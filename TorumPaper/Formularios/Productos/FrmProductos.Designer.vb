'
' Created by SharpDevelop.
' User: Coderp
' Date: 15/03/2022
' Time: 13:26
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Partial Class FrmProductos
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmProductos))
		Dim dataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Dim dataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Dim dataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Dim dataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Me.lblStockDisponible = New System.Windows.Forms.Label()
		Me.lblStockMaximo = New System.Windows.Forms.Label()
		Me.lblStockMinimo = New System.Windows.Forms.Label()
		Me.nUDdis = New System.Windows.Forms.NumericUpDown()
		Me.nUDSmax = New System.Windows.Forms.NumericUpDown()
		Me.nUDSmin = New System.Windows.Forms.NumericUpDown()
		Me.cmbMarca = New System.Windows.Forms.ComboBox()
		Me.txtDescripcion = New System.Windows.Forms.TextBox()
		Me.txtClaveProducto = New System.Windows.Forms.TextBox()
		Me.lblTitulo = New System.Windows.Forms.Label()
		Me.cmbBMarca = New System.Windows.Forms.ComboBox()
		Me.cmbBTipo = New System.Windows.Forms.ComboBox()
		Me.btnRegistrar = New System.Windows.Forms.Button()
		Me.btnEliminar = New System.Windows.Forms.Button()
		Me.lbltBuscar = New System.Windows.Forms.Label()
		Me.btnEditar = New System.Windows.Forms.Button()
		Me.txtPrecio = New System.Windows.Forms.TextBox()
		Me.txtClave = New System.Windows.Forms.TextBox()
		Me.dGVProductos = New System.Windows.Forms.DataGridView()
		Me.cmbTipo = New System.Windows.Forms.ComboBox()
		Me.lblDes = New System.Windows.Forms.Label()
		Me.lblTipo = New System.Windows.Forms.Label()
		Me.lblMarca = New System.Windows.Forms.Label()
		Me.lblPrecio = New System.Windows.Forms.Label()
		Me.lblBMarca = New System.Windows.Forms.Label()
		Me.lblBTipo = New System.Windows.Forms.Label()
		Me.lblBClave = New System.Windows.Forms.Label()
		Me.ErrorPDes = New System.Windows.Forms.ErrorProvider(Me.components)
		Me.ErrorTipo = New System.Windows.Forms.ErrorProvider(Me.components)
		Me.ErrorMarca = New System.Windows.Forms.ErrorProvider(Me.components)
		Me.ErrorPrecio = New System.Windows.Forms.ErrorProvider(Me.components)
		Me.ErrorPClave = New System.Windows.Forms.ErrorProvider(Me.components)
		CType(Me.nUDdis,System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.nUDSmax,System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.nUDSmin,System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.dGVProductos,System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.ErrorPDes,System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.ErrorTipo,System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.ErrorMarca,System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.ErrorPrecio,System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.ErrorPClave,System.ComponentModel.ISupportInitialize).BeginInit
		Me.SuspendLayout
		'
		'lblStockDisponible
		'
		Me.lblStockDisponible.Font = New System.Drawing.Font("Agency FB", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic),System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.lblStockDisponible.ForeColor = System.Drawing.Color.White
		Me.lblStockDisponible.Location = New System.Drawing.Point(340, 163)
		Me.lblStockDisponible.Name = "lblStockDisponible"
		Me.lblStockDisponible.Size = New System.Drawing.Size(115, 30)
		Me.lblStockDisponible.TabIndex = 88
		Me.lblStockDisponible.Text = "Stock Disponible"
		'
		'lblStockMaximo
		'
		Me.lblStockMaximo.Font = New System.Drawing.Font("Agency FB", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic),System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.lblStockMaximo.ForeColor = System.Drawing.Color.White
		Me.lblStockMaximo.Location = New System.Drawing.Point(340, 203)
		Me.lblStockMaximo.Name = "lblStockMaximo"
		Me.lblStockMaximo.Size = New System.Drawing.Size(100, 30)
		Me.lblStockMaximo.TabIndex = 87
		Me.lblStockMaximo.Text = "Stock Máximo"
		'
		'lblStockMinimo
		'
		Me.lblStockMinimo.Font = New System.Drawing.Font("Agency FB", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic),System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.lblStockMinimo.ForeColor = System.Drawing.Color.White
		Me.lblStockMinimo.Location = New System.Drawing.Point(340, 127)
		Me.lblStockMinimo.Name = "lblStockMinimo"
		Me.lblStockMinimo.Size = New System.Drawing.Size(115, 30)
		Me.lblStockMinimo.TabIndex = 86
		Me.lblStockMinimo.Text = "Stock Mínimo"
		'
		'nUDdis
		'
		Me.nUDdis.BackColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(104,Byte),Integer), CType(CType(130,Byte),Integer))
		Me.nUDdis.Font = New System.Drawing.Font("Agency FB", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic),System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.nUDdis.ForeColor = System.Drawing.Color.White
		Me.nUDdis.Location = New System.Drawing.Point(461, 163)
		Me.nUDdis.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
		Me.nUDdis.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
		Me.nUDdis.Name = "nUDdis"
		Me.nUDdis.Size = New System.Drawing.Size(173, 30)
		Me.nUDdis.TabIndex = 85
		Me.nUDdis.Value = New Decimal(New Integer() {1, 0, 0, 0})
		'
		'nUDSmax
		'
		Me.nUDSmax.BackColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(104,Byte),Integer), CType(CType(130,Byte),Integer))
		Me.nUDSmax.Font = New System.Drawing.Font("Agency FB", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic),System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.nUDSmax.ForeColor = System.Drawing.Color.White
		Me.nUDSmax.Location = New System.Drawing.Point(461, 202)
		Me.nUDSmax.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
		Me.nUDSmax.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
		Me.nUDSmax.Name = "nUDSmax"
		Me.nUDSmax.Size = New System.Drawing.Size(173, 30)
		Me.nUDSmax.TabIndex = 84
		Me.nUDSmax.Value = New Decimal(New Integer() {1, 0, 0, 0})
		'
		'nUDSmin
		'
		Me.nUDSmin.BackColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(104,Byte),Integer), CType(CType(130,Byte),Integer))
		Me.nUDSmin.Font = New System.Drawing.Font("Agency FB", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic),System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.nUDSmin.ForeColor = System.Drawing.Color.White
		Me.nUDSmin.Location = New System.Drawing.Point(461, 127)
		Me.nUDSmin.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
		Me.nUDSmin.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
		Me.nUDSmin.Name = "nUDSmin"
		Me.nUDSmin.Size = New System.Drawing.Size(173, 30)
		Me.nUDSmin.TabIndex = 83
		Me.nUDSmin.Value = New Decimal(New Integer() {1, 0, 0, 0})
		'
		'cmbMarca
		'
		Me.cmbMarca.BackColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(104,Byte),Integer), CType(CType(130,Byte),Integer))
		Me.cmbMarca.Font = New System.Drawing.Font("Agency FB", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic),System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.cmbMarca.ForeColor = System.Drawing.Color.LightGray
		Me.cmbMarca.FormattingEnabled = true
		Me.cmbMarca.Items.AddRange(New Object() {"BIC", "AZOR", "CRAYOLA", "MAPITA", "HP", "APPLE"})
		Me.cmbMarca.Location = New System.Drawing.Point(36, 166)
		Me.cmbMarca.Name = "cmbMarca"
		Me.cmbMarca.Size = New System.Drawing.Size(297, 33)
		Me.cmbMarca.TabIndex = 82
		Me.cmbMarca.Text = "Marca"
		AddHandler Me.cmbMarca.Click, AddressOf Me.CmbMarcaClick
		'
		'txtDescripcion
		'
		Me.txtDescripcion.BackColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(104,Byte),Integer), CType(CType(130,Byte),Integer))
		Me.txtDescripcion.Font = New System.Drawing.Font("Agency FB", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic),System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.txtDescripcion.ForeColor = System.Drawing.Color.LightGray
		Me.txtDescripcion.Location = New System.Drawing.Point(340, 81)
		Me.txtDescripcion.Name = "txtDescripcion"
		Me.txtDescripcion.Size = New System.Drawing.Size(294, 33)
		Me.txtDescripcion.TabIndex = 77
		Me.txtDescripcion.Text = "Descripcion"
		AddHandler Me.txtDescripcion.Click, AddressOf Me.TxtDescripcionClick
		'
		'txtClaveProducto
		'
		Me.txtClaveProducto.BackColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(104,Byte),Integer), CType(CType(130,Byte),Integer))
		Me.txtClaveProducto.Font = New System.Drawing.Font("Agency FB", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic),System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.txtClaveProducto.ForeColor = System.Drawing.Color.LightGray
		Me.txtClaveProducto.Location = New System.Drawing.Point(117, 311)
		Me.txtClaveProducto.Name = "txtClaveProducto"
		Me.txtClaveProducto.Size = New System.Drawing.Size(517, 33)
		Me.txtClaveProducto.TabIndex = 76
		Me.txtClaveProducto.Text = "Clave"
		AddHandler Me.txtClaveProducto.Click, AddressOf Me.TxtClaveProductoClick
		AddHandler Me.txtClaveProducto.TextChanged, AddressOf Me.TxtClaveProductoTextChanged
		AddHandler Me.txtClaveProducto.KeyPress, AddressOf Me.TxtClaveProductoKeyPress
		'
		'lblTitulo
		'
		Me.lblTitulo.Dock = System.Windows.Forms.DockStyle.Top
		Me.lblTitulo.Font = New System.Drawing.Font("Agency FB", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.lblTitulo.ForeColor = System.Drawing.Color.White
		Me.lblTitulo.Location = New System.Drawing.Point(0, 0)
		Me.lblTitulo.Name = "lblTitulo"
		Me.lblTitulo.Size = New System.Drawing.Size(857, 69)
		Me.lblTitulo.TabIndex = 89
		Me.lblTitulo.Text = "Productos TorumPaper"
		Me.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'cmbBMarca
		'
		Me.cmbBMarca.BackColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(104,Byte),Integer), CType(CType(130,Byte),Integer))
		Me.cmbBMarca.Font = New System.Drawing.Font("Agency FB", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.cmbBMarca.ForeColor = System.Drawing.Color.White
		Me.cmbBMarca.FormattingEnabled = true
		Me.cmbBMarca.Items.AddRange(New Object() {"", "BIC", "AZOR", "CRAYOLA", "MAPITA", "hp"})
		Me.cmbBMarca.Location = New System.Drawing.Point(117, 264)
		Me.cmbBMarca.Name = "cmbBMarca"
		Me.cmbBMarca.Size = New System.Drawing.Size(214, 32)
		Me.cmbBMarca.TabIndex = 107
		Me.cmbBMarca.Text = "Marca"
		AddHandler Me.cmbBMarca.SelectedIndexChanged, AddressOf Me.CmbBMarcaSelectedIndexChanged
		AddHandler Me.cmbBMarca.Click, AddressOf Me.CmbBMarcaClick
		'
		'cmbBTipo
		'
		Me.cmbBTipo.BackColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(104,Byte),Integer), CType(CType(130,Byte),Integer))
		Me.cmbBTipo.Font = New System.Drawing.Font("Agency FB", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.cmbBTipo.ForeColor = System.Drawing.Color.White
		Me.cmbBTipo.FormattingEnabled = true
		Me.cmbBTipo.Items.AddRange(New Object() {"Stock Mínimo", "Stock Disponible", "Stock Máximo"})
		Me.cmbBTipo.Location = New System.Drawing.Point(340, 264)
		Me.cmbBTipo.Name = "cmbBTipo"
		Me.cmbBTipo.Size = New System.Drawing.Size(294, 32)
		Me.cmbBTipo.TabIndex = 106
		Me.cmbBTipo.Text = "Tipo"
		AddHandler Me.cmbBTipo.SelectedIndexChanged, AddressOf Me.CmbBTipoSelectedIndexChanged
		AddHandler Me.cmbBTipo.Click, AddressOf Me.CmbBTipoClick
		'
		'btnRegistrar
		'
		Me.btnRegistrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(104,Byte),Integer), CType(CType(130,Byte),Integer))
		Me.btnRegistrar.Font = New System.Drawing.Font("Agency FB", 18!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.btnRegistrar.ForeColor = System.Drawing.Color.White
		Me.btnRegistrar.Image = CType(resources.GetObject("btnRegistrar.Image"),System.Drawing.Image)
		Me.btnRegistrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.btnRegistrar.Location = New System.Drawing.Point(654, 69)
		Me.btnRegistrar.Name = "btnRegistrar"
		Me.btnRegistrar.Size = New System.Drawing.Size(191, 50)
		Me.btnRegistrar.TabIndex = 95
		Me.btnRegistrar.Text = "   Registrar"
		Me.btnRegistrar.UseVisualStyleBackColor = false
		AddHandler Me.btnRegistrar.Click, AddressOf Me.BtnRegistrarClick
		'
		'btnEliminar
		'
		Me.btnEliminar.BackColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(104,Byte),Integer), CType(CType(130,Byte),Integer))
		Me.btnEliminar.Font = New System.Drawing.Font("Agency FB", 18!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.btnEliminar.ForeColor = System.Drawing.Color.White
		Me.btnEliminar.Image = CType(resources.GetObject("btnEliminar.Image"),System.Drawing.Image)
		Me.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.btnEliminar.Location = New System.Drawing.Point(654, 193)
		Me.btnEliminar.Name = "btnEliminar"
		Me.btnEliminar.Size = New System.Drawing.Size(191, 51)
		Me.btnEliminar.TabIndex = 99
		Me.btnEliminar.Text = "Eliminar"
		Me.btnEliminar.UseVisualStyleBackColor = false
		AddHandler Me.btnEliminar.Click, AddressOf Me.BtnEliminarClick
		'
		'lbltBuscar
		'
		Me.lbltBuscar.Font = New System.Drawing.Font("Agency FB", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.lbltBuscar.ForeColor = System.Drawing.Color.White
		Me.lbltBuscar.Location = New System.Drawing.Point(29, 252)
		Me.lbltBuscar.Name = "lbltBuscar"
		Me.lbltBuscar.Size = New System.Drawing.Size(98, 37)
		Me.lbltBuscar.TabIndex = 101
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
		Me.btnEditar.Location = New System.Drawing.Point(654, 130)
		Me.btnEditar.Name = "btnEditar"
		Me.btnEditar.Size = New System.Drawing.Size(191, 57)
		Me.btnEditar.TabIndex = 103
		Me.btnEditar.Text = "  Editar"
		Me.btnEditar.UseVisualStyleBackColor = false
		AddHandler Me.btnEditar.Click, AddressOf Me.BtnEditarClick
		'
		'txtPrecio
		'
		Me.txtPrecio.BackColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(104,Byte),Integer), CType(CType(130,Byte),Integer))
		Me.txtPrecio.Font = New System.Drawing.Font("Agency FB", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic),System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.txtPrecio.ForeColor = System.Drawing.Color.LightGray
		Me.txtPrecio.Location = New System.Drawing.Point(38, 214)
		Me.txtPrecio.Name = "txtPrecio"
		Me.txtPrecio.Size = New System.Drawing.Size(297, 33)
		Me.txtPrecio.TabIndex = 108
		Me.txtPrecio.Text = "Precio"
		AddHandler Me.txtPrecio.Click, AddressOf Me.TxtPrecioClick
		AddHandler Me.txtPrecio.KeyPress, AddressOf Me.TxtPrecioKeyPress
		'
		'txtClave
		'
		Me.txtClave.BackColor = System.Drawing.Color.White
		Me.txtClave.Enabled = false
		Me.txtClave.Font = New System.Drawing.Font("Agency FB", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic),System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.txtClave.ForeColor = System.Drawing.Color.LightGray
		Me.txtClave.Location = New System.Drawing.Point(37, 69)
		Me.txtClave.Name = "txtClave"
		Me.txtClave.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
		Me.txtClave.Size = New System.Drawing.Size(294, 33)
		Me.txtClave.TabIndex = 109
		Me.txtClave.Text = "Clave"
		'
		'dGVProductos
		'
		Me.dGVProductos.AllowUserToAddRows = false
		dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
		dataGridViewCellStyle1.BackColor = System.Drawing.Color.DimGray
		dataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!)
		dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
		dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Gray
		dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
		dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
		Me.dGVProductos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1
		Me.dGVProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
		Me.dGVProductos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
		Me.dGVProductos.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(104,Byte),Integer), CType(CType(130,Byte),Integer))
		Me.dGVProductos.BorderStyle = System.Windows.Forms.BorderStyle.None
		dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
		dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Highlight
		dataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
		dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
		dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.DimGray
		dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
		Me.dGVProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2
		Me.dGVProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
		dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Highlight
		dataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
		dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightSkyBlue
		dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
		dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
		Me.dGVProductos.DefaultCellStyle = dataGridViewCellStyle3
		Me.dGVProductos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
		Me.dGVProductos.GridColor = System.Drawing.SystemColors.Control
		Me.dGVProductos.Location = New System.Drawing.Point(29, 353)
		Me.dGVProductos.Name = "dGVProductos"
		dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
		dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.WindowFrame
		dataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
		dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
		dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
		dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
		dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
		Me.dGVProductos.RowHeadersDefaultCellStyle = dataGridViewCellStyle4
		Me.dGVProductos.RowHeadersVisible = false
		Me.dGVProductos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
		Me.dGVProductos.Size = New System.Drawing.Size(804, 155)
		Me.dGVProductos.TabIndex = 116
		AddHandler Me.dGVProductos.CellClick, AddressOf Me.DGVProductosCellClick
		'
		'cmbTipo
		'
		Me.cmbTipo.BackColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(104,Byte),Integer), CType(CType(130,Byte),Integer))
		Me.cmbTipo.Font = New System.Drawing.Font("Agency FB", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic),System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.cmbTipo.ForeColor = System.Drawing.Color.LightGray
		Me.cmbTipo.FormattingEnabled = true
		Me.cmbTipo.Items.AddRange(New Object() {"BIC", "AZOR", "CRAYOLA", "MAPITA", "HP", "APPLE"})
		Me.cmbTipo.Location = New System.Drawing.Point(38, 117)
		Me.cmbTipo.Name = "cmbTipo"
		Me.cmbTipo.Size = New System.Drawing.Size(297, 33)
		Me.cmbTipo.TabIndex = 117
		Me.cmbTipo.Text = "Tipo"
		AddHandler Me.cmbTipo.SelectedIndexChanged, AddressOf Me.CmbTipoSelectedIndexChanged
		AddHandler Me.cmbTipo.Click, AddressOf Me.CmbTipoClick
		'
		'lblDes
		'
		Me.lblDes.Font = New System.Drawing.Font("Agency FB", 14.25!, System.Drawing.FontStyle.Bold)
		Me.lblDes.ForeColor = System.Drawing.Color.White
		Me.lblDes.Location = New System.Drawing.Point(336, 53)
		Me.lblDes.Name = "lblDes"
		Me.lblDes.Size = New System.Drawing.Size(98, 37)
		Me.lblDes.TabIndex = 120
		Me.lblDes.Text = "Descripcion"
		Me.lblDes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.lblDes.Visible = false
		'
		'lblTipo
		'
		Me.lblTipo.Font = New System.Drawing.Font("Agency FB", 12.25!, System.Drawing.FontStyle.Bold)
		Me.lblTipo.ForeColor = System.Drawing.Color.White
		Me.lblTipo.Location = New System.Drawing.Point(35, 91)
		Me.lblTipo.Name = "lblTipo"
		Me.lblTipo.Size = New System.Drawing.Size(98, 37)
		Me.lblTipo.TabIndex = 121
		Me.lblTipo.Text = "Tipo"
		Me.lblTipo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.lblTipo.Visible = false
		'
		'lblMarca
		'
		Me.lblMarca.Font = New System.Drawing.Font("Agency FB", 12.25!, System.Drawing.FontStyle.Bold)
		Me.lblMarca.ForeColor = System.Drawing.Color.White
		Me.lblMarca.Location = New System.Drawing.Point(35, 139)
		Me.lblMarca.Name = "lblMarca"
		Me.lblMarca.Size = New System.Drawing.Size(98, 37)
		Me.lblMarca.TabIndex = 122
		Me.lblMarca.Text = "Marca"
		Me.lblMarca.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.lblMarca.Visible = false
		'
		'lblPrecio
		'
		Me.lblPrecio.Font = New System.Drawing.Font("Agency FB", 12.25!, System.Drawing.FontStyle.Bold)
		Me.lblPrecio.ForeColor = System.Drawing.Color.White
		Me.lblPrecio.Location = New System.Drawing.Point(35, 188)
		Me.lblPrecio.Name = "lblPrecio"
		Me.lblPrecio.Size = New System.Drawing.Size(98, 37)
		Me.lblPrecio.TabIndex = 123
		Me.lblPrecio.Text = "Precio"
		Me.lblPrecio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.lblPrecio.Visible = false
		'
		'lblBMarca
		'
		Me.lblBMarca.Font = New System.Drawing.Font("Agency FB", 12.25!, System.Drawing.FontStyle.Bold)
		Me.lblBMarca.ForeColor = System.Drawing.Color.White
		Me.lblBMarca.Location = New System.Drawing.Point(114, 237)
		Me.lblBMarca.Name = "lblBMarca"
		Me.lblBMarca.Size = New System.Drawing.Size(98, 37)
		Me.lblBMarca.TabIndex = 124
		Me.lblBMarca.Text = "Marca"
		Me.lblBMarca.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.lblBMarca.Visible = false
		'
		'lblBTipo
		'
		Me.lblBTipo.Font = New System.Drawing.Font("Agency FB", 12.25!, System.Drawing.FontStyle.Bold)
		Me.lblBTipo.ForeColor = System.Drawing.Color.White
		Me.lblBTipo.Location = New System.Drawing.Point(337, 235)
		Me.lblBTipo.Name = "lblBTipo"
		Me.lblBTipo.Size = New System.Drawing.Size(98, 37)
		Me.lblBTipo.TabIndex = 125
		Me.lblBTipo.Text = "Tipo"
		Me.lblBTipo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.lblBTipo.Visible = false
		'
		'lblBClave
		'
		Me.lblBClave.Font = New System.Drawing.Font("Agency FB", 12.25!, System.Drawing.FontStyle.Bold)
		Me.lblBClave.ForeColor = System.Drawing.Color.White
		Me.lblBClave.Location = New System.Drawing.Point(114, 285)
		Me.lblBClave.Name = "lblBClave"
		Me.lblBClave.Size = New System.Drawing.Size(98, 37)
		Me.lblBClave.TabIndex = 126
		Me.lblBClave.Text = "Clave"
		Me.lblBClave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.lblBClave.Visible = false
		'
		'ErrorPDes
		'
		Me.ErrorPDes.ContainerControl = Me
		'
		'ErrorTipo
		'
		Me.ErrorTipo.ContainerControl = Me
		'
		'ErrorMarca
		'
		Me.ErrorMarca.ContainerControl = Me
		'
		'ErrorPrecio
		'
		Me.ErrorPrecio.ContainerControl = Me
		'
		'ErrorPClave
		'
		Me.ErrorPClave.ContainerControl = Me
		'
		'FrmProductos
		'
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(104,Byte),Integer), CType(CType(130,Byte),Integer))
		Me.ClientSize = New System.Drawing.Size(857, 522)
		Me.Controls.Add(Me.txtClaveProducto)
		Me.Controls.Add(Me.cmbBMarca)
		Me.Controls.Add(Me.lblBClave)
		Me.Controls.Add(Me.cmbBTipo)
		Me.Controls.Add(Me.lblBTipo)
		Me.Controls.Add(Me.txtPrecio)
		Me.Controls.Add(Me.lblBMarca)
		Me.Controls.Add(Me.cmbMarca)
		Me.Controls.Add(Me.lblPrecio)
		Me.Controls.Add(Me.cmbTipo)
		Me.Controls.Add(Me.lblMarca)
		Me.Controls.Add(Me.txtClave)
		Me.Controls.Add(Me.lblTipo)
		Me.Controls.Add(Me.txtDescripcion)
		Me.Controls.Add(Me.lblDes)
		Me.Controls.Add(Me.dGVProductos)
		Me.Controls.Add(Me.btnEditar)
		Me.Controls.Add(Me.lbltBuscar)
		Me.Controls.Add(Me.btnEliminar)
		Me.Controls.Add(Me.btnRegistrar)
		Me.Controls.Add(Me.lblTitulo)
		Me.Controls.Add(Me.lblStockDisponible)
		Me.Controls.Add(Me.lblStockMaximo)
		Me.Controls.Add(Me.lblStockMinimo)
		Me.Controls.Add(Me.nUDdis)
		Me.Controls.Add(Me.nUDSmax)
		Me.Controls.Add(Me.nUDSmin)
		Me.Name = "FrmProductos"
		Me.Text = "FrmProductos"
		AddHandler Load, AddressOf Me.FrmProductosLoad
		CType(Me.nUDdis,System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.nUDSmax,System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.nUDSmin,System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.dGVProductos,System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.ErrorPDes,System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.ErrorTipo,System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.ErrorMarca,System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.ErrorPrecio,System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.ErrorPClave,System.ComponentModel.ISupportInitialize).EndInit
		Me.ResumeLayout(false)
		Me.PerformLayout
	End Sub
	Private ErrorPClave As System.Windows.Forms.ErrorProvider
	Private ErrorPrecio As System.Windows.Forms.ErrorProvider
	Private ErrorMarca As System.Windows.Forms.ErrorProvider
	Private ErrorTipo As System.Windows.Forms.ErrorProvider
	Private ErrorPDes As System.Windows.Forms.ErrorProvider
	Private lblBClave As System.Windows.Forms.Label
	Private lblBTipo As System.Windows.Forms.Label
	Private lblBMarca As System.Windows.Forms.Label
	Private lblPrecio As System.Windows.Forms.Label
	Private lblMarca As System.Windows.Forms.Label
	Private lblTipo As System.Windows.Forms.Label
	Private lblDes As System.Windows.Forms.Label
	Private txtPrecio As System.Windows.Forms.TextBox
	Private cmbBTipo As System.Windows.Forms.ComboBox
	Private cmbBMarca As System.Windows.Forms.ComboBox
	Private dGVProductos As System.Windows.Forms.DataGridView
	Private btnEliminar As System.Windows.Forms.Button
	Private lbltBuscar As System.Windows.Forms.Label
	Private btnEditar As System.Windows.Forms.Button
	Private lblTitulo As System.Windows.Forms.Label
	Private txtClaveProducto As System.Windows.Forms.TextBox
	Private txtDescripcion As System.Windows.Forms.TextBox
	Private txtClave As System.Windows.Forms.TextBox
	Private btnRegistrar As System.Windows.Forms.Button
	Private cmbTipo As System.Windows.Forms.ComboBox
	Private cmbMarca As System.Windows.Forms.ComboBox
	Private nUDSmin As System.Windows.Forms.NumericUpDown
	Private nUDSmax As System.Windows.Forms.NumericUpDown
	Private nUDdis As System.Windows.Forms.NumericUpDown
	Private lblStockMinimo As System.Windows.Forms.Label
	Private lblStockMaximo As System.Windows.Forms.Label
	Private lblStockDisponible As System.Windows.Forms.Label
	
	
	
End Class
