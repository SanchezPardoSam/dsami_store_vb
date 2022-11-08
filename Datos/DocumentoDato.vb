Imports System.Data.SqlClient
Imports Entidades

Public Class DocumentoDato
    Inherits Conexion

    Private cmd As SqlCommand
    Private dr As SqlDataReader

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
