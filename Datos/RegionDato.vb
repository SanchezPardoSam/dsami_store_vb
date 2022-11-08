Imports System.Data.SqlClient
Imports Entidades

Public Class RegionDato
    Inherits Conexion

    Private cmd As SqlCommand
    Private dr As SqlDataReader

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
