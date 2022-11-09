Imports Negocio

Public Class FormEditarCategoria
    Private _categoriaNegocio As New CategoriaNegocio

    Dim padre As FormCategoria

    Public Sub New(padre As FormCategoria)
        Me.padre = padre

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        ' Cargar datos de tabla
        Dim nombre As String = padre.dgvCategorias.CurrentRow.Cells.Item(1).Value
        txtNombreEditarCategoria.Text = nombre

        Dim descripcion As String = padre.dgvCategorias.CurrentRow.Cells.Item(2).Value
        txtDescripcionEditarCategoria.Text = descripcion
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptarEditarCategoria.Click
        Try
            Dim codigo As String = padre.dgvCategorias.CurrentRow.Cells.Item(0).Value

            _categoriaNegocio.ActualizarCategoria(codigo, txtNombreEditarCategoria.Text, txtDescripcionEditarCategoria.Text)

            padre.Cargardatos()

            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message & "/editar")
        End Try
    End Sub


    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelarEditarCategoria.Click
        Me.Close()
    End Sub
End Class