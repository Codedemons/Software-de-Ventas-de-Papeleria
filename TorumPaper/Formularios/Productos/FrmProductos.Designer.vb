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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmProductos))
		Dim dataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Me.lblStockDisponible = New System.Windows.Forms.Label()
		Me.lblStockMaximo = New System.Windows.Forms.Label()
		Me.lblStockMinimo = New System.Windows.Forms.Label()
		Me.nUDdis = New System.Windows.Forms.NumericUpDown()
		Me.nUDSmax = New System.Windows.Forms.NumericUpDown()
		Me.nUDSmin = New System.Windows.Forms.NumericUpDown()
		Me.cmbMarca = New System.Windows.Forms.ComboBox()
		Me.cmbTipo = New System.Windows.Forms.ComboBox()
		Me.txtDescripcion = New System.Windows.Forms.TextBox()
		Me.txtClaveProducto = New System.Windows.Forms.TextBox()
		Me.lblTitulo = New System.Windows.Forms.Label()
		Me.cmbBMarca = New System.Windows.Forms.ComboBox()
		Me.cmbBTipo = New System.Windows.Forms.ComboBox()
		Me.cmbBSmin = New System.Windows.Forms.ComboBox()
		Me.btnRegistrar = New System.Windows.Forms.Button()
		Me.btnLimpiar = New System.Windows.Forms.Button()
		Me.dGVProductos = New System.Windows.Forms.DataGridView()
		Me.btnEliminar = New System.Windows.Forms.Button()
		Me.btnActualizar = New System.Windows.Forms.Button()
		Me.lbltBuscar = New System.Windows.Forms.Label()
		Me.btnBuscar = New System.Windows.Forms.Button()
		Me.textBox1 = New System.Windows.Forms.TextBox()
		Me.txtClave = New System.Windows.Forms.TextBox()
		CType(Me.nUDdis,System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.nUDSmax,System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.nUDSmin,System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.dGVProductos,System.ComponentModel.ISupportInitialize).BeginInit
		Me.SuspendLayout
		'
		'lblStockDisponible
		'
		Me.lblStockDisponible.Font = New System.Drawing.Font("Agency FB", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic),System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.lblStockDisponible.ForeColor = System.Drawing.Color.White
		Me.lblStockDisponible.Location = New System.Drawing.Point(340, 147)
		Me.lblStockDisponible.Name = "lblStockDisponible"
		Me.lblStockDisponible.Size = New System.Drawing.Size(115, 30)
		Me.lblStockDisponible.TabIndex = 88
		Me.lblStockDisponible.Text = "Stock Disponible"
		'
		'lblStockMaximo
		'
		Me.lblStockMaximo.Font = New System.Drawing.Font("Agency FB", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic),System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.lblStockMaximo.ForeColor = System.Drawing.Color.White
		Me.lblStockMaximo.Location = New System.Drawing.Point(340, 187)
		Me.lblStockMaximo.Name = "lblStockMaximo"
		Me.lblStockMaximo.Size = New System.Drawing.Size(100, 30)
		Me.lblStockMaximo.TabIndex = 87
		Me.lblStockMaximo.Text = "Stock Máximo"
		'
		'lblStockMinimo
		'
		Me.lblStockMinimo.Font = New System.Drawing.Font("Agency FB", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic),System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.lblStockMinimo.ForeColor = System.Drawing.Color.White
		Me.lblStockMinimo.Location = New System.Drawing.Point(340, 111)
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
		Me.nUDdis.Location = New System.Drawing.Point(461, 147)
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
		Me.nUDSmax.Location = New System.Drawing.Point(461, 186)
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
		Me.nUDSmin.Location = New System.Drawing.Point(461, 111)
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
		Me.cmbMarca.Location = New System.Drawing.Point(37, 147)
		Me.cmbMarca.Name = "cmbMarca"
		Me.cmbMarca.Size = New System.Drawing.Size(297, 33)
		Me.cmbMarca.TabIndex = 82
		Me.cmbMarca.Text = "Marca"
		'
		'cmbTipo
		'
		Me.cmbTipo.BackColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(104,Byte),Integer), CType(CType(130,Byte),Integer))
		Me.cmbTipo.Font = New System.Drawing.Font("Agency FB", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic),System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.cmbTipo.ForeColor = System.Drawing.Color.LightGray
		Me.cmbTipo.FormattingEnabled = true
		Me.cmbTipo.Location = New System.Drawing.Point(37, 108)
		Me.cmbTipo.Name = "cmbTipo"
		Me.cmbTipo.Size = New System.Drawing.Size(297, 33)
		Me.cmbTipo.TabIndex = 81
		Me.cmbTipo.Text = "Tipo"
		'
		'txtDescripcion
		'
		Me.txtDescripcion.BackColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(104,Byte),Integer), CType(CType(130,Byte),Integer))
		Me.txtDescripcion.Font = New System.Drawing.Font("Agency FB", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic),System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.txtDescripcion.ForeColor = System.Drawing.Color.LightGray
		Me.txtDescripcion.Location = New System.Drawing.Point(340, 70)
		Me.txtDescripcion.Name = "txtDescripcion"
		Me.txtDescripcion.Size = New System.Drawing.Size(294, 33)
		Me.txtDescripcion.TabIndex = 77
		Me.txtDescripcion.Text = "Descripción"
		'
		'txtClaveProducto
		'
		Me.txtClaveProducto.BackColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(104,Byte),Integer), CType(CType(130,Byte),Integer))
		Me.txtClaveProducto.Font = New System.Drawing.Font("Agency FB", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic),System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.txtClaveProducto.ForeColor = System.Drawing.Color.LightGray
		Me.txtClaveProducto.Location = New System.Drawing.Point(117, 291)
		Me.txtClaveProducto.Name = "txtClaveProducto"
		Me.txtClaveProducto.Size = New System.Drawing.Size(517, 33)
		Me.txtClaveProducto.TabIndex = 76
		Me.txtClaveProducto.Text = "Buscar por clave"
		AddHandler Me.txtClaveProducto.TextChanged, AddressOf Me.TxtClaveProductoTextChanged
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
		Me.cmbBMarca.Location = New System.Drawing.Point(117, 245)
		Me.cmbBMarca.Name = "cmbBMarca"
		Me.cmbBMarca.Size = New System.Drawing.Size(160, 32)
		Me.cmbBMarca.TabIndex = 107
		Me.cmbBMarca.Text = "Marca"
		AddHandler Me.cmbBMarca.SelectedIndexChanged, AddressOf Me.CmbBMarcaSelectedIndexChanged
		'
		'cmbBTipo
		'
		Me.cmbBTipo.BackColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(104,Byte),Integer), CType(CType(130,Byte),Integer))
		Me.cmbBTipo.Font = New System.Drawing.Font("Agency FB", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.cmbBTipo.ForeColor = System.Drawing.Color.White
		Me.cmbBTipo.FormattingEnabled = true
		Me.cmbBTipo.Items.AddRange(New Object() {"Stock Mínimo", "Stock Disponible", "Stock Máximo"})
		Me.cmbBTipo.Location = New System.Drawing.Point(295, 246)
		Me.cmbBTipo.Name = "cmbBTipo"
		Me.cmbBTipo.Size = New System.Drawing.Size(160, 32)
		Me.cmbBTipo.TabIndex = 106
		Me.cmbBTipo.Text = "Tipo"
		AddHandler Me.cmbBTipo.SelectedIndexChanged, AddressOf Me.CmbBTipoSelectedIndexChanged
		'
		'cmbBSmin
		'
		Me.cmbBSmin.BackColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(104,Byte),Integer), CType(CType(130,Byte),Integer))
		Me.cmbBSmin.Font = New System.Drawing.Font("Agency FB", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.cmbBSmin.ForeColor = System.Drawing.Color.White
		Me.cmbBSmin.FormattingEnabled = true
		Me.cmbBSmin.Items.AddRange(New Object() {"Stock Mínimo", "Stock Disponible", "Stock Máximo"})
		Me.cmbBSmin.Location = New System.Drawing.Point(476, 246)
		Me.cmbBSmin.Name = "cmbBSmin"
		Me.cmbBSmin.Size = New System.Drawing.Size(160, 32)
		Me.cmbBSmin.TabIndex = 104
		Me.cmbBSmin.Text = "Stock Mínimo"
		'
		'btnRegistrar
		'
		Me.btnRegistrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(104,Byte),Integer), CType(CType(130,Byte),Integer))
		Me.btnRegistrar.Font = New System.Drawing.Font("Agency FB", 18!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.btnRegistrar.ForeColor = System.Drawing.Color.White
		Me.btnRegistrar.Image = CType(resources.GetObject("btnRegistrar.Image"),System.Drawing.Image)
		Me.btnRegistrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.btnRegistrar.Location = New System.Drawing.Point(654, 127)
		Me.btnRegistrar.Name = "btnRegistrar"
		Me.btnRegistrar.Size = New System.Drawing.Size(191, 50)
		Me.btnRegistrar.TabIndex = 95
		Me.btnRegistrar.Text = "   Registrar"
		Me.btnRegistrar.UseVisualStyleBackColor = false
		AddHandler Me.btnRegistrar.Click, AddressOf Me.BtnRegistrarClick
		'
		'btnLimpiar
		'
		Me.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(104,Byte),Integer), CType(CType(130,Byte),Integer))
		Me.btnLimpiar.Font = New System.Drawing.Font("Agency FB", 18!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.btnLimpiar.ForeColor = System.Drawing.Color.White
		Me.btnLimpiar.Image = CType(resources.GetObject("btnLimpiar.Image"),System.Drawing.Image)
		Me.btnLimpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.btnLimpiar.Location = New System.Drawing.Point(654, 72)
		Me.btnLimpiar.Name = "btnLimpiar"
		Me.btnLimpiar.Size = New System.Drawing.Size(191, 49)
		Me.btnLimpiar.TabIndex = 96
		Me.btnLimpiar.Text = "    LIMPIAR"
		Me.btnLimpiar.UseVisualStyleBackColor = false
		'
		'dGVProductos
		'
		Me.dGVProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
		Me.dGVProductos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
		Me.dGVProductos.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(104,Byte),Integer), CType(CType(130,Byte),Integer))
		Me.dGVProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
		dataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver
		dataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
		dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White
		dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
		dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
		Me.dGVProductos.DefaultCellStyle = dataGridViewCellStyle1
		Me.dGVProductos.Location = New System.Drawing.Point(30, 330)
		Me.dGVProductos.Name = "dGVProductos"
		Me.dGVProductos.Size = New System.Drawing.Size(606, 180)
		Me.dGVProductos.TabIndex = 98
		'
		'btnEliminar
		'
		Me.btnEliminar.BackColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(104,Byte),Integer), CType(CType(130,Byte),Integer))
		Me.btnEliminar.Font = New System.Drawing.Font("Agency FB", 18!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.btnEliminar.ForeColor = System.Drawing.Color.White
		Me.btnEliminar.Image = CType(resources.GetObject("btnEliminar.Image"),System.Drawing.Image)
		Me.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.btnEliminar.Location = New System.Drawing.Point(654, 393)
		Me.btnEliminar.Name = "btnEliminar"
		Me.btnEliminar.Size = New System.Drawing.Size(191, 51)
		Me.btnEliminar.TabIndex = 99
		Me.btnEliminar.Text = "Eliminar"
		Me.btnEliminar.UseVisualStyleBackColor = false
		'
		'btnActualizar
		'
		Me.btnActualizar.BackColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(104,Byte),Integer), CType(CType(130,Byte),Integer))
		Me.btnActualizar.Font = New System.Drawing.Font("Agency FB", 18!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.btnActualizar.ForeColor = System.Drawing.Color.White
		Me.btnActualizar.Image = CType(resources.GetObject("btnActualizar.Image"),System.Drawing.Image)
		Me.btnActualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.btnActualizar.Location = New System.Drawing.Point(654, 450)
		Me.btnActualizar.Name = "btnActualizar"
		Me.btnActualizar.Size = New System.Drawing.Size(191, 60)
		Me.btnActualizar.TabIndex = 100
		Me.btnActualizar.Text = "   Actualizar"
		Me.btnActualizar.UseVisualStyleBackColor = false
		AddHandler Me.btnActualizar.Click, AddressOf Me.BtnActualizarClick
		'
		'lbltBuscar
		'
		Me.lbltBuscar.Font = New System.Drawing.Font("Agency FB", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.lbltBuscar.ForeColor = System.Drawing.Color.White
		Me.lbltBuscar.Location = New System.Drawing.Point(29, 240)
		Me.lbltBuscar.Name = "lbltBuscar"
		Me.lbltBuscar.Size = New System.Drawing.Size(98, 37)
		Me.lbltBuscar.TabIndex = 101
		Me.lbltBuscar.Text = "Buscar"
		Me.lbltBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'btnBuscar
		'
		Me.btnBuscar.BackColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(104,Byte),Integer), CType(CType(130,Byte),Integer))
		Me.btnBuscar.Font = New System.Drawing.Font("Agency FB", 18!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.btnBuscar.ForeColor = System.Drawing.Color.White
		Me.btnBuscar.Image = CType(resources.GetObject("btnBuscar.Image"),System.Drawing.Image)
		Me.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.btnBuscar.Location = New System.Drawing.Point(654, 330)
		Me.btnBuscar.Name = "btnBuscar"
		Me.btnBuscar.Size = New System.Drawing.Size(191, 57)
		Me.btnBuscar.TabIndex = 103
		Me.btnBuscar.Text = "  Editar"
		Me.btnBuscar.UseVisualStyleBackColor = false
		'
		'textBox1
		'
		Me.textBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(104,Byte),Integer), CType(CType(130,Byte),Integer))
		Me.textBox1.Font = New System.Drawing.Font("Agency FB", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic),System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.textBox1.ForeColor = System.Drawing.Color.LightGray
		Me.textBox1.Location = New System.Drawing.Point(37, 184)
		Me.textBox1.Name = "textBox1"
		Me.textBox1.Size = New System.Drawing.Size(297, 33)
		Me.textBox1.TabIndex = 108
		Me.textBox1.Text = "Precio"
		'
		'txtClave
		'
		Me.txtClave.BackColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(104,Byte),Integer), CType(CType(130,Byte),Integer))
		Me.txtClave.Font = New System.Drawing.Font("Agency FB", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic),System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.txtClave.ForeColor = System.Drawing.Color.LightGray
		Me.txtClave.Location = New System.Drawing.Point(37, 69)
		Me.txtClave.Name = "txtClave"
		Me.txtClave.Size = New System.Drawing.Size(294, 33)
		Me.txtClave.TabIndex = 109
		Me.txtClave.Text = "clave"
		'
		'FrmProductos
		'
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(104,Byte),Integer), CType(CType(130,Byte),Integer))
		Me.ClientSize = New System.Drawing.Size(857, 522)
		Me.Controls.Add(Me.txtClave)
		Me.Controls.Add(Me.textBox1)
		Me.Controls.Add(Me.cmbBMarca)
		Me.Controls.Add(Me.cmbBTipo)
		Me.Controls.Add(Me.cmbBSmin)
		Me.Controls.Add(Me.btnBuscar)
		Me.Controls.Add(Me.lbltBuscar)
		Me.Controls.Add(Me.btnActualizar)
		Me.Controls.Add(Me.btnEliminar)
		Me.Controls.Add(Me.dGVProductos)
		Me.Controls.Add(Me.btnLimpiar)
		Me.Controls.Add(Me.btnRegistrar)
		Me.Controls.Add(Me.lblTitulo)
		Me.Controls.Add(Me.lblStockDisponible)
		Me.Controls.Add(Me.lblStockMaximo)
		Me.Controls.Add(Me.lblStockMinimo)
		Me.Controls.Add(Me.nUDdis)
		Me.Controls.Add(Me.nUDSmax)
		Me.Controls.Add(Me.nUDSmin)
		Me.Controls.Add(Me.cmbMarca)
		Me.Controls.Add(Me.cmbTipo)
		Me.Controls.Add(Me.txtDescripcion)
		Me.Controls.Add(Me.txtClaveProducto)
		Me.Name = "FrmProductos"
		Me.Text = "FrmProductos"
		AddHandler Load, AddressOf Me.FrmProductosLoad
		CType(Me.nUDdis,System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.nUDSmax,System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.nUDSmin,System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.dGVProductos,System.ComponentModel.ISupportInitialize).EndInit
		Me.ResumeLayout(false)
		Me.PerformLayout
	End Sub
	Private textBox1 As System.Windows.Forms.TextBox
	Private cmbBSmin As System.Windows.Forms.ComboBox
	Private cmbBTipo As System.Windows.Forms.ComboBox
	Private cmbBMarca As System.Windows.Forms.ComboBox
	Private dGVProductos As System.Windows.Forms.DataGridView
	Private btnEliminar As System.Windows.Forms.Button
	Private btnActualizar As System.Windows.Forms.Button
	Private lbltBuscar As System.Windows.Forms.Label
	Private btnBuscar As System.Windows.Forms.Button
	Private lblTitulo As System.Windows.Forms.Label
	Private txtClaveProducto As System.Windows.Forms.TextBox
	Private txtDescripcion As System.Windows.Forms.TextBox
	Private txtClave As System.Windows.Forms.TextBox
	Private btnRegistrar As System.Windows.Forms.Button
	Private btnLimpiar As System.Windows.Forms.Button
	Private cmbTipo As System.Windows.Forms.ComboBox
	Private cmbMarca As System.Windows.Forms.ComboBox
	Private nUDSmin As System.Windows.Forms.NumericUpDown
	Private nUDSmax As System.Windows.Forms.NumericUpDown
	Private nUDdis As System.Windows.Forms.NumericUpDown
	Private lblStockMinimo As System.Windows.Forms.Label
	Private lblStockMaximo As System.Windows.Forms.Label
	Private lblStockDisponible As System.Windows.Forms.Label
	
	
End Class
