﻿Imports System.Data.SqlClient

Public Class FormRoles
    Private _rolNegocio As BLRol = New BLRol()
    Private _consulta As String = ""
    Private _pagina As Integer = 1
    Private _totalPagina As Integer = 1
    Private _limite As Integer = 5
    Private _dtLimite As New DataTable()

    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

        ' Establecer columnas valor y texto a la tabla
        _dtLimite.Columns.Add("valor")
        _dtLimite.Columns.Add("texto")

        ' Agregar filas conn valor y texto
        _dtLimite.Rows.Add(5, "5 registros")
        _dtLimite.Rows.Add(10, "10 registros")
        _dtLimite.Rows.Add(25, "25 registros")
        _dtLimite.Rows.Add(50, "50 registros")

        ' Establecer tabla al combobox
        cbLimite.DataSource = _dtLimite

        ' Decirle que columna será el valor del combobox
        cbLimite.ValueMember = "valor"
        ' Decirle que columna será el texto del comobobox
        cbLimite.DisplayMember = "texto"

        cbLimite.SelectedIndex = 0

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        tbPagina.Text = _pagina
    End Sub

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


            tbPagina.Text = _pagina


            If _pagina = 1 Then
                btnAnterior.Enabled = False
            Else
                btnAnterior.Enabled = True
            End If

            If _pagina = _totalPagina Then
                btnSiguiente.Enabled = False
            Else
                btnSiguiente.Enabled = True
            End If

            _totalPagina = _rolNegocio.ObtenerRolesCantidad(_consulta, _limite)

            Dim roles As List(Of Roles) = _rolNegocio.ObtenerRoles(_consulta, _pagina, _limite)

            Dim i As Integer = 1

            For x = 0 To roles.Count - 1 Step 1
                dgvRoles.Rows.Add(roles(x).Id, roles(x).Nombre)
            Next


        Catch ex As Exception
            MsgBox(ex.Message & " FORM ROLES")
        End Try
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbLimite.SelectedIndexChanged
        ' Obtener valor del combobox
        _limite = cbLimite.SelectedItem.Row.Item("valor")

        Cargardatos()
    End Sub

    Private Sub btnAnteriorClicked(sender As Object, e As EventArgs) Handles btnAnterior.Click
        _pagina -= 1

        Cargardatos()
    End Sub

    Private Sub btnSiguienteClicked(sender As Object, e As EventArgs) Handles btnSiguiente.Click
        _pagina += 1

        Cargardatos()
    End Sub

    Private Sub btnBuscarClicked(sender As Object, e As EventArgs) Handles btnBuscar.Click
        _consulta = tbBuscar.Text

        Cargardatos()
    End Sub
End Class