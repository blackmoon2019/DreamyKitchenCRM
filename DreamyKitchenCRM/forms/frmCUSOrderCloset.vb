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

Public Class frmCUSOrderCloset
    Private ManageCbo As New CombosManager
    Private sID As String
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

        Select Case Mode
            Case FormMode.NewRecord
                txtarProt.Text = DBQ.GetNextId("CCT_ORDERS_CLOSET")
                cboEMP.EditValue = System.Guid.Parse(UserProps.ID.ToString.ToUpper)
                txtdtdaysOfDelivery.EditValue = ProgProps.DAYS_OF_DELIVERY
                cboBackThikness.EditValue = ProgProps.CLOSET_BACK_THIKNESS
                cboboxThikness.EditValue = ProgProps.CLOSET_BOX_THIKNESS
                ' cboBOXColors.EditValue = System.Guid.Parse(ProgProps.CLOSET_BOX_COLOR.ToUpper)
                txtdrawers.EditValue = ProgProps.CLOSET_DRAWERS
                txtTransp.EditValue = ProgProps.ClosetTransp
                txtMeasurement.EditValue = ProgProps.ClosetMeasurement
                txtRemove.EditValue = ProgProps.ClosetRemove

                LoadForms.LoadDataToGrid(grdEquipment, GridView2,
                    "Select  e.ID,E.code,name,price,e.price as defPrice,cast(case when (SELECT FLdVAL FROM PRM_DET WHERE TBL='EQUIPMENT' AND fld='ID' AND fldVal=e.id) is null then 0 else 1 end as bit) as  checked, " &
                    "case when (SELECT FLdVAL FROM PRM_DET WHERE TBL='EQUIPMENT' AND fld='ID' AND fldVal=e.id) is null then 0 else 1 end AS QTY,standard " &
                     "From vw_EQUIPMENT E where equipmentCatID='DB158CAB-11EA-423B-9430-0C8A0CEB1D62' ORDER BY NAME")
                TabNavigationPage2.Enabled = False
            Case FormMode.EditRecord
                LoadForms.LoadForm(LayoutControl1, "Select * from CCT_ORDERS_CLOSET where id = " & toSQLValueS(sID))
                LoadForms.LoadDataToGrid(grdEquipment, GridView2,
                    "select e.ID,e.code,e.name,
                    isnull((select price from CCT_ORDERS_CLOSET_EQUIPMENT EQ where eq.cctOrdersClosetID= " & toSQLValueS(sID) & " and eq.equipmentID=e.id),e.price ) as price,
                    e.price as defPrice,
                    CAST(CASE WHEN (select eq.ID 
                    from CCT_ORDERS_CLOSET_EQUIPMENT EQ 
                    where eq.cctOrdersClosetID= " & toSQLValueS(sID) & " and eq.equipmentID=e.id) IS NULL THEN 0 ELSE 1 END AS BIT ) as checked,
                    isnull((select qty from CCT_ORDERS_CLOSET_EQUIPMENT EQ where eq.cctOrdersClosetID= " & toSQLValueS(sID) & " and eq.equipmentID=e.id),0) as QTY,standard
                    from EQUIPMENT E
                    where equipmentCatID='DB158CAB-11EA-423B-9430-0C8A0CEB1D62'
                    ORDER BY NAME")


                'LoadForms.LoadDataToGrid(grdEquipment, GridView2,
                '    "select e.ID,e.code,e.name,price,e.price as defPrice,
                '    CAST(CASE WHEN (select eq.ID 
                '    from CCT_ORDERS_CLOSET_EQUIPMENT EQ 
                '    where eq.cctOrdersClosetID= " & toSQLValueS(sID) & " and eq.equipmentID=e.id) IS NULL THEN 0 ELSE 1 END AS BIT ) as checked,
                '    isnull((select qty from CCT_ORDERS_CLOSET_EQUIPMENT EQ where eq.cctOrdersClosetID= " & toSQLValueS(sID) & " and eq.equipmentID=e.id),0) as QTY
                '    from EQUIPMENT E
                '    where equipmentCatID='DB158CAB-11EA-423B-9430-0C8A0CEB1D62'
                '    ORDER BY NAME")
                TabNavigationPage2.Enabled = True

        End Select
        LoadForms.RestoreLayoutFromXml(GridView2, "CCT_ORDERS_CLOSET_EQUIPMENT_def.xml")
        GridView2.Columns.Item("name").OptionsColumn.AllowEdit = False : GridView2.Columns.Item("code").OptionsColumn.AllowEdit = False
        GridView2.Columns.Item("price").OptionsColumn.AllowEdit = False
        Me.CenterToScreen()
        cmdSave.Enabled = IIf(Mode = FormMode.NewRecord, UserProps.AllowInsert, UserProps.AllowEdit)

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
            Case 1 : ManageCbo.ManageColors(cboBOXColors, FormMode.NewRecord)
            Case 2 : ManageCbo.ManageColors(cboBOXColors, FormMode.EditRecord)
            Case 3 : cboBOXColors.EditValue = Nothing
        End Select
    End Sub
    Private Sub cboBOXColors2_ButtonClick(sender As Object, e As ButtonPressedEventArgs)
        Select Case e.Button.Index
            Case 1 : ManageCbo.ManageColors(cboBOXColors2, FormMode.NewRecord)
            Case 2 : ManageCbo.ManageColors(cboBOXColors2, FormMode.EditRecord)
            Case 3 : cboBOXColors2.EditValue = Nothing
        End Select
    End Sub
    Private Sub cboBOXColors3_ButtonClick(sender As Object, e As ButtonPressedEventArgs)
        Select Case e.Button.Index
            Case 1 : ManageCbo.ManageColors(cboBOXColors3, FormMode.NewRecord)
            Case 2 : ManageCbo.ManageColors(cboBOXColors3, FormMode.EditRecord)
            Case 3 : cboBOXColors3.EditValue = Nothing
        End Select
    End Sub
    Private Sub cboBOXColors4_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboBOXColors4.ButtonClick
        Select Case e.Button.Index
            Case 1 : ManageCbo.ManageColors(cboBOXColors4, FormMode.NewRecord)
            Case 2 : ManageCbo.ManageColors(cboBOXColors4, FormMode.EditRecord)
            Case 3 : cboBOXColors4.EditValue = Nothing
        End Select
    End Sub
    Private Sub cboBOXColors5_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboBOXColors5.ButtonClick
        Select Case e.Button.Index
            Case 1 : ManageCbo.ManageColors(cboBOXColors5, FormMode.NewRecord)
            Case 2 : ManageCbo.ManageColors(cboBOXColors5, FormMode.EditRecord)
            Case 3 : cboBOXColors5.EditValue = Nothing
        End Select
    End Sub
    Private Sub cboBOXColors6_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboBOXColors6.ButtonClick
        Select Case e.Button.Index
            Case 1 : ManageCbo.ManageColors(cboBOXColors6, FormMode.NewRecord)
            Case 2 : ManageCbo.ManageColors(cboBOXColors6, FormMode.EditRecord)
            Case 3 : cboBOXColors6.EditValue = Nothing
        End Select
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
                        sResult = DBQ.InsertNewData(DBQueries.InsertMode.OneLayoutControl, "CCT_ORDERS_CLOSET", LayoutControl1,,, sGuid)
                        sID = sGuid
                    Case FormMode.EditRecord
                        sResult = DBQ.UpdateNewData(DBQueries.InsertMode.OneLayoutControl, "CCT_ORDERS_CLOSET", LayoutControl1,,, sID)
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


    Private Sub cboDoorType_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboDoorType.ButtonClick
        Select Case e.Button.Index
            Case 1 : ManageCbo.ManageDoorType(cboDoorType, FormMode.NewRecord, "CF691845-D6CC-4181-9760-6D15934C40B4")
            Case 2 : ManageCbo.ManageDoorType(cboDoorType, FormMode.EditRecord, "CF691845-D6CC-4181-9760-6D15934C40B4")
            Case 3 : cboDoorType.EditValue = Nothing
        End Select
    End Sub
    Private Sub cboDoorType2_ButtonClick(sender As Object, e As ButtonPressedEventArgs)
        Select Case e.Button.Index
            Case 1 : ManageCbo.ManageDoorType(cboDoorType2, FormMode.NewRecord, "CF691845-D6CC-4181-9760-6D15934C40B4")
            Case 2 : ManageCbo.ManageDoorType(cboDoorType2, FormMode.EditRecord, "CF691845-D6CC-4181-9760-6D15934C40B4")
            Case 3 : cboDoorType2.EditValue = Nothing
        End Select
    End Sub
    Private Sub cboDoorType3_ButtonClick(sender As Object, e As ButtonPressedEventArgs)
        Select Case e.Button.Index
            Case 1 : ManageCbo.ManageDoorType(cboDoorType3, FormMode.NewRecord, "CF691845-D6CC-4181-9760-6D15934C40B4")
            Case 2 : ManageCbo.ManageDoorType(cboDoorType3, FormMode.EditRecord, "CF691845-D6CC-4181-9760-6D15934C40B4")
            Case 3 : cboDoorType3.EditValue = Nothing
        End Select
    End Sub
    Private Sub cboDoorType4_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboDoorType4.ButtonClick
        Select Case e.Button.Index
            Case 1 : ManageCbo.ManageDoorType(cboDoorType4, FormMode.NewRecord, "CF691845-D6CC-4181-9760-6D15934C40B4")
            Case 2 : ManageCbo.ManageDoorType(cboDoorType4, FormMode.EditRecord, "CF691845-D6CC-4181-9760-6D15934C40B4")
            Case 3 : cboDoorType4.EditValue = Nothing
        End Select
    End Sub
    Private Sub cboDoorType5_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboDoorType5.ButtonClick
        Select Case e.Button.Index
            Case 1 : ManageCbo.ManageDoorType(cboDoorType5, FormMode.NewRecord, "CF691845-D6CC-4181-9760-6D15934C40B4")
            Case 2 : ManageCbo.ManageDoorType(cboDoorType5, FormMode.EditRecord, "CF691845-D6CC-4181-9760-6D15934C40B4")
            Case 3 : cboDoorType5.EditValue = Nothing
        End Select
    End Sub
    Private Sub cboDoorType6_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboDoorType6.ButtonClick
        Select Case e.Button.Index
            Case 1 : ManageCbo.ManageDoorType(cboDoorType6, FormMode.NewRecord, "CF691845-D6CC-4181-9760-6D15934C40B4")
            Case 2 : ManageCbo.ManageDoorType(cboDoorType6, FormMode.EditRecord, "CF691845-D6CC-4181-9760-6D15934C40B4")
            Case 3 : cboDoorType6.EditValue = Nothing
        End Select
    End Sub
    Private Sub cboDoorType7_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboDoorType7.ButtonClick
        Select Case e.Button.Index
            Case 1 : ManageCbo.ManageDoorType(cboDoorType7, FormMode.NewRecord, "CF691845-D6CC-4181-9760-6D15934C40B4")
            Case 2 : ManageCbo.ManageDoorType(cboDoorType7, FormMode.EditRecord, "CF691845-D6CC-4181-9760-6D15934C40B4")
            Case 3 : cboDoorType7.EditValue = Nothing
        End Select
    End Sub
    Private Sub cboDoorType8_ButtonClick(sender As Object, e As ButtonPressedEventArgs)
        Select Case e.Button.Index
            Case 1 : ManageCbo.ManageDoorType(cboDoorType8, FormMode.NewRecord, "CF691845-D6CC-4181-9760-6D15934C40B4")
            Case 2 : ManageCbo.ManageDoorType(cboDoorType8, FormMode.EditRecord, "CF691845-D6CC-4181-9760-6D15934C40B4")
            Case 3 : cboDoorType8.EditValue = Nothing
        End Select
    End Sub
    Private Sub cboDoorType9_ButtonClick(sender As Object, e As ButtonPressedEventArgs)
        Select Case e.Button.Index
            Case 1 : ManageCbo.ManageDoorType(cboDoorType9, FormMode.NewRecord, "CF691845-D6CC-4181-9760-6D15934C40B4")
            Case 2 : ManageCbo.ManageDoorType(cboDoorType9, FormMode.EditRecord, "CF691845-D6CC-4181-9760-6D15934C40B4")
            Case 3 : cboDoorType9.EditValue = Nothing
        End Select
    End Sub
    Private Sub cboDoorType10_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboDoorType10.ButtonClick
        Select Case e.Button.Index
            Case 1 : ManageCbo.ManageDoorType(cboDoorType10, FormMode.NewRecord, "CF691845-D6CC-4181-9760-6D15934C40B4")
            Case 2 : ManageCbo.ManageDoorType(cboDoorType10, FormMode.EditRecord, "CF691845-D6CC-4181-9760-6D15934C40B4")
            Case 3 : cboDoorType10.EditValue = Nothing
        End Select
    End Sub
    Private Sub cboDoorType11_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboDoorType11.ButtonClick
        Select Case e.Button.Index
            Case 1 : ManageCbo.ManageDoorType(cboDoorType11, FormMode.NewRecord, "CF691845-D6CC-4181-9760-6D15934C40B4")
            Case 2 : ManageCbo.ManageDoorType(cboDoorType11, FormMode.EditRecord, "CF691845-D6CC-4181-9760-6D15934C40B4")
            Case 3 : cboDoorType11.EditValue = Nothing
        End Select
    End Sub
    Private Sub cboDoorType12_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboDoorType12.ButtonClick
        Select Case e.Button.Index
            Case 1 : ManageCbo.ManageDoorType(cboDoorType12, FormMode.NewRecord, "CF691845-D6CC-4181-9760-6D15934C40B4")
            Case 2 : ManageCbo.ManageDoorType(cboDoorType12, FormMode.EditRecord, "CF691845-D6CC-4181-9760-6D15934C40B4")
            Case 3 : cboDoorType12.EditValue = Nothing
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
    Private Sub cboSides1_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboSides1.ButtonClick
        Select Case e.Button.Index
            Case 1 : ManageCbo.ManageDoorType(cboSides1, FormMode.NewRecord, "7B92C649-9B26-463B-AA8E-6CE0682CB91A")
            Case 2 : ManageCbo.ManageDoorType(cboSides1, FormMode.EditRecord, "7B92C649-9B26-463B-AA8E-6CE0682CB91A")
            Case 3 : cboSides1.EditValue = Nothing
        End Select
    End Sub

    Private Sub cboSides2_ButtonClick(sender As Object, e As ButtonPressedEventArgs)
        Select Case e.Button.Index
            Case 1 : ManageCbo.ManageDoorType(cboSides2, FormMode.NewRecord, "7B92C649-9B26-463B-AA8E-6CE0682CB91A")
            Case 2 : ManageCbo.ManageDoorType(cboSides2, FormMode.EditRecord, "7B92C649-9B26-463B-AA8E-6CE0682CB91A")
            Case 3 : cboSides2.EditValue = Nothing
        End Select
    End Sub

    Private Sub cboSides3_ButtonClick(sender As Object, e As ButtonPressedEventArgs)
        Select Case e.Button.Index
            Case 1 : ManageCbo.ManageDoorType(cboSides3, FormMode.NewRecord, "7B92C649-9B26-463B-AA8E-6CE0682CB91A")
            Case 2 : ManageCbo.ManageDoorType(cboSides3, FormMode.EditRecord, "7B92C649-9B26-463B-AA8E-6CE0682CB91A")
            Case 3 : cboSides3.EditValue = Nothing
        End Select
    End Sub

    Private Sub cboSides4_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboSides4.ButtonClick
        Select Case e.Button.Index
            Case 1 : ManageCbo.ManageDoorType(cboSides4, FormMode.NewRecord, "7B92C649-9B26-463B-AA8E-6CE0682CB91A")
            Case 2 : ManageCbo.ManageDoorType(cboSides1, FormMode.EditRecord, "7B92C649-9B26-463B-AA8E-6CE0682CB91A")
            Case 3 : cboSides4.EditValue = Nothing
        End Select
    End Sub

    Private Sub cboSides5_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboSides5.ButtonClick
        Select Case e.Button.Index
            Case 1 : ManageCbo.ManageDoorType(cboSides5, FormMode.NewRecord, "7B92C649-9B26-463B-AA8E-6CE0682CB91A")
            Case 2 : ManageCbo.ManageDoorType(cboSides5, FormMode.EditRecord, "7B92C649-9B26-463B-AA8E-6CE0682CB91A")
            Case 3 : cboSides5.EditValue = Nothing
        End Select
    End Sub


    Private Sub cboSides6_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboSides6.ButtonClick
        Select Case e.Button.Index
            Case 1 : ManageCbo.ManageDoorType(cboSides6, FormMode.NewRecord, "7B92C649-9B26-463B-AA8E-6CE0682CB91A")
            Case 2 : ManageCbo.ManageDoorType(cboSides6, FormMode.EditRecord, "7B92C649-9B26-463B-AA8E-6CE0682CB91A")
            Case 3 : cboSides6.EditValue = Nothing
        End Select
    End Sub

    Private Sub GridView2_CellValueChanged(sender As Object, e As CellValueChangedEventArgs) Handles GridView2.CellValueChanged

    End Sub

    Private Sub GridView2_CellValueChanging(sender As Object, e As CellValueChangedEventArgs) Handles GridView2.CellValueChanging
        If e.Column.FieldName = "checked" And e.Value = "false" Then
            GridView2.SetRowCellValue(GridView2.FocusedRowHandle, "QTY", 0)
            GridView2.SetRowCellValue(GridView2.FocusedRowHandle, "price", 0)
        End If
        If e.Column.FieldName = "checked" And e.Value = "true" Then
            GridView2.SetRowCellValue(GridView2.FocusedRowHandle, "QTY", 1)
            GridView2.SetRowCellValue(GridView2.FocusedRowHandle, "price", GridView2.GetRowCellValue(GridView2.FocusedRowHandle, "defPrice"))
        End If
        If e.Column.FieldName = "QTY" Then
            Dim sTot As Decimal = e.Value * GridView2.GetRowCellValue(GridView2.FocusedRowHandle, "defPrice")
            GridView2.SetRowCellValue(GridView2.FocusedRowHandle, "price", sTot)
        End If
    End Sub
End Class