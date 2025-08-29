
Imports System.Data.SqlClient


''' <summary>
'''      Classe ClsViaturas Classe da Tabela Viaturas
'''      Gerado em 23/01/2025 15:59:30
''' </summary>
''' <remarks>
'''      (c) ETLA - PM-2025
''' </remarks>
Public Class ClsViaturas


    ' -----------------------------------------
    ' Property's da tabela Viaturas
    ' -----------------------------------------

    Public Property Cod_Viatura As String                                   ' Len:  5 - SQL_Type: nvarchar
    Public Property Descritivo As String                                    ' Len: 30 - SQL_Type: nvarchar
    Public Property Vel_Media As Integer                                    ' SQL_Type: smallint
    Public Property Fator_Preco As Integer                                  ' SQL_Type: smallint
    Public Property Lugares As Integer                                      ' SQL_Type: smallint
    Public Property Ano_Fabrico As Integer                                  ' SQL_Type: smallint
    Public Property Cod_Imagem As String                                    ' Len: 30 - SQL_Type: nvarchar
    Public Property FLG_Tomadas As Boolean                                  ' SQL_Type: bit
    Public Property FLG_USB As Boolean                                      ' SQL_Type: bit
    Public Property FLG_Wifi As Boolean                                     ' SQL_Type: bit
    Public Property FLG_AC As Boolean                                       ' SQL_Type: bit
    Public Property FLG_WC As Boolean                                       ' SQL_Type: bit
    Public Property FLG_Ativo As Boolean                                    ' SQL_Type: bit


    Sub New()
    End Sub


    '--------------------------------------------
    ' Exemplo de criador de Código por contador
    ' Para ser usado no caso de o Cdigo ser gerado
    ' e o contador existir na tabela Empresas
    '---------------------------------------------

    Friend Shared Function GetNovoCodigo() As String

        Return "V" & ClsEmpresas.GetContador(enCont.Viatura).ToString("000") ' <-------------- VERIFICAR O Nº de ZEROS

    End Function


    ''' <summary>
    '''      Function GetViaturas() Método para devolver a Lista de Viaturas
    '''      Gerado em 23/01/2025 15:59:30
    ''' </summary>
    ''' <returns>
    '''      mListaViaturas
    ''' </returns>
    ''' <remarks>
    '''      (c) ETLA - PM-2025
    ''' </remarks>
    Public Shared Function GetViaturas() As List(Of ClsViaturas)
        Dim mListaViaturas As New List(Of ClsViaturas)

        Dim mStrSQL As String
        Dim mDB As New SqlConnection
        Dim mCMD As New SqlCommand
        Dim mRDR As SqlDataReader

        mDB.ConnectionString = My.Settings.Connection
        mCMD.Parameters.Clear()

        mStrSQL = "SELECT "
        mStrSQL += "ISNULL(Cod_Viatura,'') As Cod_Viatura,"
        mStrSQL += "ISNULL(Descritivo,'') As Descritivo,"
        mStrSQL += "ISNULL(Vel_Media,0) As Vel_Media,"
        mStrSQL += "ISNULL(Fator_Preco,0) As Fator_Preco,"
        mStrSQL += "ISNULL(Lugares,0) As Lugares,"
        mStrSQL += "ISNULL(Ano_Fabrico,0) As Ano_Fabrico,"
        mStrSQL += "ISNULL(Cod_Imagem,'') As Cod_Imagem,"
        mStrSQL += "ISNULL(FLG_Tomadas,1) As FLG_Tomadas,"
        mStrSQL += "ISNULL(FLG_USB,1) As FLG_USB,"
        mStrSQL += "ISNULL(FLG_Wifi,1) As FLG_Wifi,"
        mStrSQL += "ISNULL(FLG_AC,1) As FLG_AC,"
        mStrSQL += "ISNULL(FLG_WC,1) As FLG_WC,"
        mStrSQL += "ISNULL(FLG_Ativo,1) As FLG_Ativo "
        mStrSQL += "FROM Viaturas "
        mStrSQL += "WHERE FLG_Ativo=1"


        mCMD.CommandText = mStrSQL
        mDB.Open()
        mCMD.Connection = mDB

        mRDR = mCMD.ExecuteReader

        While mRDR.Read()

            Dim mClsViaturas As New ClsViaturas

            With mClsViaturas
                .Cod_Viatura = mRDR.GetString(mRDR.GetOrdinal("Cod_Viatura"))
                .Descritivo = mRDR.GetString(mRDR.GetOrdinal("Descritivo"))
                .Vel_Media = mRDR.GetValue(mRDR.GetOrdinal("Vel_Media"))
                .Fator_Preco = mRDR.GetValue(mRDR.GetOrdinal("Fator_Preco"))
                .Lugares = mRDR.GetValue(mRDR.GetOrdinal("Lugares"))
                .Ano_Fabrico = mRDR.GetValue(mRDR.GetOrdinal("Ano_Fabrico"))
                .Cod_Imagem = mRDR.GetString(mRDR.GetOrdinal("Cod_Imagem"))
                .FLG_Tomadas = mRDR.GetBoolean(mRDR.GetOrdinal("FLG_Tomadas"))
                .FLG_USB = mRDR.GetBoolean(mRDR.GetOrdinal("FLG_USB"))
                .FLG_Wifi = mRDR.GetBoolean(mRDR.GetOrdinal("FLG_Wifi"))
                .FLG_AC = mRDR.GetBoolean(mRDR.GetOrdinal("FLG_AC"))
                .FLG_WC = mRDR.GetBoolean(mRDR.GetOrdinal("FLG_WC"))
                .FLG_Ativo = mRDR.GetBoolean(mRDR.GetOrdinal("FLG_Ativo"))
            End With


            mListaViaturas.Add(mClsViaturas)

        End While

        mRDR.Close()
        mDB.Close()

        Return mListaViaturas
    End Function

    ''' <summary>
    '''      Function FiltrarViaturas Método para Filtrar os campos da lista de Viaturas
    '''      Gerado em 23/01/2025 15:59:30
    ''' </summary>
    ''' <returns>
    '''      mListaViaturas
    ''' </returns>
    ''' <remarks>
    '''      (c) ETLA - PM-2025
    ''' </remarks>
    Public Shared Function FiltrarViaturas(ByVal pFiltro As ClsViaturas) As List(Of ClsViaturas)
        Dim mListaViaturas As New List(Of ClsViaturas)
        Dim mLista As New List(Of ClsViaturas)

        mListaViaturas = GetViaturas()

        mLista = mListaViaturas.FindAll(Function(x) _
        x.Cod_Viatura.Contains(pFiltro.Cod_Viatura)
        )
        '-----------------------------------------------------
        'Pode Colocar em cima mais colunas como esta abaixo...
        '-----------------------------------------------------
        ' AND x.Descritivo.Contains(pFiltro.Descritivo) 

        Return mLista
    End Function


    ''' <summary>
    '''      Function GetViaturasByCod(ByVal pCod_Viatura As String) Método para decolver uma Classe de Viaturas
    '''      Gerado em 23/01/2025 15:59:30
    ''' </summary>
    ''' <returns>
    '''      mClsViaturas
    ''' </returns>
    ''' <remarks>
    '''      (c) ETLA - PM-2025
    ''' </remarks>
    Public Shared Function GetViaturasByCod(ByVal pCod_Viatura As String) As ClsViaturas
        Dim mClsViaturas As New ClsViaturas

        Dim mStrSQL As String
        Dim mDB As New SqlConnection
        Dim mCMD As New SqlCommand
        Dim mRDR As SqlDataReader

        mDB.ConnectionString = My.Settings.Connection
        mCMD.Parameters.Clear()
        mCMD.Parameters.AddWithValue("@pCod_Viatura", pCod_Viatura)


        mStrSQL = "SELECT "
        mStrSQL += "ISNULL(Cod_Viatura,'') As Cod_Viatura,"
        mStrSQL += "ISNULL(Descritivo,'') As Descritivo,"
        mStrSQL += "ISNULL(Vel_Media,0) As Vel_Media,"
        mStrSQL += "ISNULL(Fator_Preco,0) As Fator_Preco,"
        mStrSQL += "ISNULL(Lugares,0) As Lugares,"
        mStrSQL += "ISNULL(Ano_Fabrico,0) As Ano_Fabrico,"
        mStrSQL += "ISNULL(Cod_Imagem,'') As Cod_Imagem,"
        mStrSQL += "ISNULL(FLG_Tomadas,1) As FLG_Tomadas,"
        mStrSQL += "ISNULL(FLG_USB,1) As FLG_USB,"
        mStrSQL += "ISNULL(FLG_Wifi,1) As FLG_Wifi,"
        mStrSQL += "ISNULL(FLG_AC,1) As FLG_AC,"
        mStrSQL += "ISNULL(FLG_WC,1) As FLG_WC,"
        mStrSQL += "ISNULL(FLG_Ativo,1) As FLG_Ativo "
        mStrSQL += "FROM Viaturas "
        mStrSQL += "WHERE FLG_Ativo=1 "
        mStrSQL += "AND Cod_Viatura=@pCod_Viatura"


        mCMD.CommandText = mStrSQL
        mDB.Open()
        mCMD.Connection = mDB

        mRDR = mCMD.ExecuteReader

        If mRDR.Read() Then


            With mClsViaturas
                .Cod_Viatura = mRDR.GetString(mRDR.GetOrdinal("Cod_Viatura"))
                .Descritivo = mRDR.GetString(mRDR.GetOrdinal("Descritivo"))
                .Vel_Media = mRDR.GetValue(mRDR.GetOrdinal("Vel_Media"))
                .Fator_Preco = mRDR.GetValue(mRDR.GetOrdinal("Fator_Preco"))
                .Lugares = mRDR.GetValue(mRDR.GetOrdinal("Lugares"))
                .Ano_Fabrico = mRDR.GetValue(mRDR.GetOrdinal("Ano_Fabrico"))
                .Cod_Imagem = mRDR.GetString(mRDR.GetOrdinal("Cod_Imagem"))
                .FLG_Tomadas = mRDR.GetBoolean(mRDR.GetOrdinal("FLG_Tomadas"))
                .FLG_USB = mRDR.GetBoolean(mRDR.GetOrdinal("FLG_USB"))
                .FLG_Wifi = mRDR.GetBoolean(mRDR.GetOrdinal("FLG_Wifi"))
                .FLG_AC = mRDR.GetBoolean(mRDR.GetOrdinal("FLG_AC"))
                .FLG_WC = mRDR.GetBoolean(mRDR.GetOrdinal("FLG_WC"))
                .FLG_Ativo = mRDR.GetBoolean(mRDR.GetOrdinal("FLG_Ativo"))
            End With


        End If
        mRDR.Close()
        mDB.Close()

        Return mClsViaturas
    End Function


    ''' <summary>
    '''      Function ModificaViaturas(ByVal pClsViaturas As ClsViaturas) Método para Modificar a TABELA Viaturas
    '''      Gerado em 23/01/2025 15:59:30
    ''' </summary>
    ''' <returns>
    '''      Boolean
    ''' </returns>
    ''' <remarks>
    '''      (c) ETLA - PM-2025
    ''' </remarks>
    Public Shared Function ModificaViaturas(ByVal pClsViaturas As ClsViaturas) As Boolean
        Dim mReturn As Boolean = True

        Dim mStrSQL As String
        Dim mDB As New SqlConnection
        Dim mCMD As New SqlCommand

        mCMD.Parameters.Clear()
        mCMD.Parameters.AddWithValue("@pCod_Viatura", pClsViaturas.Cod_Viatura.Substring(0, IIf(Len(pClsViaturas.Cod_Viatura) > 5, 5, Len(pClsViaturas.Cod_Viatura))))
        mCMD.Parameters.AddWithValue("@pDescritivo", pClsViaturas.Descritivo.Substring(0, IIf(Len(pClsViaturas.Descritivo) > 30, 30, Len(pClsViaturas.Descritivo))))
        mCMD.Parameters.AddWithValue("@pVel_Media", pClsViaturas.Vel_Media)
        mCMD.Parameters.AddWithValue("@pFator_Preco", pClsViaturas.Fator_Preco)
        mCMD.Parameters.AddWithValue("@pLugares", pClsViaturas.Lugares)
        mCMD.Parameters.AddWithValue("@pAno_Fabrico", pClsViaturas.Ano_Fabrico)
        mCMD.Parameters.AddWithValue("@pCod_Imagem", pClsViaturas.Cod_Imagem.Substring(0, IIf(Len(pClsViaturas.Cod_Imagem) > 30, 30, Len(pClsViaturas.Cod_Imagem))))
        mCMD.Parameters.AddWithValue("@pFLG_Tomadas", pClsViaturas.FLG_Tomadas)
        mCMD.Parameters.AddWithValue("@pFLG_USB", pClsViaturas.FLG_USB)
        mCMD.Parameters.AddWithValue("@pFLG_Wifi", pClsViaturas.FLG_Wifi)
        mCMD.Parameters.AddWithValue("@pFLG_AC", pClsViaturas.FLG_AC)
        mCMD.Parameters.AddWithValue("@pFLG_WC", pClsViaturas.FLG_WC)


        mStrSQL = "UPDATE Viaturas SET "
        mStrSQL += "Descritivo=@pDescritivo,"
        mStrSQL += "Vel_Media=@pVel_Media,"
        mStrSQL += "Fator_Preco=@pFator_Preco,"
        mStrSQL += "Lugares=@pLugares,"
        mStrSQL += "Ano_Fabrico=@pAno_Fabrico,"
        mStrSQL += "Cod_Imagem=@pCod_Imagem,"
        mStrSQL += "FLG_Tomadas=@pFLG_Tomadas,"
        mStrSQL += "FLG_USB=@pFLG_USB,"
        mStrSQL += "FLG_Wifi=@pFLG_Wifi,"
        mStrSQL += "FLG_AC=@pFLG_AC,"
        mStrSQL += "FLG_WC=@pFLG_WC "
        mStrSQL += "WHERE Cod_Viatura=@pCod_Viatura"


        mDB.ConnectionString = My.Settings.Connection
        mCMD.CommandText = mStrSQL
        mDB.Open()
        mCMD.Connection = mDB

        Try
            mCMD.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("ModificaViaturas:" + vbCrLf + "Erro ao Gravar!!!" + vbCrLf + ex.ToString)
            mReturn = False
        End Try

        mDB.Close()

        Return mReturn

    End Function


    ''' <summary>
    '''      Function GravaViaturas(ByVal pNovoViaturas As ClsViaturas) Método para Gravar a TABELA Viaturas
    '''      Gerado em 23/01/2025 15:59:30
    ''' </summary>
    ''' <returns>
    '''      Boolean
    ''' </returns>
    ''' <remarks>
    '''      (c) ETLA - PM-2025
    ''' </remarks>
    Public Shared Function GravaViaturas(ByVal pNovoViaturas As ClsViaturas) As Boolean
        Dim mReturn As Boolean = True

        Dim mStrSQL As String
        Dim mDB As New SqlConnection
        Dim mCMD As New SqlCommand

        mDB.ConnectionString = My.Settings.Connection
        mCMD.Parameters.Clear()


        mCMD.Parameters.AddWithValue("@pCod_Viatura", pNovoViaturas.Cod_Viatura.Substring(0, IIf(Len(pNovoViaturas.Cod_Viatura) > 5, 5, Len(pNovoViaturas.Cod_Viatura))))
        mCMD.Parameters.AddWithValue("@pDescritivo", pNovoViaturas.Descritivo.Substring(0, IIf(Len(pNovoViaturas.Descritivo) > 30, 30, Len(pNovoViaturas.Descritivo))))
        mCMD.Parameters.AddWithValue("@pVel_Media", pNovoViaturas.Vel_Media)
        mCMD.Parameters.AddWithValue("@pFator_Preco", pNovoViaturas.Fator_Preco)
        mCMD.Parameters.AddWithValue("@pLugares", pNovoViaturas.Lugares)
        mCMD.Parameters.AddWithValue("@pAno_Fabrico", pNovoViaturas.Ano_Fabrico)
        mCMD.Parameters.AddWithValue("@pCod_Imagem", pNovoViaturas.Cod_Imagem.Substring(0, IIf(Len(pNovoViaturas.Cod_Imagem) > 30, 30, Len(pNovoViaturas.Cod_Imagem))))
        mCMD.Parameters.AddWithValue("@pFLG_Tomadas", pNovoViaturas.FLG_Tomadas)
        mCMD.Parameters.AddWithValue("@pFLG_USB", pNovoViaturas.FLG_USB)
        mCMD.Parameters.AddWithValue("@pFLG_Wifi", pNovoViaturas.FLG_Wifi)
        mCMD.Parameters.AddWithValue("@pFLG_AC", pNovoViaturas.FLG_AC)
        mCMD.Parameters.AddWithValue("@pFLG_WC", pNovoViaturas.FLG_WC)
        mCMD.Parameters.AddWithValue("@pFLG_Ativo", pNovoViaturas.FLG_Ativo)


        mStrSQL = "INSERT INTO Viaturas "
        mStrSQL += "("
        mStrSQL += "Cod_Viatura,"
        mStrSQL += "Descritivo,"
        mStrSQL += "Vel_Media,"
        mStrSQL += "Fator_Preco,"
        mStrSQL += "Lugares,"
        mStrSQL += "Ano_Fabrico,"
        mStrSQL += "Cod_Imagem,"
        mStrSQL += "FLG_Tomadas,"
        mStrSQL += "FLG_USB,"
        mStrSQL += "FLG_Wifi,"
        mStrSQL += "FLG_AC,"
        mStrSQL += "FLG_WC,"
        mStrSQL += "FLG_Ativo "
        mStrSQL += ") "
        mStrSQL += "VALUES "
        mStrSQL += "("
        mStrSQL += "@pCod_Viatura,"
        mStrSQL += "@pDescritivo,"
        mStrSQL += "@pVel_Media,"
        mStrSQL += "@pFator_Preco,"
        mStrSQL += "@pLugares,"
        mStrSQL += "@pAno_Fabrico,"
        mStrSQL += "@pCod_Imagem,"
        mStrSQL += "@pFLG_Tomadas,"
        mStrSQL += "@pFLG_USB,"
        mStrSQL += "@pFLG_Wifi,"
        mStrSQL += "@pFLG_AC,"
        mStrSQL += "@pFLG_WC,"
        mStrSQL += "1"
        mStrSQL += ")"


        mCMD.CommandText = mStrSQL
        mDB.Open()
        mCMD.Connection = mDB

        Try
            mCMD.ExecuteNonQuery()
            ClsEmpresas.GravaContador(enCont.Viatura) '<<<<-------- Verificar se é  preciso...
        Catch ex As Exception
            MsgBox("GravaViaturas:" + vbCrLf + "Erro ao Gravar!!!" + vbCrLf + ex.ToString)
            mReturn = False
        End Try

        mDB.Close()

        Return mReturn

    End Function


    ''' <summary>
    '''      Function ApagaViaturas(ByVal pCod_Viatura As String) Método para Apagar um Registo da Tabela Viaturas
    '''      Gerado em 23/01/2025 15:59:30
    ''' </summary>
    ''' <returns>
    '''      Boolean
    ''' </returns>
    ''' <remarks>
    '''      (c) ETLA - PM-2025
    ''' </remarks>
    Public Shared Function ApagaViaturas(ByVal pCod_Viatura As String) As Boolean
        Dim mReturn As Boolean = True

        Dim mStrSQL As String
        Dim mDB As New SqlConnection
        Dim mCMD As New SqlCommand

        mCMD.Parameters.Clear()

        mCMD.Parameters.AddWithValue("@pCod_Viatura", pCod_Viatura)


        mStrSQL = "UPDATE Viaturas SET "
        mStrSQL += "FLG_Ativo=0 "
        mStrSQL += "WHERE Cod_Viatura=@pCod_Viatura"


        mDB.ConnectionString = My.Settings.Connection
        mCMD.CommandText = mStrSQL
        mDB.Open()
        mCMD.Connection = mDB

        Try
            mCMD.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("ApagaViaturas:" + vbCrLf + "Erro ao Gravar!!!" + vbCrLf + ex.ToString)
            mReturn = False
        End Try

        mDB.Close()

        Return mReturn

    End Function
End Class



''' <summary>
'''      Classe ViaturasComparer 
'''      Gerado em 23/01/2025 15:59:30
''' </summary>
''' <remarks>
'''      (c) ETLA - PM-2025
''' </remarks>
Public Class ViaturasComparer
    Implements IEqualityComparer(Of ClsViaturas)

    Public Function Equals1(ByVal x As ClsViaturas, ByVal y As ClsViaturas) As Boolean Implements IEqualityComparer(Of ClsViaturas).Equals

        If x Is y Then Return True

        If x Is Nothing OrElse y Is Nothing Then Return False

        Return (x.Cod_Viatura = y.Cod_Viatura) ' AndAlso (x.Descritivo = y.Descritivo)
    End Function

    Public Function GetHashCode1(ByVal pCls As ClsViaturas) As Integer Implements IEqualityComparer(Of ClsViaturas).GetHashCode

        If pCls Is Nothing Then Return 0

        'Dim Hash_ClsViaturas_Descritivo = pCls.Descritivo.GetHashCode()
        Dim Hash_ClsViaturas_Cod_Viatura = pCls.Cod_Viatura.GetHashCode()

        Return Hash_ClsViaturas_Cod_Viatura 'Xor Hash_ClsViaturas_Descritivo
    End Function
End Class
