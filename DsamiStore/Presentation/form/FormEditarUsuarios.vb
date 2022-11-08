Imports Entidades
Imports Negocio

Public Class FormEditarUsuarios
    Private _usuarioNegocio As New UsuarioNegocio
    Private _rolNegocio As New RolNegocio
    Private _empleadoNegocio As New EmpleadoNegocio

    Dim padre As FormUsuarios

    Private listaRol As New List(Of Rol)
    Private listaEmpleado As New List(Of Empleado)

    Private dtRol As New DataTable()
    Private dtEmpleado As New DataTable()

    Private usuario As Usuario

    Public Sub New(padre As FormUsuarios)
        Me.padre = padre

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        ' Cargar datos de tabla
        dtRol.Columns.Add("id")
        dtRol.Columns.Add("nombre")
        cbxRolEditarUsuario.DataSource = dtRol
        cbxRolEditarUsuario.ValueMember = "id"
        cbxRolEditarUsuario.DisplayMember = "nombre"

        dtEmpleado.Columns.Add("id")
        dtEmpleado.Columns.Add("nombre")
        cbxEmpleadoEditarUsuarios.DataSource = dtEmpleado
        cbxEmpleadoEditarUsuarios.ValueMember = "id"
        cbxEmpleadoEditarUsuarios.DisplayMember = "nombre"
    End Sub

    Private Sub frmEditarUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim codigo As String = padre.dgvUsuarios.CurrentRow.Cells.Item(0).Value

        usuario = _usuarioNegocio.ObtenerUsuario(codigo)

        Dim roles = _rolNegocio.ConsultarRoles()

        For x = 0 To roles.Count - 1 Step 1
            dtRol.Rows.Add(roles(x).Id, roles(x).Nombre)

            If usuario.Codigo_Rol = roles(x).Id Then
                cbxRolEditarUsuario.SelectedIndex = x
            End If
        Next

        Dim empleados = _empleadoNegocio.ConsultarEmpleado()
        For x = 0 To empleados.Count - 1 Step 1
            dtEmpleado.Rows.Add(empleados(x).Id_Empleado, empleados(x).Nombre & " " & empleados(x).ApellidoPaterno)

            If usuario.Codigo_Empleado = empleados(x).Id_Empleado Then
                cbxEmpleadoEditarUsuarios.SelectedIndex = x
            End If
        Next

        Dim nombreUsuario As String = padre.dgvUsuarios.CurrentRow.Cells.Item(1).Value
        txtNombreEditarUsuario.Text = nombreUsuario
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptarEditarUsuario.Click
        Try
            Dim codigo As String = padre.dgvUsuarios.CurrentRow.Cells.Item(0).Value

            _usuarioNegocio.ActualizarUsuario(codigo, txtNombreEditarUsuario.Text, txtClaveEditarUsuario.Text, cbxRolEditarUsuario.SelectedItem.Row.Item("id"))

            padre.Cargardatos()

            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message & "/editar")
        End Try
    End Sub


    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelarEditarUsuario.Click
        Me.Close()
    End Sub
End Class