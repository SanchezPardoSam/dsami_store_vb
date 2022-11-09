Imports Negocio

Public Class FormEliminarProveedor
    Private _proveedorNegocio As New ProveedorNegocio

    Dim padre As FormProveedores

    Public Sub New(padre As FormProveedores)
        Me.padre = padre
        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Dim nombre As String = padre.dgvProveedores.CurrentRow.Cells.Item(1).Value
        txtNombreEliminarProveedor.Text = nombre
    End Sub

    Private Sub btnCancelarEliminarProveedor_Click(sender As Object, e As EventArgs) Handles btnCancelarEliminarProveedor.Click
        Me.Close()
    End Sub

    Private Sub btnAceptarEliminarProveedor_Click(sender As Object, e As EventArgs) Handles btnAceptarEliminarProveedor.Click
        Try
            Dim codigo As String = padre.dgvProveedores.CurrentRow.Cells.Item(0).Value
            _proveedorNegocio.EliminarProveedor(codigo)

            padre.Cargardatos()

            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message & "/eliminar")
        End Try
    End Sub

    Private Sub FormEliminarProveedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class