Imports System.Data.SqlClient
Imports Entidades

Public Class DistritoDato
    Inherits Conexion

    Private cmd As SqlCommand
    Private dr As SqlDataReader


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
