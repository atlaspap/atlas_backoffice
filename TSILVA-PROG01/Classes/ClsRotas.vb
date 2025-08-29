
Imports System.Data.SqlClient


''' <summary>
'''      Classe ClsRotas Classe da Tabela Rotas
'''      Gerado em 23/01/2025 13:57:14
''' </summary>
''' <remarks>
'''      (c) ETLA - PM-2025
''' </remarks>
Public Class ClsRotas


    ' -----------------------------------------
    ' Property's da tabela Rotas
    ' -----------------------------------------

    Public Property Cod_Rota As String                                      ' Len:  5 - SQL_Type: nvarchar
    Public Property Descritivo As String                                    ' Len: 30 - SQL_Type: nvarchar
    Public Property Num_Paragens As Integer                                 ' SQL_Type: smallint

    Public Property Lista_Paragens As New List(Of ClsRota_Paragens)
    Public Property FLG_Ativo As Boolean                                    ' SQL_Type: bit


    '--------------------------------------------
    ' Exemplo de criador de Código por contador
    ' Para ser usado no caso de o Cdigo ser gerado
    ' e o contador existir na tabela Empresas
    '---------------------------------------------

    Friend Shared Function GetNovoCodigo() As String

        Return "R" & ClsEmpresas.GetContador(enCont.Rota).ToString("000") ' <-------------- VERIFICAR O Nº de ZEROS

    End Function


    ''' <summary>
    '''      Function GetRotas() Método para devolver a Lista de Rotas
    '''      Gerado em 23/01/2025 13:57:14
    ''' </summary>
    ''' <returns>
    '''      mListaRotas
    ''' </returns>
    ''' <remarks>
    '''      (c) ETLA - PM-2025
    ''' </remarks>
    Public Shared Function GetRotas() As List(Of ClsRotas)
        Dim mListaRotas As New List(Of ClsRotas)

        Dim mStrSQL As String
        Dim mDB As New SqlConnection
        Dim mCMD As New SqlCommand
        Dim mRDR As SqlDataReader

        mDB.ConnectionString = My.Settings.Connection
        mCMD.Parameters.Clear()

        mStrSQL = "SELECT "
        mStrSQL += "ISNULL(Cod_Rota,'') As Cod_Rota,"
        mStrSQL += "ISNULL(Descritivo,'') As Descritivo,"
        mStrSQL += "ISNULL(Num_Paragens,0) As Num_Paragens,"
        mStrSQL += "ISNULL(FLG_Ativo,1) As FLG_Ativo "
        mStrSQL += "FROM Rotas "
        mStrSQL += "WHERE FLG_Ativo=1"


        mCMD.CommandText = mStrSQL
        mDB.Open()
        mCMD.Connection = mDB

        mRDR = mCMD.ExecuteReader

        While mRDR.Read()

            Dim mClsRotas As New ClsRotas

            With mClsRotas
                .Cod_Rota = mRDR.GetString(mRDR.GetOrdinal("Cod_Rota"))
                .Descritivo = mRDR.GetString(mRDR.GetOrdinal("Descritivo"))
                .Num_Paragens = mRDR.GetValue(mRDR.GetOrdinal("Num_Paragens"))

                .Lista_Paragens = ClsRota_Paragens.GetRota_Paragens(.Cod_Rota)

                .FLG_Ativo = mRDR.GetBoolean(mRDR.GetOrdinal("FLG_Ativo"))
            End With


            mListaRotas.Add(mClsRotas)

        End While

        mRDR.Close()
        mDB.Close()

        Return mListaRotas
    End Function

    ''' <summary>
    '''      Function FiltrarRotas Método para Filtrar os campos da lista de Rotas
    '''      Gerado em 23/01/2025 13:57:14
    ''' </summary>
    ''' <returns>
    '''      mListaRotas
    ''' </returns>
    ''' <remarks>
    '''      (c) ETLA - PM-2025
    ''' </remarks>
    Public Shared Function FiltrarRotas(ByVal pFiltro As ClsRotas) As List(Of ClsRotas)
        Dim mListaRotas As New List(Of ClsRotas)
        Dim mLista As New List(Of ClsRotas)

        mListaRotas = GetRotas()

        mLista = mListaRotas.FindAll(Function(x) _
        x.Cod_Rota.Contains(pFiltro.Cod_Rota)
        )
        '-----------------------------------------------------
        'Pode Colocar em cima mais colunas como esta abaixo...
        '-----------------------------------------------------
        ' AND x.Descritivo.Contains(pFiltro.Descritivo) 

        Return mLista
    End Function


    ''' <summary>
    '''      Function GetRotasByCod(ByVal pCod_Rota As String) Método para decolver uma Classe de Rotas
    '''      Gerado em 23/01/2025 13:57:14
    ''' </summary>
    ''' <returns>
    '''      mClsRotas
    ''' </returns>
    ''' <remarks>
    '''      (c) ETLA - PM-2025
    ''' </remarks>
    Public Shared Function GetRotasByCod(ByVal pCod_Rota As String) As ClsRotas
        Dim mClsRotas As New ClsRotas

        Dim mStrSQL As String
        Dim mDB As New SqlConnection
        Dim mCMD As New SqlCommand
        Dim mRDR As SqlDataReader

        mDB.ConnectionString = My.Settings.Connection
        mCMD.Parameters.Clear()
        mCMD.Parameters.AddWithValue("@pCod_Rota", pCod_Rota)


        mStrSQL = "SELECT "
        mStrSQL += "ISNULL(Cod_Rota,'') As Cod_Rota,"
        mStrSQL += "ISNULL(Descritivo,'') As Descritivo,"
        mStrSQL += "ISNULL(Num_Paragens,0) As Num_Paragens,"
        mStrSQL += "ISNULL(FLG_Ativo,1) As FLG_Ativo "
        mStrSQL += "FROM Rotas "
        mStrSQL += "WHERE FLG_Ativo=1 "
        mStrSQL += "AND Cod_Rota=@pCod_Rota"


        mCMD.CommandText = mStrSQL
        mDB.Open()
        mCMD.Connection = mDB

        mRDR = mCMD.ExecuteReader

        If mRDR.Read() Then


            With mClsRotas
                .Cod_Rota = mRDR.GetString(mRDR.GetOrdinal("Cod_Rota"))
                .Descritivo = mRDR.GetString(mRDR.GetOrdinal("Descritivo"))
                .Num_Paragens = mRDR.GetValue(mRDR.GetOrdinal("Num_Paragens"))
                .FLG_Ativo = mRDR.GetBoolean(mRDR.GetOrdinal("FLG_Ativo"))
            End With


        End If
        mRDR.Close()
        mDB.Close()

        Return mClsRotas
    End Function


    ''' <summary>
    '''      Function ModificaRotas(ByVal pClsRotas As ClsRotas) Método para Modificar a TABELA Rotas
    '''      Gerado em 23/01/2025 13:57:14
    ''' </summary>
    ''' <returns>
    '''      Boolean
    ''' </returns>
    ''' <remarks>
    '''      (c) ETLA - PM-2025
    ''' </remarks>
    Public Shared Function ModificaRotas(ByVal pClsRotas As ClsRotas) As Boolean
        Dim mReturn As Boolean = True

        Dim mStrSQL As String
        Dim mDB As New SqlConnection
        Dim mCMD As New SqlCommand

        mCMD.Parameters.Clear()
        mCMD.Parameters.AddWithValue("@pCod_Rota", pClsRotas.Cod_Rota.Substring(0, IIf(Len(pClsRotas.Cod_Rota) > 5, 5, Len(pClsRotas.Cod_Rota))))
        mCMD.Parameters.AddWithValue("@pDescritivo", pClsRotas.Descritivo.Substring(0, IIf(Len(pClsRotas.Descritivo) > 80, 80, Len(pClsRotas.Descritivo))))
        mCMD.Parameters.AddWithValue("@pNum_Paragens", pClsRotas.Num_Paragens)


        mStrSQL = "UPDATE Rotas SET "
        mStrSQL += "Descritivo=@pDescritivo,"
        mStrSQL += "Num_Paragens=@pNum_Paragens "
        mStrSQL += "WHERE Cod_Rota=@pCod_Rota"


        mDB.ConnectionString = My.Settings.Connection
        mCMD.CommandText = mStrSQL
        mDB.Open()
        mCMD.Connection = mDB

        Try
            mCMD.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("ModificaRotas:" + vbCrLf + "Erro ao Gravar!!!" + vbCrLf + ex.ToString)
            mReturn = False
        End Try

        mDB.Close()

        Return mReturn

    End Function




    ''' <summary>
    '''      Function GravaRotas(ByVal pNovoRotas As ClsRotas) Método para Gravar a TABELA Rotas
    '''      Gerado em 23/01/2025 13:57:14
    ''' </summary>
    ''' <returns>
    '''      Boolean
    ''' </returns>
    ''' <remarks>
    '''      (c) ETLA - PM-2025
    ''' </remarks>
    Public Shared Function GravaRotas(ByVal pNovoRotas As ClsRotas) As Boolean
        Dim mReturn As Boolean = True

        Dim mStrSQL As String
        Dim mDB As New SqlConnection
        Dim mCMD As New SqlCommand

        mDB.ConnectionString = My.Settings.Connection
        mCMD.Parameters.Clear()


        mCMD.Parameters.AddWithValue("@pCod_Rota", pNovoRotas.Cod_Rota.Substring(0, IIf(Len(pNovoRotas.Cod_Rota) > 5, 5, Len(pNovoRotas.Cod_Rota))))
        mCMD.Parameters.AddWithValue("@pDescritivo", pNovoRotas.Descritivo.Substring(0, IIf(Len(pNovoRotas.Descritivo) > 80, 80, Len(pNovoRotas.Descritivo))))
        mCMD.Parameters.AddWithValue("@pNum_Paragens", pNovoRotas.Num_Paragens)
        mCMD.Parameters.AddWithValue("@pFLG_Ativo", pNovoRotas.FLG_Ativo)


        mStrSQL = "INSERT INTO Rotas "
        mStrSQL += "("
        mStrSQL += "Cod_Rota,"
        mStrSQL += "Descritivo,"
        mStrSQL += "Num_Paragens,"
        mStrSQL += "FLG_Ativo "
        mStrSQL += ") "
        mStrSQL += "VALUES "
        mStrSQL += "("
        mStrSQL += "@pCod_Rota,"
        mStrSQL += "@pDescritivo,"
        mStrSQL += "@pNum_Paragens,"
        mStrSQL += "1"
        mStrSQL += ")"


        mCMD.CommandText = mStrSQL
        mDB.Open()
        mCMD.Connection = mDB

        Try
            mCMD.ExecuteNonQuery()
            ClsEmpresas.GravaContador(enCont.Rota) '<<<<-------- Verificar se é  preciso...
        Catch ex As Exception
            MsgBox("GravaRotas:" + vbCrLf + "Erro ao Gravar!!!" + vbCrLf + ex.ToString)
            mReturn = False
        End Try

        mDB.Close()

        Return mReturn

    End Function
    Public Shared Function Apaga_Paragens(ByVal pCod_Rota As String) As Boolean
        Dim mReturn As Boolean = True

        Dim mStrSQL As String
        Dim mDB As New SqlConnection
        Dim mCMD As New SqlCommand

        mCMD.Parameters.Clear()
        mCMD.Parameters.AddWithValue("@pCod_Rota", pCod_Rota)


        mStrSQL = "DELETE FROM Rota_Paragens "
        mStrSQL += "WHERE Cod_Rota=@pCod_Rota"


        mDB.ConnectionString = My.Settings.Connection
        mCMD.CommandText = mStrSQL
        mDB.Open()
        mCMD.Connection = mDB

        Try
            mCMD.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("ApagarRotas:" + vbCrLf + "Erro ao Gravar!!!" + vbCrLf + ex.ToString)
            mReturn = False
        End Try

        mDB.Close()

        Return mReturn

    End Function

    ''' <summary>
    '''      Function ApagaRotas(ByVal pCod_Rota As String) Método para Apagar um Registo da Tabela Rotas
    '''      Gerado em 23/01/2025 13:57:14
    ''' </summary>
    ''' <returns>
    '''      Boolean
    ''' </returns>
    ''' <remarks>
    '''      (c) ETLA - PM-2025
    ''' </remarks>
    Public Shared Function ApagaRotas(ByVal pCod_Rota As String) As Boolean
        Dim mReturn As Boolean = True

        Dim mStrSQL As String
        Dim mDB As New SqlConnection
        Dim mCMD As New SqlCommand

        mCMD.Parameters.Clear()

        mCMD.Parameters.AddWithValue("@pCod_Rota", pCod_Rota)


        mStrSQL = "UPDATE Rotas SET "
        mStrSQL += "FLG_Ativo=0 "
        mStrSQL += "WHERE Cod_Rota=@pCod_Rota"


        mDB.ConnectionString = My.Settings.Connection
        mCMD.CommandText = mStrSQL
        mDB.Open()
        mCMD.Connection = mDB

        Try
            mCMD.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("ApagaRotas:" + vbCrLf + "Erro ao Gravar!!!" + vbCrLf + ex.ToString)
            mReturn = False
        End Try

        mDB.Close()

        Return mReturn

    End Function
End Class



''' <summary>
'''      Classe RotasComparer 
'''      Gerado em 23/01/2025 13:57:14
''' </summary>
''' <remarks>
'''      (c) ETLA - PM-2025
''' </remarks>
Public Class RotasComparer
    Implements IEqualityComparer(Of ClsRotas)

    Public Function Equals1(ByVal x As ClsRotas, ByVal y As ClsRotas) As Boolean Implements IEqualityComparer(Of ClsRotas).Equals

        If x Is y Then Return True

        If x Is Nothing OrElse y Is Nothing Then Return False

        Return (x.Cod_Rota = y.Cod_Rota) ' AndAlso (x.Descritivo = y.Descritivo)
    End Function

    Public Function GetHashCode1(ByVal pCls As ClsRotas) As Integer Implements IEqualityComparer(Of ClsRotas).GetHashCode

        If pCls Is Nothing Then Return 0

        'Dim Hash_ClsRotas_Descritivo = pCls.Descritivo.GetHashCode()
        Dim Hash_ClsRotas_Cod_Rota = pCls.Cod_Rota.GetHashCode()

        Return Hash_ClsRotas_Cod_Rota 'Xor Hash_ClsRotas_Descritivo
    End Function
End Class
