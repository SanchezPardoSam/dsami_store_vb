Public Class FormEliminarCategorias
    Private _categoriaNegocio As BLCategoria = New BLCategoria()

    Dim padre As FormCategoria

    Public Sub New(padre As FormCategoria)
        Me.padre = padre

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Dim nombre As String = padre.dgvCategorias.CurrentRow.Cells.Item(1).Value
        txtNombreEliminarCategoria.Text = nombre
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptarEliminarCategoria.Click
        Try
            Dim codigo As String = padre.dgvCategorias.CurrentRow.Cells.Item(0).Value

            _categoriaNegocio.EliminarCategoria(codigo)

            padre.Cargardatos()

            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message & "/eliminar")
        End Try
    End Sub


    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelarEliminarCategoria.Click
        Me.Close()
    End Sub
End Class