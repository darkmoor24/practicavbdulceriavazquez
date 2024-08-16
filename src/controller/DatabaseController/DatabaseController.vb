Imports System.Configuration
Imports System.Data.SqlClient

Public Class DatabaseController

    Dim SqlConnection As New SqlConnection
    Dim SqlQuerys As New SqlCommand

    Public Sub New()
        Dim SqlServerName As String = ConfigurationManager.ConnectionStrings("DBConnectionString").ConnectionString

        Console.WriteLine("SQL Server Name: " & SqlServerName)

        SqlConnection = New SqlConnection(SqlServerName)

    End Sub

    Public Function ExecuteQuery(sqlQuery As String)
        Try
            SqlConnection.Open()

            Console.WriteLine("Ejecutando SQL Query: " & sqlQuery)

            SqlQuerys = New SqlCommand(sqlQuery, SqlConnection)

            Dim resultado As SqlDataReader = SqlQuerys.ExecuteReader()

            If resultado.HasRows Then
                Return resultado
            Else
                Return Nothing
            End If

        Catch ex As Exception
            Console.WriteLine(ex.Message)

            Return Nothing
        End Try

    End Function

    Public Sub CloseConnection()
        SqlConnection.Close()
    End Sub

End Class
