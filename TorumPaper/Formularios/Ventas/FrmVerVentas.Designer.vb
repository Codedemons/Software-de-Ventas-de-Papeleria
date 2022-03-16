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
		Me.comboBox5 = New System.Windows.Forms.ComboBox()
		Me.lbltBuscar = New System.Windows.Forms.Label()
		Me.dGVProductos = New System.Windows.Forms.DataGridView()
		CType(Me.dGVProductos,System.ComponentModel.ISupportInitialize).BeginInit
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
		'comboBox5
		'
		Me.comboBox5.BackColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(104,Byte),Integer), CType(CType(130,Byte),Integer))
		Me.comboBox5.Font = New System.Drawing.Font("Agency FB", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.comboBox5.ForeColor = System.Drawing.Color.White
		Me.comboBox5.FormattingEnabled = true
		Me.comboBox5.Items.AddRange(New Object() {"Stock Mínimo", "Stock Disponible", "Stock Máximo"})
		Me.comboBox5.Location = New System.Drawing.Point(141, 71)
		Me.comboBox5.Name = "comboBox5"
		Me.comboBox5.Size = New System.Drawing.Size(169, 32)
		Me.comboBox5.TabIndex = 114
		Me.comboBox5.Text = "Tipo"
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
		'dGVProductos
		'
		Me.dGVProductos.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(104,Byte),Integer), CType(CType(130,Byte),Integer))
		Me.dGVProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.dGVProductos.Location = New System.Drawing.Point(25, 120)
		Me.dGVProductos.Name = "dGVProductos"
		Me.dGVProductos.Size = New System.Drawing.Size(781, 287)
		Me.dGVProductos.TabIndex = 109
		'
		'FrmVerVentas
		'
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(104,Byte),Integer), CType(CType(130,Byte),Integer))
		Me.ClientSize = New System.Drawing.Size(867, 465)
		Me.Controls.Add(Me.comboBox5)
		Me.Controls.Add(Me.lbltBuscar)
		Me.Controls.Add(Me.dGVProductos)
		Me.Controls.Add(Me.lblTitulo)
		Me.Name = "FrmVerVentas"
		Me.Text = "FrmVerVentas"
		CType(Me.dGVProductos,System.ComponentModel.ISupportInitialize).EndInit
		Me.ResumeLayout(false)
	End Sub
	Private dGVProductos As System.Windows.Forms.DataGridView
	Private lbltBuscar As System.Windows.Forms.Label
	Private comboBox5 As System.Windows.Forms.ComboBox
	Private lblTitulo As System.Windows.Forms.Label
End Class
