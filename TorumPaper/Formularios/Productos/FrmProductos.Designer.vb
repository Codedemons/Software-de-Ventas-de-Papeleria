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
		Me.labelStockDisponible = New System.Windows.Forms.Label()
		Me.labelStockMaximo = New System.Windows.Forms.Label()
		Me.labelStockMinimo = New System.Windows.Forms.Label()
		Me.numericUpDown2 = New System.Windows.Forms.NumericUpDown()
		Me.numericUpDown1 = New System.Windows.Forms.NumericUpDown()
		Me.numUDCantidadPedido = New System.Windows.Forms.NumericUpDown()
		Me.coBoxMarca = New System.Windows.Forms.ComboBox()
		Me.coBoxTipo = New System.Windows.Forms.ComboBox()
		Me.txtPrecio = New System.Windows.Forms.TextBox()
		Me.txtDescripcion = New System.Windows.Forms.TextBox()
		Me.txtClaveProducto = New System.Windows.Forms.TextBox()
		Me.lblTitulo = New System.Windows.Forms.Label()
		Me.btnBuscar = New System.Windows.Forms.Button()
		Me.lbltBuscar = New System.Windows.Forms.Label()
		Me.btnActualizar = New System.Windows.Forms.Button()
		Me.btnEliminar = New System.Windows.Forms.Button()
		Me.dGVProductos = New System.Windows.Forms.DataGridView()
		Me.btnLimpiar = New System.Windows.Forms.Button()
		Me.btnRegistrar = New System.Windows.Forms.Button()
		Me.comboBox4 = New System.Windows.Forms.ComboBox()
		Me.comboBox5 = New System.Windows.Forms.ComboBox()
		Me.textBox1 = New System.Windows.Forms.TextBox()
		Me.comboBox6 = New System.Windows.Forms.ComboBox()
		CType(Me.numericUpDown2,System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.numericUpDown1,System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.numUDCantidadPedido,System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.dGVProductos,System.ComponentModel.ISupportInitialize).BeginInit
		Me.SuspendLayout
		'
		'labelStockDisponible
		'
		Me.labelStockDisponible.Font = New System.Drawing.Font("Agency FB", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic),System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.labelStockDisponible.ForeColor = System.Drawing.Color.White
		Me.labelStockDisponible.Location = New System.Drawing.Point(367, 189)
		Me.labelStockDisponible.Name = "labelStockDisponible"
		Me.labelStockDisponible.Size = New System.Drawing.Size(115, 30)
		Me.labelStockDisponible.TabIndex = 88
		Me.labelStockDisponible.Text = "Stock Disponible"
		'
		'labelStockMaximo
		'
		Me.labelStockMaximo.Font = New System.Drawing.Font("Agency FB", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic),System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.labelStockMaximo.ForeColor = System.Drawing.Color.White
		Me.labelStockMaximo.Location = New System.Drawing.Point(30, 186)
		Me.labelStockMaximo.Name = "labelStockMaximo"
		Me.labelStockMaximo.Size = New System.Drawing.Size(100, 30)
		Me.labelStockMaximo.TabIndex = 87
		Me.labelStockMaximo.Text = "Stock Máximo"
		'
		'labelStockMinimo
		'
		Me.labelStockMinimo.Font = New System.Drawing.Font("Agency FB", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic),System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.labelStockMinimo.ForeColor = System.Drawing.Color.White
		Me.labelStockMinimo.Location = New System.Drawing.Point(367, 153)
		Me.labelStockMinimo.Name = "labelStockMinimo"
		Me.labelStockMinimo.Size = New System.Drawing.Size(115, 30)
		Me.labelStockMinimo.TabIndex = 86
		Me.labelStockMinimo.Text = "Stock Mínimo"
		'
		'numericUpDown2
		'
		Me.numericUpDown2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(104,Byte),Integer), CType(CType(130,Byte),Integer))
		Me.numericUpDown2.Font = New System.Drawing.Font("Agency FB", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic),System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.numericUpDown2.ForeColor = System.Drawing.Color.White
		Me.numericUpDown2.Location = New System.Drawing.Point(488, 189)
		Me.numericUpDown2.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
		Me.numericUpDown2.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
		Me.numericUpDown2.Name = "numericUpDown2"
		Me.numericUpDown2.Size = New System.Drawing.Size(173, 30)
		Me.numericUpDown2.TabIndex = 85
		Me.numericUpDown2.Value = New Decimal(New Integer() {1, 0, 0, 0})
		'
		'numericUpDown1
		'
		Me.numericUpDown1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(104,Byte),Integer), CType(CType(130,Byte),Integer))
		Me.numericUpDown1.Font = New System.Drawing.Font("Agency FB", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic),System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.numericUpDown1.ForeColor = System.Drawing.Color.White
		Me.numericUpDown1.Location = New System.Drawing.Point(151, 185)
		Me.numericUpDown1.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
		Me.numericUpDown1.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
		Me.numericUpDown1.Name = "numericUpDown1"
		Me.numericUpDown1.Size = New System.Drawing.Size(200, 30)
		Me.numericUpDown1.TabIndex = 84
		Me.numericUpDown1.Value = New Decimal(New Integer() {1, 0, 0, 0})
		'
		'numUDCantidadPedido
		'
		Me.numUDCantidadPedido.BackColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(104,Byte),Integer), CType(CType(130,Byte),Integer))
		Me.numUDCantidadPedido.Font = New System.Drawing.Font("Agency FB", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic),System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.numUDCantidadPedido.ForeColor = System.Drawing.Color.White
		Me.numUDCantidadPedido.Location = New System.Drawing.Point(488, 153)
		Me.numUDCantidadPedido.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
		Me.numUDCantidadPedido.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
		Me.numUDCantidadPedido.Name = "numUDCantidadPedido"
		Me.numUDCantidadPedido.Size = New System.Drawing.Size(173, 30)
		Me.numUDCantidadPedido.TabIndex = 83
		Me.numUDCantidadPedido.Value = New Decimal(New Integer() {1, 0, 0, 0})
		'
		'coBoxMarca
		'
		Me.coBoxMarca.BackColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(104,Byte),Integer), CType(CType(130,Byte),Integer))
		Me.coBoxMarca.Font = New System.Drawing.Font("Agency FB", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic),System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.coBoxMarca.ForeColor = System.Drawing.Color.LightGray
		Me.coBoxMarca.FormattingEnabled = true
		Me.coBoxMarca.Items.AddRange(New Object() {"BIC", "AZOR", "CRAYOLA", "MAPITA"})
		Me.coBoxMarca.Location = New System.Drawing.Point(30, 111)
		Me.coBoxMarca.Name = "coBoxMarca"
		Me.coBoxMarca.Size = New System.Drawing.Size(321, 33)
		Me.coBoxMarca.TabIndex = 82
		Me.coBoxMarca.Text = "Marca"
		'
		'coBoxTipo
		'
		Me.coBoxTipo.BackColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(104,Byte),Integer), CType(CType(130,Byte),Integer))
		Me.coBoxTipo.Font = New System.Drawing.Font("Agency FB", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic),System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.coBoxTipo.ForeColor = System.Drawing.Color.LightGray
		Me.coBoxTipo.FormattingEnabled = true
		Me.coBoxTipo.Items.AddRange(New Object() {"LÁPIZ", "BOLÍGRAFO", "CARPETA", "GRAPA", "HOJA BLANCA"})
		Me.coBoxTipo.Location = New System.Drawing.Point(367, 72)
		Me.coBoxTipo.Name = "coBoxTipo"
		Me.coBoxTipo.Size = New System.Drawing.Size(294, 33)
		Me.coBoxTipo.TabIndex = 81
		Me.coBoxTipo.Text = "Tipo"
		'
		'txtPrecio
		'
		Me.txtPrecio.BackColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(104,Byte),Integer), CType(CType(130,Byte),Integer))
		Me.txtPrecio.Font = New System.Drawing.Font("Agency FB", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic),System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.txtPrecio.ForeColor = System.Drawing.Color.LightGray
		Me.txtPrecio.Location = New System.Drawing.Point(30, 150)
		Me.txtPrecio.Name = "txtPrecio"
		Me.txtPrecio.Size = New System.Drawing.Size(321, 33)
		Me.txtPrecio.TabIndex = 78
		Me.txtPrecio.Text = "Precio"
		'
		'txtDescripcion
		'
		Me.txtDescripcion.BackColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(104,Byte),Integer), CType(CType(130,Byte),Integer))
		Me.txtDescripcion.Font = New System.Drawing.Font("Agency FB", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic),System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.txtDescripcion.ForeColor = System.Drawing.Color.LightGray
		Me.txtDescripcion.Location = New System.Drawing.Point(367, 111)
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
		Me.txtClaveProducto.Location = New System.Drawing.Point(30, 72)
		Me.txtClaveProducto.Name = "txtClaveProducto"
		Me.txtClaveProducto.Size = New System.Drawing.Size(321, 33)
		Me.txtClaveProducto.TabIndex = 76
		Me.txtClaveProducto.Text = "Clave"
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
		Me.btnBuscar.TabIndex = 103
		Me.btnBuscar.Text = "  Buscar"
		Me.btnBuscar.UseVisualStyleBackColor = false
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
		'btnActualizar
		'
		Me.btnActualizar.BackColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(104,Byte),Integer), CType(CType(130,Byte),Integer))
		Me.btnActualizar.Font = New System.Drawing.Font("Agency FB", 18!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.btnActualizar.ForeColor = System.Drawing.Color.White
		Me.btnActualizar.Image = CType(resources.GetObject("btnActualizar.Image"),System.Drawing.Image)
		Me.btnActualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.btnActualizar.Location = New System.Drawing.Point(654, 416)
		Me.btnActualizar.Name = "btnActualizar"
		Me.btnActualizar.Size = New System.Drawing.Size(191, 47)
		Me.btnActualizar.TabIndex = 100
		Me.btnActualizar.Text = "   Actualizar"
		Me.btnActualizar.UseVisualStyleBackColor = false
		'
		'btnEliminar
		'
		Me.btnEliminar.BackColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(104,Byte),Integer), CType(CType(130,Byte),Integer))
		Me.btnEliminar.Font = New System.Drawing.Font("Agency FB", 18!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.btnEliminar.ForeColor = System.Drawing.Color.White
		Me.btnEliminar.Image = CType(resources.GetObject("btnEliminar.Image"),System.Drawing.Image)
		Me.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.btnEliminar.Location = New System.Drawing.Point(654, 351)
		Me.btnEliminar.Name = "btnEliminar"
		Me.btnEliminar.Size = New System.Drawing.Size(191, 51)
		Me.btnEliminar.TabIndex = 99
		Me.btnEliminar.Text = "Eliminar"
		Me.btnEliminar.UseVisualStyleBackColor = false
		'
		'dGVProductos
		'
		Me.dGVProductos.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(104,Byte),Integer), CType(CType(130,Byte),Integer))
		Me.dGVProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.dGVProductos.Location = New System.Drawing.Point(29, 283)
		Me.dGVProductos.Name = "dGVProductos"
		Me.dGVProductos.Size = New System.Drawing.Size(606, 180)
		Me.dGVProductos.TabIndex = 98
		'
		'btnLimpiar
		'
		Me.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(104,Byte),Integer), CType(CType(130,Byte),Integer))
		Me.btnLimpiar.Font = New System.Drawing.Font("Agency FB", 18!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.btnLimpiar.ForeColor = System.Drawing.Color.White
		Me.btnLimpiar.Image = CType(resources.GetObject("btnLimpiar.Image"),System.Drawing.Image)
		Me.btnLimpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.btnLimpiar.Location = New System.Drawing.Point(673, 126)
		Me.btnLimpiar.Name = "btnLimpiar"
		Me.btnLimpiar.Size = New System.Drawing.Size(172, 55)
		Me.btnLimpiar.TabIndex = 96
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
		Me.btnRegistrar.Location = New System.Drawing.Point(654, 283)
		Me.btnRegistrar.Name = "btnRegistrar"
		Me.btnRegistrar.Size = New System.Drawing.Size(191, 57)
		Me.btnRegistrar.TabIndex = 95
		Me.btnRegistrar.Text = "   Registrar"
		Me.btnRegistrar.UseVisualStyleBackColor = false
		'
		'comboBox4
		'
		Me.comboBox4.BackColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(104,Byte),Integer), CType(CType(130,Byte),Integer))
		Me.comboBox4.Font = New System.Drawing.Font("Agency FB", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.comboBox4.ForeColor = System.Drawing.Color.White
		Me.comboBox4.FormattingEnabled = true
		Me.comboBox4.Items.AddRange(New Object() {"Stock Mínimo", "Stock Disponible", "Stock Máximo"})
		Me.comboBox4.Location = New System.Drawing.Point(151, 245)
		Me.comboBox4.Name = "comboBox4"
		Me.comboBox4.Size = New System.Drawing.Size(106, 32)
		Me.comboBox4.TabIndex = 107
		Me.comboBox4.Text = "Marca"
		'
		'comboBox5
		'
		Me.comboBox5.BackColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(104,Byte),Integer), CType(CType(130,Byte),Integer))
		Me.comboBox5.Font = New System.Drawing.Font("Agency FB", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.comboBox5.ForeColor = System.Drawing.Color.White
		Me.comboBox5.FormattingEnabled = true
		Me.comboBox5.Items.AddRange(New Object() {"Stock Mínimo", "Stock Disponible", "Stock Máximo"})
		Me.comboBox5.Location = New System.Drawing.Point(263, 245)
		Me.comboBox5.Name = "comboBox5"
		Me.comboBox5.Size = New System.Drawing.Size(115, 32)
		Me.comboBox5.TabIndex = 106
		Me.comboBox5.Text = "Tipo"
		'
		'textBox1
		'
		Me.textBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(104,Byte),Integer), CType(CType(130,Byte),Integer))
		Me.textBox1.Font = New System.Drawing.Font("Agency FB", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.textBox1.ForeColor = System.Drawing.Color.White
		Me.textBox1.Location = New System.Drawing.Point(384, 247)
		Me.textBox1.Name = "textBox1"
		Me.textBox1.Size = New System.Drawing.Size(130, 30)
		Me.textBox1.TabIndex = 105
		Me.textBox1.Text = "Precio"
		Me.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		'
		'comboBox6
		'
		Me.comboBox6.BackColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(104,Byte),Integer), CType(CType(130,Byte),Integer))
		Me.comboBox6.Font = New System.Drawing.Font("Agency FB", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.comboBox6.ForeColor = System.Drawing.Color.White
		Me.comboBox6.FormattingEnabled = true
		Me.comboBox6.Items.AddRange(New Object() {"Stock Mínimo", "Stock Disponible", "Stock Máximo"})
		Me.comboBox6.Location = New System.Drawing.Point(520, 247)
		Me.comboBox6.Name = "comboBox6"
		Me.comboBox6.Size = New System.Drawing.Size(114, 32)
		Me.comboBox6.TabIndex = 104
		Me.comboBox6.Text = "Stock Mínimo"
		'
		'FrmProductos
		'
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(104,Byte),Integer), CType(CType(130,Byte),Integer))
		Me.ClientSize = New System.Drawing.Size(857, 465)
		Me.Controls.Add(Me.comboBox4)
		Me.Controls.Add(Me.comboBox5)
		Me.Controls.Add(Me.textBox1)
		Me.Controls.Add(Me.comboBox6)
		Me.Controls.Add(Me.btnBuscar)
		Me.Controls.Add(Me.lbltBuscar)
		Me.Controls.Add(Me.btnActualizar)
		Me.Controls.Add(Me.btnEliminar)
		Me.Controls.Add(Me.dGVProductos)
		Me.Controls.Add(Me.btnLimpiar)
		Me.Controls.Add(Me.btnRegistrar)
		Me.Controls.Add(Me.lblTitulo)
		Me.Controls.Add(Me.labelStockDisponible)
		Me.Controls.Add(Me.labelStockMaximo)
		Me.Controls.Add(Me.labelStockMinimo)
		Me.Controls.Add(Me.numericUpDown2)
		Me.Controls.Add(Me.numericUpDown1)
		Me.Controls.Add(Me.numUDCantidadPedido)
		Me.Controls.Add(Me.coBoxMarca)
		Me.Controls.Add(Me.coBoxTipo)
		Me.Controls.Add(Me.txtPrecio)
		Me.Controls.Add(Me.txtDescripcion)
		Me.Controls.Add(Me.txtClaveProducto)
		Me.Name = "FrmProductos"
		Me.Text = "FrmProductos"
		CType(Me.numericUpDown2,System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.numericUpDown1,System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.numUDCantidadPedido,System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.dGVProductos,System.ComponentModel.ISupportInitialize).EndInit
		Me.ResumeLayout(false)
		Me.PerformLayout
	End Sub
	Private comboBox6 As System.Windows.Forms.ComboBox
	Private textBox1 As System.Windows.Forms.TextBox
	Private comboBox5 As System.Windows.Forms.ComboBox
	Private comboBox4 As System.Windows.Forms.ComboBox
	Private dGVProductos As System.Windows.Forms.DataGridView
	Private btnEliminar As System.Windows.Forms.Button
	Private btnActualizar As System.Windows.Forms.Button
	Private lbltBuscar As System.Windows.Forms.Label
	Private btnBuscar As System.Windows.Forms.Button
	Private lblTitulo As System.Windows.Forms.Label
	Private txtClaveProducto As System.Windows.Forms.TextBox
	Private txtDescripcion As System.Windows.Forms.TextBox
	Private txtPrecio As System.Windows.Forms.TextBox
	Private btnRegistrar As System.Windows.Forms.Button
	Private btnLimpiar As System.Windows.Forms.Button
	Private coBoxTipo As System.Windows.Forms.ComboBox
	Private coBoxMarca As System.Windows.Forms.ComboBox
	Private numUDCantidadPedido As System.Windows.Forms.NumericUpDown
	Private numericUpDown1 As System.Windows.Forms.NumericUpDown
	Private numericUpDown2 As System.Windows.Forms.NumericUpDown
	Private labelStockMinimo As System.Windows.Forms.Label
	Private labelStockMaximo As System.Windows.Forms.Label
	Private labelStockDisponible As System.Windows.Forms.Label
End Class
