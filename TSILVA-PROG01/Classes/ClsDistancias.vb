
Imports System.Data.SqlClient
Imports Infragistics.Win
Imports Infragistics.Win.UltraWinGrid


''' <summary>
'''      Classe ClsDistancias Classe da Tabela Distancias
'''      Gerado em 17/02/2025 13:35:10
''' </summary>
''' <remarks>
'''      (c) ETLA - PM-2025
''' </remarks>
Public Class ClsDistancias


    ' -----------------------------------------
    ' Property's da tabela Distancias
    ' -----------------------------------------
    Public Property Cod_Distancia As String
    Public Property Cod_Paragem1 As String                                  ' Len:  5 - SQL_Type: nvarchar
    Public ReadOnly Property Paragem1 As String                                      ' Len: 60 - SQL_Type: nvarchar
        Get
            Return ClsParagens.GetParagensByCod(Cod_Paragem1).Descritivo
        End Get
    End Property
    Public ReadOnly Property Coord01 As String
        Get
            Return CStr(ClsParagens.GetParagensByCod(Cod_Paragem1).Localizacao)
        End Get
    End Property
    Public Property Cod_Paragem2 As String                                  ' Len:  5 - SQL_Type: nvarchar
    Public ReadOnly Property Paragem2 As String                                      ' Len: 60 - SQL_Type: nvarchar
        Get
            Return ClsParagens.GetParagensByCod(Cod_Paragem2).Descritivo
        End Get
    End Property
    Public ReadOnly Property Coord02 As String
        Get
            Return CStr(ClsParagens.GetParagensByCod(Cod_Paragem2).Localizacao)
        End Get
    End Property

    Public ReadOnly Property strGoogle As String
        Get
            Dim g1 As String = "https://www.google.com/maps/dir/"
            Return g1 + Coord01 + "/" + Coord02
        End Get
    End Property
    Public Property Distancia As Integer                                    ' SQL_Type: smallint
    Public Property Tempo_Min As Integer                                    ' SQL_Type: smallint

    Public Property FLG_Ativo As Boolean                                    ' SQL_Type: bit


    Sub New()
    End Sub


    '--------------------------------------------
    ' Exemplo de criador de Código por contador
    ' Para ser usado no caso de o Cdigo ser gerado
    ' e o contador existir na tabela Empresas
    '---------------------------------------------

    Friend Shared Function GetNovoCodigo() As String

        Return "D" & ClsEmpresas.GetContador(enCont.Distancias).ToString("000") ' <-------------- VERIFICAR O Nº de ZEROS

    End Function


    ''' <summary>
    '''      Function GetDistancias() Método para devolver a Lista de Distancias
    '''      Gerado em 17/02/2025 13:35:10
    ''' </summary>
    ''' <returns>
    '''      mListaDistancias
    ''' </returns>
    ''' <remarks>
    '''      (c) ETLA - PM-2025
    ''' </remarks>
    Public Shared Function GetDistancias() As List(Of ClsDistancias)
        Dim mListaDistancias As New List(Of ClsDistancias)

        Dim mStrSQL As String
        Dim mDB As New SqlConnection
        Dim mCMD As New SqlCommand
        Dim mRDR As SqlDataReader
        mDB.ConnectionString = My.Settings.Connection
        mCMD.Parameters.Clear()

        mStrSQL = "SELECT "
        mStrSQL += "ISNULL(Cod_Distancia,'') As Cod_Distancia,"
        mStrSQL += "ISNULL(Cod_Paragem1,'') As Cod_Paragem1,"
        mStrSQL += "ISNULL(Cod_Paragem2,'') As Cod_Paragem2,"
        mStrSQL += "ISNULL(Distancia,0) As Distancia,"
        mStrSQL += "ISNULL(Tempo_Min,0) As Tempo_Min,"
        mStrSQL += "ISNULL(FLG_Ativo,1) As FLG_Ativo "
        mStrSQL += "FROM Distancias "
        mStrSQL += "WHERE FLG_Ativo=1"


        mCMD.CommandText = mStrSQL
        mDB.Open()
        mCMD.Connection = mDB
        mRDR = mCMD.ExecuteReader
        While mRDR.Read()
            Dim mClsDistancias As New ClsDistancias

            With mClsDistancias
                .Cod_Distancia = mRDR.GetString(mRDR.GetOrdinal("Cod_Distancia"))
                .Cod_Paragem1 = mRDR.GetString(mRDR.GetOrdinal("Cod_Paragem1"))
                .Cod_Paragem2 = mRDR.GetString(mRDR.GetOrdinal("Cod_Paragem2"))
                .Distancia = mRDR.GetValue(mRDR.GetOrdinal("Distancia"))
                .Tempo_Min = mRDR.GetValue(mRDR.GetOrdinal("Tempo_Min"))
                .FLG_Ativo = mRDR.GetBoolean(mRDR.GetOrdinal("FLG_Ativo"))
            End With
            mListaDistancias.Add(mClsDistancias)
        End While
        mRDR.Close()
        mDB.Close()
        Return mListaDistancias
    End Function

    ''' <summary>
    '''      Function FiltrarDistancias Método para Filtrar os campos da lista de Distancias
    '''      Gerado em 17/02/2025 13:35:10
    ''' </summary>
    ''' <returns>
    '''      mListaDistancias
    ''' </returns>
    ''' <remarks>
    '''      (c) ETLA - PM-2025
    ''' </remarks>
    Public Shared Function FiltrarDistancias(ByVal pFiltro As ClsDistancias) As List(Of ClsDistancias)
        Dim mListaDistancias As New List(Of ClsDistancias)
        Dim mLista As New List(Of ClsDistancias)
        mListaDistancias = GetDistancias()
        mLista = mListaDistancias.FindAll(Function(x) _
x.Cod_Paragem1.Contains(pFiltro.Cod_Paragem1)
)
        '-----------------------------------------------------
        'Pode Colocar em cima mais colunas como esta abaixo...
        '-----------------------------------------------------
        ' AND x.Paragem1.Contains(pFiltro.Paragem1) 

        Return mLista
    End Function


    ''' <summary>
    '''      Function GetDistanciasByCod(ByVal pCod_Paragem1 As String) Método para decolver uma Classe de Distancias
    '''      Gerado em 17/02/2025 13:35:10
    ''' </summary>
    ''' <returns>
    '''      mClsDistancias
    ''' </returns>
    ''' <remarks>
    '''      (c) ETLA - PM-2025
    ''' </remarks>
    Public Shared Function GetDistanciasByCod(ByVal pCod_Paragem1 As String, ByVal pCod_Paragem2 As String) As ClsDistancias
        Dim mClsDistancias As New ClsDistancias

        Dim mStrSQL As String
        Dim mDB As New SqlConnection
        Dim mCMD As New SqlCommand
        Dim mRDR As SqlDataReader

        mDB.ConnectionString = My.Settings.Connection
        mCMD.Parameters.Clear()
        mCMD.Parameters.AddWithValue("@pCod_Paragem1", pCod_Paragem1)
        mCMD.Parameters.AddWithValue("@pCod_Paragem2", pCod_Paragem2)



        mStrSQL = "SELECT "
        mStrSQL += "ISNULL(Cod_Paragem1,'') As Cod_Paragem1,"
        mStrSQL += "ISNULL(Cod_Paragem2,'') As Cod_Paragem2,"
        mStrSQL += "ISNULL(Distancia,0) As Distancia,"
        mStrSQL += "ISNULL(Tempo_Min,0) As Tempo_Min,"
        mStrSQL += "ISNULL(FLG_Ativo,1) As FLG_Ativo "
        mStrSQL += "FROM Distancias "
        mStrSQL += "WHERE FLG_Ativo=1 "
        mStrSQL += "AND Cod_Paragem1=@pCod_Paragem1 "
        mStrSQL += "AND Cod_Paragem2=@pCod_Paragem2"



        mCMD.CommandText = mStrSQL
        mDB.Open()
        mCMD.Connection = mDB

        mRDR = mCMD.ExecuteReader

        If mRDR.Read() Then


            With mClsDistancias
                .Cod_Paragem1 = mRDR.GetString(mRDR.GetOrdinal("Cod_Paragem1"))
                .Cod_Paragem2 = mRDR.GetString(mRDR.GetOrdinal("Cod_Paragem2"))
                .Distancia = mRDR.GetValue(mRDR.GetOrdinal("Distancia"))
                .Tempo_Min = mRDR.GetValue(mRDR.GetOrdinal("Tempo_Min"))
                .FLG_Ativo = mRDR.GetBoolean(mRDR.GetOrdinal("FLG_Ativo"))
            End With


        End If
        mRDR.Close()
        mDB.Close()

        Return mClsDistancias
    End Function


    ''' <summary>
    '''      Function ModificaDistancias(ByVal pClsDistancias As ClsDistancias) Método para Modificar a TABELA Distancias
    '''      Gerado em 17/02/2025 13:35:10
    ''' </summary>
    ''' <returns>
    '''      Boolean
    ''' </returns>
    ''' <remarks>
    '''      (c) ETLA - PM-2025
    ''' </remarks>
    Public Shared Function ModificaDistancias(ByVal pClsDistancias As ClsDistancias) As Boolean
        Dim mReturn As Boolean = True
        Dim mStrSQL As String
        Dim mDB As New SqlConnection
        Dim mCMD As New SqlCommand

        mCMD.Parameters.Clear()
        mCMD.Parameters.AddWithValue("@pCod_Distancia", pClsDistancias.Cod_Distancia.Substring(0, IIf(Len(pClsDistancias.Cod_Distancia) > 5, 5, Len(pClsDistancias.Cod_Distancia))))
        mCMD.Parameters.AddWithValue("@pCod_Paragem1", pClsDistancias.Cod_Paragem1.Substring(0, IIf(Len(pClsDistancias.Cod_Paragem1) > 5, 5, Len(pClsDistancias.Cod_Paragem1))))
        mCMD.Parameters.AddWithValue("@pCod_Paragem2", pClsDistancias.Cod_Paragem2.Substring(0, IIf(Len(pClsDistancias.Cod_Paragem2) > 5, 5, Len(pClsDistancias.Cod_Paragem2))))
        mCMD.Parameters.AddWithValue("@pDistancia", pClsDistancias.Distancia)
        mCMD.Parameters.AddWithValue("@pTempo_Min", pClsDistancias.Tempo_Min)


        mStrSQL = "UPDATE Distancias SET "
        mStrSQL += "Cod_Paragem1=@pCod_Paragem1,"
        mStrSQL += "Cod_Paragem2=@pCod_Paragem2,"
        mStrSQL += "Distancia=@pDistancia,"
        mStrSQL += "Tempo_Min=@pTempo_Min "
        mStrSQL += "WHERE Cod_Distancia=@pCod_Distancia"


        mDB.ConnectionString = My.Settings.Connection
        mCMD.CommandText = mStrSQL
        mDB.Open()
        mCMD.Connection = mDB

        Try
            mCMD.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("ModificaDistancias:" + vbCrLf + "Erro ao Gravar!!!" + vbCrLf + ex.ToString)
            mReturn = False
        End Try
        mDB.Close()
        Return mReturn
    End Function

    ''' <summary>
    '''      Function GravaDistancias(ByVal pNovoDistancias As ClsDistancias) Método para Gravar a TABELA Distancias
    '''      Gerado em 17/02/2025 13:35:10
    ''' </summary>
    ''' <returns>
    '''      Boolean
    ''' </returns>
    ''' <remarks>
    '''      (c) ETLA - PM-2025
    ''' </remarks>
    Public Shared Function GravaDistancias(ByVal pNovoDistancias As ClsDistancias) As Boolean
        Dim mReturn As Boolean = True

        Dim mStrSQL As String
        Dim mDB As New SqlConnection
        Dim mCMD As New SqlCommand
        mDB.ConnectionString = My.Settings.Connection
        mCMD.Parameters.Clear()


        mCMD.Parameters.AddWithValue("@pCod_Distancia", pNovoDistancias.Cod_Distancia.Substring(0, IIf(Len(pNovoDistancias.Cod_Distancia) > 5, 5, Len(pNovoDistancias.Cod_Distancia))))
        mCMD.Parameters.AddWithValue("@pCod_Paragem1", pNovoDistancias.Cod_Paragem1.Substring(0, IIf(Len(pNovoDistancias.Cod_Paragem1) > 5, 5, Len(pNovoDistancias.Cod_Paragem1))))
        mCMD.Parameters.AddWithValue("@pCod_Paragem2", pNovoDistancias.Cod_Paragem2.Substring(0, IIf(Len(pNovoDistancias.Cod_Paragem2) > 5, 5, Len(pNovoDistancias.Cod_Paragem2))))
        mCMD.Parameters.AddWithValue("@pDistancia", pNovoDistancias.Distancia)
        mCMD.Parameters.AddWithValue("@pTempo_Min", pNovoDistancias.Tempo_Min)
        mCMD.Parameters.AddWithValue("@pFLG_Ativo", pNovoDistancias.FLG_Ativo)
        mStrSQL = "INSERT INTO Distancias "
        mStrSQL += "("
        mStrSQL += "Cod_Distancia,"
        mStrSQL += "Cod_Paragem1,"
        mStrSQL += "Cod_Paragem2,"
        mStrSQL += "Distancia,"
        mStrSQL += "Tempo_Min,"
        mStrSQL += "FLG_Ativo "
        mStrSQL += ") "
        mStrSQL += "VALUES "
        mStrSQL += "("
        mStrSQL += "@pCod_Distancia,"
        mStrSQL += "@pCod_Paragem1,"
        mStrSQL += "@pCod_Paragem2,"
        mStrSQL += "@pDistancia,"
        mStrSQL += "@pTempo_Min,"
        mStrSQL += "1"
        mStrSQL += ")"
        mCMD.CommandText = mStrSQL
        mDB.Open()
        mCMD.Connection = mDB
        Try
            mCMD.ExecuteNonQuery()
            ClsEmpresas.GravaContador(enCont.Distancias) '<<<<-------- Verificar se é  preciso...
        Catch ex As Exception
            MsgBox("GravaDistancias:" + vbCrLf + "Erro ao Gravar!!!" + vbCrLf + ex.ToString)
            mReturn = False
        End Try
        mDB.Close()
        Return mReturn
    End Function


    ''' <summary>
    '''      Function ApagaDistancias(ByVal pCod_Paragem1 As String) Método para Apagar um Registo da Tabela Distancias
    '''      Gerado em 17/02/2025 13:35:10
    ''' </summary>
    ''' <returns>
    '''      Boolean
    ''' </returns>
    ''' <remarks>
    '''      (c) ETLA - PM-2025
    ''' </remarks>
    Public Shared Function ApagaDistancias(ByVal pCod_Paragem1 As String) As Boolean
        Dim mReturn As Boolean = True

        Dim mStrSQL As String
        Dim mDB As New SqlConnection
        Dim mCMD As New SqlCommand
        mCMD.Parameters.Clear()

        mCMD.Parameters.AddWithValue("@pCod_Paragem1", pCod_Paragem1)


        mStrSQL = "UPDATE Distancias SET "
        mStrSQL += "FLG_Ativo=0 "
        mStrSQL += "WHERE Cod_Paragem1=@pCod_Paragem1"


        mDB.ConnectionString = My.Settings.Connection
        mCMD.CommandText = mStrSQL
        mDB.Open()
        mCMD.Connection = mDB
        Try
            'mCMD.ExecuteNonQuery()
            MsgBox("Corrigir antes de apagar.")
        Catch ex As Exception
            MsgBox("ApagaDistancias:" + vbCrLf + "Erro ao Gravar!!!" + vbCrLf + ex.ToString)
            mReturn = False
        End Try

        mDB.Close()

        Return mReturn

    End Function
End Class




''' <summary>
'''      Classe DistanciasComparer 
'''      Gerado em 17/02/2025 13:35:10
''' </summary>
''' <remarks>
'''      (c) ETLA - PM-2025
''' </remarks>
Public Class DistanciasComparer
    Implements IEqualityComparer(Of ClsDistancias)

    Public Function Equals1(ByVal x As ClsDistancias, ByVal y As ClsDistancias) As Boolean Implements IEqualityComparer(Of ClsDistancias).Equals
        If x Is y Then Return True

        If x Is Nothing OrElse y Is Nothing Then Return False

Return (x.Cod_Paragem1 = y.Cod_Paragem1) ' AndAlso (x.Paragem1 = y.Paragem1)
End Function

Public Function GetHashCode1(ByVal pCls As clsDistancias) As Integer Implements IEqualityComparer(Of clsDistancias).GetHashCode

If pCls Is Nothing Then Return 0

'Dim Hash_ClsDistancias_Paragem1 = pCls.Paragem1.GetHashCode()
Dim Hash_ClsDistancias_Cod_Paragem1 = pCls.Cod_Paragem1.GetHashCode()

Return Hash_ClsDistancias_Cod_Paragem1 'Xor Hash_ClsDistancias_Paragem1
End Function
End Class


