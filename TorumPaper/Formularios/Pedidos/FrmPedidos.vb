'
' Created by SharpDevelop.
' User: Coderp
' Date: 15/03/2022
' Time: 13:25
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Public Partial Class FrmPedidos
	
	Private ctrl As ClsTorumPaper
	
	Private t As New Data.DataTable
	Private v As New Data.DataView
	
	Public Sub New()
		' The Me.InitializeComponent call is required for Windows Forms designer support.
		Me.InitializeComponent()
		Me.ctrl = New ClsTorumPaper
		
		'
		' TODO : Add constructor code after InitializeComponents
		'
	End Sub
	
	
	
	Sub FrmPedidosLoad(sender As Object, e As EventArgs)
		
		Dim consultaString As String = "select * from pedido;"
		Dim ctrl As New ClsTorumPaper
		Me.t=ctrl.traerDatos(consultaString)
		Me.v=New Data.DataView(t)
		Me.dGVPedidos.DataSource =Me.v.ToTable
		
		'cargar los datos de los combobox
		'Me.consultaTipo
		Me.consultaProveedor
		Me.consultaProducto
		
	End Sub
	
	
	
	Sub BtnRegistrarClick(sender As Object, e As EventArgs)
		
		Dim formatoFechaHora As String =  Format(Me.dTpFecha.Value, "yyyy-MM-dd ")  
		
		Dim clave As String = Me.txtClave.Text
		Dim claveProveedor As String= Me.cmBCProvedor.SelectedValue.ToString
		Dim claveProducto As String = Me.cmbProductos.SelectedValue.ToString
		
		Dim marca As String = Me.cmBMarca.Text
		Dim cantidad As String = Me.nUDCantidadPedido.Text
		Dim precio As String = Me.txtPrecio.Text

		
		Dim insertarRegistro As String = "INSERT INTO pedido (clavePedido, claveProducto, rfcProveedor,cantidadPedido, precioPedido, fechaPedido) VALUES ('" & clave & "','" & claveProducto & "','" & claveProveedor & "','" & cantidad & "','" & precio & "','" & formatoFechaHora & "');"
		'envia y valida si el registro se realizo
		If Me.ctrl.insertarRegistro(insertarRegistro) Then
				MsgBox("Se realizó el registro")
			End If
	
	End Sub
	
	'Private Sub consultaTipo()
		'Dim consulta As String = "SELECT claveTipoProducto, descripcionTipoProducto FROM tipoproducto;"
		
		'Me.cmBTipoProducto.DataSource = Me.ctrl.consultasSql(consulta)
		'Me.cmBTipoProducto.ValueMember = "claveTipoProducto"
		'Me.cmBTipoProducto.DisplayMember = "descripcionTipoProducto"
		'Me.cmBTipoProducto.SelectedValue = ""
	'End Sub

	
	Private Sub consultaProveedor()
		Dim consulta As String = "SELECT rfcProveedor, nombreProveedor FROM proveedor;"
		
		Me.cmBCProvedor.DataSource = Me.ctrl.consultasSql(consulta)
		Me.cmBCProvedor.ValueMember = "rfcProveedor"
		Me.cmBCProvedor.DisplayMember = "nombreProveedor"
		Me.cmBCProvedor.SelectedValue = ""
	End Sub
	
	Private Sub consultaProducto()
		Dim consulta As String = "SELECT claveProducto, descripcionProducto FROM producto;"
		
		Me.cmbProductos.DataSource = Me.ctrl.consultasSql(consulta)
		Me.cmbProductos.ValueMember = "claveProducto"
		Me.cmbProductos.DisplayMember = "descripcionProducto"
		Me.cmbProductos.SelectedValue = ""
	End Sub

	
	Sub BtnActualizarClick(sender As Object, e As EventArgs)
		
		Dim consultaString As String = "select * from pedido;"
		Dim ctrl As New ClsTorumPaper
		Me.t=ctrl.traerDatos(consultaString)
		Me.v=New Data.DataView(t)
		Me.dGVPedidos.DataSource =Me.v.ToTable
		
	End Sub
	

	
	Sub TxtBClaveTextChanged(sender As Object, e As EventArgs)
		
		Me.v=New Data.DataView(t)
		Me.v.RowFilter="clavePedido like '%" & Me.txtBClave.Text & "%'"
		Me.dGVPedidos.DataSource = Me.v.ToTable		
		
	End Sub
End Class
