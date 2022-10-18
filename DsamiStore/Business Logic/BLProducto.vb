﻿Public Class BLProducto
    Private _productoDato As Producto = New Producto()

    Public Function ConsultarProducto() As List(Of Producto)

        Try
            Dim dataProducto As New Producto

            Dim listaProducto As List(Of Producto) = _productoDato.ConsultarProducto()

            Return listaProducto

        Catch ex As Exception
            MsgBox(ex.Message & " BLPRODUCTO")
            Return Nothing
        End Try
    End Function

    Public Function ObtenerProductosCantidad(consulta As String, limite As Integer) As Integer
        Try
            Dim cantidad As Integer = _productoDato.EncontrarProductosCantidad(consulta, limite)

            Return cantidad
        Catch ex As Exception
            MsgBox(ex.Message & " BLPRODUCTO")
            Return Nothing
        End Try
    End Function

    Public Function ObtenerProductos(consulta As String, pagina As Integer, limite As Integer) As List(Of Producto)
        Try
            Dim productos As List(Of Producto) = _productoDato.EncontrarProductos(consulta, pagina, limite)

            Return productos
        Catch ex As Exception
            MsgBox(ex.Message & " BLPRODUCTO")
            Return Nothing
        End Try
    End Function
End Class