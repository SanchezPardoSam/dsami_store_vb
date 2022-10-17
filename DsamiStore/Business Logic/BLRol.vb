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
            Dim dr As New Roles

            Dim lr As List(Of Roles) = dr.ConsultarRoles()

            Return lr

        Catch ex As Exception
            MsgBox(ex.Message & " BLROLES")
            Return Nothing
        End Try
    End Function
End Class
