Imports System.Data.SqlClient
Imports Entidades

Public Class ProductoDato
    Inherits Conexion

    Private cmd As SqlCommand
    Private dr As SqlDataReader

    Public Function ConsultarProducto() As List(Of Producto)
        Try
            Dim productos As List(Of Producto) = New List(Of Producto)
            Dim i As Integer = 0

            conectar()

            cmd = New SqlCommand("sp_producto_listar")

            cmd.Connection = con

            dr = cmd.ExecuteReader

            '     Public Sub New(id As String, marca As String, categoria As String, Optional imagen As String = Nothing, Optional almacen As String = Nothing, Optional moneda As String = Nothing, Optional nombre As String = Nothing, Optional descripcion As String = Nothing, Optional barras As String = Nothing, Optional precio As Double = Nothing)

            If dr.HasRows Then
                While dr.Read
                    i += 1
                    productos.Add(New Producto(
                                 dr.Item("P.i_id_producto"),
                                 dr.Item("M.v_nombre_marca"),
                                 dr.Item("C.v_nombre_categoria"),
                                 dr.Item("I.v_nombre_imagen"),
                                 dr.Item("AL.v_nombre_almacen"),
                                 dr.Item("MO.v_nombre_moneda"),
                                 dr.Item("P.v_nombre_producto"),
                        dr.Item("P.v_descripcion_producto"),
                        dr.Item("P.v_codigo_barras_producto"),
                        dr.Item("P.d_precio_referencia_producto")))
                End While

                Return productos
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

    Public Function EncontrarProductosCantidad(consulta As String, limite As Integer) As Integer
        Try
            Dim listClien As List(Of Rol)
            listClien = New List(Of Rol)
            Dim i As Integer = 0
            conectar()
            cmd = New SqlCommand("sp_producto_listar_paginacion_count @consulta, @limite")
            cmd.Parameters.AddWithValue("@consulta", consulta)
            cmd.Parameters.AddWithValue("@limite", limite)

            cmd.Connection = con

            Return cmd.ExecuteScalar()

        Catch ex As Exception
            MsgBox(ex.Message & " PRODUCTO")
            Return Nothing
        Finally
            con.Close()
        End Try
    End Function

    Public Function EncontrarProductos(consulta As String, pagina As Integer, limite As Integer) As List(Of Producto)
        Try
            Dim productos As List(Of Producto) = New List(Of Producto)
            Dim i As Integer = 0

            conectar()

            cmd = New SqlCommand("sp_producto_listar_paginacion @consulta, @pagina, @limite")
            cmd.Parameters.AddWithValue("@consulta", consulta)
            cmd.Parameters.AddWithValue("@pagina", pagina)
            cmd.Parameters.AddWithValue("@limite", limite)

            cmd.Connection = con

            dr = cmd.ExecuteReader

            If dr.HasRows Then
                While dr.Read
                    i += 1
                    productos.Add(New Producto(
                                 dr.Item("i_id_producto"),
                                 dr.Item("v_nombre_marca"),
                                 dr.Item("v_nombre_categoria"),
                                 dr.Item("v_nombre_imagen"),
                                 dr.Item("v_nombre_almacen"),
                                 dr.Item("v_nombre_moneda"),
                                 dr.Item("v_nombre_producto"),
                        dr.Item("v_descripcion_producto"),
                        dr.Item("v_codigo_barras_producto"),
                        dr.Item("d_precio_referencia_producto")))
                End While

                Return productos
            Else
                Return Nothing
            End If

        Catch ex As Exception
            MsgBox(ex.Message & " PRODUCTO")
            Return Nothing
        Finally
            con.Close()
        End Try
    End Function
    Public Function EliminarProducto(id) As Boolean
        Try
            conectar()

            cmd = New SqlCommand("sp_producto_eliminar @in_i_id_producto")
            cmd.Parameters.AddWithValue("@in_i_id_producto", id)
            cmd.Connection = con
            dr = cmd.ExecuteReader
            If dr.HasRows Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            MsgBox(ex.Message & " PRODUCTO")
            Return Nothing
        Finally
            con.Close()
        End Try
    End Function
End Class
