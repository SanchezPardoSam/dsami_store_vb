Imports System.Data.SqlClient

Public Class Usuario
    Private codigoUsuario As String
    Private nombreUsuario As String
    Private clave As String
    Private codigoEmpleado As String
    Private _nombreEmpleado
    Private _apellidoEmpleado
    Private codigoRol As String
    Private _nombreRol As String

    Public Property Codigo_Usuario As String
        Get
            Return codigoUsuario
        End Get
        Set(value As String)
            codigoUsuario = value
        End Set
    End Property

    Public Property Nombre_Usuario As String
        Get
            Return nombreUsuario
        End Get
        Set(value As String)
            nombreUsuario = value
        End Set
    End Property

    Public Property Clave_Usuario As String
        Get
            Return clave
        End Get
        Set(value As String)
            clave = value
        End Set
    End Property

    Public Property Codigo_Empleado As String
        Get
            Return codigoEmpleado
        End Get
        Set(value As String)
            codigoEmpleado = value
        End Set
    End Property

    Public Property Codigo_Rol As String
        Get
            Return codigoRol
        End Get
        Set(value As String)
            codigoRol = value
        End Set
    End Property


    Public Property NombreEmpleado As Object
        Get
            Return _nombreEmpleado
        End Get
        Set(value As Object)
            _nombreEmpleado = value
        End Set
    End Property

    Public Property ApellidoEmpleado As Object
        Get
            Return _apellidoEmpleado
        End Get
        Set(value As Object)
            _apellidoEmpleado = value
        End Set
    End Property

    Public Property NombreRol As String
        Get
            Return _nombreRol
        End Get
        Set(value As String)
            _nombreRol = value
        End Set
    End Property

    Public Sub New(codigoUsuario As String, nombreUsuario As String, clave As String,
                   codigoEmpleado As String, nombreEmpleado As Object, apellidoEmpleado As Object,
                   codigoRol As String, nombreRol As String)
        Me.codigoUsuario = codigoUsuario
        Me.nombreUsuario = nombreUsuario
        Me.clave = clave
        Me.codigoEmpleado = codigoEmpleado
        _nombreEmpleado = nombreEmpleado
        _apellidoEmpleado = apellidoEmpleado
        Me.codigoRol = codigoRol
        _nombreRol = nombreRol
    End Sub

    Public Sub New()
    End Sub
End Class
