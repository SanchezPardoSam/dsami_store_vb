Imports System.Data.SqlClient

Public Class Empresa
    Inherits Conexion
    Private _id As String
    Private _ruc As String
    Private _razonSocial As String
    Private _ubicacion As String

    Private cmd As SqlCommand
    Private dr As SqlDataReader

    Public Sub New()
    End Sub

    Public Sub New(id As String, Optional ruc As String = Nothing, Optional razonSocial As String = Nothing, Optional ubicacion As String = Nothing)
        _id = id
        _ruc = ruc
        _razonSocial = razonSocial
        _ubicacion = ubicacion
    End Sub

    Public Property Id As String
        Get
            Return _id
        End Get
        Set(value As String)
            _id = value
        End Set
    End Property

    Public Property Ruc As String
        Get
            Return _ruc
        End Get
        Set(value As String)
            _ruc = value
        End Set
    End Property

    Public Property RazonSocial As String
        Get
            Return _razonSocial
        End Get
        Set(value As String)
            _razonSocial = value
        End Set
    End Property

    Public Property Ubicacion As String
        Get
            Return _ubicacion
        End Get
        Set(value As String)
            _ubicacion = value
        End Set
    End Property

    Public Function ConsultarEmpresa() As List(Of Empresa)
        Try
            Dim listEmp As List(Of Empresa)
            listEmp = New List(Of Empresa)
            Dim i As Integer = 0
            conectar()
            cmd = New SqlCommand("sp_empresa_listar")

            cmd.Connection = con

            dr = cmd.ExecuteReader

            If dr.HasRows Then
                While dr.Read
                    i += 1
                    listEmp.Add(New Empresa(
                                dr.Item("i_id_empresa"),
                                dr.Item("v_ruc_empresa"),
                                dr.Item("v_razon_social_empresa"),
                                dr.Item("i_id_ubicacion")
                    ))
                End While

                Return listEmp
            Else
                Return Nothing
            End If

        Catch ex As Exception
            MsgBox(ex.Message & " Empresa")
            Return Nothing
        Finally
            con.Close()
        End Try
    End Function
End Class
