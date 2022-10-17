Imports System.Security.Principal

Public Class Form1
    Private _usuarioNegocio As BLUsuario = New BLUsuario()

    Private Shared panelInicio As Form1

    Private CurrentForm As Form

    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

        tbClave.PasswordChar = "*"
    End Sub
    Public Function getInstance() As Form1
        If panelInicio Is Nothing Then
            Return New Form1
        Else
            Return panelInicio
        End If
    End Function

    Public Sub openForm(childForm As Form)
        If CurrentForm IsNot Nothing Then
            CurrentForm.Close()
        End If

        CurrentForm = childForm
        childForm.TopLevel = False
        childForm.Dock = DockStyle.Fill
        childForm.FormBorderStyle = FormBorderStyle.None

        panelPrincipalIncio.Controls.Add(childForm)
        panelPrincipalIncio.Tag = childForm
        childForm.BringToFront()
        childForm.Show()


    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If tbNombreUsuario.Text = "" Or tbClave.Text = "" Then
            MsgBox("Complete todos los campos")
            Return
        End If

        Try
            Dim usuario As Usuario = _usuarioNegocio.Ingresar(tbNombreUsuario.Text, tbClave.Text)

            Dim prin As New Principal

            openForm(prin)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
