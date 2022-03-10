'
' Created by SharpDevelop.
' User: Coderp
' Date: 19/02/2022
' Time: 15:30
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Public Partial Class FrmEliminarProductos
	Private Ctrl As ClsAdicionalConfig	
	Public Sub New()
		' The Me.InitializeComponent call is required for Windows Forms designer support.
		Me.InitializeComponent()
		Ctrl = New ClsAdicionalConfig
		'
		' TODO : Add constructor code after InitializeComponents
		'
	End Sub
	
	
	
	
	Sub FrmEliminarProductosClick(sender As Object, e As EventArgs)

	End Sub
	
	Sub TxtClaveClick(sender As Object, e As EventArgs)
		Ctrl.Modifictxt(txtClaveProducto)
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
	End Sub
	
	
	Sub BtnEliminarClick(sender As Object, e As EventArgs)
		
	End Sub
End Class
