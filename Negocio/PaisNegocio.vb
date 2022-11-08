Imports Datos
Imports Entidades

Public Class PaisNegocio

    Dim paisDato As New PaisDato

    Public Function ConsultarPais() As List(Of Pais)
        Try
            Dim listaPais As List(Of Pais) = paisDato.ConsultarPais()
            Return listaPais

        Catch ex As Exception
            MsgBox(ex.Message & " BLPAIS")
            Return Nothing
        End Try
    End Function
End Class
