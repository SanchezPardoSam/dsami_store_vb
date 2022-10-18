Imports System.Data.SqlClient

Public Class BLRol
    Private _rolDato As Roles = New Roles()

    Public Function InsertarRol(cod As String, nom As String)
        Dim rol As New Roles(cod, nom)

        If _rolDato.InsertarRol(rol) = True Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function ActualizarRol(codigo As String, nombre As String)
        Dim rol As New Roles(codigo, nombre)

        If _rolDato.ActualizarRol(rol) = True Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function EliminarRol(codigo As String)
        If _rolDato.EliminarRol(codigo) = True Then
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

    Public Function ObtenerRolesCantidad(consulta As String, limite As Integer) As Integer
        Try
            Dim cantidad As Integer = _rolDato.EncontrarRolesCantidad(consulta, limite)

            Return cantidad
        Catch ex As Exception
            MsgBox(ex.Message & " BLROLES")
            Return Nothing
        End Try
    End Function

    Public Function ObtenerRoles(consulta As String, pagina As Integer, limite As Integer) As List(Of Roles)
        Try
            Dim roles As List(Of Roles) = _rolDato.EncontrarRoles(consulta, pagina, limite)

            Return roles
        Catch ex As Exception
            MsgBox(ex.Message & " BLROLES")
            Return Nothing
        End Try
    End Function
End Class
