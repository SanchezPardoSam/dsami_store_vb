Public Class frmInsertarRol

    Dim padre As FormRoles

    Public Sub New(padre As FormRoles)
        Me.padre = padre

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Try
            Dim blRol As New BLRol
            blRol.InsertarRol("R001", tbNombre.Text)
            padre.cargardatos()
            Me.Close()
            blRol.ConsultarRoles()
        Catch ex As Exception
            MsgBox(ex.Message & "/insertar")
        End Try
    End Sub

    Private Sub frmInsertarRol_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub
End Class