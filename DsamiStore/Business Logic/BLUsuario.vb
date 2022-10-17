Public Class BLUsuario
    Public Function ConsultarUsuarios() As List(Of Usuario)

        Try
            Dim du As New Usuario

            Dim lu As List(Of Usuario) = du.ConsultarUsuario()

            Return lu

        Catch ex As Exception
            MsgBox(ex.Message & " BLUSUARIO")
            Return Nothing
        End Try
    End Function
End Class
