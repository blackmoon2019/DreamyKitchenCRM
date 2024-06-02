Imports System.Drawing.Printing

Public Class RepCUSOfferCloset_old


    Private Sub GroupHeader2_BeforePrint(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles GroupHeader2.BeforePrint
        If Detail2.Report.RowCount = 0 Then e.Cancel = True
    End Sub


    Private Sub GroupHeader1_BeforePrint(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles GroupHeader1.BeforePrint
        If Detail1.Report.RowCount = 0 Then e.Cancel = True
    End Sub

    Private Sub SubBand1_BeforePrint(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles SubBand1.BeforePrint
        If XrCheckBox3.Checked = False Then e.Cancel = True
    End Sub

    Private Sub SubBand2_BeforePrint(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles SubBand2.BeforePrint
        If XrCheckBox1.Checked = False Then e.Cancel = True
    End Sub

    Private Sub SubBand3_BeforePrint(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles SubBand3.BeforePrint
        If XrCheckBox7.Checked = False Then e.Cancel = True
    End Sub
End Class