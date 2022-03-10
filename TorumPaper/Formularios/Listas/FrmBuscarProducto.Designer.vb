'
' Creado por SharpDevelop.
' Usuario: JoCamLo-HP
' Fecha: 19/02/2022
' Hora: 07:19 p. m.
' 
' Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
'
Partial Class FrmBuscarProducto
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
		Me.comboBox1 = New System.Windows.Forms.ComboBox()
		Me.textBox2 = New System.Windows.Forms.TextBox()
		Me.comboBox2 = New System.Windows.Forms.ComboBox()
		Me.comboBox3 = New System.Windows.Forms.ComboBox()
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
		Me.lblListaPedidos.TabIndex = 2
		Me.lblListaPedidos.Text = "Productos"
		Me.lblListaPedidos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'dataGridView1
		'
		Me.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(104,Byte),Integer), CType(CType(130,Byte),Integer))
		Me.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.dataGridView1.Location = New System.Drawing.Point(12, 109)
		Me.dataGridView1.Name = "dataGridView1"
		Me.dataGridView1.Size = New System.Drawing.Size(452, 260)
		Me.dataGridView1.TabIndex = 3
		'
		'comboBox1
		'
		Me.comboBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(104,Byte),Integer), CType(CType(130,Byte),Integer))
		Me.comboBox1.Font = New System.Drawing.Font("Agency FB", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.comboBox1.ForeColor = System.Drawing.Color.White
		Me.comboBox1.FormattingEnabled = true
		Me.comboBox1.Items.AddRange(New Object() {"Stock Mínimo", "Stock Disponible", "Stock Máximo"})
		Me.comboBox1.Location = New System.Drawing.Point(350, 73)
		Me.comboBox1.Name = "comboBox1"
		Me.comboBox1.Size = New System.Drawing.Size(114, 32)
		Me.comboBox1.TabIndex = 4
		Me.comboBox1.Text = "Stock Mínimo"
		AddHandler Me.comboBox1.SelectedIndexChanged, AddressOf Me.ComboBox1SelectedIndexChanged
		'
		'textBox2
		'
		Me.textBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(104,Byte),Integer), CType(CType(130,Byte),Integer))
		Me.textBox2.Font = New System.Drawing.Font("Agency FB", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.textBox2.ForeColor = System.Drawing.Color.White
		Me.textBox2.Location = New System.Drawing.Point(226, 73)
		Me.textBox2.Name = "textBox2"
		Me.textBox2.Size = New System.Drawing.Size(118, 30)
		Me.textBox2.TabIndex = 9
		Me.textBox2.Text = "Precio"
		Me.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		'
		'comboBox2
		'
		Me.comboBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(104,Byte),Integer), CType(CType(130,Byte),Integer))
		Me.comboBox2.Font = New System.Drawing.Font("Agency FB", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.comboBox2.ForeColor = System.Drawing.Color.White
		Me.comboBox2.FormattingEnabled = true
		Me.comboBox2.Items.AddRange(New Object() {"Stock Mínimo", "Stock Disponible", "Stock Máximo"})
		Me.comboBox2.Location = New System.Drawing.Point(113, 71)
		Me.comboBox2.Name = "comboBox2"
		Me.comboBox2.Size = New System.Drawing.Size(107, 32)
		Me.comboBox2.TabIndex = 10
		Me.comboBox2.Text = "Tipo"
		'
		'comboBox3
		'
		Me.comboBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(104,Byte),Integer), CType(CType(130,Byte),Integer))
		Me.comboBox3.Font = New System.Drawing.Font("Agency FB", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.comboBox3.ForeColor = System.Drawing.Color.White
		Me.comboBox3.FormattingEnabled = true
		Me.comboBox3.Items.AddRange(New Object() {"Stock Mínimo", "Stock Disponible", "Stock Máximo"})
		Me.comboBox3.Location = New System.Drawing.Point(12, 71)
		Me.comboBox3.Name = "comboBox3"
		Me.comboBox3.Size = New System.Drawing.Size(95, 32)
		Me.comboBox3.TabIndex = 11
		Me.comboBox3.Text = "Marca"
		'
		'FrmBuscarProducto
		'
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(104,Byte),Integer), CType(CType(130,Byte),Integer))
		Me.ClientSize = New System.Drawing.Size(626, 381)
		Me.Controls.Add(Me.comboBox3)
		Me.Controls.Add(Me.comboBox2)
		Me.Controls.Add(Me.textBox2)
		Me.Controls.Add(Me.comboBox1)
		Me.Controls.Add(Me.dataGridView1)
		Me.Controls.Add(Me.lblListaPedidos)
		Me.Name = "FrmBuscarProducto"
		Me.Text = "BuscarProducto"
		CType(Me.dataGridView1,System.ComponentModel.ISupportInitialize).EndInit
		Me.ResumeLayout(false)
		Me.PerformLayout
	End Sub
	Private comboBox3 As System.Windows.Forms.ComboBox
	Private comboBox2 As System.Windows.Forms.ComboBox
	Private textBox2 As System.Windows.Forms.TextBox
	Private comboBox1 As System.Windows.Forms.ComboBox
	Private dataGridView1 As System.Windows.Forms.DataGridView
	Private lblListaPedidos As System.Windows.Forms.Label
End Class
