
Imports System.Data.SqlClient


''' <summary>
'''      Classe ClsTipos_Viagem Classe da Tabela Tipos_Viagem
'''      Gerado em 23/01/2025 13:57:14
''' </summary>
''' <remarks>
'''      (c) ETLA - PM-2025
''' </remarks>
Public Class ClsTipos_Viagem


    ' -----------------------------------------
    ' Property's da tabela Tipos_Viagem
    ' -----------------------------------------

    Public Property Tipo_VIagem As Integer                                  ' SQL_Type: smallint
    Public Property SIGLA As String                                         ' Len:  3 - SQL_Type: nvarchar
    Public Property Descrtivo As String                                     ' Len: 20 - SQL_Type: nvarchar
    Public Property FLG_Ativo As Boolean                                    ' SQL_Type: bit


    Sub New()
    End Sub


    '--------------------------------------------
    ' Exemplo de criador de Código por contador
    ' Para ser usado no caso de o Cdigo ser gerado
    ' e o contador existir na tabela Empresas
    '---------------------------------------------

    'Friend Shared Function GetNovoCodigo() As String

    'Return "T" & ClsEmpresas.GetContador(enCont.Tipos_Viagem).ToString("000")' <-------------- VERIFICAR O Nº de ZEROS

    'End Function


    ''' <summary>
    '''      Function GetTipos_Viagem() Método para devolver a Lista de Tipos_Viagem
    '''      Gerado em 23/01/2025 13:57:14
    ''' </summary>
    ''' <returns>
    '''      mListaTipos_Viagem
    ''' </returns>
    ''' <remarks>
    '''      (c) ETLA - PM-2025
    ''' </remarks>
    Public Shared Function GetTipos_Viagem() As List(Of ClsTipos_Viagem)
        Dim mListaTipos_Viagem As New List(Of ClsTipos_Viagem)

        Dim mStrSQL As String
        Dim mDB As New SqlConnection
        Dim mCMD As New SqlCommand
        Dim mRDR As SqlDataReader

        mDB.ConnectionString = My.Settings.Connection
        mCMD.Parameters.Clear()

        mStrSQL = "SELECT "
        mStrSQL += "ISNULL(Tipo_VIagem,0) As Tipo_VIagem,"
        mStrSQL += "ISNULL(SIGLA,'') As SIGLA,"
        mStrSQL += "ISNULL(Descrtivo,'') As Descrtivo,"
        mStrSQL += "ISNULL(FLG_Ativo,1) As FLG_Ativo "
        mStrSQL += "FROM Tipos_Viagem "
        mStrSQL += "WHERE FLG_Ativo=1"


        mCMD.CommandText = mStrSQL
        mDB.Open()
        mCMD.Connection = mDB

        mRDR = mCMD.ExecuteReader

        While mRDR.Read()

            Dim mClsTipos_Viagem As New ClsTipos_Viagem

            With mClsTipos_Viagem
                .Tipo_VIagem = mRDR.GetValue(mRDR.GetOrdinal("Tipo_VIagem"))
                .SIGLA = mRDR.GetString(mRDR.GetOrdinal("SIGLA"))
                .Descrtivo = mRDR.GetString(mRDR.GetOrdinal("Descrtivo"))
                .FLG_Ativo = mRDR.GetBoolean(mRDR.GetOrdinal("FLG_Ativo"))
            End With


            mListaTipos_Viagem.Add(mClsTipos_Viagem)

        End While

        mRDR.Close()
        mDB.Close()

        Return mListaTipos_Viagem
    End Function


    ''' <summary>
    '''      Function GetTipos_ViagemByCod(ByVal pTipo_VIagem As Integer) Método para decolver uma Classe de Tipos_Viagem
    '''      Gerado em 23/01/2025 13:57:14
    ''' </summary>
    ''' <returns>
    '''      mClsTipos_Viagem
    ''' </returns>
    ''' <remarks>
    '''      (c) ETLA - PM-2025
    ''' </remarks>
    Public Shared Function GetTipos_ViagemByCod(ByVal pTipo_VIagem As Integer) As ClsTipos_Viagem
        Dim mClsTipos_Viagem As New ClsTipos_Viagem

        Dim mStrSQL As String
        Dim mDB As New SqlConnection
        Dim mCMD As New SqlCommand
        Dim mRDR As SqlDataReader

        mDB.ConnectionString = My.Settings.Connection
        mCMD.Parameters.Clear()
        mCMD.Parameters.AddWithValue("@pTipo_VIagem", pTipo_VIagem)


        mStrSQL = "SELECT "
        mStrSQL += "ISNULL(Tipo_VIagem,0) As Tipo_VIagem,"
        mStrSQL += "ISNULL(SIGLA,'') As SIGLA,"
        mStrSQL += "ISNULL(Descrtivo,'') As Descrtivo,"
        mStrSQL += "ISNULL(FLG_Ativo,1) As FLG_Ativo "
        mStrSQL += "FROM Tipos_Viagem "
        mStrSQL += "WHERE FLG_Ativo=1 "
        mStrSQL += "AND Tipo_VIagem=@pTipo_VIagem"


        mCMD.CommandText = mStrSQL
        mDB.Open()
        mCMD.Connection = mDB

        mRDR = mCMD.ExecuteReader

        If mRDR.Read() Then


            With mClsTipos_Viagem
                .Tipo_VIagem = mRDR.GetValue(mRDR.GetOrdinal("Tipo_VIagem"))
                .SIGLA = mRDR.GetString(mRDR.GetOrdinal("SIGLA"))
                .Descrtivo = mRDR.GetString(mRDR.GetOrdinal("Descrtivo"))
                .FLG_Ativo = mRDR.GetBoolean(mRDR.GetOrdinal("FLG_Ativo"))
            End With


        End If
        mRDR.Close()
        mDB.Close()

        Return mClsTipos_Viagem
    End Function


    ''' <summary>
    '''      Function ModificaTipos_Viagem(ByVal pClsTipos_Viagem As ClsTipos_Viagem) Método para Modificar a TABELA Tipos_Viagem
    '''      Gerado em 23/01/2025 13:57:14
    ''' </summary>
    ''' <returns>
    '''      Boolean
    ''' </returns>
    ''' <remarks>
    '''      (c) ETLA - PM-2025
    ''' </remarks>
    Public Shared Function ModificaTipos_Viagem(ByVal pClsTipos_Viagem As ClsTipos_Viagem) As Boolean
        Dim mReturn As Boolean = True

        Dim mStrSQL As String
        Dim mDB As New SqlConnection
        Dim mCMD As New SqlCommand

        mCMD.Parameters.Clear()
        mCMD.Parameters.AddWithValue("@pTipo_VIagem", pClsTipos_Viagem.Tipo_VIagem)
        mCMD.Parameters.AddWithValue("@pSIGLA", pClsTipos_Viagem.SIGLA.Substring(0, IIf(Len(pClsTipos_Viagem.SIGLA) > 3, 3, Len(pClsTipos_Viagem.SIGLA))))
        mCMD.Parameters.AddWithValue("@pDescrtivo", pClsTipos_Viagem.Descrtivo.Substring(0, IIf(Len(pClsTipos_Viagem.Descrtivo) > 20, 20, Len(pClsTipos_Viagem.Descrtivo))))


        mStrSQL = "UPDATE Tipos_Viagem SET "
        mStrSQL += "SIGLA=@pSIGLA,"
        mStrSQL += "Descrtivo=@pDescrtivo "
        mStrSQL += "WHERE Tipo_VIagem=@pTipo_VIagem"


        mDB.ConnectionString = My.Settings.Connection
        mCMD.CommandText = mStrSQL
        mDB.Open()
        mCMD.Connection = mDB

        Try
            mCMD.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("ModificaTipos_Viagem:" + vbCrLf + "Erro ao Gravar!!!" + vbCrLf + ex.ToString)
            mReturn = False
        End Try

        mDB.Close()

        Return mReturn

    End Function


    ''' <summary>
    '''      Function GravaTipos_Viagem(ByVal pNovoTipos_Viagem As ClsTipos_Viagem) Método para Gravar a TABELA Tipos_Viagem
    '''      Gerado em 23/01/2025 13:57:14
    ''' </summary>
    ''' <returns>
    '''      Boolean
    ''' </returns>
    ''' <remarks>
    '''      (c) ETLA - PM-2025
    ''' </remarks>
    Public Shared Function GravaTipos_Viagem(ByVal pNovoTipos_Viagem As ClsTipos_Viagem) As Boolean
        Dim mReturn As Boolean = True

        Dim mStrSQL As String
        Dim mDB As New SqlConnection
        Dim mCMD As New SqlCommand

        mDB.ConnectionString = My.Settings.Connection
        mCMD.Parameters.Clear()


        mCMD.Parameters.AddWithValue("@pTipo_VIagem", pNovoTipos_Viagem.Tipo_VIagem)
        mCMD.Parameters.AddWithValue("@pSIGLA", pNovoTipos_Viagem.SIGLA.Substring(0, IIf(Len(pNovoTipos_Viagem.SIGLA) > 3, 3, Len(pNovoTipos_Viagem.SIGLA))))
        mCMD.Parameters.AddWithValue("@pDescrtivo", pNovoTipos_Viagem.Descrtivo.Substring(0, IIf(Len(pNovoTipos_Viagem.Descrtivo) > 20, 20, Len(pNovoTipos_Viagem.Descrtivo))))
        mCMD.Parameters.AddWithValue("@pFLG_Ativo", pNovoTipos_Viagem.FLG_Ativo)


        mStrSQL = "INSERT INTO Tipos_Viagem "
        mStrSQL += "("
        mStrSQL += "Tipo_VIagem,"
        mStrSQL += "SIGLA,"
        mStrSQL += "Descrtivo,"
        mStrSQL += "FLG_Ativo "
        mStrSQL += ") "
        mStrSQL += "VALUES "
        mStrSQL += "("
        mStrSQL += "@pTipo_VIagem,"
        mStrSQL += "@pSIGLA,"
        mStrSQL += "@pDescrtivo,"
        mStrSQL += "1"
        mStrSQL += ")"


        mCMD.CommandText = mStrSQL
        mDB.Open()
        mCMD.Connection = mDB

        Try
            mCMD.ExecuteNonQuery()
            'ClsEmpresas.GravaContador(enCont.Tipos_Viagem)'<<<<-------- Verificar se é  preciso...
        Catch ex As Exception
            MsgBox("GravaTipos_Viagem:" + vbCrLf + "Erro ao Gravar!!!" + vbCrLf + ex.ToString)
            mReturn = False
        End Try

        mDB.Close()

        Return mReturn

    End Function


    ''' <summary>
    '''      Function ApagaTipos_Viagem(ByVal pTipo_VIagem As Integer) Método para Apagar um Registo da Tabela Tipos_Viagem
    '''      Gerado em 23/01/2025 13:57:14
    ''' </summary>
    ''' <returns>
    '''      Boolean
    ''' </returns>
    ''' <remarks>
    '''      (c) ETLA - PM-2025
    ''' </remarks>
    Public Shared Function ApagaTipos_Viagem(ByVal pTipo_VIagem As Integer) As Boolean
        Dim mReturn As Boolean = True

        Dim mStrSQL As String
        Dim mDB As New SqlConnection
        Dim mCMD As New SqlCommand

        mCMD.Parameters.Clear()

        mCMD.Parameters.AddWithValue("@pTipo_VIagem", pTipo_VIagem)


        mStrSQL = "UPDATE Tipos_Viagem SET "
        mStrSQL += "FLG_Ativo=0 "
        mStrSQL += "WHERE Tipo_VIagem=@pTipo_VIagem"


        mDB.ConnectionString = My.Settings.Connection
        mCMD.CommandText = mStrSQL
        mDB.Open()
        mCMD.Connection = mDB

        Try
            mCMD.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("ApagaTipos_Viagem:" + vbCrLf + "Erro ao Gravar!!!" + vbCrLf + ex.ToString)
            mReturn = False
        End Try

        mDB.Close()

        Return mReturn

    End Function
End Class

