Public Class BLDistrito
    Dim dataDistrito As New Distrito
    Public Function ConsultarDistritos(idProvincia As String) As List(Of Distrito)
        Try
            Dim listaDistrito As List(Of Distrito) = dataDistrito.ConsultarDistrito(idProvincia)
            Return listaDistrito

        Catch ex As Exception
            MsgBox(ex.Message & " BLDISTRITO")
            Return Nothing
        End Try
    End Function
End Class
