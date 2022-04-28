'
' Created by SharpDevelop.
' User: Coderp
' Date: 10/03/2022
' Time: 17:52
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Partial Class FrmVentas
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
		Me.lblTitulo = New System.Windows.Forms.Label()
		Me.dataGridView1 = New System.Windows.Forms.DataGridView()
		Me.button1 = New System.Windows.Forms.Button()
		Me.label1 = New System.Windows.Forms.Label()
		Me.button2 = New System.Windows.Forms.Button()
		Me.comboBox1 = New System.Windows.Forms.ComboBox()
		CType(Me.dataGridView1,System.ComponentModel.ISupportInitialize).BeginInit
		Me.SuspendLayout
		'
		'lblTitulo
		'
		Me.lblTitulo.Dock = System.Windows.Forms.DockStyle.Top
		Me.lblTitulo.Font = New System.Drawing.Font("Agency FB", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.lblTitulo.ForeColor = System.Drawing.Color.White
		Me.lblTitulo.Location = New System.Drawing.Point(0, 0)
		Me.lblTitulo.Name = "lblTitulo"
		Me.lblTitulo.Size = New System.Drawing.Size(867, 62)
		Me.lblTitulo.TabIndex = 32
		Me.lblTitulo.Text = "Sistema de Venta TorumPaper"
		Me.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'dataGridView1
		'
		Me.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.dataGridView1.Location = New System.Drawing.Point(21, 131)
		Me.dataGridView1.Name = "dataGridView1"
		Me.dataGridView1.Size = New System.Drawing.Size(386, 171)
		Me.dataGridView1.TabIndex = 33
		'
		'button1
		'
		Me.button1.Location = New System.Drawing.Point(413, 314)
		Me.button1.Name = "button1"
		Me.button1.Size = New System.Drawing.Size(168, 55)
		Me.button1.TabIndex = 34
		Me.button1.Text = "Realizar Venta"
		Me.button1.UseVisualStyleBackColor = true
		'
		'label1
		'
		Me.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
		Me.label1.Location = New System.Drawing.Point(413, 131)
		Me.label1.Name = "label1"
		Me.label1.Size = New System.Drawing.Size(121, 171)
		Me.label1.TabIndex = 35
		Me.label1.Text = "Total"
		'
		'button2
		'
		Me.button2.Location = New System.Drawing.Point(289, 95)
		Me.button2.Name = "button2"
		Me.button2.Size = New System.Drawing.Size(118, 31)
		Me.button2.TabIndex = 37
		Me.button2.Text = "Agregar"
		Me.button2.UseVisualStyleBackColor = true
		'
		'comboBox1
		'
		Me.comboBox1.FormattingEnabled = true
		Me.comboBox1.Items.AddRange(New Object() {"huevos", "refrescos", "papel ", "lapiz"})
		Me.comboBox1.Location = New System.Drawing.Point(21, 95)
		Me.comboBox1.Name = "comboBox1"
		Me.comboBox1.Size = New System.Drawing.Size(262, 21)
		Me.comboBox1.TabIndex = 38
		'
		'FrmVentas
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(104,Byte),Integer), CType(CType(130,Byte),Integer))
		Me.ClientSize = New System.Drawing.Size(867, 465)
		Me.Controls.Add(Me.comboBox1)
		Me.Controls.Add(Me.button2)
		Me.Controls.Add(Me.label1)
		Me.Controls.Add(Me.button1)
		Me.Controls.Add(Me.dataGridView1)
		Me.Controls.Add(Me.lblTitulo)
		Me.Name = "FrmVentas"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "FrmVentas"
		CType(Me.dataGridView1,System.ComponentModel.ISupportInitialize).EndInit
		Me.ResumeLayout(false)
	End Sub
	Private comboBox1 As System.Windows.Forms.ComboBox
	Private button2 As System.Windows.Forms.Button
	Private label1 As System.Windows.Forms.Label
	Private button1 As System.Windows.Forms.Button
	Private dataGridView1 As System.Windows.Forms.DataGridView
	Private lblTitulo As System.Windows.Forms.Label
End Class
