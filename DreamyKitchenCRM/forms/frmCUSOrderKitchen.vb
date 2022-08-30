Imports System.Data.SqlClient
Imports DevExpress.Utils
Imports DevExpress.Utils.Menu
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Menu
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraReports.UI


Public Class frmCUSOrderKitchen
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
    Private Sub frmCUSOrderKitchen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DMDataSet.vw_DOOR_TYPERafiaWall' table. You can move, or remove it, as needed.
        Me.Vw_DOOR_TYPERafiaWallTableAdapter.FillByRafiaWall(Me.DMDataSet.vw_DOOR_TYPERafiaWall)
        'TODO: This line of code loads data into the 'DMDataSet.vw_DOOR_TYPERafieresY' table. You can move, or remove it, as needed.
        Me.Vw_DOOR_TYPERafieresYTableAdapter.FillByRafieresY(Me.DMDataSet.vw_DOOR_TYPERafieresY)
        'TODO: This line of code loads data into the 'DMDataSet.vw_DOOR_TYPERafieresK' table. You can move, or remove it, as needed.
        Me.Vw_DOOR_TYPERafieresKTableAdapter.FillByRafieresK(Me.DMDataSet.vw_DOOR_TYPERafieresK)
        'TODO: This line of code loads data into the 'DMDataSet.vw_DOOR_TYPERafieresV' table. You can move, or remove it, as needed.
        Me.Vw_DOOR_TYPERafieresVTableAdapter.FillByRafieresV(Me.DMDataSet.vw_DOOR_TYPERafieresV)
        'TODO: This line of code loads data into the 'DMDataSet.vw_DOOR_TYPEPlainaKremasta' table. You can move, or remove it, as needed.
        Me.Vw_DOOR_TYPEPlainaKremastaTableAdapter.FillByPlainaKremasta(Me.DMDataSet.vw_DOOR_TYPEPlainaKremasta)
        'TODO: This line of code loads data into the 'DreamyKitchenDataSet.vw_BENCH' table. You can move, or remove it, as needed.
        Me.Vw_BENCHTableAdapter.Fill(Me.DreamyKitchenDataSet.vw_BENCH)
        'TODO: This line of code loads data into the 'DMDataSet.vw_DOOR_TYPEPlainaYpsila' table. You can move, or remove it, as needed.
        Me.Vw_DOOR_TYPEPlainaYpsilaTableAdapter.FillBYPlainaYpsila(Me.DMDataSet.vw_DOOR_TYPEPlainaYpsila)
        'TODO: This line of code loads data into the 'DMDataSet.vw_DOOR_TYPE1' table. You can move, or remove it, as needed.
        Me.Vw_DOOR_TYPE1TableAdapter.FillBYErmaria(Me.DMDataSet.vw_DOOR_TYPE1)
        'TODO: This line of code loads data into the 'DMDataSet.vw_DOOR_TYPE' table. You can move, or remove it, as needed.
        Me.Vw_DOOR_TYPETableAdapter1.FillBYNisida(Me.DMDataSet.vw_DOOR_TYPE)
        'TODO: This line of code loads data into the 'DMDataSet.DOOR_TYPE' table. You can move, or remove it, as needed.
        Me.DOOR_TYPETableAdapter.FillBYPlainaVaseos(Me.DMDataSet.DOOR_TYPE)
        'TODO: This line of code loads data into the 'DreamyKitchenDataSet.vw_CCT' table. You can move, or remove it, as needed.
        Me.Vw_CCTTableAdapter.Fill(Me.DreamyKitchenDataSet.vw_CCT)
        'TODO: This line of code loads data into the 'DreamyKitchenDataSet.vw_SALERS' table. You can move, or remove it, as needed.
        Me.Vw_SALERSTableAdapter.Fill(Me.DreamyKitchenDataSet.vw_SALERS)
        'TODO: This line of code loads data into the 'DreamyKitchenDataSet.vw_DEVICES' table. You can move, or remove it, as needed.
        'Me.Vw_DEVICESTableAdapter.Fill(Me.DreamyKitchenDataSet.vw_DEVICES)
        'TODO: This line of code loads data into the 'DreamyKitchenDataSet.vw_EQUIPMENT' table. You can move, or remove it, as needed.
        'Me.Vw_EQUIPMENTTableAdapter.Fill(Me.DreamyKitchenDataSet.vw_EQUIPMENT)
        'TODO: This line of code loads data into the 'DreamyKitchenDataSet.vw_COLORSGOLA' table. You can move, or remove it, as needed.
        Me.Vw_COLORSGOLATableAdapter.Fill(Me.DreamyKitchenDataSet.vw_COLORSGOLA)
        'TODO: This line of code loads data into the 'DreamyKitchenDataSet.vw_COLORSPVC' table. You can move, or remove it, as needed.
        Me.Vw_COLORSPVCTableAdapter.Fill(Me.DreamyKitchenDataSet.vw_COLORSPVC)
        'TODO: This line of code loads data into the 'DreamyKitchenDataSet.vw_COLORSBOX' table. You can move, or remove it, as needed.
        Me.Vw_COLORSBOXTableAdapter.Fill(Me.DreamyKitchenDataSet.vw_COLORSBOX)
        Prog_Prop.GetProgPROSF()

        Select Case Mode
            Case FormMode.NewRecord
                txtCode.Text = DBQ.GetNextId("CCT_ORDERS_KITCHEN")
                cboEMP.EditValue = System.Guid.Parse(UserProps.ID.ToString.ToUpper)
                txtdtdaysOfDelivery.EditValue = ProgProps.DAYS_OF_DELIVERY
                txtExtraTransp.EditValue = ProgProps.KitchenTransp
                txtMeasurement.EditValue = ProgProps.KitchenMeasurement
                txtRemove.EditValue = ProgProps.KitchenRemove

                LoadForms.LoadDataToGrid(grdEquipment, GridView2,
                    "Select  e.ID,E.code,name,price,cast(case when (SELECT FLdVAL FROM PRM_DET WHERE TBL='EQUIPMENT' AND fld='ID' AND fldVal=e.id) is null then 0 else 1 end as bit) as  checked,
                     case when (SELECT FLdVAL FROM PRM_DET WHERE TBL='EQUIPMENT' AND fld='ID' AND fldVal=e.id) is null then 0 else 1 end AS QTY " &
                     "From vw_EQUIPMENT E where equipmentCatID='8AA21DC8-7D98-4596-8B73-9E664E955FFB' ORDER BY NAME")
                TabNavigationPage2.Enabled = False
            Case FormMode.EditRecord
                LoadForms.LoadForm(LayoutControl1, "Select * from CCT_ORDERS_KITCHEN where id = " & toSQLValueS(sID))
                LoadForms.LoadDataToGrid(grdEquipment, GridView2,
                    "select e.ID,e.code,e.name,price,
                    CAST(CASE WHEN (select eq.ID 
                    from CCT_ORDERS_KITCHEN_EQUIPMENT EQ 
                    where eq.cctOrdersKitchenID= " & toSQLValueS(sID) & " and eq.equipmentID=e.id) IS NULL THEN 0 ELSE 1 END AS BIT ) as checked,
                    isnull((select qty from CCT_ORDERS_KITCHEN_EQUIPMENT EQ where eq.cctOrdersKitchenID= " & toSQLValueS(sID) & " and eq.equipmentID=e.id),0) as QTY
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
        If System.IO.File.Exists(Application.StartupPath & "\DSGNS\DEF\CCT_ORDERS_KITCHEN_EQUIPMENT_def.xml") = True Then
            GridView2.RestoreLayoutFromXml(Application.StartupPath & "\DSGNS\DEF\CCT_ORDERS_KITCHEN_EQUIPMENT_def.xml", OptionsLayoutBase.FullLayout)
        End If
        If System.IO.File.Exists(Application.StartupPath & "\DSGNS\DEF\CCT_ORDERS_KITCHEN_DEVICES_def.xml") = True Then
            GridView1.RestoreLayoutFromXml(Application.StartupPath & "\DSGNS\DEF\CCT_ORDERS_KITCHEN_DEVICES_def.xml", OptionsLayoutBase.FullLayout)
        End If
        GridView2.Columns.Item("name").OptionsColumn.AllowEdit = False : GridView2.Columns.Item("code").OptionsColumn.AllowEdit = False
        GridView1.Columns.Item("name").OptionsColumn.AllowEdit = False : GridView1.Columns.Item("code").OptionsColumn.AllowEdit = False
        GridView1.OptionsMenu.ShowConditionalFormattingItem = True
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
        frmColors.CallerForm = "frmCUSOrderKitchen"
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
    Private Sub cboKBOXColors_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboKBOXColors.ButtonClick
        Select Case e.Button.Index
            Case 1 : cboVBOXColors.EditValue = Nothing : ManageColors(cboKBOXColors)
            Case 2 : If cboKBOXColors.EditValue <> Nothing Then ManageColors(cboKBOXColors)
            Case 3 : cboKBOXColors.EditValue = Nothing
        End Select
    End Sub


    Private Sub cboYBOXColors_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboYBOXColors.ButtonClick
        Select Case e.Button.Index
            Case 1 : cboVBOXColors.EditValue = Nothing : ManageColors(cboYBOXColors)
            Case 2 : If cboYBOXColors.EditValue <> Nothing Then ManageColors(cboYBOXColors)
            Case 3 : cboYBOXColors.EditValue = Nothing
        End Select
    End Sub

    Private Sub cboGOLAColors_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboGOLAColors.ButtonClick
        Select Case e.Button.Index
            Case 1 : cboGOLAColors.EditValue = Nothing : ManageColors(cboGOLAColors)
            Case 2 : If cboGOLAColors.EditValue <> Nothing Then ManageColors(cboGOLAColors)
            Case 3 : cboGOLAColors.EditValue = Nothing
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
                        sResult = DBQ.InsertNewData(DBQueries.InsertMode.OneLayoutControl, "CCT_ORDERS_KITCHEN", LayoutControl1,,, sGuid, True, "dtDeliver", toSQLValueS(CDate(lblDate.Text).ToString("yyyyMMdd")))
                        sID = sGuid
                    Case FormMode.EditRecord
                        sResult = DBQ.UpdateNewData(DBQueries.InsertMode.OneLayoutControl, "CCT_ORDERS_KITCHEN", LayoutControl1,,, sID, True,,,, "dtDeliver=" & toSQLValueS(CDate(lblDate.Text).ToString("yyyyMMdd")))
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
                        InsertSelectedRows(True)
                        If System.IO.File.Exists(Application.StartupPath & "\DSGNS\DEF\CCT_ORDERS_KITCHEN_EQUIPMENT_def.xml") = True Then
                            GridView2.RestoreLayoutFromXml(Application.StartupPath & "\DSGNS\DEF\CCT_ORDERS_KITCHEN_EQUIPMENT_def.xml", OptionsLayoutBase.FullLayout)
                        End If
                        If System.IO.File.Exists(Application.StartupPath & "\DSGNS\DEF\CCT_ORDERS_KITCHEN_DEVICES_def.xml") = True Then
                            GridView1.RestoreLayoutFromXml(Application.StartupPath & "\DSGNS\DEF\CCT_ORDERS_KITCHEN_DEVICES_def.xml", OptionsLayoutBase.FullLayout)
                        End If
                    End If
                    Mode = FormMode.EditRecord
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
        txtPhn.EditValue = cboCUS.GetColumnValue("phn")
        txtArea.EditValue = cboCUS.GetColumnValue("AREAS_Name")
        txtADR.EditValue = cboCUS.GetColumnValue("ADR_Name")
        Dim sCusID As String
        If cboCUS.EditValue Is Nothing Then sCusID = toSQLValueS(Guid.Empty.ToString) Else sCusID = toSQLValueS(cboCUS.EditValue.ToString)
        Dim sSQL As New System.Text.StringBuilder
        sSQL.AppendLine("Select T.id,FullTranshDescription,Description
                        from vw_TRANSH t
                        where  T.cusid = " & sCusID & "order by description")
        FillCbo.TRANSH(cboTRANSH, sSQL)

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

    Private Sub cboVType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboVType.SelectedIndexChanged
        If cboVType.SelectedIndex = 1 Then
            cboGOLAColors.ReadOnly = False
        Else
            cboGOLAColors.ReadOnly = True
            cboGOLAColors.EditValue = Nothing
        End If
    End Sub

    Private Sub cboYHeight_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboYHeight.SelectedIndexChanged
        If cboYHeight.SelectedIndex = 3 Then
            txtOtherHeight.ReadOnly = False
        Else
            txtOtherHeight.ReadOnly = True
            txtOtherHeight.EditValue = Nothing
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
        sSQL = "DELETE FROM CCT_ORDERS_KITCHEN_DEVICES WHERE cctOrdersKitchenID = " & toSQLValueS(sID)
        Using oCmd As New SqlCommand(sSQL, CNDB)
            oCmd.ExecuteNonQuery()
        End Using
        Dim Selected As Boolean
        For I = 0 To GridView2.RowCount - 1
            Selected = GridView2.GetRowCellValue(I, "checked")
            If Selected = True Then
                sSQL = "INSERT INTO CCT_ORDERS_KITCHEN_EQUIPMENT(cctOrdersKitchenID,equipmentID,selected,qty) " &
                    " VALUES ( " & toSQLValueS(sID) & "," & toSQLValueS(GridView2.GetRowCellValue(I, "ID").ToString) & ",1," & toSQLValueS(GridView2.GetRowCellValue(I, "QTY").ToString, True) & ")"
                Using oCmd As New SqlCommand(sSQL, CNDB)
                    oCmd.ExecuteNonQuery()
                End Using
            End If
        Next
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

    End Sub

    Private Sub GridView1_PopupMenuShowing(sender As Object, e As PopupMenuShowingEventArgs) Handles GridView1.PopupMenuShowing
        If e.MenuType = GridMenuType.Column Then LoadForms.PopupMenuShow(e, GridView2, "CCT_ORDERS_KITCHEN_DEVICES_def.xml", "vw_CCT_ORDERS_KITCHEN_DEVICES")
    End Sub
    Private Sub GridView2_PopupMenuShowing(sender As Object, e As PopupMenuShowingEventArgs) Handles GridView2.PopupMenuShowing
        If e.MenuType = GridMenuType.Column Then LoadForms.PopupMenuShow(e, GridView2, "CCT_ORDERS_KITCHEN_EQUIPMENT_def.xml", "vw_CCT_ORDERS_KITCHEN_EQUIPMENT")
    End Sub

    Private Sub cmdPrintOffer_Click(sender As Object, e As EventArgs) Handles cmdPrintOffer.Click
        Dim report As New RepCUSOrderKitchen()

        report.Parameters.Item(0).Value = sID
        report.CreateDocument()
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

    Private Sub cboTRANSH_ButtonClick(sender As Object, e As ButtonPressedEventArgs)
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

    Private Sub cboVDoorType_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboVDoorType.ButtonClick
        Select Case e.Button.Index
            Case 1 : cboVDoorType.EditValue = Nothing : ManageDoorType(cboVDoorType)
            Case 2 : If cboVDoorType.EditValue <> Nothing Then ManageDoorType(cboVDoorType)
            Case 3 : cboVDoorType.EditValue = Nothing
        End Select
    End Sub
    Private Sub cboKDoorType_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboKDoorType.ButtonClick
        Select Case e.Button.Index
            Case 1 : cboKDoorType.EditValue = Nothing : ManageDoorType(cboKDoorType)
            Case 2 : If cboKDoorType.EditValue <> Nothing Then ManageDoorType(cboKDoorType)
            Case 3 : cboKDoorType.EditValue = Nothing
        End Select
    End Sub
    Private Sub cboYDoorType_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboYDoorType.ButtonClick
        Select Case e.Button.Index
            Case 1 : cboYDoorType.EditValue = Nothing : ManageDoorType(cboYDoorType)
            Case 2 : If cboYDoorType.EditValue <> Nothing Then ManageDoorType(cboYDoorType)
            Case 3 : cboYDoorType.EditValue = Nothing
        End Select
    End Sub
    Private Sub cboVDoorType1_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboVDoorType1.ButtonClick
        Select Case e.Button.Index
            Case 1 : cboVDoorType1.EditValue = Nothing : ManageDoorType(cboVDoorType1)
            Case 2 : If cboVDoorType1.EditValue <> Nothing Then ManageDoorType(cboVDoorType1)
            Case 3 : cboVDoorType1.EditValue = Nothing
        End Select
    End Sub
    Private Sub cboKDoorType1_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboKDoorType1.ButtonClick
        Select Case e.Button.Index
            Case 1 : cboKDoorType1.EditValue = Nothing : ManageDoorType(cboKDoorType1)
            Case 2 : If cboKDoorType1.EditValue <> Nothing Then ManageDoorType(cboKDoorType1)
            Case 3 : cboKDoorType1.EditValue = Nothing
        End Select
    End Sub
    Private Sub cboYDoorType1_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboYDoorType1.ButtonClick
        Select Case e.Button.Index
            Case 1 : cboYDoorType1.EditValue = Nothing : ManageDoorType(cboYDoorType1)
            Case 2 : If cboYDoorType1.EditValue <> Nothing Then ManageDoorType(cboYDoorType1)
            Case 3 : cboYDoorType1.EditValue = Nothing
        End Select
    End Sub
    Private Sub cboVependisisDoorType_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboVependisisDoorType.ButtonClick
        Select Case e.Button.Index
            Case 1 : cboVependisisDoorType.EditValue = Nothing : ManageDoorType(cboVependisisDoorType)
            Case 2 : If cboVependisisDoorType.EditValue <> Nothing Then ManageDoorType(cboVependisisDoorType)
            Case 3 : cboVependisisDoorType.EditValue = Nothing
        End Select
    End Sub
    Private Sub cboKependisisDoorType_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboKependisisDoorType.ButtonClick
        Select Case e.Button.Index
            Case 1 : cboKependisisDoorType.EditValue = Nothing : ManageDoorType(cboKependisisDoorType)
            Case 2 : If cboKependisisDoorType.EditValue <> Nothing Then ManageDoorType(cboKependisisDoorType)
            Case 3 : cboKependisisDoorType.EditValue = Nothing
        End Select
    End Sub
    Private Sub cboSndEpendisisDoorType_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboSndEpendisisDoorType.ButtonClick
        Select Case e.Button.Index
            Case 1 : cboSndEpendisisDoorType.EditValue = Nothing : ManageDoorType(cboSndEpendisisDoorType)
            Case 2 : If cboSndEpendisisDoorType.EditValue <> Nothing Then ManageDoorType(cboSndEpendisisDoorType)
            Case 3 : cboSndEpendisisDoorType.EditValue = Nothing
        End Select
    End Sub
    Private Sub cboNependisisDoorType_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboNependisisDoorType.ButtonClick
        Select Case e.Button.Index
            Case 1 : cboNependisisDoorType.EditValue = Nothing : ManageDoorType(cboNependisisDoorType)
            Case 2 : If cboNependisisDoorType.EditValue <> Nothing Then ManageDoorType(cboNependisisDoorType)
            Case 3 : cboNependisisDoorType.EditValue = Nothing
        End Select
    End Sub
    Private Sub cboVRafieraDoorType_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboVRafieraDoorType.ButtonClick
        Select Case e.Button.Index
            Case 1 : cboVRafieraDoorType.EditValue = Nothing : ManageDoorType(cboVRafieraDoorType)
            Case 2 : If cboVRafieraDoorType.EditValue <> Nothing Then ManageDoorType(cboVRafieraDoorType)
            Case 3 : cboVRafieraDoorType.EditValue = Nothing
        End Select
    End Sub
    Private Sub cboYRafieraDoorType_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboYRafieraDoorType.ButtonClick
        Select Case e.Button.Index
            Case 1 : cboYRafieraDoorType.EditValue = Nothing : ManageDoorType(cboYRafieraDoorType)
            Case 2 : If cboYRafieraDoorType.EditValue <> Nothing Then ManageDoorType(cboYRafieraDoorType)
            Case 3 : cboYRafieraDoorType.EditValue = Nothing
        End Select
    End Sub
    Private Sub cboKRafieraDoorType_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboKRafieraDoorType.ButtonClick
        Select Case e.Button.Index
            Case 1 : cboKRafieraDoorType.EditValue = Nothing : ManageDoorType(cboKRafieraDoorType)
            Case 2 : If cboKRafieraDoorType.EditValue <> Nothing Then ManageDoorType(cboYRafieraDoorType)
            Case 3 : cboKRafieraDoorType.EditValue = Nothing
        End Select
    End Sub
    Private Sub cboBenchType_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboBenchType.ButtonClick
        Select Case e.Button.Index
            Case 1 : cboBenchType.EditValue = Nothing : ManageBENCH(cboBenchType)
            Case 2 : If cboBenchType.EditValue <> Nothing Then ManageBENCH(cboBenchType)
            Case 3 : cboBenchType.EditValue = Nothing
        End Select
    End Sub
    Private Sub cboBenchType2_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboBenchType2.ButtonClick
        Select Case e.Button.Index
            Case 1 : cboBenchType2.EditValue = Nothing : ManageBENCH(cboBenchType2)
            Case 2 : If cboBenchType2.EditValue <> Nothing Then ManageBENCH(cboBenchType2)
            Case 3 : cboBenchType2.EditValue = Nothing
        End Select
    End Sub
    Private Sub cboBack_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboBack.ButtonClick
        Select Case e.Button.Index
            Case 1 : cboBack.EditValue = Nothing : ManageBENCH(cboBack)
            Case 2 : If cboBack.EditValue <> Nothing Then ManageBENCH(cboBack)
            Case 3 : cboBack.EditValue = Nothing
        End Select
    End Sub
    Private Sub cboKWallRafiaDoorType_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboKWallRafiaDoorType.ButtonClick
        Select Case e.Button.Index
            Case 1 : cboKWallRafiaDoorType.EditValue = Nothing : ManageDoorType(cboKWallRafiaDoorType)
            Case 2 : If cboKWallRafiaDoorType.EditValue <> Nothing Then ManageDoorType(cboKWallRafiaDoorType)
            Case 3 : cboKWallRafiaDoorType.EditValue = Nothing
        End Select
    End Sub
    Private Sub cboPependisisDoorType_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboPependisisDoorType.ButtonClick
        Select Case e.Button.Index
            Case 1 : cboPependisisDoorType.EditValue = Nothing : ManageDoorType(cboPependisisDoorType)
            Case 2 : If cboPependisisDoorType.EditValue <> Nothing Then ManageDoorType(cboPependisisDoorType)
            Case 3 : cboPependisisDoorType.EditValue = Nothing
        End Select
    End Sub
    Private Sub ManageDoorType(ByVal CallerControl As LookUpEdit)
        Dim frmDoorType As frmDoorType = New frmDoorType
        frmDoorType.Text = "Κατηγορία Πόρτας"
        frmDoorType.CallerControl = CallerControl
        frmDoorType.CalledFromControl = True
        If CallerControl.EditValue <> Nothing Then frmDoorType.ID = CallerControl.EditValue.ToString
        frmDoorType.MdiParent = frmMain
        If CallerControl.EditValue <> Nothing Then frmDoorType.Mode = FormMode.EditRecord Else frmDoorType.Mode = FormMode.NewRecord
        frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(frmDoorType), New Point(CInt(frmDoorType.Parent.ClientRectangle.Width / 2 - frmDoorType.Width / 2), CInt(frmDoorType.Parent.ClientRectangle.Height / 2 - frmDoorType.Height / 2)))
        frmDoorType.Show()
    End Sub
    Private Sub ManageBENCH(ByVal CallerControl As LookUpEdit)
        Dim frmBench As frmBench = New frmBench
        frmBench.CallerForm = Me.Name
        frmBench.CallerControl = CallerControl
        frmBench.CalledFromControl = True
        frmBench.MdiParent = frmMain
        If CallerControl.EditValue <> Nothing Then
            frmBench.ID = CallerControl.EditValue.ToString
            frmBench.Mode = FormMode.EditRecord
        Else
            frmBench.Mode = FormMode.NewRecord
        End If
        frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(frmBench), New Point(CInt(frmBench.Parent.ClientRectangle.Width / 2 - frmBench.Width / 2), CInt(frmBench.Parent.ClientRectangle.Height / 2 - frmBench.Height / 2)))
        frmBench.Show()
    End Sub
    Private Sub cbovType_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboVType.ButtonClick
        Select Case e.Button.Index
            Case 1 : cboVType.EditValue = Nothing : cboVBOXColors.EditValue = Nothing
        End Select
    End Sub
    Private Sub cboKType_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboKType.ButtonClick
        Select Case e.Button.Index
            Case 1 : cboKType.EditValue = Nothing : cboKBOXColors.EditValue = Nothing
        End Select
    End Sub
    Private Sub cboyType_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboYType.ButtonClick
        Select Case e.Button.Index
            Case 1 : cboYType.EditValue = Nothing : cboYBOXColors.EditValue = Nothing
        End Select
    End Sub

    Private Sub cboYType_EditValueChanged(sender As Object, e As EventArgs) Handles cboYType.EditValueChanged
        LoadDoorType(cboYType, cboYBOXColors, cboYDoorType) : LoadDoorType(cboYType, cboYBOXColors, cboYDoorType1)
    End Sub
    Private Sub cboKType_EditValueChanged(sender As Object, e As EventArgs) Handles cboKType.EditValueChanged
        LoadDoorType(cboKType, cboKBOXColors, cboKDoorType) : LoadDoorType(cboKType, cboKBOXColors, cboKDoorType1)
    End Sub
    Private Sub cboVType_EditValueChanged(sender As Object, e As EventArgs) Handles cboVType.EditValueChanged
        LoadDoorType(cboVType, cboVBOXColors, cboVDoorType) : LoadDoorType(cboVType, cboVBOXColors, cboVDoorType1)
    End Sub
    Private Sub cboVBOXColors_EditValueChanged(sender As Object, e As EventArgs) Handles cboVBOXColors.EditValueChanged
        LoadDoorType(cboVType, cboVBOXColors, cboVDoorType) : LoadDoorType(cboVType, cboVBOXColors, cboVDoorType1)
        LoadDoorType(cboVType, cboVBOXColors, cboVependisisDoorType) : LoadDoorType(cboVType, cboVBOXColors, cboNependisisDoorType)
    End Sub
    Private Sub cboKBOXColors_EditValueChanged(sender As Object, e As EventArgs) Handles cboKBOXColors.EditValueChanged
        LoadDoorType(cboKType, cboKBOXColors, cboKDoorType) : LoadDoorType(cboKType, cboKBOXColors, cboKDoorType1)
        LoadDoorType(cboKType, cboKBOXColors, cboKependisisDoorType) : LoadDoorType(cboKType, cboKBOXColors, cboSndEpendisisDoorType)
    End Sub
    Private Sub cboYBOXColors_EditValueChanged(sender As Object, e As EventArgs) Handles cboYBOXColors.EditValueChanged
        LoadDoorType(cboYType, cboYBOXColors, cboYDoorType) : LoadDoorType(cboYType, cboYBOXColors, cboYDoorType1)
    End Sub

    Private Sub LoadDoorType(ByVal cboEdit As ComboBoxEdit, ByVal lkupEditColor As LookUpEdit, ByVal lkupEditDoorType As LookUpEdit)
        If Me.IsActive = False Then Exit Sub
        If cboEdit.SelectedIndex = -1 Or lkupEditColor.EditValue = Nothing Then Exit Sub
        Me.Vw_DOOR_TYPE1TableAdapter.FillByTypeAndDoorColor(Me.DMDataSet.vw_DOOR_TYPE1, cboEdit.SelectedIndex, System.Guid.Parse(lkupEditColor.EditValue.ToString))
        'Dim sSQL = New System.Text.StringBuilder
        'sSQL.AppendLine("Select id,name,price from vw_DOOR_TYPE where type = " & cboEdit.SelectedIndex & " and doorColorID = " & toSQLValueS(lkupEditColor.EditValue.ToString))
        'FillCbo.DOOR_TYPE(lkupEditDoorType, sSQL)
        'lkupEditDoorType.Enabled = True
    End Sub

End Class