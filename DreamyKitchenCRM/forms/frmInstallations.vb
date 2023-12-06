Imports System.IO
Imports System.ComponentModel
Imports System.Data.SqlClient
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraBars.Navigation
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.DataAccess.Native.Sql.MasterDetail

Public Class frmInstallations
    Private Prog_Prop As New ProgProp
    Private sID As String
    Private sEMP_T_ID As String
    Private sTRANSH_ID As String
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
    Private UserPermissions As New CheckPermissions

    Public WriteOnly Property ID As String
        Set(value As String)
            sID = value
        End Set
    End Property
    Public WriteOnly Property EMP_T_ID As String
        Set(value As String)
            sEMP_T_ID = value
        End Set
    End Property
    Public WriteOnly Property TRANSH_ID As String
        Set(value As String)
            sTRANSH_ID = value
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
    Private Sub cmdExit_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub frmInstallations_Load(sender As Object, e As EventArgs) Handles Me.Load
        'TODO: This line of code loads data into the 'DreamyKitchenDataSet.vw_TRANSH' table. You can move, or remove it, as needed.
        Dim sSQL As New System.Text.StringBuilder
        sSQL.AppendLine(" Select C.id,C.Fullname,'00000000-0000-0000-0000-000000000000' as SalerID,phn,AdrID,email " &
                            "from vw_CCT C " &
                            "inner join vw_TRANSH T On C.ID = T.cusID  " &
                            "where completed=0 " &
                            "order by Fullname")

        FillCbo.CUS(cboCUS, sSQL)
        FillCbo.SALERS(cboSaler)
        ' Μόνο αν ο Χρήστης ΔΕΝ είναι ο Παναγόπουλος
        If UserProps.ID.ToString.ToUpper <> "3F9DC32E-BE5B-4D46-A13C-EA606566CF32" And UserProps.ID.ToString.ToUpper <> "E9CEFD11-47C0-4796-A46B-BC41C4C3606B" Then Lcost.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never : LExtracost.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        Select Case Mode
            Case FormMode.NewRecord
                txtCode.Text = DBQ.GetNextId("INST")
                FillCbo.FillCheckedListSER(chkSER, FormMode.NewRecord)
            Case FormMode.EditRecord
                LoadForms.LoadForm(LayoutControl1, "Select * from vw_INST where id ='" + sID + "'")
                FillCbo.FillCheckedListSER(chkSER, FormMode.EditRecord, sID)
                cmdInstEllipse.Enabled = True
        End Select
        If CheckIfExistInstEllipse() = True Then LInstFilename.Enabled = False
        If txtInstFilename.Text.Length > 0 Then cmdInstEllipse.Enabled = False
        Me.CenterToScreen()
        cmdSave.Enabled = IIf(Mode = FormMode.NewRecord, UserProps.AllowInsert, UserProps.AllowEdit)

    End Sub

    Private Sub frmInstallations_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        If Me.WindowState = FormWindowState.Maximized Then frmMain.XtraTabbedMdiManager1.Dock(Me, frmMain.XtraTabbedMdiManager1)
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
    Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click
        Dim sResult As Boolean
        Dim sGuid As String
        Dim sSQL As New System.Text.StringBuilder
        Try
            If Valid.ValidateForm(LayoutControl1) Then
                If CheckIfTimeisValid() = False Then Exit Sub
                If CheckIfInstFExist() = False Then Exit Sub
                Select Case Mode
                    Case FormMode.NewRecord
                        sGuid = System.Guid.NewGuid.ToString
                        sResult = DBQ.InsertNewData(DBQueries.InsertMode.OneLayoutControl, "INST", LayoutControl1,,, sGuid, True)
                        sID = sGuid
                    Case FormMode.EditRecord
                        sResult = DBQ.UpdateNewData(DBQueries.InsertMode.OneLayoutControl, "INST", LayoutControl1,,, sID, True)
                        'sGuid = sID
                End Select

                If sResult = True Then
                    If cboTRANSH.EditValue IsNot Nothing Then
                        sSQL.Clear()
                        sSQL.AppendLine("UPDATE PROJECT_COST SET InstPayroll = (Select sum(ISNULL(I.cost, 0) + ISNULL(I.extracost, 0)) from INST I where I.transhid= " & toSQLValueS(cboTRANSH.EditValue.ToString) & ")")
                        sSQL.AppendLine("WHERE TRANSHID = " & toSQLValueS(cboTRANSH.EditValue.ToString))
                        'Εκτέλεση QUERY
                        Using oCmd As New SqlCommand(sSQL.ToString, CNDB)
                            oCmd.ExecuteNonQuery()
                        End Using
                        ' Άνοιγμα έργου αν δεν υπάρχει ή ενημέρωση ποσών
                        Using oCmd As New SqlCommand("usp_AddOrUpdateProjectcost", CNDB)
                            oCmd.CommandType = CommandType.StoredProcedure
                            oCmd.Parameters.AddWithValue("@transhID", cboTRANSH.EditValue.ToString)
                            oCmd.ExecuteNonQuery()
                        End Using
                    End If

                    XtraMessageBox.Show("Η εγγραφή αποθηκέυτηκε με επιτυχία", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
                Dim sSQL2 As String
                If Mode = FormMode.EditRecord Then
                    sSQL2 = "DELETE FROM INST_SER where instID = '" & sID & "'"
                    Using oCmd As New SqlCommand(sSQL2, CNDB)
                        oCmd.ExecuteNonQuery()
                    End Using
                End If

                ' Καταχώρηση Συνεργείων
                For Each item As DevExpress.XtraEditors.Controls.CheckedListBoxItem In chkSER.CheckedItems
                    sSQL2 = "INSERT INTO INST_SER (instID,empID,[createdBy],[createdOn])  
                                        values (" & toSQLValueS(sID) & "," & toSQLValueS(item.Tag.ToString()) & "," &
                                                        toSQLValueS(UserProps.ID.ToString) & ", getdate() )"
                    Using oCmd As New SqlCommand(sSQL2, CNDB)
                        oCmd.ExecuteNonQuery()
                    End Using
                Next
                FillCbo.FillCheckedListSER(chkSER, FormMode.EditRecord, sID)
            End If

        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Function CheckIfTimeisValid() As Boolean
        If txtTmIN.Text = "00:00" Or txtTmOUT.Text = "00:00" Then XtraMessageBox.Show("Η ώρα δεν μπορεί να είναι 00:00", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error) : Return False
        Dim Hours As Long = DateDiff(DateInterval.Hour, txtTmIN.EditValue, txtTmOUT.EditValue)
        If Hours < 0 Then XtraMessageBox.Show("Η ώρα ΑΠΟ δεν μπορεί να είναι μικρότερη από την ΕΩΣ", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error) : Return False
        Return True
    End Function
    Private Function CheckIfInstFExist() As Boolean
        Dim sFilename As String = ""
        If chkCompleted.Checked = True Then
            Dim Cmd As SqlCommand, sdr As SqlDataReader
            Dim sSQL As String = "SELECT fInstName  FROM INST WHERE ID= " & toSQLValueS(sID)
            Cmd = New SqlCommand(sSQL.ToString, CNDB)
            sdr = Cmd.ExecuteReader()
            If (sdr.Read() = True) Then
                If sdr.IsDBNull(sdr.GetOrdinal("fInstName")) = False Then sFilename = sdr.GetString(sdr.GetOrdinal("fInstName"))
                If sFilename = "" Then
                    XtraMessageBox.Show("Δεν μπορείτε να ολοκληρώσετε την Τοποθέτηση χωρίς να επισυνάψετε έντυπο", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
                    sdr.Close()
                    Return False
                Else
                    sdr.Close()
                    Return True
                End If
            Else
                XtraMessageBox.Show("Δεν μπορείτε να ολοκληρώσετε την Τοποθέτηση χωρίς να επισυνάψετε έντυπο", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            End If
        Else
            Return True
        End If
    End Function
    Private Sub ManageTRANSH()
        Dim form1 As frmTransactions = New frmTransactions()
        form1.Text = "Χρεωπιστώσεις Πελατών"
        form1.CallerControl = cboTRANSH
        form1.CalledFromControl = True
        form1.MdiParent = frmMain
        If cboTRANSH.EditValue <> Nothing Then
            form1.ID = cboTRANSH.EditValue.ToString
            form1.Mode = FormMode.EditRecord
        Else
            form1.Mode = FormMode.NewRecord
        End If

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


    Private Sub cboCUS_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboCUS.ButtonClick
        Select Case e.Button.Index
            Case 1 : cboCUS.EditValue = Nothing : ManageCus()
            Case 2 : If cboCUS.EditValue <> Nothing Then ManageCus()
            Case 3 : cboCUS.EditValue = Nothing
        End Select
    End Sub
    Private Sub cboSaler_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboSaler.ButtonClick
        Select Case e.Button.Index
            Case 1 : If UserProps.ID.ToString.ToUpper = "3F9DC32E-BE5B-4D46-A13C-EA606566CF32" Or UserProps.ID.ToString.ToUpper = "E9CEFD11-47C0-4796-A46B-BC41C4C3606B" Then cboSaler.EditValue = Nothing : ManageSaler()
            Case 2 : If UserProps.ID.ToString.ToUpper = "3F9DC32E-BE5B-4D46-A13C-EA606566CF32" Or UserProps.ID.ToString.ToUpper = "E9CEFD11-47C0-4796-A46B-BC41C4C3606B" Then If cboSaler.EditValue <> Nothing Then ManageSaler()
            Case 3 : cboSaler.EditValue = Nothing
        End Select
    End Sub

    Private Sub frmInstallations_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        'If Mode <> FormMode.NewRecord Then Exit Sub
        If sEMP_T_ID Is Nothing Then Exit Sub
        If XtraMessageBox.Show("Θέλετε να ενημερώσετε τους Τζίρους-Ποσοστά Έκθεσης?", ProgProps.ProgTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            frmSalerTziroi.Text = "Τζίροι-Ποσοστά έκθεσης"
            frmSalerTziroi.ID = sEMP_T_ID
            frmSalerTziroi.MdiParent = frmMain
            frmSalerTziroi.Mode = FormMode.EditRecord

            frmSalerTziroi.FormScrollerExist = False
            frmSalerTziroi.CalledFromControl = False
            frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(frmSalerTziroi), New Point(CInt(frmSalerTziroi.Parent.ClientRectangle.Width / 2 - frmSalerTziroi.Width / 2), CInt(frmSalerTziroi.Parent.ClientRectangle.Height / 2 - frmSalerTziroi.Height / 2)))
            frmSalerTziroi.Show()
        End If
    End Sub

    Private Sub cmdInstEllipse_Click(sender As Object, e As EventArgs) Handles cmdInstEllipse.Click
        'Έλεγχος για να δεί αν υπάρχει μη ολοκληρωμένη έλλειψη πριν ανοίξει καινούρια γιαυτην την τοποθέτηση 
        If CheckIfHasInstNotCompleted() = True Then XtraMessageBox.Show("Δεν μπορείτε να δημιουργήσετε νέα εγγραφή όταν υπάρχει μη ολοκληρωμένη εκκρεμότητα.", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error) : Exit Sub
        'Eλεγχος αν υπάρχει έντυπο ολοκλήρωσης
        If CheckIfEllipseHasCompleteDocument() = True Then XtraMessageBox.Show("Δεν μπορείτε να δημιουργήσετε νέα εγγραφή, έχουν ολοκληρωθεί όλες οι εκκρεμότητες.", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error) : Exit Sub

        Dim frmInstEllipse As New frmInstEllipse
        frmInstEllipse.Text = "Εκκρεμότητες Έργων"
        frmInstEllipse.Mode = FormMode.NewRecord
        frmInstEllipse.INST_ID = sID
        frmInstEllipse.CalledFromControl = False
        frmInstEllipse.ComeFrom = 0
        'frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(frmInstEllipse), New Point(CInt(frmInstEllipse.Parent.ClientRectangle.Width / 2 - frmInstEllipse.Width / 2), CInt(frmInstEllipse.Parent.ClientRectangle.Height / 2 - frmInstEllipse.Height / 2)))
        frmInstEllipse.Show()
    End Sub
    Private Function CheckIfEllipseHasCompleteDocument() As Boolean
        Dim Cmd As SqlCommand, sdr As SqlDataReader
        Dim sSQL As String
        sSQL = "SELECT fInstEllipseNameComplete FROM INST_ELLIPSE WHERE instID= " & toSQLValueS(sID)
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
        sSQL = "SELECT top 1 id FROM INST_ELLIPSE WHERE completed = 0  and instID= " & toSQLValueS(sID)
        Cmd = New SqlCommand(sSQL.ToString, CNDB)
        sdr = Cmd.ExecuteReader()
        Dim EllipseID As String
        If (sdr.Read() = True) Then
            If sdr.IsDBNull(sdr.GetOrdinal("id")) = False Then EllipseID = sdr.GetGuid(sdr.GetOrdinal("id")).ToString Else EllipseID = ""
            If EllipseID <> "" Then Return True Else Return False
        Else
            Return False
        End If
        sdr.Close()

    End Function

    Private Sub cboCUS_EditValueChanged(sender As Object, e As EventArgs) Handles cboCUS.EditValueChanged
        Dim sCusID As String
        If cboCUS.EditValue Is Nothing Then sCusID = Guid.Empty.ToString Else sCusID = cboCUS.EditValue.ToString
        Me.Vw_TRANSHTableAdapter.Fill(Me.DM_TRANS.vw_TRANSH, System.Guid.Parse(sCusID))
    End Sub


    Private Sub cboTRANSH_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboTRANSH.ButtonClick
        Select Case e.Button.Index
            Case 1 : If UserProps.ID.ToString.ToUpper = "3F9DC32E-BE5B-4D46-A13C-EA606566CF32" Or UserProps.ID.ToString.ToUpper = "E9CEFD11-47C0-4796-A46B-BC41C4C3606B" Then cboTRANSH.EditValue = Nothing : ManageTRANSH()
            Case 2 : If UserProps.ID.ToString.ToUpper = "3F9DC32E-BE5B-4D46-A13C-EA606566CF32" Or UserProps.ID.ToString.ToUpper = "E9CEFD11-47C0-4796-A46B-BC41C4C3606B" Then If cboTRANSH.EditValue <> Nothing Then ManageTRANSH()
            Case 3 : cboTRANSH.EditValue = Nothing
        End Select
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
            txtInstFilename.EditValue = XtraOpenFileDialog1.FileName
            Dim sSQL As String
            Try
                My.Computer.FileSystem.CopyFile(XtraOpenFileDialog1.FileName, ProgProps.ServerPath & Path.GetFileName(XtraOpenFileDialog1.FileName), True)

                sSQL = "UPDATE INST SET completed = 1, fInstName =  " & toSQLValueS(Path.GetFileName(XtraOpenFileDialog1.FileName).ToString) & ",fInst =  BulkColumn from Openrowset( Bulk " & toSQLValueS(ProgProps.ServerPath & Path.GetFileName(XtraOpenFileDialog1.FileName)) & ", Single_Blob) as InstF where ID = " & toSQLValueS(sID)
                'Εκτέλεση QUERY
                Using oCmd As New SqlCommand(sSQL, CNDB)
                    oCmd.ExecuteNonQuery()
                End Using
                chkCompleted.CheckState = CheckState.Checked : cmdInstEllipse.Enabled = False

                XtraMessageBox.Show("Το αρχείο αποθηκεύτηκε με επιτυχία", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Information)
                cmdInstEllipse.Enabled = False
            Catch ex As Exception
                XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

        End If
    End Sub

    Private Sub txtInstFilename_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles txtInstFilename.ButtonClick
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
                If CheckIfExistInstEllipse() = False Then
                    FileSelect()
                Else
                    XtraMessageBox.Show("Δεν μπορείτε να ανεβάσετε έντυπο ολοκλήρωσης γιατί υπάρχουν εκκρεμότητες", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If

            Case 1 : OpenFile()

            Case 2
                If XtraMessageBox.Show("Θέλετε να διαγραφεί το αρχείο?", ProgProps.ProgTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                    Dim sSQL As String
                    sSQL = "UPDATE INST SET completed = 0 ,fInstName =  NULL ,fInst =  NULL where ID = " & toSQLValueS(sID)
                    'Εκτέλεση QUERY
                    Using oCmd As New SqlCommand(sSQL, CNDB)
                        oCmd.ExecuteNonQuery()
                    End Using
                    txtInstFilename.EditValue = Nothing : cmdInstEllipse.Enabled = True : chkCompleted.CheckState = CheckState.Unchecked
                End If
        End Select

    End Sub
    'Έλεγχος αν υπάρχει εκκρεμότητα ανολοκλήρωτη
    Private Function CheckIfExistInstEllipse() As Boolean
        Dim Cmd As SqlCommand, sdr As SqlDataReader
        Dim EllipseID As String = ""
        Try
            Cmd = New SqlCommand("Select TOP 1 ID FROM INST_ELLIPSE IE WHERE completed = 0 and IE.instID= " & toSQLValueS(sID), CNDB)
            sdr = Cmd.ExecuteReader()
            If (sdr.Read() = True) Then
                EllipseID = sdr.GetGuid(sdr.GetOrdinal("ID")).ToString.ToUpper
                If EllipseID <> "" Then
                    sdr.Close()
                    Return True
                Else
                    sdr.Close()
                    Return False
                End If
            Else
                sdr.Close()
                Return False
            End If
        Catch ex As Exception
            Return False
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Function
    Private Sub OpenFile()
        Try
            Dim Cmd As SqlCommand, sdr As SqlDataReader
            Dim sSQL As String = "SELECT fInst,fInstName  FROM INST WHERE ID= " & toSQLValueS(sID)
            Cmd = New SqlCommand(sSQL.ToString, CNDB)
            sdr = Cmd.ExecuteReader()
            If (sdr.Read() = True) Then
                If sdr.IsDBNull(sdr.GetOrdinal("fInstName")) = False Then
                    Dim sFilename = Path.GetFileName(sdr.GetString(sdr.GetOrdinal("fInstName")))
                    Dim fs As IO.FileStream = New IO.FileStream(ProgProps.TempFolderPath & sFilename, IO.FileMode.Create)
                    Dim b As Byte()
                    b = DirectCast(sdr("fInst"), Byte())
                    fs.Write(b, 0, b.Length)
                    fs.Close()
                    ShellExecute(ProgProps.TempFolderPath & sFilename)
                End If
            End If
            sdr.Close()
        Catch exfs As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", exfs.Message), ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally

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

    Private Sub TabPane1_SelectedPageChanged(sender As Object, e As SelectedPageChangedEventArgs) Handles TabPane1.SelectedPageChanged
        Select Case TabPane1.SelectedPageIndex
            Case 0
            Case 1 : LoadRecords()
            Case 2
                If dtDeliverDate.EditValue = Nothing Or txtTmIN.Text = "00:00" Or txtTmOUT.EditValue = "00:00" Then cmdSendApointmentEmail.Enabled = False Else cmdSendApointmentEmail.Enabled = True
                Me.INST_MAILTableAdapter.FillByinstID(Me.DMDataSet.INST_MAIL, System.Guid.Parse(sID))
                LoadForms.RestoreLayoutFromXml(GridView3, "INST_MAIL.xml")
                Prog_Prop.GetProgEmailInst()
                txtTo.EditValue = cboCUS.GetColumnValue("email")
                txtSubject.EditValue = ProgProps.InstInfSubject
                txtBody.EditValue = ProgProps.InstInfAppointmentBody
        End Select
    End Sub
    Private Sub LoadRecords()
        Dim sSQL As String = "SELECT  * FROM vw_INST_ELLIPSE where instID = " & toSQLValueS(sID)
        Dim sSQL2 As String = "SELECT  * FROM  INST_ELLIPSE_JOBS where instID = " & toSQLValueS(sID)
        Dim AdapterMaster As New SqlDataAdapter(sSQL, CNDB)
        Dim AdapterDetail As New SqlDataAdapter(sSQL2, CNDB)
        Dim sdataSet As New DataSet()
        AdapterMaster.Fill(sdataSet, "vw_INST_ELLIPSE")
        AdapterDetail.Fill(sdataSet, "INST_ELLIPSE_JOBS")
        Dim keyColumn As DataColumn = sdataSet.Tables("vw_INST_ELLIPSE").Columns("ID")
        Dim foreignKeyColumn As DataColumn = sdataSet.Tables("INST_ELLIPSE_JOBS").Columns("instEllipseID")
        sdataSet.Relations.Add("Εκκρεμότητες", keyColumn, foreignKeyColumn, False)
        GridView1.Columns.Clear() : GridView2.Columns.Clear()
        grdMain.DataSource = sdataSet.Tables("vw_INST_ELLIPSE")
        grdMain.ForceInitialize()
        If grdMain.LevelTree.Nodes.Count = 1 Then
            Dim GrdView As New GridView(grdMain)
            grdMain.LevelTree.Nodes.Add("Εκκρεμότητες", GridView2)
            'Specify text to be displayed within detail tabs.
            GrdView.ViewCaption = "Εκκρεμότητες"
        End If
        LoadForms.RestoreLayoutFromXml(GridView1, "vw_INST_ELLIPSE_INSIDE.xml")
        LoadForms.RestoreLayoutFromXml(GridView2, "D_INST_ELLIPSE_JOBS_INSIDE.xml")
    End Sub

    Private Sub GridView1_DoubleClick(sender As Object, e As EventArgs) Handles GridView1.DoubleClick
        Dim frmInstEllipse As New frmInstEllipse
        frmInstEllipse.Text = "Εκκρεμότητες Έργων"
        'frmInstEllipse.MdiParent = frmMain
        frmInstEllipse.Mode = FormMode.EditRecord
        frmInstEllipse.ID = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "ID").ToString
        frmInstEllipse.Scroller = GridView1
        frmInstEllipse.FormScroller = Me
        frmInstEllipse.CalledFromControl = False
        frmInstEllipse.ComeFrom = 1
        'frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(frmInstEllipse), New Point(CInt(Me.Parent.ClientRectangle.Width / 2 - Me.Width / 2), CInt(Me.Parent.ClientRectangle.Height / 2 - Me.Height / 2)))
        frmInstEllipse.ShowDialog()

    End Sub

    Private Sub GridView1_KeyDown(sender As Object, e As KeyEventArgs) Handles GridView1.KeyDown
        Dim sSQL As String
        If e.KeyCode = Keys.Delete Then
            If UserProps.AllowDelete = False Then Exit Sub
            If XtraMessageBox.Show("Θέλετε να διαγραφεί η εκκρεμότητα?", ProgProps.ProgTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                Dim Cmd As SqlCommand, sdr As SqlDataReader
                sSQL = "SELECT count (id) as CountEllipse  FROM INST_ELLIPSE WHERE comefrom= 0 and instID= " & toSQLValueS(GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "instID").ToString) &
                                " and DATEADD(ms, -DATEPART(ms, createdOn), createdOn)> " & toSQLValueS(DateTime.Parse(GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "createdOn")).ToString("yyyy-MM-dd HH:mm:ss.fff"))
                Cmd = New SqlCommand(sSQL.ToString, CNDB)
                sdr = Cmd.ExecuteReader()
                Dim CountEllipse As Integer
                If (sdr.Read() = True) Then
                    If sdr.IsDBNull(sdr.GetOrdinal("CountEllipse")) = False Then CountEllipse = sdr.GetInt32(sdr.GetOrdinal("CountEllipse")) Else CountEllipse = 0
                    If CountEllipse > 0 Then
                        XtraMessageBox.Show("Δεν μπορείτε να διαγράψετε έλλειψη όταν υπάρχει κι αλλη έλλειψη για το έργο σε μεταγενέστερη ημερομηνία.", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
                        sdr.Close()
                        Exit Sub
                    Else
                        Try
                            sSQL = "DELETE FROM INST_ELLIPSE WHERE ID = '" & GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "ID").ToString & "'"
                            Using oCmd As New SqlCommand(sSQL, CNDB)
                                oCmd.ExecuteNonQuery()
                            End Using
                        Catch ex As SqlException
                            If ex.ErrorCode = -2146232060 Then
                                XtraMessageBox.Show("Δεν μπορεί να διαγραφέι η εκκρεμότητα από την στιγμή που έχει αποσταλεί Email", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
                            Else
                                XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
                            End If

                        End Try
                        LoadRecords()
                    End If
                Else
                    XtraMessageBox.Show("Παρουσιάστηκε κάποιο πρόβλημα στην ανάγνωση εγγραφών.", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
                    sdr.Close()
                    Exit Sub
                End If
            End If
        End If
    End Sub
    Private Sub GridView1_PopupMenuShowing(sender As Object, e As PopupMenuShowingEventArgs) Handles GridView1.PopupMenuShowing
        If e.MenuType = GridMenuType.Column Then LoadForms.PopupMenuShow(e, GridView1, "vw_INST_ELLIPSE_INSIDE.xml", "vw_INST_ELLIPSE")
    End Sub
    Private Sub GridView2_PopupMenuShowing(sender As Object, e As PopupMenuShowingEventArgs) Handles GridView2.PopupMenuShowing
        If e.MenuType = GridMenuType.Column Then LoadForms.PopupMenuShow(e, GridView2, "D_INST_ELLIPSE_JOBS_INSIDE.xml", "INST_ELLIPSE_JOBS")
    End Sub
    Private Sub GridView3_PopupMenuShowing(sender As Object, e As PopupMenuShowingEventArgs) Handles GridView3.PopupMenuShowing
        If e.MenuType = GridMenuType.Column Then LoadForms.PopupMenuShow(e, GridView3, "INST_MAIL.xml", "vw_INST_MAIL")
    End Sub
    Private Sub ValidateEmail()
        If txtBody.Text = "" Then XtraMessageBox.Show("Παρακαλώ συμπληρώστε κείμενο", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error) : Exit Sub
        If txtSubject.Text = "" Then XtraMessageBox.Show("Παρακαλώ συμπληρώστε το θέμα", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error) : Exit Sub
        If txtTo.Text = "" Then XtraMessageBox.Show("Δεν υπάρχει καταχωρήμενο email στον πελάτη.", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error) : Exit Sub
        If XtraMessageBox.Show("Θέλετε να αποσταλεί το Email?", ProgProps.ProgTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            SendEmail()
            Me.INST_MAILTableAdapter.FillByinstID(Me.DMDataSet.INST_MAIL, System.Guid.Parse(sID))
        End If
    End Sub
    Private Sub cmdSendApointmentEmail_Click(sender As Object, e As EventArgs) Handles cmdSendApointmentEmail.Click
        ValidateEmail()
    End Sub
    Private Sub SendEmail()
        Dim Cmd As SqlCommand, sdr As SqlDataReader
        Dim Emails As New SendEmail
        Dim statusMsg As String = ""
        Dim sEmailTo As String
        Dim sSubject As String
        Dim sBody As String
        Dim sFile As String = ""
        Dim sSQL As String
        Try



            sEmailTo = txtTo.EditValue
            sBody = txtBody.EditValue
            sSubject = txtSubject.EditValue
            sBody = sBody.Replace("{INST_DATE_DELIVERED}", Date.Now.Date)

            ' sEmailTo = "dreamykitchen@gmail.com"
            ' sEmailTo = "johnmavroselinos@gmail.com"


            If Emails.SendEmail(ProgProps.InstEmailAccount, sSubject, sBody, sEmailTo, sFile, statusMsg) = True Then
                sSQL = "Update INST SET emailApp = 1,DateOfEmailApp=getdate() WHERE ID = " & toSQLValueS(sID)


                Cmd = New SqlCommand(sSQL, CNDB) : Cmd.ExecuteNonQuery()

                ' Εισαγωγή ιστορικού email
                sSQL = "INSERT INTO INST_MAIL (instID,emailFrom,emailTo,emailSubject,emailBody,DateofEmail,[createdBy],[createdOn],emailMode,ComeFrom)  
                        values (" & toSQLValueS(sID) & "," & toSQLValueS(ProgProps.InstEmailAccount.ToString) & "," &
                                    toSQLValue(txtTo) & "," & toSQLValue(txtSubject) & "," &
                                    toSQLValue(txtBody) & ",getdate(), " &
                                    toSQLValueS(UserProps.ID.ToString) & ", getdate(),0,0 )"
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

    Private Sub cmdExit_Click_1(sender As Object, e As EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub
End Class