Imports System.ComponentModel
Imports System.Drawing.Printing

Public Class RepCUSOrderKitchen2ndPage

    Private Sub GroupHeader1_BeforePrint(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles GroupHeader1.BeforePrint
        If Detail1.Report.RowCount = 0 Then e.Cancel = True
    End Sub
    Private Sub GroupHeader2_BeforePrint(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles GroupHeader2.BeforePrint
        If Detail2.Report.RowCount = 0 Then e.Cancel = True
    End Sub

    Private Sub GroupHeader3_BeforePrint(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles GroupHeader3.BeforePrint
        If Detail3.Report.RowCount = 0 Then e.Cancel = True
    End Sub

    Private Sub Detail1_BeforePrint(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles Detail1.BeforePrint
        If Detail1.Report.RowCount = 0 Then e.Cancel = True
    End Sub

    Private Sub Detail2_BeforePrint(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles Detail2.BeforePrint
        If Detail2.Report.RowCount = 0 Then e.Cancel = True
    End Sub

    Private Sub Detail3_BeforePrint(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles Detail3.BeforePrint
        If Detail3.Report.RowCount = 0 Then e.Cancel = True
    End Sub

    Private Sub DetailReport3_BeforePrint(sender As Object, e As CancelEventArgs) Handles DetailReport3.BeforePrint
        If Detail1.Report.RowCount = 0 Then e.Cancel = False Else e.Cancel = True
    End Sub
End Class