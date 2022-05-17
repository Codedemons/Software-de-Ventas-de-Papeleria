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
	Dim Consulta As String = "SELECT * FROM v_pedidos_modif;"
	
	
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
		Me.dGVPedidos.DataSource =Me.v.ToTable
	end Sub	
	#End Region
	
	Sub FrmPedidosLoad(sender As Object, e As EventArgs)	
		'cargar los datos de los combobox
		'Me.consultaTipo
		CargarDatos()
		Me.consultaProveedor
		Me.consultaProducto
	End Sub
	
	
	
	
	#Region "Rellenar Datos"
	Public Sub RellenarDatos()
		txtClave.Text = "Clave"
		txtPrecio.Text = "Precio"
		cmbProductos.Text = "Producto"
		cmBCProvedor.Text = "Proveedores"
		nUDCantidadPedido.Text = "1"
	end Sub 		
	#End Region
	
	
	
	Sub BtnRegistrarClick(sender As Object, e As EventArgs)
		
		'envia y valida si el registro se realizo
		
		Dim cont As Integer = 0	
		Dim Vali As Integer = 0
		
		If (ctrl.Funcdatos(txtPrecio)=True) Then
			cont +=1 	
		Else
			Vali +=1 	
			'ErrorPCorr.SetError(txtCorreo,"Los Campos se encuentran Vacios")
		End If
		
		If (ctrl.FuncdatosCmb(cmBCProvedor)=True) Then
			cont +=1 	
		Else
			Vali +=1 	
			'ErrorPTell.SetError(txtTelefono,"Los Campos se encuentran Vacios")
		End If
		
		
		If (ctrl.FuncdatosCmb(cmbProductos)=True) Then
			cont +=1 	
		Else
			Vali +=1 	
			'ErrorPTell.SetError(txtTelefono,"Los Campos se encuentran Vacios")
		End If
		
		If (Vali <> 0) Then
			ctrl.MsgtxtV()'Manda un mensaje si los campos estan vacios
			Vali = 0
		End If
		
		If (Cont <> 0) Then
			cont = 0
			Dim buscarRegistro As String = "SELECT COUNT(*) FROM pedido WHERE clavePedido = '" & txtClave.Text & "';"
			If ctrl.VExistencia(buscarRegistro) = 0 Then
				Dim formatoFechaHora As String =  Format(Me.dTpFecha.Value, "yyyy-MM-dd ")  	
				Dim insertarRegistro As String = "INSERT INTO pedido (clavePedido, claveProducto, rfcProveedor,cantidadPedido, precioPedido, fechaPedido) VALUES ('" & txtClave.Text & "','" & cmbProductos.SelectedValue.ToString & "','" & cmBCProvedor.SelectedValue.ToString & "','" & nUDCantidadPedido.Text & "','" & txtPrecio.Text & "','" & formatoFechaHora & "');"
					If ctrl.insertarRegistro(insertarRegistro) Then
						insertarRegistro = ""
						ctrl.MsgAcept()
						CargarDatos()
						RellenarDatos()
					End If		
			Else
				ctrl.MsgRepit()'Manda un mensaje si los campos se repiten en la base de datos
				ErrorPClave.SetError(txtClave,"Los Campos se encuentran Repetidos")
				RellenarDatos()
			End If
		End If
		
	End Sub
	
	
	Sub BtnEditarClick(sender As Object, e As EventArgs)
		
		
		'envia y valida si el registro se realizo
		
		Dim cont As Integer = 0	
		Dim Vali As Integer = 0
		
		If (ctrl.Funcdatos(txtPrecio)=True) Then
			cont +=1 	
		Else
			Vali +=1 	
			ErrorPPrec.SetError(txtPrecio,"Los Campos se encuentran Vacios")
		End If
		
		If (ctrl.FuncdatosCmb(cmBCProvedor)=True) Then
			cont +=1 	
		Else
			Vali +=1 	
			ErrorPProv.SetError(cmBCProvedor,"Los Campos se encuentran Vacios")
		End If
		
		
		If (ctrl.FuncdatosCmb(cmbProductos)=True) Then
			cont +=1 	
		Else
			Vali +=1 	
			ErrorPProduct.SetError(cmbProductos,"Los Campos se encuentran Vacios")
		End If
		
		If (Vali <> 0) Then
			ctrl.MsgtxtV()'Manda un mensaje si los campos estan vacios
			Vali = 0
		End If
		
		If (Cont <> 0) Then
			cont = 0
			Dim buscarRegistro As String = "SELECT COUNT(*) FROM pedido WHERE clavePedido = '" & txtClave.Text & "';"
			If ctrl.VExistencia(buscarRegistro) = 0 Then						
				ctrl.MsgRepit()'Manda un mensaje si los campos se repiten en la base de datos
				ErrorPClave.SetError(txtClave,"Los Campos se encuentran Repetidos")
				RellenarDatos()
			Else
				Dim formatoFechaHora As String =  Format(Me.dTpFecha.Value, "yyyy-MM-dd ")  								
				Dim ModificarRegistro As String = "UPDATE pedido SET  claveProducto = '" & cmbProductos.SelectedValue.ToString & "', rfcProveedor = '" & cmBCProvedor.SelectedValue.ToString & "', cantidadPedido = '" & nUDCantidadPedido.Text & "', precioPedido = '" & txtPrecio.Text & "', fechaPedido = '" & formatoFechaHora & "' WHERE clavePedido = '" & txtClave.Text & "';"
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
		'envia y valida si el registro se realizo		
		Dim cont As Integer = 0	
		Dim Vali As Integer = 0
		
		If (ctrl.Funcdatos(txtPrecio)=True) Then
			cont +=1 	
		Else
			Vali +=1 	
			ErrorPPrec.SetError(txtPrecio,"Los Campos se encuentran Vacios")
		End If
		
		If (ctrl.FuncdatosCmb(cmBCProvedor)=True) Then
			cont +=1 	
		Else
			Vali +=1 	
			ErrorPProv.SetError(cmBCProvedor,"Los Campos se encuentran Vacios")
		End If
		
		
		If (ctrl.FuncdatosCmb(cmbProductos)=True) Then
			cont +=1 	
		Else
			Vali +=1 	
			ErrorPProduct.SetError(cmbProductos,"Los Campos se encuentran Vacios")
		End If
		
		If (Vali <> 0) Then
			ctrl.MsgtxtV()'Manda un mensaje si los campos estan vacios
			Vali = 0
		End If
		
		If (Cont <> 0) Then
			cont = 0
			Dim buscarRegistro As String = "SELECT COUNT(*) FROM pedido WHERE clavePedido = '" & txtClave.Text & "';"
			If ctrl.VExistencia(buscarRegistro) = 0 Then						
				ctrl.MsgRepit()'Manda un mensaje si los campos se repiten en la base de datos
				ErrorPClave.SetError(txtClave,"Los Campos se encuentran Repetidos")
				RellenarDatos()
			Else
				Dim formatoFechaHora As String =  Format(Me.dTpFecha.Value, "yyyy-MM-dd ")  							
				Dim EliminarRegistro As String = "DELETE FROM pedido WHERE clavePedido = '" & txtClave.Text & "';"
					If ctrl.EliminarRegistro(EliminarRegistro) Then
						EliminarRegistro = ""
						ctrl.MsgError()
						CargarDatos()
						RellenarDatos()
					End If
			End If
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
	
	
	
	Sub DGVPedidosCellClick(sender As Object, e As DataGridViewCellEventArgs)
		Dim i As Integer = dGVPedidos.CurrentRow.Index		
		txtClave.Text	= dGVPedidos(0,i).Value.ToString
		cmbProductos.Text = dGVPedidos(1,i).Value.ToString
		cmBCProvedor.Text= dGVPedidos(2,i).Value.ToString
		nUDCantidadPedido.Text = dGVPedidos(3,i).Value.ToString
		txtPrecio.Text = dGVPedidos(4,i).Value.ToString
		dTpFecha.Text = dGVPedidos(5,i).Value.ToString		
	End Sub	
	
	#Region "Buscadores"
	Sub TxtBClaveTextChanged(sender As Object, e As EventArgs)
		
		Me.v=New Data.DataView(t)
		Me.v.RowFilter="Pedido like '%" & Me.txtBClave.Text & "%'"
		Me.dGVPedidos.DataSource = Me.v.ToTable		
		
	End Sub
	#End Region
	
	#Region "Eventos clik de la ventana"
	Sub CmBCProvedorClick(sender As Object, e As EventArgs)
		ctrl.Funcioncmb(cmBCProvedor,lblProveedores)
	End Sub
	
	
	Sub CmbProductosClick(sender As Object, e As EventArgs)
		ctrl.Funcioncmb(cmbProductos,lblProducto)
	End Sub
	
	Sub TxtPrecioClick(sender As Object, e As EventArgs)
		ctrl.Funciontxt(txtPrecio,lblPrecio)
	End Sub
	
	Sub TxtBClaveClick(sender As Object, e As EventArgs)
		ctrl.Funciontxt(txtBClave,lblBClave)
	End Sub
	#End Region
	
	
	Sub TxtPrecioKeyPress(sender As Object, e As KeyPressEventArgs)
		If Char.IsDigit(e.KeyChar) Then
   	      e.Handled = False
	     ElseIf Char.IsControl(e.KeyChar) Then
	      e.Handled = False
	     Else
          e.Handled = True
     	End If		
	End Sub
	
	Sub TxtBClaveKeyPress(sender As Object, e As KeyPressEventArgs)
		If Char.IsDigit(e.KeyChar) Then
   	      e.Handled = False
	     ElseIf Char.IsControl(e.KeyChar) Then
	      e.Handled = False
	     Else
          e.Handled = True
     	End If		
	End Sub
End Class
