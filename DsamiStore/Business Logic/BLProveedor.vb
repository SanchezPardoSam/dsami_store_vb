Public Class BLProveedor
    Public Function ConsultarProveedor() As List(Of Proveedor)

        Try
            Dim dp As New Proveedor()

            Dim lp As List(Of Proveedor) = dp.ConsultarProveedor()

            Return lp

        Catch ex As Exception
            MsgBox(ex.Message & " BLProveedor")
            Return Nothing
        End Try
    End Function
End Class
