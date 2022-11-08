Imports System.Data.SqlClient
Imports Entidades

Public Class RolDato
    Inherits Conexion

    Private cmd As SqlCommand
    Private dr As SqlDataReader

    Public Function InsertarRol(rol As Rol)
        Try
            conectar()

            Dim sql As String = "sp_rol_agregar @nombre"
            cmd = New SqlCommand(sql, con)
            cmd.Parameters.AddWithValue("@nombre", rol.Nombre)

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

    Public Function ActualizarRol(rol As Rol)
        Try
            conectar()

            Dim sql As String = "sp_rol_actualizar @codigo, @nombre"
            cmd = New SqlCommand(sql, con)
            cmd.Parameters.AddWithValue("@codigo", rol.Id)
            cmd.Parameters.AddWithValue("@nombre", rol.Nombre)

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

    Public Function EliminarRol(codigo As String)
        Try
            conectar()

            Dim sql As String = "sp_rol_eliminar @codigo"
            cmd = New SqlCommand(sql, con)
            cmd.Parameters.AddWithValue("@codigo", codigo)

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

    Public Function ConsultarRoles() As List(Of Rol)
        Try
            Dim listRol As List(Of Rol)
            listRol = New List(Of Rol)
            Dim i As Integer = 0
            conectar()
            cmd = New SqlCommand("sp_rol_listar")

            cmd.Connection = con

            dr = cmd.ExecuteReader

            If dr.HasRows Then
                While dr.Read
                    i += 1
                    listRol.Add(New Rol(dr.Item("i_id_rol"), dr.Item("v_nombre_rol")))
                End While

                Return listRol
            Else
                Return Nothing
            End If

        Catch ex As Exception
            MsgBox(ex.Message & " ROLES")
            Return Nothing
        Finally
            con.Close()
        End Try
    End Function

    Public Function EncontrarRolesCantidad(consulta As String, limite As Integer) As Integer
        Try
            Dim listClien As List(Of Rol)
            listClien = New List(Of Rol)
            Dim i As Integer = 0
            conectar()
            cmd = New SqlCommand("sp_rol_listar_paginacion_count @consulta, @limite")
            cmd.Parameters.AddWithValue("@consulta", consulta)
            cmd.Parameters.AddWithValue("@limite", limite)

            cmd.Connection = con

            Return cmd.ExecuteScalar()

        Catch ex As Exception
            MsgBox(ex.Message & " ROLES")
            Return Nothing
        Finally
            con.Close()
        End Try
    End Function

    Public Function EncontrarRoles(consulta As String, pagina As Integer, limite As Integer) As List(Of Rol)
        Try
            Dim listClien As List(Of Rol)
            listClien = New List(Of Rol)
            Dim i As Integer = 0

            conectar()

            cmd = New SqlCommand("sp_rol_listar_paginacion @consulta, @pagina, @limite")
            cmd.Parameters.AddWithValue("@consulta", consulta)
            cmd.Parameters.AddWithValue("@pagina", pagina)
            cmd.Parameters.AddWithValue("@limite", limite)

            cmd.Connection = con

            dr = cmd.ExecuteReader

            If dr.HasRows Then
                While dr.Read
                    listClien.Add(New Rol(dr.Item("i_id_rol").ToString, dr.Item("v_nombre_rol")))
                End While

                Return listClien
            Else
                Return Nothing
            End If

        Catch ex As Exception
            MsgBox(ex.Message & " ROLES")
            Return Nothing
        Finally
            con.Close()
        End Try
    End Function
End Class
