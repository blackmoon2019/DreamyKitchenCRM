Imports System.Data.SqlClient
Imports DevExpress.XtraBars.Navigation
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid

Public Class frmCUSOfferOrderSpecialConstr
    Private CUSOfferOrderSpecialConstr As New CUSOfferOrderSpecialConstr
    Private sID As String
    Private ScanFile As ScanToPDF
    Private ManageCbo As New CombosManager
    Private Ctrl As DevExpress.XtraGrid.Views.Grid.GridView
    Private Frm As DevExpress.XtraEditors.XtraForm
    Public Mode As Byte
    Private sIsOrder As Boolean
    Private sOrderID As String
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
    Private receiveAgreement As Boolean = False
    Private UserPermissions As New CheckPermissions
    Private Prog_Prop As New ProgProp
    Public WriteOnly Property ID As String
        Set(value As String)
            sID = value
        End Set
    End Property
    Public WriteOnly Property IsOrder As Boolean
        Set(value As Boolean)
            sIsOrder = value
        End Set
    End Property
    Public ReadOnly Property IsOrderRead As Boolean
        Get
            Return sIsOrder
        End Get
    End Property
    Public WriteOnly Property orderID As String
        Set(value As String)
            sOrderID = value
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
    Private Sub frmCUSOfferSpecialConstr_Load(sender As Object, e As EventArgs) Handles Me.Load
        'TODO: This line of code loads data into the 'DreamyKitchenDataSet.vw_FILE_CAT' table. You can move, or remove it, as needed.
        Me.Vw_FILE_CATTableAdapter.Fill(Me.DreamyKitchenDataSet.vw_FILE_CAT)
        CUSOfferOrderSpecialConstr.Initialize(Me, sID, Mode, CalledFromCtrl, CtrlCombo, sIsOrder)
        CUSOfferOrderSpecialConstr.LoadForm()
        If receiveAgreement = True Then cmdSave.Enabled = False : cmdSavePhotos.Enabled = False
        If chkGenOffer.CheckState = CheckState.Checked = True Then cmdCusCollection.Enabled = False : cmdCompCollection.Enabled = True Else cmdCusCollection.Enabled = True : cmdCompCollection.Enabled = False
        Me.CenterToScreen()
    End Sub

    Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click
        CUSOfferOrderSpecialConstr.SaveRecord(sID)
    End Sub

    Private Sub cboEMP_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboEMP.ButtonClick
        Select Case e.Button.Index
            Case 1 : ManageCbo.ManageEMP(cboEMP, FormMode.NewRecord)
            Case 2 : ManageCbo.ManageEMP(cboEMP, FormMode.EditRecord)
            Case 3 : cboEMP.EditValue = Nothing
        End Select
    End Sub

    Private Sub cboCUS_EditValueChanged(sender As Object, e As EventArgs) Handles cboCUS.EditValueChanged
        If Mode = FormMode.NewRecord Then CUSOfferOrderSpecialConstr.FillCusTransh(lkupEditValue(cboCUS), lkupEditValue(cboCompProject), chkGenOffer.CheckState, "")
    End Sub

    Private Sub txtdtdaysOfDelivery_EditValueChanged(sender As Object, e As EventArgs) Handles txtdtdaysOfDelivery.EditValueChanged
        If dtpresentation.EditValue Is Nothing Then Exit Sub
        If dtpresentation.EditValue.ToString = "" Then Exit Sub
        Dim FirstDate As Date = dtpresentation.EditValue
        lblDate.Text = "Ημερομηνία Παράδοσης: " & DateAdd("d", CDbl(txtdtdaysOfDelivery.EditValue.ToString), FirstDate).ToString("dd/MM/yyyy")
    End Sub

    Private Sub dtpresentation_EditValueChanged(sender As Object, e As EventArgs) Handles dtpresentation.EditValueChanged
        If dtpresentation.EditValue Is Nothing Then Exit Sub
        If dtpresentation.EditValue.ToString = "" Then Exit Sub
        Dim FirstDate As Date = dtpresentation.EditValue
        If txtdtdaysOfDelivery.EditValue Is Nothing Then txtdtdaysOfDelivery.EditValue = 0
        lblDate.Text = "Ημερομηνία Παράδοσης: " & DateAdd("d", CDbl(txtdtdaysOfDelivery.EditValue.ToString), FirstDate).ToString("dd/MM/yyyy")
    End Sub

    Private Function TotalPrice() As Double
        Dim Price1 As Double, Price2 As Double, Price3 As Double, Price4 As Double
        Dim Total As Double
        Price1 = DbnullToZero(txtFinalPrice1)
        Price2 = DbnullToZero(txtFinalPrice2)
        Price3 = DbnullToZero(txtFinalPrice3)
        Price4 = DbnullToZero(txtFinalPrice4)
        Total = Price1 + Price2 + Price3 + Price4
        Return Total
    End Function

    Private Sub cmdPrintOffer_Click(sender As Object, e As EventArgs) Handles cmdPrintOffer.Click
        CUSOfferOrderSpecialConstr.PrintOfferOrder()
    End Sub
    Private Sub frmCUSOfferSpecialConstr_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        If Me.WindowState = FormWindowState.Maximized Then frmMain.XtraTabbedMdiManager1.Dock(Me, frmMain.XtraTabbedMdiManager1)
    End Sub

    Private Sub txtTotalSpecialVat_EditValueChanged(sender As Object, e As EventArgs) Handles txtTotalSpecialVat.EditValueChanged
        Dim TotalSpecialPrice As Double
        TotalSpecialPrice = (txtTotalSpecialVat.EditValue * (ProgProps.VAT / 100)) + txtTotalSpecialVat.EditValue
        txtTotalSpecialPrice.EditValue = TotalSpecialPrice
    End Sub

    Private Sub cboTRANSH_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboTRANSH.ButtonClick
        Select Case e.Button.Index
            Case 1
                If cboEMP.Text = "" Then XtraMessageBox.Show("Δεν έχετε επιλέξει πωλητή", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error) : Exit Sub
                ManageCbo.ManageTRANSHSmall(cboTRANSH, FormMode.NewRecord, cboCUS.EditValue,, cboEMP.EditValue, cboCompany.EditValue, cboCompProject.EditValue, 0, sIsOrder, System.Guid.Parse("AE5476D4-2152-4B20-87BB-7933B0215D04"))
            Case 2 : ManageCbo.ManageTRANSHSmall(cboTRANSH, FormMode.EditRecord, cboCUS.EditValue,,,,,, sIsOrder)
            Case 3 : cboTRANSH.EditValue = Nothing
        End Select
    End Sub

    Private Sub cboVALUELISTITEM_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboValueListItem.ButtonClick
        Select Case e.Button.Index
            Case 1 : ManageCbo.ManageValueListItem(cboValueListItem, FormMode.NewRecord, "CF47FAEE-7CD7-49AD-9455-3BC69D438DE9")
            Case 2 : ManageCbo.ManageValueListItem(cboValueListItem, FormMode.EditRecord, "CF47FAEE-7CD7-49AD-9455-3BC69D438DE9")
            Case 3 : cboValueListItem.EditValue = Nothing
        End Select
    End Sub
    Private Sub cboVALUELISTITEM2_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboVALUELISTITEM2.ButtonClick
        Select Case e.Button.Index
            Case 1 : ManageCbo.ManageValueListItem(cboVALUELISTITEM2, FormMode.NewRecord, "CF47FAEE-7CD7-49AD-9455-3BC69D438DE9")
            Case 2 : ManageCbo.ManageValueListItem(cboVALUELISTITEM2, FormMode.EditRecord, "CF47FAEE-7CD7-49AD-9455-3BC69D438DE9")
            Case 3 : cboVALUELISTITEM2.EditValue = Nothing
        End Select
    End Sub
    Private Sub cboVALUELISTITEM3_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboVALUELISTITEM3.ButtonClick
        Select Case e.Button.Index
            Case 1 : ManageCbo.ManageValueListItem(cboVALUELISTITEM3, FormMode.NewRecord, "CF47FAEE-7CD7-49AD-9455-3BC69D438DE9")
            Case 2 : ManageCbo.ManageValueListItem(cboVALUELISTITEM3, FormMode.EditRecord, "CF47FAEE-7CD7-49AD-9455-3BC69D438DE9")
            Case 3 : cboVALUELISTITEM3.EditValue = Nothing
        End Select
    End Sub
    Private Sub cboVALUELISTITEM4_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboVALUELISTITEM4.ButtonClick
        Select Case e.Button.Index
            Case 1 : ManageCbo.ManageValueListItem(cboVALUELISTITEM4, FormMode.NewRecord, "CF47FAEE-7CD7-49AD-9455-3BC69D438DE9")
            Case 2 : ManageCbo.ManageValueListItem(cboVALUELISTITEM4, FormMode.EditRecord, "CF47FAEE-7CD7-49AD-9455-3BC69D438DE9")
            Case 3 : cboVALUELISTITEM4.EditValue = Nothing
        End Select
    End Sub

    Private Sub cboScpecialConstr1_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboScpecialConstr1.ButtonClick
        Select Case e.Button.Index
            Case 1 : ManageCbo.ManageSpecialConstr(cboScpecialConstr1, FormMode.NewRecord)
            Case 2 : ManageCbo.ManageSpecialConstr(cboScpecialConstr1, FormMode.EditRecord)
            Case 3 : cboScpecialConstr1.EditValue = Nothing
        End Select
    End Sub


    Private Sub cboScpecialConstr2_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboScpecialConstr2.ButtonClick
        Select Case e.Button.Index
            Case 1 : ManageCbo.ManageSpecialConstr(cboScpecialConstr2, FormMode.NewRecord)
            Case 2 : ManageCbo.ManageSpecialConstr(cboScpecialConstr2, FormMode.EditRecord)
            Case 3 : cboScpecialConstr2.EditValue = Nothing
        End Select
    End Sub

    Private Sub cboScpecialConstr3_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboScpecialConstr3.ButtonClick
        Select Case e.Button.Index
            Case 1 : ManageCbo.ManageSpecialConstr(cboScpecialConstr3, FormMode.NewRecord)
            Case 2 : ManageCbo.ManageSpecialConstr(cboScpecialConstr3, FormMode.EditRecord)
            Case 3 : cboScpecialConstr3.EditValue = Nothing
        End Select
    End Sub

    Private Sub cboScpecialConstr4_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboScpecialConstr4.ButtonClick
        Select Case e.Button.Index
            Case 1 : ManageCbo.ManageSpecialConstr(cboScpecialConstr4, FormMode.NewRecord)
            Case 2 : ManageCbo.ManageSpecialConstr(cboScpecialConstr4, FormMode.EditRecord)
            Case 3 : cboScpecialConstr4.EditValue = Nothing
        End Select
    End Sub

    Private Sub cmdConvertToOrder_Click(sender As Object, e As EventArgs) Handles cmdConvertToOrder.Click
        CUSOfferOrderSpecialConstr.ConvertToOrder()
    End Sub
    Private Sub cboVALUELISTITEM_ProcessNewValue(sender As Object, e As ProcessNewValueEventArgs) Handles cboValueListItem.ProcessNewValue
        If CStr(e.DisplayValue) <> String.Empty Then
            Dim sVALUELISTITEMID = DBQ.InsertNewValueListItem(cboValueListItem, e.DisplayValue)
            If sVALUELISTITEMID <> "" Then
                Me.Vw_VALUELISTITEM_V2TableAdapter.Fill(Me.DM_VALUELISTITEM.vw_VALUELISTITEM_V2)
                cboValueListItem.EditValue = System.Guid.Parse(sVALUELISTITEMID)
            End If
            e.Handled = True
        End If
    End Sub

    Private Sub cboVALUELISTITEM2_ProcessNewValue(sender As Object, e As ProcessNewValueEventArgs) Handles cboVALUELISTITEM2.ProcessNewValue
        If CStr(e.DisplayValue) <> String.Empty Then
            Dim sVALUELISTITEMID = DBQ.InsertNewValueListItem(cboValueListItem, e.DisplayValue)
            If sVALUELISTITEMID <> "" Then
                Me.Vw_VALUELISTITEM_V2TableAdapter.Fill(Me.DM_VALUELISTITEM.vw_VALUELISTITEM_V2)
                cboVALUELISTITEM2.EditValue = System.Guid.Parse(sVALUELISTITEMID)
            End If
            e.Handled = True
        End If
    End Sub
    Private Sub cboVALUELISTITEM3_ProcessNewValue(sender As Object, e As ProcessNewValueEventArgs) Handles cboVALUELISTITEM3.ProcessNewValue
        If CStr(e.DisplayValue) <> String.Empty Then
            Dim sVALUELISTITEMID = DBQ.InsertNewValueListItem(cboValueListItem, e.DisplayValue)
            If sVALUELISTITEMID <> "" Then
                Me.Vw_VALUELISTITEM_V2TableAdapter.Fill(Me.DM_VALUELISTITEM.vw_VALUELISTITEM_V2)
                cboVALUELISTITEM3.EditValue = System.Guid.Parse(sVALUELISTITEMID)
            End If
            e.Handled = True
        End If
    End Sub
    Private Sub cboVALUELISTITEM4_ProcessNewValue(sender As Object, e As ProcessNewValueEventArgs) Handles cboVALUELISTITEM4.ProcessNewValue
        If CStr(e.DisplayValue) <> String.Empty Then
            Dim sVALUELISTITEMID = DBQ.InsertNewValueListItem(cboValueListItem, e.DisplayValue)
            If sVALUELISTITEMID <> "" Then
                Me.Vw_VALUELISTITEM_V2TableAdapter.Fill(Me.DM_VALUELISTITEM.vw_VALUELISTITEM_V2)
                cboVALUELISTITEM4.EditValue = System.Guid.Parse(sVALUELISTITEMID)
            End If
            e.Handled = True
        End If
    End Sub
    Private Sub chkVatVisible_CheckedChanged(sender As Object, e As EventArgs) Handles chkVatVisible.CheckedChanged
        Dim cmd As SqlCommand
        If chkVatVisible.Checked = True Then
            cmd = New SqlCommand("Update CCT_ORDERS_SPECIAL_CONSTR set visibleVAT = 1 where ID = " & toSQLValueS(sID), CNDB) : cmd.ExecuteNonQuery()
        Else
            cmd = New SqlCommand("Update CCT_ORDERS_SPECIAL_CONSTR set visibleVAT = 0 where ID = " & toSQLValueS(sID), CNDB) : cmd.ExecuteNonQuery()
        End If
    End Sub

    Private Sub txtDisc1_EditValueChanged(sender As Object, e As EventArgs) Handles txtDisc1.EditValueChanged
        If DirectCast(e, DevExpress.XtraEditors.Controls.ChangingEventArgs).OldValue IsNot Nothing Then
            If DirectCast(e, DevExpress.XtraEditors.Controls.ChangingEventArgs).OldValue.ToString.Replace("%", "") <> DirectCast(e, DevExpress.XtraEditors.Controls.ChangingEventArgs).NewValue Then ApplyDiscount(1, True)
        End If
    End Sub
    Private Sub txtDisc2_EditValueChanged(sender As Object, e As EventArgs) Handles txtDisc2.EditValueChanged
        If DirectCast(e, DevExpress.XtraEditors.Controls.ChangingEventArgs).OldValue IsNot Nothing Then
            If DirectCast(e, DevExpress.XtraEditors.Controls.ChangingEventArgs).OldValue.ToString.Replace("%", "") <> DirectCast(e, DevExpress.XtraEditors.Controls.ChangingEventArgs).NewValue Then ApplyDiscount(2, True)
        End If
    End Sub

    Private Sub txtDisc3_EditValueChanged(sender As Object, e As EventArgs) Handles txtDisc3.EditValueChanged
        If DirectCast(e, DevExpress.XtraEditors.Controls.ChangingEventArgs).OldValue IsNot Nothing Then
            If DirectCast(e, DevExpress.XtraEditors.Controls.ChangingEventArgs).OldValue.ToString.Replace("%", "") <> DirectCast(e, DevExpress.XtraEditors.Controls.ChangingEventArgs).NewValue Then ApplyDiscount(3, True)
        End If
    End Sub

    Private Sub txtDisc4_EditValueChanged(sender As Object, e As EventArgs) Handles txtDisc4.EditValueChanged
        If DirectCast(e, DevExpress.XtraEditors.Controls.ChangingEventArgs).OldValue IsNot Nothing Then
            If DirectCast(e, DevExpress.XtraEditors.Controls.ChangingEventArgs).OldValue.ToString.Replace("%", "") <> DirectCast(e, DevExpress.XtraEditors.Controls.ChangingEventArgs).NewValue Then ApplyDiscount(4, True)
        End If
    End Sub


    Private Sub cmdSavePhotos_Click(sender As Object, e As EventArgs) Handles cmdSavePhotos.Click
        CUSOfferOrderSpecialConstr.SavePhotoRecord(sID, FormMode.NewRecord)
    End Sub


    Private Sub CardView1_ValidateRow(sender As Object, e As ValidateRowEventArgs) Handles CardView1.ValidateRow
        CUSOfferOrderSpecialConstr.SavePhotoRecord(sID, FormMode.EditRecord)
    End Sub

    Private Sub CardView1_KeyDown(sender As Object, e As KeyEventArgs) Handles CardView1.KeyDown
        If e.KeyCode = Keys.Delete And UserProps.AllowDelete = True Then DeleteRecord()
    End Sub
    Private Sub DeleteRecord()
        CUSOfferOrderSpecialConstr.DeletePhotoRecord()
    End Sub

    Private Sub cboSUP1_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboSUP1.ButtonClick
        Select Case e.Button.Index
            Case 1 : ManageCbo.ManageSup(cboSUP1, FormMode.NewRecord)
            Case 2 : ManageCbo.ManageSup(cboSUP1, FormMode.EditRecord)
            Case 3 : cboSUP1.EditValue = Nothing
            Case 4
                If IsDBNull(cboSUP1.GetColumnValue("site")) Then Exit Sub
                Dim webAddress As String = cboSUP1.GetColumnValue("site")
                If webAddress = Nothing Then XtraMessageBox.Show("Δεν έχει οριστεί Site στον Προμηθευτή", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error) Else Process.Start(webAddress)
        End Select

    End Sub

    Private Sub cboPhotoValueListItem_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboPhotoValueListItem.ButtonClick
        Select Case e.Button.Index
            Case 1 : ManageCbo.ManageValueListItem(cboPhotoValueListItem, FormMode.NewRecord, "DE86FD16-2154-4E2A-B025-4D34BDF8C808", "MATERIALS")
            Case 2 : ManageCbo.ManageValueListItem(cboPhotoValueListItem, FormMode.EditRecord)
            Case 3 : cboPhotoValueListItem.EditValue = Nothing
        End Select
    End Sub

    Private Sub cboColorsCat_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboColorsCat.ButtonClick
        Select Case e.Button.Index
        '    Case 1 : ManageCbo.ManageColors(cboPhotoValueListItem, FormMode.NewRecord, "DE86FD16-2154-4E2A-B025-4D34BDF8C808", "MATERIALS")
        '    Case 2 : ManageCbo.ManageColors(cboPhotoValueListItem, FormMode.EditRecord)
            Case 3 : cboColorsCat.EditValue = Nothing
        End Select
    End Sub

    Private Sub cmdPrintPhotos_Click(sender As Object, e As EventArgs) Handles cmdPrintPhotos.Click
        CardView1.ShowPrintPreview()
    End Sub

    Private Sub GridView3_PopupMenuShowing(sender As Object, e As PopupMenuShowingEventArgs) Handles GridView3.PopupMenuShowing
        If e.MenuType = GridMenuType.Column Then LoadForms.PopupMenuShow(e, GridView3, "vw_TRANSH_F_SPECIAL_CONSTR_def.xml", "vw_TRANSH_F")
    End Sub
    Private Sub TabPane1_SelectedPageChanged(sender As Object, e As SelectedPageChangedEventArgs) Handles TabPane1.SelectedPageChanged
        Select Case TabPane1.SelectedPageIndex
            Case 1 : If sID IsNot Nothing Then Vw_CCT_ORDERS_PHOTOSTableAdapter.FillByOrderType(DM_CCT.vw_CCT_ORDERS_PHOTOS, 3, System.Guid.Parse(sID))
            Case 2
                LoadForms.RestoreLayoutFromXml(GridView3, "vw_TRANSH_F_SPECIAL_CONSTR_def.xml")
                TRANSH_FTableAdapter.FillByTranshID(DM_TRANS.TRANSH_F, System.Guid.Parse(cboTRANSH.EditValue.ToString))
        End Select

    End Sub
    Private Sub cboCompany_EditValueChanged(sender As Object, e As EventArgs) Handles cboCompany.EditValueChanged
        If Mode = FormMode.NewRecord Then CUSOfferOrderSpecialConstr.FillCompanyProjects(lkupEditValue(cboCompany), chkGenOffer.CheckState, "")
    End Sub


    Private Sub cmdCollection_Click(sender As Object, e As EventArgs) Handles cmdCompCollection.Click
        If cboCompProject.EditValue Is Nothing Then XtraMessageBox.Show("Δεν έχετε επιλέξει έργο", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error) : Exit Sub
        Dim Frm As frmTransactions = New frmTransactions()
        Frm.Text = "Είσπραξη Πελάτη"
        Frm.CreditOnly = True
        Frm.Mode = FormMode.EditRecord
        Frm.ID = cboCompProject.EditValue.ToString
        Frm.isCompany = True
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
        Dim sCusID As String, scompTrashID As String
        If cboCUS.EditValue Is Nothing Then sCusID = toSQLValueS(Guid.Empty.ToString) Else sCusID = toSQLValueS(cboCUS.EditValue.ToString)
        If cboCompProject.EditValue Is Nothing Then scompTrashID = "IS NULL" Else scompTrashID = " = " & toSQLValueS(cboCompProject.EditValue.ToString)
        Dim sSQL As New System.Text.StringBuilder
        sSQL.AppendLine("Select T.id,FullTranshDescription,Description,Iskitchen,Iscloset,Isdoor,Issc
                        from vw_TRANSH t
                        INNER JOIN TRANSC on transc.transhID = t.id and TRANSC.transhcID = 'AE5476D4-2152-4B20-87BB-7933B0215D04' 
                        where  completed = 0  and T.cusid = " & sCusID & " and T.compTrashID  " & scompTrashID & " order by description")
        FillCbo.TRANSH(cboTRANSH, sSQL)
    End Sub

    Private Sub chkGenOffer_CheckedChanged(sender As Object, e As EventArgs) Handles chkGenOffer.CheckedChanged
        If chkGenOffer.CheckState = CheckState.Checked Then
            cboCUS.Enabled = False : cboTRANSH.Enabled = False
            cboCUS.EditValue = cboCompany.EditValue
            cboTRANSH.EditValue = cboCompProject.EditValue
        Else
            cboCUS.Enabled = True : cboTRANSH.Enabled = True
        End If
    End Sub
    Private Sub cmdSaveTransF_Click(sender As Object, e As EventArgs) Handles cmdSaveTransF.Click
        XtraOpenFileDialog1.Tag = cboTanshFCategory.EditValue.ToString
        CUSOfferOrderSpecialConstr.SaveRecordF(0)
    End Sub
    Private Sub txtFiles_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles txtFiles.ButtonClick
        Dim sFilename As String
        Select Case e.Button.Index
            Case 0
                Dim result = XtraInputBox.Show("Πληκτρολογήστε το πλήθος σελίδων που θα σκανάρετε", "Όνομα Αρχείου", "1")
                ScanFile = New ScanToPDF
                If ScanFile.Scan(sFilename, Me.VwSCANFILENAMESBindingSource, result) = False Then Exit Sub
                txtFiles.EditValue = sFilename
                If txtFiles.Text <> "" Then CUSOfferOrderSpecialConstr.SaveRecordF(1, sFilename)
                ScanFile = Nothing
            Case 1 : FilesSelection(XtraOpenFileDialog1, txtFiles)

            Case 2 : txtFiles.EditValue = Nothing
        End Select
    End Sub
    Private Sub cmdPrivateAgreement_Click(sender As Object, e As EventArgs) Handles cmdPrivateAgreement.Click
        Dim frmPrivateAgreement As frmCUSPrivateAgreement = New frmCUSPrivateAgreement()
        Dim AgreementID As String
        Dim sTranshID As Guid
        With frmPrivateAgreement
            .Company = cboCompany.EditValue
            .CompProject = cboCompProject.EditValue
            .CUS = cboCUS.EditValue
            sTranshID = System.Guid.Parse(cboTRANSH.EditValue.ToString)
            .TRANSH = sTranshID
            .EMP = cboEMP.EditValue
            .Text = "Ιδ. Συμφωνητικό"
            If AgreementExist(AgreementID) Then .Mode = FormMode.EditRecord Else .Mode = FormMode.NewRecord
            .ID = AgreementID
            .ShowDialog()
        End With
    End Sub
    ' Έλεγχος αν υτπάρχει συφωνητικό για την Ντουλάπα
    Private Function AgreementExist(ByRef AgreementID As String) As Boolean
        Dim cmd As SqlCommand
        Dim sdr As SqlDataReader
        Try
            cmd = New SqlCommand("  select  id from Agreement where sc = 1 and transhID =  " & toSQLValueS(cboTRANSH.EditValue.ToString), CNDB)
            sdr = cmd.ExecuteReader()
            If (sdr.Read() = True) Then
                AgreementID = sdr.GetGuid(sdr.GetOrdinal("id")).ToString()
                sdr.Close() : Return True
            Else
                sdr.Close() : Return False
            End If
        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
            sdr.Close()
        End Try
    End Function
    Private Sub ApplyDiscount(ByVal DiscMode As Integer, Optional ByVal DiscountChangedByUser As Boolean = False)
        Dim Disc As Double, Discount As Double, InitialPrice As Double, FinalPrice1 As Double, FinalPrice2 As Double, FinalPrice3 As Double, FinalPrice4 As Double, VatPrice As Double
        Dim TotAmt As Double
        If Me.IsActive = False Then Exit Sub
        Select Case DiscMode
            Case 1
                If DiscountChangedByUser = False Then txtDisc1.EditValue = ProgProps.CusDiscountSpecial
                InitialPrice = txtInitialPrice1.EditValue.ToString.Replace(".", ",")
                If DiscountChangedByUser = False Then Disc = ProgProps.CusDiscountSpecial / 100 Else Disc = txtDisc1.EditValue / 100
                Discount = Disc * InitialPrice
                FinalPrice1 = InitialPrice - Discount
                FinalPrice1 = FinalPrice1 + (FinalPrice1 * (ProgProps.VAT / 100))
                VatPrice = InitialPrice - Discount
                txtInitialPrice1.EditValue = InitialPrice
                txtDiscount1.EditValue = Discount
                txtFinalPrice1.EditValue = FinalPrice1
                txtVatPrice1.EditValue = VatPrice
            Case 2
                If DiscountChangedByUser = False Then txtDisc2.EditValue = ProgProps.CusDiscountSpecial
                InitialPrice = txtInitialPrice2.EditValue.ToString.Replace(".", ",")
                If DiscountChangedByUser = False Then Disc = ProgProps.CusDiscountSpecial / 100 Else Disc = txtDisc2.EditValue / 100
                Discount = Disc * InitialPrice
                FinalPrice2 = InitialPrice - Discount
                FinalPrice2 = FinalPrice2 + (FinalPrice2 * (ProgProps.VAT / 100))
                VatPrice = InitialPrice - Discount
                txtInitialPrice2.EditValue = InitialPrice
                txtDiscount2.EditValue = Discount
                txtFinalPrice2.EditValue = FinalPrice2
                txtVatPrice2.EditValue = VatPrice
            Case 3
                If DiscountChangedByUser = False Then txtDisc3.EditValue = ProgProps.CusDiscountSpecial
                InitialPrice = txtInitialPrice3.EditValue.ToString.Replace(".", ",")
                If DiscountChangedByUser = False Then Disc = ProgProps.CusDiscountSpecial / 100 Else Disc = txtDisc3.EditValue / 100
                Discount = Disc * InitialPrice
                FinalPrice3 = InitialPrice - Discount
                FinalPrice3 = FinalPrice3 + (FinalPrice3 * (ProgProps.VAT / 100))
                VatPrice = InitialPrice - Discount
                txtInitialPrice3.EditValue = InitialPrice
                txtDiscount3.EditValue = Discount
                txtFinalPrice3.EditValue = FinalPrice3
                txtVatPrice3.EditValue = VatPrice
            Case 4
                If DiscountChangedByUser = False Then txtDisc4.EditValue = ProgProps.CusDiscountSpecial
                InitialPrice = txtInitialPrice4.EditValue.ToString.Replace(".", ",")
                If DiscountChangedByUser = False Then Disc = ProgProps.CusDiscountSpecial / 100 Else Disc = txtDisc4.EditValue / 100
                Discount = Disc * InitialPrice
                FinalPrice4 = InitialPrice - Discount
                FinalPrice4 = FinalPrice4 + (FinalPrice4 * (ProgProps.VAT / 100))
                VatPrice = InitialPrice - Discount
                txtInitialPrice4.EditValue = InitialPrice
                txtDiscount4.EditValue = Discount
                txtFinalPrice4.EditValue = FinalPrice4
                txtVatPrice4.EditValue = VatPrice
        End Select
        CalculateTotAmt()
    End Sub
    Private Sub CalculateTotAmt()
        Dim SCVat As Double, TotAmt As Double
        Dim ExtraInst As Double = DbnullToZero(txtExtraInst)                'Τοποθέτηση
        Dim ExtraTransp As Double = DbnullToZero(txtExtraTransp)            'Μεταφορά
        Dim PartofVat As Double = DbnullToZero(txtPartofVat)                'Συμφωνηθέν ΦΠΑ
        Dim TotalDoorsPrice As Double = DbnullToZero(txtTotalSpecialPrice)  'Συνολική Αξία με ΦΠΑ
        'Τελικές Τιμές Πορτών
        Dim FinalPrice1 As Double = DbnullToZero(txtFinalPrice1)
        Dim FinalPrice2 As Double = DbnullToZero(txtFinalPrice2)
        Dim FinalPrice3 As Double = DbnullToZero(txtFinalPrice3)
        Dim FinalPrice4 As Double = DbnullToZero(txtFinalPrice4)
        TotalDoorsPrice = ExtraInst + ExtraTransp + FinalPrice1 + FinalPrice2 + FinalPrice3 + FinalPrice4
        SCVat = TotalDoorsPrice / ProgProps.AlternateVAT
        TotAmt = IIf(PartofVat > 0, SCVat + PartofVat, TotalDoorsPrice)
        'Συνολική Αξία ΠΡΟ ΦΠΑ
        txtTotalSpecialVat.EditValue = SCVat
        'Συνολική Αξία ΜΕ ΦΠΑ
        txtTotalSpecialPrice.EditValue = TotAmt
        'Γενικό σύνολο Πώλησης
        txtTotAmt.EditValue = TotAmt
    End Sub
    Private Sub txtInitialPrice1_EditValueChanged(sender As Object, e As EventArgs) Handles txtInitialPrice1.EditValueChanged
        If DirectCast(e, DevExpress.XtraEditors.Controls.ChangingEventArgs).OldValue IsNot Nothing And DirectCast(e, DevExpress.XtraEditors.Controls.ChangingEventArgs).OldValue <> DirectCast(e, DevExpress.XtraEditors.Controls.ChangingEventArgs).NewValue Then ApplyDiscount(1)
    End Sub

    Private Sub txtInitialPrice2_EditValueChanged(sender As Object, e As EventArgs) Handles txtInitialPrice2.EditValueChanged
        If DirectCast(e, DevExpress.XtraEditors.Controls.ChangingEventArgs).OldValue IsNot Nothing And DirectCast(e, DevExpress.XtraEditors.Controls.ChangingEventArgs).OldValue <> DirectCast(e, DevExpress.XtraEditors.Controls.ChangingEventArgs).NewValue Then ApplyDiscount(2)
    End Sub

    Private Sub txtInitialPrice3_EditValueChanged(sender As Object, e As EventArgs) Handles txtInitialPrice3.EditValueChanged
        If DirectCast(e, DevExpress.XtraEditors.Controls.ChangingEventArgs).OldValue IsNot Nothing And DirectCast(e, DevExpress.XtraEditors.Controls.ChangingEventArgs).OldValue <> DirectCast(e, DevExpress.XtraEditors.Controls.ChangingEventArgs).NewValue Then ApplyDiscount(3)
    End Sub

    Private Sub txtInitialPrice4_EditValueChanged(sender As Object, e As EventArgs) Handles txtInitialPrice4.EditValueChanged
        If DirectCast(e, DevExpress.XtraEditors.Controls.ChangingEventArgs).OldValue IsNot Nothing And DirectCast(e, DevExpress.XtraEditors.Controls.ChangingEventArgs).OldValue <> DirectCast(e, DevExpress.XtraEditors.Controls.ChangingEventArgs).NewValue Then ApplyDiscount(4)
    End Sub
    Private Sub txtExtraInst_EditValueChanged(sender As Object, e As EventArgs) Handles txtExtraInst.EditValueChanged
        CalculateTotAmt()
    End Sub

    Private Sub txtExtraTransp_EditValueChanged(sender As Object, e As EventArgs) Handles txtExtraTransp.EditValueChanged
        CalculateTotAmt()
    End Sub

    Private Sub txtPartofVat_EditValueChanged(sender As Object, e As EventArgs) Handles txtPartofVat.EditValueChanged
        CalculateTotAmt()
    End Sub
    Private Sub cboTanshFCategory_ButtonPressed(sender As Object, e As ButtonPressedEventArgs) Handles cboTanshFCategory.ButtonPressed
        Select Case e.Button.Index
            Case 1 : cboTanshFCategory.EditValue = Nothing : ManageCbo.ManageFCategory(cboTanshFCategory, FormMode.NewRecord)
            Case 2 : If cboTanshFCategory.EditValue IsNot Nothing Then ManageCbo.ManageFCategory(cboTanshFCategory, FormMode.EditRecord)
            Case 3 : cboTanshFCategory.EditValue = Nothing
        End Select

    End Sub
    Private Sub cmdOrder_Click(sender As Object, e As EventArgs) Handles cmdOrder.Click
        Dim frmCUSOfferOrderSpecialConstr As frmCUSOfferOrderSpecialConstr = New frmCUSOfferOrderSpecialConstr()
        frmCUSOfferOrderSpecialConstr.ID = sOrderID
        frmCUSOfferOrderSpecialConstr.Mode = FormMode.EditRecord
        frmCUSOfferOrderSpecialConstr.IsOrder = True
        frmCUSOfferOrderSpecialConstr.Text = "Έντυπο Παραγγελίας Πελατών(Ειδικές Κατασκευές)"
        frmCUSOfferOrderSpecialConstr.ShowDialog()
    End Sub

    Private Sub cboCompProject_EditValueChanged(sender As Object, e As EventArgs) Handles cboCompProject.EditValueChanged
        If Mode = FormMode.NewRecord Then CUSOfferOrderSpecialConstr.FillCusTransh(lkupEditValue(cboCUS), lkupEditValue(cboCompProject), chkGenOffer.CheckState, "")
        If DirectCast(e, DevExpress.XtraEditors.Controls.ChangingEventArgs).NewValue IsNot Nothing And chkGenOffer.CheckState = CheckState.Checked Then cmdCompCollection.Enabled = True Else cmdCompCollection.Enabled = False
    End Sub
    Private Sub chkGenOffer_CheckStateChanged(sender As Object, e As EventArgs) Handles chkGenOffer.CheckStateChanged
        If chkGenOffer.CheckState = CheckState.Checked Then cmdCompCollection.Enabled = True : cmdCusCollection.Enabled = False Else cmdCompCollection.Enabled = False : cmdCusCollection.Enabled = True
    End Sub
    Private Sub cboTRANSH_EditValueChanged(sender As Object, e As EventArgs) Handles cboTRANSH.EditValueChanged
        receiveAgreement = cboTRANSH.GetColumnValue("receiveAgreement")
        If DirectCast(e, DevExpress.XtraEditors.Controls.ChangingEventArgs).NewValue IsNot Nothing Then cmdCusCollection.Enabled = True Else cmdCusCollection.Enabled = False
    End Sub

    Private Sub cboCUS_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboCUS.ButtonClick
        Select Case e.Button.Index
            Case 1 : ManageCbo.ManageCCT(FormMode.NewRecord, False,, cboCUS)
            Case 2 : ManageCbo.ManageCCT(FormMode.EditRecord, False,, cboCUS)
            Case 3 : cboCUS.EditValue = Nothing : cmdCusCollection.Enabled = False
        End Select
    End Sub
    Private Sub cboCompProject_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboCompProject.ButtonClick
        Select Case e.Button.Index
            Case 1
                If cboEMP.Text = "" Then XtraMessageBox.Show("Δεν έχετε επιλέξει πωλητή", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error) : Exit Sub
                ManageCbo.ManageTRANSHSmall(cboCompProject, FormMode.NewRecord, cboCompany.EditValue, True, cboEMP.EditValue, cboCompany.EditValue, cboCompProject.EditValue, 1, sIsOrder, System.Guid.Parse("AE5476D4-2152-4B20-87BB-7933B0215D04"))
            Case 2 : If cboCompProject.EditValue IsNot Nothing Then ManageCbo.ManageTRANSHSmall(cboCompProject, FormMode.EditRecord, cboCompany.EditValue, True,,,,, sIsOrder)
            Case 3 : cboCompProject.EditValue = Nothing : cmdCompCollection.Enabled = False
        End Select
    End Sub

    Private Sub cboCompany_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboCompany.ButtonClick
        Select Case e.Button.Index
            Case 1 : ManageCbo.ManageCCT(FormMode.NewRecord, False,, cboCompany)
            Case 2 : ManageCbo.ManageCCT(FormMode.EditRecord, False,, cboCompany)
            Case 3 : cboCompany.EditValue = Nothing : LCompProject.ImageOptions.Image = Nothing : cmdCompCollection.Enabled = False
        End Select
    End Sub

End Class