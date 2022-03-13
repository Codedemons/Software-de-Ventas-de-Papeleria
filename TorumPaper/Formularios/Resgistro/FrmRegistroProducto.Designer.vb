'
' Created by SharpDevelop.
' User: Gustavo
' Date: 19/02/2022
' Time: 01:50 p. m.
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Partial Class FrmRegistroProducto
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmRegistroProducto))
		Me.txtClaveProducto = New System.Windows.Forms.TextBox()
		Me.LblTitulo = New System.Windows.Forms.Label()
		Me.txtMarca = New System.Windows.Forms.TextBox()
		Me.txtDescripcion = New System.Windows.Forms.TextBox()
		Me.txtPrecio = New System.Windows.Forms.TextBox()
		Me.txtSmin = New System.Windows.Forms.TextBox()
		Me.txtSmax = New System.Windows.Forms.TextBox()
		Me.txtSdispo = New System.Windows.Forms.TextBox()
		Me.btnLimpiar = New System.Windows.Forms.Button()
		Me.btnRegistrar = New System.Windows.Forms.Button()
		Me.cmbTipo = New System.Windows.Forms.ComboBox()
		Me.SuspendLayout
		'
		'txtClaveProducto
		'
		Me.txtClaveProducto.BackColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(104,Byte),Integer), CType(CType(130,Byte),Integer))
		Me.txtClaveProducto.Font = New System.Drawing.Font("Agency FB", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.txtClaveProducto.ForeColor = System.Drawing.Color.LightGray
		Me.txtClaveProducto.Location = New System.Drawing.Point(87, 58)
		Me.txtClaveProducto.Name = "txtClaveProducto"
		Me.txtClaveProducto.Size = New System.Drawing.Size(354, 33)
		Me.txtClaveProducto.TabIndex = 17
		Me.txtClaveProducto.Text = "Clave"
		AddHandler Me.txtClaveProducto.Click, AddressOf Me.TxtClaveProductoClick
		'
		'LblTitulo
		'
		Me.LblTitulo.Dock = System.Windows.Forms.DockStyle.Top
		Me.LblTitulo.Font = New System.Drawing.Font("Agency FB", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.LblTitulo.ForeColor = System.Drawing.Color.White
		Me.LblTitulo.Location = New System.Drawing.Point(0, 0)
		Me.LblTitulo.Name = "LblTitulo"
		Me.LblTitulo.Size = New System.Drawing.Size(528, 31)
		Me.LblTitulo.TabIndex = 30
		Me.LblTitulo.Text = "REGISTRO DE PRODUCTOS"
		Me.LblTitulo.TextAlign = System.Drawing.ContentAlignment.TopCenter
		'
		'txtMarca
		'
		Me.txtMarca.BackColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(104,Byte),Integer), CType(CType(130,Byte),Integer))
		Me.txtMarca.Font = New System.Drawing.Font("Agency FB", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.txtMarca.ForeColor = System.Drawing.Color.LightGray
		Me.txtMarca.Location = New System.Drawing.Point(87, 135)
		Me.txtMarca.Name = "txtMarca"
		Me.txtMarca.Size = New System.Drawing.Size(354, 33)
		Me.txtMarca.TabIndex = 37
		Me.txtMarca.Text = "Marca"
		AddHandler Me.txtMarca.Click, AddressOf Me.TxtMarcaClick
		'
		'txtDescripcion
		'
		Me.txtDescripcion.BackColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(104,Byte),Integer), CType(CType(130,Byte),Integer))
		Me.txtDescripcion.Font = New System.Drawing.Font("Agency FB", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.txtDescripcion.ForeColor = System.Drawing.Color.LightGray
		Me.txtDescripcion.Location = New System.Drawing.Point(87, 174)
		Me.txtDescripcion.Name = "txtDescripcion"
		Me.txtDescripcion.Size = New System.Drawing.Size(354, 33)
		Me.txtDescripcion.TabIndex = 39
		Me.txtDescripcion.Text = "Descripción"
		AddHandler Me.txtDescripcion.Click, AddressOf Me.TxtDescripcionClick
		'
		'txtPrecio
		'
		Me.txtPrecio.BackColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(104,Byte),Integer), CType(CType(130,Byte),Integer))
		Me.txtPrecio.Font = New System.Drawing.Font("Agency FB", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.txtPrecio.ForeColor = System.Drawing.Color.LightGray
		Me.txtPrecio.Location = New System.Drawing.Point(87, 213)
		Me.txtPrecio.Name = "txtPrecio"
		Me.txtPrecio.Size = New System.Drawing.Size(354, 33)
		Me.txtPrecio.TabIndex = 42
		Me.txtPrecio.Text = "Precio"
		AddHandler Me.txtPrecio.Click, AddressOf Me.TxtPrecioClick
		'
		'txtSmin
		'
		Me.txtSmin.BackColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(104,Byte),Integer), CType(CType(130,Byte),Integer))
		Me.txtSmin.Font = New System.Drawing.Font("Agency FB", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.txtSmin.ForeColor = System.Drawing.Color.LightGray
		Me.txtSmin.Location = New System.Drawing.Point(87, 252)
		Me.txtSmin.Name = "txtSmin"
		Me.txtSmin.Size = New System.Drawing.Size(354, 33)
		Me.txtSmin.TabIndex = 44
		Me.txtSmin.Text = "Stock Mínimo"
		AddHandler Me.txtSmin.Click, AddressOf Me.TxtSminClick
		'
		'txtSmax
		'
		Me.txtSmax.BackColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(104,Byte),Integer), CType(CType(130,Byte),Integer))
		Me.txtSmax.Font = New System.Drawing.Font("Agency FB", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.txtSmax.ForeColor = System.Drawing.Color.LightGray
		Me.txtSmax.Location = New System.Drawing.Point(87, 291)
		Me.txtSmax.Name = "txtSmax"
		Me.txtSmax.Size = New System.Drawing.Size(354, 33)
		Me.txtSmax.TabIndex = 47
		Me.txtSmax.Text = "Stock Máximo"
		AddHandler Me.txtSmax.Click, AddressOf Me.TxtSmaxClick
		'
		'txtSdispo
		'
		Me.txtSdispo.BackColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(104,Byte),Integer), CType(CType(130,Byte),Integer))
		Me.txtSdispo.Font = New System.Drawing.Font("Agency FB", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.txtSdispo.ForeColor = System.Drawing.Color.LightGray
		Me.txtSdispo.Location = New System.Drawing.Point(87, 330)
		Me.txtSdispo.Name = "txtSdispo"
		Me.txtSdispo.Size = New System.Drawing.Size(354, 33)
		Me.txtSdispo.TabIndex = 48
		Me.txtSdispo.Text = "Stock Disponible"
		AddHandler Me.txtSdispo.Click, AddressOf Me.TxtSdispoClick
		'
		'btnLimpiar
		'
		Me.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(104,Byte),Integer), CType(CType(130,Byte),Integer))
		Me.btnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand
		Me.btnLimpiar.Font = New System.Drawing.Font("Agency FB", 18!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.btnLimpiar.ForeColor = System.Drawing.Color.White
		Me.btnLimpiar.Image = CType(resources.GetObject("btnLimpiar.Image"),System.Drawing.Image)
		Me.btnLimpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.btnLimpiar.Location = New System.Drawing.Point(293, 369)
		Me.btnLimpiar.Name = "btnLimpiar"
		Me.btnLimpiar.Size = New System.Drawing.Size(148, 46)
		Me.btnLimpiar.TabIndex = 58
		Me.btnLimpiar.Text = "    LIMPIAR"
		Me.btnLimpiar.UseVisualStyleBackColor = false
		AddHandler Me.btnLimpiar.Click, AddressOf Me.BtnLimpiarClick
		'
		'btnRegistrar
		'
		Me.btnRegistrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(104,Byte),Integer), CType(CType(130,Byte),Integer))
		Me.btnRegistrar.Cursor = System.Windows.Forms.Cursors.Hand
		Me.btnRegistrar.Font = New System.Drawing.Font("Agency FB", 18!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.btnRegistrar.ForeColor = System.Drawing.Color.LightGray
		Me.btnRegistrar.Image = CType(resources.GetObject("btnRegistrar.Image"),System.Drawing.Image)
		Me.btnRegistrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.btnRegistrar.Location = New System.Drawing.Point(87, 369)
		Me.btnRegistrar.Name = "btnRegistrar"
		Me.btnRegistrar.Size = New System.Drawing.Size(172, 46)
		Me.btnRegistrar.TabIndex = 57
		Me.btnRegistrar.Text = "     Registrar"
		Me.btnRegistrar.UseVisualStyleBackColor = false
		AddHandler Me.btnRegistrar.Click, AddressOf Me.BtnRegistrarClick
		'
		'cmbTipo
		'
		Me.cmbTipo.BackColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(104,Byte),Integer), CType(CType(130,Byte),Integer))
		Me.cmbTipo.Font = New System.Drawing.Font("Agency FB", 15!, System.Drawing.FontStyle.Bold)
		Me.cmbTipo.ForeColor = System.Drawing.Color.LightGray
		Me.cmbTipo.FormattingEnabled = true
		Me.cmbTipo.Location = New System.Drawing.Point(87, 97)
		Me.cmbTipo.Name = "cmbTipo"
		Me.cmbTipo.Size = New System.Drawing.Size(354, 32)
		Me.cmbTipo.TabIndex = 62
		Me.cmbTipo.Text = "Tipos"
		'
		'FrmRegistroProducto
		'
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(104,Byte),Integer), CType(CType(130,Byte),Integer))
		Me.ClientSize = New System.Drawing.Size(528, 437)
		Me.Controls.Add(Me.cmbTipo)
		Me.Controls.Add(Me.btnLimpiar)
		Me.Controls.Add(Me.btnRegistrar)
		Me.Controls.Add(Me.txtSdispo)
		Me.Controls.Add(Me.txtSmax)
		Me.Controls.Add(Me.txtSmin)
		Me.Controls.Add(Me.txtPrecio)
		Me.Controls.Add(Me.txtDescripcion)
		Me.Controls.Add(Me.txtMarca)
		Me.Controls.Add(Me.LblTitulo)
		Me.Controls.Add(Me.txtClaveProducto)
		Me.ForeColor = System.Drawing.Color.LightGray
		Me.Name = "FrmRegistroProducto"
		Me.Text = "RegistroProducto"
		Me.ResumeLayout(false)
		Me.PerformLayout
	End Sub
	Private cmbTipo As System.Windows.Forms.ComboBox
	Private btnRegistrar As System.Windows.Forms.Button
	Private btnLimpiar As System.Windows.Forms.Button
	Private txtSdispo As System.Windows.Forms.TextBox
	Private txtSmax As System.Windows.Forms.TextBox
	Private txtSmin As System.Windows.Forms.TextBox
	Private txtPrecio As System.Windows.Forms.TextBox
	Private LblTitulo As System.Windows.Forms.Label
	Private txtClaveProducto As System.Windows.Forms.TextBox
	Private txtMarca As System.Windows.Forms.TextBox
	Private txtDescripcion As System.Windows.Forms.TextBox
End Class
