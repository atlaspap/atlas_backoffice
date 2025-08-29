
Imports System.Data.SqlClient
Imports DevExpress.DataAccess.ObjectBinding
Imports DevExpress.XtraRichEdit.Import.OpenXml


''' <summary>
'''      Classe ClsParagens Classe da Tabela Paragens
'''      Gerado em 30/01/2025 13:40:46
''' </summary>
''' <remarks>
'''      (c) ETLA - PM-2025
''' </remarks>
Public Class ClsParagens


    ' -----------------------------------------
    ' Property's da tabela Paragens
    ' -----------------------------------------

    Public Property Cod_Paragem As String                                   ' Len:  5 - SQL_Type: nvarchar
    Public Property Descritivo As String                                    ' Len: 60 - SQL_Type: nvarchar
    Public Property Cod_Distrito As String                                  ' Len:  2 - SQL_Type: nvarchar
    Public Property Cod_Concelho As String                                  ' Len:  2 - SQL_Type: nvarchar
    Public Property Cod_Postal As String                                    ' Len:  8 - SQL_Type: nvarchar
    Public Property Endereco As String                                      ' Len:100 - SQL_Type: nvarchar
    Public Property Localidade As String                                    ' Len: 50 - SQL_Type: nvarchar

    Public Property Loc01 As Decimal                                        ' SQL_Type: decimal
    Public Property Loc02 As Decimal                                        ' SQL_Type: decimal

    Public Property FLG_Ativo As Boolean                                    ' SQL_Type: bit

    Public ReadOnly Property Localizacao As String
        Get
            Dim m1 As String
            Dim m2 As String
            m1 = Replace(Loc01, ",", ".")
            m2 = Replace(Loc02, ",", ".")
            Return m1 & ", " & m2
        End Get
    End Property

    Public Property Selecionado As Boolean
    Sub New()
    End Sub


    '--------------------------------------------
    ' Exemplo de criador de Código por contador
    ' Para ser usado no caso de o Cdigo ser gerado
    ' e o contador existir na tabela Empresas
    '---------------------------------------------

    Friend Shared Function GetNovoCodigo() As String

        Return "P" & ClsEmpresas.GetContador(enCont.Paragem).ToString("000") ' <-------------- VERIFICAR O Nº de ZEROS

    End Function


    ''' <summary>
    '''      Function GetParagens() Método para devolver a Lista de Paragens
    '''      Gerado em 30/01/2025 13:40:46
    ''' </summary>
    ''' <returns>
    '''      mListaParagens
    ''' </returns>
    ''' <remarks>
    '''      (c) ETLA - PM-2025
    ''' </remarks>
    Public Shared Function GetParagens() As List(Of ClsParagens)
        Dim mListaParagens As New List(Of ClsParagens)

        Dim mStrSQL As String
        Dim mDB As New SqlConnection
        Dim mCMD As New SqlCommand
        Dim mRDR As SqlDataReader

        mDB.ConnectionString = My.Settings.Connection
        mCMD.Parameters.Clear()



        mStrSQL = "SELECT "
        mStrSQL += "ISNULL(Cod_Paragem,'') As Cod_Paragem,"
        mStrSQL += "ISNULL(Descritivo,'') As Descritivo,"
        mStrSQL += "ISNULL(Cod_Distrito,'') As Cod_Distrito,"
        mStrSQL += "ISNULL(Cod_Concelho,'') As Cod_Concelho,"
        mStrSQL += "ISNULL(Cod_Postal,'') As Cod_Postal,"
        mStrSQL += "ISNULL(Endereco,'') As Endereco,"
        mStrSQL += "ISNULL(Localidade,'') As Localidade,"
        mStrSQL += "ISNULL(Loc01,0) As Loc01,"
        mStrSQL += "ISNULL(Loc02,0) As Loc02,"
        mStrSQL += "ISNULL(FLG_Ativo,1) As FLG_Ativo "
        mStrSQL += "FROM Paragens "
        mStrSQL += "WHERE FLG_Ativo=1"


        mCMD.CommandText = mStrSQL
        mDB.Open()
        mCMD.Connection = mDB

        mRDR = mCMD.ExecuteReader

        While mRDR.Read()

            Dim mClsParagens As New ClsParagens

            With mClsParagens
                .Cod_Paragem = mRDR.GetString(mRDR.GetOrdinal("Cod_Paragem"))
                .Descritivo = mRDR.GetString(mRDR.GetOrdinal("Descritivo"))
                .Cod_Distrito = mRDR.GetString(mRDR.GetOrdinal("Cod_Distrito"))
                .Cod_Concelho = mRDR.GetString(mRDR.GetOrdinal("Cod_Concelho"))
                .Cod_Postal = mRDR.GetString(mRDR.GetOrdinal("Cod_Postal"))
                .Endereco = mRDR.GetString(mRDR.GetOrdinal("Endereco"))
                .Localidade = mRDR.GetString(mRDR.GetOrdinal("Localidade"))
                .Loc01 = mRDR.GetDecimal(mRDR.GetOrdinal("Loc01"))
                .Loc02 = mRDR.GetDecimal(mRDR.GetOrdinal("Loc02"))
                .FLG_Ativo = mRDR.GetBoolean(mRDR.GetOrdinal("FLG_Ativo"))
            End With


            mListaParagens.Add(mClsParagens)

        End While

        mRDR.Close()
        mDB.Close()

        Return mListaParagens
    End Function

    ''' <summary>
    '''      Function FiltrarParagens Método para Filtrar os campos da lista de Paragens
    '''      Gerado em 30/01/2025 13:40:46
    ''' </summary>
    ''' <returns>
    '''      mListaParagens
    ''' </returns>
    ''' <remarks>
    '''      (c) ETLA - PM-2025
    ''' </remarks>
    Public Shared Function FiltrarParagens(ByVal pFiltro As ClsParagens) As List(Of ClsParagens)
        Dim mListaParagens As New List(Of ClsParagens)
        Dim mLista As New List(Of ClsParagens)

        mListaParagens = GetParagens()

        mLista = mListaParagens.FindAll(Function(x) _
        x.Cod_Paragem.Contains(pFiltro.Cod_Paragem)
        )
        '-----------------------------------------------------
        'Pode Colocar em cima mais colunas como esta abaixo...
        '-----------------------------------------------------
        ' AND x.Descritivo.Contains(pFiltro.Descritivo) 

        Return mLista
    End Function


    ''' <summary>
    '''      Function GetParagensByCod(ByVal pCod_Paragem As String) Método para decolver uma Classe de Paragens
    '''      Gerado em 30/01/2025 13:40:46
    ''' </summary>
    ''' <returns>
    '''      mClsParagens
    ''' </returns>
    ''' <remarks>
    '''      (c) ETLA - PM-2025
    ''' </remarks>
    Public Shared Function GetParagensByCod(ByVal pCod_Paragem As String) As ClsParagens
        Dim mClsParagens As New ClsParagens

        Dim mStrSQL As String
        Dim mDB As New SqlConnection
        Dim mCMD As New SqlCommand
        Dim mRDR As SqlDataReader

        mDB.ConnectionString = My.Settings.Connection
        mCMD.Parameters.Clear()
        mCMD.Parameters.AddWithValue("@pCod_Paragem", pCod_Paragem)

        mStrSQL = "SELECT "
        mStrSQL += "ISNULL(Cod_Paragem,'') As Cod_Paragem,"
        mStrSQL += "ISNULL(Descritivo,'') As Descritivo,"
        mStrSQL += "ISNULL(Cod_Distrito,'') As Cod_Distrito,"
        mStrSQL += "ISNULL(Cod_Concelho,'') As Cod_Concelho,"
        mStrSQL += "ISNULL(Cod_Postal,'') As Cod_Postal,"
        mStrSQL += "ISNULL(Endereco,'') As Endereco,"
        mStrSQL += "ISNULL(Localidade,'') As Localidade,"
        mStrSQL += "ISNULL(Loc01,0) As Loc01,"
        mStrSQL += "ISNULL(Loc02,0) As Loc02,"
        mStrSQL += "ISNULL(FLG_Ativo,1) As FLG_Ativo "
        mStrSQL += "FROM Paragens "
        mStrSQL += "WHERE FLG_Ativo=1 "
        mStrSQL += "AND Cod_Paragem = @pCod_Paragem"



        mCMD.CommandText = mStrSQL
        mDB.Open()
        mCMD.Connection = mDB

        mRDR = mCMD.ExecuteReader

        If mRDR.Read() Then


            With mClsParagens
                .Cod_Paragem = mRDR.GetString(mRDR.GetOrdinal("Cod_Paragem"))
                .Descritivo = mRDR.GetString(mRDR.GetOrdinal("Descritivo"))
                .Cod_Distrito = mRDR.GetString(mRDR.GetOrdinal("Cod_Distrito"))
                .Cod_Concelho = mRDR.GetString(mRDR.GetOrdinal("Cod_Concelho"))
                .Cod_Postal = mRDR.GetString(mRDR.GetOrdinal("Cod_Postal"))
                .Endereco = mRDR.GetString(mRDR.GetOrdinal("Endereco"))
                .Localidade = mRDR.GetString(mRDR.GetOrdinal("Localidade"))
                .Loc01 = mRDR.GetDecimal(mRDR.GetOrdinal("Loc01"))
                .Loc02 = mRDR.GetDecimal(mRDR.GetOrdinal("Loc02"))
                .FLG_Ativo = mRDR.GetBoolean(mRDR.GetOrdinal("FLG_Ativo"))

            End With


        End If
        mRDR.Close()
        mDB.Close()

        Return mClsParagens
    End Function


    ''' <summary>
    '''      Function ModificaParagens(ByVal pClsParagens As ClsParagens) Método para Modificar a TABELA Paragens
    '''      Gerado em 30/01/2025 13:40:46
    ''' </summary>
    ''' <returns>
    '''      Boolean
    ''' </returns>
    ''' <remarks>
    '''      (c) ETLA - PM-2025
    ''' </remarks>
    Public Shared Function ModificaParagens(ByVal pClsParagens As ClsParagens) As Boolean
        Dim mReturn As Boolean = True

        Dim mStrSQL As String
        Dim mDB As New SqlConnection
        Dim mCMD As New SqlCommand

        mCMD.Parameters.Clear()
        mCMD.Parameters.AddWithValue("@pCod_Paragem", pClsParagens.Cod_Paragem.Substring(0, IIf(Len(pClsParagens.Cod_Paragem) > 5, 5, Len(pClsParagens.Cod_Paragem))))
        mCMD.Parameters.AddWithValue("@pDescritivo", pClsParagens.Descritivo.Substring(0, IIf(Len(pClsParagens.Descritivo) > 60, 60, Len(pClsParagens.Descritivo))))
        mCMD.Parameters.AddWithValue("@pCod_Distrito", pClsParagens.Cod_Distrito.Substring(0, IIf(Len(pClsParagens.Cod_Distrito) > 2, 2, Len(pClsParagens.Cod_Distrito))))
        mCMD.Parameters.AddWithValue("@pCod_Concelho", pClsParagens.Cod_Concelho.Substring(0, IIf(Len(pClsParagens.Cod_Concelho) > 2, 2, Len(pClsParagens.Cod_Concelho))))
        mCMD.Parameters.AddWithValue("@pCod_Postal", pClsParagens.Cod_Postal.Substring(0, IIf(Len(pClsParagens.Cod_Postal) > 8, 8, Len(pClsParagens.Cod_Postal))))
        mCMD.Parameters.AddWithValue("@pEndereco", pClsParagens.Endereco.Substring(0, IIf(Len(pClsParagens.Endereco) > 100, 100, Len(pClsParagens.Endereco))))
        mCMD.Parameters.AddWithValue("@pLocalidade", pClsParagens.Localidade.Substring(0, IIf(Len(pClsParagens.Localidade) > 50, 50, Len(pClsParagens.Localidade))))
        mCMD.Parameters.AddWithValue("@pLoc01", pClsParagens.Loc01)
        mCMD.Parameters.AddWithValue("@pLoc02", pClsParagens.Loc02)


        mStrSQL = "UPDATE Paragens SET "
        mStrSQL += "Descritivo=@pDescritivo,"
        mStrSQL += "Cod_Distrito=@pCod_Distrito,"
        mStrSQL += "Cod_Concelho=@pCod_Concelho,"
        mStrSQL += "Cod_Postal=@pCod_Postal,"
        mStrSQL += "Endereco=@pEndereco,"
        mStrSQL += "Localidade=@pLocalidade,"
        mStrSQL += "Loc01=@pLoc01,"
        mStrSQL += "Loc02=@pLoc02 "
        mStrSQL += "WHERE Cod_Paragem=@pCod_Paragem"


        mDB.ConnectionString = My.Settings.Connection
        mCMD.CommandText = mStrSQL
        mDB.Open()
        mCMD.Connection = mDB

        Try
            mCMD.ExecuteNonQuery()
        Catch ex As Exception
            Msgbox("ModificaParagens:" + vbCrLf + "Erro ao Gravar!!!" + vbCrLf + ex.ToString)
            mReturn = False
        End Try

        mDB.Close()

        Return mReturn

    End Function


    ''' <summary>
    '''      Function GravaParagens(ByVal pNovoParagens As ClsParagens) Método para Gravar a TABELA Paragens
    '''      Gerado em 30/01/2025 13:40:46
    ''' </summary>
    ''' <returns>
    '''      Boolean
    ''' </returns>
    ''' <remarks>
    '''      (c) ETLA - PM-2025
    ''' </remarks>
    Public Shared Function GravaParagens(ByVal pNovoParagens As ClsParagens) As Boolean
        Dim mReturn As Boolean = True

        Dim mStrSQL As String
        Dim mDB As New SqlConnection
        Dim mCMD As New SqlCommand

        mDB.ConnectionString = My.Settings.Connection
        mCMD.Parameters.Clear()


        mCMD.Parameters.AddWithValue("@pCod_Paragem", pNovoParagens.Cod_Paragem.Substring(0, IIf(Len(pNovoParagens.Cod_Paragem) > 5, 5, Len(pNovoParagens.Cod_Paragem))))
        mCMD.Parameters.AddWithValue("@pDescritivo", pNovoParagens.Descritivo.Substring(0, IIf(Len(pNovoParagens.Descritivo) > 60, 60, Len(pNovoParagens.Descritivo))))
        mCMD.Parameters.AddWithValue("@pCod_Distrito", pNovoParagens.Cod_Distrito.Substring(0, IIf(Len(pNovoParagens.Cod_Distrito) > 2, 2, Len(pNovoParagens.Cod_Distrito))))
        mCMD.Parameters.AddWithValue("@pCod_Concelho", pNovoParagens.Cod_Concelho.Substring(0, IIf(Len(pNovoParagens.Cod_Concelho) > 2, 2, Len(pNovoParagens.Cod_Concelho))))
        mCMD.Parameters.AddWithValue("@pCod_Postal", pNovoParagens.Cod_Postal.Substring(0, IIf(Len(pNovoParagens.Cod_Postal) > 8, 8, Len(pNovoParagens.Cod_Postal))))
        mCMD.Parameters.AddWithValue("@pEndereco", pNovoParagens.Endereco.Substring(0, IIf(Len(pNovoParagens.Endereco) > 100, 100, Len(pNovoParagens.Endereco))))
        mCMD.Parameters.AddWithValue("@pLocalidade", pNovoParagens.Localidade.Substring(0, IIf(Len(pNovoParagens.Localidade) > 50, 50, Len(pNovoParagens.Localidade))))
        mCMD.Parameters.AddWithValue("@pLoc01", pNovoParagens.Loc01)
        mCMD.Parameters.AddWithValue("@pLoc02", pNovoParagens.Loc02)
        mCMD.Parameters.AddWithValue("@pFLG_Ativo", pNovoParagens.FLG_Ativo)


        mStrSQL = "INSERT INTO Paragens "
        mStrSQL += "("
        mStrSQL += "Cod_Paragem,"
        mStrSQL += "Descritivo,"
        mStrSQL += "Cod_Distrito,"
        mStrSQL += "Cod_Concelho,"
        mStrSQL += "Cod_Postal,"
        mStrSQL += "Endereco,"
        mStrSQL += "Localidade,"
        mStrSQL += "Loc01,"
        mStrSQL += "Loc02,"
        mStrSQL += "FLG_Ativo "
        mStrSQL += ") "
        mStrSQL += "VALUES "
        mStrSQL += "("
        mStrSQL += "@pCod_Paragem,"
        mStrSQL += "@pDescritivo,"
        mStrSQL += "@pCod_Distrito,"
        mStrSQL += "@pCod_Concelho,"
        mStrSQL += "@pCod_Postal,"
        mStrSQL += "@pEndereco,"
        mStrSQL += "@pLocalidade,"
        mStrSQL += "@pLoc01,"
        mStrSQL += "@pLoc02,"
        mStrSQL += "1"
        mStrSQL += ")"


        mCMD.CommandText = mStrSQL
        mDB.Open()
        mCMD.Connection = mDB

        Try
            mCMD.ExecuteNonQuery()
            ClsEmpresas.GravaContador(enCont.Paragem) '<<<<-------- Verificar se é  preciso...
        Catch ex As Exception
            Msgbox("GravaParagens:" + vbCrLf + "Erro ao Gravar!!!" + vbCrLf + ex.ToString)
            mReturn = False
        End Try

        mDB.Close()

        Return mReturn

    End Function


    ''' <summary>
    '''      Function ApagaParagens(ByVal pCod_Paragem As String) Método para Apagar um Registo da Tabela Paragens
    '''      Gerado em 30/01/2025 13:40:46
    ''' </summary>
    ''' <returns>
    '''      Boolean
    ''' </returns>
    ''' <remarks>
    '''      (c) ETLA - PM-2025
    ''' </remarks>
    Public Shared Function ApagaParagens(ByVal pCod_Paragem As String) As Boolean
        Dim mReturn As Boolean = True

        Dim mStrSQL As String
        Dim mDB As New SqlConnection
        Dim mCMD As New SqlCommand

        mCMD.Parameters.Clear()

        mCMD.Parameters.AddWithValue("@pCod_Paragem", pCod_Paragem)


        mStrSQL = "UPDATE Paragens SET "
        mStrSQL += "FLG_Ativo=0 "
        mStrSQL += "WHERE Cod_Paragem=@pCod_Paragem"


        mDB.ConnectionString = My.Settings.Connection
        mCMD.CommandText = mStrSQL
        mDB.Open()
        mCMD.Connection = mDB

        Try
            mCMD.ExecuteNonQuery()
        Catch ex As Exception
            Msgbox("ApagaParagens:" + vbCrLf + "Erro ao Gravar!!!" + vbCrLf + ex.ToString)
            mReturn = False
        End Try

        mDB.Close()

        Return mReturn

    End Function
End Class



''' <summary>
'''      Classe ParagensComparer 
'''      Gerado em 30/01/2025 13:40:46
''' </summary>
''' <remarks>
'''      (c) ETLA - PM-2025
''' </remarks>
Public Class ParagensComparer
    Implements IEqualityComparer(Of ClsParagens)

    Public Function Equals1(ByVal x As ClsParagens, ByVal y As ClsParagens) As Boolean Implements IEqualityComparer(Of ClsParagens).Equals

        If x Is y Then Return True

        If x Is Nothing OrElse y Is Nothing Then Return False

        Return (x.Cod_Paragem = y.Cod_Paragem) ' AndAlso (x.Descritivo = y.Descritivo)
    End Function

    Public Function GetHashCode1(ByVal pCls As ClsParagens) As Integer Implements IEqualityComparer(Of ClsParagens).GetHashCode

        If pCls Is Nothing Then Return 0

        'Dim Hash_ClsParagens_Descritivo = pCls.Descritivo.GetHashCode()
        Dim Hash_ClsParagens_Cod_Paragem = pCls.Cod_Paragem.GetHashCode()

        Return Hash_ClsParagens_Cod_Paragem 'Xor Hash_ClsParagens_Descritivo
    End Function
End Class
