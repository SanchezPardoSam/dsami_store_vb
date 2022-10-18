<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormInsertarUsuarios
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
        Me.btnCancelarAgregarUsuario = New System.Windows.Forms.Button()
        Me.btnAceptarAgregarUsuario = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.cbxEmpleadoAgregarUsuarios = New System.Windows.Forms.ComboBox()
        Me.cbxRolAgregarUsuario = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtClaveAgregarUsuario = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtNombreAgregarUsuario = New System.Windows.Forms.TextBox()
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
        Me.Label1.Location = New System.Drawing.Point(12, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(127, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Agregar Usuario"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.Controls.Add(Me.btnCancelarAgregarUsuario)
        Me.Panel3.Controls.Add(Me.btnAceptarAgregarUsuario)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 284)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(385, 55)
        Me.Panel3.TabIndex = 3
        '
        'btnCancelarAgregarUsuario
        '
        Me.btnCancelarAgregarUsuario.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.btnCancelarAgregarUsuario.FlatAppearance.BorderSize = 0
        Me.btnCancelarAgregarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelarAgregarUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelarAgregarUsuario.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.btnCancelarAgregarUsuario.Location = New System.Drawing.Point(165, 14)
        Me.btnCancelarAgregarUsuario.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCancelarAgregarUsuario.Name = "btnCancelarAgregarUsuario"
        Me.btnCancelarAgregarUsuario.Size = New System.Drawing.Size(87, 30)
        Me.btnCancelarAgregarUsuario.TabIndex = 9
        Me.btnCancelarAgregarUsuario.Text = "Cancelar"
        Me.btnCancelarAgregarUsuario.UseVisualStyleBackColor = False
        '
        'btnAceptarAgregarUsuario
        '
        Me.btnAceptarAgregarUsuario.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.btnAceptarAgregarUsuario.FlatAppearance.BorderSize = 0
        Me.btnAceptarAgregarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAceptarAgregarUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAceptarAgregarUsuario.ForeColor = System.Drawing.Color.White
        Me.btnAceptarAgregarUsuario.Location = New System.Drawing.Point(271, 14)
        Me.btnAceptarAgregarUsuario.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAceptarAgregarUsuario.Name = "btnAceptarAgregarUsuario"
        Me.btnAceptarAgregarUsuario.Size = New System.Drawing.Size(87, 30)
        Me.btnAceptarAgregarUsuario.TabIndex = 8
        Me.btnAceptarAgregarUsuario.Text = "Aceptar"
        Me.btnAceptarAgregarUsuario.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.cbxEmpleadoAgregarUsuarios)
        Me.Panel2.Controls.Add(Me.cbxRolAgregarUsuario)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.txtClaveAgregarUsuario)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.txtNombreAgregarUsuario)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 58)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(385, 226)
        Me.Panel2.TabIndex = 4
        '
        'cbxEmpleadoAgregarUsuarios
        '
        Me.cbxEmpleadoAgregarUsuarios.FormattingEnabled = True
        Me.cbxEmpleadoAgregarUsuarios.Location = New System.Drawing.Point(15, 191)
        Me.cbxEmpleadoAgregarUsuarios.Name = "cbxEmpleadoAgregarUsuarios"
        Me.cbxEmpleadoAgregarUsuarios.Size = New System.Drawing.Size(341, 21)
        Me.cbxEmpleadoAgregarUsuarios.TabIndex = 18
        '
        'cbxRolAgregarUsuario
        '
        Me.cbxRolAgregarUsuario.FormattingEnabled = True
        Me.cbxRolAgregarUsuario.Location = New System.Drawing.Point(15, 136)
        Me.cbxRolAgregarUsuario.Name = "cbxRolAgregarUsuario"
        Me.cbxRolAgregarUsuario.Size = New System.Drawing.Size(341, 21)
        Me.cbxRolAgregarUsuario.TabIndex = 17
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(12, 171)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(70, 16)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Empleado"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(12, 117)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(28, 16)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Rol"
        '
        'txtClaveAgregarUsuario
        '
        Me.txtClaveAgregarUsuario.Location = New System.Drawing.Point(15, 83)
        Me.txtClaveAgregarUsuario.Name = "txtClaveAgregarUsuario"
        Me.txtClaveAgregarUsuario.Size = New System.Drawing.Size(341, 20)
        Me.txtClaveAgregarUsuario.TabIndex = 13
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 62)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(42, 16)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Clave"
        '
        'txtNombreAgregarUsuario
        '
        Me.txtNombreAgregarUsuario.Location = New System.Drawing.Point(15, 30)
        Me.txtNombreAgregarUsuario.Name = "txtNombreAgregarUsuario"
        Me.txtNombreAgregarUsuario.Size = New System.Drawing.Size(341, 20)
        Me.txtNombreAgregarUsuario.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(125, 16)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Nombre de Usuario"
        '
        'FormInsertarUsuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(385, 339)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FormInsertarUsuarios"
        Me.Text = "FormInsertarUsuarios"
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
    Friend WithEvents btnCancelarAgregarUsuario As Button
    Friend WithEvents btnAceptarAgregarUsuario As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents cbxEmpleadoAgregarUsuarios As ComboBox
    Friend WithEvents cbxRolAgregarUsuario As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtClaveAgregarUsuario As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtNombreAgregarUsuario As TextBox
    Friend WithEvents Label2 As Label
End Class
