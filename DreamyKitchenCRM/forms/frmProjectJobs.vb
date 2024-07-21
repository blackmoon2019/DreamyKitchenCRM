Imports System.Data.SqlClient
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports DevExpress.XtraReports.UI

Public Class frmProjectJobs
    Private sID As String
    Public Mode As Byte
    Private FScrollerExist As Boolean = False
    Private sComeFrom As Integer
    Private CalledFromCtrl As Boolean
    Private HasConnectedOrder As Boolean = False
    Private Valid As New ValidateControls
    Private ProjectJobs As New ProjectJobs
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
    Public WriteOnly Property ComeFrom As Integer
        Set(value As Integer)
            sComeFrom = value
        End Set
    End Property

    Private Sub cmdExit_Click(sender As Object, e As EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub

    Private Sub frmProjectJobs_Load(sender As Object, e As EventArgs) Handles Me.Load
        ProjectJobs.Initialize(Me, sID, Mode)
        ProjectJobs.LoadForm()
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
            Case 1 : ManageCbo.ManageTRANSH(cboTRANSH, FormMode.NewRecord)
            Case 2 : ManageCbo.ManageTRANSH(cboTRANSH, FormMode.EditRecord)
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
        If e.KeyCode = Keys.Down And UserProps.AllowInsert Then
            If sender.FocusedRowHandle < 0 Then Exit Sub
            Dim viewInfo As GridViewInfo = TryCast(sender.GetViewInfo(), GridViewInfo)
            If sender.FocusedRowHandle = viewInfo.RowsInfo.Last().RowHandle Then
                GridView1.PostEditor() : GridView1.AddNewRow()
            End If
        End If
    End Sub

    Private Sub GridView1_ValidateRow(sender As Object, e As ValidateRowEventArgs) Handles GridView1.ValidateRow
        If e.RowHandle = GridControl1.NewItemRowHandle Then
            If GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "description").ToString = "" Then
                e.ErrorText = "Παρακαλώ συμπληρώστε την εργασία"
                e.Valid = False
                Exit Sub
            End If
            ProjectJobs.SaveRecordProjectD(True)
        Else
            ProjectJobs.SaveRecordProjectD(False)
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
End Class