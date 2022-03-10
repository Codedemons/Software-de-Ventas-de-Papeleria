'
' Created by SharpDevelop.
' User: Coderp
' Date: 19/02/2022
' Time: 15:31
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Partial Class FrmEliminarPedidos
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmEliminarPedidos))
		Me.lblTitulo = New System.Windows.Forms.Label()
		Me.btnBuscar = New System.Windows.Forms.Button()
		Me.btnLimpiar = New System.Windows.Forms.Button()
		Me.btnEliminar = New System.Windows.Forms.Button()
		Me.txtPrecioProducto = New System.Windows.Forms.TextBox()
		Me.txtHora = New System.Windows.Forms.TextBox()
		Me.txtFechaPedida = New System.Windows.Forms.TextBox()
		Me.txtCantidad = New System.Windows.Forms.TextBox()
		Me.txtClavePedido = New System.Windows.Forms.TextBox()
		Me.cmbProductos = New System.Windows.Forms.ComboBox()
		Me.cmBClaveProvedor = New System.Windows.Forms.ComboBox()
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
		Me.lblTitulo.Text = "ELIMINACION DE PEDIDOS"
		Me.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'btnBuscar
		'
		Me.btnBuscar.BackColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(104,Byte),Integer), CType(CType(130,Byte),Integer))
		Me.btnBuscar.Font = New System.Drawing.Font("Agency FB", 18!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.btnBuscar.ForeColor = System.Drawing.Color.White
		Me.btnBuscar.Image = CType(resources.GetObject("btnBuscar.Image"),System.Drawing.Image)
		Me.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.btnBuscar.Location = New System.Drawing.Point(278, 53)
		Me.btnBuscar.Name = "btnBuscar"
		Me.btnBuscar.Size = New System.Drawing.Size(148, 47)
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
		Me.btnLimpiar.Location = New System.Drawing.Point(278, 328)
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
		Me.btnEliminar.Location = New System.Drawing.Point(72, 328)
		Me.btnEliminar.Name = "btnEliminar"
		Me.btnEliminar.Size = New System.Drawing.Size(172, 46)
		Me.btnEliminar.TabIndex = 51
		Me.btnEliminar.Text = "Eliminar"
		Me.btnEliminar.UseVisualStyleBackColor = false
		AddHandler Me.btnEliminar.Click, AddressOf Me.BtnEliminarClick
		'
		'txtPrecioProducto
		'
		Me.txtPrecioProducto.BackColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(104,Byte),Integer), CType(CType(130,Byte),Integer))
		Me.txtPrecioProducto.Font = New System.Drawing.Font("Agency FB", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.txtPrecioProducto.ForeColor = System.Drawing.Color.LightGray
		Me.txtPrecioProducto.Location = New System.Drawing.Point(72, 292)
		Me.txtPrecioProducto.Name = "txtPrecioProducto"
		Me.txtPrecioProducto.Size = New System.Drawing.Size(354, 30)
		Me.txtPrecioProducto.TabIndex = 50
		Me.txtPrecioProducto.Text = "Precio del producto"
		AddHandler Me.txtPrecioProducto.Click, AddressOf Me.TxtPrecioProductoClick
		'
		'txtHora
		'
		Me.txtHora.BackColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(104,Byte),Integer), CType(CType(130,Byte),Integer))
		Me.txtHora.Font = New System.Drawing.Font("Agency FB", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.txtHora.ForeColor = System.Drawing.Color.LightGray
		Me.txtHora.Location = New System.Drawing.Point(72, 256)
		Me.txtHora.Name = "txtHora"
		Me.txtHora.Size = New System.Drawing.Size(354, 30)
		Me.txtHora.TabIndex = 49
		Me.txtHora.Text = "Hora"
		AddHandler Me.txtHora.Click, AddressOf Me.TxtHoraClick
		'
		'txtFechaPedida
		'
		Me.txtFechaPedida.BackColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(104,Byte),Integer), CType(CType(130,Byte),Integer))
		Me.txtFechaPedida.Font = New System.Drawing.Font("Agency FB", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.txtFechaPedida.ForeColor = System.Drawing.Color.LightGray
		Me.txtFechaPedida.Location = New System.Drawing.Point(72, 220)
		Me.txtFechaPedida.Name = "txtFechaPedida"
		Me.txtFechaPedida.Size = New System.Drawing.Size(354, 30)
		Me.txtFechaPedida.TabIndex = 48
		Me.txtFechaPedida.Text = "Fecha pedida"
		AddHandler Me.txtFechaPedida.Click, AddressOf Me.TxtFechaPedidaClick
		'
		'txtCantidad
		'
		Me.txtCantidad.BackColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(104,Byte),Integer), CType(CType(130,Byte),Integer))
		Me.txtCantidad.Font = New System.Drawing.Font("Agency FB", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.txtCantidad.ForeColor = System.Drawing.Color.LightGray
		Me.txtCantidad.Location = New System.Drawing.Point(72, 184)
		Me.txtCantidad.Name = "txtCantidad"
		Me.txtCantidad.Size = New System.Drawing.Size(354, 30)
		Me.txtCantidad.TabIndex = 47
		Me.txtCantidad.Text = "Cantidad"
		AddHandler Me.txtCantidad.Click, AddressOf Me.TxtCantidadClick
		'
		'txtClavePedido
		'
		Me.txtClavePedido.BackColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(104,Byte),Integer), CType(CType(130,Byte),Integer))
		Me.txtClavePedido.Font = New System.Drawing.Font("Agency FB", 19!, System.Drawing.FontStyle.Bold)
		Me.txtClavePedido.ForeColor = System.Drawing.Color.LightGray
		Me.txtClavePedido.Location = New System.Drawing.Point(72, 53)
		Me.txtClavePedido.Name = "txtClavePedido"
		Me.txtClavePedido.Size = New System.Drawing.Size(191, 38)
		Me.txtClavePedido.TabIndex = 44
		Me.txtClavePedido.Text = "Clave pedido"
		AddHandler Me.txtClavePedido.Click, AddressOf Me.TxtClavePedidoClick
		'
		'cmbProductos
		'
		Me.cmbProductos.BackColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(104,Byte),Integer), CType(CType(130,Byte),Integer))
		Me.cmbProductos.Font = New System.Drawing.Font("Agency FB", 15!, System.Drawing.FontStyle.Bold)
		Me.cmbProductos.ForeColor = System.Drawing.Color.LightGray
		Me.cmbProductos.FormattingEnabled = true
		Me.cmbProductos.Location = New System.Drawing.Point(72, 102)
		Me.cmbProductos.Name = "cmbProductos"
		Me.cmbProductos.Size = New System.Drawing.Size(354, 32)
		Me.cmbProductos.TabIndex = 60
		Me.cmbProductos.Text = "Productos"
		'
		'cmBClaveProvedor
		'
		Me.cmBClaveProvedor.BackColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(104,Byte),Integer), CType(CType(130,Byte),Integer))
		Me.cmBClaveProvedor.Font = New System.Drawing.Font("Agency FB", 15!, System.Drawing.FontStyle.Bold)
		Me.cmBClaveProvedor.ForeColor = System.Drawing.Color.LightGray
		Me.cmBClaveProvedor.FormattingEnabled = true
		Me.cmBClaveProvedor.Location = New System.Drawing.Point(72, 141)
		Me.cmBClaveProvedor.Name = "cmBClaveProvedor"
		Me.cmBClaveProvedor.Size = New System.Drawing.Size(354, 32)
		Me.cmBClaveProvedor.TabIndex = 59
		Me.cmBClaveProvedor.Text = "Proveedores"
		'
		'FrmEliminarPedidos
		'
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(104,Byte),Integer), CType(CType(130,Byte),Integer))
		Me.ClientSize = New System.Drawing.Size(626, 382)
		Me.Controls.Add(Me.cmbProductos)
		Me.Controls.Add(Me.cmBClaveProvedor)
		Me.Controls.Add(Me.btnBuscar)
		Me.Controls.Add(Me.btnLimpiar)
		Me.Controls.Add(Me.btnEliminar)
		Me.Controls.Add(Me.txtPrecioProducto)
		Me.Controls.Add(Me.txtHora)
		Me.Controls.Add(Me.txtFechaPedida)
		Me.Controls.Add(Me.txtCantidad)
		Me.Controls.Add(Me.txtClavePedido)
		Me.Controls.Add(Me.lblTitulo)
		Me.ForeColor = System.Drawing.Color.LightGray
		Me.Name = "FrmEliminarPedidos"
		Me.Text = "FrmEliminarPedidos"
		Me.ResumeLayout(false)
		Me.PerformLayout
	End Sub
	Private cmbProductos As System.Windows.Forms.ComboBox
	Private cmBClaveProvedor As System.Windows.Forms.ComboBox
	Private txtClavePedido As System.Windows.Forms.TextBox
	Private txtCantidad As System.Windows.Forms.TextBox
	Private txtFechaPedida As System.Windows.Forms.TextBox
	Private txtHora As System.Windows.Forms.TextBox
	Private txtPrecioProducto As System.Windows.Forms.TextBox
	Private btnEliminar As System.Windows.Forms.Button
	Private btnLimpiar As System.Windows.Forms.Button
	Private btnBuscar As System.Windows.Forms.Button
	Private lblTitulo As System.Windows.Forms.Label
End Class
