Imports System.Data.SqlClient
Imports Entidades

Public Class UsuarioDato
    Inherits Conexion

    Private cmd As SqlCommand
    Private dr As SqlDataReader

    Public Function InsertarUsuario(usuario As Usuario)
        Try
            conectar()
            Console.WriteLine(usuario.Codigo_Empleado)
            Console.WriteLine(usuario.Codigo_Rol)
            Dim sql As String = "sp_usuario_agregar @nombreUsuario, @clave, @codigoEmpleado, @codigoRol"
            cmd = New SqlCommand(sql, con)
            cmd.Parameters.AddWithValue("@nombreUsuario", usuario.Nombre_Usuario)
            cmd.Parameters.AddWithValue("@clave", usuario.Clave_Usuario)
            cmd.Parameters.AddWithValue("@codigoEmpleado", usuario.Codigo_Empleado)
            cmd.Parameters.AddWithValue("@codigoRol", usuario.Codigo_Rol)

            If cmd.ExecuteNonQuery() Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            MsgBox(ex.Message & "/categoria")
        Finally
            desconectar()
        End Try
    End Function

    Public Function ActualizarUsuario(usuario As Usuario)
        Try
            conectar()

            Dim sql As String = "sp_usuario_actualizar @codigo, @nombreUsuario, @clave, @codigoRol"
            cmd = New SqlCommand(sql, con)
            cmd.Parameters.AddWithValue("@codigo", usuario.Codigo_Usuario)
            cmd.Parameters.AddWithValue("@nombreUsuario", usuario.Nombre_Usuario)
            cmd.Parameters.AddWithValue("@clave", usuario.Clave_Usuario)
            cmd.Parameters.AddWithValue("@codigoRol", usuario.Codigo_Rol)

            If cmd.ExecuteNonQuery() Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            MsgBox(ex.Message & "/rol")
        Finally
            desconectar()
        End Try
    End Function

    Public Function EliminarUsuario(codigo As String)
        Try
            conectar()

            Dim sql As String = "sp_usuario_eliminar @codigo"
            cmd = New SqlCommand(sql, con)
            cmd.Parameters.AddWithValue("@codigo", codigo)

            If cmd.ExecuteNonQuery() Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            MsgBox(ex.Message & "/categoria")
        Finally
            desconectar()
        End Try
    End Function
    Public Function ConsultarUsuario() As List(Of Usuario)
        Try
            Dim listUser As List(Of Usuario)
            listUser = New List(Of Usuario)
            Dim i As Integer = 0
            conectar()
            cmd = New SqlCommand("sp_usuario_listar")

            cmd.Connection = con

            dr = cmd.ExecuteReader

            If dr.HasRows Then
                While dr.Read
                    i += 1
                    listUser.Add(New Usuario(
                            dr.Item("i_id_usuario"),
                            dr.Item("v_username_usuario"),
                            dr.Item("v_password_usuario"),
                            dr.Item("i_id_empleado"),
                            dr.Item("v_nombre_persona"),
                            dr.Item("v_apellido_paterno_persona"),
                            dr.Item("i_id_rol"),
                            dr.Item("v_nombre_rol")
                            ))
                End While
                Return listUser
            Else
                Return Nothing
            End If

        Catch ex As Exception
            MsgBox(ex.Message & " Categoria")
            Return Nothing
        Finally
            con.Close()
        End Try
    End Function

    Public Function EncontrarUsuariosCantidad(consulta As String, limite As Integer) As Integer
        Try
            Dim listClien As List(Of Rol)
            listClien = New List(Of Rol)
            Dim i As Integer = 0
            conectar()
            cmd = New SqlCommand("sp_usuario_listar_paginacion_count @consulta, @limite")
            cmd.Parameters.AddWithValue("@consulta", consulta)
            cmd.Parameters.AddWithValue("@limite", limite)

            cmd.Connection = con

            Return cmd.ExecuteScalar()

        Catch ex As Exception
            MsgBox(ex.Message & " USUARIO")
            Return Nothing
        Finally
            con.Close()
        End Try
    End Function

    Public Function EncontrarUsuarios(consulta As String, pagina As Integer, limite As Integer) As List(Of Usuario)
        Try
            Dim usuarios As List(Of Usuario) = New List(Of Usuario)
            Dim i As Integer = 0

            conectar()

            cmd = New SqlCommand("sp_usuario_listar_paginacion @consulta, @pagina, @limite")
            cmd.Parameters.AddWithValue("@consulta", consulta)
            cmd.Parameters.AddWithValue("@pagina", pagina)
            cmd.Parameters.AddWithValue("@limite", limite)

            cmd.Connection = con

            dr = cmd.ExecuteReader

            If dr.HasRows Then
                While dr.Read
                    i += 1
                    usuarios.Add(New Usuario(
                            dr.Item("i_id_usuario"),
                            dr.Item("v_username_usuario"),
                            dr.Item("v_password_usuario"),
                            dr.Item("i_id_empleado"),
                            dr.Item("v_nombre_persona"),
                            dr.Item("v_apellido_paterno_persona"),
                            dr.Item("i_id_rol"),
                            dr.Item("v_nombre_rol")
                            ))
                End While

                Return usuarios
            Else
                Return Nothing
            End If

        Catch ex As Exception
            MsgBox(ex.Message & " USUARIO")
            Return Nothing
        Finally
            con.Close()
        End Try
    End Function

    Public Function EncontrarUsuarioPorCodigo(codigo As String) As Usuario
        Try
            Dim listUser As List(Of Usuario)
            listUser = New List(Of Usuario)

            conectar()

            cmd = New SqlCommand("sp_usuario_encontrar_por_codigo @codigo")
            cmd.Parameters.AddWithValue("@codigo", codigo)

            cmd.Connection = con

            dr = cmd.ExecuteReader

            If dr.HasRows Then
                While dr.Read
                    listUser.Add(New Usuario(
                            dr.Item("i_id_usuario"),
                            dr.Item("v_username_usuario"),
                            dr.Item("v_password_usuario"),
                            dr.Item("i_id_empleado"),
                            dr.Item("v_nombre_persona"),
                            dr.Item("v_apellido_paterno_persona"),
                            dr.Item("i_id_rol"),
                            dr.Item("v_nombre_rol")
                            ))
                End While

                Return listUser.Item(0)
            Else
                Return Nothing
            End If

        Catch ex As Exception
            MsgBox(ex.Message & " Usuario")
            Return Nothing
        Finally
            con.Close()
        End Try
    End Function

    Public Function EncontrarPorNombreUsuario(nombreUsuario As String) As Usuario
        Try
            Dim listUser As List(Of Usuario)
            listUser = New List(Of Usuario)

            conectar()

            cmd = New SqlCommand("sp_usuario_encontrar_por_nombre_usuario @nombreUsuario")
            cmd.Parameters.AddWithValue("@nombreUsuario", nombreUsuario)

            cmd.Connection = con

            dr = cmd.ExecuteReader

            If dr.HasRows Then
                While dr.Read
                    listUser.Add(New Usuario(
                            dr.Item("i_id_usuario"),
                            dr.Item("v_username_usuario"),
                            dr.Item("v_password_usuario"),
                            dr.Item("i_id_empleado"),
                            dr.Item("v_nombre_persona"),
                            dr.Item("v_apellido_paterno_persona"),
                            dr.Item("i_id_rol"),
                            dr.Item("v_nombre_rol")
                            ))
                End While

                Return listUser.Item(0)
            Else
                Return Nothing
            End If

        Catch ex As Exception
            MsgBox(ex.Message & " Usuario")
            Return Nothing
        Finally
            con.Close()
        End Try
    End Function

End Class
