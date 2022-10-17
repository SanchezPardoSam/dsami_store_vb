Public Class Pais
    Private _id As String
    Private _nombre As String

    Public Sub New()
    End Sub

    Public Sub New(id As String, Optional nombre As String = Nothing)
        _id = id
        _nombre = nombre
    End Sub

    Public Property Id As String
        Get
            Return _id
        End Get
        Set(value As String)
            _id = value
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
End Class
