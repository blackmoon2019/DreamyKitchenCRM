﻿Imports DevExpress.Utils
Imports DevExpress.XtraBars
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraTabbedMdi
Public Class frmMain
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        XtraTabbedMdiManager1.ClosePageButtonShowMode = DevExpress.XtraTab.ClosePageButtonShowMode.InAllTabPageHeaders
        bbDate.Caption = DateTime.Today
        bbUser.Caption = "Χρήστης: " & UserProps.RealName
        bbServer.Caption = "SQL Server: " & CNDB.DataSource.ToString
        bbDB.Caption = "Database: " & CNDB.Database.ToString
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
                e.Cancel = True
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
End Class