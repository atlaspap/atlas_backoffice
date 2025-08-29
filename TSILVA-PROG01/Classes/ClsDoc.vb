
Imports System.Data.SqlClient
Imports System.Drawing.Printing
Imports System.Linq.Expressions
Imports System.Runtime.InteropServices.ComTypes
Imports DevExpress.Data.Async
Imports DevExpress.Utils.Behaviors
Imports DevExpress.Utils.Paint
Imports DevExpress.XtraEditors.Popup

Public Class ClsTotais
    Public Property Total_Iliquido As Decimal
    Public Property Total_Desconto As Decimal
    Public Property Total_IVA As Decimal
    Public Property Total_Doc As Decimal
    Public Property Acertos As Decimal
    Public Property Total_A_Pagar As Decimal

    Sub New()

    End Sub

    Sub New(ByRef pLinhas As List(Of ClsLinhas))
        Total_Iliquido = pLinhas.Sum(Function(x) x.Valor_Iliquido)
        Total_Desconto = pLinhas.Sum(Function(x) x.Valor_Desconto)
        Total_IVA = pLinhas.Sum(Function(x) x.Valor_IVA)
        Total_Doc = (Total_Iliquido - Total_Desconto) + Total_IVA
        Acertos = 0D
        Total_A_Pagar = Total_Doc + Acertos
    End Sub


End Class

Public Class ClsQI
    Public Property Num_Doc As String
    Public Property Tipo_IVA As String
    Public Property Taxa_IVA As Integer
    Public Property S_IVA As Decimal
    Public Property V_IVA As Decimal

    Sub New()

    End Sub

    Sub New(ByVal pTaxa_IVA As String, pLinhas As List(Of ClsLinhas))

        Dim mS_IVA As Decimal = 0D
        Dim mV_IVA As Decimal = 0D

        For Each pLinha In pLinhas
            If pLinha.Taxa_IVA = pTaxa_IVA Then

                mS_IVA += pLinha.Valor_Iliquido
                mV_IVA += pLinha.Valor_IVA

            End If
        Next

        Num_Doc = pLinhas(0).Num_Doc
        Taxa_IVA = pTaxa_IVA
        Tipo_IVA = Taxa_IVA.ToString & "% "
        S_IVA = mS_IVA
        V_IVA = mV_IVA

    End Sub


    Friend Shared Function GetQI(ByVal pLinhas As List(Of ClsLinhas)) As List(Of ClsQI)
        Dim mReturn As New List(Of ClsQI)

        Dim mLista_IVA As New List(Of ClsIVA)
        mLista_IVA = ClsIVA.GetIVA

        For Each pIVA As ClsIVA In mLista_IVA

            Dim mQI As New ClsQI(pIVA.Taxa_IVA, pLinhas)

            If mQI.S_IVA > 0D Then
                mReturn.Add(mQI)
            End If


        Next

        Return mReturn
    End Function

End Class


Public Class ClsGrava

    Shared mDB As New SqlConnection
    Shared mCMD As New SqlCommand
    Shared mTR As SqlTransaction

    Shared Function Grava_Documento(ByVal pDoc As ClsDoc, ByVal pTD As ClsTipos_Doc) As Boolean
        Dim mReturn As Boolean = True

        If pDoc.Linhas Is Nothing Then GoTo ERRO

        mDB.ConnectionString = My.Settings.Connection
        mDB.Open()
        mCMD.Connection = mDB

        mTR = mDB.BeginTransaction
        mCMD.Transaction = mTR

        '------------------------
        ' Grava_DOC
        '------------------------
        If Not Grava_Doc(pDoc) Then
            mTR.Rollback()
            GoTo ERRO
        End If

        '------------------------
        ' Grava_Linhas
        '------------------------
        Dim mStock As Integer = 0
        Dim mPreco_Compra As Decimal = 0D

        Dim mNum_Linha As Integer = -1

        Dim mLinhas As New ClsLinhas




        Dim mLinhas1 As New List(Of ClsLinhas)
        Dim mLinhas2 As New List(Of ClsLinhas)

        mLinhas1 = pDoc.Linhas
        mLinhas1 = pDoc.Linhas.FindAll(Function(x) x.Cod_Artigo.StartsWith("P") Or x.Cod_Artigo.StartsWith("S"))

        mLinhas2 = pDoc.Linhas
        mLinhas2 = pDoc.Linhas.FindAll(Function(x) x.Cod_Artigo.StartsWith("X"))


        For Each pLinha In mLinhas1.Concat(mLinhas2)


            mNum_Linha += 1
            pLinha.Num_Linha = mNum_Linha

            If Not Grava_Linhas(pLinha) Then

                mTR.Rollback()
                GoTo ERRO
            End If
            If pTD.FLG_Stock Then

                mStock = pLinha.Stock
                Select Case pTD.FLG_ESC
                    Case "E"
                        mStock += pLinha.Quantidade
                        mPreco_Compra = pLinha.P_Unitario

                    Case "S"
                        mStock -= pLinha.Quantidade
                        mPreco_Compra = 0D
                End Select

                '------------------------
                ' Grava_Artigo
                '------------------------
                If Not Atualiza_Artigo(pLinha.Cod_Artigo, mStock, mPreco_Compra) Then

                    mTR.Rollback()
                    GoTo ERRO
                End If

            End If

        Next

        '------------------------
        ' Grava_Contador
        '------------------------
        If Not Grava_Contador(pTD.Cod_Serie) Then
            mTR.Rollback()
            GoTo ERRO
        End If

        mTR.Commit()


        mDB.Close()

