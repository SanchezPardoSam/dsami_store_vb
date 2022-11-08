Imports System.Data.SqlClient
Imports Entidades

Public Class PaisDato
    Inherits Conexion

    Private cmd As SqlCommand
    Private dr As SqlDataReader

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
