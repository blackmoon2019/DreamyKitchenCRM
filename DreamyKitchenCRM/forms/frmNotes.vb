
Imports System.Data.SqlClient
Imports DevExpress.Utils
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraGrid.Columns

Public Class frmNotes
    Private sID As String
    Private Ctrl As DevExpress.XtraGrid.Views.Layout.LayoutView
    Private Frm As DevExpress.XtraEditors.XtraForm
    Public Mode As Byte
    Private Valid As New ValidateControls
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
    Public WriteOnly Property Scroller As DevExpress.XtraGrid.Views.Layout.LayoutView
        Set(value As DevExpress.XtraGrid.Views.Layout.LayoutView)
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

    Private Sub txtFileNames_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles txtFileNames.ButtonClick
        If e.Button.Index = 0 Then
            FilesSelection()
        Else
            txtFileNames.EditValue = Nothing
        End If
    End Sub
    Private Sub FilesSelection()
        OpenFileDialog1.FilterIndex = 1
        OpenFileDialog1.InitialDirectory = "C:\"
        OpenFileDialog1.Title = "Open File"
        OpenFileDialog1.CheckFileExists = False
        OpenFileDialog1.Multiselect = True
        Dim result As DialogResult = OpenFileDialog1.ShowDialog()
        If result = DialogResult.OK Then
            txtFileNames.EditValue = ""
            For I = 0 To OpenFileDialog1.FileNames.Count - 1
                txtFileNames.EditValue = txtFileNames.EditValue & IIf(txtFileNames.EditValue <> "", ";", "") & OpenFileDialog1.SafeFileNames(I)
            Next I
        End If
    End Sub
    Private Sub frmNotes_Load(sender As Object, e As EventArgs) Handles Me.Load
        'Εττικέτες
        FillCbo.NOTES_L(cboNotesL)
        'Πωλητές
        FillCbo.SALERS(cboSaler)
        Select Case Mode
            Case FormMode.NewRecord
                'dtDTS.EditValue = DateTime.Now
                txtCode.Text = DBQ.GetNextId("NOTES")
            Case FormMode.EditRecord
                LoadForms.LoadForm(LayoutControl1, "Select * from vw_NOTES where id ='" + sID + "'")
                LoadForms.LoadDataToGrid(GridControl1, GridView1, "select ID,notesID,files,filename,comefrom,createdon,realname From vw_NOTES_F where notesID = '" & sID & "'")
                Dim C As New GridColumn
                C.Name = "ICO"
                C.Caption = ""
                C.Visible = True
                Dim textEdit As New RepositoryItemTextEdit()
                textEdit.ContextImageOptions.Image = My.Resources.AddFile_16x16
                C.ColumnEdit = textEdit
                GridControl1.RepositoryItems.Add(textEdit)
                C.VisibleIndex = 0
                GridView1.Columns.Add(C)
        End Select
        'Εαν δεν υπάρχει Default Σχέδιο δημιουργεί
        If My.Computer.FileSystem.FileExists(Application.StartupPath & "\DSGNS\DEF\vw_NOTES_F_def.xml") = False Then
            GridView1.SaveLayoutToXml(Application.StartupPath & "\DSGNS\DEF\vw_NOTES_F_def.xml", OptionsLayoutBase.FullLayout)
        End If
        GridView1.RestoreLayoutFromXml(Application.StartupPath & "\DSGNS\DEF\vw_NOTES_F_def.xml", OptionsLayoutBase.FullLayout)
        Me.CenterToScreen()
        My.Settings.frmCustomers = Me.Location
        My.Settings.Save()
        cmdSave.Enabled = IIf(Mode = FormMode.NewRecord, UserProps.AllowInsert, UserProps.AllowEdit)
    End Sub
    Private Sub DeleteRecord()
        Dim sSQL As String
        Try
            If GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "ID") = Nothing Then Exit Sub
            If XtraMessageBox.Show("Θέλετε να διαγραφεί η τρέχουσα εγγραφή?", "Dreamy Kitchen CRM", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                sSQL = "DELETE FROM NOTES_F WHERE ID = '" & GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "ID").ToString & "'"

                Using oCmd As New SqlCommand(sSQL, CNDB)
                    oCmd.ExecuteNonQuery()
                End Using
                XtraMessageBox.Show("Η εγγραφή διαγράφηκε με επιτυχία", "Dreamy Kitchen CRM", MessageBoxButtons.OK, MessageBoxIcon.Information)
                LoadForms.LoadDataToGrid(GridControl1, GridView1, "select ID,notesID,filename,comefrom,createdon,realname From vw_NOTES_F where notesID = '" & sID & "'")
            End If
        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), "Dreamy Kitchen CRM", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub cboNotesL_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboNotesL.ButtonClick
        Select Case e.Button.Index
            Case 1 : ManageNotesL()
            Case 2 : cboNotesL.EditValue = Nothing
        End Select
    End Sub
    Private Sub ManageNotesL()
        Dim form1 As frmGen = New frmGen()
        form1.Text = "Εττικέτες"
        form1.L1.Text = "Κωδικός"
        form1.L2.Text = "Εττικέτα"
        form1.DataTable = "NOTES_L"
        form1.CallerControl = cboNotesL
        form1.CalledFromControl = True
        If cboNotesL.EditValue <> Nothing Then form1.ID = cboNotesL.EditValue.ToString
        form1.MdiParent = frmMain
        form1.L3.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        form1.L4.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        form1.L5.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        form1.L6.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        If cboNotesL.EditValue <> Nothing Then form1.Mode = FormMode.EditRecord Else form1.Mode = FormMode.NewRecord
        frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(form1), New Point(CInt(form1.Parent.ClientRectangle.Width / 2 - form1.Width / 2), CInt(form1.Parent.ClientRectangle.Height / 2 - form1.Height / 2)))
        form1.Show()
    End Sub
    Private Sub ManageSalers()
        Dim form1 As frmGen = New frmGen()
        form1.Text = "Πωλητές"
        form1.L1.Text = "Κωδικός"
        form1.L2.Text = "Πωλητής"
        form1.DataTable = "SALERS"
        form1.CalledFromControl = True
        form1.CallerControl = cboSaler
        If cboSaler.EditValue <> Nothing Then form1.ID = cboSaler.EditValue.ToString
        form1.MdiParent = frmMain
        form1.L3.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        form1.L4.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        form1.L5.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        If cboSaler.EditValue <> Nothing Then form1.Mode = FormMode.EditRecord Else form1.Mode = FormMode.NewRecord
        frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(form1), New Point(CInt(form1.Parent.ClientRectangle.Width / 2 - form1.Width / 2), CInt(form1.Parent.ClientRectangle.Height / 2 - form1.Height / 2)))
        form1.Show()
    End Sub
    Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click
        Dim sResult As Boolean
        Dim sGuid As String
        Try
            If Valid.ValidateForm(LayoutControl1) Then
                Select Case Mode
                    Case FormMode.NewRecord
                        sGuid = System.Guid.NewGuid.ToString
                        sResult = DBQ.InsertData(LayoutControl1, "NOTES", sGuid)
                    Case FormMode.EditRecord
                        sResult = DBQ.UpdateData(LayoutControl1, "NOTES", sID)
                        sGuid = sID
                End Select
                'Καθαρισμός Controls
                'If Mode = FormMode.EditRecord Then Cls.ClearCtrls(LayoutControl1)
                'dtDTS.EditValue = DateTime.Now
                If txtFileNames.Text <> "" Then
                    sResult = DBQ.InsertDataFiles(OpenFileDialog1, sGuid, "NOTES_F")
                    LoadForms.LoadDataToGrid(GridControl1, GridView1, "select ID,NOTESID,files,filename,comefrom,createdon,realname From vw_NOTES_F where NOTESID = '" & sGuid & "'")
                End If
                txtCode.Text = DBQ.GetNextId("NOTES")
                Dim form As frmNotesScroller = Frm
                form.LoadRecords("vw_NOTES")
                If sResult = True Then XtraMessageBox.Show("Η εγγραφή αποθηκέυτηκε με επιτυχία", "Dreamy Kitchen CRM", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), "Dreamy Kitchen CRM", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub frmNotes_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        If Me.WindowState = FormWindowState.Maximized Then frmMain.XtraTabbedMdiManager1.Dock(Me, frmMain.XtraTabbedMdiManager1)
    End Sub

    Private Sub GridView1_KeyDown(sender As Object, e As KeyEventArgs) Handles GridView1.KeyDown
        Select Case e.KeyCode
            'Case Keys.F2 : If UserProps.AllowInsert = True Then NewRecord()
            'Case Keys.F3 : If UserProps.AllowEdit = True Then EditRecord()
            'Case Keys.F5 : LoadRecords()
            Case Keys.Delete : DeleteRecord() 'If UserProps.AllowDelete = True Then DeleteRecord()
        End Select
    End Sub

    Private Sub GridControl1_DoubleClick(sender As Object, e As EventArgs) Handles GridControl1.DoubleClick
        Dim fs As IO.FileStream = New IO.FileStream(My.Settings.CRM_PATH & "\" & GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "filename"), IO.FileMode.Create)
        Dim b() As Byte = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "files")
        Try
            fs.Write(b, 0, b.Length)
            fs.Close()

            ShellExecute(My.Settings.CRM_PATH & "\" & GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "filename"))
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

    Private Sub frmNotes_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        GridView1.SaveLayoutToXml(Application.StartupPath & "\DSGNS\DEF\vw_NOTES_F_def.xml", OptionsLayoutBase.FullLayout)
    End Sub
    Private Sub cboSaler_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboSaler.ButtonClick
        Select Case e.Button.Index
            Case 1 : ManageSalers()
            Case 2 : cboSaler.EditValue = Nothing
        End Select
    End Sub

    Private Sub cboSaler_EditValueChanged(sender As Object, e As EventArgs) Handles cboSaler.EditValueChanged

    End Sub

    Private Sub txtFileNames_EditValueChanged(sender As Object, e As EventArgs) Handles txtFileNames.EditValueChanged

    End Sub
End Class