ERRO:

        Return mReturn
    End Function

    Shared Function Grava_Contador(ByVal pCod_Serie As String) As Boolean
        Dim mReturn As Boolean = True

        Dim mStrSQL As String


        mCMD.Parameters.Clear()
        mCMD.Parameters.AddWithValue("@pCod_Serie", pCod_Serie)


        mStrSQL = "UPDATE Series SET "

        mStrSQL += "Contador=Contador+1 "

        mStrSQL += "WHERE Cod_Serie=@pCod_Serie"

        mCMD.CommandText = mStrSQL

        Try
            mCMD.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("Grava_Contador:" + vbCrLf + "Erro ao Gravar!!!" + vbCrLf + ex.ToString)
            mReturn = False
        End Try

        Return mReturn
    End Function


    Shared Function Grava_Doc(ByVal pNovoDoc) As Boolean
        Dim mReturn As Boolean = True

        Dim mStrSQL As String

        mCMD.Parameters.Clear()

        mCMD.Parameters.AddWithValue("@pNum_Doc", pNovoDoc.Num_Doc.Substring(0, IIf(Len(pNovoDoc.Num_Doc) > 11, 11, Len(pNovoDoc.Num_Doc))))
        mCMD.Parameters.AddWithValue("@pFLG_Tipo_Doc", pNovoDoc.FLG_Tipo_Doc.Substring(0, IIf(Len(pNovoDoc.FLG_Tipo_Doc) > 3, 3, Len(pNovoDoc.FLG_Tipo_Doc))))
        mCMD.Parameters.AddWithValue("@pDesignacao", pNovoDoc.Designacao.Substring(0, IIf(Len(pNovoDoc.Designacao) > 50, 50, Len(pNovoDoc.Designacao))))
        mCMD.Parameters.AddWithValue("@pData_Doc", pNovoDoc.Data_Doc)
        mCMD.Parameters.AddWithValue("@pCod_Entidade", pNovoDoc.Cod_Entidade.Substring(0, IIf(Len(pNovoDoc.Cod_Entidade) > 5, 5, Len(pNovoDoc.Cod_Entidade))))
        mCMD.Parameters.AddWithValue("@pTaxa_Desconto", pNovoDoc.Taxa_Desconto)
        mCMD.Parameters.AddWithValue("@pData_Vencimento", pNovoDoc.Data_Vencimento)
        mCMD.Parameters.AddWithValue("@pFLG_Pago", pNovoDoc.FLG_Pago)
        mCMD.Parameters.AddWithValue("@pTipo_Pagamento", pNovoDoc.Tipo_Pagamento.Substring(0, IIf(Len(pNovoDoc.Tipo_Pagamento) > 30, 30, Len(pNovoDoc.Tipo_Pagamento))))
        mCMD.Parameters.AddWithValue("@pData_Pagamento", pNovoDoc.Data_Pagamento)
        mCMD.Parameters.AddWithValue("@pFLG_Ativo", pNovoDoc.FLG_Ativo)


        mStrSQL = "INSERT INTO Doc "
        mStrSQL += "("
        mStrSQL += "Num_Doc,"
        mStrSQL += "FLG_Tipo_Doc,"
        mStrSQL += "Designacao,"
        mStrSQL += "Data_Doc,"
        mStrSQL += "Cod_Entidade,"
        mStrSQL += "Taxa_Desconto,"
        mStrSQL += "Data_Vencimento,"
        mStrSQL += "FLG_Pago,"
        mStrSQL += "Tipo_Pagamento,"
        mStrSQL += "Data_Pagamento,"
        mStrSQL += "FLG_Ativo "
        mStrSQL += ") "
        mStrSQL += "VALUES "
        mStrSQL += "("
        mStrSQL += "@pNum_Doc,"
        mStrSQL += "@pFLG_Tipo_Doc,"
        mStrSQL += "@pDesignacao,"
        mStrSQL += "@pData_Doc,"
        mStrSQL += "@pCod_Entidade,"
        mStrSQL += "@pTaxa_Desconto,"
        mStrSQL += "@pData_Vencimento,"
        mStrSQL += "@pFLG_Pago,"
        mStrSQL += "@pTipo_Pagamento,"
        mStrSQL += "@pData_Pagamento,"
        mStrSQL += "1"
        mStrSQL += ")"

        mCMD.CommandText = mStrSQL

        Try
            mCMD.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox("Grava_Doc:" + vbCrLf + "Erro ao Gravar!!!" + vbCrLf + ex.ToString)
            mReturn = False
        End Try



        Return mReturn
    End Function

    Shared Function Grava_Linhas(ByVal pNovoLinhas As ClsLinhas) As Boolean
        Dim mReturn As Boolean = True

        Dim mStrSQL As String

        mCMD.Parameters.Clear()


        mCMD.Parameters.AddWithValue("@pNum_Doc", pNovoLinhas.Num_Doc.Substring(0, IIf(Len(pNovoLinhas.Num_Doc) > 11, 11, Len(pNovoLinhas.Num_Doc))))
        mCMD.Parameters.AddWithValue("@pNum_Linha", pNovoLinhas.Num_Linha)
        mCMD.Parameters.AddWithValue("@pCod_Artigo", pNovoLinhas.Cod_Artigo.Substring(0, IIf(Len(pNovoLinhas.Cod_Artigo) > 8, 8, Len(pNovoLinhas.Cod_Artigo))))
        mCMD.Parameters.AddWithValue("@pQuantidade", pNovoLinhas.Quantidade)
        mCMD.Parameters.AddWithValue("@pP_Unitario", pNovoLinhas.P_Unitario)
        mCMD.Parameters.AddWithValue("@pTaxa_Desconto", pNovoLinhas.Taxa_Desconto)
        mCMD.Parameters.AddWithValue("@pFLG_Ativo", pNovoLinhas.FLG_Ativo)


        mStrSQL = "INSERT INTO Linhas "
        mStrSQL += "("
        mStrSQL += "Num_Doc,"
        mStrSQL += "Num_Linha,"
        mStrSQL += "Cod_Artigo,"
        mStrSQL += "Quantidade,"
        mStrSQL += "P_Unitario,"
        mStrSQL += "Taxa_Desconto,"
        mStrSQL += "FLG_Ativo "
        mStrSQL += ") "
        mStrSQL += "VALUES "
        mStrSQL += "("
        mStrSQL += "@pNum_Doc,"
        mStrSQL += "@pNum_Linha,"
        mStrSQL += "@pCod_Artigo,"
        mStrSQL += "@pQuantidade,"
        mStrSQL += "@pP_Unitario,"
        mStrSQL += "@pTaxa_Desconto,"
        mStrSQL += "1"
        mStrSQL += ")"


        mCMD.CommandText = mStrSQL


        Try
            mCMD.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox("Grava_Linhas:" + vbCrLf + "Erro ao Gravar!!!" + vbCrLf + ex.ToString)
            mReturn = False
        End Try


        Return mReturn
    End Function

    Shared Function Atualiza_Artigo(ByVal pCod_Artigo As String, ByVal pStock As Integer, ByVal pPreco_Compra As Decimal) As Boolean
        Dim mReturn As Boolean = True

        Dim mStrSQL As String

        mCMD.Parameters.Clear()
        mCMD.Parameters.AddWithValue("@pCod_Artigo", pCod_Artigo)

        mCMD.Parameters.AddWithValue("@pStock", pStock)
        mCMD.Parameters.AddWithValue("@pPreco_Compra", pPreco_Compra)

        mCMD.Parameters.AddWithValue("@pData_Ultima_Entrada", Date.Now)
        mCMD.Parameters.AddWithValue("@pData_Ultima_Venda", Date.Now)


        mStrSQL = "UPDATE Artigos SET "

        mStrSQL += "Stock=@pStock,"
        If pPreco_Compra <> 0D Then
            mStrSQL += "Preco_Compra=@pPreco_Compra,"
            mStrSQL += "Data_Ultima_Entrada=@pData_Ultima_Entrada "
        Else
            mStrSQL += "Data_Ultima_Venda=@pData_Ultima_Venda "
        End If

        mStrSQL += "WHERE Cod_Artigo=@pCod_Artigo"

        mCMD.CommandText = mStrSQL

        Try
            mCMD.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("Atualiza_Artigo:" + vbCrLf + "Erro ao Gravar!!!" + vbCrLf + ex.ToString)
            mReturn = False
        End Try

        Return mReturn

    End Function

