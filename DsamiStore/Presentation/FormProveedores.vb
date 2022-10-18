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
                dgvProveedores.Rows.Add(listProvee(x).Id, listProvee(x).Nombre,
                                        listProvee(x).Documento, listProvee(x).Empresa, listProvee(x).Direccion)
            Next


        Catch ex As Exception
            MsgBox(ex.Message & " FORM ROLES")
        End Try
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Dim frmInsertarProveedor As New frmInsertarProveedor(Me)
        frmInsertarProveedor.Show()

    End Sub

    Private Sub dgvProveedores_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvProveedores.CellClick
        btnEditar.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(94, Byte), Integer))
        btnEliminar.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim form As New FormEliminarProveedor(Me)
        form.Show()
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        Dim form As New FormEditarProveedor(Me)
        form.Show()
    End Sub
End Class