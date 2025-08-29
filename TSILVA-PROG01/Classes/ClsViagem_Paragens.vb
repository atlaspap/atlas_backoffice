
Imports System.Data.SqlClient
Imports DevExpress.Office.Utils


''' <summary>
'''      Classe ClsViagem_Paragens Classe da Tabela Viagem_Paragens
'''      Gerado em 19/03/2025 12:06:35
''' </summary>
''' <remarks>
'''      (c) ETLA - PM-2025
''' </remarks>
Public Class ClsViagem_Paragens


    ' -----------------------------------------
    ' Property's da tabela Viagem_Paragens
    ' -----------------------------------------

    Public Property Cod_Viagem As String                                    ' Len:  8 - SQL_Type: nvarchar
    Public Property Cod_Paragem As String                                   ' Len:  5 - SQL_Type: nvarchar
    Public Property Ordem As Integer                                        ' SQL_Type: smallint
    Public Property Descritivo As String                                    ' Len: 30 - SQL_Type: nvarchar
    Public Property ETD As Date                                             ' SQL_Type: smalldatetime
    Public Property ATD As Date                                             ' SQL_Type: smalldatetime

    Public ReadOnly Property Loc01 As Decimal
        Get
            Return ClsParagens.GetParagensByCod(Cod_Paragem).Loc01
        End Get
    End Property

    Public ReadOnly Property Loc02 As Decimal
        Get
            Return ClsParagens.GetParagensByCod(Cod_Paragem).Loc02
        End Get
    End Property
    Public ReadOnly Property Localizacao As String
        Get
            Dim m1 As String
            Dim m2 As String
            m1 = Replace(Loc01, ",", ".")
            m2 = Replace(Loc02, ",", ".")
            Return m1 & ", " & m2
        End Get
    End Property

    Public Property FLG_Ativo As Boolean                                    ' SQL_Type: bit


    Sub New()
    End Sub


    '--------------------------------------------
    ' Exemplo de criador de Código por contador
    ' Para ser usado no caso de o Cdigo ser gerado
    ' e o contador existir na tabela Empresas
    '---------------------------------------------

    'Friend Shared Function GetNovoCodigo() As String

    'Return "V" & ClsEmpresas.GetContador(enCont.Viagem_Paragens).ToString("000")' <-------------- VERIFICAR O Nº de ZEROS

    'End Function

    ''' <summary>
    ''' Grava_Lista_VParagens
    ''' </summary>
    ''' <param name="pLista_VP"></param>
    ''' <returns></returns>
    Friend Shared Function Grava_Lista_VParagens(ByVal pLista_VP As List(Of ClsViagem_Paragens)) As Boolean
        Dim mReturn As Boolean = True

        For Each VP As ClsViagem_Paragens In pLista_VP
            If Not GravaViagem_Paragens(VP) Then
                mReturn = False
                GoTo Salto
            End If
        Next
