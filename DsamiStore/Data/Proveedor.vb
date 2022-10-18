Imports System.Data.SqlClient
Imports FontAwesome.Sharp

Public Class Proveedor
    Inherits Persona

    Private _id As String
    Private _empresa As String
    Private _direccion As String
    Private _tipo As String
    Private _documento As String
    Private _ruc As String

    Private _pais As String
    Private _region As String
    Private _distrito As String
    Private _provincia As String

    Private cmd As SqlCommand
    Private dr As SqlDataReader

    Public Sub New(id As String, direccion As String, empresa As String, tipo As String,
                   documento As String, pais As String, region As String, distrito As String,
                   provincia As String, ruc As String, codigoPersona As String, nombrePersona As String,
                   apellidoPaterno As String, apellidoMaterno As String, codigoDocumento As String,
                   fechaNacimiento As Date, codigoPais As String)

        MyBase.New(codigoPersona, nombrePersona, apellidoPaterno, apellidoMaterno, codigoDocumento,
                   fechaNacimiento, codigoPais)
        _id = id
        _direccion = direccion
        _empresa = empresa
        _tipo = tipo
        _documento = documento
        _pais = pais
        _region = region
        _distrito = distrito
        _provincia = provincia
        _ruc = ruc
    End Sub
    Public Sub New(nombre As String, paterno As String, materno As String, idTipoDocumento As String,
                   documento As String, nacimiento As Date, idEmpresa As String, idPais As String,
                   idRegion As String, idProvincia As String, idDistrito As String, direccion As String)

        MyBase.New(nombre, paterno, materno, documento, nacimiento, idPais)
        _tipo = idTipoDocumento
        _empresa = idEmpresa
        _region = idRegion
        _provincia = idProvincia
        _distrito = idDistrito
        _direccion = direccion

    End Sub

    Public Sub New()
        MyBase.New()
    End Sub

    Public Property Id As String
        Get
            Return _id
        End Get
        Set(value As String)
            _id = value
        End Set
    End Property

    Public Property Empresa As String
        Get
            Return _empresa
        End Get
        Set(value As String)
            _empresa = value
        End Set
    End Property

    Public Property Direccion As String
        Get
            Return _direccion
        End Get
        Set(value As String)
            _direccion = value
        End Set
    End Property

    Public Property Tipo As String
        Get
            Return _tipo
        End Get
        Set(value As String)
            _tipo = value
        End Set
    End Property

    Public Property Documento As String
        Get
            Return _documento
        End Get
        Set(value As String)
            _documento = value
        End Set
    End Property

    Public Property Pais As String
        Get
            Return _pais
        End Get
        Set(value As String)
            _pais = value
        End Set
    End Property

    Public Property Region As String
        Get
            Return _region
        End Get
        Set(value As String)
            _region = value
        End Set
    End Property

    Public Property Distrito As String
        Get
            Return _distrito
        End Get
        Set(value As String)
            _distrito = value
        End Set
    End Property

    Public Property Provincia As String
        Get
            Return _provincia
        End Get
        Set(value As String)
            _provincia = value
        End Set
    End Property

    Public Property Ruc As String
        Get
            Return _ruc
        End Get
        Set(value As String)
            _ruc = value
        End Set
    End Property

    Public Function ConsultarProveedor() As List(Of Proveedor)
        Try
            Dim listprov As List(Of Proveedor)
            listprov = New List(Of Proveedor)
            Dim i As Integer = 0
            conectar()
            cmd = New SqlCommand("sp_proveedor_listar")

            cmd.Connection = con

            dr = cmd.ExecuteReader

            If dr.HasRows Then
                While dr.Read
                    i += 1
                    listprov.Add(New Proveedor(
                                 dr.Item("i_id_proveedor"),
                                 dr.Item("v_direccion_ubicacion"),
                                 dr.Item("v_razon_social_empresa"),
                                 dr.Item("v_nombre_tipo_documento"),
                                 dr.Item("v_valor_documento"),
                                 dr.Item("v_nombre_pais"),
                                 dr.Item("v_nombre_region"),
                                 dr.Item("v_nombre_distrito"),
                                 dr.Item("v_nombre_provincia"),
                                  dr.Item("v_ruc_empresa"),
                        dr.Item("i_id_persona"),
                        dr.Item("v_nombre_persona"),
                        dr.Item("v_apellido_paterno_persona"),
                        dr.Item("v_apellido_materno_persona"),
                        dr.Item("i_id_documento"),
                        dr.Item("d_fecha_nacimiento_persona"),
                        dr.Item("i_id_pais")
                                   ))
                End While

                Return listprov
            Else
                Return Nothing
            End If

        Catch ex As Exception
            MsgBox(ex.Message & " Proveedor")
            Return Nothing
        Finally
            con.Close()
        End Try
    End Function


    Public Function InsertarProveedor(provee As Proveedor)
        Try

            'cmd.CommandType = CommandType.StoredProcedure
            conectar()

            cmd = New SqlCommand("sp_proveedor_agregar")

            cmd.Connection = con
            cmd.CommandType = CommandType.StoredProcedure
            MsgBox(provee.ToString())
            cmd.Parameters.AddWithValue("@in_v_direccion_ubicacion", SqlDbType.VarChar).Value = provee.Direccion
            Console.WriteLine(provee.Distrito)
            Console.WriteLine("provee.Distrito")
            cmd.Parameters.AddWithValue("@in_i_id_distrito", SqlDbType.VarChar).Value = provee.Distrito
            cmd.Parameters.AddWithValue("@in_v_valor_documento", SqlDbType.VarChar).Value = provee.Documento
            cmd.Parameters.AddWithValue("@in_i_id_tipo_documento", SqlDbType.VarChar).Value = provee.Tipo
            cmd.Parameters.AddWithValue("@in_v_nombre_persona", SqlDbType.VarChar).Value = provee.Nombre

            cmd.Parameters.AddWithValue("@in_v_apellido_paterno_persona", SqlDbType.VarChar).Value = provee.ApellidoPaterno
            cmd.Parameters.AddWithValue("@in_v_apellido_materno_persona", SqlDbType.VarChar).Value = provee.ApellidoMaterno
            Console.WriteLine(provee.ApellidoPaterno)
            Console.WriteLine("provee.ApellidoPaterno")
            cmd.Parameters.AddWithValue("@in_d_fecha_nacimiento_persona", SqlDbType.Date).Value = provee.FechaNacimiento
            cmd.Parameters.AddWithValue("@in_i_id_pais_origen", SqlDbType.VarChar).Value = provee.Pais
            Console.WriteLine(provee.Empresa)
            Console.WriteLine("provee.Empresa")
            cmd.Parameters.AddWithValue("@in_i_id_empresa", SqlDbType.Char).Value = provee.Empresa

            If cmd.ExecuteNonQuery() Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message & " Proveedor")
            Return False
        Finally
            con.Close()
        End Try
    End Function

    Public Function EditarProveedor(provee As Proveedor)
        Try

            'cmd.CommandType = CommandType.StoredProcedure
            conectar()

            cmd = New SqlCommand("sp_proveedor_modificar")

            cmd.Connection = con
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Parameters.AddWithValue("@in_i_id_proveedor", SqlDbType.VarChar).Value = provee.Id

            Console.WriteLine("provee.Distrito")
            Console.WriteLine(provee.Distrito)
            cmd.Parameters.AddWithValue("@in_v_direccion_ubicacion", SqlDbType.VarChar).Value = provee.Direccion
            cmd.Parameters.AddWithValue("@in_i_id_distrito", SqlDbType.VarChar).Value = provee.Distrito
            cmd.Parameters.AddWithValue("@in_v_valor_documento", SqlDbType.VarChar).Value = provee.Documento
            cmd.Parameters.AddWithValue("@in_i_id_tipo_documento", SqlDbType.VarChar).Value = provee.Tipo
            cmd.Parameters.AddWithValue("@in_v_nombre_persona", SqlDbType.VarChar).Value = provee.Nombre

            cmd.Parameters.AddWithValue("@in_v_apellido_paterno_persona", SqlDbType.VarChar).Value = provee.ApellidoPaterno
            cmd.Parameters.AddWithValue("@in_v_apellido_materno_persona", SqlDbType.VarChar).Value = provee.ApellidoMaterno

            cmd.Parameters.AddWithValue("@in_d_fecha_nacimiento_persona", SqlDbType.Date).Value = provee.FechaNacimiento
            cmd.Parameters.AddWithValue("@in_i_id_pais_origen", SqlDbType.VarChar).Value = provee.Pais


            If cmd.ExecuteNonQuery() Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message & " Proveedor")
            Return False
        Finally
            con.Close()
        End Try
    End Function
    Public Function EliminarProveedor(codigo As String)
        Try

            'cmd.CommandType = CommandType.StoredProcedure
            conectar()

            cmd = New SqlCommand("sp_proveedor_eliminar")

            cmd.Connection = con
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Parameters.AddWithValue("@in_i_id_proveedor", SqlDbType.NChar).Value = codigo

            If cmd.ExecuteNonQuery() Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message & " Proveedor")
            Return False
        Finally
            con.Close()
        End Try
    End Function

    Public Function ConsultarProveedorID(codigo As String) As Proveedor
        Try
            Dim prov As Proveedor
            prov = New Proveedor()

            conectar()

            cmd = New SqlCommand("sp_proveedor_buscar @codigo")
            cmd.Parameters.AddWithValue("@codigo", codigo)

            cmd.Connection = con

            dr = cmd.ExecuteReader

            If dr.HasRows Then
                While dr.Read

                    prov = New Proveedor(
                                 dr.Item("i_id_proveedor"),
                                 dr.Item("v_direccion_ubicacion"),
                                 dr.Item("v_razon_social_empresa"),
                                 dr.Item("v_nombre_tipo_documento"),
                                 dr.Item("v_valor_documento"),
                                 dr.Item("v_nombre_pais"),
                                 dr.Item("v_nombre_region"),
                                 dr.Item("v_nombre_distrito"),
                                 dr.Item("v_nombre_provincia"),
                                  dr.Item("v_ruc_empresa"),
                        dr.Item("i_id_persona"),
                        dr.Item("v_nombre_persona"),
                        dr.Item("v_apellido_paterno_persona"),
                        dr.Item("v_apellido_materno_persona"),
                        dr.Item("i_id_documento"),
                        dr.Item("d_fecha_nacimiento_persona"),
                        dr.Item("i_id_pais")
                                   )
                End While

                Return prov
            Else
                Return Nothing
            End If

        Catch ex As Exception
            MsgBox(ex.Message & " Proveedor")
            Return Nothing
        Finally
            con.Close()
        End Try
    End Function
End Class
