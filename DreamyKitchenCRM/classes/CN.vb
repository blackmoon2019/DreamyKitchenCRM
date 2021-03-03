Imports System.Configuration
Imports System.Data.SqlClient

Public Class CN

    Dim s As String = AppDomain.CurrentDomain.SetupInformation.ConfigurationFile
    'Private connStr As String = "Server = tcp:blackmoon.database.windows.net,1433;Initial Catalog=DreamyKitchen;Persist Security Info=False;User ID=blmoon;Password=mavros1!;MultipleActiveResultSets=True;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;"
    Private connStr As String = ConfigurationManager.ConnectionStrings("myConnectionString").ConnectionString

    Public Function OpenConnection() As Boolean
        Dim DBConnection As New SqlConnection()
        Try
            connStr = "Password=Dr3@mySA;Persist Security Info=True;User ID=dreamy;Initial Catalog=DreamyKitchen;Data Source=10.10.5.7,1433;MultipleActiveResultSets=True"
            DBConnection.ConnectionString = connStr
            DBConnection.Open()

            If DBConnection.State = ConnectionState.Open Then
                CNDB = DBConnection
                Return True
            Else
                DBConnection.Close()
                Return False
            End If
        Catch ex As Exception
            MessageBox.Show(String.Format("Error: {0}", ex.Message))
            Return False
        End Try
    End Function

End Class
