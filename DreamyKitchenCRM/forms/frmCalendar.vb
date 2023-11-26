﻿Imports System.ComponentModel
Imports System.Data.SqlClient
Imports System.Text
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraScheduler
Imports DevExpress.XtraScheduler.Drawing

Public Class frmCalendar
    Private Calendar As New InitializeCalendar
    Private Sub frmCalendar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DreamyKitchenDataSet.vw_SALERS_AND_COUNTERS' table. You can move, or remove it, as needed.
        Me.Vw_SALERS_AND_COUNTERSTableAdapter.Fill(Me.DreamyKitchenDataSet.vw_SALERS_AND_COUNTERS)
        Try
            Dim sSQL As String
            PanelResults.Visible = False
            sSQL = "SELECT * FROM vw_CCT_M WHERE ALLOWSCHEDULE=1 and  completed=0 order by code"
            'Δημιουργία Appointments
            Calendar.Initialize(SchedulerControl1, SchedulerDataStorage1, sSQL, True)
            Me.Vw_CCT_MTableAdapter.Fill(Me.DreamyKitchenDataSet.vw_CCT_M, "")
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

            'Κεντράρισμα Panel
            PanelResults.Parent = frmMain
            PanelResults.Left = (PanelResults.Parent.Width - PanelResults.Width) / 2
            PanelResults.Top = (PanelResults.Parent.Height - PanelResults.Height) / 2

            'Me.DreamyKitchenAdapter.Fill(Me.DreamyKitchenDataSet.vw_SALERS)
            Me.Vw_SALERS_AND_COUNTERSTableAdapter.Fill(Me.DreamyKitchenDataSet.vw_SALERS_AND_COUNTERS)

            SchedulerControl1.Start = Now.Date
            sdr.Close()
        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), Company, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub


    Private Sub SchedulerDataStorage1_ReminderAlert(sender As Object, e As ReminderEventArgs) Handles SchedulerDataStorage1.ReminderAlert
        'e.AlertNotifications(1).Ignore = True
        'e.AlertNotifications(1).Handled = True
    End Sub

    Private Sub SchedulerControl1_DoubleClick(sender As Object, e As EventArgs) Handles SchedulerControl1.DoubleClick
        Dim form1 As frmCusMov = New frmCusMov()
        form1.Text = "Κινήσεις Πελατών"
        form1.Scroller = frmScroller.GridView1
        form1.FormScroller = frmScroller
        form1.FormScrollerExist = False
        form1.MdiParent = frmMain
        If SchedulerControl1.SelectedAppointments.Count = 0 Then
            form1.Mode = FormMode.NewRecord
        Else
            For i As Integer = 0 To SchedulerControl1.SelectedAppointments.Count - 1
                Dim apt As Appointment = SchedulerControl1.SelectedAppointments(i)
                form1.ID = apt.Id
                form1.Mode = FormMode.EditRecord
            Next i
        End If
        frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(form1), New Point(CInt(form1.Parent.ClientRectangle.Width / 2 - form1.Width / 2), CInt(form1.Parent.ClientRectangle.Height / 2 - form1.Height / 2)))
        form1.Show()
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

        Calendar.Initialize(SchedulerControl1, SchedulerDataStorage1, sSQL, False)
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


    Private Sub SchedulerControl1_AppointmentViewInfoCustomizing(sender As Object, e As AppointmentViewInfoCustomizingEventArgs) Handles SchedulerControl1.AppointmentViewInfoCustomizing
        e.ViewInfo.Appearance.BackColor = e.ViewInfo.Appointment.CustomFields("StatusColor")
    End Sub

    Private Sub BarEditItem2_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs)

    End Sub

    Private Sub cmdExit_Click(sender As Object, e As EventArgs) Handles cmdExit.Click
        PanelResults.Visible = False
    End Sub

    Private Sub txtSearch2_EditValueChanged(sender As Object, e As EventArgs) Handles txtSearch2.EditValueChanged
        Dim value As Object = (TryCast(sender, TextEdit)).EditValue
        Dim teText As String = If(value Is Nothing, String.Empty, value.ToString())
        SetCalendarFilter(teText)
        Me.Vw_CCT_MTableAdapter.Fill(Me.DreamyKitchenDataSet.vw_CCT_M, teText)
    End Sub
    Private Sub txtSearch2_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles txtSearch2.ButtonClick
        PanelResults.Visible = True
    End Sub

    Private Sub GridView1_DoubleClick(sender As Object, e As EventArgs) Handles GridView1.DoubleClick
        Dim form12 As frmCusMov = New frmCusMov()
        form12.Text = "Κινήσεις Πελατών"
        form12.ID = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "ID").ToString
        form12.MdiParent = frmMain
        form12.Mode = FormMode.EditRecord
        form12.Scroller = GridView1
        form12.FormScroller = Me
        frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(form12), New Point(CInt(Me.Parent.ClientRectangle.Width / 2 - Me.Width / 2), CInt(Me.Parent.ClientRectangle.Height / 2 - Me.Height / 2)))
        form12.Show()
    End Sub
    Private Sub SchedulerControl1_KeyDown(sender As Object, e As KeyEventArgs) Handles SchedulerControl1.KeyDown
        Dim sSQL As String
        If UserProps.ID.ToString.ToUpper <> "3F9DC32E-BE5B-4D46-A13C-EA606566CF32" And UserProps.ID.ToString.ToUpper <> "E9CEFD11-47C0-4796-A46B-BC41C4C3606B" Then Exit Sub
        If e.KeyCode = Keys.Delete Then
            For i As Integer = 0 To SchedulerControl1.SelectedAppointments.Count - 1

                Dim apt As Appointment = SchedulerControl1.SelectedAppointments(i)
                sSQL = "DELETE FROM CCT_M WHERE ID = " & toSQLValueS(apt.Id)
                Using oCmd As New SqlCommand(sSQL, CNDB)
                    oCmd.ExecuteNonQuery()
                End Using
            Next i
            SetCalendarFilter()
        End If
    End Sub

    Private Sub SchedulerControl1_Click(sender As Object, e As EventArgs) Handles SchedulerControl1.Click

    End Sub

    'Private Sub FillByToolStripButton_Click(sender As Object, e As EventArgs)
    '    Try
    '        Me.Vw_SALERS_AND_COUNTERSTableAdapter.FillBy(Me.DreamyKitchenDataSet.vw_SALERS_AND_COUNTERS)
    '    Catch ex As System.Exception
    '        System.Windows.Forms.MessageBox.Show(ex.Message)
    '    End Try

    'End Sub
End Class