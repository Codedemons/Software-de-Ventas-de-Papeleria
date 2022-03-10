'
' Created by SharpDevelop.
' User: Coderp
' Date: 19/02/2022
' Time: 15:30
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Partial Class FrmEliminarProductos
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmEliminarProductos))
		Me.lblTitulo = New System.Windows.Forms.Label()
		Me.btnLimpiar = New System.Windows.Forms.Button()
		Me.btnEliminar = New System.Windows.Forms.Button()
		Me.txtSmax = New System.Windows.Forms.TextBox()
		Me.txtSmin = New System.Windows.Forms.TextBox()
		Me.txtPrecio = New System.Windows.Forms.TextBox()
		Me.txtDescripcion = New System.Windows.Forms.TextBox()
		Me.txtMarca = New System.Windows.Forms.TextBox()
		Me.txtTipo = New System.Windows.Forms.TextBox()
		Me.txtClaveProducto = New System.Windows.Forms.TextBox()
		Me.btnBuscar = New System.Windows.Forms.Button()
		Me.txtSdispo = New System.Windows.Forms.TextBox()
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
		Me.lblTitulo.Text = "ELIMINACION DE PRODUCTOS"
		Me.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		AddHandler Me.lblTitulo.Click, AddressOf Me.FrmEliminarProductosClick
		'
		'btnLimpiar
		'
		Me.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(104,Byte),Integer), CType(CType(130,Byte),Integer))
		Me.btnLimpiar.Font = New System.Drawing.Font("Agency FB", 18!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.btnLimpiar.ForeColor = System.Drawing.Color.White
		Me.btnLimpiar.Image = CType(resources.GetObject("btnLimpiar.Image"),System.Drawing.Image)
		Me.btnLimpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.btnLimpiar.Location = New System.Drawing.Point(279, 352)
		Me.btnLimpiar.Name = "btnLimpiar"
		Me.btnLimpiar.Size = New System.Drawing.Size(148, 46)
		Me.btnLimpiar.TabIndex = 41
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
		Me.btnEliminar.Location = New System.Drawing.Point(73, 352)
		Me.btnEliminar.Name = "btnEliminar"
		Me.btnEliminar.Size = New System.Drawing.Size(172, 46)
		Me.btnEliminar.TabIndex = 40
		Me.btnEliminar.Text = "Eliminar"
		Me.btnEliminar.UseVisualStyleBackColor = false
		AddHandler Me.btnEliminar.Click, AddressOf Me.BtnEliminarClick
		'
		'txtSmax
		'
		Me.txtSmax.BackColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(104,Byte),Integer), CType(CType(130,Byte),Integer))
		Me.txtSmax.Font = New System.Drawing.Font("Agency FB", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.txtSmax.ForeColor = System.Drawing.Color.LightGray
		Me.txtSmax.Location = New System.Drawing.Point(73, 288)
		Me.txtSmax.Name = "txtSmax"
		Me.txtSmax.Size = New System.Drawing.Size(354, 30)
		Me.txtSmax.TabIndex = 39
		Me.txtSmax.Text = "Stock max"
		AddHandler Me.txtSmax.Click, AddressOf Me.TxtSmaxClick
		'
		'txtSmin
		'
		Me.txtSmin.BackColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(104,Byte),Integer), CType(CType(130,Byte),Integer))
		Me.txtSmin.Font = New System.Drawing.Font("Agency FB", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.txtSmin.ForeColor = System.Drawing.Color.LightGray
		Me.txtSmin.Location = New System.Drawing.Point(73, 252)
		Me.txtSmin.Name = "txtSmin"
		Me.txtSmin.Size = New System.Drawing.Size(354, 30)
		Me.txtSmin.TabIndex = 38
		Me.txtSmin.Text = "Stock min"
		AddHandler Me.txtSmin.Click, AddressOf Me.TxtSminClick
		'
		'txtPrecio
		'
		Me.txtPrecio.BackColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(104,Byte),Integer), CType(CType(130,Byte),Integer))
		Me.txtPrecio.Font = New System.Drawing.Font("Agency FB", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.txtPrecio.ForeColor = System.Drawing.Color.LightGray
		Me.txtPrecio.Location = New System.Drawing.Point(73, 216)
		Me.txtPrecio.Name = "txtPrecio"
		Me.txtPrecio.Size = New System.Drawing.Size(354, 30)
		Me.txtPrecio.TabIndex = 37
		Me.txtPrecio.Text = "Precio"
		AddHandler Me.txtPrecio.Click, AddressOf Me.TxtPrecioClick
		'
		'txtDescripcion
		'
		Me.txtDescripcion.BackColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(104,Byte),Integer), CType(CType(130,Byte),Integer))
		Me.txtDescripcion.Font = New System.Drawing.Font("Agency FB", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.txtDescripcion.ForeColor = System.Drawing.Color.LightGray
		Me.txtDescripcion.Location = New System.Drawing.Point(73, 180)
		Me.txtDescripcion.Name = "txtDescripcion"
		Me.txtDescripcion.Size = New System.Drawing.Size(354, 30)
		Me.txtDescripcion.TabIndex = 36
		Me.txtDescripcion.Text = "Descripcion"
		AddHandler Me.txtDescripcion.Click, AddressOf Me.TxtDescripcionClick
		'
		'txtMarca
		'
		Me.txtMarca.BackColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(104,Byte),Integer), CType(CType(130,Byte),Integer))
		Me.txtMarca.Font = New System.Drawing.Font("Agency FB", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.txtMarca.ForeColor = System.Drawing.Color.LightGray
		Me.txtMarca.Location = New System.Drawing.Point(73, 144)
		Me.txtMarca.Name = "txtMarca"
		Me.txtMarca.Size = New System.Drawing.Size(354, 30)
		Me.txtMarca.TabIndex = 35
		Me.txtMarca.Text = "Marca"
		AddHandler Me.txtMarca.Click, AddressOf Me.TxtMarcaClick
		'
		'txtTipo
		'
		Me.txtTipo.BackColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(104,Byte),Integer), CType(CType(130,Byte),Integer))
		Me.txtTipo.Font = New System.Drawing.Font("Agency FB", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.txtTipo.ForeColor = System.Drawing.Color.LightGray
		Me.txtTipo.Location = New System.Drawing.Point(73, 108)
		Me.txtTipo.Name = "txtTipo"
		Me.txtTipo.Size = New System.Drawing.Size(354, 30)
		Me.txtTipo.TabIndex = 34
		Me.txtTipo.Text = "Tipo"
		AddHandler Me.txtTipo.Click, AddressOf Me.TxtTipoClick
		'
		'txtClaveProducto
		'
		Me.txtClaveProducto.BackColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(104,Byte),Integer), CType(CType(130,Byte),Integer))
		Me.txtClaveProducto.Font = New System.Drawing.Font("Agency FB", 21!, System.Drawing.FontStyle.Bold)
		Me.txtClaveProducto.ForeColor = System.Drawing.Color.LightGray
		Me.txtClaveProducto.Location = New System.Drawing.Point(73, 59)
		Me.txtClaveProducto.Name = "txtClaveProducto"
		Me.txtClaveProducto.Size = New System.Drawing.Size(191, 41)
		Me.txtClaveProducto.TabIndex = 33
		Me.txtClaveProducto.Text = "Clave"
		AddHandler Me.txtClaveProducto.Click, AddressOf Me.TxtClaveClick
		'
		'btnBuscar
		'
		Me.btnBuscar.BackColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(104,Byte),Integer), CType(CType(130,Byte),Integer))
		Me.btnBuscar.Font = New System.Drawing.Font("Agency FB", 18!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.btnBuscar.ForeColor = System.Drawing.Color.White
		Me.btnBuscar.Image = CType(resources.GetObject("btnBuscar.Image"),System.Drawing.Image)
		Me.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.btnBuscar.Location = New System.Drawing.Point(279, 54)
		Me.btnBuscar.Name = "btnBuscar"
		Me.btnBuscar.Size = New System.Drawing.Size(148, 46)
		Me.btnBuscar.TabIndex = 43
		Me.btnBuscar.Text = "  Buscar"
		Me.btnBuscar.UseVisualStyleBackColor = false
		'
		'txtSdispo
		'
		Me.txtSdispo.BackColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(104,Byte),Integer), CType(CType(130,Byte),Integer))
		Me.txtSdispo.Font = New System.Drawing.Font("Agency FB", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.txtSdispo.ForeColor = System.Drawing.Color.LightGray
		Me.txtSdispo.Location = New System.Drawing.Point(73, 321)
		Me.txtSdispo.Name = "txtSdispo"
		Me.txtSdispo.Size = New System.Drawing.Size(354, 30)
		Me.txtSdispo.TabIndex = 44
		Me.txtSdispo.Text = "Stock Disponible"
		AddHandler Me.txtSdispo.Click, AddressOf Me.TxtSdispoClick
		'
		'FrmEliminarProductos
		'
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(104,Byte),Integer), CType(CType(130,Byte),Integer))
		Me.ClientSize = New System.Drawing.Size(626, 405)
		Me.Controls.Add(Me.txtSdispo)
		Me.Controls.Add(Me.btnBuscar)
		Me.Controls.Add(Me.btnLimpiar)
		Me.Controls.Add(Me.btnEliminar)
		Me.Controls.Add(Me.txtSmax)
		Me.Controls.Add(Me.txtSmin)
		Me.Controls.Add(Me.txtPrecio)
		Me.Controls.Add(Me.txtDescripcion)
		Me.Controls.Add(Me.txtMarca)
		Me.Controls.Add(Me.txtTipo)
		Me.Controls.Add(Me.txtClaveProducto)
		Me.Controls.Add(Me.lblTitulo)
		Me.ForeColor = System.Drawing.Color.White
		Me.Name = "FrmEliminarProductos"
		Me.Text = "FrmEliminarProductos"
		AddHandler Click, AddressOf Me.FrmEliminarProductosClick
		Me.ResumeLayout(false)
		Me.PerformLayout
	End Sub
	Private txtSdispo As System.Windows.Forms.TextBox
	Private btnBuscar As System.Windows.Forms.Button
	Private txtClaveProducto As System.Windows.Forms.TextBox
	Private txtTipo As System.Windows.Forms.TextBox
	Private txtMarca As System.Windows.Forms.TextBox
	Private txtDescripcion As System.Windows.Forms.TextBox
	Private txtPrecio As System.Windows.Forms.TextBox
	Private txtSmin As System.Windows.Forms.TextBox
	Private txtSmax As System.Windows.Forms.TextBox
	Private btnEliminar As System.Windows.Forms.Button
	Private btnLimpiar As System.Windows.Forms.Button
	Private lblTitulo As System.Windows.Forms.Label
	
	

End Class
