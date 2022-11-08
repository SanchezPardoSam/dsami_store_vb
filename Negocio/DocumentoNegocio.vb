Imports Datos
Imports Entidades

Public Class DocumentoNegocio
    Dim documentoDato As New DocumentoDato

    Public Function ConsultarDocumentos() As List(Of Documento)
        Try
            Dim listaDocumento As List(Of Documento) = documentoDato.ConsultarDocumento()
            Return listaDocumento

        Catch ex As Exception
            MsgBox(ex.Message & " BLDOCUMENTO")
            Return Nothing
        End Try
    End Function
End Class
