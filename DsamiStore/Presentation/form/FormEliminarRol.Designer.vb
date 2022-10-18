<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormEliminarRol
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
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnCancelarEliminarRol = New System.Windows.Forms.Button()
        Me.btnAceptarEliminarRol = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.txtNombreEliminarRol = New System.Windows.Forms.Label()
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
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(555, 59)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 18)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(226, 22)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "¿Deseas eliminar el rol?"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.btnCancelarEliminarRol)
        Me.Panel2.Controls.Add(Me.btnAceptarEliminarRol)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 112)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(555, 74)
        Me.Panel2.TabIndex = 1
        '
        'btnCancelarEliminarRol
        '
        Me.btnCancelarEliminarRol.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.btnCancelarEliminarRol.FlatAppearance.BorderSize = 0
        Me.btnCancelarEliminarRol.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelarEliminarRol.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelarEliminarRol.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.btnCancelarEliminarRol.Location = New System.Drawing.Point(264, 12)
        Me.btnCancelarEliminarRol.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnCancelarEliminarRol.Name = "btnCancelarEliminarRol"
        Me.btnCancelarEliminarRol.Size = New System.Drawing.Size(116, 37)
        Me.btnCancelarEliminarRol.TabIndex = 7
        Me.btnCancelarEliminarRol.Text = "Cancelar"
        Me.btnCancelarEliminarRol.UseVisualStyleBackColor = False
        '
        'btnAceptarEliminarRol
        '
        Me.btnAceptarEliminarRol.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.btnAceptarEliminarRol.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.btnAceptarEliminarRol.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAceptarEliminarRol.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAceptarEliminarRol.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.btnAceptarEliminarRol.Location = New System.Drawing.Point(405, 12)
        Me.btnAceptarEliminarRol.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnAceptarEliminarRol.Name = "btnAceptarEliminarRol"
        Me.btnAceptarEliminarRol.Size = New System.Drawing.Size(116, 37)
        Me.btnAceptarEliminarRol.TabIndex = 6
        Me.btnAceptarEliminarRol.Text = "Aceptar"
        Me.btnAceptarEliminarRol.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel3.Controls.Add(Me.txtNombreEliminarRol)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 59)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(555, 53)
        Me.Panel3.TabIndex = 2
        '
        'txtNombreEliminarRol
        '
        Me.txtNombreEliminarRol.AutoSize = True
        Me.txtNombreEliminarRol.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombreEliminarRol.Location = New System.Drawing.Point(31, 16)
        Me.txtNombreEliminarRol.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.txtNombreEliminarRol.Name = "txtNombreEliminarRol"
        Me.txtNombreEliminarRol.Size = New System.Drawing.Size(65, 20)
        Me.txtNombreEliminarRol.TabIndex = 2
        Me.txtNombreEliminarRol.Text = "Nombre"
        '
        'FormEliminarRol
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(555, 186)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "FormEliminarRol"
        Me.Text = "FormEliminarRol"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents txtNombreEliminarRol As Label
    Friend WithEvents btnCancelarEliminarRol As Button
    Friend WithEvents btnAceptarEliminarRol As Button
End Class
