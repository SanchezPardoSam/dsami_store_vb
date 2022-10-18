Public Class frmInsertarProveedor
    Private padre As FormProveedores
    Private blProveedor As New BLProveedor
    Private blEmpresa As New BLEmpresa
    Private blPais As New BLPais
    Private blDocumento As New BLDocumento
    Private blRegion As New BLRegion
    Private blProvincia As New BLProvincia
    Private blDistrito As New BLDistrito

    Private listaPais As New List(Of Pais)
    Private listaRegiones As New List(Of Region)
    Private listaProvincias As New List(Of Provincia)
    Private listaDistritos As New List(Of Distrito)

    Dim codigo As String
    Public Sub New(padre As FormProveedores)
        Me.padre = padre
        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub
    Private Sub frmInsertarProveedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim listaEmpresa = blEmpresa.ConsultarEmpresa()

        cbxEmpresa.Text = "Selecionar empresa"

        For x = 0 To listaEmpresa.Count - 1 Step 1
            cbxEmpresa.Items.Add(listaEmpresa(x).RazonSocial)
        Next

        Dim listaPais = blPais.ConsultarPais()
        cbxPais.Text = "Selecionar pais"
        For x = 0 To listaPais.Count - 1 Step 1
            cbxPais.Items.Add(listaPais(x).Nombre)
        Next

        Dim listaDocumento = blDocumento.ConsultarDocumentos()
        cbxTipoDocumento.Text = "Selecionar documento"
        For x = 0 To listaDocumento.Count - 1 Step 1
            cbxTipoDocumento.Items.Add(listaDocumento(x).Nombre)
        Next

        cbxRegion.Text = "Selecionar region"
        cbxProvincia.Text = "Selecionar provincia"
        cbxDistrito.Text = "Selecionar distrito"

    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Try


            Dim prov As New Proveedor()
            prov.Nombre = txtName.Text
            prov.ApellidoMaterno = txtApellidoMaterno.Text
            prov.ApellidoPaterno = txtApellidoPaterno.Text
            prov.Documento = txtDocumento.Text
            prov.Tipo = ObtenerIdDocumento(cbxTipoDocumento.SelectedItem.ToString())
            prov.Empresa = ObtenerIdEmpresa(cbxEmpresa.SelectedItem.ToString())
            prov.Pais = ObtenerIdPais(cbxPais.SelectedItem.ToString())
            prov.Region = cbxRegion.SelectedItem.ToString()
            prov.Provincia = cbxProvincia.SelectedItem.ToString()
            prov.Distrito = ObtenerIdDistrito(cbxDistrito.SelectedItem.ToString(), cbxProvincia.SelectedItem.ToString())
            prov.Direccion = txtDireccion.Text
            prov.FechaNacimiento = dtpNacimiento.Value

            blProveedor.InsertarProveedor(prov)

            padre.Cargardatos()
            Me.Close()

            blProveedor.ConsultarProveedor()
        Catch ex As Exception
            MsgBox(ex.Message & "/insertar")
        End Try
    End Sub

    Private Sub cbxPais_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxPais.SelectedIndexChanged
        Dim pais As String = cbxPais.SelectedItem.ToString()

        listaPais = blPais.ConsultarPais()
        For x = 0 To listaPais.Count - 1 Step 1
            If pais = listaPais(x).Nombre Then

                listaRegiones = blRegion.ConsultarRegion(listaPais(x).Id)

            End If
        Next

        If listaRegiones.Count = 0 Then
            MsgBox("Valor de pais incorrecto")
        Else
            For x = 0 To listaRegiones.Count - 1 Step 1
                cbxRegion.Items.Add(listaRegiones(x).Nombre_Region)
            Next
        End If


    End Sub
    Private Sub cbxRegion_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxRegion.SelectedIndexChanged
        Dim region As String = cbxRegion.SelectedItem.ToString()

        For x = 0 To listaRegiones.Count - 1 Step 1
            If region = listaRegiones(x).Nombre_Region Then

                listaProvincias = blProvincia.ConsultarProvincias(listaRegiones(x).Id_Region)

            End If
        Next

        If listaProvincias.Count = 0 Then
            MsgBox("Valor de pais incorrecto")
        Else
            For x = 0 To listaProvincias.Count - 1 Step 1
                cbxProvincia.Items.Add(listaProvincias(x).Nombre_Provincia)
            Next
        End If
    End Sub

    Private Sub cbxProvincia_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxProvincia.SelectedIndexChanged
        Dim provincia As String = cbxProvincia.SelectedItem.ToString()

        For x = 0 To listaProvincias.Count - 1 Step 1
            If provincia = listaProvincias(x).Nombre_Provincia Then
                codigo = listaProvincias(x).Id_Provincia
                listaDistritos = blDistrito.ConsultarDistritos(listaProvincias(x).Id_Provincia)

            End If
        Next

        If listaDistritos.Count = 0 Then
            MsgBox("Valor de pais incorrecto")
        Else
            For x = 0 To listaDistritos.Count - 1 Step 1
                cbxDistrito.Items.Add(listaDistritos(x).Nombre)
            Next
        End If
    End Sub

    Private Function ObtenerIdDocumento(nombre As String) As String
        Dim listDocumento As List(Of Documento)
        listDocumento = blDocumento.ConsultarDocumentos()

        For x = 0 To listDocumento.Count - 1 Step 1
            If listDocumento(x).Nombre = nombre Then
                Return listDocumento(x).Id
            Else
                Return ""
            End If
        Next
        Return ""
    End Function

    Private Function ObtenerIdPais(nombre As String) As String

        listaPais = blPais.ConsultarPais()

        For x = 0 To listaPais.Count - 1 Step 1
            If listaPais(x).Nombre = nombre Then
                Return listaPais(x).Id
            Else
                Return ""
            End If
        Next
        Return ""
    End Function

    Private Function ObtenerIdEmpresa(nombre As String) As String
        Dim listEmpresa As List(Of Empresa)
        listEmpresa = blEmpresa.ConsultarEmpresa()
        MsgBox(nombre)
        For x = 0 To listEmpresa.Count - 1 Step 1
            If listEmpresa(x).RazonSocial = nombre Then
                MsgBox(listEmpresa(x).Id)
                Return listEmpresa(x).Id

            Else
                Return ""
            End If
        Next
        Return ""
    End Function

    Private Function ObtenerIdDistrito(nombre As String, cod As String) As String
        MsgBox(cod)
        listaDistritos = blDistrito.ConsultarDistritos(codigo)

        For x = 0 To listaDistritos.Count - 1 Step 1
            If listaDistritos(x).Nombre = nombre Then
                Return listaDistritos(x).Id
            Else
                Return ""
            End If
        Next
        Return ""
    End Function

    Private Sub dtpNacimiento_ValueChanged(sender As Object, e As EventArgs) Handles dtpNacimiento.ValueChanged
        MsgBox(dtpNacimiento.Value)
    End Sub
End Class