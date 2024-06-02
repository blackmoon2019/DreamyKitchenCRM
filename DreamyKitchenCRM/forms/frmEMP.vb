Imports System.CodeDom.Compiler
Imports System.Data.SqlClient
Imports System.IO
Imports DevExpress.Utils
Imports DevExpress.Utils.Menu
Imports DevExpress.XtraBars.Navigation
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraExport.Xls
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Menu
Imports DevExpress.XtraGrid.Views.Grid

Public Class frmEMP
    Private sID As String
    Private Ctrl As DevExpress.XtraGrid.Views.Grid.GridView
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

    Private Sub frmEMP_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim sSQL As New System.Text.StringBuilder
        'Νομοί
        FillCbo.COU(cboCOU)
        FillCbo.PRF(cboPRF)
        FillCbo.DOY(cboDOY)
        FillCbo.DEP(cboDEP)
        'FillCbo.SER(cboSER)
        'FillCbo.SALERS(cboSaler)
        FillCbo.JOBS(cboJobs)

        Select Case Mode
            Case FormMode.NewRecord
                'dtDTS.EditValue = DateTime.Now
                txtCode.Text = DBQ.GetNextId("EMP")
            Case FormMode.EditRecord
                If cboCOU.EditValue isnot Nothing Then sSQL.AppendLine(" where couid = " & toSQLValueS(cboCOU.EditValue.ToString))
                FillCbo.AREAS(cboAREAS, sSQL)
                LoadForms.LoadForm(LayoutControl1, "Select * from vw_EMP where id ='" + sID + "'")
                LoadForms.LoadDataToGrid(GridControl1, GridView1, "select ID,empID,files,filename,comefrom,createdon,realname From vw_EMP_F where empID = '" & sID & "'")
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
        LoadForms.RestoreLayoutFromXml(GridView1, "vw_EMP_F_def.xml")
        Me.CenterToScreen()
        cmdSave.Enabled = IIf(Mode = FormMode.NewRecord, UserProps.AllowInsert, UserProps.AllowEdit)

    End Sub
    Private Sub DeleteRecord()
        Dim sSQL As String
        Try
            If GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "ID") = Nothing Then Exit Sub
            If XtraMessageBox.Show("Θέλετε να διαγραφεί η τρέχουσα εγγραφή?", ProgProps.ProgTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                sSQL = "DELETE FROM EMP_F WHERE ID = '" & GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "ID").ToString & "'"

                Using oCmd As New SqlCommand(sSQL, CNDB)
                    oCmd.ExecuteNonQuery()
                End Using
                XtraMessageBox.Show("Η εγγραφή διαγράφηκε με επιτυχία", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Information)
                LoadForms.LoadDataToGrid(GridControl1, GridView1, "select ID,empID,filename,comefrom,createdon,realname From vw_EMP_F where empID = '" & sID & "'")
                LoadForms.RestoreLayoutFromXml(GridView1, "vw_EMP_F_def.xml")
            End If
        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub frmEMP_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        If Me.WindowState = FormWindowState.Maximized Then frmMain.XtraTabbedMdiManager1.Dock(Me, frmMain.XtraTabbedMdiManager1)
    End Sub
    Private Sub ManageJOBS()
        Dim form1 As frmGen = New frmGen()
        form1.Text = "Θέσεις Εργασίας"
        form1.L1.Text = "Κωδικός"
        form1.L2.Text = "Θέση"
        form1.DataTable = "JOBS"
        form1.CallerControl = cboJobs
        If cboJobs.EditValue isnot Nothing Then form1.ID = cboJobs.EditValue.ToString
        form1.MdiParent = frmMain
        If cboJobs.EditValue isnot Nothing Then form1.Mode = FormMode.EditRecord Else form1.Mode = FormMode.NewRecord
        frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(form1), New Point(CInt(form1.Parent.ClientRectangle.Width / 2 - form1.Width / 2), CInt(form1.Parent.ClientRectangle.Height / 2 - form1.Height / 2)))
        form1.Show()
    End Sub
    Private Sub ManageAREAS()
        Dim form1 As frmGen = New frmGen()
        form1.Text = "Περιοχές"
        form1.L1.Text = "Κωδικός"
        form1.L2.Text = "Περιοχή"
        form1.L3.Text = "Νομός"
        form1.DataTable = "AREAS"
        form1.L3.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
        form1.CallerControl = cboAREAS
        If cboAREAS.EditValue isnot Nothing Then form1.ID = cboAREAS.EditValue.ToString
        form1.MdiParent = frmMain
        If cboAREAS.EditValue isnot Nothing Then form1.Mode = FormMode.EditRecord Else form1.Mode = FormMode.NewRecord
        frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(form1), New Point(CInt(form1.Parent.ClientRectangle.Width / 2 - form1.Width / 2), CInt(form1.Parent.ClientRectangle.Height / 2 - form1.Height / 2)))
        form1.Show()
    End Sub
    Private Function ADRsSQL() As System.Text.StringBuilder
        Dim sSQL As New System.Text.StringBuilder
        Dim CouID As String = ""
        Dim AreaID As String = ""
        If cboCOU.EditValue isnot Nothing Then CouID = cboCOU.EditValue.ToString
        If cboAREAS.EditValue isnot Nothing Then AreaID = cboAREAS.EditValue.ToString
        sSQL.AppendLine("Select id,Name + ' - ' + isnull(ar,'') as Name from vw_ADR ")
        If CouID.Length > 0 Or AreaID.Length > 0 Or txtTK.Text.Length > 0 Then sSQL.AppendLine(" where ")
        If CouID.Length > 0 Then sSQL.AppendLine(" couid = " & toSQLValueS(CouID))
        If AreaID.Length > 0 Then
            If CouID.Length > 0 Then sSQL.AppendLine(" AND ")
            sSQL.AppendLine(" AreaID = " & toSQLValueS(AreaID))
        End If
        If txtTK.Text.Length > 0 Then
            If CouID.Length > 0 Or AreaID.Length > 0 Then sSQL.AppendLine(" AND ")
            sSQL.AppendLine(" TK = " & toSQLValue(txtTK))
        End If
        sSQL.AppendLine(" order by name ")
        Return sSQL
    End Function

    Private Sub ManageADR()
        Dim form1 As frmGen = New frmGen()
        form1.Text = "Διευθύνσεις"
        form1.L1.Text = "Κωδικός"
        form1.L2.Text = "Διεύθυνση"
        form1.L3.Text = "Νομός"
        form1.L4.Text = "Περιοχές"
        form1.L8.Text = "Αριθμός"
        form1.DataTable = "ADR"
        form1.CalledFromControl = True
        form1.CallerControl = cboADR
        form1.L3.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
        form1.L4.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
        form1.L8.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
        form1.L8.Control.Tag = "Ar,0,1,2"
        If cboADR.EditValue isnot Nothing Then form1.ID = cboADR.EditValue.ToString
        form1.MdiParent = frmMain

        If cboADR.EditValue isnot Nothing Then form1.Mode = FormMode.EditRecord Else form1.Mode = FormMode.NewRecord
        frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(form1), New Point(CInt(form1.Parent.ClientRectangle.Width / 2 - form1.Width / 2), CInt(form1.Parent.ClientRectangle.Height / 2 - form1.Height / 2)))
        form1.Show()

    End Sub
    Private Sub ManageCOU()
        Dim form1 As frmGen = New frmGen()
        form1.Text = "Νομοί"
        form1.L1.Text = "Κωδικός"
        form1.L2.Text = "Νομός"
        form1.DataTable = "COU"
        form1.CallerControl = cboCOU
        form1.CalledFromControl = True
        If cboCOU.EditValue isnot Nothing Then form1.ID = cboCOU.EditValue.ToString
        form1.MdiParent = frmMain
        If cboCOU.EditValue isnot Nothing Then form1.Mode = FormMode.EditRecord Else form1.Mode = FormMode.NewRecord
        frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(form1), New Point(CInt(form1.Parent.ClientRectangle.Width / 2 - form1.Width / 2), CInt(form1.Parent.ClientRectangle.Height / 2 - form1.Height / 2)))
        form1.Show()
    End Sub

    Private Sub ManageDOY()
        Dim form1 As frmGen = New frmGen()
        form1.Text = "ΔΟΥ"
        form1.L1.Text = "Κωδικός"
        form1.L2.Text = "ΔΟΥ"
        form1.DataTable = "DOY"
        form1.CallerControl = cboDOY
        form1.CalledFromControl = True
        If cboDOY.EditValue isnot Nothing Then form1.ID = cboDOY.EditValue.ToString
        form1.MdiParent = frmMain
        If cboDOY.EditValue isnot Nothing Then form1.Mode = FormMode.EditRecord Else form1.Mode = FormMode.NewRecord
        frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(form1), New Point(CInt(form1.Parent.ClientRectangle.Width / 2 - form1.Width / 2), CInt(form1.Parent.ClientRectangle.Height / 2 - form1.Height / 2)))
        form1.Show()
    End Sub

    Private Sub ManagePRF()
        Dim form1 As frmGen = New frmGen()
        form1.Text = "Επαγγέλματα"
        form1.L1.Text = "Κωδικός"
        form1.L2.Text = "Επάγγελμα"
        form1.DataTable = "PRF"
        form1.CallerControl = cboPRF
        form1.CalledFromControl = True
        If cboPRF.EditValue isnot Nothing Then form1.ID = cboPRF.EditValue.ToString
        form1.MdiParent = frmMain
        If cboPRF.EditValue isnot Nothing Then form1.Mode = FormMode.EditRecord Else form1.Mode = FormMode.NewRecord
        frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(form1), New Point(CInt(form1.Parent.ClientRectangle.Width / 2 - form1.Width / 2), CInt(form1.Parent.ClientRectangle.Height / 2 - form1.Height / 2)))
        form1.Show()
    End Sub
    Private Sub ManageDEP()
        Dim form1 As frmGen = New frmGen()
        form1.Text = "Τμήματα"
        form1.L1.Text = "Κωδικός"
        form1.L2.Text = "Τμήμα"
        form1.DataTable = "DEP"
        form1.CalledFromControl = True
        form1.CallerControl = cboDEP
        If cboDEP.EditValue isnot Nothing Then form1.ID = cboDEP.EditValue.ToString
        form1.MdiParent = frmMain
        If cboDEP.EditValue isnot Nothing Then form1.Mode = FormMode.EditRecord Else form1.Mode = FormMode.NewRecord
        frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(form1), New Point(CInt(form1.Parent.ClientRectangle.Width / 2 - form1.Width / 2), CInt(form1.Parent.ClientRectangle.Height / 2 - form1.Height / 2)))
        form1.Show()
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
    Private Sub txtFileNames_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles txtFileNames.ButtonClick
        If e.Button.Index = 0 Then
            FilesSelection()
        Else
            txtFileNames.EditValue = Nothing
        End If
    End Sub
    Private Sub cboCOU_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboCOU.ButtonClick
        Select Case e.Button.Index
            Case 1 : cboCOU.EditValue = Nothing : ManageCOU()
            Case 2 : If cboCOU.EditValue isnot Nothing Then ManageCOU()
            Case 3 : cboCOU.EditValue = Nothing
        End Select
    End Sub
    Private Sub cboDOY_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboDOY.ButtonClick
        Select Case e.Button.Index
            Case 1 : cboDOY.EditValue = Nothing : ManageDOY()
            Case 2 : If cboDOY.EditValue isnot Nothing Then ManageDOY()
            Case 3 : cboDOY.EditValue = Nothing
        End Select
    End Sub
    Private Sub cboPRF_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboPRF.ButtonClick
        Select Case e.Button.Index
            Case 1 : cboPRF.EditValue = Nothing : ManagePRF()
            Case 2 : If cboPRF.EditValue isnot Nothing Then ManagePRF()
            Case 3 : cboPRF.EditValue = Nothing
        End Select
    End Sub

    Private Sub cboAREAS_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboAREAS.ButtonClick
        Select Case e.Button.Index
            Case 1 : cboAREAS.EditValue = Nothing : ManageAREAS()
            Case 2 : If cboAREAS.EditValue isnot Nothing Then ManageAREAS()
            Case 3 : cboAREAS.EditValue = Nothing
        End Select
    End Sub

    Private Sub cboADR_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboADR.ButtonClick
        Select Case e.Button.Index
            Case 1 : cboADR.EditValue = Nothing : ManageADR()
            Case 2 : If cboADR.EditValue isnot Nothing Then ManageADR()
            Case 3 : cboADR.EditValue = Nothing
        End Select
    End Sub

    Private Sub ShellExecute(ByVal File As String)
        Dim myProcess As New Process
        myProcess.StartInfo.FileName = File
        myProcess.StartInfo.UseShellExecute = True
        myProcess.StartInfo.RedirectStandardOutput = False
        myProcess.Start()
        myProcess.Dispose()
    End Sub

    Private Sub frmEMP_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        GridView1.SaveLayoutToXml(Application.StartupPath & "\DSGNS\DEF\vw_EMP_F_def.xml", OptionsLayoutBase.FullLayout)
    End Sub
    Private Sub txtTK_LostFocus(sender As Object, e As EventArgs) Handles txtTK.LostFocus
        FillCbo.ADR(cboADR, ADRsSQL)
    End Sub

    Private Sub GridControl1_DoubleClick(sender As Object, e As EventArgs) Handles GridControl1.DoubleClick
        Try
            Dim sFilename = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "filename")
            Dim fs As IO.FileStream = New IO.FileStream(ProgProps.TempFolderPath & sFilename, IO.FileMode.Create)
            Dim b() As Byte = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "files")
            fs.Write(b, 0, b.Length)
            fs.Close()
            ShellExecute(ProgProps.TempFolderPath & sFilename)
        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cboCOU_EditValueChanged(sender As Object, e As EventArgs) Handles cboCOU.EditValueChanged
        Dim sSQL As New System.Text.StringBuilder
        If cboCOU.EditValue isnot Nothing Then sSQL.AppendLine(" where couid = " & toSQLValueS(cboCOU.EditValue.ToString))
        FillCbo.AREAS(cboAREAS, sSQL)
        FillCbo.ADR(cboADR, ADRsSQL)
    End Sub

    Private Sub cboAREAS_EditValueChanged(sender As Object, e As EventArgs) Handles cboAREAS.EditValueChanged
        FillCbo.ADR(cboADR, ADRsSQL)
    End Sub

    Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click
        Dim sResult As Boolean
        Dim sGuid As String
        Try
            If Valid.ValidateForm(LayoutControl1) Then
                Select Case Mode
                    Case FormMode.NewRecord
                        sGuid = System.Guid.NewGuid.ToString
                        sResult = DBQ.InsertData(LayoutControl1, "EMP", sGuid)
                    Case FormMode.EditRecord
                        sResult = DBQ.UpdateData(LayoutControl1, "EMP", sID)
                        sGuid = sID
                End Select
                'Καθαρισμός Controls
                'If Mode = FormMode.EditRecord Then Cls.ClearCtrls(LayoutControl1)
                'dtDTS.EditValue = DateTime.Now
                If txtFileNames.Text <> "" Then
                    sResult = DBQ.InsertDataFiles(XtraOpenFileDialog1, sGuid, "EMP_F")
                    LoadForms.LoadDataToGrid(GridControl1, GridView1, "select ID,EMPID,files,filename,comefrom,createdon,realname From vw_EMP_F where     EMPID = '" & sGuid & "'")
                    LoadForms.RestoreLayoutFromXml(GridView1, "vw_EMP_F_def.xml")
                End If
                txtCode.Text = DBQ.GetNextId("EMP")
                If CalledFromCtrl Then
                    FillCbo.EMP(CtrlCombo)
                    CtrlCombo.EditValue = System.Guid.Parse(sGuid)
                Else
                    Dim form As frmScroller = Frm
                    form.LoadRecords("vw_EMP")
                End If
                Cls.ClearCtrls(LayoutControl1)
                If sResult = True Then
                    XtraMessageBox.Show("Η εγγραφή αποθηκέυτηκε με επιτυχία", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Mode = FormMode.EditRecord
                    txtFileNames.Text = ""
                End If
            End If

        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub GridView1_KeyDown(sender As Object, e As KeyEventArgs) Handles GridView1.KeyDown
        Select Case e.KeyCode
            'Case Keys.F2 : If UserProps.AllowInsert = True Then NewRecord()
            'Case Keys.F3 : If UserProps.AllowEdit = True Then EditRecord()
            'Case Keys.F5 : LoadRecords()
            Case Keys.Delete : DeleteRecord() 'If UserProps.AllowDelete = True Then DeleteRecord()
        End Select

    End Sub

    Private Sub cboDEP_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboDEP.ButtonClick
        Select Case e.Button.Index
            Case 1 : cboDEP.EditValue = Nothing : ManageDEP()
            Case 2 : If cboDEP.EditValue isnot Nothing Then ManageDEP()
            Case 3 : cboDEP.EditValue = Nothing
        End Select
    End Sub
    Private Sub cmdExit_Click(sender As Object, e As EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub
    'Private Sub cboSER_ButtonClick(sender As Object, e As ButtonPressedEventArgs)
    '    Select Case e.Button.Index
    '        Case 1 : cboSER.EditValue = Nothing : ManageSer()
    '        Case 2 : If cboSER.EditValue isnot Nothing Then ManageSer()
    '        Case 3 : cboSER.EditValue = Nothing
    '    End Select
    'End Sub
    'Private Sub cboSaler_ButtonClick(sender As Object, e As ButtonPressedEventArgs)
    '    Select Case e.Button.Index
    '        Case 1 : cboSaler.EditValue = Nothing : ManageSaler()
    '        Case 2 : If cboSaler.EditValue isnot Nothing Then ManageSaler()
    '        Case 3 : cboSaler.EditValue = Nothing
    '    End Select
    'End Sub
    'Private Sub ManageSer()
    '    Dim form1 As frmServices = New frmServices()
    '    form1.Text = "Συνεργεία"
    '    form1.CallerControl = cboSER
    '    form1.CalledFromControl = True
    '    form1.MdiParent = frmMain
    '    If cboSER.EditValue isnot Nothing Then
    '        form1.ID = cboSER.EditValue.ToString
    '        form1.Mode = FormMode.EditRecord
    '    Else
    '        form1.Mode = FormMode.NewRecord
    '    End If
    '    frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(form1), New Point(CInt(form1.Parent.ClientRectangle.Width / 2 - form1.Width / 2), CInt(form1.Parent.ClientRectangle.Height / 2 - form1.Height / 2)))
    '    form1.Show()

    'End Sub
    'Private Sub ManageSaler()
    '    Dim form1 As frmGen = New frmGen()
    '    form1.Text = "Πωλητές"
    '    form1.L1.Text = "Κωδικός"
    '    form1.L2.Text = "Πωλητής"
    '    form1.L6.Text = "Χρώμα"
    '    form1.DataTable = "SALERS"
    '    form1.CalledFromControl = True
    '    form1.CallerControl = cboSaler
    '    If cboSaler.EditValue isnot Nothing Then form1.ID = cboSaler.EditValue.ToString
    '    form1.MdiParent = frmMain
    '    form1.L6.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
    '    If cboSaler.EditValue isnot Nothing Then form1.Mode = FormMode.EditRecord Else form1.Mode = FormMode.NewRecord
    '    frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(form1), New Point(CInt(form1.Parent.ClientRectangle.Width / 2 - form1.Width / 2), CInt(form1.Parent.ClientRectangle.Height / 2 - form1.Height / 2)))
    '    form1.Show()
    'End Sub

    Private Sub cboJobs_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboJobs.ButtonClick
        Select Case e.Button.Index
            Case 1 : cboJobs.EditValue = Nothing : ManageJOBS()
            Case 2 : If cboJobs.EditValue isnot Nothing Then ManageJOBS()
            Case 3 : cboJobs.EditValue = Nothing
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
        GridView1.SaveLayoutToXml(Application.StartupPath & "\DSGNS\DEF\vw_EMP_F_def.xml", OptionsLayoutBase.FullLayout)
        XtraMessageBox.Show("Η όψη αποθηκεύτηκε με επιτυχία", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Information)
        ' Μόνο αν ο Χρήστης είναι ο Παναγόπουλος
        If UserProps.ID.ToString.ToUpper = "3F9DC32E-BE5B-4D46-A13C-EA606566CF32" Or UserProps.ID.ToString.ToUpper = "E9CEFD11-47C0-4796-A46B-BC41C4C3606B" Then 
            If XtraMessageBox.Show("Θέλετε να γίνει κοινοποίηση της όψης? Εαν επιλέξετε 'Yes' όλοι οι χρήστες θα έχουν την ίδια όψη", ProgProps.ProgTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                If My.Computer.FileSystem.FileExists(ProgProps.ServerViewsPath & "DSGNS\DEF\vw_EMP_F_def.xml") = False Then GridView1.OptionsLayout.LayoutVersion = "v1"
                GridView1.SaveLayoutToXml(ProgProps.ServerViewsPath & "DSGNS\DEF\vw_EMP_F_def.xml", OptionsLayoutBase.FullLayout)
            End If
        End If

    End Sub
    'Συγχρονισμός όψης από Server
    Private Sub OnSyncView(ByVal sender As System.Object, ByVal e As EventArgs)
        If XtraMessageBox.Show("Θέλετε να γίνει μεταφορά της όψης από τον server?", ProgProps.ProgTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            ' Έλεγχος αν υπάρχει όψη με μεταγενέστερη ημερομηνία στον Server
            If System.IO.File.Exists(ProgProps.ServerViewsPath & "DSGNS\DEF\vw_EMP_F_def.xml") = True Then
                My.Computer.FileSystem.CopyFile(ProgProps.ServerViewsPath & "DSGNS\DEF\vw_EMP_F_def.xml", Application.StartupPath & "\DSGNS\DEF\vw_EMP_F_def.xml", True)
                GridView1.RestoreLayoutFromXml(Application.StartupPath & "\DSGNS\DEF\vw_EMP_F_def.xml", OptionsLayoutBase.FullLayout)
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