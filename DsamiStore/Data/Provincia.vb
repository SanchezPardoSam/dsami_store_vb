Public Class Provincia
    Private idProvincia As String
    Private nombreProvincia As String
    Private idRegion As String

    Public Property Id_Provincia As String
        Get
            Return idProvincia
        End Get
        Set(value As String)
            idProvincia = value
        End Set
    End Property

    Public Property Nombre_Provincia As String
        Get
            Return nombreProvincia
        End Get
        Set(value As String)
            nombreProvincia = value
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

    Public Sub New()
    End Sub

    Public Sub New(idProvincia As String, nombreProvincia As String, idRegion As String)
        Me.idProvincia = idProvincia
        Me.nombreProvincia = nombreProvincia
        Me.idRegion = idRegion
    End Sub
End Class
