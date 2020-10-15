Imports System.ComponentModel
Imports DevExpress.XtraScheduler

Public Class frmCalendar
    Private Calendar As New InitializeCalendar
    Private Sub frmCalendar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DreamyKitchenDataSet.vw_SALERS' table. You can move, or remove it, as needed.
        Me.Vw_SALERSTableAdapter.Fill(Me.DreamyKitchenDataSet.vw_SALERS)
        Dim sSQL As String
        sSQL = "SELECT * FROM vw_CCT_M order by code"
        Calendar.Initialize(SchedulerControl1, SchedulerDataStorage1, sSQL)

    End Sub

    Private Sub SchedulerDataStorage1_AppointmentsInserted(sender As Object, e As PersistentObjectsEventArgs) Handles SchedulerDataStorage1.AppointmentsInserted

    End Sub

    Private Sub frmCalendar_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing

    End Sub

    Private Sub SchedulerControl1_Click(sender As Object, e As EventArgs) Handles SchedulerControl1.Click

    End Sub
End Class