<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormEditarProveedor
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cbxDistritoEditarProveedor = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cbxProvinciaEditarProveedor = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cbxPaisEditarProveedor = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cbxRegionEditarProveedor = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cbxEmpresaEditarProveedor = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cbxTipoDocumentoEditarProv = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.dtpNacimientoEditarProveedor = New System.Windows.Forms.DateTimePicker()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtDireccionEditarProveedor = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtApellidoMaternoEditarProv = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtDocumentoEditarProveedor = New System.Windows.Forms.TextBox()
        Me.txtNameEditarProveedor = New System.Windows.Forms.TextBox()
        Me.txtApellidoPaternoEditarProv = New System.Windows.Forms.TextBox()
        Me.btnAgregarEditarProveedor = New System.Windows.Forms.Button()
        Me.btnCancelarEditarProveedor = New System.Windows.Forms.Button()
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
        Me.Panel1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(593, 55)
        Me.Panel1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.btnAgregarEditarProveedor)
        Me.Panel2.Controls.Add(Me.btnCancelarEditarProveedor)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Panel2.Location = New System.Drawing.Point(0, 381)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(593, 68)
        Me.Panel2.TabIndex = 1
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.cbxDistritoEditarProveedor)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Controls.Add(Me.cbxProvinciaEditarProveedor)
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Controls.Add(Me.cbxPaisEditarProveedor)
        Me.Panel3.Controls.Add(Me.Label7)
        Me.Panel3.Controls.Add(Me.cbxRegionEditarProveedor)
        Me.Panel3.Controls.Add(Me.Label8)
        Me.Panel3.Controls.Add(Me.cbxEmpresaEditarProveedor)
        Me.Panel3.Controls.Add(Me.Label9)
        Me.Panel3.Controls.Add(Me.cbxTipoDocumentoEditarProv)
        Me.Panel3.Controls.Add(Me.Label10)
        Me.Panel3.Controls.Add(Me.dtpNacimientoEditarProveedor)
        Me.Panel3.Controls.Add(Me.Label11)
        Me.Panel3.Controls.Add(Me.txtDireccionEditarProveedor)
        Me.Panel3.Controls.Add(Me.Label12)
        Me.Panel3.Controls.Add(Me.txtApellidoMaternoEditarProv)
        Me.Panel3.Controls.Add(Me.Label13)
        Me.Panel3.Controls.Add(Me.txtDocumentoEditarProveedor)
        Me.Panel3.Controls.Add(Me.txtNameEditarProveedor)
        Me.Panel3.Controls.Add(Me.txtApellidoPaternoEditarProv)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Panel3.Location = New System.Drawing.Point(0, 55)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(593, 326)
        Me.Panel3.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(21, 19)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(131, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Editar Proveedor"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(19, 12)
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
        Me.Label3.Location = New System.Drawing.Point(21, 61)
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
        Me.Label4.Location = New System.Drawing.Point(22, 108)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(111, 17)
        Me.Label4.TabIndex = 36
        Me.Label4.Text = "Apelido Materno"
        '
        'cbxDistritoEditarProveedor
        '
        Me.cbxDistritoEditarProveedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxDistritoEditarProveedor.FormattingEnabled = True
        Me.cbxDistritoEditarProveedor.Location = New System.Drawing.Point(326, 234)
        Me.cbxDistritoEditarProveedor.Margin = New System.Windows.Forms.Padding(2)
        Me.cbxDistritoEditarProveedor.Name = "cbxDistritoEditarProveedor"
        Me.cbxDistritoEditarProveedor.Size = New System.Drawing.Size(242, 21)
        Me.cbxDistritoEditarProveedor.TabIndex = 57
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(22, 163)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(112, 17)
        Me.Label5.TabIndex = 37
        Me.Label5.Text = "Tipo Documento"
        '
        'cbxProvinciaEditarProveedor
        '
        Me.cbxProvinciaEditarProveedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxProvinciaEditarProveedor.FormattingEnabled = True
        Me.cbxProvinciaEditarProveedor.Location = New System.Drawing.Point(326, 181)
        Me.cbxProvinciaEditarProveedor.Margin = New System.Windows.Forms.Padding(2)
        Me.cbxProvinciaEditarProveedor.Name = "cbxProvinciaEditarProveedor"
        Me.cbxProvinciaEditarProveedor.Size = New System.Drawing.Size(242, 21)
        Me.cbxProvinciaEditarProveedor.TabIndex = 56
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(22, 216)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(100, 17)
        Me.Label6.TabIndex = 38
        Me.Label6.Text = "N° Documento"
        '
        'cbxPaisEditarProveedor
        '
        Me.cbxPaisEditarProveedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxPaisEditarProveedor.FormattingEnabled = True
        Me.cbxPaisEditarProveedor.Location = New System.Drawing.Point(326, 78)
        Me.cbxPaisEditarProveedor.Margin = New System.Windows.Forms.Padding(2)
        Me.cbxPaisEditarProveedor.Name = "cbxPaisEditarProveedor"
        Me.cbxPaisEditarProveedor.Size = New System.Drawing.Size(242, 21)
        Me.cbxPaisEditarProveedor.TabIndex = 55
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(22, 263)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(139, 17)
        Me.Label7.TabIndex = 39
        Me.Label7.Text = "Fecha de nacimiento"
        '
        'cbxRegionEditarProveedor
        '
        Me.cbxRegionEditarProveedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxRegionEditarProveedor.FormattingEnabled = True
        Me.cbxRegionEditarProveedor.Location = New System.Drawing.Point(326, 134)
        Me.cbxRegionEditarProveedor.Margin = New System.Windows.Forms.Padding(2)
        Me.cbxRegionEditarProveedor.Name = "cbxRegionEditarProveedor"
        Me.cbxRegionEditarProveedor.Size = New System.Drawing.Size(242, 21)
        Me.cbxRegionEditarProveedor.TabIndex = 54
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(322, 12)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(64, 17)
        Me.Label8.TabIndex = 40
        Me.Label8.Text = "Empresa"
        '
        'cbxEmpresaEditarProveedor
        '
        Me.cbxEmpresaEditarProveedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxEmpresaEditarProveedor.FormattingEnabled = True
        Me.cbxEmpresaEditarProveedor.Location = New System.Drawing.Point(326, 30)
        Me.cbxEmpresaEditarProveedor.Margin = New System.Windows.Forms.Padding(2)
        Me.cbxEmpresaEditarProveedor.Name = "cbxEmpresaEditarProveedor"
        Me.cbxEmpresaEditarProveedor.Size = New System.Drawing.Size(242, 21)
        Me.cbxEmpresaEditarProveedor.TabIndex = 53
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(322, 61)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(35, 17)
        Me.Label9.TabIndex = 41
        Me.Label9.Text = "País"
        '
        'cbxTipoDocumentoEditarProv
        '
        Me.cbxTipoDocumentoEditarProv.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxTipoDocumentoEditarProv.FormattingEnabled = True
        Me.cbxTipoDocumentoEditarProv.Location = New System.Drawing.Point(21, 181)
        Me.cbxTipoDocumentoEditarProv.Margin = New System.Windows.Forms.Padding(2)
        Me.cbxTipoDocumentoEditarProv.Name = "cbxTipoDocumentoEditarProv"
        Me.cbxTipoDocumentoEditarProv.Size = New System.Drawing.Size(242, 21)
        Me.cbxTipoDocumentoEditarProv.TabIndex = 52
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(322, 108)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(53, 17)
        Me.Label10.TabIndex = 42
        Me.Label10.Text = "Región"
        '
        'dtpNacimientoEditarProveedor
        '
        Me.dtpNacimientoEditarProveedor.Location = New System.Drawing.Point(21, 291)
        Me.dtpNacimientoEditarProveedor.Margin = New System.Windows.Forms.Padding(2)
        Me.dtpNacimientoEditarProveedor.Name = "dtpNacimientoEditarProveedor"
        Me.dtpNacimientoEditarProveedor.Size = New System.Drawing.Size(151, 20)
        Me.dtpNacimientoEditarProveedor.TabIndex = 51
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(322, 163)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(66, 17)
        Me.Label11.TabIndex = 43
        Me.Label11.Text = "Provincia"
        '
        'txtDireccionEditarProveedor
        '
        Me.txtDireccionEditarProveedor.Location = New System.Drawing.Point(326, 281)
        Me.txtDireccionEditarProveedor.Margin = New System.Windows.Forms.Padding(2)
        Me.txtDireccionEditarProveedor.Name = "txtDireccionEditarProveedor"
        Me.txtDireccionEditarProveedor.Size = New System.Drawing.Size(243, 20)
        Me.txtDireccionEditarProveedor.TabIndex = 50
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(322, 216)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(52, 17)
        Me.Label12.TabIndex = 44
        Me.Label12.Text = "Distrito"
        '
        'txtApellidoMaternoEditarProv
        '
        Me.txtApellidoMaternoEditarProv.Location = New System.Drawing.Point(21, 134)
        Me.txtApellidoMaternoEditarProv.Margin = New System.Windows.Forms.Padding(2)
        Me.txtApellidoMaternoEditarProv.Name = "txtApellidoMaternoEditarProv"
        Me.txtApellidoMaternoEditarProv.Size = New System.Drawing.Size(243, 20)
        Me.txtApellidoMaternoEditarProv.TabIndex = 49
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(322, 263)
        Me.Label13.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(67, 17)
        Me.Label13.TabIndex = 45
        Me.Label13.Text = "Dirección"
        '
        'txtDocumentoEditarProveedor
        '
        Me.txtDocumentoEditarProveedor.Location = New System.Drawing.Point(21, 234)
        Me.txtDocumentoEditarProveedor.Margin = New System.Windows.Forms.Padding(2)
        Me.txtDocumentoEditarProveedor.Name = "txtDocumentoEditarProveedor"
        Me.txtDocumentoEditarProveedor.Size = New System.Drawing.Size(243, 20)
        Me.txtDocumentoEditarProveedor.TabIndex = 48
        '
        'txtNameEditarProveedor
        '
        Me.txtNameEditarProveedor.Location = New System.Drawing.Point(21, 32)
        Me.txtNameEditarProveedor.Margin = New System.Windows.Forms.Padding(2)
        Me.txtNameEditarProveedor.Name = "txtNameEditarProveedor"
        Me.txtNameEditarProveedor.Size = New System.Drawing.Size(243, 20)
        Me.txtNameEditarProveedor.TabIndex = 46
        '
        'txtApellidoPaternoEditarProv
        '
        Me.txtApellidoPaternoEditarProv.Location = New System.Drawing.Point(21, 80)
        Me.txtApellidoPaternoEditarProv.Margin = New System.Windows.Forms.Padding(2)
        Me.txtApellidoPaternoEditarProv.Name = "txtApellidoPaternoEditarProv"
        Me.txtApellidoPaternoEditarProv.Size = New System.Drawing.Size(243, 20)
        Me.txtApellidoPaternoEditarProv.TabIndex = 47
        '
        'btnAgregarEditarProveedor
        '
        Me.btnAgregarEditarProveedor.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.btnAgregarEditarProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregarEditarProveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnAgregarEditarProveedor.ForeColor = System.Drawing.Color.White
        Me.btnAgregarEditarProveedor.Location = New System.Drawing.Point(484, 18)
        Me.btnAgregarEditarProveedor.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAgregarEditarProveedor.Name = "btnAgregarEditarProveedor"
        Me.btnAgregarEditarProveedor.Size = New System.Drawing.Size(87, 30)
        Me.btnAgregarEditarProveedor.TabIndex = 27
        Me.btnAgregarEditarProveedor.Text = "Agregar"
        Me.btnAgregarEditarProveedor.UseVisualStyleBackColor = False
        '
        'btnCancelarEditarProveedor
        '
        Me.btnCancelarEditarProveedor.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.btnCancelarEditarProveedor.FlatAppearance.BorderSize = 0
        Me.btnCancelarEditarProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelarEditarProveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnCancelarEditarProveedor.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.btnCancelarEditarProveedor.Location = New System.Drawing.Point(381, 18)
        Me.btnCancelarEditarProveedor.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCancelarEditarProveedor.Name = "btnCancelarEditarProveedor"
        Me.btnCancelarEditarProveedor.Size = New System.Drawing.Size(80, 30)
        Me.btnCancelarEditarProveedor.TabIndex = 28
        Me.btnCancelarEditarProveedor.Text = "Cancelar"
        Me.btnCancelarEditarProveedor.UseVisualStyleBackColor = False
        '
        'FormEditarProveedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(593, 449)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FormEditarProveedor"
        Me.Text = "FormEditarProveedor"
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
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents cbxDistritoEditarProveedor As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents cbxProvinciaEditarProveedor As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents cbxPaisEditarProveedor As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents cbxRegionEditarProveedor As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents cbxEmpresaEditarProveedor As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents cbxTipoDocumentoEditarProv As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents dtpNacimientoEditarProveedor As DateTimePicker
    Friend WithEvents Label11 As Label
    Friend WithEvents txtDireccionEditarProveedor As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txtApellidoMaternoEditarProv As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents txtDocumentoEditarProveedor As TextBox
    Friend WithEvents txtNameEditarProveedor As TextBox
    Friend WithEvents txtApellidoPaternoEditarProv As TextBox
    Friend WithEvents btnAgregarEditarProveedor As Button
    Friend WithEvents btnCancelarEditarProveedor As Button
End Class
