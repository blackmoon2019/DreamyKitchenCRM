Public Class frmSplash
    Sub New
        InitializeComponent()
        Me.labelCopyright.Text = "Copyright © 2020-" & DateTime.Now.Year.ToString()
        Me.lblVer.Text = "V " & My.Application.Info.Version.ToString
    End Sub



    Public Enum SplashScreenCommand
        SomeCommandId
    End Enum
End Class
