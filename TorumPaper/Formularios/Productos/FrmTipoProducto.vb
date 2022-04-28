'
' Created by SharpDevelop.
' User: Coderp
' Date: 15/03/2022
' Time: 13:27
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Public Partial Class FrmTipoProducto
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
	
	Sub TxtClaveMarcaTextChanged(sender As Object, e As EventArgs)
		
	End Sub
	
	
	Sub BtnRegistrarClick(sender As Object, e As EventArgs)
		
		'Guarda la sentencia en un string 
		Dim insertarRegistro As String = "INSERT INTO tipoproducto (claveTipoProducto, descripcionTipoProducto) VALUES ('" & Me.txtClaveTipo.Text & "', '" & Me.txtDescripcion.text & "');"
		
		'envia y valida si el registro se realizo
		If Me.ctrl.insertarRegistro(insertarRegistro) Then
			MsgBox("Se realizó el registro")
			Dim consultaString As String = "select * from tipoproducto;"
			Dim ctrl As New ClsTorumPaper
			Me.t=ctrl.traerDatos(consultaString)
			Me.v=New Data.DataView(t)
			Me.dGVTipProductos.DataSource =Me.v.ToTable	
			
		End If
	End Sub
	
	Sub FrmTipoProductoLoad(sender As Object, e As EventArgs)
		
		Dim consultaString As String = "select * from tipoproducto;"
		Dim ctrl As New ClsTorumPaper
		Me.t=ctrl.traerDatos(consultaString)
		Me.v=New Data.DataView(t)
		Me.dGVTipProductos.DataSource =Me.v.ToTable
		
	End Sub
	
	
	Sub BtnActualizarClick(sender As Object, e As EventArgs)
		
		
		
	End Sub
	
	Sub TextBox1TextChanged(sender As Object, e As EventArgs)
		
		Me.v=New Data.DataView(t)
		Me.v.RowFilter="claveTipoProducto like '%" & Me.textBclave.Text & "%'"
		Me.dGVTipProductos.DataSource = Me.v.ToTable	
		
	End Sub
	
	Sub DGVTipProductosCellClick(sender As Object, e As DataGridViewCellEventArgs)
		Dim i As Integer = dGVTipProductos.CurrentRow.Index 
		
		txtClaveTipo.Text = dGVTipProductos(0,i).Value
		txtDescripcion.Text = dGVTipProductos(1,i).Value
		
		
		
	End Sub
End Class
