'
' Created by SharpDevelop.
' User: Coderp
' Date: 18/02/2022
' Time: 22:26
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'

Imports System.Runtime.InteropServices
Public Partial Class MainForm
	Public Sub New()
		' The Me.InitializeComponent call is required for Windows Forms designer support.
		Me.InitializeComponent()
		
		'
		' TODO : Add constructor code after InitializeComponents
		'
	End Sub
	
	#Region "Customize Controls - Personalizar Controles"	
	'Cerrar el formulario
	Sub BtnCloseClick(sender As Object, e As EventArgs)
		If (MsgBox("Esta Seguro que desea Salir?",vbYesNo) = vbYes )Then
			Application.Exit()	
		End If
	End Sub
	'Minimizar el formulario
	Sub BtnMiniClick(sender As Object, e As EventArgs)
		WindowState = FormWindowState.Minimized
	End Sub
	#End Region
	
	#Region "Movimiento del Formulario"
	'Drag Form
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub
    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub
	
	Sub PnlBarraTituloMouseDown(sender As Object, e As MouseEventArgs)
		 ReleaseCapture()
		 SendMessage(Me.Handle, &H112, &HF012, 0)
	End Sub	 
	
	Sub LbNameMouseDown(sender As Object, e As MouseEventArgs)
		ReleaseCapture()
		SendMessage(Me.Handle, &H112, &HF012, 0)
	End Sub
	
		
	Sub PblogoMouseDown(sender As Object, e As MouseEventArgs)
		ReleaseCapture()
		SendMessage(Me.Handle, &H112, &HF012, 0)
	End Sub
	#End Region	 

		
	#Region "FUNCIONALIDADES DEL FORMULARIO"
    'RESIZE DEL FORMULARIO- CAMBIAR TAMAÑO
    Dim cGrip As Integer = 10

     Protected Overrides Sub WndProc(ByRef m As Message)
        If (m.Msg = 132) Then
            Dim pos As Point = New Point((m.LParam.ToInt32 And 65535), (m.LParam.ToInt32 + 16))
            pos = Me.PointToClient(pos)
            If ((pos.X _
                        >= (Me.ClientSize.Width - cGrip)) _
                        AndAlso (pos.Y _
                        >= (Me.ClientSize.Height - cGrip))) Then
                m.Result = CType(17, IntPtr)
                Return
            End If
        End If
        MyBase.WndProc(m)
    End Sub
    '----------------DIBUJAR RECTANGULO / EXCLUIR ESQUINA PANEL 
    Dim sizeGripRectangle As Rectangle
    Dim tolerance As Integer = 15

    Protected Overrides Sub OnSizeChanged(ByVal e As EventArgs)
        MyBase.OnSizeChanged(e)
        Dim region = New Region(New Rectangle(0, 0, Me.ClientRectangle.Width, Me.ClientRectangle.Height))
        sizeGripRectangle = New Rectangle((Me.ClientRectangle.Width - tolerance), (Me.ClientRectangle.Height - tolerance), tolerance, tolerance)
        region.Exclude(sizeGripRectangle)
        'Me.PanelContenedor.Region = region
        Me.Invalidate()
    End Sub
    
    'METODO DE ABRIR FORMULARIO
    Private Sub AbrirFormEnPanel(Of Miform As {Form, New})()
        Dim Formulario As Form  
         'Busca el formulario en la coleccion
        'Si form no fue econtrado/ no existe
        If Formulario Is Nothing Then
            Formulario = New Miform()
             Formulario.TopLevel = False

            Formulario.FormBorderStyle = FormBorderStyle.None
            Formulario.Dock = DockStyle.Fill

            pnlContenido.Controls.Add(Formulario)
            pnlContenido.Tag = Formulario
            Formulario.Show()
            Formulario.BringToFront()
        Else
            Formulario.BringToFront()
        End If

    End Sub
    
    #End Region
    
    #Region "Menu"
	Sub BtnPedidosClick(sender As Object, e As EventArgs)
		AbrirFormEnPanel(Of FrmPedidos)()	
	End Sub
	Sub BtnProductosClick(sender As Object, e As EventArgs)
		AbrirFormEnPanel(Of FrmProductos)()	
	End Sub
	Sub BtnVentasClick(sender As Object, e As EventArgs)
		AbrirFormEnPanel(Of FrmVerVentas)()	
	End Sub
	Sub BtnProveedoresClick(sender As Object, e As EventArgs)
		AbrirFormEnPanel(Of FrmProveedores)()	
	End Sub
	Sub BtnTProductosClick(sender As Object, e As EventArgs)
		AbrirFormEnPanel(Of FrmTipoProducto)()	
	End Sub
	#End Region
	
	
	

End Class
