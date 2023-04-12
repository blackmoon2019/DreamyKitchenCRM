Imports System.Data.SqlClient
Imports DevExpress.Utils
Imports DevExpress.XtraBars
Imports DevExpress.XtraBars.Alerter
Imports DevExpress.XtraBars.ToastNotifications
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraTabbedMdi
Imports DevExpress.LookAndFeel
Imports System.ComponentModel
Imports System.Configuration

Public Class frmMain
    Private UserPermissions As New CheckPermissions
    Private CheckFUpdate As New CheckForUpdates
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        'TODO: This line of code loads data into the 'DreamyKitchenDataSet.vw_NOTES' table. You can move, or remove it, as needed.

        Me.Vw_NOTESTableAdapter.FillBy1(Me.DreamyKitchenDataSet.vw_NOTES, UserProps.EmpID, UserProps.ID)
        'XtraTabbedMdiManager1.ClosePageButtonShowMode = DevExpress.XtraTab.ClosePageButtonShowMode.InAllTabPageHeaders
        bbDate.Caption = DateTime.Today
        bbUser.Caption = "Χρήστης: " & UserProps.RealName
        bbServer.Caption = "SQL Server: " & CNDB.DataSource.ToString
        bbDB.Caption = "Database: " & CNDB.Database.ToString
        bbVersion.Caption = "Ver:" + My.Application.Info.Version.ToString
        Timer2.Stop()
        LoadCurrentSkin()
        If UserProps.ID.ToString.ToUpper <> "3F9DC32E-BE5B-4D46-A13C-EA606566CF32" And UserProps.ID.ToString.ToUpper <> "E9CEFD11-47C0-4796-A46B-BC41C4C3606B" Then
            EmpManage.Visible = False
            ProjectAnalysis.Visible = False
            RibbonPage4.Visible = False
            RibonSettings.Visible = False
            bbCreditDebit.Visibility = BarItemVisibility.Never
            BBProjectCosts.Visibility = BarItemVisibility.Never
            bbProjects.Visible = False
        End If


    End Sub

    Private Sub MdiManager_PageAdded(sender As Object, e As MdiTabPageEventArgs)
    End Sub
    Private Sub bbUsers_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbUsers.ItemClick
        If UserPermissions.CheckViewPermission("Χρήστες") Then
            Dim form As frmScroller = New frmScroller()
            form.Text = "Χρήστες"
            form.DataTable = "vw_USR"
            form.MdiParent = Me
            form.Show()
        Else
            XtraMessageBox.Show("Δεν έχετε τα απαραίτητα δικαιώματα για να εισέλθετε", "Dreamy Kitchen CRM", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

    End Sub

    Private Sub bbMailSettings_ItemClick(sender As Object, e As ItemClickEventArgs) Handles bbMailSettings.ItemClick
        If UserPermissions.CheckViewPermission("Email Settings") Then
            Dim form As frmScroller = New frmScroller()
            form.Text = "Email Settings"
            form.DataTable = "vw_MAILS"
            form.MdiParent = Me
            form.Show()
        Else
            XtraMessageBox.Show("Δεν έχετε τα απαραίτητα δικαιώματα για να εισέλθετε", "Dreamy Kitchen CRM", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub XtraTabbedMdiManager1_EndFloating(sender As Object, e As FloatingEventArgs) Handles XtraTabbedMdiManager1.EndFloating
        Select Case XtraTabbedMdiManager1.ActiveFloatForm.Name
            Case "frmUsers"
                XtraTabbedMdiManager1.ActiveFloatForm.Width = 489 : XtraTabbedMdiManager1.ActiveFloatForm.Height = 166
            Case "frmMailSettings"
                XtraTabbedMdiManager1.ActiveFloatForm.Width = 520 : XtraTabbedMdiManager1.ActiveFloatForm.Height = 136
            Case "frmCalendar"
                XtraTabbedMdiManager1.SelectedPage.ShowCloseButton = DefaultBoolean.False
        End Select
    End Sub

    Private Sub BarClose_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BarClose.ItemClick
        SaveCurrentSkin()

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
        If UserPermissions.CheckViewPermission("Δικαιώματα") Then
            Dim form As frmScroller = New frmScroller()
            form.Text = "Δικαιώματα"
            form.DataTable = "vw_RIGHTS"
            form.DataDetail = "vw_FORM_RIGHTS"
            form.MdiParent = Me
            form.Show()
        Else
            XtraMessageBox.Show("Δεν έχετε τα απαραίτητα δικαιώματα για να εισέλθετε", "Dreamy Kitchen CRM", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
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

    Private Sub BarButtonItem2_ItemClick(sender As Object, e As ItemClickEventArgs) Handles bbLabels.ItemClick
        Dim form As frmScroller = New frmScroller()
        form.Text = "Εττικέτες"
        form.DataTable = "vw_NOTES_L"
        form.MdiParent = Me
        form.Show()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        GetNewMessages()
        'Έλεγχος νέας έκδοσης
        If CheckFUpdate.CheckForNewVersion Then
            BBUpdate.Visibility = BarItemVisibility.Always
            Timer2.Start()
        End If
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
                                                     FROM vw_NOTES WHERE (empID = '" & UserProps.EmpID.ToString & "' or empID is null ) and readed=0", CNDB)
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

    Private Sub ΒΒDoorType_ItemClick(sender As Object, e As ItemClickEventArgs) Handles ΒΒDoorType.ItemClick
        Dim form As frmScroller = New frmScroller()
        form.Text = "Κατηγορία Πόρτας"
        form.DataTable = "vw_DOOR_TYPE"
        form.MdiParent = Me
        form.Show()
    End Sub

    Private Sub bbCatErm_ItemClick(sender As Object, e As ItemClickEventArgs) Handles bbCatErm.ItemClick
        Dim form As frmScroller = New frmScroller()
        form.Text = "Κατηγορίες Ερμαρίων"
        form.DataTable = "vw_CAT_ERM"
        form.MdiParent = Me
        form.Show()
    End Sub

    Private Sub bbERM_ItemClick(sender As Object, e As ItemClickEventArgs) Handles bbERM.ItemClick
        Dim form As frmScroller = New frmScroller()
        form.Text = "Ερμάρια"
        form.DataTable = "vw_ERM"
        form.MdiParent = Me
        form.Show()
    End Sub

    Private Sub bbBench_ItemClick(sender As Object, e As ItemClickEventArgs) Handles bbBench.ItemClick
        Dim form As frmScroller = New frmScroller()
        form.Text = "Πάγκοι"
        form.DataTable = "vw_BENCH"
        form.MdiParent = Me
        form.Show()
    End Sub

    Private Sub bbMech_ItemClick(sender As Object, e As ItemClickEventArgs) Handles bbMech.ItemClick
        Dim form As frmScroller = New frmScroller()
        form.Text = "Μηχανισμοί"
        form.DataTable = "vw_MECH"
        form.MdiParent = Me
        form.Show()

    End Sub

    Private Sub bbTechCateg_ItemClick(sender As Object, e As ItemClickEventArgs) Handles bbTechCateg.ItemClick
        Dim form As frmScroller = New frmScroller()
        form.Text = "Κατηγορίες Τεχνικής Υποστήριξης"
        form.DataTable = "vw_TECH_CAT"
        form.MdiParent = Me
        form.Show()
    End Sub

    Private Sub bbTechnicalSupport_ItemClick(sender As Object, e As ItemClickEventArgs) Handles bbTechnicalSupport.ItemClick
        Dim form As frmScroller = New frmScroller()
        form.Text = "Τεχνική Υποστήριξη"
        form.DataTable = "vw_TECH_SUP"
        form.MdiParent = Me
        form.Show()
    End Sub

    Private Sub bbColors_ItemClick(sender As Object, e As ItemClickEventArgs) Handles bbColors.ItemClick
        Dim form As frmScroller = New frmScroller()
        form.Text = "Χρώματα"
        form.DataTable = "vw_COLORS"
        form.MdiParent = Me
        form.Show()
    End Sub

    Private Sub bbColorCAT_ItemClick(sender As Object, e As ItemClickEventArgs) Handles bbColorCAT.ItemClick
        Dim form As frmScroller = New frmScroller()
        form.Text = "Κατηγορίες Χρωμάτων"
        form.DataTable = "vw_COLORS_CAT"
        form.MdiParent = Me
        form.Show()
    End Sub

    Private Sub bboffer_ItemClick(sender As Object, e As ItemClickEventArgs) Handles bboffer.ItemClick
        Dim form As frmScroller = New frmScroller()
        form.Text = "Προσφορές"
        form.DataTable = "vw_OFF"
        form.MdiParent = Me
        form.Show()
    End Sub

    Private Sub bbEpendisis_ItemClick(sender As Object, e As ItemClickEventArgs) Handles bbEpendisis.ItemClick
        Dim form As frmScroller = New frmScroller()
        form.Text = "Επενδύσης - Καταφραγές"
        form.DataTable = "vw_SIDES"
        form.MdiParent = Me
        form.Show()
    End Sub

    Private Sub bbDimensions_ItemClick(sender As Object, e As ItemClickEventArgs) Handles bbDimensions.ItemClick
        Dim form As frmScroller = New frmScroller()
        form.Text = "Διαστάσεις"
        form.DataTable = "vw_DIM"
        form.MdiParent = Me
        form.Show()
    End Sub

    Private Sub bbCalculations_ItemClick(sender As Object, e As ItemClickEventArgs) Handles bbCalculations.ItemClick
        Dim form As frmScroller = New frmScroller()
        form.Text = "Υπολογισμοί"
        form.DataTable = "vw_CALC"
        form.MdiParent = Me
        form.Show()
    End Sub

    Private Sub bbCatSubErm_ItemClick(sender As Object, e As ItemClickEventArgs) Handles bbCatSubErm.ItemClick
        Dim form As frmScroller = New frmScroller()
        form.Text = "Υποκατηγορίες Ερμαρίων"
        form.DataTable = "vw_CAT_SUB_ERM"
        form.MdiParent = Me
        form.Show()
    End Sub

    Private Sub frmMain_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        SaveCurrentSkin()
    End Sub

    Sub SaveCurrentSkin()
        Dim config As Configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None)
        If config.AppSettings.Settings("Skin") Is Nothing Then
            config.AppSettings.Settings.Add("Skin", UserLookAndFeel.Default.ActiveSkinName)
        Else
            config.AppSettings.Settings("Skin").Value = UserLookAndFeel.Default.ActiveSkinName
        End If
        config.Save()

    End Sub
    Sub LoadCurrentSkin()
        Dim config As Configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None)
        If config.AppSettings.Settings("Skin") Is Nothing Then
            Return
        Else
            UserLookAndFeel.Default.ActiveLookAndFeel.SkinName = config.AppSettings.Settings("Skin").Value
        End If
    End Sub

    Private Sub BBSer_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BBSer.ItemClick
        Dim form As frmScroller = New frmScroller()
        form.Text = "Συνεργεία"
        form.DataTable = "vw_SER"
        form.MdiParent = Me
        form.Show()
    End Sub

    Private Sub BBInstM_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BBInstM.ItemClick
        If UserPermissions.CheckViewPermission("Μισθοδοσία Τοποθετών") Then
            Dim form As frmScroller = New frmScroller()
            form.Text = "Μισθοδοσία Τοποθετών"
            form.DataTable = "vw_INST_M"
            form.MdiParent = Me
            form.Show()
        Else
            XtraMessageBox.Show("Δεν έχετε τα απαραίτητα δικαιώματα για να εισέλθετε", "Dreamy Kitchen CRM", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub
    Private Sub BBInst_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BBInst.ItemClick
        If UserPermissions.CheckViewPermission("Πρόγραμμα Εργασιών Τοποθετών") Then
            Dim form As frmScroller = New frmScroller()
            form.Text = "Πρόγραμμα Εργασιών Τοποθετών"
            form.DataTable = "vw_INST"
            form.DataDetail = "vw_INST_M"
            'form.DataTableWhereCondition = " WHERE DEPID = 'BFD7EBD9-B0B2-4FCB-B1FF-341EC37A6A11'"
            form.MdiParent = Me
            form.Show()
        Else
            XtraMessageBox.Show("Δεν έχετε τα απαραίτητα δικαιώματα για να εισέλθετε", "Dreamy Kitchen CRM", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub BBCalendarInst_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BBCalendarInst.ItemClick
        Dim form As frmCalendarInst = New frmCalendarInst()
        form.Text = "Πρόγραμμα Τοποθετήσεων"
        form.MdiParent = Me
        form.Show()
    End Sub

    Private Sub bbBanks_ItemClick(sender As Object, e As ItemClickEventArgs) Handles bbBanks.ItemClick
        Dim form As frmScroller = New frmScroller()
        form.Text = "Τράπεζες"
        form.DataTable = "vw_BANKS"
        form.MdiParent = Me
        form.Show()
    End Sub

    Private Sub bbCreditDebit_ItemClick(sender As Object, e As ItemClickEventArgs) Handles bbCreditDebit.ItemClick
        If UserProps.ID.ToString.ToUpper = "3F9DC32E-BE5B-4D46-A13C-EA606566CF32" Or UserProps.ID.ToString.ToUpper = "E9CEFD11-47C0-4796-A46B-BC41C4C3606B" Then
            Dim form As frmScroller = New frmScroller()
            form.Text = "Χρεωπιστώσεις Πελατών"
            form.DataTable = "vw_TRANSH"
            form.DataDetail = "vw_TRANSD"
            form.MdiParent = Me
            form.Show()
        Else
            XtraMessageBox.Show("Δεν έχετε τα απαραίτητα δικαιώματα για να εισέλθετε", "Dreamy Kitchen CRM", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub bbEmploye_ItemClick(sender As Object, e As ItemClickEventArgs) Handles bbEmploye.ItemClick
        If UserPermissions.CheckViewPermission("Διαχείριση Προσωπικού") Then
            Dim form As frmScroller = New frmScroller()
            form.Text = "Διαχείριση Προσωπικού"
            form.DataTable = "vw_EMP"
            form.MdiParent = Me
            form.Show()
        Else
            XtraMessageBox.Show("Δεν έχετε τα απαραίτητα δικαιώματα για να εισέλθετε", "Dreamy Kitchen CRM", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub bbDep_ItemClick(sender As Object, e As ItemClickEventArgs) Handles bbDep.ItemClick
        If UserPermissions.CheckViewPermission("Τμήματα Εταιρίας") Then
            Dim form As frmScroller = New frmScroller()
            form.Text = "Τμήματα Εταιρίας"
            form.DataTable = "vw_DEP"
            form.MdiParent = Me
            form.Show()
        Else
            XtraMessageBox.Show("Δεν έχετε τα απαραίτητα δικαιώματα για να εισέλθετε", "Dreamy Kitchen CRM", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub bbEmpMov_ItemClick(sender As Object, e As ItemClickEventArgs) Handles bbEmpMov.ItemClick
        If UserPermissions.CheckViewPermission("Παρουσιολόγιο Έκθεσης") Then
            Dim form As frmEmpPresentation = New frmEmpPresentation()
            form.IsConstr = False
            form.Text = "Παρουσιολόγιο Έκθεσης"
            form.MdiParent = Me
            form.Show()
        Else
            XtraMessageBox.Show("Δεν έχετε τα απαραίτητα δικαιώματα για να εισέλθετε", "Dreamy Kitchen CRM", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub bbStatusPre_ItemClick(sender As Object, e As ItemClickEventArgs) Handles bbStatusPre.ItemClick
        If UserPermissions.CheckViewPermission("Status Παρουσιολογίου") Then
            Dim form As frmScroller = New frmScroller()
            form.Text = "Status Παρουσιολογίου"
            form.DataTable = "vw_EMP_S"
            form.MdiParent = Me
            form.Show()
        Else
            XtraMessageBox.Show("Δεν έχετε τα απαραίτητα δικαιώματα για να εισέλθετε", "Dreamy Kitchen CRM", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub BBPersonalCalendar_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BBPersonalCalendar.ItemClick
        Dim form As frmCalendarPersonal = New frmCalendarPersonal()
        form.Text = "Προσωπικό Ημερολόγιο"
        form.MdiParent = Me
        form.Show()
    End Sub

    Private Sub BBPersonalCalendarStatus_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BBPersonalCalendarStatus.ItemClick
        Dim form As frmScroller = New frmScroller()
        form.Text = "Status Προσωπικού Ημερολογίου"
        form.DataTable = "vw_SALER_CAL_STATUS"
        form.MdiParent = Me
        form.Show()
    End Sub



    Private Sub BBPayrolStatus_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BBPayrolStatus.ItemClick
        If UserPermissions.CheckViewPermission("Status Μισθοδοσίας") Then
            Dim form As frmScroller = New frmScroller()
            form.Text = "Status Μισθοδοσίας"
            form.DataTable = "vw_EMP_M_S"
            form.MdiParent = Me
            form.Show()
        Else
            XtraMessageBox.Show("Δεν έχετε τα απαραίτητα δικαιώματα για να εισέλθετε", "Dreamy Kitchen CRM", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub BBPayroll_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BBPayroll.ItemClick
        If UserPermissions.CheckViewPermission("Μισθοδοσία Έκθεσης") Then
            Dim form As frmScroller = New frmScroller()
            form.Text = "Μισθοδοσία Έκθεσης"
            form.DataTableWhereCondition = " WHERE DEPID = '9812E975-2FD4-4653-B043-3D6CAF440888'"
            form.IsConstr = False
            form.DataTable = "vw_EMP_M"
            form.MdiParent = Me
            form.Show()
        Else
            XtraMessageBox.Show("Δεν έχετε τα απαραίτητα δικαιώματα για να εισέλθετε", "Dreamy Kitchen CRM", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub bbEMP_T_ItemClick(sender As Object, e As ItemClickEventArgs) Handles bbEMP_T.ItemClick
        If UserPermissions.CheckViewPermission("Τζίροι-Ποσοστά έκθεσης") Then
            Dim form As frmScroller = New frmScroller()
            form.Text = "Τζίροι-Ποσοστά έκθεσης"
            form.DataTable = "vw_EMP_T"
            form.MdiParent = Me
            form.Show()
        Else
            XtraMessageBox.Show("Δεν έχετε τα απαραίτητα δικαιώματα για να εισέλθετε", "Dreamy Kitchen CRM", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub BBEllipse_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BBEllipse.ItemClick
        Dim form As frmScroller = New frmScroller()
        form.Text = "Εκκρεμότητες Έργων"
        form.DataTable = "vw_INST_ELLIPSE"
        form.DataDetail = "INST_ELLIPSE_JOBS"
        form.MdiParent = Me
        form.Show()
    End Sub

    Private Sub bbConstrCat_ItemClick(sender As Object, e As ItemClickEventArgs) Handles bbConstrCat.ItemClick
        Dim form As frmScroller = New frmScroller()
        form.Text = "Status Κατασκευαστικού"
        form.DataTable = "vw_CONSTR_CAT"
        form.MdiParent = Me
        form.Show()
    End Sub

    Private Sub bbConstr_ItemClick(sender As Object, e As ItemClickEventArgs) Handles bbConstr.ItemClick
        If UserPermissions.CheckViewPermission("Πρόγραμμα Εργασίας Κατασκευαστικού") Then
            Dim form As frmScroller = New frmScroller()
            form.Text = "Πρόγραμμα Εργασίας Κατασκευαστικού"
            form.DataTable = "vw_CONSTR"
            form.MdiParent = Me
            form.Show()
        Else
            XtraMessageBox.Show("Δεν έχετε τα απαραίτητα δικαιώματα για να εισέλθετε", "Dreamy Kitchen CRM", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub BBPayrollConstr_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BBPayrollConstr.ItemClick
        If UserPermissions.CheckViewPermission("Μισθοδοσία Κατασκευαστικου") Then
            Dim form As frmScroller = New frmScroller()
            form.Text = "Μισθοδοσία Κατασκευαστικου"
            form.IsConstr = True
            form.DataTableWhereCondition = " WHERE jobid = 'F1A60661-D448-41B7-8CF0-CE6B9FF6E518'"
            form.DataTable = "vw_EMP_M"
            form.MdiParent = Me
            form.Show()
        Else
            XtraMessageBox.Show("Δεν έχετε τα απαραίτητα δικαιώματα για να εισέλθετε", "Dreamy Kitchen CRM", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub bbJobs_ItemClick(sender As Object, e As ItemClickEventArgs) Handles bbJobs.ItemClick
        Dim form As frmScroller = New frmScroller()
        form.Text = "Θέσεις Εργασίας"
        form.DataTable = "vw_JOBS"
        form.MdiParent = Me
        form.Show()
    End Sub

    Private Sub BBStatistics2_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BBStatistics2.ItemClick
        Dim form As frmScroller = New frmScroller()
        form.Text = "Πρόγραμμα Παραδόσεων - Τοποθετήσεων"
        form.DataTable = "vw_STATISTICS2"
        form.MdiParent = Me
        form.Show()
    End Sub

    Private Sub BBScanFileNames_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BBScanFileNames.ItemClick
        Dim form As frmScroller = New frmScroller()
        form.Text = "Ονομασίες Scan Αρχείων"
        form.DataTable = "vw_SCAN_FILE_NAMES"
        form.MdiParent = Me
        form.Show()
    End Sub

    Private Sub BBStatistics3_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BBStatistics3.ItemClick
        Dim form As frmScroller = New frmScroller()
        form.Text = "Τελευταίο Status Ανα πελάτη"
        form.DataTable = "vw_STATISTICS3"
        form.MdiParent = Me
        form.Show()
    End Sub

    Private Sub BBProjectCosts_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BBProjectCosts.ItemClick
        If UserPermissions.CheckViewPermission("Ανάλυση Έργων") Then
            Dim form As frmScroller = New frmScroller()
            form.Text = "Ανάλυση Έργων"
            form.DataTable = "vw_PROJECT_COST"
            form.MdiParent = Me
            form.Show()
        End If
    End Sub
    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If BBUpdate.Visibility = BarItemVisibility.Never Then BBUpdate.Visibility = BarItemVisibility.Always Else BBUpdate.Visibility = BarItemVisibility.Never
    End Sub

    Private Sub BBUpdate_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BBUpdate.ItemClick
        Timer2.Stop()
        CheckFUpdate.FindNewVersion()
    End Sub

    Private Sub BBNotes2_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BBNotes2.ItemClick
        Dim form As New frmScroller
        form.Text = "Σημειώματα"
        form.DataTable = "vw_NOTES"
        form.DataTableWhereCondition = "WHERE empID = " & toSQLValueS(UserProps.EmpID.ToString) & "  Or createdBy = " & toSQLValueS(UserProps.ID.ToString)
        form.MdiParent = Me
        form.Show()
    End Sub

    Private Sub BBPay_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BBPay.ItemClick
        Dim form As frmScroller = New frmScroller()
        form.Text = "Τρόποι Πληρωμής"
        form.DataTable = "vw_PAY"
        form.MdiParent = Me
        form.Show()
    End Sub

    Private Sub BBSup_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BBSup.ItemClick
        Dim form As frmScroller = New frmScroller()
        form.Text = "Προμηθευτές"
        form.DataTable = "vw_SUP"
        form.MdiParent = Me
        form.Show()
    End Sub

    Private Sub BBBuy_C_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BBBuy_C.ItemClick
        Dim form As frmScroller = New frmScroller()
        form.Text = "Κατηγορίες Αγορών"
        form.DataTable = "vw_BUY_C"
        form.MdiParent = Me
        form.Show()
    End Sub

    Private Sub BBuy_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BBuy.ItemClick
        Dim form As frmScroller = New frmScroller()
        form.Text = "Αγορές"
        form.DataTable = "vw_BUY"
        form.DataDetail = "vw_SUP_PAYMENTS_D"
        form.MdiParent = Me
        form.Show()
    End Sub

    Private Sub BBSupInvoicesPayment_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BBSupInvoicesPayment.ItemClick
        Dim form As frmScroller = New frmScroller()
        form.Text = "Πληρωμές Παραστατικών Προμηθευτών"
        form.DataTable = "vw_SUP_PAYMENTS_H"
        form.MdiParent = Me
        form.Show()
    End Sub

    Private Sub BBTransactions_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BBTransactions.ItemClick
        Dim form As frmScroller = New frmScroller()
        form.Text = "Καρτέλλα"
        form.DataTable = "vw_SUP_PAYMENTS_D"
        form.MdiParent = Me
        form.Show()
    End Sub

    Private Sub BBParam_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BBParam.ItemClick
        Dim form As frmParameters = New frmParameters()
        form.Text = "Παράμετροι"
        form.MdiParent = Me
        form.Mode = FormMode.NewRecord
        Me.XtraTabbedMdiManager1.Float(Me.XtraTabbedMdiManager1.Pages(form), New Point(CInt(Me.ClientRectangle.Width / 2 - Me.Width / 2), CInt(Me.ClientRectangle.Height / 2 - Me.Height / 2)))
        form.Show()
    End Sub
    Private Sub BBcctOffer_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BBcctOffer.ItemClick
        Dim form As frmScroller = New frmScroller()
        form.Text = "Έντυπο Προσφοράς Πελατών(Κουζίνα)"
        form.DataTable = "vw_CCT_OFFERS"
        form.MdiParent = Me
        form.Show()
    End Sub
    Private Sub BBCloset_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BBCloset.ItemClick
        Dim form As frmScroller = New frmScroller()
        form.Text = "Έντυπο Προσφοράς Πελατών(Ντουλάπα)"
        form.DataTable = "vw_CCT_OFFERS_CLOSET"
        form.MdiParent = Me
        form.Show()

    End Sub

    Private Sub BBDoors_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BBDoors.ItemClick
        Dim form As frmScroller = New frmScroller()
        form.Text = "Έντυπο Προσφοράς Πελατών(Πόρτες)"
        form.DataTable = "vw_CCT_OFFERS_DOOR"
        form.MdiParent = Me
        form.Show()
    End Sub

    Private Sub BBSpecialConstr_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BBSpecialConstr.ItemClick
        Dim form As frmScroller = New frmScroller()
        form.Text = "Έντυπο Προσφοράς Πελατών(Ειδικές Κατασκευές)"
        form.DataTable = "vw_CCT_OFFERS_SPECIAL_CONSTR"
        form.MdiParent = Me
        form.Show()
    End Sub

    Private Sub BBCCctOrdersKitchen_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BBCCctOrdersKitchen.ItemClick
        Dim form As frmScroller = New frmScroller()
        form.Text = "Έντυπο Παραγγελίας Πελατών(Κουζίνας)"
        form.DataTable = "vw_CCT_ORDERS_KITCHEN"
        form.MdiParent = Me
        form.Show()
    End Sub

    Private Sub BBEquipment_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BBEquipment.ItemClick
        Dim form As frmScroller = New frmScroller()
        form.Text = "Εξοπλισμός"
        form.DataTable = "vw_EQUIPMENT"
        form.MdiParent = Me
        form.Show()
    End Sub

    Private Sub BBDevices_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BBDevices.ItemClick
        Dim form As frmScroller = New frmScroller()
        form.Text = "Συσκευές"
        form.DataTable = "vw_DEVICES"
        form.MdiParent = Me
        form.Show()

    End Sub

    Private Sub BBequipmentCat_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BBequipmentCat.ItemClick
        Dim form As frmScroller = New frmScroller()
        form.Text = "Κατηγορίες Εξαρτήμάτων"
        form.DataTable = "vw_EQUIPMENT_CAT"
        form.MdiParent = Me
        form.Show()
    End Sub

    Private Sub BBCCctOrdersCloset_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BBCCctOrdersCloset.ItemClick
        Dim form As frmScroller = New frmScroller()
        form.Text = "Έντυπο Παραγγελίας Πελατών(Ντουλάπας)"
        form.DataTable = "vw_CCT_ORDERS_CLOSET"
        form.MdiParent = Me
        form.Show()
    End Sub

    Private Sub BBCCctDoorsCloset_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BBCCctDoorsCloset.ItemClick
        Dim form As frmScroller = New frmScroller()
        form.Text = "Έντυπο Παραγγελίας Πελατών(Πόρτες)"
        form.DataTable = "vw_CCT_ORDERS_DOOR"
        form.MdiParent = Me
        form.Show()
    End Sub

    Private Sub BBPrivateAgreement_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BBPrivateAgreement.ItemClick
        Dim form As frmScroller = New frmScroller()
        form.Text = "Ιδ. Συμφωνητικό"
        form.DataTable = "vw_AGREEMENT"
        form.MdiParent = Me
        form.Show()
    End Sub

    Private Sub BBSpecialOrder_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BBSpecialOrder.ItemClick
        Dim form As frmScroller = New frmScroller()
        form.Text = "Έντυπο Παραγγελίας Πελατών(Ειδικές Κατασκευές)"
        form.DataTable = "vw_CCT_ORDERS_SPECIAL_CONSTR"
        form.MdiParent = Me
        form.Show()
    End Sub

    Private Sub BBEpStatus_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BBEpStatus.ItemClick
        Dim form As frmScroller = New frmScroller()
        form.Text = "Status Εποπτείας"
        form.DataTable = "vw_EP_STATUS"
        form.MdiParent = Me
        form.Show()
    End Sub

    Private Sub BBSupOrders_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BBSupOrders.ItemClick
        Dim form As frmScroller = New frmScroller()
        form.Text = "Παραγγελίες Προμηθευτών"
        form.DataTable = "vw_SUP_ORDERS"
        form.MdiParent = Me
        form.Show()
    End Sub

    Private Sub BBTransConstr_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BBTransConstr.ItemClick
        Dim form As frmScroller = New frmScroller()
        form.Text = "Κλείσιμο Κατασκευής"
        form.DataTable = "vw_TRANS_CONSTR"
        form.MdiParent = Me
        form.Show()
    End Sub

    Private Sub BBEpopteiaTrans_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BBEpopteiaTrans.ItemClick

    End Sub

    Private Sub BBEpopteiaTable_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BBEpopteiaTable.ItemClick
        Dim form As frmScroller = New frmScroller()
        form.Text = "Εποπτεία Έργου"
        form.DataTable = "vw_EPOPTEIA"
        form.MdiParent = Me
        form.Show()
    End Sub

    Private Sub BBEpopteiaChart_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BBEpopteiaChart.ItemClick
        Dim form As frmEpopteiaChart = New frmEpopteiaChart()
        form.Text = "Εποτεία Έργων"
        form.MdiParent = Me
        form.Show()
    End Sub

    Private Sub BBTransCost_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BBTransCost.ItemClick
        Dim form As frmScroller = New frmScroller()
        form.Text = "Κοστολόγηση Έργων"
        form.DataTable = "vw_TRANSCOST"
        form.MdiParent = Me
        form.Show()
    End Sub

    Private Sub bbDimensionsCat_ItemClick(sender As Object, e As ItemClickEventArgs) Handles bbDimensionsCat.ItemClick
        Dim form As frmScroller = New frmScroller()
        form.Text = "Κατηγορίες Υλικών"
        form.BarNewRec.Enabled = False
        form.DataTable = "vw_DOOR_CAT"
        form.MdiParent = Me
        form.Show()
    End Sub

    Private Sub BBConstruct_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BBConstruct.ItemClick
        Dim form As frmScroller = New frmScroller()
        form.Text = "Είδη Κατασκευής"
        form.DataTable = "vw_CONSTR_TYPE"
        form.MdiParent = Me
        form.Show()
    End Sub

    Private Sub BBTechSup_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BBTechSup.ItemClick
        Dim form As frmScroller = New frmScroller()
        form.Text = "Τεχνική Υποστήριξη"
        form.DataTable = "vw_TECH_SUP"
        form.MdiParent = Me
        form.Show()
    End Sub

    Private Sub BBVer_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BBVer.ItemClick
        Dim form As frmScroller = New frmScroller()
        form.Text = "Εκδόσεις"
        form.DataTable = "vw_DMVER"
        form.MdiParent = Me
        form.Show()
    End Sub

    Private Sub BBEMP_P_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BBEMP_P.ItemClick
        If UserPermissions.CheckViewPermission("Παρουσιολόγιο Report") Then
            Dim form As frmScroller = New frmScroller()
            form.Text = "Παρουσιολόγιο Report"
            form.DataTable = "vw_EMP_P"
            form.MdiParent = Me
            form.Show()
        Else
            XtraMessageBox.Show("Δεν έχετε τα απαραίτητα δικαιώματα για να εισέλθετε", "Dreamy Kitchen CRM", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub BBOrderFormNumbers_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BBOrderFormNumbers.ItemClick
        Dim form As frmScroller = New frmScroller()
        form.Text = "Δελτία Παραγγελίας"
        form.DataTable = "vw_BUY_WITH_ORDERNUM"
        form.MdiParent = Me
        form.Show()
    End Sub

    Private Sub bbEmpConstrMov_ItemClick(sender As Object, e As ItemClickEventArgs) Handles bbEmpConstrMov.ItemClick
        If UserPermissions.CheckViewPermission("Παρουσιολόγιο Κατασκευαστικού") Then
            Dim form As frmEmpPresentation = New frmEmpPresentation()
            form.IsConstr = True
            form.Text = "Παρουσιολόγιο Κατασκευαστικού"
            form.MdiParent = Me
            form.Show()
        Else
            XtraMessageBox.Show("Δεν έχετε τα απαραίτητα δικαιώματα για να εισέλθετε", "Dreamy Kitchen CRM", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub BBinvBuyTypes_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BBinvBuyTypes.ItemClick
        Dim form As frmScroller = New frmScroller()
        form.Text = "Τύποι Παραστατικών"
        form.DataTable = "vw_DOC_TYPES"
        form.MdiParent = Me
        form.Show()
    End Sub

    Private Sub BBBulkInsertInvoices_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BBBulkInsertInvoices.ItemClick
        Dim form As frmBuyCollectionInsert = New frmBuyCollectionInsert()
        form.Text = "Αυτόματη Εισαγωγή Τιμολογίων Προμηθευτών"
        'UserPermissions.GetUserPermissions(form.Text) : If UserProps.AllowView = False Then XtraMessageBox.Show("Δεν έχουν οριστεί τα απαραίτητα δικαιώματα στον χρήστη", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error) : form.Dispose() : Exit Sub
        form.MdiParent = Me
        form.Show()
    End Sub

    Private Sub BBProjectJobs_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BBProjectJobs.ItemClick
        Dim form As frmScroller = New frmScroller()
        form.Text = "Εργασίες"
        form.DataTable = "vw_PROJECT_JOBS"
        form.MdiParent = Me
        form.Show()
    End Sub

    Private Sub BBBaseCatERP_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BBBaseCatERP.ItemClick
        Dim form As frmScroller = New frmScroller()
        form.Text = "Τύποι Κατασκευής"
        form.DataTable = "vw_BASE_CAT"
        form.MdiParent = Me
        form.Show()
    End Sub
End Class

