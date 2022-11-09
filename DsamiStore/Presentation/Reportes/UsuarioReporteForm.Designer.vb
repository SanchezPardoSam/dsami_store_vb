<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UsuarioReporteForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.SpusuariolistarBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.UsuarioDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UsuarioDataSet = New DsamiStore.UsuarioDataSet()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.tbBuscar = New System.Windows.Forms.TextBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.SpusuariolistarBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.sp_usuario_listarBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Sp_usuario_listarTableAdapter = New DsamiStore.UsuarioDataSetTableAdapters.sp_usuario_listarTableAdapter()
        Me.UsuarioDataSetBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnSiguiente = New System.Windows.Forms.Button()
        Me.btnAnterior = New System.Windows.Forms.Button()
        Me.cbLimite = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbPagina = New System.Windows.Forms.TextBox()
        CType(Me.SpusuariolistarBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UsuarioDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UsuarioDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpusuariolistarBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sp_usuario_listarBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UsuarioDataSetBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SpusuariolistarBindingSource1
        '
        Me.SpusuariolistarBindingSource1.DataMember = "sp_usuario_listar"
        Me.SpusuariolistarBindingSource1.DataSource = Me.UsuarioDataSetBindingSource
        '
        'UsuarioDataSetBindingSource
        '
        Me.UsuarioDataSetBindingSource.DataSource = Me.UsuarioDataSet
        Me.UsuarioDataSetBindingSource.Position = 0
        '
        'UsuarioDataSet
        '
        Me.UsuarioDataSet.DataSetName = "UsuarioDataSet"
        Me.UsuarioDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "UsuarioDataSet"
        ReportDataSource1.Value = Me.SpusuariolistarBindingSource1
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "DsamiStore.UsuarioReporte.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(-3, 40)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(790, 482)
        Me.ReportViewer1.TabIndex = 0
        '
        'tbBuscar
        '
        Me.tbBuscar.Location = New System.Drawing.Point(342, 8)
        Me.tbBuscar.Margin = New System.Windows.Forms.Padding(2)
        Me.tbBuscar.Name = "tbBuscar"
        Me.tbBuscar.Size = New System.Drawing.Size(199, 20)
        Me.tbBuscar.TabIndex = 6
        '
        'btnBuscar
        '
        Me.btnBuscar.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscar.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscar.ForeColor = System.Drawing.Color.White
        Me.btnBuscar.Location = New System.Drawing.Point(685, 5)
        Me.btnBuscar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(87, 30)
        Me.btnBuscar.TabIndex = 5
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = False
        '
        'SpusuariolistarBindingSource
        '
        Me.SpusuariolistarBindingSource.DataMember = "sp_usuario_listar"
        Me.SpusuariolistarBindingSource.DataSource = Me.UsuarioDataSet
        '
        'sp_usuario_listarBindingSource
        '
        Me.sp_usuario_listarBindingSource.DataMember = "sp_usuario_listar"
        Me.sp_usuario_listarBindingSource.DataSource = Me.UsuarioDataSet
        '
        'Sp_usuario_listarTableAdapter
        '
        Me.Sp_usuario_listarTableAdapter.ClearBeforeFill = True
        '
        'UsuarioDataSetBindingSource1
        '
        Me.UsuarioDataSetBindingSource1.DataSource = Me.UsuarioDataSet
        Me.UsuarioDataSetBindingSource1.Position = 0
        '
        'btnSiguiente
        '
        Me.btnSiguiente.Location = New System.Drawing.Point(80, 10)
        Me.btnSiguiente.Name = "btnSiguiente"
        Me.btnSiguiente.Size = New System.Drawing.Size(21, 23)
        Me.btnSiguiente.TabIndex = 27
        Me.btnSiguiente.Text = ">"
        Me.btnSiguiente.UseVisualStyleBackColor = True
        '
        'btnAnterior
        '
        Me.btnAnterior.Location = New System.Drawing.Point(15, 11)
        Me.btnAnterior.Name = "btnAnterior"
        Me.btnAnterior.Size = New System.Drawing.Size(21, 23)
        Me.btnAnterior.TabIndex = 26
        Me.btnAnterior.Text = "<"
        Me.btnAnterior.UseVisualStyleBackColor = True
        '
        'cbLimite
        '
        Me.cbLimite.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbLimite.FormattingEnabled = True
        Me.cbLimite.Location = New System.Drawing.Point(170, 9)
        Me.cbLimite.Name = "cbLimite"
        Me.cbLimite.Size = New System.Drawing.Size(121, 21)
        Me.cbLimite.TabIndex = 24
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(128, 15)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(36, 13)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "Límite"
        '
        'tbPagina
        '
        Me.tbPagina.Enabled = False
        Me.tbPagina.Location = New System.Drawing.Point(42, 13)
        Me.tbPagina.Name = "tbPagina"
        Me.tbPagina.Size = New System.Drawing.Size(30, 20)
        Me.tbPagina.TabIndex = 23
        '
        'UsuarioReporteForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(783, 513)
        Me.Controls.Add(Me.btnSiguiente)
        Me.Controls.Add(Me.btnAnterior)
        Me.Controls.Add(Me.cbLimite)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.tbPagina)
        Me.Controls.Add(Me.tbBuscar)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "UsuarioReporteForm"
        Me.Text = "Reporte de Usuarios"
        CType(Me.SpusuariolistarBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UsuarioDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UsuarioDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpusuariolistarBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sp_usuario_listarBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UsuarioDataSetBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents UsuarioDataSetBindingSource As BindingSource
    Friend WithEvents UsuarioDataSet As UsuarioDataSet
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents sp_usuario_listarBindingSource As BindingSource
    Friend WithEvents SpusuariolistarBindingSource As BindingSource
    Friend WithEvents Sp_usuario_listarTableAdapter As UsuarioDataSetTableAdapters.sp_usuario_listarTableAdapter
    Friend WithEvents tbBuscar As TextBox
    Friend WithEvents btnBuscar As Button
    Friend WithEvents UsuarioDataSetBindingSource1 As BindingSource
    Friend WithEvents SpusuariolistarBindingSource1 As BindingSource
    Friend WithEvents btnSiguiente As Button
    Friend WithEvents btnAnterior As Button
    Friend WithEvents cbLimite As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents tbPagina As TextBox
End Class
