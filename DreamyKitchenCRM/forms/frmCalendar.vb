Imports System.ComponentModel
Imports System.Data.SqlClient
Imports System.Text
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraScheduler
Imports DevExpress.XtraScheduler.Drawing

Public Class frmCalendar
    Private Calendar As New InitializeCalendar
    Private Sub frmCalendar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim sSQL As String
            sSQL = "SELECT * FROM vw_CCT_M WHERE ALLOWSCHEDULE=1 and  completed=0 order by code"
            'Δημιουργία Appointments
            Calendar.Initialize(SchedulerControl1, SchedulerDataStorage1, sSQL)
            sSQL = "SELECT id,name FROM vw_status WHERE ALLOWSCHEDULE=1 order by name"
            Dim cmd As SqlCommand = New SqlCommand(sSQL, CNDB)
            Dim sdr As SqlDataReader = cmd.ExecuteReader()

            While sdr.Read()
                cboStatus.Items.Add(sdr.Item(1).ToString, True)
                cboStatus.Items(sdr.Item(1).ToString).Tag = sdr.Item(0).ToString
                cboStatus.Items(sdr.Item(1).ToString).CheckState = CheckState.Checked

            End While
            cboCompleted.Items.Add("Όχι", True)
            cboCompleted.Items(0).Tag = 0
            cboCompleted.Items(0).CheckState = CheckState.Checked
            cboCompleted.Items.Add("Ναι", True)
            cboCompleted.Items(1).Tag = 1
            cboCompleted.Items(1).CheckState = CheckState.Unchecked


            Me.DreamyKitchenAdapter.Fill(Me.DreamyKitchenDataSet.vw_SALERS)

            SchedulerControl1.Start = Now.Date
            sdr.Close()
        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), "Dreamy Kitchen CRM", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

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
    Private Sub cboCompleted_Popup(sender As Object, e As EventArgs) Handles cboCompleted.Popup
        Dim edit = TryCast(sender, CheckedComboBoxEdit)
        Dim form = edit.GetPopupEditForm()
        RemoveHandler form.OkButton.Click, AddressOf OkComletedButton_Click
        AddHandler form.OkButton.Click, AddressOf OkComletedButton_Click
    End Sub
    Private Sub OkComletedButton_Click(ByVal sender As Object, ByVal e As EventArgs)
        SetCalendarFilter()
    End Sub

    Private Sub cboStatus_Popup(sender As Object, e As EventArgs) Handles cboStatus.Popup
        Dim edit = TryCast(sender, CheckedComboBoxEdit)
        Dim form = edit.GetPopupEditForm()
        RemoveHandler form.OkButton.Click, AddressOf OkButton_Click
        AddHandler form.OkButton.Click, AddressOf OkButton_Click
    End Sub
    Private Sub OkButton_Click(ByVal sender As Object, ByVal e As EventArgs)
        SetCalendarFilter()
    End Sub

    Private Sub BarRefresh_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles Ανανέωση.ItemClick
        SetCalendarFilter()
    End Sub
    Private Sub SetCalendarFilter(Optional ByVal sWhere As String = "")
        Dim sSQL As String
        Dim sIDS As New StringBuilder
        SchedulerDataStorage1.Appointments.Clear()
        sSQL = "SELECT * FROM vw_CCT_M WHERE ALLOWSCHEDULE=1 "
        If sWhere.Length > 0 Then sSQL = sSQL & " AND fullname like " & toSQLValueS("%" & sWhere & "%")
        ' FILTER STATUS
        For i As Integer = 0 To cboStatus.Items.Count - 1
            If cboStatus.Items(i).CheckState = CheckState.Checked Then
                If sIDS.Length > 0 Then sIDS.Append(",")
                sIDS.Append(toSQLValueS(cboStatus.Items(i).Tag.ToString))
            End If

        Next

        If sIDS.Length > 0 Then sSQL = sSQL + " and statusID in (" & sIDS.ToString & ")"

        'FILTER COMPLETED
        sIDS.Clear()
        For i As Integer = 0 To cboCompleted.Items.Count - 1
            If cboCompleted.Items(i).CheckState = CheckState.Checked Then
                If sIDS.Length > 0 Then sIDS.Append(",")
                sIDS.Append(toSQLValueS(cboCompleted.Items(i).Tag.ToString))
            End If

        Next
        If sIDS.Length > 0 Then sSQL = sSQL + " and completed in (" & sIDS.ToString & ")"

        Calendar.Initialize(SchedulerControl1, SchedulerDataStorage1, sSQL)
    End Sub
    Private Sub BarNewRec_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarNewRec.ItemClick
        Dim form1 As frmCusMov = New frmCusMov()
        form1.Text = "Κινήσεις Πελατών"
        form1.MdiParent = frmMain
        form1.Mode = FormMode.NewRecord
        form1.FormScrollerExist = False
        form1.CusID = "00000000-0000-0000-0000-000000000000"
        'form1.Scroller = GridView1
        'form1.FormScroller = Me
        frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(form1), New Point(CInt(form1.Parent.ClientRectangle.Width / 2 - form1.Width / 2), CInt(form1.Parent.ClientRectangle.Height / 2 - form1.Height / 2)))
        form1.Show()

    End Sub

    Private Sub txtSearch_EditValueChanging(sender As Object, e As ChangingEventArgs) Handles txtSearch.EditValueChanging

    End Sub

    Private Sub txtSearch_EditValueChanged(sender As Object, e As EventArgs) Handles txtSearch.EditValueChanged
        Dim value As Object = (TryCast(sender, TextEdit)).EditValue
        Dim teText As String = If(value Is Nothing, String.Empty, value.ToString())
        SetCalendarFilter(teText)
    End Sub

    Private Sub SchedulerControl1_AppointmentViewInfoCustomizing(sender As Object, e As AppointmentViewInfoCustomizingEventArgs) Handles SchedulerControl1.AppointmentViewInfoCustomizing
        e.ViewInfo.Appearance.BackColor = e.ViewInfo.Appointment.CustomFields("StatusColor")
    End Sub
End Class