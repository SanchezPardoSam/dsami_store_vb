Imports FontAwesome.Sharp
Imports System.Data.SqlClient

Public Class Categoria
    Inherits Conexion
    Private _id As String
    Private _nombre As String
    Private _descripcion As String

    Private cmd As SqlCommand
    Private dr As SqlDataReader
    Public Sub New()
    End Sub

    Public Sub New(id As String, nombre As String, descripcion As String)
        Me._id = id
        Me._nombre = nombre
        Me._descripcion = descripcion
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

    Public Property Descripcion As String
        Get
            Return _descripcion
        End Get
        Set(value As String)
            _descripcion = value
        End Set
    End Property

    Public Function ConsultarCategoria() As List(Of Categoria)
        Try
            Dim listCat As List(Of Categoria)
            listCat = New List(Of Categoria)
            Dim i As Integer = 0
            conectar()
            cmd = New SqlCommand("sp_categoria_listar")

            cmd.Connection = con

            dr = cmd.ExecuteReader

            If dr.HasRows Then
                While dr.Read
                    i += 1
                    listCat.Add(New Categoria(i.ToString, dr.Item("v_nombre_categoria"),
                                          dr.Item("v_descripcion_categoria")))
                End While

                Return listCat
            Else
                Return Nothing
            End If

        Catch ex As Exception
            MsgBox(ex.Message & " Categoria")
            Return Nothing
        Finally
            con.Close()
        End Try
    End Function
End Class
