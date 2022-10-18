<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormInsertarEmpleado
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
        Me.btnAgregarInsertarEmpleado = New System.Windows.Forms.Button()
        Me.btnCancelarInsertarEmpleado = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cbxDistritoInsertarEmpl = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cbxProvinciaInsertarEmpl = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cbxPaisInsertarEmpleado = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cbxRegionInsertarEmple = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cbxTipoDocumentoInsertarEmp = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.dtpNacimientoInsertarEmpleado = New System.Windows.Forms.DateTimePicker()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtDireccionInsertarEmpl = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtApellidoMaternoInsertarEmpleado = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtDocumentoInsertarEmple = New System.Windows.Forms.TextBox()
        Me.txtNameInsertarEmpleado = New System.Windows.Forms.TextBox()
        Me.txtApellidoPaternoInsertarEmpleado = New System.Windows.Forms.TextBox()
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
        Me.Panel1.Size = New System.Drawing.Size(593, 55)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(20, 23)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(142, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Agregar Empleado"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.btnAgregarInsertarEmpleado)
        Me.Panel2.Controls.Add(Me.btnCancelarInsertarEmpleado)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 381)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(593, 68)
        Me.Panel2.TabIndex = 1
        '
        'btnAgregarInsertarEmpleado
        '
        Me.btnAgregarInsertarEmpleado.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.btnAgregarInsertarEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregarInsertarEmpleado.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnAgregarInsertarEmpleado.ForeColor = System.Drawing.Color.White
        Me.btnAgregarInsertarEmpleado.Location = New System.Drawing.Point(484, 17)
        Me.btnAgregarInsertarEmpleado.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAgregarInsertarEmpleado.Name = "btnAgregarInsertarEmpleado"
        Me.btnAgregarInsertarEmpleado.Size = New System.Drawing.Size(87, 30)
        Me.btnAgregarInsertarEmpleado.TabIndex = 27
        Me.btnAgregarInsertarEmpleado.Text = "Agregar"
        Me.btnAgregarInsertarEmpleado.UseVisualStyleBackColor = False
        '
        'btnCancelarInsertarEmpleado
        '
        Me.btnCancelarInsertarEmpleado.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.btnCancelarInsertarEmpleado.FlatAppearance.BorderSize = 0
        Me.btnCancelarInsertarEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelarInsertarEmpleado.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnCancelarInsertarEmpleado.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.btnCancelarInsertarEmpleado.Location = New System.Drawing.Point(375, 17)
        Me.btnCancelarInsertarEmpleado.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCancelarInsertarEmpleado.Name = "btnCancelarInsertarEmpleado"
        Me.btnCancelarInsertarEmpleado.Size = New System.Drawing.Size(80, 30)
        Me.btnCancelarInsertarEmpleado.TabIndex = 28
        Me.btnCancelarInsertarEmpleado.Text = "Cancelar"
        Me.btnCancelarInsertarEmpleado.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.cbxDistritoInsertarEmpl)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Controls.Add(Me.cbxProvinciaInsertarEmpl)
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Controls.Add(Me.cbxPaisInsertarEmpleado)
        Me.Panel3.Controls.Add(Me.Label7)
        Me.Panel3.Controls.Add(Me.cbxRegionInsertarEmple)
        Me.Panel3.Controls.Add(Me.Label9)
        Me.Panel3.Controls.Add(Me.cbxTipoDocumentoInsertarEmp)
        Me.Panel3.Controls.Add(Me.Label10)
        Me.Panel3.Controls.Add(Me.dtpNacimientoInsertarEmpleado)
        Me.Panel3.Controls.Add(Me.Label11)
        Me.Panel3.Controls.Add(Me.txtDireccionInsertarEmpl)
        Me.Panel3.Controls.Add(Me.Label12)
        Me.Panel3.Controls.Add(Me.txtApellidoMaternoInsertarEmpleado)
        Me.Panel3.Controls.Add(Me.Label13)
        Me.Panel3.Controls.Add(Me.txtDocumentoInsertarEmple)
        Me.Panel3.Controls.Add(Me.txtNameInsertarEmpleado)
        Me.Panel3.Controls.Add(Me.txtApellidoPaternoInsertarEmpleado)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 55)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(593, 326)
        Me.Panel3.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(21, 14)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 17)
        Me.Label2.TabIndex = 34
        Me.Label2.Text = "Nombre"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(23, 63)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(112, 17)
        Me.Label3.TabIndex = 35
        Me.Label3.Text = "Apellido Paterno"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(24, 110)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(111, 17)
        Me.Label4.TabIndex = 36
        Me.Label4.Text = "Apelido Materno"
        '
        'cbxDistritoInsertarEmpl
        '
        Me.cbxDistritoInsertarEmpl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxDistritoInsertarEmpl.FormattingEnabled = True
        Me.cbxDistritoInsertarEmpl.Location = New System.Drawing.Point(319, 187)
        Me.cbxDistritoInsertarEmpl.Margin = New System.Windows.Forms.Padding(2)
        Me.cbxDistritoInsertarEmpl.Name = "cbxDistritoInsertarEmpl"
        Me.cbxDistritoInsertarEmpl.Size = New System.Drawing.Size(242, 21)
        Me.cbxDistritoInsertarEmpl.TabIndex = 57
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(24, 165)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(112, 17)
        Me.Label5.TabIndex = 37
        Me.Label5.Text = "Tipo Documento"
        '
        'cbxProvinciaInsertarEmpl
        '
        Me.cbxProvinciaInsertarEmpl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxProvinciaInsertarEmpl.FormattingEnabled = True
        Me.cbxProvinciaInsertarEmpl.Location = New System.Drawing.Point(319, 134)
        Me.cbxProvinciaInsertarEmpl.Margin = New System.Windows.Forms.Padding(2)
        Me.cbxProvinciaInsertarEmpl.Name = "cbxProvinciaInsertarEmpl"
        Me.cbxProvinciaInsertarEmpl.Size = New System.Drawing.Size(242, 21)
        Me.cbxProvinciaInsertarEmpl.TabIndex = 56
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(24, 218)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(100, 17)
        Me.Label6.TabIndex = 38
        Me.Label6.Text = "N° Documento"
        '
        'cbxPaisInsertarEmpleado
        '
        Me.cbxPaisInsertarEmpleado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxPaisInsertarEmpleado.FormattingEnabled = True
        Me.cbxPaisInsertarEmpleado.Location = New System.Drawing.Point(319, 31)
        Me.cbxPaisInsertarEmpleado.Margin = New System.Windows.Forms.Padding(2)
        Me.cbxPaisInsertarEmpleado.Name = "cbxPaisInsertarEmpleado"
        Me.cbxPaisInsertarEmpleado.Size = New System.Drawing.Size(242, 21)
        Me.cbxPaisInsertarEmpleado.TabIndex = 55
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(24, 265)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(139, 17)
        Me.Label7.TabIndex = 39
        Me.Label7.Text = "Fecha de nacimiento"
        '
        'cbxRegionInsertarEmple
        '
        Me.cbxRegionInsertarEmple.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxRegionInsertarEmple.FormattingEnabled = True
        Me.cbxRegionInsertarEmple.Location = New System.Drawing.Point(318, 82)
        Me.cbxRegionInsertarEmple.Margin = New System.Windows.Forms.Padding(2)
        Me.cbxRegionInsertarEmple.Name = "cbxRegionInsertarEmple"
        Me.cbxRegionInsertarEmple.Size = New System.Drawing.Size(242, 21)
        Me.cbxRegionInsertarEmple.TabIndex = 54
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(316, 14)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(35, 17)
        Me.Label9.TabIndex = 41
        Me.Label9.Text = "País"
        '
        'cbxTipoDocumentoInsertarEmp
        '
        Me.cbxTipoDocumentoInsertarEmp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxTipoDocumentoInsertarEmp.FormattingEnabled = True
        Me.cbxTipoDocumentoInsertarEmp.Location = New System.Drawing.Point(23, 183)
        Me.cbxTipoDocumentoInsertarEmp.Margin = New System.Windows.Forms.Padding(2)
        Me.cbxTipoDocumentoInsertarEmp.Name = "cbxTipoDocumentoInsertarEmp"
        Me.cbxTipoDocumentoInsertarEmp.Size = New System.Drawing.Size(242, 21)
        Me.cbxTipoDocumentoInsertarEmp.TabIndex = 52
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(315, 61)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(53, 17)
        Me.Label10.TabIndex = 42
        Me.Label10.Text = "Región"
        '
        'dtpNacimientoInsertarEmpleado
        '
        Me.dtpNacimientoInsertarEmpleado.Location = New System.Drawing.Point(23, 293)
        Me.dtpNacimientoInsertarEmpleado.Margin = New System.Windows.Forms.Padding(2)
        Me.dtpNacimientoInsertarEmpleado.Name = "dtpNacimientoInsertarEmpleado"
        Me.dtpNacimientoInsertarEmpleado.Size = New System.Drawing.Size(242, 20)
        Me.dtpNacimientoInsertarEmpleado.TabIndex = 51
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(315, 116)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(66, 17)
        Me.Label11.TabIndex = 43
        Me.Label11.Text = "Provincia"
        '
        'txtDireccionInsertarEmpl
        '
        Me.txtDireccionInsertarEmpl.Location = New System.Drawing.Point(319, 236)
        Me.txtDireccionInsertarEmpl.Margin = New System.Windows.Forms.Padding(2)
        Me.txtDireccionInsertarEmpl.Name = "txtDireccionInsertarEmpl"
        Me.txtDireccionInsertarEmpl.Size = New System.Drawing.Size(243, 20)
        Me.txtDireccionInsertarEmpl.TabIndex = 50
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(315, 169)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(52, 17)
        Me.Label12.TabIndex = 44
        Me.Label12.Text = "Distrito"
        '
        'txtApellidoMaternoInsertarEmpleado
        '
        Me.txtApellidoMaternoInsertarEmpleado.Location = New System.Drawing.Point(23, 136)
        Me.txtApellidoMaternoInsertarEmpleado.Margin = New System.Windows.Forms.Padding(2)
        Me.txtApellidoMaternoInsertarEmpleado.Name = "txtApellidoMaternoInsertarEmpleado"
        Me.txtApellidoMaternoInsertarEmpleado.Size = New System.Drawing.Size(243, 20)
        Me.txtApellidoMaternoInsertarEmpleado.TabIndex = 49
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(315, 216)
        Me.Label13.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(67, 17)
        Me.Label13.TabIndex = 45
        Me.Label13.Text = "Dirección"
        '
        'txtDocumentoInsertarEmple
        '
        Me.txtDocumentoInsertarEmple.Location = New System.Drawing.Point(23, 236)
        Me.txtDocumentoInsertarEmple.Margin = New System.Windows.Forms.Padding(2)
        Me.txtDocumentoInsertarEmple.Name = "txtDocumentoInsertarEmple"
        Me.txtDocumentoInsertarEmple.Size = New System.Drawing.Size(243, 20)
        Me.txtDocumentoInsertarEmple.TabIndex = 48
        '
        'txtNameInsertarEmpleado
        '
        Me.txtNameInsertarEmpleado.Location = New System.Drawing.Point(23, 34)
        Me.txtNameInsertarEmpleado.Margin = New System.Windows.Forms.Padding(2)
        Me.txtNameInsertarEmpleado.Name = "txtNameInsertarEmpleado"
        Me.txtNameInsertarEmpleado.Size = New System.Drawing.Size(243, 20)
        Me.txtNameInsertarEmpleado.TabIndex = 46
        '
        'txtApellidoPaternoInsertarEmpleado
        '
        Me.txtApellidoPaternoInsertarEmpleado.Location = New System.Drawing.Point(23, 82)
        Me.txtApellidoPaternoInsertarEmpleado.Margin = New System.Windows.Forms.Padding(2)
        Me.txtApellidoPaternoInsertarEmpleado.Name = "txtApellidoPaternoInsertarEmpleado"
        Me.txtApellidoPaternoInsertarEmpleado.Size = New System.Drawing.Size(243, 20)
        Me.txtApellidoPaternoInsertarEmpleado.TabIndex = 47
        '
        'FormInsertarEmpleado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(593, 449)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FormInsertarEmpleado"
        Me.Text = "FormInsertarEmpleado"
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
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents cbxDistritoInsertarEmpl As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents cbxProvinciaInsertarEmpl As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents cbxPaisInsertarEmpleado As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents cbxRegionInsertarEmple As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents cbxTipoDocumentoInsertarEmp As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents dtpNacimientoInsertarEmpleado As DateTimePicker
    Friend WithEvents Label11 As Label
    Friend WithEvents txtDireccionInsertarEmpl As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txtApellidoMaternoInsertarEmpleado As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents txtDocumentoInsertarEmple As TextBox
    Friend WithEvents txtNameInsertarEmpleado As TextBox
    Friend WithEvents txtApellidoPaternoInsertarEmpleado As TextBox
    Friend WithEvents btnAgregarInsertarEmpleado As Button
    Friend WithEvents btnCancelarInsertarEmpleado As Button
    Friend WithEvents Label1 As Label
End Class
