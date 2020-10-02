

'Importando clases de regulacion para regex
Imports System.Text.RegularExpressions
Public Class AgregarCliente

    Private Sub Cliente_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TDni_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles TDni.Validating
        If Not IsNumeric(TDni.Text) Then
            MsgBox("No se puede ingresar texto en la casilla DNI")
        End If
    End Sub

    Private Sub TNombre_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TNombre.KeyPress
        'Solo Letras
        Dim texto As New Regex("[0-9]", RegexOptions.IgnoreCase)
        e.Handled = texto.IsMatch(e.KeyChar)
        'MsgBox("Solo letras de  la a - z ")
    End Sub

    Private Sub TApellido_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TApellido.KeyPress
        'Solo Letras
        Dim texto As New Regex("[0-9]", RegexOptions.IgnoreCase)
        e.Handled = texto.IsMatch(e.KeyChar)
        'MsgBox("Solo letras de  la a - z ")
    End Sub

    Private Sub TTelefono_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles TTelefono.Validating
        If Not IsNumeric(TApellido.Text) Then
            MsgBox("No se puede ingresar texto en la casilla Telefono")
        End If
    End Sub

    Private Sub TEmail_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles TEmail.Validating
        If Not TEmail.Text.Contains("@email.com") Then
            MsgBox("El correo no es valido")

        End If
    End Sub

    Private Sub TBarrio_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles TBarrio.Validating
        If Len(TBarrio.Text) = 0 Then
            MsgBox("Debe completar el campo Barrio")
        End If
    End Sub

    Private Sub TDireccion_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles TDireccion.Validating
        If Len(TBarrio.Text) = 0 Then
            MsgBox("Debe completar el campo Direccion")


        End If
    End Sub

    Private Sub TFNacimiento_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles TFNacimiento.Validating
        Dim fecha As DateTime
        If Not DateTime.TryParse(TFNacimiento.Text, fecha) Then
            MsgBox("la fecha ingresada no es valida, Formato de fecha dia/mes/Año")

        End If


    End Sub


End Class