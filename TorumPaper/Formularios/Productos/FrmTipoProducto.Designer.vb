'
' Created by SharpDevelop.
' User: Coderp
' Date: 15/03/2022
' Time: 13:27
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Partial Class FrmTipoProducto
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmTipoProducto))
		Dim dataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Dim dataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Dim dataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Dim dataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Me.lblTitulo = New System.Windows.Forms.Label()
		Me.txtDescripcion = New System.Windows.Forms.TextBox()
		Me.txtClaveTipo = New System.Windows.Forms.TextBox()
		Me.btnRegistrar = New System.Windows.Forms.Button()
		Me.btnEliminar = New System.Windows.Forms.Button()
		Me.lbltBuscar = New System.Windows.Forms.Label()
		Me.btnModificar = New System.Windows.Forms.Button()
		Me.dGVTipProductos = New System.Windows.Forms.DataGridView()
		Me.textBclave = New System.Windows.Forms.TextBox()
		Me.txtDesc = New System.Windows.Forms.TextBox()
		CType(Me.dGVTipProductos,System.ComponentModel.ISupportInitialize).BeginInit
		Me.SuspendLayout
		'
		'lblTitulo
		'
		Me.lblTitulo.Dock = System.Windows.Forms.DockStyle.Top
		Me.lblTitulo.Font = New System.Drawing.Font("Agency FB", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.lblTitulo.ForeColor = System.Drawing.Color.White
		Me.lblTitulo.Location = New System.Drawing.Point(0, 0)
		Me.lblTitulo.Name = "lblTitulo"
		Me.lblTitulo.Size = New System.Drawing.Size(867, 69)
		Me.lblTitulo.TabIndex = 89
		Me.lblTitulo.Text = "Tipos de Productos  TorumPaper"
		Me.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'txtDescripcion
		'
		Me.txtDescripcion.BackColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(104,Byte),Integer), CType(CType(130,Byte),Integer))
		Me.txtDescripcion.Font = New System.Drawing.Font("Agency FB", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic),System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.txtDescripcion.ForeColor = System.Drawing.Color.LightGray
		Me.txtDescripcion.Location = New System.Drawing.Point(25, 135)
		Me.txtDescripcion.Name = "txtDescripcion"
		Me.txtDescripcion.Size = New System.Drawing.Size(606, 33)
		Me.txtDescripcion.TabIndex = 91
		Me.txtDescripcion.Text = "Descripcion"
		AddHandler Me.txtDescripcion.Click, AddressOf Me.TxtDescripcionClick
		'
		'txtClaveTipo
		'
		Me.txtClaveTipo.BackColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(104,Byte),Integer), CType(CType(130,Byte),Integer))
		Me.txtClaveTipo.Font = New System.Drawing.Font("Agency FB", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic),System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.txtClaveTipo.ForeColor = System.Drawing.Color.LightGray
		Me.txtClaveTipo.Location = New System.Drawing.Point(25, 72)
		Me.txtClaveTipo.Name = "txtClaveTipo"
		Me.txtClaveTipo.Size = New System.Drawing.Size(606, 33)
		Me.txtClaveTipo.TabIndex = 90
		Me.txtClaveTipo.Text = "Clave"
		AddHandler Me.txtClaveTipo.Click, AddressOf Me.TxtClaveTipoClick
		AddHandler Me.txtClaveTipo.TextChanged, AddressOf Me.TxtClaveMarcaTextChanged
		'
		'btnRegistrar
		'
		Me.btnRegistrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(104,Byte),Integer), CType(CType(130,Byte),Integer))
		Me.btnRegistrar.Font = New System.Drawing.Font("Agency FB", 18!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.btnRegistrar.ForeColor = System.Drawing.Color.White
		Me.btnRegistrar.Image = CType(resources.GetObject("btnRegistrar.Image"),System.Drawing.Image)
		Me.btnRegistrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.btnRegistrar.Location = New System.Drawing.Point(650, 72)
		Me.btnRegistrar.Name = "btnRegistrar"
		Me.btnRegistrar.Size = New System.Drawing.Size(191, 57)
		Me.btnRegistrar.TabIndex = 107
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
		Me.btnEliminar.Location = New System.Drawing.Point(650, 191)
		Me.btnEliminar.Name = "btnEliminar"
		Me.btnEliminar.Size = New System.Drawing.Size(191, 51)
		Me.btnEliminar.TabIndex = 110
		Me.btnEliminar.Text = "Eliminar"
		Me.btnEliminar.UseVisualStyleBackColor = false
		AddHandler Me.btnEliminar.Click, AddressOf Me.BtnEliminarClick
		'
		'lbltBuscar
		'
		Me.lbltBuscar.Font = New System.Drawing.Font("Agency FB", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.lbltBuscar.ForeColor = System.Drawing.Color.White
		Me.lbltBuscar.Location = New System.Drawing.Point(25, 205)
		Me.lbltBuscar.Name = "lbltBuscar"
		Me.lbltBuscar.Size = New System.Drawing.Size(98, 37)
		Me.lbltBuscar.TabIndex = 112
		Me.lbltBuscar.Text = "Buscar"
		Me.lbltBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'btnModificar
		'
		Me.btnModificar.BackColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(104,Byte),Integer), CType(CType(130,Byte),Integer))
		Me.btnModificar.Font = New System.Drawing.Font("Agency FB", 18!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.btnModificar.ForeColor = System.Drawing.Color.White
		Me.btnModificar.Image = CType(resources.GetObject("btnModificar.Image"),System.Drawing.Image)
		Me.btnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.btnModificar.Location = New System.Drawing.Point(650, 135)
		Me.btnModificar.Name = "btnModificar"
		Me.btnModificar.Size = New System.Drawing.Size(191, 47)
		Me.btnModificar.TabIndex = 113
		Me.btnModificar.Text = " Editar"
		Me.btnModificar.UseVisualStyleBackColor = false
		AddHandler Me.btnModificar.Click, AddressOf Me.BtnModificarClick
		'
		'dGVTipProductos
		'
		dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
		dataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver
		dataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!)
		dataGridViewCellStyle1.ForeColor = System.Drawing.Color.WhiteSmoke
		dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Gray
		dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Silver
		dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
		Me.dGVTipProductos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1
		Me.dGVTipProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
		Me.dGVTipProductos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
		Me.dGVTipProductos.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(104,Byte),Integer), CType(CType(130,Byte),Integer))
		Me.dGVTipProductos.BorderStyle = System.Windows.Forms.BorderStyle.None
		dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
		dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ButtonShadow
		dataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.InactiveCaption
		dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
		dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.GradientInactiveCaption
		dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
		Me.dGVTipProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2
		Me.dGVTipProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
		dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Highlight
		dataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Red
		dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightSkyBlue
		dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Gray
		dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
		Me.dGVTipProductos.DefaultCellStyle = dataGridViewCellStyle3
		Me.dGVTipProductos.GridColor = System.Drawing.SystemColors.Control
		Me.dGVTipProductos.Location = New System.Drawing.Point(25, 259)
		Me.dGVTipProductos.Name = "dGVTipProductos"
		dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
		dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.WindowFrame
		dataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
		dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
		dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
		dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.GradientInactiveCaption
		dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
		Me.dGVTipProductos.RowHeadersDefaultCellStyle = dataGridViewCellStyle4
		Me.dGVTipProductos.RowHeadersVisible = false
		Me.dGVTipProductos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
		Me.dGVTipProductos.Size = New System.Drawing.Size(816, 200)
		Me.dGVTipProductos.TabIndex = 115
		AddHandler Me.dGVTipProductos.CellClick, AddressOf Me.DGVTipProductosCellClick
		'
		'textBclave
		'
		Me.textBclave.BackColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(104,Byte),Integer), CType(CType(130,Byte),Integer))
		Me.textBclave.Font = New System.Drawing.Font("Agency FB", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic),System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.textBclave.ForeColor = System.Drawing.Color.LightGray
		Me.textBclave.Location = New System.Drawing.Point(101, 210)
		Me.textBclave.Name = "textBclave"
		Me.textBclave.Size = New System.Drawing.Size(257, 33)
		Me.textBclave.TabIndex = 116
		Me.textBclave.Text = "Clave"
		AddHandler Me.textBclave.Click, AddressOf Me.TextBclaveClick
		AddHandler Me.textBclave.TextChanged, AddressOf Me.TextBox1TextChanged
		'
		'txtDesc
		'
		Me.txtDesc.BackColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(104,Byte),Integer), CType(CType(130,Byte),Integer))
		Me.txtDesc.Font = New System.Drawing.Font("Agency FB", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic),System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.txtDesc.ForeColor = System.Drawing.Color.LightGray
		Me.txtDesc.Location = New System.Drawing.Point(374, 210)
		Me.txtDesc.Name = "txtDesc"
		Me.txtDesc.Size = New System.Drawing.Size(257, 33)
		Me.txtDesc.TabIndex = 117
		Me.txtDesc.Text = "Descripcion"
		AddHandler Me.txtDesc.Click, AddressOf Me.TxtDescClick
		AddHandler Me.txtDesc.TextChanged, AddressOf Me.TxtDescTextChanged
		'
		'FrmTipoProducto
		'
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(104,Byte),Integer), CType(CType(130,Byte),Integer))
		Me.ClientSize = New System.Drawing.Size(867, 465)
		Me.Controls.Add(Me.txtDesc)
		Me.Controls.Add(Me.textBclave)
		Me.Controls.Add(Me.dGVTipProductos)
		Me.Controls.Add(Me.btnModificar)
		Me.Controls.Add(Me.lbltBuscar)
		Me.Controls.Add(Me.btnEliminar)
		Me.Controls.Add(Me.btnRegistrar)
		Me.Controls.Add(Me.txtDescripcion)
		Me.Controls.Add(Me.txtClaveTipo)
		Me.Controls.Add(Me.lblTitulo)
		Me.Name = "FrmTipoProducto"
		Me.Text = "FrmTipoProducto"
		AddHandler Load, AddressOf Me.FrmTipoProductoLoad
		CType(Me.dGVTipProductos,System.ComponentModel.ISupportInitialize).EndInit
		Me.ResumeLayout(false)
		Me.PerformLayout
	End Sub
	Private txtDesc As System.Windows.Forms.TextBox
	Private textBclave As System.Windows.Forms.TextBox
	Private dGVTipProductos As System.Windows.Forms.DataGridView
	Private btnRegistrar As System.Windows.Forms.Button
	Private btnEliminar As System.Windows.Forms.Button
	Private lbltBuscar As System.Windows.Forms.Label
	Private btnModificar As System.Windows.Forms.Button
	Private txtClaveTipo As System.Windows.Forms.TextBox
	Private txtDescripcion As System.Windows.Forms.TextBox
	Private lblTitulo As System.Windows.Forms.Label
End Class
