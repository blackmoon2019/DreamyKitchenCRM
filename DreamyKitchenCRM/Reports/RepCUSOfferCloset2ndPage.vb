﻿Imports System.Drawing.Printing

Public Class RepCUSOfferCloset2ndPage
    Private Sub GroupHeader1_BeforePrint(sender As Object, e As PrintEventArgs) Handles GroupHeader1.BeforePrint
        If Detail1.Report.RowCount = 0 Then e.Cancel = True
    End Sub
    Private Sub GroupHeader3_BeforePrint(sender As Object, e As PrintEventArgs) Handles GroupHeader3.BeforePrint
        If Detail3.Report.RowCount = 0 Then e.Cancel = True
    End Sub

    Private Sub Detail1_BeforePrint(sender As Object, e As PrintEventArgs) Handles Detail1.BeforePrint
        If Detail1.Report.RowCount = 0 Then e.Cancel = True
    End Sub

    Private Sub Detail3_BeforePrint(sender As Object, e As PrintEventArgs) Handles Detail3.BeforePrint
        If Detail3.Report.RowCount = 0 Then e.Cancel = True
    End Sub
End Class