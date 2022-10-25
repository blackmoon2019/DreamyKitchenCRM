<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCUSOrderKitchen
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCUSOrderKitchen))
        Dim GridFormatRule1 As DevExpress.XtraGrid.GridFormatRule = New DevExpress.XtraGrid.GridFormatRule()
        Dim FormatConditionRuleExpression1 As DevExpress.XtraEditors.FormatConditionRuleExpression = New DevExpress.XtraEditors.FormatConditionRuleExpression()
        Me.coldCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.chkVatVisible = New DevExpress.XtraEditors.CheckEdit()
        Me.cmdExit = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdSave = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdPrintOffer = New DevExpress.XtraEditors.SimpleButton()
        Me.chkHangingOnDoors = New DevExpress.XtraEditors.CheckEdit()
        Me.chkHoodAlignment = New DevExpress.XtraEditors.CheckEdit()
        Me.cboVType = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.lblDate = New DevExpress.XtraEditors.LabelControl()
        Me.txtdtdaysOfDelivery = New DevExpress.XtraEditors.TextEdit()
        Me.txtbackCode = New DevExpress.XtraEditors.TextEdit()
        Me.cboCUS = New DevExpress.XtraEditors.LookUpEdit()
        Me.VwCCTBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DreamyKitchenDataSet = New DreamyKitchenCRM.DreamyKitchenDataSet()
        Me.txtCode = New DevExpress.XtraEditors.TextEdit()
        Me.txtPhn = New DevExpress.XtraEditors.TextEdit()
        Me.txtADR = New DevExpress.XtraEditors.TextEdit()
        Me.dtpresentation = New DevExpress.XtraEditors.DateEdit()
        Me.txtKFinalHeight = New DevExpress.XtraEditors.TextEdit()
        Me.txtOtherHeight = New DevExpress.XtraEditors.TextEdit()
        Me.txtYFinalHeight = New DevExpress.XtraEditors.TextEdit()
        Me.txtArea = New DevExpress.XtraEditors.TextEdit()
        Me.txtVShelves = New DevExpress.XtraEditors.TextEdit()
        Me.txtVdoorCode = New DevExpress.XtraEditors.TextEdit()
        Me.txtTotalErmariaVat = New DevExpress.XtraEditors.TextEdit()
        Me.txtTotalDevicesPrice = New DevExpress.XtraEditors.TextEdit()
        Me.txtTotalErmariaPice = New DevExpress.XtraEditors.TextEdit()
        Me.cboEMP = New DevExpress.XtraEditors.LookUpEdit()
        Me.VwSALERSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.cboVBOXColors = New DevExpress.XtraEditors.LookUpEdit()
        Me.VwCOLORSBOXBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.cboKBOXColors = New DevExpress.XtraEditors.LookUpEdit()
        Me.cboYBOXColors = New DevExpress.XtraEditors.LookUpEdit()
        Me.txtKHeight2 = New DevExpress.XtraEditors.TextEdit()
        Me.txtVFinalHeight = New DevExpress.XtraEditors.TextEdit()
        Me.cboGOLAColors = New DevExpress.XtraEditors.LookUpEdit()
        Me.VwCOLORSGOLABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.cboBaza = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.cboLegs = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.cboVwater = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.txtKHeight = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.txtKdoorCode = New DevExpress.XtraEditors.TextEdit()
        Me.cboKwater = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.cboLedProfil = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.txtKShelves = New DevExpress.XtraEditors.TextEdit()
        Me.cboYHeight = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.txtYdoorCode = New DevExpress.XtraEditors.TextEdit()
        Me.cboYwater = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.txtbenchCode = New DevExpress.XtraEditors.TextEdit()
        Me.cbobenchThickness = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.txtArea1 = New DevExpress.XtraEditors.TextEdit()
        Me.txtExtraTransp = New DevExpress.XtraEditors.TextEdit()
        Me.txtExtraInst = New DevExpress.XtraEditors.TextEdit()
        Me.txtPartofVat = New DevExpress.XtraEditors.TextEdit()
        Me.cboKType = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.cboYType = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.txtMeasurement = New DevExpress.XtraEditors.TextEdit()
        Me.txtRemove = New DevExpress.XtraEditors.TextEdit()
        Me.cboVependisisDoorType = New DevExpress.XtraEditors.LookUpEdit()
        Me.DOORTYPEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DMDataSet = New DreamyKitchenCRM.DMDataSet()
        Me.cboBenchType = New DevExpress.XtraEditors.LookUpEdit()
        Me.VwBENCHBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.cboBack = New DevExpress.XtraEditors.LookUpEdit()
        Me.cboBenchType2 = New DevExpress.XtraEditors.LookUpEdit()
        Me.txtYShelves = New DevExpress.XtraEditors.TextEdit()
        Me.cboNependisisDoorType = New DevExpress.XtraEditors.LookUpEdit()
        Me.VwDOORTYPEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.cboVDoorType = New DevExpress.XtraEditors.LookUpEdit()
        Me.VwDOORTYPE1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.cboVDoorType1 = New DevExpress.XtraEditors.LookUpEdit()
        Me.cboKDoorType = New DevExpress.XtraEditors.LookUpEdit()
        Me.cboKDoorType1 = New DevExpress.XtraEditors.LookUpEdit()
        Me.cboYDoorType = New DevExpress.XtraEditors.LookUpEdit()
        Me.cboYDoorType1 = New DevExpress.XtraEditors.LookUpEdit()
        Me.cboPependisisDoorType = New DevExpress.XtraEditors.LookUpEdit()
        Me.VwDOORTYPEPlainaYpsilaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.cboKependisisDoorType = New DevExpress.XtraEditors.LookUpEdit()
        Me.VwDOORTYPEPlainaKremastaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.cboSndEpendisisDoorType = New DevExpress.XtraEditors.LookUpEdit()
        Me.VwDOORTYPEPlainaKremasta2hsSeirasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.cboVRafieraDoorType = New DevExpress.XtraEditors.LookUpEdit()
        Me.VwDOORTYPERafieresVBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.cboKRafieraDoorType = New DevExpress.XtraEditors.LookUpEdit()
        Me.VwDOORTYPERafieresKBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.cboYRafieraDoorType = New DevExpress.XtraEditors.LookUpEdit()
        Me.VwDOORTYPERafieresYBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.cboKWallRafiaDoorType = New DevExpress.XtraEditors.LookUpEdit()
        Me.VwDOORTYPERafiaWallBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.cboTRANSH = New DevExpress.XtraEditors.LookUpEdit()
        Me.txtTransp = New DevExpress.XtraEditors.TextEdit()
        Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlGroup3 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem21 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem49 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem51 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem53 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem54 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem52 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem22 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem18 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem24 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem73 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem15 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem33 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem58 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup5 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem11 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem50 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem55 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem57 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem60 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem59 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem23 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem37 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem61 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem45 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem74 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem56 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem20 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem65 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem70 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup6 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem10 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem14 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem16 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem62 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem64 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem63 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem39 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem72 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem36 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem48 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem41 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem69 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup7 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem25 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem17 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem12 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem66 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem67 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem68 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem5 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem40 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem29 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem34 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem42 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem35 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem43 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem44 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem4 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem38 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem76 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem30 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem31 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem47 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem13 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem28 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem46 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem26 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem27 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem3 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem32 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.VwDOORTYPE1BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.VwCOLORSPVCBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TabPane1 = New DevExpress.XtraBars.Navigation.TabPane()
        Me.TabNavigationPage1 = New DevExpress.XtraBars.Navigation.TabNavigationPage()
        Me.TabNavigationPage2 = New DevExpress.XtraBars.Navigation.TabNavigationPage()
        Me.LayoutControl2 = New DevExpress.XtraLayout.LayoutControl()
        Me.cmdSaveEquipDev = New DevExpress.XtraEditors.SimpleButton()
        Me.grdDevices = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colchecked = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.grdEquipment = New DevExpress.XtraGrid.GridControl()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colcode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colname = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colprice = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepDefPrice = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.colmodifiedBy = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colmodifiedOn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colcreatedOn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colcreatedBy = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRealName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coldefPrice = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LayoutControlGroup4 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem19 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem71 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem75 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem6 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.VwDEVICESBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VwEQUIPMENTBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Vw_COLORSBOXTableAdapter = New DreamyKitchenCRM.DreamyKitchenDataSetTableAdapters.vw_COLORSBOXTableAdapter()
        Me.Vw_COLORSPVCTableAdapter = New DreamyKitchenCRM.DreamyKitchenDataSetTableAdapters.vw_COLORSPVCTableAdapter()
        Me.Vw_COLORSGOLATableAdapter = New DreamyKitchenCRM.DreamyKitchenDataSetTableAdapters.vw_COLORSGOLATableAdapter()
        Me.Vw_EQUIPMENTTableAdapter = New DreamyKitchenCRM.DreamyKitchenDataSetTableAdapters.vw_EQUIPMENTTableAdapter()
        Me.Vw_DEVICESTableAdapter = New DreamyKitchenCRM.DreamyKitchenDataSetTableAdapters.vw_DEVICESTableAdapter()
        Me.Vw_SALERSTableAdapter = New DreamyKitchenCRM.DreamyKitchenDataSetTableAdapters.vw_SALERSTableAdapter()
        Me.Vw_CCTTableAdapter = New DreamyKitchenCRM.DreamyKitchenDataSetTableAdapters.vw_CCTTableAdapter()
        Me.DOOR_TYPETableAdapter = New DreamyKitchenCRM.DMDataSetTableAdapters.DOOR_TYPETableAdapter()
        Me.Vw_DOOR_TYPETableAdapter1 = New DreamyKitchenCRM.DMDataSetTableAdapters.vw_DOOR_TYPETableAdapter()
        Me.Vw_DOOR_TYPE1TableAdapter = New DreamyKitchenCRM.DMDataSetTableAdapters.vw_DOOR_TYPE1TableAdapter()
        Me.Vw_DOOR_TYPEPlainaYpsilaTableAdapter = New DreamyKitchenCRM.DMDataSetTableAdapters.vw_DOOR_TYPEPlainaYpsilaTableAdapter()
        Me.Vw_BENCHTableAdapter = New DreamyKitchenCRM.DreamyKitchenDataSetTableAdapters.vw_BENCHTableAdapter()
        Me.Vw_DOOR_TYPEPlainaKremastaTableAdapter = New DreamyKitchenCRM.DMDataSetTableAdapters.vw_DOOR_TYPEPlainaKremastaTableAdapter()
        Me.Vw_DOOR_TYPERafieresVTableAdapter = New DreamyKitchenCRM.DMDataSetTableAdapters.vw_DOOR_TYPERafieresVTableAdapter()
        Me.Vw_DOOR_TYPERafieresKTableAdapter = New DreamyKitchenCRM.DMDataSetTableAdapters.vw_DOOR_TYPERafieresKTableAdapter()
        Me.Vw_DOOR_TYPERafieresYTableAdapter = New DreamyKitchenCRM.DMDataSetTableAdapters.vw_DOOR_TYPERafieresYTableAdapter()
        Me.Vw_DOOR_TYPERafiaWallTableAdapter = New DreamyKitchenCRM.DMDataSetTableAdapters.vw_DOOR_TYPERafiaWallTableAdapter()
        Me.Vw_DOOR_TYPEPlainaKremasta2hsSeirasTableAdapter = New DreamyKitchenCRM.DMDataSetTableAdapters.vw_DOOR_TYPEPlainaKremasta2hsSeirasTableAdapter()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.chkVatVisible.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkHangingOnDoors.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkHoodAlignment.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboVType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtdtdaysOfDelivery.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtbackCode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboCUS.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VwCCTBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DreamyKitchenDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPhn.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtADR.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpresentation.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpresentation.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtKFinalHeight.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtOtherHeight.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtYFinalHeight.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtArea.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtVShelves.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtVdoorCode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTotalErmariaVat.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTotalDevicesPrice.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTotalErmariaPice.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboEMP.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VwSALERSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboVBOXColors.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VwCOLORSBOXBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboKBOXColors.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboYBOXColors.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtKHeight2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtVFinalHeight.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboGOLAColors.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VwCOLORSGOLABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboBaza.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboLegs.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboVwater.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtKHeight.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtKdoorCode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboKwater.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboLedProfil.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtKShelves.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboYHeight.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtYdoorCode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboYwater.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtbenchCode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbobenchThickness.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtArea1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtExtraTransp.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtExtraInst.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPartofVat.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboKType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboYType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMeasurement.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRemove.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboVependisisDoorType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DOORTYPEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DMDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboBenchType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VwBENCHBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboBack.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboBenchType2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtYShelves.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboNependisisDoorType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VwDOORTYPEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboVDoorType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VwDOORTYPE1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboVDoorType1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboKDoorType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboKDoorType1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboYDoorType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboYDoorType1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboPependisisDoorType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VwDOORTYPEPlainaYpsilaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboKependisisDoorType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VwDOORTYPEPlainaKremastaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboSndEpendisisDoorType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VwDOORTYPEPlainaKremasta2hsSeirasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboVRafieraDoorType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VwDOORTYPERafieresVBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboKRafieraDoorType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VwDOORTYPERafieresKBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboYRafieraDoorType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VwDOORTYPERafieresYBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboKWallRafiaDoorType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VwDOORTYPERafiaWallBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboTRANSH.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTransp.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem21, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem49, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem51, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem53, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem54, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem52, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem22, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem18, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem24, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem73, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem33, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem58, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem50, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem55, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem57, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem60, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem59, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem23, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem37, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem61, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem45, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem74, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem56, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem20, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem65, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem70, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem62, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem64, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem63, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem39, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem72, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem36, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem48, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem41, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem69, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem25, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem17, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem66, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem67, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem68, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem40, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem29, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem34, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem42, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem35, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem43, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem44, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem38, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem76, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem30, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem31, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem47, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem28, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem46, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem26, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem27, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem32, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VwDOORTYPE1BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VwCOLORSPVCBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TabPane1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPane1.SuspendLayout()
        Me.TabNavigationPage1.SuspendLayout()
        Me.TabNavigationPage2.SuspendLayout()
        CType(Me.LayoutControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl2.SuspendLayout()
        CType(Me.grdDevices, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdEquipment, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepDefPrice, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem19, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem71, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem75, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VwDEVICESBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VwEQUIPMENTBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'coldCode
        '
        Me.coldCode.Caption = "ΚΩΔ.ΣΥΣΚΕΥΗΣ"
        Me.coldCode.FieldName = "dCode"
        Me.coldCode.MinWidth = 33
        Me.coldCode.Name = "coldCode"
        Me.coldCode.Visible = True
        Me.coldCode.VisibleIndex = 2
        Me.coldCode.Width = 160
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.chkVatVisible)
        Me.LayoutControl1.Controls.Add(Me.cmdExit)
        Me.LayoutControl1.Controls.Add(Me.cmdSave)
        Me.LayoutControl1.Controls.Add(Me.cmdPrintOffer)
        Me.LayoutControl1.Controls.Add(Me.chkHangingOnDoors)
        Me.LayoutControl1.Controls.Add(Me.chkHoodAlignment)
        Me.LayoutControl1.Controls.Add(Me.cboVType)
        Me.LayoutControl1.Controls.Add(Me.lblDate)
        Me.LayoutControl1.Controls.Add(Me.txtdtdaysOfDelivery)
        Me.LayoutControl1.Controls.Add(Me.txtbackCode)
        Me.LayoutControl1.Controls.Add(Me.cboCUS)
        Me.LayoutControl1.Controls.Add(Me.txtCode)
        Me.LayoutControl1.Controls.Add(Me.txtPhn)
        Me.LayoutControl1.Controls.Add(Me.txtADR)
        Me.LayoutControl1.Controls.Add(Me.dtpresentation)
        Me.LayoutControl1.Controls.Add(Me.txtKFinalHeight)
        Me.LayoutControl1.Controls.Add(Me.txtOtherHeight)
        Me.LayoutControl1.Controls.Add(Me.txtYFinalHeight)
        Me.LayoutControl1.Controls.Add(Me.txtArea)
        Me.LayoutControl1.Controls.Add(Me.txtVShelves)
        Me.LayoutControl1.Controls.Add(Me.txtVdoorCode)
        Me.LayoutControl1.Controls.Add(Me.txtTotalErmariaVat)
        Me.LayoutControl1.Controls.Add(Me.txtTotalDevicesPrice)
        Me.LayoutControl1.Controls.Add(Me.txtTotalErmariaPice)
        Me.LayoutControl1.Controls.Add(Me.cboEMP)
        Me.LayoutControl1.Controls.Add(Me.cboVBOXColors)
        Me.LayoutControl1.Controls.Add(Me.cboKBOXColors)
        Me.LayoutControl1.Controls.Add(Me.cboYBOXColors)
        Me.LayoutControl1.Controls.Add(Me.txtKHeight2)
        Me.LayoutControl1.Controls.Add(Me.txtVFinalHeight)
        Me.LayoutControl1.Controls.Add(Me.cboGOLAColors)
        Me.LayoutControl1.Controls.Add(Me.cboBaza)
        Me.LayoutControl1.Controls.Add(Me.cboLegs)
        Me.LayoutControl1.Controls.Add(Me.cboVwater)
        Me.LayoutControl1.Controls.Add(Me.txtKHeight)
        Me.LayoutControl1.Controls.Add(Me.txtKdoorCode)
        Me.LayoutControl1.Controls.Add(Me.cboKwater)
        Me.LayoutControl1.Controls.Add(Me.cboLedProfil)
        Me.LayoutControl1.Controls.Add(Me.txtKShelves)
        Me.LayoutControl1.Controls.Add(Me.cboYHeight)
        Me.LayoutControl1.Controls.Add(Me.txtYdoorCode)
        Me.LayoutControl1.Controls.Add(Me.cboYwater)
        Me.LayoutControl1.Controls.Add(Me.txtbenchCode)
        Me.LayoutControl1.Controls.Add(Me.cbobenchThickness)
        Me.LayoutControl1.Controls.Add(Me.txtArea1)
        Me.LayoutControl1.Controls.Add(Me.txtExtraTransp)
        Me.LayoutControl1.Controls.Add(Me.txtExtraInst)
        Me.LayoutControl1.Controls.Add(Me.txtPartofVat)
        Me.LayoutControl1.Controls.Add(Me.cboKType)
        Me.LayoutControl1.Controls.Add(Me.cboYType)
        Me.LayoutControl1.Controls.Add(Me.txtMeasurement)
        Me.LayoutControl1.Controls.Add(Me.txtRemove)
        Me.LayoutControl1.Controls.Add(Me.cboVependisisDoorType)
        Me.LayoutControl1.Controls.Add(Me.cboBenchType)
        Me.LayoutControl1.Controls.Add(Me.cboBack)
        Me.LayoutControl1.Controls.Add(Me.cboBenchType2)
        Me.LayoutControl1.Controls.Add(Me.txtYShelves)
        Me.LayoutControl1.Controls.Add(Me.cboNependisisDoorType)
        Me.LayoutControl1.Controls.Add(Me.cboVDoorType)
        Me.LayoutControl1.Controls.Add(Me.cboVDoorType1)
        Me.LayoutControl1.Controls.Add(Me.cboKDoorType)
        Me.LayoutControl1.Controls.Add(Me.cboKDoorType1)
        Me.LayoutControl1.Controls.Add(Me.cboYDoorType)
        Me.LayoutControl1.Controls.Add(Me.cboYDoorType1)
        Me.LayoutControl1.Controls.Add(Me.cboPependisisDoorType)
        Me.LayoutControl1.Controls.Add(Me.cboKependisisDoorType)
        Me.LayoutControl1.Controls.Add(Me.cboSndEpendisisDoorType)
        Me.LayoutControl1.Controls.Add(Me.cboVRafieraDoorType)
        Me.LayoutControl1.Controls.Add(Me.cboKRafieraDoorType)
        Me.LayoutControl1.Controls.Add(Me.cboYRafieraDoorType)
        Me.LayoutControl1.Controls.Add(Me.cboKWallRafiaDoorType)
        Me.LayoutControl1.Controls.Add(Me.cboTRANSH)
        Me.LayoutControl1.Controls.Add(Me.txtTransp)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Margin = New System.Windows.Forms.Padding(5)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(1871, 549, 1121, 1339)
        Me.LayoutControl1.Root = Me.Root
        Me.LayoutControl1.Size = New System.Drawing.Size(1885, 1414)
        Me.LayoutControl1.TabIndex = 2
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'chkVatVisible
        '
        Me.chkVatVisible.EditValue = CType(0, Byte)
        Me.chkVatVisible.Location = New System.Drawing.Point(116, 1281)
        Me.chkVatVisible.Margin = New System.Windows.Forms.Padding(5)
        Me.chkVatVisible.Name = "chkVatVisible"
        Me.chkVatVisible.Properties.Caption = "Εμφάνιση ΦΠΑ στην εκτύπωση"
        Me.chkVatVisible.Properties.ValueChecked = CType(1, Byte)
        Me.chkVatVisible.Properties.ValueUnchecked = CType(0, Byte)
        Me.chkVatVisible.Size = New System.Drawing.Size(307, 35)
        Me.chkVatVisible.StyleController = Me.LayoutControl1
        Me.chkVatVisible.TabIndex = 65
        Me.chkVatVisible.Tag = "visibleVAT,0,1,2"
        '
        'cmdExit
        '
        Me.cmdExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdExit.ImageOptions.Image = CType(resources.GetObject("cmdExit.ImageOptions.Image"), System.Drawing.Image)
        Me.cmdExit.Location = New System.Drawing.Point(1691, 1281)
        Me.cmdExit.Margin = New System.Windows.Forms.Padding(5)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(182, 39)
        Me.cmdExit.StyleController = Me.LayoutControl1
        Me.cmdExit.TabIndex = 21
        Me.cmdExit.Text = "Έξοδος"
        '
        'cmdSave
        '
        Me.cmdSave.ImageOptions.Image = CType(resources.GetObject("cmdSave.ImageOptions.Image"), System.Drawing.Image)
        Me.cmdSave.Location = New System.Drawing.Point(1527, 1281)
        Me.cmdSave.Margin = New System.Windows.Forms.Padding(5)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(160, 39)
        Me.cmdSave.StyleController = Me.LayoutControl1
        Me.cmdSave.TabIndex = 61
        Me.cmdSave.Text = "Αποθήκευση"
        '
        'cmdPrintOffer
        '
        Me.cmdPrintOffer.Location = New System.Drawing.Point(12, 1281)
        Me.cmdPrintOffer.Margin = New System.Windows.Forms.Padding(5)
        Me.cmdPrintOffer.Name = "cmdPrintOffer"
        Me.cmdPrintOffer.Size = New System.Drawing.Size(100, 39)
        Me.cmdPrintOffer.StyleController = Me.LayoutControl1
        Me.cmdPrintOffer.TabIndex = 56
        Me.cmdPrintOffer.Text = "Εκτύπωση"
        '
        'chkHangingOnDoors
        '
        Me.chkHangingOnDoors.EditValue = CType(0, Byte)
        Me.chkHangingOnDoors.Location = New System.Drawing.Point(668, 764)
        Me.chkHangingOnDoors.Margin = New System.Windows.Forms.Padding(5)
        Me.chkHangingOnDoors.Name = "chkHangingOnDoors"
        Me.chkHangingOnDoors.Properties.Appearance.BackColor = System.Drawing.Color.LightSlateGray
        Me.chkHangingOnDoors.Properties.Appearance.ForeColor = System.Drawing.Color.White
        Me.chkHangingOnDoors.Properties.Appearance.Options.UseBackColor = True
        Me.chkHangingOnDoors.Properties.Appearance.Options.UseForeColor = True
        Me.chkHangingOnDoors.Properties.Caption = "Κρέμαση στα πορτάκια"
        Me.chkHangingOnDoors.Properties.Tag = "dimChanged"
        Me.chkHangingOnDoors.Properties.ValueChecked = CType(1, Byte)
        Me.chkHangingOnDoors.Properties.ValueUnchecked = CType(0, Byte)
        Me.chkHangingOnDoors.Size = New System.Drawing.Size(296, 35)
        Me.chkHangingOnDoors.StyleController = Me.LayoutControl1
        Me.chkHangingOnDoors.TabIndex = 59
        Me.chkHangingOnDoors.Tag = "HangingOnDoors,0,1,2"
        '
        'chkHoodAlignment
        '
        Me.chkHoodAlignment.EditValue = CType(0, Byte)
        Me.chkHoodAlignment.Location = New System.Drawing.Point(968, 764)
        Me.chkHoodAlignment.Margin = New System.Windows.Forms.Padding(5)
        Me.chkHoodAlignment.Name = "chkHoodAlignment"
        Me.chkHoodAlignment.Properties.Appearance.BackColor = System.Drawing.Color.LightSlateGray
        Me.chkHoodAlignment.Properties.Appearance.ForeColor = System.Drawing.Color.White
        Me.chkHoodAlignment.Properties.Appearance.Options.UseBackColor = True
        Me.chkHoodAlignment.Properties.Appearance.Options.UseForeColor = True
        Me.chkHoodAlignment.Properties.Caption = "Ευθυγράμμιση αποροφητήρα"
        Me.chkHoodAlignment.Properties.Tag = "dimChanged"
        Me.chkHoodAlignment.Properties.ValueChecked = CType(1, Byte)
        Me.chkHoodAlignment.Properties.ValueUnchecked = CType(0, Byte)
        Me.chkHoodAlignment.Size = New System.Drawing.Size(296, 35)
        Me.chkHoodAlignment.StyleController = Me.LayoutControl1
        Me.chkHoodAlignment.TabIndex = 58
        Me.chkHoodAlignment.Tag = "HoodAlignment,0,1,2"
        '
        'cboVType
        '
        Me.cboVType.Location = New System.Drawing.Point(333, 382)
        Me.cboVType.Margin = New System.Windows.Forms.Padding(5)
        Me.cboVType.Name = "cboVType"
        Me.cboVType.Properties.AllowMouseWheel = False
        Me.cboVType.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Clear)})
        Me.cboVType.Properties.Items.AddRange(New Object() {"Απλό 72cm", "Gola 75cm"})
        Me.cboVType.Properties.Tag = "opening"
        Me.cboVType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboVType.Size = New System.Drawing.Size(305, 38)
        Me.cboVType.StyleController = Me.LayoutControl1
        Me.cboVType.TabIndex = 57
        Me.cboVType.Tag = "VType,0,1,2"
        '
        'lblDate
        '
        Me.lblDate.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.lblDate.Appearance.ForeColor = System.Drawing.SystemColors.Highlight
        Me.lblDate.Appearance.Options.UseFont = True
        Me.lblDate.Appearance.Options.UseForeColor = True
        Me.lblDate.Location = New System.Drawing.Point(1563, 187)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(297, 25)
        Me.lblDate.StyleController = Me.LayoutControl1
        Me.lblDate.TabIndex = 51
        Me.lblDate.Text = "(ΗΗ/ΜΜ/ΕΕΕ)                        "
        '
        'txtdtdaysOfDelivery
        '
        Me.txtdtdaysOfDelivery.Location = New System.Drawing.Point(994, 187)
        Me.txtdtdaysOfDelivery.Margin = New System.Windows.Forms.Padding(5)
        Me.txtdtdaysOfDelivery.Name = "txtdtdaysOfDelivery"
        Me.txtdtdaysOfDelivery.Properties.UseReadOnlyAppearance = False
        Me.txtdtdaysOfDelivery.Size = New System.Drawing.Size(565, 38)
        Me.txtdtdaysOfDelivery.StyleController = Me.LayoutControl1
        Me.txtdtdaysOfDelivery.TabIndex = 50
        Me.txtdtdaysOfDelivery.Tag = "daysofdeliver,0,1,2"
        '
        'txtbackCode
        '
        Me.txtbackCode.Location = New System.Drawing.Point(178, 1077)
        Me.txtbackCode.Margin = New System.Windows.Forms.Padding(5)
        Me.txtbackCode.Name = "txtbackCode"
        Me.txtbackCode.Properties.UseReadOnlyAppearance = False
        Me.txtbackCode.Size = New System.Drawing.Size(339, 38)
        Me.txtbackCode.StyleController = Me.LayoutControl1
        Me.txtbackCode.TabIndex = 44
        Me.txtbackCode.Tag = "backCode,0,1,2"
        '
        'cboCUS
        '
        Me.cboCUS.Location = New System.Drawing.Point(320, 103)
        Me.cboCUS.Margin = New System.Windows.Forms.Padding(5)
        Me.cboCUS.Name = "cboCUS"
        Me.cboCUS.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.cboCUS.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Search), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Clear)})
        Me.cboCUS.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 35, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("code", "code", 55, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Fullname", "Όνομα", 91, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CouID", "Cou ID", 73, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("AreaID", "Area ID", 79, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("AdrID", "Adr ID", 70, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("SourceID", "Source ID", 99, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("SalerID", "Saler ID", 83, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("DoyID", "Doy ID", 73, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("PrfID", "Prf ID", 64, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("phn", "Τηλέφωνο", 48, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("mob", "mob", 52, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("fax", "fax", 40, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("email", "email", 59, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("afm", "afm", 47, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("cmt", "cmt", 46, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("modifiedBy", "modified By", 113, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("modifiedOn", "modified On", 117, DevExpress.Utils.FormatType.DateTime, "d/M/yyyy", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("createdOn", "created On", 108, DevExpress.Utils.FormatType.DateTime, "d/M/yyyy", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("name", "name", 62, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("RealName", "Real Name", 106, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("COU_Name", "COU_Name", 110, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("SRC_Name", "SRC_Name", 108, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("AREAS_Name", "AREAS_Name", 130, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ADR_Name", "ADR_Name", 110, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("PRF_Name", "PRF_Name", 106, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("SALERS_Name", "SALERS_Name", 139, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("color", "color", 55, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Ar", "Ar", 33, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("tk", "tk", 31, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("createdby_Realname", "createdby_Realname", 191, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("HasFiles", "Has Files", 88, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("createdBy", "created By", 104, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default])})
        Me.cboCUS.Properties.DataSource = Me.VwCCTBindingSource
        Me.cboCUS.Properties.DisplayMember = "Fullname"
        Me.cboCUS.Properties.NullText = ""
        Me.cboCUS.Properties.PopupSizeable = False
        Me.cboCUS.Properties.ValueMember = "ID"
        Me.cboCUS.Size = New System.Drawing.Size(620, 38)
        Me.cboCUS.StyleController = Me.LayoutControl1
        Me.cboCUS.TabIndex = 5
        Me.cboCUS.Tag = "cusID,0,1,2"
        '
        'VwCCTBindingSource
        '
        Me.VwCCTBindingSource.DataMember = "vw_CCT"
        Me.VwCCTBindingSource.DataSource = Me.DreamyKitchenDataSet
        '
        'DreamyKitchenDataSet
        '
        Me.DreamyKitchenDataSet.DataSetName = "DreamyKitchenDataSet"
        Me.DreamyKitchenDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txtCode
        '
        Me.txtCode.Location = New System.Drawing.Point(320, 61)
        Me.txtCode.Margin = New System.Windows.Forms.Padding(5)
        Me.txtCode.Name = "txtCode"
        Me.txtCode.Properties.Appearance.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.txtCode.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtCode.Properties.Appearance.Options.UseBackColor = True
        Me.txtCode.Properties.Appearance.Options.UseFont = True
        Me.txtCode.Properties.ReadOnly = True
        Me.txtCode.Size = New System.Drawing.Size(107, 38)
        Me.txtCode.StyleController = Me.LayoutControl1
        Me.txtCode.TabIndex = 4
        Me.txtCode.Tag = "code,0"
        '
        'txtPhn
        '
        Me.txtPhn.Location = New System.Drawing.Point(320, 145)
        Me.txtPhn.Margin = New System.Windows.Forms.Padding(5)
        Me.txtPhn.Name = "txtPhn"
        Me.txtPhn.Properties.ReadOnly = True
        Me.txtPhn.Properties.UseReadOnlyAppearance = False
        Me.txtPhn.Size = New System.Drawing.Size(228, 38)
        Me.txtPhn.StyleController = Me.LayoutControl1
        Me.txtPhn.TabIndex = 23
        Me.txtPhn.Tag = "phn"
        '
        'txtADR
        '
        Me.txtADR.Location = New System.Drawing.Point(847, 145)
        Me.txtADR.Margin = New System.Windows.Forms.Padding(5)
        Me.txtADR.Name = "txtADR"
        Me.txtADR.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.txtADR.Properties.ReadOnly = True
        Me.txtADR.Properties.UseReadOnlyAppearance = False
        Me.txtADR.Size = New System.Drawing.Size(404, 38)
        Me.txtADR.StyleController = Me.LayoutControl1
        Me.txtADR.TabIndex = 7
        Me.txtADR.Tag = "ADR_name"
        '
        'dtpresentation
        '
        Me.dtpresentation.EditValue = Nothing
        Me.dtpresentation.Location = New System.Drawing.Point(320, 187)
        Me.dtpresentation.Margin = New System.Windows.Forms.Padding(5)
        Me.dtpresentation.Name = "dtpresentation"
        Me.dtpresentation.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtpresentation.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtpresentation.Size = New System.Drawing.Size(375, 38)
        Me.dtpresentation.StyleController = Me.LayoutControl1
        Me.dtpresentation.TabIndex = 32
        Me.dtpresentation.Tag = "dtOffer,0,1,2"
        '
        'txtKFinalHeight
        '
        Me.txtKFinalHeight.EditValue = "0,00 €"
        Me.txtKFinalHeight.Location = New System.Drawing.Point(963, 340)
        Me.txtKFinalHeight.Margin = New System.Windows.Forms.Padding(5)
        Me.txtKFinalHeight.Name = "txtKFinalHeight"
        Me.txtKFinalHeight.Properties.DisplayFormat.FormatString = "n"
        Me.txtKFinalHeight.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtKFinalHeight.Properties.EditFormat.FormatString = "n2"
        Me.txtKFinalHeight.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtKFinalHeight.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtKFinalHeight.Properties.MaskSettings.Set("MaskManagerType", GetType(DevExpress.Data.Mask.NumericMaskManager))
        Me.txtKFinalHeight.Properties.MaskSettings.Set("mask", "n2")
        Me.txtKFinalHeight.Size = New System.Drawing.Size(301, 38)
        Me.txtKFinalHeight.StyleController = Me.LayoutControl1
        Me.txtKFinalHeight.TabIndex = 42
        Me.txtKFinalHeight.Tag = "KFinalHeight,0,1,2"
        '
        'txtOtherHeight
        '
        Me.txtOtherHeight.EditValue = "0,00 €"
        Me.txtOtherHeight.Location = New System.Drawing.Point(1589, 424)
        Me.txtOtherHeight.Margin = New System.Windows.Forms.Padding(5)
        Me.txtOtherHeight.Name = "txtOtherHeight"
        Me.txtOtherHeight.Properties.DisplayFormat.FormatString = "n"
        Me.txtOtherHeight.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtOtherHeight.Properties.EditFormat.FormatString = "n2"
        Me.txtOtherHeight.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtOtherHeight.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtOtherHeight.Properties.MaskSettings.Set("MaskManagerType", GetType(DevExpress.Data.Mask.NumericMaskManager))
        Me.txtOtherHeight.Properties.MaskSettings.Set("mask", "n2")
        Me.txtOtherHeight.Properties.ReadOnly = True
        Me.txtOtherHeight.Size = New System.Drawing.Size(258, 38)
        Me.txtOtherHeight.StyleController = Me.LayoutControl1
        Me.txtOtherHeight.TabIndex = 42
        Me.txtOtherHeight.Tag = "OtherHeight,0,1,2"
        '
        'txtYFinalHeight
        '
        Me.txtYFinalHeight.EditValue = "0,00 €"
        Me.txtYFinalHeight.Location = New System.Drawing.Point(1589, 340)
        Me.txtYFinalHeight.Margin = New System.Windows.Forms.Padding(5)
        Me.txtYFinalHeight.Name = "txtYFinalHeight"
        Me.txtYFinalHeight.Properties.DisplayFormat.FormatString = "n"
        Me.txtYFinalHeight.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtYFinalHeight.Properties.EditFormat.FormatString = "n2"
        Me.txtYFinalHeight.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtYFinalHeight.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtYFinalHeight.Properties.MaskSettings.Set("MaskManagerType", GetType(DevExpress.Data.Mask.NumericMaskManager))
        Me.txtYFinalHeight.Properties.MaskSettings.Set("mask", "n2")
        Me.txtYFinalHeight.Size = New System.Drawing.Size(258, 38)
        Me.txtYFinalHeight.StyleController = Me.LayoutControl1
        Me.txtYFinalHeight.TabIndex = 42
        Me.txtYFinalHeight.Tag = "YFinalHeight,0,1,2"
        '
        'txtArea
        '
        Me.txtArea.Location = New System.Drawing.Point(1550, 145)
        Me.txtArea.Margin = New System.Windows.Forms.Padding(5)
        Me.txtArea.Name = "txtArea"
        Me.txtArea.Properties.ReadOnly = True
        Me.txtArea.Properties.UseReadOnlyAppearance = False
        Me.txtArea.Size = New System.Drawing.Size(310, 38)
        Me.txtArea.StyleController = Me.LayoutControl1
        Me.txtArea.TabIndex = 23
        Me.txtArea.Tag = "mob"
        '
        'txtVShelves
        '
        Me.txtVShelves.Location = New System.Drawing.Point(333, 890)
        Me.txtVShelves.Margin = New System.Windows.Forms.Padding(5)
        Me.txtVShelves.Name = "txtVShelves"
        Me.txtVShelves.Properties.UseReadOnlyAppearance = False
        Me.txtVShelves.Size = New System.Drawing.Size(305, 38)
        Me.txtVShelves.StyleController = Me.LayoutControl1
        Me.txtVShelves.TabIndex = 10
        Me.txtVShelves.Tag = "VShelves,0,1,2"
        '
        'txtVdoorCode
        '
        Me.txtVdoorCode.Location = New System.Drawing.Point(331, 804)
        Me.txtVdoorCode.Margin = New System.Windows.Forms.Padding(5)
        Me.txtVdoorCode.Name = "txtVdoorCode"
        Me.txtVdoorCode.Properties.UseReadOnlyAppearance = False
        Me.txtVdoorCode.Size = New System.Drawing.Size(306, 38)
        Me.txtVdoorCode.StyleController = Me.LayoutControl1
        Me.txtVdoorCode.TabIndex = 44
        Me.txtVdoorCode.Tag = "VdoorCode,0,1,2"
        '
        'txtTotalErmariaVat
        '
        Me.txtTotalErmariaVat.EditValue = "0,00 €"
        Me.txtTotalErmariaVat.Location = New System.Drawing.Point(1674, 1134)
        Me.txtTotalErmariaVat.Margin = New System.Windows.Forms.Padding(5)
        Me.txtTotalErmariaVat.Name = "txtTotalErmariaVat"
        Me.txtTotalErmariaVat.Properties.DisplayFormat.FormatString = "c"
        Me.txtTotalErmariaVat.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtTotalErmariaVat.Properties.EditFormat.FormatString = "n2"
        Me.txtTotalErmariaVat.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtTotalErmariaVat.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtTotalErmariaVat.Properties.MaskSettings.Set("MaskManagerType", GetType(DevExpress.Data.Mask.NumericMaskManager))
        Me.txtTotalErmariaVat.Properties.MaskSettings.Set("mask", "c2")
        Me.txtTotalErmariaVat.Properties.Tag = "BenchExtraPrice"
        Me.txtTotalErmariaVat.Properties.UseReadOnlyAppearance = False
        Me.txtTotalErmariaVat.Size = New System.Drawing.Size(186, 38)
        Me.txtTotalErmariaVat.StyleController = Me.LayoutControl1
        Me.txtTotalErmariaVat.TabIndex = 42
        Me.txtTotalErmariaVat.Tag = "TotalErmariaVat,0,1,2"
        Me.txtTotalErmariaVat.Visible = False
        '
        'txtTotalDevicesPrice
        '
        Me.txtTotalDevicesPrice.EditValue = "0,00 €"
        Me.txtTotalDevicesPrice.Location = New System.Drawing.Point(1674, 1222)
        Me.txtTotalDevicesPrice.Margin = New System.Windows.Forms.Padding(5)
        Me.txtTotalDevicesPrice.Name = "txtTotalDevicesPrice"
        Me.txtTotalDevicesPrice.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.txtTotalDevicesPrice.Properties.Appearance.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.txtTotalDevicesPrice.Properties.Appearance.Options.UseFont = True
        Me.txtTotalDevicesPrice.Properties.Appearance.Options.UseForeColor = True
        Me.txtTotalDevicesPrice.Properties.DisplayFormat.FormatString = "c"
        Me.txtTotalDevicesPrice.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtTotalDevicesPrice.Properties.EditFormat.FormatString = "n2"
        Me.txtTotalDevicesPrice.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtTotalDevicesPrice.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtTotalDevicesPrice.Properties.MaskSettings.Set("MaskManagerType", GetType(DevExpress.Data.Mask.NumericMaskManager))
        Me.txtTotalDevicesPrice.Properties.MaskSettings.Set("mask", "c2")
        Me.txtTotalDevicesPrice.Properties.ReadOnly = True
        Me.txtTotalDevicesPrice.Properties.Tag = "BenchExtraPrice"
        Me.txtTotalDevicesPrice.Properties.UseReadOnlyAppearance = False
        Me.txtTotalDevicesPrice.Size = New System.Drawing.Size(186, 42)
        Me.txtTotalDevicesPrice.StyleController = Me.LayoutControl1
        Me.txtTotalDevicesPrice.TabIndex = 42
        Me.txtTotalDevicesPrice.Tag = "TotalEquipmentPrice,0,1,2"
        Me.txtTotalDevicesPrice.Visible = False
        '
        'txtTotalErmariaPice
        '
        Me.txtTotalErmariaPice.EditValue = "0,00 €"
        Me.txtTotalErmariaPice.Location = New System.Drawing.Point(1674, 1176)
        Me.txtTotalErmariaPice.Margin = New System.Windows.Forms.Padding(5)
        Me.txtTotalErmariaPice.Name = "txtTotalErmariaPice"
        Me.txtTotalErmariaPice.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.txtTotalErmariaPice.Properties.Appearance.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.txtTotalErmariaPice.Properties.Appearance.Options.UseFont = True
        Me.txtTotalErmariaPice.Properties.Appearance.Options.UseForeColor = True
        Me.txtTotalErmariaPice.Properties.DisplayFormat.FormatString = "c"
        Me.txtTotalErmariaPice.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtTotalErmariaPice.Properties.EditFormat.FormatString = "n2"
        Me.txtTotalErmariaPice.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtTotalErmariaPice.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtTotalErmariaPice.Properties.MaskSettings.Set("MaskManagerType", GetType(DevExpress.Data.Mask.NumericMaskManager))
        Me.txtTotalErmariaPice.Properties.MaskSettings.Set("mask", "c2")
        Me.txtTotalErmariaPice.Properties.ReadOnly = True
        Me.txtTotalErmariaPice.Properties.Tag = "BenchExtraPrice"
        Me.txtTotalErmariaPice.Properties.UseReadOnlyAppearance = False
        Me.txtTotalErmariaPice.Size = New System.Drawing.Size(186, 42)
        Me.txtTotalErmariaPice.StyleController = Me.LayoutControl1
        Me.txtTotalErmariaPice.TabIndex = 42
        Me.txtTotalErmariaPice.Tag = "TotalErmariaPice,0,1,2"
        Me.txtTotalErmariaPice.Visible = False
        '
        'cboEMP
        '
        Me.cboEMP.Location = New System.Drawing.Point(726, 61)
        Me.cboEMP.Margin = New System.Windows.Forms.Padding(5)
        Me.cboEMP.Name = "cboEMP"
        Me.cboEMP.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.cboEMP.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Search), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Clear)})
        Me.cboEMP.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 35, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("code", "code", 55, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("color", "color", 55, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("RealName", "Real Name", 106, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("name", "Πωλητής", 62, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default])})
        Me.cboEMP.Properties.DataSource = Me.VwSALERSBindingSource
        Me.cboEMP.Properties.DisplayMember = "name"
        Me.cboEMP.Properties.NullText = ""
        Me.cboEMP.Properties.PopupSizeable = False
        Me.cboEMP.Properties.ValueMember = "ID"
        Me.cboEMP.Size = New System.Drawing.Size(452, 38)
        Me.cboEMP.StyleController = Me.LayoutControl1
        Me.cboEMP.TabIndex = 5
        Me.cboEMP.Tag = "empID,0,1,2"
        '
        'VwSALERSBindingSource
        '
        Me.VwSALERSBindingSource.DataMember = "vw_SALERS"
        Me.VwSALERSBindingSource.DataSource = Me.DreamyKitchenDataSet
        '
        'cboVBOXColors
        '
        Me.cboVBOXColors.EditValue = ""
        Me.cboVBOXColors.Location = New System.Drawing.Point(333, 466)
        Me.cboVBOXColors.Margin = New System.Windows.Forms.Padding(5)
        Me.cboVBOXColors.Name = "cboVBOXColors"
        Me.cboVBOXColors.Properties.AllowMouseWheel = False
        Me.cboVBOXColors.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Search), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Clear)})
        Me.cboVBOXColors.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 35, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("name", "Χρώμα", 62, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("photo", "photo", 63, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default])})
        Me.cboVBOXColors.Properties.DataSource = Me.VwCOLORSBOXBindingSource
        Me.cboVBOXColors.Properties.DisplayMember = "name"
        Me.cboVBOXColors.Properties.NullText = ""
        Me.cboVBOXColors.Properties.ValueMember = "ID"
        Me.cboVBOXColors.Size = New System.Drawing.Size(305, 38)
        Me.cboVBOXColors.StyleController = Me.LayoutControl1
        Me.cboVBOXColors.TabIndex = 45
        Me.cboVBOXColors.Tag = "VBoxColorID,0,1,2"
        '
        'VwCOLORSBOXBindingSource
        '
        Me.VwCOLORSBOXBindingSource.DataMember = "vw_COLORSBOX"
        Me.VwCOLORSBOXBindingSource.DataSource = Me.DreamyKitchenDataSet
        '
        'cboKBOXColors
        '
        Me.cboKBOXColors.EditValue = ""
        Me.cboKBOXColors.Location = New System.Drawing.Point(963, 466)
        Me.cboKBOXColors.Margin = New System.Windows.Forms.Padding(5)
        Me.cboKBOXColors.Name = "cboKBOXColors"
        Me.cboKBOXColors.Properties.AllowMouseWheel = False
        Me.cboKBOXColors.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Search), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Clear)})
        Me.cboKBOXColors.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 35, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("name", "Χρώμα", 62, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("photo", "photo", 63, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default])})
        Me.cboKBOXColors.Properties.DataSource = Me.VwCOLORSBOXBindingSource
        Me.cboKBOXColors.Properties.DisplayMember = "name"
        Me.cboKBOXColors.Properties.NullText = ""
        Me.cboKBOXColors.Properties.ValueMember = "ID"
        Me.cboKBOXColors.Size = New System.Drawing.Size(301, 38)
        Me.cboKBOXColors.StyleController = Me.LayoutControl1
        Me.cboKBOXColors.TabIndex = 45
        Me.cboKBOXColors.Tag = "KBoxColorID,0,1,2"
        '
        'cboYBOXColors
        '
        Me.cboYBOXColors.EditValue = ""
        Me.cboYBOXColors.Location = New System.Drawing.Point(1589, 508)
        Me.cboYBOXColors.Margin = New System.Windows.Forms.Padding(5)
        Me.cboYBOXColors.Name = "cboYBOXColors"
        Me.cboYBOXColors.Properties.AllowMouseWheel = False
        Me.cboYBOXColors.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Search), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Clear)})
        Me.cboYBOXColors.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 35, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("name", "Χρώμα", 62, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("photo", "photo", 63, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default])})
        Me.cboYBOXColors.Properties.DataSource = Me.VwCOLORSBOXBindingSource
        Me.cboYBOXColors.Properties.DisplayMember = "name"
        Me.cboYBOXColors.Properties.NullText = ""
        Me.cboYBOXColors.Properties.ValueMember = "ID"
        Me.cboYBOXColors.Size = New System.Drawing.Size(258, 38)
        Me.cboYBOXColors.StyleController = Me.LayoutControl1
        Me.cboYBOXColors.TabIndex = 45
        Me.cboYBOXColors.Tag = "YBoxColorID,0,1,2"
        '
        'txtKHeight2
        '
        Me.txtKHeight2.EditValue = "0,00 €"
        Me.txtKHeight2.Location = New System.Drawing.Point(1170, 382)
        Me.txtKHeight2.Margin = New System.Windows.Forms.Padding(5)
        Me.txtKHeight2.Name = "txtKHeight2"
        Me.txtKHeight2.Properties.DisplayFormat.FormatString = "n"
        Me.txtKHeight2.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtKHeight2.Properties.EditFormat.FormatString = "n2"
        Me.txtKHeight2.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtKHeight2.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtKHeight2.Properties.MaskSettings.Set("MaskManagerType", GetType(DevExpress.Data.Mask.NumericMaskManager))
        Me.txtKHeight2.Properties.MaskSettings.Set("mask", "n2")
        Me.txtKHeight2.Size = New System.Drawing.Size(94, 38)
        Me.txtKHeight2.StyleController = Me.LayoutControl1
        Me.txtKHeight2.TabIndex = 42
        Me.txtKHeight2.Tag = "KHeight2,0,1,2"
        '
        'txtVFinalHeight
        '
        Me.txtVFinalHeight.EditValue = "0,00 €"
        Me.txtVFinalHeight.Location = New System.Drawing.Point(333, 340)
        Me.txtVFinalHeight.Margin = New System.Windows.Forms.Padding(5)
        Me.txtVFinalHeight.Name = "txtVFinalHeight"
        Me.txtVFinalHeight.Properties.DisplayFormat.FormatString = "n"
        Me.txtVFinalHeight.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtVFinalHeight.Properties.EditFormat.FormatString = "n2"
        Me.txtVFinalHeight.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtVFinalHeight.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtVFinalHeight.Properties.MaskSettings.Set("MaskManagerType", GetType(DevExpress.Data.Mask.NumericMaskManager))
        Me.txtVFinalHeight.Properties.MaskSettings.Set("mask", "n2")
        Me.txtVFinalHeight.Size = New System.Drawing.Size(305, 38)
        Me.txtVFinalHeight.StyleController = Me.LayoutControl1
        Me.txtVFinalHeight.TabIndex = 42
        Me.txtVFinalHeight.Tag = "VFinalHeight,0,1,2"
        '
        'cboGOLAColors
        '
        Me.cboGOLAColors.EditValue = ""
        Me.cboGOLAColors.Location = New System.Drawing.Point(333, 424)
        Me.cboGOLAColors.Margin = New System.Windows.Forms.Padding(5)
        Me.cboGOLAColors.Name = "cboGOLAColors"
        Me.cboGOLAColors.Properties.AllowMouseWheel = False
        Me.cboGOLAColors.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Search), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Clear)})
        Me.cboGOLAColors.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 35, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("name", "Χρώμα", 62, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("photo", "photo", 63, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default])})
        Me.cboGOLAColors.Properties.DataSource = Me.VwCOLORSGOLABindingSource
        Me.cboGOLAColors.Properties.DisplayMember = "name"
        Me.cboGOLAColors.Properties.NullText = ""
        Me.cboGOLAColors.Properties.ReadOnly = True
        Me.cboGOLAColors.Properties.ValueMember = "ID"
        Me.cboGOLAColors.Size = New System.Drawing.Size(305, 38)
        Me.cboGOLAColors.StyleController = Me.LayoutControl1
        Me.cboGOLAColors.TabIndex = 45
        Me.cboGOLAColors.Tag = "VGolaColorID,0,1,2"
        '
        'VwCOLORSGOLABindingSource
        '
        Me.VwCOLORSGOLABindingSource.DataMember = "vw_COLORSGOLA"
        Me.VwCOLORSGOLABindingSource.DataSource = Me.DreamyKitchenDataSet
        '
        'cboBaza
        '
        Me.cboBaza.Location = New System.Drawing.Point(333, 676)
        Me.cboBaza.Margin = New System.Windows.Forms.Padding(5)
        Me.cboBaza.Name = "cboBaza"
        Me.cboBaza.Properties.AllowMouseWheel = False
        Me.cboBaza.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Clear)})
        Me.cboBaza.Properties.Items.AddRange(New Object() {"Ίνοξ", "Μάυρη", "Άσπρη"})
        Me.cboBaza.Properties.Tag = "opening"
        Me.cboBaza.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboBaza.Size = New System.Drawing.Size(305, 38)
        Me.cboBaza.StyleController = Me.LayoutControl1
        Me.cboBaza.TabIndex = 57
        Me.cboBaza.Tag = "Baza,0,1,2"
        '
        'cboLegs
        '
        Me.cboLegs.Location = New System.Drawing.Point(333, 718)
        Me.cboLegs.Margin = New System.Windows.Forms.Padding(5)
        Me.cboLegs.Name = "cboLegs"
        Me.cboLegs.Properties.AllowMouseWheel = False
        Me.cboLegs.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Clear)})
        Me.cboLegs.Properties.Items.AddRange(New Object() {"10cm", "12cm", "15cm"})
        Me.cboLegs.Properties.Tag = "opening"
        Me.cboLegs.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboLegs.Size = New System.Drawing.Size(305, 38)
        Me.cboLegs.StyleController = Me.LayoutControl1
        Me.cboLegs.TabIndex = 57
        Me.cboLegs.Tag = "Legs,0,1,2"
        '
        'cboVwater
        '
        Me.cboVwater.Location = New System.Drawing.Point(333, 760)
        Me.cboVwater.Margin = New System.Windows.Forms.Padding(5)
        Me.cboVwater.Name = "cboVwater"
        Me.cboVwater.Properties.AllowMouseWheel = False
        Me.cboVwater.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Clear)})
        Me.cboVwater.Properties.Items.AddRange(New Object() {"ΚΑΘΕΤΑ", "ΟΡΙΖΟΝΤΙΑ"})
        Me.cboVwater.Properties.Tag = "opening"
        Me.cboVwater.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboVwater.Size = New System.Drawing.Size(305, 38)
        Me.cboVwater.StyleController = Me.LayoutControl1
        Me.cboVwater.TabIndex = 57
        Me.cboVwater.Tag = "Vwater,0,1,2"
        '
        'txtKHeight
        '
        Me.txtKHeight.EditValue = ""
        Me.txtKHeight.Location = New System.Drawing.Point(963, 382)
        Me.txtKHeight.Margin = New System.Windows.Forms.Padding(5)
        Me.txtKHeight.Name = "txtKHeight"
        Me.txtKHeight.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtKHeight.Properties.Items.AddRange(New Object() {"36cm", "48cm", "60cm", "72cm", "80cm", "90cm", "96cm", "120cm"})
        Me.txtKHeight.Size = New System.Drawing.Size(111, 38)
        Me.txtKHeight.StyleController = Me.LayoutControl1
        Me.txtKHeight.TabIndex = 42
        Me.txtKHeight.Tag = "KHeight,0,1,2"
        '
        'txtKdoorCode
        '
        Me.txtKdoorCode.Location = New System.Drawing.Point(961, 678)
        Me.txtKdoorCode.Margin = New System.Windows.Forms.Padding(5)
        Me.txtKdoorCode.Name = "txtKdoorCode"
        Me.txtKdoorCode.Properties.UseReadOnlyAppearance = False
        Me.txtKdoorCode.Size = New System.Drawing.Size(302, 38)
        Me.txtKdoorCode.StyleController = Me.LayoutControl1
        Me.txtKdoorCode.TabIndex = 44
        Me.txtKdoorCode.Tag = "KdoorCode,0,1,2"
        '
        'cboKwater
        '
        Me.cboKwater.Location = New System.Drawing.Point(963, 722)
        Me.cboKwater.Margin = New System.Windows.Forms.Padding(5)
        Me.cboKwater.Name = "cboKwater"
        Me.cboKwater.Properties.AllowMouseWheel = False
        Me.cboKwater.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Clear)})
        Me.cboKwater.Properties.Items.AddRange(New Object() {"ΚΑΘΕΤΑ", "ΟΡΙΖΟΝΤΙΑ"})
        Me.cboKwater.Properties.Tag = "opening"
        Me.cboKwater.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboKwater.Size = New System.Drawing.Size(301, 38)
        Me.cboKwater.StyleController = Me.LayoutControl1
        Me.cboKwater.TabIndex = 57
        Me.cboKwater.Tag = "Kwater,0,1,2"
        '
        'cboLedProfil
        '
        Me.cboLedProfil.Location = New System.Drawing.Point(963, 803)
        Me.cboLedProfil.Margin = New System.Windows.Forms.Padding(5)
        Me.cboLedProfil.Name = "cboLedProfil"
        Me.cboLedProfil.Properties.AllowMouseWheel = False
        Me.cboLedProfil.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Clear)})
        Me.cboLedProfil.Properties.Items.AddRange(New Object() {"ΜΠΡΟΣΤΑ", "ΠΙΣΩ", "ΜΕΣΗ"})
        Me.cboLedProfil.Properties.Tag = "opening"
        Me.cboLedProfil.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboLedProfil.Size = New System.Drawing.Size(301, 38)
        Me.cboLedProfil.StyleController = Me.LayoutControl1
        Me.cboLedProfil.TabIndex = 57
        Me.cboLedProfil.Tag = "LedProfil,0,1,2"
        '
        'txtKShelves
        '
        Me.txtKShelves.Location = New System.Drawing.Point(963, 887)
        Me.txtKShelves.Margin = New System.Windows.Forms.Padding(5)
        Me.txtKShelves.Name = "txtKShelves"
        Me.txtKShelves.Properties.UseReadOnlyAppearance = False
        Me.txtKShelves.Size = New System.Drawing.Size(301, 38)
        Me.txtKShelves.StyleController = Me.LayoutControl1
        Me.txtKShelves.TabIndex = 10
        Me.txtKShelves.Tag = "KShelves,0,1,2"
        '
        'cboYHeight
        '
        Me.cboYHeight.EditValue = ""
        Me.cboYHeight.Location = New System.Drawing.Point(1589, 382)
        Me.cboYHeight.Margin = New System.Windows.Forms.Padding(5)
        Me.cboYHeight.Name = "cboYHeight"
        Me.cboYHeight.Properties.AllowMouseWheel = False
        Me.cboYHeight.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboYHeight.Properties.Items.AddRange(New Object() {"135cm", "209cm", "232cm", "Άλλο"})
        Me.cboYHeight.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboYHeight.Size = New System.Drawing.Size(258, 38)
        Me.cboYHeight.StyleController = Me.LayoutControl1
        Me.cboYHeight.TabIndex = 42
        Me.cboYHeight.Tag = "YHeight,0,1,2"
        '
        'txtYdoorCode
        '
        Me.txtYdoorCode.Location = New System.Drawing.Point(1587, 678)
        Me.txtYdoorCode.Margin = New System.Windows.Forms.Padding(5)
        Me.txtYdoorCode.Name = "txtYdoorCode"
        Me.txtYdoorCode.Properties.UseReadOnlyAppearance = False
        Me.txtYdoorCode.Size = New System.Drawing.Size(259, 38)
        Me.txtYdoorCode.StyleController = Me.LayoutControl1
        Me.txtYdoorCode.TabIndex = 44
        Me.txtYdoorCode.Tag = "YdoorCode,0,1,2"
        '
        'cboYwater
        '
        Me.cboYwater.Location = New System.Drawing.Point(1589, 722)
        Me.cboYwater.Margin = New System.Windows.Forms.Padding(5)
        Me.cboYwater.Name = "cboYwater"
        Me.cboYwater.Properties.AllowMouseWheel = False
        Me.cboYwater.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Clear)})
        Me.cboYwater.Properties.Items.AddRange(New Object() {"ΚΑΘΕΤΑ", "ΟΡΙΖΟΝΤΙΑ"})
        Me.cboYwater.Properties.Tag = "opening"
        Me.cboYwater.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboYwater.Size = New System.Drawing.Size(258, 38)
        Me.cboYwater.StyleController = Me.LayoutControl1
        Me.cboYwater.TabIndex = 57
        Me.cboYwater.Tag = "Ywater,0,1,2"
        '
        'txtbenchCode
        '
        Me.txtbenchCode.Location = New System.Drawing.Point(178, 1033)
        Me.txtbenchCode.Margin = New System.Windows.Forms.Padding(5)
        Me.txtbenchCode.Name = "txtbenchCode"
        Me.txtbenchCode.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.txtbenchCode.Properties.Tag = "benchID"
        Me.txtbenchCode.Size = New System.Drawing.Size(340, 38)
        Me.txtbenchCode.StyleController = Me.LayoutControl1
        Me.txtbenchCode.TabIndex = 21
        Me.txtbenchCode.Tag = "benchCode,0,1,2"
        '
        'cbobenchThickness
        '
        Me.cbobenchThickness.Location = New System.Drawing.Point(1539, 1033)
        Me.cbobenchThickness.Margin = New System.Windows.Forms.Padding(5)
        Me.cbobenchThickness.Name = "cbobenchThickness"
        Me.cbobenchThickness.Properties.AllowMouseWheel = False
        Me.cbobenchThickness.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Clear)})
        Me.cbobenchThickness.Properties.Items.AddRange(New Object() {"2cm", "4cm"})
        Me.cbobenchThickness.Properties.Tag = "opening"
        Me.cbobenchThickness.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cbobenchThickness.Size = New System.Drawing.Size(308, 38)
        Me.cbobenchThickness.StyleController = Me.LayoutControl1
        Me.cbobenchThickness.TabIndex = 57
        Me.cbobenchThickness.Tag = "benchThickness,0,1,2"
        '
        'txtArea1
        '
        Me.txtArea1.Location = New System.Drawing.Point(1477, 61)
        Me.txtArea1.Margin = New System.Windows.Forms.Padding(5)
        Me.txtArea1.Name = "txtArea1"
        Me.txtArea1.Properties.UseReadOnlyAppearance = False
        Me.txtArea1.Size = New System.Drawing.Size(263, 38)
        Me.txtArea1.StyleController = Me.LayoutControl1
        Me.txtArea1.TabIndex = 23
        Me.txtArea1.Tag = "arProt,0,1,2"
        '
        'txtExtraTransp
        '
        Me.txtExtraTransp.EditValue = "0,00 €"
        Me.txtExtraTransp.Location = New System.Drawing.Point(1207, 1134)
        Me.txtExtraTransp.Margin = New System.Windows.Forms.Padding(5)
        Me.txtExtraTransp.Name = "txtExtraTransp"
        Me.txtExtraTransp.Properties.DisplayFormat.FormatString = "c"
        Me.txtExtraTransp.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtExtraTransp.Properties.EditFormat.FormatString = "n2"
        Me.txtExtraTransp.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtExtraTransp.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtExtraTransp.Properties.MaskSettings.Set("MaskManagerType", GetType(DevExpress.Data.Mask.NumericMaskManager))
        Me.txtExtraTransp.Properties.MaskSettings.Set("mask", "c2")
        Me.txtExtraTransp.Properties.Tag = "BenchExtraPrice"
        Me.txtExtraTransp.Properties.UseReadOnlyAppearance = False
        Me.txtExtraTransp.Size = New System.Drawing.Size(168, 38)
        Me.txtExtraTransp.StyleController = Me.LayoutControl1
        Me.txtExtraTransp.TabIndex = 42
        Me.txtExtraTransp.Tag = "ExtraTransp,0,1,2"
        Me.txtExtraTransp.Visible = False
        '
        'txtExtraInst
        '
        Me.txtExtraInst.EditValue = "0,00 €"
        Me.txtExtraInst.Location = New System.Drawing.Point(1207, 1176)
        Me.txtExtraInst.Margin = New System.Windows.Forms.Padding(5)
        Me.txtExtraInst.Name = "txtExtraInst"
        Me.txtExtraInst.Properties.DisplayFormat.FormatString = "c"
        Me.txtExtraInst.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtExtraInst.Properties.EditFormat.FormatString = "n2"
        Me.txtExtraInst.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtExtraInst.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtExtraInst.Properties.MaskSettings.Set("MaskManagerType", GetType(DevExpress.Data.Mask.NumericMaskManager))
        Me.txtExtraInst.Properties.MaskSettings.Set("mask", "c2")
        Me.txtExtraInst.Properties.Tag = "BenchExtraPrice"
        Me.txtExtraInst.Properties.UseReadOnlyAppearance = False
        Me.txtExtraInst.Size = New System.Drawing.Size(168, 38)
        Me.txtExtraInst.StyleController = Me.LayoutControl1
        Me.txtExtraInst.TabIndex = 42
        Me.txtExtraInst.Tag = "ExtraInst,0,1,2"
        Me.txtExtraInst.Visible = False
        '
        'txtPartofVat
        '
        Me.txtPartofVat.EditValue = "0,00 €"
        Me.txtPartofVat.Location = New System.Drawing.Point(1207, 1218)
        Me.txtPartofVat.Margin = New System.Windows.Forms.Padding(5)
        Me.txtPartofVat.Name = "txtPartofVat"
        Me.txtPartofVat.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.txtPartofVat.Properties.Appearance.ForeColor = System.Drawing.Color.DarkRed
        Me.txtPartofVat.Properties.Appearance.Options.UseFont = True
        Me.txtPartofVat.Properties.Appearance.Options.UseForeColor = True
        Me.txtPartofVat.Properties.DisplayFormat.FormatString = "c"
        Me.txtPartofVat.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtPartofVat.Properties.EditFormat.FormatString = "n2"
        Me.txtPartofVat.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtPartofVat.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtPartofVat.Properties.MaskSettings.Set("MaskManagerType", GetType(DevExpress.Data.Mask.NumericMaskManager))
        Me.txtPartofVat.Properties.MaskSettings.Set("mask", "c2")
        Me.txtPartofVat.Properties.Tag = "BenchExtraPrice"
        Me.txtPartofVat.Properties.UseReadOnlyAppearance = False
        Me.txtPartofVat.Size = New System.Drawing.Size(168, 42)
        Me.txtPartofVat.StyleController = Me.LayoutControl1
        Me.txtPartofVat.TabIndex = 42
        Me.txtPartofVat.Tag = "PartOfVat,0,1,2"
        Me.txtPartofVat.Visible = False
        '
        'cboKType
        '
        Me.cboKType.Location = New System.Drawing.Point(963, 424)
        Me.cboKType.Margin = New System.Windows.Forms.Padding(5)
        Me.cboKType.Name = "cboKType"
        Me.cboKType.Properties.AllowMouseWheel = False
        Me.cboKType.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Clear)})
        Me.cboKType.Properties.Items.AddRange(New Object() {"Απλό 72cm", "Gola 75cm"})
        Me.cboKType.Properties.Tag = "opening"
        Me.cboKType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboKType.Size = New System.Drawing.Size(301, 38)
        Me.cboKType.StyleController = Me.LayoutControl1
        Me.cboKType.TabIndex = 57
        Me.cboKType.Tag = "KType,0,1,2"
        '
        'cboYType
        '
        Me.cboYType.Location = New System.Drawing.Point(1589, 466)
        Me.cboYType.Margin = New System.Windows.Forms.Padding(5)
        Me.cboYType.Name = "cboYType"
        Me.cboYType.Properties.AllowMouseWheel = False
        Me.cboYType.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Clear)})
        Me.cboYType.Properties.Items.AddRange(New Object() {"Απλό 72cm", "Gola 75cm"})
        Me.cboYType.Properties.Tag = "opening"
        Me.cboYType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboYType.Size = New System.Drawing.Size(258, 38)
        Me.cboYType.StyleController = Me.LayoutControl1
        Me.cboYType.TabIndex = 57
        Me.cboYType.Tag = "YType,0,1,2"
        '
        'txtMeasurement
        '
        Me.txtMeasurement.EditValue = "0,00 €"
        Me.txtMeasurement.Location = New System.Drawing.Point(735, 1134)
        Me.txtMeasurement.Margin = New System.Windows.Forms.Padding(5)
        Me.txtMeasurement.Name = "txtMeasurement"
        Me.txtMeasurement.Properties.DisplayFormat.FormatString = "c"
        Me.txtMeasurement.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtMeasurement.Properties.EditFormat.FormatString = "n2"
        Me.txtMeasurement.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtMeasurement.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtMeasurement.Properties.MaskSettings.Set("MaskManagerType", GetType(DevExpress.Data.Mask.NumericMaskManager))
        Me.txtMeasurement.Properties.MaskSettings.Set("mask", "c2")
        Me.txtMeasurement.Properties.Tag = "BenchExtraPrice"
        Me.txtMeasurement.Size = New System.Drawing.Size(173, 38)
        Me.txtMeasurement.StyleController = Me.LayoutControl1
        Me.txtMeasurement.TabIndex = 42
        Me.txtMeasurement.Tag = "measurement,0,1,2"
        Me.txtMeasurement.Visible = False
        '
        'txtRemove
        '
        Me.txtRemove.EditValue = "0,00 €"
        Me.txtRemove.Location = New System.Drawing.Point(735, 1176)
        Me.txtRemove.Margin = New System.Windows.Forms.Padding(5)
        Me.txtRemove.Name = "txtRemove"
        Me.txtRemove.Properties.DisplayFormat.FormatString = "c"
        Me.txtRemove.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtRemove.Properties.EditFormat.FormatString = "n2"
        Me.txtRemove.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtRemove.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtRemove.Properties.MaskSettings.Set("MaskManagerType", GetType(DevExpress.Data.Mask.NumericMaskManager))
        Me.txtRemove.Properties.MaskSettings.Set("mask", "c2")
        Me.txtRemove.Properties.Tag = "BenchExtraPrice"
        Me.txtRemove.Size = New System.Drawing.Size(173, 38)
        Me.txtRemove.StyleController = Me.LayoutControl1
        Me.txtRemove.TabIndex = 42
        Me.txtRemove.Tag = "remove,0,1,2"
        Me.txtRemove.Visible = False
        '
        'cboVependisisDoorType
        '
        Me.cboVependisisDoorType.Location = New System.Drawing.Point(333, 592)
        Me.cboVependisisDoorType.Margin = New System.Windows.Forms.Padding(5)
        Me.cboVependisisDoorType.Name = "cboVependisisDoorType"
        Me.cboVependisisDoorType.Properties.AllowMouseWheel = False
        Me.cboVependisisDoorType.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.cboVependisisDoorType.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Search), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Clear)})
        Me.cboVependisisDoorType.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 35, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("cat", "Κατηγορία", 30, DevExpress.Utils.FormatType.Numeric, "", True, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("name", "Υλικό", 100, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("dimName", "Διάσταση", 35, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Price", "Τιμή", 30, DevExpress.Utils.FormatType.Numeric, "c2", True, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("code", "code", 55, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CustomCode", "Custom Code", 125, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("color", "color", 55, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("doorColorID", "door Color ID", 127, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("doorType", "door Type", 100, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("closetType", "closet Type", 109, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("dimID", "dim ID", 72, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("doorCatID", "door Cat ID", 112, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("type", "type", 51, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("kasa", "kasa", 52, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("comments", "comments", 101, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("modifiedBy", "modified By", 113, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("modifiedOn", "modified On", 117, DevExpress.Utils.FormatType.DateTime, "d/M/yyyy", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("createdOn", "created On", 108, DevExpress.Utils.FormatType.DateTime, "d/M/yyyy", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("createdBy", "created By", 104, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Modifier", "Modifier", 82, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ColorName", "Color Name", 112, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("typeDescr", "type Descr", 104, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("doorCatName", "door Cat Name", 141, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("description", "description", 106, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default])})
        Me.cboVependisisDoorType.Properties.DataSource = Me.DOORTYPEBindingSource
        Me.cboVependisisDoorType.Properties.DisplayMember = "name"
        Me.cboVependisisDoorType.Properties.NullText = ""
        Me.cboVependisisDoorType.Properties.PopupFormMinSize = New System.Drawing.Size(700, 600)
        Me.cboVependisisDoorType.Properties.PopupSizeable = False
        Me.cboVependisisDoorType.Properties.ValueMember = "ID"
        Me.cboVependisisDoorType.Size = New System.Drawing.Size(305, 38)
        Me.cboVependisisDoorType.StyleController = Me.LayoutControl1
        Me.cboVependisisDoorType.TabIndex = 49
        Me.cboVependisisDoorType.Tag = "VependisisDoorTypeID,0,1,2"
        '
        'DOORTYPEBindingSource
        '
        Me.DOORTYPEBindingSource.DataMember = "DOOR_TYPE"
        Me.DOORTYPEBindingSource.DataSource = Me.DMDataSet
        '
        'DMDataSet
        '
        Me.DMDataSet.DataSetName = "DMDataSet"
        Me.DMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'cboBenchType
        '
        Me.cboBenchType.Location = New System.Drawing.Point(698, 1033)
        Me.cboBenchType.Margin = New System.Windows.Forms.Padding(5)
        Me.cboBenchType.Name = "cboBenchType"
        Me.cboBenchType.Properties.AllowMouseWheel = False
        Me.cboBenchType.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.cboBenchType.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Search), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Clear)})
        Me.cboBenchType.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 35, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("name", "Πάγκος", 200, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("pricePerMeter", "Τιμή", 60, DevExpress.Utils.FormatType.Numeric, "", True, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("width", "width", 61, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("tbl", "tbl", 36, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("dimName", "Διάσταση", 60, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default])})
        Me.cboBenchType.Properties.DataSource = Me.VwBENCHBindingSource
        Me.cboBenchType.Properties.DisplayMember = "name"
        Me.cboBenchType.Properties.NullText = ""
        Me.cboBenchType.Properties.PopupFormMinSize = New System.Drawing.Size(600, 400)
        Me.cboBenchType.Properties.PopupSizeable = False
        Me.cboBenchType.Properties.ValueMember = "ID"
        Me.cboBenchType.Size = New System.Drawing.Size(287, 38)
        Me.cboBenchType.StyleController = Me.LayoutControl1
        Me.cboBenchType.TabIndex = 49
        Me.cboBenchType.Tag = "BenchID,0,1,2"
        '
        'VwBENCHBindingSource
        '
        Me.VwBENCHBindingSource.DataMember = "vw_BENCH"
        Me.VwBENCHBindingSource.DataSource = Me.DreamyKitchenDataSet
        '
        'cboBack
        '
        Me.cboBack.Location = New System.Drawing.Point(683, 1075)
        Me.cboBack.Margin = New System.Windows.Forms.Padding(5)
        Me.cboBack.Name = "cboBack"
        Me.cboBack.Properties.AllowMouseWheel = False
        Me.cboBack.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.cboBack.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Search), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Clear)})
        Me.cboBack.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 35, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("name", "Πάγκος", 200, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("pricePerMeter", "Τιμή", 60, DevExpress.Utils.FormatType.Numeric, "", True, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("width", "width", 61, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("tbl", "tbl", 36, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("dimName", "Διάσταση", 60, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("description", "description", 106, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default])})
        Me.cboBack.Properties.DataSource = Me.VwBENCHBindingSource
        Me.cboBack.Properties.DisplayMember = "name"
        Me.cboBack.Properties.NullText = ""
        Me.cboBack.Properties.PopupFormMinSize = New System.Drawing.Size(400, 600)
        Me.cboBack.Properties.PopupSizeable = False
        Me.cboBack.Properties.ValueMember = "ID"
        Me.cboBack.Size = New System.Drawing.Size(302, 38)
        Me.cboBack.StyleController = Me.LayoutControl1
        Me.cboBack.TabIndex = 49
        Me.cboBack.Tag = "BackID,0,1,2"
        '
        'cboBenchType2
        '
        Me.cboBenchType2.Location = New System.Drawing.Point(1175, 1033)
        Me.cboBenchType2.Margin = New System.Windows.Forms.Padding(5)
        Me.cboBenchType2.Name = "cboBenchType2"
        Me.cboBenchType2.Properties.AllowMouseWheel = False
        Me.cboBenchType2.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.cboBenchType2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Search), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Clear)})
        Me.cboBenchType2.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 35, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("name", "Πάγκος", 200, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("pricePerMeter", "Τιμή", 143, DevExpress.Utils.FormatType.Numeric, "", True, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("width", "width", 61, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("tbl", "tbl", 36, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("dimName", "Διάσταση", 80, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default])})
        Me.cboBenchType2.Properties.DataSource = Me.VwBENCHBindingSource
        Me.cboBenchType2.Properties.DisplayMember = "name"
        Me.cboBenchType2.Properties.NullText = ""
        Me.cboBenchType2.Properties.PopupFormMinSize = New System.Drawing.Size(600, 400)
        Me.cboBenchType2.Properties.PopupSizeable = False
        Me.cboBenchType2.Properties.ValueMember = "ID"
        Me.cboBenchType2.Size = New System.Drawing.Size(303, 38)
        Me.cboBenchType2.StyleController = Me.LayoutControl1
        Me.cboBenchType2.TabIndex = 49
        Me.cboBenchType2.Tag = "BenchID2,0,1,2"
        '
        'txtYShelves
        '
        Me.txtYShelves.Location = New System.Drawing.Point(1589, 806)
        Me.txtYShelves.Margin = New System.Windows.Forms.Padding(5)
        Me.txtYShelves.Name = "txtYShelves"
        Me.txtYShelves.Properties.UseReadOnlyAppearance = False
        Me.txtYShelves.Size = New System.Drawing.Size(258, 38)
        Me.txtYShelves.StyleController = Me.LayoutControl1
        Me.txtYShelves.TabIndex = 10
        Me.txtYShelves.Tag = "YShelves,0,1,2"
        '
        'cboNependisisDoorType
        '
        Me.cboNependisisDoorType.Location = New System.Drawing.Point(333, 634)
        Me.cboNependisisDoorType.Margin = New System.Windows.Forms.Padding(5)
        Me.cboNependisisDoorType.Name = "cboNependisisDoorType"
        Me.cboNependisisDoorType.Properties.AllowMouseWheel = False
        Me.cboNependisisDoorType.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.cboNependisisDoorType.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Search), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Clear)})
        Me.cboNependisisDoorType.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 35, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("cat", "Κατηγορία", 30, DevExpress.Utils.FormatType.Numeric, "", True, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("name", "Υλικό", 100, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("dimName", "Διάσταση", 35, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Price", "Τιμή", 30, DevExpress.Utils.FormatType.Numeric, "c2", True, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("code", "code", 55, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CustomCode", "Custom Code", 125, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("color", "color", 55, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("doorColorID", "door Color ID", 127, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("doorType", "door Type", 100, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("closetType", "closet Type", 109, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("dimID", "dim ID", 72, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("doorCatID", "door Cat ID", 112, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("type", "type", 51, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("kasa", "kasa", 52, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("comments", "comments", 101, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("modifiedBy", "modified By", 113, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("modifiedOn", "modified On", 117, DevExpress.Utils.FormatType.DateTime, "d/M/yyyy", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("createdOn", "created On", 108, DevExpress.Utils.FormatType.DateTime, "d/M/yyyy", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("createdBy", "created By", 104, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Modifier", "Modifier", 82, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ColorName", "Color Name", 112, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("typeDescr", "type Descr", 104, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("doorCatName", "door Cat Name", 141, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("description", "description", 106, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default])})
        Me.cboNependisisDoorType.Properties.DataSource = Me.VwDOORTYPEBindingSource
        Me.cboNependisisDoorType.Properties.DisplayMember = "name"
        Me.cboNependisisDoorType.Properties.NullText = ""
        Me.cboNependisisDoorType.Properties.PopupFormMinSize = New System.Drawing.Size(700, 600)
        Me.cboNependisisDoorType.Properties.PopupSizeable = False
        Me.cboNependisisDoorType.Properties.ValueMember = "ID"
        Me.cboNependisisDoorType.Size = New System.Drawing.Size(305, 38)
        Me.cboNependisisDoorType.StyleController = Me.LayoutControl1
        Me.cboNependisisDoorType.TabIndex = 49
        Me.cboNependisisDoorType.Tag = "NependisisDoorTypeID,0,1,2"
        '
        'VwDOORTYPEBindingSource
        '
        Me.VwDOORTYPEBindingSource.DataMember = "vw_DOOR_TYPE"
        Me.VwDOORTYPEBindingSource.DataSource = Me.DMDataSet
        '
        'cboVDoorType
        '
        Me.cboVDoorType.Location = New System.Drawing.Point(333, 508)
        Me.cboVDoorType.Margin = New System.Windows.Forms.Padding(5)
        Me.cboVDoorType.Name = "cboVDoorType"
        Me.cboVDoorType.Properties.AllowMouseWheel = False
        Me.cboVDoorType.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.cboVDoorType.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Search), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Clear)})
        Me.cboVDoorType.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 35, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("cat", "Κατηγορία", 35, DevExpress.Utils.FormatType.Numeric, "", True, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("name", "Υλικό", 100, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("typeDescr", "Τύπος", 60, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ColorName", "Χρώμα", 60, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Price", "Τιμή", 30, DevExpress.Utils.FormatType.Numeric, "c2", True, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("dimName", "Διάσταση", 35, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("code", "code", 55, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CustomCode", "Custom Code", 125, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("color", "color", 55, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("doorColorID", "door Color ID", 127, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("doorType", "door Type", 100, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("closetType", "closet Type", 109, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("dimID", "dim ID", 72, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("doorCatID", "door Cat ID", 112, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("type", "type", 51, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("kasa", "kasa", 52, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("comments", "comments", 101, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("modifiedBy", "modified By", 113, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("modifiedOn", "modified On", 117, DevExpress.Utils.FormatType.DateTime, "d/M/yyyy", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("createdOn", "created On", 108, DevExpress.Utils.FormatType.DateTime, "d/M/yyyy", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("createdBy", "created By", 104, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Modifier", "Modifier", 82, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("doorCatName", "door Cat Name", 141, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("description", "description", 106, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default])})
        Me.cboVDoorType.Properties.DataSource = Me.VwDOORTYPE1BindingSource
        Me.cboVDoorType.Properties.DisplayMember = "name"
        Me.cboVDoorType.Properties.NullText = ""
        Me.cboVDoorType.Properties.PopupFormMinSize = New System.Drawing.Size(800, 600)
        Me.cboVDoorType.Properties.PopupSizeable = False
        Me.cboVDoorType.Properties.ValueMember = "ID"
        Me.cboVDoorType.Size = New System.Drawing.Size(305, 38)
        Me.cboVDoorType.StyleController = Me.LayoutControl1
        Me.cboVDoorType.TabIndex = 49
        Me.cboVDoorType.Tag = "VdoorTypeID,0,1,2"
        '
        'VwDOORTYPE1BindingSource
        '
        Me.VwDOORTYPE1BindingSource.DataMember = "vw_DOOR_TYPE1"
        Me.VwDOORTYPE1BindingSource.DataSource = Me.DMDataSet
        '
        'cboVDoorType1
        '
        Me.cboVDoorType1.Location = New System.Drawing.Point(333, 550)
        Me.cboVDoorType1.Margin = New System.Windows.Forms.Padding(5)
        Me.cboVDoorType1.Name = "cboVDoorType1"
        Me.cboVDoorType1.Properties.AllowMouseWheel = False
        Me.cboVDoorType1.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.cboVDoorType1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Search), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Clear)})
        Me.cboVDoorType1.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 35, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("cat", "Κατηγορία", 35, DevExpress.Utils.FormatType.Numeric, "", True, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("name", "Υλικό", 100, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("typeDescr", "Τύπος", 60, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ColorName", "Χρώμα", 60, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Price", "Τιμή", 30, DevExpress.Utils.FormatType.Numeric, "c2", True, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("dimName", "Διάσταση", 35, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("code", "code", 55, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CustomCode", "Custom Code", 125, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("color", "color", 55, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("doorColorID", "door Color ID", 127, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("doorType", "door Type", 100, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("closetType", "closet Type", 109, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("dimID", "dim ID", 72, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("doorCatID", "door Cat ID", 112, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("type", "type", 51, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("kasa", "kasa", 52, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("comments", "comments", 101, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("modifiedBy", "modified By", 113, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("modifiedOn", "modified On", 117, DevExpress.Utils.FormatType.DateTime, "d/M/yyyy", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("createdOn", "created On", 108, DevExpress.Utils.FormatType.DateTime, "d/M/yyyy", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("createdBy", "created By", 104, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Modifier", "Modifier", 82, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("doorCatName", "door Cat Name", 141, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("description", "description", 106, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default])})
        Me.cboVDoorType1.Properties.DataSource = Me.VwDOORTYPE1BindingSource
        Me.cboVDoorType1.Properties.DisplayMember = "name"
        Me.cboVDoorType1.Properties.NullText = ""
        Me.cboVDoorType1.Properties.PopupFormMinSize = New System.Drawing.Size(800, 600)
        Me.cboVDoorType1.Properties.PopupSizeable = False
        Me.cboVDoorType1.Properties.ValueMember = "ID"
        Me.cboVDoorType1.Size = New System.Drawing.Size(305, 38)
        Me.cboVDoorType1.StyleController = Me.LayoutControl1
        Me.cboVDoorType1.TabIndex = 49
        Me.cboVDoorType1.Tag = "VdoorTypeID2,0,1,2"
        '
        'cboKDoorType
        '
        Me.cboKDoorType.Location = New System.Drawing.Point(963, 508)
        Me.cboKDoorType.Margin = New System.Windows.Forms.Padding(5)
        Me.cboKDoorType.Name = "cboKDoorType"
        Me.cboKDoorType.Properties.AllowMouseWheel = False
        Me.cboKDoorType.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.cboKDoorType.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Search), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Clear)})
        Me.cboKDoorType.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 35, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("cat", "Κατηγορία", 35, DevExpress.Utils.FormatType.Numeric, "", True, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("name", "Υλικό", 100, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("typeDescr", "Τύπος", 60, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ColorName", "Χρώμα", 60, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Price", "Τιμή", 30, DevExpress.Utils.FormatType.Numeric, "c2", True, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("dimName", "Διάσταση", 35, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("code", "code", 55, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CustomCode", "Custom Code", 125, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("color", "color", 55, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("doorColorID", "door Color ID", 127, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("doorType", "door Type", 100, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("closetType", "closet Type", 109, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("dimID", "dim ID", 72, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("doorCatID", "door Cat ID", 112, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("type", "type", 51, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("kasa", "kasa", 52, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("comments", "comments", 101, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("modifiedBy", "modified By", 113, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("modifiedOn", "modified On", 117, DevExpress.Utils.FormatType.DateTime, "d/M/yyyy", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("createdOn", "created On", 108, DevExpress.Utils.FormatType.DateTime, "d/M/yyyy", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("createdBy", "created By", 104, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Modifier", "Modifier", 82, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("doorCatName", "door Cat Name", 141, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("description", "description", 106, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default])})
        Me.cboKDoorType.Properties.DataSource = Me.VwDOORTYPE1BindingSource
        Me.cboKDoorType.Properties.DisplayMember = "name"
        Me.cboKDoorType.Properties.NullText = ""
        Me.cboKDoorType.Properties.PopupFormMinSize = New System.Drawing.Size(800, 600)
        Me.cboKDoorType.Properties.PopupSizeable = False
        Me.cboKDoorType.Properties.ValueMember = "ID"
        Me.cboKDoorType.Size = New System.Drawing.Size(301, 38)
        Me.cboKDoorType.StyleController = Me.LayoutControl1
        Me.cboKDoorType.TabIndex = 49
        Me.cboKDoorType.Tag = "KdoorTypeID,0,1,2"
        '
        'cboKDoorType1
        '
        Me.cboKDoorType1.Location = New System.Drawing.Point(963, 550)
        Me.cboKDoorType1.Margin = New System.Windows.Forms.Padding(5)
        Me.cboKDoorType1.Name = "cboKDoorType1"
        Me.cboKDoorType1.Properties.AllowMouseWheel = False
        Me.cboKDoorType1.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.cboKDoorType1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Search), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Clear)})
        Me.cboKDoorType1.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 35, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("cat", "Κατηγορία", 35, DevExpress.Utils.FormatType.Numeric, "", True, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("name", "Υλικό", 100, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("typeDescr", "Τύπος", 60, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ColorName", "Χρώμα", 60, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Price", "Τιμή", 30, DevExpress.Utils.FormatType.Numeric, "c2", True, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("dimName", "Διάσταση", 35, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("code", "code", 55, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CustomCode", "Custom Code", 125, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("color", "color", 55, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("doorColorID", "door Color ID", 127, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("doorType", "door Type", 100, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("closetType", "closet Type", 109, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("dimID", "dim ID", 72, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("doorCatID", "door Cat ID", 112, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("type", "type", 51, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("kasa", "kasa", 52, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("comments", "comments", 101, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("modifiedBy", "modified By", 113, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("modifiedOn", "modified On", 117, DevExpress.Utils.FormatType.DateTime, "d/M/yyyy", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("createdOn", "created On", 108, DevExpress.Utils.FormatType.DateTime, "d/M/yyyy", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("createdBy", "created By", 104, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Modifier", "Modifier", 82, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("doorCatName", "door Cat Name", 141, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("description", "description", 106, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default])})
        Me.cboKDoorType1.Properties.DataSource = Me.VwDOORTYPE1BindingSource
        Me.cboKDoorType1.Properties.DisplayMember = "name"
        Me.cboKDoorType1.Properties.NullText = ""
        Me.cboKDoorType1.Properties.PopupFormMinSize = New System.Drawing.Size(800, 600)
        Me.cboKDoorType1.Properties.PopupSizeable = False
        Me.cboKDoorType1.Properties.ValueMember = "ID"
        Me.cboKDoorType1.Size = New System.Drawing.Size(301, 38)
        Me.cboKDoorType1.StyleController = Me.LayoutControl1
        Me.cboKDoorType1.TabIndex = 49
        Me.cboKDoorType1.Tag = "KdoorTypeID2,0,1,2"
        '
        'cboYDoorType
        '
        Me.cboYDoorType.Location = New System.Drawing.Point(1589, 550)
        Me.cboYDoorType.Margin = New System.Windows.Forms.Padding(5)
        Me.cboYDoorType.Name = "cboYDoorType"
        Me.cboYDoorType.Properties.AllowMouseWheel = False
        Me.cboYDoorType.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.cboYDoorType.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Search), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Clear)})
        Me.cboYDoorType.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 35, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("cat", "Κατηγορία", 35, DevExpress.Utils.FormatType.Numeric, "", True, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("name", "Υλικό", 100, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("typeDescr", "Τύπος", 60, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ColorName", "Χρώμα", 60, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Price", "Τιμή", 30, DevExpress.Utils.FormatType.Numeric, "c2", True, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("dimName", "Διάσταση", 35, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("code", "code", 55, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CustomCode", "Custom Code", 125, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("color", "color", 55, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("doorColorID", "door Color ID", 127, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("doorType", "door Type", 100, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("closetType", "closet Type", 109, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("dimID", "dim ID", 72, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("doorCatID", "door Cat ID", 112, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("type", "type", 51, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("kasa", "kasa", 52, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("comments", "comments", 101, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("modifiedBy", "modified By", 113, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("modifiedOn", "modified On", 117, DevExpress.Utils.FormatType.DateTime, "d/M/yyyy", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("createdOn", "created On", 108, DevExpress.Utils.FormatType.DateTime, "d/M/yyyy", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("createdBy", "created By", 104, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Modifier", "Modifier", 82, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("doorCatName", "door Cat Name", 141, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("description", "description", 106, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default])})
        Me.cboYDoorType.Properties.DataSource = Me.VwDOORTYPE1BindingSource
        Me.cboYDoorType.Properties.DisplayMember = "name"
        Me.cboYDoorType.Properties.NullText = ""
        Me.cboYDoorType.Properties.PopupFormMinSize = New System.Drawing.Size(800, 600)
        Me.cboYDoorType.Properties.PopupSizeable = False
        Me.cboYDoorType.Properties.ValueMember = "ID"
        Me.cboYDoorType.Size = New System.Drawing.Size(258, 38)
        Me.cboYDoorType.StyleController = Me.LayoutControl1
        Me.cboYDoorType.TabIndex = 49
        Me.cboYDoorType.Tag = "YdoorTypeID,0,1,2"
        '
        'cboYDoorType1
        '
        Me.cboYDoorType1.Location = New System.Drawing.Point(1589, 592)
        Me.cboYDoorType1.Margin = New System.Windows.Forms.Padding(5)
        Me.cboYDoorType1.Name = "cboYDoorType1"
        Me.cboYDoorType1.Properties.AllowMouseWheel = False
        Me.cboYDoorType1.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.cboYDoorType1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Search), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Clear)})
        Me.cboYDoorType1.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 35, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("cat", "Κατηγορία", 35, DevExpress.Utils.FormatType.Numeric, "", True, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("name", "Υλικό", 100, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("typeDescr", "Τύπος", 60, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ColorName", "Χρώμα", 60, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Price", "Τιμή", 30, DevExpress.Utils.FormatType.Numeric, "c2", True, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("dimName", "Διάσταση", 35, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("code", "code", 55, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CustomCode", "Custom Code", 125, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("color", "color", 55, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("doorColorID", "door Color ID", 127, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("doorType", "door Type", 100, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("closetType", "closet Type", 109, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("dimID", "dim ID", 72, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("doorCatID", "door Cat ID", 112, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("type", "type", 51, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("kasa", "kasa", 52, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("comments", "comments", 101, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("modifiedBy", "modified By", 113, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("modifiedOn", "modified On", 117, DevExpress.Utils.FormatType.DateTime, "d/M/yyyy", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("createdOn", "created On", 108, DevExpress.Utils.FormatType.DateTime, "d/M/yyyy", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("createdBy", "created By", 104, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Modifier", "Modifier", 82, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("doorCatName", "door Cat Name", 141, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("description", "description", 106, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default])})
        Me.cboYDoorType1.Properties.DataSource = Me.VwDOORTYPE1BindingSource
        Me.cboYDoorType1.Properties.DisplayMember = "name"
        Me.cboYDoorType1.Properties.NullText = ""
        Me.cboYDoorType1.Properties.PopupFormMinSize = New System.Drawing.Size(800, 600)
        Me.cboYDoorType1.Properties.PopupSizeable = False
        Me.cboYDoorType1.Properties.ValueMember = "ID"
        Me.cboYDoorType1.Size = New System.Drawing.Size(258, 38)
        Me.cboYDoorType1.StyleController = Me.LayoutControl1
        Me.cboYDoorType1.TabIndex = 49
        Me.cboYDoorType1.Tag = "YdoorTypeID2,0,1,2"
        '
        'cboPependisisDoorType
        '
        Me.cboPependisisDoorType.Location = New System.Drawing.Point(1589, 634)
        Me.cboPependisisDoorType.Margin = New System.Windows.Forms.Padding(5)
        Me.cboPependisisDoorType.Name = "cboPependisisDoorType"
        Me.cboPependisisDoorType.Properties.AllowMouseWheel = False
        Me.cboPependisisDoorType.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.cboPependisisDoorType.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Search), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Clear)})
        Me.cboPependisisDoorType.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 35, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("cat", "Κατηγορία", 30, DevExpress.Utils.FormatType.Numeric, "", True, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("name", "Υλικό", 100, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("dimName", "Διάσταση", 35, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Price", "Τιμή", 30, DevExpress.Utils.FormatType.Numeric, "c2", True, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("code", "code", 55, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CustomCode", "Custom Code", 125, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("color", "color", 55, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("doorColorID", "door Color ID", 127, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("doorType", "door Type", 100, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("closetType", "closet Type", 109, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("dimID", "dim ID", 72, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("doorCatID", "door Cat ID", 112, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("type", "type", 51, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("kasa", "kasa", 52, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("comments", "comments", 101, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("modifiedBy", "modified By", 113, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("modifiedOn", "modified On", 117, DevExpress.Utils.FormatType.DateTime, "d/M/yyyy", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("createdOn", "created On", 108, DevExpress.Utils.FormatType.DateTime, "d/M/yyyy", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("createdBy", "created By", 104, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Modifier", "Modifier", 82, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ColorName", "Color Name", 112, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("typeDescr", "type Descr", 104, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("doorCatName", "door Cat Name", 141, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("description", "description", 106, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default])})
        Me.cboPependisisDoorType.Properties.DataSource = Me.VwDOORTYPEPlainaYpsilaBindingSource
        Me.cboPependisisDoorType.Properties.DisplayMember = "name"
        Me.cboPependisisDoorType.Properties.NullText = ""
        Me.cboPependisisDoorType.Properties.PopupFormMinSize = New System.Drawing.Size(700, 600)
        Me.cboPependisisDoorType.Properties.PopupSizeable = False
        Me.cboPependisisDoorType.Properties.ValueMember = "ID"
        Me.cboPependisisDoorType.Size = New System.Drawing.Size(258, 38)
        Me.cboPependisisDoorType.StyleController = Me.LayoutControl1
        Me.cboPependisisDoorType.TabIndex = 49
        Me.cboPependisisDoorType.Tag = "PependisisDoorTypeID,0,1,2"
        '
        'VwDOORTYPEPlainaYpsilaBindingSource
        '
        Me.VwDOORTYPEPlainaYpsilaBindingSource.DataMember = "vw_DOOR_TYPEPlainaYpsila"
        Me.VwDOORTYPEPlainaYpsilaBindingSource.DataSource = Me.DMDataSet
        '
        'cboKependisisDoorType
        '
        Me.cboKependisisDoorType.Location = New System.Drawing.Point(963, 592)
        Me.cboKependisisDoorType.Margin = New System.Windows.Forms.Padding(5)
        Me.cboKependisisDoorType.Name = "cboKependisisDoorType"
        Me.cboKependisisDoorType.Properties.AllowMouseWheel = False
        Me.cboKependisisDoorType.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.cboKependisisDoorType.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Search), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Clear)})
        Me.cboKependisisDoorType.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 35, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("cat", "Κατηγορία", 30, DevExpress.Utils.FormatType.Numeric, "", True, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("name", "Υλικό", 100, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("dimName", "Διάσταση", 35, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Price", "Τιμή", 30, DevExpress.Utils.FormatType.Numeric, "c2", True, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("code", "code", 55, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CustomCode", "Custom Code", 125, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("color", "color", 55, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("doorColorID", "door Color ID", 127, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("doorType", "door Type", 100, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("closetType", "closet Type", 109, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("dimID", "dim ID", 72, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("doorCatID", "door Cat ID", 112, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("type", "type", 51, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("kasa", "kasa", 52, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("comments", "comments", 101, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("modifiedBy", "modified By", 113, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("modifiedOn", "modified On", 117, DevExpress.Utils.FormatType.DateTime, "d/M/yyyy", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("createdOn", "created On", 108, DevExpress.Utils.FormatType.DateTime, "d/M/yyyy", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("createdBy", "created By", 104, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Modifier", "Modifier", 82, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ColorName", "Color Name", 112, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("typeDescr", "type Descr", 104, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("doorCatName", "door Cat Name", 141, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("description", "description", 106, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default])})
        Me.cboKependisisDoorType.Properties.DataSource = Me.VwDOORTYPEPlainaKremastaBindingSource
        Me.cboKependisisDoorType.Properties.DisplayMember = "name"
        Me.cboKependisisDoorType.Properties.NullText = ""
        Me.cboKependisisDoorType.Properties.PopupFormMinSize = New System.Drawing.Size(700, 600)
        Me.cboKependisisDoorType.Properties.PopupSizeable = False
        Me.cboKependisisDoorType.Properties.ValueMember = "ID"
        Me.cboKependisisDoorType.Size = New System.Drawing.Size(301, 38)
        Me.cboKependisisDoorType.StyleController = Me.LayoutControl1
        Me.cboKependisisDoorType.TabIndex = 49
        Me.cboKependisisDoorType.Tag = "KependisisDoorTypeID,0,1,2"
        '
        'VwDOORTYPEPlainaKremastaBindingSource
        '
        Me.VwDOORTYPEPlainaKremastaBindingSource.DataMember = "vw_DOOR_TYPEPlainaKremasta"
        Me.VwDOORTYPEPlainaKremastaBindingSource.DataSource = Me.DMDataSet
        '
        'cboSndEpendisisDoorType
        '
        Me.cboSndEpendisisDoorType.Location = New System.Drawing.Point(963, 634)
        Me.cboSndEpendisisDoorType.Margin = New System.Windows.Forms.Padding(5)
        Me.cboSndEpendisisDoorType.Name = "cboSndEpendisisDoorType"
        Me.cboSndEpendisisDoorType.Properties.AllowMouseWheel = False
        Me.cboSndEpendisisDoorType.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.cboSndEpendisisDoorType.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Search), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Clear)})
        Me.cboSndEpendisisDoorType.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 35, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("cat", "Κατηγορία", 30, DevExpress.Utils.FormatType.Numeric, "", True, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("name", "Υλικό", 100, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("dimName", "Διάσταση", 35, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Price", "Τιμή", 30, DevExpress.Utils.FormatType.Numeric, "c2", True, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("code", "code", 55, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CustomCode", "Custom Code", 125, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("color", "color", 55, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("doorColorID", "door Color ID", 127, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("doorType", "door Type", 100, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("closetType", "closet Type", 109, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("dimID", "dim ID", 72, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("doorCatID", "door Cat ID", 112, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("type", "type", 51, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("kasa", "kasa", 52, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("comments", "comments", 101, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("modifiedBy", "modified By", 113, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("modifiedOn", "modified On", 117, DevExpress.Utils.FormatType.DateTime, "d/M/yyyy", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("createdOn", "created On", 108, DevExpress.Utils.FormatType.DateTime, "d/M/yyyy", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("createdBy", "created By", 104, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Modifier", "Modifier", 82, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ColorName", "Color Name", 112, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("typeDescr", "type Descr", 104, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("doorCatName", "door Cat Name", 141, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("description", "description", 106, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default])})
        Me.cboSndEpendisisDoorType.Properties.DataSource = Me.VwDOORTYPEPlainaKremasta2hsSeirasBindingSource
        Me.cboSndEpendisisDoorType.Properties.DisplayMember = "name"
        Me.cboSndEpendisisDoorType.Properties.NullText = ""
        Me.cboSndEpendisisDoorType.Properties.PopupFormMinSize = New System.Drawing.Size(700, 600)
        Me.cboSndEpendisisDoorType.Properties.PopupSizeable = False
        Me.cboSndEpendisisDoorType.Properties.ValueMember = "ID"
        Me.cboSndEpendisisDoorType.Size = New System.Drawing.Size(301, 38)
        Me.cboSndEpendisisDoorType.StyleController = Me.LayoutControl1
        Me.cboSndEpendisisDoorType.TabIndex = 49
        Me.cboSndEpendisisDoorType.Tag = "SndEpendisisDoorTypeID,0,1,2"
        '
        'VwDOORTYPEPlainaKremasta2hsSeirasBindingSource
        '
        Me.VwDOORTYPEPlainaKremasta2hsSeirasBindingSource.DataMember = "vw_DOOR_TYPEPlainaKremasta2hsSeiras"
        Me.VwDOORTYPEPlainaKremasta2hsSeirasBindingSource.DataSource = Me.DMDataSet
        '
        'cboVRafieraDoorType
        '
        Me.cboVRafieraDoorType.Location = New System.Drawing.Point(333, 848)
        Me.cboVRafieraDoorType.Margin = New System.Windows.Forms.Padding(5)
        Me.cboVRafieraDoorType.Name = "cboVRafieraDoorType"
        Me.cboVRafieraDoorType.Properties.AllowMouseWheel = False
        Me.cboVRafieraDoorType.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.cboVRafieraDoorType.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Search), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Clear)})
        Me.cboVRafieraDoorType.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 35, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("cat", "Κατηγορία", 30, DevExpress.Utils.FormatType.Numeric, "", True, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("name", "Υλικό", 100, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("dimName", "Διάσταση", 35, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Price", "Τιμή", 30, DevExpress.Utils.FormatType.Numeric, "c2", True, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("code", "code", 55, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CustomCode", "Custom Code", 125, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("color", "color", 55, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("doorColorID", "door Color ID", 127, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("doorType", "door Type", 100, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("closetType", "closet Type", 109, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("dimID", "dim ID", 72, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("doorCatID", "door Cat ID", 112, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("type", "type", 51, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("kasa", "kasa", 52, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("comments", "comments", 101, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("modifiedBy", "modified By", 113, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("modifiedOn", "modified On", 117, DevExpress.Utils.FormatType.DateTime, "d/M/yyyy", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("createdOn", "created On", 108, DevExpress.Utils.FormatType.DateTime, "d/M/yyyy", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("createdBy", "created By", 104, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Modifier", "Modifier", 82, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ColorName", "Color Name", 112, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("typeDescr", "type Descr", 104, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("doorCatName", "door Cat Name", 141, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("description", "description", 106, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default])})
        Me.cboVRafieraDoorType.Properties.DataSource = Me.VwDOORTYPERafieresVBindingSource
        Me.cboVRafieraDoorType.Properties.DisplayMember = "name"
        Me.cboVRafieraDoorType.Properties.NullText = ""
        Me.cboVRafieraDoorType.Properties.PopupFormMinSize = New System.Drawing.Size(700, 600)
        Me.cboVRafieraDoorType.Properties.PopupSizeable = False
        Me.cboVRafieraDoorType.Properties.ValueMember = "ID"
        Me.cboVRafieraDoorType.Size = New System.Drawing.Size(305, 38)
        Me.cboVRafieraDoorType.StyleController = Me.LayoutControl1
        Me.cboVRafieraDoorType.TabIndex = 49
        Me.cboVRafieraDoorType.Tag = "VRafieraDoorTypeID,0,1,2"
        '
        'VwDOORTYPERafieresVBindingSource
        '
        Me.VwDOORTYPERafieresVBindingSource.DataMember = "vw_DOOR_TYPERafieresV"
        Me.VwDOORTYPERafieresVBindingSource.DataSource = Me.DMDataSet
        '
        'cboKRafieraDoorType
        '
        Me.cboKRafieraDoorType.Location = New System.Drawing.Point(963, 845)
        Me.cboKRafieraDoorType.Margin = New System.Windows.Forms.Padding(5)
        Me.cboKRafieraDoorType.Name = "cboKRafieraDoorType"
        Me.cboKRafieraDoorType.Properties.AllowMouseWheel = False
        Me.cboKRafieraDoorType.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.cboKRafieraDoorType.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Search), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Clear)})
        Me.cboKRafieraDoorType.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 35, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("cat", "Κατηγορία", 30, DevExpress.Utils.FormatType.Numeric, "", True, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("name", "Υλικό", 100, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("dimName", "Διάσταση", 35, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Price", "Τιμή", 30, DevExpress.Utils.FormatType.Numeric, "c2", True, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("code", "code", 55, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CustomCode", "Custom Code", 125, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("color", "color", 55, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("doorColorID", "door Color ID", 127, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("doorType", "door Type", 100, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("closetType", "closet Type", 109, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("dimID", "dim ID", 72, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("doorCatID", "door Cat ID", 112, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("type", "type", 51, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("kasa", "kasa", 52, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("comments", "comments", 101, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("modifiedBy", "modified By", 113, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("modifiedOn", "modified On", 117, DevExpress.Utils.FormatType.DateTime, "d/M/yyyy", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("createdOn", "created On", 108, DevExpress.Utils.FormatType.DateTime, "d/M/yyyy", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("createdBy", "created By", 104, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Modifier", "Modifier", 82, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ColorName", "Color Name", 112, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("typeDescr", "type Descr", 104, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("doorCatName", "door Cat Name", 141, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("description", "description", 106, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default])})
        Me.cboKRafieraDoorType.Properties.DataSource = Me.VwDOORTYPERafieresKBindingSource
        Me.cboKRafieraDoorType.Properties.DisplayMember = "name"
        Me.cboKRafieraDoorType.Properties.NullText = ""
        Me.cboKRafieraDoorType.Properties.PopupFormMinSize = New System.Drawing.Size(700, 600)
        Me.cboKRafieraDoorType.Properties.PopupSizeable = False
        Me.cboKRafieraDoorType.Properties.ValueMember = "ID"
        Me.cboKRafieraDoorType.Size = New System.Drawing.Size(301, 38)
        Me.cboKRafieraDoorType.StyleController = Me.LayoutControl1
        Me.cboKRafieraDoorType.TabIndex = 49
        Me.cboKRafieraDoorType.Tag = "KRafieraDoorTypeID,0,1,2"
        '
        'VwDOORTYPERafieresKBindingSource
        '
        Me.VwDOORTYPERafieresKBindingSource.DataMember = "vw_DOOR_TYPERafieresK"
        Me.VwDOORTYPERafieresKBindingSource.DataSource = Me.DMDataSet
        '
        'cboYRafieraDoorType
        '
        Me.cboYRafieraDoorType.Location = New System.Drawing.Point(1589, 764)
        Me.cboYRafieraDoorType.Margin = New System.Windows.Forms.Padding(5)
        Me.cboYRafieraDoorType.Name = "cboYRafieraDoorType"
        Me.cboYRafieraDoorType.Properties.AllowMouseWheel = False
        Me.cboYRafieraDoorType.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.cboYRafieraDoorType.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Search), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Clear)})
        Me.cboYRafieraDoorType.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 35, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("cat", "Κατηγορία", 30, DevExpress.Utils.FormatType.Numeric, "", True, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("name", "Υλικό", 100, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("dimName", "Διάσταση", 35, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Price", "Τιμή", 30, DevExpress.Utils.FormatType.Numeric, "c2", True, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("code", "code", 55, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CustomCode", "Custom Code", 125, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("color", "color", 55, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("doorColorID", "door Color ID", 127, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("doorType", "door Type", 100, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("closetType", "closet Type", 109, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("dimID", "dim ID", 72, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("doorCatID", "door Cat ID", 112, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("type", "type", 51, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("kasa", "kasa", 52, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("comments", "comments", 101, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("modifiedBy", "modified By", 113, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("modifiedOn", "modified On", 117, DevExpress.Utils.FormatType.DateTime, "d/M/yyyy", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("createdOn", "created On", 108, DevExpress.Utils.FormatType.DateTime, "d/M/yyyy", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("createdBy", "created By", 104, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Modifier", "Modifier", 82, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ColorName", "Color Name", 112, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("typeDescr", "type Descr", 104, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("doorCatName", "door Cat Name", 141, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("description", "description", 106, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default])})
        Me.cboYRafieraDoorType.Properties.DataSource = Me.VwDOORTYPERafieresYBindingSource
        Me.cboYRafieraDoorType.Properties.DisplayMember = "name"
        Me.cboYRafieraDoorType.Properties.NullText = ""
        Me.cboYRafieraDoorType.Properties.PopupFormMinSize = New System.Drawing.Size(700, 600)
        Me.cboYRafieraDoorType.Properties.PopupSizeable = False
        Me.cboYRafieraDoorType.Properties.ValueMember = "ID"
        Me.cboYRafieraDoorType.Size = New System.Drawing.Size(258, 38)
        Me.cboYRafieraDoorType.StyleController = Me.LayoutControl1
        Me.cboYRafieraDoorType.TabIndex = 49
        Me.cboYRafieraDoorType.Tag = "YRafieraDoorTypeID,0,1,2"
        '
        'VwDOORTYPERafieresYBindingSource
        '
        Me.VwDOORTYPERafieresYBindingSource.DataMember = "vw_DOOR_TYPERafieresY"
        Me.VwDOORTYPERafieresYBindingSource.DataSource = Me.DMDataSet
        '
        'cboKWallRafiaDoorType
        '
        Me.cboKWallRafiaDoorType.Location = New System.Drawing.Point(963, 929)
        Me.cboKWallRafiaDoorType.Margin = New System.Windows.Forms.Padding(5)
        Me.cboKWallRafiaDoorType.Name = "cboKWallRafiaDoorType"
        Me.cboKWallRafiaDoorType.Properties.AllowMouseWheel = False
        Me.cboKWallRafiaDoorType.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.cboKWallRafiaDoorType.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Search), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Clear)})
        Me.cboKWallRafiaDoorType.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 35, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("cat", "Κατηγορία", 30, DevExpress.Utils.FormatType.Numeric, "", True, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("name", "Υλικό", 100, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("dimName", "Διάσταση", 35, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Price", "Τιμή", 30, DevExpress.Utils.FormatType.Numeric, "c2", True, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("code", "code", 55, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CustomCode", "Custom Code", 125, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("color", "color", 55, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("doorColorID", "door Color ID", 127, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("doorType", "door Type", 100, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("closetType", "closet Type", 109, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("dimID", "dim ID", 72, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("doorCatID", "door Cat ID", 112, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("type", "type", 51, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("kasa", "kasa", 52, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("comments", "comments", 101, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("modifiedBy", "modified By", 113, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("modifiedOn", "modified On", 117, DevExpress.Utils.FormatType.DateTime, "d/M/yyyy", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("createdOn", "created On", 108, DevExpress.Utils.FormatType.DateTime, "d/M/yyyy", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("createdBy", "created By", 104, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Modifier", "Modifier", 82, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ColorName", "Color Name", 112, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("typeDescr", "type Descr", 104, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("doorCatName", "door Cat Name", 141, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("description", "description", 106, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default])})
        Me.cboKWallRafiaDoorType.Properties.DataSource = Me.VwDOORTYPERafiaWallBindingSource
        Me.cboKWallRafiaDoorType.Properties.DisplayMember = "name"
        Me.cboKWallRafiaDoorType.Properties.NullText = ""
        Me.cboKWallRafiaDoorType.Properties.PopupFormMinSize = New System.Drawing.Size(700, 600)
        Me.cboKWallRafiaDoorType.Properties.PopupSizeable = False
        Me.cboKWallRafiaDoorType.Properties.ValueMember = "ID"
        Me.cboKWallRafiaDoorType.Size = New System.Drawing.Size(301, 38)
        Me.cboKWallRafiaDoorType.StyleController = Me.LayoutControl1
        Me.cboKWallRafiaDoorType.TabIndex = 49
        Me.cboKWallRafiaDoorType.Tag = "KWallRafiaDoorTypeID,0,1,2"
        '
        'VwDOORTYPERafiaWallBindingSource
        '
        Me.VwDOORTYPERafiaWallBindingSource.DataMember = "vw_DOOR_TYPERafiaWall"
        Me.VwDOORTYPERafiaWallBindingSource.DataSource = Me.DMDataSet
        '
        'cboTRANSH
        '
        Me.cboTRANSH.Location = New System.Drawing.Point(1239, 103)
        Me.cboTRANSH.Margin = New System.Windows.Forms.Padding(5)
        Me.cboTRANSH.Name = "cboTRANSH"
        Me.cboTRANSH.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.cboTRANSH.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Search), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Clear)})
        Me.cboTRANSH.Properties.DisplayMember = "description"
        Me.cboTRANSH.Properties.NullText = ""
        Me.cboTRANSH.Properties.PopupSizeable = False
        Me.cboTRANSH.Properties.ValueMember = "ID"
        Me.cboTRANSH.Size = New System.Drawing.Size(621, 38)
        Me.cboTRANSH.StyleController = Me.LayoutControl1
        Me.cboTRANSH.TabIndex = 6
        Me.cboTRANSH.Tag = "transhID,0,1,2"
        '
        'txtTransp
        '
        Me.txtTransp.EditValue = "0,00 €"
        Me.txtTransp.Location = New System.Drawing.Point(735, 1218)
        Me.txtTransp.Margin = New System.Windows.Forms.Padding(5)
        Me.txtTransp.Name = "txtTransp"
        Me.txtTransp.Properties.DisplayFormat.FormatString = "c"
        Me.txtTransp.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtTransp.Properties.EditFormat.FormatString = "n2"
        Me.txtTransp.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtTransp.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtTransp.Properties.MaskSettings.Set("MaskManagerType", GetType(DevExpress.Data.Mask.NumericMaskManager))
        Me.txtTransp.Properties.MaskSettings.Set("mask", "c2")
        Me.txtTransp.Properties.Tag = "BenchExtraPrice"
        Me.txtTransp.Properties.UseReadOnlyAppearance = False
        Me.txtTransp.Size = New System.Drawing.Size(173, 38)
        Me.txtTransp.StyleController = Me.LayoutControl1
        Me.txtTransp.TabIndex = 42
        Me.txtTransp.Tag = "Transp,0,1,2"
        Me.txtTransp.Visible = False
        '
        'Root
        '
        Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.Root.GroupBordersVisible = False
        Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlGroup2, Me.LayoutControlGroup1, Me.LayoutControlItem2, Me.LayoutControlItem26, Me.LayoutControlItem27, Me.EmptySpaceItem3, Me.LayoutControlItem32})
        Me.Root.Name = "Root"
        Me.Root.OptionsItemText.TextToControlDistance = 1
        Me.Root.Size = New System.Drawing.Size(1885, 1414)
        Me.Root.TextVisible = False
        '
        'LayoutControlGroup2
        '
        Me.LayoutControlGroup2.CustomizationFormText = "Υλικά"
        Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlGroup3, Me.LayoutControlGroup5, Me.LayoutControlGroup6, Me.LayoutControlGroup7, Me.LayoutControlItem40, Me.LayoutControlItem29, Me.LayoutControlItem34, Me.LayoutControlItem42, Me.LayoutControlItem35, Me.LayoutControlItem43, Me.LayoutControlItem44, Me.EmptySpaceItem4, Me.LayoutControlItem38, Me.LayoutControlItem76})
        Me.LayoutControlGroup2.Location = New System.Drawing.Point(0, 230)
        Me.LayoutControlGroup2.Name = "LayoutControlGroup2"
        Me.LayoutControlGroup2.Size = New System.Drawing.Size(1865, 1039)
        Me.LayoutControlGroup2.Text = "Ερμάρια"
        '
        'LayoutControlGroup3
        '
        Me.LayoutControlGroup3.AppearanceGroup.BorderColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Success
        Me.LayoutControlGroup3.AppearanceGroup.Options.UseBorderColor = True
        Me.LayoutControlGroup3.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem21, Me.LayoutControlItem49, Me.LayoutControlItem51, Me.LayoutControlItem53, Me.LayoutControlItem54, Me.LayoutControlItem52, Me.LayoutControlItem22, Me.LayoutControlItem18, Me.LayoutControlItem24, Me.LayoutControlItem6, Me.LayoutControlItem73, Me.LayoutControlItem15, Me.LayoutControlItem33, Me.LayoutControlItem58})
        Me.LayoutControlGroup3.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup3.Name = "LayoutControlGroup3"
        Me.LayoutControlGroup3.Size = New System.Drawing.Size(630, 693)
        Me.LayoutControlGroup3.Text = "Βάσεως"
        '
        'LayoutControlItem21
        '
        Me.LayoutControlItem21.Control = Me.cboVBOXColors
        Me.LayoutControlItem21.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem21.CustomizationFormText = "Χρώμα PVC"
        Me.LayoutControlItem21.Location = New System.Drawing.Point(0, 126)
        Me.LayoutControlItem21.Name = "LayoutControlItem21"
        Me.LayoutControlItem21.Size = New System.Drawing.Size(604, 42)
        Me.LayoutControlItem21.Text = "Χρώμα Κουτιού"
        Me.LayoutControlItem21.TextSize = New System.Drawing.Size(294, 23)
        '
        'LayoutControlItem49
        '
        Me.LayoutControlItem49.Control = Me.txtVFinalHeight
        Me.LayoutControlItem49.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem49.CustomizationFormText = "Ύψος"
        Me.LayoutControlItem49.HighlightFocusedItem = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlItem49.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem49.Name = "LayoutControlItem49"
        Me.LayoutControlItem49.Size = New System.Drawing.Size(604, 42)
        Me.LayoutControlItem49.Text = "Τελικό Ύψος (cm)"
        Me.LayoutControlItem49.TextSize = New System.Drawing.Size(294, 23)
        '
        'LayoutControlItem51
        '
        Me.LayoutControlItem51.Control = Me.cboVType
        Me.LayoutControlItem51.Location = New System.Drawing.Point(0, 42)
        Me.LayoutControlItem51.Name = "LayoutControlItem51"
        Me.LayoutControlItem51.Size = New System.Drawing.Size(604, 42)
        Me.LayoutControlItem51.Text = "Τύπος Κατασκευής"
        Me.LayoutControlItem51.TextSize = New System.Drawing.Size(294, 23)
        '
        'LayoutControlItem53
        '
        Me.LayoutControlItem53.Control = Me.cboBaza
        Me.LayoutControlItem53.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem53.CustomizationFormText = "Τύπος"
        Me.LayoutControlItem53.Location = New System.Drawing.Point(0, 336)
        Me.LayoutControlItem53.Name = "LayoutControlItem53"
        Me.LayoutControlItem53.Size = New System.Drawing.Size(604, 42)
        Me.LayoutControlItem53.Text = "Μπάζα"
        Me.LayoutControlItem53.TextSize = New System.Drawing.Size(294, 23)
        '
        'LayoutControlItem54
        '
        Me.LayoutControlItem54.Control = Me.cboLegs
        Me.LayoutControlItem54.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem54.CustomizationFormText = "Τύπος"
        Me.LayoutControlItem54.Location = New System.Drawing.Point(0, 378)
        Me.LayoutControlItem54.Name = "LayoutControlItem54"
        Me.LayoutControlItem54.Size = New System.Drawing.Size(604, 42)
        Me.LayoutControlItem54.Text = "Πόδια"
        Me.LayoutControlItem54.TextSize = New System.Drawing.Size(294, 23)
        '
        'LayoutControlItem52
        '
        Me.LayoutControlItem52.Control = Me.cboGOLAColors
        Me.LayoutControlItem52.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem52.CustomizationFormText = "Χρώμα PVC"
        Me.LayoutControlItem52.Location = New System.Drawing.Point(0, 84)
        Me.LayoutControlItem52.Name = "LayoutControlItem52"
        Me.LayoutControlItem52.Size = New System.Drawing.Size(604, 42)
        Me.LayoutControlItem52.Text = "Χρώμα Gola"
        Me.LayoutControlItem52.TextSize = New System.Drawing.Size(294, 23)
        '
        'LayoutControlItem22
        '
        Me.LayoutControlItem22.Control = Me.txtVdoorCode
        Me.LayoutControlItem22.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem22.CustomizationFormText = "Πλάτη"
        Me.LayoutControlItem22.Location = New System.Drawing.Point(0, 462)
        Me.LayoutControlItem22.MaxSize = New System.Drawing.Size(0, 46)
        Me.LayoutControlItem22.MinSize = New System.Drawing.Size(309, 46)
        Me.LayoutControlItem22.Name = "LayoutControlItem22"
        Me.LayoutControlItem22.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 3, 4, 4)
        Me.LayoutControlItem22.Size = New System.Drawing.Size(604, 46)
        Me.LayoutControlItem22.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem22.Text = "Κωδικός Πόρτας-Εταιρία"
        Me.LayoutControlItem22.TextSize = New System.Drawing.Size(294, 23)
        '
        'LayoutControlItem18
        '
        Me.LayoutControlItem18.Control = Me.txtVShelves
        Me.LayoutControlItem18.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem18.CustomizationFormText = "Αριθμός"
        Me.LayoutControlItem18.Location = New System.Drawing.Point(0, 550)
        Me.LayoutControlItem18.Name = "LayoutControlItem18"
        Me.LayoutControlItem18.Size = New System.Drawing.Size(604, 81)
        Me.LayoutControlItem18.Text = "Κωδικός Ραφιέρας"
        Me.LayoutControlItem18.TextSize = New System.Drawing.Size(294, 23)
        '
        'LayoutControlItem24
        '
        Me.LayoutControlItem24.Control = Me.cboVwater
        Me.LayoutControlItem24.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem24.CustomizationFormText = "Τύπος"
        Me.LayoutControlItem24.Location = New System.Drawing.Point(0, 420)
        Me.LayoutControlItem24.Name = "LayoutControlItem24"
        Me.LayoutControlItem24.Size = New System.Drawing.Size(604, 42)
        Me.LayoutControlItem24.Text = "Νερά"
        Me.LayoutControlItem24.TextSize = New System.Drawing.Size(294, 23)
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.cboVependisisDoorType
        Me.LayoutControlItem6.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem6.CustomizationFormText = "Έργο Πελάτη"
        Me.LayoutControlItem6.Location = New System.Drawing.Point(0, 252)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(604, 42)
        Me.LayoutControlItem6.Text = "Επενδύσεις Βάσεως"
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(294, 23)
        '
        'LayoutControlItem73
        '
        Me.LayoutControlItem73.Control = Me.cboNependisisDoorType
        Me.LayoutControlItem73.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem73.CustomizationFormText = "Έργο Πελάτη"
        Me.LayoutControlItem73.Location = New System.Drawing.Point(0, 294)
        Me.LayoutControlItem73.Name = "LayoutControlItem73"
        Me.LayoutControlItem73.Size = New System.Drawing.Size(604, 42)
        Me.LayoutControlItem73.Text = "Επενδύσεις Νησίδας"
        Me.LayoutControlItem73.TextSize = New System.Drawing.Size(294, 23)
        '
        'LayoutControlItem15
        '
        Me.LayoutControlItem15.Control = Me.cboVDoorType
        Me.LayoutControlItem15.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem15.CustomizationFormText = "Έργο Πελάτη"
        Me.LayoutControlItem15.Location = New System.Drawing.Point(0, 168)
        Me.LayoutControlItem15.Name = "LayoutControlItem15"
        Me.LayoutControlItem15.Size = New System.Drawing.Size(604, 42)
        Me.LayoutControlItem15.Text = "Κατηγορία Υλικού 1"
        Me.LayoutControlItem15.TextSize = New System.Drawing.Size(294, 23)
        '
        'LayoutControlItem33
        '
        Me.LayoutControlItem33.Control = Me.cboVDoorType1
        Me.LayoutControlItem33.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem33.CustomizationFormText = "Έργο Πελάτη"
        Me.LayoutControlItem33.Location = New System.Drawing.Point(0, 210)
        Me.LayoutControlItem33.Name = "LayoutControlItem33"
        Me.LayoutControlItem33.Size = New System.Drawing.Size(604, 42)
        Me.LayoutControlItem33.Text = "Κατηγορία Υλικού 2"
        Me.LayoutControlItem33.TextSize = New System.Drawing.Size(294, 23)
        '
        'LayoutControlItem58
        '
        Me.LayoutControlItem58.Control = Me.cboVRafieraDoorType
        Me.LayoutControlItem58.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem58.CustomizationFormText = "Έργο Πελάτη"
        Me.LayoutControlItem58.Location = New System.Drawing.Point(0, 508)
        Me.LayoutControlItem58.Name = "LayoutControlItem58"
        Me.LayoutControlItem58.Size = New System.Drawing.Size(604, 42)
        Me.LayoutControlItem58.Text = "Ραφιέρα"
        Me.LayoutControlItem58.TextSize = New System.Drawing.Size(294, 23)
        '
        'LayoutControlGroup5
        '
        Me.LayoutControlGroup5.AppearanceGroup.BorderColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Danger
        Me.LayoutControlGroup5.AppearanceGroup.Options.UseBorderColor = True
        Me.LayoutControlGroup5.CustomizationFormText = "Βάσεως"
        Me.LayoutControlGroup5.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem3, Me.LayoutControlItem5, Me.LayoutControlItem11, Me.LayoutControlItem50, Me.LayoutControlItem55, Me.LayoutControlItem57, Me.LayoutControlItem60, Me.LayoutControlItem59, Me.LayoutControlItem23, Me.LayoutControlItem37, Me.LayoutControlItem61, Me.LayoutControlItem45, Me.LayoutControlItem74, Me.LayoutControlItem56, Me.LayoutControlItem20, Me.LayoutControlItem65, Me.LayoutControlItem70})
        Me.LayoutControlGroup5.Location = New System.Drawing.Point(630, 0)
        Me.LayoutControlGroup5.Name = "LayoutControlGroup5"
        Me.LayoutControlGroup5.OptionsItemText.TextToControlDistance = 3
        Me.LayoutControlGroup5.Size = New System.Drawing.Size(626, 693)
        Me.LayoutControlGroup5.Text = "Κρεμαστά"
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.txtKHeight
        Me.LayoutControlItem3.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem3.CustomizationFormText = "Ύψος"
        Me.LayoutControlItem3.HighlightFocusedItem = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 42)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(410, 42)
        Me.LayoutControlItem3.Text = "Ύψος (cm)"
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(294, 23)
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.cboKBOXColors
        Me.LayoutControlItem5.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem5.CustomizationFormText = "Χρώμα PVC"
        Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 126)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(600, 42)
        Me.LayoutControlItem5.Text = "Χρώμα Κουτιού"
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(294, 23)
        '
        'LayoutControlItem11
        '
        Me.LayoutControlItem11.Control = Me.txtKFinalHeight
        Me.LayoutControlItem11.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem11.CustomizationFormText = "Ύψος"
        Me.LayoutControlItem11.HighlightFocusedItem = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlItem11.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem11.Name = "LayoutControlItem11"
        Me.LayoutControlItem11.Size = New System.Drawing.Size(600, 42)
        Me.LayoutControlItem11.Text = "Τελικό Ύψος (cm)"
        Me.LayoutControlItem11.TextSize = New System.Drawing.Size(294, 23)
        '
        'LayoutControlItem50
        '
        Me.LayoutControlItem50.Control = Me.txtKHeight2
        Me.LayoutControlItem50.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem50.CustomizationFormText = "Ύψος"
        Me.LayoutControlItem50.HighlightFocusedItem = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlItem50.Location = New System.Drawing.Point(410, 42)
        Me.LayoutControlItem50.Name = "LayoutControlItem50"
        Me.LayoutControlItem50.Size = New System.Drawing.Size(190, 42)
        Me.LayoutControlItem50.Text = "Ύψος (cm)"
        Me.LayoutControlItem50.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
        Me.LayoutControlItem50.TextSize = New System.Drawing.Size(91, 23)
        Me.LayoutControlItem50.TextToControlDistance = 1
        '
        'LayoutControlItem55
        '
        Me.LayoutControlItem55.Control = Me.txtKdoorCode
        Me.LayoutControlItem55.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem55.CustomizationFormText = "Πλάτη"
        Me.LayoutControlItem55.Location = New System.Drawing.Point(0, 336)
        Me.LayoutControlItem55.MaxSize = New System.Drawing.Size(0, 46)
        Me.LayoutControlItem55.MinSize = New System.Drawing.Size(309, 46)
        Me.LayoutControlItem55.Name = "LayoutControlItem55"
        Me.LayoutControlItem55.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 3, 4, 4)
        Me.LayoutControlItem55.Size = New System.Drawing.Size(600, 46)
        Me.LayoutControlItem55.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem55.Text = "Κωδικός Πόρτας-Εταιρία"
        Me.LayoutControlItem55.TextSize = New System.Drawing.Size(294, 23)
        '
        'LayoutControlItem57
        '
        Me.LayoutControlItem57.Control = Me.cboKwater
        Me.LayoutControlItem57.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem57.CustomizationFormText = "Τύπος"
        Me.LayoutControlItem57.Location = New System.Drawing.Point(0, 382)
        Me.LayoutControlItem57.Name = "LayoutControlItem57"
        Me.LayoutControlItem57.Size = New System.Drawing.Size(600, 42)
        Me.LayoutControlItem57.Text = "Νερά"
        Me.LayoutControlItem57.TextSize = New System.Drawing.Size(294, 23)
        '
        'LayoutControlItem60
        '
        Me.LayoutControlItem60.Control = Me.txtKShelves
        Me.LayoutControlItem60.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem60.CustomizationFormText = "Αριθμός"
        Me.LayoutControlItem60.Location = New System.Drawing.Point(0, 547)
        Me.LayoutControlItem60.Name = "LayoutControlItem60"
        Me.LayoutControlItem60.Size = New System.Drawing.Size(600, 42)
        Me.LayoutControlItem60.Text = "Κωδικός Ραφιέρας"
        Me.LayoutControlItem60.TextSize = New System.Drawing.Size(294, 23)
        '
        'LayoutControlItem59
        '
        Me.LayoutControlItem59.Control = Me.cboLedProfil
        Me.LayoutControlItem59.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem59.CustomizationFormText = "Τύπος"
        Me.LayoutControlItem59.Location = New System.Drawing.Point(0, 463)
        Me.LayoutControlItem59.Name = "LayoutControlItem59"
        Me.LayoutControlItem59.Size = New System.Drawing.Size(600, 42)
        Me.LayoutControlItem59.Text = "Χωνευτό προφίλ για Led"
        Me.LayoutControlItem59.TextSize = New System.Drawing.Size(294, 23)
        '
        'LayoutControlItem23
        '
        Me.LayoutControlItem23.Control = Me.chkHangingOnDoors
        Me.LayoutControlItem23.Location = New System.Drawing.Point(0, 424)
        Me.LayoutControlItem23.Name = "LayoutControlItem23"
        Me.LayoutControlItem23.Size = New System.Drawing.Size(300, 39)
        Me.LayoutControlItem23.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem23.TextVisible = False
        '
        'LayoutControlItem37
        '
        Me.LayoutControlItem37.Control = Me.cboKType
        Me.LayoutControlItem37.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem37.CustomizationFormText = "Τύπος"
        Me.LayoutControlItem37.Location = New System.Drawing.Point(0, 84)
        Me.LayoutControlItem37.Name = "LayoutControlItem37"
        Me.LayoutControlItem37.Size = New System.Drawing.Size(600, 42)
        Me.LayoutControlItem37.Text = "Τύπος"
        Me.LayoutControlItem37.TextSize = New System.Drawing.Size(294, 23)
        '
        'LayoutControlItem61
        '
        Me.LayoutControlItem61.Control = Me.chkHoodAlignment
        Me.LayoutControlItem61.Location = New System.Drawing.Point(300, 424)
        Me.LayoutControlItem61.Name = "LayoutControlItem61"
        Me.LayoutControlItem61.Size = New System.Drawing.Size(300, 39)
        Me.LayoutControlItem61.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem61.TextVisible = False
        '
        'LayoutControlItem45
        '
        Me.LayoutControlItem45.Control = Me.cboKDoorType
        Me.LayoutControlItem45.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem45.CustomizationFormText = "Έργο Πελάτη"
        Me.LayoutControlItem45.Location = New System.Drawing.Point(0, 168)
        Me.LayoutControlItem45.Name = "LayoutControlItem45"
        Me.LayoutControlItem45.Size = New System.Drawing.Size(600, 42)
        Me.LayoutControlItem45.Text = "Κατηγορία Υλικού 1"
        Me.LayoutControlItem45.TextSize = New System.Drawing.Size(294, 23)
        '
        'LayoutControlItem74
        '
        Me.LayoutControlItem74.Control = Me.cboKDoorType1
        Me.LayoutControlItem74.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem74.CustomizationFormText = "Έργο Πελάτη"
        Me.LayoutControlItem74.Location = New System.Drawing.Point(0, 210)
        Me.LayoutControlItem74.Name = "LayoutControlItem74"
        Me.LayoutControlItem74.Size = New System.Drawing.Size(600, 42)
        Me.LayoutControlItem74.Text = "Κατηγορία Υλικού 2"
        Me.LayoutControlItem74.TextSize = New System.Drawing.Size(294, 23)
        '
        'LayoutControlItem56
        '
        Me.LayoutControlItem56.Control = Me.cboKependisisDoorType
        Me.LayoutControlItem56.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem56.CustomizationFormText = "Έργο Πελάτη"
        Me.LayoutControlItem56.Location = New System.Drawing.Point(0, 252)
        Me.LayoutControlItem56.Name = "LayoutControlItem56"
        Me.LayoutControlItem56.Size = New System.Drawing.Size(600, 42)
        Me.LayoutControlItem56.Text = "Επενδύσεις Κρεμαστών"
        Me.LayoutControlItem56.TextSize = New System.Drawing.Size(294, 23)
        '
        'LayoutControlItem20
        '
        Me.LayoutControlItem20.Control = Me.cboSndEpendisisDoorType
        Me.LayoutControlItem20.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem20.CustomizationFormText = "Έργο Πελάτη"
        Me.LayoutControlItem20.Location = New System.Drawing.Point(0, 294)
        Me.LayoutControlItem20.Name = "LayoutControlItem20"
        Me.LayoutControlItem20.Size = New System.Drawing.Size(600, 42)
        Me.LayoutControlItem20.Text = "Επενδύσεις 2ης σειράς"
        Me.LayoutControlItem20.TextSize = New System.Drawing.Size(294, 23)
        '
        'LayoutControlItem65
        '
        Me.LayoutControlItem65.Control = Me.cboKRafieraDoorType
        Me.LayoutControlItem65.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem65.CustomizationFormText = "Έργο Πελάτη"
        Me.LayoutControlItem65.Location = New System.Drawing.Point(0, 505)
        Me.LayoutControlItem65.Name = "LayoutControlItem65"
        Me.LayoutControlItem65.Size = New System.Drawing.Size(600, 42)
        Me.LayoutControlItem65.Text = "Ραφιέρα"
        Me.LayoutControlItem65.TextSize = New System.Drawing.Size(294, 23)
        '
        'LayoutControlItem70
        '
        Me.LayoutControlItem70.Control = Me.cboKWallRafiaDoorType
        Me.LayoutControlItem70.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem70.CustomizationFormText = "Έργο Πελάτη"
        Me.LayoutControlItem70.Location = New System.Drawing.Point(0, 589)
        Me.LayoutControlItem70.Name = "LayoutControlItem70"
        Me.LayoutControlItem70.Size = New System.Drawing.Size(600, 42)
        Me.LayoutControlItem70.Text = "Ράφια Τοίχου"
        Me.LayoutControlItem70.TextSize = New System.Drawing.Size(294, 23)
        '
        'LayoutControlGroup6
        '
        Me.LayoutControlGroup6.AppearanceGroup.BorderColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Warning
        Me.LayoutControlGroup6.AppearanceGroup.Options.UseBorderColor = True
        Me.LayoutControlGroup6.CustomizationFormText = "Βάσεως"
        Me.LayoutControlGroup6.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem10, Me.LayoutControlItem14, Me.LayoutControlItem16, Me.LayoutControlItem62, Me.LayoutControlItem64, Me.LayoutControlItem63, Me.LayoutControlItem39, Me.LayoutControlItem72, Me.LayoutControlItem36, Me.LayoutControlItem48, Me.LayoutControlItem41, Me.LayoutControlItem69})
        Me.LayoutControlGroup6.Location = New System.Drawing.Point(1256, 0)
        Me.LayoutControlGroup6.Name = "LayoutControlGroup6"
        Me.LayoutControlGroup6.OptionsItemText.TextToControlDistance = 3
        Me.LayoutControlGroup6.Size = New System.Drawing.Size(583, 693)
        Me.LayoutControlGroup6.Text = "Υψηλά"
        '
        'LayoutControlItem10
        '
        Me.LayoutControlItem10.Control = Me.txtOtherHeight
        Me.LayoutControlItem10.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem10.CustomizationFormText = "Ύψος"
        Me.LayoutControlItem10.HighlightFocusedItem = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlItem10.Location = New System.Drawing.Point(0, 84)
        Me.LayoutControlItem10.Name = "LayoutControlItem10"
        Me.LayoutControlItem10.Size = New System.Drawing.Size(557, 42)
        Me.LayoutControlItem10.Text = "Άλλο Ύψος (cm)"
        Me.LayoutControlItem10.TextSize = New System.Drawing.Size(294, 23)
        '
        'LayoutControlItem14
        '
        Me.LayoutControlItem14.Control = Me.cboYBOXColors
        Me.LayoutControlItem14.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem14.CustomizationFormText = "Χρώμα PVC"
        Me.LayoutControlItem14.Location = New System.Drawing.Point(0, 168)
        Me.LayoutControlItem14.Name = "LayoutControlItem14"
        Me.LayoutControlItem14.Size = New System.Drawing.Size(557, 42)
        Me.LayoutControlItem14.Text = "Χρώμα Κουτιού"
        Me.LayoutControlItem14.TextSize = New System.Drawing.Size(294, 23)
        '
        'LayoutControlItem16
        '
        Me.LayoutControlItem16.Control = Me.txtYFinalHeight
        Me.LayoutControlItem16.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem16.CustomizationFormText = "Ύψος"
        Me.LayoutControlItem16.HighlightFocusedItem = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlItem16.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem16.Name = "LayoutControlItem16"
        Me.LayoutControlItem16.Size = New System.Drawing.Size(557, 42)
        Me.LayoutControlItem16.Text = "Τελικό Ύψος (cm)"
        Me.LayoutControlItem16.TextSize = New System.Drawing.Size(294, 23)
        '
        'LayoutControlItem62
        '
        Me.LayoutControlItem62.Control = Me.cboYHeight
        Me.LayoutControlItem62.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem62.CustomizationFormText = "Ύψος"
        Me.LayoutControlItem62.HighlightFocusedItem = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlItem62.Location = New System.Drawing.Point(0, 42)
        Me.LayoutControlItem62.Name = "LayoutControlItem62"
        Me.LayoutControlItem62.Size = New System.Drawing.Size(557, 42)
        Me.LayoutControlItem62.Text = "Ύψος (cm)"
        Me.LayoutControlItem62.TextSize = New System.Drawing.Size(294, 23)
        '
        'LayoutControlItem64
        '
        Me.LayoutControlItem64.Control = Me.cboYwater
        Me.LayoutControlItem64.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem64.CustomizationFormText = "Τύπος"
        Me.LayoutControlItem64.Location = New System.Drawing.Point(0, 382)
        Me.LayoutControlItem64.Name = "LayoutControlItem64"
        Me.LayoutControlItem64.Size = New System.Drawing.Size(557, 42)
        Me.LayoutControlItem64.Text = "Νερά"
        Me.LayoutControlItem64.TextSize = New System.Drawing.Size(294, 23)
        '
        'LayoutControlItem63
        '
        Me.LayoutControlItem63.Control = Me.txtYdoorCode
        Me.LayoutControlItem63.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem63.CustomizationFormText = "Πλάτη"
        Me.LayoutControlItem63.Location = New System.Drawing.Point(0, 336)
        Me.LayoutControlItem63.MaxSize = New System.Drawing.Size(0, 46)
        Me.LayoutControlItem63.MinSize = New System.Drawing.Size(309, 46)
        Me.LayoutControlItem63.Name = "LayoutControlItem63"
        Me.LayoutControlItem63.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 3, 4, 4)
        Me.LayoutControlItem63.Size = New System.Drawing.Size(557, 46)
        Me.LayoutControlItem63.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem63.Text = "Κωδικός Πόρτας-Εταιρία"
        Me.LayoutControlItem63.TextSize = New System.Drawing.Size(294, 23)
        '
        'LayoutControlItem39
        '
        Me.LayoutControlItem39.Control = Me.cboYType
        Me.LayoutControlItem39.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem39.CustomizationFormText = "Τύπος"
        Me.LayoutControlItem39.Location = New System.Drawing.Point(0, 126)
        Me.LayoutControlItem39.Name = "LayoutControlItem39"
        Me.LayoutControlItem39.Size = New System.Drawing.Size(557, 42)
        Me.LayoutControlItem39.Text = "Τύπος Κατασκευής"
        Me.LayoutControlItem39.TextSize = New System.Drawing.Size(294, 23)
        '
        'LayoutControlItem72
        '
        Me.LayoutControlItem72.Control = Me.txtYShelves
        Me.LayoutControlItem72.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem72.CustomizationFormText = "Αριθμός"
        Me.LayoutControlItem72.Location = New System.Drawing.Point(0, 466)
        Me.LayoutControlItem72.Name = "LayoutControlItem72"
        Me.LayoutControlItem72.Size = New System.Drawing.Size(557, 165)
        Me.LayoutControlItem72.Text = "Κωδικός Ραφιέρας"
        Me.LayoutControlItem72.TextSize = New System.Drawing.Size(294, 23)
        '
        'LayoutControlItem36
        '
        Me.LayoutControlItem36.Control = Me.cboYDoorType
        Me.LayoutControlItem36.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem36.CustomizationFormText = "Έργο Πελάτη"
        Me.LayoutControlItem36.Location = New System.Drawing.Point(0, 210)
        Me.LayoutControlItem36.Name = "LayoutControlItem36"
        Me.LayoutControlItem36.Size = New System.Drawing.Size(557, 42)
        Me.LayoutControlItem36.Text = "Κατηγορία Υλικού 1"
        Me.LayoutControlItem36.TextSize = New System.Drawing.Size(294, 23)
        '
        'LayoutControlItem48
        '
        Me.LayoutControlItem48.Control = Me.cboYDoorType1
        Me.LayoutControlItem48.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem48.CustomizationFormText = "Έργο Πελάτη"
        Me.LayoutControlItem48.Location = New System.Drawing.Point(0, 252)
        Me.LayoutControlItem48.Name = "LayoutControlItem48"
        Me.LayoutControlItem48.Size = New System.Drawing.Size(557, 42)
        Me.LayoutControlItem48.Text = "Κατηγορία Υλικού 2"
        Me.LayoutControlItem48.TextSize = New System.Drawing.Size(294, 23)
        '
        'LayoutControlItem41
        '
        Me.LayoutControlItem41.Control = Me.cboPependisisDoorType
        Me.LayoutControlItem41.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem41.CustomizationFormText = "Έργο Πελάτη"
        Me.LayoutControlItem41.Location = New System.Drawing.Point(0, 294)
        Me.LayoutControlItem41.Name = "LayoutControlItem41"
        Me.LayoutControlItem41.Size = New System.Drawing.Size(557, 42)
        Me.LayoutControlItem41.Text = "Πλαϊνά Υψηλά"
        Me.LayoutControlItem41.TextSize = New System.Drawing.Size(294, 23)
        '
        'LayoutControlItem69
        '
        Me.LayoutControlItem69.Control = Me.cboYRafieraDoorType
        Me.LayoutControlItem69.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem69.CustomizationFormText = "Έργο Πελάτη"
        Me.LayoutControlItem69.Location = New System.Drawing.Point(0, 424)
        Me.LayoutControlItem69.Name = "LayoutControlItem69"
        Me.LayoutControlItem69.Size = New System.Drawing.Size(557, 42)
        Me.LayoutControlItem69.Text = "Ραφιέρα"
        Me.LayoutControlItem69.TextSize = New System.Drawing.Size(294, 23)
        '
        'LayoutControlGroup7
        '
        Me.LayoutControlGroup7.CustomizationFormText = "Βάσεως"
        Me.LayoutControlGroup7.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem25, Me.LayoutControlItem17, Me.LayoutControlItem12, Me.LayoutControlItem66, Me.LayoutControlItem67, Me.LayoutControlItem68, Me.EmptySpaceItem5})
        Me.LayoutControlGroup7.Location = New System.Drawing.Point(0, 693)
        Me.LayoutControlGroup7.Name = "LayoutControlGroup7"
        Me.LayoutControlGroup7.OptionsItemText.TextToControlDistance = 3
        Me.LayoutControlGroup7.Size = New System.Drawing.Size(1839, 150)
        Me.LayoutControlGroup7.Text = "Πάγκοι"
        '
        'LayoutControlItem25
        '
        Me.LayoutControlItem25.Control = Me.txtbenchCode
        Me.LayoutControlItem25.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem25.CustomizationFormText = "Κατηγορία"
        Me.LayoutControlItem25.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem25.Name = "LayoutControlItem25"
        Me.LayoutControlItem25.Size = New System.Drawing.Size(484, 42)
        Me.LayoutControlItem25.Text = "Κωδικός Πάγκου"
        Me.LayoutControlItem25.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
        Me.LayoutControlItem25.TextSize = New System.Drawing.Size(135, 23)
        Me.LayoutControlItem25.TextToControlDistance = 5
        '
        'LayoutControlItem17
        '
        Me.LayoutControlItem17.Control = Me.txtbackCode
        Me.LayoutControlItem17.Location = New System.Drawing.Point(0, 42)
        Me.LayoutControlItem17.MaxSize = New System.Drawing.Size(0, 46)
        Me.LayoutControlItem17.MinSize = New System.Drawing.Size(385, 46)
        Me.LayoutControlItem17.Name = "LayoutControlItem17"
        Me.LayoutControlItem17.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 3, 4, 4)
        Me.LayoutControlItem17.Size = New System.Drawing.Size(484, 46)
        Me.LayoutControlItem17.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem17.Text = "Κωδικός Πλάτης"
        Me.LayoutControlItem17.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
        Me.LayoutControlItem17.TextSize = New System.Drawing.Size(134, 23)
        Me.LayoutControlItem17.TextToControlDistance = 8
        '
        'LayoutControlItem12
        '
        Me.LayoutControlItem12.Control = Me.cbobenchThickness
        Me.LayoutControlItem12.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem12.CustomizationFormText = "Τύπος"
        Me.LayoutControlItem12.Location = New System.Drawing.Point(1444, 0)
        Me.LayoutControlItem12.Name = "LayoutControlItem12"
        Me.LayoutControlItem12.Size = New System.Drawing.Size(369, 42)
        Me.LayoutControlItem12.Text = "Πάχος"
        Me.LayoutControlItem12.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
        Me.LayoutControlItem12.TextSize = New System.Drawing.Size(52, 23)
        Me.LayoutControlItem12.TextToControlDistance = 5
        '
        'LayoutControlItem66
        '
        Me.LayoutControlItem66.Control = Me.cboBenchType
        Me.LayoutControlItem66.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem66.CustomizationFormText = "Έργο Πελάτη"
        Me.LayoutControlItem66.Location = New System.Drawing.Point(484, 0)
        Me.LayoutControlItem66.Name = "LayoutControlItem66"
        Me.LayoutControlItem66.Size = New System.Drawing.Size(467, 42)
        Me.LayoutControlItem66.Text = "Κατηγορία Πάγκου 1"
        Me.LayoutControlItem66.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
        Me.LayoutControlItem66.TextSize = New System.Drawing.Size(171, 23)
        Me.LayoutControlItem66.TextToControlDistance = 5
        '
        'LayoutControlItem67
        '
        Me.LayoutControlItem67.Control = Me.cboBack
        Me.LayoutControlItem67.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem67.CustomizationFormText = "Έργο Πελάτη"
        Me.LayoutControlItem67.Location = New System.Drawing.Point(484, 42)
        Me.LayoutControlItem67.Name = "LayoutControlItem67"
        Me.LayoutControlItem67.Size = New System.Drawing.Size(467, 46)
        Me.LayoutControlItem67.Text = "Κατηγορία Υλικού"
        Me.LayoutControlItem67.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
        Me.LayoutControlItem67.TextSize = New System.Drawing.Size(146, 23)
        Me.LayoutControlItem67.TextToControlDistance = 15
        '
        'LayoutControlItem68
        '
        Me.LayoutControlItem68.Control = Me.cboBenchType2
        Me.LayoutControlItem68.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem68.CustomizationFormText = "Έργο Πελάτη"
        Me.LayoutControlItem68.Location = New System.Drawing.Point(951, 0)
        Me.LayoutControlItem68.Name = "LayoutControlItem68"
        Me.LayoutControlItem68.Size = New System.Drawing.Size(493, 42)
        Me.LayoutControlItem68.Text = "Έξτρα πάγκοι-Τραπέζι"
        Me.LayoutControlItem68.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
        Me.LayoutControlItem68.TextSize = New System.Drawing.Size(181, 23)
        Me.LayoutControlItem68.TextToControlDistance = 5
        '
        'EmptySpaceItem5
        '
        Me.EmptySpaceItem5.AllowHotTrack = False
        Me.EmptySpaceItem5.Location = New System.Drawing.Point(951, 42)
        Me.EmptySpaceItem5.Name = "EmptySpaceItem5"
        Me.EmptySpaceItem5.Size = New System.Drawing.Size(862, 46)
        Me.EmptySpaceItem5.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem40
        '
        Me.LayoutControlItem40.Control = Me.txtExtraInst
        Me.LayoutControlItem40.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem40.CustomizationFormText = "Τελική Αξία"
        Me.LayoutControlItem40.HighlightFocusedItem = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlItem40.Location = New System.Drawing.Point(887, 885)
        Me.LayoutControlItem40.Name = "LayoutControlItem40"
        Me.LayoutControlItem40.Size = New System.Drawing.Size(467, 42)
        Me.LayoutControlItem40.Text = "Τοποθέτηση(Εκτός Αττικής)"
        Me.LayoutControlItem40.TextSize = New System.Drawing.Size(294, 23)
        '
        'LayoutControlItem29
        '
        Me.LayoutControlItem29.Control = Me.txtPartofVat
        Me.LayoutControlItem29.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem29.CustomizationFormText = "Τελική Αξία"
        Me.LayoutControlItem29.HighlightFocusedItem = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlItem29.Location = New System.Drawing.Point(887, 927)
        Me.LayoutControlItem29.Name = "LayoutControlItem29"
        Me.LayoutControlItem29.Size = New System.Drawing.Size(467, 50)
        Me.LayoutControlItem29.Text = "Συμφωνηθέν ΦΠΑ"
        Me.LayoutControlItem29.TextSize = New System.Drawing.Size(294, 23)
        '
        'LayoutControlItem34
        '
        Me.LayoutControlItem34.Control = Me.txtTotalErmariaVat
        Me.LayoutControlItem34.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem34.CustomizationFormText = "Τελική Αξία"
        Me.LayoutControlItem34.HighlightFocusedItem = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlItem34.Location = New System.Drawing.Point(1354, 843)
        Me.LayoutControlItem34.Name = "LayoutControlItem34"
        Me.LayoutControlItem34.Size = New System.Drawing.Size(485, 42)
        Me.LayoutControlItem34.Text = "Συνολική Αξία Ερμαρίων προ Φ.Π.Α"
        Me.LayoutControlItem34.TextSize = New System.Drawing.Size(294, 23)
        '
        'LayoutControlItem42
        '
        Me.LayoutControlItem42.Control = Me.txtTotalErmariaPice
        Me.LayoutControlItem42.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem42.CustomizationFormText = "Τελική Αξία"
        Me.LayoutControlItem42.HighlightFocusedItem = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlItem42.Location = New System.Drawing.Point(1354, 885)
        Me.LayoutControlItem42.Name = "LayoutControlItem42"
        Me.LayoutControlItem42.Size = New System.Drawing.Size(485, 46)
        Me.LayoutControlItem42.Text = "Συνολική Αξία Ερμαρίων με Φ.Π.Α"
        Me.LayoutControlItem42.TextSize = New System.Drawing.Size(294, 23)
        '
        'LayoutControlItem35
        '
        Me.LayoutControlItem35.Control = Me.txtTotalDevicesPrice
        Me.LayoutControlItem35.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem35.CustomizationFormText = "Τελική Αξία"
        Me.LayoutControlItem35.HighlightFocusedItem = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlItem35.Location = New System.Drawing.Point(1354, 931)
        Me.LayoutControlItem35.Name = "LayoutControlItem35"
        Me.LayoutControlItem35.Size = New System.Drawing.Size(485, 46)
        Me.LayoutControlItem35.Text = "Συνολική Αξία συσκευών με ΦΠΑ"
        Me.LayoutControlItem35.TextSize = New System.Drawing.Size(294, 23)
        '
        'LayoutControlItem43
        '
        Me.LayoutControlItem43.Control = Me.txtMeasurement
        Me.LayoutControlItem43.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem43.CustomizationFormText = "Τελική Αξία"
        Me.LayoutControlItem43.HighlightFocusedItem = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlItem43.Location = New System.Drawing.Point(415, 843)
        Me.LayoutControlItem43.Name = "LayoutControlItem43"
        Me.LayoutControlItem43.Size = New System.Drawing.Size(472, 42)
        Me.LayoutControlItem43.Text = "Επιμέτρηση Κουζίνας"
        Me.LayoutControlItem43.TextSize = New System.Drawing.Size(294, 23)
        '
        'LayoutControlItem44
        '
        Me.LayoutControlItem44.Control = Me.txtRemove
        Me.LayoutControlItem44.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem44.CustomizationFormText = "Τελική Αξία"
        Me.LayoutControlItem44.HighlightFocusedItem = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlItem44.Location = New System.Drawing.Point(415, 885)
        Me.LayoutControlItem44.Name = "LayoutControlItem44"
        Me.LayoutControlItem44.Size = New System.Drawing.Size(472, 42)
        Me.LayoutControlItem44.Text = "Αποξύλωση Κουζίνας"
        Me.LayoutControlItem44.TextSize = New System.Drawing.Size(294, 23)
        '
        'EmptySpaceItem4
        '
        Me.EmptySpaceItem4.AllowHotTrack = False
        Me.EmptySpaceItem4.Location = New System.Drawing.Point(0, 843)
        Me.EmptySpaceItem4.Name = "EmptySpaceItem4"
        Me.EmptySpaceItem4.Size = New System.Drawing.Size(415, 134)
        Me.EmptySpaceItem4.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem38
        '
        Me.LayoutControlItem38.Control = Me.txtExtraTransp
        Me.LayoutControlItem38.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem38.CustomizationFormText = "Τελική Αξία"
        Me.LayoutControlItem38.HighlightFocusedItem = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlItem38.Location = New System.Drawing.Point(887, 843)
        Me.LayoutControlItem38.Name = "LayoutControlItem38"
        Me.LayoutControlItem38.Size = New System.Drawing.Size(467, 42)
        Me.LayoutControlItem38.Text = "Μεταφορά(Εκτός Αττικής)"
        Me.LayoutControlItem38.TextSize = New System.Drawing.Size(294, 23)
        '
        'LayoutControlItem76
        '
        Me.LayoutControlItem76.Control = Me.txtTransp
        Me.LayoutControlItem76.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem76.CustomizationFormText = "Τελική Αξία"
        Me.LayoutControlItem76.HighlightFocusedItem = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlItem76.Location = New System.Drawing.Point(415, 927)
        Me.LayoutControlItem76.Name = "LayoutControlItem76"
        Me.LayoutControlItem76.Size = New System.Drawing.Size(472, 50)
        Me.LayoutControlItem76.Text = "Μεταφορά Κουζίνας"
        Me.LayoutControlItem76.TextSize = New System.Drawing.Size(294, 23)
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem30, Me.LayoutControlItem7, Me.LayoutControlItem4, Me.EmptySpaceItem1, Me.LayoutControlItem8, Me.LayoutControlItem31, Me.LayoutControlItem47, Me.LayoutControlItem13, Me.LayoutControlItem28, Me.LayoutControlItem9, Me.LayoutControlItem1, Me.LayoutControlItem46})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
        Me.LayoutControlGroup1.OptionsItemText.TextToControlDistance = 1
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(1865, 230)
        Me.LayoutControlGroup1.Text = "Στοιχεία Παραγγελίας"
        '
        'LayoutControlItem30
        '
        Me.LayoutControlItem30.Control = Me.dtpresentation
        Me.LayoutControlItem30.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem30.CustomizationFormText = "Ημερ/νία Προσφοράς"
        Me.LayoutControlItem30.ImageOptions.Image = CType(resources.GetObject("LayoutControlItem30.ImageOptions.Image"), System.Drawing.Image)
        Me.LayoutControlItem30.Location = New System.Drawing.Point(0, 126)
        Me.LayoutControlItem30.Name = "LayoutControlItem30"
        Me.LayoutControlItem30.Size = New System.Drawing.Size(674, 42)
        Me.LayoutControlItem30.Tag = "1"
        Me.LayoutControlItem30.Text = "Ημερ/νία Προσφοράς"
        Me.LayoutControlItem30.TextSize = New System.Drawing.Size(294, 23)
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.Control = Me.txtADR
        Me.LayoutControlItem7.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem7.CustomizationFormText = "Διεύθυνση"
        Me.LayoutControlItem7.Location = New System.Drawing.Point(527, 84)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(703, 42)
        Me.LayoutControlItem7.Text = "Διεύθυνση"
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(294, 23)
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.txtCode
        Me.LayoutControlItem4.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem4.CustomizationFormText = "Κωδικός"
        Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(406, 42)
        Me.LayoutControlItem4.Text = "Κωδικός"
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(294, 23)
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(1719, 0)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(120, 42)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem8
        '
        Me.LayoutControlItem8.Control = Me.txtArea
        Me.LayoutControlItem8.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem8.CustomizationFormText = "Κινητό"
        Me.LayoutControlItem8.Location = New System.Drawing.Point(1230, 84)
        Me.LayoutControlItem8.Name = "LayoutControlItem8"
        Me.LayoutControlItem8.Size = New System.Drawing.Size(609, 42)
        Me.LayoutControlItem8.Text = "Πόλη"
        Me.LayoutControlItem8.TextLocation = DevExpress.Utils.Locations.Left
        Me.LayoutControlItem8.TextSize = New System.Drawing.Size(294, 23)
        '
        'LayoutControlItem31
        '
        Me.LayoutControlItem31.Control = Me.txtdtdaysOfDelivery
        Me.LayoutControlItem31.ImageOptions.Image = Global.DreamyKitchenCRM.My.Resources.Resources.rsz_11rsz_asterisk
        Me.LayoutControlItem31.Location = New System.Drawing.Point(674, 126)
        Me.LayoutControlItem31.Name = "LayoutControlItem31"
        Me.LayoutControlItem31.Size = New System.Drawing.Size(864, 42)
        Me.LayoutControlItem31.Tag = "1"
        Me.LayoutControlItem31.Text = "Ημερ/νία Παράδοσης"
        Me.LayoutControlItem31.TextSize = New System.Drawing.Size(294, 23)
        '
        'LayoutControlItem47
        '
        Me.LayoutControlItem47.Control = Me.lblDate
        Me.LayoutControlItem47.Location = New System.Drawing.Point(1538, 126)
        Me.LayoutControlItem47.Name = "LayoutControlItem47"
        Me.LayoutControlItem47.Size = New System.Drawing.Size(301, 42)
        Me.LayoutControlItem47.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem47.TextVisible = False
        '
        'LayoutControlItem13
        '
        Me.LayoutControlItem13.Control = Me.txtPhn
        Me.LayoutControlItem13.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem13.CustomizationFormText = "Κινητό"
        Me.LayoutControlItem13.Location = New System.Drawing.Point(0, 84)
        Me.LayoutControlItem13.Name = "LayoutControlItem13"
        Me.LayoutControlItem13.Size = New System.Drawing.Size(527, 42)
        Me.LayoutControlItem13.Text = "Κινητό"
        Me.LayoutControlItem13.TextLocation = DevExpress.Utils.Locations.Left
        Me.LayoutControlItem13.TextSize = New System.Drawing.Size(294, 23)
        '
        'LayoutControlItem28
        '
        Me.LayoutControlItem28.Control = Me.txtArea1
        Me.LayoutControlItem28.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem28.CustomizationFormText = "Κινητό"
        Me.LayoutControlItem28.ImageOptions.Image = CType(resources.GetObject("LayoutControlItem28.ImageOptions.Image"), System.Drawing.Image)
        Me.LayoutControlItem28.Location = New System.Drawing.Point(1157, 0)
        Me.LayoutControlItem28.Name = "LayoutControlItem28"
        Me.LayoutControlItem28.Size = New System.Drawing.Size(562, 42)
        Me.LayoutControlItem28.Tag = "1"
        Me.LayoutControlItem28.Text = "Αρ. Πρωτοκόλου"
        Me.LayoutControlItem28.TextLocation = DevExpress.Utils.Locations.Left
        Me.LayoutControlItem28.TextSize = New System.Drawing.Size(294, 23)
        '
        'LayoutControlItem9
        '
        Me.LayoutControlItem9.Control = Me.cboCUS
        Me.LayoutControlItem9.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem9.CustomizationFormText = "Νομός"
        Me.LayoutControlItem9.ImageOptions.Image = CType(resources.GetObject("LayoutControlItem9.ImageOptions.Image"), System.Drawing.Image)
        Me.LayoutControlItem9.Location = New System.Drawing.Point(0, 42)
        Me.LayoutControlItem9.Name = "LayoutControlItem9"
        Me.LayoutControlItem9.Size = New System.Drawing.Size(919, 42)
        Me.LayoutControlItem9.Tag = "1"
        Me.LayoutControlItem9.Text = "Πελάτης"
        Me.LayoutControlItem9.TextLocation = DevExpress.Utils.Locations.Left
        Me.LayoutControlItem9.TextSize = New System.Drawing.Size(294, 23)
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.cboTRANSH
        Me.LayoutControlItem1.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem1.CustomizationFormText = "Περιοχή"
        Me.LayoutControlItem1.HighlightFocusedItem = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlItem1.ImageOptions.Image = CType(resources.GetObject("LayoutControlItem1.ImageOptions.Image"), System.Drawing.Image)
        Me.LayoutControlItem1.Location = New System.Drawing.Point(919, 42)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(920, 42)
        Me.LayoutControlItem1.Tag = "1"
        Me.LayoutControlItem1.Text = "Έργο Πελάτη"
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(294, 23)
        '
        'LayoutControlItem46
        '
        Me.LayoutControlItem46.Control = Me.cboEMP
        Me.LayoutControlItem46.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem46.CustomizationFormText = "Νομός"
        Me.LayoutControlItem46.ImageOptions.Image = CType(resources.GetObject("LayoutControlItem46.ImageOptions.Image"), System.Drawing.Image)
        Me.LayoutControlItem46.Location = New System.Drawing.Point(406, 0)
        Me.LayoutControlItem46.Name = "LayoutControlItem46"
        Me.LayoutControlItem46.Size = New System.Drawing.Size(751, 42)
        Me.LayoutControlItem46.Tag = "1"
        Me.LayoutControlItem46.Text = "Πωλητής"
        Me.LayoutControlItem46.TextLocation = DevExpress.Utils.Locations.Left
        Me.LayoutControlItem46.TextSize = New System.Drawing.Size(294, 23)
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.cmdPrintOffer
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 1269)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(104, 125)
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem2.TextVisible = False
        '
        'LayoutControlItem26
        '
        Me.LayoutControlItem26.Control = Me.cmdSave
        Me.LayoutControlItem26.Location = New System.Drawing.Point(1515, 1269)
        Me.LayoutControlItem26.Name = "LayoutControlItem26"
        Me.LayoutControlItem26.Size = New System.Drawing.Size(164, 125)
        Me.LayoutControlItem26.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem26.TextVisible = False
        '
        'LayoutControlItem27
        '
        Me.LayoutControlItem27.Control = Me.cmdExit
        Me.LayoutControlItem27.Location = New System.Drawing.Point(1679, 1269)
        Me.LayoutControlItem27.Name = "LayoutControlItem27"
        Me.LayoutControlItem27.Size = New System.Drawing.Size(186, 125)
        Me.LayoutControlItem27.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem27.TextVisible = False
        '
        'EmptySpaceItem3
        '
        Me.EmptySpaceItem3.AllowHotTrack = False
        Me.EmptySpaceItem3.Location = New System.Drawing.Point(415, 1269)
        Me.EmptySpaceItem3.Name = "EmptySpaceItem3"
        Me.EmptySpaceItem3.Size = New System.Drawing.Size(1100, 125)
        Me.EmptySpaceItem3.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem32
        '
        Me.LayoutControlItem32.Control = Me.chkVatVisible
        Me.LayoutControlItem32.Location = New System.Drawing.Point(104, 1269)
        Me.LayoutControlItem32.Name = "LayoutControlItem32"
        Me.LayoutControlItem32.Size = New System.Drawing.Size(311, 125)
        Me.LayoutControlItem32.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem32.TextVisible = False
        '
        'VwDOORTYPE1BindingSource1
        '
        Me.VwDOORTYPE1BindingSource1.DataMember = "vw_DOOR_TYPE1"
        Me.VwDOORTYPE1BindingSource1.DataSource = Me.DMDataSet
        '
        'VwCOLORSPVCBindingSource
        '
        Me.VwCOLORSPVCBindingSource.DataMember = "vw_COLORSPVC"
        Me.VwCOLORSPVCBindingSource.DataSource = Me.DreamyKitchenDataSet
        '
        'TabPane1
        '
        Me.TabPane1.Controls.Add(Me.TabNavigationPage1)
        Me.TabPane1.Controls.Add(Me.TabNavigationPage2)
        Me.TabPane1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabPane1.Location = New System.Drawing.Point(0, 0)
        Me.TabPane1.Name = "TabPane1"
        Me.TabPane1.Pages.AddRange(New DevExpress.XtraBars.Navigation.NavigationPageBase() {Me.TabNavigationPage1, Me.TabNavigationPage2})
        Me.TabPane1.RegularSize = New System.Drawing.Size(1885, 1472)
        Me.TabPane1.SelectedPage = Me.TabNavigationPage1
        Me.TabPane1.Size = New System.Drawing.Size(1885, 1472)
        Me.TabPane1.TabIndex = 60
        '
        'TabNavigationPage1
        '
        Me.TabNavigationPage1.Caption = "TabNavigationPage1"
        Me.TabNavigationPage1.Controls.Add(Me.LayoutControl1)
        Me.TabNavigationPage1.Name = "TabNavigationPage1"
        Me.TabNavigationPage1.PageText = "ΕΡΜΑΡΙΑ"
        Me.TabNavigationPage1.Size = New System.Drawing.Size(1885, 1414)
        '
        'TabNavigationPage2
        '
        Me.TabNavigationPage2.Caption = "TabNavigationPage2"
        Me.TabNavigationPage2.Controls.Add(Me.LayoutControl2)
        Me.TabNavigationPage2.Name = "TabNavigationPage2"
        Me.TabNavigationPage2.PageText = "ΣΥΣΚΕΥΕΣ/ΕΞΑΡΤΗΜΑΤΑ"
        Me.TabNavigationPage2.Size = New System.Drawing.Size(1885, 1414)
        '
        'LayoutControl2
        '
        Me.LayoutControl2.Controls.Add(Me.cmdSaveEquipDev)
        Me.LayoutControl2.Controls.Add(Me.grdDevices)
        Me.LayoutControl2.Controls.Add(Me.grdEquipment)
        Me.LayoutControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl2.Name = "LayoutControl2"
        Me.LayoutControl2.Root = Me.LayoutControlGroup4
        Me.LayoutControl2.Size = New System.Drawing.Size(1885, 1414)
        Me.LayoutControl2.TabIndex = 65
        Me.LayoutControl2.Text = "LayoutControl2"
        '
        'cmdSaveEquipDev
        '
        Me.cmdSaveEquipDev.ImageOptions.Image = CType(resources.GetObject("cmdSaveEquipDev.ImageOptions.Image"), System.Drawing.Image)
        Me.cmdSaveEquipDev.Location = New System.Drawing.Point(1642, 1363)
        Me.cmdSaveEquipDev.Margin = New System.Windows.Forms.Padding(5)
        Me.cmdSaveEquipDev.Name = "cmdSaveEquipDev"
        Me.cmdSaveEquipDev.Size = New System.Drawing.Size(231, 39)
        Me.cmdSaveEquipDev.StyleController = Me.LayoutControl2
        Me.cmdSaveEquipDev.TabIndex = 64
        Me.cmdSaveEquipDev.Text = "Αποθήκευση"
        '
        'grdDevices
        '
        Me.grdDevices.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdDevices.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(5)
        Me.grdDevices.Location = New System.Drawing.Point(12, 719)
        Me.grdDevices.MainView = Me.GridView1
        Me.grdDevices.Margin = New System.Windows.Forms.Padding(5)
        Me.grdDevices.Name = "grdDevices"
        Me.grdDevices.Size = New System.Drawing.Size(1861, 640)
        Me.grdDevices.TabIndex = 63
        Me.grdDevices.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2, Me.coldCode, Me.GridColumn3, Me.colchecked})
        Me.GridView1.FixedLineWidth = 3
        GridFormatRule1.ApplyToRow = True
        GridFormatRule1.Column = Me.coldCode
        GridFormatRule1.Name = "Format0"
        FormatConditionRuleExpression1.Appearance.BackColor = System.Drawing.Color.White
        FormatConditionRuleExpression1.Appearance.Options.UseBackColor = True
        FormatConditionRuleExpression1.Expression = "IsNullOrEmpty([dCode]) And [checked] = True"
        FormatConditionRuleExpression1.PredefinedName = "Red Text"
        GridFormatRule1.Rule = FormatConditionRuleExpression1
        Me.GridView1.FormatRules.Add(GridFormatRule1)
        Me.GridView1.GridControl = Me.grdDevices
        Me.GridView1.LevelIndent = 0
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridView1.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[True]
        Me.GridView1.OptionsEditForm.ActionOnModifiedRowChange = DevExpress.XtraGrid.Views.Grid.EditFormModifiedAction.Save
        Me.GridView1.OptionsEditForm.BindingMode = DevExpress.XtraGrid.Views.Grid.EditFormBindingMode.Direct
        Me.GridView1.OptionsLayout.StoreAllOptions = True
        Me.GridView1.OptionsLayout.StoreAppearance = True
        Me.GridView1.OptionsLayout.StoreFormatRules = True
        Me.GridView1.OptionsMenu.ShowConditionalFormattingItem = True
        Me.GridView1.OptionsPrint.PrintPreview = True
        Me.GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView1.OptionsSelection.MultiSelect = True
        Me.GridView1.OptionsView.AllowHtmlDrawHeaders = True
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.EnableAppearanceEvenRow = True
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        Me.GridView1.PreviewIndent = 0
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "ΚΩΔΙΚΟΣ"
        Me.GridColumn1.FieldName = "code"
        Me.GridColumn1.MinWidth = 33
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.OptionsColumn.AllowEdit = False
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 0
        Me.GridColumn1.Width = 112
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "ΣΥΣΚΕΥΗ"
        Me.GridColumn2.FieldName = "name"
        Me.GridColumn2.MinWidth = 33
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.OptionsColumn.AllowEdit = False
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 1
        Me.GridColumn2.Width = 152
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "ΤΙΜΗ"
        Me.GridColumn3.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn3.MinWidth = 35
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 3
        Me.GridColumn3.Width = 131
        '
        'colchecked
        '
        Me.colchecked.Caption = "ΕΠΙΛΟΓΗ"
        Me.colchecked.FieldName = "checked"
        Me.colchecked.MinWidth = 33
        Me.colchecked.Name = "colchecked"
        Me.colchecked.Visible = True
        Me.colchecked.VisibleIndex = 4
        Me.colchecked.Width = 112
        '
        'grdEquipment
        '
        Me.grdEquipment.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdEquipment.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(5)
        Me.grdEquipment.Location = New System.Drawing.Point(12, 12)
        Me.grdEquipment.MainView = Me.GridView2
        Me.grdEquipment.Margin = New System.Windows.Forms.Padding(5)
        Me.grdEquipment.Name = "grdEquipment"
        Me.grdEquipment.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepDefPrice})
        Me.grdEquipment.Size = New System.Drawing.Size(1861, 703)
        Me.grdEquipment.TabIndex = 62
        Me.grdEquipment.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2})
        '
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colID, Me.colcode, Me.colname, Me.colprice, Me.colmodifiedBy, Me.colmodifiedOn, Me.colcreatedOn, Me.colcreatedBy, Me.colRealName, Me.coldefPrice})
        Me.GridView2.DetailHeight = 619
        Me.GridView2.GridControl = Me.grdEquipment
        Me.GridView2.LevelIndent = 0
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridView2.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[True]
        Me.GridView2.OptionsEditForm.ActionOnModifiedRowChange = DevExpress.XtraGrid.Views.Grid.EditFormModifiedAction.Save
        Me.GridView2.OptionsEditForm.BindingMode = DevExpress.XtraGrid.Views.Grid.EditFormBindingMode.Direct
        Me.GridView2.OptionsLayout.StoreAllOptions = True
        Me.GridView2.OptionsLayout.StoreAppearance = True
        Me.GridView2.OptionsLayout.StoreFormatRules = True
        Me.GridView2.OptionsPrint.PrintPreview = True
        Me.GridView2.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView2.OptionsSelection.MultiSelect = True
        Me.GridView2.OptionsView.AllowHtmlDrawHeaders = True
        Me.GridView2.OptionsView.ColumnAutoWidth = False
        Me.GridView2.OptionsView.EnableAppearanceEvenRow = True
        Me.GridView2.OptionsView.ShowFooter = True
        Me.GridView2.OptionsView.ShowGroupPanel = False
        Me.GridView2.PreviewIndent = 0
        '
        'colID
        '
        Me.colID.FieldName = "ID"
        Me.colID.MinWidth = 35
        Me.colID.Name = "colID"
        Me.colID.Width = 131
        '
        'colcode
        '
        Me.colcode.Caption = "Κωδικός"
        Me.colcode.FieldName = "code"
        Me.colcode.MinWidth = 35
        Me.colcode.Name = "colcode"
        Me.colcode.Visible = True
        Me.colcode.VisibleIndex = 2
        Me.colcode.Width = 131
        '
        'colname
        '
        Me.colname.Caption = "Εξοπλισμός"
        Me.colname.FieldName = "name"
        Me.colname.MinWidth = 35
        Me.colname.Name = "colname"
        Me.colname.Visible = True
        Me.colname.VisibleIndex = 0
        Me.colname.Width = 628
        '
        'colprice
        '
        Me.colprice.Caption = "Τιμή"
        Me.colprice.ColumnEdit = Me.RepDefPrice
        Me.colprice.DisplayFormat.FormatString = "C2"
        Me.colprice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colprice.FieldName = "price"
        Me.colprice.MinWidth = 35
        Me.colprice.Name = "colprice"
        Me.colprice.Visible = True
        Me.colprice.VisibleIndex = 1
        Me.colprice.Width = 131
        '
        'RepDefPrice
        '
        Me.RepDefPrice.AutoHeight = False
        Me.RepDefPrice.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.OK), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Clear)})
        Me.RepDefPrice.Name = "RepDefPrice"
        '
        'colmodifiedBy
        '
        Me.colmodifiedBy.FieldName = "modifiedBy"
        Me.colmodifiedBy.MinWidth = 35
        Me.colmodifiedBy.Name = "colmodifiedBy"
        Me.colmodifiedBy.Width = 131
        '
        'colmodifiedOn
        '
        Me.colmodifiedOn.FieldName = "modifiedOn"
        Me.colmodifiedOn.MinWidth = 35
        Me.colmodifiedOn.Name = "colmodifiedOn"
        Me.colmodifiedOn.Width = 131
        '
        'colcreatedOn
        '
        Me.colcreatedOn.FieldName = "createdOn"
        Me.colcreatedOn.MinWidth = 35
        Me.colcreatedOn.Name = "colcreatedOn"
        Me.colcreatedOn.Width = 131
        '
        'colcreatedBy
        '
        Me.colcreatedBy.FieldName = "createdBy"
        Me.colcreatedBy.MinWidth = 35
        Me.colcreatedBy.Name = "colcreatedBy"
        Me.colcreatedBy.Width = 131
        '
        'colRealName
        '
        Me.colRealName.FieldName = "RealName"
        Me.colRealName.MinWidth = 35
        Me.colRealName.Name = "colRealName"
        Me.colRealName.Width = 131
        '
        'coldefPrice
        '
        Me.coldefPrice.FieldName = "defPrice"
        Me.coldefPrice.MinWidth = 35
        Me.coldefPrice.Name = "coldefPrice"
        Me.coldefPrice.Width = 131
        '
        'LayoutControlGroup4
        '
        Me.LayoutControlGroup4.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup4.GroupBordersVisible = False
        Me.LayoutControlGroup4.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem19, Me.LayoutControlItem71, Me.LayoutControlItem75, Me.EmptySpaceItem6})
        Me.LayoutControlGroup4.Name = "LayoutControlGroup4"
        Me.LayoutControlGroup4.Size = New System.Drawing.Size(1885, 1414)
        Me.LayoutControlGroup4.TextVisible = False
        '
        'LayoutControlItem19
        '
        Me.LayoutControlItem19.Control = Me.grdEquipment
        Me.LayoutControlItem19.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem19.Name = "LayoutControlItem19"
        Me.LayoutControlItem19.Size = New System.Drawing.Size(1865, 707)
        Me.LayoutControlItem19.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem19.TextVisible = False
        '
        'LayoutControlItem71
        '
        Me.LayoutControlItem71.Control = Me.grdDevices
        Me.LayoutControlItem71.Location = New System.Drawing.Point(0, 707)
        Me.LayoutControlItem71.Name = "LayoutControlItem71"
        Me.LayoutControlItem71.Size = New System.Drawing.Size(1865, 644)
        Me.LayoutControlItem71.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem71.TextVisible = False
        '
        'LayoutControlItem75
        '
        Me.LayoutControlItem75.Control = Me.cmdSaveEquipDev
        Me.LayoutControlItem75.Location = New System.Drawing.Point(1630, 1351)
        Me.LayoutControlItem75.Name = "LayoutControlItem75"
        Me.LayoutControlItem75.Size = New System.Drawing.Size(235, 43)
        Me.LayoutControlItem75.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem75.TextVisible = False
        '
        'EmptySpaceItem6
        '
        Me.EmptySpaceItem6.AllowHotTrack = False
        Me.EmptySpaceItem6.Location = New System.Drawing.Point(0, 1351)
        Me.EmptySpaceItem6.Name = "EmptySpaceItem6"
        Me.EmptySpaceItem6.Size = New System.Drawing.Size(1630, 43)
        Me.EmptySpaceItem6.TextSize = New System.Drawing.Size(0, 0)
        '
        'VwDEVICESBindingSource
        '
        Me.VwDEVICESBindingSource.DataMember = "vw_DEVICES"
        Me.VwDEVICESBindingSource.DataSource = Me.DreamyKitchenDataSet
        '
        'VwEQUIPMENTBindingSource
        '
        Me.VwEQUIPMENTBindingSource.DataMember = "vw_EQUIPMENT"
        Me.VwEQUIPMENTBindingSource.DataSource = Me.DreamyKitchenDataSet
        '
        'Vw_COLORSBOXTableAdapter
        '
        Me.Vw_COLORSBOXTableAdapter.ClearBeforeFill = True
        '
        'Vw_COLORSPVCTableAdapter
        '
        Me.Vw_COLORSPVCTableAdapter.ClearBeforeFill = True
        '
        'Vw_COLORSGOLATableAdapter
        '
        Me.Vw_COLORSGOLATableAdapter.ClearBeforeFill = True
        '
        'Vw_EQUIPMENTTableAdapter
        '
        Me.Vw_EQUIPMENTTableAdapter.ClearBeforeFill = True
        '
        'Vw_DEVICESTableAdapter
        '
        Me.Vw_DEVICESTableAdapter.ClearBeforeFill = True
        '
        'Vw_SALERSTableAdapter
        '
        Me.Vw_SALERSTableAdapter.ClearBeforeFill = True
        '
        'Vw_CCTTableAdapter
        '
        Me.Vw_CCTTableAdapter.ClearBeforeFill = True
        '
        'DOOR_TYPETableAdapter
        '
        Me.DOOR_TYPETableAdapter.ClearBeforeFill = True
        '
        'Vw_DOOR_TYPETableAdapter1
        '
        Me.Vw_DOOR_TYPETableAdapter1.ClearBeforeFill = True
        '
        'Vw_DOOR_TYPE1TableAdapter
        '
        Me.Vw_DOOR_TYPE1TableAdapter.ClearBeforeFill = True
        '
        'Vw_DOOR_TYPEPlainaYpsilaTableAdapter
        '
        Me.Vw_DOOR_TYPEPlainaYpsilaTableAdapter.ClearBeforeFill = True
        '
        'Vw_BENCHTableAdapter
        '
        Me.Vw_BENCHTableAdapter.ClearBeforeFill = True
        '
        'Vw_DOOR_TYPEPlainaKremastaTableAdapter
        '
        Me.Vw_DOOR_TYPEPlainaKremastaTableAdapter.ClearBeforeFill = True
        '
        'Vw_DOOR_TYPERafieresVTableAdapter
        '
        Me.Vw_DOOR_TYPERafieresVTableAdapter.ClearBeforeFill = True
        '
        'Vw_DOOR_TYPERafieresKTableAdapter
        '
        Me.Vw_DOOR_TYPERafieresKTableAdapter.ClearBeforeFill = True
        '
        'Vw_DOOR_TYPERafieresYTableAdapter
        '
        Me.Vw_DOOR_TYPERafieresYTableAdapter.ClearBeforeFill = True
        '
        'Vw_DOOR_TYPERafiaWallTableAdapter
        '
        Me.Vw_DOOR_TYPERafiaWallTableAdapter.ClearBeforeFill = True
        '
        'Vw_DOOR_TYPEPlainaKremasta2hsSeirasTableAdapter
        '
        Me.Vw_DOOR_TYPEPlainaKremasta2hsSeirasTableAdapter.ClearBeforeFill = True
        '
        'frmCUSOrderKitchen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 23.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1885, 1472)
        Me.Controls.Add(Me.TabPane1)
        Me.IconOptions.Image = Global.DreamyKitchenCRM.My.Resources.Resources.favicon
        Me.Name = "frmCUSOrderKitchen"
        Me.Text = "frmCUSOrderKitchen"
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.chkVatVisible.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkHangingOnDoors.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkHoodAlignment.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboVType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtdtdaysOfDelivery.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtbackCode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboCUS.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VwCCTBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DreamyKitchenDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPhn.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtADR.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpresentation.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpresentation.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtKFinalHeight.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtOtherHeight.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtYFinalHeight.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtArea.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtVShelves.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtVdoorCode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTotalErmariaVat.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTotalDevicesPrice.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTotalErmariaPice.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboEMP.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VwSALERSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboVBOXColors.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VwCOLORSBOXBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboKBOXColors.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboYBOXColors.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtKHeight2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtVFinalHeight.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboGOLAColors.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VwCOLORSGOLABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboBaza.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboLegs.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboVwater.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtKHeight.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtKdoorCode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboKwater.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboLedProfil.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtKShelves.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboYHeight.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtYdoorCode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboYwater.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtbenchCode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbobenchThickness.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtArea1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtExtraTransp.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtExtraInst.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPartofVat.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboKType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboYType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMeasurement.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRemove.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboVependisisDoorType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DOORTYPEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DMDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboBenchType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VwBENCHBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboBack.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboBenchType2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtYShelves.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboNependisisDoorType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VwDOORTYPEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboVDoorType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VwDOORTYPE1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboVDoorType1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboKDoorType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboKDoorType1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboYDoorType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboYDoorType1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboPependisisDoorType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VwDOORTYPEPlainaYpsilaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboKependisisDoorType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VwDOORTYPEPlainaKremastaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboSndEpendisisDoorType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VwDOORTYPEPlainaKremasta2hsSeirasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboVRafieraDoorType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VwDOORTYPERafieresVBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboKRafieraDoorType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VwDOORTYPERafieresKBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboYRafieraDoorType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VwDOORTYPERafieresYBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboKWallRafiaDoorType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VwDOORTYPERafiaWallBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboTRANSH.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTransp.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem21, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem49, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem51, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem53, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem54, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem52, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem22, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem18, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem24, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem73, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem33, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem58, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem50, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem55, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem57, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem60, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem59, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem23, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem37, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem61, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem45, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem74, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem56, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem20, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem65, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem70, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem62, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem64, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem63, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem39, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem72, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem36, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem48, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem41, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem69, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem25, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem17, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem66, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem67, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem68, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem40, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem29, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem34, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem42, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem35, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem43, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem44, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem38, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem76, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem30, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem31, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem47, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem28, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem46, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem26, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem27, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem32, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VwDOORTYPE1BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VwCOLORSPVCBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TabPane1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPane1.ResumeLayout(False)
        Me.TabNavigationPage1.ResumeLayout(False)
        Me.TabNavigationPage2.ResumeLayout(False)
        CType(Me.LayoutControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl2.ResumeLayout(False)
        CType(Me.grdDevices, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdEquipment, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepDefPrice, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem19, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem71, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem75, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VwDEVICESBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VwEQUIPMENTBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents cmdPrintOffer As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lblDate As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtdtdaysOfDelivery As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtbackCode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cmdExit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cboCUS As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents txtCode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtPhn As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtADR As DevExpress.XtraEditors.TextEdit
    Friend WithEvents dtpresentation As DevExpress.XtraEditors.DateEdit
    Friend WithEvents txtKFinalHeight As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtOtherHeight As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtYFinalHeight As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtArea As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtVShelves As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtVdoorCode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtTotalErmariaVat As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtTotalDevicesPrice As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtTotalErmariaPice As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cboEMP As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents cboVBOXColors As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents cboKBOXColors As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents cboYBOXColors As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents txtKHeight2 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Root As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlGroup3 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem21 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlGroup5 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem11 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem50 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlGroup6 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem10 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem14 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem16 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlGroup7 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem25 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem17 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem18 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem22 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents txtVFinalHeight As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem49 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents cboVType As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LayoutControlItem51 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents cboGOLAColors As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LayoutControlItem52 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents cboBaza As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents cboLegs As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LayoutControlItem53 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem54 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents cboVwater As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LayoutControlItem24 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents txtKHeight As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents txtKdoorCode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem55 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents cboKwater As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LayoutControlItem57 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents cboLedProfil As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LayoutControlItem59 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents txtKShelves As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem60 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents chkHoodAlignment As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents LayoutControlItem61 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents cboYHeight As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LayoutControlItem62 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents txtYdoorCode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem63 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents cboYwater As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LayoutControlItem64 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents txtbenchCode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cbobenchThickness As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LayoutControlItem12 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem30 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem31 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem13 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LayoutControlItem46 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem47 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents TabPane1 As DevExpress.XtraBars.Navigation.TabPane
    Friend WithEvents TabNavigationPage1 As DevExpress.XtraBars.Navigation.TabNavigationPage
    Friend WithEvents TabNavigationPage2 As DevExpress.XtraBars.Navigation.TabNavigationPage
    Friend WithEvents DreamyKitchenDataSet As DreamyKitchenDataSet
    Friend WithEvents VwCOLORSBOXBindingSource As BindingSource
    Friend WithEvents Vw_COLORSBOXTableAdapter As DreamyKitchenDataSetTableAdapters.vw_COLORSBOXTableAdapter
    Friend WithEvents VwCOLORSPVCBindingSource As BindingSource
    Friend WithEvents Vw_COLORSPVCTableAdapter As DreamyKitchenDataSetTableAdapters.vw_COLORSPVCTableAdapter
    Friend WithEvents VwCOLORSGOLABindingSource As BindingSource
    Friend WithEvents Vw_COLORSGOLATableAdapter As DreamyKitchenDataSetTableAdapters.vw_COLORSGOLATableAdapter
    Friend WithEvents VwEQUIPMENTBindingSource As BindingSource
    Friend WithEvents Vw_EQUIPMENTTableAdapter As DreamyKitchenDataSetTableAdapters.vw_EQUIPMENTTableAdapter
    Friend WithEvents VwDEVICESBindingSource As BindingSource
    Friend WithEvents Vw_DEVICESTableAdapter As DreamyKitchenDataSetTableAdapters.vw_DEVICESTableAdapter
    Friend WithEvents grdDevices As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents grdEquipment As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colcode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colname As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colmodifiedBy As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colmodifiedOn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colcreatedOn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colcreatedBy As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRealName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents VwSALERSBindingSource As BindingSource
    Friend WithEvents Vw_SALERSTableAdapter As DreamyKitchenDataSetTableAdapters.vw_SALERSTableAdapter
    Friend WithEvents VwCCTBindingSource As BindingSource
    Friend WithEvents Vw_CCTTableAdapter As DreamyKitchenDataSetTableAdapters.vw_CCTTableAdapter
    Friend WithEvents chkHangingOnDoors As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents LayoutControlItem23 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents cmdSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem26 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem27 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem3 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents cmdSaveEquipDev As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtArea1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem28 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents txtExtraTransp As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtExtraInst As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem38 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem40 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem4 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colchecked As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtPartofVat As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem29 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem34 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem42 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem35 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents chkVatVisible As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents LayoutControlItem32 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents cboKType As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LayoutControlItem37 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents cboYType As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LayoutControlItem39 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents txtMeasurement As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtRemove As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem43 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem44 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents cboVependisisDoorType As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents cboBenchType As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LayoutControlItem66 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents cboBack As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LayoutControlItem67 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents cboBenchType2 As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LayoutControlItem68 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents txtYShelves As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem72 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem5 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents DMDataSet As DMDataSet
    Friend WithEvents DOOR_TYPETableAdapter As DMDataSetTableAdapters.DOOR_TYPETableAdapter
    Friend WithEvents DOORTYPEBindingSource As BindingSource
    Friend WithEvents cboNependisisDoorType As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LayoutControlItem73 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents Vw_DOOR_TYPETableAdapter As DMDataSetTableAdapters.vw_DOOR_TYPETableAdapter
    Friend WithEvents VwDOORTYPEBindingSource As BindingSource
    Friend WithEvents Vw_DOOR_TYPETableAdapter1 As DMDataSetTableAdapters.vw_DOOR_TYPETableAdapter
    Friend WithEvents cboVDoorType As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LayoutControlItem15 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents VwDOORTYPE1BindingSource As BindingSource
    Friend WithEvents Vw_DOOR_TYPE1TableAdapter As DMDataSetTableAdapters.vw_DOOR_TYPE1TableAdapter
    Friend WithEvents VwDOORTYPE1BindingSource1 As BindingSource
    Friend WithEvents cboVDoorType1 As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LayoutControlItem33 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents cboKDoorType As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents cboKDoorType1 As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LayoutControlItem45 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem74 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents cboYDoorType As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents cboYDoorType1 As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LayoutControlItem36 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem48 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents cboPependisisDoorType As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LayoutControlItem41 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents VwDOORTYPEPlainaYpsilaBindingSource As BindingSource
    Friend WithEvents Vw_DOOR_TYPEPlainaYpsilaTableAdapter As DMDataSetTableAdapters.vw_DOOR_TYPEPlainaYpsilaTableAdapter
    Friend WithEvents VwBENCHBindingSource As BindingSource
    Friend WithEvents Vw_BENCHTableAdapter As DreamyKitchenDataSetTableAdapters.vw_BENCHTableAdapter
    Friend WithEvents VwDOORTYPEPlainaKremastaBindingSource As BindingSource
    Friend WithEvents Vw_DOOR_TYPEPlainaKremastaTableAdapter As DMDataSetTableAdapters.vw_DOOR_TYPEPlainaKremastaTableAdapter
    Friend WithEvents cboKependisisDoorType As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LayoutControlItem56 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents cboSndEpendisisDoorType As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LayoutControlItem20 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents cboVRafieraDoorType As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LayoutControlItem58 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents VwDOORTYPERafieresVBindingSource As BindingSource
    Friend WithEvents Vw_DOOR_TYPERafieresVTableAdapter As DMDataSetTableAdapters.vw_DOOR_TYPERafieresVTableAdapter
    Friend WithEvents cboKRafieraDoorType As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LayoutControlItem65 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents VwDOORTYPERafieresKBindingSource As BindingSource
    Friend WithEvents Vw_DOOR_TYPERafieresKTableAdapter As DMDataSetTableAdapters.vw_DOOR_TYPERafieresKTableAdapter
    Friend WithEvents cboYRafieraDoorType As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LayoutControlItem69 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents VwDOORTYPERafieresYBindingSource As BindingSource
    Friend WithEvents Vw_DOOR_TYPERafieresYTableAdapter As DMDataSetTableAdapters.vw_DOOR_TYPERafieresYTableAdapter
    Friend WithEvents cboKWallRafiaDoorType As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LayoutControlItem70 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents VwDOORTYPERafiaWallBindingSource As BindingSource
    Friend WithEvents Vw_DOOR_TYPERafiaWallTableAdapter As DMDataSetTableAdapters.vw_DOOR_TYPERafiaWallTableAdapter
    Friend WithEvents cboTRANSH As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents colprice As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepDefPrice As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents coldefPrice As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LayoutControl2 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup4 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem19 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem71 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem75 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem6 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents txtTransp As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem76 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents VwDOORTYPEPlainaKremasta2hsSeirasBindingSource As BindingSource
    Friend WithEvents Vw_DOOR_TYPEPlainaKremasta2hsSeirasTableAdapter As DMDataSetTableAdapters.vw_DOOR_TYPEPlainaKremasta2hsSeirasTableAdapter
    '    Friend WithEvents Vw_DOOR_TYPEPlainaYpsilaTableAdapter As DMDataSetTableAdapters.vw_DOOR_TYPEPlainaYpsilaTableAdapter
End Class
