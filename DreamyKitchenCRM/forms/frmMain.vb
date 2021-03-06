﻿Imports System.Data.SqlClient
Imports DevExpress.Utils
Imports DevExpress.XtraBars
Imports DevExpress.XtraBars.Alerter
Imports DevExpress.XtraBars.ToastNotifications
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraTabbedMdi
Public Class frmMain
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        'TODO: This line of code loads data into the 'DreamyKitchenDataSet.vw_NOTES' table. You can move, or remove it, as needed.
        Me.Vw_NOTESTableAdapter.FillBy1(Me.DreamyKitchenDataSet.vw_NOTES, UserProps.SalerID, UserProps.ID)
        XtraTabbedMdiManager1.ClosePageButtonShowMode = DevExpress.XtraTab.ClosePageButtonShowMode.InAllTabPageHeaders
        bbDate.Caption = DateTime.Today
        bbUser.Caption = "Χρήστης: " & UserProps.RealName
        bbServer.Caption = "SQL Server: " & CNDB.DataSource.ToString
        bbDB.Caption = "Database: " & CNDB.Database.ToString
        bbVersion.Caption = "Ver:" + My.Application.Info.Version.ToString
    End Sub

    Private Sub MdiManager_PageAdded(sender As Object, e As MdiTabPageEventArgs)
    End Sub
    Private Sub bbUsers_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbUsers.ItemClick
        Dim form As frmScroller = New frmScroller()
        form.Text = "Χρήστες"
        form.DataTable = "vw_USR"
        form.MdiParent = Me
        form.Show()
    End Sub

    Private Sub bbMailSettings_ItemClick(sender As Object, e As ItemClickEventArgs) Handles bbMailSettings.ItemClick
        Dim form As frmScroller = New frmScroller()
        form.Text = "Email Settings"
        form.DataTable = "vw_MAILS"
        form.MdiParent = Me
        form.Show()

    End Sub

    Private Sub XtraTabbedMdiManager1_EndFloating(sender As Object, e As FloatingEventArgs) Handles XtraTabbedMdiManager1.EndFloating
        Select Case XtraTabbedMdiManager1.ActiveFloatForm.Name
            Case "frmUsers"
                XtraTabbedMdiManager1.ActiveFloatForm.Width = 489 : XtraTabbedMdiManager1.ActiveFloatForm.Height = 166
                XtraTabbedMdiManager1.ActiveFloatForm.Location = My.Settings.frmUsers
            Case "frmMailSettings"
                XtraTabbedMdiManager1.ActiveFloatForm.Width = 520 : XtraTabbedMdiManager1.ActiveFloatForm.Height = 136
                XtraTabbedMdiManager1.ActiveFloatForm.Location = My.Settings.frmUsers
            Case "frmCalendar"
                XtraTabbedMdiManager1.SelectedPage.ShowCloseButton = DefaultBoolean.False
        End Select
    End Sub

    Private Sub BarClose_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BarClose.ItemClick
        Application.Exit()
    End Sub

    Private Sub XtraTabbedMdiManager1_BeginFloating(sender As Object, e As FloatingCancelEventArgs) Handles XtraTabbedMdiManager1.BeginFloating
        Select Case XtraTabbedMdiManager1.SelectedPage.MdiChild.Name
            Case "frmCalendar"
                'e.Cancel = True
                '        XtraTabbedMdiManager1.ActiveFloatForm.Width = 489 : XtraTabbedMdiManager1.ActiveFloatForm.Height = 166
                '    Case "frmMailSettings"
                '        XtraTabbedMdiManager1.ActiveFloatForm.Width = 520 : XtraTabbedMdiManager1.ActiveFloatForm.Height = 136
                '    Case "frmScroller"
                '        frmScroller.Width = 1037 : frmScroller.Height = 689

        End Select
    End Sub
    Private Sub bbRights_ItemClick(sender As Object, e As ItemClickEventArgs) Handles bbRights.ItemClick
        Dim form As frmScroller = New frmScroller()
        form.Text = "Δικαιώματα"
        form.DataTable = "vw_RIGHTS"
        form.DataDetail = "vw_FORM_RIGHTS"
        form.MdiParent = Me
        form.Show()
    End Sub


    Private Sub bbLink_HyperlinkClick(sender As Object, e As HyperlinkClickEventArgs) Handles bbLink.HyperlinkClick
        Process.Start(bbLink.EditValue)
    End Sub



    Private Sub bbCOU_ItemClick(sender As Object, e As ItemClickEventArgs) Handles bbCOU.ItemClick
        Dim form As frmScroller = New frmScroller()
        form.Text = "Νομοί"
        form.DataTable = "vw_COU"
        form.MdiParent = Me
        form.Show()
    End Sub

    Private Sub bbAreas_ItemClick(sender As Object, e As ItemClickEventArgs) Handles bbAreas.ItemClick
        Dim form As frmScroller = New frmScroller()
        form.Text = "Περιοχές"
        form.DataTable = "vw_AREAS"
        form.MdiParent = Me
        form.Show()
    End Sub

    Private Sub bbADR_ItemClick(sender As Object, e As ItemClickEventArgs) Handles bbADR.ItemClick
        Dim form As frmScroller = New frmScroller()
        form.Text = "Διευθύνσεις"
        form.DataTable = "vw_ADR"
        form.MdiParent = Me
        form.Show()
    End Sub

    Private Sub bbDOY_ItemClick(sender As Object, e As ItemClickEventArgs) Handles bbDOY.ItemClick
        Dim form As frmScroller = New frmScroller()
        form.Text = "ΔΟΥ"
        form.DataTable = "vw_DOY"
        form.MdiParent = Me
        form.Show()
    End Sub

    Private Sub bbPRF_ItemClick(sender As Object, e As ItemClickEventArgs) Handles bbPRF.ItemClick
        Dim form As frmScroller = New frmScroller()
        form.Text = "Επαγγέλματα"
        form.DataTable = "vw_PRF"
        form.MdiParent = Me
        form.Show()
    End Sub

    Private Sub bbStatus_ItemClick(sender As Object, e As ItemClickEventArgs) Handles bbStatus.ItemClick
        Dim form As frmScroller = New frmScroller()
        form.Text = "Status"
        form.DataTable = "vw_STATUS"
        form.MdiParent = Me
        form.Show()
    End Sub

    Private Sub bbSource_ItemClick(sender As Object, e As ItemClickEventArgs) Handles bbSource.ItemClick
        Dim form As frmScroller = New frmScroller()
        form.Text = "Πηγές"
        form.DataTable = "vw_SOURCE"
        form.MdiParent = Me
        form.Show()
    End Sub

    Private Sub bbCCT_ItemClick(sender As Object, e As ItemClickEventArgs) Handles bbCCT.ItemClick
        Dim form As frmScroller = New frmScroller()
        form.Text = "Πελάτες"
        form.DataTable = "vw_CCT"
        form.MdiParent = Me
        form.Show()
    End Sub

    Private Sub bbSalers_ItemClick(sender As Object, e As ItemClickEventArgs) Handles bbSalers.ItemClick
        Dim form As frmScroller = New frmScroller()
        form.Text = "Πωλητές"
        form.DataTable = "vw_SALERS"
        form.MdiParent = Me
        form.Show()
    End Sub

    Private Sub BBCusMovs_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BBCusMovs.ItemClick
        Dim form As frmScroller = New frmScroller()
        form.Text = "Κινήσεις Πελατών"
        form.DataTable = "vw_CCT_M"
        form.MdiParent = Me
        form.Show()
    End Sub

    Private Sub BBCalendar_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BBCalendar.ItemClick
        Dim form As frmCalendar = New frmCalendar()
        form.Text = "Ημερολόγιο Κινήσεων"
        'form.DataTable = "vw_CCT_M"
        form.MdiParent = Me
        form.Show()
    End Sub

    Private Sub BBCusStatistics1_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BBCusStatistics1.ItemClick
        Dim form As frmScroller = New frmScroller()
        form.Text = "Στατιστικά Πελατών"
        form.DataTable = "vw_CUS_REPORT1"
        form.MdiParent = Me
        form.Show()
    End Sub

    Private Sub XtraTabbedMdiManager1_PageAdded(sender As Object, e As MdiTabPageEventArgs) Handles XtraTabbedMdiManager1.PageAdded
        Dim form1 As frmCalendar = New frmCalendar()
        XtraTabbedMdiManager1.Pages(frmCalendar).ShowCloseButton = DefaultBoolean.False


    End Sub

    Private Sub BBNotes_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BBNotes.ItemClick
        Dim form As New frmNotesScroller
        form.Text = "Σημειώματα"
        form.MdiParent = Me
        form.Show()
    End Sub

    Private Sub BarButtonItem2_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        Dim form As frmScroller = New frmScroller()
        form.Text = "Εττικέτες"
        form.DataTable = "vw_NOTES_L"
        form.MdiParent = Me
        form.Show()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        GetNewMessages()

    End Sub

    Private Sub ToastNotificationsManager1_Activated(sender As Object, e As ToastNotificationEventArgs)
        Try
            Dim sSQL As String
            sSQL = "update NOTES SET readed=1 where ID = '" & e.NotificationID.ToString & "'"
            'Εκτέλεση QUERY
            Using oCmd As New SqlCommand(sSQL.ToString, CNDB)
                oCmd.ExecuteNonQuery()
            End Using
            'Dim note As New ToastNotification
            'note.ID = e.NotificationID
            'ToastNotificationsManager1.HideNotification(note)
            'ToastNotificationsManager1.Notifications.Remove(note)
            Dim form10 As frmNotes = New frmNotes()
            form10.Text = "Σημειώματα"
            form10.ID = e.NotificationID
            form10.MdiParent = Me
            form10.Mode = FormMode.EditRecord
            form10.FormScroller = Me
            Me.XtraTabbedMdiManager1.Float(Me.XtraTabbedMdiManager1.Pages(form10), New Point(CInt(form10.Parent.ClientRectangle.Width / 2 - form10.Width / 2), CInt(form10.Parent.ClientRectangle.Height / 2 - form10.Height / 2)))
            form10.Show()
            Timer1.Enabled = True
        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), "Dreamy Kitchen CRM", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Timer1.Enabled = False
        End Try
    End Sub
    Private Sub GetNewMessages()
        Try
            'Dim i As Integer = 0
            Dim cmd As SqlCommand = New SqlCommand("SELECT ID,title,note
                                                     FROM vw_NOTES WHERE (salerID = '" & UserProps.SalerID.ToString & "' or salerID is null ) and readed=0", CNDB)
            Dim sdr As SqlDataReader = cmd.ExecuteReader()
            If sdr.HasRows Then
                'ToastNotificationsManager1.Notifications.Clear()

                While sdr.Read()
                    'Dim note As New ToastNotification(sdr.Item(0).ToString, Nothing, "CRM Notification", sdr.Item(1).ToString, sdr.Item(2).ToString, ToastNotificationTemplate.ImageAndText04)
                    'note.ID = sdr.Item(0).ToString
                    'ToastNotificationsManager1.Notifications.Add(note)
                    'ToastNotificationsManager1.ShowNotification(ToastNotificationsManager1.Notifications(i))
                    If FindAllert(sdr.Item(0).ToString) = False Then
                        AlertControl1.Show(Me, "CRM Notification", sdr.Item(1).ToString, sdr.Item(2).ToString, My.Resources.logo32x32, sdr.Item(0).ToString)
                    End If
                    'i = i + 1

                End While
            End If
            sdr.Close()
            sdr = Nothing
        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), "Dreamy Kitchen CRM", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Timer1.Enabled = False
        End Try
    End Sub
    Private Function FindAllert(ByVal ID As String) As Boolean
        Dim i As Integer
        For i = 0 To AlertControl1.AlertFormList.Count - 1
            If AlertControl1.AlertFormList.Item(i).Info.Tag = ID Then Return True
        Next
        Return False
    End Function


    Private Sub AlertControl1_AlertClick(sender As Object, e As AlertClickEventArgs) Handles AlertControl1.AlertClick
        Try
            Dim sSQL As String
            sSQL = "update NOTES SET readed=1 where ID = '" & e.Info.Tag & "'"
            'Εκτέλεση QUERY
            Using oCmd As New SqlCommand(sSQL.ToString, CNDB)
                oCmd.ExecuteNonQuery()
            End Using
            'Dim note As New ToastNotification
            'note.ID = e.NotificationID
            'ToastNotificationsManager1.HideNotification(note)
            'ToastNotificationsManager1.Notifications.Remove(note)
            e.AlertForm.Close()
            Dim form10 As frmNotes = New frmNotes()
            form10.Text = "Σημειώματα"
            form10.ID = e.Info.Tag
            form10.MdiParent = Me
            form10.Mode = FormMode.EditRecord
            form10.FormScroller = Me
            Me.XtraTabbedMdiManager1.Float(Me.XtraTabbedMdiManager1.Pages(form10), New Point(CInt(form10.Parent.ClientRectangle.Width / 2 - form10.Width / 2), CInt(form10.Parent.ClientRectangle.Height / 2 - form10.Height / 2)))
            form10.Show()
            Timer1.Enabled = True
        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), "Dreamy Kitchen CRM", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Timer1.Enabled = False
        End Try
    End Sub

    Private Sub AlertControl1_FormLoad(sender As Object, e As AlertFormLoadEventArgs) Handles AlertControl1.FormLoad
        e.Buttons.PinButton.SetDown(True)
    End Sub

    Private Sub BBChangeUsr_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BBChangeUsr.ItemClick
        frmLogin.Show()
        Me.Close()
    End Sub
End Class

