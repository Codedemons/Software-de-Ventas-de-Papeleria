'
' Created by SharpDevelop.
' User: Coderp
' Date: 15/03/2022
' Time: 13:25
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Partial Class FrmPedidos
	Inherits System.Windows.Forms.Form
	
	''' <summary>
	''' Designer variable used to keep track of non-visual components.
	''' </summary>
	Private components As System.ComponentModel.IContainer
	
	''' <summary>
	''' Disposes resources used by the form.
	''' </summary>
	''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
	Protected Overrides Sub Dispose(ByVal disposing As Boolean)
		If disposing Then
			If components IsNot Nothing Then
				components.Dispose()
			End If
		End If
		MyBase.Dispose(disposing)
	End Sub
	
	''' <summary>
	''' This method is required for Windows Forms designer support.
	''' Do not change the method contents inside the source code editor. The Forms designer might
	''' not be able to load this method if it was changed manually.
	''' </summary>
	Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPedidos))
		Dim dataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Dim dataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Dim dataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Dim dataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Me.lbltCantidad = New System.Windows.Forms.Label()
		Me.nUDCantidadPedido = New System.Windows.Forms.NumericUpDown()
		Me.cmBCProvedor = New System.Windows.Forms.ComboBox()
		Me.btnRegistrar = New System.Windows.Forms.Button()
		Me.txtPrecio = New System.Windows.Forms.TextBox()
		Me.txtClave = New System.Windows.Forms.TextBox()
		Me.lblTitulo = New System.Windows.Forms.Label()
		Me.btnEliminar = New System.Windows.Forms.Button()
		Me.lbltBuscar = New System.Windows.Forms.Label()
		Me.btnEditar = New System.Windows.Forms.Button()
		Me.dTPBFecha = New System.Windows.Forms.DateTimePicker()
		Me.dTpFecha = New System.Windows.Forms.DateTimePicker()
		Me.txtBClave = New System.Windows.Forms.TextBox()
		Me.dGVPedidos = New System.Windows.Forms.DataGridView()
		Me.lblProveedores = New System.Windows.Forms.Label()
		Me.lblFecha = New System.Windows.Forms.Label()
		Me.lblPrecio = New System.Windows.Forms.Label()
		Me.lblProducto = New System.Windows.Forms.Label()
		Me.lblBFecha = New System.Windows.Forms.Label()
		Me.lblBClave = New System.Windows.Forms.Label()
		Me.ErrorPClave = New System.Windows.Forms.ErrorProvider(Me.components)
		Me.ErrorPProv = New System.Windows.Forms.ErrorProvider(Me.components)
		Me.ErrorPProduct = New System.Windows.Forms.ErrorProvider(Me.components)
		Me.ErrorPPrec = New System.Windows.Forms.ErrorProvider(Me.components)
		Me.cmbProductos = New System.Windows.Forms.ComboBox()
		CType(Me.nUDCantidadPedido,System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.dGVPedidos,System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.ErrorPClave,System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.ErrorPProv,System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.ErrorPProduct,System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.ErrorPPrec,System.ComponentModel.ISupportInitialize).BeginInit
		Me.SuspendLayout
		'
		'lbltCantidad
		'
		Me.lbltCantidad.Font = New System.Drawing.Font("Agency FB", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic),System.Drawing.FontStyle))
		Me.lbltCantidad.ForeColor = System.Drawing.Color.White
		Me.lbltCantidad.Location = New System.Drawing.Point(354, 130)
		Me.lbltCantidad.Name = "lbltCantidad"
		Me.lbltCantidad.Size = New System.Drawing.Size(100, 30)
		Me.lbltCantidad.TabIndex = 87
		Me.lbltCantidad.Text = "Cantidad"
		'
		'nUDCantidadPedido
		'
		Me.nUDCantidadPedido.BackColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(104,Byte),Integer), CType(CType(130,Byte),Integer))
		Me.nUDCantidadPedido.Font = New System.Drawing.Font("Agency FB", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic),System.Drawing.FontStyle))
		Me.nUDCantidadPedido.ForeColor = System.Drawing.Color.White
		Me.nUDCantidadPedido.Location = New System.Drawing.Point(460, 128)
		Me.nUDCantidadPedido.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
		Me.nUDCantidadPedido.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
		Me.nUDCantidadPedido.Name = "nUDCantidadPedido"
		Me.nUDCantidadPedido.Size = New System.Drawing.Size(194, 33)
		Me.nUDCantidadPedido.TabIndex = 85
		Me.nUDCantidadPedido.Value = New Decimal(New Integer() {1, 0, 0, 0})
		'
		'cmBCProvedor
		'
		Me.cmBCProvedor.BackColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(104,Byte),Integer), CType(CType(130,Byte),Integer))
		Me.cmBCProvedor.Font = New System.Drawing.Font("Agency FB", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic),System.Drawing.FontStyle))
		Me.cmBCProvedor.ForeColor = System.Drawing.Color.Gainsboro
		Me.cmBCProvedor.FormattingEnabled = true
		Me.cmBCProvedor.Location = New System.Drawing.Point(41, 131)
		Me.cmBCProvedor.Name = "cmBCProvedor"
		Me.cmBCProvedor.Size = New System.Drawing.Size(287, 33)
		Me.cmBCProvedor.TabIndex = 81
		Me.cmBCProvedor.Text = "Proveedores"
		AddHandler Me.cmBCProvedor.Click, AddressOf Me.CmBCProvedorClick
		'
		'btnRegistrar
		'
		Me.btnRegistrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(104,Byte),Integer), CType(CType(130,Byte),Integer))
		Me.btnRegistrar.Font = New System.Drawing.Font("Agency FB", 18!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.btnRegistrar.ForeColor = System.Drawing.Color.White
		Me.btnRegistrar.Image = CType(resources.GetObject("btnRegistrar.Image"),System.Drawing.Image)
		Me.btnRegistrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.btnRegistrar.Location = New System.Drawing.Point(673, 69)
		Me.btnRegistrar.Name = "btnRegistrar"
		Me.btnRegistrar.Size = New System.Drawing.Size(172, 57)
		Me.btnRegistrar.TabIndex = 79
		Me.btnRegistrar.Text = "   Registrar"
		Me.btnRegistrar.UseVisualStyleBackColor = false
		AddHandler Me.btnRegistrar.Click, AddressOf Me.BtnRegistrarClick
		'
		'txtPrecio
		'
		Me.txtPrecio.BackColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(104,Byte),Integer), CType(CType(130,Byte),Integer))
		Me.txtPrecio.Font = New System.Drawing.Font("Agency FB", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic),System.Drawing.FontStyle))
		Me.txtPrecio.ForeColor = System.Drawing.Color.Gainsboro
		Me.txtPrecio.Location = New System.Drawing.Point(354, 199)
		Me.txtPrecio.Name = "txtPrecio"
		Me.txtPrecio.Size = New System.Drawing.Size(300, 33)
		Me.txtPrecio.TabIndex = 78
		Me.txtPrecio.Text = "Precio"
		AddHandler Me.txtPrecio.Click, AddressOf Me.TxtPrecioClick
		AddHandler Me.txtPrecio.KeyPress, AddressOf Me.TxtPrecioKeyPress
		'
		'txtClave
		'
		Me.txtClave.BackColor = System.Drawing.Color.White
		Me.txtClave.Enabled = false
		Me.txtClave.Font = New System.Drawing.Font("Agency FB", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic),System.Drawing.FontStyle))
		Me.txtClave.ForeColor = System.Drawing.Color.Gainsboro
		Me.txtClave.Location = New System.Drawing.Point(41, 73)
		Me.txtClave.Name = "txtClave"
		Me.txtClave.Size = New System.Drawing.Size(287, 33)
		Me.txtClave.TabIndex = 75
		Me.txtClave.Text = "Clave "
		'
		'lblTitulo
		'
		Me.lblTitulo.Dock = System.Windows.Forms.DockStyle.Top
		Me.lblTitulo.Font = New System.Drawing.Font("Agency FB", 22.75!, System.Drawing.FontStyle.Bold)
		Me.lblTitulo.ForeColor = System.Drawing.Color.White
		Me.lblTitulo.Location = New System.Drawing.Point(0, 0)
		Me.lblTitulo.Name = "lblTitulo"
		Me.lblTitulo.Size = New System.Drawing.Size(867, 69)
		Me.lblTitulo.TabIndex = 88
		Me.lblTitulo.Text = "Pedidos  TorumPaper"
		Me.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'btnEliminar
		'
		Me.btnEliminar.BackColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(104,Byte),Integer), CType(CType(130,Byte),Integer))
		Me.btnEliminar.Font = New System.Drawing.Font("Agency FB", 18!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.btnEliminar.ForeColor = System.Drawing.Color.White
		Me.btnEliminar.Image = CType(resources.GetObject("btnEliminar.Image"),System.Drawing.Image)
		Me.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.btnEliminar.Location = New System.Drawing.Point(673, 190)
		Me.btnEliminar.Name = "btnEliminar"
		Me.btnEliminar.Size = New System.Drawing.Size(172, 51)
		Me.btnEliminar.TabIndex = 90
		Me.btnEliminar.Text = "Eliminar"
		Me.btnEliminar.UseVisualStyleBackColor = false
		AddHandler Me.btnEliminar.Click, AddressOf Me.BtnEliminarClick
		'
		'lbltBuscar
		'
		Me.lbltBuscar.Font = New System.Drawing.Font("Agency FB", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic),System.Drawing.FontStyle))
		Me.lbltBuscar.ForeColor = System.Drawing.Color.White
		Me.lbltBuscar.Location = New System.Drawing.Point(41, 257)
		Me.lbltBuscar.Name = "lbltBuscar"
		Me.lbltBuscar.Size = New System.Drawing.Size(98, 37)
		Me.lbltBuscar.TabIndex = 92
		Me.lbltBuscar.Text = "Buscar"
		Me.lbltBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'btnEditar
		'
		Me.btnEditar.BackColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(104,Byte),Integer), CType(CType(130,Byte),Integer))
		Me.btnEditar.Font = New System.Drawing.Font("Agency FB", 18!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.btnEditar.ForeColor = System.Drawing.Color.White
		Me.btnEditar.Image = CType(resources.GetObject("btnEditar.Image"),System.Drawing.Image)
		Me.btnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.btnEditar.Location = New System.Drawing.Point(673, 132)
		Me.btnEditar.Name = "btnEditar"
		Me.btnEditar.Size = New System.Drawing.Size(172, 47)
		Me.btnEditar.TabIndex = 94
		Me.btnEditar.Text = "Editar"
		Me.btnEditar.UseVisualStyleBackColor = false
		AddHandler Me.btnEditar.Click, AddressOf Me.BtnEditarClick
		'
		'dTPBFecha
		'
		Me.dTPBFecha.CalendarFont = New System.Drawing.Font("Agency FB", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic),System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.dTPBFecha.Font = New System.Drawing.Font("Agency FB", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic),System.Drawing.FontStyle))
		Me.dTPBFecha.Location = New System.Drawing.Point(402, 260)
		Me.dTPBFecha.Name = "dTPBFecha"
		Me.dTPBFecha.Size = New System.Drawing.Size(252, 33)
		Me.dTPBFecha.TabIndex = 95
		'
		'dTpFecha
		'
		Me.dTpFecha.CalendarFont = New System.Drawing.Font("Agency FB", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic),System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.dTpFecha.Font = New System.Drawing.Font("Agency FB", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic),System.Drawing.FontStyle))
		Me.dTpFecha.Location = New System.Drawing.Point(41, 199)
		Me.dTpFecha.Name = "dTpFecha"
		Me.dTpFecha.Size = New System.Drawing.Size(287, 33)
		Me.dTpFecha.TabIndex = 96
		'
		'txtBClave
		'
		Me.txtBClave.BackColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(104,Byte),Integer), CType(CType(130,Byte),Integer))
		Me.txtBClave.Font = New System.Drawing.Font("Agency FB", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic),System.Drawing.FontStyle))
		Me.txtBClave.ForeColor = System.Drawing.Color.Gainsboro
		Me.txtBClave.Location = New System.Drawing.Point(107, 259)
		Me.txtBClave.Name = "txtBClave"
		Me.txtBClave.Size = New System.Drawing.Size(289, 33)
		Me.txtBClave.TabIndex = 101
		Me.txtBClave.Text = "Clave"
		AddHandler Me.txtBClave.Click, AddressOf Me.TxtBClaveClick
		AddHandler Me.txtBClave.TextChanged, AddressOf Me.TxtBClaveTextChanged
		AddHandler Me.txtBClave.KeyPress, AddressOf Me.TxtBClaveKeyPress
		'
		'dGVPedidos
		'
		Me.dGVPedidos.AllowUserToAddRows = false
		dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
		dataGridViewCellStyle1.BackColor = System.Drawing.Color.DimGray
		dataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!)
		dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
		dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Gray
		dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
		dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
		Me.dGVPedidos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1
		Me.dGVPedidos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
		Me.dGVPedidos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
		Me.dGVPedidos.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(104,Byte),Integer), CType(CType(130,Byte),Integer))
		Me.dGVPedidos.BorderStyle = System.Windows.Forms.BorderStyle.None
		dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
		dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Highlight
		dataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
		dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
		dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.DimGray
		dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
		Me.dGVPedidos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2
		Me.dGVPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
		dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Highlight
		dataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
		dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightSkyBlue
		dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
		dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
		Me.dGVPedidos.DefaultCellStyle = dataGridViewCellStyle3
		Me.dGVPedidos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
		Me.dGVPedidos.GridColor = System.Drawing.SystemColors.Control
		Me.dGVPedidos.Location = New System.Drawing.Point(38, 303)
		Me.dGVPedidos.Name = "dGVPedidos"
		dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
		dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.WindowFrame
		dataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
		dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
		dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
		dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
		dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
		Me.dGVPedidos.RowHeadersDefaultCellStyle = dataGridViewCellStyle4
		Me.dGVPedidos.RowHeadersVisible = false
		Me.dGVPedidos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
		Me.dGVPedidos.Size = New System.Drawing.Size(804, 147)
		Me.dGVPedidos.TabIndex = 117
		AddHandler Me.dGVPedidos.CellClick, AddressOf Me.DGVPedidosCellClick
		'
		'lblProveedores
		'
		Me.lblProveedores.Font = New System.Drawing.Font("Agency FB", 13.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic),System.Drawing.FontStyle))
		Me.lblProveedores.ForeColor = System.Drawing.Color.White
		Me.lblProveedores.Location = New System.Drawing.Point(38, 104)
		Me.lblProveedores.Name = "lblProveedores"
		Me.lblProveedores.Size = New System.Drawing.Size(98, 37)
		Me.lblProveedores.TabIndex = 119
		Me.lblProveedores.Text = "Proveedores"
		Me.lblProveedores.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.lblProveedores.Visible = false
		'
		'lblFecha
		'
		Me.lblFecha.Font = New System.Drawing.Font("Agency FB", 13.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic),System.Drawing.FontStyle))
		Me.lblFecha.ForeColor = System.Drawing.Color.White
		Me.lblFecha.Location = New System.Drawing.Point(41, 170)
		Me.lblFecha.Name = "lblFecha"
		Me.lblFecha.Size = New System.Drawing.Size(98, 37)
		Me.lblFecha.TabIndex = 120
		Me.lblFecha.Text = "Fecha"
		Me.lblFecha.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'lblPrecio
		'
		Me.lblPrecio.Font = New System.Drawing.Font("Agency FB", 13.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic),System.Drawing.FontStyle))
		Me.lblPrecio.ForeColor = System.Drawing.Color.White
		Me.lblPrecio.Location = New System.Drawing.Point(354, 172)
		Me.lblPrecio.Name = "lblPrecio"
		Me.lblPrecio.Size = New System.Drawing.Size(98, 37)
		Me.lblPrecio.TabIndex = 121
		Me.lblPrecio.Text = "Precio"
		Me.lblPrecio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.lblPrecio.Visible = false
		'
		'lblProducto
		'
		Me.lblProducto.Font = New System.Drawing.Font("Agency FB", 13.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic),System.Drawing.FontStyle))
		Me.lblProducto.ForeColor = System.Drawing.Color.White
		Me.lblProducto.Location = New System.Drawing.Point(350, 50)
		Me.lblProducto.Name = "lblProducto"
		Me.lblProducto.Size = New System.Drawing.Size(98, 37)
		Me.lblProducto.TabIndex = 122
		Me.lblProducto.Text = "Producto"
		Me.lblProducto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.lblProducto.Visible = false
		'
		'lblBFecha
		'
		Me.lblBFecha.Font = New System.Drawing.Font("Agency FB", 13.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic),System.Drawing.FontStyle))
		Me.lblBFecha.ForeColor = System.Drawing.Color.White
		Me.lblBFecha.Location = New System.Drawing.Point(398, 232)
		Me.lblBFecha.Name = "lblBFecha"
		Me.lblBFecha.Size = New System.Drawing.Size(98, 37)
		Me.lblBFecha.TabIndex = 124
		Me.lblBFecha.Text = "Fecha"
		Me.lblBFecha.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'lblBClave
		'
		Me.lblBClave.Font = New System.Drawing.Font("Agency FB", 13.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic),System.Drawing.FontStyle))
		Me.lblBClave.ForeColor = System.Drawing.Color.White
		Me.lblBClave.Location = New System.Drawing.Point(107, 231)
		Me.lblBClave.Name = "lblBClave"
		Me.lblBClave.Size = New System.Drawing.Size(98, 37)
		Me.lblBClave.TabIndex = 125
		Me.lblBClave.Text = "Clave"
		Me.lblBClave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.lblBClave.Visible = false
		'
		'ErrorPClave
		'
		Me.ErrorPClave.ContainerControl = Me
		'
		'ErrorPProv
		'
		Me.ErrorPProv.ContainerControl = Me
		'
		'ErrorPProduct
		'
		Me.ErrorPProduct.ContainerControl = Me
		'
		'ErrorPPrec
		'
		Me.ErrorPPrec.ContainerControl = Me
		'
		'cmbProductos
		'
		Me.cmbProductos.BackColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(104,Byte),Integer), CType(CType(130,Byte),Integer))
		Me.cmbProductos.Font = New System.Drawing.Font("Agency FB", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic),System.Drawing.FontStyle))
		Me.cmbProductos.ForeColor = System.Drawing.Color.Gainsboro
		Me.cmbProductos.FormattingEnabled = true
		Me.cmbProductos.Items.AddRange(New Object() {"Producto"})
		Me.cmbProductos.Location = New System.Drawing.Point(354, 77)
		Me.cmbProductos.Name = "cmbProductos"
		Me.cmbProductos.Size = New System.Drawing.Size(300, 33)
		Me.cmbProductos.TabIndex = 100
		Me.cmbProductos.Text = "Producto"
		AddHandler Me.cmbProductos.Click, AddressOf Me.CmbProductosClick
		'
		'FrmPedidos
		'
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(104,Byte),Integer), CType(CType(130,Byte),Integer))
		Me.ClientSize = New System.Drawing.Size(867, 465)
		Me.Controls.Add(Me.txtBClave)
		Me.Controls.Add(Me.lblBClave)
		Me.Controls.Add(Me.dTPBFecha)
		Me.Controls.Add(Me.txtPrecio)
		Me.Controls.Add(Me.lblBFecha)
		Me.Controls.Add(Me.lbltCantidad)
		Me.Controls.Add(Me.lblPrecio)
		Me.Controls.Add(Me.cmbProductos)
		Me.Controls.Add(Me.lblProducto)
		Me.Controls.Add(Me.dTpFecha)
		Me.Controls.Add(Me.lblFecha)
		Me.Controls.Add(Me.txtClave)
		Me.Controls.Add(Me.cmBCProvedor)
		Me.Controls.Add(Me.lblProveedores)
		Me.Controls.Add(Me.dGVPedidos)
		Me.Controls.Add(Me.btnEditar)
		Me.Controls.Add(Me.lbltBuscar)
		Me.Controls.Add(Me.btnEliminar)
		Me.Controls.Add(Me.lblTitulo)
		Me.Controls.Add(Me.nUDCantidadPedido)
		Me.Controls.Add(Me.btnRegistrar)
		Me.Name = "FrmPedidos"
		Me.Text = "FrmPedidos"
		AddHandler Load, AddressOf Me.FrmPedidosLoad
		CType(Me.nUDCantidadPedido,System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.dGVPedidos,System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.ErrorPClave,System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.ErrorPProv,System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.ErrorPProduct,System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.ErrorPPrec,System.ComponentModel.ISupportInitialize).EndInit
		Me.ResumeLayout(false)
		Me.PerformLayout
	End Sub
	Private ErrorPPrec As System.Windows.Forms.ErrorProvider
	Private ErrorPProduct As System.Windows.Forms.ErrorProvider
	Private ErrorPProv As System.Windows.Forms.ErrorProvider
	Private ErrorPClave As System.Windows.Forms.ErrorProvider
	Private lblBClave As System.Windows.Forms.Label
	Private lblBFecha As System.Windows.Forms.Label
	Private lblProducto As System.Windows.Forms.Label
	Private lblPrecio As System.Windows.Forms.Label
	Private lblFecha As System.Windows.Forms.Label
	Private lblProveedores As System.Windows.Forms.Label
	Private txtBClave As System.Windows.Forms.TextBox
	Private dTpFecha As System.Windows.Forms.DateTimePicker
	Private dTPBFecha As System.Windows.Forms.DateTimePicker
	Private btnEditar As System.Windows.Forms.Button
	Private lbltBuscar As System.Windows.Forms.Label
	Private btnEliminar As System.Windows.Forms.Button
	Private dGVPedidos As System.Windows.Forms.DataGridView
	Private lblTitulo As System.Windows.Forms.Label
	Private txtClave As System.Windows.Forms.TextBox
	Private txtPrecio As System.Windows.Forms.TextBox
	Private btnRegistrar As System.Windows.Forms.Button
	Private cmBCProvedor As System.Windows.Forms.ComboBox
	Private cmbProductos As System.Windows.Forms.ComboBox
	Private nUDCantidadPedido As System.Windows.Forms.NumericUpDown
	Private lbltCantidad As System.Windows.Forms.Label
	
End Class
