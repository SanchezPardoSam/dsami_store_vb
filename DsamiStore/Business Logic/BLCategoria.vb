Public Class BLCategoria
    Private _categoriaDato As Categoria = New Categoria()

    Public Function ConsultarCategoria() As List(Of Categoria)

        Try
            Dim dataCategoria As New Categoria

            Dim listaCategoria As List(Of Categoria) = dataCategoria.ConsultarCategoria()

            Return listaCategoria

        Catch ex As Exception
            MsgBox(ex.Message & " BLCATEGORIA")
            Return Nothing
        End Try
    End Function

    Public Function ObtenerCategoriasCantidad(consulta As String, limite As Integer) As Integer
        Try
            Dim cantidad As Integer = _categoriaDato.EncontrarCategoriasCantidad(consulta, limite)

            Return cantidad
        Catch ex As Exception
            MsgBox(ex.Message & " BLCATEGORIA")
            Return Nothing
        End Try
    End Function

    Public Function ObtenerCategorias(consulta As String, pagina As Integer, limite As Integer) As List(Of Categoria)
        Try
            Dim categorias As List(Of Categoria) = _categoriaDato.EncontrarCategorias(consulta, pagina, limite)

            Return categorias
        Catch ex As Exception
            MsgBox(ex.Message & " BLCATEGORIA")
            Return Nothing
        End Try
    End Function
End Class
