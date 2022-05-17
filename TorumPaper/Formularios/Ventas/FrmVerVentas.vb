'
' Created by SharpDevelop.
' User: Coderp
' Date: 16/03/2022
' Time: 17:02
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Public Partial Class FrmVerVentas
	
	Private ctrl As ClsTorumPaper
	
	Private t As New Data.DataTable
	Private v As New Data.DataView
	Dim Consulta As String = "SELECT * FROM v_ventas;"
	
	Public Sub New()
		' The Me.InitializeComponent call is required for Windows Forms designer support.
		Me.InitializeComponent()			
		Me.ctrl = New ClsTorumPaper
		'
		' TODO : Add constructor code after InitializeComponents
		'
	End Sub
	
	Sub FrmVerVentasLoad(sender As Object, e As EventArgs)
			
		Dim consultaString As String = Consulta
		Dim ctrl As New ClsTorumPaper
		Me.t=ctrl.traerDatos(consultaString)
		Me.v=New Data.DataView(t)		
		Me.dGVventas.DataSource =Me.v.ToTable	
		
	End Sub
	
	
	
	
	Sub DGVventasCellContentClick(sender As Object, e As DataGridViewCellEventArgs)
		
	End Sub
End Class
