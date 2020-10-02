Public Class MenuPrincipal

    Private Sub AgregarProductoToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AgregarProductoToolStripMenuItem.Click
        Me.Close()
        AgregarProducto.Show()


    End Sub

    Private Sub MenuPrincipal_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub AgregarUsuarioToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AgregarUsuarioToolStripMenuItem.Click
        AgregarCliente.Show()


    End Sub

    Private Sub ModificarProductoToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ModificarProductoToolStripMenuItem.Click
        ModificarProducto.Show()

    End Sub

    Private Sub ModificarDatosToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs)
        ModificarDatos.Show()


    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs)
        Me.Close()
        Login.Show()


    End Sub

    Private Sub GestionDeUsuariosToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles GestionDeUsuariosToolStripMenuItem.Click

    End Sub

    Private Sub ModificarUsuarioToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ModificarUsuarioToolStripMenuItem.Click
        ModificarUsuario.show()
    End Sub

    Private Sub ModificarDatosToolStripMenuItem_Click_1(sender As System.Object, e As System.EventArgs) Handles ModificarDatosToolStripMenuItem.Click
        ModificarDatos.Show()


    End Sub

    Private Sub SalirToolStripMenuItem_Click_1(sender As System.Object, e As System.EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()

    End Sub

    Private Sub AgregarClienteToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AgregarClienteToolStripMenuItem.Click
        AgregarCliente.Show()

    End Sub

    Private Sub ModificarClienteToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ModificarClienteToolStripMenuItem.Click
        'ModificarCliente.show()
    End Sub
End Class