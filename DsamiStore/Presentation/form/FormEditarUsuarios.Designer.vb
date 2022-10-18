<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormEditarUsuarios
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnCancelarEditarUsuario = New System.Windows.Forms.Button()
        Me.btnAceptarEditarUsuario = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.cbxEmpleadoEditarUsuarios = New System.Windows.Forms.ComboBox()
        Me.cbxRolEditarUsuario = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtPasswordEditarUsuario = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtEmailEditarUsuarios = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtUsuarioEditarUsuarios = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNombreEditarUsuario = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(385, 58)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(21, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Editar Usuario"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.Controls.Add(Me.btnCancelarEditarUsuario)
        Me.Panel3.Controls.Add(Me.btnAceptarEditarUsuario)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 415)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(385, 55)
        Me.Panel3.TabIndex = 3
        '
        'btnCancelarEditarUsuario
        '
        Me.btnCancelarEditarUsuario.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.btnCancelarEditarUsuario.FlatAppearance.BorderSize = 0
        Me.btnCancelarEditarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelarEditarUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelarEditarUsuario.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.btnCancelarEditarUsuario.Location = New System.Drawing.Point(174, 14)
        Me.btnCancelarEditarUsuario.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCancelarEditarUsuario.Name = "btnCancelarEditarUsuario"
        Me.btnCancelarEditarUsuario.Size = New System.Drawing.Size(87, 30)
        Me.btnCancelarEditarUsuario.TabIndex = 11
        Me.btnCancelarEditarUsuario.Text = "Cancelar"
        Me.btnCancelarEditarUsuario.UseVisualStyleBackColor = False
        '
        'btnAceptarEditarUsuario
        '
        Me.btnAceptarEditarUsuario.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.btnAceptarEditarUsuario.FlatAppearance.BorderSize = 0
        Me.btnAceptarEditarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAceptarEditarUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAceptarEditarUsuario.ForeColor = System.Drawing.Color.White
        Me.btnAceptarEditarUsuario.Location = New System.Drawing.Point(280, 14)
        Me.btnAceptarEditarUsuario.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAceptarEditarUsuario.Name = "btnAceptarEditarUsuario"
        Me.btnAceptarEditarUsuario.Size = New System.Drawing.Size(87, 30)
        Me.btnAceptarEditarUsuario.TabIndex = 10
        Me.btnAceptarEditarUsuario.Text = "Aceptar"
        Me.btnAceptarEditarUsuario.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.cbxEmpleadoEditarUsuarios)
        Me.Panel2.Controls.Add(Me.cbxRolEditarUsuario)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.txtPasswordEditarUsuario)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.txtEmailEditarUsuarios)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.txtUsuarioEditarUsuarios)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.txtNombreEditarUsuario)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 58)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(385, 357)
        Me.Panel2.TabIndex = 4
        '
        'cbxEmpleadoEditarUsuarios
        '
        Me.cbxEmpleadoEditarUsuarios.FormattingEnabled = True
        Me.cbxEmpleadoEditarUsuarios.Location = New System.Drawing.Point(24, 306)
        Me.cbxEmpleadoEditarUsuarios.Name = "cbxEmpleadoEditarUsuarios"
        Me.cbxEmpleadoEditarUsuarios.Size = New System.Drawing.Size(341, 21)
        Me.cbxEmpleadoEditarUsuarios.TabIndex = 30
        '
        'cbxRolEditarUsuario
        '
        Me.cbxRolEditarUsuario.FormattingEnabled = True
        Me.cbxRolEditarUsuario.Location = New System.Drawing.Point(24, 251)
        Me.cbxRolEditarUsuario.Name = "cbxRolEditarUsuario"
        Me.cbxRolEditarUsuario.Size = New System.Drawing.Size(341, 21)
        Me.cbxRolEditarUsuario.TabIndex = 29
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(21, 286)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(70, 16)
        Me.Label7.TabIndex = 28
        Me.Label7.Text = "Empleado"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(21, 232)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(28, 16)
        Me.Label6.TabIndex = 27
        Me.Label6.Text = "Rol"
        '
        'txtPasswordEditarUsuario
        '
        Me.txtPasswordEditarUsuario.Location = New System.Drawing.Point(24, 198)
        Me.txtPasswordEditarUsuario.Name = "txtPasswordEditarUsuario"
        Me.txtPasswordEditarUsuario.Size = New System.Drawing.Size(341, 20)
        Me.txtPasswordEditarUsuario.TabIndex = 26
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(21, 177)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 16)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "Contraseña"
        '
        'txtEmailEditarUsuarios
        '
        Me.txtEmailEditarUsuarios.Location = New System.Drawing.Point(24, 141)
        Me.txtEmailEditarUsuarios.Name = "txtEmailEditarUsuarios"
        Me.txtEmailEditarUsuarios.Size = New System.Drawing.Size(341, 20)
        Me.txtEmailEditarUsuarios.TabIndex = 24
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(21, 120)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 16)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "Email"
        '
        'txtUsuarioEditarUsuarios
        '
        Me.txtUsuarioEditarUsuarios.Location = New System.Drawing.Point(24, 85)
        Me.txtUsuarioEditarUsuarios.Name = "txtUsuarioEditarUsuarios"
        Me.txtUsuarioEditarUsuarios.Size = New System.Drawing.Size(341, 20)
        Me.txtUsuarioEditarUsuarios.TabIndex = 22
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(21, 64)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 16)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Usuario"
        '
        'txtNombreEditarUsuario
        '
        Me.txtNombreEditarUsuario.Location = New System.Drawing.Point(24, 29)
        Me.txtNombreEditarUsuario.Name = "txtNombreEditarUsuario"
        Me.txtNombreEditarUsuario.Size = New System.Drawing.Size(341, 20)
        Me.txtNombreEditarUsuario.TabIndex = 20
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(21, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 16)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Nombre"
        '
        'FormEditarUsuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(385, 470)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FormEditarUsuarios"
        Me.Text = "FormEditarUsuarios"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btnCancelarEditarUsuario As Button
    Friend WithEvents btnAceptarEditarUsuario As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents cbxEmpleadoEditarUsuarios As ComboBox
    Friend WithEvents cbxRolEditarUsuario As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtPasswordEditarUsuario As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtEmailEditarUsuarios As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtUsuarioEditarUsuarios As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtNombreEditarUsuario As TextBox
    Friend WithEvents Label2 As Label
End Class
