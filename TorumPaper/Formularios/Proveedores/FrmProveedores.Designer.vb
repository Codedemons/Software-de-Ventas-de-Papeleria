'
' Created by SharpDevelop.
' User: Coderp
' Date: 15/03/2022
' Time: 13:28
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Partial Class FrmProveedores
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmProveedores))
		Dim dataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Dim dataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Dim dataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Dim dataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Me.lblTitulo = New System.Windows.Forms.Label()
		Me.lblCalificacion = New System.Windows.Forms.Label()
		Me.nUDCalificacion = New System.Windows.Forms.NumericUpDown()
		Me.txtTelefono = New System.Windows.Forms.TextBox()
		Me.txtCorreo = New System.Windows.Forms.TextBox()
		Me.txtNombre = New System.Windows.Forms.TextBox()
		Me.txtRfc = New System.Windows.Forms.TextBox()
		Me.btnEditar = New System.Windows.Forms.Button()
		Me.lbltBuscar = New System.Windows.Forms.Label()
		Me.btnEliminar = New System.Windows.Forms.Button()
		Me.btnRegistrar = New System.Windows.Forms.Button()
		Me.txtBuscarRFC = New System.Windows.Forms.TextBox()
		Me.txtBuscarNombreProv = New System.Windows.Forms.TextBox()
		Me.dGVProveedores = New System.Windows.Forms.DataGridView()
		Me.lblTell = New System.Windows.Forms.Label()
		Me.lblNombre = New System.Windows.Forms.Label()
		Me.lblCorreo = New System.Windows.Forms.Label()
		Me.lblRFC = New System.Windows.Forms.Label()
		Me.lblBRFC = New System.Windows.Forms.Label()
		Me.lblBNombre = New System.Windows.Forms.Label()
		Me.ErrorPR = New System.Windows.Forms.ErrorProvider(Me.components)
		Me.ErrorPNom = New System.Windows.Forms.ErrorProvider(Me.components)
		Me.ErrorPCorr = New System.Windows.Forms.ErrorProvider(Me.components)
		Me.ErrorPTell = New System.Windows.Forms.ErrorProvider(Me.components)
		CType(Me.nUDCalificacion,System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.dGVProveedores,System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.ErrorPR,System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.ErrorPNom,System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.ErrorPCorr,System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.ErrorPTell,System.ComponentModel.ISupportInitialize).BeginInit
		Me.SuspendLayout
		'
		'lblTitulo
		'
		Me.lblTitulo.Dock = System.Windows.Forms.DockStyle.Top
		Me.lblTitulo.Font = New System.Drawing.Font("Agency FB", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.lblTitulo.ForeColor = System.Drawing.Color.White
		Me.lblTitulo.Location = New System.Drawing.Point(0, 0)
		Me.lblTitulo.Name = "lblTitulo"
		Me.lblTitulo.Size = New System.Drawing.Size(886, 69)
		Me.lblTitulo.TabIndex = 89
		Me.lblTitulo.Text = "Proveedores  TorumPaper"
		Me.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'lblCalificacion
		'
		Me.lblCalificacion.Font = New System.Drawing.Font("Agency FB", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic),System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.lblCalificacion.ForeColor = System.Drawing.Color.White
		Me.lblCalificacion.Location = New System.Drawing.Point(18, 167)
		Me.lblCalificacion.Name = "lblCalificacion"
		Me.lblCalificacion.Size = New System.Drawing.Size(100, 30)
		Me.lblCalificacion.TabIndex = 95
		Me.lblCalificacion.Text = "Calificacion"
		'
		'nUDCalificacion
		'
		Me.nUDCalificacion.BackColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(104,Byte),Integer), CType(CType(130,Byte),Integer))
		Me.nUDCalificacion.Font = New System.Drawing.Font("Agency FB", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic),System.Drawing.FontStyle))
		Me.nUDCalificacion.ForeColor = System.Drawing.Color.White
		Me.nUDCalificacion.Location = New System.Drawing.Point(102, 167)
		Me.nUDCalificacion.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
		Me.nUDCalificacion.Name = "nUDCalificacion"
		Me.nUDCalificacion.Size = New System.Drawing.Size(195, 33)
		Me.nUDCalificacion.TabIndex = 94
		'
		'txtTelefono
		'
		Me.txtTelefono.BackColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(104,Byte),Integer), CType(CType(130,Byte),Integer))
		Me.txtTelefono.Font = New System.Drawing.Font("Agency FB", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic),System.Drawing.FontStyle))
		Me.txtTelefono.ForeColor = System.Drawing.Color.LightGray
		Me.txtTelefono.Location = New System.Drawing.Point(339, 129)
		Me.txtTelefono.Name = "txtTelefono"
		Me.txtTelefono.Size = New System.Drawing.Size(301, 33)
		Me.txtTelefono.TabIndex = 93
		Me.txtTelefono.Text = "Telefono"
		AddHandler Me.txtTelefono.Click, AddressOf Me.TxtTelefonoClick
		AddHandler Me.txtTelefono.KeyPress, AddressOf Me.TxtTelefonoKeyPress
		'
		'txtCorreo
		'
		Me.txtCorreo.BackColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(104,Byte),Integer), CType(CType(130,Byte),Integer))
		Me.txtCorreo.Font = New System.Drawing.Font("Agency FB", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic),System.Drawing.FontStyle))
		Me.txtCorreo.ForeColor = System.Drawing.Color.LightGray
		Me.txtCorreo.Location = New System.Drawing.Point(21, 129)
		Me.txtCorreo.Name = "txtCorreo"
		Me.txtCorreo.Size = New System.Drawing.Size(301, 33)
		Me.txtCorreo.TabIndex = 92
		Me.txtCorreo.Text = "Correo"
		AddHandler Me.txtCorreo.Click, AddressOf Me.TxtCorreoClick
		'
		'txtNombre
		'
		Me.txtNombre.BackColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(104,Byte),Integer), CType(CType(130,Byte),Integer))
		Me.txtNombre.Font = New System.Drawing.Font("Agency FB", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic),System.Drawing.FontStyle))
		Me.txtNombre.ForeColor = System.Drawing.Color.LightGray
		Me.txtNombre.Location = New System.Drawing.Point(339, 76)
		Me.txtNombre.Name = "txtNombre"
		Me.txtNombre.Size = New System.Drawing.Size(301, 33)
		Me.txtNombre.TabIndex = 91
		Me.txtNombre.Text = "Nombre"
		AddHandler Me.txtNombre.Click, AddressOf Me.TxtNombreClick
		'
		'txtRfc
		'
		Me.txtRfc.BackColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(104,Byte),Integer), CType(CType(130,Byte),Integer))
		Me.txtRfc.Font = New System.Drawing.Font("Agency FB", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic),System.Drawing.FontStyle))
		Me.txtRfc.ForeColor = System.Drawing.Color.LightGray
		Me.txtRfc.Location = New System.Drawing.Point(21, 76)
		Me.txtRfc.Name = "txtRfc"
		Me.txtRfc.Size = New System.Drawing.Size(301, 33)
		Me.txtRfc.TabIndex = 90
		Me.txtRfc.Text = "RFC"
		AddHandler Me.txtRfc.Click, AddressOf Me.TxtRfcClick
		'
		'btnEditar
		'
		Me.btnEditar.BackColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(104,Byte),Integer), CType(CType(130,Byte),Integer))
		Me.btnEditar.Font = New System.Drawing.Font("Agency FB", 18!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.btnEditar.ForeColor = System.Drawing.Color.White
		Me.btnEditar.Image = CType(resources.GetObject("btnEditar.Image"),System.Drawing.Image)
		Me.btnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.btnEditar.Location = New System.Drawing.Point(662, 131)
		Me.btnEditar.Name = "btnEditar"
		Me.btnEditar.Size = New System.Drawing.Size(191, 47)
		Me.btnEditar.TabIndex = 110
		Me.btnEditar.Text = "Editar"
		Me.btnEditar.UseVisualStyleBackColor = false
		AddHandler Me.btnEditar.Click, AddressOf Me.BtnEditarClick
		'
		'lbltBuscar
		'
		Me.lbltBuscar.Font = New System.Drawing.Font("Agency FB", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.lbltBuscar.ForeColor = System.Drawing.Color.White
		Me.lbltBuscar.Location = New System.Drawing.Point(25, 216)
		Me.lbltBuscar.Name = "lbltBuscar"
		Me.lbltBuscar.Size = New System.Drawing.Size(98, 37)
		Me.lbltBuscar.TabIndex = 109
		Me.lbltBuscar.Text = "Buscar"
		Me.lbltBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'btnEliminar
		'
		Me.btnEliminar.BackColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(104,Byte),Integer), CType(CType(130,Byte),Integer))
		Me.btnEliminar.Font = New System.Drawing.Font("Agency FB", 18!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.btnEliminar.ForeColor = System.Drawing.Color.White
		Me.btnEliminar.Image = CType(resources.GetObject("btnEliminar.Image"),System.Drawing.Image)
		Me.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.btnEliminar.Location = New System.Drawing.Point(662, 191)
		Me.btnEliminar.Name = "btnEliminar"
		Me.btnEliminar.Size = New System.Drawing.Size(191, 51)
		Me.btnEliminar.TabIndex = 107
		Me.btnEliminar.Text = "Eliminar"
		Me.btnEliminar.UseVisualStyleBackColor = false
		AddHandler Me.btnEliminar.Click, AddressOf Me.BtnEliminarClick
		'
		'btnRegistrar
		'
		Me.btnRegistrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(104,Byte),Integer), CType(CType(130,Byte),Integer))
		Me.btnRegistrar.Font = New System.Drawing.Font("Agency FB", 18!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.btnRegistrar.ForeColor = System.Drawing.Color.White
		Me.btnRegistrar.Image = CType(resources.GetObject("btnRegistrar.Image"),System.Drawing.Image)
		Me.btnRegistrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.btnRegistrar.Location = New System.Drawing.Point(662, 65)
		Me.btnRegistrar.Name = "btnRegistrar"
		Me.btnRegistrar.Size = New System.Drawing.Size(191, 57)
		Me.btnRegistrar.TabIndex = 104
		Me.btnRegistrar.Text = "   Registrar"
		Me.btnRegistrar.UseVisualStyleBackColor = false
		AddHandler Me.btnRegistrar.Click, AddressOf Me.BtnRegistrarClick
		'
		'txtBuscarRFC
		'
		Me.txtBuscarRFC.BackColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(104,Byte),Integer), CType(CType(130,Byte),Integer))
		Me.txtBuscarRFC.Font = New System.Drawing.Font("Agency FB", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic),System.Drawing.FontStyle))
		Me.txtBuscarRFC.ForeColor = System.Drawing.Color.White
		Me.txtBuscarRFC.Location = New System.Drawing.Point(129, 222)
		Me.txtBuscarRFC.Name = "txtBuscarRFC"
		Me.txtBuscarRFC.Size = New System.Drawing.Size(258, 33)
		Me.txtBuscarRFC.TabIndex = 113
		Me.txtBuscarRFC.Text = "RFC"
		AddHandler Me.txtBuscarRFC.Click, AddressOf Me.TxtBuscarRFCClick
		AddHandler Me.txtBuscarRFC.TextChanged, AddressOf Me.TxtBuscarRFCTextChanged
		'
		'txtBuscarNombreProv
		'
		Me.txtBuscarNombreProv.BackColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(104,Byte),Integer), CType(CType(130,Byte),Integer))
		Me.txtBuscarNombreProv.Font = New System.Drawing.Font("Agency FB", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic),System.Drawing.FontStyle))
		Me.txtBuscarNombreProv.ForeColor = System.Drawing.Color.White
		Me.txtBuscarNombreProv.Location = New System.Drawing.Point(393, 222)
		Me.txtBuscarNombreProv.Name = "txtBuscarNombreProv"
		Me.txtBuscarNombreProv.Size = New System.Drawing.Size(247, 33)
		Me.txtBuscarNombreProv.TabIndex = 111
		Me.txtBuscarNombreProv.Text = "Nombre"
		AddHandler Me.txtBuscarNombreProv.Click, AddressOf Me.TxtBuscarNombreProvClick
		AddHandler Me.txtBuscarNombreProv.TextChanged, AddressOf Me.TextBoxFiltroNombreProveedorTextChanged
		'
		'dGVProveedores
		'
		Me.dGVProveedores.AllowUserToAddRows = false
		dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
		dataGridViewCellStyle1.BackColor = System.Drawing.Color.DimGray
		dataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!)
		dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
		dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Gray
		dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
		dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
		Me.dGVProveedores.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1
		Me.dGVProveedores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
		Me.dGVProveedores.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
		Me.dGVProveedores.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(104,Byte),Integer), CType(CType(130,Byte),Integer))
		Me.dGVProveedores.BorderStyle = System.Windows.Forms.BorderStyle.None
		dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
		dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Highlight
		dataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
		dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
		dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.DimGray
		dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
		Me.dGVProveedores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2
		Me.dGVProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
		dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Highlight
		dataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
		dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightSkyBlue
		dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
		dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
		Me.dGVProveedores.DefaultCellStyle = dataGridViewCellStyle3
		Me.dGVProveedores.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
		Me.dGVProveedores.GridColor = System.Drawing.SystemColors.Control
		Me.dGVProveedores.Location = New System.Drawing.Point(25, 260)
		Me.dGVProveedores.Name = "dGVProveedores"
		dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
		dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.WindowFrame
		dataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
		dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
		dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
		dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
		dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
		Me.dGVProveedores.RowHeadersDefaultCellStyle = dataGridViewCellStyle4
		Me.dGVProveedores.RowHeadersVisible = false
		Me.dGVProveedores.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
		Me.dGVProveedores.Size = New System.Drawing.Size(828, 200)
		Me.dGVProveedores.TabIndex = 116
		AddHandler Me.dGVProveedores.CellClick, AddressOf Me.DGVProveedoresCellClick
		'
		'lblTell
		'
		Me.lblTell.Font = New System.Drawing.Font("Agency FB", 13.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic),System.Drawing.FontStyle))
		Me.lblTell.ForeColor = System.Drawing.Color.White
		Me.lblTell.Location = New System.Drawing.Point(336, 107)
		Me.lblTell.Name = "lblTell"
		Me.lblTell.Size = New System.Drawing.Size(100, 30)
		Me.lblTell.TabIndex = 117
		Me.lblTell.Text = "Telefono"
		Me.lblTell.Visible = false
		'
		'lblNombre
		'
		Me.lblNombre.Font = New System.Drawing.Font("Agency FB", 13.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic),System.Drawing.FontStyle))
		Me.lblNombre.ForeColor = System.Drawing.Color.White
		Me.lblNombre.Location = New System.Drawing.Point(336, 55)
		Me.lblNombre.Name = "lblNombre"
		Me.lblNombre.Size = New System.Drawing.Size(100, 30)
		Me.lblNombre.TabIndex = 118
		Me.lblNombre.Text = "Nombre"
		Me.lblNombre.Visible = false
		'
		'lblCorreo
		'
		Me.lblCorreo.Font = New System.Drawing.Font("Agency FB", 13.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic),System.Drawing.FontStyle))
		Me.lblCorreo.ForeColor = System.Drawing.Color.White
		Me.lblCorreo.Location = New System.Drawing.Point(18, 107)
		Me.lblCorreo.Name = "lblCorreo"
		Me.lblCorreo.Size = New System.Drawing.Size(100, 30)
		Me.lblCorreo.TabIndex = 119
		Me.lblCorreo.Text = "Correo"
		Me.lblCorreo.Visible = false
		'
		'lblRFC
		'
		Me.lblRFC.Font = New System.Drawing.Font("Agency FB", 13.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic),System.Drawing.FontStyle))
		Me.lblRFC.ForeColor = System.Drawing.Color.White
		Me.lblRFC.Location = New System.Drawing.Point(18, 55)
		Me.lblRFC.Name = "lblRFC"
		Me.lblRFC.Size = New System.Drawing.Size(100, 30)
		Me.lblRFC.TabIndex = 120
		Me.lblRFC.Text = "RFC"
		Me.lblRFC.Visible = false
		'
		'lblBRFC
		'
		Me.lblBRFC.Font = New System.Drawing.Font("Agency FB", 13.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic),System.Drawing.FontStyle))
		Me.lblBRFC.ForeColor = System.Drawing.Color.White
		Me.lblBRFC.Location = New System.Drawing.Point(129, 200)
		Me.lblBRFC.Name = "lblBRFC"
		Me.lblBRFC.Size = New System.Drawing.Size(100, 30)
		Me.lblBRFC.TabIndex = 121
		Me.lblBRFC.Text = "RFC"
		Me.lblBRFC.Visible = false
		'
		'lblBNombre
		'
		Me.lblBNombre.Font = New System.Drawing.Font("Agency FB", 13.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic),System.Drawing.FontStyle))
		Me.lblBNombre.ForeColor = System.Drawing.Color.White
		Me.lblBNombre.Location = New System.Drawing.Point(393, 200)
		Me.lblBNombre.Name = "lblBNombre"
		Me.lblBNombre.Size = New System.Drawing.Size(100, 30)
		Me.lblBNombre.TabIndex = 122
		Me.lblBNombre.Text = "Nombre"
		Me.lblBNombre.Visible = false
		'
		'ErrorPR
		'
		Me.ErrorPR.ContainerControl = Me
		'
		'ErrorPNom
		'
		Me.ErrorPNom.ContainerControl = Me
		'
		'ErrorPCorr
		'
		Me.ErrorPCorr.ContainerControl = Me
		'
		'ErrorPTell
		'
		Me.ErrorPTell.ContainerControl = Me
		'
		'FrmProveedores
		'
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(104,Byte),Integer), CType(CType(130,Byte),Integer))
		Me.ClientSize = New System.Drawing.Size(886, 465)
		Me.Controls.Add(Me.txtBuscarNombreProv)
		Me.Controls.Add(Me.lblBNombre)
		Me.Controls.Add(Me.txtBuscarRFC)
		Me.Controls.Add(Me.lblBRFC)
		Me.Controls.Add(Me.txtNombre)
		Me.Controls.Add(Me.txtCorreo)
		Me.Controls.Add(Me.txtRfc)
		Me.Controls.Add(Me.lblRFC)
		Me.Controls.Add(Me.lblCorreo)
		Me.Controls.Add(Me.lblNombre)
		Me.Controls.Add(Me.txtTelefono)
		Me.Controls.Add(Me.lblTell)
		Me.Controls.Add(Me.nUDCalificacion)
		Me.Controls.Add(Me.dGVProveedores)
		Me.Controls.Add(Me.btnEditar)
		Me.Controls.Add(Me.lbltBuscar)
		Me.Controls.Add(Me.btnEliminar)
		Me.Controls.Add(Me.btnRegistrar)
		Me.Controls.Add(Me.lblCalificacion)
		Me.Controls.Add(Me.lblTitulo)
		Me.Name = "FrmProveedores"
		Me.Text = "FrmProveedores"
		AddHandler Load, AddressOf Me.FrmProveedoresLoad
		CType(Me.nUDCalificacion,System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.dGVProveedores,System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.ErrorPR,System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.ErrorPNom,System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.ErrorPCorr,System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.ErrorPTell,System.ComponentModel.ISupportInitialize).EndInit
		Me.ResumeLayout(false)
		Me.PerformLayout
	End Sub
	Private ErrorPTell As System.Windows.Forms.ErrorProvider
	Private ErrorPCorr As System.Windows.Forms.ErrorProvider
	Private ErrorPNom As System.Windows.Forms.ErrorProvider
	Private ErrorPR As System.Windows.Forms.ErrorProvider
	Private lblBNombre As System.Windows.Forms.Label
	Private lblBRFC As System.Windows.Forms.Label
	Private lblRFC As System.Windows.Forms.Label
	Private lblCorreo As System.Windows.Forms.Label
	Private lblNombre As System.Windows.Forms.Label
	Private lblTell As System.Windows.Forms.Label
	Private dGVProveedores As System.Windows.Forms.DataGridView
	Private txtBuscarNombreProv As System.Windows.Forms.TextBox
	Private txtBuscarRFC As System.Windows.Forms.TextBox
	Private btnRegistrar As System.Windows.Forms.Button
	Private btnEliminar As System.Windows.Forms.Button
	Private lbltBuscar As System.Windows.Forms.Label
	Private btnEditar As System.Windows.Forms.Button
	Private txtRfc As System.Windows.Forms.TextBox
	Private txtNombre As System.Windows.Forms.TextBox
	Private txtCorreo As System.Windows.Forms.TextBox
	Private txtTelefono As System.Windows.Forms.TextBox
	Private nUDCalificacion As System.Windows.Forms.NumericUpDown
	Private lblCalificacion As System.Windows.Forms.Label
	Private lblTitulo As System.Windows.Forms.Label
End Class
