
Imports System.Data.SqlClient
Imports DevExpress.XtraTreeList.Features.OfficeScrolling


Public Class ClsLogins
    Public Property Login As String
    Public Property Password As String
    Public Property Num_Cartao As String
    Public Property FLG_Entidade As String

    Public Shared Function GetLoginByUsername(ByVal pUsername As String) As ClsLogins
        Dim mClsLogins As New ClsLogins

        Dim mStrSQL As String
        Dim mDB As New SqlConnection
        Dim mCMD As New SqlCommand
        Dim mRDR As SqlDataReader

        mDB.ConnectionString = My.Settings.Connection
        mCMD.Parameters.Clear()
        mCMD.Parameters.AddWithValue("@pUsername", pUsername)


        mStrSQL = "SELECT "
        mStrSQL += "ISNULL(FLG_Entidade,'') As FLG_Entidade,"
        mStrSQL += "ISNULL(Login,'') As Login,"
        mStrSQL += "ISNULL(Password,'') As Password, "
        mStrSQL += "ISNULL(Num_Cartao,'') As Num_Cartao "
        mStrSQL += "FROM Entidades "
        mStrSQL += "WHERE FLG_Ativo=1 "
        mStrSQL += "and Login=@pUsername"

        mCMD.CommandText = mStrSQL
        mDB.Open()
        mCMD.Connection = mDB

        mRDR = mCMD.ExecuteReader

        If mRDR.Read() Then


            With mClsLogins
                .FLG_Entidade = mRDR.GetString(mRDR.GetOrdinal("FLG_Entidade"))
                .Login = mRDR.GetString(mRDR.GetOrdinal("Login"))
                .Password = mRDR.GetString(mRDR.GetOrdinal("Password"))
                .Num_Cartao = mRDR.GetString(mRDR.GetOrdinal("Num_Cartao"))
            End With


        End If
        mRDR.Close()
        mDB.Close()

        Return mClsLogins
    End Function


End Class

''' <summary>
'''      Classe ClsEntidades Classe da Tabela Entidades
'''      Gerado em 23/01/2025 15:59:29
''' </summary>
''' <remarks>
'''      (c) ETLA - PM-2025
''' </remarks>
''' 

