Imports System.Data.SqlClient
Imports DevExpress.PivotGrid.OLAP
Imports DevExpress.XtraEditors
Imports DevExpress.XtraLayout
Imports DevExpress.XtraReports.UI
Public Class CusOfferOrderDoors
    Private FillCbo As New FillCombos
    Private Valid As New ValidateControls
    Private ID As String
    Private Cls As New ClearControls
    Private sIsOrder As Boolean
    Private Mode As Byte
    Private CalledFromCtrl As Boolean
    Private CtrlCombo As DevExpress.XtraEditors.LookUpEdit
    Private DBQ As New DBQueries
    Private LoadForms As New FormLoader
    Private Frm As frmCUSOfferOrderDoors
    Private Prog_Prop As New ProgProp
    Public Sub Initialize(ByVal sFrm As frmCUSOfferOrderDoors, ByVal sID As String, ByVal sMode As Byte, ByVal sCalledFromCtrl As Boolean, ByVal sCtrlCombo As DevExpress.XtraEditors.LookUpEdit, ByVal IsOrder As Boolean)
        Frm = sFrm
        ID = sID
        Mode = sMode
        CalledFromCtrl = sCalledFromCtrl
        CtrlCombo = sCtrlCombo
        sIsOrder = IsOrder
        Prog_Prop.GetProgPROSF()
        Frm.Vw_COMPTableAdapter.Fill(Frm.DM_CCT.vw_COMP)
        Frm.CCT_TRANSHTableAdapter.Fill(Frm.DM_TRANS.CCT_TRANSH)
        Frm.Vw_CCTTableAdapter.Fill(Frm.DreamyKitchenDataSet.vw_CCT)
        Frm.Vw_VALUELISTITEM_V2TableAdapter.Fill(Frm.DM_VALUELISTITEM.vw_VALUELISTITEM_V2)
        Frm.CCT_TRANSHTableAdapter.Fill(Frm.DM_TRANS.CCT_TRANSH)
        Frm.Vw_COLORSDOORSTableAdapter.Fill(Frm.DreamyKitchenDataSet.vw_COLORSDOORS)
        Frm.Vw_SALERSTableAdapter.Fill(Frm.DreamyKitchenDataSet.vw_SALERS)
        Frm.Vw_COLORS_CATTableAdapter.Fill(Frm.DreamyKitchenDataSet.vw_COLORS_CAT)
        Frm.Vw_SUPTableAdapter.Fill(Frm.DreamyKitchenDataSet.vw_SUP)
        If ID IsNot Nothing Then Frm.Vw_CCT_ORDERS_PHOTOSTableAdapter.FillByOrderType(Frm.DM_CCT.vw_CCT_ORDERS_PHOTOS, 2, System.Guid.Parse(ID))
        If sIsOrder = True Then
            Frm.LGenOffer.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
            Frm.LExtraInst.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
            Frm.LPartofVat.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
            Frm.LOrder.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
            Frm.LPrivateAgreement.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
            Frm.LExtraTransp.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
            Frm.LofferAccepted.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
            Frm.LGroupOrderDetails1.Text = "Στοιχεία Παραγγελίας"
            Frm.LGroupOrderDetails2.Text = "Στοιχεία Παραγγελίας"
            Frm.Ldtpresentation.Text = "Ημερ/νία Παραγγελίας"
            Frm.LConvertToOrder.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
            Frm.LofferAccepted.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
            Frm.LGenOffer.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
            Frm.LNewRecord.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
            Frm.LOrder.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        Else
            Frm.LayoutControlItem41.Tag = 0
            Frm.LarProt.Text = "Αρ. Προσφοράς"
            Frm.LGroupOrderDetails1.Text = "Στοιχεία Προσφοράς"
            Frm.LGroupOrderDetails2.Text = "Στοιχεία Προσφοράς"
            Frm.Ldtpresentation.Text = "Ημερ/νία Προσφοράς"
            Frm.LCost.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
            Frm.LOrder.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
            Frm.LPrivateAgreement.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
            Frm.TabNavigationPage2.PageVisible = False
            Frm.TabNavigationPage3.PageVisible = False
        End If
    End Sub
    Public Sub LoadForm()

        Select Case Mode
            Case FormMode.NewRecord
                Frm.txtarProt.Text = DBQ.GetNextId("CCT_ORDERS_DOOR")
                Frm.cboEMP.EditValue = System.Guid.Parse(UserProps.ID.ToString.ToUpper)
                Frm.txtdtdaysOfDelivery.EditValue = ProgProps.DAYS_OF_DELIVERY
                Frm.txtDescription.EditValue = ProgProps.DOOR_DESCRIPTION
                Frm.txtComments.EditValue = ProgProps.DOOR_CMT
                Frm.txtNotes.EditValue = ProgProps.CUS_NOTES
                Frm.LConvertToOrder.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
                Frm.cmdPrintOffer.Enabled = False
                If sIsOrder = False Then Frm.cmdOrder.Enabled = False
            Case FormMode.EditRecord
                Dim sFields As New Dictionary(Of String, String)
                If sIsOrder = False Then
                    LoadForms.LoadForm(Frm.LayoutControl1, "Select [ORDER].id as OrderID,[OFFER].*,OFFER_F.filename " &
                                                   " from CCT_ORDERS_DOOR  [OFFER] " &
                                                   " left join CCT_ORDERS_DOOR  [ORDER] on [ORDER].CreatedFromOfferID =  [OFFER].id " &
                                                   " left join TRANSH_F  OFFER_F on OFFER_F.ownerID =  [OFFER].ID " &
                                                   " where [OFFER].id = " & toSQLValueS(ID), sFields)
                    If sFields("OrderID") <> "" Then
                        Frm.orderID = sFields("OrderID")
                        Frm.LConvertToOrder.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
                        Frm.cmdSave.Enabled = False
                        Frm.LblMsg.Text = "Δεν μπορείτε να κάνετε αλλαγές στην προσφορά γιατί έχει δημιουργηθεί παραγγελία."
                    Else
                        Frm.cmdOrder.Enabled = False
                    End If

                Else
                    LoadForms.LoadForm(Frm.LayoutControl1, "Select [ORDER].id as OrderID,[ORDER].*,ORDER_F.filename 
                                                        from CCT_ORDERS_DOOR [ORDER]
                                                        left join CCT_ORDERS_DOOR  [OFFER] on [OFFER].CreatedFromOfferID =  [ORDER].id  
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
        End Select
        If Frm.chkGenOffer.CheckState = CheckState.Checked Then Frm.cmdCusCollection.Enabled = False Else Frm.cmdCusCollection.Enabled = True
    End Sub
    Public Sub SaveRecord(ByRef sID As String)
        Dim sResult As Boolean
        Dim sGuid As String
        Try
            If Valid.ValiDationRules(Frm.Name, Frm) = False Then Exit Sub
            If Valid.ValidateForm(Frm.LayoutControl1) Then
                Select Case Mode
                    Case FormMode.NewRecord
                        sGuid = System.Guid.NewGuid.ToString
                        Dim sDate As String = Frm.lblDate.Text.Replace("Ημερομηνία Παράδοσης: ", "")
                        sResult = DBQ.InsertNewData(DBQueries.InsertMode.OneLayoutControl, "CCT_ORDERS_DOOR", Frm.LayoutControl1,,, sGuid, , "dtDeliver,IsOrder,TotAmt", toSQLValueS(CDate(sDate).ToString("yyyyMMdd")) & "," & IIf(sIsOrder = True, 1, 0) & "," & toSQLValue(Frm.txtTotAmt, True))
                        ID = sGuid : sID = sGuid
                    Case FormMode.EditRecord
                        Dim sDate As String = Frm.lblDate.Text.Replace("Ημερομηνία Παράδοσης: ", "")
                        sResult = DBQ.UpdateNewData(DBQueries.InsertMode.OneLayoutControl, "CCT_ORDERS_DOOR", Frm.LayoutControl1,,, sID, ,,,, "dtDeliver=" & toSQLValueS(CDate(sDate).ToString("yyyyMMdd")) & ",IsOrder = " & IIf(sIsOrder = True, 1, 0) & ",TotAmt = " & toSQLValue(Frm.txtTotAmt, True))
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
                    End If
                    Dim Projects As New Projects
                    If sIsOrder = True Then
                        ' Ενημέρωση ποσών στο έργο
                        Projects.UpdateProject(Frm.cboTRANSH.EditValue.ToString,  , True)
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
    Public Sub PrintOfferOrder()
        If sIsOrder Then
            Dim report As New RepCUSOrderDoors()
            report.Parameters.Item(0).Value = ID
            report.CreateDocument()
            Dim printTool As New ReportPrintTool(report)
            printTool.ShowRibbonPreview()
        Else
            Dim report As New RepCUSOfferDoors()
            report.Parameters.Item(0).Value = ID
            report.CreateDocument()
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
            If Frm.cboCompany.EditValue IsNot Nothing And Frm.cboCUS.EditValue IsNot Nothing Then
                If Frm.chkGenOffer.CheckState = CheckState.Checked And Frm.IsOrderRead = False Then XtraMessageBox.Show("Παραγγελίες γίνονται μόνο σε πελάτες", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error) : Exit Sub
            End If
            If XtraMessageBox.Show("Θέλετε να μετατραπεί σε παραγγελία η προσφορά ?", ProgProps.ProgTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                Using oCmd As New SqlCommand("ConvertToOrder", CNDB)
                    oCmd.CommandType = CommandType.StoredProcedure
                    oCmd.Parameters.AddWithValue("@OfferID", ID)
                    oCmd.Parameters.AddWithValue("@createdBy", UserProps.ID)
                    oCmd.Parameters.AddWithValue("@Mode", 3)
                    oCmd.Parameters.Add("@OrderID", SqlDbType.UniqueIdentifier)
                    oCmd.Parameters("@OrderID").Direction = ParameterDirection.Output
                    oCmd.ExecuteNonQuery()
                    OrderID = oCmd.Parameters("@OrderID").Value.ToString
                End Using
                XtraMessageBox.Show("Η μετατροπή ολοκληρώθηκε με επιτυχία", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Frm.orderID = OrderID
                Frm.cmdSave.Enabled = False
                Frm.LConvertToOrder.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
                Frm.LblMsg.Text = "Δεν μπορείτε να κάνετε αλλαγές στην προσφορά γιατί έχει δημιουργηθεί παραγγελία."
                Frm.cmdOrder.Enabled = True
                If XtraMessageBox.Show("Θέλετε να δείτε την παραγγελία ?", ProgProps.ProgTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                    Dim frmCUSOfferOrderDoors As frmCUSOfferOrderDoors = New frmCUSOfferOrderDoors()
                    frmCUSOfferOrderDoors.ID = OrderID
                    frmCUSOfferOrderDoors.Mode = FormMode.EditRecord
                    frmCUSOfferOrderDoors.IsOrder = True
                    frmCUSOfferOrderDoors.Text = "Έντυπο Παραγγελίας Πελατών(Πόρτες)"
                    frmCUSOfferOrderDoors.ShowDialog()
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
                        sResult = DBQ.InsertNewData(DBQueries.InsertMode.OneLayoutControl, "CCT_ORDERS_PHOTOS", Frm.LayoutControl3,,, sGuid, , "orderID,orderType", toSQLValueS(sID) & ",2")
                    Case FormMode.EditRecord
                        sResult = DBQ.UpdateDataCardGRD(Frm.CardView1, "CCT_ORDERS_PHOTOS",, True)
                End Select
                If sResult = True Then
                    XtraMessageBox.Show("Η εγγραφή αποθηκέυτηκε με επιτυχία", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Cls.ClearCtrls(Frm.LayoutControl3)
                    Frm.Vw_CCT_ORDERS_PHOTOSTableAdapter.FillByOrderType(Frm.DM_CCT.vw_CCT_ORDERS_PHOTOS, 2, System.Guid.Parse(sID))
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
    Public Sub FillCompanyProjects(ByVal sCompID As String, ByVal GenOffer As Boolean, ByVal scompTrashID As String)
        If sCompID = "" Then sCompID = toSQLValueS(Guid.Empty.ToString) Else sCompID = toSQLValueS(sCompID)
        Dim sSQL As New System.Text.StringBuilder
        sSQL.AppendLine("Select T.id,FullTranshDescription,Description,Iskitchen,Iscloset,Isdoor,Issc
                        from vw_TRANSH t
                        where  IsDoor = 1 and T.cusid = " & sCompID & "order by description")
        FillCbo.TRANSH(Frm.cboCompProject, sSQL)
        Frm.LCompProject.ImageOptions.Image = Global.DreamyKitchenCRM.My.Resources.Resources.rsz_11rsz_asterisk
        Frm.cmdCompCollection.Enabled = True
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
                        INNER JOIN TRANSC on transc.transhID = t.id and TRANSC.transhcID =  '47618E49-33E8-4685-969F-55419EDFAC58' 
                        where   completed = 0  and T.cusid = " & sCusID & sCompProjectID & " order by description")
        FillCbo.TRANSH(Frm.cboTRANSH, sSQL)
        If Frm.chkGenOffer.CheckState = CheckState.Checked Then
            Frm.cboCUS.EditValue = Frm.cboCompany.EditValue
            Frm.cboTRANSH.EditValue = Frm.cboCompProject.EditValue
        End If
        If sCusID <> "" Then Frm.cboCUS.EditValue = System.Guid.Parse(sCusID.Replace("'", ""))
        If sTranshID <> "" Then Frm.cboTRANSH.EditValue = System.Guid.Parse(sTranshID)
    End Sub
    Public Sub NewRecord()
        Cls.ClearCtrls(Frm.LayoutControl1) : Cls.ClearCtrls(Frm.LayoutControl3) : Cls.ClearCtrls(Frm.LayoutControl4)

        Frm.txtarProt.Text = DBQ.GetNextId("CCT_ORDERS_DOOR")
        Frm.cboEMP.EditValue = System.Guid.Parse(UserProps.ID.ToString.ToUpper)
        Frm.txtdtdaysOfDelivery.EditValue = ProgProps.DAYS_OF_DELIVERY
        Frm.TabNavigationPage2.Enabled = False
        Frm.LConvertToOrder.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
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
End Class
