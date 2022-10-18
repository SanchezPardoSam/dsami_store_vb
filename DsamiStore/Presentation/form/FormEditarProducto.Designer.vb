<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormEditarProducto
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
        Me.cbxMonedaEditarProducto = New System.Windows.Forms.ComboBox()
        Me.cbxAlmacenEditarProducto = New System.Windows.Forms.ComboBox()
        Me.cbxCategoriaEditarProducto = New System.Windows.Forms.ComboBox()
        Me.cbxMarcaEditarProducto = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtPrecioEditarProducto = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtCodigoEditarProducto = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtDescripciónEditarProducto = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNombreEditarProducto = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnCancelarEditarProducto = New System.Windows.Forms.Button()
        Me.btnAceptarEditarProducto = New System.Windows.Forms.Button()
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
        Me.Panel1.Size = New System.Drawing.Size(385, 58)
        Me.Panel1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.btnCancelarEditarProducto)
        Me.Panel2.Controls.Add(Me.btnAceptarEditarProducto)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 472)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(385, 55)
        Me.Panel2.TabIndex = 1
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel3.Controls.Add(Me.cbxMonedaEditarProducto)
        Me.Panel3.Controls.Add(Me.cbxAlmacenEditarProducto)
        Me.Panel3.Controls.Add(Me.cbxCategoriaEditarProducto)
        Me.Panel3.Controls.Add(Me.cbxMarcaEditarProducto)
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Controls.Add(Me.Label7)
        Me.Panel3.Controls.Add(Me.Label8)
        Me.Panel3.Controls.Add(Me.Label9)
        Me.Panel3.Controls.Add(Me.txtPrecioEditarProducto)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.txtCodigoEditarProducto)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Controls.Add(Me.txtDescripciónEditarProducto)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.txtNombreEditarProducto)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 58)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(385, 414)
        Me.Panel3.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(26, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(121, 17)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Editar Producto"
        '
        'cbxMonedaEditarProducto
        '
        Me.cbxMonedaEditarProducto.FormattingEnabled = True
        Me.cbxMonedaEditarProducto.Location = New System.Drawing.Point(21, 384)
        Me.cbxMonedaEditarProducto.Name = "cbxMonedaEditarProducto"
        Me.cbxMonedaEditarProducto.Size = New System.Drawing.Size(341, 21)
        Me.cbxMonedaEditarProducto.TabIndex = 47
        '
        'cbxAlmacenEditarProducto
        '
        Me.cbxAlmacenEditarProducto.FormattingEnabled = True
        Me.cbxAlmacenEditarProducto.Location = New System.Drawing.Point(21, 333)
        Me.cbxAlmacenEditarProducto.Name = "cbxAlmacenEditarProducto"
        Me.cbxAlmacenEditarProducto.Size = New System.Drawing.Size(341, 21)
        Me.cbxAlmacenEditarProducto.TabIndex = 46
        '
        'cbxCategoriaEditarProducto
        '
        Me.cbxCategoriaEditarProducto.FormattingEnabled = True
        Me.cbxCategoriaEditarProducto.Location = New System.Drawing.Point(21, 282)
        Me.cbxCategoriaEditarProducto.Name = "cbxCategoriaEditarProducto"
        Me.cbxCategoriaEditarProducto.Size = New System.Drawing.Size(341, 21)
        Me.cbxCategoriaEditarProducto.TabIndex = 45
        '
        'cbxMarcaEditarProducto
        '
        Me.cbxMarcaEditarProducto.FormattingEnabled = True
        Me.cbxMarcaEditarProducto.Location = New System.Drawing.Point(21, 228)
        Me.cbxMarcaEditarProducto.Name = "cbxMarcaEditarProducto"
        Me.cbxMarcaEditarProducto.Size = New System.Drawing.Size(341, 21)
        Me.cbxMarcaEditarProducto.TabIndex = 44
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(18, 364)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(57, 16)
        Me.Label6.TabIndex = 43
        Me.Label6.Text = "Moneda"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(18, 313)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(60, 16)
        Me.Label7.TabIndex = 42
        Me.Label7.Text = "Almacen"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(18, 262)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(66, 16)
        Me.Label8.TabIndex = 41
        Me.Label8.Text = "CategorÍa"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(18, 208)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(45, 16)
        Me.Label9.TabIndex = 40
        Me.Label9.Text = "Marca"
        '
        'txtPrecioEditarProducto
        '
        Me.txtPrecioEditarProducto.Location = New System.Drawing.Point(21, 177)
        Me.txtPrecioEditarProducto.Name = "txtPrecioEditarProducto"
        Me.txtPrecioEditarProducto.Size = New System.Drawing.Size(341, 20)
        Me.txtPrecioEditarProducto.TabIndex = 39
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(18, 156)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 16)
        Me.Label4.TabIndex = 38
        Me.Label4.Text = "Precio"
        '
        'txtCodigoEditarProducto
        '
        Me.txtCodigoEditarProducto.Location = New System.Drawing.Point(21, 127)
        Me.txtCodigoEditarProducto.Name = "txtCodigoEditarProducto"
        Me.txtCodigoEditarProducto.Size = New System.Drawing.Size(341, 20)
        Me.txtCodigoEditarProducto.TabIndex = 37
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(18, 106)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(112, 16)
        Me.Label5.TabIndex = 36
        Me.Label5.Text = "Codigo de barras"
        '
        'txtDescripciónEditarProducto
        '
        Me.txtDescripciónEditarProducto.Location = New System.Drawing.Point(21, 77)
        Me.txtDescripciónEditarProducto.Name = "txtDescripciónEditarProducto"
        Me.txtDescripciónEditarProducto.Size = New System.Drawing.Size(341, 20)
        Me.txtDescripciónEditarProducto.TabIndex = 35
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(18, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 16)
        Me.Label2.TabIndex = 34
        Me.Label2.Text = "Descripción"
        '
        'txtNombreEditarProducto
        '
        Me.txtNombreEditarProducto.Location = New System.Drawing.Point(21, 27)
        Me.txtNombreEditarProducto.Name = "txtNombreEditarProducto"
        Me.txtNombreEditarProducto.Size = New System.Drawing.Size(341, 20)
        Me.txtNombreEditarProducto.TabIndex = 33
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(18, 6)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 16)
        Me.Label3.TabIndex = 32
        Me.Label3.Text = "Nombre"
        '
        'btnCancelarEditarProducto
        '
        Me.btnCancelarEditarProducto.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.btnCancelarEditarProducto.FlatAppearance.BorderSize = 0
        Me.btnCancelarEditarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelarEditarProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelarEditarProducto.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.btnCancelarEditarProducto.Location = New System.Drawing.Point(171, 14)
        Me.btnCancelarEditarProducto.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCancelarEditarProducto.Name = "btnCancelarEditarProducto"
        Me.btnCancelarEditarProducto.Size = New System.Drawing.Size(87, 30)
        Me.btnCancelarEditarProducto.TabIndex = 15
        Me.btnCancelarEditarProducto.Text = "Cancelar"
        Me.btnCancelarEditarProducto.UseVisualStyleBackColor = False
        '
        'btnAceptarEditarProducto
        '
        Me.btnAceptarEditarProducto.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.btnAceptarEditarProducto.FlatAppearance.BorderSize = 0
        Me.btnAceptarEditarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAceptarEditarProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAceptarEditarProducto.ForeColor = System.Drawing.Color.White
        Me.btnAceptarEditarProducto.Location = New System.Drawing.Point(277, 14)
        Me.btnAceptarEditarProducto.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAceptarEditarProducto.Name = "btnAceptarEditarProducto"
        Me.btnAceptarEditarProducto.Size = New System.Drawing.Size(87, 30)
        Me.btnAceptarEditarProducto.TabIndex = 14
        Me.btnAceptarEditarProducto.Text = "Aceptar"
        Me.btnAceptarEditarProducto.UseVisualStyleBackColor = False
        '
        'FormEditarProducto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(385, 527)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FormEditarProducto"
        Me.Text = "FormEditarProducto"
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
    Friend WithEvents cbxMonedaEditarProducto As ComboBox
    Friend WithEvents cbxAlmacenEditarProducto As ComboBox
    Friend WithEvents cbxCategoriaEditarProducto As ComboBox
    Friend WithEvents cbxMarcaEditarProducto As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txtPrecioEditarProducto As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtCodigoEditarProducto As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtDescripciónEditarProducto As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtNombreEditarProducto As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnCancelarEditarProducto As Button
    Friend WithEvents btnAceptarEditarProducto As Button
End Class
