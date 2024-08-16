Imports System.Configuration
Imports System.Data.SqlClient

Public Class DatabaseController

    Dim SqlConnection As New SqlConnection
    Dim SqlQuerys As New SqlCommand

    Public Sub New()
        Dim SqlServerName As String = ConfigurationManager.ConnectionStrings("DBConnectionString").ConnectionString

        SqlConnection = New SqlConnection()

    End Sub

    Public Function ExecuteQuery(sqlQuery As String)
        Try
            SqlConnection.Open()

            SqlQuerys = New SqlCommand(sqlQuery, SqlConnection)

            Dim resultado As SqlDataReader = SqlQuerys.ExecuteReader()

            If resultado.HasRows Then
                Dim resultadoAuxiliar As SqlDataReader = resultado

                SqlConnection.Close()

                Return resultadoAuxiliar
            Else
                Return Nothing
            End If

        Catch ex As Exception
            Console.WriteLine(ex.Message)

            Return Nothing
        End Try

    End Function

End Class
