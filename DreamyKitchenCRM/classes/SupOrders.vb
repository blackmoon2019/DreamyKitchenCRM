Imports System.Data.SqlClient
Imports DevExpress.XtraEditors
Imports DevExpress.XtraReports.UI

Public Class SupOrders
    Private Frm As frmSUPOrders
    Private DBQ As New DBQueries
    Private LoadForms As New FormLoader
    Private FillCbo As New FillCombos
    Private Valid As New ValidateControls
    Private ScanFile As ScanToPDF
    Private Prog_Prop As New ProgProp
    Private UserPermissions As New CheckPermissions
    Public Mode As Byte
    Private ID As String
    Private sComeFrom As Int16
    Private sFields As New Dictionary(Of String, String)
    Public Property ComeFrom() As Int16
        Get
            Return sComeFrom
        End Get
        Set(value As Int16)
            sComeFrom = value
        End Set
    End Property

    Public Sub Initialize(ByVal sFrm As frmSUPOrders, ByVal sID As String, ByVal sMode As Byte)
        Frm = sFrm
        ID = sID
        Mode = sMode
        Frm.CCT_TRANSHTableAdapter.Fill(Frm.DM_TRANS.CCT_TRANSH)
        Frm.Vw_CCTTableAdapter.Fill(Frm.DreamyKitchenDataSet.vw_CCT)
        Frm.Vw_SUPTableAdapter.Fill(Frm.DreamyKitchenDataSet.vw_SUP)
        Frm.Vw_ORDER_MANAGERSTableAdapter.Fill(Frm.DreamyKitchenDataSet.vw_ORDER_MANAGERS)
        Frm.Vw_SUP_ORDER_TYPESTableAdapter.Fill(Frm.DMDataSet.vw_SUP_ORDER_TYPES)
        Frm.SUP_ORDERSDTableAdapter.Fill(Frm.DMDataSet.SUP_ORDERSD)


        'AddHandler Frm.GridControl1.EmbeddedNavigator.ButtonClick, AddressOf Grid_EmbeddedNavigator_ButtonClick
        UserPermissions.GetUserPermissions("Παραγγελίες Προμηθευτών")
    End Sub
    Public Sub LoadForm()
        Select Case Mode
            Case FormMode.NewRecord
                Frm.txtCode.Text = DBQ.GetNextId("SUP_ORDERS")
                Frm.cboEMP.EditValue = System.Guid.Parse(UserProps.ID.ToString.ToUpper)
            Case FormMode.EditRecord

                LoadForms.LoadForm(Frm.LayoutControl1, "Select * from SUP_ORDERS where id = " & toSQLValueS(ID), sFields)
                sComeFrom = sFields("comeFrom")
                Select Case sComeFrom
                    Case 1 : Frm.LblComeFrom.Text = "Η παραγγελία δημιουργήθηκε από εκκρεμότητα τοποθέτησης"
                    Case 2 : Frm.LblComeFrom.Text = "Η παραγγελία δημιουργήθηκε από εργασία"
                    Case 3 : Frm.LblComeFrom.Text = "Η παραγγελία δημιουργήθηκε από εκκρεμότητα κατασκευαστικού"
                    Case Else : Frm.LblComeFrom.Text = "" : Frm.cmdPrintAll.Enabled = False
                End Select
        End Select
        Frm.cmdSave.Enabled = IIf(Mode = FormMode.NewRecord, UserProps.AllowInsert, UserProps.AllowEdit)
    End Sub
    Public Sub SaveRecord()
        Dim sResult As Boolean
        Dim sGuid As String
        Try
            If Valid.ValidateForm(Frm.LayoutControl1) Then
                Select Case Mode
                    Case FormMode.NewRecord
                        sGuid = System.Guid.NewGuid.ToString
                        sResult = DBQ.InsertNewData(DBQueries.InsertMode.OneLayoutControl, "SUP_ORDERS", Frm.LayoutControl1,,, sGuid, True)
                        ID = sGuid
                    Case FormMode.EditRecord
                        sResult = DBQ.UpdateNewData(DBQueries.InsertMode.OneLayoutControl, "SUP_ORDERS", Frm.LayoutControl1,,, ID, True)
                        sGuid = ID
                End Select
                If Frm.txtFiles.Text <> "" Then
                    sResult = DBQ.InsertDataFiles(Frm.XtraOpenFileDialog1, sGuid, "SUP_ORDERS_F")
                    LoadForms.LoadDataToGrid(Frm.GridControl1, Frm.GridView1, "select ID,supOrderID,files,filename,comefrom,createdon,realname From vw_SUP_ORDERS_F where supOrderID = '" & sGuid & "'")
                    LoadForms.RestoreLayoutFromXml(Frm.GridView1, "vw_SUP_ORDERS_F.xml")
                End If
                LoadForms.RestoreLayoutFromXml(Frm.GridView1, "vw_SUP_ORDERS_F_def.xml")
                If sResult = True Then
                    XtraMessageBox.Show("Η εγγραφή αποθηκέυτηκε με επιτυχία", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    If Mode = FormMode.NewRecord Then Mode = FormMode.EditRecord
                    Frm.txtFiles.EditValue = Nothing
                End If
            End If

        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
    Public Sub DeleteRecord()
        Dim sSQL As String
        Try
            If Frm.GridView1.GetRowCellValue(Frm.GridView1.FocusedRowHandle, "ID") = Nothing Then Exit Sub
            If XtraMessageBox.Show("Θέλετε να διαγραφεί η τρέχουσα εγγραφή?", ProgProps.ProgTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                sSQL = "DELETE FROM SUP_ORDERS_F WHERE ID = '" & Frm.GridView1.GetRowCellValue(Frm.GridView1.FocusedRowHandle, "ID").ToString & "'"

                Using oCmd As New SqlCommand(sSQL, CNDB)
                    oCmd.ExecuteNonQuery()
                End Using
                XtraMessageBox.Show("Η εγγραφή διαγράφηκε με επιτυχία", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Information)
                LoadForms.LoadDataToGrid(Frm.GridControl1, Frm.GridView1, "select ID,supOrderID,filename,comefrom,createdon,realname From vw_SUP_ORDERS_F where supOrderID = '" & ID & "'")
                LoadForms.RestoreLayoutFromXml(Frm.GridView1, "vw_SUP_ORDERS_F_def.xml")
            End If
        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Public Sub OpenFile()
        Try
            Dim sFilename As String = Frm.GridView1.GetRowCellValue(Frm.GridView1.FocusedRowHandle, "filename").ToString
            Dim fs As IO.FileStream = New IO.FileStream(ProgProps.TempFolderPath & sFilename, IO.FileMode.Create)
            Dim b() As Byte = GetFile(Frm.GridView1.GetRowCellValue(Frm.GridView1.FocusedRowHandle, "ID").ToString, "SUP_ORDERS_F", sFilename)
            fs.Write(b, 0, b.Length)
            fs.Close()
            ShellExecute(ProgProps.TempFolderPath & sFilename)
        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
    Public Sub SendEmail()
        Dim Cmd As SqlCommand, sdr As SqlDataReader
        Dim Emails As New SendEmail
        Dim statusMsg As String = ""
        Dim sEmailTo As String
        Dim sSubject As String
        Dim sBody As String
        Dim sFile As String = ""
        Dim sSQL As String
        Try



            sEmailTo = Frm.txtTo.EditValue
            sBody = Frm.txtBody.EditValue
            sSubject = Frm.txtSubject.EditValue

            'sEmailTo = "dreamykitchen@gmail.com"
            'sEmailTo = "johnmavroselinos@gmail.com"
            If CNDB.Database <> "DreamyKitchen" Or Debugger.IsAttached = True Then sEmailTo = "johnmavroselinos@gmail.com;dreamykitchen@gmail.com"

            Dim Attachments As New Dictionary(Of String, String) : Attachments.Add(ID, "SUP_ORDERS_F")
            If Emails.SendEmail(ProgProps.EmailOrdersFrom, sSubject, sBody, sEmailTo, sFile, statusMsg, Attachments) = True Then
                sSQL = "Update SUP_ORDERS SET email = 1,DateOfEmail=getdate() WHERE ID = " & toSQLValueS(ID)


                Cmd = New SqlCommand(sSQL, CNDB) : Cmd.ExecuteNonQuery()

                ' Εισαγωγή ιστορικού email
                sSQL = "INSERT INTO SUP_ORDERS_MAIL (supOrderID,emailFrom,emailTo,emailSubject,emailBody,DateofEmail,[createdBy],[createdOn])  
                        values (" & toSQLValueS(ID) & "," & toSQLValueS(ProgProps.SupportEmail.ToString) & "," &
                                    toSQLValue(Frm.txtTo) & "," & toSQLValue(Frm.txtSubject) & "," &
                                    toSQLValue(Frm.txtBody) & ",getdate(), " &
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
    Public Sub PrintAll()
        If sComeFrom = 1 Then
            Dim report As New RepCUSEllipseForSUP
            report.Parameters.Item(0).Value = sFields("instEllipseID")
            report.CreateDocument()
            Dim printTool As New ReportPrintTool(report)
            printTool.ShowRibbonPreview()
        ElseIf sComeFrom = 2 Then
            Dim report As New RepCUSProjectJobsForSUP
            report.Parameters.Item(0).Value = sFields("projectJobID")
            report.CreateDocument()
            Dim printTool As New ReportPrintTool(report)
            printTool.ShowRibbonPreview()
        ElseIf sComeFrom = 3 Then
            Dim report As New RepCUSProjectJobsSUP
            report.Parameters.Item(0).Value = sFields("projectJobSupID")
            report.CreateDocument()
            Dim printTool As New ReportPrintTool(report)
            printTool.ShowRibbonPreview()
        End If
    End Sub
    Public Sub ValidateEmail()
        If Frm.txtBody.Text = "" Then XtraMessageBox.Show("Παρακαλώ συμπληρώστε κείμενο", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error) : Exit Sub
        If Frm.txtSubject.Text = "" Then XtraMessageBox.Show("Παρακαλώ συμπληρώστε το θέμα", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error) : Exit Sub
        If Frm.txtTo.Text = "" Then XtraMessageBox.Show("Δεν υπάρχει καταχωρήμενο email στον προμηθευτή.", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error) : Exit Sub
        If XtraMessageBox.Show("Θέλετε να αποσταλεί το Email με όλα τα επισυναπτόμενα αρχεία ?", ProgProps.ProgTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            SendEmail()
            Frm.SUP_ORDERS_MAILTableAdapter.FillBYSupOrderID(Frm.DMDataSet.SUP_ORDERS_MAIL, System.Guid.Parse(ID))
        End If
    End Sub
    Public Sub EmailTabSelected()
        If ID IsNot Nothing Then Frm.SUP_ORDERS_MAILTableAdapter.FillBYSupOrderID(Frm.DMDataSet.SUP_ORDERS_MAIL, System.Guid.Parse(ID))
        Prog_Prop.GetProgEmailSupFROM()
        Prog_Prop.GetProgEmailSupTO()
        LoadForms.RestoreLayoutFromXml(Frm.GridView2, "SUP_ORDERS_MAIL_def.xml")
        Frm.txtTo.EditValue = ProgProps.EmailOrdersTo
    End Sub
    Public Sub FilesTabSelected()
        LoadForms.RestoreLayoutFromXml(Frm.GridView1, "vw_SUP_ORDERS_F_def.xml")
        LoadForms.LoadDataToGrid(Frm.GridControl1, Frm.GridView1, "select ID,supOrderID,filename,comefrom,createdon,realname From vw_SUP_ORDERS_F where supOrderID = '" & ID & "'")
    End Sub
    Public Sub FilesSelection()

        'XtraOpenFileDialog1.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*"
        Frm.XtraOpenFileDialog1.FilterIndex = 1
        Frm.XtraOpenFileDialog1.InitialDirectory = "C:\"
        Frm.XtraOpenFileDialog1.Title = "Open File"
        Frm.XtraOpenFileDialog1.CheckFileExists = False
        Frm.XtraOpenFileDialog1.Multiselect = True
        Dim result As DialogResult = Frm.XtraOpenFileDialog1.ShowDialog()
        If result = DialogResult.OK Then
            Frm.txtFiles.EditValue = ""
            For I = 0 To Frm.XtraOpenFileDialog1.FileNames.Count - 1
                Frm.txtFiles.EditValue = Frm.txtFiles.EditValue & IIf(Frm.txtFiles.EditValue <> "", ";", "") & Frm.XtraOpenFileDialog1.SafeFileNames(I).Replace("'", "")
            Next I
        End If
    End Sub
End Class
