﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCUSOfferOrderDoors
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCUSOfferOrderDoors))
        Dim GridFormatRule2 As DevExpress.XtraGrid.GridFormatRule = New DevExpress.XtraGrid.GridFormatRule()
        Dim FormatConditionRuleExpression2 As DevExpress.XtraEditors.FormatConditionRuleExpression = New DevExpress.XtraEditors.FormatConditionRuleExpression()
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
        Me.CCTTRANSHBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DM_TRANS = New DreamyKitchenCRM.DM_TRANS()
        Me.DMDataSet = New DreamyKitchenCRM.DMDataSet()
        Me.VwCOLORSDOORSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Vw_SALERSTableAdapter = New DreamyKitchenCRM.DreamyKitchenDataSetTableAdapters.vw_SALERSTableAdapter()
        Me.Vw_COLORSDOORSTableAdapter = New DreamyKitchenCRM.DreamyKitchenDataSetTableAdapters.vw_COLORSDOORSTableAdapter()
        Me.Vw_CCTTableAdapter = New DreamyKitchenCRM.DreamyKitchenDataSetTableAdapters.vw_CCTTableAdapter()
        Me.CCT_TRANSHTableAdapter = New DreamyKitchenCRM.DM_TRANSTableAdapters.CCT_TRANSHTableAdapter()
        Me.Vw_VALUELISTITEM_V2TableAdapter = New DreamyKitchenCRM.DM_VALUELISTITEMTableAdapters.vw_VALUELISTITEM_V2TableAdapter()
        Me.Vw_COMPTableAdapter = New DreamyKitchenCRM.DM_CCTTableAdapters.vw_COMPTableAdapter()
        Me.TabPane1 = New DevExpress.XtraBars.Navigation.TabPane()
        Me.TabNavigationPage1 = New DevExpress.XtraBars.Navigation.TabNavigationPage()
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.LblMsg = New DevExpress.XtraEditors.LabelControl()
        Me.chkGenOffer = New DevExpress.XtraEditors.CheckEdit()
        Me.cmdOrder = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdPrivateAgreement = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdNewRecord = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdCusCollection = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdCompCollection = New DevExpress.XtraEditors.SimpleButton()
        Me.cboCompProject = New DevExpress.XtraEditors.LookUpEdit()
        Me.cboCompany = New DevExpress.XtraEditors.LookUpEdit()
        Me.chkofferAccepted = New DevExpress.XtraEditors.CheckEdit()
        Me.chkVatVisible = New DevExpress.XtraEditors.CheckEdit()
        Me.cmdPrintOffer = New DevExpress.XtraEditors.SimpleButton()
        Me.lblDate = New DevExpress.XtraEditors.LabelControl()
        Me.txtdtdaysOfDelivery = New DevExpress.XtraEditors.TextEdit()
        Me.cmdSave = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdExit = New DevExpress.XtraEditors.SimpleButton()
        Me.cboCUS = New DevExpress.XtraEditors.LookUpEdit()
        Me.txtarProt = New DevExpress.XtraEditors.TextEdit()
        Me.dtpresentation = New DevExpress.XtraEditors.DateEdit()
        Me.txtDimension1 = New DevExpress.XtraEditors.TextEdit()
        Me.txtDimension2 = New DevExpress.XtraEditors.TextEdit()
        Me.txtDimension3 = New DevExpress.XtraEditors.TextEdit()
        Me.txtDimension4 = New DevExpress.XtraEditors.TextEdit()
        Me.txtDimension8 = New DevExpress.XtraEditors.TextEdit()
        Me.txtDimension5 = New DevExpress.XtraEditors.TextEdit()
        Me.txtTotalDoorsVat = New DevExpress.XtraEditors.TextEdit()
        Me.cboEMP = New DevExpress.XtraEditors.LookUpEdit()
        Me.cboFora1 = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.cboFora2 = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.cboFora3 = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.cboFora4 = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.cboFora5 = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.cboFora6 = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.cboKasa1 = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.cboKasa2 = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.cboKasa3 = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.cboKasa4 = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.cboKasa5 = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.cboKasa6 = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.txtDescription = New DevExpress.XtraEditors.MemoEdit()
        Me.txtComments = New DevExpress.XtraEditors.MemoEdit()
        Me.txtKnobs1 = New DevExpress.XtraEditors.TextEdit()
        Me.txtTotalDoorsPrice = New DevExpress.XtraEditors.TextEdit()
        Me.txtNotes = New DevExpress.XtraEditors.MemoEdit()
        Me.cboTRANSH = New DevExpress.XtraEditors.LookUpEdit()
        Me.txtExtraInst = New DevExpress.XtraEditors.TextEdit()
        Me.txtPartofVat = New DevExpress.XtraEditors.TextEdit()
        Me.cboType1 = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.cboType2 = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.cboType3 = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.cboType4 = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.cboType5 = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.cboType6 = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.cboValueListItem = New DevExpress.XtraEditors.LookUpEdit()
        Me.cboVALUELISTITEM2 = New DevExpress.XtraEditors.LookUpEdit()
        Me.cboVALUELISTITEM3 = New DevExpress.XtraEditors.LookUpEdit()
        Me.cboVALUELISTITEM4 = New DevExpress.XtraEditors.LookUpEdit()
        Me.cboVALUELISTITEM5 = New DevExpress.XtraEditors.LookUpEdit()
        Me.cboVALUELISTITEM6 = New DevExpress.XtraEditors.LookUpEdit()
        Me.txtExtraTransp = New DevExpress.XtraEditors.TextEdit()
        Me.cmdConvertToOrder = New DevExpress.XtraEditors.SimpleButton()
        Me.txtKnobs2 = New DevExpress.XtraEditors.TextEdit()
        Me.txtKnobs3 = New DevExpress.XtraEditors.TextEdit()
        Me.txtKnobs4 = New DevExpress.XtraEditors.TextEdit()
        Me.txtKnobs5 = New DevExpress.XtraEditors.TextEdit()
        Me.txtKnobs6 = New DevExpress.XtraEditors.TextEdit()
        Me.cboType7 = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.cboKasa7 = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.cboFora7 = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.cboVALUELISTITEM7 = New DevExpress.XtraEditors.LookUpEdit()
        Me.txtDimension142 = New DevExpress.XtraEditors.TextEdit()
        Me.txtKnobs7 = New DevExpress.XtraEditors.TextEdit()
        Me.cboType8 = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.cboKasa8 = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.cboFora8 = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.cboVALUELISTITEM8 = New DevExpress.XtraEditors.LookUpEdit()
        Me.txtDimension141 = New DevExpress.XtraEditors.TextEdit()
        Me.txtKnobs8 = New DevExpress.XtraEditors.TextEdit()
        Me.cboType9 = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.cboKasa9 = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.cboFora9 = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.cboVALUELISTITEM9 = New DevExpress.XtraEditors.LookUpEdit()
        Me.txtDimension9 = New DevExpress.XtraEditors.TextEdit()
        Me.txtKnobs9 = New DevExpress.XtraEditors.TextEdit()
        Me.cboType10 = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.cboKasa10 = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.cboFora10 = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.cboVALUELISTITEM10 = New DevExpress.XtraEditors.LookUpEdit()
        Me.txtDimension10 = New DevExpress.XtraEditors.TextEdit()
        Me.txtKnobs10 = New DevExpress.XtraEditors.TextEdit()
        Me.txtInitialPrice1 = New DevExpress.XtraEditors.TextEdit()
        Me.txtDisc1 = New DevExpress.XtraEditors.TextEdit()
        Me.txtDiscount1 = New DevExpress.XtraEditors.TextEdit()
        Me.txtFinalPrice1 = New DevExpress.XtraEditors.TextEdit()
        Me.txtInitialPrice2 = New DevExpress.XtraEditors.TextEdit()
        Me.txtDisc2 = New DevExpress.XtraEditors.TextEdit()
        Me.txtDiscount2 = New DevExpress.XtraEditors.TextEdit()
        Me.txtFinalPrice2 = New DevExpress.XtraEditors.TextEdit()
        Me.txtInitialPrice3 = New DevExpress.XtraEditors.TextEdit()
        Me.txtDisc3 = New DevExpress.XtraEditors.TextEdit()
        Me.txtDiscount3 = New DevExpress.XtraEditors.TextEdit()
        Me.txtFinalPrice3 = New DevExpress.XtraEditors.TextEdit()
        Me.txtInitialPrice4 = New DevExpress.XtraEditors.TextEdit()
        Me.txtDisc4 = New DevExpress.XtraEditors.TextEdit()
        Me.txtDiscount4 = New DevExpress.XtraEditors.TextEdit()
        Me.txtFinalPrice4 = New DevExpress.XtraEditors.TextEdit()
        Me.txtInitialPrice5 = New DevExpress.XtraEditors.TextEdit()
        Me.txtDisc5 = New DevExpress.XtraEditors.TextEdit()
        Me.txtDiscount5 = New DevExpress.XtraEditors.TextEdit()
        Me.txtFinalPrice5 = New DevExpress.XtraEditors.TextEdit()
        Me.txtInitialPrice6 = New DevExpress.XtraEditors.TextEdit()
        Me.txtDisc6 = New DevExpress.XtraEditors.TextEdit()
        Me.txtDiscount6 = New DevExpress.XtraEditors.TextEdit()
        Me.txtFinalPrice6 = New DevExpress.XtraEditors.TextEdit()
        Me.txtInitialPrice7 = New DevExpress.XtraEditors.TextEdit()
        Me.txtDisc7 = New DevExpress.XtraEditors.TextEdit()
        Me.txtDiscount7 = New DevExpress.XtraEditors.TextEdit()
        Me.txtFinalPrice7 = New DevExpress.XtraEditors.TextEdit()
        Me.txtInitialPrice8 = New DevExpress.XtraEditors.TextEdit()
        Me.txtDisc8 = New DevExpress.XtraEditors.TextEdit()
        Me.txtDiscount8 = New DevExpress.XtraEditors.TextEdit()
        Me.txtFinalPrice8 = New DevExpress.XtraEditors.TextEdit()
        Me.txtInitialPrice9 = New DevExpress.XtraEditors.TextEdit()
        Me.txtDisc9 = New DevExpress.XtraEditors.TextEdit()
        Me.txtDiscount9 = New DevExpress.XtraEditors.TextEdit()
        Me.txtFinalPrice9 = New DevExpress.XtraEditors.TextEdit()
        Me.txtInitialPrice10 = New DevExpress.XtraEditors.TextEdit()
        Me.txtDisc10 = New DevExpress.XtraEditors.TextEdit()
        Me.txtDiscount10 = New DevExpress.XtraEditors.TextEdit()
        Me.txtFinalPrice10 = New DevExpress.XtraEditors.TextEdit()
        Me.txtTotAmt = New DevExpress.XtraEditors.TextEdit()
        Me.LayoutControlGroup12 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlGroup11 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LExit = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LSave = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LGroupOrderDetails1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LarProt = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LEMP = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem41 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.Ldtpresentation = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem31 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LlblDate = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LofferAccepted = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem15 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LCompProject = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LCompCollection = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LCusCollection = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LGenOffer = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LPrintOffer = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LvisibleVAT = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LGroupOrderDetails2 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem32 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem33 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem39 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup9 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.TabbedControlGroup1 = New DevExpress.XtraLayout.TabbedControlGroup()
        Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem12 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem56 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem24 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem105 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.Lcost3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem106 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem107 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem58 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem18 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem37 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup3 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem57 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem25 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem23 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem108 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.Lcost1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem109 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem110 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem22 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem13 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup5 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem59 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem49 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem26 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem111 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.Lcost2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem112 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem113 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem63 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem21 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup6 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem60 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem50 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem27 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem114 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.Lcost4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem115 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem116 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem64 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem67 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup7 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem61 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem51 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem10 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem29 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem117 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.Lcost5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem118 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem119 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem65 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem68 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup8 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem62 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem11 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem28 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem120 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.Lcost6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem121 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem122 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem66 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem71 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem52 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutRootGroupForRestore = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem81 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem82 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem83 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem87 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem123 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.Lcost7 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem124 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem125 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem84 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem88 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup13 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem73 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem74 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem75 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem79 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem126 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.Lcost8 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem127 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem128 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem76 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem80 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup15 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem89 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem90 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem91 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem95 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem129 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.Lcost9 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem130 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem131 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem92 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem96 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup17 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem97 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem98 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem99 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem103 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem132 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.Lcost10 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem133 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem134 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem100 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem104 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LCost = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LTotalDoorsPrice = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LExtraInst = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LExtraTransp = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LPartofVat = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LTotalDoorsVat = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem3 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem4 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LConvertToOrder = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem14 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LTotAmt = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LPrivateAgreement = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LOrder = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LNewRecord = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
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
        Me.LayoutControlItem14 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem16 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem17 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem19 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem20 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem34 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem5 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem36 = New DevExpress.XtraLayout.LayoutControlItem()
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
        Me.LayoutControlItem42 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem78 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem85 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem86 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem6 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.Vw_CCT_ORDERS_PHOTOSTableAdapter = New DreamyKitchenCRM.DM_CCTTableAdapters.vw_CCT_ORDERS_PHOTOSTableAdapter()
        Me.TRANSH_FTableAdapter = New DreamyKitchenCRM.DM_TRANSTableAdapters.TRANSH_FTableAdapter()
        Me.Vw_SUPTableAdapter = New DreamyKitchenCRM.DreamyKitchenDataSetTableAdapters.vw_SUPTableAdapter()
        Me.Vw_COLORS_CATTableAdapter = New DreamyKitchenCRM.DreamyKitchenDataSetTableAdapters.vw_COLORS_CATTableAdapter()
        Me.VwSCANFILENAMESBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.XtraOpenFileDialog1 = New DevExpress.XtraEditors.XtraOpenFileDialog(Me.components)
        Me.Vw_FILE_CATTableAdapter = New DreamyKitchenCRM.DreamyKitchenDataSetTableAdapters.vw_FILE_CATTableAdapter()
        CType(Me.VwCOMPBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DM_CCT, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VwCCTBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DreamyKitchenDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VwSALERSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VwVALUELISTITEMV2BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DM_VALUELISTITEM, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CCTTRANSHBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DM_TRANS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DMDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VwCOLORSDOORSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
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
        CType(Me.txtDimension1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDimension2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDimension3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDimension4.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDimension8.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDimension5.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTotalDoorsVat.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboEMP.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboFora1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboFora2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboFora3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboFora4.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboFora5.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboFora6.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboKasa1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboKasa2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboKasa3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboKasa4.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboKasa5.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboKasa6.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDescription.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtComments.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtKnobs1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTotalDoorsPrice.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNotes.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboTRANSH.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtExtraInst.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPartofVat.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboType1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboType2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboType3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboType4.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboType5.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboType6.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboValueListItem.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboVALUELISTITEM2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboVALUELISTITEM3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboVALUELISTITEM4.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboVALUELISTITEM5.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboVALUELISTITEM6.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtExtraTransp.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtKnobs2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtKnobs3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtKnobs4.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtKnobs5.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtKnobs6.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboType7.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboKasa7.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboFora7.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboVALUELISTITEM7.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDimension142.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtKnobs7.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboType8.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboKasa8.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboFora8.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboVALUELISTITEM8.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDimension141.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtKnobs8.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboType9.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboKasa9.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboFora9.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboVALUELISTITEM9.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDimension9.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtKnobs9.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboType10.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboKasa10.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboFora10.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboVALUELISTITEM10.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDimension10.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtKnobs10.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtInitialPrice1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDisc1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDiscount1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFinalPrice1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtInitialPrice2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDisc2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDiscount2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFinalPrice2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtInitialPrice3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDisc3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDiscount3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFinalPrice3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtInitialPrice4.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDisc4.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDiscount4.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFinalPrice4.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtInitialPrice5.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDisc5.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDiscount5.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFinalPrice5.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtInitialPrice6.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDisc6.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDiscount6.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFinalPrice6.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtInitialPrice7.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDisc7.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDiscount7.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFinalPrice7.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtInitialPrice8.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDisc8.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDiscount8.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFinalPrice8.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtInitialPrice9.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDisc9.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDiscount9.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFinalPrice9.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtInitialPrice10.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDisc10.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDiscount10.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFinalPrice10.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTotAmt.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LExit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LSave, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LGroupOrderDetails1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LarProt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LEMP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem41, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ldtpresentation, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem31, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LlblDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LofferAccepted, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LCompProject, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LCompCollection, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LCusCollection, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LGenOffer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LPrintOffer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LvisibleVAT, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LGroupOrderDetails2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem32, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem33, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem39, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TabbedControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem56, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem24, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem105, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Lcost3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem106, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem107, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem58, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem18, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem37, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem57, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem25, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem23, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem108, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Lcost1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem109, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem110, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem22, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem59, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem49, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem26, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem111, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Lcost2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem112, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem113, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem63, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem21, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem60, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem50, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem27, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem114, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Lcost4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem115, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem116, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem64, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem67, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem61, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem51, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem29, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem117, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Lcost5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem118, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem119, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem65, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem68, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem62, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem28, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem120, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Lcost6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem121, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem122, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem66, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem71, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem52, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutRootGroupForRestore, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem81, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem82, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem83, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem87, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem123, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Lcost7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem124, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem125, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem84, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem88, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem73, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem74, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem75, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem79, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem126, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Lcost8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem127, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem128, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem76, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem80, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem89, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem90, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem91, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem95, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem129, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Lcost9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem130, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem131, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem92, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem96, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup17, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem97, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem98, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem99, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem103, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem132, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Lcost10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem133, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem134, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem100, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem104, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LCost, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LTotalDoorsPrice, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LExtraInst, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LExtraTransp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LPartofVat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LTotalDoorsVat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LConvertToOrder, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LTotAmt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LPrivateAgreement, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LOrder, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LNewRecord, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem17, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem19, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem20, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem34, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem36, System.ComponentModel.ISupportInitialize).BeginInit()
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
        CType(Me.LayoutControlItem42, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem78, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem85, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem86, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'DMDataSet
        '
        Me.DMDataSet.DataSetName = "DMDataSet"
        Me.DMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'VwCOLORSDOORSBindingSource
        '
        Me.VwCOLORSDOORSBindingSource.DataMember = "vw_COLORSDOORS"
        Me.VwCOLORSDOORSBindingSource.DataSource = Me.DreamyKitchenDataSet
        '
        'Vw_SALERSTableAdapter
        '
        Me.Vw_SALERSTableAdapter.ClearBeforeFill = True
        '
        'Vw_COLORSDOORSTableAdapter
        '
        Me.Vw_COLORSDOORSTableAdapter.ClearBeforeFill = True
        '
        'Vw_CCTTableAdapter
        '
        Me.Vw_CCTTableAdapter.ClearBeforeFill = True
        '
        'CCT_TRANSHTableAdapter
        '
        Me.CCT_TRANSHTableAdapter.ClearBeforeFill = True
        '
        'Vw_VALUELISTITEM_V2TableAdapter
        '
        Me.Vw_VALUELISTITEM_V2TableAdapter.ClearBeforeFill = True
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
        Me.TabPane1.Margin = New System.Windows.Forms.Padding(10)
        Me.TabPane1.Name = "TabPane1"
        Me.TabPane1.Pages.AddRange(New DevExpress.XtraBars.Navigation.NavigationPageBase() {Me.TabNavigationPage1, Me.TabNavigationPage2, Me.TabNavigationPage3})
        Me.TabPane1.RegularSize = New System.Drawing.Size(1353, 1010)
        Me.TabPane1.SelectedPage = Me.TabNavigationPage1
        Me.TabPane1.Size = New System.Drawing.Size(1353, 1010)
        Me.TabPane1.TabIndex = 0
        Me.TabPane1.Text = "TabPane1"
        '
        'TabNavigationPage1
        '
        Me.TabNavigationPage1.Caption = "TabNavigationPage1"
        Me.TabNavigationPage1.Controls.Add(Me.LayoutControl1)
        Me.TabNavigationPage1.Margin = New System.Windows.Forms.Padding(10)
        Me.TabNavigationPage1.Name = "TabNavigationPage1"
        Me.TabNavigationPage1.PageText = "ΠΟΡΤΕΣ"
        Me.TabNavigationPage1.Size = New System.Drawing.Size(1353, 961)
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.LblMsg)
        Me.LayoutControl1.Controls.Add(Me.chkGenOffer)
        Me.LayoutControl1.Controls.Add(Me.cmdOrder)
        Me.LayoutControl1.Controls.Add(Me.cmdPrivateAgreement)
        Me.LayoutControl1.Controls.Add(Me.cmdNewRecord)
        Me.LayoutControl1.Controls.Add(Me.cmdCusCollection)
        Me.LayoutControl1.Controls.Add(Me.cmdCompCollection)
        Me.LayoutControl1.Controls.Add(Me.cboCompProject)
        Me.LayoutControl1.Controls.Add(Me.cboCompany)
        Me.LayoutControl1.Controls.Add(Me.chkofferAccepted)
        Me.LayoutControl1.Controls.Add(Me.chkVatVisible)
        Me.LayoutControl1.Controls.Add(Me.cmdPrintOffer)
        Me.LayoutControl1.Controls.Add(Me.lblDate)
        Me.LayoutControl1.Controls.Add(Me.txtdtdaysOfDelivery)
        Me.LayoutControl1.Controls.Add(Me.cmdSave)
        Me.LayoutControl1.Controls.Add(Me.cmdExit)
        Me.LayoutControl1.Controls.Add(Me.cboCUS)
        Me.LayoutControl1.Controls.Add(Me.txtarProt)
        Me.LayoutControl1.Controls.Add(Me.dtpresentation)
        Me.LayoutControl1.Controls.Add(Me.txtDimension1)
        Me.LayoutControl1.Controls.Add(Me.txtDimension2)
        Me.LayoutControl1.Controls.Add(Me.txtDimension3)
        Me.LayoutControl1.Controls.Add(Me.txtDimension4)
        Me.LayoutControl1.Controls.Add(Me.txtDimension8)
        Me.LayoutControl1.Controls.Add(Me.txtDimension5)
        Me.LayoutControl1.Controls.Add(Me.txtTotalDoorsVat)
        Me.LayoutControl1.Controls.Add(Me.cboEMP)
        Me.LayoutControl1.Controls.Add(Me.cboFora1)
        Me.LayoutControl1.Controls.Add(Me.cboFora2)
        Me.LayoutControl1.Controls.Add(Me.cboFora3)
        Me.LayoutControl1.Controls.Add(Me.cboFora4)
        Me.LayoutControl1.Controls.Add(Me.cboFora5)
        Me.LayoutControl1.Controls.Add(Me.cboFora6)
        Me.LayoutControl1.Controls.Add(Me.cboKasa1)
        Me.LayoutControl1.Controls.Add(Me.cboKasa2)
        Me.LayoutControl1.Controls.Add(Me.cboKasa3)
        Me.LayoutControl1.Controls.Add(Me.cboKasa4)
        Me.LayoutControl1.Controls.Add(Me.cboKasa5)
        Me.LayoutControl1.Controls.Add(Me.cboKasa6)
        Me.LayoutControl1.Controls.Add(Me.txtDescription)
        Me.LayoutControl1.Controls.Add(Me.txtComments)
        Me.LayoutControl1.Controls.Add(Me.txtKnobs1)
        Me.LayoutControl1.Controls.Add(Me.txtTotalDoorsPrice)
        Me.LayoutControl1.Controls.Add(Me.txtNotes)
        Me.LayoutControl1.Controls.Add(Me.cboTRANSH)
        Me.LayoutControl1.Controls.Add(Me.txtExtraInst)
        Me.LayoutControl1.Controls.Add(Me.txtPartofVat)
        Me.LayoutControl1.Controls.Add(Me.cboType1)
        Me.LayoutControl1.Controls.Add(Me.cboType2)
        Me.LayoutControl1.Controls.Add(Me.cboType3)
        Me.LayoutControl1.Controls.Add(Me.cboType4)
        Me.LayoutControl1.Controls.Add(Me.cboType5)
        Me.LayoutControl1.Controls.Add(Me.cboType6)
        Me.LayoutControl1.Controls.Add(Me.cboValueListItem)
        Me.LayoutControl1.Controls.Add(Me.cboVALUELISTITEM2)
        Me.LayoutControl1.Controls.Add(Me.cboVALUELISTITEM3)
        Me.LayoutControl1.Controls.Add(Me.cboVALUELISTITEM4)
        Me.LayoutControl1.Controls.Add(Me.cboVALUELISTITEM5)
        Me.LayoutControl1.Controls.Add(Me.cboVALUELISTITEM6)
        Me.LayoutControl1.Controls.Add(Me.txtExtraTransp)
        Me.LayoutControl1.Controls.Add(Me.cmdConvertToOrder)
        Me.LayoutControl1.Controls.Add(Me.txtKnobs2)
        Me.LayoutControl1.Controls.Add(Me.txtKnobs3)
        Me.LayoutControl1.Controls.Add(Me.txtKnobs4)
        Me.LayoutControl1.Controls.Add(Me.txtKnobs5)
        Me.LayoutControl1.Controls.Add(Me.txtKnobs6)
        Me.LayoutControl1.Controls.Add(Me.cboType7)
        Me.LayoutControl1.Controls.Add(Me.cboKasa7)
        Me.LayoutControl1.Controls.Add(Me.cboFora7)
        Me.LayoutControl1.Controls.Add(Me.cboVALUELISTITEM7)
        Me.LayoutControl1.Controls.Add(Me.txtDimension142)
        Me.LayoutControl1.Controls.Add(Me.txtKnobs7)
        Me.LayoutControl1.Controls.Add(Me.cboType8)
        Me.LayoutControl1.Controls.Add(Me.cboKasa8)
        Me.LayoutControl1.Controls.Add(Me.cboFora8)
        Me.LayoutControl1.Controls.Add(Me.cboVALUELISTITEM8)
        Me.LayoutControl1.Controls.Add(Me.txtDimension141)
        Me.LayoutControl1.Controls.Add(Me.txtKnobs8)
        Me.LayoutControl1.Controls.Add(Me.cboType9)
        Me.LayoutControl1.Controls.Add(Me.cboKasa9)
        Me.LayoutControl1.Controls.Add(Me.cboFora9)
        Me.LayoutControl1.Controls.Add(Me.cboVALUELISTITEM9)
        Me.LayoutControl1.Controls.Add(Me.txtDimension9)
        Me.LayoutControl1.Controls.Add(Me.txtKnobs9)
        Me.LayoutControl1.Controls.Add(Me.cboType10)
        Me.LayoutControl1.Controls.Add(Me.cboKasa10)
        Me.LayoutControl1.Controls.Add(Me.cboFora10)
        Me.LayoutControl1.Controls.Add(Me.cboVALUELISTITEM10)
        Me.LayoutControl1.Controls.Add(Me.txtDimension10)
        Me.LayoutControl1.Controls.Add(Me.txtKnobs10)
        Me.LayoutControl1.Controls.Add(Me.txtInitialPrice1)
        Me.LayoutControl1.Controls.Add(Me.txtDisc1)
        Me.LayoutControl1.Controls.Add(Me.txtDiscount1)
        Me.LayoutControl1.Controls.Add(Me.txtFinalPrice1)
        Me.LayoutControl1.Controls.Add(Me.txtInitialPrice2)
        Me.LayoutControl1.Controls.Add(Me.txtDisc2)
        Me.LayoutControl1.Controls.Add(Me.txtDiscount2)
        Me.LayoutControl1.Controls.Add(Me.txtFinalPrice2)
        Me.LayoutControl1.Controls.Add(Me.txtInitialPrice3)
        Me.LayoutControl1.Controls.Add(Me.txtDisc3)
        Me.LayoutControl1.Controls.Add(Me.txtDiscount3)
        Me.LayoutControl1.Controls.Add(Me.txtFinalPrice3)
        Me.LayoutControl1.Controls.Add(Me.txtInitialPrice4)
        Me.LayoutControl1.Controls.Add(Me.txtDisc4)
        Me.LayoutControl1.Controls.Add(Me.txtDiscount4)
        Me.LayoutControl1.Controls.Add(Me.txtFinalPrice4)
        Me.LayoutControl1.Controls.Add(Me.txtInitialPrice5)
        Me.LayoutControl1.Controls.Add(Me.txtDisc5)
        Me.LayoutControl1.Controls.Add(Me.txtDiscount5)
        Me.LayoutControl1.Controls.Add(Me.txtFinalPrice5)
        Me.LayoutControl1.Controls.Add(Me.txtInitialPrice6)
        Me.LayoutControl1.Controls.Add(Me.txtDisc6)
        Me.LayoutControl1.Controls.Add(Me.txtDiscount6)
        Me.LayoutControl1.Controls.Add(Me.txtFinalPrice6)
        Me.LayoutControl1.Controls.Add(Me.txtInitialPrice7)
        Me.LayoutControl1.Controls.Add(Me.txtDisc7)
        Me.LayoutControl1.Controls.Add(Me.txtDiscount7)
        Me.LayoutControl1.Controls.Add(Me.txtFinalPrice7)
        Me.LayoutControl1.Controls.Add(Me.txtInitialPrice8)
        Me.LayoutControl1.Controls.Add(Me.txtDisc8)
        Me.LayoutControl1.Controls.Add(Me.txtDiscount8)
        Me.LayoutControl1.Controls.Add(Me.txtFinalPrice8)
        Me.LayoutControl1.Controls.Add(Me.txtInitialPrice9)
        Me.LayoutControl1.Controls.Add(Me.txtDisc9)
        Me.LayoutControl1.Controls.Add(Me.txtDiscount9)
        Me.LayoutControl1.Controls.Add(Me.txtFinalPrice9)
        Me.LayoutControl1.Controls.Add(Me.txtInitialPrice10)
        Me.LayoutControl1.Controls.Add(Me.txtDisc10)
        Me.LayoutControl1.Controls.Add(Me.txtDiscount10)
        Me.LayoutControl1.Controls.Add(Me.txtFinalPrice10)
        Me.LayoutControl1.Controls.Add(Me.txtTotAmt)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.HiddenItems.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlGroup12, Me.LayoutControlGroup11})
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Margin = New System.Windows.Forms.Padding(15)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(1595, 556, 936, 1049)
        Me.LayoutControl1.Root = Me.Root
        Me.LayoutControl1.Size = New System.Drawing.Size(1353, 961)
        Me.LayoutControl1.TabIndex = 3
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'LblMsg
        '
        Me.LblMsg.Appearance.Font = New System.Drawing.Font("Tahoma", 8.142858!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.LblMsg.Appearance.ForeColor = System.Drawing.Color.Red
        Me.LblMsg.Appearance.Options.UseFont = True
        Me.LblMsg.Appearance.Options.UseForeColor = True
        Me.LblMsg.Location = New System.Drawing.Point(12, 883)
        Me.LblMsg.Margin = New System.Windows.Forms.Padding(10)
        Me.LblMsg.Name = "LblMsg"
        Me.LblMsg.Size = New System.Drawing.Size(966, 19)
        Me.LblMsg.StyleController = Me.LayoutControl1
        Me.LblMsg.TabIndex = 107
        '
        'chkGenOffer
        '
        Me.chkGenOffer.EditValue = CType(0, Byte)
        Me.chkGenOffer.Location = New System.Drawing.Point(901, 56)
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
        Me.chkGenOffer.Size = New System.Drawing.Size(222, 27)
        Me.chkGenOffer.StyleController = Me.LayoutControl1
        Me.chkGenOffer.TabIndex = 106
        Me.chkGenOffer.Tag = "GenOffer,0,1,2"
        '
        'cmdOrder
        '
        Me.cmdOrder.ImageOptions.Image = Global.DreamyKitchenCRM.My.Resources.Resources.icons8_purchase_order_24
        Me.cmdOrder.Location = New System.Drawing.Point(611, 917)
        Me.cmdOrder.Margin = New System.Windows.Forms.Padding(9, 10, 9, 10)
        Me.cmdOrder.Name = "cmdOrder"
        Me.cmdOrder.Size = New System.Drawing.Size(118, 32)
        Me.cmdOrder.StyleController = Me.LayoutControl1
        Me.cmdOrder.TabIndex = 105
        Me.cmdOrder.Text = "Παραγγελία"
        '
        'cmdPrivateAgreement
        '
        Me.cmdPrivateAgreement.ImageOptions.Image = Global.DreamyKitchenCRM.My.Resources.Resources.icons8_agreement_24
        Me.cmdPrivateAgreement.Location = New System.Drawing.Point(733, 917)
        Me.cmdPrivateAgreement.Margin = New System.Windows.Forms.Padding(9, 10, 9, 10)
        Me.cmdPrivateAgreement.Name = "cmdPrivateAgreement"
        Me.cmdPrivateAgreement.Size = New System.Drawing.Size(158, 32)
        Me.cmdPrivateAgreement.StyleController = Me.LayoutControl1
        Me.cmdPrivateAgreement.TabIndex = 104
        Me.cmdPrivateAgreement.Text = "Ιδ. Συμφωνητικό"
        '
        'cmdNewRecord
        '
        Me.cmdNewRecord.ImageOptions.Image = Global.DreamyKitchenCRM.My.Resources.Resources.icons8_new_document_24
        Me.cmdNewRecord.Location = New System.Drawing.Point(475, 917)
        Me.cmdNewRecord.Margin = New System.Windows.Forms.Padding(9, 10, 9, 10)
        Me.cmdNewRecord.Name = "cmdNewRecord"
        Me.cmdNewRecord.Size = New System.Drawing.Size(132, 32)
        Me.cmdNewRecord.StyleController = Me.LayoutControl1
        Me.cmdNewRecord.TabIndex = 103
        Me.cmdNewRecord.Text = "Νέα Εγγραφή"
        '
        'cmdCusCollection
        '
        Me.cmdCusCollection.ImageOptions.Image = CType(resources.GetObject("cmdCusCollection.ImageOptions.Image"), System.Drawing.Image)
        Me.cmdCusCollection.Location = New System.Drawing.Point(1221, 154)
        Me.cmdCusCollection.Margin = New System.Windows.Forms.Padding(10)
        Me.cmdCusCollection.Name = "cmdCusCollection"
        Me.cmdCusCollection.Size = New System.Drawing.Size(108, 32)
        Me.cmdCusCollection.StyleController = Me.LayoutControl1
        Me.cmdCusCollection.TabIndex = 101
        Me.cmdCusCollection.Text = "Είσπραξη"
        '
        'cmdCompCollection
        '
        Me.cmdCompCollection.ImageOptions.Image = CType(resources.GetObject("cmdCompCollection.ImageOptions.Image"), System.Drawing.Image)
        Me.cmdCompCollection.Location = New System.Drawing.Point(1221, 118)
        Me.cmdCompCollection.Margin = New System.Windows.Forms.Padding(10)
        Me.cmdCompCollection.Name = "cmdCompCollection"
        Me.cmdCompCollection.Size = New System.Drawing.Size(108, 32)
        Me.cmdCompCollection.StyleController = Me.LayoutControl1
        Me.cmdCompCollection.TabIndex = 100
        Me.cmdCompCollection.Text = "Είσπραξη"
        '
        'cboCompProject
        '
        Me.cboCompProject.Location = New System.Drawing.Point(821, 118)
        Me.cboCompProject.Margin = New System.Windows.Forms.Padding(15)
        Me.cboCompProject.Name = "cboCompProject"
        Me.cboCompProject.Properties.AllowMouseWheel = False
        Me.cboCompProject.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.cboCompProject.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Search), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Clear)})
        Me.cboCompProject.Properties.DisplayMember = "description"
        Me.cboCompProject.Properties.NullText = ""
        Me.cboCompProject.Properties.PopupWidthMode = DevExpress.XtraEditors.PopupWidthMode.ContentWidth
        Me.cboCompProject.Properties.ShowPopupButtons = DevExpress.Utils.DefaultBoolean.[True]
        Me.cboCompProject.Properties.ValueMember = "ID"
        Me.cboCompProject.Size = New System.Drawing.Size(396, 26)
        Me.cboCompProject.StyleController = Me.LayoutControl1
        Me.cboCompProject.TabIndex = 99
        Me.cboCompProject.Tag = "compTrashID,0,1,2"
        '
        'cboCompany
        '
        Me.cboCompany.Location = New System.Drawing.Point(226, 118)
        Me.cboCompany.Margin = New System.Windows.Forms.Padding(15)
        Me.cboCompany.Name = "cboCompany"
        Me.cboCompany.Properties.AllowMouseWheel = False
        Me.cboCompany.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.cboCompany.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Search), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Clear)})
        Me.cboCompany.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 94, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("code", "code", 150, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Fullname", "Όνομα", 253, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CouID", "Cou ID", 202, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("AreaID", "Area ID", 214, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("AdrID", "Adr ID", 193, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("SourceID", "Source ID", 271, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("SalerID", "Saler ID", 231, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("DoyID", "Doy ID", 202, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("PrfID", "Prf ID", 174, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("phn", "Τηλέφωνο", 133, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("mob", "mob", 142, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("fax", "fax", 111, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("email", "email", 160, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("afm", "afm", 127, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("cmt", "cmt", 127, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("modifiedBy", "modified By", 313, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("modifiedOn", "modified On", 321, DevExpress.Utils.FormatType.DateTime, "d/M/yyyy", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("createdOn", "created On", 298, DevExpress.Utils.FormatType.DateTime, "d/M/yyyy", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("name", "name", 169, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("RealName", "Real Name", 294, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("COU_Name", "COU_Name", 303, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("SRC_Name", "SRC_Name", 298, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("AREAS_Name", "AREAS_Name", 357, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ADR_Name", "ADR_Name", 303, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("PRF_Name", "PRF_Name", 294, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("SALERS_Name", "SALERS_Name", 381, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("color", "color", 150, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Ar", "Ar", 93, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("tk", "tk", 87, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("createdby_Realname", "createdby_Realname", 528, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("HasFiles", "Has Files", 243, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("createdBy", "created By", 285, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default])})
        Me.cboCompany.Properties.DataSource = Me.VwCOMPBindingSource
        Me.cboCompany.Properties.DisplayMember = "Fullname"
        Me.cboCompany.Properties.NullText = ""
        Me.cboCompany.Properties.PopupSizeable = False
        Me.cboCompany.Properties.ValueMember = "ID"
        Me.cboCompany.Size = New System.Drawing.Size(389, 26)
        Me.cboCompany.StyleController = Me.LayoutControl1
        Me.cboCompany.TabIndex = 98
        Me.cboCompany.Tag = "compID,0,1,2"
        '
        'chkofferAccepted
        '
        Me.chkofferAccepted.EditValue = CType(0, Byte)
        Me.chkofferAccepted.Location = New System.Drawing.Point(1127, 56)
        Me.chkofferAccepted.Margin = New System.Windows.Forms.Padding(15)
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
        Me.chkofferAccepted.Size = New System.Drawing.Size(202, 27)
        Me.chkofferAccepted.StyleController = Me.LayoutControl1
        Me.chkofferAccepted.TabIndex = 75
        Me.chkofferAccepted.Tag = "offerAccepted,0,1,2"
        '
        'chkVatVisible
        '
        Me.chkVatVisible.EditValue = CType(0, Byte)
        Me.chkVatVisible.Location = New System.Drawing.Point(125, 917)
        Me.chkVatVisible.Margin = New System.Windows.Forms.Padding(15)
        Me.chkVatVisible.Name = "chkVatVisible"
        Me.chkVatVisible.Properties.Caption = "Εμφάνιση ΦΠΑ στην εκτύπωση"
        Me.chkVatVisible.Properties.ValueChecked = CType(1, Byte)
        Me.chkVatVisible.Properties.ValueUnchecked = CType(0, Byte)
        Me.chkVatVisible.Size = New System.Drawing.Size(285, 27)
        Me.chkVatVisible.StyleController = Me.LayoutControl1
        Me.chkVatVisible.TabIndex = 64
        Me.chkVatVisible.Tag = "visibleVAT,0,1,2"
        '
        'cmdPrintOffer
        '
        Me.cmdPrintOffer.ImageOptions.Image = Global.DreamyKitchenCRM.My.Resources.Resources.icons8_print_24
        Me.cmdPrintOffer.Location = New System.Drawing.Point(12, 917)
        Me.cmdPrintOffer.Margin = New System.Windows.Forms.Padding(15)
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
        Me.lblDate.Location = New System.Drawing.Point(974, 190)
        Me.lblDate.Margin = New System.Windows.Forms.Padding(10)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(355, 22)
        Me.lblDate.StyleController = Me.LayoutControl1
        Me.lblDate.TabIndex = 51
        Me.lblDate.Text = "Ημερομηνία Παράδοσης: (ΗΗ/ΜΜ/ΕΕΕ)"
        '
        'txtdtdaysOfDelivery
        '
        Me.txtdtdaysOfDelivery.EditValue = "0"
        Me.txtdtdaysOfDelivery.Location = New System.Drawing.Point(821, 190)
        Me.txtdtdaysOfDelivery.Margin = New System.Windows.Forms.Padding(15)
        Me.txtdtdaysOfDelivery.Name = "txtdtdaysOfDelivery"
        Me.txtdtdaysOfDelivery.Properties.MaskSettings.Set("MaskManagerType", GetType(DevExpress.Data.Mask.NumericMaskManager))
        Me.txtdtdaysOfDelivery.Properties.MaskSettings.Set("mask", "d")
        Me.txtdtdaysOfDelivery.Properties.MaskSettings.Set("valueAfterDelete", DevExpress.Data.Mask.NumericMaskManager.ValueAfterDelete.ZeroThenNull)
        Me.txtdtdaysOfDelivery.Properties.MaskSettings.Set("valueType", GetType(Integer))
        Me.txtdtdaysOfDelivery.Properties.UseMaskAsDisplayFormat = True
        Me.txtdtdaysOfDelivery.Properties.UseReadOnlyAppearance = False
        Me.txtdtdaysOfDelivery.Size = New System.Drawing.Size(149, 26)
        Me.txtdtdaysOfDelivery.StyleController = Me.LayoutControl1
        Me.txtdtdaysOfDelivery.TabIndex = 50
        Me.txtdtdaysOfDelivery.Tag = "daysofdeliver,0,1,2"
        '
        'cmdSave
        '
        Me.cmdSave.ImageOptions.Image = CType(resources.GetObject("cmdSave.ImageOptions.Image"), System.Drawing.Image)
        Me.cmdSave.Location = New System.Drawing.Point(1123, 917)
        Me.cmdSave.Margin = New System.Windows.Forms.Padding(15)
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
        Me.cmdExit.Location = New System.Drawing.Point(1252, 917)
        Me.cmdExit.Margin = New System.Windows.Forms.Padding(15)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(89, 32)
        Me.cmdExit.StyleController = Me.LayoutControl1
        Me.cmdExit.TabIndex = 21
        Me.cmdExit.Text = "Έξοδος"
        '
        'cboCUS
        '
        Me.cboCUS.Location = New System.Drawing.Point(226, 154)
        Me.cboCUS.Margin = New System.Windows.Forms.Padding(15)
        Me.cboCUS.Name = "cboCUS"
        Me.cboCUS.Properties.AllowMouseWheel = False
        Me.cboCUS.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.cboCUS.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Search), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Clear)})
        Me.cboCUS.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 94, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("code", "code", 150, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Fullname", "Όνομα", 253, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CouID", "Cou ID", 202, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("AreaID", "Area ID", 214, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("AdrID", "Adr ID", 193, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("SourceID", "Source ID", 271, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("SalerID", "Saler ID", 231, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("DoyID", "Doy ID", 202, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("PrfID", "Prf ID", 174, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("phn", "Τηλέφωνο", 133, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("mob", "mob", 142, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("fax", "fax", 111, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("email", "email", 160, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("afm", "afm", 127, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("cmt", "cmt", 127, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("modifiedBy", "modified By", 313, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("modifiedOn", "modified On", 321, DevExpress.Utils.FormatType.DateTime, "d/M/yyyy", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("createdOn", "created On", 298, DevExpress.Utils.FormatType.DateTime, "d/M/yyyy", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("name", "name", 169, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("RealName", "Real Name", 294, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("COU_Name", "COU_Name", 303, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("SRC_Name", "SRC_Name", 298, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("AREAS_Name", "AREAS_Name", 357, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ADR_Name", "ADR_Name", 303, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("PRF_Name", "PRF_Name", 294, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("SALERS_Name", "SALERS_Name", 381, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("color", "color", 150, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Ar", "Ar", 93, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("tk", "tk", 87, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("createdby_Realname", "createdby_Realname", 528, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("HasFiles", "Has Files", 243, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("createdBy", "created By", 285, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default])})
        Me.cboCUS.Properties.DataSource = Me.VwCCTBindingSource
        Me.cboCUS.Properties.DisplayMember = "Fullname"
        Me.cboCUS.Properties.NullText = ""
        Me.cboCUS.Properties.PopupSizeable = False
        Me.cboCUS.Properties.ValueMember = "ID"
        Me.cboCUS.Size = New System.Drawing.Size(389, 26)
        Me.cboCUS.StyleController = Me.LayoutControl1
        Me.cboCUS.TabIndex = 5
        Me.cboCUS.Tag = "cusID,0,1,2"
        '
        'txtarProt
        '
        Me.txtarProt.Location = New System.Drawing.Point(226, 56)
        Me.txtarProt.Margin = New System.Windows.Forms.Padding(15)
        Me.txtarProt.Name = "txtarProt"
        Me.txtarProt.Properties.Appearance.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.txtarProt.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtarProt.Properties.Appearance.Options.UseBackColor = True
        Me.txtarProt.Properties.Appearance.Options.UseFont = True
        Me.txtarProt.Properties.ReadOnly = True
        Me.txtarProt.Size = New System.Drawing.Size(117, 28)
        Me.txtarProt.StyleController = Me.LayoutControl1
        Me.txtarProt.TabIndex = 4
        Me.txtarProt.Tag = "arProt,0,1,2"
        '
        'dtpresentation
        '
        Me.dtpresentation.EditValue = Nothing
        Me.dtpresentation.Location = New System.Drawing.Point(226, 190)
        Me.dtpresentation.Margin = New System.Windows.Forms.Padding(15)
        Me.dtpresentation.Name = "dtpresentation"
        Me.dtpresentation.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtpresentation.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtpresentation.Size = New System.Drawing.Size(389, 26)
        Me.dtpresentation.StyleController = Me.LayoutControl1
        Me.dtpresentation.TabIndex = 32
        Me.dtpresentation.Tag = "dtOffer,0,1,2"
        '
        'txtDimension1
        '
        Me.txtDimension1.Location = New System.Drawing.Point(706, 575)
        Me.txtDimension1.Margin = New System.Windows.Forms.Padding(15)
        Me.txtDimension1.Name = "txtDimension1"
        Me.txtDimension1.Properties.UseReadOnlyAppearance = False
        Me.txtDimension1.Size = New System.Drawing.Size(611, 26)
        Me.txtDimension1.StyleController = Me.LayoutControl1
        Me.txtDimension1.TabIndex = 10
        Me.txtDimension1.Tag = "dimension1,0,1,2"
        '
        'txtDimension2
        '
        Me.txtDimension2.Location = New System.Drawing.Point(706, 575)
        Me.txtDimension2.Margin = New System.Windows.Forms.Padding(15)
        Me.txtDimension2.Name = "txtDimension2"
        Me.txtDimension2.Properties.UseReadOnlyAppearance = False
        Me.txtDimension2.Size = New System.Drawing.Size(611, 26)
        Me.txtDimension2.StyleController = Me.LayoutControl1
        Me.txtDimension2.TabIndex = 10
        Me.txtDimension2.Tag = "dimension2,0,1,2"
        '
        'txtDimension3
        '
        Me.txtDimension3.Location = New System.Drawing.Point(706, 575)
        Me.txtDimension3.Margin = New System.Windows.Forms.Padding(15)
        Me.txtDimension3.Name = "txtDimension3"
        Me.txtDimension3.Properties.UseReadOnlyAppearance = False
        Me.txtDimension3.Size = New System.Drawing.Size(611, 26)
        Me.txtDimension3.StyleController = Me.LayoutControl1
        Me.txtDimension3.TabIndex = 10
        Me.txtDimension3.Tag = "dimension3,0,1,2"
        '
        'txtDimension4
        '
        Me.txtDimension4.Location = New System.Drawing.Point(706, 575)
        Me.txtDimension4.Margin = New System.Windows.Forms.Padding(15)
        Me.txtDimension4.Name = "txtDimension4"
        Me.txtDimension4.Properties.UseReadOnlyAppearance = False
        Me.txtDimension4.Size = New System.Drawing.Size(611, 26)
        Me.txtDimension4.StyleController = Me.LayoutControl1
        Me.txtDimension4.TabIndex = 10
        Me.txtDimension4.Tag = "dimension4,0,1,2"
        '
        'txtDimension8
        '
        Me.txtDimension8.Location = New System.Drawing.Point(706, 575)
        Me.txtDimension8.Margin = New System.Windows.Forms.Padding(15)
        Me.txtDimension8.Name = "txtDimension8"
        Me.txtDimension8.Properties.UseReadOnlyAppearance = False
        Me.txtDimension8.Size = New System.Drawing.Size(611, 26)
        Me.txtDimension8.StyleController = Me.LayoutControl1
        Me.txtDimension8.TabIndex = 10
        Me.txtDimension8.Tag = "dimension6,0,1,2"
        '
        'txtDimension5
        '
        Me.txtDimension5.Location = New System.Drawing.Point(706, 575)
        Me.txtDimension5.Margin = New System.Windows.Forms.Padding(15)
        Me.txtDimension5.Name = "txtDimension5"
        Me.txtDimension5.Properties.UseReadOnlyAppearance = False
        Me.txtDimension5.Size = New System.Drawing.Size(611, 26)
        Me.txtDimension5.StyleController = Me.LayoutControl1
        Me.txtDimension5.TabIndex = 44
        Me.txtDimension5.Tag = "dimension5,0,1,2"
        '
        'txtTotalDoorsVat
        '
        Me.txtTotalDoorsVat.EditValue = "0,00 €"
        Me.txtTotalDoorsVat.Location = New System.Drawing.Point(1186, 807)
        Me.txtTotalDoorsVat.Margin = New System.Windows.Forms.Padding(15)
        Me.txtTotalDoorsVat.Name = "txtTotalDoorsVat"
        Me.txtTotalDoorsVat.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.txtTotalDoorsVat.Properties.Appearance.Options.UseForeColor = True
        Me.txtTotalDoorsVat.Properties.DisplayFormat.FormatString = "c"
        Me.txtTotalDoorsVat.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtTotalDoorsVat.Properties.EditFormat.FormatString = "n2"
        Me.txtTotalDoorsVat.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtTotalDoorsVat.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtTotalDoorsVat.Properties.MaskSettings.Set("MaskManagerType", GetType(DevExpress.Data.Mask.NumericMaskManager))
        Me.txtTotalDoorsVat.Properties.MaskSettings.Set("mask", "c2")
        Me.txtTotalDoorsVat.Properties.ReadOnly = True
        Me.txtTotalDoorsVat.Properties.Tag = "BenchExtraPrice"
        Me.txtTotalDoorsVat.Properties.UseReadOnlyAppearance = False
        Me.txtTotalDoorsVat.Size = New System.Drawing.Size(143, 26)
        Me.txtTotalDoorsVat.StyleController = Me.LayoutControl1
        Me.txtTotalDoorsVat.TabIndex = 42
        Me.txtTotalDoorsVat.Tag = "TotalVatPrice,0,1,2"
        Me.txtTotalDoorsVat.Visible = False
        '
        'cboEMP
        '
        Me.cboEMP.Location = New System.Drawing.Point(226, 88)
        Me.cboEMP.Margin = New System.Windows.Forms.Padding(15)
        Me.cboEMP.Name = "cboEMP"
        Me.cboEMP.Properties.AllowMouseWheel = False
        Me.cboEMP.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.cboEMP.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Search), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Clear)})
        Me.cboEMP.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 94, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("code", "code", 150, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("color", "color", 150, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("RealName", "Real Name", 294, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("name", "Πωλητής", 169, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default])})
        Me.cboEMP.Properties.DataSource = Me.VwSALERSBindingSource
        Me.cboEMP.Properties.DisplayMember = "name"
        Me.cboEMP.Properties.NullText = ""
        Me.cboEMP.Properties.PopupSizeable = False
        Me.cboEMP.Properties.ValueMember = "ID"
        Me.cboEMP.Size = New System.Drawing.Size(1103, 26)
        Me.cboEMP.StyleController = Me.LayoutControl1
        Me.cboEMP.TabIndex = 5
        Me.cboEMP.Tag = "empID,0,1,2"
        '
        'cboFora1
        '
        Me.cboFora1.Location = New System.Drawing.Point(36, 625)
        Me.cboFora1.Margin = New System.Windows.Forms.Padding(15)
        Me.cboFora1.Name = "cboFora1"
        Me.cboFora1.Properties.AllowMouseWheel = False
        Me.cboFora1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Clear)})
        Me.cboFora1.Properties.Items.AddRange(New Object() {"ΑΡΙΣΤΕΡΗ", "ΔΕΞΙΑ", "ΚΑΣΑ"})
        Me.cboFora1.Properties.Tag = "String"
        Me.cboFora1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboFora1.Size = New System.Drawing.Size(243, 26)
        Me.cboFora1.StyleController = Me.LayoutControl1
        Me.cboFora1.TabIndex = 47
        Me.cboFora1.Tag = "fora1,0,1,2"
        '
        'cboFora2
        '
        Me.cboFora2.Location = New System.Drawing.Point(36, 625)
        Me.cboFora2.Margin = New System.Windows.Forms.Padding(15)
        Me.cboFora2.Name = "cboFora2"
        Me.cboFora2.Properties.AllowMouseWheel = False
        Me.cboFora2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Clear)})
        Me.cboFora2.Properties.Items.AddRange(New Object() {"ΑΡΙΣΤΕΡΗ", "ΔΕΞΙΑ", "ΚΑΣΑ"})
        Me.cboFora2.Properties.Tag = "String"
        Me.cboFora2.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboFora2.Size = New System.Drawing.Size(243, 26)
        Me.cboFora2.StyleController = Me.LayoutControl1
        Me.cboFora2.TabIndex = 47
        Me.cboFora2.Tag = "fora2,0,1,2"
        '
        'cboFora3
        '
        Me.cboFora3.Location = New System.Drawing.Point(36, 625)
        Me.cboFora3.Margin = New System.Windows.Forms.Padding(15)
        Me.cboFora3.Name = "cboFora3"
        Me.cboFora3.Properties.AllowMouseWheel = False
        Me.cboFora3.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Clear)})
        Me.cboFora3.Properties.Items.AddRange(New Object() {"ΑΡΙΣΤΕΡΗ", "ΔΕΞΙΑ", "ΚΑΣΑ"})
        Me.cboFora3.Properties.Tag = "String"
        Me.cboFora3.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboFora3.Size = New System.Drawing.Size(243, 26)
        Me.cboFora3.StyleController = Me.LayoutControl1
        Me.cboFora3.TabIndex = 47
        Me.cboFora3.Tag = "fora3,0,1,2"
        '
        'cboFora4
        '
        Me.cboFora4.Location = New System.Drawing.Point(36, 625)
        Me.cboFora4.Margin = New System.Windows.Forms.Padding(15)
        Me.cboFora4.Name = "cboFora4"
        Me.cboFora4.Properties.AllowMouseWheel = False
        Me.cboFora4.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Clear)})
        Me.cboFora4.Properties.Items.AddRange(New Object() {"ΑΡΙΣΤΕΡΗ", "ΔΕΞΙΑ", "ΚΑΣΑ"})
        Me.cboFora4.Properties.Tag = "String"
        Me.cboFora4.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboFora4.Size = New System.Drawing.Size(243, 26)
        Me.cboFora4.StyleController = Me.LayoutControl1
        Me.cboFora4.TabIndex = 47
        Me.cboFora4.Tag = "fora4,0,1,2"
        '
        'cboFora5
        '
        Me.cboFora5.Location = New System.Drawing.Point(36, 625)
        Me.cboFora5.Margin = New System.Windows.Forms.Padding(15)
        Me.cboFora5.Name = "cboFora5"
        Me.cboFora5.Properties.AllowMouseWheel = False
        Me.cboFora5.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Clear)})
        Me.cboFora5.Properties.Items.AddRange(New Object() {"ΑΡΙΣΤΕΡΗ", "ΔΕΞΙΑ", "ΚΑΣΑ"})
        Me.cboFora5.Properties.Tag = "String"
        Me.cboFora5.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboFora5.Size = New System.Drawing.Size(243, 26)
        Me.cboFora5.StyleController = Me.LayoutControl1
        Me.cboFora5.TabIndex = 47
        Me.cboFora5.Tag = "fora5,0,1,2"
        '
        'cboFora6
        '
        Me.cboFora6.Location = New System.Drawing.Point(36, 625)
        Me.cboFora6.Margin = New System.Windows.Forms.Padding(15)
        Me.cboFora6.Name = "cboFora6"
        Me.cboFora6.Properties.AllowMouseWheel = False
        Me.cboFora6.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Clear)})
        Me.cboFora6.Properties.Items.AddRange(New Object() {"ΑΡΙΣΤΕΡΗ", "ΔΕΞΙΑ", "ΚΑΣΑ"})
        Me.cboFora6.Properties.Tag = "String"
        Me.cboFora6.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboFora6.Size = New System.Drawing.Size(243, 26)
        Me.cboFora6.StyleController = Me.LayoutControl1
        Me.cboFora6.TabIndex = 47
        Me.cboFora6.Tag = "fora6,0,1,2"
        '
        'cboKasa1
        '
        Me.cboKasa1.Location = New System.Drawing.Point(283, 575)
        Me.cboKasa1.Margin = New System.Windows.Forms.Padding(15)
        Me.cboKasa1.Name = "cboKasa1"
        Me.cboKasa1.Properties.AllowMouseWheel = False
        Me.cboKasa1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Clear)})
        Me.cboKasa1.Properties.Items.AddRange(New Object() {"13", "15", "18", "24"})
        Me.cboKasa1.Properties.Tag = "String"
        Me.cboKasa1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboKasa1.Size = New System.Drawing.Size(419, 26)
        Me.cboKasa1.StyleController = Me.LayoutControl1
        Me.cboKasa1.TabIndex = 47
        Me.cboKasa1.Tag = "kasa1,0,1,2"
        '
        'cboKasa2
        '
        Me.cboKasa2.Location = New System.Drawing.Point(283, 575)
        Me.cboKasa2.Margin = New System.Windows.Forms.Padding(15)
        Me.cboKasa2.Name = "cboKasa2"
        Me.cboKasa2.Properties.AllowMouseWheel = False
        Me.cboKasa2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Clear)})
        Me.cboKasa2.Properties.Items.AddRange(New Object() {"13", "15", "18", "24"})
        Me.cboKasa2.Properties.Tag = "String"
        Me.cboKasa2.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboKasa2.Size = New System.Drawing.Size(419, 26)
        Me.cboKasa2.StyleController = Me.LayoutControl1
        Me.cboKasa2.TabIndex = 47
        Me.cboKasa2.Tag = "kasa2,0,1,2"
        '
        'cboKasa3
        '
        Me.cboKasa3.Location = New System.Drawing.Point(283, 575)
        Me.cboKasa3.Margin = New System.Windows.Forms.Padding(15)
        Me.cboKasa3.Name = "cboKasa3"
        Me.cboKasa3.Properties.AllowMouseWheel = False
        Me.cboKasa3.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Clear)})
        Me.cboKasa3.Properties.Items.AddRange(New Object() {"13", "15", "18", "24"})
        Me.cboKasa3.Properties.Tag = "String"
        Me.cboKasa3.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboKasa3.Size = New System.Drawing.Size(419, 26)
        Me.cboKasa3.StyleController = Me.LayoutControl1
        Me.cboKasa3.TabIndex = 47
        Me.cboKasa3.Tag = "kasa3,0,1,2"
        '
        'cboKasa4
        '
        Me.cboKasa4.Location = New System.Drawing.Point(283, 575)
        Me.cboKasa4.Margin = New System.Windows.Forms.Padding(15)
        Me.cboKasa4.Name = "cboKasa4"
        Me.cboKasa4.Properties.AllowMouseWheel = False
        Me.cboKasa4.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Clear)})
        Me.cboKasa4.Properties.Items.AddRange(New Object() {"13", "15", "18", "24"})
        Me.cboKasa4.Properties.Tag = "String"
        Me.cboKasa4.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboKasa4.Size = New System.Drawing.Size(419, 26)
        Me.cboKasa4.StyleController = Me.LayoutControl1
        Me.cboKasa4.TabIndex = 47
        Me.cboKasa4.Tag = "kasa4,0,1,2"
        '
        'cboKasa5
        '
        Me.cboKasa5.Location = New System.Drawing.Point(283, 575)
        Me.cboKasa5.Margin = New System.Windows.Forms.Padding(15)
        Me.cboKasa5.Name = "cboKasa5"
        Me.cboKasa5.Properties.AllowMouseWheel = False
        Me.cboKasa5.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Clear)})
        Me.cboKasa5.Properties.Items.AddRange(New Object() {"13", "15", "18", "24"})
        Me.cboKasa5.Properties.Tag = "String"
        Me.cboKasa5.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboKasa5.Size = New System.Drawing.Size(419, 26)
        Me.cboKasa5.StyleController = Me.LayoutControl1
        Me.cboKasa5.TabIndex = 47
        Me.cboKasa5.Tag = "kasa5,0,1,2"
        '
        'cboKasa6
        '
        Me.cboKasa6.Location = New System.Drawing.Point(283, 575)
        Me.cboKasa6.Margin = New System.Windows.Forms.Padding(15)
        Me.cboKasa6.Name = "cboKasa6"
        Me.cboKasa6.Properties.AllowMouseWheel = False
        Me.cboKasa6.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Clear)})
        Me.cboKasa6.Properties.Items.AddRange(New Object() {"13", "15", "18", "24"})
        Me.cboKasa6.Properties.Tag = "String"
        Me.cboKasa6.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboKasa6.Size = New System.Drawing.Size(419, 26)
        Me.cboKasa6.StyleController = Me.LayoutControl1
        Me.cboKasa6.TabIndex = 47
        Me.cboKasa6.Tag = "kasa6,0,1,2"
        '
        'txtDescription
        '
        Me.txtDescription.Location = New System.Drawing.Point(24, 296)
        Me.txtDescription.Margin = New System.Windows.Forms.Padding(15)
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(437, 154)
        Me.txtDescription.StyleController = Me.LayoutControl1
        Me.txtDescription.TabIndex = 17
        Me.txtDescription.Tag = "description,0,1,2"
        '
        'txtComments
        '
        Me.txtComments.Location = New System.Drawing.Point(465, 296)
        Me.txtComments.Margin = New System.Windows.Forms.Padding(15)
        Me.txtComments.Name = "txtComments"
        Me.txtComments.Size = New System.Drawing.Size(439, 154)
        Me.txtComments.StyleController = Me.LayoutControl1
        Me.txtComments.TabIndex = 17
        Me.txtComments.Tag = "cmt,0,1,2"
        '
        'txtKnobs1
        '
        Me.txtKnobs1.Location = New System.Drawing.Point(706, 625)
        Me.txtKnobs1.Margin = New System.Windows.Forms.Padding(15)
        Me.txtKnobs1.Name = "txtKnobs1"
        Me.txtKnobs1.Properties.UseReadOnlyAppearance = False
        Me.txtKnobs1.Size = New System.Drawing.Size(611, 26)
        Me.txtKnobs1.StyleController = Me.LayoutControl1
        Me.txtKnobs1.TabIndex = 44
        Me.txtKnobs1.Tag = "knobs,0,1,2"
        '
        'txtTotalDoorsPrice
        '
        Me.txtTotalDoorsPrice.EditValue = "0,00 €"
        Me.txtTotalDoorsPrice.Location = New System.Drawing.Point(1186, 837)
        Me.txtTotalDoorsPrice.Margin = New System.Windows.Forms.Padding(15)
        Me.txtTotalDoorsPrice.Name = "txtTotalDoorsPrice"
        Me.txtTotalDoorsPrice.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.txtTotalDoorsPrice.Properties.Appearance.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.txtTotalDoorsPrice.Properties.Appearance.Options.UseFont = True
        Me.txtTotalDoorsPrice.Properties.Appearance.Options.UseForeColor = True
        Me.txtTotalDoorsPrice.Properties.DisplayFormat.FormatString = "c"
        Me.txtTotalDoorsPrice.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtTotalDoorsPrice.Properties.EditFormat.FormatString = "n2"
        Me.txtTotalDoorsPrice.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtTotalDoorsPrice.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtTotalDoorsPrice.Properties.MaskSettings.Set("MaskManagerType", GetType(DevExpress.Data.Mask.NumericMaskManager))
        Me.txtTotalDoorsPrice.Properties.MaskSettings.Set("mask", "c2")
        Me.txtTotalDoorsPrice.Properties.ReadOnly = True
        Me.txtTotalDoorsPrice.Properties.Tag = "BenchExtraPrice"
        Me.txtTotalDoorsPrice.Properties.UseReadOnlyAppearance = False
        Me.txtTotalDoorsPrice.Size = New System.Drawing.Size(143, 30)
        Me.txtTotalDoorsPrice.StyleController = Me.LayoutControl1
        Me.txtTotalDoorsPrice.TabIndex = 42
        Me.txtTotalDoorsPrice.Tag = "TotalPrice,0,1,2"
        Me.txtTotalDoorsPrice.Visible = False
        '
        'txtNotes
        '
        Me.txtNotes.Location = New System.Drawing.Point(908, 296)
        Me.txtNotes.Margin = New System.Windows.Forms.Padding(15)
        Me.txtNotes.Name = "txtNotes"
        Me.txtNotes.Size = New System.Drawing.Size(421, 154)
        Me.txtNotes.StyleController = Me.LayoutControl1
        Me.txtNotes.TabIndex = 17
        Me.txtNotes.Tag = "notes,0,1,2"
        '
        'cboTRANSH
        '
        Me.cboTRANSH.Location = New System.Drawing.Point(821, 154)
        Me.cboTRANSH.Margin = New System.Windows.Forms.Padding(15)
        Me.cboTRANSH.Name = "cboTRANSH"
        Me.cboTRANSH.Properties.AllowMouseWheel = False
        Me.cboTRANSH.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.cboTRANSH.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Search), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Clear)})
        Me.cboTRANSH.Properties.DisplayMember = "description"
        Me.cboTRANSH.Properties.NullText = ""
        Me.cboTRANSH.Properties.PopupWidthMode = DevExpress.XtraEditors.PopupWidthMode.ContentWidth
        Me.cboTRANSH.Properties.ShowPopupButtons = DevExpress.Utils.DefaultBoolean.[True]
        Me.cboTRANSH.Properties.ValueMember = "ID"
        Me.cboTRANSH.Size = New System.Drawing.Size(396, 26)
        Me.cboTRANSH.StyleController = Me.LayoutControl1
        Me.cboTRANSH.TabIndex = 6
        Me.cboTRANSH.Tag = "transhID,0,1,2"
        '
        'txtExtraInst
        '
        Me.txtExtraInst.EditValue = "0,00 €"
        Me.txtExtraInst.Location = New System.Drawing.Point(835, 807)
        Me.txtExtraInst.Margin = New System.Windows.Forms.Padding(15)
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
        Me.txtExtraInst.Size = New System.Drawing.Size(145, 26)
        Me.txtExtraInst.StyleController = Me.LayoutControl1
        Me.txtExtraInst.TabIndex = 42
        Me.txtExtraInst.Tag = "ExtraInst,0,1,2"
        Me.txtExtraInst.Visible = False
        '
        'txtPartofVat
        '
        Me.txtPartofVat.EditValue = "0,00 €"
        Me.txtPartofVat.Location = New System.Drawing.Point(1186, 773)
        Me.txtPartofVat.Margin = New System.Windows.Forms.Padding(15)
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
        Me.txtPartofVat.Size = New System.Drawing.Size(143, 30)
        Me.txtPartofVat.StyleController = Me.LayoutControl1
        Me.txtPartofVat.TabIndex = 42
        Me.txtPartofVat.Tag = "PartOfVat,0,1,2"
        Me.txtPartofVat.Visible = False
        '
        'cboType1
        '
        Me.cboType1.Location = New System.Drawing.Point(36, 575)
        Me.cboType1.Margin = New System.Windows.Forms.Padding(15)
        Me.cboType1.Name = "cboType1"
        Me.cboType1.Properties.AllowMouseWheel = False
        Me.cboType1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Clear)})
        Me.cboType1.Properties.Items.AddRange(New Object() {"ΑΝΟΙΓΟΜΕΝΗ", "ΣΥΡΟΜΕΝΗ", "ΠΑΤΑΡΙ"})
        Me.cboType1.Properties.Tag = "String"
        Me.cboType1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboType1.Size = New System.Drawing.Size(243, 26)
        Me.cboType1.StyleController = Me.LayoutControl1
        Me.cboType1.TabIndex = 47
        Me.cboType1.Tag = "doorType1,0,1,2"
        '
        'cboType2
        '
        Me.cboType2.Location = New System.Drawing.Point(36, 575)
        Me.cboType2.Margin = New System.Windows.Forms.Padding(15)
        Me.cboType2.Name = "cboType2"
        Me.cboType2.Properties.AllowMouseWheel = False
        Me.cboType2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Clear)})
        Me.cboType2.Properties.Items.AddRange(New Object() {"ΑΝΟΙΓΟΜΕΝΗ", "ΣΥΡΟΜΕΝΗ", "ΠΑΤΑΡΙ"})
        Me.cboType2.Properties.Tag = "String"
        Me.cboType2.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboType2.Size = New System.Drawing.Size(243, 26)
        Me.cboType2.StyleController = Me.LayoutControl1
        Me.cboType2.TabIndex = 47
        Me.cboType2.Tag = "doorType2,0,1,2"
        '
        'cboType3
        '
        Me.cboType3.Location = New System.Drawing.Point(36, 575)
        Me.cboType3.Margin = New System.Windows.Forms.Padding(15)
        Me.cboType3.Name = "cboType3"
        Me.cboType3.Properties.AllowMouseWheel = False
        Me.cboType3.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Clear)})
        Me.cboType3.Properties.Items.AddRange(New Object() {"ΑΝΟΙΓΟΜΕΝΗ", "ΣΥΡΟΜΕΝΗ", "ΠΑΤΑΡΙ"})
        Me.cboType3.Properties.Tag = "String"
        Me.cboType3.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboType3.Size = New System.Drawing.Size(243, 26)
        Me.cboType3.StyleController = Me.LayoutControl1
        Me.cboType3.TabIndex = 47
        Me.cboType3.Tag = "doorType3,0,1,2"
        '
        'cboType4
        '
        Me.cboType4.Location = New System.Drawing.Point(36, 575)
        Me.cboType4.Margin = New System.Windows.Forms.Padding(15)
        Me.cboType4.Name = "cboType4"
        Me.cboType4.Properties.AllowMouseWheel = False
        Me.cboType4.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Clear)})
        Me.cboType4.Properties.Items.AddRange(New Object() {"ΑΝΟΙΓΟΜΕΝΗ", "ΣΥΡΟΜΕΝΗ", "ΠΑΤΑΡΙ"})
        Me.cboType4.Properties.Tag = "String"
        Me.cboType4.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboType4.Size = New System.Drawing.Size(243, 26)
        Me.cboType4.StyleController = Me.LayoutControl1
        Me.cboType4.TabIndex = 47
        Me.cboType4.Tag = "doorType4,0,1,2"
        '
        'cboType5
        '
        Me.cboType5.Location = New System.Drawing.Point(36, 575)
        Me.cboType5.Margin = New System.Windows.Forms.Padding(15)
        Me.cboType5.Name = "cboType5"
        Me.cboType5.Properties.AllowMouseWheel = False
        Me.cboType5.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Clear)})
        Me.cboType5.Properties.Items.AddRange(New Object() {"ΑΝΟΙΓΟΜΕΝΗ", "ΣΥΡΟΜΕΝΗ", "ΠΑΤΑΡΙ"})
        Me.cboType5.Properties.Tag = "String"
        Me.cboType5.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboType5.Size = New System.Drawing.Size(243, 26)
        Me.cboType5.StyleController = Me.LayoutControl1
        Me.cboType5.TabIndex = 47
        Me.cboType5.Tag = "doorType5,0,1,2"
        '
        'cboType6
        '
        Me.cboType6.Location = New System.Drawing.Point(36, 575)
        Me.cboType6.Margin = New System.Windows.Forms.Padding(15)
        Me.cboType6.Name = "cboType6"
        Me.cboType6.Properties.AllowMouseWheel = False
        Me.cboType6.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Clear)})
        Me.cboType6.Properties.Items.AddRange(New Object() {"ΑΝΟΙΓΟΜΕΝΗ", "ΣΥΡΟΜΕΝΗ", "ΠΑΤΑΡΙ"})
        Me.cboType6.Properties.Tag = "String"
        Me.cboType6.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboType6.Size = New System.Drawing.Size(243, 26)
        Me.cboType6.StyleController = Me.LayoutControl1
        Me.cboType6.TabIndex = 47
        Me.cboType6.Tag = "doorType6,0,1,2"
        '
        'cboValueListItem
        '
        Me.cboValueListItem.Location = New System.Drawing.Point(283, 625)
        Me.cboValueListItem.Margin = New System.Windows.Forms.Padding(15)
        Me.cboValueListItem.Name = "cboValueListItem"
        Me.cboValueListItem.Properties.AllowMouseWheel = False
        Me.cboValueListItem.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.cboValueListItem.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Search), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Clear)})
        Me.cboValueListItem.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Modifier", "Modifier", 225, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 94, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("code", "code", 150, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CustomCode", "Κωδικός", 343, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("name", "Περιγραφή", 169, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("cat", "cat", 111, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("color", "color", 150, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Price", "Price", 150, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("comments", "comments", 280, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("modifiedBy", "modified By", 313, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("modifiedOn", "modified On", 321, DevExpress.Utils.FormatType.DateTime, "d/M/yyyy", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("createdOn", "created On", 298, DevExpress.Utils.FormatType.DateTime, "d/M/yyyy", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("createdBy", "created By", 285, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("doorColorID", "door Color ID", 348, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ColorName", "Color Name", 307, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("typeDescr", "type Descr", 285, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("type", "type", 142, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("valueListItem", "door Type", 274, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("kasa", "kasa", 142, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("dimName", "dim Name", 280, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("dimID", "dim ID", 196, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("valueListID", "door Cat ID", 307, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("valueListName", "door Cat Name", 391, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("closetType", "closet Type", 298, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("description", "Κατηγορία", 294, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default])})
        Me.cboValueListItem.Properties.DataSource = Me.VwVALUELISTITEMV2BindingSource
        Me.cboValueListItem.Properties.DisplayMember = "name"
        Me.cboValueListItem.Properties.NullText = ""
        Me.cboValueListItem.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.cboValueListItem.Properties.PopupFormMinSize = New System.Drawing.Size(2205, 1517)
        Me.cboValueListItem.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoSuggest
        Me.cboValueListItem.Properties.ValueMember = "ID"
        Me.cboValueListItem.Size = New System.Drawing.Size(419, 26)
        Me.cboValueListItem.StyleController = Me.LayoutControl1
        Me.cboValueListItem.TabIndex = 49
        Me.cboValueListItem.Tag = "DoorTypeID,0,1,2"
        '
        'cboVALUELISTITEM2
        '
        Me.cboVALUELISTITEM2.Location = New System.Drawing.Point(283, 625)
        Me.cboVALUELISTITEM2.Margin = New System.Windows.Forms.Padding(15)
        Me.cboVALUELISTITEM2.Name = "cboVALUELISTITEM2"
        Me.cboVALUELISTITEM2.Properties.AllowMouseWheel = False
        Me.cboVALUELISTITEM2.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.cboVALUELISTITEM2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Search), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Clear)})
        Me.cboVALUELISTITEM2.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Modifier", "Modifier", 225, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 94, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("code", "code", 150, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CustomCode", "Κωδικός", 343, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("name", "Περιγραφή", 169, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("cat", "cat", 111, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("color", "color", 150, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Price", "Price", 150, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("comments", "comments", 280, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("modifiedBy", "modified By", 313, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("modifiedOn", "modified On", 321, DevExpress.Utils.FormatType.DateTime, "d/M/yyyy", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("createdOn", "created On", 298, DevExpress.Utils.FormatType.DateTime, "d/M/yyyy", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("createdBy", "created By", 285, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("doorColorID", "door Color ID", 348, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ColorName", "Color Name", 307, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("typeDescr", "type Descr", 285, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("type", "type", 142, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("valueListItem", "door Type", 274, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("kasa", "kasa", 142, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("dimName", "dim Name", 280, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("dimID", "dim ID", 196, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("valueListID", "door Cat ID", 307, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("valueListName", "door Cat Name", 391, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("closetType", "closet Type", 298, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("description", "Κατηγορία", 294, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default])})
        Me.cboVALUELISTITEM2.Properties.DataSource = Me.VwVALUELISTITEMV2BindingSource
        Me.cboVALUELISTITEM2.Properties.DisplayMember = "name"
        Me.cboVALUELISTITEM2.Properties.NullText = ""
        Me.cboVALUELISTITEM2.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.cboVALUELISTITEM2.Properties.PopupSizeable = False
        Me.cboVALUELISTITEM2.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoSuggest
        Me.cboVALUELISTITEM2.Properties.ValueMember = "ID"
        Me.cboVALUELISTITEM2.Size = New System.Drawing.Size(419, 26)
        Me.cboVALUELISTITEM2.StyleController = Me.LayoutControl1
        Me.cboVALUELISTITEM2.TabIndex = 49
        Me.cboVALUELISTITEM2.Tag = "DoorTypeID2,0,1,2"
        '
        'cboVALUELISTITEM3
        '
        Me.cboVALUELISTITEM3.Location = New System.Drawing.Point(283, 625)
        Me.cboVALUELISTITEM3.Margin = New System.Windows.Forms.Padding(15)
        Me.cboVALUELISTITEM3.Name = "cboVALUELISTITEM3"
        Me.cboVALUELISTITEM3.Properties.AllowMouseWheel = False
        Me.cboVALUELISTITEM3.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.cboVALUELISTITEM3.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Search), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Clear)})
        Me.cboVALUELISTITEM3.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Modifier", "Modifier", 225, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 94, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("code", "code", 150, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CustomCode", "Κωδικός", 343, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("name", "Περιγραφή", 169, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("cat", "cat", 111, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("color", "color", 150, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Price", "Price", 150, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("comments", "comments", 280, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("modifiedBy", "modified By", 313, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("modifiedOn", "modified On", 321, DevExpress.Utils.FormatType.DateTime, "d/M/yyyy", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("createdOn", "created On", 298, DevExpress.Utils.FormatType.DateTime, "d/M/yyyy", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("createdBy", "created By", 285, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("doorColorID", "door Color ID", 348, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ColorName", "Color Name", 307, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("typeDescr", "type Descr", 285, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("type", "type", 142, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("valueListItem", "door Type", 274, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("kasa", "kasa", 142, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("dimName", "dim Name", 280, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("dimID", "dim ID", 196, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("valueListID", "door Cat ID", 307, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("valueListName", "door Cat Name", 391, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("closetType", "closet Type", 298, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("description", "Κατηγορία", 294, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default])})
        Me.cboVALUELISTITEM3.Properties.DataSource = Me.VwVALUELISTITEMV2BindingSource
        Me.cboVALUELISTITEM3.Properties.DisplayMember = "name"
        Me.cboVALUELISTITEM3.Properties.NullText = ""
        Me.cboVALUELISTITEM3.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.cboVALUELISTITEM3.Properties.PopupSizeable = False
        Me.cboVALUELISTITEM3.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoSuggest
        Me.cboVALUELISTITEM3.Properties.ValueMember = "ID"
        Me.cboVALUELISTITEM3.Size = New System.Drawing.Size(419, 26)
        Me.cboVALUELISTITEM3.StyleController = Me.LayoutControl1
        Me.cboVALUELISTITEM3.TabIndex = 49
        Me.cboVALUELISTITEM3.Tag = "doorTypeID3,0,1,2"
        '
        'cboVALUELISTITEM4
        '
        Me.cboVALUELISTITEM4.Location = New System.Drawing.Point(283, 625)
        Me.cboVALUELISTITEM4.Margin = New System.Windows.Forms.Padding(15)
        Me.cboVALUELISTITEM4.Name = "cboVALUELISTITEM4"
        Me.cboVALUELISTITEM4.Properties.AllowMouseWheel = False
        Me.cboVALUELISTITEM4.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.cboVALUELISTITEM4.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Search), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Clear)})
        Me.cboVALUELISTITEM4.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Modifier", "Modifier", 225, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 94, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("code", "code", 150, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CustomCode", "Κωδικός", 343, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("name", "Περιγραφή", 169, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("cat", "cat", 111, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("color", "color", 150, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Price", "Price", 150, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("comments", "comments", 280, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("modifiedBy", "modified By", 313, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("modifiedOn", "modified On", 321, DevExpress.Utils.FormatType.DateTime, "d/M/yyyy", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("createdOn", "created On", 298, DevExpress.Utils.FormatType.DateTime, "d/M/yyyy", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("createdBy", "created By", 285, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("doorColorID", "door Color ID", 348, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ColorName", "Color Name", 307, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("typeDescr", "type Descr", 285, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("type", "type", 142, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("valueListItem", "door Type", 274, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("kasa", "kasa", 142, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("dimName", "dim Name", 280, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("dimID", "dim ID", 196, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("valueListID", "door Cat ID", 307, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("valueListName", "door Cat Name", 391, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("closetType", "closet Type", 298, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("description", "Κατηγορία", 294, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default])})
        Me.cboVALUELISTITEM4.Properties.DataSource = Me.VwVALUELISTITEMV2BindingSource
        Me.cboVALUELISTITEM4.Properties.DisplayMember = "name"
        Me.cboVALUELISTITEM4.Properties.NullText = ""
        Me.cboVALUELISTITEM4.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.cboVALUELISTITEM4.Properties.PopupSizeable = False
        Me.cboVALUELISTITEM4.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoSuggest
        Me.cboVALUELISTITEM4.Properties.ValueMember = "ID"
        Me.cboVALUELISTITEM4.Size = New System.Drawing.Size(419, 26)
        Me.cboVALUELISTITEM4.StyleController = Me.LayoutControl1
        Me.cboVALUELISTITEM4.TabIndex = 49
        Me.cboVALUELISTITEM4.Tag = "doorTypeID4,0,1,2"
        '
        'cboVALUELISTITEM5
        '
        Me.cboVALUELISTITEM5.Location = New System.Drawing.Point(283, 625)
        Me.cboVALUELISTITEM5.Margin = New System.Windows.Forms.Padding(15)
        Me.cboVALUELISTITEM5.Name = "cboVALUELISTITEM5"
        Me.cboVALUELISTITEM5.Properties.AllowMouseWheel = False
        Me.cboVALUELISTITEM5.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.cboVALUELISTITEM5.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Search), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Clear)})
        Me.cboVALUELISTITEM5.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Modifier", "Modifier", 225, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 94, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("code", "code", 150, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CustomCode", "Κωδικός", 343, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("name", "Περιγραφή", 169, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("cat", "cat", 111, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("color", "color", 150, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Price", "Price", 150, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("comments", "comments", 280, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("modifiedBy", "modified By", 313, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("modifiedOn", "modified On", 321, DevExpress.Utils.FormatType.DateTime, "d/M/yyyy", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("createdOn", "created On", 298, DevExpress.Utils.FormatType.DateTime, "d/M/yyyy", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("createdBy", "created By", 285, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("doorColorID", "door Color ID", 348, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ColorName", "Color Name", 307, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("typeDescr", "type Descr", 285, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("type", "type", 142, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("valueListItem", "door Type", 274, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("kasa", "kasa", 142, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("dimName", "dim Name", 280, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("dimID", "dim ID", 196, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("valueListID", "door Cat ID", 307, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("valueListName", "door Cat Name", 391, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("closetType", "closet Type", 298, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("description", "Κατηγορία", 294, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default])})
        Me.cboVALUELISTITEM5.Properties.DataSource = Me.VwVALUELISTITEMV2BindingSource
        Me.cboVALUELISTITEM5.Properties.DisplayMember = "name"
        Me.cboVALUELISTITEM5.Properties.NullText = ""
        Me.cboVALUELISTITEM5.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.cboVALUELISTITEM5.Properties.PopupSizeable = False
        Me.cboVALUELISTITEM5.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoSuggest
        Me.cboVALUELISTITEM5.Properties.ValueMember = "ID"
        Me.cboVALUELISTITEM5.Size = New System.Drawing.Size(419, 26)
        Me.cboVALUELISTITEM5.StyleController = Me.LayoutControl1
        Me.cboVALUELISTITEM5.TabIndex = 49
        Me.cboVALUELISTITEM5.Tag = "doorTypeID5,0,1,2"
        '
        'cboVALUELISTITEM6
        '
        Me.cboVALUELISTITEM6.Location = New System.Drawing.Point(283, 625)
        Me.cboVALUELISTITEM6.Margin = New System.Windows.Forms.Padding(15)
        Me.cboVALUELISTITEM6.Name = "cboVALUELISTITEM6"
        Me.cboVALUELISTITEM6.Properties.AllowMouseWheel = False
        Me.cboVALUELISTITEM6.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.cboVALUELISTITEM6.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Search), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Clear)})
        Me.cboVALUELISTITEM6.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Modifier", "Modifier", 225, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 94, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("code", "code", 150, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CustomCode", "Κωδικός", 343, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("name", "Περιγραφή", 169, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("cat", "cat", 111, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("color", "color", 150, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Price", "Price", 150, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("comments", "comments", 280, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("modifiedBy", "modified By", 313, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("modifiedOn", "modified On", 321, DevExpress.Utils.FormatType.DateTime, "d/M/yyyy", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("createdOn", "created On", 298, DevExpress.Utils.FormatType.DateTime, "d/M/yyyy", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("createdBy", "created By", 285, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("doorColorID", "door Color ID", 348, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ColorName", "Color Name", 307, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("typeDescr", "type Descr", 285, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("type", "type", 142, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("valueListItem", "door Type", 274, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("kasa", "kasa", 142, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("dimName", "dim Name", 280, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("dimID", "dim ID", 196, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("valueListID", "door Cat ID", 307, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("valueListName", "door Cat Name", 391, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("closetType", "closet Type", 298, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("description", "Κατηγορία", 294, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default])})
        Me.cboVALUELISTITEM6.Properties.DataSource = Me.VwVALUELISTITEMV2BindingSource
        Me.cboVALUELISTITEM6.Properties.DisplayMember = "name"
        Me.cboVALUELISTITEM6.Properties.NullText = ""
        Me.cboVALUELISTITEM6.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.cboVALUELISTITEM6.Properties.PopupSizeable = False
        Me.cboVALUELISTITEM6.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoSuggest
        Me.cboVALUELISTITEM6.Properties.ValueMember = "ID"
        Me.cboVALUELISTITEM6.Size = New System.Drawing.Size(419, 26)
        Me.cboVALUELISTITEM6.StyleController = Me.LayoutControl1
        Me.cboVALUELISTITEM6.TabIndex = 49
        Me.cboVALUELISTITEM6.Tag = "doorTypeID6,0,1,2"
        '
        'txtExtraTransp
        '
        Me.txtExtraTransp.EditValue = "0,00 €"
        Me.txtExtraTransp.Location = New System.Drawing.Point(835, 773)
        Me.txtExtraTransp.Margin = New System.Windows.Forms.Padding(15)
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
        Me.txtExtraTransp.Size = New System.Drawing.Size(145, 26)
        Me.txtExtraTransp.StyleController = Me.LayoutControl1
        Me.txtExtraTransp.TabIndex = 42
        Me.txtExtraTransp.Tag = "ExtraTransp,0,1,2"
        Me.txtExtraTransp.Visible = False
        '
        'cmdConvertToOrder
        '
        Me.cmdConvertToOrder.ImageOptions.Image = Global.DreamyKitchenCRM.My.Resources.Resources.ConvertToOrder24
        Me.cmdConvertToOrder.Location = New System.Drawing.Point(895, 917)
        Me.cmdConvertToOrder.Margin = New System.Windows.Forms.Padding(10)
        Me.cmdConvertToOrder.Name = "cmdConvertToOrder"
        Me.cmdConvertToOrder.Size = New System.Drawing.Size(224, 32)
        Me.cmdConvertToOrder.StyleController = Me.LayoutControl1
        Me.cmdConvertToOrder.TabIndex = 65
        Me.cmdConvertToOrder.Text = "Μετατροπή σε Παραγγελία"
        '
        'txtKnobs2
        '
        Me.txtKnobs2.Location = New System.Drawing.Point(706, 625)
        Me.txtKnobs2.Margin = New System.Windows.Forms.Padding(15)
        Me.txtKnobs2.Name = "txtKnobs2"
        Me.txtKnobs2.Properties.UseReadOnlyAppearance = False
        Me.txtKnobs2.Size = New System.Drawing.Size(611, 26)
        Me.txtKnobs2.StyleController = Me.LayoutControl1
        Me.txtKnobs2.TabIndex = 44
        Me.txtKnobs2.Tag = "knobs2,0,1,2"
        '
        'txtKnobs3
        '
        Me.txtKnobs3.Location = New System.Drawing.Point(706, 625)
        Me.txtKnobs3.Margin = New System.Windows.Forms.Padding(15)
        Me.txtKnobs3.Name = "txtKnobs3"
        Me.txtKnobs3.Properties.UseReadOnlyAppearance = False
        Me.txtKnobs3.Size = New System.Drawing.Size(611, 26)
        Me.txtKnobs3.StyleController = Me.LayoutControl1
        Me.txtKnobs3.TabIndex = 44
        Me.txtKnobs3.Tag = "knobs3,0,1,2"
        '
        'txtKnobs4
        '
        Me.txtKnobs4.Location = New System.Drawing.Point(706, 625)
        Me.txtKnobs4.Margin = New System.Windows.Forms.Padding(15)
        Me.txtKnobs4.Name = "txtKnobs4"
        Me.txtKnobs4.Properties.UseReadOnlyAppearance = False
        Me.txtKnobs4.Size = New System.Drawing.Size(611, 26)
        Me.txtKnobs4.StyleController = Me.LayoutControl1
        Me.txtKnobs4.TabIndex = 44
        Me.txtKnobs4.Tag = "knobs4,0,1,2"
        '
        'txtKnobs5
        '
        Me.txtKnobs5.Location = New System.Drawing.Point(706, 625)
        Me.txtKnobs5.Margin = New System.Windows.Forms.Padding(15)
        Me.txtKnobs5.Name = "txtKnobs5"
        Me.txtKnobs5.Properties.UseReadOnlyAppearance = False
        Me.txtKnobs5.Size = New System.Drawing.Size(611, 26)
        Me.txtKnobs5.StyleController = Me.LayoutControl1
        Me.txtKnobs5.TabIndex = 44
        Me.txtKnobs5.Tag = "knobs5,0,1,2"
        '
        'txtKnobs6
        '
        Me.txtKnobs6.Location = New System.Drawing.Point(706, 625)
        Me.txtKnobs6.Margin = New System.Windows.Forms.Padding(15)
        Me.txtKnobs6.Name = "txtKnobs6"
        Me.txtKnobs6.Properties.UseReadOnlyAppearance = False
        Me.txtKnobs6.Size = New System.Drawing.Size(611, 26)
        Me.txtKnobs6.StyleController = Me.LayoutControl1
        Me.txtKnobs6.TabIndex = 44
        Me.txtKnobs6.Tag = "knobs6,0,1,2"
        '
        'cboType7
        '
        Me.cboType7.Location = New System.Drawing.Point(36, 575)
        Me.cboType7.Margin = New System.Windows.Forms.Padding(15)
        Me.cboType7.Name = "cboType7"
        Me.cboType7.Properties.AllowMouseWheel = False
        Me.cboType7.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Clear)})
        Me.cboType7.Properties.Items.AddRange(New Object() {"ΑΝΟΙΓΟΜΕΝΗ", "ΣΥΡΟΜΕΝΗ", "ΠΑΤΑΡΙ"})
        Me.cboType7.Properties.Tag = "String"
        Me.cboType7.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboType7.Size = New System.Drawing.Size(243, 26)
        Me.cboType7.StyleController = Me.LayoutControl1
        Me.cboType7.TabIndex = 47
        Me.cboType7.Tag = "doorType7,0,1,2"
        '
        'cboKasa7
        '
        Me.cboKasa7.Location = New System.Drawing.Point(283, 575)
        Me.cboKasa7.Margin = New System.Windows.Forms.Padding(15)
        Me.cboKasa7.Name = "cboKasa7"
        Me.cboKasa7.Properties.AllowMouseWheel = False
        Me.cboKasa7.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Clear)})
        Me.cboKasa7.Properties.Items.AddRange(New Object() {"13", "15", "18", "24"})
        Me.cboKasa7.Properties.Tag = "String"
        Me.cboKasa7.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboKasa7.Size = New System.Drawing.Size(419, 26)
        Me.cboKasa7.StyleController = Me.LayoutControl1
        Me.cboKasa7.TabIndex = 47
        Me.cboKasa7.Tag = "kasa7,0,1,2"
        '
        'cboFora7
        '
        Me.cboFora7.Location = New System.Drawing.Point(36, 625)
        Me.cboFora7.Margin = New System.Windows.Forms.Padding(15)
        Me.cboFora7.Name = "cboFora7"
        Me.cboFora7.Properties.AllowMouseWheel = False
        Me.cboFora7.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Clear)})
        Me.cboFora7.Properties.Items.AddRange(New Object() {"ΑΡΙΣΤΕΡΗ", "ΔΕΞΙΑ", "ΚΑΣΑ"})
        Me.cboFora7.Properties.Tag = "String"
        Me.cboFora7.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboFora7.Size = New System.Drawing.Size(243, 26)
        Me.cboFora7.StyleController = Me.LayoutControl1
        Me.cboFora7.TabIndex = 47
        Me.cboFora7.Tag = "fora7,0,1,2"
        '
        'cboVALUELISTITEM7
        '
        Me.cboVALUELISTITEM7.Location = New System.Drawing.Point(283, 625)
        Me.cboVALUELISTITEM7.Margin = New System.Windows.Forms.Padding(15)
        Me.cboVALUELISTITEM7.Name = "cboVALUELISTITEM7"
        Me.cboVALUELISTITEM7.Properties.AllowMouseWheel = False
        Me.cboVALUELISTITEM7.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.cboVALUELISTITEM7.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Search), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Clear)})
        Me.cboVALUELISTITEM7.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Modifier", "Modifier", 225, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 94, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("code", "code", 150, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CustomCode", "Κωδικός", 343, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("name", "Περιγραφή", 169, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("cat", "cat", 111, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("color", "color", 150, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Price", "Price", 150, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("comments", "comments", 280, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("modifiedBy", "modified By", 313, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("modifiedOn", "modified On", 321, DevExpress.Utils.FormatType.DateTime, "d/M/yyyy", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("createdOn", "created On", 298, DevExpress.Utils.FormatType.DateTime, "d/M/yyyy", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("createdBy", "created By", 285, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("doorColorID", "door Color ID", 348, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ColorName", "Color Name", 307, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("typeDescr", "type Descr", 285, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("type", "type", 142, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("valueListItem", "door Type", 274, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("kasa", "kasa", 142, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("dimName", "dim Name", 280, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("dimID", "dim ID", 196, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("valueListID", "door Cat ID", 307, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("valueListName", "door Cat Name", 391, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("closetType", "closet Type", 298, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("description", "Κατηγορία", 294, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default])})
        Me.cboVALUELISTITEM7.Properties.DataSource = Me.VwVALUELISTITEMV2BindingSource
        Me.cboVALUELISTITEM7.Properties.DisplayMember = "name"
        Me.cboVALUELISTITEM7.Properties.NullText = ""
        Me.cboVALUELISTITEM7.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.cboVALUELISTITEM7.Properties.PopupSizeable = False
        Me.cboVALUELISTITEM7.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoSuggest
        Me.cboVALUELISTITEM7.Properties.ValueMember = "ID"
        Me.cboVALUELISTITEM7.Size = New System.Drawing.Size(419, 26)
        Me.cboVALUELISTITEM7.StyleController = Me.LayoutControl1
        Me.cboVALUELISTITEM7.TabIndex = 49
        Me.cboVALUELISTITEM7.Tag = "doorTypeID7,0,1,2"
        '
        'txtDimension142
        '
        Me.txtDimension142.Location = New System.Drawing.Point(706, 575)
        Me.txtDimension142.Margin = New System.Windows.Forms.Padding(15)
        Me.txtDimension142.Name = "txtDimension142"
        Me.txtDimension142.Properties.UseReadOnlyAppearance = False
        Me.txtDimension142.Size = New System.Drawing.Size(611, 26)
        Me.txtDimension142.StyleController = Me.LayoutControl1
        Me.txtDimension142.TabIndex = 10
        Me.txtDimension142.Tag = "dimension7,0,1,2"
        '
        'txtKnobs7
        '
        Me.txtKnobs7.Location = New System.Drawing.Point(706, 625)
        Me.txtKnobs7.Margin = New System.Windows.Forms.Padding(15)
        Me.txtKnobs7.Name = "txtKnobs7"
        Me.txtKnobs7.Properties.UseReadOnlyAppearance = False
        Me.txtKnobs7.Size = New System.Drawing.Size(611, 26)
        Me.txtKnobs7.StyleController = Me.LayoutControl1
        Me.txtKnobs7.TabIndex = 44
        Me.txtKnobs7.Tag = "knobs7,0,1,2"
        '
        'cboType8
        '
        Me.cboType8.Location = New System.Drawing.Point(36, 575)
        Me.cboType8.Margin = New System.Windows.Forms.Padding(15)
        Me.cboType8.Name = "cboType8"
        Me.cboType8.Properties.AllowMouseWheel = False
        Me.cboType8.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Clear)})
        Me.cboType8.Properties.Items.AddRange(New Object() {"ΑΝΟΙΓΟΜΕΝΗ", "ΣΥΡΟΜΕΝΗ", "ΠΑΤΑΡΙ"})
        Me.cboType8.Properties.Tag = "String"
        Me.cboType8.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboType8.Size = New System.Drawing.Size(243, 26)
        Me.cboType8.StyleController = Me.LayoutControl1
        Me.cboType8.TabIndex = 47
        Me.cboType8.Tag = "doorType8,0,1,2"
        '
        'cboKasa8
        '
        Me.cboKasa8.Location = New System.Drawing.Point(283, 575)
        Me.cboKasa8.Margin = New System.Windows.Forms.Padding(15)
        Me.cboKasa8.Name = "cboKasa8"
        Me.cboKasa8.Properties.AllowMouseWheel = False
        Me.cboKasa8.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Clear)})
        Me.cboKasa8.Properties.Items.AddRange(New Object() {"13", "15", "18", "24"})
        Me.cboKasa8.Properties.Tag = "String"
        Me.cboKasa8.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboKasa8.Size = New System.Drawing.Size(419, 26)
        Me.cboKasa8.StyleController = Me.LayoutControl1
        Me.cboKasa8.TabIndex = 47
        Me.cboKasa8.Tag = "kasa8,0,1,2"
        '
        'cboFora8
        '
        Me.cboFora8.Location = New System.Drawing.Point(36, 625)
        Me.cboFora8.Margin = New System.Windows.Forms.Padding(15)
        Me.cboFora8.Name = "cboFora8"
        Me.cboFora8.Properties.AllowMouseWheel = False
        Me.cboFora8.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Clear)})
        Me.cboFora8.Properties.Items.AddRange(New Object() {"ΑΡΙΣΤΕΡΗ", "ΔΕΞΙΑ", "ΚΑΣΑ"})
        Me.cboFora8.Properties.Tag = "String"
        Me.cboFora8.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboFora8.Size = New System.Drawing.Size(243, 26)
        Me.cboFora8.StyleController = Me.LayoutControl1
        Me.cboFora8.TabIndex = 47
        Me.cboFora8.Tag = "fora8,0,1,2"
        '
        'cboVALUELISTITEM8
        '
        Me.cboVALUELISTITEM8.Location = New System.Drawing.Point(283, 625)
        Me.cboVALUELISTITEM8.Margin = New System.Windows.Forms.Padding(15)
        Me.cboVALUELISTITEM8.Name = "cboVALUELISTITEM8"
        Me.cboVALUELISTITEM8.Properties.AllowMouseWheel = False
        Me.cboVALUELISTITEM8.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.cboVALUELISTITEM8.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Search), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Clear)})
        Me.cboVALUELISTITEM8.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Modifier", "Modifier", 225, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 94, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("code", "code", 150, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CustomCode", "Κωδικός", 343, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("name", "Περιγραφή", 169, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("cat", "cat", 111, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("color", "color", 150, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Price", "Price", 150, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("comments", "comments", 280, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("modifiedBy", "modified By", 313, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("modifiedOn", "modified On", 321, DevExpress.Utils.FormatType.DateTime, "d/M/yyyy", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("createdOn", "created On", 298, DevExpress.Utils.FormatType.DateTime, "d/M/yyyy", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("createdBy", "created By", 285, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("doorColorID", "door Color ID", 348, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ColorName", "Color Name", 307, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("typeDescr", "type Descr", 285, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("type", "type", 142, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("valueListItem", "door Type", 274, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("kasa", "kasa", 142, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("dimName", "dim Name", 280, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("dimID", "dim ID", 196, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("valueListID", "door Cat ID", 307, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("valueListName", "door Cat Name", 391, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("closetType", "closet Type", 298, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("description", "Κατηγορία", 294, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default])})
        Me.cboVALUELISTITEM8.Properties.DataSource = Me.VwVALUELISTITEMV2BindingSource
        Me.cboVALUELISTITEM8.Properties.DisplayMember = "name"
        Me.cboVALUELISTITEM8.Properties.NullText = ""
        Me.cboVALUELISTITEM8.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.cboVALUELISTITEM8.Properties.PopupSizeable = False
        Me.cboVALUELISTITEM8.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoSuggest
        Me.cboVALUELISTITEM8.Properties.ValueMember = "ID"
        Me.cboVALUELISTITEM8.Size = New System.Drawing.Size(419, 26)
        Me.cboVALUELISTITEM8.StyleController = Me.LayoutControl1
        Me.cboVALUELISTITEM8.TabIndex = 49
        Me.cboVALUELISTITEM8.Tag = "doorTypeID8,0,1,2"
        '
        'txtDimension141
        '
        Me.txtDimension141.Location = New System.Drawing.Point(706, 575)
        Me.txtDimension141.Margin = New System.Windows.Forms.Padding(15)
        Me.txtDimension141.Name = "txtDimension141"
        Me.txtDimension141.Properties.UseReadOnlyAppearance = False
        Me.txtDimension141.Size = New System.Drawing.Size(611, 26)
        Me.txtDimension141.StyleController = Me.LayoutControl1
        Me.txtDimension141.TabIndex = 10
        Me.txtDimension141.Tag = "dimension8,0,1,2"
        '
        'txtKnobs8
        '
        Me.txtKnobs8.Location = New System.Drawing.Point(706, 625)
        Me.txtKnobs8.Margin = New System.Windows.Forms.Padding(15)
        Me.txtKnobs8.Name = "txtKnobs8"
        Me.txtKnobs8.Properties.UseReadOnlyAppearance = False
        Me.txtKnobs8.Size = New System.Drawing.Size(611, 26)
        Me.txtKnobs8.StyleController = Me.LayoutControl1
        Me.txtKnobs8.TabIndex = 44
        Me.txtKnobs8.Tag = "knobs8,0,1,2"
        '
        'cboType9
        '
        Me.cboType9.Location = New System.Drawing.Point(36, 575)
        Me.cboType9.Margin = New System.Windows.Forms.Padding(15)
        Me.cboType9.Name = "cboType9"
        Me.cboType9.Properties.AllowMouseWheel = False
        Me.cboType9.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Clear)})
        Me.cboType9.Properties.Items.AddRange(New Object() {"ΑΝΟΙΓΟΜΕΝΗ", "ΣΥΡΟΜΕΝΗ", "ΠΑΤΑΡΙ"})
        Me.cboType9.Properties.Tag = "String"
        Me.cboType9.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboType9.Size = New System.Drawing.Size(243, 26)
        Me.cboType9.StyleController = Me.LayoutControl1
        Me.cboType9.TabIndex = 47
        Me.cboType9.Tag = "doorType9,0,1,2"
        '
        'cboKasa9
        '
        Me.cboKasa9.Location = New System.Drawing.Point(283, 575)
        Me.cboKasa9.Margin = New System.Windows.Forms.Padding(15)
        Me.cboKasa9.Name = "cboKasa9"
        Me.cboKasa9.Properties.AllowMouseWheel = False
        Me.cboKasa9.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Clear)})
        Me.cboKasa9.Properties.Items.AddRange(New Object() {"13", "15", "18", "24"})
        Me.cboKasa9.Properties.Tag = "String"
        Me.cboKasa9.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboKasa9.Size = New System.Drawing.Size(419, 26)
        Me.cboKasa9.StyleController = Me.LayoutControl1
        Me.cboKasa9.TabIndex = 47
        Me.cboKasa9.Tag = "kasa9,0,1,2"
        '
        'cboFora9
        '
        Me.cboFora9.Location = New System.Drawing.Point(36, 625)
        Me.cboFora9.Margin = New System.Windows.Forms.Padding(15)
        Me.cboFora9.Name = "cboFora9"
        Me.cboFora9.Properties.AllowMouseWheel = False
        Me.cboFora9.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Clear)})
        Me.cboFora9.Properties.Items.AddRange(New Object() {"ΑΡΙΣΤΕΡΗ", "ΔΕΞΙΑ", "ΚΑΣΑ"})
        Me.cboFora9.Properties.Tag = "String"
        Me.cboFora9.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboFora9.Size = New System.Drawing.Size(243, 26)
        Me.cboFora9.StyleController = Me.LayoutControl1
        Me.cboFora9.TabIndex = 47
        Me.cboFora9.Tag = "fora9,0,1,2"
        '
        'cboVALUELISTITEM9
        '
        Me.cboVALUELISTITEM9.Location = New System.Drawing.Point(283, 625)
        Me.cboVALUELISTITEM9.Margin = New System.Windows.Forms.Padding(15)
        Me.cboVALUELISTITEM9.Name = "cboVALUELISTITEM9"
        Me.cboVALUELISTITEM9.Properties.AllowMouseWheel = False
        Me.cboVALUELISTITEM9.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.cboVALUELISTITEM9.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Search), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Clear)})
        Me.cboVALUELISTITEM9.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Modifier", "Modifier", 225, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 94, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("code", "code", 150, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CustomCode", "Κωδικός", 343, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("name", "Περιγραφή", 169, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("cat", "cat", 111, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("color", "color", 150, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Price", "Price", 150, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("comments", "comments", 280, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("modifiedBy", "modified By", 313, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("modifiedOn", "modified On", 321, DevExpress.Utils.FormatType.DateTime, "d/M/yyyy", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("createdOn", "created On", 298, DevExpress.Utils.FormatType.DateTime, "d/M/yyyy", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("createdBy", "created By", 285, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("doorColorID", "door Color ID", 348, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ColorName", "Color Name", 307, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("typeDescr", "type Descr", 285, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("type", "type", 142, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("valueListItem", "door Type", 274, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("kasa", "kasa", 142, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("dimName", "dim Name", 280, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("dimID", "dim ID", 196, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("valueListID", "door Cat ID", 307, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("valueListName", "door Cat Name", 391, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("closetType", "closet Type", 298, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("description", "Κατηγορία", 294, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default])})
        Me.cboVALUELISTITEM9.Properties.DataSource = Me.VwVALUELISTITEMV2BindingSource
        Me.cboVALUELISTITEM9.Properties.DisplayMember = "name"
        Me.cboVALUELISTITEM9.Properties.NullText = ""
        Me.cboVALUELISTITEM9.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.cboVALUELISTITEM9.Properties.PopupSizeable = False
        Me.cboVALUELISTITEM9.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoSuggest
        Me.cboVALUELISTITEM9.Properties.ValueMember = "ID"
        Me.cboVALUELISTITEM9.Size = New System.Drawing.Size(419, 26)
        Me.cboVALUELISTITEM9.StyleController = Me.LayoutControl1
        Me.cboVALUELISTITEM9.TabIndex = 49
        Me.cboVALUELISTITEM9.Tag = "doorTypeID9,0,1,2"
        '
        'txtDimension9
        '
        Me.txtDimension9.Location = New System.Drawing.Point(706, 575)
        Me.txtDimension9.Margin = New System.Windows.Forms.Padding(15)
        Me.txtDimension9.Name = "txtDimension9"
        Me.txtDimension9.Properties.UseReadOnlyAppearance = False
        Me.txtDimension9.Size = New System.Drawing.Size(611, 26)
        Me.txtDimension9.StyleController = Me.LayoutControl1
        Me.txtDimension9.TabIndex = 10
        Me.txtDimension9.Tag = "dimension9,0,1,2"
        '
        'txtKnobs9
        '
        Me.txtKnobs9.Location = New System.Drawing.Point(706, 625)
        Me.txtKnobs9.Margin = New System.Windows.Forms.Padding(15)
        Me.txtKnobs9.Name = "txtKnobs9"
        Me.txtKnobs9.Properties.UseReadOnlyAppearance = False
        Me.txtKnobs9.Size = New System.Drawing.Size(611, 26)
        Me.txtKnobs9.StyleController = Me.LayoutControl1
        Me.txtKnobs9.TabIndex = 44
        Me.txtKnobs9.Tag = "knobs9,0,1,2"
        '
        'cboType10
        '
        Me.cboType10.Location = New System.Drawing.Point(36, 575)
        Me.cboType10.Margin = New System.Windows.Forms.Padding(15)
        Me.cboType10.Name = "cboType10"
        Me.cboType10.Properties.AllowMouseWheel = False
        Me.cboType10.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Clear)})
        Me.cboType10.Properties.Items.AddRange(New Object() {"ΑΝΟΙΓΟΜΕΝΗ", "ΣΥΡΟΜΕΝΗ", "ΠΑΤΑΡΙ"})
        Me.cboType10.Properties.Tag = "String"
        Me.cboType10.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboType10.Size = New System.Drawing.Size(243, 26)
        Me.cboType10.StyleController = Me.LayoutControl1
        Me.cboType10.TabIndex = 47
        Me.cboType10.Tag = "doorType10,0,1,2"
        '
        'cboKasa10
        '
        Me.cboKasa10.Location = New System.Drawing.Point(283, 575)
        Me.cboKasa10.Margin = New System.Windows.Forms.Padding(15)
        Me.cboKasa10.Name = "cboKasa10"
        Me.cboKasa10.Properties.AllowMouseWheel = False
        Me.cboKasa10.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Clear)})
        Me.cboKasa10.Properties.Items.AddRange(New Object() {"13", "15", "18", "24"})
        Me.cboKasa10.Properties.Tag = "String"
        Me.cboKasa10.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboKasa10.Size = New System.Drawing.Size(419, 26)
        Me.cboKasa10.StyleController = Me.LayoutControl1
        Me.cboKasa10.TabIndex = 47
        Me.cboKasa10.Tag = "kasa10,0,1,2"
        '
        'cboFora10
        '
        Me.cboFora10.Location = New System.Drawing.Point(36, 625)
        Me.cboFora10.Margin = New System.Windows.Forms.Padding(15)
        Me.cboFora10.Name = "cboFora10"
        Me.cboFora10.Properties.AllowMouseWheel = False
        Me.cboFora10.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Clear)})
        Me.cboFora10.Properties.Items.AddRange(New Object() {"ΑΡΙΣΤΕΡΗ", "ΔΕΞΙΑ", "ΚΑΣΑ"})
        Me.cboFora10.Properties.Tag = "String"
        Me.cboFora10.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboFora10.Size = New System.Drawing.Size(243, 26)
        Me.cboFora10.StyleController = Me.LayoutControl1
        Me.cboFora10.TabIndex = 47
        Me.cboFora10.Tag = "fora10,0,1,2"
        '
        'cboVALUELISTITEM10
        '
        Me.cboVALUELISTITEM10.Location = New System.Drawing.Point(283, 625)
        Me.cboVALUELISTITEM10.Margin = New System.Windows.Forms.Padding(15)
        Me.cboVALUELISTITEM10.Name = "cboVALUELISTITEM10"
        Me.cboVALUELISTITEM10.Properties.AllowMouseWheel = False
        Me.cboVALUELISTITEM10.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.cboVALUELISTITEM10.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Search), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Clear)})
        Me.cboVALUELISTITEM10.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Modifier", "Modifier", 225, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 94, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("code", "code", 150, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CustomCode", "Κωδικός", 343, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("name", "Περιγραφή", 169, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("cat", "cat", 111, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("color", "color", 150, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Price", "Price", 150, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("comments", "comments", 280, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("modifiedBy", "modified By", 313, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("modifiedOn", "modified On", 321, DevExpress.Utils.FormatType.DateTime, "d/M/yyyy", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("createdOn", "created On", 298, DevExpress.Utils.FormatType.DateTime, "d/M/yyyy", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("createdBy", "created By", 285, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("doorColorID", "door Color ID", 348, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ColorName", "Color Name", 307, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("typeDescr", "type Descr", 285, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("type", "type", 142, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("valueListItem", "door Type", 274, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("kasa", "kasa", 142, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("dimName", "dim Name", 280, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("dimID", "dim ID", 196, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("valueListID", "door Cat ID", 307, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("valueListName", "door Cat Name", 391, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("closetType", "closet Type", 298, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("description", "Κατηγορία", 294, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default])})
        Me.cboVALUELISTITEM10.Properties.DataSource = Me.VwVALUELISTITEMV2BindingSource
        Me.cboVALUELISTITEM10.Properties.DisplayMember = "name"
        Me.cboVALUELISTITEM10.Properties.NullText = ""
        Me.cboVALUELISTITEM10.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.cboVALUELISTITEM10.Properties.PopupSizeable = False
        Me.cboVALUELISTITEM10.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoSuggest
        Me.cboVALUELISTITEM10.Properties.ValueMember = "ID"
        Me.cboVALUELISTITEM10.Size = New System.Drawing.Size(419, 26)
        Me.cboVALUELISTITEM10.StyleController = Me.LayoutControl1
        Me.cboVALUELISTITEM10.TabIndex = 49
        Me.cboVALUELISTITEM10.Tag = "doorTypeID10,0,1,2"
        '
        'txtDimension10
        '
        Me.txtDimension10.Location = New System.Drawing.Point(706, 575)
        Me.txtDimension10.Margin = New System.Windows.Forms.Padding(15)
        Me.txtDimension10.Name = "txtDimension10"
        Me.txtDimension10.Properties.UseReadOnlyAppearance = False
        Me.txtDimension10.Size = New System.Drawing.Size(611, 26)
        Me.txtDimension10.StyleController = Me.LayoutControl1
        Me.txtDimension10.TabIndex = 10
        Me.txtDimension10.Tag = "dimension10,0,1,2"
        '
        'txtKnobs10
        '
        Me.txtKnobs10.Location = New System.Drawing.Point(706, 625)
        Me.txtKnobs10.Margin = New System.Windows.Forms.Padding(15)
        Me.txtKnobs10.Name = "txtKnobs10"
        Me.txtKnobs10.Properties.UseReadOnlyAppearance = False
        Me.txtKnobs10.Size = New System.Drawing.Size(611, 26)
        Me.txtKnobs10.StyleController = Me.LayoutControl1
        Me.txtKnobs10.TabIndex = 44
        Me.txtKnobs10.Tag = "knobs10,0,1,2"
        '
        'txtInitialPrice1
        '
        Me.txtInitialPrice1.EditValue = "0,00 €"
        Me.txtInitialPrice1.Location = New System.Drawing.Point(36, 675)
        Me.txtInitialPrice1.Margin = New System.Windows.Forms.Padding(15)
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
        Me.txtInitialPrice1.Size = New System.Drawing.Size(303, 26)
        Me.txtInitialPrice1.StyleController = Me.LayoutControl1
        Me.txtInitialPrice1.TabIndex = 42
        Me.txtInitialPrice1.Tag = "modelInitialPrice1,0,1,2"
        Me.txtInitialPrice1.Visible = False
        '
        'txtDisc1
        '
        Me.txtDisc1.EditValue = "0%"
        Me.txtDisc1.Location = New System.Drawing.Point(343, 675)
        Me.txtDisc1.Margin = New System.Windows.Forms.Padding(15)
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
        Me.txtDisc1.Size = New System.Drawing.Size(294, 26)
        Me.txtDisc1.StyleController = Me.LayoutControl1
        Me.txtDisc1.TabIndex = 42
        Me.txtDisc1.Tag = "discount1,0,1,2"
        Me.txtDisc1.Visible = False
        '
        'txtDiscount1
        '
        Me.txtDiscount1.EditValue = "0,00 €"
        Me.txtDiscount1.Location = New System.Drawing.Point(641, 675)
        Me.txtDiscount1.Margin = New System.Windows.Forms.Padding(15)
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
        Me.txtDiscount1.Size = New System.Drawing.Size(325, 26)
        Me.txtDiscount1.StyleController = Me.LayoutControl1
        Me.txtDiscount1.TabIndex = 42
        Me.txtDiscount1.Tag = "modelDiscount1,0,1,2"
        Me.txtDiscount1.Visible = False
        '
        'txtFinalPrice1
        '
        Me.txtFinalPrice1.EditValue = "0,00 €"
        Me.txtFinalPrice1.Location = New System.Drawing.Point(970, 675)
        Me.txtFinalPrice1.Margin = New System.Windows.Forms.Padding(15)
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
        Me.txtFinalPrice1.Size = New System.Drawing.Size(347, 26)
        Me.txtFinalPrice1.StyleController = Me.LayoutControl1
        Me.txtFinalPrice1.TabIndex = 42
        Me.txtFinalPrice1.Tag = "modelFinalPrice1,0,1,2"
        Me.txtFinalPrice1.Visible = False
        '
        'txtInitialPrice2
        '
        Me.txtInitialPrice2.EditValue = "0,00 €"
        Me.txtInitialPrice2.Location = New System.Drawing.Point(36, 675)
        Me.txtInitialPrice2.Margin = New System.Windows.Forms.Padding(15)
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
        Me.txtInitialPrice2.Size = New System.Drawing.Size(303, 26)
        Me.txtInitialPrice2.StyleController = Me.LayoutControl1
        Me.txtInitialPrice2.TabIndex = 42
        Me.txtInitialPrice2.Tag = "modelInitialPrice2,0,1,2"
        Me.txtInitialPrice2.Visible = False
        '
        'txtDisc2
        '
        Me.txtDisc2.EditValue = "0%"
        Me.txtDisc2.Location = New System.Drawing.Point(343, 675)
        Me.txtDisc2.Margin = New System.Windows.Forms.Padding(15)
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
        Me.txtDisc2.Size = New System.Drawing.Size(294, 26)
        Me.txtDisc2.StyleController = Me.LayoutControl1
        Me.txtDisc2.TabIndex = 42
        Me.txtDisc2.Tag = "discount2,0,1,2"
        Me.txtDisc2.Visible = False
        '
        'txtDiscount2
        '
        Me.txtDiscount2.EditValue = "0,00 €"
        Me.txtDiscount2.Location = New System.Drawing.Point(641, 675)
        Me.txtDiscount2.Margin = New System.Windows.Forms.Padding(15)
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
        Me.txtDiscount2.Size = New System.Drawing.Size(325, 26)
        Me.txtDiscount2.StyleController = Me.LayoutControl1
        Me.txtDiscount2.TabIndex = 42
        Me.txtDiscount2.Tag = "modelDiscount2,0,1,2"
        Me.txtDiscount2.Visible = False
        '
        'txtFinalPrice2
        '
        Me.txtFinalPrice2.EditValue = "0,00 €"
        Me.txtFinalPrice2.Location = New System.Drawing.Point(970, 675)
        Me.txtFinalPrice2.Margin = New System.Windows.Forms.Padding(15)
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
        Me.txtFinalPrice2.Size = New System.Drawing.Size(347, 26)
        Me.txtFinalPrice2.StyleController = Me.LayoutControl1
        Me.txtFinalPrice2.TabIndex = 42
        Me.txtFinalPrice2.Tag = "modelFinalPrice2,0,1,2"
        Me.txtFinalPrice2.Visible = False
        '
        'txtInitialPrice3
        '
        Me.txtInitialPrice3.EditValue = "0,00 €"
        Me.txtInitialPrice3.Location = New System.Drawing.Point(36, 675)
        Me.txtInitialPrice3.Margin = New System.Windows.Forms.Padding(15)
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
        Me.txtInitialPrice3.Size = New System.Drawing.Size(303, 26)
        Me.txtInitialPrice3.StyleController = Me.LayoutControl1
        Me.txtInitialPrice3.TabIndex = 42
        Me.txtInitialPrice3.Tag = "modelInitialPrice3,0,1,2"
        Me.txtInitialPrice3.Visible = False
        '
        'txtDisc3
        '
        Me.txtDisc3.EditValue = "0%"
        Me.txtDisc3.Location = New System.Drawing.Point(343, 675)
        Me.txtDisc3.Margin = New System.Windows.Forms.Padding(15)
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
        Me.txtDisc3.Size = New System.Drawing.Size(294, 26)
        Me.txtDisc3.StyleController = Me.LayoutControl1
        Me.txtDisc3.TabIndex = 42
        Me.txtDisc3.Tag = "discount3,0,1,2"
        Me.txtDisc3.Visible = False
        '
        'txtDiscount3
        '
        Me.txtDiscount3.EditValue = "0,00 €"
        Me.txtDiscount3.Location = New System.Drawing.Point(641, 675)
        Me.txtDiscount3.Margin = New System.Windows.Forms.Padding(15)
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
        Me.txtDiscount3.Size = New System.Drawing.Size(325, 26)
        Me.txtDiscount3.StyleController = Me.LayoutControl1
        Me.txtDiscount3.TabIndex = 42
        Me.txtDiscount3.Tag = "modelDiscount3,0,1,2"
        Me.txtDiscount3.Visible = False
        '
        'txtFinalPrice3
        '
        Me.txtFinalPrice3.EditValue = "0,00 €"
        Me.txtFinalPrice3.Location = New System.Drawing.Point(970, 675)
        Me.txtFinalPrice3.Margin = New System.Windows.Forms.Padding(15)
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
        Me.txtFinalPrice3.Size = New System.Drawing.Size(347, 26)
        Me.txtFinalPrice3.StyleController = Me.LayoutControl1
        Me.txtFinalPrice3.TabIndex = 42
        Me.txtFinalPrice3.Tag = "modelFinalPrice3,0,1,2"
        Me.txtFinalPrice3.Visible = False
        '
        'txtInitialPrice4
        '
        Me.txtInitialPrice4.EditValue = "0,00 €"
        Me.txtInitialPrice4.Location = New System.Drawing.Point(36, 675)
        Me.txtInitialPrice4.Margin = New System.Windows.Forms.Padding(15)
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
        Me.txtInitialPrice4.Size = New System.Drawing.Size(303, 26)
        Me.txtInitialPrice4.StyleController = Me.LayoutControl1
        Me.txtInitialPrice4.TabIndex = 42
        Me.txtInitialPrice4.Tag = "modelInitialPrice4,0,1,2"
        Me.txtInitialPrice4.Visible = False
        '
        'txtDisc4
        '
        Me.txtDisc4.EditValue = "0%"
        Me.txtDisc4.Location = New System.Drawing.Point(343, 675)
        Me.txtDisc4.Margin = New System.Windows.Forms.Padding(15)
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
        Me.txtDisc4.Size = New System.Drawing.Size(294, 26)
        Me.txtDisc4.StyleController = Me.LayoutControl1
        Me.txtDisc4.TabIndex = 42
        Me.txtDisc4.Tag = "discount4,0,1,2"
        Me.txtDisc4.Visible = False
        '
        'txtDiscount4
        '
        Me.txtDiscount4.EditValue = "0,00 €"
        Me.txtDiscount4.Location = New System.Drawing.Point(641, 675)
        Me.txtDiscount4.Margin = New System.Windows.Forms.Padding(15)
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
        Me.txtDiscount4.Size = New System.Drawing.Size(325, 26)
        Me.txtDiscount4.StyleController = Me.LayoutControl1
        Me.txtDiscount4.TabIndex = 42
        Me.txtDiscount4.Tag = "modelDiscount4,0,1,2"
        Me.txtDiscount4.Visible = False
        '
        'txtFinalPrice4
        '
        Me.txtFinalPrice4.EditValue = "0,00 €"
        Me.txtFinalPrice4.Location = New System.Drawing.Point(970, 675)
        Me.txtFinalPrice4.Margin = New System.Windows.Forms.Padding(15)
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
        Me.txtFinalPrice4.Size = New System.Drawing.Size(347, 26)
        Me.txtFinalPrice4.StyleController = Me.LayoutControl1
        Me.txtFinalPrice4.TabIndex = 42
        Me.txtFinalPrice4.Tag = "modelFinalPrice4,0,1,2"
        Me.txtFinalPrice4.Visible = False
        '
        'txtInitialPrice5
        '
        Me.txtInitialPrice5.EditValue = "0,00 €"
        Me.txtInitialPrice5.Location = New System.Drawing.Point(36, 675)
        Me.txtInitialPrice5.Margin = New System.Windows.Forms.Padding(15)
        Me.txtInitialPrice5.Name = "txtInitialPrice5"
        Me.txtInitialPrice5.Properties.DisplayFormat.FormatString = "c"
        Me.txtInitialPrice5.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtInitialPrice5.Properties.EditFormat.FormatString = "n2"
        Me.txtInitialPrice5.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtInitialPrice5.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtInitialPrice5.Properties.MaskSettings.Set("MaskManagerType", GetType(DevExpress.Data.Mask.NumericMaskManager))
        Me.txtInitialPrice5.Properties.MaskSettings.Set("mask", "c2")
        Me.txtInitialPrice5.Properties.Tag = "BenchExtraPrice"
        Me.txtInitialPrice5.Properties.UseReadOnlyAppearance = False
        Me.txtInitialPrice5.Size = New System.Drawing.Size(303, 26)
        Me.txtInitialPrice5.StyleController = Me.LayoutControl1
        Me.txtInitialPrice5.TabIndex = 42
        Me.txtInitialPrice5.Tag = "modelInitialPrice5,0,1,2"
        Me.txtInitialPrice5.Visible = False
        '
        'txtDisc5
        '
        Me.txtDisc5.EditValue = "0%"
        Me.txtDisc5.Location = New System.Drawing.Point(343, 675)
        Me.txtDisc5.Margin = New System.Windows.Forms.Padding(15)
        Me.txtDisc5.Name = "txtDisc5"
        Me.txtDisc5.Properties.DisplayFormat.FormatString = "c"
        Me.txtDisc5.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtDisc5.Properties.EditFormat.FormatString = "n2"
        Me.txtDisc5.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtDisc5.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtDisc5.Properties.MaskSettings.Set("MaskManagerType", GetType(DevExpress.Data.Mask.NumericMaskManager))
        Me.txtDisc5.Properties.MaskSettings.Set("mask", "P0")
        Me.txtDisc5.Properties.Tag = "BenchExtraPrice"
        Me.txtDisc5.Properties.UseReadOnlyAppearance = False
        Me.txtDisc5.Size = New System.Drawing.Size(294, 26)
        Me.txtDisc5.StyleController = Me.LayoutControl1
        Me.txtDisc5.TabIndex = 42
        Me.txtDisc5.Tag = "discount5,0,1,2"
        Me.txtDisc5.Visible = False
        '
        'txtDiscount5
        '
        Me.txtDiscount5.EditValue = "0,00 €"
        Me.txtDiscount5.Location = New System.Drawing.Point(641, 675)
        Me.txtDiscount5.Margin = New System.Windows.Forms.Padding(15)
        Me.txtDiscount5.Name = "txtDiscount5"
        Me.txtDiscount5.Properties.DisplayFormat.FormatString = "c"
        Me.txtDiscount5.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtDiscount5.Properties.EditFormat.FormatString = "n2"
        Me.txtDiscount5.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtDiscount5.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtDiscount5.Properties.MaskSettings.Set("MaskManagerType", GetType(DevExpress.Data.Mask.NumericMaskManager))
        Me.txtDiscount5.Properties.MaskSettings.Set("mask", "c2")
        Me.txtDiscount5.Properties.ReadOnly = True
        Me.txtDiscount5.Properties.Tag = "BenchExtraPrice"
        Me.txtDiscount5.Properties.UseReadOnlyAppearance = False
        Me.txtDiscount5.Size = New System.Drawing.Size(325, 26)
        Me.txtDiscount5.StyleController = Me.LayoutControl1
        Me.txtDiscount5.TabIndex = 42
        Me.txtDiscount5.Tag = "modelDiscount5,0,1,2"
        Me.txtDiscount5.Visible = False
        '
        'txtFinalPrice5
        '
        Me.txtFinalPrice5.EditValue = "0,00 €"
        Me.txtFinalPrice5.Location = New System.Drawing.Point(970, 675)
        Me.txtFinalPrice5.Margin = New System.Windows.Forms.Padding(15)
        Me.txtFinalPrice5.Name = "txtFinalPrice5"
        Me.txtFinalPrice5.Properties.DisplayFormat.FormatString = "c"
        Me.txtFinalPrice5.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtFinalPrice5.Properties.EditFormat.FormatString = "n2"
        Me.txtFinalPrice5.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtFinalPrice5.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtFinalPrice5.Properties.MaskSettings.Set("MaskManagerType", GetType(DevExpress.Data.Mask.NumericMaskManager))
        Me.txtFinalPrice5.Properties.MaskSettings.Set("mask", "c2")
        Me.txtFinalPrice5.Properties.ReadOnly = True
        Me.txtFinalPrice5.Properties.Tag = "BenchExtraPrice"
        Me.txtFinalPrice5.Properties.UseReadOnlyAppearance = False
        Me.txtFinalPrice5.Size = New System.Drawing.Size(347, 26)
        Me.txtFinalPrice5.StyleController = Me.LayoutControl1
        Me.txtFinalPrice5.TabIndex = 42
        Me.txtFinalPrice5.Tag = "modelFinalPrice5,0,1,2"
        Me.txtFinalPrice5.Visible = False
        '
        'txtInitialPrice6
        '
        Me.txtInitialPrice6.EditValue = "0,00 €"
        Me.txtInitialPrice6.Location = New System.Drawing.Point(36, 675)
        Me.txtInitialPrice6.Margin = New System.Windows.Forms.Padding(15)
        Me.txtInitialPrice6.Name = "txtInitialPrice6"
        Me.txtInitialPrice6.Properties.DisplayFormat.FormatString = "c"
        Me.txtInitialPrice6.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtInitialPrice6.Properties.EditFormat.FormatString = "n2"
        Me.txtInitialPrice6.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtInitialPrice6.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtInitialPrice6.Properties.MaskSettings.Set("MaskManagerType", GetType(DevExpress.Data.Mask.NumericMaskManager))
        Me.txtInitialPrice6.Properties.MaskSettings.Set("mask", "c2")
        Me.txtInitialPrice6.Properties.Tag = "BenchExtraPrice"
        Me.txtInitialPrice6.Properties.UseReadOnlyAppearance = False
        Me.txtInitialPrice6.Size = New System.Drawing.Size(303, 26)
        Me.txtInitialPrice6.StyleController = Me.LayoutControl1
        Me.txtInitialPrice6.TabIndex = 42
        Me.txtInitialPrice6.Tag = "modelInitialPrice6,0,1,2"
        Me.txtInitialPrice6.Visible = False
        '
        'txtDisc6
        '
        Me.txtDisc6.EditValue = "0%"
        Me.txtDisc6.Location = New System.Drawing.Point(343, 675)
        Me.txtDisc6.Margin = New System.Windows.Forms.Padding(15)
        Me.txtDisc6.Name = "txtDisc6"
        Me.txtDisc6.Properties.DisplayFormat.FormatString = "c"
        Me.txtDisc6.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtDisc6.Properties.EditFormat.FormatString = "n2"
        Me.txtDisc6.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtDisc6.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtDisc6.Properties.MaskSettings.Set("MaskManagerType", GetType(DevExpress.Data.Mask.NumericMaskManager))
        Me.txtDisc6.Properties.MaskSettings.Set("mask", "P0")
        Me.txtDisc6.Properties.Tag = "BenchExtraPrice"
        Me.txtDisc6.Properties.UseReadOnlyAppearance = False
        Me.txtDisc6.Size = New System.Drawing.Size(294, 26)
        Me.txtDisc6.StyleController = Me.LayoutControl1
        Me.txtDisc6.TabIndex = 42
        Me.txtDisc6.Tag = "discount6,0,1,2"
        Me.txtDisc6.Visible = False
        '
        'txtDiscount6
        '
        Me.txtDiscount6.EditValue = "0,00 €"
        Me.txtDiscount6.Location = New System.Drawing.Point(641, 675)
        Me.txtDiscount6.Margin = New System.Windows.Forms.Padding(15)
        Me.txtDiscount6.Name = "txtDiscount6"
        Me.txtDiscount6.Properties.DisplayFormat.FormatString = "c"
        Me.txtDiscount6.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtDiscount6.Properties.EditFormat.FormatString = "n2"
        Me.txtDiscount6.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtDiscount6.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtDiscount6.Properties.MaskSettings.Set("MaskManagerType", GetType(DevExpress.Data.Mask.NumericMaskManager))
        Me.txtDiscount6.Properties.MaskSettings.Set("mask", "c2")
        Me.txtDiscount6.Properties.ReadOnly = True
        Me.txtDiscount6.Properties.Tag = "BenchExtraPrice"
        Me.txtDiscount6.Properties.UseReadOnlyAppearance = False
        Me.txtDiscount6.Size = New System.Drawing.Size(325, 26)
        Me.txtDiscount6.StyleController = Me.LayoutControl1
        Me.txtDiscount6.TabIndex = 42
        Me.txtDiscount6.Tag = "modelDiscount6,0,1,2"
        Me.txtDiscount6.Visible = False
        '
        'txtFinalPrice6
        '
        Me.txtFinalPrice6.EditValue = "0,00 €"
        Me.txtFinalPrice6.Location = New System.Drawing.Point(970, 675)
        Me.txtFinalPrice6.Margin = New System.Windows.Forms.Padding(15)
        Me.txtFinalPrice6.Name = "txtFinalPrice6"
        Me.txtFinalPrice6.Properties.DisplayFormat.FormatString = "c"
        Me.txtFinalPrice6.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtFinalPrice6.Properties.EditFormat.FormatString = "n2"
        Me.txtFinalPrice6.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtFinalPrice6.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtFinalPrice6.Properties.MaskSettings.Set("MaskManagerType", GetType(DevExpress.Data.Mask.NumericMaskManager))
        Me.txtFinalPrice6.Properties.MaskSettings.Set("mask", "c2")
        Me.txtFinalPrice6.Properties.ReadOnly = True
        Me.txtFinalPrice6.Properties.Tag = "BenchExtraPrice"
        Me.txtFinalPrice6.Properties.UseReadOnlyAppearance = False
        Me.txtFinalPrice6.Size = New System.Drawing.Size(347, 26)
        Me.txtFinalPrice6.StyleController = Me.LayoutControl1
        Me.txtFinalPrice6.TabIndex = 42
        Me.txtFinalPrice6.Tag = "modelFinalPrice6,0,1,2"
        Me.txtFinalPrice6.Visible = False
        '
        'txtInitialPrice7
        '
        Me.txtInitialPrice7.EditValue = "0,00 €"
        Me.txtInitialPrice7.Location = New System.Drawing.Point(36, 675)
        Me.txtInitialPrice7.Margin = New System.Windows.Forms.Padding(15)
        Me.txtInitialPrice7.Name = "txtInitialPrice7"
        Me.txtInitialPrice7.Properties.DisplayFormat.FormatString = "c"
        Me.txtInitialPrice7.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtInitialPrice7.Properties.EditFormat.FormatString = "n2"
        Me.txtInitialPrice7.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtInitialPrice7.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtInitialPrice7.Properties.MaskSettings.Set("MaskManagerType", GetType(DevExpress.Data.Mask.NumericMaskManager))
        Me.txtInitialPrice7.Properties.MaskSettings.Set("mask", "c2")
        Me.txtInitialPrice7.Properties.Tag = "BenchExtraPrice"
        Me.txtInitialPrice7.Properties.UseReadOnlyAppearance = False
        Me.txtInitialPrice7.Size = New System.Drawing.Size(303, 26)
        Me.txtInitialPrice7.StyleController = Me.LayoutControl1
        Me.txtInitialPrice7.TabIndex = 42
        Me.txtInitialPrice7.Tag = "modelInitialPrice7,0,1,2"
        Me.txtInitialPrice7.Visible = False
        '
        'txtDisc7
        '
        Me.txtDisc7.EditValue = "0%"
        Me.txtDisc7.Location = New System.Drawing.Point(343, 675)
        Me.txtDisc7.Margin = New System.Windows.Forms.Padding(15)
        Me.txtDisc7.Name = "txtDisc7"
        Me.txtDisc7.Properties.DisplayFormat.FormatString = "c"
        Me.txtDisc7.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtDisc7.Properties.EditFormat.FormatString = "n2"
        Me.txtDisc7.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtDisc7.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtDisc7.Properties.MaskSettings.Set("MaskManagerType", GetType(DevExpress.Data.Mask.NumericMaskManager))
        Me.txtDisc7.Properties.MaskSettings.Set("mask", "P0")
        Me.txtDisc7.Properties.Tag = "BenchExtraPrice"
        Me.txtDisc7.Properties.UseReadOnlyAppearance = False
        Me.txtDisc7.Size = New System.Drawing.Size(294, 26)
        Me.txtDisc7.StyleController = Me.LayoutControl1
        Me.txtDisc7.TabIndex = 42
        Me.txtDisc7.Tag = "discount7,0,1,2"
        Me.txtDisc7.Visible = False
        '
        'txtDiscount7
        '
        Me.txtDiscount7.EditValue = "0,00 €"
        Me.txtDiscount7.Location = New System.Drawing.Point(641, 675)
        Me.txtDiscount7.Margin = New System.Windows.Forms.Padding(15)
        Me.txtDiscount7.Name = "txtDiscount7"
        Me.txtDiscount7.Properties.DisplayFormat.FormatString = "c"
        Me.txtDiscount7.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtDiscount7.Properties.EditFormat.FormatString = "n2"
        Me.txtDiscount7.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtDiscount7.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtDiscount7.Properties.MaskSettings.Set("MaskManagerType", GetType(DevExpress.Data.Mask.NumericMaskManager))
        Me.txtDiscount7.Properties.MaskSettings.Set("mask", "c2")
        Me.txtDiscount7.Properties.ReadOnly = True
        Me.txtDiscount7.Properties.Tag = "BenchExtraPrice"
        Me.txtDiscount7.Properties.UseReadOnlyAppearance = False
        Me.txtDiscount7.Size = New System.Drawing.Size(325, 26)
        Me.txtDiscount7.StyleController = Me.LayoutControl1
        Me.txtDiscount7.TabIndex = 42
        Me.txtDiscount7.Tag = "modelDiscount7,0,1,2"
        Me.txtDiscount7.Visible = False
        '
        'txtFinalPrice7
        '
        Me.txtFinalPrice7.EditValue = "0,00 €"
        Me.txtFinalPrice7.Location = New System.Drawing.Point(970, 675)
        Me.txtFinalPrice7.Margin = New System.Windows.Forms.Padding(15)
        Me.txtFinalPrice7.Name = "txtFinalPrice7"
        Me.txtFinalPrice7.Properties.DisplayFormat.FormatString = "c"
        Me.txtFinalPrice7.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtFinalPrice7.Properties.EditFormat.FormatString = "n2"
        Me.txtFinalPrice7.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtFinalPrice7.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtFinalPrice7.Properties.MaskSettings.Set("MaskManagerType", GetType(DevExpress.Data.Mask.NumericMaskManager))
        Me.txtFinalPrice7.Properties.MaskSettings.Set("mask", "c2")
        Me.txtFinalPrice7.Properties.ReadOnly = True
        Me.txtFinalPrice7.Properties.Tag = "BenchExtraPrice"
        Me.txtFinalPrice7.Properties.UseReadOnlyAppearance = False
        Me.txtFinalPrice7.Size = New System.Drawing.Size(347, 26)
        Me.txtFinalPrice7.StyleController = Me.LayoutControl1
        Me.txtFinalPrice7.TabIndex = 42
        Me.txtFinalPrice7.Tag = "modelFinalPrice7,0,1,2"
        Me.txtFinalPrice7.Visible = False
        '
        'txtInitialPrice8
        '
        Me.txtInitialPrice8.EditValue = "0,00 €"
        Me.txtInitialPrice8.Location = New System.Drawing.Point(36, 675)
        Me.txtInitialPrice8.Margin = New System.Windows.Forms.Padding(15)
        Me.txtInitialPrice8.Name = "txtInitialPrice8"
        Me.txtInitialPrice8.Properties.DisplayFormat.FormatString = "c"
        Me.txtInitialPrice8.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtInitialPrice8.Properties.EditFormat.FormatString = "n2"
        Me.txtInitialPrice8.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtInitialPrice8.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtInitialPrice8.Properties.MaskSettings.Set("MaskManagerType", GetType(DevExpress.Data.Mask.NumericMaskManager))
        Me.txtInitialPrice8.Properties.MaskSettings.Set("mask", "c2")
        Me.txtInitialPrice8.Properties.Tag = "BenchExtraPrice"
        Me.txtInitialPrice8.Properties.UseReadOnlyAppearance = False
        Me.txtInitialPrice8.Size = New System.Drawing.Size(303, 26)
        Me.txtInitialPrice8.StyleController = Me.LayoutControl1
        Me.txtInitialPrice8.TabIndex = 42
        Me.txtInitialPrice8.Tag = "modelInitialPrice8,0,1,2"
        Me.txtInitialPrice8.Visible = False
        '
        'txtDisc8
        '
        Me.txtDisc8.EditValue = "0%"
        Me.txtDisc8.Location = New System.Drawing.Point(343, 675)
        Me.txtDisc8.Margin = New System.Windows.Forms.Padding(15)
        Me.txtDisc8.Name = "txtDisc8"
        Me.txtDisc8.Properties.DisplayFormat.FormatString = "c"
        Me.txtDisc8.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtDisc8.Properties.EditFormat.FormatString = "n2"
        Me.txtDisc8.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtDisc8.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtDisc8.Properties.MaskSettings.Set("MaskManagerType", GetType(DevExpress.Data.Mask.NumericMaskManager))
        Me.txtDisc8.Properties.MaskSettings.Set("mask", "P0")
        Me.txtDisc8.Properties.Tag = "BenchExtraPrice"
        Me.txtDisc8.Properties.UseReadOnlyAppearance = False
        Me.txtDisc8.Size = New System.Drawing.Size(294, 26)
        Me.txtDisc8.StyleController = Me.LayoutControl1
        Me.txtDisc8.TabIndex = 42
        Me.txtDisc8.Tag = "discount8,0,1,2"
        Me.txtDisc8.Visible = False
        '
        'txtDiscount8
        '
        Me.txtDiscount8.EditValue = "0,00 €"
        Me.txtDiscount8.Location = New System.Drawing.Point(641, 675)
        Me.txtDiscount8.Margin = New System.Windows.Forms.Padding(15)
        Me.txtDiscount8.Name = "txtDiscount8"
        Me.txtDiscount8.Properties.DisplayFormat.FormatString = "c"
        Me.txtDiscount8.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtDiscount8.Properties.EditFormat.FormatString = "n2"
        Me.txtDiscount8.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtDiscount8.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtDiscount8.Properties.MaskSettings.Set("MaskManagerType", GetType(DevExpress.Data.Mask.NumericMaskManager))
        Me.txtDiscount8.Properties.MaskSettings.Set("mask", "c2")
        Me.txtDiscount8.Properties.ReadOnly = True
        Me.txtDiscount8.Properties.Tag = "BenchExtraPrice"
        Me.txtDiscount8.Properties.UseReadOnlyAppearance = False
        Me.txtDiscount8.Size = New System.Drawing.Size(325, 26)
        Me.txtDiscount8.StyleController = Me.LayoutControl1
        Me.txtDiscount8.TabIndex = 42
        Me.txtDiscount8.Tag = "modelDiscount8,0,1,2"
        Me.txtDiscount8.Visible = False
        '
        'txtFinalPrice8
        '
        Me.txtFinalPrice8.EditValue = "0,00 €"
        Me.txtFinalPrice8.Location = New System.Drawing.Point(970, 675)
        Me.txtFinalPrice8.Margin = New System.Windows.Forms.Padding(15)
        Me.txtFinalPrice8.Name = "txtFinalPrice8"
        Me.txtFinalPrice8.Properties.DisplayFormat.FormatString = "c"
        Me.txtFinalPrice8.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtFinalPrice8.Properties.EditFormat.FormatString = "n2"
        Me.txtFinalPrice8.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtFinalPrice8.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtFinalPrice8.Properties.MaskSettings.Set("MaskManagerType", GetType(DevExpress.Data.Mask.NumericMaskManager))
        Me.txtFinalPrice8.Properties.MaskSettings.Set("mask", "c2")
        Me.txtFinalPrice8.Properties.ReadOnly = True
        Me.txtFinalPrice8.Properties.Tag = "BenchExtraPrice"
        Me.txtFinalPrice8.Properties.UseReadOnlyAppearance = False
        Me.txtFinalPrice8.Size = New System.Drawing.Size(347, 26)
        Me.txtFinalPrice8.StyleController = Me.LayoutControl1
        Me.txtFinalPrice8.TabIndex = 42
        Me.txtFinalPrice8.Tag = "modelFinalPrice8,0,1,2"
        Me.txtFinalPrice8.Visible = False
        '
        'txtInitialPrice9
        '
        Me.txtInitialPrice9.EditValue = "0,00 €"
        Me.txtInitialPrice9.Location = New System.Drawing.Point(36, 675)
        Me.txtInitialPrice9.Margin = New System.Windows.Forms.Padding(15)
        Me.txtInitialPrice9.Name = "txtInitialPrice9"
        Me.txtInitialPrice9.Properties.DisplayFormat.FormatString = "c"
        Me.txtInitialPrice9.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtInitialPrice9.Properties.EditFormat.FormatString = "n2"
        Me.txtInitialPrice9.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtInitialPrice9.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtInitialPrice9.Properties.MaskSettings.Set("MaskManagerType", GetType(DevExpress.Data.Mask.NumericMaskManager))
        Me.txtInitialPrice9.Properties.MaskSettings.Set("mask", "c2")
        Me.txtInitialPrice9.Properties.Tag = "BenchExtraPrice"
        Me.txtInitialPrice9.Properties.UseReadOnlyAppearance = False
        Me.txtInitialPrice9.Size = New System.Drawing.Size(303, 26)
        Me.txtInitialPrice9.StyleController = Me.LayoutControl1
        Me.txtInitialPrice9.TabIndex = 42
        Me.txtInitialPrice9.Tag = "modelInitialPrice9,0,1,2"
        Me.txtInitialPrice9.Visible = False
        '
        'txtDisc9
        '
        Me.txtDisc9.EditValue = "0%"
        Me.txtDisc9.Location = New System.Drawing.Point(343, 675)
        Me.txtDisc9.Margin = New System.Windows.Forms.Padding(15)
        Me.txtDisc9.Name = "txtDisc9"
        Me.txtDisc9.Properties.DisplayFormat.FormatString = "c"
        Me.txtDisc9.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtDisc9.Properties.EditFormat.FormatString = "n2"
        Me.txtDisc9.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtDisc9.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtDisc9.Properties.MaskSettings.Set("MaskManagerType", GetType(DevExpress.Data.Mask.NumericMaskManager))
        Me.txtDisc9.Properties.MaskSettings.Set("mask", "P0")
        Me.txtDisc9.Properties.Tag = "BenchExtraPrice"
        Me.txtDisc9.Properties.UseReadOnlyAppearance = False
        Me.txtDisc9.Size = New System.Drawing.Size(294, 26)
        Me.txtDisc9.StyleController = Me.LayoutControl1
        Me.txtDisc9.TabIndex = 42
        Me.txtDisc9.Tag = "discount9,0,1,2"
        Me.txtDisc9.Visible = False
        '
        'txtDiscount9
        '
        Me.txtDiscount9.EditValue = "0,00 €"
        Me.txtDiscount9.Location = New System.Drawing.Point(641, 675)
        Me.txtDiscount9.Margin = New System.Windows.Forms.Padding(15)
        Me.txtDiscount9.Name = "txtDiscount9"
        Me.txtDiscount9.Properties.DisplayFormat.FormatString = "c"
        Me.txtDiscount9.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtDiscount9.Properties.EditFormat.FormatString = "n2"
        Me.txtDiscount9.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtDiscount9.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtDiscount9.Properties.MaskSettings.Set("MaskManagerType", GetType(DevExpress.Data.Mask.NumericMaskManager))
        Me.txtDiscount9.Properties.MaskSettings.Set("mask", "c2")
        Me.txtDiscount9.Properties.ReadOnly = True
        Me.txtDiscount9.Properties.Tag = "BenchExtraPrice"
        Me.txtDiscount9.Properties.UseReadOnlyAppearance = False
        Me.txtDiscount9.Size = New System.Drawing.Size(325, 26)
        Me.txtDiscount9.StyleController = Me.LayoutControl1
        Me.txtDiscount9.TabIndex = 42
        Me.txtDiscount9.Tag = "modelDiscount9,0,1,2"
        Me.txtDiscount9.Visible = False
        '
        'txtFinalPrice9
        '
        Me.txtFinalPrice9.EditValue = "0,00 €"
        Me.txtFinalPrice9.Location = New System.Drawing.Point(970, 675)
        Me.txtFinalPrice9.Margin = New System.Windows.Forms.Padding(15)
        Me.txtFinalPrice9.Name = "txtFinalPrice9"
        Me.txtFinalPrice9.Properties.DisplayFormat.FormatString = "c"
        Me.txtFinalPrice9.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtFinalPrice9.Properties.EditFormat.FormatString = "n2"
        Me.txtFinalPrice9.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtFinalPrice9.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtFinalPrice9.Properties.MaskSettings.Set("MaskManagerType", GetType(DevExpress.Data.Mask.NumericMaskManager))
        Me.txtFinalPrice9.Properties.MaskSettings.Set("mask", "c2")
        Me.txtFinalPrice9.Properties.ReadOnly = True
        Me.txtFinalPrice9.Properties.Tag = "BenchExtraPrice"
        Me.txtFinalPrice9.Properties.UseReadOnlyAppearance = False
        Me.txtFinalPrice9.Size = New System.Drawing.Size(347, 26)
        Me.txtFinalPrice9.StyleController = Me.LayoutControl1
        Me.txtFinalPrice9.TabIndex = 42
        Me.txtFinalPrice9.Tag = "modelFinalPrice9,0,1,2"
        Me.txtFinalPrice9.Visible = False
        '
        'txtInitialPrice10
        '
        Me.txtInitialPrice10.EditValue = "0,00 €"
        Me.txtInitialPrice10.Location = New System.Drawing.Point(36, 675)
        Me.txtInitialPrice10.Margin = New System.Windows.Forms.Padding(15)
        Me.txtInitialPrice10.Name = "txtInitialPrice10"
        Me.txtInitialPrice10.Properties.DisplayFormat.FormatString = "c"
        Me.txtInitialPrice10.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtInitialPrice10.Properties.EditFormat.FormatString = "n2"
        Me.txtInitialPrice10.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtInitialPrice10.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtInitialPrice10.Properties.MaskSettings.Set("MaskManagerType", GetType(DevExpress.Data.Mask.NumericMaskManager))
        Me.txtInitialPrice10.Properties.MaskSettings.Set("mask", "c2")
        Me.txtInitialPrice10.Properties.Tag = "BenchExtraPrice"
        Me.txtInitialPrice10.Properties.UseReadOnlyAppearance = False
        Me.txtInitialPrice10.Size = New System.Drawing.Size(303, 26)
        Me.txtInitialPrice10.StyleController = Me.LayoutControl1
        Me.txtInitialPrice10.TabIndex = 42
        Me.txtInitialPrice10.Tag = "modelInitialPrice10,0,1,2"
        Me.txtInitialPrice10.Visible = False
        '
        'txtDisc10
        '
        Me.txtDisc10.EditValue = "0%"
        Me.txtDisc10.Location = New System.Drawing.Point(343, 675)
        Me.txtDisc10.Margin = New System.Windows.Forms.Padding(15)
        Me.txtDisc10.Name = "txtDisc10"
        Me.txtDisc10.Properties.DisplayFormat.FormatString = "c"
        Me.txtDisc10.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtDisc10.Properties.EditFormat.FormatString = "n2"
        Me.txtDisc10.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtDisc10.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtDisc10.Properties.MaskSettings.Set("MaskManagerType", GetType(DevExpress.Data.Mask.NumericMaskManager))
        Me.txtDisc10.Properties.MaskSettings.Set("mask", "P0")
        Me.txtDisc10.Properties.Tag = "BenchExtraPrice"
        Me.txtDisc10.Properties.UseReadOnlyAppearance = False
        Me.txtDisc10.Size = New System.Drawing.Size(294, 26)
        Me.txtDisc10.StyleController = Me.LayoutControl1
        Me.txtDisc10.TabIndex = 42
        Me.txtDisc10.Tag = "discount10,0,1,2"
        Me.txtDisc10.Visible = False
        '
        'txtDiscount10
        '
        Me.txtDiscount10.EditValue = "0,00 €"
        Me.txtDiscount10.Location = New System.Drawing.Point(641, 675)
        Me.txtDiscount10.Margin = New System.Windows.Forms.Padding(15)
        Me.txtDiscount10.Name = "txtDiscount10"
        Me.txtDiscount10.Properties.DisplayFormat.FormatString = "c"
        Me.txtDiscount10.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtDiscount10.Properties.EditFormat.FormatString = "n2"
        Me.txtDiscount10.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtDiscount10.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtDiscount10.Properties.MaskSettings.Set("MaskManagerType", GetType(DevExpress.Data.Mask.NumericMaskManager))
        Me.txtDiscount10.Properties.MaskSettings.Set("mask", "c2")
        Me.txtDiscount10.Properties.ReadOnly = True
        Me.txtDiscount10.Properties.Tag = "BenchExtraPrice"
        Me.txtDiscount10.Properties.UseReadOnlyAppearance = False
        Me.txtDiscount10.Size = New System.Drawing.Size(325, 26)
        Me.txtDiscount10.StyleController = Me.LayoutControl1
        Me.txtDiscount10.TabIndex = 42
        Me.txtDiscount10.Tag = "modelDiscount10,0,1,2"
        Me.txtDiscount10.Visible = False
        '
        'txtFinalPrice10
        '
        Me.txtFinalPrice10.EditValue = "0,00 €"
        Me.txtFinalPrice10.Location = New System.Drawing.Point(970, 675)
        Me.txtFinalPrice10.Margin = New System.Windows.Forms.Padding(15)
        Me.txtFinalPrice10.Name = "txtFinalPrice10"
        Me.txtFinalPrice10.Properties.DisplayFormat.FormatString = "c"
        Me.txtFinalPrice10.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtFinalPrice10.Properties.EditFormat.FormatString = "n2"
        Me.txtFinalPrice10.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtFinalPrice10.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtFinalPrice10.Properties.MaskSettings.Set("MaskManagerType", GetType(DevExpress.Data.Mask.NumericMaskManager))
        Me.txtFinalPrice10.Properties.MaskSettings.Set("mask", "c2")
        Me.txtFinalPrice10.Properties.ReadOnly = True
        Me.txtFinalPrice10.Properties.Tag = "BenchExtraPrice"
        Me.txtFinalPrice10.Properties.UseReadOnlyAppearance = False
        Me.txtFinalPrice10.Size = New System.Drawing.Size(347, 26)
        Me.txtFinalPrice10.StyleController = Me.LayoutControl1
        Me.txtFinalPrice10.TabIndex = 42
        Me.txtFinalPrice10.Tag = "modelFinalPrice10,0,1,2"
        Me.txtFinalPrice10.Visible = False
        '
        'txtTotAmt
        '
        Me.txtTotAmt.EditValue = "0,00 €"
        Me.txtTotAmt.Location = New System.Drawing.Point(1184, 883)
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
        Me.txtTotAmt.Size = New System.Drawing.Size(157, 30)
        Me.txtTotAmt.StyleController = Me.LayoutControl1
        Me.txtTotAmt.TabIndex = 42
        Me.txtTotAmt.Tag = "Totamt,0"
        Me.txtTotAmt.Visible = False
        '
        'LayoutControlGroup12
        '
        Me.LayoutControlGroup12.GroupBordersVisible = False
        Me.LayoutControlGroup12.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup12.Name = "item0"
        Me.LayoutControlGroup12.Size = New System.Drawing.Size(1813, 208)
        Me.LayoutControlGroup12.Tag = "LayoutRootGroupForRestore"
        '
        'LayoutControlGroup11
        '
        Me.LayoutControlGroup11.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup11.Name = "LayoutControlGroup11"
        Me.LayoutControlGroup11.Size = New System.Drawing.Size(1813, 208)
        '
        'Root
        '
        Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.Root.GroupBordersVisible = False
        Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LExit, Me.LSave, Me.LGroupOrderDetails1, Me.LPrintOffer, Me.LvisibleVAT, Me.LGroupOrderDetails2, Me.LayoutControlGroup9, Me.LCost, Me.LConvertToOrder, Me.EmptySpaceItem14, Me.LTotAmt, Me.LPrivateAgreement, Me.LOrder, Me.LNewRecord, Me.LayoutControlItem1})
        Me.Root.Name = "Root"
        Me.Root.OptionsItemText.TextToControlDistance = 1
        Me.Root.Size = New System.Drawing.Size(1353, 961)
        Me.Root.TextVisible = False
        '
        'LExit
        '
        Me.LExit.Control = Me.cmdExit
        Me.LExit.Location = New System.Drawing.Point(1240, 905)
        Me.LExit.Name = "LExit"
        Me.LExit.Size = New System.Drawing.Size(93, 36)
        Me.LExit.Text = "Έξοδος"
        Me.LExit.TextSize = New System.Drawing.Size(0, 0)
        Me.LExit.TextVisible = False
        '
        'LSave
        '
        Me.LSave.Control = Me.cmdSave
        Me.LSave.Location = New System.Drawing.Point(1111, 905)
        Me.LSave.Name = "LSave"
        Me.LSave.Size = New System.Drawing.Size(129, 36)
        Me.LSave.Text = "Αποθήκευση"
        Me.LSave.TextSize = New System.Drawing.Size(0, 0)
        Me.LSave.TextVisible = False
        '
        'LGroupOrderDetails1
        '
        Me.LGroupOrderDetails1.AppearanceGroup.BorderColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Question
        Me.LGroupOrderDetails1.AppearanceGroup.Options.UseBorderColor = True
        Me.LGroupOrderDetails1.CustomizationFormText = "Στοιχεία Προσφοράς/Παραγγελίας"
        Me.LGroupOrderDetails1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LarProt, Me.EmptySpaceItem1, Me.LEMP, Me.LayoutControlItem9, Me.LayoutControlItem41, Me.Ldtpresentation, Me.LayoutControlItem31, Me.LlblDate, Me.LofferAccepted, Me.LayoutControlItem15, Me.LCompProject, Me.LCompCollection, Me.LCusCollection, Me.LGenOffer})
        Me.LGroupOrderDetails1.Location = New System.Drawing.Point(0, 0)
        Me.LGroupOrderDetails1.Name = "LGroupOrderDetails1"
        Me.LGroupOrderDetails1.OptionsItemText.TextToControlDistance = 1
        Me.LGroupOrderDetails1.Size = New System.Drawing.Size(1333, 220)
        Me.LGroupOrderDetails1.Text = "Στοιχεία Προσφοράς/Παραγγελίας"
        '
        'LarProt
        '
        Me.LarProt.Control = Me.txtarProt
        Me.LarProt.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LarProt.CustomizationFormText = "Αρ. Παραγγελίας"
        Me.LarProt.Location = New System.Drawing.Point(0, 0)
        Me.LarProt.Name = "LarProt"
        Me.LarProt.Size = New System.Drawing.Size(323, 32)
        Me.LarProt.Text = "Αρ. Παραγγελίας"
        Me.LarProt.TextSize = New System.Drawing.Size(201, 19)
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(323, 0)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(554, 32)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'LEMP
        '
        Me.LEMP.Control = Me.cboEMP
        Me.LEMP.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LEMP.CustomizationFormText = "Πωλητής"
        Me.LEMP.ImageOptions.Image = CType(resources.GetObject("LEMP.ImageOptions.Image"), System.Drawing.Image)
        Me.LEMP.Location = New System.Drawing.Point(0, 32)
        Me.LEMP.Name = "LEMP"
        Me.LEMP.Size = New System.Drawing.Size(1309, 30)
        Me.LEMP.Tag = "1"
        Me.LEMP.Text = "Πωλητής"
        Me.LEMP.TextLocation = DevExpress.Utils.Locations.Left
        Me.LEMP.TextSize = New System.Drawing.Size(201, 19)
        '
        'LayoutControlItem9
        '
        Me.LayoutControlItem9.Control = Me.cboCUS
        Me.LayoutControlItem9.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem9.CustomizationFormText = "Πελάτης"
        Me.LayoutControlItem9.ImageOptions.Image = CType(resources.GetObject("LayoutControlItem9.ImageOptions.Image"), System.Drawing.Image)
        Me.LayoutControlItem9.Location = New System.Drawing.Point(0, 98)
        Me.LayoutControlItem9.Name = "LayoutControlItem9"
        Me.LayoutControlItem9.Size = New System.Drawing.Size(595, 36)
        Me.LayoutControlItem9.Tag = "1"
        Me.LayoutControlItem9.Text = "Πελάτης"
        Me.LayoutControlItem9.TextLocation = DevExpress.Utils.Locations.Left
        Me.LayoutControlItem9.TextSize = New System.Drawing.Size(201, 19)
        '
        'LayoutControlItem41
        '
        Me.LayoutControlItem41.Control = Me.cboTRANSH
        Me.LayoutControlItem41.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem41.CustomizationFormText = "Έργο Πελάτη"
        Me.LayoutControlItem41.HighlightFocusedItem = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlItem41.ImageOptions.Image = CType(resources.GetObject("LayoutControlItem41.ImageOptions.Image"), System.Drawing.Image)
        Me.LayoutControlItem41.Location = New System.Drawing.Point(595, 98)
        Me.LayoutControlItem41.Name = "LayoutControlItem41"
        Me.LayoutControlItem41.Size = New System.Drawing.Size(602, 36)
        Me.LayoutControlItem41.Tag = "1"
        Me.LayoutControlItem41.Text = "Έργο Πελάτη"
        Me.LayoutControlItem41.TextSize = New System.Drawing.Size(201, 19)
        '
        'Ldtpresentation
        '
        Me.Ldtpresentation.Control = Me.dtpresentation
        Me.Ldtpresentation.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.Ldtpresentation.CustomizationFormText = "Ημερ/νία Παραγγελίας"
        Me.Ldtpresentation.Location = New System.Drawing.Point(0, 134)
        Me.Ldtpresentation.Name = "Ldtpresentation"
        Me.Ldtpresentation.Size = New System.Drawing.Size(595, 30)
        Me.Ldtpresentation.Tag = "1"
        Me.Ldtpresentation.Text = "Ημερ/νία Παραγγελίας"
        Me.Ldtpresentation.TextSize = New System.Drawing.Size(201, 19)
        '
        'LayoutControlItem31
        '
        Me.LayoutControlItem31.Control = Me.txtdtdaysOfDelivery
        Me.LayoutControlItem31.ImageOptions.Image = Global.DreamyKitchenCRM.My.Resources.Resources.rsz_11rsz_asterisk
        Me.LayoutControlItem31.Location = New System.Drawing.Point(595, 134)
        Me.LayoutControlItem31.Name = "LayoutControlItem31"
        Me.LayoutControlItem31.Size = New System.Drawing.Size(355, 30)
        Me.LayoutControlItem31.Tag = "1"
        Me.LayoutControlItem31.Text = "Μέρες Παράδοσης"
        Me.LayoutControlItem31.TextSize = New System.Drawing.Size(201, 19)
        '
        'LlblDate
        '
        Me.LlblDate.Control = Me.lblDate
        Me.LlblDate.Location = New System.Drawing.Point(950, 134)
        Me.LlblDate.Name = "LlblDate"
        Me.LlblDate.Size = New System.Drawing.Size(359, 30)
        Me.LlblDate.Text = "Ημερομηνία Παράδοσης: (ΗΗ/ΜΜ/ΕΕΕΕ)"
        Me.LlblDate.TextSize = New System.Drawing.Size(0, 0)
        Me.LlblDate.TextVisible = False
        '
        'LofferAccepted
        '
        Me.LofferAccepted.Control = Me.chkofferAccepted
        Me.LofferAccepted.Location = New System.Drawing.Point(1103, 0)
        Me.LofferAccepted.Name = "LofferAccepted"
        Me.LofferAccepted.Size = New System.Drawing.Size(206, 32)
        Me.LofferAccepted.Text = "Αποδοχή Προσφοράς"
        Me.LofferAccepted.TextSize = New System.Drawing.Size(0, 0)
        Me.LofferAccepted.TextVisible = False
        '
        'LayoutControlItem15
        '
        Me.LayoutControlItem15.Control = Me.cboCompany
        Me.LayoutControlItem15.Location = New System.Drawing.Point(0, 62)
        Me.LayoutControlItem15.Name = "LayoutControlItem15"
        Me.LayoutControlItem15.Size = New System.Drawing.Size(595, 36)
        Me.LayoutControlItem15.Text = "Εταιρία"
        Me.LayoutControlItem15.TextSize = New System.Drawing.Size(201, 19)
        '
        'LCompProject
        '
        Me.LCompProject.Control = Me.cboCompProject
        Me.LCompProject.Location = New System.Drawing.Point(595, 62)
        Me.LCompProject.Name = "LCompProject"
        Me.LCompProject.Size = New System.Drawing.Size(602, 36)
        Me.LCompProject.Text = "Έργο Εταιρίας"
        Me.LCompProject.TextSize = New System.Drawing.Size(201, 19)
        '
        'LCompCollection
        '
        Me.LCompCollection.Control = Me.cmdCompCollection
        Me.LCompCollection.Location = New System.Drawing.Point(1197, 62)
        Me.LCompCollection.Name = "LCompCollection"
        Me.LCompCollection.Size = New System.Drawing.Size(112, 36)
        Me.LCompCollection.Text = "Είσπραξη"
        Me.LCompCollection.TextSize = New System.Drawing.Size(0, 0)
        Me.LCompCollection.TextVisible = False
        '
        'LCusCollection
        '
        Me.LCusCollection.Control = Me.cmdCusCollection
        Me.LCusCollection.Location = New System.Drawing.Point(1197, 98)
        Me.LCusCollection.Name = "LCusCollection"
        Me.LCusCollection.Size = New System.Drawing.Size(112, 36)
        Me.LCusCollection.Text = "Είσπραξη"
        Me.LCusCollection.TextSize = New System.Drawing.Size(0, 0)
        Me.LCusCollection.TextVisible = False
        '
        'LGenOffer
        '
        Me.LGenOffer.Control = Me.chkGenOffer
        Me.LGenOffer.Location = New System.Drawing.Point(877, 0)
        Me.LGenOffer.Name = "LGenOffer"
        Me.LGenOffer.Size = New System.Drawing.Size(226, 32)
        Me.LGenOffer.Text = "Γενική Προσφορά Εταιρίας"
        Me.LGenOffer.TextSize = New System.Drawing.Size(0, 0)
        Me.LGenOffer.TextVisible = False
        '
        'LPrintOffer
        '
        Me.LPrintOffer.Control = Me.cmdPrintOffer
        Me.LPrintOffer.Location = New System.Drawing.Point(0, 905)
        Me.LPrintOffer.Name = "LPrintOffer"
        Me.LPrintOffer.Size = New System.Drawing.Size(113, 36)
        Me.LPrintOffer.Text = "Εκτύπωση"
        Me.LPrintOffer.TextSize = New System.Drawing.Size(0, 0)
        Me.LPrintOffer.TextVisible = False
        '
        'LvisibleVAT
        '
        Me.LvisibleVAT.Control = Me.chkVatVisible
        Me.LvisibleVAT.Location = New System.Drawing.Point(113, 905)
        Me.LvisibleVAT.Name = "LvisibleVAT"
        Me.LvisibleVAT.Size = New System.Drawing.Size(289, 36)
        Me.LvisibleVAT.Text = "Εμφάνιση ΦΠΑ στην εκτύπωση"
        Me.LvisibleVAT.TextSize = New System.Drawing.Size(0, 0)
        Me.LvisibleVAT.TextVisible = False
        '
        'LGroupOrderDetails2
        '
        Me.LGroupOrderDetails2.AppearanceGroup.BorderColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Primary
        Me.LGroupOrderDetails2.AppearanceGroup.Options.UseBorderColor = True
        Me.LGroupOrderDetails2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem32, Me.LayoutControlItem33, Me.LayoutControlItem39})
        Me.LGroupOrderDetails2.Location = New System.Drawing.Point(0, 220)
        Me.LGroupOrderDetails2.Name = "LGroupOrderDetails2"
        Me.LGroupOrderDetails2.Size = New System.Drawing.Size(1333, 234)
        Me.LGroupOrderDetails2.Text = "Στοιχεία Προσφοράς/Παραγγελίας"
        '
        'LayoutControlItem32
        '
        Me.LayoutControlItem32.Control = Me.txtDescription
        Me.LayoutControlItem32.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem32.CustomizationFormText = "Περιγραφή"
        Me.LayoutControlItem32.HighlightFocusedItem = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlItem32.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem32.Name = "LayoutControlItem32"
        Me.LayoutControlItem32.Size = New System.Drawing.Size(441, 178)
        Me.LayoutControlItem32.Text = "Περιγραφή"
        Me.LayoutControlItem32.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem32.TextSize = New System.Drawing.Size(201, 19)
        '
        'LayoutControlItem33
        '
        Me.LayoutControlItem33.Control = Me.txtComments
        Me.LayoutControlItem33.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem33.CustomizationFormText = "Σχόλια"
        Me.LayoutControlItem33.HighlightFocusedItem = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlItem33.Location = New System.Drawing.Point(441, 0)
        Me.LayoutControlItem33.Name = "LayoutControlItem33"
        Me.LayoutControlItem33.Size = New System.Drawing.Size(443, 178)
        Me.LayoutControlItem33.Text = "Σχόλια"
        Me.LayoutControlItem33.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem33.TextSize = New System.Drawing.Size(201, 19)
        '
        'LayoutControlItem39
        '
        Me.LayoutControlItem39.Control = Me.txtNotes
        Me.LayoutControlItem39.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem39.CustomizationFormText = "Παρατηρήσεις"
        Me.LayoutControlItem39.HighlightFocusedItem = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlItem39.Location = New System.Drawing.Point(884, 0)
        Me.LayoutControlItem39.Name = "LayoutControlItem39"
        Me.LayoutControlItem39.Size = New System.Drawing.Size(425, 178)
        Me.LayoutControlItem39.Text = "Παρατηρήσεις"
        Me.LayoutControlItem39.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem39.TextSize = New System.Drawing.Size(201, 19)
        '
        'LayoutControlGroup9
        '
        Me.LayoutControlGroup9.AppearanceGroup.BorderColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Danger
        Me.LayoutControlGroup9.AppearanceGroup.Options.UseBorderColor = True
        Me.LayoutControlGroup9.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.TabbedControlGroup1})
        Me.LayoutControlGroup9.Location = New System.Drawing.Point(0, 454)
        Me.LayoutControlGroup9.Name = "LayoutControlGroup9"
        Me.LayoutControlGroup9.Size = New System.Drawing.Size(1333, 263)
        Me.LayoutControlGroup9.Text = "Ανάλυση Πορτών"
        '
        'TabbedControlGroup1
        '
        Me.TabbedControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.TabbedControlGroup1.Name = "TabbedControlGroup1"
        Me.TabbedControlGroup1.SelectedTabPage = Me.LayoutControlGroup2
        Me.TabbedControlGroup1.Size = New System.Drawing.Size(1309, 207)
        Me.TabbedControlGroup1.TabPages.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlGroup2, Me.LayoutControlGroup3, Me.LayoutControlGroup5, Me.LayoutControlGroup6, Me.LayoutControlGroup7, Me.LayoutControlGroup8, Me.LayoutRootGroupForRestore, Me.LayoutControlGroup13, Me.LayoutControlGroup15, Me.LayoutControlGroup17})
        '
        'LayoutControlGroup2
        '
        Me.LayoutControlGroup2.AppearanceGroup.BorderColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Danger
        Me.LayoutControlGroup2.AppearanceGroup.Options.UseBorderColor = True
        Me.LayoutControlGroup2.CustomizationFormText = "Πόρτα 1"
        Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem12, Me.LayoutControlItem56, Me.LayoutControlItem24, Me.LayoutControlItem105, Me.Lcost3, Me.LayoutControlItem106, Me.LayoutControlItem107, Me.LayoutControlItem58, Me.LayoutControlItem18, Me.LayoutControlItem37})
        Me.LayoutControlGroup2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup2.Name = "LayoutControlGroup2"
        Me.LayoutControlGroup2.Size = New System.Drawing.Size(1285, 150)
        Me.LayoutControlGroup2.Text = "Πόρτα 1"
        '
        'LayoutControlItem12
        '
        Me.LayoutControlItem12.Control = Me.txtDimension1
        Me.LayoutControlItem12.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem12.CustomizationFormText = "Διάσταση"
        Me.LayoutControlItem12.Location = New System.Drawing.Point(670, 0)
        Me.LayoutControlItem12.Name = "LayoutControlItem12"
        Me.LayoutControlItem12.Size = New System.Drawing.Size(615, 50)
        Me.LayoutControlItem12.Text = "Διάσταση"
        Me.LayoutControlItem12.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem12.TextSize = New System.Drawing.Size(201, 19)
        '
        'LayoutControlItem56
        '
        Me.LayoutControlItem56.Control = Me.cboType1
        Me.LayoutControlItem56.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem56.CustomizationFormText = "Τύπος Πόρτας"
        Me.LayoutControlItem56.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem56.Name = "LayoutControlItem56"
        Me.LayoutControlItem56.Size = New System.Drawing.Size(247, 50)
        Me.LayoutControlItem56.Text = "Τύπος Πόρτας"
        Me.LayoutControlItem56.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem56.TextSize = New System.Drawing.Size(201, 19)
        '
        'LayoutControlItem24
        '
        Me.LayoutControlItem24.Control = Me.cboKasa1
        Me.LayoutControlItem24.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem24.CustomizationFormText = "Πάχος Κάσας"
        Me.LayoutControlItem24.Location = New System.Drawing.Point(247, 0)
        Me.LayoutControlItem24.Name = "LayoutControlItem24"
        Me.LayoutControlItem24.Size = New System.Drawing.Size(423, 50)
        Me.LayoutControlItem24.Text = "Πάχος Κάσας"
        Me.LayoutControlItem24.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem24.TextSize = New System.Drawing.Size(201, 19)
        '
        'LayoutControlItem105
        '
        Me.LayoutControlItem105.Control = Me.txtInitialPrice1
        Me.LayoutControlItem105.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem105.CustomizationFormText = "Αρχική Τιμή"
        Me.LayoutControlItem105.HighlightFocusedItem = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlItem105.Location = New System.Drawing.Point(0, 100)
        Me.LayoutControlItem105.Name = "LayoutControlItem105"
        Me.LayoutControlItem105.Size = New System.Drawing.Size(307, 50)
        Me.LayoutControlItem105.Text = "Αρχική Τιμή"
        Me.LayoutControlItem105.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem105.TextSize = New System.Drawing.Size(201, 19)
        '
        'Lcost3
        '
        Me.Lcost3.Control = Me.txtDisc1
        Me.Lcost3.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.Lcost3.CustomizationFormText = "Έκπτωση"
        Me.Lcost3.HighlightFocusedItem = DevExpress.Utils.DefaultBoolean.[True]
        Me.Lcost3.Location = New System.Drawing.Point(307, 100)
        Me.Lcost3.Name = "Lcost3"
        Me.Lcost3.Size = New System.Drawing.Size(298, 50)
        Me.Lcost3.Text = "Έκπτωση"
        Me.Lcost3.TextLocation = DevExpress.Utils.Locations.Top
        Me.Lcost3.TextSize = New System.Drawing.Size(201, 19)
        '
        'LayoutControlItem106
        '
        Me.LayoutControlItem106.Control = Me.txtDiscount1
        Me.LayoutControlItem106.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem106.CustomizationFormText = "Ποσό Έκπτωσης"
        Me.LayoutControlItem106.HighlightFocusedItem = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlItem106.Location = New System.Drawing.Point(605, 100)
        Me.LayoutControlItem106.Name = "LayoutControlItem106"
        Me.LayoutControlItem106.Size = New System.Drawing.Size(329, 50)
        Me.LayoutControlItem106.Text = "Ποσό Έκπτωσης"
        Me.LayoutControlItem106.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem106.TextSize = New System.Drawing.Size(201, 19)
        '
        'LayoutControlItem107
        '
        Me.LayoutControlItem107.Control = Me.txtFinalPrice1
        Me.LayoutControlItem107.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem107.CustomizationFormText = "Τελική Τιμή(ΦΠΑ)"
        Me.LayoutControlItem107.HighlightFocusedItem = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlItem107.Location = New System.Drawing.Point(934, 100)
        Me.LayoutControlItem107.Name = "LayoutControlItem107"
        Me.LayoutControlItem107.Size = New System.Drawing.Size(351, 50)
        Me.LayoutControlItem107.Text = "Τελική Τιμή(ΦΠΑ)"
        Me.LayoutControlItem107.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem107.TextSize = New System.Drawing.Size(201, 19)
        '
        'LayoutControlItem58
        '
        Me.LayoutControlItem58.Control = Me.cboFora1
        Me.LayoutControlItem58.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem58.CustomizationFormText = "Φορά"
        Me.LayoutControlItem58.Location = New System.Drawing.Point(0, 50)
        Me.LayoutControlItem58.Name = "LayoutControlItem58"
        Me.LayoutControlItem58.Size = New System.Drawing.Size(247, 50)
        Me.LayoutControlItem58.Text = "Φορά"
        Me.LayoutControlItem58.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem58.TextSize = New System.Drawing.Size(201, 19)
        '
        'LayoutControlItem18
        '
        Me.LayoutControlItem18.Control = Me.cboValueListItem
        Me.LayoutControlItem18.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem18.CustomizationFormText = "Κωδικός Πόρτας"
        Me.LayoutControlItem18.Location = New System.Drawing.Point(247, 50)
        Me.LayoutControlItem18.Name = "LayoutControlItem18"
        Me.LayoutControlItem18.Size = New System.Drawing.Size(423, 50)
        Me.LayoutControlItem18.Text = "Κωδικός Πόρτας"
        Me.LayoutControlItem18.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem18.TextSize = New System.Drawing.Size(201, 19)
        '
        'LayoutControlItem37
        '
        Me.LayoutControlItem37.Control = Me.txtKnobs1
        Me.LayoutControlItem37.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem37.CustomizationFormText = "Πόμολα"
        Me.LayoutControlItem37.Location = New System.Drawing.Point(670, 50)
        Me.LayoutControlItem37.Name = "LayoutControlItem37"
        Me.LayoutControlItem37.Size = New System.Drawing.Size(615, 50)
        Me.LayoutControlItem37.Text = "Πόμολα"
        Me.LayoutControlItem37.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem37.TextSize = New System.Drawing.Size(201, 19)
        '
        'LayoutControlGroup3
        '
        Me.LayoutControlGroup3.CustomizationFormText = "Πόρτα 2"
        Me.LayoutControlGroup3.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem57, Me.LayoutControlItem25, Me.LayoutControlItem3, Me.LayoutControlItem23, Me.LayoutControlItem108, Me.Lcost1, Me.LayoutControlItem109, Me.LayoutControlItem110, Me.LayoutControlItem22, Me.LayoutControlItem13})
        Me.LayoutControlGroup3.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup3.Name = "LayoutControlGroup3"
        Me.LayoutControlGroup3.Size = New System.Drawing.Size(1285, 150)
        Me.LayoutControlGroup3.Text = "Πόρτα 2"
        '
        'LayoutControlItem57
        '
        Me.LayoutControlItem57.Control = Me.cboType2
        Me.LayoutControlItem57.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem57.CustomizationFormText = "Τύπος Πόρτας"
        Me.LayoutControlItem57.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem57.Name = "LayoutControlItem57"
        Me.LayoutControlItem57.Size = New System.Drawing.Size(247, 50)
        Me.LayoutControlItem57.Text = "Τύπος Πόρτας"
        Me.LayoutControlItem57.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem57.TextSize = New System.Drawing.Size(201, 19)
        '
        'LayoutControlItem25
        '
        Me.LayoutControlItem25.Control = Me.cboKasa2
        Me.LayoutControlItem25.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem25.CustomizationFormText = "Πάχος Κάσας"
        Me.LayoutControlItem25.Location = New System.Drawing.Point(247, 0)
        Me.LayoutControlItem25.Name = "LayoutControlItem25"
        Me.LayoutControlItem25.Size = New System.Drawing.Size(423, 50)
        Me.LayoutControlItem25.Text = "Πάχος Κάσας"
        Me.LayoutControlItem25.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem25.TextSize = New System.Drawing.Size(201, 19)
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.cboFora2
        Me.LayoutControlItem3.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem3.CustomizationFormText = "Φορά"
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 50)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(247, 50)
        Me.LayoutControlItem3.Text = "Φορά"
        Me.LayoutControlItem3.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(201, 19)
        '
        'LayoutControlItem23
        '
        Me.LayoutControlItem23.Control = Me.txtDimension2
        Me.LayoutControlItem23.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem23.CustomizationFormText = "Διάσταση"
        Me.LayoutControlItem23.Location = New System.Drawing.Point(670, 0)
        Me.LayoutControlItem23.Name = "LayoutControlItem23"
        Me.LayoutControlItem23.Size = New System.Drawing.Size(615, 50)
        Me.LayoutControlItem23.Text = "Διάσταση"
        Me.LayoutControlItem23.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem23.TextSize = New System.Drawing.Size(201, 19)
        '
        'LayoutControlItem108
        '
        Me.LayoutControlItem108.Control = Me.txtInitialPrice2
        Me.LayoutControlItem108.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem108.CustomizationFormText = "Αρχική Τιμή"
        Me.LayoutControlItem108.HighlightFocusedItem = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlItem108.Location = New System.Drawing.Point(0, 100)
        Me.LayoutControlItem108.Name = "LayoutControlItem108"
        Me.LayoutControlItem108.Size = New System.Drawing.Size(307, 50)
        Me.LayoutControlItem108.Text = "Αρχική Τιμή"
        Me.LayoutControlItem108.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem108.TextSize = New System.Drawing.Size(201, 19)
        '
        'Lcost1
        '
        Me.Lcost1.Control = Me.txtDisc2
        Me.Lcost1.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.Lcost1.CustomizationFormText = "Έκπτωση"
        Me.Lcost1.HighlightFocusedItem = DevExpress.Utils.DefaultBoolean.[True]
        Me.Lcost1.Location = New System.Drawing.Point(307, 100)
        Me.Lcost1.Name = "Lcost1"
        Me.Lcost1.Size = New System.Drawing.Size(298, 50)
        Me.Lcost1.Text = "Έκπτωση"
        Me.Lcost1.TextLocation = DevExpress.Utils.Locations.Top
        Me.Lcost1.TextSize = New System.Drawing.Size(201, 19)
        '
        'LayoutControlItem109
        '
        Me.LayoutControlItem109.Control = Me.txtDiscount2
        Me.LayoutControlItem109.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem109.CustomizationFormText = "Ποσό Έκπτωσης"
        Me.LayoutControlItem109.HighlightFocusedItem = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlItem109.Location = New System.Drawing.Point(605, 100)
        Me.LayoutControlItem109.Name = "LayoutControlItem109"
        Me.LayoutControlItem109.Size = New System.Drawing.Size(329, 50)
        Me.LayoutControlItem109.Text = "Ποσό Έκπτωσης"
        Me.LayoutControlItem109.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem109.TextSize = New System.Drawing.Size(201, 19)
        '
        'LayoutControlItem110
        '
        Me.LayoutControlItem110.Control = Me.txtFinalPrice2
        Me.LayoutControlItem110.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem110.CustomizationFormText = "Τελική Τιμή(ΦΠΑ)"
        Me.LayoutControlItem110.HighlightFocusedItem = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlItem110.Location = New System.Drawing.Point(934, 100)
        Me.LayoutControlItem110.Name = "LayoutControlItem110"
        Me.LayoutControlItem110.Size = New System.Drawing.Size(351, 50)
        Me.LayoutControlItem110.Text = "Τελική Τιμή(ΦΠΑ)"
        Me.LayoutControlItem110.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem110.TextSize = New System.Drawing.Size(201, 19)
        '
        'LayoutControlItem22
        '
        Me.LayoutControlItem22.Control = Me.cboVALUELISTITEM2
        Me.LayoutControlItem22.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem22.CustomizationFormText = "Κωδικός Πόρτας"
        Me.LayoutControlItem22.Location = New System.Drawing.Point(247, 50)
        Me.LayoutControlItem22.Name = "LayoutControlItem22"
        Me.LayoutControlItem22.Size = New System.Drawing.Size(423, 50)
        Me.LayoutControlItem22.Text = "Κωδικός Πόρτας"
        Me.LayoutControlItem22.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem22.TextSize = New System.Drawing.Size(201, 19)
        '
        'LayoutControlItem13
        '
        Me.LayoutControlItem13.Control = Me.txtKnobs2
        Me.LayoutControlItem13.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem13.CustomizationFormText = "Πόμολα"
        Me.LayoutControlItem13.Location = New System.Drawing.Point(670, 50)
        Me.LayoutControlItem13.Name = "LayoutControlItem13"
        Me.LayoutControlItem13.Size = New System.Drawing.Size(615, 50)
        Me.LayoutControlItem13.Text = "Πόμολα"
        Me.LayoutControlItem13.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem13.TextSize = New System.Drawing.Size(201, 19)
        '
        'LayoutControlGroup5
        '
        Me.LayoutControlGroup5.CustomizationFormText = "Πόρτα 3"
        Me.LayoutControlGroup5.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem59, Me.LayoutControlItem49, Me.LayoutControlItem5, Me.LayoutControlItem26, Me.LayoutControlItem111, Me.Lcost2, Me.LayoutControlItem112, Me.LayoutControlItem113, Me.LayoutControlItem63, Me.LayoutControlItem21})
        Me.LayoutControlGroup5.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup5.Name = "LayoutControlGroup5"
        Me.LayoutControlGroup5.Size = New System.Drawing.Size(1285, 150)
        Me.LayoutControlGroup5.Text = "Πόρτα 3"
        '
        'LayoutControlItem59
        '
        Me.LayoutControlItem59.Control = Me.cboType3
        Me.LayoutControlItem59.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem59.CustomizationFormText = "Τύπος Πόρτας"
        Me.LayoutControlItem59.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem59.Name = "LayoutControlItem59"
        Me.LayoutControlItem59.Size = New System.Drawing.Size(247, 50)
        Me.LayoutControlItem59.Text = "Τύπος Πόρτας"
        Me.LayoutControlItem59.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem59.TextSize = New System.Drawing.Size(201, 19)
        '
        'LayoutControlItem49
        '
        Me.LayoutControlItem49.Control = Me.cboKasa3
        Me.LayoutControlItem49.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem49.CustomizationFormText = "Πάχος Κάσας"
        Me.LayoutControlItem49.Location = New System.Drawing.Point(247, 0)
        Me.LayoutControlItem49.Name = "LayoutControlItem49"
        Me.LayoutControlItem49.Size = New System.Drawing.Size(423, 50)
        Me.LayoutControlItem49.Text = "Πάχος Κάσας"
        Me.LayoutControlItem49.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem49.TextSize = New System.Drawing.Size(201, 19)
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.cboFora3
        Me.LayoutControlItem5.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem5.CustomizationFormText = "Φορά"
        Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 50)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(247, 50)
        Me.LayoutControlItem5.Text = "Φορά"
        Me.LayoutControlItem5.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(201, 19)
        '
        'LayoutControlItem26
        '
        Me.LayoutControlItem26.Control = Me.txtDimension3
        Me.LayoutControlItem26.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem26.CustomizationFormText = "Διάσταση"
        Me.LayoutControlItem26.Location = New System.Drawing.Point(670, 0)
        Me.LayoutControlItem26.Name = "LayoutControlItem26"
        Me.LayoutControlItem26.Size = New System.Drawing.Size(615, 50)
        Me.LayoutControlItem26.Text = "Διάσταση"
        Me.LayoutControlItem26.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem26.TextSize = New System.Drawing.Size(201, 19)
        '
        'LayoutControlItem111
        '
        Me.LayoutControlItem111.Control = Me.txtInitialPrice3
        Me.LayoutControlItem111.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem111.CustomizationFormText = "Αρχική Τιμή"
        Me.LayoutControlItem111.HighlightFocusedItem = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlItem111.Location = New System.Drawing.Point(0, 100)
        Me.LayoutControlItem111.Name = "LayoutControlItem111"
        Me.LayoutControlItem111.Size = New System.Drawing.Size(307, 50)
        Me.LayoutControlItem111.Text = "Αρχική Τιμή"
        Me.LayoutControlItem111.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem111.TextSize = New System.Drawing.Size(201, 19)
        '
        'Lcost2
        '
        Me.Lcost2.Control = Me.txtDisc3
        Me.Lcost2.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.Lcost2.CustomizationFormText = "Έκπτωση"
        Me.Lcost2.HighlightFocusedItem = DevExpress.Utils.DefaultBoolean.[True]
        Me.Lcost2.Location = New System.Drawing.Point(307, 100)
        Me.Lcost2.Name = "Lcost2"
        Me.Lcost2.Size = New System.Drawing.Size(298, 50)
        Me.Lcost2.Text = "Έκπτωση"
        Me.Lcost2.TextLocation = DevExpress.Utils.Locations.Top
        Me.Lcost2.TextSize = New System.Drawing.Size(201, 19)
        '
        'LayoutControlItem112
        '
        Me.LayoutControlItem112.Control = Me.txtDiscount3
        Me.LayoutControlItem112.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem112.CustomizationFormText = "Ποσό Έκπτωσης"
        Me.LayoutControlItem112.HighlightFocusedItem = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlItem112.Location = New System.Drawing.Point(605, 100)
        Me.LayoutControlItem112.Name = "LayoutControlItem112"
        Me.LayoutControlItem112.Size = New System.Drawing.Size(329, 50)
        Me.LayoutControlItem112.Text = "Ποσό Έκπτωσης"
        Me.LayoutControlItem112.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem112.TextSize = New System.Drawing.Size(201, 19)
        '
        'LayoutControlItem113
        '
        Me.LayoutControlItem113.Control = Me.txtFinalPrice3
        Me.LayoutControlItem113.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem113.CustomizationFormText = "Τελική Τιμή(ΦΠΑ)"
        Me.LayoutControlItem113.HighlightFocusedItem = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlItem113.Location = New System.Drawing.Point(934, 100)
        Me.LayoutControlItem113.Name = "LayoutControlItem113"
        Me.LayoutControlItem113.Size = New System.Drawing.Size(351, 50)
        Me.LayoutControlItem113.Text = "Τελική Τιμή(ΦΠΑ)"
        Me.LayoutControlItem113.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem113.TextSize = New System.Drawing.Size(201, 19)
        '
        'LayoutControlItem63
        '
        Me.LayoutControlItem63.Control = Me.cboVALUELISTITEM3
        Me.LayoutControlItem63.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem63.CustomizationFormText = "Κωδικός Πόρτας"
        Me.LayoutControlItem63.Location = New System.Drawing.Point(247, 50)
        Me.LayoutControlItem63.Name = "LayoutControlItem63"
        Me.LayoutControlItem63.Size = New System.Drawing.Size(423, 50)
        Me.LayoutControlItem63.Text = "Κωδικός Πόρτας"
        Me.LayoutControlItem63.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem63.TextSize = New System.Drawing.Size(201, 19)
        '
        'LayoutControlItem21
        '
        Me.LayoutControlItem21.Control = Me.txtKnobs3
        Me.LayoutControlItem21.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem21.CustomizationFormText = "Πόμολα"
        Me.LayoutControlItem21.Location = New System.Drawing.Point(670, 50)
        Me.LayoutControlItem21.Name = "LayoutControlItem21"
        Me.LayoutControlItem21.Size = New System.Drawing.Size(615, 50)
        Me.LayoutControlItem21.Text = "Πόμολα"
        Me.LayoutControlItem21.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem21.TextSize = New System.Drawing.Size(201, 19)
        '
        'LayoutControlGroup6
        '
        Me.LayoutControlGroup6.CustomizationFormText = "Πόρτα 4"
        Me.LayoutControlGroup6.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem60, Me.LayoutControlItem50, Me.LayoutControlItem6, Me.LayoutControlItem27, Me.LayoutControlItem114, Me.Lcost4, Me.LayoutControlItem115, Me.LayoutControlItem116, Me.LayoutControlItem64, Me.LayoutControlItem67})
        Me.LayoutControlGroup6.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup6.Name = "LayoutControlGroup6"
        Me.LayoutControlGroup6.Size = New System.Drawing.Size(1285, 150)
        Me.LayoutControlGroup6.Text = "Πόρτα 4"
        '
        'LayoutControlItem60
        '
        Me.LayoutControlItem60.Control = Me.cboType4
        Me.LayoutControlItem60.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem60.CustomizationFormText = "Τύπος Πόρτας"
        Me.LayoutControlItem60.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem60.Name = "LayoutControlItem60"
        Me.LayoutControlItem60.Size = New System.Drawing.Size(247, 50)
        Me.LayoutControlItem60.Text = "Τύπος Πόρτας"
        Me.LayoutControlItem60.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem60.TextSize = New System.Drawing.Size(201, 19)
        '
        'LayoutControlItem50
        '
        Me.LayoutControlItem50.Control = Me.cboKasa4
        Me.LayoutControlItem50.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem50.CustomizationFormText = "Πάχος Κάσας"
        Me.LayoutControlItem50.Location = New System.Drawing.Point(247, 0)
        Me.LayoutControlItem50.Name = "LayoutControlItem50"
        Me.LayoutControlItem50.Size = New System.Drawing.Size(423, 50)
        Me.LayoutControlItem50.Text = "Πάχος Κάσας"
        Me.LayoutControlItem50.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem50.TextSize = New System.Drawing.Size(201, 19)
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.cboFora4
        Me.LayoutControlItem6.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem6.CustomizationFormText = "Φορά"
        Me.LayoutControlItem6.Location = New System.Drawing.Point(0, 50)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(247, 50)
        Me.LayoutControlItem6.Text = "Φορά"
        Me.LayoutControlItem6.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(201, 19)
        '
        'LayoutControlItem27
        '
        Me.LayoutControlItem27.Control = Me.txtDimension4
        Me.LayoutControlItem27.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem27.CustomizationFormText = "Διάσταση"
        Me.LayoutControlItem27.Location = New System.Drawing.Point(670, 0)
        Me.LayoutControlItem27.Name = "LayoutControlItem27"
        Me.LayoutControlItem27.Size = New System.Drawing.Size(615, 50)
        Me.LayoutControlItem27.Text = "Διάσταση"
        Me.LayoutControlItem27.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem27.TextSize = New System.Drawing.Size(201, 19)
        '
        'LayoutControlItem114
        '
        Me.LayoutControlItem114.Control = Me.txtInitialPrice4
        Me.LayoutControlItem114.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem114.CustomizationFormText = "Αρχική Τιμή"
        Me.LayoutControlItem114.HighlightFocusedItem = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlItem114.Location = New System.Drawing.Point(0, 100)
        Me.LayoutControlItem114.Name = "LayoutControlItem114"
        Me.LayoutControlItem114.Size = New System.Drawing.Size(307, 50)
        Me.LayoutControlItem114.Text = "Αρχική Τιμή"
        Me.LayoutControlItem114.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem114.TextSize = New System.Drawing.Size(201, 19)
        '
        'Lcost4
        '
        Me.Lcost4.Control = Me.txtDisc4
        Me.Lcost4.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.Lcost4.CustomizationFormText = "Έκπτωση"
        Me.Lcost4.HighlightFocusedItem = DevExpress.Utils.DefaultBoolean.[True]
        Me.Lcost4.Location = New System.Drawing.Point(307, 100)
        Me.Lcost4.Name = "Lcost4"
        Me.Lcost4.Size = New System.Drawing.Size(298, 50)
        Me.Lcost4.Text = "Έκπτωση"
        Me.Lcost4.TextLocation = DevExpress.Utils.Locations.Top
        Me.Lcost4.TextSize = New System.Drawing.Size(201, 19)
        '
        'LayoutControlItem115
        '
        Me.LayoutControlItem115.Control = Me.txtDiscount4
        Me.LayoutControlItem115.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem115.CustomizationFormText = "Ποσό Έκπτωσης"
        Me.LayoutControlItem115.HighlightFocusedItem = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlItem115.Location = New System.Drawing.Point(605, 100)
        Me.LayoutControlItem115.Name = "LayoutControlItem115"
        Me.LayoutControlItem115.Size = New System.Drawing.Size(329, 50)
        Me.LayoutControlItem115.Text = "Ποσό Έκπτωσης"
        Me.LayoutControlItem115.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem115.TextSize = New System.Drawing.Size(201, 19)
        '
        'LayoutControlItem116
        '
        Me.LayoutControlItem116.Control = Me.txtFinalPrice4
        Me.LayoutControlItem116.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem116.CustomizationFormText = "Τελική Τιμή(ΦΠΑ)"
        Me.LayoutControlItem116.HighlightFocusedItem = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlItem116.Location = New System.Drawing.Point(934, 100)
        Me.LayoutControlItem116.Name = "LayoutControlItem116"
        Me.LayoutControlItem116.Size = New System.Drawing.Size(351, 50)
        Me.LayoutControlItem116.Text = "Τελική Τιμή(ΦΠΑ)"
        Me.LayoutControlItem116.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem116.TextSize = New System.Drawing.Size(201, 19)
        '
        'LayoutControlItem64
        '
        Me.LayoutControlItem64.Control = Me.cboVALUELISTITEM4
        Me.LayoutControlItem64.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem64.CustomizationFormText = "Κωδικός Πόρτας"
        Me.LayoutControlItem64.Location = New System.Drawing.Point(247, 50)
        Me.LayoutControlItem64.Name = "LayoutControlItem64"
        Me.LayoutControlItem64.Size = New System.Drawing.Size(423, 50)
        Me.LayoutControlItem64.Text = "Κωδικός Πόρτας"
        Me.LayoutControlItem64.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem64.TextSize = New System.Drawing.Size(201, 19)
        '
        'LayoutControlItem67
        '
        Me.LayoutControlItem67.Control = Me.txtKnobs4
        Me.LayoutControlItem67.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem67.CustomizationFormText = "Πόμολα"
        Me.LayoutControlItem67.Location = New System.Drawing.Point(670, 50)
        Me.LayoutControlItem67.Name = "LayoutControlItem67"
        Me.LayoutControlItem67.Size = New System.Drawing.Size(615, 50)
        Me.LayoutControlItem67.Text = "Πόμολα"
        Me.LayoutControlItem67.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem67.TextSize = New System.Drawing.Size(201, 19)
        '
        'LayoutControlGroup7
        '
        Me.LayoutControlGroup7.CustomizationFormText = "Πόρτα 5"
        Me.LayoutControlGroup7.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem61, Me.LayoutControlItem51, Me.LayoutControlItem10, Me.LayoutControlItem29, Me.LayoutControlItem117, Me.Lcost5, Me.LayoutControlItem118, Me.LayoutControlItem119, Me.LayoutControlItem65, Me.LayoutControlItem68})
        Me.LayoutControlGroup7.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup7.Name = "LayoutControlGroup7"
        Me.LayoutControlGroup7.Size = New System.Drawing.Size(1285, 150)
        Me.LayoutControlGroup7.Text = "Πόρτα 5"
        '
        'LayoutControlItem61
        '
        Me.LayoutControlItem61.Control = Me.cboType5
        Me.LayoutControlItem61.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem61.CustomizationFormText = "Τύπος Πόρτας"
        Me.LayoutControlItem61.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem61.Name = "LayoutControlItem61"
        Me.LayoutControlItem61.Size = New System.Drawing.Size(247, 50)
        Me.LayoutControlItem61.Text = "Τύπος Πόρτας"
        Me.LayoutControlItem61.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem61.TextSize = New System.Drawing.Size(201, 19)
        '
        'LayoutControlItem51
        '
        Me.LayoutControlItem51.Control = Me.cboKasa5
        Me.LayoutControlItem51.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem51.CustomizationFormText = "Πάχος Κάσας"
        Me.LayoutControlItem51.Location = New System.Drawing.Point(247, 0)
        Me.LayoutControlItem51.Name = "LayoutControlItem51"
        Me.LayoutControlItem51.Size = New System.Drawing.Size(423, 50)
        Me.LayoutControlItem51.Text = "Πάχος Κάσας"
        Me.LayoutControlItem51.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem51.TextSize = New System.Drawing.Size(201, 19)
        '
        'LayoutControlItem10
        '
        Me.LayoutControlItem10.Control = Me.cboFora5
        Me.LayoutControlItem10.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem10.CustomizationFormText = "Φορά"
        Me.LayoutControlItem10.Location = New System.Drawing.Point(0, 50)
        Me.LayoutControlItem10.Name = "LayoutControlItem10"
        Me.LayoutControlItem10.Size = New System.Drawing.Size(247, 50)
        Me.LayoutControlItem10.Text = "Φορά"
        Me.LayoutControlItem10.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem10.TextSize = New System.Drawing.Size(201, 19)
        '
        'LayoutControlItem29
        '
        Me.LayoutControlItem29.Control = Me.txtDimension5
        Me.LayoutControlItem29.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem29.CustomizationFormText = "Διάσταση"
        Me.LayoutControlItem29.Location = New System.Drawing.Point(670, 0)
        Me.LayoutControlItem29.Name = "LayoutControlItem29"
        Me.LayoutControlItem29.Size = New System.Drawing.Size(615, 50)
        Me.LayoutControlItem29.Text = "Διάσταση"
        Me.LayoutControlItem29.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem29.TextSize = New System.Drawing.Size(201, 19)
        '
        'LayoutControlItem117
        '
        Me.LayoutControlItem117.Control = Me.txtInitialPrice5
        Me.LayoutControlItem117.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem117.CustomizationFormText = "Αρχική Τιμή"
        Me.LayoutControlItem117.HighlightFocusedItem = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlItem117.Location = New System.Drawing.Point(0, 100)
        Me.LayoutControlItem117.Name = "LayoutControlItem117"
        Me.LayoutControlItem117.Size = New System.Drawing.Size(307, 50)
        Me.LayoutControlItem117.Text = "Αρχική Τιμή"
        Me.LayoutControlItem117.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem117.TextSize = New System.Drawing.Size(201, 19)
        '
        'Lcost5
        '
        Me.Lcost5.Control = Me.txtDisc5
        Me.Lcost5.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.Lcost5.CustomizationFormText = "Έκπτωση"
        Me.Lcost5.HighlightFocusedItem = DevExpress.Utils.DefaultBoolean.[True]
        Me.Lcost5.Location = New System.Drawing.Point(307, 100)
        Me.Lcost5.Name = "Lcost5"
        Me.Lcost5.Size = New System.Drawing.Size(298, 50)
        Me.Lcost5.Text = "Έκπτωση"
        Me.Lcost5.TextLocation = DevExpress.Utils.Locations.Top
        Me.Lcost5.TextSize = New System.Drawing.Size(201, 19)
        '
        'LayoutControlItem118
        '
        Me.LayoutControlItem118.Control = Me.txtDiscount5
        Me.LayoutControlItem118.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem118.CustomizationFormText = "Ποσό Έκπτωσης"
        Me.LayoutControlItem118.HighlightFocusedItem = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlItem118.Location = New System.Drawing.Point(605, 100)
        Me.LayoutControlItem118.Name = "LayoutControlItem118"
        Me.LayoutControlItem118.Size = New System.Drawing.Size(329, 50)
        Me.LayoutControlItem118.Text = "Ποσό Έκπτωσης"
        Me.LayoutControlItem118.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem118.TextSize = New System.Drawing.Size(201, 19)
        '
        'LayoutControlItem119
        '
        Me.LayoutControlItem119.Control = Me.txtFinalPrice5
        Me.LayoutControlItem119.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem119.CustomizationFormText = "Τελική Τιμή(ΦΠΑ)"
        Me.LayoutControlItem119.HighlightFocusedItem = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlItem119.Location = New System.Drawing.Point(934, 100)
        Me.LayoutControlItem119.Name = "LayoutControlItem119"
        Me.LayoutControlItem119.Size = New System.Drawing.Size(351, 50)
        Me.LayoutControlItem119.Text = "Τελική Τιμή(ΦΠΑ)"
        Me.LayoutControlItem119.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem119.TextSize = New System.Drawing.Size(201, 19)
        '
        'LayoutControlItem65
        '
        Me.LayoutControlItem65.Control = Me.cboVALUELISTITEM5
        Me.LayoutControlItem65.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem65.CustomizationFormText = "Κωδικός Πόρτας"
        Me.LayoutControlItem65.Location = New System.Drawing.Point(247, 50)
        Me.LayoutControlItem65.Name = "LayoutControlItem65"
        Me.LayoutControlItem65.Size = New System.Drawing.Size(423, 50)
        Me.LayoutControlItem65.Text = "Κωδικός Πόρτας"
        Me.LayoutControlItem65.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem65.TextSize = New System.Drawing.Size(201, 19)
        '
        'LayoutControlItem68
        '
        Me.LayoutControlItem68.Control = Me.txtKnobs5
        Me.LayoutControlItem68.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem68.CustomizationFormText = "Πόμολα"
        Me.LayoutControlItem68.Location = New System.Drawing.Point(670, 50)
        Me.LayoutControlItem68.Name = "LayoutControlItem68"
        Me.LayoutControlItem68.Size = New System.Drawing.Size(615, 50)
        Me.LayoutControlItem68.Text = "Πόμολα"
        Me.LayoutControlItem68.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem68.TextSize = New System.Drawing.Size(201, 19)
        '
        'LayoutControlGroup8
        '
        Me.LayoutControlGroup8.CustomizationFormText = "Πόρτα 6"
        Me.LayoutControlGroup8.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem62, Me.LayoutControlItem11, Me.LayoutControlItem28, Me.LayoutControlItem120, Me.Lcost6, Me.LayoutControlItem121, Me.LayoutControlItem122, Me.LayoutControlItem66, Me.LayoutControlItem71, Me.LayoutControlItem52})
        Me.LayoutControlGroup8.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup8.Name = "LayoutControlGroup8"
        Me.LayoutControlGroup8.Size = New System.Drawing.Size(1285, 150)
        Me.LayoutControlGroup8.Text = "Πόρτα 6"
        '
        'LayoutControlItem62
        '
        Me.LayoutControlItem62.Control = Me.cboType6
        Me.LayoutControlItem62.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem62.CustomizationFormText = "Τύπος Πόρτας"
        Me.LayoutControlItem62.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem62.Name = "LayoutControlItem62"
        Me.LayoutControlItem62.Size = New System.Drawing.Size(247, 50)
        Me.LayoutControlItem62.Text = "Τύπος Πόρτας"
        Me.LayoutControlItem62.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem62.TextSize = New System.Drawing.Size(201, 19)
        '
        'LayoutControlItem11
        '
        Me.LayoutControlItem11.Control = Me.cboFora6
        Me.LayoutControlItem11.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem11.CustomizationFormText = "Φορά"
        Me.LayoutControlItem11.Location = New System.Drawing.Point(0, 50)
        Me.LayoutControlItem11.Name = "LayoutControlItem11"
        Me.LayoutControlItem11.Size = New System.Drawing.Size(247, 50)
        Me.LayoutControlItem11.Text = "Φορά"
        Me.LayoutControlItem11.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem11.TextSize = New System.Drawing.Size(201, 19)
        '
        'LayoutControlItem28
        '
        Me.LayoutControlItem28.Control = Me.txtDimension8
        Me.LayoutControlItem28.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem28.CustomizationFormText = "Διάσταση"
        Me.LayoutControlItem28.Location = New System.Drawing.Point(670, 0)
        Me.LayoutControlItem28.Name = "LayoutControlItem28"
        Me.LayoutControlItem28.Size = New System.Drawing.Size(615, 50)
        Me.LayoutControlItem28.Text = "Διάσταση"
        Me.LayoutControlItem28.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem28.TextSize = New System.Drawing.Size(201, 19)
        '
        'LayoutControlItem120
        '
        Me.LayoutControlItem120.Control = Me.txtInitialPrice6
        Me.LayoutControlItem120.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem120.CustomizationFormText = "Αρχική Τιμή"
        Me.LayoutControlItem120.HighlightFocusedItem = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlItem120.Location = New System.Drawing.Point(0, 100)
        Me.LayoutControlItem120.Name = "LayoutControlItem120"
        Me.LayoutControlItem120.Size = New System.Drawing.Size(307, 50)
        Me.LayoutControlItem120.Text = "Αρχική Τιμή"
        Me.LayoutControlItem120.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem120.TextSize = New System.Drawing.Size(201, 19)
        '
        'Lcost6
        '
        Me.Lcost6.Control = Me.txtDisc6
        Me.Lcost6.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.Lcost6.CustomizationFormText = "Έκπτωση"
        Me.Lcost6.HighlightFocusedItem = DevExpress.Utils.DefaultBoolean.[True]
        Me.Lcost6.Location = New System.Drawing.Point(307, 100)
        Me.Lcost6.Name = "Lcost6"
        Me.Lcost6.Size = New System.Drawing.Size(298, 50)
        Me.Lcost6.Text = "Έκπτωση"
        Me.Lcost6.TextLocation = DevExpress.Utils.Locations.Top
        Me.Lcost6.TextSize = New System.Drawing.Size(201, 19)
        '
        'LayoutControlItem121
        '
        Me.LayoutControlItem121.Control = Me.txtDiscount6
        Me.LayoutControlItem121.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem121.CustomizationFormText = "Ποσό Έκπτωσης"
        Me.LayoutControlItem121.HighlightFocusedItem = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlItem121.Location = New System.Drawing.Point(605, 100)
        Me.LayoutControlItem121.Name = "LayoutControlItem121"
        Me.LayoutControlItem121.Size = New System.Drawing.Size(329, 50)
        Me.LayoutControlItem121.Text = "Ποσό Έκπτωσης"
        Me.LayoutControlItem121.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem121.TextSize = New System.Drawing.Size(201, 19)
        '
        'LayoutControlItem122
        '
        Me.LayoutControlItem122.Control = Me.txtFinalPrice6
        Me.LayoutControlItem122.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem122.CustomizationFormText = "Τελική Τιμή"
        Me.LayoutControlItem122.HighlightFocusedItem = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlItem122.Location = New System.Drawing.Point(934, 100)
        Me.LayoutControlItem122.Name = "LayoutControlItem122"
        Me.LayoutControlItem122.Size = New System.Drawing.Size(351, 50)
        Me.LayoutControlItem122.Text = "Τελική Τιμή"
        Me.LayoutControlItem122.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem122.TextSize = New System.Drawing.Size(201, 19)
        '
        'LayoutControlItem66
        '
        Me.LayoutControlItem66.Control = Me.cboVALUELISTITEM6
        Me.LayoutControlItem66.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem66.CustomizationFormText = "Κωδικός Πόρτας"
        Me.LayoutControlItem66.Location = New System.Drawing.Point(247, 50)
        Me.LayoutControlItem66.Name = "LayoutControlItem66"
        Me.LayoutControlItem66.Size = New System.Drawing.Size(423, 50)
        Me.LayoutControlItem66.Text = "Κωδικός Πόρτας"
        Me.LayoutControlItem66.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem66.TextSize = New System.Drawing.Size(201, 19)
        '
        'LayoutControlItem71
        '
        Me.LayoutControlItem71.Control = Me.txtKnobs6
        Me.LayoutControlItem71.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem71.CustomizationFormText = "Πόμολα"
        Me.LayoutControlItem71.Location = New System.Drawing.Point(670, 50)
        Me.LayoutControlItem71.Name = "LayoutControlItem71"
        Me.LayoutControlItem71.Size = New System.Drawing.Size(615, 50)
        Me.LayoutControlItem71.Text = "Πόμολα"
        Me.LayoutControlItem71.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem71.TextSize = New System.Drawing.Size(201, 19)
        '
        'LayoutControlItem52
        '
        Me.LayoutControlItem52.Control = Me.cboKasa6
        Me.LayoutControlItem52.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem52.CustomizationFormText = "Πάχος Κάσας"
        Me.LayoutControlItem52.Location = New System.Drawing.Point(247, 0)
        Me.LayoutControlItem52.Name = "LayoutControlItem52"
        Me.LayoutControlItem52.Size = New System.Drawing.Size(423, 50)
        Me.LayoutControlItem52.Text = "Πάχος Κάσας"
        Me.LayoutControlItem52.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem52.TextSize = New System.Drawing.Size(201, 19)
        '
        'LayoutRootGroupForRestore
        '
        Me.LayoutRootGroupForRestore.GroupBordersVisible = False
        Me.LayoutRootGroupForRestore.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem81, Me.LayoutControlItem82, Me.LayoutControlItem83, Me.LayoutControlItem87, Me.LayoutControlItem123, Me.Lcost7, Me.LayoutControlItem124, Me.LayoutControlItem125, Me.LayoutControlItem84, Me.LayoutControlItem88})
        Me.LayoutRootGroupForRestore.Location = New System.Drawing.Point(0, 0)
        Me.LayoutRootGroupForRestore.Name = "LayoutRootGroupForRestore"
        Me.LayoutRootGroupForRestore.Size = New System.Drawing.Size(1285, 150)
        Me.LayoutRootGroupForRestore.Tag = "LayoutRootGroupForRestore"
        Me.LayoutRootGroupForRestore.Text = "Πόρτα 7"
        '
        'LayoutControlItem81
        '
        Me.LayoutControlItem81.Control = Me.cboType7
        Me.LayoutControlItem81.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem81.CustomizationFormText = "Τύπος Πόρτας"
        Me.LayoutControlItem81.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem81.Name = "LayoutControlItem81"
        Me.LayoutControlItem81.Size = New System.Drawing.Size(247, 50)
        Me.LayoutControlItem81.Text = "Τύπος Πόρτας"
        Me.LayoutControlItem81.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem81.TextSize = New System.Drawing.Size(201, 19)
        '
        'LayoutControlItem82
        '
        Me.LayoutControlItem82.Control = Me.cboKasa7
        Me.LayoutControlItem82.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem82.CustomizationFormText = "Πάχος Κάσας"
        Me.LayoutControlItem82.Location = New System.Drawing.Point(247, 0)
        Me.LayoutControlItem82.Name = "LayoutControlItem82"
        Me.LayoutControlItem82.Size = New System.Drawing.Size(423, 50)
        Me.LayoutControlItem82.Text = "Πάχος Κάσας"
        Me.LayoutControlItem82.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem82.TextSize = New System.Drawing.Size(201, 19)
        '
        'LayoutControlItem83
        '
        Me.LayoutControlItem83.Control = Me.cboFora7
        Me.LayoutControlItem83.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem83.CustomizationFormText = "Φορά"
        Me.LayoutControlItem83.Location = New System.Drawing.Point(0, 50)
        Me.LayoutControlItem83.Name = "LayoutControlItem83"
        Me.LayoutControlItem83.Size = New System.Drawing.Size(247, 50)
        Me.LayoutControlItem83.Text = "Φορά"
        Me.LayoutControlItem83.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem83.TextSize = New System.Drawing.Size(201, 19)
        '
        'LayoutControlItem87
        '
        Me.LayoutControlItem87.Control = Me.txtDimension142
        Me.LayoutControlItem87.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem87.CustomizationFormText = "Διάσταση"
        Me.LayoutControlItem87.Location = New System.Drawing.Point(670, 0)
        Me.LayoutControlItem87.Name = "LayoutControlItem87"
        Me.LayoutControlItem87.Size = New System.Drawing.Size(615, 50)
        Me.LayoutControlItem87.Text = "Διάσταση"
        Me.LayoutControlItem87.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem87.TextSize = New System.Drawing.Size(201, 19)
        '
        'LayoutControlItem123
        '
        Me.LayoutControlItem123.Control = Me.txtInitialPrice7
        Me.LayoutControlItem123.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem123.CustomizationFormText = "Αρχική Τιμή"
        Me.LayoutControlItem123.HighlightFocusedItem = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlItem123.Location = New System.Drawing.Point(0, 100)
        Me.LayoutControlItem123.Name = "LayoutControlItem123"
        Me.LayoutControlItem123.Size = New System.Drawing.Size(307, 50)
        Me.LayoutControlItem123.Text = "Αρχική Τιμή"
        Me.LayoutControlItem123.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem123.TextSize = New System.Drawing.Size(201, 19)
        '
        'Lcost7
        '
        Me.Lcost7.Control = Me.txtDisc7
        Me.Lcost7.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.Lcost7.CustomizationFormText = "Έκπτωση"
        Me.Lcost7.HighlightFocusedItem = DevExpress.Utils.DefaultBoolean.[True]
        Me.Lcost7.Location = New System.Drawing.Point(307, 100)
        Me.Lcost7.Name = "Lcost7"
        Me.Lcost7.Size = New System.Drawing.Size(298, 50)
        Me.Lcost7.Text = "Έκπτωση"
        Me.Lcost7.TextLocation = DevExpress.Utils.Locations.Top
        Me.Lcost7.TextSize = New System.Drawing.Size(201, 19)
        '
        'LayoutControlItem124
        '
        Me.LayoutControlItem124.Control = Me.txtDiscount7
        Me.LayoutControlItem124.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem124.CustomizationFormText = "Ποσό Έκπτωσης"
        Me.LayoutControlItem124.HighlightFocusedItem = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlItem124.Location = New System.Drawing.Point(605, 100)
        Me.LayoutControlItem124.Name = "LayoutControlItem124"
        Me.LayoutControlItem124.Size = New System.Drawing.Size(329, 50)
        Me.LayoutControlItem124.Text = "Ποσό Έκπτωσης"
        Me.LayoutControlItem124.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem124.TextSize = New System.Drawing.Size(201, 19)
        '
        'LayoutControlItem125
        '
        Me.LayoutControlItem125.Control = Me.txtFinalPrice7
        Me.LayoutControlItem125.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem125.CustomizationFormText = "Τελική Τιμή(ΦΠΑ)"
        Me.LayoutControlItem125.HighlightFocusedItem = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlItem125.Location = New System.Drawing.Point(934, 100)
        Me.LayoutControlItem125.Name = "LayoutControlItem125"
        Me.LayoutControlItem125.Size = New System.Drawing.Size(351, 50)
        Me.LayoutControlItem125.Text = "Τελική Τιμή(ΦΠΑ)"
        Me.LayoutControlItem125.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem125.TextSize = New System.Drawing.Size(201, 19)
        '
        'LayoutControlItem84
        '
        Me.LayoutControlItem84.Control = Me.cboVALUELISTITEM7
        Me.LayoutControlItem84.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem84.CustomizationFormText = "Κωδικός Πόρτας"
        Me.LayoutControlItem84.Location = New System.Drawing.Point(247, 50)
        Me.LayoutControlItem84.Name = "LayoutControlItem84"
        Me.LayoutControlItem84.Size = New System.Drawing.Size(423, 50)
        Me.LayoutControlItem84.Text = "Κωδικός Πόρτας"
        Me.LayoutControlItem84.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem84.TextSize = New System.Drawing.Size(201, 19)
        '
        'LayoutControlItem88
        '
        Me.LayoutControlItem88.Control = Me.txtKnobs7
        Me.LayoutControlItem88.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem88.CustomizationFormText = "Πόμολα"
        Me.LayoutControlItem88.Location = New System.Drawing.Point(670, 50)
        Me.LayoutControlItem88.Name = "LayoutControlItem88"
        Me.LayoutControlItem88.Size = New System.Drawing.Size(615, 50)
        Me.LayoutControlItem88.Text = "Πόμολα"
        Me.LayoutControlItem88.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem88.TextSize = New System.Drawing.Size(201, 19)
        '
        'LayoutControlGroup13
        '
        Me.LayoutControlGroup13.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem73, Me.LayoutControlItem74, Me.LayoutControlItem75, Me.LayoutControlItem79, Me.LayoutControlItem126, Me.Lcost8, Me.LayoutControlItem127, Me.LayoutControlItem128, Me.LayoutControlItem76, Me.LayoutControlItem80})
        Me.LayoutControlGroup13.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup13.Name = "LayoutControlGroup13"
        Me.LayoutControlGroup13.Size = New System.Drawing.Size(1285, 150)
        Me.LayoutControlGroup13.Text = "Πόρτα 8"
        '
        'LayoutControlItem73
        '
        Me.LayoutControlItem73.Control = Me.cboType8
        Me.LayoutControlItem73.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem73.CustomizationFormText = "Τύπος Πόρτας"
        Me.LayoutControlItem73.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem73.Name = "LayoutControlItem73"
        Me.LayoutControlItem73.Size = New System.Drawing.Size(247, 50)
        Me.LayoutControlItem73.Text = "Τύπος Πόρτας"
        Me.LayoutControlItem73.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem73.TextSize = New System.Drawing.Size(201, 19)
        '
        'LayoutControlItem74
        '
        Me.LayoutControlItem74.Control = Me.cboKasa8
        Me.LayoutControlItem74.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem74.CustomizationFormText = "Πάχος Κάσας"
        Me.LayoutControlItem74.Location = New System.Drawing.Point(247, 0)
        Me.LayoutControlItem74.Name = "LayoutControlItem74"
        Me.LayoutControlItem74.Size = New System.Drawing.Size(423, 50)
        Me.LayoutControlItem74.Text = "Πάχος Κάσας"
        Me.LayoutControlItem74.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem74.TextSize = New System.Drawing.Size(201, 19)
        '
        'LayoutControlItem75
        '
        Me.LayoutControlItem75.Control = Me.cboFora8
        Me.LayoutControlItem75.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem75.CustomizationFormText = "Φορά"
        Me.LayoutControlItem75.Location = New System.Drawing.Point(0, 50)
        Me.LayoutControlItem75.Name = "LayoutControlItem75"
        Me.LayoutControlItem75.Size = New System.Drawing.Size(247, 50)
        Me.LayoutControlItem75.Text = "Φορά"
        Me.LayoutControlItem75.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem75.TextSize = New System.Drawing.Size(201, 19)
        '
        'LayoutControlItem79
        '
        Me.LayoutControlItem79.Control = Me.txtDimension141
        Me.LayoutControlItem79.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem79.CustomizationFormText = "Διάσταση"
        Me.LayoutControlItem79.Location = New System.Drawing.Point(670, 0)
        Me.LayoutControlItem79.Name = "LayoutControlItem79"
        Me.LayoutControlItem79.Size = New System.Drawing.Size(615, 50)
        Me.LayoutControlItem79.Text = "Διάσταση"
        Me.LayoutControlItem79.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem79.TextSize = New System.Drawing.Size(201, 19)
        '
        'LayoutControlItem126
        '
        Me.LayoutControlItem126.Control = Me.txtInitialPrice8
        Me.LayoutControlItem126.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem126.CustomizationFormText = "Αρχική Τιμή"
        Me.LayoutControlItem126.HighlightFocusedItem = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlItem126.Location = New System.Drawing.Point(0, 100)
        Me.LayoutControlItem126.Name = "LayoutControlItem126"
        Me.LayoutControlItem126.Size = New System.Drawing.Size(307, 50)
        Me.LayoutControlItem126.Text = "Αρχική Τιμή"
        Me.LayoutControlItem126.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem126.TextSize = New System.Drawing.Size(201, 19)
        '
        'Lcost8
        '
        Me.Lcost8.Control = Me.txtDisc8
        Me.Lcost8.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.Lcost8.CustomizationFormText = "Έκπτωση"
        Me.Lcost8.HighlightFocusedItem = DevExpress.Utils.DefaultBoolean.[True]
        Me.Lcost8.Location = New System.Drawing.Point(307, 100)
        Me.Lcost8.Name = "Lcost8"
        Me.Lcost8.Size = New System.Drawing.Size(298, 50)
        Me.Lcost8.Text = "Έκπτωση"
        Me.Lcost8.TextLocation = DevExpress.Utils.Locations.Top
        Me.Lcost8.TextSize = New System.Drawing.Size(201, 19)
        '
        'LayoutControlItem127
        '
        Me.LayoutControlItem127.Control = Me.txtDiscount8
        Me.LayoutControlItem127.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem127.CustomizationFormText = "Ποσό Έκπτωσης"
        Me.LayoutControlItem127.HighlightFocusedItem = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlItem127.Location = New System.Drawing.Point(605, 100)
        Me.LayoutControlItem127.Name = "LayoutControlItem127"
        Me.LayoutControlItem127.Size = New System.Drawing.Size(329, 50)
        Me.LayoutControlItem127.Text = "Ποσό Έκπτωσης"
        Me.LayoutControlItem127.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem127.TextSize = New System.Drawing.Size(201, 19)
        '
        'LayoutControlItem128
        '
        Me.LayoutControlItem128.Control = Me.txtFinalPrice8
        Me.LayoutControlItem128.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem128.CustomizationFormText = "Τελική Τιμή(ΦΠΑ)"
        Me.LayoutControlItem128.HighlightFocusedItem = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlItem128.Location = New System.Drawing.Point(934, 100)
        Me.LayoutControlItem128.Name = "LayoutControlItem128"
        Me.LayoutControlItem128.Size = New System.Drawing.Size(351, 50)
        Me.LayoutControlItem128.Text = "Τελική Τιμή(ΦΠΑ)"
        Me.LayoutControlItem128.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem128.TextSize = New System.Drawing.Size(201, 19)
        '
        'LayoutControlItem76
        '
        Me.LayoutControlItem76.Control = Me.cboVALUELISTITEM8
        Me.LayoutControlItem76.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem76.CustomizationFormText = "Κωδικός Πόρτας"
        Me.LayoutControlItem76.Location = New System.Drawing.Point(247, 50)
        Me.LayoutControlItem76.Name = "LayoutControlItem76"
        Me.LayoutControlItem76.Size = New System.Drawing.Size(423, 50)
        Me.LayoutControlItem76.Text = "Κωδικός Πόρτας"
        Me.LayoutControlItem76.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem76.TextSize = New System.Drawing.Size(201, 19)
        '
        'LayoutControlItem80
        '
        Me.LayoutControlItem80.Control = Me.txtKnobs8
        Me.LayoutControlItem80.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem80.CustomizationFormText = "Πόμολα"
        Me.LayoutControlItem80.Location = New System.Drawing.Point(670, 50)
        Me.LayoutControlItem80.Name = "LayoutControlItem80"
        Me.LayoutControlItem80.Size = New System.Drawing.Size(615, 50)
        Me.LayoutControlItem80.Text = "Πόμολα"
        Me.LayoutControlItem80.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem80.TextSize = New System.Drawing.Size(201, 19)
        '
        'LayoutControlGroup15
        '
        Me.LayoutControlGroup15.CustomizationFormText = "Πόρτα 9"
        Me.LayoutControlGroup15.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem89, Me.LayoutControlItem90, Me.LayoutControlItem91, Me.LayoutControlItem95, Me.LayoutControlItem129, Me.Lcost9, Me.LayoutControlItem130, Me.LayoutControlItem131, Me.LayoutControlItem92, Me.LayoutControlItem96})
        Me.LayoutControlGroup15.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup15.Name = "LayoutControlGroup15"
        Me.LayoutControlGroup15.Size = New System.Drawing.Size(1285, 150)
        Me.LayoutControlGroup15.Text = "Πόρτα 9"
        '
        'LayoutControlItem89
        '
        Me.LayoutControlItem89.Control = Me.cboType9
        Me.LayoutControlItem89.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem89.CustomizationFormText = "Τύπος Πόρτας"
        Me.LayoutControlItem89.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem89.Name = "LayoutControlItem89"
        Me.LayoutControlItem89.Size = New System.Drawing.Size(247, 50)
        Me.LayoutControlItem89.Text = "Τύπος Πόρτας"
        Me.LayoutControlItem89.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem89.TextSize = New System.Drawing.Size(201, 19)
        '
        'LayoutControlItem90
        '
        Me.LayoutControlItem90.Control = Me.cboKasa9
        Me.LayoutControlItem90.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem90.CustomizationFormText = "Πάχος Κάσας"
        Me.LayoutControlItem90.Location = New System.Drawing.Point(247, 0)
        Me.LayoutControlItem90.Name = "LayoutControlItem90"
        Me.LayoutControlItem90.Size = New System.Drawing.Size(423, 50)
        Me.LayoutControlItem90.Text = "Πάχος Κάσας"
        Me.LayoutControlItem90.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem90.TextSize = New System.Drawing.Size(201, 19)
        '
        'LayoutControlItem91
        '
        Me.LayoutControlItem91.Control = Me.cboFora9
        Me.LayoutControlItem91.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem91.CustomizationFormText = "Φορά"
        Me.LayoutControlItem91.Location = New System.Drawing.Point(0, 50)
        Me.LayoutControlItem91.Name = "LayoutControlItem91"
        Me.LayoutControlItem91.Size = New System.Drawing.Size(247, 50)
        Me.LayoutControlItem91.Text = "Φορά"
        Me.LayoutControlItem91.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem91.TextSize = New System.Drawing.Size(201, 19)
        '
        'LayoutControlItem95
        '
        Me.LayoutControlItem95.Control = Me.txtDimension9
        Me.LayoutControlItem95.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem95.CustomizationFormText = "Διάσταση"
        Me.LayoutControlItem95.Location = New System.Drawing.Point(670, 0)
        Me.LayoutControlItem95.Name = "LayoutControlItem95"
        Me.LayoutControlItem95.Size = New System.Drawing.Size(615, 50)
        Me.LayoutControlItem95.Text = "Διάσταση"
        Me.LayoutControlItem95.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem95.TextSize = New System.Drawing.Size(201, 19)
        '
        'LayoutControlItem129
        '
        Me.LayoutControlItem129.Control = Me.txtInitialPrice9
        Me.LayoutControlItem129.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem129.CustomizationFormText = "Αρχική Τιμή"
        Me.LayoutControlItem129.HighlightFocusedItem = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlItem129.Location = New System.Drawing.Point(0, 100)
        Me.LayoutControlItem129.Name = "LayoutControlItem129"
        Me.LayoutControlItem129.Size = New System.Drawing.Size(307, 50)
        Me.LayoutControlItem129.Text = "Αρχική Τιμή"
        Me.LayoutControlItem129.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem129.TextSize = New System.Drawing.Size(201, 19)
        '
        'Lcost9
        '
        Me.Lcost9.Control = Me.txtDisc9
        Me.Lcost9.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.Lcost9.CustomizationFormText = "Έκπτωση"
        Me.Lcost9.HighlightFocusedItem = DevExpress.Utils.DefaultBoolean.[True]
        Me.Lcost9.Location = New System.Drawing.Point(307, 100)
        Me.Lcost9.Name = "Lcost9"
        Me.Lcost9.Size = New System.Drawing.Size(298, 50)
        Me.Lcost9.Text = "Έκπτωση"
        Me.Lcost9.TextLocation = DevExpress.Utils.Locations.Top
        Me.Lcost9.TextSize = New System.Drawing.Size(201, 19)
        '
        'LayoutControlItem130
        '
        Me.LayoutControlItem130.Control = Me.txtDiscount9
        Me.LayoutControlItem130.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem130.CustomizationFormText = "Ποσό Έκπτωσης"
        Me.LayoutControlItem130.HighlightFocusedItem = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlItem130.Location = New System.Drawing.Point(605, 100)
        Me.LayoutControlItem130.Name = "LayoutControlItem130"
        Me.LayoutControlItem130.Size = New System.Drawing.Size(329, 50)
        Me.LayoutControlItem130.Text = "Ποσό Έκπτωσης"
        Me.LayoutControlItem130.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem130.TextSize = New System.Drawing.Size(201, 19)
        '
        'LayoutControlItem131
        '
        Me.LayoutControlItem131.Control = Me.txtFinalPrice9
        Me.LayoutControlItem131.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem131.CustomizationFormText = "Τελική Τιμή(ΦΠΑ)"
        Me.LayoutControlItem131.HighlightFocusedItem = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlItem131.Location = New System.Drawing.Point(934, 100)
        Me.LayoutControlItem131.Name = "LayoutControlItem131"
        Me.LayoutControlItem131.Size = New System.Drawing.Size(351, 50)
        Me.LayoutControlItem131.Text = "Τελική Τιμή(ΦΠΑ)"
        Me.LayoutControlItem131.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem131.TextSize = New System.Drawing.Size(201, 19)
        '
        'LayoutControlItem92
        '
        Me.LayoutControlItem92.Control = Me.cboVALUELISTITEM9
        Me.LayoutControlItem92.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem92.CustomizationFormText = "Κωδικός Πόρτας"
        Me.LayoutControlItem92.Location = New System.Drawing.Point(247, 50)
        Me.LayoutControlItem92.Name = "LayoutControlItem92"
        Me.LayoutControlItem92.Size = New System.Drawing.Size(423, 50)
        Me.LayoutControlItem92.Text = "Κωδικός Πόρτας"
        Me.LayoutControlItem92.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem92.TextSize = New System.Drawing.Size(201, 19)
        '
        'LayoutControlItem96
        '
        Me.LayoutControlItem96.Control = Me.txtKnobs9
        Me.LayoutControlItem96.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem96.CustomizationFormText = "Πόμολα"
        Me.LayoutControlItem96.Location = New System.Drawing.Point(670, 50)
        Me.LayoutControlItem96.Name = "LayoutControlItem96"
        Me.LayoutControlItem96.Size = New System.Drawing.Size(615, 50)
        Me.LayoutControlItem96.Text = "Πόμολα"
        Me.LayoutControlItem96.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem96.TextSize = New System.Drawing.Size(201, 19)
        '
        'LayoutControlGroup17
        '
        Me.LayoutControlGroup17.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem97, Me.LayoutControlItem98, Me.LayoutControlItem99, Me.LayoutControlItem103, Me.LayoutControlItem132, Me.Lcost10, Me.LayoutControlItem133, Me.LayoutControlItem134, Me.LayoutControlItem100, Me.LayoutControlItem104})
        Me.LayoutControlGroup17.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup17.Name = "LayoutControlGroup17"
        Me.LayoutControlGroup17.Size = New System.Drawing.Size(1285, 150)
        Me.LayoutControlGroup17.Text = "Πόρτα 10"
        '
        'LayoutControlItem97
        '
        Me.LayoutControlItem97.Control = Me.cboType10
        Me.LayoutControlItem97.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem97.CustomizationFormText = "Τύπος Πόρτας"
        Me.LayoutControlItem97.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem97.Name = "LayoutControlItem97"
        Me.LayoutControlItem97.Size = New System.Drawing.Size(247, 50)
        Me.LayoutControlItem97.Text = "Τύπος Πόρτας"
        Me.LayoutControlItem97.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem97.TextSize = New System.Drawing.Size(201, 19)
        '
        'LayoutControlItem98
        '
        Me.LayoutControlItem98.Control = Me.cboKasa10
        Me.LayoutControlItem98.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem98.CustomizationFormText = "Πάχος Κάσας"
        Me.LayoutControlItem98.Location = New System.Drawing.Point(247, 0)
        Me.LayoutControlItem98.Name = "LayoutControlItem98"
        Me.LayoutControlItem98.Size = New System.Drawing.Size(423, 50)
        Me.LayoutControlItem98.Text = "Πάχος Κάσας"
        Me.LayoutControlItem98.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem98.TextSize = New System.Drawing.Size(201, 19)
        '
        'LayoutControlItem99
        '
        Me.LayoutControlItem99.Control = Me.cboFora10
        Me.LayoutControlItem99.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem99.CustomizationFormText = "Φορά"
        Me.LayoutControlItem99.Location = New System.Drawing.Point(0, 50)
        Me.LayoutControlItem99.Name = "LayoutControlItem99"
        Me.LayoutControlItem99.Size = New System.Drawing.Size(247, 50)
        Me.LayoutControlItem99.Text = "Φορά"
        Me.LayoutControlItem99.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem99.TextSize = New System.Drawing.Size(201, 19)
        '
        'LayoutControlItem103
        '
        Me.LayoutControlItem103.Control = Me.txtDimension10
        Me.LayoutControlItem103.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem103.CustomizationFormText = "Διάσταση"
        Me.LayoutControlItem103.Location = New System.Drawing.Point(670, 0)
        Me.LayoutControlItem103.Name = "LayoutControlItem103"
        Me.LayoutControlItem103.Size = New System.Drawing.Size(615, 50)
        Me.LayoutControlItem103.Text = "Διάσταση"
        Me.LayoutControlItem103.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem103.TextSize = New System.Drawing.Size(201, 19)
        '
        'LayoutControlItem132
        '
        Me.LayoutControlItem132.Control = Me.txtInitialPrice10
        Me.LayoutControlItem132.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem132.CustomizationFormText = "Αρχική Τιμή"
        Me.LayoutControlItem132.HighlightFocusedItem = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlItem132.Location = New System.Drawing.Point(0, 100)
        Me.LayoutControlItem132.Name = "LayoutControlItem132"
        Me.LayoutControlItem132.Size = New System.Drawing.Size(307, 50)
        Me.LayoutControlItem132.Text = "Αρχική Τιμή"
        Me.LayoutControlItem132.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem132.TextSize = New System.Drawing.Size(201, 19)
        '
        'Lcost10
        '
        Me.Lcost10.Control = Me.txtDisc10
        Me.Lcost10.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.Lcost10.CustomizationFormText = "Έκπτωση"
        Me.Lcost10.HighlightFocusedItem = DevExpress.Utils.DefaultBoolean.[True]
        Me.Lcost10.Location = New System.Drawing.Point(307, 100)
        Me.Lcost10.Name = "Lcost10"
        Me.Lcost10.Size = New System.Drawing.Size(298, 50)
        Me.Lcost10.Text = "Έκπτωση"
        Me.Lcost10.TextLocation = DevExpress.Utils.Locations.Top
        Me.Lcost10.TextSize = New System.Drawing.Size(201, 19)
        '
        'LayoutControlItem133
        '
        Me.LayoutControlItem133.Control = Me.txtDiscount10
        Me.LayoutControlItem133.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem133.CustomizationFormText = "Ποσό Έκπτωσης"
        Me.LayoutControlItem133.HighlightFocusedItem = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlItem133.Location = New System.Drawing.Point(605, 100)
        Me.LayoutControlItem133.Name = "LayoutControlItem133"
        Me.LayoutControlItem133.Size = New System.Drawing.Size(329, 50)
        Me.LayoutControlItem133.Text = "Ποσό Έκπτωσης"
        Me.LayoutControlItem133.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem133.TextSize = New System.Drawing.Size(201, 19)
        '
        'LayoutControlItem134
        '
        Me.LayoutControlItem134.Control = Me.txtFinalPrice10
        Me.LayoutControlItem134.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem134.CustomizationFormText = "Τελική Τιμή(ΦΠΑ)"
        Me.LayoutControlItem134.HighlightFocusedItem = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlItem134.Location = New System.Drawing.Point(934, 100)
        Me.LayoutControlItem134.Name = "LayoutControlItem134"
        Me.LayoutControlItem134.Size = New System.Drawing.Size(351, 50)
        Me.LayoutControlItem134.Text = "Τελική Τιμή(ΦΠΑ)"
        Me.LayoutControlItem134.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem134.TextSize = New System.Drawing.Size(201, 19)
        '
        'LayoutControlItem100
        '
        Me.LayoutControlItem100.Control = Me.cboVALUELISTITEM10
        Me.LayoutControlItem100.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem100.CustomizationFormText = "Κωδικός Πόρτας"
        Me.LayoutControlItem100.Location = New System.Drawing.Point(247, 50)
        Me.LayoutControlItem100.Name = "LayoutControlItem100"
        Me.LayoutControlItem100.Size = New System.Drawing.Size(423, 50)
        Me.LayoutControlItem100.Text = "Κωδικός Πόρτας"
        Me.LayoutControlItem100.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem100.TextSize = New System.Drawing.Size(201, 19)
        '
        'LayoutControlItem104
        '
        Me.LayoutControlItem104.Control = Me.txtKnobs10
        Me.LayoutControlItem104.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem104.CustomizationFormText = "Πόμολα"
        Me.LayoutControlItem104.Location = New System.Drawing.Point(670, 50)
        Me.LayoutControlItem104.Name = "LayoutControlItem104"
        Me.LayoutControlItem104.Size = New System.Drawing.Size(615, 50)
        Me.LayoutControlItem104.Text = "Πόμολα"
        Me.LayoutControlItem104.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem104.TextSize = New System.Drawing.Size(201, 19)
        '
        'LCost
        '
        Me.LCost.AppearanceGroup.BorderColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Success
        Me.LCost.AppearanceGroup.Options.UseBorderColor = True
        Me.LCost.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LTotalDoorsPrice, Me.LExtraInst, Me.LExtraTransp, Me.LPartofVat, Me.LTotalDoorsVat, Me.EmptySpaceItem3, Me.EmptySpaceItem4})
        Me.LCost.Location = New System.Drawing.Point(0, 717)
        Me.LCost.Name = "LCost"
        Me.LCost.Size = New System.Drawing.Size(1333, 154)
        Me.LCost.Text = "Κοστολόγιο"
        '
        'LTotalDoorsPrice
        '
        Me.LTotalDoorsPrice.Control = Me.txtTotalDoorsPrice
        Me.LTotalDoorsPrice.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LTotalDoorsPrice.CustomizationFormText = "Συνολική αξία με ΦΠΑ"
        Me.LTotalDoorsPrice.HighlightFocusedItem = DevExpress.Utils.DefaultBoolean.[True]
        Me.LTotalDoorsPrice.Location = New System.Drawing.Point(960, 64)
        Me.LTotalDoorsPrice.Name = "LTotalDoorsPrice"
        Me.LTotalDoorsPrice.Size = New System.Drawing.Size(349, 34)
        Me.LTotalDoorsPrice.Text = "Συνολική αξία με ΦΠΑ"
        Me.LTotalDoorsPrice.TextSize = New System.Drawing.Size(201, 19)
        '
        'LExtraInst
        '
        Me.LExtraInst.Control = Me.txtExtraInst
        Me.LExtraInst.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LExtraInst.CustomizationFormText = "Τοποθέτηση(Εκτός Αττικής)"
        Me.LExtraInst.HighlightFocusedItem = DevExpress.Utils.DefaultBoolean.[True]
        Me.LExtraInst.Location = New System.Drawing.Point(609, 34)
        Me.LExtraInst.Name = "LExtraInst"
        Me.LExtraInst.Size = New System.Drawing.Size(351, 30)
        Me.LExtraInst.Text = "Τοποθέτηση(Εκτός Αττικής)"
        Me.LExtraInst.TextSize = New System.Drawing.Size(201, 19)
        Me.LExtraInst.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        '
        'LExtraTransp
        '
        Me.LExtraTransp.Control = Me.txtExtraTransp
        Me.LExtraTransp.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LExtraTransp.CustomizationFormText = "Μεταφορά(Εκτός Αττικής)"
        Me.LExtraTransp.HighlightFocusedItem = DevExpress.Utils.DefaultBoolean.[True]
        Me.LExtraTransp.Location = New System.Drawing.Point(609, 0)
        Me.LExtraTransp.Name = "LExtraTransp"
        Me.LExtraTransp.Size = New System.Drawing.Size(351, 34)
        Me.LExtraTransp.Text = "Μεταφορά(Εκτός Αττικής)"
        Me.LExtraTransp.TextSize = New System.Drawing.Size(201, 19)
        Me.LExtraTransp.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        '
        'LPartofVat
        '
        Me.LPartofVat.Control = Me.txtPartofVat
        Me.LPartofVat.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LPartofVat.CustomizationFormText = "Συμφωνηθέν ΦΠΑ"
        Me.LPartofVat.HighlightFocusedItem = DevExpress.Utils.DefaultBoolean.[True]
        Me.LPartofVat.Location = New System.Drawing.Point(960, 0)
        Me.LPartofVat.Name = "LPartofVat"
        Me.LPartofVat.Size = New System.Drawing.Size(349, 34)
        Me.LPartofVat.Text = "Συμφωνηθέν ΦΠΑ"
        Me.LPartofVat.TextSize = New System.Drawing.Size(201, 19)
        Me.LPartofVat.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        '
        'LTotalDoorsVat
        '
        Me.LTotalDoorsVat.Control = Me.txtTotalDoorsVat
        Me.LTotalDoorsVat.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LTotalDoorsVat.CustomizationFormText = "Συνολική αξία προ ΦΠΑ"
        Me.LTotalDoorsVat.HighlightFocusedItem = DevExpress.Utils.DefaultBoolean.[True]
        Me.LTotalDoorsVat.Location = New System.Drawing.Point(960, 34)
        Me.LTotalDoorsVat.Name = "LTotalDoorsVat"
        Me.LTotalDoorsVat.Size = New System.Drawing.Size(349, 30)
        Me.LTotalDoorsVat.Text = "Συνολική αξία προ ΦΠΑ"
        Me.LTotalDoorsVat.TextSize = New System.Drawing.Size(201, 19)
        '
        'EmptySpaceItem3
        '
        Me.EmptySpaceItem3.AllowHotTrack = False
        Me.EmptySpaceItem3.Location = New System.Drawing.Point(0, 0)
        Me.EmptySpaceItem3.Name = "EmptySpaceItem3"
        Me.EmptySpaceItem3.Size = New System.Drawing.Size(609, 98)
        Me.EmptySpaceItem3.TextSize = New System.Drawing.Size(0, 0)
        '
        'EmptySpaceItem4
        '
        Me.EmptySpaceItem4.AllowHotTrack = False
        Me.EmptySpaceItem4.Location = New System.Drawing.Point(609, 64)
        Me.EmptySpaceItem4.Name = "EmptySpaceItem4"
        Me.EmptySpaceItem4.Size = New System.Drawing.Size(351, 34)
        Me.EmptySpaceItem4.TextSize = New System.Drawing.Size(0, 0)
        '
        'LConvertToOrder
        '
        Me.LConvertToOrder.Control = Me.cmdConvertToOrder
        Me.LConvertToOrder.Location = New System.Drawing.Point(883, 905)
        Me.LConvertToOrder.Name = "LConvertToOrder"
        Me.LConvertToOrder.Size = New System.Drawing.Size(228, 36)
        Me.LConvertToOrder.Text = "Μετατροπή σε Παραγγελία"
        Me.LConvertToOrder.TextSize = New System.Drawing.Size(0, 0)
        Me.LConvertToOrder.TextVisible = False
        '
        'EmptySpaceItem14
        '
        Me.EmptySpaceItem14.AllowHotTrack = False
        Me.EmptySpaceItem14.Location = New System.Drawing.Point(402, 905)
        Me.EmptySpaceItem14.Name = "EmptySpaceItem14"
        Me.EmptySpaceItem14.Size = New System.Drawing.Size(61, 36)
        Me.EmptySpaceItem14.TextSize = New System.Drawing.Size(0, 0)
        '
        'LTotAmt
        '
        Me.LTotAmt.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.LTotAmt.AppearanceItemCaption.Options.UseFont = True
        Me.LTotAmt.Control = Me.txtTotAmt
        Me.LTotAmt.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LTotAmt.CustomizationFormText = "Γενικό Σύνολο Πώλησης"
        Me.LTotAmt.HighlightFocusedItem = DevExpress.Utils.DefaultBoolean.[True]
        Me.LTotAmt.Location = New System.Drawing.Point(970, 871)
        Me.LTotAmt.Name = "LTotAmt"
        Me.LTotAmt.Size = New System.Drawing.Size(363, 34)
        Me.LTotAmt.Text = "Γενικό Σύνολο Πώλησης"
        Me.LTotAmt.TextSize = New System.Drawing.Size(201, 19)
        '
        'LPrivateAgreement
        '
        Me.LPrivateAgreement.Control = Me.cmdPrivateAgreement
        Me.LPrivateAgreement.Location = New System.Drawing.Point(721, 905)
        Me.LPrivateAgreement.Name = "LPrivateAgreement"
        Me.LPrivateAgreement.Size = New System.Drawing.Size(162, 36)
        Me.LPrivateAgreement.Text = "Ιδ. Συμφωνητικό"
        Me.LPrivateAgreement.TextSize = New System.Drawing.Size(0, 0)
        Me.LPrivateAgreement.TextVisible = False
        '
        'LOrder
        '
        Me.LOrder.Control = Me.cmdOrder
        Me.LOrder.Location = New System.Drawing.Point(599, 905)
        Me.LOrder.Name = "LOrder"
        Me.LOrder.Size = New System.Drawing.Size(122, 36)
        Me.LOrder.Text = "Παραγγελία"
        Me.LOrder.TextSize = New System.Drawing.Size(0, 0)
        Me.LOrder.TextVisible = False
        '
        'LNewRecord
        '
        Me.LNewRecord.Control = Me.cmdNewRecord
        Me.LNewRecord.Location = New System.Drawing.Point(463, 905)
        Me.LNewRecord.Name = "LNewRecord"
        Me.LNewRecord.Size = New System.Drawing.Size(136, 36)
        Me.LNewRecord.Text = "Νέα Εγγραφή"
        Me.LNewRecord.TextSize = New System.Drawing.Size(0, 0)
        Me.LNewRecord.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.LblMsg
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 871)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(970, 34)
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'TabNavigationPage2
        '
        Me.TabNavigationPage2.Caption = "TabNavigationPage2"
        Me.TabNavigationPage2.Controls.Add(Me.LayoutControl3)
        Me.TabNavigationPage2.Margin = New System.Windows.Forms.Padding(10)
        Me.TabNavigationPage2.Name = "TabNavigationPage2"
        Me.TabNavigationPage2.PageText = "ΦΩΤΟΓΡΑΦΙΕΣ ΧΡΩΜΑΤΩΝ"
        Me.TabNavigationPage2.Size = New System.Drawing.Size(5198, 2999)
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
        Me.LayoutControl3.Margin = New System.Windows.Forms.Padding(10)
        Me.LayoutControl3.Name = "LayoutControl3"
        Me.LayoutControl3.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(1970, 1031, 1137, 700)
        Me.LayoutControl3.Root = Me.LayoutControlGroup14
        Me.LayoutControl3.Size = New System.Drawing.Size(5198, 2999)
        Me.LayoutControl3.TabIndex = 2
        Me.LayoutControl3.Text = "LayoutControl3"
        '
        'cmdPrintPhotos
        '
        Me.cmdPrintPhotos.Location = New System.Drawing.Point(12, 829)
        Me.cmdPrintPhotos.Margin = New System.Windows.Forms.Padding(15)
        Me.cmdPrintPhotos.Name = "cmdPrintPhotos"
        Me.cmdPrintPhotos.Size = New System.Drawing.Size(895, 32)
        Me.cmdPrintPhotos.StyleController = Me.LayoutControl3
        Me.cmdPrintPhotos.TabIndex = 57
        Me.cmdPrintPhotos.Text = "Εκτύπωση"
        '
        'cmdSavePhotos
        '
        Me.cmdSavePhotos.ImageOptions.Image = Global.DreamyKitchenCRM.My.Resources.Resources.icons8_save_close_24
        Me.cmdSavePhotos.Location = New System.Drawing.Point(4452, 829)
        Me.cmdSavePhotos.Margin = New System.Windows.Forms.Padding(15)
        Me.cmdSavePhotos.Name = "cmdSavePhotos"
        Me.cmdSavePhotos.Size = New System.Drawing.Size(734, 32)
        Me.cmdSavePhotos.StyleController = Me.LayoutControl3
        Me.cmdSavePhotos.TabIndex = 52
        Me.cmdSavePhotos.Text = "Αποθήκευση"
        '
        'GridControl1
        '
        Me.GridControl1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridControl1.DataSource = Me.VwCCTORDERSPHOTOSBindingSource
        Me.GridControl1.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(9)
        Me.GridControl1.Location = New System.Drawing.Point(12, 865)
        Me.GridControl1.MainView = Me.CardView1
        Me.GridControl1.Margin = New System.Windows.Forms.Padding(15)
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemColorCat, Me.RepositoryItemValueListiItem, Me.RepositoryItemSup, Me.RepositoryItemPhoto})
        Me.GridControl1.Size = New System.Drawing.Size(5174, 2122)
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
        Me.CardView1.CardWidth = 1399
        Me.CardView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colcolorCatID1, Me.colColorsCatName, Me.colsupID1, Me.colSupFullName, Me.colvalueListItemID1, Me.colValueListItemName, Me.colphoto, Me.colID1, Me.colvalueListItemID, Me.colCustomCode, Me.colcreatedOn, Me.colcreatedBy, Me.colcolorCatID, Me.colmodifiedBy, Me.colmodifiedOn, Me.colsite, Me.colsupID})
        Me.CardView1.DetailHeight = 886
        GridFormatRule2.ApplyToRow = True
        GridFormatRule2.Name = "Format0"
        FormatConditionRuleExpression2.Appearance.BackColor = System.Drawing.Color.White
        FormatConditionRuleExpression2.Appearance.Options.UseBackColor = True
        FormatConditionRuleExpression2.Expression = "IsNullOrEmpty([dCode]) And [checked] = True"
        FormatConditionRuleExpression2.PredefinedName = "Red Text"
        GridFormatRule2.Rule = FormatConditionRuleExpression2
        Me.CardView1.FormatRules.Add(GridFormatRule2)
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
        Me.colcolorCatID1.MinWidth = 94
        Me.colcolorCatID1.Name = "colcolorCatID1"
        Me.colcolorCatID1.Visible = True
        Me.colcolorCatID1.VisibleIndex = 1
        Me.colcolorCatID1.Width = 363
        '
        'RepositoryItemColorCat
        '
        Me.RepositoryItemColorCat.AutoHeight = False
        Me.RepositoryItemColorCat.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemColorCat.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 94, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("code", "code", 150, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("name", "Κατηγορία", 169, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("modifiedBy", "modified By", 313, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("modifiedOn", "modified On", 321, DevExpress.Utils.FormatType.DateTime, "d/M/yyyy", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("createdOn", "created On", 298, DevExpress.Utils.FormatType.DateTime, "d/M/yyyy", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("createdBy", "created By", 285, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("RealName", "Real Name", 294, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default])})
        Me.RepositoryItemColorCat.DisplayMember = "name"
        Me.RepositoryItemColorCat.Name = "RepositoryItemColorCat"
        Me.RepositoryItemColorCat.NullText = ""
        Me.RepositoryItemColorCat.ValueMember = "ID"
        '
        'colColorsCatName
        '
        Me.colColorsCatName.Caption = "Κατηγορία"
        Me.colColorsCatName.FieldName = "ColorsCatName"
        Me.colColorsCatName.MinWidth = 94
        Me.colColorsCatName.Name = "colColorsCatName"
        Me.colColorsCatName.Width = 363
        '
        'colsupID1
        '
        Me.colsupID1.Caption = "Προμηθευτής"
        Me.colsupID1.ColumnEdit = Me.RepositoryItemSup
        Me.colsupID1.FieldName = "supID"
        Me.colsupID1.MinWidth = 94
        Me.colsupID1.Name = "colsupID1"
        Me.colsupID1.Visible = True
        Me.colsupID1.VisibleIndex = 2
        Me.colsupID1.Width = 363
        '
        'RepositoryItemSup
        '
        Me.RepositoryItemSup.AutoHeight = False
        Me.RepositoryItemSup.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemSup.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 94, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("code", "code", 150, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Fullname", "Επωνυμία", 253, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ttl", "ttl", 87, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("bal", "bal", 111, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("email", "email", 160, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("site", "site", 54, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default])})
        Me.RepositoryItemSup.DisplayMember = "Fullname"
        Me.RepositoryItemSup.Name = "RepositoryItemSup"
        Me.RepositoryItemSup.NullText = ""
        Me.RepositoryItemSup.ValueMember = "ID"
        '
        'colSupFullName
        '
        Me.colSupFullName.Caption = "Προμηθευτής"
        Me.colSupFullName.FieldName = "SupFullName"
        Me.colSupFullName.MinWidth = 94
        Me.colSupFullName.Name = "colSupFullName"
        Me.colSupFullName.Width = 363
        '
        'colvalueListItemID1
        '
        Me.colvalueListItemID1.Caption = "Κωδικός Χρώματος"
        Me.colvalueListItemID1.ColumnEdit = Me.RepositoryItemValueListiItem
        Me.colvalueListItemID1.FieldName = "valueListItemID"
        Me.colvalueListItemID1.MinWidth = 94
        Me.colvalueListItemID1.Name = "colvalueListItemID1"
        Me.colvalueListItemID1.Visible = True
        Me.colvalueListItemID1.VisibleIndex = 3
        Me.colvalueListItemID1.Width = 363
        '
        'RepositoryItemValueListiItem
        '
        Me.RepositoryItemValueListiItem.AutoHeight = False
        Me.RepositoryItemValueListiItem.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemValueListiItem.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Modifier", "Modifier", 225, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 94, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("code", "code", 150, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CustomCode", "Κωδικός", 343, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("name", "Χρώματα", 169, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("cat", "cat", 111, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("color", "color", 150, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Price", "Price", 150, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("comments", "comments", 280, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("modifiedBy", "modified By", 313, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("modifiedOn", "modified On", 321, DevExpress.Utils.FormatType.DateTime, "d/M/yyyy", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("createdOn", "created On", 298, DevExpress.Utils.FormatType.DateTime, "d/M/yyyy", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("createdBy", "created By", 285, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("doorColorID", "door Color ID", 348, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ColorName", "Color Name", 307, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("typeDescr", "type Descr", 285, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("type", "type", 142, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("valueListItem", "value List Item", 375, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("kasa", "kasa", 142, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("dimName", "dim Name", 280, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("dimID", "dim ID", 196, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("valueListID", "value List ID", 325, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("valueListName", "value List Name", 403, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("closetType", "closet Type", 298, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("description", "description", 294, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("doorType", "door Type", 274, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default])})
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
        Me.colValueListItemName.MinWidth = 94
        Me.colValueListItemName.Name = "colValueListItemName"
        Me.colValueListItemName.Width = 363
        '
        'colphoto
        '
        Me.colphoto.Caption = "Φωτογραφία"
        Me.colphoto.FieldName = "photo"
        Me.colphoto.MinWidth = 94
        Me.colphoto.Name = "colphoto"
        Me.colphoto.Visible = True
        Me.colphoto.VisibleIndex = 0
        Me.colphoto.Width = 414
        '
        'colID1
        '
        Me.colID1.FieldName = "ID"
        Me.colID1.MinWidth = 94
        Me.colID1.Name = "colID1"
        Me.colID1.Width = 363
        '
        'colvalueListItemID
        '
        Me.colvalueListItemID.FieldName = "valueListItemID"
        Me.colvalueListItemID.MinWidth = 94
        Me.colvalueListItemID.Name = "colvalueListItemID"
        Me.colvalueListItemID.Width = 363
        '
        'colCustomCode
        '
        Me.colCustomCode.FieldName = "CustomCode"
        Me.colCustomCode.MinWidth = 94
        Me.colCustomCode.Name = "colCustomCode"
        Me.colCustomCode.Width = 363
        '
        'colcreatedOn
        '
        Me.colcreatedOn.FieldName = "createdOn"
        Me.colcreatedOn.MinWidth = 94
        Me.colcreatedOn.Name = "colcreatedOn"
        Me.colcreatedOn.Width = 363
        '
        'colcreatedBy
        '
        Me.colcreatedBy.FieldName = "createdBy"
        Me.colcreatedBy.MinWidth = 94
        Me.colcreatedBy.Name = "colcreatedBy"
        Me.colcreatedBy.Width = 363
        '
        'colcolorCatID
        '
        Me.colcolorCatID.FieldName = "colorCatID"
        Me.colcolorCatID.MinWidth = 94
        Me.colcolorCatID.Name = "colcolorCatID"
        Me.colcolorCatID.Width = 363
        '
        'colmodifiedBy
        '
        Me.colmodifiedBy.FieldName = "modifiedBy"
        Me.colmodifiedBy.MinWidth = 94
        Me.colmodifiedBy.Name = "colmodifiedBy"
        Me.colmodifiedBy.Width = 363
        '
        'colmodifiedOn
        '
        Me.colmodifiedOn.FieldName = "modifiedOn"
        Me.colmodifiedOn.MinWidth = 94
        Me.colmodifiedOn.Name = "colmodifiedOn"
        Me.colmodifiedOn.Width = 363
        '
        'colsite
        '
        Me.colsite.FieldName = "site"
        Me.colsite.MinWidth = 94
        Me.colsite.Name = "colsite"
        Me.colsite.Width = 363
        '
        'colsupID
        '
        Me.colsupID.FieldName = "supID"
        Me.colsupID.MinWidth = 94
        Me.colsupID.Name = "colsupID"
        Me.colsupID.Width = 363
        '
        'RepositoryItemPhoto
        '
        Me.RepositoryItemPhoto.Name = "RepositoryItemPhoto"
        Me.RepositoryItemPhoto.PictureStoreMode = DevExpress.XtraEditors.Controls.PictureStoreMode.Image
        '
        'cboPhotoValueListItem
        '
        Me.cboPhotoValueListItem.Location = New System.Drawing.Point(160, 72)
        Me.cboPhotoValueListItem.Margin = New System.Windows.Forms.Padding(15)
        Me.cboPhotoValueListItem.Name = "cboPhotoValueListItem"
        Me.cboPhotoValueListItem.Properties.AllowMouseWheel = False
        Me.cboPhotoValueListItem.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.cboPhotoValueListItem.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Search), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Clear)})
        Me.cboPhotoValueListItem.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Modifier", "Modifier", 225, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 94, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("code", "code", 150, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CustomCode", "Κωδικός", 343, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("name", "Χρώμα", 169, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("cat", "cat", 111, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("color", "color", 150, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Price", "Price", 150, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("comments", "comments", 280, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("modifiedBy", "modified By", 313, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("modifiedOn", "modified On", 321, DevExpress.Utils.FormatType.DateTime, "d/M/yyyy", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("createdOn", "created On", 298, DevExpress.Utils.FormatType.DateTime, "d/M/yyyy", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("createdBy", "created By", 285, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("doorColorID", "door Color ID", 348, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ColorName", "Color Name", 307, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("typeDescr", "type Descr", 285, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("type", "type", 142, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("valueListItem", "value List Item", 375, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("kasa", "kasa", 142, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("dimName", "dim Name", 280, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("dimID", "dim ID", 196, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("valueListID", "value List ID", 325, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("valueListName", "value List Name", 403, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("closetType", "closet Type", 298, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("description", "description", 294, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("doorType", "door Type", 274, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default])})
        Me.cboPhotoValueListItem.Properties.DataSource = Me.VwVALUELISTITEMV2BindingSource
        Me.cboPhotoValueListItem.Properties.DisplayMember = "name"
        Me.cboPhotoValueListItem.Properties.NullText = ""
        Me.cboPhotoValueListItem.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.cboPhotoValueListItem.Properties.PopupFormMinSize = New System.Drawing.Size(1653, 761)
        Me.cboPhotoValueListItem.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoSuggest
        Me.cboPhotoValueListItem.Properties.ValueMember = "ID"
        Me.cboPhotoValueListItem.Size = New System.Drawing.Size(5026, 26)
        Me.cboPhotoValueListItem.StyleController = Me.LayoutControl3
        Me.cboPhotoValueListItem.TabIndex = 50
        Me.cboPhotoValueListItem.Tag = "valueListItemID,0,1,2"
        '
        'cboSUP1
        '
        Me.cboSUP1.Location = New System.Drawing.Point(160, 12)
        Me.cboSUP1.Margin = New System.Windows.Forms.Padding(15)
        Me.cboSUP1.Name = "cboSUP1"
        Me.cboSUP1.Properties.AllowMouseWheel = False
        Me.cboSUP1.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        EditorButtonImageOptions2.Image = CType(resources.GetObject("EditorButtonImageOptions2.Image"), System.Drawing.Image)
        Me.cboSUP1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Search), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Clear), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, EditorButtonImageOptions2, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject5, SerializableAppearanceObject6, SerializableAppearanceObject7, SerializableAppearanceObject8, "", Nothing, Nothing, DevExpress.Utils.ToolTipAnchor.[Default])})
        Me.cboSUP1.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 94, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("code", "code", 150, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Fullname", "Επωνυμία", 253, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ttl", "ttl", 87, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("bal", "bal", 111, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("email", "email", 160, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("site", "site", 54, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default])})
        Me.cboSUP1.Properties.DataSource = Me.VwSUPBindingSource
        Me.cboSUP1.Properties.DisplayMember = "Fullname"
        Me.cboSUP1.Properties.NullText = ""
        Me.cboSUP1.Properties.PopupSizeable = False
        Me.cboSUP1.Properties.ValueMember = "ID"
        Me.cboSUP1.Size = New System.Drawing.Size(5026, 26)
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
        Me.cboColorsCat.Location = New System.Drawing.Point(160, 42)
        Me.cboColorsCat.Margin = New System.Windows.Forms.Padding(15)
        Me.cboColorsCat.Name = "cboColorsCat"
        Me.cboColorsCat.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.cboColorsCat.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Search), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Clear)})
        Me.cboColorsCat.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 94, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("code", "code", 150, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("name", "Κατηγορία", 169, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("modifiedBy", "modified By", 313, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("modifiedOn", "modified On", 321, DevExpress.Utils.FormatType.DateTime, "d/M/yyyy", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("createdOn", "created On", 298, DevExpress.Utils.FormatType.DateTime, "d/M/yyyy", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("createdBy", "created By", 285, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("RealName", "Real Name", 294, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default])})
        Me.cboColorsCat.Properties.DataSource = Me.VwCOLORSCATBindingSource
        Me.cboColorsCat.Properties.DisplayMember = "name"
        Me.cboColorsCat.Properties.NullText = ""
        Me.cboColorsCat.Properties.PopupSizeable = False
        Me.cboColorsCat.Properties.ValueMember = "ID"
        Me.cboColorsCat.Size = New System.Drawing.Size(5026, 26)
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
        Me.PictureEdit2.Location = New System.Drawing.Point(160, 102)
        Me.PictureEdit2.Margin = New System.Windows.Forms.Padding(15)
        Me.PictureEdit2.Name = "PictureEdit2"
        Me.PictureEdit2.Properties.PictureStoreMode = DevExpress.XtraEditors.Controls.PictureStoreMode.ByteArray
        Me.PictureEdit2.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Always
        Me.PictureEdit2.Properties.ShowScrollBars = True
        Me.PictureEdit2.Properties.ShowZoomSubMenu = DevExpress.Utils.DefaultBoolean.[True]
        Me.PictureEdit2.Size = New System.Drawing.Size(5026, 723)
        Me.PictureEdit2.StyleController = Me.LayoutControl3
        Me.PictureEdit2.TabIndex = 44
        Me.PictureEdit2.Tag = "photo,0,1,2"
        '
        'LayoutControlGroup14
        '
        Me.LayoutControlGroup14.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup14.GroupBordersVisible = False
        Me.LayoutControlGroup14.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem14, Me.LayoutControlItem16, Me.LayoutControlItem17, Me.LayoutControlItem19, Me.LayoutControlItem20, Me.LayoutControlItem34, Me.EmptySpaceItem5, Me.LayoutControlItem36})
        Me.LayoutControlGroup14.Name = "Root"
        Me.LayoutControlGroup14.Size = New System.Drawing.Size(5198, 2999)
        Me.LayoutControlGroup14.TextVisible = False
        '
        'LayoutControlItem14
        '
        Me.LayoutControlItem14.Control = Me.cboSUP1
        Me.LayoutControlItem14.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem14.CustomizationFormText = "Νομός"
        Me.LayoutControlItem14.HighlightFocusedItem = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlItem14.ImageOptions.Image = CType(resources.GetObject("LayoutControlItem14.ImageOptions.Image"), System.Drawing.Image)
        Me.LayoutControlItem14.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem14.Name = "LayoutControlItem92"
        Me.LayoutControlItem14.Size = New System.Drawing.Size(5178, 30)
        Me.LayoutControlItem14.Text = "Προμηθευτής"
        Me.LayoutControlItem14.TextSize = New System.Drawing.Size(136, 19)
        '
        'LayoutControlItem16
        '
        Me.LayoutControlItem16.Control = Me.cboColorsCat
        Me.LayoutControlItem16.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem16.CustomizationFormText = "Πορτάκι"
        Me.LayoutControlItem16.ImageOptions.Image = CType(resources.GetObject("LayoutControlItem16.ImageOptions.Image"), System.Drawing.Image)
        Me.LayoutControlItem16.Location = New System.Drawing.Point(0, 30)
        Me.LayoutControlItem16.Name = "LayoutControlItem93"
        Me.LayoutControlItem16.Size = New System.Drawing.Size(5178, 30)
        Me.LayoutControlItem16.Text = "Κατηγορία"
        Me.LayoutControlItem16.TextSize = New System.Drawing.Size(136, 19)
        '
        'LayoutControlItem17
        '
        Me.LayoutControlItem17.Control = Me.cboPhotoValueListItem
        Me.LayoutControlItem17.Location = New System.Drawing.Point(0, 60)
        Me.LayoutControlItem17.Name = "LayoutControlItem94"
        Me.LayoutControlItem17.Size = New System.Drawing.Size(5178, 30)
        Me.LayoutControlItem17.Text = "Κωδικός Χρώματος"
        Me.LayoutControlItem17.TextSize = New System.Drawing.Size(136, 19)
        '
        'LayoutControlItem19
        '
        Me.LayoutControlItem19.Control = Me.PictureEdit2
        Me.LayoutControlItem19.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem19.CustomizationFormText = "Φωτογραφία"
        Me.LayoutControlItem19.Location = New System.Drawing.Point(0, 90)
        Me.LayoutControlItem19.Name = "LayoutControlItem95"
        Me.LayoutControlItem19.Size = New System.Drawing.Size(5178, 727)
        Me.LayoutControlItem19.Text = "Φωτογραφία"
        Me.LayoutControlItem19.TextLocation = DevExpress.Utils.Locations.Left
        Me.LayoutControlItem19.TextSize = New System.Drawing.Size(136, 19)
        '
        'LayoutControlItem20
        '
        Me.LayoutControlItem20.Control = Me.GridControl1
        Me.LayoutControlItem20.Location = New System.Drawing.Point(0, 853)
        Me.LayoutControlItem20.Name = "LayoutControlItem96"
        Me.LayoutControlItem20.Size = New System.Drawing.Size(5178, 2126)
        Me.LayoutControlItem20.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem20.TextVisible = False
        '
        'LayoutControlItem34
        '
        Me.LayoutControlItem34.Control = Me.cmdSavePhotos
        Me.LayoutControlItem34.Location = New System.Drawing.Point(4440, 817)
        Me.LayoutControlItem34.Name = "LayoutControlItem97"
        Me.LayoutControlItem34.Size = New System.Drawing.Size(738, 36)
        Me.LayoutControlItem34.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem34.TextVisible = False
        '
        'EmptySpaceItem5
        '
        Me.EmptySpaceItem5.AllowHotTrack = False
        Me.EmptySpaceItem5.Location = New System.Drawing.Point(899, 817)
        Me.EmptySpaceItem5.Name = "EmptySpaceItem2"
        Me.EmptySpaceItem5.Size = New System.Drawing.Size(3541, 36)
        Me.EmptySpaceItem5.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem36
        '
        Me.LayoutControlItem36.Control = Me.cmdPrintPhotos
        Me.LayoutControlItem36.Location = New System.Drawing.Point(0, 817)
        Me.LayoutControlItem36.Name = "LayoutControlItem98"
        Me.LayoutControlItem36.Size = New System.Drawing.Size(899, 36)
        Me.LayoutControlItem36.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem36.TextVisible = False
        '
        'TabNavigationPage3
        '
        Me.TabNavigationPage3.Caption = "TabNavigationPage3"
        Me.TabNavigationPage3.Controls.Add(Me.LayoutControl4)
        Me.TabNavigationPage3.Margin = New System.Windows.Forms.Padding(10)
        Me.TabNavigationPage3.Name = "TabNavigationPage3"
        Me.TabNavigationPage3.PageText = "ΑΡΧΕΙΑ"
        Me.TabNavigationPage3.Size = New System.Drawing.Size(1353, 961)
        '
        'LayoutControl4
        '
        Me.LayoutControl4.Controls.Add(Me.cmdSaveTransF)
        Me.LayoutControl4.Controls.Add(Me.cboTanshFCategory)
        Me.LayoutControl4.Controls.Add(Me.GridControl2)
        Me.LayoutControl4.Controls.Add(Me.txtFiles)
        Me.LayoutControl4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl4.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl4.Margin = New System.Windows.Forms.Padding(10)
        Me.LayoutControl4.Name = "LayoutControl4"
        Me.LayoutControl4.Root = Me.LayoutControlGroup16
        Me.LayoutControl4.Size = New System.Drawing.Size(1353, 961)
        Me.LayoutControl4.TabIndex = 2
        Me.LayoutControl4.Text = "LayoutControl4"
        '
        'cmdSaveTransF
        '
        Me.cmdSaveTransF.ImageOptions.Image = Global.DreamyKitchenCRM.My.Resources.Resources.icons8_save_close_24
        Me.cmdSaveTransF.Location = New System.Drawing.Point(1157, 72)
        Me.cmdSaveTransF.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdSaveTransF.Name = "cmdSaveTransF"
        Me.cmdSaveTransF.Size = New System.Drawing.Size(184, 32)
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
        Me.cboTanshFCategory.Size = New System.Drawing.Size(1232, 26)
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
        Me.GridControl2.Margin = New System.Windows.Forms.Padding(15)
        Me.GridControl2.Name = "GridControl2"
        Me.GridControl2.Size = New System.Drawing.Size(1329, 841)
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
        Me.GridView3.DetailHeight = 1565
        Me.GridView3.GridControl = Me.GridControl2
        Me.GridView3.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always
        Me.GridView3.Name = "GridView3"
        Me.GridView3.OptionsBehavior.Editable = False
        Me.GridView3.OptionsEditForm.PopupEditFormWidth = 2205
        Me.GridView3.OptionsView.ColumnAutoWidth = False
        Me.GridView3.OptionsView.ShowGroupPanel = False
        '
        'GridColumn6
        '
        Me.GridColumn6.FieldName = "ID"
        Me.GridColumn6.MinWidth = 94
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 0
        Me.GridColumn6.Width = 363
        '
        'GridColumn7
        '
        Me.GridColumn7.FieldName = "code"
        Me.GridColumn7.MinWidth = 94
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.Visible = True
        Me.GridColumn7.VisibleIndex = 1
        Me.GridColumn7.Width = 363
        '
        'coltranshID1
        '
        Me.coltranshID1.FieldName = "transhID"
        Me.coltranshID1.MinWidth = 94
        Me.coltranshID1.Name = "coltranshID1"
        Me.coltranshID1.Visible = True
        Me.coltranshID1.VisibleIndex = 2
        Me.coltranshID1.Width = 363
        '
        'colfilename
        '
        Me.colfilename.FieldName = "filename"
        Me.colfilename.MinWidth = 94
        Me.colfilename.Name = "colfilename"
        Me.colfilename.Visible = True
        Me.colfilename.VisibleIndex = 3
        Me.colfilename.Width = 363
        '
        'colcomefrom
        '
        Me.colcomefrom.FieldName = "comefrom"
        Me.colcomefrom.MinWidth = 94
        Me.colcomefrom.Name = "colcomefrom"
        Me.colcomefrom.Visible = True
        Me.colcomefrom.VisibleIndex = 4
        Me.colcomefrom.Width = 363
        '
        'colextension
        '
        Me.colextension.FieldName = "extension"
        Me.colextension.MinWidth = 94
        Me.colextension.Name = "colextension"
        Me.colextension.Visible = True
        Me.colextension.VisibleIndex = 5
        Me.colextension.Width = 363
        '
        'GridColumn8
        '
        Me.GridColumn8.FieldName = "modifiedBy"
        Me.GridColumn8.MinWidth = 94
        Me.GridColumn8.Name = "GridColumn8"
        Me.GridColumn8.Visible = True
        Me.GridColumn8.VisibleIndex = 6
        Me.GridColumn8.Width = 363
        '
        'colmodifiedOn1
        '
        Me.colmodifiedOn1.FieldName = "modifiedOn"
        Me.colmodifiedOn1.MinWidth = 94
        Me.colmodifiedOn1.Name = "colmodifiedOn1"
        Me.colmodifiedOn1.Visible = True
        Me.colmodifiedOn1.VisibleIndex = 7
        Me.colmodifiedOn1.Width = 363
        '
        'colcreatedOn1
        '
        Me.colcreatedOn1.FieldName = "createdOn"
        Me.colcreatedOn1.MinWidth = 94
        Me.colcreatedOn1.Name = "colcreatedOn1"
        Me.colcreatedOn1.Visible = True
        Me.colcreatedOn1.VisibleIndex = 8
        Me.colcreatedOn1.Width = 363
        '
        'GridColumn9
        '
        Me.GridColumn9.FieldName = "createdBy"
        Me.GridColumn9.MinWidth = 94
        Me.GridColumn9.Name = "GridColumn9"
        Me.GridColumn9.Visible = True
        Me.GridColumn9.VisibleIndex = 9
        Me.GridColumn9.Width = 363
        '
        'txtFiles
        '
        Me.txtFiles.Location = New System.Drawing.Point(109, 12)
        Me.txtFiles.Margin = New System.Windows.Forms.Padding(4)
        Me.txtFiles.Name = "txtFiles"
        Me.txtFiles.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.txtFiles.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph), New DevExpress.XtraEditors.Controls.EditorButton(), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete)})
        Me.txtFiles.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.txtFiles.Size = New System.Drawing.Size(1232, 26)
        Me.txtFiles.StyleController = Me.LayoutControl4
        Me.txtFiles.TabIndex = 0
        Me.txtFiles.Tag = ""
        '
        'LayoutControlGroup16
        '
        Me.LayoutControlGroup16.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup16.GroupBordersVisible = False
        Me.LayoutControlGroup16.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem42, Me.LayoutControlItem78, Me.LayoutControlItem85, Me.LayoutControlItem86, Me.EmptySpaceItem6})
        Me.LayoutControlGroup16.Name = "LayoutControlGroup11"
        Me.LayoutControlGroup16.Size = New System.Drawing.Size(1353, 961)
        Me.LayoutControlGroup16.TextVisible = False
        '
        'LayoutControlItem42
        '
        Me.LayoutControlItem42.Control = Me.GridControl2
        Me.LayoutControlItem42.Location = New System.Drawing.Point(0, 96)
        Me.LayoutControlItem42.Name = "LayoutControlItem99"
        Me.LayoutControlItem42.Size = New System.Drawing.Size(1333, 845)
        Me.LayoutControlItem42.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem42.TextVisible = False
        '
        'LayoutControlItem78
        '
        Me.LayoutControlItem78.Control = Me.txtFiles
        Me.LayoutControlItem78.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem78.CustomizationFormText = "Αρχεία"
        Me.LayoutControlItem78.HighlightFocusedItem = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlItem78.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem78.Name = "LayoutControlItem78"
        Me.LayoutControlItem78.Size = New System.Drawing.Size(1333, 30)
        Me.LayoutControlItem78.Text = "Αρχεία"
        Me.LayoutControlItem78.TextSize = New System.Drawing.Size(85, 19)
        '
        'LayoutControlItem85
        '
        Me.LayoutControlItem85.Control = Me.cboTanshFCategory
        Me.LayoutControlItem85.CustomizationFormText = "Κατηγορία"
        Me.LayoutControlItem85.ImageOptions.Image = Global.DreamyKitchenCRM.My.Resources.Resources.rsz_11rsz_asterisk
        Me.LayoutControlItem85.Location = New System.Drawing.Point(0, 30)
        Me.LayoutControlItem85.Name = "LayoutControlItem85"
        Me.LayoutControlItem85.Size = New System.Drawing.Size(1333, 30)
        Me.LayoutControlItem85.Text = "Κατηγορία"
        Me.LayoutControlItem85.TextSize = New System.Drawing.Size(85, 19)
        '
        'LayoutControlItem86
        '
        Me.LayoutControlItem86.Control = Me.cmdSaveTransF
        Me.LayoutControlItem86.Location = New System.Drawing.Point(1145, 60)
        Me.LayoutControlItem86.Name = "LayoutControlItem86"
        Me.LayoutControlItem86.Size = New System.Drawing.Size(188, 36)
        Me.LayoutControlItem86.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem86.TextVisible = False
        '
        'EmptySpaceItem6
        '
        Me.EmptySpaceItem6.AllowHotTrack = False
        Me.EmptySpaceItem6.Location = New System.Drawing.Point(0, 60)
        Me.EmptySpaceItem6.Name = "EmptySpaceItem6"
        Me.EmptySpaceItem6.Size = New System.Drawing.Size(1145, 36)
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
        'VwSCANFILENAMESBindingSource
        '
        Me.VwSCANFILENAMESBindingSource.DataMember = "vw_SCAN_FILE_NAMES"
        Me.VwSCANFILENAMESBindingSource.DataSource = Me.DreamyKitchenDataSet
        '
        'XtraOpenFileDialog1
        '
        Me.XtraOpenFileDialog1.Title = "Επιλογή αρχείων"
        '
        'Vw_FILE_CATTableAdapter
        '
        Me.Vw_FILE_CATTableAdapter.ClearBeforeFill = True
        '
        'frmCUSOfferOrderDoors
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1353, 1010)
        Me.Controls.Add(Me.TabPane1)
        Me.IconOptions.Image = Global.DreamyKitchenCRM.My.Resources.Resources.favicon
        Me.Name = "frmCUSOfferOrderDoors"
        Me.Text = "Έντυπο Προσφοράς Πελάτη"
        CType(Me.VwCOMPBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DM_CCT, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VwCCTBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DreamyKitchenDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VwSALERSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VwVALUELISTITEMV2BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DM_VALUELISTITEM, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CCTTRANSHBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DM_TRANS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DMDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VwCOLORSDOORSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
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
        CType(Me.txtDimension1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDimension2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDimension3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDimension4.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDimension8.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDimension5.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTotalDoorsVat.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboEMP.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboFora1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboFora2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboFora3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboFora4.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboFora5.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboFora6.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboKasa1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboKasa2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboKasa3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboKasa4.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboKasa5.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboKasa6.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDescription.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtComments.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtKnobs1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTotalDoorsPrice.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNotes.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboTRANSH.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtExtraInst.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPartofVat.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboType1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboType2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboType3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboType4.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboType5.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboType6.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboValueListItem.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboVALUELISTITEM2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboVALUELISTITEM3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboVALUELISTITEM4.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboVALUELISTITEM5.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboVALUELISTITEM6.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtExtraTransp.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtKnobs2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtKnobs3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtKnobs4.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtKnobs5.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtKnobs6.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboType7.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboKasa7.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboFora7.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboVALUELISTITEM7.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDimension142.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtKnobs7.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboType8.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboKasa8.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboFora8.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboVALUELISTITEM8.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDimension141.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtKnobs8.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboType9.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboKasa9.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboFora9.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboVALUELISTITEM9.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDimension9.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtKnobs9.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboType10.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboKasa10.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboFora10.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboVALUELISTITEM10.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDimension10.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtKnobs10.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtInitialPrice1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDisc1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDiscount1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFinalPrice1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtInitialPrice2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDisc2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDiscount2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFinalPrice2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtInitialPrice3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDisc3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDiscount3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFinalPrice3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtInitialPrice4.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDisc4.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDiscount4.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFinalPrice4.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtInitialPrice5.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDisc5.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDiscount5.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFinalPrice5.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtInitialPrice6.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDisc6.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDiscount6.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFinalPrice6.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtInitialPrice7.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDisc7.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDiscount7.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFinalPrice7.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtInitialPrice8.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDisc8.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDiscount8.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFinalPrice8.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtInitialPrice9.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDisc9.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDiscount9.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFinalPrice9.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtInitialPrice10.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDisc10.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDiscount10.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFinalPrice10.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTotAmt.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LExit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LSave, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LGroupOrderDetails1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LarProt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LEMP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem41, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ldtpresentation, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem31, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LlblDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LofferAccepted, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LCompProject, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LCompCollection, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LCusCollection, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LGenOffer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LPrintOffer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LvisibleVAT, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LGroupOrderDetails2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem32, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem33, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem39, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TabbedControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem56, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem24, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem105, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Lcost3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem106, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem107, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem58, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem18, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem37, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem57, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem25, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem23, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem108, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Lcost1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem109, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem110, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem22, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem59, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem49, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem26, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem111, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Lcost2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem112, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem113, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem63, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem21, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem60, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem50, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem27, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem114, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Lcost4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem115, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem116, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem64, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem67, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem61, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem51, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem29, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem117, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Lcost5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem118, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem119, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem65, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem68, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem62, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem28, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem120, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Lcost6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem121, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem122, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem66, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem71, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem52, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutRootGroupForRestore, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem81, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem82, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem83, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem87, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem123, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Lcost7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem124, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem125, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem84, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem88, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem73, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem74, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem75, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem79, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem126, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Lcost8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem127, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem128, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem76, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem80, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem89, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem90, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem91, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem95, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem129, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Lcost9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem130, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem131, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem92, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem96, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup17, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem97, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem98, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem99, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem103, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem132, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Lcost10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem133, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem134, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem100, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem104, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LCost, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LTotalDoorsPrice, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LExtraInst, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LExtraTransp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LPartofVat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LTotalDoorsVat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LConvertToOrder, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LTotAmt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LPrivateAgreement, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LOrder, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LNewRecord, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
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
        CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem17, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem19, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem20, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem34, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem36, System.ComponentModel.ISupportInitialize).EndInit()
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
        CType(Me.LayoutControlItem42, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem78, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem85, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem86, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VwSCANFILENAMESBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DreamyKitchenDataSet As DreamyKitchenDataSet
    Friend WithEvents VwSALERSBindingSource As BindingSource
    Friend WithEvents Vw_SALERSTableAdapter As DreamyKitchenDataSetTableAdapters.vw_SALERSTableAdapter
    Friend WithEvents VwCOLORSDOORSBindingSource As BindingSource
    Friend WithEvents Vw_COLORSDOORSTableAdapter As DreamyKitchenDataSetTableAdapters.vw_COLORSDOORSTableAdapter
    Friend WithEvents DMDataSet As DMDataSet
    Friend WithEvents CCTTRANSHBindingSource As BindingSource
    Friend WithEvents DM_VALUELISTITEM As DM_VALUELISTITEM
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
    Friend WithEvents LayoutControlItem14 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem16 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem17 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem19 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem20 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem34 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem5 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LayoutControlItem36 As DevExpress.XtraLayout.LayoutControlItem
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
    Friend WithEvents LayoutControlItem42 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents VwCCTORDERSPHOTOSBindingSource As BindingSource
    Friend WithEvents Vw_CCT_ORDERS_PHOTOSTableAdapter As DM_CCTTableAdapters.vw_CCT_ORDERS_PHOTOSTableAdapter
    Friend WithEvents TRANSHFBindingSource As BindingSource
    Friend WithEvents TRANSH_FTableAdapter As DM_TRANSTableAdapters.TRANSH_FTableAdapter
    Friend WithEvents VwSUPBindingSource As BindingSource
    Friend WithEvents Vw_SUPTableAdapter As DreamyKitchenDataSetTableAdapters.vw_SUPTableAdapter
    Friend WithEvents Vw_COLORS_CATTableAdapter As DreamyKitchenDataSetTableAdapters.vw_COLORS_CATTableAdapter
    Friend WithEvents VwCOLORSCATBindingSource As BindingSource
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents cmdOrder As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdPrivateAgreement As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdNewRecord As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdCusCollection As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdCompCollection As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cboCompProject As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents cboCompany As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents chkofferAccepted As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkVatVisible As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents cmdPrintOffer As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lblDate As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtdtdaysOfDelivery As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cmdSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdExit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cboCUS As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents txtarProt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents dtpresentation As DevExpress.XtraEditors.DateEdit
    Friend WithEvents txtDimension1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtDimension2 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtDimension3 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtDimension4 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtDimension8 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtDimension5 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtTotalDoorsVat As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cboEMP As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents cboFora1 As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents cboFora2 As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents cboFora3 As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents cboFora4 As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents cboFora5 As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents cboFora6 As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents cboKasa1 As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents cboKasa2 As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents cboKasa3 As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents cboKasa4 As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents cboKasa5 As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents cboKasa6 As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents txtDescription As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents txtComments As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents txtKnobs1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtTotalDoorsPrice As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtNotes As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents cboTRANSH As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents txtExtraInst As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtPartofVat As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cboType1 As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents cboType2 As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents cboType3 As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents cboType4 As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents cboType5 As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents cboType6 As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents cboValueListItem As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents cboVALUELISTITEM2 As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents cboVALUELISTITEM3 As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents cboVALUELISTITEM4 As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents cboVALUELISTITEM5 As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents cboVALUELISTITEM6 As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents txtExtraTransp As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cmdConvertToOrder As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtKnobs2 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtKnobs3 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtKnobs4 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtKnobs5 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtKnobs6 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cboType7 As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents cboKasa7 As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents cboFora7 As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents cboVALUELISTITEM7 As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents txtDimension142 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtKnobs7 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cboType8 As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents cboKasa8 As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents cboFora8 As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents cboVALUELISTITEM8 As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents txtDimension141 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtKnobs8 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cboType9 As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents cboKasa9 As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents cboFora9 As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents cboVALUELISTITEM9 As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents txtDimension9 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtKnobs9 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cboType10 As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents cboKasa10 As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents cboFora10 As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents cboVALUELISTITEM10 As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents txtDimension10 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtKnobs10 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtInitialPrice1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtDisc1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtDiscount1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtFinalPrice1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtInitialPrice2 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtDisc2 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtDiscount2 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtFinalPrice2 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtInitialPrice3 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtDisc3 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtDiscount3 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtFinalPrice3 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtInitialPrice4 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtDisc4 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtDiscount4 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtFinalPrice4 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtInitialPrice5 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtDisc5 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtDiscount5 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtFinalPrice5 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtInitialPrice6 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtDisc6 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtDiscount6 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtFinalPrice6 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtInitialPrice7 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtDisc7 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtDiscount7 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtFinalPrice7 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtInitialPrice8 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtDisc8 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtDiscount8 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtFinalPrice8 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtInitialPrice9 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtDisc9 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtDiscount9 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtFinalPrice9 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtInitialPrice10 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtDisc10 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtDiscount10 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtFinalPrice10 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtTotAmt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlGroup12 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlGroup11 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents Root As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LExit As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LSave As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LGroupOrderDetails1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LarProt As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LEMP As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem41 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents Ldtpresentation As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem31 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LlblDate As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LofferAccepted As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem15 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LCompProject As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LCompCollection As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LCusCollection As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LPrintOffer As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LvisibleVAT As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LGroupOrderDetails2 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem32 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem33 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem39 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlGroup9 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents TabbedControlGroup1 As DevExpress.XtraLayout.TabbedControlGroup
    Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem12 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem56 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem24 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem58 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem18 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem37 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem105 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents Lcost3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem106 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem107 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlGroup3 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem57 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem25 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem22 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem23 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem13 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem108 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents Lcost1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem109 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem110 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlGroup5 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem59 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem49 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem63 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem26 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem21 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem111 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents Lcost2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem112 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem113 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlGroup6 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem60 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem50 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem64 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem27 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem67 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem114 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents Lcost4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem115 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem116 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlGroup7 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem61 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem51 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem10 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem65 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem29 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem68 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem117 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents Lcost5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem118 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem119 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlGroup8 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem62 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem52 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem11 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem66 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem28 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem71 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem120 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents Lcost6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem121 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem122 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutRootGroupForRestore As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem81 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem82 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem83 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem84 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem87 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem88 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem123 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents Lcost7 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem124 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem125 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlGroup13 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem73 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem74 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem75 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem76 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem79 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem80 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem126 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents Lcost8 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem127 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem128 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlGroup15 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem89 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem90 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem91 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem92 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem95 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem96 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem129 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents Lcost9 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem130 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem131 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlGroup17 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem97 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem98 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem99 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem100 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem103 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem104 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem132 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents Lcost10 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem133 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem134 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LCost As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LTotalDoorsPrice As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LExtraInst As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LExtraTransp As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LPartofVat As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LTotalDoorsVat As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem3 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem4 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LConvertToOrder As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem14 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LTotAmt As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LOrder As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LPrivateAgreement As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LNewRecord As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents chkGenOffer As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents LGenOffer As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents txtFiles As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents LayoutControlItem78 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents cboTanshFCategory As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LayoutControlItem85 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents cmdSaveTransF As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem86 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem6 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents VwSCANFILENAMESBindingSource As BindingSource
    Friend WithEvents XtraOpenFileDialog1 As DevExpress.XtraEditors.XtraOpenFileDialog
    Friend WithEvents LblMsg As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents VwFILECATBindingSource As BindingSource
    Friend WithEvents Vw_FILE_CATTableAdapter As DreamyKitchenDataSetTableAdapters.vw_FILE_CATTableAdapter
End Class
