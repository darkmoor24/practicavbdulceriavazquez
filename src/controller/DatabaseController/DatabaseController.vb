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

    Public Function ExecuteStoredProcedure(storedProcedureName As String, parameters As Dictionary(Of String, SqlParameter)) As SqlDataReader
        Using SqlConnection
            Using SqlQuerys As New SqlCommand(storedProcedureName, SqlConnection)
                SqlQuerys.CommandType = CommandType.StoredProcedure

                If parameters IsNot Nothing Then
                    For Each param In parameters
                        SqlQuerys.Parameters.Add(param.Value)
                    Next
                End If

                Try
                    SqlConnection.Open()

                    Dim resultado As SqlDataReader = SqlQuerys.ExecuteReader()

                    If storedProcedureName.Contains("Eliminar") Then
                        Return Nothing
                    End If

                    Console.WriteLine(resultado.HasRows)

                    If resultado.HasRows Then
                        Console.WriteLine("devolviendo resultado satisfactorio: ")
                        Console.WriteLine(resultado)

                        Return resultado
                    Else
                        Console.WriteLine("devolviendo nada: ")

                        Return Nothing
                    End If
                Catch ex As Exception
                    Console.WriteLine(ex.Message)

                    Return Nothing
                End Try

            End Using
        End Using
    End Function

    Public Sub CloseConnection()
        SqlConnection.Close()
    End Sub

End Class
