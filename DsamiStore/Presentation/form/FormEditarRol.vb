Public Class FormEditarRol
    Private _rolNegocio As BLRol = New BLRol()

    Dim padre As FormRoles

    Public Sub New(padre As FormRoles)
        Me.padre = padre

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        ' Cargar datos de tabla
        Dim nombre As String = padre.dgvRoles.CurrentRow.Cells.Item(1).Value
        txtNombreEditarRol.Text = nombre
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptarEditarRol.Click
        Try
            Dim codigo As String = padre.dgvRoles.CurrentRow.Cells.Item(0).Value

            _rolNegocio.ActualizarRol(codigo, txtNombreEditarRol.Text)

            padre.Cargardatos()

            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message & "/editar")
        End Try
    End Sub


    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelarEditarRol.Click
        Me.Close()
    End Sub
End Class