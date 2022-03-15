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
		Me.msMenu = New System.Windows.Forms.MenuStrip()
		Me.toolsToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
		Me.registrarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.mostrarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.TSMIEliminarProducto = New System.Windows.Forms.ToolStripMenuItem()
		Me.toolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
		Me.proveedorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.registrarToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
		Me.mostrarToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
		Me.TSMIEliminarProveedor = New System.Windows.Forms.ToolStripMenuItem()
		Me.pedidosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.registrarToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
		Me.mostrarToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
		Me.TSMIEliminarPedidos = New System.Windows.Forms.ToolStripMenuItem()
		Me.toolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
		Me.toolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
		Me.toolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem()
		Me.toolStripMenuItem5 = New System.Windows.Forms.ToolStripMenuItem()
		Me.pnlBarraTitulo.SuspendLayout
		CType(Me.pblogo,System.ComponentModel.ISupportInitialize).BeginInit
		Me.PnlContenido.SuspendLayout
		Me.msMenu.SuspendLayout
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
		Me.pnlBarraTitulo.Size = New System.Drawing.Size(720, 40)
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
		Me.btnMini.Location = New System.Drawing.Point(616, 0)
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
		Me.btnClose.Location = New System.Drawing.Point(668, 0)
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
		Me.PnlContenido.Controls.Add(Me.msMenu)
		Me.PnlContenido.Cursor = System.Windows.Forms.Cursors.Hand
		Me.PnlContenido.Dock = System.Windows.Forms.DockStyle.Fill
		Me.PnlContenido.Font = New System.Drawing.Font("Agency FB", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.PnlContenido.ForeColor = System.Drawing.Color.White
		Me.PnlContenido.ImeMode = System.Windows.Forms.ImeMode.Off
		Me.PnlContenido.Location = New System.Drawing.Point(0, 40)
		Me.PnlContenido.Name = "PnlContenido"
		Me.PnlContenido.Size = New System.Drawing.Size(720, 420)
		Me.PnlContenido.TabIndex = 1
		'
		'msMenu
		'
		Me.msMenu.AutoSize = false
		Me.msMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(105,Byte),Integer), CType(CType(152,Byte),Integer), CType(CType(171,Byte),Integer))
		Me.msMenu.Dock = System.Windows.Forms.DockStyle.Left
		Me.msMenu.GripMargin = New System.Windows.Forms.Padding(10)
		Me.msMenu.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible
		Me.msMenu.ImageScalingSize = New System.Drawing.Size(26, 26)
		Me.msMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolsToolStripMenuItem1, Me.toolStripMenuItem1, Me.proveedorToolStripMenuItem, Me.toolStripMenuItem2, Me.pedidosToolStripMenuItem})
		Me.msMenu.Location = New System.Drawing.Point(0, 0)
		Me.msMenu.Margin = New System.Windows.Forms.Padding(400)
		Me.msMenu.Name = "msMenu"
		Me.msMenu.Padding = New System.Windows.Forms.Padding(10)
		Me.msMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
		Me.msMenu.Size = New System.Drawing.Size(138, 420)
		Me.msMenu.TabIndex = 0
		Me.msMenu.Text = "MenuPaper"
		'
		'toolsToolStripMenuItem1
		'
		Me.toolsToolStripMenuItem1.Checked = true
		Me.toolsToolStripMenuItem1.CheckState = System.Windows.Forms.CheckState.Checked
		Me.toolsToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.registrarToolStripMenuItem, Me.mostrarToolStripMenuItem, Me.TSMIEliminarProducto})
		Me.toolsToolStripMenuItem1.Font = New System.Drawing.Font("Segoe UI", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.toolsToolStripMenuItem1.ForeColor = System.Drawing.Color.Black
		Me.toolsToolStripMenuItem1.Image = CType(resources.GetObject("toolsToolStripMenuItem1.Image"),System.Drawing.Image)
		Me.toolsToolStripMenuItem1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.toolsToolStripMenuItem1.ImageTransparentColor = System.Drawing.Color.Cyan
		Me.toolsToolStripMenuItem1.Name = "toolsToolStripMenuItem1"
		Me.toolsToolStripMenuItem1.Size = New System.Drawing.Size(117, 30)
		Me.toolsToolStripMenuItem1.Text = "Producto"
		'
		'registrarToolStripMenuItem
		'
		Me.registrarToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(177,Byte),Integer), CType(CType(208,Byte),Integer), CType(CType(224,Byte),Integer))
		Me.registrarToolStripMenuItem.Image = CType(resources.GetObject("registrarToolStripMenuItem.Image"),System.Drawing.Image)
		Me.registrarToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black
		Me.registrarToolStripMenuItem.Name = "registrarToolStripMenuItem"
		Me.registrarToolStripMenuItem.Size = New System.Drawing.Size(162, 32)
		Me.registrarToolStripMenuItem.Text = "Registrar"
		AddHandler Me.registrarToolStripMenuItem.Click, AddressOf Me.RegistrarToolStripMenuItemClick
		'
		'mostrarToolStripMenuItem
		'
		Me.mostrarToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(177,Byte),Integer), CType(CType(208,Byte),Integer), CType(CType(224,Byte),Integer))
		Me.mostrarToolStripMenuItem.Image = CType(resources.GetObject("mostrarToolStripMenuItem.Image"),System.Drawing.Image)
		Me.mostrarToolStripMenuItem.Name = "mostrarToolStripMenuItem"
		Me.mostrarToolStripMenuItem.Size = New System.Drawing.Size(162, 32)
		Me.mostrarToolStripMenuItem.Text = "Mostrar"
		AddHandler Me.mostrarToolStripMenuItem.Click, AddressOf Me.MostrarToolStripMenuItemClick
		'
		'TSMIEliminarProducto
		'
		Me.TSMIEliminarProducto.BackColor = System.Drawing.Color.FromArgb(CType(CType(177,Byte),Integer), CType(CType(208,Byte),Integer), CType(CType(224,Byte),Integer))
		Me.TSMIEliminarProducto.Image = CType(resources.GetObject("TSMIEliminarProducto.Image"),System.Drawing.Image)
		Me.TSMIEliminarProducto.Name = "TSMIEliminarProducto"
		Me.TSMIEliminarProducto.Size = New System.Drawing.Size(162, 32)
		Me.TSMIEliminarProducto.Text = "Eliminar"
		AddHandler Me.TSMIEliminarProducto.Click, AddressOf Me.TSMIEliminarProductoClick
		'
		'toolStripMenuItem1
		'
		Me.toolStripMenuItem1.ForeColor = System.Drawing.Color.Black
		Me.toolStripMenuItem1.Name = "toolStripMenuItem1"
		Me.toolStripMenuItem1.Size = New System.Drawing.Size(117, 4)
		'
		'proveedorToolStripMenuItem
		'
		Me.proveedorToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.registrarToolStripMenuItem1, Me.mostrarToolStripMenuItem1, Me.TSMIEliminarProveedor})
		Me.proveedorToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.proveedorToolStripMenuItem.ForeColor = System.Drawing.Color.Black
		Me.proveedorToolStripMenuItem.Image = CType(resources.GetObject("proveedorToolStripMenuItem.Image"),System.Drawing.Image)
		Me.proveedorToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.proveedorToolStripMenuItem.Name = "proveedorToolStripMenuItem"
		Me.proveedorToolStripMenuItem.Size = New System.Drawing.Size(117, 30)
		Me.proveedorToolStripMenuItem.Text = "Proveedor "
		'
		'registrarToolStripMenuItem1
		'
		Me.registrarToolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(CType(CType(177,Byte),Integer), CType(CType(208,Byte),Integer), CType(CType(224,Byte),Integer))
		Me.registrarToolStripMenuItem1.Image = CType(resources.GetObject("registrarToolStripMenuItem1.Image"),System.Drawing.Image)
		Me.registrarToolStripMenuItem1.Name = "registrarToolStripMenuItem1"
		Me.registrarToolStripMenuItem1.Size = New System.Drawing.Size(143, 26)
		Me.registrarToolStripMenuItem1.Text = "Registrar"
		AddHandler Me.registrarToolStripMenuItem1.Click, AddressOf Me.RegistrarToolStripMenuItem1Click
		'
		'mostrarToolStripMenuItem1
		'
		Me.mostrarToolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(CType(CType(177,Byte),Integer), CType(CType(208,Byte),Integer), CType(CType(224,Byte),Integer))
		Me.mostrarToolStripMenuItem1.Image = CType(resources.GetObject("mostrarToolStripMenuItem1.Image"),System.Drawing.Image)
		Me.mostrarToolStripMenuItem1.Name = "mostrarToolStripMenuItem1"
		Me.mostrarToolStripMenuItem1.Size = New System.Drawing.Size(143, 26)
		Me.mostrarToolStripMenuItem1.Text = "Mostrar"
		AddHandler Me.mostrarToolStripMenuItem1.Click, AddressOf Me.MostrarToolStripMenuItem1Click
		'
		'TSMIEliminarProveedor
		'
		Me.TSMIEliminarProveedor.BackColor = System.Drawing.Color.FromArgb(CType(CType(177,Byte),Integer), CType(CType(208,Byte),Integer), CType(CType(224,Byte),Integer))
		Me.TSMIEliminarProveedor.Image = CType(resources.GetObject("TSMIEliminarProveedor.Image"),System.Drawing.Image)
		Me.TSMIEliminarProveedor.Name = "TSMIEliminarProveedor"
		Me.TSMIEliminarProveedor.Size = New System.Drawing.Size(143, 26)
		Me.TSMIEliminarProveedor.Text = "Eliminar"
		AddHandler Me.TSMIEliminarProveedor.Click, AddressOf Me.TSMIEliminarProveedorClick
		'
		'pedidosToolStripMenuItem
		'
		Me.pedidosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.registrarToolStripMenuItem2, Me.mostrarToolStripMenuItem2, Me.TSMIEliminarPedidos})
		Me.pedidosToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.pedidosToolStripMenuItem.ForeColor = System.Drawing.Color.Black
		Me.pedidosToolStripMenuItem.Image = CType(resources.GetObject("pedidosToolStripMenuItem.Image"),System.Drawing.Image)
		Me.pedidosToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.pedidosToolStripMenuItem.Name = "pedidosToolStripMenuItem"
		Me.pedidosToolStripMenuItem.Size = New System.Drawing.Size(117, 30)
		Me.pedidosToolStripMenuItem.Text = "Pedidos"
		'
		'registrarToolStripMenuItem2
		'
		Me.registrarToolStripMenuItem2.BackColor = System.Drawing.Color.FromArgb(CType(CType(177,Byte),Integer), CType(CType(208,Byte),Integer), CType(CType(224,Byte),Integer))
		Me.registrarToolStripMenuItem2.Image = CType(resources.GetObject("registrarToolStripMenuItem2.Image"),System.Drawing.Image)
		Me.registrarToolStripMenuItem2.Name = "registrarToolStripMenuItem2"
		Me.registrarToolStripMenuItem2.Size = New System.Drawing.Size(162, 32)
		Me.registrarToolStripMenuItem2.Text = "Registrar"
		AddHandler Me.registrarToolStripMenuItem2.Click, AddressOf Me.RegistrarToolStripMenuItem2Click
		'
		'mostrarToolStripMenuItem2
		'
		Me.mostrarToolStripMenuItem2.BackColor = System.Drawing.Color.FromArgb(CType(CType(177,Byte),Integer), CType(CType(208,Byte),Integer), CType(CType(224,Byte),Integer))
		Me.mostrarToolStripMenuItem2.Image = CType(resources.GetObject("mostrarToolStripMenuItem2.Image"),System.Drawing.Image)
		Me.mostrarToolStripMenuItem2.Name = "mostrarToolStripMenuItem2"
		Me.mostrarToolStripMenuItem2.Size = New System.Drawing.Size(162, 32)
		Me.mostrarToolStripMenuItem2.Text = "Mostrar"
		AddHandler Me.mostrarToolStripMenuItem2.Click, AddressOf Me.MostrarToolStripMenuItem2Click
		'
		'TSMIEliminarPedidos
		'
		Me.TSMIEliminarPedidos.BackColor = System.Drawing.Color.FromArgb(CType(CType(177,Byte),Integer), CType(CType(208,Byte),Integer), CType(CType(224,Byte),Integer))
		Me.TSMIEliminarPedidos.Image = CType(resources.GetObject("TSMIEliminarPedidos.Image"),System.Drawing.Image)
		Me.TSMIEliminarPedidos.Name = "TSMIEliminarPedidos"
		Me.TSMIEliminarPedidos.Size = New System.Drawing.Size(162, 32)
		Me.TSMIEliminarPedidos.Text = "Eliminar"
		AddHandler Me.TSMIEliminarPedidos.Click, AddressOf Me.TSMIEliminarPedidosClick
		'
		'toolStripMenuItem2
		'
		Me.toolStripMenuItem2.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolStripMenuItem3, Me.toolStripMenuItem4, Me.toolStripMenuItem5})
		Me.toolStripMenuItem2.Font = New System.Drawing.Font("Segoe UI", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.toolStripMenuItem2.ForeColor = System.Drawing.Color.Black
		Me.toolStripMenuItem2.Image = CType(resources.GetObject("toolStripMenuItem2.Image"),System.Drawing.Image)
		Me.toolStripMenuItem2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.toolStripMenuItem2.Name = "toolStripMenuItem2"
		Me.toolStripMenuItem2.Size = New System.Drawing.Size(117, 30)
		Me.toolStripMenuItem2.Text = "Pedidos"
		'
		'toolStripMenuItem3
		'
		Me.toolStripMenuItem3.BackColor = System.Drawing.Color.FromArgb(CType(CType(177,Byte),Integer), CType(CType(208,Byte),Integer), CType(CType(224,Byte),Integer))
		Me.toolStripMenuItem3.Image = CType(resources.GetObject("toolStripMenuItem3.Image"),System.Drawing.Image)
		Me.toolStripMenuItem3.Name = "toolStripMenuItem3"
		Me.toolStripMenuItem3.Size = New System.Drawing.Size(162, 32)
		Me.toolStripMenuItem3.Text = "Registrar"
		'
		'toolStripMenuItem4
		'
		Me.toolStripMenuItem4.BackColor = System.Drawing.Color.FromArgb(CType(CType(177,Byte),Integer), CType(CType(208,Byte),Integer), CType(CType(224,Byte),Integer))
		Me.toolStripMenuItem4.Image = CType(resources.GetObject("toolStripMenuItem4.Image"),System.Drawing.Image)
		Me.toolStripMenuItem4.Name = "toolStripMenuItem4"
		Me.toolStripMenuItem4.Size = New System.Drawing.Size(162, 32)
		Me.toolStripMenuItem4.Text = "Mostrar"
		'
		'toolStripMenuItem5
		'
		Me.toolStripMenuItem5.BackColor = System.Drawing.Color.FromArgb(CType(CType(177,Byte),Integer), CType(CType(208,Byte),Integer), CType(CType(224,Byte),Integer))
		Me.toolStripMenuItem5.Image = CType(resources.GetObject("toolStripMenuItem5.Image"),System.Drawing.Image)
		Me.toolStripMenuItem5.Name = "toolStripMenuItem5"
		Me.toolStripMenuItem5.Size = New System.Drawing.Size(162, 32)
		Me.toolStripMenuItem5.Text = "Eliminar"
		'
		'MainForm
		'
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(104,Byte),Integer), CType(CType(130,Byte),Integer))
		Me.ClientSize = New System.Drawing.Size(720, 460)
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
		Me.msMenu.ResumeLayout(false)
		Me.msMenu.PerformLayout
		Me.ResumeLayout(false)
		Me.PerformLayout
	End Sub
	Private toolStripMenuItem5 As System.Windows.Forms.ToolStripMenuItem
	Private toolStripMenuItem4 As System.Windows.Forms.ToolStripMenuItem
	Private toolStripMenuItem3 As System.Windows.Forms.ToolStripMenuItem
	Private toolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
	Private btnMini As System.Windows.Forms.Button
	Private btnClose As System.Windows.Forms.Button
	Private TSMIEliminarPedidos As System.Windows.Forms.ToolStripMenuItem
	Private mostrarToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
	Private registrarToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
	Private TSMIEliminarProveedor As System.Windows.Forms.ToolStripMenuItem
	Private mostrarToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
	Private registrarToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
	Private TSMIEliminarProducto As System.Windows.Forms.ToolStripMenuItem
	Private mostrarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private registrarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private pedidosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private proveedorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private toolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
	Private toolsToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
	Private msMenu As System.Windows.Forms.MenuStrip
	Private pblogo As System.Windows.Forms.PictureBox
	Private lbName As System.Windows.Forms.Label
	Private PnlContenido As System.Windows.Forms.Panel
	Private pnlBarraTitulo As System.Windows.Forms.Panel
End Class
