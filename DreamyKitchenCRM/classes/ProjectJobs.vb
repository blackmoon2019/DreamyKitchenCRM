Imports System.IO
Imports DevExpress.XtraEditors
Imports DevExpress.XtraReports.UI
Imports System.Data.SqlClient
Imports DevExpress.XtraBars.Navigation

Public Class ProjectJobs
    Dim Frm As frmProjectJobs
    Private Valid As New ValidateControls
    Private FillCbo As New FillCombos
    Private DBQ As New DBQueries
    Private LoadForms As New FormLoader
    Private Cls As New ClearControls
    Private UserPermissions As New CheckPermissions
    Private emailMode As Int16
    Private ID As String
    Public Mode As Byte
    Private sComeFrom As Int16
    Private HasConnectedOrder As Boolean = False
    Private ConnectedOrderID As String = ""
    Public Property ComeFrom() As Int16
        Get
            Return sComeFrom
        End Get
        Set(value As Int16)
            sComeFrom = value
        End Set
    End Property
    Public Sub New()

    End Sub

    Public Sub Initialize(ByVal sFrm As frmProjectJobs, ByVal sID As String, ByVal sMode As Byte)
        Frm = sFrm
        ID = sID
        Mode = sMode
        HandleGridEmbeddedNavigatorButtons()
        Frm.CCT_TRANSHTableAdapter.Fill(Frm.DM_TRANS.CCT_TRANSH)
        Frm.Vw_SUPTableAdapter.Fill(Frm.DreamyKitchenDataSet.vw_SUP)
        Frm.Vw_ORDER_MANAGERSTableAdapter.Fill(Frm.DreamyKitchenDataSet.vw_ORDER_MANAGERS)
        If Mode = FormMode.EditRecord Then Frm.Vw_PROJECT_JOBS_DTableAdapter.FillByProjectJobID(Frm.DMDataSet.vw_PROJECT_JOBS_D, System.Guid.Parse(ID))
        UserPermissions.GetUserPermissions("Εργασίες Έργων")
    End Sub
    Public Sub LoadForm()
        Select Case Mode
            Case FormMode.NewRecord
                Frm.txtCode.Text = DBQ.GetNextId("PROJECT_JOBS")
                FillCbo.FillCheckedListPROJECT_JOBS_SER(Frm.chkSER, FormMode.NewRecord)
                Frm.TabNavigationPage2.Enabled = False : Frm.TabNavigationPage3.Enabled = False
            Case FormMode.EditRecord
                Dim sFields As New Dictionary(Of String, String)
                LoadForms.LoadForm(Frm.LayoutControl1, "Select * from PROJECT_JOBS where id ='" + ID + "'", sFields)
                If sFields("comeFrom") = "False" Then sComeFrom = 0 Else sComeFrom = 1
                FillCbo.FillCheckedListPROJECT_JOBS_SER(Frm.chkSER, FormMode.EditRecord, ID)
                If sComeFrom = 0 Then
                    If CheckIfHasConnectedOrder() = True Then Frm.cmdConvertToOrder.Text = "Ενημέρωση Παραγγελίας" : HasConnectedOrder = True : 
                Else
                    ConnectedOrderID = ID
                End If
                Frm.GridControl1.ForceInitialize()
                If Frm.GridView1.DataRowCount = 0 Then Frm.cmdSendEmail.Enabled = False : Frm.cmdPrintAll.Enabled = False : Frm.cmdSendApointmentEmail.Enabled = False : Frm.cmdDefEmail.Enabled = False
        End Select

        If sComeFrom = 1 Then
            LoadForms.RestoreLayoutFromXml(Frm.GridView1, "vw_PROJECT_JOBS_D_SUP.xml")
            Frm.LayoutControlGroup1.Text = "Αφορά Προμηθευτή"
            Frm.chkSER.Enabled = False : Frm.LTmINFrom.Enabled = False : Frm.LTmINTo.Enabled = False
            Frm.cmdNewProjectJob.Enabled = False
            Frm.dtVisitDate.Enabled = False
            DisabletxtProjectJobFilenameComplete()
            Frm.GridView1.OptionsBehavior.Editable = True : Frm.cmdViewOrder.Enabled = False : Frm.cmdConvertToOrder.Enabled = False

        Else
            Frm.LayoutControlGroup1.Text = "Αφορά Πελάτη"
            LoadForms.RestoreLayoutFromXml(Frm.GridView1, "vw_PROJECT_JOBS_D.xml")
        End If

        Frm.cmdSave.Enabled = IIf(Mode = FormMode.NewRecord, UserProps.AllowInsert, UserProps.AllowEdit)
    End Sub
    Private Sub DisabletxtProjectJobFilenameComplete()
        Frm.txtfProjectNameComplete.ReadOnly = True
        Frm.txtfProjectNameComplete.Properties.Buttons.Item(0).Enabled = False
        Frm.txtfProjectNameComplete.Properties.Buttons.Item(1).Enabled = True
        Frm.txtfProjectNameComplete.Properties.Buttons.Item(2).Enabled = False
    End Sub

    Private Sub HandleGridEmbeddedNavigatorButtons()
        Dim navigator As ControlNavigator = Frm.GridControl1.EmbeddedNavigator
        navigator.Buttons.BeginUpdate()
        Try
            If Mode = FormMode.NewRecord Then
                navigator.Buttons.Append.Enabled = False
                navigator.Buttons.Remove.Enabled = False
            Else
                If sComeFrom = 0 Then
                    'navigator.Buttons.Append.Enabled = False
                    'navigator.Buttons.Remove.Enabled = False
                Else
                    navigator.Buttons.Append.Enabled = True
                    navigator.Buttons.Remove.Enabled = True
                End If
            End If
        Finally
            navigator.Buttons.EndUpdate()
        End Try
    End Sub
    Public Sub SaveRecord(ByRef sID As String)
        Dim sResult As Boolean
        Dim sSQL As String
        Dim sGuid As String
        Try
            If Valid.ValidateForm(Frm.LayoutControl1) Then
                If Valid.ValiDationRules(Frm.Name, Frm, False) = False Then Exit Sub
                Select Case Mode
                    Case FormMode.NewRecord
                        sGuid = System.Guid.NewGuid.ToString
                        sResult = DBQ.InsertNewData(DBQueries.InsertMode.OneLayoutControl, "PROJECT_JOBS", Frm.LayoutControl1,,, sGuid, True)
                        ID = sGuid : sID = sGuid
                    Case FormMode.EditRecord
                        sResult = DBQ.UpdateNewData(DBQueries.InsertMode.OneLayoutControl, "PROJECT_JOBS", Frm.LayoutControl1,,, sID, True)
                        ID = sID
                        If sResult = True Then
                            ' Διαγραφή όλων των συνεργείων πάντα στην επεξεργασία εγγραφής
                            sSQL = "DELETE FROM PROJECT_JOBS_SER where projectJobID = '" & sID & "'"
                            Using oCmd As New SqlCommand(sSQL, CNDB)
                                oCmd.ExecuteNonQuery()
                            End Using
                        End If

                End Select

                If sResult = True Then
                    ' Καταχώρηση Συνεργείων 
                    For Each item As DevExpress.XtraEditors.Controls.CheckedListBoxItem In Frm.chkSER.CheckedItems
                        sSQL = "INSERT INTO PROJECT_JOBS_SER (projectJobID,empID,[createdBy],[createdOn]) values (" & toSQLValueS(sID) & "," & toSQLValueS(item.Tag.ToString()) & "," & toSQLValueS(UserProps.ID.ToString) & ", getdate() )"
                        Using oCmd As New SqlCommand(sSQL, CNDB)
                            oCmd.ExecuteNonQuery()
                        End Using
                    Next
                    FillCbo.FillCheckedListPROJECT_JOBS_SER(Frm.chkSER, FormMode.EditRecord, sID)
                    Mode = FormMode.EditRecord : Frm.Mode = Mode
                    Frm.TabNavigationPage2.Enabled = True : Frm.TabNavigationPage3.Enabled = True
                    HandleGridEmbeddedNavigatorButtons()
                    XtraMessageBox.Show("Η εγγραφή αποθηκέυτηκε με επιτυχία", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Public Sub SaveRecordProjectD(ByVal NewRec As Boolean)
        Dim sSQL As New System.Text.StringBuilder
        Dim CompletedCell As String = "", sDate As String
        Dim toOrder As String
        Try
            With Frm.GridView1
                sSQL.Clear()
                If NewRec Then
                    sSQL.AppendLine("INSERT INTO PROJECT_JOBS_D (projectJobID,description,descriptionSup,cmt,completed,toOrder,cost,dtCompleted,[modifiedBy],[createdby],[createdOn])")
                    sSQL.AppendLine("Select " & toSQLValueS(ID) & ",")
                    sSQL.AppendLine(toSQLValueS(.GetRowCellValue(.FocusedRowHandle, "description").ToString) & ",")
                    sSQL.AppendLine(toSQLValueS(.GetRowCellValue(.FocusedRowHandle, "descriptionSup").ToString) & ",")
                    sSQL.AppendLine(toSQLValueS(.GetRowCellValue(.FocusedRowHandle, "cmt").ToString) & ",")
                    CompletedCell = .GetRowCellValue(.FocusedRowHandle, "completed").ToString : If CompletedCell = "" Then CompletedCell = "0"
                    sSQL.AppendLine(toSQLValueS(CompletedCell) & ",")
                    toOrder = .GetRowCellValue(.FocusedRowHandle, "toOrder").ToString : If toOrder = "" Then toOrder = "0"
                    sSQL.AppendLine(toSQLValueS(toOrder) & ",")
                    sSQL.AppendLine(toSQLValueS(.GetRowCellValue(.FocusedRowHandle, "cost").ToString, True) & ",")
                    sDate = .GetRowCellValue(.FocusedRowHandle, "dtCompleted").ToString
                    If sDate <> "" Then sDate = toSQLValueS(CDate(sDate).ToString("yyyyMMdd")) Else sDate = "NULL"
                    sSQL.AppendLine(sDate & ",")
                    sSQL.Append(toSQLValueS(UserProps.ID.ToString) & "," & toSQLValueS(UserProps.ID.ToString) & ", getdate()")
                    'Εκτέλεση QUERY
                    Using oCmd As New SqlCommand(sSQL.ToString, CNDB)
                        oCmd.ExecuteNonQuery()
                    End Using
                    Frm.Vw_PROJECT_JOBS_DTableAdapter.FillByProjectJobID(Frm.DMDataSet.vw_PROJECT_JOBS_D, System.Guid.Parse(ID))
                Else
                    sSQL.AppendLine("UPDATE PROJECT_JOBS_D	SET ")
                    sSQL.AppendLine("modifiedBY = " & toSQLValueS(UserProps.ID.ToString) & ",")
                    sSQL.AppendLine("cmt = " & toSQLValueS(.GetRowCellValue(.FocusedRowHandle, "cmt").ToString) & ",")
                    CompletedCell = .GetRowCellValue(.FocusedRowHandle, "completed").ToString : If CompletedCell = "" Then CompletedCell = "0"
                    sSQL.AppendLine("completed = " & toSQLValueS(CompletedCell) & ",")
                    toOrder = .GetRowCellValue(.FocusedRowHandle, "toOrder").ToString : If toOrder = "" Then toOrder = "0"
                    sSQL.AppendLine("toOrder= " & toSQLValueS(toOrder) & ",")


                    sDate = .GetRowCellValue(.FocusedRowHandle, "dtCompleted").ToString
                    If sDate <> "" Then sDate = toSQLValueS(CDate(sDate).ToString("yyyyMMdd")) Else sDate = "NULL"
                    sSQL.AppendLine("dtcompleted = " & sDate & ",")
                    sSQL.AppendLine("description = " & toSQLValueS(.GetRowCellValue(.FocusedRowHandle, "description").ToString) & ",")
                    sSQL.AppendLine("descriptionSup= " & toSQLValueS(.GetRowCellValue(.FocusedRowHandle, "descriptionSup").ToString) & ",")
                    sSQL.AppendLine("cost= " & toSQLValueS(.GetRowCellValue(.FocusedRowHandle, "cost").ToString, True) & ",")
                    sSQL.AppendLine("modifiedON = getdate() ")
                    sSQL.AppendLine("WHERE ID = " & toSQLValueS(.GetRowCellValue(.FocusedRowHandle, "ID").ToString))
                    'Εκτέλεση QUERY
                    Using oCmd As New SqlCommand(sSQL.ToString, CNDB)
                        oCmd.ExecuteNonQuery()
                    End Using
                    Frm.Vw_PROJECT_JOBS_DTableAdapter.FillByProjectJobID(Frm.DMDataSet.vw_PROJECT_JOBS_D, System.Guid.Parse(ID))
                End If
                If .RowCount = 0 Then
                    Frm.cmdSendEmail.Enabled = False : Frm.cmdPrintAll.Enabled = False : Frm.cmdSendApointmentEmail.Enabled = False : Frm.cmdDefEmail.Enabled = False
                    If sComeFrom = 0 Then Frm.cmdConvertToOrder.Enabled = False
                Else
                    Frm.cmdSendEmail.Enabled = True : Frm.cmdPrintAll.Enabled = True : Frm.cmdSendApointmentEmail.Enabled = True : Frm.cmdDefEmail.Enabled = True
                    If sComeFrom = 0 Then Frm.cmdConvertToOrder.Enabled = True
                End If

            End With
        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
    Public Sub CUSEditValueChanged()
        Dim sCusID As String
        If Frm.cboCUS.EditValue Is Nothing Then sCusID = toSQLValueS("00000000-0000-0000-0000-000000000000") Else sCusID = toSQLValueS(Frm.cboCUS.EditValue.ToString)
        Dim sSQL As New System.Text.StringBuilder
        sSQL.AppendLine("Select T.id,FullTranshDescription,Description,Iskitchen,Iscloset,Isdoor,Issc,instdtDeliverDate
                        from vw_TRANSH t
                        where  T.cusid = " & sCusID & "order by description")
        FillCbo.TRANSH(Frm.cboTRANSH, sSQL)
    End Sub
    Public Sub DeleteRecord()
        If Frm.GridView1.GetRowCellValue(Frm.GridView1.FocusedRowHandle, "ID") = Nothing Then Exit Sub
        If XtraMessageBox.Show("Θέλετε να διαγραφεί η τρέχουσα εγγραφή?", ProgProps.ProgTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            Dim sSQL As String = "DELETE FROM PROJECT_JOBS_D WHERE ID = '" & Frm.GridView1.GetRowCellValue(Frm.GridView1.FocusedRowHandle, "ID").ToString & "'"
            Using oCmd As New SqlCommand(sSQL, CNDB)
                oCmd.ExecuteNonQuery()
            End Using
            Frm.Vw_PROJECT_JOBS_DTableAdapter.FillByProjectJobID(Frm.DMDataSet.vw_PROJECT_JOBS_D, System.Guid.Parse(ID))
        End If
    End Sub
    Public Function CheckIfHasConnectedOrder() As Boolean
        Dim Cmd As SqlCommand, sdr As SqlDataReader
        Dim sSQL As String
        sSQL = "SELECT top 1 id as connectedProjectJobsID FROM PROJECT_JOBS WHERE connectedProjectID = " & toSQLValueS(ID)
        Cmd = New SqlCommand(sSQL.ToString, CNDB)
        sdr = Cmd.ExecuteReader()
        Dim connectedProjectJobsID As String
        If (sdr.Read() = True) Then
            If sdr.IsDBNull(sdr.GetOrdinal("connectedProjectJobsID")) = False Then connectedProjectJobsID = sdr.GetGuid(sdr.GetOrdinal("connectedProjectJobsID")).ToString Else connectedProjectJobsID = ""
            If connectedProjectJobsID <> "" Then
                ConnectedOrderID = connectedProjectJobsID : Frm.cmdViewOrder.Enabled = True
                sdr.Close()
                Return True
            Else
                Frm.cmdViewOrder.Enabled = False
                sdr.Close()
                Return False
            End If
        Else
            Frm.cmdViewOrder.Enabled = False
            sdr.Close()
            Return False
        End If
        sdr.Close()

    End Function
    Public Sub ConvertToOrder()
        Try
            Valid.ID = ID
            If Valid.ValiDationRules(Frm.Name, Frm, True, IIf(sComeFrom = 0, False, True)) = False Then Exit Sub
            If HasConnectedOrder Then
                Using oCmd As New SqlCommand("ClonePROJECTJOBSd", CNDB)
                    oCmd.CommandType = CommandType.StoredProcedure
                    oCmd.Parameters.AddWithValue("@ProjectJobID", ID)
                    oCmd.ExecuteNonQuery()
                End Using
                XtraMessageBox.Show("Η παραγγελία επαναδημιουργήθηκε με επιτυχία.", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Information)
                If CheckIfHasConnectedOrder() = True Then Frm.cmdConvertToOrder.Text = "Ενημέρωση Παραγγελίας" : HasConnectedOrder = True : 
            Else
                If Frm.GridView1.DataRowCount = 0 Then
                    XtraMessageBox.Show("Δεν έχετε καταχωρήσει εργασίες. Δεν μπορεί να αποθηκευθεί η εγγραφή.", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
                If CheckIfHasProjectJobsDForOrder() = False Then
                    XtraMessageBox.Show("Δεν έχετε επιλέξει εργασίες προς Παραγγελία. Δεν μπορεί να γίνει η μετατροπή.", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If

                If XtraMessageBox.Show("Θέλετε να μετατραπούν οι εργασίες σε παραγγελία?", ProgProps.ProgTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                    Using oCmd As New SqlCommand("ClonePROJECTJOBS", CNDB)
                        oCmd.CommandType = CommandType.StoredProcedure
                        oCmd.Parameters.AddWithValue("@ProjectJobID", ID)
                        oCmd.Parameters.AddWithValue("@supID", Frm.cboSUP.EditValue.ToString)
                        oCmd.Parameters.AddWithValue("@empID", Frm.cboEmp.EditValue.ToString)
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
    Private Function CheckIfHasProjectJobsDForOrder() As Boolean
        Dim Cmd As SqlCommand, sdr As SqlDataReader
        Dim sSQL As String
        sSQL = "SELECT top 1 id as toOrderID FROM PROJECT_JOBS_D WHERE toOrder = 1 and projectJobID= " & toSQLValueS(ID)
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

    Public Function CheckIfProjectJobsAreCompleted() As Boolean
        Dim Cmd As SqlCommand, sdr As SqlDataReader
        Dim sSQL As String
        sSQL = "SELECT id as CountProjectJob FROM PROJECT_JOBS_D  WHERE completed = 0 and projectJobID= " & toSQLValueS(ID)
        Cmd = New SqlCommand(sSQL.ToString, CNDB)
        sdr = Cmd.ExecuteReader()
        Dim CountProjectJob As String
        If (sdr.Read() = True) Then
            If sdr.IsDBNull(sdr.GetOrdinal("CountProjectJob")) = False Then CountProjectJob = sdr.GetGuid(sdr.GetOrdinal("CountProjectJob")).ToString Else CountProjectJob = ""
            sdr.Close()
            If CountProjectJob <> "" Then Return False Else Return True
        Else
            sdr.Close()
            Return True
        End If
    End Function
    Public Sub NewRecord()
        'Έλεγχος για να δεί αν υπάρχει μη ολοκληρωμένη έλλειψη πριν ανοίξει καινούρια γιαυτην την τοποθέτηση 
        If CheckIfHasProjectJobNotCompleted() = True Then XtraMessageBox.Show("Δεν μπορείτε να δημιουργήσετε νέα εγγραφή όταν υπάρχει μη ολοκληρωμένη εργασία.", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error) : Exit Sub
        'Eλεγχος αν υπάρχει έντυπο ολοκλήρωσης
        If CheckIfProjectHasCompleteDocument() = True Then XtraMessageBox.Show("Δεν μπορείτε να δημιουργήσετε νέα εγγραφή, έχουν ολοκληρωθεί όλες οι εργασίες.", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error) : Exit Sub
        ' Κάνει ολοκληρωμένη την ελλέιψη τις συγκεκριμένης τοποθέτησης
        If SetProjectJobCompleted() = False Then Exit Sub
        ID = System.Guid.NewGuid.ToString
        'Καταχώρηση συνεργείων και επιμέρους εργασιών που έμειναν ανολοκλήρωτες στην νέα εργασία
        Insert_ProjectJobSer_ProjectJobs_D()
        Frm.txtTmIN.EditValue = "00:00" : Frm.txtTmOUT.EditValue = "00:00" : Frm.chkCompleted.CheckState = CheckState.Unchecked
        Frm.txtComments.EditValue = Nothing : Frm.txtfProjectNameComplete.EditValue = Nothing : Frm.cmdConvertToOrder.Enabled = False : Frm.cmdViewOrder.Enabled = False
        AddRecord()

    End Sub
    Private Function CheckIfHasProjectJobNotCompleted() As Boolean
        Dim Cmd As SqlCommand, sdr As SqlDataReader
        Dim sSQL As String
        sSQL = "SELECT id FROM PROJECT_JOBS WHERE completed = 0  and transhID= " & toSQLValueS(Frm.cboTRANSH.EditValue.ToString)
        Cmd = New SqlCommand(sSQL.ToString, CNDB)
        sdr = Cmd.ExecuteReader()
        Dim ProjectJobID As String
        If (sdr.Read() = True) Then
            If sdr.IsDBNull(sdr.GetOrdinal("id")) = False Then ProjectJobID = sdr.GetGuid(sdr.GetOrdinal("id")).ToString Else ProjectJobID = ""
            If ProjectJobID <> "" Then Return True Else Return False
        Else
            Return False
        End If
        sdr.Close()
    End Function
    Private Function CheckIfProjectHasCompleteDocument() As Boolean
        Dim Cmd As SqlCommand, sdr As SqlDataReader
        Dim sSQL As String
        sSQL = "SELECT fProjectNameComplete FROM PROJECT_JOBS WHERE ID= " & toSQLValueS(ID)
        Cmd = New SqlCommand(sSQL.ToString, CNDB)
        sdr = Cmd.ExecuteReader()
        Dim fProjectNameComplete As String
        If (sdr.Read() = True) Then
            If sdr.IsDBNull(sdr.GetOrdinal("fProjectNameComplete")) = False Then fProjectNameComplete = sdr.GetString(sdr.GetOrdinal("fProjectNameComplete")) Else fProjectNameComplete = ""
            If fProjectNameComplete <> "" Then Return True Else Return False
        End If
        sdr.Close()
    End Function
    Private Function SetProjectJobCompleted() As Boolean
        Dim sSQL As String
        Try
            sSQL = "UPDATE PROJECT_JOB SET COMPLETED = 1 WHERE ID = " & toSQLValueS(ID)
            Using oCmd As New SqlCommand(sSQL, CNDB)
                oCmd.ExecuteNonQuery()
            End Using
            Return True
        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try

    End Function
    Private Sub Insert_ProjectJobSer_ProjectJobs_D()
        Try
            Dim sSQL As String
            Dim LastProjectID As String = GetLastProjectJobID()

            ' Μεταφέρει ότι άλλη εργασία υπάρχει ανολοκλήρωτη στην καινούρια εργασία
            sSQL = "INSERT INTO PROJECT_JOBS_D ([ID],[projectJobID], [description],[descriptionSup], [cmt], [completed], [dtCompleted],  [createdOn], [createdBy]) " &
                    "SELECT NEWID()," & toSQLValueS(ID) & ", [description],[descriptionSup], PJD.[cmt], PJD.[completed], [dtCompleted],  PJD.[createdOn], PJD.[createdBy] " &
                    "from TRANSH T 
                     inner join PROJECT_JOBS PJ on PJ.transhID=T.I 
                     INNER  join PROJECT_JOBS_D PJD ON PJD.projectJobID =PJ.ID 
                     WHERE PJ.comefrom = 0 and  PJD.completed=0 And T.[ID]= " & toSQLValueS(Frm.cboTRANSH.EditValue.ToString) &
                     " AND PJ.id = " & toSQLValueS(LastProjectID)
            Using oCmd As New SqlCommand(sSQL, CNDB)
                oCmd.ExecuteNonQuery()
            End Using
            Frm.Vw_PROJECT_JOBS_DTableAdapter.FillByProjectJobID(Frm.DMDataSet.vw_PROJECT_JOBS_D, System.Guid.Parse(ID))
            Frm.GridView1.OptionsBehavior.Editable = True
            Mode = FormMode.EditRecord
        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Function GetLastProjectJobID() As String
        Dim Cmd As SqlCommand, sdr As SqlDataReader
        Cmd = New SqlCommand("Select TOP 1 PJ.id, MAX(ie.createdOn) as createdOn  FROM PROJECT_JOB PJ WHERE comefrom=0 and PJ.transhID= " & toSQLValueS(Frm.cboTRANSH.EditValue.ToString) & " group by PJ.ID ORDER BY createdOn DESC ", CNDB)
        sdr = Cmd.ExecuteReader()
        If (sdr.Read() = True) Then GetLastProjectJobID = sdr.GetGuid(sdr.GetOrdinal("ID")).ToString.ToUpper
        sdr.Close()
        Return GetLastProjectJobID
    End Function
    Private Sub AddRecord()
        Frm.cmdNewProjectJob.Enabled = False
        Frm.txtCode.Text = DBQ.GetNextId("PROJECT_JOB")
        FillCbo.FillCheckedListINST_ELLIPSE_SER(Frm.chkSER, FormMode.NewRecord)
        Frm.cmdSendEmail.Enabled = False : Frm.cmdPrintAll.Enabled = False : Frm.cmdSendApointmentEmail.Enabled = False : Frm.cmdDefEmail.Enabled = False

        '΅Εισαγωγή εγγραφής απευθείας στην βάση
        Dim sResult As Boolean = sResult = DBQ.InsertNewData(DBQueries.InsertMode.OneLayoutControl, "PROJECT_JOBS", Frm.LayoutControl1,,, ID, True, "comefrom", sComeFrom)
        If sResult = False Then
            XtraMessageBox.Show("Υπήρξε πρόβλημα κατά την διαδικασία ανοίγματος εργασίας.", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Frm.Close()
        End If
        Mode = FormMode.EditRecord
    End Sub
    Public Sub ViewOrder()
        Dim frmProjectJobs As New frmProjectJobs
        frmProjectJobs.Text = "Εργασίες Έργων"
        frmProjectJobs.Mode = FormMode.EditRecord
        frmProjectJobs.ID = ConnectedOrderID
        frmProjectJobs.CalledFromControl = False
        frmProjectJobs.ComeFrom = 1
        frmProjectJobs.ShowDialog()
    End Sub
    Public Sub PrintDocument()
        If sComeFrom = 0 Then
            Dim report As New RepCUSProjectJobs
            report.Parameters.Item(0).Value = ID
            report.CreateDocument()
            Dim printTool As New ReportPrintTool(report)
            printTool.ShowRibbonPreview()
        Else
            Dim report As New RepCUSProjectJobsForSUP
            report.Parameters.Item(0).Value = ID
            report.CreateDocument()
            Dim printTool As New ReportPrintTool(report)
            printTool.ShowRibbonPreview()
        End If

    End Sub
    Public Sub FileSelect()
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
                Frm.txtfProjectNameComplete.EditValue = Frm.XtraOpenFileDialog1.FileName
                sSQL = "UPDATE PROJECT_JOBS SET completed = 1 ,fProjectNameComplete =  " & toSQLValueS(Path.GetFileName(Frm.XtraOpenFileDialog1.FileName).ToString) & ", fProjectComplete =  BulkColumn from Openrowset( Bulk " & toSQLValueS(ProgProps.ServerPath & Path.GetFileName(Frm.XtraOpenFileDialog1.FileName)) & ", Single_Blob) as ProjectJobF where ID = " & toSQLValueS(ID)

                'Εκτέλεση QUERY
                Using oCmd As New SqlCommand(sSQL, CNDB)
                    oCmd.ExecuteNonQuery()
                End Using
                Frm.chkCompleted.CheckState = CheckState.Checked : Frm.GridView1.OptionsBehavior.Editable = False
                Frm.cmdNewProjectJob.Enabled = False : DisabletxtProjectJobFilenameComplete()
                XtraMessageBox.Show("Το αρχείο αποθηκεύτηκε με επιτυχία", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub
    Public Sub DeleteFile()
        If Frm.txtfProjectNameComplete.EditValue = Nothing Then Exit Sub
        If XtraMessageBox.Show("Θέλετε να διαγραφεί το αρχείο?", ProgProps.ProgTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            Dim sSQL As String
            sSQL = "UPDATE PROJECT_JOBS SET completed = 0,fProjectNameComplete =  NULL ,fProjectComplete =  NULL where ID = " & toSQLValueS(ID)
            'Εκτέλεση QUERY
            Using oCmd As New SqlCommand(sSQL, CNDB)
                oCmd.ExecuteNonQuery()
            End Using
            Frm.chkCompleted.CheckState = CheckState.Unchecked
            Frm.GridView1.OptionsBehavior.Editable = True
            Frm.txtfProjectNameComplete.EditValue = Nothing
            Frm.cmdNewProjectJob.Enabled = True
        End If

    End Sub
    Public Sub ValidateEmail(ByVal sEmailMode As Int16)
        emailMode = sEmailMode
        If Frm.GridView1.RowCount = 0 Then XtraMessageBox.Show("Δεν υπάρχουν εργασίες προς αποστολή", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error) : Exit Sub
        If Frm.txtBody.Text = "" Then XtraMessageBox.Show("Παρακαλώ συμπληρώστε κείμενο", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error) : Exit Sub
        If Frm.txtSubject.Text = "" Then XtraMessageBox.Show("Παρακαλώ συμπληρώστε το θέμα", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error) : Exit Sub
        If Frm.txtTo.Text.Trim = "" Then XtraMessageBox.Show("Δεν υπάρχει καταχωρήμενο email στον " & IIf(sComeFrom = 0, " πελάτη.", " προμηθευτή."), ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error) : Exit Sub
        If XtraMessageBox.Show("Θέλετε να αποσταλεί το Email?", ProgProps.ProgTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            SendEmailExportReport()
            Frm.PROJECT_JOBS_MAILTableAdapter.FillByProjectJobID(Frm.DMDataSet.PROJECT_JOBS_MAIL, System.Guid.Parse(ID))
        End If
    End Sub
    Private Sub SendEmailExportReport()
        Dim Cmd As SqlCommand, sdr As SqlDataReader
        Dim Emails As New SendEmail
        Dim statusMsg As String
        Dim sEmailTo As String
        Dim sSubject As String
        Dim sBody As String
        Dim sFile As String
        Dim sSQL As String
        Try


            If sComeFrom = 1 Then
                Dim report As New RepCUSProjectJobsForSUP()
                report.Parameters.Item(0).Value = ID
                sEmailTo = Frm.txtTo.EditValue
                sBody = Frm.txtBody.EditValue
                sSubject = Frm.txtSubject.EditValue
                sBody = sBody.Replace("{PJ_VISIT_DATE}", Date.Now.Date)
                sBody = sBody.Replace("{CUS}", Frm.cboCUS.Text)
                sFile = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) & "\Downloads\Ενημερώτικό έντυπο εργασιών προμηθευτή.pdf"
                report.CreateDocument()
                report.ExportToPdf(sFile)
                report.Dispose()
                report = Nothing
                My.Computer.FileSystem.CopyFile(sFile, ProgProps.ServerPath & Path.GetFileName(sFile), True)
            Else
                Dim report As New RepCUSProjectJobs()
                report.Parameters.Item(0).Value = ID
                sEmailTo = Frm.txtTo.EditValue
                sBody = Frm.txtBody.EditValue
                sBody = sBody.Replace("{PJ_TIME_FROM}", Frm.txtTmIN.Text)
                sBody = sBody.Replace("{PJ_TIME_TO}", Frm.txtTmOUT.Text)
                sSubject = Frm.txtSubject.EditValue
                sFile = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) & "\Downloads\Ενημερώτικό έντυπο εργασιών.pdf"
                report.CreateDocument()
                report.ExportToPdf(sFile)
                report.Dispose()
                report = Nothing
                My.Computer.FileSystem.CopyFile(sFile, ProgProps.ServerPath & Path.GetFileName(sFile), True)
            End If

            'sEmailTo = "dreamykitchen@gmail.com"
            'sEmailTo = "johnmavroselinos@gmail.com"

            If CNDB.Database <> "DreamyKitchen" Or Debugger.IsAttached = True Then sEmailTo = "johnmavroselinos@gmail.com;dreamykitchen@gmail.com"

            If Emails.SendEmail(ProgProps.PJEmailSupFrom, sSubject, sBody, sEmailTo, sFile, statusMsg) = True Then
                Select Case emailMode
                    Case 1 : sSQL = "Update PROJECT_JOBS SET emailApp = 1,DateOfEmailApp=getdate() WHERE ID = " & toSQLValueS(ID)
                    Case 2 : sSQL = "Update PROJECT_JOBS SET emailInf = 1,DateOfEmailInf=getdate() WHERE ID = " & toSQLValueS(ID)
                    Case 3 : sSQL = "Update PROJECT_JOBS SET emailInfComplete = 1,DateOfEmailInfComplete=getdate() WHERE ID = " & toSQLValueS(ID)
                End Select

                Cmd = New SqlCommand(sSQL, CNDB) : Cmd.ExecuteNonQuery()

                ' Εισαγωγή ιστορικού email
                sSQL = "INSERT INTO [PROJECT_JOBS_MAIL] (projectjobID,emailFrom,emailTo,emailSubject,emailBody,DateofEmail,[createdBy],[createdOn],ComeFrom,emailMode,Attachment)  
                        Select " & toSQLValueS(ID) & "," & toSQLValueS(ProgProps.PJEmailSupFrom) & "," &
                                    toSQLValue(Frm.txtTo) & "," & toSQLValue(Frm.txtSubject) & "," & toSQLValue(Frm.txtBody) & ",getdate(), " &
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
    Public Sub SaveRecordF(ByVal sMode As Integer, Optional ByVal sFilename As String = "")
        Dim sResultF As Boolean
        If Frm.cboTanshFCategory.EditValue = Nothing Then XtraMessageBox.Show("Δεν έχετε επιλέξει Κατηγορία.", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error) : Exit Sub
        If Frm.txtFiles.Text = "" Then XtraMessageBox.Show("Δεν έχετε επιλέξει Αρχείο.", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error) : Exit Sub
        Select Case sMode
            Case 0 : sResultF = DBQ.InsertDataFiles(Frm.XtraOpenFileDialog2, Frm.cboTRANSH.EditValue.ToString, "TRANSH_F", ID, "Αρχεία Εργασιών")
            Case 1 : sResultF = DBQ.InsertDataFilesFromScanner(sFilename, Frm.cboTRANSH.EditValue.ToString, "TRANSH_F", Frm.cboTanshFCategory.EditValue.ToString, ID, "Αρχεία Εργασιών")
        End Select
        Frm.txtFiles.EditValue = Nothing
        Frm.TRANSH_FTableAdapter.FillByTranshID(Frm.DM_TRANS.TRANSH_F, System.Guid.Parse(Frm.cboTRANSH.EditValue.ToString))


    End Sub

End Class
