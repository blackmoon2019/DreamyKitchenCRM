Imports DevExpress.XtraEditors
Imports DevExpress.XtraLayout
Imports DevExpress.XtraReports.UI
Imports System.Data.SqlClient

Public Class CusOfferOrderKitchen
    Private FillCbo As New FillCombos
    Private Valid As New ValidateControls
    Private ID As String
    Private sIsOrder As Boolean
    Private Mode As Byte
    Private CalledFromCtrl As Boolean
    Private CtrlCombo As DevExpress.XtraEditors.LookUpEdit
    Private Cls As New ClearControls
    Private DBQ As New DBQueries
    Private LoadForms As New FormLoader
    Private Frm As frmCUSOfferOrderKitchen
    Private Prog_Prop As New ProgProp
    Private sBaseCat As Integer
    Public Sub Initialize(ByVal sFrm As frmCUSOfferOrderKitchen, ByVal sID As String, ByVal sMode As Byte, ByVal sCalledFromCtrl As Boolean, ByVal sCtrlCombo As DevExpress.XtraEditors.LookUpEdit,
                          ByVal IsOrder As Boolean, BaseCat As Integer)
        Frm = sFrm
        ID = sID
        Mode = sMode
        CalledFromCtrl = sCalledFromCtrl
        CtrlCombo = sCtrlCombo
        sBaseCat = BaseCat
        sIsOrder = IsOrder
        Prog_Prop.GetProgPROSF()
        Frm.Vw_FILE_CATTableAdapter.Fill(Frm.DreamyKitchenDataSet.vw_FILE_CAT)
        Frm.Vw_COMPTableAdapter.Fill(Frm.DM_CCT.vw_COMP)
        Frm.Vw_VALUELISTITEM_BENCH_V2TableAdapter.Fill(Frm.DM_VALUELISTITEM.vw_VALUELISTITEM_BENCH_V2)
        Frm.Vw_VALUELISTITEM_V2TableAdapter.Fill(Frm.DM_VALUELISTITEM.vw_VALUELISTITEM_V2)
        Frm.CCT_TRANSHTableAdapter.Fill(Frm.DM_TRANS.CCT_TRANSH)
        Frm.BASE_CATTableAdapter.Fill(Frm.DMDataSet.BASE_CAT)
        Frm.Vw_BENCHTableAdapter.Fill(Frm.DreamyKitchenDataSet.vw_BENCH)
        Frm.Vw_CCTTableAdapter.Fill(Frm.DreamyKitchenDataSet.vw_CCT)
        Frm.Vw_SALERSTableAdapter.Fill(Frm.DreamyKitchenDataSet.vw_SALERS)
        Frm.Vw_COLORSGOLATableAdapter.Fill(Frm.DreamyKitchenDataSet.vw_COLORSGOLA)
        Frm.Vw_COLORS_CATTableAdapter.Fill(Frm.DreamyKitchenDataSet.vw_COLORS_CAT)
        Frm.Vw_VALUELISTITEMModelKitchenTableAdapter.Fill(Frm.DM_VALUELISTITEM1.vw_VALUELISTITEMModelKitchen)
        Frm.Vw_SUPTableAdapter.Fill(Frm.DreamyKitchenDataSet.vw_SUP)
        If ID IsNot Nothing Then Frm.Vw_CCT_ORDERS_PHOTOSTableAdapter.FillByOrderType(Frm.DM_CCT.vw_CCT_ORDERS_PHOTOS, 0, System.Guid.Parse(ID))
        If sIsOrder = True Then
            Frm.LOrderDetailsGroup.Text = "Στοιχεία Παραγγελίας"
            Frm.LdtOrder.Text = "Ημερ/νία Παραγγελίας"
            Frm.LCostDetails.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
            Frm.LOfferDetails.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
            Frm.LDevices.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
            Frm.LConvertToOrder.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
            Frm.LofferAccepted.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
            Frm.LGenOffer.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
            Frm.LNewRecord.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
            Frm.LOrder.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        Else
            Frm.LOrderDetailsGroup.Text = "Στοιχεία Προσφοράς"
            Frm.LdtOrder.Text = "Ημερ/νία Προσφοράς"
            Frm.LarProt.Text = "Αρ. Προσφοράς"
            Frm.LCostDetails.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
            Frm.LOfferDetails.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
            Frm.LDevices.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
            Frm.LPrivateAgreement.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
            Frm.TabNavigationPage3.PageVisible = False
            Frm.TabNavigationPage4.PageVisible = False
            Frm.LOrder.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
        End If

    End Sub
    Public Sub LoadForm()



        Select Case Mode
            Case FormMode.NewRecord
                LoadEquipments()
                Frm.txtarProt.Text = DBQ.GetNextId("CCT_ORDERS_KITCHEN")
                Frm.cboEMP.EditValue = System.Guid.Parse(UserProps.EmpID.ToString.ToUpper)
                Frm.txtdtdaysOfDelivery.EditValue = ProgProps.DAYS_OF_DELIVERY
                Frm.dtOrder.EditValue = Date.Now
                Frm.cmdPrintOffer.Enabled = False
                Frm.TabNavigationPage2.Enabled = False
                Frm.LConvertToOrder.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never

                If sIsOrder = False Then
                    Frm.txtVFinalHeight.EditValue = ProgProps.V_HEIGHT
                    Frm.txtKHeight.EditValue = ProgProps.K_HEIGHT
                    Frm.txtKFinalHeight.EditValue = ProgProps.K_FINAL_HEIGHT
                    Frm.txtYHeight.EditValue = ProgProps.Y_HEIGHT
                    Frm.txtYFinalHeight.EditValue = ProgProps.Y_FINAL_HEIGHT
                    Frm.cboVBOXColors.EditValue = System.Guid.Parse(ProgProps.V_BOX_COLOR)
                    Frm.cboKBOXColors.EditValue = System.Guid.Parse(ProgProps.K_BOX_COLOR)
                    Frm.cboYBOXColors.EditValue = System.Guid.Parse(ProgProps.Y_BOX_COLOR)
                    Frm.cboLegs.EditValue = ProgProps.LEGS
                    Frm.cboEMP.EditValue = System.Guid.Parse(UserProps.ID.ToString.ToUpper)
                    Frm.txtdtdaysOfDelivery.EditValue = ProgProps.DAYS_OF_DELIVERY
                    Frm.txtNotes.EditValue = ProgProps.CUS_NOTES
                    Frm.cmdOrder.Enabled = False
                End If


            Case FormMode.EditRecord
                Dim sFields As New Dictionary(Of String, String)
                If sIsOrder = False Then
                    LoadForms.LoadForm(Frm.LayoutControl1, "Select [ORDER].id as OrderID,[OFFER].*,OFFER_F.filename " &
                                                       "from CCT_ORDERS_KITCHEN [OFFER]" &
                                                       " left join CCT_ORDERS_KITCHEN  [ORDER] on [ORDER].CreatedFromOfferID =  [OFFER].id " &
                                                       " left join TRANSH_F  OFFER_F on OFFER_F.ownerID =  [OFFER].ID " &
                                                       "where [OFFER].id = " & toSQLValueS(ID), sFields)

                    If sFields("OrderID") <> "" Then
                        Frm.orderID = sFields("OrderID")
                        Frm.LConvertToOrder.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
                        Frm.cmdSave.Enabled = False : Frm.cmdSaveEquipDev.Enabled = False
                        Frm.LblMsg.Text = "Δεν μπορείτε να κάνετε αλλαγές στην προσφορά γιατί έχει δημιουργηθεί παραγγελία."
                        Frm.txtCUSOfferOrderFilename.Properties.Buttons.Item(0).Enabled = False
                        Frm.txtCUSOfferOrderFilename.Properties.Buttons.Item(2).Enabled = False
                    Else
                        Frm.cmdOrder.Enabled = False
                    End If
                    If sFields("selectedModel") <> "" Then
                        If sFields("selectedModel") = 1 Then Frm.chkModel1.CheckState = CheckState.Checked
                        If sFields("selectedModel") = 2 Then Frm.chkModel2.CheckState = CheckState.Checked
                        If sFields("selectedModel") = 3 Then Frm.chkModel3.CheckState = CheckState.Checked
                        If sFields("selectedModel") = 4 Then Frm.chkModel4.CheckState = CheckState.Checked
                    End If
                Else
                    LoadForms.LoadForm(Frm.LayoutControl1, "Select [ORDER].id as OrderID,[ORDER].*,ORDER_F.filename 
                                                        from CCT_ORDERS_KITCHEN [ORDER]
                                                        left join CCT_ORDERS_KITCHEN  [OFFER] on [OFFER].CreatedFromOfferID =  [ORDER].id  
                                                        left join TRANSH_F  ORDER_F on ORDER_F.ownerID =  [ORDER].ID where [ORDER].id = " & toSQLValueS(ID), sFields)

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

                Frm.TabNavigationPage2.Enabled = True
                If sFields("GenOffer") = "" Then sFields("GenOffer") = False
                FillCusTransh(sFields("cusID"), sFields("compTrashID"), sFields("GenOffer"), sFields("transhID")) : FillCompanyProjects(sFields("compID"), sFields("GenOffer"), sFields("compTrashID"))
                sFields = Nothing 
        End Select



        If Frm.txtCUSOfferOrderFilename.EditValue IsNot Nothing Then Frm.txtbenchSalesPrice.ReadOnly = False Else Frm.txtbenchSalesPrice.ReadOnly = True

    End Sub
    Public Sub LoadDevices()
        LoadForms.LoadDataToGrid(Frm.grdDevices, Frm.GridView1,
                   "select D.ID,D.code,D.name,
                        (select dCode  from CCT_ORDERS_KITCHEN_DEVICES ED where ED.cctOrdersKitchenID=" & toSQLValueS(ID) & " AND  ED.devicesID =D.id) as dCode, 
                        isnull((select price  from CCT_ORDERS_KITCHEN_DEVICES ED where ED.cctOrdersKitchenID=" & toSQLValueS(ID) & " AND  ED.devicesID =D.id),0) as price,
                        CAST(CASE WHEN (select ED.ID  from CCT_ORDERS_KITCHEN_DEVICES ED  where ED.cctOrdersKitchenID=" & toSQLValueS(ID) & " AND  ED.devicesID =D.id) IS NULL THEN 0 ELSE 1 END AS BIT ) as checked,
                        (select suppID from CCT_ORDERS_KITCHEN_DEVICES ED where ED.cctOrdersKitchenID=" & toSQLValueS(ID) & " AND  ED.devicesID =D.id) as suppID  
                      from DEVICES D
                      ORDER BY NAME")
        LoadForms.RestoreLayoutFromXml(Frm.GridView1, "CCT_ORDERS_KITCHEN_DEVICES_def.xml")
    End Sub
    Public Sub LoadEquipments()
        If Mode = FormMode.NewRecord Then
            LoadForms.LoadDataToGrid(Frm.grdEquipment, Frm.GridView2,
                    "Select  e.ID,E.code,name,e.price as defPrice,
                     price,cast(case when (SELECT FLdVAL FROM PRM_DET WHERE TBL='EQUIPMENT' AND fld='ID' AND fldVal=e.id) is null then 0 else 1 end as bit) as  checked,
                     case when (SELECT FLdVAL FROM PRM_DET WHERE TBL='EQUIPMENT' AND fld='ID' AND fldVal=e.id) is null then 0 else 1 end AS QTY,standard 
                     From vw_EQUIPMENT E 
                     where equipmentCatID='8AA21DC8-7D98-4596-8B73-9E664E955FFB' ORDER BY NAME")

        Else
            LoadForms.LoadDataToGrid(Frm.grdEquipment, Frm.GridView2,
                    "select e.ID,e.code,e.name,
                    isnull((select price from CCT_ORDERS_KITCHEN_EQUIPMENT EQ where eq.cctOrdersKitchenID= " & toSQLValueS(ID) & " And eq.equipmentID=e.id),e.price ) as price,
                    e.price as defPrice,
                    CAST(CASE WHEN (select eq.ID 
                    from CCT_ORDERS_KITCHEN_EQUIPMENT EQ 
                    where eq.cctOrdersKitchenID= " & toSQLValueS(ID) & " and eq.equipmentID=e.id) IS NULL THEN 0 ELSE 1 END AS BIT ) as checked,
                    isnull((select qty from CCT_ORDERS_KITCHEN_EQUIPMENT EQ where eq.cctOrdersKitchenID= " & toSQLValueS(ID) & " and eq.equipmentID=e.id),0) as QTY,standard
                    from EQUIPMENT E
                    where equipmentCatID='8AA21DC8-7D98-4596-8B73-9E664E955FFB' 
                    ORDER BY NAME")
        End If
        LoadForms.RestoreLayoutFromXml(Frm.GridView2, "CCT_ORDERS_KITCHEN_EQUIPMENT_def.xml")
    End Sub
    Public Sub FillCompanyProjects(ByVal sCompID As String, ByVal GenOffer As Boolean, ByVal scompTrashID As String)
        If sCompID = "" Then sCompID = toSQLValueS(Guid.Empty.ToString) Else sCompID = toSQLValueS(sCompID)
        Dim sSQL As New System.Text.StringBuilder
        sSQL.AppendLine("Select T.id,FullTranshDescription,Description,Iskitchen,Iscloset,Isdoor,Issc
                        from vw_TRANSH t
                        where  Iskitchen = 1 and T.cusid = " & sCompID & "order by description")
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
                        INNER JOIN TRANSC on transc.transhID = t.id and TRANSC.transhcID = '60344B92-1925-42E9-8D0F-0525990B0D5F' 
                        where   completed = 0  and T.cusid = " & sCusID & sCompProjectID & " order by description")
        FillCbo.TRANSH(Frm.cboTRANSH, sSQL)
        If Frm.chkGenOffer.CheckState = CheckState.Checked Then
            Frm.cboCUS.EditValue = Frm.cboCompany.EditValue
            Frm.cboTRANSH.EditValue = Frm.cboCompProject.EditValue
        End If
        If sCusID <> "" Then Frm.cboCUS.EditValue = System.Guid.Parse(sCusID.Replace("'", ""))
        If sTranshID <> "" Then Frm.cboTRANSH.EditValue = System.Guid.Parse(sTranshID)
    End Sub
    Private Function GetBaseCatID() As String
        Dim Cmd As SqlCommand, sdr As SqlDataReader
        Dim sSQL As String
        Select Case sBaseCat
            Case 1 'ECO
                sSQL = "SELECT top 1 id as BaseCatID FROM BASE_CAT WHERE name = 'ECO' "
            Case 2 'PREMIUM
                sSQL = "SELECT top 1 id as BaseCatID FROM BASE_CAT WHERE name = 'PREMIUM' "

        End Select
        Cmd = New SqlCommand(sSQL.ToString, CNDB)
        sdr = Cmd.ExecuteReader()
        Dim DBaseCatID As String
        If (sdr.Read() = True) Then
            If sdr.IsDBNull(sdr.GetOrdinal("BaseCatID")) = False Then DBaseCatID = sdr.GetGuid(sdr.GetOrdinal("BaseCatID")).ToString Else DBaseCatID = Guid.Empty.ToString
            If DBaseCatID <> "" Then Return DBaseCatID Else Return Guid.Empty.ToString
        Else
            Return Guid.Empty.ToString
        End If
        sdr.Close()
    End Function
    Public Sub SaveRecord(ByRef sID As String)
        Dim sResult As Boolean, sResultF As Boolean
        Dim sGuid As String
        Try
            Valid.ID = Frm.cboTRANSH.EditValue.ToString
            If Valid.ValiDationRules(Frm.Name, Frm,, sIsOrder) = False Then Exit Sub

            If Valid.ValidateForm(Frm.LayoutControl1) Then
                Dim selectedModel As Integer
                Dim TotAmt As Double
                If Frm.chkModel1.CheckState = CheckState.Checked Then selectedModel = 1 : Frm.txtTotAmt.EditValue = Frm.txtFinalPrice1.EditValue
                If Frm.chkModel2.CheckState = CheckState.Checked Then selectedModel = 2 : Frm.txtTotAmt.EditValue = Frm.txtFinalPrice2.EditValue
                If Frm.chkModel3.CheckState = CheckState.Checked Then selectedModel = 3 : Frm.txtTotAmt.EditValue = Frm.txtFinalPrice3.EditValue
                If Frm.chkModel4.CheckState = CheckState.Checked Then selectedModel = 4 : Frm.txtTotAmt.EditValue = Frm.txtFinalPrice4.EditValue
                Select Case Mode
                    Case FormMode.NewRecord
                        sGuid = System.Guid.NewGuid.ToString
                        Dim sDate As String = Frm.lblDate.Text.Replace("Ημερομηνία Παράδοσης: ", "")
                        sResult = DBQ.InsertNewData(DBQueries.InsertMode.OneLayoutControl, "CCT_ORDERS_KITCHEN", Frm.LayoutControl1,,, sGuid, , "dtDeliver,IsOrder,selectedModel,TotAmt", toSQLValueS(CDate(sDate).ToString("yyyyMMdd")) & "," & IIf(sIsOrder = True, 1, 0) & "," & selectedModel & "," & toSQLValue(Frm.txtTotAmt, True))
                        ID = sGuid : sID = sGuid
                    Case FormMode.EditRecord
                        Dim sDate As String = Frm.lblDate.Text.Replace("Ημερομηνία Παράδοσης: ", "")
                        sResult = DBQ.UpdateNewData(DBQueries.InsertMode.OneLayoutControl, "CCT_ORDERS_KITCHEN", Frm.LayoutControl1,,, ID, ,,,, "dtDeliver=" & toSQLValueS(CDate(sDate).ToString("yyyyMMdd")) & ",IsOrder = " & IIf(sIsOrder = True, 1, 0) & ",selectedModel = " & selectedModel & ",TotAmt = " & toSQLValue(Frm.txtTotAmt, True))
                        ID = sID
                End Select

                If Frm.txtCUSOfferOrderFilename.Text <> "" And sResult = True Then
                    sResultF = DBQ.DeleteDataFiles("TRANSH_F", Frm.cboTRANSH.EditValue.ToString, sID)
                    'Αποθήκευση αρχείου στο έργο
                    Frm.XtraOpenFileDialog1.Tag = "EEA48A0A-4171-46FE-BBC5-D02F2712B04C" ' Κατηγορία Αρχείου ΠΑΓΚΟΙ
                    sResultF = DBQ.InsertDataFiles(Frm.XtraOpenFileDialog1, Frm.cboTRANSH.EditValue.ToString, "TRANSH_F", sID, IIf(sIsOrder = True, "Παραγγελία", "Προσφορά"))
                    If sResultF = False Then XtraMessageBox.Show("Παρουσιάστηκε πρόβλημα στην επισύναψη προσφοράς στο Έργο", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
                If sResult = True Then
                    ' Καταχώρηση Εξοπλισμών
                    If Mode = FormMode.NewRecord Then
                        Frm.GridView1.PopulateColumns() : Frm.GridView2.PopulateColumns()
                        Frm.TabNavigationPage2.Enabled = True
                        InsertSelectedRows(False)
                        If sIsOrder = False Then
                            Frm.cmdConvertToOrder.Enabled = True
                            Frm.LConvertToOrder.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
                            Frm.LOrder.Visibility = Utils.LayoutVisibility.Always
                        Else
                            Frm.cmdPrivateAgreement.Enabled = True
                        End If
                        Frm.cmdPrintOffer.Enabled = True
                    End If
                    Dim Projects As New Projects
                    If sIsOrder = True Then
                        ' Πάγκος
                        If UpdateProjectBench() = False Then XtraMessageBox.Show("Παρουσιάστηκε πρόβλημα στην ενημέρωση του πάγκου στο έργο.", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
                        ' Ενημέρωση ποσών στο έργο
                        Projects.UpdateProject(Frm.cboTRANSH.EditValue.ToString, False, True)
                    Else
                        If Frm.chkGenOffer.CheckState = CheckState.Checked Then Projects.UpdateProject(Frm.cboTRANSH.EditValue.ToString, False, True, True)
                    End If
                        Mode = FormMode.EditRecord
                        XtraMessageBox.Show("Η εγγραφή αποθηκέυτηκε με επιτυχία", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Information)
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
                        sResult = DBQ.InsertNewData(DBQueries.InsertMode.OneLayoutControl, "CCT_ORDERS_PHOTOS", Frm.LayoutControl3,,, sGuid, , "orderID,orderType", toSQLValueS(sID) & ",0")
                    Case FormMode.EditRecord
                        sResult = DBQ.UpdateDataCardGRD(Frm.CardView1, "CCT_ORDERS_PHOTOS",, True)
                End Select
                If sResult = True Then
                    XtraMessageBox.Show("Η εγγραφή αποθηκέυτηκε με επιτυχία", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Cls.ClearCtrls(Frm.LayoutControl3)
                    Frm.Vw_CCT_ORDERS_PHOTOSTableAdapter.FillByOrderType(Frm.DM_CCT.vw_CCT_ORDERS_PHOTOS, 0, System.Guid.Parse(sID))
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
            Frm.Vw_CCT_ORDERS_PHOTOSTableAdapter.FillByOrderType(Frm.DM_CCT.vw_CCT_ORDERS_PHOTOS, 0, System.Guid.Parse(ID))
        End If
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

    ' Πάγκος
    Private Function UpdateProjectBench() As Boolean
        Try
            Dim sSQL As String
            If Frm.txtCUSOfferOrderFilename.EditValue = Nothing Then Return True
            sSQL = "UPDATE TRANSH SET BENCHSALESPRICE = " & toSQLValue(Frm.txtbenchSalesPrice, True) & " WHERE ID = " & toSQLValueS(Frm.cboTRANSH.EditValue.ToString)
            Using oCmd As New SqlCommand(sSQL, CNDB)
                oCmd.ExecuteNonQuery()
            End Using
            Return True
        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Public Sub InsertSelectedRows(ByVal msg As Boolean)
        Dim sSQL As String
        Dim I As Integer
        sSQL = "DELETE FROM CCT_ORDERS_KITCHEN_EQUIPMENT WHERE cctOrdersKitchenID = " & toSQLValueS(ID)
        Using oCmd As New SqlCommand(sSQL, CNDB)
            oCmd.ExecuteNonQuery()
        End Using
        If sIsOrder = True Then
            sSQL = "DELETE FROM CCT_ORDERS_KITCHEN_DEVICES WHERE cctOrdersKitchenID = " & toSQLValueS(ID)
            Using oCmd As New SqlCommand(sSQL, CNDB)
                oCmd.ExecuteNonQuery()
            End Using
        End If
        Dim Selected As Boolean
        Dim sPrice As Decimal
        For I = 0 To Frm.GridView2.RowCount - 1
            Selected = Frm.GridView2.GetRowCellValue(I, "checked")
            If Selected = True Then
                sPrice = Frm.GridView2.GetRowCellValue(I, "price")
                sSQL = "INSERT INTO CCT_ORDERS_KITCHEN_EQUIPMENT(cctOrdersKitchenID,equipmentID,price,selected,qty) " &
                        " VALUES ( " & toSQLValueS(ID) & "," & toSQLValueS(Frm.GridView2.GetRowCellValue(I, "ID").ToString) & "," & toSQLValueS(sPrice.ToString, True) & ",1," & toSQLValueS(Frm.GridView2.GetRowCellValue(I, "QTY").ToString, True) & ")"
                Using oCmd As New SqlCommand(sSQL, CNDB)
                    oCmd.ExecuteNonQuery()
                End Using
            End If
        Next
        If sIsOrder = True Then
            Dim DcodeIsEmpty As Boolean = False
            Dim supIDIsEmpty As Boolean = False
            For I = 0 To Frm.GridView1.RowCount - 1
                Selected = Frm.GridView1.GetRowCellValue(I, "checked")
                If Selected = True Then
                    If Frm.GridView1.GetRowCellValue(I, "dCode").ToString = "" Then DcodeIsEmpty = True
                    If Frm.GridView1.GetRowCellValue(I, "suppID").ToString = "" Then supIDIsEmpty = True
                    If Frm.GridView1.GetRowCellValue(I, "dCode").ToString.Length > 0 And Frm.GridView1.GetRowCellValue(I, "suppID").ToString.Length > 0 Then
                        sSQL = "INSERT INTO CCT_ORDERS_KITCHEN_DEVICES(cctOrdersKitchenID,devicesID,dCode,Price,selected,suppID) " &
                                " VALUES ( " & toSQLValueS(ID) & "," & toSQLValueS(Frm.GridView1.GetRowCellValue(I, "ID").ToString) & "," & toSQLValueS(Frm.GridView1.GetRowCellValue(I, "dCode").ToString) & "," &
                                                toSQLValueS(Frm.GridView1.GetRowCellValue(I, "price").ToString, True) & ",1," & toSQLValueS(Frm.GridView1.GetRowCellValue(I, "suppID").ToString) & " )"
                        Using oCmd As New SqlCommand(sSQL, CNDB)
                            oCmd.ExecuteNonQuery()
                        End Using
                    End If
                End If
            Next
            If Frm.GridView1.Columns.Item("price").SummaryItem.SummaryValue IsNot Nothing Then Frm.txtTotalDevicesPrice.EditValue = Frm.GridView1.Columns.Item("price").SummaryItem.SummaryValue
            If DcodeIsEmpty = True Or supIDIsEmpty = True Then
                If DcodeIsEmpty = True Then If msg Then XtraMessageBox.Show("Δεν έχετε καταχωρήσει Κωδικούς συσκευών", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
                If supIDIsEmpty = True Then If msg Then XtraMessageBox.Show("Δεν έχετε καταχωρήσει Προμηθευτή", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                Dim Projects As New Projects
                Projects.UpdateProject(Frm.cboTRANSH.EditValue.ToString, True)

                If msg Then XtraMessageBox.Show("Η εγγραφή αποθηκέυτηκε με επιτυχία", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Else
            If msg Then XtraMessageBox.Show("Η εγγραφή αποθηκέυτηκε με επιτυχία", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub

    Public Sub ConvertToOrder()
        Try
            Dim OrderID As String
            Valid.ID = Frm.cboTRANSH.EditValue.ToString
            If Frm.cboCompProject.EditValue IsNot Nothing Then Valid.compTrashID = Frm.cboCompProject.EditValue.ToString
            If Valid.ValiDationRules(Frm.Name, Frm, True) = False Then Exit Sub
            'If Frm.cboCompany.EditValue IsNot Nothing And Frm.cboCUS.EditValue IsNot Nothing Then
            '    If Frm.chkGenOffer.CheckState = CheckState.Checked And Frm.IsOrderRead = False Then XtraMessageBox.Show("Παραγγελίες γίνονται μόνο σε πελάτες", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error) : Exit Sub
            'End If
            If XtraMessageBox.Show("Θέλετε να μετατραπεί σε παραγγελία η προσφορά ?", ProgProps.ProgTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                Using oCmd As New SqlCommand("ConvertToOrder", CNDB)
                    oCmd.CommandType = CommandType.StoredProcedure
                    oCmd.Parameters.AddWithValue("@OfferID", ID)
                    oCmd.Parameters.AddWithValue("@createdBy", UserProps.ID)
                    oCmd.Parameters.AddWithValue("@Mode", 1)
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
                    Dim frmCUSOfferOrderKitchen As frmCUSOfferOrderKitchen = New frmCUSOfferOrderKitchen()
                    frmCUSOfferOrderKitchen.ID = OrderID
                    frmCUSOfferOrderKitchen.Mode = FormMode.EditRecord
                    frmCUSOfferOrderKitchen.IsOrder = True
                    frmCUSOfferOrderKitchen.Text = "Έντυπο Παραγγελίας Πελατών(Κουζίνα)"
                    frmCUSOfferOrderKitchen.ShowDialog()
                End If
            End If
        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Public Sub PrintOffer()
        If sIsOrder = True Then
            Dim report As New RepCUSOrderKitchen()

            report.Parameters.Item(0).Value = ID
            report.CreateDocument()
            'report.PrintingSystem.Document.ScaleFactor = 0.75

            Dim report2 As New RepCUSOrderKitchen2ndPage

            report2.Parameters.Item(0).Value = ID
            report2.Parameters.Item(1).Value = ID
            report2.Parameters.Item(2).Value = ID
            report2.CreateDocument()
            report.ModifyDocument(Sub(x)
                                      x.AddPages(report2.Pages)
                                  End Sub)
            Dim printTool As New ReportPrintTool(report)
            printTool.ShowRibbonPreview()
        Else
            Dim report As New RepCUSOfferKitchen()

            report.Parameters.Item(0).Value = ID
            report.CreateDocument()
            Dim report1 As New RepCUSOfferKitchen1stPage
            If Frm.cboBaseCat.EditValue.ToString.ToUpper = "77F25E1D-CEE0-4E13-91B4-A84B640DBBDA" Then
                report1.Parameters.Item(0).Value = "REPORT_ECO"
                report1.XrLabel2.Text = "ECO"
            ElseIf Frm.cboBaseCat.EditValue.ToString.ToUpper = "7F7273D1-CD5D-472F-83E2-D52F68B4530F" Then
                report1.Parameters.Item(0).Value = "REPORT_PREMIUM"
                report1.XrLabel2.Text = "PREMIUM"
            End If

            report1.CreateDocument()
            report.ModifyDocument(Sub(x)
                                      x.AddPages(report1.Pages)
                                  End Sub)


            Dim report2 As New RepCUSOfferKitchen2ndPage

            report2.CreateDocument()
            report.ModifyDocument(Sub(x)
                                      x.AddPages(report2.Pages)
                                  End Sub)
            Dim report3 As New RepCUSOfferKitchen3ndPage
            report3.Parameters.Item(0).Value = ID
            report3.CreateDocument()
            report.ModifyDocument(Sub(x)
                                      x.AddPages(report3.Pages)
                                  End Sub)

            Dim printTool As New ReportPrintTool(report)
            printTool.ShowRibbonPreview()
        End If
    End Sub
    Public Sub NewRecord()
        Cls.ClearCtrls(Frm.LayoutControl1) : Cls.ClearCtrls(Frm.LayoutControl2)
        Cls.ClearCtrls(Frm.LayoutControl3) : Cls.ClearCtrls(Frm.LayoutControl4)

        Frm.txtarProt.Text = DBQ.GetNextId("CCT_ORDERS_KITCHEN")
        Frm.cboEMP.EditValue = System.Guid.Parse(UserProps.EmpID.ToString.ToUpper)
        Frm.txtdtdaysOfDelivery.EditValue = ProgProps.DAYS_OF_DELIVERY
        Frm.LblMsg.Text = ""
        Frm.cboModel1.SetEditValue(-1) : Frm.cboModel2.SetEditValue(-1)
        Frm.cboModel3.SetEditValue(-1) : Frm.cboModel4.SetEditValue(-1)
        Frm.dtOrder.EditValue = Date.Now
        Frm.cmdPrintOffer.Enabled = False
        Mode = FormMode.NewRecord
        If sIsOrder = False Then
            Frm.txtVFinalHeight.EditValue = ProgProps.V_HEIGHT
            Frm.txtKHeight.EditValue = ProgProps.K_HEIGHT
            Frm.txtKFinalHeight.EditValue = ProgProps.K_FINAL_HEIGHT
            Frm.txtYHeight.EditValue = ProgProps.Y_HEIGHT
            Frm.txtYFinalHeight.EditValue = ProgProps.Y_FINAL_HEIGHT
            Frm.cboVBOXColors.EditValue = System.Guid.Parse(ProgProps.V_BOX_COLOR)
            Frm.cboKBOXColors.EditValue = System.Guid.Parse(ProgProps.K_BOX_COLOR)
            Frm.cboYBOXColors.EditValue = System.Guid.Parse(ProgProps.Y_BOX_COLOR)
            Frm.cboLegs.EditValue = ProgProps.LEGS
            Frm.cboEMP.EditValue = System.Guid.Parse(UserProps.ID.ToString.ToUpper)
            Frm.txtdtdaysOfDelivery.EditValue = ProgProps.DAYS_OF_DELIVERY
            Frm.txtNotes.EditValue = ProgProps.CUS_NOTES
        End If

        LoadForms.LoadDataToGrid(Frm.grdEquipment, Frm.GridView2,
            "Select  e.ID,E.code,name,e.price as defPrice,
                     price,cast(case when (SELECT FLdVAL FROM PRM_DET WHERE TBL='EQUIPMENT' AND fld='ID' AND fldVal=e.id) is null then 0 else 1 end as bit) as  checked,
                     case when (SELECT FLdVAL FROM PRM_DET WHERE TBL='EQUIPMENT' AND fld='ID' AND fldVal=e.id) is null then 0 else 1 end AS QTY,standard 
                     From vw_EQUIPMENT E 
                     where equipmentCatID='8AA21DC8-7D98-4596-8B73-9E664E955FFB' ORDER BY NAME")
        Frm.TabNavigationPage2.Enabled = False
        'cmdConvertToOrder.Enabled = False
        Frm.LConvertToOrder.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
    End Sub
End Class
