Public Class FormUsuarios
    Private Sub FormUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Cargardatos()
    End Sub
    Public Sub Cargardatos()
        Try
            dgvUsuarios.Rows.Clear()
            Dim blUsuario As New BLUsuario
            Dim listUsuario As List(Of Usuario) = blUsuario.ConsultarUsuarios()
            Dim i As Integer = 1

            For x = 0 To listUsuario.Count - 1 Step 1
                dgvUsuarios.Rows.Add((x + 1).ToString(), listUsuario(x).NombreEmpleado, listUsuario(x).Nombre_Usuario, listUsuario(x).NombreRol)
            Next


        Catch ex As Exception
            MsgBox(ex.Message & " FORM Usuario")
        End Try
    End Sub
End Class