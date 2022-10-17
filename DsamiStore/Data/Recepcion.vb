Public Class Recepcion
    Private _id As String
    Private _empleado As String
    Private _proveedor As String
    Private _fechaPedido As Date
    Private _fechaRespuesta As Date
    Private _estado As Integer

    Public Sub New(id As String, empleado As String, proveedor As String, fechaPedido As Date, fechaRespuesta As Date, estado As Integer)
        _id = id
        _empleado = empleado
        _proveedor = proveedor
        _fechaPedido = fechaPedido
        _fechaRespuesta = fechaRespuesta
        _estado = estado
    End Sub

    Public Property Id As String
        Get
            Return _id
        End Get
        Set(value As String)
            _id = value
        End Set
    End Property

    Public Property Empleado As String
        Get
            Return _empleado
        End Get
        Set(value As String)
            _empleado = value
        End Set
    End Property

    Public Property Proveedor As String
        Get
            Return _proveedor
        End Get
        Set(value As String)
            _proveedor = value
        End Set
    End Property

    Public Property FechaPedido As Date
        Get
            Return _fechaPedido
        End Get
        Set(value As Date)
            _fechaPedido = value
        End Set
    End Property

    Public Property FechaRespuesta As Date
        Get
            Return _fechaRespuesta
        End Get
        Set(value As Date)
            _fechaRespuesta = value
        End Set
    End Property

    Public Property Estado As Integer
        Get
            Return _estado
        End Get
        Set(value As Integer)
            _estado = value
        End Set
    End Property
End Class
