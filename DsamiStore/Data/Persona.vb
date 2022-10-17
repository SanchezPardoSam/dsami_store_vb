Public Class Persona
    Inherits Conexion
    Private _codigo As String
    Private _nombre As String
    Private _apellidoPaterno As String
    Private _apellidoMaterno As String
    Private _codigoDocumento As String
    Private _fechaNacimiento As Date
    Private _ubicacion As String
    Private _pais As Pais

    Public Sub New(codigo As String, nombre As String, Optional apellidoPaterno As String = Nothing, Optional apellidoMaterno As String = Nothing, Optional codigoDocumento As String = Nothing, Optional fechaNacimiento As Date = Nothing, Optional ubicacion As String = Nothing, Optional pais As Pais = Nothing)
        _codigo = codigo
        _nombre = nombre
        _apellidoPaterno = apellidoPaterno
        _apellidoMaterno = apellidoMaterno
        _codigoDocumento = codigoDocumento
        _fechaNacimiento = fechaNacimiento
        _ubicacion = ubicacion
        _pais = pais
    End Sub

    Public Sub New()
    End Sub

    Public Property Codigo As String
        Get
            Return _codigo
        End Get
        Set(value As String)
            _codigo = value
        End Set
    End Property

    Public Property Nombre As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            _nombre = value
        End Set
    End Property

    Public Property ApellidoPaterno As String
        Get
            Return _apellidoPaterno
        End Get
        Set(value As String)
            _apellidoPaterno = value
        End Set
    End Property

    Public Property ApellidoMaterno As String
        Get
            Return _apellidoMaterno
        End Get
        Set(value As String)
            _apellidoMaterno = value
        End Set
    End Property

    Public Property CodigoDocumento As String
        Get
            Return _codigoDocumento
        End Get
        Set(value As String)
            _codigoDocumento = value
        End Set
    End Property

    Public Property FechaNacimiento As Date
        Get
            Return _fechaNacimiento
        End Get
        Set(value As Date)
            _fechaNacimiento = value
        End Set
    End Property

    Public Property Ubicacion As String
        Get
            Return _ubicacion
        End Get
        Set(value As String)
            _ubicacion = value
        End Set
    End Property

    Public Property Pais As Pais
        Get
            Return _pais
        End Get
        Set(value As Pais)
            _pais = value
        End Set
    End Property
End Class
