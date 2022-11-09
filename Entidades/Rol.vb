Imports System.Data.SqlClient

Public Class Rol
    Private _id As String
    Private _nombre As String

    Public Property Nombre As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            _nombre = value
        End Set
    End Property

    Public Property Id As String
        Get
            Return _id
        End Get
        Set(value As String)
            _id = value
        End Set
    End Property

    Public Sub New(cod As String, nom As String)
        Nombre = nom
        Id = cod
    End Sub

    Public Sub New()

    End Sub
End Class
