Public Class BLRegion
    Dim dataRegion As New Region
    Public Function ConsultarRegion(idPais As String) As List(Of Region)
        Try
            Dim listaRegion As List(Of Region) = dataRegion.ConsultarRegion(idPais)
            Return listaRegion

        Catch ex As Exception
            MsgBox(ex.Message & " BLREGION")
            Return Nothing
        End Try
    End Function
End Class
