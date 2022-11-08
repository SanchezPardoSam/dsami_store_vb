Imports Negocio

Public Class FormEliminarUsuarios
    Private _usuarioNegocio As New UsuarioNegocio

    Dim padre As FormUsuarios

    Public Sub New(padre As FormUsuarios)
        Me.padre = padre

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Dim nombre As String = padre.dgvUsuarios.CurrentRow.Cells.Item(1).Value
        txtNombreEliminarUsuario.Text = nombre
    End Sub

    Public Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptarEliminarUsuarios.Click
        Try
            Dim codigo As String = padre.dgvUsuarios.CurrentRow.Cells.Item(0).Value

            _usuarioNegocio.EliminarUsuario(codigo)

            padre.Cargardatos()

            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message & "/eliminar")
        End Try
    End Sub


    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelarEliminarUsuario.Click
        Me.Close()
    End Sub
End Class