
Public Class frmInputBox
    Private FillCbo As New FillCombos
    Private sID As String
    Private sOffers As New List(Of String)
    Public WriteOnly Property ID As String
        Set(value As String)
            sID = value
        End Set
    End Property
    Public ReadOnly Property SubOffers() As List(Of String)
        Get
            Return sOffers
        End Get
    End Property

    Private Sub frmInputBox_Load(sender As Object, e As EventArgs) Handles Me.Load
        FillCbo.FillCheckedListSubOff(chklstSubOffs, " where offid = " & toSQLValueS(sID))
    End Sub

    Private Sub cmdExit_Click(sender As Object, e As EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub

    Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click
        sOffers.Clear()
        For Each item As DevExpress.XtraEditors.Controls.CheckedListBoxItem In chklstSubOffs.CheckedItems
            sOffers.Add(item.Tag.ToString())
        Next
        Me.Close()
    End Sub
End Class