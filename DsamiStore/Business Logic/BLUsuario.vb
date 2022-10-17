Public Class BLUsuario
    Public Function ConsultarUsuarios() As List(Of Usuario)

        Try
            Dim dataUsuario As New Usuario

            Dim listaUsuarios As List(Of Usuario) = dataUsuario.ConsultarUsuario()

            Return listaUsuarios

        Catch ex As Exception
            MsgBox(ex.Message & " BLUSUARIO")
            Return Nothing
        End Try
    End Function
End Class
