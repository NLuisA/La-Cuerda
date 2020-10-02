
'Importando clases de regulacion para regex
Imports System.Text.RegularExpressions
Public Class registroUsuario



    'Solo numeros
    Private Sub TDni_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles TDni.Validating
        If Not IsNumeric(TDni.Text) Then
            MsgBox("No se puede ingresar texto en la casilla DNI")
        End If
    End Sub


    Private Sub TApellido_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TApellido.KeyPress
        'Solo Letras
        Dim texto As New Regex("[0-9]", RegexOptions.IgnoreCase)
        e.Handled = texto.IsMatch(e.KeyChar)
        'MsgBox("Solo letras de  la a - z ")
    End Sub

    Private Sub TNombre_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TNombre.KeyPress
        'Solo Letras
        Dim texto As New Regex("[0-9]", RegexOptions.IgnoreCase)
        e.Handled = texto.IsMatch(e.KeyChar)
        'MsgBox("Solo letras de  la a - z ")
    End Sub



    Private Sub TContraseña_Validated(sender As Object, e As System.EventArgs) Handles TContraseña.Validated
        If Len(TContraseña.Text) < 5 Then
            MsgBox("La contrasña debe ser mayor a 5")
        End If


    End Sub



    Private Sub TEmail_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles TEmail.Validating
        If validar_Mail(LCase(TEmail.Text)) = False Then
     MessageBox.Show("Dirección de correo electronico no valida,   el correo debe tener el formato: nombre@dominio.com, " & _
     " por favor seleccione un correo valido", "Validación de   correo electronico", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            TEmail.Focus()
            TEmail.SelectAll()
        End If

    End Sub

    Private Sub TNickname_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TNickname.KeyPress
        'Solo Letras
        Dim texto As New Regex("[0-9]", RegexOptions.IgnoreCase)
        e.Handled = texto.IsMatch(e.KeyChar)
        'MsgBox("Solo letras de  la a - z ")
    End Sub

    Private Sub suario_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Login.Show()
        Me.Close()



    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Me.Close()


    End Sub

    Public Function validar_Mail(ByVal sMail As String) As Boolean
        ' retorna true o false   
     Return Regex.IsMatch(sMail, _
               "^[_a-z0-9-]+(\.[_a-z0-9-]+)*@[a-z0-9-]+(\.[a-z0-  9-]+)*(\.[a-z]{2,4})$")
    End Function


End Class
