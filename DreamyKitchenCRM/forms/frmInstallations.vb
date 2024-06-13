Imports System.ComponentModel
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraBars.Navigation
Imports DevExpress.XtraGrid.Views.Grid

Public Class frmInstallations
    Private Installations As New Installations
    Private LoadForms As New FormLoader
    Private ManageCbo As New CombosManager
    Private sID As String
    Private sEMP_T_ID As String
    Private sTRANSH_ID As String
    Private FScrollerExist As Boolean = False
    Private CalledFromCtrl As Boolean
    Public Mode As Byte
    Private CtrlCombo As DevExpress.XtraEditors.LookUpEdit
    Private Ctrl As DevExpress.XtraGrid.Views.Grid.GridView
    Private Frm As DevExpress.XtraEditors.XtraForm


    Public WriteOnly Property ID As String
        Set(value As String)
            sID = value
        End Set
    End Property
    Public WriteOnly Property EMP_T_ID As String
        Set(value As String)
            sEMP_T_ID = value
        End Set
    End Property
    Public WriteOnly Property TRANSH_ID As String
        Set(value As String)
            sTRANSH_ID = value
        End Set
    End Property
    Public WriteOnly Property Scroller As DevExpress.XtraGrid.Views.Grid.GridView
        Set(value As DevExpress.XtraGrid.Views.Grid.GridView)
            Ctrl = value
        End Set
    End Property
    Public WriteOnly Property FormScroller As DevExpress.XtraEditors.XtraForm
        Set(value As DevExpress.XtraEditors.XtraForm)
            Frm = value
        End Set
    End Property
    Public WriteOnly Property CallerControl As DevExpress.XtraEditors.LookUpEdit
        Set(value As DevExpress.XtraEditors.LookUpEdit)
            CtrlCombo = value
        End Set
    End Property
    Public WriteOnly Property CalledFromControl As Boolean
        Set(value As Boolean)
            CalledFromCtrl = value
        End Set
    End Property
    Public WriteOnly Property FormScrollerExist As Boolean
        Set(value As Boolean)
            FScrollerExist = value
        End Set
    End Property

    Private Sub frmInstallations_Load(sender As Object, e As EventArgs) Handles Me.Load
        Installations.Initialize(Me, sID, Mode, CalledFromCtrl, CtrlCombo, sEMP_T_ID)
        Installations.LoadForm()
        Me.CenterToScreen()
    End Sub

    Private Sub frmInstallations_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        If Me.WindowState = FormWindowState.Maximized Then frmMain.XtraTabbedMdiManager1.Dock(Me, frmMain.XtraTabbedMdiManager1)
    End Sub
    Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click
        Installations.SaveRecord(sID)
    End Sub

    Private Sub frmInstallations_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        If sEMP_T_ID Is Nothing Then Exit Sub
        Installations.UpdateSaleTziroi()
    End Sub

    Private Sub cmdInstEllipse_Click(sender As Object, e As EventArgs) Handles cmdInstEllipse.Click
        'Έλεγχος για να δεί αν υπάρχει μη ολοκληρωμένη έλλειψη πριν ανοίξει καινούρια γιαυτην την τοποθέτηση 
        If Installations.CheckIfHasInstNotCompleted() = True Then XtraMessageBox.Show("Δεν μπορείτε να δημιουργήσετε νέα εγγραφή όταν υπάρχει μη ολοκληρωμένη εκκρεμότητα.", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error) : Exit Sub
        'Eλεγχος αν υπάρχει έντυπο ολοκλήρωσης
        If Installations.CheckIfEllipseHasCompleteDocument() = True Then XtraMessageBox.Show("Δεν μπορείτε να δημιουργήσετε νέα εγγραφή, έχουν ολοκληρωθεί όλες οι εκκρεμότητες.", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error) : Exit Sub
        Installations.OpenInstEllipseForm(True)
    End Sub


    Private Sub cboCUS_EditValueChanged(sender As Object, e As EventArgs) Handles cboCUS.EditValueChanged
        Dim sCusID As String
        If cboCUS.EditValue Is Nothing Then sCusID = Guid.Empty.ToString Else sCusID = cboCUS.EditValue.ToString
        Me.Vw_TRANSHTableAdapter.Fill(Me.DM_TRANS.vw_TRANSH, System.Guid.Parse(sCusID))
    End Sub

    Private Sub txtInstFilename_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles txtInstFilename.ButtonClick
        Select Case e.Button.Index
            Case 0
                If Installations.CheckIfExistInstEllipse() = False Then
                    Installations.FileSelect()
                Else
                    XtraMessageBox.Show("Δεν μπορείτε να ανεβάσετε έντυπο ολοκλήρωσης γιατί υπάρχουν εκκρεμότητες", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Case 1 : Installations.OpenFile()
            Case 2 : Installations.DeleteFile()
        End Select
    End Sub

    Private Sub TabPane1_SelectedPageChanged(sender As Object, e As SelectedPageChangedEventArgs) Handles TabPane1.SelectedPageChanged
        Select Case TabPane1.SelectedPageIndex
            Case 0
            Case 1 : Installations.LoadRecords()
            Case 2 : Installations.TabMail()
        End Select
    End Sub

    Private Sub GridView1_DoubleClick(sender As Object, e As EventArgs) Handles GridView1.DoubleClick
        Installations.OpenInstEllipseForm(False)
    End Sub

    Private Sub GridView1_KeyDown(sender As Object, e As KeyEventArgs) Handles GridView1.KeyDown
        If e.KeyCode = Keys.Delete Then Installations.InstEllipseDelete()
    End Sub
    Private Sub GridView1_PopupMenuShowing(sender As Object, e As PopupMenuShowingEventArgs) Handles GridView1.PopupMenuShowing
        If e.MenuType = GridMenuType.Column Then LoadForms.PopupMenuShow(e, GridView1, "vw_INST_ELLIPSE_INSIDE.xml", "vw_INST_ELLIPSE")
    End Sub
    Private Sub GridView2_PopupMenuShowing(sender As Object, e As PopupMenuShowingEventArgs) Handles GridView2.PopupMenuShowing
        If e.MenuType = GridMenuType.Column Then LoadForms.PopupMenuShow(e, GridView2, "D_INST_ELLIPSE_JOBS_INSIDE.xml", "INST_ELLIPSE_JOBS")
    End Sub
    Private Sub GridView3_PopupMenuShowing(sender As Object, e As PopupMenuShowingEventArgs) Handles GridView3.PopupMenuShowing
        If e.MenuType = GridMenuType.Column Then LoadForms.PopupMenuShow(e, GridView3, "INST_MAIL.xml", "vw_INST_MAIL")
    End Sub

    Private Sub cmdSendApointmentEmail_Click(sender As Object, e As EventArgs) Handles cmdSendApointmentEmail.Click
        Installations.ValidateEmail()
    End Sub

    Private Sub cmdExit_Click(sender As Object, e As EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub

    Private Sub cboTRANSH_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboTRANSH.ButtonClick
        Select Case e.Button.Index
            Case 1 : ManageCbo.ManageTRANSH(cboTRANSH, FormMode.NewRecord)
            Case 2 : ManageCbo.ManageTRANSH(cboTRANSH, FormMode.EditRecord)
            Case 3 : cboTRANSH.EditValue = Nothing
        End Select
    End Sub
    Private Sub cboCUS_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboCUS.ButtonClick
        Select Case e.Button.Index
            Case 1 : ManageCbo.ManageCCT(FormMode.NewRecord, False,, cboCUS)
            Case 2 : ManageCbo.ManageCCT(FormMode.EditRecord, False,, cboCUS)
            Case 3 : cboCUS.EditValue = Nothing
        End Select
    End Sub
    Private Sub cboSaler_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboSaler.ButtonClick
        Select Case e.Button.Index
            Case 1 : ManageCbo.ManageSaler(cboSaler, FormMode.NewRecord)
            Case 2 : ManageCbo.ManageSaler(cboSaler, FormMode.EditRecord)
            Case 3 : cboSaler.EditValue = Nothing
        End Select
    End Sub

End Class