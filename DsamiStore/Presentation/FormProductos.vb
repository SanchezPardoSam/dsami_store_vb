Public Class FormProductos
    Private _productoNegocio As BLProducto = New BLProducto()
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

    Private Sub FormProducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Cargardatos()
    End Sub

    Public Sub Cargardatos()
        Try
            dgvProductos.Rows.Clear()

            tbPagina.Text = _pagina

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

            _totalPagina = _productoNegocio.ObtenerProductosCantidad(_consulta, _limite)

            Dim productos As List(Of Producto) = _productoNegocio.ObtenerProductos(_consulta, _pagina, _limite)

            Dim i As Integer = 1

            For x = 0 To productos.Count - 1 Step 1
                dgvProductos.Rows.Add(productos(x).Id, productos(x).Nombre, productos(x).Descripcion, productos(x).Precio, productos(x).Marca, productos(x).Categoria, productos(x).Almacen, productos(x).Moneda)
            Next


        Catch ex As Exception
            MsgBox(ex.Message & " FORM PRODUCTOS")
        End Try
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        FormInsertarProducto.Show()

    End Sub

    Private Sub ButtonDelete_Click(sender As Object, e As EventArgs) Handles ButtonDelete.Click
        Dim form As New FormEliminarProducto(Me)
        form.Show()
    End Sub

    Private Sub ButtonEdit_Click(sender As Object, e As EventArgs) Handles ButtonEdit.Click
        FormEditarProducto.Show()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click

    End Sub
End Class