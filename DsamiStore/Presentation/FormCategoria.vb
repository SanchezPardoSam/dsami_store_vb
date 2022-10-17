Public Class FormCategoria
    Private Sub FormCategoria_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Cargardatos()
    End Sub
    Public Sub Cargardatos()
        Try
            dgvCategorias.Rows.Clear()
            Dim blCategoria As New BLCategoria
            Dim listCat As List(Of Categoria) = blCategoria.ConsultarCategoria()
            Dim i As Integer = 1

            For x = 0 To listCat.Count - 1 Step 1
                dgvCategorias.Rows.Add(listCat(x).Id, listCat(x).Nombre, listCat(x).Descripcion)
            Next


        Catch ex As Exception
            MsgBox(ex.Message & " FORM ROLES")
        End Try
    End Sub
End Class