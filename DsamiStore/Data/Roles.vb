Imports System.Data.SqlClient

Public Class Roles
    Inherits Conexion

    Private _id As String
    Private _nombre As String

    Private cmd As SqlCommand
    Private dr As SqlDataReader



    Public Property Nombre As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            _nombre = value
        End Set
    End Property

    Public Property Id As String
        Get
            Return _id
        End Get
        Set(value As String)
            _id = value
        End Set
    End Property

    Public Sub New(cod As String, nom As String)
        Nombre = nom
        Id = cod
    End Sub

    Public Sub New()

    End Sub



    Public Function InsertarRol(rol As Roles)
        Try
            conectar()
            Dim cod As String = "Cl" & rol.Nombre
            Dim fecha As String = "2022-08-01"
            Dim state As Integer = 0

            Dim sql As String = "SP_Set_AgregarRoles '" & cod & "','" & rol.Nombre & "','" & fecha & "','" & state.ToString & "'"

            cmd = New SqlCommand(sql, con)
            If cmd.ExecuteNonQuery() Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            MsgBox(ex.Message & "/rol")
        Finally
            desconectar()
        End Try
    End Function

    Public Function ConsultarRoles() As List(Of Roles)
        Try
            Dim listRol As List(Of Roles)
            listRol = New List(Of Roles)
            Dim i As Integer = 0
            conectar()
            cmd = New SqlCommand("sp_rol_listar")

            cmd.Connection = con

            dr = cmd.ExecuteReader

            If dr.HasRows Then
                While dr.Read
                    i += 1
                    listRol.Add(New Roles(i.ToString, dr.Item("v_nombre_rol")))
                End While

                Return listRol
            Else
                Return Nothing
            End If

        Catch ex As Exception
            MsgBox(ex.Message & " ROLES")
            Return Nothing
        Finally
            con.Close()
        End Try
    End Function

    Public Function EncontrarRolesCantidad(consulta As String, limite As Integer) As Integer
        Try
            Dim listClien As List(Of Roles)
            listClien = New List(Of Roles)
            Dim i As Integer = 0
            conectar()
            cmd = New SqlCommand("sp_rol_listar_paginacion_count @consulta, @limite")
            cmd.Parameters.AddWithValue("@consulta", consulta)
            cmd.Parameters.AddWithValue("@limite", limite)

            cmd.Connection = con

            Return cmd.ExecuteScalar()

        Catch ex As Exception
            MsgBox(ex.Message & " ROLES")
            Return Nothing
        Finally
            con.Close()
        End Try
    End Function

    Public Function EncontrarRoles(consulta As String, pagina As Integer, limite As Integer) As List(Of Roles)
        Try
            Dim listClien As List(Of Roles)
            listClien = New List(Of Roles)
            Dim i As Integer = 0

            conectar()

            cmd = New SqlCommand("sp_rol_listar_paginacion @consulta, @pagina, @limite")
            cmd.Parameters.AddWithValue("@consulta", consulta)
            cmd.Parameters.AddWithValue("@pagina", pagina)
            cmd.Parameters.AddWithValue("@limite", limite)

            cmd.Connection = con

            dr = cmd.ExecuteReader

            If dr.HasRows Then
                While dr.Read
                    listClien.Add(New Roles(dr.Item("i_id_rol").ToString, dr.Item("v_nombre_rol")))
                End While

                Return listClien
            Else
                Return Nothing
            End If

        Catch ex As Exception
            MsgBox(ex.Message & " ROLES")
            Return Nothing
        Finally
            con.Close()
        End Try
    End Function
End Class
