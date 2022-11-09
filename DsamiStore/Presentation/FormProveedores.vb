Imports Negocio

Public Class FormProveedores
    Private _proveedorNegocio As New ProveedorNegocio

    Private _consulta As String = ""
    Private _pagina As Integer = 1
    Private _totalPagina As Integer = 1
    Private _limite As Integer = 5
    Private _dtLimite As New DataTable()

    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

        ' Establecer columnas valor y texto a la tabla
        _dtLimite.Columns.Add("valor")
        _dtLimite.Columns.Add("texto")

        ' Agregar filas conn valor y texto
        _dtLimite.Rows.Add(5, "5 registros")
        _dtLimite.Rows.Add(10, "10 registros")
        _dtLimite.Rows.Add(25, "25 registros")
        _dtLimite.Rows.Add(50, "50 registros")

        ' Establecer tabla al combobox
        cbLimite.DataSource = _dtLimite

        ' Decirle que columna será el valor del combobox
        cbLimite.ValueMember = "valor"
        ' Decirle que columna será el texto del comobobox
        cbLimite.DisplayMember = "texto"

        cbLimite.SelectedIndex = 0

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        tbPagina.Text = _pagina
    End Sub

    Private Sub FormProveedores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Cargardatos()
    End Sub

    Public Sub Cargardatos()
        Try
            dgvProveedores.Rows.Clear()

            tbPagina.Text = _pagina

            _totalPagina = _proveedorNegocio.ObtenerProveedoresCantidad(_consulta, _limite)

            If _pagina = 1 Then
                btnAnterior.Enabled = False
            Else
                btnAnterior.Enabled = True
            End If

            If _pagina = _totalPagina Then
                btnSiguiente.Enabled = False
            Else
                btnSiguiente.Enabled = True
            End If


            Dim proveedores As List(Of Entidades.Proveedor) = _proveedorNegocio.ObtenerProveedores(_consulta, _pagina, _limite)

            Dim i As Integer = 1

            For x = 0 To proveedores.Count - 1 Step 1
                dgvProveedores.Rows.Add(proveedores(x).Id, proveedores(x).Nombre,
                                        proveedores(x).Documento, proveedores(x).Empresa, proveedores(x).Direccion)
            Next



        Catch ex As Exception
            MsgBox(ex.Message & " FORM ROLES")
        End Try
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbLimite.SelectedIndexChanged
        ' Obtener valor del combobox
        _limite = cbLimite.SelectedItem.Row.Item("valor")

        Cargardatos()
    End Sub

    Private Sub btnAnteriorClicked(sender As Object, e As EventArgs) Handles btnAnterior.Click
        _pagina -= 1

        Cargardatos()
    End Sub

    Private Sub btnSiguienteClicked(sender As Object, e As EventArgs) Handles btnSiguiente.Click
        _pagina += 1

        Cargardatos()
    End Sub

    Private Sub btnBuscarClicked(sender As Object, e As EventArgs) Handles btnBuscar.Click
        _consulta = tbBuscar.Text

        Cargardatos()
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Dim frmInsertarProveedor As New frmInsertarProveedor(Me)
        frmInsertarProveedor.Show()

    End Sub

    Private Sub dgvProveedores_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvProveedores.CellClick
        btnEditar.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(94, Byte), Integer))
        btnEliminar.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim form As New FormEliminarProveedor(Me)
        form.Show()
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        Dim form As New FormEditarProveedor(Me)
        form.Show()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub btnReporte_Click(sender As Object, e As EventArgs) Handles btnReporte.Click
        Dim form As New ProveedorReporteForm()
        form.Show()
    End Sub
End Class