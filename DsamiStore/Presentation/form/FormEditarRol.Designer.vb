<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormEditarRol
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txtNombreEditarRol = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnCancelarEditarRol = New System.Windows.Forms.Button()
        Me.btnAceptarEditarRol = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Editar Rol"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(370, 44)
        Me.Panel1.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.txtNombreEditarRol)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 44)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(370, 142)
        Me.Panel2.TabIndex = 2
        '
        'txtNombreEditarRol
        '
        Me.txtNombreEditarRol.Location = New System.Drawing.Point(15, 36)
        Me.txtNombreEditarRol.Name = "txtNombreEditarRol"
        Me.txtNombreEditarRol.Size = New System.Drawing.Size(325, 20)
        Me.txtNombreEditarRol.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 16)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Nombre"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.Controls.Add(Me.btnCancelarEditarRol)
        Me.Panel3.Controls.Add(Me.btnAceptarEditarRol)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 125)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(370, 61)
        Me.Panel3.TabIndex = 3
        '
        'btnCancelarEditarRol
        '
        Me.btnCancelarEditarRol.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.btnCancelarEditarRol.FlatAppearance.BorderSize = 0
        Me.btnCancelarEditarRol.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelarEditarRol.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelarEditarRol.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.btnCancelarEditarRol.Location = New System.Drawing.Point(147, 15)
        Me.btnCancelarEditarRol.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCancelarEditarRol.Name = "btnCancelarEditarRol"
        Me.btnCancelarEditarRol.Size = New System.Drawing.Size(87, 30)
        Me.btnCancelarEditarRol.TabIndex = 5
        Me.btnCancelarEditarRol.Text = "Cancelar"
        Me.btnCancelarEditarRol.UseVisualStyleBackColor = False
        '
        'btnAceptarEditarRol
        '
        Me.btnAceptarEditarRol.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.btnAceptarEditarRol.FlatAppearance.BorderSize = 0
        Me.btnAceptarEditarRol.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAceptarEditarRol.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAceptarEditarRol.ForeColor = System.Drawing.Color.White
        Me.btnAceptarEditarRol.Location = New System.Drawing.Point(253, 15)
        Me.btnAceptarEditarRol.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAceptarEditarRol.Name = "btnAceptarEditarRol"
        Me.btnAceptarEditarRol.Size = New System.Drawing.Size(87, 30)
        Me.btnAceptarEditarRol.TabIndex = 4
        Me.btnAceptarEditarRol.Text = "Aceptar"
        Me.btnAceptarEditarRol.UseVisualStyleBackColor = False
        '
        'FormEditarRol
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(370, 186)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FormEditarRol"
        Me.Text = "FormEditarRol"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btnAceptarEditarRol As Button
    Friend WithEvents txtNombreEditarRol As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnCancelarEditarRol As Button
End Class
