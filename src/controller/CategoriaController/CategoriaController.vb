Imports System.Data.SqlClient

Public Class CategoriaController
    Private Property DatabaseController As DatabaseController

    Public Sub New()
        DatabaseController = New DatabaseController()
    End Sub

    Public Function GetCategoriasContacto()
        Try
            Dim categoriasContacto As New ArrayList()

            Dim sqlQuery As String = "SELECT * FROM Categoria;"

            Dim queryResults As SqlDataReader = DatabaseController.ExecuteQuery(sqlQuery)

            While queryResults.Read()
                Dim categoria As New Categoria(queryResults("IdCategoria"), queryResults("Nombre"))

                categoriasContacto.Add(categoria)
            End While

            DatabaseController.CloseConnection()

            Return categoriasContacto
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

End Class