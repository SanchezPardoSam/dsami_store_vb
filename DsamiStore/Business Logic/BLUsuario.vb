Public Class BLUsuario
    Private _usuarioDato As Usuario = New Usuario()
    Private _encrypt As Encrypt = New Encrypt()

    Public Function ConsultarUsuarios() As List(Of Usuario)
        Try
<<<<<<< HEAD
            Dim dataUsuario As New Usuario

            Dim listaUsuarios As List(Of Usuario) = dataUsuario.ConsultarUsuario()

            Return listaUsuarios
=======
            Dim usuarios As List(Of Usuario) = _usuarioDato.ConsultarUsuario()

            Return usuarios
>>>>>>> 9f878442952440d451b6daf26aa8fdc0e682088b

        Catch ex As Exception
            MsgBox(ex.Message & " BLUSUARIO")
            Return Nothing
        End Try
    End Function

    Public Function Ingresar(nombreUsuario As String, clave As String)
        Dim usuario As Usuario = _usuarioDato.EncontrarPorNombreUsuario(nombreUsuario)

        If usuario Is Nothing Then
            Throw New Exception("Usuario no existe")
        End If

        If 0 = _encrypt.verify(clave, usuario.Clave_Usuario) Then
            Throw New Exception("Clave incorrecta")
        End If

        Return usuario
    End Function
End Class
