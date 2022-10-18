Imports System
Imports System.Collections.Generic
Imports Microsoft.VisualBasic

Public Class BLCategoria
    Public Function ConsultarCategorias() As List(Of Categoria)

        Try
            Dim dc As New Categoria

            Dim lc As List(Of Categoria) = dc.

            Return lr

        Catch ex As Exception
            MsgBox(ex.Message & "BLCategoria")
            Return Nothing
        End Try
    End Function
End Class
