
'Importando clases de regulacion para regex
Imports System.Text.RegularExpressions
Public Class AgregarProducto

    Private Sub Label1_Click(sender As System.Object, e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub Btn_imagen_Click(sender As System.Object, e As System.EventArgs) Handles Btn_imagen.Click
        If OfdSeleccionarImagen.ShowDialog = Windows.Forms.DialogResult.OK Then
            PictureBox1.Image = Image.FromFile(OfdSeleccionarImagen.FileName)
            Me.Text = "Visor de Imagenes(" & OfdSeleccionarImagen.FileName & ")"
        End If
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        'Solo Letras
        Dim texto As New Regex("[0-9]", RegexOptions.IgnoreCase)
        e.Handled = texto.IsMatch(e.KeyChar)
        'MsgBox("Solo letras de  la a - z ")
    End Sub


    Private Sub TextBox3_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles TPrecio.Validating
        If Not IsNumeric(TPrecio.Text) Then
            MsgBox("No se puede ingresar texto en la casilla Precio")
        End If
    End Sub

    Private Sub TextBox5_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles TStock.Validating
        If Not IsNumeric(TStock.Text) Then
            MsgBox("No se puede ingresar texto en la casilla Stock")
        End If
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        MenuPrincipal.Show()
        Me.Close()


    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Me.Close()

    End Sub

    
    Private Sub PictureBox1_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox1.Click

    End Sub
End Class