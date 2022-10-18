Public Class BLDocumento
    Dim dataDocumento As New Documento
    Public Function ConsultarDocumentos() As List(Of Documento)
        Try
            Dim listaDocumento As List(Of Documento) = dataDocumento.ConsultarDocumento()
            Return listaDocumento

        Catch ex As Exception
            MsgBox(ex.Message & " BLDOCUMENTO")
            Return Nothing
        End Try
    End Function
End Class
