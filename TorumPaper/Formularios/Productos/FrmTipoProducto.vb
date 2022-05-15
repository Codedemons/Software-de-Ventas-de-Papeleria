'
' Created by SharpDevelop.
' User: Coderp
' Date: 15/03/2022
' Time: 13:27
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Public Partial Class FrmTipoProducto
	Private ctrl As ClsTorumPaper		
	Private t As New Data.DataTable
	Private v As New Data.DataView
	Dim Consulta As String = "	SELECT * FROM v_tipos_productos;"
	
	Public Sub New()
		' The Me.InitializeComponent call is required for Windows Forms designer support.
		Me.InitializeComponent()	
		Me.ctrl = New ClsTorumPaper
		
		'
		' TODO : Add constructor code after InitializeComponents
		'
	End Sub
	#Region "Cargar Datos"
	Public Sub CargarDatos()
		Dim consultaString As String = Consulta 
		Dim ctrl As New ClsTorumPaper
		Me.t=ctrl.traerDatos(consultaString)
		Me.v=New Data.DataView(t)
		Me.dGVTipProductos.DataSource =Me.v.ToTable
	end Sub	
	#End Region
	
	Sub FrmTipoProductoLoad(sender As Object, e As EventArgs)
		CargarDatos()
	End Sub

	Sub DGVTipProductosCellClick(sender As Object, e As DataGridViewCellEventArgs)
		Dim i As Integer = dGVTipProductos.CurrentRow.Index		
		txtClaveTipo.Text = dGVTipProductos(0,i).Value.ToString
		txtDescripcion.Text = dGVTipProductos(1,i).Value.ToString		
	End Sub
	
	
	#Region "Buscadores"
	Sub TextBclaveTextChanged(sender As Object, e As EventArgs)
		Me.v=New Data.DataView(t)
		Me.v.RowFilter="Clave like '%" & Me.textBclave.Text & "%'"
		Me.dGVTipProductos.DataSource = Me.v.ToTable					
	End Sub	
	
	Sub TxtBDesTextChanged(sender As Object, e As EventArgs)
		
		Me.v=New Data.DataView(t)
		Me.v.RowFilter="Descripcion like '%" & txtBDes.Text & "%'"
		Me.dGVTipProductos.DataSource = Me.v.ToTable	
		
	End Sub
	#End region
	
	#Region "Rellenar Datos"
	Public Sub RellenarDatos()
		txtClaveTipo.Text = "Clave"
		txtDescripcion.Text = "Descripcion"
	end Sub 		
	#End Region
	
	#Region "Botones Principales -Registrar - Modificar - Eliminar -"
	Sub BtnRegistrarClick(sender As Object, e As EventArgs)
		If(ctrl.Funcdatos(txtDescripcion)=True) Then
			Dim buscarRegistro As String = "SELECT COUNT(*) FROM tipoproducto WHERE claveTipoProducto = '" & txtClaveTipo.Text & "' OR descripcionTipoProducto = '" & txtDescripcion.Text & "';"
			If ctrl.VExistencia(buscarRegistro) = 0 Then
					Dim insertarRegistro As String = "INSERT INTO tipoproducto (claveTipoProducto, descripcionTipoProducto) VALUES ('" & txtClaveTipo.Text & "', '" & txtDescripcion.Text & "');"
					If ctrl.insertarRegistro(insertarRegistro) Then
						insertarRegistro = ""
						ctrl.MsgAcept()
						CargarDatos()
						RellenarDatos()
					End If		
			Else
				ctrl.MsgRepit()'Manda un mensaje si los campos se repiten en la base de datos
				ErrorP.SetError(txtDescripcion,"Los Campos se encuentran Repetidos")
				RellenarDatos()
			End If
		Else 
			ctrl.MsgtxtV()'Manda un mensaje si los campos estan vacios
			ErrorP.SetError(txtDescripcion,"Los Campos se encuentran Vacios")
		End If
	End Sub
	
	Sub BtnModificarClick(sender As Object, e As EventArgs)		
		'Guarda la sentencia en un string		
		If(ctrl.Funcdatos(txtDescripcion)=True) Then
			Dim buscarRegistro As String = "SELECT COUNT(*) FROM tipoproducto WHERE claveTipoProducto = '" & txtClaveTipo.Text & "' OR descripcionTipoProducto = '" & txtDescripcion.Text & "';"
			If ctrl.VExistencia(buscarRegistro) = 0 Then
				ctrl.MsgFalt()'Manda un mensaje si no existe en la base de datos		
				RellenarDatos()
				ErrorP.SetError(txtDescripcion,"Los datos no Existen")
			Else
				Dim ModificarRegistro As String = "UPDATE tipoproducto SET claveTipoProducto = '" & txtClaveTipo.Text & "', descripcionTipoProducto = '" & Me.txtDescripcion.text & "' WHERE claveTipoProducto = '" & txtClaveTipo.Text & "';"
					If ctrl.ModificarRegistro(ModificarRegistro) Then
						ModificarRegistro = ""
						ctrl.MsgAler()
						CargarDatos()
						RellenarDatos()
					End If		
			End If
		Else 
			ctrl.MsgtxtV()'Manda un mensaje si los campos estan vacios
			ErrorP.SetError(txtDescripcion,"Los Campos se encuentran Vacios")
		End If
	End Sub
	
	Sub BtnEliminarClick(sender As Object, e As EventArgs)
		'Guarda la sentencia en un string		
		If(ctrl.Funcdatos(txtDescripcion)=True) Then
			Dim buscarRegistro As String = "SELECT COUNT(*) FROM tipoproducto WHERE claveTipoProducto = '" & txtClaveTipo.Text & "' OR descripcionTipoProducto = '" & txtDescripcion.Text & "';"
			If ctrl.VExistencia(buscarRegistro) = 0 Then
				ctrl.MsgFalt()'Manda un mensaje si no existe en la base de datos		
				RellenarDatos()
				ErrorP.SetError(txtDescripcion,"Los datos no Existen")
			Else
				Dim EliminarRegistro As String = "DELETE FROM tipoproducto WHERE claveTipoProducto = '" & txtClaveTipo.Text & "';"
					If ctrl.EliminarRegistro(EliminarRegistro) Then
						EliminarRegistro = ""
						ctrl.MsgError()
						CargarDatos()
						RellenarDatos()
					End If		
			End If
		Else 
			ctrl.MsgtxtV()'Manda un mensaje si los campos estan vacios
			ErrorP.SetError(txtDescripcion,"Los Campos se encuentran Vacios")
		End If
	End Sub
	#End Region
	
	#Region "Eventos clik de la ventana"
	Sub TxtClaveTipoClick(sender As Object, e As EventArgs)	
		ctrl.Funciontxt(txtClaveTipo,lblClave)		
	End Sub
		
	Sub TxtDescripcionClick(sender As Object, e As EventArgs)
		ctrl.Funciontxt(txtDescripcion,lblDes)
		ErrorP.Clear()
	End Sub
	
	Sub TextBclaveClick(sender As Object, e As EventArgs)
		ctrl.Funciontxt(textBclave,lblBClave)
	End Sub
	
	Sub TxtBDesClick(sender As Object, e As EventArgs)
		ctrl.Funciontxt(txtBDes,lblBDes)
	End Sub
	#End Region

	
	Sub TextBclaveKeyPress(sender As Object, e As KeyPressEventArgs)
		If Char.IsDigit(e.KeyChar) Then
          e.Handled = False
	     ElseIf Char.IsControl(e.KeyChar) Then
	      e.Handled = False
	     Else
          e.Handled = True
     	End If		
	End Sub
End Class
