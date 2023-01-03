
Imports System.Data.SqlClient
Imports DevExpress.Utils
Imports DevExpress.Utils.Menu
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Menu
Imports DevExpress.XtraGrid.Views.Grid

Public Class frmNotes
    Private sID As String
    Private Ctrl As DevExpress.XtraGrid.Views.Layout.LayoutView
    Private Ctrl2 As DevExpress.XtraGrid.Views.Grid.GridView
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
    Public WriteOnly Property Scroller2 As DevExpress.XtraGrid.Views.Grid.GridView
        Set(value2 As DevExpress.XtraGrid.Views.Grid.GridView)
            Ctrl2 = value2
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

        'XtraOpenFileDialog1.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*"
        XtraOpenFileDialog1.FilterIndex = 1
        XtraOpenFileDialog1.InitialDirectory = "C:\"
        XtraOpenFileDialog1.Title = "Open File"
        XtraOpenFileDialog1.CheckFileExists = False
        XtraOpenFileDialog1.Multiselect = True
        Dim result As DialogResult = XtraOpenFileDialog1.ShowDialog()
        If result = DialogResult.OK Then
            txtFileNames.EditValue = ""
            For I = 0 To XtraOpenFileDialog1.FileNames.Count - 1
                txtFileNames.EditValue = txtFileNames.EditValue & IIf(txtFileNames.EditValue <> "", ";", "") & XtraOpenFileDialog1.SafeFileNames(I)
            Next I


        End If
    End Sub
    Private Sub frmNotes_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim sSQL As New System.Text.StringBuilder
        sSQL.AppendLine("Select id,Fullname,salary from vw_EMP where jobID not in ( '475CBAD0-555B-4945-92EF-7D5A611D8D46','E0C1789F-713C-45C1-8339-41950701F146','F1A60661-D448-41B7-8CF0-CE6B9FF6E518') order by Fullname")
        FillCbo.EMP(cboSaler, sSQL)

        'Εττικέτες
        FillCbo.NOTES_L(cboNotesL)

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
        LoadForms.RestoreLayoutFromXml(GridView1, "vw_NOTES_F_def.xml")
        Me.CenterToScreen()
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
                LoadForms.RestoreLayoutFromXml(GridView1, "vw_NOTES_F_def.xml")
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
        If cboNotesL.EditValue <> Nothing Then form1.Mode = FormMode.EditRecord Else form1.Mode = FormMode.NewRecord
        frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(form1), New Point(CInt(form1.Parent.ClientRectangle.Width / 2 - form1.Width / 2), CInt(form1.Parent.ClientRectangle.Height / 2 - form1.Height / 2)))
        form1.Show()
    End Sub
    Private Sub ManageSaler()
        Dim form1 As frmEMP = New frmEMP()
        form1.Text = "Πωλητές"
        form1.CallerControl = cboSaler
        form1.CalledFromControl = True
        form1.MdiParent = frmMain
        If cboSaler.EditValue <> Nothing Then
            form1.ID = cboSaler.EditValue.ToString
            form1.Mode = FormMode.EditRecord
        Else
            form1.Mode = FormMode.NewRecord
        End If
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
                    sResult = DBQ.InsertDataFiles(XtraOpenFileDialog1, sGuid, "NOTES_F")
                    LoadForms.LoadDataToGrid(GridControl1, GridView1, "select ID,NOTESID,files,filename,comefrom,createdon,realname From vw_NOTES_F where NOTESID = '" & sGuid & "'")
                    LoadForms.RestoreLayoutFromXml(GridView1, "vw_NOTES_F_def.xml")
                End If
                txtCode.Text = DBQ.GetNextId("NOTES")
                If Frm.Name = "frmScroller" Then
                    Dim form As frmScroller = Frm
                    form.LoadRecords("vw_NOTES")
                Else
                    Dim form As frmNotesScroller = Frm
                    form.LoadRecords("vw_NOTES")
                End If
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
        If GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "filename") = Nothing Then Exit Sub
        Dim fs As IO.FileStream = New IO.FileStream(ProgProps.TempFolderPath & GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "filename"), IO.FileMode.Create)
        Dim b() As Byte = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "files")
        Try
            fs.Write(b, 0, b.Length)
            fs.Close()

            ShellExecute(ProgProps.TempFolderPath & GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "filename"))
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
            Case 1 : If UserProps.ID.ToString.ToUpper = "3F9DC32E-BE5B-4D46-A13C-EA606566CF32" Then cboSaler.EditValue = Nothing : ManageSaler()
            Case 2 : If UserProps.ID.ToString.ToUpper = "3F9DC32E-BE5B-4D46-A13C-EA606566CF32" Then If cboSaler.EditValue <> Nothing Then ManageSaler()
            Case 3 : cboSaler.EditValue = Nothing
        End Select
    End Sub
    Private Sub GridView1_PopupMenuShowing(sender As Object, e As PopupMenuShowingEventArgs) Handles GridView1.PopupMenuShowing
        If e.MenuType = GridMenuType.Column Then
            Dim menu As DevExpress.XtraGrid.Menu.GridViewColumnMenu = TryCast(e.Menu, GridViewColumnMenu)
            Dim item As New DXEditMenuItem()
            Dim itemColor As New DXEditMenuItem()

            'menu.Items.Clear()
            If menu.Column IsNot Nothing Then
                'Για να προσθέσουμε menu item στο Default menu πρέπει πρώτα να προσθέσουμε ένα Repository Item 
                'Υπάρχουν πολλών ειδών Repositorys
                '1st Custom Menu Item
                Dim popRenameColumn As New RepositoryItemTextEdit
                popRenameColumn.Name = "RenameColumn"
                menu.Items.Add(New DXEditMenuItem("Μετονομασία Στήλης", popRenameColumn, AddressOf OnEditValueChanged, Nothing, Nothing, 100, 0))
                item = menu.Items.Item("Μετονομασία Στήλης")
                item.EditValue = menu.Column.GetTextCaption
                item.Tag = menu.Column.AbsoluteIndex

                '2nd Custom Menu Item
                menu.Items.Add(CreateCheckItem("Κλείδωμα Στήλης", menu.Column, Nothing))

                '3rd Custom Menu Item
                Dim popColorsColumn As New RepositoryItemColorEdit
                popColorsColumn.Name = "ColorsColumn"
                menu.Items.Add(New DXEditMenuItem("Χρώμα Στήλης", popColorsColumn, AddressOf OnColumnsColorChanged, Nothing, Nothing, 100, 0))
                itemColor = menu.Items.Item("Χρώμα Στήλης")
                itemColor.EditValue = menu.Column.AppearanceCell.BackColor
                itemColor.Tag = menu.Column.AbsoluteIndex

                '4nd Custom Menu Item
                menu.Items.Add(New DXMenuItem("Αποθήκευση όψης", AddressOf OnSaveView, Nothing, Nothing, Nothing, Nothing))

                '5nd Custom Menu Item
                menu.Items.Add(New DXMenuItem("Συγχρονισμός όψης από Server", AddressOf OnSyncView, Nothing, Nothing, Nothing, Nothing))

            End If
        End If
    End Sub

    'Μετονομασία Στήλης Master
    Private Sub OnEditValueChanged(ByVal sender As System.Object, ByVal e As EventArgs)
        Dim item As New DXEditMenuItem()
        item = sender
        If item.Tag Is Nothing Then Exit Sub
        GridView1.Columns(item.Tag).Caption = item.EditValue
        'MessageBox.Show(item.EditValue.ToString())
    End Sub
    Private Function CreateCheckItem(ByVal caption As String, ByVal column As GridColumn, ByVal image As Image) As DXMenuCheckItem
        Dim item As New DXMenuCheckItem(caption, (Not column.OptionsColumn.AllowMove), image, New EventHandler(AddressOf OnCanMoveItemClick))
        item.Tag = New MenuColumnInfo(column)
        Return item
    End Function
    'Αλλαγή Χρώματος Στήλης Master
    Private Sub OnColumnsColorChanged(ByVal sender As System.Object, ByVal e As EventArgs)
        Dim item As DXEditMenuItem = TryCast(sender, DXEditMenuItem)
        item = sender
        If item.Tag Is Nothing Then Exit Sub
        GridView1.Columns(item.Tag).AppearanceCell.BackColor = item.EditValue
    End Sub
    'Κλείδωμα Στήλης Master
    Private Sub OnCanMoveItemClick(ByVal sender As Object, ByVal e As EventArgs)
        Dim item As DXMenuCheckItem = TryCast(sender, DXMenuCheckItem)
        Dim info As MenuColumnInfo = TryCast(item.Tag, MenuColumnInfo)
        If info Is Nothing Then
            Return
        End If
        info.Column.OptionsColumn.AllowMove = Not item.Checked
    End Sub
    'Αποθήκευση όψης 
    Private Sub OnSaveView(ByVal sender As System.Object, ByVal e As EventArgs)
        Dim item As DXMenuItem = TryCast(sender, DXMenuItem)
        GridView1.SaveLayoutToXml(Application.StartupPath & "\DSGNS\DEF\NOTES_F_def.xml", OptionsLayoutBase.FullLayout)
        XtraMessageBox.Show("Η όψη αποθηκεύτηκε με επιτυχία", "Dreamy Kitchen CRM", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ' Μόνο αν ο Χρήστης είναι ο Παναγόπουλος
        If UserProps.ID.ToString.ToUpper = "3F9DC32E-BE5B-4D46-A13C-EA606566CF32" Then
            If XtraMessageBox.Show("Θέλετε να γίνει κοινοποίηση της όψης? Εαν επιλέξετε 'Yes' όλοι οι χρήστες θα έχουν την ίδια όψη", "Dreamy Kitchen CRM", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                If My.Computer.FileSystem.FileExists(ProgProps.ServerViewsPath & "DSGNS\DEF\NOTES_F_def.xml") = False Then GridView1.OptionsLayout.LayoutVersion = "v1"
                GridView1.SaveLayoutToXml(ProgProps.ServerViewsPath & "DSGNS\DEF\NOTES_F_def.xml", OptionsLayoutBase.FullLayout)
            End If
        End If

    End Sub
    'Συγχρονισμός όψης από Server
    Private Sub OnSyncView(ByVal sender As System.Object, ByVal e As EventArgs)
        If XtraMessageBox.Show("Θέλετε να γίνει μεταφορά της όψης από τον server?", "Dreamy Kitchen CRM", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            ' Έλεγχος αν υπάρχει όψη με μεταγενέστερη ημερομηνία στον Server
            If System.IO.File.Exists(ProgProps.ServerViewsPath & "DSGNS\DEF\NOTES_F_def.xml") = True Then
                My.Computer.FileSystem.CopyFile(ProgProps.ServerViewsPath & "DSGNS\DEF\NOTES_F_def.xml", Application.StartupPath & "\DSGNS\DEF\NOTES_F_def.xml", True)
                GridView1.RestoreLayoutFromXml(Application.StartupPath & "\DSGNS\DEF\NOTES_F_def.xml", OptionsLayoutBase.FullLayout)
            End If
        End If
    End Sub


    Friend Class MenuColumnInfo
        Public Sub New(ByVal column As GridColumn)
            Me.Column = column
        End Sub
        Public Column As GridColumn
    End Class

End Class