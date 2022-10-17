Imports System.Security.Principal

Public Class Form1
    Dim user As String = "adm"
    Dim pass As String = "adm"

    Private Shared panelInicio As Form1

    Private CurrentForm As Form

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

        If txtUsername.Text = "" Or txtPassword.Text = "" Then
            MsgBox("Complete todos los campos")

        ElseIf txtUsername.Text <> user Or txtPassword.Text <> pass Then
            MsgBox("El usuario o contraseña incorrecto")

        Else
            Dim prin As New Principal
            openForm(prin)
        End If
    End Sub


End Class
