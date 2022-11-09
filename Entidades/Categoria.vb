
Public Class Categoria
    Private _id As String
    Private _nombre As String
    Private _descripcion As String

    Public Sub New()
    End Sub

    Public Sub New(id As String, nombre As String, descripcion As String)
        Me._id = id
        Me._nombre = nombre
        Me._descripcion = descripcion
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

    Public Property Descripcion As String
        Get
            Return _descripcion
        End Get
        Set(value As String)
            _descripcion = value
        End Set
    End Property
End Class
