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
	
	Public Sub New()
		' The Me.InitializeComponent call is required for Windows Forms designer support.
		Me.InitializeComponent()
		
		
		Me.ctrl = New ClsTorumPaper
		'
		' TODO : Add constructor code after InitializeComponents
		'
	End Sub
	
	
	Sub FrmProductosLoad(sender As Object, e As EventArgs)
		
		Dim consultaString As String = "select * from producto;"
		Dim ctrl As New ClsTorumPaper
		Me.t=ctrl.traerDatos(consultaString)
		Me.v=New Data.DataView(t)
		Me.dGVProductos.DataSource =Me.v.ToTable
		
		'muestra los datos en el combo box
		Me.consultaTipo
		Me.consultaTipoBusqueda
		
		
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
		Me.cmbBTipo.DisplayMember = "claveTipoProducto"
		Me.cmbBTipo.SelectedValue = ""
	End Sub
	


	Sub CmbBMarcaSelectedIndexChanged(sender As Object, e As EventArgs)
		
		Me.v=New Data.DataView(t)
		Me.v.RowFilter=" marcaProducto like '%" & Me.cmbBMarca.Text & "%'"
		Me.dGVProductos.DataSource = Me.v.ToTable

	
	End Sub
	
	Sub CmbBTipoSelectedIndexChanged(sender As Object, e As EventArgs)
		
		Me.v=New Data.DataView(t)
		Me.v.RowFilter=" claveTipoProducto like '%" & Me.cmbBTipo.text & "%'"
		Me.dGVProductos.DataSource = Me.v.ToTable

	End Sub
	

	Sub BtnRegistrarClick(sender As Object, e As EventArgs)
		
		Dim insertarRegistro As String 
		insertarRegistro = "INSERT INTO producto (claveProducto, claveTipoProducto, descripcionProducto, marcaProducto, precioProducto, stockMinimo, stockMaximo, stockDisponible) VALUES ('" & Me.txtClave.Text & "','" & Me.cmbTipo.SelectedValue & "','" & Me.txtDescripcion.Text & "','" & Me.cmbMarca.Text & "','" & textBox1.Text & "','" & nUDSmin.Text & "','" & nUDSmax.Text & "','" & nUDdis.Text & "')"
		'envia y valida si el registro se realizo
		If Me.ctrl.insertarRegistro(insertarRegistro) Then
				MsgBox("Se realizó el registro")
			End If
	End Sub
	

	
	Sub TxtClaveProductoTextChanged(sender As Object, e As EventArgs)
		Me.v=New Data.DataView(t)
		Me.v.RowFilter=" claveProducto like '%" & Me.txtClaveProducto.text & "%'"
		Me.dGVProductos.DataSource = Me.v.ToTable
	End Sub
	
	Sub BtnActualizarClick(sender As Object, e As EventArgs)
		
		Dim consultaString As String = "select * from producto;"
		Dim ctrl As New ClsTorumPaper
		Me.t=ctrl.traerDatos(consultaString)
		Me.v=New Data.DataView(t)
		Me.dGVProductos.DataSource =Me.v.ToTable
	End Sub
End Class
