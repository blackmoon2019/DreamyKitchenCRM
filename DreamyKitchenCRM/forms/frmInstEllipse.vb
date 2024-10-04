
Imports System.ComponentModel
Imports System.Data.SqlClient
Imports System.IO
Imports DevExpress.XtraBars.Navigation
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports DevExpress.XtraReports.UI

Imports DreamyKitchenCRM.DM_TRANSTableAdapters

Public Class frmInstEllipse

    Private sID As String
    Private sINST_ID As String
    Private Ctrl As DevExpress.XtraGrid.Views.Grid.GridView
    Private Frm As DevExpress.XtraEditors.XtraForm
    Public Mode As Byte
    Private ScanFile As ScanToPDF
    Private Prog_Prop As New ProgProp
    Private Valid As New ValidateControls
    Private FScrollerExist As Boolean = False
    Private Log As New Transactions
    Private FillCbo As New FillCombos
    Private ManageCbo As New CombosManager
    Private DBQ As New DBQueries
    Private LoadForms As New FormLoader
    Private Cls As New ClearControls
    Private CtrlCombo As DevExpress.XtraEditors.LookUpEdit
    Private CalledFromCtrl As Boolean
    Private sComeFrom As Integer
    Private SaveButtonPressed As Boolean = False
    Private emailMode As Int16 = 0
    Private HasConnectedOrder As Boolean = False
    Private ConnectedOrderID As String = ""


    Public WriteOnly Property ID As String
        Set(value As String)
            sID = value
        End Set
    End Property
    Public WriteOnly Property INST_ID As String
        Set(value As String)
            sINST_ID = value
        End Set
    End Property
    Public WriteOnly Property ComeFrom As Integer
        Set(value As Integer)
            sComeFrom = value
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

    Private Sub frmInstEllipse_Load(sender As Object, e As EventArgs) Handles Me.Load
        'TODO: This line of code loads data into the 'DreamyKitchenDataSet.vw_FILE_CAT' table. You can move, or remove it, as needed.
        Me.Vw_FILE_CATTableAdapter.Fill(Me.DreamyKitchenDataSet.vw_FILE_CAT)
        Me.Vw_ORDER_MANAGERSTableAdapter.Fill(Me.DreamyKitchenDataSet.vw_ORDER_MANAGERS)
        'TODO: This line of code loads data into the 'DreamyKitchenDataSet.vw_SUP' table. You can move, or remove it, as needed.
        Me.Vw_SUPTableAdapter.Fill(Me.DreamyKitchenDataSet.vw_SUP)
        Me.CCT_TRANSHTableAdapter.Fill(Me.DM_TRANS.CCT_TRANSH)
        AddHandler GridControl1.EmbeddedNavigator.ButtonClick, AddressOf Grid_EmbeddedNavigator_ButtonClick

        FillCbo.INST(cboINST)
        Select Case Mode
            Case FormMode.NewRecord
                If sComeFrom = 0 Then NewRecord() : cmdViewOrder.Enabled = False
                TabNavigationPage2.Enabled = False
            Case FormMode.EditRecord
                SaveButtonPressed = True
                Dim sFields As New Dictionary(Of String, String)
                LoadForms.LoadForm(LayoutControl1, "Select * from vw_INST_ELLIPSE where id =" & toSQLValueS(sID), sFields)
                If sFields("comeFrom") = "False" Then sComeFrom = 0 Else sComeFrom = 1
                FillCbo.FillCheckedListINST_ELLIPSE_SER(chkSER, FormMode.EditRecord, sID)
                Me.INST_ELLIPSE_JOBSTableAdapter.FillBYinstEllipseID(Me.DmDataSet.INST_ELLIPSE_JOBS, System.Guid.Parse(sID))
                If sINST_ID Is Nothing Then sINST_ID = cboINST.EditValue.ToString
                'Αφορά μόνο τον πελάτη και ελέγχει αν υπάρχει έλλειψη πριν την τελευταία . Αν υπάρχει δεν μπορεί να την επεξεργαστεί αυτήν
                If sComeFrom = 0 Then
                    If CheckIfHasOtherElllipse() Then LayoutControl1.Enabled = False
                    If CheckIfHasConnectedOrder() = True Then cmdConvertToOrder.Text = "Ενημέρωση Παραγγελίας" : HasConnectedOrder = True : 
                Else
                    ConnectedOrderID = sID
                End If
                txtInstellipseFilename.ReadOnly = False
                txtInstellipseFilenameD.ReadOnly = False
                txtInstellipseFilenameC.ReadOnly = False
                txtInstellipseFilenameSC.ReadOnly = False
                GridControl1.ForceInitialize()
                If GridView1.DataRowCount = 0 Then cmdSendEmail.Enabled = False : cmdPrintAll.Enabled = False : cmdSendApointmentEmail.Enabled = False : cmdDefEmail.Enabled = False
                If sFields("completed") = "True" Then dtDateDelivered.Enabled = False : txtTmINFrom.Enabled = False : txtTmINTo.Enabled = False : chkSER.Enabled = False
                If sFields("emailInfComplete") = "True" Then DisabletxtInstellipseFilenameComplete()
        End Select
        LInst.Enabled = False
        If sComeFrom = 1 Then
            LayoutControlGroup1.Text = "Αφορά Προμηθευτή"
            chkSER.Enabled = False : LdtDateDelivered.Enabled = False : LTmINFrom.Enabled = False : LTmINTo.Enabled = False
            cmdNewInstEllipse.Enabled = False
            DisabletxtInstellipseFilename() : DisabletxtInstellipseFilenameComplete()
            GridView1.OptionsBehavior.Editable = True : cmdViewOrder.Enabled = False : cmdConvertToOrder.Enabled = False
            LoadForms.RestoreLayoutFromXml(GridView1, "INST_ELLIPSE_JOBS_def_SUP.xml")
        Else
            LayoutControlGroup1.Text = "Αφορά Πελάτη"
            LCus.Enabled = False
            cboTRANSH.Properties.Buttons.Item(0).Enabled = False
            cboTRANSH.Properties.Buttons.Item(1).Enabled = False
            cboTRANSH.Properties.Buttons.Item(2).Enabled = True
            cboTRANSH.Properties.Buttons.Item(3).Enabled = False
            cboTRANSH.ReadOnly = True
            If dtDateDelivered.EditValue IsNot Nothing And
                (txtInstellipseFilename.EditValue IsNot Nothing Or txtInstellipseFilenameD.EditValue IsNot Nothing Or
                txtInstellipseFilenameC.EditValue IsNot Nothing Or txtInstellipseFilenameSC.EditValue IsNot Nothing) Then DisabletxtInstellipseFilename()
            LoadForms.RestoreLayoutFromXml(GridView1, "INST_ELLIPSE_JOBS_def.xml")
        End If

        Me.CenterToScreen()
        cmdSave.Enabled = IIf(Mode = FormMode.NewRecord, UserProps.AllowInsert, UserProps.AllowEdit)

    End Sub
    Private Sub cmdExit_Click(sender As Object, e As EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub
    Private Function ValidationsExit() As Boolean
        If sID = Nothing Then Return False
        If SaveButtonPressed = False Then
            If XtraMessageBox.Show("Θέλετε να σώσετε την εγγραφή?", ProgProps.ProgTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbNo Then
                Dim sSQL As String = "DELETE FROM INST_ELLIPSE WHERE ID = '" & sID & "'"
                Using oCmd As New SqlCommand(sSQL, CNDB)
                    oCmd.ExecuteNonQuery()
                End Using
            End If
        End If
        If sComeFrom = 0 Then If CheckForInstName() = False Then Return False
        If HasConnectedOrder = False And sComeFrom = 0 Then If CheckIfHasRecordsForOrder() = True Then Return False
        If sComeFrom = 0 Then
            If GridView1.DataRowCount > 0 Then
                'If CheckIfHasSendInfEmail() = False Then Return False
                If CheckIfInstJobsAreCompleted() = True And txtInstellipseFilenameComplete.EditValue = Nothing Then
                    XtraMessageBox.Show("Όλες οι εκκρεμότητες είναι ολοκληρωμένες χωρίς να έχετε επισυνάψει έντυπο ολοκλήρωσης. Δεν μπορεί να αποθηκευθεί η εγγραφή.", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return False
                End If
            End If

            If CheckIfHasSendInfCompleteEmail() = False Then Return False
        End If
        Return True
    End Function
    Private Sub DisabletxtInstellipseFilename()
        txtInstellipseFilename.ReadOnly = True
        txtInstellipseFilename.Properties.Buttons.Item(0).Enabled = False
        txtInstellipseFilename.Properties.Buttons.Item(1).Enabled = True
        txtInstellipseFilename.Properties.Buttons.Item(2).Enabled = False

        txtInstellipseFilenameD.ReadOnly = True
        txtInstellipseFilenameD.Properties.Buttons.Item(0).Enabled = False
        txtInstellipseFilenameD.Properties.Buttons.Item(1).Enabled = True
        txtInstellipseFilenameD.Properties.Buttons.Item(2).Enabled = False

        txtInstellipseFilenameC.ReadOnly = True
        txtInstellipseFilenameC.Properties.Buttons.Item(0).Enabled = False
        txtInstellipseFilenameC.Properties.Buttons.Item(1).Enabled = True
        txtInstellipseFilenameC.Properties.Buttons.Item(2).Enabled = False

        txtInstellipseFilenameSC.ReadOnly = True
        txtInstellipseFilenameSC.Properties.Buttons.Item(0).Enabled = False
        txtInstellipseFilenameSC.Properties.Buttons.Item(1).Enabled = True
        txtInstellipseFilenameSC.Properties.Buttons.Item(2).Enabled = False

    End Sub
    Private Sub EnabletxtInstellipseFilename()
        txtInstellipseFilename.ReadOnly = False
        txtInstellipseFilename.Properties.Buttons.Item(0).Enabled = True
        txtInstellipseFilename.Properties.Buttons.Item(1).Enabled = True
        txtInstellipseFilename.Properties.Buttons.Item(2).Enabled = True

        txtInstellipseFilenameD.ReadOnly = False
        txtInstellipseFilenameD.Properties.Buttons.Item(0).Enabled = True
        txtInstellipseFilenameD.Properties.Buttons.Item(1).Enabled = True
        txtInstellipseFilenameD.Properties.Buttons.Item(2).Enabled = True

        txtInstellipseFilenameC.ReadOnly = False
        txtInstellipseFilenameC.Properties.Buttons.Item(0).Enabled = True
        txtInstellipseFilenameC.Properties.Buttons.Item(1).Enabled = True
        txtInstellipseFilenameC.Properties.Buttons.Item(2).Enabled = True

        txtInstellipseFilenameSC.ReadOnly = False
        txtInstellipseFilenameSC.Properties.Buttons.Item(0).Enabled = True
        txtInstellipseFilenameSC.Properties.Buttons.Item(1).Enabled = True
        txtInstellipseFilenameSC.Properties.Buttons.Item(2).Enabled = True
    End Sub
    Private Sub DisabletxtInstellipseFilenameComplete()
        txtInstellipseFilenameComplete.ReadOnly = True
        txtInstellipseFilenameComplete.Properties.Buttons.Item(0).Enabled = False
        txtInstellipseFilenameComplete.Properties.Buttons.Item(1).Enabled = True
        txtInstellipseFilenameComplete.Properties.Buttons.Item(2).Enabled = False
    End Sub
    Private Sub EnabletxtInstellipseFilenameComplete()
        txtInstellipseFilenameComplete.ReadOnly = False
        txtInstellipseFilenameComplete.Properties.Buttons.Item(0).Enabled = True
        txtInstellipseFilenameComplete.Properties.Buttons.Item(1).Enabled = True
        txtInstellipseFilenameComplete.Properties.Buttons.Item(2).Enabled = True
    End Sub

    Private Function CheckIfHasConnectedOrder() As Boolean
        Dim Cmd As SqlCommand, sdr As SqlDataReader
        Dim sSQL As String
        sSQL = "SELECT top 1 id as connectedEllipseID FROM INST_ELLIPSE WHERE connectedEllipseID = " & toSQLValueS(sID)
        Cmd = New SqlCommand(sSQL.ToString, CNDB)
        sdr = Cmd.ExecuteReader()
        Dim connectedEllipseID As String
        If (sdr.Read() = True) Then
            If sdr.IsDBNull(sdr.GetOrdinal("connectedEllipseID")) = False Then connectedEllipseID = sdr.GetGuid(sdr.GetOrdinal("connectedEllipseID")).ToString Else connectedEllipseID = ""
            If connectedEllipseID <> "" Then
                ConnectedOrderID = connectedEllipseID : cmdViewOrder.Enabled = True
                Return True
            Else
                cmdViewOrder.Enabled = False
                Return False
            End If
        Else
            cmdViewOrder.Enabled = False
            Return False
        End If
        sdr.Close()

    End Function
    Private Function CheckIfHasOtherElllipse() As Boolean
        Dim Cmd As SqlCommand, sdr As SqlDataReader
        Dim sSQL As New System.Text.StringBuilder
        sSQL.AppendLine("SELECT count (id) as CountEllipse  FROM INST_ELLIPSE WHERE ID= " & toSQLValueS(sID) & " and createdOn<(select max(createdon) from INST_ELLIPSE WHERE comefrom = 0 and instID= " & toSQLValueS(sINST_ID) & ")")
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
                         WHERE instEllipseID= " & toSQLValueS(sID) & " and toOrder = 1 and " & toSQLValueS(sID) &
                         " Not In (Select Top 1 ID from INST_ELLIPSE  where connectedEllipseID = " & toSQLValueS(sID) & ")")
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
                        WHERE instEllipseID= " & toSQLValueS(sID) & "  AND emailInf IS NOT NULL")
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
                        WHERE ID= " & toSQLValueS(sID) & " AND IE.completed = 1 ")
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
        cmdNewInstEllipse.Enabled = False
        txtCode.Text = DBQ.GetNextId("INST_ELLIPSE")
        If sINST_ID IsNot Nothing Then cboINST.EditValue = System.Guid.Parse(sINST_ID)
        FillCbo.FillCheckedListINST_ELLIPSE_SER(chkSER, FormMode.NewRecord)
        cmdSendEmail.Enabled = False : cmdPrintAll.Enabled = False : cmdSendApointmentEmail.Enabled = False : cmdDefEmail.Enabled = False
        txtInstellipseFilename.ReadOnly = False : txtInstellipseFilenameD.ReadOnly = False
        txtInstellipseFilenameC.ReadOnly = False : txtInstellipseFilenameSC.ReadOnly = False
        EnabletxtInstellipseFilename() : EnabletxtInstellipseFilenameComplete()
        '΅Εισαγωγή εγγραφής απευθείας στην βάση
        Dim sResult As Boolean = DBQ.InsertNewData(DBQueries.InsertMode.OneLayoutControl, "INST_ELLIPSE", LayoutControl1,,, sID, True, "comefrom", sComeFrom)
        If sResult = False Then
            XtraMessageBox.Show("Υπήρξε πρόβλημα κατά την διαδικασία ανοίγματος εκκρεμότητας.", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Close()
        End If
        Mode = FormMode.EditRecord
    End Sub

    Private Sub frmInstEllipse_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        If Me.WindowState = FormWindowState.Maximized Then frmMain.XtraTabbedMdiManager1.Dock(Me, frmMain.XtraTabbedMdiManager1)
    End Sub

    Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click
        Dim sResult As Boolean
        Dim sSQL As String
        Try
            If Valid.ValidateForm(LayoutControl1) Then
                ' Έλεγχος επισύναψης εντύπου
                'If CheckIfInstEllipseFExist() = False Then Exit Sub
                Select Case Mode
                    Case FormMode.NewRecord
                        sID = System.Guid.NewGuid.ToString
                        ' Έλεγχος επισύναψης εντύπου και καταχώρησης εκκρεμοτήτων
                        If ValidateRecord() Then sResult = DBQ.InsertNewData(DBQueries.InsertMode.OneLayoutControl, "INST_ELLIPSE", LayoutControl1,,, sID, True, "comefrom", sComeFrom)
                    Case FormMode.EditRecord
                        If sComeFrom = 0 Then
                            If ValidateRecord() Then sResult = DBQ.UpdateNewData(DBQueries.InsertMode.OneLayoutControl, "INST_ELLIPSE", LayoutControl1,,, sID, True)
                        Else
                            If sComeFrom = 1 And cboSUP.EditValue = Nothing Then
                                XtraMessageBox.Show("Δεν έχετε επιλέξει Προμηθευτή.", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
                                Exit Sub
                            End If
                            sResult = DBQ.UpdateNewData(DBQueries.InsertMode.OneLayoutControl, "INST_ELLIPSE", LayoutControl1,,, sID, True)
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
                    For Each item As DevExpress.XtraEditors.Controls.CheckedListBoxItem In chkSER.CheckedItems
                        sSQL = "INSERT INTO INST_ELLIPSE_SER (instEllipseID,empID,[createdBy],[createdOn]) values (" & toSQLValueS(sID) & "," & toSQLValueS(item.Tag.ToString()) & "," & toSQLValueS(UserProps.ID.ToString) & ", getdate() )"
                        Using oCmd As New SqlCommand(sSQL, CNDB)
                            oCmd.ExecuteNonQuery()
                        End Using
                    Next
                    FillCbo.FillCheckedListINST_ELLIPSE_SER(chkSER, FormMode.EditRecord, sID)
                    SaveButtonPressed = True : cmdNewInstEllipse.Enabled = True : TabNavigationPage2.Enabled = True
                    XtraMessageBox.Show("Η εγγραφή αποθηκέυτηκε με επιτυχία", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Function ValidateRecord() As Boolean
        GridControl1.ForceInitialize()
        If CheckIfTimeisValid() = False Then Return False
        If GridView1.DataRowCount = 0 Then
            XtraMessageBox.Show("Δεν έχετε καταχωρήσει εκκρεμότητες. Δεν μπορεί να αποθηκευθεί η εγγραφή.", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If
        If txtInstellipseFilename.EditValue = Nothing And txtInstellipseFilenameD.EditValue = Nothing And txtInstellipseFilenameC.EditValue = Nothing And txtInstellipseFilenameSC.EditValue = Nothing Then
            XtraMessageBox.Show("Δεν έχετε επισυνάψει έντυπο εκκρεμοτήτων. Δεν μπορεί να αποθηκευθεί η εγγραφή.", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If
        If dtDateDelivered.EditValue IsNot Nothing And chkSER.CheckedItemsCount = 0 Then
            XtraMessageBox.Show("Έχετε επιλέξει ημερομηνία τοποθέτησης χωρίς να επιλέξετε συνεργείο. Δεν μπορεί να αποθηκευθεί η εγγραφή.", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If
        If chkCompleted.CheckState = CheckState.Checked And dtDateDelivered.EditValue = Nothing Then
            XtraMessageBox.Show("Δεν μπορείτε να ολοκληρώσετε την εκκρεμότητα χωρίς ημερομηνία επίσκεψης. Δεν μπορεί να αποθηκευθεί η εγγραφή.", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If
        If CheckIfInstJobsAreCompleted() And txtInstellipseFilenameComplete.EditValue = Nothing Then
            XtraMessageBox.Show("Έχετε ολοκληρώσει όλες τις εργασίες και δεν έχετε επισυνάψει το έντυπο ολοκλήρωσης. Δεν μπορεί να αποθηκευθεί η εγγραφή.", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If
        If sComeFrom = 1 And cboSUP.EditValue = Nothing Then
            XtraMessageBox.Show("Δεν έχετε επιλέξει Προμηθευτή.", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If
        Return True
    End Function
    Private Function CheckIfTimeisValid() As Boolean
        If dtDateDelivered.EditValue IsNot Nothing Then
            If txtTmINFrom.Text = "00:00" Or txtTmINTo.Text = "00:00" Then XtraMessageBox.Show("Η ώρα δεν μπορεί να είναι 00:00", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error) : Return False
            txtTmINFrom.EditValue = txtTmINFrom.Text : txtTmINTo.EditValue = txtTmINTo.Text
            Dim Hours As Long = DateDiff(DateInterval.Hour, txtTmINFrom.EditValue, txtTmINTo.EditValue)
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
        If chkCompleted.Checked = True Then
            Dim Cmd As SqlCommand, sdr As SqlDataReader
            Dim sSQL As String = "SELECT fInstEllipseName  FROM INST_ELLIPSE WHERE ID= " & toSQLValueS(sID)
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
    Private Sub GridView1_InvalidRowException(sender As Object, e As InvalidRowExceptionEventArgs) Handles GridView1.InvalidRowException
        e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction
    End Sub
    Private Sub Grid_EmbeddedNavigator_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.NavigatorButtonClickEventArgs)
        Select Case e.Button.ButtonType
            Case e.Button.ButtonType.Remove : DeleteRecord() : e.Handled = True
            Case e.Button.ButtonType.Append
                If txtInstellipseFilename.EditValue = Nothing And txtInstellipseFilenameD.EditValue = Nothing And txtInstellipseFilenameC.EditValue = Nothing And txtInstellipseFilenameSC.EditValue = Nothing Then
                    XtraMessageBox.Show("Δεν έχετε επισυνάψει έντυπο εκκρεμοτήτων.", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
                    e.Handled = True
                End If
        End Select
    End Sub
    Private Sub GridView1_KeyDown(sender As Object, e As KeyEventArgs) Handles GridView1.KeyDown
        If e.KeyCode = Keys.Delete And UserProps.AllowDelete = True Then DeleteRecord()
        If e.KeyCode = Keys.Down And UserProps.AllowInsert Then
            If sender.FocusedRowHandle < 0 Then Exit Sub
            Dim viewInfo As GridViewInfo = TryCast(sender.GetViewInfo(), GridViewInfo)
            If sender.FocusedRowHandle = viewInfo.RowsInfo.Last().RowHandle Then
                If txtInstellipseFilename.EditValue = Nothing And txtInstellipseFilenameD.EditValue = Nothing And txtInstellipseFilenameC.EditValue = Nothing And txtInstellipseFilenameSC.EditValue = Nothing Then
                    XtraMessageBox.Show("Δεν έχετε επισυνάψει έντυπο εκκρεμοτήτων. Δεν μπορεί να αποθηκευθεί η εγγραφή.", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
                GridView1.PostEditor() : GridView1.AddNewRow()
            End If
        End If
    End Sub
    Private Sub DeleteRecord()
        If GridView1.FocusedRowHandle < 0 Then
            XtraMessageBox.Show("Δεν μπορείτε να διαγράψετε εγγραφή που επεξεργάζεστε. Αν θέλετε να φύγετε από την εγγραφή πατήστε ESC", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        If GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "ID") = Nothing Then Exit Sub
        If XtraMessageBox.Show("Θέλετε να διαγραφεί η τρέχουσα εγγραφή?", ProgProps.ProgTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            Dim sSQL As String = "DELETE FROM INST_ELLIPSE_JOBS WHERE ID = '" & GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "ID").ToString & "'"
            Using oCmd As New SqlCommand(sSQL, CNDB)
                oCmd.ExecuteNonQuery()
            End Using
            Me.INST_ELLIPSE_JOBSTableAdapter.FillBYinstEllipseID(Me.DmDataSet.INST_ELLIPSE_JOBS, System.Guid.Parse(sID))
        End If
    End Sub
    Private Sub GridView1_ValidateRow(sender As Object, e As ValidateRowEventArgs) Handles GridView1.ValidateRow
        Dim sSQL As New System.Text.StringBuilder
        Dim CompletedCell As String = "", sDate As String
        Dim missing As String, replacement As String, orderError As String, toOrder As String
        Try
            sSQL.Clear()
            If e.RowHandle = GridControl1.NewItemRowHandle Then
                If GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "name").ToString = "" Then
                    e.ErrorText = "Παρακαλώ συμπληρώστε την έλλειψη"
                    e.Valid = False
                    Exit Sub
                End If
                sSQL.AppendLine("INSERT INTO INST_ELLIPSE_JOBS (instEllipseID,instID,name,nameSup,cmt,completed,missing,replacement,orderError,toOrder,dtCompleted,[modifiedBy],[createdby],[createdOn])")
                sSQL.AppendLine("Select " & toSQLValueS(sID) & ",")
                sSQL.AppendLine(toSQLValueS(sINST_ID) & ",")
                sSQL.AppendLine(toSQLValueS(GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "name").ToString) & ",")
                sSQL.AppendLine(toSQLValueS(GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "nameSup").ToString) & ",")
                sSQL.AppendLine(toSQLValueS(GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "cmt").ToString) & ",")
                CompletedCell = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "completed").ToString : If CompletedCell = "" Then CompletedCell = "0"
                sSQL.AppendLine("completed = " & toSQLValueS(CompletedCell) & ",")
                missing = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "missing").ToString : If missing = "" Then missing = "0"
                sSQL.AppendLine("missing = " & toSQLValueS(missing) & ",")
                replacement = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "replacement").ToString : If replacement = "" Then replacement = "0"
                sSQL.AppendLine("replacement = " & toSQLValueS(replacement) & ",")
                orderError = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "orderError").ToString : If orderError = "" Then orderError = "0"
                sSQL.AppendLine("orderError= " & toSQLValueS(orderError) & ",")
                toOrder = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "toOrder").ToString : If toOrder = "" Then toOrder = "0"
                sSQL.AppendLine("toOrder= " & toSQLValueS(toOrder) & ",")
                sDate = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "dtCompleted").ToString
                If sDate <> "" Then sDate = toSQLValueS(CDate(sDate).ToString("yyyyMMdd")) Else sDate = "NULL"
                sSQL.AppendLine(sDate & ",")
                sSQL.Append(toSQLValueS(UserProps.ID.ToString) & "," & toSQLValueS(UserProps.ID.ToString) & ", getdate()")
                'Εκτέλεση QUERY
                Using oCmd As New SqlCommand(sSQL.ToString, CNDB)
                    oCmd.ExecuteNonQuery()
                End Using
                Me.INST_ELLIPSE_JOBSTableAdapter.FillBYinstEllipseID(Me.DmDataSet.INST_ELLIPSE_JOBS, System.Guid.Parse(sID))
            Else
                sSQL.AppendLine("UPDATE INST_ELLIPSE_JOBS	SET name= " & toSQLValueS(GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "name").ToString) & ",")
                sSQL.AppendLine("nameSup = " & toSQLValueS(GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "nameSup").ToString) & ",")
                sSQL.AppendLine("instID = " & toSQLValueS(sINST_ID) & ",")
                sSQL.AppendLine("modifiedBY = " & toSQLValueS(UserProps.ID.ToString) & ",")
                sSQL.AppendLine("cmt = " & toSQLValueS(GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "cmt").ToString) & ",")
                CompletedCell = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "completed").ToString : If CompletedCell = "" Then CompletedCell = "0"
                sSQL.AppendLine("completed = " & toSQLValueS(CompletedCell) & ",")
                missing = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "missing").ToString : If missing = "" Then missing = "0"
                sSQL.AppendLine("missing= " & toSQLValueS(missing) & ",")
                replacement = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "replacement").ToString : If replacement = "" Then replacement = "0"
                sSQL.AppendLine("replacement = " & toSQLValueS(replacement) & ",")
                orderError = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "orderError").ToString : If orderError = "" Then orderError = "0"
                sSQL.AppendLine("orderError= " & toSQLValueS(orderError) & ",")
                toOrder = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "toOrder").ToString : If toOrder = "" Then toOrder = "0"
                sSQL.AppendLine("toOrder= " & toSQLValueS(toOrder) & ",")


                sDate = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "dtCompleted").ToString
                If sDate <> "" Then sDate = toSQLValueS(CDate(sDate).ToString("yyyyMMdd")) Else sDate = "NULL"
                sSQL.AppendLine("dtcompleted = " & sDate & ",")
                sSQL.AppendLine("modifiedON = getdate() ")
                sSQL.AppendLine("WHERE ID = " & toSQLValueS(GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "ID").ToString))
                'Εκτέλεση QUERY
                Using oCmd As New SqlCommand(sSQL.ToString, CNDB)
                    oCmd.ExecuteNonQuery()
                End Using
                Me.INST_ELLIPSE_JOBSTableAdapter.FillBYinstEllipseID(Me.DmDataSet.INST_ELLIPSE_JOBS, System.Guid.Parse(sID))
            End If
            If GridView1.RowCount = 0 Then
                cmdSendEmail.Enabled = False : cmdPrintAll.Enabled = False : cmdSendApointmentEmail.Enabled = False : cmdDefEmail.Enabled = False
                If sComeFrom = 0 Then cmdConvertToOrder.Enabled = False
            Else
                cmdSendEmail.Enabled = True : cmdPrintAll.Enabled = True : cmdSendApointmentEmail.Enabled = True : cmdDefEmail.Enabled = True
                If sComeFrom = 0 Then cmdConvertToOrder.Enabled = True
            End If
        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub GridView1_CellValueChanging(sender As Object, e As CellValueChangedEventArgs) Handles GridView1.CellValueChanging

        If e.Column.FieldName = "completed" Then
            If e.Value = True Then GridView1.SetRowCellValue(GridView1.FocusedRowHandle, "dtCompleted", Date.Now) Else GridView1.SetRowCellValue(GridView1.FocusedRowHandle, "dtCompleted", Nothing)
        End If
    End Sub

    Private Sub FileSelect(ByVal Mode As Int16)
        'XtraOpenFileDialog1.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*"
        XtraOpenFileDialog1.FilterIndex = 1
        XtraOpenFileDialog1.InitialDirectory = "C:\"
        XtraOpenFileDialog1.Title = "Open File"
        XtraOpenFileDialog1.CheckFileExists = False
        XtraOpenFileDialog1.Multiselect = False
        Dim result As DialogResult = XtraOpenFileDialog1.ShowDialog()
        If result = DialogResult.OK Then
            Try

                Dim sSQL As String

                My.Computer.FileSystem.CopyFile(XtraOpenFileDialog1.FileName, ProgProps.ServerPath & Path.GetFileName(XtraOpenFileDialog1.FileName), True)
                Select Case Mode
                    Case 0
                        txtInstellipseFilename.EditValue = XtraOpenFileDialog1.FileName
                        sSQL = "UPDATE INST_ELLIPSE SET  fInstEllipseName =  " & toSQLValueS(Path.GetFileName(XtraOpenFileDialog1.FileName).ToString) & ", fInstEllipse =  BulkColumn from Openrowset( Bulk " & toSQLValueS(ProgProps.ServerPath & Path.GetFileName(XtraOpenFileDialog1.FileName)) & ", Single_Blob) as InstEllipseF where ID = " & toSQLValueS(sID)
                    Case 1
                        txtInstellipseFilenameD.EditValue = XtraOpenFileDialog1.FileName
                        sSQL = "UPDATE INST_ELLIPSE SET  fInstEllipseNameD =  " & toSQLValueS(Path.GetFileName(XtraOpenFileDialog1.FileName).ToString) & ", fInstEllipseD =  BulkColumn from Openrowset( Bulk " & toSQLValueS(ProgProps.ServerPath & Path.GetFileName(XtraOpenFileDialog1.FileName)) & ", Single_Blob) as InstEllipseF where ID = " & toSQLValueS(sID)
                    Case 2
                        txtInstellipseFilenameC.EditValue = XtraOpenFileDialog1.FileName
                        sSQL = "UPDATE INST_ELLIPSE SET  fInstEllipseNameC =  " & toSQLValueS(Path.GetFileName(XtraOpenFileDialog1.FileName).ToString) & ", fInstEllipseC =  BulkColumn from Openrowset( Bulk " & toSQLValueS(ProgProps.ServerPath & Path.GetFileName(XtraOpenFileDialog1.FileName)) & ", Single_Blob) as InstEllipseF where ID = " & toSQLValueS(sID)
                    Case 3
                        txtInstellipseFilenameSC.EditValue = XtraOpenFileDialog1.FileName
                        sSQL = "UPDATE INST_ELLIPSE SET  fInstEllipseNameSC =  " & toSQLValueS(Path.GetFileName(XtraOpenFileDialog1.FileName).ToString) & ", fInstEllipseSC =  BulkColumn from Openrowset( Bulk " & toSQLValueS(ProgProps.ServerPath & Path.GetFileName(XtraOpenFileDialog1.FileName)) & ", Single_Blob) as InstEllipseF where ID = " & toSQLValueS(sID)
                    Case 4
                        txtInstellipseFilenameComplete.EditValue = XtraOpenFileDialog1.FileName
                        sSQL = "UPDATE INST_ELLIPSE SET completed = 1 ,fInstEllipseNameComplete =  " & toSQLValueS(Path.GetFileName(XtraOpenFileDialog1.FileName).ToString) & ", fInstEllipseComplete =  BulkColumn from Openrowset( Bulk " & toSQLValueS(ProgProps.ServerPath & Path.GetFileName(XtraOpenFileDialog1.FileName)) & ", Single_Blob) as InstEllipseF where ID = " & toSQLValueS(sID)
                End Select

                'Εκτέλεση QUERY
                Using oCmd As New SqlCommand(sSQL, CNDB)
                    oCmd.ExecuteNonQuery()
                End Using
                If Mode = 4 Then
                    chkCompleted.CheckState = CheckState.Checked : GridView1.OptionsBehavior.Editable = False
                    cmdNewInstEllipse.Enabled = False : DisabletxtInstellipseFilename() ' txtInstellipseFilename.Enabled = False
                End If
                XtraMessageBox.Show("Το αρχείο αποθηκεύτηκε με επιτυχία", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub txtInstellipseFilename_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles txtInstellipseFilename.ButtonClick
        Try
            Select Case e.Button.Index
                Case 0 : FileSelect(0)
                Case 1
                    Try
                        Dim Cmd As SqlCommand, sdr As SqlDataReader
                        Dim sSQL As String = "SELECT fInstEllipse,fInstEllipseName  FROM INST_ELLIPSE WHERE comefrom=0 and ID= " & toSQLValueS(sID)
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
                    Catch exfs As Exception
                        XtraMessageBox.Show(String.Format("Error: {0}", exfs.Message), ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Finally

                    End Try
                Case 2
                    If txtInstellipseFilename.EditValue = Nothing Then Exit Sub
                    If XtraMessageBox.Show("Θέλετε να διαγραφεί το αρχείο?", ProgProps.ProgTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                        Dim sSQL As String
                        sSQL = "UPDATE INST_ELLIPSE SET fInstEllipseName =  NULL ,fInstEllipse =  NULL where ID = " & toSQLValueS(sID)
                        'Εκτέλεση QUERY
                        Using oCmd As New SqlCommand(sSQL, CNDB)
                            oCmd.ExecuteNonQuery()
                        End Using
                        txtInstellipseFilename.EditValue = Nothing
                    End If
            End Select
        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try

    End Sub
    Private Sub txtInstellipseFilenameD_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles txtInstellipseFilenameD.ButtonClick
        Try
            Select Case e.Button.Index
                Case 0 : FileSelect(1)
                Case 1
                    Try
                        Dim Cmd As SqlCommand, sdr As SqlDataReader
                        Dim sSQL As String = "SELECT fInstEllipseD,fInstEllipseNameD  FROM INST_ELLIPSE WHERE comefrom=0 and ID= " & toSQLValueS(sID)
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
                    If txtInstellipseFilenameD.EditValue = Nothing Then Exit Sub
                    If XtraMessageBox.Show("Θέλετε να διαγραφεί το αρχείο?", ProgProps.ProgTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                        Dim sSQL As String
                        sSQL = "UPDATE INST_ELLIPSE SET fInstEllipseNameD =  NULL ,fInstEllipseD =  NULL where ID = " & toSQLValueS(sID)
                        'Εκτέλεση QUERY
                        Using oCmd As New SqlCommand(sSQL, CNDB)
                            oCmd.ExecuteNonQuery()
                        End Using
                        txtInstellipseFilenameD.EditValue = Nothing
                    End If
            End Select
        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try

    End Sub
    Private Sub txtInstellipseFilenameC_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles txtInstellipseFilenameC.ButtonClick
        Try
            Select Case e.Button.Index
                Case 0 : FileSelect(2)
                Case 1
                    Try
                        Dim Cmd As SqlCommand, sdr As SqlDataReader
                        Dim sSQL As String = "SELECT fInstEllipseC,fInstEllipseNameC  FROM INST_ELLIPSE WHERE comefrom=0 and ID= " & toSQLValueS(sID)
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
                Case 2
                    If txtInstellipseFilenameC.EditValue = Nothing Then Exit Sub
                    If XtraMessageBox.Show("Θέλετε να διαγραφεί το αρχείο?", ProgProps.ProgTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                        Dim sSQL As String
                        sSQL = "UPDATE INST_ELLIPSE SET fInstEllipseNameC =  NULL ,fInstEllipseC =  NULL where ID = " & toSQLValueS(sID)
                        'Εκτέλεση QUERY
                        Using oCmd As New SqlCommand(sSQL, CNDB)
                            oCmd.ExecuteNonQuery()
                        End Using
                        txtInstellipseFilenameC.EditValue = Nothing
                    End If
            End Select
        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try

    End Sub
    Private Sub txtInstellipseFilenameSC_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles txtInstellipseFilenameSC.ButtonClick
        Try
            Select Case e.Button.Index
                Case 0 : FileSelect(3)
                Case 1
                    Try
                        Dim Cmd As SqlCommand, sdr As SqlDataReader
                        Dim sSQL As String = "SELECT fInstEllipseSC,fInstEllipseNameSC  FROM INST_ELLIPSE WHERE comefrom=0 and ID= " & toSQLValueS(sID)
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
                Case 2
                    If txtInstellipseFilenameSC.EditValue = Nothing Then Exit Sub
                    If XtraMessageBox.Show("Θέλετε να διαγραφεί το αρχείο?", ProgProps.ProgTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                        Dim sSQL As String
                        sSQL = "UPDATE INST_ELLIPSE SET fInstEllipseNameSC =  NULL ,fInstEllipseSC =  NULL where ID = " & toSQLValueS(sID)
                        'Εκτέλεση QUERY
                        Using oCmd As New SqlCommand(sSQL, CNDB)
                            oCmd.ExecuteNonQuery()
                        End Using
                        txtInstellipseFilenameSC.EditValue = Nothing
                    End If
            End Select
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

    Private Sub cmdPrintAll_Click(sender As Object, e As EventArgs) Handles cmdPrintAll.Click

        If sComeFrom = 0 Then
            Dim report As New RepCUSEllipse
            report.Parameters.Item(0).Value = sID
            report.CreateDocument()
            Dim printTool As New ReportPrintTool(report)
            printTool.ShowRibbonPreview()
        Else
            Dim report As New RepCUSEllipseForSUP
            report.Parameters.Item(0).Value = sID
            report.CreateDocument()
            Dim printTool As New ReportPrintTool(report)
            printTool.ShowRibbonPreview()
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
                Dim report As New RepCUSEllipseForSUP()
                report.Parameters.Item(0).Value = sID
                sEmailTo = txtTo.EditValue
                sBody = txtBody.EditValue
                sSubject = txtSubject.EditValue
                sBody = sBody.Replace("{INST_ELLIPSE_DATE_DELIVERED}", Date.Now.Date)
                sBody = sBody.Replace("{CUS}", cboCUS.Text)
                sFile = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) & "\Downloads\Ενημερώτικό έντυπο εκκρεμοτήτων προμηθευτή.pdf"
                report.CreateDocument()
                report.ExportToPdf(sFile)
                report.Dispose()
                report = Nothing
                My.Computer.FileSystem.CopyFile(sFile, ProgProps.ServerPath & Path.GetFileName(sFile), True)
            Else
                Dim report As New RepCUSEllipse()
                report.Parameters.Item(0).Value = sID
                sEmailTo = txtTo.EditValue
                sBody = txtBody.EditValue
                sBody = sBody.Replace("{INST_ELLIPSE_DATE_DELIVERED}", dtDateDelivered.Text)
                sBody = sBody.Replace("{INST_DATE_DELIVERED}", cboINST.GetColumnValue("dtDeliverDate").ToString())
                sBody = sBody.Replace("{INST_ELLIPSE_TIME_FROM}", txtTmINFrom.Text)
                sBody = sBody.Replace("{INST_ELLIPSE_TIME_TO}", txtTmINTo.Text)
                sSubject = txtSubject.EditValue
                sFile = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) & "\Downloads\Ενημερώτικό έντυπο εκκρεμοτήτων.pdf"
                report.CreateDocument()
                report.ExportToPdf(sFile)
                report.Dispose()
                report = Nothing
                My.Computer.FileSystem.CopyFile(sFile, ProgProps.ServerPath & Path.GetFileName(sFile), True)
            End If

            'sEmailTo = "dreamykitchen@gmail.com"
            'sEmailTo = "johnmavroselinos@gmail.com"
            If CNDB.Database <> "DreamyKitchen" Or Debugger.IsAttached = True Then sEmailTo = "johnmavroselinos@gmail.com;dreamykitchen@gmail.com"


            If Emails.SendEmail(IIf(sComeFrom = 1, ProgProps.InstEllipseEmailAccountSupFrom, ProgProps.InstEmailAccountFrom), sSubject, sBody, sEmailTo, sFile, statusMsg) = True Then
                Select Case emailMode
                    Case 1 : sSQL = "Update INST_ELLIPSE SET emailApp = 1,DateOfEmailApp=getdate() WHERE ID = " & toSQLValueS(sID)
                    Case 2 : sSQL = "Update INST_ELLIPSE SET emailInf = 1,DateOfEmailInf=getdate() WHERE ID = " & toSQLValueS(sID)
                    Case 3 : sSQL = "Update INST_ELLIPSE SET emailInfComplete = 1,DateOfEmailInfComplete=getdate() WHERE ID = " & toSQLValueS(sID)
                End Select

                Cmd = New SqlCommand(sSQL, CNDB) : Cmd.ExecuteNonQuery()

                ' Εισαγωγή ιστορικού email
                sSQL = "INSERT INTO INST_MAIL (instID,instEllipseID,emailFrom,emailTo,emailSubject,emailBody,DateofEmail,[createdBy],[createdOn],ComeFrom,emailMode,Attachment)  
                        Select " & toSQLValueS(sINST_ID) & "," & toSQLValueS(sID) & "," & toSQLValueS(ProgProps.InstEmailAccountFrom) & "," &
                                    toSQLValue(txtTo) & "," & toSQLValue(txtSubject) & "," &
                                    toSQLValue(txtBody) & ",getdate(), " &
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


    Private Sub cboCUS_EditValueChanged(sender As Object, e As EventArgs) Handles cboCUS.EditValueChanged
        Dim sCusID As String
        If cboCUS.EditValue Is Nothing Then sCusID = toSQLValueS("00000000-0000-0000-0000-000000000000") Else sCusID = toSQLValueS(cboCUS.EditValue.ToString)
        Dim sSQL As New System.Text.StringBuilder
        sSQL.AppendLine("Select T.id,FullTranshDescription,Description,Iskitchen,Iscloset,Isdoor,Issc,offerCusAcceptance
                        from vw_TRANSH t
                        where   T.cusid = " & sCusID & "order by description")
        FillCbo.TRANSH(cboTRANSH, sSQL)
    End Sub

    Private Sub cboINST_EditValueChanged(sender As Object, e As EventArgs) Handles cboINST.EditValueChanged
        If Me.IsActive = False Then Exit Sub
        Try
            If cboINST.GetColumnValue("cusID").ToString <> "" Then cboCUS.EditValue = System.Guid.Parse(cboINST.GetColumnValue("cusID").ToString)
            If cboINST.GetColumnValue("transhID").ToString <> "" Then cboTRANSH.EditValue = System.Guid.Parse(cboINST.GetColumnValue("transhID").ToString)
        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub frmInstEllipse_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        If ValidationsExit() = False Then e.Cancel = True : Exit Sub
    End Sub
    Private Function CheckForInstName() As Boolean
        If GridView1.DataRowCount > 0 And
            txtInstellipseFilename.EditValue Is Nothing And txtInstellipseFilenameD.EditValue Is Nothing And
            txtInstellipseFilenameC.EditValue Is Nothing And txtInstellipseFilenameSC.EditValue Is Nothing Then
            XtraMessageBox.Show("Έχετε καταχωρήσει εκκρεμότητες χωρίς να έχετε επισυνάψει έντυπο ολοκλήρωσης. ", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        Else
            Return True
        End If
    End Function
    Private Sub TabPane1_SelectedPageChanged(sender As Object, e As SelectedPageChangedEventArgs) Handles TabPane1.SelectedPageChanged
        Select Case TabPane1.SelectedPageIndex
            Case 1
                Prog_Prop.GetProgEmailInstAndEllipse()

                If sComeFrom = 0 Then
                    txtSubject.EditValue = ProgProps.InstEllipseInfSubject
                    txtTo.EditValue = cboINST.GetColumnValue("email") ' Email Πελάτη
                    If txtInstellipseFilenameComplete.EditValue IsNot Nothing Then
                        cmdSendEmailComplete.Enabled = True : DefInstComplete.Enabled = True
                    Else
                        cmdSendEmailComplete.Enabled = False : DefInstComplete.Enabled = False
                    End If
                    If txtInstellipseFilename.EditValue IsNot Nothing Or txtInstellipseFilenameD.EditValue IsNot Nothing Or
                       txtInstellipseFilenameC.EditValue IsNot Nothing Or txtInstellipseFilenameSC.EditValue IsNot Nothing Then
                        cmdSendEmail.Enabled = True : DefInst.Enabled = True
                    End If
                Else
                    txtSubject.EditValue = ProgProps.InstEllipseInfSubjectSup
                    txtTo.EditValue = ProgProps.InstEllipseEmailAccountSupTo
                    txtBody.EditValue = ProgProps.InstEllipseInfBodySup.Replace("{CUS}", cboCUS.Text)
                    txtSubject.EditValue = ProgProps.PJInfSubjectSup
                    DefInstAppointment.Enabled = False : DefInstAppointment.Enabled = False : DefInstComplete.Enabled = False
                    cmdSendEmailComplete.Enabled = False
                End If
                cmdDefEmail.Enabled = True
                If dtDateDelivered.EditValue = Nothing Or txtTmINFrom.EditValue = "00:00" Or txtTmINTo.EditValue = "00:00" Then cmdSendApointmentEmail.Enabled = False : DefInstAppointment.Enabled = False Else cmdSendApointmentEmail.Enabled = True : DefInstAppointment.Enabled = True
                Me.INST_MAILTableAdapter.FillByinstEllipseID(Me.DmDataSet.INST_MAIL, System.Guid.Parse(sID))
                LoadForms.RestoreLayoutFromXml(GridView3, "INST_MAIL_ELLIPSE.xml")
            Case 2
                LoadForms.RestoreLayoutFromXml(GridView5, "vw_TRANSH_F_INST_ELLIPSE_def.xml")
                GridView5.Columns.Item("belongsTo").OptionsColumn.AllowEdit = False
                If cboTRANSH.EditValue IsNot Nothing Then TRANSH_FTableAdapter.FillByTranshID(DM_TRANS.TRANSH_F, System.Guid.Parse(cboTRANSH.EditValue.ToString))
        End Select
    End Sub

    Private Sub DefInst_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles DefInst.ItemClick
        If sComeFrom = 0 Then
            txtBody.EditValue = ProgProps.InstEllipseInfBody.Replace("{INST_ELLIPSE_DATE_DELIVERED}", dtDateDelivered.Text)
            txtBody.EditValue = ProgProps.InstEllipseInfBody.Replace("{INST_DATE_DELIVERED}", cboINST.GetColumnValue("dtDeliverDate").ToString)
            txtSubject.EditValue = ProgProps.InstEllipseInfSubject
        Else
            txtBody.EditValue = ProgProps.InstEllipseInfBodySup.Replace("{CUS}", cboCUS.Text)
            txtSubject.EditValue = ProgProps.InstEllipseInfSubjectSup
        End If
    End Sub
    Private Sub DefInstComplete_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles DefInstComplete.ItemClick
        If sComeFrom = 0 Then
            If dtDateDelivered.EditValue IsNot Nothing Then txtBody.EditValue = ProgProps.InstEllipseInfBodyComplete.Replace("{INST_ELLIPSE_DATE_DELIVERED}", dtDateDelivered.Text)
            txtSubject.EditValue = ProgProps.InstEllipseInfSubjectComplete
        End If

    End Sub
    Private Sub DefInstAppointment_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles DefInstAppointment.ItemClick
        txtBody.EditValue = ProgProps.InstEllipseInfAppointmentBody
        txtBody.EditValue = txtBody.EditValue.Replace("{INST_ELLIPSE_DATE_DELIVERED}", dtDateDelivered.Text)
        txtBody.EditValue = txtBody.EditValue.Replace("{INST_DATE_DELIVERED}", cboINST.GetColumnValue("dtDeliverDate").ToString)
        txtBody.EditValue = txtBody.EditValue.Replace("{INST_ELLIPSE_TIME_FROM}", txtTmINFrom.Text)
        txtBody.EditValue = txtBody.EditValue.Replace("{INST_ELLIPSE_TIME_TO}", txtTmINTo.Text)
        txtSubject.EditValue = ProgProps.InstEllipseInfAppointmentSubject
    End Sub
    Private Sub cmdSendApointmentEmail_Click(sender As Object, e As EventArgs) Handles cmdSendApointmentEmail.Click
        emailMode = 1 : ValidateEmail()
    End Sub

    Private Sub cmdSendEmail_Click(sender As Object, e As EventArgs) Handles cmdSendEmail.Click
        emailMode = 2 : ValidateEmail()
    End Sub
    Private Sub cmdSendEmailComplete_Click(sender As Object, e As EventArgs) Handles cmdSendEmailComplete.Click
        emailMode = 3 : ValidateEmail()
    End Sub

    Private Sub cmdNewInstEllipse_Click(sender As Object, e As EventArgs) Handles cmdNewInstEllipse.Click
        If GridView1.DataRowCount = 0 Then
            XtraMessageBox.Show("Δεν έχετε καταχωρήσει εκκρεμότητες. Δεν μπορεί να δημιουργηθεί νέα εγγραφή.", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If CheckIfInstJobsAreCompleted() Then
            XtraMessageBox.Show("Όλες οι εκρεμμότητες είναι ολοκληρωμένες. Δεν μπορεί να δημιουργηθεί νέα εγγραφή.", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        NewRecord()
    End Sub
    Private Sub ValidateEmail()
        If GridView1.RowCount = 0 Then XtraMessageBox.Show("Δεν υπάρχουν εκκρεμότητες προς αποστολή", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error) : Exit Sub
        If txtBody.Text = "" Then XtraMessageBox.Show("Παρακαλώ συμπληρώστε κείμενο", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error) : Exit Sub
        If txtSubject.Text = "" Then XtraMessageBox.Show("Παρακαλώ συμπληρώστε το θέμα", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error) : Exit Sub
        If txtTo.Text = "" Then XtraMessageBox.Show("Δεν υπάρχει καταχωρήμενο email στον πελάτη.", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error) : Exit Sub
        If XtraMessageBox.Show("Θέλετε να αποσταλεί το Email?", ProgProps.ProgTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            SendEmailExportReport()
            Me.INST_MAILTableAdapter.FillByinstEllipseID(Me.DmDataSet.INST_MAIL, System.Guid.Parse(sID))
        End If
    End Sub
    Private Function SetInstEllipseCompleted() As Boolean
        Dim sSQL As String
        Try
            sSQL = "UPDATE INST_ELLIPSE SET COMPLETED = 1 WHERE ID = " & toSQLValueS(sID)
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
        sSQL = "SELECT top 1 id as JobEllipseid FROM INST_ELLIPSE_JOBS WHERE completed = 1 and instEllipseID= " & toSQLValueS(sID)
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
    Private Function CheckIfEllipseHasDateDelivered() As Boolean
        Dim Cmd As SqlCommand, sdr As SqlDataReader
        Dim sSQL As String
        sSQL = "SELECT count (id) as CountEllipse  FROM INST_ELLIPSE WHERE DateDelivered is not null and ID= " & toSQLValueS(sID)
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
        sSQL = "SELECT fInstEllipseNameComplete FROM INST_ELLIPSE WHERE ID= " & toSQLValueS(sID)
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
        sSQL = "SELECT id FROM INST_ELLIPSE WHERE completed = 0  and instID= " & toSQLValueS(sID)
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
    Private Function CheckIfInstJobsAreCompleted() As Boolean
        Dim Cmd As SqlCommand, sdr As SqlDataReader
        Dim sSQL As String
        sSQL = "SELECT id as CountJobEllipse  FROM INST_ELLIPSE_JOBS WHERE completed = 0 and instEllipseID= " & toSQLValueS(sID)
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
        sSQL = "SELECT top 1 id as toOrderID FROM INST_ELLIPSE_JOBS WHERE toOrder = 1 and instEllipseID= " & toSQLValueS(sID)
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
                    "SELECT NEWID()," & toSQLValueS(sID) & " ,  " & toSQLValueS(sINST_ID) & ", [name], IEJ.[cmt], IEJ.[completed], [dtCompleted],  IEJ.[createdOn], IEJ.[createdBy] " &
                    "from INST I " &
                    "inner join INST_ELLIPSE IE on IE.id= " & toSQLValueS(LastEllipseID) &
                    " INNER  join INST_ELLIPSE_JOBS  IEJ ON IEJ.instEllipseID =IE.ID " &
                    "WHERE IE.comefrom = 0 and  IEJ.completed=0 And I.[ID]= " & toSQLValueS(sINST_ID)
            Using oCmd As New SqlCommand(sSQL, CNDB)
                oCmd.ExecuteNonQuery()
            End Using
            Me.INST_ELLIPSE_JOBSTableAdapter.FillBYinstEllipseID(Me.DmDataSet.INST_ELLIPSE_JOBS, System.Guid.Parse(sID))
            txtInstellipseFilename.ReadOnly = False : txtInstellipseFilenameD.ReadOnly = False
            txtInstellipseFilenameC.ReadOnly = False : txtInstellipseFilenameSC.ReadOnly = False
            GridView1.OptionsBehavior.Editable = True
            Mode = FormMode.EditRecord
        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub NewRecord()
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
        sID = System.Guid.NewGuid.ToString
        'Καταχώρηση συνεργείων και εκκρεμοτήτων που έμειναν ανολοκλήρωτες στην νέα έλλειψη
        Insert_EllipseSer_EllipseJobs_InstEllipse()
        dtDateDelivered.EditValue = Nothing : txtTmINFrom.EditValue = "00:00" : txtTmINTo.EditValue = "00:00" : dtReceipt.EditValue = Nothing : chkCompleted.CheckState = CheckState.Unchecked
        txtComments.EditValue = Nothing : cmdConvertToOrder.Enabled = False : cmdViewOrder.Enabled = False
        txtInstellipseFilename.EditValue = Nothing : txtInstellipseFilenameD.EditValue = Nothing
        txtInstellipseFilenameC.EditValue = Nothing : txtInstellipseFilenameSC.EditValue = Nothing
        AddRecord()
    End Sub

    Private Sub txtInstellipseFilenameComplete_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles txtInstellipseFilenameComplete.ButtonClick
        Try
            Select Case e.Button.Index
                Case 0
                    'Έλεγχος για να δεί αν υπάρχει μη ολοκληρωμένη έλλειψη.Αν υπάρχει δεν μπορεί να επισυνάψει έντυπο ολοκλήρωσης
                    'If CheckIfInstJobsAreCompleted() = False Then XtraMessageBox.Show("Δεν μπορείτε επισυνάψετε έντυπο ολοκλήρωσης όταν υπάρχει έστω και μια μη ολοκληρωμένη εκκρεμότητα.", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error) : Exit Sub
                    If CheckIfInstJobsAreCompleted() = False Then
                        XtraMessageBox.Show("Δεν μπορείτε επισυνάψετε έντυπο ολοκλήρωσης όταν υπάρχει έστω και μια μη ολοκληρωμένη εκκρεμότητα.", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    Else
                        FileSelect(4)
                    End If
                Case 1
                    Try
                        Dim Cmd As SqlCommand, sdr As SqlDataReader
                        Dim sSQL As String = "SELECT fInstEllipseComplete,fInstEllipseNameComplete  FROM INST_ELLIPSE WHERE comefrom=0 and ID= " & toSQLValueS(sID)
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
                Case 2
                    If txtInstellipseFilenameComplete.EditValue = Nothing Then Exit Sub
                    If XtraMessageBox.Show("Θέλετε να διαγραφεί το αρχείο?", ProgProps.ProgTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                        Dim sSQL As String
                        sSQL = "UPDATE INST_ELLIPSE SET fInstEllipseNameComplete =  NULL ,fInstEllipseComplete =  NULL where ID = " & toSQLValueS(sID)
                        'Εκτέλεση QUERY
                        Using oCmd As New SqlCommand(sSQL, CNDB)
                            oCmd.ExecuteNonQuery()
                        End Using
                        sSQL = "UPDATE INST_ELLIPSE SET completed = 0 where ID = " & toSQLValueS(sID)
                        'Εκτέλεση QUERY
                        Using oCmd As New SqlCommand(sSQL, CNDB)
                            oCmd.ExecuteNonQuery()
                        End Using
                        chkCompleted.CheckState = CheckState.Unchecked
                        GridView1.OptionsBehavior.Editable = True
                        txtInstellipseFilenameComplete.EditValue = Nothing
                        cmdNewInstEllipse.Enabled = True : txtInstellipseFilename.ReadOnly = False
                        txtInstellipseFilenameD.ReadOnly = False : txtInstellipseFilenameC.ReadOnly = False
                        txtInstellipseFilenameSC.ReadOnly = False
                    End If
            End Select
        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try


    End Sub
    Private Sub GridView1_PopupMenuShowing(sender As Object, e As PopupMenuShowingEventArgs) Handles GridView1.PopupMenuShowing
        If e.MenuType = GridMenuType.Column Then
            If sComeFrom = 1 Then
                LoadForms.PopupMenuShow(e, GridView1, "INST_ELLIPSE_JOBS_def_SUP.xml", "INST_ELLIPSE_JOBS")
            Else
                LoadForms.PopupMenuShow(e, GridView1, "INST_ELLIPSE_JOBS_def.xml", "INST_ELLIPSE_JOBS")
            End If
        End If
    End Sub

    Private Sub GridView3_PopupMenuShowing(sender As Object, e As PopupMenuShowingEventArgs) Handles GridView3.PopupMenuShowing
        If e.MenuType = GridMenuType.Column Then LoadForms.PopupMenuShow(e, GridView3, "INST_MAIL_ELLIPSE.xml", "vw_INST_MAIL")
    End Sub

    Private Sub cmdConvertToOrder_Click(sender As Object, e As EventArgs) Handles cmdConvertToOrder.Click
        Try
            If SaveButtonPressed = False Then
                XtraMessageBox.Show("Δεν έχετε αποθηκέυση την εκκρεμότητα. Παρακαλώ κάντε κλίκ στο  ""Αποθήκευση"".", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            If CheckIfInstJobsAreCompleted() Then
                XtraMessageBox.Show("Όλες οι εκρεμμότητες είναι ολοκληρωμένες. Δεν μπορεί να αποθηκευθεί η εγγραφή.", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            If cboSUP.EditValue = Nothing Then
                XtraMessageBox.Show("Δεν έχετε επιλέξει Προμηθευτή.", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            If HasConnectedOrder Then
                Using oCmd As New SqlCommand("CloneINSTELLIPSEJOBS", CNDB)
                    oCmd.CommandType = CommandType.StoredProcedure
                    oCmd.Parameters.AddWithValue("@InstEllipseID", sID)
                    oCmd.ExecuteNonQuery()
                End Using
                XtraMessageBox.Show("Η παραγγελία επαναδημιουργήθηκε με επιτυχία.", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Information)
                If CheckIfHasConnectedOrder() = True Then cmdConvertToOrder.Text = "Ενημέρωση Παραγγελίας" : HasConnectedOrder = True : 
            Else

                If GridView1.DataRowCount = 0 Then
                    XtraMessageBox.Show("Δεν έχετε καταχωρήσει εκκρεμότητες. Δεν μπορεί να αποθηκευθεί η εγγραφή.", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
                If CheckIfHasInstJobsForOrder() = False Then
                    XtraMessageBox.Show("Δεν έχετε επιλέξει εκκρεμότητες προς Παραγγελία. Δεν μπορεί να γίνει η μετατροπή.", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
                If XtraMessageBox.Show("Θέλετε να μετατραπούν οι εκκρεμότητες σε παραγγελία?", ProgProps.ProgTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                    Using oCmd As New SqlCommand("cloneINSTELLIPSE", CNDB)
                        oCmd.CommandType = CommandType.StoredProcedure
                        oCmd.Parameters.AddWithValue("@InstEllipseID", sID)
                        oCmd.Parameters.AddWithValue("@supID", cboSUP.EditValue.ToString)
                        oCmd.Parameters.AddWithValue("@empID", cboEMP.EditValue.ToString)
                        oCmd.ExecuteNonQuery()
                    End Using
                    XtraMessageBox.Show("Η παραγγελία δημιουργήθηκε με επιτυχία.", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    If CheckIfHasConnectedOrder() = True Then cmdConvertToOrder.Text = "Ενημέρωση Παραγγελίας" : HasConnectedOrder = True : 
                End If
            End If
        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub cmdViewOrder_Click(sender As Object, e As EventArgs) Handles cmdViewOrder.Click
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

    Private Sub GridView3_CustomRowCellEdit(sender As Object, e As CustomRowCellEditEventArgs) Handles GridView3.CustomRowCellEdit
        If e.Column.FieldName = "imageCell" Then
            e.RepositoryItem = txtImageAttachment
            GridView3.SetRowCellValue(GridView3.FocusedRowHandle, "imageCell", "Επισυναπτόμενο")
        End If
    End Sub

    Private Sub GridView3_DoubleClick(sender As Object, e As EventArgs) Handles GridView3.DoubleClick
        Dim Cmd As SqlCommand, sdr As SqlDataReader
        Dim sSQL As String = "SELECT Attachment  FROM INST_MAIL WHERE ID= " & toSQLValueS(GridView3.GetRowCellValue(GridView3.FocusedRowHandle, "ID").ToString)
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

    Private Sub cboCUS_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboCUS.ButtonClick
        Select Case e.Button.Index
            Case 1 : ManageCbo.ManageCCT(FormMode.NewRecord, False,, cboCUS)
            Case 2 : ManageCbo.ManageCCT(FormMode.EditRecord, False,, cboCUS)
            Case 3 : cboCUS.EditValue = Nothing
        End Select
    End Sub

    Private Sub cboSUP_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboSUP.ButtonClick
        Select Case e.Button.Index
            Case 1 : ManageCbo.ManageSup(cboSUP, FormMode.NewRecord)
            Case 2 : ManageCbo.ManageSup(cboSUP, FormMode.EditRecord)
            Case 3 : cboSUP.EditValue = Nothing
        End Select
    End Sub

    Private Sub cboTRANSH_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboTRANSH.ButtonClick
        Select Case e.Button.Index
            Case 1 : ManageCbo.ManageTRANSH(cboTRANSH, FormMode.NewRecord, cboCUS.EditValue)
            Case 2 : ManageCbo.ManageTRANSH(cboTRANSH, FormMode.EditRecord, cboCUS.EditValue)
            Case 3 : cboTRANSH.EditValue = Nothing
        End Select
    End Sub
    Private Sub cboINST_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboINST.ButtonClick
        Select Case e.Button.Index
            Case 1 : ManageCbo.ManageINST(cboINST, FormMode.NewRecord)
            Case 2 : ManageCbo.ManageINST(cboINST, FormMode.EditRecord)
            Case 3 : cboINST.EditValue = Nothing
        End Select

    End Sub
    Private Sub txtFiles_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles txtFiles.ButtonClick
        Dim sFilename As String
        Select Case e.Button.Index
            Case 0
                Dim result = XtraInputBox.Show("Πληκτρολογήστε το πλήθος σελίδων που θα σκανάρετε", "Όνομα Αρχείου", "1")
                ScanFile = New ScanToPDF
                If ScanFile.Scan(sFilename, Me.VwSCANFILENAMESBindingSource, result) = False Then Exit Sub
                txtFiles.EditValue = sFilename
                If txtFiles.Text <> "" Then SaveRecordF(1, sFilename)
                ScanFile = Nothing
            Case 1 : FilesSelection(XtraOpenFileDialog1, txtFiles)
            Case 2 : txtFiles.EditValue = Nothing
        End Select
    End Sub
    Public Sub SaveRecordF(ByVal sMode As Integer, Optional ByVal sFilename As String = "")
        Dim sResultF As Boolean
        If cboTanshFCategory.EditValue = Nothing Then XtraMessageBox.Show("Δεν έχετε επιλέξει Κατηγορία.", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error) : Exit Sub
        If txtFiles.Text = "" Then XtraMessageBox.Show("Δεν έχετε επιλέξει Αρχείο.", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error) : Exit Sub
        Select Case sMode
            Case 0 : sResultF = DBQ.InsertDataFiles(XtraOpenFileDialog1, cboTRANSH.EditValue.ToString, "TRANSH_F", sID, "Αρχεία Εκκρεμοτήτων")
            Case 1 : sResultF = DBQ.InsertDataFilesFromScanner(sFilename, cboTRANSH.EditValue.ToString, "TRANSH_F", cboTanshFCategory.EditValue.ToString, sID, "Αρχεία Εκκρεμοτήτων")
        End Select
        txtFiles.EditValue = Nothing
        TRANSH_FTableAdapter.FillByTranshID(DM_TRANS.TRANSH_F, System.Guid.Parse(cboTRANSH.EditValue.ToString))
    End Sub
    Private Sub cmdSaveTransF_Click(sender As Object, e As EventArgs) Handles cmdSaveTransF.Click
        XtraOpenFileDialog1.Tag = cboTanshFCategory.EditValue.ToString
        SaveRecordF(0)
    End Sub
    Private Sub cboTanshFCategory_ButtonPressed(sender As Object, e As ButtonPressedEventArgs) Handles cboTanshFCategory.ButtonPressed
        Select Case e.Button.Index
            Case 1 : cboTanshFCategory.EditValue = Nothing : ManageCbo.ManageFCategory(cboTanshFCategory, FormMode.NewRecord)
            Case 2 : If cboTanshFCategory.EditValue IsNot Nothing Then ManageCbo.ManageFCategory(cboTanshFCategory, FormMode.EditRecord)
            Case 3 : cboTanshFCategory.EditValue = Nothing
        End Select
    End Sub
    Private Sub GridControl2_DoubleClick(sender As Object, e As EventArgs) Handles GridControl2.DoubleClick
        OpenFileFromGrid(GridView5, "TRANSH_F")
    End Sub
    Private Sub GridView5_ValidateRow(sender As Object, e As ValidateRowEventArgs) Handles GridView5.ValidateRow
        Dim sSQL As New System.Text.StringBuilder
        Try
            sSQL.Clear()
            sSQL.AppendLine("UPDATE TRANSH_F	SET FileCatID= " & toSQLValueS(GridView5.GetRowCellValue(GridView5.FocusedRowHandle, "fileCatID").ToString) & ",")
            sSQL.AppendLine("modifiedBY = " & toSQLValueS(UserProps.ID.ToString) & ",")
            sSQL.AppendLine("modifiedON = getdate() ")
            sSQL.AppendLine("WHERE ID = " & toSQLValueS(GridView5.GetRowCellValue(GridView5.FocusedRowHandle, "ID").ToString))
            'Εκτέλεση QUERY
            Using oCmd As New SqlCommand(sSQL.ToString, CNDB)
                oCmd.ExecuteNonQuery()
            End Using
        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub GridView5_PopupMenuShowing(sender As Object, e As PopupMenuShowingEventArgs) Handles GridView5.PopupMenuShowing
        If e.MenuType = GridMenuType.Column Then LoadForms.PopupMenuShow(e, GridView5, "vw_TRANSH_F_INST_ELLIPSE_def.xml", "vw_TRANSH_F")
    End Sub

End Class
'Private Sub ShowQuestionForm()
'    Dim args As New XtraInputBoxArgs()
'    Dim Item1 As New RadioGroupItem
'    Item1.Description = "Αφορά Πελάτη"
'    Dim item2 As New RadioGroupItem
'    item2.Description = "Αφορά Προμηθευτή"
'    Dim RadioEdit1 As New RadioGroup
'    RadioEdit1.Properties.Items.Add(Item1)
'    RadioEdit1.Properties.Items.Add(item2)
'    RadioEdit1.Name = "radioEditComeFrom"
'    RadioEdit1.Location = New System.Drawing.Point(30, 35)
'    RadioEdit1.Width = 50
'    RadioEdit1.Height = 100
'    ' set required Input Box options
'    args.Caption = "Επιλογή Εκκρεμότητας"
'    args.Prompt = "Επιλέξτε ποιον αφορά η εκκρεμότητα"
'    args.DefaultButtonIndex = 0
'    AddHandler args.Showing, AddressOf Args_Showing
'    ' initialize a DateEdit editor with custom settings

'    args.Editor = RadioEdit1
'    AddHandler RadioEdit1.SelectedIndexChanged, AddressOf SelectedIndexChanged

'    Dim result = XtraInputBox.Show(args)
'    'If result = Nothing Then ComeFrom = 0

'End Sub
'Private Sub SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs)
'    Dim Edit As RadioGroup = CType(sender, RadioGroup)
'    If (Edit.SelectedIndex = 0) Then sComeFrom = 0 Else sComeFrom = 1
'End Sub
'Private Sub Args_Showing(ByVal sender As Object, ByVal e As XtraMessageShowingArgs)
'    e.Form.Icon = Me.Icon
'End Sub