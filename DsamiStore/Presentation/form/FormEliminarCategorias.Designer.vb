<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormEliminarCategorias
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.txtNombreEliminarCategoria = New System.Windows.Forms.Label()
        Me.btnCancelarEliminarCategoria = New System.Windows.Forms.Button()
        Me.btnAceptarEliminarCategoria = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.btnCancelarEliminarCategoria)
        Me.Panel1.Controls.Add(Me.btnAceptarEliminarCategoria)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 91)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(416, 60)
        Me.Panel1.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(416, 48)
        Me.Panel2.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(233, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "¿Deseas eliminar la categoria?"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel3.Controls.Add(Me.txtNombreEliminarCategoria)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 48)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(416, 43)
        Me.Panel3.TabIndex = 3
        '
        'txtNombreEliminarCategoria
        '
        Me.txtNombreEliminarCategoria.AutoSize = True
        Me.txtNombreEliminarCategoria.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombreEliminarCategoria.Location = New System.Drawing.Point(21, 10)
        Me.txtNombreEliminarCategoria.Name = "txtNombreEliminarCategoria"
        Me.txtNombreEliminarCategoria.Size = New System.Drawing.Size(56, 16)
        Me.txtNombreEliminarCategoria.TabIndex = 3
        Me.txtNombreEliminarCategoria.Text = "Nombre"
        '
        'btnCancelarEliminarCategoria
        '
        Me.btnCancelarEliminarCategoria.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.btnCancelarEliminarCategoria.FlatAppearance.BorderSize = 0
        Me.btnCancelarEliminarCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelarEliminarCategoria.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelarEliminarCategoria.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.btnCancelarEliminarCategoria.Location = New System.Drawing.Point(196, 18)
        Me.btnCancelarEliminarCategoria.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCancelarEliminarCategoria.Name = "btnCancelarEliminarCategoria"
        Me.btnCancelarEliminarCategoria.Size = New System.Drawing.Size(87, 30)
        Me.btnCancelarEliminarCategoria.TabIndex = 9
        Me.btnCancelarEliminarCategoria.Text = "Cancelar"
        Me.btnCancelarEliminarCategoria.UseVisualStyleBackColor = False
        '
        'btnAceptarEliminarCategoria
        '
        Me.btnAceptarEliminarCategoria.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.btnAceptarEliminarCategoria.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.btnAceptarEliminarCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAceptarEliminarCategoria.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAceptarEliminarCategoria.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.btnAceptarEliminarCategoria.Location = New System.Drawing.Point(302, 18)
        Me.btnAceptarEliminarCategoria.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAceptarEliminarCategoria.Name = "btnAceptarEliminarCategoria"
        Me.btnAceptarEliminarCategoria.Size = New System.Drawing.Size(87, 30)
        Me.btnAceptarEliminarCategoria.TabIndex = 8
        Me.btnAceptarEliminarCategoria.Text = "Aceptar"
        Me.btnAceptarEliminarCategoria.UseVisualStyleBackColor = False
        '
        'FormEliminarCategorias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(416, 151)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FormEliminarCategorias"
        Me.Text = "FormEliminarCategorias"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents txtNombreEliminarCategoria As Label
    Friend WithEvents btnCancelarEliminarCategoria As Button
    Friend WithEvents btnAceptarEliminarCategoria As Button
End Class
