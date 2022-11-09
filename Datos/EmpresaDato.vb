Imports System.Data.SqlClient
Imports Entidades

Public Class EmpresaDato
    Inherits Conexion

    Private cmd As SqlCommand
    Private dr As SqlDataReader

    Public Function ConsultarEmpresa() As List(Of Empresa)
        Try
            Dim listEmp As List(Of Empresa)
            listEmp = New List(Of Empresa)
            Dim i As Integer = 0
            conectar()
            cmd = New SqlCommand("sp_empresa_listar")

            cmd.Connection = con

            dr = cmd.ExecuteReader

            If dr.HasRows Then
                While dr.Read
                    i += 1
                    listEmp.Add(New Empresa(
                                dr.Item("i_id_empresa"),
                                dr.Item("v_ruc_empresa"),
                                dr.Item("v_razon_social_empresa"),
                                dr.Item("i_id_ubicacion")
                    ))
                End While

                Return listEmp
            Else
                Return Nothing
            End If

        Catch ex As Exception
            MsgBox(ex.Message & " Empresa")
            Return Nothing
        Finally
            con.Close()
        End Try
    End Function
End Class
