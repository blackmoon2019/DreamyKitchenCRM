Imports DevExpress.Data.PivotGrid
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraRichEdit.UI
Imports System.Data.SqlClient

Public Class Projects
    Private Valid As New ValidateControls
    Private DBQ As New DBQueries
    Private Frm As frmTransactions
    Private Frm2 As frmProject
    Private LoadForms As New FormLoader
    Private ID As String
    Private Mode As Byte
    Private CalledFromCtrl As Boolean
    Private CtrlCombo As DevExpress.XtraEditors.LookUpEdit
    Private FillCbo As New FillCombos
    Private Cls As New ClearControls
    Private TranshFieldAndValues As Dictionary(Of String, String)
    Private sEMP_T_ID As String = ""
    Private sProjectCostID As String



    Public Sub Initialize(ByVal sFrm As frmTransactions, ByVal sID As String, ByVal sMode As Byte, ByVal sCalledFromCtrl As Boolean, ByVal sCtrlCombo As DevExpress.XtraEditors.LookUpEdit)
        Frm = sFrm
        ID = sID
        Mode = sMode
        CalledFromCtrl = sCalledFromCtrl
        CtrlCombo = sCtrlCombo
        Frm.Vw_PAYTYPESTableAdapter.Fill(Frm.DM_TRANS.vw_PAYTYPES)
        Frm.Vw_TRANSH_CTableAdapter.Fill(Frm.DM_TRANS.vw_TRANSH_C)
        Frm.Vw_SCAN_FILE_NAMESTableAdapter.Fill(Frm.DreamyKitchenDataSet.vw_SCAN_FILE_NAMES)
        Frm.Vw_INVTYPESTableAdapter.Fill(Frm.DreamyKitchenDataSet.vw_INVTYPES)
        Frm.Vw_BANKSTableAdapter.Fill(Frm.DreamyKitchenDataSet.vw_BANKS)
        'Τράπεζες
        FillCbo.BANKS(Frm.cboBANK)
        'Πελάτες
        FillCbo.CUS(Frm.cboCUS)
        'Πωλητές
        FillCbo.SALERS(Frm.cboSaler)
        'Νομοί
        FillCbo.COU(Frm.cboCOU)
    End Sub
    Public Sub InitializeSmall(ByVal sFrm As frmProject, ByVal sID As String, ByVal sMode As Byte, ByVal sCalledFromCtrl As Boolean, ByVal sCtrlCombo As DevExpress.XtraEditors.LookUpEdit)
        Frm2 = sFrm : ID = sID : Mode = sMode
        Frm2.Vw_TRANSH_CTableAdapter.Fill(Frm2.DM_TRANS.vw_TRANSH_C)

        CalledFromCtrl = sCalledFromCtrl
        CtrlCombo = sCtrlCombo
        'Πελάτες
        FillCbo.CUS(Frm2.cboCUS)
        'Πωλητές
        FillCbo.SALERS(Frm2.cboSaler)
        'Νομοί
        FillCbo.COU(Frm2.cboCOU)
    End Sub
    Public Sub LoadForm()
        Select Case Mode
            Case FormMode.NewRecord
                Frm.dtCharge.EditValue = DateTime.Now : Frm.dtPay.EditValue = DateTime.Now : Frm.LayoutControlGroup2.Enabled = False : Frm.txtCodeH.Text = GetNextID()
            Case FormMode.EditRecord
                Dim sSQL As New System.Text.StringBuilder
                If Frm.cboCOU.EditValue <> Nothing Then sSQL.AppendLine(" where couid = " & toSQLValueS(Frm.cboCOU.EditValue.ToString))
                FillCbo.AREAS(Frm.cboAREAS, sSQL)

                TranshFieldAndValues = New Dictionary(Of String, String)
                LoadForms.LoadFormGRP(Frm.LayoutControlGroup3, "Select * from vw_TRANSH with(nolock) where id ='" + ID + "'",, TranshFieldAndValues)
                LoadForms.LoadFormGRP(Frm.LayoutControlGroup4, "Select * from vw_TRANSH with(nolock) where id ='" + ID + "'")
                Frm.txtBal.EditValue = TranshFieldAndValues.Item("bal")
                sEMP_T_ID = TranshFieldAndValues.Item("EmpTID").ToString
                sProjectCostID = TranshFieldAndValues.Item("ProjectCostID").ToString
                Frm.TRANSH_FTableAdapter.FillByTanshID(Frm.DM_TRANS.TRANSH_F, System.Guid.Parse(ID))
                Frm.Vw_TRANSDTableAdapter.Fill(Frm.DM_TRANS.vw_TRANSD, System.Guid.Parse(ID))
                Dim cmd As SqlCommand = New SqlCommand("Select transhCID from TRANSC WHERE transhID = " & toSQLValueS(ID), CNDB)
                Dim sdr As SqlDataReader = cmd.ExecuteReader()
                If sdr.HasRows Then
                    While sdr.Read()
                        Frm.cboTransC.Properties.GetItems.Item(System.Guid.Parse(sdr("transhCID").ToString)).CheckState = CheckState.Checked
                    End While
                End If
                sdr.Close()
                Frm.txtCodeD.Text = DBQ.GetNextId("TRANSD")
                Frm.dtPay.EditValue = DateTime.Now
        End Select
        LoadForms.RestoreLayoutFromXml(Frm.GridView2, "vw_TRANSH_F_def.xml")
        LoadForms.RestoreLayoutFromXml(Frm.GridView1, "TRANSD.xml")
        Frm.cmdSaveTransH.Enabled = IIf(Mode = FormMode.NewRecord, UserProps.AllowInsert, UserProps.AllowEdit)
        Frm.cmdSaveTransD.Enabled = IIf(Mode = FormMode.NewRecord, UserProps.AllowInsert, UserProps.AllowEdit)

    End Sub
    Public Sub LoadSalerTziroi()
        Dim frmSalerTziroi As New frmSalerTziroi
        frmSalerTziroi.Text = "Τζίροι-Ποσοστά έκθεσης"
        frmSalerTziroi.ID = sEMP_T_ID
        frmSalerTziroi.MdiParent = frmMain
        frmSalerTziroi.Mode = FormMode.EditRecord
        frmSalerTziroi.Scroller = Frm.GridView1
        frmSalerTziroi.FormScroller = Frm
        frmSalerTziroi.FormScrollerExist = True
        frmSalerTziroi.CalledFromControl = False
        frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(frmSalerTziroi), New Point(CInt(frmSalerTziroi.Parent.ClientRectangle.Width / 2 - frmSalerTziroi.Width / 2), CInt(frmSalerTziroi.Parent.ClientRectangle.Height / 2 - frmSalerTziroi.Height / 2)))
        frmSalerTziroi.Show()

    End Sub
    Public Sub LoadProjectCost()
        Dim frmProjectCost As New frmProjectCost
        frmProjectCost.Text = "Ανάλυση Έργων"
        frmProjectCost.ID = sProjectCostID
        frmProjectCost.MdiParent = frmMain
        frmProjectCost.Mode = FormMode.EditRecord
        frmProjectCost.FormScroller = Frm
        frmProjectCost.CalledFromControl = False
        frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(frmProjectCost), New Point(CInt(frmProjectCost.Parent.ClientRectangle.Width / 2 - frmProjectCost.Width / 2), CInt(frmProjectCost.Parent.ClientRectangle.Height / 2 - frmProjectCost.Height / 2)))
        frmProjectCost.Show()
    End Sub
    Public Sub LoadInstallations(Optional ByVal Ask As Boolean = False)
        If Ask Then
            If sEMP_T_ID = "" Then
                If XtraMessageBox.Show("Θέλετε να περάσετε εγγραφή στην Μισθοδοσία Τοποθετών?", ProgProps.ProgTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbNo Then Exit Sub
            Else
                Exit Sub
            End If
        End If
        Dim frmInstallations As New frmInstallations
        frmInstallations.Text = "Μισθοδοσία Τοποθετών"
        frmInstallations.MdiParent = frmMain
        frmInstallations.Mode = FormMode.NewRecord
        frmInstallations.Scroller = Frm.GridView1
        frmInstallations.FormScroller = Frm
        frmInstallations.TRANSH_ID = ID
        frmInstallations.EMP_T_ID = sEMP_T_ID
        frmInstallations.CalledFromControl = False
        frmInstallations.cboSaler.EditValue = Frm.cboSaler.EditValue
        frmInstallations.cboCUS.EditValue = Frm.cboCUS.EditValue
        frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(frmInstallations), New Point(CInt(frmInstallations.Parent.ClientRectangle.Width / 2 - frmInstallations.Width / 2), CInt(frmInstallations.Parent.ClientRectangle.Height / 2 - frmInstallations.Height / 2)))
        frmInstallations.Show()
    End Sub
    Public Sub SaveRecordSmallH()
        Dim sResult As Boolean
        Try
            If Valid.ValidateForm(Frm2.LayoutControl1) Then
                ' Καταχώριση/Ενημέρωση Ποσοστά-Τζίρους Έκθεσης
                Select Case Mode
                    Case FormMode.NewRecord
                        ID = System.Guid.NewGuid.ToString
                        sResult = DBQ.InsertNewData(DBQueries.InsertMode.OneLayoutControl, "TRANSH", Frm2.LayoutControl1,,, ID)
                        ' Εαν πετύχει η καταχώρηση του έργου αλλά όχι των κατηγοριών τότε όλο το έργο διαγράφεται
                        If sResult Then If Not SaveTRANSC_SMALL() Then DeleteRecord() : Exit Sub Else Frm2.txtCodeH.Text = DBQ.GetNextId("TRANSH")
                    Case FormMode.EditRecord
                        sResult = DBQ.UpdateNewData(DBQueries.InsertMode.OneLayoutControl, "TRANSH", Frm2.LayoutControl1,,, ID)
                        ' Καταχώρηση κατηγοριών 
                        If sResult Then SaveTRANSC_SMALL()
                End Select
                If sResult = True Then
                    If CalledFromCtrl Then
                        Dim sSQL As New System.Text.StringBuilder
                        sSQL.AppendLine("Select T.id,FullTranshDescription,Description,Iskitchen,Iscloset,Isdoors,Issc from vw_TRANSH t where  T.cusid = " & toSQLValueS(Frm2.cboCUS.EditValue.ToString) & "order by description")
                        FillCbo.TRANSH(CtrlCombo, sSQL) : CtrlCombo.EditValue = System.Guid.Parse(ID)
                    End If
                    XtraMessageBox.Show("Η εγγραφή αποθηκέυτηκε με επιτυχία", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Mode = FormMode.EditRecord
                    If UserProps.ID.ToString.ToUpper = "3F9DC32E-BE5B-4D46-A13C-EA606566CF32" Or UserProps.ID.ToString.ToUpper = "E9CEFD11-47C0-4796-A46B-BC41C4C3606B" Then Frm2.cmdOpenTransh.Enabled = True
                End If
            End If
        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Public Sub SaveRecordH()
        Dim sResult As Boolean, sResultF As Boolean
        Dim sSQL As New System.Text.StringBuilder

        Try
            If Valid.ValidateForm(Frm.LayoutControl2) Then
                ' Καταχώριση/Ενημέρωση Ποσοστά-Τζίρους Έκθεσης
                Select Case Mode
                    Case FormMode.NewRecord
                        ID = System.Guid.NewGuid.ToString
                        sResult = DBQ.InsertNewData(DBQueries.InsertMode.OneLayoutControl, "TRANSH", Frm.LayoutControl2,, , ID,, "bal", toSQLValueS(Frm.txtBal.EditValue.ToString, True))
                        ' Εαν πετύχει η καταχώρηση του έργου αλλά όχι των κατηγοριών τότε όλο το έργο διαγράφεται
                        If sResult Then
                            If Not SaveTRANSC() Then
                                DeleteRecord()
                                Exit Sub
                            Else
                                Frm.txtCodeH.Text = DBQ.GetNextId("TRANSH")
                            End If
                        End If

                    Case FormMode.EditRecord
                        sResult = DBQ.UpdateNewData(DBQueries.InsertMode.OneLayoutControl, "TRANSH", Frm.LayoutControl2,,, ID,,,,, "bal=" & toSQLValueS(Frm.txtBal.EditValue.ToString, True))
                        ' Καταχώρηση κατηγοριών 
                        If sResult Then
                            If Not SaveTRANSC() Then
                                ' Εαν υπάρχει εγγραφή κλεισίματος τότε κάνουμε ενημέρωση των ποσών στους τζίρους και στην ανάλυση
                                If CheckIfClosedRecExist() Then
                                    'Τζίροι ποσοστά
                                    SaveEMP_T()
                                    ' Ανάλυση έργου 
                                    SaveProjectcost()
                                End If
                                Exit Sub
                            End If
                        End If

                End Select

                If Frm.txtFiles.Text <> "" Then
                    sResultF = DBQ.InsertDataFiles(Frm.XtraOpenFileDialog1, ID, "TRANSH_F")
                    Frm.TRANSH_FTableAdapter.FillByTanshID(Frm.DM_TRANS.TRANSH_F, System.Guid.Parse(ID))
                End If

                If CalledFromCtrl = True Then
                    FillCbo.TRANSH(CtrlCombo)
                    CtrlCombo.EditValue = System.Guid.Parse(ID)
                End If
                'Cls.ClearCtrls(LayoutControl1)
                If sResult = True Then
                    XtraMessageBox.Show("Η εγγραφή αποθηκέυτηκε με επιτυχία", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Frm.LayoutControlGroup2.Enabled = True
                    Mode = FormMode.EditRecord
                    Frm.txtFiles.Text = ""
                End If
                If Frm.txtFiles.Text <> "" Then
                    If sResultF = False Then XtraMessageBox.Show("To Παραστατικό δεν αποθηκέυτηκε.", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Public Sub SaveRecordD()
        Dim sResult As Boolean
        Dim sGuid As String, sSQL As String
        Try
            If Valid.ValidateForm(Frm.LayoutControl3) Then
                If PayTypeValidations() = False Then Exit Sub
                If BalValidation() = False Then Exit Sub
                sGuid = System.Guid.NewGuid.ToString
                sResult = DBQ.InsertNewData(DBQueries.InsertMode.OneLayoutControl, "TRANSD", Frm.LayoutControl3,,, sGuid,, "transhID", toSQLValueS(ID))
                If sResult = True Then
                    XtraMessageBox.Show("Η εγγραφή αποθηκέυτηκε με επιτυχία", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Frm.Vw_TRANSDTableAdapter.Fill(Frm.DM_TRANS.vw_TRANSD, System.Guid.Parse(ID))
                    If Frm.cboPayType.EditValue.ToString.ToUpper = "90A295A1-D2A0-40B7-B260-A532B2C322AC" Then
                        'Τζίροι ποσοστά
                        SaveEMP_T()
                        ' Ανάλυση έργου 
                        SaveProjectcost()
                    End If

                    'Καθαρισμός Controls
                    Cls.ClearCtrls(Frm.LayoutControl3)
                    Frm.dtPay.EditValue = DateTime.Now
                    Frm.txtCodeD.Text = DBQ.GetNextId("TRANSD")
                End If
            End If
        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Public Sub UpdateRecordD()
        Dim cash As Byte, cmt As String, Paid As Byte
        Try
            Dim sSQL As String
            If Not IsDBNull(Frm.GridView1.GetRowCellValue(Frm.GridView1.FocusedRowHandle, "cash")) Then
                If Frm.GridView1.GetRowCellValue(Frm.GridView1.FocusedRowHandle, "cash") = True Then cash = 1 Else cash = 0
            End If
            If Not IsDBNull(Frm.GridView1.GetRowCellValue(Frm.GridView1.FocusedRowHandle, "paid")) Then
                If Frm.GridView1.GetRowCellValue(Frm.GridView1.FocusedRowHandle, "paid") = True Then Paid = 1 Else Paid = 0
            End If

            If Not IsDBNull(Frm.GridView1.GetRowCellValue(Frm.GridView1.FocusedRowHandle, "cmt")) Then
                cmt = toSQLValueS(Frm.GridView1.GetRowCellValue(Frm.GridView1.FocusedRowHandle, "cmt"))
            Else
                cmt = "NULL"
            End If

            sSQL = "UPDATE [TRANSD] SET dtPay  = " & toSQLValueS(CDate(Frm.GridView1.GetRowCellValue(Frm.GridView1.FocusedRowHandle, "dtPay")).ToString("yyyyMMdd")) &
                    ",bankID = " & toSQLValueS(Frm.GridView1.GetRowCellValue(Frm.GridView1.FocusedRowHandle, "bankID").ToString) &
                    ",PayTypeID = " & toSQLValueS(Frm.GridView1.GetRowCellValue(Frm.GridView1.FocusedRowHandle, "PayTypeID").ToString) &
                    ",cash = " & cash &
                    ",paid = " & Paid &
                    ",cmt = " & cmt &
                    ",amt = " & toSQLValueS(Frm.GridView1.GetRowCellValue(Frm.GridView1.FocusedRowHandle, "amt"), True) &
                    " WHERE ID = " & toSQLValueS(Frm.GridView1.GetRowCellValue(Frm.GridView1.FocusedRowHandle, "ID").ToString)
            Using oCmd As New SqlCommand(sSQL, CNDB)
                oCmd.ExecuteNonQuery()
            End Using
            sSQL = "UPDATE [TRANSH] SET bal  = " & toSQLValueS(Frm.txtBal.EditValue.ToString, True) & " WHERE ID = " & toSQLValueS(ID)
            Using oCmd As New SqlCommand(sSQL, CNDB)
                oCmd.ExecuteNonQuery()
            End Using

        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Public Function GetTransDAmt() As Double
        Dim sSQL As String
        Dim Cmd As SqlCommand
        Try
            Dim Bal As Double = 0
            sSQL = "SELECT Bal FROM [TRANSH] WHERE ID =  " & toSQLValueS(ID)
            Cmd = New SqlCommand(sSQL, CNDB)
            Dim sdr As SqlDataReader = Cmd.ExecuteReader()
            If (sdr.Read() = True) Then
                If sdr.IsDBNull(sdr.GetOrdinal("Bal")) = False Then Bal = sdr.GetDecimal(sdr.GetOrdinal("Bal")) Else Bal = 0
            End If
            Return Bal
        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return 0
        End Try
    End Function
    'Καταχώρηση Εγγραφής στους Τζίρους ποσοστά
    Private Sub SaveEMP_T()
        Try
            Using oCmd As New SqlCommand("usp_AddOrUpdateProjectcost", CNDB)
                oCmd.CommandType = CommandType.StoredProcedure
                oCmd.Parameters.AddWithValue("@transhID", ID)
                oCmd.ExecuteNonQuery()
            End Using
        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    ' Άνοιγμα ανάλυσης έργου αν δεν υπάρχει ή ενημέρωση ποσών
    Private Sub SaveProjectcost()
        Try
            Using oCmd As New SqlCommand("usp_AddOrUpdateEmp_T", CNDB)
                oCmd.CommandType = CommandType.StoredProcedure
                oCmd.Parameters.AddWithValue("@transhID", ID)
                oCmd.ExecuteNonQuery()
            End Using
        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Function CheckIfClosedRecExist() As Boolean
        Dim sSQL As String
        Dim Cmd As SqlCommand
        Try
            Dim CountClosed As Integer
            sSQL = "SELECT count(ID) as CountClosed FROM [TRANSD] WHERE PayTypeID = '90A295A1-D2A0-40B7-B260-A532B2C322AC' and transhID = " & toSQLValueS(ID)
            Cmd = New SqlCommand(sSQL, CNDB)
            Dim sdr As SqlDataReader = Cmd.ExecuteReader()
            If (sdr.Read() = True) Then
                If sdr.IsDBNull(sdr.GetOrdinal("CountClosed")) = False Then CountClosed = sdr.GetInt32(sdr.GetOrdinal("CountClosed")) Else CountClosed = 0
                If CountClosed = 0 Then Return False Else Return True
            Else
                Return False
            End If
        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try


    End Function
    ' Έλεγχος αν υπάρχει εγγραφή με τύπο πληρωμής "Κλείσιμο" ή δεν έχει καταχωρηθεί διπλή εγγραφή Κλεισίματος
    Private Function PayTypeValidations() As Boolean
        Dim sSQL As String
        Dim Cmd As SqlCommand
        Try
            Dim CountClosed As Integer
            sSQL = "SELECT count(ID) as CountClosed FROM [TRANSD] WHERE PayTypeID = '90A295A1-D2A0-40B7-B260-A532B2C322AC' and transhID = " & toSQLValueS(ID)
            Cmd = New SqlCommand(sSQL, CNDB)
            Dim sdr As SqlDataReader = Cmd.ExecuteReader()
            If (sdr.Read() = True) Then
                If sdr.IsDBNull(sdr.GetOrdinal("CountClosed")) = False Then CountClosed = sdr.GetInt32(sdr.GetOrdinal("CountClosed")) Else CountClosed = 0
                Select Case Frm.cboPayType.EditValue.ToString.ToUpper
                    'Κλεισιμο
                    Case "90A295A1-D2A0-40B7-B260-A532B2C322AC"
                        If CountClosed > 0 Then
                            XtraMessageBox.Show("Δεν μπορείτε να καταχωρήσετε παραπάνω από μια φορές εγγραφή Κλεισίματος. ", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
                            Return False
                        End If
                    Case Else
                        If CountClosed = 0 Then
                            XtraMessageBox.Show("Δεν μπορείτε να καταχωρήσετε άλλον τύπο πληρωμής αν  δεν έχει καταχωρηθεί πρώτα το ΚΛΕΙΣΙΜΟ. ", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
                            Return False
                        End If
                End Select
            End If
            Return True
        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try

    End Function
    Private Function BalValidation() As Boolean
        Try
            Dim amtD As Double, Bal As Double
            amtD = Frm.txtamtD.EditValue : Bal = Frm.txtBal.EditValue
            If amtD > Bal Then
                XtraMessageBox.Show("Το σύνολο της Πίστωσης δεν μπορεί να ξεπερνάει την Χρέωση. ", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function
    'Καταχώρηση Κατηγοριών έργου
    Private Function SaveTRANSC() As Boolean
        Dim sSQL As New System.Text.StringBuilder
        Try
            Using oCmd As New SqlCommand("DELETE FROM TRANSC WHERE TRANSHID = " & toSQLValueS(ID), CNDB)
                oCmd.ExecuteNonQuery()
            End Using
            For Each CheckedItem As CheckedListBoxItem In Frm.cboTransC.Properties.GetItems
                If Frm.cboTransC.EditValue <> Nothing Then
                    If CheckedItem.CheckState = CheckState.Checked Then
                        sSQL.Clear()
                        sSQL.Append("INSERT INTO TRANSC(TRANSHCID,TRANSHID,createdOn,createdBy)")
                        sSQL.Append("SELECT " & toSQLValueS(CheckedItem.Value.ToString) & "," & toSQLValueS(ID) & ",GETDATE()," & toSQLValueS(UserProps.ID.ToString))
                        'Εκτέλεση QUERY
                        Using oCmd As New SqlCommand(sSQL.ToString, CNDB)
                            oCmd.ExecuteNonQuery()
                        End Using
                    End If
                End If
            Next
            Return True
        Catch ex As Exception
            XtraMessageBox.Show("Παρουσιάστηκε πρόβλημα στην καταχώρηση κατηγοριών έργου!" & vbCrLf &
                                String.Format("Error: {0}", ex.Message), ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function
    'Καταχώρηση Κατηγοριών έργου
    Private Function SaveTRANSC_SMALL() As Boolean
        Dim sSQL As New System.Text.StringBuilder
        Try
            Using oCmd As New SqlCommand("DELETE FROM TRANSC WHERE TRANSHID = " & toSQLValueS(ID), CNDB)
                oCmd.ExecuteNonQuery()
            End Using
            For Each CheckedItem As CheckedListBoxItem In Frm2.cboTransC.Properties.GetItems
                If Frm2.cboTransC.EditValue <> Nothing Then
                    If CheckedItem.CheckState = CheckState.Checked Then
                        sSQL.Clear()
                        sSQL.Append("INSERT INTO TRANSC(TRANSHCID,TRANSHID,createdOn,createdBy)")
                        sSQL.Append("SELECT " & toSQLValueS(CheckedItem.Value.ToString) & "," & toSQLValueS(ID) & ",GETDATE()," & toSQLValueS(UserProps.ID.ToString))
                        'Εκτέλεση QUERY
                        Using oCmd As New SqlCommand(sSQL.ToString, CNDB)
                            oCmd.ExecuteNonQuery()
                        End Using
                    End If
                End If
            Next
            Return True
        Catch ex As Exception
            XtraMessageBox.Show("Παρουσιάστηκε πρόβλημα στην καταχώρηση κατηγοριών έργου!" & vbCrLf &
                                String.Format("Error: {0}", ex.Message), ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function
    Private Sub DeleteRecord()
        Try
            Using oCmd As New SqlCommand("DELETE FROM TRANSH WHERE ID = " & toSQLValueS(ID), CNDB)
                oCmd.ExecuteNonQuery()
            End Using
        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Public Sub DeleteRecordF()
        Try
            Dim sSQL As String
            If Frm.GridView2.GetRowCellValue(Frm.GridView2.FocusedRowHandle, "ID") = Nothing Then Exit Sub
            If XtraMessageBox.Show("Θέλετε να διαγραφεί η τρέχουσα εγγραφή?", ProgProps.ProgTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                sSQL = "DELETE FROM TRANSH_F WHERE ID = '" & Frm.GridView2.GetRowCellValue(Frm.GridView2.FocusedRowHandle, "ID").ToString & "'"

                Using oCmd As New SqlCommand(sSQL, CNDB)
                    oCmd.ExecuteNonQuery()
                End Using
                XtraMessageBox.Show("Η εγγραφή διαγράφηκε με επιτυχία", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Frm.TRANSH_FTableAdapter.FillByTanshID(Frm.DM_TRANS.TRANSH_F, System.Guid.Parse(ID))
            End If
        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Public Sub DeleteRecordD()
        Dim sSQL As String
        Try
            If Frm.GridView1.GetRowCellValue(Frm.GridView1.FocusedRowHandle, "ID") = Nothing Then Exit Sub
            If XtraMessageBox.Show("Θέλετε να διαγραφεί η τρέχουσα εγγραφή?", ProgProps.ProgTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                sSQL = "DELETE FROM TRANSD WHERE ID = '" & Frm.GridView1.GetRowCellValue(Frm.GridView1.FocusedRowHandle, "ID").ToString & "'"

                Using oCmd As New SqlCommand(sSQL, CNDB)
                    oCmd.ExecuteNonQuery()
                End Using
                XtraMessageBox.Show("Η εγγραφή διαγράφηκε με επιτυχία", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Frm.Vw_TRANSDTableAdapter.Fill(Frm.DM_TRANS.vw_TRANSD, System.Guid.Parse(ID))
            End If
        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Public Sub PrintedForms()
        Dim cmd As SqlCommand
        Dim sdr As SqlDataReader
        cmd = New SqlCommand(" select AN.ID AS AnID,A.ID as AgID,C.ID as ClID, K.ID as KitID,SC.ID as SpCID,D.ID as DoorsID
                                FROM dbo.vw_TRANSH AS T 
                                LEFT OUTER JOIN dbo.vw_ANALYSH_KOSTOYS AS AN ON AN.ID = T.ID 
                                LEFT OUTER JOIN dbo.vw_AGREEMENT AS A ON A.transhID = T.ID 
                                LEFT OUTER JOIN dbo.vw_CCT_ORDERS_CLOSET AS C ON C.transhID = T.ID 
                                LEFT OUTER JOIN dbo.vw_CCT_ORDERS_KITCHEN AS K ON K.transhID = T.ID 
                                LEFT OUTER JOIN dbo.vw_CCT_ORDERS_SPECIAL_CONSTR AS SC ON SC.transhID = T.ID 
                                LEFT OUTER JOIN dbo.vw_CCT_ORDERS_DOOR AS D ON D.transhID = T.ID  where  T.ID = " & toSQLValueS(ID), CNDB)
        sdr = cmd.ExecuteReader()
        Dim report As New RepCUSPrivateAgreement()
        While sdr.Read()

            If sdr.IsDBNull(sdr.GetOrdinal("AgID")) = False Then
                report.Parameters.Item(0).Value = sdr.GetGuid(sdr.GetOrdinal("AgID"))
                report.CreateDocument()

                Dim report2 As New RepCUSPrivateAgreement2ndPage
                report2.Parameters.Item(0).Value = sdr.GetGuid(sdr.GetOrdinal("AgID"))
                report2.CreateDocument()
                report.ModifyDocument(Sub(x)
                                          x.AddPages(report2.Pages)
                                      End Sub)
                Dim report3 As New RepCUSPrivateAgreement3ndPage
                report3.CreateDocument()
                report.ModifyDocument(Sub(x)
                                          x.AddPages(report3.Pages)
                                      End Sub)
                Dim report4 As New RepCUSPrivateAgreement4ndPage
                report4.CreateDocument()
                report.ModifyDocument(Sub(x)
                                          x.AddPages(report4.Pages)
                                      End Sub)
            End If
            If sdr.IsDBNull(sdr.GetOrdinal("AnID")) = False Then
                Dim report5 As New RepCUSAnalysis
                report5.Parameters.Item(0).Value = sdr.GetGuid(sdr.GetOrdinal("AnID"))
                report5.CreateDocument()
                report.ModifyDocument(Sub(x)
                                          x.AddPages(report5.Pages)
                                      End Sub)
            End If
            If sdr.IsDBNull(sdr.GetOrdinal("KitID")) = False Then
                Dim report6 As New RepCUSOrderKitchen()

                report6.Parameters.Item(0).Value = sdr.GetGuid(sdr.GetOrdinal("KitID"))
                report6.CreateDocument()
                Dim report7 As New RepCUSOrderKitchen2ndPage

                report7.Parameters.Item(0).Value = sdr.GetGuid(sdr.GetOrdinal("KitID"))
                report7.Parameters.Item(1).Value = sdr.GetGuid(sdr.GetOrdinal("KitID"))
                report7.Parameters.Item(2).Value = sdr.GetGuid(sdr.GetOrdinal("KitID"))
                report7.CreateDocument()
                report6.ModifyDocument(Sub(x)
                                           x.AddPages(report7.Pages)
                                       End Sub)
                report.ModifyDocument(Sub(x)
                                          x.AddPages(report6.Pages)
                                      End Sub)
            End If

            If sdr.IsDBNull(sdr.GetOrdinal("ClID")) = False Then
                Dim report8 As New RepCUSOrderCloset()

                report8.Parameters.Item(0).Value = sdr.GetGuid(sdr.GetOrdinal("ClID"))
                report8.CreateDocument()


                Dim report9 As New RepCUSOrderCloset2ndPage

                report9.Parameters.Item(0).Value = sdr.GetGuid(sdr.GetOrdinal("ClID"))
                report9.CreateDocument()
                report8.ModifyDocument(Sub(x)
                                           x.AddPages(report9.Pages)
                                       End Sub)
                report.ModifyDocument(Sub(x)
                                          x.AddPages(report8.Pages)
                                      End Sub)
            End If
            If sdr.IsDBNull(sdr.GetOrdinal("DoorsID")) = False Then
                Dim report10 As New RepCUSOrderDoors()
                report10.Parameters.Item(0).Value = sdr.GetGuid(sdr.GetOrdinal("DoorsID"))
                report10.CreateDocument()
                report.ModifyDocument(Sub(x)
                                          x.AddPages(report10.Pages)
                                      End Sub)
            End If
            If sdr.IsDBNull(sdr.GetOrdinal("SpCID")) = False Then
                Dim report11 As New RepCUSOrderSpecialConstr()
                report11.Parameters.Item(0).Value = sdr.GetGuid(sdr.GetOrdinal("SpCID"))
                report11.CreateDocument()
                report.ModifyDocument(Sub(x)
                                          x.AddPages(report11.Pages)
                                      End Sub)
            End If
        End While
        sdr.Close()
        Dim printTool As New ReportPrintTool(report)
        printTool.ShowRibbonPreview()
    End Sub
    Public Function GetNextID() As Integer
        Return DBQ.GetNextId("TRANSH")
    End Function
End Class
