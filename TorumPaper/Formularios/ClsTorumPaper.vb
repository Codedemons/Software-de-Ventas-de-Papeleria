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
	
End Class
