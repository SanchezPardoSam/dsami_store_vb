Imports Datos
Imports Entidades

Public Class ProvinciaNegocio
    Dim provinciaDato As New ProvinciaDato

    Public Function ConsultarProvincias(idRegion As String) As List(Of Provincia)
        Try
            Dim listaProvincia As List(Of Provincia) = provinciaDato.ConsultarProvincia(idRegion)
            Return listaProvincia

        Catch ex As Exception
            MsgBox(ex.Message & " BLPROVINCIA")
            Return Nothing
        End Try
    End Function
End Class
