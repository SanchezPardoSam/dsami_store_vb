Imports FontAwesome.Sharp
Imports System.Data.SqlClient

Public Class Producto
    Inherits Conexion
    Private _id As String
    Private _marca As String
    Private _categoria As String
    Private _imagen As String
    Private _almacen As String
    Private _moneda As String
    Private _nombre As String
    Private _descripcion As String
    Private _barras As String
    Private _precio As Double

    Private cmd As SqlCommand
    Private dr As SqlDataReader

    Public Sub New()
    End Sub

    Public Sub New(id As String, marca As String, categoria As String, Optional imagen As String = Nothing, Optional almacen As String = Nothing, Optional moneda As String = Nothing, Optional nombre As String = Nothing, Optional descripcion As String = Nothing, Optional barras As String = Nothing, Optional precio As Double = Nothing)
        _id = id
        _marca = marca
        _categoria = categoria
        _imagen = imagen
        _almacen = almacen
        _moneda = moneda
        _nombre = nombre
        _descripcion = descripcion
        _barras = barras
        _precio = precio
    End Sub

    Public Property Id As String
        Get
            Return _id
        End Get
        Set(value As String)
            _id = value
        End Set
    End Property

    Public Property Marca As String
        Get
            Return _marca
        End Get
        Set(value As String)
            _marca = value
        End Set
    End Property

    Public Property Categoria As String
        Get
            Return _categoria
        End Get
        Set(value As String)
            _categoria = value
        End Set
    End Property

    Public Property Imagen As String
        Get
            Return _imagen
        End Get
        Set(value As String)
            _imagen = value
        End Set
    End Property

    Public Property Almacen As String
        Get
            Return _almacen
        End Get
        Set(value As String)
            _almacen = value
        End Set
    End Property

    Public Property Moneda As String
        Get
            Return _moneda
        End Get
        Set(value As String)
            _moneda = value
        End Set
    End Property

    Public Property Nombre As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            _nombre = value
        End Set
    End Property

    Public Property Descripcion As String
        Get
            Return _descripcion
        End Get
        Set(value As String)
            _descripcion = value
        End Set
    End Property

    Public Property Barras As String
        Get
            Return _barras
        End Get
        Set(value As String)
            _barras = value
        End Set
    End Property

    Public Property Precio As Double
        Get
            Return _precio
        End Get
        Set(value As Double)
            _precio = value
        End Set
    End Property

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
            Dim listClien As List(Of Roles)
            listClien = New List(Of Roles)
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
End Class
