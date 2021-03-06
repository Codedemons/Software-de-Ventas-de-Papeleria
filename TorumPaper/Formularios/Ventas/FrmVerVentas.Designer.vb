'
' Created by SharpDevelop.
' User: Coderp
' Date: 16/03/2022
' Time: 17:02
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Partial Class FrmVerVentas
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
		Me.lbltBuscar = New System.Windows.Forms.Label()
		Me.dGVventas = New System.Windows.Forms.DataGridView()
		Me.dTPBFecha = New System.Windows.Forms.DateTimePicker()
		Me.txtBPrecio = New System.Windows.Forms.TextBox()
		Me.cmbProductos = New System.Windows.Forms.ComboBox()
		Me.textBox1 = New System.Windows.Forms.TextBox()
		CType(Me.dGVventas,System.ComponentModel.ISupportInitialize).BeginInit
		Me.SuspendLayout
		'
		'lblTitulo
		'
		Me.lblTitulo.Dock = System.Windows.Forms.DockStyle.Top
		Me.lblTitulo.Font = New System.Drawing.Font("Agency FB", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.lblTitulo.ForeColor = System.Drawing.Color.White
		Me.lblTitulo.Location = New System.Drawing.Point(0, 0)
		Me.lblTitulo.Name = "lblTitulo"
		Me.lblTitulo.Size = New System.Drawing.Size(867, 69)
		Me.lblTitulo.TabIndex = 90
		Me.lblTitulo.Text = "Ventas  TorumPaper"
		Me.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'lbltBuscar
		'
		Me.lbltBuscar.Font = New System.Drawing.Font("Agency FB", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.lbltBuscar.ForeColor = System.Drawing.Color.White
		Me.lbltBuscar.Location = New System.Drawing.Point(25, 66)
		Me.lbltBuscar.Name = "lbltBuscar"
		Me.lbltBuscar.Size = New System.Drawing.Size(98, 37)
		Me.lbltBuscar.TabIndex = 112
		Me.lbltBuscar.Text = "Buscar"
		Me.lbltBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'dGVventas
		'
		Me.dGVventas.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(104,Byte),Integer), CType(CType(130,Byte),Integer))
		Me.dGVventas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.dGVventas.Location = New System.Drawing.Point(25, 120)
		Me.dGVventas.Name = "dGVventas"
		Me.dGVventas.Size = New System.Drawing.Size(781, 333)
		Me.dGVventas.TabIndex = 109
		'
		'dTPBFecha
		'
		Me.dTPBFecha.CalendarFont = New System.Drawing.Font("Agency FB", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic),System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.dTPBFecha.Font = New System.Drawing.Font("Agency FB", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic),System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.dTPBFecha.Location = New System.Drawing.Point(554, 73)
		Me.dTPBFecha.Name = "dTPBFecha"
		Me.dTPBFecha.Size = New System.Drawing.Size(252, 33)
		Me.dTPBFecha.TabIndex = 115
		'
		'txtBPrecio
		'
		Me.txtBPrecio.BackColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(104,Byte),Integer), CType(CType(130,Byte),Integer))
		Me.txtBPrecio.Font = New System.Drawing.Font("Agency FB", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.txtBPrecio.ForeColor = System.Drawing.Color.White
		Me.txtBPrecio.Location = New System.Drawing.Point(254, 72)
		Me.txtBPrecio.Name = "txtBPrecio"
		Me.txtBPrecio.Size = New System.Drawing.Size(130, 30)
		Me.txtBPrecio.TabIndex = 116
		Me.txtBPrecio.Text = "Unidades"
		Me.txtBPrecio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		'
		'cmbProductos
		'
		Me.cmbProductos.BackColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(104,Byte),Integer), CType(CType(130,Byte),Integer))
		Me.cmbProductos.Font = New System.Drawing.Font("Agency FB", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.cmbProductos.ForeColor = System.Drawing.Color.White
		Me.cmbProductos.FormattingEnabled = true
		Me.cmbProductos.Items.AddRange(New Object() {"Stock Mínimo", "Stock Disponible", "Stock Máximo"})
		Me.cmbProductos.Location = New System.Drawing.Point(118, 72)
		Me.cmbProductos.Name = "cmbProductos"
		Me.cmbProductos.Size = New System.Drawing.Size(115, 32)
		Me.cmbProductos.TabIndex = 117
		Me.cmbProductos.Text = "Tipo"
		'
		'textBox1
		'
		Me.textBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(104,Byte),Integer), CType(CType(130,Byte),Integer))
		Me.textBox1.Font = New System.Drawing.Font("Agency FB", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.textBox1.ForeColor = System.Drawing.Color.White
		Me.textBox1.Location = New System.Drawing.Point(407, 73)
		Me.textBox1.Name = "textBox1"
		Me.textBox1.Size = New System.Drawing.Size(130, 30)
		Me.textBox1.TabIndex = 118
		Me.textBox1.Text = "Total Venta"
		Me.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		'
		'FrmVerVentas
		'
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(104,Byte),Integer), CType(CType(130,Byte),Integer))
		Me.ClientSize = New System.Drawing.Size(867, 465)
		Me.Controls.Add(Me.textBox1)
		Me.Controls.Add(Me.cmbProductos)
		Me.Controls.Add(Me.txtBPrecio)
		Me.Controls.Add(Me.dTPBFecha)
		Me.Controls.Add(Me.lbltBuscar)
		Me.Controls.Add(Me.dGVventas)
		Me.Controls.Add(Me.lblTitulo)
		Me.Name = "FrmVerVentas"
		Me.Text = "FrmVerVentas"
		AddHandler Load, AddressOf Me.FrmVerVentasLoad
		CType(Me.dGVventas,System.ComponentModel.ISupportInitialize).EndInit
		Me.ResumeLayout(false)
		Me.PerformLayout
	End Sub
	Private textBox1 As System.Windows.Forms.TextBox
	Private cmbProductos As System.Windows.Forms.ComboBox
	Private txtBPrecio As System.Windows.Forms.TextBox
	Private dTPBFecha As System.Windows.Forms.DateTimePicker
	Private dGVventas As System.Windows.Forms.DataGridView
	Private lbltBuscar As System.Windows.Forms.Label
	Private lblTitulo As System.Windows.Forms.Label
End Class
