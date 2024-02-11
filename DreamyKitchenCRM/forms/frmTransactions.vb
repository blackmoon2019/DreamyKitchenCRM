Imports System.ComponentModel
Imports System.Data.SqlClient
Imports DevExpress.XtraBars.Navigation
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo

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
    Private ShowCreditOnly As Boolean
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
    Public WriteOnly Property CreditOnly As Boolean
        Set(value As Boolean)
            ShowCreditOnly = value
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
        AddHandler GridControl3.EmbeddedNavigator.ButtonClick, AddressOf Grid_EmbeddedNavigator_ButtonClick
        Projects.Initialize(Me, sID, Mode, CalledFromCtrl, CtrlCombo)
        Projects.LoadForm(ShowCreditOnly)
        Me.CenterToScreen()
    End Sub

    Private Sub frmTransactions_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        If Me.WindowState = FormWindowState.Maximized Then frmMain.XtraTabbedMdiManager1.Dock(Me, frmMain.XtraTabbedMdiManager1)
    End Sub

    Private Sub cmdSaveTransD_Click(sender As Object, e As EventArgs) Handles cmdSaveTransD.Click
        Projects.SaveRecordD() : txtBal.Text = Projects.GetTranshBal
    End Sub
    Private Sub cmdSaveTransH_Click(sender As Object, e As EventArgs) Handles cmdSaveTransH.Click
        Projects.SaveRecordH() : txtBal.Text = Projects.GetTranshBal
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
                If txtFiles.Text <> "" Then Projects.SaveRecordF(1, sFilename)
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

    Private Sub GridControl2_DoubleClick(sender As Object, e As EventArgs) Handles GridControl2.DoubleClick
        OpenFileFromGrid(GridView2, "TRANSH_F")
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
            Case GridMenuType.Column : LoadForms.PopupMenuShow(e, GridView1, "TRANSD.xml", "vw_TRANSD")
            Case GridMenuType.User
        End Select
    End Sub

    Private Sub GridView1_KeyDown(sender As Object, e As KeyEventArgs) Handles GridView1.KeyDown
        Select Case e.KeyCode
            Case Keys.Delete : Projects.DeleteRecordD() : txtBal.Text = Projects.GetTranshBal
        End Select
    End Sub

    Private Sub RepositoryItemLookUpEdit1_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles RepositoryItemLookUpEdit1.ButtonClick
        Select Case e.Button.Index
            Case 0
            Case 1 : sender.EditValue = Nothing
        End Select

    End Sub
    Private Sub txtTotAmt_EditValueChanged(sender As Object, e As EventArgs) Handles txtTotAmt.EditValueChanged
        If Me.IsActive = False Then Exit Sub
        CalculateBal()
    End Sub
    Private Sub CalculateBal()
        Dim dAmt As Double = 0
        If GridView1.Columns.Item("amt").SummaryItem.SummaryValue IsNot Nothing Then dAmt = GridView1.Columns.Item("amt").SummaryItem.SummaryValue
        txtBal.Text = txtTotAmt.EditValue - dAmt
    End Sub
    Private Sub frmTransactions_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Projects.LoadInstallations(True)
    End Sub


    Private Sub GridView2_PopupMenuShowing(sender As Object, e As PopupMenuShowingEventArgs) Handles GridView2.PopupMenuShowing
        If e.MenuType = GridMenuType.Column Then LoadForms.PopupMenuShow(e, GridView2, "vw_TRANSH_F_def.xml", "vw_TRANSH_F")
    End Sub

    Private Sub cmdPrintAll_Click(sender As Object, e As EventArgs) Handles cmdPrintAll.Click
        Projects.PrintedForms()
    End Sub

    Private Sub txtExtraCost_EditValueChanged(sender As Object, e As EventArgs) Handles txtExtraCost.EditValueChanged
        If Me.IsActive = False Then Exit Sub
        CalculateTotAmt()
    End Sub
    Private Sub txtDebitCost_EditValueChanged(sender As Object, e As EventArgs) Handles txtDebitCost.EditValueChanged
        If Me.IsActive = False Then Exit Sub
        CalculateTotAmt()
    End Sub

    Private Sub txtDevicesCost_EditValueChanged(sender As Object, e As EventArgs) Handles txtDevicesCost.EditValueChanged
        If Me.IsActive = False Then Exit Sub
        CalculateTotAmt()
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

    Private Sub GridView1_ValidateRow(sender As Object, e As ValidateRowEventArgs) Handles GridView1.ValidateRow
        GridView1.UpdateTotalSummary() : CalculateBal()

        If Projects.UpdateRecordD() = False Then e.Valid = False
        txtBal.Text = Projects.GetTranshBal

    End Sub

    Private Sub GridView1_InvalidRowException(sender As Object, e As InvalidRowExceptionEventArgs) Handles GridView1.InvalidRowException
        e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction
    End Sub

    Private Sub txtbenchSalesPrice_EditValueChanged(sender As Object, e As EventArgs) Handles txtbenchSalesPrice.EditValueChanged
        If Me.IsActive = False Then Exit Sub
        CalculateTotAmt() : CalculateBenchProfit()
    End Sub
    Private Sub CalculateTotAmt()
        Dim ExtraCost As Double, Debit As Double, Devices As Double, BenchSalesPrice As Double
        If txtExtraCost.EditValue Is Nothing Or txtDevicesCost.EditValue Is Nothing Or txtDebitCost.EditValue Is Nothing Then Exit Sub
        Debit = DbnullToZero(txtDebitCost) : Devices = DbnullToZero(txtDevicesCost) : ExtraCost = DbnullToZero(txtExtraCost) : BenchSalesPrice = DbnullToZero(txtbenchSalesPrice)
        txtTotAmt.EditValue = Debit + Devices + ExtraCost + BenchSalesPrice
    End Sub

    Private Sub txtbenchPurchasePrice_EditValueChanged(sender As Object, e As EventArgs) Handles txtbenchPurchasePrice.EditValueChanged
        If Me.IsActive = False Then Exit Sub
        CalculateBenchProfit()
    End Sub
    Private Sub CalculateBenchProfit()
        Dim benchPurchasePrice As Double, benchSalesPrice As Double
        If txtbenchPurchasePrice.EditValue Is Nothing Or txtbenchSalesPrice.EditValue Is Nothing Then Exit Sub
        benchPurchasePrice = DbnullToZero(txtbenchPurchasePrice) : benchSalesPrice = DbnullToZero(txtbenchSalesPrice)
        txtbenchProfit.EditValue = benchPurchasePrice - benchSalesPrice
    End Sub
    Private Sub GridView3_InvalidRowException(sender As Object, e As InvalidRowExceptionEventArgs) Handles GridView3.InvalidRowException
        e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction
    End Sub
    Private Sub Grid_EmbeddedNavigator_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.NavigatorButtonClickEventArgs)
        Select Case e.Button.ButtonType
            Case e.Button.ButtonType.Remove : DeleteRecord() : e.Handled = True
            Case e.Button.ButtonType.Append
        End Select
    End Sub
    Private Sub GridView3_KeyDown(sender As Object, e As KeyEventArgs) Handles GridView3.KeyDown
        If e.KeyCode = Keys.Delete And UserProps.AllowDelete = True Then DeleteRecord()
        If e.KeyCode = Keys.Down And UserProps.AllowInsert Then
            If sender.FocusedRowHandle < 0 Then Exit Sub
            Dim viewInfo As GridViewInfo = TryCast(sender.GetViewInfo(), GridViewInfo)
            If sender.FocusedRowHandle = viewInfo.RowsInfo.Last().RowHandle Then
                GridView3.PostEditor() : GridView3.AddNewRow()
            End If
        End If
    End Sub
    Private Sub DeleteRecord()
        If GridView3.GetRowCellValue(GridView3.FocusedRowHandle, "ID") = Nothing Then Exit Sub
        If XtraMessageBox.Show("Θέλετε να διαγραφεί η τρέχουσα εγγραφή?", ProgProps.ProgTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            Dim sSQL As String = "DELETE FROM TRANS_EXTRA_CHARGES WHERE ID = '" & GridView3.GetRowCellValue(GridView3.FocusedRowHandle, "ID").ToString & "'"
            Using oCmd As New SqlCommand(sSQL, CNDB)
                oCmd.ExecuteNonQuery()
            End Using
            Me.Vw_TRANS_EXTRA_CHARGESTableAdapter.FillBytranshID(Me.DM_TRANS.vw_TRANS_EXTRA_CHARGES, System.Guid.Parse(sID))
        End If
    End Sub
    Private Sub GridView3_ValidateRow(sender As Object, e As ValidateRowEventArgs) Handles GridView3.ValidateRow
        Dim sSQL As New System.Text.StringBuilder
        Try
            sSQL.Clear()
            If e.RowHandle = GridControl3.NewItemRowHandle Then
                If GridView3.GetRowCellValue(GridView3.FocusedRowHandle, "name").ToString = "" Then
                    e.ErrorText = "Παρακαλώ συμπληρώστε περιγραφή"
                    e.Valid = False
                    Exit Sub
                End If
                If GridView3.GetRowCellValue(GridView3.FocusedRowHandle, "amt").ToString = "0" Then
                    e.ErrorText = "Παρακαλώ συμπληρώστε κόστος"
                    e.Valid = False
                    Exit Sub
                End If

                sSQL.AppendLine("INSERT INTO TRANS_EXTRA_CHARGES (transhID,name,amt,[modifiedBy],[createdby],[createdOn])")
                sSQL.AppendLine("Select " & toSQLValueS(sID) & ",")
                sSQL.AppendLine(toSQLValueS(GridView3.GetRowCellValue(GridView3.FocusedRowHandle, "name").ToString) & ",")
                sSQL.AppendLine(toSQLValueS(GridView3.GetRowCellValue(GridView3.FocusedRowHandle, "amt"), True) & ",")
                sSQL.Append(toSQLValueS(UserProps.ID.ToString) & "," & toSQLValueS(UserProps.ID.ToString) & ", getdate()")
                'Εκτέλεση QUERY
                Using oCmd As New SqlCommand(sSQL.ToString, CNDB)
                    oCmd.ExecuteNonQuery()
                End Using
                Me.Vw_TRANS_EXTRA_CHARGESTableAdapter.FillBytranshID(Me.DM_TRANS.vw_TRANS_EXTRA_CHARGES, System.Guid.Parse(sID))
            Else
                sSQL.AppendLine("UPDATE TRANS_EXTRA_CHARGES	SET name= " & toSQLValueS(GridView3.GetRowCellValue(GridView3.FocusedRowHandle, "name").ToString) & ",")
                sSQL.AppendLine("amt= " & toSQLValueS(GridView3.GetRowCellValue(GridView3.FocusedRowHandle, "amt"), True) & ",")
                sSQL.AppendLine("modifiedBY = " & toSQLValueS(UserProps.ID.ToString) & ",")
                sSQL.AppendLine("modifiedON = getdate() ")
                sSQL.AppendLine("WHERE ID = " & toSQLValueS(GridView3.GetRowCellValue(GridView3.FocusedRowHandle, "ID").ToString))
                'Εκτέλεση QUERY
                Using oCmd As New SqlCommand(sSQL.ToString, CNDB)
                    oCmd.ExecuteNonQuery()
                End Using
                Me.Vw_TRANS_EXTRA_CHARGESTableAdapter.FillBytranshID(Me.DM_TRANS.vw_TRANS_EXTRA_CHARGES, System.Guid.Parse(sID))
            End If
            sSQL.Clear()
            sSQL.AppendLine("UPDATE TRANSH	SET extracost=(select sum(amt) from TRANS_EXTRA_CHARGES where transhID =  " & toSQLValueS(sID) & ") where ID = " & toSQLValueS(sID))
            'Εκτέλεση QUERY
            Using oCmd As New SqlCommand(sSQL.ToString, CNDB)
                oCmd.ExecuteNonQuery()
            End Using
            Dim cmd As SqlCommand = New SqlCommand("Select extracost from TRANSH WHERE ID = " & toSQLValueS(sID), CNDB)
            Dim sdr As SqlDataReader = cmd.ExecuteReader()
            If sdr.HasRows Then
                While sdr.Read()
                    If sdr.IsDBNull(sdr.GetOrdinal("extracost")) = False Then txtExtraCost.EditValue = sdr.GetDecimal(sdr.GetOrdinal("extracost"))
                End While
            End If
            sdr.Close()
        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub TabPane1_SelectedPageChanged(sender As Object, e As SelectedPageChangedEventArgs) Handles TabPane1.SelectedPageChanged
        If Me.IsActive = False Then Exit Sub
        Select Case TabPane1.SelectedPageIndex
            Case 0  'Projects.LoadForm()
            Case 1
            Case 2 : Me.Vw_TRANS_EXTRA_CHARGESTableAdapter.FillBytranshID(Me.DM_TRANS.vw_TRANS_EXTRA_CHARGES, System.Guid.Parse(sID))
            Case Else
        End Select
    End Sub
    Private Sub GridView3_PopupMenuShowing(sender As Object, e As PopupMenuShowingEventArgs) Handles GridView3.PopupMenuShowing
        If e.MenuType = GridMenuType.Column Then LoadForms.PopupMenuShow(e, GridView3, "Vw_TRANS_EXTRA_CHARGES.xml", "Vw_TRANS_EXTRA_CHARGES")
    End Sub

    Private Sub chkreceiveDateAgreement_CheckStateChanged(sender As Object, e As EventArgs) Handles chkreceiveDateAgreement.CheckStateChanged
        If chkreceiveDateAgreement.CheckState = CheckState.Checked Then dtreceiveDateAgreement.EditValue = Date.Now Else dtreceiveDateAgreement.EditValue = Nothing
    End Sub

    Private Sub cmdSaveTransF_Click(sender As Object, e As EventArgs) Handles cmdSaveTransF.Click
        XtraOpenFileDialog1.Tag = cboTanshFCategory.EditValue.ToString
        Projects.SaveRecordF(0)
    End Sub

    Private Sub cboTanshFCategory_ButtonPressed(sender As Object, e As ButtonPressedEventArgs) Handles cboTanshFCategory.ButtonPressed
        Select Case e.Button.Index
            Case 1 : cboTanshFCategory.EditValue = Nothing : ManageCbo.ManageFCategory(cboTanshFCategory, FormMode.NewRecord)
            Case 2 : If cboTanshFCategory.EditValue <> Nothing Then ManageCbo.ManageFCategory(cboTanshFCategory, FormMode.EditRecord)
            Case 3 : cboTanshFCategory.EditValue = Nothing
        End Select

    End Sub

    Private Sub RepositoryItemCCT_ButtonPressed(sender As Object, e As ButtonPressedEventArgs) Handles RepositoryItemCCT.ButtonPressed
        Select Case e.Button.Index
            Case 1 : GridView1.SetRowCellValue(GridView1.FocusedRowHandle, "cusID", Nothing)
        End Select
    End Sub
    Private Sub cboCompany_EditValueChanged(sender As Object, e As EventArgs) Handles cboCompany.EditValueChanged
        Dim sCompID As String
        If cboCompany.EditValue Is Nothing Then sCompID = toSQLValueS(Guid.Empty.ToString) Else sCompID = toSQLValueS(cboCompany.EditValue.ToString)
        Dim sSQL As New System.Text.StringBuilder
        sSQL.AppendLine("Select T.id,FullTranshDescription,Description,Iskitchen,Iscloset,Isdoor,Issc
                        from vw_TRANSH t
                        where  T.cusid = " & sCompID & "order by description")
        FillCbo.TRANSH(cboCompProject, sSQL)
        LCompProject.ImageOptions.Image = Global.DreamyKitchenCRM.My.Resources.Resources.rsz_11rsz_asterisk
        If chkcompProject.CheckState = CheckState.Checked Then cboCUS.EditValue = cboCompany.EditValue : LCUS.Enabled = False Else cboCUS.EditValue = Nothing : LCUS.Enabled = True
    End Sub

    Private Sub cboCompProject_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboCompProject.ButtonClick
        Select Case e.Button.Index
            Case 1 : ManageCbo.ManageTRANSHSmall(cboCompProject, FormMode.NewRecord, cboCompany.EditValue)
            Case 2 : ManageCbo.ManageTRANSHSmall(cboCompProject, FormMode.EditRecord, cboCompany.EditValue)
            Case 3 : cboCompProject.EditValue = Nothing
        End Select
    End Sub

    Private Sub cboCompany_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboCompany.ButtonClick
        Select Case e.Button.Index
            Case 1 : ManageCbo.ManageCCT(FormMode.NewRecord, False,, cboCompany)
            Case 2 : ManageCbo.ManageCCT(FormMode.EditRecord, False,, cboCompany)
            Case 3 : cboCompany.EditValue = Nothing : LCompProject.ImageOptions.Image = Nothing
        End Select
    End Sub



    Private Sub cboCUSD_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboCUSD.ButtonClick
        Select Case e.Button.Index
            Case 1 : ManageCbo.ManageCCT(FormMode.NewRecord, False,, cboCUSD)
            Case 2 : ManageCbo.ManageCCT(FormMode.EditRecord, False,, cboCUSD)
            Case 3 : cboCUSD.EditValue = Nothing
        End Select
    End Sub
    Private Sub GridView4_ValidateRow(sender As Object, e As ValidateRowEventArgs) Handles GridView4.ValidateRow
        Projects.SaveRecordD(False, e)
    End Sub

    Private Sub GridView4_InvalidRowException(sender As Object, e As InvalidRowExceptionEventArgs) Handles GridView4.InvalidRowException
        e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction
    End Sub

    Private Sub GridView4_KeyDown(sender As Object, e As KeyEventArgs) Handles GridView4.KeyDown
        If e.KeyCode = Keys.Delete And UserProps.AllowDelete = True Then Projects.DeleteRecordD(False)
    End Sub

    Private Sub GridView4_PopupMenuShowing(sender As Object, e As PopupMenuShowingEventArgs) Handles GridView4.PopupMenuShowing
        If e.MenuType = GridMenuType.Column Then LoadForms.PopupMenuShow(e, GridView4, "Vw_TRANSD_Debit.xml", "Vw_TRANSD")
    End Sub

    Private Sub chkcompProject_CheckStateChanged(sender As Object, e As EventArgs) Handles chkcompProject.CheckStateChanged
        If chkcompProject.CheckState = CheckState.Checked Then cboCUS.EditValue = cboCompany.EditValue : LCUS.Enabled = False Else cboCUS.EditValue = Nothing : LCUS.Enabled = True
    End Sub
End Class