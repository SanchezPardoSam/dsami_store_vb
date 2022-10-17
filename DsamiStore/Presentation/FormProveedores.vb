Public Class FormProveedores
    Private Sub FormProveedores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Cargardatos()
    End Sub

    Public Sub Cargardatos()
        Try
            dgvProveedores.Rows.Clear()
            Dim blProvee As New BLProveedor
            Dim listProvee As List(Of Proveedor) = blProvee.ConsultarProveedor()
            Dim i As Integer = 1

            For x = 0 To listProvee.Count - 1 Step 1
                dgvProveedores.Rows.Add((x + 1).ToString(), listProvee(x).ApellidoPaterno,
                                        listProvee(x).Ruc, listProvee(x).Empresa)
            Next


        Catch ex As Exception
            MsgBox(ex.Message & " FORM ROLES")
        End Try
    End Sub
End Class