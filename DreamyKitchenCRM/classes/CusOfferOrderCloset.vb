Imports DevExpress.XtraEditors
Imports DevExpress.XtraLayout
Imports DevExpress.XtraReports.UI
Imports System.Data.SqlClient
Public Class CusOfferOrderCloset
    Private FillCbo As New FillCombos
    Private Valid As New ValidateControls
    Private Cls As New ClearControls
    Private ID As String
    Private sIsOrder As Boolean
    Private Mode As Byte
    Private CalledFromCtrl As Boolean
    Private CtrlCombo As DevExpress.XtraEditors.LookUpEdit
    Private DBQ As New DBQueries
    Private LoadForms As New FormLoader
    Private Frm As frmCUSOfferOrderCloset
    Private Prog_Prop As New ProgProp
    Private isCustomer As Boolean
    Public Sub Initialize(ByVal sFrm As frmCUSOfferOrderCloset, ByVal sID As String, ByVal sMode As Byte, ByVal sCalledFromCtrl As Boolean, ByVal sCtrlCombo As DevExpress.XtraEditors.LookUpEdit, ByVal IsOrder As Boolean)
        Frm = sFrm
        ID = sID
        Mode = sMode
        CalledFromCtrl = sCalledFromCtrl
        CtrlCombo = sCtrlCombo
        sIsOrder = IsOrder
        Prog_Prop.GetProgPROSF()
        Frm.Vw_COMPTableAdapter.Fill(Frm.DM_CCT.vw_COMP)
        Frm.Vw_VALUELISTITEMModelClosetTableAdapter.Fill(Frm.DM_VALUELISTITEM.vw_VALUELISTITEMModelCloset)
        Frm.CCT_TRANSHTableAdapter.Fill(Frm.DM_TRANS.CCT_TRANSH)
        Frm.Vw_CCTTableAdapter.Fill(Frm.DreamyKitchenDataSet.vw_CCT)
        Frm.Vw_VALUELISTITEM_V2TableAdapter.Fill(Frm.DM_VALUELISTITEM.vw_VALUELISTITEM_V2)
        Frm.CCT_TRANSHTableAdapter.Fill(Frm.DM_TRANS.CCT_TRANSH)
        Frm.Vw_SALERSTableAdapter.Fill(Frm.DreamyKitchenDataSet.vw_SALERS)
        Frm.Vw_COLORS_CATTableAdapter.Fill(Frm.DreamyKitchenDataSet.vw_COLORS_CAT)
        Frm.Vw_SUPTableAdapter.Fill(Frm.DreamyKitchenDataSet.vw_SUP)
        If ID IsNot Nothing Then Frm.Vw_CCT_ORDERS_PHOTOSTableAdapter.FillByOrderType(Frm.DM_CCT.vw_CCT_ORDERS_PHOTOS, 1, System.Guid.Parse(ID))
        If sIsOrder = True Then
            Frm.LOrderDetailsGroup.Text = "Στοιχεία Παραγγελίας"
            Frm.LdtOrder.Text = "Ημερ/νία Παραγγελίας"
            Frm.LCost1Group.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
            Frm.LCost2Group.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
            Frm.LCost3Group.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
            Frm.LCost4Group.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
            Frm.LCost5Group.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
            Frm.LConvertToOrder.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
            Frm.LofferAccepted.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
            Frm.LGenOffer.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
            Frm.LNewRecord.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
            Frm.LOrder.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        Else
            Frm.LOrderDetailsGroup.Text = "Στοιχεία Προσφοράς"
            Frm.LdtOrder.Text = "Ημερ/νία Προσφοράς"
            Frm.LarProt.Text = "Αρ. Προσφοράς"
            Frm.LCost.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
            Frm.LPrivateAgreement.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
            Frm.LOrder.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
            Frm.TabNavigationPage3.PageVisible = False
            Frm.TabNavigationPage4.PageVisible = False
        End If
    End Sub
    Public Sub LoadForm()



        Select Case Mode
            Case FormMode.NewRecord
                LoadEquipments()
                Frm.txtarProt.Text = DBQ.GetNextId("CCT_ORDERS_CLOSET")
                Frm.cboEMP.EditValue = System.Guid.Parse(UserProps.ID.ToString.ToUpper)
                Frm.txtdtdaysOfDelivery.EditValue = ProgProps.DAYS_OF_DELIVERY
                Frm.cmdPrintOffer.Enabled = False
                If sIsOrder = True Then
                    Frm.txtdrawers.EditValue = ProgProps.CLOSET_DRAWERS
                    Frm.cboBackThikness2.EditValue = ProgProps.CLOSET_BACK_THIKNESS
                    Frm.cboboxThikness2.EditValue = ProgProps.CLOSET_BOX_THIKNESS
                    Frm.txtdrawers2.EditValue = ProgProps.CLOSET_DRAWERS
                    Frm.cboBackThikness3.EditValue = ProgProps.CLOSET_BACK_THIKNESS
                    Frm.cboboxThikness3.EditValue = ProgProps.CLOSET_BOX_THIKNESS
                    Frm.txtdrawers3.EditValue = ProgProps.CLOSET_DRAWERS
                    Frm.cboBackThikness4.EditValue = ProgProps.CLOSET_BACK_THIKNESS
                    Frm.cboboxThikness4.EditValue = ProgProps.CLOSET_BOX_THIKNESS
                    Frm.txtdrawers4.EditValue = ProgProps.CLOSET_DRAWERS
                    Frm.cboBackThikness5.EditValue = ProgProps.CLOSET_BACK_THIKNESS
                    Frm.cboboxThikness5.EditValue = ProgProps.CLOSET_BOX_THIKNESS
                    Frm.txtdrawers5.EditValue = ProgProps.CLOSET_DRAWERS
                    Frm.cboBackThikness6.EditValue = ProgProps.CLOSET_BACK_THIKNESS
                    Frm.cboboxThikness6.EditValue = ProgProps.CLOSET_BOX_THIKNESS
                    Frm.txtdrawers6.EditValue = ProgProps.CLOSET_DRAWERS
                    Frm.cboBackThikness.EditValue = ProgProps.CLOSET_BACK_THIKNESS
                    Frm.cboboxThikness.EditValue = ProgProps.CLOSET_BOX_THIKNESS
                Else
                    Frm.txtNotes.EditValue = ProgProps.CUS_NOTES
                    Frm.txtdrawers.EditValue = ProgProps.DRAWERS
                    Frm.txtdrawers2.EditValue = ProgProps.DRAWERS
                    Frm.txtdrawers3.EditValue = ProgProps.DRAWERS
                    Frm.txtdrawers4.EditValue = ProgProps.DRAWERS
                    Frm.txtdrawers5.EditValue = ProgProps.DRAWERS
                    Frm.txtdrawers6.EditValue = ProgProps.DRAWERS
                    Frm.cmdOrder.Enabled = False
                End If

                Frm.TabNavigationPage2.Enabled = False
                Frm.LConvertToOrder.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
            Case FormMode.EditRecord
                Dim sFields As New Dictionary(Of String, String)
                If sIsOrder = False Then
                    LoadForms.LoadForm(Frm.LayoutControl1, "Select [ORDER].id as OrderID,[OFFER].*,OFFER_F.filename " &
                                                   " from CCT_ORDERS_CLOSET  [OFFER] " &
                                                   " left join CCT_ORDERS_CLOSET  [ORDER] on [ORDER].CreatedFromOfferID =  [OFFER].id " &
                                                   " left join TRANSH_F  OFFER_F on OFFER_F.ownerID =  [OFFER].ID " &
                                                   " where [OFFER].id = " & toSQLValueS(ID), sFields)

                    If sFields("OrderID") <> "" Then
                        Frm.orderID = sFields("OrderID")
                        Frm.LConvertToOrder.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
                        Frm.cmdSave.Enabled = False : Frm.cmdSaveEquipDev.Enabled = False
                        Frm.LblMsg.Text = "Δεν μπορείτε να κάνετε αλλαγές στην προσφορά γιατί έχει δημιουργηθεί παραγγελία."
                    Else
                        Frm.cmdOrder.Enabled = False
                    End If
                Else
                    LoadForms.LoadForm(Frm.LayoutControl1, "Select [ORDER].id as OrderID,[ORDER].*,ORDER_F.filename 
                                                        from CCT_ORDERS_CLOSET [ORDER]
                                                        left join CCT_ORDERS_CLOSET  [OFFER] on [OFFER].CreatedFromOfferID =  [ORDER].id  
                                                        left join TRANSH_F  ORDER_F on ORDER_F.ownerID =  [ORDER].ID where [ORDER].id = " & toSQLValueS(ID), sFields)
                    'cmdConvertToOrder.Enabled = False
                    Frm.LConvertToOrder.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
                    If sFields("CreatedFromOfferID") <> "" Then
                        Frm.cboCUS.Enabled = False
                        Frm.cboCompany.Enabled = False
                        Frm.cboCompProject.Enabled = False
                        Frm.cboCompProject.Properties.Buttons.Item(0).Enabled = False
                        Frm.cboCompProject.Properties.Buttons.Item(1).Enabled = False
                        Frm.cboCompProject.Properties.Buttons.Item(3).Enabled = False
                        Frm.cboTRANSH.ReadOnly = True
                        Frm.cboTRANSH.Properties.Buttons.Item(0).Enabled = False
                        Frm.cboTRANSH.Properties.Buttons.Item(1).Enabled = False
                        Frm.cboTRANSH.Properties.Buttons.Item(3).Enabled = False
                    End If

                End If


                If Frm.cboCompany.EditValue Is Nothing Then Frm.cmdCompCollection.Enabled = False
                Frm.TabNavigationPage2.Enabled = True
                If sFields("GenOffer") = "" Then sFields("GenOffer") = False
                FillCusTransh(sFields("cusID"), sFields("compTrashID"), sFields("GenOffer"), sFields("transhID")) : FillCompanyProjects(sFields("compID"), sFields("GenOffer"), sFields("compTrashID"))
                sFields = Nothing
                If Frm.chkGenOffer.CheckState = CheckState.Checked Or Frm.cboCUS.EditValue = Frm.cboCompany.EditValue Then isCustomer = False Else isCustomer = True
                If isCustomer Then Frm.cmdCompCollection.Enabled = False

        End Select
    End Sub
    Public Sub LoadEquipments()
        If Mode = FormMode.NewRecord Then
            LoadForms.LoadDataToGrid(Frm.grdEquipment, Frm.GridView2,
                    "Select  e.ID,E.code,name,price,e.price as defPrice,
                    cast(case when (SELECT FLdVAL FROM PRM_DET WHERE TBL='EQUIPMENT' AND fld='ID' AND fldVal=e.id) is null then 0 else 1 end as bit) as  checked, 
                    case when (SELECT FLdVAL FROM PRM_DET WHERE TBL='EQUIPMENT' AND fld='ID' AND fldVal=e.id) is null then 0 else 1 end AS QTY,standard 
                    From vw_EQUIPMENT E where equipmentCatID='DB158CAB-11EA-423B-9430-0C8A0CEB1D62' ORDER BY NAME")

        Else
            LoadForms.LoadDataToGrid(Frm.grdEquipment, Frm.GridView2,
                    "select e.ID,e.code,e.name,
                    isnull((select price from CCT_ORDERS_CLOSET_EQUIPMENT EQ where eq.cctOrdersClosetID= " & toSQLValueS(ID) & " And eq.equipmentID=e.id),e.price ) as price,
                    e.price as defPrice,
                    CAST(CASE WHEN (select eq.ID 
                    from CCT_ORDERS_CLOSET_EQUIPMENT EQ 
                    where eq.cctOrdersClosetID= " & toSQLValueS(ID) & " and eq.equipmentID=e.id) IS NULL THEN 0 ELSE 1 END AS BIT ) as checked,
                    isnull((select qty from CCT_ORDERS_CLOSET_EQUIPMENT EQ where eq.cctOrdersClosetID= " & toSQLValueS(ID) & " and eq.equipmentID=e.id),0) as QTY,standard
                    from EQUIPMENT E
                    where equipmentCatID='DB158CAB-11EA-423B-9430-0C8A0CEB1D62'
                    ORDER BY NAME")
        End If
        LoadForms.RestoreLayoutFromXml(Frm.GridView2, "CCT_ORDERS_CLOSET_EQUIPMENT_def.xml")
    End Sub
    Public Sub SaveRecord(ByRef sID As String)
        Dim sResult As Boolean
        Dim sGuid As String
        Try
            If Valid.ValidateForm(Frm.LayoutControl1) Then
                Valid.ID = Frm.cboTRANSH.EditValue.ToString
                If Valid.ValiDationRules(Frm.Name, Frm) = False Then Exit Sub
                Select Case Mode
                    Case FormMode.NewRecord
                        sGuid = System.Guid.NewGuid.ToString
                        Dim sDate As String = Frm.lblDate.Text.Replace("Ημερομηνία Παράδοσης: ", "")
                        sResult = DBQ.InsertNewData(DBQueries.InsertMode.OneLayoutControl, "CCT_ORDERS_CLOSET", Frm.LayoutControl1,,, sGuid, , "dtDeliver,IsOrder,TotAmt", toSQLValueS(CDate(sDate).ToString("yyyyMMdd")) & "," & IIf(sIsOrder = True, 1, 0) & "," & toSQLValue(Frm.txtTotAmt, True))
                        ID = sGuid : sID = sGuid
                    Case FormMode.EditRecord
                        Dim sDate As String = Frm.lblDate.Text.Replace("Ημερομηνία Παράδοσης: ", "")
                        sResult = DBQ.UpdateNewData(DBQueries.InsertMode.OneLayoutControl, "CCT_ORDERS_CLOSET", Frm.LayoutControl1,,, sID,,,,, "dtDeliver=" & toSQLValueS(CDate(sDate).ToString("yyyyMMdd")) & ",IsOrder = " & IIf(sIsOrder = True, 1, 0) & ",TotAmt = " & toSQLValue(Frm.txtTotAmt, True))
                        ID = sID
                End Select

                If sResult = True Then
                    If Mode = FormMode.NewRecord Then
                        Frm.TabNavigationPage2.Enabled = True
                        If sIsOrder = False Then
                            Frm.cmdConvertToOrder.Enabled = True
                            Frm.LConvertToOrder.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
                            Frm.LOrder.Visibility = Utils.LayoutVisibility.Always
                        End If
                        Frm.cmdPrintOffer.Enabled = True
                        InsertSelectedRows(False)
                    End If
                    Dim Projects As New Projects
                    Projects.CalculateTotAmtAndBal(Frm.cboTRANSH.EditValue.ToString, sIsOrder)
                    Mode = FormMode.EditRecord
                    XtraMessageBox.Show("Η εγγραφή αποθηκέυτηκε με επιτυχία", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Public Sub SaveRecordF(ByVal sMode As Integer, Optional ByVal sFilename As String = "")
        Dim sResultF As Boolean
        If Frm.cboTanshFCategory.EditValue = Nothing Then XtraMessageBox.Show("Δεν έχετε επιλέξει Κατηγορία.", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error) : Exit Sub
        If Frm.txtFiles.Text = "" Then XtraMessageBox.Show("Δεν έχετε επιλέξει Αρχείο.", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error) : Exit Sub
        Select Case sMode
            Case 0 : sResultF = DBQ.InsertDataFiles(Frm.XtraOpenFileDialog1, Frm.cboTRANSH.EditValue.ToString, "TRANSH_F", ID, "Παραγγελία")
            Case 1 : sResultF = DBQ.InsertDataFilesFromScanner(sFilename, Frm.cboTRANSH.EditValue.ToString, "TRANSH_F", Frm.cboTanshFCategory.EditValue.ToString, ID, "Παραγγελία")
        End Select
        Frm.txtFiles.EditValue = Nothing
        Frm.TRANSH_FTableAdapter.FillByTranshID(Frm.DM_TRANS.TRANSH_F, System.Guid.Parse(Frm.cboTRANSH.EditValue.ToString))


    End Sub
    Public Sub InsertSelectedRows(Optional ByVal msg As Boolean = True)
        Dim sSQL As String
        Dim I As Integer
        sSQL = "DELETE FROM CCT_ORDERS_CLOSET_EQUIPMENT WHERE cctOrdersClosetID = " & toSQLValueS(ID)
        Using oCmd As New SqlCommand(sSQL, CNDB)
            oCmd.ExecuteNonQuery()
        End Using
        Dim Selected As Boolean
        For I = 0 To Frm.GridView2.RowCount - 1
            Selected = Frm.GridView2.GetRowCellValue(I, "checked")
            If Selected = True Then
                sSQL = "INSERT INTO CCT_ORDERS_CLOSET_EQUIPMENT(cctOrdersClosetID,equipmentID,price,selected,qty) " &
                    " VALUES ( " & toSQLValueS(ID) & "," & toSQLValueS(Frm.GridView2.GetRowCellValue(I, "ID").ToString) & "," & toSQLValueS(Frm.GridView2.GetRowCellValue(I, "price").ToString, True) & ",1," & toSQLValueS(Frm.GridView2.GetRowCellValue(I, "QTY").ToString, True) & ")"
                Using oCmd As New SqlCommand(sSQL, CNDB)
                    oCmd.ExecuteNonQuery()
                End Using
            End If
        Next
        If msg Then XtraMessageBox.Show("Η εγγραφή αποθηκέυτηκε με επιτυχία", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub
    Public Sub PrintOfferOrder()
        If sIsOrder = True Then
            Dim report As New RepCUSOrderCloset()

            report.Parameters.Item(0).Value = ID
            report.CreateDocument()
            Dim report2 As New RepCUSOrderCloset2ndPage

            report2.Parameters.Item(0).Value = ID
            report2.CreateDocument()
            report.ModifyDocument(Sub(x)
                                      x.AddPages(report2.Pages)
                                  End Sub)
            Dim printTool As New ReportPrintTool(report)
            printTool.ShowRibbonPreview()
        Else
            Dim report As New RepCUSOfferCloset()

            report.Parameters.Item(0).Value = ID
            report.CreateDocument()
            Dim report2 As New RepCUSOfferCloset2ndPage

            report2.Parameters.Item(0).Value = ID
            report2.CreateDocument()
            report.ModifyDocument(Sub(x)
                                      x.AddPages(report2.Pages)
                                  End Sub)
            Dim report3 As New RepCUSOfferCloset3ndPage
            report3.CreateDocument()
            report.ModifyDocument(Sub(x)
                                      x.AddPages(report3.Pages)
                                  End Sub)
            Dim printTool As New ReportPrintTool(report)
            printTool.ShowRibbonPreview()
        End If
    End Sub
    Public Sub ConvertToOrder()
        Try
            Dim OrderID As String
            Valid.ID = Frm.cboTRANSH.EditValue.ToString
            If Frm.cboCompProject.EditValue IsNot Nothing Then Valid.compTrashID = Frm.cboCompProject.EditValue.ToString
            If Valid.ValiDationRules(Frm.Name, Frm, True) = False Then Exit Sub
            If XtraMessageBox.Show("Θέλετε να μετατραπεί σε παραγγελία η προσφορά ?", ProgProps.ProgTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                Using oCmd As New SqlCommand("ConvertToOrder", CNDB)
                    oCmd.CommandType = CommandType.StoredProcedure
                    oCmd.Parameters.AddWithValue("@OfferID", ID)
                    oCmd.Parameters.AddWithValue("@createdBy", UserProps.ID)
                    oCmd.Parameters.AddWithValue("@Mode", 2)
                    oCmd.Parameters.Add("@OrderID", SqlDbType.UniqueIdentifier)
                    oCmd.Parameters("@OrderID").Direction = ParameterDirection.Output
                    oCmd.ExecuteNonQuery()
                    OrderID = oCmd.Parameters("@OrderID").Value.ToString
                End Using

                XtraMessageBox.Show("Η μετατροπή ολοκληρώθηκε με επιτυχία", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Frm.orderID = OrderID
                'cmdConvertToOrder.Enabled = False
                Frm.cmdSave.Enabled = False : Frm.cmdSaveEquipDev.Enabled = False
                Frm.LConvertToOrder.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
                Frm.LblMsg.Text = "Δεν μπορείτε να κάνετε αλλαγές στην προσφορά γιατί έχει δημιουργηθεί παραγγελία."
                Frm.cmdOrder.Enabled = True
                If XtraMessageBox.Show("Θέλετε να δείτε την παραγγελία ?", ProgProps.ProgTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                    Dim frmCUSOfferOrderCloset As frmCUSOfferOrderCloset = New frmCUSOfferOrderCloset()
                    frmCUSOfferOrderCloset.ID = OrderID
                    frmCUSOfferOrderCloset.Mode = FormMode.EditRecord
                    frmCUSOfferOrderCloset.IsOrder = True
                    frmCUSOfferOrderCloset.Text = "Έντυπο Παραγγελίας Πελατών(Ντουλάπα)"
                    frmCUSOfferOrderCloset.ShowDialog()
                End If
            End If
        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Public Sub SavePhotoRecord(ByVal sID As String, ByVal LocalMode As Integer)
        Dim sResult As Boolean
        Dim sGuid As String
        Try
            If Valid.ValidateForm(Frm.LayoutControl3) Then
                Select Case LocalMode
                    Case FormMode.NewRecord
                        sGuid = System.Guid.NewGuid.ToString
                        sResult = DBQ.InsertNewData(DBQueries.InsertMode.OneLayoutControl, "CCT_ORDERS_PHOTOS", Frm.LayoutControl3,,, sGuid, , "orderID,orderType", toSQLValueS(sID) & ",1")
                    Case FormMode.EditRecord
                        sResult = DBQ.UpdateDataCardGRD(Frm.CardView1, "CCT_ORDERS_PHOTOS",, True)
                End Select
                If sResult = True Then
                    XtraMessageBox.Show("Η εγγραφή αποθηκέυτηκε με επιτυχία", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Cls.ClearCtrls(Frm.LayoutControl3)
                    Frm.Vw_CCT_ORDERS_PHOTOSTableAdapter.FillByOrderType(Frm.DM_CCT.vw_CCT_ORDERS_PHOTOS, 1, System.Guid.Parse(sID))
                End If
            End If

        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Public Sub DeletePhotoRecord()
        If Frm.CardView1.GetRowCellValue(Frm.CardView1.FocusedRowHandle, "ID") = Nothing Then Exit Sub
        If XtraMessageBox.Show("Θέλετε να διαγραφεί η τρέχουσα εγγραφή?", ProgProps.ProgTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            Dim sSQL As String = "DELETE FROM CCT_ORDERS_PHOTOS WHERE ID = '" & Frm.CardView1.GetRowCellValue(Frm.CardView1.FocusedRowHandle, "ID").ToString & "'"
            Using oCmd As New SqlCommand(sSQL, CNDB)
                oCmd.ExecuteNonQuery()
            End Using
            Frm.Vw_CCT_ORDERS_PHOTOSTableAdapter.FillByOrderType(Frm.DM_CCT.vw_CCT_ORDERS_PHOTOS, 1, System.Guid.Parse(ID))
        End If
    End Sub
    Public Sub NewRecord()
        Cls.ClearCtrls(Frm.LayoutControl1) : Cls.ClearCtrls(Frm.LayoutControl2)
        Cls.ClearCtrls(Frm.LayoutControl3) : Cls.ClearCtrls(Frm.LayoutControl4)

        Frm.txtarProt.Text = DBQ.GetNextId("CCT_ORDERS_CLOSET")
        Frm.cboEMP.EditValue = System.Guid.Parse(UserProps.ID.ToString.ToUpper)
        Frm.txtdtdaysOfDelivery.EditValue = ProgProps.DAYS_OF_DELIVERY
        If sIsOrder = True Then
            Frm.txtdrawers.EditValue = ProgProps.CLOSET_DRAWERS
            Frm.cboBackThikness2.EditValue = ProgProps.CLOSET_BACK_THIKNESS
            Frm.cboboxThikness2.EditValue = ProgProps.CLOSET_BOX_THIKNESS
            Frm.txtdrawers2.EditValue = ProgProps.CLOSET_DRAWERS
            Frm.cboBackThikness3.EditValue = ProgProps.CLOSET_BACK_THIKNESS
            Frm.cboboxThikness3.EditValue = ProgProps.CLOSET_BOX_THIKNESS
            Frm.txtdrawers3.EditValue = ProgProps.CLOSET_DRAWERS
            Frm.cboBackThikness4.EditValue = ProgProps.CLOSET_BACK_THIKNESS
            Frm.cboboxThikness4.EditValue = ProgProps.CLOSET_BOX_THIKNESS
            Frm.txtdrawers4.EditValue = ProgProps.CLOSET_DRAWERS
            Frm.cboBackThikness5.EditValue = ProgProps.CLOSET_BACK_THIKNESS
            Frm.cboboxThikness5.EditValue = ProgProps.CLOSET_BOX_THIKNESS
            Frm.txtdrawers5.EditValue = ProgProps.CLOSET_DRAWERS
            Frm.cboBackThikness6.EditValue = ProgProps.CLOSET_BACK_THIKNESS
            Frm.cboboxThikness6.EditValue = ProgProps.CLOSET_BOX_THIKNESS
            Frm.txtdrawers6.EditValue = ProgProps.CLOSET_DRAWERS
            Frm.cboBackThikness.EditValue = ProgProps.CLOSET_BACK_THIKNESS
            Frm.cboboxThikness.EditValue = ProgProps.CLOSET_BOX_THIKNESS
        Else
            Frm.txtNotes.EditValue = ProgProps.CUS_NOTES
            Frm.txtdrawers.EditValue = ProgProps.DRAWERS
            Frm.txtdrawers2.EditValue = ProgProps.DRAWERS
            Frm.txtdrawers3.EditValue = ProgProps.DRAWERS
            Frm.txtdrawers4.EditValue = ProgProps.DRAWERS
            Frm.txtdrawers5.EditValue = ProgProps.DRAWERS
            Frm.txtdrawers6.EditValue = ProgProps.DRAWERS
        End If


        LoadForms.LoadDataToGrid(Frm.grdEquipment, Frm.GridView2,
                    "Select  e.ID,E.code,name,price,e.price as defPrice,
                    cast(case when (SELECT FLdVAL FROM PRM_DET WHERE TBL='EQUIPMENT' AND fld='ID' AND fldVal=e.id) is null then 0 else 1 end as bit) as  checked, 
                    case when (SELECT FLdVAL FROM PRM_DET WHERE TBL='EQUIPMENT' AND fld='ID' AND fldVal=e.id) is null then 0 else 1 end AS QTY,standard 
                    From vw_EQUIPMENT E where equipmentCatID='DB158CAB-11EA-423B-9430-0C8A0CEB1D62' ORDER BY NAME"
)
        Frm.TabNavigationPage2.Enabled = False
        Frm.LConvertToOrder.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
    End Sub
    Public Sub FillCompanyProjects(ByVal sCompID As String, ByVal GenOffer As Boolean, ByVal scompTrashID As String)
        If sCompID = "" Then sCompID = toSQLValueS(Guid.Empty.ToString) Else sCompID = toSQLValueS(sCompID)
        Dim sSQL As New System.Text.StringBuilder
        sSQL.AppendLine("Select T.id,FullTranshDescription,Description,Iskitchen,Iscloset,Isdoor,Issc
                        from vw_TRANSH t
                        where  IsCloset = 1 and T.cusid = " & sCompID & "order by description")
        FillCbo.TRANSH(Frm.cboCompProject, sSQL)
        Frm.LCompProject.ImageOptions.Image = Global.DreamyKitchenCRM.My.Resources.Resources.rsz_11rsz_asterisk
        If GenOffer = True Then
            Frm.cboCUS.EditValue = Frm.cboCompany.EditValue
            Frm.cboTRANSH.EditValue = scompTrashID
        End If
        If scompTrashID <> "" Then Frm.cboCompProject.EditValue = System.Guid.Parse(scompTrashID)
    End Sub
    Public Sub FillCusTransh(ByVal sCusID As String, ByVal scompTrashID As String, ByVal GenOffer As Boolean, ByVal sTranshID As String)
        Dim sCompProjectID As String
        If sCusID = "" Then sCusID = toSQLValueS(Guid.Empty.ToString) Else sCusID = toSQLValueS(sCusID)
        If GenOffer = False Then
            If scompTrashID = "" Then sCompProjectID = " and T.compTrashID  IS NULL" Else sCompProjectID = " and T.compTrashID   = " & toSQLValueS(scompTrashID)
        End If
        Dim sSQL As New System.Text.StringBuilder
        sSQL.AppendLine("Select T.id,FullTranshDescription,Description,Iskitchen,Iscloset,Isdoor,Issc,AgreementExist,AgreementID,Totamt
                        from vw_TRANSH t
                        INNER JOIN TRANSC on transc.transhID = t.id and TRANSC.transhcID =  '3DAF9172-E9C4-402D-9BE7-4A3F64ABDAE4' 
                        where   completed = 0  and T.cusid = " & sCusID & sCompProjectID & " order by description")
        FillCbo.TRANSH(Frm.cboTRANSH, sSQL)
        If Frm.chkGenOffer.CheckState = CheckState.Checked Then
            Frm.cboCUS.EditValue = Frm.cboCompany.EditValue
            Frm.cboTRANSH.EditValue = Frm.cboCompProject.EditValue
        End If
        If sCusID <> "" Then Frm.cboCUS.EditValue = System.Guid.Parse(sCusID.Replace("'", ""))
        If sTranshID <> "" Then Frm.cboTRANSH.EditValue = System.Guid.Parse(sTranshID)
    End Sub
End Class
