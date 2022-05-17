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
	Private t As New Data.DataTable
	Private v As New Data.DataView
	Dim Consulta As String = "SELECT * FROM v_productos_modif;"
	dim fila As Integer
	
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

	
	
	Sub BtnAgregarClick(sender As Object, e As EventArgs)
		Dim CantF As Integer
		dGVventas.Rows.Add()
		CantF = dGVventas.Rows.Count - 1
		
		dGVventas(0,CantF).Value = cmbProductos.Text
		dGVventas(1,CantF).Value = nUDCantidad.Text
		dGVventas(2,CantF).Value = DateTime.Now.ToString("dd/MM/yyyy")
				
		Dim consulta As String = "SELECT * FROM `v_productos_modif` where Descripcion ='" & cmbProductos.Text	 & "';"		
		t = Me.ctrl.consultasSql(consulta)
		
		If t.Rows.Count = 0 Then
			ctrl.MsgFalt()
		Else
			dGVventas(3,CantF).Value = t.Rows(0).Item("Precio").ToString
		End If
		'dGVventas(4,CantF).Value = dGVventas(3,CantF).Value.ToString * nUDCantidad.Text
		If dGVventas(3,CantF).Value <> "" Then
			dGVventas(4,CantF).Value =  nUDCantidad.Text * dGVventas(3,CantF).Value.ToString
		Else
			dGVventas(4,CantF).Value =  "0"
		End If
	End Sub
	
	Sub BtnEditarClick(sender As Object, e As EventArgs)
		
	End Sub
	
	
	Sub BtnEliminarClick(sender As Object, e As EventArgs)
		
		If dGVventas.Rows.Count = 0 Then
			ctrl.MsgtxtV
		Else
			dGVventas.Rows.Remove(dGVventas.Rows(fila))	
		End If
		
	End Sub
	
	Sub DGVventasCellClick(sender As Object, e As DataGridViewCellEventArgs)
		fila = 0
		fila = dGVventas.CurrentCell.RowIndex.ToString
		
		Dim i As Integer = dGVventas.CurrentRow.Index
		cmbProductos.Text = dGVventas(0,i).Value.ToString		
		nUDCantidad.Text = dGVventas(1,i).Value.ToString	
		
	End Sub
	
End Class
