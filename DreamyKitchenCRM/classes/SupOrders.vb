Imports System.Data.SqlClient
Imports System.IO
Imports System.Runtime.Remoting.Metadata.W3cXsd2001
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
        'Frm.SUP_ORDERSDTableAdapter.Fill(Frm.DMDataSet.SUP_ORDERSD)
        Frm.Vw_SUP_ORDERSDTableAdapter.FillBysupOrderID(Frm.DMDataSet.vw_SUP_ORDERSD, System.Guid.Parse(ID))

        AddHandler Frm.GridControl3.EmbeddedNavigator.ButtonClick, AddressOf Grid_EmbeddedNavigator_ButtonClick
        UserPermissions.GetUserPermissions("Παραγγελίες Προμηθευτών")
    End Sub
    Public Sub LoadForm()
        Select Case Mode
            Case FormMode.NewRecord
                Frm.txtCode.Text = DBQ.GetNextId("SUP_ORDERS")
                Frm.cboEMP.EditValue = System.Guid.Parse(UserProps.ID.ToString.ToUpper)
                Frm.LblComeFrom.Text = "Αρχική"
                LoadForms.RestoreLayoutFromXml(Frm.GridView3, "SUP_ORDERS_D_def.xml")
                Frm.GridView3.OptionsBehavior.Editable = False : Frm.GridView3.OptionsBehavior.ReadOnly = True
            Case FormMode.EditRecord
                LoadForms.LoadForm(Frm.LayoutControl1, "Select * from SUP_ORDERS where id = " & toSQLValueS(ID), sFields)
                sComeFrom = sFields("comeFrom")
                Select Case sComeFrom
                    Case 0 : Frm.LblComeFrom.Text = "Αρχική"
                    Case 1 : Frm.LblComeFrom.Text = "Η παραγγελία δημιουργήθηκε από εκκρεμότητα τοποθέτησης"
                    Case 2 : Frm.LblComeFrom.Text = "Η παραγγελία δημιουργήθηκε από εργασία"
                    Case 3 : Frm.LblComeFrom.Text = "Η παραγγελία δημιουργήθηκε από εκκρεμότητα κατασκευαστικού"
                    Case 4 : Frm.LblComeFrom.Text = "Η παραγγελία δημιουργήθηκε από συσκευές"
                    Case Else : Frm.LblComeFrom.Text = "" : Frm.cmdPrintAll.Enabled = False
                End Select
                LoadForms.RestoreLayoutFromXml(Frm.GridView3, "SUP_ORDERS_D_def.xml")
                If sComeFrom <> 0 Then
                    Frm.GridView3.Columns.Item("Files").Visible = False
                    Frm.GridView3.Columns.Item("HasFiles").Visible = False
                End If

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
                End Select
                'If Frm.txtFiles.Text <> "" Then
                '    sResult = DBQ.InsertDataFiles(Frm.XtraOpenFileDialog1, sGuid, "SUP_ORDERS_F")
                '    LoadForms.LoadDataToGrid(Frm.GridControl1, Frm.GridView1, "select ID,supOrderID,files,filename,comefrom,createdon,realname From vw_SUP_ORDERS_F where supOrderID = '" & sGuid & "'")
                '    LoadForms.RestoreLayoutFromXml(Frm.GridView1, "vw_SUP_ORDERS_F.xml")
                'End If
                LoadForms.RestoreLayoutFromXml(Frm.GridView1, "vw_SUP_ORDERS_F_def.xml")
                If sResult = True Then
                    XtraMessageBox.Show("Η εγγραφή αποθηκέυτηκε με επιτυχία", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    If Mode = FormMode.NewRecord Then Mode = FormMode.EditRecord
                    'Frm.txtFiles.EditValue = Nothing
                    Frm.GridView3.OptionsBehavior.Editable = True : Frm.GridView3.OptionsBehavior.ReadOnly = False
                End If
            End If

        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
    Public Sub SaveRecordD(ByVal e As DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs)
        Dim sSQLS As New System.Text.StringBuilder
        Dim sGuid As String
        Try
            sSQLS.Clear()
            If Frm.GridView3.RowCount = 0 Then Exit Sub
            If e.RowHandle = Frm.GridControl3.NewItemRowHandle Then
                If Frm.GridView3.GetRowCellValue(Frm.GridView3.FocusedRowHandle, "supID").ToString = "" Then
                    e.ErrorText = "Παρακαλώ επιλεξτε προμηθευτή"
                    e.Valid = False
                    Exit Sub
                End If
                If Frm.GridView3.GetRowCellValue(Frm.GridView3.FocusedRowHandle, "orderType").ToString = "" Then
                    e.ErrorText = "Παρακαλώ επιλέξτε κατηγορία παραγγελίας"
                    e.Valid = False
                    Exit Sub
                End If
                sGuid = Guid.NewGuid.ToString
                Frm.GridView3.SetRowCellValue(Frm.GridView3.FocusedRowHandle, "supOrderID", ID)
                sSQLS.AppendLine("INSERT INTO SUP_ORDERSD (ID,supOrderID,supID,orderType,cmt,createdOn,createdBy,modifiedBy)")
                sSQLS.AppendLine("Select " & toSQLValueS(sGuid) & ",")
                sSQLS.AppendLine(toSQLValueS(ID) & ",")
                sSQLS.AppendLine(toSQLValueS(Frm.GridView3.GetRowCellValue(Frm.GridView3.FocusedRowHandle, "supID").ToString) & ",")
                sSQLS.AppendLine(toSQLValueS(Frm.GridView3.GetRowCellValue(Frm.GridView3.FocusedRowHandle, "orderType").ToString, True) & ",")
                sSQLS.AppendLine(toSQLValueS(Frm.GridView3.GetRowCellValue(Frm.GridView3.FocusedRowHandle, "cmt").ToString) & ",")
                sSQLS.AppendLine("getdate()" & ",")
                sSQLS.AppendLine(toSQLValueS(UserProps.ID.ToString) & ",")
                sSQLS.AppendLine(toSQLValueS(UserProps.ID.ToString))
                'Εκτέλεση QUERY
                Using oCmd As New SqlCommand(sSQLS.ToString, CNDB)
                    oCmd.ExecuteNonQuery()
                End Using
                SaveRecordF(sGuid)
            Else
                If Frm.GridView3.GetRowCellValue(Frm.GridView3.FocusedRowHandle, "supID").ToString = "" Then
                    e.ErrorText = "Παρακαλώ επιλεξτε προμηθευτή"
                    e.Valid = False
                    Exit Sub
                End If
                If Frm.GridView3.GetRowCellValue(Frm.GridView3.FocusedRowHandle, "orderType").ToString = "" Then
                    e.ErrorText = "Παρακαλώ επιλέξτε κατηγορία παραγγελίας"
                    e.Valid = False
                    Exit Sub
                End If
                sGuid = Frm.GridView3.GetRowCellValue(Frm.GridView3.FocusedRowHandle, "ID").ToString
                sSQLS.AppendLine("UPDATE SUP_ORDERSD SET  ")
                sSQLS.AppendLine("supID = " & toSQLValueS(Frm.GridView3.GetRowCellValue(Frm.GridView3.FocusedRowHandle, "supID").ToString) & ",")
                sSQLS.AppendLine("cmt = " & toSQLValueS(Frm.GridView3.GetRowCellValue(Frm.GridView3.FocusedRowHandle, "cmt").ToString) & ",")
                sSQLS.AppendLine("orderType = " & toSQLValueS(Frm.GridView3.GetRowCellValue(Frm.GridView3.FocusedRowHandle, "orderType").ToString, True) & ",")
                sSQLS.AppendLine("modifiedBy = " & toSQLValueS(UserProps.ID.ToString) & ",")
                sSQLS.AppendLine("modifiedOn = getdate()")
                sSQLS.Append("WHERE ID = " & toSQLValueS(sGuid))
                'Εκτέλεση QUERY
                Using oCmd As New SqlCommand(sSQLS.ToString, CNDB)
                    oCmd.ExecuteNonQuery()
                End Using
                SaveRecordF(sGuid)
            End If
            'Frm.SUP_ORDERSDTableAdapter.Fill(Frm.DMDataSet.SUP_ORDERSD)
            Frm.Vw_SUP_ORDERSDTableAdapter.FillBysupOrderID(Frm.DMDataSet.vw_SUP_ORDERSD, System.Guid.Parse(ID))
            LoadForms.RestoreLayoutFromXml(Frm.GridView3, "SUP_ORDERS_D_def.xml")
        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Public Sub SaveRecordF(ByVal sID As String)
        Try
            Dim sResultF As Boolean
            Using oCmd As New SqlCommand("DELETE FROM SUP_ORDERS_F WHERE supOrderDID = " & toSQLValueS(sID), CNDB)
                oCmd.ExecuteNonQuery()
            End Using
            sResultF = DBQ.InsertDataFiles(Frm.XtraOpenFileDialog1, sID, "SUP_ORDERS_F")
        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Grid_EmbeddedNavigator_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.NavigatorButtonClickEventArgs)
        Select Case e.Button.ButtonType
            Case e.Button.ButtonType.Remove : DeleteRecordD() : e.Handled = True
            Case e.Button.ButtonType.Append
        End Select
    End Sub
    Public Sub DeleteRecordF()
        Try
            If Frm.GridView3.GetRowCellValue(Frm.GridView3.FocusedRowHandle, "HasFiles").ToString = "False" Then Exit Sub
            Using oCmd As New SqlCommand("DELETE FROM SUP_ORDERS_F WHERE supOrderDID = " & toSQLValueS(Frm.GridView3.GetRowCellValue(Frm.GridView3.FocusedRowHandle, "ID").ToString), CNDB)
                oCmd.ExecuteNonQuery()
            End Using
            Frm.Vw_SUP_ORDERSDTableAdapter.FillBysupOrderID(Frm.DMDataSet.vw_SUP_ORDERSD, System.Guid.Parse(ID))
            XtraMessageBox.Show("Τα αρχεία διαγράφηκαν", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Public Sub DeleteRecordD()
        Dim sSQL As String
        If Frm.GridView3.GetRowCellValue(Frm.GridView3.FocusedRowHandle, "ID") = Nothing Then Exit Sub
        If XtraMessageBox.Show("Θέλετε να διαγραφεί η τρέχουσα εγγραφή?", ProgProps.ProgTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            sSQL = "DELETE FROM SUP_ORDERSD WHERE ID = '" & Frm.GridView3.GetRowCellValue(Frm.GridView3.FocusedRowHandle, "ID").ToString & "'"

            Using oCmd As New SqlCommand(sSQL, CNDB)
                oCmd.ExecuteNonQuery()
            End Using
            XtraMessageBox.Show("Η εγγραφή διαγράφηκε με επιτυχία", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Information)
            'Frm.SUP_ORDERSDTableAdapter.Fill(Frm.DMDataSet.SUP_ORDERSD)
            Frm.Vw_SUP_ORDERSDTableAdapter.FillBysupOrderID(Frm.DMDataSet.vw_SUP_ORDERSD, System.Guid.Parse(ID))
        End If
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
    Public Sub OpenFiles()
        Try
            Dim sSQL As String
            Dim cmd As SqlCommand
            Dim sdr As SqlDataReader
            Dim bytes As Byte()
            Dim sFileName As String
            Dim sID As String = Frm.GridView3.GetRowCellValue(Frm.GridView3.FocusedRowHandle, "ID").ToString
            sSQL = "Select filename, files From SUP_ORDERS_F  WHERE supOrderDID = " & toSQLValueS(sID)
            cmd = New SqlCommand(sSQL, CNDB) : sdr = cmd.ExecuteReader()

            While sdr.Read()
                sFileName = sdr.GetString(sdr.GetOrdinal("filename").ToString).ToString
                Dim fs As IO.FileStream = New IO.FileStream(ProgProps.TempFolderPath & sFileName, IO.FileMode.Create)
                bytes = DirectCast(sdr("files"), Byte())
                fs.Write(bytes, 0, bytes.Length)
                fs.Close()
                ShellExecute(ProgProps.TempFolderPath & sFileName)
            End While
            sdr.Close()
        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Public Sub SendEmail(ByVal sID As String, sEmailTo As String, sSupID As String)
        Dim Cmd As SqlCommand, sdr As SqlDataReader
        Dim Emails As New SendEmail
        'Dim sEmailsTo() As String, sSupID() As String
        Dim statusMsg As String = ""
        Dim sSubject As String
        Dim sBody As String
        Dim sFile As String = ""
        Dim sSQL As String
        Dim Attachments As Dictionary(Of String, String)
        Try

            'sEmailTo = Frm.txtTo.EditValue
            sBody = Frm.txtBody.EditValue
            sSubject = Frm.txtSubject.EditValue

            'sEmailsTo = Frm.txtTo.EditValue.ToString.Split(";")
            'sSupID = Frm.txtTo.Tag.ToString.Split(";")
            Dim sIndex As Int16 = 0
            'For Each sEmailTo In sEmailsTo
            If sEmailTo.Length > 0 Then
                If CNDB.Database <> "DreamyKitchen" Or Debugger.IsAttached = True Then sEmailTo = "johnmavroselinos@gmail.com"

                'Συσκευές
                If sComeFrom = 4 Then sFile = ExportDevicesReport(sSupID)
                'Αρχική
                If sComeFrom = 0 Then Attachments = New Dictionary(Of String, String) : Attachments.Add(sID, "SUP_ORDERS_F")

                If Emails.SendEmail(ProgProps.EmailOrdersFrom, sSubject, sBody, sEmailTo, sFile, statusMsg, Attachments) = True Then
                    sSQL = "Update SUP_ORDERS SET email = 1,DateOfEmail=getdate() WHERE ID = " & toSQLValueS(ID)
                    Cmd = New SqlCommand(sSQL, CNDB) : Cmd.ExecuteNonQuery()

                    ' Εισαγωγή ιστορικού email
                    sSQL = "INSERT INTO SUP_ORDERS_MAIL (supOrderID,supOrderDID,emailFrom,emailTo,emailSubject,emailBody,DateofEmail,[createdBy],[createdOn])  
                        values (" & toSQLValueS(ID) & "," & toSQLValueS(sID) & "," & toSQLValueS(ProgProps.SupportEmail.ToString) & "," &
                        toSQLValueS(sEmailTo) & "," & toSQLValue(Frm.txtSubject) & "," &
                        toSQLValue(Frm.txtBody) & ",getdate(), " &
                        toSQLValueS(UserProps.ID.ToString) & ", getdate() )"
                    Using oCmd As New SqlCommand(sSQL, CNDB)
                        oCmd.ExecuteNonQuery()
                    End Using
                Else
                    XtraMessageBox.Show("Παρουσιάστηκε πρόβλημα με σφάλμα " & statusMsg, ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
            sIndex = sIndex + 1
            'Next




        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Function ExportDevicesReport(ByVal sSupID As String) As String
        Dim sfile As String
        sfile = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) & "\Downloads\Έντυπο Παραγγελίας Συσκευών.pdf"
        Dim report As New RepCUSDevices()
        report.Parameters.Item(0).Value = sFields("ID")
        report.Parameters.Item(1).Value = sSupID

        report.CreateDocument()
        report.ExportToPdf(sfile)
        report.Dispose()
        report = Nothing
        My.Computer.FileSystem.CopyFile(sfile, ProgProps.ServerPath & Path.GetFileName(sfile), True)
        Return ProgProps.ServerPath & Path.GetFileName(sfile)
    End Function
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
        ElseIf sComeFrom = 4 Then
            For i As Integer = 0 To Frm.GridView3.DataRowCount - 1
                Dim report As New RepCUSDevices
                report.Parameters.Item(0).Value = sFields("ID")
                report.Parameters.Item(1).Value = Frm.GridView3.GetRowCellValue(i, "supID").ToString
                report.CreateDocument()
                Dim printTool As New ReportPrintTool(report)
                printTool.ShowRibbonPreview()
            Next i


        End If
    End Sub
    Public Sub ValidateEmail()
        If Frm.txtBody.Text = "" Then XtraMessageBox.Show("Παρακαλώ συμπληρώστε κείμενο", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error) : Exit Sub
        If Frm.txtSubject.Text = "" Then XtraMessageBox.Show("Παρακαλώ συμπληρώστε το θέμα", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error) : Exit Sub
        If Frm.txtTo.Text = "" Then XtraMessageBox.Show("Δεν υπάρχει καταχωρήμενο email στον προμηθευτή.", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error) : Exit Sub
        Select Case sComeFrom
            Case 0 'Αρχική
                If XtraMessageBox.Show("Θέλετε να αποσταλεί το Email με όλα τα επισυναπτόμενα αρχεία ?", ProgProps.ProgTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                    For i As Integer = 0 To Frm.GridView3.DataRowCount - 1
                        SendEmail(Frm.GridView3.GetRowCellValue(i, "ID").ToString, Frm.GridView3.GetRowCellValue(i, "email").ToString, Frm.GridView3.GetRowCellValue(i, "supID").ToString)
                    Next i
                    Frm.SUP_ORDERS_MAILTableAdapter.FillBYSupOrderID(Frm.DMDataSet.SUP_ORDERS_MAIL, System.Guid.Parse(ID))
                End If

            Case 1
            Case 2
            Case 3
            Case 4
                If XtraMessageBox.Show("Θέλετε να αποσταλεί το Email την παραγγελία ?", ProgProps.ProgTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                    For i As Integer = 0 To Frm.GridView3.DataRowCount - 1
                        SendEmail(Frm.GridView3.GetRowCellValue(i, "ID").ToString, Frm.GridView3.GetRowCellValue(i, "email").ToString, Frm.GridView3.GetRowCellValue(i, "supID").ToString)
                    Next i
                    Frm.SUP_ORDERS_MAILTableAdapter.FillBYSupOrderID(Frm.DMDataSet.SUP_ORDERS_MAIL, System.Guid.Parse(ID))
                End If

        End Select
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
    Public Sub EmailTabSelected()
        Prog_Prop.GetProgEmailSupFROM()
        'Prog_Prop.GetProgEmailSupTO()
        Dim supID As String : Frm.txtTo.EditValue = GetSupplierEmails(supID) : Frm.txtTo.Tag = supID
        If ID IsNot Nothing Then Frm.SUP_ORDERS_MAILTableAdapter.FillBYSupOrderID(Frm.DMDataSet.SUP_ORDERS_MAIL, System.Guid.Parse(ID))
        LoadForms.RestoreLayoutFromXml(Frm.GridView2, "SUP_ORDERS_MAIL_def.xml")
    End Sub
    Private Function GetSupplierEmails(ByRef supID As String) As String
        Try
            Dim Cmd As SqlCommand, sdr As SqlDataReader
            Cmd = New SqlCommand("Select email,supID FROM SUP inner join dbo.SUP_ORDERSD SOD on SOD.supID=SUP.id WHERE email is not null and supOrderID= " & toSQLValueS(ID), CNDB)
            sdr = Cmd.ExecuteReader()
            GetSupplierEmails = ""
            If sdr.HasRows Then
                While sdr.Read()
                    If GetSupplierEmails.Contains(sdr.GetString(sdr.GetOrdinal("email"))) = False Then
                        GetSupplierEmails = GetSupplierEmails & IIf(GetSupplierEmails <> "", ";", "") & sdr.GetString(sdr.GetOrdinal("email"))
                        supID = supID & IIf(supID <> "", ";", "") & sdr.GetGuid(sdr.GetOrdinal("supID")).ToString
                    End If
                End While
            End If
            sdr.Close()
            Return GetSupplierEmails
        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function
End Class
