Public Class FormEliminarRol
    Private _rolNegocio As BLRol = New BLRol()

    Dim padre As FormRoles

    Public Sub New(padre As FormRoles)
        Me.padre = padre

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Dim nombre As String = padre.dgvRoles.CurrentRow.Cells.Item(1).Value
        txtNombreEliminarRol.Text = nombre
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptarEliminarRol.Click
        Try
            Dim codigo As String = padre.dgvRoles.CurrentRow.Cells.Item(0).Value
            MsgBox(codigo)
            _rolNegocio.EliminarRol(codigo)

            padre.Cargardatos()

            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message & "/eliminar")
        End Try
    End Sub


    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelarEliminarRol.Click
        Me.Close()
    End Sub

    Private Sub FormEliminarRol_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class