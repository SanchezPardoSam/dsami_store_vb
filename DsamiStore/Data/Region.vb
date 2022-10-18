Imports System.Data.SqlClient

Public Class Region
    Inherits Conexion
    Private idRegion As String
    Private nombreRegion As String
    Private idPais As String
    Private pais As Pais

    Private cmd As SqlCommand
    Private dr As SqlDataReader

    Public Property Id_Region As String
        Get
            Return idRegion
        End Get
        Set(value As String)
            idRegion = value
        End Set
    End Property

    Public Property Nombre_Region As String
        Get
            Return nombreRegion
        End Get
        Set(value As String)
            nombreRegion = value
        End Set
    End Property

    Public Property Id_Pais As String
        Get
            Return idPais
        End Get
        Set(value As String)
            idPais = value
        End Set
    End Property

    Public Property Pais_Region As Pais
        Get
            Return pais
        End Get
        Set(value As Pais)
            pais = value
        End Set
    End Property

    Public Sub New(idRegion As String, nombreRegion As String, idPais As String)
        Me.idRegion = idRegion
        Me.nombreRegion = nombreRegion
        Me.idPais = idPais
    End Sub

    Public Sub New()
    End Sub

    Public Function ConsultarRegion(idPais As String) As List(Of Region)
        Try
            Dim listRegion As List(Of Region)
            listRegion = New List(Of Region)

            conectar()

            cmd = New SqlCommand("sp_region_listar")
            cmd.Connection = con
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Parameters.AddWithValue("@in_i_id_pais", SqlDbType.VarChar).Value = idPais

            dr = cmd.ExecuteReader()

            If dr.HasRows Then
                While dr.Read
                    listRegion.Add(New Region(
                        dr.Item("i_id_region"),
                        dr.Item("v_nombre_region"),
                         dr.Item("i_id_pais")
                     ))
                End While

                Return listRegion
            Else
                Return Nothing
            End If

        Catch ex As Exception
            MsgBox(ex.Message & " Pais")
            Return Nothing
        Finally
            con.Close()
        End Try
    End Function
End Class
