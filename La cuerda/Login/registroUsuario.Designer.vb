<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class registroUsuario
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
        Me.components = New System.ComponentModel.Container()
        Me.TApellido = New System.Windows.Forms.TextBox()
        Me.TContraseña = New System.Windows.Forms.TextBox()
        Me.TNombre = New System.Windows.Forms.TextBox()
        Me.TEmail = New System.Windows.Forms.TextBox()
        Me.TTipo = New System.Windows.Forms.TextBox()
        Me.TNickname = New System.Windows.Forms.TextBox()
        Me.TDni = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ErrorProvider2 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TApellido
        '
        Me.TApellido.Location = New System.Drawing.Point(313, 145)
        Me.TApellido.Name = "TApellido"
        Me.TApellido.Size = New System.Drawing.Size(176, 22)
        Me.TApellido.TabIndex = 0
        '
        'TContraseña
        '
        Me.TContraseña.Location = New System.Drawing.Point(313, 202)
        Me.TContraseña.Name = "TContraseña"
        Me.TContraseña.Size = New System.Drawing.Size(176, 22)
        Me.TContraseña.TabIndex = 1
        '
        'TNombre
        '
        Me.TNombre.Location = New System.Drawing.Point(313, 92)
        Me.TNombre.Name = "TNombre"
        Me.TNombre.Size = New System.Drawing.Size(176, 22)
        Me.TNombre.TabIndex = 2
        '
        'TEmail
        '
        Me.TEmail.Location = New System.Drawing.Point(313, 375)
        Me.TEmail.Name = "TEmail"
        Me.TEmail.Size = New System.Drawing.Size(176, 22)
        Me.TEmail.TabIndex = 3
        '
        'TTipo
        '
        Me.TTipo.Location = New System.Drawing.Point(313, 258)
        Me.TTipo.Name = "TTipo"
        Me.TTipo.Size = New System.Drawing.Size(176, 22)
        Me.TTipo.TabIndex = 5
        '
        'TNickname
        '
        Me.TNickname.Location = New System.Drawing.Point(313, 428)
        Me.TNickname.Name = "TNickname"
        Me.TNickname.Size = New System.Drawing.Size(176, 22)
        Me.TNickname.TabIndex = 6
        '
        'TDni
        '
        Me.TDni.Location = New System.Drawing.Point(313, 41)
        Me.TDni.Name = "TDni"
        Me.TDni.Size = New System.Drawing.Size(176, 22)
        Me.TDni.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(46, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 33)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "DNI"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(46, 92)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(134, 33)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Nombre"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(46, 145)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(141, 33)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Apellido"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(46, 202)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(182, 33)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "contraseña"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(46, 258)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(114, 33)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "estado"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(46, 317)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(201, 33)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Tipo Usuario"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(46, 375)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(98, 33)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Email"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(46, 428)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(161, 33)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "nickname"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button1.Location = New System.Drawing.Point(25, 502)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(99, 28)
        Me.Button1.TabIndex = 16
        Me.Button1.Text = "Registrarse"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button2.Location = New System.Drawing.Point(476, 499)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 29)
        Me.Button2.TabIndex = 17
        Me.Button2.Text = "Salir"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button3.Location = New System.Drawing.Point(172, 502)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(119, 26)
        Me.Button3.TabIndex = 18
        Me.Button3.Text = "Iniciar Sesion"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'ErrorProvider2
        '
        Me.ErrorProvider2.ContainerControl = Me
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"1- Gerente", "2- Administrador", "3-Encargado"})
        Me.ComboBox1.Location = New System.Drawing.Point(313, 317)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(176, 24)
        Me.ComboBox1.TabIndex = 19
        '
        'registroUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Tomato
        Me.BackgroundImage = Global.La_cuerda.My.Resources.Resources.como_avinar_un_bajo_electrico
        Me.ClientSize = New System.Drawing.Size(599, 569)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TDni)
        Me.Controls.Add(Me.TNickname)
        Me.Controls.Add(Me.TTipo)
        Me.Controls.Add(Me.TEmail)
        Me.Controls.Add(Me.TNombre)
        Me.Controls.Add(Me.TContraseña)
        Me.Controls.Add(Me.TApellido)
        Me.Name = "registroUsuario"
        Me.Text = "registroUsuario"
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TApellido As System.Windows.Forms.TextBox
    Friend WithEvents TContraseña As System.Windows.Forms.TextBox
    Friend WithEvents TNombre As System.Windows.Forms.TextBox
    Friend WithEvents TEmail As System.Windows.Forms.TextBox
    Friend WithEvents TTipo As System.Windows.Forms.TextBox
    Friend WithEvents TNickname As System.Windows.Forms.TextBox
    Friend WithEvents TDni As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents ErrorProvider2 As System.Windows.Forms.ErrorProvider
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
End Class
