
Imports System.Data.SqlClient


''' <summary>
'''      Classe ClsLocalidades Classe da Tabela Localidades
'''      Gerado em 08/10/2024 13:36:11
''' </summary>
''' <remarks>
'''      (c) ETLA - PM-2024
''' </remarks>
Public Class ClsLocalidades


    ' -----------------------------------------
    ' Property's da tabela Localidades
    ' -----------------------------------------

    Public Property Cod_Localidade As Integer                               ' SQL_Type: int
    Public Property Localidade As String                                    ' Len: 50 - SQL_Type: nvarchar
    Public Property FLG_Ativo As Boolean                                    ' SQL_Type: bit


    Sub New()
    End Sub


    '--------------------------------------------
    ' Exemplo de criador de Código por contador
    ' Para ser usado no caso de o Cdigo ser gerado
    ' e o contador existir na tabela Empresas
    '---------------------------------------------

    'Friend Shared Function GetNovoCodigo() As String

    'Return "L" & ClsEmpresas.GetContador(enCont.Localidades).ToString("000")' <-------------- VERIFICAR O Nº de ZEROS

    'End Function


    ''' <summary>
    '''      Function GetLocalidades() Método para devolver a Lista de Localidades
    '''      Gerado em 08/10/2024 13:36:11
    ''' </summary>
    ''' <returns>
    '''      mListaLocalidades
    ''' </returns>
    ''' <remarks>
    '''      (c) ETLA - PM-2024
    ''' </remarks>
    Public Shared Function GetLocalidades() As List(Of ClsLocalidades)
        Dim mListaLocalidades As New List(Of ClsLocalidades)

        Dim mStrSQL As String
        Dim mDB As New SqlConnection
        Dim mCMD As New SqlCommand
        Dim mRDR As SqlDataReader

        mDB.ConnectionString = My.Settings.Connection
        mCMD.Parameters.Clear()

        mStrSQL = "SELECT "
        mStrSQL += "ISNULL(Cod_Localidade,0) As Cod_Localidade,"
        mStrSQL += "ISNULL(Localidade,'') As Localidade,"
        mStrSQL += "ISNULL(FLG_Ativo,1) As FLG_Ativo "
        mStrSQL += "FROM Localidades "
        mStrSQL += "WHERE FLG_Ativo=1"


        mCMD.CommandText = mStrSQL
        mDB.Open()
        mCMD.Connection = mDB

        mRDR = mCMD.ExecuteReader

        While mRDR.Read()

            Dim mClsLocalidades As New ClsLocalidades

            With mClsLocalidades
                .Cod_Localidade = mRDR.GetValue(mRDR.GetOrdinal("Cod_Localidade"))
                .Localidade = mRDR.GetString(mRDR.GetOrdinal("Localidade"))
                .FLG_Ativo = mRDR.GetBoolean(mRDR.GetOrdinal("FLG_Ativo"))
            End With


            mListaLocalidades.Add(mClsLocalidades)

        End While

        mRDR.Close()
        mDB.Close()

        Return mListaLocalidades
    End Function


    ''' <summary>
    '''      Function GetLocalidadesByCod(ByVal pCod_Localidade As Integer) Método para decolver uma Classe de Localidades
    '''      Gerado em 08/10/2024 13:36:11
    ''' </summary>
    ''' <returns>
    '''      mClsLocalidades
    ''' </returns>
    ''' <remarks>
    '''      (c) ETLA - PM-2024
    ''' </remarks>
    Public Shared Function GetLocalidadesByCod(ByVal pCod_Localidade As Integer) As ClsLocalidades
        Dim mClsLocalidades As New ClsLocalidades

        Dim mStrSQL As String
        Dim mDB As New SqlConnection
        Dim mCMD As New SqlCommand
        Dim mRDR As SqlDataReader

        mDB.ConnectionString = My.Settings.Connection
        mCMD.Parameters.Clear()
        mCMD.Parameters.AddWithValue("@pCod_Localidade", pCod_Localidade)


        mStrSQL = "SELECT "
        mStrSQL += "ISNULL(Cod_Localidade,0) As Cod_Localidade,"
        mStrSQL += "ISNULL(Localidade,'') As Localidade,"
        mStrSQL += "ISNULL(FLG_Ativo,1) As FLG_Ativo "
        mStrSQL += "FROM Localidades "
        mStrSQL += "WHERE FLG_Ativo=1 "
        mStrSQL += "AND Cod_Localidade=@pCod_Localidade"


        mCMD.CommandText = mStrSQL
        mDB.Open()
        mCMD.Connection = mDB

        mRDR = mCMD.ExecuteReader

        If mRDR.Read() Then


            With mClsLocalidades
                .Cod_Localidade = mRDR.GetValue(mRDR.GetOrdinal("Cod_Localidade"))
                .Localidade = mRDR.GetString(mRDR.GetOrdinal("Localidade"))
                .FLG_Ativo = mRDR.GetBoolean(mRDR.GetOrdinal("FLG_Ativo"))
            End With


        End If
        mRDR.Close()
        mDB.Close()

        Return mClsLocalidades
    End Function


    ''' <summary>
    '''      Function ModificaLocalidades(ByVal pClsLocalidades As ClsLocalidades) Método para Modificar a TABELA Localidades
    '''      Gerado em 08/10/2024 13:36:11
    ''' </summary>
    ''' <returns>
    '''      Boolean
    ''' </returns>
    ''' <remarks>
    '''      (c) ETLA - PM-2024
    ''' </remarks>
    Public Shared Function ModificaLocalidades(ByVal pClsLocalidades As ClsLocalidades) As Boolean
        Dim mReturn As Boolean = True

        Dim mStrSQL As String
        Dim mDB As New SqlConnection
        Dim mCMD As New SqlCommand

        mCMD.Parameters.Clear()
        mCMD.Parameters.AddWithValue("@pCod_Localidade", pClsLocalidades.Cod_Localidade)
        mCMD.Parameters.AddWithValue("@pLocalidade", pClsLocalidades.Localidade.Substring(0, IIf(Len(pClsLocalidades.Localidade) > 50, 50, Len(pClsLocalidades.Localidade))))


        mStrSQL = "UPDATE Localidades SET "
        mStrSQL += "Localidade=@pLocalidade "
        mStrSQL += "WHERE Cod_Localidade=@pCod_Localidade"


        mDB.ConnectionString = My.Settings.Connection
        mCMD.CommandText = mStrSQL
        mDB.Open()
        mCMD.Connection = mDB

        Try
            mCMD.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("ModificaLocalidades:" + vbCrLf + "Erro ao Gravar!!!" + vbCrLf + ex.ToString)
            mReturn = False
        End Try

        mDB.Close()

        Return mReturn

    End Function


    ''' <summary>
    '''      Function GravaLocalidades(ByVal pNovoLocalidades As ClsLocalidades) Método para Gravar a TABELA Localidades
    '''      Gerado em 08/10/2024 13:36:11
    ''' </summary>
    ''' <returns>
    '''      Boolean
    ''' </returns>
    ''' <remarks>
    '''      (c) ETLA - PM-2024
    ''' </remarks>
    Public Shared Function GravaLocalidades(ByVal pNovoLocalidades As ClsLocalidades) As Boolean
        Dim mReturn As Boolean = True

        Dim mStrSQL As String
        Dim mDB As New SqlConnection
        Dim mCMD As New SqlCommand

        mDB.ConnectionString = My.Settings.Connection
        mCMD.Parameters.Clear()


        mCMD.Parameters.AddWithValue("@pCod_Localidade", pNovoLocalidades.Cod_Localidade)
        mCMD.Parameters.AddWithValue("@pLocalidade", pNovoLocalidades.Localidade.Substring(0, IIf(Len(pNovoLocalidades.Localidade) > 50, 50, Len(pNovoLocalidades.Localidade))))
        mCMD.Parameters.AddWithValue("@pFLG_Ativo", pNovoLocalidades.FLG_Ativo)


        mStrSQL = "INSERT INTO Localidades "
        mStrSQL += "("
        mStrSQL += "Cod_Localidade,"
        mStrSQL += "Localidade,"
        mStrSQL += "FLG_Ativo "
        mStrSQL += ") "
        mStrSQL += "VALUES "
        mStrSQL += "("
        mStrSQL += "@pCod_Localidade,"
        mStrSQL += "@pLocalidade,"
        mStrSQL += "1"
        mStrSQL += ")"


        mCMD.CommandText = mStrSQL
        mDB.Open()
        mCMD.Connection = mDB

        Try
            mCMD.ExecuteNonQuery()
            'ClsEmpresas.GravaContador(enCont.Localidades)'<<<<-------- Verificar se é  preciso...
        Catch ex As Exception
            MsgBox("GravaLocalidades:" + vbCrLf + "Erro ao Gravar!!!" + vbCrLf + ex.ToString)
            mReturn = False
        End Try

        mDB.Close()

        Return mReturn

    End Function


    ''' <summary>
    '''      Function ApagaLocalidades(ByVal pCod_Localidade As Integer) Método para Apagar um Registo da Tabela Localidades
    '''      Gerado em 08/10/2024 13:36:11
    ''' </summary>
    ''' <returns>
    '''      Boolean
    ''' </returns>
    ''' <remarks>
    '''      (c) ETLA - PM-2024
    ''' </remarks>
    Public Shared Function ApagaLocalidades(ByVal pCod_Localidade As Integer) As Boolean
        Dim mReturn As Boolean = True

        Dim mStrSQL As String
        Dim mDB As New SqlConnection
        Dim mCMD As New SqlCommand

        mCMD.Parameters.Clear()

        mCMD.Parameters.AddWithValue("@pCod_Localidade", pCod_Localidade)


        mStrSQL = "UPDATE Localidades SET "
        mStrSQL += "FLG_Ativo=0 "
        mStrSQL += "WHERE Cod_Localidade=@pCod_Localidade"


        mDB.ConnectionString = My.Settings.Connection
        mCMD.CommandText = mStrSQL
        mDB.Open()
        mCMD.Connection = mDB

        Try
            mCMD.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("ApagaLocalidades:" + vbCrLf + "Erro ao Gravar!!!" + vbCrLf + ex.ToString)
            mReturn = False
        End Try

        mDB.Close()

        Return mReturn

    End Function
End Class



''' <summary>
'''      Classe LocalidadesComparer 
'''      Gerado em 08/10/2024 13:36:11
''' </summary>
''' <remarks>
'''      (c) ETLA - PM-2024
''' </remarks>
Public Class LocalidadesComparer
    Implements IEqualityComparer(Of ClsLocalidades)

    Public Function Equals1(ByVal x As ClsLocalidades, ByVal y As ClsLocalidades) As Boolean Implements IEqualityComparer(Of ClsLocalidades).Equals

        If x Is y Then Return True

        If x Is Nothing OrElse y Is Nothing Then Return False

        Return (x.Cod_Localidade = y.Cod_Localidade) ' AndAlso (x.Localidade = y.Localidade)
    End Function

    Public Function GetHashCode1(ByVal pCls As ClsLocalidades) As Integer Implements IEqualityComparer(Of ClsLocalidades).GetHashCode

        If pCls Is Nothing Then Return 0

        'Dim Hash_ClsLocalidades_Localidade = pCls.Localidade.GetHashCode()
        Dim Hash_ClsLocalidades_Cod_Localidade = pCls.Cod_Localidade.GetHashCode()

        Return Hash_ClsLocalidades_Cod_Localidade 'Xor Hash_ClsLocalidades_Localidade
    End Function
End Class
