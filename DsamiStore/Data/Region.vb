Public Class Region
    Private idRegion As String
    Private nombreRegion As String
    Private idPais As String
    Private pais As Pais

    Public Property Id_Region As String
        Get
            Return idRegion
        End Get
        Set(value As String)
            idRegion = value
        End Set
    End Property

    Public Property Nombre_Region As String
        Get
            Return nombreRegion
        End Get
        Set(value As String)
            nombreRegion = value
        End Set
    End Property

    Public Property Id_Pais As String
        Get
            Return idPais
        End Get
        Set(value As String)
            idPais = value
        End Set
    End Property

    Public Property Pais_Region As Pais
        Get
            Return pais
        End Get
        Set(value As Pais)
            pais = value
        End Set
    End Property

    Public Sub New(idRegion As String, nombreRegion As String, idPais As String)
        Me.idRegion = idRegion
        Me.nombreRegion = nombreRegion
        Me.idPais = idPais
    End Sub

    Public Sub New()
    End Sub
End Class
