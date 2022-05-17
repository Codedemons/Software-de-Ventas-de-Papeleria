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
		Dim dataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Dim dataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Dim dataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Dim dataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Me.lblTitulo = New System.Windows.Forms.Label()
		Me.label1 = New System.Windows.Forms.Label()
		Me.cmbProductos = New System.Windows.Forms.ComboBox()
		Me.btnEditar = New System.Windows.Forms.Button()
		Me.btnEliminar = New System.Windows.Forms.Button()
		Me.btnAgregar = New System.Windows.Forms.Button()
		Me.lbltCantidad = New System.Windows.Forms.Label()
		Me.nUDCantidad = New System.Windows.Forms.NumericUpDown()
		Me.dGVventas = New System.Windows.Forms.DataGridView()
		Me.Producto = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.Cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.Fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.Precio = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.Total = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.btnPagar = New System.Windows.Forms.Button()
		Me.label2 = New System.Windows.Forms.Label()
		Me.label3 = New System.Windows.Forms.Label()
		Me.txtPago = New System.Windows.Forms.TextBox()
		Me.lblPago = New System.Windows.Forms.Label()
		Me.label4 = New System.Windows.Forms.Label()
		Me.label5 = New System.Windows.Forms.Label()
		CType(Me.nUDCantidad,System.ComponentModel.ISupportInitialize).BeginInit
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
		AddHandler Me.btnEditar.Click, AddressOf Me.BtnEditarClick
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
		AddHandler Me.btnEliminar.Click, AddressOf Me.BtnEliminarClick
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
		AddHandler Me.btnAgregar.Click, AddressOf Me.BtnAgregarClick
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
		'nUDCantidad
		'
		Me.nUDCantidad.BackColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(104,Byte),Integer), CType(CType(130,Byte),Integer))
		Me.nUDCantidad.Font = New System.Drawing.Font("Agency FB", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic),System.Drawing.FontStyle))
		Me.nUDCantidad.ForeColor = System.Drawing.Color.White
		Me.nUDCantidad.Location = New System.Drawing.Point(97, 182)
		Me.nUDCantidad.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
		Me.nUDCantidad.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
		Me.nUDCantidad.Name = "nUDCantidad"
		Me.nUDCantidad.Size = New System.Drawing.Size(194, 33)
		Me.nUDCantidad.TabIndex = 127
		Me.nUDCantidad.Value = New Decimal(New Integer() {1, 0, 0, 0})
		'
		'dGVventas
		'
		Me.dGVventas.AllowUserToAddRows = false
		dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
		dataGridViewCellStyle1.BackColor = System.Drawing.Color.DimGray
		dataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!)
		dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
		dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Gray
		dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
		dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
		Me.dGVventas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1
		Me.dGVventas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
		Me.dGVventas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
		Me.dGVventas.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(104,Byte),Integer), CType(CType(130,Byte),Integer))
		dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
		dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Highlight
		dataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
		dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
		dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.DimGray
		dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
		Me.dGVventas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2
		Me.dGVventas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.dGVventas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Producto, Me.Cantidad, Me.Fecha, Me.Precio, Me.Total})
		dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
		dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Highlight
		dataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
		dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightSkyBlue
		dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
		dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
		Me.dGVventas.DefaultCellStyle = dataGridViewCellStyle3
		Me.dGVventas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
		Me.dGVventas.GridColor = System.Drawing.SystemColors.Control
		Me.dGVventas.Location = New System.Drawing.Point(311, 143)
		Me.dGVventas.Name = "dGVventas"
		dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
		dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.WindowFrame
		dataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
		dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
		dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
		dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
		dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
		Me.dGVventas.RowHeadersDefaultCellStyle = dataGridViewCellStyle4
		Me.dGVventas.RowHeadersVisible = false
		Me.dGVventas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
		Me.dGVventas.Size = New System.Drawing.Size(544, 251)
		Me.dGVventas.TabIndex = 129
		AddHandler Me.dGVventas.CellClick, AddressOf Me.DGVventasCellClick
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
		Me.Precio.HeaderText = "Precio Unitario"
		Me.Precio.Name = "Precio"
		'
		'Total
		'
		Me.Total.HeaderText = "Total"
		Me.Total.Name = "Total"
		'
		'btnPagar
		'
		Me.btnPagar.BackColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(104,Byte),Integer), CType(CType(130,Byte),Integer))
		Me.btnPagar.Font = New System.Drawing.Font("Agency FB", 18!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.btnPagar.ForeColor = System.Drawing.Color.White
		Me.btnPagar.Image = CType(resources.GetObject("btnPagar.Image"),System.Drawing.Image)
		Me.btnPagar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.btnPagar.Location = New System.Drawing.Point(307, 405)
		Me.btnPagar.Name = "btnPagar"
		Me.btnPagar.Size = New System.Drawing.Size(224, 51)
		Me.btnPagar.TabIndex = 130
		Me.btnPagar.Text = "Pagar"
		Me.btnPagar.UseVisualStyleBackColor = false
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
		'txtPago
		'
		Me.txtPago.BackColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(104,Byte),Integer), CType(CType(130,Byte),Integer))
		Me.txtPago.Font = New System.Drawing.Font("Agency FB", 20.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic),System.Drawing.FontStyle))
		Me.txtPago.ForeColor = System.Drawing.Color.Gainsboro
		Me.txtPago.Location = New System.Drawing.Point(22, 417)
		Me.txtPago.Name = "txtPago"
		Me.txtPago.Size = New System.Drawing.Size(269, 41)
		Me.txtPago.TabIndex = 133
		Me.txtPago.Text = "Pago"
		'
		'lblPago
		'
		Me.lblPago.Font = New System.Drawing.Font("Agency FB", 13.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic),System.Drawing.FontStyle))
		Me.lblPago.ForeColor = System.Drawing.Color.White
		Me.lblPago.Location = New System.Drawing.Point(22, 386)
		Me.lblPago.Name = "lblPago"
		Me.lblPago.Size = New System.Drawing.Size(67, 37)
		Me.lblPago.TabIndex = 134
		Me.lblPago.Text = "Pago"
		Me.lblPago.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.lblPago.Visible = false
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
		Me.Controls.Add(Me.txtPago)
		Me.Controls.Add(Me.lblPago)
		Me.Controls.Add(Me.btnPagar)
		Me.Controls.Add(Me.label3)
		Me.Controls.Add(Me.label2)
		Me.Controls.Add(Me.dGVventas)
		Me.Controls.Add(Me.nUDCantidad)
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
		CType(Me.nUDCantidad,System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.dGVventas,System.ComponentModel.ISupportInitialize).EndInit
		Me.ResumeLayout(false)
		Me.PerformLayout
	End Sub
	Private Total As System.Windows.Forms.DataGridViewTextBoxColumn
	Private label5 As System.Windows.Forms.Label
	Private label4 As System.Windows.Forms.Label
	Private lblPago As System.Windows.Forms.Label
	Private txtPago As System.Windows.Forms.TextBox
	Private label3 As System.Windows.Forms.Label
	Private label2 As System.Windows.Forms.Label
	Private btnPagar As System.Windows.Forms.Button
	Private Precio As System.Windows.Forms.DataGridViewTextBoxColumn
	Private Fecha As System.Windows.Forms.DataGridViewTextBoxColumn
	Private Cantidad As System.Windows.Forms.DataGridViewTextBoxColumn
	Private Producto As System.Windows.Forms.DataGridViewTextBoxColumn
	Private dGVventas As System.Windows.Forms.DataGridView
	Private nUDCantidad As System.Windows.Forms.NumericUpDown
	Private lbltCantidad As System.Windows.Forms.Label
	Private btnAgregar As System.Windows.Forms.Button
	Private btnEliminar As System.Windows.Forms.Button
	Private btnEditar As System.Windows.Forms.Button
	Private cmbProductos As System.Windows.Forms.ComboBox
	Private label1 As System.Windows.Forms.Label
	Private lblTitulo As System.Windows.Forms.Label
End Class
