Imports System.Data.SqlClient

Public Class ContactoController

    Private Property DatabaseController As DatabaseController

    Public Sub New()
        DatabaseController = New DatabaseController()
    End Sub

    Public Function GetContactosByIdUsuario(idUsuario As Integer)
        Try
            Dim contactos As New ArrayList()

            Dim sqlQuery As String = $"SELECT * FROM ViewContactos WHERE IdUsuario = {idUsuario};"

            Dim queryResults As SqlDataReader = DatabaseController.ExecuteQuery(sqlQuery)

            While queryResults.Read()
                Dim contacto As Contacto = LlenarContacto(queryResults)

                contactos.Add(contacto)
            End While

            Return contactos

        Catch ex As Exception
            Return Nothing
        End Try

    End Function

    Public Function LlenarContacto(queryResults As SqlDataReader)



        Dim contacto As New Contacto()

        Return contacto
    End Function

End Class
