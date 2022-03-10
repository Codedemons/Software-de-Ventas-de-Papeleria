'
' Creado por SharpDevelop.
' Usuario: JoCamLo-HP
' Fecha: 19/02/2022
' Hora: 07:09 p. m.
' 
' Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
'
Partial Class FrmBuscarPedido
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
		Me.lblListaPedidos = New System.Windows.Forms.Label()
		Me.dataGridView1 = New System.Windows.Forms.DataGridView()
		Me.dateTimePicker1 = New System.Windows.Forms.DateTimePicker()
		Me.textBox2 = New System.Windows.Forms.TextBox()
		Me.textBox1 = New System.Windows.Forms.TextBox()
		Me.textBox3 = New System.Windows.Forms.TextBox()
		CType(Me.dataGridView1,System.ComponentModel.ISupportInitialize).BeginInit
		Me.SuspendLayout
		'
		'lblListaPedidos
		'
		Me.lblListaPedidos.Dock = System.Windows.Forms.DockStyle.Top
		Me.lblListaPedidos.Font = New System.Drawing.Font("Agency FB", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.lblListaPedidos.ForeColor = System.Drawing.Color.White
		Me.lblListaPedidos.Location = New System.Drawing.Point(0, 0)
		Me.lblListaPedidos.Name = "lblListaPedidos"
		Me.lblListaPedidos.Size = New System.Drawing.Size(626, 35)
		Me.lblListaPedidos.TabIndex = 1
		Me.lblListaPedidos.Text = "Pedidos"
		Me.lblListaPedidos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'dataGridView1
		'
		Me.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(104,Byte),Integer), CType(CType(130,Byte),Integer))
		Me.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.dataGridView1.Location = New System.Drawing.Point(12, 109)
		Me.dataGridView1.Name = "dataGridView1"
		Me.dataGridView1.Size = New System.Drawing.Size(463, 260)
		Me.dataGridView1.TabIndex = 2
		'
		'dateTimePicker1
		'
		Me.dateTimePicker1.CalendarFont = New System.Drawing.Font("Agency FB", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.dateTimePicker1.Font = New System.Drawing.Font("Agency FB", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
		Me.dateTimePicker1.Location = New System.Drawing.Point(364, 71)
		Me.dateTimePicker1.Name = "dateTimePicker1"
		Me.dateTimePicker1.Size = New System.Drawing.Size(111, 30)
		Me.dateTimePicker1.TabIndex = 9
		'
		'textBox2
		'
		Me.textBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(104,Byte),Integer), CType(CType(130,Byte),Integer))
		Me.textBox2.Font = New System.Drawing.Font("Agency FB", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.textBox2.ForeColor = System.Drawing.Color.White
		Me.textBox2.Location = New System.Drawing.Point(257, 71)
		Me.textBox2.Name = "textBox2"
		Me.textBox2.Size = New System.Drawing.Size(101, 30)
		Me.textBox2.TabIndex = 8
		Me.textBox2.Text = "Costo"
		Me.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		'
		'textBox1
		'
		Me.textBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(104,Byte),Integer), CType(CType(130,Byte),Integer))
		Me.textBox1.Font = New System.Drawing.Font("Agency FB", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.textBox1.ForeColor = System.Drawing.Color.White
		Me.textBox1.Location = New System.Drawing.Point(134, 71)
		Me.textBox1.Name = "textBox1"
		Me.textBox1.Size = New System.Drawing.Size(117, 30)
		Me.textBox1.TabIndex = 7
		Me.textBox1.Text = "Cantidad"
		Me.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		'
		'textBox3
		'
		Me.textBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(104,Byte),Integer), CType(CType(130,Byte),Integer))
		Me.textBox3.Font = New System.Drawing.Font("Agency FB", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.textBox3.ForeColor = System.Drawing.Color.White
		Me.textBox3.Location = New System.Drawing.Point(12, 71)
		Me.textBox3.Name = "textBox3"
		Me.textBox3.Size = New System.Drawing.Size(116, 30)
		Me.textBox3.TabIndex = 10
		Me.textBox3.Text = "Clave"
		Me.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		'
		'FrmBuscarPedido
		'
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(104,Byte),Integer), CType(CType(130,Byte),Integer))
		Me.ClientSize = New System.Drawing.Size(626, 381)
		Me.Controls.Add(Me.textBox3)
		Me.Controls.Add(Me.dateTimePicker1)
		Me.Controls.Add(Me.textBox2)
		Me.Controls.Add(Me.textBox1)
		Me.Controls.Add(Me.dataGridView1)
		Me.Controls.Add(Me.lblListaPedidos)
		Me.Name = "FrmBuscarPedido"
		Me.Text = "ListaPedido"
		CType(Me.dataGridView1,System.ComponentModel.ISupportInitialize).EndInit
		Me.ResumeLayout(false)
		Me.PerformLayout
	End Sub
	Private textBox3 As System.Windows.Forms.TextBox
	Private dateTimePicker1 As System.Windows.Forms.DateTimePicker
	Private textBox2 As System.Windows.Forms.TextBox
	Private textBox1 As System.Windows.Forms.TextBox
	Private dataGridView1 As System.Windows.Forms.DataGridView
	Private lblListaPedidos As System.Windows.Forms.Label
End Class
