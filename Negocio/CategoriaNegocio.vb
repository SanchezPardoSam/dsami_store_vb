Imports Datos
Imports Entidades

Public Class CategoriaNegocio
    Private _categoriaDato As New CategoriaDato

    Public Function InsertarCategoria(codigo As String, nombre As String, descripcion As String)
        Dim categoria As New Categoria(codigo, nombre, descripcion)

        If _categoriaDato.InsertarCategoria(categoria) = True Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function ActualizarCategoria(codigo As String, nombre As String, descripcion As String)
        Dim categoria As New Categoria(codigo, nombre, descripcion)

        If _categoriaDato.ActualizarCategoria(categoria) = True Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function EliminarCategoria(codigo As String)
        If _categoriaDato.EliminarCategoria(codigo) = True Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function ConsultarCategoria() As List(Of Categoria)

        Try
            Dim listaCategoria As List(Of Categoria) = _categoriaDato.ConsultarCategoria()

            Return listaCategoria

        Catch ex As Exception
            MsgBox(ex.Message & " BLCATEGORIA")
            Return Nothing
        End Try
    End Function

    Public Function ObtenerCategoriasCantidad(consulta As String, limite As Integer) As Integer
        Try
            Dim cantidad As Integer = _categoriaDato.EncontrarCategoriasCantidad(consulta, limite)

            Return cantidad
        Catch ex As Exception
            MsgBox(ex.Message & " BLCATEGORIA")
            Return Nothing
        End Try
    End Function

    Public Function ObtenerCategorias(consulta As String, pagina As Integer, limite As Integer) As List(Of Categoria)
        Try
            Dim categorias As List(Of Categoria) = _categoriaDato.EncontrarCategorias(consulta, pagina, limite)

            Return categorias
        Catch ex As Exception
            MsgBox(ex.Message & " BLCATEGORIA")
            Return Nothing
        End Try
    End Function
End Class
