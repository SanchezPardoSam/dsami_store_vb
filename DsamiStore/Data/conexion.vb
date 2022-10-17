Imports System.Configuration
Imports System.Data.OleDb
Imports System.Data.SqlClient

Public Class Conexion
    Protected con As New SqlConnection(ConfigurationManager.ConnectionStrings("cnDBS").ConnectionString)

    Public Function conectar()
        Try
            con.Open()
            Return True

        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Function desconectar()
        Try
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function
End Class
