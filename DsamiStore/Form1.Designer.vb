<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.lTitleLogin = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.tbClave = New System.Windows.Forms.TextBox()
        Me.tbNombreUsuario = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.panelPrincipalIncio = New System.Windows.Forms.Panel()
        Me.GroupBox1.SuspendLayout()
        Me.panelPrincipalIncio.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnLogin
        '
        Me.btnLogin.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.btnLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogin.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnLogin.Location = New System.Drawing.Point(126, 193)
        Me.btnLogin.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(82, 32)
        Me.btnLogin.TabIndex = 0
        Me.btnLogin.Text = "Acceder"
        Me.btnLogin.UseVisualStyleBackColor = False
        '
        'lTitleLogin
        '
        Me.lTitleLogin.AutoSize = True
        Me.lTitleLogin.Font = New System.Drawing.Font("Bookman Old Style", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lTitleLogin.ForeColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.lTitleLogin.Location = New System.Drawing.Point(9, 24)
        Me.lTitleLogin.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lTitleLogin.Name = "lTitleLogin"
        Me.lTitleLogin.Size = New System.Drawing.Size(235, 38)
        Me.lTitleLogin.TabIndex = 1
        Me.lTitleLogin.Text = "D'Sami Store"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(472, 512)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(107, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "© 2022 D'Sami Store"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.tbClave)
        Me.GroupBox1.Controls.Add(Me.tbNombreUsuario)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.btnLogin)
        Me.GroupBox1.Location = New System.Drawing.Point(349, 165)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(320, 244)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        '
        'tbClave
        '
        Me.tbClave.Location = New System.Drawing.Point(30, 152)
        Me.tbClave.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.tbClave.Name = "tbClave"
        Me.tbClave.Size = New System.Drawing.Size(230, 20)
        Me.tbClave.TabIndex = 5
        '
        'tbNombreUsuario
        '
        Me.tbNombreUsuario.Location = New System.Drawing.Point(28, 87)
        Me.tbNombreUsuario.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.tbNombreUsuario.Name = "tbNombreUsuario"
        Me.tbNombreUsuario.Size = New System.Drawing.Size(230, 20)
        Me.tbNombreUsuario.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(26, 122)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Clave"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(26, 55)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(143, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Nombre de usuario"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(79, 15)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(178, 26)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Inicio de sesión"
        '
        'panelPrincipalIncio
        '
        Me.panelPrincipalIncio.Controls.Add(Me.lTitleLogin)
        Me.panelPrincipalIncio.Controls.Add(Me.GroupBox1)
        Me.panelPrincipalIncio.Controls.Add(Me.Label2)
        Me.panelPrincipalIncio.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelPrincipalIncio.Location = New System.Drawing.Point(0, 0)
        Me.panelPrincipalIncio.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.panelPrincipalIncio.Name = "panelPrincipalIncio"
        Me.panelPrincipalIncio.Size = New System.Drawing.Size(1030, 580)
        Me.panelPrincipalIncio.TabIndex = 4
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1030, 580)
        Me.Controls.Add(Me.panelPrincipalIncio)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "Form1"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Text = "D´SamiStore"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.panelPrincipalIncio.ResumeLayout(False)
        Me.panelPrincipalIncio.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnLogin As Button
    Friend WithEvents lTitleLogin As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents tbClave As TextBox
    Friend WithEvents tbNombreUsuario As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents panelPrincipalIncio As Panel
End Class
