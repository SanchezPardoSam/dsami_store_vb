Imports Datos
Imports Entidades

Public Class RegionNegocio
    Dim regionDato As New RegionDato

    Public Function ConsultarRegion(idPais As String) As List(Of Region)
        Try
            Dim listaRegion As List(Of Region) = regionDato.ConsultarRegion(idPais)
            Return listaRegion

        Catch ex As Exception
            MsgBox(ex.Message & " BLREGION")
            Return Nothing
        End Try
    End Function
End Class
