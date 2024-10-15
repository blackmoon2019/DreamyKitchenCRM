Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraReports.UI
Imports System.Data.SqlClient
Imports System.IO

Public Class InstEllipse
    Private Frm As frmInstEllipse
    Private DBQ As New DBQueries
    Private LoadForms As New FormLoader
    Private FillCbo As New FillCombos
    Private Valid As New ValidateControls
    Private ScanFile As ScanToPDF
    Private Prog_Prop As New ProgProp
    Private UserPermissions As New CheckPermissions
    Public Mode As Byte
    Private ID As String
    Private sINST_ID As String
    Private ConnectedOrderID As String = ""
    Private SaveButtonPressed As Boolean = False
    Private sComeFrom As Int16
    Private semailMode As Int16 = 0
    Private HasConnectedOrder As Boolean = False

    Public Property INST_ID() As String
        Get
            Return sINST_ID
        End Get
        Set(value As String)
            sINST_ID = value
        End Set
    End Property
    Public Property ComeFrom() As Int16
        Get
            Return sComeFrom
        End Get
        Set(value As Int16)
            sComeFrom = value
        End Set
    End Property
    Public Property emailMode() As Int16
        Get
            Return semailMode
        End Get
        Set(value As Int16)
            semailMode = value
        End Set
    End Property

    Public Sub Initialize(ByVal sFrm As frmInstEllipse, ByVal sInstEllipseID As String, ByVal sMode As Byte)

        Frm = sFrm
        ID = sInstEllipseID
        Mode = sMode
        Frm.Vw_FILE_CATTableAdapter.Fill(Frm.DreamyKitchenDataSet.vw_FILE_CAT)
        Frm.Vw_ORDER_MANAGERSTableAdapter.Fill(Frm.DreamyKitchenDataSet.vw_ORDER_MANAGERS)
        Frm.Vw_SUPTableAdapter.Fill(Frm.DreamyKitchenDataSet.vw_SUP)
        Frm.CCT_TRANSHTableAdapter.Fill(Frm.DM_TRANS.CCT_TRANSH)
        AddHandler Frm.GridControl1.EmbeddedNavigator.ButtonClick, AddressOf Grid_EmbeddedNavigator_ButtonClick
        UserPermissions.GetUserPermissions("Εκρεμότητες Έργων από Τοποθέτηση")
    End Sub
    Public Sub LoadForm()
        FillCbo.INST(Frm.cboINST)
        Select Case Mode
            Case FormMode.NewRecord
                If sComeFrom = 0 Then NewRecord() : Frm.cmdViewOrder.Enabled = False
                Frm.TabNavigationPage2.Enabled = False
            Case FormMode.EditRecord
                SaveButtonPressed = True
                Dim sFields As New Dictionary(Of String, String)
                LoadForms.LoadForm(Frm.LayoutControl1, "Select * from vw_INST_ELLIPSE where id =" & toSQLValueS(ID), sFields)
                If sFields("comeFrom") = "False" Then sComeFrom = 0 Else sComeFrom = 1
                FillCbo.FillCheckedListINST_ELLIPSE_SER(Frm.chkSER, FormMode.EditRecord, ID)
                Frm.INST_ELLIPSE_JOBSTableAdapter.FillBYinstEllipseID(Frm.DmDataSet.INST_ELLIPSE_JOBS, System.Guid.Parse(ID))
                If sINST_ID Is Nothing Then sINST_ID = Frm.cboINST.EditValue.ToString
                'Αφορά μόνο τον πελάτη και ελέγχει αν υπάρχει έλλειψη πριν την τελευταία . Αν υπάρχει δεν μπορεί να την επεξεργαστεί αυτήν
                If sComeFrom = 0 Then
                    If CheckIfHasOtherElllipse() Then Frm.LayoutControl1.Enabled = False
                    If CheckIfHasConnectedOrder() = True Then Frm.cmdConvertToOrder.Text = "Ενημέρωση Παραγγελίας" : HasConnectedOrder = True : 
                Else
                    ConnectedOrderID = ID
                End If
                Frm.txtInstellipseFilename.ReadOnly = False
                Frm.txtInstellipseFilenameD.ReadOnly = False
                Frm.txtInstellipseFilenameC.ReadOnly = False
                Frm.txtInstellipseFilenameSC.ReadOnly = False
                Frm.GridControl1.ForceInitialize()
                If Frm.GridView1.DataRowCount = 0 Then Frm.cmdSendEmail.Enabled = False : Frm.cmdPrintAll.Enabled = False : Frm.cmdSendApointmentEmail.Enabled = False : Frm.cmdDefEmail.Enabled = False
                If sFields("completed") = "True" Then Frm.dtDateDelivered.Enabled = False : Frm.txtTmINFrom.Enabled = False : Frm.txtTmINTo.Enabled = False : Frm.chkSER.Enabled = False
                If sFields("emailInfComplete") = "True" Then DisabletxtInstellipseFilenameComplete()
        End Select
        Frm.LInst.Enabled = False
        If sComeFrom = 1 Then
            Frm.LayoutControlGroup1.Text = "Αφορά Προμηθευτή"
            Frm.chkSER.Enabled = False : Frm.LdtDateDelivered.Enabled = False : Frm.LTmINFrom.Enabled = False : Frm.LTmINTo.Enabled = False
            Frm.cmdNewInstEllipse.Enabled = False
            DisabletxtInstellipseFilename() : DisabletxtInstellipseFilenameComplete()
            Frm.GridView1.OptionsBehavior.Editable = True : Frm.cmdViewOrder.Enabled = False : Frm.cmdConvertToOrder.Enabled = False
            LoadForms.RestoreLayoutFromXml(Frm.GridView1, "INST_ELLIPSE_JOBS_def_SUP.xml")
        Else
            Frm.LayoutControlGroup1.Text = "Αφορά Πελάτη"
            Frm.LCus.Enabled = False
            Frm.cboTRANSH.Properties.Buttons.Item(0).Enabled = False
            Frm.cboTRANSH.Properties.Buttons.Item(1).Enabled = False
            Frm.cboTRANSH.Properties.Buttons.Item(2).Enabled = True
            Frm.cboTRANSH.Properties.Buttons.Item(3).Enabled = False
            Frm.cboTRANSH.ReadOnly = True
            If Frm.dtDateDelivered.EditValue IsNot Nothing And
                (Frm.txtInstellipseFilename.EditValue IsNot Nothing Or Frm.txtInstellipseFilenameD.EditValue IsNot Nothing Or
                Frm.txtInstellipseFilenameC.EditValue IsNot Nothing Or Frm.txtInstellipseFilenameSC.EditValue IsNot Nothing) Then DisabletxtInstellipseFilename()
            LoadForms.RestoreLayoutFromXml(Frm.GridView1, "INST_ELLIPSE_JOBS_def.xml")
        End If


        Frm.cmdSave.Enabled = IIf(Mode = FormMode.NewRecord, UserProps.AllowInsert, UserProps.AllowEdit)

    End Sub
    Public Sub SaveRecord(ByRef sID As String)
        Dim sResult As Boolean
        Dim sSQL As String
        Try
            If Valid.ValidateForm(Frm.LayoutControl1) Then
                ' Έλεγχος επισύναψης εντύπου
                'If CheckIfInstEllipseFExist() = False Then Exit Sub
                Select Case Mode
                    Case FormMode.NewRecord
                        sID = System.Guid.NewGuid.ToString
                        ' Έλεγχος επισύναψης εντύπου και καταχώρησης εκκρεμοτήτων
                        If ValidateRecord() Then sResult = DBQ.InsertNewData(DBQueries.InsertMode.OneLayoutControl, "INST_ELLIPSE", Frm.LayoutControl1,,, sID, True, "comefrom", sComeFrom)
                    Case FormMode.EditRecord
                        If sComeFrom = 0 Then
                            If ValidateRecord() Then sResult = DBQ.UpdateNewData(DBQueries.InsertMode.OneLayoutControl, "INST_ELLIPSE", Frm.LayoutControl1,,, sID, True)
                        Else
                            If sComeFrom = 1 And CheckIfSupplierExist() = False Then
                                XtraMessageBox.Show("Καμμία Εκκρεμότητα δεν έχει προμηθευτή.", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
                                Exit Sub
                            End If
                            sResult = DBQ.UpdateNewData(DBQueries.InsertMode.OneLayoutControl, "INST_ELLIPSE", Frm.LayoutControl1,,, sID, True)
                        End If
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
                    For Each item As DevExpress.XtraEditors.Controls.CheckedListBoxItem In Frm.chkSER.CheckedItems
                        sSQL = "INSERT INTO INST_ELLIPSE_SER (instEllipseID,empID,[createdBy],[createdOn]) values (" & toSQLValueS(sID) & "," & toSQLValueS(item.Tag.ToString()) & "," & toSQLValueS(UserProps.ID.ToString) & ", getdate() )"
                        Using oCmd As New SqlCommand(sSQL, CNDB)
                            oCmd.ExecuteNonQuery()
                        End Using
                    Next
                    FillCbo.FillCheckedListINST_ELLIPSE_SER(Frm.chkSER, FormMode.EditRecord, sID)
                    SaveButtonPressed = True : Frm.cmdNewInstEllipse.Enabled = True : Frm.TabNavigationPage2.Enabled = True
                    XtraMessageBox.Show("Η εγγραφή αποθηκέυτηκε με επιτυχία", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Public Sub SaveRecordF(ByVal sMode As Integer, Optional ByVal sFilename As String = "")
        Dim sResultF As Boolean
        If Frm.cboTanshFCategory.EditValue = Nothing Then XtraMessageBox.Show("Δεν έχετε επιλέξει Κατηγορία.", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error) : Exit Sub
        If Frm.txtFiles.Text = "" Then XtraMessageBox.Show("Δεν έχετε επιλέξει Αρχείο.", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error) : Exit Sub
        Select Case sMode
            Case 0 : sResultF = DBQ.InsertDataFiles(Frm.XtraOpenFileDialog1, Frm.cboTRANSH.EditValue.ToString, "TRANSH_F", ID, "Αρχεία Εκκρεμοτήτων")
            Case 1 : sResultF = DBQ.InsertDataFilesFromScanner(sFilename, Frm.cboTRANSH.EditValue.ToString, "TRANSH_F", Frm.cboTanshFCategory.EditValue.ToString, ID, "Αρχεία Εκκρεμοτήτων")
        End Select
        Frm.txtFiles.EditValue = Nothing
        Frm.TRANSH_FTableAdapter.FillByTranshID(Frm.DM_TRANS.TRANSH_F, System.Guid.Parse(Frm.cboTRANSH.EditValue.ToString))
    End Sub

    Public Sub NewRecord()
        'Έλεγχος για να δεί αν υπάρχει μη ολοκληρωμένη έλλειψη πριν ανοίξει καινούρια γιαυτην την τοποθέτηση 
        If CheckIfHasInstNotCompleted() = True Then XtraMessageBox.Show("Δεν μπορείτε να δημιουργήσετε νέα εγγραφή όταν υπάρχει μη ολοκληρωμένη εκκρεμότητα.", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error) : Exit Sub
        'Eλεγχος αν υπάρχουν ολοκληρωμένες εκκρεμότητες για να συνεχίσει
        '     If CheckIfHasCompletedInstJobs() = True Then XtraMessageBox.Show("Δεν μπορείτε να δημιουργήσετε νέα εγγραφή όταν όλες οι εργασίες-εκκρεμότητες είναι μη ολοκληρωμένες.", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error) : Exit Sub
        'Eλεγχος αν στην έλλειψη έχει καταχωρηθεί ημερομηνία τοποθέτησης
        'If CheckIfEllipseHasDateDelivered() = False Then XtraMessageBox.Show("Δεν μπορείτε να δημιουργήσετε νέα εγγραφή όταν δεν έχει καταχωρηθεί Ημερ/νία Τοποθέτησης.", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error) : Exit Sub
        'Eλεγχος αν υπάρχει έντυπο ολοκλήρωσης
        If CheckIfEllipseHasCompleteDocument() = True Then XtraMessageBox.Show("Δεν μπορείτε να δημιουργήσετε νέα εγγραφή, έχουν ολοκληρωθεί όλες οι εκκρεμότητες.", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error) : Exit Sub
        ' Κάνει ολοκληρωμένη την ελλέιψη τις συγκεκριμένης τοποθέτησης
        If SetInstEllipseCompleted() = False Then Exit Sub
        ID = System.Guid.NewGuid.ToString
        'Καταχώρηση συνεργείων και εκκρεμοτήτων που έμειναν ανολοκλήρωτες στην νέα έλλειψη
        Insert_EllipseSer_EllipseJobs_InstEllipse()
        Frm.dtDateDelivered.EditValue = Nothing : Frm.txtTmINFrom.EditValue = "00:00" : Frm.txtTmINTo.EditValue = "00:00" : Frm.dtReceipt.EditValue = Nothing : Frm.chkCompleted.CheckState = CheckState.Unchecked
        Frm.txtComments.EditValue = Nothing : Frm.cmdConvertToOrder.Enabled = False : Frm.cmdViewOrder.Enabled = False
        Frm.txtInstellipseFilename.EditValue = Nothing : Frm.txtInstellipseFilenameD.EditValue = Nothing
        Frm.txtInstellipseFilenameC.EditValue = Nothing : Frm.txtInstellipseFilenameSC.EditValue = Nothing
        AddRecord()
    End Sub


    Public Sub DeleteRecord()
        If Frm.GridView1.FocusedRowHandle < 0 Then
            XtraMessageBox.Show("Δεν μπορείτε να διαγράψετε εγγραφή που επεξεργάζεστε. Αν θέλετε να φύγετε από την εγγραφή πατήστε ESC", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        If Frm.GridView1.GetRowCellValue(Frm.GridView1.FocusedRowHandle, "ID") = Nothing Then Exit Sub
        If XtraMessageBox.Show("Θέλετε να διαγραφεί η τρέχουσα εγγραφή?", ProgProps.ProgTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            Dim sSQL As String = "DELETE FROM INST_ELLIPSE_JOBS WHERE ID = '" & Frm.GridView1.GetRowCellValue(Frm.GridView1.FocusedRowHandle, "ID").ToString & "'"
            Using oCmd As New SqlCommand(sSQL, CNDB)
                oCmd.ExecuteNonQuery()
            End Using
            Frm.INST_ELLIPSE_JOBSTableAdapter.FillBYinstEllipseID(Frm.DmDataSet.INST_ELLIPSE_JOBS, System.Guid.Parse(ID))
        End If
    End Sub

    Public Sub Grid_EmbeddedNavigator_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.NavigatorButtonClickEventArgs)
        Select Case e.Button.ButtonType
            Case e.Button.ButtonType.Remove : DeleteRecord() : e.Handled = True
            Case e.Button.ButtonType.Append
                If Frm.txtInstellipseFilename.EditValue = Nothing And Frm.txtInstellipseFilenameD.EditValue = Nothing And Frm.txtInstellipseFilenameC.EditValue = Nothing And Frm.txtInstellipseFilenameSC.EditValue = Nothing Then
                    XtraMessageBox.Show("Δεν έχετε επισυνάψει έντυπο εκκρεμοτήτων.", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
                    e.Handled = True
                End If
        End Select
    End Sub
    Private Function ValidateRecord() As Boolean
        Frm.GridControl1.ForceInitialize()
        If CheckIfTimeisValid() = False Then Return False
        If Frm.GridView1.DataRowCount = 0 Then
            XtraMessageBox.Show("Δεν έχετε καταχωρήσει εκκρεμότητες. Δεν μπορεί να αποθηκευθεί η εγγραφή.", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If
        If Frm.txtInstellipseFilename.EditValue = Nothing And Frm.txtInstellipseFilenameD.EditValue = Nothing And Frm.txtInstellipseFilenameC.EditValue = Nothing And Frm.txtInstellipseFilenameSC.EditValue = Nothing Then
            XtraMessageBox.Show("Δεν έχετε επισυνάψει έντυπο εκκρεμοτήτων. Δεν μπορεί να αποθηκευθεί η εγγραφή.", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If
        If Frm.dtDateDelivered.EditValue IsNot Nothing And Frm.chkSER.CheckedItemsCount = 0 Then
            XtraMessageBox.Show("Έχετε επιλέξει ημερομηνία τοποθέτησης χωρίς να επιλέξετε συνεργείο. Δεν μπορεί να αποθηκευθεί η εγγραφή.", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If
        If Frm.chkCompleted.CheckState = CheckState.Checked And Frm.dtDateDelivered.EditValue = Nothing Then
            XtraMessageBox.Show("Δεν μπορείτε να ολοκληρώσετε την εκκρεμότητα χωρίς ημερομηνία επίσκεψης. Δεν μπορεί να αποθηκευθεί η εγγραφή.", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If
        If CheckIfInstJobsAreCompleted() And Frm.txtInstellipseFilenameComplete.EditValue = Nothing Then
            XtraMessageBox.Show("Έχετε ολοκληρώσει όλες τις εργασίες και δεν έχετε επισυνάψει το έντυπο ολοκλήρωσης. Δεν μπορεί να αποθηκευθεί η εγγραφή.", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If
        If sComeFrom = 1 And CheckIfSupplierExist() = False Then
            XtraMessageBox.Show("Καμμία Εκκρεμότητα δεν έχει προμηθευτή.", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If
        Return True
    End Function

    Private Function CheckIfEllipseHasDateDelivered() As Boolean
        Dim Cmd As SqlCommand, sdr As SqlDataReader
        Dim sSQL As String
        sSQL = "SELECT count (id) as CountEllipse  FROM INST_ELLIPSE WHERE DateDelivered is not null and ID= " & toSQLValueS(ID)
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
        sSQL = "SELECT fInstEllipseNameComplete FROM INST_ELLIPSE WHERE ID= " & toSQLValueS(ID)
        Cmd = New SqlCommand(sSQL.ToString, CNDB)
        sdr = Cmd.ExecuteReader()
        Dim fInstEllipseNameComplete As String
        If (sdr.Read() = True) Then
            If sdr.IsDBNull(sdr.GetOrdinal("fInstEllipseNameComplete")) = False Then fInstEllipseNameComplete = sdr.GetString(sdr.GetOrdinal("fInstEllipseNameComplete")) Else fInstEllipseNameComplete = ""
            If fInstEllipseNameComplete <> "" Then Return True Else Return False
        End If
        sdr.Close()
    End Function

    Private Function CheckIfHasInstNotCompleted() As Boolean
        Dim Cmd As SqlCommand, sdr As SqlDataReader
        Dim sSQL As String
        sSQL = "SELECT id FROM INST_ELLIPSE WHERE completed = 0  and instID= " & toSQLValueS(ID)
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
    Public Function CheckIfInstJobsAreCompleted() As Boolean
        Dim Cmd As SqlCommand, sdr As SqlDataReader
        Dim sSQL As String
        sSQL = "SELECT id as CountJobEllipse  FROM INST_ELLIPSE_JOBS WHERE completed = 0 and instEllipseID= " & toSQLValueS(ID)
        Cmd = New SqlCommand(sSQL.ToString, CNDB)
        sdr = Cmd.ExecuteReader()
        Dim CountJobEllipse As String
        If (sdr.Read() = True) Then
            If sdr.IsDBNull(sdr.GetOrdinal("CountJobEllipse")) = False Then CountJobEllipse = sdr.GetGuid(sdr.GetOrdinal("CountJobEllipse")).ToString Else CountJobEllipse = ""
            sdr.Close()
            If CountJobEllipse <> "" Then Return False Else Return True
        Else
            sdr.Close()
            Return True
        End If
    End Function
    Private Function CheckIfHasInstJobsForOrder() As Boolean
        Dim Cmd As SqlCommand, sdr As SqlDataReader
        Dim sSQL As String
        sSQL = "SELECT top 1 id as toOrderID FROM INST_ELLIPSE_JOBS WHERE toOrder = 1 and instEllipseID= " & toSQLValueS(ID)
        Cmd = New SqlCommand(sSQL.ToString, CNDB)
        sdr = Cmd.ExecuteReader()
        Dim toOrderID As String
        If (sdr.Read() = True) Then
            If sdr.IsDBNull(sdr.GetOrdinal("toOrderID")) = False Then toOrderID = sdr.GetGuid(sdr.GetOrdinal("toOrderID")).ToString Else toOrderID = ""
            sdr.Close()
            If toOrderID <> "" Then Return True Else Return False
        Else
            sdr.Close()
            Return False
        End If
    End Function


    Private Sub Insert_EllipseSer_EllipseJobs_InstEllipse()
        Try
            Dim sSQL As String
            Dim LastEllipseID As String = GetLastEllipseID()

            ' Μεταφέρει ότι άλλη εκκρεμότητα υπάρχει ανολοκλήρωτη στην καινούρια έλλειψη 
            sSQL = "INSERT INTO INST_ELLIPSE_JOBS ([ID],[instEllipseID],[instID], [name], [cmt], [completed], [dtCompleted],  [createdOn], [createdBy]) " &
                    "SELECT NEWID()," & toSQLValueS(ID) & " ,  " & toSQLValueS(sINST_ID) & ", [name], IEJ.[cmt], IEJ.[completed], [dtCompleted],  IEJ.[createdOn], IEJ.[createdBy] " &
                    "from INST I " &
                    "inner join INST_ELLIPSE IE on IE.id= " & toSQLValueS(LastEllipseID) &
                    " INNER  join INST_ELLIPSE_JOBS  IEJ ON IEJ.instEllipseID =IE.ID " &
                    "WHERE IE.comefrom = 0 and  IEJ.completed=0 And I.[ID]= " & toSQLValueS(sINST_ID)
            Using oCmd As New SqlCommand(sSQL, CNDB)
                oCmd.ExecuteNonQuery()
            End Using
            Frm.INST_ELLIPSE_JOBSTableAdapter.FillBYinstEllipseID(Frm.DmDataSet.INST_ELLIPSE_JOBS, System.Guid.Parse(ID))
            Frm.txtInstellipseFilename.ReadOnly = False : Frm.txtInstellipseFilenameD.ReadOnly = False
            Frm.txtInstellipseFilenameC.ReadOnly = False : Frm.txtInstellipseFilenameSC.ReadOnly = False
            Frm.GridView1.OptionsBehavior.Editable = True
            Mode = FormMode.EditRecord
        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Function CheckIfTimeisValid() As Boolean
        If Frm.dtDateDelivered.EditValue IsNot Nothing Then
            If Frm.txtTmINFrom.Text = "00:00" Or Frm.txtTmINTo.Text = "00:00" Then XtraMessageBox.Show("Η ώρα δεν μπορεί να είναι 00:00", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error) : Return False
            Frm.txtTmINFrom.EditValue = Frm.txtTmINFrom.Text : Frm.txtTmINTo.EditValue = Frm.txtTmINTo.Text
            Dim Hours As Long = DateDiff(DateInterval.Hour, Frm.txtTmINFrom.EditValue, Frm.txtTmINTo.EditValue)
            If Hours < 0 Then XtraMessageBox.Show("Η ώρα ΑΠΟ δεν μπορεί να είναι μικρότερη από την ΕΩΣ", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error) : Return False
        End If
        Return True
    End Function

    Private Function GetLastEllipseID() As String
        Dim Cmd As SqlCommand, sdr As SqlDataReader
        Cmd = New SqlCommand("Select TOP 1 IE.id, MAX(ie.createdOn) as createdOn  FROM INST_ELLIPSE IE WHERE comefrom=0 and IE.instID= " & toSQLValueS(sINST_ID) & " group by IE.ID ORDER BY createdOn DESC ", CNDB)
        sdr = Cmd.ExecuteReader()
        If (sdr.Read() = True) Then GetLastEllipseID = sdr.GetGuid(sdr.GetOrdinal("ID")).ToString.ToUpper
        sdr.Close()
        Return GetLastEllipseID
    End Function
    Private Function CheckIfInstEllipseFExist() As Boolean
        Dim sFilename As String = ""
        If Frm.chkCompleted.Checked = True Then
            Dim Cmd As SqlCommand, sdr As SqlDataReader
            Dim sSQL As String = "SELECT fInstEllipseName  FROM INST_ELLIPSE WHERE ID= " & toSQLValueS(ID)
            Cmd = New SqlCommand(sSQL.ToString, CNDB)
            sdr = Cmd.ExecuteReader()
            If (sdr.Read() = True) Then
                If sdr.IsDBNull(sdr.GetOrdinal("fInstEllipseName")) = False Then sFilename = sdr.GetString(sdr.GetOrdinal("fInstEllipseName"))
                If sFilename = "" Then
                    XtraMessageBox.Show("Δεν μπορείτε να ολοκληρώσετε την Εκκρεμότητα χωρίς να επισυνάψετε έντυπο", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
                    sdr.Close()
                    Return False
                Else
                    sdr.Close()
                    Return True
                End If
            Else
                XtraMessageBox.Show("Δεν μπορείτε να ολοκληρώσετε την Εκκρεμότητα χωρίς να επισυνάψετε έντυπο", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            End If
        Else
            Return True
        End If
    End Function
    Private Function SetInstEllipseCompleted() As Boolean
        Dim sSQL As String
        Try
            sSQL = "UPDATE INST_ELLIPSE SET COMPLETED = 1 WHERE ID = " & toSQLValueS(ID)
            Using oCmd As New SqlCommand(sSQL, CNDB)
                oCmd.ExecuteNonQuery()
            End Using
            Return True
        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try

    End Function
    Private Function CheckIfHasCompletedInstJobs() As Boolean
        Dim Cmd As SqlCommand, sdr As SqlDataReader
        Dim sSQL As String
        sSQL = "SELECT top 1 id as JobEllipseid FROM INST_ELLIPSE_JOBS WHERE completed = 1 and instEllipseID= " & toSQLValueS(ID)
        Cmd = New SqlCommand(sSQL.ToString, CNDB)
        sdr = Cmd.ExecuteReader()
        Dim JobEllipseid As String
        If (sdr.Read() = True) Then
            If sdr.IsDBNull(sdr.GetOrdinal("JobEllipseid")) = False Then JobEllipseid = sdr.GetGuid(sdr.GetOrdinal("JobEllipseid")).ToString Else JobEllipseid = ""
            If JobEllipseid <> "" Then Return True Else Return False
        Else
            Return False
        End If
        sdr.Close()
    End Function
    Public Function ValidationsExit() As Boolean
        If ID = Nothing Then Return False
        If SaveButtonPressed = False Then
            If XtraMessageBox.Show("Θέλετε να σώσετε την εγγραφή?", ProgProps.ProgTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbNo Then
                Dim sSQL As String = "DELETE FROM INST_ELLIPSE WHERE ID = '" & ID & "'"
                Using oCmd As New SqlCommand(sSQL, CNDB)
                    oCmd.ExecuteNonQuery()
                End Using
            End If
        End If
        If sComeFrom = 0 Then If CheckForInstName() = False Then Return False
        If HasConnectedOrder = False And sComeFrom = 0 Then If CheckIfHasRecordsForOrder() = True Then Return False
        If sComeFrom = 0 Then
            If Frm.GridView1.DataRowCount > 0 Then
                'If CheckIfHasSendInfEmail() = False Then Return False
                If CheckIfInstJobsAreCompleted() = True And Frm.txtInstellipseFilenameComplete.EditValue = Nothing Then
                    XtraMessageBox.Show("Όλες οι εκκρεμότητες είναι ολοκληρωμένες χωρίς να έχετε επισυνάψει έντυπο ολοκλήρωσης. Δεν μπορεί να αποθηκευθεί η εγγραφή.", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return False
                End If
            End If

            If CheckIfHasSendInfCompleteEmail() = False Then Return False
        End If
        Return True
    End Function
    Private Function CheckIfSupplierExist()
        Dim Cmd As SqlCommand, sdr As SqlDataReader
        Dim sSQL As String
        sSQL = "SELECT top 1 supID  FROM INST_ELLIPSE_JOBS WHERE supID is null and instEllipseID= " & toSQLValueS(ID)
        Cmd = New SqlCommand(sSQL.ToString, CNDB)
        sdr = Cmd.ExecuteReader()
        Dim supID As String
        If (sdr.Read() = True) Then
            If sdr.IsDBNull(sdr.GetOrdinal("supID")) = False Then supID = sdr.GetGuid(sdr.GetOrdinal("supID")).ToString Else supID = ""
            If supID <> "" Then Return True Else Return False
        Else
            Return True
        End If
        sdr.Close()
    End Function
    Private Function CheckForInstName() As Boolean
        If Frm.GridView1.DataRowCount > 0 And
            Frm.txtInstellipseFilename.EditValue Is Nothing And Frm.txtInstellipseFilenameD.EditValue Is Nothing And
            Frm.txtInstellipseFilenameC.EditValue Is Nothing And Frm.txtInstellipseFilenameSC.EditValue Is Nothing Then
            XtraMessageBox.Show("Έχετε καταχωρήσει εκκρεμότητες χωρίς να έχετε επισυνάψει έντυπο ολοκλήρωσης. ", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        Else
            Return True
        End If
    End Function

    Private Sub DisabletxtInstellipseFilename()
        Frm.txtInstellipseFilename.ReadOnly = True
        Frm.txtInstellipseFilename.Properties.Buttons.Item(0).Enabled = False
        Frm.txtInstellipseFilename.Properties.Buttons.Item(1).Enabled = True
        Frm.txtInstellipseFilename.Properties.Buttons.Item(2).Enabled = False

        Frm.txtInstellipseFilenameD.ReadOnly = True
        Frm.txtInstellipseFilenameD.Properties.Buttons.Item(0).Enabled = False
        Frm.txtInstellipseFilenameD.Properties.Buttons.Item(1).Enabled = True
        Frm.txtInstellipseFilenameD.Properties.Buttons.Item(2).Enabled = False

        Frm.txtInstellipseFilenameC.ReadOnly = True
        Frm.txtInstellipseFilenameC.Properties.Buttons.Item(0).Enabled = False
        Frm.txtInstellipseFilenameC.Properties.Buttons.Item(1).Enabled = True
        Frm.txtInstellipseFilenameC.Properties.Buttons.Item(2).Enabled = False

        Frm.txtInstellipseFilenameSC.ReadOnly = True
        Frm.txtInstellipseFilenameSC.Properties.Buttons.Item(0).Enabled = False
        Frm.txtInstellipseFilenameSC.Properties.Buttons.Item(1).Enabled = True
        Frm.txtInstellipseFilenameSC.Properties.Buttons.Item(2).Enabled = False

    End Sub
    Private Sub EnabletxtInstellipseFilename()
        Frm.txtInstellipseFilename.ReadOnly = False
        Frm.txtInstellipseFilename.Properties.Buttons.Item(0).Enabled = True
        Frm.txtInstellipseFilename.Properties.Buttons.Item(1).Enabled = True
        Frm.txtInstellipseFilename.Properties.Buttons.Item(2).Enabled = True

        Frm.txtInstellipseFilenameD.ReadOnly = False
        Frm.txtInstellipseFilenameD.Properties.Buttons.Item(0).Enabled = True
        Frm.txtInstellipseFilenameD.Properties.Buttons.Item(1).Enabled = True
        Frm.txtInstellipseFilenameD.Properties.Buttons.Item(2).Enabled = True

        Frm.txtInstellipseFilenameC.ReadOnly = False
        Frm.txtInstellipseFilenameC.Properties.Buttons.Item(0).Enabled = True
        Frm.txtInstellipseFilenameC.Properties.Buttons.Item(1).Enabled = True
        Frm.txtInstellipseFilenameC.Properties.Buttons.Item(2).Enabled = True

        Frm.txtInstellipseFilenameSC.ReadOnly = False
        Frm.txtInstellipseFilenameSC.Properties.Buttons.Item(0).Enabled = True
        Frm.txtInstellipseFilenameSC.Properties.Buttons.Item(1).Enabled = True
        Frm.txtInstellipseFilenameSC.Properties.Buttons.Item(2).Enabled = True
    End Sub
    Private Sub DisabletxtInstellipseFilenameComplete()
        Frm.txtInstellipseFilenameComplete.ReadOnly = True
        Frm.txtInstellipseFilenameComplete.Properties.Buttons.Item(0).Enabled = False
        Frm.txtInstellipseFilenameComplete.Properties.Buttons.Item(1).Enabled = True
        Frm.txtInstellipseFilenameComplete.Properties.Buttons.Item(2).Enabled = False
    End Sub
    Private Sub EnabletxtInstellipseFilenameComplete()
        Frm.txtInstellipseFilenameComplete.ReadOnly = False
        Frm.txtInstellipseFilenameComplete.Properties.Buttons.Item(0).Enabled = True
        Frm.txtInstellipseFilenameComplete.Properties.Buttons.Item(1).Enabled = True
        Frm.txtInstellipseFilenameComplete.Properties.Buttons.Item(2).Enabled = True
    End Sub

    Private Function CheckIfHasConnectedOrder() As Boolean
        Dim Cmd As SqlCommand, sdr As SqlDataReader
        Dim sSQL As String
        sSQL = "SELECT top 1 id as connectedEllipseID FROM INST_ELLIPSE WHERE connectedEllipseID = " & toSQLValueS(ID)
        Cmd = New SqlCommand(sSQL.ToString, CNDB)
        sdr = Cmd.ExecuteReader()
        Dim connectedEllipseID As String
        If (sdr.Read() = True) Then
            If sdr.IsDBNull(sdr.GetOrdinal("connectedEllipseID")) = False Then connectedEllipseID = sdr.GetGuid(sdr.GetOrdinal("connectedEllipseID")).ToString Else connectedEllipseID = ""
            If connectedEllipseID <> "" Then
                ConnectedOrderID = connectedEllipseID : Frm.cmdViewOrder.Enabled = True
                Return True
            Else
                Frm.cmdViewOrder.Enabled = False
                Return False
            End If
        Else
            Frm.cmdViewOrder.Enabled = False
            Return False
        End If
        sdr.Close()

    End Function
    Private Function CheckIfHasOtherElllipse() As Boolean
        Dim Cmd As SqlCommand, sdr As SqlDataReader
        Dim sSQL As New System.Text.StringBuilder
        sSQL.AppendLine("SELECT count (id) as CountEllipse  FROM INST_ELLIPSE WHERE ID= " & toSQLValueS(ID) & " and createdOn<(select max(createdon) from INST_ELLIPSE WHERE comefrom = 0 and instID= " & toSQLValueS(sINST_ID) & ")")
        Cmd = New SqlCommand(sSQL.ToString, CNDB)
        sdr = Cmd.ExecuteReader()
        Dim CountEllipse As Integer
        If (sdr.Read() = True) Then
            If sdr.IsDBNull(sdr.GetOrdinal("CountEllipse")) = False Then CountEllipse = sdr.GetInt32(sdr.GetOrdinal("CountEllipse")) Else CountEllipse = 0
            sdr.Close()
            If CountEllipse > 0 Then Return True Else Return False
        End If
        Return False

    End Function
    Private Function CheckIfHasRecordsForOrder() As Boolean
        Dim Cmd As SqlCommand, sdr As SqlDataReader
        Dim sSQL As New System.Text.StringBuilder
        sSQL.AppendLine("SELECT count (id) as CountEllipse  FROM INST_ELLIPSE_JOBS 
                         WHERE instEllipseID= " & toSQLValueS(ID) & " and toOrder = 1 and " & toSQLValueS(ID) &
                         " Not In (Select Top 1 ID from INST_ELLIPSE  where connectedEllipseID = " & toSQLValueS(ID) & ")")
        Cmd = New SqlCommand(sSQL.ToString, CNDB)
        sdr = Cmd.ExecuteReader()
        Dim CountEllipse As Integer
        If (sdr.Read() = True) Then
            If sdr.IsDBNull(sdr.GetOrdinal("CountEllipse")) = False Then CountEllipse = sdr.GetInt32(sdr.GetOrdinal("CountEllipse")) Else CountEllipse = 0
            sdr.Close()
            If CountEllipse > 0 Then
                XtraMessageBox.Show("Υπάρχουν εκκρεμότητες προς παραγγελία. Παρακαλώ δημιουργήστε παραγγελία πριν την έξοδο.", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return True
            Else
                Return False
            End If
        End If
        Return False

    End Function
    Private Function CheckIfHasSendInfEmail() As Boolean
        Dim Cmd As SqlCommand, sdr As SqlDataReader
        Dim sSQL As New System.Text.StringBuilder
        sSQL.AppendLine("SELECT count (IE.id) as CountEllipse  
                        FROM INST_ELLIPSE_JOBS  IEJ
                        inner join INST_ELLIPSE  IE ON IE.ID = IEJ.instEllipseID 
                        WHERE instEllipseID= " & toSQLValueS(ID) & "  AND emailInf IS NOT NULL")
        Cmd = New SqlCommand(sSQL.ToString, CNDB)
        sdr = Cmd.ExecuteReader()
        Dim CountEllipse As Integer
        If (sdr.Read() = True) Then
            If sdr.IsDBNull(sdr.GetOrdinal("CountEllipse")) = False Then CountEllipse = sdr.GetInt32(sdr.GetOrdinal("CountEllipse")) Else CountEllipse = 0
            sdr.Close()
            If CountEllipse = 0 Then
                XtraMessageBox.Show("Παρακαλώ πολύ πρέπει να στείλετε eMail Ενημέρωσης Εκκρεμοτήτων στον πελάτη.", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            Else
                Return True
            End If
        Else
            Return True
        End If
    End Function

    Private Function CheckIfHasSendInfCompleteEmail() As Boolean
        Dim Cmd As SqlCommand, sdr As SqlDataReader
        Dim sSQL As New System.Text.StringBuilder
        sSQL.AppendLine("SELECT emailInfComplete
                        FROM INST_ELLIPSE  IE
                        WHERE ID= " & toSQLValueS(ID) & " AND IE.completed = 1 ")
        Cmd = New SqlCommand(sSQL.ToString, CNDB)
        sdr = Cmd.ExecuteReader()
        Dim emailInfComplete As Boolean
        If (sdr.Read() = True) Then
            If sdr.IsDBNull(sdr.GetOrdinal("emailInfComplete")) = False Then emailInfComplete = sdr.GetBoolean(sdr.GetOrdinal("emailInfComplete")) Else emailInfComplete = False
            sdr.Close()
            If emailInfComplete = False Then
                XtraMessageBox.Show("Παρακαλώ πολύ πρέπει να στείλετε eMail Ολοκλήρωσης Ενημέρωσης εκκρεμοτήτων στον πελάτη.", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            Else
                Return True
            End If
        Else
            Return True
        End If


    End Function

    Private Sub AddRecord()
        Try
            Frm.cmdNewInstEllipse.Enabled = False
            Frm.txtCode.Text = DBQ.GetNextId("INST_ELLIPSE")
            If sINST_ID IsNot Nothing Then Frm.cboINST.EditValue = System.Guid.Parse(sINST_ID)
            FillCbo.FillCheckedListINST_ELLIPSE_SER(Frm.chkSER, FormMode.NewRecord)
            Frm.cmdSendEmail.Enabled = False : Frm.cmdPrintAll.Enabled = False : Frm.cmdSendApointmentEmail.Enabled = False : Frm.cmdDefEmail.Enabled = False
            Frm.txtInstellipseFilename.ReadOnly = False : Frm.txtInstellipseFilenameD.ReadOnly = False
            Frm.txtInstellipseFilenameC.ReadOnly = False : Frm.txtInstellipseFilenameSC.ReadOnly = False
            EnabletxtInstellipseFilename() : EnabletxtInstellipseFilenameComplete()
            '΅Εισαγωγή εγγραφής απευθείας στην βάση
            Dim sResult As Boolean = DBQ.InsertNewData(DBQueries.InsertMode.OneLayoutControl, "INST_ELLIPSE", Frm.LayoutControl1,,, ID, True, "comefrom", sComeFrom)
            If sResult = False Then
                XtraMessageBox.Show("Υπήρξε πρόβλημα κατά την διαδικασία ανοίγματος εκκρεμότητας.", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Frm.Close()
            End If
            Mode = FormMode.EditRecord
        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Public Sub GridView5ValidateRow(e As ValidateRowEventArgs)
        Dim sSQL As New System.Text.StringBuilder
        Try
            sSQL.Clear()
            sSQL.AppendLine("UPDATE TRANSH_F	SET FileCatID= " & toSQLValueS(Frm.GridView5.GetRowCellValue(Frm.GridView5.FocusedRowHandle, "fileCatID").ToString) & ",")
            sSQL.AppendLine("modifiedBY = " & toSQLValueS(UserProps.ID.ToString) & ",")
            sSQL.AppendLine("modifiedON = getdate() ")
            sSQL.AppendLine("WHERE ID = " & toSQLValueS(Frm.GridView5.GetRowCellValue(Frm.GridView5.FocusedRowHandle, "ID").ToString))
            'Εκτέλεση QUERY
            Using oCmd As New SqlCommand(sSQL.ToString, CNDB)
                oCmd.ExecuteNonQuery()
            End Using
        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Public Sub GridView1ValidateRow(e As ValidateRowEventArgs)
        Dim sSQL As New System.Text.StringBuilder
        Dim CompletedCell As String = "", sDate As String
        Dim missing As String, replacement As String, orderError As String, toOrder As String
        Try
            sSQL.Clear()
            If e.RowHandle = Frm.GridControl1.NewItemRowHandle Then
                If Frm.GridView1.GetRowCellValue(Frm.GridView1.FocusedRowHandle, "name").ToString = "" Then
                    e.ErrorText = "Παρακαλώ συμπληρώστε την έλλειψη"
                    e.Valid = False
                    Exit Sub
                End If
                sSQL.AppendLine("INSERT INTO INST_ELLIPSE_JOBS (instEllipseID,instID,supID,name,nameSup,cmt,completed,missing,replacement,orderError,toOrder,dtCompleted,[modifiedBy],[createdby],[createdOn])")
                sSQL.AppendLine("Select " & toSQLValueS(ID) & ",")
                sSQL.AppendLine(toSQLValueS(sINST_ID) & ",")
                sSQL.AppendLine(toSQLValueS(Frm.GridView1.GetRowCellValue(Frm.GridView1.FocusedRowHandle, "supID").ToString) & ",")
                sSQL.AppendLine(toSQLValueS(Frm.GridView1.GetRowCellValue(Frm.GridView1.FocusedRowHandle, "name").ToString) & ",")
                sSQL.AppendLine(toSQLValueS(Frm.GridView1.GetRowCellValue(Frm.GridView1.FocusedRowHandle, "nameSup").ToString) & ",")
                sSQL.AppendLine(toSQLValueS(Frm.GridView1.GetRowCellValue(Frm.GridView1.FocusedRowHandle, "cmt").ToString) & ",")
                CompletedCell = Frm.GridView1.GetRowCellValue(Frm.GridView1.FocusedRowHandle, "completed").ToString : If CompletedCell = "" Then CompletedCell = "0"
                sSQL.AppendLine("completed = " & toSQLValueS(CompletedCell) & ",")
                missing = Frm.GridView1.GetRowCellValue(Frm.GridView1.FocusedRowHandle, "missing").ToString : If missing = "" Then missing = "0"
                sSQL.AppendLine("missing = " & toSQLValueS(missing) & ",")
                replacement = Frm.GridView1.GetRowCellValue(Frm.GridView1.FocusedRowHandle, "replacement").ToString : If replacement = "" Then replacement = "0"
                sSQL.AppendLine("replacement = " & toSQLValueS(replacement) & ",")
                orderError = Frm.GridView1.GetRowCellValue(Frm.GridView1.FocusedRowHandle, "orderError").ToString : If orderError = "" Then orderError = "0"
                sSQL.AppendLine("orderError= " & toSQLValueS(orderError) & ",")
                toOrder = Frm.GridView1.GetRowCellValue(Frm.GridView1.FocusedRowHandle, "toOrder").ToString : If toOrder = "" Then toOrder = "0"
                sSQL.AppendLine("toOrder= " & toSQLValueS(toOrder) & ",")
                sDate = Frm.GridView1.GetRowCellValue(Frm.GridView1.FocusedRowHandle, "dtCompleted").ToString
                If sDate <> "" Then sDate = toSQLValueS(CDate(sDate).ToString("yyyyMMdd")) Else sDate = "NULL"
                sSQL.AppendLine(sDate & ",")
                sSQL.Append(toSQLValueS(UserProps.ID.ToString) & "," & toSQLValueS(UserProps.ID.ToString) & ", getdate()")
                'Εκτέλεση QUERY
                Using oCmd As New SqlCommand(sSQL.ToString, CNDB)
                    oCmd.ExecuteNonQuery()
                End Using
                Frm.INST_ELLIPSE_JOBSTableAdapter.FillBYinstEllipseID(Frm.DmDataSet.INST_ELLIPSE_JOBS, System.Guid.Parse(ID))
            Else
                sSQL.AppendLine("UPDATE INST_ELLIPSE_JOBS	SET name= " & toSQLValueS(Frm.GridView1.GetRowCellValue(Frm.GridView1.FocusedRowHandle, "name").ToString) & ",")
                sSQL.AppendLine("supID = " & toSQLValueS(Frm.GridView1.GetRowCellValue(Frm.GridView1.FocusedRowHandle, "supID").ToString) & ",")
                sSQL.AppendLine("nameSup = " & toSQLValueS(Frm.GridView1.GetRowCellValue(Frm.GridView1.FocusedRowHandle, "nameSup").ToString) & ",")
                sSQL.AppendLine("instID = " & toSQLValueS(sINST_ID) & ",")
                sSQL.AppendLine("modifiedBY = " & toSQLValueS(UserProps.ID.ToString) & ",")
                sSQL.AppendLine("cmt = " & toSQLValueS(Frm.GridView1.GetRowCellValue(Frm.GridView1.FocusedRowHandle, "cmt").ToString) & ",")
                CompletedCell = Frm.GridView1.GetRowCellValue(Frm.GridView1.FocusedRowHandle, "completed").ToString : If CompletedCell = "" Then CompletedCell = "0"
                sSQL.AppendLine("completed = " & toSQLValueS(CompletedCell) & ",")
                missing = Frm.GridView1.GetRowCellValue(Frm.GridView1.FocusedRowHandle, "missing").ToString : If missing = "" Then missing = "0"
                sSQL.AppendLine("missing= " & toSQLValueS(missing) & ",")
                replacement = Frm.GridView1.GetRowCellValue(Frm.GridView1.FocusedRowHandle, "replacement").ToString : If replacement = "" Then replacement = "0"
                sSQL.AppendLine("replacement = " & toSQLValueS(replacement) & ",")
                orderError = Frm.GridView1.GetRowCellValue(Frm.GridView1.FocusedRowHandle, "orderError").ToString : If orderError = "" Then orderError = "0"
                sSQL.AppendLine("orderError= " & toSQLValueS(orderError) & ",")
                toOrder = Frm.GridView1.GetRowCellValue(Frm.GridView1.FocusedRowHandle, "toOrder").ToString : If toOrder = "" Then toOrder = "0"
                sSQL.AppendLine("toOrder= " & toSQLValueS(toOrder) & ",")


                sDate = Frm.GridView1.GetRowCellValue(Frm.GridView1.FocusedRowHandle, "dtCompleted").ToString
                If sDate <> "" Then sDate = toSQLValueS(CDate(sDate).ToString("yyyyMMdd")) Else sDate = "NULL"
                sSQL.AppendLine("dtcompleted = " & sDate & ",")
                sSQL.AppendLine("modifiedON = getdate() ")
                sSQL.AppendLine("WHERE ID = " & toSQLValueS(Frm.GridView1.GetRowCellValue(Frm.GridView1.FocusedRowHandle, "ID").ToString))
                'Εκτέλεση QUERY
                Using oCmd As New SqlCommand(sSQL.ToString, CNDB)
                    oCmd.ExecuteNonQuery()
                End Using
                Frm.INST_ELLIPSE_JOBSTableAdapter.FillBYinstEllipseID(Frm.DmDataSet.INST_ELLIPSE_JOBS, System.Guid.Parse(ID))
            End If
            If Frm.GridView1.RowCount = 0 Then
                Frm.cmdSendEmail.Enabled = False : Frm.cmdPrintAll.Enabled = False : Frm.cmdSendApointmentEmail.Enabled = False : Frm.cmdDefEmail.Enabled = False
                If sComeFrom = 0 Then Frm.cmdConvertToOrder.Enabled = False
            Else
                Frm.cmdSendEmail.Enabled = True : Frm.cmdPrintAll.Enabled = True : Frm.cmdSendApointmentEmail.Enabled = True : Frm.cmdDefEmail.Enabled = True
                If sComeFrom = 0 Then Frm.cmdConvertToOrder.Enabled = True
            End If
        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
    Public Sub FileSelect(ByVal Mode As Int16)
        'XtraOpenFileDialog1.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*"
        Frm.XtraOpenFileDialog1.FilterIndex = 1
        Frm.XtraOpenFileDialog1.InitialDirectory = "C:\"
        Frm.XtraOpenFileDialog1.Title = "Open File"
        Frm.XtraOpenFileDialog1.CheckFileExists = False
        Frm.XtraOpenFileDialog1.Multiselect = False
        Dim result As DialogResult = Frm.XtraOpenFileDialog1.ShowDialog()
        If result = DialogResult.OK Then
            Try

                Dim sSQL As String

                My.Computer.FileSystem.CopyFile(Frm.XtraOpenFileDialog1.FileName, ProgProps.ServerPath & Path.GetFileName(Frm.XtraOpenFileDialog1.FileName), True)
                Select Case Mode
                    Case 0
                        Frm.txtInstellipseFilename.EditValue = Frm.XtraOpenFileDialog1.FileName
                        sSQL = "UPDATE INST_ELLIPSE SET  fInstEllipseName =  " & toSQLValueS(Path.GetFileName(Frm.XtraOpenFileDialog1.FileName).ToString) & ", fInstEllipse =  BulkColumn from Openrowset( Bulk " & toSQLValueS(ProgProps.ServerPath & Path.GetFileName(Frm.XtraOpenFileDialog1.FileName)) & ", Single_Blob) as InstEllipseF where ID = " & toSQLValueS(ID)
                    Case 1
                        Frm.txtInstellipseFilenameD.EditValue = Frm.XtraOpenFileDialog1.FileName
                        sSQL = "UPDATE INST_ELLIPSE SET  fInstEllipseNameD =  " & toSQLValueS(Path.GetFileName(Frm.XtraOpenFileDialog1.FileName).ToString) & ", fInstEllipseD =  BulkColumn from Openrowset( Bulk " & toSQLValueS(ProgProps.ServerPath & Path.GetFileName(Frm.XtraOpenFileDialog1.FileName)) & ", Single_Blob) as InstEllipseF where ID = " & toSQLValueS(ID)
                    Case 2
                        Frm.txtInstellipseFilenameC.EditValue = Frm.XtraOpenFileDialog1.FileName
                        sSQL = "UPDATE INST_ELLIPSE SET  fInstEllipseNameC =  " & toSQLValueS(Path.GetFileName(Frm.XtraOpenFileDialog1.FileName).ToString) & ", fInstEllipseC =  BulkColumn from Openrowset( Bulk " & toSQLValueS(ProgProps.ServerPath & Path.GetFileName(Frm.XtraOpenFileDialog1.FileName)) & ", Single_Blob) as InstEllipseF where ID = " & toSQLValueS(ID)
                    Case 3
                        Frm.txtInstellipseFilenameSC.EditValue = Frm.XtraOpenFileDialog1.FileName
                        sSQL = "UPDATE INST_ELLIPSE SET  fInstEllipseNameSC =  " & toSQLValueS(Path.GetFileName(Frm.XtraOpenFileDialog1.FileName).ToString) & ", fInstEllipseSC =  BulkColumn from Openrowset( Bulk " & toSQLValueS(ProgProps.ServerPath & Path.GetFileName(Frm.XtraOpenFileDialog1.FileName)) & ", Single_Blob) as InstEllipseF where ID = " & toSQLValueS(ID)
                    Case 4
                        Frm.txtInstellipseFilenameComplete.EditValue = Frm.XtraOpenFileDialog1.FileName
                        sSQL = "UPDATE INST_ELLIPSE SET completed = 1 ,fInstEllipseNameComplete =  " & toSQLValueS(Path.GetFileName(Frm.XtraOpenFileDialog1.FileName).ToString) & ", fInstEllipseComplete =  BulkColumn from Openrowset( Bulk " & toSQLValueS(ProgProps.ServerPath & Path.GetFileName(Frm.XtraOpenFileDialog1.FileName)) & ", Single_Blob) as InstEllipseF where ID = " & toSQLValueS(ID)
                End Select

                'Εκτέλεση QUERY
                Using oCmd As New SqlCommand(sSQL, CNDB)
                    oCmd.ExecuteNonQuery()
                End Using
                If Mode = 4 Then
                    Frm.chkCompleted.CheckState = CheckState.Checked : Frm.GridView1.OptionsBehavior.Editable = False
                    Frm.cmdNewInstEllipse.Enabled = False : DisabletxtInstellipseFilename() ' txtInstellipseFilename.Enabled = False
                End If
                XtraMessageBox.Show("Το αρχείο αποθηκεύτηκε με επιτυχία", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub
    Public Sub OpenFile(ByVal Mode As Int16)
        Try
            Select Case Mode
                Case 0

                    Dim Cmd As SqlCommand, sdr As SqlDataReader
                    Dim sSQL As String = "SELECT fInstEllipse,fInstEllipseName  FROM INST_ELLIPSE WHERE comefrom=0 and ID= " & toSQLValueS(ID)
                    Cmd = New SqlCommand(sSQL.ToString, CNDB)
                    sdr = Cmd.ExecuteReader()
                    If (sdr.Read() = True) Then
                        If sdr.IsDBNull(sdr.GetOrdinal("fInstEllipseName")) = False Then
                            Dim sFilename = Path.GetFileName(sdr.GetString(sdr.GetOrdinal("fInstEllipseName")))
                            Dim fs As IO.FileStream = New IO.FileStream(ProgProps.TempFolderPath & sFilename, IO.FileMode.Create)
                            Dim b As Byte()
                            b = DirectCast(sdr("fInstEllipse"), Byte())
                            fs.Write(b, 0, b.Length)
                            fs.Close()
                            ShellExecute(ProgProps.TempFolderPath & sFilename)
                        End If
                    End If
                    sdr.Close()
                Case 1
                    Try
                        Dim Cmd As SqlCommand, sdr As SqlDataReader
                        Dim sSQL As String = "SELECT fInstEllipseD,fInstEllipseNameD  FROM INST_ELLIPSE WHERE comefrom=0 and ID= " & toSQLValueS(ID)
                        Cmd = New SqlCommand(sSQL.ToString, CNDB)
                        sdr = Cmd.ExecuteReader()
                        If (sdr.Read() = True) Then
                            If sdr.IsDBNull(sdr.GetOrdinal("fInstEllipseNameD")) = False Then
                                Dim sFilename = Path.GetFileName(sdr.GetString(sdr.GetOrdinal("fInstEllipseNameD")))
                                Dim fs As IO.FileStream = New IO.FileStream(ProgProps.TempFolderPath & sFilename, IO.FileMode.Create)
                                Dim b As Byte()
                                b = DirectCast(sdr("fInstEllipseD"), Byte())
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
                Case 2
                    Try
                        Dim Cmd As SqlCommand, sdr As SqlDataReader
                        Dim sSQL As String = "SELECT fInstEllipseC,fInstEllipseNameC  FROM INST_ELLIPSE WHERE comefrom=0 and ID= " & toSQLValueS(ID)
                        Cmd = New SqlCommand(sSQL.ToString, CNDB)
                        sdr = Cmd.ExecuteReader()
                        If (sdr.Read() = True) Then
                            If sdr.IsDBNull(sdr.GetOrdinal("fInstEllipseNameC")) = False Then
                                Dim sFilename = Path.GetFileName(sdr.GetString(sdr.GetOrdinal("fInstEllipseNameC")))
                                Dim fs As IO.FileStream = New IO.FileStream(ProgProps.TempFolderPath & sFilename, IO.FileMode.Create)
                                Dim b As Byte()
                                b = DirectCast(sdr("fInstEllipseC"), Byte())
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
                Case 3
                    Try
                        Dim Cmd As SqlCommand, sdr As SqlDataReader
                        Dim sSQL As String = "SELECT fInstEllipseSC,fInstEllipseNameSC  FROM INST_ELLIPSE WHERE comefrom=0 and ID= " & toSQLValueS(ID)
                        Cmd = New SqlCommand(sSQL.ToString, CNDB)
                        sdr = Cmd.ExecuteReader()
                        If (sdr.Read() = True) Then
                            If sdr.IsDBNull(sdr.GetOrdinal("fInstEllipseNameSC")) = False Then
                                Dim sFilename = Path.GetFileName(sdr.GetString(sdr.GetOrdinal("fInstEllipseNameSC")))
                                Dim fs As IO.FileStream = New IO.FileStream(ProgProps.TempFolderPath & sFilename, IO.FileMode.Create)
                                Dim b As Byte()
                                b = DirectCast(sdr("fInstEllipseSC"), Byte())
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
                Case 4
                    Try
                        Dim Cmd As SqlCommand, sdr As SqlDataReader
                        Dim sSQL As String = "SELECT fInstEllipseComplete,fInstEllipseNameComplete  FROM INST_ELLIPSE WHERE comefrom=0 and ID= " & toSQLValueS(ID)
                        Cmd = New SqlCommand(sSQL.ToString, CNDB)
                        sdr = Cmd.ExecuteReader()
                        If (sdr.Read() = True) Then
                            If sdr.IsDBNull(sdr.GetOrdinal("fInstEllipseNameComplete")) = False Then
                                Dim sFilename = Path.GetFileName(sdr.GetString(sdr.GetOrdinal("fInstEllipseNameComplete")))
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
                        XtraMessageBox.Show(String.Format("Error: {0}", exfs.Message), ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Finally

                    End Try
            End Select
        Catch exfs As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", exfs.Message), ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally

        End Try
    End Sub
    Public Sub DeleteFile(ByVal Mode As Int16)
        Select Case Mode
            Case 0
                If Frm.txtInstellipseFilename.EditValue = Nothing Then Exit Sub
                If XtraMessageBox.Show("Θέλετε να διαγραφεί το αρχείο?", ProgProps.ProgTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                    Dim sSQL As String
                    sSQL = "UPDATE INST_ELLIPSE SET fInstEllipseName =  NULL ,fInstEllipse =  NULL where ID = " & toSQLValueS(ID)
                    'Εκτέλεση QUERY
                    Using oCmd As New SqlCommand(sSQL, CNDB)
                        oCmd.ExecuteNonQuery()
                    End Using
                    Frm.txtInstellipseFilename.EditValue = Nothing
                End If
            Case 1
                If Frm.txtInstellipseFilenameD.EditValue = Nothing Then Exit Sub
                If XtraMessageBox.Show("Θέλετε να διαγραφεί το αρχείο?", ProgProps.ProgTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                    Dim sSQL As String
                    sSQL = "UPDATE INST_ELLIPSE SET fInstEllipseNameD =  NULL ,fInstEllipseD =  NULL where ID = " & toSQLValueS(ID)
                    'Εκτέλεση QUERY
                    Using oCmd As New SqlCommand(sSQL, CNDB)
                        oCmd.ExecuteNonQuery()
                    End Using
                    Frm.txtInstellipseFilenameD.EditValue = Nothing
                End If
            Case 2
                If Frm.txtInstellipseFilenameC.EditValue = Nothing Then Exit Sub
                If XtraMessageBox.Show("Θέλετε να διαγραφεί το αρχείο?", ProgProps.ProgTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                    Dim sSQL As String
                    sSQL = "UPDATE INST_ELLIPSE SET fInstEllipseNameC =  NULL ,fInstEllipseC =  NULL where ID = " & toSQLValueS(ID)
                    'Εκτέλεση QUERY
                    Using oCmd As New SqlCommand(sSQL, CNDB)
                        oCmd.ExecuteNonQuery()
                    End Using
                    Frm.txtInstellipseFilenameC.EditValue = Nothing
                End If
            Case 3
                If Frm.txtInstellipseFilenameSC.EditValue = Nothing Then Exit Sub
                If XtraMessageBox.Show("Θέλετε να διαγραφεί το αρχείο?", ProgProps.ProgTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                    Dim sSQL As String
                    sSQL = "UPDATE INST_ELLIPSE SET fInstEllipseNameSC =  NULL ,fInstEllipseSC =  NULL where ID = " & toSQLValueS(ID)
                    'Εκτέλεση QUERY
                    Using oCmd As New SqlCommand(sSQL, CNDB)
                        oCmd.ExecuteNonQuery()
                    End Using
                    Frm.txtInstellipseFilenameSC.EditValue = Nothing
                End If
            Case 4
                If Frm.txtInstellipseFilenameComplete.EditValue = Nothing Then Exit Sub
                If XtraMessageBox.Show("Θέλετε να διαγραφεί το αρχείο?", ProgProps.ProgTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                    Dim sSQL As String
                    sSQL = "UPDATE INST_ELLIPSE SET fInstEllipseNameComplete =  NULL ,fInstEllipseComplete =  NULL where ID = " & toSQLValueS(ID)
                    'Εκτέλεση QUERY
                    Using oCmd As New SqlCommand(sSQL, CNDB)
                        oCmd.ExecuteNonQuery()
                    End Using
                    sSQL = "UPDATE INST_ELLIPSE SET completed = 0 where ID = " & toSQLValueS(ID)
                    'Εκτέλεση QUERY
                    Using oCmd As New SqlCommand(sSQL, CNDB)
                        oCmd.ExecuteNonQuery()
                    End Using
                    Frm.chkCompleted.CheckState = CheckState.Unchecked
                    Frm.GridView1.OptionsBehavior.Editable = True
                    Frm.txtInstellipseFilenameComplete.EditValue = Nothing
                    Frm.cmdNewInstEllipse.Enabled = True : Frm.txtInstellipseFilename.ReadOnly = False
                    Frm.txtInstellipseFilenameD.ReadOnly = False : Frm.txtInstellipseFilenameC.ReadOnly = False
                    Frm.txtInstellipseFilenameSC.ReadOnly = False
                End If
        End Select
    End Sub
    Private Sub SendEmailExportReport()
        If sComeFrom = 1 Then SendEmailSup() Else SendEmailCus()
    End Sub
    Private Sub SendEmailSup()
        Try
            Dim Cmd As SqlCommand, sdr As SqlDataReader
            Dim Emails As New SendEmail
            Dim statusMsg As String, sEmailTo As String, sEmailsTo() As String, sSupID() As String
            Dim sSubject As String, sBody As String, sFile As String, sSQL As String




            sEmailsTo = Frm.txtTo.EditValue.ToString.Split(";")
            sSupID = Frm.txtTo.Tag.ToString.Split(";")
            Dim sIndex As Int16 = 0
            For Each sEmailTo In sEmailsTo
                Dim report As New RepCUSEllipseForSUP()
                report.Parameters.Item(0).Value = ID
                If sEmailTo.Length > 0 Then
                    report.Parameters.Item(1).Value = sSupID(sIndex)

                    sBody = Frm.txtBody.EditValue
                    sSubject = Frm.txtSubject.EditValue
                    sBody = sBody.Replace("{INST_ELLIPSE_DATE_DELIVERED}", Date.Now.Date)
                    sBody = sBody.Replace("{CUS}", Frm.cboCUS.Text)
                    sFile = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) & "\Downloads\Ενημερώτικό έντυπο εκκρεμοτήτων προμηθευτή.pdf"
                    report.CreateDocument()
                    report.ExportToPdf(sFile)
                    report.Dispose()
                    report = Nothing
                    My.Computer.FileSystem.CopyFile(sFile, ProgProps.ServerPath & Path.GetFileName(sFile), True)
                    If CNDB.Database <> "DreamyKitchen" Or Debugger.IsAttached = True Then sEmailTo = "johnmavroselinos@gmail.com;dreamykitchen@gmail.com"

                    If Emails.SendEmail(ProgProps.InstEllipseEmailAccountSupFrom, sSubject, sBody, sEmailTo, sFile, statusMsg) = True Then
                        Select Case emailMode
                            Case 1 : sSQL = "Update INST_ELLIPSE SET emailApp = 1,DateOfEmailApp=getdate() WHERE ID = " & toSQLValueS(ID)
                            Case 2 : sSQL = "Update INST_ELLIPSE SET emailInf = 1,DateOfEmailInf=getdate() WHERE ID = " & toSQLValueS(ID)
                            Case 3 : sSQL = "Update INST_ELLIPSE SET emailInfComplete = 1,DateOfEmailInfComplete=getdate() WHERE ID = " & toSQLValueS(ID)
                        End Select

                        Cmd = New SqlCommand(sSQL, CNDB) : Cmd.ExecuteNonQuery()

                        ' Εισαγωγή ιστορικού email
                        sSQL = "INSERT INTO INST_MAIL (instID,instEllipseID,emailFrom,emailTo,emailSubject,emailBody,DateofEmail,[createdBy],[createdOn],ComeFrom,emailMode,Attachment)  
                        Select " & toSQLValueS(sINST_ID) & "," & toSQLValueS(ID) & "," & toSQLValueS(ProgProps.InstEllipseEmailAccountSupFrom) & "," &
                                        toSQLValueS(sEmailTo) & "," & toSQLValue(Frm.txtSubject) & "," &
                                        toSQLValue(Frm.txtBody) & ",getdate(), " &
                                        toSQLValueS(UserProps.ID.ToString) & ", getdate(), " & sComeFrom & "," & emailMode & ",  * FROM  Openrowset( Bulk " & toSQLValueS(ProgProps.ServerPath & Path.GetFileName(sFile)) & ", Single_Blob) as F;"
                        Using oCmd As New SqlCommand(sSQL, CNDB)
                            oCmd.ExecuteNonQuery()
                        End Using
                    Else
                        XtraMessageBox.Show("Παρουσιάστηκε πρόβλημα με σφάλμα " & statusMsg, ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End If
                sIndex = sIndex + 1
            Next
        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub SendEmailCus()
        Try
            Dim Cmd As SqlCommand, sdr As SqlDataReader
            Dim Emails As New SendEmail
            Dim statusMsg As String, sEmailTo As String, sSubject As String, sBody As String, sFile As String, sSQL As String
            Dim report As New RepCUSEllipse()
            report.Parameters.Item(0).Value = ID
            sEmailTo = Frm.txtTo.EditValue
            sBody = Frm.txtBody.EditValue
            sBody = sBody.Replace("{INST_ELLIPSE_DATE_DELIVERED}", Frm.dtDateDelivered.Text)
            sBody = sBody.Replace("{INST_DATE_DELIVERED}", Frm.cboINST.GetColumnValue("dtDeliverDate").ToString())
            sBody = sBody.Replace("{INST_ELLIPSE_TIME_FROM}", Frm.txtTmINFrom.Text)
            sBody = sBody.Replace("{INST_ELLIPSE_TIME_TO}", Frm.txtTmINTo.Text)
            sSubject = Frm.txtSubject.EditValue
            sFile = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) & "\Downloads\Ενημερώτικό έντυπο εκκρεμοτήτων.pdf"
            report.CreateDocument()
            report.ExportToPdf(sFile)
            report.Dispose()
            report = Nothing
            My.Computer.FileSystem.CopyFile(sFile, ProgProps.ServerPath & Path.GetFileName(sFile), True)
            If CNDB.Database <> "DreamyKitchen" Or Debugger.IsAttached = True Then sEmailTo = "johnmavroselinos@gmail.com;dreamykitchen@gmail.com"


            If Emails.SendEmail(ProgProps.InstEmailAccountFrom, sSubject, sBody, sEmailTo, sFile, statusMsg) = True Then
                Select Case emailMode
                    Case 1 : sSQL = "Update INST_ELLIPSE SET emailApp = 1,DateOfEmailApp=getdate() WHERE ID = " & toSQLValueS(ID)
                    Case 2 : sSQL = "Update INST_ELLIPSE SET emailInf = 1,DateOfEmailInf=getdate() WHERE ID = " & toSQLValueS(ID)
                    Case 3 : sSQL = "Update INST_ELLIPSE SET emailInfComplete = 1,DateOfEmailInfComplete=getdate() WHERE ID = " & toSQLValueS(ID)
                End Select

                Cmd = New SqlCommand(sSQL, CNDB) : Cmd.ExecuteNonQuery()

                ' Εισαγωγή ιστορικού email
                sSQL = "INSERT INTO INST_MAIL (instID,instEllipseID,emailFrom,emailTo,emailSubject,emailBody,DateofEmail,[createdBy],[createdOn],ComeFrom,emailMode,Attachment)  
                        Select " & toSQLValueS(sINST_ID) & "," & toSQLValueS(ID) & "," & toSQLValueS(ProgProps.InstEmailAccountFrom) & "," &
                                    toSQLValue(Frm.txtTo) & "," & toSQLValue(Frm.txtSubject) & "," &
                                    toSQLValue(Frm.txtBody) & ",getdate(), " &
                                    toSQLValueS(UserProps.ID.ToString) & ", getdate(), " & sComeFrom & "," & emailMode & ",  * FROM  Openrowset( Bulk " & toSQLValueS(ProgProps.ServerPath & Path.GetFileName(sFile)) & ", Single_Blob) as F;"
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
    Public Sub PrintDocument()
        If sComeFrom = 1 Then PrintDocumentSUP() Else PrintDocumentCUS()
    End Sub
    Private Sub PrintDocumentSUP()
        Dim supID As String, sSupID() As String : GetSupplierEmails(supID) : Frm.txtTo.Tag = supID
        sSupID = Frm.txtTo.Tag.ToString.Split(";")
        For Each supID In sSupID
            Dim report As New RepCUSEllipseForSUP
            report.Parameters.Item(0).Value = ID
            report.Parameters.Item(1).Value = supID
            report.CreateDocument()
            Dim printTool As New ReportPrintTool(report)
            printTool.ShowRibbonPreview()
        Next
    End Sub
    Private Sub PrintDocumentCUS()
        Dim report As New RepCUSEllipse
        report.Parameters.Item(0).Value = ID
        report.CreateDocument()
        Dim printTool As New ReportPrintTool(report)
        printTool.ShowRibbonPreview()
    End Sub
    Public Sub ConvertToOrder()
        Try
            If SaveButtonPressed = False Then
                XtraMessageBox.Show("Δεν έχετε αποθηκέυση την εκκρεμότητα. Παρακαλώ κάντε κλίκ στο  ""Αποθήκευση"".", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            If CheckIfInstJobsAreCompleted() Then
                XtraMessageBox.Show("Όλες οι εκρεμμότητες είναι ολοκληρωμένες. Δεν μπορεί να αποθηκευθεί η εγγραφή.", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            If CheckIfSupplierExist() = False Then
                XtraMessageBox.Show("Όλες οι προς παραγγελία εκκρεμότητες πρέπει να έχουν προμηθευτή.", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            If HasConnectedOrder Then
                Using oCmd As New SqlCommand("CloneINSTELLIPSEJOBS", CNDB)
                    oCmd.CommandType = CommandType.StoredProcedure
                    oCmd.Parameters.AddWithValue("@InstEllipseID", ID)
                    oCmd.ExecuteNonQuery()
                End Using
                XtraMessageBox.Show("Η παραγγελία επαναδημιουργήθηκε με επιτυχία.", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Information)
                If CheckIfHasConnectedOrder() = True Then Frm.cmdConvertToOrder.Text = "Ενημέρωση Παραγγελίας" : HasConnectedOrder = True : 
            Else

                If Frm.GridView1.DataRowCount = 0 Then
                    XtraMessageBox.Show("Δεν έχετε καταχωρήσει εκκρεμότητες. Δεν μπορεί να αποθηκευθεί η εγγραφή.", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
                If CheckIfHasInstJobsForOrder() = False Then
                    XtraMessageBox.Show("Δεν έχετε επιλέξει εκκρεμότητες προς Παραγγελία. Δεν μπορεί να γίνει η μετατροπή.", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
                If CheckIfSupplierExist() = False Then
                    XtraMessageBox.Show("Όλες οι προς παραγγελία εκκρεμότητες πρέπει να έχουν προμηθευτή.", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
                If XtraMessageBox.Show("Θέλετε να μετατραπούν οι εκκρεμότητες σε παραγγελία?", ProgProps.ProgTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                    Using oCmd As New SqlCommand("cloneINSTELLIPSE", CNDB)
                        oCmd.CommandType = CommandType.StoredProcedure
                        oCmd.Parameters.AddWithValue("@InstEllipseID", ID)
                        oCmd.Parameters.AddWithValue("@empID", Frm.cboEMP.EditValue.ToString)
                        oCmd.ExecuteNonQuery()
                    End Using
                    XtraMessageBox.Show("Η παραγγελία δημιουργήθηκε με επιτυχία.", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    If CheckIfHasConnectedOrder() = True Then Frm.cmdConvertToOrder.Text = "Ενημέρωση Παραγγελίας" : HasConnectedOrder = True : 
                End If
            End If
        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
    Public Sub EmailTabSelected()
        Prog_Prop.GetProgEmailInstAndEllipse()

        If sComeFrom = 0 Then
            Frm.txtSubject.EditValue = ProgProps.InstEllipseInfSubject
            Frm.txtTo.EditValue = Frm.cboINST.GetColumnValue("email") ' Email Πελάτη
            If Frm.txtInstellipseFilenameComplete.EditValue IsNot Nothing Then
                Frm.cmdSendEmailComplete.Enabled = True : Frm.DefInstComplete.Enabled = True
            Else
                Frm.cmdSendEmailComplete.Enabled = False : Frm.DefInstComplete.Enabled = False
            End If
            If Frm.txtInstellipseFilename.EditValue IsNot Nothing Or Frm.txtInstellipseFilenameD.EditValue IsNot Nothing Or
                     Frm.txtInstellipseFilenameC.EditValue IsNot Nothing Or Frm.txtInstellipseFilenameSC.EditValue IsNot Nothing Then
                Frm.cmdSendEmail.Enabled = True : Frm.DefInst.Enabled = True
            End If
        Else
            Dim supID As String : Frm.txtTo.EditValue = GetSupplierEmails(supID) : Frm.txtTo.Tag = supID
            Frm.txtSubject.EditValue = ProgProps.InstEllipseInfSubjectSup
            Frm.txtBody.EditValue = ProgProps.InstEllipseInfBodySup.Replace("{CUS}", Frm.cboCUS.Text)
            Frm.txtSubject.EditValue = ProgProps.PJInfSubjectSup
            Frm.DefInstAppointment.Enabled = False : Frm.DefInstAppointment.Enabled = False : Frm.DefInstComplete.Enabled = False
            Frm.cmdSendEmailComplete.Enabled = False
        End If
        Frm.cmdDefEmail.Enabled = True
        If Frm.dtDateDelivered.EditValue = Nothing Or Frm.txtTmINFrom.EditValue = "00:00" Or Frm.txtTmINTo.EditValue = "00:00" Then Frm.cmdSendApointmentEmail.Enabled = False : Frm.DefInstAppointment.Enabled = False Else Frm.cmdSendApointmentEmail.Enabled = True : Frm.DefInstAppointment.Enabled = True
        Frm.INST_MAILTableAdapter.FillByinstEllipseID(Frm.DmDataSet.INST_MAIL, System.Guid.Parse(ID))
        LoadForms.RestoreLayoutFromXml(Frm.GridView3, "INST_MAIL_ELLIPSE.xml")
    End Sub
    Private Function GetSupplierEmails(ByRef supID As String) As String
        Try
            Dim Cmd As SqlCommand, sdr As SqlDataReader
            Cmd = New SqlCommand("Select email,supID FROM SUP inner join inst_ellipse_jobs IEJ on IEJ.supID=SUP.id WHERE toOrder=1 and email is not null and instEllipseID= " & toSQLValueS(ID), CNDB)
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
    Public Sub FilesTabSelected()
        LoadForms.RestoreLayoutFromXml(Frm.GridView5, "vw_TRANSH_F_INST_ELLIPSE_def.xml")
        Frm.GridView5.Columns.Item("belongsTo").OptionsColumn.AllowEdit = False
        If Frm.cboTRANSH.EditValue IsNot Nothing Then Frm.TRANSH_FTableAdapter.FillByTranshID(Frm.DM_TRANS.TRANSH_F, System.Guid.Parse(Frm.cboTRANSH.EditValue.ToString))
    End Sub
    Public Sub ViewOrder()
        Dim frmInstEllipse As New frmInstEllipse
        frmInstEllipse.Text = "Εκκρεμότητες Έργων"
        frmInstEllipse.Mode = FormMode.EditRecord
        frmInstEllipse.ID = ConnectedOrderID
        frmInstEllipse.INST_ID = sINST_ID
        frmInstEllipse.CalledFromControl = False
        frmInstEllipse.ComeFrom = 1
        'frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(frmInstEllipse), New Point(CInt(frmInstEllipse.Parent.ClientRectangle.Width / 2 - frmInstEllipse.Width / 2), CInt(frmInstEllipse.Parent.ClientRectangle.Height / 2 - frmInstEllipse.Height / 2)))
        frmInstEllipse.ShowDialog()
    End Sub
    Public Sub OpenEmailAttachment()
        Dim Cmd As SqlCommand, sdr As SqlDataReader
        Dim sSQL As String = "SELECT Attachment  FROM INST_MAIL WHERE ID= " & toSQLValueS(Frm.GridView3.GetRowCellValue(Frm.GridView3.FocusedRowHandle, "ID").ToString)
        Cmd = New SqlCommand(sSQL.ToString, CNDB)
        sdr = Cmd.ExecuteReader()
        If (sdr.Read() = True) Then
            If sdr.IsDBNull(sdr.GetOrdinal("Attachment")) = False Then
                Dim sFilename = "ATTACHMENT.PDF"
                Dim fs As IO.FileStream = New IO.FileStream(ProgProps.TempFolderPath & sFilename, IO.FileMode.Create)
                Dim b As Byte()
                b = DirectCast(sdr("Attachment"), Byte())
                fs.Write(b, 0, b.Length)
                fs.Close()
                ShellExecute(ProgProps.TempFolderPath & sFilename)
            End If
        End If
        sdr.Close()

    End Sub
    Public Sub ScanFiles()
        Dim sFilename As String
        Dim result = XtraInputBox.Show("Πληκτρολογήστε το πλήθος σελίδων που θα σκανάρετε", "Όνομα Αρχείου", "1")
        ScanFile = New ScanToPDF
        If ScanFile.Scan(sFilename, Frm.VwSCANFILENAMESBindingSource, result) = False Then Exit Sub
        Frm.txtFiles.EditValue = sFilename
        If Frm.txtFiles.Text <> "" Then SaveRecordF(1, sFilename)
        ScanFile = Nothing
    End Sub
    Public Sub ValidateEmail()
        If Frm.GridView1.RowCount = 0 Then XtraMessageBox.Show("Δεν υπάρχουν εκκρεμότητες προς αποστολή", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error) : Exit Sub
        If Frm.txtBody.Text = "" Then XtraMessageBox.Show("Παρακαλώ συμπληρώστε κείμενο", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error) : Exit Sub
        If Frm.txtSubject.Text = "" Then XtraMessageBox.Show("Παρακαλώ συμπληρώστε το θέμα", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error) : Exit Sub
        If Frm.txtTo.Text = "" Then XtraMessageBox.Show("Δεν υπάρχει καταχωρήμενο email στον " & IIf(sComeFrom = 0, " πελάτη.", " προμηθευτή."), ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error) : Exit Sub
        If XtraMessageBox.Show("Θέλετε να αποσταλεί το Email?", ProgProps.ProgTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            SendEmailExportReport()
            Frm.INST_MAILTableAdapter.FillByinstEllipseID(Frm.DmDataSet.INST_MAIL, System.Guid.Parse(ID))
        End If
    End Sub
    Private Sub ShellExecute(ByVal File As String)
        Dim myProcess As New Process
        myProcess.StartInfo.FileName = File
        myProcess.StartInfo.UseShellExecute = True
        myProcess.StartInfo.RedirectStandardOutput = False
        myProcess.Start()
        myProcess.Dispose()
    End Sub
End Class
