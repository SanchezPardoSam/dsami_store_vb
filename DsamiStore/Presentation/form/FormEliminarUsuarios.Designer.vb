<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormEliminarUsuarios
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
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNombreEliminarUsuario = New System.Windows.Forms.Label()
        Me.btnCancelarEliminarUsuario = New System.Windows.Forms.Button()
        Me.btnAceptarEliminarUsuarios = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(416, 48)
        Me.Panel1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.txtNombreEliminarUsuario)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 48)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(416, 103)
        Me.Panel2.TabIndex = 1
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.Controls.Add(Me.btnCancelarEliminarUsuario)
        Me.Panel3.Controls.Add(Me.btnAceptarEliminarUsuarios)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 91)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(416, 60)
        Me.Panel3.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(219, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "¿Deseas eliminar el usuario?"
        '
        'txtNombreEliminarUsuario
        '
        Me.txtNombreEliminarUsuario.AutoSize = True
        Me.txtNombreEliminarUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombreEliminarUsuario.Location = New System.Drawing.Point(24, 14)
        Me.txtNombreEliminarUsuario.Name = "txtNombreEliminarUsuario"
        Me.txtNombreEliminarUsuario.Size = New System.Drawing.Size(56, 16)
        Me.txtNombreEliminarUsuario.TabIndex = 3
        Me.txtNombreEliminarUsuario.Text = "Nombre"
        '
        'btnCancelarEliminarUsuario
        '
        Me.btnCancelarEliminarUsuario.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.btnCancelarEliminarUsuario.FlatAppearance.BorderSize = 0
        Me.btnCancelarEliminarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelarEliminarUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelarEliminarUsuario.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.btnCancelarEliminarUsuario.Location = New System.Drawing.Point(193, 19)
        Me.btnCancelarEliminarUsuario.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCancelarEliminarUsuario.Name = "btnCancelarEliminarUsuario"
        Me.btnCancelarEliminarUsuario.Size = New System.Drawing.Size(87, 30)
        Me.btnCancelarEliminarUsuario.TabIndex = 9
        Me.btnCancelarEliminarUsuario.Text = "Cancelar"
        Me.btnCancelarEliminarUsuario.UseVisualStyleBackColor = False
        '
        'btnAceptarEliminarUsuarios
        '
        Me.btnAceptarEliminarUsuarios.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.btnAceptarEliminarUsuarios.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.btnAceptarEliminarUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAceptarEliminarUsuarios.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAceptarEliminarUsuarios.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.btnAceptarEliminarUsuarios.Location = New System.Drawing.Point(299, 19)
        Me.btnAceptarEliminarUsuarios.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAceptarEliminarUsuarios.Name = "btnAceptarEliminarUsuarios"
        Me.btnAceptarEliminarUsuarios.Size = New System.Drawing.Size(87, 30)
        Me.btnAceptarEliminarUsuarios.TabIndex = 8
        Me.btnAceptarEliminarUsuarios.Text = "Aceptar"
        Me.btnAceptarEliminarUsuarios.UseVisualStyleBackColor = False
        '
        'FormEliminarUsuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(416, 151)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FormEliminarUsuarios"
        Me.Text = "FormEliminarUsuarios"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents txtNombreEliminarUsuario As Label
    Friend WithEvents btnCancelarEliminarUsuario As Button
    Friend WithEvents btnAceptarEliminarUsuarios As Button
End Class
