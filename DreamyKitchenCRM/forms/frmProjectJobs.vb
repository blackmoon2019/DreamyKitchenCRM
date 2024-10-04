Imports DevExpress.XtraBars.Navigation
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports System.ComponentModel
Imports System.Data.SqlClient

Public Class frmProjectJobs
    Private sID As String
    Public Mode As Byte
    Private FScrollerExist As Boolean = False
    Private sComeFrom As Integer
    Private CalledFromCtrl As Boolean
    Private HasConnectedOrder As Boolean = False
    Private ScanFile As ScanToPDF
    Private Prog_Prop As New ProgProp
    Private Valid As New ValidateControls
    Private ProjectJobs As New ProjectJobs
    Private LoadForms As New FormLoader
    Private Ctrl As DevExpress.XtraGrid.Views.Grid.GridView
    Private Frm As DevExpress.XtraEditors.XtraForm
    Private ManageCbo As New CombosManager
    Private CtrlCombo As DevExpress.XtraEditors.LookUpEdit

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
    Public WriteOnly Property FormScrollerExist As Boolean
        Set(value As Boolean)
            FScrollerExist = value
        End Set
    End Property
    Public Property ComeFrom() As Int16
        Get
            Return sComeFrom
        End Get
        Set(value As Int16)
            sComeFrom = value
        End Set
    End Property

    Private Sub cmdExit_Click(sender As Object, e As EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub

    Private Sub frmProjectJobs_Load(sender As Object, e As EventArgs) Handles Me.Load
        'TODO: This line of code loads data into the 'DreamyKitchenDataSet.vw_FILE_CAT' table. You can move, or remove it, as needed.
        Me.Vw_FILE_CATTableAdapter.Fill(Me.DreamyKitchenDataSet.vw_FILE_CAT)
        ProjectJobs.Initialize(Me, sID, Mode)
        ProjectJobs.LoadForm()
        ComeFrom = ProjectJobs.ComeFrom
        AddHandler GridControl1.EmbeddedNavigator.ButtonClick, AddressOf Grid_EmbeddedNavigator_ButtonClick
        Me.CenterToScreen()
    End Sub

    Private Sub cboCUS_EditValueChanged(sender As Object, e As EventArgs) Handles cboCUS.EditValueChanged
        ProjectJobs.CUSEditValueChanged()
    End Sub

    Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click
        ProjectJobs.SaveRecord(sID)
    End Sub
    Private Sub cboCUS_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboCUS.ButtonClick
        Select Case e.Button.Index
            Case 1 : ManageCbo.ManageCCT(FormMode.NewRecord, False,, cboCUS)
            Case 2 : ManageCbo.ManageCCT(FormMode.EditRecord, False,, cboCUS)
            Case 3 : cboCUS.EditValue = Nothing
        End Select
    End Sub
    Private Sub cboSaler_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboEmp.ButtonClick
        Select Case e.Button.Index
            Case 1 : ManageCbo.ManageSaler(cboEmp, FormMode.NewRecord)
            Case 2 : ManageCbo.ManageSaler(cboEmp, FormMode.EditRecord)
            Case 3 : cboEmp.EditValue = Nothing
        End Select
    End Sub
    Private Sub cboTRANSH_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboTRANSH.ButtonClick
        Select Case e.Button.Index
            Case 1 : ManageCbo.ManageTRANSH(cboTRANSH, FormMode.NewRecord, cboCUS.EditValue)
            Case 2 : ManageCbo.ManageTRANSH(cboTRANSH, FormMode.EditRecord, cboCUS.EditValue)
            Case 3 : cboTRANSH.EditValue = Nothing
        End Select
    End Sub
    Private Sub frmProjectJobs_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        If Me.WindowState = FormWindowState.Maximized Then frmMain.XtraTabbedMdiManager1.Dock(Me, frmMain.XtraTabbedMdiManager1)
    End Sub
    Private Sub cboTRANSH_EditValueChanged(sender As Object, e As EventArgs) Handles cboTRANSH.EditValueChanged
        dtInstDeliverDate.EditValue = cboTRANSH.GetColumnValue("instdtDeliverDate")
    End Sub
    Private Sub GridView1_InvalidRowException(sender As Object, e As InvalidRowExceptionEventArgs) Handles GridView1.InvalidRowException
        e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction
    End Sub
    Private Sub Grid_EmbeddedNavigator_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.NavigatorButtonClickEventArgs)
        Select Case e.Button.ButtonType
            Case e.Button.ButtonType.Remove : ProjectJobs.DeleteRecord() : e.Handled = True
            Case e.Button.ButtonType.Append
        End Select
    End Sub
    Private Sub GridView1_KeyDown(sender As Object, e As KeyEventArgs) Handles GridView1.KeyDown
        If e.KeyCode = Keys.Delete And UserProps.AllowDelete = True Then ProjectJobs.DeleteRecord()
        If e.KeyCode = Keys.Down And UserProps.AllowInsert And sComeFrom = 0 Then
            If sender.FocusedRowHandle < 0 Then Exit Sub
            Dim viewInfo As GridViewInfo = TryCast(sender.GetViewInfo(), GridViewInfo)
            If sender.FocusedRowHandle = viewInfo.RowsInfo.Last().RowHandle Then
                GridView1.PostEditor() : GridView1.AddNewRow()
            End If
        End If
    End Sub

    Private Sub GridView1_ValidateRow(sender As Object, e As ValidateRowEventArgs) Handles GridView1.ValidateRow
        If e.RowHandle = GridControl1.NewItemRowHandle Then
            If GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "description").ToString = "" And sComeFrom = 0 Then
                e.ErrorText = "Παρακαλώ συμπληρώστε την εργασία"
                XtraMessageBox.Show(e.ErrorText, ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
                e.Valid = False
                Exit Sub
            End If
            If GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "cost").ToString = "" And sComeFrom = 0 Then
                e.ErrorText = "Παρακαλώ συμπληρώστε κόστος"
                XtraMessageBox.Show(e.ErrorText, ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
                e.Valid = False
                Exit Sub
            End If

            ProjectJobs.SaveRecordProjectD(True)
        Else
            If GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "descriptionSup").ToString = "" And sComeFrom = 1 Then
                e.ErrorText = "Παρακαλώ συμπληρώστε την εργασία"
                XtraMessageBox.Show(e.ErrorText, ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
                e.Valid = False
                Exit Sub
            Else
                If GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "cost").ToString = "" And sComeFrom = 0 Then
                    e.ErrorText = "Παρακαλώ συμπληρώστε κόστος"
                    XtraMessageBox.Show(e.ErrorText, ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
                    e.Valid = False
                    Exit Sub
                End If

                If GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "description").ToString = "" And sComeFrom = 0 Then
                    e.ErrorText = "Παρακαλώ συμπληρώστε την εργασία"
                    XtraMessageBox.Show(e.ErrorText, ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
                    e.Valid = False
                    Exit Sub
                End If
                ProjectJobs.SaveRecordProjectD(False)
            End If
        End If
    End Sub

    Private Sub GridView1_CellValueChanging(sender As Object, e As CellValueChangedEventArgs) Handles GridView1.CellValueChanging
        If e.Column.FieldName = "completed" Then
            If e.Value = True Then GridView1.SetRowCellValue(GridView1.FocusedRowHandle, "dtCompleted", Date.Now) Else GridView1.SetRowCellValue(GridView1.FocusedRowHandle, "dtCompleted", Nothing)
        End If
    End Sub

    Private Sub cmdConvertToOrder_Click(sender As Object, e As EventArgs) Handles cmdConvertToOrder.Click
        ProjectJobs.ConvertToOrder()
    End Sub

    Private Sub cmdNewProjectJob_Click(sender As Object, e As EventArgs) Handles cmdNewProjectJob.Click
        If GridView1.DataRowCount = 0 Then
            XtraMessageBox.Show("Δεν έχετε καταχωρήσει εργασίες. Δεν μπορεί να δημιουργηθεί νέα εγγραφή.", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If ProjectJobs.CheckIfProjectJobsAreCompleted() Then
            XtraMessageBox.Show("Όλες οι εργασίες είναι ολοκληρωμένες. Δεν μπορεί να δημιουργηθεί νέα εγγραφή.", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        ProjectJobs.NewRecord()
    End Sub

    Private Sub cmdViewOrder_Click(sender As Object, e As EventArgs) Handles cmdViewOrder.Click
        ProjectJobs.ViewOrder()
    End Sub

    Private Sub cmdPrintAll_Click(sender As Object, e As EventArgs) Handles cmdPrintAll.Click
        ProjectJobs.PrintDocument()
    End Sub

    Private Sub txtfProjectNameComplete_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles txtfProjectNameComplete.ButtonClick
        Try
            Select Case e.Button.Index
                Case 0
                    'Έλεγχος για να δεί αν υπάρχει μη ολοκληρωμένη εργασία.Αν υπάρχει δεν μπορεί να επισυνάψει έντυπο ολοκλήρωσης
                    If ProjectJobs.CheckIfProjectJobsAreCompleted() = False Then
                        XtraMessageBox.Show("Δεν μπορείτε επισυνάψετε έντυπο ολοκλήρωσης όταν υπάρχει έστω και μια μη ολοκληρωμένη εργασία.", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    Else
                        ProjectJobs.FileSelect()
                    End If
                Case 1 : OpenFile("PROJECT_JOBS", sID)
                Case 2 : ProjectJobs.DeleteFile()
            End Select
        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub
    Private Sub cmdSendApointmentEmail_Click(sender As Object, e As EventArgs) Handles cmdSendApointmentEmail.Click
        ProjectJobs.ValidateEmail(1)
    End Sub

    Private Sub cmdSendEmail_Click(sender As Object, e As EventArgs) Handles cmdSendEmail.Click
        ProjectJobs.ValidateEmail(2)
    End Sub
    Private Sub cmdSendEmailComplete_Click(sender As Object, e As EventArgs) Handles cmdSendEmailComplete.Click
        ProjectJobs.ValidateEmail(3)
    End Sub
    Private Sub DefProj_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles DefProj.ItemClick
        If sComeFrom = 0 Then
            txtBody.EditValue = ProgProps.PJInfBody.Replace("{PJ_VISIT_DATE}", dtVisitDate.Text)
            txtSubject.EditValue = ProgProps.PJInfSubject
        Else
            txtBody.EditValue = ProgProps.PJInfBodySup.Replace("{CUS}", cboCUS.Text)
            txtSubject.EditValue = ProgProps.PJInfSubjectSup
        End If
    End Sub
    Private Sub DefProjComplete_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles DefProjComplete.ItemClick
        If sComeFrom = 0 Then
            If dtVisitDate.EditValue IsNot Nothing Then txtBody.EditValue = ProgProps.PJInfBodyComplete.Replace("{PJ_VISIT_DATE}", dtVisitDate.Text)
            txtSubject.EditValue = ProgProps.PJInfSubjectComplete
        End If

    End Sub
    Private Sub DefProjAppointment_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles DefProjAppointment.ItemClick
        txtBody.EditValue = ProgProps.PJInfAppointmentBody
        txtBody.EditValue = txtBody.EditValue.Replace("{PJ_VISIT_DATE}", dtVisitDate.Text)
        txtBody.EditValue = txtBody.EditValue.Replace("{PJ_TIME_FROM}", txtTmIN.Text)
        txtBody.EditValue = txtBody.EditValue.Replace("{PJ_TIME_TO}", txtTmOUT.Text)
        txtSubject.EditValue = ProgProps.PJInfAppointmentSubject
    End Sub
    Private Sub TabPane1_SelectedPageChanged(sender As Object, e As SelectedPageChangedEventArgs) Handles TabPane1.SelectedPageChanged
        Select Case TabPane1.SelectedPageIndex
            Case 1
                Prog_Prop.GetProgEmailPJ()

                If sComeFrom = 0 Then
                    txtSubject.EditValue = ProgProps.PJInfSubject
                    txtTo.EditValue = cboCUS.GetColumnValue("email")
                    If txtfProjectNameComplete.EditValue IsNot Nothing Then
                        cmdSendEmailComplete.Enabled = True : DefProjComplete.Enabled = True
                    Else
                        cmdSendEmailComplete.Enabled = False : DefProjComplete.Enabled = False
                    End If
                Else
                    txtSubject.EditValue = ProgProps.PJInfSubjectSup
                    txtTo.EditValue = cboSUP.GetColumnValue("email")
                    DefProjAppointment.Enabled = False
                    DefProjComplete.Enabled = False
                    cmdSendEmailComplete.Enabled = False
                    txtBody.EditValue = ProgProps.PJInfBodySup.Replace("{CUS}", cboCUS.Text)
                    txtSubject.EditValue = ProgProps.PJInfSubjectSup
                End If
                If dtVisitDate.EditValue = Nothing Or txtTmIN.EditValue = "00:00" Or txtTmOUT.EditValue = "00:00" Then cmdSendApointmentEmail.Enabled = False Else cmdSendApointmentEmail.Enabled = True
                Me.PROJECT_JOBS_MAILTableAdapter.FillByProjectJobID(Me.DMDataSet.PROJECT_JOBS_MAIL, System.Guid.Parse(sID))
                LoadForms.RestoreLayoutFromXml(GridView3, "PROJECT_JOBS_MAIL.xml")
            Case 2
                LoadForms.RestoreLayoutFromXml(GridView4, "vw_TRANSH_F_PROJECT_JOBS_def.xml")
                TRANSH_FTableAdapter.FillByTranshID(DM_TRANS.TRANSH_F, System.Guid.Parse(cboTRANSH.EditValue.ToString))
        End Select
    End Sub

    Private Sub GridView1_PopupMenuShowing(sender As Object, e As DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs) Handles GridView1.PopupMenuShowing
        If e.MenuType = GridMenuType.Column Then
            If sComeFrom = 1 Then
                LoadForms.PopupMenuShow(e, GridView1, "vw_PROJECT_JOBS_D_SUP.xml", "vw_PROJECT_JOBS_D")
            Else
                LoadForms.PopupMenuShow(e, GridView1, "vw_PROJECT_JOBS_D.xml", "vw_PROJECT_JOBS_D")
            End If
        End If
    End Sub

    Private Sub GridView3_PopupMenuShowing(sender As Object, e As PopupMenuShowingEventArgs) Handles GridView3.PopupMenuShowing
        LoadForms.PopupMenuShow(e, GridView3, "PROJECT_JOBS_MAIL.xml", "vw_PROJECT_JOBS_MAIL")
    End Sub
    Private Sub txtFiles_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles txtFiles.ButtonClick
        Dim sFilename As String
        Select Case e.Button.Index
            Case 0
                Dim result = XtraInputBox.Show("Πληκτρολογήστε το πλήθος σελίδων που θα σκανάρετε", "Όνομα Αρχείου", "1")
                ScanFile = New ScanToPDF
                If ScanFile.Scan(sFilename, Me.VwSCANFILENAMESBindingSource, result) = False Then Exit Sub
                txtFiles.EditValue = sFilename
                If txtFiles.Text <> "" Then ProjectJobs.SaveRecordF(1, sFilename)
                ScanFile = Nothing
            Case 1 : FilesSelection(XtraOpenFileDialog2, txtFiles)

            Case 2 : txtFiles.EditValue = Nothing
        End Select
    End Sub

    Private Sub cmdSaveTransF_Click(sender As Object, e As EventArgs) Handles cmdSaveTransF.Click
        XtraOpenFileDialog2.Tag = cboTanshFCategory.EditValue.ToString
        ProjectJobs.SaveRecordF(0)
    End Sub
    Private Sub GridView4_PopupMenuShowing(sender As Object, e As PopupMenuShowingEventArgs) Handles GridView4.PopupMenuShowing
        If e.MenuType = GridMenuType.Column Then LoadForms.PopupMenuShow(e, GridView4, "vw_TRANSH_F_PROJECT_JOBS_def.xml", "vw_TRANSH_F")
    End Sub
    Private Sub GridView4_ValidateRow(sender As Object, e As ValidateRowEventArgs) Handles GridView4.ValidateRow
        Dim sSQL As New System.Text.StringBuilder
        Try
            sSQL.Clear()
            sSQL.AppendLine("UPDATE TRANSH_F	SET FileCatID= " & toSQLValueS(GridView4.GetRowCellValue(GridView4.FocusedRowHandle, "fileCatID").ToString) & ",")
            sSQL.AppendLine("modifiedBY = " & toSQLValueS(UserProps.ID.ToString) & ",")
            sSQL.AppendLine("modifiedON = getdate() ")
            sSQL.AppendLine("WHERE ID = " & toSQLValueS(GridView4.GetRowCellValue(GridView4.FocusedRowHandle, "ID").ToString))
            'Εκτέλεση QUERY
            Using oCmd As New SqlCommand(sSQL.ToString, CNDB)
                oCmd.ExecuteNonQuery()
            End Using
        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub GridControl2_DoubleClick(sender As Object, e As EventArgs) Handles GridControl2.DoubleClick
        OpenFileFromGrid(GridView4, "TRANSH_F")
    End Sub

    Private Sub frmProjectJobs_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        'If ProjectJobs.ValidationsExit = False Then e.Cancel = True : Exit Sub
    End Sub
    Private Sub cboTanshFCategory_ButtonPressed(sender As Object, e As ButtonPressedEventArgs) Handles cboTanshFCategory.ButtonPressed
        Select Case e.Button.Index
            Case 1 : cboTanshFCategory.EditValue = Nothing : ManageCbo.ManageFCategory(cboTanshFCategory, FormMode.NewRecord)
            Case 2 : If cboTanshFCategory.EditValue IsNot Nothing Then ManageCbo.ManageFCategory(cboTanshFCategory, FormMode.EditRecord)
            Case 3 : cboTanshFCategory.EditValue = Nothing
        End Select
    End Sub
End Class