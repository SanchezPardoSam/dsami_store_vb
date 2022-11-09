Imports DsamiStore.UsuarioDataSetTableAdapters
Imports Negocio

Public Class UsuarioReporteForm
    Private _usuarioNegocio As New UsuarioNegocio

    Private _consulta As String = ""
    Private _pagina As Integer = 1
    Private _limite As Integer = 5
    Private _totalPagina As Integer = 1
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

    Public Sub cargarDatos()
        Try
            tbPagina.Text = _pagina

            _totalPagina = _usuarioNegocio.ObtenerUsuariosCantidad(_consulta, _limite)

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


            Me.Sp_usuario_listarTableAdapter.Fill(Me.UsuarioDataSet.sp_usuario_listar, _consulta, _pagina, _limite)
            Me.ReportViewer1.RefreshReport()

        Catch ex As Exception
            MsgBox(ex.Message & " FORM Usuario")
        End Try
    End Sub


    Private Sub UsuarioReporteForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarDatos()
    End Sub


    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        _consulta = tbBuscar.Text
        cargarDatos()
    End Sub


    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbLimite.SelectedIndexChanged
        ' Obtener valor del combobox
        _limite = cbLimite.SelectedItem.Row.Item("valor")

        cargarDatos()
    End Sub

    Private Sub btnAnteriorClicked(sender As Object, e As EventArgs) Handles btnAnterior.Click
        _pagina -= 1

        cargarDatos()
    End Sub

    Private Sub btnSiguienteClicked(sender As Object, e As EventArgs) Handles btnSiguiente.Click
        _pagina += 1

        cargarDatos()
    End Sub

End Class