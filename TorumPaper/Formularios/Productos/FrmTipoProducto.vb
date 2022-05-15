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
	Dim Consulta As String = "	SELECT * FROM v_tipos_productos;"
	
	Public Sub New()
		' The Me.InitializeComponent call is required for Windows Forms designer support.
		Me.InitializeComponent()	
		Me.ctrl = New ClsTorumPaper
		
		'
		' TODO : Add constructor code after InitializeComponents
		'
	End Sub
	#Region "Cargar Datos"
	Public Sub CargarDatos()
		Dim consultaString As String = Consulta 
		Dim ctrl As New ClsTorumPaper
		Me.t=ctrl.traerDatos(consultaString)
		Me.v=New Data.DataView(t)
		Me.dGVTipProductos.DataSource =Me.v.ToTable
	end Sub
	
	#End Region
	
	Sub FrmTipoProductoLoad(sender As Object, e As EventArgs)
		CargarDatos()
	End Sub

	Sub TextBox1TextChanged(sender As Object, e As EventArgs)
		
		Me.v=New Data.DataView(t)
		Me.v.RowFilter="Clave like '%" & Me.textBclave.Text & "%'"
		Me.dGVTipProductos.DataSource = Me.v.ToTable	
		
	End Sub
	
	Sub DGVTipProductosCellClick(sender As Object, e As DataGridViewCellEventArgs)
		Dim i As Integer = dGVTipProductos.CurrentRow.Index		
		txtClaveTipo.Text = dGVTipProductos(0,i).Value.ToString
		txtDescripcion.Text = dGVTipProductos(1,i).Value.ToString		
	End Sub
	
	Sub TxtDescTextChanged(sender As Object, e As EventArgs)
		Me.v=New Data.DataView(t)
		Me.v.RowFilter="Descripcion like '%" & txtDescripcion.Text & "%'"
		Me.dGVTipProductos.DataSource = Me.v.ToTable	
	End Sub
	
	
	Sub BtnRegistrarClick(sender As Object, e As EventArgs)
		If(ctrl.Funcdatos(txtDescripcion)=True) Then
			
		Else 
			ctrl.MsgtxtV() 
		End If
	End Sub
	
	Sub BtnModificarClick(sender As Object, e As EventArgs)
				
		'Guarda la sentencia en un string 
		Dim insertarRegistro As String = "UPDATE tipoproducto SET claveTipoProducto = '" & txtClaveTipo.Text & "', descripcionTipoProducto = '" & Me.txtDescripcion.text & "' WHERE claveTipoProducto = '" & txtClaveTipo.Text & "';"
		
		'envia y valida si el registro se realizo
		If txtDescripcion.Text <> "" Then
		If Me.ctrl.insertarRegistro(insertarRegistro) Then
			MessageBox.Show("Se han Actualizado los datos De manera correcta","Actualizar Datos",MessageBoxButtons.OK,MessageBoxIcon.Warning)
			Dim consultaString As String = Consulta
			Dim ctrl As New ClsTorumPaper
			Me.t=ctrl.traerDatos(consultaString)
			Me.v=New Data.DataView(t)
			Me.dGVTipProductos.DataSource =Me.v.ToTable	
			
		End If
		txtClaveTipo.Text = "Clave"
		txtDescripcion.Text = "Descripcion"
		End If
	End Sub
	
	Sub BtnEliminarClick(sender As Object, e As EventArgs)
		'Guarda la sentencia en un string 
		Dim insertarRegistro As String = "DELETE FROM tipoproducto WHERE claveTipoProducto = '" & txtClaveTipo.Text & "';"
		
		'envia y valida si el registro se realizo
		If txtDescripcion.Text <> "" Then
		If Me.ctrl.insertarRegistro(insertarRegistro) Then
			MessageBox.Show("Se han Eliminado los datos De manera correcta","Eliminar Datos",MessageBoxButtons.OK,MessageBoxIcon.Error)
			Dim consultaString As String = Consulta
			Dim ctrl As New ClsTorumPaper
			Me.t=ctrl.traerDatos(consultaString)
			Me.v=New Data.DataView(t)
			Me.dGVTipProductos.DataSource =Me.v.ToTable	
			
		End If
		txtClaveTipo.Text = "Clave"
		txtDescripcion.Text = "Descripcion"
		End If 
	End Sub
	
	
	#Region "Eventos clik de la ventana"
	Sub TxtClaveTipoClick(sender As Object, e As EventArgs)	
		ctrl.Funciontxt(txtClaveTipo,lblClave)		
	End Sub
		
	Sub TxtDescripcionClick(sender As Object, e As EventArgs)
		ctrl.Funciontxt(txtDescripcion,lblDes)		
	End Sub
	
	Sub TextBclaveClick(sender As Object, e As EventArgs)
		ctrl.Funciontxt(textBclave,lblBClave)
	End Sub
	
	Sub TxtDescClick(sender As Object, e As EventArgs)
		ctrl.Funciontxt(txtDesc,lblBDes)
	End Sub
	#End Region
	
	
End Class
