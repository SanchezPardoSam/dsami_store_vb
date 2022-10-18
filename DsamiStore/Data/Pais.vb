Imports System.Data.SqlClient

Public Class Pais
    Inherits Conexion
    Private _id As String
    Private _nombre As String


    Private cmd As SqlCommand
    Private dr As SqlDataReader
    Public Sub New()
    End Sub

    Public Sub New(id As String, Optional nombre As String = Nothing)
        _id = id
        _nombre = nombre
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
    Public Function ConsultarPais() As List(Of Pais)
        Try
            Dim listpais As List(Of Pais)
            listpais = New List(Of Pais)

            conectar()
            cmd = New SqlCommand("sp_pais_listar")

            cmd.Connection = con

            dr = cmd.ExecuteReader

            If dr.HasRows Then
                While dr.Read
                    listpais.Add(New Pais(
                        dr.Item("i_id_pais"),
                        dr.Item("v_nombre_pais")
                                   ))
                End While

                Return listpais
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
