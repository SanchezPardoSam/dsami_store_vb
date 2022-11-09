Imports Datos
Imports Entidades

Public Class RolNegocio
    Private _rolDato As New RolDato

    Public Function InsertarRol(cod As String, nom As String)
        Dim rol As New Rol(cod, nom)

        If _rolDato.InsertarRol(rol) = True Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function ActualizarRol(codigo As String, nombre As String)
        Dim rol As New Rol(codigo, nombre)

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

    Public Function ConsultarRoles() As List(Of Rol)

        Try
            Dim roles As List(Of Rol) = _rolDato.ConsultarRoles()

            Return roles

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

    Public Function ObtenerRoles(consulta As String, pagina As Integer, limite As Integer) As List(Of Rol)
        Try
            Dim roles As List(Of Rol) = _rolDato.EncontrarRoles(consulta, pagina, limite)

            Return roles
        Catch ex As Exception
            MsgBox(ex.Message & " BLROLES")
            Return Nothing
        End Try
    End Function
End Class
