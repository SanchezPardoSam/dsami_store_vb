<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormInsertarProducto
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
        Me.btnCancelarInsertarProducto = New System.Windows.Forms.Button()
        Me.btnAceptarInsertarProducto = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.cbxMonedaInsertarProducto = New System.Windows.Forms.ComboBox()
        Me.cbxAlmacenInsertarProducto = New System.Windows.Forms.ComboBox()
        Me.cbxCategoriaInsertarProducto = New System.Windows.Forms.ComboBox()
        Me.cbxMarcaInsertarProducto = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtPrecioInsertarProducto = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtCodigoInsertarProducto = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtDescripciónInsertarProducto = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNombreInsertarProducto = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(23, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(136, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Agregar Producto"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.btnCancelarInsertarProducto)
        Me.Panel2.Controls.Add(Me.btnAceptarInsertarProducto)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 472)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(385, 55)
        Me.Panel2.TabIndex = 1
        '
        'btnCancelarInsertarProducto
        '
        Me.btnCancelarInsertarProducto.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.btnCancelarInsertarProducto.FlatAppearance.BorderSize = 0
        Me.btnCancelarInsertarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelarInsertarProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelarInsertarProducto.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.btnCancelarInsertarProducto.Location = New System.Drawing.Point(174, 14)
        Me.btnCancelarInsertarProducto.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCancelarInsertarProducto.Name = "btnCancelarInsertarProducto"
        Me.btnCancelarInsertarProducto.Size = New System.Drawing.Size(87, 30)
        Me.btnCancelarInsertarProducto.TabIndex = 13
        Me.btnCancelarInsertarProducto.Text = "Cancelar"
        Me.btnCancelarInsertarProducto.UseVisualStyleBackColor = False
        '
        'btnAceptarInsertarProducto
        '
        Me.btnAceptarInsertarProducto.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.btnAceptarInsertarProducto.FlatAppearance.BorderSize = 0
        Me.btnAceptarInsertarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAceptarInsertarProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAceptarInsertarProducto.ForeColor = System.Drawing.Color.White
        Me.btnAceptarInsertarProducto.Location = New System.Drawing.Point(280, 14)
        Me.btnAceptarInsertarProducto.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAceptarInsertarProducto.Name = "btnAceptarInsertarProducto"
        Me.btnAceptarInsertarProducto.Size = New System.Drawing.Size(87, 30)
        Me.btnAceptarInsertarProducto.TabIndex = 12
        Me.btnAceptarInsertarProducto.Text = "Aceptar"
        Me.btnAceptarInsertarProducto.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel3.Controls.Add(Me.cbxMonedaInsertarProducto)
        Me.Panel3.Controls.Add(Me.cbxAlmacenInsertarProducto)
        Me.Panel3.Controls.Add(Me.cbxCategoriaInsertarProducto)
        Me.Panel3.Controls.Add(Me.cbxMarcaInsertarProducto)
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Controls.Add(Me.Label7)
        Me.Panel3.Controls.Add(Me.Label8)
        Me.Panel3.Controls.Add(Me.Label9)
        Me.Panel3.Controls.Add(Me.txtPrecioInsertarProducto)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.txtCodigoInsertarProducto)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Controls.Add(Me.txtDescripciónInsertarProducto)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.txtNombreInsertarProducto)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 58)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(385, 414)
        Me.Panel3.TabIndex = 2
        '
        'cbxMonedaInsertarProducto
        '
        Me.cbxMonedaInsertarProducto.FormattingEnabled = True
        Me.cbxMonedaInsertarProducto.Location = New System.Drawing.Point(26, 383)
        Me.cbxMonedaInsertarProducto.Name = "cbxMonedaInsertarProducto"
        Me.cbxMonedaInsertarProducto.Size = New System.Drawing.Size(341, 21)
        Me.cbxMonedaInsertarProducto.TabIndex = 31
        '
        'cbxAlmacenInsertarProducto
        '
        Me.cbxAlmacenInsertarProducto.FormattingEnabled = True
        Me.cbxAlmacenInsertarProducto.Location = New System.Drawing.Point(26, 332)
        Me.cbxAlmacenInsertarProducto.Name = "cbxAlmacenInsertarProducto"
        Me.cbxAlmacenInsertarProducto.Size = New System.Drawing.Size(341, 21)
        Me.cbxAlmacenInsertarProducto.TabIndex = 30
        '
        'cbxCategoriaInsertarProducto
        '
        Me.cbxCategoriaInsertarProducto.FormattingEnabled = True
        Me.cbxCategoriaInsertarProducto.Location = New System.Drawing.Point(26, 281)
        Me.cbxCategoriaInsertarProducto.Name = "cbxCategoriaInsertarProducto"
        Me.cbxCategoriaInsertarProducto.Size = New System.Drawing.Size(341, 21)
        Me.cbxCategoriaInsertarProducto.TabIndex = 29
        '
        'cbxMarcaInsertarProducto
        '
        Me.cbxMarcaInsertarProducto.FormattingEnabled = True
        Me.cbxMarcaInsertarProducto.Location = New System.Drawing.Point(26, 227)
        Me.cbxMarcaInsertarProducto.Name = "cbxMarcaInsertarProducto"
        Me.cbxMarcaInsertarProducto.Size = New System.Drawing.Size(341, 21)
        Me.cbxMarcaInsertarProducto.TabIndex = 28
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(23, 363)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(57, 16)
        Me.Label6.TabIndex = 26
        Me.Label6.Text = "Moneda"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(23, 312)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(60, 16)
        Me.Label7.TabIndex = 24
        Me.Label7.Text = "Almacen"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(23, 261)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(66, 16)
        Me.Label8.TabIndex = 22
        Me.Label8.Text = "CategorÍa"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(23, 207)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(45, 16)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "Marca"
        '
        'txtPrecioInsertarProducto
        '
        Me.txtPrecioInsertarProducto.Location = New System.Drawing.Point(26, 176)
        Me.txtPrecioInsertarProducto.Name = "txtPrecioInsertarProducto"
        Me.txtPrecioInsertarProducto.Size = New System.Drawing.Size(341, 20)
        Me.txtPrecioInsertarProducto.TabIndex = 19
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(23, 155)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 16)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Precio"
        '
        'txtCodigoInsertarProducto
        '
        Me.txtCodigoInsertarProducto.Location = New System.Drawing.Point(26, 126)
        Me.txtCodigoInsertarProducto.Name = "txtCodigoInsertarProducto"
        Me.txtCodigoInsertarProducto.Size = New System.Drawing.Size(341, 20)
        Me.txtCodigoInsertarProducto.TabIndex = 17
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(23, 105)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(112, 16)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Codigo de barras"
        '
        'txtDescripciónInsertarProducto
        '
        Me.txtDescripciónInsertarProducto.Location = New System.Drawing.Point(26, 76)
        Me.txtDescripciónInsertarProducto.Name = "txtDescripciónInsertarProducto"
        Me.txtDescripciónInsertarProducto.Size = New System.Drawing.Size(341, 20)
        Me.txtDescripciónInsertarProducto.TabIndex = 15
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(23, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 16)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Descripción"
        '
        'txtNombreInsertarProducto
        '
        Me.txtNombreInsertarProducto.Location = New System.Drawing.Point(26, 26)
        Me.txtNombreInsertarProducto.Name = "txtNombreInsertarProducto"
        Me.txtNombreInsertarProducto.Size = New System.Drawing.Size(341, 20)
        Me.txtNombreInsertarProducto.TabIndex = 13
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(23, 5)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 16)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Nombre"
        '
        'FormInsertarProducto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(385, 527)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FormInsertarProducto"
        Me.Text = "FormInsertarProducto"
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
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txtPrecioInsertarProducto As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtCodigoInsertarProducto As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtDescripciónInsertarProducto As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtNombreInsertarProducto As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnCancelarInsertarProducto As Button
    Friend WithEvents btnAceptarInsertarProducto As Button
    Friend WithEvents cbxMonedaInsertarProducto As ComboBox
    Friend WithEvents cbxAlmacenInsertarProducto As ComboBox
    Friend WithEvents cbxCategoriaInsertarProducto As ComboBox
    Friend WithEvents cbxMarcaInsertarProducto As ComboBox
End Class
