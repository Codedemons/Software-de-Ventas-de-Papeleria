'
' Created by SharpDevelop.
' User: Coderp
' Date: 15/03/2022
' Time: 13:26
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Public Partial Class FrmProductos
	
	Private ctrl As ClsTorumPaper		
	Private t As New Data.DataTable
	Private v As New Data.DataView
	Dim Consulta As String = "	SELECT * FROM v_productos_modif;"
	
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
		Me.dGVProductos.DataSource =Me.v.ToTable
		
	end Sub	
	#End Region
	
	Sub FrmProductosLoad(sender As Object, e As EventArgs)
		CargarDatos()
		'muestra los datos en el combo box
		Me.consultaTipo
		Me.consultaTipoBusqueda		
	End Sub
	
	
	Sub DGVProductosCellClick(sender As Object, e As DataGridViewCellEventArgs)	
		Dim i As Integer = dGVProductos.CurrentRow.Index		
		Dim buscarRegistro As String = "SELECT COUNT(*) FROM tipoproducto WHERE claveTipoProducto = '" & txtClave.Text & "' ;"
		txtClave.Text	= dGVProductos(0,i).Value.ToString
		cmbTipo.Text = dGVProductos(1,i).Value.ToString
		txtDescripcion.Text = dGVProductos(2,i).Value.ToString
		cmbMarca.Text = dGVProductos(3,i).Value.ToString
		txtPrecio.Text = dGVProductos(4,i).Value.ToString
		nUDSmin.Text = dGVProductos(5,i).Value.ToString
		nUDSmax.Text = dGVProductos(6,i).Value.ToString
		nUDdis.Text = dGVProductos(7,i).Value.ToString
		
	End Sub
	
	Private Sub consultaTipo()
		Dim consulta As String = "SELECT claveTipoProducto, descripcionTipoProducto FROM tipoproducto;"	
		Me.cmbTipo.DataSource = Me.ctrl.consultasSql(consulta)
		Me.cmbTipo.ValueMember = "claveTipoProducto"
		Me.cmbTipo.DisplayMember = "descripcionTipoProducto"
		Me.cmbTipo.SelectedValue = ""
	End Sub
	
	Private Sub consultaTipoBusqueda()
		Dim consulta As String = "SELECT claveTipoProducto, descripcionTipoProducto FROM tipoproducto;"
		
		Me.cmbBTipo.DataSource = Me.ctrl.consultasSql(consulta)
		Me.cmbBTipo.ValueMember = "claveTipoProducto"
		Me.cmbBTipo.DisplayMember = "descripcionTipoProducto"
		Me.cmbBTipo.SelectedValue = ""
	End Sub
	

	#Region "Buscadores"
	Sub CmbBMarcaSelectedIndexChanged(sender As Object, e As EventArgs)
		Me.v=New Data.DataView(t)
		Me.v.RowFilter="Marca like '%" & Me.cmbBMarca.Text & "%'"
		Me.dGVProductos.DataSource = Me.v.ToTable	
	End Sub
	Sub CmbBTipoSelectedIndexChanged(sender As Object, e As EventArgs)		
		Me.v=New Data.DataView(t)
		Me.v.RowFilter="Tipo like '%" & Me.cmbBTipo.text & "%'"
		Me.dGVProductos.DataSource = Me.v.ToTable
	End Sub
	Sub TxtClaveProductoTextChanged(sender As Object, e As EventArgs)
		Me.v=New Data.DataView(t)
		Me.v.RowFilter="Producto like '%" & Me.txtClaveProducto.text & "%'"
		Me.dGVProductos.DataSource = Me.v.ToTable
	End Sub	
	#End Region
	
	#Region "Rellenar Datos"
	Public Sub RellenarDatos()
		txtClave.Text = "Clave"
		txtDescripcion.Text = "Descripcion"
		cmbBTipo.Text = "Tipo"
		cmbBMarca.Text = "Marca"
		txtPrecio.Text = "Precio"
		nUDdis.Text = "1"
		nUDSmax.Text = "1"
		nUDSmin.Text = "1"
		cmbTipo.Text = ""
		cmbMarca.Text = ""
	end Sub 		
	#End Region
	
	Sub BtnRegistrarClick(sender As Object, e As EventArgs) 
		'insertarRegistro = 
		'envia y valida si el registro se realizo
		Dim cont As Integer = 0	
		Dim Vali As Integer = 0
		
		If (ctrl.Funcdatos(txtDescripcion)=True) Then
			cont +=1 	
		Else
			Vali +=1 	
			ErrorPDes.SetError(txtDescripcion,"Los Campos se encuentran Vacios")			
		End If
		
		If (ctrl.FuncdatosCmb(cmbTipo)=True) Then
			cont +=1 				
		Else
			Vali +=1 	
			ErrorTipo.SetError(cmbTipo,"Los Campos se encuentran Vacios")
		End If
		
		If (ctrl.FuncdatosCmb(cmbMarca)=True) Then
			cont +=1 				
		Else
			Vali +=1 
			ErrorMarca.SetError(cmbMarca,"Los Campos se encuentran Vacios")
		End If
		
		If (ctrl.Funcdatos(txtPrecio)=True) Then
			cont +=1
		Else
			Vali +=1 	
			ErrorPrecio.SetError(txtPrecio,"Los Campos se encuentran Vacios")				
		End If
		
		If (Vali <> 0) Then
			ctrl.MsgtxtV()'Manda un mensaje si los campos estan vacios
			Vali = 0
		End If
		
		If (Cont <> 0) Then
			cont = 0
			Dim buscarRegistro As String = "SELECT COUNT(*) FROM producto WHERE claveProducto = '" & txtClave.Text & "';"
			If ctrl.VExistencia(buscarRegistro) = 0 Then
					Dim insertarRegistro As String = "INSERT INTO producto (claveProducto, claveTipoProducto, 	descripcionProducto	, marcaProducto, precioProducto,stockMinimo,stockMaximo,stockDisponible) VALUES ('" & txtClave.Text & "','" & cmbTipo.SelectedValue.ToString & "','" & txtDescripcion.Text & "','" & cmbMarca.Text & "','" & txtPrecio.Text & "','" & nUDSmin.Text & "','" & nUDSmax.Text & "','" & nUDdis.Text & "');"
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
		'insertarRegistro = 
		'envia y valida si el registro se realizo
		Dim cont As Integer = 0	
		Dim Vali As Integer = 0
		
		If (ctrl.Funcdatos(txtDescripcion)=True) Then
			cont +=1 	
		Else
			Vali +=1 	
			ErrorPDes.SetError(txtDescripcion,"Los Campos se encuentran Vacios")			
		End If
		
		If (ctrl.FuncdatosCmb(cmbTipo)=True) Then
			cont +=1 				
		Else
			Vali +=1 	
			ErrorTipo.SetError(cmbTipo,"Los Campos se encuentran Vacios")
		End If
		
		If (ctrl.FuncdatosCmb(cmbMarca)=True) Then
			cont +=1 				
		Else
			Vali +=1 
			ErrorMarca.SetError(cmbMarca,"Los Campos se encuentran Vacios")
		End If
		
		If (ctrl.Funcdatos(txtPrecio)=True) Then
			cont +=1
		Else
			Vali +=1 	
			ErrorPrecio.SetError(txtPrecio,"Los Campos se encuentran Vacios")			
		End If
		
		If (Vali <> 0) Then
			ctrl.MsgtxtV()'Manda un mensaje si los campos estan vacios
			Vali = 0
		End If
		
		If (Cont <> 0) Then
			cont = 0
			Dim buscarRegistro As String = "SELECT COUNT(*) FROM producto WHERE claveProducto = '" & txtClave.Text & "';"
			If ctrl.VExistencia(buscarRegistro) = 0 Then							
				ctrl.MsgRepit()'Manda un mensaje si los campos se repiten en la base de datos
				ErrorPClave.SetError(txtClave,"Los Campos se encuentran Repetidos")
				RellenarDatos()
			Else				
				Dim ModificarRegistro As String = "UPDATE producto SET claveTipoProducto = '" & cmbTipo.SelectedValue.ToString & "', descripcionProducto = '" & txtDescripcion.Text & "', marcaProducto = '" & cmbMarca.Text & "', precioProducto = '" & txtPrecio.Text & "', stockMinimo = '" & nUDSmin.Text & "', stockMaximo = '" & nUDSmax.Text & "', stockDisponible = '" & nUDdis.Text & "' WHERE claveProducto = '" & txtClave.Text & "';"
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
		'insertarRegistro = 
		'envia y valida si el registro se realizo
		Dim cont As Integer = 0	
		Dim Vali As Integer = 0
		
		If (ctrl.Funcdatos(txtDescripcion)=True) Then
			cont +=1 	
		Else
			Vali +=1 	
			ErrorPDes.SetError(txtDescripcion,"Los Campos se encuentran Vacios")			
		End If
		
		If (ctrl.FuncdatosCmb(cmbTipo)=True) Then
			cont +=1 				
		Else
			Vali +=1 	
			ErrorTipo.SetError(cmbTipo,"Los Campos se encuentran Vacios")
		End If
		
		If (ctrl.FuncdatosCmb(cmbMarca)=True) Then
			cont +=1 				
		Else
			Vali +=1 
			ErrorMarca.SetError(cmbMarca,"Los Campos se encuentran Vacios")
		End If
		
		If (ctrl.Funcdatos(txtPrecio)=True) Then
			cont +=1
		Else
			Vali +=1 	
			ErrorPrecio.SetError(txtPrecio,"Los Campos se encuentran Vacios")			
		End If
		
		If (Vali <> 0) Then
			ctrl.MsgtxtV()'Manda un mensaje si los campos estan vacios
			Vali = 0
		End If
		
		If (Cont <> 0) Then
			cont = 0
			Dim buscarRegistro As String = "SELECT COUNT(*) FROM producto WHERE claveProducto = '" & txtClave.Text & "';"
			If ctrl.VExistencia(buscarRegistro) = 0 Then							
				ctrl.MsgRepit()'Manda un mensaje si los campos se repiten en la base de datos
				ErrorPClave.SetError(txtClave,"Los Campos se encuentran Repetidos")
				RellenarDatos()
			Else			
				Dim EliminarRegistro As String = "DELETE FROM producto WHERE claveProducto = '" & txtClave.Text & "';"
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
	Sub TxtDescripcionClick(sender As Object, e As EventArgs)
		ctrl.Funciontxt(txtDescripcion,lblDes)
		ErrorPDes.Clear()
	End Sub
		
	Sub TxtPrecioClick(sender As Object, e As EventArgs)
		ctrl.Funciontxt(txtPrecio,lblPrecio)
		ErrorPrecio.Clear()
	End Sub
		
	Sub CmbTipoClick(sender As Object, e As EventArgs)
		ctrl.Funcioncmb(cmbTipo,lblTipo)
		ErrorTipo.Clear()
	End Sub
	
	Sub CmbMarcaClick(sender As Object, e As EventArgs)
		ctrl.Funcioncmb(cmbMarca,lblMarca)
		ErrorMarca.Clear()
	End Sub
	
	Sub CmbBMarcaClick(sender As Object, e As EventArgs)
		ctrl.Funcioncmb(cmbBMarca,lblBMarca)
	End Sub
	
	Sub CmbBTipoClick(sender As Object, e As EventArgs)
		ctrl.Funcioncmb(cmbBTipo,lblBTipo)
	End Sub
	
	Sub TxtClaveProductoClick(sender As Object, e As EventArgs)
		ctrl.Funciontxt(txtClaveProducto,lblBClave)
	End Sub
	#End Region
	
	
	
	Sub TxtClaveProductoKeyPress(sender As Object, e As KeyPressEventArgs)
		If Char.IsDigit(e.KeyChar) Then
          e.Handled = False
	     ElseIf Char.IsControl(e.KeyChar) Then
	      e.Handled = False
	     Else
          e.Handled = True
     	End If		
	End Sub
	
	Sub TxtPrecioKeyPress(sender As Object, e As KeyPressEventArgs)
		If Char.IsDigit(e.KeyChar) Then
          e.Handled = False
	     ElseIf Char.IsControl(e.KeyChar) Then
	      e.Handled = False
	     Else
          e.Handled = True
     	End If		
	End Sub
	
	Sub CmbTipoSelectedIndexChanged(sender As Object, e As EventArgs)
		
	End Sub
	
	
End Class
