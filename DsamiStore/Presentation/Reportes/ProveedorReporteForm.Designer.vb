<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ProveedorReporteForm
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
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.ProveedorDataSet = New DsamiStore.ProveedorDataSet()
        Me.ProveedorDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SpproveedorlistarpaginacionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Sp_proveedor_listar_paginacionTableAdapter = New DsamiStore.ProveedorDataSetTableAdapters.sp_proveedor_listar_paginacionTableAdapter()
        Me.SpproveedorlistarpaginacionBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnSiguiente = New System.Windows.Forms.Button()
        Me.btnAnterior = New System.Windows.Forms.Button()
        Me.cbLimite = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbPagina = New System.Windows.Forms.TextBox()
        Me.tbBuscar = New System.Windows.Forms.TextBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        CType(Me.ProveedorDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProveedorDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpproveedorlistarpaginacionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpproveedorlistarpaginacionBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        ReportDataSource2.Name = "DataSet1"
        ReportDataSource2.Value = Me.SpproveedorlistarpaginacionBindingSource1
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "DsamiStore.ProveedorReporte.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(9, 50)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(1027, 388)
        Me.ReportViewer1.TabIndex = 0
        '
        'ProveedorDataSet
        '
        Me.ProveedorDataSet.DataSetName = "ProveedorDataSet"
        Me.ProveedorDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ProveedorDataSetBindingSource
        '
        Me.ProveedorDataSetBindingSource.DataSource = Me.ProveedorDataSet
        Me.ProveedorDataSetBindingSource.Position = 0
        '
        'SpproveedorlistarpaginacionBindingSource
        '
        Me.SpproveedorlistarpaginacionBindingSource.DataMember = "sp_proveedor_listar_paginacion"
        Me.SpproveedorlistarpaginacionBindingSource.DataSource = Me.ProveedorDataSet
        '
        'Sp_proveedor_listar_paginacionTableAdapter
        '
        Me.Sp_proveedor_listar_paginacionTableAdapter.ClearBeforeFill = True
        '
        'SpproveedorlistarpaginacionBindingSource1
        '
        Me.SpproveedorlistarpaginacionBindingSource1.DataMember = "sp_proveedor_listar_paginacion"
        Me.SpproveedorlistarpaginacionBindingSource1.DataSource = Me.ProveedorDataSetBindingSource
        '
        'btnSiguiente
        '
        Me.btnSiguiente.Location = New System.Drawing.Point(96, 13)
        Me.btnSiguiente.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSiguiente.Name = "btnSiguiente"
        Me.btnSiguiente.Size = New System.Drawing.Size(28, 28)
        Me.btnSiguiente.TabIndex = 34
        Me.btnSiguiente.Text = ">"
        Me.btnSiguiente.UseVisualStyleBackColor = True
        '
        'btnAnterior
        '
        Me.btnAnterior.Location = New System.Drawing.Point(9, 15)
        Me.btnAnterior.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAnterior.Name = "btnAnterior"
        Me.btnAnterior.Size = New System.Drawing.Size(28, 28)
        Me.btnAnterior.TabIndex = 33
        Me.btnAnterior.Text = "<"
        Me.btnAnterior.UseVisualStyleBackColor = True
        '
        'cbLimite
        '
        Me.cbLimite.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbLimite.FormattingEnabled = True
        Me.cbLimite.Location = New System.Drawing.Point(216, 12)
        Me.cbLimite.Margin = New System.Windows.Forms.Padding(4)
        Me.cbLimite.Name = "cbLimite"
        Me.cbLimite.Size = New System.Drawing.Size(160, 24)
        Me.cbLimite.TabIndex = 31
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(160, 19)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 16)
        Me.Label3.TabIndex = 32
        Me.Label3.Text = "Límite"
        '
        'tbPagina
        '
        Me.tbPagina.Enabled = False
        Me.tbPagina.Location = New System.Drawing.Point(45, 17)
        Me.tbPagina.Margin = New System.Windows.Forms.Padding(4)
        Me.tbPagina.Name = "tbPagina"
        Me.tbPagina.Size = New System.Drawing.Size(39, 22)
        Me.tbPagina.TabIndex = 30
        '
        'tbBuscar
        '
        Me.tbBuscar.Location = New System.Drawing.Point(445, 11)
        Me.tbBuscar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tbBuscar.Name = "tbBuscar"
        Me.tbBuscar.Size = New System.Drawing.Size(264, 22)
        Me.tbBuscar.TabIndex = 29
        '
        'btnBuscar
        '
        Me.btnBuscar.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscar.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscar.ForeColor = System.Drawing.Color.White
        Me.btnBuscar.Location = New System.Drawing.Point(902, 7)
        Me.btnBuscar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(116, 37)
        Me.btnBuscar.TabIndex = 28
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = False
        '
        'ProveedorReporteForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1048, 450)
        Me.Controls.Add(Me.btnSiguiente)
        Me.Controls.Add(Me.btnAnterior)
        Me.Controls.Add(Me.cbLimite)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.tbPagina)
        Me.Controls.Add(Me.tbBuscar)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "ProveedorReporteForm"
        Me.Text = "ProveedorReporteForm"
        CType(Me.ProveedorDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProveedorDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpproveedorlistarpaginacionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpproveedorlistarpaginacionBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents SpproveedorlistarpaginacionBindingSource As BindingSource
    Friend WithEvents ProveedorDataSet As ProveedorDataSet
    Friend WithEvents ProveedorDataSetBindingSource As BindingSource
    Friend WithEvents Sp_proveedor_listar_paginacionTableAdapter As ProveedorDataSetTableAdapters.sp_proveedor_listar_paginacionTableAdapter
    Friend WithEvents SpproveedorlistarpaginacionBindingSource1 As BindingSource
    Friend WithEvents btnSiguiente As Button
    Friend WithEvents btnAnterior As Button
    Friend WithEvents cbLimite As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents tbPagina As TextBox
    Friend WithEvents tbBuscar As TextBox
    Friend WithEvents btnBuscar As Button
End Class