Public Class ClsEntidades


    ' -----------------------------------------
    ' Property's da tabela Entidades
    ' -----------------------------------------

    Public Property Cod_Entidade As String                                  ' Len:  5 - SQL_Type: nvarchar
    Public Property FLG_Entidade As String                                  ' Len:  1 - SQL_Type: nvarchar
    Public Property Num_Cartao As String                                  ' Len:  20 - SQL_Type: nvarchar
    Public Property Login As String                                         ' Len: 25 - SQL_Type: nvarchar
    Public Property Password As String                                      ' Len: 25 - SQL_Type: nvarchar
    Public Property Nome As String                                          ' Len: 80 - SQL_Type: nvarchar
    Public Property Cod_Imagem As String                                    ' Len: 30 - SQL_Type: nvarchar
    Public ReadOnly Property Localidade As String                                   ' SQL_Type: int
        Get
            Return ClsEnderecos.GetEnderecosByCod(Cod_Entidade, "E01").Localidade
        End Get
    End Property
    Public ReadOnly Property Cod_Postal As String                                    ' Len:  8 - SQL_Type: nvarchar
        Get
            Return ClsEnderecos.GetEnderecosByCod(Cod_Entidade, "E01").Cod_Postal
        End Get
    End Property
    Public ReadOnly Property Endereco As String
        Get
            Return ClsEnderecos.GetEnderecosByCod(Cod_Entidade, "E01").Endereco
        End Get
    End Property
    Public Property Num_Telefone As String                                  ' Len: 15 - SQL_Type: nvarchar
    Public Property Num_Telemovel As String                                 ' Len: 15 - SQL_Type: nvarchar
    Public Property Email As String                                         ' Len: 80 - SQL_Type: nvarchar
    Public Property NIF As String                                           ' Len: 20 - SQL_Type: nvarchar
    Public Property Data_Registo As Date                                    ' SQL_Type: smalldatetime
    Public Property FLG_Ativo As Boolean                                    ' SQL_Type: bit


    Sub New()
    End Sub


    '--------------------------------------------
    ' Exemplo de criador de Código por contador
    ' Para ser usado no caso de o Cdigo ser gerado
    ' e o contador existir na tabela Empresas
    '---------------------------------------------

    Friend Shared Function GetNovoCodigo(pFLG_Entidade As String) As String

        Dim mEnc As New enCont
        Select Case pFLG_Entidade
            Case "C"
                mEnc = enCont.Clientes
            Case "F"
                mEnc = enCont.Fornecedores
            Case "E"
                mEnc = enCont.Empregados
            Case "M"
                mEnc = enCont.Motoristas
        End Select

        Return pFLG_Entidade & ClsEmpresas.GetContador(mEnc).ToString("000") ' <-------------- VERIFICAR O Nº de ZEROS

    End Function


    Public Shared Function GetEntidadesByFLG(ByVal pFLG_Entidade As String) As List(Of ClsEntidades)
        Dim mListaEntidades As New List(Of ClsEntidades)

        Dim mStrSQL As String
        Dim mDB As New SqlConnection
        Dim mCMD As New SqlCommand
        Dim mRDR As SqlDataReader

        mDB.ConnectionString = My.Settings.Connection
        mCMD.Parameters.Clear()
        mCMD.Parameters.AddWithValue("@pFLG_Entidade", pFLG_Entidade)

        mStrSQL = "SELECT "
        mStrSQL += "ISNULL(Cod_Entidade,'') As Cod_Entidade,"
        mStrSQL += "ISNULL(FLG_Entidade,'') As FLG_Entidade,"
        mStrSQL += "ISNULL(Num_Cartao,'') As Num_Cartao,"
        mStrSQL += "ISNULL(Login,'') As Login,"
        mStrSQL += "ISNULL(Password,'') As Password,"
        mStrSQL += "ISNULL(Nome,'') As Nome,"
        mStrSQL += "ISNULL(Cod_Imagem,'') As Cod_Imagem,"

        mStrSQL += "ISNULL(Num_Telefone,'') As Num_Telefone,"
        mStrSQL += "ISNULL(Num_Telemovel,'') As Num_Telemovel,"
        mStrSQL += "ISNULL(Email,'') As Email,"
        mStrSQL += "ISNULL(NIF,'') As NIF,"
        mStrSQL += "ISNULL(Data_Registo,0) As Data_Registo,"
        mStrSQL += "ISNULL(FLG_Ativo,1) As FLG_Ativo "
        mStrSQL += "FROM Entidades "
        mStrSQL += "WHERE FLG_Ativo=1 AND FLG_Entidade=@pFLG_Entidade"


        mCMD.CommandText = mStrSQL
        mDB.Open()
        mCMD.Connection = mDB

        mRDR = mCMD.ExecuteReader

        While mRDR.Read()

            Dim mClsEntidades As New ClsEntidades

            With mClsEntidades
                .Cod_Entidade = mRDR.GetString(mRDR.GetOrdinal("Cod_Entidade"))
                .FLG_Entidade = mRDR.GetString(mRDR.GetOrdinal("FLG_Entidade"))
                .Num_Cartao = mRDR.GetString(mRDR.GetOrdinal("Num_Cartao"))
                .Login = mRDR.GetString(mRDR.GetOrdinal("Login"))
                .Password = mRDR.GetString(mRDR.GetOrdinal("Password"))
                .Nome = mRDR.GetString(mRDR.GetOrdinal("Nome"))
                .Cod_Imagem = mRDR.GetString(mRDR.GetOrdinal("Cod_Imagem"))

                .Num_Telefone = mRDR.GetString(mRDR.GetOrdinal("Num_Telefone"))
                .Num_Telemovel = mRDR.GetString(mRDR.GetOrdinal("Num_Telemovel"))
                .Email = mRDR.GetString(mRDR.GetOrdinal("Email"))
                .NIF = mRDR.GetString(mRDR.GetOrdinal("NIF"))
                .Data_Registo = mRDR.GetDateTime(mRDR.GetOrdinal("Data_Registo"))
                .FLG_Ativo = mRDR.GetBoolean(mRDR.GetOrdinal("FLG_Ativo"))
            End With


            mListaEntidades.Add(mClsEntidades)

        End While

        mRDR.Close()
        mDB.Close()

        Return mListaEntidades
    End Function

    ''' <summary>
    '''      Function GetEntidades() Método para devolver a Lista de Entidades
    '''      Gerado em 23/01/2025 15:59:29
    ''' </summary>
    ''' <returns>
    '''      mListaEntidades
    ''' </returns>
    ''' <remarks>
    '''      (c) ETLA - PM-2025
    ''' </remarks>

    Public Shared Function GetEntidades() As List(Of ClsEntidades)
        Dim mListaEntidades As New List(Of ClsEntidades)

        Dim mStrSQL As String
        Dim mDB As New SqlConnection
        Dim mCMD As New SqlCommand
        Dim mRDR As SqlDataReader

        mDB.ConnectionString = My.Settings.Connection
        mCMD.Parameters.Clear()

        mStrSQL = "SELECT "
        mStrSQL += "ISNULL(Cod_Entidade,'') As Cod_Entidade,"
        mStrSQL += "ISNULL(FLG_Entidade,'') As FLG_Entidade,"
        mStrSQL += "ISNULL(Num_Cartao,'') As Num_Cartao,"
        mStrSQL += "ISNULL(Login,'') As Login,"
        mStrSQL += "ISNULL(Password,'') As Password,"
        mStrSQL += "ISNULL(Nome,'') As Nome,"
        mStrSQL += "ISNULL(Cod_Imagem,'') As Cod_Imagem,"
        mStrSQL += "ISNULL(Num_Telefone,'') As Num_Telefone,"
        mStrSQL += "ISNULL(Num_Telemovel,'') As Num_Telemovel,"
        mStrSQL += "ISNULL(Email,'') As Email,"
        mStrSQL += "ISNULL(NIF,'') As NIF,"
        mStrSQL += "ISNULL(Data_Registo,0) As Data_Registo,"
        mStrSQL += "ISNULL(FLG_Ativo,1) As FLG_Ativo "
        mStrSQL += "FROM Entidades "
        mStrSQL += "WHERE FLG_Ativo=1"


        mCMD.CommandText = mStrSQL
        mDB.Open()
        mCMD.Connection = mDB

        mRDR = mCMD.ExecuteReader

        While mRDR.Read()

            Dim mClsEntidades As New ClsEntidades

            With mClsEntidades
                .Cod_Entidade = mRDR.GetString(mRDR.GetOrdinal("Cod_Entidade"))
                .FLG_Entidade = mRDR.GetString(mRDR.GetOrdinal("FLG_Entidade"))
                .Num_Cartao = mRDR.GetString(mRDR.GetOrdinal("Num_Cartao"))
                .Login = mRDR.GetString(mRDR.GetOrdinal("Login"))
                .Password = mRDR.GetString(mRDR.GetOrdinal("Password"))
                .Nome = mRDR.GetString(mRDR.GetOrdinal("Nome"))
                .Cod_Imagem = mRDR.GetString(mRDR.GetOrdinal("Cod_Imagem"))
                .Num_Telefone = mRDR.GetString(mRDR.GetOrdinal("Num_Telefone"))
                .Num_Telemovel = mRDR.GetString(mRDR.GetOrdinal("Num_Telemovel"))
                .Email = mRDR.GetString(mRDR.GetOrdinal("Email"))
                .NIF = mRDR.GetString(mRDR.GetOrdinal("NIF"))
                .Data_Registo = mRDR.GetDateTime(mRDR.GetOrdinal("Data_Registo"))
                .FLG_Ativo = mRDR.GetBoolean(mRDR.GetOrdinal("FLG_Ativo"))
            End With


            mListaEntidades.Add(mClsEntidades)

        End While

        mRDR.Close()
        mDB.Close()

        Return mListaEntidades
    End Function

    ''' <summary>
    '''      Function FiltrarEntidades Método para Filtrar os campos da lista de Entidades
    '''      Gerado em 23/01/2025 15:59:29
    ''' </summary>
    ''' <returns>
    '''      mListaEntidades
    ''' </returns>
    ''' <remarks>
    '''      (c) ETLA - PM-2025
    ''' </remarks>
    Public Shared Function FiltrarEntidades(ByVal pFiltro As ClsEntidades) As List(Of ClsEntidades)
        Dim mListaEntidades As New List(Of ClsEntidades)
        Dim mLista As New List(Of ClsEntidades)

        mListaEntidades = GetEntidades()

        mLista = mListaEntidades.FindAll(Function(x) _
        x.Cod_Entidade.Contains(pFiltro.Cod_Entidade)
        )
        '-----------------------------------------------------
        'Pode Colocar em cima mais colunas como esta abaixo...
        '-----------------------------------------------------
        ' AND x.FLG_Entidade.Contains(pFiltro.FLG_Entidade) 

        Return mLista
    End Function


    ''' <summary>
    '''      Function GetEntidadesByCod(ByVal pCod_Entidade As String) Método para decolver uma Classe de Entidades
    '''      Gerado em 23/01/2025 15:59:29
    ''' </summary>
    ''' <returns>
    '''      mClsEntidades
    ''' </returns>
    ''' <remarks>
    '''      (c) ETLA - PM-2025
    ''' </remarks>
    Public Shared Function GetEntidadesByCod(ByVal pCod_Entidade As String) As ClsEntidades
        Dim mClsEntidades As New ClsEntidades

        Dim mStrSQL As String
        Dim mDB As New SqlConnection
        Dim mCMD As New SqlCommand
        Dim mRDR As SqlDataReader

        mDB.ConnectionString = My.Settings.Connection
        mCMD.Parameters.Clear()
        mCMD.Parameters.AddWithValue("@pCod_Entidade", pCod_Entidade)


        mStrSQL = "SELECT "
        mStrSQL += "ISNULL(Cod_Entidade,'') As Cod_Entidade,"
        mStrSQL += "ISNULL(FLG_Entidade,'') As FLG_Entidade,"
        mStrSQL += "ISNULL(Num_Cartao,'') As Num_Cartao,"
        mStrSQL += "ISNULL(Login,'') As Login,"
        mStrSQL += "ISNULL(Password,'') As Password,"
        mStrSQL += "ISNULL(Nome,'') As Nome,"
        mStrSQL += "ISNULL(Cod_Imagem,'') As Cod_Imagem,"
        mStrSQL += "ISNULL(Num_Telefone,'') As Num_Telefone,"
        mStrSQL += "ISNULL(Num_Telemovel,'') As Num_Telemovel,"
        mStrSQL += "ISNULL(Email,'') As Email,"
        mStrSQL += "ISNULL(NIF,'') As NIF,"
        mStrSQL += "ISNULL(Data_Registo,0) As Data_Registo,"
        mStrSQL += "ISNULL(FLG_Ativo,1) As FLG_Ativo "
        mStrSQL += "FROM Entidades "
        mStrSQL += "WHERE FLG_Ativo=1 "
        mStrSQL += "AND Cod_Entidade=@pCod_Entidade"


        mCMD.CommandText = mStrSQL
        mDB.Open()
        mCMD.Connection = mDB

        mRDR = mCMD.ExecuteReader

        If mRDR.Read() Then


            With mClsEntidades
                .Cod_Entidade = mRDR.GetString(mRDR.GetOrdinal("Cod_Entidade"))
                .FLG_Entidade = mRDR.GetString(mRDR.GetOrdinal("FLG_Entidade"))
                .Num_Cartao = mRDR.GetString(mRDR.GetOrdinal("Num_Cartao"))
                .Login = mRDR.GetString(mRDR.GetOrdinal("Login"))
                .Password = mRDR.GetString(mRDR.GetOrdinal("Password"))
                .Nome = mRDR.GetString(mRDR.GetOrdinal("Nome"))
                .Cod_Imagem = mRDR.GetString(mRDR.GetOrdinal("Cod_Imagem"))
                .Num_Telefone = mRDR.GetString(mRDR.GetOrdinal("Num_Telefone"))
                .Num_Telemovel = mRDR.GetString(mRDR.GetOrdinal("Num_Telemovel"))
                .Email = mRDR.GetString(mRDR.GetOrdinal("Email"))
                .NIF = mRDR.GetString(mRDR.GetOrdinal("NIF"))
                .Data_Registo = mRDR.GetDateTime(mRDR.GetOrdinal("Data_Registo"))
                .FLG_Ativo = mRDR.GetBoolean(mRDR.GetOrdinal("FLG_Ativo"))
            End With


        End If
        mRDR.Close()
        mDB.Close()

        Return mClsEntidades
    End Function


    Public Shared Function GetEntidadesByCard(ByVal pNum_Cartao As String) As ClsEntidades
        Dim mClsEntidades As New ClsEntidades

        Dim mStrSQL As String
        Dim mDB As New SqlConnection
        Dim mCMD As New SqlCommand
        Dim mRDR As SqlDataReader

        mDB.ConnectionString = My.Settings.Connection
        mCMD.Parameters.Clear()
        mCMD.Parameters.AddWithValue("@pNum_Cartao", pNum_Cartao)


        mStrSQL = "SELECT "
        mStrSQL += "ISNULL(Cod_Entidade,'') As Cod_Entidade,"
        mStrSQL += "ISNULL(FLG_Entidade,'') As FLG_Entidade,"
        mStrSQL += "ISNULL(Num_Cartao,'') As Num_Cartao,"
        mStrSQL += "ISNULL(Login,'') As Login,"
        mStrSQL += "ISNULL(Password,'') As Password,"
        mStrSQL += "ISNULL(Nome,'') As Nome,"
        mStrSQL += "ISNULL(Cod_Imagem,'') As Cod_Imagem,"
        mStrSQL += "ISNULL(Num_Telefone,'') As Num_Telefone,"
        mStrSQL += "ISNULL(Num_Telemovel,'') As Num_Telemovel,"
        mStrSQL += "ISNULL(Email,'') As Email,"
        mStrSQL += "ISNULL(NIF,'') As NIF,"
        mStrSQL += "ISNULL(Data_Registo,0) As Data_Registo,"
        mStrSQL += "ISNULL(FLG_Ativo,1) As FLG_Ativo "
        mStrSQL += "FROM Entidades "
        mStrSQL += "WHERE FLG_Ativo=1 "
        mStrSQL += "AND Num_Cartao=@pNum_Cartao"


        mCMD.CommandText = mStrSQL
        mDB.Open()
        mCMD.Connection = mDB

        mRDR = mCMD.ExecuteReader

        If mRDR.Read() Then


            With mClsEntidades
                .Cod_Entidade = mRDR.GetString(mRDR.GetOrdinal("Cod_Entidade"))
                .FLG_Entidade = mRDR.GetString(mRDR.GetOrdinal("FLG_Entidade"))
                .Num_Cartao = mRDR.GetString(mRDR.GetOrdinal("Num_Cartao"))
                .Login = mRDR.GetString(mRDR.GetOrdinal("Login"))
                .Password = mRDR.GetString(mRDR.GetOrdinal("Password"))
                .Nome = mRDR.GetString(mRDR.GetOrdinal("Nome"))
                .Cod_Imagem = mRDR.GetString(mRDR.GetOrdinal("Cod_Imagem"))
                .Num_Telefone = mRDR.GetString(mRDR.GetOrdinal("Num_Telefone"))
                .Num_Telemovel = mRDR.GetString(mRDR.GetOrdinal("Num_Telemovel"))
                .Email = mRDR.GetString(mRDR.GetOrdinal("Email"))
                .NIF = mRDR.GetString(mRDR.GetOrdinal("NIF"))
                .Data_Registo = mRDR.GetDateTime(mRDR.GetOrdinal("Data_Registo"))
                .FLG_Ativo = mRDR.GetBoolean(mRDR.GetOrdinal("FLG_Ativo"))
            End With


        End If
        mRDR.Close()
        mDB.Close()

        Return mClsEntidades
    End Function


    ''' <summary>
    '''      Function ModificaEntidades(ByVal pClsEntidades As ClsEntidades) Método para Modificar a TABELA Entidades
    '''      Gerado em 23/01/2025 15:59:29
    ''' </summary>
    ''' <returns>
    '''      Boolean
    ''' </returns>
    ''' <remarks>
    '''      (c) ETLA - PM-2025
    ''' </remarks>
    Public Shared Function ModificaEntidades(ByVal pClsEntidades As ClsEntidades) As Boolean
        Dim mReturn As Boolean = True

        Dim mStrSQL As String
        Dim mDB As New SqlConnection
        Dim mCMD As New SqlCommand

        mCMD.Parameters.Clear()
        mCMD.Parameters.AddWithValue("@pCod_Entidade", pClsEntidades.Cod_Entidade.Substring(0, IIf(Len(pClsEntidades.Cod_Entidade) > 5, 5, Len(pClsEntidades.Cod_Entidade))))
        mCMD.Parameters.AddWithValue("@pFLG_Entidade", pClsEntidades.FLG_Entidade.Substring(0, IIf(Len(pClsEntidades.FLG_Entidade) > 1, 1, Len(pClsEntidades.FLG_Entidade))))
        mCMD.Parameters.AddWithValue("@pLogin", pClsEntidades.Login.Substring(0, IIf(Len(pClsEntidades.Login) > 25, 25, Len(pClsEntidades.Login))))
        mCMD.Parameters.AddWithValue("@pNum_Cartao", pClsEntidades.Num_Cartao.Substring(0, IIf(Len(pClsEntidades.Num_Cartao) > 20, 20, Len(pClsEntidades.Num_Cartao))))
        mCMD.Parameters.AddWithValue("@pPassword", pClsEntidades.Password.Substring(0, IIf(Len(pClsEntidades.Password) > 25, 25, Len(pClsEntidades.Password))))
        mCMD.Parameters.AddWithValue("@pNome", pClsEntidades.Nome.Substring(0, IIf(Len(pClsEntidades.Nome) > 80, 80, Len(pClsEntidades.Nome))))
        mCMD.Parameters.AddWithValue("@pCod_Imagem", pClsEntidades.Cod_Imagem.Substring(0, IIf(Len(pClsEntidades.Cod_Imagem) > 30, 30, Len(pClsEntidades.Cod_Imagem))))
        mCMD.Parameters.AddWithValue("@pNum_Telefone", pClsEntidades.Num_Telefone.Substring(0, IIf(Len(pClsEntidades.Num_Telefone) > 15, 15, Len(pClsEntidades.Num_Telefone))))
        mCMD.Parameters.AddWithValue("@pNum_Telemovel", pClsEntidades.Num_Telemovel.Substring(0, IIf(Len(pClsEntidades.Num_Telemovel) > 15, 15, Len(pClsEntidades.Num_Telemovel))))
        mCMD.Parameters.AddWithValue("@pEmail", pClsEntidades.Email.Substring(0, IIf(Len(pClsEntidades.Email) > 80, 80, Len(pClsEntidades.Email))))
        mCMD.Parameters.AddWithValue("@pNIF", pClsEntidades.NIF.Substring(0, IIf(Len(pClsEntidades.NIF) > 20, 20, Len(pClsEntidades.NIF))))
        mCMD.Parameters.AddWithValue("@pData_Registo", pClsEntidades.Data_Registo)


        mStrSQL = "UPDATE Entidades SET "
        mStrSQL += "FLG_Entidade=@pFLG_Entidade,"
        mStrSQL += "Num_Cartao=@pNum_Cartao,"
        mStrSQL += "Login=@pLogin,"
        mStrSQL += "Password=@pPassword,"
        mStrSQL += "Nome=@pNome,"
        mStrSQL += "Cod_Imagem=@pCod_Imagem,"
        mStrSQL += "Num_Telefone=@pNum_Telefone,"
        mStrSQL += "Num_Telemovel=@pNum_Telemovel,"
        mStrSQL += "Email=@pEmail,"
        mStrSQL += "NIF=@pNIF,"
        mStrSQL += "Data_Registo=@pData_Registo "
        mStrSQL += "WHERE Cod_Entidade=@pCod_Entidade"


        mDB.ConnectionString = My.Settings.Connection
        mCMD.CommandText = mStrSQL
        mDB.Open()
        mCMD.Connection = mDB

        Try
            mCMD.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("ModificaEntidades:" + vbCrLf + "Erro ao Gravar!!!" + vbCrLf + ex.ToString)
            mReturn = False
        End Try

        mDB.Close()

        Return mReturn

    End Function


    ''' <summary>
    '''      Function GravaEntidades(ByVal pNovoEntidades As ClsEntidades) Método para Gravar a TABELA Entidades
    '''      Gerado em 23/01/2025 15:59:29
    ''' </summary>
    ''' <returns>
    '''      Boolean
    ''' </returns>
    ''' <remarks>
    '''      (c) ETLA - PM-2025
    ''' </remarks>
    Public Shared Function GravaEntidades(ByVal pNovoEntidades As ClsEntidades) As Boolean
        Dim mReturn As Boolean = True

        Dim mStrSQL As String
        Dim mDB As New SqlConnection
        Dim mCMD As New SqlCommand

        mDB.ConnectionString = My.Settings.Connection
        mCMD.Parameters.Clear()


        mCMD.Parameters.AddWithValue("@pCod_Entidade", pNovoEntidades.Cod_Entidade.Substring(0, IIf(Len(pNovoEntidades.Cod_Entidade) > 5, 5, Len(pNovoEntidades.Cod_Entidade))))
        mCMD.Parameters.AddWithValue("@pFLG_Entidade", pNovoEntidades.FLG_Entidade.Substring(0, IIf(Len(pNovoEntidades.FLG_Entidade) > 1, 1, Len(pNovoEntidades.FLG_Entidade))))
        mCMD.Parameters.AddWithValue("@pLogin", pNovoEntidades.Login.Substring(0, IIf(Len(pNovoEntidades.Login) > 25, 25, Len(pNovoEntidades.Login))))
        mCMD.Parameters.AddWithValue("@pNum_Cartao", pNovoEntidades.Num_Cartao.Substring(0, IIf(Len(pNovoEntidades.Num_Cartao) > 25, 25, Len(pNovoEntidades.Num_Cartao))))
        mCMD.Parameters.AddWithValue("@pPassword", pNovoEntidades.Password.Substring(0, IIf(Len(pNovoEntidades.Password) > 25, 25, Len(pNovoEntidades.Password))))
        mCMD.Parameters.AddWithValue("@pNome", pNovoEntidades.Nome.Substring(0, IIf(Len(pNovoEntidades.Nome) > 80, 80, Len(pNovoEntidades.Nome))))
        mCMD.Parameters.AddWithValue("@pCod_Imagem", pNovoEntidades.Cod_Imagem.Substring(0, IIf(Len(pNovoEntidades.Cod_Imagem) > 30, 30, Len(pNovoEntidades.Cod_Imagem))))
        mCMD.Parameters.AddWithValue("@pNum_Telefone", pNovoEntidades.Num_Telefone.Substring(0, IIf(Len(pNovoEntidades.Num_Telefone) > 15, 15, Len(pNovoEntidades.Num_Telefone))))
        mCMD.Parameters.AddWithValue("@pNum_Telemovel", pNovoEntidades.Num_Telemovel.Substring(0, IIf(Len(pNovoEntidades.Num_Telemovel) > 15, 15, Len(pNovoEntidades.Num_Telemovel))))
        mCMD.Parameters.AddWithValue("@pEmail", pNovoEntidades.Email.Substring(0, IIf(Len(pNovoEntidades.Email) > 80, 80, Len(pNovoEntidades.Email))))
        mCMD.Parameters.AddWithValue("@pNIF", pNovoEntidades.NIF.Substring(0, IIf(Len(pNovoEntidades.NIF) > 20, 20, Len(pNovoEntidades.NIF))))
        mCMD.Parameters.AddWithValue("@pData_Registo", pNovoEntidades.Data_Registo)
        mCMD.Parameters.AddWithValue("@pFLG_Ativo", pNovoEntidades.FLG_Ativo)


        mStrSQL = "INSERT INTO Entidades "
        mStrSQL += "("
        mStrSQL += "Cod_Entidade,"
        mStrSQL += "FLG_Entidade,"
        mStrSQL += "Num_Cartao,"
        mStrSQL += "Login,"
        mStrSQL += "Password,"
        mStrSQL += "Nome,"
        mStrSQL += "Cod_Imagem,"
        mStrSQL += "Num_Telefone,"
        mStrSQL += "Num_Telemovel,"
        mStrSQL += "Email,"
        mStrSQL += "NIF,"
        mStrSQL += "Data_Registo,"
        mStrSQL += "FLG_Ativo "
        mStrSQL += ") "
        mStrSQL += "VALUES "
        mStrSQL += "("
        mStrSQL += "@pCod_Entidade,"
        mStrSQL += "@pFLG_Entidade,"
        mStrSQL += "@pNum_Cartao,"
        mStrSQL += "@pLogin,"
        mStrSQL += "@pPassword,"
        mStrSQL += "@pNome,"
        mStrSQL += "@pCod_Imagem,"
        mStrSQL += "@pNum_Telefone,"
        mStrSQL += "@pNum_Telemovel,"
        mStrSQL += "@pEmail,"
        mStrSQL += "@pNIF,"
        mStrSQL += "@pData_Registo,"
        mStrSQL += "1"
        mStrSQL += ")"


        mCMD.CommandText = mStrSQL
        mDB.Open()
        mCMD.Connection = mDB

        Try
            mCMD.ExecuteNonQuery()
            Dim mEnc As New enCont
            Select Case pNovoEntidades.FLG_Entidade
                Case "C"
                    mEnc = enCont.Clientes
                    ClsEmpresas.GravaContador(enCont.Clientes)
                Case "F"
                    mEnc = enCont.Fornecedores
                    ClsEmpresas.GravaContador(enCont.Fornecedores)
                Case "E"
                    mEnc = enCont.Empregados
                    ClsEmpresas.GravaContador(enCont.Empregados)
                Case "M"
                    mEnc = enCont.Motoristas
                    ClsEmpresas.GravaContador(enCont.Motoristas)
            End Select
        Catch ex As Exception
            MsgBox("GravaEntidades:" + vbCrLf + "Erro ao Gravar!!!" + vbCrLf + ex.ToString)
            mReturn = False
        End Try

        mDB.Close()

        Return mReturn

    End Function


    ''' <summary>
    '''      Function ApagaEntidades(ByVal pCod_Entidade As String) Método para Apagar um Registo da Tabela Entidades
    '''      Gerado em 23/01/2025 15:59:29
    ''' </summary>
    ''' <returns>
    '''      Boolean
    ''' </returns>
    ''' <remarks>
    '''      (c) ETLA - PM-2025
    ''' </remarks>
    Public Shared Function ApagaEntidades(ByVal pCod_Entidade As String) As Boolean
        Dim mReturn As Boolean = True

        Dim mStrSQL As String
        Dim mDB As New SqlConnection
        Dim mCMD As New SqlCommand

        mCMD.Parameters.Clear()

        mCMD.Parameters.AddWithValue("@pCod_Entidade", pCod_Entidade)


        mStrSQL = "UPDATE Entidades SET "
        mStrSQL += "FLG_Ativo=0 "
        mStrSQL += "WHERE Cod_Entidade=@pCod_Entidade"


        mDB.ConnectionString = My.Settings.Connection
        mCMD.CommandText = mStrSQL
        mDB.Open()
        mCMD.Connection = mDB

        Try
            mCMD.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("ApagaEntidades:" + vbCrLf + "Erro ao Gravar!!!" + vbCrLf + ex.ToString)
            mReturn = False
        End Try

        mDB.Close()

        Return mReturn

    End Function
