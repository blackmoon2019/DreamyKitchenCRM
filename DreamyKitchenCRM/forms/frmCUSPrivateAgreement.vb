Imports System.Data.SqlClient
Imports DevExpress.Utils
Imports DevExpress.Utils.Menu
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraGrid.Menu
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraReports.UI
Public Event HyperlinkClick As HyperlinkClickEventHandler
Public Class frmCUSPrivateAgreement

    Private sID As String
    Private Ctrl As DevExpress.XtraGrid.Views.Grid.GridView
    Private Frm As DevExpress.XtraEditors.XtraForm
    Public Mode As Byte
    Private ChangeVal As Boolean = False
    Private Valid As New ValidateControls
    Private FScrollerExist As Boolean = False
    Private Log As New Transactions
    Private FillCbo As New FillCombos
    Private DBQ As New DBQueries
    Private LoadForms As New FormLoader
    Private Cls As New ClearControls
    Private CtrlCombo As DevExpress.XtraEditors.LookUpEdit
    Private CalledFromCtrl As Boolean
    Private WorkingTime As Integer
    Private AgreementSalary As Double
    Private UserPermissions As New CheckPermissions
    Private Prog_Prop As New ProgProp

    Public WriteOnly Property ID As String
        Set(value As String)
            sID = value
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
    Private Sub cmdExit_Click(sender As Object, e As EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub
    Private Sub frmPrivateAgreement_Load(sender As Object, e As EventArgs) Handles Me.Load
        'TODO: This line of code loads data into the 'DreamyKitchenDataSet.vw_INVTYPES' table. You can move, or remove it, as needed.
        Me.Vw_INVTYPESTableAdapter.Fill(Me.DreamyKitchenDataSet.vw_INVTYPES)
        'TODO: This line of code loads data into the 'DreamyKitchenDataSet.vw_BANKS' table. You can move, or remove it, as needed.
        Me.Vw_BANKSTableAdapter.Fill(Me.DreamyKitchenDataSet.vw_BANKS)
        'TODO: This line of code loads data into the 'DreamyKitchenDataSet.vw_CCT' table. You can move, or remove it, as needed.
        Me.Vw_CCTTableAdapter.Fill(Me.DreamyKitchenDataSet.vw_CCT)
        'TODO: This line of code loads data into the 'DreamyKitchenDataSet.vw_SALERS' table. You can move, or remove it, as needed.
        Me.Vw_SALERSTableAdapter.Fill(Me.DreamyKitchenDataSet.vw_SALERS)
        Dim sSQL As New System.Text.StringBuilder
        FillCbo.ADR(cboADR, sSQL)


        Select Case Mode
            Case FormMode.NewRecord
                txtCode.Text = DBQ.GetNextId("AGREEMENT")
                cboEMP.EditValue = System.Guid.Parse(UserProps.ID.ToString.ToUpper)
                ChangeVal = True
            Case FormMode.EditRecord
                LoadForms.LoadForm(LayoutControl1, "Select * from AGREEMENT where id = " & toSQLValueS(sID))
                ChangeVal = False
                cmdPrintOffer.Enabled = True
        End Select
        Me.CenterToScreen()
        cmdSave.Enabled = IIf(Mode = FormMode.NewRecord, UserProps.AllowInsert, UserProps.AllowEdit)

        chkHasCloset.Properties.AllowHtmlDraw = DefaultBoolean.True
        chkHasCloset.Text = "<href=www.dreamykitchen.gr/>Ντουλάπες Υπνοδωματίου</href>"
        chkHasDoors.Properties.AllowHtmlDraw = DefaultBoolean.True
        chkHasDoors.Text = "<href=www.dreamykitchen.gr/>Πόρτες Εσωτερικές</href>"
        chkHasKitchen.Properties.AllowHtmlDraw = DefaultBoolean.True
        chkHasKitchen.Text = "<href=www.dreamykitchen.gr/>Ερμάρια Κουζίνας</href>"
        chkHasSC.Properties.AllowHtmlDraw = DefaultBoolean.True
        chkHasSC.Text = "<href=www.dreamykitchen.gr/>Ειδικές Κατασκευές</href>"

    End Sub

    Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click
        Dim sResult As Boolean
        Dim sGuid As String
        Dim TotalPrice As Double, PayinAdvance As Double, closeAmt As Double
        Try
            If Valid.ValidateForm(LayoutControl1) Then
                If txtPayinAdvance.EditValue = "0,00" Then
                    XtraMessageBox.Show("Δεν έχετε συμπληρώσει στην προκαταβολη (Μετρητά,Τράπεζα ή και τα 2).", "Dreamy Kitchen CRM", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
                TotalPrice = 0
                TotalPrice = DbnullToZero(txtPayinAdvanceCash)
                TotalPrice = TotalPrice + DbnullToZero(txtPayinAdvanceBank)
                PayinAdvance = DbnullToZero(txtPayinAdvance)
                closeAmt = DbnullToZero(txtClose)
                closeAmt = closeAmt + DbnullToZero(txtCloseCash)
                TotalPrice = TotalPrice + closeAmt
                If Math.Round(TotalPrice, 2) <> Math.Round(PayinAdvance, 2) Then
                    XtraMessageBox.Show("Το σύνολο της προκαταβολής δεν είναι ίσο με τις επιμέρους", "Dreamy Kitchen CRM", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
                PayinAdvance = txtPayinAdvanceBank.EditValue
                If PayinAdvance <> "0" And cboBANK.EditValue = Nothing Then
                    XtraMessageBox.Show("Έχετε συμπληρώσει προκαταβολή(Τράπεζα) χωρίς να βάλετε τράπεζα", "Dreamy Kitchen CRM", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
                Select Case Mode
                    Case FormMode.NewRecord
                        sGuid = System.Guid.NewGuid.ToString
                        sResult = DBQ.InsertNewData(DBQueries.InsertMode.OneLayoutControl, "AGREEMENT", LayoutControl1,,, sGuid, True)
                        sID = sGuid
                    Case FormMode.EditRecord
                        sResult = DBQ.UpdateNewData(DBQueries.InsertMode.OneLayoutControl, "AGREEMENT", LayoutControl1,,, sID, True)
                        'sGuid = sID
                End Select

                If FScrollerExist = True Then
                    Dim form As frmScroller = Frm
                    form.LoadRecords("vw_AGREEMENT")
                End If

                If sResult = True Then
                    Dim sSQL As New System.Text.StringBuilder
                    TotalPrice = txtGenTot.EditValue
                    Dim PolisiErgou As Double = TotalPrice - txtDevices.EditValue
                    TotalPrice = TotalPrice + txtDevices.EditValue

                    sSQL.AppendLine("update TRANSH SET invType = " & toSQLValueS(cboInvoiceType.EditValue.ToString) & ",  vatamt = " & toSQLValueS(txtPartofVat.EditValue.ToString, True) & ", " &
                                    " amt = " & toSQLValueS(txtPosoParastatikou.EditValue.ToString, True) & ",debitcost = " & toSQLValueS(PolisiErgou.ToString, True) & ", " &
                                    " DevicesCost = " & toSQLValueS(txtDevices.EditValue.ToString) & ",  totamt = " & toSQLValueS(txtGenTot.EditValue.ToString, True) & " where ID = " & toSQLValueS(cboTRANSH.EditValue.ToString))
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
                    TotalPrice = txtPayinAdvanceCash.EditValue
                    If TotalPrice <> "0" Then
                        sSQL.AppendLine("INSERT INTO TRANSD (TRANSHID,CASH,AMT,DTPAY,PAYTYPE,agreementID) ")
                        sSQL.AppendLine("Select " & toSQLValueS(cboTRANSH.EditValue.ToString) & ",")
                        sSQL.AppendLine("1" & ",")
                        sSQL.AppendLine(toSQLValueS(txtPayinAdvanceCash.EditValue.ToString, True) & ",")
                        sSQL.AppendLine(toSQLValueS(CDate(dtpresentation.Text).ToString("yyyyMMdd")) & ",")
                        sSQL.Append("0,")
                        sSQL.AppendLine(toSQLValueS(sID))
                        'Εκτέλεση QUERY
                        Using oCmd As New SqlCommand(sSQL.ToString, CNDB)
                            oCmd.ExecuteNonQuery()
                        End Using
                    End If
                    sSQL.Clear()
                    TotalPrice = txtPayinAdvanceBank.EditValue
                    If TotalPrice <> "0" Then
                        sSQL.AppendLine("INSERT INTO TRANSD (TRANSHID,CASH,BANKID,AMT,DTPAY,PAYTYPE,agreementID) ")
                        sSQL.AppendLine("Select " & toSQLValueS(cboTRANSH.EditValue.ToString) & ",")
                        sSQL.AppendLine("0" & ",")
                        sSQL.AppendLine(toSQLValueS(cboBANK.EditValue.ToString) & ",")
                        sSQL.AppendLine(toSQLValueS(txtPayinAdvanceBank.EditValue.ToString, True) & ",")
                        sSQL.AppendLine(toSQLValueS(CDate(dtpresentation.Text).ToString("yyyyMMdd")) & ",")
                        sSQL.Append("0,")
                        sSQL.AppendLine(toSQLValueS(sID))
                        'Εκτέλεση QUERY
                        Using oCmd As New SqlCommand(sSQL.ToString, CNDB)
                            oCmd.ExecuteNonQuery()
                        End Using
                    End If
                    XtraMessageBox.Show("Η εγγραφή αποθηκέυτηκε με επιτυχία", "Dreamy Kitchen CRM", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    cmdPrintOffer.Enabled = True
                    Dim cmd As SqlCommand
                    Dim sdr As SqlDataReader
                    Dim ExistNegative As Integer = 0
                    cmd = New SqlCommand("  select  count(id) as ExistNegative  
	                                        from vw_ANALYSH_KOSTOYS 
	                                        where (KLEISIMO_CASH<0 or ΕΝΑΝΤΙ_CASH<0 OR [EXOFLISI_CASH]<0 OR KLEISIMO_BANK<0 OR [ΕΝΑΝΤΙ_BANK]<0
	                                        OR EXOFLISI_BANK<0)  and ID = " & toSQLValueS(cboTRANSH.EditValue.ToString), CNDB)
                    sdr = cmd.ExecuteReader()
                    If (sdr.Read() = True) Then
                        If sdr.IsDBNull(sdr.GetOrdinal("ExistNegative")) = False Then ExistNegative = sdr.GetInt32(sdr.GetOrdinal("ExistNegative"))
                    End If
                    sdr.Close()
                    If ExistNegative > 0 Then
                        XtraMessageBox.Show("Λανθασμένη κατανομή ποσών στον τρόπο πληρωμής", "Dreamy Kitchen CRM", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Dim report As New RepCUSAnalysis
                        report.Parameters.Item(0).Value = cboTRANSH.EditValue.ToString
                        report.CreateDocument()

                        Dim printTool As New ReportPrintTool(report)
                        printTool.ShowRibbonPreview()

                    End If
                    Mode = FormMode.EditRecord
                End If
            End If

        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), "Dreamy Kitchen CRM", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub frmPrivateAgreement_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        If Me.WindowState = FormWindowState.Maximized Then frmMain.XtraTabbedMdiManager1.Dock(Me, frmMain.XtraTabbedMdiManager1)
    End Sub
    Private Sub cboCUS_EditValueChanged(sender As Object, e As EventArgs) Handles cboCUS.EditValueChanged
        txtFatherName.EditValue = cboCUS.GetColumnValue("FatherName")
        txtArea.EditValue = cboCUS.GetColumnValue("AREAS_Name")
        txtDOY.EditValue = cboCUS.GetColumnValue("DOY_Name")
        txtAFM.EditValue = cboCUS.GetColumnValue("afm")
        cboADR.EditValue = cboCUS.GetColumnValue("AdrID")

        Dim sCusID As String
        If cboCUS.EditValue Is Nothing Then sCusID = toSQLValueS(Guid.Empty.ToString) Else sCusID = toSQLValueS(cboCUS.EditValue.ToString)
        Dim sSQL As New System.Text.StringBuilder
        sSQL.AppendLine("Select T.id,FullTranshDescription,Description,ArProtKitchen,ArProtCloset,ArProtDoor,ArProtSpecialContr
                        from vw_TRANSH t
                        where  completed = 0 and T.cusid = " & sCusID & "order by description")
        FillCbo.TRANSH(cboTRANSH, sSQL)
    End Sub
    Private Sub cboEMP_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboEMP.ButtonClick
        Select Case e.Button.Index
            Case 1 : If UserProps.ID.ToString.ToUpper = "3F9DC32E-BE5B-4D46-A13C-EA606566CF32" Or UserProps.ID.ToString.ToUpper = "E9CEFD11-47C0-4796-A46B-BC41C4C3606B" Then  cboEMP.EditValue = Nothing : ManageEMP()
            Case 2 : If UserProps.ID.ToString.ToUpper = "3F9DC32E-BE5B-4D46-A13C-EA606566CF32" Or UserProps.ID.ToString.ToUpper = "E9CEFD11-47C0-4796-A46B-BC41C4C3606B" Then  If cboEMP.EditValue <> Nothing Then ManageEMP()
            Case 3 : cboEMP.EditValue = Nothing
        End Select
    End Sub
    Private Sub cboCUS_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboCUS.ButtonClick
        Select Case e.Button.Index
            Case 1 : cboCUS.EditValue = Nothing : ManageCus()
            Case 2 : If cboCUS.EditValue <> Nothing Then ManageCus()
            Case 3 : cboCUS.EditValue = Nothing
        End Select
    End Sub
    Private Sub cboTRANSH_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboTRANSH.ButtonClick
        Select Case e.Button.Index
            Case 1 : If UserProps.ID.ToString.ToUpper = "3F9DC32E-BE5B-4D46-A13C-EA606566CF32" Or UserProps.ID.ToString.ToUpper = "E9CEFD11-47C0-4796-A46B-BC41C4C3606B" Then  cboTRANSH.EditValue = Nothing : ManageTRANSH()
            Case 2 : If UserProps.ID.ToString.ToUpper = "3F9DC32E-BE5B-4D46-A13C-EA606566CF32" Or UserProps.ID.ToString.ToUpper = "E9CEFD11-47C0-4796-A46B-BC41C4C3606B" Then  If cboTRANSH.EditValue <> Nothing Then ManageTRANSH()
            Case 3 : cboTRANSH.EditValue = Nothing
        End Select
    End Sub
    Private Sub ManageTRANSH()
        Dim form1 As frmTransactions = New frmTransactions()
        form1.Text = "Χρεωπιστώσεις Πελατών"
        form1.CallerControl = cboTRANSH
        form1.CalledFromControl = True
        form1.MdiParent = frmMain
        If cboTRANSH.EditValue <> Nothing Then
            form1.ID = cboTRANSH.EditValue.ToString
            form1.Mode = FormMode.EditRecord
        Else
            form1.Mode = FormMode.NewRecord
        End If
        frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(form1), New Point(CInt(form1.Parent.ClientRectangle.Width / 2 - form1.Width / 2), CInt(form1.Parent.ClientRectangle.Height / 2 - form1.Height / 2)))
        form1.Show()
    End Sub
    Private Sub ManageEMP()
        Dim form1 As frmEMP = New frmEMP()
        form1.Text = "Προσωπικό"
        form1.CallerControl = cboEMP
        form1.CalledFromControl = True
        form1.MdiParent = frmMain
        If cboEMP.EditValue <> Nothing Then
            form1.ID = cboEMP.EditValue.ToString
            form1.Mode = FormMode.EditRecord
        Else
            form1.Mode = FormMode.NewRecord
        End If
        frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(form1), New Point(CInt(form1.Parent.ClientRectangle.Width / 2 - form1.Width / 2), CInt(form1.Parent.ClientRectangle.Height / 2 - form1.Height / 2)))
        form1.Show()
    End Sub
    Private Sub ManageCus()
        Dim form1 As frmCustomers = New frmCustomers()
        form1.Text = "Πελάτες"
        form1.CallerControl = cboCUS
        form1.CalledFromControl = True
        'form1.MdiParent = frmMain
        If cboCUS.EditValue <> Nothing Then
            form1.ID = cboCUS.EditValue.ToString
            form1.Mode = FormMode.EditRecord
        Else
            form1.Mode = FormMode.NewRecord
        End If
        'frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(form1), New Point(CInt(form1.Parent.ClientRectangle.Width / 2 - form1.Width / 2), CInt(form1.Parent.ClientRectangle.Height / 2 - form1.Height / 2)))
        form1.ShowDialog()
        Dim cmd As SqlCommand
        Dim sdr As SqlDataReader
        If cboCUS.EditValue <> Nothing Then
            cmd = New SqlCommand("SELECT AdrID,FatherName,AREAS_Name,DOY_Name,afm FROM VW_CCT WHERE ID = " & toSQLValueS(cboCUS.EditValue.ToString), CNDB)
            sdr = cmd.ExecuteReader()
            If (sdr.Read() = True) Then
                If sdr.IsDBNull(sdr.GetOrdinal("FatherName")) = False Then txtFatherName.EditValue = sdr.GetString(sdr.GetOrdinal("FatherName")) Else txtFatherName.EditValue = Nothing
                If sdr.IsDBNull(sdr.GetOrdinal("AREAS_Name")) = False Then txtArea.EditValue = sdr.GetString(sdr.GetOrdinal("AREAS_Name")) Else txtArea.EditValue = Nothing
                If sdr.IsDBNull(sdr.GetOrdinal("DOY_Name")) = False Then txtDOY.EditValue = sdr.GetString(sdr.GetOrdinal("DOY_Name")) Else txtDOY.EditValue = Nothing
                If sdr.IsDBNull(sdr.GetOrdinal("afm")) = False Then txtAFM.EditValue = sdr.GetString(sdr.GetOrdinal("afm")) Else txtAFM.EditValue = Nothing
                Dim sADSQL As New System.Text.StringBuilder
                If cboADR.EditValue IsNot Nothing Then sADSQL.AppendLine("Select id,Name + ' - ' + isnull(ar,'') as Name from vw_ADR WHERE ID = " & toSQLValueS(cboADR.EditValue.ToString))
                FillCbo.ADR(cboADR, sADSQL)
                If sdr.IsDBNull(sdr.GetOrdinal("AdrID")) = False Then cboADR.EditValue = sdr.GetGuid(sdr.GetOrdinal("AdrID")) Else cboADR.EditValue = Nothing
            End If
            sdr.Close()
        End If
    End Sub

    Private Sub cmdPrintOffer_Click(sender As Object, e As EventArgs) Handles cmdPrintOffer.Click
        Dim report As New RepCUSPrivateAgreement()

        report.Parameters.Item(0).Value = sID
        report.CreateDocument()

        Dim report2 As New RepCUSPrivateAgreement2ndPage
        report2.Parameters.Item(0).Value = sID
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
        report5.Parameters.Item(0).Value = cboTRANSH.EditValue.ToString
        report5.CreateDocument()
        report.ModifyDocument(Sub(x)
                                  x.AddPages(report5.Pages)
                              End Sub)
        Dim printTool As New ReportPrintTool(report)
        printTool.ShowRibbonPreview()
    End Sub

    Private Sub txtTotalVatPrice_EditValueChanged(sender As Object, e As EventArgs) Handles txtTotalVatPrice.EditValueChanged
        'Dim TotalPrice As Double
        'If txtTotalVatPrice.EditValue <> Nothing Then TotalPrice = DbnullToZero(txtTotalVatPrice)
        'TotalPrice = TotalPrice / 2
        'txtPayinAdvance.EditValue = TotalPrice
        'If ChangeVal Then txtTotalPrice.Text = "0.00" : txtPartofVat.Text = "0.00"
    End Sub
    Private Sub txtTotalPrice_EditValueChanged(sender As Object, e As EventArgs) Handles TxtTotalVat.EditValueChanged
        Dim Price As Double, PartOfVat As Double
        If TxtTotalVat.EditValue <> Nothing Then Price = DbnullToZero(TxtTotalVat)
        If txtPartofVat.EditValue <> Nothing Then PartOfVat = DbnullToZero(txtPartofVat)
        'txtPayinAdvance.EditValue = (Price + PartOfVat) / 2
        'If ChangeVal Then txtTotalVatPrice.Text = "0.00"

    End Sub
    Private Sub txtPartofVat_EditValueChanged(sender As Object, e As EventArgs) Handles txtPartofVat.EditValueChanged
        Dim TotalPrice As Double, Price As Double, PartOfVat As Double
        If txtPartofVat.EditValue <> Nothing Then TotalPrice = DbnullToZero(txtPartofVat)
        TotalPrice = (TotalPrice * 100) / 24 + TotalPrice
        txtPosoParastatikou.EditValue = TotalPrice
        If TxtTotalVat.EditValue <> Nothing Then Price = DbnullToZero(TxtTotalVat)
        If txtPartofVat.EditValue <> Nothing Then PartOfVat = DbnullToZero(txtPartofVat)
        'txtPayinAdvance.EditValue = (Price + PartOfVat) / 2
        'If ChangeVal Then txtTotalVatPrice.Text = "0.00"
    End Sub

    Private Sub cboTRANSH_EditValueChanged(sender As Object, e As EventArgs) Handles cboTRANSH.EditValueChanged
        Dim cmd As SqlCommand
        Dim sdr As SqlDataReader
        Dim Cash As Boolean
        Try
            If cboTRANSH.EditValue = Nothing Then
                lblBank.Text = "" : txtClose.EditValue = 0 : txtCloseCash.EditValue = 0
                txtPartofVat.EditValue = 0 : TxtTotalVat.EditValue = 0
                txtTotalVatPrice.EditValue = 0 : chkHasKitchen.Checked = False : chkHasCloset.Checked = False
                chkHasDoors.Checked = False : chkHasSC.Checked = False : txtGenTot.EditValue = 0
                txtPosoParastatikou.EditValue = 0 : txtDevices.EditValue = 0 : txtExtraInst.EditValue = 0 : txtExtraTransp.EditValue = 0
                txtPayinAdvance.EditValue = 0 : txtPayinAdvanceBank.EditValue = 0 : txtPayinAdvanceCash.EditValue = 0
                txtArProt.EditValue = Nothing
                Exit Sub
            Else
                txtArProt.EditValue = txtArProt.EditValue & IIf(cboTRANSH.GetColumnValue("ArProtKitchen").ToString.Length > 0, cboTRANSH.GetColumnValue("ArProtKitchen") & " ", "")
                txtArProt.EditValue = txtArProt.EditValue & IIf(cboTRANSH.GetColumnValue("ArProtCloset").ToString.Length > 0, " " & cboTRANSH.GetColumnValue("ArProtCloset"), "")
                txtArProt.EditValue = txtArProt.EditValue & IIf(cboTRANSH.GetColumnValue("ArProtDoor").ToString.Length > 0, " " & cboTRANSH.GetColumnValue("ArProtDoor"), "")
                txtArProt.EditValue = txtArProt.EditValue & IIf(cboTRANSH.GetColumnValue("ArProtSpecialContr").ToString.Length > 0, " " & cboTRANSH.GetColumnValue("ArProtSpecialContr"), "")
            End If
            cmd = New SqlCommand("SELECT isnull(sum(amt),0) as amt FROM TRANSD WHERE cash=0 and paytype=1  and transhID = " & toSQLValueS(cboTRANSH.EditValue.ToString), CNDB)
            sdr = cmd.ExecuteReader()
            If (sdr.Read() = True) Then
                If sdr.IsDBNull(sdr.GetOrdinal("amt")) = False Then txtClose.EditValue = sdr.GetDecimal(sdr.GetOrdinal("amt")) Else txtClose.EditValue = Nothing
            Else
                lblBank.Text = ""
                txtClose.EditValue = "0"
            End If
            sdr.Close()
            cmd = New SqlCommand("SELECT isnull(sum(amt),0) as amt FROM TRANSD WHERE cash=1 and paytype=1  and transhID = " & toSQLValueS(cboTRANSH.EditValue.ToString), CNDB)
            sdr = cmd.ExecuteReader()
            If (sdr.Read() = True) Then
                If sdr.IsDBNull(sdr.GetOrdinal("amt")) = False Then txtCloseCash.EditValue = sdr.GetDecimal(sdr.GetOrdinal("amt")) Else txtCloseCash.EditValue = Nothing
            Else
                lblCash.Text = ""
                txtCloseCash.EditValue = "0"
            End If
            sdr.Close()
            cmd = New SqlCommand(" select   TotPartOfVat,TotalVat,TotalPrice,TotalEquipmentPrice,GENTOT,ExtraInst, ExtraTransp,
                                            TotKitchen,TotDoor,HasCloset,HasKitchen,HasSpecial,HasDoors
                                    FROM vw_ANALYSH_KOSTOYS WHERE ID = " & toSQLValueS(cboTRANSH.EditValue.ToString), CNDB)
            sdr = cmd.ExecuteReader()
            If (sdr.Read() = True) Then
                If sdr.IsDBNull(sdr.GetOrdinal("TotPartOfVat")) = False Then txtPartofVat.EditValue = sdr.GetDecimal(sdr.GetOrdinal("TotPartOfVat")) Else txtPartofVat.EditValue = Nothing
                If sdr.IsDBNull(sdr.GetOrdinal("TotalVat")) = False Then TxtTotalVat.EditValue = sdr.GetDecimal(sdr.GetOrdinal("TotalVat")) Else TxtTotalVat.EditValue = Nothing
                If sdr.IsDBNull(sdr.GetOrdinal("TotalPrice")) = False Then txtTotalVatPrice.EditValue = sdr.GetDecimal(sdr.GetOrdinal("TotalPrice")) Else txtTotalVatPrice.EditValue = Nothing
                If sdr.IsDBNull(sdr.GetOrdinal("GENTOT")) = False Then txtGenTot.EditValue = sdr.GetDecimal(sdr.GetOrdinal("GENTOT")) Else txtGenTot.EditValue = Nothing
                If sdr.IsDBNull(sdr.GetOrdinal("ExtraInst")) = False Then txtExtraInst.EditValue = sdr.GetDecimal(sdr.GetOrdinal("ExtraInst")) Else txtExtraInst.EditValue = Nothing
                If sdr.IsDBNull(sdr.GetOrdinal("ExtraTransp")) = False Then txtExtraTransp.EditValue = sdr.GetDecimal(sdr.GetOrdinal("ExtraTransp")) Else txtExtraTransp.EditValue = Nothing
                chkHasKitchen.Checked = sdr.GetBoolean(sdr.GetOrdinal("HasKitchen"))
                chkHasCloset.Checked = sdr.GetBoolean(sdr.GetOrdinal("HasCloset"))
                chkHasDoors.Checked = sdr.GetBoolean(sdr.GetOrdinal("HasDoors"))
                chkHasSC.Checked = sdr.GetBoolean(sdr.GetOrdinal("HasSpecial"))
                If sdr.IsDBNull(sdr.GetOrdinal("TotalEquipmentPrice")) = False Then
                    Dim TotalEquipmentPrice As Double, PosoParastatikou As Double
                    TotalEquipmentPrice = sdr.GetDecimal(sdr.GetOrdinal("TotalEquipmentPrice"))
                    PosoParastatikou = DbnullToZero(txtPosoParastatikou)
                    txtPosoParastatikou.EditValue = PosoParastatikou + TotalEquipmentPrice
                    txtDevices.EditValue = TotalEquipmentPrice
                End If
            End If
            sdr.Close()
        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), "Dreamy Kitchen CRM", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub txtPayinAdvance_EditValueChanged(sender As Object, e As EventArgs) Handles txtPayinAdvance.EditValueChanged
        Dim TotalPrice As Double, Close As Double, Ypol As Double
        If txtPayinAdvance.EditValue <> Nothing Then TotalPrice = DbnullToZero(txtPayinAdvance)
        If txtClose.EditValue <> Nothing Then Close = DbnullToZero(txtClose)
        If txtCloseCash.EditValue <> Nothing Then Close = Close + DbnullToZero(txtCloseCash)
        Ypol = TotalPrice - Close
        txtPayinAdvanceYpol.EditValue = Ypol
    End Sub

    Private Sub cboBANK_ButtonPressed(sender As Object, e As ButtonPressedEventArgs) Handles cboBANK.ButtonPressed
        Select Case e.Button.Index
            Case 1 : cboBANK.EditValue = Nothing : ManageBank()
            Case 2 : If cboBANK.EditValue <> Nothing Then ManageBank()
            Case 3 : cboBANK.EditValue = Nothing
        End Select

    End Sub
    Private Sub ManageBank()
        Dim form1 As frmGen = New frmGen()
        form1.Text = "Τράπεζες"
        form1.L1.Text = "Κωδικός"
        form1.L2.Text = "Τράπεζα"
        form1.DataTable = "BANKS"
        form1.CalledFromControl = True
        form1.CallerControl = cboBANK
        If cboBANK.EditValue <> Nothing Then form1.ID = cboBANK.EditValue.ToString
        form1.MdiParent = frmMain
        If cboBANK.EditValue <> Nothing Then form1.Mode = FormMode.EditRecord Else form1.Mode = FormMode.NewRecord
        frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(form1), New Point(CInt(form1.Parent.ClientRectangle.Width / 2 - form1.Width / 2), CInt(form1.Parent.ClientRectangle.Height / 2 - form1.Height / 2)))
        form1.Show()
    End Sub

    Private Sub txtGenTot_EditValueChanged(sender As Object, e As EventArgs) Handles txtGenTot.EditValueChanged
        Dim PayinAdvance As Double
        If txtGenTot.EditValue <> Nothing Then
            PayinAdvance = DbnullToZero(txtGenTot)
            PayinAdvance = PayinAdvance / 2
            txtPayinAdvance.EditValue = PayinAdvance
        End If
    End Sub


    Private Sub chkHasCloset_DoubleClick(sender As Object, e As EventArgs) Handles chkHasCloset.DoubleClick
        Dim cmd As SqlCommand
        Dim sdr As SqlDataReader
        Dim oID As String = ""
        Try
            cmd = New SqlCommand("SELECT ID FROM CCT_ORDERS_CLOSET WHERE transhID = " & toSQLValueS(cboTRANSH.EditValue.ToString), CNDB)
            sdr = cmd.ExecuteReader()
            If (sdr.Read() = True) Then
                If sdr.IsDBNull(sdr.GetOrdinal("ID")) = False Then oID = sdr.GetGuid(sdr.GetOrdinal("ID")).ToString
            End If
            sdr.Close()
            If oID = "" Then Exit Sub
            Dim frmCUSOrderCloset As frmCUSOfferOrderCloset = New frmCUSOfferOrderCloset()
            frmCUSOrderCloset.Text = "Έντυπο Παραγγελίας Πελατών(Ντουλάπα)"
            frmCUSOrderCloset.ID = oID
            frmCUSOrderCloset.MdiParent = frmMain
            frmCUSOrderCloset.Mode = FormMode.EditRecord
            frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(frmCUSOrderCloset), New Point(CInt(Me.ClientRectangle.Width / 2 - Me.Width / 2), CInt(Me.ClientRectangle.Height / 2 - Me.Height / 2)))
            frmCUSOrderCloset.Show()
        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), "Dreamy Kitchen CRM", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub chkHasDoors_DoubleClick(sender As Object, e As EventArgs) Handles chkHasDoors.DoubleClick
        Dim cmd As SqlCommand
        Dim sdr As SqlDataReader
        Dim oID As String = ""
        Try
            cmd = New SqlCommand("SELECT ID FROM CCT_ORDERS_DOOR WHERE transhID = " & toSQLValueS(cboTRANSH.EditValue.ToString), CNDB)
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
            frmCUSOfferOrderDoors.MdiParent = frmMain
            frmCUSOfferOrderDoors.Mode = FormMode.EditRecord
            frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(frmCUSOfferOrderDoors), New Point(CInt(Me.ClientRectangle.Width / 2 - Me.Width / 2), CInt(Me.ClientRectangle.Height / 2 - Me.Height / 2)))
            frmCUSOfferOrderDoors.Show()
        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), "Dreamy Kitchen CRM", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub chkHasKitchen_DoubleClick(sender As Object, e As EventArgs) Handles chkHasKitchen.DoubleClick
        Dim cmd As SqlCommand
        Dim sdr As SqlDataReader
        Dim oID As String = ""
        Try
            cmd = New SqlCommand("SELECT ID FROM CCT_ORDERS_KITCHEN WHERE transhID = " & toSQLValueS(cboTRANSH.EditValue.ToString), CNDB)
            sdr = cmd.ExecuteReader()
            If (sdr.Read() = True) Then
                If sdr.IsDBNull(sdr.GetOrdinal("ID")) = False Then oID = sdr.GetGuid(sdr.GetOrdinal("ID")).ToString
            End If
            sdr.Close()
            If oID = "" Then Exit Sub
            Dim frmCUSOrderKitchen As frmCUSOfferOrderKitchen = New frmCUSOfferOrderKitchen()
            frmCUSOrderKitchen.Text = "Έντυπο Παραγγελίας Πελατών(Κουζίνα)"
            frmCUSOrderKitchen.ID = oID
            frmCUSOrderKitchen.MdiParent = frmMain
            frmCUSOrderKitchen.Mode = FormMode.EditRecord
            frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(frmCUSOrderKitchen), New Point(CInt(Me.ClientRectangle.Width / 2 - Me.Width / 2), CInt(Me.ClientRectangle.Height / 2 - Me.Height / 2)))
            frmCUSOrderKitchen.Show()
        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), "Dreamy Kitchen CRM", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub chkHasSC_DoubleClick(sender As Object, e As EventArgs) Handles chkHasSC.DoubleClick
        Dim cmd As SqlCommand
        Dim sdr As SqlDataReader
        Dim oID As String = ""
        Try
            cmd = New SqlCommand("SELECT ID FROM CCT_ORDERS_SPECIAL_CONSTR WHERE transhID = " & toSQLValueS(cboTRANSH.EditValue.ToString), CNDB)
            sdr = cmd.ExecuteReader()
            If (sdr.Read() = True) Then
                If sdr.IsDBNull(sdr.GetOrdinal("ID")) = False Then oID = sdr.GetGuid(sdr.GetOrdinal("ID")).ToString
            End If
            sdr.Close()
            If oID = "" Then Exit Sub
            Dim frmCUSOfferSpecialConstr As frmCUSOfferOrderSpecialConstr = New frmCUSOfferOrderSpecialConstr()
            frmCUSOfferSpecialConstr.Text = "Έντυπο Παραγγελίας Πελατών(Έπιπλο Μπάνιου)"
            frmCUSOfferSpecialConstr.ID = oID
            frmCUSOfferSpecialConstr.MdiParent = frmMain
            frmCUSOfferSpecialConstr.IsOrder = True
            frmCUSOfferSpecialConstr.Mode = FormMode.EditRecord
            frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(frmCUSOfferSpecialConstr), New Point(CInt(Me.ClientRectangle.Width / 2 - Me.Width / 2), CInt(Me.ClientRectangle.Height / 2 - Me.Height / 2)))
            frmCUSOfferSpecialConstr.Show()
        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), "Dreamy Kitchen CRM", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cboADR_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboADR.ButtonClick
        Select Case e.Button.Index
            Case 1 : cboADR.EditValue = Nothing : ManageADR()
            Case 2 : If cboADR.EditValue <> Nothing Then ManageADR()
            Case 3 : cboADR.EditValue = Nothing
        End Select
    End Sub

    Private Sub ManageADR()
        Dim form1 As frmGen = New frmGen()
        form1.Text = "Διευθύνσεις"
        form1.L1.Text = "Κωδικός"
        form1.L2.Text = "Διεύθυνση"
        form1.L3.Text = "Νομός"
        form1.L4.Text = "Περιοχές"
        form1.L8.Text = "Αριθμός"
        form1.DataTable = "ADR"
        form1.CalledFromControl = True
        form1.CallerControl = cboADR
        form1.L3.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
        form1.L4.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
        form1.L8.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
        form1.L8.Control.Tag = "Ar,0,1,2"
        If cboADR.EditValue <> Nothing Then form1.ID = cboADR.EditValue.ToString
        form1.MdiParent = frmMain

        If cboADR.EditValue <> Nothing Then form1.Mode = FormMode.EditRecord Else form1.Mode = FormMode.NewRecord
        frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(form1), New Point(CInt(form1.Parent.ClientRectangle.Width / 2 - form1.Width / 2), CInt(form1.Parent.ClientRectangle.Height / 2 - form1.Height / 2)))
        form1.Show()
    End Sub

End Class