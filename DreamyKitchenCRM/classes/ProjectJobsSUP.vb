Imports System.IO
Imports DevExpress.XtraEditors
Imports DevExpress.XtraReports.UI
Imports System.Data.SqlClient
Imports DreamyKitchenCRM.DM_TRANSTableAdapters

Public Class ProjectJobsSUP
    Dim Frm As frmProjectJobsSUP
    Private Valid As New ValidateControls
    Private FillCbo As New FillCombos
    Private DBQ As New DBQueries
    Private LoadForms As New FormLoader
    Private Cls As New ClearControls
    Private UserPermissions As New CheckPermissions
    Private Prog_Prop As New ProgProp
    Private emailMode As Int16
    Private EmailSended As Boolean = False
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

    Public Sub Initialize(ByVal sFrm As frmProjectJobsSUP, ByVal sID As String, ByVal sMode As Byte)
        Frm = sFrm
        ID = sID
        Mode = sMode
        Frm.EmailSended = False
        HandleGridEmbeddedNavigatorButtons()
        Frm.CCT_TRANSHTableAdapter.Fill(Frm.DM_TRANS.CCT_TRANSH)
        Frm.Vw_SUPTableAdapter.Fill(Frm.DreamyKitchenDataSet.vw_SUP)
        Frm.Vw_ORDER_MANAGERSTableAdapter.FillByConstrDep(Frm.DreamyKitchenDataSet.vw_ORDER_MANAGERS)
        If Mode = FormMode.EditRecord Then Frm.Vw_PROJECT_JOBSSUP_DTableAdapter.FillByProjectJobSUPID(Frm.DMDataSet.vw_PROJECT_JOBSSUP_D, System.Guid.Parse(ID))
        UserPermissions.GetUserPermissions("Εκκρεμότητες Κατασκευαστικού")
    End Sub
    Public Sub LoadForm()
        sComeFrom = 1
        Select Case Mode
            Case FormMode.NewRecord
                Frm.txtCode.Text = DBQ.GetNextId("PROJECT_JOBSSUP")
                Frm.TabNavigationPage2.Enabled = False : Frm.TabNavigationPage3.Enabled = False
            Case FormMode.EditRecord
                Dim sFields As New Dictionary(Of String, String)
                LoadForms.LoadForm(Frm.LayoutControl1, "Select * from PROJECT_JOBSSUP where id ='" + ID + "'", sFields)
                'If sFields("comeFrom") = "False" Then sComeFrom = 0 Else sComeFrom = 1
                ' Το κύκλωμα αφορά μόνο προμηθευτή
                If CheckIfHasConnectedOrder() = True Then Frm.cmdConvertToOrder.Text = "Ενημέρωση Παραγγελίας" : HasConnectedOrder = True : 
                Frm.GridControl1.ForceInitialize()
                If Frm.GridView1.DataRowCount = 0 Then Frm.cmdSendEmail.Enabled = False : Frm.cmdPrintAll.Enabled = False : Frm.cmdSendEmail.Enabled = False
                'If sFields("emailInfComplete") = "True" Then DisabletxtProjectJobFilenameComplete()
                If sFields("emailApp") = "True" Then EmailSended = True : Frm.EmailSended = True

        End Select

        If sComeFrom = 1 Then
            LoadForms.RestoreLayoutFromXml(Frm.GridView1, "vw_PROJECT_JOBSSUP_D_SUP.xml")
            Frm.LayoutControlGroup1.Text = "Αφορά Προμηθευτή"
            If Mode = FormMode.NewRecord Then
                Frm.chkCompleted.Enabled = False
                DisabletxtProjectJobFilenameComplete()
                Frm.GridView1.OptionsBehavior.Editable = True : Frm.cmdConvertToOrder.Enabled = False
            End If
        Else
            Frm.LayoutControlGroup1.Text = "Αφορά Πελάτη"
            LoadForms.RestoreLayoutFromXml(Frm.GridView1, "vw_PROJECT_JOBSSUP_D.xml")
        End If

        Frm.cmdSave.Enabled = IIf(Mode = FormMode.NewRecord, UserProps.AllowInsert, UserProps.AllowEdit)
    End Sub
    Public Function ValidationsExit() As Boolean
        'If HasConnectedOrder = False And sComeFrom = 0 Then If CheckIfHasRecordsForOrder() = True Then Return False
        If Frm.GridView1.DataRowCount > 0 Then
            'If CheckIfHasSendInfEmail() = False Then Return False
            If CheckIfProjectJobsAreCompleted() = True And Frm.txtfProjectNameComplete.EditValue = Nothing Then
                XtraMessageBox.Show("Όλες οι εργασίες είναι ολοκληρωμένες χωρίς να έχετε επισυνάψει έντυπο ολοκλήρωσης.", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            End If
        End If

        Return True
    End Function
    Public Sub EmailTabSelected()
        Prog_Prop.GetProgEmailPJ()
        'txtSubject.EditValue = ProgProps.PJInfSubjectSup
        Dim supID As String : Frm.txtTo.EditValue = GetSupplierEmails(supID) : Frm.txtTo.Tag = supID
        Frm.PROJECT_JOBSSUP_MAILTableAdapter.FillByProjectJobSUPID(Frm.DMDataSet.PROJECT_JOBSSUP_MAIL, System.Guid.Parse(ID))
        LoadForms.RestoreLayoutFromXml(Frm.GridView3, "PROJECT_JOBSSUP_MAIL.xml")
    End Sub
    Private Function GetSupplierEmails(ByRef supID As String) As String
        Try
            Dim Cmd As SqlCommand, sdr As SqlDataReader
            Cmd = New SqlCommand("Select email,supID FROM SUP inner join PROJECT_JOBSSUP_D PJD on PJD.supID=SUP.id WHERE email is not null and projectJobID= " & toSQLValueS(ID), CNDB)
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
        LoadForms.RestoreLayoutFromXml(Frm.GridView4, "vw_TRANSH_F_PROJECT_JOBSSUP_def.xml")
        If Frm.cboTRANSH.EditValue IsNot Nothing Then Frm.TRANSH_FTableAdapter.FillByTranshID(Frm.DM_TRANS.TRANSH_F, System.Guid.Parse(Frm.cboTRANSH.EditValue.ToString))
    End Sub
    Private Function CheckIfHasSendInfEmail() As Boolean
        Dim Cmd As SqlCommand, sdr As SqlDataReader
        Dim sSQL As New System.Text.StringBuilder
        Try
            sSQL.AppendLine("SELECT count (PJ.id) as CountPJ  
                        FROM PROJECT_JOBSSUP_D  PJD
                        inner join PROJECT_JOBSSUP  PJ ON PJ.ID = PJD.projectJobID 
                        WHERE projectJobID = " & toSQLValueS(ID) & "  AND emailApp IS NOT NULL")
            Cmd = New SqlCommand(sSQL.ToString, CNDB)
            sdr = Cmd.ExecuteReader()
            Dim CountPJ As Integer
            If (sdr.Read() = True) Then
                If sdr.IsDBNull(sdr.GetOrdinal("CountPJ")) = False Then CountPJ = sdr.GetInt32(sdr.GetOrdinal("CountPJ")) Else CountPJ = 0
                sdr.Close()
                If CountPJ = 0 Then
                    XtraMessageBox.Show("Παρακαλώ πολύ πρέπει να στείλετε eMail με την παραγγελία στον προμηθευτή.", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Return False
                Else
                    Return True
                End If
            Else
                Return True
            End If
        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try


    End Function
    Private Function CheckIfHasSendInfCompleteEmail() As Boolean
        Dim Cmd As SqlCommand, sdr As SqlDataReader
        Dim sSQL As New System.Text.StringBuilder
        Try
            sSQL.AppendLine("SELECT emailInfComplete 
                        FROM PROJECT_JOBSSUP PJ
                        WHERE ID= " & toSQLValueS(ID) & "  AND PJ.completed = 1 ")
            Cmd = New SqlCommand(sSQL.ToString, CNDB)
            sdr = Cmd.ExecuteReader()
            Dim emailInfComplete As Boolean
            If (sdr.Read() = True) Then
                If sdr.IsDBNull(sdr.GetOrdinal("emailInfComplete")) = False Then emailInfComplete = sdr.GetBoolean(sdr.GetOrdinal("emailInfComplete")) Else emailInfComplete = False
                sdr.Close()
                If emailInfComplete = False Then
                    XtraMessageBox.Show("Παρακαλώ πολύ πρέπει να στείλετε eMail Ολοκλήρωσης Ενημέρωσης εργασιών στον πελάτη.", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return False
                Else
                    Return True
                End If
            Else
                Return True
            End If
        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try

    End Function

    Private Function CheckIfHasRecordsForOrder() As Boolean
        Dim Cmd As SqlCommand, sdr As SqlDataReader
        Dim sSQL As New System.Text.StringBuilder
        Try
            sSQL.AppendLine("SELECT count (id) as CountPJ  FROM PROJECT_JOBSSUP_D 
                         WHERE projectJobID= " & toSQLValueS(ID) & " and toOrder = 1 and " & toSQLValueS(ID) &
                         " Not In (Select Top 1 ID from PROJECT_JOBSSUP  where connectedProjectID = " & toSQLValueS(ID) & ")")
            Cmd = New SqlCommand(sSQL.ToString, CNDB)
            sdr = Cmd.ExecuteReader()
            Dim CountPJ As Integer
            If (sdr.Read() = True) Then
                If sdr.IsDBNull(sdr.GetOrdinal("CountPJ")) = False Then CountPJ = sdr.GetInt32(sdr.GetOrdinal("CountPJ")) Else CountPJ = 0
                sdr.Close()
                If CountPJ > 0 Then
                    XtraMessageBox.Show("Υπάρχουν εργασίες προς παραγγελία. Παρακαλώ δημιουργήστε παραγγελία πριν την έξοδο.", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return True
                Else
                    Return False
                End If
            End If
            Return False
        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try

    End Function

    Private Sub DisabletxtProjectJobFilenameComplete()
        Frm.txtfProjectNameComplete.ReadOnly = True
        Frm.txtfProjectNameComplete.Properties.Buttons.Item(0).Enabled = False
        Frm.txtfProjectNameComplete.Properties.Buttons.Item(1).Enabled = True
        Frm.txtfProjectNameComplete.Properties.Buttons.Item(2).Enabled = False
    End Sub
    Private Sub EnabletxtInstellipseFilenameComplete()
        Frm.txtfProjectNameComplete.ReadOnly = False
        Frm.txtfProjectNameComplete.Properties.Buttons.Item(0).Enabled = True
        Frm.txtfProjectNameComplete.Properties.Buttons.Item(1).Enabled = True
        Frm.txtfProjectNameComplete.Properties.Buttons.Item(2).Enabled = True
    End Sub

    Private Sub HandleGridEmbeddedNavigatorButtons()
        Dim navigator As ControlNavigator = Frm.GridControl1.EmbeddedNavigator
        navigator.Buttons.BeginUpdate()
        Try
            If Mode = FormMode.NewRecord Then
                navigator.Buttons.Append.Enabled = False
                navigator.Buttons.Remove.Enabled = False
            Else
                navigator.Buttons.Append.Enabled = True
                navigator.Buttons.Remove.Enabled = True
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
                        sResult = DBQ.InsertNewData(DBQueries.InsertMode.OneLayoutControl, "PROJECT_JOBSSUP", Frm.LayoutControl1,,, sGuid, True)
                        ID = sGuid : sID = sGuid
                    Case FormMode.EditRecord
                        sResult = DBQ.UpdateNewData(DBQueries.InsertMode.OneLayoutControl, "PROJECT_JOBSSUP", Frm.LayoutControl1,,, sID, True)
                        ID = sID
                End Select

                If sResult = True Then
                    Mode = FormMode.EditRecord : Frm.Mode = Mode
                    Frm.TabNavigationPage2.Enabled = True : Frm.TabNavigationPage3.Enabled = True
                    Frm.cmdConvertToOrder.Enabled = True
                    HandleGridEmbeddedNavigatorButtons()
                    Frm.chkCompleted.Enabled = True
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
        Dim missing As String, replacement As String, orderError As String, toOrder As String
        Try
            With Frm.GridView1
                sSQL.Clear()
                If NewRec Then
                    sSQL.AppendLine("INSERT INTO PROJECT_JOBSSUP_D (projectJobID,supID,description,cmt,completed,missing,replacement,orderError,toOrder,dtCompleted,[modifiedBy],[createdby],[createdOn])")
                    sSQL.AppendLine("Select " & toSQLValueS(ID) & ",")
                    sSQL.AppendLine(toSQLValueS(.GetRowCellValue(.FocusedRowHandle, "supID").ToString) & ",")
                    sSQL.AppendLine(toSQLValueS(.GetRowCellValue(.FocusedRowHandle, "description").ToString) & ",")
                    sSQL.AppendLine(toSQLValueS(.GetRowCellValue(.FocusedRowHandle, "cmt").ToString) & ",")
                    CompletedCell = .GetRowCellValue(.FocusedRowHandle, "completed").ToString : If CompletedCell = "" Then CompletedCell = "0"
                    sSQL.AppendLine("completed = " & toSQLValueS(CompletedCell) & ",")
                    missing = .GetRowCellValue(.FocusedRowHandle, "missing").ToString : If missing = "" Then missing = "0"
                    sSQL.AppendLine("missing = " & toSQLValueS(missing) & ",")
                    replacement = .GetRowCellValue(.FocusedRowHandle, "replacement").ToString : If replacement = "" Then replacement = "0"
                    sSQL.AppendLine("replacement = " & toSQLValueS(replacement) & ",")
                    orderError = .GetRowCellValue(.FocusedRowHandle, "orderError").ToString : If orderError = "" Then orderError = "0"
                    sSQL.AppendLine("orderError= " & toSQLValueS(orderError) & ",")
                    toOrder = .GetRowCellValue(.FocusedRowHandle, "toOrder").ToString : If toOrder = "" Then toOrder = "0"
                    sSQL.AppendLine("toOrder= " & toSQLValueS(toOrder) & ",")
                    sDate = .GetRowCellValue(.FocusedRowHandle, "dtCompleted").ToString
                    If sDate <> "" Then sDate = toSQLValueS(CDate(sDate).ToString("yyyyMMdd")) Else sDate = "NULL"
                    sSQL.AppendLine(sDate & ",")
                    sSQL.Append(toSQLValueS(UserProps.ID.ToString) & "," & toSQLValueS(UserProps.ID.ToString) & ", getdate()")
                    'Εκτέλεση QUERY
                    Using oCmd As New SqlCommand(sSQL.ToString, CNDB)
                        oCmd.ExecuteNonQuery()
                    End Using
                    Frm.Vw_PROJECT_JOBSSUP_DTableAdapter.FillByProjectJobSUPID(Frm.DMDataSet.vw_PROJECT_JOBSSUP_D, System.Guid.Parse(ID))
                Else
                    sSQL.AppendLine("UPDATE PROJECT_JOBSSUP_D	SET ")
                    sSQL.AppendLine("modifiedBY = " & toSQLValueS(UserProps.ID.ToString) & ",")
                    sSQL.AppendLine("supID = " & toSQLValueS(.GetRowCellValue(.FocusedRowHandle, "supID").ToString) & ",")
                    sSQL.AppendLine("cmt = " & toSQLValueS(.GetRowCellValue(.FocusedRowHandle, "cmt").ToString) & ",")
                    CompletedCell = .GetRowCellValue(.FocusedRowHandle, "completed").ToString : If CompletedCell = "" Then CompletedCell = "0"
                    sSQL.AppendLine("completed = " & toSQLValueS(CompletedCell) & ",")
                    missing = .GetRowCellValue(.FocusedRowHandle, "missing").ToString : If missing = "" Then missing = "0"
                    sSQL.AppendLine("missing= " & toSQLValueS(missing) & ",")
                    replacement = .GetRowCellValue(.FocusedRowHandle, "replacement").ToString : If replacement = "" Then replacement = "0"
                    sSQL.AppendLine("replacement = " & toSQLValueS(replacement) & ",")
                    orderError = .GetRowCellValue(.FocusedRowHandle, "orderError").ToString : If orderError = "" Then orderError = "0"
                    sSQL.AppendLine("orderError= " & toSQLValueS(orderError) & ",")
                    toOrder = .GetRowCellValue(.FocusedRowHandle, "toOrder").ToString : If toOrder = "" Then toOrder = "0"
                    sSQL.AppendLine("toOrder= " & toSQLValueS(toOrder) & ",")


                    sDate = .GetRowCellValue(.FocusedRowHandle, "dtCompleted").ToString
                    If sDate <> "" Then sDate = toSQLValueS(CDate(sDate).ToString("yyyyMMdd")) Else sDate = "NULL"
                    sSQL.AppendLine("dtcompleted = " & sDate & ",")
                    sSQL.AppendLine("description = " & toSQLValueS(.GetRowCellValue(.FocusedRowHandle, "description").ToString) & ",")
                    sSQL.AppendLine("modifiedON = getdate() ")
                    sSQL.AppendLine("WHERE ID = " & toSQLValueS(.GetRowCellValue(.FocusedRowHandle, "ID").ToString))
                    'Εκτέλεση QUERY
                    Using oCmd As New SqlCommand(sSQL.ToString, CNDB)
                        oCmd.ExecuteNonQuery()
                    End Using
                    Frm.Vw_PROJECT_JOBSSUP_DTableAdapter.FillByProjectJobSUPID(Frm.DMDataSet.vw_PROJECT_JOBSSUP_D, System.Guid.Parse(ID))
                End If
                If .RowCount = 0 Then
                    Frm.cmdSendEmail.Enabled = False : Frm.cmdPrintAll.Enabled = False : Frm.cmdSendEmail.Enabled = False
                Else
                    Frm.cmdSendEmail.Enabled = True : Frm.cmdPrintAll.Enabled = True : Frm.cmdSendEmail.Enabled = True
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
        sSQL.AppendLine("Select T.id,FullTranshDescription,Description,Iskitchen,Iscloset,Isdoor,Issc,instdtDeliverDate,offerCusAcceptance
                        from vw_TRANSH t
                        where  T.cusid = " & sCusID & "order by description")
        FillCbo.TRANSH(Frm.cboTRANSH, sSQL)
    End Sub
    Public Sub DeleteRecord()
        If Frm.GridView1.FocusedRowHandle < 0 Then
            XtraMessageBox.Show("Δεν μπορείτε να διαγράψετε εγγραφή που επεξεργάζεστε. Αν θέλετε να φύγετε από την εγγραφή πατήστε ESC", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If Frm.GridView1.GetRowCellValue(Frm.GridView1.FocusedRowHandle, "ID") = Nothing Then Exit Sub
        If XtraMessageBox.Show("Θέλετε να διαγραφεί η τρέχουσα εγγραφή?", ProgProps.ProgTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            Dim sSQL As String = "DELETE FROM PROJECT_JOBSSUP_D WHERE ID = '" & Frm.GridView1.GetRowCellValue(Frm.GridView1.FocusedRowHandle, "ID").ToString & "'"
            Using oCmd As New SqlCommand(sSQL, CNDB)
                oCmd.ExecuteNonQuery()
            End Using
            Frm.Vw_PROJECT_JOBSSUP_DTableAdapter.FillByProjectJobSUPID(Frm.DMDataSet.vw_PROJECT_JOBSSUP_D, System.Guid.Parse(ID))
        End If
    End Sub
    Public Function CheckIfHasConnectedOrder() As Boolean
        Dim Cmd As SqlCommand, sdr As SqlDataReader
        Dim sSQL As String
        sSQL = "SELECT top 1 id as connectedProjectJobsID FROM SUP_ORDERS WHERE projectJobSUPID = " & toSQLValueS(ID)
        Cmd = New SqlCommand(sSQL.ToString, CNDB)
        sdr = Cmd.ExecuteReader()
        Dim connectedProjectJobsID As String
        If (sdr.Read() = True) Then
            If sdr.IsDBNull(sdr.GetOrdinal("connectedProjectJobsID")) = False Then connectedProjectJobsID = sdr.GetGuid(sdr.GetOrdinal("connectedProjectJobsID")).ToString Else connectedProjectJobsID = ""
            If connectedProjectJobsID <> "" Then
                ConnectedOrderID = connectedProjectJobsID
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
        sdr.Close()

    End Function

    Private Function CheckIfSupplierExist()
        Dim Cmd As SqlCommand, sdr As SqlDataReader
        Dim sSQL As String
        sSQL = "SELECT top 1 supID  FROM PROJECT_JOBSSUP_D WHERE supID is null and projectJobID= " & toSQLValueS(ID)
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
    Public Sub CreateOrder()
        Try
            Valid.ID = ID
            If Valid.ValiDationRules(Frm.Name, Frm, True, True) = False Then Exit Sub
            If Frm.GridView1.DataRowCount = 0 Then
                XtraMessageBox.Show("Δεν έχετε καταχωρήσει εργασίες. Δεν μπορεί να αποθηκευθεί η εγγραφή.", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            If CheckIfSupplierExist() = False Then
                XtraMessageBox.Show("Όλες οι προς εργασίες πρέπει να έχουν προμηθευτή.", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            If XtraMessageBox.Show("Θέλετε να μετατραπούν οι εργασίες σε παραγγελία?", ProgProps.ProgTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                Using oCmd As New SqlCommand("CreateOrderFromProjectJobSup", CNDB)
                    oCmd.CommandType = CommandType.StoredProcedure
                    oCmd.Parameters.AddWithValue("@projectJobSupID", ID)
                    oCmd.ExecuteNonQuery()
                End Using
                XtraMessageBox.Show("Η παραγγελία δημιουργήθηκε με επιτυχία.", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Information)
                If CheckIfHasConnectedOrder() = True Then Frm.cmdConvertToOrder.Text = "Ενημέρωση Παραγγελίας" : HasConnectedOrder = True : 
            End If
        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
    Private Function CheckIfHasProjectJobsDForOrder() As Boolean
        Dim Cmd As SqlCommand, sdr As SqlDataReader
        Dim sSQL As String
        sSQL = "SELECT count(id) as toOrderID FROM PROJECT_JOBSSUP_D WHERE toOrder = 1 and projectJobID= " & toSQLValueS(ID)
        Cmd = New SqlCommand(sSQL.ToString, CNDB)
        sdr = Cmd.ExecuteReader()
        Dim toOrderID As Integer
        If (sdr.Read() = True) Then
            If sdr.IsDBNull(sdr.GetOrdinal("toOrderID")) = False Then toOrderID = sdr.GetInt32(sdr.GetOrdinal("toOrderID")) Else toOrderID = 0
            sdr.Close()
            If toOrderID > 0 Then Return True Else Return False
        Else
            sdr.Close()
            Return False
        End If
    End Function

    Public Function CheckIfProjectJobsAreCompleted() As Boolean
        Dim Cmd As SqlCommand, sdr As SqlDataReader
        Dim sSQL As String
        sSQL = "SELECT id as CountProjectJob FROM PROJECT_JOBSSUP_D  WHERE completed = 0 and projectJobID= " & toSQLValueS(ID)
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
        Frm.chkCompleted.CheckState = CheckState.Unchecked
        Frm.txtComments.EditValue = Nothing : Frm.txtfProjectNameComplete.EditValue = Nothing : Frm.cmdConvertToOrder.Enabled = False
        AddRecord()

    End Sub
    Private Function CheckIfHasProjectJobNotCompleted() As Boolean
        Dim Cmd As SqlCommand, sdr As SqlDataReader
        Dim sSQL As String
        sSQL = "SELECT id FROM PROJECT_JOBSSUP WHERE completed = 0  and transhID= " & toSQLValueS(Frm.cboTRANSH.EditValue.ToString)
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
        sSQL = "SELECT fProjectNameComplete FROM PROJECT_JOBSSUP WHERE ID= " & toSQLValueS(ID)
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
            sSQL = "UPDATE PROJECT_JOBSSUP SET COMPLETED = 1 WHERE ID = " & toSQLValueS(ID)
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
            sSQL = "INSERT INTO PROJECT_JOBSSUP_D ([ID],[projectJobID], [description],[descriptionSup], [cmt], [completed], [dtCompleted],  [createdOn], [createdBy]) " &
                    "SELECT NEWID()," & toSQLValueS(ID) & ", [description],[descriptionSup], PJD.[cmt], PJD.[completed], [dtCompleted],  PJD.[createdOn], PJD.[createdBy] " &
                    "from TRANSH T 
                     inner join PROJECT_JOBSSUP PJ on PJ.transhID=T.I 
                     INNER  join PROJECT_JOBSSUP_D PJD ON PJD.projectJobID =PJ.ID 
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
        Cmd = New SqlCommand("Select TOP 1 PJ.id, MAX(ie.createdOn) as createdOn  FROM PROJECT_JOBSSUP PJ WHERE comefrom=0 and PJ.transhID= " & toSQLValueS(Frm.cboTRANSH.EditValue.ToString) & " group by PJ.ID ORDER BY createdOn DESC ", CNDB)
        sdr = Cmd.ExecuteReader()
        If (sdr.Read() = True) Then GetLastProjectJobID = sdr.GetGuid(sdr.GetOrdinal("ID")).ToString.ToUpper
        sdr.Close()
        Return GetLastProjectJobID
    End Function
    Private Sub AddRecord()
        Frm.txtCode.Text = DBQ.GetNextId("PROJECT_JOBSSUP")
        Frm.cmdSendEmail.Enabled = False : Frm.cmdPrintAll.Enabled = False : Frm.cmdSendEmail.Enabled = False
        EnabletxtInstellipseFilenameComplete()
        '΅Εισαγωγή εγγραφής απευθείας στην βάση
        Dim sResult As Boolean = sResult = DBQ.InsertNewData(DBQueries.InsertMode.OneLayoutControl, "PROJECT_JOBSSUP", Frm.LayoutControl1,,, ID, True, "comefrom", sComeFrom)
        If sResult = False Then
            XtraMessageBox.Show("Υπήρξε πρόβλημα κατά την διαδικασία ανοίγματος εργασίας.", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Frm.Close()
        End If
        Mode = FormMode.EditRecord
    End Sub

    Public Sub PrintDocument()
        Dim supID As String, sSupID() As String : GetSupplierEmails(supID) : Frm.txtTo.Tag = supID
        sSupID = Frm.txtTo.Tag.ToString.Split(";")
        For Each supID In sSupID
            Dim report As New RepCUSProjectJobsSUP
            report.Parameters.Item(0).Value = ID
            report.Parameters.Item(1).Value = supID
            report.CreateDocument()
            Dim printTool As New ReportPrintTool(report)
            printTool.ShowRibbonPreview()
        Next
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
                sSQL = "UPDATE PROJECT_JOBSSUP SET completed = 1 ,fProjectNameComplete =  " & toSQLValueS(Path.GetFileName(Frm.XtraOpenFileDialog1.FileName).ToString) & ", fProjectComplete =  BulkColumn from Openrowset( Bulk " & toSQLValueS(ProgProps.ServerPath & Path.GetFileName(Frm.XtraOpenFileDialog1.FileName)) & ", Single_Blob) as ProjectJobF where ID = " & toSQLValueS(ID)

                'Εκτέλεση QUERY
                Using oCmd As New SqlCommand(sSQL, CNDB)
                    oCmd.ExecuteNonQuery()
                End Using
                Frm.chkCompleted.CheckState = CheckState.Checked : Frm.GridView1.OptionsBehavior.Editable = False
                DisabletxtProjectJobFilenameComplete()
                XtraMessageBox.Show("Το αρχείο αποθηκεύτηκε με επιτυχία", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub
    Public Sub AttachmentSelect()
        Frm.XtraOpenFileDialog1.FilterIndex = 1
        Frm.XtraOpenFileDialog1.InitialDirectory = "C:\"
        Frm.XtraOpenFileDialog1.Title = "Open File"
        Frm.XtraOpenFileDialog1.CheckFileExists = False
        Frm.XtraOpenFileDialog1.Multiselect = False
        Dim result As DialogResult = Frm.XtraOpenFileDialog1.ShowDialog()
        If result = DialogResult.OK Then
            Try
                My.Computer.FileSystem.CopyFile(Frm.XtraOpenFileDialog1.FileName, ProgProps.ServerPath & Path.GetFileName(Frm.XtraOpenFileDialog1.FileName), True)
                Frm.txtAttachFile.EditValue = Frm.XtraOpenFileDialog1.FileName
            Catch ex As Exception
                XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub
    Public Sub DeleteFile()
        If Frm.txtfProjectNameComplete.EditValue = Nothing Then Exit Sub
        If XtraMessageBox.Show("Θέλετε να διαγραφεί το αρχείο?", ProgProps.ProgTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            Dim sSQL As String
            sSQL = "UPDATE PROJECT_JOBSSUP SET completed = 0,fProjectNameComplete =  NULL ,fProjectComplete =  NULL where ID = " & toSQLValueS(ID)
            'Εκτέλεση QUERY
            Using oCmd As New SqlCommand(sSQL, CNDB)
                oCmd.ExecuteNonQuery()
            End Using
            Frm.chkCompleted.CheckState = CheckState.Unchecked
            Frm.GridView1.OptionsBehavior.Editable = True
            Frm.txtfProjectNameComplete.EditValue = Nothing
        End If

    End Sub
    Public Sub ValidateEmail(ByVal sEmailMode As Int16)
        emailMode = sEmailMode
        If Frm.GridView1.RowCount = 0 Then XtraMessageBox.Show("Δεν υπάρχουν εργασίες προς αποστολή", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error) : Exit Sub
        If Frm.txtBody.Text = "" Then XtraMessageBox.Show("Παρακαλώ συμπληρώστε κείμενο", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error) : Exit Sub
        If Frm.txtSubject.Text = "" Then XtraMessageBox.Show("Παρακαλώ συμπληρώστε το θέμα", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error) : Exit Sub
        If Frm.txtTo.Text.Trim = "" Then XtraMessageBox.Show("Δεν υπάρχει καταχωρήμενο email στον προμηθευτή.", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error) : Exit Sub
        If HasConnectedOrder = False Then XtraMessageBox.Show("Δεν έχετε δημιουργήσει παραγγελία.", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error) : Exit Sub
        If XtraMessageBox.Show("Θέλετε να αποσταλεί το Email?", ProgProps.ProgTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            SendEmailExportReport()
            Frm.PROJECT_JOBSSUP_MAILTableAdapter.FillByProjectJobSUPID(Frm.DMDataSet.PROJECT_JOBSSUP_MAIL, System.Guid.Parse(ID))
        End If
    End Sub
    Private Sub SendEmailExportReport()
        Dim Cmd As SqlCommand, sdr As SqlDataReader
        Dim Emails As New SendEmail
        Dim statusMsg As String
        Dim sEmailTo As String, sEmailsTo() As String, sSupID() As String
        Dim sSubject As String
        Dim sBody As String
        Dim sFile As String
        Dim sFile2 As String
        Dim sSQL As String
        Try

            sEmailsTo = Frm.txtTo.EditValue.ToString.Split(";")
            sSupID = Frm.txtTo.Tag.ToString.Split(";")
            Dim sIndex As Int16 = 0
            For Each sEmailTo In sEmailsTo
                Dim report As New RepCUSProjectJobsSUP()
                report.Parameters.Item(0).Value = ID
                If sEmailTo.Length > 0 Then
                    report.Parameters.Item(1).Value = sSupID(sIndex)
                    sBody = Frm.txtBody.EditValue
                    sSubject = Frm.txtSubject.EditValue
                    sFile = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) & "\Downloads\Ενημερώτικό έντυπο εργασιών προμηθευτή.pdf"
                    sFile2 = Frm.txtAttachFile.EditValue
                    report.CreateDocument()
                    report.ExportToPdf(sFile)
                    report.Dispose()
                    report = Nothing
                    My.Computer.FileSystem.CopyFile(sFile, ProgProps.ServerPath & Path.GetFileName(sFile), True)
                    If sFile2.Length > 0 Then My.Computer.FileSystem.CopyFile(sFile2, ProgProps.ServerPath & Path.GetFileName(sFile2), True)


                    If CNDB.Database <> "DreamyKitchen" Or Debugger.IsAttached = True Then sEmailTo = "johnmavroselinos@gmail.com;dreamykitchen@gmail.com"

                    If Emails.SendEmail(ProgProps.PJEmailSupFrom, sSubject, sBody, sEmailTo, sFile & IIf(sFile2.Length > 0, ";", "") & sFile2, statusMsg) = True Then
                        Select Case emailMode
                            Case 1 : sSQL = "Update PROJECT_JOBSSUP SET emailApp = 1,DateOfEmailApp=getdate() WHERE ID = " & toSQLValueS(ID)
                        End Select

                        Cmd = New SqlCommand(sSQL, CNDB) : Cmd.ExecuteNonQuery()
                        ' Εισαγωγή ιστορικού email
                        sSQL = "INSERT INTO [PROJECT_JOBSSUP_MAIL] (projectjobID,emailFrom,emailTo,emailSubject,emailBody,DateofEmail,[createdBy],[createdOn],ComeFrom,emailMode,Attachment2Name,Attachment " & IIf(sFile2.Length > 0, ",Attachment2)", ")") &
                            "Select " & toSQLValueS(ID) & "," &
                                        toSQLValueS(ProgProps.PJEmailSupFrom) & "," &
                                        toSQLValueS(sEmailTo) & "," &
                                        toSQLValue(Frm.txtSubject) & "," &
                                        toSQLValue(Frm.txtBody) & ",getdate(), " &
                                        toSQLValueS(UserProps.ID.ToString) &
                                        ", getdate(), " &
                                        sComeFrom & "," &
                                        emailMode & ", " &
                                        IIf(sFile2.Length > 0, toSQLValueS(Path.GetFileName(sFile2)), "NULL") & ", " &
                                         " * FROM  Openrowset( Bulk " & toSQLValueS(ProgProps.ServerPath & Path.GetFileName(sFile)) & ", Single_Blob) as F " &
                                        IIf(sFile2.Length > 0, ",Openrowset( Bulk " & toSQLValueS(ProgProps.ServerPath & Path.GetFileName(sFile2)) & ", Single_Blob) as F2", "") & ";"
                        Using oCmd As New SqlCommand(sSQL, CNDB)
                            oCmd.ExecuteNonQuery()
                        End Using
                        EmailSended = True : Frm.EmailSended = True

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
