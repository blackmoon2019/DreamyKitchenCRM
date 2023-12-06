Imports System.ComponentModel
Imports System.Data.SqlClient
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid

Public Class frmTransactions
    Private Projects As New Projects
    Private sID As String
    Private sEMP_T_ID As String
    Private sProjectCostID As String
    Private Ctrl As DevExpress.XtraGrid.Views.Grid.GridView
    Private Frm As DevExpress.XtraEditors.XtraForm
    Public Mode As Byte
    Private ScanFile As ScanToPDF
    Private Valid As New ValidateControls
    Private Log As New Transactions
    Private FillCbo As New FillCombos
    Private DBQ As New DBQueries
    Private LoadForms As New FormLoader
    Private Cls As New ClearControls
    Private CtrlCombo As DevExpress.XtraEditors.LookUpEdit
    Private CalledFromCtrl As Boolean
    Private ManageCbo As New CombosManager
    Private TranshFieldAndValues As Dictionary(Of String, String)



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
        'TODO: This line of code loads data into the 'DM_TRANS.vw_PAYTYPES' table. You can move, or remove it, as needed.
        Me.Vw_PAYTYPESTableAdapter.Fill(Me.DM_TRANS.vw_PAYTYPES)
        Projects.Initialize(Me, sID, Mode, CalledFromCtrl, CtrlCombo, Frm)


        Select Case Mode
            Case FormMode.NewRecord
                dtCharge.EditValue = DateTime.Now : dtPay.EditValue = DateTime.Now : LayoutControlGroup2.Enabled = False : txtCodeH.Text = Projects.GetNextID
            Case FormMode.EditRecord
                TransHFieldAndValues = New Dictionary(Of String, String)
                LoadForms.LoadFormGRP(LayoutControlGroup1, "Select * from vw_TRANSH with(nolock) where id ='" + sID + "'",, TranshFieldAndValues)
                sEMP_T_ID = TranshFieldAndValues.Item("EmpTID").ToString
                sProjectCostID = TranshFieldAndValues.Item("ProjectCostID").ToString
                Me.TRANSH_FTableAdapter.FillByTanshID(Me.DM_TRANS.TRANSH_F, System.Guid.Parse(sID))
                Me.Vw_TRANSDTableAdapter.Fill(Me.DM_TRANS.vw_TRANSD, System.Guid.Parse(sID))
                Dim cmd As SqlCommand = New SqlCommand("Select transhCID from TRANSC WHERE transhID = " & toSQLValueS(sID), CNDB)
                Dim sdr As SqlDataReader = cmd.ExecuteReader()
                If sdr.HasRows Then
                    While sdr.Read()
                        cboTransC.Properties.GetItems.Item(System.Guid.Parse(sdr("transhCID").ToString)).CheckState = CheckState.Checked
                    End While
                End If
                sdr.Close()
                txtCodeD.Text = DBQ.GetNextId("TRANSD")
                dtPay.EditValue = DateTime.Now
        End Select
        LoadForms.RestoreLayoutFromXml(GridView2, "vw_TRANSH_F_def.xml")
        LoadForms.RestoreLayoutFromXml(GridView1, "TRANSD.xml")

        Me.CenterToScreen()
        cmdSaveTransH.Enabled = IIf(Mode = FormMode.NewRecord, UserProps.AllowInsert, UserProps.AllowEdit)
        cmdSaveTransD.Enabled = IIf(Mode = FormMode.NewRecord, UserProps.AllowInsert, UserProps.AllowEdit)
    End Sub

    Private Sub cmdSaveTransH_Click(sender As Object, e As EventArgs) Handles cmdSaveTransH.Click
        Projects.SaveRecordH()
    End Sub

    Private Sub frmTransactions_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        If Me.WindowState = FormWindowState.Maximized Then frmMain.XtraTabbedMdiManager1.Dock(Me, frmMain.XtraTabbedMdiManager1)
    End Sub

    Private Sub txtInvoiceFilename_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles txtInvoiceFilename.ButtonClick
        Dim sFilename As String
        Select Case e.Button.Index
            Case 0
                Dim result = XtraInputBox.Show("Πληκτρολογήστε το πλήθος σελίδων που θα σκανάρετε", "Όνομα Αρχείου", "1")

                ScanFile = New ScanToPDF
                If ScanFile.Scan(sFilename, Me.VwSCANFILENAMESBindingSource, result) = False Then Exit Sub
                txtInvoiceFilename.EditValue = sFilename
                If txtInvoiceFilename.Text <> "" Then
                    DBQ.InsertDataFilesFromScanner(sFilename, sID, "TRANSH_F")
                    Me.TRANSH_FTableAdapter.FillByTanshID(Me.DM_TRANS.TRANSH_F, System.Guid.Parse(sID))
                End If
                ScanFile = Nothing

            Case 1 : FilesSelection(XtraOpenFileDialog1, txtInvoiceFilename)

            Case 2 : txtInvoiceFilename.EditValue = Nothing
        End Select
    End Sub

    Private Sub GridView2_KeyDown(sender As Object, e As KeyEventArgs) Handles GridView2.KeyDown
        Select Case e.KeyCode
            Case Keys.Delete : Projects.DeleteRecordF()
        End Select
    End Sub

    Private Sub GridControl2_DoubleClick(sender As Object, e As EventArgs) Handles GridControl2.DoubleClick
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

    Private Sub cmdSaveTransD_Click(sender As Object, e As EventArgs) Handles cmdSaveTransD.Click
        Projects.SaveRecordD()
    End Sub

    Private Sub GridView1CellValueChanged(sender As Object, e As CellValueChangedEventArgs) Handles GridView1.CellValueChanged
        Dim cash As Byte, cmt As String, Paid As Byte
        Try
            Dim sSQL As String
            If Not IsDBNull(GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "cash")) Then
                If GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "cash") = True Then cash = 1 Else cash = 0
            End If
            If Not IsDBNull(GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "paid")) Then
                If GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "paid") = True Then Paid = 1 Else Paid = 0
            End If

            If Not IsDBNull(GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "cmt")) Then
                cmt = toSQLValueS(GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "cmt"))
            Else
                cmt = "NULL"
            End If

            sSQL = "UPDATE [TRANSD] SET dtPay  = " & toSQLValueS(CDate(GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "dtPay")).ToString("yyyyMMdd")) &
                ",bankID = " & toSQLValueS(GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "bankID").ToString) &
                ",PayTypeID = " & toSQLValueS(GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "PayTypeID").ToString) &
                ",cash = " & cash &
                ",paid = " & Paid &
                ",cmt = " & cmt &
                ",amt = " & toSQLValueS(GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "amt"), True) &
        " WHERE ID = " & toSQLValueS(GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "ID").ToString)
            Using oCmd As New SqlCommand(sSQL, CNDB)
                oCmd.ExecuteNonQuery()
            End Using
            sSQL = "UPDATE [TRANSH] SET bal  = " & toSQLValueS(txtBal.EditValue.ToString, True) &
                    " WHERE ID = " & toSQLValueS(sID)
            Using oCmd As New SqlCommand(sSQL, CNDB)
                oCmd.ExecuteNonQuery()
            End Using
        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub GridView1_PopupMenuShowing(sender As Object, e As PopupMenuShowingEventArgs) Handles GridView1.PopupMenuShowing
        Select Case e.MenuType
            Case GridMenuType.Column : LoadForms.PopupMenuShow(e, GridView1, "TRANSD.xml", "TRANSD")
            Case GridMenuType.User

        End Select
    End Sub

    Private Sub GridView1_KeyDown(sender As Object, e As KeyEventArgs) Handles GridView1.KeyDown
        Select Case e.KeyCode
            Case Keys.Delete : Projects.DeleteRecordD()
        End Select
    End Sub

    Private Sub RepositoryItemLookUpEdit1_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles RepositoryItemLookUpEdit1.ButtonClick
        Select Case e.Button.Index
            Case 0
            Case 1 : sender.EditValue = Nothing
        End Select

    End Sub

    Private Sub GridView1_CustomDrawFooterCell(sender As Object, e As FooterCellCustomDrawEventArgs) Handles GridView1.CustomDrawFooterCell
        If Me.IsActive = False Then Exit Sub
        txtBal.EditValue = GridView1.Columns("amt").SummaryItem.SummaryValue
        If txtTotAmt.Text = "0,00 €" Then txtTotAmt.EditValue = "0.00"
        txtBal.EditValue = txtTotAmt.EditValue - txtBal.EditValue
    End Sub

    Private Sub txtTotAmt_EditValueChanged(sender As Object, e As EventArgs) Handles txtTotAmt.EditValueChanged
        If Me.IsActive = False Then Exit Sub
        txtBal.EditValue = GridView1.Columns("amt").SummaryItem.SummaryValue
        If txtTotAmt.Text = "0,00 €" Then txtTotAmt.EditValue = "0.00"
        txtBal.EditValue = txtTotAmt.EditValue - txtBal.EditValue

    End Sub

    Private Sub frmTransactions_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        If XtraMessageBox.Show("Θέλετε να περάσετε εγγραφή στην Μισθοδοσία Τοποθετών?", ProgProps.ProgTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            Dim frmInstallations As New frmInstallations
            frmInstallations.Text = "Μισθοδοσία Τοποθετών"
            frmInstallations.MdiParent = frmMain
            frmInstallations.Mode = FormMode.NewRecord
            frmInstallations.Scroller = GridView1
            frmInstallations.FormScroller = Me
            frmInstallations.TRANSH_ID = sID
            If sEMP_T_ID <> Nothing Then
                frmInstallations.EMP_T_ID = sEMP_T_ID
            ElseIf txtEMP_T_ID.EditValue <> Nothing Then
                frmInstallations.EMP_T_ID = txtEMP_T_ID.EditValue.ToString
            End If

            frmInstallations.CalledFromControl = False
            'frmInstallations.cboSaler.EditValue = cboCUS.GetColumnValue("SalerID")
            frmInstallations.cboSaler.EditValue = cboSaler.EditValue
            frmInstallations.cboCUS.EditValue = cboCUS.EditValue
            frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(frmInstallations), New Point(CInt(frmInstallations.Parent.ClientRectangle.Width / 2 - frmInstallations.Width / 2), CInt(frmInstallations.Parent.ClientRectangle.Height / 2 - frmInstallations.Height / 2)))
            frmInstallations.Show()
        End If
    End Sub


    Private Sub GridView2_PopupMenuShowing(sender As Object, e As PopupMenuShowingEventArgs) Handles GridView2.PopupMenuShowing
        If e.MenuType = GridMenuType.Column Then LoadForms.PopupMenuShow(e, GridView1, "vw_TRANSH_F_def.xml",, "select top 1 [filename], [RealName], [code], [comefrom], [extension], [modifiedOn], [createdOn], [ID], [cctID], [isinvoice] from vw_TRANSH_F")
    End Sub

    Private Sub cmdPrintOffer_Click(sender As Object, e As EventArgs) Handles cmdPrintAll.Click
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
        Dim frmSalerTziroi As New frmSalerTziroi
        frmSalerTziroi.Text = "Τζίροι-Ποσοστά έκθεσης"
        frmSalerTziroi.ID = sEMP_T_ID
        frmSalerTziroi.MdiParent = frmMain
        frmSalerTziroi.Mode = FormMode.EditRecord
        frmSalerTziroi.Scroller = GridView1
        frmSalerTziroi.FormScroller = Me
        frmSalerTziroi.FormScrollerExist = True
        frmSalerTziroi.CalledFromControl = False
        frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(frmSalerTziroi), New Point(CInt(frmSalerTziroi.Parent.ClientRectangle.Width / 2 - frmSalerTziroi.Width / 2), CInt(frmSalerTziroi.Parent.ClientRectangle.Height / 2 - frmSalerTziroi.Height / 2)))
        frmSalerTziroi.Show()

    End Sub

    Private Sub BBProjectCosts_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BBProjectCosts.ItemClick
        Dim frmProjectCost As New frmProjectCost
        frmProjectCost.Text = "Ανάλυση Έργων"
        frmProjectCost.ID = sProjectCostID
        frmProjectCost.MdiParent = frmMain
        frmProjectCost.Mode = FormMode.EditRecord
        frmProjectCost.FormScroller = Me
        frmProjectCost.CalledFromControl = False
        frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(frmProjectCost), New Point(CInt(frmProjectCost.Parent.ClientRectangle.Width / 2 - frmProjectCost.Width / 2), CInt(frmProjectCost.Parent.ClientRectangle.Height / 2 - frmProjectCost.Height / 2)))
        frmProjectCost.Show()
    End Sub
End Class