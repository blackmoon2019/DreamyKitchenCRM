Imports System.Drawing.Printing

Public Class RepCUSOrderCloset2ndPage
    Private Sub GroupHeader1_BeforePrint(sender As Object, e As PrintEventArgs)
        If Detail1.Report.RowCount = 0 Then e.Cancel = True
    End Sub


    Private Sub GroupHeader2_BeforePrint(sender As Object, e As PrintEventArgs) Handles GroupHeader2.BeforePrint
        If Detail2.Report.RowCount = 0 Then e.Cancel = True
    End Sub
End Class