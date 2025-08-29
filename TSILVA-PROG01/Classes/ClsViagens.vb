
Imports System.Data.SqlClient
Imports System.Reflection.Emit
Imports System.Runtime.InteropServices.WindowsRuntime


''' <summary>
'''      Classe ClsViagens Classe da Tabela Viagens
'''      Gerado em 23/01/2025 13:57:14
''' </summary>
''' <remarks>
'''      (c) ETLA - PM-2025
''' </remarks>
Public Class ClsViagens


    ' -----------------------------------------
    ' Property's da tabela Viagens
    ' -----------------------------------------

    Public Property Cod_Viagem As String                                    ' Len:  8 - SQL_Type: nvarchar
    Public Property Descritivo As String                                    ' Len: 30 - SQL_Type: nvarchar
    Public Property Tipo_Viagem As Integer                                  ' SQL_Type: smallint

    Public ReadOnly Property SIGLA_Tipo_Viagem As String
        Get
            Return ClsTipos_Viagem.GetTipos_ViagemByCod(Tipo_Viagem).SIGLA
        End Get
    End Property

    Public ReadOnly Property DESC_Tipo_Viagem As String
        Get
            Return ClsTipos_Viagem.GetTipos_ViagemByCod(Tipo_Viagem).Descrtivo
        End Get
    End Property
    Public Property Cod_Viatura As String                                   ' Len:  5 - SQL_Type: nvarchar
    Public ReadOnly Property Viatura As String
        Get
            Return ClsViaturas.GetViaturasByCod(Cod_Viatura).Descritivo
        End Get
    End Property
    Public Property Cod_Rota As String                                      ' Len:  5 - SQL_Type: nvarchar
    Public Property Data_Viagem As DateTime                                    ' SQL_Type: smalldatetime
    Public ReadOnly Property Dia_Semana As String                                    ' Len: 15 - SQL_Type: nvarchar
        Get
            Return Data_Viagem.DayOfWeek
        End Get
    End Property

    Public ReadOnly Property ETD As String                                      ' SQL_Type: smalldatetime
        Get
            Return Data_Viagem.Hour.ToString("00") & ":" & Data_Viagem.Minute.ToString("00")
        End Get
    End Property

    Public Property ATD As DateTime                                            ' SQL_Type: smalldatetime
    Public Property Cod_Motorista As String                                 ' Len:  5 - SQL_Type: nvarchar
    Public ReadOnly Property Nome_Motorista
        Get
            Return ClsEntidades.GetEntidadesByCod(Cod_Motorista).Nome
        End Get
    End Property

    Public Property Lista_VParagens As List(Of ClsViagem_Paragens)

    Public ReadOnly Property Num_Paragens As Integer                                 ' SQL_Type: smallint
        Get
            If Not Lista_VParagens Is Nothing Then
                Return Lista_VParagens.Count
            Else
                Return 0
            End If

        End Get
    End Property


    Public Property FLG_Estado As Integer                                ' SQL_Type: smallint
    Public Property Num_KM As Integer
    Public Property FLG_Ativo As Boolean                                    ' SQL_Type: bit


    Sub New()
    End Sub



    '--------------------------------------------------------
    'Para criar a Viagem a partir das Variáveis:
    '   Tipo_Viagem
    '   Cod_Viatura
    '   Cod_Motorista
    '   Cod_Rota
    '   Data_Viagem
    '   ---------------------------
    '   A Lista_VParagens é criada a partir da Rota_Paragens
    '--------------------------------------------------------

    Sub New(ByVal pTipo_Viagem As Integer, ByVal pCod_Viatura As String, ByVal pCod_Motorista As String, ByVal pCod_Rota As String, ByVal pData_Viagem As DateTime)
        Dim mTipo_Viagem As New ClsTipos_Viagem
        mTipo_Viagem = ClsTipos_Viagem.GetTipos_ViagemByCod(pTipo_Viagem)
        Dim mRota As New ClsRotas
        mRota = ClsRotas.GetRotasByCod(pCod_Rota)

        Cod_Viagem = GetNovoCodigo(mTipo_Viagem.SIGLA)
        Descritivo = "Viagem " & mTipo_Viagem.Descrtivo & " " & mRota.Descritivo
        Tipo_Viagem = pTipo_Viagem
        Cod_Viatura = pCod_Viatura
        Cod_Rota = pCod_Rota
        'pData_Viagem = pData_Viagem.AddHours(10)
        Data_Viagem = Format(pData_Viagem, "dd/MM/yyyy HH:mm")
        FLG_Estado = 3
        Cod_Motorista = pCod_Motorista
        'Dim DataString As String = pData_Viagem.Day.ToString & "/" &
        ATD = Format(pData_Viagem, "dd/MM/yyyy HH:mm")

        Lista_VParagens = GetLista_VParagens(Cod_Rota, Cod_Viagem, Data_Viagem)

        Num_KM = mRota.Lista_Paragens.Sum(Function(X) X.Dist_Km) / 1000

        FLG_Ativo = True

    End Sub


    Friend Shared Function GetLista_VParagens(ByVal pCod_Rota As String, ByVal pCod_Viagem As String, ByVal pData_Viagem As DateTime) As List(Of ClsViagem_Paragens)
        Dim mLista_VParagens As New List(Of ClsViagem_Paragens)
        Dim mLista_RParagens As New List(Of ClsRota_Paragens)

        mLista_RParagens = ClsRota_Paragens.GetRota_Paragens(pCod_Rota)

        Dim mMinutos As Integer = 0

        For Each mRP As ClsRota_Paragens In mLista_RParagens
            Dim mVP As New ClsViagem_Paragens
            With mVP

                mMinutos += mRP.Tempo_Min

                .Cod_Viagem = pCod_Viagem
                .Cod_Paragem = mRP.Cod_Paragem
                .Ordem = mRP.Ordem
                .Descritivo = mRP.Paragem_Descritivo

                .ETD = pData_Viagem.AddMinutes(mMinutos)
                .ATD = .ETD
                .FLG_Ativo = True

            End With

            mLista_VParagens.Add(mVP)
        Next

        Return mLista_VParagens
    End Function


    '--------------------------------------------
    ' Exemplo de criador de Código por contador
    ' Para ser usado no caso de o Cdigo ser gerado
    ' e o contador existir na tabela Empresas
    '---------------------------------------------

    Friend Shared Function GetNovoCodigo(ByVal pTV_SIGLA As String) As String

        Return "V-" & pTV_SIGLA & ClsEmpresas.GetContador(enCont.Viagem).ToString("000") ' <-------------- VERIFICAR O Nº de ZEROS

    End Function


    ''' <summary>
    '''      Function GetViagens() Método para devolver a Lista de Viagens
    '''      Gerado em 23/01/2025 13:57:14
    ''' </summary>
    ''' <returns>
    '''      mListaViagens
    ''' </returns>
    ''' <remarks>
    '''      (c) ETLA - PM-2025
    ''' </remarks>
    Public Shared Function GetViagens() As List(Of ClsViagens)
        Dim mListaViagens As New List(Of ClsViagens)

        Dim mStrSQL As String
        Dim mDB As New SqlConnection
        Dim mCMD As New SqlCommand
        Dim mRDR As SqlDataReader

        mDB.ConnectionString = My.Settings.Connection
        mCMD.Parameters.Clear()

        mStrSQL = "SELECT "
        mStrSQL += "ISNULL(Cod_Viagem,'') As Cod_Viagem,"
        mStrSQL += "ISNULL(Descritivo,'') As Descritivo,"
        mStrSQL += "ISNULL(Tipo_Viagem,0) As Tipo_Viagem,"
        mStrSQL += "ISNULL(Cod_Viatura,'') As Cod_Viatura,"
        mStrSQL += "ISNULL(Cod_Rota,'') As Cod_Rota,"
        mStrSQL += "ISNULL(Data_Viagem,0) As Data_Viagem,"

        mStrSQL += "ISNULL(ATD,0) As ATD,"
        mStrSQL += "ISNULL(Cod_Motorista,'') As Cod_Motorista,"

        mStrSQL += "ISNULL(FLG_Estado,0) As FLG_Estado,"

        mStrSQL += "ISNULL(FLG_Ativo,1) As FLG_Ativo "
        mStrSQL += "FROM Viagens "
        mStrSQL += "WHERE FLG_Ativo=1"


        mCMD.CommandText = mStrSQL
        mDB.Open()
        mCMD.Connection = mDB

        mRDR = mCMD.ExecuteReader

        While mRDR.Read()

            Dim mClsViagens As New ClsViagens
            Dim mRota As New ClsRotas

            With mClsViagens
                .Cod_Viagem = mRDR.GetString(mRDR.GetOrdinal("Cod_Viagem"))
                .Descritivo = mRDR.GetString(mRDR.GetOrdinal("Descritivo"))
                .Tipo_Viagem = mRDR.GetValue(mRDR.GetOrdinal("Tipo_Viagem"))
                .Cod_Viatura = mRDR.GetString(mRDR.GetOrdinal("Cod_Viatura"))
                .Cod_Rota = mRDR.GetString(mRDR.GetOrdinal("Cod_Rota"))
                .Data_Viagem = mRDR.GetDateTime(mRDR.GetOrdinal("Data_Viagem"))

                .ATD = mRDR.GetDateTime(mRDR.GetOrdinal("ATD"))
                .Cod_Motorista = mRDR.GetString(mRDR.GetOrdinal("Cod_Motorista"))

                .FLG_Estado = mRDR.GetValue(mRDR.GetOrdinal("FLG_Estado"))

                .FLG_Ativo = mRDR.GetBoolean(mRDR.GetOrdinal("FLG_Ativo"))

                .Lista_VParagens = ClsViagem_Paragens.GetViagem_ParagensByCod(.Cod_Viagem)

            End With


            mListaViagens.Add(mClsViagens)

        End While

        mRDR.Close()
        mDB.Close()

        Return mListaViagens
    End Function

    ''' <summary>
    '''      Function FiltrarViagens Método para Filtrar os campos da lista de Viagens
    '''      Gerado em 23/01/2025 13:57:14
    ''' </summary>
    ''' <returns>
    '''      mListaViagens
    ''' </returns>
    ''' <remarks>
    '''      (c) ETLA - PM-2025
    ''' </remarks>
    Public Shared Function FiltrarViagens(ByVal pFiltro As ClsViagens) As List(Of ClsViagens)
        Dim mListaViagens As New List(Of ClsViagens)
        Dim mLista As New List(Of ClsViagens)

        mListaViagens = GetViagens()

        mLista = mListaViagens.FindAll(Function(x) _
        x.Cod_Viagem.Contains(pFiltro.Cod_Viagem)
        )
        '-----------------------------------------------------
        'Pode Colocar em cima mais colunas como esta abaixo...
        '-----------------------------------------------------
        ' AND x.Descritivo.Contains(pFiltro.Descritivo) 

        Return mLista
    End Function


    ''' <summary>
    '''      Function GetViagensByCod(ByVal pCod_Viagem As String) Método para decolver uma Classe de Viagens
    '''      Gerado em 23/01/2025 13:57:14
    ''' </summary>
    ''' <returns>
    '''      mClsViagens
    ''' </returns>
    ''' <remarks>
    '''      (c) ETLA - PM-2025
    ''' </remarks>
    Public Shared Function GetViagensByCod(ByVal pCod_Viagem As String) As ClsViagens
        Dim mClsViagens As New ClsViagens

        Dim mStrSQL As String
        Dim mDB As New SqlConnection
        Dim mCMD As New SqlCommand
        Dim mRDR As SqlDataReader

        mDB.ConnectionString = My.Settings.Connection
        mCMD.Parameters.Clear()
        mCMD.Parameters.AddWithValue("@pCod_Viagem", pCod_Viagem)


        mStrSQL = "SELECT "
        mStrSQL += "ISNULL(Cod_Viagem,'') As Cod_Viagem,"
        mStrSQL += "ISNULL(Descritivo,'') As Descritivo,"
        mStrSQL += "ISNULL(Tipo_Viagem,0) As Tipo_Viagem,"
        mStrSQL += "ISNULL(Cod_Viatura,'') As Cod_Viatura,"
        mStrSQL += "ISNULL(Cod_Rota,'') As Cod_Rota,"
        mStrSQL += "ISNULL(Data_Viagem,0) As Data_Viagem,"

        mStrSQL += "ISNULL(ATD,0) As ATD,"
        mStrSQL += "ISNULL(Cod_Motorista,'') As Cod_Motorista,"
        mStrSQL += "ISNULL(Num_Paragens,0) As Num_Paragens,"
        mStrSQL += "ISNULL(FLG_Estado,0) As FLG_Estado,"

        mStrSQL += "ISNULL(FLG_Ativo,1) As FLG_Ativo "
        mStrSQL += "FROM Viagens "
        mStrSQL += "WHERE FLG_Ativo=1 "
        mStrSQL += "AND Cod_Viagem=@pCod_Viagem"


        mCMD.CommandText = mStrSQL
        mDB.Open()
        mCMD.Connection = mDB

        mRDR = mCMD.ExecuteReader

        If mRDR.Read() Then


            With mClsViagens
                .Cod_Viagem = mRDR.GetString(mRDR.GetOrdinal("Cod_Viagem"))
                .Descritivo = mRDR.GetString(mRDR.GetOrdinal("Descritivo"))
                .Tipo_Viagem = mRDR.GetValue(mRDR.GetOrdinal("Tipo_Viagem"))
                .Cod_Viatura = mRDR.GetString(mRDR.GetOrdinal("Cod_Viatura"))
                .Cod_Rota = mRDR.GetString(mRDR.GetOrdinal("Cod_Rota"))
                .Data_Viagem = mRDR.GetDateTime(mRDR.GetOrdinal("Data_Viagem"))

                .ATD = mRDR.GetDateTime(mRDR.GetOrdinal("ATD"))
                .Cod_Motorista = mRDR.GetString(mRDR.GetOrdinal("Cod_Motorista"))

                .FLG_Estado = mRDR.GetValue(mRDR.GetOrdinal("FLG_Estado"))

                .FLG_Ativo = mRDR.GetBoolean(mRDR.GetOrdinal("FLG_Ativo"))
            End With


        End If
        mRDR.Close()
        mDB.Close()

        Return mClsViagens
    End Function


    ''' <summary>
    '''      Function ModificaViagens(ByVal pClsViagens As ClsViagens) Método para Modificar a TABELA Viagens
    '''      Gerado em 23/01/2025 13:57:14
    ''' </summary>
    ''' <returns>
    '''      Boolean
    ''' </returns>
    ''' <remarks>
    '''      (c) ETLA - PM-2025
    ''' </remarks>
    Public Shared Function ModificaViagens(ByVal pClsViagens As ClsViagens) As Boolean
        Dim mReturn As Boolean = True

        Dim mStrSQL As String
        Dim mDB As New SqlConnection
        Dim mCMD As New SqlCommand

        mCMD.Parameters.Clear()
        mCMD.Parameters.AddWithValue("@pCod_Viagem", pClsViagens.Cod_Viagem.Substring(0, IIf(Len(pClsViagens.Cod_Viagem) > 8, 8, Len(pClsViagens.Cod_Viagem))))
        mCMD.Parameters.AddWithValue("@pDescritivo", pClsViagens.Descritivo.Substring(0, IIf(Len(pClsViagens.Descritivo) > 80, 80, Len(pClsViagens.Descritivo))))
        mCMD.Parameters.AddWithValue("@pTipo_Viagem", pClsViagens.Tipo_Viagem)
        mCMD.Parameters.AddWithValue("@pCod_Viatura", pClsViagens.Cod_Viatura.Substring(0, IIf(Len(pClsViagens.Cod_Viatura) > 5, 5, Len(pClsViagens.Cod_Viatura))))
        mCMD.Parameters.AddWithValue("@pCod_Rota", pClsViagens.Cod_Rota.Substring(0, IIf(Len(pClsViagens.Cod_Rota) > 5, 5, Len(pClsViagens.Cod_Rota))))
        mCMD.Parameters.AddWithValue("@pData_Viagem", pClsViagens.Data_Viagem)

        mCMD.Parameters.AddWithValue("@pATD", pClsViagens.ATD)
        mCMD.Parameters.AddWithValue("@pCod_Motorista", pClsViagens.Cod_Motorista.Substring(0, IIf(Len(pClsViagens.Cod_Motorista) > 5, 5, Len(pClsViagens.Cod_Motorista))))

        mCMD.Parameters.AddWithValue("@pFLG_Estado", pClsViagens.FLG_Estado)



        mStrSQL = "UPDATE Viagens SET "
        mStrSQL += "Descritivo=@pDescritivo,"
        mStrSQL += "Tipo_Viagem=@pTipo_Viagem,"
        mStrSQL += "Cod_Viatura=@pCod_Viatura,"
        mStrSQL += "Cod_Rota=@pCod_Rota,"
        mStrSQL += "Data_Viagem=@pData_Viagem,"

        mStrSQL += "ATD=@pATD,"
        mStrSQL += "Cod_Motorista=@pCod_Motorista,"

        mStrSQL += "FLG_Estado=@pFLG_Estado,"

        mStrSQL += "WHERE Cod_Viagem=@pCod_Viagem"


        mDB.ConnectionString = My.Settings.Connection
        mCMD.CommandText = mStrSQL
        mDB.Open()
        mCMD.Connection = mDB

        Try
            mCMD.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("ModificaViagens:" + vbCrLf + "Erro ao Gravar!!!" + vbCrLf + ex.ToString)
            mReturn = False
        End Try

        mDB.Close()

        Return mReturn

    End Function


    ''' <summary>
    '''      Function GravaViagens(ByVal pNovoViagens As ClsViagens) Método para Gravar a TABELA Viagens
    '''      Gerado em 23/01/2025 13:57:14
    ''' </summary>
    ''' <returns>
    '''      Boolean
    ''' </returns>
    ''' <remarks>
    '''      (c) ETLA - PM-2025
    ''' </remarks>
    Public Shared Function GravaViagens(ByVal pNovoViagens As ClsViagens) As Boolean
        Dim mReturn As Boolean = True

        Dim mStrSQL As String
        Dim mDB As New SqlConnection
        Dim mCMD As New SqlCommand

        mDB.ConnectionString = My.Settings.Connection
        mCMD.Parameters.Clear()


        mCMD.Parameters.AddWithValue("@pCod_Viagem", pNovoViagens.Cod_Viagem.Substring(0, IIf(Len(pNovoViagens.Cod_Viagem) > 8, 8, Len(pNovoViagens.Cod_Viagem))))
        mCMD.Parameters.AddWithValue("@pDescritivo", pNovoViagens.Descritivo.Substring(0, IIf(Len(pNovoViagens.Descritivo) > 80, 80, Len(pNovoViagens.Descritivo))))
        mCMD.Parameters.AddWithValue("@pTipo_Viagem", pNovoViagens.Tipo_Viagem)
        mCMD.Parameters.AddWithValue("@pCod_Viatura", pNovoViagens.Cod_Viatura.Substring(0, IIf(Len(pNovoViagens.Cod_Viatura) > 5, 5, Len(pNovoViagens.Cod_Viatura))))
        mCMD.Parameters.AddWithValue("@pCod_Rota", pNovoViagens.Cod_Rota.Substring(0, IIf(Len(pNovoViagens.Cod_Rota) > 5, 5, Len(pNovoViagens.Cod_Rota))))
        mCMD.Parameters.AddWithValue("@pData_Viagem", pNovoViagens.Data_Viagem)

        mCMD.Parameters.AddWithValue("@pATD", pNovoViagens.ATD)
        mCMD.Parameters.AddWithValue("@pCod_Motorista", pNovoViagens.Cod_Motorista.Substring(0, IIf(Len(pNovoViagens.Cod_Motorista) > 5, 5, Len(pNovoViagens.Cod_Motorista))))

        mCMD.Parameters.AddWithValue("@pFLG_Estado", pNovoViagens.FLG_Estado)

        mCMD.Parameters.AddWithValue("@pFLG_Ativo", pNovoViagens.FLG_Ativo)


        mStrSQL = "INSERT INTO Viagens "
        mStrSQL += "("
        mStrSQL += "Cod_Viagem,"
        mStrSQL += "Descritivo,"
        mStrSQL += "Tipo_Viagem,"
        mStrSQL += "Cod_Viatura,"
        mStrSQL += "Cod_Rota,"
        mStrSQL += "Data_Viagem,"
        mStrSQL += "ATD,"
        mStrSQL += "Cod_Motorista,"

        mStrSQL += "FLG_Estado,"
        mStrSQL += "FLG_Ativo "
        mStrSQL += ") "
        mStrSQL += "VALUES "
        mStrSQL += "("
        mStrSQL += "@pCod_Viagem,"
        mStrSQL += "@pDescritivo,"
        mStrSQL += "@pTipo_Viagem,"
        mStrSQL += "@pCod_Viatura,"
        mStrSQL += "@pCod_Rota,"
        mStrSQL += "@pData_Viagem,"
        mStrSQL += "@pATD,"
        mStrSQL += "@pCod_Motorista,"

        mStrSQL += "@pFLG_Estado,"
        mStrSQL += "1"
        mStrSQL += ")"


        mCMD.CommandText = mStrSQL
        mDB.Open()
        mCMD.Connection = mDB

        Try
            mCMD.ExecuteNonQuery()
            ClsEmpresas.GravaContador(enCont.Viagem) '<<<<-------- Verificar se é  preciso...
            ClsViagem_Paragens.Grava_Lista_VParagens(pNovoViagens.Lista_VParagens)

        Catch ex As Exception
            MsgBox("GravaViagens:" + vbCrLf + "Erro ao Gravar!!!" + vbCrLf + ex.ToString)
            mReturn = False
        End Try

        mDB.Close()

        Return mReturn

    End Function




    ''' <summary>
    '''      Function ApagaViagens(ByVal pCod_Viagem As String) Método para Apagar um Registo da Tabela Viagens
    '''      Gerado em 23/01/2025 13:57:14
    ''' </summary>
    ''' <returns>
    '''      Boolean
    ''' </returns>
    ''' <remarks>
    '''      (c) ETLA - PM-2025
    ''' </remarks>
    Public Shared Function ApagaViagens(ByVal pCod_Viagem As String) As Boolean
        Dim mReturn As Boolean = True

        Dim mStrSQL As String
        Dim mDB As New SqlConnection
        Dim mCMD As New SqlCommand

        mCMD.Parameters.Clear()

        mCMD.Parameters.AddWithValue("@pCod_Viagem", pCod_Viagem)


        mStrSQL = "UPDATE Viagens SET "
        mStrSQL += "FLG_Ativo=0 "
        mStrSQL += "WHERE Cod_Viagem=@pCod_Viagem"


        mDB.ConnectionString = My.Settings.Connection
        mCMD.CommandText = mStrSQL
        mDB.Open()
        mCMD.Connection = mDB

        Try
            mCMD.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("ApagaViagens:" + vbCrLf + "Erro ao Gravar!!!" + vbCrLf + ex.ToString)
            mReturn = False
        End Try

        mDB.Close()

        Return mReturn

    End Function
End Class



''' <summary>
'''      Classe ViagensComparer 
'''      Gerado em 23/01/2025 13:57:14
''' </summary>
''' <remarks>
'''      (c) ETLA - PM-2025
''' </remarks>
Public Class ViagensComparer
    Implements IEqualityComparer(Of ClsViagens)

    Public Function Equals1(ByVal x As ClsViagens, ByVal y As ClsViagens) As Boolean Implements IEqualityComparer(Of ClsViagens).Equals

        If x Is y Then Return True

        If x Is Nothing OrElse y Is Nothing Then Return False

        Return (x.Cod_Viagem = y.Cod_Viagem) ' AndAlso (x.Descritivo = y.Descritivo)
    End Function

    Public Function GetHashCode1(ByVal pCls As ClsViagens) As Integer Implements IEqualityComparer(Of ClsViagens).GetHashCode

        If pCls Is Nothing Then Return 0

        'Dim Hash_ClsViagens_Descritivo = pCls.Descritivo.GetHashCode()
        Dim Hash_ClsViagens_Cod_Viagem = pCls.Cod_Viagem.GetHashCode()

        Return Hash_ClsViagens_Cod_Viagem 'Xor Hash_ClsViagens_Descritivo
    End Function
End Class
