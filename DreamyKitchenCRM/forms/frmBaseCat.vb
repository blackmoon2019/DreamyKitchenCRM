Public Class frmBaseCat
    Private _BaseCat As Integer
    Public Property BaseCat() As Integer
        Get
            Return _BaseCat
        End Get
        Set(ByVal value As Integer)
            _BaseCat = value
        End Set
    End Property
    Private Sub cmdExit_Click(sender As Object, e As EventArgs) Handles cmdExit.Click
        BaseCat = 3
        Me.Close()
    End Sub

    Private Sub cmdEco_Click(sender As Object, e As EventArgs) Handles cmdEco.Click
        BaseCat = 1
        Me.Close()
    End Sub

    Private Sub cmdPremium_Click(sender As Object, e As EventArgs) Handles cmdPremium.Click
        BaseCat = 2
        Me.Close()
    End Sub
End Class