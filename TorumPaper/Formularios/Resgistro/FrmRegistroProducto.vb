﻿'
' Created by SharpDevelop.
' User: Gustavo
' Date: 19/02/2022
' Time: 01:50 p. m.
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Public Partial Class FrmRegistroProducto
	Private Ctrl As ClsAdicionalConfig		
	Public Sub New()
		' The Me.InitializeComponent call is required for Windows Forms designer support.
		Me.InitializeComponent()
		Ctrl = New ClsAdicionalConfig
		'
		' TODO : Add constructor code after InitializeComponents
		'
	End Sub
	
	

	
	Sub TxtClaveProductoClick(sender As Object, e As EventArgs)
		Ctrl.Modifictxt(txtClaveProducto)
	End Sub
	
	Sub TxtTipoClick(sender As Object, e As EventArgs)
		Ctrl.Modifictxt(txtTipo)
	End Sub
	
	Sub TxtMarcaClick(sender As Object, e As EventArgs)
		Ctrl.Modifictxt(txtMarca)
	End Sub
	
	Sub TxtDescripcionClick(sender As Object, e As EventArgs)
		Ctrl.Modifictxt(txtDescripcion)
	End Sub
	
	Sub TxtPrecioClick(sender As Object, e As EventArgs)
		Ctrl.Modifictxt(txtPrecio)
	End Sub
	
	Sub TxtSminClick(sender As Object, e As EventArgs)
		Ctrl.Modifictxt(txtSmin)
	End Sub
	
	Sub TxtSmaxClick(sender As Object, e As EventArgs)
		Ctrl.Modifictxt(txtSmax)
	End Sub
	
	Sub TxtSdispoClick(sender As Object, e As EventArgs)
		Ctrl.Modifictxt(txtSdispo)	
	End Sub
		
	Sub BtnLimpiarClick(sender As Object, e As EventArgs)
		txtClaveProducto.ForeColor = Color.LightGray
		txtClaveProducto.Text = "Clave"	
		txtTipo.ForeColor = Color.LightGray
		txtTipo.Text = "Tipo"
		txtMarca.ForeColor = Color.LightGray
		txtMarca.Text = "Marca"
		txtDescripcion.ForeColor = Color.LightGray
		txtDescripcion.Text = "Descripcion"	
		txtPrecio.ForeColor = Color.LightGray
		txtPrecio.Text = "Precio"
		txtSmin.ForeColor = Color.LightGray
		txtSmin.Text = "Stock Min"
		txtSmax.ForeColor = Color.LightGray
		txtSmax.Text = "Stock Max"
		txtSdispo.ForeColor = Color.LightGray
		txtSdispo.Text = "Stock Disponible"
		btnRegistrar.ForeColor = Color.LightGray
	End Sub
	
	
	Sub BtnRegistrarClick(sender As Object, e As EventArgs)
		
		If (Ctrl.txtVacio(txtClaveProducto)) And (Ctrl.txtVacio(txtTipo)) 		 And 
				(Ctrl.txtVacio(txtMarca)) 	 And (Ctrl.txtVacio(txtDescripcion)) And 
				(Ctrl.txtVacio(txtPrecio))   And (Ctrl.txtVacio(txtSmin))		 And
				(Ctrl.txtVacio(txtSmax))     And (Ctrl.txtVacio(txtSdispo)) Then
			MsgBox(txtClaveProducto.Text)
			Ctrl.Modificbtn(btnRegistrar)
		Else
			MsgBox("Debe Ingresar todos los datos de Forma Correcta")
		End If
	End Sub
End Class
