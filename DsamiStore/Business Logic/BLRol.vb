Imports System.Data.SqlClient

Public Class BLRol
    Public Function InsertarRol(cod As String, nom As String)
        Dim rol As New Roles(cod, nom)
        If rol.InsertarRol(rol) = True Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function ConsultarRoles() As List(Of Roles)

        Try
            Dim dataRol As New Roles

            Dim listaRol As List(Of Roles) = dataRol.ConsultarRoles()

            Return listaRol

        Catch ex As Exception
            MsgBox(ex.Message & " BLROLES")
            Return Nothing
        End Try
    End Function
End Class
