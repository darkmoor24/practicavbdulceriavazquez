Imports System.Data.SqlClient

Public Class NumeroTelefonoController
    Private Property DatabaseController As DatabaseController

    Public Sub New()
        DatabaseController = New DatabaseController()
    End Sub

    Public Function GetNumerosTelefonoContacto(idContacto As Integer)
        Dim listaNumerosTelefono As New ArrayList()

        Try
            Dim sqlQuery As String = $"SELECT * FROM NumeroTelefono WHERE IdContacto = {idContacto};"

            Dim queryResults As SqlDataReader = DatabaseController.ExecuteQuery(sqlQuery)

            While queryResults.Read()
                Dim idNumeroTelefono As Integer = queryResults("IdNumeroTelefono")

                Dim numero As String = queryResults("NumeroTelefono")

                Dim tipoNumeroTelefono As String = queryResults("Tipo")

                Dim numeroTelefono As New NumeroTelefono(idNumeroTelefono, numero, tipoNumeroTelefono)

                listaNumerosTelefono.Add(numeroTelefono)
            End While

            Return listaNumerosTelefono
        Catch ex As Exception
            Return Nothing
        End Try

    End Function
End Class
