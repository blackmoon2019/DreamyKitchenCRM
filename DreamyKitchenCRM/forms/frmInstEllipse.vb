
Imports System.ComponentModel
Imports DevExpress.XtraBars.Navigation
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports DreamyKitchenCRM.DM_TRANSTableAdapters

Public Class frmInstEllipse

    Private InstEllipse As New InstEllipse
    Private sID As String
    Private Ctrl As DevExpress.XtraGrid.Views.Grid.GridView
    Private Frm As DevExpress.XtraEditors.XtraForm
    Public Mode As Byte


    Private FScrollerExist As Boolean = False
    Private LoadForms As New FormLoader
    Private Log As New Transactions
    Private FillCbo As New FillCombos
    Private ManageCbo As New CombosManager
    Private sINST_ID As String
    Private Cls As New ClearControls
    Private CtrlCombo As DevExpress.XtraEditors.LookUpEdit
    Private CalledFromCtrl As Boolean
    Private sComeFrom As Integer

    Public WriteOnly Property ID As String
        Set(value As String)
            sID = value
        End Set
    End Property
    Public WriteOnly Property INST_ID As String
        Set(value As String)
            sINST_ID = value
        End Set
    End Property
    Public WriteOnly Property ComeFrom As Integer
        Set(value As Integer)
            sComeFrom = value
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

    Private Sub frmInstEllipse_Load(sender As Object, e As EventArgs) Handles Me.Load
        InstEllipse.INST_ID = sINST_ID
        InstEllipse.Initialize(Me, sID, Mode)
        InstEllipse.LoadForm()
        ComeFrom = InstEllipse.ComeFrom
        Me.CenterToScreen()
    End Sub
    Private Sub cmdExit_Click(sender As Object, e As EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub


    Private Sub frmInstEllipse_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        If Me.WindowState = FormWindowState.Maximized Then frmMain.XtraTabbedMdiManager1.Dock(Me, frmMain.XtraTabbedMdiManager1)
    End Sub

    Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click
        InstEllipse.SaveRecord(sID)
    End Sub
    Private Sub GridView1_InvalidRowException(sender As Object, e As InvalidRowExceptionEventArgs) Handles GridView1.InvalidRowException
        e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction
    End Sub
    Private Sub GridView1_KeyDown(sender As Object, e As KeyEventArgs) Handles GridView1.KeyDown
        If e.KeyCode = Keys.Delete And UserProps.AllowDelete = True Then InstEllipse.DeleteRecord()
        If e.KeyCode = Keys.Down And UserProps.AllowInsert Then
            If sender.FocusedRowHandle < 0 Then Exit Sub
            Dim viewInfo As GridViewInfo = TryCast(sender.GetViewInfo(), GridViewInfo)
            If sender.FocusedRowHandle = viewInfo.RowsInfo.Last().RowHandle Then
                If txtInstellipseFilename.EditValue = Nothing And txtInstellipseFilenameD.EditValue = Nothing And txtInstellipseFilenameC.EditValue = Nothing And txtInstellipseFilenameSC.EditValue = Nothing Then
                    XtraMessageBox.Show("Δεν έχετε επισυνάψει έντυπο εκκρεμοτήτων. Δεν μπορεί να αποθηκευθεί η εγγραφή.", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
                GridView1.PostEditor() : GridView1.AddNewRow()
            End If
        End If
    End Sub
    Private Sub GridView1_ValidateRow(sender As Object, e As ValidateRowEventArgs) Handles GridView1.ValidateRow
        InstEllipse.GridView1ValidateRow(e)
    End Sub

    Private Sub GridView1_CellValueChanging(sender As Object, e As CellValueChangedEventArgs) Handles GridView1.CellValueChanging

        If e.Column.FieldName = "completed" Then
            If e.Value = True Then GridView1.SetRowCellValue(GridView1.FocusedRowHandle, "dtCompleted", Date.Now) Else GridView1.SetRowCellValue(GridView1.FocusedRowHandle, "dtCompleted", Nothing)
        End If
    End Sub



    Private Sub txtInstellipseFilename_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles txtInstellipseFilename.ButtonClick
        Try
            Select Case e.Button.Index
                Case 0 : InstEllipse.FileSelect(0)
                Case 1 : InstEllipse.OpenFile(0)
                Case 2 : InstEllipse.DeleteFile(0)
            End Select
        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub txtInstellipseFilenameD_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles txtInstellipseFilenameD.ButtonClick
        Try
            Select Case e.Button.Index
                Case 0 : InstEllipse.FileSelect(1)
                Case 1 : InstEllipse.OpenFile(1)
                Case 2 : InstEllipse.DeleteFile(1)
            End Select
        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub txtInstellipseFilenameC_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles txtInstellipseFilenameC.ButtonClick
        Try
            Select Case e.Button.Index
                Case 0 : InstEllipse.FileSelect(2)
                Case 1 : InstEllipse.OpenFile(2)
                Case 2 : InstEllipse.DeleteFile(2)
            End Select
        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub txtInstellipseFilenameSC_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles txtInstellipseFilenameSC.ButtonClick
        Try
            Select Case e.Button.Index
                Case 0 : InstEllipse.FileSelect(3)
                Case 1 : InstEllipse.OpenFile(3)
                Case 2 : InstEllipse.DeleteFile(3)
            End Select
        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub cmdPrintAll_Click(sender As Object, e As EventArgs) Handles cmdPrintAll.Click
        InstEllipse.PrintDocument()
    End Sub
    Private Sub cboCUS_EditValueChanged(sender As Object, e As EventArgs) Handles cboCUS.EditValueChanged
        Dim sCusID As String
        If cboCUS.EditValue Is Nothing Then sCusID = toSQLValueS("00000000-0000-0000-0000-000000000000") Else sCusID = toSQLValueS(cboCUS.EditValue.ToString)
        Dim sSQL As New System.Text.StringBuilder
        sSQL.AppendLine("Select T.id,FullTranshDescription,Description,Iskitchen,Iscloset,Isdoor,Issc,offerCusAcceptance
                        from vw_TRANSH t
                        where   T.cusid = " & sCusID & "order by description")
        FillCbo.TRANSH(cboTRANSH, sSQL)
    End Sub

    Private Sub cboINST_EditValueChanged(sender As Object, e As EventArgs) Handles cboINST.EditValueChanged
        If Me.IsActive = False Then Exit Sub
        Try
            If cboINST.GetColumnValue("cusID").ToString <> "" Then cboCUS.EditValue = System.Guid.Parse(cboINST.GetColumnValue("cusID").ToString)
            If cboINST.GetColumnValue("transhID").ToString <> "" Then cboTRANSH.EditValue = System.Guid.Parse(cboINST.GetColumnValue("transhID").ToString)
        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub frmInstEllipse_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        If InstEllipse.ValidationsExit() = False Then e.Cancel = True : Exit Sub
    End Sub
    Private Sub TabPane1_SelectedPageChanged(sender As Object, e As SelectedPageChangedEventArgs) Handles TabPane1.SelectedPageChanged
        Select Case TabPane1.SelectedPageIndex
            Case 1 : InstEllipse.EmailTabSelected()
            Case 2 : InstEllipse.FilesTabSelected()
        End Select
    End Sub

    Private Sub DefInst_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles DefInst.ItemClick
        If sComeFrom = 0 Then
            txtBody.EditValue = ProgProps.InstEllipseInfBody.Replace("{INST_ELLIPSE_DATE_DELIVERED}", dtDateDelivered.Text)
            txtBody.EditValue = ProgProps.InstEllipseInfBody.Replace("{INST_DATE_DELIVERED}", cboINST.GetColumnValue("dtDeliverDate").ToString)
            txtSubject.EditValue = ProgProps.InstEllipseInfSubject
        Else
            txtBody.EditValue = ProgProps.InstEllipseInfBodySup.Replace("{CUS}", cboCUS.Text)
            txtSubject.EditValue = ProgProps.InstEllipseInfSubjectSup
        End If
    End Sub
    Private Sub DefInstComplete_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles DefInstComplete.ItemClick
        If sComeFrom = 0 Then
            If dtDateDelivered.EditValue IsNot Nothing Then txtBody.EditValue = ProgProps.InstEllipseInfBodyComplete.Replace("{INST_ELLIPSE_DATE_DELIVERED}", dtDateDelivered.Text)
            txtSubject.EditValue = ProgProps.InstEllipseInfSubjectComplete
        End If

    End Sub
    Private Sub DefInstAppointment_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles DefInstAppointment.ItemClick
        txtBody.EditValue = ProgProps.InstEllipseInfAppointmentBody
        txtBody.EditValue = txtBody.EditValue.Replace("{INST_ELLIPSE_DATE_DELIVERED}", dtDateDelivered.Text)
        txtBody.EditValue = txtBody.EditValue.Replace("{INST_DATE_DELIVERED}", cboINST.GetColumnValue("dtDeliverDate").ToString)
        txtBody.EditValue = txtBody.EditValue.Replace("{INST_ELLIPSE_TIME_FROM}", txtTmINFrom.Text)
        txtBody.EditValue = txtBody.EditValue.Replace("{INST_ELLIPSE_TIME_TO}", txtTmINTo.Text)
        txtSubject.EditValue = ProgProps.InstEllipseInfAppointmentSubject
    End Sub
    Private Sub cmdSendApointmentEmail_Click(sender As Object, e As EventArgs) Handles cmdSendApointmentEmail.Click
        InstEllipse.emailMode = 1 : InstEllipse.ValidateEmail()
    End Sub

    Private Sub cmdSendEmail_Click(sender As Object, e As EventArgs) Handles cmdSendEmail.Click
        InstEllipse.emailMode = 2 : InstEllipse.ValidateEmail()
    End Sub
    Private Sub cmdSendEmailComplete_Click(sender As Object, e As EventArgs) Handles cmdSendEmailComplete.Click
        InstEllipse.emailMode = 3 : InstEllipse.ValidateEmail()
    End Sub

    Private Sub cmdNewInstEllipse_Click(sender As Object, e As EventArgs) Handles cmdNewInstEllipse.Click
        If GridView1.DataRowCount = 0 Then
            XtraMessageBox.Show("Δεν έχετε καταχωρήσει εκκρεμότητες. Δεν μπορεί να δημιουργηθεί νέα εγγραφή.", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If InstEllipse.CheckIfInstJobsAreCompleted() Then
            XtraMessageBox.Show("Όλες οι εκρεμμότητες είναι ολοκληρωμένες. Δεν μπορεί να δημιουργηθεί νέα εγγραφή.", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        InstEllipse.NewRecord()
    End Sub


    Private Sub txtInstellipseFilenameComplete_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles txtInstellipseFilenameComplete.ButtonClick
        Try
            Select Case e.Button.Index
                Case 0
                    'Έλεγχος για να δεί αν υπάρχει μη ολοκληρωμένη έλλειψη.Αν υπάρχει δεν μπορεί να επισυνάψει έντυπο ολοκλήρωσης
                    If InstEllipse.CheckIfInstJobsAreCompleted() = False Then
                        XtraMessageBox.Show("Δεν μπορείτε επισυνάψετε έντυπο ολοκλήρωσης όταν υπάρχει έστω και μια μη ολοκληρωμένη εκκρεμότητα.", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Else
                        InstEllipse.FileSelect(4)
                    End If
                Case 1 : InstEllipse.OpenFile(4)
                Case 2 : InstEllipse.DeleteFile(4)
            End Select
        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub GridView1_PopupMenuShowing(sender As Object, e As PopupMenuShowingEventArgs) Handles GridView1.PopupMenuShowing
        If e.MenuType = GridMenuType.Column Then
            If sComeFrom = 1 Then
                LoadForms.PopupMenuShow(e, GridView1, "INST_ELLIPSE_JOBS_def_SUP.xml", "INST_ELLIPSE_JOBS")
            Else
                LoadForms.PopupMenuShow(e, GridView1, "INST_ELLIPSE_JOBS_def.xml", "INST_ELLIPSE_JOBS")
            End If
        End If
    End Sub

    Private Sub GridView3_PopupMenuShowing(sender As Object, e As PopupMenuShowingEventArgs) Handles GridView3.PopupMenuShowing
        If e.MenuType = GridMenuType.Column Then LoadForms.PopupMenuShow(e, GridView3, "INST_MAIL_ELLIPSE.xml", "vw_INST_MAIL")
    End Sub

    Private Sub cmdConvertToOrder_Click(sender As Object, e As EventArgs) Handles cmdConvertToOrder.Click
        InstEllipse.ConvertToOrder()
    End Sub

    Private Sub cmdViewOrder_Click(sender As Object, e As EventArgs) Handles cmdViewOrder.Click
        InstEllipse.ViewOrder()
    End Sub

    Private Sub GridView3_CustomRowCellEdit(sender As Object, e As CustomRowCellEditEventArgs) Handles GridView3.CustomRowCellEdit
        If e.Column.FieldName = "imageCell" Then
            e.RepositoryItem = txtImageAttachment
            GridView3.SetRowCellValue(GridView3.FocusedRowHandle, "imageCell", "Επισυναπτόμενο")
        End If
    End Sub

    Private Sub GridView3_DoubleClick(sender As Object, e As EventArgs) Handles GridView3.DoubleClick
        InstEllipse.OpenEmailAttachment()
    End Sub

    Private Sub cboCUS_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboCUS.ButtonClick
        Select Case e.Button.Index
            Case 1 : ManageCbo.ManageCCT(FormMode.NewRecord, False,, cboCUS)
            Case 2 : ManageCbo.ManageCCT(FormMode.EditRecord, False,, cboCUS)
            Case 3 : cboCUS.EditValue = Nothing
        End Select
    End Sub

    Private Sub cboTRANSH_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboTRANSH.ButtonClick
        Select Case e.Button.Index
            Case 1 : ManageCbo.ManageTRANSH(cboTRANSH, FormMode.NewRecord, cboCUS.EditValue)
            Case 2 : ManageCbo.ManageTRANSH(cboTRANSH, FormMode.EditRecord, cboCUS.EditValue)
            Case 3 : cboTRANSH.EditValue = Nothing
        End Select
    End Sub
    Private Sub cboINST_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboINST.ButtonClick
        Select Case e.Button.Index
            Case 1 : ManageCbo.ManageINST(cboINST, FormMode.NewRecord)
            Case 2 : ManageCbo.ManageINST(cboINST, FormMode.EditRecord)
            Case 3 : cboINST.EditValue = Nothing
        End Select

    End Sub
    Private Sub txtFiles_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles txtFiles.ButtonClick

        Select Case e.Button.Index
            Case 0 : InstEllipse.ScanFiles()
            Case 1 : FilesSelection(XtraOpenFileDialog1, txtFiles)
            Case 2 : txtFiles.EditValue = Nothing
        End Select
    End Sub

    Private Sub cmdSaveTransF_Click(sender As Object, e As EventArgs) Handles cmdSaveTransF.Click
        XtraOpenFileDialog1.Tag = cboTanshFCategory.EditValue.ToString
        InstEllipse.SaveRecordF(0)
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
    Private Sub GridView5_ValidateRow(sender As Object, e As ValidateRowEventArgs) Handles GridView5.ValidateRow
        InstEllipse.GridView5ValidateRow(e)
    End Sub
    Private Sub GridView5_PopupMenuShowing(sender As Object, e As PopupMenuShowingEventArgs) Handles GridView5.PopupMenuShowing
        If e.MenuType = GridMenuType.Column Then LoadForms.PopupMenuShow(e, GridView5, "vw_TRANSH_F_INST_ELLIPSE_def.xml", "vw_TRANSH_F")
    End Sub


End Class
