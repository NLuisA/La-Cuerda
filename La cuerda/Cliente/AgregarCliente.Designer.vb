<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AgregarCliente
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.label4 = New System.Windows.Forms.Label()
        Me.label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TDni = New System.Windows.Forms.TextBox()
        Me.TApellido = New System.Windows.Forms.TextBox()
        Me.TTelefono = New System.Windows.Forms.TextBox()
        Me.TEmail = New System.Windows.Forms.TextBox()
        Me.TNombre = New System.Windows.Forms.TextBox()
        Me.TFNacimiento = New System.Windows.Forms.TextBox()
        Me.TDireccion = New System.Windows.Forms.TextBox()
        Me.TBarrio = New System.Windows.Forms.TextBox()
        Me.BAgregar = New System.Windows.Forms.Button()
        Me.BMenu = New System.Windows.Forms.Button()
        Me.BSalir = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(105, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "id Cliente"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(105, 82)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "DNI"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(105, 132)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Nombre"
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Location = New System.Drawing.Point(105, 190)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(58, 17)
        Me.label4.TabIndex = 3
        Me.label4.Text = "Apellido"
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Location = New System.Drawing.Point(105, 246)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(64, 17)
        Me.label5.TabIndex = 4
        Me.label5.Text = "Telefono"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(105, 296)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(42, 17)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Email"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(105, 359)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(46, 17)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Barrio"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(105, 419)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(67, 17)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Direccion"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(105, 474)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(121, 17)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Fecha Nacimiento"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(105, 529)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(52, 17)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "Estado"
        '
        'TDni
        '
        Me.TDni.Location = New System.Drawing.Point(398, 79)
        Me.TDni.Name = "TDni"
        Me.TDni.Size = New System.Drawing.Size(149, 22)
        Me.TDni.TabIndex = 11
        '
        'TApellido
        '
        Me.TApellido.Location = New System.Drawing.Point(398, 185)
        Me.TApellido.Name = "TApellido"
        Me.TApellido.Size = New System.Drawing.Size(149, 22)
        Me.TApellido.TabIndex = 12
        '
        'TTelefono
        '
        Me.TTelefono.Location = New System.Drawing.Point(398, 243)
        Me.TTelefono.Name = "TTelefono"
        Me.TTelefono.Size = New System.Drawing.Size(149, 22)
        Me.TTelefono.TabIndex = 13
        '
        'TEmail
        '
        Me.TEmail.Location = New System.Drawing.Point(398, 291)
        Me.TEmail.Name = "TEmail"
        Me.TEmail.Size = New System.Drawing.Size(149, 22)
        Me.TEmail.TabIndex = 14
        '
        'TNombre
        '
        Me.TNombre.Location = New System.Drawing.Point(398, 132)
        Me.TNombre.Name = "TNombre"
        Me.TNombre.Size = New System.Drawing.Size(149, 22)
        Me.TNombre.TabIndex = 15
        '
        'TFNacimiento
        '
        Me.TFNacimiento.Location = New System.Drawing.Point(398, 469)
        Me.TFNacimiento.Name = "TFNacimiento"
        Me.TFNacimiento.Size = New System.Drawing.Size(149, 22)
        Me.TFNacimiento.TabIndex = 17
        '
        'TDireccion
        '
        Me.TDireccion.Location = New System.Drawing.Point(398, 414)
        Me.TDireccion.Name = "TDireccion"
        Me.TDireccion.Size = New System.Drawing.Size(149, 22)
        Me.TDireccion.TabIndex = 18
        '
        'TBarrio
        '
        Me.TBarrio.Location = New System.Drawing.Point(398, 354)
        Me.TBarrio.Name = "TBarrio"
        Me.TBarrio.Size = New System.Drawing.Size(149, 22)
        Me.TBarrio.TabIndex = 19
        '
        'BAgregar
        '
        Me.BAgregar.Location = New System.Drawing.Point(108, 599)
        Me.BAgregar.Name = "BAgregar"
        Me.BAgregar.Size = New System.Drawing.Size(99, 37)
        Me.BAgregar.TabIndex = 20
        Me.BAgregar.Text = "Agregar"
        Me.BAgregar.UseVisualStyleBackColor = True
        '
        'BMenu
        '
        Me.BMenu.Location = New System.Drawing.Point(416, 601)
        Me.BMenu.Name = "BMenu"
        Me.BMenu.Size = New System.Drawing.Size(131, 35)
        Me.BMenu.TabIndex = 21
        Me.BMenu.Text = "Volver a Menu"
        Me.BMenu.UseVisualStyleBackColor = True
        '
        'BSalir
        '
        Me.BSalir.Location = New System.Drawing.Point(771, 601)
        Me.BSalir.Name = "BSalir"
        Me.BSalir.Size = New System.Drawing.Size(105, 36)
        Me.BSalir.TabIndex = 22
        Me.BSalir.Text = "Salir"
        Me.BSalir.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(447, 38)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(59, 17)
        Me.Label11.TabIndex = 23
        Me.Label11.Text = "Label11"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Activado", "Desactivado"})
        Me.ComboBox1.Location = New System.Drawing.Point(398, 529)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(149, 24)
        Me.ComboBox1.TabIndex = 24
        '
        'Cliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.La_cuerda.My.Resources.Resources.como_avinar_un_bajo_electrico
        Me.ClientSize = New System.Drawing.Size(982, 681)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.BSalir)
        Me.Controls.Add(Me.BMenu)
        Me.Controls.Add(Me.BAgregar)
        Me.Controls.Add(Me.TBarrio)
        Me.Controls.Add(Me.TDireccion)
        Me.Controls.Add(Me.TFNacimiento)
        Me.Controls.Add(Me.TNombre)
        Me.Controls.Add(Me.TEmail)
        Me.Controls.Add(Me.TTelefono)
        Me.Controls.Add(Me.TApellido)
        Me.Controls.Add(Me.TDni)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.label5)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Cliente"
        Me.Text = "Cliente"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents label4 As System.Windows.Forms.Label
    Friend WithEvents label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents TDni As System.Windows.Forms.TextBox
    Friend WithEvents TApellido As System.Windows.Forms.TextBox
    Friend WithEvents TTelefono As System.Windows.Forms.TextBox
    Friend WithEvents TEmail As System.Windows.Forms.TextBox
    Friend WithEvents TNombre As System.Windows.Forms.TextBox
    Friend WithEvents TFNacimiento As System.Windows.Forms.TextBox
    Friend WithEvents TDireccion As System.Windows.Forms.TextBox
    Friend WithEvents TBarrio As System.Windows.Forms.TextBox
    Friend WithEvents BAgregar As System.Windows.Forms.Button
    Friend WithEvents BMenu As System.Windows.Forms.Button
    Friend WithEvents BSalir As System.Windows.Forms.Button
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
End Class
