'
' Created by SharpDevelop.
' User: Coderp
' Date: 15/03/2022
' Time: 13:28
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Public Partial Class FrmProveedores
	
	Private ctrl As ClsTorumPaper	
	Private t As New Data.DataTable
	Private v As New Data.DataView
	Dim Consulta As String = "SELECT * FROM v_proveedor;"
	
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
		Me.dGVProveedores.DataSource =Me.v.ToTable
	end Sub	
	#End Region
	
	Sub FrmProveedoresLoad(sender As Object, e As EventArgs)
		CargarDatos()
	End Sub
	
	#Region "Rellenar Datos"
	Public Sub RellenarDatos()
		txtRfc.Text = "RFC"
		txtNombre.Text = "Nombre"	
		txtCorreo.Text = "Correo"
		txtTelefono.Text = "Telefono"	
	end Sub 		
	#End Region
	
	Sub DGVProveedoresCellClick(sender As Object, e As DataGridViewCellEventArgs)
		Dim i As Integer = dGVProveedores.CurrentRow.Index		
		txtRfc.Text = dGVProveedores(0,i).Value.ToString
		txtNombre.Text = dGVProveedores(1,i).Value.ToString
		txtCorreo.Text = dGVProveedores(2,i).Value.ToString
		txtTelefono.Text = dGVProveedores(3,i).Value.ToString
		nUDCalificacion.Text = dGVProveedores(4,i).Value.ToString
	End Sub
	
	
	
	#Region "Buscadores"
	Sub TextBoxFiltroNombreProveedorTextChanged(sender As Object, e As EventArgs)		
		Me.v=New Data.DataView(t)
		Me.v.RowFilter="Nombre like '%" & txtBuscarNombreProv.Text & "%'"
		Me.dGVProveedores.DataSource = Me.v.ToTable		
	End Sub
	
	Sub TxtBuscarRFCTextChanged(sender As Object, e As EventArgs)		
		Me.v=New Data.DataView(t)
		Me.v.RowFilter="RFC like '%" & txtBuscarRFC.Text & "%'"
		Me.dGVProveedores.DataSource = Me.v.ToTable
	End Sub	
	#End Region
	
	Sub BtnRegistrarClick(sender As Object, e As EventArgs)			
		Dim cont As Integer = 0	
		Dim Vali As Integer = 0
		If (ctrl.Funcdatos(txtRfc)=True) Then
			cont +=1 	
		Else
			Vali +=1 	
			ErrorPR.SetError(txtRfc,"Los Campos se encuentran Vacios")
		End If
		
		If (ctrl.Funcdatos(txtNombre)=True) Then
			cont +=1 	
		Else
			Vali +=1 	
			ErrorPNom.SetError(txtNombre,"Los Campos se encuentran Vacios")
		End If
		
		If (ctrl.Funcdatos(txtCorreo)=True) Then
			cont +=1 	
		Else
			Vali +=1 	
			ErrorPCorr.SetError(txtCorreo,"Los Campos se encuentran Vacios")
		End If
		
		If (ctrl.Funcdatos(txtTelefono)=True) Then
			cont +=1 	
		Else
			Vali +=1 	
			ErrorPTell.SetError(txtTelefono,"Los Campos se encuentran Vacios")
		End If
		
		If (Vali <> 0) Then
			ctrl.MsgtxtV()'Manda un mensaje si los campos estan vacios
			Vali = 0
		End If
		
		If (Cont <> 0) Then
			cont = 0
			Dim buscarRegistro As String = "SELECT COUNT(*) FROM proveedor WHERE rfcProveedor = '" & txtRfc.Text & "';"
			If ctrl.VExistencia(buscarRegistro) = 0 Then
					Dim insertarRegistro As String = "INSERT INTO proveedor (rfcProveedor, nombreProveedor, correoProveedor, telefonoProveedor, calificacionProveedor) VALUES ('" & Me.txtRfc.Text & "','" & Me.txtNombre.Text & "','" & Me.txtCorreo.Text & "','" & Me.txtTelefono.Text & "','" & Me.nUDCalificacion.Text & "');"
					If ctrl.insertarRegistro(insertarRegistro) Then
						insertarRegistro = ""
						ctrl.MsgAcept()
						CargarDatos()
						RellenarDatos()
					End If		
			Else
				ctrl.MsgRepit()'Manda un mensaje si los campos se repiten en la base de datos
				ErrorPR.SetError(txtRfc,"Los Campos se encuentran Repetidos")
				RellenarDatos()
			End If
		End If
		
	End Sub
	
	Sub BtnEditarClick(sender As Object, e As EventArgs)
		Dim cont As Integer = 0	
		Dim Vali As Integer = 0
		If (ctrl.Funcdatos(txtRfc)=True) Then
			cont +=1 	
		Else
			Vali +=1 	
			ErrorPR.SetError(txtRfc,"Los Campos se encuentran Vacios")
		End If
		
		If (ctrl.Funcdatos(txtNombre)=True) Then
			cont +=1 	
		Else
			Vali +=1 	
			ErrorPNom.SetError(txtNombre,"Los Campos se encuentran Vacios")
		End If
		
		If (ctrl.Funcdatos(txtCorreo)=True) Then
			cont +=1 	
		Else
			Vali +=1 	
			ErrorPCorr.SetError(txtCorreo,"Los Campos se encuentran Vacios")
		End If
		
		If (ctrl.Funcdatos(txtTelefono)=True) Then
			cont +=1 	
		Else
			Vali +=1 	
			ErrorPTell.SetError(txtTelefono,"Los Campos se encuentran Vacios")
		End If
		
		If (Vali <> 0) Then
			ctrl.MsgtxtV()'Manda un mensaje si los campos estan vacios
			Vali = 0
		End If
		
		If (Cont <> 0) Then
			cont = 0
			Dim buscarRegistro As String = "SELECT COUNT(*) FROM proveedor WHERE rfcProveedor = '" & txtRfc.Text & "';"
			If ctrl.VExistencia(buscarRegistro) = 0 Then
				ctrl.MsgRepit()'Manda un mensaje si los campos se repiten en la base de datos
				ErrorPR.SetError(txtRfc,"Los Campos se encuentran Repetidos")
				RellenarDatos()	
			Else				
				Dim ModificarRegistro As String = "UPDATE proveedor SET nombreProveedor = '" & txtNombre.Text & "', correoProveedor = '" & txtCorreo.Text & "', telefonoProveedor = '" & txtTelefono.Text & "', calificacionProveedor = '" & nUDCalificacion.Text & "' WHERE rfcProveedor = '" & txtRfc.Text & "';"
					If ctrl.ModificarRegistro(ModificarRegistro) Then
						ModificarRegistro = ""
						ctrl.MsgAler()
						CargarDatos()
						RellenarDatos()
					End If		
			End If
		End If		
	End Sub
	
	Sub BtnEliminarClick(sender As Object, e As EventArgs)
		Dim cont As Integer = 0	
		Dim Vali As Integer = 0
		If (ctrl.Funcdatos(txtRfc)=True) Then
			cont +=1 	
		Else
			Vali +=1 	
			ErrorPR.SetError(txtRfc,"Los Campos se encuentran Vacios")
		End If
		
		If (ctrl.Funcdatos(txtNombre)=True) Then
			cont +=1 	
		Else
			Vali +=1 	
			ErrorPNom.SetError(txtNombre,"Los Campos se encuentran Vacios")
		End If
		
		If (ctrl.Funcdatos(txtCorreo)=True) Then
			cont +=1 	
		Else
			Vali +=1 	
			ErrorPCorr.SetError(txtCorreo,"Los Campos se encuentran Vacios")
		End If
		
		If (ctrl.Funcdatos(txtTelefono)=True) Then
			cont +=1 	
		Else
			Vali +=1 	
			ErrorPTell.SetError(txtTelefono,"Los Campos se encuentran Vacios")
		End If
		
		If (Vali <> 0) Then
			ctrl.MsgtxtV()'Manda un mensaje si los campos estan vacios
			Vali = 0
		End If
		
		If (Cont <> 0) Then
			cont = 0
			Dim buscarRegistro As String = "SELECT COUNT(*) FROM proveedor WHERE rfcProveedor = '" & txtRfc.Text & "';"
			If ctrl.VExistencia(buscarRegistro) = 0 Then
				ctrl.MsgRepit()'Manda un mensaje si los campos se repiten en la base de datos
				ErrorPR.SetError(txtRfc,"Los Campos se encuentran Repetidos")
				RellenarDatos()	
			Else	  
				Dim EliminarRegistro As String = "DELETE FROM proveedor WHERE rfcProveedor = '" & txtRfc.Text & "';"
					If ctrl.EliminarRegistro(EliminarRegistro) Then
						EliminarRegistro = ""
						ctrl.MsgError()
						CargarDatos()
						RellenarDatos()
					End If		
			End If
		End If		
	End Sub
	
	
	#Region "Eventos clik de la ventana"
	Sub TxtRfcClick(sender As Object, e As EventArgs)
		ctrl.Funciontxt(txtRfc,lblRFC)
		ErrorPR.Clear()
	End Sub
	
	Sub TxtNombreClick(sender As Object, e As EventArgs)
		ctrl.Funciontxt(txtNombre,lblNombre)
		ErrorPNom.Clear()
	End Sub
	
	Sub TxtCorreoClick(sender As Object, e As EventArgs)
		ctrl.Funciontxt(txtCorreo,lblCorreo)
		ErrorPCorr.Clear()
	End Sub
	
	Sub TxtTelefonoClick(sender As Object, e As EventArgs)
		ctrl.Funciontxt(txtTelefono,lblTell)
		ErrorPTell.Clear()
	End Sub
	
	Sub TxtBuscarRFCClick(sender As Object, e As EventArgs)
		ctrl.Funciontxt(txtBuscarRFC,lblBRFC)
	End Sub
	
	Sub TxtBuscarNombreProvClick(sender As Object, e As EventArgs)
		ctrl.Funciontxt(txtBuscarNombreProv,lblBNombre)
	End Sub
	#End Region
	
	
	
	
	Sub TxtTelefonoKeyPress(sender As Object, e As KeyPressEventArgs)
		If Char.IsDigit(e.KeyChar) Then
          e.Handled = False
	     ElseIf Char.IsControl(e.KeyChar) Then
	      e.Handled = False
	     Else
          e.Handled = True
     	End If		
	End Sub
	
End Class
