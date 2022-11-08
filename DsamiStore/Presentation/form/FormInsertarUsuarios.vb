Imports Negocio

Public Class FormInsertarUsuarios
    Private _usuarioNegocio As New UsuarioNegocio
    Private _rolNegocio As New RolNegocio
    Private _empleadoNegocio As New BLEmpleado

    Dim padre As FormUsuarios

    Private listaRol As New List(Of Roles)
    Private listaEmpleado As New List(Of Empleado)

    Private dtRol As New DataTable()
    Private dtEmpleado As New DataTable()

    Public Sub New(padre As FormUsuarios)
        Me.padre = padre

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        dtRol.Columns.Add("id")
        dtRol.Columns.Add("nombre")
        cbxRolAgregarUsuario.DataSource = dtRol
        cbxRolAgregarUsuario.ValueMember = "id"
        cbxRolAgregarUsuario.DisplayMember = "nombre"

        dtEmpleado.Columns.Add("id")
        dtEmpleado.Columns.Add("nombre")
        cbxEmpleadoAgregarUsuarios.DataSource = dtEmpleado
        cbxEmpleadoAgregarUsuarios.ValueMember = "id"
        cbxEmpleadoAgregarUsuarios.DisplayMember = "nombre"
    End Sub

    Private Sub frmInsertarUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim roles = _rolNegocio.ConsultarRoles()
        For x = 0 To roles.Count - 1 Step 1
            dtRol.Rows.Add(roles(x).Id, roles(x).Nombre)

        Next
        Dim empleados = _empleadoNegocio.ConsultarEmpleado()
        For x = 0 To empleados.Count - 1 Step 1
            dtEmpleado.Rows.Add(empleados(x).Id_Empleado, empleados(x).Nombre & " " & empleados(x).ApellidoPaterno)
        Next
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAceptarAgregarUsuario.Click
        Try

            _usuarioNegocio.InsertarUsuario("R001", txtNombreAgregarUsuario.Text, txtClaveAgregarUsuario.Text, cbxEmpleadoAgregarUsuarios.SelectedItem.Row.Item("id"), cbxRolAgregarUsuario.SelectedItem.Row.Item("id"))

            padre.Cargardatos()

            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message & "/insertar")
        End Try
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelarAgregarUsuario.Click
        Me.Close()
    End Sub
End Class