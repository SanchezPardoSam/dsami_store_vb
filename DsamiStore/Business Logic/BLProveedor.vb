﻿Public Class BLProveedor
    Dim dataProveedor As New Proveedor()
    Public Function ConsultarProveedor() As List(Of Proveedor)
        Try
            Dim listaProveedor As List(Of Proveedor) = dataProveedor.ConsultarProveedor()
            Return listaProveedor

        Catch ex As Exception
            MsgBox(ex.Message & " BLProveedor")
            Return Nothing
        End Try
    End Function

    Public Function ConsultarProveedorID(codigo As String) As Proveedor
        Try
            Dim prov As Proveedor = dataProveedor.ConsultarProveedorID(codigo)
            Return prov

        Catch ex As Exception
            MsgBox(ex.Message & " BLProveedor")
            Return Nothing
        End Try
    End Function

    Public Function InsertarProveedor(prov As Proveedor)
        If dataProveedor.InsertarProveedor(prov) = True Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function EditarProveedor(prov As Proveedor)
        If dataProveedor.EditarProveedor(prov) = True Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function EliminarProveedor(cod As String)
        If dataProveedor.EliminarProveedor(cod) = True Then
            Return True
        Else
            Return False
        End If
    End Function
End Class
