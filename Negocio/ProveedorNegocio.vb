Imports Datos
Imports Entidades

Public Class ProveedorNegocio
    Dim proveedorDato As New ProveedorDato

    Public Function ConsultarProveedor() As List(Of Proveedor)
        Try
            Dim listaProveedor As List(Of Proveedor) = proveedorDato.ConsultarProveedor()
            Return listaProveedor

        Catch ex As Exception
            MsgBox(ex.Message & " BLProveedor")
            Return Nothing
        End Try
    End Function

    Public Function ConsultarProveedorID(codigo As String) As Proveedor
        Try
            Dim prov As Proveedor = proveedorDato.ConsultarProveedorID(codigo)
            Return prov

        Catch ex As Exception
            MsgBox(ex.Message & " BLProveedor")
            Return Nothing
        End Try
    End Function

    Public Function InsertarProveedor(prov As Proveedor)
        If proveedorDato.InsertarProveedor(prov) = True Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function EditarProveedor(prov As Proveedor)
        If proveedorDato.EditarProveedor(prov) = True Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function EliminarProveedor(cod As String)
        If proveedorDato.EliminarProveedor(cod) = True Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function ObtenerProveedoresCantidad(consulta As String, limite As Integer) As Integer
        Try
            Dim cantidad As Integer = proveedorDato.EncontrarProveedoresCantidad(consulta, limite)

            Return cantidad
        Catch ex As Exception
            MsgBox(ex.Message & " BLProveedor")
            Return Nothing
        End Try
    End Function

    Public Function ObtenerProveedores(consulta As String, pagina As Integer, limite As Integer) As List(Of Proveedor)
        Try
            Dim proveedores As List(Of Proveedor) = proveedorDato.EncontrarProveedores(consulta, pagina, limite)

            Return proveedores
        Catch ex As Exception
            MsgBox(ex.Message & " BLProveedor")
            Return Nothing
        End Try
    End Function
End Class
