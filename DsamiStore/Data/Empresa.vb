Public Class Empresa
    Private _id As String
    Private _ruc As String
    Private _razonSocial As String
    Private _ubicacion As String

    Public Sub New()
    End Sub

    Public Sub New(id As String, Optional ruc As String = Nothing, Optional razonSocial As String = Nothing, Optional ubicacion As String = Nothing)
        _id = id
        _ruc = ruc
        _razonSocial = razonSocial
        _ubicacion = ubicacion
    End Sub

    Public Property Id As String
        Get
            Return _id
        End Get
        Set(value As String)
            _id = value
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

    Public Property RazonSocial As String
        Get
            Return _razonSocial
        End Get
        Set(value As String)
            _razonSocial = value
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
End Class
