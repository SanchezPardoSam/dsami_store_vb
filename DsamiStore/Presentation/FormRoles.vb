Imports System.Data.SqlClient

Public Class FormRoles
    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Dim frmInsertarRol As New frmInsertarRol(Me)
        frmInsertarRol.Show()

        If frmInsertarRol.IsDisposed Then
            Cargardatos()
        End If
    End Sub

    Private Sub FormRoles_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Cargardatos()
    End Sub
    Public Sub Cargardatos()
        Try
            dgvRoles.Rows.Clear()
            Dim blRol As New BLRol
            Dim listRol As List(Of Roles) = blRol.ConsultarRoles()
            Dim i As Integer = 1

            For x = 0 To listRol.Count - 1 Step 1
                dgvRoles.Rows.Add(listRol(x).Id, listRol(x).Nombre)
            Next


        Catch ex As Exception
            MsgBox(ex.Message & " FORM ROLES")
        End Try
    End Sub


End Class