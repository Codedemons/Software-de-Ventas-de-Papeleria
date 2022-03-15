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
		Me.pnlBarraTitulo.SuspendLayout
		CType(Me.pblogo,System.ComponentModel.ISupportInitialize).BeginInit
		Me.PnlContenido.SuspendLayout
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
		Me.pnlBarraTitulo.Size = New System.Drawing.Size(883, 40)
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
		Me.btnMini.Location = New System.Drawing.Point(779, 0)
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
		Me.btnClose.Location = New System.Drawing.Point(831, 0)
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
		Me.PnlContenido.Size = New System.Drawing.Size(883, 503)
		Me.PnlContenido.TabIndex = 1
		'
		'pnlMenu
		'
		Me.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left
		Me.pnlMenu.Location = New System.Drawing.Point(0, 0)
		Me.pnlMenu.Name = "pnlMenu"
		Me.pnlMenu.Size = New System.Drawing.Size(150, 503)
		Me.pnlMenu.TabIndex = 0
		'
		'MainForm
		'
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(104,Byte),Integer), CType(CType(130,Byte),Integer))
		Me.ClientSize = New System.Drawing.Size(883, 543)
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
		Me.ResumeLayout(false)
		Me.PerformLayout
	End Sub
	Private pnlMenu As System.Windows.Forms.Panel
	Private btnMini As System.Windows.Forms.Button
	Private btnClose As System.Windows.Forms.Button
	Private pblogo As System.Windows.Forms.PictureBox
	Private lbName As System.Windows.Forms.Label
	Private PnlContenido As System.Windows.Forms.Panel
	Private pnlBarraTitulo As System.Windows.Forms.Panel
End Class
