Public Class RecepcionDetalle
    Private idRecepcionDetalle As String
    Private idRecepcion As String
    Private idProducto As String

    Private precioRecepcion As Double
    Private cantidadRecepcion As Integer

    Private recepcion As Recepcion
    Private producto As Producto

    Public Property Id_RecepcionDetalle As String
        Get
            Return idRecepcionDetalle
        End Get
        Set(value As String)
            idRecepcionDetalle = value
        End Set
    End Property

    Public Property Id_Recepcion As String
        Get
            Return idRecepcion
        End Get
        Set(value As String)
            idRecepcion = value
        End Set
    End Property

    Public Property Id_Producto As String
        Get
            Return idProducto
        End Get
        Set(value As String)
            idProducto = value
        End Set
    End Property

    Public Property Precio_Recepcion As Double
        Get
            Return precioRecepcion
        End Get
        Set(value As Double)
            precioRecepcion = value
        End Set
    End Property

    Public Property Cantidad_Recepcion As Integer
        Get
            Return cantidadRecepcion
        End Get
        Set(value As Integer)
            cantidadRecepcion = value
        End Set
    End Property

    Public Property Recepcion_RecepcionDetalle As Recepcion
        Get
            Return recepcion
        End Get
        Set(value As Recepcion)
            recepcion = value
        End Set
    End Property

    Public Property Producto_RecepcionDetalle As Producto
        Get
            Return producto
        End Get
        Set(value As Producto)
            producto = value
        End Set
    End Property

    Public Sub New(idRecepcionDetalle As String, idRecepcion As String, idProducto As String, precioRecepcion As Double, cantidadRecepcion As Integer)
        Me.idRecepcionDetalle = idRecepcionDetalle
        Me.idRecepcion = idRecepcion
        Me.idProducto = idProducto
        Me.precioRecepcion = precioRecepcion
        Me.cantidadRecepcion = cantidadRecepcion
    End Sub

    Public Sub New()
    End Sub
End Class
