'
' Created by SharpDevelop.
' User: Gustavo
' Date: 19/02/2022
' Time: 06:46 p. m.
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Partial Class FrmRegistroProveedor
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmRegistroProveedor))
		Me.txtTelefono = New System.Windows.Forms.TextBox()
		Me.txtCorreo = New System.Windows.Forms.TextBox()
		Me.txtNombre = New System.Windows.Forms.TextBox()
		Me.LblTitulo = New System.Windows.Forms.Label()
		Me.txtRfc = New System.Windows.Forms.TextBox()
		Me.cmBCalificacion = New System.Windows.Forms.ComboBox()
		Me.btnLimpiar = New System.Windows.Forms.Button()
		Me.btnRegistrar = New System.Windows.Forms.Button()
		Me.SuspendLayout
		'
		'txtTelefono
		'
		Me.txtTelefono.BackColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(104,Byte),Integer), CType(CType(130,Byte),Integer))
		Me.txtTelefono.Font = New System.Drawing.Font("Agency FB", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.txtTelefono.ForeColor = System.Drawing.Color.LightGray
		Me.txtTelefono.Location = New System.Drawing.Point(68, 181)
		Me.txtTelefono.Name = "txtTelefono"
		Me.txtTelefono.Size = New System.Drawing.Size(354, 33)
		Me.txtTelefono.TabIndex = 52
		Me.txtTelefono.Text = "Telefono"
		AddHandler Me.txtTelefono.Click, AddressOf Me.TxtTelefonoClick
		'
		'txtCorreo
		'
		Me.txtCorreo.BackColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(104,Byte),Integer), CType(CType(130,Byte),Integer))
		Me.txtCorreo.Font = New System.Drawing.Font("Agency FB", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.txtCorreo.ForeColor = System.Drawing.Color.LightGray
		Me.txtCorreo.Location = New System.Drawing.Point(68, 142)
		Me.txtCorreo.Name = "txtCorreo"
		Me.txtCorreo.Size = New System.Drawing.Size(354, 33)
		Me.txtCorreo.TabIndex = 51
		Me.txtCorreo.Text = "Correo"
		AddHandler Me.txtCorreo.Click, AddressOf Me.TxtCorreoClick
		'
		'txtNombre
		'
		Me.txtNombre.BackColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(104,Byte),Integer), CType(CType(130,Byte),Integer))
		Me.txtNombre.Font = New System.Drawing.Font("Agency FB", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.txtNombre.ForeColor = System.Drawing.Color.LightGray
		Me.txtNombre.Location = New System.Drawing.Point(68, 104)
		Me.txtNombre.Name = "txtNombre"
		Me.txtNombre.Size = New System.Drawing.Size(354, 33)
		Me.txtNombre.TabIndex = 50
		Me.txtNombre.Text = "Nombre"
		AddHandler Me.txtNombre.Click, AddressOf Me.TxtNombreClick
		'
		'LblTitulo
		'
		Me.LblTitulo.Dock = System.Windows.Forms.DockStyle.Top
		Me.LblTitulo.Font = New System.Drawing.Font("Agency FB", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.LblTitulo.ForeColor = System.Drawing.Color.White
		Me.LblTitulo.Location = New System.Drawing.Point(0, 0)
		Me.LblTitulo.Name = "LblTitulo"
		Me.LblTitulo.Size = New System.Drawing.Size(626, 31)
		Me.LblTitulo.TabIndex = 49
		Me.LblTitulo.Text = "REGISTRO DE PROVEEDORES"
		Me.LblTitulo.TextAlign = System.Drawing.ContentAlignment.TopCenter
		'
		'txtRfc
		'
		Me.txtRfc.BackColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(104,Byte),Integer), CType(CType(130,Byte),Integer))
		Me.txtRfc.Font = New System.Drawing.Font("Agency FB", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.txtRfc.ForeColor = System.Drawing.Color.LightGray
		Me.txtRfc.Location = New System.Drawing.Point(68, 65)
		Me.txtRfc.Name = "txtRfc"
		Me.txtRfc.Size = New System.Drawing.Size(354, 33)
		Me.txtRfc.TabIndex = 48
		Me.txtRfc.Text = "RFC"
		AddHandler Me.txtRfc.Click, AddressOf Me.TxtRfcClick
		'
		'cmBCalificacion
		'
		Me.cmBCalificacion.BackColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(104,Byte),Integer), CType(CType(130,Byte),Integer))
		Me.cmBCalificacion.Font = New System.Drawing.Font("Agency FB", 15!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.cmBCalificacion.ForeColor = System.Drawing.Color.LightGray
		Me.cmBCalificacion.FormattingEnabled = true
		Me.cmBCalificacion.Location = New System.Drawing.Point(68, 221)
		Me.cmBCalificacion.Name = "cmBCalificacion"
		Me.cmBCalificacion.Size = New System.Drawing.Size(354, 32)
		Me.cmBCalificacion.TabIndex = 53
		Me.cmBCalificacion.Text = "Calificacion"
		'
		'btnLimpiar
		'
		Me.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(104,Byte),Integer), CType(CType(130,Byte),Integer))
		Me.btnLimpiar.Font = New System.Drawing.Font("Agency FB", 18!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.btnLimpiar.ForeColor = System.Drawing.Color.White
		Me.btnLimpiar.Image = CType(resources.GetObject("btnLimpiar.Image"),System.Drawing.Image)
		Me.btnLimpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.btnLimpiar.Location = New System.Drawing.Point(274, 275)
		Me.btnLimpiar.Name = "btnLimpiar"
		Me.btnLimpiar.Size = New System.Drawing.Size(148, 46)
		Me.btnLimpiar.TabIndex = 56
		Me.btnLimpiar.Text = "    LIMPIAR"
		Me.btnLimpiar.UseVisualStyleBackColor = false
		AddHandler Me.btnLimpiar.Click, AddressOf Me.BtnLimpiarClick
		'
		'btnRegistrar
		'
		Me.btnRegistrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(104,Byte),Integer), CType(CType(130,Byte),Integer))
		Me.btnRegistrar.Font = New System.Drawing.Font("Agency FB", 18!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.btnRegistrar.ForeColor = System.Drawing.Color.White
		Me.btnRegistrar.Image = CType(resources.GetObject("btnRegistrar.Image"),System.Drawing.Image)
		Me.btnRegistrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.btnRegistrar.Location = New System.Drawing.Point(68, 275)
		Me.btnRegistrar.Name = "btnRegistrar"
		Me.btnRegistrar.Size = New System.Drawing.Size(172, 46)
		Me.btnRegistrar.TabIndex = 55
		Me.btnRegistrar.Text = "   Registrar"
		Me.btnRegistrar.UseVisualStyleBackColor = false
		AddHandler Me.btnRegistrar.Click, AddressOf Me.BtnRegistrarClick
		'
		'FrmRegistroProveedor
		'
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(104,Byte),Integer), CType(CType(130,Byte),Integer))
		Me.ClientSize = New System.Drawing.Size(626, 382)
		Me.Controls.Add(Me.btnLimpiar)
		Me.Controls.Add(Me.btnRegistrar)
		Me.Controls.Add(Me.cmBCalificacion)
		Me.Controls.Add(Me.txtTelefono)
		Me.Controls.Add(Me.txtCorreo)
		Me.Controls.Add(Me.txtNombre)
		Me.Controls.Add(Me.LblTitulo)
		Me.Controls.Add(Me.txtRfc)
		Me.Name = "FrmRegistroProveedor"
		Me.Text = "RegistroProveedor"
		Me.ResumeLayout(false)
		Me.PerformLayout
	End Sub
	Private btnRegistrar As System.Windows.Forms.Button
	Private btnLimpiar As System.Windows.Forms.Button
	Private cmBCalificacion As System.Windows.Forms.ComboBox
	Private txtRfc As System.Windows.Forms.TextBox
	Private LblTitulo As System.Windows.Forms.Label
	Private txtNombre As System.Windows.Forms.TextBox
	Private txtCorreo As System.Windows.Forms.TextBox
	Private txtTelefono As System.Windows.Forms.TextBox
End Class
