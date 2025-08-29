
Imports System.Data.SqlClient


''' <summary>
'''      Classe ClsPontos_Paragem Classe da Tabela Pontos_Paragem
'''      Gerado em 23/01/2025 13:57:14
''' </summary>
''' <remarks>
'''      (c) ETLA - PM-2025
''' </remarks>
Public Class ClsPontos_Paragem


    ' -----------------------------------------
    ' Property's da tabela Pontos_Paragem
    ' -----------------------------------------

    Public Property Cod_PP As String                                        ' Len:  5 - SQL_Type: nvarchar
    Public Property Descritivo As String                                    ' Len: 30 - SQL_Type: nvarchar
    Public Property Endereco As String                                      ' Len:120 - SQL_Type: nvarchar
    Public Property Cod_Localidade As String                                ' Len:  5 - SQL_Type: nvarchar
    Public Property Dist_Km As Integer                                      ' SQL_Type: smallint
    Public Property Tempo_Min As Integer                                    ' SQL_Type: smallint
    Public Property FLG_Ativo As Boolean                                    ' SQL_Type: bit


    Sub New()
    End Sub


    '--------------------------------------------
    ' Exemplo de criador de Código por contador
    ' Para ser usado no caso de o Cdigo ser gerado
    ' e o contador existir na tabela Empresas
    '---------------------------------------------

    'Friend Shared Function GetNovoCodigo() As String

    'Return "P" & ClsEmpresas.GetContador(enCont.Pontos_Paragem).ToString("000")' <-------------- VERIFICAR O Nº de ZEROS

    'End Function


    ''' <summary>
    '''      Function GetPontos_Paragem() Método para devolver a Lista de Pontos_Paragem
    '''      Gerado em 23/01/2025 13:57:14
    ''' </summary>
    ''' <returns>
    '''      mListaPontos_Paragem
    ''' </returns>
    ''' <remarks>
    '''      (c) ETLA - PM-2025
    ''' </remarks>
    Public Shared Function GetPontos_Paragem() As List(Of ClsPontos_Paragem)
        Dim mListaPontos_Paragem As New List(Of ClsPontos_Paragem)

        Dim mStrSQL As String
        Dim mDB As New SqlConnection
        Dim mCMD As New SqlCommand
        Dim mRDR As SqlDataReader

        mDB.ConnectionString = My.Settings.Connection
        mCMD.Parameters.Clear()

        mStrSQL = "SELECT "
        mStrSQL += "ISNULL(Cod_PP,'') As Cod_PP,"
        mStrSQL += "ISNULL(Descritivo,'') As Descritivo,"
        mStrSQL += "ISNULL(Endereco,'') As Endereco,"
        mStrSQL += "ISNULL(Cod_Localidade,'') As Cod_Localidade,"
        mStrSQL += "ISNULL(Dist_Km,0) As Dist_Km,"
        mStrSQL += "ISNULL(Tempo_Min,0) As Tempo_Min,"
        mStrSQL += "ISNULL(FLG_Ativo,1) As FLG_Ativo "
        mStrSQL += "FROM Pontos_Paragem "
        mStrSQL += "WHERE FLG_Ativo=1"


        mCMD.CommandText = mStrSQL
        mDB.Open()
        mCMD.Connection = mDB

        mRDR = mCMD.ExecuteReader

        While mRDR.Read()

            Dim mClsPontos_Paragem As New ClsPontos_Paragem

            With mClsPontos_Paragem
                .Cod_PP = mRDR.GetString(mRDR.GetOrdinal("Cod_PP"))
                .Descritivo = mRDR.GetString(mRDR.GetOrdinal("Descritivo"))
                .Endereco = mRDR.GetString(mRDR.GetOrdinal("Endereco"))
                .Cod_Localidade = mRDR.GetString(mRDR.GetOrdinal("Cod_Localidade"))
                .Dist_Km = mRDR.GetValue(mRDR.GetOrdinal("Dist_Km"))
                .Tempo_Min = mRDR.GetValue(mRDR.GetOrdinal("Tempo_Min"))
                .FLG_Ativo = mRDR.GetBoolean(mRDR.GetOrdinal("FLG_Ativo"))
            End With


            mListaPontos_Paragem.Add(mClsPontos_Paragem)

        End While

        mRDR.Close()
        mDB.Close()

        Return mListaPontos_Paragem
    End Function

    ''' <summary>
    '''      Function FiltrarPontos_Paragem Método para Filtrar os campos da lista de Pontos_Paragem
    '''      Gerado em 23/01/2025 13:57:14
    ''' </summary>
    ''' <returns>
    '''      mListaPontos_Paragem
    ''' </returns>
    ''' <remarks>
    '''      (c) ETLA - PM-2025
    ''' </remarks>
    Public Shared Function FiltrarPontos_Paragem(ByVal pFiltro As ClsPontos_Paragem) As List(Of ClsPontos_Paragem)
        Dim mListaPontos_Paragem As New List(Of ClsPontos_Paragem)
        Dim mLista As New List(Of ClsPontos_Paragem)

        mListaPontos_Paragem = GetPontos_Paragem()

        mLista = mListaPontos_Paragem.FindAll(Function(x) _
        x.Cod_PP.Contains(pFiltro.Cod_PP)
        )
        '-----------------------------------------------------
        'Pode Colocar em cima mais colunas como esta abaixo...
        '-----------------------------------------------------
        ' AND x.Descritivo.Contains(pFiltro.Descritivo) 

        Return mLista
    End Function


    ''' <summary>
    '''      Function GetPontos_ParagemByCod(ByVal pCod_PP As String) Método para decolver uma Classe de Pontos_Paragem
    '''      Gerado em 23/01/2025 13:57:14
    ''' </summary>
    ''' <returns>
    '''      mClsPontos_Paragem
    ''' </returns>
    ''' <remarks>
    '''      (c) ETLA - PM-2025
    ''' </remarks>
    Public Shared Function GetPontos_ParagemByCod(ByVal pCod_PP As String) As ClsPontos_Paragem
        Dim mClsPontos_Paragem As New ClsPontos_Paragem

        Dim mStrSQL As String
        Dim mDB As New SqlConnection
        Dim mCMD As New SqlCommand
        Dim mRDR As SqlDataReader

        mDB.ConnectionString = My.Settings.Connection
        mCMD.Parameters.Clear()
        mCMD.Parameters.AddWithValue("@pCod_PP", pCod_PP)


        mStrSQL = "SELECT "
        mStrSQL += "ISNULL(Cod_PP,'') As Cod_PP,"
        mStrSQL += "ISNULL(Descritivo,'') As Descritivo,"
        mStrSQL += "ISNULL(Endereco,'') As Endereco,"
        mStrSQL += "ISNULL(Cod_Localidade,'') As Cod_Localidade,"
        mStrSQL += "ISNULL(Dist_Km,0) As Dist_Km,"
        mStrSQL += "ISNULL(Tempo_Min,0) As Tempo_Min,"
        mStrSQL += "ISNULL(FLG_Ativo,1) As FLG_Ativo "
        mStrSQL += "FROM Pontos_Paragem "
        mStrSQL += "WHERE FLG_Ativo=1 "
        mStrSQL += "AND Cod_PP=@pCod_PP"


        mCMD.CommandText = mStrSQL
        mDB.Open()
        mCMD.Connection = mDB

        mRDR = mCMD.ExecuteReader

        If mRDR.Read() Then


            With mClsPontos_Paragem
                .Cod_PP = mRDR.GetString(mRDR.GetOrdinal("Cod_PP"))
                .Descritivo = mRDR.GetString(mRDR.GetOrdinal("Descritivo"))
                .Endereco = mRDR.GetString(mRDR.GetOrdinal("Endereco"))
                .Cod_Localidade = mRDR.GetString(mRDR.GetOrdinal("Cod_Localidade"))
                .Dist_Km = mRDR.GetValue(mRDR.GetOrdinal("Dist_Km"))
                .Tempo_Min = mRDR.GetValue(mRDR.GetOrdinal("Tempo_Min"))
                .FLG_Ativo = mRDR.GetBoolean(mRDR.GetOrdinal("FLG_Ativo"))
            End With


        End If
        mRDR.Close()
        mDB.Close()

        Return mClsPontos_Paragem
    End Function


    ''' <summary>
    '''      Function ModificaPontos_Paragem(ByVal pClsPontos_Paragem As ClsPontos_Paragem) Método para Modificar a TABELA Pontos_Paragem
    '''      Gerado em 23/01/2025 13:57:14
    ''' </summary>
    ''' <returns>
    '''      Boolean
    ''' </returns>
    ''' <remarks>
    '''      (c) ETLA - PM-2025
    ''' </remarks>
    Public Shared Function ModificaPontos_Paragem(ByVal pClsPontos_Paragem As ClsPontos_Paragem) As Boolean
        Dim mReturn As Boolean = True

        Dim mStrSQL As String
        Dim mDB As New SqlConnection
        Dim mCMD As New SqlCommand

        mCMD.Parameters.Clear()
        mCMD.Parameters.AddWithValue("@pCod_PP", pClsPontos_Paragem.Cod_PP.Substring(0, IIf(Len(pClsPontos_Paragem.Cod_PP) > 5, 5, Len(pClsPontos_Paragem.Cod_PP))))
        mCMD.Parameters.AddWithValue("@pDescritivo", pClsPontos_Paragem.Descritivo.Substring(0, IIf(Len(pClsPontos_Paragem.Descritivo) > 30, 30, Len(pClsPontos_Paragem.Descritivo))))
        mCMD.Parameters.AddWithValue("@pEndereco", pClsPontos_Paragem.Endereco.Substring(0, IIf(Len(pClsPontos_Paragem.Endereco) > 120, 120, Len(pClsPontos_Paragem.Endereco))))
        mCMD.Parameters.AddWithValue("@pCod_Localidade", pClsPontos_Paragem.Cod_Localidade.Substring(0, IIf(Len(pClsPontos_Paragem.Cod_Localidade) > 5, 5, Len(pClsPontos_Paragem.Cod_Localidade))))
        mCMD.Parameters.AddWithValue("@pDist_Km", pClsPontos_Paragem.Dist_Km)
        mCMD.Parameters.AddWithValue("@pTempo_Min", pClsPontos_Paragem.Tempo_Min)


        mStrSQL = "UPDATE Pontos_Paragem SET "
        mStrSQL += "Descritivo=@pDescritivo,"
        mStrSQL += "Endereco=@pEndereco,"
        mStrSQL += "Cod_Localidade=@pCod_Localidade,"
        mStrSQL += "Dist_Km=@pDist_Km,"
        mStrSQL += "Tempo_Min=@pTempo_Min "
        mStrSQL += "WHERE Cod_PP=@pCod_PP"


        mDB.ConnectionString = My.Settings.Connection
        mCMD.CommandText = mStrSQL
        mDB.Open()
        mCMD.Connection = mDB

        Try
            mCMD.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("ModificaPontos_Paragem:" + vbCrLf + "Erro ao Gravar!!!" + vbCrLf + ex.ToString)
            mReturn = False
        End Try

        mDB.Close()

        Return mReturn

    End Function


    ''' <summary>
    '''      Function GravaPontos_Paragem(ByVal pNovoPontos_Paragem As ClsPontos_Paragem) Método para Gravar a TABELA Pontos_Paragem
    '''      Gerado em 23/01/2025 13:57:14
    ''' </summary>
    ''' <returns>
    '''      Boolean
    ''' </returns>
    ''' <remarks>
    '''      (c) ETLA - PM-2025
    ''' </remarks>
    Public Shared Function GravaPontos_Paragem(ByVal pNovoPontos_Paragem As ClsPontos_Paragem) As Boolean
        Dim mReturn As Boolean = True

        Dim mStrSQL As String
        Dim mDB As New SqlConnection
        Dim mCMD As New SqlCommand

        mDB.ConnectionString = My.Settings.Connection
        mCMD.Parameters.Clear()


        mCMD.Parameters.AddWithValue("@pCod_PP", pNovoPontos_Paragem.Cod_PP.Substring(0, IIf(Len(pNovoPontos_Paragem.Cod_PP) > 5, 5, Len(pNovoPontos_Paragem.Cod_PP))))
        mCMD.Parameters.AddWithValue("@pDescritivo", pNovoPontos_Paragem.Descritivo.Substring(0, IIf(Len(pNovoPontos_Paragem.Descritivo) > 30, 30, Len(pNovoPontos_Paragem.Descritivo))))
        mCMD.Parameters.AddWithValue("@pEndereco", pNovoPontos_Paragem.Endereco.Substring(0, IIf(Len(pNovoPontos_Paragem.Endereco) > 120, 120, Len(pNovoPontos_Paragem.Endereco))))
        mCMD.Parameters.AddWithValue("@pCod_Localidade", pNovoPontos_Paragem.Cod_Localidade.Substring(0, IIf(Len(pNovoPontos_Paragem.Cod_Localidade) > 5, 5, Len(pNovoPontos_Paragem.Cod_Localidade))))
        mCMD.Parameters.AddWithValue("@pDist_Km", pNovoPontos_Paragem.Dist_Km)
        mCMD.Parameters.AddWithValue("@pTempo_Min", pNovoPontos_Paragem.Tempo_Min)
        mCMD.Parameters.AddWithValue("@pFLG_Ativo", pNovoPontos_Paragem.FLG_Ativo)


        mStrSQL = "INSERT INTO Pontos_Paragem "
        mStrSQL += "("
        mStrSQL += "Cod_PP,"
        mStrSQL += "Descritivo,"
        mStrSQL += "Endereco,"
        mStrSQL += "Cod_Localidade,"
        mStrSQL += "Dist_Km,"
        mStrSQL += "Tempo_Min,"
        mStrSQL += "FLG_Ativo "
        mStrSQL += ") "
        mStrSQL += "VALUES "
        mStrSQL += "("
        mStrSQL += "@pCod_PP,"
        mStrSQL += "@pDescritivo,"
        mStrSQL += "@pEndereco,"
        mStrSQL += "@pCod_Localidade,"
        mStrSQL += "@pDist_Km,"
        mStrSQL += "@pTempo_Min,"
        mStrSQL += "1"
        mStrSQL += ")"


        mCMD.CommandText = mStrSQL
        mDB.Open()
        mCMD.Connection = mDB

        Try
            mCMD.ExecuteNonQuery()
            'ClsEmpresas.GravaContador(enCont.Pontos_Paragem)'<<<<-------- Verificar se é  preciso...
        Catch ex As Exception
            MsgBox("GravaPontos_Paragem:" + vbCrLf + "Erro ao Gravar!!!" + vbCrLf + ex.ToString)
            mReturn = False
        End Try

        mDB.Close()

        Return mReturn

    End Function


    ''' <summary>
    '''      Function ApagaPontos_Paragem(ByVal pCod_PP As String) Método para Apagar um Registo da Tabela Pontos_Paragem
    '''      Gerado em 23/01/2025 13:57:14
    ''' </summary>
    ''' <returns>
    '''      Boolean
    ''' </returns>
    ''' <remarks>
    '''      (c) ETLA - PM-2025
    ''' </remarks>
    Public Shared Function ApagaPontos_Paragem(ByVal pCod_PP As String) As Boolean
        Dim mReturn As Boolean = True

        Dim mStrSQL As String
        Dim mDB As New SqlConnection
        Dim mCMD As New SqlCommand

        mCMD.Parameters.Clear()

        mCMD.Parameters.AddWithValue("@pCod_PP", pCod_PP)


        mStrSQL = "UPDATE Pontos_Paragem SET "
        mStrSQL += "FLG_Ativo=0 "
        mStrSQL += "WHERE Cod_PP=@pCod_PP"


        mDB.ConnectionString = My.Settings.Connection
        mCMD.CommandText = mStrSQL
        mDB.Open()
        mCMD.Connection = mDB

        Try
            mCMD.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("ApagaPontos_Paragem:" + vbCrLf + "Erro ao Gravar!!!" + vbCrLf + ex.ToString)
            mReturn = False
        End Try

        mDB.Close()

        Return mReturn

    End Function
End Class



''' <summary>
'''      Classe Pontos_ParagemComparer 
'''      Gerado em 23/01/2025 13:57:14
''' </summary>
''' <remarks>
'''      (c) ETLA - PM-2025
''' </remarks>
Public Class Pontos_ParagemComparer
    Implements IEqualityComparer(Of ClsPontos_Paragem)

    Public Function Equals1(ByVal x As ClsPontos_Paragem, ByVal y As ClsPontos_Paragem) As Boolean Implements IEqualityComparer(Of ClsPontos_Paragem).Equals

        If x Is y Then Return True

        If x Is Nothing OrElse y Is Nothing Then Return False

        Return (x.Cod_PP = y.Cod_PP) ' AndAlso (x.Descritivo = y.Descritivo)
    End Function

    Public Function GetHashCode1(ByVal pCls As ClsPontos_Paragem) As Integer Implements IEqualityComparer(Of ClsPontos_Paragem).GetHashCode

        If pCls Is Nothing Then Return 0

        'Dim Hash_ClsPontos_Paragem_Descritivo = pCls.Descritivo.GetHashCode()
        Dim Hash_ClsPontos_Paragem_Cod_PP = pCls.Cod_PP.GetHashCode()

        Return Hash_ClsPontos_Paragem_Cod_PP 'Xor Hash_ClsPontos_Paragem_Descritivo
    End Function
End Class