Salto:
        Return mReturn
    End Function


    ''' <summary>
    '''      Function GetViagem_Paragens() Método para devolver a Lista de Viagem_Paragens
    '''      Gerado em 19/03/2025 12:06:35
    ''' </summary>
    ''' <returns>
    '''      mListaViagem_Paragens
    ''' </returns>
    ''' <remarks>
    '''      (c) ETLA - PM-2025
    ''' </remarks>
    Public Shared Function GetViagem_Paragens() As List(Of ClsViagem_Paragens)
        Dim mListaViagem_Paragens As New List(Of ClsViagem_Paragens)

        Dim mStrSQL As String
        Dim mDB As New SqlConnection
        Dim mCMD As New SqlCommand
        Dim mRDR As SqlDataReader

        mDB.ConnectionString = My.Settings.Connection
        mCMD.Parameters.Clear()

        mStrSQL = "SELECT "
        mStrSQL += "ISNULL(Cod_Viagem,'') As Cod_Viagem,"
        mStrSQL += "ISNULL(Cod_Paragem,'') As Cod_Paragem,"
        mStrSQL += "ISNULL(Ordem,0) As Ordem,"
        mStrSQL += "ISNULL(Descritivo,'') As Descritivo,"
        mStrSQL += "ISNULL(ETD,0) As ETD,"
        mStrSQL += "ISNULL(ATD,0) As ATD,"
        mStrSQL += "ISNULL(FLG_Ativo,1) As FLG_Ativo "
        mStrSQL += "FROM Viagem_Paragens "
        mStrSQL += "WHERE FLG_Ativo=1"


        mCMD.CommandText = mStrSQL
        mDB.Open()
        mCMD.Connection = mDB

        mRDR = mCMD.ExecuteReader

        While mRDR.Read()

            Dim mClsViagem_Paragens As New ClsViagem_Paragens

            With mClsViagem_Paragens
                .Cod_Viagem = mRDR.GetString(mRDR.GetOrdinal("Cod_Viagem"))
                .Cod_Paragem = mRDR.GetString(mRDR.GetOrdinal("Cod_Paragem"))
                .Ordem = mRDR.GetValue(mRDR.GetOrdinal("Ordem"))
                .Descritivo = mRDR.GetString(mRDR.GetOrdinal("Descritivo"))
                .ETD = mRDR.GetDateTime(mRDR.GetOrdinal("ETD"))
                .ATD = mRDR.GetDateTime(mRDR.GetOrdinal("ATD"))
                .FLG_Ativo = mRDR.GetBoolean(mRDR.GetOrdinal("FLG_Ativo"))
            End With


            mListaViagem_Paragens.Add(mClsViagem_Paragens)

        End While

        mRDR.Close()
        mDB.Close()

        Return mListaViagem_Paragens
    End Function

    ''' <summary>
    '''      Function FiltrarViagem_Paragens Método para Filtrar os campos da lista de Viagem_Paragens
    '''      Gerado em 19/03/2025 12:06:35
    ''' </summary>
    ''' <returns>
    '''      mListaViagem_Paragens
    ''' </returns>
    ''' <remarks>
    '''      (c) ETLA - PM-2025
    ''' </remarks>
    Public Shared Function FiltrarViagem_Paragens(ByVal pFiltro As ClsViagem_Paragens) As List(Of ClsViagem_Paragens)
        Dim mListaViagem_Paragens As New List(Of ClsViagem_Paragens)
        Dim mLista As New List(Of ClsViagem_Paragens)

        mListaViagem_Paragens = GetViagem_Paragens()

        mLista = mListaViagem_Paragens.FindAll(Function(x) _
        x.Cod_Viagem.Contains(pFiltro.Cod_Viagem)
        )
        '-----------------------------------------------------
        'Pode Colocar em cima mais colunas como esta abaixo...
        '-----------------------------------------------------
        ' AND x.Cod_Paragem.Contains(pFiltro.Cod_Paragem) 

        Return mLista
    End Function


    ''' <summary>
    '''      Function GetViagem_ParagensByCod(ByVal pCod_Viagem As String) Método para decolver uma Classe de Viagem_Paragens
    '''      Gerado em 19/03/2025 12:06:35
    ''' </summary>
    ''' <returns>
    '''      mClsViagem_Paragens
    ''' </returns>
    ''' <remarks>
    '''      (c) ETLA - PM-2025
    ''' </remarks>
    Public Shared Function GetViagem_ParagensByCod(ByVal pCod_Viagem As String) As List(Of ClsViagem_Paragens)
        Dim mLista_VParagens As New List(Of ClsViagem_Paragens)

        Dim mStrSQL As String
        Dim mDB As New SqlConnection
        Dim mCMD As New SqlCommand
        Dim mRDR As SqlDataReader

        mDB.ConnectionString = My.Settings.Connection
        mCMD.Parameters.Clear()
        mCMD.Parameters.AddWithValue("@pCod_Viagem", pCod_Viagem)


        mStrSQL = "SELECT "
        mStrSQL += "ISNULL(Cod_Viagem,'') As Cod_Viagem,"
        mStrSQL += "ISNULL(Cod_Paragem,'') As Cod_Paragem,"
        mStrSQL += "ISNULL(Ordem,0) As Ordem,"
        mStrSQL += "ISNULL(Descritivo,'') As Descritivo,"
        mStrSQL += "ISNULL(ETD,0) As ETD,"
        mStrSQL += "ISNULL(ATD,0) As ATD,"
        mStrSQL += "ISNULL(FLG_Ativo,1) As FLG_Ativo "
        mStrSQL += "FROM Viagem_Paragens "
        mStrSQL += "WHERE FLG_Ativo=1 "
        mStrSQL += "AND Cod_Viagem=@pCod_Viagem"


        mCMD.CommandText = mStrSQL
        mDB.Open()
        mCMD.Connection = mDB

        mRDR = mCMD.ExecuteReader

        While mRDR.Read()
            Dim mClsViagem_Paragens As New ClsViagem_Paragens

            With mClsViagem_Paragens
                .Cod_Viagem = mRDR.GetString(mRDR.GetOrdinal("Cod_Viagem"))
                .Cod_Paragem = mRDR.GetString(mRDR.GetOrdinal("Cod_Paragem"))
                .Ordem = mRDR.GetValue(mRDR.GetOrdinal("Ordem"))
                .Descritivo = mRDR.GetString(mRDR.GetOrdinal("Descritivo"))
                .ETD = mRDR.GetDateTime(mRDR.GetOrdinal("ETD"))
                .ATD = mRDR.GetDateTime(mRDR.GetOrdinal("ATD"))
                .FLG_Ativo = mRDR.GetBoolean(mRDR.GetOrdinal("FLG_Ativo"))
            End With

            mLista_VParagens.Add(mClsViagem_Paragens)
        End While

        mRDR.Close()
        mDB.Close()

        Return mLista_VParagens
    End Function


    ''' <summary>
    '''      Function ModificaViagem_Paragens(ByVal pClsViagem_Paragens As ClsViagem_Paragens) Método para Modificar a TABELA Viagem_Paragens
    '''      Gerado em 19/03/2025 12:06:35
    ''' </summary>
    ''' <returns>
    '''      Boolean
    ''' </returns>
    ''' <remarks>
    '''      (c) ETLA - PM-2025
    ''' </remarks>
    Public Shared Function ModificaViagem_Paragens(ByVal pClsViagem_Paragens As ClsViagem_Paragens) As Boolean
        Dim mReturn As Boolean = True

        Dim mStrSQL As String
        Dim mDB As New SqlConnection
        Dim mCMD As New SqlCommand

        mCMD.Parameters.Clear()
        mCMD.Parameters.AddWithValue("@pCod_Viagem", pClsViagem_Paragens.Cod_Viagem.Substring(0, IIf(Len(pClsViagem_Paragens.Cod_Viagem) > 8, 8, Len(pClsViagem_Paragens.Cod_Viagem))))
        mCMD.Parameters.AddWithValue("@pCod_Paragem", pClsViagem_Paragens.Cod_Paragem.Substring(0, IIf(Len(pClsViagem_Paragens.Cod_Paragem) > 5, 5, Len(pClsViagem_Paragens.Cod_Paragem))))
        mCMD.Parameters.AddWithValue("@pOrdem", pClsViagem_Paragens.Ordem)
        mCMD.Parameters.AddWithValue("@pDescritivo", pClsViagem_Paragens.Descritivo.Substring(0, IIf(Len(pClsViagem_Paragens.Descritivo) > 30, 30, Len(pClsViagem_Paragens.Descritivo))))
        mCMD.Parameters.AddWithValue("@pETD", pClsViagem_Paragens.ETD)
        mCMD.Parameters.AddWithValue("@pATD", pClsViagem_Paragens.ATD)


        mStrSQL = "UPDATE Viagem_Paragens SET "
        mStrSQL += "Cod_Paragem=@pCod_Paragem,"
        mStrSQL += "Ordem=@pOrdem,"
        mStrSQL += "Descritivo=@pDescritivo,"
        mStrSQL += "ETD=@pETD,"
        mStrSQL += "ATD=@pATD "
        mStrSQL += "WHERE Cod_Viagem=@pCod_Viagem"


        mDB.ConnectionString = My.Settings.Connection
        mCMD.CommandText = mStrSQL
        mDB.Open()
        mCMD.Connection = mDB

        Try
            mCMD.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("ModificaViagem_Paragens:" + vbCrLf + "Erro ao Gravar!!!" + vbCrLf + ex.ToString)
            mReturn = False
        End Try

        mDB.Close()

        Return mReturn

    End Function


    ''' <summary>
    '''      Function GravaViagem_Paragens(ByVal pNovoViagem_Paragens As ClsViagem_Paragens) Método para Gravar a TABELA Viagem_Paragens
    '''      Gerado em 19/03/2025 12:06:35
    ''' </summary>
    ''' <returns>
    '''      Boolean
    ''' </returns>
    ''' <remarks>
    '''      (c) ETLA - PM-2025
    ''' </remarks>
    Public Shared Function GravaViagem_Paragens(ByVal pNovoViagem_Paragens As ClsViagem_Paragens) As Boolean
        Dim mReturn As Boolean = True

        Dim mStrSQL As String
        Dim mDB As New SqlConnection
        Dim mCMD As New SqlCommand

        mDB.ConnectionString = My.Settings.Connection
        mCMD.Parameters.Clear()


        mCMD.Parameters.AddWithValue("@pCod_Viagem", pNovoViagem_Paragens.Cod_Viagem.Substring(0, IIf(Len(pNovoViagem_Paragens.Cod_Viagem) > 8, 8, Len(pNovoViagem_Paragens.Cod_Viagem))))
        mCMD.Parameters.AddWithValue("@pCod_Paragem", pNovoViagem_Paragens.Cod_Paragem.Substring(0, IIf(Len(pNovoViagem_Paragens.Cod_Paragem) > 5, 5, Len(pNovoViagem_Paragens.Cod_Paragem))))
        mCMD.Parameters.AddWithValue("@pOrdem", pNovoViagem_Paragens.Ordem)
        mCMD.Parameters.AddWithValue("@pDescritivo", pNovoViagem_Paragens.Descritivo.Substring(0, IIf(Len(pNovoViagem_Paragens.Descritivo) > 30, 30, Len(pNovoViagem_Paragens.Descritivo))))
        mCMD.Parameters.AddWithValue("@pETD", pNovoViagem_Paragens.ETD)
        mCMD.Parameters.AddWithValue("@pATD", pNovoViagem_Paragens.ATD)
        mCMD.Parameters.AddWithValue("@pFLG_Ativo", pNovoViagem_Paragens.FLG_Ativo)


        mStrSQL = "INSERT INTO Viagem_Paragens "
        mStrSQL += "("
        mStrSQL += "Cod_Viagem,"
        mStrSQL += "Cod_Paragem,"
        mStrSQL += "Ordem,"
        mStrSQL += "Descritivo,"
        mStrSQL += "ETD,"
        mStrSQL += "ATD,"
        mStrSQL += "FLG_Ativo "
        mStrSQL += ") "
        mStrSQL += "VALUES "
        mStrSQL += "("
        mStrSQL += "@pCod_Viagem,"
        mStrSQL += "@pCod_Paragem,"
        mStrSQL += "@pOrdem,"
        mStrSQL += "@pDescritivo,"
        mStrSQL += "@pETD,"
        mStrSQL += "@pATD,"
        mStrSQL += "1"
        mStrSQL += ")"


        mCMD.CommandText = mStrSQL
        mDB.Open()
        mCMD.Connection = mDB

        Try
            mCMD.ExecuteNonQuery()
            'ClsEmpresas.GravaContador(enCont.Viagem_Paragens)'<<<<-------- Verificar se é  preciso...
        Catch ex As Exception
            MsgBox("GravaViagem_Paragens:" + vbCrLf + "Erro ao Gravar!!!" + vbCrLf + ex.ToString)
            mReturn = False
        End Try

        mDB.Close()

        Return mReturn

    End Function


    ''' <summary>
    '''      Function ApagaViagem_Paragens(ByVal pCod_Viagem As String) Método para Apagar um Registo da Tabela Viagem_Paragens
    '''      Gerado em 19/03/2025 12:06:35
    ''' </summary>
    ''' <returns>
    '''      Boolean
    ''' </returns>
    ''' <remarks>
    '''      (c) ETLA - PM-2025
    ''' </remarks>
    Public Shared Function ApagaViagem_Paragens(ByVal pCod_Viagem As String) As Boolean
        Dim mReturn As Boolean = True

        Dim mStrSQL As String
        Dim mDB As New SqlConnection
        Dim mCMD As New SqlCommand

        mCMD.Parameters.Clear()

        mCMD.Parameters.AddWithValue("@pCod_Viagem", pCod_Viagem)


        mStrSQL = "UPDATE Viagem_Paragens SET "
        mStrSQL += "FLG_Ativo=0 "
        mStrSQL += "WHERE Cod_Viagem=@pCod_Viagem"


        mDB.ConnectionString = My.Settings.Connection
        mCMD.CommandText = mStrSQL
        mDB.Open()
        mCMD.Connection = mDB

        Try
            mCMD.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("ApagaViagem_Paragens:" + vbCrLf + "Erro ao Gravar!!!" + vbCrLf + ex.ToString)
            mReturn = False
        End Try

        mDB.Close()

        Return mReturn

    End Function