End Class



''' <summary>
'''      Classe EntidadesComparer 
'''      Gerado em 23/01/2025 15:59:29
''' </summary>
''' <remarks>
'''      (c) ETLA - PM-2025
''' </remarks>
Public Class EntidadesComparer
    Implements IEqualityComparer(Of ClsEntidades)

    Public Function Equals1(ByVal x As ClsEntidades, ByVal y As ClsEntidades) As Boolean Implements IEqualityComparer(Of ClsEntidades).Equals

        If x Is y Then Return True

        If x Is Nothing OrElse y Is Nothing Then Return False

        Return (x.Cod_Entidade = y.Cod_Entidade) ' AndAlso (x.FLG_Entidade = y.FLG_Entidade)
    End Function

    Public Function GetHashCode1(ByVal pCls As ClsEntidades) As Integer Implements IEqualityComparer(Of ClsEntidades).GetHashCode

        If pCls Is Nothing Then Return 0

        'Dim Hash_ClsEntidades_FLG_Entidade = pCls.FLG_Entidade.GetHashCode()
        Dim Hash_ClsEntidades_Cod_Entidade = pCls.Cod_Entidade.GetHashCode()

        Return Hash_ClsEntidades_Cod_Entidade 'Xor Hash_ClsEntidades_FLG_Entidade
    End Function
End Class
