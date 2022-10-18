Public Class FormEditarProveedor
    Private _proveedorNegocio As BLProveedor = New BLProveedor()
    Private _documentoNegocio As BLDocumento = New BLDocumento()
    Private _empresaNegocio As BLEmpresa = New BLEmpresa()

    Private _prov As Proveedor
    Dim padre As FormProveedores

    Dim _dtProveedor As New DataTable
    Dim _dtEmpresa As New DataTable
    Public Sub New(padre As FormProveedores)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        _dtProveedor.Columns.Add("valor")
        _dtProveedor.Columns.Add("texto")

        cbxTipoDocumento.DataSource = _dtProveedor

        ' Decirle que columna será el valor del combobox
        cbxTipoDocumento.ValueMember = "valor"
        ' Decirle que columna será el texto del comobobox
        cbxTipoDocumento.DisplayMember = "texto"

        _dtEmpresa.Columns.Add("valor")
        _dtEmpresa.Columns.Add("texto")

        cbxEmpresa.DataSource = _dtEmpresa

        ' Decirle que columna será el valor del combobox
        cbxEmpresa.ValueMember = "valor"
        ' Decirle que columna será el texto del comobobox
        cbxEmpresa.DisplayMember = "texto"


        Me.padre = padre
        _prov = _proveedorNegocio.ConsultarProveedorID(padre.dgvProveedores.CurrentRow.Cells.Item(0).Value)
    End Sub

    Private Sub FormEditarProveedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtName.Text = _prov.Nombre
        txtApellidoPaterno.Text = _prov.ApellidoPaterno
        txtApellidoMaterno.Text = _prov.ApellidoMaterno

        txtDocumento.Text = _prov.Documento
        txtDireccion.Text = _prov.Direccion

        Dim documentos = _documentoNegocio.ConsultarDocumentos()

        For x = 0 To documentos.Count - 1 Step 1
            _dtProveedor.Rows.Add(documentos(x).Id, documentos(x).Nombre)
            If documentos(x).Id = _prov.Id Then
                cbxTipoDocumento.SelectedIndex = x
            End If
        Next

        Dim empresas = _empresaNegocio.ConsultarEmpresa()

        For x = 0 To empresas.Count - 1 Step 1
            _dtProveedor.Rows.Add(empresas(x).Id, empresas(x).RazonSocial)
            If empresas(x).RazonSocial = _prov.Empresa Then
                cbxEmpresa.SelectedIndex = x
            End If
        Next

    End Sub
End Class