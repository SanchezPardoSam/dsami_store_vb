<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormEliminarProveedores
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
        Me.txtNombreEliminarProveedor = New System.Windows.Forms.Label()
        Me.btnCancelarEliminarProveedor = New System.Windows.Forms.Button()
        Me.btnAceptarEliminarProveedor = New System.Windows.Forms.Button()
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
        Me.Panel2.Controls.Add(Me.btnAceptarEliminarProveedor)
        Me.Panel2.Controls.Add(Me.btnCancelarEliminarProveedor)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 91)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(416, 60)
        Me.Panel2.TabIndex = 1
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.Controls.Add(Me.txtNombreEliminarProveedor)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 48)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(416, 43)
        Me.Panel3.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(239, 17)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "¿Deseas eliminar el proveedor?"
        '
        'txtNombreEliminarProveedor
        '
        Me.txtNombreEliminarProveedor.AutoSize = True
        Me.txtNombreEliminarProveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombreEliminarProveedor.Location = New System.Drawing.Point(29, 14)
        Me.txtNombreEliminarProveedor.Name = "txtNombreEliminarProveedor"
        Me.txtNombreEliminarProveedor.Size = New System.Drawing.Size(56, 16)
        Me.txtNombreEliminarProveedor.TabIndex = 11
        Me.txtNombreEliminarProveedor.Text = "Nombre"
        '
        'btnCancelarEliminarProveedor
        '
        Me.btnCancelarEliminarProveedor.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.btnCancelarEliminarProveedor.FlatAppearance.BorderSize = 0
        Me.btnCancelarEliminarProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelarEliminarProveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelarEliminarProveedor.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.btnCancelarEliminarProveedor.Location = New System.Drawing.Point(202, 16)
        Me.btnCancelarEliminarProveedor.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCancelarEliminarProveedor.Name = "btnCancelarEliminarProveedor"
        Me.btnCancelarEliminarProveedor.Size = New System.Drawing.Size(87, 30)
        Me.btnCancelarEliminarProveedor.TabIndex = 13
        Me.btnCancelarEliminarProveedor.Text = "Cancelar"
        Me.btnCancelarEliminarProveedor.UseVisualStyleBackColor = False
        '
        'btnAceptarEliminarProveedor
        '
        Me.btnAceptarEliminarProveedor.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.btnAceptarEliminarProveedor.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.btnAceptarEliminarProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAceptarEliminarProveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAceptarEliminarProveedor.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.btnAceptarEliminarProveedor.Location = New System.Drawing.Point(308, 16)
        Me.btnAceptarEliminarProveedor.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAceptarEliminarProveedor.Name = "btnAceptarEliminarProveedor"
        Me.btnAceptarEliminarProveedor.Size = New System.Drawing.Size(87, 30)
        Me.btnAceptarEliminarProveedor.TabIndex = 12
        Me.btnAceptarEliminarProveedor.Text = "Aceptar"
        Me.btnAceptarEliminarProveedor.UseVisualStyleBackColor = False
        '
        'FormEliminarProveedores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(416, 151)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FormEliminarProveedores"
        Me.Text = "FormEliminarProveedores"
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
    Friend WithEvents txtNombreEliminarProveedor As Label
    Friend WithEvents btnCancelarEliminarProveedor As Button
    Friend WithEvents btnAceptarEliminarProveedor As Button
End Class
