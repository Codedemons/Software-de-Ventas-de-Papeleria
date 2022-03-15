'
' Created by SharpDevelop.
' User: Coderp
' Date: 18/02/2022
' Time: 22:26
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Imports Microsoft.VisualBasic.ApplicationServices

Namespace My
	' This file controls the behaviour of the application.
	Partial Class MyApplication
		Public Sub New()
			MyBase.New(AuthenticationMode.Windows)
			Me.IsSingleInstance = False
			Me.EnableVisualStyles = True
			Me.SaveMySettingsOnExit = True
			Me.ShutDownStyle = ShutdownMode.AfterMainFormCloses
		End Sub
		
		Protected Overrides Sub OnCreateMainForm()
			'Me.MainForm = My.Forms.MainForm
			Me.MainForm = My.Forms.FrmPedidos
		End Sub
	End Class
End Namespace
