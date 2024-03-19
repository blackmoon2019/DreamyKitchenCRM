<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCUSOfferOrderSpecialConstr
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCUSOfferOrderSpecialConstr))
        Dim GridFormatRule1 As DevExpress.XtraGrid.GridFormatRule = New DevExpress.XtraGrid.GridFormatRule()
        Dim FormatConditionRuleExpression1 As DevExpress.XtraEditors.FormatConditionRuleExpression = New DevExpress.XtraEditors.FormatConditionRuleExpression()
        Dim EditorButtonImageOptions1 As DevExpress.XtraEditors.Controls.EditorButtonImageOptions = New DevExpress.XtraEditors.Controls.EditorButtonImageOptions()
        Dim SerializableAppearanceObject1 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject2 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject3 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject4 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim EditorButtonImageOptions2 As DevExpress.XtraEditors.Controls.EditorButtonImageOptions = New DevExpress.XtraEditors.Controls.EditorButtonImageOptions()
        Dim SerializableAppearanceObject5 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject6 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject7 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject8 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Me.VwCOMPBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DM_CCT = New DreamyKitchenCRM.DM_CCT()
        Me.VwCCTBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DreamyKitchenDataSet = New DreamyKitchenCRM.DreamyKitchenDataSet()
        Me.VwSALERSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VwVALUELISTITEMV2BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DM_VALUELISTITEM = New DreamyKitchenCRM.DM_VALUELISTITEM()
        Me.VwCONSTRTYPEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DMDataSet = New DreamyKitchenCRM.DMDataSet()
        Me.VwVALUELISTITEMSpecialConstrBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Vw_SALERSTableAdapter = New DreamyKitchenCRM.DreamyKitchenDataSetTableAdapters.vw_SALERSTableAdapter()
        Me.Vw_VALUELISTITEMSpecialConstrTableAdapter = New DreamyKitchenCRM.DM_VALUELISTITEMTableAdapters.vw_VALUELISTITEMSpecialConstrTableAdapter()
        Me.Vw_VALUELISTITEM_V2TableAdapter = New DreamyKitchenCRM.DM_VALUELISTITEMTableAdapters.vw_VALUELISTITEM_V2TableAdapter()
        Me.Vw_CCTTableAdapter = New DreamyKitchenCRM.DreamyKitchenDataSetTableAdapters.vw_CCTTableAdapter()
        Me.Vw_CONSTR_TYPETableAdapter = New DreamyKitchenCRM.DMDataSetTableAdapters.vw_CONSTR_TYPETableAdapter()
        Me.CCTTRANSHBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DM_TRANS = New DreamyKitchenCRM.DM_TRANS()
        Me.CCT_TRANSHTableAdapter = New DreamyKitchenCRM.DM_TRANSTableAdapters.CCT_TRANSHTableAdapter()
        Me.Vw_COMPTableAdapter = New DreamyKitchenCRM.DM_CCTTableAdapters.vw_COMPTableAdapter()
        Me.TabPane1 = New DevExpress.XtraBars.Navigation.TabPane()
        Me.TabNavigationPage1 = New DevExpress.XtraBars.Navigation.TabNavigationPage()
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.LblMsg = New DevExpress.XtraEditors.LabelControl()
        Me.cmdOrder = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdPrivateAgreement = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdNewRecord = New DevExpress.XtraEditors.SimpleButton()
        Me.chkGenOffer = New DevExpress.XtraEditors.CheckEdit()
        Me.cmdCusCollection = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdCompCollection = New DevExpress.XtraEditors.SimpleButton()
        Me.cboCompProject = New DevExpress.XtraEditors.LookUpEdit()
        Me.cboCompany = New DevExpress.XtraEditors.LookUpEdit()
        Me.chkofferAccepted = New DevExpress.XtraEditors.CheckEdit()
        Me.cmdConvertToOrder = New DevExpress.XtraEditors.SimpleButton()
        Me.chkVatVisible = New DevExpress.XtraEditors.CheckEdit()
        Me.cmdPrintOffer = New DevExpress.XtraEditors.SimpleButton()
        Me.lblDate = New DevExpress.XtraEditors.LabelControl()
        Me.txtdtdaysOfDelivery = New DevExpress.XtraEditors.TextEdit()
        Me.cmdSave = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdExit = New DevExpress.XtraEditors.SimpleButton()
        Me.cboCUS = New DevExpress.XtraEditors.LookUpEdit()
        Me.txtarProt = New DevExpress.XtraEditors.TextEdit()
        Me.dtpresentation = New DevExpress.XtraEditors.DateEdit()
        Me.txtInitialPrice1 = New DevExpress.XtraEditors.TextEdit()
        Me.txtInitialPrice2 = New DevExpress.XtraEditors.TextEdit()
        Me.txtInitialPrice3 = New DevExpress.XtraEditors.TextEdit()
        Me.txtInitialPrice4 = New DevExpress.XtraEditors.TextEdit()
        Me.txtDisc1 = New DevExpress.XtraEditors.TextEdit()
        Me.txtDisc2 = New DevExpress.XtraEditors.TextEdit()
        Me.txtDisc3 = New DevExpress.XtraEditors.TextEdit()
        Me.txtDisc4 = New DevExpress.XtraEditors.TextEdit()
        Me.txtDiscount1 = New DevExpress.XtraEditors.TextEdit()
        Me.txtDiscount2 = New DevExpress.XtraEditors.TextEdit()
        Me.txtDiscount3 = New DevExpress.XtraEditors.TextEdit()
        Me.txtDiscount4 = New DevExpress.XtraEditors.TextEdit()
        Me.txtFinalPrice1 = New DevExpress.XtraEditors.TextEdit()
        Me.txtFinalPrice2 = New DevExpress.XtraEditors.TextEdit()
        Me.txtFinalPrice3 = New DevExpress.XtraEditors.TextEdit()
        Me.txtFinalPrice4 = New DevExpress.XtraEditors.TextEdit()
        Me.cboEMP = New DevExpress.XtraEditors.LookUpEdit()
        Me.txtComments = New DevExpress.XtraEditors.MemoEdit()
        Me.txtDescription = New DevExpress.XtraEditors.MemoEdit()
        Me.txtnotes = New DevExpress.XtraEditors.MemoEdit()
        Me.txtTotalSpecialPrice = New DevExpress.XtraEditors.TextEdit()
        Me.txtTotalSpecialVat = New DevExpress.XtraEditors.TextEdit()
        Me.cboTRANSH = New DevExpress.XtraEditors.LookUpEdit()
        Me.txtExtraInst = New DevExpress.XtraEditors.TextEdit()
        Me.txtPartofVat = New DevExpress.XtraEditors.TextEdit()
        Me.cboVALUELISTITEM4 = New DevExpress.XtraEditors.LookUpEdit()
        Me.cboValueListItem = New DevExpress.XtraEditors.LookUpEdit()
        Me.cboVALUELISTITEM2 = New DevExpress.XtraEditors.LookUpEdit()
        Me.cboVALUELISTITEM3 = New DevExpress.XtraEditors.LookUpEdit()
        Me.cboScpecialConstr1 = New DevExpress.XtraEditors.LookUpEdit()
        Me.cboScpecialConstr3 = New DevExpress.XtraEditors.LookUpEdit()
        Me.cboScpecialConstr2 = New DevExpress.XtraEditors.LookUpEdit()
        Me.cboScpecialConstr4 = New DevExpress.XtraEditors.LookUpEdit()
        Me.txtExtraTransp = New DevExpress.XtraEditors.TextEdit()
        Me.txtTotAmt = New DevExpress.XtraEditors.TextEdit()
        Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LExit = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LGroupOrderDetails1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.Ldtpresentation = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LarProt = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem46 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem31 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem47 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LTRANSH = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LofferAccepted = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem13 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LCompProject = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem51 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem52 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LGenOffer = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem48 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem14 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LGroupOrderDetails2 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem14 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem20 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup6 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.TabbedControlGroup1 = New DevExpress.XtraLayout.TabbedControlGroup()
        Me.LayoutControlGroup9 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem34 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.Lcost3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem38 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem42 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem17 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem21 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup3 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem23 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem18 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem35 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.Lcost1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem39 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem43 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup4 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem22 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem19 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem36 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.Lcost2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem40 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem44 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup5 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem24 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem63 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem37 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.Lcost4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem41 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem45 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LCost = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LPartofVat = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LTotalSpecialVat = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LTotalSpecialPrice = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LExtraTransp = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LExtraInst = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem4 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LConvertToOrder = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LPrivateAgreement = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LOrder = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LNewRecord = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem125 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem54 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem3 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.TabNavigationPage2 = New DevExpress.XtraBars.Navigation.TabNavigationPage()
        Me.LayoutControl3 = New DevExpress.XtraLayout.LayoutControl()
        Me.cmdPrintPhotos = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdSavePhotos = New DevExpress.XtraEditors.SimpleButton()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.VwCCTORDERSPHOTOSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CardView1 = New DevExpress.XtraGrid.Views.Card.CardView()
        Me.colcolorCatID1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemColorCat = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.colColorsCatName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsupID1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemSup = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.colSupFullName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colvalueListItemID1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemValueListiItem = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.colValueListItemName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colphoto = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colID1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colvalueListItemID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCustomCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colcreatedOn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colcreatedBy = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colcolorCatID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colmodifiedBy = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colmodifiedOn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsite = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsupID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemPhoto = New DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit()
        Me.cboPhotoValueListItem = New DevExpress.XtraEditors.LookUpEdit()
        Me.cboSUP1 = New DevExpress.XtraEditors.LookUpEdit()
        Me.VwSUPBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.cboColorsCat = New DevExpress.XtraEditors.LookUpEdit()
        Me.VwCOLORSCATBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PictureEdit2 = New DevExpress.XtraEditors.PictureEdit()
        Me.LayoutControlGroup14 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem25 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem26 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem27 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem28 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem29 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem32 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem5 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem33 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.TabNavigationPage3 = New DevExpress.XtraBars.Navigation.TabNavigationPage()
        Me.LayoutControl4 = New DevExpress.XtraLayout.LayoutControl()
        Me.cmdSaveTransF = New DevExpress.XtraEditors.SimpleButton()
        Me.cboTanshFCategory = New DevExpress.XtraEditors.LookUpEdit()
        Me.VwFILECATBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridControl2 = New DevExpress.XtraGrid.GridControl()
        Me.TRANSHFBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coltranshID1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colfilename = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colcomefrom = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colextension = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colmodifiedOn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colcreatedOn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtFiles = New DevExpress.XtraEditors.ButtonEdit()
        Me.LayoutControlGroup16 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem49 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem12 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem6 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.Vw_CCT_ORDERS_PHOTOSTableAdapter = New DreamyKitchenCRM.DM_CCTTableAdapters.vw_CCT_ORDERS_PHOTOSTableAdapter()
        Me.TRANSH_FTableAdapter = New DreamyKitchenCRM.DM_TRANSTableAdapters.TRANSH_FTableAdapter()
        Me.Vw_SUPTableAdapter = New DreamyKitchenCRM.DreamyKitchenDataSetTableAdapters.vw_SUPTableAdapter()
        Me.Vw_COLORS_CATTableAdapter = New DreamyKitchenCRM.DreamyKitchenDataSetTableAdapters.vw_COLORS_CATTableAdapter()
        Me.XtraOpenFileDialog1 = New DevExpress.XtraEditors.XtraOpenFileDialog(Me.components)
        Me.VwSCANFILENAMESBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Vw_FILE_CATTableAdapter = New DreamyKitchenCRM.DreamyKitchenDataSetTableAdapters.vw_FILE_CATTableAdapter()
        CType(Me.VwCOMPBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DM_CCT, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VwCCTBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DreamyKitchenDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VwSALERSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VwVALUELISTITEMV2BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DM_VALUELISTITEM, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VwCONSTRTYPEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DMDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VwVALUELISTITEMSpecialConstrBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CCTTRANSHBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DM_TRANS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TabPane1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPane1.SuspendLayout()
        Me.TabNavigationPage1.SuspendLayout()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.chkGenOffer.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboCompProject.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboCompany.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkofferAccepted.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkVatVisible.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtdtdaysOfDelivery.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboCUS.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtarProt.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpresentation.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpresentation.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtInitialPrice1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtInitialPrice2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtInitialPrice3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtInitialPrice4.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDisc1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDisc2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDisc3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDisc4.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDiscount1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDiscount2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDiscount3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDiscount4.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFinalPrice1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFinalPrice2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFinalPrice3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFinalPrice4.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboEMP.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtComments.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDescription.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtnotes.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTotalSpecialPrice.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTotalSpecialVat.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboTRANSH.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtExtraInst.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPartofVat.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboVALUELISTITEM4.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboValueListItem.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboVALUELISTITEM2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboVALUELISTITEM3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboScpecialConstr1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboScpecialConstr3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboScpecialConstr2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboScpecialConstr4.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtExtraTransp.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTotAmt.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LExit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LGroupOrderDetails1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ldtpresentation, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LarProt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem46, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem31, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem47, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LTRANSH, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LofferAccepted, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LCompProject, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem51, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem52, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LGenOffer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem48, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LGroupOrderDetails2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem20, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TabbedControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem34, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Lcost3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem38, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem42, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem17, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem21, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem23, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem18, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem35, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Lcost1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem39, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem43, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem22, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem19, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem36, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Lcost2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem40, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem44, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem24, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem63, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem37, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Lcost4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem41, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem45, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LCost, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LPartofVat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LTotalSpecialVat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LTotalSpecialPrice, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LExtraTransp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LExtraInst, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LConvertToOrder, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LPrivateAgreement, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LOrder, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LNewRecord, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem125, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem54, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabNavigationPage2.SuspendLayout()
        CType(Me.LayoutControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl3.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VwCCTORDERSPHOTOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CardView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemColorCat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemSup, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemValueListiItem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemPhoto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboPhotoValueListItem.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboSUP1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VwSUPBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboColorsCat.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VwCOLORSCATBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem25, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem26, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem27, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem28, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem29, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem32, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem33, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabNavigationPage3.SuspendLayout()
        CType(Me.LayoutControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl4.SuspendLayout()
        CType(Me.cboTanshFCategory.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VwFILECATBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TRANSHFBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFiles.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem49, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VwSCANFILENAMESBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'VwCOMPBindingSource
        '
        Me.VwCOMPBindingSource.DataMember = "vw_COMP"
        Me.VwCOMPBindingSource.DataSource = Me.DM_CCT
        '
        'DM_CCT
        '
        Me.DM_CCT.DataSetName = "DM_CCT"
        Me.DM_CCT.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'VwSALERSBindingSource
        '
        Me.VwSALERSBindingSource.DataMember = "vw_SALERS"
        Me.VwSALERSBindingSource.DataSource = Me.DreamyKitchenDataSet
        '
        'VwVALUELISTITEMV2BindingSource
        '
        Me.VwVALUELISTITEMV2BindingSource.DataMember = "vw_VALUELISTITEM_V2"
        Me.VwVALUELISTITEMV2BindingSource.DataSource = Me.DM_VALUELISTITEM
        '
        'DM_VALUELISTITEM
        '
        Me.DM_VALUELISTITEM.DataSetName = "DM_VALUELISTITEM"
        Me.DM_VALUELISTITEM.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'VwCONSTRTYPEBindingSource
        '
        Me.VwCONSTRTYPEBindingSource.DataMember = "vw_CONSTR_TYPE"
        Me.VwCONSTRTYPEBindingSource.DataSource = Me.DMDataSet
        '
        'DMDataSet
        '
        Me.DMDataSet.DataSetName = "DMDataSet"
        Me.DMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'VwVALUELISTITEMSpecialConstrBindingSource
        '
        Me.VwVALUELISTITEMSpecialConstrBindingSource.DataMember = "vw_VALUELISTITEMSpecialConstr"
        Me.VwVALUELISTITEMSpecialConstrBindingSource.DataSource = Me.DM_VALUELISTITEM
        '
        'Vw_SALERSTableAdapter
        '
        Me.Vw_SALERSTableAdapter.ClearBeforeFill = True
        '
        'Vw_VALUELISTITEMSpecialConstrTableAdapter
        '
        Me.Vw_VALUELISTITEMSpecialConstrTableAdapter.ClearBeforeFill = True
        '
        'Vw_VALUELISTITEM_V2TableAdapter
        '
        Me.Vw_VALUELISTITEM_V2TableAdapter.ClearBeforeFill = True
        '
        'Vw_CCTTableAdapter
        '
        Me.Vw_CCTTableAdapter.ClearBeforeFill = True
        '
        'Vw_CONSTR_TYPETableAdapter
        '
        Me.Vw_CONSTR_TYPETableAdapter.ClearBeforeFill = True
        '
        'CCTTRANSHBindingSource
        '
        Me.CCTTRANSHBindingSource.DataMember = "CCT_TRANSH"
        Me.CCTTRANSHBindingSource.DataSource = Me.DM_TRANS
        '
        'DM_TRANS
        '
        Me.DM_TRANS.DataSetName = "DM_TRANS"
        Me.DM_TRANS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CCT_TRANSHTableAdapter
        '
        Me.CCT_TRANSHTableAdapter.ClearBeforeFill = True
        '
        'Vw_COMPTableAdapter
        '
        Me.Vw_COMPTableAdapter.ClearBeforeFill = True
        '
        'TabPane1
        '
        Me.TabPane1.Controls.Add(Me.TabNavigationPage1)
        Me.TabPane1.Controls.Add(Me.TabNavigationPage2)
        Me.TabPane1.Controls.Add(Me.TabNavigationPage3)
        Me.TabPane1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabPane1.Location = New System.Drawing.Point(0, 0)
        Me.TabPane1.Margin = New System.Windows.Forms.Padding(4)
        Me.TabPane1.Name = "TabPane1"
        Me.TabPane1.Pages.AddRange(New DevExpress.XtraBars.Navigation.NavigationPageBase() {Me.TabNavigationPage1, Me.TabNavigationPage2, Me.TabNavigationPage3})
        Me.TabPane1.RegularSize = New System.Drawing.Size(1282, 1010)
        Me.TabPane1.SelectedPage = Me.TabNavigationPage1
        Me.TabPane1.Size = New System.Drawing.Size(1282, 1010)
        Me.TabPane1.TabIndex = 0
        Me.TabPane1.Text = "TabPane1"
        '
        'TabNavigationPage1
        '
        Me.TabNavigationPage1.Caption = "TabNavigationPage1"
        Me.TabNavigationPage1.Controls.Add(Me.LayoutControl1)
        Me.TabNavigationPage1.Margin = New System.Windows.Forms.Padding(4)
        Me.TabNavigationPage1.Name = "TabNavigationPage1"
        Me.TabNavigationPage1.PageText = "ΕΙΔΙΚΕΣ ΚΑΤΑΣΚΕΥΕΣ"
        Me.TabNavigationPage1.Size = New System.Drawing.Size(1282, 961)
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.LblMsg)
        Me.LayoutControl1.Controls.Add(Me.cmdOrder)
        Me.LayoutControl1.Controls.Add(Me.cmdPrivateAgreement)
        Me.LayoutControl1.Controls.Add(Me.cmdNewRecord)
        Me.LayoutControl1.Controls.Add(Me.chkGenOffer)
        Me.LayoutControl1.Controls.Add(Me.cmdCusCollection)
        Me.LayoutControl1.Controls.Add(Me.cmdCompCollection)
        Me.LayoutControl1.Controls.Add(Me.cboCompProject)
        Me.LayoutControl1.Controls.Add(Me.cboCompany)
        Me.LayoutControl1.Controls.Add(Me.chkofferAccepted)
        Me.LayoutControl1.Controls.Add(Me.cmdConvertToOrder)
        Me.LayoutControl1.Controls.Add(Me.chkVatVisible)
        Me.LayoutControl1.Controls.Add(Me.cmdPrintOffer)
        Me.LayoutControl1.Controls.Add(Me.lblDate)
        Me.LayoutControl1.Controls.Add(Me.txtdtdaysOfDelivery)
        Me.LayoutControl1.Controls.Add(Me.cmdSave)
        Me.LayoutControl1.Controls.Add(Me.cmdExit)
        Me.LayoutControl1.Controls.Add(Me.cboCUS)
        Me.LayoutControl1.Controls.Add(Me.txtarProt)
        Me.LayoutControl1.Controls.Add(Me.dtpresentation)
        Me.LayoutControl1.Controls.Add(Me.txtInitialPrice1)
        Me.LayoutControl1.Controls.Add(Me.txtInitialPrice2)
        Me.LayoutControl1.Controls.Add(Me.txtInitialPrice3)
        Me.LayoutControl1.Controls.Add(Me.txtInitialPrice4)
        Me.LayoutControl1.Controls.Add(Me.txtDisc1)
        Me.LayoutControl1.Controls.Add(Me.txtDisc2)
        Me.LayoutControl1.Controls.Add(Me.txtDisc3)
        Me.LayoutControl1.Controls.Add(Me.txtDisc4)
        Me.LayoutControl1.Controls.Add(Me.txtDiscount1)
        Me.LayoutControl1.Controls.Add(Me.txtDiscount2)
        Me.LayoutControl1.Controls.Add(Me.txtDiscount3)
        Me.LayoutControl1.Controls.Add(Me.txtDiscount4)
        Me.LayoutControl1.Controls.Add(Me.txtFinalPrice1)
        Me.LayoutControl1.Controls.Add(Me.txtFinalPrice2)
        Me.LayoutControl1.Controls.Add(Me.txtFinalPrice3)
        Me.LayoutControl1.Controls.Add(Me.txtFinalPrice4)
        Me.LayoutControl1.Controls.Add(Me.cboEMP)
        Me.LayoutControl1.Controls.Add(Me.txtComments)
        Me.LayoutControl1.Controls.Add(Me.txtDescription)
        Me.LayoutControl1.Controls.Add(Me.txtnotes)
        Me.LayoutControl1.Controls.Add(Me.txtTotalSpecialPrice)
        Me.LayoutControl1.Controls.Add(Me.txtTotalSpecialVat)
        Me.LayoutControl1.Controls.Add(Me.cboTRANSH)
        Me.LayoutControl1.Controls.Add(Me.txtExtraInst)
        Me.LayoutControl1.Controls.Add(Me.txtPartofVat)
        Me.LayoutControl1.Controls.Add(Me.cboVALUELISTITEM4)
        Me.LayoutControl1.Controls.Add(Me.cboValueListItem)
        Me.LayoutControl1.Controls.Add(Me.cboVALUELISTITEM2)
        Me.LayoutControl1.Controls.Add(Me.cboVALUELISTITEM3)
        Me.LayoutControl1.Controls.Add(Me.cboScpecialConstr1)
        Me.LayoutControl1.Controls.Add(Me.cboScpecialConstr3)
        Me.LayoutControl1.Controls.Add(Me.cboScpecialConstr2)
        Me.LayoutControl1.Controls.Add(Me.cboScpecialConstr4)
        Me.LayoutControl1.Controls.Add(Me.txtExtraTransp)
        Me.LayoutControl1.Controls.Add(Me.txtTotAmt)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(1789, 469, 1122, 950)
        Me.LayoutControl1.Root = Me.Root
        Me.LayoutControl1.Size = New System.Drawing.Size(1282, 961)
        Me.LayoutControl1.TabIndex = 3
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'LblMsg
        '
        Me.LblMsg.Appearance.Font = New System.Drawing.Font("Tahoma", 8.142858!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.LblMsg.Appearance.ForeColor = System.Drawing.Color.Red
        Me.LblMsg.Appearance.Options.UseFont = True
        Me.LblMsg.Appearance.Options.UseForeColor = True
        Me.LblMsg.Location = New System.Drawing.Point(12, 894)
        Me.LblMsg.Margin = New System.Windows.Forms.Padding(10)
        Me.LblMsg.Name = "LblMsg"
        Me.LblMsg.Size = New System.Drawing.Size(1258, 19)
        Me.LblMsg.StyleController = Me.LayoutControl1
        Me.LblMsg.TabIndex = 107
        '
        'cmdOrder
        '
        Me.cmdOrder.ImageOptions.Image = Global.DreamyKitchenCRM.My.Resources.Resources.icons8_purchase_order_24
        Me.cmdOrder.Location = New System.Drawing.Point(533, 917)
        Me.cmdOrder.Margin = New System.Windows.Forms.Padding(9, 10, 9, 10)
        Me.cmdOrder.Name = "cmdOrder"
        Me.cmdOrder.Size = New System.Drawing.Size(118, 32)
        Me.cmdOrder.StyleController = Me.LayoutControl1
        Me.cmdOrder.TabIndex = 106
        Me.cmdOrder.Text = "Παραγγελία"
        '
        'cmdPrivateAgreement
        '
        Me.cmdPrivateAgreement.ImageOptions.Image = Global.DreamyKitchenCRM.My.Resources.Resources.icons8_agreement_24
        Me.cmdPrivateAgreement.Location = New System.Drawing.Point(655, 917)
        Me.cmdPrivateAgreement.Margin = New System.Windows.Forms.Padding(9, 10, 9, 10)
        Me.cmdPrivateAgreement.Name = "cmdPrivateAgreement"
        Me.cmdPrivateAgreement.Size = New System.Drawing.Size(158, 32)
        Me.cmdPrivateAgreement.StyleController = Me.LayoutControl1
        Me.cmdPrivateAgreement.TabIndex = 105
        Me.cmdPrivateAgreement.Text = "Ιδ. Συμφωνητικό"
        '
        'cmdNewRecord
        '
        Me.cmdNewRecord.ImageOptions.Image = Global.DreamyKitchenCRM.My.Resources.Resources.icons8_new_document_24
        Me.cmdNewRecord.Location = New System.Drawing.Point(397, 917)
        Me.cmdNewRecord.Margin = New System.Windows.Forms.Padding(9, 10, 9, 10)
        Me.cmdNewRecord.Name = "cmdNewRecord"
        Me.cmdNewRecord.Size = New System.Drawing.Size(132, 32)
        Me.cmdNewRecord.StyleController = Me.LayoutControl1
        Me.cmdNewRecord.TabIndex = 104
        Me.cmdNewRecord.Text = "Νέα Εγγραφή"
        '
        'chkGenOffer
        '
        Me.chkGenOffer.EditValue = CType(0, Byte)
        Me.chkGenOffer.Location = New System.Drawing.Point(804, 56)
        Me.chkGenOffer.Margin = New System.Windows.Forms.Padding(15)
        Me.chkGenOffer.Name = "chkGenOffer"
        Me.chkGenOffer.Properties.Appearance.BackColor = System.Drawing.Color.LightSlateGray
        Me.chkGenOffer.Properties.Appearance.ForeColor = System.Drawing.Color.White
        Me.chkGenOffer.Properties.Appearance.Options.UseBackColor = True
        Me.chkGenOffer.Properties.Appearance.Options.UseForeColor = True
        Me.chkGenOffer.Properties.Caption = "Γενική Προσφορά Εταιρίας"
        Me.chkGenOffer.Properties.Tag = "dimChanged"
        Me.chkGenOffer.Properties.ValueChecked = CType(1, Byte)
        Me.chkGenOffer.Properties.ValueUnchecked = CType(0, Byte)
        Me.chkGenOffer.Size = New System.Drawing.Size(231, 27)
        Me.chkGenOffer.StyleController = Me.LayoutControl1
        Me.chkGenOffer.TabIndex = 103
        Me.chkGenOffer.Tag = "GenOffer,0,1,2"
        '
        'cmdCusCollection
        '
        Me.cmdCusCollection.ImageOptions.Image = CType(resources.GetObject("cmdCusCollection.ImageOptions.Image"), System.Drawing.Image)
        Me.cmdCusCollection.Location = New System.Drawing.Point(1150, 154)
        Me.cmdCusCollection.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdCusCollection.Name = "cmdCusCollection"
        Me.cmdCusCollection.Size = New System.Drawing.Size(108, 32)
        Me.cmdCusCollection.StyleController = Me.LayoutControl1
        Me.cmdCusCollection.TabIndex = 102
        Me.cmdCusCollection.Text = "Είσπραξη"
        '
        'cmdCompCollection
        '
        Me.cmdCompCollection.ImageOptions.Image = CType(resources.GetObject("cmdCompCollection.ImageOptions.Image"), System.Drawing.Image)
        Me.cmdCompCollection.Location = New System.Drawing.Point(1150, 118)
        Me.cmdCompCollection.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdCompCollection.Name = "cmdCompCollection"
        Me.cmdCompCollection.Size = New System.Drawing.Size(108, 32)
        Me.cmdCompCollection.StyleController = Me.LayoutControl1
        Me.cmdCompCollection.TabIndex = 101
        Me.cmdCompCollection.Text = "Είσπραξη"
        '
        'cboCompProject
        '
        Me.cboCompProject.Location = New System.Drawing.Point(788, 118)
        Me.cboCompProject.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.cboCompProject.Name = "cboCompProject"
        Me.cboCompProject.Properties.AllowMouseWheel = False
        Me.cboCompProject.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.cboCompProject.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Search), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Clear)})
        Me.cboCompProject.Properties.DisplayMember = "description"
        Me.cboCompProject.Properties.NullText = ""
        Me.cboCompProject.Properties.PopupWidthMode = DevExpress.XtraEditors.PopupWidthMode.ContentWidth
        Me.cboCompProject.Properties.ShowPopupButtons = DevExpress.Utils.DefaultBoolean.[True]
        Me.cboCompProject.Properties.ValueMember = "ID"
        Me.cboCompProject.Size = New System.Drawing.Size(358, 26)
        Me.cboCompProject.StyleController = Me.LayoutControl1
        Me.cboCompProject.TabIndex = 100
        Me.cboCompProject.Tag = "compTrashID,0,1,2"
        '
        'cboCompany
        '
        Me.cboCompany.Location = New System.Drawing.Point(226, 118)
        Me.cboCompany.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.cboCompany.Name = "cboCompany"
        Me.cboCompany.Properties.AllowMouseWheel = False
        Me.cboCompany.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.cboCompany.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Search), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Clear)})
        Me.cboCompany.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 54, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("code", "code", 85, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Fullname", "Όνομα", 142, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CouID", "Cou ID", 114, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("AreaID", "Area ID", 124, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("AdrID", "Adr ID", 111, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("SourceID", "Source ID", 156, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("SalerID", "Saler ID", 130, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("DoyID", "Doy ID", 114, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("PrfID", "Prf ID", 100, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("phn", "Τηλέφωνο", 76, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("mob", "mob", 82, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("fax", "fax", 63, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("email", "email", 93, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("afm", "afm", 75, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("cmt", "cmt", 73, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("modifiedBy", "modified By", 177, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("modifiedOn", "modified On", 184, DevExpress.Utils.FormatType.DateTime, "d/M/yyyy", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("createdOn", "created On", 169, DevExpress.Utils.FormatType.DateTime, "d/M/yyyy", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("name", "name", 97, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("RealName", "Real Name", 168, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("COU_Name", "COU_Name", 174, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("SRC_Name", "SRC_Name", 169, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("AREAS_Name", "AREAS_Name", 204, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ADR_Name", "ADR_Name", 174, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("PRF_Name", "PRF_Name", 168, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("SALERS_Name", "SALERS_Name", 219, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("color", "color", 85, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Ar", "Ar", 51, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("tk", "tk", 48, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("createdby_Realname", "createdby_Realname", 300, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("HasFiles", "Has Files", 139, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("createdBy", "created By", 163, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default])})
        Me.cboCompany.Properties.DataSource = Me.VwCOMPBindingSource
        Me.cboCompany.Properties.DisplayMember = "Fullname"
        Me.cboCompany.Properties.NullText = ""
        Me.cboCompany.Properties.PopupSizeable = False
        Me.cboCompany.Properties.ValueMember = "ID"
        Me.cboCompany.Size = New System.Drawing.Size(356, 26)
        Me.cboCompany.StyleController = Me.LayoutControl1
        Me.cboCompany.TabIndex = 99
        Me.cboCompany.Tag = "compID,0,1,2"
        '
        'chkofferAccepted
        '
        Me.chkofferAccepted.EditValue = CType(0, Byte)
        Me.chkofferAccepted.Location = New System.Drawing.Point(1039, 56)
        Me.chkofferAccepted.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.chkofferAccepted.Name = "chkofferAccepted"
        Me.chkofferAccepted.Properties.Appearance.BackColor = System.Drawing.Color.RosyBrown
        Me.chkofferAccepted.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.142858!, System.Drawing.FontStyle.Bold)
        Me.chkofferAccepted.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.chkofferAccepted.Properties.Appearance.Options.UseBackColor = True
        Me.chkofferAccepted.Properties.Appearance.Options.UseFont = True
        Me.chkofferAccepted.Properties.Appearance.Options.UseForeColor = True
        Me.chkofferAccepted.Properties.Caption = "Αποδοχή Προσφοράς"
        Me.chkofferAccepted.Properties.Tag = "dimChanged"
        Me.chkofferAccepted.Properties.ValueChecked = CType(1, Byte)
        Me.chkofferAccepted.Properties.ValueUnchecked = CType(0, Byte)
        Me.chkofferAccepted.Size = New System.Drawing.Size(219, 27)
        Me.chkofferAccepted.StyleController = Me.LayoutControl1
        Me.chkofferAccepted.TabIndex = 75
        Me.chkofferAccepted.Tag = "offerAccepted,0,1,2"
        '
        'cmdConvertToOrder
        '
        Me.cmdConvertToOrder.ImageOptions.Image = Global.DreamyKitchenCRM.My.Resources.Resources.ConvertToOrder24
        Me.cmdConvertToOrder.Location = New System.Drawing.Point(817, 917)
        Me.cmdConvertToOrder.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdConvertToOrder.Name = "cmdConvertToOrder"
        Me.cmdConvertToOrder.Size = New System.Drawing.Size(224, 32)
        Me.cmdConvertToOrder.StyleController = Me.LayoutControl1
        Me.cmdConvertToOrder.TabIndex = 65
        Me.cmdConvertToOrder.Text = "Μετατροπή σε Παραγγελία"
        '
        'chkVatVisible
        '
        Me.chkVatVisible.EditValue = CType(0, Byte)
        Me.chkVatVisible.Location = New System.Drawing.Point(125, 917)
        Me.chkVatVisible.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.chkVatVisible.Name = "chkVatVisible"
        Me.chkVatVisible.Properties.Caption = "Εμφάνιση ΦΠΑ στην εκτύπωση"
        Me.chkVatVisible.Properties.ValueChecked = CType(1, Byte)
        Me.chkVatVisible.Properties.ValueUnchecked = CType(0, Byte)
        Me.chkVatVisible.Size = New System.Drawing.Size(254, 27)
        Me.chkVatVisible.StyleController = Me.LayoutControl1
        Me.chkVatVisible.TabIndex = 64
        Me.chkVatVisible.Tag = "visibleVAT,0,1,2"
        '
        'cmdPrintOffer
        '
        Me.cmdPrintOffer.ImageOptions.Image = Global.DreamyKitchenCRM.My.Resources.Resources.icons8_print_24
        Me.cmdPrintOffer.Location = New System.Drawing.Point(12, 917)
        Me.cmdPrintOffer.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.cmdPrintOffer.Name = "cmdPrintOffer"
        Me.cmdPrintOffer.Size = New System.Drawing.Size(109, 32)
        Me.cmdPrintOffer.StyleController = Me.LayoutControl1
        Me.cmdPrintOffer.TabIndex = 56
        Me.cmdPrintOffer.Text = "Εκτύπωση"
        '
        'lblDate
        '
        Me.lblDate.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.lblDate.Appearance.ForeColor = System.Drawing.SystemColors.Highlight
        Me.lblDate.Appearance.Options.UseFont = True
        Me.lblDate.Appearance.Options.UseForeColor = True
        Me.lblDate.Location = New System.Drawing.Point(903, 190)
        Me.lblDate.Margin = New System.Windows.Forms.Padding(4)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(355, 22)
        Me.lblDate.StyleController = Me.LayoutControl1
        Me.lblDate.TabIndex = 51
        Me.lblDate.Text = "Ημερομηνία Παράδοσης: (ΗΗ/ΜΜ/ΕΕΕ)"
        '
        'txtdtdaysOfDelivery
        '
        Me.txtdtdaysOfDelivery.EditValue = "0"
        Me.txtdtdaysOfDelivery.Location = New System.Drawing.Point(788, 190)
        Me.txtdtdaysOfDelivery.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.txtdtdaysOfDelivery.Name = "txtdtdaysOfDelivery"
        Me.txtdtdaysOfDelivery.Properties.MaskSettings.Set("MaskManagerType", GetType(DevExpress.Data.Mask.NumericMaskManager))
        Me.txtdtdaysOfDelivery.Properties.MaskSettings.Set("mask", "d")
        Me.txtdtdaysOfDelivery.Properties.MaskSettings.Set("valueAfterDelete", DevExpress.Data.Mask.NumericMaskManager.ValueAfterDelete.ZeroThenNull)
        Me.txtdtdaysOfDelivery.Properties.MaskSettings.Set("valueType", GetType(Integer))
        Me.txtdtdaysOfDelivery.Properties.UseMaskAsDisplayFormat = True
        Me.txtdtdaysOfDelivery.Properties.UseReadOnlyAppearance = False
        Me.txtdtdaysOfDelivery.Size = New System.Drawing.Size(111, 26)
        Me.txtdtdaysOfDelivery.StyleController = Me.LayoutControl1
        Me.txtdtdaysOfDelivery.TabIndex = 50
        Me.txtdtdaysOfDelivery.Tag = "daysofdeliver,0,1,2"
        '
        'cmdSave
        '
        Me.cmdSave.ImageOptions.Image = CType(resources.GetObject("cmdSave.ImageOptions.Image"), System.Drawing.Image)
        Me.cmdSave.Location = New System.Drawing.Point(1045, 917)
        Me.cmdSave.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(125, 32)
        Me.cmdSave.StyleController = Me.LayoutControl1
        Me.cmdSave.TabIndex = 22
        Me.cmdSave.Text = "Αποθήκευση"
        '
        'cmdExit
        '
        Me.cmdExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdExit.ImageOptions.Image = CType(resources.GetObject("cmdExit.ImageOptions.Image"), System.Drawing.Image)
        Me.cmdExit.Location = New System.Drawing.Point(1174, 917)
        Me.cmdExit.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(96, 32)
        Me.cmdExit.StyleController = Me.LayoutControl1
        Me.cmdExit.TabIndex = 21
        Me.cmdExit.Text = "Έξοδος"
        '
        'cboCUS
        '
        Me.cboCUS.Location = New System.Drawing.Point(226, 154)
        Me.cboCUS.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.cboCUS.Name = "cboCUS"
        Me.cboCUS.Properties.AllowMouseWheel = False
        Me.cboCUS.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.cboCUS.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Search), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Clear)})
        Me.cboCUS.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 54, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("code", "code", 85, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Fullname", "Όνομα", 142, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CouID", "Cou ID", 114, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("AreaID", "Area ID", 124, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("AdrID", "Adr ID", 111, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("SourceID", "Source ID", 156, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("SalerID", "Saler ID", 130, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("DoyID", "Doy ID", 114, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("PrfID", "Prf ID", 100, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("phn", "Τηλέφωνο", 76, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("mob", "mob", 82, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("fax", "fax", 63, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("email", "email", 93, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("afm", "afm", 75, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("cmt", "cmt", 73, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("modifiedBy", "modified By", 177, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("modifiedOn", "modified On", 184, DevExpress.Utils.FormatType.DateTime, "d/M/yyyy", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("createdOn", "created On", 169, DevExpress.Utils.FormatType.DateTime, "d/M/yyyy", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("name", "name", 97, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("RealName", "Real Name", 168, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("COU_Name", "COU_Name", 174, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("SRC_Name", "SRC_Name", 169, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("AREAS_Name", "AREAS_Name", 204, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ADR_Name", "ADR_Name", 174, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("PRF_Name", "PRF_Name", 168, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("SALERS_Name", "SALERS_Name", 219, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("color", "color", 85, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Ar", "Ar", 51, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("tk", "tk", 48, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("createdby_Realname", "createdby_Realname", 300, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("HasFiles", "Has Files", 139, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("createdBy", "created By", 163, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default])})
        Me.cboCUS.Properties.DataSource = Me.VwCCTBindingSource
        Me.cboCUS.Properties.DisplayMember = "Fullname"
        Me.cboCUS.Properties.NullText = ""
        Me.cboCUS.Properties.PopupSizeable = False
        Me.cboCUS.Properties.ValueMember = "ID"
        Me.cboCUS.Size = New System.Drawing.Size(356, 26)
        Me.cboCUS.StyleController = Me.LayoutControl1
        Me.cboCUS.TabIndex = 5
        Me.cboCUS.Tag = "cusID,0,1,2"
        '
        'txtarProt
        '
        Me.txtarProt.Location = New System.Drawing.Point(226, 56)
        Me.txtarProt.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.txtarProt.Name = "txtarProt"
        Me.txtarProt.Properties.Appearance.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.txtarProt.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtarProt.Properties.Appearance.Options.UseBackColor = True
        Me.txtarProt.Properties.Appearance.Options.UseFont = True
        Me.txtarProt.Properties.ReadOnly = True
        Me.txtarProt.Size = New System.Drawing.Size(95, 28)
        Me.txtarProt.StyleController = Me.LayoutControl1
        Me.txtarProt.TabIndex = 4
        Me.txtarProt.Tag = "arProt,0,1,2"
        '
        'dtpresentation
        '
        Me.dtpresentation.EditValue = Nothing
        Me.dtpresentation.Location = New System.Drawing.Point(226, 190)
        Me.dtpresentation.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.dtpresentation.Name = "dtpresentation"
        Me.dtpresentation.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtpresentation.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtpresentation.Size = New System.Drawing.Size(356, 26)
        Me.dtpresentation.StyleController = Me.LayoutControl1
        Me.dtpresentation.TabIndex = 32
        Me.dtpresentation.Tag = "dtOffer,0,1,2"
        '
        'txtInitialPrice1
        '
        Me.txtInitialPrice1.EditValue = "0,00 €"
        Me.txtInitialPrice1.Location = New System.Drawing.Point(687, 652)
        Me.txtInitialPrice1.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.txtInitialPrice1.Name = "txtInitialPrice1"
        Me.txtInitialPrice1.Properties.DisplayFormat.FormatString = "c"
        Me.txtInitialPrice1.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtInitialPrice1.Properties.EditFormat.FormatString = "n2"
        Me.txtInitialPrice1.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtInitialPrice1.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtInitialPrice1.Properties.MaskSettings.Set("MaskManagerType", GetType(DevExpress.Data.Mask.NumericMaskManager))
        Me.txtInitialPrice1.Properties.MaskSettings.Set("mask", "c2")
        Me.txtInitialPrice1.Properties.Tag = "BenchExtraPrice"
        Me.txtInitialPrice1.Properties.UseReadOnlyAppearance = False
        Me.txtInitialPrice1.Size = New System.Drawing.Size(144, 26)
        Me.txtInitialPrice1.StyleController = Me.LayoutControl1
        Me.txtInitialPrice1.TabIndex = 42
        Me.txtInitialPrice1.Tag = "modelInitialPrice1,0,1,2"
        Me.txtInitialPrice1.Visible = False
        '
        'txtInitialPrice2
        '
        Me.txtInitialPrice2.EditValue = "0,00 €"
        Me.txtInitialPrice2.Location = New System.Drawing.Point(687, 652)
        Me.txtInitialPrice2.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.txtInitialPrice2.Name = "txtInitialPrice2"
        Me.txtInitialPrice2.Properties.DisplayFormat.FormatString = "c"
        Me.txtInitialPrice2.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtInitialPrice2.Properties.EditFormat.FormatString = "n2"
        Me.txtInitialPrice2.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtInitialPrice2.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtInitialPrice2.Properties.MaskSettings.Set("MaskManagerType", GetType(DevExpress.Data.Mask.NumericMaskManager))
        Me.txtInitialPrice2.Properties.MaskSettings.Set("mask", "c2")
        Me.txtInitialPrice2.Properties.Tag = "BenchExtraPrice"
        Me.txtInitialPrice2.Properties.UseReadOnlyAppearance = False
        Me.txtInitialPrice2.Size = New System.Drawing.Size(144, 26)
        Me.txtInitialPrice2.StyleController = Me.LayoutControl1
        Me.txtInitialPrice2.TabIndex = 42
        Me.txtInitialPrice2.Tag = "modelInitialPrice2,0,1,2"
        Me.txtInitialPrice2.Visible = False
        '
        'txtInitialPrice3
        '
        Me.txtInitialPrice3.EditValue = "0,00 €"
        Me.txtInitialPrice3.Location = New System.Drawing.Point(687, 652)
        Me.txtInitialPrice3.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.txtInitialPrice3.Name = "txtInitialPrice3"
        Me.txtInitialPrice3.Properties.DisplayFormat.FormatString = "c"
        Me.txtInitialPrice3.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtInitialPrice3.Properties.EditFormat.FormatString = "n2"
        Me.txtInitialPrice3.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtInitialPrice3.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtInitialPrice3.Properties.MaskSettings.Set("MaskManagerType", GetType(DevExpress.Data.Mask.NumericMaskManager))
        Me.txtInitialPrice3.Properties.MaskSettings.Set("mask", "c2")
        Me.txtInitialPrice3.Properties.Tag = "BenchExtraPrice"
        Me.txtInitialPrice3.Properties.UseReadOnlyAppearance = False
        Me.txtInitialPrice3.Size = New System.Drawing.Size(144, 26)
        Me.txtInitialPrice3.StyleController = Me.LayoutControl1
        Me.txtInitialPrice3.TabIndex = 42
        Me.txtInitialPrice3.Tag = "modelInitialPrice3,0,1,2"
        Me.txtInitialPrice3.Visible = False
        '
        'txtInitialPrice4
        '
        Me.txtInitialPrice4.EditValue = "0,00 €"
        Me.txtInitialPrice4.Location = New System.Drawing.Point(687, 652)
        Me.txtInitialPrice4.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.txtInitialPrice4.Name = "txtInitialPrice4"
        Me.txtInitialPrice4.Properties.DisplayFormat.FormatString = "c"
        Me.txtInitialPrice4.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtInitialPrice4.Properties.EditFormat.FormatString = "n2"
        Me.txtInitialPrice4.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtInitialPrice4.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtInitialPrice4.Properties.MaskSettings.Set("MaskManagerType", GetType(DevExpress.Data.Mask.NumericMaskManager))
        Me.txtInitialPrice4.Properties.MaskSettings.Set("mask", "c2")
        Me.txtInitialPrice4.Properties.Tag = "BenchExtraPrice"
        Me.txtInitialPrice4.Properties.UseReadOnlyAppearance = False
        Me.txtInitialPrice4.Size = New System.Drawing.Size(144, 26)
        Me.txtInitialPrice4.StyleController = Me.LayoutControl1
        Me.txtInitialPrice4.TabIndex = 42
        Me.txtInitialPrice4.Tag = "modelInitialPrice4,0,1,2"
        Me.txtInitialPrice4.Visible = False
        '
        'txtDisc1
        '
        Me.txtDisc1.EditValue = "0%"
        Me.txtDisc1.Location = New System.Drawing.Point(835, 652)
        Me.txtDisc1.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.txtDisc1.Name = "txtDisc1"
        Me.txtDisc1.Properties.DisplayFormat.FormatString = "c"
        Me.txtDisc1.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtDisc1.Properties.EditFormat.FormatString = "n2"
        Me.txtDisc1.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtDisc1.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtDisc1.Properties.MaskSettings.Set("MaskManagerType", GetType(DevExpress.Data.Mask.NumericMaskManager))
        Me.txtDisc1.Properties.MaskSettings.Set("mask", "P0")
        Me.txtDisc1.Properties.Tag = "BenchExtraPrice"
        Me.txtDisc1.Properties.UseReadOnlyAppearance = False
        Me.txtDisc1.Size = New System.Drawing.Size(124, 26)
        Me.txtDisc1.StyleController = Me.LayoutControl1
        Me.txtDisc1.TabIndex = 42
        Me.txtDisc1.Tag = "discount1,0,1,2"
        Me.txtDisc1.Visible = False
        '
        'txtDisc2
        '
        Me.txtDisc2.EditValue = "0%"
        Me.txtDisc2.Location = New System.Drawing.Point(835, 652)
        Me.txtDisc2.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.txtDisc2.Name = "txtDisc2"
        Me.txtDisc2.Properties.DisplayFormat.FormatString = "c"
        Me.txtDisc2.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtDisc2.Properties.EditFormat.FormatString = "n2"
        Me.txtDisc2.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtDisc2.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtDisc2.Properties.MaskSettings.Set("MaskManagerType", GetType(DevExpress.Data.Mask.NumericMaskManager))
        Me.txtDisc2.Properties.MaskSettings.Set("mask", "P0")
        Me.txtDisc2.Properties.Tag = "BenchExtraPrice"
        Me.txtDisc2.Properties.UseReadOnlyAppearance = False
        Me.txtDisc2.Size = New System.Drawing.Size(124, 26)
        Me.txtDisc2.StyleController = Me.LayoutControl1
        Me.txtDisc2.TabIndex = 42
        Me.txtDisc2.Tag = "discount2,0,1,2"
        Me.txtDisc2.Visible = False
        '
        'txtDisc3
        '
        Me.txtDisc3.EditValue = "0%"
        Me.txtDisc3.Location = New System.Drawing.Point(835, 652)
        Me.txtDisc3.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.txtDisc3.Name = "txtDisc3"
        Me.txtDisc3.Properties.DisplayFormat.FormatString = "c"
        Me.txtDisc3.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtDisc3.Properties.EditFormat.FormatString = "n2"
        Me.txtDisc3.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtDisc3.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtDisc3.Properties.MaskSettings.Set("MaskManagerType", GetType(DevExpress.Data.Mask.NumericMaskManager))
        Me.txtDisc3.Properties.MaskSettings.Set("mask", "P0")
        Me.txtDisc3.Properties.Tag = "BenchExtraPrice"
        Me.txtDisc3.Properties.UseReadOnlyAppearance = False
        Me.txtDisc3.Size = New System.Drawing.Size(124, 26)
        Me.txtDisc3.StyleController = Me.LayoutControl1
        Me.txtDisc3.TabIndex = 42
        Me.txtDisc3.Tag = "discount3,0,1,2"
        Me.txtDisc3.Visible = False
        '
        'txtDisc4
        '
        Me.txtDisc4.EditValue = "0%"
        Me.txtDisc4.Location = New System.Drawing.Point(835, 652)
        Me.txtDisc4.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.txtDisc4.Name = "txtDisc4"
        Me.txtDisc4.Properties.DisplayFormat.FormatString = "c"
        Me.txtDisc4.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtDisc4.Properties.EditFormat.FormatString = "n2"
        Me.txtDisc4.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtDisc4.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtDisc4.Properties.MaskSettings.Set("MaskManagerType", GetType(DevExpress.Data.Mask.NumericMaskManager))
        Me.txtDisc4.Properties.MaskSettings.Set("mask", "P0")
        Me.txtDisc4.Properties.Tag = "BenchExtraPrice"
        Me.txtDisc4.Properties.UseReadOnlyAppearance = False
        Me.txtDisc4.Size = New System.Drawing.Size(124, 26)
        Me.txtDisc4.StyleController = Me.LayoutControl1
        Me.txtDisc4.TabIndex = 42
        Me.txtDisc4.Tag = "discount4,0,1,2"
        Me.txtDisc4.Visible = False
        '
        'txtDiscount1
        '
        Me.txtDiscount1.EditValue = "0,00 €"
        Me.txtDiscount1.Location = New System.Drawing.Point(963, 652)
        Me.txtDiscount1.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.txtDiscount1.Name = "txtDiscount1"
        Me.txtDiscount1.Properties.DisplayFormat.FormatString = "c"
        Me.txtDiscount1.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtDiscount1.Properties.EditFormat.FormatString = "n2"
        Me.txtDiscount1.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtDiscount1.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtDiscount1.Properties.MaskSettings.Set("MaskManagerType", GetType(DevExpress.Data.Mask.NumericMaskManager))
        Me.txtDiscount1.Properties.MaskSettings.Set("mask", "c2")
        Me.txtDiscount1.Properties.ReadOnly = True
        Me.txtDiscount1.Properties.Tag = "BenchExtraPrice"
        Me.txtDiscount1.Properties.UseReadOnlyAppearance = False
        Me.txtDiscount1.Size = New System.Drawing.Size(150, 26)
        Me.txtDiscount1.StyleController = Me.LayoutControl1
        Me.txtDiscount1.TabIndex = 42
        Me.txtDiscount1.Tag = "modelDiscount1,0,1,2"
        Me.txtDiscount1.Visible = False
        '
        'txtDiscount2
        '
        Me.txtDiscount2.EditValue = "0,00 €"
        Me.txtDiscount2.Location = New System.Drawing.Point(963, 652)
        Me.txtDiscount2.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.txtDiscount2.Name = "txtDiscount2"
        Me.txtDiscount2.Properties.DisplayFormat.FormatString = "c"
        Me.txtDiscount2.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtDiscount2.Properties.EditFormat.FormatString = "n2"
        Me.txtDiscount2.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtDiscount2.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtDiscount2.Properties.MaskSettings.Set("MaskManagerType", GetType(DevExpress.Data.Mask.NumericMaskManager))
        Me.txtDiscount2.Properties.MaskSettings.Set("mask", "c2")
        Me.txtDiscount2.Properties.ReadOnly = True
        Me.txtDiscount2.Properties.Tag = "BenchExtraPrice"
        Me.txtDiscount2.Properties.UseReadOnlyAppearance = False
        Me.txtDiscount2.Size = New System.Drawing.Size(150, 26)
        Me.txtDiscount2.StyleController = Me.LayoutControl1
        Me.txtDiscount2.TabIndex = 42
        Me.txtDiscount2.Tag = "modelDiscount2,0,1,2"
        Me.txtDiscount2.Visible = False
        '
        'txtDiscount3
        '
        Me.txtDiscount3.EditValue = "0,00 €"
        Me.txtDiscount3.Location = New System.Drawing.Point(963, 652)
        Me.txtDiscount3.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.txtDiscount3.Name = "txtDiscount3"
        Me.txtDiscount3.Properties.DisplayFormat.FormatString = "c"
        Me.txtDiscount3.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtDiscount3.Properties.EditFormat.FormatString = "n2"
        Me.txtDiscount3.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtDiscount3.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtDiscount3.Properties.MaskSettings.Set("MaskManagerType", GetType(DevExpress.Data.Mask.NumericMaskManager))
        Me.txtDiscount3.Properties.MaskSettings.Set("mask", "c2")
        Me.txtDiscount3.Properties.ReadOnly = True
        Me.txtDiscount3.Properties.Tag = "BenchExtraPrice"
        Me.txtDiscount3.Properties.UseReadOnlyAppearance = False
        Me.txtDiscount3.Size = New System.Drawing.Size(150, 26)
        Me.txtDiscount3.StyleController = Me.LayoutControl1
        Me.txtDiscount3.TabIndex = 42
        Me.txtDiscount3.Tag = "modelDiscount3,0,1,2"
        Me.txtDiscount3.Visible = False
        '
        'txtDiscount4
        '
        Me.txtDiscount4.EditValue = "0,00 €"
        Me.txtDiscount4.Location = New System.Drawing.Point(963, 652)
        Me.txtDiscount4.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.txtDiscount4.Name = "txtDiscount4"
        Me.txtDiscount4.Properties.DisplayFormat.FormatString = "c"
        Me.txtDiscount4.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtDiscount4.Properties.EditFormat.FormatString = "n2"
        Me.txtDiscount4.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtDiscount4.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtDiscount4.Properties.MaskSettings.Set("MaskManagerType", GetType(DevExpress.Data.Mask.NumericMaskManager))
        Me.txtDiscount4.Properties.MaskSettings.Set("mask", "c2")
        Me.txtDiscount4.Properties.ReadOnly = True
        Me.txtDiscount4.Properties.Tag = "BenchExtraPrice"
        Me.txtDiscount4.Properties.UseReadOnlyAppearance = False
        Me.txtDiscount4.Size = New System.Drawing.Size(150, 26)
        Me.txtDiscount4.StyleController = Me.LayoutControl1
        Me.txtDiscount4.TabIndex = 42
        Me.txtDiscount4.Tag = "modelDiscount4,0,1,2"
        Me.txtDiscount4.Visible = False
        '
        'txtFinalPrice1
        '
        Me.txtFinalPrice1.EditValue = "0,00 €"
        Me.txtFinalPrice1.Location = New System.Drawing.Point(1117, 652)
        Me.txtFinalPrice1.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.txtFinalPrice1.Name = "txtFinalPrice1"
        Me.txtFinalPrice1.Properties.DisplayFormat.FormatString = "c"
        Me.txtFinalPrice1.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtFinalPrice1.Properties.EditFormat.FormatString = "n2"
        Me.txtFinalPrice1.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtFinalPrice1.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtFinalPrice1.Properties.MaskSettings.Set("MaskManagerType", GetType(DevExpress.Data.Mask.NumericMaskManager))
        Me.txtFinalPrice1.Properties.MaskSettings.Set("mask", "c2")
        Me.txtFinalPrice1.Properties.ReadOnly = True
        Me.txtFinalPrice1.Properties.Tag = "BenchExtraPrice"
        Me.txtFinalPrice1.Properties.UseReadOnlyAppearance = False
        Me.txtFinalPrice1.Size = New System.Drawing.Size(129, 26)
        Me.txtFinalPrice1.StyleController = Me.LayoutControl1
        Me.txtFinalPrice1.TabIndex = 42
        Me.txtFinalPrice1.Tag = "modelFinalPrice1,0,1,2"
        Me.txtFinalPrice1.Visible = False
        '
        'txtFinalPrice2
        '
        Me.txtFinalPrice2.EditValue = "0,00 €"
        Me.txtFinalPrice2.Location = New System.Drawing.Point(1117, 652)
        Me.txtFinalPrice2.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.txtFinalPrice2.Name = "txtFinalPrice2"
        Me.txtFinalPrice2.Properties.DisplayFormat.FormatString = "c"
        Me.txtFinalPrice2.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtFinalPrice2.Properties.EditFormat.FormatString = "n2"
        Me.txtFinalPrice2.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtFinalPrice2.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtFinalPrice2.Properties.MaskSettings.Set("MaskManagerType", GetType(DevExpress.Data.Mask.NumericMaskManager))
        Me.txtFinalPrice2.Properties.MaskSettings.Set("mask", "c2")
        Me.txtFinalPrice2.Properties.ReadOnly = True
        Me.txtFinalPrice2.Properties.Tag = "BenchExtraPrice"
        Me.txtFinalPrice2.Properties.UseReadOnlyAppearance = False
        Me.txtFinalPrice2.Size = New System.Drawing.Size(129, 26)
        Me.txtFinalPrice2.StyleController = Me.LayoutControl1
        Me.txtFinalPrice2.TabIndex = 42
        Me.txtFinalPrice2.Tag = "modelFinalPrice2,0,1,2"
        Me.txtFinalPrice2.Visible = False
        '
        'txtFinalPrice3
        '
        Me.txtFinalPrice3.EditValue = "0,00 €"
        Me.txtFinalPrice3.Location = New System.Drawing.Point(1117, 652)
        Me.txtFinalPrice3.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.txtFinalPrice3.Name = "txtFinalPrice3"
        Me.txtFinalPrice3.Properties.DisplayFormat.FormatString = "c"
        Me.txtFinalPrice3.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtFinalPrice3.Properties.EditFormat.FormatString = "n2"
        Me.txtFinalPrice3.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtFinalPrice3.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtFinalPrice3.Properties.MaskSettings.Set("MaskManagerType", GetType(DevExpress.Data.Mask.NumericMaskManager))
        Me.txtFinalPrice3.Properties.MaskSettings.Set("mask", "c2")
        Me.txtFinalPrice3.Properties.ReadOnly = True
        Me.txtFinalPrice3.Properties.Tag = "BenchExtraPrice"
        Me.txtFinalPrice3.Properties.UseReadOnlyAppearance = False
        Me.txtFinalPrice3.Size = New System.Drawing.Size(129, 26)
        Me.txtFinalPrice3.StyleController = Me.LayoutControl1
        Me.txtFinalPrice3.TabIndex = 42
        Me.txtFinalPrice3.Tag = "modelFinalPrice3,0,1,2"
        Me.txtFinalPrice3.Visible = False
        '
        'txtFinalPrice4
        '
        Me.txtFinalPrice4.EditValue = "0,00 €"
        Me.txtFinalPrice4.Location = New System.Drawing.Point(1117, 652)
        Me.txtFinalPrice4.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.txtFinalPrice4.Name = "txtFinalPrice4"
        Me.txtFinalPrice4.Properties.DisplayFormat.FormatString = "c"
        Me.txtFinalPrice4.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtFinalPrice4.Properties.EditFormat.FormatString = "n2"
        Me.txtFinalPrice4.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtFinalPrice4.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtFinalPrice4.Properties.MaskSettings.Set("MaskManagerType", GetType(DevExpress.Data.Mask.NumericMaskManager))
        Me.txtFinalPrice4.Properties.MaskSettings.Set("mask", "c2")
        Me.txtFinalPrice4.Properties.ReadOnly = True
        Me.txtFinalPrice4.Properties.Tag = "BenchExtraPrice"
        Me.txtFinalPrice4.Properties.UseReadOnlyAppearance = False
        Me.txtFinalPrice4.Size = New System.Drawing.Size(129, 26)
        Me.txtFinalPrice4.StyleController = Me.LayoutControl1
        Me.txtFinalPrice4.TabIndex = 42
        Me.txtFinalPrice4.Tag = "modelFinalPrice4,0,1,2"
        Me.txtFinalPrice4.Visible = False
        '
        'cboEMP
        '
        Me.cboEMP.Location = New System.Drawing.Point(226, 88)
        Me.cboEMP.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.cboEMP.Name = "cboEMP"
        Me.cboEMP.Properties.AllowMouseWheel = False
        Me.cboEMP.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.cboEMP.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Search), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Clear)})
        Me.cboEMP.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 54, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("code", "code", 85, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("color", "color", 85, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("RealName", "Real Name", 168, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("name", "Πωλητής", 97, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default])})
        Me.cboEMP.Properties.DataSource = Me.VwSALERSBindingSource
        Me.cboEMP.Properties.DisplayMember = "name"
        Me.cboEMP.Properties.NullText = ""
        Me.cboEMP.Properties.PopupSizeable = False
        Me.cboEMP.Properties.ValueMember = "ID"
        Me.cboEMP.Size = New System.Drawing.Size(1032, 26)
        Me.cboEMP.StyleController = Me.LayoutControl1
        Me.cboEMP.TabIndex = 5
        Me.cboEMP.Tag = "empID,0,1,2"
        '
        'txtComments
        '
        Me.txtComments.Location = New System.Drawing.Point(449, 296)
        Me.txtComments.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.txtComments.Name = "txtComments"
        Me.txtComments.Size = New System.Drawing.Size(413, 231)
        Me.txtComments.StyleController = Me.LayoutControl1
        Me.txtComments.TabIndex = 17
        Me.txtComments.Tag = "cmt,0,1,2"
        '
        'txtDescription
        '
        Me.txtDescription.Location = New System.Drawing.Point(24, 296)
        Me.txtDescription.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(421, 231)
        Me.txtDescription.StyleController = Me.LayoutControl1
        Me.txtDescription.TabIndex = 17
        Me.txtDescription.Tag = "description,0,1,2"
        '
        'txtnotes
        '
        Me.txtnotes.Location = New System.Drawing.Point(866, 296)
        Me.txtnotes.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.txtnotes.Name = "txtnotes"
        Me.txtnotes.Size = New System.Drawing.Size(392, 231)
        Me.txtnotes.StyleController = Me.LayoutControl1
        Me.txtnotes.TabIndex = 17
        Me.txtnotes.Tag = "notes,0,1,2"
        '
        'txtTotalSpecialPrice
        '
        Me.txtTotalSpecialPrice.EditValue = "0,00 €"
        Me.txtTotalSpecialPrice.Location = New System.Drawing.Point(1117, 814)
        Me.txtTotalSpecialPrice.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.txtTotalSpecialPrice.Name = "txtTotalSpecialPrice"
        Me.txtTotalSpecialPrice.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.txtTotalSpecialPrice.Properties.Appearance.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.txtTotalSpecialPrice.Properties.Appearance.Options.UseFont = True
        Me.txtTotalSpecialPrice.Properties.Appearance.Options.UseForeColor = True
        Me.txtTotalSpecialPrice.Properties.DisplayFormat.FormatString = "c"
        Me.txtTotalSpecialPrice.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtTotalSpecialPrice.Properties.EditFormat.FormatString = "n2"
        Me.txtTotalSpecialPrice.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtTotalSpecialPrice.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtTotalSpecialPrice.Properties.MaskSettings.Set("MaskManagerType", GetType(DevExpress.Data.Mask.NumericMaskManager))
        Me.txtTotalSpecialPrice.Properties.MaskSettings.Set("mask", "c2")
        Me.txtTotalSpecialPrice.Properties.ReadOnly = True
        Me.txtTotalSpecialPrice.Properties.Tag = "BenchExtraPrice"
        Me.txtTotalSpecialPrice.Properties.UseReadOnlyAppearance = False
        Me.txtTotalSpecialPrice.Size = New System.Drawing.Size(141, 30)
        Me.txtTotalSpecialPrice.StyleController = Me.LayoutControl1
        Me.txtTotalSpecialPrice.TabIndex = 42
        Me.txtTotalSpecialPrice.Tag = "TotalSpecialPice,0,1,2"
        Me.txtTotalSpecialPrice.Visible = False
        '
        'txtTotalSpecialVat
        '
        Me.txtTotalSpecialVat.EditValue = "0,00 €"
        Me.txtTotalSpecialVat.Location = New System.Drawing.Point(1117, 784)
        Me.txtTotalSpecialVat.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.txtTotalSpecialVat.Name = "txtTotalSpecialVat"
        Me.txtTotalSpecialVat.Properties.DisplayFormat.FormatString = "c"
        Me.txtTotalSpecialVat.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtTotalSpecialVat.Properties.EditFormat.FormatString = "n2"
        Me.txtTotalSpecialVat.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtTotalSpecialVat.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtTotalSpecialVat.Properties.MaskSettings.Set("MaskManagerType", GetType(DevExpress.Data.Mask.NumericMaskManager))
        Me.txtTotalSpecialVat.Properties.MaskSettings.Set("mask", "c2")
        Me.txtTotalSpecialVat.Properties.ReadOnly = True
        Me.txtTotalSpecialVat.Properties.Tag = "BenchExtraPrice"
        Me.txtTotalSpecialVat.Properties.UseReadOnlyAppearance = False
        Me.txtTotalSpecialVat.Size = New System.Drawing.Size(141, 26)
        Me.txtTotalSpecialVat.StyleController = Me.LayoutControl1
        Me.txtTotalSpecialVat.TabIndex = 42
        Me.txtTotalSpecialVat.Tag = "TotalSpecialVat,0,1,2"
        Me.txtTotalSpecialVat.Visible = False
        '
        'cboTRANSH
        '
        Me.cboTRANSH.Location = New System.Drawing.Point(788, 154)
        Me.cboTRANSH.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.cboTRANSH.Name = "cboTRANSH"
        Me.cboTRANSH.Properties.AllowMouseWheel = False
        Me.cboTRANSH.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.cboTRANSH.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Search), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Clear)})
        Me.cboTRANSH.Properties.DisplayMember = "description"
        Me.cboTRANSH.Properties.NullText = ""
        Me.cboTRANSH.Properties.PopupWidthMode = DevExpress.XtraEditors.PopupWidthMode.ContentWidth
        Me.cboTRANSH.Properties.ShowPopupButtons = DevExpress.Utils.DefaultBoolean.[True]
        Me.cboTRANSH.Properties.ValueMember = "ID"
        Me.cboTRANSH.Size = New System.Drawing.Size(358, 26)
        Me.cboTRANSH.StyleController = Me.LayoutControl1
        Me.cboTRANSH.TabIndex = 6
        Me.cboTRANSH.Tag = "transhID,0,1,2"
        '
        'txtExtraInst
        '
        Me.txtExtraInst.EditValue = "0,00 €"
        Me.txtExtraInst.Location = New System.Drawing.Point(805, 784)
        Me.txtExtraInst.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
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
        Me.txtExtraInst.Size = New System.Drawing.Size(106, 26)
        Me.txtExtraInst.StyleController = Me.LayoutControl1
        Me.txtExtraInst.TabIndex = 42
        Me.txtExtraInst.Tag = "ExtraInst,0,1,2"
        Me.txtExtraInst.Visible = False
        '
        'txtPartofVat
        '
        Me.txtPartofVat.EditValue = "0,00 €"
        Me.txtPartofVat.Location = New System.Drawing.Point(1117, 750)
        Me.txtPartofVat.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
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
        Me.txtPartofVat.Size = New System.Drawing.Size(141, 30)
        Me.txtPartofVat.StyleController = Me.LayoutControl1
        Me.txtPartofVat.TabIndex = 42
        Me.txtPartofVat.Tag = "PartOfVat,0,1,2"
        Me.txtPartofVat.Visible = False
        '
        'cboVALUELISTITEM4
        '
        Me.cboVALUELISTITEM4.Location = New System.Drawing.Point(321, 652)
        Me.cboVALUELISTITEM4.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.cboVALUELISTITEM4.Name = "cboVALUELISTITEM4"
        Me.cboVALUELISTITEM4.Properties.AllowMouseWheel = False
        Me.cboVALUELISTITEM4.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.cboVALUELISTITEM4.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Search), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Clear)})
        Me.cboVALUELISTITEM4.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Modifier", "Modifier", 129, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 54, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("code", "code", 85, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CustomCode", "Κωδικός", 196, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("name", "Περιγραφή", 97, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("cat", "cat", 63, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("color", "color", 85, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Price", "Price", 85, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("comments", "comments", 159, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("modifiedBy", "modified By", 177, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("modifiedOn", "modified On", 184, DevExpress.Utils.FormatType.DateTime, "d/M/yyyy", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("createdOn", "created On", 169, DevExpress.Utils.FormatType.DateTime, "d/M/yyyy", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("createdBy", "created By", 163, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("doorColorID", "door Color ID", 201, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ColorName", "Color Name", 175, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("typeDescr", "type Descr", 163, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("type", "type", 79, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("valueListItem", "door Type", 157, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("kasa", "kasa", 82, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("dimName", "dim Name", 159, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("dimID", "dim ID", 112, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("valueListID", "door Cat ID", 175, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("valueListName", "door Cat Name", 222, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("closetType", "closet Type", 172, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("description", "Κατηγορία", 168, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default])})
        Me.cboVALUELISTITEM4.Properties.DataSource = Me.VwVALUELISTITEMV2BindingSource
        Me.cboVALUELISTITEM4.Properties.DisplayMember = "name"
        Me.cboVALUELISTITEM4.Properties.NullText = ""
        Me.cboVALUELISTITEM4.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.cboVALUELISTITEM4.Properties.PopupSizeable = False
        Me.cboVALUELISTITEM4.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoSuggest
        Me.cboVALUELISTITEM4.Properties.ValueMember = "ID"
        Me.cboVALUELISTITEM4.Size = New System.Drawing.Size(362, 26)
        Me.cboVALUELISTITEM4.StyleController = Me.LayoutControl1
        Me.cboVALUELISTITEM4.TabIndex = 49
        Me.cboVALUELISTITEM4.Tag = "doorTypeID4,0,1,2"
        '
        'cboValueListItem
        '
        Me.cboValueListItem.Location = New System.Drawing.Point(321, 652)
        Me.cboValueListItem.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.cboValueListItem.Name = "cboValueListItem"
        Me.cboValueListItem.Properties.AllowMouseWheel = False
        Me.cboValueListItem.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.cboValueListItem.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Search), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Clear)})
        Me.cboValueListItem.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Modifier", "Modifier", 129, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 54, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("code", "code", 85, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CustomCode", "Κωδικός", 196, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("name", "Περιγραφή", 97, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("cat", "cat", 63, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("color", "color", 85, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Price", "Price", 85, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("comments", "comments", 159, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("modifiedBy", "modified By", 177, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("modifiedOn", "modified On", 184, DevExpress.Utils.FormatType.DateTime, "d/M/yyyy", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("createdOn", "created On", 169, DevExpress.Utils.FormatType.DateTime, "d/M/yyyy", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("createdBy", "created By", 163, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("doorColorID", "door Color ID", 201, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ColorName", "Color Name", 175, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("typeDescr", "type Descr", 163, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("type", "type", 79, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("valueListItem", "door Type", 157, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("kasa", "kasa", 82, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("dimName", "dim Name", 159, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("dimID", "dim ID", 112, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("valueListID", "door Cat ID", 175, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("valueListName", "door Cat Name", 222, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("closetType", "closet Type", 172, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("description", "Κατηγορία", 168, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default])})
        Me.cboValueListItem.Properties.DataSource = Me.VwVALUELISTITEMV2BindingSource
        Me.cboValueListItem.Properties.DisplayMember = "name"
        Me.cboValueListItem.Properties.NullText = ""
        Me.cboValueListItem.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.cboValueListItem.Properties.PopupSizeable = False
        Me.cboValueListItem.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoSuggest
        Me.cboValueListItem.Properties.ValueMember = "ID"
        Me.cboValueListItem.Size = New System.Drawing.Size(362, 26)
        Me.cboValueListItem.StyleController = Me.LayoutControl1
        Me.cboValueListItem.TabIndex = 49
        Me.cboValueListItem.Tag = "doorTypeID1,0,1,2"
        '
        'cboVALUELISTITEM2
        '
        Me.cboVALUELISTITEM2.Location = New System.Drawing.Point(321, 652)
        Me.cboVALUELISTITEM2.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.cboVALUELISTITEM2.Name = "cboVALUELISTITEM2"
        Me.cboVALUELISTITEM2.Properties.AllowMouseWheel = False
        Me.cboVALUELISTITEM2.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.cboVALUELISTITEM2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Search), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Clear)})
        Me.cboVALUELISTITEM2.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Modifier", "Modifier", 129, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 54, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("code", "code", 85, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CustomCode", "Κωδικός", 196, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("name", "Περιγραφή", 97, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("cat", "cat", 63, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("color", "color", 85, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Price", "Price", 85, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("comments", "comments", 159, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("modifiedBy", "modified By", 177, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("modifiedOn", "modified On", 184, DevExpress.Utils.FormatType.DateTime, "d/M/yyyy", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("createdOn", "created On", 169, DevExpress.Utils.FormatType.DateTime, "d/M/yyyy", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("createdBy", "created By", 163, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("doorColorID", "door Color ID", 201, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ColorName", "Color Name", 175, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("typeDescr", "type Descr", 163, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("type", "type", 79, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("valueListItem", "door Type", 157, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("kasa", "kasa", 82, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("dimName", "dim Name", 159, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("dimID", "dim ID", 112, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("valueListID", "door Cat ID", 175, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("valueListName", "door Cat Name", 222, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("closetType", "closet Type", 172, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("description", "Κατηγορία", 168, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default])})
        Me.cboVALUELISTITEM2.Properties.DataSource = Me.VwVALUELISTITEMV2BindingSource
        Me.cboVALUELISTITEM2.Properties.DisplayMember = "name"
        Me.cboVALUELISTITEM2.Properties.NullText = ""
        Me.cboVALUELISTITEM2.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.cboVALUELISTITEM2.Properties.PopupSizeable = False
        Me.cboVALUELISTITEM2.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoSuggest
        Me.cboVALUELISTITEM2.Properties.ValueMember = "ID"
        Me.cboVALUELISTITEM2.Size = New System.Drawing.Size(362, 26)
        Me.cboVALUELISTITEM2.StyleController = Me.LayoutControl1
        Me.cboVALUELISTITEM2.TabIndex = 49
        Me.cboVALUELISTITEM2.Tag = "DoorTypeID2,0,1,2"
        '
        'cboVALUELISTITEM3
        '
        Me.cboVALUELISTITEM3.Location = New System.Drawing.Point(321, 652)
        Me.cboVALUELISTITEM3.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.cboVALUELISTITEM3.Name = "cboVALUELISTITEM3"
        Me.cboVALUELISTITEM3.Properties.AllowMouseWheel = False
        Me.cboVALUELISTITEM3.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.cboVALUELISTITEM3.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Search), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Clear)})
        Me.cboVALUELISTITEM3.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Modifier", "Modifier", 129, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 54, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("code", "code", 85, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CustomCode", "Κωδικός", 196, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("name", "Περιγραφή", 97, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("cat", "cat", 63, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("color", "color", 85, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Price", "Price", 85, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("comments", "comments", 159, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("modifiedBy", "modified By", 177, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("modifiedOn", "modified On", 184, DevExpress.Utils.FormatType.DateTime, "d/M/yyyy", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("createdOn", "created On", 169, DevExpress.Utils.FormatType.DateTime, "d/M/yyyy", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("createdBy", "created By", 163, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("doorColorID", "door Color ID", 201, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ColorName", "Color Name", 175, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("typeDescr", "type Descr", 163, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("type", "type", 79, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("valueListItem", "door Type", 157, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("kasa", "kasa", 82, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("dimName", "dim Name", 159, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("dimID", "dim ID", 112, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("valueListID", "door Cat ID", 175, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("valueListName", "door Cat Name", 222, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("closetType", "closet Type", 172, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("description", "Κατηγορία", 168, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default])})
        Me.cboVALUELISTITEM3.Properties.DataSource = Me.VwVALUELISTITEMV2BindingSource
        Me.cboVALUELISTITEM3.Properties.DisplayMember = "name"
        Me.cboVALUELISTITEM3.Properties.NullText = ""
        Me.cboVALUELISTITEM3.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.cboVALUELISTITEM3.Properties.PopupSizeable = False
        Me.cboVALUELISTITEM3.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoSuggest
        Me.cboVALUELISTITEM3.Properties.ValueMember = "ID"
        Me.cboVALUELISTITEM3.Size = New System.Drawing.Size(362, 26)
        Me.cboVALUELISTITEM3.StyleController = Me.LayoutControl1
        Me.cboVALUELISTITEM3.TabIndex = 49
        Me.cboVALUELISTITEM3.Tag = "doorTypeID3,0,1,2"
        '
        'cboScpecialConstr1
        '
        Me.cboScpecialConstr1.Location = New System.Drawing.Point(36, 652)
        Me.cboScpecialConstr1.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.cboScpecialConstr1.Name = "cboScpecialConstr1"
        Me.cboScpecialConstr1.Properties.AllowMouseWheel = False
        Me.cboScpecialConstr1.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.cboScpecialConstr1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Search), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Clear)})
        Me.cboScpecialConstr1.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 54, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("name", "Κατασκευή", 97, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default])})
        Me.cboScpecialConstr1.Properties.DataSource = Me.VwCONSTRTYPEBindingSource
        Me.cboScpecialConstr1.Properties.DisplayMember = "name"
        Me.cboScpecialConstr1.Properties.NullText = ""
        Me.cboScpecialConstr1.Properties.PopupSizeable = False
        Me.cboScpecialConstr1.Properties.ValueMember = "ID"
        Me.cboScpecialConstr1.Size = New System.Drawing.Size(281, 26)
        Me.cboScpecialConstr1.StyleController = Me.LayoutControl1
        Me.cboScpecialConstr1.TabIndex = 49
        Me.cboScpecialConstr1.Tag = "constrTypeID1,0,1,2"
        '
        'cboScpecialConstr3
        '
        Me.cboScpecialConstr3.Location = New System.Drawing.Point(36, 652)
        Me.cboScpecialConstr3.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.cboScpecialConstr3.Name = "cboScpecialConstr3"
        Me.cboScpecialConstr3.Properties.AllowMouseWheel = False
        Me.cboScpecialConstr3.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.cboScpecialConstr3.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Search), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Clear)})
        Me.cboScpecialConstr3.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 54, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("name", "Κατασκευή", 97, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default])})
        Me.cboScpecialConstr3.Properties.DataSource = Me.VwCONSTRTYPEBindingSource
        Me.cboScpecialConstr3.Properties.DisplayMember = "name"
        Me.cboScpecialConstr3.Properties.NullText = ""
        Me.cboScpecialConstr3.Properties.PopupSizeable = False
        Me.cboScpecialConstr3.Properties.ValueMember = "ID"
        Me.cboScpecialConstr3.Size = New System.Drawing.Size(281, 26)
        Me.cboScpecialConstr3.StyleController = Me.LayoutControl1
        Me.cboScpecialConstr3.TabIndex = 49
        Me.cboScpecialConstr3.Tag = "constrTypeID3,0,1,2"
        '
        'cboScpecialConstr2
        '
        Me.cboScpecialConstr2.Location = New System.Drawing.Point(36, 652)
        Me.cboScpecialConstr2.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.cboScpecialConstr2.Name = "cboScpecialConstr2"
        Me.cboScpecialConstr2.Properties.AllowMouseWheel = False
        Me.cboScpecialConstr2.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.cboScpecialConstr2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Search), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Clear)})
        Me.cboScpecialConstr2.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 54, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("name", "Κατασκευή", 97, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default])})
        Me.cboScpecialConstr2.Properties.DataSource = Me.VwCONSTRTYPEBindingSource
        Me.cboScpecialConstr2.Properties.DisplayMember = "name"
        Me.cboScpecialConstr2.Properties.NullText = ""
        Me.cboScpecialConstr2.Properties.PopupSizeable = False
        Me.cboScpecialConstr2.Properties.ValueMember = "ID"
        Me.cboScpecialConstr2.Size = New System.Drawing.Size(281, 26)
        Me.cboScpecialConstr2.StyleController = Me.LayoutControl1
        Me.cboScpecialConstr2.TabIndex = 49
        Me.cboScpecialConstr2.Tag = "constrTypeID2,0,1,2"
        '
        'cboScpecialConstr4
        '
        Me.cboScpecialConstr4.Location = New System.Drawing.Point(36, 652)
        Me.cboScpecialConstr4.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.cboScpecialConstr4.Name = "cboScpecialConstr4"
        Me.cboScpecialConstr4.Properties.AllowMouseWheel = False
        Me.cboScpecialConstr4.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.cboScpecialConstr4.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Search), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Clear)})
        Me.cboScpecialConstr4.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 54, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("name", "Κατασκευή", 97, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default])})
        Me.cboScpecialConstr4.Properties.DataSource = Me.VwCONSTRTYPEBindingSource
        Me.cboScpecialConstr4.Properties.DisplayMember = "name"
        Me.cboScpecialConstr4.Properties.NullText = ""
        Me.cboScpecialConstr4.Properties.PopupSizeable = False
        Me.cboScpecialConstr4.Properties.ValueMember = "ID"
        Me.cboScpecialConstr4.Size = New System.Drawing.Size(281, 26)
        Me.cboScpecialConstr4.StyleController = Me.LayoutControl1
        Me.cboScpecialConstr4.TabIndex = 49
        Me.cboScpecialConstr4.Tag = "constrTypeID4,0,1,2"
        '
        'txtExtraTransp
        '
        Me.txtExtraTransp.EditValue = "0,00 €"
        Me.txtExtraTransp.Location = New System.Drawing.Point(805, 750)
        Me.txtExtraTransp.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
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
        Me.txtExtraTransp.Size = New System.Drawing.Size(106, 26)
        Me.txtExtraTransp.StyleController = Me.LayoutControl1
        Me.txtExtraTransp.TabIndex = 42
        Me.txtExtraTransp.Tag = "ExtraTransp,0,1,2"
        Me.txtExtraTransp.Visible = False
        '
        'txtTotAmt
        '
        Me.txtTotAmt.EditValue = "0,00 €"
        Me.txtTotAmt.Location = New System.Drawing.Point(1115, 860)
        Me.txtTotAmt.Margin = New System.Windows.Forms.Padding(15)
        Me.txtTotAmt.Name = "txtTotAmt"
        Me.txtTotAmt.Properties.Appearance.BackColor = System.Drawing.Color.Moccasin
        Me.txtTotAmt.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.txtTotAmt.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.txtTotAmt.Properties.Appearance.Options.UseBackColor = True
        Me.txtTotAmt.Properties.Appearance.Options.UseFont = True
        Me.txtTotAmt.Properties.Appearance.Options.UseForeColor = True
        Me.txtTotAmt.Properties.DisplayFormat.FormatString = "c"
        Me.txtTotAmt.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtTotAmt.Properties.EditFormat.FormatString = "n2"
        Me.txtTotAmt.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtTotAmt.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtTotAmt.Properties.MaskSettings.Set("MaskManagerType", GetType(DevExpress.Data.Mask.NumericMaskManager))
        Me.txtTotAmt.Properties.MaskSettings.Set("mask", "c2")
        Me.txtTotAmt.Properties.ReadOnly = True
        Me.txtTotAmt.Properties.Tag = "BenchExtraPrice"
        Me.txtTotAmt.Properties.UseReadOnlyAppearance = False
        Me.txtTotAmt.Size = New System.Drawing.Size(155, 30)
        Me.txtTotAmt.StyleController = Me.LayoutControl1
        Me.txtTotAmt.TabIndex = 42
        Me.txtTotAmt.Tag = "Totamt,0"
        Me.txtTotAmt.Visible = False
        '
        'Root
        '
        Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.Root.GroupBordersVisible = False
        Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LExit, Me.LayoutControlItem1, Me.LGroupOrderDetails1, Me.LayoutControlItem48, Me.EmptySpaceItem14, Me.LayoutControlItem5, Me.LGroupOrderDetails2, Me.LayoutControlGroup6, Me.LCost, Me.LConvertToOrder, Me.LPrivateAgreement, Me.LOrder, Me.LNewRecord, Me.LayoutControlItem125, Me.LayoutControlItem54, Me.EmptySpaceItem3})
        Me.Root.Name = "Root"
        Me.Root.OptionsItemText.TextToControlDistance = 1
        Me.Root.Size = New System.Drawing.Size(1282, 961)
        Me.Root.TextVisible = False
        '
        'LExit
        '
        Me.LExit.Control = Me.cmdExit
        Me.LExit.Location = New System.Drawing.Point(1162, 905)
        Me.LExit.Name = "LExit"
        Me.LExit.Size = New System.Drawing.Size(100, 36)
        Me.LExit.Text = "Έξοδος"
        Me.LExit.TextSize = New System.Drawing.Size(0, 0)
        Me.LExit.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.cmdSave
        Me.LayoutControlItem1.Location = New System.Drawing.Point(1033, 905)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(129, 36)
        Me.LayoutControlItem1.Text = "Αποθήκευση"
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'LGroupOrderDetails1
        '
        Me.LGroupOrderDetails1.AppearanceGroup.BorderColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Question
        Me.LGroupOrderDetails1.AppearanceGroup.Options.UseBorderColor = True
        Me.LGroupOrderDetails1.CustomizationFormText = "Στοιχεία Προσφοράς/Παραγγελίας"
        Me.LGroupOrderDetails1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem9, Me.Ldtpresentation, Me.LarProt, Me.EmptySpaceItem1, Me.LayoutControlItem46, Me.LayoutControlItem31, Me.LayoutControlItem47, Me.LTRANSH, Me.LofferAccepted, Me.LayoutControlItem13, Me.LCompProject, Me.LayoutControlItem51, Me.LayoutControlItem52, Me.LGenOffer})
        Me.LGroupOrderDetails1.Location = New System.Drawing.Point(0, 0)
        Me.LGroupOrderDetails1.Name = "LGroupOrderDetails1"
        Me.LGroupOrderDetails1.OptionsItemText.TextToControlDistance = 1
        Me.LGroupOrderDetails1.Size = New System.Drawing.Size(1262, 220)
        Me.LGroupOrderDetails1.Text = "Στοιχεία Προσφοράς/Παραγγελίας"
        '
        'LayoutControlItem9
        '
        Me.LayoutControlItem9.Control = Me.cboCUS
        Me.LayoutControlItem9.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem9.CustomizationFormText = "Πελάτης"
        Me.LayoutControlItem9.ImageOptions.Image = CType(resources.GetObject("LayoutControlItem9.ImageOptions.Image"), System.Drawing.Image)
        Me.LayoutControlItem9.Location = New System.Drawing.Point(0, 98)
        Me.LayoutControlItem9.Name = "LayoutControlItem9"
        Me.LayoutControlItem9.Size = New System.Drawing.Size(562, 36)
        Me.LayoutControlItem9.Tag = "1"
        Me.LayoutControlItem9.Text = "Πελάτης"
        Me.LayoutControlItem9.TextLocation = DevExpress.Utils.Locations.Left
        Me.LayoutControlItem9.TextSize = New System.Drawing.Size(201, 19)
        '
        'Ldtpresentation
        '
        Me.Ldtpresentation.Control = Me.dtpresentation
        Me.Ldtpresentation.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.Ldtpresentation.CustomizationFormText = "Ημερ/νία Παραγγελίας"
        Me.Ldtpresentation.ImageOptions.Image = CType(resources.GetObject("Ldtpresentation.ImageOptions.Image"), System.Drawing.Image)
        Me.Ldtpresentation.Location = New System.Drawing.Point(0, 134)
        Me.Ldtpresentation.Name = "Ldtpresentation"
        Me.Ldtpresentation.Size = New System.Drawing.Size(562, 30)
        Me.Ldtpresentation.Tag = "1"
        Me.Ldtpresentation.Text = "Ημερ/νία Παραγγελίας"
        Me.Ldtpresentation.TextSize = New System.Drawing.Size(201, 19)
        '
        'LarProt
        '
        Me.LarProt.Control = Me.txtarProt
        Me.LarProt.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LarProt.CustomizationFormText = "Αρ. Παραγγελίας"
        Me.LarProt.Location = New System.Drawing.Point(0, 0)
        Me.LarProt.Name = "LarProt"
        Me.LarProt.Size = New System.Drawing.Size(301, 32)
        Me.LarProt.Text = "Αρ. Παραγγελίας"
        Me.LarProt.TextSize = New System.Drawing.Size(201, 19)
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(301, 0)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(479, 32)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem46
        '
        Me.LayoutControlItem46.Control = Me.cboEMP
        Me.LayoutControlItem46.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem46.CustomizationFormText = "Πωλητής"
        Me.LayoutControlItem46.ImageOptions.Image = CType(resources.GetObject("LayoutControlItem46.ImageOptions.Image"), System.Drawing.Image)
        Me.LayoutControlItem46.Location = New System.Drawing.Point(0, 32)
        Me.LayoutControlItem46.Name = "LayoutControlItem46"
        Me.LayoutControlItem46.Size = New System.Drawing.Size(1238, 30)
        Me.LayoutControlItem46.Tag = "1"
        Me.LayoutControlItem46.Text = "Πωλητής"
        Me.LayoutControlItem46.TextLocation = DevExpress.Utils.Locations.Left
        Me.LayoutControlItem46.TextSize = New System.Drawing.Size(201, 19)
        '
        'LayoutControlItem31
        '
        Me.LayoutControlItem31.Control = Me.txtdtdaysOfDelivery
        Me.LayoutControlItem31.ImageOptions.Image = Global.DreamyKitchenCRM.My.Resources.Resources.rsz_11rsz_asterisk
        Me.LayoutControlItem31.Location = New System.Drawing.Point(562, 134)
        Me.LayoutControlItem31.Name = "LayoutControlItem31"
        Me.LayoutControlItem31.Size = New System.Drawing.Size(317, 30)
        Me.LayoutControlItem31.Tag = "1"
        Me.LayoutControlItem31.Text = "Μέρες Παράδοσης"
        Me.LayoutControlItem31.TextSize = New System.Drawing.Size(201, 19)
        '
        'LayoutControlItem47
        '
        Me.LayoutControlItem47.Control = Me.lblDate
        Me.LayoutControlItem47.Location = New System.Drawing.Point(879, 134)
        Me.LayoutControlItem47.Name = "LayoutControlItem47"
        Me.LayoutControlItem47.Size = New System.Drawing.Size(359, 30)
        Me.LayoutControlItem47.Text = "Ημερομηνία Παράδοσης: (ΗΗ/ΜΜ/ΕΕΕ)                        "
        Me.LayoutControlItem47.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem47.TextVisible = False
        '
        'LTRANSH
        '
        Me.LTRANSH.Control = Me.cboTRANSH
        Me.LTRANSH.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LTRANSH.CustomizationFormText = "Έργο Πελάτη"
        Me.LTRANSH.HighlightFocusedItem = DevExpress.Utils.DefaultBoolean.[True]
        Me.LTRANSH.ImageOptions.Image = CType(resources.GetObject("LTRANSH.ImageOptions.Image"), System.Drawing.Image)
        Me.LTRANSH.Location = New System.Drawing.Point(562, 98)
        Me.LTRANSH.Name = "LTRANSH"
        Me.LTRANSH.Size = New System.Drawing.Size(564, 36)
        Me.LTRANSH.Tag = "1"
        Me.LTRANSH.Text = "Έργο Πελάτη"
        Me.LTRANSH.TextSize = New System.Drawing.Size(201, 19)
        '
        'LofferAccepted
        '
        Me.LofferAccepted.Control = Me.chkofferAccepted
        Me.LofferAccepted.Location = New System.Drawing.Point(1015, 0)
        Me.LofferAccepted.Name = "LofferAccepted"
        Me.LofferAccepted.Size = New System.Drawing.Size(223, 32)
        Me.LofferAccepted.Text = "Αποδοχή Προσφοράς"
        Me.LofferAccepted.TextSize = New System.Drawing.Size(0, 0)
        Me.LofferAccepted.TextVisible = False
        '
        'LayoutControlItem13
        '
        Me.LayoutControlItem13.Control = Me.cboCompany
        Me.LayoutControlItem13.Location = New System.Drawing.Point(0, 62)
        Me.LayoutControlItem13.Name = "LayoutControlItem13"
        Me.LayoutControlItem13.Size = New System.Drawing.Size(562, 36)
        Me.LayoutControlItem13.Text = "Εταιρία"
        Me.LayoutControlItem13.TextSize = New System.Drawing.Size(201, 19)
        '
        'LCompProject
        '
        Me.LCompProject.Control = Me.cboCompProject
        Me.LCompProject.Location = New System.Drawing.Point(562, 62)
        Me.LCompProject.Name = "LCompProject"
        Me.LCompProject.Size = New System.Drawing.Size(564, 36)
        Me.LCompProject.Text = "Έργο Εταιρίας"
        Me.LCompProject.TextSize = New System.Drawing.Size(201, 19)
        '
        'LayoutControlItem51
        '
        Me.LayoutControlItem51.Control = Me.cmdCompCollection
        Me.LayoutControlItem51.Location = New System.Drawing.Point(1126, 62)
        Me.LayoutControlItem51.Name = "LayoutControlItem51"
        Me.LayoutControlItem51.Size = New System.Drawing.Size(112, 36)
        Me.LayoutControlItem51.Text = "Είσπραξη"
        Me.LayoutControlItem51.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem51.TextVisible = False
        '
        'LayoutControlItem52
        '
        Me.LayoutControlItem52.Control = Me.cmdCusCollection
        Me.LayoutControlItem52.Location = New System.Drawing.Point(1126, 98)
        Me.LayoutControlItem52.Name = "LayoutControlItem52"
        Me.LayoutControlItem52.Size = New System.Drawing.Size(112, 36)
        Me.LayoutControlItem52.Text = "Είσπραξη"
        Me.LayoutControlItem52.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem52.TextVisible = False
        '
        'LGenOffer
        '
        Me.LGenOffer.Control = Me.chkGenOffer
        Me.LGenOffer.Location = New System.Drawing.Point(780, 0)
        Me.LGenOffer.Name = "LGenOffer"
        Me.LGenOffer.Size = New System.Drawing.Size(235, 32)
        Me.LGenOffer.Text = "Γενική Προσφορά Εταιρίας"
        Me.LGenOffer.TextSize = New System.Drawing.Size(0, 0)
        Me.LGenOffer.TextVisible = False
        '
        'LayoutControlItem48
        '
        Me.LayoutControlItem48.Control = Me.cmdPrintOffer
        Me.LayoutControlItem48.Location = New System.Drawing.Point(0, 905)
        Me.LayoutControlItem48.Name = "LayoutControlItem48"
        Me.LayoutControlItem48.Size = New System.Drawing.Size(113, 36)
        Me.LayoutControlItem48.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem48.TextVisible = False
        '
        'EmptySpaceItem14
        '
        Me.EmptySpaceItem14.AllowHotTrack = False
        Me.EmptySpaceItem14.Location = New System.Drawing.Point(371, 905)
        Me.EmptySpaceItem14.Name = "EmptySpaceItem14"
        Me.EmptySpaceItem14.Size = New System.Drawing.Size(14, 36)
        Me.EmptySpaceItem14.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.chkVatVisible
        Me.LayoutControlItem5.Location = New System.Drawing.Point(113, 905)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(258, 36)
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem5.TextVisible = False
        '
        'LGroupOrderDetails2
        '
        Me.LGroupOrderDetails2.AppearanceGroup.BorderColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Primary
        Me.LGroupOrderDetails2.AppearanceGroup.Options.UseBorderColor = True
        Me.LGroupOrderDetails2.CustomizationFormText = "Στοιχεία Προσφοράς/Παραγγελίας"
        Me.LGroupOrderDetails2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem3, Me.LayoutControlItem14, Me.LayoutControlItem20})
        Me.LGroupOrderDetails2.Location = New System.Drawing.Point(0, 220)
        Me.LGroupOrderDetails2.Name = "LGroupOrderDetails2"
        Me.LGroupOrderDetails2.Size = New System.Drawing.Size(1262, 311)
        Me.LGroupOrderDetails2.Text = "Στοιχεία Προσφοράς/Παραγγελίας"
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.txtDescription
        Me.LayoutControlItem3.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem3.CustomizationFormText = "Περιγραφή"
        Me.LayoutControlItem3.HighlightFocusedItem = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(425, 255)
        Me.LayoutControlItem3.Text = "Περιγραφή"
        Me.LayoutControlItem3.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(201, 19)
        '
        'LayoutControlItem14
        '
        Me.LayoutControlItem14.Control = Me.txtComments
        Me.LayoutControlItem14.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem14.CustomizationFormText = "Σχόλια"
        Me.LayoutControlItem14.HighlightFocusedItem = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlItem14.Location = New System.Drawing.Point(425, 0)
        Me.LayoutControlItem14.Name = "LayoutControlItem14"
        Me.LayoutControlItem14.Size = New System.Drawing.Size(417, 255)
        Me.LayoutControlItem14.Text = "Σχόλια"
        Me.LayoutControlItem14.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem14.TextSize = New System.Drawing.Size(201, 19)
        '
        'LayoutControlItem20
        '
        Me.LayoutControlItem20.Control = Me.txtnotes
        Me.LayoutControlItem20.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem20.CustomizationFormText = "Παρατηρήσεις"
        Me.LayoutControlItem20.HighlightFocusedItem = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlItem20.Location = New System.Drawing.Point(842, 0)
        Me.LayoutControlItem20.Name = "LayoutControlItem20"
        Me.LayoutControlItem20.Size = New System.Drawing.Size(396, 255)
        Me.LayoutControlItem20.Text = "Παρατηρήσεις"
        Me.LayoutControlItem20.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem20.TextSize = New System.Drawing.Size(201, 19)
        '
        'LayoutControlGroup6
        '
        Me.LayoutControlGroup6.AppearanceGroup.BorderColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Danger
        Me.LayoutControlGroup6.AppearanceGroup.Options.UseBorderColor = True
        Me.LayoutControlGroup6.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.TabbedControlGroup1})
        Me.LayoutControlGroup6.Location = New System.Drawing.Point(0, 531)
        Me.LayoutControlGroup6.Name = "LayoutControlGroup6"
        Me.LayoutControlGroup6.Size = New System.Drawing.Size(1262, 163)
        Me.LayoutControlGroup6.Text = "Ανάλυση Μοντέλων"
        '
        'TabbedControlGroup1
        '
        Me.TabbedControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.TabbedControlGroup1.Name = "TabbedControlGroup1"
        Me.TabbedControlGroup1.SelectedTabPage = Me.LayoutControlGroup9
        Me.TabbedControlGroup1.Size = New System.Drawing.Size(1238, 107)
        Me.TabbedControlGroup1.TabPages.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlGroup9, Me.LayoutControlGroup3, Me.LayoutControlGroup4, Me.LayoutControlGroup5})
        '
        'LayoutControlGroup9
        '
        Me.LayoutControlGroup9.AppearanceGroup.BorderColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Danger
        Me.LayoutControlGroup9.AppearanceGroup.Options.UseBorderColor = True
        Me.LayoutControlGroup9.CustomizationFormText = "Μοντέλο 1"
        Me.LayoutControlGroup9.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem34, Me.Lcost3, Me.LayoutControlItem38, Me.LayoutControlItem42, Me.LayoutControlItem17, Me.LayoutControlItem21})
        Me.LayoutControlGroup9.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup9.Name = "LayoutControlGroup9"
        Me.LayoutControlGroup9.OptionsItemText.TextToControlDistance = 3
        Me.LayoutControlGroup9.Size = New System.Drawing.Size(1214, 50)
        Me.LayoutControlGroup9.Text = "Μοντέλο 1"
        Me.LayoutControlGroup9.TextLocation = DevExpress.Utils.Locations.[Default]
        '
        'LayoutControlItem34
        '
        Me.LayoutControlItem34.Control = Me.txtInitialPrice1
        Me.LayoutControlItem34.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem34.CustomizationFormText = "Αρχική Τιμή"
        Me.LayoutControlItem34.HighlightFocusedItem = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlItem34.Location = New System.Drawing.Point(651, 0)
        Me.LayoutControlItem34.Name = "LayoutControlItem34"
        Me.LayoutControlItem34.Size = New System.Drawing.Size(148, 50)
        Me.LayoutControlItem34.Text = "Αρχική Τιμή"
        Me.LayoutControlItem34.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
        Me.LayoutControlItem34.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem34.TextSize = New System.Drawing.Size(86, 19)
        Me.LayoutControlItem34.TextToControlDistance = 1
        '
        'Lcost3
        '
        Me.Lcost3.Control = Me.txtDisc1
        Me.Lcost3.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.Lcost3.CustomizationFormText = "Έκπτωση"
        Me.Lcost3.HighlightFocusedItem = DevExpress.Utils.DefaultBoolean.[True]
        Me.Lcost3.Location = New System.Drawing.Point(799, 0)
        Me.Lcost3.Name = "Lcost3"
        Me.Lcost3.Size = New System.Drawing.Size(128, 50)
        Me.Lcost3.Text = "Έκπτωση"
        Me.Lcost3.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
        Me.Lcost3.TextLocation = DevExpress.Utils.Locations.Top
        Me.Lcost3.TextSize = New System.Drawing.Size(66, 19)
        Me.Lcost3.TextToControlDistance = 1
        '
        'LayoutControlItem38
        '
        Me.LayoutControlItem38.Control = Me.txtDiscount1
        Me.LayoutControlItem38.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem38.CustomizationFormText = "Ποσό Έκπτωσης"
        Me.LayoutControlItem38.HighlightFocusedItem = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlItem38.Location = New System.Drawing.Point(927, 0)
        Me.LayoutControlItem38.Name = "LayoutControlItem38"
        Me.LayoutControlItem38.Size = New System.Drawing.Size(154, 50)
        Me.LayoutControlItem38.Text = "Ποσό Έκπτωσης"
        Me.LayoutControlItem38.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
        Me.LayoutControlItem38.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem38.TextSize = New System.Drawing.Size(117, 19)
        Me.LayoutControlItem38.TextToControlDistance = 1
        '
        'LayoutControlItem42
        '
        Me.LayoutControlItem42.Control = Me.txtFinalPrice1
        Me.LayoutControlItem42.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem42.CustomizationFormText = "Τελική Τιμή(ΦΠΑ)"
        Me.LayoutControlItem42.HighlightFocusedItem = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlItem42.Location = New System.Drawing.Point(1081, 0)
        Me.LayoutControlItem42.Name = "LayoutControlItem42"
        Me.LayoutControlItem42.Size = New System.Drawing.Size(133, 50)
        Me.LayoutControlItem42.Text = "Τελική Τιμή(ΦΠΑ)"
        Me.LayoutControlItem42.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
        Me.LayoutControlItem42.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem42.TextSize = New System.Drawing.Size(129, 19)
        Me.LayoutControlItem42.TextToControlDistance = 1
        '
        'LayoutControlItem17
        '
        Me.LayoutControlItem17.Control = Me.cboValueListItem
        Me.LayoutControlItem17.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem17.CustomizationFormText = "Κωδικός Υλικού"
        Me.LayoutControlItem17.HighlightFocusedItem = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlItem17.Location = New System.Drawing.Point(285, 0)
        Me.LayoutControlItem17.Name = "LayoutControlItem17"
        Me.LayoutControlItem17.Size = New System.Drawing.Size(366, 50)
        Me.LayoutControlItem17.Text = "Κωδικός Υλικού"
        Me.LayoutControlItem17.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
        Me.LayoutControlItem17.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem17.TextSize = New System.Drawing.Size(111, 19)
        Me.LayoutControlItem17.TextToControlDistance = 1
        '
        'LayoutControlItem21
        '
        Me.LayoutControlItem21.Control = Me.cboScpecialConstr1
        Me.LayoutControlItem21.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem21.CustomizationFormText = "Είδος Κατασκευής"
        Me.LayoutControlItem21.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem21.Name = "LayoutControlItem21"
        Me.LayoutControlItem21.Size = New System.Drawing.Size(285, 50)
        Me.LayoutControlItem21.Text = "Είδος Κατασκευής"
        Me.LayoutControlItem21.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
        Me.LayoutControlItem21.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem21.TextSize = New System.Drawing.Size(128, 19)
        Me.LayoutControlItem21.TextToControlDistance = 1
        '
        'LayoutControlGroup3
        '
        Me.LayoutControlGroup3.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem23, Me.LayoutControlItem18, Me.LayoutControlItem35, Me.Lcost1, Me.LayoutControlItem39, Me.LayoutControlItem43})
        Me.LayoutControlGroup3.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup3.Name = "LayoutControlGroup3"
        Me.LayoutControlGroup3.Size = New System.Drawing.Size(1214, 50)
        Me.LayoutControlGroup3.Text = "Μοντέλο 2"
        '
        'LayoutControlItem23
        '
        Me.LayoutControlItem23.Control = Me.cboScpecialConstr2
        Me.LayoutControlItem23.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem23.CustomizationFormText = "Είδος Κατασκευής"
        Me.LayoutControlItem23.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem23.Name = "LayoutControlItem23"
        Me.LayoutControlItem23.Size = New System.Drawing.Size(285, 50)
        Me.LayoutControlItem23.Text = "Είδος Κατασκευής"
        Me.LayoutControlItem23.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
        Me.LayoutControlItem23.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem23.TextSize = New System.Drawing.Size(128, 19)
        Me.LayoutControlItem23.TextToControlDistance = 1
        '
        'LayoutControlItem18
        '
        Me.LayoutControlItem18.Control = Me.cboVALUELISTITEM2
        Me.LayoutControlItem18.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem18.CustomizationFormText = "Κωδικός Υλικού"
        Me.LayoutControlItem18.HighlightFocusedItem = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlItem18.Location = New System.Drawing.Point(285, 0)
        Me.LayoutControlItem18.Name = "LayoutControlItem18"
        Me.LayoutControlItem18.Size = New System.Drawing.Size(366, 50)
        Me.LayoutControlItem18.Text = "Κωδικός Υλικού"
        Me.LayoutControlItem18.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
        Me.LayoutControlItem18.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem18.TextSize = New System.Drawing.Size(111, 19)
        Me.LayoutControlItem18.TextToControlDistance = 1
        '
        'LayoutControlItem35
        '
        Me.LayoutControlItem35.Control = Me.txtInitialPrice2
        Me.LayoutControlItem35.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem35.CustomizationFormText = "Αρχική Τιμή"
        Me.LayoutControlItem35.HighlightFocusedItem = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlItem35.Location = New System.Drawing.Point(651, 0)
        Me.LayoutControlItem35.Name = "LayoutControlItem35"
        Me.LayoutControlItem35.Size = New System.Drawing.Size(148, 50)
        Me.LayoutControlItem35.Text = "Αρχική Τιμή"
        Me.LayoutControlItem35.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
        Me.LayoutControlItem35.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem35.TextSize = New System.Drawing.Size(86, 19)
        Me.LayoutControlItem35.TextToControlDistance = 1
        '
        'Lcost1
        '
        Me.Lcost1.Control = Me.txtDisc2
        Me.Lcost1.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.Lcost1.CustomizationFormText = "Έκπτωση"
        Me.Lcost1.HighlightFocusedItem = DevExpress.Utils.DefaultBoolean.[True]
        Me.Lcost1.Location = New System.Drawing.Point(799, 0)
        Me.Lcost1.Name = "Lcost1"
        Me.Lcost1.Size = New System.Drawing.Size(128, 50)
        Me.Lcost1.Text = "Έκπτωση"
        Me.Lcost1.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
        Me.Lcost1.TextLocation = DevExpress.Utils.Locations.Top
        Me.Lcost1.TextSize = New System.Drawing.Size(66, 19)
        Me.Lcost1.TextToControlDistance = 1
        '
        'LayoutControlItem39
        '
        Me.LayoutControlItem39.Control = Me.txtDiscount2
        Me.LayoutControlItem39.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem39.CustomizationFormText = "Ποσό Έκπτωσης"
        Me.LayoutControlItem39.HighlightFocusedItem = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlItem39.Location = New System.Drawing.Point(927, 0)
        Me.LayoutControlItem39.Name = "LayoutControlItem39"
        Me.LayoutControlItem39.Size = New System.Drawing.Size(154, 50)
        Me.LayoutControlItem39.Text = "Ποσό Έκπτωσης"
        Me.LayoutControlItem39.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
        Me.LayoutControlItem39.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem39.TextSize = New System.Drawing.Size(117, 19)
        Me.LayoutControlItem39.TextToControlDistance = 1
        '
        'LayoutControlItem43
        '
        Me.LayoutControlItem43.Control = Me.txtFinalPrice2
        Me.LayoutControlItem43.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem43.CustomizationFormText = "Τελική Τιμή(ΦΠΑ)"
        Me.LayoutControlItem43.HighlightFocusedItem = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlItem43.Location = New System.Drawing.Point(1081, 0)
        Me.LayoutControlItem43.Name = "LayoutControlItem43"
        Me.LayoutControlItem43.Size = New System.Drawing.Size(133, 50)
        Me.LayoutControlItem43.Text = "Τελική Τιμή(ΦΠΑ)"
        Me.LayoutControlItem43.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
        Me.LayoutControlItem43.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem43.TextSize = New System.Drawing.Size(129, 19)
        Me.LayoutControlItem43.TextToControlDistance = 1
        '
        'LayoutControlGroup4
        '
        Me.LayoutControlGroup4.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem22, Me.LayoutControlItem19, Me.LayoutControlItem36, Me.Lcost2, Me.LayoutControlItem40, Me.LayoutControlItem44})
        Me.LayoutControlGroup4.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup4.Name = "LayoutControlGroup4"
        Me.LayoutControlGroup4.Size = New System.Drawing.Size(1214, 50)
        Me.LayoutControlGroup4.Text = "Μοντέλο 3"
        '
        'LayoutControlItem22
        '
        Me.LayoutControlItem22.Control = Me.cboScpecialConstr3
        Me.LayoutControlItem22.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem22.CustomizationFormText = "Είδος Κατασκευής"
        Me.LayoutControlItem22.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem22.Name = "LayoutControlItem22"
        Me.LayoutControlItem22.Size = New System.Drawing.Size(285, 50)
        Me.LayoutControlItem22.Text = "Είδος Κατασκευής"
        Me.LayoutControlItem22.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
        Me.LayoutControlItem22.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem22.TextSize = New System.Drawing.Size(128, 19)
        Me.LayoutControlItem22.TextToControlDistance = 1
        '
        'LayoutControlItem19
        '
        Me.LayoutControlItem19.Control = Me.cboVALUELISTITEM3
        Me.LayoutControlItem19.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem19.CustomizationFormText = "Κωδικός Υλικού"
        Me.LayoutControlItem19.HighlightFocusedItem = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlItem19.Location = New System.Drawing.Point(285, 0)
        Me.LayoutControlItem19.Name = "LayoutControlItem19"
        Me.LayoutControlItem19.Size = New System.Drawing.Size(366, 50)
        Me.LayoutControlItem19.Text = "Κωδικός Υλικού"
        Me.LayoutControlItem19.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
        Me.LayoutControlItem19.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem19.TextSize = New System.Drawing.Size(111, 19)
        Me.LayoutControlItem19.TextToControlDistance = 1
        '
        'LayoutControlItem36
        '
        Me.LayoutControlItem36.Control = Me.txtInitialPrice3
        Me.LayoutControlItem36.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem36.CustomizationFormText = "Αρχική Τιμή"
        Me.LayoutControlItem36.HighlightFocusedItem = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlItem36.Location = New System.Drawing.Point(651, 0)
        Me.LayoutControlItem36.Name = "LayoutControlItem36"
        Me.LayoutControlItem36.Size = New System.Drawing.Size(148, 50)
        Me.LayoutControlItem36.Text = "Αρχική Τιμή"
        Me.LayoutControlItem36.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
        Me.LayoutControlItem36.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem36.TextSize = New System.Drawing.Size(86, 19)
        Me.LayoutControlItem36.TextToControlDistance = 1
        '
        'Lcost2
        '
        Me.Lcost2.Control = Me.txtDisc3
        Me.Lcost2.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.Lcost2.CustomizationFormText = "Έκπτωση"
        Me.Lcost2.HighlightFocusedItem = DevExpress.Utils.DefaultBoolean.[True]
        Me.Lcost2.Location = New System.Drawing.Point(799, 0)
        Me.Lcost2.Name = "Lcost2"
        Me.Lcost2.Size = New System.Drawing.Size(128, 50)
        Me.Lcost2.Text = "Έκπτωση"
        Me.Lcost2.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
        Me.Lcost2.TextLocation = DevExpress.Utils.Locations.Top
        Me.Lcost2.TextSize = New System.Drawing.Size(66, 19)
        Me.Lcost2.TextToControlDistance = 1
        '
        'LayoutControlItem40
        '
        Me.LayoutControlItem40.Control = Me.txtDiscount3
        Me.LayoutControlItem40.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem40.CustomizationFormText = "Ποσό Έκπτωσης"
        Me.LayoutControlItem40.HighlightFocusedItem = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlItem40.Location = New System.Drawing.Point(927, 0)
        Me.LayoutControlItem40.Name = "LayoutControlItem40"
        Me.LayoutControlItem40.Size = New System.Drawing.Size(154, 50)
        Me.LayoutControlItem40.Text = "Ποσό Έκπτωσης"
        Me.LayoutControlItem40.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
        Me.LayoutControlItem40.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem40.TextSize = New System.Drawing.Size(117, 19)
        Me.LayoutControlItem40.TextToControlDistance = 1
        '
        'LayoutControlItem44
        '
        Me.LayoutControlItem44.Control = Me.txtFinalPrice3
        Me.LayoutControlItem44.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem44.CustomizationFormText = "Τελική Τιμή(ΦΠΑ)"
        Me.LayoutControlItem44.HighlightFocusedItem = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlItem44.Location = New System.Drawing.Point(1081, 0)
        Me.LayoutControlItem44.Name = "LayoutControlItem44"
        Me.LayoutControlItem44.Size = New System.Drawing.Size(133, 50)
        Me.LayoutControlItem44.Text = "Τελική Τιμή(ΦΠΑ)"
        Me.LayoutControlItem44.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
        Me.LayoutControlItem44.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem44.TextSize = New System.Drawing.Size(129, 19)
        Me.LayoutControlItem44.TextToControlDistance = 1
        '
        'LayoutControlGroup5
        '
        Me.LayoutControlGroup5.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem24, Me.LayoutControlItem63, Me.LayoutControlItem37, Me.Lcost4, Me.LayoutControlItem41, Me.LayoutControlItem45})
        Me.LayoutControlGroup5.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup5.Name = "LayoutControlGroup5"
        Me.LayoutControlGroup5.Size = New System.Drawing.Size(1214, 50)
        Me.LayoutControlGroup5.Text = "Μοντέλο 4"
        '
        'LayoutControlItem24
        '
        Me.LayoutControlItem24.Control = Me.cboScpecialConstr4
        Me.LayoutControlItem24.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem24.CustomizationFormText = "Είδος Κατασκευής"
        Me.LayoutControlItem24.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem24.Name = "LayoutControlItem24"
        Me.LayoutControlItem24.Size = New System.Drawing.Size(285, 50)
        Me.LayoutControlItem24.Text = "Είδος Κατασκευής"
        Me.LayoutControlItem24.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
        Me.LayoutControlItem24.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem24.TextSize = New System.Drawing.Size(128, 19)
        Me.LayoutControlItem24.TextToControlDistance = 1
        '
        'LayoutControlItem63
        '
        Me.LayoutControlItem63.Control = Me.cboVALUELISTITEM4
        Me.LayoutControlItem63.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem63.CustomizationFormText = "Κωδικός Υλικού"
        Me.LayoutControlItem63.HighlightFocusedItem = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlItem63.Location = New System.Drawing.Point(285, 0)
        Me.LayoutControlItem63.Name = "LayoutControlItem63"
        Me.LayoutControlItem63.Size = New System.Drawing.Size(366, 50)
        Me.LayoutControlItem63.Text = "Κωδικός Υλικού"
        Me.LayoutControlItem63.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
        Me.LayoutControlItem63.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem63.TextSize = New System.Drawing.Size(111, 19)
        Me.LayoutControlItem63.TextToControlDistance = 1
        '
        'LayoutControlItem37
        '
        Me.LayoutControlItem37.Control = Me.txtInitialPrice4
        Me.LayoutControlItem37.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem37.CustomizationFormText = "Αρχική Τιμή"
        Me.LayoutControlItem37.HighlightFocusedItem = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlItem37.Location = New System.Drawing.Point(651, 0)
        Me.LayoutControlItem37.Name = "LayoutControlItem37"
        Me.LayoutControlItem37.Size = New System.Drawing.Size(148, 50)
        Me.LayoutControlItem37.Text = "Αρχική Τιμή"
        Me.LayoutControlItem37.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
        Me.LayoutControlItem37.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem37.TextSize = New System.Drawing.Size(86, 19)
        Me.LayoutControlItem37.TextToControlDistance = 1
        '
        'Lcost4
        '
        Me.Lcost4.Control = Me.txtDisc4
        Me.Lcost4.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.Lcost4.CustomizationFormText = "Έκπτωση"
        Me.Lcost4.HighlightFocusedItem = DevExpress.Utils.DefaultBoolean.[True]
        Me.Lcost4.Location = New System.Drawing.Point(799, 0)
        Me.Lcost4.Name = "Lcost4"
        Me.Lcost4.Size = New System.Drawing.Size(128, 50)
        Me.Lcost4.Text = "Έκπτωση"
        Me.Lcost4.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
        Me.Lcost4.TextLocation = DevExpress.Utils.Locations.Top
        Me.Lcost4.TextSize = New System.Drawing.Size(66, 19)
        Me.Lcost4.TextToControlDistance = 1
        '
        'LayoutControlItem41
        '
        Me.LayoutControlItem41.Control = Me.txtDiscount4
        Me.LayoutControlItem41.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem41.CustomizationFormText = "Ποσό Έκπτωσης"
        Me.LayoutControlItem41.HighlightFocusedItem = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlItem41.Location = New System.Drawing.Point(927, 0)
        Me.LayoutControlItem41.Name = "LayoutControlItem41"
        Me.LayoutControlItem41.Size = New System.Drawing.Size(154, 50)
        Me.LayoutControlItem41.Text = "Ποσό Έκπτωσης"
        Me.LayoutControlItem41.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
        Me.LayoutControlItem41.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem41.TextSize = New System.Drawing.Size(117, 19)
        Me.LayoutControlItem41.TextToControlDistance = 1
        '
        'LayoutControlItem45
        '
        Me.LayoutControlItem45.Control = Me.txtFinalPrice4
        Me.LayoutControlItem45.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem45.CustomizationFormText = "Τελική Τιμή(ΦΠΑ)"
        Me.LayoutControlItem45.HighlightFocusedItem = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlItem45.Location = New System.Drawing.Point(1081, 0)
        Me.LayoutControlItem45.Name = "LayoutControlItem45"
        Me.LayoutControlItem45.Size = New System.Drawing.Size(133, 50)
        Me.LayoutControlItem45.Text = "Τελική Τιμή(ΦΠΑ)"
        Me.LayoutControlItem45.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
        Me.LayoutControlItem45.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem45.TextSize = New System.Drawing.Size(129, 19)
        Me.LayoutControlItem45.TextToControlDistance = 1
        '
        'LCost
        '
        Me.LCost.AppearanceGroup.BorderColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Success
        Me.LCost.AppearanceGroup.Options.UseBorderColor = True
        Me.LCost.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LPartofVat, Me.LTotalSpecialVat, Me.LTotalSpecialPrice, Me.EmptySpaceItem2, Me.LExtraTransp, Me.LExtraInst, Me.EmptySpaceItem4})
        Me.LCost.Location = New System.Drawing.Point(0, 694)
        Me.LCost.Name = "LCost"
        Me.LCost.Size = New System.Drawing.Size(1262, 154)
        Me.LCost.Text = "Κοστολόγιο"
        '
        'LPartofVat
        '
        Me.LPartofVat.Control = Me.txtPartofVat
        Me.LPartofVat.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LPartofVat.CustomizationFormText = "Συμφωνηθέν ΦΠΑ"
        Me.LPartofVat.HighlightFocusedItem = DevExpress.Utils.DefaultBoolean.[True]
        Me.LPartofVat.Location = New System.Drawing.Point(891, 0)
        Me.LPartofVat.Name = "LPartofVat"
        Me.LPartofVat.Size = New System.Drawing.Size(347, 34)
        Me.LPartofVat.Text = "Συμφωνηθέν ΦΠΑ"
        Me.LPartofVat.TextSize = New System.Drawing.Size(201, 19)
        Me.LPartofVat.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        '
        'LTotalSpecialVat
        '
        Me.LTotalSpecialVat.Control = Me.txtTotalSpecialVat
        Me.LTotalSpecialVat.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LTotalSpecialVat.CustomizationFormText = "Συνολική Αξία προ Φ.Π.Α"
        Me.LTotalSpecialVat.HighlightFocusedItem = DevExpress.Utils.DefaultBoolean.[True]
        Me.LTotalSpecialVat.Location = New System.Drawing.Point(891, 34)
        Me.LTotalSpecialVat.Name = "LTotalSpecialVat"
        Me.LTotalSpecialVat.Size = New System.Drawing.Size(347, 30)
        Me.LTotalSpecialVat.Text = "Συνολική Αξία προ Φ.Π.Α"
        Me.LTotalSpecialVat.TextSize = New System.Drawing.Size(201, 19)
        '
        'LTotalSpecialPrice
        '
        Me.LTotalSpecialPrice.Control = Me.txtTotalSpecialPrice
        Me.LTotalSpecialPrice.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LTotalSpecialPrice.CustomizationFormText = "Συνολική Αξία με Φ.Π.Α"
        Me.LTotalSpecialPrice.HighlightFocusedItem = DevExpress.Utils.DefaultBoolean.[True]
        Me.LTotalSpecialPrice.Location = New System.Drawing.Point(891, 64)
        Me.LTotalSpecialPrice.Name = "LTotalSpecialPrice"
        Me.LTotalSpecialPrice.Size = New System.Drawing.Size(347, 34)
        Me.LTotalSpecialPrice.Text = "Συνολική Αξία με Φ.Π.Α"
        Me.LTotalSpecialPrice.TextSize = New System.Drawing.Size(201, 19)
        '
        'EmptySpaceItem2
        '
        Me.EmptySpaceItem2.AllowHotTrack = False
        Me.EmptySpaceItem2.Location = New System.Drawing.Point(0, 0)
        Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Size = New System.Drawing.Size(579, 98)
        Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
        '
        'LExtraTransp
        '
        Me.LExtraTransp.Control = Me.txtExtraTransp
        Me.LExtraTransp.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LExtraTransp.CustomizationFormText = "Μεταφορά(Εκτός Αττικής)"
        Me.LExtraTransp.HighlightFocusedItem = DevExpress.Utils.DefaultBoolean.[True]
        Me.LExtraTransp.Location = New System.Drawing.Point(579, 0)
        Me.LExtraTransp.Name = "LExtraTransp"
        Me.LExtraTransp.Size = New System.Drawing.Size(312, 34)
        Me.LExtraTransp.Text = "Μεταφορά(Εκτός Αττικής)"
        Me.LExtraTransp.TextSize = New System.Drawing.Size(201, 19)
        Me.LExtraTransp.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        '
        'LExtraInst
        '
        Me.LExtraInst.Control = Me.txtExtraInst
        Me.LExtraInst.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LExtraInst.CustomizationFormText = "Τοποθέτηση(Εκτός Αττικής)"
        Me.LExtraInst.HighlightFocusedItem = DevExpress.Utils.DefaultBoolean.[True]
        Me.LExtraInst.Location = New System.Drawing.Point(579, 34)
        Me.LExtraInst.Name = "LExtraInst"
        Me.LExtraInst.Size = New System.Drawing.Size(312, 30)
        Me.LExtraInst.Text = "Τοποθέτηση(Εκτός Αττικής)"
        Me.LExtraInst.TextSize = New System.Drawing.Size(201, 19)
        Me.LExtraInst.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        '
        'EmptySpaceItem4
        '
        Me.EmptySpaceItem4.AllowHotTrack = False
        Me.EmptySpaceItem4.Location = New System.Drawing.Point(579, 64)
        Me.EmptySpaceItem4.Name = "EmptySpaceItem4"
        Me.EmptySpaceItem4.Size = New System.Drawing.Size(312, 34)
        Me.EmptySpaceItem4.TextSize = New System.Drawing.Size(0, 0)
        '
        'LConvertToOrder
        '
        Me.LConvertToOrder.Control = Me.cmdConvertToOrder
        Me.LConvertToOrder.Location = New System.Drawing.Point(805, 905)
        Me.LConvertToOrder.Name = "LConvertToOrder"
        Me.LConvertToOrder.Size = New System.Drawing.Size(228, 36)
        Me.LConvertToOrder.Text = "Μετατροπή σε Παραγγελία"
        Me.LConvertToOrder.TextSize = New System.Drawing.Size(0, 0)
        Me.LConvertToOrder.TextVisible = False
        '
        'LPrivateAgreement
        '
        Me.LPrivateAgreement.Control = Me.cmdPrivateAgreement
        Me.LPrivateAgreement.Location = New System.Drawing.Point(643, 905)
        Me.LPrivateAgreement.Name = "LPrivateAgreement"
        Me.LPrivateAgreement.Size = New System.Drawing.Size(162, 36)
        Me.LPrivateAgreement.Text = "Ιδ. Συμφωνητικό"
        Me.LPrivateAgreement.TextSize = New System.Drawing.Size(0, 0)
        Me.LPrivateAgreement.TextVisible = False
        '
        'LOrder
        '
        Me.LOrder.Control = Me.cmdOrder
        Me.LOrder.Location = New System.Drawing.Point(521, 905)
        Me.LOrder.Name = "LOrder"
        Me.LOrder.Size = New System.Drawing.Size(122, 36)
        Me.LOrder.Text = "Παραγγελία"
        Me.LOrder.TextSize = New System.Drawing.Size(0, 0)
        Me.LOrder.TextVisible = False
        '
        'LNewRecord
        '
        Me.LNewRecord.Control = Me.cmdNewRecord
        Me.LNewRecord.Location = New System.Drawing.Point(385, 905)
        Me.LNewRecord.Name = "LNewRecord"
        Me.LNewRecord.Size = New System.Drawing.Size(136, 36)
        Me.LNewRecord.Text = "Νέα Εγγραφή"
        Me.LNewRecord.TextSize = New System.Drawing.Size(0, 0)
        Me.LNewRecord.TextVisible = False
        '
        'LayoutControlItem125
        '
        Me.LayoutControlItem125.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.LayoutControlItem125.AppearanceItemCaption.Options.UseFont = True
        Me.LayoutControlItem125.Control = Me.txtTotAmt
        Me.LayoutControlItem125.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem125.CustomizationFormText = "Γενικό Σύνολο Πώλησης"
        Me.LayoutControlItem125.HighlightFocusedItem = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlItem125.Location = New System.Drawing.Point(901, 848)
        Me.LayoutControlItem125.Name = "LayoutControlItem125"
        Me.LayoutControlItem125.Size = New System.Drawing.Size(361, 34)
        Me.LayoutControlItem125.Text = "Γενικό Σύνολο Πώλησης"
        Me.LayoutControlItem125.TextSize = New System.Drawing.Size(201, 19)
        '
        'LayoutControlItem54
        '
        Me.LayoutControlItem54.Control = Me.LblMsg
        Me.LayoutControlItem54.Location = New System.Drawing.Point(0, 882)
        Me.LayoutControlItem54.Name = "LayoutControlItem54"
        Me.LayoutControlItem54.Size = New System.Drawing.Size(1262, 23)
        Me.LayoutControlItem54.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem54.TextVisible = False
        '
        'EmptySpaceItem3
        '
        Me.EmptySpaceItem3.AllowHotTrack = False
        Me.EmptySpaceItem3.Location = New System.Drawing.Point(0, 848)
        Me.EmptySpaceItem3.Name = "EmptySpaceItem3"
        Me.EmptySpaceItem3.Size = New System.Drawing.Size(901, 34)
        Me.EmptySpaceItem3.TextSize = New System.Drawing.Size(0, 0)
        '
        'TabNavigationPage2
        '
        Me.TabNavigationPage2.Caption = "TabNavigationPage2"
        Me.TabNavigationPage2.Controls.Add(Me.LayoutControl3)
        Me.TabNavigationPage2.Margin = New System.Windows.Forms.Padding(4)
        Me.TabNavigationPage2.Name = "TabNavigationPage2"
        Me.TabNavigationPage2.PageText = "ΦΩΤΟΓΡΑΦΙΕΣ ΧΡΩΜΑΤΩΝ"
        Me.TabNavigationPage2.Size = New System.Drawing.Size(1282, 961)
        '
        'LayoutControl3
        '
        Me.LayoutControl3.Controls.Add(Me.cmdPrintPhotos)
        Me.LayoutControl3.Controls.Add(Me.cmdSavePhotos)
        Me.LayoutControl3.Controls.Add(Me.GridControl1)
        Me.LayoutControl3.Controls.Add(Me.cboPhotoValueListItem)
        Me.LayoutControl3.Controls.Add(Me.cboSUP1)
        Me.LayoutControl3.Controls.Add(Me.cboColorsCat)
        Me.LayoutControl3.Controls.Add(Me.PictureEdit2)
        Me.LayoutControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl3.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl3.Margin = New System.Windows.Forms.Padding(4)
        Me.LayoutControl3.Name = "LayoutControl3"
        Me.LayoutControl3.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(1970, 1031, 1137, 700)
        Me.LayoutControl3.Root = Me.LayoutControlGroup14
        Me.LayoutControl3.Size = New System.Drawing.Size(1282, 961)
        Me.LayoutControl3.TabIndex = 3
        Me.LayoutControl3.Text = "LayoutControl3"
        '
        'cmdPrintPhotos
        '
        Me.cmdPrintPhotos.Location = New System.Drawing.Point(12, 323)
        Me.cmdPrintPhotos.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.cmdPrintPhotos.Name = "cmdPrintPhotos"
        Me.cmdPrintPhotos.Size = New System.Drawing.Size(215, 32)
        Me.cmdPrintPhotos.StyleController = Me.LayoutControl3
        Me.cmdPrintPhotos.TabIndex = 57
        Me.cmdPrintPhotos.Text = "Εκτύπωση"
        '
        'cmdSavePhotos
        '
        Me.cmdSavePhotos.ImageOptions.Image = Global.DreamyKitchenCRM.My.Resources.Resources.icons8_save_close_24
        Me.cmdSavePhotos.Location = New System.Drawing.Point(1093, 323)
        Me.cmdSavePhotos.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.cmdSavePhotos.Name = "cmdSavePhotos"
        Me.cmdSavePhotos.Size = New System.Drawing.Size(177, 32)
        Me.cmdSavePhotos.StyleController = Me.LayoutControl3
        Me.cmdSavePhotos.TabIndex = 52
        Me.cmdSavePhotos.Text = "Αποθήκευση"
        '
        'GridControl1
        '
        Me.GridControl1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridControl1.DataSource = Me.VwCCTORDERSPHOTOSBindingSource
        Me.GridControl1.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(6)
        Me.GridControl1.Location = New System.Drawing.Point(12, 359)
        Me.GridControl1.MainView = Me.CardView1
        Me.GridControl1.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemColorCat, Me.RepositoryItemValueListiItem, Me.RepositoryItemSup, Me.RepositoryItemPhoto})
        Me.GridControl1.Size = New System.Drawing.Size(1258, 590)
        Me.GridControl1.TabIndex = 51
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.CardView1})
        '
        'VwCCTORDERSPHOTOSBindingSource
        '
        Me.VwCCTORDERSPHOTOSBindingSource.DataMember = "vw_CCT_ORDERS_PHOTOS"
        Me.VwCCTORDERSPHOTOSBindingSource.DataSource = Me.DM_CCT
        '
        'CardView1
        '
        Me.CardView1.CardCaptionFormat = "{ColorsCatName}"
        Me.CardView1.CardWidth = 799
        Me.CardView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colcolorCatID1, Me.colColorsCatName, Me.colsupID1, Me.colSupFullName, Me.colvalueListItemID1, Me.colValueListItemName, Me.colphoto, Me.colID1, Me.colvalueListItemID, Me.colCustomCode, Me.colcreatedOn, Me.colcreatedBy, Me.colcolorCatID, Me.colmodifiedBy, Me.colmodifiedOn, Me.colsite, Me.colsupID})
        Me.CardView1.DetailHeight = 506
        GridFormatRule1.ApplyToRow = True
        GridFormatRule1.Name = "Format0"
        FormatConditionRuleExpression1.Appearance.BackColor = System.Drawing.Color.White
        FormatConditionRuleExpression1.Appearance.Options.UseBackColor = True
        FormatConditionRuleExpression1.Expression = "IsNullOrEmpty([dCode]) And [checked] = True"
        FormatConditionRuleExpression1.PredefinedName = "Red Text"
        GridFormatRule1.Rule = FormatConditionRuleExpression1
        Me.CardView1.FormatRules.Add(GridFormatRule1)
        Me.CardView1.GridControl = Me.GridControl1
        Me.CardView1.Name = "CardView1"
        Me.CardView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.CardView1.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[True]
        Me.CardView1.OptionsBehavior.FieldAutoHeight = True
        Me.CardView1.OptionsSelection.MultiSelect = True
        Me.CardView1.OptionsView.ShowViewCaption = True
        Me.CardView1.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.[Auto]
        '
        'colcolorCatID1
        '
        Me.colcolorCatID1.Caption = "Κατηγορία"
        Me.colcolorCatID1.ColumnEdit = Me.RepositoryItemColorCat
        Me.colcolorCatID1.FieldName = "colorCatID"
        Me.colcolorCatID1.MinWidth = 54
        Me.colcolorCatID1.Name = "colcolorCatID1"
        Me.colcolorCatID1.Visible = True
        Me.colcolorCatID1.VisibleIndex = 1
        Me.colcolorCatID1.Width = 205
        '
        'RepositoryItemColorCat
        '
        Me.RepositoryItemColorCat.AutoHeight = False
        Me.RepositoryItemColorCat.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemColorCat.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 54, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("code", "code", 85, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("name", "Κατηγορία", 97, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("modifiedBy", "modified By", 177, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("modifiedOn", "modified On", 184, DevExpress.Utils.FormatType.DateTime, "d/M/yyyy", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("createdOn", "created On", 169, DevExpress.Utils.FormatType.DateTime, "d/M/yyyy", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("createdBy", "created By", 163, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("RealName", "Real Name", 168, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default])})
        Me.RepositoryItemColorCat.DisplayMember = "name"
        Me.RepositoryItemColorCat.Name = "RepositoryItemColorCat"
        Me.RepositoryItemColorCat.NullText = ""
        Me.RepositoryItemColorCat.ValueMember = "ID"
        '
        'colColorsCatName
        '
        Me.colColorsCatName.Caption = "Κατηγορία"
        Me.colColorsCatName.FieldName = "ColorsCatName"
        Me.colColorsCatName.MinWidth = 54
        Me.colColorsCatName.Name = "colColorsCatName"
        Me.colColorsCatName.Width = 205
        '
        'colsupID1
        '
        Me.colsupID1.Caption = "Προμηθευτής"
        Me.colsupID1.ColumnEdit = Me.RepositoryItemSup
        Me.colsupID1.FieldName = "supID"
        Me.colsupID1.MinWidth = 54
        Me.colsupID1.Name = "colsupID1"
        Me.colsupID1.Visible = True
        Me.colsupID1.VisibleIndex = 2
        Me.colsupID1.Width = 205
        '
        'RepositoryItemSup
        '
        Me.RepositoryItemSup.AutoHeight = False
        Me.RepositoryItemSup.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemSup.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 54, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("code", "code", 85, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Fullname", "Επωνυμία", 142, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ttl", "ttl", 48, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("bal", "bal", 63, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("email", "email", 93, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("site", "site", 67, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default])})
        Me.RepositoryItemSup.DisplayMember = "Fullname"
        Me.RepositoryItemSup.Name = "RepositoryItemSup"
        Me.RepositoryItemSup.NullText = ""
        Me.RepositoryItemSup.ValueMember = "ID"
        '
        'colSupFullName
        '
        Me.colSupFullName.Caption = "Προμηθευτής"
        Me.colSupFullName.FieldName = "SupFullName"
        Me.colSupFullName.MinWidth = 54
        Me.colSupFullName.Name = "colSupFullName"
        Me.colSupFullName.Width = 205
        '
        'colvalueListItemID1
        '
        Me.colvalueListItemID1.Caption = "Κωδικός Χρώματος"
        Me.colvalueListItemID1.ColumnEdit = Me.RepositoryItemValueListiItem
        Me.colvalueListItemID1.FieldName = "valueListItemID"
        Me.colvalueListItemID1.MinWidth = 54
        Me.colvalueListItemID1.Name = "colvalueListItemID1"
        Me.colvalueListItemID1.Visible = True
        Me.colvalueListItemID1.VisibleIndex = 3
        Me.colvalueListItemID1.Width = 205
        '
        'RepositoryItemValueListiItem
        '
        Me.RepositoryItemValueListiItem.AutoHeight = False
        Me.RepositoryItemValueListiItem.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemValueListiItem.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Modifier", "Modifier", 129, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 54, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("code", "code", 85, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CustomCode", "Κωδικός", 196, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("name", "Χρώματα", 97, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("cat", "cat", 63, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("color", "color", 85, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Price", "Price", 85, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("comments", "comments", 159, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("modifiedBy", "modified By", 177, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("modifiedOn", "modified On", 184, DevExpress.Utils.FormatType.DateTime, "d/M/yyyy", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("createdOn", "created On", 169, DevExpress.Utils.FormatType.DateTime, "d/M/yyyy", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("createdBy", "created By", 163, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("doorColorID", "door Color ID", 201, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ColorName", "Color Name", 175, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("typeDescr", "type Descr", 163, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("type", "type", 79, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("valueListItem", "value List Item", 216, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("kasa", "kasa", 82, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("dimName", "dim Name", 159, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("dimID", "dim ID", 112, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("valueListID", "value List ID", 186, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("valueListName", "value List Name", 231, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("closetType", "closet Type", 172, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("description", "description", 168, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("doorType", "door Type", 157, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default])})
        Me.RepositoryItemValueListiItem.DataSource = Me.VwVALUELISTITEMV2BindingSource
        Me.RepositoryItemValueListiItem.DisplayMember = "name"
        Me.RepositoryItemValueListiItem.Name = "RepositoryItemValueListiItem"
        Me.RepositoryItemValueListiItem.NullText = ""
        Me.RepositoryItemValueListiItem.ValueMember = "ID"
        '
        'colValueListItemName
        '
        Me.colValueListItemName.Caption = "Κωδικός Χρώματος"
        Me.colValueListItemName.FieldName = "ValueListItemName"
        Me.colValueListItemName.MinWidth = 54
        Me.colValueListItemName.Name = "colValueListItemName"
        Me.colValueListItemName.Width = 205
        '
        'colphoto
        '
        Me.colphoto.Caption = "Φωτογραφία"
        Me.colphoto.FieldName = "photo"
        Me.colphoto.MinWidth = 54
        Me.colphoto.Name = "colphoto"
        Me.colphoto.Visible = True
        Me.colphoto.VisibleIndex = 0
        Me.colphoto.Width = 237
        '
        'colID1
        '
        Me.colID1.FieldName = "ID"
        Me.colID1.MinWidth = 54
        Me.colID1.Name = "colID1"
        Me.colID1.Width = 205
        '
        'colvalueListItemID
        '
        Me.colvalueListItemID.FieldName = "valueListItemID"
        Me.colvalueListItemID.MinWidth = 54
        Me.colvalueListItemID.Name = "colvalueListItemID"
        Me.colvalueListItemID.Width = 205
        '
        'colCustomCode
        '
        Me.colCustomCode.FieldName = "CustomCode"
        Me.colCustomCode.MinWidth = 54
        Me.colCustomCode.Name = "colCustomCode"
        Me.colCustomCode.Width = 205
        '
        'colcreatedOn
        '
        Me.colcreatedOn.FieldName = "createdOn"
        Me.colcreatedOn.MinWidth = 54
        Me.colcreatedOn.Name = "colcreatedOn"
        Me.colcreatedOn.Width = 205
        '
        'colcreatedBy
        '
        Me.colcreatedBy.FieldName = "createdBy"
        Me.colcreatedBy.MinWidth = 54
        Me.colcreatedBy.Name = "colcreatedBy"
        Me.colcreatedBy.Width = 205
        '
        'colcolorCatID
        '
        Me.colcolorCatID.FieldName = "colorCatID"
        Me.colcolorCatID.MinWidth = 54
        Me.colcolorCatID.Name = "colcolorCatID"
        Me.colcolorCatID.Width = 205
        '
        'colmodifiedBy
        '
        Me.colmodifiedBy.FieldName = "modifiedBy"
        Me.colmodifiedBy.MinWidth = 54
        Me.colmodifiedBy.Name = "colmodifiedBy"
        Me.colmodifiedBy.Width = 205
        '
        'colmodifiedOn
        '
        Me.colmodifiedOn.FieldName = "modifiedOn"
        Me.colmodifiedOn.MinWidth = 54
        Me.colmodifiedOn.Name = "colmodifiedOn"
        Me.colmodifiedOn.Width = 205
        '
        'colsite
        '
        Me.colsite.FieldName = "site"
        Me.colsite.MinWidth = 54
        Me.colsite.Name = "colsite"
        Me.colsite.Width = 205
        '
        'colsupID
        '
        Me.colsupID.FieldName = "supID"
        Me.colsupID.MinWidth = 54
        Me.colsupID.Name = "colsupID"
        Me.colsupID.Width = 205
        '
        'RepositoryItemPhoto
        '
        Me.RepositoryItemPhoto.Name = "RepositoryItemPhoto"
        Me.RepositoryItemPhoto.PictureStoreMode = DevExpress.XtraEditors.Controls.PictureStoreMode.Image
        '
        'cboPhotoValueListItem
        '
        Me.cboPhotoValueListItem.Location = New System.Drawing.Point(160, 80)
        Me.cboPhotoValueListItem.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.cboPhotoValueListItem.Name = "cboPhotoValueListItem"
        Me.cboPhotoValueListItem.Properties.AllowMouseWheel = False
        Me.cboPhotoValueListItem.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.cboPhotoValueListItem.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Search), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Clear)})
        Me.cboPhotoValueListItem.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Modifier", "Modifier", 129, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 54, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("code", "code", 85, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CustomCode", "Κωδικός", 196, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("name", "Χρώμα", 97, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("cat", "cat", 63, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("color", "color", 85, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Price", "Price", 85, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("comments", "comments", 159, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("modifiedBy", "modified By", 177, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("modifiedOn", "modified On", 184, DevExpress.Utils.FormatType.DateTime, "d/M/yyyy", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("createdOn", "created On", 169, DevExpress.Utils.FormatType.DateTime, "d/M/yyyy", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("createdBy", "created By", 163, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("doorColorID", "door Color ID", 201, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ColorName", "Color Name", 175, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("typeDescr", "type Descr", 163, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("type", "type", 79, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("valueListItem", "value List Item", 216, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("kasa", "kasa", 82, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("dimName", "dim Name", 159, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("dimID", "dim ID", 112, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("valueListID", "value List ID", 186, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("valueListName", "value List Name", 231, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("closetType", "closet Type", 172, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("description", "description", 168, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("doorType", "door Type", 157, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default])})
        Me.cboPhotoValueListItem.Properties.DataSource = Me.VwVALUELISTITEMV2BindingSource
        Me.cboPhotoValueListItem.Properties.DisplayMember = "name"
        Me.cboPhotoValueListItem.Properties.NullText = ""
        Me.cboPhotoValueListItem.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.cboPhotoValueListItem.Properties.PopupFormMinSize = New System.Drawing.Size(945, 434)
        Me.cboPhotoValueListItem.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoSuggest
        Me.cboPhotoValueListItem.Properties.ValueMember = "ID"
        Me.cboPhotoValueListItem.Size = New System.Drawing.Size(1110, 26)
        Me.cboPhotoValueListItem.StyleController = Me.LayoutControl3
        Me.cboPhotoValueListItem.TabIndex = 50
        Me.cboPhotoValueListItem.Tag = "valueListItemID,0,1,2"
        '
        'cboSUP1
        '
        Me.cboSUP1.Location = New System.Drawing.Point(160, 12)
        Me.cboSUP1.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.cboSUP1.Name = "cboSUP1"
        Me.cboSUP1.Properties.AllowMouseWheel = False
        Me.cboSUP1.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        EditorButtonImageOptions1.Image = CType(resources.GetObject("EditorButtonImageOptions1.Image"), System.Drawing.Image)
        Me.cboSUP1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Search), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Clear), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, EditorButtonImageOptions1, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, SerializableAppearanceObject2, SerializableAppearanceObject3, SerializableAppearanceObject4, "", Nothing, Nothing, DevExpress.Utils.ToolTipAnchor.[Default])})
        Me.cboSUP1.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 54, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("code", "code", 85, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Fullname", "Επωνυμία", 142, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ttl", "ttl", 48, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("bal", "bal", 63, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("email", "email", 93, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("site", "site", 67, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default])})
        Me.cboSUP1.Properties.DataSource = Me.VwSUPBindingSource
        Me.cboSUP1.Properties.DisplayMember = "Fullname"
        Me.cboSUP1.Properties.NullText = ""
        Me.cboSUP1.Properties.PopupSizeable = False
        Me.cboSUP1.Properties.ValueMember = "ID"
        Me.cboSUP1.Size = New System.Drawing.Size(1110, 26)
        Me.cboSUP1.StyleController = Me.LayoutControl3
        Me.cboSUP1.TabIndex = 5
        Me.cboSUP1.Tag = "supID,0,1,2"
        '
        'VwSUPBindingSource
        '
        Me.VwSUPBindingSource.DataMember = "vw_SUP"
        Me.VwSUPBindingSource.DataSource = Me.DreamyKitchenDataSet
        '
        'cboColorsCat
        '
        Me.cboColorsCat.Location = New System.Drawing.Point(162, 46)
        Me.cboColorsCat.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.cboColorsCat.Name = "cboColorsCat"
        Me.cboColorsCat.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.cboColorsCat.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Search), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Clear)})
        Me.cboColorsCat.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 54, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("code", "code", 85, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("name", "Κατηγορία", 97, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("modifiedBy", "modified By", 177, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("modifiedOn", "modified On", 184, DevExpress.Utils.FormatType.DateTime, "d/M/yyyy", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("createdOn", "created On", 169, DevExpress.Utils.FormatType.DateTime, "d/M/yyyy", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("createdBy", "created By", 163, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("RealName", "Real Name", 168, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default])})
        Me.cboColorsCat.Properties.DataSource = Me.VwCOLORSCATBindingSource
        Me.cboColorsCat.Properties.DisplayMember = "name"
        Me.cboColorsCat.Properties.NullText = ""
        Me.cboColorsCat.Properties.PopupSizeable = False
        Me.cboColorsCat.Properties.ValueMember = "ID"
        Me.cboColorsCat.Size = New System.Drawing.Size(1106, 26)
        Me.cboColorsCat.StyleController = Me.LayoutControl3
        Me.cboColorsCat.TabIndex = 21
        Me.cboColorsCat.Tag = "colorCatID,0,1,2"
        '
        'VwCOLORSCATBindingSource
        '
        Me.VwCOLORSCATBindingSource.DataMember = "vw_COLORS_CAT"
        Me.VwCOLORSCATBindingSource.DataSource = Me.DreamyKitchenDataSet
        '
        'PictureEdit2
        '
        Me.PictureEdit2.Location = New System.Drawing.Point(162, 114)
        Me.PictureEdit2.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.PictureEdit2.Name = "PictureEdit2"
        Me.PictureEdit2.Properties.PictureStoreMode = DevExpress.XtraEditors.Controls.PictureStoreMode.ByteArray
        Me.PictureEdit2.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Always
        Me.PictureEdit2.Properties.ShowScrollBars = True
        Me.PictureEdit2.Properties.ShowZoomSubMenu = DevExpress.Utils.DefaultBoolean.[True]
        Me.PictureEdit2.Size = New System.Drawing.Size(1106, 201)
        Me.PictureEdit2.StyleController = Me.LayoutControl3
        Me.PictureEdit2.TabIndex = 44
        Me.PictureEdit2.Tag = "photo,0,1,2"
        '
        'LayoutControlGroup14
        '
        Me.LayoutControlGroup14.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup14.GroupBordersVisible = False
        Me.LayoutControlGroup14.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem25, Me.LayoutControlItem26, Me.LayoutControlItem27, Me.LayoutControlItem28, Me.LayoutControlItem29, Me.LayoutControlItem32, Me.EmptySpaceItem5, Me.LayoutControlItem33})
        Me.LayoutControlGroup14.Name = "Root"
        Me.LayoutControlGroup14.Size = New System.Drawing.Size(1282, 961)
        Me.LayoutControlGroup14.TextVisible = False
        '
        'LayoutControlItem25
        '
        Me.LayoutControlItem25.Control = Me.cboSUP1
        Me.LayoutControlItem25.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem25.CustomizationFormText = "Νομός"
        Me.LayoutControlItem25.HighlightFocusedItem = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlItem25.ImageOptions.Image = CType(resources.GetObject("LayoutControlItem25.ImageOptions.Image"), System.Drawing.Image)
        Me.LayoutControlItem25.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem25.Name = "LayoutControlItem92"
        Me.LayoutControlItem25.Size = New System.Drawing.Size(1262, 30)
        Me.LayoutControlItem25.Text = "Προμηθευτής"
        Me.LayoutControlItem25.TextSize = New System.Drawing.Size(136, 19)
        '
        'LayoutControlItem26
        '
        Me.LayoutControlItem26.Control = Me.cboColorsCat
        Me.LayoutControlItem26.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem26.CustomizationFormText = "Πορτάκι"
        Me.LayoutControlItem26.ImageOptions.Image = CType(resources.GetObject("LayoutControlItem26.ImageOptions.Image"), System.Drawing.Image)
        Me.LayoutControlItem26.Location = New System.Drawing.Point(0, 30)
        Me.LayoutControlItem26.Name = "LayoutControlItem93"
        Me.LayoutControlItem26.Padding = New DevExpress.XtraLayout.Utils.Padding(4, 4, 6, 6)
        Me.LayoutControlItem26.Size = New System.Drawing.Size(1262, 38)
        Me.LayoutControlItem26.Text = "Κατηγορία"
        Me.LayoutControlItem26.TextSize = New System.Drawing.Size(136, 19)
        '
        'LayoutControlItem27
        '
        Me.LayoutControlItem27.Control = Me.cboPhotoValueListItem
        Me.LayoutControlItem27.Location = New System.Drawing.Point(0, 68)
        Me.LayoutControlItem27.Name = "LayoutControlItem94"
        Me.LayoutControlItem27.Size = New System.Drawing.Size(1262, 30)
        Me.LayoutControlItem27.Text = "Κωδικός Χρώματος"
        Me.LayoutControlItem27.TextSize = New System.Drawing.Size(136, 19)
        '
        'LayoutControlItem28
        '
        Me.LayoutControlItem28.Control = Me.PictureEdit2
        Me.LayoutControlItem28.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem28.CustomizationFormText = "Φωτογραφία"
        Me.LayoutControlItem28.Location = New System.Drawing.Point(0, 98)
        Me.LayoutControlItem28.Name = "LayoutControlItem95"
        Me.LayoutControlItem28.Padding = New DevExpress.XtraLayout.Utils.Padding(4, 4, 6, 6)
        Me.LayoutControlItem28.Size = New System.Drawing.Size(1262, 213)
        Me.LayoutControlItem28.Text = "Φωτογραφία"
        Me.LayoutControlItem28.TextLocation = DevExpress.Utils.Locations.Left
        Me.LayoutControlItem28.TextSize = New System.Drawing.Size(136, 19)
        '
        'LayoutControlItem29
        '
        Me.LayoutControlItem29.Control = Me.GridControl1
        Me.LayoutControlItem29.Location = New System.Drawing.Point(0, 347)
        Me.LayoutControlItem29.Name = "LayoutControlItem96"
        Me.LayoutControlItem29.Size = New System.Drawing.Size(1262, 594)
        Me.LayoutControlItem29.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem29.TextVisible = False
        '
        'LayoutControlItem32
        '
        Me.LayoutControlItem32.Control = Me.cmdSavePhotos
        Me.LayoutControlItem32.Location = New System.Drawing.Point(1081, 311)
        Me.LayoutControlItem32.Name = "LayoutControlItem97"
        Me.LayoutControlItem32.Size = New System.Drawing.Size(181, 36)
        Me.LayoutControlItem32.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem32.TextVisible = False
        '
        'EmptySpaceItem5
        '
        Me.EmptySpaceItem5.AllowHotTrack = False
        Me.EmptySpaceItem5.Location = New System.Drawing.Point(219, 311)
        Me.EmptySpaceItem5.Name = "EmptySpaceItem2"
        Me.EmptySpaceItem5.Size = New System.Drawing.Size(862, 36)
        Me.EmptySpaceItem5.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem33
        '
        Me.LayoutControlItem33.Control = Me.cmdPrintPhotos
        Me.LayoutControlItem33.Location = New System.Drawing.Point(0, 311)
        Me.LayoutControlItem33.Name = "LayoutControlItem98"
        Me.LayoutControlItem33.Size = New System.Drawing.Size(219, 36)
        Me.LayoutControlItem33.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem33.TextVisible = False
        '
        'TabNavigationPage3
        '
        Me.TabNavigationPage3.Caption = "TabNavigationPage3"
        Me.TabNavigationPage3.Controls.Add(Me.LayoutControl4)
        Me.TabNavigationPage3.Margin = New System.Windows.Forms.Padding(4)
        Me.TabNavigationPage3.Name = "TabNavigationPage3"
        Me.TabNavigationPage3.PageText = "ΑΡΧΕΙΑ"
        Me.TabNavigationPage3.Size = New System.Drawing.Size(1282, 961)
        '
        'LayoutControl4
        '
        Me.LayoutControl4.Controls.Add(Me.cmdSaveTransF)
        Me.LayoutControl4.Controls.Add(Me.cboTanshFCategory)
        Me.LayoutControl4.Controls.Add(Me.GridControl2)
        Me.LayoutControl4.Controls.Add(Me.txtFiles)
        Me.LayoutControl4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl4.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl4.Margin = New System.Windows.Forms.Padding(4)
        Me.LayoutControl4.Name = "LayoutControl4"
        Me.LayoutControl4.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(1354, 626, 975, 600)
        Me.LayoutControl4.Root = Me.LayoutControlGroup16
        Me.LayoutControl4.Size = New System.Drawing.Size(1282, 961)
        Me.LayoutControl4.TabIndex = 3
        Me.LayoutControl4.Text = "LayoutControl4"
        '
        'cmdSaveTransF
        '
        Me.cmdSaveTransF.ImageOptions.Image = Global.DreamyKitchenCRM.My.Resources.Resources.icons8_save_close_24
        Me.cmdSaveTransF.Location = New System.Drawing.Point(1093, 72)
        Me.cmdSaveTransF.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdSaveTransF.Name = "cmdSaveTransF"
        Me.cmdSaveTransF.Size = New System.Drawing.Size(177, 32)
        Me.cmdSaveTransF.StyleController = Me.LayoutControl4
        Me.cmdSaveTransF.TabIndex = 69
        Me.cmdSaveTransF.Text = "Αποθήκευση"
        '
        'cboTanshFCategory
        '
        Me.cboTanshFCategory.Location = New System.Drawing.Point(109, 42)
        Me.cboTanshFCategory.Margin = New System.Windows.Forms.Padding(4)
        Me.cboTanshFCategory.Name = "cboTanshFCategory"
        Me.cboTanshFCategory.Properties.AllowMouseWheel = False
        Me.cboTanshFCategory.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.cboTanshFCategory.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Search), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Clear)})
        Me.cboTanshFCategory.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 31, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("code", "code", 49, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("name", "Κατηγορία", 55, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("modifiedBy", "modified By", 102, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("modifiedOn", "modified On", 105, DevExpress.Utils.FormatType.DateTime, "d/M/yyyy", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("createdOn", "created On", 97, DevExpress.Utils.FormatType.DateTime, "d/M/yyyy", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("createdBy", "created By", 93, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("RealName", "Real Name", 96, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default])})
        Me.cboTanshFCategory.Properties.DataSource = Me.VwFILECATBindingSource
        Me.cboTanshFCategory.Properties.DisplayMember = "name"
        Me.cboTanshFCategory.Properties.NullText = ""
        Me.cboTanshFCategory.Properties.PopupSizeable = False
        Me.cboTanshFCategory.Properties.ValueMember = "ID"
        Me.cboTanshFCategory.Size = New System.Drawing.Size(1161, 26)
        Me.cboTanshFCategory.StyleController = Me.LayoutControl4
        Me.cboTanshFCategory.TabIndex = 68
        Me.cboTanshFCategory.Tag = "fileCatID,0,1,2"
        '
        'VwFILECATBindingSource
        '
        Me.VwFILECATBindingSource.DataMember = "vw_FILE_CAT"
        Me.VwFILECATBindingSource.DataSource = Me.DreamyKitchenDataSet
        '
        'GridControl2
        '
        Me.GridControl2.DataSource = Me.TRANSHFBindingSource
        Me.GridControl2.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(12, 10, 12, 10)
        Me.GridControl2.Location = New System.Drawing.Point(12, 108)
        Me.GridControl2.MainView = Me.GridView3
        Me.GridControl2.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.GridControl2.Name = "GridControl2"
        Me.GridControl2.Size = New System.Drawing.Size(1258, 841)
        Me.GridControl2.TabIndex = 66
        Me.GridControl2.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView3})
        '
        'TRANSHFBindingSource
        '
        Me.TRANSHFBindingSource.DataMember = "TRANSH_F"
        Me.TRANSHFBindingSource.DataSource = Me.DM_TRANS
        '
        'GridView3
        '
        Me.GridView3.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn6, Me.GridColumn7, Me.coltranshID1, Me.colfilename, Me.colcomefrom, Me.colextension, Me.GridColumn8, Me.colmodifiedOn1, Me.colcreatedOn1, Me.GridColumn9})
        Me.GridView3.DetailHeight = 894
        Me.GridView3.GridControl = Me.GridControl2
        Me.GridView3.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always
        Me.GridView3.Name = "GridView3"
        Me.GridView3.OptionsBehavior.Editable = False
        Me.GridView3.OptionsEditForm.PopupEditFormWidth = 1260
        Me.GridView3.OptionsView.ColumnAutoWidth = False
        Me.GridView3.OptionsView.ShowGroupPanel = False
        '
        'GridColumn6
        '
        Me.GridColumn6.FieldName = "ID"
        Me.GridColumn6.MinWidth = 54
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 0
        Me.GridColumn6.Width = 205
        '
        'GridColumn7
        '
        Me.GridColumn7.FieldName = "code"
        Me.GridColumn7.MinWidth = 54
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.Visible = True
        Me.GridColumn7.VisibleIndex = 1
        Me.GridColumn7.Width = 205
        '
        'coltranshID1
        '
        Me.coltranshID1.FieldName = "transhID"
        Me.coltranshID1.MinWidth = 54
        Me.coltranshID1.Name = "coltranshID1"
        Me.coltranshID1.Visible = True
        Me.coltranshID1.VisibleIndex = 2
        Me.coltranshID1.Width = 205
        '
        'colfilename
        '
        Me.colfilename.FieldName = "filename"
        Me.colfilename.MinWidth = 54
        Me.colfilename.Name = "colfilename"
        Me.colfilename.Visible = True
        Me.colfilename.VisibleIndex = 3
        Me.colfilename.Width = 205
        '
        'colcomefrom
        '
        Me.colcomefrom.FieldName = "comefrom"
        Me.colcomefrom.MinWidth = 54
        Me.colcomefrom.Name = "colcomefrom"
        Me.colcomefrom.Visible = True
        Me.colcomefrom.VisibleIndex = 4
        Me.colcomefrom.Width = 205
        '
        'colextension
        '
        Me.colextension.FieldName = "extension"
        Me.colextension.MinWidth = 54
        Me.colextension.Name = "colextension"
        Me.colextension.Visible = True
        Me.colextension.VisibleIndex = 5
        Me.colextension.Width = 205
        '
        'GridColumn8
        '
        Me.GridColumn8.FieldName = "modifiedBy"
        Me.GridColumn8.MinWidth = 54
        Me.GridColumn8.Name = "GridColumn8"
        Me.GridColumn8.Visible = True
        Me.GridColumn8.VisibleIndex = 6
        Me.GridColumn8.Width = 205
        '
        'colmodifiedOn1
        '
        Me.colmodifiedOn1.FieldName = "modifiedOn"
        Me.colmodifiedOn1.MinWidth = 54
        Me.colmodifiedOn1.Name = "colmodifiedOn1"
        Me.colmodifiedOn1.Visible = True
        Me.colmodifiedOn1.VisibleIndex = 7
        Me.colmodifiedOn1.Width = 205
        '
        'colcreatedOn1
        '
        Me.colcreatedOn1.FieldName = "createdOn"
        Me.colcreatedOn1.MinWidth = 54
        Me.colcreatedOn1.Name = "colcreatedOn1"
        Me.colcreatedOn1.Visible = True
        Me.colcreatedOn1.VisibleIndex = 8
        Me.colcreatedOn1.Width = 205
        '
        'GridColumn9
        '
        Me.GridColumn9.FieldName = "createdBy"
        Me.GridColumn9.MinWidth = 54
        Me.GridColumn9.Name = "GridColumn9"
        Me.GridColumn9.Visible = True
        Me.GridColumn9.VisibleIndex = 9
        Me.GridColumn9.Width = 205
        '
        'txtFiles
        '
        Me.txtFiles.Location = New System.Drawing.Point(109, 12)
        Me.txtFiles.Margin = New System.Windows.Forms.Padding(4)
        Me.txtFiles.Name = "txtFiles"
        Me.txtFiles.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        EditorButtonImageOptions2.Image = Global.DreamyKitchenCRM.My.Resources.Resources.icons8_scanner_16
        Me.txtFiles.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, EditorButtonImageOptions2, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject5, SerializableAppearanceObject6, SerializableAppearanceObject7, SerializableAppearanceObject8, "", Nothing, Nothing, DevExpress.Utils.ToolTipAnchor.[Default]), New DevExpress.XtraEditors.Controls.EditorButton(), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete)})
        Me.txtFiles.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.txtFiles.Size = New System.Drawing.Size(1161, 26)
        Me.txtFiles.StyleController = Me.LayoutControl4
        Me.txtFiles.TabIndex = 0
        Me.txtFiles.Tag = ""
        '
        'LayoutControlGroup16
        '
        Me.LayoutControlGroup16.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup16.GroupBordersVisible = False
        Me.LayoutControlGroup16.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem49, Me.LayoutControlItem2, Me.LayoutControlItem8, Me.LayoutControlItem12, Me.EmptySpaceItem6})
        Me.LayoutControlGroup16.Name = "Root"
        Me.LayoutControlGroup16.Size = New System.Drawing.Size(1282, 961)
        Me.LayoutControlGroup16.TextVisible = False
        '
        'LayoutControlItem49
        '
        Me.LayoutControlItem49.Control = Me.GridControl2
        Me.LayoutControlItem49.Location = New System.Drawing.Point(0, 96)
        Me.LayoutControlItem49.Name = "LayoutControlItem99"
        Me.LayoutControlItem49.Size = New System.Drawing.Size(1262, 845)
        Me.LayoutControlItem49.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem49.TextVisible = False
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.txtFiles
        Me.LayoutControlItem2.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem2.CustomizationFormText = "Αρχεία"
        Me.LayoutControlItem2.HighlightFocusedItem = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(1262, 30)
        Me.LayoutControlItem2.Text = "Αρχεία"
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(85, 19)
        '
        'LayoutControlItem8
        '
        Me.LayoutControlItem8.Control = Me.cboTanshFCategory
        Me.LayoutControlItem8.ImageOptions.Image = Global.DreamyKitchenCRM.My.Resources.Resources.rsz_11rsz_asterisk
        Me.LayoutControlItem8.Location = New System.Drawing.Point(0, 30)
        Me.LayoutControlItem8.Name = "LayoutControlItem8"
        Me.LayoutControlItem8.Size = New System.Drawing.Size(1262, 30)
        Me.LayoutControlItem8.Text = "Κατηγορία"
        Me.LayoutControlItem8.TextSize = New System.Drawing.Size(85, 19)
        '
        'LayoutControlItem12
        '
        Me.LayoutControlItem12.Control = Me.cmdSaveTransF
        Me.LayoutControlItem12.Location = New System.Drawing.Point(1081, 60)
        Me.LayoutControlItem12.Name = "LayoutControlItem12"
        Me.LayoutControlItem12.Size = New System.Drawing.Size(181, 36)
        Me.LayoutControlItem12.Text = "Αποθήκευση"
        Me.LayoutControlItem12.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem12.TextVisible = False
        '
        'EmptySpaceItem6
        '
        Me.EmptySpaceItem6.AllowHotTrack = False
        Me.EmptySpaceItem6.Location = New System.Drawing.Point(0, 60)
        Me.EmptySpaceItem6.Name = "EmptySpaceItem6"
        Me.EmptySpaceItem6.Size = New System.Drawing.Size(1081, 36)
        Me.EmptySpaceItem6.TextSize = New System.Drawing.Size(0, 0)
        '
        'Vw_CCT_ORDERS_PHOTOSTableAdapter
        '
        Me.Vw_CCT_ORDERS_PHOTOSTableAdapter.ClearBeforeFill = True
        '
        'TRANSH_FTableAdapter
        '
        Me.TRANSH_FTableAdapter.ClearBeforeFill = True
        '
        'Vw_SUPTableAdapter
        '
        Me.Vw_SUPTableAdapter.ClearBeforeFill = True
        '
        'Vw_COLORS_CATTableAdapter
        '
        Me.Vw_COLORS_CATTableAdapter.ClearBeforeFill = True
        '
        'XtraOpenFileDialog1
        '
        Me.XtraOpenFileDialog1.Title = "Επιλογή αρχείων"
        '
        'VwSCANFILENAMESBindingSource
        '
        Me.VwSCANFILENAMESBindingSource.DataMember = "vw_SCAN_FILE_NAMES"
        Me.VwSCANFILENAMESBindingSource.DataSource = Me.DreamyKitchenDataSet
        '
        'Vw_FILE_CATTableAdapter
        '
        Me.Vw_FILE_CATTableAdapter.ClearBeforeFill = True
        '
        'frmCUSOfferOrderSpecialConstr
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1282, 1010)
        Me.Controls.Add(Me.TabPane1)
        Me.IconOptions.Image = Global.DreamyKitchenCRM.My.Resources.Resources.favicon
        Me.Name = "frmCUSOfferOrderSpecialConstr"
        Me.Text = "frmCUSOfferOrderSpecialConstr"
        CType(Me.VwCOMPBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DM_CCT, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VwCCTBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DreamyKitchenDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VwSALERSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VwVALUELISTITEMV2BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DM_VALUELISTITEM, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VwCONSTRTYPEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DMDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VwVALUELISTITEMSpecialConstrBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CCTTRANSHBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DM_TRANS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TabPane1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPane1.ResumeLayout(False)
        Me.TabNavigationPage1.ResumeLayout(False)
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.chkGenOffer.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboCompProject.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboCompany.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkofferAccepted.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkVatVisible.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtdtdaysOfDelivery.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboCUS.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtarProt.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpresentation.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpresentation.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtInitialPrice1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtInitialPrice2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtInitialPrice3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtInitialPrice4.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDisc1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDisc2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDisc3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDisc4.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDiscount1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDiscount2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDiscount3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDiscount4.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFinalPrice1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFinalPrice2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFinalPrice3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFinalPrice4.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboEMP.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtComments.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDescription.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtnotes.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTotalSpecialPrice.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTotalSpecialVat.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboTRANSH.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtExtraInst.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPartofVat.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboVALUELISTITEM4.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboValueListItem.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboVALUELISTITEM2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboVALUELISTITEM3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboScpecialConstr1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboScpecialConstr3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboScpecialConstr2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboScpecialConstr4.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtExtraTransp.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTotAmt.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LExit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LGroupOrderDetails1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ldtpresentation, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LarProt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem46, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem31, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem47, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LTRANSH, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LofferAccepted, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LCompProject, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem51, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem52, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LGenOffer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem48, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LGroupOrderDetails2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem20, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TabbedControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem34, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Lcost3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem38, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem42, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem17, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem21, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem23, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem18, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem35, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Lcost1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem39, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem43, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem22, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem19, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem36, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Lcost2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem40, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem44, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem24, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem63, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem37, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Lcost4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem41, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem45, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LCost, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LPartofVat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LTotalSpecialVat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LTotalSpecialPrice, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LExtraTransp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LExtraInst, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LConvertToOrder, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LPrivateAgreement, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LOrder, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LNewRecord, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem125, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem54, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabNavigationPage2.ResumeLayout(False)
        CType(Me.LayoutControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl3.ResumeLayout(False)
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VwCCTORDERSPHOTOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CardView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemColorCat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemSup, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemValueListiItem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemPhoto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboPhotoValueListItem.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboSUP1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VwSUPBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboColorsCat.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VwCOLORSCATBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem25, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem26, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem27, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem28, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem29, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem32, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem33, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabNavigationPage3.ResumeLayout(False)
        CType(Me.LayoutControl4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl4.ResumeLayout(False)
        CType(Me.cboTanshFCategory.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VwFILECATBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TRANSHFBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFiles.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem49, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VwSCANFILENAMESBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DreamyKitchenDataSet As DreamyKitchenDataSet
    Friend WithEvents VwSALERSBindingSource As BindingSource
    Friend WithEvents Vw_SALERSTableAdapter As DreamyKitchenDataSetTableAdapters.vw_SALERSTableAdapter
    Friend WithEvents DMDataSet As DMDataSet
    Friend WithEvents VwCONSTRTYPEBindingSource As BindingSource
    Friend WithEvents Vw_CONSTR_TYPETableAdapter As DMDataSetTableAdapters.vw_CONSTR_TYPETableAdapter
    Friend WithEvents DM_VALUELISTITEM As DM_VALUELISTITEM
    Friend WithEvents VwVALUELISTITEMSpecialConstrBindingSource As BindingSource
    Friend WithEvents Vw_VALUELISTITEMSpecialConstrTableAdapter As DM_VALUELISTITEMTableAdapters.vw_VALUELISTITEMSpecialConstrTableAdapter
    Friend WithEvents CCTTRANSHBindingSource As BindingSource
    Friend WithEvents VwVALUELISTITEMV2BindingSource As BindingSource
    Friend WithEvents Vw_VALUELISTITEM_V2TableAdapter As DM_VALUELISTITEMTableAdapters.vw_VALUELISTITEM_V2TableAdapter
    Friend WithEvents VwCCTBindingSource As BindingSource
    Friend WithEvents Vw_CCTTableAdapter As DreamyKitchenDataSetTableAdapters.vw_CCTTableAdapter
    Friend WithEvents DM_TRANS As DM_TRANS
    Friend WithEvents CCT_TRANSHTableAdapter As DM_TRANSTableAdapters.CCT_TRANSHTableAdapter
    Friend WithEvents DM_CCT As DM_CCT
    Friend WithEvents VwCOMPBindingSource As BindingSource
    Friend WithEvents Vw_COMPTableAdapter As DM_CCTTableAdapters.vw_COMPTableAdapter
    Friend WithEvents TabPane1 As DevExpress.XtraBars.Navigation.TabPane
    Friend WithEvents TabNavigationPage1 As DevExpress.XtraBars.Navigation.TabNavigationPage
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents cboCompProject As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents cboCompany As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents chkofferAccepted As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents cmdConvertToOrder As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents chkVatVisible As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents cmdPrintOffer As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lblDate As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtdtdaysOfDelivery As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cmdSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdExit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cboCUS As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents txtarProt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents dtpresentation As DevExpress.XtraEditors.DateEdit
    Friend WithEvents txtInitialPrice1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtInitialPrice2 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtInitialPrice3 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtInitialPrice4 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtDisc1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtDisc2 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtDisc3 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtDisc4 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtDiscount1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtDiscount2 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtDiscount3 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtDiscount4 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtFinalPrice1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtFinalPrice2 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtFinalPrice3 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtFinalPrice4 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cboEMP As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents txtComments As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents txtDescription As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents txtnotes As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents txtTotalSpecialPrice As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtTotalSpecialVat As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cboTRANSH As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents txtExtraInst As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtPartofVat As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cboVALUELISTITEM4 As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents cboValueListItem As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents cboVALUELISTITEM2 As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents cboVALUELISTITEM3 As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents cboScpecialConstr1 As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents cboScpecialConstr3 As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents cboScpecialConstr2 As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents cboScpecialConstr4 As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents txtExtraTransp As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Root As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LExit As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LGroupOrderDetails1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents Ldtpresentation As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LarProt As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LayoutControlItem46 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem31 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem47 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LTRANSH As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LofferAccepted As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem13 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LCompProject As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem48 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem14 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LGroupOrderDetails2 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem14 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem20 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlGroup6 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents TabbedControlGroup1 As DevExpress.XtraLayout.TabbedControlGroup
    Friend WithEvents LayoutControlGroup9 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem34 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents Lcost3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem38 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem42 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem17 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem21 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlGroup3 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem23 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem18 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem35 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents Lcost1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem39 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem43 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlGroup4 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem22 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem19 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem36 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents Lcost2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem40 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem44 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlGroup5 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem24 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem63 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem37 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents Lcost4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem41 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem45 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LCost As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LExtraTransp As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LExtraInst As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LPartofVat As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LTotalSpecialVat As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LTotalSpecialPrice As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LConvertToOrder As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents TabNavigationPage2 As DevExpress.XtraBars.Navigation.TabNavigationPage
    Friend WithEvents TabNavigationPage3 As DevExpress.XtraBars.Navigation.TabNavigationPage
    Friend WithEvents LayoutControl3 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents cmdPrintPhotos As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdSavePhotos As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents CardView1 As DevExpress.XtraGrid.Views.Card.CardView
    Friend WithEvents colcolorCatID1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemColorCat As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents colColorsCatName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsupID1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemSup As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents colSupFullName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colvalueListItemID1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemValueListiItem As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents colValueListItemName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colphoto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colID1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colvalueListItemID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCustomCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colcreatedOn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colcreatedBy As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colcolorCatID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colmodifiedBy As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colmodifiedOn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsite As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsupID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemPhoto As DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit
    Friend WithEvents cboPhotoValueListItem As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents cboSUP1 As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents cboColorsCat As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents PictureEdit2 As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents LayoutControlGroup14 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem25 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem26 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem27 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem28 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem29 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem32 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem5 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LayoutControlItem33 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControl4 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents GridControl2 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coltranshID1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colfilename As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colcomefrom As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colextension As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colmodifiedOn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colcreatedOn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn9 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LayoutControlGroup16 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem49 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents VwCCTORDERSPHOTOSBindingSource As BindingSource
    Friend WithEvents TRANSHFBindingSource As BindingSource
    Friend WithEvents Vw_CCT_ORDERS_PHOTOSTableAdapter As DM_CCTTableAdapters.vw_CCT_ORDERS_PHOTOSTableAdapter
    Friend WithEvents TRANSH_FTableAdapter As DM_TRANSTableAdapters.TRANSH_FTableAdapter
    Friend WithEvents VwSUPBindingSource As BindingSource
    Friend WithEvents Vw_SUPTableAdapter As DreamyKitchenDataSetTableAdapters.vw_SUPTableAdapter
    Friend WithEvents Vw_COLORS_CATTableAdapter As DreamyKitchenDataSetTableAdapters.vw_COLORS_CATTableAdapter
    Friend WithEvents VwCOLORSCATBindingSource As BindingSource
    Friend WithEvents cmdCompCollection As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem51 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents cmdCusCollection As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem52 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents chkGenOffer As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents LGenOffer As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents cmdOrder As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdPrivateAgreement As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdNewRecord As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LPrivateAgreement As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LOrder As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LNewRecord As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents txtTotAmt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem125 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LblMsg As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LayoutControlItem54 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem3 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem4 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents txtFiles As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents cboTanshFCategory As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents cmdSaveTransF As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem12 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem6 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents XtraOpenFileDialog1 As DevExpress.XtraEditors.XtraOpenFileDialog
    Friend WithEvents VwSCANFILENAMESBindingSource As BindingSource
    Friend WithEvents VwFILECATBindingSource As BindingSource
    Friend WithEvents Vw_FILE_CATTableAdapter As DreamyKitchenDataSetTableAdapters.vw_FILE_CATTableAdapter
End Class
