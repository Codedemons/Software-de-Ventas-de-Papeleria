'
' Created by SharpDevelop.
' User: Coderp
' Date: 15/03/2022
' Time: 13:28
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Public Partial Class FrmProveedores
	
	Private ctrl As ClsTorumPaper
	
	Private t As New Data.DataTable
	Private v As New Data.DataView
	
	Public Sub New()
		' The Me.InitializeComponent call is required for Windows Forms designer support.
		Me.InitializeComponent()
			
		Me.ctrl = New ClsTorumPaper
		'
		' TODO : Add constructor code after InitializeComponents
		'
	End Sub
	
	
	
	Sub FrmProveedoresLoad(sender As Object, e As EventArgs)
		
		Dim consultaString As String = "select * from proveedor order by calificacionProveedor desc;"
		Dim ctrl As New ClsTorumPaper
		Me.t=ctrl.traerDatos(consultaString)
		Me.v=New Data.DataView(t)
		Me.dGVProveedores.DataSource =Me.v.ToTable
	End Sub
	
	Sub BtnRegistrarClick(sender As Object, e As EventArgs)
		
		Dim insertarRegistro As String = "INSERT INTO proveedor (rfcProveedor, nombreProveedor, correoProveedor, telefonoProveedor, calificacionProveedor) VALUES ('" & Me.txtRfc.Text & "','" & Me.txtNombre.Text & "','" & Me.txtCorreo.Text & "','" & Me.txtTelefono.Text & "','" & Me.nUDCalificacion.Text & "');"
		'envia y valida si el registro se realizo
		If Me.ctrl.insertarRegistro(insertarRegistro) Then
			MsgBox("Se realizó el registro")
			End If
		
	End Sub
	
	Sub TextBoxFiltroNombreProveedorTextChanged(sender As Object, e As EventArgs)
		
		Me.v=New Data.DataView(t)
		Me.v.RowFilter="nombreProveedor like '%" & Me.txtBuscarNombreProv.Text & "%'"
		Me.dGVProveedores.DataSource = Me.v.ToTable
		
	End Sub
	
	
	Sub TxtBuscarRFCTextChanged(sender As Object, e As EventArgs)
		
		Me.v=New Data.DataView(t)
		Me.v.RowFilter="rfcProveedor like '%" & Me.txtBuscarRFC.Text & "%'"
		Me.dGVProveedores.DataSource = Me.v.ToTable
	End Sub
	

	
	Sub BtnActualizarClick(sender As Object, e As EventArgs)
		
		Dim consultaString As String = "select * from proveedor order by calificacionProveedor desc;"
		Dim ctrl As New ClsTorumPaper
		Me.t=ctrl.traerDatos(consultaString)
		Me.v=New Data.DataView(t)
		Me.dGVProveedores.DataSource =Me.v.ToTable
		
	End Sub
End Class
