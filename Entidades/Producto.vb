
Public Class Producto
    Private _id As String
    Private _marca As String
    Private _categoria As String
    Private _imagen As String
    Private _almacen As String
    Private _moneda As String
    Private _nombre As String
    Private _descripcion As String
    Private _barras As String
    Private _precio As Double

    Public Sub New()
    End Sub

    Public Sub New(id As String, marca As String, categoria As String, Optional imagen As String = Nothing, Optional almacen As String = Nothing, Optional moneda As String = Nothing, Optional nombre As String = Nothing, Optional descripcion As String = Nothing, Optional barras As String = Nothing, Optional precio As Double = Nothing)
        _id = id
        _marca = marca
        _categoria = categoria
        _imagen = imagen
        _almacen = almacen
        _moneda = moneda
        _nombre = nombre
        _descripcion = descripcion
        _barras = barras
        _precio = precio
    End Sub

    Public Property Id As String
        Get
            Return _id
        End Get
        Set(value As String)
            _id = value
        End Set
    End Property

    Public Property Marca As String
        Get
            Return _marca
        End Get
        Set(value As String)
            _marca = value
        End Set
    End Property

    Public Property Categoria As String
        Get
            Return _categoria
        End Get
        Set(value As String)
            _categoria = value
        End Set
    End Property

    Public Property Imagen As String
        Get
            Return _imagen
        End Get
        Set(value As String)
            _imagen = value
        End Set
    End Property

    Public Property Almacen As String
        Get
            Return _almacen
        End Get
        Set(value As String)
            _almacen = value
        End Set
    End Property

    Public Property Moneda As String
        Get
            Return _moneda
        End Get
        Set(value As String)
            _moneda = value
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

    Public Property Barras As String
        Get
            Return _barras
        End Get
        Set(value As String)
            _barras = value
        End Set
    End Property

    Public Property Precio As Double
        Get
            Return _precio
        End Get
        Set(value As Double)
            _precio = value
        End Set
    End Property

End Class
