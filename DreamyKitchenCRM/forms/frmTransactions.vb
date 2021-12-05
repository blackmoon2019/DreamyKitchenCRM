Imports System.ComponentModel
Imports System.Data.SqlClient
Imports DevExpress.Utils
Imports DevExpress.Utils.Menu
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Menu
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid

Public Class frmTransactions
    Private sID As String
    Private sEMP_T_ID As String
    Private Ctrl As DevExpress.XtraGrid.Views.Grid.GridView
    Private Frm As DevExpress.XtraEditors.XtraForm
    Public Mode As Byte
    Private ScanFile As ScanToPDF
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
    Private Sub cmdExit_Click(sender As Object, e As EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub
    Private Sub ShellExecute(ByVal File As String)
        Dim myProcess As New Process
        myProcess.StartInfo.FileName = File
        myProcess.StartInfo.UseShellExecute = True
        myProcess.StartInfo.RedirectStandardOutput = False
        myProcess.Start()
        myProcess.Dispose()
    End Sub

    Private Sub frmTransactions_Load(sender As Object, e As EventArgs) Handles Me.Load
        'TODO: This line of code loads data into the 'DreamyKitchenDataSet.vw_SCAN_FILE_NAMES' table. You can move, or remove it, as needed.
        Me.Vw_SCAN_FILE_NAMESTableAdapter.Fill(Me.DreamyKitchenDataSet.vw_SCAN_FILE_NAMES)
        'TODO: This line of code loads data into the 'DreamyKitchenDataSet.vw_INVTYPES' table. You can move, or remove it, as needed.
        Me.Vw_INVTYPESTableAdapter.Fill(Me.DreamyKitchenDataSet.vw_INVTYPES)
        'TODO: This line of code loads data into the 'DreamyKitchenDataSet.vw_BANKS' table. You can move, or remove it, as needed.
        Me.Vw_BANKSTableAdapter.Fill(Me.DreamyKitchenDataSet.vw_BANKS)
        Dim sSQL As New System.Text.StringBuilder
        'Τράπεζες
        FillCbo.BANKS(cboBANK)
        'Πελάτες
        FillCbo.CUS(cboCUS)
        'Πωλητές
        FillCbo.SALERS(cboSaler)

        Select Case Mode
            Case FormMode.NewRecord
                dtCharge.EditValue = DateTime.Now
                dtPay.EditValue = DateTime.Now
                txtCode.Text = DBQ.GetNextId("TRANSH")
                LayoutControlGroup2.Enabled = False
            Case FormMode.EditRecord
                LoadForms.LoadFormGRP(LayoutControlGroup1, "Select * from vw_TRANSH where id ='" + sID + "'")
                Me.Vw_CCT_FTableAdapter.Fill(Me.DreamyKitchenDataSet.vw_CCT_F, System.Guid.Parse(cboCUS.EditValue.ToString))
                Me.Vw_TRANSDTableAdapter.Fill(Me.DreamyKitchenDataSet.vw_TRANSD, System.Guid.Parse(sID))
                txtCode1.Text = DBQ.GetNextId("TRANSD")
                dtPay.EditValue = DateTime.Now
        End Select
        'Εαν δεν υπάρχει Default Σχέδιο δημιουργεί
        If My.Computer.FileSystem.FileExists(Application.StartupPath & "\DSGNS\DEF\vw_TRANSH_F_def.xml") = False Then
            GridView2.SaveLayoutToXml(Application.StartupPath & "\DSGNS\DEF\vw_TRANSH_F_def.xml", OptionsLayoutBase.FullLayout)
        End If
        GridView2.RestoreLayoutFromXml(Application.StartupPath & "\DSGNS\DEF\vw_TRANSH_F_def.xml", OptionsLayoutBase.FullLayout)
        If My.Computer.FileSystem.FileExists(Application.StartupPath & "\DSGNS\DEF\TRANSD.xml") Then GridView1.RestoreLayoutFromXml(Application.StartupPath & "\DSGNS\DEF\TRANSD.xml", OptionsLayoutBase.FullLayout)
        Me.CenterToScreen()
        My.Settings.frmTransactions = Me.Location
        My.Settings.Save()
        cmdSaveTransH.Enabled = IIf(Mode = FormMode.NewRecord, UserProps.AllowInsert, UserProps.AllowEdit)
        cmdSaveTransD.Enabled = IIf(Mode = FormMode.NewRecord, UserProps.AllowInsert, UserProps.AllowEdit)
    End Sub

    Private Sub cmdSaveTransH_Click(sender As Object, e As EventArgs) Handles cmdSaveTransH.Click
        Dim sResult As Boolean, sResultF As Boolean
        Dim sGuid As String
        Dim sSQL As New System.Text.StringBuilder

        Try
            If Valid.ValidateFormGRP(LayoutControlGroup1) Then
                'If cboCUS.GetColumnValue("SalerID").ToString() = "00000000-0000-0000-0000-000000000000" Then
                '    XtraMessageBox.Show("Παρακαλώ ορίστε πωλητή", "Dreamy Kitchen CRM", MessageBoxButtons.OK, MessageBoxIcon.Error)
                '    Exit Sub
                'End If
                ' Καταχώριση/Ενημέρωση Ποσοστά-Τζίρους Έκθεσης
                Select Case Mode
                    Case FormMode.NewRecord
                        sGuid = System.Guid.NewGuid.ToString
                        sResult = DBQ.InsertNewData(DBQueries.InsertMode.GroupLayoutControl, "TRANSH",,, LayoutControlGroup1, sGuid,, "bal", toSQLValueS(txtBal.EditValue.ToString, True))
                        sID = sGuid
                        sSQL.Clear()
                        sEMP_T_ID = System.Guid.NewGuid.ToString
                        sSQL.AppendLine("INSERT INTO EMP_T (ID,CUSID,EMPID,SALEPRICE,CREATEDBY,CREATEDON,TRANSHID,dtPay)")
                        sSQL.AppendLine("Select " & toSQLValueS(sEMP_T_ID.ToString) & ",")
                        sSQL.AppendLine(toSQLValueS(cboCUS.EditValue.ToString) & ",")
                        sSQL.AppendLine(toSQLValueS(cboSaler.EditValue.ToString) & ",")
                        sSQL.AppendLine(toSQLValueS(txtTotAmt.EditValue, True) & ",")
                        sSQL.AppendLine(toSQLValueS(UserProps.ID.ToString) & ",")
                        sSQL.AppendLine("getdate(),")
                        sSQL.AppendLine(toSQLValueS(sID) & ",")
                        sSQL.AppendLine(toSQLValueS(CDate(dtPay.Text).ToString("yyyyMMdd")))
                        'Εκτέλεση QUERY
                        Using oCmd As New SqlCommand(sSQL.ToString, CNDB)
                            oCmd.ExecuteNonQuery()
                        End Using
                    Case FormMode.EditRecord
                        sResult = DBQ.UpdateNewData(DBQueries.InsertMode.GroupLayoutControl, "TRANSH",,, LayoutControlGroup1, sID,,,,, "bal=" & toSQLValueS(txtBal.EditValue.ToString, True))
                        sGuid = sID
                        sSQL.Clear()
                        sSQL.AppendLine("UPDATE EMP_T SET CUSID = " & toSQLValueS(cboCUS.EditValue.ToString) & ",")
                        sSQL.AppendLine("EMPID = " & toSQLValueS(cboSaler.EditValue.ToString) & ",")
                        sSQL.AppendLine("SALEPRICE = " & toSQLValueS(txtTotAmt.EditValue, True) & ",")
                        sSQL.AppendLine("MODIFIEDBY= " & toSQLValueS(UserProps.ID.ToString) & ",")
                        sSQL.AppendLine("MODIFIEDON= GETDATE(), ")
                        sSQL.AppendLine("DTPAY = " & toSQLValueS(CDate(dtPay.Text).ToString("yyyyMMdd")))


                        sSQL.AppendLine("WHERE TRANSHID = " & toSQLValueS(sID))
                        'Εκτέλεση QUERY
                        Using oCmd As New SqlCommand(sSQL.ToString, CNDB)
                            oCmd.ExecuteNonQuery()
                        End Using
                End Select
                'Καθαρισμός Controls
                'If Mode = FormMode.EditRecord Then Cls.ClearCtrls(LayoutControl1)
                'dtDTS.EditValue = DateTime.Now
                If txtInvoiceFilename.Text <> "" Then
                    sResultF = DBQ.InsertDataFiles(XtraOpenFileDialog1, cboCUS.EditValue.ToString, "TRANSH")
                    Me.Vw_CCT_FTableAdapter.Fill(Me.DreamyKitchenDataSet.vw_CCT_F, System.Guid.Parse(cboCUS.EditValue.ToString))
                    'LoadForms.LoadDataToGrid(GridControl2, GridView2, "select ID,cctID,files,filename,comefrom,createdon,realname From vw_CCT_F where ISINVOICE = 1 AND cctID = " & toSQLValueS(cboCUS.EditValue.ToString))
                End If
                txtCode.Text = DBQ.GetNextId("TRANSH")
                txtCode1.Text = DBQ.GetNextId("TRANSD")
                'If CalledFromCtrl Then
                '    FillCbo.CUS(CtrlCombo)
                '    CtrlCombo.EditValue = System.Guid.Parse(sGuid)
                'Else
                If CalledFromCtrl = False Then
                    Dim form As frmScroller = Frm
                    form.DataTable = "vw_TRANSH"
                    form.LoadRecords("vw_TRANSD")
                Else
                    FillCbo.TRANSH(CtrlCombo)
                    CtrlCombo.EditValue = System.Guid.Parse(sGuid)

                End If
                'Cls.ClearCtrls(LayoutControl1)
                If sResult = True Then
                    XtraMessageBox.Show("Η εγγραφή αποθηκέυτηκε με επιτυχία", "Dreamy Kitchen CRM", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    LayoutControlGroup2.Enabled = True
                    Mode = FormMode.EditRecord
                    txtInvoiceFilename.Text = ""
                End If
                If txtInvoiceFilename.Text <> "" Then
                    If sResultF = False Then XtraMessageBox.Show("To Παραστατικό δεν αποθηκέυτηκε.", "Dreamy Kitchen CRM", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), "Dreamy Kitchen CRM", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub frmTransactions_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        If Me.WindowState = FormWindowState.Maximized Then frmMain.XtraTabbedMdiManager1.Dock(Me, frmMain.XtraTabbedMdiManager1)
    End Sub

    Private Sub txtInvoiceFilename_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles txtInvoiceFilename.ButtonClick
        Dim sFilename As String
        Select Case e.Button.Index
            Case 0
                Dim result = XtraInputBox.Show("Πληκτρολογήστε το πλήθος σελίδων που θα σκανάρετε", "Όνομα Αρχείου", "1")

                ScanFile = New ScanToPDF
                If ScanFile.Scan(sFilename, Me.VwSCANFILENAMESBindingSource, result) = False Then Exit Sub
                txtInvoiceFilename.EditValue = sFilename
                If txtInvoiceFilename.Text <> "" Then
                    DBQ.InsertDataFilesFromScanner(sFilename, cboCUS.EditValue.ToString, "TRANSH")
                    Me.Vw_CCT_FTableAdapter.Fill(Me.DreamyKitchenDataSet.vw_CCT_F, System.Guid.Parse(cboCUS.EditValue.ToString))
                End If
                ScanFile = Nothing

            Case 1 : FileSelect()
            Case 2 : txtInvoiceFilename.EditValue = Nothing
        End Select
    End Sub

    Private Sub FileSelect()

        'XtraOpenFileDialog1.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*"
        XtraOpenFileDialog1.FilterIndex = 1
        XtraOpenFileDialog1.InitialDirectory = "C:\"
        XtraOpenFileDialog1.Title = "Open File"
        XtraOpenFileDialog1.CheckFileExists = False
        XtraOpenFileDialog1.Multiselect = True
        Dim result As DialogResult = XtraOpenFileDialog1.ShowDialog()
        If result = DialogResult.OK Then
            txtInvoiceFilename.EditValue = ""
            For I = 0 To XtraOpenFileDialog1.FileNames.Count - 1
                txtInvoiceFilename.EditValue = txtInvoiceFilename.EditValue & IIf(txtInvoiceFilename.EditValue <> "", ";", "") & XtraOpenFileDialog1.SafeFileNames(I)
            Next I


        End If
    End Sub
    Private Sub GridView2_KeyDown(sender As Object, e As KeyEventArgs) Handles GridView2.KeyDown
        Select Case e.KeyCode
            'Case Keys.F2 : If UserProps.AllowInsert = True Then NewRecord()
            'Case Keys.F3 : If UserProps.AllowEdit = True Then EditRecord()
            'Case Keys.F5 : LoadRecords()
            Case Keys.Delete : DeleteRecord("CCT_F") 'If UserProps.AllowDelete = True Then DeleteRecord()
        End Select
    End Sub
    Private Sub DeleteRecord(ByVal sTable As String)
        Dim sSQL As String
        Try
            If sTable = "CCT_F" Then
                If GridView2.GetRowCellValue(GridView2.FocusedRowHandle, "ID") = Nothing Then Exit Sub
                If XtraMessageBox.Show("Θέλετε να διαγραφεί η τρέχουσα εγγραφή?", "Dreamy Kitchen CRM", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                    sSQL = "DELETE FROM CCT_F WHERE ID = '" & GridView2.GetRowCellValue(GridView2.FocusedRowHandle, "ID").ToString & "'"

                    Using oCmd As New SqlCommand(sSQL, CNDB)
                        oCmd.ExecuteNonQuery()
                    End Using
                    XtraMessageBox.Show("Η εγγραφή διαγράφηκε με επιτυχία", "Dreamy Kitchen CRM", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.Vw_CCT_FTableAdapter.Fill(Me.DreamyKitchenDataSet.vw_CCT_F, System.Guid.Parse(cboCUS.EditValue.ToString))
                End If
                'LoadForms.LoadDataToGrid(GridControl2, GridView2, "select ID,cctID,filename,comefrom,createdon,realname From vw_CCT_F where isinvoice=1 and cctID = '" & sID & "'")
            Else
                If GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "ID") = Nothing Then Exit Sub
                If XtraMessageBox.Show("Θέλετε να διαγραφεί η τρέχουσα εγγραφή?", "Dreamy Kitchen CRM", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                    sSQL = "DELETE FROM TRANSD WHERE ID = '" & GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "ID").ToString & "'"

                    Using oCmd As New SqlCommand(sSQL, CNDB)
                        oCmd.ExecuteNonQuery()
                    End Using
                    XtraMessageBox.Show("Η εγγραφή διαγράφηκε με επιτυχία", "Dreamy Kitchen CRM", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.Vw_TRANSDTableAdapter.Fill(Me.DreamyKitchenDataSet.vw_TRANSD, System.Guid.Parse(sID))
                End If
            End If
        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), "Dreamy Kitchen CRM", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub GridControl2_DoubleClick(sender As Object, e As EventArgs) Handles GridControl2.DoubleClick
        Try
            Dim sFilename = GridView2.GetRowCellValue(GridView2.FocusedRowHandle, "filename")
            Dim fs As IO.FileStream = New IO.FileStream(Application.StartupPath & "\" & sFilename, IO.FileMode.Create)
            Dim b() As Byte = GridView2.GetRowCellValue(GridView2.FocusedRowHandle, "files")
            fs.Write(b, 0, b.Length)
            fs.Close()
            My.Computer.FileSystem.MoveFile(Application.StartupPath & "\" & sFilename, My.Settings.CRM_PATH & sFilename, True)
            ShellExecute(My.Settings.CRM_PATH & sFilename)
        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), "Dreamy Kitchen CRM", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub cboCUS_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboCUS.ButtonClick
        Select Case e.Button.Index
            Case 1 : cboCUS.EditValue = Nothing : ManageCus()
            Case 2 : If cboCUS.EditValue <> Nothing Then ManageCus()
            Case 3 : cboCUS.EditValue = Nothing
        End Select
    End Sub
    Private Sub ManageCus()
        Dim form1 As frmCustomers = New frmCustomers()
        form1.Text = "Πελάτες"
        form1.CallerControl = cboCUS
        form1.CalledFromControl = True
        form1.MdiParent = frmMain
        If cboCUS.EditValue <> Nothing Then
            form1.ID = cboCUS.EditValue.ToString
            form1.Mode = FormMode.EditRecord
        Else
            form1.Mode = FormMode.NewRecord
        End If
        frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(form1), New Point(CInt(form1.Parent.ClientRectangle.Width / 2 - form1.Width / 2), CInt(form1.Parent.ClientRectangle.Height / 2 - form1.Height / 2)))
        form1.Show()
    End Sub
    Private Sub ManageBank()
        Dim form1 As frmGen = New frmGen()
        form1.Text = "Τράπεζες"
        form1.L1.Text = "Κωδικός"
        form1.L2.Text = "Τράπεζα"
        form1.DataTable = "BANKS"
        form1.CalledFromControl = True
        form1.CallerControl = cboBANK
        If cboBANK.EditValue <> Nothing Then form1.ID = cboBANK.EditValue.ToString
        form1.MdiParent = frmMain
        If cboBANK.EditValue <> Nothing Then form1.Mode = FormMode.EditRecord Else form1.Mode = FormMode.NewRecord
        frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(form1), New Point(CInt(form1.Parent.ClientRectangle.Width / 2 - form1.Width / 2), CInt(form1.Parent.ClientRectangle.Height / 2 - form1.Height / 2)))
        form1.Show()
    End Sub

    Private Sub cboBANK_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboBANK.ButtonClick
        Select Case e.Button.Index
            Case 1 : cboBANK.EditValue = Nothing : ManageBank()
            Case 2 : If cboBANK.EditValue <> Nothing Then ManageBank()
            Case 3 : cboBANK.EditValue = Nothing
        End Select
    End Sub

    Private Sub cboBANK_EditValueChanged(sender As Object, e As EventArgs) Handles cboBANK.EditValueChanged
        If cboBANK.EditValue IsNot Nothing Then chkCash.Enabled = False : chkCash.Checked = False Else chkCash.Enabled = True
    End Sub

    Private Sub cmdSaveTransD_Click(sender As Object, e As EventArgs) Handles cmdSaveTransD.Click
        Dim sResult As Boolean
        Dim sGuid As String, sSQL As String
        Try
            If Valid.ValidateFormGRP(LayoutControlGroup2) Then
                sGuid = System.Guid.NewGuid.ToString
                sResult = DBQ.InsertNewData(DBQueries.InsertMode.GroupLayoutControl, "TRANSD",,, LayoutControlGroup2, sGuid,, "transhID", toSQLValueS(sID))
                If sResult = True Then
                    XtraMessageBox.Show("Η εγγραφή αποθηκέυτηκε με επιτυχία", "Dreamy Kitchen CRM", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.Vw_TRANSDTableAdapter.Fill(Me.DreamyKitchenDataSet.vw_TRANSD, System.Guid.Parse(sID))
                    'Καθαρισμός Controls
                    Cls.ClearCtrlsGRP(LayoutControlGroup2)
                    dtPay.EditValue = DateTime.Now
                    txtCode1.Text = DBQ.GetNextId("TRANSD")
                End If
            End If
        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), "Dreamy Kitchen CRM", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub GridView1CellValueChanged(sender As Object, e As CellValueChangedEventArgs) Handles GridView1.CellValueChanged
        Dim cash As Byte, cmt As String
        Try
            Dim sSQL As String
            If Not IsDBNull(GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "cash")) Then
                If GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "cash") = True Then cash = 1 Else cash = 0
            End If
            If Not IsDBNull(GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "cmt")) Then
                cmt = toSQLValueS(GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "cmt"))
            Else
                cmt = "NULL"
            End If
            sSQL = "UPDATE [TRANSD] SET dtPay  = " & toSQLValueS(CDate(GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "dtPay")).ToString("yyyyMMdd")) &
                ",bankID = " & toSQLValueS(GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "bankID").ToString) &
                ",cash = " & cash &
                ",cmt = " & cmt &
                ",amt = " & toSQLValueS(GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "amt"), True) &
        " WHERE ID = " & toSQLValueS(GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "ID").ToString)
            Using oCmd As New SqlCommand(sSQL, CNDB)
                oCmd.ExecuteNonQuery()
            End Using
        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), "Dreamy Kitchen CRM", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
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
        GridView1.SaveLayoutToXml(Application.StartupPath & "\DSGNS\DEF\TRANSD.xml", OptionsLayoutBase.FullLayout)
        XtraMessageBox.Show("Η όψη αποθηκεύτηκε με επιτυχία", "Dreamy Kitchen CRM", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub GridView1_KeyDown(sender As Object, e As KeyEventArgs) Handles GridView1.KeyDown
        Select Case e.KeyCode
            'Case Keys.F2 : If UserProps.AllowInsert = True Then NewRecord()
            'Case Keys.F3 : If UserProps.AllowEdit = True Then EditRecord()
            'Case Keys.F5 : LoadRecords()
            Case Keys.Delete : DeleteRecord("TRANSD") 'If UserProps.AllowDelete = True Then DeleteRecord()
        End Select
    End Sub

    Private Sub RepositoryItemLookUpEdit1_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles RepositoryItemLookUpEdit1.ButtonClick
        Select Case e.Button.Index
            Case 0
            Case 1 : sender.EditValue = Nothing
        End Select

    End Sub

    Private Sub GridView1_CustomDrawFooterCell(sender As Object, e As FooterCellCustomDrawEventArgs) Handles GridView1.CustomDrawFooterCell
        Dim sSQL As String
        Try
            txtBal.EditValue = GridView1.Columns("amt").SummaryItem.SummaryValue
            If txtTotAmt.Text = "0,00 €" Then txtTotAmt.EditValue = "0.00"
            txtBal.EditValue = txtTotAmt.EditValue - txtBal.EditValue
            sSQL = "UPDATE [TRANSH] SET bal  = " & toSQLValueS(txtBal.EditValue.ToString, True) &
                           " WHERE ID = " & toSQLValueS(sID)
            Using oCmd As New SqlCommand(sSQL, CNDB)
                oCmd.ExecuteNonQuery()
            End Using
            If CalledFromCtrl = False Then
                Dim form As frmScroller = Frm
                form.DataTable = "vw_TRANSH"
                form.LoadRecords("vw_TRANSD")
            End If
        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), "Dreamy Kitchen CRM", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub txtTotAmt_EditValueChanged(sender As Object, e As EventArgs) Handles txtTotAmt.EditValueChanged
        txtBal.EditValue = GridView1.Columns("amt").SummaryItem.SummaryValue
        If txtTotAmt.Text = "0,00 €" Then txtTotAmt.EditValue = "0.00"
        txtBal.EditValue = txtTotAmt.EditValue - txtBal.EditValue

    End Sub

    Private Sub frmTransactions_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        If XtraMessageBox.Show("Θέλετε να περάσετε εγγραφή στην Μισθοδοσία Τοποθετών?", "Dreamy Kitchen CRM", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            Dim frmInstallations As New frmInstallations
            frmInstallations.Text = "Μισθοδοσία Τοποθετών"
            frmInstallations.MdiParent = frmMain
            frmInstallations.Mode = FormMode.NewRecord
            frmInstallations.Scroller = GridView1
            frmInstallations.FormScroller = Me
            frmInstallations.TRANSH_ID = sID
            If sEMP_T_ID <> Nothing Then
                frmInstallations.EMP_T_ID = sEMP_T_ID
            ElseIf txtEMP_T_ID.EditValue <> Nothing Then
                frmInstallations.EMP_T_ID = txtEMP_T_ID.EditValue.ToString
            End If

            frmInstallations.CalledFromControl = False
            'frmInstallations.cboSaler.EditValue = cboCUS.GetColumnValue("SalerID")
            frmInstallations.cboSaler.EditValue = cboSaler.EditValue
            frmInstallations.cboCUS.EditValue = cboCUS.EditValue
            frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(frmInstallations), New Point(CInt(frmInstallations.Parent.ClientRectangle.Width / 2 - frmInstallations.Width / 2), CInt(frmInstallations.Parent.ClientRectangle.Height / 2 - frmInstallations.Height / 2)))
            frmInstallations.Show()
        End If
    End Sub
    Private Sub cboSaler_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboSaler.ButtonClick
        Select Case e.Button.Index
            Case 1 : cboSaler.EditValue = Nothing : ManageSaler()
            Case 2 : If cboSaler.EditValue <> Nothing Then ManageSaler()
            Case 3 : cboSaler.EditValue = Nothing
        End Select
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
    Friend Class MenuColumnInfo
        Public Sub New(ByVal column As GridColumn)
            Me.Column = column
        End Sub
        Public Column As GridColumn
    End Class

    Private Sub txtInvoiceFilename_EditValueChanged(sender As Object, e As EventArgs) Handles txtInvoiceFilename.EditValueChanged

    End Sub

    Private Sub txtDebitCost_EditValueChanged(sender As Object, e As EventArgs) Handles txtDebitCost.EditValueChanged
        Dim Debit As Double, Devices As Double
        If txtDevicesCost.EditValue Is Nothing Or txtDebitCost.EditValue Is Nothing Then Exit Sub
        Debit = DbnullToZero(txtDebitCost) : Devices = DbnullToZero(txtDevicesCost)
        txtTotAmt.EditValue = Debit + Devices
    End Sub

    Private Sub txtDevicesCost_EditValueChanged(sender As Object, e As EventArgs) Handles txtDevicesCost.EditValueChanged
        Dim Debit As Double, Devices As Double
        If txtDevicesCost.EditValue Is Nothing Or txtDebitCost.EditValue Is Nothing Then Exit Sub
        Debit = DbnullToZero(txtDebitCost) : Devices = DbnullToZero(txtDevicesCost)
        txtTotAmt.EditValue = Debit + Devices

    End Sub
End Class