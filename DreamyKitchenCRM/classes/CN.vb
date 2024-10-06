Imports System.Configuration
Imports System.Data.SqlClient

Public Class CN

    Dim s As String = AppDomain.CurrentDomain.SetupInformation.ConfigurationFile
    'Private connStr As String = "Server = tcp:blackmoon.database.windows.net,1433;Initial Catalog=DreamyKitchen;Persist Security Info=False;User ID=blmoon;Password=mavros1!;MultipleActiveResultSets=True;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;"
    'Private connStr As String = ConfigurationManager.ConnectionStrings("myConnectionString").ConnectionString
    'Private connStr As String = ConfigurationManager.ConnectionStrings("myConnectionString").ConnectionString
    Private connStr As String = My.Settings.DreamyKitchenConnectionStringRemotely.ToString
    'Private connStr As String = My.Settings.DreamyKitchenConnectionStringRemotelyLocal.ToString

    Public Function OpenConnection() As Boolean
        Dim DBConnection As New SqlConnection()
        Try
            ' connStr = "Password=Dr3@mySA;Persist Security Info=True;User ID=dreamy;Initial Catalog=DreamyKitchen;Data Source=10.10.5.7,1433;MultipleActiveResultSets=True"
            If My.Settings.PROD = False Then
                connStr = "Data Source=10.10.5.7,1433;Initial Catalog=DreamyKitchenDEV;Persist Security Info=True;User ID=sa;Password=Dr3@mySA;MultipleActiveResultSets=True;Encrypt=False;TrustServerCertificate=True"
            Else
                connStr = "Data Source=10.10.5.7,1433;Initial Catalog=DreamyKitchen;Persist Security Info=True;User ID=sa;Password=Dr3@mySA;MultipleActiveResultSets=True;Encrypt=False;TrustServerCertificate=True"
            End If
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
    Public Function OpenConnectionWithParam(ByVal Servername As String, ByVal authentication As String,
                                           ByVal Login As String, ByVal Pwd As String, Optional ByVal Database As String = "") As Boolean
        Dim DBConnection As New SqlConnection()
        Dim cnSTR As New System.Text.StringBuilder

        If authentication = "True" Then
            cnSTR.Append("Password = " & Pwd & ";")
        Else
            cnSTR.Append("Integrated Security=SSPI;")
        End If
        cnSTR.Append("Persist Security Info=" & authentication & ";")

        If authentication = "True" Then cnSTR.Append("User ID= " & Login & ";")
        If Database <> "" Then cnSTR.Append("Initial Catalog=" & Database & ";")
        cnSTR.Append("Data Source=" & Servername & ";")
        cnSTR.Append("MultipleActiveResultSets = True")

        Try
            DBConnection.ConnectionString = cnSTR.ToString
            DBConnection.Open()

            If DBConnection.State = ConnectionState.Open Then
                CNDB2 = DBConnection
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