End Class

''' <summary>
'''      Classe ClsDoc Classe da Tabela Doc
'''      Gerado em 08/10/2024 13:36:11
''' </summary>
''' <remarks>
'''      (c) ETLA - PM-2024
''' </remarks>
Public Class ClsDoc


    ' -----------------------------------------
    ' Property's da tabela Doc
    ' -----------------------------------------

    Public Property Num_Doc As String                                       ' Len: 11 - SQL_Type: nvarchar
    Public Property FLG_Tipo_Doc As String                                  ' Len:  3 - SQL_Type: nvarchar
    Public Property Designacao As String                                    ' Len: 50 - SQL_Type: nvarchar
    Public Property Data_Doc As Date                                        ' SQL_Type: smalldatetime
    Public Property Cod_Entidade As String                                  ' Len:  5 - SQL_Type: nvarchar
    Public ReadOnly Property Nome As String
        Get
            Return If(Cod_Entidade = "", "", ClsEntidades.GetEntidadesByCod(Cod_Entidade).Nome)
        End Get
    End Property
    Public Property Taxa_Desconto As Integer                                ' SQL_Type: smallint
    Public Property Data_Vencimento As Date                                 ' SQL_Type: smalldatetime
    Public Property FLG_Pago As Boolean                                     ' SQL_Type: bit
    Public Property Tipo_Pagamento As String                                ' Len: 30 - SQL_Type: nvarchar
    Public Property Data_Pagamento As Date                                  ' SQL_Type: smalldatetime

    Public ReadOnly Property Entidade As ClsEntidades
        Get
            Return ClsEntidades.GetEntidadesByCod(Cod_Entidade)
        End Get
    End Property

    Public ReadOnly Property Empresa As ClsEmpresas
        Get
            Return ClsEmpresas.GetEmpresasByCod("1")
        End Get
    End Property


    Public Property Linhas As List(Of ClsLinhas)

    Public Property Totais As ClsTotais

    Public Property QI As List(Of ClsQI)


    Public Property FLG_Ativo As Boolean                                    ' SQL_Type: bit


    Sub New()
    End Sub

    Sub New(ByVal pTD As ClsTipos_Doc)

        FLG_Tipo_Doc = pTD.FLG_Tipo_Doc

        Num_Doc = FLG_Tipo_Doc & (pTD.Contador + 1).ToString("000") & "/" & pTD.Cod_Serie.Substring(0, 4)

        Designacao = pTD.Descritivo_Impressao & ""
        Data_Doc = Date.Now
        Taxa_Desconto = 0
        Data_Vencimento = Data_Doc
        Data_Pagamento = Data_Doc
        Tipo_Pagamento = ""
        FLG_Pago = False

        Linhas = ClsLinhas.Init_Linhas(Num_Doc)

        FLG_Ativo = True
    End Sub


    '--------------------------------------------
    ' Exemplo de criador de Código por contador
    ' Para ser usado no caso de o Cdigo ser gerado
    ' e o contador existir na tabela Empresas
    '---------------------------------------------

    'Friend Shared Function GetNovoCodigo() As String

    'Return "D" & ClsEmpresas.GetContador(enCont.Doc).ToString("000")' <-------------- VERIFICAR O Nº de ZEROS

    'End Function


    ''' <summary>
    '''      Function GetDoc() Método para devolver a Lista de Doc
    '''      Gerado em 08/10/2024 13:36:11
    ''' </summary>
    ''' <returns>
    '''      mListaDoc
    ''' </returns>
    ''' <remarks>
    '''      (c) ETLA - PM-2024
    ''' </remarks>
    Public Shared Function GetDoc() As List(Of ClsDoc)
        Dim mListaDoc As New List(Of ClsDoc)

        Dim mStrSQL As String
        Dim mDB As New SqlConnection
        Dim mCMD As New SqlCommand
        Dim mRDR As SqlDataReader

        mDB.ConnectionString = My.Settings.Connection
        mCMD.Parameters.Clear()

        mStrSQL = "SELECT "
        mStrSQL += "ISNULL(Num_Doc,'') As Num_Doc,"
        mStrSQL += "ISNULL(FLG_Tipo_Doc,'') As FLG_Tipo_Doc,"
        mStrSQL += "ISNULL(Designacao,'') As Designacao,"
        mStrSQL += "ISNULL(Data_Doc,0) As Data_Doc,"
        mStrSQL += "ISNULL(Cod_Entidade,'') As Cod_Entidade,"
        mStrSQL += "ISNULL(Taxa_Desconto,0) As Taxa_Desconto,"
        mStrSQL += "ISNULL(Data_Vencimento,0) As Data_Vencimento,"
        mStrSQL += "ISNULL(FLG_Pago,1) As FLG_Pago,"
        mStrSQL += "ISNULL(Tipo_Pagamento,'') As Tipo_Pagamento,"
        mStrSQL += "ISNULL(Data_Pagamento,0) As Data_Pagamento,"
        mStrSQL += "ISNULL(FLG_Ativo,1) As FLG_Ativo "
        mStrSQL += "FROM Doc "
        mStrSQL += "WHERE FLG_Ativo=1"


        mCMD.CommandText = mStrSQL
        mDB.Open()
        mCMD.Connection = mDB

        mRDR = mCMD.ExecuteReader

        While mRDR.Read()

            Dim mClsDoc As New ClsDoc

            With mClsDoc
                .Num_Doc = mRDR.GetString(mRDR.GetOrdinal("Num_Doc"))
                .FLG_Tipo_Doc = mRDR.GetString(mRDR.GetOrdinal("FLG_Tipo_Doc"))
                .Designacao = mRDR.GetString(mRDR.GetOrdinal("Designacao"))
                .Data_Doc = mRDR.GetDateTime(mRDR.GetOrdinal("Data_Doc"))
                .Cod_Entidade = mRDR.GetString(mRDR.GetOrdinal("Cod_Entidade"))
                .Taxa_Desconto = mRDR.GetValue(mRDR.GetOrdinal("Taxa_Desconto"))
                .Data_Vencimento = mRDR.GetDateTime(mRDR.GetOrdinal("Data_Vencimento"))
                .FLG_Pago = mRDR.GetBoolean(mRDR.GetOrdinal("FLG_Pago"))
                .Tipo_Pagamento = mRDR.GetString(mRDR.GetOrdinal("Tipo_Pagamento"))
                .Data_Pagamento = mRDR.GetDateTime(mRDR.GetOrdinal("Data_Pagamento"))
                .FLG_Ativo = mRDR.GetBoolean(mRDR.GetOrdinal("FLG_Ativo"))
            End With


            mListaDoc.Add(mClsDoc)

        End While

        mRDR.Close()
        mDB.Close()

        Return mListaDoc
    End Function


    ''' <summary>
    '''      Function GetDocByCod(ByVal pNum_Doc As String) Método para decolver uma Classe de Doc
    '''      Gerado em 08/10/2024 13:36:11
    ''' </summary>
    ''' <returns>
    '''      mClsDoc
    ''' </returns>
    ''' <remarks>
    '''      (c) ETLA - PM-2024
    ''' </remarks>
    Public Shared Function GetDocByCod(ByVal pNum_Doc As String) As ClsDoc
        Dim mClsDoc As New ClsDoc

        Dim mStrSQL As String
        Dim mDB As New SqlConnection
        Dim mCMD As New SqlCommand
        Dim mRDR As SqlDataReader
        Dim mFLG_Entidade As String = "C"

        mDB.ConnectionString = My.Settings.Connection
        mCMD.Parameters.Clear()
        mCMD.Parameters.AddWithValue("@pNum_Doc", pNum_Doc)


        mStrSQL = "SELECT "
        mStrSQL += "ISNULL(Num_Doc,'') As Num_Doc,"
        mStrSQL += "ISNULL(FLG_Tipo_Doc,'') As FLG_Tipo_Doc,"
        mStrSQL += "ISNULL(Designacao,'') As Designacao,"
        mStrSQL += "ISNULL(Data_Doc,0) As Data_Doc,"
        mStrSQL += "ISNULL(Cod_Entidade,'') As Cod_Entidade,"
        mStrSQL += "ISNULL(Taxa_Desconto,0) As Taxa_Desconto,"
        mStrSQL += "ISNULL(Data_Vencimento,0) As Data_Vencimento,"
        mStrSQL += "ISNULL(FLG_Pago,1) As FLG_Pago,"
        mStrSQL += "ISNULL(Tipo_Pagamento,'') As Tipo_Pagamento,"
        mStrSQL += "ISNULL(Data_Pagamento,0) As Data_Pagamento,"
        mStrSQL += "ISNULL(FLG_Ativo,1) As FLG_Ativo "
        mStrSQL += "FROM Doc "
        mStrSQL += "WHERE FLG_Ativo=1 "
        mStrSQL += "AND Num_Doc=@pNum_Doc"


        mCMD.CommandText = mStrSQL
        mDB.Open()
        mCMD.Connection = mDB

        mRDR = mCMD.ExecuteReader

        If mRDR.Read() Then


            With mClsDoc

                .Num_Doc = mRDR.GetString(mRDR.GetOrdinal("Num_Doc"))
                .FLG_Tipo_Doc = mRDR.GetString(mRDR.GetOrdinal("FLG_Tipo_Doc"))
                .Designacao = mRDR.GetString(mRDR.GetOrdinal("Designacao"))
                .Data_Doc = mRDR.GetDateTime(mRDR.GetOrdinal("Data_Doc"))
                .Cod_Entidade = mRDR.GetString(mRDR.GetOrdinal("Cod_Entidade"))

                mFLG_Entidade = .Cod_Entidade.Substring(0, 1)

                .Taxa_Desconto = mRDR.GetValue(mRDR.GetOrdinal("Taxa_Desconto"))
                .Data_Vencimento = mRDR.GetDateTime(mRDR.GetOrdinal("Data_Vencimento"))
                .FLG_Pago = mRDR.GetBoolean(mRDR.GetOrdinal("FLG_Pago"))
                .Tipo_Pagamento = mRDR.GetString(mRDR.GetOrdinal("Tipo_Pagamento"))
                .Data_Pagamento = mRDR.GetDateTime(mRDR.GetOrdinal("Data_Pagamento"))
                .FLG_Ativo = mRDR.GetBoolean(mRDR.GetOrdinal("FLG_Ativo"))

                .Linhas = ClsLinhas.GetLinhas(.Num_Doc, mFLG_Entidade)

                .Totais = New ClsTotais(.Linhas)
                .QI = ClsQI.GetQI(.Linhas)
            End With

        End If
        mRDR.Close()
        mDB.Close()

        Return mClsDoc
    End Function


    ''' <summary>
    '''      Function ModificaDoc(ByVal pClsDoc As ClsDoc) Método para Modificar a TABELA Doc
    '''      Gerado em 08/10/2024 13:36:11
    ''' </summary>
    ''' <returns>
    '''      Boolean
    ''' </returns>
    ''' <remarks>
    '''      (c) ETLA - PM-2024
    ''' </remarks>
    Public Shared Function ModificaDoc(ByVal pClsDoc As ClsDoc) As Boolean
        Dim mReturn As Boolean = True

        Dim mStrSQL As String
        Dim mDB As New SqlConnection
        Dim mCMD As New SqlCommand

        mCMD.Parameters.Clear()
        mCMD.Parameters.AddWithValue("@pNum_Doc", pClsDoc.Num_Doc.Substring(0, IIf(Len(pClsDoc.Num_Doc) > 11, 11, Len(pClsDoc.Num_Doc))))
        mCMD.Parameters.AddWithValue("@pFLG_Tipo_Doc", pClsDoc.FLG_Tipo_Doc.Substring(0, IIf(Len(pClsDoc.FLG_Tipo_Doc) > 3, 3, Len(pClsDoc.FLG_Tipo_Doc))))
        mCMD.Parameters.AddWithValue("@pDesignacao", pClsDoc.Designacao.Substring(0, IIf(Len(pClsDoc.Designacao) > 50, 50, Len(pClsDoc.Designacao))))
        mCMD.Parameters.AddWithValue("@pData_Doc", pClsDoc.Data_Doc)
        mCMD.Parameters.AddWithValue("@pCod_Entidade", pClsDoc.Cod_Entidade.Substring(0, IIf(Len(pClsDoc.Cod_Entidade) > 5, 5, Len(pClsDoc.Cod_Entidade))))
        mCMD.Parameters.AddWithValue("@pTaxa_Desconto", pClsDoc.Taxa_Desconto)
        mCMD.Parameters.AddWithValue("@pData_Vencimento", pClsDoc.Data_Vencimento)
        mCMD.Parameters.AddWithValue("@pFLG_Pago", pClsDoc.FLG_Pago)
        mCMD.Parameters.AddWithValue("@pTipo_Pagamento", pClsDoc.Tipo_Pagamento.Substring(0, IIf(Len(pClsDoc.Tipo_Pagamento) > 30, 30, Len(pClsDoc.Tipo_Pagamento))))
        mCMD.Parameters.AddWithValue("@pData_Pagamento", pClsDoc.Data_Pagamento)


        mStrSQL = "UPDATE Doc SET "
        mStrSQL += "FLG_Tipo_Doc=@pFLG_Tipo_Doc,"
        mStrSQL += "Designacao=@pDesignacao,"
        mStrSQL += "Data_Doc=@pData_Doc,"
        mStrSQL += "Cod_Entidade=@pCod_Entidade,"
        mStrSQL += "Taxa_Desconto=@pTaxa_Desconto,"
        mStrSQL += "Data_Vencimento=@pData_Vencimento,"
        mStrSQL += "FLG_Pago=@pFLG_Pago,"
        mStrSQL += "Tipo_Pagamento=@pTipo_Pagamento,"
        mStrSQL += "Data_Pagamento=@pData_Pagamento "
        mStrSQL += "WHERE Num_Doc=@pNum_Doc"


        mDB.ConnectionString = My.Settings.Connection
        mCMD.CommandText = mStrSQL
        mDB.Open()
        mCMD.Connection = mDB

        Try
            mCMD.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("ModificaDoc:" + vbCrLf + "Erro ao Gravar!!!" + vbCrLf + ex.ToString)
            mReturn = False
        End Try

        mDB.Close()

        Return mReturn

    End Function


    ''' <summary>
    '''      Function GravaDoc(ByVal pNovoDoc As ClsDoc) Método para Gravar a TABELA Doc
    '''      Gerado em 08/10/2024 13:36:11
    ''' </summary>
    ''' <returns>
    '''      Boolean
    ''' </returns>
    ''' <remarks>
    '''      (c) ETLA - PM-2024
    ''' </remarks>
    Public Shared Function GravaDoc(ByVal pNovoDoc As ClsDoc) As Boolean
        Dim mReturn As Boolean = True

        Dim mStrSQL As String
        Dim mDB As New SqlConnection
        Dim mCMD As New SqlCommand

        mDB.ConnectionString = My.Settings.Connection
        mCMD.Parameters.Clear()


        mCMD.Parameters.AddWithValue("@pNum_Doc", pNovoDoc.Num_Doc.Substring(0, IIf(Len(pNovoDoc.Num_Doc) > 11, 11, Len(pNovoDoc.Num_Doc))))
        mCMD.Parameters.AddWithValue("@pFLG_Tipo_Doc", pNovoDoc.FLG_Tipo_Doc.Substring(0, IIf(Len(pNovoDoc.FLG_Tipo_Doc) > 3, 3, Len(pNovoDoc.FLG_Tipo_Doc))))
        mCMD.Parameters.AddWithValue("@pDesignacao", pNovoDoc.Designacao.Substring(0, IIf(Len(pNovoDoc.Designacao) > 50, 50, Len(pNovoDoc.Designacao))))
        mCMD.Parameters.AddWithValue("@pData_Doc", pNovoDoc.Data_Doc)
        mCMD.Parameters.AddWithValue("@pCod_Entidade", pNovoDoc.Cod_Entidade.Substring(0, IIf(Len(pNovoDoc.Cod_Entidade) > 5, 5, Len(pNovoDoc.Cod_Entidade))))
        mCMD.Parameters.AddWithValue("@pTaxa_Desconto", pNovoDoc.Taxa_Desconto)
        mCMD.Parameters.AddWithValue("@pData_Vencimento", pNovoDoc.Data_Vencimento)
        mCMD.Parameters.AddWithValue("@pFLG_Pago", pNovoDoc.FLG_Pago)
        mCMD.Parameters.AddWithValue("@pTipo_Pagamento", pNovoDoc.Tipo_Pagamento.Substring(0, IIf(Len(pNovoDoc.Tipo_Pagamento) > 30, 30, Len(pNovoDoc.Tipo_Pagamento))))
        mCMD.Parameters.AddWithValue("@pData_Pagamento", pNovoDoc.Data_Pagamento)
        mCMD.Parameters.AddWithValue("@pFLG_Ativo", pNovoDoc.FLG_Ativo)


        mStrSQL = "INSERT INTO Doc "
        mStrSQL += "("
        mStrSQL += "Num_Doc,"
        mStrSQL += "FLG_Tipo_Doc,"
        mStrSQL += "Designacao,"
        mStrSQL += "Data_Doc,"
        mStrSQL += "Cod_Entidade,"
        mStrSQL += "Taxa_Desconto,"
        mStrSQL += "Data_Vencimento,"
        mStrSQL += "FLG_Pago,"
        mStrSQL += "Tipo_Pagamento,"
        mStrSQL += "Data_Pagamento,"
        mStrSQL += "FLG_Ativo "
        mStrSQL += ") "
        mStrSQL += "VALUES "
        mStrSQL += "("
        mStrSQL += "@pNum_Doc,"
        mStrSQL += "@pFLG_Tipo_Doc,"
        mStrSQL += "@pDesignacao,"
        mStrSQL += "@pData_Doc,"
        mStrSQL += "@pCod_Entidade,"
        mStrSQL += "@pTaxa_Desconto,"
        mStrSQL += "@pData_Vencimento,"
        mStrSQL += "@pFLG_Pago,"
        mStrSQL += "@pTipo_Pagamento,"
        mStrSQL += "@pData_Pagamento,"
        mStrSQL += "1"
        mStrSQL += ")"


        mCMD.CommandText = mStrSQL
        mDB.Open()
        mCMD.Connection = mDB

        Try
            mCMD.ExecuteNonQuery()
            'ClsEmpresas.GravaContador(enCont.Doc)'<<<<-------- Verificar se é  preciso...
        Catch ex As Exception
            MsgBox("GravaDoc:" + vbCrLf + "Erro ao Gravar!!!" + vbCrLf + ex.ToString)
            mReturn = False
        End Try

        mDB.Close()

        Return mReturn

    End Function


    ''' <summary>
    '''      Function ApagaDoc(ByVal pNum_Doc As String) Método para Apagar um Registo da Tabela Doc
    '''      Gerado em 08/10/2024 13:36:11
    ''' </summary>
    ''' <returns>
    '''      Boolean
    ''' </returns>
    ''' <remarks>
    '''      (c) ETLA - PM-2024
    ''' </remarks>
    Public Shared Function ApagaDoc(ByVal pNum_Doc As String) As Boolean
        Dim mReturn As Boolean = True

        Dim mStrSQL As String
        Dim mDB As New SqlConnection
        Dim mCMD As New SqlCommand

        mCMD.Parameters.Clear()

        mCMD.Parameters.AddWithValue("@pNum_Doc", pNum_Doc)


        mStrSQL = "UPDATE Doc SET "
        mStrSQL += "FLG_Ativo=0 "
        mStrSQL += "WHERE Num_Doc=@pNum_Doc"


        mDB.ConnectionString = My.Settings.Connection
        mCMD.CommandText = mStrSQL
        mDB.Open()
        mCMD.Connection = mDB

        Try
            mCMD.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("ApagaDoc:" + vbCrLf + "Erro ao Gravar!!!" + vbCrLf + ex.ToString)
            mReturn = False
        End Try

        mDB.Close()

        Return mReturn

    End Function
End Class

