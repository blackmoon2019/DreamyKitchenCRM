Imports System.Drawing.Printing

Public Class RepCUSOrderKitchen2ndPage
    Private Sub GroupHeader1_BeforePrint(sender As Object, e As PrintEventArgs) Handles GroupHeader1.BeforePrint
        If Detail1.Report.RowCount = 0 Then e.Cancel = True
    End Sub

    Private Sub XrLabel3_BeforePrint(sender As Object, e As PrintEventArgs) Handles XrLabel3.BeforePrint
        If Detail1.Report.RowCount = 0 Then e.Cancel = True
    End Sub

    Private Sub XrLabel5_BeforePrint(sender As Object, e As PrintEventArgs) Handles XrLabel5.BeforePrint
        If Detail1.Report.RowCount = 0 Then e.Cancel = True
    End Sub
End Class