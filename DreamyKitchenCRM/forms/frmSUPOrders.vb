Imports System.Data.SqlClient
Imports DevExpress.Utils
Imports DevExpress.Utils.Menu
Imports DevExpress.XtraBars.Navigation
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraExport.Helpers
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Menu
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraLayout
Imports DevExpress.XtraReports.UI
Public Class frmSUPOrders
    Private ManageCbo As New CombosManager
    Private Valid As New ValidateControls
    Private FillCbo As New FillCombos
    Private DBQ As New DBQueries
    Private LoadForms As New FormLoader
    Private Cls As New ClearControls
    Private UserPermissions As New CheckPermissions
    Private Prog_Prop As New ProgProp

    Private Ctrl As DevExpress.XtraGrid.Views.Grid.GridView
    Private Frm As DevExpress.XtraEditors.XtraForm
    Private CtrlCombo As DevExpress.XtraEditors.LookUpEdit

    Private sID As String
    Public Mode As Byte
    Private FScrollerExist As Boolean = False
    Private CalledFromCtrl As Boolean
    Private WorkingTime As Integer
    Private AgreementSalary As Double
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
    Private Sub cmdExit_Click(sender As Object, e As EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub
    Private Sub frmSUPOrders_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DM_TRANS.CCT_TRANSH' table. You can move, or remove it, as needed.
        Me.CCT_TRANSHTableAdapter.Fill(Me.DM_TRANS.CCT_TRANSH)
        'TODO: This line of code loads data into the 'DMDataSet.CCT_TRANSH' table. You can move, or remove it, as needed.
        Me.CCT_TRANSHTableAdapter.Fill(Me.DM_TRANS.CCT_TRANSH)
        'TODO: This line of code loads data into the 'DreamyKitchenDataSet.vw_CCT' table. You can move, or remove it, as needed.
        Me.Vw_CCTTableAdapter.Fill(Me.DreamyKitchenDataSet.vw_CCT)
        'TODO: This line of code loads data into the 'DreamyKitchenDataSet.vw_SUP' table. You can move, or remove it, as needed.
        Me.Vw_SUPTableAdapter.Fill(Me.DreamyKitchenDataSet.vw_SUP)
        'TODO: This line of code loads data into the 'DreamyKitchenDataSet.vw_ORDER_MANAGERS' table. You can move, or remove it, as needed.
        Me.Vw_ORDER_MANAGERSTableAdapter.Fill(Me.DreamyKitchenDataSet.vw_ORDER_MANAGERS)
        Select Case Mode
            Case FormMode.NewRecord
                txtCode.Text = DBQ.GetNextId("SUP_ORDERS")
                cboEMP.EditValue = System.Guid.Parse(UserProps.ID.ToString.ToUpper)
            Case FormMode.EditRecord
                LoadForms.LoadForm(LayoutControl1, "Select * from SUP_ORDERS where id = " & toSQLValueS(sID))
                LoadForms.LoadDataToGrid(GridControl1, GridView1, "select ID,supOrderID,filename,comefrom,createdon,realname From vw_SUP_ORDERS_F where supOrderID = '" & sID & "'")
        End Select
        LoadForms.RestoreLayoutFromXml(GridView1, "vw_SUP_ORDERS_F_def.xml")

        Me.CenterToScreen()
        cmdSave.Enabled = IIf(Mode = FormMode.NewRecord, UserProps.AllowInsert, UserProps.AllowEdit)
    End Sub
    Private Sub cboEMP_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboEMP.ButtonClick
        Select Case e.Button.Index
            Case 1 : ManageCbo.ManageSup(cboSUP, FormMode.NewRecord)
            Case 2 : ManageCbo.ManageSup(cboSUP, FormMode.EditRecord)
            Case 3 : cboSUP.EditValue = Nothing
        End Select
    End Sub
    Private Sub cboCUS_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboCUS.ButtonClick
        Select Case e.Button.Index
            Case 1 : ManageCbo.ManageCCT(FormMode.NewRecord, False,, cboCUS)
            Case 2 : ManageCbo.ManageCCT(FormMode.EditRecord, False,, cboCUS)
            Case 3 : cboCUS.EditValue = Nothing
        End Select
    End Sub
    Private Sub cboCUS_EditValueChanged(sender As Object, e As EventArgs) Handles cboCUS.EditValueChanged
        txtPhn.EditValue = cboCUS.GetColumnValue("phn")
        txtArea.EditValue = cboCUS.GetColumnValue("AREAS_Name")
        txtADR.EditValue = cboCUS.GetColumnValue("ADR_Name")
        Dim sCusID As String
        If cboCUS.EditValue Is Nothing Then sCusID = toSQLValueS(Guid.Empty.ToString) Else sCusID = toSQLValueS(cboCUS.EditValue.ToString)
        Dim sSQL As New System.Text.StringBuilder
        sSQL.AppendLine("Select T.id,FullTranshDescription,Description
                        from vw_TRANSH t
                        where  T.cusid = " & sCusID & "order by description")
        FillCbo.TRANSH(cboTRANSH, sSQL)

    End Sub
    Private Sub cboTRANSH_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboTRANSH.ButtonClick
        Select Case e.Button.Index
            Case 1 : ManageCbo.ManageTRANSH(cboTRANSH, FormMode.NewRecord)
            Case 2 : ManageCbo.ManageTRANSH(cboTRANSH, FormMode.EditRecord)
            Case 3 : cboTRANSH.EditValue = Nothing
        End Select
    End Sub

    Private Sub cboSUP_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboSUP.ButtonClick
        Select Case e.Button.Index
            Case 1 : ManageCbo.ManageSup(cboSUP, FormMode.NewRecord)
            Case 2 : ManageCbo.ManageSup(cboSUP, FormMode.EditRecord)
            Case 3 : cboSUP.EditValue = Nothing
        End Select
    End Sub
    Private Sub frmSUPOrders_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        If Me.WindowState = FormWindowState.Maximized Then frmMain.XtraTabbedMdiManager1.Dock(Me, frmMain.XtraTabbedMdiManager1)
    End Sub
    Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click
        Dim sResult As Boolean
        Dim sGuid As String
        Try
            If Valid.ValidateForm(LayoutControl1) Then
                Select Case Mode
                    Case FormMode.NewRecord
                        sGuid = System.Guid.NewGuid.ToString
                        sResult = DBQ.InsertNewData(DBQueries.InsertMode.OneLayoutControl, "SUP_ORDERS", LayoutControl1,,, sGuid, True)
                        sID = sGuid
                    Case FormMode.EditRecord
                        sResult = DBQ.UpdateNewData(DBQueries.InsertMode.OneLayoutControl, "SUP_ORDERS", LayoutControl1,,, sID, True)
                        sGuid = sID
                End Select
                If txtFileNames.Text <> "" Then
                    sResult = DBQ.InsertDataFiles(XtraOpenFileDialog1, sGuid, "SUP_ORDERS_F")
                    LoadForms.LoadDataToGrid(GridControl1, GridView1, "select ID,supOrderID,files,filename,comefrom,createdon,realname From vw_SUP_ORDERS_F where supOrderID = '" & sGuid & "'")
                    LoadForms.RestoreLayoutFromXml(GridView1, "vw_SUP_ORDERS_F.xml")
                End If
                LoadForms.RestoreLayoutFromXml(GridView1, "vw_SUP_ORDERS_F_def.xml")
                If FScrollerExist = True Then
                    Dim form As frmScroller = Frm
                    form.LoadRecords("vw_SUP_ORDERS")
                End If

                If sResult = True Then
                    XtraMessageBox.Show("Η εγγραφή αποθηκέυτηκε με επιτυχία", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    If Mode = FormMode.NewRecord Then Mode = FormMode.EditRecord
                    txtFileNames.EditValue = Nothing
                    'If Mode = FormMode.NewRecord Then
                    '    Cls.ClearCtrls(LayoutControl1)
                    '    txtCode.Text = DBQ.GetNextId("CCT_ORDERS_KITCHEN")
                    'End If
                End If
            End If

        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub GridView1_KeyDown(sender As Object, e As KeyEventArgs) Handles GridView1.KeyDown
        Select Case e.KeyCode
            Case Keys.Delete : DeleteRecord() 'If UserProps.AllowDelete = True Then DeleteRecord()
        End Select
    End Sub
    Private Sub DeleteRecord()
        Dim sSQL As String
        Try
            If GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "ID") = Nothing Then Exit Sub
            If XtraMessageBox.Show("Θέλετε να διαγραφεί η τρέχουσα εγγραφή?", ProgProps.ProgTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                sSQL = "DELETE FROM SUP_ORDERS_F WHERE ID = '" & GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "ID").ToString & "'"

                Using oCmd As New SqlCommand(sSQL, CNDB)
                    oCmd.ExecuteNonQuery()
                End Using
                XtraMessageBox.Show("Η εγγραφή διαγράφηκε με επιτυχία", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Information)
                LoadForms.LoadDataToGrid(GridControl1, GridView1, "select ID,supOrderID,filename,comefrom,createdon,realname From vw_SUP_ORDERS_F where supOrderID = '" & sID & "'")
                LoadForms.RestoreLayoutFromXml(GridView1, "vw_SUP_ORDERS_F_def.xml")
            End If
        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub GridControl1_DoubleClick(sender As Object, e As EventArgs) Handles GridControl1.DoubleClick
        Try
            Dim sFilename = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "filename")
            'Dim fs As IO.FileStream = New IO.FileStream(Application.StartupPath & "\" & sFilename, IO.FileMode.Create)
            Dim fs As IO.FileStream = New IO.FileStream(ProgProps.TempFolderPath & sFilename, IO.FileMode.Create)
            Dim b() As Byte = GetFile(GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "ID").ToString)
            fs.Write(b, 0, b.Length)
            fs.Close()
            ShellExecute(ProgProps.TempFolderPath & sFilename)
        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
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

    Private Function GetFile(ByVal sRowID As String) As Byte()
        Dim sSQL As String
        Dim cmd As SqlCommand
        Dim sdr As SqlDataReader
        Dim bytes As Byte()

        sSQL = "Select  files From vw_SUP_ORDERS_F WHERE ID = " & toSQLValueS(sRowID)
        cmd = New SqlCommand(sSQL, CNDB) : sdr = cmd.ExecuteReader()
        If sdr.Read() = True Then
            bytes = DirectCast(sdr("files"), Byte())
            Return bytes
        End If
        sdr.Close()

    End Function
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
                txtFileNames.EditValue = txtFileNames.EditValue & IIf(txtFileNames.EditValue <> "", ";", "") & XtraOpenFileDialog1.SafeFileNames(I).Replace("'", "")
            Next I
        End If
    End Sub

    Private Sub cmdSendEmail_Click(sender As Object, e As EventArgs) Handles cmdSendEmail.Click
        ValidateEmail()
    End Sub
    Private Sub ValidateEmail()
        If txtBody.Text = "" Then XtraMessageBox.Show("Παρακαλώ συμπληρώστε κείμενο", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error) : Exit Sub
        If txtSubject.Text = "" Then XtraMessageBox.Show("Παρακαλώ συμπληρώστε το θέμα", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error) : Exit Sub
        If txtTo.Text = "" Then XtraMessageBox.Show("Δεν υπάρχει καταχωρήμενο email στον προμηθευτή.", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error) : Exit Sub
        If XtraMessageBox.Show("Θέλετε να αποσταλεί το Email με όλα τα επισυναπτόμενα αρχεία ?", ProgProps.ProgTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            SendEmail()
            Me.SUP_ORDERS_MAILTableAdapter.FillBYSupOrderID(Me.DMDataSet.SUP_ORDERS_MAIL, System.Guid.Parse(sID))
        End If
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

            'sEmailTo = "dreamykitchen@gmail.com"
            'sEmailTo = "johnmavroselinos@gmail.com"

            Dim Attachments As New Dictionary(Of String, String) : Attachments.Add(sID, "SUP_ORDERS_F")
            If Emails.SendEmail(ProgProps.EmailOrders, sSubject, sBody, sEmailTo, sFile, statusMsg, Attachments) = True Then
                sSQL = "Update SUP_ORDERS SET email = 1,DateOfEmail=getdate() WHERE ID = " & toSQLValueS(sID)


                Cmd = New SqlCommand(sSQL, CNDB) : Cmd.ExecuteNonQuery()

                ' Εισαγωγή ιστορικού email
                sSQL = "INSERT INTO SUP_ORDERS_MAIL (supOrderID,emailFrom,emailTo,emailSubject,emailBody,DateofEmail,[createdBy],[createdOn])  
                        values (" & toSQLValueS(sID) & "," & toSQLValueS(ProgProps.SupportEmail.ToString) & "," &
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

    Private Sub TabPane1_SelectedPageChanged(sender As Object, e As SelectedPageChangedEventArgs) Handles TabPane1.SelectedPageChanged
        Select Case TabPane1.SelectedPageIndex
            Case 0
            Case 1
                If sID IsNot Nothing Then Me.SUP_ORDERS_MAILTableAdapter.FillBYSupOrderID(Me.DMDataSet.SUP_ORDERS_MAIL, System.Guid.Parse(sID))
                Prog_Prop.GetProgEmailSup()
                LoadForms.RestoreLayoutFromXml(GridView2, "SUP_ORDERS_MAIL_def.xml")
                txtTo.EditValue = cboSUP.GetColumnValue("email")
        End Select

    End Sub

    Private Sub GridView1_PopupMenuShowing(sender As Object, e As DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs) Handles GridView1.PopupMenuShowing
        If e.MenuType = GridMenuType.Column Then LoadForms.PopupMenuShow(e, GridView1, "vw_SUP_ORDERS_F_def.xml",, "select top 1 [filename], [RealName], [code], [comefrom], [extension], [modifiedOn], [createdOn], [ID], [supOrderID]  from vw_SUP_ORDERS_F")
    End Sub

    Private Sub GridView2_PopupMenuShowing(sender As Object, e As DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs) Handles GridView2.PopupMenuShowing
        If e.MenuType = GridMenuType.Column Then LoadForms.PopupMenuShow(e, GridView2, "SUP_ORDERS_MAIL_def.xml",, "select top 1 [ID], [code], [supOrderID], [emailFrom], [emailTo], [emailSubject], [emailBody], [DateOfEmail], [createdOn], [createdBy]  from SUP_ORDERS_MAIL")
    End Sub
End Class