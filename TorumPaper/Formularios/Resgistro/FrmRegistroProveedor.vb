'
' Created by SharpDevelop.
' User: Gustavo
' Date: 19/02/2022
' Time: 06:46 p. m.
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Public Partial Class FrmRegistroProveedor
	Private Ctrl As ClsAdicionalConfig		
	Public Sub New()
		' The Me.InitializeComponent call is required for Windows Forms designer support.
		Me.InitializeComponent()
		Ctrl = New ClsAdicionalConfig
		'
		' TODO : Add constructor code after InitializeComponents
		'
	End Sub
	
	
	
	Sub TxtRfcClick(sender As Object, e As EventArgs)
		Ctrl.Modifictxt(txtRfc)
	End Sub
	
	Sub TxtNombreClick(sender As Object, e As EventArgs)
		Ctrl.Modifictxt(txtNombre)
	End Sub
	
	Sub TxtCorreoClick(sender As Object, e As EventArgs)
		Ctrl.Modifictxt(txtCorreo)
	End Sub
	
	Sub TxtTelefonoClick(sender As Object, e As EventArgs)
		Ctrl.Modifictxt(txtTelefono)
	End Sub
	
	Sub BtnLimpiarClick(sender As Object, e As EventArgs)
		txtRfc.ForeColor = Color.LightGray
		txtRfc.Text = "Rfc"
		txtNombre.ForeColor = Color.LightGray
		txtNombre.Text = "Nombre"
		txtCorreo.ForeColor = Color.LightGray
		txtCorreo.Text = "Correo"
		txtTelefono.ForeColor = Color.LightGray
		txtTelefono.Text = "Telefono"
	End Sub
	
	Sub BtnRegistrarClick(sender As Object, e As EventArgs)
		
	End Sub
End Class
