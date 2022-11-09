Imports Datos
Imports Entidades

Public Class DistritoNegocio
    Dim distritoNegocio As New DistritoDato

    Public Function ConsultarDistritos(idProvincia As String) As List(Of Distrito)
        Try
            Dim listaDistrito As List(Of Distrito) = distritoNegocio.ConsultarDistrito(idProvincia)
            Return listaDistrito

        Catch ex As Exception
            MsgBox(ex.Message & " BLDISTRITO")
            Return Nothing
        End Try
    End Function
End Class
