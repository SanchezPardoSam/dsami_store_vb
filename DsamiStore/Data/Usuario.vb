Imports System.Data.SqlClient

Public Class Usuario
    Inherits Conexion
    Private codigoUsuario As String
    Private nombreUsuario As String
    Private clave As String
    Private codigoEmpleado As String
    Private _nombreEmpleado
    Private codigoRol As String
    Private _nombreRol As String


    Private cmd As SqlCommand
    Private dr As SqlDataReader

    Public Property Codigo_Usuario As String
        Get
            Return codigoUsuario
        End Get
        Set(value As String)
            codigoUsuario = value
        End Set
    End Property

    Public Property Nombre_Usuario As String
        Get
            Return nombreUsuario
        End Get
        Set(value As String)
            nombreUsuario = value
        End Set
    End Property

    Public Property Clave_Usuario As String
        Get
            Return clave
        End Get
        Set(value As String)
            clave = value
        End Set
    End Property

    Public Property Codigo_Empleado As String
        Get
            Return codigoEmpleado
        End Get
        Set(value As String)
            codigoEmpleado = value
        End Set
    End Property

    Public Property Codigo_Rol As String
        Get
            Return codigoRol
        End Get
        Set(value As String)
            codigoRol = value
        End Set
    End Property


    Public Property NombreEmpleado As Object
        Get
            Return _nombreEmpleado
        End Get
        Set(value As Object)
            _nombreEmpleado = value
        End Set
    End Property

    Public Property NombreRol As String
        Get
            Return _nombreRol
        End Get
        Set(value As String)
            _nombreRol = value
        End Set
    End Property

    Public Sub New(codigoUsuario As String, nombreUsuario As String, clave As String,
                   codigoEmpleado As String, nombreEmpleado As Object,
                   codigoRol As String, nombreRol As String)
        Me.codigoUsuario = codigoUsuario
        Me.nombreUsuario = nombreUsuario
        Me.clave = clave
        Me.codigoEmpleado = codigoEmpleado
        _nombreEmpleado = nombreEmpleado
        Me.codigoRol = codigoRol
        _nombreRol = nombreRol
    End Sub

    Public Sub New()
    End Sub

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
            Dim listClien As List(Of Roles)
            listClien = New List(Of Roles)
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
