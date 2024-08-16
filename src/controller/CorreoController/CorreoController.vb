Imports System.Data.SqlClient

Public Class CorreoController
    Private Property DatabaseController As DatabaseController

    Public Sub New()
        DatabaseController = New DatabaseController()
    End Sub

    Public Function GetCorreosContacto(idContacto As Integer)
        Dim listaCorreos As New ArrayList()

        Try
            Dim sqlQuery = $"SELECT * FROM Correo WHERE IdContacto = {idContacto};"

            Dim queryResults = DatabaseController.ExecuteQuery(sqlQuery)

            If queryResults Is Nothing Then
                Return Nothing

                Exit Function
            Else
                Dim resultados As SqlDataReader = queryResults

                While resultados.Read()
                    Dim idCorreo As Integer = resultados("IdCorreo")

                    Dim direccionCorreo As String = resultados("Correo")

                    Dim correo As New Correo(idCorreo, direccionCorreo)

                    listaCorreos.Add(correo)
                End While

                DatabaseController.CloseConnection()

                Return listaCorreos

            End If

        Catch ex As Exception
            Console.WriteLine(ex.Message)

            Return Nothing
        End Try

    End Function
End Class
