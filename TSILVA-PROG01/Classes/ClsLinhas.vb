
Imports System.Data.SqlClient
Imports DevExpress.Utils.Extensions


''' <summary>
'''      Classe ClsLinhas Classe da Tabela Linhas
'''      Gerado em 08/10/2024 13:36:11
''' </summary>
''' <remarks>
'''      (c) ETLA - PM-2024
''' </remarks>
Public Class ClsLinhas


    ' -----------------------------------------
    ' Property's da tabela Linhas
    ' -----------------------------------------

    Public Property Num_Doc As String                                       ' Len: 11 - SQL_Type: nvarchar

    Public FLG_Entidade As String

    Public Num_Linha As Integer                                             ' SQL_Type: smallint

    Public ReadOnly Property sNum_Linha As String
        Get
            Return (Num_Linha + 1).ToString("00")
        End Get
    End Property


    Public Property Cod_Artigo As String                                    ' Len:  8 - SQL_Type: nvarchar

    Private cArtigo As ViewArt

    Private _Artigo As String
    Public Property Artigo As String
        Get
            Return If(Cod_Artigo = "", "", cArtigo.Artigo)
        End Get
        Set(value As String)
            _Artigo = value
        End Set
    End Property
    Public Property Quantidade As Integer                                 ' SQL_Type: smallint
    Public Property sQTD As String

    Public _P_Unitario As Decimal
    Public Property P_Unitario As Decimal                                   ' SQL_Type: numeric
        Get
            Return If(Cod_Artigo = "", 0D, cArtigo.Preco_Unitario)
        End Get
        Set(value As Decimal)
            _P_Unitario = value ' _sP_Unitario
        End Set
    End Property

    Public _sP_Unitario As String
    Public Property sP_Unitario As String
        Get
            sP_Unitario = If(Cod_Artigo = "", "", FormatCurrency(P_Unitario.ToString))
        End Get
        Set(value As String)
            P_Unitario = value
        End Set
    End Property

    Public Property Taxa_Desconto As Integer                          ' SQL_Type: smallint
    Public Property sTaxa_Desconto As String

    Public ReadOnly Property Taxa_IVA As Integer
        Get
            Return If(Cod_Artigo = "", 0, cArtigo.Taxa_IVA)
        End Get
    End Property

    Public ReadOnly Property sTaxa_IVA As String
        Get
            Return If(Cod_Artigo = "", "", Taxa_IVA.ToString("00"))
        End Get
    End Property

    Public ReadOnly Property Valor_Iliquido As Decimal
        Get
            Return If(Cod_Artigo = "", 0D, Quantidade * P_Unitario)
        End Get
    End Property

    Public ReadOnly Property sValor_Iliquido As String
        Get
            Return If(Cod_Artigo = "", "", FormatCurrency(Valor_Iliquido.ToString))
        End Get
    End Property

    Public ReadOnly Property Valor_Desconto As Decimal
        Get
            Return If(Cod_Artigo = "", 0D, Valor_Iliquido * (Taxa_Desconto / 100))
        End Get
    End Property

    Public ReadOnly Property Valor_IVA As Decimal
        Get
            Return If(Cod_Artigo = "", 0D, (Valor_Iliquido - Valor_Desconto) * (Taxa_IVA / 100))
        End Get
    End Property

    Public ReadOnly Property FLG_Feita As Boolean
        Get
            Return If(Cod_Artigo = "", False, True)
        End Get
    End Property

    Public ReadOnly Property Stock As Integer
        Get
            Return If(Cod_Artigo = "", 0, cArtigo.Stock)
        End Get
    End Property

    Public Property Index_Artigo As Integer

    Public Property FLG_Ativo As Boolean = True                                   ' SQL_Type: bit


    Sub New()
    End Sub

    ''' <summary>
    ''' Construtor que serve para Inicializar as linhas
    ''' </summary>
    ''' <param name="pNum_Doc"></param>
    ''' <param name="pLinha"></param>
    Sub New(pNum_Doc As String, pLinha As Integer)

        Num_Doc = pNum_Doc
        Num_Linha = pLinha
        Cod_Artigo = ""
        Artigo = ""
        Quantidade = 0
        Index_Artigo = -1
        sQTD = ""
        Taxa_Desconto = 0
        sTaxa_Desconto = ""
        FLG_Entidade = "C"
    End Sub


    ''' <summary>
    ''' AFTER ARTIGO QTD PUNITARIO e DSC
    ''' </summary>
    ''' <param name="pNum_Doc"></param>
    ''' <param name="pLinha"></param>
    ''' <param name="pQTD"></param>
    ''' <param name="pPreco"></param>
    ''' <param name="pDSC"></param>
    ''' <param name="pListaVA"></param>
    ''' <param name="pIndex_Artigo"></param>
    Sub New(ByVal pNum_Doc As String, ByVal pLinha As String, ByVal pQTD As Integer, ByVal pPreco As Decimal, ByVal pDSC As Integer, ByRef pListaVA As List(Of ViewArt), pIndex_Artigo As Integer)

        Num_Doc = pNum_Doc
        Num_Linha = pLinha
        Index_Artigo = pIndex_Artigo
        cArtigo = pListaVA(pIndex_Artigo)
        Cod_Artigo = cArtigo.Cod_Artigo
        FLG_Entidade = cArtigo.FLG_Entidade
        '-------------------------------
        Quantidade = pQTD
        sQTD = Quantidade.ToString
        Taxa_Desconto = pDSC
        sTaxa_Desconto = Taxa_Desconto.ToString
        P_Unitario = pPreco
        sP_Unitario = pPreco.ToString

    End Sub

    Public Shared Function Init_Linhas(ByVal pNum_Doc As String) As List(Of ClsLinhas)
        Dim mReturn As New List(Of ClsLinhas)

        For n As Integer = 0 To My.Settings.MAX_LINHAS - 1
            Dim mLinha As New ClsLinhas(pNum_Doc, n)
            mReturn.Add(mLinha)
        Next

        Return mReturn
    End Function


    '--------------------------------------------
    ' Exemplo de criador de Código por contador
    ' Para ser usado no caso de o Cdigo ser gerado
    ' e o contador existir na tabela Empresas
    '---------------------------------------------

    'Friend Shared Function GetNovoCodigo() As String

    'Return "L" & ClsEmpresas.GetContador(enCont.Linhas).ToString("000")' <-------------- VERIFICAR O Nº de ZEROS

    'End Function


    ''' <summary>
    '''      Function GetLinhas() Método para devolver a Lista de Linhas
    '''      Gerado em 08/10/2024 13:36:11
    ''' </summary>
    ''' <returns>
    '''      mListaLinhas
    ''' </returns>
    ''' <remarks>
    '''      (c) ETLA - PM-2024
    ''' </remarks>
    Public Shared Function GetLinhas(ByVal pNum_Doc As String, ByVal pFLG_Entidade As String) As List(Of ClsLinhas)
        Dim mListaLinhas As New List(Of ClsLinhas)

        Dim mStrSQL As String
        Dim mDB As New SqlConnection
        Dim mCMD As New SqlCommand
        Dim mRDR As SqlDataReader

        mDB.ConnectionString = My.Settings.Connection
        mCMD.Parameters.Clear()
        mCMD.Parameters.AddWithValue("@pNum_Doc", pNum_Doc)

        mStrSQL = "SELECT "
        mStrSQL += "ISNULL(Num_Doc,'') As Num_Doc,"
        mStrSQL += "ISNULL(Num_Linha,0) As Num_Linha,"
        mStrSQL += "ISNULL(Cod_Artigo,'') As Cod_Artigo,"
        mStrSQL += "ISNULL(Quantidade,0) As Quantidade,"
        mStrSQL += "ISNULL(P_Unitario,0) As P_Unitario,"
        mStrSQL += "ISNULL(Taxa_Desconto,0) As Taxa_Desconto,"
        mStrSQL += "ISNULL(FLG_Ativo,1) As FLG_Ativo "
        mStrSQL += "FROM Linhas "
        mStrSQL += "WHERE FLG_Ativo=1 AND Num_Doc=@pNum_Doc"


        mCMD.CommandText = mStrSQL
        mDB.Open()
        mCMD.Connection = mDB

        mRDR = mCMD.ExecuteReader

        While mRDR.Read()

            Dim mClsLinhas As New ClsLinhas

            With mClsLinhas


                .Num_Doc = mRDR.GetString(mRDR.GetOrdinal("Num_Doc"))
                .Num_Linha = mRDR.GetValue(mRDR.GetOrdinal("Num_Linha"))
                .Cod_Artigo = mRDR.GetString(mRDR.GetOrdinal("Cod_Artigo"))
                .Quantidade = mRDR.GetValue(mRDR.GetOrdinal("Quantidade"))
                .P_Unitario = mRDR.GetDecimal(mRDR.GetOrdinal("P_Unitario"))
                .Taxa_Desconto = mRDR.GetValue(mRDR.GetOrdinal("Taxa_Desconto"))
                .FLG_Ativo = mRDR.GetBoolean(mRDR.GetOrdinal("FLG_Ativo"))
                .cArtigo = ViewArt.GetViewArtByCod(.Cod_Artigo, pFLG_Entidade)

                .sQTD = .Quantidade.ToString
                .sTaxa_Desconto = .Taxa_Desconto.ToString
            End With


            mListaLinhas.Add(mClsLinhas)

        End While

        Dim mNum_Linhas As Integer = mListaLinhas.Count + 1

        Dim nNum As Integer = 0

        For nNum = mNum_Linhas To My.Settings.MAX_LINHAS
            Dim mLinha As New ClsLinhas

            mLinha = New ClsLinhas(pNum_Doc, nNum)

            mListaLinhas.Add(mLinha)
        Next



        mRDR.Close()
        mDB.Close()

        Return mListaLinhas
    End Function


    ''' <summary>
    '''      Function GetLinhasByCod(ByVal pNum_Doc As String) Método para decolver uma Classe de Linhas
    '''      Gerado em 08/10/2024 13:36:11
    ''' </summary>
    ''' <returns>
    '''      mClsLinhas
    ''' </returns>
    ''' <remarks>
    '''      (c) ETLA - PM-2024
    ''' </remarks>
    Public Shared Function GetLinhasByCod(ByVal pNum_Doc As String) As ClsLinhas
        Dim mClsLinhas As New ClsLinhas

        Dim mStrSQL As String
        Dim mDB As New SqlConnection
        Dim mCMD As New SqlCommand
        Dim mRDR As SqlDataReader

        mDB.ConnectionString = My.Settings.Connection
        mCMD.Parameters.Clear()
        mCMD.Parameters.AddWithValue("@pNum_Doc", pNum_Doc)


        mStrSQL = "SELECT "
        mStrSQL += "ISNULL(Num_Doc,'') As Num_Doc,"
        mStrSQL += "ISNULL(Num_Linha,0) As Num_Linha,"
        mStrSQL += "ISNULL(Cod_Artigo,'') As Cod_Artigo,"
        mStrSQL += "ISNULL(Quantidade,0) As Quantidade,"
        mStrSQL += "ISNULL(P_Unitario,0) As P_Unitario,"
        mStrSQL += "ISNULL(Taxa_Desconto,0) As Taxa_Desconto,"
        mStrSQL += "ISNULL(FLG_Ativo,1) As FLG_Ativo "
        mStrSQL += "FROM Linhas "
        mStrSQL += "WHERE FLG_Ativo=1 "
        mStrSQL += "AND Num_Doc=@pNum_Doc"


        mCMD.CommandText = mStrSQL
        mDB.Open()
        mCMD.Connection = mDB

        mRDR = mCMD.ExecuteReader

        If mRDR.Read() Then


            With mClsLinhas
                .Num_Doc = mRDR.GetString(mRDR.GetOrdinal("Num_Doc"))
                .Num_Linha = mRDR.GetValue(mRDR.GetOrdinal("Num_Linha"))
                .Cod_Artigo = mRDR.GetString(mRDR.GetOrdinal("Cod_Artigo"))
                .Quantidade = mRDR.GetValue(mRDR.GetOrdinal("Quantidade"))
                .P_Unitario = mRDR.GetDecimal(mRDR.GetOrdinal("P_Unitario"))
                .Taxa_Desconto = mRDR.GetValue(mRDR.GetOrdinal("Taxa_Desconto"))
                .FLG_Ativo = mRDR.GetBoolean(mRDR.GetOrdinal("FLG_Ativo"))
            End With


        End If
        mRDR.Close()
        mDB.Close()

        Return mClsLinhas
    End Function


    ''' <summary>
    '''      Function ModificaLinhas(ByVal pClsLinhas As ClsLinhas) Método para Modificar a TABELA Linhas
    '''      Gerado em 08/10/2024 13:36:11
    ''' </summary>
    ''' <returns>
    '''      Boolean
    ''' </returns>
    ''' <remarks>
    '''      (c) ETLA - PM-2024
    ''' </remarks>
    Public Shared Function ModificaLinhas(ByVal pClsLinhas As ClsLinhas) As Boolean
        Dim mReturn As Boolean = True

        Dim mStrSQL As String
        Dim mDB As New SqlConnection
        Dim mCMD As New SqlCommand

        mCMD.Parameters.Clear()
        mCMD.Parameters.AddWithValue("@pNum_Doc", pClsLinhas.Num_Doc.Substring(0, IIf(Len(pClsLinhas.Num_Doc) > 11, 11, Len(pClsLinhas.Num_Doc))))
        mCMD.Parameters.AddWithValue("@pNum_Linha", pClsLinhas.Num_Linha)
        mCMD.Parameters.AddWithValue("@pCod_Artigo", pClsLinhas.Cod_Artigo.Substring(0, IIf(Len(pClsLinhas.Cod_Artigo) > 8, 8, Len(pClsLinhas.Cod_Artigo))))
        mCMD.Parameters.AddWithValue("@pQuantidade", pClsLinhas.Quantidade)
        mCMD.Parameters.AddWithValue("@pP_Unitario", pClsLinhas.P_Unitario)
        mCMD.Parameters.AddWithValue("@pTaxa_Desconto", pClsLinhas.Taxa_Desconto)


        mStrSQL = "UPDATE Linhas SET "
        mStrSQL += "Num_Linha=@pNum_Linha,"
        mStrSQL += "Cod_Artigo=@pCod_Artigo,"
        mStrSQL += "Quantidade=@pQuantidade,"
        mStrSQL += "P_Unitario=@pP_Unitario,"
        mStrSQL += "Taxa_Desconto=@pTaxa_Desconto "
        mStrSQL += "WHERE Num_Doc=@pNum_Doc"


        mDB.ConnectionString = My.Settings.Connection
        mCMD.CommandText = mStrSQL
        mDB.Open()
        mCMD.Connection = mDB

        Try
            mCMD.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("ModificaLinhas:" + vbCrLf + "Erro ao Gravar!!!" + vbCrLf + ex.ToString)
            mReturn = False
        End Try

        mDB.Close()

        Return mReturn

    End Function


    ''' <summary>
    '''      Function GravaLinhas(ByVal pNovoLinhas As ClsLinhas) Método para Gravar a TABELA Linhas
    '''      Gerado em 08/10/2024 13:36:11
    ''' </summary>
    ''' <returns>
    '''      Boolean
    ''' </returns>
    ''' <remarks>
    '''      (c) ETLA - PM-2024
    ''' </remarks>
    Public Shared Function GravaLinhas(ByVal pNovoLinhas As ClsLinhas) As Boolean
        Dim mReturn As Boolean = True

        Dim mStrSQL As String
        Dim mDB As New SqlConnection
        Dim mCMD As New SqlCommand

        mDB.ConnectionString = My.Settings.Connection
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
        mDB.Open()
        mCMD.Connection = mDB

        Try
            mCMD.ExecuteNonQuery()
            'ClsEmpresas.GravaContador(enCont.Linhas)'<<<<-------- Verificar se é  preciso...
        Catch ex As Exception
            MsgBox("GravaLinhas:" + vbCrLf + "Erro ao Gravar!!!" + vbCrLf + ex.ToString)
            mReturn = False
        End Try

        mDB.Close()

        Return mReturn

    End Function


    ''' <summary>
    '''      Function ApagaLinhas(ByVal pNum_Doc As String) Método para Apagar um Registo da Tabela Linhas
    '''      Gerado em 08/10/2024 13:36:11
    ''' </summary>
    ''' <returns>
    '''      Boolean
    ''' </returns>
    ''' <remarks>
    '''      (c) ETLA - PM-2024
    ''' </remarks>
    Public Shared Function ApagaLinhas(ByVal pNum_Doc As String) As Boolean
        Dim mReturn As Boolean = True

        Dim mStrSQL As String
        Dim mDB As New SqlConnection
        Dim mCMD As New SqlCommand

        mCMD.Parameters.Clear()

        mCMD.Parameters.AddWithValue("@pNum_Doc", pNum_Doc)


        mStrSQL = "UPDATE Linhas SET "
        mStrSQL += "FLG_Ativo=0 "
        mStrSQL += "WHERE Num_Doc=@pNum_Doc"


        mDB.ConnectionString = My.Settings.Connection
        mCMD.CommandText = mStrSQL
        mDB.Open()
        mCMD.Connection = mDB

        Try
            mCMD.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("ApagaLinhas:" + vbCrLf + "Erro ao Gravar!!!" + vbCrLf + ex.ToString)
            mReturn = False
        End Try

        mDB.Close()

        Return mReturn

    End Function
End Class

