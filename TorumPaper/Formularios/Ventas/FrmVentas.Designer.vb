'
' Created by SharpDevelop.
' User: Coderp
' Date: 10/03/2022
' Time: 17:52
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Partial Class FrmVentas
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmVentas))
		Dim dataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Dim dataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Dim dataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Dim dataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Me.lblTitulo = New System.Windows.Forms.Label()
		Me.label1 = New System.Windows.Forms.Label()
		Me.cmbProductos = New System.Windows.Forms.ComboBox()
		Me.btnEditar = New System.Windows.Forms.Button()
		Me.btnEliminar = New System.Windows.Forms.Button()
		Me.btnAgregar = New System.Windows.Forms.Button()
		Me.lbltCantidad = New System.Windows.Forms.Label()
		Me.nUDCantidadPedido = New System.Windows.Forms.NumericUpDown()
		Me.dGVventas = New System.Windows.Forms.DataGridView()
		Me.Producto = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.Cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.Fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.Precio = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.button1 = New System.Windows.Forms.Button()
		Me.label2 = New System.Windows.Forms.Label()
		Me.label3 = New System.Windows.Forms.Label()
		Me.txtPrecio = New System.Windows.Forms.TextBox()
		Me.lblPrecio = New System.Windows.Forms.Label()
		Me.label4 = New System.Windows.Forms.Label()
		Me.label5 = New System.Windows.Forms.Label()
		CType(Me.nUDCantidadPedido,System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.dGVventas,System.ComponentModel.ISupportInitialize).BeginInit
		Me.SuspendLayout
		'
		'lblTitulo
		'
		Me.lblTitulo.Dock = System.Windows.Forms.DockStyle.Top
		Me.lblTitulo.Font = New System.Drawing.Font("Agency FB", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.lblTitulo.ForeColor = System.Drawing.Color.White
		Me.lblTitulo.Location = New System.Drawing.Point(0, 0)
		Me.lblTitulo.Name = "lblTitulo"
		Me.lblTitulo.Size = New System.Drawing.Size(867, 62)
		Me.lblTitulo.TabIndex = 32
		Me.lblTitulo.Text = "Sistema de Venta TorumPaper"
		Me.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'label1
		'
		Me.label1.Font = New System.Drawing.Font("Agency FB", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label1.ForeColor = System.Drawing.Color.White
		Me.label1.Location = New System.Drawing.Point(12, 81)
		Me.label1.Name = "label1"
		Me.label1.Size = New System.Drawing.Size(296, 59)
		Me.label1.TabIndex = 35
		Me.label1.Text = "Productos"
		Me.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		AddHandler Me.label1.Click, AddressOf Me.Label1Click
		'
		'cmbProductos
		'
		Me.cmbProductos.BackColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(104,Byte),Integer), CType(CType(130,Byte),Integer))
		Me.cmbProductos.Font = New System.Drawing.Font("Agency FB", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic),System.Drawing.FontStyle))
		Me.cmbProductos.ForeColor = System.Drawing.Color.Gainsboro
		Me.cmbProductos.FormattingEnabled = true
		Me.cmbProductos.Items.AddRange(New Object() {"Producto"})
		Me.cmbProductos.Location = New System.Drawing.Point(20, 143)
		Me.cmbProductos.Name = "cmbProductos"
		Me.cmbProductos.Size = New System.Drawing.Size(271, 33)
		Me.cmbProductos.TabIndex = 101
		Me.cmbProductos.Text = "Producto"
		'
		'btnEditar
		'
		Me.btnEditar.BackColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(104,Byte),Integer), CType(CType(130,Byte),Integer))
		Me.btnEditar.Font = New System.Drawing.Font("Agency FB", 18!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.btnEditar.ForeColor = System.Drawing.Color.White
		Me.btnEditar.Image = CType(resources.GetObject("btnEditar.Image"),System.Drawing.Image)
		Me.btnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.btnEditar.Location = New System.Drawing.Point(22, 285)
		Me.btnEditar.Name = "btnEditar"
		Me.btnEditar.Size = New System.Drawing.Size(271, 47)
		Me.btnEditar.TabIndex = 126
		Me.btnEditar.Text = "Editar"
		Me.btnEditar.UseVisualStyleBackColor = false
		'
		'btnEliminar
		'
		Me.btnEliminar.BackColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(104,Byte),Integer), CType(CType(130,Byte),Integer))
		Me.btnEliminar.Font = New System.Drawing.Font("Agency FB", 18!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.btnEliminar.ForeColor = System.Drawing.Color.White
		Me.btnEliminar.Image = CType(resources.GetObject("btnEliminar.Image"),System.Drawing.Image)
		Me.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.btnEliminar.Location = New System.Drawing.Point(20, 338)
		Me.btnEliminar.Name = "btnEliminar"
		Me.btnEliminar.Size = New System.Drawing.Size(271, 51)
		Me.btnEliminar.TabIndex = 125
		Me.btnEliminar.Text = "Eliminar"
		Me.btnEliminar.UseVisualStyleBackColor = false
		'
		'btnAgregar
		'
		Me.btnAgregar.BackColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(104,Byte),Integer), CType(CType(130,Byte),Integer))
		Me.btnAgregar.Font = New System.Drawing.Font("Agency FB", 18!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.btnAgregar.ForeColor = System.Drawing.Color.White
		Me.btnAgregar.Image = CType(resources.GetObject("btnAgregar.Image"),System.Drawing.Image)
		Me.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.btnAgregar.Location = New System.Drawing.Point(20, 222)
		Me.btnAgregar.Name = "btnAgregar"
		Me.btnAgregar.Size = New System.Drawing.Size(271, 57)
		Me.btnAgregar.TabIndex = 124
		Me.btnAgregar.Text = "Agregar"
		Me.btnAgregar.UseVisualStyleBackColor = false
		'
		'lbltCantidad
		'
		Me.lbltCantidad.Font = New System.Drawing.Font("Agency FB", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic),System.Drawing.FontStyle))
		Me.lbltCantidad.ForeColor = System.Drawing.Color.White
		Me.lbltCantidad.Location = New System.Drawing.Point(18, 184)
		Me.lbltCantidad.Name = "lbltCantidad"
		Me.lbltCantidad.Size = New System.Drawing.Size(100, 30)
		Me.lbltCantidad.TabIndex = 128
		Me.lbltCantidad.Text = "Cantidad"
		'
		'nUDCantidadPedido
		'
		Me.nUDCantidadPedido.BackColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(104,Byte),Integer), CType(CType(130,Byte),Integer))
		Me.nUDCantidadPedido.Font = New System.Drawing.Font("Agency FB", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic),System.Drawing.FontStyle))
		Me.nUDCantidadPedido.ForeColor = System.Drawing.Color.White
		Me.nUDCantidadPedido.Location = New System.Drawing.Point(97, 182)
		Me.nUDCantidadPedido.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
		Me.nUDCantidadPedido.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
		Me.nUDCantidadPedido.Name = "nUDCantidadPedido"
		Me.nUDCantidadPedido.Size = New System.Drawing.Size(194, 33)
		Me.nUDCantidadPedido.TabIndex = 127
		Me.nUDCantidadPedido.Value = New Decimal(New Integer() {1, 0, 0, 0})
		'
		'dGVventas
		'
		Me.dGVventas.AllowUserToAddRows = false
		dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
		dataGridViewCellStyle5.BackColor = System.Drawing.Color.DimGray
		dataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!)
		dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
		dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Gray
		dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White
		dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
		Me.dGVventas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5
		Me.dGVventas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
		Me.dGVventas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
		Me.dGVventas.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(104,Byte),Integer), CType(CType(130,Byte),Integer))
		dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
		dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Highlight
		dataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText
		dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
		dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.DimGray
		dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
		Me.dGVventas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6
		Me.dGVventas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.dGVventas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Producto, Me.Cantidad, Me.Fecha, Me.Precio})
		dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
		dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Highlight
		dataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White
		dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.LightSkyBlue
		dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White
		dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
		Me.dGVventas.DefaultCellStyle = dataGridViewCellStyle7
		Me.dGVventas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
		Me.dGVventas.GridColor = System.Drawing.SystemColors.Control
		Me.dGVventas.Location = New System.Drawing.Point(311, 143)
		Me.dGVventas.Name = "dGVventas"
		dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
		dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.WindowFrame
		dataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
		dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText
		dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
		dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
		dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
		Me.dGVventas.RowHeadersDefaultCellStyle = dataGridViewCellStyle8
		Me.dGVventas.RowHeadersVisible = false
		Me.dGVventas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
		Me.dGVventas.Size = New System.Drawing.Size(544, 251)
		Me.dGVventas.TabIndex = 129
		'
		'Producto
		'
		Me.Producto.HeaderText = "Producto"
		Me.Producto.Name = "Producto"
		'
		'Cantidad
		'
		Me.Cantidad.HeaderText = "Cantidad"
		Me.Cantidad.Name = "Cantidad"
		'
		'Fecha
		'
		Me.Fecha.HeaderText = "Fecha"
		Me.Fecha.Name = "Fecha"
		'
		'Precio
		'
		Me.Precio.HeaderText = "Precio"
		Me.Precio.Name = "Precio"
		'
		'button1
		'
		Me.button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(104,Byte),Integer), CType(CType(130,Byte),Integer))
		Me.button1.Font = New System.Drawing.Font("Agency FB", 18!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.button1.ForeColor = System.Drawing.Color.White
		Me.button1.Image = CType(resources.GetObject("button1.Image"),System.Drawing.Image)
		Me.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.button1.Location = New System.Drawing.Point(307, 405)
		Me.button1.Name = "button1"
		Me.button1.Size = New System.Drawing.Size(224, 51)
		Me.button1.TabIndex = 130
		Me.button1.Text = "Pagar"
		Me.button1.UseVisualStyleBackColor = false
		'
		'label2
		'
		Me.label2.Font = New System.Drawing.Font("Agency FB", 18.25!, System.Drawing.FontStyle.Bold)
		Me.label2.ForeColor = System.Drawing.Color.White
		Me.label2.Location = New System.Drawing.Point(532, 397)
		Me.label2.Name = "label2"
		Me.label2.Size = New System.Drawing.Size(212, 32)
		Me.label2.TabIndex = 131
		Me.label2.Text = "Total"
		Me.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'AddHandler Me.label2.Click, AddressOf Me.Label2Click
		'
		'label3
		'
		Me.label3.Font = New System.Drawing.Font("Agency FB", 18.25!, System.Drawing.FontStyle.Bold)
		Me.label3.ForeColor = System.Drawing.Color.White
		Me.label3.Location = New System.Drawing.Point(712, 397)
		Me.label3.Name = "label3"
		Me.label3.Size = New System.Drawing.Size(143, 32)
		Me.label3.TabIndex = 132
		Me.label3.Text = "0.0"
		Me.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'txtPrecio
		'
		Me.txtPrecio.BackColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(104,Byte),Integer), CType(CType(130,Byte),Integer))
		Me.txtPrecio.Font = New System.Drawing.Font("Agency FB", 20.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic),System.Drawing.FontStyle))
		Me.txtPrecio.ForeColor = System.Drawing.Color.Gainsboro
		Me.txtPrecio.Location = New System.Drawing.Point(22, 417)
		Me.txtPrecio.Name = "txtPrecio"
		Me.txtPrecio.Size = New System.Drawing.Size(269, 41)
		Me.txtPrecio.TabIndex = 133
		Me.txtPrecio.Text = "Pago"
		'
		'lblPrecio
		'
		Me.lblPrecio.Font = New System.Drawing.Font("Agency FB", 13.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic),System.Drawing.FontStyle))
		Me.lblPrecio.ForeColor = System.Drawing.Color.White
		Me.lblPrecio.Location = New System.Drawing.Point(22, 380)
		Me.lblPrecio.Name = "lblPrecio"
		Me.lblPrecio.Size = New System.Drawing.Size(67, 37)
		Me.lblPrecio.TabIndex = 134
		Me.lblPrecio.Text = "Pago"
		Me.lblPrecio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.lblPrecio.Visible = false
		'AddHandler Me.lblPrecio.Click, AddressOf Me.LblPrecioClick
		'
		'label4
		'
		Me.label4.Font = New System.Drawing.Font("Agency FB", 14.25!, System.Drawing.FontStyle.Bold)
		Me.label4.ForeColor = System.Drawing.Color.White
		Me.label4.Location = New System.Drawing.Point(712, 425)
		Me.label4.Name = "label4"
		Me.label4.Size = New System.Drawing.Size(143, 32)
		Me.label4.TabIndex = 136
		Me.label4.Text = "0.0"
		Me.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'label5
		'
		Me.label5.Font = New System.Drawing.Font("Agency FB", 14.25!, System.Drawing.FontStyle.Bold)
		Me.label5.ForeColor = System.Drawing.Color.White
		Me.label5.Location = New System.Drawing.Point(537, 426)
		Me.label5.Name = "label5"
		Me.label5.Size = New System.Drawing.Size(212, 32)
		Me.label5.TabIndex = 135
		Me.label5.Text = "Cambio"
		Me.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'FrmVentas
		'
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(104,Byte),Integer), CType(CType(130,Byte),Integer))
		Me.ClientSize = New System.Drawing.Size(867, 465)
		Me.Controls.Add(Me.label4)
		Me.Controls.Add(Me.label5)
		Me.Controls.Add(Me.btnEliminar)
		Me.Controls.Add(Me.txtPrecio)
		Me.Controls.Add(Me.lblPrecio)
		Me.Controls.Add(Me.button1)
		Me.Controls.Add(Me.label3)
		Me.Controls.Add(Me.label2)
		Me.Controls.Add(Me.dGVventas)
		Me.Controls.Add(Me.nUDCantidadPedido)
		Me.Controls.Add(Me.lbltCantidad)
		Me.Controls.Add(Me.btnEditar)
		Me.Controls.Add(Me.btnAgregar)
		Me.Controls.Add(Me.cmbProductos)
		Me.Controls.Add(Me.label1)
		Me.Controls.Add(Me.lblTitulo)
		Me.Name = "FrmVentas"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "FrmVentas"
		AddHandler Load, AddressOf Me.FrmVentasLoad
		CType(Me.nUDCantidadPedido,System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.dGVventas,System.ComponentModel.ISupportInitialize).EndInit
		Me.ResumeLayout(false)
		Me.PerformLayout
	End Sub
	Private label5 As System.Windows.Forms.Label
	Private label4 As System.Windows.Forms.Label
	Private lblPrecio As System.Windows.Forms.Label
	Private txtPrecio As System.Windows.Forms.TextBox
	Private label3 As System.Windows.Forms.Label
	Private label2 As System.Windows.Forms.Label
	Private button1 As System.Windows.Forms.Button
	Private Precio As System.Windows.Forms.DataGridViewTextBoxColumn
	Private Fecha As System.Windows.Forms.DataGridViewTextBoxColumn
	Private Cantidad As System.Windows.Forms.DataGridViewTextBoxColumn
	Private Producto As System.Windows.Forms.DataGridViewTextBoxColumn
	Private dGVventas As System.Windows.Forms.DataGridView
	Private nUDCantidadPedido As System.Windows.Forms.NumericUpDown
	Private lbltCantidad As System.Windows.Forms.Label
	Private btnAgregar As System.Windows.Forms.Button
	Private btnEliminar As System.Windows.Forms.Button
	Private btnEditar As System.Windows.Forms.Button
	Private cmbProductos As System.Windows.Forms.ComboBox
	Private label1 As System.Windows.Forms.Label
	Private lblTitulo As System.Windows.Forms.Label
End Class
