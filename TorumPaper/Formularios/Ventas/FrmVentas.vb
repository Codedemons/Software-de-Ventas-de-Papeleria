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
	Dim totalP As Double
	Dim CantF As Integer 
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
		
		
		If ctrl.FuncdatosCmb(cmbProductos)=True Then			
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
			If dGVventas(3,CantF).Value.ToString <> "" Then
				dGVventas(4,CantF).Value = Convert.ToDouble(nUDCantidad.Text) * Convert.ToDouble(dGVventas(3,CantF).Value.ToString)
				totalP +=  Convert.ToDouble(dGVventas(4,CantF).Value) 
				lblTotal.Text= totalP.ToString						
			Else
				dGVventas(4,CantF).Value =  "0"
			End If
		Else
			ctrl.MsgtxtV
		End If
		
		
		
		
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
		fila = Convert.ToInt32(dGVventas.CurrentCell.RowIndex.ToString)
	End Sub
	
	
	Sub BtnPagarClick(sender As Object, e As EventArgs)
		
		Dim operacion As Double
		
		If Convert.ToDouble(lblTotal.Text) < Convert.ToDouble(txtPago.Text) Then		
		If dGVventas.Rows.Count <> 0 Then
			If txtPago.Text <> "" Then
				operacion = Convert.ToDouble(txtPago.Text) - Convert.ToDouble(lblTotal.Text)
				lblCambio.Text = operacion.ToString			
			End If
				
				
			If (MsgBox("Se ha realizado la Compra",vbYesNo,"Pago") = vbYes) Then						
				
				For i As Integer = 1 To dGVventas.Rows.Count
					Dim formatoFechaHora As String =  Format(dTpFecha.Value, "yyyy-MM-dd ")  							
					Dim insertarRegistro As String = "INSERT INTO `venta` (`claveVenta`, `claveProducto`, `unidadesVenta`, `montoVenta`, `fechaVenta`) VALUES ('','PT0001','" & dGVventas.Item(1,0).Value.ToString & "','" & dGVventas.Item(4,0).Value.ToString & "','" & formatoFechaHora & "');"
					If ctrl.insertarRegistro(insertarRegistro) Then
						insertarRegistro = ""					
					Else
						ctrl.MsgError()
					End If							
				Next				 
				RellenarDatos()
			Else
				ctrl.MsgCancel()	
			End If
			
		Else
			ctrl.MsgtxtV
		End If
	Else
		ctrl.MsgDError()	
	End if
		
		
		
		
	End Sub
	
	
#Region "Rellenar Datos"
	Public Sub RellenarDatos()
		cmbProductos.Text = ""
		nUDCantidad.Text = "1"
		dGVventas.Rows.Clear()
		lblTotal.Text = "0.0"
		lblCambio.Text= "0.0"
		CantF = 0
		txtPago.Text = "0"
	end Sub 		
#End region
	
	
	Sub TxtPagoClick(sender As Object, e As EventArgs)
		ctrl.Funciontxt(txtPago,lblPago)
	End Sub
	
	Sub TxtPagoKeyPress(sender As Object, e As KeyPressEventArgs)
		If Char.IsDigit(e.KeyChar) Then
   	      e.Handled = False
	     ElseIf Char.IsControl(e.KeyChar) Then
	      e.Handled = False
	     Else
          e.Handled = True
     	End If		
	End Sub
	
	Sub TxtPagoTextChanged(sender As Object, e As EventArgs)
	
	End Sub
End Class
