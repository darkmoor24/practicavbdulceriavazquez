Imports System.Data.SqlClient

Public Class DireccionController
    Private Property DatabaseController As DatabaseController

    Public Sub New()
        DatabaseController = New DatabaseController()
    End Sub

    Public Function GetDireccionContacto(idDireccion As Integer)
        Dim direccion As New Direccion()

        Try
            Dim sqlQuery = $"SELECT * FROM Direccion WHERE IdDireccion = {idDireccion};"

            Dim queryResults = DatabaseController.ExecuteQuery(sqlQuery)

            If queryResults Is Nothing Then
                Return Nothing

                Exit Function
            Else
                Dim resultado As SqlDataReader = queryResults

                resultado.Read()

                Dim calle As String = resultado("Calle")

                Dim numeroInterior As String = resultado("NumeroInterior")

                Dim numeroExterior As String = resultado("NumeroExterior")

                Dim colonia As String = resultado("Colonia")

                Dim localidad As String = resultado("Localidad")

                Dim municipio As String = resultado("Municipio")

                Dim estado As String = resultado("Estado")

                Dim codigoPostal As String = resultado("CodigoPostal")

                Dim tipo As String = resultado("Tipo")

                direccion = New Direccion(idDireccion, calle, numeroInterior, numeroExterior, colonia, localidad, municipio, estado, codigoPostal, tipo)

                DatabaseController.CloseConnection()

                Return direccion
            End If

        Catch ex As Exception
            Console.WriteLine(ex.Message)

            Return Nothing
        End Try

    End Function
End Class
