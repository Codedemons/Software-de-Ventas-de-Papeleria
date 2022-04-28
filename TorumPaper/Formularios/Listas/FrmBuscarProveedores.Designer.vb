'
' Creado por SharpDevelop.
' Usuario: JoCamLo-HP
' Fecha: 19/02/2022
' Hora: 06:22 p. m.
' 
' Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
'
Partial Class FrmBuscarProveedores
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
		Me.lblListaProveedores = New System.Windows.Forms.Label()
		Me.dataGridView1 = New System.Windows.Forms.DataGridView()
		Me.textBox1 = New System.Windows.Forms.TextBox()
		Me.comboBox1 = New System.Windows.Forms.ComboBox()
		Me.textBoxFiltroNombreProveedor = New System.Windows.Forms.TextBox()
		CType(Me.dataGridView1,System.ComponentModel.ISupportInitialize).BeginInit
		Me.SuspendLayout
		'
		'lblListaProveedores
		'
		Me.lblListaProveedores.Dock = System.Windows.Forms.DockStyle.Top
		Me.lblListaProveedores.Font = New System.Drawing.Font("Agency FB", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.lblListaProveedores.ForeColor = System.Drawing.Color.White
		Me.lblListaProveedores.Location = New System.Drawing.Point(0, 0)
		Me.lblListaProveedores.Name = "lblListaProveedores"
		Me.lblListaProveedores.Size = New System.Drawing.Size(626, 35)
		Me.lblListaProveedores.TabIndex = 0
		Me.lblListaProveedores.Text = "Proveedores"
		Me.lblListaProveedores.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'dataGridView1
		'
		Me.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(104,Byte),Integer), CType(CType(130,Byte),Integer))
		Me.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.dataGridView1.Location = New System.Drawing.Point(12, 111)
		Me.dataGridView1.Name = "dataGridView1"
		Me.dataGridView1.Size = New System.Drawing.Size(478, 260)
		Me.dataGridView1.TabIndex = 1
		'
		'textBox1
		'
		Me.textBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(104,Byte),Integer), CType(CType(130,Byte),Integer))
		Me.textBox1.Font = New System.Drawing.Font("Agency FB", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.textBox1.ForeColor = System.Drawing.Color.White
		Me.textBox1.Location = New System.Drawing.Point(74, 176)
		Me.textBox1.Name = "textBox1"
		Me.textBox1.Size = New System.Drawing.Size(160, 30)
		Me.textBox1.TabIndex = 7
		Me.textBox1.Text = "RFC"
		Me.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		'
		'comboBox1
		'
		Me.comboBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(104,Byte),Integer), CType(CType(130,Byte),Integer))
		Me.comboBox1.Font = New System.Drawing.Font("Agency FB", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.comboBox1.ForeColor = System.Drawing.Color.White
		Me.comboBox1.FormattingEnabled = true
		Me.comboBox1.Items.AddRange(New Object() {"Calificación Ascendente", "Calificación Descendente"})
		Me.comboBox1.Location = New System.Drawing.Point(378, 174)
		Me.comboBox1.Name = "comboBox1"
		Me.comboBox1.Size = New System.Drawing.Size(174, 32)
		Me.comboBox1.TabIndex = 6
		Me.comboBox1.Text = "Calificación Ascendente"
		'
		'textBoxFiltroNombreProveedor
		'
		Me.textBoxFiltroNombreProveedor.BackColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(104,Byte),Integer), CType(CType(130,Byte),Integer))
		Me.textBoxFiltroNombreProveedor.Font = New System.Drawing.Font("Agency FB", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.textBoxFiltroNombreProveedor.ForeColor = System.Drawing.Color.White
		Me.textBoxFiltroNombreProveedor.Location = New System.Drawing.Point(240, 176)
		Me.textBoxFiltroNombreProveedor.Name = "textBoxFiltroNombreProveedor"
		Me.textBoxFiltroNombreProveedor.Size = New System.Drawing.Size(132, 30)
		Me.textBoxFiltroNombreProveedor.TabIndex = 5
		Me.textBoxFiltroNombreProveedor.Text = "Nombre"
		Me.textBoxFiltroNombreProveedor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		'
		'FrmBuscarProveedores
		'
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(104,Byte),Integer), CType(CType(130,Byte),Integer))
		Me.ClientSize = New System.Drawing.Size(626, 381)
		Me.Controls.Add(Me.textBox1)
		Me.Controls.Add(Me.comboBox1)
		Me.Controls.Add(Me.textBoxFiltroNombreProveedor)
		Me.Controls.Add(Me.dataGridView1)
		Me.Controls.Add(Me.lblListaProveedores)
		Me.Name = "FrmBuscarProveedores"
		Me.Text = "ListaProveedores"
		CType(Me.dataGridView1,System.ComponentModel.ISupportInitialize).EndInit
		Me.ResumeLayout(false)
		Me.PerformLayout
	End Sub
	Private textBoxFiltroNombreProveedor As System.Windows.Forms.TextBox
	Private comboBox1 As System.Windows.Forms.ComboBox
	Private textBox1 As System.Windows.Forms.TextBox
	Private dataGridView1 As System.Windows.Forms.DataGridView
	Private lblListaProveedores As System.Windows.Forms.Label
End Class
