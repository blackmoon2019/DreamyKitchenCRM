Imports System.Data.SqlClient
Imports DevExpress.CodeParser
Imports DevExpress.Utils
Imports DevExpress.Utils.Menu
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraGrid.Menu
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraReports.UI

Public Class frmCUSOfferOrderCloset
    Private ManageCbo As New CombosManager
    Private sID As String
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

    Private Sub frmCUSOrderCloset_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DM_DOORTYPES.vw_DOOR_TYPE_V2' table. You can move, or remove it, as needed.
        Me.Vw_DOOR_TYPE_V2TableAdapter.Fill(Me.DM_DOORTYPES.vw_DOOR_TYPE_V2)
        'TODO: This line of code loads data into the 'DMDataSet.CCT_TRANSH' table. You can move, or remove it, as needed.
        Me.CCT_TRANSHTableAdapter.Fill(Me.DMDataSet.CCT_TRANSH)
        'TODO: This line of code loads data into the 'DreamyKitchenDataSet.vw_SALERS' table. You can move, or remove it, as needed.
        Me.Vw_SALERSTableAdapter.Fill(Me.DreamyKitchenDataSet.vw_SALERS)
        Prog_Prop.GetProgPROSF()

        If sIsOrder = True Then
            LayoutControlGroup1.Text = "Στοιχεία Παραγγελίας"
            LayoutControlGroup3.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
            LayoutControlGroup11.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
            LayoutControlGroup12.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
            LayoutControlGroup13.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
            LayoutControlItem30.Text = "Ημερ/νία Παραγγελίας"
        Else
            LayoutControlGroup1.Text = "Στοιχεία Προσφοράς"
            LayoutControlItem30.Text = "Ημερ/νία Προσφοράς"
            LayoutControlGroup10.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
            LayoutControlItem1.Tag = 0
        End If

        Select Case Mode
            Case FormMode.NewRecord
                txtarProt.Text = DBQ.GetNextId("CCT_ORDERS_CLOSET")
                cboEMP.EditValue = System.Guid.Parse(UserProps.ID.ToString.ToUpper)
                txtdtdaysOfDelivery.EditValue = ProgProps.DAYS_OF_DELIVERY
                cboBackThikness.EditValue = ProgProps.CLOSET_BACK_THIKNESS
                cboboxThikness.EditValue = ProgProps.CLOSET_BOX_THIKNESS
                txtdrawers.EditValue = ProgProps.CLOSET_DRAWERS
                cboBackThikness2.EditValue = ProgProps.CLOSET_BACK_THIKNESS
                cboboxThikness2.EditValue = ProgProps.CLOSET_BOX_THIKNESS
                txtdrawers2.EditValue = ProgProps.CLOSET_DRAWERS
                cboBackThikness3.EditValue = ProgProps.CLOSET_BACK_THIKNESS
                cboboxThikness3.EditValue = ProgProps.CLOSET_BOX_THIKNESS
                txtdrawers3.EditValue = ProgProps.CLOSET_DRAWERS
                cboBackThikness4.EditValue = ProgProps.CLOSET_BACK_THIKNESS
                cboboxThikness4.EditValue = ProgProps.CLOSET_BOX_THIKNESS
                txtdrawers4.EditValue = ProgProps.CLOSET_DRAWERS
                cboBackThikness5.EditValue = ProgProps.CLOSET_BACK_THIKNESS
                cboboxThikness5.EditValue = ProgProps.CLOSET_BOX_THIKNESS
                txtdrawers5.EditValue = ProgProps.CLOSET_DRAWERS
                cboBackThikness6.EditValue = ProgProps.CLOSET_BACK_THIKNESS
                cboboxThikness6.EditValue = ProgProps.CLOSET_BOX_THIKNESS
                txtdrawers6.EditValue = ProgProps.CLOSET_DRAWERS

                txtTransp.EditValue = ProgProps.ClosetTransp
                txtMeasurement.EditValue = ProgProps.ClosetMeasurement
                txtRemove.EditValue = ProgProps.ClosetRemove

                LoadForms.LoadDataToGrid(grdEquipment, GridView2,
                    "Select  e.ID,E.code,name,price,e.price as defPrice,cast(case when (SELECT FLdVAL FROM PRM_DET WHERE TBL='EQUIPMENT' AND fld='ID' AND fldVal=e.id) is null then 0 else 1 end as bit) as  checked, " &
                    "case when (SELECT FLdVAL FROM PRM_DET WHERE TBL='EQUIPMENT' AND fld='ID' AND fldVal=e.id) is null then 0 else 1 end AS QTY,standard " &
                     "From vw_EQUIPMENT E where equipmentCatID='DB158CAB-11EA-423B-9430-0C8A0CEB1D62' ORDER BY NAME")
                TabNavigationPage2.Enabled = False
                cmdConvertToOrder.Enabled = False
            Case FormMode.EditRecord
                Dim sFields As New Dictionary(Of String, String)
                LoadForms.LoadForm(LayoutControl1, "Select [ORDER].id as OrderID,CCT_ORDERS_CLOSET.* " &
                                                   " from CCT_ORDERS_CLOSET " &
                                                   " left join CCT_ORDERS_CLOSET  [ORDER] on [ORDER].CreatedFromOfferID =  CCT_ORDERS_CLOSET.id " &
                                                   " where CCT_ORDERS_DOOR.id = " & toSQLValueS(sID), sFields)
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
                    isnull((select price from CCT_ORDERS_CLOSET_EQUIPMENT EQ where eq.cctOrdersClosetID= " & toSQLValueS(sID) & " And eq.equipmentID=e.id),e.price ) as price,
                    e.price as defPrice,
                    CAST(CASE WHEN (select eq.ID 
                    from CCT_ORDERS_CLOSET_EQUIPMENT EQ 
                    where eq.cctOrdersClosetID= " & toSQLValueS(sID) & " and eq.equipmentID=e.id) IS NULL THEN 0 ELSE 1 END AS BIT ) as checked,
                    isnull((select qty from CCT_ORDERS_CLOSET_EQUIPMENT EQ where eq.cctOrdersClosetID= " & toSQLValueS(sID) & " and eq.equipmentID=e.id),0) as QTY,standard
                    from EQUIPMENT E
                    where equipmentCatID='DB158CAB-11EA-423B-9430-0C8A0CEB1D62'
                    ORDER BY NAME")

                TabNavigationPage2.Enabled = True

        End Select
        LoadForms.RestoreLayoutFromXml(GridView2, "CCT_ORDERS_CLOSET_EQUIPMENT_def.xml")
        GridView2.Columns.Item("name").OptionsColumn.AllowEdit = False : GridView2.Columns.Item("code").OptionsColumn.AllowEdit = False
        GridView2.Columns.Item("price").OptionsColumn.AllowEdit = False
        Me.CenterToScreen()


    End Sub


    Private Sub frmCUSOrderCloset_Resize(sender As Object, e As EventArgs) Handles Me.Resize
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
                        sResult = DBQ.InsertNewData(DBQueries.InsertMode.OneLayoutControl, "CCT_ORDERS_CLOSET", LayoutControl1,,, sGuid,, "isOrder", IIf(sIsOrder = True, 1, 0))
                        sID = sGuid
                    Case FormMode.EditRecord
                        sResult = DBQ.UpdateNewData(DBQueries.InsertMode.OneLayoutControl, "CCT_ORDERS_CLOSET", LayoutControl1,,, sID,,,,, "isOrder=" & IIf(sIsOrder = True, 1, 0))
                        'sGuid = sID
                End Select

                If FScrollerExist = True Then
                    Dim form As frmScroller = Frm
                    form.LoadRecords("vw_CCT_ORDERS_CLOSET")
                End If

                If sResult = True Then
                    XtraMessageBox.Show("Η εγγραφή αποθηκέυτηκε με επιτυχία", "Dreamy Kitchen CRM", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Mode = FormMode.EditRecord
                    TabNavigationPage2.Enabled = True
                    cmdConvertToOrder.Enabled = True

                    Dim HasKitchen As Boolean, HasCloset As Boolean, HasDoors As Boolean, HasSc As Boolean
                    HasKitchen = cboTRANSH.GetColumnValue("Iskitchen")
                    HasCloset = cboTRANSH.GetColumnValue("Iscloset")
                    HasDoors = cboTRANSH.GetColumnValue("Isdoors")
                    HasSc = cboTRANSH.GetColumnValue("Issc")
                    If HasKitchen = False And HasCloset = False And HasDoors = False And HasSc = False Then
                        XtraMessageBox.Show("Κοστολόγηση δεν θα δημιουργηθεί λόγω έλλειψης συμφωνητικού", "Dreamy Kitchen CRM", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Exit Sub
                    End If
                    Dim cmd As SqlCommand
                    Dim sdr As SqlDataReader
                    Dim sSQL As String
                    Dim cctOrderKitchen As String = "00000000-0000-0000-0000-000000000000"

                    sSQL = "select ID from CCT_ORDERS_KITCHEN where transhID = " & (toSQLValueS(cboTRANSH.EditValue.ToString))
                    cmd = New SqlCommand(sSQL, CNDB)
                    sdr = cmd.ExecuteReader()
                    If (sdr.Read() = True) Then
                        If sdr.IsDBNull(sdr.GetOrdinal("ID")) = False Then cctOrderKitchen = sdr.GetGuid(sdr.GetOrdinal("ID")).ToString
                    End If
                    sdr.Close()
                    cmd.Dispose()
                    ' Δημιουργία/Ενημέρωση Κοστολόγησης
                    Using oCmd As New SqlCommand("usp_InsertOrUpdateTransCost", CNDB)
                        oCmd.CommandType = CommandType.StoredProcedure
                        oCmd.Parameters.AddWithValue("@transhID", cboTRANSH.EditValue.ToString)
                        oCmd.Parameters.AddWithValue("@cctOrderKitchenID", System.Guid.Parse(cctOrderKitchen))
                        oCmd.Parameters.AddWithValue("@Mode", 2)
                        oCmd.Parameters.AddWithValue("@UserID", UserProps.ID.ToString)
                        oCmd.ExecuteNonQuery()
                    End Using
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
        Dim sVal As String
        If cboTRANSH.EditValue IsNot Nothing Then sVal = cboTRANSH.EditValue.ToString
        FillCbo.TRANSH(cboTRANSH, sSQL)
        If sVal <> "" Then cboTRANSH.EditValue = Guid.Parse(sVal)
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

    Private Sub txtTotalClosetVat_EditValueChanged(sender As Object, e As EventArgs) Handles txtTotalClosetVat.EditValueChanged
        Dim TotalClosetPrice As Double
        TotalClosetPrice = (txtTotalClosetVat.EditValue * (ProgProps.VAT / 100)) + txtTotalClosetVat.EditValue
        txtTotalClosetPice.EditValue = TotalClosetPrice
    End Sub
    Private Sub RepDefPrice_ButtonPressed(sender As Object, e As ButtonPressedEventArgs) Handles RepDefPrice.ButtonPressed
        Select Case e.Button.Index
            Case 0 : GridView2.SetRowCellValue(GridView2.FocusedRowHandle, "price", GridView2.GetRowCellValue(GridView2.FocusedRowHandle, "defPrice").ToString)
            Case 1 : GridView2.SetRowCellValue(GridView2.FocusedRowHandle, "price", "0.00")
        End Select
    End Sub
    Private Sub InsertSelectedRows()
        Dim sSQL As String
        Dim I As Integer
        sSQL = "DELETE FROM CCT_ORDERS_CLOSET_EQUIPMENT WHERE cctOrdersClosetID = " & toSQLValueS(sID)
        Using oCmd As New SqlCommand(sSQL, CNDB)
            oCmd.ExecuteNonQuery()
        End Using
        Dim Selected As Boolean
        For I = 0 To GridView2.RowCount - 1
            Selected = GridView2.GetRowCellValue(I, "checked")
            If Selected = True Then
                sSQL = "INSERT INTO CCT_ORDERS_CLOSET_EQUIPMENT(cctOrdersClosetID,equipmentID,price,selected,qty) " &
                    " VALUES ( " & toSQLValueS(sID) & "," & toSQLValueS(GridView2.GetRowCellValue(I, "ID").ToString) & "," & toSQLValueS(GridView2.GetRowCellValue(I, "price").ToString, True) & ",1," & toSQLValueS(GridView2.GetRowCellValue(I, "QTY").ToString, True) & ")"
                Using oCmd As New SqlCommand(sSQL, CNDB)
                    oCmd.ExecuteNonQuery()
                End Using
            End If
        Next
        XtraMessageBox.Show("Η εγγραφή αποθηκέυτηκε με επιτυχία", "Dreamy Kitchen CRM", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub
    Private Sub GridView2_PopupMenuShowing(sender As Object, e As PopupMenuShowingEventArgs) Handles GridView2.PopupMenuShowing
        If e.MenuType = GridMenuType.Column Then LoadForms.PopupMenuShow(e, GridView2, "CCT_ORDERS_CLOSET_EQUIPMENT_def.xml", "vw_CCT_ORDERS_CLOSET_EQUIPMENT")
    End Sub

    Private Sub cmdPrintOffer_Click(sender As Object, e As EventArgs) Handles cmdPrintOffer.Click
        Dim report As New RepCUSOrderCloset()

        report.Parameters.Item(0).Value = sID
        report.CreateDocument()
        Dim report2 As New RepCUSOrderCloset2ndPage

        report2.Parameters.Item(0).Value = sID
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
        InsertSelectedRows()
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


    Private Sub cboBOXColors_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboBOXColors.ButtonClick
        Select Case e.Button.Index
            Case 1 : ManageCbo.ManageDoorType(cboBOXColors, FormMode.NewRecord, "DE86FD16-2154-4E2A-B025-4D34BDF8C808")
            Case 2 : ManageCbo.ManageDoorType(cboBOXColors, FormMode.EditRecord)
            Case 3 : cboBOXColors.EditValue = Nothing
        End Select
    End Sub
    Private Sub cboBOXColors2_ButtonClick(sender As Object, e As ButtonPressedEventArgs)
        Select Case e.Button.Index
            Case 1 : ManageCbo.ManageDoorType(cboBOXColors2, FormMode.NewRecord, "DE86FD16-2154-4E2A-B025-4D34BDF8C808")
            Case 2 : ManageCbo.ManageDoorType(cboBOXColors2, FormMode.EditRecord)
            Case 3 : cboBOXColors2.EditValue = Nothing
        End Select
    End Sub
    Private Sub cboBOXColors3_ButtonClick(sender As Object, e As ButtonPressedEventArgs)
        Select Case e.Button.Index
            Case 1 : ManageCbo.ManageDoorType(cboBOXColors3, FormMode.NewRecord, "DE86FD16-2154-4E2A-B025-4D34BDF8C808")
            Case 2 : ManageCbo.ManageDoorType(cboBOXColors3, FormMode.EditRecord)
            Case 3 : cboBOXColors3.EditValue = Nothing
        End Select
    End Sub
    Private Sub cboBOXColors4_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboBOXColors4.ButtonClick
        Select Case e.Button.Index
            Case 1 : ManageCbo.ManageDoorType(cboBOXColors4, FormMode.NewRecord, "DE86FD16-2154-4E2A-B025-4D34BDF8C808")
            Case 2 : ManageCbo.ManageDoorType(cboBOXColors4, FormMode.EditRecord)
            Case 3 : cboBOXColors4.EditValue = Nothing
        End Select
    End Sub
    Private Sub cboBOXColors5_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboBOXColors5.ButtonClick
        Select Case e.Button.Index
            Case 1 : ManageCbo.ManageDoorType(cboBOXColors5, FormMode.NewRecord, "DE86FD16-2154-4E2A-B025-4D34BDF8C808")
            Case 2 : ManageCbo.ManageDoorType(cboBOXColors5, FormMode.EditRecord)
            Case 3 : cboBOXColors5.EditValue = Nothing
        End Select
    End Sub
    Private Sub cboBOXColors6_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboBOXColors6.ButtonClick
        Select Case e.Button.Index
            Case 1 : ManageCbo.ManageDoorType(cboBOXColors6, FormMode.NewRecord, "DE86FD16-2154-4E2A-B025-4D34BDF8C808")
            Case 2 : ManageCbo.ManageDoorType(cboBOXColors6, FormMode.EditRecord)
            Case 3 : cboBOXColors6.EditValue = Nothing
        End Select
    End Sub

    Private Sub cboDoorType_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboDoorType.ButtonClick
        Select Case e.Button.Index
            Case 1 : ManageCbo.ManageDoorType(cboDoorType, FormMode.NewRecord, "DE86FD16-2154-4E2A-B025-4D34BDF8C808")
            Case 2 : ManageCbo.ManageDoorType(cboDoorType, FormMode.EditRecord)
            Case 3 : cboDoorType.EditValue = Nothing
        End Select
    End Sub
    Private Sub cboDoorType2_ButtonClick(sender As Object, e As ButtonPressedEventArgs)
        Select Case e.Button.Index
            Case 1 : ManageCbo.ManageDoorType(cboDoorType8, FormMode.NewRecord, "DE86FD16-2154-4E2A-B025-4D34BDF8C808")
            Case 2 : ManageCbo.ManageDoorType(cboDoorType8, FormMode.EditRecord)
            Case 3 : cboDoorType8.EditValue = Nothing
        End Select
    End Sub
    Private Sub cboDoorType3_ButtonClick(sender As Object, e As ButtonPressedEventArgs)
        Select Case e.Button.Index
            Case 1 : ManageCbo.ManageDoorType(cboDoorType9, FormMode.NewRecord, "DE86FD16-2154-4E2A-B025-4D34BDF8C808")
            Case 2 : ManageCbo.ManageDoorType(cboDoorType9, FormMode.EditRecord)
            Case 3 : cboDoorType9.EditValue = Nothing
        End Select
    End Sub
    Private Sub cboDoorType4_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboDoorType4.ButtonClick
        Select Case e.Button.Index
            Case 1 : ManageCbo.ManageDoorType(cboDoorType4, FormMode.NewRecord, "DE86FD16-2154-4E2A-B025-4D34BDF8C808")
            Case 2 : ManageCbo.ManageDoorType(cboDoorType4, FormMode.EditRecord)
            Case 3 : cboDoorType4.EditValue = Nothing
        End Select
    End Sub
    Private Sub cboDoorType5_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboDoorType5.ButtonClick
        Select Case e.Button.Index
            Case 1 : ManageCbo.ManageDoorType(cboDoorType5, FormMode.NewRecord, "DE86FD16-2154-4E2A-B025-4D34BDF8C808")
            Case 2 : ManageCbo.ManageDoorType(cboDoorType5, FormMode.EditRecord)
            Case 3 : cboDoorType5.EditValue = Nothing
        End Select
    End Sub
    Private Sub cboDoorType6_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboDoorType6.ButtonClick
        Select Case e.Button.Index
            Case 1 : ManageCbo.ManageDoorType(cboDoorType6, FormMode.NewRecord, "DE86FD16-2154-4E2A-B025-4D34BDF8C808")
            Case 2 : ManageCbo.ManageDoorType(cboDoorType6, FormMode.EditRecord)
            Case 3 : cboDoorType6.EditValue = Nothing
        End Select
    End Sub
    Private Sub cboDoorType7_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboDoorType7.ButtonClick
        Select Case e.Button.Index
            Case 1 : ManageCbo.ManageDoorType(cboDoorType7, FormMode.NewRecord, "DE86FD16-2154-4E2A-B025-4D34BDF8C808")
            Case 2 : ManageCbo.ManageDoorType(cboDoorType7, FormMode.EditRecord)
            Case 3 : cboDoorType7.EditValue = Nothing
        End Select
    End Sub
    Private Sub cboDoorType8_ButtonClick(sender As Object, e As ButtonPressedEventArgs)
        Select Case e.Button.Index
            Case 1 : ManageCbo.ManageDoorType(cboDoorType2, FormMode.NewRecord, "DE86FD16-2154-4E2A-B025-4D34BDF8C808")
            Case 2 : ManageCbo.ManageDoorType(cboDoorType2, FormMode.EditRecord)
            Case 3 : cboDoorType2.EditValue = Nothing
        End Select
    End Sub
    Private Sub cboDoorType9_ButtonClick(sender As Object, e As ButtonPressedEventArgs)
        Select Case e.Button.Index
            Case 1 : ManageCbo.ManageDoorType(cboDoorType3, FormMode.NewRecord, "DE86FD16-2154-4E2A-B025-4D34BDF8C808")
            Case 2 : ManageCbo.ManageDoorType(cboDoorType3, FormMode.EditRecord)
            Case 3 : cboDoorType3.EditValue = Nothing
        End Select
    End Sub
    Private Sub cboDoorType10_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboDoorType10.ButtonClick
        Select Case e.Button.Index
            Case 1 : ManageCbo.ManageDoorType(cboDoorType10, FormMode.NewRecord, "DE86FD16-2154-4E2A-B025-4D34BDF8C808")
            Case 2 : ManageCbo.ManageDoorType(cboDoorType10, FormMode.EditRecord)
            Case 3 : cboDoorType10.EditValue = Nothing
        End Select
    End Sub
    Private Sub cboDoorType11_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboDoorType11.ButtonClick
        Select Case e.Button.Index
            Case 1 : ManageCbo.ManageDoorType(cboDoorType11, FormMode.NewRecord, "DE86FD16-2154-4E2A-B025-4D34BDF8C808")
            Case 2 : ManageCbo.ManageDoorType(cboDoorType11, FormMode.EditRecord)
            Case 3 : cboDoorType11.EditValue = Nothing
        End Select
    End Sub
    Private Sub cboDoorType12_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboDoorType12.ButtonClick
        Select Case e.Button.Index
            Case 1 : ManageCbo.ManageDoorType(cboDoorType12, FormMode.NewRecord, "DE86FD16-2154-4E2A-B025-4D34BDF8C808")
            Case 2 : ManageCbo.ManageDoorType(cboDoorType12, FormMode.EditRecord)
            Case 3 : cboDoorType12.EditValue = Nothing
        End Select
    End Sub
    Private Sub cboSides1_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboSides1.ButtonClick
        Select Case e.Button.Index
            Case 1 : ManageCbo.ManageDoorType(cboSides1, FormMode.NewRecord, "DE86FD16-2154-4E2A-B025-4D34BDF8C808")
            Case 2 : ManageCbo.ManageDoorType(cboSides1, FormMode.EditRecord)
            Case 3 : cboSides1.EditValue = Nothing
        End Select
    End Sub

    Private Sub cboSides2_ButtonClick(sender As Object, e As ButtonPressedEventArgs)
        Select Case e.Button.Index
            Case 1 : ManageCbo.ManageDoorType(cboSides2, FormMode.NewRecord, "DE86FD16-2154-4E2A-B025-4D34BDF8C808")
            Case 2 : ManageCbo.ManageDoorType(cboSides2, FormMode.EditRecord)
            Case 3 : cboSides2.EditValue = Nothing
        End Select
    End Sub

    Private Sub cboSides3_ButtonClick(sender As Object, e As ButtonPressedEventArgs)
        Select Case e.Button.Index
            Case 1 : ManageCbo.ManageDoorType(cboSides3, FormMode.NewRecord, "DE86FD16-2154-4E2A-B025-4D34BDF8C808")
            Case 2 : ManageCbo.ManageDoorType(cboSides3, FormMode.EditRecord)
            Case 3 : cboSides3.EditValue = Nothing
        End Select
    End Sub

    Private Sub cboSides4_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboSides4.ButtonClick
        Select Case e.Button.Index
            Case 1 : ManageCbo.ManageDoorType(cboSides4, FormMode.NewRecord, "DE86FD16-2154-4E2A-B025-4D34BDF8C808")
            Case 2 : ManageCbo.ManageDoorType(cboSides1, FormMode.EditRecord)
            Case 3 : cboSides4.EditValue = Nothing
        End Select
    End Sub

    Private Sub cboSides5_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboSides5.ButtonClick
        Select Case e.Button.Index
            Case 1 : ManageCbo.ManageDoorType(cboSides5, FormMode.NewRecord, "DE86FD16-2154-4E2A-B025-4D34BDF8C808")
            Case 2 : ManageCbo.ManageDoorType(cboSides5, FormMode.EditRecord)
            Case 3 : cboSides5.EditValue = Nothing
        End Select
    End Sub


    Private Sub cboSides6_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboSides6.ButtonClick
        Select Case e.Button.Index
            Case 1 : ManageCbo.ManageDoorType(cboSides6, FormMode.NewRecord, "DE86FD16-2154-4E2A-B025-4D34BDF8C808")
            Case 2 : ManageCbo.ManageDoorType(cboSides6, FormMode.EditRecord)
            Case 3 : cboSides6.EditValue = Nothing
        End Select
    End Sub

    Private Sub cboShelves1_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboShelves1.ButtonClick
        Select Case e.Button.Index
            Case 1 : ManageCbo.ManageDoorType(cboShelves1, FormMode.NewRecord, "DE86FD16-2154-4E2A-B025-4D34BDF8C808")
            Case 2 : ManageCbo.ManageDoorType(cboShelves1, FormMode.EditRecord)
            Case 3 : cboShelves1.EditValue = Nothing
        End Select
    End Sub

    Private Sub cboShelves2_ButtonClick(sender As Object, e As ButtonPressedEventArgs)
        Select Case e.Button.Index
            Case 1 : ManageCbo.ManageDoorType(cboShelves2, FormMode.NewRecord, "DE86FD16-2154-4E2A-B025-4D34BDF8C808")
            Case 2 : ManageCbo.ManageDoorType(cboShelves2, FormMode.EditRecord)
            Case 3 : cboShelves2.EditValue = Nothing
        End Select
    End Sub

    Private Sub cboShelves3_ButtonClick(sender As Object, e As ButtonPressedEventArgs)
        Select Case e.Button.Index
            Case 1 : ManageCbo.ManageDoorType(cboShelves3, FormMode.NewRecord, "DE86FD16-2154-4E2A-B025-4D34BDF8C808")
            Case 2 : ManageCbo.ManageDoorType(cboShelves3, FormMode.EditRecord)
            Case 3 : cboShelves3.EditValue = Nothing
        End Select
    End Sub

    Private Sub cboShelves4_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboShelves4.ButtonClick
        Select Case e.Button.Index
            Case 1 : ManageCbo.ManageDoorType(cboShelves4, FormMode.NewRecord, "DE86FD16-2154-4E2A-B025-4D34BDF8C808")
            Case 2 : ManageCbo.ManageDoorType(cboShelves1, FormMode.EditRecord)
            Case 3 : cboShelves4.EditValue = Nothing
        End Select
    End Sub

    Private Sub cboShelves5_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboShelves5.ButtonClick
        Select Case e.Button.Index
            Case 1 : ManageCbo.ManageDoorType(cboShelves5, FormMode.NewRecord, "DE86FD16-2154-4E2A-B025-4D34BDF8C808")
            Case 2 : ManageCbo.ManageDoorType(cboShelves5, FormMode.EditRecord)
            Case 3 : cboShelves5.EditValue = Nothing
        End Select
    End Sub
    Private Sub cboShelves6_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboShelves6.ButtonClick
        Select Case e.Button.Index
            Case 1 : ManageCbo.ManageDoorType(cboShelves6, FormMode.NewRecord, "DE86FD16-2154-4E2A-B025-4D34BDF8C808")
            Case 2 : ManageCbo.ManageDoorType(cboShelves6, FormMode.EditRecord)
            Case 3 : cboShelves6.EditValue = Nothing
        End Select
    End Sub

    Private Sub cboClosetType1_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboClosetType1.ButtonClick
        Select Case e.Button.Index
            Case 1 : cboClosetType1.EditValue = Nothing
        End Select
    End Sub
    Private Sub cboClosetType2_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboClosetType2.ButtonClick
        Select Case e.Button.Index
            Case 1 : cboClosetType2.EditValue = Nothing
        End Select
    End Sub
    Private Sub cboClosetType3_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboClosetType3.ButtonClick
        Select Case e.Button.Index
            Case 1 : cboClosetType3.EditValue = Nothing
        End Select
    End Sub
    Private Sub cboClosetType4_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboClosetType4.ButtonClick
        Select Case e.Button.Index
            Case 1 : cboClosetType4.EditValue = Nothing
        End Select
    End Sub
    Private Sub cboClosetType5_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboClosetType5.ButtonClick
        Select Case e.Button.Index
            Case 1 : cboClosetType5.EditValue = Nothing
        End Select
    End Sub
    Private Sub cboClosetType6_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboClosetType6.ButtonClick
        Select Case e.Button.Index
            Case 1 : cboClosetType6.EditValue = Nothing
        End Select
    End Sub


    Private Sub GridView2_ValidatingEditor(sender As Object, e As BaseContainerValidateEditorEventArgs) Handles GridView2.ValidatingEditor
        Dim grdView As GridView = sender
        If grdView.FocusedColumn.FieldName = "checked" Then
            If CStr(e.Value) = "false" Then
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
                    oCmd.Parameters.AddWithValue("@Mode", 2)
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
        txtDisc1.EditValue = ProgProps.CusDiscountCloset
        If ProgProps.CusDiscountCloset > 0 Then
            InitialPrice = txtInitialPrice1.EditValue
            Disc = ProgProps.CusDiscountCloset / 100
            Discount = Disc * InitialPrice
            FinalPrice = InitialPrice - Discount
            txtInitialPrice1.EditValue = InitialPrice
            txtDiscount1.EditValue = Discount
            txtFinalPrice1.EditValue = FinalPrice
        End If
    End Sub

    Private Sub txtInitialPrice2_EditValueChanged(sender As Object, e As EventArgs) Handles txtInitialPrice2.EditValueChanged
        Dim Disc As Double, Discount As Double, InitialPrice As Double, FinalPrice As Double
        txtDisc2.EditValue = ProgProps.CusDiscountCloset
        If ProgProps.CusDiscountCloset > 0 Then
            InitialPrice = txtInitialPrice2.EditValue
            Disc = ProgProps.CusDiscountCloset / 100
            Discount = Disc * InitialPrice
            FinalPrice = InitialPrice - Discount
            txtInitialPrice2.EditValue = InitialPrice
            txtDiscount2.EditValue = Discount
            txtFinalPrice2.EditValue = FinalPrice
        End If

    End Sub

    Private Sub txtInitialPrice3_EditValueChanged(sender As Object, e As EventArgs) Handles txtInitialPrice3.EditValueChanged
        Dim Disc As Double, Discount As Double, InitialPrice As Double, FinalPrice As Double
        txtDisc3.EditValue = ProgProps.CusDiscountCloset
        If ProgProps.CusDiscountCloset > 0 Then
            InitialPrice = txtInitialPrice3.EditValue
            Disc = ProgProps.CusDiscountCloset / 100
            Discount = Disc * InitialPrice
            FinalPrice = InitialPrice - Discount
            txtInitialPrice3.EditValue = InitialPrice
            txtDiscount3.EditValue = Discount
            txtFinalPrice3.EditValue = FinalPrice
        End If
    End Sub

    Private Sub txtInitialPrice4_EditValueChanged(sender As Object, e As EventArgs) Handles txtInitialPrice4.EditValueChanged
        Dim Disc As Double, Discount As Double, InitialPrice As Double, FinalPrice As Double
        txtDisc4.EditValue = ProgProps.CusDiscountCloset
        If ProgProps.CusDiscountCloset > 0 Then
            InitialPrice = txtInitialPrice4.EditValue
            Disc = ProgProps.CusDiscountCloset / 100
            Discount = Disc * InitialPrice
            FinalPrice = InitialPrice - Discount
            txtInitialPrice4.EditValue = InitialPrice
            txtDiscount4.EditValue = Discount
            txtFinalPrice4.EditValue = FinalPrice
        End If
    End Sub
    Private Sub cboDoorType_ProcessNewValue(sender As Object, e As ProcessNewValueEventArgs) Handles cboDoorType.ProcessNewValue
        If CStr(e.DisplayValue) <> String.Empty Then
            Dim sDoorTypeID = DBQ.InsertNewDoorType(cboDoorType, e.DisplayValue)
            If sDoorTypeID <> "" Then
                Me.Vw_DOOR_TYPE_V2TableAdapter.Fill(Me.DM_DOORTYPES.vw_DOOR_TYPE_V2)
                cboDoorType.EditValue = System.Guid.Parse(sDoorTypeID)
            End If
            e.Handled = True
        End If
    End Sub
    Private Sub cboDoorType7_ProcessNewValue(sender As Object, e As ProcessNewValueEventArgs) Handles cboDoorType7.ProcessNewValue
        If CStr(e.DisplayValue) <> String.Empty Then
            Dim sDoorTypeID = DBQ.InsertNewDoorType(cboDoorType7, e.DisplayValue)
            If sDoorTypeID <> "" Then
                Me.Vw_DOOR_TYPE_V2TableAdapter.Fill(Me.DM_DOORTYPES.vw_DOOR_TYPE_V2)
                cboDoorType7.EditValue = System.Guid.Parse(sDoorTypeID)
            End If
            e.Handled = True
        End If
    End Sub
    Private Sub cboSides1_ProcessNewValue(sender As Object, e As ProcessNewValueEventArgs) Handles cboSides1.ProcessNewValue
        If CStr(e.DisplayValue) <> String.Empty Then
            Dim sDoorTypeID = DBQ.InsertNewDoorType(cboSides1, e.DisplayValue)
            If sDoorTypeID <> "" Then
                Me.Vw_DOOR_TYPE_V2TableAdapter.Fill(Me.DM_DOORTYPES.vw_DOOR_TYPE_V2)
                cboSides1.EditValue = System.Guid.Parse(sDoorTypeID)
            End If
            e.Handled = True
        End If
    End Sub
    Private Sub cboShelves1_ProcessNewValue(sender As Object, e As ProcessNewValueEventArgs) Handles cboShelves1.ProcessNewValue
        If CStr(e.DisplayValue) <> String.Empty Then
            Dim sDoorTypeID = DBQ.InsertNewDoorType(cboShelves1, e.DisplayValue)
            If sDoorTypeID <> "" Then
                Me.Vw_DOOR_TYPE_V2TableAdapter.Fill(Me.DM_DOORTYPES.vw_DOOR_TYPE_V2)
                cboShelves1.EditValue = System.Guid.Parse(sDoorTypeID)
            End If
            e.Handled = True
        End If
    End Sub

    Private Sub cboDoorType2_ProcessNewValue(sender As Object, e As ProcessNewValueEventArgs) Handles cboDoorType2.ProcessNewValue
        If CStr(e.DisplayValue) <> String.Empty Then
            Dim sDoorTypeID = DBQ.InsertNewDoorType(cboDoorType2, e.DisplayValue)
            If sDoorTypeID <> "" Then
                Me.Vw_DOOR_TYPE_V2TableAdapter.Fill(Me.DM_DOORTYPES.vw_DOOR_TYPE_V2)
                cboDoorType2.EditValue = System.Guid.Parse(sDoorTypeID)
            End If
            e.Handled = True
        End If
    End Sub
    Private Sub cboDoorType8_ProcessNewValue(sender As Object, e As ProcessNewValueEventArgs) Handles cboDoorType8.ProcessNewValue
        If CStr(e.DisplayValue) <> String.Empty Then
            Dim sDoorTypeID = DBQ.InsertNewDoorType(cboDoorType8, e.DisplayValue)
            If sDoorTypeID <> "" Then
                Me.Vw_DOOR_TYPE_V2TableAdapter.Fill(Me.DM_DOORTYPES.vw_DOOR_TYPE_V2)
                cboDoorType8.EditValue = System.Guid.Parse(sDoorTypeID)
            End If
            e.Handled = True
        End If
    End Sub
    Private Sub cboSides2_ProcessNewValue(sender As Object, e As ProcessNewValueEventArgs) Handles cboSides2.ProcessNewValue
        If CStr(e.DisplayValue) <> String.Empty Then
            Dim sDoorTypeID = DBQ.InsertNewDoorType(cboSides2, e.DisplayValue)
            If sDoorTypeID <> "" Then
                Me.Vw_DOOR_TYPE_V2TableAdapter.Fill(Me.DM_DOORTYPES.vw_DOOR_TYPE_V2)
                cboSides2.EditValue = System.Guid.Parse(sDoorTypeID)
            End If
            e.Handled = True
        End If
    End Sub
    Private Sub cboShelves2_ProcessNewValue(sender As Object, e As ProcessNewValueEventArgs) Handles cboShelves2.ProcessNewValue
        If CStr(e.DisplayValue) <> String.Empty Then
            Dim sDoorTypeID = DBQ.InsertNewDoorType(cboShelves2, e.DisplayValue)
            If sDoorTypeID <> "" Then
                Me.Vw_DOOR_TYPE_V2TableAdapter.Fill(Me.DM_DOORTYPES.vw_DOOR_TYPE_V2)
                cboShelves2.EditValue = System.Guid.Parse(sDoorTypeID)
            End If
            e.Handled = True
        End If
    End Sub

    Private Sub cboDoorType3_ProcessNewValue(sender As Object, e As ProcessNewValueEventArgs) Handles cboDoorType3.ProcessNewValue
        If CStr(e.DisplayValue) <> String.Empty Then
            Dim sDoorTypeID = DBQ.InsertNewDoorType(cboDoorType3, e.DisplayValue)
            If sDoorTypeID <> "" Then
                Me.Vw_DOOR_TYPE_V2TableAdapter.Fill(Me.DM_DOORTYPES.vw_DOOR_TYPE_V2)
                cboDoorType3.EditValue = System.Guid.Parse(sDoorTypeID)
            End If
            e.Handled = True
        End If
    End Sub
    Private Sub cboDoorType9_ProcessNewValue(sender As Object, e As ProcessNewValueEventArgs) Handles cboDoorType9.ProcessNewValue
        If CStr(e.DisplayValue) <> String.Empty Then
            Dim sDoorTypeID = DBQ.InsertNewDoorType(cboDoorType9, e.DisplayValue)
            If sDoorTypeID <> "" Then
                Me.Vw_DOOR_TYPE_V2TableAdapter.Fill(Me.DM_DOORTYPES.vw_DOOR_TYPE_V2)
                cboDoorType9.EditValue = System.Guid.Parse(sDoorTypeID)
            End If
            e.Handled = True
        End If
    End Sub
    Private Sub cboSides3_ProcessNewValue(sender As Object, e As ProcessNewValueEventArgs) Handles cboSides3.ProcessNewValue
        If CStr(e.DisplayValue) <> String.Empty Then
            Dim sDoorTypeID = DBQ.InsertNewDoorType(cboSides3, e.DisplayValue)
            If sDoorTypeID <> "" Then
                Me.Vw_DOOR_TYPE_V2TableAdapter.Fill(Me.DM_DOORTYPES.vw_DOOR_TYPE_V2)
                cboSides3.EditValue = System.Guid.Parse(sDoorTypeID)
            End If
            e.Handled = True
        End If
    End Sub
    Private Sub cboShelves3_ProcessNewValue(sender As Object, e As ProcessNewValueEventArgs) Handles cboShelves3.ProcessNewValue
        If CStr(e.DisplayValue) <> String.Empty Then
            Dim sDoorTypeID = DBQ.InsertNewDoorType(cboShelves3, e.DisplayValue)
            If sDoorTypeID <> "" Then
                Me.Vw_DOOR_TYPE_V2TableAdapter.Fill(Me.DM_DOORTYPES.vw_DOOR_TYPE_V2)
                cboShelves3.EditValue = System.Guid.Parse(sDoorTypeID)
            End If
            e.Handled = True
        End If
    End Sub

    Private Sub cboDoorType4_ProcessNewValue(sender As Object, e As ProcessNewValueEventArgs) Handles cboDoorType4.ProcessNewValue
        If CStr(e.DisplayValue) <> String.Empty Then
            Dim sDoorTypeID = DBQ.InsertNewDoorType(cboDoorType4, e.DisplayValue)
            If sDoorTypeID <> "" Then
                Me.Vw_DOOR_TYPE_V2TableAdapter.Fill(Me.DM_DOORTYPES.vw_DOOR_TYPE_V2)
                cboDoorType4.EditValue = System.Guid.Parse(sDoorTypeID)
            End If
            e.Handled = True
        End If
    End Sub
    Private Sub cboDoorType10_ProcessNewValue(sender As Object, e As ProcessNewValueEventArgs) Handles cboDoorType10.ProcessNewValue
        If CStr(e.DisplayValue) <> String.Empty Then
            Dim sDoorTypeID = DBQ.InsertNewDoorType(cboDoorType10, e.DisplayValue)
            If sDoorTypeID <> "" Then
                Me.Vw_DOOR_TYPE_V2TableAdapter.Fill(Me.DM_DOORTYPES.vw_DOOR_TYPE_V2)
                cboDoorType10.EditValue = System.Guid.Parse(sDoorTypeID)
            End If
            e.Handled = True
        End If
    End Sub
    Private Sub cboSides4_ProcessNewValue(sender As Object, e As ProcessNewValueEventArgs) Handles cboSides4.ProcessNewValue
        If CStr(e.DisplayValue) <> String.Empty Then
            Dim sDoorTypeID = DBQ.InsertNewDoorType(cboSides4, e.DisplayValue)
            If sDoorTypeID <> "" Then
                Me.Vw_DOOR_TYPE_V2TableAdapter.Fill(Me.DM_DOORTYPES.vw_DOOR_TYPE_V2)
                cboSides4.EditValue = System.Guid.Parse(sDoorTypeID)
            End If
            e.Handled = True
        End If
    End Sub
    Private Sub cboShelves4_ProcessNewValue(sender As Object, e As ProcessNewValueEventArgs) Handles cboShelves4.ProcessNewValue
        If CStr(e.DisplayValue) <> String.Empty Then
            Dim sDoorTypeID = DBQ.InsertNewDoorType(cboShelves4, e.DisplayValue)
            If sDoorTypeID <> "" Then
                Me.Vw_DOOR_TYPE_V2TableAdapter.Fill(Me.DM_DOORTYPES.vw_DOOR_TYPE_V2)
                cboShelves4.EditValue = System.Guid.Parse(sDoorTypeID)
            End If
            e.Handled = True
        End If
    End Sub

    Private Sub cboDoorType5_ProcessNewValue(sender As Object, e As ProcessNewValueEventArgs) Handles cboDoorType5.ProcessNewValue
        If CStr(e.DisplayValue) <> String.Empty Then
            Dim sDoorTypeID = DBQ.InsertNewDoorType(cboDoorType5, e.DisplayValue)
            If sDoorTypeID <> "" Then
                Me.Vw_DOOR_TYPE_V2TableAdapter.Fill(Me.DM_DOORTYPES.vw_DOOR_TYPE_V2)
                cboDoorType5.EditValue = System.Guid.Parse(sDoorTypeID)
            End If
            e.Handled = True
        End If
    End Sub
    Private Sub cboDoorType11_ProcessNewValue(sender As Object, e As ProcessNewValueEventArgs) Handles cboDoorType11.ProcessNewValue
        If CStr(e.DisplayValue) <> String.Empty Then
            Dim sDoorTypeID = DBQ.InsertNewDoorType(cboDoorType11, e.DisplayValue)
            If sDoorTypeID <> "" Then
                Me.Vw_DOOR_TYPE_V2TableAdapter.Fill(Me.DM_DOORTYPES.vw_DOOR_TYPE_V2)
                cboDoorType11.EditValue = System.Guid.Parse(sDoorTypeID)
            End If
            e.Handled = True
        End If
    End Sub
    Private Sub cboSides5_ProcessNewValue(sender As Object, e As ProcessNewValueEventArgs) Handles cboSides5.ProcessNewValue
        If CStr(e.DisplayValue) <> String.Empty Then
            Dim sDoorTypeID = DBQ.InsertNewDoorType(cboSides5, e.DisplayValue)
            If sDoorTypeID <> "" Then
                Me.Vw_DOOR_TYPE_V2TableAdapter.Fill(Me.DM_DOORTYPES.vw_DOOR_TYPE_V2)
                cboSides5.EditValue = System.Guid.Parse(sDoorTypeID)
            End If
            e.Handled = True
        End If
    End Sub
    Private Sub cboShelves5_ProcessNewValue(sender As Object, e As ProcessNewValueEventArgs) Handles cboShelves5.ProcessNewValue
        If CStr(e.DisplayValue) <> String.Empty Then
            Dim sDoorTypeID = DBQ.InsertNewDoorType(cboShelves5, e.DisplayValue)
            If sDoorTypeID <> "" Then
                Me.Vw_DOOR_TYPE_V2TableAdapter.Fill(Me.DM_DOORTYPES.vw_DOOR_TYPE_V2)
                cboShelves5.EditValue = System.Guid.Parse(sDoorTypeID)
            End If
            e.Handled = True
        End If
    End Sub


    Private Sub cboDoorType6_ProcessNewValue(sender As Object, e As ProcessNewValueEventArgs) Handles cboDoorType6.ProcessNewValue
        If CStr(e.DisplayValue) <> String.Empty Then
            Dim sDoorTypeID = DBQ.InsertNewDoorType(cboDoorType6, e.DisplayValue)
            If sDoorTypeID <> "" Then
                Me.Vw_DOOR_TYPE_V2TableAdapter.Fill(Me.DM_DOORTYPES.vw_DOOR_TYPE_V2)
                cboDoorType6.EditValue = System.Guid.Parse(sDoorTypeID)
            End If
            e.Handled = True
        End If
    End Sub
    Private Sub cboDoorType12_ProcessNewValue(sender As Object, e As ProcessNewValueEventArgs) Handles cboDoorType12.ProcessNewValue
        If CStr(e.DisplayValue) <> String.Empty Then
            Dim sDoorTypeID = DBQ.InsertNewDoorType(cboDoorType12, e.DisplayValue)
            If sDoorTypeID <> "" Then
                Me.Vw_DOOR_TYPE_V2TableAdapter.Fill(Me.DM_DOORTYPES.vw_DOOR_TYPE_V2)
                cboDoorType12.EditValue = System.Guid.Parse(sDoorTypeID)
            End If
            e.Handled = True
        End If
    End Sub
    Private Sub cboSides6_ProcessNewValue(sender As Object, e As ProcessNewValueEventArgs) Handles cboSides6.ProcessNewValue
        If CStr(e.DisplayValue) <> String.Empty Then
            Dim sDoorTypeID = DBQ.InsertNewDoorType(cboSides6, e.DisplayValue)
            If sDoorTypeID <> "" Then
                Me.Vw_DOOR_TYPE_V2TableAdapter.Fill(Me.DM_DOORTYPES.vw_DOOR_TYPE_V2)
                cboSides6.EditValue = System.Guid.Parse(sDoorTypeID)
            End If
            e.Handled = True
        End If
    End Sub
    Private Sub cboShelves6_ProcessNewValue(sender As Object, e As ProcessNewValueEventArgs) Handles cboShelves6.ProcessNewValue
        If CStr(e.DisplayValue) <> String.Empty Then
            Dim sDoorTypeID = DBQ.InsertNewDoorType(cboShelves6, e.DisplayValue)
            If sDoorTypeID <> "" Then
                Me.Vw_DOOR_TYPE_V2TableAdapter.Fill(Me.DM_DOORTYPES.vw_DOOR_TYPE_V2)
                cboShelves6.EditValue = System.Guid.Parse(sDoorTypeID)
            End If
            e.Handled = True
        End If
    End Sub
End Class