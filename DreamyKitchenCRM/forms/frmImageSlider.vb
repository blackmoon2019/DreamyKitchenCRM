Imports System.Data.SqlClient
Imports System.IO

Public Class frmImageSlider
    Private sID As String
    Private sCCT_ID As String
    Private Splash As DevExpress.XtraSplashScreen.SplashScreenManager
    Public WriteOnly Property ID As String
        Set(value As String)
            sID = value
        End Set
    End Property
    Public WriteOnly Property CCT_ID As String
        Set(value As String)
            sCCT_ID = value
        End Set
    End Property
    Public WriteOnly Property Spl As DevExpress.XtraSplashScreen.SplashScreenManager
        Set(value As DevExpress.XtraSplashScreen.SplashScreenManager)
            Splash = value
        End Set
    End Property
    Private Sub cmdExit_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub frmImageSlider_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim sSQL As String
        Dim cmd As SqlCommand
        Dim sdr As SqlDataReader
        Dim bytes As Byte()

        sSQL = "Select  files From vw_CCT_F WHERE extension IN ('.jpg','.png','.JPG','JPEG','.jpeg') and  cctID = " & toSQLValueS(sCCT_ID)
        cmd = New SqlCommand(sSQL, CNDB) : sdr = cmd.ExecuteReader()
        If sdr.HasRows Then
            While sdr.Read()
                bytes = DirectCast(sdr("files"), Byte())
                Dim stream As New MemoryStream(bytes)
                mySlider.Images.Add(Image.FromStream(stream))
            End While
            sdr.Close()
            sdr = Nothing
            mySlider.Parent = Me
            mySlider.LayoutMode = DevExpress.Utils.Drawing.ImageLayoutMode.Squeeze
            'Slide to the next image
            mySlider.SlideNext()
        End If
        Splash.CloseWaitForm()
    End Sub
End Class