Imports System.Data.SqlClient
Imports Entidades

Public Class ProveedorDato
    Inherits Conexion

    Private cmd As SqlCommand
    Private dr As SqlDataReader

    Public Function ConsultarProveedor() As List(Of Proveedor)
        Try
            Dim listprov As List(Of Proveedor)
            listprov = New List(Of Proveedor)
            Dim i As Integer = 0
            conectar()
            cmd = New SqlCommand("sp_proveedor_listar")

            cmd.Connection = con

            dr = cmd.ExecuteReader

            If dr.HasRows Then
                While dr.Read
                    i += 1
                    listprov.Add(New Proveedor(
                                 dr.Item("i_id_proveedor"),
                                 dr.Item("v_direccion_ubicacion"),
                                 dr.Item("v_razon_social_empresa"),
                                 dr.Item("v_nombre_tipo_documento"),
                                 dr.Item("v_valor_documento"),
                                 dr.Item("v_nombre_pais"),
                                 dr.Item("v_nombre_region"),
                                 dr.Item("v_nombre_distrito"),
                                 dr.Item("v_nombre_provincia"),
                                  dr.Item("v_ruc_empresa"),
                        dr.Item("i_id_persona"),
                        dr.Item("v_nombre_persona"),
                        dr.Item("v_apellido_paterno_persona"),
                        dr.Item("v_apellido_materno_persona"),
                        dr.Item("i_id_documento"),
                        dr.Item("d_fecha_nacimiento_persona"),
                        dr.Item("i_id_pais")
                                   ))
                End While

                Return listprov
            Else
                Return Nothing
            End If

        Catch ex As Exception
            MsgBox(ex.Message & " Proveedor")
            Return Nothing
        Finally
            con.Close()
        End Try
    End Function


    Public Function InsertarProveedor(provee As Proveedor)
        Try

            'cmd.CommandType = CommandType.StoredProcedure
            conectar()

            cmd = New SqlCommand("sp_proveedor_agregar")

            cmd.Connection = con
            cmd.CommandType = CommandType.StoredProcedure
            MsgBox(provee.ToString())
            cmd.Parameters.AddWithValue("@in_v_direccion_ubicacion", SqlDbType.VarChar).Value = provee.Direccion
            Console.WriteLine(provee.Distrito)
            Console.WriteLine("provee.Distrito")
            cmd.Parameters.AddWithValue("@in_i_id_distrito", SqlDbType.VarChar).Value = provee.Distrito
            cmd.Parameters.AddWithValue("@in_v_valor_documento", SqlDbType.VarChar).Value = provee.Documento
            cmd.Parameters.AddWithValue("@in_i_id_tipo_documento", SqlDbType.VarChar).Value = provee.Tipo
            cmd.Parameters.AddWithValue("@in_v_nombre_persona", SqlDbType.VarChar).Value = provee.Nombre

            cmd.Parameters.AddWithValue("@in_v_apellido_paterno_persona", SqlDbType.VarChar).Value = provee.ApellidoPaterno
            cmd.Parameters.AddWithValue("@in_v_apellido_materno_persona", SqlDbType.VarChar).Value = provee.ApellidoMaterno
            Console.WriteLine(provee.ApellidoPaterno)
            Console.WriteLine("provee.ApellidoPaterno")
            cmd.Parameters.AddWithValue("@in_d_fecha_nacimiento_persona", SqlDbType.Date).Value = provee.FechaNacimiento
            cmd.Parameters.AddWithValue("@in_i_id_pais_origen", SqlDbType.VarChar).Value = provee.Pais
            Console.WriteLine(provee.Empresa)
            Console.WriteLine("provee.Empresa")
            cmd.Parameters.AddWithValue("@in_i_id_empresa", SqlDbType.Char).Value = provee.Empresa

            If cmd.ExecuteNonQuery() Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message & " Proveedor")
            Return False
        Finally
            con.Close()
        End Try
    End Function

    Public Function EditarProveedor(provee As Proveedor)
        Try

            'cmd.CommandType = CommandType.StoredProcedure
            conectar()

            cmd = New SqlCommand("sp_proveedor_modificar")

            cmd.Connection = con
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Parameters.AddWithValue("@in_i_id_proveedor", SqlDbType.VarChar).Value = provee.Id

            Console.WriteLine("provee.Distrito")
            Console.WriteLine(provee.Distrito)
            cmd.Parameters.AddWithValue("@in_v_direccion_ubicacion", SqlDbType.VarChar).Value = provee.Direccion
            cmd.Parameters.AddWithValue("@in_i_id_distrito", SqlDbType.VarChar).Value = provee.Distrito
            cmd.Parameters.AddWithValue("@in_v_valor_documento", SqlDbType.VarChar).Value = provee.Documento
            cmd.Parameters.AddWithValue("@in_i_id_tipo_documento", SqlDbType.VarChar).Value = provee.Tipo
            cmd.Parameters.AddWithValue("@in_v_nombre_persona", SqlDbType.VarChar).Value = provee.Nombre

            cmd.Parameters.AddWithValue("@in_v_apellido_paterno_persona", SqlDbType.VarChar).Value = provee.ApellidoPaterno
            cmd.Parameters.AddWithValue("@in_v_apellido_materno_persona", SqlDbType.VarChar).Value = provee.ApellidoMaterno

            cmd.Parameters.AddWithValue("@in_d_fecha_nacimiento_persona", SqlDbType.Date).Value = provee.FechaNacimiento
            cmd.Parameters.AddWithValue("@in_i_id_pais_origen", SqlDbType.VarChar).Value = provee.Pais


            If cmd.ExecuteNonQuery() Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message & " Proveedor")
            Return False
        Finally
            con.Close()
        End Try
    End Function
    Public Function EliminarProveedor(codigo As String)
        Try

            'cmd.CommandType = CommandType.StoredProcedure
            conectar()

            cmd = New SqlCommand("sp_proveedor_eliminar")

            cmd.Connection = con
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Parameters.AddWithValue("@in_i_id_proveedor", SqlDbType.NChar).Value = codigo

            If cmd.ExecuteNonQuery() Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message & " Proveedor")
            Return False
        Finally
            con.Close()
        End Try
    End Function

    Public Function EncontrarProveedoresCantidad(consulta As String, limite As Integer) As Integer
        Try
            Dim listClien As List(Of Rol)
            listClien = New List(Of Rol)
            Dim i As Integer = 0
            conectar()
            cmd = New SqlCommand("sp_proveedor_listar_paginacion_count @consulta, @limite")
            cmd.Parameters.AddWithValue("@consulta", consulta)
            cmd.Parameters.AddWithValue("@limite", limite)

            cmd.Connection = con

            Return cmd.ExecuteScalar()

        Catch ex As Exception
            MsgBox(ex.Message & " Proveedor")
            Return Nothing
        Finally
            con.Close()
        End Try
    End Function

    Public Function EncontrarProveedores(consulta As String, pagina As Integer, limite As Integer) As List(Of Proveedor)
        Try
            Dim proveedores As List(Of Proveedor) = New List(Of Proveedor)
            Dim i As Integer = 0

            conectar()

            cmd = New SqlCommand("sp_proveedor_listar_paginacion @consulta, @pagina, @limite")
            cmd.Parameters.AddWithValue("@consulta", consulta)
            cmd.Parameters.AddWithValue("@pagina", pagina)
            cmd.Parameters.AddWithValue("@limite", limite)

            cmd.Connection = con

            dr = cmd.ExecuteReader

            If dr.HasRows Then
                While dr.Read
                    i += 1
                    proveedores.Add(New Proveedor(
                                 dr.Item("i_id_proveedor"),
                                 dr.Item("v_direccion_ubicacion"),
                                 dr.Item("v_razon_social_empresa"),
                                 dr.Item("v_nombre_tipo_documento"),
                                 dr.Item("v_valor_documento"),
                                 dr.Item("v_nombre_pais"),
                                 dr.Item("v_nombre_region"),
                                 dr.Item("v_nombre_distrito"),
                                 dr.Item("v_nombre_provincia"),
                                  dr.Item("v_ruc_empresa"),
                        dr.Item("i_id_persona"),
                        dr.Item("v_nombre_persona"),
                        dr.Item("v_apellido_paterno_persona"),
                        dr.Item("v_apellido_materno_persona"),
                        dr.Item("i_id_documento"),
                        dr.Item("d_fecha_nacimiento_persona"),
                        dr.Item("i_id_pais")
                                   ))
                End While

                Return proveedores
            Else
                Return Nothing
            End If

        Catch ex As Exception
            MsgBox(ex.Message & " Proveedor")
            Return Nothing
        Finally
            con.Close()
        End Try
    End Function

    Public Function ConsultarProveedorID(codigo As String) As Proveedor
        Try
            Dim prov As Proveedor
            prov = New Proveedor()

            conectar()

            cmd = New SqlCommand("sp_proveedor_buscar @codigo")
            cmd.Parameters.AddWithValue("@codigo", codigo)

            cmd.Connection = con

            dr = cmd.ExecuteReader

            If dr.HasRows Then
                While dr.Read

                    prov = New Proveedor(
                                 dr.Item("i_id_proveedor"),
                                 dr.Item("v_direccion_ubicacion"),
                                 dr.Item("v_razon_social_empresa"),
                                 dr.Item("v_nombre_tipo_documento"),
                                 dr.Item("v_valor_documento"),
                                 dr.Item("v_nombre_pais"),
                                 dr.Item("v_nombre_region"),
                                 dr.Item("v_nombre_distrito"),
                                 dr.Item("v_nombre_provincia"),
                                  dr.Item("v_ruc_empresa"),
                        dr.Item("i_id_persona"),
                        dr.Item("v_nombre_persona"),
                        dr.Item("v_apellido_paterno_persona"),
                        dr.Item("v_apellido_materno_persona"),
                        dr.Item("i_id_documento"),
                        dr.Item("d_fecha_nacimiento_persona"),
                        dr.Item("i_id_pais")
                                   )
                End While

                Return prov
            Else
                Return Nothing
            End If

        Catch ex As Exception
            MsgBox(ex.Message & " Proveedor")
            Return Nothing
        Finally
            con.Close()
        End Try
    End Function
End Class
