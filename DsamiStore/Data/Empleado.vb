Imports System.Data.SqlClient

Public Class Empleado
    Inherits Persona
    Private idEmpleado As String

    Private direccion As String
    Private tipoDocumento As String
    Private numeroDocumento As String

    Private idRegion As String
    Private idDistrito As String
    Private idProvincia As String

    Private cmd As SqlCommand
    Private dr As SqlDataReader

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

    Public Function ConsultarEmpleado() As List(Of Empleado)
        Try
            Dim empleados As List(Of Empleado) = New List(Of Empleado)
            Dim i As Integer = 0

            conectar()

            cmd = New SqlCommand("sp_empleado_listar")

            cmd.Connection = con

            dr = cmd.ExecuteReader

            If dr.HasRows Then
                While dr.Read
                    i += 1
                    empleados.Add(New Empleado(
                                 dr.Item("i_id_empleado"),
                                 dr.Item("v_direccion_ubicacion"),
                                 dr.Item("v_nombre_tipo_documento"),
                                 dr.Item("v_valor_documento"),
                                 dr.Item("i_id_region"),
                                 dr.Item("i_id_distrito"),
                                 dr.Item("i_id_provincia"),
                        dr.Item("i_id_persona"),
                        dr.Item("v_nombre_persona"),
                        dr.Item("v_apellido_paterno_persona"),
                        dr.Item("v_apellido_materno_persona"),
                        dr.Item("i_id_documento"),
                        dr.Item("d_fecha_nacimiento_persona"),
                        dr.Item("i_id_pais")
                                   ))
                End While

                Return empleados
            Else
                Return Nothing
            End If

        Catch ex As Exception
            MsgBox(ex.Message & " EMPLEADO")
            Return Nothing
        Finally
            con.Close()
        End Try
    End Function

    Public Function EncontrarEmpleadosCantidad(consulta As String, limite As Integer) As Integer
        Try
            Dim listClien As List(Of Roles)
            listClien = New List(Of Roles)
            Dim i As Integer = 0
            conectar()
            cmd = New SqlCommand("sp_empleado_listar_paginacion_count @consulta, @limite")
            cmd.Parameters.AddWithValue("@consulta", consulta)
            cmd.Parameters.AddWithValue("@limite", limite)

            cmd.Connection = con

            Return cmd.ExecuteScalar()

        Catch ex As Exception
            MsgBox(ex.Message & " EMPLEADO")
            Return Nothing
        Finally
            con.Close()
        End Try
    End Function

    Public Function EncontrarEmpleados(consulta As String, pagina As Integer, limite As Integer) As List(Of Empleado)
        Try
            Dim empleados As List(Of Empleado) = New List(Of Empleado)
            Dim i As Integer = 0

            conectar()

            cmd = New SqlCommand("sp_empleado_listar_paginacion @consulta, @pagina, @limite")
            cmd.Parameters.AddWithValue("@consulta", consulta)
            cmd.Parameters.AddWithValue("@pagina", pagina)
            cmd.Parameters.AddWithValue("@limite", limite)

            cmd.Connection = con

            dr = cmd.ExecuteReader

            If dr.HasRows Then
                While dr.Read
                    i += 1
                    empleados.Add(New Empleado(
                                 dr.Item("i_id_empleado"),
                                 dr.Item("v_direccion_ubicacion"),
                                 dr.Item("v_nombre_tipo_documento"),
                                 dr.Item("v_valor_documento"),
                                 dr.Item("i_id_region"),
                                 dr.Item("i_id_distrito"),
                                 dr.Item("i_id_provincia"),
                        dr.Item("i_id_persona"),
                        dr.Item("v_nombre_persona"),
                        dr.Item("v_apellido_paterno_persona"),
                        dr.Item("v_apellido_materno_persona"),
                        dr.Item("i_id_documento"),
                        dr.Item("d_fecha_nacimiento_persona"),
                        dr.Item("i_id_pais")
                                   ))
                End While

                Return empleados
            Else
                Return Nothing
            End If

        Catch ex As Exception
            MsgBox(ex.Message & " EMPLEADO")
            Return Nothing
        Finally
            con.Close()
        End Try
    End Function

End Class
