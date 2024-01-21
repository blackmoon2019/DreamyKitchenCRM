Imports DevExpress.XtraEditors
Imports DevExpress.XtraReports.UI
Imports System.Data.SqlClient
Public Class CusOfferOrderCloset
    Private Valid As New ValidateControls
    Private ID As String
    Private sIsOrder As Boolean
    Private Mode As Byte
    Private CalledFromCtrl As Boolean
    Private CtrlCombo As DevExpress.XtraEditors.LookUpEdit
    Private DBQ As New DBQueries
    Private LoadForms As New FormLoader
    Private Frm As frmCUSOfferOrderCloset
    Private Prog_Prop As New ProgProp
    Public Sub Initialize(ByVal sFrm As frmCUSOfferOrderCloset, ByVal sID As String, ByVal sMode As Byte, ByVal sCalledFromCtrl As Boolean, ByVal sCtrlCombo As DevExpress.XtraEditors.LookUpEdit, ByVal IsOrder As Boolean)
        Frm = sFrm
        ID = sID
        Mode = sMode
        CalledFromCtrl = sCalledFromCtrl
        CtrlCombo = sCtrlCombo
        sIsOrder = IsOrder
    End Sub
    Public Sub LoadForm()
        'TODO: This line of code loads data into the 'DM_VALUELISTITEM.vw_VALUELISTITEMCloset' table. You can move, or remove it, as needed.
        Frm.Vw_VALUELISTITEMModelClosetTableAdapter.Fill(Frm.DM_VALUELISTITEM.vw_VALUELISTITEMModelCloset)
        'TODO: This line of code loads data into the 'DM_TRANS.CCT_TRANSH' table. You can move, or remove it, as needed.
        Frm.CCT_TRANSHTableAdapter.Fill(Frm.DM_TRANS.CCT_TRANSH)
        'TODO: This line of code loads data into the 'DreamyKitchenDataSet.vw_CCT' table. You can move, or remove it, as needed.
        Frm.Vw_CCTTableAdapter.Fill(Frm.DreamyKitchenDataSet.vw_CCT)
        'TODO: This line of code loads data into the 'DM_VALUELISTITEM.vw_VALUELISTITEM_V2' table. You can move, or remove it, as needed.
        Frm.Vw_VALUELISTITEM_V2TableAdapter.Fill(Frm.DM_VALUELISTITEM.vw_VALUELISTITEM_V2)
        'TODO: This line of code loads data into the 'DMDataSet.CCT_TRANSH' table. You can move, or remove it, as needed.
        Frm.CCT_TRANSHTableAdapter.Fill(Frm.DM_TRANS.CCT_TRANSH)
        'TODO: This line of code loads data into the 'DreamyKitchenDataSet.vw_SALERS' table. You can move, or remove it, as needed.
        Frm.Vw_SALERSTableAdapter.Fill(Frm.DreamyKitchenDataSet.vw_SALERS)
        Prog_Prop.GetProgPROSF()

        If sIsOrder = True Then
            Frm.LayoutControlGroup1.Text = "Στοιχεία Παραγγελίας"
            Frm.LayoutControlGroup3.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
            Frm.LayoutControlGroup11.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
            Frm.LayoutControlGroup12.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
            Frm.LayoutControlGroup13.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
            Frm.LayoutControlGroup15.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
            Frm.LofferAccepted.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
            Frm.LayoutControlItem30.Text = "Ημερ/νία Παραγγελίας"
        Else
            Frm.LayoutControlGroup1.Text = "Στοιχεία Προσφοράς"
            Frm.LayoutControlItem30.Text = "Ημερ/νία Προσφοράς"
            Frm.LayoutControlItem4.Text = "Αρ. Προσφοράς"
            Frm.LayoutControlGroup10.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        End If

        Select Case Mode
            Case FormMode.NewRecord
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
                    Frm.txtTransp.EditValue = ProgProps.ClosetTransp
                    Frm.txtMeasurement.EditValue = ProgProps.ClosetMeasurement
                    Frm.txtRemove.EditValue = ProgProps.ClosetRemove
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
                Frm.LayoutControlItem104.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
            Case FormMode.EditRecord
                Dim sFields As New Dictionary(Of String, String)
                LoadForms.LoadForm(Frm.LayoutControl1, "Select [ORDER].id as OrderID,CCT_ORDERS_CLOSET.* " &
                                                   " from CCT_ORDERS_CLOSET " &
                                                   " left join CCT_ORDERS_CLOSET  [ORDER] on [ORDER].CreatedFromOfferID =  CCT_ORDERS_CLOSET.id " &
                                                   " where CCT_ORDERS_CLOSET.id = " & toSQLValueS(ID), sFields)
                If sIsOrder = False Then
                    If sFields("OrderID") <> "" Then
                        'cmdConvertToOrder.Enabled = False
                        Frm.LayoutControlItem104.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
                        Frm.cmdSave.Enabled = False : Frm.cmdSaveEquipDev.Enabled = False
                        Frm.LabelControl1.Text = "Δεν μπορείτε να κάνετε αλλαγές στην προσφορά γιατί έχει δημιουργηθεί παραγγελία."
                    End If
                Else
                    'cmdConvertToOrder.Enabled = False
                    Frm.LayoutControlItem104.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
                    If sFields("CreatedFromOfferID") <> "" Then Frm.cboCUS.Enabled = False
                End If



                sFields = Nothing

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
                    ORDER BY NAME"
)

                Frm.TabNavigationPage2.Enabled = True

        End Select
        LoadForms.RestoreLayoutFromXml(Frm.GridView2, "CCT_ORDERS_CLOSET_EQUIPMENT_def.xml")
        Frm.GridView2.Columns.Item("name").OptionsColumn.AllowEdit = False : Frm.GridView2.Columns.Item("code").OptionsColumn.AllowEdit = False

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
                        sResult = DBQ.InsertNewData(DBQueries.InsertMode.OneLayoutControl, "CCT_ORDERS_CLOSET", Frm.LayoutControl1,,, sGuid, , "dtDeliver,IsOrder", toSQLValueS(CDate(sDate).ToString("yyyyMMdd")) & "," & IIf(sIsOrder = True, 1, 0))
                        ID = sGuid : sID = ID
                    Case FormMode.EditRecord
                        Dim sDate As String = Frm.lblDate.Text.Replace("Ημερομηνία Παράδοσης: ", "")
                        sResult = DBQ.UpdateNewData(DBQueries.InsertMode.OneLayoutControl, "CCT_ORDERS_CLOSET", Frm.LayoutControl1,,, sID,,,,, "dtDeliver=" & toSQLValueS(CDate(sDate).ToString("yyyyMMdd")) & ",IsOrder = " & IIf(sIsOrder = True, 1, 0))
                        sGuid = ID : sID = ID
                End Select

                If sResult = True Then
                    If Mode = FormMode.NewRecord Then
                        Frm.TabNavigationPage2.Enabled = True
                        If sIsOrder = False Then Frm.cmdConvertToOrder.Enabled = True : Frm.LayoutControlItem104.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
                        InsertSelectedRows(False)
                    End If
                    XtraMessageBox.Show("Η εγγραφή αποθηκέυτηκε με επιτυχία", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Information)

                    Mode = FormMode.EditRecord
                    Dim HasKitchen As Boolean, HasCloset As Boolean, HasDoors As Boolean, HasSc As Boolean
                    HasKitchen = Frm.cboTRANSH.GetColumnValue("Iskitchen")
                    HasCloset = Frm.cboTRANSH.GetColumnValue("Iscloset")
                    HasDoors = Frm.cboTRANSH.GetColumnValue("Isdoors")
                    HasSc = Frm.cboTRANSH.GetColumnValue("Issc")
                    If HasKitchen = False And HasCloset = False And HasDoors = False And HasSc = False Then
                        XtraMessageBox.Show("Κοστολόγηση δεν θα δημιουργηθεί λόγω έλλειψης συμφωνητικού", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Exit Sub
                    End If
                    Dim cmd As SqlCommand
                    Dim sdr As SqlDataReader
                    Dim sSQL As String
                    Dim cctOrderKitchen As String = "00000000-0000-0000-0000-000000000000"

                    sSQL = "select ID from CCT_ORDERS_KITCHEN where transhID = " & (toSQLValueS(Frm.cboTRANSH.EditValue.ToString))
                    cmd = New SqlCommand(sSQL, CNDB)
                    sdr = cmd.ExecuteReader()
                    If (sdr.Read() = True) Then
                        If sdr.IsDBNull(sdr.GetOrdinal("ID")) = False Then cctOrderKitchen = sdr.GetGuid(sdr.GetOrdinal("ID")).ToString
                    End If
                    sdr.Close()
                    cmd.Dispose()
                End If
            End If

        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
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
            If XtraMessageBox.Show("Θέλετε να μετατραπεί σε παραγγελία η προσφορά ?", ProgProps.ProgTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                Using oCmd As New SqlCommand("ConvertToOrder", CNDB)
                    oCmd.CommandType = CommandType.StoredProcedure
                    oCmd.Parameters.AddWithValue("@OfferID", ID)
                    oCmd.Parameters.AddWithValue("@createdBy", UserProps.ID)
                    oCmd.Parameters.AddWithValue("@Mode", 2)
                    oCmd.ExecuteNonQuery()
                End Using
                XtraMessageBox.Show("Η μετατροπή ολοκληρώθηκε με επιτυχία", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Information)
                'cmdConvertToOrder.Enabled = False
                Frm.cmdSave.Enabled = False : Frm.cmdSaveEquipDev.Enabled = False
                Frm.LayoutControlItem104.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
                Frm.LabelControl1.Text = "Δεν μπορείτε να κάνετε αλλαγές στην προσφορά γιατί έχει δημιουργηθεί παραγγελία."
            End If
        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
