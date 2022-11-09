Imports System.Data.SqlClient
Imports Entidades

Public Class ProvinciaDato
    Inherits Conexion

    Private cmd As SqlCommand
    Private dr As SqlDataReader

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
