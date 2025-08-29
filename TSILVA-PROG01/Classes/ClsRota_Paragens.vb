
Imports System.Data.SqlClient


''' <summary>
'''      Classe ClsRota_Paragens Classe da Tabela Rota_Paragens
'''      Gerado em 03/02/2025 14:16:43
''' </summary>
''' <remarks>
'''      (c) ETLA - PM-2025
''' </remarks>
Public Class ClsRota_Paragens


    ' -----------------------------------------
    ' Property's da tabela Rota_Paragens
    ' -----------------------------------------

    Public Property Cod_Rota As String                                      ' Len:  5 - SQL_Type: nvarchar
    Public Property Cod_Paragem As String                                   ' Len:  5 - SQL_Type: nvarchar
    Public Property Ordem As Integer                                        ' SQL_Type: smallint

    Public Property Tempo_Min As Integer                                    ' SQL_Type: smallint
    Public ReadOnly Property Paragem_Descritivo As String
        Get
            Return ClsParagens.GetParagensByCod(Cod_Paragem).Descritivo
        End Get
    End Property

    Public ReadOnly Property Paragem_Localidade As String
        Get
            Return ClsParagens.GetParagensByCod(Cod_Paragem).Localidade
        End Get
    End Property
    Public ReadOnly Property Paragem_Endereco As String
        Get
            Return ClsParagens.GetParagensByCod(Cod_Paragem).Endereco
        End Get
    End Property

    Public Property Dist_Km As Integer                                      ' SQL_Type: smallint

    Public Property FLG_Ativo As Boolean                                    ' SQL_Type: bit

    Sub New()
    End Sub

    Sub New(ByVal pCod_Rota As String, ByVal pCod_Paragem As String, pOrdem As Integer, pDist_Km As Integer, pTempo_Min As Integer)

        Cod_Rota = pCod_Rota
        Cod_Paragem = pCod_Paragem
        Ordem = pOrdem
        Dist_Km = pDist_Km
        Tempo_Min = pTempo_Min

    End Sub

    Public Shared Function Grava_Lista_Paragens(ByVal pLista As List(Of ClsRota_Paragens)) As Boolean

        Dim mReturn As Boolean = True
        Dim n As Integer = 1
        For Each pRP As ClsRota_Paragens In pLista
            pRP.Ordem = n
            If Not GravaRota_Paragens(pRP) Then
                Return mReturn = False
                Exit Function
            End If
            n += 1
        Next

        Return mReturn
    End Function



    '--------------------------------------------
    ' Exemplo de criador de Código por contador
    ' Para ser usado no caso de o Cdigo ser gerado
    ' e o contador existir na tabela Empresas
    '---------------------------------------------

    'Friend Shared Function GetNovoCodigo() As String

    'Return "R" & ClsEmpresas.GetContador(enCont.Rota_Paragens).ToString("000")' <-------------- VERIFICAR O Nº de ZEROS

    'End Function


    ''' <summary>
    '''      Function GetRota_Paragens() Método para devolver a Lista de Rota_Paragens
    '''      Gerado em 03/02/2025 14:16:43
    ''' </summary>
    ''' <returns>
    '''      mListaRota_Paragens
    ''' </returns>
    ''' <remarks>
    '''      (c) ETLA - PM-2025
    ''' </remarks>
    Public Shared Function GetRota_Paragens(ByVal pCod_Rota As String) As List(Of ClsRota_Paragens)
        Dim mListaRota_Paragens As New List(Of ClsRota_Paragens)

        Dim mStrSQL As String
        Dim mDB As New SqlConnection
        Dim mCMD As New SqlCommand
        Dim mRDR As SqlDataReader

        mDB.ConnectionString = My.Settings.Connection
        mCMD.Parameters.Clear()
        mCMD.Parameters.AddWithValue("@pCod_Rota", pCod_Rota)

        mStrSQL = "SELECT "
        mStrSQL += "ISNULL(Cod_Rota,'') As Cod_Rota,"
        mStrSQL += "ISNULL(Cod_Paragem,'') As Cod_Paragem,"
        mStrSQL += "ISNULL(Ordem,0) As Ordem,"
        mStrSQL += "ISNULL(Dist_Km,0) As Dist_Km,"
        mStrSQL += "ISNULL(Tempo_Min,0) As Tempo_Min,"
        mStrSQL += "ISNULL(FLG_Ativo,1) As FLG_Ativo "
        mStrSQL += "FROM Rota_Paragens "
        mStrSQL += "WHERE FLG_Ativo=1 AND Cod_Rota=@pCod_Rota ORDER BY Ordem"


        mCMD.CommandText = mStrSQL
        mDB.Open()
        mCMD.Connection = mDB

        mRDR = mCMD.ExecuteReader

        While mRDR.Read()

            Dim mClsRota_Paragens As New ClsRota_Paragens

            With mClsRota_Paragens
                .Cod_Rota = mRDR.GetString(mRDR.GetOrdinal("Cod_Rota"))
                .Cod_Paragem = mRDR.GetString(mRDR.GetOrdinal("Cod_Paragem"))
                .Ordem = mRDR.GetValue(mRDR.GetOrdinal("Ordem"))
                .Dist_Km = mRDR.GetValue(mRDR.GetOrdinal("Dist_Km"))
                .Tempo_Min = mRDR.GetValue(mRDR.GetOrdinal("Tempo_Min"))
                .FLG_Ativo = mRDR.GetBoolean(mRDR.GetOrdinal("FLG_Ativo"))
            End With


            mListaRota_Paragens.Add(mClsRota_Paragens)

        End While

        mRDR.Close()
        mDB.Close()

        Return mListaRota_Paragens
    End Function

    ''' <summary>
    '''      Function FiltrarRota_Paragens Método para Filtrar os campos da lista de Rota_Paragens
    '''      Gerado em 03/02/2025 14:16:43
    ''' </summary>
    ''' <returns>
    '''      mListaRota_Paragens
    ''' </returns>
    ''' <remarks>
    '''      (c) ETLA - PM-2025
    ''' </remarks>
    Public Shared Function FiltrarRota_Paragens(ByVal pFiltro As String) As List(Of ClsRota_Paragens)
        Dim mListaRota_Paragens As New List(Of ClsRota_Paragens)
        Dim mLista As New List(Of ClsRota_Paragens)

        mListaRota_Paragens = GetRota_Paragens(pFiltro)

        mLista = mListaRota_Paragens.FindAll(Function(x) x.Cod_Rota.Contains(pFiltro)
)
        '-----------------------------------------------------
        'Pode Colocar em cima mais colunas como esta abaixo...
        '-----------------------------------------------------
        ' AND x.Cod_Paragem.Contains(pFiltro.Cod_Paragem) 

        Return mLista
    End Function


    ''' <summary>
    '''      Function GetRota_ParagensByCod(ByVal pCod_Rota As String) Método para decolver uma Classe de Rota_Paragens
    '''      Gerado em 03/02/2025 14:16:43
    ''' </summary>
    ''' <returns>
    '''      mClsRota_Paragens
    ''' </returns>
    ''' <remarks>
    '''      (c) ETLA - PM-2025
    ''' </remarks>
    Public Shared Function GetRota_ParagensByCod(ByVal pCod_Rota As String) As ClsRota_Paragens
        Dim mClsRota_Paragens As New ClsRota_Paragens

        Dim mStrSQL As String
        Dim mDB As New SqlConnection
        Dim mCMD As New SqlCommand
        Dim mRDR As SqlDataReader

        mDB.ConnectionString = My.Settings.Connection
        mCMD.Parameters.Clear()
        mCMD.Parameters.AddWithValue("@pCod_Rota", pCod_Rota)


        mStrSQL = "SELECT "
        mStrSQL += "ISNULL(Cod_Rota,'') As Cod_Rota,"
        mStrSQL += "ISNULL(Cod_Paragem,'') As Cod_Paragem,"
        mStrSQL += "ISNULL(Ordem,0) As Ordem,"
        mStrSQL += "ISNULL(Dist_Km,0) As Dist_Km,"
        mStrSQL += "ISNULL(Tempo_Min,0) As Tempo_Min,"
        mStrSQL += "ISNULL(FLG_Ativo,1) As FLG_Ativo "
        mStrSQL += "FROM Rota_Paragens "
        mStrSQL += "WHERE FLG_Ativo=1 "
        mStrSQL += "AND Cod_Rota=@pCod_Rota"


        mCMD.CommandText = mStrSQL
        mDB.Open()
        mCMD.Connection = mDB

        mRDR = mCMD.ExecuteReader

        If mRDR.Read() Then


            With mClsRota_Paragens
                .Cod_Rota = mRDR.GetString(mRDR.GetOrdinal("Cod_Rota"))
                .Cod_Paragem = mRDR.GetString(mRDR.GetOrdinal("Cod_Paragem"))
                .Ordem = mRDR.GetValue(mRDR.GetOrdinal("Ordem"))
                .Dist_Km = mRDR.GetValue(mRDR.GetOrdinal("Dist_Km"))
                .Tempo_Min = mRDR.GetValue(mRDR.GetOrdinal("Tempo_Min"))
                .FLG_Ativo = mRDR.GetBoolean(mRDR.GetOrdinal("FLG_Ativo"))
            End With


        End If
        mRDR.Close()
        mDB.Close()

        Return mClsRota_Paragens
    End Function

    Public Shared Function GetRota_ParagensByCodParagem(ByVal pCod_Rota As String, ByVal pCod_Paragem As String) As ClsRota_Paragens
        Dim mClsRota_Paragens As New ClsRota_Paragens

        Dim mStrSQL As String
        Dim mDB As New SqlConnection
        Dim mCMD As New SqlCommand
        Dim mRDR As SqlDataReader

        mDB.ConnectionString = My.Settings.Connection
        mCMD.Parameters.Clear()
        mCMD.Parameters.AddWithValue("@pCod_Rota", pCod_Rota)
        mCMD.Parameters.AddWithValue("@pCod_Paragem", pCod_Paragem)


        mStrSQL = "SELECT "
        mStrSQL += "ISNULL(Cod_Rota,'') As Cod_Rota,"
        mStrSQL += "ISNULL(Cod_Paragem,'') As Cod_Paragem,"
        mStrSQL += "ISNULL(Ordem,0) As Ordem,"
        mStrSQL += "ISNULL(Dist_Km,0) As Dist_Km,"
        mStrSQL += "ISNULL(Tempo_Min,0) As Tempo_Min,"
        mStrSQL += "ISNULL(FLG_Ativo,1) As FLG_Ativo "
        mStrSQL += "FROM Rota_Paragens "
        mStrSQL += "WHERE FLG_Ativo=1 "
        mStrSQL += "AND Cod_Paragem=@pCod_Paragem "
        mStrSQL += "AND Cod_Rota=@pCod_Rota"


        mCMD.CommandText = mStrSQL
        mDB.Open()
        mCMD.Connection = mDB

        mRDR = mCMD.ExecuteReader

        If mRDR.Read() Then


            With mClsRota_Paragens
                .Cod_Rota = mRDR.GetString(mRDR.GetOrdinal("Cod_Rota"))
                .Cod_Paragem = mRDR.GetString(mRDR.GetOrdinal("Cod_Paragem"))
                .Ordem = mRDR.GetValue(mRDR.GetOrdinal("Ordem"))
                .Dist_Km = mRDR.GetValue(mRDR.GetOrdinal("Dist_Km"))
                .Tempo_Min = mRDR.GetValue(mRDR.GetOrdinal("Tempo_Min"))
                .FLG_Ativo = mRDR.GetBoolean(mRDR.GetOrdinal("FLG_Ativo"))
            End With


        End If
        mRDR.Close()
        mDB.Close()

        Return mClsRota_Paragens
    End Function


    ''' <summary>
    '''      Function ModificaRota_Paragens(ByVal pClsRota_Paragens As ClsRota_Paragens) Método para Modificar a TABELA Rota_Paragens
    '''      Gerado em 03/02/2025 14:16:43
    ''' </summary>
    ''' <returns>
    '''      Boolean
    ''' </returns>
    ''' <remarks>
    '''      (c) ETLA - PM-2025
    ''' </remarks>
    Public Shared Function ModificaRota_Paragens(ByVal pClsRota_Paragens As ClsRota_Paragens) As Boolean
        Dim mReturn As Boolean = True

        Dim mStrSQL As String
        Dim mDB As New SqlConnection
        Dim mCMD As New SqlCommand

        mCMD.Parameters.Clear()
        mCMD.Parameters.AddWithValue("@pCod_Rota", pClsRota_Paragens.Cod_Rota.Substring(0, IIf(Len(pClsRota_Paragens.Cod_Rota) > 5, 5, Len(pClsRota_Paragens.Cod_Rota))))
        mCMD.Parameters.AddWithValue("@pCod_Paragem", pClsRota_Paragens.Cod_Paragem.Substring(0, IIf(Len(pClsRota_Paragens.Cod_Paragem) > 5, 5, Len(pClsRota_Paragens.Cod_Paragem))))
        mCMD.Parameters.AddWithValue("@pOrdem", pClsRota_Paragens.Ordem)
        mCMD.Parameters.AddWithValue("@pDist_Km", pClsRota_Paragens.Dist_Km)
        mCMD.Parameters.AddWithValue("@pTempo_Min", pClsRota_Paragens.Tempo_Min)


        mStrSQL = "UPDATE Rota_Paragens SET "
        mStrSQL += "Cod_Paragem=@pCod_Paragem,"
        mStrSQL += "Ordem=@pOrdem,"
        mStrSQL += "Dist_Km=@pDist_Km,"
        mStrSQL += "Tempo_Min=@pTempo_Min "
        mStrSQL += "WHERE Cod_Rota=@pCod_Rota"


        mDB.ConnectionString = My.Settings.Connection
        mCMD.CommandText = mStrSQL
        mDB.Open()
        mCMD.Connection = mDB

        Try
            mCMD.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("ModificaRota_Paragens:" + vbCrLf + "Erro ao Gravar!!!" + vbCrLf + ex.ToString)
            mReturn = False
        End Try

        mDB.Close()

        Return mReturn

    End Function


    ''' <summary>
    '''      Function GravaRota_Paragens(ByVal pNovoRota_Paragens As ClsRota_Paragens) Método para Gravar a TABELA Rota_Paragens
    '''      Gerado em 03/02/2025 14:16:43
    ''' </summary>
    ''' <returns>
    '''      Boolean
    ''' </returns>
    ''' <remarks>
    '''      (c) ETLA - PM-2025
    ''' </remarks>
    Public Shared Function GravaRota_Paragens(ByVal pNovoRota_Paragens As ClsRota_Paragens) As Boolean
        Dim mReturn As Boolean = True

        Dim mStrSQL As String
        Dim mDB As New SqlConnection
        Dim mCMD As New SqlCommand

        mDB.ConnectionString = My.Settings.Connection
        mCMD.Parameters.Clear()


        mCMD.Parameters.AddWithValue("@pCod_Rota", pNovoRota_Paragens.Cod_Rota.Substring(0, IIf(Len(pNovoRota_Paragens.Cod_Rota) > 5, 5, Len(pNovoRota_Paragens.Cod_Rota))))
        mCMD.Parameters.AddWithValue("@pCod_Paragem", pNovoRota_Paragens.Cod_Paragem.Substring(0, IIf(Len(pNovoRota_Paragens.Cod_Paragem) > 5, 5, Len(pNovoRota_Paragens.Cod_Paragem))))
        mCMD.Parameters.AddWithValue("@pOrdem", pNovoRota_Paragens.Ordem)
        mCMD.Parameters.AddWithValue("@pDist_Km", pNovoRota_Paragens.Dist_Km)
        mCMD.Parameters.AddWithValue("@pTempo_Min", pNovoRota_Paragens.Tempo_Min)
        mCMD.Parameters.AddWithValue("@pFLG_Ativo", pNovoRota_Paragens.FLG_Ativo)


        mStrSQL = "INSERT INTO Rota_Paragens "
        mStrSQL += "("
        mStrSQL += "Cod_Rota,"
        mStrSQL += "Cod_Paragem,"
        mStrSQL += "Ordem,"
        mStrSQL += "Dist_Km,"
        mStrSQL += "Tempo_Min,"
        mStrSQL += "FLG_Ativo "
        mStrSQL += ") "
        mStrSQL += "VALUES "
        mStrSQL += "("
        mStrSQL += "@pCod_Rota,"
        mStrSQL += "@pCod_Paragem,"
        mStrSQL += "@pOrdem,"
        mStrSQL += "@pDist_Km,"
        mStrSQL += "@pTempo_Min,"
        mStrSQL += "1"
        mStrSQL += ")"


        mCMD.CommandText = mStrSQL
        mDB.Open()
        mCMD.Connection = mDB

        Try
            mCMD.ExecuteNonQuery()
            'ClsEmpresas.GravaContador(enCont.Rota_Paragens)'<<<<-------- Verificar se é  preciso...
        Catch ex As Exception
            MsgBox("GravaRota_Paragens:" + vbCrLf + "Erro ao Gravar!!!" + vbCrLf + ex.ToString)
            mReturn = False
        End Try

        mDB.Close()

        Return mReturn

    End Function


    ''' <summary>
    '''      Function ApagaRota_Paragens(ByVal pCod_Rota As String) Método para Apagar um Registo da Tabela Rota_Paragens
    '''      Gerado em 03/02/2025 14:16:43
    ''' </summary>
    ''' <returns>
    '''      Boolean
    ''' </returns>
    ''' <remarks>
    '''      (c) ETLA - PM-2025
    ''' </remarks>
    Public Shared Function ApagaRota_Paragens(ByVal pCod_Rota As String, ByVal pCod_Paragem As String) As Boolean
        Dim mReturn As Boolean = True

        Dim mStrSQL As String
        Dim mDB As New SqlConnection
        Dim mCMD As New SqlCommand

        mCMD.Parameters.Clear()

        mCMD.Parameters.AddWithValue("@pCod_Rota", pCod_Rota)
        mCMD.Parameters.AddWithValue("@pCod_Paragem", pCod_Paragem)


        mStrSQL = "DELETE FROM Rota_Paragens "
        mStrSQL += "WHERE Cod_Rota=@pCod_Rota "
        mStrSQL += "AND Cod_Paragem=@pCod_Paragem"


        mDB.ConnectionString = My.Settings.Connection
        mCMD.CommandText = mStrSQL
        mDB.Open()
        mCMD.Connection = mDB

        Try
            mCMD.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("ApagaRota_Paragens:" + vbCrLf + "Erro ao Gravar!!!" + vbCrLf + ex.ToString)
            mReturn = False
        End Try

        mDB.Close()

        Return mReturn

    End Function
End Class



''' <summary>
'''      Classe Rota_ParagensComparer 
'''      Gerado em 03/02/2025 14:16:43
''' </summary>
''' <remarks>
'''      (c) ETLA - PM-2025
''' </remarks>
Public Class Rota_ParagensComparer
    Implements IEqualityComparer(Of ClsRota_Paragens)

    Public Function Equals1(ByVal x As ClsRota_Paragens, ByVal y As ClsRota_Paragens) As Boolean Implements IEqualityComparer(Of ClsRota_Paragens).Equals

        If x Is y Then Return True

        If x Is Nothing OrElse y Is Nothing Then Return False

        Return (x.Cod_Rota = y.Cod_Rota) ' AndAlso (x.Cod_Paragem = y.Cod_Paragem)
    End Function

    Public Function GetHashCode1(ByVal pCls As ClsRota_Paragens) As Integer Implements IEqualityComparer(Of ClsRota_Paragens).GetHashCode

        If pCls Is Nothing Then Return 0

        'Dim Hash_ClsRota_Paragens_Cod_Paragem = pCls.Cod_Paragem.GetHashCode()
        Dim Hash_ClsRota_Paragens_Cod_Rota = pCls.Cod_Rota.GetHashCode()

        Return Hash_ClsRota_Paragens_Cod_Rota 'Xor Hash_ClsRota_Paragens_Cod_Paragem
    End Function
End Class
