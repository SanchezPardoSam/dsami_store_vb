Imports System.Data.SqlClient

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

End Class
