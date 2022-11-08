Imports System.Data.SqlClient

Public Class Provincia
    Inherits Conexion
    Private idProvincia As String
    Private nombreProvincia As String
    Private idRegion As String

    Private cmd As SqlCommand
    Private dr As SqlDataReader
    Public Property Id_Provincia As String
        Get
            Return idProvincia
        End Get
        Set(value As String)
            idProvincia = value
        End Set
    End Property

    Public Property Nombre_Provincia As String
        Get
            Return nombreProvincia
        End Get
        Set(value As String)
            nombreProvincia = value
        End Set
    End Property

    Public Property Id_Region As String
        Get
            Return idRegion
        End Get
        Set(value As String)
            idRegion = value
        End Set
    End Property

    Public Sub New()
    End Sub

    Public Sub New(idProvincia As String, nombreProvincia As String, idRegion As String)
        Me.idProvincia = idProvincia
        Me.nombreProvincia = nombreProvincia
        Me.idRegion = idRegion
    End Sub

    Public Function ConsultarProvincia(idRegion As String) As List(Of Provincia)
        Try
            Dim listProvincia As List(Of Provincia)
            listProvincia = New List(Of Provincia)

            conectar()

            cmd = New SqlCommand("sp_provincia_listar")
            cmd.Connection = con
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Parameters.AddWithValue("@in_i_id_region", SqlDbType.VarChar).Value = idRegion

            dr = cmd.ExecuteReader()

            If dr.HasRows Then
                While dr.Read
                    listProvincia.Add(New Provincia(
                        dr.Item("i_id_provincia"),
                        dr.Item("v_nombre_provincia"),
                         dr.Item("i_id_region")
                     ))
                End While

                Return listProvincia
            Else
                Return Nothing
            End If

        Catch ex As Exception
            MsgBox(ex.Message & " Provincia")
            Return Nothing
        Finally
            con.Close()
        End Try
    End Function
End Class
