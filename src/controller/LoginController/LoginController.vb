Imports System.Data.SqlClient

Public Class LoginController
    Private Property DatabaseController As DatabaseController

    Public Sub New()
        DatabaseController = New DatabaseController()
    End Sub

    Public Function ValidarCredenciales(nombreUsuario As String, contrasenia As String) As String
        Dim usuario As Usuario

        Dim sqlQuery As String = $"SELECT * FROM Usuario WHERE NombreUsuario = '{nombreUsuario}';"

        Try
            Dim queryResults = DatabaseController.ExecuteQuery(sqlQuery)

            If queryResults Is Nothing Then
                Return "unknown_user"

                Exit Function
            Else
                Dim resultado As SqlDataReader = queryResults

                resultado.Read()

                Dim idUsuario As Integer = resultado("IdUsuario")
                Dim nombreUsuarioDb As String = resultado("NombreUsuario").ToString()
                Dim contraseniaDb As String = resultado("Contrasenia").ToString()

                If contrasenia = contraseniaDb Then
                    usuario = New Usuario(idUsuario, nombreUsuarioDb, contrasenia)

                    DatosGlobales.UsuarioIngresado = usuario

                    DatabaseController.CloseConnection()

                    Return "access_granted"
                Else
                    Return "wrong_password"
                End If
            End If
        Catch ex As Exception
            Console.WriteLine(ex.Message)

            Return "unknown_error"
        End Try

    End Function
End Class
