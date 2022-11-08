Imports Datos
Imports Entidades

Public Class EmpleadoNegocio
    Private _empleadoDato As New EmpleadoDato

    Public Function ConsultarEmpleado() As List(Of Empleado)
        Try
            Dim empleados As List(Of Empleado) = _empleadoDato.ConsultarEmpleado()

            Return empleados
        Catch ex As Exception
            MsgBox(ex.Message & " BLEMPLEADO")
            Return Nothing
        End Try
    End Function

    Public Function ObtenerEmpleadosCantidad(consulta As String, limite As Integer) As Integer
        Try
            Dim cantidad As Integer = _empleadoDato.EncontrarEmpleadosCantidad(consulta, limite)

            Return cantidad
        Catch ex As Exception
            MsgBox(ex.Message & " BLEMPLEADO")
            Return Nothing
        End Try
    End Function

    Public Function ObtenerEmpleados(consulta As String, pagina As Integer, limite As Integer) As List(Of Empleado)
        Try
            Dim empleados As List(Of Empleado) = _empleadoDato.EncontrarEmpleados(consulta, pagina, limite)

            Return empleados
        Catch ex As Exception
            MsgBox(ex.Message & " BLEMPLEADO")
            Return Nothing
        End Try
    End Function

End Class
