Imports System.Data.SqlClient
Imports Entidades

Public Class CategoriaDato
    Inherits Conexion

    Private cmd As SqlCommand
    Private dr As SqlDataReader

    Public Function InsertarCategoria(categoria As Categoria)
        Try
            conectar()

            Dim sql As String = "sp_categoria_crear @nombre, @descripcion"
            cmd = New SqlCommand(sql, con)
            cmd.Parameters.AddWithValue("@nombre", categoria.Nombre)
            cmd.Parameters.AddWithValue("@descripcion", categoria.Descripcion)

            If cmd.ExecuteNonQuery() Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            MsgBox(ex.Message & "/categoria")
        Finally
            desconectar()
        End Try
    End Function

    Public Function ActualizarCategoria(categoria As Categoria)
        Try
            conectar()

            Dim sql As String = "sp_categoria_actualizar @codigo, @nombre, @descripcion"
            cmd = New SqlCommand(sql, con)
            cmd.Parameters.AddWithValue("@codigo", categoria.Id)
            cmd.Parameters.AddWithValue("@nombre", categoria.Nombre)
            cmd.Parameters.AddWithValue("@descripcion", categoria.Descripcion)

            If cmd.ExecuteNonQuery() Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            MsgBox(ex.Message & "/rol")
        Finally
            desconectar()
        End Try
    End Function

    Public Function EliminarCategoria(codigo As String)
        Try
            conectar()

            Dim sql As String = "sp_categoria_eliminar @codigo"
            cmd = New SqlCommand(sql, con)
            cmd.Parameters.AddWithValue("@codigo", codigo)

            If cmd.ExecuteNonQuery() Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            MsgBox(ex.Message & "/categoria")
        Finally
            desconectar()
        End Try
    End Function

    Public Function ConsultarCategoria() As List(Of Categoria)
        Try
            Dim listCat As List(Of Categoria)
            listCat = New List(Of Categoria)
            Dim i As Integer = 0
            conectar()
            cmd = New SqlCommand("sp_categoria_listar")

            cmd.Connection = con

            dr = cmd.ExecuteReader

            If dr.HasRows Then
                While dr.Read
                    i += 1
                    listCat.Add(New Categoria(dr.Item("i_id_categoria"), dr.Item("v_nombre_categoria"),
                                          dr.Item("v_descripcion_categoria")))
                End While

                Return listCat
            Else
                Return Nothing
            End If

        Catch ex As Exception
            MsgBox(ex.Message & " Categoria")
            Return Nothing
        Finally
            con.Close()
        End Try
    End Function

    Public Function EncontrarCategoriasCantidad(consulta As String, limite As Integer) As Integer
        Try
            Dim listClien As List(Of Rol)
            listClien = New List(Of Rol)
            Dim i As Integer = 0
            conectar()
            cmd = New SqlCommand("sp_categoria_listar_paginacion_count @consulta, @limite")
            cmd.Parameters.AddWithValue("@consulta", consulta)
            cmd.Parameters.AddWithValue("@limite", limite)

            cmd.Connection = con

            Return cmd.ExecuteScalar()

        Catch ex As Exception
            MsgBox(ex.Message & " CATEGORIA")
            Return Nothing
        Finally
            con.Close()
        End Try
    End Function

    Public Function EncontrarCategorias(consulta As String, pagina As Integer, limite As Integer) As List(Of Categoria)
        Try
            Dim categorias As List(Of Categoria) = New List(Of Categoria)
            Dim i As Integer = 0

            conectar()

            cmd = New SqlCommand("sp_categoria_listar_paginacion @consulta, @pagina, @limite")
            cmd.Parameters.AddWithValue("@consulta", consulta)
            cmd.Parameters.AddWithValue("@pagina", pagina)
            cmd.Parameters.AddWithValue("@limite", limite)

            cmd.Connection = con

            dr = cmd.ExecuteReader

            If dr.HasRows Then
                While dr.Read
                    i += 1
                    categorias.Add(New Categoria(dr.Item("i_id_categoria"), dr.Item("v_nombre_categoria"),
                                          dr.Item("v_descripcion_categoria")))
                End While

                Return categorias
            Else
                Return Nothing
            End If

        Catch ex As Exception
            MsgBox(ex.Message & " CATEGORIA")
            Return Nothing
        Finally
            con.Close()
        End Try
    End Function
End Class
