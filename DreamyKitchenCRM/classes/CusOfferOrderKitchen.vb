Imports DevExpress.XtraBars.Navigation
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraEditors.DXErrorProvider
Imports DevExpress.XtraLayout
Imports DevExpress.XtraReports.UI
Imports DreamyKitchenCRM.Main
Imports System.Data.SqlClient

Public Class CusOfferOrderKitchen
    Private Valid As New ValidateControls
    Private ID As String
    Private sIsOrder As Boolean
    Private Mode As Byte
    Private CalledFromCtrl As Boolean
    Private CtrlCombo As DevExpress.XtraEditors.LookUpEdit
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
    End Sub
    Public Sub LoadForm()
        Frm.Vw_COMPTableAdapter.Fill(Frm.DM_CCT.vw_COMP)
        Frm.Vw_VALUELISTITEM_BENCH_V2TableAdapter.Fill(Frm.DM_VALUELISTITEM.vw_VALUELISTITEM_BENCH_V2)
        Frm.Vw_VALUELISTITEM_V2TableAdapter.Fill(Frm.DM_VALUELISTITEM.vw_VALUELISTITEM_V2)
        Frm.CCT_TRANSHTableAdapter.Fill(Frm.DM_TRANS.CCT_TRANSH)
        Frm.BASE_CATTableAdapter.Fill(Frm.DMDataSet.BASE_CAT)
        Frm.Vw_BENCHTableAdapter.Fill(Frm.DreamyKitchenDataSet.vw_BENCH)
        Frm.Vw_CCTTableAdapter.Fill(Frm.DreamyKitchenDataSet.vw_CCT)
        Frm.Vw_SALERSTableAdapter.Fill(Frm.DreamyKitchenDataSet.vw_SALERS)
        Frm.Vw_COLORSGOLATableAdapter.Fill(Frm.DreamyKitchenDataSet.vw_COLORSGOLA)
        Prog_Prop.GetProgPROSF()

        If sIsOrder = True Then
            Frm.LayoutControlGroup1.Text = "Στοιχεία Παραγγελίας"
            Frm.LayoutControlItem30.Text = "Ημερ/νία Παραγγελίας"
            Frm.LayoutControlGroup8.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
            Frm.LayoutControlGroup9.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
            Frm.LayoutControlItem71.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
            Frm.LayoutControlItem85.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        Else
            Frm.LayoutControlGroup1.Text = "Στοιχεία Προσφοράς"
            Frm.LayoutControlItem30.Text = "Ημερ/νία Προσφοράς"
            Frm.LayoutControlItem28.Text = "Αρ. Προσφοράς"
            Frm.LayoutControlGroup8.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
            Frm.LayoutControlGroup9.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
            Frm.LayoutControlItem1.Tag = 0
            Frm.LayoutControlItem71.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        End If

        Select Case Mode
            Case FormMode.NewRecord
                'txtCode.Text = DBQ.GetNextId("CCT_ORDERS_KITCHEN")
                Frm.txtarProt.Text = DBQ.GetNextId("CCT_ORDERS_KITCHEN")
                Frm.cboEMP.EditValue = System.Guid.Parse(UserProps.EmpID.ToString.ToUpper)
                Frm.txtdtdaysOfDelivery.EditValue = ProgProps.DAYS_OF_DELIVERY
                Frm.txtTransp.EditValue = ProgProps.KitchenTransp
                Frm.txtMeasurement.EditValue = ProgProps.KitchenMeasurement
                Frm.txtRemove.EditValue = ProgProps.KitchenRemove
                'Frm.cboBaseCat.EditValue = System.Guid.Parse(GetBaseCatID())
                Frm.dtOrder.EditValue = Date.Now

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
                Frm.LayoutControlItem85.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
            Case FormMode.EditRecord
                Dim sFields As New Dictionary(Of String, String)
                LoadForms.LoadForm(Frm.LayoutControl1, "Select [ORDER].id as OrderID,[OFFER].*,OFFER_F.filename " &
                                                       "from CCT_ORDERS_KITCHEN [OFFER]" &
                                                       " left join CCT_ORDERS_KITCHEN  [ORDER] on [ORDER].CreatedFromOfferID =  [OFFER].id " &
                                                       " left join CCT_ORDERS_KITCHEN_F  OFFER_F on OFFER_F.cctOrdersKitchenID =  [OFFER].ID " &
                                                       "where [OFFER].id = " & toSQLValueS(ID), sFields)
                If sIsOrder = False Then
                    If sFields("OrderID") <> "" Then
                        Frm.LayoutControlItem85.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
                        Frm.cmdSave.Enabled = False : Frm.cmdSaveEquipDev.Enabled = False
                        Frm.LabelControl1.Text = "Δεν μπορείτε να κάνετε αλλαγές στην προσφορά γιατί έχει δημιουργηθεί παραγγελία."
                    End If
                Else
                    Frm.LayoutControlItem85.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
                    If sFields("CreatedFromOfferID") <> "" Then Frm.cboCUS.Enabled = False
                End If
                sFields = Nothing

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
                Frm.TabNavigationPage2.Enabled = True

        End Select

        LoadForms.LoadDataToGrid(Frm.grdDevices, Frm.GridView1,
                    "select D.ID,D.code,D.name,(select dCode  from CCT_ORDERS_KITCHEN_DEVICES ED where ED.cctOrdersKitchenID=" & toSQLValueS(ID) & " AND  ED.devicesID =D.id) as dCode, 
                    isnull((select price  from CCT_ORDERS_KITCHEN_DEVICES ED where ED.cctOrdersKitchenID=" & toSQLValueS(ID) & " AND  ED.devicesID =D.id),0) as price,
                      CAST(CASE WHEN (select ED.ID 
                        from CCT_ORDERS_KITCHEN_DEVICES ED 
	                    where ED.cctOrdersKitchenID=" & toSQLValueS(ID) & " AND  ED.devicesID =D.id) IS NULL THEN 0 ELSE 1 END AS BIT ) as checked
                      from DEVICES D
                        ORDER BY NAME")
        LoadForms.RestoreLayoutFromXml(Frm.GridView2, "CCT_ORDERS_KITCHEN_EQUIPMENT_def.xml")
        LoadForms.RestoreLayoutFromXml(Frm.GridView1, "CCT_ORDERS_KITCHEN_DEVICES_def.xml")
        If Frm.txtCUSOfferOrderFilename.EditValue IsNot Nothing Then Frm.txtbenchSalesPrice.ReadOnly = False Else Frm.txtbenchSalesPrice.ReadOnly = True
        Frm.GridView2.Columns.Item("name").OptionsColumn.AllowEdit = False : Frm.GridView2.Columns.Item("code").OptionsColumn.AllowEdit = False
        Frm.GridView1.Columns.Item("name").OptionsColumn.AllowEdit = False : Frm.GridView1.Columns.Item("code").OptionsColumn.AllowEdit = False
        Frm.GridView2.Columns.Item("price").OptionsColumn.AllowEdit = False : Frm.GridView2.Columns.Item("standard").OptionsColumn.AllowEdit = False
        Frm.GridView1.OptionsMenu.ShowConditionalFormattingItem = True


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
            If Valid.ValiDationRules(Frm.Name, Frm) = False Then Exit Sub
            If Valid.ValidateForm(Frm.LayoutControl1) Then
                Select Case Mode
                    Case FormMode.NewRecord
                        sGuid = System.Guid.NewGuid.ToString
                        Dim sDate As String = Frm.lblDate.Text.Replace("Ημερομηνία Παράδοσης: ", "")
                        sResult = DBQ.InsertNewData(DBQueries.InsertMode.OneLayoutControl, "CCT_ORDERS_KITCHEN", Frm.LayoutControl1,,, sGuid, , "dtDeliver,IsOrder", toSQLValueS(CDate(sDate).ToString("yyyyMMdd")) & "," & IIf(sIsOrder = True, 1, 0))
                        ID = sGuid : sID = ID
                    Case FormMode.EditRecord
                        Dim sDate As String = Frm.lblDate.Text.Replace("Ημερομηνία Παράδοσης: ", "")
                        sResult = DBQ.UpdateNewData(DBQueries.InsertMode.OneLayoutControl, "CCT_ORDERS_KITCHEN", Frm.LayoutControl1,,, ID, ,,,, "dtDeliver=" & toSQLValueS(CDate(sDate).ToString("yyyyMMdd")) & ",IsOrder = " & IIf(sIsOrder = True, 1, 0))
                        sGuid = ID : sID = ID
                End Select
                If sResult = False Then Exit Sub
                sResultF = DBQ.DeleteDataFiles("CCT_ORDERS_KITCHEN_F", sGuid)
                If sResultF Then
                    If Frm.txtCUSOfferOrderFilename.Text <> "" And sResult = True Then
                        sResultF = DBQ.InsertDataFiles(Frm.XtraOpenFileDialog1, sGuid, "CCT_ORDERS_KITCHEN_F")
                        If sResultF = False Then XtraMessageBox.Show("Παρουσιάστηκε πρόβλημα στην επισύναψη προσφοράς", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                Else
                    XtraMessageBox.Show("Παρουσιάστηκε πρόβλημα στην επισύναψη προσφοράς", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
                If sResult = True Then
                    If UpdateProjectFields() = False Then XtraMessageBox.Show("Παρουσιάστηκε πρόβλημα στην ενημέρωση του έργου.", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
                    XtraMessageBox.Show("Η εγγραφή αποθηκέυτηκε με επιτυχία", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    ' Καταχώρηση Εξοπλισμών
                    If Mode = FormMode.NewRecord Then
                        Frm.GridView1.PopulateColumns() : Frm.GridView2.PopulateColumns()
                        Frm.TabNavigationPage2.Enabled = True
                        InsertSelectedRows(False)
                        LoadForms.RestoreLayoutFromXml(Frm.GridView1, "CCT_ORDERS_KITCHEN_DEVICES_def.xml")
                        LoadForms.RestoreLayoutFromXml(Frm.GridView2, "CCT_ORDERS_KITCHEN_EQUIPMENT_def")
                        If sIsOrder = False Then Frm.cmdConvertToOrder.Enabled = True : Frm.LayoutControlItem85.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
                    End If
                    Mode = FormMode.EditRecord
                    If sIsOrder = True Then
                        Dim HasKitchen As Boolean, HasCloset As Boolean, HasDoors As Boolean, HasSc As Boolean
                        HasKitchen = Frm.cboTRANSH.GetColumnValue("Iskitchen")
                        HasCloset = Frm.cboTRANSH.GetColumnValue("Iscloset")
                        HasDoors = Frm.cboTRANSH.GetColumnValue("Isdoors")
                        HasSc = Frm.cboTRANSH.GetColumnValue("Issc")
                        If HasKitchen = False And HasCloset = False And HasDoors = False And HasSc = False Then
                            XtraMessageBox.Show("Κοστολόγηση δεν θα δημιουργηθεί λόγω έλλειψης συμφωνητικού", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                            Exit Sub
                        End If
                    End If
                End If
            End If

        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Function UpdateProjectFields() As Boolean
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
            For I = 0 To Frm.GridView1.RowCount - 1
                Selected = Frm.GridView1.GetRowCellValue(I, "checked")
                If Selected = True Then
                    If Frm.GridView1.GetRowCellValue(I, "dCode").ToString = "" Then DcodeIsEmpty = True
                    If Frm.GridView1.GetRowCellValue(I, "dCode").ToString.Length > 0 Then
                        sSQL = "INSERT INTO CCT_ORDERS_KITCHEN_DEVICES(cctOrdersKitchenID,devicesID,dCode,Price,selected) " &
                    " VALUES ( " & toSQLValueS(ID) & "," & toSQLValueS(Frm.GridView1.GetRowCellValue(I, "ID").ToString) & "," & toSQLValueS(Frm.GridView1.GetRowCellValue(I, "dCode").ToString) & "," & toSQLValueS(Frm.GridView1.GetRowCellValue(I, "price").ToString, True) & ",1)"
                        Using oCmd As New SqlCommand(sSQL, CNDB)
                            oCmd.ExecuteNonQuery()
                        End Using
                    End If
                End If
            Next
            If DcodeIsEmpty = True Then
                If msg Then XtraMessageBox.Show("Δεν έχετε καταχωρήσει Κωδικούς συσκευών", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                If msg Then XtraMessageBox.Show("Η εγγραφή αποθηκέυτηκε με επιτυχία", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Else
            If msg Then XtraMessageBox.Show("Η εγγραφή αποθηκέυτηκε με επιτυχία", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub
    Public Sub ConvertToOrder()
        Try
            If XtraMessageBox.Show("Θέλετε να μετατραπεί σε παραγγελία η προσφορά ?", ProgProps.ProgTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                Using oCmd As New SqlCommand("ConvertToOrder", CNDB)
                    oCmd.CommandType = CommandType.StoredProcedure
                    oCmd.Parameters.AddWithValue("@OfferID", ID)
                    oCmd.Parameters.AddWithValue("@createdBy", UserProps.ID)
                    oCmd.Parameters.AddWithValue("@Mode", 1)
                    oCmd.ExecuteNonQuery()
                End Using
                XtraMessageBox.Show("Η μετατροπή ολοκληρώθηκε με επιτυχία", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Information)
                'cmdConvertToOrder.Enabled = False
                Frm.cmdSave.Enabled = False : Frm.cmdSaveEquipDev.Enabled = False
                Frm.LayoutControlItem85.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
                Frm.LabelControl1.Text = "Δεν μπορείτε να κάνετε αλλαγές στην προσφορά γιατί έχει δημιουργηθεί παραγγελία."
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
End Class
