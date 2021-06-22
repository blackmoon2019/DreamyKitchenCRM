Public Class frmErmDoorTypes
    Private sID As String
    Public WriteOnly Property ID As String
        Set(value As String)
            sID = value
        End Set
    End Property
    Private Sub frmErmDoorTypes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DreamyKitchenDataSet.vw_DOOR_TYPE' table. You can move, or remove it, as needed.
        Me.Vw_DOOR_TYPETableAdapter.Fill(Me.DreamyKitchenDataSet.vw_DOOR_TYPE)

    End Sub

    Private Sub cmdExit_Click(sender As Object, e As EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub

    Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click
        Dim sSQL As String
        PB.Properties.Maximum = chkDoorTypes.CheckedItems.Count
        PB.Properties.Step = 1
        PB.Properties.PercentView = True
        PB.Properties.Minimum = 0
        PB.EditValue = 0
        PB.Reset()

        ' Καταχώρηση Ερμάρια και σε άλλα πορτάκια
        For Each item As DevExpress.XtraEditors.Controls.CheckedListBoxItem In chkDoorTypes.CheckedItems
            'sSQL = "INSERT INTO OFFER_MECH ([OFFID],[OFFERID],[MECHID],[modifiedBy],[createdOn])  
            '            values (" & toSQLValueS(sID) & "," & toSQLValueS(IIf(sOffersID <> "", sOffersID, sGuid)) & "," & toSQLValueS(item.Tag.ToString()) & "," &
            '                    toSQLValueS(UserProps.ID.ToString) & ", getdate() )"
            'Using oCmd As New SqlCommand(sSQL, CNDB)
            '    oCmd.ExecuteNonQuery()
            'End Using
            PB.PerformStep()
            PB.Update()

        Next
    End Sub
End Class