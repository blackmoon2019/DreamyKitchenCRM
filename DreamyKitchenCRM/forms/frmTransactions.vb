Imports System.ComponentModel
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid

Public Class frmTransactions
    Private Projects As New Projects
    Private sID As String
    Private Ctrl As DevExpress.XtraGrid.Views.Grid.GridView
    Private Frm As DevExpress.XtraEditors.XtraForm
    Public Mode As Byte
    Private ScanFile As ScanToPDF
    Private Valid As New ValidateControls
    Private FillCbo As New FillCombos
    Private DBQ As New DBQueries
    Private Cls As New ClearControls
    Private CtrlCombo As DevExpress.XtraEditors.LookUpEdit
    Private CalledFromCtrl As Boolean
    Private ManageCbo As New CombosManager
    Private LoadForms As New FormLoader

    Public WriteOnly Property ID As String
        Set(value As String)
            sID = value
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
    Private Sub cmdExit_Click(sender As Object, e As EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub

    Private Sub frmTransactions_Load(sender As Object, e As EventArgs) Handles Me.Load
        Projects.Initialize(Me, sID, Mode, CalledFromCtrl, CtrlCombo)
        Projects.LoadForm()
        Me.CenterToScreen()
    End Sub

    Private Sub frmTransactions_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        If Me.WindowState = FormWindowState.Maximized Then frmMain.XtraTabbedMdiManager1.Dock(Me, frmMain.XtraTabbedMdiManager1)
    End Sub

    Private Sub cmdSaveTransD_Click(sender As Object, e As EventArgs) Handles cmdSaveTransD.Click
        Projects.SaveRecordD() : txtBal.Text = Projects.GetTransDAmt
    End Sub

    Private Sub GridView1CellValueChanged(sender As Object, e As CellValueChangedEventArgs) Handles GridView1.CellValueChanged
        Projects.UpdateRecordD() : txtBal.Text = Projects.GetTransDAmt
    End Sub
    Private Sub cmdSaveTransH_Click(sender As Object, e As EventArgs) Handles cmdSaveTransH.Click
        Projects.SaveRecordH() : txtBal.Text = Projects.GetTransDAmt
    End Sub
    Private Sub cboCOU_EditValueChanged(sender As Object, e As EventArgs) Handles cboCOU.EditValueChanged
        Dim sSQL As New System.Text.StringBuilder
        If cboCOU.EditValue <> Nothing Then sSQL.AppendLine(" where couid = " & toSQLValueS(cboCOU.EditValue.ToString))
        FillCbo.AREAS(cboAREAS, sSQL)
        FillCbo.ADR(cboADR, ManageCbo.ADRsSQL(cboCOU, cboAREAS))
    End Sub

    Private Sub cboAREAS_EditValueChanged(sender As Object, e As EventArgs) Handles cboCOU.EditValueChanged
        FillCbo.ADR(cboADR, ManageCbo.ADRsSQL(cboCOU, cboAREAS))
    End Sub
    Private Sub cboCOU_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboCOU.ButtonClick
        Select Case e.Button.Index
            Case 1 : cboCOU.EditValue = Nothing : ManageCbo.ManageCOU(cboCOU, FormMode.NewRecord)
            Case 2 : If cboCOU.EditValue <> Nothing Then ManageCbo.ManageCOU(cboCOU, FormMode.EditRecord)
            Case 3 : cboCOU.EditValue = Nothing
        End Select
    End Sub
    Private Sub cboAREAS_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboAREAS.ButtonClick
        Select Case e.Button.Index
            Case 1 : cboAREAS.EditValue = Nothing : ManageCbo.ManageAREAS(cboAREAS, FormMode.NewRecord)
            Case 2 : If cboAREAS.EditValue <> Nothing Then ManageCbo.ManageAREAS(cboAREAS, FormMode.EditRecord)
            Case 3 : cboAREAS.EditValue = Nothing
        End Select
    End Sub

    Private Sub cboADR_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboADR.ButtonClick
        Select Case e.Button.Index
            Case 1 : cboADR.EditValue = Nothing : ManageCbo.ManageADR(cboADR, FormMode.NewRecord)
            Case 2 : If cboADR.EditValue <> Nothing Then ManageCbo.ManageADR(cboADR, FormMode.EditRecord)
            Case 3 : cboADR.EditValue = Nothing
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
                If txtFiles.Text <> "" Then
                    DBQ.InsertDataFilesFromScanner(sFilename, sID, "TRANSH_F")
                    Me.TRANSH_FTableAdapter.FillByTanshID(Me.DM_TRANS.TRANSH_F, System.Guid.Parse(sID))
                End If
                ScanFile = Nothing

            Case 1 : FilesSelection(XtraOpenFileDialog1, txtFiles)

            Case 2 : txtFiles.EditValue = Nothing
        End Select
    End Sub

    Private Sub GridView2_KeyDown(sender As Object, e As KeyEventArgs) Handles GridView2.KeyDown
        Select Case e.KeyCode
            Case Keys.Delete : Projects.DeleteRecordF()
        End Select
    End Sub

    Private Sub GridControl2_DoubleClick(sender As Object, e As EventArgs) Handles GridControl2.KeyDown
        OpenFile(GridView2, "TRANSH_F")
    End Sub
    Private Sub cboCUS_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboCUS.ButtonClick
        Select Case e.Button.Index
            Case 1 : ManageCbo.ManageCCT(FormMode.NewRecord, False,, cboCUS)
            Case 2 : ManageCbo.ManageCCT(FormMode.EditRecord, False,, cboCUS)
            Case 3 : cboCUS.EditValue = Nothing
        End Select
    End Sub


    Private Sub cboBANK_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboBANK.ButtonClick
        Select Case e.Button.Index
            Case 1 : ManageCbo.ManageBank(cboBANK, FormMode.NewRecord)
            Case 2 : ManageCbo.ManageBank(cboBANK, FormMode.EditRecord)
            Case 3 : cboBANK.EditValue = Nothing
        End Select
    End Sub
    Private Sub cboSaler_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboSaler.ButtonClick
        Select Case e.Button.Index
            Case 1 : ManageCbo.ManageSaler(cboSaler, FormMode.NewRecord)
            Case 2 : ManageCbo.ManageSaler(cboSaler, FormMode.EditRecord)
            Case 3 : cboSaler.EditValue = Nothing
        End Select
    End Sub


    Private Sub cboBANK_EditValueChanged(sender As Object, e As EventArgs) Handles cboBANK.EditValueChanged
        If cboBANK.EditValue IsNot Nothing Then chkCash.Enabled = False : chkCash.Checked = False Else chkCash.Enabled = True
    End Sub

    Private Sub GridView1_PopupMenuShowing(sender As Object, e As PopupMenuShowingEventArgs) Handles GridView1.PopupMenuShowing
        Select Case e.MenuType
            Case GridMenuType.Column : LoadForms.PopupMenuShow(e, GridView1, "TRANSD.xml", "TRANSD")
            Case GridMenuType.User
        End Select
    End Sub

    Private Sub GridView1_KeyDown(sender As Object, e As KeyEventArgs) Handles GridView1.KeyDown
        Select Case e.KeyCode
            Case Keys.Delete : Projects.DeleteRecordD() : txtBal.Text = Projects.GetTransDAmt
        End Select
    End Sub

    Private Sub RepositoryItemLookUpEdit1_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles RepositoryItemLookUpEdit1.ButtonClick
        Select Case e.Button.Index
            Case 0
            Case 1 : sender.EditValue = Nothing
        End Select

    End Sub


    Private Sub frmTransactions_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Projects.LoadInstallations(True)
    End Sub


    Private Sub GridView2_PopupMenuShowing(sender As Object, e As PopupMenuShowingEventArgs) Handles GridView2.PopupMenuShowing
        If e.MenuType = GridMenuType.Column Then LoadForms.PopupMenuShow(e, GridView1, "vw_TRANSH_F_def.xml",, "select top 1 [filename], [RealName], [code], [comefrom], [extension], [modifiedOn], [createdOn], [ID], [cctID], [isinvoice] from vw_TRANSH_F")
    End Sub

    Private Sub cmdPrintAll_Click(sender As Object, e As EventArgs) Handles cmdPrintAll.Click
        Projects.PrintedForms()
    End Sub

    Private Sub txtExtraCost_EditValueChanged(sender As Object, e As EventArgs) Handles txtExtraCost.EditValueChanged
        If Me.IsActive = False Then Exit Sub
        Dim ExtraCost As Double, Debit As Double, Devices As Double
        If txtExtraCost.EditValue Is Nothing Or txtDevicesCost.EditValue Is Nothing Or txtDebitCost.EditValue Is Nothing Then Exit Sub
        Debit = DbnullToZero(txtDebitCost) : Devices = DbnullToZero(txtDevicesCost) : ExtraCost = DbnullToZero(txtExtraCost)
        txtTotAmt.EditValue = Debit + Devices + ExtraCost
    End Sub
    Private Sub txtDebitCost_EditValueChanged(sender As Object, e As EventArgs) Handles txtDebitCost.EditValueChanged
        If Me.IsActive = False Then Exit Sub
        Dim Debit As Double, Devices As Double
        If txtDevicesCost.EditValue Is Nothing Or txtDebitCost.EditValue Is Nothing Then Exit Sub
        Debit = DbnullToZero(txtDebitCost) : Devices = DbnullToZero(txtDevicesCost)
        txtTotAmt.EditValue = Debit + Devices
    End Sub

    Private Sub txtDevicesCost_EditValueChanged(sender As Object, e As EventArgs) Handles txtDevicesCost.EditValueChanged
        If Me.IsActive = False Then Exit Sub
        Dim Debit As Double, Devices As Double
        If txtDevicesCost.EditValue Is Nothing Or txtDebitCost.EditValue Is Nothing Then Exit Sub
        Debit = DbnullToZero(txtDebitCost) : Devices = DbnullToZero(txtDevicesCost)
        txtTotAmt.EditValue = Debit + Devices

    End Sub

    Private Sub cboPayType_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboPayType.ButtonClick
        Select Case e.Button.Index
            Case 1 : ManageCbo.ManagePAY_TYPE(cboPayType, FormMode.NewRecord)
            Case 2 : ManageCbo.ManagePAY_TYPE(cboPayType, FormMode.EditRecord)
            Case 3 : cboPayType.EditValue = Nothing
        End Select
    End Sub

    Private Sub bbEMP_T_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbEMP_T.ItemClick
        Projects.LoadSalerTziroi()
    End Sub

    Private Sub BBProjectCosts_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BBProjectCosts.ItemClick
        Projects.LoadProjectCost()
    End Sub

    Private Sub BBInstallations_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BBInstallations.ItemClick
        Projects.LoadInstallations()
    End Sub


End Class