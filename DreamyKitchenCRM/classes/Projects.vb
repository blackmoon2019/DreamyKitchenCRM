Imports DevExpress.DashboardCommon
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraReports.UI
Imports System.Data.SqlClient

Public Class Projects
    Private LoadForms As New FormLoader
    Private Valid As New ValidateControls
    Private DBQ As New DBQueries
    Private FrmScr As DevExpress.XtraEditors.XtraForm
    Private Frm As frmTransactions
    Private ID As String
    Private Mode As Byte
    Private CalledFromCtrl As Boolean
    Private CtrlCombo As DevExpress.XtraEditors.LookUpEdit
    Private FillCbo As New FillCombos
    Private Cls As New ClearControls


    Public Sub Initialize(ByVal sFrm As frmTransactions, ByVal sID As String, ByVal sMode As Byte, ByVal sCalledFromCtrl As Boolean, ByVal sCtrlCombo As DevExpress.XtraEditors.LookUpEdit, ByVal sFrmScr As DevExpress.XtraEditors.XtraForm)
        Frm = sFrm
        ID = sID
        Mode = sMode
        CalledFromCtrl = sCalledFromCtrl
        CtrlCombo = sCtrlCombo
        FrmScr = sFrmScr
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
    End Sub
    Public Sub SaveRecordH()
        Dim sResult As Boolean, sResultF As Boolean
        Dim sSQL As New System.Text.StringBuilder

        Try
            If Valid.ValidateFormGRP(Frm.LayoutControlGroup1) Then
                ' Καταχώριση/Ενημέρωση Ποσοστά-Τζίρους Έκθεσης
                Select Case Mode
                    Case FormMode.NewRecord
                        ID = System.Guid.NewGuid.ToString
                        sResult = DBQ.InsertNewData(DBQueries.InsertMode.GroupLayoutControl, "TRANSH",,, Frm.LayoutControlGroup1, ID,, "bal", toSQLValueS(Frm.txtBal.EditValue.ToString, True))
                        ' Εαν πετύχει η καταχώρηση του έργου αλλά όχι των κατηγοριών τότε όλο το έργο διαγράφεται
                        If sResult Then If Not SaveTRANSC() Then DeleteRecord()

                    Case FormMode.EditRecord
                        sResult = DBQ.UpdateNewData(DBQueries.InsertMode.GroupLayoutControl, "TRANSH",,, Frm.LayoutControlGroup1, ID,,,,, "bal=" & toSQLValueS(Frm.txtBal.EditValue.ToString, True))
                        ' Καταχώρηση κατηγοριών 
                        If sResult Then SaveTRANSC()

                        '' Άνοιγμα έργου αν δεν υπάρχει ή ενημέρωση ποσών
                        'Using oCmd As New SqlCommand("usp_CreateProjectcost", CNDB)
                        '    oCmd.CommandType = CommandType.StoredProcedure
                        '    oCmd.Parameters.AddWithValue("@transhID", sGuid)
                        '    oCmd.ExecuteNonQuery()
                        'End Using
                        'sSQL.Clear()
                        'sSQL.AppendLine("UPDATE EMP_T SET CUSID = " & toSQLValueS(cboCUS.EditValue.ToString) & ",")
                        'sSQL.AppendLine("EMPID = " & toSQLValueS(cboSaler.EditValue.ToString) & ",")
                        'sSQL.AppendLine("SALEPRICE = " & toSQLValueS(txtTotAmt.EditValue, True) & ",")
                        'sSQL.AppendLine("MODIFIEDBY= " & toSQLValueS(UserProps.ID.ToString) & ",")
                        'sSQL.AppendLine("MODIFIEDON= GETDATE(), ")
                        'sSQL.AppendLine("DTPAY = " & toSQLValueS(CDate(dtPay.Text).ToString("yyyyMMdd")))


                        'sSQL.AppendLine("WHERE TRANSHID = " & toSQLValueS(sID))
                        ''Εκτέλεση QUERY
                        'Using oCmd As New SqlCommand(sSQL.ToString, CNDB)
                        '    oCmd.ExecuteNonQuery()
                        'End Using
                End Select
                'Καθαρισμός Controls
                'If Mode = FormMode.EditRecord Then Cls.ClearCtrls(LayoutControl1)
                'dtDTS.EditValue = DateTime.Now

                If Frm.txtInvoiceFilename.Text <> "" Then
                    sResultF = DBQ.InsertDataFiles(Frm.XtraOpenFileDialog1, ID, "TRANSH_F")
                    Frm.TRANSH_FTableAdapter.FillByTanshID(Frm.DM_TRANS.TRANSH_F, System.Guid.Parse(ID))
                End If
                Frm.txtCodeH.Text = DBQ.GetNextId("TRANSH")
                Frm.txtCodeD.Text = DBQ.GetNextId("TRANSD")
                If CalledFromCtrl = True Then
                    FillCbo.TRANSH(CtrlCombo)
                    CtrlCombo.EditValue = System.Guid.Parse(ID)
                End If
                'Cls.ClearCtrls(LayoutControl1)
                If sResult = True Then
                    XtraMessageBox.Show("Η εγγραφή αποθηκέυτηκε με επιτυχία", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Frm.LayoutControlGroup2.Enabled = True
                    Mode = FormMode.EditRecord
                    Frm.txtInvoiceFilename.Text = ""
                End If
                If Frm.txtInvoiceFilename.Text <> "" Then
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
            If Valid.ValidateFormGRP(Frm.LayoutControlGroup2) Then
                If PayTypeValidations() = False Then Exit Sub
                If BalValidation() = False Then Exit Sub
                sGuid = System.Guid.NewGuid.ToString
                sResult = DBQ.InsertNewData(DBQueries.InsertMode.GroupLayoutControl, "TRANSD",,, Frm.LayoutControlGroup2, sGuid,, "transhID", toSQLValueS(ID))
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
                    Cls.ClearCtrlsGRP(Frm.LayoutControlGroup2)
                    Frm.dtPay.EditValue = DateTime.Now
                    Frm.txtCodeD.Text = DBQ.GetNextId("TRANSD")
                End If
            End If
        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    'Καταχώρηση Εγγραφής στους Τζίρους ποσοστά
    Private Sub SaveEMP_T()
        Try
            Dim sSQL As New System.Text.StringBuilder
            Dim sEMP_T_ID As String
            sSQL.Clear()
            sEMP_T_ID = System.Guid.NewGuid.ToString
            sSQL.AppendLine("INSERT INTO EMP_T (ID,CUSID,EMPID,SALEPRICE,CREATEDBY,CREATEDON,TRANSHID)")
            sSQL.AppendLine("Select " & toSQLValueS(sEMP_T_ID.ToString) & ",")
            sSQL.AppendLine(toSQLValueS(Frm.cboCUS.EditValue.ToString) & ",")
            sSQL.AppendLine(toSQLValueS(Frm.cboSaler.EditValue.ToString) & ",")
            sSQL.AppendLine(toSQLValueS(Frm.txtTotAmt.EditValue, True) & ",")
            sSQL.AppendLine(toSQLValueS(UserProps.ID.ToString) & ",")
            sSQL.AppendLine("getdate(),")
            sSQL.AppendLine(toSQLValueS(ID))

            ''Εκτέλεση QUERY
            Using oCmd As New SqlCommand(sSQL.ToString, CNDB)
                oCmd.ExecuteNonQuery()
            End Using
        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    ' Άνοιγμα ανάλυσης έργου αν δεν υπάρχει ή ενημέρωση ποσών
    Private Sub SaveProjectcost()
        Try
            Using oCmd As New SqlCommand("usp_CreateProjectcost", CNDB)
                oCmd.CommandType = CommandType.StoredProcedure
                oCmd.Parameters.AddWithValue("@transhID", ID)
                oCmd.ExecuteNonQuery()
            End Using
        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
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
            If Frm.txtamtD.EditValue > Frm.txtBal.EditValue Then
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
                        sSQL.Append("INSERT INTO TRANSC(ID,TRANSHID,createdOn,createdBy)")
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
