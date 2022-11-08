Imports Datos
Imports Entidades

Public Class ProductoNegocio
    Private _productoDato As New ProductoDato

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

    Public Function EliminarProductos(consulta As String) As Boolean
        Try
            Dim productos = _productoDato.EliminarProducto(consulta)

            Return productos
        Catch ex As Exception
            MsgBox(ex.Message & " BLPRODUCTO")
            Return Nothing
        End Try
    End Function
End Class
