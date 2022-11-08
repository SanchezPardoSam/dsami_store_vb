Imports System.Data.SqlClient

Public Class Documento
    Inherits Conexion
    Private _id As String
    Private _nombre As String

    Private cmd As SqlCommand
    Private dr As SqlDataReader

    Public Sub New()
    End Sub

    Public Sub New(id As String, nombre As String)
        Me._id = id
        Me._nombre = nombre
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

    Public Function ConsultarDocumento() As List(Of Documento)
        Try
            Dim listDocumento As List(Of Documento)
            listDocumento = New List(Of Documento)

            conectar()
            cmd = New SqlCommand("sp_tipo_documento_listar")

            cmd.Connection = con

            dr = cmd.ExecuteReader

            If dr.HasRows Then
                While dr.Read
                    listDocumento.Add(New Documento(
                        dr.Item("i_id_tipo_documento"),
                        dr.Item("v_nombre_tipo_documento")
                                   ))
                End While

                Return listDocumento
            Else
                Return Nothing
            End If

        Catch ex As Exception
            MsgBox(ex.Message & " Documento")
            Return Nothing
        Finally
            con.Close()
        End Try
    End Function
End Class
