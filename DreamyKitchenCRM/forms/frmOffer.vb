Imports System.Text.RegularExpressions
Imports System.Data.SqlClient
Imports DevExpress.Utils
Imports DevExpress.Utils.Menu
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Menu
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports DevExpress.XtraLayout
Imports DevExpress.XtraReports.Parameters
Imports DevExpress.XtraReports.UI
Imports DevExpress.LookAndFeel
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraPrinting
Imports DevExpress.Export
Imports DevExpress.XtraEditors.Popup

Public Class frmOffer

    Private sID As String
    Private sOffersID As String = ""
    Private Ctrl As DevExpress.XtraGrid.Views.Grid.GridView
    Private Frm As DevExpress.XtraEditors.XtraForm
    Public Mode As Byte
    Private Valid As New ValidateControls
    Private Log As New Transactions
    Private FillCbo As New FillCombos
    Private DBQ As New DBQueries
    Private LoadForms As New FormLoader
    Private Cls As New ClearControls
    Private CtrlCombo As DevExpress.XtraEditors.LookUpEdit
    Private CalledFromCtrl As Boolean
    Private DoorTypeID As String
    Private DoorPrice As Double
    Private MechPrice As Double
    Private SidePrice As Double
    Private CatErmID As String
    Private CatSubErmID As String
    Private SubOffID As String
    Private SubOffCode As Integer
    Private Calculations As String
    Private CalcID As String
    Private DoCalculations As Boolean = True
    Private selectedOffesID As List(Of String)


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
    Private Sub cmdExit_Click(sender As Object, e As EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub

    Private Sub frmOffer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DreamyKitchenDataSet1.vw_COLORSBAZA' table. You can move, or remove it, as needed.
        Me.Vw_COLORSBAZATableAdapter.Fill(Me.DreamyKitchenDataSet1.vw_COLORSBAZA)
        'TODO: This line of code loads data into the 'DreamyKitchenDataSet.vw_DOOR_TYPE' table. You can move, or remove it, as needed.
        ' Me.Vw_DOOR_TYPETableAdapter.Fill(Me.DreamyKitchenDataSet.vw_DOOR_TYPE)
        'TODO: This line of code loads data into the 'DreamyKitchenDataSet.vw_COLORSPVC' table. You can move, or remove it, as needed.
        Me.Vw_COLORSPVCTableAdapter.Fill(Me.DreamyKitchenDataSet.vw_COLORSPVC)
        'TODO: This line of code loads data into the 'DreamyKitchenDataSet.vw_COLORSBOX' table. You can move, or remove it, as needed.
        Me.Vw_COLORSBOXTableAdapter.Fill(Me.DreamyKitchenDataSet.vw_COLORSBOX)
        'TODO: This line of code loads data into the 'DreamyKitchenDataSet.vw_COLORSBOX' table. You can move, or remove it, as needed.
        Me.Vw_COLORSBAZATableAdapter.Fill(Me.DreamyKitchenDataSet.vw_COLORSBAZA)


        FillCbo.CUS(cboCUS)
        FillCbo.CAT_ERM(cboCategory)
        FillCbo.ERM(cboERM)
        FillCbo.DOOR_TYPE(cboDoorType)
        'FillCbo.BENCH(cboBENCH)
        'FillCbo.BENCH(cboExtraBENCH)
        'FillCbo.DIMENSION(cboDim)
        'FillCbo.FillCheckedListMech(chkMech, FormMode.NewRecord)
        LoadMech()



        FillCbo.CAT_SUB_ERM(cboCatSubErm)
        FillCbo.SIDES()
        'FillCbo.FillCheckedListDoorTypes(chkDoorTypes, FormMode.NewRecord)
        cboSides.Properties.Items.Add("Δεξί")
        cboSides.Properties.Items.Add("Αριστερό")
        cboSides.Properties.Items.Add("Δεξί/Αριστερό")
        cboOpening.Properties.Items.Add("Δεξί")
        cboOpening.Properties.Items.Add("Αριστερό")
        cboOpening.Properties.Items.Add("Ανάκληση")
        If cboCategory.EditValue Is Nothing And cboCatSubErm.EditValue Is Nothing And cboDoorType.EditValue <> Nothing Then
            Me.Vw_ERMTableAdapter.FillByDoorType(Me.DreamyKitchenDataSet.vw_ERM, System.Guid.Parse(cboDoorType.EditValue.ToString))
        ElseIf cboCategory.EditValue <> Nothing And cboCatSubErm.EditValue Is Nothing And cboDoorType.EditValue Is Nothing Then
            Me.Vw_ERMTableAdapter.FillErmCategory(Me.DreamyKitchenDataSet.vw_ERM, System.Guid.Parse(cboCategory.EditValue.ToString))
        ElseIf cboCategory.EditValue Is Nothing And cboDoorType.EditValue Is Nothing And cboCatSubErm.EditValue Is Nothing Then
            'Me.Vw_ERMTableAdapter.FillByAll(Me.DreamyKitchenDataSet.vw_ERM)
        ElseIf cboCategory.EditValue <> Nothing And cboDoorType.EditValue <> Nothing And cboCatSubErm.EditValue Is Nothing Then
            Me.Vw_ERMTableAdapter.FillByErmAndDoor(Me.DreamyKitchenDataSet.vw_ERM, System.Guid.Parse(cboCategory.EditValue.ToString), System.Guid.Parse(cboDoorType.EditValue.ToString))
        ElseIf cboCategory.EditValue <> Nothing And cboCatSubErm.EditValue <> Nothing And cboDoorType.EditValue Is Nothing Then
            Me.Vw_ERMTableAdapter.FillByErmAndSubCat(Me.DreamyKitchenDataSet.vw_ERM, System.Guid.Parse(cboCategory.EditValue.ToString), System.Guid.Parse(cboCatSubErm.EditValue.ToString))
        ElseIf cboCategory.EditValue <> Nothing And cboCatSubErm.EditValue <> Nothing And cboDoorType.EditValue <> Nothing Then
            Me.Vw_ERMTableAdapter.FillByErmDoorAndSubCat(Me.DreamyKitchenDataSet.vw_ERM, System.Guid.Parse(cboCategory.EditValue.ToString), System.Guid.Parse(cboDoorType.EditValue.ToString), System.Guid.Parse(cboCatSubErm.EditValue.ToString))
        End If

        Select Case Mode
            Case FormMode.NewRecord
                LayoutControl2.Enabled = False
                'FillCbo.FillCheckedListMech(chkMech, FormMode.NewRecord)
                txtCode.Text = DBQ.GetNextId("[OFF]")
                cmdOffersNew.Enabled = False
                cmdSave.Enabled = False
            Case FormMode.EditRecord
                'FillCbo.FillCheckedListMech(chkMech, FormMode.EditRecord, sID)
                Me.OFFERSTableAdapter.Fill(Me.DreamyKitchenDataSet.vw_OFFERS, System.Guid.Parse(sID))
                LoadForms.LoadFormGRP(LayoutControlGroup1, "Select * from vw_OFF where id ='" + sID + "'")
                cmdSave.Enabled = False
                cmdCancelOff.Enabled = True
                cmdOfferDetails.Enabled = True
        End Select
        Me.CenterToScreen()
        My.Settings.frmDoorType = Me.Location
        My.Settings.Save()
        LayoutControlGroup2.Enabled = False
        'Φορτώνει όλες τις ονομασίες των στηλών από τον SQL. Από το πεδίο Description
        LoadForms.LoadColumnDescriptionNames(grdMain, GridView1, , "ERM")
        'Φορτώνει όλες τις ονομασίες των στηλών από τον SQL. Από το πεδίο Description
        LoadForms.LoadColumnDescriptionNames(grdMain, GridView3, , "OFFERS")

        If My.Computer.FileSystem.FileExists(Application.StartupPath & "\DSGNS\DEF\OFF_erm.xml") Then GridView1.RestoreLayoutFromXml(Application.StartupPath & "\DSGNS\DEF\OFF_erm.xml", OptionsLayoutBase.FullLayout)
        If My.Computer.FileSystem.FileExists(Application.StartupPath & "\DSGNS\DEF\OFFERS.xml") Then GridView3.RestoreLayoutFromXml(Application.StartupPath & "\DSGNS\DEF\OFFERS.xml", OptionsLayoutBase.FullLayout)

        GridView3.OptionsBehavior.AutoExpandAllGroups = True
        cmdSaveOff.Enabled = IIf(Mode = FormMode.NewRecord, UserProps.AllowInsert, UserProps.AllowEdit)
        txtHeight.ReadOnly = True
        txtWidth.ReadOnly = True
        txtDepth.ReadOnly = True
        txtCustomCode.Select()


    End Sub
    Private Sub LoadMech()
        If Mode = FormMode.NewRecord And sOffersID = "" Then
            LoadForms.LoadDataToGrid(grdMech, GridView2, "select ID,NAME,PRICE,PHOTO from vw_MECH",, True)
        Else
            LoadForms.LoadDataToGrid(grdMech, GridView2, "Select M.ID,M.NAME ,isnull(OM.PRICE,M.PRICE) AS PRICE,M.PHOTO,QTY, TOTALPRICE 
                                                          from vw_MECH M left join vw_OFFER_MECH OM on M.ID = OM.mechID AND offerid = " & toSQLValueS(sOffersID))

        End If
        GridView2.RowHeight = 50
        GridView2.OptionsBehavior.Editable = True
        GridView2.Columns("ID").Visible = False
        GridView2.Columns("NAME").OptionsColumn.AllowEdit = False
        GridView2.Columns("PHOTO").OptionsColumn.AllowEdit = False
        GridView2.Columns("PRICE").OptionsColumn.AllowEdit = False
        GridView2.Columns("QTY").UnboundType = DevExpress.Data.UnboundColumnType.Integer
        GridView2.Columns("QTY").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric

        GridView2.Columns("TOTALPRICE").OptionsColumn.AllowEdit = False
        GridView2.Columns("TOTALPRICE").SummaryItem.FieldName = "TOTALPRICE"
        GridView2.Columns("TOTALPRICE").SummaryItem.DisplayFormat = "SUM={0:0.##}"
        GridView2.Columns("TOTALPRICE").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        GridView2.OptionsView.ShowFooter = True
        'Εαν δεν υπάρχει Default Σχέδιο δημιουργεί
        If My.Computer.FileSystem.FileExists(Application.StartupPath & "\DSGNS\DEF\MECH.xml") = False Then
            GridView2.SaveLayoutToXml(Application.StartupPath & "\DSGNS\DEF\MECH.xml", OptionsLayoutBase.FullLayout)
        Else
            GridView2.RestoreLayoutFromXml(Application.StartupPath & "\DSGNS\DEF\MECH.xml", OptionsLayoutBase.FullLayout)
        End If
    End Sub
    Private Sub frmOffer_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        If Me.WindowState = FormWindowState.Maximized Then frmMain.XtraTabbedMdiManager1.Dock(Me, frmMain.XtraTabbedMdiManager1)
    End Sub

    Private Sub cboCUS_EditValueChanged(sender As Object, e As EventArgs) Handles cboCUS.EditValueChanged
        If cboCUS.EditValue Is Nothing Then Exit Sub
        Dim cmd As SqlCommand = New SqlCommand("Select * from vw_CCT where ID = '" & cboCUS.EditValue.ToString & "'", CNDB)
        Dim sdr As SqlDataReader = cmd.ExecuteReader()
        If (sdr.Read() = True) Then
            If sdr.IsDBNull(sdr.GetOrdinal("mob")) = False Then txtMob.EditValue = sdr.GetString(sdr.GetOrdinal("mob"))
            If sdr.IsDBNull(sdr.GetOrdinal("phn")) = False Then txtPhn.EditValue = sdr.GetString(sdr.GetOrdinal("phn"))
            If sdr.IsDBNull(sdr.GetOrdinal("COU_Name")) = False Then txtCou.EditValue = sdr.GetString(sdr.GetOrdinal("COU_Name"))
            If sdr.IsDBNull(sdr.GetOrdinal("AREAS_Name")) = False Then txtArea.EditValue = sdr.GetString(sdr.GetOrdinal("AREAS_Name"))
            If sdr.IsDBNull(sdr.GetOrdinal("ADR_Name")) = False Then txtADR.EditValue = sdr.GetString(sdr.GetOrdinal("ADR_Name"))
            If sdr.IsDBNull(sdr.GetOrdinal("Ar")) = False Then txtAR.EditValue = sdr.GetString(sdr.GetOrdinal("Ar"))
            If sdr.IsDBNull(sdr.GetOrdinal("Tk")) = False Then txtTK.EditValue = sdr.GetString(sdr.GetOrdinal("Tk"))
        End If
        sdr.Close()
    End Sub

    Private Sub cboCUS_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboCUS.ButtonClick
        Select Case e.Button.Index
            Case 1 : ManageCus()
            Case 2 : cboCUS.EditValue = Nothing : Cls.ClearCtrlsGRP(LayoutControlGroup1)
        End Select
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

    Private Sub cboCategory_EditValueChanged(sender As Object, e As EventArgs) Handles cboCategory.EditValueChanged
        If cboCategory.EditValue Is Nothing Then Exit Sub
        Dim sSQL As New System.Text.StringBuilder
        sSQL.AppendLine("Select id,name from vw_CAT_SUB_ERM where CatErmID = " & toSQLValueS(cboCategory.EditValue.ToString) & "order by name")
        FillCbo.CAT_SUB_ERM(cboCatSubErm, sSQL)

        If cboCategory.EditValue Is Nothing And cboDoorType.EditValue <> Nothing Then
            Me.Vw_ERMTableAdapter.FillByDoorType(Me.DreamyKitchenDataSet.vw_ERM, System.Guid.Parse(cboDoorType.EditValue.ToString))
        ElseIf cboCategory.EditValue <> Nothing And cboDoorType.EditValue Is Nothing Then
            Me.Vw_ERMTableAdapter.FillErmCategory(Me.DreamyKitchenDataSet.vw_ERM, System.Guid.Parse(cboCategory.EditValue.ToString))
        ElseIf cboCategory.EditValue Is Nothing And cboDoorType.EditValue Is Nothing Then
            Me.Vw_ERMTableAdapter.FillByAll(Me.DreamyKitchenDataSet.vw_ERM)
        ElseIf cboCategory.EditValue <> Nothing And cboDoorType.EditValue <> Nothing Then
            Me.Vw_ERMTableAdapter.FillByErmAndDoor(Me.DreamyKitchenDataSet.vw_ERM, System.Guid.Parse(cboCategory.EditValue.ToString), System.Guid.Parse(cboDoorType.EditValue.ToString))
        ElseIf cboCategory.EditValue <> Nothing And cboDoorType.EditValue <> Nothing And cboCatSubErm.EditValue <> Nothing Then
            Me.Vw_ERMTableAdapter.FillByErmDoorAndSubCat(Me.DreamyKitchenDataSet.vw_ERM, System.Guid.Parse(cboCategory.EditValue.ToString), System.Guid.Parse(cboDoorType.EditValue.ToString), System.Guid.Parse(cboCatSubErm.EditValue.ToString))
        End If
    End Sub
    Private Sub grdMain_DoubleClick(sender As Object, e As EventArgs) Handles grdMain.DoubleClick
        chkDimChanged.Checked = False
        LayoutControlGroup2.Enabled = True
        Pic1.EditValue = Nothing : Pic2.EditValue = Nothing : Pic3.EditValue = Nothing
        LoadForms.LoadFormGRP(LayoutControlGroup2, "Select * from vw_ERM where id = " & toSQLValueS(GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "ID").ToString()))
        DoorTypeID = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "DoorTypeID").ToString()
        cboERM.EditValue = System.Guid.Parse(GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "ID").ToString())
        CatErmID = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "catErmID").ToString()
        CatSubErmID = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "catSubErmID").ToString()
        Calculations = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "calculations").ToString()
        CalcID = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "calcID").ToString()
        DoorPrice = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "DoorPrice").ToString()
        cboCategory.EditValue = System.Guid.Parse(CatErmID)
        cboDoorType.EditValue = System.Guid.Parse(DoorTypeID)
        cboCatSubErm.EditValue = System.Guid.Parse(CatSubErmID)
        txtCalc.EditValue = Calculations
        sOffersID = ""
        LoadMech()
        txtTotalPriceMech.EditValue = "0.00"
        If Calculations.Length > 0 Then Calculate() Else txtTotalPrice.EditValue = "0,00"
        txtQTY.EditValue = "1"
        cmdSave.Enabled = True
    End Sub

    Private Sub cboCategory_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboCategory.ButtonClick
        Select Case e.Button.Index
            Case 1 : ManageCAT()
            Case 2 : cboCategory.EditValue = Nothing
        End Select
    End Sub
    Private Sub ManageCAT()
        Dim frmGen As frmGen = New frmGen
        frmGen.Text = "Κατηγορίες Ερμαρίων"
        frmGen.L1.Text = "Κωδικός"
        frmGen.L2.Text = "Κατηγορία"
        frmGen.DataTable = "CAT_ERM"
        frmGen.CallerControl = cboCategory
        frmGen.CalledFromControl = True
        If cboCategory.EditValue <> Nothing Then frmGen.ID = cboCategory.EditValue.ToString
        frmGen.MdiParent = frmMain
        frmGen.L3.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        frmGen.L4.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        frmGen.L5.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        frmGen.L6.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        frmGen.L7.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        If cboCategory.EditValue <> Nothing Then frmGen.Mode = FormMode.EditRecord Else frmGen.Mode = FormMode.NewRecord
        frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(frmGen), New Point(CInt(frmGen.Parent.ClientRectangle.Width / 2 - frmGen.Width / 2), CInt(frmGen.Parent.ClientRectangle.Height / 2 - frmGen.Height / 2)))
        frmGen.Show()
    End Sub

    Private Sub chkDimChanged_CheckedChanged(sender As Object, e As EventArgs) Handles chkDimChanged.CheckedChanged
        Dim Edit As CheckEdit = CType(sender, CheckEdit)
        If Edit.Checked = True Then
            txtHeight.ReadOnly = False : txtWidth.ReadOnly = False : txtDepth.ReadOnly = False
        Else
            txtHeight.ReadOnly = True : txtWidth.ReadOnly = True : txtDepth.ReadOnly = True
            txtHeight.EditValue = "0,00" : txtWidth.EditValue = "0,00" : txtDepth.EditValue = "0,00"
        End If
    End Sub

    Private Sub cboDim_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboDim.ButtonClick
        Select Case e.Button.Index
            Case 1 : ManageDIM()
            Case 2 : cboDim.EditValue = Nothing
        End Select
    End Sub
    Private Sub ManageDIM()
        Dim frmGen As frmGen = New frmGen
        frmGen.Text = "Διαστάσεις"
        frmGen.L1.Text = "Κωδικός"
        frmGen.L2.Text = "Διάσταση"
        frmGen.DataTable = "DIM"
        frmGen.CallerControl = cboDim
        frmGen.CalledFromControl = True
        If cboDim.EditValue <> Nothing Then frmGen.ID = cboDim.EditValue.ToString
        frmGen.MdiParent = frmMain
        frmGen.L3.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        frmGen.L4.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        frmGen.L5.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        frmGen.L6.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        frmGen.L7.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        If cboDim.EditValue <> Nothing Then frmGen.Mode = FormMode.EditRecord Else frmGen.Mode = FormMode.NewRecord
        frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(frmGen), New Point(CInt(frmGen.Parent.ClientRectangle.Width / 2 - frmGen.Width / 2), CInt(frmGen.Parent.ClientRectangle.Height / 2 - frmGen.Height / 2)))
        frmGen.Show()
    End Sub

    Private Sub cboPVCColors_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboPVCColors.ButtonClick
        Select Case e.Button.Index
            Case 1 : ManagePVCColors()
            Case 2 : cboPVCColors.EditValue = Nothing
        End Select
    End Sub
    Private Sub ManagePVCColors()
        Dim frmColors As frmColors = New frmColors
        frmColors.CallerForm = "frmOffer"
        frmColors.CallerControl = cboPVCColors
        frmColors.CalledFromControl = True
        If cboPVCColors.EditValue <> Nothing Then frmColors.ID = cboPVCColors.EditValue.ToString
        frmColors.MdiParent = frmMain
        If cboPVCColors.EditValue <> Nothing Then frmColors.Mode = FormMode.EditRecord Else frmColors.Mode = FormMode.NewRecord
        frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(frmColors), New Point(CInt(frmColors.Parent.ClientRectangle.Width / 2 - frmColors.Width / 2), CInt(frmColors.Parent.ClientRectangle.Height / 2 - frmColors.Height / 2)))
        frmColors.Show()
    End Sub

    Private Sub cboBOXColors_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboBOXColors.ButtonClick
        Select Case e.Button.Index
            Case 1 : ManageBOXColors()
            Case 2 : cboBOXColors.EditValue = Nothing
        End Select
    End Sub
    Private Sub ManageBOXColors()
        Dim frmColors As frmColors = New frmColors
        frmColors.CallerForm = "frmOffer"
        frmColors.CallerControl = cboBOXColors
        frmColors.CalledFromControl = True
        If cboBOXColors.EditValue <> Nothing Then frmColors.ID = cboBOXColors.EditValue.ToString
        frmColors.MdiParent = frmMain
        If cboBOXColors.EditValue <> Nothing Then frmColors.Mode = FormMode.EditRecord Else frmColors.Mode = FormMode.NewRecord
        frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(frmColors), New Point(CInt(frmColors.Parent.ClientRectangle.Width / 2 - frmColors.Width / 2), CInt(frmColors.Parent.ClientRectangle.Height / 2 - frmColors.Height / 2)))
        frmColors.Show()
    End Sub
    Private Sub ManageBazaColors()
        Dim frmColors As frmColors = New frmColors
        frmColors.CallerForm = "frmOffer"
        frmColors.CallerControl = cboBazaColors
        frmColors.CalledFromControl = True
        If cboBazaColors.EditValue <> Nothing Then frmColors.ID = cboBazaColors.EditValue.ToString
        frmColors.MdiParent = frmMain
        If cboBazaColors.EditValue <> Nothing Then frmColors.Mode = FormMode.EditRecord Else frmColors.Mode = FormMode.NewRecord
        frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(frmColors), New Point(CInt(frmColors.Parent.ClientRectangle.Width / 2 - frmColors.Width / 2), CInt(frmColors.Parent.ClientRectangle.Height / 2 - frmColors.Height / 2)))
        frmColors.Show()
    End Sub

    Private Sub cboBENCH_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboBENCH.ButtonClick
        Select Case e.Button.Index
            Case 1 : ManageBENCH()
            Case 2 : cboBENCH.EditValue = Nothing
        End Select
    End Sub
    Private Sub ManageBENCH()
        Dim frmBench As frmBench = New frmBench
        frmBench.CallerForm = "frmOffer"
        frmBench.CallerControl = cboBENCH
        frmBench.CalledFromControl = True
        If cboBENCH.EditValue <> Nothing Then frmBench.ID = cboBENCH.EditValue.ToString
        frmBench.MdiParent = frmMain
        If cboBENCH.EditValue <> Nothing Then frmBench.Mode = FormMode.EditRecord Else frmBench.Mode = FormMode.NewRecord
        frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(frmBench), New Point(CInt(frmBench.Parent.ClientRectangle.Width / 2 - frmBench.Width / 2), CInt(frmBench.Parent.ClientRectangle.Height / 2 - frmBench.Height / 2)))
        frmBench.Show()
    End Sub
    Private Sub ManageBENCHExtra()
        Dim frmBench As frmBench = New frmBench
        frmBench.CallerForm = "frmOffer"
        frmBench.CallerControl = cboExtraBENCH
        frmBench.CalledFromControl = True
        If cboExtraBENCH.EditValue <> Nothing Then frmBench.ID = cboExtraBENCH.EditValue.ToString
        frmBench.MdiParent = frmMain
        If cboExtraBENCH.EditValue <> Nothing Then frmBench.Mode = FormMode.EditRecord Else frmBench.Mode = FormMode.NewRecord
        frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(frmBench), New Point(CInt(frmBench.Parent.ClientRectangle.Width / 2 - frmBench.Width / 2), CInt(frmBench.Parent.ClientRectangle.Height / 2 - frmBench.Height / 2)))
        frmBench.Show()
    End Sub

    'Αποθήκευση όψης Μηχανισμών
    Private Sub OnSaveViewMech(ByVal sender As System.Object, ByVal e As EventArgs)
        Dim item As DXMenuItem = TryCast(sender, DXMenuItem)
        GridView2.SaveLayoutToXml(Application.StartupPath & "\DSGNS\DEF\MECH.xml", OptionsLayoutBase.FullLayout)
        XtraMessageBox.Show("Η όψη αποθηκεύτηκε με επιτυχία", "Dreamy Kitchen CRM", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
    'Μετονομασία Στήλης Master
    Private Sub OnEditValueChangedMech(ByVal sender As System.Object, ByVal e As EventArgs)
        Dim item As New DXEditMenuItem()
        item = sender
        If item.Tag Is Nothing Then Exit Sub
        GridView2.Columns(item.Tag).Caption = item.EditValue
        'MessageBox.Show(item.EditValue.ToString())
    End Sub
    'Αλλαγή Χρώματος Στήλης Master
    Private Sub OnColumnsColorChangedMech(ByVal sender As System.Object, ByVal e As EventArgs)
        Dim item As DXEditMenuItem = TryCast(sender, DXEditMenuItem)
        item = sender
        If item.Tag Is Nothing Then Exit Sub
        GridView2.Columns(item.Tag).AppearanceCell.BackColor = item.EditValue
    End Sub


    'Αποθήκευση όψης Προσφορών
    Private Sub OnSaveViewOff(ByVal sender As System.Object, ByVal e As EventArgs)
        Dim item As DXMenuItem = TryCast(sender, DXMenuItem)
        GridView3.SaveLayoutToXml(Application.StartupPath & "\DSGNS\DEF\OFFERS.xml", OptionsLayoutBase.FullLayout)
        XtraMessageBox.Show("Η όψη αποθηκεύτηκε με επιτυχία", "Dreamy Kitchen CRM", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
    'Μετονομασία Στήλης Master
    Private Sub OnEditValueChangedOff(ByVal sender As System.Object, ByVal e As EventArgs)
        Dim item As New DXEditMenuItem()
        item = sender
        If item.Tag Is Nothing Then Exit Sub
        GridView3.Columns(item.Tag).Caption = item.EditValue
        'MessageBox.Show(item.EditValue.ToString())
    End Sub
    'Αλλαγή Χρώματος Στήλης Master
    Private Sub OnColumnsColorChangedOff(ByVal sender As System.Object, ByVal e As EventArgs)
        Dim item As DXEditMenuItem = TryCast(sender, DXEditMenuItem)
        item = sender
        If item.Tag Is Nothing Then Exit Sub
        GridView3.Columns(item.Tag).AppearanceCell.BackColor = item.EditValue
    End Sub


    'Αποθήκευση όψης Ερμάριων
    Private Sub OnSaveViewErm(ByVal sender As System.Object, ByVal e As EventArgs)
        Dim item As DXMenuItem = TryCast(sender, DXMenuItem)
        GridView1.SaveLayoutToXml(Application.StartupPath & "\DSGNS\DEF\OFF_erm.xml", OptionsLayoutBase.FullLayout)
        XtraMessageBox.Show("Η όψη αποθηκεύτηκε με επιτυχία", "Dreamy Kitchen CRM", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
    'Μετονομασία Στήλης Master
    Private Sub OnEditValueChanged(ByVal sender As System.Object, ByVal e As EventArgs)
        Dim item As New DXEditMenuItem()
        item = sender
        If item.Tag Is Nothing Then Exit Sub
        GridView1.Columns(item.Tag).Caption = item.EditValue
        'MessageBox.Show(item.EditValue.ToString())
    End Sub
    Private Function CreateCheckItem(ByVal caption As String, ByVal column As GridColumn, ByVal image As Image) As DXMenuCheckItem
        Dim item As New DXMenuCheckItem(caption, (Not column.OptionsColumn.AllowMove), image, New EventHandler(AddressOf OnCanMoveItemClick))
        item.Tag = New MenuColumnInfo(column)
        Return item
    End Function
    'Αλλαγή Χρώματος Στήλης Master
    Private Sub OnColumnsColorChanged(ByVal sender As System.Object, ByVal e As EventArgs)
        Dim item As DXEditMenuItem = TryCast(sender, DXEditMenuItem)
        item = sender
        If item.Tag Is Nothing Then Exit Sub
        GridView1.Columns(item.Tag).AppearanceCell.BackColor = item.EditValue
    End Sub
    'Κλείδωμα Στήλης Master
    Private Sub OnCanMoveItemClick(ByVal sender As Object, ByVal e As EventArgs)
        Dim item As DXMenuCheckItem = TryCast(sender, DXMenuCheckItem)
        Dim info As MenuColumnInfo = TryCast(item.Tag, MenuColumnInfo)
        If info Is Nothing Then
            Return
        End If
        info.Column.OptionsColumn.AllowMove = Not item.Checked
    End Sub

    Friend Class MenuColumnInfo
        Public Sub New(ByVal column As GridColumn)
            Me.Column = column
        End Sub
        Public Column As GridColumn
    End Class

    Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click
        Dim sResult As Boolean
        Dim sGuid As String = "", sSQL As String, ExceptFields As New List(Of String)
        Dim SelectedPics As Byte, WhichPictureHaseSelected As Byte
        Dim cbo As New DevExpress.XtraEditors.LookUpEdit
        Dim SubOffCode As Integer
        Dim NewCatSubErmID As String
        Try
            If Valid.ValidateForm(LayoutControl1) Then
                'Εδω θα μπεί όταν πάμε να προσθέσουμε ενα νέο ερμάριο σε μια υπάρχουσα προσφορά
                If (Mode = FormMode.EditRecord And sOffersID = "") Or (selectedOffesID IsNot Nothing And sOffersID = "") Then
                    Dim frmInputBox As New frmInputBox
                    frmInputBox.Text = "Επιλογή τίτλου προσφοράς"
                    frmInputBox.ID = sID
                    selectedOffesID = frmInputBox.SubOffers
                    frmInputBox.ShowDialog()
                End If
                'Επιλογή εικόνας ερμαρίου
                If Pic1.BackColor = Color.Gray Then SelectedPics = 1 : WhichPictureHaseSelected = 1
                If Pic2.BackColor = Color.Gray Then SelectedPics = SelectedPics + 1 : WhichPictureHaseSelected = 2
                If Pic3.BackColor = Color.Gray Then SelectedPics = SelectedPics + 1 : WhichPictureHaseSelected = 3
                If SelectedPics > 1 Then
                    XtraMessageBox.Show("Μόνο μια φωτογραφία μπορείτε να επιλέξετε.", "Dreamy Kitchen CRM", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
                'Καταχώρηση Ερμαρίου
                If chkDimChanged.Checked = True And CatErmID <> "117cf8ed-77c9-4763-8be0-9896bcccaa06" Then
                    'Ελεγχος αν υπάρχει ήδη το Ερμάριο στην βιβλιοθήκη
                    sSQL = "select count(E.id) as id from vw_erm  E " &
                            "where	catErmID=  " & toSQLValueS(CatErmID) & "and " &
                            "catSubErmID = " & toSQLValueS(CatSubErmID) & " and  " &
                            "DoorTypeID= " & toSQLValueS(DoorTypeID) & " and  " &
                            "Width = " & toSQLValueS(txtWidth.EditValue.ToString, True) & " And " &
                            "Height = " & toSQLValueS(txtHeight.EditValue.ToString, True) & " And " &
                            "depth =  " & toSQLValueS(txtDepth.EditValue.ToString, True)
                    Dim cmd As SqlCommand = New SqlCommand(sSQL, CNDB)
                    Dim ExistsDim As Integer = cmd.ExecuteScalar
                    If ExistsDim = 0 Then
                        XtraMessageBox.Show("Έχετε επιλέξει αλλαγή διάστασης. Θα ενημερωθεί η βιβλιοθήκη με την νέα διάσταση.", "Dreamy Kitchen CRM", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        ExceptFields.Add(cboERM.Properties.Tag)
                        ExceptFields.Add(txtQTY.Properties.Tag)
                        ExceptFields.Add(cboBENCH.Properties.Tag)
                        ExceptFields.Add(chkDimChanged.Properties.Tag)
                        ExceptFields.Add(cboBazaColors.Properties.Tag)
                        ExceptFields.Add(cboExtraBENCH.Properties.Tag)
                        ExceptFields.Add(txtbenchExtraDim.Properties.Tag)
                        ExceptFields.Add(txtBenchExtraPrice.Properties.Tag)
                        ExceptFields.Add(txtTotalPrice.Properties.Tag)
                        ExceptFields.Add(cboOpening.Properties.Tag)
                        sGuid = System.Guid.NewGuid.ToString
                        Dim ctErmID As String
                        Select Case CatErmID
                        'Εξτρα Πλαινα
                            Case "DF0C5343-2422-4340-9157-27427098ABD7" : ctErmID = CatErmID
                        'Πάγκοι
                            Case "117CF8ED-77C9-4763-8BE0-9896BCCCAA06" : ctErmID = CatErmID
                            Case Else
                                'ctErmID = "DF0C5343-2422-4340-9157-27427098ABD7"
                                'NewCatSubErmID = System.Guid.NewGuid.ToString
                                'sSQL = "INSERT INTO CAT_SUB_ERM (ID,NAME,CATERMID,CREATEDON,CREATEDBY) VALUES ( " & toSQLValueS(NewCatSubErmID) & "," & toSQLValueS(cboCatSubErm.Properties.GetDisplayText(cboCatSubErm.EditValue)) & "," & toSQLValueS(ctErmID) & ",GETDATE()," & toSQLValueS(UserProps.ID.ToString) & " )"
                                'Using oCmd As New SqlCommand(sSQL, CNDB)
                                '    oCmd.ExecuteNonQuery()
                                'End Using
                                'CatSubErmID = NewCatSubErmID
                                ctErmID = CatErmID
                        End Select
                        sResult = DBQ.InsertNewData(DBQueries.InsertMode.GroupLayoutControl, "ERM",,, LayoutControlGroup2, sGuid,, "DoorTypeID,CatSubErmID,CatErmID,CalcID,visible", toSQLValueS(DoorTypeID) & "," & toSQLValueS(CatSubErmID) & "," & toSQLValueS(ctErmID) & "," & toSQLValueS(CalcID) & ",0", ExceptFields)
                        ' Καταχώρηση Ερμαρίου σε όλα τα πορτάκια
                        Using oCmd As New SqlCommand("CloneERM", CNDB)
                            oCmd.CommandType = CommandType.StoredProcedure
                            oCmd.Parameters.AddWithValue("@ErmID", sGuid)
                            oCmd.Parameters.AddWithValue("@DoorTypeID", DoorTypeID)
                            oCmd.ExecuteNonQuery()
                        End Using
                        ExceptFields.Clear()
                        FillCbo.ERM(cboERM)
                        cboERM.EditValue = System.Guid.Parse(sGuid)
                        If sResult = False Then Exit Sub
                    End If
                End If
                ExceptFields.Add(Pic1.Properties.Tag)
                ExceptFields.Add(Pic2.Properties.Tag)
                ExceptFields.Add(Pic3.Properties.Tag)
                If sOffersID = "" Then
                    If selectedOffesID Is Nothing Then
                        sGuid = System.Guid.NewGuid.ToString
                        selectedOffesID = New List(Of String)
                        If SubOffID = "" Then
                            SubOffID = System.Guid.NewGuid.ToString
                            SubOffCode = DBQ.GetNextCODE("OFF_SUBOFF", "where offid= " & toSQLValueS(sID))
                            sSQL = "INSERT INTO OFF_SUBOFF (ID,offID, code,createdBy ,createdOn) SELECT " & toSQLValueS(SubOffID) & "," & toSQLValueS(sID) & "," & toSQLValueS(SubOffCode.ToString, True) & "," & toSQLValueS(UserProps.ID.ToString) & ",GETDATE()"
                            Using oCmd As New SqlCommand(sSQL, CNDB)
                                oCmd.ExecuteNonQuery()
                            End Using
                        End If
                        sResult = DBQ.InsertNewData(DBQueries.InsertMode.GroupLayoutControl, "OFFERS",,, LayoutControlGroup2, sGuid,, "offID,SelectedErmPicture,subOffID", toSQLValueS(sID) & "," & WhichPictureHaseSelected & "," & toSQLValueS(SubOffID), ExceptFields)
                        If sResult = True Then
                            If SelectedPics > 0 Then
                                'Οταν φτάσει εδώ ο κώδικας πάντα μια φωτογραφία ειναι επιλεγμένη
                                sSQL = "UPDATE OFFERS SET SelectedErmPicture = " & WhichPictureHaseSelected & ", Photo = @Photo WHERE ID = " & toSQLValueS(sGuid)
                                Using oCmd As New SqlCommand(sSQL, CNDB)
                                    If Pic1.BackColor = Color.Gray Then oCmd.Parameters.AddWithValue("@Photo", Pic1.EditValue)
                                    If Pic2.BackColor = Color.Gray Then oCmd.Parameters.AddWithValue("@Photo", Pic2.EditValue)
                                    If Pic3.BackColor = Color.Gray Then oCmd.Parameters.AddWithValue("@Photo", Pic3.EditValue)
                                    oCmd.ExecuteNonQuery()
                                End Using
                            End If
                            selectedOffesID.Add(SubOffID)
                        End If
                    Else
                        For i As Integer = 0 To selectedOffesID.Count - 1
                            sGuid = System.Guid.NewGuid.ToString
                            SubOffID = selectedOffesID(i)
                            sResult = DBQ.InsertNewData(DBQueries.InsertMode.GroupLayoutControl, "OFFERS",,, LayoutControlGroup2, sGuid,, "offID,SelectedErmPicture,subOffID", toSQLValueS(sID) & "," & WhichPictureHaseSelected & "," & toSQLValueS(SubOffID), ExceptFields)
                            If sResult = True Then
                                If SelectedPics > 0 Then
                                    'Οταν φτάσει εδώ ο κώδικας πάντα μια φωτογραφία ειναι επιλεγμένη
                                    sSQL = "UPDATE OFFERS SET SelectedErmPicture = " & WhichPictureHaseSelected & ", Photo = @Photo WHERE ID = " & toSQLValueS(sGuid)
                                    Using oCmd As New SqlCommand(sSQL, CNDB)
                                        If Pic1.BackColor = Color.Gray Then oCmd.Parameters.AddWithValue("@Photo", Pic1.EditValue)
                                        If Pic2.BackColor = Color.Gray Then oCmd.Parameters.AddWithValue("@Photo", Pic2.EditValue)
                                        If Pic3.BackColor = Color.Gray Then oCmd.Parameters.AddWithValue("@Photo", Pic3.EditValue)
                                        oCmd.ExecuteNonQuery()
                                    End Using
                                End If
                            End If
                        Next i
                    End If
                Else
                    sResult = DBQ.UpdateNewData(DBQueries.InsertMode.GroupLayoutControl, "OFFERS",,, LayoutControlGroup2, sOffersID,,,, ExceptFields)
                End If
                If sResult = True Then
                    If SelectedPics > 0 Then
                        'Οταν φτάσει εδώ ο κώδικας πάντα μια φωτογραφία ειναι επιλεγμένη
                        sSQL = "UPDATE OFFERS SET SelectedErmPicture = " & WhichPictureHaseSelected & ", Photo = @Photo WHERE ID = " & toSQLValueS(sOffersID)
                        Using oCmd As New SqlCommand(sSQL, CNDB)
                            If Pic1.BackColor = Color.Gray Then oCmd.Parameters.AddWithValue("@Photo", Pic1.EditValue)
                            If Pic2.BackColor = Color.Gray Then oCmd.Parameters.AddWithValue("@Photo", Pic2.EditValue)
                            If Pic3.BackColor = Color.Gray Then oCmd.Parameters.AddWithValue("@Photo", Pic3.EditValue)
                            oCmd.ExecuteNonQuery()
                        End Using
                    End If

                    'Όταν είναι σε EditMode διαγραφουμε όλους τους μηχανισμούς
                    If sOffersID <> "" Then
                        sSQL = "DELETE FROM OFFER_MECH where OFFERID = '" & IIf(sOffersID <> "", sOffersID, sGuid) & "'"
                        Using oCmd As New SqlCommand(sSQL, CNDB)
                            oCmd.ExecuteNonQuery()
                        End Using
                    End If

                    ' Καταχώρηση Μηχανισμών
                    For i As Integer = 0 To GridView2.DataRowCount - 1

                        If Not IsDBNull(GridView2.GetRowCellValue(i, "QTY")) Then
                            sSQL = "INSERT INTO OFFER_MECH ([OFFID],[OFFERID],[MECHID],[modifiedBy],[createdOn],QTY,PRICE,TOTALPRICE)  
                                    values (" & toSQLValueS(sID) & "," & toSQLValueS(IIf(sOffersID <> "", sOffersID, sGuid)) & "," & toSQLValueS(GridView2.GetRowCellValue(i, "ID").ToString) & "," &
                                    toSQLValueS(UserProps.ID.ToString) & ", getdate()," & toSQLValueS(GridView2.GetRowCellValue(i, "QTY"), True) & "," &
                                    toSQLValueS(GridView2.GetRowCellValue(i, "PRICE"), True) & "," & toSQLValueS(GridView2.GetRowCellValue(i, "TOTALPRICE"), True) & ")"
                            Using oCmd As New SqlCommand(sSQL, CNDB)
                                oCmd.ExecuteNonQuery()
                            End Using
                        End If
                    Next

                    'Όταν είναι σε EditMode διαγραφουμε όλους τα πλαϊνά - καταφραγές
                    If sOffersID <> "" Then
                        sSQL = "DELETE FROM OFFER_SIDES where OFFERID = '" & IIf(sOffersID <> "", sOffersID, sGuid) & "'"
                        Using oCmd As New SqlCommand(sSQL, CNDB)
                            oCmd.ExecuteNonQuery()
                        End Using
                    End If

                    XtraMessageBox.Show("Η εγγραφή αποθηκέυτηκε με επιτυχία", "Dreamy Kitchen CRM", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Cls.ClearCtrlsGRP(LayoutControlGroup2)
                    LoadMech()
                    Pic1.BackColor = Color.White : Pic2.BackColor = Color.White : Pic3.BackColor = Color.White
                    Pic1.BorderStyle = BorderStyles.Default : Pic2.BorderStyle = BorderStyles.Default : Pic3.BorderStyle = BorderStyles.Default
                    LayoutControlGroup2.Enabled = False
                    txtTotalPrice.EditValue = "0,00"
                    txtTotalPriceMech.EditValue = "0,00"
                    txtGrandTotal.EditValue = "0,00"
                    sOffersID = "" : SidePrice = 0 : MechPrice = 0
                    Me.OFFERSTableAdapter.Fill(Me.DreamyKitchenDataSet.vw_OFFERS, System.Guid.Parse(sID))
                    cmdSave.Enabled = False
                End If
            End If
        Catch ex As Exception
            cbo = Nothing
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), "Dreamy Kitchen CRM", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub cmdSaveOff_Click(sender As Object, e As EventArgs) Handles cmdSaveOff.Click
        Dim sResult As Boolean
        Try
            If Valid.ValidateForm(LayoutControl1) Then
                'Dim txt As New DevExpress.XtraEditors.TextEdit
                'txt.Properties.Mask.MaskType = Mask.MaskType.Numeric
                'txt.Properties.Mask.EditMask = "n2"
                'Dim args = New XtraInputBoxArgs()
                'args.Caption = "Τελικό Ύψος Κουζίνας (cm)"
                'args.Prompt = "Πληκτρολογήστε το Τελικό Ύψος Κουζίνας (cm)"
                'args.DefaultButtonIndex = 0
                'args.DefaultResponse = "Test"
                'args.Editor = txt
                'Dim Result = XtraInputBox.Show(args)
                'If Result Is Nothing Then
                '    XtraMessageBox.Show("Πρέπει υποχρεωτικά να περάσετε τελικό ύψος κουζινας για να προχωρήσετε.", "Dreamy Kitchen CRM", MessageBoxButtons.OK, MessageBoxIcon.Error)
                '    Exit Sub
                'End If
                Select Case Mode
                    Case FormMode.NewRecord
                        sID = System.Guid.NewGuid.ToString
                        sResult = DBQ.InsertNewData(DBQueries.InsertMode.GroupLayoutControl, "[OFF]",,, LayoutControlGroup1, sID)
                        If sResult = True Then
                            ' Καταχώρηση υποπροσφοράς
                            Dim sSQL As String
                            SubOffID = System.Guid.NewGuid.ToString
                            SubOffCode = 1
                            sSQL = "INSERT INTO OFF_SUBOFF (ID,offID, code,createdBy ,createdOn) SELECT " & toSQLValueS(SubOffID) & "," & toSQLValueS(sID) & "," & toSQLValueS(SubOffCode.ToString, True) & "," & toSQLValueS(UserProps.ID.ToString) & ",GETDATE()"
                            Using oCmd As New SqlCommand(sSQL, CNDB)
                                oCmd.ExecuteNonQuery()
                            End Using
                            'Εαν δεν υπάρχουν στοιχεία προσφοράς καταχωρώ την γραμμή ώστε μετα να γίνεται update στο data entry
                            sSQL = "INSERT INTO OFF_DET (offID, createdBy ,createdOn,gola,legsV,legsY,boxVColorID, boxKColorID, boxYColorID, pvcVColorID, pvcKColorID, pvcYColorID,benchID,
                                    doorThickness,backThickness) 
                                    SELECT " & toSQLValueS(sID) & "," & toSQLValueS(UserProps.ID.ToString) & ",GETDATE(),0,10,10,'AAED2CAA-2FFB-4A00-98F7-3720B0C29D0A',
                                    'AAED2CAA-2FFB-4A00-98F7-3720B0C29D0A','AAED2CAA-2FFB-4A00-98F7-3720B0C29D0A','C8115C86-BE50-4B14-8A4E-9BF0AAA250E5','C8115C86-BE50-4B14-8A4E-9BF0AAA250E5'
                                    ,'C8115C86-BE50-4B14-8A4E-9BF0AAA250E5','96A2CECA-74D3-4FE2-BE1E-09F9BD35B13D',18,8"
                            Using oCmd As New SqlCommand(sSQL, CNDB)
                                oCmd.ExecuteNonQuery()
                            End Using
                            cmdOfferDetails.Enabled = True
                        End If
                    Case FormMode.EditRecord
                        sResult = DBQ.UpdateNewData(DBQueries.InsertMode.GroupLayoutControl, "[OFF]",,, LayoutControlGroup1, sID)
                End Select
                'If CalledFromCtrl Then
                '    FillCbo.ERM(CtrlCombo)
                '    CtrlCombo.EditValue = System.Guid.Parse(sGuid)
                'Else
                Dim form As frmScroller = Frm
                form.LoadRecords("vw_OFF")
                'End If
                txtCustomCode.Select()
                If sResult = True Then
                    XtraMessageBox.Show("Η εγγραφή αποθηκέυτηκε με επιτυχία", "Dreamy Kitchen CRM", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    'LayoutControlGroup2.Enabled = True :
                    LayoutControl2.Enabled = True
                    cmdOffersNew.Enabled = True
                    cmdSave.Enabled = True
                    cmdCancelOff.Enabled = True
                    'Cls.ClearCtrls(LayoutControl1)
                    'txtCode.Text = DBQ.GetNextId("[OFF]")
                End If
            End If

        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), "Dreamy Kitchen CRM", MessageBoxButtons.OK, MessageBoxIcon.Error)
            'Όταν είναι νέα εγγραφή και κάτι δεν έχει πάει κάλά στην προσπάθεια των καταχωρήσεων κάνει ολική διαγραφή όλων 
        End Try
    End Sub

    Private Sub GridView3_DoubleClick(sender As Object, e As EventArgs) Handles GridView3.DoubleClick
        DoCalculations = False
        If GridView3.GetRowCellValue(GridView3.FocusedRowHandle, "ID") = Nothing Then Exit Sub
        Cls.ClearCtrlsGRP(LayoutControlGroup2)
        Pic1.BackColor = Color.White : Pic2.BackColor = Color.White : Pic3.BackColor = Color.White
        Pic1.BorderStyle = BorderStyles.Default : Pic2.BorderStyle = BorderStyles.Default : Pic3.BorderStyle = BorderStyles.Default
        LoadForms.LoadFormGRP(LayoutControlGroup2, "Select * from vw_OFFERS where id ='" + GridView3.GetRowCellValue(GridView3.FocusedRowHandle, "ID").ToString() + "'")
        'Άνοιγμα
        cboOpening.EditValue = GridView3.GetRowCellValue(GridView3.FocusedRowHandle, "opening").ToString()
        'Πλαϊνα
        cboSides.EditValue = GridView3.GetRowCellValue(GridView3.FocusedRowHandle, "side1").ToString()
        'Φωτογραφία επιλεγμένου ερμαρίου
        Dim cmd As SqlCommand = New SqlCommand("Select SelectedErmPicture from vw_OFFERS where id ='" + GridView3.GetRowCellValue(GridView3.FocusedRowHandle, "ID").ToString() + "'", CNDB)
        Dim sdr As SqlDataReader = cmd.ExecuteReader()
        If (sdr.Read() = True) Then
            If sdr.IsDBNull(sdr.GetOrdinal("SelectedErmPicture")) = False Then
                Select Case sdr.GetByte(sdr.GetOrdinal("SelectedErmPicture"))
                    Case 1 : Pic1.BackColor = Color.Gray
                    Case 2 : Pic2.BackColor = Color.Gray
                    Case 3 : Pic3.BackColor = Color.Gray
                End Select
            End If
        End If
        sdr.Close()
        DoorTypeID = GridView3.GetRowCellValue(GridView3.FocusedRowHandle, "DoorTypeID").ToString()
        CatSubErmID = GridView3.GetRowCellValue(GridView3.FocusedRowHandle, "catSubErmID").ToString()
        CatErmID = GridView3.GetRowCellValue(GridView3.FocusedRowHandle, "catErmID").ToString()
        sOffersID = GridView3.GetRowCellValue(GridView3.FocusedRowHandle, "ID").ToString()
        DoorPrice = GridView3.GetRowCellValue(GridView3.FocusedRowHandle, "DoorPrice").ToString()
        txtTotalPrice.EditValue = GridView3.GetRowCellValue(GridView3.FocusedRowHandle, "ErmPrice").ToString()
        txtCalc.EditValue = GridView3.GetRowCellValue(GridView3.FocusedRowHandle, "calculations").ToString()
        LoadMech()
        'FillCbo.FillCheckedListMech(chkMech, FormMode.EditRecord, sOffersID)
        cmdSave.Enabled = True
        cboERM.EditValue = System.Guid.Parse(GridView3.GetRowCellValue(GridView3.FocusedRowHandle, "ermID").ToString())
        cboCatSubErm.EditValue = Nothing : cboCategory.EditValue = Nothing : cboDoorType.EditValue = Nothing
        LayoutControlGroup2.Enabled = True
        DoCalculations = True
    End Sub

    Private Sub cmdOffersEdit_Click(sender As Object, e As EventArgs) Handles cmdOffersEdit.Click
        sOffersID = ""
        cmdSave.Enabled = True
    End Sub
    Private Sub cmdSameOffer_Click(sender As Object, e As EventArgs) Handles cmdSameOffer.Click
        Try
            Dim frmCloneOffer As New frmCloneOffer
            frmCloneOffer.Text = "Δημιουργία Προσφοράς σε άλλο πορτάκι"
            'frmOffTotal.MdiParent = frmMain
            frmCloneOffer.ID = sID
            frmCloneOffer.OfferCode = txtCode.EditValue
            frmCloneOffer.SetSubOffers = selectedOffesID
            frmCloneOffer.FormScroller = Me
            If Not selectedOffesID Is Nothing Then
                frmCloneOffer.GetSubOffers.AddRange(selectedOffesID.GetRange(0, selectedOffesID.Count))
            End If
            'frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(frmCatSubErm), New Point(CInt(Me.Parent.ClientRectangle.Width / 2 - Me.Width / 2), CInt(Me.Parent.ClientRectangle.Height / 2 - Me.Height / 2)))
            frmCloneOffer.ShowDialog()
            Me.OFFERSTableAdapter.Fill(Me.DreamyKitchenDataSet.vw_OFFERS, System.Guid.Parse(sID))

        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), "Dreamy Kitchen CRM", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cmdOffersDel_Click(sender As Object, e As EventArgs) Handles cmdOffersDel.Click
        DeleteOffersHandle()
    End Sub
    Private Sub DeleteOffers()
        Try
            Dim sSQL As String
            If GridView3.GetRowCellValue(GridView3.FocusedRowHandle, "ID") = Nothing Then Exit Sub
            If XtraMessageBox.Show("Θέλετε να διαγραφεί η τρέχουσα εγγραφή?", "Dreamy Kitchen CRM", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                sSQL = "DELETE FROM [OFFER_MECH] WHERE OFFERID = '" & GridView3.GetRowCellValue(GridView3.FocusedRowHandle, "ID").ToString & "'"
                Using oCmd As New SqlCommand(sSQL, CNDB)
                    oCmd.ExecuteNonQuery()
                End Using
                sSQL = "DELETE FROM [OFFER_SIDES] WHERE OFFERID = '" & GridView3.GetRowCellValue(GridView3.FocusedRowHandle, "ID").ToString & "'"
                Using oCmd As New SqlCommand(sSQL, CNDB)
                    oCmd.ExecuteNonQuery()
                End Using
                sSQL = "DELETE FROM [OFFERS] WHERE ID = '" & GridView3.GetRowCellValue(GridView3.FocusedRowHandle, "ID").ToString & "'"
                Using oCmd As New SqlCommand(sSQL, CNDB)
                    oCmd.ExecuteNonQuery()
                End Using
                Me.OFFERSTableAdapter.Fill(Me.DreamyKitchenDataSet.vw_OFFERS, System.Guid.Parse(sID))
                Cls.ClearCtrlsGRP(LayoutControlGroup2)
                cmdSave.Enabled = False
            End If
        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), "Dreamy Kitchen CRM", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
    Private Sub DeleteOffersBasedSubOffer(ByVal SelectedOfferID As String)
        Try
            Dim sSQL As String
            sSQL = " delete OFFER_MECH  from offers inner join OFFER_MECH on OFFER_MECH.offerID=offers.ID where offers.subOffID = " & toSQLValueS(SelectedOfferID)
            Using oCmd As New SqlCommand(sSQL, CNDB)
                oCmd.ExecuteNonQuery()
            End Using
            sSQL = " delete OFFER_SIDES  from offers inner join OFFER_SIDES on OFFER_SIDES.offerID=offers.ID where offers.subOffID = " & toSQLValueS(SelectedOfferID)
            Using oCmd As New SqlCommand(sSQL, CNDB)
                oCmd.ExecuteNonQuery()
            End Using

            sSQL = "DELETE FROM [OFF_SUBOFF] WHERE ID = '" & SelectedOfferID & "'"
            Using oCmd As New SqlCommand(sSQL, CNDB)
                oCmd.ExecuteNonQuery()
            End Using

            sSQL = "DELETE FROM [OFFERS] WHERE subOffID = '" & SelectedOfferID & "'"
            Using oCmd As New SqlCommand(sSQL, CNDB)
                oCmd.ExecuteNonQuery()
            End Using

        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), "Dreamy Kitchen CRM", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
    Private Sub DeleteOffersBasedSubOfferAndDoortype(ByVal SelectedOfferID As String, ByVal DoorTypeID As String)
        Try
            Dim sSQL As String
            sSQL = " delete OFFER_MECH 
                     from offers
                    inner join OFFER_MECH on OFFER_MECH.offerID=offers.ID 
                    inner join ERM on ERM.ID=OFFERS.ermID
                    inner join DOOR_TYPE on DOOR_TYPE.ID=ERM.DoorTypeID 
                    where offers.subOffID  = " & toSQLValueS(SelectedOfferID) & " and doortypeid = " & toSQLValueS(DoorTypeID)
            Using oCmd As New SqlCommand(sSQL, CNDB)
                oCmd.ExecuteNonQuery()
            End Using
            sSQL = " delete OFFER_SIDES 
                     from offers
                    inner join OFFER_SIDES on OFFER_SIDES.offerID=offers.ID 
                    inner join ERM on ERM.ID=OFFERS.ermID
                    inner join DOOR_TYPE on DOOR_TYPE.ID=ERM.DoorTypeID 
                    where offers.subOffID  = " & toSQLValueS(SelectedOfferID) & " and doortypeid = " & toSQLValueS(DoorTypeID)

            Using oCmd As New SqlCommand(sSQL, CNDB)
                oCmd.ExecuteNonQuery()
            End Using

            sSQL = " delete offers 
                     from offers
                    inner join ERM on ERM.ID=OFFERS.ermID
                    inner join DOOR_TYPE on DOOR_TYPE.ID=ERM.DoorTypeID 
                    where offers.subOffID  = " & toSQLValueS(SelectedOfferID) & " and doortypeid = " & toSQLValueS(DoorTypeID)
            Using oCmd As New SqlCommand(sSQL, CNDB)
                oCmd.ExecuteNonQuery()
            End Using

        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), "Dreamy Kitchen CRM", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
    Private Sub DeleteOffersBasedSubOfferDoortypeAndCatErm(ByVal SelectedOfferID As String, ByVal DoorTypeID As String, ByVal CatErmID As String)
        Try
            Dim sSQL As String
            sSQL = " delete OFFER_MECH 
                     from offers
                    inner join OFFER_MECH on OFFER_MECH.offerID=offers.ID 
                    inner join ERM on ERM.ID=OFFERS.ermID
                    inner join DOOR_TYPE on DOOR_TYPE.ID=ERM.DoorTypeID 
                    where offers.subOffID  = " & toSQLValueS(SelectedOfferID) & " and doortypeid = " & toSQLValueS(DoorTypeID) & " and catermid = " & toSQLValueS(CatErmID)
            Using oCmd As New SqlCommand(sSQL, CNDB)
                oCmd.ExecuteNonQuery()
            End Using
            sSQL = " delete OFFER_SIDES 
                     from offers
                    inner join OFFER_SIDES on OFFER_SIDES.offerID=offers.ID 
                    inner join ERM on ERM.ID=OFFERS.ermID
                    inner join DOOR_TYPE on DOOR_TYPE.ID=ERM.DoorTypeID 
                    where offers.subOffID  = " & toSQLValueS(SelectedOfferID) & " and doortypeid = " & toSQLValueS(DoorTypeID) & " and catermid = " & toSQLValueS(CatErmID)

            Using oCmd As New SqlCommand(sSQL, CNDB)
                oCmd.ExecuteNonQuery()
            End Using

            sSQL = " delete offers 
                     from offers
                    inner join ERM on ERM.ID=OFFERS.ermID
                    inner join DOOR_TYPE on DOOR_TYPE.ID=ERM.DoorTypeID 
                    where offers.subOffID  = " & toSQLValueS(SelectedOfferID) & " and doortypeid = " & toSQLValueS(DoorTypeID) & " and catermid = " & toSQLValueS(CatErmID)
            Using oCmd As New SqlCommand(sSQL, CNDB)
                oCmd.ExecuteNonQuery()
            End Using

        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), "Dreamy Kitchen CRM", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
    Private Sub GridControl1_KeyDown(sender As Object, e As KeyEventArgs) Handles grdOffers.KeyDown

    End Sub

    Private Sub cmdOffersRefresh_Click(sender As Object, e As EventArgs) Handles cmdOffersRefresh.Click
        Me.OFFERSTableAdapter.Fill(Me.DreamyKitchenDataSet.vw_OFFERS, System.Guid.Parse(sID))
    End Sub

    Private Sub Calculate()
        Try
            If DoCalculations = False Then Exit Sub
            Dim sCalc As Decimal, W As Decimal, P As Decimal, TransformationCalc As String, H As Decimal
            Dim BenchExtraPrice As String
            If txtCalc.EditValue = Nothing Then Exit Sub
            W = txtWidth.EditValue / 100
            H = txtHeight.EditValue / 100
            If W = 0 Then Exit Sub
            BenchExtraPrice = txtBenchExtraPrice.EditValue
            BenchExtraPrice = BenchExtraPrice.Replace(",", ".").Replace(" €", "")
            TransformationCalc = txtCalc.EditValue
            TransformationCalc = TransformationCalc.Replace("W", W)
            TransformationCalc = TransformationCalc.Replace("H", H)
            TransformationCalc = TransformationCalc.Replace("P", DoorPrice).Replace(",", ".")
            'TransformationCalc = TransformationCalc.Replace("Η", DoorPrice).Replace(",", ".")
            If BenchExtraPrice <> "0,00" And BenchExtraPrice <> "0,00 €" And BenchExtraPrice.Length <> 0 Then TransformationCalc = TransformationCalc + " + " + BenchExtraPrice
            If txtQTY.EditValue.ToString = "" Then txtQTY.EditValue = "1"
            TransformationCalc = "(" + TransformationCalc + ") *" + txtQTY.EditValue.ToString
            Dim cmd As SqlCommand = New SqlCommand("Select cast(" & TransformationCalc & " as decimal(18,2))", CNDB)
            Dim sdr As SqlDataReader = cmd.ExecuteReader()
            If sdr.Read() = True Then sCalc = sdr.GetDecimal(0) : txtTotalPrice.EditValue = sCalc : txtGrandTotal.EditValue = txtTotalPriceMech.EditValue + txtTotalPrice.EditValue
            sdr.Close()
        Catch ex As Exception

            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), "Dreamy Kitchen CRM", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub cboExtraBENCH_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboExtraBENCH.ButtonClick
        Select Case e.Button.Index
            Case 1 : ManageBENCHExtra()
            Case 2 : cboExtraBENCH.EditValue = Nothing
        End Select
    End Sub

    Private Sub cboExtraBENCH_EditValueChanged(sender As Object, e As EventArgs) Handles cboExtraBENCH.EditValueChanged
        If cboExtraBENCH.EditValue <> Nothing Then
            txtbenchExtraDim.Enabled = True
            txtBenchExtraPrice.Enabled = True
        Else
            txtbenchExtraDim.Enabled = False
            txtBenchExtraPrice.Enabled = False
            txtbenchExtraDim.EditValue = "0,00"
            txtBenchExtraPrice.EditValue = "0,00"
        End If
    End Sub

    Private Sub txtbenchExtraDim_EditValueChanged(sender As Object, e As EventArgs) Handles txtbenchExtraDim.EditValueChanged
        If cboExtraBENCH.GetColumnValue("pricePerMeter") = Nothing Or txtbenchExtraDim.EditValue = Nothing Then Exit Sub
        txtBenchExtraPrice.EditValue = cboExtraBENCH.GetColumnValue("pricePerMeter") * txtbenchExtraDim.EditValue.ToString.Replace(".", ",")
        Calculate()
    End Sub

    Private Sub cboDoorType_EditValueChanged(sender As Object, e As EventArgs) Handles cboDoorType.EditValueChanged
        If cboCategory.EditValue Is Nothing And cboCatSubErm.EditValue Is Nothing And cboDoorType.EditValue <> Nothing Then
            Me.Vw_ERMTableAdapter.FillByDoorType(Me.DreamyKitchenDataSet.vw_ERM, System.Guid.Parse(cboDoorType.EditValue.ToString))
        ElseIf cboCategory.EditValue <> Nothing And cboCatSubErm.EditValue Is Nothing And cboDoorType.EditValue Is Nothing Then
            Me.Vw_ERMTableAdapter.FillErmCategory(Me.DreamyKitchenDataSet.vw_ERM, System.Guid.Parse(cboCategory.EditValue.ToString))
        ElseIf cboCategory.EditValue Is Nothing And cboDoorType.EditValue Is Nothing And cboCatSubErm.EditValue Is Nothing Then
            Me.Vw_ERMTableAdapter.FillByAll(Me.DreamyKitchenDataSet.vw_ERM)
        ElseIf cboCategory.EditValue <> Nothing And cboDoorType.EditValue <> Nothing And cboCatSubErm.EditValue Is Nothing Then
            Me.Vw_ERMTableAdapter.FillByErmAndDoor(Me.DreamyKitchenDataSet.vw_ERM, System.Guid.Parse(cboCategory.EditValue.ToString), System.Guid.Parse(cboDoorType.EditValue.ToString))
        ElseIf cboCategory.EditValue <> Nothing And cboCatSubErm.EditValue <> Nothing And cboDoorType.EditValue Is Nothing Then
            Me.Vw_ERMTableAdapter.FillByErmAndSubCat(Me.DreamyKitchenDataSet.vw_ERM, System.Guid.Parse(cboCategory.EditValue.ToString), System.Guid.Parse(cboCatSubErm.EditValue.ToString))
        ElseIf cboCategory.EditValue <> Nothing And cboCatSubErm.EditValue <> Nothing And cboDoorType.EditValue <> Nothing Then
            Me.Vw_ERMTableAdapter.FillByErmDoorAndSubCat(Me.DreamyKitchenDataSet.vw_ERM, System.Guid.Parse(cboCategory.EditValue.ToString), System.Guid.Parse(cboDoorType.EditValue.ToString), System.Guid.Parse(cboCatSubErm.EditValue.ToString))
        End If
        ' txtDoorPrice.EditValue = cboDoorType.GetColumnValue("price")
    End Sub

    Private Sub cboDoorType_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboDoorType.ButtonClick
        Select Case e.Button.Index
            Case 1 : ManageDoorType()
            Case 2 : cboDoorType.EditValue = Nothing
        End Select
    End Sub
    Private Sub ManageDoorType()
        Dim frmDoorType As frmDoorType = New frmDoorType
        frmDoorType.CallerControl = cboDoorType
        frmDoorType.CalledFromControl = True
        If cboDoorType.EditValue <> Nothing Then frmDoorType.ID = cboDoorType.EditValue.ToString
        frmDoorType.MdiParent = frmMain
        If cboDoorType.EditValue <> Nothing Then frmDoorType.Mode = FormMode.EditRecord Else frmDoorType.Mode = FormMode.NewRecord
        frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(frmDoorType), New Point(CInt(frmDoorType.Parent.ClientRectangle.Width / 2 - frmDoorType.Width / 2), CInt(frmDoorType.Parent.ClientRectangle.Height / 2 - frmDoorType.Height / 2)))
        frmDoorType.Show()
    End Sub

    Private Sub txtWidth_EditValueChanged(sender As Object, e As EventArgs) Handles txtWidth.EditValueChanged
        Calculate()
    End Sub

    Private Sub txtQTY_EditValueChanged(sender As Object, e As EventArgs) Handles txtQTY.EditValueChanged
        Calculate()
    End Sub

    Private Sub cboCatSubErm_EditValueChanged(sender As Object, e As EventArgs) Handles cboCatSubErm.EditValueChanged
        If cboCategory.EditValue Is Nothing And cboCatSubErm.EditValue Is Nothing And cboDoorType.EditValue <> Nothing Then
            Me.Vw_ERMTableAdapter.FillByDoorType(Me.DreamyKitchenDataSet.vw_ERM, System.Guid.Parse(cboDoorType.EditValue.ToString))
        ElseIf cboCategory.EditValue <> Nothing And cboCatSubErm.EditValue Is Nothing And cboDoorType.EditValue Is Nothing Then
            Me.Vw_ERMTableAdapter.FillErmCategory(Me.DreamyKitchenDataSet.vw_ERM, System.Guid.Parse(cboCategory.EditValue.ToString))
        ElseIf cboCategory.EditValue Is Nothing And cboDoorType.EditValue Is Nothing And cboCatSubErm.EditValue Is Nothing Then
            Me.Vw_ERMTableAdapter.FillByAll(Me.DreamyKitchenDataSet.vw_ERM)
        ElseIf cboCategory.EditValue <> Nothing And cboDoorType.EditValue <> Nothing And cboCatSubErm.EditValue Is Nothing Then
            Me.Vw_ERMTableAdapter.FillByErmAndDoor(Me.DreamyKitchenDataSet.vw_ERM, System.Guid.Parse(cboCategory.EditValue.ToString), System.Guid.Parse(cboDoorType.EditValue.ToString))
        ElseIf cboCategory.EditValue <> Nothing And cboCatSubErm.EditValue <> Nothing And cboDoorType.EditValue Is Nothing Then
            Me.Vw_ERMTableAdapter.FillByErmAndSubCat(Me.DreamyKitchenDataSet.vw_ERM, System.Guid.Parse(cboCategory.EditValue.ToString), System.Guid.Parse(cboCatSubErm.EditValue.ToString))
        ElseIf cboCategory.EditValue <> Nothing And cboCatSubErm.EditValue <> Nothing And cboDoorType.EditValue <> Nothing Then
            Me.Vw_ERMTableAdapter.FillByErmDoorAndSubCat(Me.DreamyKitchenDataSet.vw_ERM, System.Guid.Parse(cboCategory.EditValue.ToString), System.Guid.Parse(cboDoorType.EditValue.ToString), System.Guid.Parse(cboCatSubErm.EditValue.ToString))
        End If
        'txtDoorPrice.EditValue = cboDoorType.GetColumnValue("price")
    End Sub

    Private Sub cboCatSubErm_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboCatSubErm.ButtonClick
        Select Case e.Button.Index
            Case 1 : ManageCATSUBERM()
            Case 2 : cboCatSubErm.EditValue = Nothing
        End Select
    End Sub
    Private Sub ManageCATSUBERM()
        Dim frmCatSubErm As frmCatSubErm = New frmCatSubErm
        frmCatSubErm.CallerControl = cboCatSubErm
        frmCatSubErm.CalledFromControl = True
        If cboCatSubErm.EditValue <> Nothing Then frmCatSubErm.ID = cboCatSubErm.EditValue.ToString
        frmCatSubErm.MdiParent = frmMain
        If cboCatSubErm.EditValue <> Nothing Then frmCatSubErm.Mode = FormMode.EditRecord Else frmCatSubErm.Mode = FormMode.NewRecord
        frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(frmCatSubErm), New Point(CInt(frmCatSubErm.Parent.ClientRectangle.Width / 2 - frmCatSubErm.Width / 2), CInt(frmCatSubErm.Parent.ClientRectangle.Height / 2 - frmCatSubErm.Height / 2)))
        frmCatSubErm.Show()
    End Sub


    Private Sub PictureEdit2_Click(sender As Object, e As EventArgs) Handles Pic1.Click
        If Pic1.BackColor = Color.White And Pic1.EditValue IsNot Nothing Then
            Pic1.BackColor = Color.Gray
            Pic1.BorderStyle = BorderStyles.Style3D
        Else
            Pic1.BackColor = Color.White
            Pic1.BorderStyle = BorderStyles.Default
        End If
    End Sub

    Private Sub PictureEdit21_Click(sender As Object, e As EventArgs) Handles Pic3.Click
        If Pic3.BackColor = Color.White And Pic3.EditValue IsNot Nothing Then
            Pic3.BackColor = Color.Gray
            Pic3.BorderStyle = BorderStyles.Style3D
        Else
            Pic3.BackColor = Color.White
            Pic3.BorderStyle = BorderStyles.Default
        End If
    End Sub

    Private Sub PictureEdit22_Click(sender As Object, e As EventArgs) Handles Pic2.Click
        If Pic2.BackColor = Color.White And Pic2.EditValue IsNot Nothing Then
            Pic2.BackColor = Color.Gray
            Pic2.BorderStyle = BorderStyles.Style3D
        Else
            Pic2.BackColor = Color.White
            Pic2.BorderStyle = BorderStyles.Default
        End If
    End Sub



    Private Sub cmdPrintOffer_Click(sender As Object, e As EventArgs) Handles cmdPrintOffer.Click
        Dim frmOffTotal As New frmOFFTotal
        frmOffTotal.Text = "Τελικά Σύνολα Προσφοράς"
        'frmOffTotal.MdiParent = frmMain
        frmOffTotal.ID = sID
        'frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(frmCatSubErm), New Point(CInt(Me.Parent.ClientRectangle.Width / 2 - Me.Width / 2), CInt(Me.Parent.ClientRectangle.Height / 2 - Me.Height / 2)))
        frmOffTotal.ShowDialog()

        Dim report As New Rep_offer()
        'Dim report3 As New RepOfferMech()
        'Dim myParameter As New Parameter()
        'myParameter.Type = GetType(String)
        'myParameter.Name = "OfferID"
        'myParameter.Value = sID
        'myParameter.Visible = False
        report.Parameters.Item(0).Value = sID
        report.CreateDocument()
        Dim report2 As New Rep_Offer2ndPage
        'report3.Parameters.Item(0).Value = sID
        report2.CreateDocument()
        report.ModifyDocument(Sub(x)
                                  x.AddPages(report2.Pages)
                              End Sub)
        'report2.Parameters.Item(0).Value = sID
        'report.Parameters.Add(myParameter)
        'report.RequestParameters = False
        Dim printTool As New ReportPrintTool(report)
        printTool.ShowRibbonPreview()

        ' Invoke the Ribbon Print Preview form modally 
        ' with the specified look and feel settings. 
        'printTool.ShowRibbonPreviewDialog(UserLookAndFeel.Default)

        ' Invoke the Print Preview form  
        ' and load the report document into it. 
        'printTool.ShowPreview()

        ' Invoke the Print Preview form modally 
        ' with the specified look and feel settings. 
        'printTool.ShowPreviewDialog(UserLookAndFeel.Default)

    End Sub

    'Private Sub chkMech_ItemCheck(sender As Object, e As ItemCheckEventArgs)
    '    Try
    '        Dim Total As String, MechItem As String, sCalc As Decimal
    '        Dim LItem As DevExpress.XtraEditors.CheckedListBoxControl = CType(sender, DevExpress.XtraEditors.CheckedListBoxControl)
    '        Dim chkLstItem As New DevExpress.XtraEditors.Controls.CheckedListBoxItem
    '        Dim bytes As Byte()
    '        chkLstItem = chkMech.Items.Item(chkMech.SelectedIndex)
    '        If chkLstItem.Tag = "" Then Exit Sub
    '        Dim cmd2 As SqlCommand = New SqlCommand("Select Photo,Price from vw_MECH where id ='" + chkLstItem.Tag + "'", CNDB)
    '        Dim sdr2 As SqlDataReader = cmd2.ExecuteReader()
    '        If (sdr2.Read() = True) Then
    '            Total = sdr2.GetDecimal(sdr2.GetOrdinal("Price"))
    '            Total = toSQLValueS(Total, True)
    '            If sdr2.IsDBNull(sdr2.GetOrdinal("Photo")) = False Then bytes = DirectCast(sdr2(sdr2.GetOrdinal("Photo")), Byte())
    '            sdr2.Close()
    '        End If
    '        If e.State = CheckState.Checked Then
    '            If LItem.Items(e.Index).CheckState = CheckState.Checked Then
    '                MechItem = toSQLValueS(txtTotalPrice.EditValue.ToString, True)
    '                MechPrice = MechPrice + MechItem
    '                Dim cmd As SqlCommand = New SqlCommand("Select " & MechItem + " + " + Total, CNDB)
    '                Dim sdr As SqlDataReader = cmd.ExecuteReader()
    '                If sdr.Read() = True Then sCalc = sdr.GetDecimal(0) : txtTotalPrice.EditValue = sCalc
    '                sdr.Close()
    '                If bytes.Length >= 0 Then
    '                    PicMech.EditValue = bytes
    '                Else
    '                    PicMech.EditValue = Nothing
    '                End If
    '            Else
    '                PicMech.EditValue = Nothing
    '            End If
    '        Else
    '            PicMech.EditValue = Nothing
    '            MechItem = toSQLValueS(txtTotalPrice.EditValue.ToString, True)
    '            Dim cmd As SqlCommand = New SqlCommand("Select " & MechItem + " - " + Total, CNDB)
    '            Dim sdr As SqlDataReader = cmd.ExecuteReader()
    '            If sdr.Read() = True Then sCalc = sdr.GetDecimal(0) : txtTotalPrice.EditValue = sCalc
    '            sdr.Close()
    '        End If
    '    Catch ex As Exception
    '        XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), "Dreamy Kitchen CRM", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End Try
    '    'MsgBox(Decimal.Parse(Regex.Replace(x, "[^\d]", "")))
    'End Sub


    Private Sub cmdOffersNew_Click(sender As Object, e As EventArgs) Handles cmdOffersNew.Click
        Cls.ClearCtrlsGRP(LayoutControlGroup2)
        sOffersID = ""
        LoadMech()
        txtTotalPrice.EditValue = "0,00"
        txtGrandTotal.EditValue = "0,00"
        txtHeight.ReadOnly = True
        txtWidth.ReadOnly = True
        txtDepth.ReadOnly = True
        cmdSave.Enabled = True
        chkDimChanged.Checked = False
        LayoutControlGroup2.Enabled = True
        Pic1.BackColor = Color.White : Pic2.BackColor = Color.White : Pic3.BackColor = Color.White
        'PicMech.EditValue = Nothing
        cboBENCH.EditValue = System.Guid.Parse("9B4F8F7D-115F-4A2D-9DD3-603A5DD19C52")
    End Sub

    Private Sub GridView1_PopupMenuShowing(sender As Object, e As DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs) Handles GridView1.PopupMenuShowing
        If e.MenuType = GridMenuType.Column Then
            Dim menu As DevExpress.XtraGrid.Menu.GridViewColumnMenu = TryCast(e.Menu, GridViewColumnMenu)
            Dim item As New DXEditMenuItem()
            Dim itemColor As New DXEditMenuItem()

            'menu.Items.Clear()
            If menu.Column IsNot Nothing Then
                'Για να προσθέσουμε menu item στο Default menu πρέπει πρώτα να προσθέσουμε ένα Repository Item 
                'Υπάρχουν πολλών ειδών Repositorys
                '1st Custom Menu Item
                Dim popRenameColumn As New RepositoryItemTextEdit
                popRenameColumn.Name = "RenameColumn"
                menu.Items.Add(New DXEditMenuItem("Μετονομασία Στήλης", popRenameColumn, AddressOf OnEditValueChanged, Nothing, Nothing, 100, 0))
                item = menu.Items.Item("Μετονομασία Στήλης")
                item.EditValue = menu.Column.GetTextCaption
                item.Tag = menu.Column.AbsoluteIndex

                '2nd Custom Menu Item
                menu.Items.Add(CreateCheckItem("Κλείδωμα Στήλης", menu.Column, Nothing))

                '3rd Custom Menu Item
                Dim popColorsColumn As New RepositoryItemColorEdit
                popColorsColumn.Name = "ColorsColumn"
                menu.Items.Add(New DXEditMenuItem("Χρώμα Στήλης", popColorsColumn, AddressOf OnColumnsColorChanged, Nothing, Nothing, 100, 0))
                itemColor = menu.Items.Item("Χρώμα Στήλης")
                itemColor.EditValue = menu.Column.AppearanceCell.BackColor
                itemColor.Tag = menu.Column.AbsoluteIndex

                '4nd Custom Menu Item
                menu.Items.Add(New DXMenuItem("Αποθήκευση όψης", AddressOf OnSaveViewErm, Nothing, Nothing, Nothing, Nothing))

            End If
        End If
    End Sub

    Private Sub GridView3_PopupMenuShowing(sender As Object, e As DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs) Handles GridView3.PopupMenuShowing
        If e.MenuType = GridMenuType.Column Then
            Dim menu As DevExpress.XtraGrid.Menu.GridViewColumnMenu = TryCast(e.Menu, GridViewColumnMenu)
            Dim item As New DXEditMenuItem()
            Dim itemColor As New DXEditMenuItem()

            'menu.Items.Clear()
            If menu.Column IsNot Nothing Then
                'Για να προσθέσουμε menu item στο Default menu πρέπει πρώτα να προσθέσουμε ένα Repository Item 
                'Υπάρχουν πολλών ειδών Repositorys
                '1st Custom Menu Item
                Dim popRenameColumn As New RepositoryItemTextEdit
                popRenameColumn.Name = "RenameColumn"
                menu.Items.Add(New DXEditMenuItem("Μετονομασία Στήλης", popRenameColumn, AddressOf OnEditValueChangedOff, Nothing, Nothing, 100, 0))
                item = menu.Items.Item("Μετονομασία Στήλης")
                item.EditValue = menu.Column.GetTextCaption
                item.Tag = menu.Column.AbsoluteIndex

                '2nd Custom Menu Item
                menu.Items.Add(CreateCheckItem("Κλείδωμα Στήλης", menu.Column, Nothing))

                '3rd Custom Menu Item
                Dim popColorsColumn As New RepositoryItemColorEdit
                popColorsColumn.Name = "ColorsColumn"
                menu.Items.Add(New DXEditMenuItem("Χρώμα Στήλης", popColorsColumn, AddressOf OnColumnsColorChangedOff, Nothing, Nothing, 100, 0))
                itemColor = menu.Items.Item("Χρώμα Στήλης")
                itemColor.EditValue = menu.Column.AppearanceCell.BackColor
                itemColor.Tag = menu.Column.AbsoluteIndex

                '4nd Custom Menu Item
                menu.Items.Add(New DXMenuItem("Αποθήκευση όψης", AddressOf OnSaveViewOff, Nothing, Nothing, Nothing, Nothing))

            End If
        End If
    End Sub
    Private Sub cmdTotalOffPrice_Click(sender As Object, e As EventArgs) Handles cmdTotalOffPrice.Click
        Dim frmOffTotal As New frmOFFTotal
        frmOffTotal.Text = "Τελικά Σύνολα Προσφοράς"
        'frmOffTotal.MdiParent = frmMain
        frmOffTotal.ID = sID
        'frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(frmCatSubErm), New Point(CInt(Me.Parent.ClientRectangle.Width / 2 - Me.Width / 2), CInt(Me.Parent.ClientRectangle.Height / 2 - Me.Height / 2)))
        frmOffTotal.ShowDialog()
    End Sub


    Private Sub cmdRecalc_Click(sender As Object, e As EventArgs) Handles cmdRecalc.Click
        Dim sSQL As String
        Try
            sSQL = "DELETE FROM OFF_TOTAL  WHERE offID = " & toSQLValueS(sID)
            Using oCmd As New SqlCommand(sSQL, CNDB)
                oCmd.ExecuteNonQuery()
            End Using

            sSQL = "INSERT INTO OFF_TOTAL (offID,subOffID, DoorTypeID, price, NewPrice,createdBy ,createdOn)
                    SELECT offID,subOffID, DoorTypeID, OfferPrice, OfferPrice," & toSQLValueS(UserProps.ID.ToString) & " ,getdate()
                    FROM   vw_OFF_TOTALPERDOOR S
                     WHERE offID = " & toSQLValueS(sID) & " and  NOT EXISTS (SELECT T.offid FROM   OFF_TOTAL  T WHERE  T.offid= " & toSQLValueS(sID) & " and t.DoorTypeID=s.DoorTypeID )"
            Using oCmd As New SqlCommand(sSQL, CNDB)
                oCmd.ExecuteNonQuery()
            End Using

        Catch ex As Exception

        End Try
    End Sub

    Private Sub GridView3_KeyDown(sender As Object, e As KeyEventArgs) Handles GridView3.KeyDown
        Select Case e.KeyCode
            Case Keys.F2  'If UserProps.AllowInsert = True Then NewRecord()
            Case Keys.F3 'If UserProps.AllowEdit = True Then EditRecord()
            Case Keys.F5  'DeleteOffers()
            Case Keys.Delete : DeleteOffersHandle()

        End Select
    End Sub
    Private Sub DeleteOffersHandle()
        Dim ID1 As String, ID2 As String, ID3 As String
        If UserProps.AllowDelete = True Then
            If GridView3.IsGroupRow(GridView3.FocusedRowHandle) Then
                If XtraMessageBox.Show("Θέλετε να διαγραφούν τα ερμάρια?", "Dreamy Kitchen CRM", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                    'Να ορίσω στο UI στα columns το FieldNameSortGroup να ειναι το ID της γραμμής
                    Select Case GridView3.GroupedColumns.Item(GridView3.GetRowLevel(GridView3.FocusedRowHandle)).FieldNameSortGroup
                        Case "subOffID"
                            ID1 = GridView3.GetRowCellValue(GridView3.GetDataRowHandleByGroupRowHandle(GridView3.FocusedRowHandle), "subOffID").ToString
                            DeleteOffersBasedSubOffer(ID1)
                        Case "DoorTypeID"
                            ID1 = GridView3.GetRowCellValue(GridView3.GetDataRowHandleByGroupRowHandle(GridView3.FocusedRowHandle), "subOffID").ToString
                            ID2 = GridView3.GetRowCellValue(GridView3.GetDataRowHandleByGroupRowHandle(GridView3.FocusedRowHandle), "DoorTypeID").ToString
                            DeleteOffersBasedSubOfferAndDoortype(ID1, ID2)
                        Case "catErmID"
                            ID1 = GridView3.GetRowCellValue(GridView3.GetDataRowHandleByGroupRowHandle(GridView3.FocusedRowHandle), "subOffID").ToString
                            ID2 = GridView3.GetRowCellValue(GridView3.GetDataRowHandleByGroupRowHandle(GridView3.FocusedRowHandle), "DoorTypeID").ToString
                            ID3 = GridView3.GetRowCellValue(GridView3.GetDataRowHandleByGroupRowHandle(GridView3.FocusedRowHandle), "catErmID").ToString
                            DeleteOffersBasedSubOfferDoortypeAndCatErm(ID1, ID2, ID3)
                        Case Else

                    End Select
                    Me.OFFERSTableAdapter.Fill(Me.DreamyKitchenDataSet.vw_OFFERS, System.Guid.Parse(sID))
                    Cls.ClearCtrlsGRP(LayoutControlGroup2)
                    cmdSave.Enabled = False
                End If
            Else
                DeleteOffers()
            End If
        End If
    End Sub

    Private Sub GridView2_PopupMenuShowing(sender As Object, e As DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs) Handles GridView2.PopupMenuShowing
        If e.MenuType = GridMenuType.Column Then
            Dim menu As DevExpress.XtraGrid.Menu.GridViewColumnMenu = TryCast(e.Menu, GridViewColumnMenu)
            Dim item As New DXEditMenuItem()
            Dim itemColor As New DXEditMenuItem()

            'menu.Items.Clear()
            If menu.Column IsNot Nothing Then
                'Για να προσθέσουμε menu item στο Default menu πρέπει πρώτα να προσθέσουμε ένα Repository Item 
                'Υπάρχουν πολλών ειδών Repositorys
                '1st Custom Menu Item
                Dim popRenameColumn As New RepositoryItemTextEdit
                popRenameColumn.Name = "RenameColumn"
                menu.Items.Add(New DXEditMenuItem("Μετονομασία Στήλης", popRenameColumn, AddressOf OnEditValueChangedMech, Nothing, Nothing, 100, 0))
                item = menu.Items.Item("Μετονομασία Στήλης")
                item.EditValue = menu.Column.GetTextCaption
                item.Tag = menu.Column.AbsoluteIndex

                '2nd Custom Menu Item
                menu.Items.Add(CreateCheckItem("Κλείδωμα Στήλης", menu.Column, Nothing))

                '3rd Custom Menu Item
                Dim popColorsColumn As New RepositoryItemColorEdit
                popColorsColumn.Name = "ColorsColumn"
                menu.Items.Add(New DXEditMenuItem("Χρώμα Στήλης", popColorsColumn, AddressOf OnColumnsColorChangedMech, Nothing, Nothing, 100, 0))
                itemColor = menu.Items.Item("Χρώμα Στήλης")
                itemColor.EditValue = menu.Column.AppearanceCell.BackColor
                itemColor.Tag = menu.Column.AbsoluteIndex

                '4nd Custom Menu Item
                menu.Items.Add(New DXMenuItem("Αποθήκευση όψης", AddressOf OnSaveViewMech, Nothing, Nothing, Nothing, Nothing))

            End If
        End If
    End Sub

    Private Sub GridView2_CellValueChanged(sender As Object, e As CellValueChangedEventArgs) Handles GridView2.CellValueChanged
        If e.Column.FieldName <> "QTY" Then Exit Sub
        Dim sCalc As Decimal
        Dim MechItem As String = GridView2.GetRowCellValue(GridView2.FocusedRowHandle, "PRICE").ToString
        Dim cmd As SqlCommand = New SqlCommand("Select " & e.Value & "*" & toSQLValueS(MechItem, True), CNDB)
        Dim sdr As SqlDataReader = cmd.ExecuteReader()
        If sdr.Read() = True Then sCalc = sdr.GetValue(0) : 
        GridView2.SetRowCellValue(GridView2.FocusedRowHandle, "TOTALPRICE", sCalc.ToString)

        sdr.Close()
    End Sub

    Private Sub GridView2_CustomDrawFooterCell(sender As Object, e As FooterCellCustomDrawEventArgs) Handles GridView2.CustomDrawFooterCell
        txtTotalPriceMech.EditValue = GridView2.Columns("TOTALPRICE").SummaryItem.SummaryValue
        If txtTotalPrice.Text = "0,00 €" Then txtTotalPrice.EditValue = "0.00"
        txtGrandTotal.EditValue = txtTotalPriceMech.EditValue + txtTotalPrice.EditValue
    End Sub

    Private Sub GridView2_CustomColumnDisplayText(sender As Object, e As CustomColumnDisplayTextEventArgs) Handles GridView2.CustomColumnDisplayText
        If e.Column.FieldName = "QTY" Then
            If e.DisplayText = "" Then e.DisplayText = "0"
        End If
    End Sub

    Private Sub cboBazaColors_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboBazaColors.ButtonClick
        Select Case e.Button.Index
            Case 1 : ManageBazaColors()
            Case 2 : cboBazaColors.EditValue = Nothing
        End Select
    End Sub

    Private Sub cboERM_EditValueChanged(sender As Object, e As EventArgs) Handles cboERM.EditValueChanged

    End Sub

    Private Sub cboERM_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboERM.ButtonClick
        Select Case e.Button.Index
            Case 1 : ManageErm()
            Case 2 : cboERM.EditValue = Nothing
        End Select
    End Sub
    Private Sub ManageErm()
        Dim frmErmaria As frmErmaria = New frmErmaria
        frmErmaria.CallerForm = "frmOffer"
        frmErmaria.CallerControl = cboERM
        frmErmaria.CalledFromControl = True
        If cboERM.EditValue <> Nothing Then frmErmaria.ID = cboERM.EditValue.ToString
        frmErmaria.MdiParent = frmMain
        If cboERM.EditValue <> Nothing Then frmErmaria.Mode = FormMode.EditRecord Else frmErmaria.Mode = FormMode.NewRecord
        frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(frmErmaria), New Point(CInt(frmErmaria.Parent.ClientRectangle.Width / 2 - frmErmaria.Width / 2), CInt(frmErmaria.Parent.ClientRectangle.Height / 2 - frmErmaria.Height / 2)))
        frmErmaria.Show()
    End Sub

    Private Sub cboOfferDetails_Click(sender As Object, e As EventArgs) Handles cmdOfferDetails.Click
        Dim frmOfferDet As New frmOfferDet
        frmOfferDet.Text = "Στοιχεία Προσφοράς"
        'frmOffTotal.MdiParent = frmMain
        frmOfferDet.ID = sID
        'frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(frmCatSubErm), New Point(CInt(Me.Parent.ClientRectangle.Width / 2 - Me.Width / 2), CInt(Me.Parent.ClientRectangle.Height / 2 - Me.Height / 2)))
        frmOfferDet.ShowDialog()
    End Sub

    Private Sub cmdOfferExport_Click(sender As Object, e As EventArgs) Handles cmdOfferExport.Click
        Dim options = New XlsxExportOptionsEx()
        options.UnboundExpressionExportMode = UnboundExpressionExportMode.AsFormula
        options.ExportType = ExportType.WYSIWYG
        XtraSaveFileDialog1.Filter = "XLSX Files (*.xlsx*)|*.xlsx"
        If XtraSaveFileDialog1.ShowDialog() = DialogResult.OK Then
            GridView3.GridControl.ExportToXlsx(XtraSaveFileDialog1.FileName, options)
            Process.Start(XtraSaveFileDialog1.FileName)
        End If
    End Sub

    Private Sub cmdCancelOff_Click(sender As Object, e As EventArgs) Handles cmdCancelOff.Click
        Try
            Dim sSQL As String
            If sID <> "" Then
                If XtraMessageBox.Show("Θέλετε να ακυρωθεί η προσφορά?", "Dreamy Kitchen CRM", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                    sSQL = "UPDATE [OFF] SET cancelOFF = 1 WHERE ID = " & toSQLValueS(sID)
                    Using oCmd As New SqlCommand(sSQL, CNDB)
                        oCmd.ExecuteNonQuery()
                    End Using
                End If
            End If
        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), "Dreamy Kitchen CRM", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cboSides_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboSides.ButtonClick
        Select Case e.Button.Index
            Case 1 : cboSides.EditValue = Nothing
        End Select

    End Sub

    Private Sub cboOpening_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboOpening.ButtonClick
        Select Case e.Button.Index
            Case 1 : cboOpening.EditValue = Nothing
        End Select
    End Sub


End Class