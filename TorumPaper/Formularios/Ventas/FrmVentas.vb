'
' Created by SharpDevelop.
' User: Coderp
' Date: 10/03/2022
' Time: 17:52
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Public Partial Class FrmVentas
	Private ctrl As ClsTorumPaper		
	Public Sub New()
		' The Me.InitializeComponent call is required for Windows Forms designer support.
		Me.InitializeComponent()
		ctrl = New ClsTorumPaper()
		'
		' TODO : Add constructor code after InitializeComponents
		'
	End Sub

	
	Sub Label1Click(sender As Object, e As EventArgs)
		
	End Sub
	
	Sub FrmVentasLoad(sender As Object, e As EventArgs)
		Me.consultaProducto
	End Sub
	
	Private Sub consultaProducto()
		Dim consulta As String = "SELECT claveProducto, descripcionProducto FROM producto;"
		
		Me.cmbProductos.DataSource = Me.ctrl.consultasSql(consulta)
		Me.cmbProductos.ValueMember = "claveProducto"
		Me.cmbProductos.DisplayMember = "descripcionProducto"
		Me.cmbProductos.SelectedValue = ""
	End Sub

	
End Class
