Public Class BLProvincia
    Dim dataProvincia As New Provincia
    Public Function ConsultarProvincias(idRegion As String) As List(Of Provincia)
        Try
            Dim listaProvincia As List(Of Provincia) = dataProvincia.ConsultarProvincia(idRegion)
            Return listaProvincia

        Catch ex As Exception
            MsgBox(ex.Message & " BLPROVINCIA")
            Return Nothing
        End Try
    End Function
End Class
