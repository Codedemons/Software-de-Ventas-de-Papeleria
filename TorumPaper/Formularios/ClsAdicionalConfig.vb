'
' Created by SharpDevelop.
' User: Coderp
' Date: 10/03/2022
' Time: 12:01
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Public Class ClsAdicionalConfig
	'Comprobar el estado de los textbox	
	Public Function txtVacio(texto As TextBox) As Boolean
		If (texto.Text <> "" And texto.ForeColor = Color.White )  Then
			Return True
		Else
			Return False
		End If
	End Function
	'Quita el texto por defecto y cambia el color
	Public Sub Modifictxt(txt As TextBox)
		txt.Text = ""
		txt.ForeColor = Color.White
	End Sub
	
	
	Public Sub Modificbtn(btn As Button)
		btn.ForeColor = Color.White
	End Sub
	
End Class
