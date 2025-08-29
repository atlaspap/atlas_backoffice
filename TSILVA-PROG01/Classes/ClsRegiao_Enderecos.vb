
Imports System.Data.SqlClient


''' <summary>
'''      Classe ClsRegiao_Enderecos Classe da Tabela Regiao_Enderecos
'''      Gerado em 08/10/2024 13:36:12
''' </summary>
''' <remarks>
'''      (c) ETLA - PM-2024
''' </remarks>
Public Class ClsRegiao_Enderecos


    ' -----------------------------------------
    ' Property's da tabela Regiao_Enderecos
    ' -----------------------------------------

    Public Property Cod_Distrito As String                                  ' Len:  2 - SQL_Type: nvarchar
    Public Property Cod_Concelho As String                                  ' Len:  2 - SQL_Type: nvarchar
    Public Property Cod_Postal As String                                    ' Len:  8 - SQL_Type: nvarchar
    Public Property Endereco As String                                      ' Len: 80 - SQL_Type: nvarchar
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

    'Return "R" & ClsEmpresas.GetContador(enCont.Regiao_Enderecos).ToString("000")' <-------------- VERIFICAR O Nº de ZEROS

    'End Function


    ''' <summary>
    '''      Function GetRegiao_Enderecos() Método para devolver a Lista de Regiao_Enderecos
    '''      Gerado em 08/10/2024 13:36:12
    ''' </summary>
    ''' <returns>
    '''      mListaRegiao_Enderecos
    ''' </returns>
    ''' <remarks>
    '''      (c) ETLA - PM-2024
    ''' </remarks>
    Public Shared Function GetRegiao_Enderecos() As List(Of ClsRegiao_Enderecos)
        Dim mListaRegiao_Enderecos As New List(Of ClsRegiao_Enderecos)

        Dim mStrSQL As String
        Dim mDB As New SqlConnection
        Dim mCMD As New SqlCommand
        Dim mRDR As SqlDataReader

        mDB.ConnectionString = My.Settings.Connection
        mCMD.Parameters.Clear()

        mStrSQL = "SELECT "
        mStrSQL += "ISNULL(Cod_Distrito,'') As Cod_Distrito,"
        mStrSQL += "ISNULL(Cod_Concelho,'') As Cod_Concelho,"
        mStrSQL += "ISNULL(Cod_Postal,'') As Cod_Postal,"
        mStrSQL += "ISNULL(Endereco,'') As Endereco,"
        mStrSQL += "ISNULL(Localidade,'') As Localidade,"
        mStrSQL += "ISNULL(FLG_Ativo,0) As FLG_Ativo "
        mStrSQL += "FROM Regiao_Enderecos "
        mStrSQL += "WHERE FLG_Ativo=1"


        mCMD.CommandText = mStrSQL
        mDB.Open()
        mCMD.Connection = mDB

        mRDR = mCMD.ExecuteReader

        While mRDR.Read()

            Dim mClsRegiao_Enderecos As New ClsRegiao_Enderecos

            With mClsRegiao_Enderecos
                .Cod_Distrito = mRDR.GetString(mRDR.GetOrdinal("Cod_Distrito"))
                .Cod_Concelho = mRDR.GetString(mRDR.GetOrdinal("Cod_Concelho"))
                .Cod_Postal = mRDR.GetString(mRDR.GetOrdinal("Cod_Postal"))
                .Endereco = mRDR.GetString(mRDR.GetOrdinal("Endereco"))
                .Localidade = mRDR.GetString(mRDR.GetOrdinal("Localidade"))
                .FLG_Ativo = mRDR.GetBoolean(mRDR.GetOrdinal("FLG_Ativo"))
            End With


            mListaRegiao_Enderecos.Add(mClsRegiao_Enderecos)

        End While

        mRDR.Close()
        mDB.Close()

        Return mListaRegiao_Enderecos
    End Function

    ''' <summary>
    '''      Function FiltrarRegiao_Enderecos Método para Filtrar os campos da lista de Regiao_Enderecos
    '''      Gerado em 08/10/2024 13:36:12
    ''' </summary>
    ''' <returns>
    '''      mListaRegiao_Enderecos
    ''' </returns>
    ''' <remarks>
    '''      (c) ETLA - PM-2024
    ''' </remarks>
    Public Shared Function FiltrarRegiao_Enderecos(ByVal pFiltro As ClsRegiao_Enderecos) As List(Of ClsRegiao_Enderecos)
        Dim mListaRegiao_Enderecos As New List(Of ClsRegiao_Enderecos)
        Dim mLista As New List(Of ClsRegiao_Enderecos)

        mListaRegiao_Enderecos = GetRegiao_Enderecos()

        mLista = mListaRegiao_Enderecos.FindAll(Function(x) _
        x.Cod_Distrito.Contains(pFiltro.Cod_Distrito)
        )
        '-----------------------------------------------------
        'Pode Colocar em cima mais colunas como esta abaixo...
        '-----------------------------------------------------
        ' AND x.Cod_Concelho.Contains(pFiltro.Cod_Concelho) 

        Return mLista
    End Function


    ''' <summary>
    '''      Function GetRegiao_EnderecosByCod(ByVal pCod_Distrito As String) Método para decolver uma Classe de Regiao_Enderecos
    '''      Gerado em 08/10/2024 13:36:12
    ''' </summary>
    ''' <returns>
    '''      mClsRegiao_Enderecos
    ''' </returns>
    ''' <remarks>
    '''      (c) ETLA - PM-2024
    ''' </remarks>
    Public Shared Function GetRegiao_EnderecosByCod(ByVal pCod_Distrito As String) As ClsRegiao_Enderecos
        Dim mClsRegiao_Enderecos As New ClsRegiao_Enderecos

        Dim mStrSQL As String
        Dim mDB As New SqlConnection
        Dim mCMD As New SqlCommand
        Dim mRDR As SqlDataReader

        mDB.ConnectionString = My.Settings.Connection
        mCMD.Parameters.Clear()
        mCMD.Parameters.AddWithValue("@pCod_Distrito", pCod_Distrito)


        mStrSQL = "SELECT "
        mStrSQL += "ISNULL(Cod_Distrito,'') As Cod_Distrito,"
        mStrSQL += "ISNULL(Cod_Concelho,'') As Cod_Concelho,"
        mStrSQL += "ISNULL(Cod_Postal,'') As Cod_Postal,"
        mStrSQL += "ISNULL(Endereco,'') As Endereco,"
        mStrSQL += "ISNULL(Localidade,'') As Localidade,"
        mStrSQL += "ISNULL(FLG_Ativo,0) As FLG_Ativo "
        mStrSQL += "FROM Regiao_Enderecos "
        mStrSQL += "WHERE FLG_Ativo=1 "
        mStrSQL += "AND Cod_Distrito=@pCod_Distrito"


        mCMD.CommandText = mStrSQL
        mDB.Open()
        mCMD.Connection = mDB

        mRDR = mCMD.ExecuteReader

        If mRDR.Read() Then


            With mClsRegiao_Enderecos
                .Cod_Distrito = mRDR.GetString(mRDR.GetOrdinal("Cod_Distrito"))
                .Cod_Concelho = mRDR.GetString(mRDR.GetOrdinal("Cod_Concelho"))
                .Cod_Postal = mRDR.GetString(mRDR.GetOrdinal("Cod_Postal"))
                .Endereco = mRDR.GetString(mRDR.GetOrdinal("Endereco"))
                .Localidade = mRDR.GetString(mRDR.GetOrdinal("Localidade"))
                .FLG_Ativo = mRDR.GetBoolean(mRDR.GetOrdinal("FLG_Ativo"))
            End With


        End If
        mRDR.Close()
        mDB.Close()

        Return mClsRegiao_Enderecos
    End Function


    ''' <summary>
    '''      Function ModificaRegiao_Enderecos(ByVal pClsRegiao_Enderecos As ClsRegiao_Enderecos) Método para Modificar a TABELA Regiao_Enderecos
    '''      Gerado em 08/10/2024 13:36:12
    ''' </summary>
    ''' <returns>
    '''      Boolean
    ''' </returns>
    ''' <remarks>
    '''      (c) ETLA - PM-2024
    ''' </remarks>
    Public Shared Function ModificaRegiao_Enderecos(ByVal pClsRegiao_Enderecos As ClsRegiao_Enderecos) As Boolean
        Dim mReturn As Boolean = True

        Dim mStrSQL As String
        Dim mDB As New SqlConnection
        Dim mCMD As New SqlCommand

        mCMD.Parameters.Clear()
        mCMD.Parameters.AddWithValue("@pCod_Distrito", pClsRegiao_Enderecos.Cod_Distrito.Substring(0, IIf(Len(pClsRegiao_Enderecos.Cod_Distrito) > 2, 2, Len(pClsRegiao_Enderecos.Cod_Distrito))))
        mCMD.Parameters.AddWithValue("@pCod_Concelho", pClsRegiao_Enderecos.Cod_Concelho.Substring(0, IIf(Len(pClsRegiao_Enderecos.Cod_Concelho) > 2, 2, Len(pClsRegiao_Enderecos.Cod_Concelho))))
        mCMD.Parameters.AddWithValue("@pCod_Postal", pClsRegiao_Enderecos.Cod_Postal.Substring(0, IIf(Len(pClsRegiao_Enderecos.Cod_Postal) > 8, 8, Len(pClsRegiao_Enderecos.Cod_Postal))))
        mCMD.Parameters.AddWithValue("@pEndereco", pClsRegiao_Enderecos.Endereco.Substring(0, IIf(Len(pClsRegiao_Enderecos.Endereco) > 80, 80, Len(pClsRegiao_Enderecos.Endereco))))
        mCMD.Parameters.AddWithValue("@pLocalidade", pClsRegiao_Enderecos.Localidade.Substring(0, IIf(Len(pClsRegiao_Enderecos.Localidade) > 50, 50, Len(pClsRegiao_Enderecos.Localidade))))


        mStrSQL = "UPDATE Regiao_Enderecos SET "
        mStrSQL += "Cod_Concelho=@pCod_Concelho,"
        mStrSQL += "Cod_Postal=@pCod_Postal,"
        mStrSQL += "Endereco=@pEndereco,"
        mStrSQL += "Localidade=@pLocalidade "
        mStrSQL += "WHERE Cod_Distrito=@pCod_Distrito"


        mDB.ConnectionString = My.Settings.Connection
        mCMD.CommandText = mStrSQL
        mDB.Open()
        mCMD.Connection = mDB

        Try
            mCMD.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("ModificaRegiao_Enderecos:" + vbCrLf + "Erro ao Gravar!!!" + vbCrLf + ex.ToString)
            mReturn = False
        End Try

        mDB.Close()

        Return mReturn

    End Function


    ''' <summary>
    '''      Function GravaRegiao_Enderecos(ByVal pNovoRegiao_Enderecos As ClsRegiao_Enderecos) Método para Gravar a TABELA Regiao_Enderecos
    '''      Gerado em 08/10/2024 13:36:12
    ''' </summary>
    ''' <returns>
    '''      Boolean
    ''' </returns>
    ''' <remarks>
    '''      (c) ETLA - PM-2024
    ''' </remarks>
    Public Shared Function GravaRegiao_Enderecos(ByVal pNovoRegiao_Enderecos As ClsRegiao_Enderecos) As Boolean
        Dim mReturn As Boolean = True

        Dim mStrSQL As String
        Dim mDB As New SqlConnection
        Dim mCMD As New SqlCommand

        mDB.ConnectionString = My.Settings.Connection
        mCMD.Parameters.Clear()


        mCMD.Parameters.AddWithValue("@pCod_Distrito", pNovoRegiao_Enderecos.Cod_Distrito.Substring(0, IIf(Len(pNovoRegiao_Enderecos.Cod_Distrito) > 2, 2, Len(pNovoRegiao_Enderecos.Cod_Distrito))))
        mCMD.Parameters.AddWithValue("@pCod_Concelho", pNovoRegiao_Enderecos.Cod_Concelho.Substring(0, IIf(Len(pNovoRegiao_Enderecos.Cod_Concelho) > 2, 2, Len(pNovoRegiao_Enderecos.Cod_Concelho))))
        mCMD.Parameters.AddWithValue("@pCod_Postal", pNovoRegiao_Enderecos.Cod_Postal.Substring(0, IIf(Len(pNovoRegiao_Enderecos.Cod_Postal) > 8, 8, Len(pNovoRegiao_Enderecos.Cod_Postal))))
        mCMD.Parameters.AddWithValue("@pEndereco", pNovoRegiao_Enderecos.Endereco.Substring(0, IIf(Len(pNovoRegiao_Enderecos.Endereco) > 80, 80, Len(pNovoRegiao_Enderecos.Endereco))))
        mCMD.Parameters.AddWithValue("@pLocalidade", pNovoRegiao_Enderecos.Localidade.Substring(0, IIf(Len(pNovoRegiao_Enderecos.Localidade) > 50, 50, Len(pNovoRegiao_Enderecos.Localidade))))
        mCMD.Parameters.AddWithValue("@pFLG_Ativo", pNovoRegiao_Enderecos.FLG_Ativo)


        mStrSQL = "INSERT INTO Regiao_Enderecos "
        mStrSQL += "("
        mStrSQL += "Cod_Distrito,"
        mStrSQL += "Cod_Concelho,"
        mStrSQL += "Cod_Postal,"
        mStrSQL += "Endereco,"
        mStrSQL += "Localidade,"
        mStrSQL += "FLG_Ativo "
        mStrSQL += ") "
        mStrSQL += "VALUES "
        mStrSQL += "("
        mStrSQL += "@pCod_Distrito,"
        mStrSQL += "@pCod_Concelho,"
        mStrSQL += "@pCod_Postal,"
        mStrSQL += "@pEndereco,"
        mStrSQL += "@pLocalidade,"
        mStrSQL += "1"
        mStrSQL += ")"


        mCMD.CommandText = mStrSQL
        mDB.Open()
        mCMD.Connection = mDB

        Try
            mCMD.ExecuteNonQuery()
            'ClsEmpresas.GravaContador(enCont.Regiao_Enderecos)'<<<<-------- Verificar se é  preciso...
        Catch ex As Exception
            MsgBox("GravaRegiao_Enderecos:" + vbCrLf + "Erro ao Gravar!!!" + vbCrLf + ex.ToString)
            mReturn = False
        End Try

        mDB.Close()

        Return mReturn

    End Function


    ''' <summary>
    '''      Function ApagaRegiao_Enderecos(ByVal pCod_Distrito As String) Método para Apagar um Registo da Tabela Regiao_Enderecos
    '''      Gerado em 08/10/2024 13:36:12
    ''' </summary>
    ''' <returns>
    '''      Boolean
    ''' </returns>
    ''' <remarks>
    '''      (c) ETLA - PM-2024
    ''' </remarks>
    Public Shared Function ApagaRegiao_Enderecos(ByVal pCod_Distrito As String) As Boolean
        Dim mReturn As Boolean = True

        Dim mStrSQL As String
        Dim mDB As New SqlConnection
        Dim mCMD As New SqlCommand

        mCMD.Parameters.Clear()

        mCMD.Parameters.AddWithValue("@pCod_Distrito", pCod_Distrito)


        mStrSQL = "UPDATE Regiao_Enderecos SET "
        mStrSQL += "FLG_Ativo=0 "
        mStrSQL += "WHERE Cod_Distrito=@pCod_Distrito"


        mDB.ConnectionString = My.Settings.Connection
        mCMD.CommandText = mStrSQL
        mDB.Open()
        mCMD.Connection = mDB

        Try
            mCMD.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("ApagaRegiao_Enderecos:" + vbCrLf + "Erro ao Gravar!!!" + vbCrLf + ex.ToString)
            mReturn = False
        End Try

        mDB.Close()

        Return mReturn

    End Function
End Class



''' <summary>
'''      Classe Regiao_EnderecosComparer 
'''      Gerado em 08/10/2024 13:36:12
''' </summary>
''' <remarks>
'''      (c) ETLA - PM-2024
''' </remarks>
Public Class Regiao_EnderecosComparer
    Implements IEqualityComparer(Of ClsRegiao_Enderecos)

    Public Function Equals1(ByVal x As ClsRegiao_Enderecos, ByVal y As ClsRegiao_Enderecos) As Boolean Implements IEqualityComparer(Of ClsRegiao_Enderecos).Equals

        If x Is y Then Return True

        If x Is Nothing OrElse y Is Nothing Then Return False

        Return (x.Cod_Distrito = y.Cod_Distrito) ' AndAlso (x.Cod_Concelho = y.Cod_Concelho)
    End Function

    Public Function GetHashCode1(ByVal pCls As ClsRegiao_Enderecos) As Integer Implements IEqualityComparer(Of ClsRegiao_Enderecos).GetHashCode

        If pCls Is Nothing Then Return 0

        'Dim Hash_ClsRegiao_Enderecos_Cod_Concelho = pCls.Cod_Concelho.GetHashCode()
        Dim Hash_ClsRegiao_Enderecos_Cod_Distrito = pCls.Cod_Distrito.GetHashCode()

        Return Hash_ClsRegiao_Enderecos_Cod_Distrito 'Xor Hash_ClsRegiao_Enderecos_Cod_Concelho
    End Function
End Class
