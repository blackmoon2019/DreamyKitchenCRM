Imports System.ComponentModel
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraBars.Navigation
Imports DevExpress.XtraGrid.Views.Grid
Imports DreamyKitchenCRM.DM_TRANSTableAdapters
Imports System.Data.SqlClient
Imports DevExpress.XtraGrid.Views.Base


Public Class frmInstallations
    Private ScanFile As ScanToPDF
    Private UserPermissions As New CheckPermissions
    Public Installations As New Installations
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
            Case 3
                LoadForms.RestoreLayoutFromXml(GridView5, "vw_TRANSH_F_INST_def.xml")
                If cboTRANSH.EditValue IsNot Nothing Then TRANSH_FTableAdapter.FillByTranshID(DM_TRANS.TRANSH_F, System.Guid.Parse(cboTRANSH.EditValue.ToString))
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
    Private Sub GridView5_PopupMenuShowing(sender As Object, e As PopupMenuShowingEventArgs) Handles GridView5.PopupMenuShowing
        If e.MenuType = GridMenuType.Column Then LoadForms.PopupMenuShow(e, GridView5, "vw_TRANSH_F_INST_def.xml", "vw_TRANSH_F")
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
    Private Sub txtFiles_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles txtFiles.ButtonClick
        Dim sFilename As String
        Select Case e.Button.Index
            Case 0
                Dim result = XtraInputBox.Show("Πληκτρολογήστε το πλήθος σελίδων που θα σκανάρετε", "Όνομα Αρχείου", "1")
                ScanFile = New ScanToPDF
                If ScanFile.Scan(sFilename, Me.VwSCANFILENAMESBindingSource, result) = False Then Exit Sub
                txtFiles.EditValue = sFilename
                If txtFiles.Text <> "" Then Installations.SaveRecordF(1, sFilename)
                ScanFile = Nothing
            Case 1 : FilesSelection(XtraOpenFileDialog1, txtFiles)
            Case 2 : txtFiles.EditValue = Nothing
        End Select
    End Sub
    Private Sub cmdSaveTransF_Click(sender As Object, e As EventArgs) Handles cmdSaveTransF.Click
        XtraOpenFileDialog1.Tag = cboTanshFCategory.EditValue.ToString
        Installations.SaveRecordF(0)
    End Sub
    Private Sub cboTanshFCategory_ButtonPressed(sender As Object, e As ButtonPressedEventArgs) Handles cboTanshFCategory.ButtonPressed
        Select Case e.Button.Index
            Case 1 : cboTanshFCategory.EditValue = Nothing : ManageCbo.ManageFCategory(cboTanshFCategory, FormMode.NewRecord)
            Case 2 : If cboTanshFCategory.EditValue IsNot Nothing Then ManageCbo.ManageFCategory(cboTanshFCategory, FormMode.EditRecord)
            Case 3 : cboTanshFCategory.EditValue = Nothing
        End Select
    End Sub
    Private Sub GridControl2_DoubleClick(sender As Object, e As EventArgs) Handles GridControl2.DoubleClick
        OpenFileFromGrid(GridView5, "TRANSH_F")
    End Sub

    Private Sub TabPane2_SelectedPageChanged(sender As Object, e As SelectedPageChangedEventArgs) Handles TabPane2.SelectedPageChanged
        'If Me.IsActive = False Then Exit Sub
        'Select Case TabPane2.SelectedPageIndex
        '    Case 0 : Installations.FillListSER(0)   'ΚΟΥΖΙΝΑ
        '    Case 1 : Installations.FillListSER(1)   'ΝΤΟΥΛΑΠΑ
        '    Case 2 : Installations.FillListSER(2)   'ΠΟΡΤΑ
        '    Case 3 : Installations.FillListSER(3)   'ΕΙΔΙΚΗ ΚΑΤΑΣΚΕΥΗ
        'End Select

    End Sub
    Private Sub cmdConstInstK_Click(sender As Object, e As EventArgs) Handles cmdConstInstK.Click
        Installations.OpenCostForm(0, sID)
    End Sub
    Private Sub cmdConstInstC_Click(sender As Object, e As EventArgs) Handles cmdConstInstC.Click
        Installations.OpenCostForm(1, sID)
    End Sub
    Private Sub cmdConstInstD_Click(sender As Object, e As EventArgs) Handles cmdConstInstD.Click
        Installations.OpenCostForm(2, sID)
    End Sub
    Private Sub cmdConstInstSC_Click(sender As Object, e As EventArgs) Handles cmdConstInstSC.Click
        Installations.OpenCostForm(3, sID)
    End Sub

    Private Sub cboTRANSH_EditValueChanged(sender As Object, e As EventArgs) Handles cboTRANSH.EditValueChanged
        TabNavKitchen.Enabled = cboTRANSH.GetColumnValue("Iskitchen") : TabPane2.SelectedPage = TabNavKitchen
        TabNavCloset.Enabled = cboTRANSH.GetColumnValue("Iscloset") : TabPane2.SelectedPage = TabNavCloset
        TabNavDoor.Enabled = cboTRANSH.GetColumnValue("Isdoor") : TabPane2.SelectedPage = TabNavDoor
        TabNavSC.Enabled = cboTRANSH.GetColumnValue("Issc") : TabPane2.SelectedPage = TabNavSC
        'ΚΟΥΖΙΝΑ
        If cboTRANSH.GetColumnValue("Iskitchen") = "True" Then Installations.FillListSER(0)
        'ΝΤΟΥΛΑΠΑ
        If cboTRANSH.GetColumnValue("Iscloset") = "True" Then Installations.FillListSER(1)
        'ΠΟΡΤΑ
        If cboTRANSH.GetColumnValue("Isdoor") = "True" Then Installations.FillListSER(2)
        'ΕΙΔΙΚΗ ΚΑΤΑΣΚΕΥΗ
        If cboTRANSH.GetColumnValue("Issc") = "True" Then Installations.FillListSER(3)
    End Sub

    Private Sub cboExtPartnerKitchen_ButtonPressed(sender As Object, e As ButtonPressedEventArgs) Handles cboExtPartnerKitchen.ButtonPressed
        Select Case e.Button.Index
            Case 1 : cboExtPartnerKitchen.EditValue = Nothing : ManageCbo.ManageEMP(cboExtPartnerKitchen, FormMode.NewRecord, True)
            Case 2 : If cboExtPartnerKitchen.EditValue IsNot Nothing Then ManageCbo.ManageEMP(cboExtPartnerKitchen, FormMode.EditRecord, True)
            Case 3 : cboExtPartnerKitchen.EditValue = Nothing : cmdConstInstK.Enabled = False
        End Select
    End Sub
    Private Sub cboExtPartnerCloset_ButtonPressed(sender As Object, e As ButtonPressedEventArgs) Handles cboExtPartnerCloset.ButtonPressed
        Select Case e.Button.Index
            Case 1 : cboExtPartnerCloset.EditValue = Nothing : ManageCbo.ManageEMP(cboExtPartnerCloset, FormMode.NewRecord, True)
            Case 2 : If cboExtPartnerCloset.EditValue IsNot Nothing Then ManageCbo.ManageEMP(cboExtPartnerCloset, FormMode.EditRecord, True)
            Case 3 : cboExtPartnerCloset.EditValue = Nothing : cmdConstInstC.Enabled = False
        End Select
    End Sub
    Private Sub cboExtPartnerDoors_ButtonPressed(sender As Object, e As ButtonPressedEventArgs) Handles cboExtPartnerDoors.ButtonPressed
        Select Case e.Button.Index
            Case 1 : cboExtPartnerDoors.EditValue = Nothing : ManageCbo.ManageEMP(cboExtPartnerDoors, FormMode.NewRecord, True)
            Case 2 : If cboExtPartnerDoors.EditValue IsNot Nothing Then ManageCbo.ManageEMP(cboExtPartnerDoors, FormMode.EditRecord, True)
            Case 3 : cboExtPartnerDoors.EditValue = Nothing : cmdConstInstD.Enabled = False
        End Select
    End Sub
    Private Sub cboExtPartnerSC_ButtonPressed(sender As Object, e As ButtonPressedEventArgs) Handles cboExtPartnerSC.ButtonPressed
        Select Case e.Button.Index
            Case 1 : cboExtPartnerSC.EditValue = Nothing : ManageCbo.ManageEMP(cboExtPartnerSC, FormMode.NewRecord, True)
            Case 2 : If cboExtPartnerSC.EditValue IsNot Nothing Then ManageCbo.ManageEMP(cboExtPartnerSC, FormMode.EditRecord, True)
            Case 3 : cboExtPartnerSC.EditValue = Nothing : cmdConstInstSC.Enabled = False
        End Select
    End Sub

    Private Sub cboExtPartnerKitchen_EditValueChanged(sender As Object, e As EventArgs) Handles cboExtPartnerKitchen.EditValueChanged
        Installations.SetCostButtonEnabled(0)
    End Sub

    Private Sub cboExtPartnerCloset_EditValueChanged(sender As Object, e As EventArgs) Handles cboExtPartnerCloset.EditValueChanged
        Installations.SetCostButtonEnabled(1)
    End Sub

    Private Sub cboExtPartnerDoors_EditValueChanged(sender As Object, e As EventArgs) Handles cboExtPartnerDoors.EditValueChanged
        Installations.SetCostButtonEnabled(2)
    End Sub

    Private Sub cboExtPartnerSC_EditValueChanged(sender As Object, e As EventArgs) Handles cboExtPartnerSC.EditValueChanged
        Installations.SetCostButtonEnabled(3)
    End Sub

    Private Sub cmdDeleteInstCostK_Click(sender As Object, e As EventArgs) Handles cmdDeleteInstCostK.Click
        Installations.DeleteInstCost(0)
    End Sub

    Private Sub cmdDeleteInstCostC_Click(sender As Object, e As EventArgs) Handles cmdDeleteInstCostC.Click
        Installations.DeleteInstCost(1)
    End Sub

    Private Sub cmdDeleteInstCostD_Click(sender As Object, e As EventArgs) Handles cmdDeleteInstCostD.Click
        Installations.DeleteInstCost(2)
    End Sub

    Private Sub cmdDeleteInstCostSC_Click(sender As Object, e As EventArgs) Handles cmdDeleteInstCostSC.Click
        Installations.DeleteInstCost(3)
    End Sub

    Private Sub GridView5_ValidateRow(sender As Object, e As ValidateRowEventArgs) Handles GridView5.ValidateRow
        Dim sSQL As New System.Text.StringBuilder
        Try
            sSQL.Clear()
            sSQL.AppendLine("UPDATE TRANSH_F	SET FileCatID= " & toSQLValueS(GridView5.GetRowCellValue(GridView5.FocusedRowHandle, "fileCatID").ToString) & ",")
            sSQL.AppendLine("modifiedBY = " & toSQLValueS(UserProps.ID.ToString) & ",")
            sSQL.AppendLine("modifiedON = getdate() ")
            sSQL.AppendLine("WHERE ID = " & toSQLValueS(GridView5.GetRowCellValue(GridView5.FocusedRowHandle, "ID").ToString))
            'Εκτέλεση QUERY
            Using oCmd As New SqlCommand(sSQL.ToString, CNDB)
                oCmd.ExecuteNonQuery()
            End Using
        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class