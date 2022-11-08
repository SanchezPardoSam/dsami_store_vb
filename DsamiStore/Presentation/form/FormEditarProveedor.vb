Imports Entidades
Imports Negocio

Public Class FormEditarProveedor
    Private _proveedorNegocio As New ProveedorNegocio
    Private _documentoNegocio As New DocumentoNegocio
    Private _empresaNegocio As New EmpresaNegocio

    Private padre As FormProveedores
    Private blProveedor As New ProveedorNegocio
    Private blEmpresa As New EmpresaNegocio
    Private blPais As New PaisNegocio
    Private blDocumento As New DocumentoNegocio
    Private blRegion As New RegionNegocio
    Private blProvincia As New ProvinciaNegocio
    Private blDistrito As New DistritoNegocio

    Private listaPais As New List(Of Pais)
    Private listaRegiones As New List(Of Region)
    Private listaProvincias As New List(Of Provincia)
    Private listaDistritos As New List(Of Distrito)

    Private dtEmpresa As New DataTable()
    Private dtTipoDocumento As New DataTable()
    Private dtPais As New DataTable()
    Private dtRegion As New DataTable()
    Private dtProvincia As New DataTable()
    Private dtDistrito As New DataTable()

    Private proveedor As Proveedor

    Dim codigo As String

    Public Sub New(padre As FormProveedores)
        Me.padre = padre

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        dtEmpresa.Columns.Add("id")
        dtEmpresa.Columns.Add("nombre")
        cbxEmpresa.DataSource = dtEmpresa
        cbxEmpresa.ValueMember = "id"
        cbxEmpresa.DisplayMember = "nombre"

        dtTipoDocumento.Columns.Add("id")
        dtTipoDocumento.Columns.Add("nombre")
        cbxTipoDocumento.DataSource = dtTipoDocumento
        cbxTipoDocumento.ValueMember = "id"
        cbxTipoDocumento.DisplayMember = "nombre"

        dtPais.Columns.Add("id")
        dtPais.Columns.Add("nombre")
        cbxPais.DataSource = dtPais
        cbxPais.ValueMember = "id"
        cbxPais.DisplayMember = "nombre"

        dtRegion.Columns.Add("id")
        dtRegion.Columns.Add("nombre")
        cbxRegion.DataSource = dtRegion
        cbxRegion.ValueMember = "id"
        cbxRegion.DisplayMember = "nombre"

        dtProvincia.Columns.Add("id")
        dtProvincia.Columns.Add("nombre")
        cbxProvincia.DataSource = dtProvincia
        cbxProvincia.ValueMember = "id"
        cbxProvincia.DisplayMember = "nombre"

        dtDistrito.Columns.Add("id")
        dtDistrito.Columns.Add("nombre")
        cbxDistrito.DataSource = dtDistrito
        cbxDistrito.ValueMember = "id"
        cbxDistrito.DisplayMember = "nombre"

    End Sub

    Private Sub FormEditarProveedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim codigo As String = padre.dgvProveedores.CurrentRow.Cells.Item(0).Value
        proveedor = _proveedorNegocio.ConsultarProveedorID(codigo)

        Console.WriteLine("")
        Console.WriteLine(codigo)
        Console.WriteLine(proveedor.Id)
        Console.WriteLine(proveedor.Empresa)
        Console.WriteLine(proveedor.Tipo)
        Console.WriteLine(proveedor.Pais)

        txtName.Text = proveedor.Nombre
        txtApellidoPaterno.Text = proveedor.ApellidoPaterno
        txtApellidoMaterno.Text = proveedor.ApellidoMaterno

        txtDocumento.Text = proveedor.Documento
        txtDireccion.Text = proveedor.Direccion

        Dim empresas = blEmpresa.ConsultarEmpresa()
        For x = 0 To empresas.Count - 1 Step 1
            dtEmpresa.Rows.Add(empresas(x).Id, empresas(x).RazonSocial)

            If proveedor.Empresa = empresas(x).RazonSocial Then
                cbxEmpresa.SelectedIndex = x
            End If
        Next

        Dim tipoDocumentos = blDocumento.ConsultarDocumentos()
        For x = 0 To tipoDocumentos.Count - 1 Step 1
            dtTipoDocumento.Rows.Add(tipoDocumentos(x).Id, tipoDocumentos(x).Nombre)

            If proveedor.Tipo = tipoDocumentos(x).Nombre Then
                cbxTipoDocumento.SelectedIndex = x
            End If
        Next

        Dim paises = blPais.ConsultarPais()
        For x = 0 To paises.Count - 1 Step 1
            dtPais.Rows.Add(paises(x).Id, paises(x).Nombre)

            If proveedor.Pais = paises(x).Nombre Then
                cbxPais.SelectedIndex = x

                If paises.Count = 0 Then
                Else
                    ObtenerRegiones(paises(x).Id)
                End If
            End If
        Next
    End Sub

    Public Sub ObtenerPais(codigo As String)
        Dim paises = blPais.ConsultarPais()
        For x = 0 To paises.Count - 1 Step 1
            dtPais.Rows.Add(paises(x).Id, paises(x).Nombre)
        Next

        If paises.Count = 0 Then
        Else
            'cbxPais.SelectedIndex = 0

            ObtenerRegiones(paises.Item(0).Id)
        End If

    End Sub

    Public Sub ObtenerRegiones(codigo As String)
        Dim regiones = blRegion.ConsultarRegion(codigo)
        For x = 0 To regiones.Count - 1 Step 1
            dtRegion.Rows.Add(regiones(x).Id_Region, regiones(x).Nombre_Region)

            If proveedor.Region = regiones(x).Nombre_Region Then
                cbxRegion.SelectedIndex = x

                If regiones.Count = 0 Then
                Else
                    ObtenerProvincias(regiones(x).Id_Region)
                End If
            End If
        Next
    End Sub

    Public Sub ObtenerProvincias(codigo As String)
        Dim provincias = blProvincia.ConsultarProvincias(codigo)
        For x = 0 To provincias.Count - 1 Step 1
            dtProvincia.Rows.Add(provincias(x).Id_Provincia, provincias(x).Nombre_Provincia)

            If proveedor.Provincia = provincias(x).Nombre_Provincia Then
                cbxProvincia.SelectedIndex = x

                If provincias.Count = 0 Then
                Else
                    ObtenerDistritos(provincias(x).Id_Provincia)
                End If
            End If

        Next
    End Sub


    Public Sub ObtenerDistritos(codigo As String)
        Dim distritos = blDistrito.ConsultarDistritos(codigo)
        For x = 0 To distritos.Count - 1 Step 1
            dtDistrito.Rows.Add(distritos(x).Id, distritos(x).Nombre)

            If proveedor.Distrito = distritos(x).Nombre Then
                cbxDistrito.SelectedIndex = x
            End If

        Next
    End Sub

    Private Sub cbxTipoDocumento_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxTipoDocumento.SelectedIndexChanged

    End Sub

    Private Sub cbxPais_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxPais.SelectedIndexChanged
        If cbxPais.SelectedItem Is Nothing Then
            Return
        End If

        Dim paisId As String = cbxPais.SelectedItem.Row.Item("id")

        listaRegiones = blRegion.ConsultarRegion(paisId)

        dtRegion.Rows.Clear()

        If listaRegiones.Count = 0 Then
            MsgBox("Valor de pais incorrecto")
        Else
            For x = 0 To listaRegiones.Count - 1 Step 1
                dtRegion.Rows.Add(listaRegiones(x).Id_Region, listaRegiones(x).Nombre_Region)
            Next
        End If
    End Sub
    Private Sub cbxRegion_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxRegion.SelectedIndexChanged
        If cbxRegion.SelectedItem Is Nothing Then
            Return
        End If

        Dim regionId As String = cbxRegion.SelectedItem.Row.Item("id")

        listaProvincias = blProvincia.ConsultarProvincias(regionId)

        dtProvincia.Rows.Clear()

        If listaProvincias.Count = 0 Then
            MsgBox("Valor de pais incorrecto")
        Else
            For x = 0 To listaProvincias.Count - 1 Step 1
                dtProvincia.Rows.Add(listaProvincias(x).Id_Provincia, listaProvincias(x).Nombre_Provincia)
            Next
        End If
    End Sub

    Private Sub cbxProvincia_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxProvincia.SelectedIndexChanged
        If cbxProvincia.SelectedItem Is Nothing Then
            Return
        End If

        Dim provinciaId As String = cbxProvincia.SelectedItem.Row.Item("id")

        codigo = provinciaId
        listaDistritos = blDistrito.ConsultarDistritos(provinciaId)

        dtDistrito.Rows.Clear()

        If listaDistritos.Count = 0 Then
            MsgBox("Valor de pais incorrecto")
        Else
            For x = 0 To listaDistritos.Count - 1 Step 1
                dtDistrito.Rows.Add(listaDistritos(x).Id, listaDistritos(x).Nombre)
            Next
        End If
    End Sub

    Private Sub dtpNacimiento_ValueChanged(sender As Object, e As EventArgs) Handles dtpNacimiento.ValueChanged
        MsgBox(dtpNacimiento.Value)
    End Sub

    Private Sub cbxEmpresa_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxEmpresa.SelectedIndexChanged

    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Try

            Dim codigo As String = padre.dgvProveedores.CurrentRow.Cells.Item(0).Value

            Dim prov As New Proveedor()
            prov.Id = codigo
            prov.Nombre = txtName.Text
            prov.ApellidoMaterno = txtApellidoMaterno.Text
            prov.ApellidoPaterno = txtApellidoPaterno.Text
            prov.Documento = txtDocumento.Text
            prov.Tipo = cbxTipoDocumento.SelectedItem.Row.Item("id")
            prov.Empresa = cbxEmpresa.SelectedItem.Row.Item("id")
            prov.Pais = cbxPais.SelectedItem.Row.Item("id")
            prov.Region = cbxRegion.SelectedItem.ToString()
            prov.Provincia = cbxProvincia.SelectedItem.ToString()
            prov.Distrito = cbxDistrito.SelectedItem.Row.Item("id")
            prov.Direccion = txtDireccion.Text
            prov.FechaNacimiento = dtpNacimiento.Value

            blProveedor.EditarProveedor(prov)

            padre.Cargardatos()

            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message & "/insertar")
        End Try
    End Sub


    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub
End Class