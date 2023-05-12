Imports System.Data.SqlClient
Imports DevExpress.Utils
Imports DevExpress.Utils.Menu
Imports DevExpress.XtraBars.Navigation
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Menu
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraRichEdit.Model

Public Class frmCUSOfferOrderKitchen
    Private ManageCbo As New CombosManager
    Private sID As String
    Private sBaseCat As Integer
    Private sIsOrder As Boolean
    Private Ctrl As DevExpress.XtraGrid.Views.Grid.GridView
    Private Frm As DevExpress.XtraEditors.XtraForm
    Public Mode As Byte
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
    Public WriteOnly Property BaseCat As Integer
        Set(value As Integer)
            sBaseCat = value
        End Set
    End Property
    Public WriteOnly Property IsOrder As Boolean
        Set(value As Boolean)
            sIsOrder = value
        End Set
    End Property
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
    Private Sub frmCUSOrderKitchen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DM_DOORTYPES.vw_DOOR_TYPE_BENCH_V2' table. You can move, or remove it, as needed.
        Me.Vw_DOOR_TYPE_BENCH_V2TableAdapter.Fill(Me.DM_DOORTYPES.vw_DOOR_TYPE_BENCH_V2)
        'TODO: This line of code loads data into the 'DM_DOORTYPES.vw_DOOR_TYPE_V2' table. You can move, or remove it, as needed.
        Me.Vw_DOOR_TYPE_V2TableAdapter.Fill(Me.DM_DOORTYPES.vw_DOOR_TYPE_V2)
        Me.CCT_TRANSHTableAdapter.Fill(Me.DMDataSet.CCT_TRANSH)
        Me.BASE_CATTableAdapter.Fill(Me.DMDataSet.BASE_CAT)
        Me.Vw_BENCHTableAdapter.Fill(Me.DreamyKitchenDataSet.vw_BENCH)
        Me.Vw_CCTTableAdapter.Fill(Me.DreamyKitchenDataSet.vw_CCT)
        Me.Vw_SALERSTableAdapter.Fill(Me.DreamyKitchenDataSet.vw_SALERS)
        Me.Vw_COLORSGOLATableAdapter.Fill(Me.DreamyKitchenDataSet.vw_COLORSGOLA)
        Prog_Prop.GetProgPROSF()

        If sIsOrder = True Then
            LayoutControlGroup1.Text = "Στοιχεία Παραγγελίας"
            LayoutControlItem30.Text = "Ημερ/νία Παραγγελίας"
            LayoutControlGroup8.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
            LayoutControlGroup9.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
            LayoutControlItem71.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
            LayoutControlItem85.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        Else
            LayoutControlGroup1.Text = "Στοιχεία Προσφοράς"
            LayoutControlItem30.Text = "Ημερ/νία Προσφοράς"
            LayoutControlGroup8.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
            LayoutControlGroup9.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
            LayoutControlItem1.Tag = 0
            LayoutControlItem71.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        End If

        Select Case Mode
            Case FormMode.NewRecord
                'txtCode.Text = DBQ.GetNextId("CCT_ORDERS_KITCHEN")
                txtarProt.Text = DBQ.GetNextId("CCT_ORDERS_KITCHEN")
                cboEMP.EditValue = System.Guid.Parse(UserProps.EmpID.ToString.ToUpper)
                txtdtdaysOfDelivery.EditValue = ProgProps.DAYS_OF_DELIVERY
                txtTransp.EditValue = ProgProps.KitchenTransp
                txtMeasurement.EditValue = ProgProps.KitchenMeasurement
                txtRemove.EditValue = ProgProps.KitchenRemove
                cboBaseCat.EditValue = System.Guid.Parse(GetBaseCatID())
                dtOrder.EditValue = Date.Now
                LoadForms.LoadDataToGrid(grdEquipment, GridView2,
                    "Select  e.ID,E.code,name,price,cast(case when (SELECT FLdVAL FROM PRM_DET WHERE TBL='EQUIPMENT' AND fld='ID' AND fldVal=e.id) is null then 0 else 1 end as bit) as  checked,
                     case when (SELECT FLdVAL FROM PRM_DET WHERE TBL='EQUIPMENT' AND fld='ID' AND fldVal=e.id) is null then 0 else 1 end AS QTY,standard " &
                     "From vw_EQUIPMENT E where equipmentCatID='8AA21DC8-7D98-4596-8B73-9E664E955FFB' ORDER BY NAME")
                TabNavigationPage2.Enabled = False
                cmdConvertToOrder.Enabled = False
            Case FormMode.EditRecord
                Dim sFields As New Dictionary(Of String, String)
                LoadForms.LoadForm(LayoutControl1, "Select [ORDER].id as OrderID,CCT_ORDERS_KITCHEN.* " &
                                                   "from CCT_ORDERS_KITCHEN " &
                                                   " left join CCT_ORDERS_KITCHEN  [ORDER] on [ORDER].CreatedFromOfferID =  CCT_ORDERS_KITCHEN.id where CCT_ORDERS_DOOR.id = " & toSQLValueS(sID), sFields)
                If sIsOrder = False Then
                    If sFields("OrderID") <> "" Then
                        cmdConvertToOrder.Enabled = False
                        cmdSave.Enabled = False : cmdSaveEquipDev.Enabled = False
                        LabelControl1.Text = "Δεν μπορείτε να κάνετε αλλαγές στην προσφορά γιατί έχει δημιουργηθεί παραγγελία."
                    End If
                Else
                    cmdConvertToOrder.Enabled = False
                End If
                sFields = Nothing

                LoadForms.LoadDataToGrid(grdEquipment, GridView2,
                    "select e.ID,e.code,e.name,
                    isnull((select price from CCT_ORDERS_KITCHEN_EQUIPMENT EQ where eq.cctOrdersKitchenID= " & toSQLValueS(sID) & " And eq.equipmentID=e.id),e.price ) as price,
                    e.price as defPrice,
                    CAST(CASE WHEN (select eq.ID 
                    from CCT_ORDERS_KITCHEN_EQUIPMENT EQ 
                    where eq.cctOrdersKitchenID= " & toSQLValueS(sID) & " and eq.equipmentID=e.id) IS NULL THEN 0 ELSE 1 END AS BIT ) as checked,
                    isnull((select qty from CCT_ORDERS_KITCHEN_EQUIPMENT EQ where eq.cctOrdersKitchenID= " & toSQLValueS(sID) & " and eq.equipmentID=e.id),0) as QTY,standard
                    from EQUIPMENT E
                    ORDER BY NAME")
                TabNavigationPage2.Enabled = True

        End Select

        LoadForms.LoadDataToGrid(grdDevices, GridView1,
                    "select D.ID,D.code,D.name,(select dCode  from CCT_ORDERS_KITCHEN_DEVICES ED where ED.cctOrdersKitchenID=" & toSQLValueS(sID) & " AND  ED.devicesID =D.id) as dCode, 
                    isnull((select price  from CCT_ORDERS_KITCHEN_DEVICES ED where ED.cctOrdersKitchenID=" & toSQLValueS(sID) & " AND  ED.devicesID =D.id),0) as price,
                      CAST(CASE WHEN (select ED.ID 
                        from CCT_ORDERS_KITCHEN_DEVICES ED 
	                    where ED.cctOrdersKitchenID=" & toSQLValueS(sID) & " AND  ED.devicesID =D.id) IS NULL THEN 0 ELSE 1 END AS BIT ) as checked
                      from DEVICES D
                        ORDER BY NAME")
        LoadForms.RestoreLayoutFromXml(GridView2, "CCT_ORDERS_KITCHEN_EQUIPMENT_def.xml")
        LoadForms.RestoreLayoutFromXml(GridView1, "CCT_ORDERS_KITCHEN_DEVICES_def.xml")
        GridView2.Columns.Item("name").OptionsColumn.AllowEdit = False : GridView2.Columns.Item("code").OptionsColumn.AllowEdit = False
        GridView1.Columns.Item("name").OptionsColumn.AllowEdit = False : GridView1.Columns.Item("code").OptionsColumn.AllowEdit = False
        GridView2.Columns.Item("price").OptionsColumn.AllowEdit = False : GridView2.Columns.Item("standard").OptionsColumn.AllowEdit = False
        GridView1.OptionsMenu.ShowConditionalFormattingItem = True
        Me.CenterToScreen()

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

    Private Sub RepDefPrice_ButtonPressed(sender As Object, e As ButtonPressedEventArgs) Handles RepDefPrice.ButtonPressed
        Select Case e.Button.Index
            Case 0
                Dim sDefPrice As Decimal
                If GridView2.GetRowCellValue(GridView2.FocusedRowHandle, "defPrice") = Nothing Then
                    sDefPrice = 0
                Else
                    sDefPrice = GridView2.GetRowCellValue(GridView2.FocusedRowHandle, "defPrice")
                End If
                GridView2.SetRowCellValue(GridView2.FocusedRowHandle, "price", sDefPrice)
            Case 1 : GridView2.SetRowCellValue(GridView2.FocusedRowHandle, "price", "0.00")
        End Select
    End Sub

    Private Sub frmCUSOrderKitchen_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        If Me.WindowState = FormWindowState.Maximized Then frmMain.XtraTabbedMdiManager1.Dock(Me, frmMain.XtraTabbedMdiManager1)
    End Sub

    Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click
        Dim sResult As Boolean
        Dim sGuid As String
        Try
            If Valid.ValidateForm(LayoutControl1) Then
                Select Case Mode
                    Case FormMode.NewRecord
                        sGuid = System.Guid.NewGuid.ToString
                        Dim sDate As String = lblDate.Text.Replace("Ημερομηνία Παράδοσης: ", "")
                        sResult = DBQ.InsertNewData(DBQueries.InsertMode.OneLayoutControl, "CCT_ORDERS_KITCHEN", LayoutControl1,,, sGuid, True, "dtDeliver,IsOrder", toSQLValueS(CDate(sDate).ToString("yyyyMMdd")) & "," & IIf(sIsOrder = True, 1, 0))
                        sID = sGuid
                    Case FormMode.EditRecord
                        Dim sDate As String = lblDate.Text.Replace("Ημερομηνία Παράδοσης: ", "")
                        sResult = DBQ.UpdateNewData(DBQueries.InsertMode.OneLayoutControl, "CCT_ORDERS_KITCHEN", LayoutControl1,,, sID, True,,,, "dtDeliver=" & toSQLValueS(CDate(sDate).ToString("yyyyMMdd")) & ",IsOrder = " & IIf(sIsOrder = True, 1, 0))
                        'sGuid = sID
                End Select

                If FScrollerExist = True Then
                    Dim form As frmScroller = Frm
                    form.LoadRecords("vw_CCT_ORDERS_KITCHEN")
                End If

                If sResult = True Then
                    XtraMessageBox.Show("Η εγγραφή αποθηκέυτηκε με επιτυχία", "Dreamy Kitchen CRM", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    ' Καταχώρηση Εξοπλισμών
                    If Mode = FormMode.NewRecord Then
                        GridView1.PopulateColumns() : GridView2.PopulateColumns()
                        TabNavigationPage2.Enabled = True
                        InsertSelectedRows(False)
                        LoadForms.RestoreLayoutFromXml(GridView1, "CCT_ORDERS_KITCHEN_DEVICES_def.xml")
                        LoadForms.RestoreLayoutFromXml(GridView2, "CCT_ORDERS_KITCHEN_EQUIPMENT_def")
                        cmdConvertToOrder.Enabled = True
                    End If
                    Mode = FormMode.EditRecord
                    Dim HasKitchen As Boolean, HasCloset As Boolean, HasDoors As Boolean, HasSc As Boolean
                    HasKitchen = cboTRANSH.GetColumnValue("Iskitchen")
                    HasCloset = cboTRANSH.GetColumnValue("Iscloset")
                    HasDoors = cboTRANSH.GetColumnValue("Isdoors")
                    HasSc = cboTRANSH.GetColumnValue("Issc")
                    If HasKitchen = False And HasCloset = False And HasDoors = False And HasSc = False Then
                        XtraMessageBox.Show("Κοστολόγηση δεν θα δημιουργηθεί λόγω έλλειψης συμφωνητικού", "Dreamy Kitchen CRM", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Exit Sub
                    End If
                    ' Δημιουργία/Ενημέρωση Κοστολόγησης
                    Using oCmd As New SqlCommand("usp_InsertOrUpdateTransCost", CNDB)
                        oCmd.CommandType = CommandType.StoredProcedure
                        oCmd.Parameters.AddWithValue("@transhID", cboTRANSH.EditValue.ToString)
                        oCmd.Parameters.AddWithValue("@cctOrderKitchenID", sID)
                        oCmd.Parameters.AddWithValue("@Mode", 1)
                        oCmd.Parameters.AddWithValue("@UserID", UserProps.ID.ToString)
                        oCmd.ExecuteNonQuery()
                    End Using

                    'If Mode = FormMode.NewRecord Then
                    '    Cls.ClearCtrls(LayoutControl1)
                    '    txtCode.Text = DBQ.GetNextId("CCT_ORDERS_KITCHEN")
                    'End If
                End If
            End If

        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), "Dreamy Kitchen CRM", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cboCUS_EditValueChanged(sender As Object, e As EventArgs) Handles cboCUS.EditValueChanged
        'txtPhn.EditValue = cboCUS.GetColumnValue("phn")
        'txtArea.EditValue = cboCUS.GetColumnValue("AREAS_Name")
        'txtADR.EditValue = cboCUS.GetColumnValue("ADR_Name")
        Dim sCusID As String
        If cboCUS.EditValue Is Nothing Then sCusID = toSQLValueS(Guid.Empty.ToString) Else sCusID = toSQLValueS(cboCUS.EditValue.ToString)
        Dim sSQL As New System.Text.StringBuilder
        sSQL.AppendLine("Select T.id,FullTranshDescription,Description,Iskitchen,Iscloset,Isdoors,Issc
                        from vw_TRANSH t
                        where  completed = 0 and T.cusid = " & sCusID & "order by description")
        FillCbo.TRANSH(cboTRANSH, sSQL)

    End Sub

    Private Sub txtdtdaysOfDelivery_EditValueChanged(sender As Object, e As EventArgs) Handles txtdtdaysOfDelivery.EditValueChanged
        If dtOrder.EditValue Is Nothing Then Exit Sub
        If dtOrder.EditValue.ToString = "" Then Exit Sub
        Dim FirstDate As Date = dtOrder.EditValue
        lblDate.Text = "Ημερομηνία Παράδοσης: " & DateAdd("d", CDbl(txtdtdaysOfDelivery.EditValue.ToString), FirstDate).ToString("dd/MM/yyyy")
    End Sub

    Private Sub dtpresentation_EditValueChanged(sender As Object, e As EventArgs) Handles dtOrder.EditValueChanged
        If dtOrder.EditValue Is Nothing Then Exit Sub
        If dtOrder.EditValue.ToString = "" Then Exit Sub
        Dim FirstDate As Date = dtOrder.EditValue
        If txtdtdaysOfDelivery.EditValue Is Nothing Then txtdtdaysOfDelivery.EditValue = 0
        lblDate.Text = "Ημερομηνία Παράδοσης: " & DateAdd("d", CDbl(txtdtdaysOfDelivery.EditValue.ToString), FirstDate).ToString("dd/MM/yyyy")
    End Sub

    Private Sub cboVType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboVType.SelectedIndexChanged
        If cboVType.SelectedIndex = 1 Then
            cboGOLAColors.ReadOnly = False
        Else
            cboGOLAColors.ReadOnly = True
            cboGOLAColors.EditValue = Nothing
        End If
    End Sub


    Private Sub txtTotalErmariaVat_EditValueChanged(sender As Object, e As EventArgs) Handles txtTotalErmariaVat.EditValueChanged
        Dim TotalErmariaPrice As Double
        TotalErmariaPrice = (txtTotalErmariaVat.EditValue * (ProgProps.VAT / 100)) + txtTotalErmariaVat.EditValue
        txtTotalErmariaPice.EditValue = TotalErmariaPrice
    End Sub

    Private Sub InsertSelectedRows(ByVal msg As Boolean)
        Dim sSQL As String
        Dim I As Integer
        sSQL = "DELETE FROM CCT_ORDERS_KITCHEN_EQUIPMENT WHERE cctOrdersKitchenID = " & toSQLValueS(sID)
        Using oCmd As New SqlCommand(sSQL, CNDB)
            oCmd.ExecuteNonQuery()
        End Using
        If sIsOrder = True Then
            sSQL = "DELETE FROM CCT_ORDERS_KITCHEN_DEVICES WHERE cctOrdersKitchenID = " & toSQLValueS(sID)
            Using oCmd As New SqlCommand(sSQL, CNDB)
                oCmd.ExecuteNonQuery()
            End Using
        End If
        Dim Selected As Boolean
        Dim sPrice As Decimal
        For I = 0 To GridView2.RowCount - 1
            Selected = GridView2.GetRowCellValue(I, "checked")
            If Selected = True Then
                If GridView2.GetRowCellValue(I, "price") = 0 Then
                    sPrice = GridView2.GetRowCellValue(I, "defPrice")
                Else
                    sPrice = GridView2.GetRowCellValue(I, "price")
                End If
                sSQL = "INSERT INTO CCT_ORDERS_KITCHEN_EQUIPMENT(cctOrdersKitchenID,equipmentID,price,selected,qty) " &
                        " VALUES ( " & toSQLValueS(sID) & "," & toSQLValueS(GridView2.GetRowCellValue(I, "ID").ToString) & "," & toSQLValueS(sPrice.ToString, True) & ",1," & toSQLValueS(GridView2.GetRowCellValue(I, "QTY").ToString, True) & ")"
                Using oCmd As New SqlCommand(sSQL, CNDB)
                    oCmd.ExecuteNonQuery()
                End Using
            End If
        Next
        If sIsOrder = True Then
            Dim DcodeIsEmpty As Boolean = False
            For I = 0 To GridView1.RowCount - 1
                Selected = GridView1.GetRowCellValue(I, "checked")
                If Selected = True Then
                    If GridView1.GetRowCellValue(I, "dCode").ToString = "" Then DcodeIsEmpty = True
                    If GridView1.GetRowCellValue(I, "dCode").ToString.Length > 0 Then
                        sSQL = "INSERT INTO CCT_ORDERS_KITCHEN_DEVICES(cctOrdersKitchenID,devicesID,dCode,Price,selected) " &
                    " VALUES ( " & toSQLValueS(sID) & "," & toSQLValueS(GridView1.GetRowCellValue(I, "ID").ToString) & "," & toSQLValueS(GridView1.GetRowCellValue(I, "dCode").ToString) & "," & toSQLValueS(GridView1.GetRowCellValue(I, "price").ToString, True) & ",1)"
                        Using oCmd As New SqlCommand(sSQL, CNDB)
                            oCmd.ExecuteNonQuery()
                        End Using
                    End If
                End If
            Next
            If DcodeIsEmpty = True Then
                If msg Then XtraMessageBox.Show("Δεν έχετε καταχωρήσει Κωδικούς συσκευών", "Dreamy Kitchen CRM", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                If msg Then XtraMessageBox.Show("Η εγγραφή αποθηκέυτηκε με επιτυχία", "Dreamy Kitchen CRM", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Else
            If msg Then XtraMessageBox.Show("Η εγγραφή αποθηκέυτηκε με επιτυχία", "Dreamy Kitchen CRM", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub

    Private Sub GridView1_PopupMenuShowing(sender As Object, e As PopupMenuShowingEventArgs) Handles GridView1.PopupMenuShowing
        If e.MenuType = GridMenuType.Column Then LoadForms.PopupMenuShow(e, GridView1, "CCT_ORDERS_KITCHEN_DEVICES_def.xml", "vw_CCT_ORDERS_KITCHEN_DEVICES")
    End Sub
    Private Sub GridView2_PopupMenuShowing(sender As Object, e As PopupMenuShowingEventArgs) Handles GridView2.PopupMenuShowing
        If e.MenuType = GridMenuType.Column Then LoadForms.PopupMenuShow(e, GridView2, "CCT_ORDERS_KITCHEN_EQUIPMENT_def.xml", "vw_CCT_ORDERS_KITCHEN_EQUIPMENT")
    End Sub

    Private Sub cmdPrintOffer_Click(sender As Object, e As EventArgs) Handles cmdPrintOffer.Click
        Dim report As New RepCUSOrderKitchen()

        report.Parameters.Item(0).Value = sID
        report.CreateDocument()
        'report.PrintingSystem.Document.ScaleFactor = 0.75

        Dim report2 As New RepCUSOrderKitchen2ndPage

        report2.Parameters.Item(0).Value = sID
        report2.Parameters.Item(1).Value = sID
        report2.Parameters.Item(2).Value = sID
        report2.CreateDocument()
        report.ModifyDocument(Sub(x)
                                  x.AddPages(report2.Pages)
                              End Sub)
        Dim printTool As New ReportPrintTool(report)
        printTool.ShowRibbonPreview()
    End Sub

    Private Sub cboTRANSH_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboTRANSH.ButtonClick
        Select Case e.Button.Index
            Case 1 : ManageCbo.ManageTRANSH(cboTRANSH, FormMode.NewRecord)
            Case 2 : ManageCbo.ManageTRANSH(cboTRANSH, FormMode.EditRecord)
            Case 3 : cboTRANSH.EditValue = Nothing
        End Select
    End Sub

    Private Sub cmdSaveEquipDev_Click(sender As Object, e As EventArgs) Handles cmdSaveEquipDev.Click
        InsertSelectedRows(True)
    End Sub

    Private Sub GridView1_CustomDrawFooterCell(sender As Object, e As FooterCellCustomDrawEventArgs) Handles GridView1.CustomDrawFooterCell
        Dim sSQL As String
        Dim cmd As SqlCommand
        Try
            txtTotalDevicesPrice.EditValue = GridView1.Columns("price").SummaryItem.SummaryValue

            sSQL = "Update CCT_ORDERS_KITCHEN set TotalEquipmentPrice = " & toSQLValueS(txtTotalDevicesPrice.EditValue.ToString, True) & " where ID = " & toSQLValueS(sID)
            cmd = New SqlCommand(sSQL, CNDB) : cmd.ExecuteNonQuery()
        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), "Dreamy Kitchen CRM", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub chkVatVisible_CheckedChanged(sender As Object, e As EventArgs) Handles chkVatVisible.CheckedChanged
        'Dim ProFPA As Double = DbnullToZero(txtTotalErmariaVat)
        'Dim MeFPA As Double = DbnullToZero(txtTotalErmariaPice)
        'If chkVatVisible.Checked = True Then
        '    txtPartofVat.EditValue = MeFPA - ProFPA
        'Else
        '    txtPartofVat.EditValue = 0
        'End If
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
            Case 1 : ManageCbo.ManageCCT(FormMode.NewRecord, False,, cboCUS)
            Case 2 : ManageCbo.ManageCCT(FormMode.EditRecord, False,, cboCUS)
            Case 3 : cboCUS.EditValue = Nothing
        End Select
    End Sub
    Private Sub cboVBOXColors_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboVBOXColors.ButtonClick
        Select Case e.Button.Index
            Case 1 : ManageCbo.ManageColors(cboVBOXColors, FormMode.NewRecord)
            Case 2 : ManageCbo.ManageColors(cboVBOXColors, FormMode.EditRecord)
            Case 3 : cboVBOXColors.EditValue = Nothing
        End Select
    End Sub

    Private Sub cboKBOXColors_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboKBOXColors.ButtonClick
        Select Case e.Button.Index
            Case 1 : ManageCbo.ManageColors(cboKBOXColors, FormMode.NewRecord)
            Case 2 : ManageCbo.ManageColors(cboKBOXColors, FormMode.EditRecord)
            Case 3 : cboKBOXColors.EditValue = Nothing
        End Select
    End Sub


    Private Sub cboYBOXColors_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboYBOXColors.ButtonClick
        Select Case e.Button.Index
            Case 1 : ManageCbo.ManageColors(cboYBOXColors, FormMode.NewRecord)
            Case 2 : ManageCbo.ManageColors(cboYBOXColors, FormMode.EditRecord)
            Case 3 : cboYBOXColors.EditValue = Nothing
        End Select
    End Sub

    Private Sub cboGOLAColors_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboGOLAColors.ButtonClick
        Select Case e.Button.Index
            Case 1 : ManageCbo.ManageColors(cboGOLAColors, FormMode.NewRecord)
            Case 2 : ManageCbo.ManageColors(cboGOLAColors, FormMode.EditRecord)
            Case 3 : cboGOLAColors.EditValue = Nothing
        End Select
    End Sub

    Private Sub cboVDoorType_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboVDoorType.ButtonClick
        Select Case e.Button.Index
            Case 1 : ManageCbo.ManageDoorType(cboVDoorType, FormMode.NewRecord)
            Case 2 : ManageCbo.ManageDoorType(cboVDoorType, FormMode.EditRecord)
            Case 3 : cboVDoorType.EditValue = Nothing
        End Select
    End Sub
    Private Sub cboKDoorType_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboKDoorType.ButtonClick
        Select Case e.Button.Index
            Case 1 : ManageCbo.ManageDoorType(cboKDoorType, FormMode.NewRecord)
            Case 2 : ManageCbo.ManageDoorType(cboKDoorType, FormMode.EditRecord)
            Case 3 : cboKDoorType.EditValue = Nothing
        End Select
    End Sub
    Private Sub cboYDoorType_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboYDoorType.ButtonClick
        Select Case e.Button.Index
            Case 1 : ManageCbo.ManageDoorType(cboYDoorType, FormMode.NewRecord)
            Case 2 : ManageCbo.ManageDoorType(cboYDoorType, FormMode.EditRecord)
            Case 3 : cboYDoorType.EditValue = Nothing
        End Select
    End Sub
    Private Sub cboVDoorType1_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboVDoorType1.ButtonClick
        Select Case e.Button.Index
            Case 1 : ManageCbo.ManageDoorType(cboVDoorType1, FormMode.NewRecord)
            Case 2 : ManageCbo.ManageDoorType(cboVDoorType1, FormMode.EditRecord)
            Case 3 : cboVDoorType1.EditValue = Nothing
        End Select
    End Sub
    Private Sub cboKDoorType1_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboKDoorType1.ButtonClick
        Select Case e.Button.Index
            Case 1 : ManageCbo.ManageDoorType(cboKDoorType1, FormMode.NewRecord)
            Case 2 : ManageCbo.ManageDoorType(cboKDoorType1, FormMode.EditRecord)
            Case 3 : cboKDoorType1.EditValue = Nothing
        End Select
    End Sub
    Private Sub cboYDoorType1_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboYDoorType1.ButtonClick
        Select Case e.Button.Index
            Case 1 : ManageCbo.ManageDoorType(cboYDoorType1, FormMode.NewRecord)
            Case 2 : ManageCbo.ManageDoorType(cboYDoorType1, FormMode.EditRecord)
            Case 3 : cboYDoorType1.EditValue = Nothing
        End Select
    End Sub
    Private Sub cboVependisisDoorType_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboVependisisDoorType.ButtonClick
        Select Case e.Button.Index
            Case 1 : ManageCbo.ManageDoorType(cboVependisisDoorType, FormMode.NewRecord)
            Case 2 : ManageCbo.ManageDoorType(cboVependisisDoorType, FormMode.EditRecord)
            Case 3 : cboVependisisDoorType.EditValue = Nothing
        End Select
    End Sub
    Private Sub cboKependisisDoorType_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboKependisisDoorType.ButtonClick
        Select Case e.Button.Index
            Case 1 : ManageCbo.ManageDoorType(cboKependisisDoorType, FormMode.NewRecord)
            Case 2 : ManageCbo.ManageDoorType(cboKependisisDoorType, FormMode.EditRecord)
            Case 3 : cboKependisisDoorType.EditValue = Nothing
        End Select
    End Sub
    Private Sub cboSndEpendisisDoorType_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboSndEpendisisDoorType.ButtonClick
        Select Case e.Button.Index
            Case 1 : ManageCbo.ManageDoorType(cboSndEpendisisDoorType, FormMode.NewRecord)
            Case 2 : ManageCbo.ManageDoorType(cboSndEpendisisDoorType, FormMode.EditRecord)
            Case 3 : cboSndEpendisisDoorType.EditValue = Nothing
        End Select
    End Sub
    Private Sub cboNependisisDoorType_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboNependisisDoorType.ButtonClick
        Select Case e.Button.Index
            Case 1 : ManageCbo.ManageDoorType(cboNependisisDoorType, FormMode.NewRecord)
            Case 2 : ManageCbo.ManageDoorType(cboNependisisDoorType, FormMode.EditRecord)
            Case 3 : cboNependisisDoorType.EditValue = Nothing
        End Select
    End Sub
    Private Sub cboVRafieraDoorType_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboVRafieraDoorType.ButtonClick
        Select Case e.Button.Index
            Case 1 : ManageCbo.ManageDoorType(cboVRafieraDoorType, FormMode.NewRecord)
            Case 2 : ManageCbo.ManageDoorType(cboVRafieraDoorType, FormMode.EditRecord)
            Case 3 : cboVRafieraDoorType.EditValue = Nothing
        End Select
    End Sub
    Private Sub cboYRafieraDoorType_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboYRafieraDoorType.ButtonClick
        Select Case e.Button.Index
            Case 1 : ManageCbo.ManageDoorType(cboYRafieraDoorType, FormMode.NewRecord)
            Case 2 : ManageCbo.ManageDoorType(cboYRafieraDoorType, FormMode.EditRecord)
            Case 3 : cboYRafieraDoorType.EditValue = Nothing
        End Select
    End Sub
    Private Sub cboKRafieraDoorType_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboKRafieraDoorType.ButtonClick
        Select Case e.Button.Index
            Case 1 : ManageCbo.ManageDoorType(cboKRafieraDoorType, FormMode.NewRecord)
            Case 2 : ManageCbo.ManageDoorType(cboKRafieraDoorType, FormMode.EditRecord)
            Case 3 : cboKRafieraDoorType.EditValue = Nothing
        End Select
    End Sub
    Private Sub cboBenchType_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboBenchType.ButtonClick
        Select Case e.Button.Index
            Case 1 : ManageCbo.ManageBENCH(cboBenchType, Me, FormMode.NewRecord)
            Case 2 : ManageCbo.ManageBENCH(cboBenchType, Me, FormMode.EditRecord)
            Case 3 : cboBenchType.EditValue = Nothing
        End Select
    End Sub
    Private Sub cboBenchType2_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboBenchType2.ButtonClick
        Select Case e.Button.Index
            Case 1 : ManageCbo.ManageBENCH(cboBenchType2, Me, FormMode.NewRecord)
            Case 2 : ManageCbo.ManageBENCH(cboBenchType2, Me, FormMode.EditRecord)
            Case 3 : cboBenchType2.EditValue = Nothing
        End Select
    End Sub
    Private Sub cboBack_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboBack.ButtonClick
        Select Case e.Button.Index
            Case 1 : ManageCbo.ManageBENCH(cboBack, Me, FormMode.NewRecord)
            Case 2 : ManageCbo.ManageBENCH(cboBack, Me, FormMode.EditRecord)
            Case 3 : cboBack.EditValue = Nothing
        End Select
    End Sub
    Private Sub cboKWallRafiaDoorType_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboKWallRafiaDoorType.ButtonClick
        Select Case e.Button.Index
            Case 1 : ManageCbo.ManageDoorType(cboKWallRafiaDoorType, FormMode.NewRecord)
            Case 2 : ManageCbo.ManageDoorType(cboKWallRafiaDoorType, FormMode.EditRecord)
            Case 3 : cboKWallRafiaDoorType.EditValue = Nothing
        End Select
    End Sub
    Private Sub cboPependisisDoorType_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboPependisisDoorType.ButtonClick
        Select Case e.Button.Index
            Case 1 : ManageCbo.ManageDoorType(cboPependisisDoorType, FormMode.NewRecord)
            Case 2 : ManageCbo.ManageDoorType(cboPependisisDoorType, FormMode.EditRecord)
            Case 3 : cboPependisisDoorType.EditValue = Nothing
        End Select
    End Sub

    Private Sub cbovType_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboVType.ButtonClick
        Select Case e.Button.Index
            Case 1 : cboVType.EditValue = Nothing : cboVBOXColors.EditValue = Nothing
        End Select
    End Sub
    Private Sub cboKType_ButtonClick(sender As Object, e As ButtonPressedEventArgs)
        Select Case e.Button.Index
            Case 1 : cboKBOXColors.EditValue = Nothing
        End Select
    End Sub
    Private Sub cboyType_ButtonClick(sender As Object, e As ButtonPressedEventArgs)
        Select Case e.Button.Index
            Case 1 : cboYBOXColors.EditValue = Nothing
        End Select
    End Sub

    'Private Sub LoadDoorType(ByVal cboEdit As ComboBoxEdit, ByVal lkupEditColor As LookUpEdit, ByVal lkupEditDoorType As LookUpEdit, ByVal doorCatID As String)
    '    If Me.IsActive = False Then Exit Sub
    '    If cboEdit.SelectedIndex = -1 Or lkupEditColor.EditValue = Nothing Then Exit Sub
    '    'Me.Vw_DOOR_TYPE1TableAdapter.FillByTypeAndDoorColor(Me.DMDataSet.vw_DOOR_TYPE1, cboEdit.SelectedIndex, System.Guid.Parse(lkupEditColor.EditValue.ToString))
    '    Dim sSQL = New System.Text.StringBuilder
    '    sSQL.AppendLine("Select id,name,price from vw_DOOR_TYPE where doorCatID = " & toSQLValueS(doorCatID) & "  and type = " & cboEdit.SelectedIndex & " and doorColorID = " & toSQLValueS(lkupEditColor.EditValue.ToString) & " ORDER BY cat, dimName ")
    '    FillCbo.DOOR_TYPE(lkupEditDoorType, sSQL)
    '    'lkupEditDoorType.Enabled = True
    'End Sub

    Private Sub cboBaza_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboBaza.ButtonClick
        Select Case e.Button.Index
            Case 1 : cboBaza.EditValue = Nothing
        End Select
    End Sub

    Private Sub cboLegs_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboLegs.ButtonClick
        Select Case e.Button.Index
            Case 1 : cboLegs.EditValue = Nothing
        End Select
    End Sub

    Private Sub cboVwater_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboVwater.ButtonClick
        Select Case e.Button.Index
            Case 1 : cboVwater.EditValue = Nothing
        End Select
    End Sub
    Private Sub cboYwater_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboYwater.ButtonClick
        Select Case e.Button.Index
            Case 1 : cboYwater.EditValue = Nothing
        End Select
    End Sub
    Private Sub cboKwater_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboKwater.ButtonClick
        Select Case e.Button.Index
            Case 1 : cboKwater.EditValue = Nothing
        End Select
    End Sub

    Private Sub cboLedProfil_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboLedProfil.ButtonClick
        Select Case e.Button.Index
            Case 1 : cboLedProfil.EditValue = Nothing
        End Select
    End Sub



    Private Sub TabPane1_SelectedPageChanged(sender As Object, e As SelectedPageChangedEventArgs) Handles TabPane1.SelectedPageChanged
        Select Case TabPane1.SelectedPageIndex
            Case 1
                LoadForms.RestoreLayoutFromXml(GridView2, "CCT_ORDERS_KITCHEN_EQUIPMENT_def.xml")
                LoadForms.RestoreLayoutFromXml(GridView1, "CCT_ORDERS_KITCHEN_DEVICES_def.xml")
        End Select
    End Sub

    Private Sub GridView2_ValidatingEditor(sender As Object, e As BaseContainerValidateEditorEventArgs) Handles GridView2.ValidatingEditor
        Dim grdView As GridView = sender
        If grdView.FocusedColumn.FieldName = "checked" Then
            If CStr(e.Value) = "False" Then
                GridView2.SetRowCellValue(GridView2.FocusedRowHandle, "QTY", 0)
            Else
                GridView2.SetRowCellValue(GridView2.FocusedRowHandle, "QTY", 1)
                GridView2.SetRowCellValue(GridView2.FocusedRowHandle, "price", GridView2.GetRowCellValue(GridView2.FocusedRowHandle, "defPrice"))
            End If
        End If
        If grdView.FocusedColumn.FieldName = "QTY" Then
            If CStr(e.Value) = "" Then Exit Sub
            Dim sTot As Decimal = e.Value * GridView2.GetRowCellValue(GridView2.FocusedRowHandle, "defPrice")
            GridView2.SetRowCellValue(GridView2.FocusedRowHandle, "price", sTot)
        End If
    End Sub

    Private Sub cmdConvertToOrder_Click(sender As Object, e As EventArgs) Handles cmdConvertToOrder.Click
        Try
            If XtraMessageBox.Show("Θέλετε να μετατραπεί σε παραγγελία η προσφορά ?", "Dreamy Kitchen CRM", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                Using oCmd As New SqlCommand("ConvertToOrder", CNDB)
                    oCmd.CommandType = CommandType.StoredProcedure
                    oCmd.Parameters.AddWithValue("@OfferID", sID)
                    oCmd.Parameters.AddWithValue("@createdBy", UserProps.ID)
                    oCmd.Parameters.AddWithValue("@Mode", 1)
                    oCmd.ExecuteNonQuery()
                End Using
                XtraMessageBox.Show("Η μετατροπή ολοκληρώθηκε με επιτυχία", "Dreamy Kitchen CRM", MessageBoxButtons.OK, MessageBoxIcon.Information)
                cmdConvertToOrder.Enabled = False : cmdSave.Enabled = False
                LabelControl1.Text = "Δεν μπορείτε να κάνετε αλλαγές στην προσφορά γιατί έχει δημιουργηθεί παραγγελία."
            End If
        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), "Dreamy Kitchen CRM", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub txtInitialPrice1_EditValueChanged(sender As Object, e As EventArgs) Handles txtInitialPrice1.EditValueChanged
        Dim Disc As Double, Discount As Double, InitialPrice As Double, FinalPrice As Double
        txtDisc1.EditValue = ProgProps.CusDiscountKitchen
        If ProgProps.CusDiscountKitchen > 0 Then
            InitialPrice = txtInitialPrice1.EditValue
            Disc = ProgProps.CusDiscountKitchen / 100
            Discount = Disc * InitialPrice
            FinalPrice = InitialPrice - Discount
            txtInitialPrice1.EditValue = InitialPrice
            txtDiscount1.EditValue = Discount
            txtFinalPrice1.EditValue = FinalPrice
        End If
    End Sub

    Private Sub txtInitialPrice2_EditValueChanged(sender As Object, e As EventArgs) Handles txtInitialPrice2.EditValueChanged
        Dim Disc As Double, Discount As Double, InitialPrice As Double, FinalPrice As Double
        txtDisc2.EditValue = ProgProps.CusDiscountKitchen
        If ProgProps.CusDiscountKitchen > 0 Then
            InitialPrice = txtInitialPrice2.EditValue
            Disc = ProgProps.CusDiscountKitchen / 100
            Discount = Disc * InitialPrice
            FinalPrice = InitialPrice - Discount
            txtInitialPrice2.EditValue = InitialPrice
            txtDiscount2.EditValue = Discount
            txtFinalPrice2.EditValue = FinalPrice
        End If

    End Sub

    Private Sub txtInitialPrice3_EditValueChanged(sender As Object, e As EventArgs) Handles txtInitialPrice3.EditValueChanged
        Dim Disc As Double, Discount As Double, InitialPrice As Double, FinalPrice As Double
        txtDisc3.EditValue = ProgProps.CusDiscountKitchen
        If ProgProps.CusDiscountKitchen > 0 Then
            InitialPrice = txtInitialPrice3.EditValue
            Disc = ProgProps.CusDiscountKitchen / 100
            Discount = Disc * InitialPrice
            FinalPrice = InitialPrice - Discount
            txtInitialPrice3.EditValue = InitialPrice
            txtDiscount3.EditValue = Discount
            txtFinalPrice3.EditValue = FinalPrice
        End If
    End Sub

    Private Sub txtInitialPrice4_EditValueChanged(sender As Object, e As EventArgs) Handles txtInitialPrice4.EditValueChanged
        Dim Disc As Double, Discount As Double, InitialPrice As Double, FinalPrice As Double
        txtDisc4.EditValue = ProgProps.CusDiscountKitchen
        If ProgProps.CusDiscountKitchen > 0 Then
            InitialPrice = txtInitialPrice4.EditValue
            Disc = ProgProps.CusDiscountKitchen / 100
            Discount = Disc * InitialPrice
            FinalPrice = InitialPrice - Discount
            txtInitialPrice4.EditValue = InitialPrice
            txtDiscount4.EditValue = Discount
            txtFinalPrice4.EditValue = FinalPrice
        End If
    End Sub
End Class