﻿'
' Created by SharpDevelop.
' User: Coderp
' Date: 15/03/2022
' Time: 13:25
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Partial Class FrmPedidos
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPedidos))
		Me.lbltCantidad = New System.Windows.Forms.Label()
		Me.dTpFecha = New System.Windows.Forms.DateTimePicker()
		Me.nUDCantidadPedido = New System.Windows.Forms.NumericUpDown()
		Me.cmBTipoProducto = New System.Windows.Forms.ComboBox()
		Me.cmBMarca = New System.Windows.Forms.ComboBox()
		Me.cmbProductos = New System.Windows.Forms.ComboBox()
		Me.cmBCProvedor = New System.Windows.Forms.ComboBox()
		Me.btnLimpiar = New System.Windows.Forms.Button()
		Me.btnRegistrar = New System.Windows.Forms.Button()
		Me.txtPrecio = New System.Windows.Forms.TextBox()
		Me.txtClave = New System.Windows.Forms.TextBox()
		Me.lblTitulo = New System.Windows.Forms.Label()
		Me.dGVPedidos = New System.Windows.Forms.DataGridView()
		Me.btnEliminar = New System.Windows.Forms.Button()
		Me.btnActualizar = New System.Windows.Forms.Button()
		Me.lbltBuscar = New System.Windows.Forms.Label()
		Me.cmbBusqueda = New System.Windows.Forms.ComboBox()
		Me.btnBuscar = New System.Windows.Forms.Button()
		Me.dTPBFecha = New System.Windows.Forms.DateTimePicker()
		CType(Me.nUDCantidadPedido,System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.dGVPedidos,System.ComponentModel.ISupportInitialize).BeginInit
		Me.SuspendLayout
		'
		'lbltCantidad
		'
		Me.lbltCantidad.Font = New System.Drawing.Font("Agency FB", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic),System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.lbltCantidad.ForeColor = System.Drawing.Color.White
		Me.lbltCantidad.Location = New System.Drawing.Point(354, 149)
		Me.lbltCantidad.Name = "lbltCantidad"
		Me.lbltCantidad.Size = New System.Drawing.Size(100, 30)
		Me.lbltCantidad.TabIndex = 87
		Me.lbltCantidad.Text = "Cantidad"
		'
		'dTpFecha
		'
		Me.dTpFecha.CalendarFont = New System.Drawing.Font("Agency FB", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic),System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.dTpFecha.Font = New System.Drawing.Font("Agency FB", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic),System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.dTpFecha.Location = New System.Drawing.Point(48, 187)
		Me.dTpFecha.Name = "dTpFecha"
		Me.dTpFecha.Size = New System.Drawing.Size(287, 33)
		Me.dTpFecha.TabIndex = 86
		'
		'nUDCantidadPedido
		'
		Me.nUDCantidadPedido.BackColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(104,Byte),Integer), CType(CType(130,Byte),Integer))
		Me.nUDCantidadPedido.Font = New System.Drawing.Font("Agency FB", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic),System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.nUDCantidadPedido.ForeColor = System.Drawing.Color.White
		Me.nUDCantidadPedido.Location = New System.Drawing.Point(460, 148)
		Me.nUDCantidadPedido.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
		Me.nUDCantidadPedido.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
		Me.nUDCantidadPedido.Name = "nUDCantidadPedido"
		Me.nUDCantidadPedido.Size = New System.Drawing.Size(194, 30)
		Me.nUDCantidadPedido.TabIndex = 85
		Me.nUDCantidadPedido.Value = New Decimal(New Integer() {1, 0, 0, 0})
		'
		'cmBTipoProducto
		'
		Me.cmBTipoProducto.BackColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(104,Byte),Integer), CType(CType(130,Byte),Integer))
		Me.cmBTipoProducto.Font = New System.Drawing.Font("Agency FB", 15!, System.Drawing.FontStyle.Bold)
		Me.cmBTipoProducto.ForeColor = System.Drawing.Color.Gainsboro
		Me.cmBTipoProducto.FormattingEnabled = true
		Me.cmBTipoProducto.Items.AddRange(New Object() {"LÁPIZ", "BOLÍGRAFO", "CARPETA", "GRAPA", "HOJA BLANCA"})
		Me.cmBTipoProducto.Location = New System.Drawing.Point(48, 111)
		Me.cmBTipoProducto.Name = "cmBTipoProducto"
		Me.cmBTipoProducto.Size = New System.Drawing.Size(287, 32)
		Me.cmBTipoProducto.TabIndex = 84
		Me.cmBTipoProducto.Text = "Tipo"
		'
		'cmBMarca
		'
		Me.cmBMarca.BackColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(104,Byte),Integer), CType(CType(130,Byte),Integer))
		Me.cmBMarca.Font = New System.Drawing.Font("Agency FB", 15!, System.Drawing.FontStyle.Bold)
		Me.cmBMarca.ForeColor = System.Drawing.Color.Gainsboro
		Me.cmBMarca.FormattingEnabled = true
		Me.cmBMarca.Items.AddRange(New Object() {"BIC", "AZOR", "CRAYOLA", "MAPITA"})
		Me.cmBMarca.Location = New System.Drawing.Point(354, 73)
		Me.cmBMarca.Name = "cmBMarca"
		Me.cmBMarca.Size = New System.Drawing.Size(300, 32)
		Me.cmBMarca.TabIndex = 83
		Me.cmBMarca.Text = "Marca"
		'
		'cmbProductos
		'
		Me.cmbProductos.BackColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(104,Byte),Integer), CType(CType(130,Byte),Integer))
		Me.cmbProductos.Font = New System.Drawing.Font("Agency FB", 15!, System.Drawing.FontStyle.Bold)
		Me.cmbProductos.ForeColor = System.Drawing.Color.Gainsboro
		Me.cmbProductos.FormattingEnabled = true
		Me.cmbProductos.Items.AddRange(New Object() {"BOLÍGRAFO AZUL INDIVIDUAL", "BOLIGRAFO NEGRE INDIVIDUAL", "BOLIGRAFO ROJO INDIVIDUAL", "PAQUETE AZUL, NEGRO, ROJO (1 X CU)", "PAQUETE BOLIGRAFO AZUL X100", "PAQUETE SURITDO TRICOLOR X100"})
		Me.cmbProductos.Location = New System.Drawing.Point(354, 111)
		Me.cmbProductos.Name = "cmbProductos"
		Me.cmbProductos.Size = New System.Drawing.Size(300, 32)
		Me.cmbProductos.TabIndex = 82
		Me.cmbProductos.Text = "Productos"
		'
		'cmBCProvedor
		'
		Me.cmBCProvedor.BackColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(104,Byte),Integer), CType(CType(130,Byte),Integer))
		Me.cmBCProvedor.Font = New System.Drawing.Font("Agency FB", 15!, System.Drawing.FontStyle.Bold)
		Me.cmBCProvedor.ForeColor = System.Drawing.Color.Gainsboro
		Me.cmBCProvedor.FormattingEnabled = true
		Me.cmBCProvedor.Location = New System.Drawing.Point(48, 149)
		Me.cmBCProvedor.Name = "cmBCProvedor"
		Me.cmBCProvedor.Size = New System.Drawing.Size(287, 32)
		Me.cmBCProvedor.TabIndex = 81
		Me.cmBCProvedor.Text = "Proveedores"
		'
		'btnLimpiar
		'
		Me.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(104,Byte),Integer), CType(CType(130,Byte),Integer))
		Me.btnLimpiar.Font = New System.Drawing.Font("Agency FB", 18!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.btnLimpiar.ForeColor = System.Drawing.Color.White
		Me.btnLimpiar.Image = CType(resources.GetObject("btnLimpiar.Image"),System.Drawing.Image)
		Me.btnLimpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.btnLimpiar.Location = New System.Drawing.Point(673, 123)
		Me.btnLimpiar.Name = "btnLimpiar"
		Me.btnLimpiar.Size = New System.Drawing.Size(172, 55)
		Me.btnLimpiar.TabIndex = 80
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
		Me.btnRegistrar.Location = New System.Drawing.Point(673, 282)
		Me.btnRegistrar.Name = "btnRegistrar"
		Me.btnRegistrar.Size = New System.Drawing.Size(172, 57)
		Me.btnRegistrar.TabIndex = 79
		Me.btnRegistrar.Text = "   Registrar"
		Me.btnRegistrar.UseVisualStyleBackColor = false
		'
		'txtPrecio
		'
		Me.txtPrecio.BackColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(104,Byte),Integer), CType(CType(130,Byte),Integer))
		Me.txtPrecio.Font = New System.Drawing.Font("Agency FB", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.txtPrecio.ForeColor = System.Drawing.Color.Gainsboro
		Me.txtPrecio.Location = New System.Drawing.Point(354, 190)
		Me.txtPrecio.Name = "txtPrecio"
		Me.txtPrecio.Size = New System.Drawing.Size(300, 33)
		Me.txtPrecio.TabIndex = 78
		Me.txtPrecio.Text = "Precio Pedido"
		'
		'txtClave
		'
		Me.txtClave.BackColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(104,Byte),Integer), CType(CType(130,Byte),Integer))
		Me.txtClave.Font = New System.Drawing.Font("Agency FB", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.txtClave.ForeColor = System.Drawing.Color.Gainsboro
		Me.txtClave.Location = New System.Drawing.Point(48, 72)
		Me.txtClave.Name = "txtClave"
		Me.txtClave.Size = New System.Drawing.Size(287, 33)
		Me.txtClave.TabIndex = 75
		Me.txtClave.Text = "Clave Pedido"
		'
		'lblTitulo
		'
		Me.lblTitulo.Dock = System.Windows.Forms.DockStyle.Top
		Me.lblTitulo.Font = New System.Drawing.Font("Agency FB", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.lblTitulo.ForeColor = System.Drawing.Color.White
		Me.lblTitulo.Location = New System.Drawing.Point(0, 0)
		Me.lblTitulo.Name = "lblTitulo"
		Me.lblTitulo.Size = New System.Drawing.Size(867, 69)
		Me.lblTitulo.TabIndex = 88
		Me.lblTitulo.Text = "Pedidos  TorumPaper"
		Me.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'dGVPedidos
		'
		Me.dGVPedidos.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(104,Byte),Integer), CType(CType(130,Byte),Integer))
		Me.dGVPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.dGVPedidos.Location = New System.Drawing.Point(48, 282)
		Me.dGVPedidos.Name = "dGVPedidos"
		Me.dGVPedidos.Size = New System.Drawing.Size(606, 180)
		Me.dGVPedidos.TabIndex = 89
		'
		'btnEliminar
		'
		Me.btnEliminar.BackColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(104,Byte),Integer), CType(CType(130,Byte),Integer))
		Me.btnEliminar.Font = New System.Drawing.Font("Agency FB", 18!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.btnEliminar.ForeColor = System.Drawing.Color.White
		Me.btnEliminar.Image = CType(resources.GetObject("btnEliminar.Image"),System.Drawing.Image)
		Me.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.btnEliminar.Location = New System.Drawing.Point(673, 350)
		Me.btnEliminar.Name = "btnEliminar"
		Me.btnEliminar.Size = New System.Drawing.Size(172, 51)
		Me.btnEliminar.TabIndex = 90
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
		Me.btnActualizar.Location = New System.Drawing.Point(673, 415)
		Me.btnActualizar.Name = "btnActualizar"
		Me.btnActualizar.Size = New System.Drawing.Size(172, 47)
		Me.btnActualizar.TabIndex = 91
		Me.btnActualizar.Text = "   Actualizar"
		Me.btnActualizar.UseVisualStyleBackColor = false
		'
		'lbltBuscar
		'
		Me.lbltBuscar.Font = New System.Drawing.Font("Agency FB", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.lbltBuscar.ForeColor = System.Drawing.Color.White
		Me.lbltBuscar.Location = New System.Drawing.Point(48, 242)
		Me.lbltBuscar.Name = "lbltBuscar"
		Me.lbltBuscar.Size = New System.Drawing.Size(98, 37)
		Me.lbltBuscar.TabIndex = 92
		Me.lbltBuscar.Text = "Buscar"
		Me.lbltBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'cmbBusqueda
		'
		Me.cmbBusqueda.BackColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(104,Byte),Integer), CType(CType(130,Byte),Integer))
		Me.cmbBusqueda.Font = New System.Drawing.Font("Agency FB", 16!, System.Drawing.FontStyle.Bold)
		Me.cmbBusqueda.ForeColor = System.Drawing.Color.Gainsboro
		Me.cmbBusqueda.FormattingEnabled = true
		Me.cmbBusqueda.Location = New System.Drawing.Point(141, 247)
		Me.cmbBusqueda.Name = "cmbBusqueda"
		Me.cmbBusqueda.Size = New System.Drawing.Size(255, 33)
		Me.cmbBusqueda.TabIndex = 93
		Me.cmbBusqueda.Text = "Buscar Por"
		'
		'btnBuscar
		'
		Me.btnBuscar.BackColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(104,Byte),Integer), CType(CType(130,Byte),Integer))
		Me.btnBuscar.Font = New System.Drawing.Font("Agency FB", 18!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.btnBuscar.ForeColor = System.Drawing.Color.White
		Me.btnBuscar.Image = CType(resources.GetObject("btnBuscar.Image"),System.Drawing.Image)
		Me.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.btnBuscar.Location = New System.Drawing.Point(673, 72)
		Me.btnBuscar.Name = "btnBuscar"
		Me.btnBuscar.Size = New System.Drawing.Size(172, 47)
		Me.btnBuscar.TabIndex = 94
		Me.btnBuscar.Text = "  Buscar"
		Me.btnBuscar.UseVisualStyleBackColor = false
		'
		'dTPBFecha
		'
		Me.dTPBFecha.CalendarFont = New System.Drawing.Font("Agency FB", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic),System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.dTPBFecha.Font = New System.Drawing.Font("Agency FB", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic),System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.dTPBFecha.Location = New System.Drawing.Point(402, 247)
		Me.dTPBFecha.Name = "dTPBFecha"
		Me.dTPBFecha.Size = New System.Drawing.Size(252, 33)
		Me.dTPBFecha.TabIndex = 95
		'
		'FrmPedidos
		'
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(104,Byte),Integer), CType(CType(130,Byte),Integer))
		Me.ClientSize = New System.Drawing.Size(867, 465)
		Me.Controls.Add(Me.dTPBFecha)
		Me.Controls.Add(Me.btnBuscar)
		Me.Controls.Add(Me.cmbBusqueda)
		Me.Controls.Add(Me.lbltBuscar)
		Me.Controls.Add(Me.btnActualizar)
		Me.Controls.Add(Me.btnEliminar)
		Me.Controls.Add(Me.dGVPedidos)
		Me.Controls.Add(Me.lblTitulo)
		Me.Controls.Add(Me.lbltCantidad)
		Me.Controls.Add(Me.dTpFecha)
		Me.Controls.Add(Me.nUDCantidadPedido)
		Me.Controls.Add(Me.cmBTipoProducto)
		Me.Controls.Add(Me.cmBMarca)
		Me.Controls.Add(Me.cmbProductos)
		Me.Controls.Add(Me.cmBCProvedor)
		Me.Controls.Add(Me.btnLimpiar)
		Me.Controls.Add(Me.btnRegistrar)
		Me.Controls.Add(Me.txtPrecio)
		Me.Controls.Add(Me.txtClave)
		Me.Name = "FrmPedidos"
		Me.Text = "FrmPedidos"
		CType(Me.nUDCantidadPedido,System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.dGVPedidos,System.ComponentModel.ISupportInitialize).EndInit
		Me.ResumeLayout(false)
		Me.PerformLayout
	End Sub
	Private dTPBFecha As System.Windows.Forms.DateTimePicker
	Private btnBuscar As System.Windows.Forms.Button
	Private cmbBusqueda As System.Windows.Forms.ComboBox
	Private lbltBuscar As System.Windows.Forms.Label
	Private btnActualizar As System.Windows.Forms.Button
	Private btnEliminar As System.Windows.Forms.Button
	Private dGVPedidos As System.Windows.Forms.DataGridView
	Private lblTitulo As System.Windows.Forms.Label
	Private txtClave As System.Windows.Forms.TextBox
	Private txtPrecio As System.Windows.Forms.TextBox
	Private btnRegistrar As System.Windows.Forms.Button
	Private btnLimpiar As System.Windows.Forms.Button
	Private cmBCProvedor As System.Windows.Forms.ComboBox
	Private cmbProductos As System.Windows.Forms.ComboBox
	Private cmBMarca As System.Windows.Forms.ComboBox
	Private cmBTipoProducto As System.Windows.Forms.ComboBox
	Private nUDCantidadPedido As System.Windows.Forms.NumericUpDown
	Private dTpFecha As System.Windows.Forms.DateTimePicker
	Private lbltCantidad As System.Windows.Forms.Label
End Class