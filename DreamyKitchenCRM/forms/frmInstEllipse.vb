
Imports System.IO
Imports System.Data.SqlClient
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports DevExpress.XtraReports.UI
Imports DevExpress.DataAccess
Imports DevExpress.DataAccess.Native
Imports DevExpress.DataAccess.UI
Imports System.ComponentModel
Imports DevExpress.XtraBars.Navigation
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Tab
Imports DevExpress.DataAccess.UI.Native
Imports DevExpress.Office.PInvoke.Win32
Imports DevExpress.XtraExport.Helpers

Public Class frmInstEllipse

    Private sID As String
    Private sINST_ID As String
    Private Ctrl As DevExpress.XtraGrid.Views.Grid.GridView
    Private Frm As DevExpress.XtraEditors.XtraForm
    Public Mode As Byte
    Private Prog_Prop As New ProgProp
    Private Valid As New ValidateControls
    Private FScrollerExist As Boolean = False
    Private Log As New Transactions
    Private FillCbo As New FillCombos
    Private DBQ As New DBQueries
    Private LoadForms As New FormLoader
    Private Cls As New ClearControls
    Private CtrlCombo As DevExpress.XtraEditors.LookUpEdit
    Private CalledFromCtrl As Boolean
    Private sComeFrom As Integer
    Private SaveButtonPressed As Boolean = False
    Private emailMode As Int16 = 0


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
    Private Sub cmdExit_Click(sender As Object, e As EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub

    Private Sub frmInstEllipse_Load(sender As Object, e As EventArgs) Handles Me.Load
        'TODO: This line of code loads data into the 'DmDataSet.CCT_TRANSH' table. You can move, or remove it, as needed.
        Me.CCT_TRANSHTableAdapter.Fill(Me.DmDataSet.CCT_TRANSH)
        'TODO: This line of code loads data into the 'DmDataSet.INST_ELLIPSE_JOBS' table. You can move, or remove it, as needed.
        'Me.INST_ELLIPSE_JOBSTableAdapter.Fill(Me.DmDataSet.INST_ELLIPSE_JOBS)
        AddHandler GridControl1.EmbeddedNavigator.ButtonClick, AddressOf Grid_EmbeddedNavigator_ButtonClick
        Dim sSQL As New System.Text.StringBuilder
        sSQL.AppendLine("Select id,Fullname,salary,tmIN,tmOUT from vw_EMP where active=1 and jobID IN('A7C491B1-965B-4E86-95CF-C7881935C77D','F1A60661-D448-41B7-8CF0-CE6B9FF6E518') order by Fullname")

        FillCbo.INST(cboINST)
        Select Case Mode
            Case FormMode.NewRecord : NewRecord()
            Case FormMode.EditRecord
                SaveButtonPressed = True
                Dim sFields As New Dictionary(Of String, String)
                LoadForms.LoadForm(LayoutControl1, "Select * from vw_INST_ELLIPSE where id =" & toSQLValueS(sID), sFields)
                If sFields("comeFrom") = "False" Then sComeFrom = 0 Else sComeFrom = 1
                FillCbo.FillCheckedListINST_ELLIPSE_SER(chkSER, FormMode.EditRecord, sID)
                Me.INST_ELLIPSE_JOBSTableAdapter.FillBYinstEllipseID(Me.DmDataSet.INST_ELLIPSE_JOBS, System.Guid.Parse(sID))
                If sINST_ID Is Nothing Then sINST_ID = cboINST.EditValue.ToString
                'Αφορά μόνο τον πελάτη και ελέγχει αν υπάρχει έλλειψη πριν την τελευταία . Αν υπάρχει δεν μπορεί να την επεξεργαστεί αυτήν
                If sComeFrom = 0 Then
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
                End If
                txtInstellipseFilename.Enabled = True
                GridControl1.ForceInitialize()
                If GridView1.DataRowCount = 0 Then cmdSendEmail.Enabled = False : cmdPrintAll.Enabled = False : cmdSendApointmentEmail.Enabled = False : cmdDefEmail.Enabled = False
        End Select
        LoadForms.RestoreLayoutFromXml(GridView1, "INST_ELLIPSE_JOBS_def.xml")
        LInst.Enabled = False
        If sComeFrom = 1 Then
            LayoutControlGroup1.Text = "Αφορά Προμηθευτή"
            chkSER.Enabled = False
            LdtDateDelivered.Enabled = False
            LTmINFrom.Enabled = False : LTmINTo.Enabled = False
            cboINST.EditValue = System.Guid.Parse("00000001-0001-0001-0001-000000000001")
            cmdConvertToOrder.Enabled = False
        Else
            LayoutControlGroup1.Text = "Αφορά Πελάτη"
            LCus.Enabled = False
            LTransh.Enabled = False
        End If

        Me.CenterToScreen()
        cmdSave.Enabled = IIf(Mode = FormMode.NewRecord, UserProps.AllowInsert, UserProps.AllowEdit)

    End Sub
    Private Sub AddRecord()
        cmdNewInstEllipse.Enabled = False
        txtCode.Text = DBQ.GetNextId("INST_ELLIPSE")
        If sINST_ID IsNot Nothing Then cboINST.EditValue = System.Guid.Parse(sINST_ID)
        FillCbo.FillCheckedListINST_ELLIPSE_SER(chkSER, FormMode.NewRecord)
        GridView1.OptionsBehavior.Editable = False : cmdSendEmail.Enabled = False : cmdPrintAll.Enabled = False : cmdSendApointmentEmail.Enabled = False : cmdDefEmail.Enabled = False : txtInstellipseFilename.Enabled = True

        '΅Εισαγωγή εγγραφής απευθείας στην βάση
        Dim sResult As Boolean = DBQ.InsertNewData(DBQueries.InsertMode.OneLayoutControl, "INST_ELLIPSE", LayoutControl1,,, sID, True, "comefrom", sComeFrom)
        If sResult = False Then
            XtraMessageBox.Show("Υπήρξε πρόβλημα κατά την διαδικασία ανοίγματος εκκρεμότητας.", "Dreamy Kitchen CRM", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Close()
        End If
        Mode = FormMode.EditRecord
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
        frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(form1), New POINT(CInt(form1.Parent.ClientRectangle.Width / 2 - form1.Width / 2), CInt(form1.Parent.ClientRectangle.Height / 2 - form1.Height / 2)))
        form1.Show()

    End Sub

    Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click
        Dim sResult As Boolean
        Dim sSQL As String
        Try
            If Valid.ValidateForm(LayoutControl1) Then
                ' Έλεγχος επισύναψης εντύπου
                'If CheckIfInstEllipseFExist() = False Then Exit Sub
                Select Case Mode
                    Case FormMode.NewRecord
                        sID = System.Guid.NewGuid.ToString
                        ' Έλεγχος επισύναψης εντύπου και καταχώρησης εκκρεμοτήτων
                        If ValidateRecord() Then sResult = DBQ.InsertNewData(DBQueries.InsertMode.OneLayoutControl, "INST_ELLIPSE", LayoutControl1,,, sID, True, "comefrom", sComeFrom)
                    Case FormMode.EditRecord
                        If ValidateRecord() Then sResult = DBQ.UpdateNewData(DBQueries.InsertMode.OneLayoutControl, "INST_ELLIPSE", LayoutControl1,,, sID, True)
                        If sResult = True Then
                            ' Διαγραφή όλων των συνεργείων πάντα στην επεξεργασία εγγραφής
                            sSQL = "DELETE FROM INST_ELLIPSE_SER where instEllipseID = '" & sID & "'"
                            Using oCmd As New SqlCommand(sSQL, CNDB)
                                oCmd.ExecuteNonQuery()
                            End Using
                        End If
                End Select

                If sResult = True Then
                    sSQL = ""
                    ' Καταχώρηση Συνεργείων 
                    For Each item As DevExpress.XtraEditors.Controls.CheckedListBoxItem In chkSER.CheckedItems
                        sSQL = "INSERT INTO INST_ELLIPSE_SER (instEllipseID,empID,[createdBy],[createdOn]) values (" & toSQLValueS(sID) & "," & toSQLValueS(item.Tag.ToString()) & "," & toSQLValueS(UserProps.ID.ToString) & ", getdate() )"
                        Using oCmd As New SqlCommand(sSQL, CNDB)
                            oCmd.ExecuteNonQuery()
                        End Using
                    Next
                    FillCbo.FillCheckedListINST_ELLIPSE_SER(chkSER, FormMode.EditRecord, sID)
                    SaveButtonPressed = True : cmdNewInstEllipse.Enabled = True
                    XtraMessageBox.Show("Η εγγραφή αποθηκέυτηκε με επιτυχία", "Dreamy Kitchen CRM", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), "Dreamy Kitchen CRM", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Function ValidateRecord() As Boolean
        GridControl1.ForceInitialize()
        If GridView1.DataRowCount = 0 Then
            XtraMessageBox.Show("Δεν έχετε καταχωρήσει εκκρεμότητες. Δεν μπορεί να αποθηκευθεί η εγγραφή.", "Dreamy Kitchen CRM", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If
        If txtInstellipseFilename.EditValue = Nothing Then
            XtraMessageBox.Show("Δεν έχετε επισυνάψει έντυπο εκκρεμοτήτων. Δεν μπορεί να αποθηκευθεί η εγγραφή.", "Dreamy Kitchen CRM", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If
        If dtDateDelivered.EditValue IsNot Nothing And chkSER.CheckedItemsCount = 0 Then
            XtraMessageBox.Show("Έχετε επιλέξει ημερομηνία τοποθέτησης χωρίς να επιλέξετε συνεργείο. Δεν μπορεί να αποθηκευθεί η εγγραφή.", "Dreamy Kitchen CRM", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If
        If chkCompleted.CheckState = CheckState.Checked And dtDateDelivered.EditValue = Nothing Then
            XtraMessageBox.Show("Δεν μπορείτε να ολοκληρώσετε την εκκρεμότητα χωρίς ημερομηνία τοποθέτησης. Δεν μπορεί να αποθηκευθεί η εγγραφή.", "Dreamy Kitchen CRM", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If
        Return True
    End Function
    Private Function GetLastEllipseID() As String
        Dim Cmd As SqlCommand, sdr As SqlDataReader
        Cmd = New SqlCommand("Select TOP 1 IE.id, MAX(ie.createdOn) as createdOn  FROM INST_ELLIPSE IE WHERE IE.instID= " & toSQLValueS(sINST_ID) & " group by IE.ID ORDER BY createdOn DESC ", CNDB)
        sdr = Cmd.ExecuteReader()
        If (sdr.Read() = True) Then GetLastEllipseID = sdr.GetGuid(sdr.GetOrdinal("ID")).ToString.ToUpper
        sdr.Close()
        Return GetLastEllipseID
    End Function
    Private Function CheckIfInstEllipseFExist() As Boolean
        Dim sFilename As String = ""
        If chkCompleted.Checked = True Then
            Dim Cmd As SqlCommand, sdr As SqlDataReader
            Dim sSQL As String = "SELECT fInstEllipseName  FROM INST_ELLIPSE WHERE ID= " & toSQLValueS(sID)
            Cmd = New SqlCommand(sSQL.ToString, CNDB)
            sdr = Cmd.ExecuteReader()
            If (sdr.Read() = True) Then
                If sdr.IsDBNull(sdr.GetOrdinal("fInstEllipseName")) = False Then sFilename = sdr.GetString(sdr.GetOrdinal("fInstEllipseName"))
                If sFilename = "" Then
                    XtraMessageBox.Show("Δεν μπορείτε να ολοκληρώσετε την Εκκρεμότητα χωρίς να επισυνάψετε έντυπο", "Dreamy Kitchen CRM", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    sdr.Close()
                    Return False
                Else
                    sdr.Close()
                    Return True
                End If
            Else
                XtraMessageBox.Show("Δεν μπορείτε να ολοκληρώσετε την Εκκρεμότητα χωρίς να επισυνάψετε έντυπο", "Dreamy Kitchen CRM", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            End If
        Else
            Return True
        End If
    End Function
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
            Case e.Button.ButtonType.Append
                If txtInstellipseFilename.EditValue = Nothing Then
                    XtraMessageBox.Show("Δεν έχετε επισυνάψει έντυπο εκκρεμοτήτων.", "Dreamy Kitchen CRM", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    e.Handled = True
                End If
        End Select
    End Sub
    Private Sub GridView1_KeyDown(sender As Object, e As KeyEventArgs) Handles GridView1.KeyDown
        If e.KeyCode = Keys.Delete And UserProps.AllowDelete = True Then DeleteRecord()
        If e.KeyCode = Keys.Down And UserProps.AllowInsert Then
            If sender.FocusedRowHandle < 0 Then Exit Sub
            Dim viewInfo As GridViewInfo = TryCast(sender.GetViewInfo(), GridViewInfo)
            If sender.FocusedRowHandle = viewInfo.RowsInfo.Last().RowHandle Then
                If txtInstellipseFilename.EditValue = Nothing Then
                    XtraMessageBox.Show("Δεν έχετε επισυνάψει έντυπο εκκρεμοτήτων. Δεν μπορεί να αποθηκευθεί η εγγραφή.", "Dreamy Kitchen CRM", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
                GridView1.PostEditor() : GridView1.AddNewRow()
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
        Dim missing As String, replacement As String, orderError As String
        Try
            sSQL.Clear()
            If e.RowHandle = GridControl1.NewItemRowHandle Then
                If GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "name").ToString = "" Then
                    e.ErrorText = "Παρακαλώ συμπληρώστε την έλλειψη"
                    e.Valid = False
                    Exit Sub
                End If
                sSQL.AppendLine("INSERT INTO INST_ELLIPSE_JOBS (instEllipseID,instID,name,cmt,completed,missing,replacement,orderError,dtCompleted,[modifiedBy],[createdby],[createdOn])")
                sSQL.AppendLine("Select " & toSQLValueS(sID) & ",")
                sSQL.AppendLine(toSQLValueS(sINST_ID) & ",")
                sSQL.AppendLine(toSQLValueS(GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "name").ToString) & ",")
                sSQL.AppendLine(toSQLValueS(GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "cmt").ToString) & ",")
                CompletedCell = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "completed").ToString : If CompletedCell = "" Then CompletedCell = "0"
                sSQL.AppendLine("completed = " & toSQLValueS(CompletedCell) & ",")
                missing = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "missing").ToString : If missing = "" Then missing = "0"
                sSQL.AppendLine("missing = " & toSQLValueS(missing) & ",")
                replacement = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "replacement").ToString : If replacement = "" Then replacement = "0"
                sSQL.AppendLine("replacement = " & toSQLValueS(replacement) & ",")
                orderError = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "orderError").ToString : If orderError = "" Then orderError = "0"
                sSQL.AppendLine("orderError= " & toSQLValueS(orderError) & ",")
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
                missing = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "missing").ToString : If missing = "" Then missing = "0"
                sSQL.AppendLine("missing= " & toSQLValueS(missing) & ",")
                replacement = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "replacement").ToString : If replacement = "" Then replacement = "0"
                sSQL.AppendLine("replacement = " & toSQLValueS(replacement) & ",")
                orderError = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "orderError").ToString : If orderError = "" Then orderError = "0"
                sSQL.AppendLine("orderError= " & toSQLValueS(orderError) & ",")

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
            If GridView1.RowCount = 0 Then
                cmdSendEmail.Enabled = False : cmdPrintAll.Enabled = False : cmdSendApointmentEmail.Enabled = False : cmdDefEmail.Enabled = False
            Else
                cmdSendEmail.Enabled = True : cmdPrintAll.Enabled = True : cmdSendApointmentEmail.Enabled = True : cmdDefEmail.Enabled = True
            End If
        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), "Dreamy Kitchen CRM", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub GridView1_CellValueChanging(sender As Object, e As CellValueChangedEventArgs) Handles GridView1.CellValueChanging

        If e.Column.FieldName = "completed" Then
            If e.Value = True Then GridView1.SetRowCellValue(GridView1.FocusedRowHandle, "dtCompleted", Date.Now) Else GridView1.SetRowCellValue(GridView1.FocusedRowHandle, "dtCompleted", Nothing)
        End If
    End Sub

    Private Sub FileSelect(ByVal Mode As Int16)
        'XtraOpenFileDialog1.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*"
        XtraOpenFileDialog1.FilterIndex = 1
        XtraOpenFileDialog1.InitialDirectory = "C:\"
        XtraOpenFileDialog1.Title = "Open File"
        XtraOpenFileDialog1.CheckFileExists = False
        XtraOpenFileDialog1.Multiselect = False
        Dim result As DialogResult = XtraOpenFileDialog1.ShowDialog()
        If result = DialogResult.OK Then
            Try

                Dim sSQL As String

                My.Computer.FileSystem.CopyFile(XtraOpenFileDialog1.FileName, ProgProps.ServerPath & Path.GetFileName(XtraOpenFileDialog1.FileName), True)
                Select Case Mode
                    Case 0
                        txtInstellipseFilename.EditValue = XtraOpenFileDialog1.FileName
                        sSQL = "UPDATE INST_ELLIPSE SET fInstEllipseName =  " & toSQLValueS(Path.GetFileName(XtraOpenFileDialog1.FileName).ToString) & ", fInstEllipse =  BulkColumn from Openrowset( Bulk " & toSQLValueS(ProgProps.ServerPath & Path.GetFileName(XtraOpenFileDialog1.FileName)) & ", Single_Blob) as InstEllipseF where ID = " & toSQLValueS(sID)
                    Case 1
                        txtInstellipseFilenameComplete.EditValue = XtraOpenFileDialog1.FileName
                        sSQL = "UPDATE INST_ELLIPSE SET fInstEllipseNameComplete =  " & toSQLValueS(Path.GetFileName(XtraOpenFileDialog1.FileName).ToString) & ", fInstEllipseComplete =  BulkColumn from Openrowset( Bulk " & toSQLValueS(ProgProps.ServerPath & Path.GetFileName(XtraOpenFileDialog1.FileName)) & ", Single_Blob) as InstEllipseF where ID = " & toSQLValueS(sID)
                End Select

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
                Case 0 : FileSelect(0)
                Case 1
                    Try
                        Dim Cmd As SqlCommand, sdr As SqlDataReader
                        Dim sSQL As String = "SELECT fInstEllipse,fInstEllipseName  FROM INST_ELLIPSE WHERE ID= " & toSQLValueS(sID)
                        Cmd = New SqlCommand(sSQL.ToString, CNDB)
                        sdr = Cmd.ExecuteReader()
                        If (sdr.Read() = True) Then
                            If sdr.IsDBNull(sdr.GetOrdinal("fInstEllipseName")) = False Then
                                Dim sFilename = sdr.GetString(sdr.GetOrdinal("fInstEllipseName"))
                                Dim fs As IO.FileStream = New IO.FileStream(ProgProps.TempFolderPath & sFilename, IO.FileMode.Create)
                                Dim b As Byte()
                                b = DirectCast(sdr("fInstEllipse"), Byte())
                                fs.Write(b, 0, b.Length)
                                fs.Close()
                                ShellExecute(ProgProps.TempFolderPath & sFilename)
                            End If
                        End If
                        sdr.Close()
                    Catch exfs As Exception
                        XtraMessageBox.Show(String.Format("Error: {0}", exfs.Message), "Dreamy Kitchen CRM", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Finally

                    End Try
                Case 2
                    If txtInstellipseFilename.EditValue = Nothing Then Exit Sub
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

    Private Sub cmdPrintAll_Click(sender As Object, e As EventArgs) Handles cmdPrintAll.Click

        If sComeFrom = 0 Then
            Dim report As New RepCUSEllipse
            report.Parameters.Item(0).Value = sID
            report.CreateDocument()
            Dim printTool As New ReportPrintTool(report)
            printTool.ShowRibbonPreview()
        Else
            Dim report As New RepCUSEllipseForSUP
            report.Parameters.Item(0).Value = sID
            report.CreateDocument()
            Dim printTool As New ReportPrintTool(report)
            printTool.ShowRibbonPreview()
        End If
    End Sub

    Private Sub SendEmailExportReport()
        Dim Cmd As SqlCommand, sdr As SqlDataReader
        Dim Emails As New SendEmail
        Dim statusMsg As String
        Dim sEmailTo As String
        Dim sSubject As String
        Dim sBody As String
        Dim sFile As String
        Dim sSQL As String
        Try


            If sComeFrom = 1 Then
                Dim report As New RepCUSEllipseForSUP()
                report.Parameters.Item(0).Value = sID
                sEmailTo = txtTo.EditValue
                sBody = ProgProps.InstEllipseInfBodySup
                sSubject = ProgProps.InstEllipseInfSubjectSup
                sBody = sBody.Replace("{INST_ELLIPSE_DATE_DELIVERED}", Date.Now.Date)
                sFile = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) & "\Downloads\Ενημερώτικό έντυπο εκκρεμοτήτων προμηθευτή.pdf"
                report.CreateDocument()
                report.ExportToPdf(sFile)
                report.Dispose()
                report = Nothing
            Else
                Dim report As New RepCUSEllipse()
                report.Parameters.Item(0).Value = sID
                sEmailTo = txtTo.EditValue
                sBody = txtBody.EditValue
                sBody = sBody.Replace("{INST_ELLIPSE_DATE_DELIVERED}", dtDateDelivered.Text)
                sSubject = txtSubject.EditValue
                sFile = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) & "\Downloads\Ενημερώτικό έντυπο εκκρεμοτήτων.pdf"
                report.CreateDocument()
                report.ExportToPdf(sFile)
                report.Dispose()
                report = Nothing
            End If

            sEmailTo = "dreamykitchen@gmail.com"
            sEmailTo = "johnmavroselinos@gmail.com"


            If Emails.SendEmail(ProgProps.InstEmailAccount, sSubject, sBody, sEmailTo, sFile, statusMsg) = True Then
                Select Case emailMode
                    Case 1 : sSQL = "Update INST_ELLIPSE SET emailApp = 1,DateOfEmailApp=getdate() WHERE ID = " & toSQLValueS(sID)
                    Case 2 : sSQL = "Update INST_ELLIPSE SET emailInf = 1,DateOfEmailInf=getdate() WHERE ID = " & toSQLValueS(sID)
                End Select

                Cmd = New SqlCommand(sSQL, CNDB) : Cmd.ExecuteNonQuery()

                ' Εισαγωγή ιστορικού email
                sSQL = "INSERT INTO INST_MAIL (instID,instEllipseID,emailFrom,emailTo,emailSubject,emailBody,DateofEmail,[createdBy],[createdOn])  
                        values (" & toSQLValueS(sINST_ID) & "," & toSQLValueS(sID) & "," & toSQLValueS(ProgProps.InstEmailAccount.ToString) & "," &
                                    toSQLValue(txtTo) & "," & toSQLValue(txtSubject) & "," &
                                    toSQLValue(txtBody) & ",getdate(), " &
                                    toSQLValueS(UserProps.ID.ToString) & ", getdate() )"
                Using oCmd As New SqlCommand(sSQL, CNDB)
                    oCmd.ExecuteNonQuery()
                End Using


                XtraMessageBox.Show("Το email στάλθηκε με επιτυχία", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                XtraMessageBox.Show("Παρουσιάστηκε πρόβλημα με σφάλμα " & statusMsg, ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub cboCUS_EditValueChanged(sender As Object, e As EventArgs) Handles cboCUS.EditValueChanged
        Dim sCusID As String
        If cboCUS.EditValue Is Nothing Then sCusID = toSQLValueS(Guid.Empty.ToString) Else sCusID = toSQLValueS(cboCUS.EditValue.ToString)
        Dim sSQL As New System.Text.StringBuilder
        sSQL.AppendLine("Select T.id,FullTranshDescription,Description,Iskitchen,Iscloset,Isdoors,Issc
                        from vw_TRANSH t
                        where  completed = 0 and T.cusid = " & sCusID & "order by description")
        FillCbo.TRANSH(cboTRANSH, sSQL)
    End Sub

    Private Sub cboINST_EditValueChanged(sender As Object, e As EventArgs) Handles cboINST.EditValueChanged
        If cboINST.GetColumnValue("cusID").ToString <> "" Then cboCUS.EditValue = System.Guid.Parse(cboINST.GetColumnValue("cusID").ToString)
        If cboINST.GetColumnValue("transhID").ToString <> "" Then cboTRANSH.EditValue = System.Guid.Parse(cboINST.GetColumnValue("transhID").ToString)
    End Sub

    Private Sub frmInstEllipse_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        If sID = Nothing Then Exit Sub
        If SaveButtonPressed = False Then
            If XtraMessageBox.Show("Θέλετε να σώσετε την εγγραφή?", "Dreamy Kitchen CRM", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbNo Then
                Dim sSQL As String = "DELETE FROM INST_ELLIPSE WHERE ID = '" & sID & "'"
                Using oCmd As New SqlCommand(sSQL, CNDB)
                    oCmd.ExecuteNonQuery()
                End Using
            End If
        End If
    End Sub

    Private Sub TabPane1_SelectedPageChanged(sender As Object, e As SelectedPageChangedEventArgs) Handles TabPane1.SelectedPageChanged
        Select Case TabPane1.SelectedPageIndex
            Case 1
                Prog_Prop.GetProgEmailInst()
                txtTo.EditValue = cboINST.GetColumnValue("email")
                txtSubject.EditValue = ProgProps.InstEllipseInfSubject
                If dtDateDelivered.EditValue = Nothing Or txtTmINFrom.EditValue = "00:00" Or txtTmINTo.EditValue = "00:00" Then cmdSendApointmentEmail.Enabled = False Else cmdSendApointmentEmail.Enabled = True
                Me.INST_MAILTableAdapter.FillByinstEllipseID(Me.DmDataSet.INST_MAIL, System.Guid.Parse(sID))
                LoadForms.RestoreLayoutFromXml(GridView3, "INST_MAIL_ELLIPSE.xml")
                'GridView3.Columns("DateOfEmail").DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
                'GridView3.Columns("DateOfEmail").DisplayFormat.FormatString = "dd/MM/yyyy HH:mm tt"
        End Select
    End Sub

    Private Sub DefInst_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles DefInst.ItemClick
        txtBody.EditValue = ProgProps.InstEllipseInfBody.Replace("{INST_ELLIPSE_DATE_DELIVERED}", dtDateDelivered.Text)
    End Sub

    Private Sub DefInstAppointment_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles DefInstAppointment.ItemClick
        txtBody.EditValue = ProgProps.InstEllipseInfAppointmentBody.Replace("{INST_ELLIPSE_DATE_DELIVERED}", dtDateDelivered.Text)
    End Sub
    Private Sub cmdSendApointmentEmail_Click(sender As Object, e As EventArgs) Handles cmdSendApointmentEmail.Click
        emailMode = 1 : ValidateEmail()
    End Sub

    Private Sub cmdSendEmail_Click(sender As Object, e As EventArgs) Handles cmdSendEmail.Click
        emailMode = 2 : ValidateEmail()
    End Sub

    Private Sub cmdNewInstEllipse_Click(sender As Object, e As EventArgs) Handles cmdNewInstEllipse.Click
        NewRecord()
    End Sub
    Private Sub ValidateEmail()
        If GridView1.RowCount = 0 Then XtraMessageBox.Show("Δεν υπάρχουν εκκρεμότητες προς αποστολή", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error) : Exit Sub
        If txtBody.Text = "" Then XtraMessageBox.Show("Παρακαλώ συμπληρώστε κείμενο", "Dreamy Kitchen CRM", MessageBoxButtons.OK, MessageBoxIcon.Error) : Exit Sub
        If txtSubject.Text = "" Then XtraMessageBox.Show("Παρακαλώ συμπληρώστε το θέμα", "Dreamy Kitchen CRM", MessageBoxButtons.OK, MessageBoxIcon.Error) : Exit Sub
        If txtTo.Text = "" Then XtraMessageBox.Show("Δεν υπάρχει καταχωρήμενο email στον πελάτη.", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error) : Exit Sub
        If XtraMessageBox.Show("Θέλετε να αποσταλεί το Email?", "Dreamy Kitchen CRM", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            SendEmailExportReport()
            Me.INST_MAILTableAdapter.FillByinstEllipseID(Me.DmDataSet.INST_MAIL, System.Guid.Parse(sID))
        End If
    End Sub
    Private Function SetInstEllipseCompleted() As Boolean
        Dim sSQL As String
        Try
            sSQL = "UPDATE INST_ELLIPSE SET COMPLETED = 1 WHERE ID = " & toSQLValueS(sID)
            Using oCmd As New SqlCommand(sSQL, CNDB)
                oCmd.ExecuteNonQuery()
            End Using
            Return True
        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), "Dreamy Kitchen CRM", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try

    End Function
    Private Function CheckIfHasCompletedInstJobs() As Boolean
        Dim Cmd As SqlCommand, sdr As SqlDataReader
        Dim sSQL As String
        sSQL = "SELECT top 1 id as JobEllipseid FROM INST_ELLIPSE_JOBS WHERE completed = 1 and instEllipseID= " & toSQLValueS(sID)
        Cmd = New SqlCommand(sSQL.ToString, CNDB)
        sdr = Cmd.ExecuteReader()
        Dim JobEllipseid As Integer
        If (sdr.Read() = True) Then
            If sdr.IsDBNull(sdr.GetOrdinal("JobEllipseid")) = False Then JobEllipseid = sdr.GetString(sdr.GetOrdinal("JobEllipseid")) Else JobEllipseid = ""
            If JobEllipseid <> "" Then Return True Else Return False
        Else
            Return False
        End If
        sdr.Close()
    End Function
    Private Function CheckIfEllipseHasDateDelivered() As Boolean
        Dim Cmd As SqlCommand, sdr As SqlDataReader
        Dim sSQL As String
        sSQL = "SELECT count (id) as CountEllipse  FROM INST_ELLIPSE WHERE DateDelivered is not null and ID= " & toSQLValueS(sID)
        Cmd = New SqlCommand(sSQL.ToString, CNDB)
        sdr = Cmd.ExecuteReader()
        Dim CountEllipse As Integer
        If (sdr.Read() = True) Then
            If sdr.IsDBNull(sdr.GetOrdinal("CountEllipse")) = False Then CountEllipse = sdr.GetInt32(sdr.GetOrdinal("CountEllipse")) Else CountEllipse = 0
            If CountEllipse > 0 Then Return True Else Return False
        End If
        sdr.Close()
    End Function
    Private Function CheckIfEllipseHasCompleteDocument() As Boolean
        Dim Cmd As SqlCommand, sdr As SqlDataReader
        Dim sSQL As String
        sSQL = "SELECT fInstEllipseNameComplete FROM INST_ELLIPSE WHERE ID= " & toSQLValueS(sID)
        Cmd = New SqlCommand(sSQL.ToString, CNDB)
        sdr = Cmd.ExecuteReader()
        Dim fInstEllipseNameComplete As String
        If (sdr.Read() = True) Then
            If sdr.IsDBNull(sdr.GetOrdinal("fInstEllipseNameComplete")) = False Then fInstEllipseNameComplete = sdr.GetString(sdr.GetOrdinal("fInstEllipseNameComplete")) Else fInstEllipseNameComplete = ""
            If fInstEllipseNameComplete <> "" Then Return True Else Return False
        End If
        sdr.Close()
    End Function

    Private Function CheckIfHasInstNotCompleted()
        Dim Cmd As SqlCommand, sdr As SqlDataReader
        Dim sSQL As String
        sSQL = "SELECT id FROM INST_ELLIPSE WHERE completed = 0  and instID= " & toSQLValueS(sID)
        Cmd = New SqlCommand(sSQL.ToString, CNDB)
        sdr = Cmd.ExecuteReader()
        Dim EllipseID As String
        If (sdr.Read() = True) Then
            If sdr.IsDBNull(sdr.GetOrdinal("EllipseID")) = False Then EllipseID = sdr.GetString(sdr.GetOrdinal("EllipseID")) Else EllipseID = ""
            If EllipseID <> "" Then Return True Else Return False
        Else
            Return False
        End If
        sdr.Close()
    End Function
    Private Function CheckIfInstJobsAreCompleted()
        Dim Cmd As SqlCommand, sdr As SqlDataReader
        Dim sSQL As String
        sSQL = "SELECT count (id) as CountJobEllipse  FROM INST_ELLIPSE_JOBS WHERE completed = 0 and instEllipseID= " & toSQLValueS(sID)
        Cmd = New SqlCommand(sSQL.ToString, CNDB)
        sdr = Cmd.ExecuteReader()
        Dim CountJobEllipse As Integer
        If (sdr.Read() = True) Then
            If sdr.IsDBNull(sdr.GetOrdinal("CountJobEllipse")) = False Then CountJobEllipse = sdr.GetInt32(sdr.GetOrdinal("CountJobEllipse")) Else CountJobEllipse = 0
            If CountJobEllipse > 0 Then Return False Else Return True
        End If
        sdr.Close()
    End Function


    Private Sub Insert_EllipseSer_EllipseJobs_InstEllipse()
        Try
            Dim sSQL As String
            Dim LastEllipseID As String = GetLastEllipseID()

            ' Μεταφέρει ότι άλλη εκκρεμότητα υπάρχει ανολοκλήρωτη στην καινούρια έλλειψη 
            sSQL = "INSERT INTO INST_ELLIPSE_JOBS ([ID],[instEllipseID],[instID], [name], [cmt], [completed], [dtCompleted],  [createdOn], [createdBy]) " &
                    "SELECT NEWID()," & toSQLValueS(sID) & " ,  " & toSQLValueS(sINST_ID) & ", [name], IEJ.[cmt], IEJ.[completed], [dtCompleted],  IEJ.[createdOn], IEJ.[createdBy] " &
                    "from INST I " &
                    "inner join INST_ELLIPSE IE on IE.id= " & toSQLValueS(LastEllipseID) &
                    " INNER  join INST_ELLIPSE_JOBS  IEJ ON IEJ.instEllipseID =IE.ID " &
                    "WHERE IEJ.completed=0 And I.[ID]= " & toSQLValueS(sINST_ID)
            Using oCmd As New SqlCommand(sSQL, CNDB)
                oCmd.ExecuteNonQuery()
            End Using
            Me.INST_ELLIPSE_JOBSTableAdapter.FillBYinstEllipseID(Me.DmDataSet.INST_ELLIPSE_JOBS, System.Guid.Parse(sID))
            txtInstellipseFilename.Enabled = True
            GridView1.OptionsBehavior.Editable = True
            Mode = FormMode.EditRecord
        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), "Dreamy Kitchen CRM", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub NewRecord()
        'Έλεγχος για να δεί αν υπάρχει μη ολοκληρωμένη έλλειψη πριν ανοίξει καινούρια γιαυτην την τοποθέτηση 
        If CheckIfHasInstNotCompleted() = True Then XtraMessageBox.Show("Δεν μπορείτε να δημιουργήσετε νέα εγγραφή όταν υπάρχει μη ολοκληρωμένη εκκρεμότητα.", "Dreamy Kitchen CRM", MessageBoxButtons.OK, MessageBoxIcon.Error) : Exit Sub
        'Eλεγχος αν υπάρχουν ολοκληρωμένες εκκρεμότητες για να συνεχίσει
        If CheckIfHasCompletedInstJobs() = True Then XtraMessageBox.Show("Δεν μπορείτε να δημιουργήσετε νέα εγγραφή όταν όλες οι εργασίες-εκκρεμότητες είναι μη ολοκληρωμένες.", "Dreamy Kitchen CRM", MessageBoxButtons.OK, MessageBoxIcon.Error) : Exit Sub
        'Eλεγχος αν στην έλλειψη έχει καταχωρηθεί ημερομηνία τοποθέτησης
        'If CheckIfEllipseHasDateDelivered() = False Then XtraMessageBox.Show("Δεν μπορείτε να δημιουργήσετε νέα εγγραφή όταν δεν έχει καταχωρηθεί Ημερ/νία Τοποθέτησης.", "Dreamy Kitchen CRM", MessageBoxButtons.OK, MessageBoxIcon.Error) : Exit Sub
        'Eλεγχος αν υπάρχει έντυπο ολοκλήρωσης
        If CheckIfEllipseHasCompleteDocument() = True Then XtraMessageBox.Show("Δεν μπορείτε να δημιουργήσετε νέα εγγραφή, έχουν ολοκληρωθεί όλες οι εκκρεμότητες.", "Dreamy Kitchen CRM", MessageBoxButtons.OK, MessageBoxIcon.Error) : Exit Sub
        ' Κάνει ολοκληρωμένη την ελλέιψη τις συγκεκριμένης τοποθέτησης
        If SetInstEllipseCompleted() = False Then Exit Sub
        sID = System.Guid.NewGuid.ToString
        'Καταχώρηση συνεργείων και εκκρεμοτήτων που έμειναν ανολοκλήρωτες στην νέα έλλειψη
        Insert_EllipseSer_EllipseJobs_InstEllipse()
        dtDateDelivered.EditValue = Nothing : txtTmINFrom.EditValue = "00:00" : txtTmINTo.EditValue = "00:00" : dtReceipt.EditValue = Nothing : chkCompleted.CheckState = CheckState.Unchecked
        txtComments.EditValue = Nothing : txtInstellipseFilename.EditValue = Nothing : cmdConvertToOrder.Enabled = False
        AddRecord()
        End Sub

    Private Sub txtInstellipseFilenameComplete_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles txtInstellipseFilenameComplete.ButtonClick
        Try
            Select Case e.Button.Index
                Case 0
                    'Έλεγχος για να δεί αν υπάρχει μη ολοκληρωμένη έλλειψη.Αν υπάρχει δεν μπορεί να επισυνάψει έντυπο ολοκλήρωσης
                    If CheckIfInstJobsAreCompleted() = False Then XtraMessageBox.Show("Δεν μπορείτε επισυνάψετε έντυπο ολοκλήρωσης όταν υπάρχει έστω και μια μη ολοκληρωμένη εκκρεμότητα.", "Dreamy Kitchen CRM", MessageBoxButtons.OK, MessageBoxIcon.Error) : Exit Sub
                    FileSelect(1)
                Case 1
                    Try
                        Dim Cmd As SqlCommand, sdr As SqlDataReader
                        Dim sSQL As String = "SELECT fInstEllipseComplete,fInstEllipseNameComplete  FROM INST_ELLIPSE WHERE ID= " & toSQLValueS(sID)
                        Cmd = New SqlCommand(sSQL.ToString, CNDB)
                        sdr = Cmd.ExecuteReader()
                        If (sdr.Read() = True) Then
                            If sdr.IsDBNull(sdr.GetOrdinal("fInstEllipseNameComplete")) = False Then
                                Dim sFilename = sdr.GetString(sdr.GetOrdinal("fInstEllipseNameComplete"))
                                Dim fs As IO.FileStream = New IO.FileStream(ProgProps.TempFolderPath & sFilename, IO.FileMode.Create)
                                Dim b As Byte()
                                b = DirectCast(sdr("fInstEllipseComplete"), Byte())
                                fs.Write(b, 0, b.Length)
                                fs.Close()
                                ShellExecute(ProgProps.TempFolderPath & sFilename)
                            End If
                        End If
                        sdr.Close()
                    Catch exfs As Exception
                        XtraMessageBox.Show(String.Format("Error: {0}", exfs.Message), "Dreamy Kitchen CRM", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Finally

                    End Try
                Case 2
                    If txtInstellipseFilenameComplete.EditValue = Nothing Then Exit Sub
                    If XtraMessageBox.Show("Θέλετε να διαγραφεί το αρχείο?", "Dreamy Kitchen CRM", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                        Dim sSQL As String
                        sSQL = "UPDATE INST_ELLIPSE SET fInstEllipseNameComplete =  NULL ,fInstEllipseComplete =  NULL where ID = " & toSQLValueS(sID)
                        'Εκτέλεση QUERY
                        Using oCmd As New SqlCommand(sSQL, CNDB)
                            oCmd.ExecuteNonQuery()
                        End Using
                        txtInstellipseFilenameComplete.EditValue = Nothing
                    End If
            End Select
        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), "Dreamy Kitchen CRM", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try


    End Sub
    Private Sub GridView1_PopupMenuShowing(sender As Object, e As PopupMenuShowingEventArgs) Handles GridView1.PopupMenuShowing
        If e.MenuType = GridMenuType.Column Then LoadForms.PopupMenuShow(e, GridView1, "INST_ELLIPSE_JOBS_def.xml", "INST_ELLIPSE_JOBS")
    End Sub

    Private Sub GridView3_PopupMenuShowing(sender As Object, e As PopupMenuShowingEventArgs) Handles GridView3.PopupMenuShowing
        If e.MenuType = GridMenuType.Column Then LoadForms.PopupMenuShow(e, GridView3, "INST_MAIL_ELLIPSE.xml", "INST_MAIL")
    End Sub
End Class
'Private Sub ShowQuestionForm()
'    Dim args As New XtraInputBoxArgs()
'    Dim Item1 As New RadioGroupItem
'    Item1.Description = "Αφορά Πελάτη"
'    Dim item2 As New RadioGroupItem
'    item2.Description = "Αφορά Προμηθευτή"
'    Dim RadioEdit1 As New RadioGroup
'    RadioEdit1.Properties.Items.Add(Item1)
'    RadioEdit1.Properties.Items.Add(item2)
'    RadioEdit1.Name = "radioEditComeFrom"
'    RadioEdit1.Location = New System.Drawing.Point(30, 35)
'    RadioEdit1.Width = 50
'    RadioEdit1.Height = 100
'    ' set required Input Box options
'    args.Caption = "Επιλογή Εκκρεμότητας"
'    args.Prompt = "Επιλέξτε ποιον αφορά η εκκρεμότητα"
'    args.DefaultButtonIndex = 0
'    AddHandler args.Showing, AddressOf Args_Showing
'    ' initialize a DateEdit editor with custom settings

'    args.Editor = RadioEdit1
'    AddHandler RadioEdit1.SelectedIndexChanged, AddressOf SelectedIndexChanged

'    Dim result = XtraInputBox.Show(args)
'    'If result = Nothing Then ComeFrom = 0

'End Sub
'Private Sub SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs)
'    Dim Edit As RadioGroup = CType(sender, RadioGroup)
'    If (Edit.SelectedIndex = 0) Then sComeFrom = 0 Else sComeFrom = 1
'End Sub
'Private Sub Args_Showing(ByVal sender As Object, ByVal e As XtraMessageShowingArgs)
'    e.Form.Icon = Me.Icon
'End Sub