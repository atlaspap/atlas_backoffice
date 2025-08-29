
Imports System.Data.SqlClient


''' <summary>
'''      Classe ClsEstados Classe da Tabela Estados
'''      Gerado em 23/01/2025 13:57:13
''' </summary>
''' <remarks>
'''      (c) ETLA - PM-2025
''' </remarks>
Public Class ClsEstados


' -----------------------------------------
' Property's da tabela Estados
' -----------------------------------------

Public Property Cod_Estado As Integer									' SQL_Type: smallint
Public Property Estado As String										' Len: 15 - SQL_Type: nvarchar
Public Property FLG_Ativo As Boolean									' SQL_Type: bit


Sub New()
End Sub


'--------------------------------------------
' Exemplo de criador de Código por contador
' Para ser usado no caso de o Cdigo ser gerado
' e o contador existir na tabela Empresas
'---------------------------------------------

'Friend Shared Function GetNovoCodigo() As String

'Return "E" & ClsEmpresas.GetContador(enCont.Estados).ToString("000")' <-------------- VERIFICAR O Nº de ZEROS

'End Function


''' <summary>
'''      Function GetEstados() Método para devolver a Lista de Estados
'''      Gerado em 23/01/2025 13:57:13
''' </summary>
''' <returns>
'''      mListaEstados
''' </returns>
''' <remarks>
'''      (c) ETLA - PM-2025
''' </remarks>
Public Shared Function GetEstados() As List(Of clsEstados)
Dim mListaEstados As new List(Of clsEstados)

Dim mStrSQL as String
Dim mDB As New SqlConnection
Dim mCMD As New SqlCommand
Dim mRDR As SqlDataReader

mDB.ConnectionString = My.Settings.Connection
mCMD.Parameters.Clear()

mStrSQL="SELECT "
mStrSQL+="ISNULL(Cod_Estado,0) As Cod_Estado,"
mStrSQL+="ISNULL(Estado,'') As Estado,"
mStrSQL+="ISNULL(FLG_Ativo,1) As FLG_Ativo "
mStrSQL+="FROM Estados "
mStrSQL+="WHERE FLG_Ativo=1"


mCMD.CommandText = mStrSQL
mDB.Open()
mCMD.Connection = mDB

mRDR = mCMD.ExecuteReader

While mRDR.Read()

Dim mClsEstados As New ClsEstados

With mClsEstados
.Cod_Estado = mRDR.Getvalue(mRDR.GetOrdinal("Cod_Estado"))
.Estado = mRDR.GetString(mRDR.GetOrdinal("Estado"))
.FLG_Ativo = mRDR.GetBoolean(mRDR.GetOrdinal("FLG_Ativo"))
End With


mListaEstados.add(mClsEstados)

End While

mRDR.Close()
mDB.Close()

Return mListaEstados
End Function 


''' <summary>
'''      Function GetEstadosByCod(ByVal pCod_Estado As Integer) Método para decolver uma Classe de Estados
'''      Gerado em 23/01/2025 13:57:14
''' </summary>
''' <returns>
'''      mClsEstados
''' </returns>
''' <remarks>
'''      (c) ETLA - PM-2025
''' </remarks>
Public Shared Function GetEstadosByCod(ByVal pCod_Estado As Integer) As clsEstados
Dim mClsEstados As new clsEstados

Dim mStrSQL as String
Dim mDB As New SqlConnection
Dim mCMD As New SqlCommand
Dim mRDR As SqlDataReader

mDB.ConnectionString = My.Settings.Connection
mCMD.Parameters.Clear()
mCMD.Parameters.AddWithValue("@pCod_Estado",pCod_Estado)


mStrSQL="SELECT "
mStrSQL+="ISNULL(Cod_Estado,0) As Cod_Estado,"
mStrSQL+="ISNULL(Estado,'') As Estado,"
mStrSQL+="ISNULL(FLG_Ativo,1) As FLG_Ativo "
mStrSQL+="FROM Estados "
mStrSQL+="WHERE FLG_Ativo=1 "
mStrSQL+="AND Cod_Estado=@pCod_Estado"


mCMD.CommandText = mStrSQL
mDB.Open()
mCMD.Connection = mDB

mRDR = mCMD.ExecuteReader

IF mRDR.Read() Then


With mClsEstados
.Cod_Estado = mRDR.Getvalue(mRDR.GetOrdinal("Cod_Estado"))
.Estado = mRDR.GetString(mRDR.GetOrdinal("Estado"))
.FLG_Ativo = mRDR.GetBoolean(mRDR.GetOrdinal("FLG_Ativo"))
End With


End IF
mRDR.Close()
mDB.Close()

Return mClsEstados
End Function 


''' <summary>
'''      Function ModificaEstados(ByVal pClsEstados As ClsEstados) Método para Modificar a TABELA Estados
'''      Gerado em 23/01/2025 13:57:14
''' </summary>
''' <returns>
'''      Boolean
''' </returns>
''' <remarks>
'''      (c) ETLA - PM-2025
''' </remarks>
Public Shared Function ModificaEstados(ByVal pClsEstados As ClsEstados) As Boolean
Dim mReturn As Boolean=True

Dim mStrSQL as String
Dim mDB As New SqlConnection
Dim mCMD As New SqlCommand

mCMD.Parameters.Clear()
mCMD.Parameters.AddWithValue("@pCod_Estado",pClsEstados.Cod_Estado)
mCMD.Parameters.AddWithValue("@pEstado",pClsEstados.Estado.Substring(0,IIf(Len(pClsEstados.Estado)> 15, 15,Len(pClsEstados.Estado))))


mStrSQL="UPDATE Estados SET "
mStrSQL+="Estado=@pEstado "
mStrSQL+="WHERE Cod_Estado=@pCod_Estado"


mDB.ConnectionString = My.Settings.Connection
mCMD.CommandText = mStrSQL
mDB.Open()
mCMD.Connection = mDB

Try
mCMD.ExecuteNonQuery()
Catch ex As Exception
Msgbox("ModificaEstados:"  + vbCrLf + "Erro ao Gravar!!!" + vbCrLf + ex.ToString)
mReturn = False
End Try

mDB.Close()

Return mReturn

End Function 


''' <summary>
'''      Function GravaEstados(ByVal pNovoEstados As ClsEstados) Método para Gravar a TABELA Estados
'''      Gerado em 23/01/2025 13:57:14
''' </summary>
''' <returns>
'''      Boolean
''' </returns>
''' <remarks>
'''      (c) ETLA - PM-2025
''' </remarks>
Public Shared Function GravaEstados(ByVal pNovoEstados As ClsEstados) As Boolean
Dim mReturn As Boolean=True

Dim mStrSQL as String
Dim mDB As New SqlConnection
Dim mCMD As New SqlCommand

mDB.ConnectionString = My.Settings.Connection
mCMD.Parameters.Clear()


mCMD.Parameters.AddWithValue("@pCod_Estado",pNovoEstados.Cod_Estado)
mCMD.Parameters.AddWithValue("@pEstado",pNovoEstados.Estado.Substring(0,IIf(Len(pNovoEstados.Estado)> 15, 15,Len(pNovoEstados.Estado))))
mCMD.Parameters.AddWithValue("@pFLG_Ativo",pNovoEstados.FLG_Ativo)


mStrSQL="INSERT INTO Estados "
mStrSQL+="("
mStrSQL+="Cod_Estado,"
mStrSQL+="Estado,"
mStrSQL+="FLG_Ativo "
mStrSQL+=") "
mStrSQL+="VALUES "
mStrSQL+="("
mStrSQL+="@pCod_Estado,"
mStrSQL+="@pEstado,"
mStrSQL+="1"
mStrSQL+=")"


mCMD.CommandText = mStrSQL
mDB.Open()
mCMD.Connection = mDB

Try
mCMD.ExecuteNonQuery()
'ClsEmpresas.GravaContador(enCont.Estados)'<<<<-------- Verificar se é  preciso...
Catch ex As Exception
Msgbox("GravaEstados:"  + vbCrLf + "Erro ao Gravar!!!" + vbCrLf + ex.ToString)
mReturn = False
End Try

mDB.Close()

Return mReturn

End Function 


''' <summary>
'''      Function ApagaEstados(ByVal pCod_Estado As Integer) Método para Apagar um Registo da Tabela Estados
'''      Gerado em 23/01/2025 13:57:14
''' </summary>
''' <returns>
'''      Boolean
''' </returns>
''' <remarks>
'''      (c) ETLA - PM-2025
''' </remarks>
Public Shared Function ApagaEstados(ByVal pCod_Estado As Integer) As Boolean
Dim mReturn As Boolean=True

Dim mStrSQL as String
Dim mDB As New SqlConnection
Dim mCMD As New SqlCommand

mCMD.Parameters.Clear()

mCMD.Parameters.AddWithValue("@pCod_Estado", pCod_Estado)


mStrSQL="UPDATE Estados SET "
mStrSQL+="FLG_Ativo=0 "
mStrSQL+="WHERE Cod_Estado=@pCod_Estado"


mDB.ConnectionString = My.Settings.Connection
mCMD.CommandText = mStrSQL
mDB.Open()
mCMD.Connection = mDB

Try
mCMD.ExecuteNonQuery()
Catch ex As Exception
Msgbox("ApagaEstados:"  + vbCrLf + "Erro ao Gravar!!!" + vbCrLf + ex.ToString)
mReturn = False
End Try

mDB.Close()

Return mReturn

End Function 
End Class



''' <summary>
'''      Classe EstadosComparer 
'''      Gerado em 23/01/2025 13:57:14
''' </summary>
''' <remarks>
'''      (c) ETLA - PM-2025
''' </remarks>
Public Class EstadosComparer 
Implements IEqualityComparer(Of clsEstados)

Public Function Equals1(ByVal x As clsEstados, ByVal y As clsEstados) As Boolean Implements IEqualityComparer(Of clsEstados).Equals

If x Is y Then Return True

If x Is Nothing OrElse y Is Nothing Then Return False

Return (x.Cod_Estado = y.Cod_Estado) ' AndAlso (x.Estado = y.Estado)
End Function

Public Function GetHashCode1(ByVal pCls As clsEstados) As Integer Implements IEqualityComparer(Of clsEstados).GetHashCode

If pCls Is Nothing Then Return 0

'Dim Hash_ClsEstados_Estado = pCls.Estado.GetHashCode()
Dim Hash_ClsEstados_Cod_Estado = pCls.Cod_Estado.GetHashCode()

Return Hash_ClsEstados_Cod_Estado 'Xor Hash_ClsEstados_Estado
End Function
End Class
