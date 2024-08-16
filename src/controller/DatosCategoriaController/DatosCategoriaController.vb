Imports System.Data.SqlClient

Public Class DatosCategoriaController
    Private Property DatabaseController As DatabaseController

    Public Sub New()
        DatabaseController = New DatabaseController()
    End Sub

    Public Function GetDatosCategoria(idCategoria As Integer, idContacto As Integer)
        Try
            Dim datosCategoria As New Object()

            Select Case idCategoria
                'Empleado
                Case 1
                    datosCategoria = GetDatosEmpleado(idContacto)

                'Cliente
                Case 2
                    datosCategoria = GetDatosCliente(idContacto)

                'Proveedor
                Case 3
                    datosCategoria = GetDatosProveedor(idContacto)

            End Select

            Return datosCategoria
        Catch ex As Exception
            Console.WriteLine(ex.Message)

            Return Nothing
        End Try
    End Function

    Private Function GetDatosEmpleado(idContacto As Integer) As DatosEmpleado
        Dim datosEmpleado As New DatosEmpleado()

        Dim sqlQuery As String = $"SELECT * FROM DatosEmpleado WHERE IdContacto = {idContacto}"

        Dim queryResults = DatabaseController.ExecuteQuery(sqlQuery)

        If queryResults Is Nothing Then
            Return datosEmpleado

            Exit Function
        Else
            Dim resultado As SqlDataReader = queryResults

            resultado.Read()

            Dim idDatosEmpleado As Integer = resultado("IdDatosEmpleado")
            Dim curp As String = resultado("Curp").ToString()
            Dim contraseniaDb As String = resultado("Contrasenia").ToString()

            Return datosEmpleado
        End If
    End Function

    Private Function GetDatosCliente(idContacto As Integer) As DatosCliente
        Dim datosCliente As New DatosCliente()

        Dim sqlQuery As String = $""

        Return datosCliente
    End Function

    Private Function GetDatosProveedor(idContacto As Integer) As DatosProveedor
        Dim datosProveedor As New DatosProveedor()

        Dim sqlQuery As String = $""

        Return datosProveedor
    End Function
End Class
