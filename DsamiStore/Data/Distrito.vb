Imports System.Data.SqlClient

Public Class Distrito
    Inherits Conexion

    Private _id As String
    Private _nombre As String
    Private _provincia As String

    Private cmd As SqlCommand
    Private dr As SqlDataReader

    Public Sub New()
    End Sub

    Public Sub New(id As String, nombre As String, provincia As String)
        Me._id = id
        Me._nombre = nombre
        Me._provincia = provincia
    End Sub

    Public Property Id As String
        Get
            Return _id
        End Get
        Set(value As String)
            _id = value
        End Set
    End Property

    Public Property Nombre As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            _nombre = value
        End Set
    End Property

    Public Property Provincia As String
        Get
            Return _provincia
        End Get
        Set(value As String)
            _provincia = value
        End Set
    End Property

    Public Function ConsultarDistrito(idProvincia As String) As List(Of Distrito)
        Try
            Dim listDistrito As List(Of Distrito)
            listDistrito = New List(Of Distrito)

            conectar()

            cmd = New SqlCommand("sp_distrito_listar")
            cmd.Connection = con
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Parameters.AddWithValue("@in_i_id_provincia", SqlDbType.VarChar).Value = idProvincia

            dr = cmd.ExecuteReader()

            If dr.HasRows Then
                While dr.Read
                    listDistrito.Add(New Distrito(
                        dr.Item("i_id_distrito"),
                        dr.Item("v_nombre_distrito"),
                         dr.Item("i_id_provincia")
                     ))
                End While

                Return listDistrito
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
