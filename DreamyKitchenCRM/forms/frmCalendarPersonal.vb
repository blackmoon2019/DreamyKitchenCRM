Imports System.ComponentModel
Imports System.Data.SqlClient
Imports System.Text
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraScheduler
Imports DevExpress.XtraScheduler.Drawing
Public Class frmCalendarPersonal
    Private Calendar As New InitializeCalendar
    Private Sub SchedulerControl1_EditAppointmentFormShowing(sender As Object, e As DevExpress.XtraScheduler.AppointmentFormEventArgs) Handles SchedulerControl1.EditAppointmentFormShowing


    End Sub

    Private Sub frmCalendarPersonal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim sSQL As String
            sSQL = "SELECT * FROM vw_SALER_CALENDAR WHERE empID = " & toSQLValueS(UserProps.SalerID.ToString) & " order by code"
            'Δημιουργία Appointments
            Calendar.InitializePersonal(SchedulerControl1, SchedulerDataStorage1, sSQL, True)
            Me.Vw_SALER_CAL_STATUSTableAdapter.Fill(Me.DreamyKitchenDataSet.vw_SALER_CAL_STATUS)
            sSQL = "SELECT id,name FROM vw_SALER_CAL_STATUS  order by name"
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


            SchedulerControl1.Start = Now.Date
            sdr.Close()
        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), "Dreamy Kitchen CRM", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
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
    Public Sub SetCalendarFilter(Optional ByVal sWhere As String = "")
        Dim sSQL As String
        Dim sIDS As New StringBuilder
        SchedulerDataStorage1.Appointments.Clear()
        sSQL = "SELECT * FROM vw_SALER_CALENDAR WHERE empID = " & toSQLValueS(UserProps.SalerID.ToString)

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

        Calendar.InitializePersonal(SchedulerControl1, SchedulerDataStorage1, sSQL, False)
        SchedulerControl1.Start = Now.Date
    End Sub
    Private Sub BarNewRec_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarNewRec.ItemClick
        Dim form1 As frmPersonalNote = New frmPersonalNote()
        form1.Text = "Προσωπικό Ημερολόγιο"
        ' form1.MdiParent = frmMain
        form1.Mode = FormMode.NewRecord
        form1.dtInsertedDate.EditValue = SchedulerControl1.SelectedInterval.Start
        ' frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(form1), New Point(CInt(form1.Parent.ClientRectangle.Width / 2 - form1.Width / 2), CInt(form1.Parent.ClientRectangle.Height / 2 - form1.Height / 2)))
        form1.ShowDialog()
        SetCalendarFilter()
    End Sub
    Private Sub SchedulerControl1_DoubleClick(sender As Object, e As EventArgs) Handles SchedulerControl1.DoubleClick
        Dim form1 As frmPersonalNote = New frmPersonalNote()
        form1.Text = "Προσωπικό Ημερολόγιο"
        form1.Scroller = frmScroller.GridView1
        form1.FormScroller = frmScroller
        'form1.MdiParent = frmMain
        If SchedulerControl1.SelectedAppointments.Count = 0 Then
            form1.Mode = FormMode.NewRecord
            form1.dtInsertedDate.EditValue = SchedulerControl1.SelectedInterval.Start
        Else
            For i As Integer = 0 To SchedulerControl1.SelectedAppointments.Count - 1
                Dim apt As Appointment = SchedulerControl1.SelectedAppointments(i)
                form1.ID = apt.Id
                form1.Mode = FormMode.EditRecord
            Next i
        End If
        'frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(form1), New Point(CInt(form1.Parent.ClientRectangle.Width / 2 - form1.Width / 2), CInt(form1.Parent.ClientRectangle.Height / 2 - form1.Height / 2)))
        form1.ShowDialog()
        SetCalendarFilter()
    End Sub

    Private Sub SchedulerControl1_AppointmentViewInfoCustomizing(sender As Object, e As AppointmentViewInfoCustomizingEventArgs) Handles SchedulerControl1.AppointmentViewInfoCustomizing
        'e.ViewInfo.Appearance.BackColor = e.ViewInfo.Appointment.CustomFields("StatusColor")
    End Sub

    Private Sub SchedulerControl1_KeyDown(sender As Object, e As KeyEventArgs) Handles SchedulerControl1.KeyDown
        Dim sSQL As String
        If e.KeyCode = Keys.Delete Then
            If XtraMessageBox.Show("Θέλετε να διαγραφεί η τρέχουσα εγγραφή?", "Dreamy Kitchen CRM", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                For i As Integer = 0 To SchedulerControl1.SelectedAppointments.Count - 1
                    Dim apt As Appointment = SchedulerControl1.SelectedAppointments(i)
                    sSQL = "DELETE FROM SALER_CALENDAR WHERE ID = " & toSQLValueS(apt.Id)
                    Using oCmd As New SqlCommand(sSQL, CNDB)
                        oCmd.ExecuteNonQuery()
                    End Using

                Next i
                SetCalendarFilter()
            End If
        End If
    End Sub

    Private Sub txtSearch2_EditValueChanged(sender As Object, e As EventArgs) Handles txtSearch2.EditValueChanged
        Dim value As Object = (TryCast(sender, TextEdit)).EditValue
        Dim teText As String = If(value Is Nothing, String.Empty, value.ToString())
        SetCalendarFilter(teText)
        'Me.Vw_CCT_MTableAdapter.Fill(Me.DreamyKitchenDataSet.vw_CCT_M, teText)
    End Sub

End Class