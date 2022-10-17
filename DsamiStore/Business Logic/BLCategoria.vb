Public Class BLCategoria
    Public Function ConsultarCategoria() As List(Of Categoria)

        Try
            Dim dc As New Categoria

            Dim lc As List(Of Categoria) = dc.ConsultarCategoria()

            Return lc

        Catch ex As Exception
            MsgBox(ex.Message & " BLCATEGORIA")
            Return Nothing
        End Try
    End Function
End Class
