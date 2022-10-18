Public Class BLUsuario
    Private _usuarioDato As Usuario = New Usuario()
    Private _encrypt As Encrypt = New Encrypt()

    Public Function InsertarUsuario(codigo As String, nombreUsuario As String, clave As String, codigoEmpleado As String, codigoRol As String)
        Dim usuarioEncontrado As Usuario = _usuarioDato.EncontrarPorNombreUsuario(nombreUsuario)

        If usuarioEncontrado IsNot Nothing Then
            Throw New Exception("Nombre de usuario ya existe")
        End If

        clave = _encrypt.generate(clave)

        Dim usuario As New Usuario(codigo, nombreUsuario, clave, codigoEmpleado, "", "", codigoRol, "")

        If _usuarioDato.InsertarUsuario(usuario) = True Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Sub ActualizarUsuario(codigo As String, nombreUsuario As String, clave As String, codigoRol As String)
        Dim usuario As Usuario = _usuarioDato.EncontrarUsuarioPorCodigo(codigo)

        If usuario Is Nothing Then
            Throw New Exception("Usuario no existe")
        End If

        If usuario.Nombre_Usuario = nombreUsuario Then
        Else
            Dim usuarioEncontrado As Usuario = _usuarioDato.EncontrarPorNombreUsuario(nombreUsuario)

            If usuarioEncontrado IsNot Nothing Then
                Throw New Exception("Nombre de usuario ya existe")
            End If
        End If

        usuario.Nombre_Usuario = nombreUsuario

        If clave = "" Then
        Else
            usuario.Clave_Usuario = _encrypt.generate(clave)
        End If

        usuario.Codigo_Rol = codigoRol

        _usuarioDato.ActualizarUsuario(usuario)
    End Sub

    Public Function EliminarUsuario(codigo As String)
        If _usuarioDato.EliminarUsuario(codigo) = True Then
            Return True
        Else
            Return False
        End If
    End Function

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

    Public Function ObtenerUsuario(codigo As String) As Usuario
        Try
            Dim usuario As Usuario = _usuarioDato.EncontrarUsuarioPorCodigo(codigo)

            Return usuario
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
