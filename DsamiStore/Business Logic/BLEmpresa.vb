Public Class BLEmpresa
    Dim dataEmpresa As New Empresa
    Public Function ConsultarEmpresa() As List(Of Empresa)
        Try
            Dim listaEmpresa As List(Of Empresa) = dataEmpresa.ConsultarEmpresa()

            Return listaEmpresa

        Catch ex As Exception
            MsgBox(ex.Message & " BLEMPRESA")
            Return Nothing
        End Try
    End Function
End Class
