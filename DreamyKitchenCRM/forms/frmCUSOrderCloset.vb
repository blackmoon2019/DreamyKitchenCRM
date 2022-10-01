Imports System.Data.SqlClient
Imports DevExpress.Utils
Imports DevExpress.Utils.Menu
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraGrid.Menu
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraReports.UI

Public Class frmCUSOrderCloset
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
        'TODO: This line of code loads data into the 'DMDataSet.vw_DOOR_TYPEEpendisisCloset' table. You can move, or remove it, as needed.
        Me.Vw_DOOR_TYPEEpendisisClosetTableAdapter.FillBYEpendisisCloset(Me.DMDataSet.vw_DOOR_TYPEEpendisisCloset)
        'TODO: This line of code loads data into the 'DMDataSet.vw_DOOR_TYPE1' table. You can move, or remove it, as needed.
        Me.Vw_DOOR_TYPE1TableAdapter.FillBYErmaria(Me.DMDataSet.vw_DOOR_TYPE1)
        'TODO: This line of code loads data into the 'DreamyKitchenDataSet.vw_EQUIPMENT_CLOSET' table. You can move, or remove it, as needed.
        Me.Vw_EQUIPMENT_CLOSETTableAdapter.Fill(Me.DreamyKitchenDataSet.vw_EQUIPMENT_CLOSET)
        'TODO: This line of code loads data into the 'DreamyKitchenDataSet.vw_COLORSPVC' table. You can move, or remove it, as needed.
        '  Me.Vw_COLORSPVCTableAdapter.Fill(Me.DreamyKitchenDataSet.vw_COLORSPVC)
        'TODO: This line of code loads data into the 'DreamyKitchenDataSet.vw_COLORSBOX' table. You can move, or remove it, as needed.
        Me.Vw_COLORSBOXTableAdapter.Fill(Me.DreamyKitchenDataSet.vw_COLORSBOX)
        'TODO: This line of code loads data into the 'DreamyKitchenDataSet.vw_CCT' table. You can move, or remove it, as needed.
        Me.Vw_CCTTableAdapter.Fill(Me.DreamyKitchenDataSet.vw_CCT)
        'TODO: This line of code loads data into the 'DreamyKitchenDataSet.vw_SALERS' table. You can move, or remove it, as needed.
        Me.Vw_SALERSTableAdapter.Fill(Me.DreamyKitchenDataSet.vw_SALERS)
        Prog_Prop.GetProgPROSF()

        Select Case Mode
            Case FormMode.NewRecord
                txtCode.Text = DBQ.GetNextId("CCT_ORDERS_CLOSET")
                cboEMP.EditValue = System.Guid.Parse(UserProps.ID.ToString.ToUpper)
                txtdtdaysOfDelivery.EditValue = ProgProps.DAYS_OF_DELIVERY
                cboBackThikness.EditValue = ProgProps.CLOSET_BACK_THIKNESS
                cboboxThikness.EditValue = ProgProps.CLOSET_BOX_THIKNESS
                ' cboBOXColors.EditValue = System.Guid.Parse(ProgProps.CLOSET_BOX_COLOR.ToUpper)
                cboLegs.EditValue = ProgProps.CLOSET_LEGS
                txtshelves.EditValue = ProgProps.CLOSET_SHELVES
                txtdrawers.EditValue = ProgProps.CLOSET_DRAWERS
                txtTransp.EditValue = ProgProps.ClosetTransp
                txtMeasurement.EditValue = ProgProps.ClosetMeasurement
                txtRemove.EditValue = ProgProps.ClosetRemove

                LoadForms.LoadDataToGrid(grdEquipment, GridView2,
                    "Select  e.ID,E.code,name,price,cast(case when (SELECT FLdVAL FROM PRM_DET WHERE TBL='EQUIPMENT' AND fld='ID' AND fldVal=e.id) is null then 0 else 1 end as bit) as  checked, " &
                    "case when (SELECT FLdVAL FROM PRM_DET WHERE TBL='EQUIPMENT' AND fld='ID' AND fldVal=e.id) is null then 0 else 1 end AS QTY " &
                     "From vw_EQUIPMENT E where equipmentCatID='DB158CAB-11EA-423B-9430-0C8A0CEB1D62' ORDER BY NAME")
                TabNavigationPage2.Enabled = False
            Case FormMode.EditRecord
                LoadForms.LoadForm(LayoutControl1, "Select * from CCT_ORDERS_CLOSET where id = " & toSQLValueS(sID))
                LoadForms.LoadDataToGrid(grdEquipment, GridView2,
                    "select e.ID,e.code,e.name,price,e.price as defPrice,
                    CAST(CASE WHEN (select eq.ID 
                    from CCT_ORDERS_CLOSET_EQUIPMENT EQ 
                    where eq.cctOrdersClosetID= " & toSQLValueS(sID) & " and eq.equipmentID=e.id) IS NULL THEN 0 ELSE 1 END AS BIT ) as checked,
                    isnull((select qty from CCT_ORDERS_CLOSET_EQUIPMENT EQ where eq.cctOrdersClosetID= " & toSQLValueS(sID) & " and eq.equipmentID=e.id),0) as QTY
                    from EQUIPMENT E
                    where equipmentCatID='DB158CAB-11EA-423B-9430-0C8A0CEB1D62'
                    ORDER BY NAME")
                TabNavigationPage2.Enabled = True

        End Select
        If System.IO.File.Exists(Application.StartupPath & "\DSGNS\DEF\CCT_ORDERS_CLOSET_EQUIPMENT_def.xml") = True Then
            GridView2.RestoreLayoutFromXml(Application.StartupPath & "\DSGNS\DEF\CCT_ORDERS_CLOSET_EQUIPMENT_def.xml", OptionsLayoutBase.FullLayout)
        End If
        GridView2.Columns.Item("name").OptionsColumn.AllowEdit = False : GridView2.Columns.Item("code").OptionsColumn.AllowEdit = False
        Me.CenterToScreen()
        cmdSave.Enabled = IIf(Mode = FormMode.NewRecord, UserProps.AllowInsert, UserProps.AllowEdit)

    End Sub
    Private Sub cboEMP_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboEMP.ButtonClick
        Select Case e.Button.Index
            Case 1 : If UserProps.ID.ToString.ToUpper = "3F9DC32E-BE5B-4D46-A13C-EA606566CF32" Then cboEMP.EditValue = Nothing : ManageEMP()
            Case 2 : If UserProps.ID.ToString.ToUpper = "3F9DC32E-BE5B-4D46-A13C-EA606566CF32" Then If cboEMP.EditValue <> Nothing Then ManageEMP()
            Case 3 : cboEMP.EditValue = Nothing
        End Select
    End Sub
    Private Sub cboCUS_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboCUS.ButtonClick
        Select Case e.Button.Index
            Case 1 : cboCUS.EditValue = Nothing : ManageCus()
            Case 2 : If cboCUS.EditValue <> Nothing Then ManageCus()
            Case 3 : cboCUS.EditValue = Nothing
        End Select
    End Sub


    Private Sub ManageColors(ByVal CallerControl As LookUpEdit)
        Dim frmColors As frmColors = New frmColors
        Select Case CallerControl.Name
            Case "cboGOLAColors" : frmColors.ColorCategory = "1FA658C9-A338-4805-B38F-7E6503A5CD25"
            Case "cboVBOXColors", "cboKBOXColors", "cboYBOXColors", "cboBOXColors", "cboBOXColors2",
                 "cboBOXColors3", "cboBOXColors4", "cboBOXColors5", "cboBOXColors6" : frmColors.ColorCategory = "40C7BFFB-43EB-48FB-A467-74C0BCBE09FA"
            Case "cboVPVCColors", "cboKPVCColors", "cboYPVCColors" : frmColors.ColorCategory = "1226147D-2FF2-4076-B24D-92ABC8FB4663"
        End Select

        frmColors.Text = "Χρώματα"
        frmColors.CallerForm = "frmCUSOrderCloset"
        frmColors.CallerControlLKUP = CallerControl
        frmColors.CalledFromControl = True
        frmColors.MdiParent = frmMain
        If CallerControl.EditValue <> Nothing Then
            frmColors.ID = CallerControl.EditValue.ToString
            frmColors.Mode = FormMode.EditRecord
        Else
            frmColors.Mode = FormMode.NewRecord
        End If
        frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(frmColors), New Point(CInt(frmColors.Parent.ClientRectangle.Width / 2 - frmColors.Width / 2), CInt(frmColors.Parent.ClientRectangle.Height / 2 - frmColors.Height / 2)))
        frmColors.Show()
    End Sub
    Private Sub ManageCus()
        Dim form1 As frmCustomers = New frmCustomers()
        form1.Text = "Πελάτες"
        form1.CallerControl = cboCUS
        form1.CalledFromControl = True
        form1.MdiParent = frmMain
        If cboCUS.EditValue <> Nothing Then
            form1.ID = cboCUS.EditValue.ToString
            form1.Mode = FormMode.EditRecord
        Else
            form1.Mode = FormMode.NewRecord
        End If
        frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(form1), New Point(CInt(form1.Parent.ClientRectangle.Width / 2 - form1.Width / 2), CInt(form1.Parent.ClientRectangle.Height / 2 - form1.Height / 2)))
        form1.Show()

    End Sub

    Private Sub ManageEMP()
        Dim form1 As frmEMP = New frmEMP()
        form1.Text = "Προσωπικό"
        form1.CallerControl = cboEMP
        form1.CalledFromControl = True
        form1.MdiParent = frmMain
        If cboEMP.EditValue <> Nothing Then
            form1.ID = cboEMP.EditValue.ToString
            form1.Mode = FormMode.EditRecord
        Else
            form1.Mode = FormMode.NewRecord
        End If
        frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(form1), New Point(CInt(form1.Parent.ClientRectangle.Width / 2 - form1.Width / 2), CInt(form1.Parent.ClientRectangle.Height / 2 - form1.Height / 2)))
        form1.Show()
    End Sub

    Private Sub cboBOXColors_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboBOXColors.ButtonClick
        Select Case e.Button.Index
            Case 1 : cboBOXColors.EditValue = Nothing : ManageColors(cboBOXColors) : cboDoorType.EditValue = Nothing : cboDoorType7.EditValue = Nothing
            Case 2 : If cboBOXColors.EditValue <> Nothing Then ManageColors(cboBOXColors)
            Case 3 : cboBOXColors.EditValue = Nothing : cboDoorType.EditValue = Nothing : cboDoorType7.EditValue = Nothing
        End Select
    End Sub
    Private Sub cboBOXColors2_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboBOXColors2.ButtonClick
        Select Case e.Button.Index
            Case 1 : cboBOXColors2.EditValue = Nothing : ManageColors(cboBOXColors2) : cboDoorType2.EditValue = Nothing : cboDoorType8.EditValue = Nothing
            Case 2 : If cboBOXColors2.EditValue <> Nothing Then ManageColors(cboBOXColors2)
            Case 3 : cboBOXColors2.EditValue = Nothing : cboDoorType2.EditValue = Nothing : cboDoorType8.EditValue = Nothing
        End Select
    End Sub
    Private Sub cboBOXColors3_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboBOXColors3.ButtonClick
        Select Case e.Button.Index
            Case 1 : cboBOXColors3.EditValue = Nothing : ManageColors(cboBOXColors3) : cboDoorType3.EditValue = Nothing : cboDoorType9.EditValue = Nothing
            Case 2 : If cboBOXColors3.EditValue <> Nothing Then ManageColors(cboBOXColors3)
            Case 3 : cboBOXColors3.EditValue = Nothing : cboDoorType3.EditValue = Nothing : cboDoorType9.EditValue = Nothing
        End Select
    End Sub
    Private Sub cboBOXColors4_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboBOXColors4.ButtonClick
        Select Case e.Button.Index
            Case 1 : cboBOXColors4.EditValue = Nothing : ManageColors(cboBOXColors4) : cboDoorType4.EditValue = Nothing : cboDoorType10.EditValue = Nothing
            Case 2 : If cboBOXColors4.EditValue <> Nothing Then ManageColors(cboBOXColors4)
            Case 3 : cboBOXColors4.EditValue = Nothing : cboDoorType4.EditValue = Nothing : cboDoorType10.EditValue = Nothing
        End Select
    End Sub
    Private Sub cboBOXColors5_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboBOXColors5.ButtonClick
        Select Case e.Button.Index
            Case 1 : cboBOXColors5.EditValue = Nothing : ManageColors(cboBOXColors5) : cboDoorType5.EditValue = Nothing : cboDoorType11.EditValue = Nothing
            Case 2 : If cboBOXColors5.EditValue <> Nothing Then ManageColors(cboBOXColors5)
            Case 3 : cboBOXColors5.EditValue = Nothing : cboDoorType5.EditValue = Nothing : cboDoorType11.EditValue = Nothing
        End Select
    End Sub
    Private Sub cboBOXColors6_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboBOXColors6.ButtonClick
        Select Case e.Button.Index
            Case 1 : cboBOXColors6.EditValue = Nothing : ManageColors(cboBOXColors6) : cboDoorType6.EditValue = Nothing : cboDoorType12.EditValue = Nothing
            Case 2 : If cboBOXColors6.EditValue <> Nothing Then ManageColors(cboBOXColors6)
            Case 3 : cboBOXColors6.EditValue = Nothing : cboDoorType6.EditValue = Nothing : cboDoorType12.EditValue = Nothing
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
                        sResult = DBQ.InsertNewData(DBQueries.InsertMode.OneLayoutControl, "CCT_ORDERS_CLOSET", LayoutControl1,,, sGuid, True)
                        sID = sGuid
                    Case FormMode.EditRecord
                        sResult = DBQ.UpdateNewData(DBQueries.InsertMode.OneLayoutControl, "CCT_ORDERS_CLOSET", LayoutControl1,,, sID, True)
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

                    ' Δημιουργία/Ενημέρωση Κοστολόγησης
                    Using oCmd As New SqlCommand("usp_InsertOrUpdateTransCost", CNDB)
                        oCmd.CommandType = CommandType.StoredProcedure
                        oCmd.Parameters.AddWithValue("@transhID", cboTRANSH.EditValue.ToString)
                        oCmd.Parameters.AddWithValue("@cctOrderKitchenID", System.Guid.Parse("00000000-0000-0000-0000-000000000000"))
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
        txtPhn.EditValue = cboCUS.GetColumnValue("phn")
        txtArea.EditValue = cboCUS.GetColumnValue("AREAS_Name")
        txtADR.EditValue = cboCUS.GetColumnValue("ADR_Name")
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
        lblDate.Text = DateAdd("d", CDbl(txtdtdaysOfDelivery.EditValue.ToString), FirstDate)
    End Sub

    Private Sub dtpresentation_EditValueChanged(sender As Object, e As EventArgs) Handles dtpresentation.EditValueChanged
        If dtpresentation.EditValue Is Nothing Then Exit Sub
        If dtpresentation.EditValue.ToString = "" Then Exit Sub
        Dim FirstDate As Date = dtpresentation.EditValue
        If txtdtdaysOfDelivery.EditValue Is Nothing Then txtdtdaysOfDelivery.EditValue = 0
        lblDate.Text = DateAdd("d", CDbl(txtdtdaysOfDelivery.EditValue.ToString), FirstDate)
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
            Case 1 : If UserProps.ID.ToString.ToUpper = "3F9DC32E-BE5B-4D46-A13C-EA606566CF32" Then cboTRANSH.EditValue = Nothing : ManageTRANSH()
            Case 2 : If UserProps.ID.ToString.ToUpper = "3F9DC32E-BE5B-4D46-A13C-EA606566CF32" Then If cboTRANSH.EditValue <> Nothing Then ManageTRANSH()
            Case 3 : cboTRANSH.EditValue = Nothing
        End Select
    End Sub
    Private Sub ManageTRANSH()
        Dim form1 As frmTransactions = New frmTransactions()
        form1.Text = "Χρεωπιστώσεις Πελατών"
        form1.CallerControl = cboTRANSH
        form1.CalledFromControl = True
        form1.MdiParent = frmMain
        If cboTRANSH.EditValue <> Nothing Then
            form1.ID = cboTRANSH.EditValue.ToString
            form1.Mode = FormMode.EditRecord
        End If
        frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(form1), New Point(CInt(form1.Parent.ClientRectangle.Width / 2 - form1.Width / 2), CInt(form1.Parent.ClientRectangle.Height / 2 - form1.Height / 2)))
        form1.Show()
    End Sub

    Private Sub cmdSaveEquipDev_Click(sender As Object, e As EventArgs) Handles cmdSaveEquipDev.Click
        InsertSelectedRows()
    End Sub

    Private Sub cboBOXColors_EditValueChanged(sender As Object, e As EventArgs) Handles cboBOXColors.EditValueChanged
        LoadDoorType(cboBOXColors, cboDoorType, cboClosetType1) : LoadDoorType(cboBOXColors, cboDoorType7, cboClosetType1)
    End Sub
    Private Sub cboBOXColors2_EditValueChanged(sender As Object, e As EventArgs) Handles cboBOXColors2.EditValueChanged
        LoadDoorType(cboBOXColors2, cboDoorType2, cboClosetType2) : LoadDoorType(cboBOXColors2, cboDoorType8, cboClosetType2)
    End Sub
    Private Sub cboBOXColors3_EditValueChanged(sender As Object, e As EventArgs) Handles cboBOXColors3.EditValueChanged
        LoadDoorType(cboBOXColors3, cboDoorType3, cboClosetType3) : LoadDoorType(cboBOXColors3, cboDoorType9, cboClosetType3)
    End Sub
    Private Sub cboBOXColors4_EditValueChanged(sender As Object, e As EventArgs) Handles cboBOXColors4.EditValueChanged
        LoadDoorType(cboBOXColors4, cboDoorType4, cboClosetType4) : LoadDoorType(cboBOXColors4, cboDoorType10, cboClosetType4)
    End Sub
    Private Sub cboBOXColors5_EditValueChanged(sender As Object, e As EventArgs) Handles cboBOXColors5.EditValueChanged
        LoadDoorType(cboBOXColors5, cboDoorType5, cboClosetType5) : LoadDoorType(cboBOXColors5, cboDoorType11, cboClosetType5)
    End Sub
    Private Sub cboBOXColors6_EditValueChanged(sender As Object, e As EventArgs) Handles cboBOXColors6.EditValueChanged
        LoadDoorType(cboBOXColors6, cboDoorType6, cboClosetType6) : LoadDoorType(cboBOXColors6, cboDoorType12, cboClosetType6)
    End Sub
    Private Sub LoadDoorType(ByVal lkupEditColor As LookUpEdit, ByVal lkupEditDoorType As LookUpEdit, Optional ByVal cboClosetTypes As ComboBoxEdit = Nothing)
        '      If Me.IsActive = False Then Exit Sub
        If lkupEditColor.EditValue = Nothing Then Exit Sub
        Dim sSQL = New System.Text.StringBuilder
        sSQL.AppendLine("Select id,name,price from vw_DOOR_TYPE where  doorCatID = 'CF691845-D6CC-4181-9760-6D15934C40B4' and doorColorID = " & toSQLValueS(lkupEditColor.EditValue.ToString))
        If cboClosetTypes IsNot Nothing Then sSQL.AppendLine(" and closetType = " & cboClosetTypes.SelectedIndex)
        FillCbo.DOOR_TYPE(lkupEditDoorType, sSQL)
    End Sub

    Private Sub cboDoorType_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboDoorType.ButtonClick
        Select Case e.Button.Index
            Case 1 : cboDoorType.EditValue = Nothing : ManageDoorType(cboDoorType, "CF691845-D6CC-4181-9760-6D15934C40B4")
            Case 2 : If cboDoorType.EditValue <> Nothing Then ManageDoorType(cboDoorType, "CF691845-D6CC-4181-9760-6D15934C40B4")
            Case 3 : cboDoorType.EditValue = Nothing
        End Select
    End Sub
    Private Sub cboDoorType2_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboDoorType2.ButtonClick
        Select Case e.Button.Index
            Case 1 : cboDoorType2.EditValue = Nothing : ManageDoorType(cboDoorType2, "CF691845-D6CC-4181-9760-6D15934C40B4")
            Case 2 : If cboDoorType2.EditValue <> Nothing Then ManageDoorType(cboDoorType2, "CF691845-D6CC-4181-9760-6D15934C40B4")
            Case 3 : cboDoorType2.EditValue = Nothing
        End Select
    End Sub
    Private Sub cboDoorType3_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboDoorType3.ButtonClick
        Select Case e.Button.Index
            Case 1 : cboDoorType3.EditValue = Nothing : ManageDoorType(cboDoorType3, "CF691845-D6CC-4181-9760-6D15934C40B4")
            Case 2 : If cboDoorType3.EditValue <> Nothing Then ManageDoorType(cboDoorType3, "CF691845-D6CC-4181-9760-6D15934C40B4")
            Case 3 : cboDoorType3.EditValue = Nothing
        End Select
    End Sub
    Private Sub cboDoorType4_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboDoorType4.ButtonClick
        Select Case e.Button.Index
            Case 1 : cboDoorType4.EditValue = Nothing : ManageDoorType(cboDoorType4, "CF691845-D6CC-4181-9760-6D15934C40B4")
            Case 2 : If cboDoorType4.EditValue <> Nothing Then ManageDoorType(cboDoorType4, "CF691845-D6CC-4181-9760-6D15934C40B4")
            Case 3 : cboDoorType4.EditValue = Nothing
        End Select
    End Sub
    Private Sub cboDoorType5_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboDoorType5.ButtonClick
        Select Case e.Button.Index
            Case 1 : cboDoorType5.EditValue = Nothing : ManageDoorType(cboDoorType5, "CF691845-D6CC-4181-9760-6D15934C40B4")
            Case 2 : If cboDoorType5.EditValue <> Nothing Then ManageDoorType(cboDoorType5, "CF691845-D6CC-4181-9760-6D15934C40B4")
            Case 3 : cboDoorType5.EditValue = Nothing
        End Select
    End Sub
    Private Sub cboDoorType6_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboDoorType6.ButtonClick
        Select Case e.Button.Index
            Case 1 : cboDoorType6.EditValue = Nothing : ManageDoorType(cboDoorType6, "CF691845-D6CC-4181-9760-6D15934C40B4")
            Case 2 : If cboDoorType6.EditValue <> Nothing Then ManageDoorType(cboDoorType6, "CF691845-D6CC-4181-9760-6D15934C40B4")
            Case 3 : cboDoorType6.EditValue = Nothing
        End Select
    End Sub
    Private Sub cboDoorType7_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboDoorType7.ButtonClick
        Select Case e.Button.Index
            Case 1 : cboDoorType7.EditValue = Nothing : ManageDoorType(cboDoorType7, "CF691845-D6CC-4181-9760-6D15934C40B4")
            Case 2 : If cboDoorType7.EditValue <> Nothing Then ManageDoorType(cboDoorType7, "CF691845-D6CC-4181-9760-6D15934C40B4")
            Case 3 : cboDoorType7.EditValue = Nothing
        End Select
    End Sub
    Private Sub cboDoorType8_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboDoorType8.ButtonClick
        Select Case e.Button.Index
            Case 1 : cboDoorType8.EditValue = Nothing : ManageDoorType(cboDoorType8, "CF691845-D6CC-4181-9760-6D15934C40B4")
            Case 2 : If cboDoorType8.EditValue <> Nothing Then ManageDoorType(cboDoorType8, "CF691845-D6CC-4181-9760-6D15934C40B4")
            Case 3 : cboDoorType8.EditValue = Nothing
        End Select
    End Sub
    Private Sub cboDoorType9_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboDoorType9.ButtonClick
        Select Case e.Button.Index
            Case 1 : cboDoorType9.EditValue = Nothing : ManageDoorType(cboDoorType9, "CF691845-D6CC-4181-9760-6D15934C40B4")
            Case 2 : If cboDoorType9.EditValue <> Nothing Then ManageDoorType(cboDoorType9, "CF691845-D6CC-4181-9760-6D15934C40B4")
            Case 3 : cboDoorType9.EditValue = Nothing
        End Select
    End Sub
    Private Sub cboDoorType10_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboDoorType10.ButtonClick
        Select Case e.Button.Index
            Case 1 : cboDoorType10.EditValue = Nothing : ManageDoorType(cboDoorType10, "CF691845-D6CC-4181-9760-6D15934C40B4")
            Case 2 : If cboDoorType10.EditValue <> Nothing Then ManageDoorType(cboDoorType10, "CF691845-D6CC-4181-9760-6D15934C40B4")
            Case 3 : cboDoorType10.EditValue = Nothing
        End Select
    End Sub
    Private Sub cboDoorType11_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboDoorType11.ButtonClick
        Select Case e.Button.Index
            Case 1 : cboDoorType11.EditValue = Nothing : ManageDoorType(cboDoorType11, "CF691845-D6CC-4181-9760-6D15934C40B4")
            Case 2 : If cboDoorType11.EditValue <> Nothing Then ManageDoorType(cboDoorType11, "CF691845-D6CC-4181-9760-6D15934C40B4")
            Case 3 : cboDoorType11.EditValue = Nothing
        End Select
    End Sub
    Private Sub cboDoorType12_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboDoorType12.ButtonClick
        Select Case e.Button.Index
            Case 1 : cboDoorType12.EditValue = Nothing : ManageDoorType(cboDoorType12, "CF691845-D6CC-4181-9760-6D15934C40B4")
            Case 2 : If cboDoorType12.EditValue <> Nothing Then ManageDoorType(cboDoorType12, "CF691845-D6CC-4181-9760-6D15934C40B4")
            Case 3 : cboDoorType12.EditValue = Nothing
        End Select
    End Sub
    Private Sub ManageDoorType(ByVal CallerControl As LookUpEdit, ByVal DoorCatID As String)
        Dim frmDoorType As frmDoorType = New frmDoorType
        frmDoorType.Text = "Κατηγορία Πόρτας"
        frmDoorType.CallerControl = CallerControl
        frmDoorType.CalledFromControl = True
        frmDoorType.cboDoorCat.EditValue = DoorCatID
        If CallerControl.EditValue <> Nothing Then frmDoorType.ID = CallerControl.EditValue.ToString
        frmDoorType.MdiParent = frmMain
        If CallerControl.EditValue <> Nothing Then frmDoorType.Mode = FormMode.EditRecord Else frmDoorType.Mode = FormMode.NewRecord
        frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(frmDoorType), New Point(CInt(frmDoorType.Parent.ClientRectangle.Width / 2 - frmDoorType.Width / 2), CInt(frmDoorType.Parent.ClientRectangle.Height / 2 - frmDoorType.Height / 2)))
        frmDoorType.Show()
    End Sub

    Private Sub cboClosetType1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboClosetType1.SelectedIndexChanged
        LoadDoorType(cboBOXColors, cboDoorType, cboClosetType1) : LoadDoorType(cboBOXColors, cboDoorType7, cboClosetType1)
    End Sub

    Private Sub cboClosetType2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboClosetType2.SelectedIndexChanged
        LoadDoorType(cboBOXColors2, cboDoorType2, cboClosetType2) : LoadDoorType(cboBOXColors2, cboDoorType8, cboClosetType2)
    End Sub

    Private Sub cboClosetType3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboClosetType3.SelectedIndexChanged
        LoadDoorType(cboBOXColors3, cboDoorType3, cboClosetType3) : LoadDoorType(cboBOXColors3, cboDoorType9, cboClosetType3)
    End Sub

    Private Sub cboClosetType4_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboClosetType4.SelectedIndexChanged
        LoadDoorType(cboBOXColors4, cboDoorType4, cboClosetType4) : LoadDoorType(cboBOXColors4, cboDoorType10, cboClosetType4)
    End Sub

    Private Sub cboClosetType5_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboClosetType5.SelectedIndexChanged
        LoadDoorType(cboBOXColors5, cboDoorType5, cboClosetType5) : LoadDoorType(cboBOXColors5, cboDoorType11, cboClosetType5)
    End Sub

    Private Sub cboClosetType6_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboClosetType6.SelectedIndexChanged
        LoadDoorType(cboBOXColors6, cboDoorType6, cboClosetType6) : LoadDoorType(cboBOXColors6, cboDoorType12, cboClosetType6)
    End Sub

    Private Sub cboClosetType1_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboClosetType1.ButtonClick
        Select Case e.Button.Index
            Case 1 : cboClosetType1.EditValue = Nothing : cboBOXColors.EditValue = Nothing : cboDoorType.EditValue = Nothing : cboDoorType7.EditValue = Nothing
        End Select
    End Sub
    Private Sub cboClosetType2_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboClosetType2.ButtonClick
        Select Case e.Button.Index
            Case 1 : cboClosetType2.EditValue = Nothing : cboBOXColors2.EditValue = Nothing : cboDoorType3.EditValue = Nothing : cboDoorType8.EditValue = Nothing
        End Select
    End Sub
    Private Sub cboClosetType3_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboClosetType3.ButtonClick
        Select Case e.Button.Index
            Case 1 : cboClosetType3.EditValue = Nothing : cboBOXColors3.EditValue = Nothing : cboDoorType3.EditValue = Nothing : cboDoorType9.EditValue = Nothing
        End Select
    End Sub
    Private Sub cboClosetType4_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboClosetType4.ButtonClick
        Select Case e.Button.Index
            Case 1 : cboClosetType4.EditValue = Nothing : cboBOXColors4.EditValue = Nothing : cboDoorType4.EditValue = Nothing : cboDoorType10.EditValue = Nothing
        End Select
    End Sub
    Private Sub cboClosetType5_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboClosetType5.ButtonClick
        Select Case e.Button.Index
            Case 1 : cboClosetType5.EditValue = Nothing : cboBOXColors5.EditValue = Nothing : cboDoorType5.EditValue = Nothing : cboDoorType11.EditValue = Nothing
        End Select
    End Sub
    Private Sub cboClosetType6_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboClosetType6.ButtonClick
        Select Case e.Button.Index
            Case 1 : cboClosetType6.EditValue = Nothing : cboBOXColors6.EditValue = Nothing : cboDoorType6.EditValue = Nothing : cboDoorType12.EditValue = Nothing
        End Select
    End Sub
    Private Sub cboSides1_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboSides1.ButtonClick
        Select Case e.Button.Index
            Case 1 : cboSides1.EditValue = Nothing : ManageDoorType(cboSides1, "7B92C649-9B26-463B-AA8E-6CE0682CB91A") : cboSides1.EditValue = Nothing
            Case 2 : If cboSides1.EditValue <> Nothing Then ManageDoorType(cboSides1, "7B92C649-9B26-463B-AA8E-6CE0682CB91A")
            Case 3 : cboSides1.EditValue = Nothing : cboSides1.EditValue = Nothing
        End Select
    End Sub

    Private Sub cboSides2_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboSides2.ButtonClick
        Select Case e.Button.Index
            Case 1 : cboSides2.EditValue = Nothing : ManageDoorType(cboSides2, "7B92C649-9B26-463B-AA8E-6CE0682CB91A") : cboSides2.EditValue = Nothing
            Case 2 : If cboSides2.EditValue <> Nothing Then ManageDoorType(cboSides2, "7B92C649-9B26-463B-AA8E-6CE0682CB91A")
            Case 3 : cboSides2.EditValue = Nothing : cboSides2.EditValue = Nothing
        End Select
    End Sub

    Private Sub cboSides3_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboSides3.ButtonClick
        Select Case e.Button.Index
            Case 1 : cboSides3.EditValue = Nothing : ManageDoorType(cboSides3, "7B92C649-9B26-463B-AA8E-6CE0682CB91A") : cboSides3.EditValue = Nothing
            Case 2 : If cboSides3.EditValue <> Nothing Then ManageDoorType(cboSides3, "7B92C649-9B26-463B-AA8E-6CE0682CB91A")
            Case 3 : cboSides3.EditValue = Nothing : cboSides3.EditValue = Nothing
        End Select
    End Sub

    Private Sub cboSides4_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboSides4.ButtonClick
        Select Case e.Button.Index
            Case 1 : cboSides4.EditValue = Nothing : ManageDoorType(cboSides4, "7B92C649-9B26-463B-AA8E-6CE0682CB91A") : cboSides4.EditValue = Nothing
            Case 2 : If cboSides4.EditValue <> Nothing Then ManageDoorType(cboSides4, "7B92C649-9B26-463B-AA8E-6CE0682CB91A")
            Case 3 : cboSides4.EditValue = Nothing : cboSides4.EditValue = Nothing
        End Select
    End Sub

    Private Sub cboSides5_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboSides5.ButtonClick
        Select Case e.Button.Index
            Case 1 : cboSides5.EditValue = Nothing : ManageDoorType(cboSides5, "7B92C649-9B26-463B-AA8E-6CE0682CB91A") : cboSides5.EditValue = Nothing
            Case 2 : If cboSides5.EditValue <> Nothing Then ManageDoorType(cboSides5, "7B92C649-9B26-463B-AA8E-6CE0682CB91A")
            Case 3 : cboSides5.EditValue = Nothing : cboSides5.EditValue = Nothing
        End Select
    End Sub


    Private Sub cboSides6_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboSides6.ButtonClick
        Select Case e.Button.Index
            Case 1 : cboSides6.EditValue = Nothing : ManageDoorType(cboSides6, "7B92C649-9B26-463B-AA8E-6CE0682CB91A") : cboSides6.EditValue = Nothing
            Case 2 : If cboSides6.EditValue <> Nothing Then ManageDoorType(cboSides6, "7B92C649-9B26-463B-AA8E-6CE0682CB91A")
            Case 3 : cboSides6.EditValue = Nothing : cboSides6.EditValue = Nothing
        End Select
    End Sub

End Class