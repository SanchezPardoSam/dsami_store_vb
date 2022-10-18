<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormInsertarCategorias
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
        Me.txtNombreAgregarCategoria = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtDescripcionInsertarCategoria = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnCancelarAgregarCategoria = New System.Windows.Forms.Button()
        Me.btnAceptarAgregarCategoria = New System.Windows.Forms.Button()
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
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.btnCancelarAgregarCategoria)
        Me.Panel2.Controls.Add(Me.btnAceptarAgregarCategoria)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 201)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(395, 64)
        Me.Panel2.TabIndex = 1
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel3.Controls.Add(Me.txtDescripcionInsertarCategoria)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.txtNombreAgregarCategoria)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 58)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(395, 143)
        Me.Panel3.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(139, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Agregar categoría"
        '
        'txtNombreAgregarCategoria
        '
        Me.txtNombreAgregarCategoria.Location = New System.Drawing.Point(14, 32)
        Me.txtNombreAgregarCategoria.Name = "txtNombreAgregarCategoria"
        Me.txtNombreAgregarCategoria.Size = New System.Drawing.Size(341, 20)
        Me.txtNombreAgregarCategoria.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(11, 11)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 16)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Nombre"
        '
        'txtDescripcionInsertarCategoria
        '
        Me.txtDescripcionInsertarCategoria.Location = New System.Drawing.Point(14, 91)
        Me.txtDescripcionInsertarCategoria.Name = "txtDescripcionInsertarCategoria"
        Me.txtDescripcionInsertarCategoria.Size = New System.Drawing.Size(341, 20)
        Me.txtDescripcionInsertarCategoria.TabIndex = 11
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(11, 70)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 16)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Descripción"
        '
        'btnCancelarAgregarCategoria
        '
        Me.btnCancelarAgregarCategoria.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.btnCancelarAgregarCategoria.FlatAppearance.BorderSize = 0
        Me.btnCancelarAgregarCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelarAgregarCategoria.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelarAgregarCategoria.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.btnCancelarAgregarCategoria.Location = New System.Drawing.Point(164, 20)
        Me.btnCancelarAgregarCategoria.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCancelarAgregarCategoria.Name = "btnCancelarAgregarCategoria"
        Me.btnCancelarAgregarCategoria.Size = New System.Drawing.Size(87, 30)
        Me.btnCancelarAgregarCategoria.TabIndex = 11
        Me.btnCancelarAgregarCategoria.Text = "Cancelar"
        Me.btnCancelarAgregarCategoria.UseVisualStyleBackColor = False
        '
        'btnAceptarAgregarCategoria
        '
        Me.btnAceptarAgregarCategoria.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.btnAceptarAgregarCategoria.FlatAppearance.BorderSize = 0
        Me.btnAceptarAgregarCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAceptarAgregarCategoria.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAceptarAgregarCategoria.ForeColor = System.Drawing.Color.White
        Me.btnAceptarAgregarCategoria.Location = New System.Drawing.Point(270, 20)
        Me.btnAceptarAgregarCategoria.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAceptarAgregarCategoria.Name = "btnAceptarAgregarCategoria"
        Me.btnAceptarAgregarCategoria.Size = New System.Drawing.Size(87, 30)
        Me.btnAceptarAgregarCategoria.TabIndex = 10
        Me.btnAceptarAgregarCategoria.Text = "Aceptar"
        Me.btnAceptarAgregarCategoria.UseVisualStyleBackColor = False
        '
        'FormInsertarCategorias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(395, 265)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FormInsertarCategorias"
        Me.Text = "FormInsertarCategorias"
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
    Friend WithEvents txtDescripcionInsertarCategoria As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtNombreAgregarCategoria As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnCancelarAgregarCategoria As Button
    Friend WithEvents btnAceptarAgregarCategoria As Button
End Class
