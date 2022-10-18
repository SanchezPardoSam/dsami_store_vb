<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmInsertarProveedor
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtApellidoPaterno = New System.Windows.Forms.TextBox()
        Me.txtDocumento = New System.Windows.Forms.TextBox()
        Me.txtApellidoMaterno = New System.Windows.Forms.TextBox()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.dtpNacimiento = New System.Windows.Forms.DateTimePicker()
        Me.cbxTipoDocumento = New System.Windows.Forms.ComboBox()
        Me.cbxEmpresa = New System.Windows.Forms.ComboBox()
        Me.cbxRegion = New System.Windows.Forms.ComboBox()
        Me.cbxPais = New System.Windows.Forms.ComboBox()
        Me.cbxProvincia = New System.Windows.Forms.ComboBox()
        Me.cbxDistrito = New System.Windows.Forms.ComboBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(14, 19)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(146, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Agregar Proveedor"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(14, 6)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nombre"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(16, 55)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(112, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Apellido Paterno"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(17, 102)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(111, 17)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Apelido Materno"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(17, 157)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(112, 17)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Tipo Documento"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(17, 210)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(100, 17)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "N° Documento"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(17, 257)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(139, 17)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Fecha de nacimiento"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(317, 6)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(64, 17)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Empresa"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(317, 55)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(35, 17)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "País"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(317, 102)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(53, 17)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "Región"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(317, 157)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(66, 17)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "Provincia"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(317, 210)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(52, 17)
        Me.Label12.TabIndex = 11
        Me.Label12.Text = "Distrito"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(317, 257)
        Me.Label13.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(67, 17)
        Me.Label13.TabIndex = 12
        Me.Label13.Text = "Dirección"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(16, 26)
        Me.txtName.Margin = New System.Windows.Forms.Padding(2)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(243, 20)
        Me.txtName.TabIndex = 13
        '
        'txtApellidoPaterno
        '
        Me.txtApellidoPaterno.Location = New System.Drawing.Point(16, 74)
        Me.txtApellidoPaterno.Margin = New System.Windows.Forms.Padding(2)
        Me.txtApellidoPaterno.Name = "txtApellidoPaterno"
        Me.txtApellidoPaterno.Size = New System.Drawing.Size(243, 20)
        Me.txtApellidoPaterno.TabIndex = 14
        '
        'txtDocumento
        '
        Me.txtDocumento.Location = New System.Drawing.Point(16, 228)
        Me.txtDocumento.Margin = New System.Windows.Forms.Padding(2)
        Me.txtDocumento.Name = "txtDocumento"
        Me.txtDocumento.Size = New System.Drawing.Size(243, 20)
        Me.txtDocumento.TabIndex = 16
        '
        'txtApellidoMaterno
        '
        Me.txtApellidoMaterno.Location = New System.Drawing.Point(16, 128)
        Me.txtApellidoMaterno.Margin = New System.Windows.Forms.Padding(2)
        Me.txtApellidoMaterno.Name = "txtApellidoMaterno"
        Me.txtApellidoMaterno.Size = New System.Drawing.Size(243, 20)
        Me.txtApellidoMaterno.TabIndex = 18
        '
        'txtDireccion
        '
        Me.txtDireccion.Location = New System.Drawing.Point(321, 275)
        Me.txtDireccion.Margin = New System.Windows.Forms.Padding(2)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(243, 20)
        Me.txtDireccion.TabIndex = 20
        '
        'btnAgregar
        '
        Me.btnAgregar.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnAgregar.ForeColor = System.Drawing.Color.White
        Me.btnAgregar.Location = New System.Drawing.Point(479, 16)
        Me.btnAgregar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(87, 30)
        Me.btnAgregar.TabIndex = 25
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = False
        '
        'btnCancelar
        '
        Me.btnCancelar.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.btnCancelar.FlatAppearance.BorderSize = 0
        Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnCancelar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.btnCancelar.Location = New System.Drawing.Point(370, 16)
        Me.btnCancelar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(80, 30)
        Me.btnCancelar.TabIndex = 26
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'dtpNacimiento
        '
        Me.dtpNacimiento.Location = New System.Drawing.Point(16, 285)
        Me.dtpNacimiento.Margin = New System.Windows.Forms.Padding(2)
        Me.dtpNacimiento.Name = "dtpNacimiento"
        Me.dtpNacimiento.Size = New System.Drawing.Size(151, 20)
        Me.dtpNacimiento.TabIndex = 27
        '
        'cbxTipoDocumento
        '
        Me.cbxTipoDocumento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxTipoDocumento.FormattingEnabled = True
        Me.cbxTipoDocumento.Location = New System.Drawing.Point(16, 175)
        Me.cbxTipoDocumento.Margin = New System.Windows.Forms.Padding(2)
        Me.cbxTipoDocumento.Name = "cbxTipoDocumento"
        Me.cbxTipoDocumento.Size = New System.Drawing.Size(242, 21)
        Me.cbxTipoDocumento.TabIndex = 28
        '
        'cbxEmpresa
        '
        Me.cbxEmpresa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxEmpresa.FormattingEnabled = True
        Me.cbxEmpresa.Location = New System.Drawing.Point(321, 24)
        Me.cbxEmpresa.Margin = New System.Windows.Forms.Padding(2)
        Me.cbxEmpresa.Name = "cbxEmpresa"
        Me.cbxEmpresa.Size = New System.Drawing.Size(242, 21)
        Me.cbxEmpresa.TabIndex = 29
        '
        'cbxRegion
        '
        Me.cbxRegion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxRegion.FormattingEnabled = True
        Me.cbxRegion.Location = New System.Drawing.Point(321, 128)
        Me.cbxRegion.Margin = New System.Windows.Forms.Padding(2)
        Me.cbxRegion.Name = "cbxRegion"
        Me.cbxRegion.Size = New System.Drawing.Size(242, 21)
        Me.cbxRegion.TabIndex = 30
        '
        'cbxPais
        '
        Me.cbxPais.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxPais.FormattingEnabled = True
        Me.cbxPais.Location = New System.Drawing.Point(321, 72)
        Me.cbxPais.Margin = New System.Windows.Forms.Padding(2)
        Me.cbxPais.Name = "cbxPais"
        Me.cbxPais.Size = New System.Drawing.Size(242, 21)
        Me.cbxPais.TabIndex = 31
        '
        'cbxProvincia
        '
        Me.cbxProvincia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxProvincia.FormattingEnabled = True
        Me.cbxProvincia.Location = New System.Drawing.Point(321, 175)
        Me.cbxProvincia.Margin = New System.Windows.Forms.Padding(2)
        Me.cbxProvincia.Name = "cbxProvincia"
        Me.cbxProvincia.Size = New System.Drawing.Size(242, 21)
        Me.cbxProvincia.TabIndex = 32
        '
        'cbxDistrito
        '
        Me.cbxDistrito.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxDistrito.FormattingEnabled = True
        Me.cbxDistrito.Location = New System.Drawing.Point(321, 228)
        Me.cbxDistrito.Margin = New System.Windows.Forms.Padding(2)
        Me.cbxDistrito.Name = "cbxDistrito"
        Me.cbxDistrito.Size = New System.Drawing.Size(242, 21)
        Me.cbxDistrito.TabIndex = 33
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(593, 55)
        Me.Panel1.TabIndex = 34
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.btnAgregar)
        Me.Panel2.Controls.Add(Me.btnCancelar)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 381)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(593, 68)
        Me.Panel2.TabIndex = 35
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.cbxDistrito)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Controls.Add(Me.cbxProvincia)
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Controls.Add(Me.cbxPais)
        Me.Panel3.Controls.Add(Me.Label7)
        Me.Panel3.Controls.Add(Me.cbxRegion)
        Me.Panel3.Controls.Add(Me.Label8)
        Me.Panel3.Controls.Add(Me.cbxEmpresa)
        Me.Panel3.Controls.Add(Me.Label9)
        Me.Panel3.Controls.Add(Me.cbxTipoDocumento)
        Me.Panel3.Controls.Add(Me.Label10)
        Me.Panel3.Controls.Add(Me.dtpNacimiento)
        Me.Panel3.Controls.Add(Me.Label11)
        Me.Panel3.Controls.Add(Me.txtDireccion)
        Me.Panel3.Controls.Add(Me.Label12)
        Me.Panel3.Controls.Add(Me.txtApellidoMaterno)
        Me.Panel3.Controls.Add(Me.Label13)
        Me.Panel3.Controls.Add(Me.txtDocumento)
        Me.Panel3.Controls.Add(Me.txtName)
        Me.Panel3.Controls.Add(Me.txtApellidoPaterno)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 55)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(593, 326)
        Me.Panel3.TabIndex = 36
        '
        'frmInsertarProveedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(593, 449)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frmInsertarProveedor"
        Me.Text = "frmInsertarProveedor"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtApellidoPaterno As TextBox
    Friend WithEvents txtDocumento As TextBox
    Friend WithEvents txtApellidoMaterno As TextBox
    Friend WithEvents txtDireccion As TextBox
    Friend WithEvents btnAgregar As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents dtpNacimiento As DateTimePicker
    Friend WithEvents cbxTipoDocumento As ComboBox
    Friend WithEvents cbxEmpresa As ComboBox
    Friend WithEvents cbxRegion As ComboBox
    Friend WithEvents cbxPais As ComboBox
    Friend WithEvents cbxProvincia As ComboBox
    Friend WithEvents cbxDistrito As ComboBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
End Class
