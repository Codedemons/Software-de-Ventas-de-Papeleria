'
' Created by SharpDevelop.
' User: Coderp
' Date: 18/02/2022
' Time: 22:26
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Partial Class MainForm
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
		Me.pnlBarraTitulo = New System.Windows.Forms.Panel()
		Me.btnMini = New System.Windows.Forms.Button()
		Me.btnClose = New System.Windows.Forms.Button()
		Me.lbName = New System.Windows.Forms.Label()
		Me.pblogo = New System.Windows.Forms.PictureBox()
		Me.PnlContenido = New System.Windows.Forms.Panel()
		Me.pnlMenu = New System.Windows.Forms.Panel()
		Me.pbLogoMenu = New System.Windows.Forms.PictureBox()
		Me.Panel6 = New System.Windows.Forms.Panel()
		Me.btnEmpleados = New System.Windows.Forms.Button()
		Me.Panel5 = New System.Windows.Forms.Panel()
		Me.btnPedidos = New System.Windows.Forms.Button()
		Me.pnlProveedores = New System.Windows.Forms.Panel()
		Me.btnProveedores = New System.Windows.Forms.Button()
		Me.Panel3 = New System.Windows.Forms.Panel()
		Me.btnVentas = New System.Windows.Forms.Button()
		Me.Panel2 = New System.Windows.Forms.Panel()
		Me.Panel10 = New System.Windows.Forms.Panel()
		Me.btnTProductos = New System.Windows.Forms.Button()
		Me.btnProductos = New System.Windows.Forms.Button()
		Me.pnlBarraTitulo.SuspendLayout
		CType(Me.pblogo,System.ComponentModel.ISupportInitialize).BeginInit
		Me.PnlContenido.SuspendLayout
		Me.pnlMenu.SuspendLayout
		CType(Me.pbLogoMenu,System.ComponentModel.ISupportInitialize).BeginInit
		Me.SuspendLayout
		'
		'pnlBarraTitulo
		'
		Me.pnlBarraTitulo.BackColor = System.Drawing.Color.FromArgb(CType(CType(26,Byte),Integer), CType(CType(55,Byte),Integer), CType(CType(77,Byte),Integer))
		Me.pnlBarraTitulo.Controls.Add(Me.btnMini)
		Me.pnlBarraTitulo.Controls.Add(Me.btnClose)
		Me.pnlBarraTitulo.Controls.Add(Me.lbName)
		Me.pnlBarraTitulo.Controls.Add(Me.pblogo)
		Me.pnlBarraTitulo.Dock = System.Windows.Forms.DockStyle.Top
		Me.pnlBarraTitulo.Location = New System.Drawing.Point(0, 0)
		Me.pnlBarraTitulo.Name = "pnlBarraTitulo"
		Me.pnlBarraTitulo.Size = New System.Drawing.Size(1070, 40)
		Me.pnlBarraTitulo.TabIndex = 0
		AddHandler Me.pnlBarraTitulo.MouseDown, AddressOf Me.PnlBarraTituloMouseDown
		'
		'btnMini
		'
		Me.btnMini.BackColor = System.Drawing.Color.Transparent
		Me.btnMini.Dock = System.Windows.Forms.DockStyle.Right
		Me.btnMini.FlatAppearance.BorderSize = 0
		Me.btnMini.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue
		Me.btnMini.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(128,Byte),Integer), CType(CType(128,Byte),Integer), CType(CType(255,Byte),Integer))
		Me.btnMini.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnMini.Image = CType(resources.GetObject("btnMini.Image"),System.Drawing.Image)
		Me.btnMini.Location = New System.Drawing.Point(966, 0)
		Me.btnMini.Name = "btnMini"
		Me.btnMini.Size = New System.Drawing.Size(52, 40)
		Me.btnMini.TabIndex = 5
		Me.btnMini.UseVisualStyleBackColor = false
		AddHandler Me.btnMini.Click, AddressOf Me.BtnMiniClick
		'
		'btnClose
		'
		Me.btnClose.BackColor = System.Drawing.Color.Transparent
		Me.btnClose.Dock = System.Windows.Forms.DockStyle.Right
		Me.btnClose.FlatAppearance.BorderSize = 0
		Me.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
		Me.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255,Byte),Integer), CType(CType(128,Byte),Integer), CType(CType(128,Byte),Integer))
		Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnClose.Image = CType(resources.GetObject("btnClose.Image"),System.Drawing.Image)
		Me.btnClose.Location = New System.Drawing.Point(1018, 0)
		Me.btnClose.Name = "btnClose"
		Me.btnClose.Size = New System.Drawing.Size(52, 40)
		Me.btnClose.TabIndex = 4
		Me.btnClose.UseVisualStyleBackColor = false
		AddHandler Me.btnClose.Click, AddressOf Me.BtnCloseClick
		'
		'lbName
		'
		Me.lbName.Dock = System.Windows.Forms.DockStyle.Left
		Me.lbName.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.lbName.Location = New System.Drawing.Point(44, 0)
		Me.lbName.Name = "lbName"
		Me.lbName.Size = New System.Drawing.Size(154, 40)
		Me.lbName.TabIndex = 3
		Me.lbName.Text = "TorumPaper"
		Me.lbName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		AddHandler Me.lbName.MouseDown, AddressOf Me.LbNameMouseDown
		'
		'pblogo
		'
		Me.pblogo.Dock = System.Windows.Forms.DockStyle.Left
		Me.pblogo.Image = CType(resources.GetObject("pblogo.Image"),System.Drawing.Image)
		Me.pblogo.Location = New System.Drawing.Point(0, 0)
		Me.pblogo.Name = "pblogo"
		Me.pblogo.Size = New System.Drawing.Size(44, 40)
		Me.pblogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
		Me.pblogo.TabIndex = 2
		Me.pblogo.TabStop = false
		AddHandler Me.pblogo.MouseDown, AddressOf Me.PblogoMouseDown
		'
		'PnlContenido
		'
		Me.PnlContenido.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar
		Me.PnlContenido.AllowDrop = true
		Me.PnlContenido.AutoSize = true
		Me.PnlContenido.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.PnlContenido.Controls.Add(Me.pnlMenu)
		Me.PnlContenido.Cursor = System.Windows.Forms.Cursors.Hand
		Me.PnlContenido.Dock = System.Windows.Forms.DockStyle.Fill
		Me.PnlContenido.Font = New System.Drawing.Font("Agency FB", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.PnlContenido.ForeColor = System.Drawing.Color.White
		Me.PnlContenido.ImeMode = System.Windows.Forms.ImeMode.Off
		Me.PnlContenido.Location = New System.Drawing.Point(0, 40)
		Me.PnlContenido.Name = "PnlContenido"
		Me.PnlContenido.Size = New System.Drawing.Size(1070, 510)
		Me.PnlContenido.TabIndex = 1
		'
		'pnlMenu
		'
		Me.pnlMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(104,Byte),Integer), CType(CType(110,Byte),Integer))
		Me.pnlMenu.Controls.Add(Me.pbLogoMenu)
		Me.pnlMenu.Controls.Add(Me.Panel6)
		Me.pnlMenu.Controls.Add(Me.btnEmpleados)
		Me.pnlMenu.Controls.Add(Me.Panel5)
		Me.pnlMenu.Controls.Add(Me.btnPedidos)
		Me.pnlMenu.Controls.Add(Me.pnlProveedores)
		Me.pnlMenu.Controls.Add(Me.btnProveedores)
		Me.pnlMenu.Controls.Add(Me.Panel3)
		Me.pnlMenu.Controls.Add(Me.btnVentas)
		Me.pnlMenu.Controls.Add(Me.Panel2)
		Me.pnlMenu.Controls.Add(Me.Panel10)
		Me.pnlMenu.Controls.Add(Me.btnTProductos)
		Me.pnlMenu.Controls.Add(Me.btnProductos)
		Me.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left
		Me.pnlMenu.Location = New System.Drawing.Point(0, 0)
		Me.pnlMenu.Name = "pnlMenu"
		Me.pnlMenu.Size = New System.Drawing.Size(200, 510)
		Me.pnlMenu.TabIndex = 0
		'
		'pbLogoMenu
		'
		Me.pbLogoMenu.Dock = System.Windows.Forms.DockStyle.Top
		Me.pbLogoMenu.Image = CType(resources.GetObject("pbLogoMenu.Image"),System.Drawing.Image)
		Me.pbLogoMenu.Location = New System.Drawing.Point(0, 0)
		Me.pbLogoMenu.Name = "pbLogoMenu"
		Me.pbLogoMenu.Size = New System.Drawing.Size(200, 120)
		Me.pbLogoMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
		Me.pbLogoMenu.TabIndex = 28
		Me.pbLogoMenu.TabStop = false
		'
		'Panel6
		'
		Me.Panel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(145,Byte),Integer), CType(CType(110,Byte),Integer), CType(CType(21,Byte),Integer))
		Me.Panel6.Location = New System.Drawing.Point(3, 405)
		Me.Panel6.Name = "Panel6"
		Me.Panel6.Size = New System.Drawing.Size(5, 50)
		Me.Panel6.TabIndex = 26
		'
		'btnEmpleados
		'
		Me.btnEmpleados.FlatAppearance.BorderSize = 0
		Me.btnEmpleados.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(145,Byte),Integer), CType(CType(110,Byte),Integer), CType(CType(21,Byte),Integer))
		Me.btnEmpleados.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(44,Byte),Integer), CType(CType(55,Byte),Integer), CType(CType(70,Byte),Integer))
		Me.btnEmpleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnEmpleados.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.btnEmpleados.ForeColor = System.Drawing.Color.White
		Me.btnEmpleados.Image = CType(resources.GetObject("btnEmpleados.Image"),System.Drawing.Image)
		Me.btnEmpleados.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.btnEmpleados.Location = New System.Drawing.Point(3, 405)
		Me.btnEmpleados.Name = "btnEmpleados"
		Me.btnEmpleados.Size = New System.Drawing.Size(200, 50)
		Me.btnEmpleados.TabIndex = 25
		Me.btnEmpleados.Text = "  Empleados"
		Me.btnEmpleados.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.btnEmpleados.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
		Me.btnEmpleados.UseVisualStyleBackColor = true
		'
		'Panel5
		'
		Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(145,Byte),Integer), CType(CType(110,Byte),Integer), CType(CType(21,Byte),Integer))
		Me.Panel5.Location = New System.Drawing.Point(3, 349)
		Me.Panel5.Name = "Panel5"
		Me.Panel5.Size = New System.Drawing.Size(5, 50)
		Me.Panel5.TabIndex = 24
		'
		'btnPedidos
		'
		Me.btnPedidos.FlatAppearance.BorderSize = 0
		Me.btnPedidos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(145,Byte),Integer), CType(CType(110,Byte),Integer), CType(CType(21,Byte),Integer))
		Me.btnPedidos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(44,Byte),Integer), CType(CType(55,Byte),Integer), CType(CType(70,Byte),Integer))
		Me.btnPedidos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnPedidos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.btnPedidos.ForeColor = System.Drawing.Color.White
		Me.btnPedidos.Image = CType(resources.GetObject("btnPedidos.Image"),System.Drawing.Image)
		Me.btnPedidos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.btnPedidos.Location = New System.Drawing.Point(1, 352)
		Me.btnPedidos.Name = "btnPedidos"
		Me.btnPedidos.Size = New System.Drawing.Size(200, 50)
		Me.btnPedidos.TabIndex = 23
		Me.btnPedidos.Text = "  Pedidos"
		Me.btnPedidos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.btnPedidos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
		Me.btnPedidos.UseVisualStyleBackColor = true
		AddHandler Me.btnPedidos.Click, AddressOf Me.BtnPedidosClick
		'
		'pnlProveedores
		'
		Me.pnlProveedores.BackColor = System.Drawing.Color.FromArgb(CType(CType(145,Byte),Integer), CType(CType(110,Byte),Integer), CType(CType(21,Byte),Integer))
		Me.pnlProveedores.Location = New System.Drawing.Point(3, 293)
		Me.pnlProveedores.Name = "pnlProveedores"
		Me.pnlProveedores.Size = New System.Drawing.Size(5, 50)
		Me.pnlProveedores.TabIndex = 22
		'
		'btnProveedores
		'
		Me.btnProveedores.FlatAppearance.BorderSize = 0
		Me.btnProveedores.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(145,Byte),Integer), CType(CType(110,Byte),Integer), CType(CType(21,Byte),Integer))
		Me.btnProveedores.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(44,Byte),Integer), CType(CType(55,Byte),Integer), CType(CType(70,Byte),Integer))
		Me.btnProveedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnProveedores.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.btnProveedores.ForeColor = System.Drawing.Color.White
		Me.btnProveedores.Image = CType(resources.GetObject("btnProveedores.Image"),System.Drawing.Image)
		Me.btnProveedores.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.btnProveedores.Location = New System.Drawing.Point(3, 293)
		Me.btnProveedores.Name = "btnProveedores"
		Me.btnProveedores.Size = New System.Drawing.Size(200, 50)
		Me.btnProveedores.TabIndex = 21
		Me.btnProveedores.Text = "Proveedores"
		Me.btnProveedores.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.btnProveedores.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
		Me.btnProveedores.UseVisualStyleBackColor = true
		AddHandler Me.btnProveedores.Click, AddressOf Me.BtnProveedoresClick
		'
		'Panel3
		'
		Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(145,Byte),Integer), CType(CType(110,Byte),Integer), CType(CType(21,Byte),Integer))
		Me.Panel3.Location = New System.Drawing.Point(3, 237)
		Me.Panel3.Name = "Panel3"
		Me.Panel3.Size = New System.Drawing.Size(5, 50)
		Me.Panel3.TabIndex = 20
		'
		'btnVentas
		'
		Me.btnVentas.FlatAppearance.BorderSize = 0
		Me.btnVentas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(145,Byte),Integer), CType(CType(110,Byte),Integer), CType(CType(21,Byte),Integer))
		Me.btnVentas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(44,Byte),Integer), CType(CType(55,Byte),Integer), CType(CType(70,Byte),Integer))
		Me.btnVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnVentas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.btnVentas.ForeColor = System.Drawing.Color.White
		Me.btnVentas.Image = CType(resources.GetObject("btnVentas.Image"),System.Drawing.Image)
		Me.btnVentas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.btnVentas.Location = New System.Drawing.Point(-1, 237)
		Me.btnVentas.Name = "btnVentas"
		Me.btnVentas.Size = New System.Drawing.Size(200, 50)
		Me.btnVentas.TabIndex = 19
		Me.btnVentas.Text = "  Ventas"
		Me.btnVentas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.btnVentas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
		Me.btnVentas.UseVisualStyleBackColor = true
		AddHandler Me.btnVentas.Click, AddressOf Me.BtnVentasClick
		'
		'Panel2
		'
		Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(145,Byte),Integer), CType(CType(110,Byte),Integer), CType(CType(21,Byte),Integer))
		Me.Panel2.Location = New System.Drawing.Point(3, 181)
		Me.Panel2.Name = "Panel2"
		Me.Panel2.Size = New System.Drawing.Size(5, 50)
		Me.Panel2.TabIndex = 18
		'
		'Panel10
		'
		Me.Panel10.BackColor = System.Drawing.Color.FromArgb(CType(CType(145,Byte),Integer), CType(CType(110,Byte),Integer), CType(CType(21,Byte),Integer))
		Me.Panel10.Location = New System.Drawing.Point(3, 125)
		Me.Panel10.Name = "Panel10"
		Me.Panel10.Size = New System.Drawing.Size(5, 50)
		Me.Panel10.TabIndex = 16
		'
		'btnTProductos
		'
		Me.btnTProductos.FlatAppearance.BorderSize = 0
		Me.btnTProductos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(145,Byte),Integer), CType(CType(110,Byte),Integer), CType(CType(21,Byte),Integer))
		Me.btnTProductos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(44,Byte),Integer), CType(CType(55,Byte),Integer), CType(CType(70,Byte),Integer))
		Me.btnTProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnTProductos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.btnTProductos.ForeColor = System.Drawing.Color.White
		Me.btnTProductos.Image = CType(resources.GetObject("btnTProductos.Image"),System.Drawing.Image)
		Me.btnTProductos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.btnTProductos.Location = New System.Drawing.Point(4, 181)
		Me.btnTProductos.Name = "btnTProductos"
		Me.btnTProductos.Size = New System.Drawing.Size(200, 50)
		Me.btnTProductos.TabIndex = 15
		Me.btnTProductos.Text = "  Tipos Productos"
		Me.btnTProductos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.btnTProductos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
		Me.btnTProductos.UseVisualStyleBackColor = true
		AddHandler Me.btnTProductos.Click, AddressOf Me.BtnTProductosClick
		'
		'btnProductos
		'
		Me.btnProductos.FlatAppearance.BorderSize = 0
		Me.btnProductos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(145,Byte),Integer), CType(CType(110,Byte),Integer), CType(CType(21,Byte),Integer))
		Me.btnProductos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(44,Byte),Integer), CType(CType(55,Byte),Integer), CType(CType(70,Byte),Integer))
		Me.btnProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnProductos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.btnProductos.ForeColor = System.Drawing.Color.White
		Me.btnProductos.Image = CType(resources.GetObject("btnProductos.Image"),System.Drawing.Image)
		Me.btnProductos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.btnProductos.Location = New System.Drawing.Point(0, 126)
		Me.btnProductos.Name = "btnProductos"
		Me.btnProductos.Size = New System.Drawing.Size(200, 50)
		Me.btnProductos.TabIndex = 17
		Me.btnProductos.Text = "  Productos"
		Me.btnProductos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.btnProductos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
		Me.btnProductos.UseVisualStyleBackColor = true
		AddHandler Me.btnProductos.Click, AddressOf Me.BtnProductosClick
		'
		'MainForm
		'
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(104,Byte),Integer), CType(CType(130,Byte),Integer))
		Me.ClientSize = New System.Drawing.Size(1070, 550)
		Me.Controls.Add(Me.PnlContenido)
		Me.Controls.Add(Me.pnlBarraTitulo)
		Me.ForeColor = System.Drawing.Color.White
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
		Me.Name = "MainForm"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "TorumPaper"
		Me.pnlBarraTitulo.ResumeLayout(false)
		CType(Me.pblogo,System.ComponentModel.ISupportInitialize).EndInit
		Me.PnlContenido.ResumeLayout(false)
		Me.pnlMenu.ResumeLayout(false)
		CType(Me.pbLogoMenu,System.ComponentModel.ISupportInitialize).EndInit
		Me.ResumeLayout(false)
		Me.PerformLayout
	End Sub
	Private pbLogoMenu As System.Windows.Forms.PictureBox
	Friend btnTProductos As System.Windows.Forms.Button
	Friend Panel10 As System.Windows.Forms.Panel
	Friend btnProductos As System.Windows.Forms.Button
	Friend Panel2 As System.Windows.Forms.Panel
	Friend btnVentas As System.Windows.Forms.Button
	Friend Panel3 As System.Windows.Forms.Panel
	Friend btnProveedores As System.Windows.Forms.Button
	Friend pnlProveedores As System.Windows.Forms.Panel
	Friend btnPedidos As System.Windows.Forms.Button
	Friend Panel5 As System.Windows.Forms.Panel
	Friend btnEmpleados As System.Windows.Forms.Button
	Friend Panel6 As System.Windows.Forms.Panel
	Private pnlMenu As System.Windows.Forms.Panel
	Private btnMini As System.Windows.Forms.Button
	Private btnClose As System.Windows.Forms.Button
	Private pblogo As System.Windows.Forms.PictureBox
	Private lbName As System.Windows.Forms.Label
	Private PnlContenido As System.Windows.Forms.Panel
	Private pnlBarraTitulo As System.Windows.Forms.Panel
End Class
