<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormEditarEmpleado
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
        Me.btnAgregaEditarEmpl = New System.Windows.Forms.Button()
        Me.btnCancelarEditarEmpl = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cbxDistritoEditarEmpl = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cbxProvinciaEditarEmpl = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cbxPaisEditarEmpl = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cbxRegionEditarEmpl = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cbxTipoDocumentoEditarEmpl = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.dtpNacimientoEditarEmpl = New System.Windows.Forms.DateTimePicker()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtDireccionEditarEmpl = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtApellidoMaternoEditarEmpl = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtDocumentoEditarEmpl = New System.Windows.Forms.TextBox()
        Me.txtNameEditarEmpleado = New System.Windows.Forms.TextBox()
        Me.txtApellidoPaternoEditarEmpl = New System.Windows.Forms.TextBox()
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
        Me.Panel1.Size = New System.Drawing.Size(593, 64)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(25, 24)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(127, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Editar Empleado"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.btnAgregaEditarEmpl)
        Me.Panel2.Controls.Add(Me.btnCancelarEditarEmpl)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 388)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(593, 61)
        Me.Panel2.TabIndex = 1
        '
        'btnAgregaEditarEmpl
        '
        Me.btnAgregaEditarEmpl.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.btnAgregaEditarEmpl.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregaEditarEmpl.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnAgregaEditarEmpl.ForeColor = System.Drawing.Color.White
        Me.btnAgregaEditarEmpl.Location = New System.Drawing.Point(478, 20)
        Me.btnAgregaEditarEmpl.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAgregaEditarEmpl.Name = "btnAgregaEditarEmpl"
        Me.btnAgregaEditarEmpl.Size = New System.Drawing.Size(87, 30)
        Me.btnAgregaEditarEmpl.TabIndex = 29
        Me.btnAgregaEditarEmpl.Text = "Agregar"
        Me.btnAgregaEditarEmpl.UseVisualStyleBackColor = False
        '
        'btnCancelarEditarEmpl
        '
        Me.btnCancelarEditarEmpl.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.btnCancelarEditarEmpl.FlatAppearance.BorderSize = 0
        Me.btnCancelarEditarEmpl.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelarEditarEmpl.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnCancelarEditarEmpl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.btnCancelarEditarEmpl.Location = New System.Drawing.Point(369, 20)
        Me.btnCancelarEditarEmpl.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCancelarEditarEmpl.Name = "btnCancelarEditarEmpl"
        Me.btnCancelarEditarEmpl.Size = New System.Drawing.Size(80, 30)
        Me.btnCancelarEditarEmpl.TabIndex = 30
        Me.btnCancelarEditarEmpl.Text = "Cancelar"
        Me.btnCancelarEditarEmpl.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.cbxDistritoEditarEmpl)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Controls.Add(Me.cbxProvinciaEditarEmpl)
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Controls.Add(Me.cbxPaisEditarEmpl)
        Me.Panel3.Controls.Add(Me.Label7)
        Me.Panel3.Controls.Add(Me.cbxRegionEditarEmpl)
        Me.Panel3.Controls.Add(Me.Label9)
        Me.Panel3.Controls.Add(Me.cbxTipoDocumentoEditarEmpl)
        Me.Panel3.Controls.Add(Me.Label10)
        Me.Panel3.Controls.Add(Me.dtpNacimientoEditarEmpl)
        Me.Panel3.Controls.Add(Me.Label11)
        Me.Panel3.Controls.Add(Me.txtDireccionEditarEmpl)
        Me.Panel3.Controls.Add(Me.Label12)
        Me.Panel3.Controls.Add(Me.txtApellidoMaternoEditarEmpl)
        Me.Panel3.Controls.Add(Me.Label13)
        Me.Panel3.Controls.Add(Me.txtDocumentoEditarEmpl)
        Me.Panel3.Controls.Add(Me.txtNameEditarEmpleado)
        Me.Panel3.Controls.Add(Me.txtApellidoPaternoEditarEmpl)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 64)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(593, 324)
        Me.Panel3.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(26, 13)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 17)
        Me.Label2.TabIndex = 58
        Me.Label2.Text = "Nombre"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(28, 62)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(112, 17)
        Me.Label3.TabIndex = 59
        Me.Label3.Text = "Apellido Paterno"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(29, 109)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(111, 17)
        Me.Label4.TabIndex = 60
        Me.Label4.Text = "Apelido Materno"
        '
        'cbxDistritoEditarEmpl
        '
        Me.cbxDistritoEditarEmpl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxDistritoEditarEmpl.FormattingEnabled = True
        Me.cbxDistritoEditarEmpl.Location = New System.Drawing.Point(324, 186)
        Me.cbxDistritoEditarEmpl.Margin = New System.Windows.Forms.Padding(2)
        Me.cbxDistritoEditarEmpl.Name = "cbxDistritoEditarEmpl"
        Me.cbxDistritoEditarEmpl.Size = New System.Drawing.Size(242, 21)
        Me.cbxDistritoEditarEmpl.TabIndex = 79
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(29, 164)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(112, 17)
        Me.Label5.TabIndex = 61
        Me.Label5.Text = "Tipo Documento"
        '
        'cbxProvinciaEditarEmpl
        '
        Me.cbxProvinciaEditarEmpl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxProvinciaEditarEmpl.FormattingEnabled = True
        Me.cbxProvinciaEditarEmpl.Location = New System.Drawing.Point(324, 133)
        Me.cbxProvinciaEditarEmpl.Margin = New System.Windows.Forms.Padding(2)
        Me.cbxProvinciaEditarEmpl.Name = "cbxProvinciaEditarEmpl"
        Me.cbxProvinciaEditarEmpl.Size = New System.Drawing.Size(242, 21)
        Me.cbxProvinciaEditarEmpl.TabIndex = 78
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(29, 217)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(100, 17)
        Me.Label6.TabIndex = 62
        Me.Label6.Text = "N° Documento"
        '
        'cbxPaisEditarEmpl
        '
        Me.cbxPaisEditarEmpl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxPaisEditarEmpl.FormattingEnabled = True
        Me.cbxPaisEditarEmpl.Location = New System.Drawing.Point(324, 30)
        Me.cbxPaisEditarEmpl.Margin = New System.Windows.Forms.Padding(2)
        Me.cbxPaisEditarEmpl.Name = "cbxPaisEditarEmpl"
        Me.cbxPaisEditarEmpl.Size = New System.Drawing.Size(242, 21)
        Me.cbxPaisEditarEmpl.TabIndex = 77
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(29, 264)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(139, 17)
        Me.Label7.TabIndex = 63
        Me.Label7.Text = "Fecha de nacimiento"
        '
        'cbxRegionEditarEmpl
        '
        Me.cbxRegionEditarEmpl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxRegionEditarEmpl.FormattingEnabled = True
        Me.cbxRegionEditarEmpl.Location = New System.Drawing.Point(323, 81)
        Me.cbxRegionEditarEmpl.Margin = New System.Windows.Forms.Padding(2)
        Me.cbxRegionEditarEmpl.Name = "cbxRegionEditarEmpl"
        Me.cbxRegionEditarEmpl.Size = New System.Drawing.Size(242, 21)
        Me.cbxRegionEditarEmpl.TabIndex = 76
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(321, 13)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(35, 17)
        Me.Label9.TabIndex = 64
        Me.Label9.Text = "País"
        '
        'cbxTipoDocumentoEditarEmpl
        '
        Me.cbxTipoDocumentoEditarEmpl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxTipoDocumentoEditarEmpl.FormattingEnabled = True
        Me.cbxTipoDocumentoEditarEmpl.Location = New System.Drawing.Point(28, 182)
        Me.cbxTipoDocumentoEditarEmpl.Margin = New System.Windows.Forms.Padding(2)
        Me.cbxTipoDocumentoEditarEmpl.Name = "cbxTipoDocumentoEditarEmpl"
        Me.cbxTipoDocumentoEditarEmpl.Size = New System.Drawing.Size(242, 21)
        Me.cbxTipoDocumentoEditarEmpl.TabIndex = 75
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(320, 60)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(53, 17)
        Me.Label10.TabIndex = 65
        Me.Label10.Text = "Región"
        '
        'dtpNacimientoEditarEmpl
        '
        Me.dtpNacimientoEditarEmpl.Location = New System.Drawing.Point(28, 292)
        Me.dtpNacimientoEditarEmpl.Margin = New System.Windows.Forms.Padding(2)
        Me.dtpNacimientoEditarEmpl.Name = "dtpNacimientoEditarEmpl"
        Me.dtpNacimientoEditarEmpl.Size = New System.Drawing.Size(242, 20)
        Me.dtpNacimientoEditarEmpl.TabIndex = 74
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(320, 115)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(66, 17)
        Me.Label11.TabIndex = 66
        Me.Label11.Text = "Provincia"
        '
        'txtDireccionEditarEmpl
        '
        Me.txtDireccionEditarEmpl.Location = New System.Drawing.Point(324, 235)
        Me.txtDireccionEditarEmpl.Margin = New System.Windows.Forms.Padding(2)
        Me.txtDireccionEditarEmpl.Name = "txtDireccionEditarEmpl"
        Me.txtDireccionEditarEmpl.Size = New System.Drawing.Size(243, 20)
        Me.txtDireccionEditarEmpl.TabIndex = 73
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(320, 168)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(52, 17)
        Me.Label12.TabIndex = 67
        Me.Label12.Text = "Distrito"
        '
        'txtApellidoMaternoEditarEmpl
        '
        Me.txtApellidoMaternoEditarEmpl.Location = New System.Drawing.Point(28, 135)
        Me.txtApellidoMaternoEditarEmpl.Margin = New System.Windows.Forms.Padding(2)
        Me.txtApellidoMaternoEditarEmpl.Name = "txtApellidoMaternoEditarEmpl"
        Me.txtApellidoMaternoEditarEmpl.Size = New System.Drawing.Size(243, 20)
        Me.txtApellidoMaternoEditarEmpl.TabIndex = 72
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(320, 215)
        Me.Label13.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(67, 17)
        Me.Label13.TabIndex = 68
        Me.Label13.Text = "Dirección"
        '
        'txtDocumentoEditarEmpl
        '
        Me.txtDocumentoEditarEmpl.Location = New System.Drawing.Point(28, 235)
        Me.txtDocumentoEditarEmpl.Margin = New System.Windows.Forms.Padding(2)
        Me.txtDocumentoEditarEmpl.Name = "txtDocumentoEditarEmpl"
        Me.txtDocumentoEditarEmpl.Size = New System.Drawing.Size(243, 20)
        Me.txtDocumentoEditarEmpl.TabIndex = 71
        '
        'txtNameEditarEmpleado
        '
        Me.txtNameEditarEmpleado.Location = New System.Drawing.Point(28, 33)
        Me.txtNameEditarEmpleado.Margin = New System.Windows.Forms.Padding(2)
        Me.txtNameEditarEmpleado.Name = "txtNameEditarEmpleado"
        Me.txtNameEditarEmpleado.Size = New System.Drawing.Size(243, 20)
        Me.txtNameEditarEmpleado.TabIndex = 69
        '
        'txtApellidoPaternoEditarEmpl
        '
        Me.txtApellidoPaternoEditarEmpl.Location = New System.Drawing.Point(28, 81)
        Me.txtApellidoPaternoEditarEmpl.Margin = New System.Windows.Forms.Padding(2)
        Me.txtApellidoPaternoEditarEmpl.Name = "txtApellidoPaternoEditarEmpl"
        Me.txtApellidoPaternoEditarEmpl.Size = New System.Drawing.Size(243, 20)
        Me.txtApellidoPaternoEditarEmpl.TabIndex = 70
        '
        'FormEditarEmpleado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(593, 449)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FormEditarEmpleado"
        Me.Text = "FormEditarEmpleado"
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
    Friend WithEvents cbxDistritoEditarEmpl As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents cbxProvinciaEditarEmpl As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents cbxPaisEditarEmpl As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents cbxRegionEditarEmpl As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents cbxTipoDocumentoEditarEmpl As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents dtpNacimientoEditarEmpl As DateTimePicker
    Friend WithEvents Label11 As Label
    Friend WithEvents txtDireccionEditarEmpl As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txtApellidoMaternoEditarEmpl As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents txtDocumentoEditarEmpl As TextBox
    Friend WithEvents txtNameEditarEmpleado As TextBox
    Friend WithEvents txtApellidoPaternoEditarEmpl As TextBox
    Friend WithEvents btnAgregaEditarEmpl As Button
    Friend WithEvents btnCancelarEditarEmpl As Button
End Class
