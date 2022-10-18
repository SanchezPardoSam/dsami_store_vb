Public Class FormInsertarCategorias
    Dim padre As FormCategoria

    Private _categoriaNegocio As New BLCategoria

    Public Sub New(padre As FormCategoria)
        Me.padre = padre

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub frmInsertarCategoria_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAceptarAgregarCategoria.Click
        Try
            _categoriaNegocio.InsertarCategoria("R001", txtNombreAgregarCategoria.Text, txtDescripcionInsertarCategoria.Text)

            padre.Cargardatos()

            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message & "/insertar")
        End Try
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelarAgregarCategoria.Click
        Me.Close()
    End Sub
End Class