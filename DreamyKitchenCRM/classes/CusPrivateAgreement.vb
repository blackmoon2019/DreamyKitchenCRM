Imports System.Data.SqlClient
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
    Public Company As Guid
    Public CompProject As Guid
    Public CUS As Guid
    Public TRANSH As Guid
    Public EMP As Guid

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
        Frm.cboCompany.EditValue = System.Guid.Parse(Company.ToString)
        If Company <> Guid.Empty Then FillCompanyProjects()
        Frm.cboCompProject.EditValue = System.Guid.Parse(CompProject.ToString)
        Frm.cboCUS.EditValue = System.Guid.Parse(CUS.ToString)
        If CUS <> Guid.Empty Then FillCusTransh()
        Frm.cboTRANSH.EditValue = System.Guid.Parse(TRANSH.ToString)
        Frm.cboEMP.EditValue = System.Guid.Parse(EMP.ToString)
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
        If Company = Guid.Empty Then FillCompanyProjects()
        If CUS = Guid.Empty Then FillCusTransh()
        GetKLeisimoAmt(Frm.cboTRANSH.EditValue.ToString)
        GetPayInAdvanceAmt(Frm.cboTRANSH.EditValue.ToString)
        GetProjectAmounts(Frm.cboTRANSH.EditValue.ToString)
        FillArProt()


        If Frm.cboCompProject.EditValue IsNot Nothing Then
            Frm.LLegalRepresentative.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
            Frm.LLegalRepresentative.Tag = "1"
        Else
            Frm.LLegalRepresentative.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        End If
        Frm.cboInvoiceType.EditValue = Frm.cboTRANSH.GetColumnValue("invType")
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

    Private Sub FillCusTransh()
        Dim sCusID As String, scompTrashID As String
        If CUS = Guid.Empty Then sCusID = toSQLValueS(Guid.Empty.ToString) Else sCusID = toSQLValueS(CUS.ToString)
        If CompProject = Guid.Empty Then scompTrashID = toSQLValueS(Guid.Empty.ToString) Else scompTrashID = toSQLValueS(CompProject.ToString)

        If CompProject = Guid.Empty Then scompTrashID = " and T.compTrashID  IS NULL" Else scompTrashID = " and T.compTrashID   = " & toSQLValueS(CompProject.ToString)
        Dim sSQL As New System.Text.StringBuilder
        sSQL.AppendLine("Select T.id,FullTranshDescription,Description,Iskitchen,Iscloset,Isdoor,Issc,AgreementExist,AgreementID,t.invType,ArProtKitchen,ArProtCloset,ArProtDoor,ArProtSpecialContr
                        from vw_TRANSH t
                        INNER JOIN TRANSC on transc.transhID = t.id 
                        where   completed = 0  and T.cusid = " & sCusID & scompTrashID & " order by description")
        FillCbo.TRANSH(Frm.cboTRANSH, sSQL)
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
                        where  T.cusid = " & sCompID & "order by description")
        FillCbo.TRANSH(Frm.cboCompProject, sSQL)
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
                CheckForValidPayinAdvnace()
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

            sSQL.AppendLine("update TRANSH SET waitingForAgreement=1,invType = " & toSQLValueS(Frm.cboInvoiceType.EditValue.ToString) & ",  vatamt = " & toSQLValueS(Frm.txtPartofVat.EditValue.ToString, True) & ", " &
                            " amt = " & toSQLValueS(Frm.txtPosoParastatikou.EditValue.ToString, True) & ",debitcost = " & toSQLValueS(PolisiErgou.ToString, True) & ", " &
                            " DevicesCost = " & toSQLValueS(Frm.txtDevices.EditValue.ToString) & ",  totamt = " & toSQLValueS(Frm.txtGenTot.EditValue.ToString, True) & " where ID = " & toSQLValueS(Frm.cboTRANSH.EditValue.ToString))
            'Εκτέλεση QUERY
            Using oCmd As New SqlCommand(sSQL.ToString, CNDB)
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
    Private Sub CheckForValidPayinAdvnace()
        Dim TotalPayinAdvance As Double, PayinAdvance As Double, closeAmt As Double, CheckPayInAdvance As Double
        TotalPayinAdvance = 0
        TotalPayinAdvance = DbnullToZero(Frm.txtPayinAdvanceCash)
        TotalPayinAdvance = TotalPayinAdvance + DbnullToZero(Frm.txtPayinAdvanceBank)
        PayinAdvance = DbnullToZero(Frm.txtPayinAdvanceTot)
        closeAmt = DbnullToZero(Frm.txtCloseBank)
        closeAmt = closeAmt + DbnullToZero(Frm.txtCloseCash)
        TotalPayinAdvance = TotalPayinAdvance + closeAmt
        ' Αυτό που πρέπει να δίνει ο πελάτης με το συμφωνητικό είναι ως προκαταβολή το 50% του έργου
        CheckPayInAdvance = DbnullToZero(Frm.txtGenTot) : CheckPayInAdvance = CheckPayInAdvance / 2
        If Math.Round(TotalPayinAdvance, 2) < Math.Round(CheckPayInAdvance, 2) Then
            XtraMessageBox.Show("Η προκαταβολή που έχει εισπραχθεί είναι μικρότερη του 50% του έργου", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
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
            End If
            sdr.Close()
        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Public Sub GetPayInAdvanceAmt(ByVal TransHID As String)
        Dim cmd As SqlCommand
        Dim sdr As SqlDataReader
        Dim TotalPayInAdvance As Double
        Try
            cmd = New SqlCommand("SELECT cash, isnull(sum(amt),0) as amt FROM TRANSD WHERE cash in(0,1) and paytypeID='27CF38F4-BD30-403C-8BC6-2D2A57501DEB'  and transhID = " & toSQLValueS(TransHID) & " Group By Cash ", CNDB)
            sdr = cmd.ExecuteReader()
            If sdr.HasRows Then
                While sdr.Read()
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
            cmd = New SqlCommand(" select   TotPartOfVat,TotalVat,TotalPrice,TotalEquipmentPrice,GENTOT,ExtraInst, ExtraTransp,
                                            TotKitchen,TotDoor,HasCloset,HasKitchen,HasSpecial,HasDoors
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
