<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormEditarProveedor
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.cbxDistrito = New System.Windows.Forms.ComboBox()
        Me.cbxProvincia = New System.Windows.Forms.ComboBox()
        Me.cbxPais = New System.Windows.Forms.ComboBox()
        Me.cbxRegion = New System.Windows.Forms.ComboBox()
        Me.cbxEmpresa = New System.Windows.Forms.ComboBox()
        Me.cbxTipoDocumento = New System.Windows.Forms.ComboBox()
        Me.dtpNacimiento = New System.Windows.Forms.DateTimePicker()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.txtApellidoMaterno = New System.Windows.Forms.TextBox()
        Me.txtDocumento = New System.Windows.Forms.TextBox()
        Me.txtApellidoPaterno = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'cbxDistrito
        '
        Me.cbxDistrito.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxDistrito.FormattingEnabled = True
        Me.cbxDistrito.Location = New System.Drawing.Point(322, 292)
        Me.cbxDistrito.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cbxDistrito.Name = "cbxDistrito"
        Me.cbxDistrito.Size = New System.Drawing.Size(242, 21)
        Me.cbxDistrito.TabIndex = 60
        '
        'cbxProvincia
        '
        Me.cbxProvincia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxProvincia.FormattingEnabled = True
        Me.cbxProvincia.Location = New System.Drawing.Point(322, 238)
        Me.cbxProvincia.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cbxProvincia.Name = "cbxProvincia"
        Me.cbxProvincia.Size = New System.Drawing.Size(242, 21)
        Me.cbxProvincia.TabIndex = 59
        '
        'cbxPais
        '
        Me.cbxPais.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxPais.FormattingEnabled = True
        Me.cbxPais.Location = New System.Drawing.Point(322, 136)
        Me.cbxPais.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cbxPais.Name = "cbxPais"
        Me.cbxPais.Size = New System.Drawing.Size(242, 21)
        Me.cbxPais.TabIndex = 58
        '
        'cbxRegion
        '
        Me.cbxRegion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxRegion.FormattingEnabled = True
        Me.cbxRegion.Location = New System.Drawing.Point(322, 192)
        Me.cbxRegion.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cbxRegion.Name = "cbxRegion"
        Me.cbxRegion.Size = New System.Drawing.Size(242, 21)
        Me.cbxRegion.TabIndex = 57
        '
        'cbxEmpresa
        '
        Me.cbxEmpresa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxEmpresa.FormattingEnabled = True
        Me.cbxEmpresa.Location = New System.Drawing.Point(322, 88)
        Me.cbxEmpresa.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cbxEmpresa.Name = "cbxEmpresa"
        Me.cbxEmpresa.Size = New System.Drawing.Size(242, 21)
        Me.cbxEmpresa.TabIndex = 56
        '
        'cbxTipoDocumento
        '
        Me.cbxTipoDocumento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxTipoDocumento.FormattingEnabled = True
        Me.cbxTipoDocumento.Location = New System.Drawing.Point(17, 238)
        Me.cbxTipoDocumento.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cbxTipoDocumento.Name = "cbxTipoDocumento"
        Me.cbxTipoDocumento.Size = New System.Drawing.Size(242, 21)
        Me.cbxTipoDocumento.TabIndex = 55
        '
        'dtpNacimiento
        '
        Me.dtpNacimiento.Location = New System.Drawing.Point(17, 349)
        Me.dtpNacimiento.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.dtpNacimiento.Name = "dtpNacimiento"
        Me.dtpNacimiento.Size = New System.Drawing.Size(151, 20)
        Me.dtpNacimiento.TabIndex = 54
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(402, 383)
        Me.btnCancelar.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(80, 38)
        Me.btnCancelar.TabIndex = 53
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(508, 383)
        Me.btnAgregar.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(80, 38)
        Me.btnAgregar.TabIndex = 52
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'txtDireccion
        '
        Me.txtDireccion.Location = New System.Drawing.Point(322, 338)
        Me.txtDireccion.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(243, 20)
        Me.txtDireccion.TabIndex = 51
        '
        'txtApellidoMaterno
        '
        Me.txtApellidoMaterno.Location = New System.Drawing.Point(17, 192)
        Me.txtApellidoMaterno.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtApellidoMaterno.Name = "txtApellidoMaterno"
        Me.txtApellidoMaterno.Size = New System.Drawing.Size(243, 20)
        Me.txtApellidoMaterno.TabIndex = 50
        '
        'txtDocumento
        '
        Me.txtDocumento.Location = New System.Drawing.Point(17, 292)
        Me.txtDocumento.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtDocumento.Name = "txtDocumento"
        Me.txtDocumento.Size = New System.Drawing.Size(243, 20)
        Me.txtDocumento.TabIndex = 49
        '
        'txtApellidoPaterno
        '
        Me.txtApellidoPaterno.Location = New System.Drawing.Point(17, 137)
        Me.txtApellidoPaterno.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtApellidoPaterno.Name = "txtApellidoPaterno"
        Me.txtApellidoPaterno.Size = New System.Drawing.Size(243, 20)
        Me.txtApellidoPaterno.TabIndex = 48
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(17, 89)
        Me.txtName.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(243, 20)
        Me.txtName.TabIndex = 47
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(318, 320)
        Me.Label13.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(67, 17)
        Me.Label13.TabIndex = 46
        Me.Label13.Text = "Dirección"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(318, 273)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(52, 17)
        Me.Label12.TabIndex = 45
        Me.Label12.Text = "Distrito"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(318, 220)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(66, 17)
        Me.Label11.TabIndex = 44
        Me.Label11.Text = "Provincia"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(318, 166)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(53, 17)
        Me.Label10.TabIndex = 43
        Me.Label10.Text = "Región"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(318, 119)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(35, 17)
        Me.Label9.TabIndex = 42
        Me.Label9.Text = "País"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(318, 69)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(64, 17)
        Me.Label8.TabIndex = 41
        Me.Label8.Text = "Empresa"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(18, 320)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(139, 17)
        Me.Label7.TabIndex = 40
        Me.Label7.Text = "Fecha de nacimiento"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(18, 273)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(100, 17)
        Me.Label6.TabIndex = 39
        Me.Label6.Text = "N° Documento"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(18, 220)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(112, 17)
        Me.Label5.TabIndex = 38
        Me.Label5.Text = "Tipo Documento"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(18, 166)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(111, 17)
        Me.Label4.TabIndex = 37
        Me.Label4.Text = "Apelido Materno"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(17, 119)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(112, 17)
        Me.Label3.TabIndex = 36
        Me.Label3.Text = "Apellido Paterno"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(15, 69)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 17)
        Me.Label2.TabIndex = 35
        Me.Label2.Text = "Nombre"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 15)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(211, 29)
        Me.Label1.TabIndex = 34
        Me.Label1.Text = "Editar Proveedor"
        '
        'FormEditarProveedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(600, 436)
        Me.Controls.Add(Me.cbxDistrito)
        Me.Controls.Add(Me.cbxProvincia)
        Me.Controls.Add(Me.cbxPais)
        Me.Controls.Add(Me.cbxRegion)
        Me.Controls.Add(Me.cbxEmpresa)
        Me.Controls.Add(Me.cbxTipoDocumento)
        Me.Controls.Add(Me.dtpNacimiento)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.txtDireccion)
        Me.Controls.Add(Me.txtApellidoMaterno)
        Me.Controls.Add(Me.txtDocumento)
        Me.Controls.Add(Me.txtApellidoPaterno)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "FormEditarProveedor"
        Me.Text = "FormEditarProveedor"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cbxDistrito As ComboBox
    Friend WithEvents cbxProvincia As ComboBox
    Friend WithEvents cbxPais As ComboBox
    Friend WithEvents cbxRegion As ComboBox
    Friend WithEvents cbxEmpresa As ComboBox
    Friend WithEvents cbxTipoDocumento As ComboBox
    Friend WithEvents dtpNacimiento As DateTimePicker
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnAgregar As Button
    Friend WithEvents txtDireccion As TextBox
    Friend WithEvents txtApellidoMaterno As TextBox
    Friend WithEvents txtDocumento As TextBox
    Friend WithEvents txtApellidoPaterno As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label

    Friend WithEvents cbxDistritoEditarProveedor As ComboBox

    Friend WithEvents cbxProvinciaEditarProveedor As ComboBox

    Friend WithEvents cbxPaisEditarProveedor As ComboBox

    Friend WithEvents cbxRegionEditarProveedor As ComboBox

    Friend WithEvents cbxEmpresaEditarProveedor As ComboBox

    Friend WithEvents cbxTipoDocumentoEditarProv As ComboBox

    Friend WithEvents dtpNacimientoEditarProveedor As DateTimePicker

    Friend WithEvents txtDireccionEditarProveedor As TextBox

    Friend WithEvents txtApellidoMaternoEditarProv As TextBox

    Friend WithEvents txtDocumentoEditarProveedor As TextBox
    Friend WithEvents txtNameEditarProveedor As TextBox
    Friend WithEvents txtApellidoPaternoEditarProv As TextBox
    Friend WithEvents btnAgregarEditarProveedor As Button
    Friend WithEvents btnCancelarEditarProveedor As Button
End Class
