Public Class FormEliminarProducto
    Private _productoNegocio As BLProducto = New BLProducto()

    Dim padre As FormProductos

    Public Sub New(padre As FormProductos)
        Me.padre = padre

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Dim nombre As String = padre.dgvProductos.CurrentRow.Cells.Item(1).Value
        txtNombreEliminarProducto.Text = nombre
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptarEliminarProducto.Click
        Try
            Dim codigo As String = padre.dgvProductos.CurrentRow.Cells.Item(0).Value

            _productoNegocio.EliminarProductos(codigo)

            padre.Cargardatos()

            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message & "/eliminar")
        End Try
    End Sub


    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelarEliminarProducto.Click
        Me.Close()
    End Sub
End Class