Public Class frmInsertarProveedor
    Dim padre As FormProveedores
    Dim blProveedor As New BLProveedor
    Dim blEmpresa As New BLEmpresa

    Public Sub New(padre As FormProveedores)
        Me.padre = padre
        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub
    Private Sub frmInsertarProveedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim listaEmpresa = blEmpresa.ConsultarEmpresa()
        cbxEmpresa.Text = "Selecionar empresa"
        For x = 0 To listaEmpresa.Count - 1 Step 1
            cbxEmpresa.Items.Add(listaEmpresa(x).RazonSocial)
        Next
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Try


            Dim prov As New Proveedor(txtName.Text,
                                      txtApellidoPaterno.Text,
                                      txtApellidoMaterno.Text,
                                      cbxTipoDocumento.SelectedItem,
                                      txtDocumento.Text,
                                      dtpNacimiento.ToString(),
                                      cbxEmpresa.SelectedItem,
                                      cbxPais.SelectedItem,
                                      cbxRegion.SelectedItem,
                                      cbxProvincia.SelectedItem,
                                      cbxDistrito.SelectedItem,
                                      txtDireccion.Text)
            blProveedor.InsertarProveedor(prov)

            padre.Cargardatos()
            Me.Close()

            blProveedor.ConsultarProveedor()
        Catch ex As Exception
            MsgBox(ex.Message & "/insertar")
        End Try
    End Sub
End Class