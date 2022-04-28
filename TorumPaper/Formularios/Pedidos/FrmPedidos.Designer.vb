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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPedidos))
		Dim dataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Me.lbltCantidad = New System.Windows.Forms.Label()
		Me.nUDCantidadPedido = New System.Windows.Forms.NumericUpDown()
		Me.cmBMarca = New System.Windows.Forms.ComboBox()
		Me.cmBCProvedor = New System.Windows.Forms.ComboBox()
		Me.btnLimpiar = New System.Windows.Forms.Button()
		Me.btnRegistrar = New System.Windows.Forms.Button()
		Me.txtPrecio = New System.Windows.Forms.TextBox()
		Me.txtClave = New System.Windows.Forms.TextBox()
		Me.lblTitulo = New System.Windows.Forms.Label()
		Me.btnEliminar = New System.Windows.Forms.Button()
		Me.btnActualizar = New System.Windows.Forms.Button()
		Me.lbltBuscar = New System.Windows.Forms.Label()
		Me.btnBuscar = New System.Windows.Forms.Button()
		Me.dTPBFecha = New System.Windows.Forms.DateTimePicker()
		Me.dTpFecha = New System.Windows.Forms.DateTimePicker()
		Me.dGVPedidos = New System.Windows.Forms.DataGridView()
		Me.cmbProductos = New System.Windows.Forms.ComboBox()
		Me.txtBClave = New System.Windows.Forms.TextBox()
		CType(Me.nUDCantidadPedido,System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.dGVPedidos,System.ComponentModel.ISupportInitialize).BeginInit
		Me.SuspendLayout
		'
		'lbltCantidad
		'
		Me.lbltCantidad.Font = New System.Drawing.Font("Agency FB", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic),System.Drawing.FontStyle))
		Me.lbltCantidad.ForeColor = System.Drawing.Color.White
		Me.lbltCantidad.Location = New System.Drawing.Point(354, 149)
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
		Me.nUDCantidadPedido.Location = New System.Drawing.Point(460, 148)
		Me.nUDCantidadPedido.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
		Me.nUDCantidadPedido.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
		Me.nUDCantidadPedido.Name = "nUDCantidadPedido"
		Me.nUDCantidadPedido.Size = New System.Drawing.Size(194, 33)
		Me.nUDCantidadPedido.TabIndex = 85
		Me.nUDCantidadPedido.Value = New Decimal(New Integer() {1, 0, 0, 0})
		'
		'cmBMarca
		'
		Me.cmBMarca.BackColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(104,Byte),Integer), CType(CType(130,Byte),Integer))
		Me.cmBMarca.Font = New System.Drawing.Font("Agency FB", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic),System.Drawing.FontStyle))
		Me.cmBMarca.ForeColor = System.Drawing.Color.Gainsboro
		Me.cmBMarca.FormattingEnabled = true
		Me.cmBMarca.Items.AddRange(New Object() {"BIC", "AZOR", "CRAYOLA", "MAPITA"})
		Me.cmBMarca.Location = New System.Drawing.Point(354, 73)
		Me.cmBMarca.Name = "cmBMarca"
		Me.cmBMarca.Size = New System.Drawing.Size(300, 33)
		Me.cmBMarca.TabIndex = 83
		Me.cmBMarca.Text = "Marca"
		'
		'cmBCProvedor
		'
		Me.cmBCProvedor.BackColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(104,Byte),Integer), CType(CType(130,Byte),Integer))
		Me.cmBCProvedor.Font = New System.Drawing.Font("Agency FB", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic),System.Drawing.FontStyle))
		Me.cmBCProvedor.ForeColor = System.Drawing.Color.Gainsboro
		Me.cmBCProvedor.FormattingEnabled = true
		Me.cmBCProvedor.Location = New System.Drawing.Point(48, 111)
		Me.cmBCProvedor.Name = "cmBCProvedor"
		Me.cmBCProvedor.Size = New System.Drawing.Size(287, 33)
		Me.cmBCProvedor.TabIndex = 81
		Me.cmBCProvedor.Text = "Proveedores"
		'
		'btnLimpiar
		'
		Me.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(104,Byte),Integer), CType(CType(130,Byte),Integer))
		Me.btnLimpiar.Font = New System.Drawing.Font("Agency FB", 18!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.btnLimpiar.ForeColor = System.Drawing.Color.White
		Me.btnLimpiar.Image = CType(resources.GetObject("btnLimpiar.Image"),System.Drawing.Image)
		Me.btnLimpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.btnLimpiar.Location = New System.Drawing.Point(673, 123)
		Me.btnLimpiar.Name = "btnLimpiar"
		Me.btnLimpiar.Size = New System.Drawing.Size(172, 55)
		Me.btnLimpiar.TabIndex = 80
		Me.btnLimpiar.Text = "    LIMPIAR"
		Me.btnLimpiar.UseVisualStyleBackColor = false
		'
		'btnRegistrar
		'
		Me.btnRegistrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(104,Byte),Integer), CType(CType(130,Byte),Integer))
		Me.btnRegistrar.Font = New System.Drawing.Font("Agency FB", 18!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.btnRegistrar.ForeColor = System.Drawing.Color.White
		Me.btnRegistrar.Image = CType(resources.GetObject("btnRegistrar.Image"),System.Drawing.Image)
		Me.btnRegistrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.btnRegistrar.Location = New System.Drawing.Point(673, 282)
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
		Me.txtPrecio.Location = New System.Drawing.Point(354, 190)
		Me.txtPrecio.Name = "txtPrecio"
		Me.txtPrecio.Size = New System.Drawing.Size(300, 33)
		Me.txtPrecio.TabIndex = 78
		Me.txtPrecio.Text = "Precio Pedido"
		'
		'txtClave
		'
		Me.txtClave.BackColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(104,Byte),Integer), CType(CType(130,Byte),Integer))
		Me.txtClave.Font = New System.Drawing.Font("Agency FB", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic),System.Drawing.FontStyle))
		Me.txtClave.ForeColor = System.Drawing.Color.Gainsboro
		Me.txtClave.Location = New System.Drawing.Point(48, 72)
		Me.txtClave.Name = "txtClave"
		Me.txtClave.Size = New System.Drawing.Size(287, 33)
		Me.txtClave.TabIndex = 75
		Me.txtClave.Text = "Clave Pedido"
		'
		'lblTitulo
		'
		Me.lblTitulo.Dock = System.Windows.Forms.DockStyle.Top
		Me.lblTitulo.Font = New System.Drawing.Font("Agency FB", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic),System.Drawing.FontStyle))
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
		Me.btnEliminar.Location = New System.Drawing.Point(673, 350)
		Me.btnEliminar.Name = "btnEliminar"
		Me.btnEliminar.Size = New System.Drawing.Size(172, 51)
		Me.btnEliminar.TabIndex = 90
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
		Me.btnActualizar.Location = New System.Drawing.Point(673, 415)
		Me.btnActualizar.Name = "btnActualizar"
		Me.btnActualizar.Size = New System.Drawing.Size(172, 47)
		Me.btnActualizar.TabIndex = 91
		Me.btnActualizar.Text = "   Actualizar"
		Me.btnActualizar.UseVisualStyleBackColor = false
		AddHandler Me.btnActualizar.Click, AddressOf Me.BtnActualizarClick
		'
		'lbltBuscar
		'
		Me.lbltBuscar.Font = New System.Drawing.Font("Agency FB", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic),System.Drawing.FontStyle))
		Me.lbltBuscar.ForeColor = System.Drawing.Color.White
		Me.lbltBuscar.Location = New System.Drawing.Point(48, 242)
		Me.lbltBuscar.Name = "lbltBuscar"
		Me.lbltBuscar.Size = New System.Drawing.Size(98, 37)
		Me.lbltBuscar.TabIndex = 92
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
		Me.btnBuscar.Location = New System.Drawing.Point(673, 72)
		Me.btnBuscar.Name = "btnBuscar"
		Me.btnBuscar.Size = New System.Drawing.Size(172, 47)
		Me.btnBuscar.TabIndex = 94
		Me.btnBuscar.Text = "  Buscar"
		Me.btnBuscar.UseVisualStyleBackColor = false
		'
		'dTPBFecha
		'
		Me.dTPBFecha.CalendarFont = New System.Drawing.Font("Agency FB", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic),System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.dTPBFecha.Font = New System.Drawing.Font("Agency FB", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic),System.Drawing.FontStyle))
		Me.dTPBFecha.Location = New System.Drawing.Point(402, 247)
		Me.dTPBFecha.Name = "dTPBFecha"
		Me.dTPBFecha.Size = New System.Drawing.Size(252, 33)
		Me.dTPBFecha.TabIndex = 95
		'
		'dTpFecha
		'
		Me.dTpFecha.CalendarFont = New System.Drawing.Font("Agency FB", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic),System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.dTpFecha.Font = New System.Drawing.Font("Agency FB", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic),System.Drawing.FontStyle))
		Me.dTpFecha.Location = New System.Drawing.Point(48, 149)
		Me.dTpFecha.Name = "dTpFecha"
		Me.dTpFecha.Size = New System.Drawing.Size(287, 33)
		Me.dTpFecha.TabIndex = 96
		'
		'dGVPedidos
		'
		Me.dGVPedidos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
		Me.dGVPedidos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
		Me.dGVPedidos.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(104,Byte),Integer), CType(CType(130,Byte),Integer))
		Me.dGVPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
		dataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver
		dataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
		dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White
		dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
		dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
		Me.dGVPedidos.DefaultCellStyle = dataGridViewCellStyle1
		Me.dGVPedidos.Location = New System.Drawing.Point(48, 282)
		Me.dGVPedidos.Name = "dGVPedidos"
		Me.dGVPedidos.Size = New System.Drawing.Size(606, 180)
		Me.dGVPedidos.TabIndex = 99
		'
		'cmbProductos
		'
		Me.cmbProductos.BackColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(104,Byte),Integer), CType(CType(130,Byte),Integer))
		Me.cmbProductos.Font = New System.Drawing.Font("Agency FB", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic),System.Drawing.FontStyle))
		Me.cmbProductos.ForeColor = System.Drawing.Color.Gainsboro
		Me.cmbProductos.FormattingEnabled = true
		Me.cmbProductos.Items.AddRange(New Object() {"Producto"})
		Me.cmbProductos.Location = New System.Drawing.Point(354, 111)
		Me.cmbProductos.Name = "cmbProductos"
		Me.cmbProductos.Size = New System.Drawing.Size(300, 33)
		Me.cmbProductos.TabIndex = 100
		Me.cmbProductos.Text = "Producto"
		'
		'txtBClave
		'
		Me.txtBClave.BackColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(104,Byte),Integer), CType(CType(130,Byte),Integer))
		Me.txtBClave.Font = New System.Drawing.Font("Agency FB", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic),System.Drawing.FontStyle))
		Me.txtBClave.ForeColor = System.Drawing.Color.Gainsboro
		Me.txtBClave.Location = New System.Drawing.Point(107, 247)
		Me.txtBClave.Name = "txtBClave"
		Me.txtBClave.Size = New System.Drawing.Size(289, 33)
		Me.txtBClave.TabIndex = 101
		Me.txtBClave.Text = "Buscar por clave"
		AddHandler Me.txtBClave.TextChanged, AddressOf Me.TxtBClaveTextChanged
		'
		'FrmPedidos
		'
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(104,Byte),Integer), CType(CType(130,Byte),Integer))
		Me.ClientSize = New System.Drawing.Size(867, 465)
		Me.Controls.Add(Me.txtBClave)
		Me.Controls.Add(Me.cmbProductos)
		Me.Controls.Add(Me.dGVPedidos)
		Me.Controls.Add(Me.dTpFecha)
		Me.Controls.Add(Me.dTPBFecha)
		Me.Controls.Add(Me.btnBuscar)
		Me.Controls.Add(Me.lbltBuscar)
		Me.Controls.Add(Me.btnActualizar)
		Me.Controls.Add(Me.btnEliminar)
		Me.Controls.Add(Me.lblTitulo)
		Me.Controls.Add(Me.lbltCantidad)
		Me.Controls.Add(Me.nUDCantidadPedido)
		Me.Controls.Add(Me.cmBMarca)
		Me.Controls.Add(Me.cmBCProvedor)
		Me.Controls.Add(Me.btnLimpiar)
		Me.Controls.Add(Me.btnRegistrar)
		Me.Controls.Add(Me.txtPrecio)
		Me.Controls.Add(Me.txtClave)
		Me.Name = "FrmPedidos"
		Me.Text = "FrmPedidos"
		AddHandler Load, AddressOf Me.FrmPedidosLoad
		CType(Me.nUDCantidadPedido,System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.dGVPedidos,System.ComponentModel.ISupportInitialize).EndInit
		Me.ResumeLayout(false)
		Me.PerformLayout
	End Sub
	Private txtBClave As System.Windows.Forms.TextBox
	Private dTpFecha As System.Windows.Forms.DateTimePicker
	Private dTPBFecha As System.Windows.Forms.DateTimePicker
	Private btnBuscar As System.Windows.Forms.Button
	Private lbltBuscar As System.Windows.Forms.Label
	Private btnActualizar As System.Windows.Forms.Button
	Private btnEliminar As System.Windows.Forms.Button
	Private dGVPedidos As System.Windows.Forms.DataGridView
	Private lblTitulo As System.Windows.Forms.Label
	Private txtClave As System.Windows.Forms.TextBox
	Private txtPrecio As System.Windows.Forms.TextBox
	Private btnRegistrar As System.Windows.Forms.Button
	Private btnLimpiar As System.Windows.Forms.Button
	Private cmBCProvedor As System.Windows.Forms.ComboBox
	Private cmbProductos As System.Windows.Forms.ComboBox
	Private cmBMarca As System.Windows.Forms.ComboBox
	Private nUDCantidadPedido As System.Windows.Forms.NumericUpDown
	Private lbltCantidad As System.Windows.Forms.Label
End Class
