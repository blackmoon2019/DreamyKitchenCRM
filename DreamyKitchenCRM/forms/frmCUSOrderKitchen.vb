﻿Imports System.ComponentModel
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
    Private sNewGuid As String
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
    Private yType As Integer
    Private yTypeDescr As String

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
        'TODO: This line of code loads data into the 'DreamyKitchenDataSet.BENCH_CAT' table. You can move, or remove it, as needed.
        Me.BENCH_CATTableAdapter.Fill(Me.DreamyKitchenDataSet.BENCH_CAT)
        'TODO: This line of code loads data into the 'DMDataSet.CCT_ORDERS_KITCHEN_B' table. You can move, or remove it, as needed.
        Me.CCT_ORDERS_KITCHEN_BTableAdapter.Fill(Me.DMDataSet.CCT_ORDERS_KITCHEN_B)
        Me.Vw_DOOR_CATYTableAdapter.Fill(Me.DreamyKitchenDataSet.vw_DOOR_CATY)
        Me.CCT_ORDERS_KITCHEN_YTableAdapter.Fill(Me.DMDataSet.CCT_ORDERS_KITCHEN_Y)
        Me.Vw_DOOR_CATKTableAdapter.Fill(Me.DreamyKitchenDataSet.vw_DOOR_CATK)
        Me.CCT_ORDERS_KITCHEN_KTableAdapter.Fill(Me.DMDataSet.CCT_ORDERS_KITCHEN_K)
        Me.Vw_BASE_CATTableAdapter.Fill(Me.DreamyKitchenDataSet.vw_BASE_CAT)
        Me.Vw_COLORSBOXTableAdapter.Fill(Me.DreamyKitchenDataSet.vw_COLORSBOX)
        Me.Vw_COLORSGOLATableAdapter.Fill(Me.DreamyKitchenDataSet.vw_COLORSGOLA)
        Me.Vw_DOOR_TYPETableAdapter2.Fill(Me.DreamyKitchenDataSet.vw_DOOR_TYPE)
        Me.Vw_DOOR_CATVTableAdapter.Fill(Me.DreamyKitchenDataSet.vw_DOOR_CATV)
        Me.Vw_CCTTableAdapter.Fill(Me.DreamyKitchenDataSet.vw_CCT)
        Me.Vw_SALERSTableAdapter.Fill(Me.DreamyKitchenDataSet.vw_SALERS)
        Me.Vw_BENCHTableAdapter.Fill(Me.DreamyKitchenDataSet.vw_BENCH)

        Prog_Prop.GetProgPROSF()
        AddHandler GridControl1.EmbeddedNavigator.ButtonClick, AddressOf Grid_EmbeddedNavigatorV_ButtonClick
        AddHandler GridControl2.EmbeddedNavigator.ButtonClick, AddressOf Grid_EmbeddedNavigatorK_ButtonClick
        AddHandler GridControl3.EmbeddedNavigator.ButtonClick, AddressOf Grid_EmbeddedNavigatorY_ButtonClick
        AddHandler GridControl4.EmbeddedNavigator.ButtonClick, AddressOf Grid_EmbeddedNavigatorB_ButtonClick

        Select Case Mode
            Case FormMode.NewRecord
                sID = System.Guid.NewGuid.ToString
                Me.CCT_ORDERS_KITCHEN_VTableAdapter.FillBycctOrdersKitchenID(Me.DMDataSet.CCT_ORDERS_KITCHEN_V, System.Guid.Parse(sID))
                Me.CCT_ORDERS_KITCHEN_KTableAdapter.FillBycctOrdersKitchenID(Me.DMDataSet.CCT_ORDERS_KITCHEN_K, System.Guid.Parse(sID))
                Me.CCT_ORDERS_KITCHEN_YTableAdapter.FillBycctOrdersKitchenID(Me.DMDataSet.CCT_ORDERS_KITCHEN_Y, System.Guid.Parse(sID))
                Me.CCT_ORDERS_KITCHEN_BTableAdapter.FillBycctOrdersKitchenID(Me.DMDataSet.CCT_ORDERS_KITCHEN_B, System.Guid.Parse(sID))

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
                LayoutControlGroup2.Enabled = False
            Case FormMode.EditRecord
                Me.CCT_ORDERS_KITCHEN_VTableAdapter.FillBycctOrdersKitchenID(Me.DMDataSet.CCT_ORDERS_KITCHEN_V, System.Guid.Parse(sID))
                Me.CCT_ORDERS_KITCHEN_KTableAdapter.FillBycctOrdersKitchenID(Me.DMDataSet.CCT_ORDERS_KITCHEN_K, System.Guid.Parse(sID))
                Me.CCT_ORDERS_KITCHEN_YTableAdapter.FillBycctOrdersKitchenID(Me.DMDataSet.CCT_ORDERS_KITCHEN_Y, System.Guid.Parse(sID))
                Me.CCT_ORDERS_KITCHEN_BTableAdapter.FillBycctOrdersKitchenID(Me.DMDataSet.CCT_ORDERS_KITCHEN_B, System.Guid.Parse(sID))

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
                LayoutControlGroup2.Enabled = True

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
        LoadForms.RestoreLayoutFromXml(GridView4, "CCT_ORDERS_KITCHEN_K_def.xml")
        LoadForms.RestoreLayoutFromXml(GridView5, "CCT_ORDERS_KITCHEN_Y_def.xml")
        LoadForms.RestoreLayoutFromXml(GridView6, "CCT_ORDERS_KITCHEN_B_def.xml")

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
    Private Sub Grid_EmbeddedNavigatorY_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.NavigatorButtonClickEventArgs)
        If UserProps.AllowDelete = True Then If e.Button.ButtonType = NavigatorButtonType.Remove Then DeleteRecordY()
        If UserProps.AllowEdit = True Then If e.Button.ButtonType = NavigatorButtonType.EndEdit Then UpdateRecordY()
    End Sub
    Private Sub Grid_EmbeddedNavigatorB_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.NavigatorButtonClickEventArgs)
        If UserProps.AllowDelete = True Then If e.Button.ButtonType = NavigatorButtonType.Remove Then DeleteRecordB()
        If UserProps.AllowEdit = True Then If e.Button.ButtonType = NavigatorButtonType.EndEdit Then UpdateRecordB()
    End Sub

    Private Sub InsertRecordV()
        Dim sSQL As String = "INSERT INTO CCT_ORDERS_KITCHEN_V(ID,cctOrdersKitchenID,doorCatID,constrType,GolaColorID,BoxColorID,DoorTypeID,Shelves,trm,Price,FinalPrice) " &
                    " VALUES ( " & toSQLValueS(sNewGuid) & "," & toSQLValueS(sID) &
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
        Dim sSQL As String = "INSERT INTO CCT_ORDERS_KITCHEN_K(ID,cctOrdersKitchenID,doorCatID,constrType,Height,Height2ndLine,BoxColorID,DoorTypeID,Shelves,trm,Price,FinalPrice) " &
                    " VALUES ( " & toSQLValueS(sNewGuid) & "," & toSQLValueS(sID) &
                               "," & toSQLValueS(GridView4.GetRowCellValue(GridView4.FocusedRowHandle, "doorCatID").ToString()) &
                               "," & toSQLValueS(vTypeDescr) &
                               "," & toSQLValueS(GridView4.GetRowCellValue(GridView4.FocusedRowHandle, "Height").ToString(), True) &
                               "," & toSQLValueS(GridView4.GetRowCellValue(GridView4.FocusedRowHandle, "Height2ndLine").ToString(), True) &
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
                ",Height2ndLine = " & toSQLValueS(GridView4.GetRowCellValue(GridView4.FocusedRowHandle, "Height2ndLine").ToString(), True) &
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
    Private Sub InsertRecordY()
        Dim sSQL As String = "INSERT INTO CCT_ORDERS_KITCHEN_Y(ID,cctOrdersKitchenID,doorCatID,constrType,GolaColorID,BoxColorID,DoorTypeID,Shelves,Height,trm,Price,FinalPrice) " &
                    " VALUES ( " & toSQLValueS(sNewGuid) & "," & toSQLValueS(sID) &
                               "," & toSQLValueS(GridView5.GetRowCellValue(GridView5.FocusedRowHandle, "doorCatID").ToString()) &
                               "," & toSQLValueS(yTypeDescr) &
                               "," & toSQLValueS(GridView5.GetRowCellValue(GridView5.FocusedRowHandle, "GolaColorID").ToString()) &
                               "," & toSQLValueS(GridView5.GetRowCellValue(GridView5.FocusedRowHandle, "BoxColorID").ToString()) &
                               "," & toSQLValueS(GridView5.GetRowCellValue(GridView5.FocusedRowHandle, "DoorTypeID").ToString()) &
                               "," & toSQLValueS(GridView5.GetRowCellValue(GridView5.FocusedRowHandle, "Shelves").ToString()) &
                               "," & toSQLValueS(GridView5.GetRowCellValue(GridView5.FocusedRowHandle, "Height").ToString(), True) &
                               "," & toSQLValueS(GridView5.GetRowCellValue(GridView5.FocusedRowHandle, "trm").ToString(), True) &
                               "," & toSQLValueS(GridView5.GetRowCellValue(GridView5.FocusedRowHandle, "Price").ToString(), True) &
                               "," & toSQLValueS(GridView5.GetRowCellValue(GridView5.FocusedRowHandle, "FinalPrice").ToString(), True) & ")"
        Using oCmd As New SqlCommand(sSQL, CNDB)
            oCmd.ExecuteNonQuery()
        End Using
    End Sub
    Private Sub DeleteRecordY()
        If XtraMessageBox.Show("Θέλετε να διαγραφεί η τρέχουσα εγγραφή?", "Dreamy Kitchen CRM", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            Dim sSQL As String = "DELETE FROM CCT_ORDERS_KITCHEN_Y WHERE ID = " & toSQLValueS(GridView5.GetRowCellValue(GridView5.FocusedRowHandle, "ID").ToString)
            Using oCmd As New SqlCommand(sSQL, CNDB)
                oCmd.ExecuteNonQuery()
            End Using
        End If
    End Sub
    Private Sub UpdateRecordY()
        Dim sSQL As String = "UPDATE [CCT_ORDERS_KITCHEN_Y] SET constrType  = " & toSQLValueS(yTypeDescr) &
                ",doorCatID = " & toSQLValueS(GridView5.GetRowCellValue(GridView5.FocusedRowHandle, "doorCatID").ToString()) &
                ",GolaColorID = " & toSQLValueS(GridView5.GetRowCellValue(GridView5.FocusedRowHandle, "GolaColorID").ToString()) &
                ",BoxColorID = " & toSQLValueS(GridView5.GetRowCellValue(GridView5.FocusedRowHandle, "BoxColorID").ToString()) &
                ",DoorTypeID = " & toSQLValueS(GridView5.GetRowCellValue(GridView5.FocusedRowHandle, "DoorTypeID").ToString()) &
                ",Shelves = " & toSQLValueS(GridView5.GetRowCellValue(GridView5.FocusedRowHandle, "Shelves").ToString()) &
                ",Height = " & toSQLValueS(GridView5.GetRowCellValue(GridView5.FocusedRowHandle, "Height").ToString(), True) &
                ",trm = " & toSQLValueS(GridView5.GetRowCellValue(GridView5.FocusedRowHandle, "trm").ToString(), True) &
                ",Price = " & toSQLValueS(GridView5.GetRowCellValue(GridView5.FocusedRowHandle, "Price").ToString(), True) &
                ",FinalPrice = " & toSQLValueS(GridView5.GetRowCellValue(GridView5.FocusedRowHandle, "FinalPrice").ToString(), True) &
        " WHERE ID = " & toSQLValueS(GridView5.GetRowCellValue(GridView5.FocusedRowHandle, "ID").ToString)
        Using oCmd As New SqlCommand(sSQL, CNDB)
            oCmd.ExecuteNonQuery()
        End Using

    End Sub
    Private Sub InsertRecordB()
        Dim sSQL As String = "INSERT INTO CCT_ORDERS_KITCHEN_B(ID,cctOrdersKitchenID,benchCatID,benchID,benchCode,Thickness,tem,Price,FinalPrice) " &
                    " VALUES ( " & toSQLValueS(sNewGuid) & "," & toSQLValueS(sID) &
                               "," & toSQLValueS(GridView6.GetRowCellValue(GridView6.FocusedRowHandle, "benchCatID").ToString()) &
                               "," & toSQLValueS(GridView6.GetRowCellValue(GridView6.FocusedRowHandle, "benchID").ToString()) &
                               "," & toSQLValueS(GridView6.GetRowCellValue(GridView6.FocusedRowHandle, "benchCode").ToString()) &
                               "," & toSQLValueS(GridView6.GetRowCellValue(GridView6.FocusedRowHandle, "Thickness").ToString()) &
                               "," & toSQLValueS(GridView6.GetRowCellValue(GridView6.FocusedRowHandle, "tem").ToString(), True) &
                               "," & toSQLValueS(GridView6.GetRowCellValue(GridView6.FocusedRowHandle, "Price").ToString(), True) &
                               "," & toSQLValueS(GridView6.GetRowCellValue(GridView6.FocusedRowHandle, "FinalPrice").ToString(), True) & ")"
        Using oCmd As New SqlCommand(sSQL, CNDB)
            oCmd.ExecuteNonQuery()
        End Using
    End Sub
    Private Sub DeleteRecordB()
        If XtraMessageBox.Show("Θέλετε να διαγραφεί η τρέχουσα εγγραφή?", "Dreamy Kitchen CRM", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            Dim sSQL As String = "DELETE FROM CCT_ORDERS_KITCHEN_B WHERE ID = " & toSQLValueS(GridView6.GetRowCellValue(GridView6.FocusedRowHandle, "ID").ToString)
            Using oCmd As New SqlCommand(sSQL, CNDB)
                oCmd.ExecuteNonQuery()
            End Using
        End If
    End Sub
    Private Sub UpdateRecordB()
        Dim sSQL As String = "UPDATE [CCT_ORDERS_KITCHEN_B] SET " &
                "benchCatID = " & toSQLValueS(GridView6.GetRowCellValue(GridView6.FocusedRowHandle, "benchCatID").ToString()) &
                ",benchID = " & toSQLValueS(GridView6.GetRowCellValue(GridView6.FocusedRowHandle, "benchID").ToString()) &
                ",benchCode = " & toSQLValueS(GridView6.GetRowCellValue(GridView6.FocusedRowHandle, "benchCode").ToString()) &
                ",Thickness = " & toSQLValueS(GridView6.GetRowCellValue(GridView6.FocusedRowHandle, "Thickness").ToString()) &
                ",tem = " & toSQLValueS(GridView6.GetRowCellValue(GridView6.FocusedRowHandle, "tem").ToString(), True) &
                ",Price = " & toSQLValueS(GridView6.GetRowCellValue(GridView6.FocusedRowHandle, "Price").ToString(), True) &
                ",FinalPrice = " & toSQLValueS(GridView6.GetRowCellValue(GridView6.FocusedRowHandle, "FinalPrice").ToString(), True) &
        " WHERE ID = " & toSQLValueS(GridView6.GetRowCellValue(GridView6.FocusedRowHandle, "ID").ToString)
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
                    LayoutControlGroup2.Enabled = True
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

    Private Sub txtTotalErmariaVat_EditValueChanged(sender As Object, e As EventArgs) Handles txtTotalErmariaPriceWVat.EditValueChanged
        Dim TotalErmariaPrice As Double
        TotalErmariaPrice = (txtTotalErmariaPriceWVat.EditValue * (ProgProps.VAT / 100)) + txtTotalErmariaPriceWVat.EditValue
        txtTotalErmariaPrice.EditValue = TotalErmariaPrice
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
        LoadForms.PopupMenuShow(e, GridView1, "CCT_ORDERS_KITCHEN_DEVICES_def.xml", "vw_CCT_ORDERS_KITCHEN_DEVICES")
    End Sub
    Private Sub GridView2_PopupMenuShowing(sender As Object, e As PopupMenuShowingEventArgs) Handles GridView2.PopupMenuShowing
        LoadForms.PopupMenuShow(e, GridView2, "CCT_ORDERS_KITCHEN_EQUIPMENT_def.xml", "vw_CCT_ORDERS_KITCHEN_EQUIPMENT")
    End Sub
    Private Sub GridView3_PopupMenuShowing(sender As Object, e As PopupMenuShowingEventArgs) Handles GridView3.PopupMenuShowing
        LoadForms.PopupMenuShow(e, GridView3, "CCT_ORDERS_KITCHEN_V_def.xml", "CCT_ORDERS_KITCHEN_V")
    End Sub
    Private Sub GridView4_PopupMenuShowing(sender As Object, e As PopupMenuShowingEventArgs) Handles GridView4.PopupMenuShowing
        LoadForms.PopupMenuShow(e, GridView4, "CCT_ORDERS_KITCHEN_K_def.xml", "CCT_ORDERS_KITCHEN_K")
    End Sub
    Private Sub GridView5_PopupMenuShowing(sender As Object, e As PopupMenuShowingEventArgs) Handles GridView5.PopupMenuShowing
        LoadForms.PopupMenuShow(e, GridView5, "CCT_ORDERS_KITCHEN_Y_def.xml", "CCT_ORDERS_KITCHEN_Y")
    End Sub
    Private Sub GridView6_PopupMenuShowing(sender As Object, e As PopupMenuShowingEventArgs) Handles GridView6.PopupMenuShowing
        LoadForms.PopupMenuShow(e, GridView6, "CCT_ORDERS_KITCHEN_B_def.xml", "CCT_ORDERS_KITCHEN_B")
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


    Private Sub GridView2_CellValueChanged(sender As Object, e As CellValueChangedEventArgs) Handles GridView2.CellValueChanged
        If e.Column.FieldName <> "QTY" Then Exit Sub
        Dim sTot As Decimal = GridView2.GetRowCellValue(GridView2.FocusedRowHandle, "QTY") * GridView2.GetRowCellValue(GridView2.FocusedRowHandle, "price")
        GridView2.SetRowCellValue(GridView2.FocusedRowHandle, "price", sTot)
    End Sub

    '**************************** NEW GRID**********************************
    '************Β Α Σ Ε Ω Σ***********************
    Private Sub GridView3_InitNewRow(sender As Object, e As InitNewRowEventArgs) Handles GridView3.InitNewRow
        sNewGuid = Guid.NewGuid.ToString
        GridView3.SetRowCellValue(GridView3.FocusedRowHandle, "ID", sNewGuid)
        GridView3.SetRowCellValue(GridView3.FocusedRowHandle, "cctOrdersKitchenID", sID)
        GridView3.SetRowCellValue(GridView3.FocusedRowHandle, "trm", "0")
        GridView3.SetRowCellValue(GridView3.FocusedRowHandle, "Price", "0")
        GridView3.SetRowCellValue(GridView3.FocusedRowHandle, "FinalPrice", "0")

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
            If colorID.Length > 0 Then
                e.Criteria = DevExpress.Data.Filtering.CriteriaOperator.Parse(" baseCatErmID == " & toSQLValueS(System.Guid.Parse(cbobaseCatErm.EditValue.ToString).ToString) &
                                                                                                     " And doorCatID == " & toSQLValueS(System.Guid.Parse(DoorCatID).ToString) &
                                                                                                     " And type == " & vType & " And  doorColorID == " & toSQLValueS(System.Guid.Parse(colorID).ToString))
            Else
                e.Criteria = DevExpress.Data.Filtering.CriteriaOperator.Parse(" doorCatID == " & toSQLValueS(System.Guid.Parse(Guid.Empty.ToString).ToString))
                Exit Sub

            End If
        Else
            e.Criteria = DevExpress.Data.Filtering.CriteriaOperator.Parse("baseCatErmID == " & toSQLValueS(System.Guid.Parse(cbobaseCatErm.EditValue.ToString).ToString) & " And  doorCatID == " & toSQLValueS(System.Guid.Parse(DoorCatID).ToString))
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
                If e.Value Is Nothing Then
                    If e.Value Is Nothing Then
                        GridView3.SetRowCellValue(GridView3.FocusedRowHandle, "Shelves", "")
                        GridView3.SetRowCellValue(GridView3.FocusedRowHandle, "GolaColorID", Nothing)
                        GridView3.SetRowCellValue(GridView3.FocusedRowHandle, "BoxColorID", Nothing)
                        GridView3.SetRowCellValue(GridView3.FocusedRowHandle, "DoorTypeID", Nothing)
                        GridView3.SetRowCellValue(GridView3.FocusedRowHandle, "Price", "0")
                        GridView3.SetRowCellValue(GridView3.FocusedRowHandle, "trm", "0")
                        GridView3.SetRowCellValue(GridView3.FocusedRowHandle, "FinalPrice", "0")
                        Exit Sub
                    End If
                End If
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
                If e.Value Is Nothing Then Exit Sub
                If GridView3.GetRowCellValue(GridView3.FocusedRowHandle, "Price").ToString = "" Then Exit Sub
                Dim Price As Double = GridView3.GetRowCellValue(GridView3.FocusedRowHandle, "Price")
                Dim trm As Double = e.Value.ToString.Replace(".", ",")
                Dim FinalPrice As Double = trm * Price
                GridView3.SetRowCellValue(GridView3.FocusedRowHandle, "FinalPrice", FinalPrice)
                GridView3.UpdateTotalSummary()
                Dim TotalErmaria As Double = GridView3.Columns("FinalPrice").SummaryItem.SummaryValue +
                                  GridView4.Columns("FinalPrice").SummaryItem.SummaryValue +
                                  GridView5.Columns("FinalPrice").SummaryItem.SummaryValue +
                                  GridView6.Columns("FinalPrice").SummaryItem.SummaryValue
                txtTotalErmariaPriceWVat.EditValue = TotalErmaria

        End Select


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
            Case 1 : If editor.EditValue.ToString <> "" Then ManageCbo.ManageColors(editor)
            Case 2 : editor.EditValue = Nothing
        End Select

    End Sub

    Private Sub RepColorGola_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles RepColorGola.ButtonClick
        Dim editor As DevExpress.XtraEditors.LookUpEdit = TryCast(sender, DevExpress.XtraEditors.LookUpEdit)
        Select Case e.Button.Index
            Case 1 : If editor.EditValue.ToString <> "" Then ManageCbo.ManageColors(editor)
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
        sNewGuid = Guid.NewGuid.ToString
        GridView4.SetRowCellValue(GridView4.FocusedRowHandle, "ID", sNewGuid)
        GridView4.SetRowCellValue(GridView4.FocusedRowHandle, "cctOrdersKitchenID", sID)
        GridView4.SetRowCellValue(GridView4.FocusedRowHandle, "Height", "0")
        GridView4.SetRowCellValue(GridView4.FocusedRowHandle, "Height2ndLine", "0")
        GridView4.SetRowCellValue(GridView4.FocusedRowHandle, "trm", "0")
        GridView4.SetRowCellValue(GridView4.FocusedRowHandle, "Price", "0")
        GridView4.SetRowCellValue(GridView4.FocusedRowHandle, "FinalPrice", "0")
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
            If colorID.Length > 0 Then
                e.Criteria = DevExpress.Data.Filtering.CriteriaOperator.Parse(" baseCatErmID == " & toSQLValueS(System.Guid.Parse(cbobaseCatErm.EditValue.ToString).ToString) &
                                                                                                     " And doorCatID == " & toSQLValueS(System.Guid.Parse(DoorCatID).ToString) &
                                                                                                     " And type == " & kType & " And  doorColorID == " & toSQLValueS(System.Guid.Parse(colorID).ToString))
            Else
                e.Criteria = DevExpress.Data.Filtering.CriteriaOperator.Parse(" doorCatID == " & toSQLValueS(System.Guid.Parse(Guid.Empty.ToString).ToString))
                Exit Sub
            End If

        Else
            e.Criteria = DevExpress.Data.Filtering.CriteriaOperator.Parse("baseCatErmID == " & toSQLValueS(System.Guid.Parse(cbobaseCatErm.EditValue.ToString).ToString) & " And  doorCatID == " & toSQLValueS(System.Guid.Parse(DoorCatID).ToString))
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
                If e.Value Is Nothing Then
                    GridView4.SetRowCellValue(GridView4.FocusedRowHandle, "Shelves", "")
                    GridView4.SetRowCellValue(GridView4.FocusedRowHandle, "Height", "")
                    GridView4.SetRowCellValue(GridView4.FocusedRowHandle, "Height2ndLine", "")
                    GridView4.SetRowCellValue(GridView4.FocusedRowHandle, "BoxColorID", Nothing)
                    GridView4.SetRowCellValue(GridView4.FocusedRowHandle, "DoorTypeID", Nothing)
                    GridView4.SetRowCellValue(GridView4.FocusedRowHandle, "Price", "0")
                    GridView4.SetRowCellValue(GridView4.FocusedRowHandle, "trm", "0")
                    GridView4.SetRowCellValue(GridView4.FocusedRowHandle, "FinalPrice", "0")
                    Exit Sub
                End If
                Dim DoorCatID As String = e.Value.ToString
                Select Case DoorCatID.ToUpper
                    'ΕΡΜΑΡΙΑ
                    Case "53582708-BB28-4714-99AC-736AEF1D3086"
                        GridView4.SetRowCellValue(GridView4.FocusedRowHandle, "Shelves", "")
                    Case Else
                        GridView4.SetRowCellValue(GridView4.FocusedRowHandle, "Shelves", "")
                        GridView4.SetRowCellValue(GridView4.FocusedRowHandle, "BoxColorID", Nothing)
                End Select
                GridView4.SetRowCellValue(GridView4.FocusedRowHandle, "DoorTypeID", Nothing)
                GridView4.SetRowCellValue(GridView4.FocusedRowHandle, "Price", "0")
                GridView4.SetRowCellValue(GridView4.FocusedRowHandle, "FinalPrice", "0")
            Case "trm"
                If e.Value Is Nothing Then Exit Sub
                If GridView4.GetRowCellValue(GridView4.FocusedRowHandle, "Price").ToString = "" Then Exit Sub
                Dim Price As Double = GridView4.GetRowCellValue(GridView4.FocusedRowHandle, "Price")
                Dim trm As Double = e.Value.ToString.Replace(".", ",")
                Dim FinalPrice As Double = trm * Price
                GridView4.SetRowCellValue(GridView4.FocusedRowHandle, "FinalPrice", FinalPrice)
                GridView4.UpdateTotalSummary()
                Dim TotalErmaria As Double = GridView3.Columns("FinalPrice").SummaryItem.SummaryValue +
                                  GridView4.Columns("FinalPrice").SummaryItem.SummaryValue +
                                  GridView5.Columns("FinalPrice").SummaryItem.SummaryValue +
                                  GridView6.Columns("FinalPrice").SummaryItem.SummaryValue
                txtTotalErmariaPriceWVat.EditValue = TotalErmaria
        End Select


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
            Case 1 : If editor.EditValue.ToString <> "" Then ManageCbo.ManageColors(editor)
            Case 2 : editor.EditValue = Nothing
        End Select

    End Sub

    Private Sub RepColorBOXK_PopupFilter(sender As Object, e As PopupFilterEventArgs) Handles RepColorBOXK.PopupFilter
        If kType = 1 Then e.Criteria = DevExpress.Data.Filtering.CriteriaOperator.Parse(" BoxColorID == " & toSQLValueS(System.Guid.Parse(Guid.Empty.ToString).ToString))
    End Sub


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

    '************Υ Ψ Η Λ Α***********************
    Private Sub GridView5_InitNewRow(sender As Object, e As InitNewRowEventArgs) Handles GridView5.InitNewRow
        sNewGuid = Guid.NewGuid.ToString
        GridView5.SetRowCellValue(GridView5.FocusedRowHandle, "ID", sNewGuid)
        GridView5.SetRowCellValue(GridView5.FocusedRowHandle, "cctOrdersKitchenID", sID)
        GridView5.SetRowCellValue(GridView5.FocusedRowHandle, "Height", "0")
        GridView5.SetRowCellValue(GridView5.FocusedRowHandle, "trm", "0")
        GridView5.SetRowCellValue(GridView5.FocusedRowHandle, "Price", "0")
        GridView5.SetRowCellValue(GridView5.FocusedRowHandle, "FinalPrice", "0")

    End Sub

    Private Sub GridView5_ShowingEditor(sender As Object, e As CancelEventArgs) Handles GridView5.ShowingEditor
        'Dim view As ColumnView = DirectCast(sender, ColumnView)
        'If view.FocusedColumn.FieldName = "GolaColorID" And vType = 0 Then e.Cancel = True
        'If view.FocusedColumn.FieldName = "BoxColorID" And vType = 1 Then e.Cancel = True
    End Sub

    Private Sub RepDoorTYPEY_PopupFilter(sender As Object, e As PopupFilterEventArgs) Handles RepDoorTYPEY.PopupFilter
        Dim colorID As String
        If cbobaseCatErm.EditValue Is Nothing Then
            e.Criteria = DevExpress.Data.Filtering.CriteriaOperator.Parse(" doorCatID == " & toSQLValueS(System.Guid.Parse(Guid.Empty.ToString).ToString))
            Exit Sub
        End If
        If GridView5.GetRowCellValue(GridView5.FocusedRowHandle, "doorCatID") Is Nothing Then
            e.Criteria = DevExpress.Data.Filtering.CriteriaOperator.Parse(" doorCatID == " & toSQLValueS(System.Guid.Parse(Guid.Empty.ToString).ToString))
            Exit Sub
        End If
        Dim DoorCatID As String = GridView5.GetRowCellValue(GridView5.FocusedRowHandle, "doorCatID").ToString()
        If DoorCatID = "" Then
            e.Criteria = DevExpress.Data.Filtering.CriteriaOperator.Parse(" doorCatID == " & toSQLValueS(System.Guid.Parse(Guid.Empty.ToString).ToString))
            Exit Sub
        End If
        If DoorCatID.ToUpper = "53582708-BB28-4714-99AC-736AEF1D3086" Then
            If vType = 0 Then colorID = GridView5.GetRowCellValue(GridView5.FocusedRowHandle, "BoxColorID").ToString() Else colorID = GridView5.GetRowCellValue(GridView5.FocusedRowHandle, "GolaColorID").ToString()
            If colorID.Length > 0 Then
                e.Criteria = DevExpress.Data.Filtering.CriteriaOperator.Parse(" baseCatErmID == " & toSQLValueS(System.Guid.Parse(cbobaseCatErm.EditValue.ToString).ToString) &
                                                                                                     " And doorCatID == " & toSQLValueS(System.Guid.Parse(DoorCatID).ToString) &
                                                                                                     " And type == " & yType & " And  doorColorID == " & toSQLValueS(System.Guid.Parse(colorID).ToString))
            Else
                e.Criteria = DevExpress.Data.Filtering.CriteriaOperator.Parse(" doorCatID == " & toSQLValueS(System.Guid.Parse(Guid.Empty.ToString).ToString))
                Exit Sub

            End If
        Else
            e.Criteria = DevExpress.Data.Filtering.CriteriaOperator.Parse("baseCatErmID == " & toSQLValueS(System.Guid.Parse(cbobaseCatErm.EditValue.ToString).ToString) & " And  doorCatID == " & toSQLValueS(System.Guid.Parse(DoorCatID).ToString))
        End If
    End Sub

    Private Sub RepConstrTypeY_SelectedIndexChanged(sender As Object, e As EventArgs) Handles RepConstrTypeY.SelectedIndexChanged
        yType = DirectCast(sender, DevExpress.XtraEditors.ComboBoxEdit).SelectedIndex
        yTypeDescr = DirectCast(sender, DevExpress.XtraEditors.ComboBoxEdit).EditValue
    End Sub

    Private Sub RepDoorTYPEY_EditValueChanged(sender As Object, e As EventArgs) Handles RepDoorTYPEY.EditValueChanged
        Dim editor As DevExpress.XtraEditors.LookUpEdit = TryCast(sender, DevExpress.XtraEditors.LookUpEdit)
        GridView5.SetRowCellValue(GridView5.FocusedRowHandle, "Price", editor.GetColumnValue("Price"))
    End Sub

    Private Sub GridView5_CellValueChanged(sender As Object, e As CellValueChangedEventArgs) Handles GridView5.CellValueChanged
    End Sub

    Private Sub GridView5_CellValueChanging(sender As Object, e As CellValueChangedEventArgs) Handles GridView5.CellValueChanging
        Select Case e.Column.FieldName
            Case "doorCatID"
                If e.Value Is Nothing Then
                    If e.Value Is Nothing Then
                        GridView5.SetRowCellValue(GridView5.FocusedRowHandle, "Shelves", "")
                        GridView5.SetRowCellValue(GridView5.FocusedRowHandle, "GolaColorID", Nothing)
                        GridView5.SetRowCellValue(GridView5.FocusedRowHandle, "BoxColorID", Nothing)
                        GridView5.SetRowCellValue(GridView5.FocusedRowHandle, "DoorTypeID", Nothing)
                        GridView5.SetRowCellValue(GridView5.FocusedRowHandle, "Height", "0")
                        GridView5.SetRowCellValue(GridView5.FocusedRowHandle, "Price", "0")
                        GridView5.SetRowCellValue(GridView5.FocusedRowHandle, "trm", "0")
                        GridView5.SetRowCellValue(GridView5.FocusedRowHandle, "FinalPrice", "0")
                        Exit Sub
                    End If
                End If
                Dim DoorCatID As String = e.Value.ToString
                Select Case DoorCatID.ToUpper
                    'ΕΡΜΑΡΙΑ
                    Case "53582708-BB28-4714-99AC-736AEF1D3086"
                        GridView5.SetRowCellValue(GridView5.FocusedRowHandle, "Shelves", "")
                    'ΡΑΦΙΕΡΕΣ ΒΑΣΕΩΣ
                    Case "E1D9DBA9-E4FF-45B6-AA26-46ADCED92EE9"
                        GridView5.SetRowCellValue(GridView5.FocusedRowHandle, "constrType", "")
                        GridView5.SetRowCellValue(GridView5.FocusedRowHandle, "GolaColorID", Nothing)
                        GridView5.SetRowCellValue(GridView5.FocusedRowHandle, "BoxColorID", Nothing)
                    Case Else
                        GridView5.SetRowCellValue(GridView5.FocusedRowHandle, "Shelves", "")
                        GridView5.SetRowCellValue(GridView5.FocusedRowHandle, "constrType", "")
                        GridView5.SetRowCellValue(GridView5.FocusedRowHandle, "GolaColorID", Nothing)
                        GridView5.SetRowCellValue(GridView5.FocusedRowHandle, "BoxColorID", Nothing)
                End Select
                GridView5.SetRowCellValue(GridView5.FocusedRowHandle, "DoorTypeID", Nothing)
                GridView5.SetRowCellValue(GridView5.FocusedRowHandle, "Price", "0")
                GridView5.SetRowCellValue(GridView5.FocusedRowHandle, "FinalPrice", "0")
            Case "trm"
                If e.Value Is Nothing Then Exit Sub
                If GridView5.GetRowCellValue(GridView5.FocusedRowHandle, "Price").ToString = "" Then Exit Sub
                Dim Price As Double = GridView5.GetRowCellValue(GridView5.FocusedRowHandle, "Price")
                Dim trm As Double = e.Value.ToString.Replace(".", ",")
                Dim FinalPrice As Double = trm * Price
                GridView5.SetRowCellValue(GridView5.FocusedRowHandle, "FinalPrice", FinalPrice)
                GridView5.UpdateTotalSummary()
                Dim TotalErmaria As Double = GridView3.Columns("FinalPrice").SummaryItem.SummaryValue +
                                  GridView4.Columns("FinalPrice").SummaryItem.SummaryValue +
                                  GridView5.Columns("FinalPrice").SummaryItem.SummaryValue +
                                  GridView6.Columns("FinalPrice").SummaryItem.SummaryValue
                txtTotalErmariaPriceWVat.EditValue = TotalErmaria
        End Select


    End Sub

    Private Sub GridView5_RowUpdated(sender As Object, e As RowObjectEventArgs) Handles GridView5.RowUpdated
        If GridView5.IsNewItemRow(e.RowHandle) Then InsertRecordY() Else UpdateRecordY()
    End Sub

    Private Sub GridView5_KeyDown(sender As Object, e As KeyEventArgs) Handles GridView5.KeyDown
        Select Case e.KeyCode
            Case Keys.Delete : If UserProps.AllowDelete = True Then DeleteRecordY()
        End Select

    End Sub

    Private Sub RepDoorTYPEY_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles RepDoorTYPEY.ButtonClick
        Dim editor As DevExpress.XtraEditors.LookUpEdit = TryCast(sender, DevExpress.XtraEditors.LookUpEdit)
        Select Case e.Button.Index
            Case 1 : If editor.EditValue <> Nothing Then ManageCbo.ManageDoorType(editor)
            Case 2 : editor.EditValue = Nothing
        End Select
    End Sub


    Private Sub RepDoorCATY_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles RepDoorCATY.ButtonClick
        Dim editor As DevExpress.XtraEditors.LookUpEdit = TryCast(sender, DevExpress.XtraEditors.LookUpEdit)
        Select Case e.Button.Index
            Case 1 : If editor.EditValue <> Nothing Then ManageCbo.ManageDoorCAT(editor)
            Case 2 : editor.EditValue = Nothing
        End Select
    End Sub

    Private Sub RepConstrTypeY_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles RepConstrTypeY.ButtonClick
        Dim editor As DevExpress.XtraEditors.ComboBoxEdit = TryCast(sender, DevExpress.XtraEditors.ComboBoxEdit)
        Select Case e.Button.Index
            Case 1 : editor.EditValue = Nothing
        End Select
    End Sub

    Private Sub RepColorBOXY_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles RepColorBOXY.ButtonClick
        Dim editor As DevExpress.XtraEditors.LookUpEdit = TryCast(sender, DevExpress.XtraEditors.LookUpEdit)
        Select Case e.Button.Index
            Case 1 : If editor.EditValue.ToString <> "" Then ManageCbo.ManageColors(editor)
            Case 2 : editor.EditValue = Nothing
        End Select

    End Sub

    Private Sub RepColorGolaY_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles RepColorGolaY.ButtonClick
        Dim editor As DevExpress.XtraEditors.LookUpEdit = TryCast(sender, DevExpress.XtraEditors.LookUpEdit)
        Select Case e.Button.Index
            Case 1 : If editor.EditValue.ToString <> "" Then ManageCbo.ManageColors(editor)
            Case 2 : editor.EditValue = Nothing
        End Select

    End Sub
    Private Sub RepColorBOXY_PopupFilter(sender As Object, e As PopupFilterEventArgs) Handles RepColorBOXY.PopupFilter
        If yType = 1 Then e.Criteria = DevExpress.Data.Filtering.CriteriaOperator.Parse(" BoxColorID == " & toSQLValueS(System.Guid.Parse(Guid.Empty.ToString).ToString))
    End Sub

    Private Sub RepColorGolaY_PopupFilter(sender As Object, e As PopupFilterEventArgs) Handles RepColorGolaY.PopupFilter
        If yType = 0 Then e.Criteria = DevExpress.Data.Filtering.CriteriaOperator.Parse(" GolaColorID == " & toSQLValueS(System.Guid.Parse(Guid.Empty.ToString).ToString))
    End Sub

    Private Sub GridView5_ValidateRow(sender As Object, e As ValidateRowEventArgs) Handles GridView5.ValidateRow
        Dim View As GridView = CType(sender, GridView)
        If GridView5.GetRowCellValue(GridView5.FocusedRowHandle, "DoorTypeID").ToString() = "" Then
            Dim DoorTypeID As GridColumn = View.Columns("DoorTypeID")
            e.Valid = False
            View.SetColumnError(DoorTypeID, "Δεν έχετε επιλέξει Υλικό")
        End If
        If GridView5.GetRowCellValue(GridView5.FocusedRowHandle, "trm").ToString() = "" Then
            Dim trmCOL As GridColumn = View.Columns("trm")
            e.Valid = False
            View.SetColumnError(trmCOL, "Δεν έχετε πληκτρολογήσει ΤΡ.Μ.")
        End If
        If e.Valid Then View.ClearColumnErrors()

    End Sub

    Private Sub GridView5_InvalidRowException(sender As Object, e As InvalidRowExceptionEventArgs) Handles GridView5.InvalidRowException
        e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction
    End Sub


    '************Π Α Γ Κ Ο Ι***********************
    Private Sub GridView6_InitNewRow(sender As Object, e As InitNewRowEventArgs) Handles GridView6.InitNewRow
        sNewGuid = Guid.NewGuid.ToString
        GridView6.SetRowCellValue(GridView6.FocusedRowHandle, "ID", sNewGuid)
        GridView6.SetRowCellValue(GridView6.FocusedRowHandle, "cctOrdersKitchenID", sID)
        GridView6.SetRowCellValue(GridView6.FocusedRowHandle, "tem", "0")
        GridView6.SetRowCellValue(GridView6.FocusedRowHandle, "Price", "0")
        GridView6.SetRowCellValue(GridView6.FocusedRowHandle, "FinalPrice", "0")

    End Sub

    Private Sub GridView6_ShowingEditor(sender As Object, e As CancelEventArgs) Handles GridView6.ShowingEditor
        'Dim view As ColumnView = DirectCast(sender, ColumnView)
        'If view.FocusedColumn.FieldName = "GolaColorID" And vType = 0 Then e.Cancel = True
        'If view.FocusedColumn.FieldName = "BoxColorID" And vType = 1 Then e.Cancel = True
    End Sub


    Private Sub RepBench_PopupFilter(sender As Object, e As PopupFilterEventArgs) Handles RepBench.PopupFilter

        If GridView6.GetRowCellValue(GridView6.FocusedRowHandle, "benchCatID") Is Nothing Then
            e.Criteria = DevExpress.Data.Filtering.CriteriaOperator.Parse(" benchID == " & toSQLValueS(System.Guid.Parse(Guid.Empty.ToString).ToString))
            Exit Sub
        End If
        Dim benchCatID As String = GridView6.GetRowCellValue(GridView6.FocusedRowHandle, "benchCatID").ToString()
        If benchCatID = "" Then
            e.Criteria = DevExpress.Data.Filtering.CriteriaOperator.Parse(" benchID == " & toSQLValueS(System.Guid.Parse(Guid.Empty.ToString).ToString))
            Exit Sub
        Else
            e.Criteria = DevExpress.Data.Filtering.CriteriaOperator.Parse(" benchCatID == " & toSQLValueS(System.Guid.Parse(benchCatID).ToString))
        End If
    End Sub

    Private Sub RepBench_EditValueChanged(sender As Object, e As EventArgs) Handles RepBench.EditValueChanged
        Dim editor As DevExpress.XtraEditors.LookUpEdit = TryCast(sender, DevExpress.XtraEditors.LookUpEdit)
        GridView6.SetRowCellValue(GridView6.FocusedRowHandle, "Price", editor.GetColumnValue("pricePerMeter"))
    End Sub

    Private Sub GridView6_CellValueChanging(sender As Object, e As CellValueChangedEventArgs) Handles GridView6.CellValueChanging
        Select Case e.Column.FieldName
            Case "tem"
                If e.Value Is Nothing Then Exit Sub
                If GridView6.GetRowCellValue(GridView6.FocusedRowHandle, "Price").ToString = "" Then Exit Sub
                Dim Price As Double = GridView6.GetRowCellValue(GridView6.FocusedRowHandle, "Price")
                Dim tem As Double = e.Value.ToString.Replace(".", ",")
                Dim FinalPrice As Double = tem * Price
                GridView6.SetRowCellValue(GridView6.FocusedRowHandle, "FinalPrice", FinalPrice)
                GridView6.UpdateTotalSummary()
                Dim TotalErmaria As Double = GridView3.Columns("FinalPrice").SummaryItem.SummaryValue +
                                  GridView4.Columns("FinalPrice").SummaryItem.SummaryValue +
                                  GridView5.Columns("FinalPrice").SummaryItem.SummaryValue +
                                  GridView6.Columns("FinalPrice").SummaryItem.SummaryValue
                txtTotalErmariaPriceWVat.EditValue = TotalErmaria
        End Select


    End Sub

    Private Sub GridView6_RowUpdated(sender As Object, e As RowObjectEventArgs) Handles GridView6.RowUpdated
        If GridView6.IsNewItemRow(e.RowHandle) Then InsertRecordB() Else UpdateRecordB()
    End Sub

    Private Sub GridView6_KeyDown(sender As Object, e As KeyEventArgs) Handles GridView6.KeyDown
        Select Case e.KeyCode
            Case Keys.Delete : If UserProps.AllowDelete = True Then DeleteRecordB()
        End Select

    End Sub

    Private Sub RepBenchCat_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles RepBenchCat.ButtonClick
        Dim editor As DevExpress.XtraEditors.LookUpEdit = TryCast(sender, DevExpress.XtraEditors.LookUpEdit)
        Select Case e.Button.Index
            Case 1 : If editor.EditValue <> Nothing Then ManageCbo.ManageBenchCat(editor)
            Case 2 : editor.EditValue = Nothing
        End Select
    End Sub
    Private Sub RepBench_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles RepBench.ButtonClick
        Dim editor As DevExpress.XtraEditors.LookUpEdit = TryCast(sender, DevExpress.XtraEditors.LookUpEdit)
        Select Case e.Button.Index
            Case 1 : If editor.EditValue <> Nothing Then ManageCbo.ManageBENCH(editor)
            Case 2 : editor.EditValue = Nothing
        End Select

    End Sub


    Private Sub GridView6_ValidateRow(sender As Object, e As ValidateRowEventArgs) Handles GridView6.ValidateRow
        Dim View As GridView = CType(sender, GridView)
        If GridView6.GetRowCellValue(GridView6.FocusedRowHandle, "benchID").ToString() = "" Then
            Dim benchID As GridColumn = View.Columns("benchID")
            e.Valid = False
            View.SetColumnError(benchID, "Δεν έχετε επιλέξει Πάγκο")
        End If
        If GridView6.GetRowCellValue(GridView6.FocusedRowHandle, "tem").ToString() = "" Then
            Dim temCOL As GridColumn = View.Columns("tem")
            e.Valid = False
            View.SetColumnError(temCOL, "Δεν έχετε πληκτρολογήσει ΤΕΜ")
        End If
        If e.Valid Then View.ClearColumnErrors()

    End Sub

    Private Sub GridView6_InvalidRowException(sender As Object, e As InvalidRowExceptionEventArgs) Handles GridView6.InvalidRowException
        e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction
    End Sub

    Private Sub RepThickness_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles RepThickness.ButtonClick
        Dim editor As DevExpress.XtraEditors.ComboBoxEdit = TryCast(sender, DevExpress.XtraEditors.ComboBoxEdit)
        Select Case e.Button.Index
            Case 1 : editor.EditValue = Nothing
        End Select

    End Sub
End Class