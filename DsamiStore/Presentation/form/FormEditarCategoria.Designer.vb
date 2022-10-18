<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormEditarCategoria
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
        Me.btnCancelarEditarCategoria = New System.Windows.Forms.Button()
        Me.btnAceptarEditarCategoria = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.txtDescripcionEditarCategoria = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNombreEditarCategoria = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
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
        Me.Panel1.Size = New System.Drawing.Size(395, 58)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(25, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(126, 17)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Editar Categoría"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.btnCancelarEditarCategoria)
        Me.Panel2.Controls.Add(Me.btnAceptarEditarCategoria)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 201)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(395, 64)
        Me.Panel2.TabIndex = 1
        '
        'btnCancelarEditarCategoria
        '
        Me.btnCancelarEditarCategoria.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.btnCancelarEditarCategoria.FlatAppearance.BorderSize = 0
        Me.btnCancelarEditarCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelarEditarCategoria.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelarEditarCategoria.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.btnCancelarEditarCategoria.Location = New System.Drawing.Point(180, 23)
        Me.btnCancelarEditarCategoria.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCancelarEditarCategoria.Name = "btnCancelarEditarCategoria"
        Me.btnCancelarEditarCategoria.Size = New System.Drawing.Size(87, 30)
        Me.btnCancelarEditarCategoria.TabIndex = 13
        Me.btnCancelarEditarCategoria.Text = "Cancelar"
        Me.btnCancelarEditarCategoria.UseVisualStyleBackColor = False
        '
        'btnAceptarEditarCategoria
        '
        Me.btnAceptarEditarCategoria.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.btnAceptarEditarCategoria.FlatAppearance.BorderSize = 0
        Me.btnAceptarEditarCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAceptarEditarCategoria.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAceptarEditarCategoria.ForeColor = System.Drawing.Color.White
        Me.btnAceptarEditarCategoria.Location = New System.Drawing.Point(286, 23)
        Me.btnAceptarEditarCategoria.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAceptarEditarCategoria.Name = "btnAceptarEditarCategoria"
        Me.btnAceptarEditarCategoria.Size = New System.Drawing.Size(87, 30)
        Me.btnAceptarEditarCategoria.TabIndex = 12
        Me.btnAceptarEditarCategoria.Text = "Aceptar"
        Me.btnAceptarEditarCategoria.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel3.Controls.Add(Me.txtDescripcionEditarCategoria)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.txtNombreEditarCategoria)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 58)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(395, 143)
        Me.Panel3.TabIndex = 2
        '
        'txtDescripcionEditarCategoria
        '
        Me.txtDescripcionEditarCategoria.Location = New System.Drawing.Point(28, 94)
        Me.txtDescripcionEditarCategoria.Name = "txtDescripcionEditarCategoria"
        Me.txtDescripcionEditarCategoria.Size = New System.Drawing.Size(341, 20)
        Me.txtDescripcionEditarCategoria.TabIndex = 15
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(25, 73)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 16)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Descripción"
        '
        'txtNombreEditarCategoria
        '
        Me.txtNombreEditarCategoria.Location = New System.Drawing.Point(28, 35)
        Me.txtNombreEditarCategoria.Name = "txtNombreEditarCategoria"
        Me.txtNombreEditarCategoria.Size = New System.Drawing.Size(341, 20)
        Me.txtNombreEditarCategoria.TabIndex = 13
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(25, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 16)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Nombre"
        '
        'FormEditarCategoria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(395, 265)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FormEditarCategoria"
        Me.Text = "FormEditarCategoria"
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
    Friend WithEvents txtDescripcionEditarCategoria As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtNombreEditarCategoria As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnCancelarEditarCategoria As Button
    Friend WithEvents btnAceptarEditarCategoria As Button
End Class
