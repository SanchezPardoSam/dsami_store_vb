Public Class BLProveedor
    Public Function ConsultarProveedor() As List(Of Proveedor)

        Try
            Dim dataProveedor As New Proveedor()

            Dim listaProveedor As List(Of Proveedor) = dataProveedor.ConsultarProveedor()

            Return listaProveedor

        Catch ex As Exception
            MsgBox(ex.Message & " BLProveedor")
            Return Nothing
        End Try
    End Function
End Class
