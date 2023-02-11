Imports System.IO
Imports System.ComponentModel
Imports System.Data.SqlClient
Imports DevExpress.DataAccess
Imports DevExpress.DataAccess.Native
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraExport.Helpers
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports DevExpress.XtraMap.Drawing.DirectD3D9
Imports DevExpress.DataAccess.UI
Imports DevExpress.DataAccess.UI.Native
Imports DevExpress.XtraSpreadsheet.Layout

Public Class frmInstEllipse

    Private sID As String
    Private sINST_ID As String
    Private Ctrl As DevExpress.XtraGrid.Views.Grid.GridView
    Private Frm As DevExpress.XtraEditors.XtraForm
    Public Mode As Byte
    Private Valid As New ValidateControls
    Private FScrollerExist As Boolean = False
    Private Log As New Transactions
    Private FillCbo As New FillCombos
    Private DBQ As New DBQueries
    Private LoadForms As New FormLoader
    Private Cls As New ClearControls
    Private CtrlCombo As DevExpress.XtraEditors.LookUpEdit
    Private CalledFromCtrl As Boolean

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
    Private Sub cmdExit_Click(sender As Object, e As EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub

    Private Sub frmInstEllipse_Load(sender As Object, e As EventArgs) Handles Me.Load
        'TODO: This line of code loads data into the 'DmDataSet.INST_ELLIPSE_JOBS' table. You can move, or remove it, as needed.
        'Me.INST_ELLIPSE_JOBSTableAdapter.Fill(Me.DmDataSet.INST_ELLIPSE_JOBS)
        Dim sSQL As New System.Text.StringBuilder
        sSQL.AppendLine("Select id,Fullname,salary,tmIN,tmOUT from vw_EMP where active=1 and jobID IN('A7C491B1-965B-4E86-95CF-C7881935C77D','F1A60661-D448-41B7-8CF0-CE6B9FF6E518') order by Fullname")

        FillCbo.INST(cboINST)
        Select Case Mode
            Case FormMode.NewRecord
                txtCode.Text = DBQ.GetNextId("INST_ELLIPSE")
                If sINST_ID IsNot Nothing Then cboINST.EditValue = System.Guid.Parse(sINST_ID)
                FillCbo.FillCheckedListINST_ELLIPSE_SER(chkSER, FormMode.NewRecord)
                GridView1.OptionsBehavior.Editable = False
            Case FormMode.EditRecord
                LoadForms.LoadForm(LayoutControl1, "Select * from vw_INST_ELLIPSE where id =" & toSQLValueS(sID))
                FillCbo.FillCheckedListINST_ELLIPSE_SER(chkSER, FormMode.EditRecord, sID)
                Me.INST_ELLIPSE_JOBSTableAdapter.FillBYinstEllipseID(Me.DmDataSet.INST_ELLIPSE_JOBS, System.Guid.Parse(sID))
                If sINST_ID Is Nothing Then sINST_ID = cboINST.EditValue.ToString
                Dim Cmd As SqlCommand, sdr As SqlDataReader
                sSQL.Clear()
                sSQL.AppendLine("SELECT count (id) as CountEllipse  FROM INST_ELLIPSE WHERE ID= " & toSQLValueS(sID) & " and createdOn<(select max(createdon) from INST_ELLIPSE WHERE instID= " & toSQLValueS(sINST_ID) & ")")
                Cmd = New SqlCommand(sSQL.ToString, CNDB)
                sdr = Cmd.ExecuteReader()
                Dim CountEllipse As Integer
                If (sdr.Read() = True) Then
                    If sdr.IsDBNull(sdr.GetOrdinal("CountEllipse")) = False Then CountEllipse = sdr.GetInt32(sdr.GetOrdinal("CountEllipse")) Else CountEllipse = 0
                    If CountEllipse > 0 Then LayoutControl1.Enabled = False
                End If
                sdr.Close()
                txtInstellipseFilename.Enabled = True
        End Select
        Me.CenterToScreen()
        cmdSave.Enabled = IIf(Mode = FormMode.NewRecord, UserProps.AllowInsert, UserProps.AllowEdit)

    End Sub

    Private Sub frmInstEllipse_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        If Me.WindowState = FormWindowState.Maximized Then frmMain.XtraTabbedMdiManager1.Dock(Me, frmMain.XtraTabbedMdiManager1)
    End Sub
    Private Sub ManageINST()
        Dim form1 As frmInstallations = New frmInstallations()
        form1.Text = "Μισθοδοσία Τοποθετών"
        form1.CallerControl = cboINST
        form1.CalledFromControl = True
        form1.MdiParent = frmMain
        If cboINST.EditValue <> Nothing Then
            form1.ID = cboINST.EditValue.ToString
            form1.Mode = FormMode.EditRecord
        Else
            form1.Mode = FormMode.NewRecord
        End If
        frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(form1), New Point(CInt(form1.Parent.ClientRectangle.Width / 2 - form1.Width / 2), CInt(form1.Parent.ClientRectangle.Height / 2 - form1.Height / 2)))
        form1.Show()

    End Sub

    Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click
        Dim sResult As Boolean
        Dim sSQL As String
        Dim LastEllipseID As String
        Try
            If Valid.ValidateForm(LayoutControl1) Then
                Select Case Mode
                    Case FormMode.NewRecord
                        sID = System.Guid.NewGuid.ToString
                        Dim Cmd As SqlCommand, sdr As SqlDataReader
                        Cmd = New SqlCommand("SELECT TOP 1 IE.id,MAX(ie.createdOn) as createdOn  FROM INST_ELLIPSE IE WHERE IE.instID= " & toSQLValueS(sINST_ID) & " group by IE.ID ORDER BY createdOn DESC ", CNDB)
                        sdr = Cmd.ExecuteReader()
                        If (sdr.Read() = True) Then LastEllipseID = sdr.GetGuid(sdr.GetOrdinal("ID")).ToString.ToUpper
                        sdr.Close()
                        sResult = DBQ.InsertNewData(DBQueries.InsertMode.OneLayoutControl, "INST_ELLIPSE", LayoutControl1,,, sID, True)
                    Case FormMode.EditRecord
                        sResult = DBQ.UpdateNewData(DBQueries.InsertMode.OneLayoutControl, "INST_ELLIPSE", LayoutControl1,,, sID, True)
                End Select

                If FScrollerExist = True Then
                    Dim form As frmScroller = Frm
                    form.LoadRecords("vw_INST_ELLIPSE")
                End If

                If sResult = True Then
                    If Mode = FormMode.EditRecord Then
                        ' Διαγραφή όλων των συνεργείων πάντα στην επεξεργασία εγγραφής
                        sSQL = "DELETE FROM INST_ELLIPSE_SER where instEllipseID = '" & sID & "'"
                        Using oCmd As New SqlCommand(sSQL, CNDB)
                            oCmd.ExecuteNonQuery()
                        End Using
                    End If

                    Dim sSQL2 As String

                    If Mode = FormMode.NewRecord Then

                        ' Κάνει ολοκληρωμένες όλες τις άλλες ελλέιψεις τις συγκεκριμένης τοποθέτησης
                        sSQL2 = "UPDATE INST_ELLIPSE SET COMPLETED =1 WHERE instID = " & toSQLValueS(sINST_ID) & " and ID <> " & toSQLValueS(sID)
                        Using oCmd As New SqlCommand(sSQL2, CNDB)
                            oCmd.ExecuteNonQuery()
                        End Using

                        ' Μεταφέρει στην καινούρια έλλειψη ότι ανολοκλήρωτη εκκρεμότητα υπάρχει
                        sSQL2 = "INSERT INTO INST_ELLIPSE_JOBS ([ID],[instEllipseID],[instID], [name], [cmt], [completed], [dtCompleted],  [createdOn], [createdBy]) " &
                                "SELECT NEWID()," & toSQLValueS(sID) & " ,  " & toSQLValueS(sINST_ID) & ", [name], IEJ.[cmt], IEJ.[completed], [dtCompleted],  IEJ.[createdOn], IEJ.[createdBy] " &
                                "from INST I " &
                                "inner join INST_ELLIPSE IE on IE.id= " & toSQLValueS(LastEllipseID) &
                                " INNER  join INST_ELLIPSE_JOBS  IEJ ON IEJ.instEllipseID =IE.ID " &
                                "WHERE IEJ.completed=0 And I.[ID]= " & toSQLValueS(sINST_ID)
                        Using oCmd As New SqlCommand(sSQL2, CNDB)
                            oCmd.ExecuteNonQuery()
                        End Using
                        Me.INST_ELLIPSE_JOBSTableAdapter.FillBYinstEllipseID(Me.DmDataSet.INST_ELLIPSE_JOBS, System.Guid.Parse(sID))


                        'Cls.ClearCtrls(LayoutControl1)
                        'txtCode.Text = DBQ.GetNextId("INST_ELLIPSE")
                        txtInstellipseFilename.Enabled = True
                        GridView1.OptionsBehavior.Editable = True
                        Mode = FormMode.EditRecord
                    End If
                    sSQL2 = ""
                    ' Καταχώρηση Συνεργείων 
                    For Each item As DevExpress.XtraEditors.Controls.CheckedListBoxItem In chkSER.CheckedItems
                        sSQL2 = "INSERT INTO INST_ELLIPSE_SER (instEllipseID,empID,[createdBy],[createdOn])  
                                        values (" & toSQLValueS(sID) & "," & toSQLValueS(item.Tag.ToString()) & "," &
                                                            toSQLValueS(UserProps.ID.ToString) & ", getdate() )"
                        Using oCmd As New SqlCommand(sSQL2, CNDB)
                            oCmd.ExecuteNonQuery()
                        End Using
                    Next
                    FillCbo.FillCheckedListINST_ELLIPSE_SER(chkSER, FormMode.EditRecord, sID)
                    XtraMessageBox.Show("Η εγγραφή αποθηκέυτηκε με επιτυχία", "Dreamy Kitchen CRM", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), "Dreamy Kitchen CRM", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cboINST_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboINST.ButtonClick
        Select Case e.Button.Index
            Case 1 : cboINST.EditValue = Nothing : ManageINST()
            Case 2 : If cboINST.EditValue <> Nothing Then ManageINST()
            Case 3 : cboINST.EditValue = Nothing
        End Select

    End Sub
    Private Sub GridView1_InvalidRowException(sender As Object, e As InvalidRowExceptionEventArgs) Handles GridView1.InvalidRowException
        e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction
    End Sub
    Private Sub Grid_EmbeddedNavigator_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.NavigatorButtonClickEventArgs)
        Select Case e.Button.ButtonType
            Case e.Button.ButtonType.Remove : DeleteRecord() : e.Handled = True
        End Select
    End Sub
    Private Sub GridView1_KeyDown(sender As Object, e As KeyEventArgs) Handles GridView1.KeyDown
        If e.KeyCode = Keys.Delete And UserProps.AllowDelete = True Then DeleteRecord()
        If e.KeyCode = Keys.Down And UserProps.AllowInsert Then
            If sender.FocusedRowHandle < 0 Then Exit Sub
            Dim viewInfo As GridViewInfo = TryCast(sender.GetViewInfo(), GridViewInfo)
            If sender.FocusedRowHandle = viewInfo.RowsInfo.Last().RowHandle Then
                GridView1.PostEditor()
                GridView1.AddNewRow()
            End If
        End If
    End Sub
    Private Sub DeleteRecord()
        If GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "ID") = Nothing Then Exit Sub
        If XtraMessageBox.Show("Θέλετε να διαγραφεί η τρέχουσα εγγραφή?", "Dreamy Kitchen CRM", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            Dim sSQL As String = "DELETE FROM INST_ELLIPSE_JOBS WHERE ID = '" & GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "ID").ToString & "'"
            Using oCmd As New SqlCommand(sSQL, CNDB)
                oCmd.ExecuteNonQuery()
            End Using
            Me.INST_ELLIPSE_JOBSTableAdapter.FillBYinstEllipseID(Me.DmDataSet.INST_ELLIPSE_JOBS, System.Guid.Parse(sID))
        End If
    End Sub
    Private Sub GridView1_ValidateRow(sender As Object, e As ValidateRowEventArgs) Handles GridView1.ValidateRow
        Dim sSQL As New System.Text.StringBuilder
        Dim CompletedCell As String = "", sDate As String
        Try
            sSQL.Clear()
            If e.RowHandle = GridControl1.NewItemRowHandle Then
                If GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "name").ToString = "" Then
                    e.ErrorText = "Παρακαλώ συμπληρώστε την έλλειψη"
                    e.Valid = False
                    Exit Sub
                End If
                sSQL.AppendLine("INSERT INTO INST_ELLIPSE_JOBS (instEllipseID,instID,name,cmt,completed,dtCompleted,[modifiedBy],[createdby],[createdOn])")
                sSQL.AppendLine("Select " & toSQLValueS(sID) & ",")
                sSQL.AppendLine(toSQLValueS(sINST_ID) & ",")
                sSQL.AppendLine(toSQLValueS(GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "name").ToString) & ",")
                sSQL.AppendLine(toSQLValueS(GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "cmt").ToString) & ",")
                CompletedCell = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "completed").ToString : If CompletedCell = "" Then CompletedCell = "0"
                sSQL.AppendLine("completed = " & toSQLValueS(CompletedCell) & ",")
                sDate = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "dtCompleted").ToString
                If sDate <> "" Then sDate = toSQLValueS(CDate(sDate).ToString("yyyyMMdd")) Else sDate = "NULL"
                sSQL.AppendLine(sDate & ",")
                sSQL.Append(toSQLValueS(UserProps.ID.ToString) & "," & toSQLValueS(UserProps.ID.ToString) & ", getdate()")
                'Εκτέλεση QUERY
                Using oCmd As New SqlCommand(sSQL.ToString, CNDB)
                    oCmd.ExecuteNonQuery()
                End Using
                Me.INST_ELLIPSE_JOBSTableAdapter.FillBYinstEllipseID(Me.DmDataSet.INST_ELLIPSE_JOBS, System.Guid.Parse(sID))
            Else
                sSQL.AppendLine("UPDATE INST_ELLIPSE_JOBS	SET name= " & toSQLValueS(GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "name").ToString) & ",")
                sSQL.AppendLine("instID = " & toSQLValueS(sINST_ID) & ",")
                sSQL.AppendLine("modifiedBY = " & toSQLValueS(UserProps.ID.ToString) & ",")
                sSQL.AppendLine("cmt = " & toSQLValueS(GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "cmt").ToString) & ",")
                CompletedCell = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "completed").ToString : If CompletedCell = "" Then CompletedCell = "0"
                sSQL.AppendLine("completed = " & toSQLValueS(CompletedCell) & ",")
                sDate = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "dtCompleted").ToString
                If sDate <> "" Then sDate = toSQLValueS(CDate(sDate).ToString("yyyyMMdd")) Else sDate = "NULL"
                sSQL.AppendLine("dtcompleted = " & sDate & ",")
                sSQL.AppendLine("modifiedON = getdate() ")
                sSQL.AppendLine("WHERE ID = " & toSQLValueS(GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "ID").ToString))
                'Εκτέλεση QUERY
                Using oCmd As New SqlCommand(sSQL.ToString, CNDB)
                    oCmd.ExecuteNonQuery()
                End Using
                Me.INST_ELLIPSE_JOBSTableAdapter.FillBYinstEllipseID(Me.DmDataSet.INST_ELLIPSE_JOBS, System.Guid.Parse(sID))
            End If
        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), "Dreamy Kitchen CRM", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub GridView1_CellValueChanged(sender As Object, e As CellValueChangedEventArgs) Handles GridView1.CellValueChanged

    End Sub

    Private Sub GridView1_CellValueChanging(sender As Object, e As CellValueChangedEventArgs) Handles GridView1.CellValueChanging
        If e.Column.FieldName = "completed" Then
            If e.Value = True Then GridView1.SetRowCellValue(GridView1.FocusedRowHandle, "dtCompleted", Date.Now) Else GridView1.SetRowCellValue(GridView1.FocusedRowHandle, "dtCompleted", Nothing)
        End If
    End Sub

    Private Sub cmdUploadInstEllipseF_Click(sender As Object, e As EventArgs)


    End Sub
    Private Sub FileSelect()
        'XtraOpenFileDialog1.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*"
        XtraOpenFileDialog1.FilterIndex = 1
        XtraOpenFileDialog1.InitialDirectory = "C:\"
        XtraOpenFileDialog1.Title = "Open File"
        XtraOpenFileDialog1.CheckFileExists = False
        XtraOpenFileDialog1.Multiselect = False
        Dim result As DialogResult = XtraOpenFileDialog1.ShowDialog()
        If result = DialogResult.OK Then
            txtInstellipseFilename.EditValue = XtraOpenFileDialog1.FileName
            Dim sSQL As String
            Try
                My.Computer.FileSystem.CopyFile(XtraOpenFileDialog1.FileName, ProgProps.ServerPath & Path.GetFileName(XtraOpenFileDialog1.FileName), True)

                sSQL = "UPDATE INST_ELLIPSE SET fInstEllipseName =  " & toSQLValueS(Path.GetFileName(XtraOpenFileDialog1.FileName).ToString) & ", fInstEllipse =  BulkColumn from Openrowset( Bulk " & toSQLValueS(ProgProps.ServerPath & Path.GetFileName(XtraOpenFileDialog1.FileName)) & ", Single_Blob) as InstEllipseF where ID = " & toSQLValueS(sID)
                'Εκτέλεση QUERY
                Using oCmd As New SqlCommand(sSQL, CNDB)
                    oCmd.ExecuteNonQuery()
                End Using
                XtraMessageBox.Show("Το αρχείο αποθηκεύτηκε με επιτυχία", "Dreamy Kitchen CRM", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), "Dreamy Kitchen CRM", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub txtInstellipseFilename_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles txtInstellipseFilename.ButtonClick
        Try
            Select Case e.Button.Index
                Case 0
                    'Dim result = XtraInputBox.Show("Πληκτρολογήστε το πλήθος σελίδων που θα σκανάρετε", "Όνομα Αρχείου", "1")
                    'ScanFile = New ScanToPDF
                    'If ScanFile.Scan(sFilename, Me.VwSCANFILENAMESBindingSource, result) = False Then Exit Sub
                    'txtInvoiceFilename.EditValue = sFilename
                    'If txtInvoiceFilename.Text <> "" Then
                    '    DBQ.InsertDataFilesFromScanner(sFilename, cboCUS.EditValue.ToString, "TRANSH")
                    '    Me.Vw_CCT_FTableAdapter.Fill(Me.DreamyKitchenDataSet.vw_CCT_F, System.Guid.Parse(cboCUS.EditValue.ToString))
                    'End If
                    'ScanFile = Nothing
                    FileSelect()
                Case 1
                    Try
                        Dim Cmd As SqlCommand, sdr As SqlDataReader
                        Dim sSQL As String = "SELECT fInstEllipse,fInstEllipseName  FROM INST_ELLIPSE WHERE ID= " & toSQLValueS(sID)
                        Cmd = New SqlCommand(sSQL.ToString, CNDB)
                        sdr = Cmd.ExecuteReader()
                        If (sdr.Read() = True) Then
                            Dim sFilename = sdr.GetString(sdr.GetOrdinal("fInstEllipseName"))
                            Dim fs As IO.FileStream = New IO.FileStream(ProgProps.TempFolderPath & sFilename, IO.FileMode.Create)
                            Dim b As Byte()
                            b = DirectCast(sdr("fInstEllipse"), Byte())
                            fs.Write(b, 0, b.Length)
                            fs.Close()
                            ShellExecute(ProgProps.TempFolderPath & sFilename)
                        End If
                        sdr.Close()
                    Catch exfs As Exception
                        XtraMessageBox.Show(String.Format("Error: {0}", exfs.Message), "Dreamy Kitchen CRM", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Finally

                    End Try
                Case 2
                        If XtraMessageBox.Show("Θέλετε να διαγραφεί το αρχείο?", "Dreamy Kitchen CRM", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                        Dim sSQL As String
                        sSQL = "UPDATE INST_ELLIPSE SET fInstEllipseName =  NULL ,fInstEllipse =  NULL where ID = " & toSQLValueS(sID)
                        'Εκτέλεση QUERY
                        Using oCmd As New SqlCommand(sSQL, CNDB)
                            oCmd.ExecuteNonQuery()
                        End Using
                        txtInstellipseFilename.EditValue = Nothing
                    End If
            End Select
        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), "Dreamy Kitchen CRM", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try

    End Sub
    Private Sub ShellExecute(ByVal File As String)
        Dim myProcess As New Process
        myProcess.StartInfo.FileName = File
        myProcess.StartInfo.UseShellExecute = True
        myProcess.StartInfo.RedirectStandardOutput = False
        myProcess.Start()
        myProcess.Dispose()
    End Sub
    Private Sub txtInstellipseFilename_EditValueChanged(sender As Object, e As EventArgs) Handles txtInstellipseFilename.EditValueChanged

    End Sub
End Class