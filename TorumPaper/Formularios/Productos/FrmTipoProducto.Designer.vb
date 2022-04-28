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
		Me.lblTitulo = New System.Windows.Forms.Label()
		Me.txtDescripcion = New System.Windows.Forms.TextBox()
		Me.txtClaveTipo = New System.Windows.Forms.TextBox()
		Me.btnLimpiar = New System.Windows.Forms.Button()
		Me.btnRegistrar = New System.Windows.Forms.Button()
		Me.btnEliminar = New System.Windows.Forms.Button()
		Me.btnActualizar = New System.Windows.Forms.Button()
		Me.lbltBuscar = New System.Windows.Forms.Label()
		Me.btnBuscar = New System.Windows.Forms.Button()
		Me.dGVTipProductos = New System.Windows.Forms.DataGridView()
		Me.textBclave = New System.Windows.Forms.TextBox()
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
		AddHandler Me.txtClaveTipo.TextChanged, AddressOf Me.TxtClaveMarcaTextChanged
		'
		'btnLimpiar
		'
		Me.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(104,Byte),Integer), CType(CType(130,Byte),Integer))
		Me.btnLimpiar.Font = New System.Drawing.Font("Agency FB", 18!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.btnLimpiar.ForeColor = System.Drawing.Color.White
		Me.btnLimpiar.Image = CType(resources.GetObject("btnLimpiar.Image"),System.Drawing.Image)
		Me.btnLimpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.btnLimpiar.Location = New System.Drawing.Point(650, 135)
		Me.btnLimpiar.Name = "btnLimpiar"
		Me.btnLimpiar.Size = New System.Drawing.Size(191, 55)
		Me.btnLimpiar.TabIndex = 108
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
		Me.btnEliminar.Location = New System.Drawing.Point(650, 316)
		Me.btnEliminar.Name = "btnEliminar"
		Me.btnEliminar.Size = New System.Drawing.Size(191, 51)
		Me.btnEliminar.TabIndex = 110
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
		Me.btnActualizar.Location = New System.Drawing.Point(650, 381)
		Me.btnActualizar.Name = "btnActualizar"
		Me.btnActualizar.Size = New System.Drawing.Size(191, 47)
		Me.btnActualizar.TabIndex = 111
		Me.btnActualizar.Text = "   Actualizar"
		Me.btnActualizar.UseVisualStyleBackColor = false
		AddHandler Me.btnActualizar.Click, AddressOf Me.BtnActualizarClick
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
		'btnBuscar
		'
		Me.btnBuscar.BackColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(104,Byte),Integer), CType(CType(130,Byte),Integer))
		Me.btnBuscar.Font = New System.Drawing.Font("Agency FB", 18!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.btnBuscar.ForeColor = System.Drawing.Color.White
		Me.btnBuscar.Image = CType(resources.GetObject("btnBuscar.Image"),System.Drawing.Image)
		Me.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.btnBuscar.Location = New System.Drawing.Point(650, 248)
		Me.btnBuscar.Name = "btnBuscar"
		Me.btnBuscar.Size = New System.Drawing.Size(191, 47)
		Me.btnBuscar.TabIndex = 113
		Me.btnBuscar.Text = " Editar"
		Me.btnBuscar.UseVisualStyleBackColor = false
		'
		'dGVTipProductos
		'
		Me.dGVTipProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
		Me.dGVTipProductos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
		Me.dGVTipProductos.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(104,Byte),Integer), CType(CType(130,Byte),Integer))
		Me.dGVTipProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
		dataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver
		dataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
		dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White
		dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
		dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
		Me.dGVTipProductos.DefaultCellStyle = dataGridViewCellStyle1
		Me.dGVTipProductos.Location = New System.Drawing.Point(25, 259)
		Me.dGVTipProductos.Name = "dGVTipProductos"
		Me.dGVTipProductos.Size = New System.Drawing.Size(606, 180)
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
		Me.textBclave.Size = New System.Drawing.Size(530, 33)
		Me.textBclave.TabIndex = 116
		Me.textBclave.Text = "Buscar por clave"
		AddHandler Me.textBclave.TextChanged, AddressOf Me.TextBox1TextChanged
		'
		'FrmTipoProducto
		'
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(104,Byte),Integer), CType(CType(130,Byte),Integer))
		Me.ClientSize = New System.Drawing.Size(867, 465)
		Me.Controls.Add(Me.textBclave)
		Me.Controls.Add(Me.dGVTipProductos)
		Me.Controls.Add(Me.btnBuscar)
		Me.Controls.Add(Me.lbltBuscar)
		Me.Controls.Add(Me.btnActualizar)
		Me.Controls.Add(Me.btnEliminar)
		Me.Controls.Add(Me.btnLimpiar)
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
	Private textBclave As System.Windows.Forms.TextBox
	Private dGVTipProductos As System.Windows.Forms.DataGridView
	Private btnRegistrar As System.Windows.Forms.Button
	Private btnLimpiar As System.Windows.Forms.Button
	Private btnEliminar As System.Windows.Forms.Button
	Private btnActualizar As System.Windows.Forms.Button
	Private lbltBuscar As System.Windows.Forms.Label
	Private btnBuscar As System.Windows.Forms.Button
	Private txtClaveTipo As System.Windows.Forms.TextBox
	Private txtDescripcion As System.Windows.Forms.TextBox
	Private lblTitulo As System.Windows.Forms.Label
End Class
