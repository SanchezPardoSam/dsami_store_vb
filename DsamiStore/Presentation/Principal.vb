
Imports FontAwesome.Sharp

Public Class Principal
	Private Button As IconButton

	Private BorderButton As Panel

	Private CurrentForm As Form
	Public Sub New()

		' Esta llamada es exigida por el diseñador.
		InitializeComponent()
		BorderButton = New Panel()
		BorderButton.Size = New Size(8, 50)
		PanelMenu.Controls.Add(BorderButton)
		' Agregue cualquier inicialización después de la llamada a InitializeComponent().

	End Sub
	Public Sub buttonActive(senderBtn As Object, customColor As Color)
		If senderBtn IsNot Nothing Then
			buttonDesactive()
			Button = CType(senderBtn, IconButton)
			Button.BackColor = customColor
			Button.ForeColor = Color.White
			Button.IconColor = Color.White

			Button.TextAlign = ContentAlignment.MiddleCenter
			Button.ImageAlign = ContentAlignment.MiddleLeft
			Button.TextImageRelation = TextImageRelation.TextBeforeImage

			BorderButton.BackColor = Color.White
			BorderButton.Location = New Point(0, Button.Location.Y)
			BorderButton.Visible = True
			BorderButton.BringToFront()
		End If
	End Sub
	Public Sub buttonDesactive()
		If Button IsNot Nothing Then
			Button.BackColor = Color.FromArgb(248, 249, 250)
			Button.ForeColor = Color.Black
			Button.IconColor = Color.Green
			Button.TextAlign = ContentAlignment.MiddleCenter
			Button.ImageAlign = ContentAlignment.MiddleLeft
			Button.TextImageRelation = TextImageRelation.ImageBeforeText
			BorderButton.BackColor = Color.FromArgb(34, 197, 94)
		End If

	End Sub

	Private Sub openForm(childForm As Form)
		If CurrentForm IsNot Nothing Then
			CurrentForm.Close()
		End If
		CurrentForm = childForm
		childForm.TopLevel = False
		childForm.Dock = DockStyle.Fill
		childForm.FormBorderStyle = FormBorderStyle.None

		panelSecciones.Controls.Add(childForm)
		panelSecciones.Tag = childForm
		childForm.BringToFront()
		childForm.Show()


	End Sub

	Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click
		buttonActive(sender, Color.FromArgb(34, 197, 94))
		openForm(New FormCategoria)
	End Sub
	Private Sub IconButton2_Click(sender As Object, e As EventArgs) Handles IconButton2.Click
		buttonActive(sender, Color.FromArgb(34, 197, 94))
		openForm(New FormProveedores)
	End Sub

	Private Sub IconButton3_Click(sender As Object, e As EventArgs) Handles IconButton3.Click
		buttonActive(sender, Color.FromArgb(34, 197, 94))
		openForm(New FormProductos)
	End Sub

	Private Sub IconButton4_Click(sender As Object, e As EventArgs) Handles IconButton4.Click
		buttonActive(sender, Color.FromArgb(34, 197, 94))
		openForm(New FormUsuarios)
	End Sub

	Private Sub IconButton5_Click(sender As Object, e As EventArgs) Handles IconButton5.Click
		buttonActive(sender, Color.FromArgb(34, 197, 94))
		openForm(New FormRoles)
	End Sub

	Private Sub IconButton6_Click(sender As Object, e As EventArgs) Handles IconButton6.Click
		buttonActive(sender, Color.FromArgb(34, 197, 94))
		openForm(New FormEmpleados)
	End Sub

	Private Sub IconButton7_Click(sender As Object, e As EventArgs) Handles IconButton7.Click

	End Sub

	Private Sub Principal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

	End Sub
End Class