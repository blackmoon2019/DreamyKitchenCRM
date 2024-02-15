Imports System.Data.SqlClient
Imports System.Text
Imports DevExpress.Utils
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
        Dim sSQL As New System.Text.StringBuilder
        FillCbo.ADR(Frm.cboADR, sSQL)

    End Sub
    Public Sub LoadForm()


        Select Case Mode
            Case FormMode.NewRecord
                Frm.txtCode.Text = DBQ.GetNextId("AGREEMENT")
                'Frm.cboEMP.EditValue = System.Guid.Parse(UserProps.ID.ToString.ToUpper)
                Frm.dtpresentation.EditValue = Date.Now
                ChangeVal = True : Frm.lblMsg.Text = "Το Συμφωνητικό δεν έχει αποθηκευτεί"
                Frm.LayoutControlItem16.Visibility = Utils.LayoutVisibility.Always
            Case FormMode.EditRecord
                LoadForms.LoadForm(Frm.LayoutControl1, "Select * from AGREEMENT where id = " & toSQLValueS(ID))
                ChangeVal = False
                Frm.cmdPrintOffer.Enabled = True
        End Select
        GetKLeisimoAmt(Frm.cboTRANSH.EditValue.ToString)
        GetPayInAdvanceAmt(Frm.cboTRANSH.EditValue.ToString)
        GetProjectAmounts(Frm.cboTRANSH.EditValue.ToString)
        FillArProt()

        Frm.cboInvoiceType.EditValue = Frm.cboTRANSH.GetColumnValue("invType")
        If Frm.cboCompProject.EditValue IsNot Nothing Then
            Frm.LLegalRepresentative.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
            Frm.LLegalRepresentative.Tag = "1"
        Else
            Frm.LLegalRepresentative.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        End If
        Frm.cmdCompCollection.Enabled = IIf(Frm.cboCompany.EditValue = Nothing, False, True)
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
    Private Sub FillArProt()
        Dim sArProt As New StringBuilder
        sArProt.Append(Frm.cboTRANSH.GetColumnValue("ArProtKitchen") & " ")
        sArProt.Append(Frm.cboTRANSH.GetColumnValue("ArProtCloset") & " ")
        sArProt.Append(Frm.cboTRANSH.GetColumnValue("ArProtDoor") & " ")
        sArProt.Append(Frm.cboTRANSH.GetColumnValue("ArProtSpecialContr") & " ")
        Frm.txtArProt.EditValue = sArProt
    End Sub
    Public Sub SaveRecord(ByRef sID As String)
        Dim sResult As Boolean
        Dim sGuid As String
        Dim TotalPrice As Double, PayinAdvance As Double, closeAmt As Double
        Try
            If Valid.ValidateForm(Frm.LayoutControl1) Then
                If Frm.txtPayinAdvance.EditValue = "0,00" Then
                    XtraMessageBox.Show("Δεν έχετε συμπληρώσει στην προκαταβολη (Μετρητά,Τράπεζα ή και τα 2).", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
                TotalPrice = 0
                TotalPrice = DbnullToZero(Frm.txtPayinAdvanceCash)
                TotalPrice = TotalPrice + DbnullToZero(Frm.txtPayinAdvanceBank)
                PayinAdvance = DbnullToZero(Frm.txtPayinAdvance)
                closeAmt = DbnullToZero(Frm.txtClose)
                closeAmt = closeAmt + DbnullToZero(Frm.txtCloseCash)
                TotalPrice = TotalPrice + closeAmt
                If Math.Round(TotalPrice, 2) <> Math.Round(PayinAdvance, 2) Then
                    XtraMessageBox.Show("Το σύνολο της προκαταβολής δεν είναι ίσο με τις επιμέρους", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
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
                    Dim sSQL As New System.Text.StringBuilder
                    TotalPrice = Frm.txtGenTot.EditValue
                    Dim PolisiErgou As Double = TotalPrice - Frm.txtDevices.EditValue
                    TotalPrice = TotalPrice + Frm.txtDevices.EditValue

                    sSQL.AppendLine("update TRANSH SET waitingForAgreement=1,invType = " & toSQLValueS(Frm.cboInvoiceType.EditValue.ToString) & ",  vatamt = " & toSQLValueS(Frm.txtPartofVat.EditValue.ToString, True) & ", " &
                                    " amt = " & toSQLValueS(Frm.txtPosoParastatikou.EditValue.ToString, True) & ",debitcost = " & toSQLValueS(PolisiErgou.ToString, True) & ", " &
                                    " DevicesCost = " & toSQLValueS(Frm.txtDevices.EditValue.ToString) & ",  totamt = " & toSQLValueS(Frm.txtGenTot.EditValue.ToString, True) & " where ID = " & toSQLValueS(Frm.cboTRANSH.EditValue.ToString))
                    'Εκτέλεση QUERY
                    Using oCmd As New SqlCommand(sSQL.ToString, CNDB)
                        oCmd.ExecuteNonQuery()
                    End Using
                    sSQL.Clear()
                    ' Διαγραφή όλων των κινήσεων που αφοόύν το συγκεκριμένο συμφωνητικό
                    sSQL.AppendLine("DELETE FROM TRANSD WHERE agreementID = " & toSQLValueS(sID))
                    Using oCmd As New SqlCommand(sSQL.ToString, CNDB)
                        oCmd.ExecuteNonQuery()
                    End Using
                    sSQL.Clear()
                    TotalPrice = Frm.txtPayinAdvanceCash.EditValue

                    XtraMessageBox.Show("Η εγγραφή αποθηκέυτηκε με επιτυχία", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Frm.cmdPrintOffer.Enabled = True
                    Dim cmd As SqlCommand
                    Dim sdr As SqlDataReader
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
                    Mode = FormMode.EditRecord
                End If
            End If

        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Public Sub GetKLeisimoAmt(ByVal TransHID As String)
        Dim cmd As SqlCommand
        Dim sdr As SqlDataReader
        Try
            cmd = New SqlCommand("SELECT cash, isnull(sum(amt),0) as amt FROM TRANSD WHERE cash in(0,1) and paytypeID='90A295A1-D2A0-40B7-B260-A532B2C322AC'  and transhID = " & toSQLValueS(TransHID) & " Group By Cash ", CNDB)
            sdr = cmd.ExecuteReader()
            If sdr.HasRows Then
                While sdr.Read()
                    If sdr.GetBoolean(sdr.GetOrdinal("cash")) = "0" Then
                        If sdr.IsDBNull(sdr.GetOrdinal("amt")) = False Then
                            Frm.txtClose.EditValue = sdr.GetDecimal(sdr.GetOrdinal("amt"))
                        Else
                            Frm.txtClose.EditValue = Nothing
                        End If
                    Else
                        If sdr.IsDBNull(sdr.GetOrdinal("amt")) = False Then
                            Frm.txtCloseCash.EditValue = sdr.GetDecimal(sdr.GetOrdinal("amt"))
                        Else
                            Frm.txtCloseCash.EditValue = Nothing
                        End If
                    End If
                End While
            End If
            sdr.Close()
        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Public Sub GetPayInAdvanceAmt(ByVal TransHID As String)
        Dim cmd As SqlCommand
        Dim sdr As SqlDataReader
        Try
            cmd = New SqlCommand("SELECT cash, isnull(sum(amt),0) as amt FROM TRANSD WHERE cash in(0,1) and paytypeID='27CF38F4-BD30-403C-8BC6-2D2A57501DEB'  and transhID = " & toSQLValueS(TransHID) & " Group By Cash ", CNDB)
            sdr = cmd.ExecuteReader()
            If sdr.HasRows Then
                While sdr.Read()
                    If sdr.GetBoolean(sdr.GetOrdinal("cash")) = "0" Then
                        If sdr.IsDBNull(sdr.GetOrdinal("amt")) = False Then
                            Frm.txtPayinAdvanceBank.EditValue = sdr.GetDecimal(sdr.GetOrdinal("amt"))
                        Else
                            Frm.txtPayinAdvanceBank.EditValue = Nothing
                        End If
                    Else
                        If sdr.IsDBNull(sdr.GetOrdinal("amt")) = False Then
                            Frm.txtPayinAdvanceCash.EditValue = sdr.GetDecimal(sdr.GetOrdinal("amt"))
                        Else
                            Frm.txtPayinAdvanceCash.EditValue = Nothing
                        End If
                    End If
                End While
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
            cmd = New SqlCommand(" select   TotPartOfVat,TotalVat,TotalPrice,TotalEquipmentPrice,GENTOT,ExtraInst, ExtraTransp,
                                            TotKitchen,TotDoor,HasCloset,HasKitchen,HasSpecial,HasDoors
                                    FROM vw_ANALYSH_KOSTOYS WHERE ID = " & toSQLValueS(TransHID), CNDB)
            sdr = cmd.ExecuteReader()
            If (sdr.Read() = True) Then
                If sdr.IsDBNull(sdr.GetOrdinal("TotPartOfVat")) = False Then Frm.txtPartofVat.EditValue = sdr.GetDecimal(sdr.GetOrdinal("TotPartOfVat")) Else Frm.txtPartofVat.EditValue = Nothing
                If sdr.IsDBNull(sdr.GetOrdinal("TotalVat")) = False Then Frm.TxtTotalVat.EditValue = sdr.GetDecimal(sdr.GetOrdinal("TotalVat")) Else Frm.TxtTotalVat.EditValue = Nothing
                If sdr.IsDBNull(sdr.GetOrdinal("TotalPrice")) = False Then Frm.txtTotalVatPrice.EditValue = sdr.GetDecimal(sdr.GetOrdinal("TotalPrice")) Else Frm.txtTotalVatPrice.EditValue = Nothing
                If sdr.IsDBNull(sdr.GetOrdinal("GENTOT")) = False Then Frm.txtGenTot.EditValue = sdr.GetDecimal(sdr.GetOrdinal("GENTOT")) Else Frm.txtGenTot.EditValue = Nothing
                If sdr.IsDBNull(sdr.GetOrdinal("ExtraInst")) = False Then Frm.txtExtraInst.EditValue = sdr.GetDecimal(sdr.GetOrdinal("ExtraInst")) Else Frm.txtExtraInst.EditValue = Nothing
                If sdr.IsDBNull(sdr.GetOrdinal("ExtraTransp")) = False Then Frm.txtExtraTransp.EditValue = sdr.GetDecimal(sdr.GetOrdinal("ExtraTransp")) Else Frm.txtExtraTransp.EditValue = Nothing
                Frm.chkHasKitchen.Checked = sdr.GetBoolean(sdr.GetOrdinal("HasKitchen"))
                Frm.chkHasCloset.Checked = sdr.GetBoolean(sdr.GetOrdinal("HasCloset"))
                Frm.chkHasDoors.Checked = sdr.GetBoolean(sdr.GetOrdinal("HasDoors"))
                Frm.chkHasSC.Checked = sdr.GetBoolean(sdr.GetOrdinal("HasSpecial"))
                If sdr.IsDBNull(sdr.GetOrdinal("TotalEquipmentPrice")) = False Then
                    Dim TotalEquipmentPrice As Double, PosoParastatikou As Double
                    TotalEquipmentPrice = sdr.GetDecimal(sdr.GetOrdinal("TotalEquipmentPrice"))
                    PosoParastatikou = DbnullToZero(Frm.txtPosoParastatikou)
                    Frm.txtPosoParastatikou.EditValue = PosoParastatikou + TotalEquipmentPrice
                    Frm.txtDevices.EditValue = TotalEquipmentPrice
                End If
            End If
            sdr.Close()
        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Public Sub PrintAgreement()
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

        If Frm.cboCompProject.EditValue IsNot Nothing Then
            Dim reportComp As New RepCUSPrivateAgreement()
            reportComp.XrLabel23.ExpressionBindings.Item(0).Expression = "'Της Εταιρίας ' + [COMPName] + ' η οποία εδρεύει ' + [CompAdrName] + ' με ΑΦΜ ' + [CompAFM] + ' ΔΟΥ ' + [COMPDoyName] "
            reportComp.XrLabel1.ExpressionBindings.Item(0).Expression = "'νόμιμα εκπροσωπούμενης για την υπογραφή του παρόντος από το νόμιμο εκπρόσωπο της'"
            reportComp.XrLabel5.Visible = True
            reportComp.XrLabel5.ExpressionBindings.Item(0).Expression = "[COMPName] + ' ,  που θα καλείται στο εξής <b><ΑΓΟΡΑΣΤΗΣ></b> συμφωνούνται τα εξής :'"

            reportComp.Parameters.Item(0).Value = ID
            reportComp.CreateDocument()

            Dim reportComp2 As New RepCUSPrivateAgreement2ndPage
            reportComp2.Parameters.Item(0).Value = ID
            reportComp2.XrLabel2.ExpressionBindings.Item(0).Expression = "FormatString('{0:C2}',[DebitAmt]) "
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

        End If


    End Sub

End Class
