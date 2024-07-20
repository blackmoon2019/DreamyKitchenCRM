Imports DevExpress.XtraEditors
Imports System.Data.SqlClient
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo

Public Class frmProjectJobs
    Private sID As String
    Public Mode As Byte
    Private FScrollerExist As Boolean = False
    Private sComeFrom As Integer
    Private CalledFromCtrl As Boolean
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
    Private Sub cboSaler_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboSaler.ButtonClick
        Select Case e.Button.Index
            Case 1 : ManageCbo.ManageSaler(cboSaler, FormMode.NewRecord)
            Case 2 : ManageCbo.ManageSaler(cboSaler, FormMode.EditRecord)
            Case 3 : cboSaler.EditValue = Nothing
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
    End Sub

    Private Sub GridView1_ValidateRow(sender As Object, e As ValidateRowEventArgs) Handles GridView1.ValidateRow
        Dim sSQL As New System.Text.StringBuilder
        Dim CompletedCell As String = "", sDate As String
        Dim toOrder As String
        Try
            sSQL.Clear()
            If e.RowHandle = GridControl1.NewItemRowHandle Then
                If GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "description").ToString = "" Then
                    e.ErrorText = "Παρακαλώ συμπληρώστε την εργασία"
                    e.Valid = False
                    Exit Sub
                End If
                sSQL.AppendLine("INSERT INTO PROJECT_JOBS_D (projectJobID,description,descriptionSup,cmt,completed,toOrder,cost,dtCompleted,[modifiedBy],[createdby],[createdOn])")
                sSQL.AppendLine("Select " & toSQLValueS(sID) & ",")
                sSQL.AppendLine(toSQLValueS(GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "description").ToString) & ",")
                sSQL.AppendLine(toSQLValueS(GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "descriptionSup").ToString) & ",")
                sSQL.AppendLine(toSQLValueS(GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "cmt").ToString) & ",")
                CompletedCell = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "completed").ToString : If CompletedCell = "" Then CompletedCell = "0"
                sSQL.AppendLine(toSQLValueS(CompletedCell) & ",")
                toOrder = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "toOrder").ToString : If toOrder = "" Then toOrder = "0"
                sSQL.AppendLine(toSQLValueS(toOrder) & ",")
                sSQL.AppendLine(toSQLValueS(GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "cost").ToString, True) & ",")
                sDate = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "dtCompleted").ToString
                If sDate <> "" Then sDate = toSQLValueS(CDate(sDate).ToString("yyyyMMdd")) Else sDate = "NULL"
                sSQL.AppendLine(sDate & ",")
                sSQL.Append(toSQLValueS(UserProps.ID.ToString) & "," & toSQLValueS(UserProps.ID.ToString) & ", getdate()")
                'Εκτέλεση QUERY
                Using oCmd As New SqlCommand(sSQL.ToString, CNDB)
                    oCmd.ExecuteNonQuery()
                End Using
                Me.Vw_PROJECT_JOBS_DTableAdapter.FillByProjectJobID(Me.DMDataSet.vw_PROJECT_JOBS_D, System.Guid.Parse(sID))
            Else
                sSQL.AppendLine("UPDATE PROJECT_JOBS_D	SET ")
                sSQL.AppendLine("modifiedBY = " & toSQLValueS(UserProps.ID.ToString) & ",")
                sSQL.AppendLine("cmt = " & toSQLValueS(GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "cmt").ToString) & ",")
                CompletedCell = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "completed").ToString : If CompletedCell = "" Then CompletedCell = "0"
                sSQL.AppendLine("completed = " & toSQLValueS(CompletedCell) & ",")
                toOrder = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "toOrder").ToString : If toOrder = "" Then toOrder = "0"
                sSQL.AppendLine("toOrder= " & toSQLValueS(toOrder) & ",")


                sDate = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "dtCompleted").ToString
                If sDate <> "" Then sDate = toSQLValueS(CDate(sDate).ToString("yyyyMMdd")) Else sDate = "NULL"
                sSQL.AppendLine("dtcompleted = " & sDate & ",")
                sSQL.AppendLine("description = " & toSQLValueS(GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "description").ToString) & ",")
                sSQL.AppendLine("descriptionSup= " & toSQLValueS(GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "descriptionSup").ToString) & ",")
                sSQL.AppendLine("cost= " & toSQLValueS(GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "cost").ToString, True) & ",")
                sSQL.AppendLine("modifiedON = getdate() ")
                sSQL.AppendLine("WHERE ID = " & toSQLValueS(GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "ID").ToString))
                'Εκτέλεση QUERY
                Using oCmd As New SqlCommand(sSQL.ToString, CNDB)
                    oCmd.ExecuteNonQuery()
                End Using
                Me.Vw_PROJECT_JOBS_DTableAdapter.FillByProjectJobID(Me.DMDataSet.vw_PROJECT_JOBS_D, System.Guid.Parse(sID))
            End If
            If GridView1.RowCount = 0 Then
                cmdSendEmail.Enabled = False : cmdPrintAll.Enabled = False : cmdSendApointmentEmail.Enabled = False : cmdDefEmail.Enabled = False
                If sComeFrom = 0 Then cmdConvertToOrder.Enabled = False
            Else
                cmdSendEmail.Enabled = True : cmdPrintAll.Enabled = True : cmdSendApointmentEmail.Enabled = True : cmdDefEmail.Enabled = True
                If sComeFrom = 0 Then cmdConvertToOrder.Enabled = True
            End If
        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub GridView1_CellValueChanging(sender As Object, e As CellValueChangedEventArgs) Handles GridView1.CellValueChanging

        If e.Column.FieldName = "completed" Then
            If e.Value = True Then GridView1.SetRowCellValue(GridView1.FocusedRowHandle, "dtCompleted", Date.Now) Else GridView1.SetRowCellValue(GridView1.FocusedRowHandle, "dtCompleted", Nothing)
        End If
    End Sub

End Class