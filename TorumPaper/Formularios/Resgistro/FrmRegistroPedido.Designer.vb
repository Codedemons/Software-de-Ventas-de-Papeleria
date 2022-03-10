'
' Created by SharpDevelop.
' User: Gustavo
' Date: 19/02/2022
' Time: 06:58 p. m.
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Partial Class FrmRegistroPedido
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmRegistroPedido))
		Me.txtCantidad = New System.Windows.Forms.TextBox()
		Me.txtClavearticulo = New System.Windows.Forms.TextBox()
		Me.txtClaveProvedor = New System.Windows.Forms.TextBox()
		Me.LblTitulo = New System.Windows.Forms.Label()
		Me.txtClavePedido = New System.Windows.Forms.TextBox()
		Me.txtFechaPedida = New System.Windows.Forms.TextBox()
		Me.txtPrecioProducto = New System.Windows.Forms.TextBox()
		Me.txtHora = New System.Windows.Forms.TextBox()
		Me.btnLimpiar = New System.Windows.Forms.Button()
		Me.btnRegistrar = New System.Windows.Forms.Button()
		Me.cmbProductos = New System.Windows.Forms.ComboBox()
		Me.cmBClaveProvedor = New System.Windows.Forms.ComboBox()
		Me.SuspendLayout
		'
		'txtCantidad
		'
		Me.txtCantidad.BackColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(104,Byte),Integer), CType(CType(130,Byte),Integer))
		Me.txtCantidad.Font = New System.Drawing.Font("Agency FB", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.txtCantidad.ForeColor = System.Drawing.Color.Gainsboro
		Me.txtCantidad.Location = New System.Drawing.Point(72, 176)
		Me.txtCantidad.Name = "txtCantidad"
		Me.txtCantidad.Size = New System.Drawing.Size(352, 33)
		Me.txtCantidad.TabIndex = 58
		Me.txtCantidad.Text = "Cantidad"
		AddHandler Me.txtCantidad.Click, AddressOf Me.TxtCantidadClick
		'
		'txtClavearticulo
		'
		Me.txtClavearticulo.BackColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(104,Byte),Integer), CType(CType(130,Byte),Integer))
		Me.txtClavearticulo.Font = New System.Drawing.Font("Agency FB", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.txtClavearticulo.ForeColor = System.Drawing.Color.White
		Me.txtClavearticulo.Location = New System.Drawing.Point(72, 137)
		Me.txtClavearticulo.Name = "txtClavearticulo"
		Me.txtClavearticulo.Size = New System.Drawing.Size(352, 33)
		Me.txtClavearticulo.TabIndex = 57
		Me.txtClavearticulo.Text = "Clave articulo"
		'
		'txtClaveProvedor
		'
		Me.txtClaveProvedor.BackColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(104,Byte),Integer), CType(CType(130,Byte),Integer))
		Me.txtClaveProvedor.Font = New System.Drawing.Font("Agency FB", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.txtClaveProvedor.ForeColor = System.Drawing.Color.White
		Me.txtClaveProvedor.Location = New System.Drawing.Point(72, 99)
		Me.txtClaveProvedor.Name = "txtClaveProvedor"
		Me.txtClaveProvedor.Size = New System.Drawing.Size(352, 33)
		Me.txtClaveProvedor.TabIndex = 56
		Me.txtClaveProvedor.Text = "Clave Proveedor"
		'
		'LblTitulo
		'
		Me.LblTitulo.Dock = System.Windows.Forms.DockStyle.Top
		Me.LblTitulo.Font = New System.Drawing.Font("Agency FB", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.LblTitulo.ForeColor = System.Drawing.Color.White
		Me.LblTitulo.Location = New System.Drawing.Point(0, 0)
		Me.LblTitulo.Name = "LblTitulo"
		Me.LblTitulo.Size = New System.Drawing.Size(595, 31)
		Me.LblTitulo.TabIndex = 55
		Me.LblTitulo.Text = "REGISTRO DE PEDIDOS"
		Me.LblTitulo.TextAlign = System.Drawing.ContentAlignment.TopCenter
		'
		'txtClavePedido
		'
		Me.txtClavePedido.BackColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(104,Byte),Integer), CType(CType(130,Byte),Integer))
		Me.txtClavePedido.Font = New System.Drawing.Font("Agency FB", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.txtClavePedido.ForeColor = System.Drawing.Color.Gainsboro
		Me.txtClavePedido.Location = New System.Drawing.Point(72, 60)
		Me.txtClavePedido.Name = "txtClavePedido"
		Me.txtClavePedido.Size = New System.Drawing.Size(352, 33)
		Me.txtClavePedido.TabIndex = 54
		Me.txtClavePedido.Text = "Clave Pedido"
		AddHandler Me.txtClavePedido.Click, AddressOf Me.TxtClavePedidoClick
		'
		'txtFechaPedida
		'
		Me.txtFechaPedida.BackColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(104,Byte),Integer), CType(CType(130,Byte),Integer))
		Me.txtFechaPedida.Font = New System.Drawing.Font("Agency FB", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.txtFechaPedida.ForeColor = System.Drawing.Color.Gainsboro
		Me.txtFechaPedida.Location = New System.Drawing.Point(72, 215)
		Me.txtFechaPedida.Name = "txtFechaPedida"
		Me.txtFechaPedida.Size = New System.Drawing.Size(352, 33)
		Me.txtFechaPedida.TabIndex = 60
		Me.txtFechaPedida.Text = "Fecha pedido"
		AddHandler Me.txtFechaPedida.Click, AddressOf Me.TxtFechaPedidaClick
		'
		'txtPrecioProducto
		'
		Me.txtPrecioProducto.BackColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(104,Byte),Integer), CType(CType(130,Byte),Integer))
		Me.txtPrecioProducto.Font = New System.Drawing.Font("Agency FB", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.txtPrecioProducto.ForeColor = System.Drawing.Color.Gainsboro
		Me.txtPrecioProducto.Location = New System.Drawing.Point(72, 293)
		Me.txtPrecioProducto.Name = "txtPrecioProducto"
		Me.txtPrecioProducto.Size = New System.Drawing.Size(352, 33)
		Me.txtPrecioProducto.TabIndex = 61
		Me.txtPrecioProducto.Text = "Precio del producto"
		AddHandler Me.txtPrecioProducto.Click, AddressOf Me.TxtPrecioProductoClick
		'
		'txtHora
		'
		Me.txtHora.BackColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(104,Byte),Integer), CType(CType(130,Byte),Integer))
		Me.txtHora.Font = New System.Drawing.Font("Agency FB", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.txtHora.ForeColor = System.Drawing.Color.Gainsboro
		Me.txtHora.Location = New System.Drawing.Point(72, 254)
		Me.txtHora.Name = "txtHora"
		Me.txtHora.Size = New System.Drawing.Size(352, 33)
		Me.txtHora.TabIndex = 62
		Me.txtHora.Text = "Hora"
		AddHandler Me.txtHora.Click, AddressOf Me.TxtHoraClick
		'
		'btnLimpiar
		'
		Me.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(104,Byte),Integer), CType(CType(130,Byte),Integer))
		Me.btnLimpiar.Font = New System.Drawing.Font("Agency FB", 18!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.btnLimpiar.ForeColor = System.Drawing.Color.White
		Me.btnLimpiar.Image = CType(resources.GetObject("btnLimpiar.Image"),System.Drawing.Image)
		Me.btnLimpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.btnLimpiar.Location = New System.Drawing.Point(278, 332)
		Me.btnLimpiar.Name = "btnLimpiar"
		Me.btnLimpiar.Size = New System.Drawing.Size(148, 46)
		Me.btnLimpiar.TabIndex = 64
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
		Me.btnRegistrar.Location = New System.Drawing.Point(72, 332)
		Me.btnRegistrar.Name = "btnRegistrar"
		Me.btnRegistrar.Size = New System.Drawing.Size(172, 46)
		Me.btnRegistrar.TabIndex = 63
		Me.btnRegistrar.Text = "   Registrar"
		Me.btnRegistrar.UseVisualStyleBackColor = false
		AddHandler Me.btnRegistrar.Click, AddressOf Me.BtnRegistrarClick
		'
		'cmbProductos
		'
		Me.cmbProductos.BackColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(104,Byte),Integer), CType(CType(130,Byte),Integer))
		Me.cmbProductos.Font = New System.Drawing.Font("Agency FB", 15!, System.Drawing.FontStyle.Bold)
		Me.cmbProductos.ForeColor = System.Drawing.Color.Gainsboro
		Me.cmbProductos.FormattingEnabled = true
		Me.cmbProductos.Location = New System.Drawing.Point(72, 99)
		Me.cmbProductos.Name = "cmbProductos"
		Me.cmbProductos.Size = New System.Drawing.Size(352, 32)
		Me.cmbProductos.TabIndex = 66
		Me.cmbProductos.Text = "Productos"
		'
		'cmBClaveProvedor
		'
		Me.cmBClaveProvedor.BackColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(104,Byte),Integer), CType(CType(130,Byte),Integer))
		Me.cmBClaveProvedor.Font = New System.Drawing.Font("Agency FB", 15!, System.Drawing.FontStyle.Bold)
		Me.cmBClaveProvedor.ForeColor = System.Drawing.Color.Gainsboro
		Me.cmBClaveProvedor.FormattingEnabled = true
		Me.cmBClaveProvedor.Location = New System.Drawing.Point(72, 138)
		Me.cmBClaveProvedor.Name = "cmBClaveProvedor"
		Me.cmBClaveProvedor.Size = New System.Drawing.Size(352, 32)
		Me.cmBClaveProvedor.TabIndex = 65
		Me.cmBClaveProvedor.Text = "Proveedores"
		'
		'FrmRegistroPedido
		'
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(104,Byte),Integer), CType(CType(130,Byte),Integer))
		Me.ClientSize = New System.Drawing.Size(595, 420)
		Me.Controls.Add(Me.cmbProductos)
		Me.Controls.Add(Me.cmBClaveProvedor)
		Me.Controls.Add(Me.btnLimpiar)
		Me.Controls.Add(Me.btnRegistrar)
		Me.Controls.Add(Me.txtHora)
		Me.Controls.Add(Me.txtPrecioProducto)
		Me.Controls.Add(Me.txtFechaPedida)
		Me.Controls.Add(Me.txtCantidad)
		Me.Controls.Add(Me.txtClavearticulo)
		Me.Controls.Add(Me.txtClaveProvedor)
		Me.Controls.Add(Me.LblTitulo)
		Me.Controls.Add(Me.txtClavePedido)
		Me.ForeColor = System.Drawing.Color.Gainsboro
		Me.Name = "FrmRegistroPedido"
		Me.Text = "RegistroVenta"
		Me.ResumeLayout(false)
		Me.PerformLayout
	End Sub
	Private cmBClaveProvedor As System.Windows.Forms.ComboBox
	Private cmbProductos As System.Windows.Forms.ComboBox
	Private btnRegistrar As System.Windows.Forms.Button
	Private btnLimpiar As System.Windows.Forms.Button
	Private txtHora As System.Windows.Forms.TextBox
	Private txtPrecioProducto As System.Windows.Forms.TextBox
	Private txtFechaPedida As System.Windows.Forms.TextBox
	Private txtClavePedido As System.Windows.Forms.TextBox
	Private LblTitulo As System.Windows.Forms.Label
	Private txtClaveProvedor As System.Windows.Forms.TextBox
	Private txtClavearticulo As System.Windows.Forms.TextBox
	Private txtCantidad As System.Windows.Forms.TextBox
End Class
