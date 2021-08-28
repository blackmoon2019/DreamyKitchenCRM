Imports System.CodeDom.Compiler
Imports System.Data.SqlClient
Imports System.IO
Imports DevExpress.Utils
Imports DevExpress.XtraBars.Navigation
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraExport.Xls
Imports DevExpress.XtraGrid.Columns

Public Class frmCustomers
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


    Private Sub frmCustomers_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim sSQL As New System.Text.StringBuilder
        'Νομοί
        FillCbo.COU(cboCOU)
        'FillCbo.ADR(cboADR, sSQL)
        'FillCbo.AREAS(cboAREAS, sSQL)
        FillCbo.SRC(cboSRC)
        FillCbo.SALERS(cboSaler)
        FillCbo.PRF(cboPRF)
        FillCbo.DOY(cboDOY)


        Select Case Mode
            Case FormMode.NewRecord
                'dtDTS.EditValue = DateTime.Now
                txtCode.Text = DBQ.GetNextId("CCT")
            Case FormMode.EditRecord
                If cboCOU.EditValue <> Nothing Then sSQL.AppendLine(" where couid = " & toSQLValueS(cboCOU.EditValue.ToString))
                FillCbo.AREAS(cboAREAS, sSQL)
                LoadForms.LoadForm(LayoutControl1, "Select * from vw_CCT where id ='" + sID + "'")
                LoadForms.LoadDataToGrid(GridControl1, GridView1, "select ID,cctID,files,filename,comefrom,createdon,realname From vw_CCT_F where cctID = '" & sID & "'")
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
        If My.Computer.FileSystem.FileExists(Application.StartupPath & "\DSGNS\DEF\vw_CCT_F_def.xml") = False Then
            GridView1.SaveLayoutToXml(Application.StartupPath & "\DSGNS\DEF\vw_CCT_F_def.xml", OptionsLayoutBase.FullLayout)
        End If
        'GridView1.RestoreLayoutFromXml(Application.StartupPath & "\DSGNS\DEF\vw_CCT_F_def.xml", OptionsLayoutBase.FullLayout)
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
                sSQL = "DELETE FROM CCT_F WHERE ID = '" & GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "ID").ToString & "'"

                Using oCmd As New SqlCommand(sSQL, CNDB)
                    oCmd.ExecuteNonQuery()
                End Using
                XtraMessageBox.Show("Η εγγραφή διαγράφηκε με επιτυχία", "Dreamy Kitchen CRM", MessageBoxButtons.OK, MessageBoxIcon.Information)
                LoadForms.LoadDataToGrid(GridControl1, GridView1, "select ID,cctID,filename,comefrom,createdon,realname From vw_CCT_F where cctID = '" & sID & "'")
            End If
        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), "Dreamy Kitchen CRM", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub frmCustomers_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        If Me.WindowState = FormWindowState.Maximized Then frmMain.XtraTabbedMdiManager1.Dock(Me, frmMain.XtraTabbedMdiManager1)
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
        If cboAREAS.EditValue <> Nothing Then form1.ID = cboAREAS.EditValue.ToString
        form1.MdiParent = frmMain
        If cboAREAS.EditValue <> Nothing Then form1.Mode = FormMode.EditRecord Else form1.Mode = FormMode.NewRecord
        frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(form1), New Point(CInt(form1.Parent.ClientRectangle.Width / 2 - form1.Width / 2), CInt(form1.Parent.ClientRectangle.Height / 2 - form1.Height / 2)))
        form1.Show()
    End Sub
    Private Function ADRsSQL() As System.Text.StringBuilder
        Dim sSQL As New System.Text.StringBuilder
        Dim CouID As String = ""
        Dim AreaID As String = ""
        If cboCOU.EditValue <> Nothing Then CouID = cboCOU.EditValue.ToString
        If cboAREAS.EditValue <> Nothing Then AreaID = cboAREAS.EditValue.ToString
        sSQL.AppendLine("Select id,Name from vw_ADR ")
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
        form1.DataTable = "ADR"
        form1.CallerControl = cboADR
        form1.L3.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
        form1.L4.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
        If cboADR.EditValue <> Nothing Then form1.ID = cboADR.EditValue.ToString
        form1.MdiParent = frmMain

        If cboADR.EditValue <> Nothing Then form1.Mode = FormMode.EditRecord Else form1.Mode = FormMode.NewRecord
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
        If cboCOU.EditValue <> Nothing Then form1.ID = cboCOU.EditValue.ToString
        form1.MdiParent = frmMain
        If cboCOU.EditValue <> Nothing Then form1.Mode = FormMode.EditRecord Else form1.Mode = FormMode.NewRecord
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
        If cboDOY.EditValue <> Nothing Then form1.ID = cboDOY.EditValue.ToString
        form1.MdiParent = frmMain
        If cboDOY.EditValue <> Nothing Then form1.Mode = FormMode.EditRecord Else form1.Mode = FormMode.NewRecord
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
        If cboPRF.EditValue <> Nothing Then form1.ID = cboPRF.EditValue.ToString
        form1.MdiParent = frmMain
        If cboPRF.EditValue <> Nothing Then form1.Mode = FormMode.EditRecord Else form1.Mode = FormMode.NewRecord
        frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(form1), New Point(CInt(form1.Parent.ClientRectangle.Width / 2 - form1.Width / 2), CInt(form1.Parent.ClientRectangle.Height / 2 - form1.Height / 2)))
        form1.Show()
    End Sub
    Private Sub ManageSaler()
        Dim form1 As frmGen = New frmGen()
        form1.Text = "Πωλητές"
        form1.L1.Text = "Κωδικός"
        form1.L2.Text = "Πωλητής"
        form1.L6.Text = "Χρώμα"
        form1.DataTable = "SALERS"
        form1.CalledFromControl = True
        form1.CallerControl = cboSaler
        If cboSaler.EditValue <> Nothing Then form1.ID = cboSaler.EditValue.ToString
        form1.MdiParent = frmMain
        form1.L6.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
        If cboSaler.EditValue <> Nothing Then form1.Mode = FormMode.EditRecord Else form1.Mode = FormMode.NewRecord
        frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(form1), New Point(CInt(form1.Parent.ClientRectangle.Width / 2 - form1.Width / 2), CInt(form1.Parent.ClientRectangle.Height / 2 - form1.Height / 2)))
        form1.Show()
    End Sub
    Private Sub ManageSRC()
        Dim form1 As frmGen = New frmGen()
        form1.Text = "Πηγές"
        form1.L1.Text = "Κωδικός"
        form1.L2.Text = "Πηγή"
        form1.DataTable = "SRC"
        form1.CalledFromControl = True
        form1.CallerControl = cboSRC
        If cboSRC.EditValue <> Nothing Then form1.ID = cboSRC.EditValue.ToString
        form1.MdiParent = frmMain
        If cboSRC.EditValue <> Nothing Then form1.Mode = FormMode.EditRecord Else form1.Mode = FormMode.NewRecord
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
            Case 2 : If cboCOU.EditValue <> Nothing Then ManageCOU()
            Case 3 : cboCOU.EditValue = Nothing
        End Select
    End Sub
    Private Sub cboDOY_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboDOY.ButtonClick
        Select Case e.Button.Index
            Case 1 : cboDOY.EditValue = Nothing : ManageDOY()
            Case 2 : If cboDOY.EditValue <> Nothing Then ManageDOY()
            Case 3 : cboDOY.EditValue = Nothing
        End Select
    End Sub
    Private Sub cboPRF_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboPRF.ButtonClick
        Select Case e.Button.Index
            Case 1 : cboPRF.EditValue = Nothing : ManagePRF()
            Case 2 : If cboPRF.EditValue <> Nothing Then ManagePRF()
            Case 3 : cboPRF.EditValue = Nothing
        End Select
    End Sub

    Private Sub cboAREAS_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboAREAS.ButtonClick
        Select Case e.Button.Index
            Case 1 : cboAREAS.EditValue = Nothing : ManageAREAS()
            Case 2 : If cboAREAS.EditValue <> Nothing Then ManageAREAS()
            Case 3 : cboAREAS.EditValue = Nothing
        End Select
    End Sub

    Private Sub cboADR_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboADR.ButtonClick
        Select Case e.Button.Index
            Case 1 : cboADR.EditValue = Nothing : ManageADR()
            Case 2 : If cboADR.EditValue <> Nothing Then ManageADR()
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

    Private Sub frmCustomers_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        GridView1.SaveLayoutToXml(Application.StartupPath & "\DSGNS\DEF\vw_CCT_F_def.xml", OptionsLayoutBase.FullLayout)
    End Sub

    Private Sub txtTK_LostFocus(sender As Object, e As EventArgs) Handles txtTK.LostFocus
        FillCbo.ADR(cboADR, ADRsSQL)
    End Sub

    Private Sub GridControl1_DoubleClick(sender As Object, e As EventArgs) Handles GridControl1.DoubleClick
        Try
            Dim sFilename = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "filename")
            Dim fs As IO.FileStream = New IO.FileStream(Application.StartupPath & "\" & sFilename, IO.FileMode.Create)
            Dim b() As Byte = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "files")
            fs.Write(b, 0, b.Length)
            fs.Close()
            My.Computer.FileSystem.MoveFile(Application.StartupPath & "\" & sFilename, My.Settings.CRM_PATH & sFilename, True)
            ShellExecute(My.Settings.CRM_PATH & sFilename)
        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), "Dreamy Kitchen CRM", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cboCOU_EditValueChanged(sender As Object, e As EventArgs) Handles cboCOU.EditValueChanged
        Dim sSQL As New System.Text.StringBuilder
        If cboCOU.EditValue <> Nothing Then sSQL.AppendLine(" where couid = " & toSQLValueS(cboCOU.EditValue.ToString))
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
                        sResult = DBQ.InsertData(LayoutControl1, "CCT", sGuid)
                    Case FormMode.EditRecord
                        sResult = DBQ.UpdateData(LayoutControl1, "CCT", sID)
                        sGuid = sID
                End Select
                'Καθαρισμός Controls
                'If Mode = FormMode.EditRecord Then Cls.ClearCtrls(LayoutControl1)
                'dtDTS.EditValue = DateTime.Now
                If txtFileNames.Text <> "" Then
                    sResult = DBQ.InsertDataFiles(XtraOpenFileDialog1, sGuid, "CCT_F")
                    LoadForms.LoadDataToGrid(GridControl1, GridView1, "select ID,cctID,files,filename,comefrom,createdon,realname From vw_CCT_F where isINVOICE = 0 AND cctID = '" & sGuid & "'")
                End If
                txtCode.Text = DBQ.GetNextId("CCT")
                If CalledFromCtrl Then
                    FillCbo.CUS(CtrlCombo)
                    CtrlCombo.EditValue = System.Guid.Parse(sGuid)
                Else
                    Dim form As frmScroller = Frm
                    form.LoadRecords("vw_CCT")
                End If
                'Cls.ClearCtrls(LayoutControl1)
                If sResult = True Then
                    XtraMessageBox.Show("Η εγγραφή αποθηκέυτηκε με επιτυχία", "Dreamy Kitchen CRM", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Mode = FormMode.EditRecord
                    txtFileNames.Text = ""
                    If XtraMessageBox.Show("Θέλετε να καταχωρήσετε κίνηση στον πελάτη?", "Dreamy Kitchen CRM", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                        Dim form1 As frmCusMov = New frmCusMov()
                        form1.Text = "Κινήσεις Πελατών"
                        form1.MdiParent = frmMain
                        form1.Mode = FormMode.NewRecord
                        form1.FormScrollerExist = False
                        form1.CusID = sGuid
                        'form1.Scroller = GridView1
                        'form1.FormScroller = Me
                        frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(form1), New Point(CInt(form1.Parent.ClientRectangle.Width / 2 - form1.Width / 2), CInt(form1.Parent.ClientRectangle.Height / 2 - form1.Height / 2)))
                        form1.Show()
                    End If
                End If
            End If

        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), "Dreamy Kitchen CRM", MessageBoxButtons.OK, MessageBoxIcon.Error)
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

    Private Sub cboSaler_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboSaler.ButtonClick
        Select Case e.Button.Index
            Case 1 : cboSaler.EditValue = Nothing : ManageSaler()
            Case 2 : If cboSaler.EditValue <> Nothing Then ManageSaler()
            Case 3 : cboSaler.EditValue = Nothing
        End Select
    End Sub

    Private Sub cboSRC_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboSRC.ButtonClick
        Select Case e.Button.Index
            Case 1 : cboSRC.EditValue = Nothing : ManageSRC()
            Case 2 : If cboSRC.EditValue <> Nothing Then ManageSRC()
            Case 3 : cboSRC.EditValue = Nothing
        End Select
    End Sub

    Private Sub cmdExit_Click(sender As Object, e As EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub






    'Private Sub SqlBlob2File(ByVal DocName As String)

    '    Dim cn As New SqlConnection(My.Settings.DocStoreConnectionString.ToString())
    '    Dim cmd As New SqlCommand("Select DocData From Documents WHERE DocName = @DocName", cn)

    '    cmd.Parameters.AddWithValue("@DocName", DocName)

    '    cn.Open()

    '    Using dr As SqlDataReader = cmd.ExecuteReader(CommandBehavior.CloseConnection)
    '        If dr.Read() Then
    '            Dim fs As IO.FileStream = New IO.FileStream(IO.Path.Combine(Me.FolderBrowserDial og1.SelectedPath, DocName), IO.FileMode.Create)
    '            Dim b() As Byte = dr.Item("DocData")
    '            fs.Write(b, 0, b.Length)
    '            fs.Close()
    '        End If
    '    End Using 'dr

    '    cn.Close()
    'End Sub
End Class
