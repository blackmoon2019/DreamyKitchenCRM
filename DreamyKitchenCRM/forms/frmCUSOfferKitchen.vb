Imports System.Data.SqlClient
Imports DevExpress.Utils
Imports DevExpress.Utils.Menu
Imports DevExpress.XtraBars.Navigation
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Menu
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraReports.UI

Public Class frmCUSOfferKitchen
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

    Private Sub frmCUSOffer_Load(sender As Object, e As EventArgs) Handles Me.Load
        'TODO: This line of code loads data into the 'DreamyKitchenDataSet.vw_EQUIPMENT_KITCHEN' table. You can move, or remove it, as needed.
        'Me.Vw_EQUIPMENT_KITCHENTableAdapter.Fill(Me.DreamyKitchenDataSet.vw_EQUIPMENT_KITCHEN)
        'TODO: This line of code loads data into the 'DreamyKitchenDataSet.vw_CCT' table. You can move, or remove it, as needed.
        Me.Vw_CCTTableAdapter.Fill(Me.DreamyKitchenDataSet.vw_CCT)
        'TODO: This line of code loads data into the 'DreamyKitchenDataSet.vw_BENCH' table. You can move, or remove it, as needed.
        Me.Vw_BENCHTableAdapter.Fill(Me.DreamyKitchenDataSet.vw_BENCH)
        'TODO: This line of code loads data into the 'DreamyKitchenDataSet.vw_COLORSPVC' table. You can move, or remove it, as needed.
        Me.Vw_COLORSPVCTableAdapter.Fill(Me.DreamyKitchenDataSet.vw_COLORSPVC)
        'TODO: This line of code loads data into the 'DreamyKitchenDataSet.vw_COLORSBOX' table. You can move, or remove it, as needed.
        Me.Vw_COLORSBOXTableAdapter.Fill(Me.DreamyKitchenDataSet.vw_COLORSBOX)
        'TODO: This line of code loads data into the 'DreamyKitchenDataSet.vw_SALERS' table. You can move, or remove it, as needed.
        Me.Vw_SALERSTableAdapter.Fill(Me.DreamyKitchenDataSet.vw_SALERS)
        Prog_Prop.GetProgPROSF()

        Select Case Mode
            Case FormMode.NewRecord
                txtCode.Text = DBQ.GetNextId("CCT_OFFERS")
                txtVHeight.EditValue = ProgProps.V_HEIGHT
                txtKHeight.EditValue = ProgProps.K_HEIGHT
                txtYHeight.EditValue = ProgProps.Y_HEIGHT
                cboVBOXColors.EditValue = System.Guid.Parse(ProgProps.V_BOX_COLOR)
                cboKBOXColors.EditValue = System.Guid.Parse(ProgProps.K_BOX_COLOR)
                cboYBOXColors.EditValue = System.Guid.Parse(ProgProps.Y_BOX_COLOR)
                cboVPVCColors.EditValue = System.Guid.Parse(ProgProps.V_PVC_COLOR)
                cboKPVCColors.EditValue = System.Guid.Parse(ProgProps.K_PVC_COLOR)
                cboYPVCColors.EditValue = System.Guid.Parse(ProgProps.Y_PVC_COLOR)
                cboBENCH.EditValue = System.Guid.Parse(ProgProps.BENCH)
                txtlegs.EditValue = ProgProps.LEGS
                txtKFinalHeight.EditValue = ProgProps.K_FINAL_HEIGHT
                txtYFinalHeight.EditValue = ProgProps.Y_FINAL_HEIGHT
                cboEMP.EditValue = System.Guid.Parse(UserProps.ID.ToString.ToUpper)
                txtdtdaysOfDelivery.EditValue = ProgProps.DAYS_OF_DELIVERY
                txtNotes.EditValue = ProgProps.CUS_NOTES
                LoadForms.LoadDataToGrid(grdEquipment, GridView2,
                    "Select  e.ID,E.code,name,price,cast(case when (SELECT FLdVAL FROM PRM_DET WHERE TBL='EQUIPMENT' AND fld='ID' AND fldVal=e.id) is null then 0 else 1 end as bit) as  checked, 
                    case when (SELECT FLdVAL FROM PRM_DET WHERE TBL='EQUIPMENT' AND fld='ID' AND fldVal=e.id) is null then 0 else 1 end AS QTY " &
                     "From vw_EQUIPMENT E where equipmentCatID='8AA21DC8-7D98-4596-8B73-9E664E955FFB' ORDER BY NAME")
                TabNavigationPage2.Enabled = False

            Case FormMode.EditRecord
                LoadForms.LoadForm(LayoutControl1, "Select * from CCT_OFFERS where id ='" + sID + "'")
                LoadForms.LoadDataToGrid(grdEquipment, GridView2,
                    "select e.ID,e.code,e.name,
                    isnull((select price from CCT_OFFERS_KITCHEN_EQUIPMENT EQ where eq.cctOffersKitchenID= " & toSQLValueS(sID) & " and eq.equipmentID=e.id),0) as price,
                    e.price as defPrice,
                    CAST(CASE WHEN (select eq.ID 
                    from CCT_OFFERS_KITCHEN_EQUIPMENT EQ 
                    where eq.cctOffersKitchenID= " & toSQLValueS(sID) & " and eq.equipmentID=e.id) IS NULL THEN 0 ELSE 1 END AS BIT ) as checked,
                    isnull((select qty from CCT_OFFERS_KITCHEN_EQUIPMENT EQ where eq.cctOffersKitchenID= " & toSQLValueS(sID) & " and eq.equipmentID=e.id),0) as QTY
                    from EQUIPMENT E
                    where equipmentCatID='8AA21DC8-7D98-4596-8B73-9E664E955FFB'
                    ORDER BY NAME")

                TabNavigationPage2.Enabled = True
        End Select


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
    Private Sub cboBENCH_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboBENCH.ButtonClick
        Select Case e.Button.Index
            Case 1 : cboBENCH.EditValue = Nothing : ManageBENCH()
            Case 2 : If cboBENCH.EditValue <> Nothing Then ManageBENCH()
            Case 3 : cboBENCH.EditValue = Nothing
        End Select
    End Sub
    Private Sub cboVBOXColors_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboVBOXColors.ButtonClick
        Select Case e.Button.Index
            Case 1 : cboVBOXColors.EditValue = Nothing : ManageColors(cboVBOXColors)
            Case 2 : If cboVBOXColors.EditValue <> Nothing Then ManageColors(cboVBOXColors)
            Case 3 : cboVBOXColors.EditValue = Nothing
        End Select
    End Sub
    Private Sub ManageColors(ByVal CallerControl As LookUpEdit)
        Dim frmColors As frmColors = New frmColors
        Select Case CallerControl.Name
            Case "cboGOLAColors" : frmColors.ColorCategory = "1FA658C9-A338-4805-B38F-7E6503A5CD25"
            Case "cboVBOXColors", "cboKBOXColors", "cboYBOXColors" : frmColors.ColorCategory = "40C7BFFB-43EB-48FB-A467-74C0BCBE09FA"
            Case "cboVPVCColors", "cboKPVCColors", "cboYPVCColors" : frmColors.ColorCategory = "1226147D-2FF2-4076-B24D-92ABC8FB4663"
        End Select
        frmColors.Text = "Χρώματα"
        frmColors.CallerForm = "frmCUSOffer"
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
    Private Sub ManageBENCH()
        Dim frmBench As frmBench = New frmBench
        frmBench.CallerForm = "frmOffer"
        frmBench.CallerControl = cboBENCH
        frmBench.CalledFromControl = True
        frmBench.MdiParent = frmMain
        If cboBENCH.EditValue <> Nothing Then
            frmBench.ID = cboBENCH.EditValue.ToString
            frmBench.Mode = FormMode.EditRecord
        Else
            frmBench.Mode = FormMode.NewRecord
        End If
        frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(frmBench), New Point(CInt(frmBench.Parent.ClientRectangle.Width / 2 - frmBench.Width / 2), CInt(frmBench.Parent.ClientRectangle.Height / 2 - frmBench.Height / 2)))
        frmBench.Show()
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

    Private Sub cboVPVCColors_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboVPVCColors.ButtonClick
        Select Case e.Button.Index
            Case 1 : cboVPVCColors.EditValue = Nothing : ManageColors(cboVPVCColors)
            Case 2 : If cboVPVCColors.EditValue <> Nothing Then ManageColors(cboVPVCColors)
            Case 3 : cboVPVCColors.EditValue = Nothing
        End Select
    End Sub
    Private Sub cboKBOXColors_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboKBOXColors.ButtonClick
        Select Case e.Button.Index
            Case 1 : cboVBOXColors.EditValue = Nothing : ManageColors(cboKBOXColors)
            Case 2 : If cboKBOXColors.EditValue <> Nothing Then ManageColors(cboKBOXColors)
            Case 3 : cboKBOXColors.EditValue = Nothing
        End Select
    End Sub

    Private Sub cboKPVCColors_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboKPVCColors.ButtonClick
        Select Case e.Button.Index
            Case 1 : cboVBOXColors.EditValue = Nothing : ManageColors(cboKPVCColors)
            Case 2 : If cboKPVCColors.EditValue <> Nothing Then ManageColors(cboKPVCColors)
            Case 3 : cboKPVCColors.EditValue = Nothing
        End Select
    End Sub

    Private Sub cboYBOXColors_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboYBOXColors.ButtonClick
        Select Case e.Button.Index
            Case 1 : cboVBOXColors.EditValue = Nothing : ManageColors(cboYBOXColors)
            Case 2 : If cboYBOXColors.EditValue <> Nothing Then ManageColors(cboYBOXColors)
            Case 3 : cboYBOXColors.EditValue = Nothing
        End Select
    End Sub

    Private Sub cboYPVCColors_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboYPVCColors.ButtonClick
        Select Case e.Button.Index
            Case 1 : cboVBOXColors.EditValue = Nothing : ManageColors(cboYPVCColors)
            Case 2 : If cboYPVCColors.EditValue <> Nothing Then ManageColors(cboYPVCColors)
            Case 3 : cboYPVCColors.EditValue = Nothing
        End Select
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

    Private Sub cboCUS_EditValueChanged(sender As Object, e As EventArgs) Handles cboCUS.EditValueChanged
        txtPhn.EditValue = cboCUS.GetColumnValue("phn")
        txtArea.EditValue = cboCUS.GetColumnValue("AREAS_Name")
        txtADR.EditValue = cboCUS.GetColumnValue("ADR_Name")
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

    Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click
        Dim sResult As Boolean
        Dim sGuid As String
        Try
            If Valid.ValidateForm(LayoutControl1) Then
                Select Case Mode
                    Case FormMode.NewRecord
                        sGuid = System.Guid.NewGuid.ToString
                        sResult = DBQ.InsertNewData(DBQueries.InsertMode.OneLayoutControl, "CCT_OFFERS", LayoutControl1,,, sGuid, True)
                        sID = sGuid
                    Case FormMode.EditRecord
                        sResult = DBQ.UpdateNewData(DBQueries.InsertMode.OneLayoutControl, "CCT_OFFERS", LayoutControl1,,, sID, True)
                        'sGuid = sID
                End Select

                If FScrollerExist = True Then
                    Dim form As frmScroller = Frm
                    form.LoadRecords("vw_CCT_OFFERS")
                End If

                If sResult = True Then
                    XtraMessageBox.Show("Η εγγραφή αποθηκέυτηκε με επιτυχία", "Dreamy Kitchen CRM", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    ' Καταχώρηση Εξοπλισμών
                    If Mode = FormMode.NewRecord Then
                        GridView2.PopulateColumns()
                        TabNavigationPage2.Enabled = True
                        InsertSelectedRows(False)
                        Mode = FormMode.EditRecord
                    End If


                    '    Cls.ClearCtrls(LayoutControl1)
                    '    txtCode.Text = DBQ.GetNextId("CCT_OFFERS")
                    'End If
                End If
            End If

        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), "Dreamy Kitchen CRM", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cmdPrintOffer_Click(sender As Object, e As EventArgs) Handles cmdPrintOffer.Click
        Dim report As New RepCUSOfferKitchen()

        report.Parameters.Item(0).Value = sID
        report.CreateDocument()
        Dim report2 As New Rep_Offer2ndPage

        report2.CreateDocument()
        report.ModifyDocument(Sub(x)
                                  x.AddPages(report2.Pages)
                              End Sub)
        Dim report3 As New RepCUSOfferKitchen3ndPage
        report3.Parameters.Item(0).Value = sID
        report3.CreateDocument()
        report.ModifyDocument(Sub(x)
                                  x.AddPages(report3.Pages)
                              End Sub)

        Dim printTool As New ReportPrintTool(report)
        printTool.ShowRibbonPreview()
    End Sub

    Private Sub frmCUSOfferKitchen_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        If Me.WindowState = FormWindowState.Maximized Then frmMain.XtraTabbedMdiManager1.Dock(Me, frmMain.XtraTabbedMdiManager1)
    End Sub

    Private Sub GridView2_PopupMenuShowing(sender As Object, e As PopupMenuShowingEventArgs) Handles GridView2.PopupMenuShowing
        If e.MenuType = GridMenuType.Column Then LoadForms.PopupMenuShow(e, GridView2, "CCT_OFFERS_KITCHEN_EQUIPMENT_def.xml", "vw_CCT_OFFERS_KITCHEN_EQUIPMENT_def")
    End Sub

    Private Sub cmdSaveEquipDev_Click(sender As Object, e As EventArgs) Handles cmdSaveEquip.Click
        InsertSelectedRows(True)
    End Sub
    Private Sub InsertSelectedRows(ByVal msg As Boolean)
        Dim sSQL As String
        Dim I As Integer
        sSQL = "DELETE FROM CCT_OFFERS_KITCHEN_EQUIPMENT WHERE cctOffersKitchenID = " & toSQLValueS(sID)
        Using oCmd As New SqlCommand(sSQL, CNDB)
            oCmd.ExecuteNonQuery()
        End Using
        sSQL = "DELETE FROM CCT_OFFERS_KITCHEN_EQUIPMENT WHERE cctOffersKitchenID = " & toSQLValueS(sID)
        Using oCmd As New SqlCommand(sSQL, CNDB)
            oCmd.ExecuteNonQuery()
        End Using
        Dim Selected As Boolean
        For I = 0 To GridView2.RowCount - 1
            Selected = GridView2.GetRowCellValue(I, "checked")
            If Selected = True Then
                sSQL = "INSERT INTO CCT_OFFERS_KITCHEN_EQUIPMENT(cctOffersKitchenID,equipmentID,price,selected,qty) " &
                    " VALUES ( " & toSQLValueS(sID) & "," & toSQLValueS(GridView2.GetRowCellValue(I, "ID").ToString) & "," & toSQLValueS(GridView2.GetRowCellValue(I, "price").ToString, True) & ",1," & toSQLValueS(GridView2.GetRowCellValue(I, "QTY").ToString, True) & ")"
                Using oCmd As New SqlCommand(sSQL, CNDB)
                    oCmd.ExecuteNonQuery()
                End Using
            End If
        Next
        If msg Then XtraMessageBox.Show("Η εγγραφή αποθηκέυτηκε με επιτυχία", "Dreamy Kitchen CRM", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub RepDefPrice_ButtonPressed(sender As Object, e As ButtonPressedEventArgs) Handles RepDefPrice.ButtonPressed
        Select Case e.Button.Index
            Case 0 : GridView2.SetRowCellValue(GridView2.FocusedRowHandle, "price", GridView2.GetRowCellValue(GridView2.FocusedRowHandle, "defPrice").ToString)
            Case 1 : GridView2.SetRowCellValue(GridView2.FocusedRowHandle, "price", "0.00")
        End Select
    End Sub

    Private Sub TabPane1_SelectedPageChanged(sender As Object, e As SelectedPageChangedEventArgs) Handles TabPane1.SelectedPageChanged
        Select Case TabPane1.SelectedPageIndex
            Case 1
                If My.Computer.FileSystem.FileExists(Application.StartupPath & "\DSGNS\DEF\CCT_OFFERS_KITCHEN_EQUIPMENT_def.xml") = True Then
                    GridView2.RestoreLayoutFromXml(Application.StartupPath & "\DSGNS\DEF\CCT_OFFERS_KITCHEN_EQUIPMENT_def.xml", OptionsLayoutBase.FullLayout)
                End If

                GridView2.Columns.Item("name").OptionsColumn.AllowEdit = False : GridView2.Columns.Item("code").OptionsColumn.AllowEdit = False
                GridView2.Columns.Item("checked").OptionsColumn.AllowEdit = True : GridView2.Columns.Item("checked").OptionsColumn.ReadOnly = False

        End Select


    End Sub


End Class