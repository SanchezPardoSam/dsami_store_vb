Public Class BLPais

    Dim dataPais As New Pais
    Public Function ConsultarPais() As List(Of Pais)
        Try
            Dim listaPais As List(Of Pais) = dataPais.ConsultarPais()
            Return listaPais

        Catch ex As Exception
            MsgBox(ex.Message & " BLPAIS")
            Return Nothing
        End Try
    End Function
End Class
