Public Class Empleado
    Inherits Persona
    Private idEmpleado As String

    Private direccion As String
    Private tipoDocumento As String
    Private numeroDocumento As String

    Private idRegion As String
    Private idDistrito As String
    Private idProvincia As String


    Public Sub New(idEmpleado As String, direccion As String, tipoDocumento As String,
                   numeroDocumento As String, idRegion As String, idDistrito As String,
                   idProvincia As String, codigoPersona As String, nombrePersona As String,
                   apellidoPaterno As String, apellidoMaterno As String, codigoDocumento As String,
                   fechaNacimiento As Date, codigoPais As String)

        MyBase.New(codigoPersona, nombrePersona, apellidoPaterno, apellidoMaterno, codigoDocumento,
                   fechaNacimiento, codigoPais)

        Me.idEmpleado = idEmpleado

        Me.direccion = direccion
        Me.tipoDocumento = tipoDocumento
        Me.numeroDocumento = numeroDocumento
        Me.idRegion = idRegion
        Me.idDistrito = idDistrito
        Me.idProvincia = idProvincia

    End Sub


    Public Sub New()
        MyBase.New()
    End Sub


    Public Property Id_Empleado As String
        Get
            Return idEmpleado
        End Get
        Set(value As String)
            idEmpleado = value
        End Set
    End Property



    Public Property Direccion_Empleado As String
        Get
            Return direccion
        End Get
        Set(value As String)
            direccion = value
        End Set
    End Property

    Public Property Tipo_Documento As String
        Get
            Return tipoDocumento
        End Get
        Set(value As String)
            tipoDocumento = value
        End Set
    End Property

    Public Property Numero_Documento As String
        Get
            Return numeroDocumento
        End Get
        Set(value As String)
            numeroDocumento = value
        End Set
    End Property

    Public Property Id_Region As String
        Get
            Return idRegion
        End Get
        Set(value As String)
            idRegion = value
        End Set
    End Property

    Public Property Id_Distrito As String
        Get
            Return idDistrito
        End Get
        Set(value As String)
            idDistrito = value
        End Set
    End Property

    Public Property Id_Provincia As String
        Get
            Return idProvincia
        End Get
        Set(value As String)
            idProvincia = value
        End Set
    End Property

End Class
