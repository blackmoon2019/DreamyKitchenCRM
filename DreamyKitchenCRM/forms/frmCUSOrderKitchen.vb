Imports System.ComponentModel
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
    Private ManageCbo As New CombosManager
    Private DBQ As New DBQueries
    Private LoadForms As New FormLoader
    Private Cls As New ClearControls
    Private CtrlCombo As DevExpress.XtraEditors.LookUpEdit
    Private CalledFromCtrl As Boolean
    Private WorkingTime As Integer
    Private AgreementSalary As Double
    Private UserPermissions As New CheckPermissions
    Private Prog_Prop As New ProgProp
    Private vType As Integer
    Private vTypeDescr As String
    Private kType As Integer
    Private kTypeDescr As String

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
        'TODO: This line of code loads data into the 'DreamyKitchenDataSet.vw_DOOR_CATK' table. You can move, or remove it, as needed.
        Me.Vw_DOOR_CATKTableAdapter.Fill(Me.DreamyKitchenDataSet.vw_DOOR_CATK)
        'TODO: This line of code loads data into the 'DMDataSet.CCT_ORDERS_KITCHEN_K' table. You can move, or remove it, as needed.
        Me.CCT_ORDERS_KITCHEN_KTableAdapter.Fill(Me.DMDataSet.CCT_ORDERS_KITCHEN_K)
        'TODO: This line of code loads data into the 'DreamyKitchenDataSet.vw_BASE_CAT' table. You can move, or remove it, as needed.
        Me.Vw_BASE_CATTableAdapter.Fill(Me.DreamyKitchenDataSet.vw_BASE_CAT)
        Me.Vw_COLORSBOXTableAdapter.Fill(Me.DreamyKitchenDataSet.vw_COLORSBOX)
        Me.Vw_COLORSGOLATableAdapter.Fill(Me.DreamyKitchenDataSet.vw_COLORSGOLA)
        'TODO: This line of code loads data into the 'DreamyKitchenDataSet.vw_DOOR_TYPE' table. You can move, or remove it, as needed.
        Me.Vw_DOOR_TYPETableAdapter2.Fill(Me.DreamyKitchenDataSet.vw_DOOR_TYPE)
        'TODO: This line of code loads data into the 'DreamyKitchenDataSet.vw_DOOR_CATV' table. You can move, or remove it, as needed.
        Me.Vw_DOOR_CATVTableAdapter.Fill(Me.DreamyKitchenDataSet.vw_DOOR_CATV)
        'TODO: This line of code loads data into the 'DMDataSet.vw_DOOR_TYPEPlainaKremasta2hsSeiras' table. You can move, or remove it, as needed.
        Me.Vw_DOOR_TYPEPlainaKremasta2hsSeirasTableAdapter.FillBYPlainaKremasta2hsSeiras(Me.DMDataSet.vw_DOOR_TYPEPlainaKremasta2hsSeiras)
        'TODO: This line of code loads data into the 'DMDataSet.vw_DOOR_TYPERafiaWall' table. You can move, or remove it, as needed.
        Me.Vw_DOOR_TYPERafiaWallTableAdapter.FillByRafiaWall(Me.DMDataSet.vw_DOOR_TYPERafiaWall)
        'TODO: This line of code loads data into the 'DMDataSet.vw_DOOR_TYPERafieresY' table. You can move, or remove it, as needed.
        Me.Vw_DOOR_TYPERafieresYTableAdapter.FillByRafieresY(Me.DMDataSet.vw_DOOR_TYPERafieresY)
        'TODO: This line of code loads data into the 'DMDataSet.vw_DOOR_TYPERafieresK' table. You can move, or remove it, as needed.
        Me.Vw_DOOR_TYPERafieresKTableAdapter.FillByRafieresK(Me.DMDataSet.vw_DOOR_TYPERafieresK)
        'TODO: This line of code loads data into the 'DMDataSet.vw_DOOR_TYPEPlainaKremasta' table. You can move, or remove it, as needed.
        Me.Vw_DOOR_TYPEPlainaKremastaTableAdapter.FillByPlainaKremasta(Me.DMDataSet.vw_DOOR_TYPEPlainaKremasta)
        'TODO: This line of code loads data into the 'DreamyKitchenDataSet.vw_BENCH' table. You can move, or remove it, as needed.
        Me.Vw_BENCHTableAdapter.Fill(Me.DreamyKitchenDataSet.vw_BENCH)
        'TODO: This line of code loads data into the 'DMDataSet.vw_DOOR_TYPEPlainaYpsila' table. You can move, or remove it, as needed.
        Me.Vw_DOOR_TYPEPlainaYpsilaTableAdapter.FillBYPlainaYpsila(Me.DMDataSet.vw_DOOR_TYPEPlainaYpsila)
        'TODO: This line of code loads data into the 'DreamyKitchenDataSet.vw_CCT' table. You can move, or remove it, as needed.
        Me.Vw_CCTTableAdapter.Fill(Me.DreamyKitchenDataSet.vw_CCT)
        'TODO: This line of code loads data into the 'DreamyKitchenDataSet.vw_SALERS' table. You can move, or remove it, as needed.
        Me.Vw_SALERSTableAdapter.Fill(Me.DreamyKitchenDataSet.vw_SALERS)
        'TODO: This line of code loads data into the 'DreamyKitchenDataSet.vw_DEVICES' table. You can move, or remove it, as needed.
        'Me.Vw_DEVICESTableAdapter.Fill(Me.DreamyKitchenDataSet.vw_DEVICES)
        'TODO: This line of code loads data into the 'DreamyKitchenDataSet.vw_EQUIPMENT' table. You can move, or remove it, as needed.
        'Me.Vw_EQUIPMENTTableAdapter.Fill(Me.DreamyKitchenDataSet.vw_EQUIPMENT)
        Prog_Prop.GetProgPROSF()
        AddHandler GridControl1.EmbeddedNavigator.ButtonClick, AddressOf Grid_EmbeddedNavigatorV_ButtonClick
        AddHandler GridControl2.EmbeddedNavigator.ButtonClick, AddressOf Grid_EmbeddedNavigatorK_ButtonClick

        Select Case Mode
            Case FormMode.NewRecord
                sID = System.Guid.NewGuid.ToString
                Me.CCT_ORDERS_KITCHEN_VTableAdapter.FillBycctOrdersKitchenID(Me.DMDataSet.CCT_ORDERS_KITCHEN_V, System.Guid.Parse(sID))
                Me.CCT_ORDERS_KITCHEN_KTableAdapter.FillBycctOrdersKitchenID(Me.DMDataSet.CCT_ORDERS_KITCHEN_K, System.Guid.Parse(sID))

                txtCode.Text = DBQ.GetNextId("CCT_ORDERS_KITCHEN")
                cboEMP.EditValue = System.Guid.Parse(UserProps.ID.ToString.ToUpper)
                txtdtdaysOfDelivery.EditValue = ProgProps.DAYS_OF_DELIVERY
                txtTransp.EditValue = ProgProps.KitchenTransp
                txtMeasurement.EditValue = ProgProps.KitchenMeasurement
                txtRemove.EditValue = ProgProps.KitchenRemove

                LoadForms.LoadDataToGrid(grdEquipment, GridView2,
                    "Select  e.ID,E.code,name,price,cast(case when (SELECT FLdVAL FROM PRM_DET WHERE TBL='EQUIPMENT' AND fld='ID' AND fldVal=e.id) is null then 0 else 1 end as bit) as  checked,
                     case when (SELECT FLdVAL FROM PRM_DET WHERE TBL='EQUIPMENT' AND fld='ID' AND fldVal=e.id) is null then 0 else 1 end AS QTY " &
                     "From vw_EQUIPMENT E where equipmentCatID='8AA21DC8-7D98-4596-8B73-9E664E955FFB' ORDER BY NAME")
                TabNavigationPage2.Enabled = False
            Case FormMode.EditRecord
                Me.CCT_ORDERS_KITCHEN_VTableAdapter.FillBycctOrdersKitchenID(Me.DMDataSet.CCT_ORDERS_KITCHEN_V, System.Guid.Parse(sID))
                Me.CCT_ORDERS_KITCHEN_KTableAdapter.FillBycctOrdersKitchenID(Me.DMDataSet.CCT_ORDERS_KITCHEN_K, System.Guid.Parse(sID))
                LoadForms.LoadForm(LayoutControl1, "Select * from CCT_ORDERS_KITCHEN where id = " & toSQLValueS(sID))
                LoadForms.LoadDataToGrid(grdEquipment, GridView2,
                    "select e.ID,e.code,e.name,
                    isnull((select price from CCT_ORDERS_KITCHEN_EQUIPMENT EQ where eq.cctOrdersKitchenID= " & toSQLValueS(sID) & " and eq.equipmentID=e.id),e.price ) as price,
                    e.price as defPrice,
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


        LoadForms.RestoreLayoutFromXml(GridView1, "CCT_ORDERS_KITCHEN_DEVICES_def.xml")
        LoadForms.RestoreLayoutFromXml(GridView2, "CCT_ORDERS_KITCHEN_EQUIPMENT_def.xml")
        LoadForms.RestoreLayoutFromXml(GridView3, "CCT_ORDERS_KITCHEN_V_def.xml")
        GridView2.Columns.Item("name").OptionsColumn.AllowEdit = False : GridView2.Columns.Item("code").OptionsColumn.AllowEdit = False
        GridView1.Columns.Item("name").OptionsColumn.AllowEdit = False : GridView1.Columns.Item("code").OptionsColumn.AllowEdit = False
        GridView2.Columns.Item("price").OptionsColumn.AllowEdit = False
        GridView1.OptionsMenu.ShowConditionalFormattingItem = True
        Me.CenterToScreen()
        cmdSave.Enabled = IIf(Mode = FormMode.NewRecord, UserProps.AllowInsert, UserProps.AllowEdit)
    End Sub
    Private Sub Grid_EmbeddedNavigatorV_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.NavigatorButtonClickEventArgs)
        If UserProps.AllowDelete = True Then If e.Button.ButtonType = NavigatorButtonType.Remove Then DeleteRecordV()
        If UserProps.AllowEdit = True Then If e.Button.ButtonType = NavigatorButtonType.EndEdit Then UpdateRecordV()
    End Sub
    Private Sub Grid_EmbeddedNavigatorK_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.NavigatorButtonClickEventArgs)
        If UserProps.AllowDelete = True Then If e.Button.ButtonType = NavigatorButtonType.Remove Then DeleteRecordK()
        If UserProps.AllowEdit = True Then If e.Button.ButtonType = NavigatorButtonType.EndEdit Then UpdateRecordK()
    End Sub

    Private Sub InsertRecordV()
        Dim sSQL As String = "INSERT INTO CCT_ORDERS_KITCHEN_V(cctOrdersKitchenID,doorCatID,constrType,GolaColorID,BoxColorID,DoorTypeID,Shelves,trm,Price,FinalPrice) " &
                    " VALUES ( " & toSQLValueS(sID) &
                               "," & toSQLValueS(GridView3.GetRowCellValue(GridView3.FocusedRowHandle, "doorCatID").ToString()) &
                               "," & toSQLValueS(vTypeDescr) &
                               "," & toSQLValueS(GridView3.GetRowCellValue(GridView3.FocusedRowHandle, "GolaColorID").ToString()) &
                               "," & toSQLValueS(GridView3.GetRowCellValue(GridView3.FocusedRowHandle, "BoxColorID").ToString()) &
                               "," & toSQLValueS(GridView3.GetRowCellValue(GridView3.FocusedRowHandle, "DoorTypeID").ToString()) &
                               "," & toSQLValueS(GridView3.GetRowCellValue(GridView3.FocusedRowHandle, "Shelves").ToString()) &
                               "," & toSQLValueS(GridView3.GetRowCellValue(GridView3.FocusedRowHandle, "trm").ToString(), True) &
                               "," & toSQLValueS(GridView3.GetRowCellValue(GridView3.FocusedRowHandle, "Price").ToString(), True) &
                               "," & toSQLValueS(GridView3.GetRowCellValue(GridView3.FocusedRowHandle, "FinalPrice").ToString(), True) & ")"
        Using oCmd As New SqlCommand(sSQL, CNDB)
            oCmd.ExecuteNonQuery()
        End Using
    End Sub
    Private Sub DeleteRecordV()
        If XtraMessageBox.Show("Θέλετε να διαγραφεί η τρέχουσα εγγραφή?", "Dreamy Kitchen CRM", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            Dim sSQL As String = "DELETE FROM CCT_ORDERS_KITCHEN_V WHERE ID = " & toSQLValueS(GridView3.GetRowCellValue(GridView3.FocusedRowHandle, "ID").ToString)
            Using oCmd As New SqlCommand(sSQL, CNDB)
                oCmd.ExecuteNonQuery()
            End Using
        End If
    End Sub
    Private Sub UpdateRecordV()
        Dim sSQL As String = "UPDATE [CCT_ORDERS_KITCHEN_V] SET constrType  = " & toSQLValueS(vTypeDescr) &
                ",doorCatID = " & toSQLValueS(GridView3.GetRowCellValue(GridView3.FocusedRowHandle, "doorCatID").ToString()) &
                ",GolaColorID = " & toSQLValueS(GridView3.GetRowCellValue(GridView3.FocusedRowHandle, "GolaColorID").ToString()) &
                ",BoxColorID = " & toSQLValueS(GridView3.GetRowCellValue(GridView3.FocusedRowHandle, "BoxColorID").ToString()) &
                ",DoorTypeID = " & toSQLValueS(GridView3.GetRowCellValue(GridView3.FocusedRowHandle, "DoorTypeID").ToString()) &
                ",Shelves = " & toSQLValueS(GridView3.GetRowCellValue(GridView3.FocusedRowHandle, "Shelves").ToString()) &
                ",trm = " & toSQLValueS(GridView3.GetRowCellValue(GridView3.FocusedRowHandle, "trm").ToString(), True) &
                ",Price = " & toSQLValueS(GridView3.GetRowCellValue(GridView3.FocusedRowHandle, "Price").ToString(), True) &
                ",FinalPrice = " & toSQLValueS(GridView3.GetRowCellValue(GridView3.FocusedRowHandle, "FinalPrice").ToString(), True) &
        " WHERE ID = " & toSQLValueS(GridView3.GetRowCellValue(GridView3.FocusedRowHandle, "ID").ToString)
        Using oCmd As New SqlCommand(sSQL, CNDB)
            oCmd.ExecuteNonQuery()
        End Using

    End Sub
    Private Sub InsertRecordK()
        Dim sSQL As String = "INSERT INTO CCT_ORDERS_KITCHEN_K(cctOrdersKitchenID,doorCatID,constrType,Height,BoxColorID,DoorTypeID,Shelves,trm,Price,FinalPrice) " &
                    " VALUES ( " & toSQLValueS(sID) &
                               "," & toSQLValueS(GridView4.GetRowCellValue(GridView4.FocusedRowHandle, "doorCatID").ToString()) &
                               "," & toSQLValueS(vTypeDescr) &
                               "," & toSQLValueS(GridView4.GetRowCellValue(GridView4.FocusedRowHandle, "Height").ToString(), True) &
                               "," & toSQLValueS(GridView4.GetRowCellValue(GridView4.FocusedRowHandle, "BoxColorID").ToString()) &
                               "," & toSQLValueS(GridView4.GetRowCellValue(GridView4.FocusedRowHandle, "DoorTypeID").ToString()) &
                               "," & toSQLValueS(GridView4.GetRowCellValue(GridView4.FocusedRowHandle, "Shelves").ToString()) &
                               "," & toSQLValueS(GridView4.GetRowCellValue(GridView4.FocusedRowHandle, "trm").ToString(), True) &
                               "," & toSQLValueS(GridView4.GetRowCellValue(GridView4.FocusedRowHandle, "Price").ToString(), True) &
                               "," & toSQLValueS(GridView4.GetRowCellValue(GridView4.FocusedRowHandle, "FinalPrice").ToString(), True) & ")"
        Using oCmd As New SqlCommand(sSQL, CNDB)
            oCmd.ExecuteNonQuery()
        End Using
    End Sub
    Private Sub DeleteRecordK()
        If XtraMessageBox.Show("Θέλετε να διαγραφεί η τρέχουσα εγγραφή?", "Dreamy Kitchen CRM", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            Dim sSQL As String = "DELETE FROM CCT_ORDERS_KITCHEN_K WHERE ID = " & toSQLValueS(GridView4.GetRowCellValue(GridView4.FocusedRowHandle, "ID").ToString)
            Using oCmd As New SqlCommand(sSQL, CNDB)
                oCmd.ExecuteNonQuery()
            End Using
        End If
    End Sub
    Private Sub UpdateRecordK()
        Dim sSQL As String = "UPDATE [CCT_ORDERS_KITCHEN_K] SET constrType  = " & toSQLValueS(vTypeDescr) &
                ",doorCatID = " & toSQLValueS(GridView4.GetRowCellValue(GridView4.FocusedRowHandle, "doorCatID").ToString()) &
                ",Height = " & toSQLValueS(GridView4.GetRowCellValue(GridView4.FocusedRowHandle, "Height").ToString(), True) &
                ",BoxColorID = " & toSQLValueS(GridView4.GetRowCellValue(GridView4.FocusedRowHandle, "BoxColorID").ToString()) &
                ",DoorTypeID = " & toSQLValueS(GridView4.GetRowCellValue(GridView4.FocusedRowHandle, "DoorTypeID").ToString()) &
                ",Shelves = " & toSQLValueS(GridView4.GetRowCellValue(GridView4.FocusedRowHandle, "Shelves").ToString()) &
                ",trm = " & toSQLValueS(GridView4.GetRowCellValue(GridView4.FocusedRowHandle, "trm").ToString(), True) &
                ",Price = " & toSQLValueS(GridView4.GetRowCellValue(GridView4.FocusedRowHandle, "Price").ToString(), True) &
                ",FinalPrice = " & toSQLValueS(GridView4.GetRowCellValue(GridView4.FocusedRowHandle, "FinalPrice").ToString(), True) &
        " WHERE ID = " & toSQLValueS(GridView4.GetRowCellValue(GridView4.FocusedRowHandle, "ID").ToString)
        Using oCmd As New SqlCommand(sSQL, CNDB)
            oCmd.ExecuteNonQuery()
        End Using

    End Sub

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
    Private Sub cboTRANSH_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboTRANSH.ButtonClick
        Select Case e.Button.Index
            Case 1 : ManageCbo.ManageTRANSH(cboTRANSH, FormMode.NewRecord)
            Case 2 : ManageCbo.ManageTRANSH(cboTRANSH, FormMode.EditRecord)
            Case 3 : cboTRANSH.EditValue = Nothing
        End Select
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
            Case 1 : ManageCbo.ManageCus(cboCUS, FormMode.NewRecord)
            Case 2 : ManageCbo.ManageCus(cboCUS, FormMode.EditRecord)
            Case 3 : cboCUS.EditValue = Nothing
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
                        'sGuid = System.Guid.NewGuid.ToString
                        sResult = DBQ.InsertNewData(DBQueries.InsertMode.OneLayoutControl, "CCT_ORDERS_KITCHEN", LayoutControl1,,, sID, True, "dtDeliver", toSQLValueS(CDate(lblDate.Text).ToString("yyyyMMdd")))
                        'sID = sGuid
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
                        '    InsertSelectedRows(True)
                        If System.IO.File.Exists(Application.StartupPath & "\DSGNS\DEF\CCT_ORDERS_KITCHEN_EQUIPMENT_def.xml") = True Then
                            GridView2.RestoreLayoutFromXml(Application.StartupPath & "\DSGNS\DEF\CCT_ORDERS_KITCHEN_EQUIPMENT_def.xml", OptionsLayoutBase.FullLayout)
                        End If
                        If System.IO.File.Exists(Application.StartupPath & "\DSGNS\DEF\CCT_ORDERS_KITCHEN_DEVICES_def.xml") = True Then
                            GridView1.RestoreLayoutFromXml(Application.StartupPath & "\DSGNS\DEF\CCT_ORDERS_KITCHEN_DEVICES_def.xml", OptionsLayoutBase.FullLayout)
                        End If
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
        txtPhn.EditValue = cboCUS.GetColumnValue("phn")
        txtArea.EditValue = cboCUS.GetColumnValue("AREAS_Name")
        txtADR.EditValue = cboCUS.GetColumnValue("ADR_Name")
        Dim sCusID As String
        If cboCUS.EditValue Is Nothing Then sCusID = toSQLValueS(Guid.Empty.ToString) Else sCusID = toSQLValueS(cboCUS.EditValue.ToString)
        Dim sSQL As New System.Text.StringBuilder
        sSQL.AppendLine("Select T.id,FullTranshDescription,Description,Iskitchen,Iscloset,Isdoors,Issc
                        from vw_TRANSH t
                        where  completed = 0 and T.cusid = " & sCusID & "order by description")
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

    Private Sub cboYHeight_SelectedIndexChanged(sender As Object, e As EventArgs)
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
        If e.MenuType = GridMenuType.Column Then LoadForms.PopupMenuShow(e, GridView1, "CCT_ORDERS_KITCHEN_DEVICES_def.xml", "vw_CCT_ORDERS_KITCHEN_DEVICES")
    End Sub
    Private Sub GridView2_PopupMenuShowing(sender As Object, e As PopupMenuShowingEventArgs) Handles GridView2.PopupMenuShowing
        If e.MenuType = GridMenuType.Column Then LoadForms.PopupMenuShow(e, GridView2, "CCT_ORDERS_KITCHEN_EQUIPMENT_def.xml", "vw_CCT_ORDERS_KITCHEN_EQUIPMENT")
    End Sub
    Private Sub GridView3_PopupMenuShowing(sender As Object, e As PopupMenuShowingEventArgs) Handles GridView3.PopupMenuShowing
        If e.MenuType = GridMenuType.Column Then LoadForms.PopupMenuShow(e, GridView3, "CCT_ORDERS_KITCHEN_V_def.xml", "CCT_ORDERS_KITCHEN_V")
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

    Private Sub cboYDoorType_ButtonClick(sender As Object, e As ButtonPressedEventArgs)
        Select Case e.Button.Index
            Case 1 : cboYDoorType.EditValue = Nothing : ManageCbo.ManageDoorType(cboYDoorType)
            Case 2 : If cboYDoorType.EditValue <> Nothing Then ManageCbo.ManageDoorType(cboYDoorType)
            Case 3 : cboYDoorType.EditValue = Nothing
        End Select
    End Sub

    Private Sub cboYDoorType1_ButtonClick(sender As Object, e As ButtonPressedEventArgs)
        Select Case e.Button.Index
            Case 1 : cboYDoorType1.EditValue = Nothing : ManageCbo.ManageDoorType(cboYDoorType1)
            Case 2 : If cboYDoorType1.EditValue <> Nothing Then ManageCbo.ManageDoorType(cboYDoorType1)
            Case 3 : cboYDoorType1.EditValue = Nothing
        End Select
    End Sub

    Private Sub cboYRafieraDoorType_ButtonClick(sender As Object, e As ButtonPressedEventArgs)
        Select Case e.Button.Index
            Case 1 : cboYRafieraDoorType.EditValue = Nothing : ManageCbo.ManageDoorType(cboYRafieraDoorType)
            Case 2 : If cboYRafieraDoorType.EditValue <> Nothing Then ManageCbo.ManageDoorType(cboYRafieraDoorType)
            Case 3 : cboYRafieraDoorType.EditValue = Nothing
        End Select
    End Sub
    Private Sub cboBenchType_ButtonClick(sender As Object, e As ButtonPressedEventArgs)
        Select Case e.Button.Index
            Case 1 : cboBenchType.EditValue = Nothing : ManageCbo.ManageBENCH(cboBenchType)
            Case 2 : If cboBenchType.EditValue <> Nothing Then ManageCbo.ManageBENCH(cboBenchType)
            Case 3 : cboBenchType.EditValue = Nothing
        End Select
    End Sub
    Private Sub cboBenchType2_ButtonClick(sender As Object, e As ButtonPressedEventArgs)
        Select Case e.Button.Index
            Case 1 : cboBenchType2.EditValue = Nothing : ManageCbo.ManageBENCH(cboBenchType2)
            Case 2 : If cboBenchType2.EditValue <> Nothing Then ManageCbo.ManageBENCH(cboBenchType2)
            Case 3 : cboBenchType2.EditValue = Nothing
        End Select
    End Sub
    Private Sub cboBack_ButtonClick(sender As Object, e As ButtonPressedEventArgs)
        Select Case e.Button.Index
            Case 1 : cboBack.EditValue = Nothing : ManageCbo.ManageBENCH(cboBack)
            Case 2 : If cboBack.EditValue <> Nothing Then ManageCbo.ManageBENCH(cboBack)
            Case 3 : cboBack.EditValue = Nothing
        End Select
    End Sub
    Private Sub cboPependisisDoorType_ButtonClick(sender As Object, e As ButtonPressedEventArgs)
        Select Case e.Button.Index
            Case 1 : cboPependisisDoorType.EditValue = Nothing : ManageCbo.ManageDoorType(cboPependisisDoorType)
            Case 2 : If cboPependisisDoorType.EditValue <> Nothing Then ManageCbo.ManageDoorType(cboPependisisDoorType)
            Case 3 : cboPependisisDoorType.EditValue = Nothing
        End Select
    End Sub

    Private Sub cboyType_ButtonClick(sender As Object, e As ButtonPressedEventArgs)
        Select Case e.Button.Index
            Case 1 : cboYType.EditValue = Nothing : cboYBOXColors.EditValue = Nothing
        End Select
    End Sub

    Private Sub cboYType_EditValueChanged(sender As Object, e As EventArgs)
        LoadDoorType(cboYType, cboYBOXColors, cboYDoorType) : LoadDoorType(cboYType, cboYBOXColors, cboYDoorType1)
    End Sub
    Private Sub cboYBOXColors_EditValueChanged(sender As Object, e As EventArgs)
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

    Private Sub cboBaza_ButtonClick(sender As Object, e As ButtonPressedEventArgs)
        Select Case e.Button.Index
            Case 1 : cboBaza.EditValue = Nothing
        End Select
    End Sub

    Private Sub cboLegs_ButtonClick(sender As Object, e As ButtonPressedEventArgs)
        Select Case e.Button.Index
            Case 1 : cboLegs.EditValue = Nothing
        End Select
    End Sub

    Private Sub cboVwater_ButtonClick(sender As Object, e As ButtonPressedEventArgs)
        Select Case e.Button.Index
            Case 1 : cboVwater.EditValue = Nothing
        End Select
    End Sub
    Private Sub cboYwater_ButtonClick(sender As Object, e As ButtonPressedEventArgs)
        Select Case e.Button.Index
            Case 1 : cboYwater.EditValue = Nothing
        End Select
    End Sub
    Private Sub cboKwater_ButtonClick(sender As Object, e As ButtonPressedEventArgs)
        Select Case e.Button.Index
            Case 1 : cboKwater.EditValue = Nothing
        End Select
    End Sub

    Private Sub cboLedProfil_ButtonClick(sender As Object, e As ButtonPressedEventArgs)
        Select Case e.Button.Index
            Case 1 : cboLedProfil.EditValue = Nothing
        End Select
    End Sub

    Private Sub cbobenchThickness_ButtonClick(sender As Object, e As ButtonPressedEventArgs)
        Select Case e.Button.Index
            Case 1 : cbobenchThickness.EditValue = Nothing
        End Select
    End Sub

    Private Sub GridView2_CellValueChanged(sender As Object, e As CellValueChangedEventArgs) Handles GridView2.CellValueChanged
        If e.Column.FieldName <> "QTY" Then Exit Sub
        Dim sTot As Decimal = GridView2.GetRowCellValue(GridView2.FocusedRowHandle, "QTY") * GridView2.GetRowCellValue(GridView2.FocusedRowHandle, "price")
        GridView2.SetRowCellValue(GridView2.FocusedRowHandle, "price", sTot)
    End Sub

    '**************************** NEW GRID**********************************
    '************Β Α Σ Ε Ω Σ***********************
    Private Sub GridView3_InitNewRow(sender As Object, e As InitNewRowEventArgs) Handles GridView3.InitNewRow
        GridView3.SetRowCellValue(GridView3.FocusedRowHandle, "ID", sID)
        GridView3.SetRowCellValue(GridView3.FocusedRowHandle, "cctOrdersKitchenID", sID)
    End Sub

    Private Sub GridView3_ShowingEditor(sender As Object, e As CancelEventArgs) Handles GridView3.ShowingEditor
        'Dim view As ColumnView = DirectCast(sender, ColumnView)
        'If view.FocusedColumn.FieldName = "GolaColorID" And vType = 0 Then e.Cancel = True
        'If view.FocusedColumn.FieldName = "BoxColorID" And vType = 1 Then e.Cancel = True
    End Sub

    Private Sub RepDoorTYPEV_PopupFilter(sender As Object, e As PopupFilterEventArgs) Handles RepDoorTYPEV.PopupFilter
        Dim colorID As String
        If cbobaseCatErm.EditValue Is Nothing Then
            e.Criteria = DevExpress.Data.Filtering.CriteriaOperator.Parse(" doorCatID == " & toSQLValueS(System.Guid.Parse(Guid.Empty.ToString).ToString))
            Exit Sub
        End If
        If GridView3.GetRowCellValue(GridView3.FocusedRowHandle, "doorCatID") Is Nothing Then
            e.Criteria = DevExpress.Data.Filtering.CriteriaOperator.Parse(" doorCatID == " & toSQLValueS(System.Guid.Parse(Guid.Empty.ToString).ToString))
            Exit Sub
        End If
        Dim DoorCatID As String = GridView3.GetRowCellValue(GridView3.FocusedRowHandle, "doorCatID").ToString()
        If DoorCatID = "" Then
            e.Criteria = DevExpress.Data.Filtering.CriteriaOperator.Parse(" doorCatID == " & toSQLValueS(System.Guid.Parse(Guid.Empty.ToString).ToString))
            Exit Sub
        End If
        If DoorCatID.ToUpper = "53582708-BB28-4714-99AC-736AEF1D3086" Then
            If vType = 0 Then colorID = GridView3.GetRowCellValue(GridView3.FocusedRowHandle, "BoxColorID").ToString() Else colorID = GridView3.GetRowCellValue(GridView3.FocusedRowHandle, "GolaColorID").ToString()
            If colorID.Length > 0 Then e.Criteria = DevExpress.Data.Filtering.CriteriaOperator.Parse(" baseCatErmID == " & toSQLValueS(System.Guid.Parse(cbobaseCatErm.EditValue.ToString).ToString) &
                                                                                                     " And doorCatID == " & toSQLValueS(System.Guid.Parse(DoorCatID).ToString) &
                                                                                                     " And type == " & vType & " And  doorColorID == " & toSQLValueS(System.Guid.Parse(colorID).ToString))
        Else
            e.Criteria = DevExpress.Data.Filtering.CriteriaOperator.Parse("baseCatID == " & toSQLValueS(System.Guid.Parse(cbobaseCatErm.EditValue.ToString).ToString) & " And  doorCatID == " & toSQLValueS(System.Guid.Parse(DoorCatID).ToString))
        End If
    End Sub

    Private Sub RepConstrTypeV_SelectedIndexChanged(sender As Object, e As EventArgs) Handles RepConstrTypeV.SelectedIndexChanged
        vType = DirectCast(sender, DevExpress.XtraEditors.ComboBoxEdit).SelectedIndex
        vTypeDescr = DirectCast(sender, DevExpress.XtraEditors.ComboBoxEdit).EditValue
    End Sub

    Private Sub RepDoorTYPEV_EditValueChanged(sender As Object, e As EventArgs) Handles RepDoorTYPEV.EditValueChanged
        Dim editor As DevExpress.XtraEditors.LookUpEdit = TryCast(sender, DevExpress.XtraEditors.LookUpEdit)
        GridView3.SetRowCellValue(GridView3.FocusedRowHandle, "Price", editor.GetColumnValue("Price"))
    End Sub

    Private Sub GridView3_CellValueChanged(sender As Object, e As CellValueChangedEventArgs) Handles GridView3.CellValueChanged
    End Sub

    Private Sub GridView3_CellValueChanging(sender As Object, e As CellValueChangedEventArgs) Handles GridView3.CellValueChanging
        Select Case e.Column.FieldName
            Case "doorCatID"
                If e.Value Is Nothing Then Exit Sub
                Dim DoorCatID As String = e.Value.ToString
                Select Case DoorCatID.ToUpper
                    'ΕΡΜΑΡΙΑ
                    Case "53582708-BB28-4714-99AC-736AEF1D3086"
                        GridView3.SetRowCellValue(GridView3.FocusedRowHandle, "Shelves", "")
                    'ΡΑΦΙΕΡΕΣ ΒΑΣΕΩΣ
                    Case "E1D9DBA9-E4FF-45B6-AA26-46ADCED92EE9"
                        GridView3.SetRowCellValue(GridView3.FocusedRowHandle, "constrType", "")
                        GridView3.SetRowCellValue(GridView3.FocusedRowHandle, "GolaColorID", Nothing)
                        GridView3.SetRowCellValue(GridView3.FocusedRowHandle, "BoxColorID", Nothing)
                    Case Else
                        GridView3.SetRowCellValue(GridView3.FocusedRowHandle, "Shelves", "")
                        GridView3.SetRowCellValue(GridView3.FocusedRowHandle, "constrType", "")
                        GridView3.SetRowCellValue(GridView3.FocusedRowHandle, "GolaColorID", Nothing)
                        GridView3.SetRowCellValue(GridView3.FocusedRowHandle, "BoxColorID", Nothing)
                End Select
                GridView3.SetRowCellValue(GridView3.FocusedRowHandle, "DoorTypeID", Nothing)
                GridView3.SetRowCellValue(GridView3.FocusedRowHandle, "Price", "0")
                GridView3.SetRowCellValue(GridView3.FocusedRowHandle, "FinalPrice", "0")
            Case "trm"
                Dim Price As Double = GridView3.GetRowCellValue(GridView3.FocusedRowHandle, "Price")
                Dim trm As Double = e.Value
                Dim FinalPrice As Double = trm * Price
                GridView3.SetRowCellValue(GridView3.FocusedRowHandle, "FinalPrice", FinalPrice)
        End Select

        If e.Column.FieldName <> "trm" Then Exit Sub
    End Sub

    Private Sub GridView3_RowUpdated(sender As Object, e As RowObjectEventArgs) Handles GridView3.RowUpdated
        If GridView3.IsNewItemRow(e.RowHandle) Then InsertRecordV() Else UpdateRecordV()
    End Sub

    Private Sub GridView3_KeyDown(sender As Object, e As KeyEventArgs) Handles GridView3.KeyDown
        Select Case e.KeyCode
            Case Keys.Delete : If UserProps.AllowDelete = True Then DeleteRecordV()
        End Select

    End Sub

    Private Sub RepDoorTYPEV_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles RepDoorTYPEV.ButtonClick
        Dim editor As DevExpress.XtraEditors.LookUpEdit = TryCast(sender, DevExpress.XtraEditors.LookUpEdit)
        Select Case e.Button.Index
            Case 1 : If editor.EditValue <> Nothing Then ManageCbo.ManageDoorType(editor)
            Case 2 : editor.EditValue = Nothing
        End Select
    End Sub


    Private Sub RepDoorCATV_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles RepDoorCATV.ButtonClick
        Dim editor As DevExpress.XtraEditors.LookUpEdit = TryCast(sender, DevExpress.XtraEditors.LookUpEdit)
        Select Case e.Button.Index
            Case 1 : If editor.EditValue <> Nothing Then ManageCbo.ManageDoorCAT(editor)
            Case 2 : editor.EditValue = Nothing
        End Select
    End Sub

    Private Sub RepConstrTypeV_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles RepConstrTypeV.ButtonClick
        Dim editor As DevExpress.XtraEditors.ComboBoxEdit = TryCast(sender, DevExpress.XtraEditors.ComboBoxEdit)
        Select Case e.Button.Index
            Case 1 : editor.EditValue = Nothing
        End Select
    End Sub

    Private Sub RepColorBOXV_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles RepColorBOXV.ButtonClick
        Dim editor As DevExpress.XtraEditors.LookUpEdit = TryCast(sender, DevExpress.XtraEditors.LookUpEdit)
        Select Case e.Button.Index
            Case 1 : If editor.EditValue <> Nothing Then ManageCbo.ManageColors(editor)
            Case 2 : editor.EditValue = Nothing
        End Select

    End Sub

    Private Sub RepColorGola_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles RepColorGola.ButtonClick
        Dim editor As DevExpress.XtraEditors.LookUpEdit = TryCast(sender, DevExpress.XtraEditors.LookUpEdit)
        Select Case e.Button.Index
            Case 1 : If editor.EditValue <> Nothing Then ManageCbo.ManageColors(editor)
            Case 2 : editor.EditValue = Nothing
        End Select

    End Sub
    Private Sub cboBaseCat_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cbobaseCatErm.ButtonClick
        Select Case e.Button.Index
            Case 1 : ManageCbo.ManageDoorBaseCat(cbobaseCatErm)
            Case 2 : ManageCbo.ManageDoorBaseCat(cbobaseCatErm)
            Case 3 : cbobaseCatErm.EditValue = Nothing
        End Select
    End Sub
    Private Sub RepColorBOXV_PopupFilter(sender As Object, e As PopupFilterEventArgs) Handles RepColorBOXV.PopupFilter
        If vType = 1 Then e.Criteria = DevExpress.Data.Filtering.CriteriaOperator.Parse(" BoxColorID == " & toSQLValueS(System.Guid.Parse(Guid.Empty.ToString).ToString))
    End Sub

    Private Sub RepColorGola_PopupFilter(sender As Object, e As PopupFilterEventArgs) Handles RepColorGola.PopupFilter
        If vType = 0 Then e.Criteria = DevExpress.Data.Filtering.CriteriaOperator.Parse(" GolaColorID == " & toSQLValueS(System.Guid.Parse(Guid.Empty.ToString).ToString))
    End Sub

    Private Sub GridView3_ValidateRow(sender As Object, e As ValidateRowEventArgs) Handles GridView3.ValidateRow
        Dim View As GridView = CType(sender, GridView)
        If GridView3.GetRowCellValue(GridView3.FocusedRowHandle, "DoorTypeID").ToString() = "" Then
            Dim DoorTypeID As GridColumn = View.Columns("DoorTypeID")
            e.Valid = False
            View.SetColumnError(DoorTypeID, "Δεν έχετε επιλέξει Υλικό")
        End If
        If GridView3.GetRowCellValue(GridView3.FocusedRowHandle, "trm").ToString() = "" Then
            Dim trmCOL As GridColumn = View.Columns("trm")
            e.Valid = False
            View.SetColumnError(trmCOL, "Δεν έχετε πληκτρολογήσει ΤΡ.Μ.")
        End If
        If e.Valid Then View.ClearColumnErrors()

    End Sub

    Private Sub GridView3_InvalidRowException(sender As Object, e As InvalidRowExceptionEventArgs) Handles GridView3.InvalidRowException
        e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction
    End Sub


    '************Κ Ρ Ε Μ Α Σ Τ Α***********************
    Private Sub GridView4_InitNewRow(sender As Object, e As InitNewRowEventArgs) Handles GridView4.InitNewRow
        GridView4.SetRowCellValue(GridView4.FocusedRowHandle, "ID", sID)
        GridView4.SetRowCellValue(GridView4.FocusedRowHandle, "cctOrdersKitchenID", sID)
    End Sub

    Private Sub GridView4_ShowingEditor(sender As Object, e As CancelEventArgs) Handles GridView4.ShowingEditor
        'Dim view As ColumnView = DirectCast(sender, ColumnView)
        'If view.FocusedColumn.FieldName = "GolaColorID" And vType = 0 Then e.Cancel = True
        'If view.FocusedColumn.FieldName = "BoxColorID" And vType = 1 Then e.Cancel = True
    End Sub

    Private Sub RepDoorTYPEK_PopupFilter(sender As Object, e As PopupFilterEventArgs) Handles RepDoorTYPEK.PopupFilter
        Dim colorID As String
        If cbobaseCatErm.EditValue Is Nothing Then
            e.Criteria = DevExpress.Data.Filtering.CriteriaOperator.Parse(" doorCatID == " & toSQLValueS(System.Guid.Parse(Guid.Empty.ToString).ToString))
            Exit Sub
        End If
        If GridView4.GetRowCellValue(GridView4.FocusedRowHandle, "doorCatID") Is Nothing Then
            e.Criteria = DevExpress.Data.Filtering.CriteriaOperator.Parse(" doorCatID == " & toSQLValueS(System.Guid.Parse(Guid.Empty.ToString).ToString))
            Exit Sub
        End If
        Dim DoorCatID As String = GridView4.GetRowCellValue(GridView4.FocusedRowHandle, "doorCatID").ToString()
        If DoorCatID = "" Then
            e.Criteria = DevExpress.Data.Filtering.CriteriaOperator.Parse(" doorCatID == " & toSQLValueS(System.Guid.Parse(Guid.Empty.ToString).ToString))
            Exit Sub
        End If
        If DoorCatID.ToUpper = "53582708-BB28-4714-99AC-736AEF1D3086" Then
            If vType = 0 Then colorID = GridView4.GetRowCellValue(GridView4.FocusedRowHandle, "BoxColorID").ToString() Else colorID = GridView4.GetRowCellValue(GridView4.FocusedRowHandle, "GolaColorID").ToString()
            If colorID.Length > 0 Then e.Criteria = DevExpress.Data.Filtering.CriteriaOperator.Parse(" baseCatErmID == " & toSQLValueS(System.Guid.Parse(cbobaseCatErm.EditValue.ToString).ToString) &
                                                                                                     " And doorCatID == " & toSQLValueS(System.Guid.Parse(DoorCatID).ToString) &
                                                                                                     " And type == " & vType & " And  doorColorID == " & toSQLValueS(System.Guid.Parse(colorID).ToString))
        Else
            e.Criteria = DevExpress.Data.Filtering.CriteriaOperator.Parse("baseCatID == " & toSQLValueS(System.Guid.Parse(cbobaseCatErm.EditValue.ToString).ToString) & " And  doorCatID == " & toSQLValueS(System.Guid.Parse(DoorCatID).ToString))
        End If
    End Sub

    Private Sub RepConstrTypeK_SelectedIndexChanged(sender As Object, e As EventArgs) Handles RepConstrTypeK.SelectedIndexChanged
        kType = DirectCast(sender, DevExpress.XtraEditors.ComboBoxEdit).SelectedIndex
        kTypeDescr = DirectCast(sender, DevExpress.XtraEditors.ComboBoxEdit).EditValue
    End Sub

    Private Sub RepDoorTYPEK_EditValueChanged(sender As Object, e As EventArgs) Handles RepDoorTYPEK.EditValueChanged
        Dim editor As DevExpress.XtraEditors.LookUpEdit = TryCast(sender, DevExpress.XtraEditors.LookUpEdit)
        GridView4.SetRowCellValue(GridView4.FocusedRowHandle, "Price", editor.GetColumnValue("Price"))
    End Sub

    Private Sub GridView4_CellValueChanging(sender As Object, e As CellValueChangedEventArgs) Handles GridView4.CellValueChanging
        Select Case e.Column.FieldName
            Case "doorCatID"
                If e.Value Is Nothing Then Exit Sub
                Dim DoorCatID As String = e.Value.ToString
                Select Case DoorCatID.ToUpper
                    'ΕΡΜΑΡΙΑ
                    Case "53582708-BB28-4714-99AC-736AEF1D3086"
                        GridView4.SetRowCellValue(GridView4.FocusedRowHandle, "Shelves", "")
                    'ΡΑΦΙΕΡΕΣ ΒΑΣΕΩΣ
                    Case "E1D9DBA9-E4FF-45B6-AA26-46ADCED92EE9"
                        GridView4.SetRowCellValue(GridView4.FocusedRowHandle, "constrType", "")
                        GridView4.SetRowCellValue(GridView4.FocusedRowHandle, "GolaColorID", Nothing)
                        GridView4.SetRowCellValue(GridView4.FocusedRowHandle, "BoxColorID", Nothing)
                    Case Else
                        GridView4.SetRowCellValue(GridView4.FocusedRowHandle, "Shelves", "")
                        GridView4.SetRowCellValue(GridView4.FocusedRowHandle, "constrType", "")
                        GridView4.SetRowCellValue(GridView4.FocusedRowHandle, "GolaColorID", Nothing)
                        GridView4.SetRowCellValue(GridView4.FocusedRowHandle, "BoxColorID", Nothing)
                End Select
                GridView4.SetRowCellValue(GridView4.FocusedRowHandle, "DoorTypeID", Nothing)
                GridView4.SetRowCellValue(GridView4.FocusedRowHandle, "Price", "0")
                GridView4.SetRowCellValue(GridView4.FocusedRowHandle, "FinalPrice", "0")
            Case "trm"
                Dim Price As Double = GridView4.GetRowCellValue(GridView4.FocusedRowHandle, "Price")
                Dim trm As Double = e.Value
                Dim FinalPrice As Double = trm * Price
                GridView4.SetRowCellValue(GridView4.FocusedRowHandle, "FinalPrice", FinalPrice)
        End Select

        If e.Column.FieldName <> "trm" Then Exit Sub
    End Sub

    Private Sub GridView4_RowUpdated(sender As Object, e As RowObjectEventArgs) Handles GridView4.RowUpdated
        If GridView4.IsNewItemRow(e.RowHandle) Then InsertRecordK() Else UpdateRecordK()
    End Sub

    Private Sub GridView4_KeyDown(sender As Object, e As KeyEventArgs) Handles GridView4.KeyDown
        Select Case e.KeyCode
            Case Keys.Delete : If UserProps.AllowDelete = True Then DeleteRecordK()
        End Select

    End Sub

    Private Sub RepDoorTYPEK_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles RepDoorTYPEK.ButtonClick
        Dim editor As DevExpress.XtraEditors.LookUpEdit = TryCast(sender, DevExpress.XtraEditors.LookUpEdit)
        Select Case e.Button.Index
            Case 1 : If editor.EditValue <> Nothing Then ManageCbo.ManageDoorType(editor)
            Case 2 : editor.EditValue = Nothing
        End Select
    End Sub


    Private Sub RepDoorCATK_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles RepDoorCATK.ButtonClick
        Dim editor As DevExpress.XtraEditors.LookUpEdit = TryCast(sender, DevExpress.XtraEditors.LookUpEdit)
        Select Case e.Button.Index
            Case 1 : If editor.EditValue <> Nothing Then ManageCbo.ManageDoorCAT(editor)
            Case 2 : editor.EditValue = Nothing
        End Select
    End Sub

    Private Sub RepConstrTypeK_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles RepConstrTypeK.ButtonClick
        Dim editor As DevExpress.XtraEditors.ComboBoxEdit = TryCast(sender, DevExpress.XtraEditors.ComboBoxEdit)
        Select Case e.Button.Index
            Case 1 : editor.EditValue = Nothing
        End Select
    End Sub

    Private Sub RepColorBOXK_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles RepColorBOXK.ButtonClick
        Dim editor As DevExpress.XtraEditors.LookUpEdit = TryCast(sender, DevExpress.XtraEditors.LookUpEdit)
        Select Case e.Button.Index
            Case 1 : If editor.EditValue <> Nothing Then ManageCbo.ManageColors(editor)
            Case 2 : editor.EditValue = Nothing
        End Select

    End Sub

    'Private Sub RepColorGola_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles RepColorGola.ButtonClick
    '    Dim editor As DevExpress.XtraEditors.LookUpEdit = TryCast(sender, DevExpress.XtraEditors.LookUpEdit)
    '    Select Case e.Button.Index
    '        Case 1 : If editor.EditValue <> Nothing Then ManageCbo.ManageColors(editor)
    '        Case 2 : editor.EditValue = Nothing
    '    End Select

    'End Sub
    Private Sub RepColorBOXK_PopupFilter(sender As Object, e As PopupFilterEventArgs) Handles RepColorBOXK.PopupFilter
        If vType = 1 Then e.Criteria = DevExpress.Data.Filtering.CriteriaOperator.Parse(" BoxColorID == " & toSQLValueS(System.Guid.Parse(Guid.Empty.ToString).ToString))
    End Sub

    'Private Sub RepColorGola_PopupFilter(sender As Object, e As PopupFilterEventArgs) Handles RepColorGola.PopupFilter
    '    If vType = 0 Then e.Criteria = DevExpress.Data.Filtering.CriteriaOperator.Parse(" GolaColorID == " & toSQLValueS(System.Guid.Parse(Guid.Empty.ToString).ToString))
    'End Sub

    Private Sub GridView4_ValidateRow(sender As Object, e As ValidateRowEventArgs) Handles GridView4.ValidateRow
        Dim View As GridView = CType(sender, GridView)
        If GridView4.GetRowCellValue(GridView4.FocusedRowHandle, "DoorTypeID").ToString() = "" Then
            Dim DoorTypeID As GridColumn = View.Columns("DoorTypeID")
            e.Valid = False
            View.SetColumnError(DoorTypeID, "Δεν έχετε επιλέξει Υλικό")
        End If
        If GridView4.GetRowCellValue(GridView4.FocusedRowHandle, "trm").ToString() = "" Then
            Dim trmCOL As GridColumn = View.Columns("trm")
            e.Valid = False
            View.SetColumnError(trmCOL, "Δεν έχετε πληκτρολογήσει ΤΡ.Μ.")
        End If
        If e.Valid Then View.ClearColumnErrors()

    End Sub

    Private Sub GridView4_InvalidRowException(sender As Object, e As InvalidRowExceptionEventArgs) Handles GridView4.InvalidRowException
        e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction
    End Sub



End Class