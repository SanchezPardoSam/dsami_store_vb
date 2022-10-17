Public Class BLUsuario
    Private _usuarioDato As Usuario = New Usuario()
    Private _encrypt As Encrypt = New Encrypt()

    Public Function ConsultarUsuarios() As List(Of Usuario)
        Try

            Dim usuarios As List(Of Usuario) = _usuarioDato.ConsultarUsuario()

            Return usuarios


        Catch ex As Exception
            MsgBox(ex.Message & " BLUSUARIO")
            Return Nothing
        End Try
    End Function

    Public Function ObtenerUsuariosCantidad(consulta As String, limite As Integer) As Integer
        Try
            Dim cantidad As Integer = _usuarioDato.EncontrarUsuariosCantidad(consulta, limite)

            Return cantidad
        Catch ex As Exception
            MsgBox(ex.Message & " BLUSUARIO")
            Return Nothing
        End Try
    End Function

    Public Function ObtenerUsuarios(consulta As String, pagina As Integer, limite As Integer) As List(Of Usuario)
        Try
            Dim usuarios As List(Of Usuario) = _usuarioDato.EncontrarUsuarios(consulta, pagina, limite)

            Return usuarios
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
