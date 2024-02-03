Imports System.Data.SqlClient
Imports DevExpress.Utils
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraReports.UI
Public Event HyperlinkClick As HyperlinkClickEventHandler
Public Class frmCUSPrivateAgreement
    Private CusPrivateAgreement As New CusPrivateAgreement
    Private ManageCbo As New CombosManager
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
    Private Sub frmPrivateAgreement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CusPrivateAgreement.Initialize(Me, sID, Mode, CalledFromCtrl, CtrlCombo)
        CusPrivateAgreement.LoadForm()
        Me.CenterToScreen()
    End Sub

    Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click
        CusPrivateAgreement.SaveRecord(sID)
    End Sub

    Private Sub frmPrivateAgreement_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        If Me.WindowState = FormWindowState.Maximized Then frmMain.XtraTabbedMdiManager1.Dock(Me, frmMain.XtraTabbedMdiManager1)
    End Sub
    Private Sub cboCUS_EditValueChanged(sender As Object, e As EventArgs) Handles cboCUS.EditValueChanged
        FillCusTransh()
    End Sub
    Private Sub cboEMP_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboEMP.ButtonClick
        Select Case e.Button.Index
            Case 1 : ManageCbo.ManageEMP(cboEMP, FormMode.NewRecord)
            Case 2 : ManageCbo.ManageEMP(cboEMP, FormMode.EditRecord)
            Case 3 : cboEMP.EditValue = Nothing
        End Select
    End Sub
    Private Sub cboCUS_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboCUS.ButtonClick
        Select Case e.Button.Index
            Case 1 : ManageCbo.ManageCCT(FormMode.NewRecord, False,, cboCUS) : Vw_CCTTableAdapter.Fill(DreamyKitchenDataSet.vw_CCT)
            Case 2 : ManageCbo.ManageCCT(FormMode.EditRecord, False,, cboCUS) : Vw_CCTTableAdapter.Fill(DreamyKitchenDataSet.vw_CCT)
            Case 3 : cboCUS.EditValue = Nothing
        End Select
    End Sub
    Private Sub cboTRANSH_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboTRANSH.ButtonClick
        Select Case e.Button.Index
            Case 1 : ManageCbo.ManageTRANSHSmall(cboTRANSH, FormMode.NewRecord, cboCUS.EditValue)
            Case 2 : ManageCbo.ManageTRANSHSmall(cboTRANSH, FormMode.EditRecord, cboCUS.EditValue)
            Case 3 : cboTRANSH.EditValue = Nothing
        End Select
    End Sub

    'Private Sub ManageCus()
    '    Dim form1 As frmCustomers = New frmCustomers()
    '    form1.Text = "Πελάτες"
    '    form1.CallerControl = cboCUS
    '    form1.CalledFromControl = True
    '    'form1.MdiParent = frmMain
    '    If cboCUS.EditValue <> Nothing Then
    '        form1.ID = cboCUS.EditValue.ToString
    '        form1.Mode = FormMode.EditRecord
    '    Else
    '        form1.Mode = FormMode.NewRecord
    '    End If
    '    'frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(form1), New Point(CInt(form1.Parent.ClientRectangle.Width / 2 - form1.Width / 2), CInt(form1.Parent.ClientRectangle.Height / 2 - form1.Height / 2)))
    '    form1.ShowDialog()
    '    Dim cmd As SqlCommand
    '    Dim sdr As SqlDataReader
    '    If cboCUS.EditValue <> Nothing Then
    '        cmd = New SqlCommand("SELECT AdrID,FatherName,AREAS_Name,DOY_Name,afm FROM VW_CCT WHERE ID = " & toSQLValueS(cboCUS.EditValue.ToString), CNDB)
    '        sdr = cmd.ExecuteReader()
    '        If (sdr.Read() = True) Then
    '            If sdr.IsDBNull(sdr.GetOrdinal("FatherName")) = False Then txtFatherName.EditValue = sdr.GetString(sdr.GetOrdinal("FatherName")) Else txtFatherName.EditValue = Nothing
    '            If sdr.IsDBNull(sdr.GetOrdinal("AREAS_Name")) = False Then txtArea.EditValue = sdr.GetString(sdr.GetOrdinal("AREAS_Name")) Else txtArea.EditValue = Nothing
    '            If sdr.IsDBNull(sdr.GetOrdinal("DOY_Name")) = False Then txtDOY.EditValue = sdr.GetString(sdr.GetOrdinal("DOY_Name")) Else txtDOY.EditValue = Nothing
    '            If sdr.IsDBNull(sdr.GetOrdinal("afm")) = False Then txtAFM.EditValue = sdr.GetString(sdr.GetOrdinal("afm")) Else txtAFM.EditValue = Nothing
    '            Dim sADSQL As New System.Text.StringBuilder
    '            If cboADR.EditValue IsNot Nothing Then sADSQL.AppendLine("Select id,Name + ' - ' + isnull(ar,'') as Name from vw_ADR WHERE ID = " & toSQLValueS(cboADR.EditValue.ToString))
    '            FillCbo.ADR(cboADR, sADSQL)
    '            If sdr.IsDBNull(sdr.GetOrdinal("AdrID")) = False Then cboADR.EditValue = sdr.GetGuid(sdr.GetOrdinal("AdrID")) Else cboADR.EditValue = Nothing
    '        End If
    '        sdr.Close()
    '    End If
    'End Sub

    Private Sub cmdPrintOffer_Click(sender As Object, e As EventArgs) Handles cmdPrintOffer.Click
        CusPrivateAgreement.PrintAgreement()
    End Sub

    Private Sub txtTotalPrice_EditValueChanged(sender As Object, e As EventArgs) Handles TxtTotalVat.EditValueChanged
        Dim Price As Double, PartOfVat As Double
        If TxtTotalVat.EditValue <> Nothing Then Price = DbnullToZero(TxtTotalVat)
        If txtPartofVat.EditValue <> Nothing Then PartOfVat = DbnullToZero(txtPartofVat)
    End Sub
    Private Sub txtPartofVat_EditValueChanged(sender As Object, e As EventArgs) Handles txtPartofVat.EditValueChanged
        Dim TotalPrice As Double, Price As Double, PartOfVat As Double
        If txtPartofVat.EditValue <> Nothing Then TotalPrice = DbnullToZero(txtPartofVat)
        TotalPrice = (TotalPrice * 100) / 24 + TotalPrice
        txtPosoParastatikou.EditValue = TotalPrice
        If TxtTotalVat.EditValue <> Nothing Then Price = DbnullToZero(TxtTotalVat)
        If txtPartofVat.EditValue <> Nothing Then PartOfVat = DbnullToZero(txtPartofVat)
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
            cmd = New SqlCommand("SELECT isnull(sum(amt),0) as amt FROM TRANSD WHERE cash=0 and paytypeID='90A295A1-D2A0-40B7-B260-A532B2C322AC'  and transhID = " & toSQLValueS(cboTRANSH.EditValue.ToString), CNDB)
            sdr = cmd.ExecuteReader()
            If (sdr.Read() = True) Then
                If sdr.IsDBNull(sdr.GetOrdinal("amt")) = False Then txtClose.EditValue = sdr.GetDecimal(sdr.GetOrdinal("amt")) Else txtClose.EditValue = Nothing
            Else
                lblBank.Text = ""
                txtClose.EditValue = "0"
            End If
            sdr.Close()
            cmd = New SqlCommand("SELECT isnull(sum(amt),0) as amt FROM TRANSD WHERE cash=1 and paytypeID='90A295A1-D2A0-40B7-B260-A532B2C322AC'  and transhID = " & toSQLValueS(cboTRANSH.EditValue.ToString), CNDB)
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
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
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
            Case 1 : ManageCbo.ManageBank(cboBANK, FormMode.NewRecord)
            Case 2 : ManageCbo.ManageBank(cboBANK, FormMode.EditRecord)
            Case 3 : cboBANK.EditValue = Nothing
        End Select

    End Sub


    Private Sub txtGenTot_EditValueChanged(sender As Object, e As EventArgs) Handles txtGenTot.EditValueChanged
        Dim PayinAdvance As Double
        If txtGenTot.EditValue <> Nothing Then
            PayinAdvance = DbnullToZero(txtGenTot)
            PayinAdvance = PayinAdvance / 2
            txtPayinAdvance.EditValue = PayinAdvance
        End If
    End Sub


    Private Sub chkHasCloset_DoubleClick(sender As Object, e As EventArgs)
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
            frmCUSOrderCloset.IsOrder = True
            frmCUSOrderCloset.MdiParent = frmMain
            frmCUSOrderCloset.Mode = FormMode.EditRecord
            frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(frmCUSOrderCloset), New Point(CInt(Me.ClientRectangle.Width / 2 - Me.Width / 2), CInt(Me.ClientRectangle.Height / 2 - Me.Height / 2)))
            frmCUSOrderCloset.Show()
        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub chkHasDoors_DoubleClick(sender As Object, e As EventArgs)
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
            frmCUSOfferOrderDoors.IsOrder = True
            frmCUSOfferOrderDoors.MdiParent = frmMain
            frmCUSOfferOrderDoors.Mode = FormMode.EditRecord
            frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(frmCUSOfferOrderDoors), New Point(CInt(Me.ClientRectangle.Width / 2 - Me.Width / 2), CInt(Me.ClientRectangle.Height / 2 - Me.Height / 2)))
            frmCUSOfferOrderDoors.Show()
        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub chkHasKitchen_DoubleClick(sender As Object, e As EventArgs)
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
            frmCUSOrderKitchen.IsOrder = True
            frmCUSOrderKitchen.MdiParent = frmMain
            frmCUSOrderKitchen.Mode = FormMode.EditRecord
            frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(frmCUSOrderKitchen), New Point(CInt(Me.ClientRectangle.Width / 2 - Me.Width / 2), CInt(Me.ClientRectangle.Height / 2 - Me.Height / 2)))
            frmCUSOrderKitchen.Show()
        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub chkHasSC_DoubleClick(sender As Object, e As EventArgs)
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
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cboADR_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboADR.ButtonClick
        Select Case e.Button.Index
            Case 1 : cboADR.EditValue = Nothing : ManageCbo.ManageADR(cboADR, FormMode.NewRecord)
            Case 2 : If cboADR.EditValue <> Nothing Then ManageCbo.ManageADR(cboADR, FormMode.EditRecord)
            Case 3 : cboADR.EditValue = Nothing
        End Select
    End Sub


    Private Sub cboCompany_EditValueChanged(sender As Object, e As EventArgs) Handles cboCompany.EditValueChanged
        Dim sCompID As String
        If cboCompany.EditValue Is Nothing Then sCompID = toSQLValueS(Guid.Empty.ToString) Else sCompID = toSQLValueS(cboCompany.EditValue.ToString)
        Dim sSQL As New System.Text.StringBuilder
        sSQL.AppendLine("Select T.id,FullTranshDescription,Description,Iskitchen,Iscloset,Isdoor,Issc
                        from vw_TRANSH t
                        where  T.cusid = " & sCompID & "order by description")
        FillCbo.TRANSH(cboCompProject, sSQL)
        LCompProject.ImageOptions.Image = Global.DreamyKitchenCRM.My.Resources.Resources.rsz_11rsz_asterisk
    End Sub

    Private Sub cboCompProject_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboCompProject.ButtonClick
        Select Case e.Button.Index
            Case 1 : ManageCbo.ManageTRANSHSmall(cboCompProject, FormMode.NewRecord, cboCompany.EditValue, True)
            Case 2 : ManageCbo.ManageTRANSHSmall(cboCompProject, FormMode.EditRecord, cboCompany.EditValue, True)
            Case 3 : cboCompProject.EditValue = Nothing
        End Select
    End Sub

    Private Sub cboCompany_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboCompany.ButtonClick
        Select Case e.Button.Index
            Case 1 : ManageCbo.ManageCCT(FormMode.NewRecord, False,, cboCompany)
            Case 2 : ManageCbo.ManageCCT(FormMode.EditRecord, False,, cboCompany)
            Case 3 : cboCompany.EditValue = Nothing : LCompProject.ImageOptions.Image = Nothing
        End Select
    End Sub

    Private Sub cmdCollection_Click(sender As Object, e As EventArgs) Handles cmdCompCollection.Click
        If cboCompProject.EditValue Is Nothing Then XtraMessageBox.Show("Δεν έχετε επιλέξει έργο", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error) : Exit Sub
        Dim Frm As frmTransactions = New frmTransactions()
        Frm.Text = "Είσπραξη Πελάτη"
        Frm.CreditOnly = True
        Frm.Mode = FormMode.EditRecord
        Frm.ID = cboCompProject.EditValue.ToString
        Frm.ShowDialog()
    End Sub

    Private Sub cmdCusCollection_Click(sender As Object, e As EventArgs) Handles cmdCusCollection.Click
        If cboTRANSH.EditValue Is Nothing Then XtraMessageBox.Show("Δεν έχετε επιλέξει έργο", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error) : Exit Sub
        Dim Frm As frmTransactions = New frmTransactions()
        Frm.Text = "Είσπραξη Πελάτη"
        Frm.CreditOnly = True
        Frm.Mode = FormMode.EditRecord
        Frm.ID = cboTRANSH.EditValue.ToString
        Frm.lCusD.Visibility = False
        Frm.ShowDialog()

    End Sub

    Private Sub FillCusTransh()
        txtFatherName.EditValue = cboCUS.GetColumnValue("FatherName")
        txtArea.EditValue = cboCUS.GetColumnValue("AREAS_Name")
        txtDOY.EditValue = cboCUS.GetColumnValue("DOY_Name")
        txtAFM.EditValue = cboCUS.GetColumnValue("afm")
        cboADR.EditValue = cboCUS.GetColumnValue("AdrID")

        Dim sCusID As String, scompTrashID As String
        If cboCUS.EditValue Is Nothing Then sCusID = toSQLValueS(Guid.Empty.ToString) Else sCusID = toSQLValueS(cboCUS.EditValue.ToString)
        If cboCompProject.EditValue Is Nothing Then scompTrashID = toSQLValueS(Guid.Empty.ToString) Else scompTrashID = toSQLValueS(cboCompProject.EditValue.ToString)
        Dim sSQL As New System.Text.StringBuilder
        sSQL.AppendLine("Select T.id,FullTranshDescription,Description,ArProtKitchen,ArProtCloset,ArProtDoor,ArProtSpecialContr
                        from vw_TRANSH t
                        INNER JOIN TRANSC on transc.transhID = t.id 
                        where  completed = 0  and T.cusid = " & sCusID & " and T.compTrashID = " & scompTrashID & " order by description")
        FillCbo.TRANSH(cboTRANSH, sSQL)
    End Sub

    Private Sub cboCompProject_EditValueChanged(sender As Object, e As EventArgs) Handles cboCompProject.EditValueChanged
        FillCusTransh()
    End Sub
End Class