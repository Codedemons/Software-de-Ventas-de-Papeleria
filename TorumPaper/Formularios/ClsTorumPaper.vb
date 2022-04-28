'
' Created by SharpDevelop.
' User: Coderp
' Date: 09/03/2022
' Time: 19:49
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Imports MySql.Data.MySqlClient

Public Class ClsTorumPaper
	Private MysqlConector As MySqlConnection
	
	Public Sub New()
		MysqlConector = New MySqlConnection("server = localhost; database = torumpaper; uid = root; pwd = ''")
	End Sub
	
	
	
	Public Function insertarRegistro(insertarDato As String) As Boolean
		Try
			Dim sqlQuery As MySqlCommand
			sqlQuery = New MySqlCommand(insertarDato, MysqlConector)
			MysqlConector.Open()
			sqlQuery.ExecuteNonQuery
			MysqlConector.Close()
			Return True
		Catch e As Exception
			Return False
		End Try
		Return False
	End Function
	
	
	
	Public Function traerDatos (ConsultaString As String) As Data.DataTable
		
		Dim t As New Data.DataTable
		Dim cadCon As String="server=localhost;user id=root; password=; database=torumpaper; pooling=false"
		Dim conn As New MySql.Data.MySqlClient.MySqlConnection(cadCon)
		Dim da As New MySql.Data.MySqlClient.MySqlDataAdapter(ConsultaString, conn)
		conn.Open
		da.Fill(t)
		conn.Close
		
		Return t
	End Function
	
	
	
	Public Function consultasSql(consulta As String) As Data.DataTable
		
		Dim tablaQuery As New Data.DataTable
		Dim sqlQuery As MySqlDataAdapter
		sqlQuery = New MySqlDataAdapter(consulta, MysqlConector)
		MysqlConector.Open
		sqlQuery.Fill(tablaQuery)
		MysqlConector.Close
		Return tablaQuery
	End Function
End Class
