Imports System.ComponentModel
Imports DevExpress.XtraScheduler
Imports DevExpress.XtraScheduler.Drawing

Public Class frmCalendar
    Private Calendar As New InitializeCalendar
    Private Sub frmCalendar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DreamyKitchenDataSet.vw_SALERS' table. You can move, or remove it, as needed.
        Me.Vw_SALERSTableAdapter.Fill(Me.DreamyKitchenDataSet.vw_SALERS)
        Dim sSQL As String
        sSQL = "SELECT * FROM vw_CCT_M order by code"
        Calendar.Initialize(SchedulerControl1, SchedulerDataStorage1, sSQL)
        SchedulerControl1.Start = Now.Date
    End Sub

    Private Sub SchedulerDataStorage1_AppointmentsInserted(sender As Object, e As PersistentObjectsEventArgs) Handles SchedulerDataStorage1.AppointmentsInserted

    End Sub

    Private Sub frmCalendar_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing

    End Sub

    Private Sub SchedulerControl1_Click(sender As Object, e As EventArgs) Handles SchedulerControl1.Click

    End Sub

    Private Sub SchedulerDataStorage1_ReminderAlert(sender As Object, e As ReminderEventArgs) Handles SchedulerDataStorage1.ReminderAlert
        'e.AlertNotifications(1).Ignore = True
        'e.AlertNotifications(1).Handled = True
    End Sub

    Private Sub SchedulerControl1_DoubleClick(sender As Object, e As EventArgs) Handles SchedulerControl1.DoubleClick
        Dim form12 As frmCusMov = New frmCusMov()
        For i As Integer = 0 To SchedulerControl1.SelectedAppointments.Count - 1
            Dim apt As Appointment = SchedulerControl1.SelectedAppointments(i)
            Dim form1 As frmCusMov = New frmCusMov()
            form1.Text = "Κινήσεις Πελατών"
            form1.ID = apt.Id
            form1.MdiParent = frmMain
            form1.Mode = FormMode.EditRecord
            form1.FormScrollerExist = False
            form1.Scroller = frmScroller.GridView1
            form1.FormScroller = frmScroller
            frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(form1), New Point(CInt(form1.Parent.ClientRectangle.Width / 2 - form1.Width / 2), CInt(form1.Parent.ClientRectangle.Height / 2 - form1.Height / 2)))
            form1.Show()


        Next i

    End Sub

    Private Sub SchedulerControl1_MouseHover(sender As Object, e As EventArgs) Handles SchedulerControl1.MouseHover

    End Sub

    Private Sub SchedulerControl1_MouseMove(sender As Object, e As MouseEventArgs) Handles SchedulerControl1.MouseMove
        Dim scheduler As DevExpress.XtraScheduler.SchedulerControl = sender

        Dim pos As Point = New Point(e.X, e.Y)
        Dim viewInfo As SchedulerViewInfoBase
        Dim hitInfo As SchedulerHitInfo
        viewInfo = SchedulerControl1.ActiveView.ViewInfo
        hitInfo = viewInfo.CalcHitInfo(pos, False)

        If (hitInfo.HitTest = SchedulerHitTest.AppointmentContent) Then
            scheduler.Cursor = Cursors.Hand
        Else
            scheduler.Cursor = Cursors.Default
        End If
    End Sub
End Class