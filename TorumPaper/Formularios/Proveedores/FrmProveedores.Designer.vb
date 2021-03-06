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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmProveedores))
		Dim dataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Me.lblTitulo = New System.Windows.Forms.Label()
		Me.lblCalificacion = New System.Windows.Forms.Label()
		Me.nUDCalificacion = New System.Windows.Forms.NumericUpDown()
		Me.txtTelefono = New System.Windows.Forms.TextBox()
		Me.txtCorreo = New System.Windows.Forms.TextBox()
		Me.txtNombre = New System.Windows.Forms.TextBox()
		Me.txtRfc = New System.Windows.Forms.TextBox()
		Me.btnBuscar = New System.Windows.Forms.Button()
		Me.lbltBuscar = New System.Windows.Forms.Label()
		Me.btnActualizar = New System.Windows.Forms.Button()
		Me.btnEliminar = New System.Windows.Forms.Button()
		Me.btnLimpiar = New System.Windows.Forms.Button()
		Me.btnRegistrar = New System.Windows.Forms.Button()
		Me.txtBuscarRFC = New System.Windows.Forms.TextBox()
		Me.cmbCalifAsc = New System.Windows.Forms.ComboBox()
		Me.txtBuscarNombreProv = New System.Windows.Forms.TextBox()
		Me.dGVProveedores = New System.Windows.Forms.DataGridView()
		CType(Me.nUDCalificacion,System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.dGVProveedores,System.ComponentModel.ISupportInitialize).BeginInit
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
		Me.lblCalificacion.Location = New System.Drawing.Point(21, 154)
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
		Me.nUDCalificacion.Location = New System.Drawing.Point(127, 153)
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
		Me.txtTelefono.Location = New System.Drawing.Point(339, 112)
		Me.txtTelefono.Name = "txtTelefono"
		Me.txtTelefono.Size = New System.Drawing.Size(301, 33)
		Me.txtTelefono.TabIndex = 93
		Me.txtTelefono.Text = "Telefono"
		'
		'txtCorreo
		'
		Me.txtCorreo.BackColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(104,Byte),Integer), CType(CType(130,Byte),Integer))
		Me.txtCorreo.Font = New System.Drawing.Font("Agency FB", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic),System.Drawing.FontStyle))
		Me.txtCorreo.ForeColor = System.Drawing.Color.LightGray
		Me.txtCorreo.Location = New System.Drawing.Point(21, 112)
		Me.txtCorreo.Name = "txtCorreo"
		Me.txtCorreo.Size = New System.Drawing.Size(301, 33)
		Me.txtCorreo.TabIndex = 92
		Me.txtCorreo.Text = "Correo"
		'
		'txtNombre
		'
		Me.txtNombre.BackColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(104,Byte),Integer), CType(CType(130,Byte),Integer))
		Me.txtNombre.Font = New System.Drawing.Font("Agency FB", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic),System.Drawing.FontStyle))
		Me.txtNombre.ForeColor = System.Drawing.Color.LightGray
		Me.txtNombre.Location = New System.Drawing.Point(339, 73)
		Me.txtNombre.Name = "txtNombre"
		Me.txtNombre.Size = New System.Drawing.Size(301, 33)
		Me.txtNombre.TabIndex = 91
		Me.txtNombre.Text = "Nombre"
		'
		'txtRfc
		'
		Me.txtRfc.BackColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(104,Byte),Integer), CType(CType(130,Byte),Integer))
		Me.txtRfc.Font = New System.Drawing.Font("Agency FB", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic),System.Drawing.FontStyle))
		Me.txtRfc.ForeColor = System.Drawing.Color.LightGray
		Me.txtRfc.Location = New System.Drawing.Point(21, 73)
		Me.txtRfc.Name = "txtRfc"
		Me.txtRfc.Size = New System.Drawing.Size(301, 33)
		Me.txtRfc.TabIndex = 90
		Me.txtRfc.Text = "RFC"
		'
		'btnBuscar
		'
		Me.btnBuscar.BackColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(104,Byte),Integer), CType(CType(130,Byte),Integer))
		Me.btnBuscar.Font = New System.Drawing.Font("Agency FB", 18!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.btnBuscar.ForeColor = System.Drawing.Color.White
		Me.btnBuscar.Image = CType(resources.GetObject("btnBuscar.Image"),System.Drawing.Image)
		Me.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.btnBuscar.Location = New System.Drawing.Point(662, 248)
		Me.btnBuscar.Name = "btnBuscar"
		Me.btnBuscar.Size = New System.Drawing.Size(191, 47)
		Me.btnBuscar.TabIndex = 110
		Me.btnBuscar.Text = "Editar"
		Me.btnBuscar.UseVisualStyleBackColor = false
		'
		'lbltBuscar
		'
		Me.lbltBuscar.Font = New System.Drawing.Font("Agency FB", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.lbltBuscar.ForeColor = System.Drawing.Color.White
		Me.lbltBuscar.Location = New System.Drawing.Point(25, 205)
		Me.lbltBuscar.Name = "lbltBuscar"
		Me.lbltBuscar.Size = New System.Drawing.Size(98, 37)
		Me.lbltBuscar.TabIndex = 109
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
		Me.btnActualizar.Location = New System.Drawing.Point(662, 381)
		Me.btnActualizar.Name = "btnActualizar"
		Me.btnActualizar.Size = New System.Drawing.Size(191, 47)
		Me.btnActualizar.TabIndex = 108
		Me.btnActualizar.Text = "   Actualizar"
		Me.btnActualizar.UseVisualStyleBackColor = false
		AddHandler Me.btnActualizar.Click, AddressOf Me.BtnActualizarClick
		'
		'btnEliminar
		'
		Me.btnEliminar.BackColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(104,Byte),Integer), CType(CType(130,Byte),Integer))
		Me.btnEliminar.Font = New System.Drawing.Font("Agency FB", 18!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.btnEliminar.ForeColor = System.Drawing.Color.White
		Me.btnEliminar.Image = CType(resources.GetObject("btnEliminar.Image"),System.Drawing.Image)
		Me.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.btnEliminar.Location = New System.Drawing.Point(662, 312)
		Me.btnEliminar.Name = "btnEliminar"
		Me.btnEliminar.Size = New System.Drawing.Size(191, 51)
		Me.btnEliminar.TabIndex = 107
		Me.btnEliminar.Text = "Eliminar"
		Me.btnEliminar.UseVisualStyleBackColor = false
		'
		'btnLimpiar
		'
		Me.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(104,Byte),Integer), CType(CType(130,Byte),Integer))
		Me.btnLimpiar.Font = New System.Drawing.Font("Agency FB", 18!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.btnLimpiar.ForeColor = System.Drawing.Color.White
		Me.btnLimpiar.Image = CType(resources.GetObject("btnLimpiar.Image"),System.Drawing.Image)
		Me.btnLimpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.btnLimpiar.Location = New System.Drawing.Point(662, 128)
		Me.btnLimpiar.Name = "btnLimpiar"
		Me.btnLimpiar.Size = New System.Drawing.Size(191, 55)
		Me.btnLimpiar.TabIndex = 105
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
		Me.txtBuscarRFC.Location = New System.Drawing.Point(129, 211)
		Me.txtBuscarRFC.Name = "txtBuscarRFC"
		Me.txtBuscarRFC.Size = New System.Drawing.Size(177, 33)
		Me.txtBuscarRFC.TabIndex = 113
		Me.txtBuscarRFC.Text = "Buscar por RFC"
		AddHandler Me.txtBuscarRFC.TextChanged, AddressOf Me.TxtBuscarRFCTextChanged
		'
		'cmbCalifAsc
		'
		Me.cmbCalifAsc.BackColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(104,Byte),Integer), CType(CType(130,Byte),Integer))
		Me.cmbCalifAsc.Font = New System.Drawing.Font("Agency FB", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic),System.Drawing.FontStyle))
		Me.cmbCalifAsc.ForeColor = System.Drawing.Color.White
		Me.cmbCalifAsc.FormattingEnabled = true
		Me.cmbCalifAsc.Items.AddRange(New Object() {"Calificación Ascendente", "Calificación Descendente"})
		Me.cmbCalifAsc.Location = New System.Drawing.Point(465, 211)
		Me.cmbCalifAsc.Name = "cmbCalifAsc"
		Me.cmbCalifAsc.Size = New System.Drawing.Size(175, 33)
		Me.cmbCalifAsc.TabIndex = 112
		Me.cmbCalifAsc.Text = "Calificación Ascendente"
		'
		'txtBuscarNombreProv
		'
		Me.txtBuscarNombreProv.BackColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(104,Byte),Integer), CType(CType(130,Byte),Integer))
		Me.txtBuscarNombreProv.Font = New System.Drawing.Font("Agency FB", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic),System.Drawing.FontStyle))
		Me.txtBuscarNombreProv.ForeColor = System.Drawing.Color.White
		Me.txtBuscarNombreProv.Location = New System.Drawing.Point(312, 211)
		Me.txtBuscarNombreProv.Name = "txtBuscarNombreProv"
		Me.txtBuscarNombreProv.Size = New System.Drawing.Size(147, 33)
		Me.txtBuscarNombreProv.TabIndex = 111
		Me.txtBuscarNombreProv.Text = "Buscar por nombre"
		AddHandler Me.txtBuscarNombreProv.TextChanged, AddressOf Me.TextBoxFiltroNombreProveedorTextChanged
		'
		'dGVProveedores
		'
		Me.dGVProveedores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
		Me.dGVProveedores.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
		Me.dGVProveedores.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(104,Byte),Integer), CType(CType(130,Byte),Integer))
		Me.dGVProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
		dataGridViewCellStyle2.BackColor = System.Drawing.Color.Silver
		dataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
		dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White
		dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
		dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
		Me.dGVProveedores.DefaultCellStyle = dataGridViewCellStyle2
		Me.dGVProveedores.Location = New System.Drawing.Point(25, 273)
		Me.dGVProveedores.Name = "dGVProveedores"
		Me.dGVProveedores.Size = New System.Drawing.Size(615, 180)
		Me.dGVProveedores.TabIndex = 114
		'
		'FrmProveedores
		'
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(104,Byte),Integer), CType(CType(130,Byte),Integer))
		Me.ClientSize = New System.Drawing.Size(886, 465)
		Me.Controls.Add(Me.dGVProveedores)
		Me.Controls.Add(Me.txtBuscarRFC)
		Me.Controls.Add(Me.cmbCalifAsc)
		Me.Controls.Add(Me.txtBuscarNombreProv)
		Me.Controls.Add(Me.btnBuscar)
		Me.Controls.Add(Me.lbltBuscar)
		Me.Controls.Add(Me.btnActualizar)
		Me.Controls.Add(Me.btnEliminar)
		Me.Controls.Add(Me.btnLimpiar)
		Me.Controls.Add(Me.btnRegistrar)
		Me.Controls.Add(Me.lblCalificacion)
		Me.Controls.Add(Me.nUDCalificacion)
		Me.Controls.Add(Me.txtTelefono)
		Me.Controls.Add(Me.txtCorreo)
		Me.Controls.Add(Me.txtNombre)
		Me.Controls.Add(Me.txtRfc)
		Me.Controls.Add(Me.lblTitulo)
		Me.Name = "FrmProveedores"
		Me.Text = "FrmProveedores"
		AddHandler Load, AddressOf Me.FrmProveedoresLoad
		CType(Me.nUDCalificacion,System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.dGVProveedores,System.ComponentModel.ISupportInitialize).EndInit
		Me.ResumeLayout(false)
		Me.PerformLayout
	End Sub
	Private dGVProveedores As System.Windows.Forms.DataGridView
	Private txtBuscarNombreProv As System.Windows.Forms.TextBox
	Private cmbCalifAsc As System.Windows.Forms.ComboBox
	Private txtBuscarRFC As System.Windows.Forms.TextBox
	Private btnRegistrar As System.Windows.Forms.Button
	Private btnLimpiar As System.Windows.Forms.Button
	Private btnEliminar As System.Windows.Forms.Button
	Private btnActualizar As System.Windows.Forms.Button
	Private lbltBuscar As System.Windows.Forms.Label
	Private btnBuscar As System.Windows.Forms.Button
	Private txtRfc As System.Windows.Forms.TextBox
	Private txtNombre As System.Windows.Forms.TextBox
	Private txtCorreo As System.Windows.Forms.TextBox
	Private txtTelefono As System.Windows.Forms.TextBox
	Private nUDCalificacion As System.Windows.Forms.NumericUpDown
	Private lblCalificacion As System.Windows.Forms.Label
	Private lblTitulo As System.Windows.Forms.Label
End Class
