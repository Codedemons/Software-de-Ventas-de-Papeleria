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
	
	Public Function ModificarRegistro(insertarDato As String) As Boolean
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
	
	Public Function EliminarRegistro(insertarDato As String) As Boolean
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
	
	
	
	Public Function VExistencia(buscarRegistro As String) As Integer
		Dim sqlQuery As MySqlCommand
		sqlQuery = New MySqlCommand(buscarRegistro, MysqlConector)			
		Dim resultadoConsulta As MySqlDataReader
		
		MysqlConector.Open
		resultadoConsulta = sqlQuery.ExecuteReader
		resultadoConsulta.Read
		Dim numeroRegistros As Integer = Convert.ToUInt16(resultadoConsulta.Item("COUNT(*)").ToString)
		resultadoConsulta.Close
		MysqlConector.Close			
		Return numeroRegistros
	End Function
	
	
	
	Public sub Funciontxt(txt As TextBox, lbl As Label)  
		txt.Text = ""
		lbl.Visible = True
	End Sub
	
	
	Public sub Funcioncmb(cmb As ComboBox, lbl As Label)  
		cmb.Text = ""
		lbl.Visible = True
	End Sub
	
	Public Function Funcdatos(txt As TextBox) As Boolean  
		Select txt.Text
			Case ""
				Return False	
			Case " "
				Return False	
			Case "Clave"
				Return False	
			Case "Descripcion"
				Return False	
			Case "RFC"
				Return False
			Case "Nombre"
				Return False
			Case "Correo"
				Return False
			Case "Telefono"
				Return False
			Case "Precio"
				Return False
			Case "Marca"
				Return False
			Case Else
				Return True
		End Select
	End Function
	
	Public Function FuncdatosCmb(cmb As ComboBox) As Boolean  
		Select cmb.Text
			Case ""
				Return False	
			Case " "
				Return False	
			Case "Clave"
				Return False	
			Case "Descripcion"
				Return False	
			Case "RFC"
				Return False
			Case "Nombre"
				Return False
			Case "Correo"
				Return False
			Case "Telefono"
				Return False
			Case "Precio"
				Return False
			Case "Marca"
				Return False
			Case "Producto"
				Return False
			Case "Proveedores"
				Return False				
			Case Else
				Return True
		End Select
	End Function
	
	Public sub MsgAcept()  
		MessageBox.Show("Se han aceptado insertado los datos De manera correcta","Datos Insertados",MessageBoxButtons.OK,MessageBoxIcon.Information)
	End sub
	
	Public sub MsgAler()  
		MessageBox.Show("Se han Actualizado los datos De manera correcta","Actualizar Datos",MessageBoxButtons.OK,MessageBoxIcon.Exclamation)
	End Sub
	
	Public sub MsgError()  
		MessageBox.Show("Se han Eliminado los datos De manera correcta","Eliminar Datos",MessageBoxButtons.OK,MessageBoxIcon.Error)
	End sub
	
	Public sub MsgtxtV()  
		MessageBox.Show("Los Campos se encuentran Vacios","Campos Vacios",MessageBoxButtons.OK,MessageBoxIcon.Exclamation)
	End Sub
	
	Public sub MsgRepit()  
		MessageBox.Show("Los Campos se encuentran Repetidos","Campos Existente",MessageBoxButtons.OK,MessageBoxIcon.Exclamation)
	End Sub
	
	Public sub MsgFalt()  
		MessageBox.Show("Los Campos no se encuentran en la base de datos","Campos No Existente",MessageBoxButtons.OK,MessageBoxIcon.Exclamation)
	End Sub
	
	Public sub MsgDError()  
		MessageBox.Show("Los Datos han sido erroneos","No Erroneos",MessageBoxButtons.OK,MessageBoxIcon.Exclamation)
	End Sub
	
End Class
