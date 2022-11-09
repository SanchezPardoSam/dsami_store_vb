Imports System.Data.SqlClient
Imports Entidades

Public Class EmpleadoDato
    Inherits Conexion

    Private cmd As SqlCommand
    Private dr As SqlDataReader

    Public Function ConsultarEmpleado() As List(Of Empleado)
        Try
            Dim empleados As List(Of Empleado) = New List(Of Empleado)
            Dim i As Integer = 0

            conectar()

            cmd = New SqlCommand("sp_empleado_listar")

            cmd.Connection = con

            dr = cmd.ExecuteReader

            If dr.HasRows Then
                While dr.Read
                    i += 1
                    empleados.Add(New Empleado(
                                 dr.Item("i_id_empleado"),
                                 dr.Item("v_direccion_ubicacion"),
                                 dr.Item("v_nombre_tipo_documento"),
                                 dr.Item("v_valor_documento"),
                                 dr.Item("i_id_region"),
                                 dr.Item("i_id_distrito"),
                                 dr.Item("i_id_provincia"),
                        dr.Item("i_id_persona"),
                        dr.Item("v_nombre_persona"),
                        dr.Item("v_apellido_paterno_persona"),
                        dr.Item("v_apellido_materno_persona"),
                        dr.Item("i_id_documento"),
                        dr.Item("d_fecha_nacimiento_persona"),
                        dr.Item("i_id_pais")
                                   ))
                End While

                Return empleados
            Else
                Return Nothing
            End If

        Catch ex As Exception
            MsgBox(ex.Message & " EMPLEADO")
            Return Nothing
        Finally
            con.Close()
        End Try
    End Function

    Public Function EncontrarEmpleadosCantidad(consulta As String, limite As Integer) As Integer
        Try
            Dim listClien As List(Of Rol)
            listClien = New List(Of Rol)
            Dim i As Integer = 0
            conectar()
            cmd = New SqlCommand("sp_empleado_listar_paginacion_count @consulta, @limite")
            cmd.Parameters.AddWithValue("@consulta", consulta)
            cmd.Parameters.AddWithValue("@limite", limite)

            cmd.Connection = con

            Return cmd.ExecuteScalar()

        Catch ex As Exception
            MsgBox(ex.Message & " EMPLEADO")
            Return Nothing
        Finally
            con.Close()
        End Try
    End Function

    Public Function EncontrarEmpleados(consulta As String, pagina As Integer, limite As Integer) As List(Of Empleado)
        Try
            Dim empleados As List(Of Empleado) = New List(Of Empleado)
            Dim i As Integer = 0

            conectar()

            cmd = New SqlCommand("sp_empleado_listar_paginacion @consulta, @pagina, @limite")
            cmd.Parameters.AddWithValue("@consulta", consulta)
            cmd.Parameters.AddWithValue("@pagina", pagina)
            cmd.Parameters.AddWithValue("@limite", limite)

            cmd.Connection = con

            dr = cmd.ExecuteReader

            If dr.HasRows Then
                While dr.Read
                    i += 1
                    empleados.Add(New Empleado(
                                 dr.Item("i_id_empleado"),
                                 dr.Item("v_direccion_ubicacion"),
                                 dr.Item("v_nombre_tipo_documento"),
                                 dr.Item("v_valor_documento"),
                                 dr.Item("i_id_region"),
                                 dr.Item("i_id_distrito"),
                                 dr.Item("i_id_provincia"),
                        dr.Item("i_id_persona"),
                        dr.Item("v_nombre_persona"),
                        dr.Item("v_apellido_paterno_persona"),
                        dr.Item("v_apellido_materno_persona"),
                        dr.Item("i_id_documento"),
                        dr.Item("d_fecha_nacimiento_persona"),
                        dr.Item("i_id_pais")
                                   ))
                End While

                Return empleados
            Else
                Return Nothing
            End If

        Catch ex As Exception
            MsgBox(ex.Message & " EMPLEADO")
            Return Nothing
        Finally
            con.Close()
        End Try
    End Function

End Class
