Public Class BLProveedor
    Dim dataProveedor As New Proveedor()
    Public Function ConsultarProveedor() As List(Of Proveedor)
        Try
            Dim listaProveedor As List(Of Proveedor) = dataProveedor.ConsultarProveedor()
            Return listaProveedor

        Catch ex As Exception
            MsgBox(ex.Message & " BLProveedor")
            Return Nothing
        End Try
    End Function

    Public Function InsertarProveedor(prov As Proveedor)
        If dataProveedor.InsertarProveedor(prov) = True Then
            Return True
        Else
            Return False
        End If
    End Function
End Class
