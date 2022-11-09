Imports Datos
Imports Entidades

Public Class EmpresaNegocio
    Dim empresaDato As New EmpresaDato

    Public Function ConsultarEmpresa() As List(Of Empresa)
        Try
            Dim listaEmpresa As List(Of Empresa) = empresaDato.ConsultarEmpresa()

            Return listaEmpresa

        Catch ex As Exception
            MsgBox(ex.Message & " BLEMPRESA")
            Return Nothing
        End Try
    End Function
End Class
