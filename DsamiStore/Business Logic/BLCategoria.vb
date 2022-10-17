Public Class BLCategoria
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
End Class
