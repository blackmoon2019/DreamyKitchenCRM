Imports System.Data.SqlClient
Imports System.Runtime.Remoting.Metadata.W3cXsd2001
Imports System.Text
Imports DevExpress.Utils
Imports DevExpress.Utils.Extensions
Imports DevExpress.XtraEditors
Imports DevExpress.XtraLayout
Imports DevExpress.XtraReports.UI

Public Class CusPrivateAgreement
    Private Valid As New ValidateControls
    Private FillCbo As New FillCombos
    Private ID As String
    Private sIsOrder As Boolean
    Private Mode As Byte
    Private CalledFromCtrl As Boolean
    Private CtrlCombo As DevExpress.XtraEditors.LookUpEdit
    Private Cls As New ClearControls
    Private DBQ As New DBQueries
    Private LoadForms As New FormLoader
    Private Frm As frmCUSPrivateAgreement
    Private Prog_Prop As New ProgProp
    Private ChangeVal As Boolean = False
    Public CompanyID As Guid
    Public CompTranshID As Guid
    Public CusID As Guid
    Public TranshID As Guid
    Public EmpID As Guid
    Private isCustomer As Boolean


    Public Sub Initialize(ByVal sFrm As frmCUSPrivateAgreement, ByVal sID As String, ByVal sMode As Byte, ByVal sCalledFromCtrl As Boolean, ByVal sCtrlCombo As DevExpress.XtraEditors.LookUpEdit)
        Frm = sFrm
        ID = sID
        Mode = sMode
        CalledFromCtrl = sCalledFromCtrl
        CtrlCombo = sCtrlCombo
        Frm.Vw_COMPTableAdapter.Fill(Frm.DM_CCT.vw_COMP)
        Frm.Vw_INVTYPESTableAdapter.Fill(Frm.DreamyKitchenDataSet.vw_INVTYPES)
        Frm.Vw_BANKSTableAdapter.Fill(Frm.DreamyKitchenDataSet.vw_BANKS)
        Frm.Vw_CCTTableAdapter.Fill(Frm.DreamyKitchenDataSet.vw_CCT)
        Frm.Vw_SALERSTableAdapter.Fill(Frm.DreamyKitchenDataSet.vw_SALERS)
        FillCbo.ADR(Frm.cboADR)
        Frm.cboCompany.EditValue = System.Guid.Parse(CompanyID.ToString)
        If CompanyID <> Guid.Empty Then FillCompanyProjects()
        Frm.cboCompProject.EditValue = System.Guid.Parse(CompTranshID.ToString)
        Frm.cboCUS.EditValue = System.Guid.Parse(CusID.ToString)
        If CusID <> Guid.Empty Then FillCusTransh()
        Frm.cboTRANSH.EditValue = System.Guid.Parse(TranshID.ToString)
        Frm.cboEMP.EditValue = System.Guid.Parse(EmpID.ToString)
        If Frm.cboTRANSH.GetColumnValue("AgreementExist") = "1" Then
            ID = Frm.cboTRANSH.GetColumnValue("AgreementID").ToString
            Mode = FormMode.EditRecord
        Else
            Mode = FormMode.NewRecord
        End If
    End Sub


    Public Sub LoadForm()
        'If Frm.cboTRANSH.GetColumnValue("AgreementExist") = "1" Then
        '    .ID = cboTRANSH.GetColumnValue("AgreementID").ToString
        '    .Mode = FormMode.EditRecord
        'Else
        '    .Mode = FormMode.NewRecord
        'End If


        Select Case Mode
            Case FormMode.NewRecord
                Frm.txtCode.Text = DBQ.GetNextId("AGREEMENT")
                'Frm.cboEMP.EditValue = System.Guid.Parse(UserProps.ID.ToString.ToUpper)
                Frm.dtpresentation.EditValue = Date.Now
                ChangeVal = True : Frm.lblMsg.Text = "Το Συμφωνητικό δεν έχει αποθηκευτεί"
                Frm.LCheckList.Visibility = Utils.LayoutVisibility.Never
                Frm.LMsg.Visibility = Utils.LayoutVisibility.Always
            Case FormMode.EditRecord
                LoadForms.LoadForm(Frm.LayoutControl1, "Select * from AGREEMENT where id = " & toSQLValueS(ID))
                ChangeVal = False
                Frm.cmdPrintOffer.Enabled = True
        End Select
        If CompanyID = Guid.Empty Then FillCompanyProjects()
        If CusID = Guid.Empty Then FillCusTransh()
        GetKLeisimoAmt(Frm.cboTRANSH.EditValue.ToString)
        GetPayInAdvanceAmt(Frm.cboTRANSH.EditValue.ToString)
        GetProjectAmounts(Frm.cboTRANSH.EditValue.ToString)
        GetPayInAdvanceBal()
        FillArProt()


        If Frm.cboCUS.EditValue = Frm.cboCompany.EditValue Then isCustomer = False Else isCustomer = True
        If isCustomer Then
            Frm.cmdCompCollection.Enabled = False
            Frm.cmdCusCollection.Enabled = True
            Frm.LLegalRepresentative.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
            Frm.LLegalRepresentative.Tag = ""
        Else
            Frm.LLegalRepresentative.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
            Frm.LLegalRepresentative.Tag = "1"
            Frm.LFatherName.Tag = "" : Frm.LFatherName.ImageOptions.Image = Nothing
            Frm.cmdCompCollection.Enabled = True
            Frm.cmdCusCollection.Enabled = False
        End If

        Frm.cboInvoiceType.EditValue = Frm.cboTRANSH.GetColumnValue("invType")
        Frm.cmdSave.Enabled = IIf(Mode = FormMode.NewRecord, UserProps.AllowInsert, UserProps.AllowEdit)
        Frm.chkHasCloset.Properties.AllowHtmlDraw = DefaultBoolean.True
        Frm.chkHasCloset.Text = "<href=www.dreamykitchen.gr/>Ντουλάπες Υπνοδωματίου</href>"
        Frm.chkHasDoors.Properties.AllowHtmlDraw = DefaultBoolean.True
        Frm.chkHasDoors.Text = "<href=www.dreamykitchen.gr/>Πόρτες Εσωτερικές</href>"
        Frm.chkHasKitchen.Properties.AllowHtmlDraw = DefaultBoolean.True
        Frm.chkHasKitchen.Text = "<href=www.dreamykitchen.gr/>Ερμάρια Κουζίνας</href>"
        Frm.chkHasSC.Properties.AllowHtmlDraw = DefaultBoolean.True
        Frm.chkHasSC.Text = "<href=www.dreamykitchen.gr/>Ειδικές Κατασκευές</href>"

    End Sub
    Public Sub GetPayInAdvanceBal()
        Dim TotalPayinAdvance As Double, CloseTot As Double, BalPayinAdvance As Double, TotalPayinAdvanceBench As Double
        Dim CusPayInAdvance As Double
        If Frm.txtPayinAdvanceTot.EditValue IsNot Nothing Then TotalPayinAdvance = DbnullToZero(Frm.txtPayinAdvanceTot)
        If Frm.txtPayInAdvanceBench.EditValue isnot Nothing Then TotalPayinAdvanceBench = DbnullToZero(Frm.txtPayInAdvanceBench)
        If Frm.txtCloseTot.EditValue isnot Nothing Then CloseTot = DbnullToZero(Frm.txtCloseTot)
        CusPayInAdvance = CusPayInAdvanceInf()
        BalPayinAdvance = CusPayInAdvance - (TotalPayinAdvance + TotalPayinAdvanceBench + CloseTot)
        Frm.txtPayinAdvanceBal.EditValue = BalPayinAdvance
        Frm.lblPayInAdvnace.Text = "Ο πελάτης πρέπει να καταβάλει το 50% του έργου: " & CusPayInAdvance & "€"
    End Sub
    Private Sub FillCusTransh()
        Dim sCusID As String, scompTrashID As String, sCompID As String
        If CusID = Guid.Empty Then sCusID = toSQLValueS(Guid.Empty.ToString) Else sCusID = toSQLValueS(CusID.ToString)
        If Frm.cboCompany.EditValue Is Nothing Then sCompID = toSQLValueS(Guid.Empty.ToString) Else sCompID = toSQLValueS(Frm.cboCompany.EditValue.ToString)
        If CompTranshID = Guid.Empty Then
            scompTrashID = " and T.compTrashID  IS NULL"
        Else
            'Εαν το συμφωνητικό δεν αφορά τον ίδιο τον κατασκευαστή
            If sCusID <> sCompID Then scompTrashID = " and T.compTrashID   = " & toSQLValueS(CompTranshID.ToString)
        End If
            Dim sSQL As New System.Text.StringBuilder
        sSQL.AppendLine("Select T.id,FullTranshDescription,Description,Iskitchen,Iscloset,Isdoor,Issc,AgreementExist,AgreementID,t.invType,ArProtKitchen,ArProtCloset,ArProtDoor,ArProtSpecialContr
                        from vw_TRANSH t
                        INNER JOIN TRANSC on transc.transhID = t.id 
                        where   completed = 0  and T.cusid = " & sCusID & scompTrashID & " order by description")
        FillCbo.TRANSH(Frm.cboTRANSH, sSQL)
        Frm.cboCUS.EditValue = System.Guid.Parse(sCusID.Replace("'", ""))
        Frm.cboCompProject.EditValue = System.Guid.Parse(CompTranshID.ToString)
        Frm.txtFatherName.EditValue = Frm.cboCUS.GetColumnValue("FatherName")
        Frm.txtArea.EditValue = Frm.cboCUS.GetColumnValue("AREAS_Name")
        Frm.txtDOY.EditValue = Frm.cboCUS.GetColumnValue("DOY_Name")
        Frm.txtAFM.EditValue = Frm.cboCUS.GetColumnValue("afm")
        Frm.cboADR.EditValue = Frm.cboCUS.GetColumnValue("AdrID")
    End Sub
    Private Sub FillCompanyProjects()
        Dim sCompID As String
        If Frm.cboCompany.EditValue Is Nothing Then sCompID = toSQLValueS(Guid.Empty.ToString) Else sCompID = toSQLValueS(Frm.cboCompany.EditValue.ToString)
        Dim sSQL As New System.Text.StringBuilder
        sSQL.AppendLine("Select T.id,FullTranshDescription,Description,Iskitchen,Iscloset,Isdoor,Issc
                        from vw_TRANSH t
                        INNER JOIN TRANSC on transc.transhID = t.id and transc.transhcID ='60344B92-1925-42E9-8D0F-0525990B0D5F'
                        where  completed = 0  and T.cusid = " & sCompID & "order by description")
        FillCbo.TRANSH(Frm.cboCompProject, sSQL)
        Frm.cboCompany.EditValue = System.Guid.Parse(sCompID.Replace("'", ""))
        Frm.LCompProject.ImageOptions.Image = Global.DreamyKitchenCRM.My.Resources.Resources.rsz_11rsz_asterisk
        Frm.cmdCompCollection.Enabled = True

    End Sub
    Private Sub FillArProt()
        Dim sArProt As New StringBuilder
        sArProt.Append(Frm.cboTRANSH.GetColumnValue("ArProtKitchen") & " ")
        sArProt.Append(Frm.cboTRANSH.GetColumnValue("ArProtCloset") & " ")
        sArProt.Append(Frm.cboTRANSH.GetColumnValue("ArProtDoor") & " ")
        sArProt.Append(Frm.cboTRANSH.GetColumnValue("ArProtSpecialContr") & " ")
        Frm.txtArProt.EditValue = sArProt
    End Sub
    Public Function SaveRecord(ByRef sID As String) As Boolean
        Dim sResult As Boolean
        Dim sGuid As String
        Try
            If Valid.ValidateForm(Frm.LayoutControl1) Then
                If Frm.txtPayinAdvanceTot.EditValue = "0,00" Then
                    XtraMessageBox.Show("Δεν έχετε συμπληρώσει στην προκαταβολη (Μετρητά,Τράπεζα ή και τα 2).", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return False
                End If
                ' Έλεγχος αν η προκαταβολή καλύπτει το 50% του έργου
                CheckForValidPayinAdvaνce()
                Select Case Mode
                    Case FormMode.NewRecord
                        sGuid = System.Guid.NewGuid.ToString
                        sResult = DBQ.InsertNewData(DBQueries.InsertMode.OneLayoutControl, "AGREEMENT", Frm.LayoutControl1,,, sGuid, True)
                        ID = sGuid : sID = ID
                    Case FormMode.EditRecord
                        sResult = DBQ.UpdateNewData(DBQueries.InsertMode.OneLayoutControl, "AGREEMENT", Frm.LayoutControl1,,, sID, True)
                        sGuid = ID : sID = ID
                End Select

                If sResult = True Then
                    XtraMessageBox.Show("Η εγγραφή αποθηκέυτηκε με επιτυχία", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Frm.cmdPrintOffer.Enabled = True
                    ' Ενημέρωση πεδίων έργου
                    UpdateTransH()
                    ' 
                    If isCustomer Then
                        'Τζίροι ποσοστά
                        SaveEMP_T()
                        ' Ανάλυση έργου 
                        SaveProjectcost()
                    End If
                    'Ελεγχος για λανθασμένη κατανομή ποσών
                    CheckForNegative()
                    Mode = FormMode.EditRecord
                    Return True
                Else
                    Return False
                End If
            Else
                Return False
            End If

        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function
    ' Ενημέρωση πεδίων έργου
    Private Sub UpdateTransH()
        Try
            Dim GenTot As Double
            Dim sSQL As New System.Text.StringBuilder

            GenTot = Frm.txtGenTot.EditValue
            Dim PolisiErgou As Double = GenTot - Frm.txtDevices.EditValue
            GenTot = GenTot + Frm.txtDevices.EditValue
            sSQL.Clear()
            sSQL.AppendLine("update TRANSH SET waitingForAgreement=1,invType = " & toSQLValueS(Frm.cboInvoiceType.EditValue.ToString) & ",  vatamt = " & toSQLValueS(Frm.txtPartofVat.EditValue.ToString, True) & ", " &
                            " amt = " & toSQLValueS(Frm.txtPosoParastatikou.EditValue.ToString, True) & ",debitcost = " & toSQLValueS(PolisiErgou.ToString, True) & ", " &
                            " DevicesCost = " & toSQLValueS(Frm.txtDevices.EditValue.ToString, True) & ",  totamt = ISNULL(benchSalesPrice,0) + ISNULL(extracost,0) + " & toSQLValueS(Frm.txtGenTot.EditValue.ToString, True) & " where ID = " & toSQLValueS(Frm.cboTRANSH.EditValue.ToString))
            'Εκτέλεση QUERY
            Using oCmd As New SqlCommand(sSQL.ToString, CNDB)
                oCmd.ExecuteNonQuery()
            End Using
        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    'Καταχώρηση Εγγραφής στους Τζίρους ποσοστά
    Private Sub SaveEMP_T()
        Try
            Using oCmd As New SqlCommand("usp_AddOrUpdateEmp_T", CNDB)
                oCmd.CommandType = CommandType.StoredProcedure
                oCmd.Parameters.AddWithValue("@transhID", TranshID.ToString)
                oCmd.ExecuteNonQuery()
            End Using
        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    ' Άνοιγμα ανάλυσης έργου αν δεν υπάρχει ή ενημέρωση ποσών
    Private Sub SaveProjectcost()
        Try
            Using oCmd As New SqlCommand("usp_AddOrUpdateProjectcost", CNDB)
                oCmd.CommandType = CommandType.StoredProcedure
                oCmd.Parameters.AddWithValue("@transhID", TranshID.ToString)
                oCmd.ExecuteNonQuery()
            End Using
        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    'Ελεγχος για λανθασμένη κατανομή ποσών
    Private Sub CheckForNegative()
        Dim cmd As SqlCommand
        Dim sdr As SqlDataReader
        Try
            Dim ExistNegative As Integer = 0
            cmd = New SqlCommand("  select  count(id) as ExistNegative  
	                                        from vw_ANALYSH_KOSTOYS 
	                                        where (KLEISIMO_CASH<0 or ΕΝΑΝΤΙ_CASH<0 OR [EXOFLISI_CASH]<0 OR KLEISIMO_BANK<0 OR [ΕΝΑΝΤΙ_BANK]<0
	                                        OR EXOFLISI_BANK<0)  and ID = " & toSQLValueS(Frm.cboTRANSH.EditValue.ToString), CNDB)
            sdr = cmd.ExecuteReader()
            If (sdr.Read() = True) Then
                If sdr.IsDBNull(sdr.GetOrdinal("ExistNegative")) = False Then ExistNegative = sdr.GetInt32(sdr.GetOrdinal("ExistNegative"))
            End If
            sdr.Close()
            If ExistNegative > 0 Then
                XtraMessageBox.Show("Λανθασμένη κατανομή ποσών στον τρόπο πληρωμής", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Dim report As New RepCUSAnalysis
                report.Parameters.Item(0).Value = Frm.cboTRANSH.EditValue.ToString
                report.CreateDocument()

                Dim printTool As New ReportPrintTool(report)
                printTool.ShowRibbonPreview()

            End If
        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
            sdr.Close()
        End Try
    End Sub
    Private Sub CheckForValidPayinAdvaνce()
        Dim TotalPayinAdvance As Double, PayinAdvance As Double, closeAmt As Double, CheckPayInAdvance As Double, PayInAdvanceBench As Double
        TotalPayinAdvance = 0
        TotalPayinAdvance = DbnullToZero(Frm.txtPayinAdvanceCash)
        TotalPayinAdvance = TotalPayinAdvance + DbnullToZero(Frm.txtPayinAdvanceBank)
        PayInAdvanceBench = DbnullToZero(Frm.txtPayInAdvanceBench)
        PayinAdvance = DbnullToZero(Frm.txtPayinAdvanceTot)
        closeAmt = DbnullToZero(Frm.txtCloseBank)
        closeAmt = closeAmt + DbnullToZero(Frm.txtCloseCash)
        TotalPayinAdvance = TotalPayinAdvance + closeAmt + PayInAdvanceBench
        ' Αυτό που πρέπει να δίνει ο πελάτης με το συμφωνητικό είναι ως προκαταβολή το 50% του έργου
        CheckPayInAdvance = DbnullToZero(Frm.txtGenTot) : CheckPayInAdvance = CheckPayInAdvance / 2
        If Math.Round(TotalPayinAdvance, 2) < Math.Round(CheckPayInAdvance, 2) Then
            XtraMessageBox.Show("Η προκαταβολή που έχει εισπραχθεί είναι μικρότερη του 50% του έργου", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub
    Public Sub GetKLeisimoAmt(ByVal TransHID As String)
        Dim cmd As SqlCommand
        Dim sdr As SqlDataReader
        Dim CloseCash As Double, CloseBank As Double, CloseTot As Double
        Try
            cmd = New SqlCommand("SELECT cash, isnull(sum(amt),0) as amt FROM TRANSD WHERE cash in(0,1) and paytypeID='90A295A1-D2A0-40B7-B260-A532B2C322AC'  and transhID = " & toSQLValueS(TransHID) & " Group By Cash ", CNDB)
            sdr = cmd.ExecuteReader()
            If sdr.HasRows Then
                While sdr.Read()
                    If sdr.GetBoolean(sdr.GetOrdinal("cash")) = "0" Then
                        If sdr.IsDBNull(sdr.GetOrdinal("amt")) = False Then
                            Frm.txtCloseBank.EditValue = sdr.GetDecimal(sdr.GetOrdinal("amt"))
                        Else
                            Frm.txtCloseBank.EditValue = Nothing
                        End If
                    Else
                        If sdr.IsDBNull(sdr.GetOrdinal("amt")) = False Then
                            Frm.txtCloseCash.EditValue = sdr.GetDecimal(sdr.GetOrdinal("amt"))
                        Else
                            Frm.txtCloseCash.EditValue = Nothing
                        End If
                    End If
                End While
                CloseCash = DbnullToZero(Frm.txtCloseCash)
                CloseBank = DbnullToZero(Frm.txtCloseBank)
                CloseTot = CloseCash + CloseBank
                Frm.txtCloseTot.EditValue = CloseTot
            End If
            sdr.Close()
        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Function CusPayInAdvanceInf() As Double
        Dim PayinAdvance As Double
        If Frm.txtGenTot.EditValue isnot Nothing Then
            PayinAdvance = DbnullToZero(Frm.txtGenTot)
            PayinAdvance = PayinAdvance / 2
            Frm.lblPayInAdvnace.Text = "Ο πελάτης πρέπει να καταβάλει το 50% του έργου: " & PayinAdvance & "€"
        End If
        Return PayinAdvance
    End Function
    Public Sub GetPayInAdvanceAmt(ByVal TransHID As String)
        Dim cmd As SqlCommand
        Dim sdr As SqlDataReader
        Dim TotalPayInAdvance As Double
        Try
            cmd = New SqlCommand("SELECT paytypeID,cash, isnull(sum(amt),0) as amt FROM TRANSD WHERE cash in(0,1) and paytypeID in('CEB0FF51-CA48-4EC1-962E-1B46851A37BD', '27CF38F4-BD30-403C-8BC6-2D2A57501DEB')  and transhID = " & toSQLValueS(TransHID) & " Group By Cash,paytypeID ", CNDB)
            sdr = cmd.ExecuteReader()
            If sdr.HasRows Then
                While sdr.Read()

                    Select Case sdr.GetGuid(sdr.GetOrdinal("paytypeID")).ToString.ToUpper
                        Case "CEB0FF51-CA48-4EC1-962E-1B46851A37BD" ' Προκαταβολή Πάγκου
                            Frm.txtPayInAdvanceBench.EditValue = sdr.GetDecimal(sdr.GetOrdinal("amt"))
                        Case "27CF38F4-BD30-403C-8BC6-2D2A57501DEB" ' Προκαταβολή
                            If sdr.GetBoolean(sdr.GetOrdinal("cash")) = "0" Then
                                If sdr.IsDBNull(sdr.GetOrdinal("amt")) = False Then
                                    Frm.txtPayinAdvanceBank.EditValue = sdr.GetDecimal(sdr.GetOrdinal("amt"))
                                    TotalPayInAdvance = TotalPayInAdvance + DbnullToZero(Frm.txtPayinAdvanceBank)
                                Else
                                    Frm.txtPayinAdvanceBank.EditValue = Nothing
                                End If
                            Else
                                If sdr.IsDBNull(sdr.GetOrdinal("amt")) = False Then
                                    Frm.txtPayinAdvanceCash.EditValue = sdr.GetDecimal(sdr.GetOrdinal("amt"))
                                    TotalPayInAdvance = TotalPayInAdvance + DbnullToZero(Frm.txtPayinAdvanceCash)
                                Else
                                    Frm.txtPayinAdvanceCash.EditValue = Nothing
                                End If
                            End If
                    End Select
                End While
                Frm.txtPayinAdvanceTot.EditValue = TotalPayInAdvance
            End If
            sdr.Close()
        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Public Sub GetProjectAmounts(ByVal TransHID As String)
        Dim cmd As SqlCommand
        Dim sdr As SqlDataReader
        Try
            cmd = New SqlCommand(" select   TotPartOfVat,TotalVat,TotalPrice,TotalDevices,GENTOT,ExtraInst, ExtraTransp,
                                            TotKitchen,TotDoor,HasCloset,HasKitchen,HasSpecial,HasDoors,PosoParastatikou,benchSalesPrice
                                    FROM vw_ANALYSH_KOSTOYS WHERE ID = " & toSQLValueS(TransHID), CNDB)
            sdr = cmd.ExecuteReader()
            If (sdr.Read() = True) Then
                If sdr.IsDBNull(sdr.GetOrdinal("TotPartOfVat")) = False Then Frm.txtPartofVat.EditValue = sdr.GetDecimal(sdr.GetOrdinal("TotPartOfVat")) Else Frm.txtPartofVat.EditValue = Nothing
                If sdr.IsDBNull(sdr.GetOrdinal("TotalVat")) = False Then Frm.TxtTotalVat.EditValue = sdr.GetDecimal(sdr.GetOrdinal("TotalVat")) Else Frm.TxtTotalVat.EditValue = Nothing
                If sdr.IsDBNull(sdr.GetOrdinal("TotalPrice")) = False Then Frm.txtTotalVatPrice.EditValue = sdr.GetDecimal(sdr.GetOrdinal("TotalPrice")) Else Frm.txtTotalVatPrice.EditValue = Nothing
                If sdr.IsDBNull(sdr.GetOrdinal("GENTOT")) = False Then Frm.txtGenTot.EditValue = sdr.GetDecimal(sdr.GetOrdinal("GENTOT")) Else Frm.txtGenTot.EditValue = Nothing
                Frm.chkHasKitchen.Checked = sdr.GetBoolean(sdr.GetOrdinal("HasKitchen"))
                Frm.chkHasCloset.Checked = sdr.GetBoolean(sdr.GetOrdinal("HasCloset"))
                Frm.chkHasDoors.Checked = sdr.GetBoolean(sdr.GetOrdinal("HasDoors"))
                Frm.chkHasSC.Checked = sdr.GetBoolean(sdr.GetOrdinal("HasSpecial"))
                If sdr.IsDBNull(sdr.GetOrdinal("PosoParastatikou")) = False Then Frm.txtPosoParastatikou.EditValue = sdr.GetDecimal(sdr.GetOrdinal("PosoParastatikou"))
                If sdr.IsDBNull(sdr.GetOrdinal("TotalDevices")) = False Then Frm.txtDevices.EditValue = sdr.GetDecimal(sdr.GetOrdinal("TotalDevices"))
                If sdr.IsDBNull(sdr.GetOrdinal("benchSalesPrice")) = False Then Frm.txtTotalbenchSalesPrice.EditValue = sdr.GetDecimal(sdr.GetOrdinal("benchSalesPrice"))
            End If
            sdr.Close()
        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Public Sub OpenOrder(ByVal Mode As Int16, ByVal sTranshID As String)
        Dim cmd As SqlCommand
        Dim sdr As SqlDataReader
        Dim oID As String = ""
        Try

            Select Case Mode
                Case 1 ' Κουζίνα
                    cmd = New SqlCommand("SELECT ID FROM CCT_ORDERS_KITCHEN WHERE isOrder = 1 and transhID = " & toSQLValueS(sTranshID), CNDB)
                    sdr = cmd.ExecuteReader()
                    If (sdr.Read() = True) Then
                        If sdr.IsDBNull(sdr.GetOrdinal("ID")) = False Then oID = sdr.GetGuid(sdr.GetOrdinal("ID")).ToString
                    End If
                    sdr.Close()
                    If oID = "" Then Exit Sub
                    Dim frmCUSOrderKitchen As frmCUSOfferOrderKitchen = New frmCUSOfferOrderKitchen()
                    frmCUSOrderKitchen.Text = "Έντυπο Παραγγελίας Πελατών(Κουζίνα)"
                    frmCUSOrderKitchen.ID = oID
                    frmCUSOrderKitchen.IsOrder = True
                    'frmCUSOrderKitchen.MdiParent = frmMain
                    frmCUSOrderKitchen.Mode = FormMode.EditRecord
                    frmCUSOrderKitchen.ShowDialog()
                Case 2 ' Πόρτες
                    cmd = New SqlCommand("SELECT ID FROM CCT_ORDERS_DOOR WHERE isOrder = 1 and transhID = " & toSQLValueS(sTranshID), CNDB)
                    sdr = cmd.ExecuteReader()
                    If (sdr.Read() = True) Then
                        If sdr.IsDBNull(sdr.GetOrdinal("ID")) = False Then oID = sdr.GetGuid(sdr.GetOrdinal("ID")).ToString
                    End If
                    sdr.Close()
                    If oID = "" Then Exit Sub
                    Dim frmCUSOfferOrderDoors As frmCUSOfferOrderDoors = New frmCUSOfferOrderDoors()
                    frmCUSOfferOrderDoors.Text = "Έντυπο Παραγγελίας Πελατών(Πόρτες)"
                    frmCUSOfferOrderDoors.IsOrder = True
                    frmCUSOfferOrderDoors.ID = oID
                    frmCUSOfferOrderDoors.IsOrder = True
                    'frmCUSOfferOrderDoors.MdiParent = frmMain
                    frmCUSOfferOrderDoors.Mode = FormMode.EditRecord
                    frmCUSOfferOrderDoors.ShowDialog()
                Case 3 ' Ντουλάπες
                    cmd = New SqlCommand("SELECT ID FROM CCT_ORDERS_CLOSET WHERE isOrder = 1 and  transhID = " & toSQLValueS(sTranshID), CNDB)
                    sdr = cmd.ExecuteReader()
                    If (sdr.Read() = True) Then
                        If sdr.IsDBNull(sdr.GetOrdinal("ID")) = False Then oID = sdr.GetGuid(sdr.GetOrdinal("ID")).ToString
                    End If
                    sdr.Close()
                    If oID = "" Then Exit Sub
                    Dim frmCUSOrderCloset As frmCUSOfferOrderCloset = New frmCUSOfferOrderCloset()
                    frmCUSOrderCloset.Text = "Έντυπο Παραγγελίας Πελατών(Ντουλάπα)"
                    frmCUSOrderCloset.ID = oID
                    frmCUSOrderCloset.IsOrder = True
                    ' frmCUSOrderCloset.MdiParent = frmMain
                    frmCUSOrderCloset.Mode = FormMode.EditRecord
                    frmCUSOrderCloset.ShowDialog()
                Case 4 ' Ειδικές Κατασκευές
                    cmd = New SqlCommand("SELECT ID FROM CCT_ORDERS_SPECIAL_CONSTR WHERE isOrder = 1 and transhID = " & toSQLValueS(sTranshID), CNDB)
                    sdr = cmd.ExecuteReader()
                    If (sdr.Read() = True) Then
                        If sdr.IsDBNull(sdr.GetOrdinal("ID")) = False Then oID = sdr.GetGuid(sdr.GetOrdinal("ID")).ToString
                    End If
                    sdr.Close()
                    If oID = "" Then Exit Sub
                    Dim frmCUSOfferSpecialConstr As frmCUSOfferOrderSpecialConstr = New frmCUSOfferOrderSpecialConstr()
                    frmCUSOfferSpecialConstr.Text = "Έντυπο Παραγγελίας Πελατών(Έπιπλο Μπάνιου)"
                    frmCUSOfferSpecialConstr.ID = oID
                    ' frmCUSOfferSpecialConstr.MdiParent = frmMain
                    frmCUSOfferSpecialConstr.IsOrder = True
                    frmCUSOfferSpecialConstr.Mode = FormMode.EditRecord
                    frmCUSOfferSpecialConstr.ShowDialog()

            End Select
        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
            sdr.Close()
        End Try

    End Sub

    Public Sub PrintAgreement()


        If Frm.cboCompProject.EditValue IsNot Nothing Then
            Dim reportComp As New RepCUSPrivateAgreement()
            reportComp.XrLabel23.ExpressionBindings.Item(0).Expression = "'Της Εταιρίας ' + [COMPName] + ' η οποία εδρεύει ' + [CompAdrName] + ' με ΑΦΜ ' + [CompAFM] + ' ΔΟΥ ' + [COMPDoyName] "
            reportComp.XrLabel1.ExpressionBindings.Item(0).Expression = "'νόμιμα εκπροσωπούμενης για την υπογραφή του παρόντος από το νόμιμο εκπρόσωπο της'"
            reportComp.XrLabel5.Visible = True
            reportComp.XrLabel5.ExpressionBindings.Item(0).Expression = "[LegalRepresentative] + ' ,  που θα καλείται στο εξής <b><ΑΓΟΡΑΣΤΗΣ></b> συμφωνούνται τα εξής :'"

            reportComp.Parameters.Item(0).Value = ID
            reportComp.CreateDocument()

            Dim reportComp2 As New RepCUSPrivateAgreement2ndPage
            reportComp2.Parameters.Item(0).Value = ID
            'reportComp2.XrLabel2.ExpressionBindings.Item(0).Expression = "FormatString('{0:C2}',[DebitAmt]) "
            reportComp2.CreateDocument()
            reportComp.ModifyDocument(Sub(x)
                                          x.AddPages(reportComp2.Pages)
                                      End Sub)
            Dim reportComp3 As New RepCUSPrivateAgreement3ndPage
            reportComp3.CreateDocument()
            reportComp.ModifyDocument(Sub(x)
                                          x.AddPages(reportComp3.Pages)
                                      End Sub)
            Dim reportComp4 As New RepCUSPrivateAgreement4ndPage
            reportComp4.CreateDocument()
            reportComp.ModifyDocument(Sub(x)
                                          x.AddPages(reportComp4.Pages)
                                      End Sub)
            Dim reportComp5 As New RepCUSAnalysis
            reportComp5.Parameters.Item(0).Value = Frm.cboTRANSH.EditValue.ToString
            reportComp5.CreateDocument()
            reportComp.ModifyDocument(Sub(x)
                                          x.AddPages(reportComp5.Pages)
                                      End Sub)
            Dim printToolComp As New ReportPrintTool(reportComp)
            printToolComp.ShowRibbonPreview()
        Else
            Dim report As New RepCUSPrivateAgreement()

            report.XrLabel5.Visible = True
            report.XrLabel5.ExpressionBindings.Item(0).Expression = "' συμφωνούνται τα εξής :'"
            report.Parameters.Item(0).Value = ID
            report.CreateDocument()

            Dim report2 As New RepCUSPrivateAgreement2ndPage
            report2.Parameters.Item(0).Value = ID
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
            Dim report5 As New RepCUSAnalysis
            report5.Parameters.Item(0).Value = Frm.cboTRANSH.EditValue.ToString
            report5.CreateDocument()
            report.ModifyDocument(Sub(x)
                                      x.AddPages(report5.Pages)
                                  End Sub)
            Dim printTool As New ReportPrintTool(report)
            printTool.ShowRibbonPreview()
        End If


    End Sub

End Class
