'
' Created by SharpDevelop.
' User: Coderp
' Date: 19/02/2022
' Time: 15:31
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Public Partial Class FrmEliminarPedidos
	Private Ctrl As ClsAdicionalConfig		
	Public Sub New()
		' The Me.InitializeComponent call is required for Windows Forms designer support.
		Me.InitializeComponent()
		Ctrl = New ClsAdicionalConfig
		'
		' TODO : Add constructor code after InitializeComponents
		'
	End Sub
	
	Sub TxtClavePedidoClick(sender As Object, e As EventArgs)
		Ctrl.Modifictxt(txtClavePedido)
	End Sub
	
	Sub TxtCantidadClick(sender As Object, e As EventArgs)
		Ctrl.Modifictxt(txtCantidad)
	End Sub
	
	Sub TxtFechaPedidaClick(sender As Object, e As EventArgs)
		Ctrl.Modifictxt(txtFechaPedida)
	End Sub
	
	Sub TxtHoraClick(sender As Object, e As EventArgs)
		Ctrl.Modifictxt(txtHora)
	End Sub
	
	Sub TxtPrecioProductoClick(sender As Object, e As EventArgs)
		Ctrl.Modifictxt(txtPrecioProducto)
	End Sub
	
	Sub BtnLimpiarClick(sender As Object, e As EventArgs)
		txtClavePedido.ForeColor = Color.LightGray
		txtClavePedido.Text = "Clave Pedido"
		txtCantidad.ForeColor = Color.LightGray
		txtCantidad.Text = "Cantidad"
		txtFechaPedida.ForeColor = Color.LightGray
		txtFechaPedida.Text = "Fecha Pedida"
		txtHora.ForeColor = Color.LightGray
		txtHora.Text = "Hora"
		txtPrecioProducto.ForeColor = Color.LightGray
		txtPrecioProducto.Text = "Precio Producto"
	End Sub
	
	Sub BtnEliminarClick(sender As Object, e As EventArgs)
		
	End Sub
End Class
