Imports System.Drawing.Printing

Public Class RepCUSOfferKitchen
    Private Sub GroupHeader2_BeforePrint(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles GroupHeader2.BeforePrint
        If Detail2.Report.RowCount = 0 Then e.Cancel = True
    End Sub

    Private Sub GroupHeader1_BeforePrint(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles GroupHeader1.BeforePrint
        If Detail1.Report.RowCount = 0 Then e.Cancel = True
    End Sub

    Private Sub Detail2_BeforePrint(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles Detail2.BeforePrint
        If Detail2.Report.RowCount = 0 Then e.Cancel = True
    End Sub
End Class