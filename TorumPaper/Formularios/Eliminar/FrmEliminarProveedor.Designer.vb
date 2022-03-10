'
' Created by SharpDevelop.
' User: Coderp
' Date: 19/02/2022
' Time: 15:30
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Partial Class FrmEliminarProveedor
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmEliminarProveedor))
		Me.lblTitulo = New System.Windows.Forms.Label()
		Me.btnBuscar = New System.Windows.Forms.Button()
		Me.btnLimpiar = New System.Windows.Forms.Button()
		Me.btnEliminar = New System.Windows.Forms.Button()
		Me.txtTelefono = New System.Windows.Forms.TextBox()
		Me.txtCorreo = New System.Windows.Forms.TextBox()
		Me.txtNombre = New System.Windows.Forms.TextBox()
		Me.txtRfc = New System.Windows.Forms.TextBox()
		Me.cmBCalificacion = New System.Windows.Forms.ComboBox()
		Me.SuspendLayout
		'
		'lblTitulo
		'
		Me.lblTitulo.Dock = System.Windows.Forms.DockStyle.Top
		Me.lblTitulo.Font = New System.Drawing.Font("Agency FB", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.lblTitulo.ForeColor = System.Drawing.Color.White
		Me.lblTitulo.Location = New System.Drawing.Point(0, 0)
		Me.lblTitulo.Name = "lblTitulo"
		Me.lblTitulo.Size = New System.Drawing.Size(626, 62)
		Me.lblTitulo.TabIndex = 31
		Me.lblTitulo.Text = "ELIMINACION DE PROVEDORES"
		Me.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'btnBuscar
		'
		Me.btnBuscar.BackColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(104,Byte),Integer), CType(CType(130,Byte),Integer))
		Me.btnBuscar.Font = New System.Drawing.Font("Agency FB", 18!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.btnBuscar.ForeColor = System.Drawing.Color.White
		Me.btnBuscar.Image = CType(resources.GetObject("btnBuscar.Image"),System.Drawing.Image)
		Me.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.btnBuscar.Location = New System.Drawing.Point(287, 60)
		Me.btnBuscar.Name = "btnBuscar"
		Me.btnBuscar.Size = New System.Drawing.Size(148, 46)
		Me.btnBuscar.TabIndex = 53
		Me.btnBuscar.Text = "  Buscar"
		Me.btnBuscar.UseVisualStyleBackColor = false
		'
		'btnLimpiar
		'
		Me.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(104,Byte),Integer), CType(CType(130,Byte),Integer))
		Me.btnLimpiar.Font = New System.Drawing.Font("Agency FB", 18!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.btnLimpiar.ForeColor = System.Drawing.Color.White
		Me.btnLimpiar.Image = CType(resources.GetObject("btnLimpiar.Image"),System.Drawing.Image)
		Me.btnLimpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.btnLimpiar.Location = New System.Drawing.Point(287, 279)
		Me.btnLimpiar.Name = "btnLimpiar"
		Me.btnLimpiar.Size = New System.Drawing.Size(148, 46)
		Me.btnLimpiar.TabIndex = 52
		Me.btnLimpiar.Text = "    LIMPIAR"
		Me.btnLimpiar.UseVisualStyleBackColor = false
		AddHandler Me.btnLimpiar.Click, AddressOf Me.BtnLimpiarClick
		'
		'btnEliminar
		'
		Me.btnEliminar.BackColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(104,Byte),Integer), CType(CType(130,Byte),Integer))
		Me.btnEliminar.Font = New System.Drawing.Font("Agency FB", 18!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.btnEliminar.ForeColor = System.Drawing.Color.White
		Me.btnEliminar.Image = CType(resources.GetObject("btnEliminar.Image"),System.Drawing.Image)
		Me.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.btnEliminar.Location = New System.Drawing.Point(81, 279)
		Me.btnEliminar.Name = "btnEliminar"
		Me.btnEliminar.Size = New System.Drawing.Size(172, 46)
		Me.btnEliminar.TabIndex = 51
		Me.btnEliminar.Text = "Eliminar"
		Me.btnEliminar.UseVisualStyleBackColor = false
		AddHandler Me.btnEliminar.Click, AddressOf Me.BtnEliminarClick
		'
		'txtTelefono
		'
		Me.txtTelefono.BackColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(104,Byte),Integer), CType(CType(130,Byte),Integer))
		Me.txtTelefono.Font = New System.Drawing.Font("Agency FB", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.txtTelefono.ForeColor = System.Drawing.Color.LightGray
		Me.txtTelefono.Location = New System.Drawing.Point(81, 186)
		Me.txtTelefono.Name = "txtTelefono"
		Me.txtTelefono.Size = New System.Drawing.Size(354, 30)
		Me.txtTelefono.TabIndex = 47
		Me.txtTelefono.Text = "Telefono"
		AddHandler Me.txtTelefono.Click, AddressOf Me.TxtTelefonoClick
		'
		'txtCorreo
		'
		Me.txtCorreo.BackColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(104,Byte),Integer), CType(CType(130,Byte),Integer))
		Me.txtCorreo.Font = New System.Drawing.Font("Agency FB", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.txtCorreo.ForeColor = System.Drawing.Color.LightGray
		Me.txtCorreo.Location = New System.Drawing.Point(81, 150)
		Me.txtCorreo.Name = "txtCorreo"
		Me.txtCorreo.Size = New System.Drawing.Size(354, 30)
		Me.txtCorreo.TabIndex = 46
		Me.txtCorreo.Text = "Correo"
		AddHandler Me.txtCorreo.Click, AddressOf Me.TxtCorreoClick
		'
		'txtNombre
		'
		Me.txtNombre.BackColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(104,Byte),Integer), CType(CType(130,Byte),Integer))
		Me.txtNombre.Font = New System.Drawing.Font("Agency FB", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.txtNombre.ForeColor = System.Drawing.Color.LightGray
		Me.txtNombre.Location = New System.Drawing.Point(81, 114)
		Me.txtNombre.Name = "txtNombre"
		Me.txtNombre.Size = New System.Drawing.Size(354, 30)
		Me.txtNombre.TabIndex = 45
		Me.txtNombre.Text = "Nombre"
		AddHandler Me.txtNombre.Click, AddressOf Me.TxtNombreClick
		'
		'txtRfc
		'
		Me.txtRfc.BackColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(104,Byte),Integer), CType(CType(130,Byte),Integer))
		Me.txtRfc.Font = New System.Drawing.Font("Agency FB", 21!, System.Drawing.FontStyle.Bold)
		Me.txtRfc.ForeColor = System.Drawing.Color.LightGray
		Me.txtRfc.Location = New System.Drawing.Point(81, 65)
		Me.txtRfc.Name = "txtRfc"
		Me.txtRfc.Size = New System.Drawing.Size(191, 41)
		Me.txtRfc.TabIndex = 44
		Me.txtRfc.Text = "RFC"
		AddHandler Me.txtRfc.Click, AddressOf Me.TxtRfcClick
		'
		'cmBCalificacion
		'
		Me.cmBCalificacion.BackColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(104,Byte),Integer), CType(CType(130,Byte),Integer))
		Me.cmBCalificacion.Font = New System.Drawing.Font("Agency FB", 15!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.cmBCalificacion.ForeColor = System.Drawing.Color.LightGray
		Me.cmBCalificacion.FormattingEnabled = true
		Me.cmBCalificacion.Location = New System.Drawing.Point(81, 222)
		Me.cmBCalificacion.Name = "cmBCalificacion"
		Me.cmBCalificacion.Size = New System.Drawing.Size(354, 32)
		Me.cmBCalificacion.TabIndex = 54
		Me.cmBCalificacion.Text = "Calificacion"
		'
		'FrmEliminarProveedor
		'
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(104,Byte),Integer), CType(CType(130,Byte),Integer))
		Me.ClientSize = New System.Drawing.Size(626, 382)
		Me.Controls.Add(Me.cmBCalificacion)
		Me.Controls.Add(Me.btnBuscar)
		Me.Controls.Add(Me.btnLimpiar)
		Me.Controls.Add(Me.btnEliminar)
		Me.Controls.Add(Me.txtTelefono)
		Me.Controls.Add(Me.txtCorreo)
		Me.Controls.Add(Me.txtNombre)
		Me.Controls.Add(Me.txtRfc)
		Me.Controls.Add(Me.lblTitulo)
		Me.Name = "FrmEliminarProveedor"
		Me.Text = "FrmEliminarProveedor"
		Me.ResumeLayout(false)
		Me.PerformLayout
	End Sub
	Private cmBCalificacion As System.Windows.Forms.ComboBox
	Private txtRfc As System.Windows.Forms.TextBox
	Private txtNombre As System.Windows.Forms.TextBox
	Private txtCorreo As System.Windows.Forms.TextBox
	Private txtTelefono As System.Windows.Forms.TextBox
	Private btnEliminar As System.Windows.Forms.Button
	Private btnLimpiar As System.Windows.Forms.Button
	Private btnBuscar As System.Windows.Forms.Button
	Private lblTitulo As System.Windows.Forms.Label

End Class