End Class



''' <summary>
'''      Classe Viagem_ParagensComparer 
'''      Gerado em 19/03/2025 12:06:35
''' </summary>
''' <remarks>
'''      (c) ETLA - PM-2025
''' </remarks>
Public Class Viagem_ParagensComparer
    Implements IEqualityComparer(Of ClsViagem_Paragens)

    Public Function Equals1(ByVal x As ClsViagem_Paragens, ByVal y As ClsViagem_Paragens) As Boolean Implements IEqualityComparer(Of ClsViagem_Paragens).Equals

        If x Is y Then Return True

        If x Is Nothing OrElse y Is Nothing Then Return False

        Return (x.Cod_Viagem = y.Cod_Viagem) ' AndAlso (x.Cod_Paragem = y.Cod_Paragem)
    End Function

    Public Function GetHashCode1(ByVal pCls As ClsViagem_Paragens) As Integer Implements IEqualityComparer(Of ClsViagem_Paragens).GetHashCode

        If pCls Is Nothing Then Return 0

        'Dim Hash_ClsViagem_Paragens_Cod_Paragem = pCls.Cod_Paragem.GetHashCode()
        Dim Hash_ClsViagem_Paragens_Cod_Viagem = pCls.Cod_Viagem.GetHashCode()

        Return Hash_ClsViagem_Paragens_Cod_Viagem 'Xor Hash_ClsViagem_Paragens_Cod_Paragem
    End Function
End Class
