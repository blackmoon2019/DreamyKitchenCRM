﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmTransactions
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTransactions))
        Dim EditorButtonImageOptions1 As DevExpress.XtraEditors.Controls.EditorButtonImageOptions = New DevExpress.XtraEditors.Controls.EditorButtonImageOptions()
        Dim SerializableAppearanceObject1 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject2 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject3 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject4 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim PushTransition1 As DevExpress.Utils.Animation.PushTransition = New DevExpress.Utils.Animation.PushTransition()
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.TabPane1 = New DevExpress.XtraBars.Navigation.TabPane()
        Me.TabNavigationPage1 = New DevExpress.XtraBars.Navigation.TabNavigationPage()
        Me.LayoutControl2 = New DevExpress.XtraLayout.LayoutControl()
        Me.cmdPrintCompOffer = New DevExpress.XtraEditors.SimpleButton()
        Me.LayoutControl7 = New DevExpress.XtraLayout.LayoutControl()
        Me.chkcompProject = New DevExpress.XtraEditors.CheckEdit()
        Me.cboCompany = New DevExpress.XtraEditors.LookUpEdit()
        Me.VwCOMPBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DM_CCT = New DreamyKitchenCRM.DM_CCT()
        Me.chkreceiveDateAgreement = New DevExpress.XtraEditors.CheckEdit()
        Me.chkwaitingForAgreement = New DevExpress.XtraEditors.CheckEdit()
        Me.chkofferCusAcceptance = New DevExpress.XtraEditors.CheckEdit()
        Me.cboTransC = New DevExpress.XtraEditors.CheckedComboBoxEdit()
        Me.VwTRANSHCBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DM_TRANS = New DreamyKitchenCRM.DM_TRANS()
        Me.txtCodeH = New DevExpress.XtraEditors.TextEdit()
        Me.cboSaler = New DevExpress.XtraEditors.LookUpEdit()
        Me.cboCOU = New DevExpress.XtraEditors.LookUpEdit()
        Me.cboAREAS = New DevExpress.XtraEditors.LookUpEdit()
        Me.cboADR = New DevExpress.XtraEditors.LookUpEdit()
        Me.MemoEdit12 = New DevExpress.XtraEditors.TextEdit()
        Me.cboCompProject = New DevExpress.XtraEditors.LookUpEdit()
        Me.cboCUS = New DevExpress.XtraEditors.LookUpEdit()
        Me.dtCharge = New DevExpress.XtraEditors.DateEdit()
        Me.DateEdit1 = New DevExpress.XtraEditors.DateEdit()
        Me.dtreceiveDateAgreement = New DevExpress.XtraEditors.DateEdit()
        Me.txtComments = New DevExpress.XtraEditors.MemoEdit()
        Me.LayoutControlGroup8 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem20 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem32 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem33 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LComp = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LCompProject = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LCUS = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem38 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem40 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem44 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem55 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem6 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem54 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem19 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem34 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem14 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem35 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem56 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.TabPane2 = New DevExpress.XtraBars.Navigation.TabPane()
        Me.TabNavigationPage5 = New DevExpress.XtraBars.Navigation.TabNavigationPage()
        Me.LayoutControl6 = New DevExpress.XtraLayout.LayoutControl()
        Me.cboInvoiceType = New DevExpress.XtraEditors.LookUpEdit()
        Me.VwINVTYPESBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DreamyKitchenDataSet = New DreamyKitchenCRM.DreamyKitchenDataSet()
        Me.txtDevicesCost = New DevExpress.XtraEditors.TextEdit()
        Me.txtbenchPurchasePrice = New DevExpress.XtraEditors.TextEdit()
        Me.txtbenchSalesPrice = New DevExpress.XtraEditors.TextEdit()
        Me.txtbenchProfit = New DevExpress.XtraEditors.TextEdit()
        Me.txtExtraCost = New DevExpress.XtraEditors.TextEdit()
        Me.txtTotAmt = New DevExpress.XtraEditors.TextEdit()
        Me.txtAmtH = New DevExpress.XtraEditors.TextEdit()
        Me.txtVatAmt = New DevExpress.XtraEditors.TextEdit()
        Me.LayoutControlGroup7 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem22 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem48 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem49 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem50 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem28 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem13 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem51 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem45 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem26 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.TabNavigationPage6 = New DevExpress.XtraBars.Navigation.TabNavigationPage()
        Me.GridControl4 = New DevExpress.XtraGrid.GridControl()
        Me.VwTRANSDDebitBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView4 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemBanks = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.VwBANKSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn10 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn11 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn12 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemPayTypes = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.VwPAYTYPESBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridColumn13 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn14 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn15 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemCctTransh = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.COMPCCTTRANSHBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.colcustranshid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemCusTranshID = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.VwTRANSHBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.chkCompleted = New DevExpress.XtraEditors.CheckEdit()
        Me.cmdSaveTransH = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdPrintAll = New DevExpress.XtraEditors.SimpleButton()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem25 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem5 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlGroup4 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem47 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem23 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem52 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LPrintCompOffer = New DevExpress.XtraLayout.LayoutControlItem()
        Me.TabNavigationPage2 = New DevExpress.XtraBars.Navigation.TabNavigationPage()
        Me.LayoutControl3 = New DevExpress.XtraLayout.LayoutControl()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.VwTRANSDCreditBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coltranshID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colbankID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.colBankName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colcash = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colamt = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colcmt = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coldtPay = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRealName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colmodifiedOn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colcreatedOn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPayTypeID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemLookUpEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.colpaid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coldepositor = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colcusID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemCCT = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.CCTTRANSHBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.cmdSaveTransD = New DevExpress.XtraEditors.SimpleButton()
        Me.chkCash = New DevExpress.XtraEditors.CheckEdit()
        Me.dtPay = New DevExpress.XtraEditors.DateEdit()
        Me.txtCodeD = New DevExpress.XtraEditors.TextEdit()
        Me.cboBANK = New DevExpress.XtraEditors.LookUpEdit()
        Me.MemoEdit11 = New DevExpress.XtraEditors.TextEdit()
        Me.cboPayType = New DevExpress.XtraEditors.LookUpEdit()
        Me.txtamtD = New DevExpress.XtraEditors.TextEdit()
        Me.txtCMTD = New DevExpress.XtraEditors.MemoEdit()
        Me.cboCUSD = New DevExpress.XtraEditors.LookUpEdit()
        Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem30 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem17 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem24 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem10 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem11 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.lCusD = New DevExpress.XtraLayout.LayoutControlItem()
        Me.TabNavigationPage3 = New DevExpress.XtraBars.Navigation.TabNavigationPage()
        Me.LayoutControl4 = New DevExpress.XtraLayout.LayoutControl()
        Me.cmdSaveTransF = New DevExpress.XtraEditors.SimpleButton()
        Me.GridControl2 = New DevExpress.XtraGrid.GridControl()
        Me.TRANSHFBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colID1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colcode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coltranshID1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colfilename = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colcomefrom = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colextension = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colmodifiedBy = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colmodifiedOn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colcreatedOn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colcreatedBy = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtFiles = New DevExpress.XtraEditors.ButtonEdit()
        Me.cboTanshFCategory = New DevExpress.XtraEditors.LookUpEdit()
        Me.VwFILECATBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LayoutControlGroup5 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem12 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem16 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem41 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem42 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem3 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.TabNavigationPage4 = New DevExpress.XtraBars.Navigation.TabNavigationPage()
        Me.LayoutControl5 = New DevExpress.XtraLayout.LayoutControl()
        Me.GridControl3 = New DevExpress.XtraGrid.GridControl()
        Me.VwTRANSEXTRACHARGESBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colID2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colcode1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colname = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colamt1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemAmt = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.coltranshID2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colmodifiedBy1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colmodifiedOn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colcreatedOn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colcreatedBy1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRealName1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LayoutControlGroup6 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem43 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.cmdExit = New DevExpress.XtraEditors.SimpleButton()
        Me.txtBal = New DevExpress.XtraEditors.TextEdit()
        Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem29 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem31 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem27 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem4 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.VwTRANSDBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Vw_BANKSTableAdapter = New DreamyKitchenCRM.DreamyKitchenDataSetTableAdapters.vw_BANKSTableAdapter()
        Me.XtraOpenFileDialog1 = New DevExpress.XtraEditors.XtraOpenFileDialog(Me.components)
        Me.Vw_INVTYPESTableAdapter = New DreamyKitchenCRM.DreamyKitchenDataSetTableAdapters.vw_INVTYPESTableAdapter()
        Me.VwSCANFILENAMESBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Vw_SCAN_FILE_NAMESTableAdapter = New DreamyKitchenCRM.DreamyKitchenDataSetTableAdapters.vw_SCAN_FILE_NAMESTableAdapter()
        Me.DreamyKitchenDataSet2 = New DreamyKitchenCRM.DreamyKitchenDataSet()
        Me.TRANSH_FTableAdapter = New DreamyKitchenCRM.DM_TRANSTableAdapters.TRANSH_FTableAdapter()
        Me.Vw_TRANSDTableAdapter = New DreamyKitchenCRM.DM_TRANSTableAdapters.vw_TRANSDTableAdapter()
        Me.Vw_TRANSH_CTableAdapter = New DreamyKitchenCRM.DM_TRANSTableAdapters.vw_TRANSH_CTableAdapter()
        Me.Vw_PAYTYPESTableAdapter = New DreamyKitchenCRM.DM_TRANSTableAdapters.vw_PAYTYPESTableAdapter()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar1 = New DevExpress.XtraBars.Bar()
        Me.bbEMP_T = New DevExpress.XtraBars.BarButtonItem()
        Me.BBProjectCosts = New DevExpress.XtraBars.BarButtonItem()
        Me.BBInstallations = New DevExpress.XtraBars.BarButtonItem()
        Me.BBCctOrdersKitchen = New DevExpress.XtraBars.BarButtonItem()
        Me.BBCctOrdersCloset = New DevExpress.XtraBars.BarButtonItem()
        Me.BBCctOrdersDoor = New DevExpress.XtraBars.BarButtonItem()
        Me.BBCctOrdersSC = New DevExpress.XtraBars.BarButtonItem()
        Me.BBAgreement = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.BarWorkspaceMenuItem1 = New DevExpress.XtraBars.BarWorkspaceMenuItem()
        Me.WorkspaceManager1 = New DevExpress.Utils.WorkspaceManager(Me.components)
        Me.Vw_TRANS_EXTRA_CHARGESTableAdapter = New DreamyKitchenCRM.DM_TRANSTableAdapters.vw_TRANS_EXTRA_CHARGESTableAdapter()
        Me.Vw_FILE_CATTableAdapter = New DreamyKitchenCRM.DreamyKitchenDataSetTableAdapters.vw_FILE_CATTableAdapter()
        Me.VwCCTBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Vw_CCTTableAdapter = New DreamyKitchenCRM.DreamyKitchenDataSetTableAdapters.vw_CCTTableAdapter()
        Me.CCT_TRANSHTableAdapter = New DreamyKitchenCRM.DM_TRANSTableAdapters.CCT_TRANSHTableAdapter()
        Me.Vw_COMPTableAdapter = New DreamyKitchenCRM.DM_CCTTableAdapters.vw_COMPTableAdapter()
        Me.Vw_TRANSD_CreditTableAdapter = New DreamyKitchenCRM.DM_TRANSTableAdapters.vw_TRANSD_CreditTableAdapter()
        Me.Vw_TRANSD_DebitTableAdapter = New DreamyKitchenCRM.DM_TRANSTableAdapters.vw_TRANSD_DebitTableAdapter()
        Me.COMP_CCT_TRANSHTableAdapter = New DreamyKitchenCRM.DM_TRANSTableAdapters.COMP_CCT_TRANSHTableAdapter()
        Me.BarButtonItem6 = New DevExpress.XtraBars.BarButtonItem()
        Me.Vw_TRANSHTableAdapter = New DreamyKitchenCRM.DM_TRANSTableAdapters.vw_TRANSHTableAdapter()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.TabPane1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPane1.SuspendLayout()
        Me.TabNavigationPage1.SuspendLayout()
        CType(Me.LayoutControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl2.SuspendLayout()
        CType(Me.LayoutControl7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl7.SuspendLayout()
        CType(Me.chkcompProject.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboCompany.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VwCOMPBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DM_CCT, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkreceiveDateAgreement.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkwaitingForAgreement.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkofferCusAcceptance.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboTransC.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VwTRANSHCBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DM_TRANS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodeH.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboSaler.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboCOU.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboAREAS.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboADR.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MemoEdit12.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboCompProject.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboCUS.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtCharge.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtCharge.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit1.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtreceiveDateAgreement.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtreceiveDateAgreement.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtComments.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem20, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem32, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem33, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LComp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LCompProject, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LCUS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem38, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem40, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem44, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem55, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem54, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem19, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem34, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem35, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem56, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TabPane2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPane2.SuspendLayout()
        Me.TabNavigationPage5.SuspendLayout()
        CType(Me.LayoutControl6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl6.SuspendLayout()
        CType(Me.cboInvoiceType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VwINVTYPESBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DreamyKitchenDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDevicesCost.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtbenchPurchasePrice.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtbenchSalesPrice.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtbenchProfit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtExtraCost.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTotAmt.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAmtH.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtVatAmt.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem22, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem48, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem49, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem50, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem28, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem51, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem45, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem26, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabNavigationPage6.SuspendLayout()
        CType(Me.GridControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VwTRANSDDebitBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemBanks, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VwBANKSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemPayTypes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VwPAYTYPESBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCctTransh, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.COMPCCTTRANSHBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCusTranshID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VwTRANSHBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkCompleted.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem25, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem47, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem23, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem52, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LPrintCompOffer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabNavigationPage2.SuspendLayout()
        CType(Me.LayoutControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl3.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VwTRANSDCreditBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCCT, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CCTTRANSHBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkCash.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtPay.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtPay.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodeD.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboBANK.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MemoEdit11.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboPayType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtamtD.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCMTD.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboCUSD.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem30, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem17, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem24, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lCusD, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabNavigationPage3.SuspendLayout()
        CType(Me.LayoutControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl4.SuspendLayout()
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TRANSHFBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFiles.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboTanshFCategory.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VwFILECATBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem41, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem42, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabNavigationPage4.SuspendLayout()
        CType(Me.LayoutControl5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl5.SuspendLayout()
        CType(Me.GridControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VwTRANSEXTRACHARGESBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemAmt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem43, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtBal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem29, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem31, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem27, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VwTRANSDBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VwSCANFILENAMESBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DreamyKitchenDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VwCCTBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.TabPane1)
        Me.LayoutControl1.Controls.Add(Me.cmdExit)
        Me.LayoutControl1.Controls.Add(Me.txtBal)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(50, 0)
        Me.LayoutControl1.Margin = New System.Windows.Forms.Padding(4)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(1177, 502, 650, 400)
        Me.LayoutControl1.Root = Me.Root
        Me.LayoutControl1.Size = New System.Drawing.Size(1366, 1314)
        Me.LayoutControl1.TabIndex = 0
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'TabPane1
        '
        Me.TabPane1.Controls.Add(Me.TabNavigationPage1)
        Me.TabPane1.Controls.Add(Me.TabNavigationPage2)
        Me.TabPane1.Controls.Add(Me.TabNavigationPage3)
        Me.TabPane1.Controls.Add(Me.TabNavigationPage4)
        Me.TabPane1.Location = New System.Drawing.Point(12, 12)
        Me.TabPane1.Name = "TabPane1"
        Me.TabPane1.Pages.AddRange(New DevExpress.XtraBars.Navigation.NavigationPageBase() {Me.TabNavigationPage1, Me.TabNavigationPage2, Me.TabNavigationPage4, Me.TabNavigationPage3})
        Me.TabPane1.RegularSize = New System.Drawing.Size(1342, 1254)
        Me.TabPane1.SelectedPage = Me.TabNavigationPage1
        Me.TabPane1.Size = New System.Drawing.Size(1342, 1254)
        Me.TabPane1.TabIndex = 64
        Me.TabPane1.Text = "TabPane1"
        '
        'TabNavigationPage1
        '
        Me.TabNavigationPage1.Caption = "TabNavigationPage1"
        Me.TabNavigationPage1.Controls.Add(Me.LayoutControl2)
        Me.TabNavigationPage1.Name = "TabNavigationPage1"
        Me.TabNavigationPage1.PageText = "Στοιχεία Χρέωσης"
        Me.TabNavigationPage1.Properties.AppearanceCaption.BorderColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Danger
        Me.TabNavigationPage1.Properties.AppearanceCaption.Options.UseBorderColor = True
        Me.TabNavigationPage1.Size = New System.Drawing.Size(1342, 1205)
        '
        'LayoutControl2
        '
        Me.LayoutControl2.Controls.Add(Me.cmdPrintCompOffer)
        Me.LayoutControl2.Controls.Add(Me.LayoutControl7)
        Me.LayoutControl2.Controls.Add(Me.TabPane2)
        Me.LayoutControl2.Controls.Add(Me.chkCompleted)
        Me.LayoutControl2.Controls.Add(Me.cmdSaveTransH)
        Me.LayoutControl2.Controls.Add(Me.cmdPrintAll)
        Me.LayoutControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl2.Name = "LayoutControl2"
        Me.LayoutControl2.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(1423, 692, 1137, 700)
        Me.LayoutControl2.OptionsView.DrawItemBorders = True
        Me.LayoutControl2.OptionsView.ItemBorderColor = System.Drawing.Color.Empty
        Me.LayoutControl2.Root = Me.LayoutControlGroup1
        Me.LayoutControl2.Size = New System.Drawing.Size(1342, 1205)
        Me.LayoutControl2.TabIndex = 0
        Me.LayoutControl2.Text = "LayoutControl2"
        '
        'cmdPrintCompOffer
        '
        Me.cmdPrintCompOffer.ImageOptions.Image = Global.DreamyKitchenCRM.My.Resources.Resources.icons8_print_24
        Me.cmdPrintCompOffer.Location = New System.Drawing.Point(723, 1161)
        Me.cmdPrintCompOffer.Margin = New System.Windows.Forms.Padding(15)
        Me.cmdPrintCompOffer.Name = "cmdPrintCompOffer"
        Me.cmdPrintCompOffer.Size = New System.Drawing.Size(343, 32)
        Me.cmdPrintCompOffer.StyleController = Me.LayoutControl2
        Me.cmdPrintCompOffer.TabIndex = 100
        Me.cmdPrintCompOffer.Text = "Εκτύπωση Συγκεντρωτικής Προσφοράς"
        '
        'LayoutControl7
        '
        Me.LayoutControl7.Controls.Add(Me.chkcompProject)
        Me.LayoutControl7.Controls.Add(Me.cboCompany)
        Me.LayoutControl7.Controls.Add(Me.chkreceiveDateAgreement)
        Me.LayoutControl7.Controls.Add(Me.chkwaitingForAgreement)
        Me.LayoutControl7.Controls.Add(Me.chkofferCusAcceptance)
        Me.LayoutControl7.Controls.Add(Me.cboTransC)
        Me.LayoutControl7.Controls.Add(Me.txtCodeH)
        Me.LayoutControl7.Controls.Add(Me.cboSaler)
        Me.LayoutControl7.Controls.Add(Me.cboCOU)
        Me.LayoutControl7.Controls.Add(Me.cboAREAS)
        Me.LayoutControl7.Controls.Add(Me.cboADR)
        Me.LayoutControl7.Controls.Add(Me.MemoEdit12)
        Me.LayoutControl7.Controls.Add(Me.cboCompProject)
        Me.LayoutControl7.Controls.Add(Me.cboCUS)
        Me.LayoutControl7.Controls.Add(Me.dtCharge)
        Me.LayoutControl7.Controls.Add(Me.DateEdit1)
        Me.LayoutControl7.Controls.Add(Me.dtreceiveDateAgreement)
        Me.LayoutControl7.Controls.Add(Me.txtComments)
        Me.LayoutControl7.Location = New System.Drawing.Point(12, 12)
        Me.LayoutControl7.Name = "LayoutControl7"
        Me.LayoutControl7.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(1140, 170, 1137, 700)
        Me.LayoutControl7.Root = Me.LayoutControlGroup8
        Me.LayoutControl7.Size = New System.Drawing.Size(1318, 658)
        Me.LayoutControl7.TabIndex = 99
        Me.LayoutControl7.Text = "LayoutControl7"
        '
        'chkcompProject
        '
        Me.chkcompProject.EditValue = CType(0, Byte)
        Me.chkcompProject.Location = New System.Drawing.Point(12, 196)
        Me.chkcompProject.Margin = New System.Windows.Forms.Padding(4)
        Me.chkcompProject.Name = "chkcompProject"
        Me.chkcompProject.Properties.Caption = "Γενικό Έργο"
        Me.chkcompProject.Properties.ValueChecked = CType(1, Byte)
        Me.chkcompProject.Properties.ValueUnchecked = CType(0, Byte)
        Me.chkcompProject.Size = New System.Drawing.Size(643, 27)
        Me.chkcompProject.StyleController = Me.LayoutControl7
        Me.chkcompProject.TabIndex = 102
        Me.chkcompProject.Tag = "compProject,0,1,2"
        '
        'cboCompany
        '
        Me.cboCompany.Location = New System.Drawing.Point(835, 196)
        Me.cboCompany.Margin = New System.Windows.Forms.Padding(4)
        Me.cboCompany.Name = "cboCompany"
        Me.cboCompany.Properties.AllowMouseWheel = False
        Me.cboCompany.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.cboCompany.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Search), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Clear)})
        Me.cboCompany.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 31, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("code", "code", 49, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Fullname", "Όνομα", 82, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CouID", "Cou ID", 66, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("AreaID", "Area ID", 70, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("AdrID", "Adr ID", 63, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("SourceID", "Source ID", 88, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("SalerID", "Saler ID", 75, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("DoyID", "Doy ID", 66, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("PrfID", "Prf ID", 57, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("phn", "Τηλέφωνο", 43, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("mob", "mob", 46, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("fax", "fax", 36, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("email", "email", 52, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("afm", "afm", 42, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("cmt", "cmt", 42, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("modifiedBy", "modified By", 102, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("modifiedOn", "modified On", 105, DevExpress.Utils.FormatType.DateTime, "d/M/yyyy", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("createdOn", "created On", 97, DevExpress.Utils.FormatType.DateTime, "d/M/yyyy", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("name", "name", 55, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("RealName", "Real Name", 96, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("COU_Name", "COU_Name", 99, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("SRC_Name", "SRC_Name", 97, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("AREAS_Name", "AREAS_Name", 117, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ADR_Name", "ADR_Name", 99, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("PRF_Name", "PRF_Name", 96, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("SALERS_Name", "SALERS_Name", 124, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("color", "color", 49, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Ar", "Ar", 30, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("tk", "tk", 28, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("createdby_Realname", "createdby_Realname", 172, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("HasFiles", "Has Files", 79, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("createdBy", "created By", 93, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default])})
        Me.cboCompany.Properties.DataSource = Me.VwCOMPBindingSource
        Me.cboCompany.Properties.DisplayMember = "Fullname"
        Me.cboCompany.Properties.NullText = ""
        Me.cboCompany.Properties.PopupSizeable = False
        Me.cboCompany.Properties.ValueMember = "ID"
        Me.cboCompany.Size = New System.Drawing.Size(471, 26)
        Me.cboCompany.StyleController = Me.LayoutControl7
        Me.cboCompany.TabIndex = 101
        Me.cboCompany.Tag = "compID,0,1,2"
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
        'chkreceiveDateAgreement
        '
        Me.chkreceiveDateAgreement.EditValue = CType(0, Byte)
        Me.chkreceiveDateAgreement.Location = New System.Drawing.Point(12, 347)
        Me.chkreceiveDateAgreement.Margin = New System.Windows.Forms.Padding(4)
        Me.chkreceiveDateAgreement.Name = "chkreceiveDateAgreement"
        Me.chkreceiveDateAgreement.Properties.Caption = "Παραλαβή συμφωνητικού"
        Me.chkreceiveDateAgreement.Properties.ValueChecked = CType(1, Byte)
        Me.chkreceiveDateAgreement.Properties.ValueUnchecked = CType(0, Byte)
        Me.chkreceiveDateAgreement.Size = New System.Drawing.Size(318, 27)
        Me.chkreceiveDateAgreement.StyleController = Me.LayoutControl7
        Me.chkreceiveDateAgreement.TabIndex = 100
        Me.chkreceiveDateAgreement.Tag = "receiveAgreement,0,1,2"
        '
        'chkwaitingForAgreement
        '
        Me.chkwaitingForAgreement.EditValue = CType(0, Byte)
        Me.chkwaitingForAgreement.Location = New System.Drawing.Point(334, 347)
        Me.chkwaitingForAgreement.Margin = New System.Windows.Forms.Padding(4)
        Me.chkwaitingForAgreement.Name = "chkwaitingForAgreement"
        Me.chkwaitingForAgreement.Properties.Caption = "Αναμονή συμφωνητικού"
        Me.chkwaitingForAgreement.Properties.ReadOnly = True
        Me.chkwaitingForAgreement.Properties.ValueChecked = CType(1, Byte)
        Me.chkwaitingForAgreement.Properties.ValueUnchecked = CType(0, Byte)
        Me.chkwaitingForAgreement.Size = New System.Drawing.Size(321, 27)
        Me.chkwaitingForAgreement.StyleController = Me.LayoutControl7
        Me.chkwaitingForAgreement.TabIndex = 99
        Me.chkwaitingForAgreement.Tag = "waitingForAgreement,0,1,2"
        '
        'chkofferCusAcceptance
        '
        Me.chkofferCusAcceptance.EditValue = CType(0, Byte)
        Me.chkofferCusAcceptance.Location = New System.Drawing.Point(659, 347)
        Me.chkofferCusAcceptance.Margin = New System.Windows.Forms.Padding(4)
        Me.chkofferCusAcceptance.Name = "chkofferCusAcceptance"
        Me.chkofferCusAcceptance.Properties.Caption = "Αποδοχή προσφοράς από πελάτη"
        Me.chkofferCusAcceptance.Properties.ValueChecked = CType(1, Byte)
        Me.chkofferCusAcceptance.Properties.ValueUnchecked = CType(0, Byte)
        Me.chkofferCusAcceptance.Size = New System.Drawing.Size(291, 27)
        Me.chkofferCusAcceptance.StyleController = Me.LayoutControl7
        Me.chkofferCusAcceptance.TabIndex = 98
        Me.chkofferCusAcceptance.Tag = "offerCusAcceptance,0,1,2"
        '
        'cboTransC
        '
        Me.cboTransC.EditValue = ""
        Me.cboTransC.Location = New System.Drawing.Point(188, 106)
        Me.cboTransC.Margin = New System.Windows.Forms.Padding(4)
        Me.cboTransC.Name = "cboTransC"
        Me.cboTransC.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Clear)})
        Me.cboTransC.Properties.DataSource = Me.VwTRANSHCBindingSource
        Me.cboTransC.Properties.DisplayMember = "name"
        Me.cboTransC.Properties.ValueMember = "ID"
        Me.cboTransC.Size = New System.Drawing.Size(1118, 26)
        Me.cboTransC.StyleController = Me.LayoutControl7
        Me.cboTransC.TabIndex = 18
        Me.cboTransC.Tag = ""
        '
        'VwTRANSHCBindingSource
        '
        Me.VwTRANSHCBindingSource.DataMember = "vw_TRANSH_C"
        Me.VwTRANSHCBindingSource.DataSource = Me.DM_TRANS
        '
        'DM_TRANS
        '
        Me.DM_TRANS.DataSetName = "DM_TRANS"
        Me.DM_TRANS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txtCodeH
        '
        Me.txtCodeH.Location = New System.Drawing.Point(188, 44)
        Me.txtCodeH.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCodeH.Name = "txtCodeH"
        Me.txtCodeH.Properties.Appearance.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.txtCodeH.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtCodeH.Properties.Appearance.Options.UseBackColor = True
        Me.txtCodeH.Properties.Appearance.Options.UseFont = True
        Me.txtCodeH.Properties.ReadOnly = True
        Me.txtCodeH.Size = New System.Drawing.Size(95, 28)
        Me.txtCodeH.StyleController = Me.LayoutControl7
        Me.txtCodeH.TabIndex = 4
        Me.txtCodeH.Tag = "code,0"
        '
        'cboSaler
        '
        Me.cboSaler.Location = New System.Drawing.Point(188, 76)
        Me.cboSaler.Margin = New System.Windows.Forms.Padding(4)
        Me.cboSaler.Name = "cboSaler"
        Me.cboSaler.Properties.AllowMouseWheel = False
        Me.cboSaler.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.cboSaler.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Search), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Clear)})
        Me.cboSaler.Properties.NullText = ""
        Me.cboSaler.Properties.PopupSizeable = False
        Me.cboSaler.Size = New System.Drawing.Size(1118, 26)
        Me.cboSaler.StyleController = Me.LayoutControl7
        Me.cboSaler.TabIndex = 6
        Me.cboSaler.Tag = "empID,0,1,2"
        '
        'cboCOU
        '
        Me.cboCOU.Location = New System.Drawing.Point(188, 136)
        Me.cboCOU.Margin = New System.Windows.Forms.Padding(4)
        Me.cboCOU.Name = "cboCOU"
        Me.cboCOU.Properties.AllowMouseWheel = False
        Me.cboCOU.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.cboCOU.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Search), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Clear)})
        Me.cboCOU.Properties.NullText = ""
        Me.cboCOU.Properties.PopupSizeable = False
        Me.cboCOU.Size = New System.Drawing.Size(1118, 26)
        Me.cboCOU.StyleController = Me.LayoutControl7
        Me.cboCOU.TabIndex = 5
        Me.cboCOU.Tag = "couid,0,1,2"
        '
        'cboAREAS
        '
        Me.cboAREAS.Location = New System.Drawing.Point(188, 166)
        Me.cboAREAS.Margin = New System.Windows.Forms.Padding(4)
        Me.cboAREAS.Name = "cboAREAS"
        Me.cboAREAS.Properties.AllowMouseWheel = False
        Me.cboAREAS.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.cboAREAS.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Search), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Clear)})
        Me.cboAREAS.Properties.NullText = ""
        Me.cboAREAS.Properties.PopupSizeable = False
        Me.cboAREAS.Size = New System.Drawing.Size(467, 26)
        Me.cboAREAS.StyleController = Me.LayoutControl7
        Me.cboAREAS.TabIndex = 6
        Me.cboAREAS.Tag = "AreaId,0,1,2"
        '
        'cboADR
        '
        Me.cboADR.Location = New System.Drawing.Point(835, 166)
        Me.cboADR.Margin = New System.Windows.Forms.Padding(4)
        Me.cboADR.Name = "cboADR"
        Me.cboADR.Properties.AllowMouseWheel = False
        Me.cboADR.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.cboADR.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Search), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Clear)})
        Me.cboADR.Properties.NullText = ""
        Me.cboADR.Properties.PopupSizeable = False
        Me.cboADR.Size = New System.Drawing.Size(471, 26)
        Me.cboADR.StyleController = Me.LayoutControl7
        Me.cboADR.TabIndex = 7
        Me.cboADR.Tag = "adrid,0,1,2"
        '
        'MemoEdit12
        '
        Me.MemoEdit12.Location = New System.Drawing.Point(188, 287)
        Me.MemoEdit12.Margin = New System.Windows.Forms.Padding(4)
        Me.MemoEdit12.Name = "MemoEdit12"
        Me.MemoEdit12.Size = New System.Drawing.Size(1118, 26)
        Me.MemoEdit12.StyleController = Me.LayoutControl7
        Me.MemoEdit12.TabIndex = 63
        Me.MemoEdit12.Tag = "description,0,1,2"
        '
        'cboCompProject
        '
        Me.cboCompProject.Location = New System.Drawing.Point(188, 227)
        Me.cboCompProject.Margin = New System.Windows.Forms.Padding(4)
        Me.cboCompProject.Name = "cboCompProject"
        Me.cboCompProject.Properties.AllowMouseWheel = False
        Me.cboCompProject.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.cboCompProject.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Search), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Clear)})
        Me.cboCompProject.Properties.DisplayMember = "description"
        Me.cboCompProject.Properties.NullText = ""
        Me.cboCompProject.Properties.PopupSizeable = False
        Me.cboCompProject.Properties.ValueMember = "ID"
        Me.cboCompProject.Size = New System.Drawing.Size(1118, 26)
        Me.cboCompProject.StyleController = Me.LayoutControl7
        Me.cboCompProject.TabIndex = 97
        Me.cboCompProject.Tag = "compTrashID,0,1,2"
        '
        'cboCUS
        '
        Me.cboCUS.Location = New System.Drawing.Point(188, 257)
        Me.cboCUS.Margin = New System.Windows.Forms.Padding(4)
        Me.cboCUS.Name = "cboCUS"
        Me.cboCUS.Properties.AllowMouseWheel = False
        Me.cboCUS.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.cboCUS.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Search), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Clear)})
        Me.cboCUS.Properties.NullText = ""
        Me.cboCUS.Properties.PopupSizeable = False
        Me.cboCUS.Size = New System.Drawing.Size(1118, 26)
        Me.cboCUS.StyleController = Me.LayoutControl7
        Me.cboCUS.TabIndex = 6
        Me.cboCUS.Tag = "cusID,0,1,2"
        '
        'dtCharge
        '
        Me.dtCharge.EditValue = Nothing
        Me.dtCharge.Location = New System.Drawing.Point(188, 317)
        Me.dtCharge.Margin = New System.Windows.Forms.Padding(4)
        Me.dtCharge.Name = "dtCharge"
        Me.dtCharge.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtCharge.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtCharge.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.dtCharge.Size = New System.Drawing.Size(467, 26)
        Me.dtCharge.StyleController = Me.LayoutControl7
        Me.dtCharge.TabIndex = 32
        Me.dtCharge.Tag = "dtCharge,0,1,2"
        '
        'DateEdit1
        '
        Me.DateEdit1.EditValue = Nothing
        Me.DateEdit1.Location = New System.Drawing.Point(835, 317)
        Me.DateEdit1.Margin = New System.Windows.Forms.Padding(4)
        Me.DateEdit1.Name = "DateEdit1"
        Me.DateEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEdit1.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEdit1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.DateEdit1.Size = New System.Drawing.Size(471, 26)
        Me.DateEdit1.StyleController = Me.LayoutControl7
        Me.DateEdit1.TabIndex = 32
        Me.DateEdit1.Tag = "dtAgreement,0,1,2"
        '
        'dtreceiveDateAgreement
        '
        Me.dtreceiveDateAgreement.EditValue = Nothing
        Me.dtreceiveDateAgreement.Location = New System.Drawing.Point(1130, 347)
        Me.dtreceiveDateAgreement.Margin = New System.Windows.Forms.Padding(4)
        Me.dtreceiveDateAgreement.Name = "dtreceiveDateAgreement"
        Me.dtreceiveDateAgreement.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtreceiveDateAgreement.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtreceiveDateAgreement.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.dtreceiveDateAgreement.Size = New System.Drawing.Size(176, 26)
        Me.dtreceiveDateAgreement.StyleController = Me.LayoutControl7
        Me.dtreceiveDateAgreement.TabIndex = 32
        Me.dtreceiveDateAgreement.Tag = "receiveDateAgreement,0,1,2"
        '
        'txtComments
        '
        Me.txtComments.Location = New System.Drawing.Point(188, 378)
        Me.txtComments.Margin = New System.Windows.Forms.Padding(4)
        Me.txtComments.Name = "txtComments"
        Me.txtComments.Size = New System.Drawing.Size(1118, 268)
        Me.txtComments.StyleController = Me.LayoutControl7
        Me.txtComments.TabIndex = 17
        Me.txtComments.Tag = "cmt,0,1,2"
        '
        'LayoutControlGroup8
        '
        Me.LayoutControlGroup8.AppearanceGroup.BorderColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Question
        Me.LayoutControlGroup8.AppearanceGroup.Options.UseBorderColor = True
        Me.LayoutControlGroup8.CustomizationFormText = "Γενικά Στοιχεία Έργου"
        Me.LayoutControlGroup8.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem20, Me.LayoutControlItem32, Me.LayoutControlItem33, Me.LComp, Me.LCompProject, Me.LCUS, Me.LayoutControlItem2, Me.LayoutControlItem4, Me.LayoutControlItem38, Me.LayoutControlItem40, Me.LayoutControlItem44, Me.LayoutControlItem55, Me.EmptySpaceItem6, Me.LayoutControlItem54, Me.LayoutControlItem19, Me.LayoutControlItem34, Me.LayoutControlItem14, Me.LayoutControlItem35, Me.LayoutControlItem56})
        Me.LayoutControlGroup8.Name = "Root"
        Me.LayoutControlGroup8.Size = New System.Drawing.Size(1318, 658)
        Me.LayoutControlGroup8.Text = "Γενικά Στοιχεία Έργου"
        '
        'LayoutControlItem20
        '
        Me.LayoutControlItem20.Control = Me.cboSaler
        Me.LayoutControlItem20.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem20.CustomizationFormText = "Περιοχή"
        Me.LayoutControlItem20.HighlightFocusedItem = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlItem20.ImageOptions.Image = CType(resources.GetObject("LayoutControlItem20.ImageOptions.Image"), System.Drawing.Image)
        Me.LayoutControlItem20.Location = New System.Drawing.Point(0, 32)
        Me.LayoutControlItem20.Name = "LayoutControlItem20"
        Me.LayoutControlItem20.Size = New System.Drawing.Size(1298, 30)
        Me.LayoutControlItem20.Text = "Πωλητής"
        Me.LayoutControlItem20.TextSize = New System.Drawing.Size(164, 19)
        '
        'LayoutControlItem32
        '
        Me.LayoutControlItem32.Control = Me.cboCOU
        Me.LayoutControlItem32.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem32.CustomizationFormText = "Νομός"
        Me.LayoutControlItem32.HighlightFocusedItem = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlItem32.ImageOptions.Image = CType(resources.GetObject("LayoutControlItem32.ImageOptions.Image"), System.Drawing.Image)
        Me.LayoutControlItem32.Location = New System.Drawing.Point(0, 92)
        Me.LayoutControlItem32.Name = "LayoutControlItem32"
        Me.LayoutControlItem32.Size = New System.Drawing.Size(1298, 30)
        Me.LayoutControlItem32.Text = "Νομός"
        Me.LayoutControlItem32.TextSize = New System.Drawing.Size(164, 19)
        '
        'LayoutControlItem33
        '
        Me.LayoutControlItem33.Control = Me.cboAREAS
        Me.LayoutControlItem33.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem33.CustomizationFormText = "Περιοχή"
        Me.LayoutControlItem33.HighlightFocusedItem = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlItem33.ImageOptions.Image = CType(resources.GetObject("LayoutControlItem33.ImageOptions.Image"), System.Drawing.Image)
        Me.LayoutControlItem33.Location = New System.Drawing.Point(0, 122)
        Me.LayoutControlItem33.Name = "LayoutControlItem33"
        Me.LayoutControlItem33.Size = New System.Drawing.Size(647, 30)
        Me.LayoutControlItem33.Text = "Περιοχή"
        Me.LayoutControlItem33.TextSize = New System.Drawing.Size(164, 19)
        '
        'LComp
        '
        Me.LComp.Control = Me.cboCompany
        Me.LComp.Location = New System.Drawing.Point(647, 152)
        Me.LComp.Name = "LComp"
        Me.LComp.Size = New System.Drawing.Size(651, 31)
        Me.LComp.Text = "Εταιρία"
        Me.LComp.TextSize = New System.Drawing.Size(164, 19)
        '
        'LCompProject
        '
        Me.LCompProject.Control = Me.cboCompProject
        Me.LCompProject.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LCompProject.CustomizationFormText = "Έργο Εταιρίας"
        Me.LCompProject.Location = New System.Drawing.Point(0, 183)
        Me.LCompProject.Name = "LCompProject"
        Me.LCompProject.Size = New System.Drawing.Size(1298, 30)
        Me.LCompProject.Text = "Έργο Εταιρίας"
        Me.LCompProject.TextSize = New System.Drawing.Size(164, 19)
        '
        'LCUS
        '
        Me.LCUS.Control = Me.cboCUS
        Me.LCUS.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LCUS.CustomizationFormText = "Περιοχή"
        Me.LCUS.HighlightFocusedItem = DevExpress.Utils.DefaultBoolean.[True]
        Me.LCUS.ImageOptions.Image = CType(resources.GetObject("LCUS.ImageOptions.Image"), System.Drawing.Image)
        Me.LCUS.Location = New System.Drawing.Point(0, 213)
        Me.LCUS.Name = "LCUS"
        Me.LCUS.Size = New System.Drawing.Size(1298, 30)
        Me.LCUS.Text = "Πελάτης"
        Me.LCUS.TextSize = New System.Drawing.Size(164, 19)
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.dtCharge
        Me.LayoutControlItem2.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem2.CustomizationFormText = "Ημερ/νία Ολοκλήρωσης"
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 273)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(647, 30)
        Me.LayoutControlItem2.Text = "Ημερ/νία "
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(164, 19)
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.txtCodeH
        Me.LayoutControlItem4.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem4.CustomizationFormText = "Κωδικός"
        Me.LayoutControlItem4.HighlightFocusedItem = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(275, 32)
        Me.LayoutControlItem4.Text = "Κωδικός"
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(164, 19)
        '
        'LayoutControlItem38
        '
        Me.LayoutControlItem38.Control = Me.chkreceiveDateAgreement
        Me.LayoutControlItem38.Location = New System.Drawing.Point(0, 303)
        Me.LayoutControlItem38.Name = "LayoutControlItem38"
        Me.LayoutControlItem38.Size = New System.Drawing.Size(322, 31)
        Me.LayoutControlItem38.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem38.TextVisible = False
        '
        'LayoutControlItem40
        '
        Me.LayoutControlItem40.Control = Me.chkwaitingForAgreement
        Me.LayoutControlItem40.Location = New System.Drawing.Point(322, 303)
        Me.LayoutControlItem40.Name = "LayoutControlItem40"
        Me.LayoutControlItem40.Size = New System.Drawing.Size(325, 31)
        Me.LayoutControlItem40.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem40.TextVisible = False
        '
        'LayoutControlItem44
        '
        Me.LayoutControlItem44.Control = Me.chkofferCusAcceptance
        Me.LayoutControlItem44.Location = New System.Drawing.Point(647, 303)
        Me.LayoutControlItem44.Name = "LayoutControlItem44"
        Me.LayoutControlItem44.Size = New System.Drawing.Size(295, 31)
        Me.LayoutControlItem44.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem44.TextVisible = False
        '
        'LayoutControlItem55
        '
        Me.LayoutControlItem55.Control = Me.dtreceiveDateAgreement
        Me.LayoutControlItem55.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem55.CustomizationFormText = "Ημερ/νία Ολοκλήρωσης"
        Me.LayoutControlItem55.Location = New System.Drawing.Point(942, 303)
        Me.LayoutControlItem55.Name = "LayoutControlItem55"
        Me.LayoutControlItem55.Size = New System.Drawing.Size(356, 31)
        Me.LayoutControlItem55.Text = "Ημερ/νία  Παραλαβής"
        Me.LayoutControlItem55.TextSize = New System.Drawing.Size(164, 19)
        '
        'EmptySpaceItem6
        '
        Me.EmptySpaceItem6.AllowHotTrack = False
        Me.EmptySpaceItem6.Location = New System.Drawing.Point(275, 0)
        Me.EmptySpaceItem6.Name = "EmptySpaceItem6"
        Me.EmptySpaceItem6.Size = New System.Drawing.Size(1023, 32)
        Me.EmptySpaceItem6.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem54
        '
        Me.LayoutControlItem54.Control = Me.DateEdit1
        Me.LayoutControlItem54.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem54.CustomizationFormText = "Ημερ/νία Ολοκλήρωσης"
        Me.LayoutControlItem54.ImageOptions.Image = CType(resources.GetObject("LayoutControlItem54.ImageOptions.Image"), System.Drawing.Image)
        Me.LayoutControlItem54.Location = New System.Drawing.Point(647, 273)
        Me.LayoutControlItem54.Name = "LayoutControlItem54"
        Me.LayoutControlItem54.Size = New System.Drawing.Size(651, 30)
        Me.LayoutControlItem54.Text = "Ημερ/νία  Συμφωνίας"
        Me.LayoutControlItem54.TextSize = New System.Drawing.Size(164, 19)
        '
        'LayoutControlItem19
        '
        Me.LayoutControlItem19.Control = Me.cboTransC
        Me.LayoutControlItem19.ImageOptions.Image = Global.DreamyKitchenCRM.My.Resources.Resources.rsz_11rsz_asterisk
        Me.LayoutControlItem19.Location = New System.Drawing.Point(0, 62)
        Me.LayoutControlItem19.Name = "LayoutControlItem19"
        Me.LayoutControlItem19.Size = New System.Drawing.Size(1298, 30)
        Me.LayoutControlItem19.Tag = "1"
        Me.LayoutControlItem19.Text = "Κατηγορία Έργου"
        Me.LayoutControlItem19.TextSize = New System.Drawing.Size(164, 19)
        '
        'LayoutControlItem34
        '
        Me.LayoutControlItem34.Control = Me.cboADR
        Me.LayoutControlItem34.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem34.CustomizationFormText = "Διεύθυνση"
        Me.LayoutControlItem34.HighlightFocusedItem = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlItem34.ImageOptions.Image = CType(resources.GetObject("LayoutControlItem34.ImageOptions.Image"), System.Drawing.Image)
        Me.LayoutControlItem34.Location = New System.Drawing.Point(647, 122)
        Me.LayoutControlItem34.Name = "LayoutControlItem34"
        Me.LayoutControlItem34.Size = New System.Drawing.Size(651, 30)
        Me.LayoutControlItem34.Text = "Διεύθυνση"
        Me.LayoutControlItem34.TextSize = New System.Drawing.Size(164, 19)
        '
        'LayoutControlItem14
        '
        Me.LayoutControlItem14.Control = Me.txtComments
        Me.LayoutControlItem14.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem14.CustomizationFormText = "Σχόλια"
        Me.LayoutControlItem14.HighlightFocusedItem = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlItem14.Location = New System.Drawing.Point(0, 334)
        Me.LayoutControlItem14.MinSize = New System.Drawing.Size(190, 180)
        Me.LayoutControlItem14.Name = "LayoutControlItem14"
        Me.LayoutControlItem14.Size = New System.Drawing.Size(1298, 272)
        Me.LayoutControlItem14.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem14.Text = "Σχόλια"
        Me.LayoutControlItem14.TextSize = New System.Drawing.Size(164, 19)
        '
        'LayoutControlItem35
        '
        Me.LayoutControlItem35.Control = Me.MemoEdit12
        Me.LayoutControlItem35.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem35.CustomizationFormText = "Περιγραφή"
        Me.LayoutControlItem35.Location = New System.Drawing.Point(0, 243)
        Me.LayoutControlItem35.Name = "LayoutControlItem35"
        Me.LayoutControlItem35.Size = New System.Drawing.Size(1298, 30)
        Me.LayoutControlItem35.Text = "Περιγραφή"
        Me.LayoutControlItem35.TextSize = New System.Drawing.Size(164, 19)
        '
        'LayoutControlItem56
        '
        Me.LayoutControlItem56.Control = Me.chkcompProject
        Me.LayoutControlItem56.Location = New System.Drawing.Point(0, 152)
        Me.LayoutControlItem56.Name = "LayoutControlItem56"
        Me.LayoutControlItem56.Size = New System.Drawing.Size(647, 31)
        Me.LayoutControlItem56.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem56.TextVisible = False
        '
        'TabPane2
        '
        Me.TabPane2.Controls.Add(Me.TabNavigationPage5)
        Me.TabPane2.Controls.Add(Me.TabNavigationPage6)
        Me.TabPane2.Location = New System.Drawing.Point(24, 718)
        Me.TabPane2.Name = "TabPane2"
        Me.TabPane2.Pages.AddRange(New DevExpress.XtraBars.Navigation.NavigationPageBase() {Me.TabNavigationPage5, Me.TabNavigationPage6})
        Me.TabPane2.RegularSize = New System.Drawing.Size(1294, 427)
        Me.TabPane2.SelectedPage = Me.TabNavigationPage5
        Me.TabPane2.Size = New System.Drawing.Size(1294, 427)
        Me.TabPane2.TabIndex = 98
        Me.TabPane2.Text = "TabPane2"
        '
        'TabNavigationPage5
        '
        Me.TabNavigationPage5.Caption = "TabNavigationPage5"
        Me.TabNavigationPage5.Controls.Add(Me.LayoutControl6)
        Me.TabNavigationPage5.Name = "TabNavigationPage5"
        Me.TabNavigationPage5.PageText = "Γενικά Στοιχεία"
        Me.TabNavigationPage5.Size = New System.Drawing.Size(1294, 378)
        '
        'LayoutControl6
        '
        Me.LayoutControl6.Controls.Add(Me.cboInvoiceType)
        Me.LayoutControl6.Controls.Add(Me.txtDevicesCost)
        Me.LayoutControl6.Controls.Add(Me.txtbenchPurchasePrice)
        Me.LayoutControl6.Controls.Add(Me.txtbenchSalesPrice)
        Me.LayoutControl6.Controls.Add(Me.txtbenchProfit)
        Me.LayoutControl6.Controls.Add(Me.txtExtraCost)
        Me.LayoutControl6.Controls.Add(Me.txtTotAmt)
        Me.LayoutControl6.Controls.Add(Me.txtAmtH)
        Me.LayoutControl6.Controls.Add(Me.txtVatAmt)
        Me.LayoutControl6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl6.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl6.Name = "LayoutControl6"
        Me.LayoutControl6.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(1663, 880, 1137, 700)
        Me.LayoutControl6.Root = Me.LayoutControlGroup7
        Me.LayoutControl6.Size = New System.Drawing.Size(1294, 378)
        Me.LayoutControl6.TabIndex = 0
        Me.LayoutControl6.Text = "LayoutControl6"
        '
        'cboInvoiceType
        '
        Me.cboInvoiceType.Location = New System.Drawing.Point(228, 132)
        Me.cboInvoiceType.Margin = New System.Windows.Forms.Padding(4)
        Me.cboInvoiceType.Name = "cboInvoiceType"
        Me.cboInvoiceType.Properties.AllowMouseWheel = False
        Me.cboInvoiceType.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboInvoiceType.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("invType", "inv Type", 75, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("invTypeDescr", "ΤΥΠΟΣ ΠΑΡΑΣΤΑΤΙΚΟΥ", 120, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default])})
        Me.cboInvoiceType.Properties.DataSource = Me.VwINVTYPESBindingSource
        Me.cboInvoiceType.Properties.DisplayMember = "invTypeDescr"
        Me.cboInvoiceType.Properties.NullText = ""
        Me.cboInvoiceType.Properties.PopupSizeable = False
        Me.cboInvoiceType.Properties.ValueMember = "invType"
        Me.cboInvoiceType.Size = New System.Drawing.Size(1054, 26)
        Me.cboInvoiceType.StyleController = Me.LayoutControl6
        Me.cboInvoiceType.TabIndex = 48
        Me.cboInvoiceType.Tag = "invType,0,1,2"
        '
        'VwINVTYPESBindingSource
        '
        Me.VwINVTYPESBindingSource.DataMember = "vw_INVTYPES"
        Me.VwINVTYPESBindingSource.DataSource = Me.DreamyKitchenDataSet
        '
        'DreamyKitchenDataSet
        '
        Me.DreamyKitchenDataSet.DataSetName = "DreamyKitchenDataSet"
        Me.DreamyKitchenDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txtDevicesCost
        '
        Me.txtDevicesCost.EditValue = "0,00 €"
        Me.txtDevicesCost.Location = New System.Drawing.Point(228, 12)
        Me.txtDevicesCost.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDevicesCost.Name = "txtDevicesCost"
        Me.txtDevicesCost.Properties.DisplayFormat.FormatString = "c"
        Me.txtDevicesCost.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtDevicesCost.Properties.EditFormat.FormatString = "n2"
        Me.txtDevicesCost.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtDevicesCost.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtDevicesCost.Properties.MaskSettings.Set("MaskManagerType", GetType(DevExpress.Data.Mask.NumericMaskManager))
        Me.txtDevicesCost.Properties.MaskSettings.Set("mask", "c2")
        Me.txtDevicesCost.Properties.ReadOnly = True
        Me.txtDevicesCost.Properties.Tag = "BenchExtraPrice"
        Me.txtDevicesCost.Size = New System.Drawing.Size(1054, 26)
        Me.txtDevicesCost.StyleController = Me.LayoutControl6
        Me.txtDevicesCost.TabIndex = 42
        Me.txtDevicesCost.Tag = "DevicesCost,0,1,2"
        Me.txtDevicesCost.Visible = False
        '
        'txtbenchPurchasePrice
        '
        Me.txtbenchPurchasePrice.EditValue = "0,00 €"
        Me.txtbenchPurchasePrice.Location = New System.Drawing.Point(228, 42)
        Me.txtbenchPurchasePrice.Margin = New System.Windows.Forms.Padding(4)
        Me.txtbenchPurchasePrice.Name = "txtbenchPurchasePrice"
        Me.txtbenchPurchasePrice.Properties.DisplayFormat.FormatString = "c"
        Me.txtbenchPurchasePrice.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtbenchPurchasePrice.Properties.EditFormat.FormatString = "n2"
        Me.txtbenchPurchasePrice.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtbenchPurchasePrice.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtbenchPurchasePrice.Properties.MaskSettings.Set("MaskManagerType", GetType(DevExpress.Data.Mask.NumericMaskManager))
        Me.txtbenchPurchasePrice.Properties.MaskSettings.Set("mask", "c2")
        Me.txtbenchPurchasePrice.Properties.Tag = "BenchExtraPrice"
        Me.txtbenchPurchasePrice.Size = New System.Drawing.Size(134, 26)
        Me.txtbenchPurchasePrice.StyleController = Me.LayoutControl6
        Me.txtbenchPurchasePrice.TabIndex = 42
        Me.txtbenchPurchasePrice.Tag = "benchPurchasePrice,0,1,2"
        Me.txtbenchPurchasePrice.Visible = False
        '
        'txtbenchSalesPrice
        '
        Me.txtbenchSalesPrice.EditValue = "0,00 €"
        Me.txtbenchSalesPrice.Location = New System.Drawing.Point(582, 42)
        Me.txtbenchSalesPrice.Margin = New System.Windows.Forms.Padding(4)
        Me.txtbenchSalesPrice.Name = "txtbenchSalesPrice"
        Me.txtbenchSalesPrice.Properties.DisplayFormat.FormatString = "c"
        Me.txtbenchSalesPrice.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtbenchSalesPrice.Properties.EditFormat.FormatString = "n2"
        Me.txtbenchSalesPrice.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtbenchSalesPrice.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtbenchSalesPrice.Properties.MaskSettings.Set("MaskManagerType", GetType(DevExpress.Data.Mask.NumericMaskManager))
        Me.txtbenchSalesPrice.Properties.MaskSettings.Set("mask", "c2")
        Me.txtbenchSalesPrice.Properties.Tag = "BenchExtraPrice"
        Me.txtbenchSalesPrice.Size = New System.Drawing.Size(171, 26)
        Me.txtbenchSalesPrice.StyleController = Me.LayoutControl6
        Me.txtbenchSalesPrice.TabIndex = 42
        Me.txtbenchSalesPrice.Tag = "benchSalesPrice,0,1,2"
        Me.txtbenchSalesPrice.Visible = False
        '
        'txtbenchProfit
        '
        Me.txtbenchProfit.EditValue = "0,00 €"
        Me.txtbenchProfit.Location = New System.Drawing.Point(973, 42)
        Me.txtbenchProfit.Margin = New System.Windows.Forms.Padding(4)
        Me.txtbenchProfit.Name = "txtbenchProfit"
        Me.txtbenchProfit.Properties.DisplayFormat.FormatString = "c"
        Me.txtbenchProfit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtbenchProfit.Properties.EditFormat.FormatString = "n2"
        Me.txtbenchProfit.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtbenchProfit.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtbenchProfit.Properties.MaskSettings.Set("MaskManagerType", GetType(DevExpress.Data.Mask.NumericMaskManager))
        Me.txtbenchProfit.Properties.MaskSettings.Set("mask", "c2")
        Me.txtbenchProfit.Properties.Tag = "BenchExtraPrice"
        Me.txtbenchProfit.Size = New System.Drawing.Size(309, 26)
        Me.txtbenchProfit.StyleController = Me.LayoutControl6
        Me.txtbenchProfit.TabIndex = 42
        Me.txtbenchProfit.Tag = "benchProfit,0,1,2"
        Me.txtbenchProfit.Visible = False
        '
        'txtExtraCost
        '
        Me.txtExtraCost.EditValue = "0,00 €"
        Me.txtExtraCost.Location = New System.Drawing.Point(228, 72)
        Me.txtExtraCost.Margin = New System.Windows.Forms.Padding(4)
        Me.txtExtraCost.Name = "txtExtraCost"
        Me.txtExtraCost.Properties.DisplayFormat.FormatString = "c"
        Me.txtExtraCost.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtExtraCost.Properties.EditFormat.FormatString = "n2"
        Me.txtExtraCost.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtExtraCost.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtExtraCost.Properties.MaskSettings.Set("MaskManagerType", GetType(DevExpress.Data.Mask.NumericMaskManager))
        Me.txtExtraCost.Properties.MaskSettings.Set("mask", "c2")
        Me.txtExtraCost.Properties.ReadOnly = True
        Me.txtExtraCost.Properties.Tag = "BenchExtraPrice"
        Me.txtExtraCost.Properties.UseReadOnlyAppearance = False
        Me.txtExtraCost.Size = New System.Drawing.Size(1054, 26)
        Me.txtExtraCost.StyleController = Me.LayoutControl6
        Me.txtExtraCost.TabIndex = 42
        Me.txtExtraCost.Tag = "extracost,0,1,2"
        Me.txtExtraCost.Visible = False
        '
        'txtTotAmt
        '
        Me.txtTotAmt.EditValue = "0,00 €"
        Me.txtTotAmt.Location = New System.Drawing.Point(228, 102)
        Me.txtTotAmt.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTotAmt.Name = "txtTotAmt"
        Me.txtTotAmt.Properties.Appearance.BackColor = System.Drawing.Color.Moccasin
        Me.txtTotAmt.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.142858!, System.Drawing.FontStyle.Bold)
        Me.txtTotAmt.Properties.Appearance.Options.UseBackColor = True
        Me.txtTotAmt.Properties.Appearance.Options.UseFont = True
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
        Me.txtTotAmt.Size = New System.Drawing.Size(1054, 26)
        Me.txtTotAmt.StyleController = Me.LayoutControl6
        Me.txtTotAmt.TabIndex = 42
        Me.txtTotAmt.Tag = "Totamt,0,1,2"
        Me.txtTotAmt.Visible = False
        '
        'txtAmtH
        '
        Me.txtAmtH.EditValue = "0,00 €"
        Me.txtAmtH.Location = New System.Drawing.Point(228, 162)
        Me.txtAmtH.Margin = New System.Windows.Forms.Padding(4)
        Me.txtAmtH.Name = "txtAmtH"
        Me.txtAmtH.Properties.DisplayFormat.FormatString = "c"
        Me.txtAmtH.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtAmtH.Properties.EditFormat.FormatString = "n2"
        Me.txtAmtH.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtAmtH.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtAmtH.Properties.MaskSettings.Set("MaskManagerType", GetType(DevExpress.Data.Mask.NumericMaskManager))
        Me.txtAmtH.Properties.MaskSettings.Set("mask", "c2")
        Me.txtAmtH.Properties.Tag = "BenchExtraPrice"
        Me.txtAmtH.Size = New System.Drawing.Size(1054, 26)
        Me.txtAmtH.StyleController = Me.LayoutControl6
        Me.txtAmtH.TabIndex = 42
        Me.txtAmtH.Tag = "amt,0,1,2"
        Me.txtAmtH.Visible = False
        '
        'txtVatAmt
        '
        Me.txtVatAmt.EditValue = "0,00 €"
        Me.txtVatAmt.Location = New System.Drawing.Point(228, 192)
        Me.txtVatAmt.Margin = New System.Windows.Forms.Padding(4)
        Me.txtVatAmt.Name = "txtVatAmt"
        Me.txtVatAmt.Properties.DisplayFormat.FormatString = "c"
        Me.txtVatAmt.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtVatAmt.Properties.EditFormat.FormatString = "n2"
        Me.txtVatAmt.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtVatAmt.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtVatAmt.Properties.MaskSettings.Set("MaskManagerType", GetType(DevExpress.Data.Mask.NumericMaskManager))
        Me.txtVatAmt.Properties.MaskSettings.Set("mask", "c2")
        Me.txtVatAmt.Properties.Tag = "BenchExtraPrice"
        Me.txtVatAmt.Size = New System.Drawing.Size(1054, 26)
        Me.txtVatAmt.StyleController = Me.LayoutControl6
        Me.txtVatAmt.TabIndex = 42
        Me.txtVatAmt.Tag = "vatamt,0,1,2"
        Me.txtVatAmt.Visible = False
        '
        'LayoutControlGroup7
        '
        Me.LayoutControlGroup7.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup7.GroupBordersVisible = False
        Me.LayoutControlGroup7.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem22, Me.LayoutControlItem48, Me.LayoutControlItem49, Me.LayoutControlItem50, Me.LayoutControlItem28, Me.LayoutControlItem13, Me.LayoutControlItem51, Me.LayoutControlItem45, Me.LayoutControlItem26})
        Me.LayoutControlGroup7.Name = "Root"
        Me.LayoutControlGroup7.Size = New System.Drawing.Size(1294, 378)
        Me.LayoutControlGroup7.TextVisible = False
        '
        'LayoutControlItem22
        '
        Me.LayoutControlItem22.Control = Me.txtDevicesCost
        Me.LayoutControlItem22.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem22.CustomizationFormText = "Τελική Αξία"
        Me.LayoutControlItem22.HighlightFocusedItem = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlItem22.ImageOptions.Image = CType(resources.GetObject("LayoutControlItem22.ImageOptions.Image"), System.Drawing.Image)
        Me.LayoutControlItem22.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem22.Name = "LayoutControlItem22"
        Me.LayoutControlItem22.Size = New System.Drawing.Size(1274, 30)
        Me.LayoutControlItem22.Text = "Πώληση Συσκευών"
        Me.LayoutControlItem22.TextSize = New System.Drawing.Size(204, 19)
        '
        'LayoutControlItem48
        '
        Me.LayoutControlItem48.Control = Me.txtbenchPurchasePrice
        Me.LayoutControlItem48.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem48.CustomizationFormText = "Τελική Αξία"
        Me.LayoutControlItem48.HighlightFocusedItem = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlItem48.Location = New System.Drawing.Point(0, 30)
        Me.LayoutControlItem48.Name = "LayoutControlItem48"
        Me.LayoutControlItem48.Size = New System.Drawing.Size(354, 30)
        Me.LayoutControlItem48.Text = "Τιμή Χονδρικής Πάγκου"
        Me.LayoutControlItem48.TextSize = New System.Drawing.Size(204, 19)
        '
        'LayoutControlItem49
        '
        Me.LayoutControlItem49.Control = Me.txtbenchSalesPrice
        Me.LayoutControlItem49.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem49.CustomizationFormText = "Τελική Αξία"
        Me.LayoutControlItem49.HighlightFocusedItem = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlItem49.Location = New System.Drawing.Point(354, 30)
        Me.LayoutControlItem49.Name = "LayoutControlItem49"
        Me.LayoutControlItem49.Size = New System.Drawing.Size(391, 30)
        Me.LayoutControlItem49.Text = "Τιμή Λιανικής Πάγκου"
        Me.LayoutControlItem49.TextSize = New System.Drawing.Size(204, 19)
        '
        'LayoutControlItem50
        '
        Me.LayoutControlItem50.Control = Me.txtbenchProfit
        Me.LayoutControlItem50.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem50.CustomizationFormText = "Τελική Αξία"
        Me.LayoutControlItem50.HighlightFocusedItem = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlItem50.Location = New System.Drawing.Point(745, 30)
        Me.LayoutControlItem50.Name = "LayoutControlItem50"
        Me.LayoutControlItem50.Size = New System.Drawing.Size(529, 30)
        Me.LayoutControlItem50.Text = "Προμήθεια"
        Me.LayoutControlItem50.TextSize = New System.Drawing.Size(204, 19)
        '
        'LayoutControlItem28
        '
        Me.LayoutControlItem28.Control = Me.txtExtraCost
        Me.LayoutControlItem28.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem28.CustomizationFormText = "Τελική Αξία"
        Me.LayoutControlItem28.HighlightFocusedItem = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlItem28.Location = New System.Drawing.Point(0, 60)
        Me.LayoutControlItem28.Name = "LayoutControlItem28"
        Me.LayoutControlItem28.Size = New System.Drawing.Size(1274, 30)
        Me.LayoutControlItem28.Text = "Έξτρα Χρεώσεις"
        Me.LayoutControlItem28.TextSize = New System.Drawing.Size(204, 19)
        '
        'LayoutControlItem13
        '
        Me.LayoutControlItem13.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 8.142858!, System.Drawing.FontStyle.Bold)
        Me.LayoutControlItem13.AppearanceItemCaption.Options.UseFont = True
        Me.LayoutControlItem13.Control = Me.txtTotAmt
        Me.LayoutControlItem13.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem13.CustomizationFormText = "Τελική Αξία"
        Me.LayoutControlItem13.HighlightFocusedItem = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlItem13.ImageOptions.Image = CType(resources.GetObject("LayoutControlItem13.ImageOptions.Image"), System.Drawing.Image)
        Me.LayoutControlItem13.Location = New System.Drawing.Point(0, 90)
        Me.LayoutControlItem13.Name = "LayoutControlItem13"
        Me.LayoutControlItem13.Size = New System.Drawing.Size(1274, 30)
        Me.LayoutControlItem13.Text = "Γενικό Σύνολο Πώλησης"
        Me.LayoutControlItem13.TextSize = New System.Drawing.Size(204, 19)
        '
        'LayoutControlItem51
        '
        Me.LayoutControlItem51.Control = Me.txtAmtH
        Me.LayoutControlItem51.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem51.CustomizationFormText = "Τελική Αξία"
        Me.LayoutControlItem51.HighlightFocusedItem = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlItem51.Location = New System.Drawing.Point(0, 150)
        Me.LayoutControlItem51.Name = "LayoutControlItem51"
        Me.LayoutControlItem51.Size = New System.Drawing.Size(1274, 30)
        Me.LayoutControlItem51.Text = "Ποσό Παραστατικού"
        Me.LayoutControlItem51.TextSize = New System.Drawing.Size(204, 19)
        '
        'LayoutControlItem45
        '
        Me.LayoutControlItem45.Control = Me.txtVatAmt
        Me.LayoutControlItem45.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem45.CustomizationFormText = "Τελική Αξία"
        Me.LayoutControlItem45.HighlightFocusedItem = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlItem45.Location = New System.Drawing.Point(0, 180)
        Me.LayoutControlItem45.Name = "LayoutControlItem45"
        Me.LayoutControlItem45.Size = New System.Drawing.Size(1274, 178)
        Me.LayoutControlItem45.Text = "ΦΠΑ Παραστατικού"
        Me.LayoutControlItem45.TextSize = New System.Drawing.Size(204, 19)
        '
        'LayoutControlItem26
        '
        Me.LayoutControlItem26.Control = Me.cboInvoiceType
        Me.LayoutControlItem26.ImageOptions.Image = Global.DreamyKitchenCRM.My.Resources.Resources.rsz_11rsz_asterisk
        Me.LayoutControlItem26.Location = New System.Drawing.Point(0, 120)
        Me.LayoutControlItem26.Name = "LayoutControlItem26"
        Me.LayoutControlItem26.Size = New System.Drawing.Size(1274, 30)
        Me.LayoutControlItem26.Tag = "1"
        Me.LayoutControlItem26.Text = "Τύπος Παραστατικού"
        Me.LayoutControlItem26.TextSize = New System.Drawing.Size(204, 19)
        '
        'TabNavigationPage6
        '
        Me.TabNavigationPage6.Caption = "TabNavigationPage6"
        Me.TabNavigationPage6.Controls.Add(Me.GridControl4)
        Me.TabNavigationPage6.Name = "TabNavigationPage6"
        Me.TabNavigationPage6.PageText = "Στοιχεία Χρέωσης"
        Me.TabNavigationPage6.Size = New System.Drawing.Size(1294, 378)
        '
        'GridControl4
        '
        Me.GridControl4.DataSource = Me.VwTRANSDDebitBindingSource
        Me.GridControl4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl4.EmbeddedNavigator.Buttons.EndEdit.Visible = False
        Me.GridControl4.EmbeddedNavigator.Buttons.First.Visible = False
        Me.GridControl4.EmbeddedNavigator.Buttons.Last.Visible = False
        Me.GridControl4.EmbeddedNavigator.Buttons.Next.Visible = False
        Me.GridControl4.EmbeddedNavigator.Buttons.NextPage.Visible = False
        Me.GridControl4.EmbeddedNavigator.Buttons.Prev.Visible = False
        Me.GridControl4.EmbeddedNavigator.Buttons.PrevPage.Visible = False
        Me.GridControl4.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(4)
        Me.GridControl4.Location = New System.Drawing.Point(0, 0)
        Me.GridControl4.MainView = Me.GridView4
        Me.GridControl4.Margin = New System.Windows.Forms.Padding(4)
        Me.GridControl4.Name = "GridControl4"
        Me.GridControl4.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemBanks, Me.RepositoryItemPayTypes, Me.RepositoryItemCctTransh, Me.RepositoryItemCusTranshID})
        Me.GridControl4.Size = New System.Drawing.Size(1294, 378)
        Me.GridControl4.TabIndex = 11
        Me.GridControl4.UseEmbeddedNavigator = True
        Me.GridControl4.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView4})
        '
        'VwTRANSDDebitBindingSource
        '
        Me.VwTRANSDDebitBindingSource.DataMember = "vw_TRANSD_Debit"
        Me.VwTRANSDDebitBindingSource.DataSource = Me.DM_TRANS
        '
        'GridView4
        '
        Me.GridView4.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2, Me.GridColumn3, Me.GridColumn4, Me.GridColumn5, Me.GridColumn6, Me.GridColumn7, Me.GridColumn8, Me.GridColumn9, Me.GridColumn10, Me.GridColumn11, Me.GridColumn12, Me.GridColumn13, Me.GridColumn14, Me.GridColumn15, Me.colcustranshid})
        Me.GridView4.DetailHeight = 525
        Me.GridView4.GridControl = Me.GridControl4
        Me.GridView4.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "amt", Me.GridColumn6, " Σύνολο {0:n2}€")})
        Me.GridView4.Name = "GridView4"
        Me.GridView4.OptionsEditForm.PopupEditFormWidth = 720
        Me.GridView4.OptionsMenu.ShowConditionalFormattingItem = True
        Me.GridView4.OptionsView.EnableAppearanceEvenRow = True
        Me.GridView4.OptionsView.ShowFooter = True
        Me.GridView4.OptionsView.ShowGroupedColumns = True
        Me.GridView4.OptionsView.ShowGroupPanel = False
        '
        'GridColumn1
        '
        Me.GridColumn1.FieldName = "ID"
        Me.GridColumn1.MinWidth = 30
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Width = 112
        '
        'GridColumn2
        '
        Me.GridColumn2.FieldName = "transhID"
        Me.GridColumn2.MinWidth = 30
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Width = 112
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "Τράπεζα"
        Me.GridColumn3.ColumnEdit = Me.RepositoryItemBanks
        Me.GridColumn3.FieldName = "bankID"
        Me.GridColumn3.MinWidth = 30
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Width = 61
        '
        'RepositoryItemBanks
        '
        Me.RepositoryItemBanks.AutoHeight = False
        Me.RepositoryItemBanks.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Clear)})
        Me.RepositoryItemBanks.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("RealName", "Real Name", 90, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 30, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("code", "code", 48, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("name", "name", 52, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("modifiedBy", "modified By", 96, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("modifiedOn", "modified On", 99, DevExpress.Utils.FormatType.DateTime, "d/M/yyyy", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("createdOn", "created On", 94, DevExpress.Utils.FormatType.DateTime, "d/M/yyyy", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("createdBy", "created By", 91, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default])})
        Me.RepositoryItemBanks.DataSource = Me.VwBANKSBindingSource
        Me.RepositoryItemBanks.DisplayMember = "name"
        Me.RepositoryItemBanks.Name = "RepositoryItemBanks"
        Me.RepositoryItemBanks.NullText = ""
        Me.RepositoryItemBanks.ValueMember = "ID"
        '
        'VwBANKSBindingSource
        '
        Me.VwBANKSBindingSource.DataMember = "vw_BANKS"
        Me.VwBANKSBindingSource.DataSource = Me.DreamyKitchenDataSet
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "Τράπεζα"
        Me.GridColumn4.FieldName = "BankName"
        Me.GridColumn4.MinWidth = 30
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.Width = 487
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "Μετρητά"
        Me.GridColumn5.FieldName = "cash"
        Me.GridColumn5.MinWidth = 30
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.Width = 183
        '
        'GridColumn6
        '
        Me.GridColumn6.Caption = "Ποσό"
        Me.GridColumn6.DisplayFormat.FormatString = "{0:n2}€"
        Me.GridColumn6.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn6.FieldName = "amt"
        Me.GridColumn6.MinWidth = 30
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "amt", " Σύνολο {0:n2}€")})
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 0
        Me.GridColumn6.Width = 217
        '
        'GridColumn7
        '
        Me.GridColumn7.Caption = "Σχόλια"
        Me.GridColumn7.FieldName = "cmt"
        Me.GridColumn7.MinWidth = 30
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.Width = 784
        '
        'GridColumn8
        '
        Me.GridColumn8.Caption = "Ημερομηνία"
        Me.GridColumn8.FieldName = "dtPay"
        Me.GridColumn8.MinWidth = 30
        Me.GridColumn8.Name = "GridColumn8"
        Me.GridColumn8.Width = 177
        '
        'GridColumn9
        '
        Me.GridColumn9.Caption = "Ενημερώθηκε από"
        Me.GridColumn9.FieldName = "RealName"
        Me.GridColumn9.MinWidth = 30
        Me.GridColumn9.Name = "GridColumn9"
        Me.GridColumn9.Width = 112
        '
        'GridColumn10
        '
        Me.GridColumn10.FieldName = "modifiedOn"
        Me.GridColumn10.MinWidth = 30
        Me.GridColumn10.Name = "GridColumn10"
        Me.GridColumn10.Width = 112
        '
        'GridColumn11
        '
        Me.GridColumn11.FieldName = "createdOn"
        Me.GridColumn11.MinWidth = 30
        Me.GridColumn11.Name = "GridColumn11"
        Me.GridColumn11.Width = 112
        '
        'GridColumn12
        '
        Me.GridColumn12.Caption = "Τύπος Πληρωμής"
        Me.GridColumn12.ColumnEdit = Me.RepositoryItemPayTypes
        Me.GridColumn12.FieldName = "PayTypeID"
        Me.GridColumn12.MinWidth = 31
        Me.GridColumn12.Name = "GridColumn12"
        Me.GridColumn12.Width = 69
        '
        'RepositoryItemPayTypes
        '
        Me.RepositoryItemPayTypes.AutoHeight = False
        Me.RepositoryItemPayTypes.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemPayTypes.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 31, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("code", "code", 49, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("name", "Τύπος Πληρωμής", 55, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("modifiedBy", "modified By", 102, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("modifiedOn", "modified On", 105, DevExpress.Utils.FormatType.DateTime, "d/M/yyyy", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("createdOn", "created On", 97, DevExpress.Utils.FormatType.DateTime, "d/M/yyyy", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("createdBy", "created By", 93, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("RealName", "Real Name", 96, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default])})
        Me.RepositoryItemPayTypes.DataSource = Me.VwPAYTYPESBindingSource
        Me.RepositoryItemPayTypes.DisplayMember = "name"
        Me.RepositoryItemPayTypes.Name = "RepositoryItemPayTypes"
        Me.RepositoryItemPayTypes.NullText = ""
        Me.RepositoryItemPayTypes.ValueMember = "ID"
        '
        'VwPAYTYPESBindingSource
        '
        Me.VwPAYTYPESBindingSource.DataMember = "vw_PAYTYPES"
        Me.VwPAYTYPESBindingSource.DataSource = Me.DM_TRANS
        '
        'GridColumn13
        '
        Me.GridColumn13.Caption = "Παραλαβή Χρημάτων"
        Me.GridColumn13.FieldName = "paid"
        Me.GridColumn13.MinWidth = 31
        Me.GridColumn13.Name = "GridColumn13"
        Me.GridColumn13.Width = 118
        '
        'GridColumn14
        '
        Me.GridColumn14.Caption = "Καταθέτης"
        Me.GridColumn14.FieldName = "depositor"
        Me.GridColumn14.MinWidth = 31
        Me.GridColumn14.Name = "GridColumn14"
        Me.GridColumn14.Width = 118
        '
        'GridColumn15
        '
        Me.GridColumn15.Caption = "Πελάτης"
        Me.GridColumn15.ColumnEdit = Me.RepositoryItemCctTransh
        Me.GridColumn15.FieldName = "cusID"
        Me.GridColumn15.MinWidth = 31
        Me.GridColumn15.Name = "GridColumn15"
        Me.GridColumn15.Visible = True
        Me.GridColumn15.VisibleIndex = 1
        Me.GridColumn15.Width = 232
        '
        'RepositoryItemCctTransh
        '
        Me.RepositoryItemCctTransh.AutoHeight = False
        Me.RepositoryItemCctTransh.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Clear)})
        Me.RepositoryItemCctTransh.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 31, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("code", "code", 49, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Fullname", "Πελάτης", 82, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("FatherName", "Father Name", 111, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CouID", "Cou ID", 66, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("AreaID", "Area ID", 70, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("AdrID", "Adr ID", 63, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("SourceID", "Source ID", 88, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("SalerID", "Saler ID", 75, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("DoyID", "Doy ID", 66, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("PrfID", "Prf ID", 57, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("phn", "phn", 43, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("mob", "mob", 46, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("fax", "fax", 36, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("email", "email", 52, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("afm", "afm", 42, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("cmt", "cmt", 42, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("modifiedBy", "modified By", 102, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("modifiedOn", "modified On", 105, DevExpress.Utils.FormatType.DateTime, "d/M/yyyy", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("createdOn", "created On", 97, DevExpress.Utils.FormatType.DateTime, "d/M/yyyy", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("createdBy", "created By", 93, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default])})
        Me.RepositoryItemCctTransh.DataSource = Me.COMPCCTTRANSHBindingSource
        Me.RepositoryItemCctTransh.DisplayMember = "Fullname"
        Me.RepositoryItemCctTransh.Name = "RepositoryItemCctTransh"
        Me.RepositoryItemCctTransh.NullText = ""
        Me.RepositoryItemCctTransh.ValueMember = "ID"
        '
        'COMPCCTTRANSHBindingSource
        '
        Me.COMPCCTTRANSHBindingSource.DataMember = "COMP_CCT_TRANSH"
        Me.COMPCCTTRANSHBindingSource.DataSource = Me.DM_TRANS
        '
        'colcustranshid
        '
        Me.colcustranshid.Caption = "Έργο Πελάτη"
        Me.colcustranshid.ColumnEdit = Me.RepositoryItemCusTranshID
        Me.colcustranshid.FieldName = "custranshid"
        Me.colcustranshid.MinWidth = 30
        Me.colcustranshid.Name = "colcustranshid"
        Me.colcustranshid.Visible = True
        Me.colcustranshid.VisibleIndex = 2
        Me.colcustranshid.Width = 112
        '
        'RepositoryItemCusTranshID
        '
        Me.RepositoryItemCusTranshID.AutoHeight = False
        Me.RepositoryItemCusTranshID.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemCusTranshID.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 30, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("code", "code", 46, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("cusID", "cus ID", 58, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("dtCharge", "dt Charge", 82, DevExpress.Utils.FormatType.DateTime, "d/M/yyyy", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("GRMONTH", "GRMONTH", 90, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("amt", "amt", 40, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("cmt", "cmt", 39, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("modifiedBy", "modified By", 97, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("modifiedOn", "modified On", 101, DevExpress.Utils.FormatType.DateTime, "d/M/yyyy", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("createdOn", "created On", 90, DevExpress.Utils.FormatType.DateTime, "d/M/yyyy", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("createdBy", "created By", 86, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Fullname", "Fullname", 77, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("RealName", "Real Name", 89, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Totamt", "Totamt", 64, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("vatamt", "vatamt", 61, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("bal", "bal", 34, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("SalerName", "Saler Name", 94, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("SalerID", "Saler ID", 70, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("EmpTID", "Emp TID", 77, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("invTypeDescr", "inv Type Descr", 118, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("description", "description", 90, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("invType", "inv Type", 74, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("empID", "emp ID", 66, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("DebitCost", "Debit Cost", 86, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("DevicesCost", "Devices Cost", 102, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("salerProfit", "saler Profit", 89, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("FullTranshDescription", "Έργο", 176, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("AreaId", "Area Id", 66, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("adrid", "adrid", 49, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("couid", "couid", 51, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("benchSalesPrice", "bench Sales Price", 135, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("benchPurchasePrice", "bench Purchase Price", 162, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("benchProfit", "bench Profit", 98, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("dtAgreement", "dt Agreement", 110, DevExpress.Utils.FormatType.DateTime, "d/M/yyyy", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("offerCusAcceptance", "offer Cus Acceptance", 161, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("waitingForAgreement", "waiting For Agreement", 175, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default])})
        Me.RepositoryItemCusTranshID.DataSource = Me.VwTRANSHBindingSource
        Me.RepositoryItemCusTranshID.DisplayMember = "FullTranshDescription"
        Me.RepositoryItemCusTranshID.Name = "RepositoryItemCusTranshID"
        Me.RepositoryItemCusTranshID.NullText = ""
        Me.RepositoryItemCusTranshID.PopupFormMinSize = New System.Drawing.Size(700, 400)
        Me.RepositoryItemCusTranshID.PopupWidthMode = DevExpress.XtraEditors.PopupWidthMode.ContentWidth
        Me.RepositoryItemCusTranshID.ValueMember = "ID"
        '
        'VwTRANSHBindingSource
        '
        Me.VwTRANSHBindingSource.DataMember = "vw_TRANSH"
        Me.VwTRANSHBindingSource.DataSource = Me.DM_TRANS
        '
        'chkCompleted
        '
        Me.chkCompleted.EditValue = CType(0, Byte)
        Me.chkCompleted.Location = New System.Drawing.Point(12, 1161)
        Me.chkCompleted.Margin = New System.Windows.Forms.Padding(4)
        Me.chkCompleted.Name = "chkCompleted"
        Me.chkCompleted.Properties.Appearance.BackColor = System.Drawing.Color.SlateGray
        Me.chkCompleted.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.chkCompleted.Properties.Appearance.ForeColor = System.Drawing.Color.White
        Me.chkCompleted.Properties.Appearance.Options.UseBackColor = True
        Me.chkCompleted.Properties.Appearance.Options.UseFont = True
        Me.chkCompleted.Properties.Appearance.Options.UseForeColor = True
        Me.chkCompleted.Properties.Caption = "Κλείσιμο Έργου"
        Me.chkCompleted.Properties.CheckBoxOptions.Style = DevExpress.XtraEditors.Controls.CheckBoxStyle.SvgToggle1
        Me.chkCompleted.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.chkCompleted.Properties.Tag = "completed,0,1,2"
        Me.chkCompleted.Properties.ValueChecked = CType(1, Byte)
        Me.chkCompleted.Properties.ValueUnchecked = CType(0, Byte)
        Me.chkCompleted.Size = New System.Drawing.Size(326, 31)
        Me.chkCompleted.StyleController = Me.LayoutControl2
        Me.chkCompleted.TabIndex = 67
        Me.chkCompleted.Tag = "completed,0,1,2"
        '
        'cmdSaveTransH
        '
        Me.cmdSaveTransH.ImageOptions.Image = Global.DreamyKitchenCRM.My.Resources.Resources.icons8_save_close_24
        Me.cmdSaveTransH.Location = New System.Drawing.Point(1185, 1161)
        Me.cmdSaveTransH.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdSaveTransH.Name = "cmdSaveTransH"
        Me.cmdSaveTransH.Size = New System.Drawing.Size(145, 32)
        Me.cmdSaveTransH.StyleController = Me.LayoutControl2
        Me.cmdSaveTransH.TabIndex = 66
        Me.cmdSaveTransH.Text = "Αποθήκευση"
        '
        'cmdPrintAll
        '
        Me.cmdPrintAll.ImageOptions.Image = Global.DreamyKitchenCRM.My.Resources.Resources.icons8_papers_24
        Me.cmdPrintAll.Location = New System.Drawing.Point(1070, 1161)
        Me.cmdPrintAll.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdPrintAll.Name = "cmdPrintAll"
        Me.cmdPrintAll.Size = New System.Drawing.Size(111, 32)
        Me.cmdPrintAll.StyleController = Me.LayoutControl2
        Me.cmdPrintAll.TabIndex = 65
        Me.cmdPrintAll.Text = "Έντυπα"
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem25, Me.LayoutControlItem1, Me.EmptySpaceItem5, Me.LayoutControlGroup4, Me.LayoutControlItem23, Me.LayoutControlItem52, Me.LPrintCompOffer})
        Me.LayoutControlGroup1.Name = "Root"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(1342, 1205)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem25
        '
        Me.LayoutControlItem25.Control = Me.cmdPrintAll
        Me.LayoutControlItem25.Location = New System.Drawing.Point(1058, 1149)
        Me.LayoutControlItem25.Name = "LayoutControlItem25"
        Me.LayoutControlItem25.Size = New System.Drawing.Size(115, 36)
        Me.LayoutControlItem25.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem25.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.cmdSaveTransH
        Me.LayoutControlItem1.Location = New System.Drawing.Point(1173, 1149)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(149, 36)
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'EmptySpaceItem5
        '
        Me.EmptySpaceItem5.AllowHotTrack = False
        Me.EmptySpaceItem5.Location = New System.Drawing.Point(330, 1149)
        Me.EmptySpaceItem5.Name = "EmptySpaceItem5"
        Me.EmptySpaceItem5.Size = New System.Drawing.Size(381, 36)
        Me.EmptySpaceItem5.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlGroup4
        '
        Me.LayoutControlGroup4.AppearanceGroup.BorderColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Success
        Me.LayoutControlGroup4.AppearanceGroup.Options.UseBorderColor = True
        Me.LayoutControlGroup4.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem47})
        Me.LayoutControlGroup4.Location = New System.Drawing.Point(0, 662)
        Me.LayoutControlGroup4.Name = "LayoutControlGroup4"
        Me.LayoutControlGroup4.Size = New System.Drawing.Size(1322, 487)
        Me.LayoutControlGroup4.Text = "Οικονομικά Στοιχεία"
        '
        'LayoutControlItem47
        '
        Me.LayoutControlItem47.Control = Me.TabPane2
        Me.LayoutControlItem47.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem47.Name = "LayoutControlItem47"
        Me.LayoutControlItem47.Size = New System.Drawing.Size(1298, 431)
        Me.LayoutControlItem47.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem47.TextVisible = False
        '
        'LayoutControlItem23
        '
        Me.LayoutControlItem23.Control = Me.chkCompleted
        Me.LayoutControlItem23.Location = New System.Drawing.Point(0, 1149)
        Me.LayoutControlItem23.Name = "LayoutControlItem23"
        Me.LayoutControlItem23.Size = New System.Drawing.Size(330, 36)
        Me.LayoutControlItem23.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem23.TextVisible = False
        '
        'LayoutControlItem52
        '
        Me.LayoutControlItem52.Control = Me.LayoutControl7
        Me.LayoutControlItem52.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem52.Name = "LayoutControlItem52"
        Me.LayoutControlItem52.Size = New System.Drawing.Size(1322, 662)
        Me.LayoutControlItem52.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem52.TextVisible = False
        '
        'LPrintCompOffer
        '
        Me.LPrintCompOffer.Control = Me.cmdPrintCompOffer
        Me.LPrintCompOffer.CustomizationFormText = "LPrintCompOffer"
        Me.LPrintCompOffer.Location = New System.Drawing.Point(711, 1149)
        Me.LPrintCompOffer.Name = "LPrintCompOffer"
        Me.LPrintCompOffer.Size = New System.Drawing.Size(347, 36)
        Me.LPrintCompOffer.TextSize = New System.Drawing.Size(0, 0)
        Me.LPrintCompOffer.TextVisible = False
        '
        'TabNavigationPage2
        '
        Me.TabNavigationPage2.Caption = "TabNavigationPage2"
        Me.TabNavigationPage2.Controls.Add(Me.LayoutControl3)
        Me.TabNavigationPage2.Name = "TabNavigationPage2"
        Me.TabNavigationPage2.PageText = "Στοιχεία Πίστωσης"
        Me.TabNavigationPage2.Properties.AppearanceCaption.BorderColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Success
        Me.TabNavigationPage2.Properties.AppearanceCaption.Options.UseBorderColor = True
        Me.TabNavigationPage2.Size = New System.Drawing.Size(1342, 1205)
        '
        'LayoutControl3
        '
        Me.LayoutControl3.Controls.Add(Me.GridControl1)
        Me.LayoutControl3.Controls.Add(Me.cmdSaveTransD)
        Me.LayoutControl3.Controls.Add(Me.chkCash)
        Me.LayoutControl3.Controls.Add(Me.dtPay)
        Me.LayoutControl3.Controls.Add(Me.txtCodeD)
        Me.LayoutControl3.Controls.Add(Me.cboBANK)
        Me.LayoutControl3.Controls.Add(Me.MemoEdit11)
        Me.LayoutControl3.Controls.Add(Me.cboPayType)
        Me.LayoutControl3.Controls.Add(Me.txtamtD)
        Me.LayoutControl3.Controls.Add(Me.txtCMTD)
        Me.LayoutControl3.Controls.Add(Me.cboCUSD)
        Me.LayoutControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl3.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl3.Name = "LayoutControl3"
        Me.LayoutControl3.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(2169, 264, 1137, 700)
        Me.LayoutControl3.Root = Me.LayoutControlGroup2
        Me.LayoutControl3.Size = New System.Drawing.Size(1342, 1205)
        Me.LayoutControl3.TabIndex = 0
        Me.LayoutControl3.Text = "LayoutControl3"
        '
        'GridControl1
        '
        Me.GridControl1.DataSource = Me.VwTRANSDCreditBindingSource
        Me.GridControl1.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(4)
        Me.GridControl1.Location = New System.Drawing.Point(12, 506)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Margin = New System.Windows.Forms.Padding(4)
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemLookUpEdit1, Me.RepositoryItemLookUpEdit2, Me.RepositoryItemCCT})
        Me.GridControl1.Size = New System.Drawing.Size(1318, 687)
        Me.GridControl1.TabIndex = 10
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'VwTRANSDCreditBindingSource
        '
        Me.VwTRANSDCreditBindingSource.DataMember = "vw_TRANSD_Credit"
        Me.VwTRANSDCreditBindingSource.DataSource = Me.DM_TRANS
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colID, Me.coltranshID, Me.colbankID, Me.colBankName, Me.colcash, Me.colamt, Me.colcmt, Me.coldtPay, Me.colRealName, Me.colmodifiedOn, Me.colcreatedOn, Me.colPayTypeID, Me.colpaid, Me.coldepositor, Me.colcusID})
        Me.GridView1.DetailHeight = 525
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "amt", Me.colamt, " Σύνολο {0:n2}€")})
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsEditForm.PopupEditFormWidth = 720
        Me.GridView1.OptionsMenu.ShowConditionalFormattingItem = True
        Me.GridView1.OptionsView.EnableAppearanceEvenRow = True
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.OptionsView.ShowGroupedColumns = True
        '
        'colID
        '
        Me.colID.FieldName = "ID"
        Me.colID.MinWidth = 30
        Me.colID.Name = "colID"
        Me.colID.Width = 112
        '
        'coltranshID
        '
        Me.coltranshID.FieldName = "transhID"
        Me.coltranshID.MinWidth = 30
        Me.coltranshID.Name = "coltranshID"
        Me.coltranshID.Width = 112
        '
        'colbankID
        '
        Me.colbankID.Caption = "Τράπεζα"
        Me.colbankID.ColumnEdit = Me.RepositoryItemLookUpEdit1
        Me.colbankID.FieldName = "bankID"
        Me.colbankID.MinWidth = 30
        Me.colbankID.Name = "colbankID"
        Me.colbankID.Visible = True
        Me.colbankID.VisibleIndex = 4
        Me.colbankID.Width = 61
        '
        'RepositoryItemLookUpEdit1
        '
        Me.RepositoryItemLookUpEdit1.AutoHeight = False
        Me.RepositoryItemLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Clear)})
        Me.RepositoryItemLookUpEdit1.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("RealName", "Real Name", 90, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 30, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("code", "code", 48, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("name", "name", 52, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("modifiedBy", "modified By", 96, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("modifiedOn", "modified On", 99, DevExpress.Utils.FormatType.DateTime, "d/M/yyyy", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("createdOn", "created On", 94, DevExpress.Utils.FormatType.DateTime, "d/M/yyyy", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("createdBy", "created By", 91, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default])})
        Me.RepositoryItemLookUpEdit1.DataSource = Me.VwBANKSBindingSource
        Me.RepositoryItemLookUpEdit1.DisplayMember = "name"
        Me.RepositoryItemLookUpEdit1.Name = "RepositoryItemLookUpEdit1"
        Me.RepositoryItemLookUpEdit1.NullText = ""
        Me.RepositoryItemLookUpEdit1.ValueMember = "ID"
        '
        'colBankName
        '
        Me.colBankName.Caption = "Τράπεζα"
        Me.colBankName.FieldName = "BankName"
        Me.colBankName.MinWidth = 30
        Me.colBankName.Name = "colBankName"
        Me.colBankName.Width = 487
        '
        'colcash
        '
        Me.colcash.Caption = "Μετρητά"
        Me.colcash.FieldName = "cash"
        Me.colcash.MinWidth = 30
        Me.colcash.Name = "colcash"
        Me.colcash.Visible = True
        Me.colcash.VisibleIndex = 3
        Me.colcash.Width = 183
        '
        'colamt
        '
        Me.colamt.Caption = "Ποσό"
        Me.colamt.DisplayFormat.FormatString = "{0:n2}€"
        Me.colamt.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colamt.FieldName = "amt"
        Me.colamt.MinWidth = 30
        Me.colamt.Name = "colamt"
        Me.colamt.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "amt", " Σύνολο {0:n2}€")})
        Me.colamt.Visible = True
        Me.colamt.VisibleIndex = 2
        Me.colamt.Width = 217
        '
        'colcmt
        '
        Me.colcmt.Caption = "Σχόλια"
        Me.colcmt.FieldName = "cmt"
        Me.colcmt.MinWidth = 30
        Me.colcmt.Name = "colcmt"
        Me.colcmt.Visible = True
        Me.colcmt.VisibleIndex = 6
        Me.colcmt.Width = 784
        '
        'coldtPay
        '
        Me.coldtPay.Caption = "Ημερομηνία"
        Me.coldtPay.FieldName = "dtPay"
        Me.coldtPay.MinWidth = 30
        Me.coldtPay.Name = "coldtPay"
        Me.coldtPay.Visible = True
        Me.coldtPay.VisibleIndex = 1
        Me.coldtPay.Width = 177
        '
        'colRealName
        '
        Me.colRealName.Caption = "Ενημερώθηκε από"
        Me.colRealName.FieldName = "RealName"
        Me.colRealName.MinWidth = 30
        Me.colRealName.Name = "colRealName"
        Me.colRealName.Width = 112
        '
        'colmodifiedOn
        '
        Me.colmodifiedOn.FieldName = "modifiedOn"
        Me.colmodifiedOn.MinWidth = 30
        Me.colmodifiedOn.Name = "colmodifiedOn"
        Me.colmodifiedOn.Width = 112
        '
        'colcreatedOn
        '
        Me.colcreatedOn.FieldName = "createdOn"
        Me.colcreatedOn.MinWidth = 30
        Me.colcreatedOn.Name = "colcreatedOn"
        Me.colcreatedOn.Width = 112
        '
        'colPayTypeID
        '
        Me.colPayTypeID.Caption = "Τύπος Πληρωμής"
        Me.colPayTypeID.ColumnEdit = Me.RepositoryItemLookUpEdit2
        Me.colPayTypeID.FieldName = "PayTypeID"
        Me.colPayTypeID.MinWidth = 31
        Me.colPayTypeID.Name = "colPayTypeID"
        Me.colPayTypeID.Visible = True
        Me.colPayTypeID.VisibleIndex = 7
        Me.colPayTypeID.Width = 69
        '
        'RepositoryItemLookUpEdit2
        '
        Me.RepositoryItemLookUpEdit2.AutoHeight = False
        Me.RepositoryItemLookUpEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit2.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 31, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("code", "code", 49, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("name", "Τύπος Πληρωμής", 55, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("modifiedBy", "modified By", 102, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("modifiedOn", "modified On", 105, DevExpress.Utils.FormatType.DateTime, "d/M/yyyy", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("createdOn", "created On", 97, DevExpress.Utils.FormatType.DateTime, "d/M/yyyy", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("createdBy", "created By", 93, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("RealName", "Real Name", 96, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default])})
        Me.RepositoryItemLookUpEdit2.DataSource = Me.VwPAYTYPESBindingSource
        Me.RepositoryItemLookUpEdit2.DisplayMember = "name"
        Me.RepositoryItemLookUpEdit2.Name = "RepositoryItemLookUpEdit2"
        Me.RepositoryItemLookUpEdit2.NullText = ""
        Me.RepositoryItemLookUpEdit2.ValueMember = "ID"
        '
        'colpaid
        '
        Me.colpaid.Caption = "Παραλαβή Χρημάτων"
        Me.colpaid.FieldName = "paid"
        Me.colpaid.MinWidth = 31
        Me.colpaid.Name = "colpaid"
        Me.colpaid.Visible = True
        Me.colpaid.VisibleIndex = 5
        Me.colpaid.Width = 118
        '
        'coldepositor
        '
        Me.coldepositor.Caption = "Καταθέτης"
        Me.coldepositor.FieldName = "depositor"
        Me.coldepositor.MinWidth = 31
        Me.coldepositor.Name = "coldepositor"
        Me.coldepositor.Visible = True
        Me.coldepositor.VisibleIndex = 8
        Me.coldepositor.Width = 118
        '
        'colcusID
        '
        Me.colcusID.Caption = "Πελάτης"
        Me.colcusID.ColumnEdit = Me.RepositoryItemCCT
        Me.colcusID.FieldName = "cusID"
        Me.colcusID.MinWidth = 31
        Me.colcusID.Name = "colcusID"
        Me.colcusID.Visible = True
        Me.colcusID.VisibleIndex = 0
        Me.colcusID.Width = 232
        '
        'RepositoryItemCCT
        '
        Me.RepositoryItemCCT.AutoHeight = False
        Me.RepositoryItemCCT.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Clear)})
        Me.RepositoryItemCCT.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 31, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("code", "code", 49, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Fullname", "Πελάτης", 82, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("FatherName", "Father Name", 111, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CouID", "Cou ID", 66, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("AreaID", "Area ID", 70, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("AdrID", "Adr ID", 63, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("SourceID", "Source ID", 88, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("SalerID", "Saler ID", 75, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("DoyID", "Doy ID", 66, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("PrfID", "Prf ID", 57, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("phn", "phn", 43, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("mob", "mob", 46, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("fax", "fax", 36, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("email", "email", 52, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("afm", "afm", 42, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("cmt", "cmt", 42, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("modifiedBy", "modified By", 102, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("modifiedOn", "modified On", 105, DevExpress.Utils.FormatType.DateTime, "d/M/yyyy", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("createdOn", "created On", 97, DevExpress.Utils.FormatType.DateTime, "d/M/yyyy", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("createdBy", "created By", 93, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default])})
        Me.RepositoryItemCCT.DataSource = Me.CCTTRANSHBindingSource
        Me.RepositoryItemCCT.DisplayMember = "Fullname"
        Me.RepositoryItemCCT.Name = "RepositoryItemCCT"
        Me.RepositoryItemCCT.NullText = ""
        Me.RepositoryItemCCT.ValueMember = "ID"
        '
        'CCTTRANSHBindingSource
        '
        Me.CCTTRANSHBindingSource.DataMember = "CCT_TRANSH"
        Me.CCTTRANSHBindingSource.DataSource = Me.DM_TRANS
        '
        'cmdSaveTransD
        '
        Me.cmdSaveTransD.ImageOptions.Image = Global.DreamyKitchenCRM.My.Resources.Resources.icons8_save_close_24
        Me.cmdSaveTransD.Location = New System.Drawing.Point(1114, 470)
        Me.cmdSaveTransD.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdSaveTransD.Name = "cmdSaveTransD"
        Me.cmdSaveTransD.Size = New System.Drawing.Size(216, 32)
        Me.cmdSaveTransD.StyleController = Me.LayoutControl3
        Me.cmdSaveTransD.TabIndex = 64
        Me.cmdSaveTransD.Text = "Αποθήκευση"
        '
        'chkCash
        '
        Me.chkCash.EditValue = CType(0, Byte)
        Me.chkCash.Location = New System.Drawing.Point(12, 134)
        Me.chkCash.Margin = New System.Windows.Forms.Padding(4)
        Me.chkCash.Name = "chkCash"
        Me.chkCash.Properties.Caption = "Μετρητά"
        Me.chkCash.Properties.ValueChecked = CType(1, Byte)
        Me.chkCash.Properties.ValueUnchecked = CType(0, Byte)
        Me.chkCash.Size = New System.Drawing.Size(1318, 27)
        Me.chkCash.StyleController = Me.LayoutControl3
        Me.chkCash.TabIndex = 5
        Me.chkCash.Tag = "cash,0,1,2"
        '
        'dtPay
        '
        Me.dtPay.EditValue = Nothing
        Me.dtPay.Location = New System.Drawing.Point(159, 44)
        Me.dtPay.Margin = New System.Windows.Forms.Padding(4)
        Me.dtPay.Name = "dtPay"
        Me.dtPay.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtPay.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtPay.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.dtPay.Size = New System.Drawing.Size(1171, 26)
        Me.dtPay.StyleController = Me.LayoutControl3
        Me.dtPay.TabIndex = 2
        Me.dtPay.Tag = "dtPay,0,1,2"
        '
        'txtCodeD
        '
        Me.txtCodeD.Location = New System.Drawing.Point(159, 12)
        Me.txtCodeD.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCodeD.Name = "txtCodeD"
        Me.txtCodeD.Properties.Appearance.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.txtCodeD.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtCodeD.Properties.Appearance.Options.UseBackColor = True
        Me.txtCodeD.Properties.Appearance.Options.UseFont = True
        Me.txtCodeD.Properties.ReadOnly = True
        Me.txtCodeD.Size = New System.Drawing.Size(131, 28)
        Me.txtCodeD.StyleController = Me.LayoutControl3
        Me.txtCodeD.TabIndex = 0
        Me.txtCodeD.Tag = "code,0"
        '
        'cboBANK
        '
        Me.cboBANK.Location = New System.Drawing.Point(159, 74)
        Me.cboBANK.Margin = New System.Windows.Forms.Padding(4)
        Me.cboBANK.Name = "cboBANK"
        Me.cboBANK.Properties.AllowMouseWheel = False
        Me.cboBANK.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.cboBANK.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Search), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Clear)})
        Me.cboBANK.Properties.NullText = ""
        Me.cboBANK.Properties.PopupSizeable = False
        Me.cboBANK.Size = New System.Drawing.Size(1171, 26)
        Me.cboBANK.StyleController = Me.LayoutControl3
        Me.cboBANK.TabIndex = 3
        Me.cboBANK.Tag = "bankID,0,1,2"
        '
        'MemoEdit11
        '
        Me.MemoEdit11.Location = New System.Drawing.Point(159, 104)
        Me.MemoEdit11.Margin = New System.Windows.Forms.Padding(4)
        Me.MemoEdit11.Name = "MemoEdit11"
        Me.MemoEdit11.Size = New System.Drawing.Size(1171, 26)
        Me.MemoEdit11.StyleController = Me.LayoutControl3
        Me.MemoEdit11.TabIndex = 4
        Me.MemoEdit11.Tag = "depositor,0,1,2"
        '
        'cboPayType
        '
        Me.cboPayType.Location = New System.Drawing.Point(159, 195)
        Me.cboPayType.Margin = New System.Windows.Forms.Padding(4)
        Me.cboPayType.Name = "cboPayType"
        Me.cboPayType.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Search), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Clear)})
        Me.cboPayType.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 31, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("code", "code", 49, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("name", "Τύπος Πληρωμής", 55, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("modifiedBy", "modified By", 102, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("modifiedOn", "modified On", 105, DevExpress.Utils.FormatType.DateTime, "d/M/yyyy", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("createdOn", "created On", 97, DevExpress.Utils.FormatType.DateTime, "d/M/yyyy", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("createdBy", "created By", 93, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("RealName", "Real Name", 96, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default])})
        Me.cboPayType.Properties.DataSource = Me.VwPAYTYPESBindingSource
        Me.cboPayType.Properties.DisplayMember = "name"
        Me.cboPayType.Properties.NullText = ""
        Me.cboPayType.Properties.PopupSizeable = False
        Me.cboPayType.Properties.ValueMember = "ID"
        Me.cboPayType.Size = New System.Drawing.Size(1171, 26)
        Me.cboPayType.StyleController = Me.LayoutControl3
        Me.cboPayType.TabIndex = 6
        Me.cboPayType.Tag = "PayTypeID,0,1,2"
        '
        'txtamtD
        '
        Me.txtamtD.EditValue = "0,00 €"
        Me.txtamtD.Location = New System.Drawing.Point(159, 225)
        Me.txtamtD.Margin = New System.Windows.Forms.Padding(4)
        Me.txtamtD.Name = "txtamtD"
        Me.txtamtD.Properties.DisplayFormat.FormatString = "c"
        Me.txtamtD.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtamtD.Properties.EditFormat.FormatString = "n2"
        Me.txtamtD.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtamtD.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtamtD.Properties.MaskSettings.Set("MaskManagerType", GetType(DevExpress.Data.Mask.NumericMaskManager))
        Me.txtamtD.Properties.MaskSettings.Set("mask", "c2")
        Me.txtamtD.Properties.Tag = "BenchExtraPrice"
        Me.txtamtD.Size = New System.Drawing.Size(1171, 26)
        Me.txtamtD.StyleController = Me.LayoutControl3
        Me.txtamtD.TabIndex = 7
        Me.txtamtD.Tag = "amt,0,1,2"
        Me.txtamtD.Visible = False
        '
        'txtCMTD
        '
        Me.txtCMTD.Location = New System.Drawing.Point(159, 255)
        Me.txtCMTD.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCMTD.Name = "txtCMTD"
        Me.txtCMTD.Size = New System.Drawing.Size(1171, 211)
        Me.txtCMTD.StyleController = Me.LayoutControl3
        Me.txtCMTD.TabIndex = 8
        Me.txtCMTD.Tag = "cmt,0,1,2"
        '
        'cboCUSD
        '
        Me.cboCUSD.Location = New System.Drawing.Point(159, 165)
        Me.cboCUSD.Margin = New System.Windows.Forms.Padding(4)
        Me.cboCUSD.Name = "cboCUSD"
        Me.cboCUSD.Properties.AllowMouseWheel = False
        Me.cboCUSD.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.cboCUSD.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Search), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Clear)})
        Me.cboCUSD.Properties.NullText = ""
        Me.cboCUSD.Properties.PopupSizeable = False
        Me.cboCUSD.Size = New System.Drawing.Size(1171, 26)
        Me.cboCUSD.StyleController = Me.LayoutControl3
        Me.cboCUSD.TabIndex = 6
        Me.cboCUSD.Tag = "cusID,0,1,2"
        '
        'LayoutControlGroup2
        '
        Me.LayoutControlGroup2.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup2.GroupBordersVisible = False
        Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem7, Me.LayoutControlItem6, Me.LayoutControlItem8, Me.LayoutControlItem30, Me.LayoutControlItem17, Me.LayoutControlItem24, Me.LayoutControlItem9, Me.LayoutControlItem10, Me.LayoutControlItem3, Me.EmptySpaceItem1, Me.LayoutControlItem11, Me.EmptySpaceItem2, Me.lCusD})
        Me.LayoutControlGroup2.Name = "Root"
        Me.LayoutControlGroup2.Size = New System.Drawing.Size(1342, 1205)
        Me.LayoutControlGroup2.TextVisible = False
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.Control = Me.dtPay
        Me.LayoutControlItem7.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem7.CustomizationFormText = "Ημερ/νία"
        Me.LayoutControlItem7.ImageOptions.Image = CType(resources.GetObject("LayoutControlItem7.ImageOptions.Image"), System.Drawing.Image)
        Me.LayoutControlItem7.Location = New System.Drawing.Point(0, 32)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(1322, 30)
        Me.LayoutControlItem7.Tag = "1"
        Me.LayoutControlItem7.Text = "Ημερ/νία"
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(135, 19)
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.txtCodeD
        Me.LayoutControlItem6.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem6.CustomizationFormText = "Κωδικός"
        Me.LayoutControlItem6.HighlightFocusedItem = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlItem6.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(282, 32)
        Me.LayoutControlItem6.Text = "Κωδικός"
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(135, 19)
        '
        'LayoutControlItem8
        '
        Me.LayoutControlItem8.Control = Me.cboBANK
        Me.LayoutControlItem8.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem8.CustomizationFormText = "Τράπεζα"
        Me.LayoutControlItem8.HighlightFocusedItem = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlItem8.Location = New System.Drawing.Point(0, 62)
        Me.LayoutControlItem8.Name = "LayoutControlItem8"
        Me.LayoutControlItem8.Size = New System.Drawing.Size(1322, 30)
        Me.LayoutControlItem8.Text = "Τράπεζα"
        Me.LayoutControlItem8.TextSize = New System.Drawing.Size(135, 19)
        '
        'LayoutControlItem30
        '
        Me.LayoutControlItem30.Control = Me.MemoEdit11
        Me.LayoutControlItem30.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem30.CustomizationFormText = "Καταθέτης"
        Me.LayoutControlItem30.Location = New System.Drawing.Point(0, 92)
        Me.LayoutControlItem30.Name = "LayoutControlItem30"
        Me.LayoutControlItem30.Size = New System.Drawing.Size(1322, 30)
        Me.LayoutControlItem30.Text = "Καταθέτης"
        Me.LayoutControlItem30.TextSize = New System.Drawing.Size(135, 19)
        '
        'LayoutControlItem17
        '
        Me.LayoutControlItem17.Control = Me.chkCash
        Me.LayoutControlItem17.Location = New System.Drawing.Point(0, 122)
        Me.LayoutControlItem17.Name = "LayoutControlItem17"
        Me.LayoutControlItem17.Size = New System.Drawing.Size(1322, 31)
        Me.LayoutControlItem17.Text = "Μετρητά"
        Me.LayoutControlItem17.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem17.TextVisible = False
        '
        'LayoutControlItem24
        '
        Me.LayoutControlItem24.Control = Me.cboPayType
        Me.LayoutControlItem24.ImageOptions.Image = Global.DreamyKitchenCRM.My.Resources.Resources.rsz_11rsz_asterisk
        Me.LayoutControlItem24.Location = New System.Drawing.Point(0, 183)
        Me.LayoutControlItem24.Name = "LayoutControlItem24"
        Me.LayoutControlItem24.Size = New System.Drawing.Size(1322, 30)
        Me.LayoutControlItem24.Tag = "1"
        Me.LayoutControlItem24.Text = "Τύπος Πληρωμής"
        Me.LayoutControlItem24.TextSize = New System.Drawing.Size(135, 19)
        '
        'LayoutControlItem9
        '
        Me.LayoutControlItem9.Control = Me.txtamtD
        Me.LayoutControlItem9.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem9.CustomizationFormText = "Ποσό"
        Me.LayoutControlItem9.HighlightFocusedItem = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlItem9.ImageOptions.Image = CType(resources.GetObject("LayoutControlItem9.ImageOptions.Image"), System.Drawing.Image)
        Me.LayoutControlItem9.Location = New System.Drawing.Point(0, 213)
        Me.LayoutControlItem9.Name = "LayoutControlItem9"
        Me.LayoutControlItem9.Size = New System.Drawing.Size(1322, 30)
        Me.LayoutControlItem9.Tag = "1"
        Me.LayoutControlItem9.Text = "Ποσό"
        Me.LayoutControlItem9.TextSize = New System.Drawing.Size(135, 19)
        '
        'LayoutControlItem10
        '
        Me.LayoutControlItem10.Control = Me.txtCMTD
        Me.LayoutControlItem10.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem10.CustomizationFormText = "Σχόλια"
        Me.LayoutControlItem10.HighlightFocusedItem = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlItem10.Location = New System.Drawing.Point(0, 243)
        Me.LayoutControlItem10.MinSize = New System.Drawing.Size(169, 127)
        Me.LayoutControlItem10.Name = "LayoutControlItem10"
        Me.LayoutControlItem10.Size = New System.Drawing.Size(1322, 215)
        Me.LayoutControlItem10.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem10.Text = "Σχόλια"
        Me.LayoutControlItem10.TextSize = New System.Drawing.Size(135, 19)
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.GridControl1
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 494)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(1322, 691)
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem3.TextVisible = False
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(282, 0)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(1040, 32)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem11
        '
        Me.LayoutControlItem11.Control = Me.cmdSaveTransD
        Me.LayoutControlItem11.Location = New System.Drawing.Point(1102, 458)
        Me.LayoutControlItem11.Name = "LayoutControlItem11"
        Me.LayoutControlItem11.Size = New System.Drawing.Size(220, 36)
        Me.LayoutControlItem11.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem11.TextVisible = False
        '
        'EmptySpaceItem2
        '
        Me.EmptySpaceItem2.AllowHotTrack = False
        Me.EmptySpaceItem2.Location = New System.Drawing.Point(0, 458)
        Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Size = New System.Drawing.Size(1102, 36)
        Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
        '
        'lCusD
        '
        Me.lCusD.Control = Me.cboCUSD
        Me.lCusD.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.lCusD.CustomizationFormText = "Περιοχή"
        Me.lCusD.HighlightFocusedItem = DevExpress.Utils.DefaultBoolean.[True]
        Me.lCusD.Location = New System.Drawing.Point(0, 153)
        Me.lCusD.Name = "lCusD"
        Me.lCusD.Size = New System.Drawing.Size(1322, 30)
        Me.lCusD.Text = "Πελάτης"
        Me.lCusD.TextSize = New System.Drawing.Size(135, 19)
        '
        'TabNavigationPage3
        '
        Me.TabNavigationPage3.Caption = "Αρχεία"
        Me.TabNavigationPage3.Controls.Add(Me.LayoutControl4)
        Me.TabNavigationPage3.Name = "TabNavigationPage3"
        Me.TabNavigationPage3.Properties.AppearanceCaption.BorderColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Warning
        Me.TabNavigationPage3.Properties.AppearanceCaption.Options.UseBorderColor = True
        Me.TabNavigationPage3.Size = New System.Drawing.Size(1342, 1205)
        '
        'LayoutControl4
        '
        Me.LayoutControl4.Controls.Add(Me.cmdSaveTransF)
        Me.LayoutControl4.Controls.Add(Me.GridControl2)
        Me.LayoutControl4.Controls.Add(Me.txtFiles)
        Me.LayoutControl4.Controls.Add(Me.cboTanshFCategory)
        Me.LayoutControl4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl4.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl4.Name = "LayoutControl4"
        Me.LayoutControl4.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(2210, 1039, 1137, 700)
        Me.LayoutControl4.Root = Me.LayoutControlGroup5
        Me.LayoutControl4.Size = New System.Drawing.Size(1342, 1205)
        Me.LayoutControl4.TabIndex = 0
        Me.LayoutControl4.Text = "LayoutControl4"
        '
        'cmdSaveTransF
        '
        Me.cmdSaveTransF.ImageOptions.Image = Global.DreamyKitchenCRM.My.Resources.Resources.icons8_save_close_24
        Me.cmdSaveTransF.Location = New System.Drawing.Point(1150, 72)
        Me.cmdSaveTransF.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdSaveTransF.Name = "cmdSaveTransF"
        Me.cmdSaveTransF.Size = New System.Drawing.Size(180, 32)
        Me.cmdSaveTransF.StyleController = Me.LayoutControl4
        Me.cmdSaveTransF.TabIndex = 67
        Me.cmdSaveTransF.Text = "Αποθήκευση"
        '
        'GridControl2
        '
        Me.GridControl2.DataSource = Me.TRANSHFBindingSource
        Me.GridControl2.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(4)
        Me.GridControl2.Location = New System.Drawing.Point(12, 108)
        Me.GridControl2.MainView = Me.GridView2
        Me.GridControl2.Margin = New System.Windows.Forms.Padding(4)
        Me.GridControl2.Name = "GridControl2"
        Me.GridControl2.Size = New System.Drawing.Size(1318, 1085)
        Me.GridControl2.TabIndex = 65
        Me.GridControl2.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2})
        '
        'TRANSHFBindingSource
        '
        Me.TRANSHFBindingSource.DataMember = "TRANSH_F"
        Me.TRANSHFBindingSource.DataSource = Me.DM_TRANS
        '
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colID1, Me.colcode, Me.coltranshID1, Me.colfilename, Me.colcomefrom, Me.colextension, Me.colmodifiedBy, Me.colmodifiedOn1, Me.colcreatedOn1, Me.colcreatedBy})
        Me.GridView2.DetailHeight = 525
        Me.GridView2.GridControl = Me.GridControl2
        Me.GridView2.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsBehavior.Editable = False
        Me.GridView2.OptionsEditForm.PopupEditFormWidth = 720
        Me.GridView2.OptionsView.ColumnAutoWidth = False
        Me.GridView2.OptionsView.ShowGroupPanel = False
        '
        'colID1
        '
        Me.colID1.FieldName = "ID"
        Me.colID1.MinWidth = 31
        Me.colID1.Name = "colID1"
        Me.colID1.Visible = True
        Me.colID1.VisibleIndex = 0
        Me.colID1.Width = 118
        '
        'colcode
        '
        Me.colcode.FieldName = "code"
        Me.colcode.MinWidth = 31
        Me.colcode.Name = "colcode"
        Me.colcode.Visible = True
        Me.colcode.VisibleIndex = 1
        Me.colcode.Width = 118
        '
        'coltranshID1
        '
        Me.coltranshID1.FieldName = "transhID"
        Me.coltranshID1.MinWidth = 31
        Me.coltranshID1.Name = "coltranshID1"
        Me.coltranshID1.Visible = True
        Me.coltranshID1.VisibleIndex = 2
        Me.coltranshID1.Width = 118
        '
        'colfilename
        '
        Me.colfilename.FieldName = "filename"
        Me.colfilename.MinWidth = 31
        Me.colfilename.Name = "colfilename"
        Me.colfilename.Visible = True
        Me.colfilename.VisibleIndex = 3
        Me.colfilename.Width = 118
        '
        'colcomefrom
        '
        Me.colcomefrom.FieldName = "comefrom"
        Me.colcomefrom.MinWidth = 31
        Me.colcomefrom.Name = "colcomefrom"
        Me.colcomefrom.Visible = True
        Me.colcomefrom.VisibleIndex = 4
        Me.colcomefrom.Width = 118
        '
        'colextension
        '
        Me.colextension.FieldName = "extension"
        Me.colextension.MinWidth = 31
        Me.colextension.Name = "colextension"
        Me.colextension.Visible = True
        Me.colextension.VisibleIndex = 5
        Me.colextension.Width = 118
        '
        'colmodifiedBy
        '
        Me.colmodifiedBy.FieldName = "modifiedBy"
        Me.colmodifiedBy.MinWidth = 31
        Me.colmodifiedBy.Name = "colmodifiedBy"
        Me.colmodifiedBy.Visible = True
        Me.colmodifiedBy.VisibleIndex = 6
        Me.colmodifiedBy.Width = 118
        '
        'colmodifiedOn1
        '
        Me.colmodifiedOn1.FieldName = "modifiedOn"
        Me.colmodifiedOn1.MinWidth = 31
        Me.colmodifiedOn1.Name = "colmodifiedOn1"
        Me.colmodifiedOn1.Visible = True
        Me.colmodifiedOn1.VisibleIndex = 7
        Me.colmodifiedOn1.Width = 118
        '
        'colcreatedOn1
        '
        Me.colcreatedOn1.FieldName = "createdOn"
        Me.colcreatedOn1.MinWidth = 31
        Me.colcreatedOn1.Name = "colcreatedOn1"
        Me.colcreatedOn1.Visible = True
        Me.colcreatedOn1.VisibleIndex = 8
        Me.colcreatedOn1.Width = 118
        '
        'colcreatedBy
        '
        Me.colcreatedBy.FieldName = "createdBy"
        Me.colcreatedBy.MinWidth = 31
        Me.colcreatedBy.Name = "colcreatedBy"
        Me.colcreatedBy.Visible = True
        Me.colcreatedBy.VisibleIndex = 9
        Me.colcreatedBy.Width = 118
        '
        'txtFiles
        '
        Me.txtFiles.Location = New System.Drawing.Point(109, 12)
        Me.txtFiles.Margin = New System.Windows.Forms.Padding(4)
        Me.txtFiles.Name = "txtFiles"
        Me.txtFiles.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        EditorButtonImageOptions1.Image = Global.DreamyKitchenCRM.My.Resources.Resources.icons8_scanner_16
        Me.txtFiles.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, EditorButtonImageOptions1, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, SerializableAppearanceObject2, SerializableAppearanceObject3, SerializableAppearanceObject4, "", Nothing, Nothing, DevExpress.Utils.ToolTipAnchor.[Default]), New DevExpress.XtraEditors.Controls.EditorButton(), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete)})
        Me.txtFiles.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.txtFiles.Size = New System.Drawing.Size(1221, 26)
        Me.txtFiles.StyleController = Me.LayoutControl4
        Me.txtFiles.TabIndex = 6
        Me.txtFiles.Tag = ""
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
        Me.cboTanshFCategory.Size = New System.Drawing.Size(1221, 26)
        Me.cboTanshFCategory.StyleController = Me.LayoutControl4
        Me.cboTanshFCategory.TabIndex = 6
        Me.cboTanshFCategory.Tag = "fileCatID,0,1,2"
        '
        'VwFILECATBindingSource
        '
        Me.VwFILECATBindingSource.DataMember = "vw_FILE_CAT"
        Me.VwFILECATBindingSource.DataSource = Me.DreamyKitchenDataSet
        '
        'LayoutControlGroup5
        '
        Me.LayoutControlGroup5.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup5.GroupBordersVisible = False
        Me.LayoutControlGroup5.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem12, Me.LayoutControlItem16, Me.LayoutControlItem41, Me.LayoutControlItem42, Me.EmptySpaceItem3})
        Me.LayoutControlGroup5.Name = "Root"
        Me.LayoutControlGroup5.Size = New System.Drawing.Size(1342, 1205)
        Me.LayoutControlGroup5.TextVisible = False
        '
        'LayoutControlItem12
        '
        Me.LayoutControlItem12.Control = Me.txtFiles
        Me.LayoutControlItem12.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem12.CustomizationFormText = "Αρχεία"
        Me.LayoutControlItem12.HighlightFocusedItem = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlItem12.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem12.Name = "LayoutControlItem12"
        Me.LayoutControlItem12.Size = New System.Drawing.Size(1322, 30)
        Me.LayoutControlItem12.Text = "Αρχεία"
        Me.LayoutControlItem12.TextSize = New System.Drawing.Size(85, 19)
        '
        'LayoutControlItem16
        '
        Me.LayoutControlItem16.Control = Me.GridControl2
        Me.LayoutControlItem16.Location = New System.Drawing.Point(0, 96)
        Me.LayoutControlItem16.Name = "LayoutControlItem16"
        Me.LayoutControlItem16.Size = New System.Drawing.Size(1322, 1089)
        Me.LayoutControlItem16.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem16.TextVisible = False
        '
        'LayoutControlItem41
        '
        Me.LayoutControlItem41.Control = Me.cboTanshFCategory
        Me.LayoutControlItem41.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem41.CustomizationFormText = "Κατηγορία"
        Me.LayoutControlItem41.HighlightFocusedItem = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlItem41.ImageOptions.Image = Global.DreamyKitchenCRM.My.Resources.Resources.rsz_11rsz_asterisk
        Me.LayoutControlItem41.Location = New System.Drawing.Point(0, 30)
        Me.LayoutControlItem41.Name = "LayoutControlItem41"
        Me.LayoutControlItem41.Size = New System.Drawing.Size(1322, 30)
        Me.LayoutControlItem41.Tag = "1"
        Me.LayoutControlItem41.Text = "Κατηγορία"
        Me.LayoutControlItem41.TextSize = New System.Drawing.Size(85, 19)
        '
        'LayoutControlItem42
        '
        Me.LayoutControlItem42.Control = Me.cmdSaveTransF
        Me.LayoutControlItem42.Location = New System.Drawing.Point(1138, 60)
        Me.LayoutControlItem42.Name = "LayoutControlItem42"
        Me.LayoutControlItem42.Size = New System.Drawing.Size(184, 36)
        Me.LayoutControlItem42.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem42.TextVisible = False
        '
        'EmptySpaceItem3
        '
        Me.EmptySpaceItem3.AllowHotTrack = False
        Me.EmptySpaceItem3.Location = New System.Drawing.Point(0, 60)
        Me.EmptySpaceItem3.Name = "EmptySpaceItem3"
        Me.EmptySpaceItem3.Size = New System.Drawing.Size(1138, 36)
        Me.EmptySpaceItem3.TextSize = New System.Drawing.Size(0, 0)
        '
        'TabNavigationPage4
        '
        Me.TabNavigationPage4.Caption = "TabNavigationPage4"
        Me.TabNavigationPage4.Controls.Add(Me.LayoutControl5)
        Me.TabNavigationPage4.Name = "TabNavigationPage4"
        Me.TabNavigationPage4.PageText = "Εξτρά Χρεώσεις"
        Me.TabNavigationPage4.Size = New System.Drawing.Size(1342, 1205)
        '
        'LayoutControl5
        '
        Me.LayoutControl5.Controls.Add(Me.GridControl3)
        Me.LayoutControl5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl5.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl5.Name = "LayoutControl5"
        Me.LayoutControl5.Root = Me.LayoutControlGroup6
        Me.LayoutControl5.Size = New System.Drawing.Size(1342, 1205)
        Me.LayoutControl5.TabIndex = 0
        Me.LayoutControl5.Text = "LayoutControl5"
        '
        'GridControl3
        '
        Me.GridControl3.DataSource = Me.VwTRANSEXTRACHARGESBindingSource
        Me.GridControl3.EmbeddedNavigator.Buttons.EndEdit.Visible = False
        Me.GridControl3.EmbeddedNavigator.Buttons.First.Visible = False
        Me.GridControl3.EmbeddedNavigator.Buttons.Last.Visible = False
        Me.GridControl3.EmbeddedNavigator.Buttons.Next.Visible = False
        Me.GridControl3.EmbeddedNavigator.Buttons.NextPage.Visible = False
        Me.GridControl3.EmbeddedNavigator.Buttons.Prev.Visible = False
        Me.GridControl3.EmbeddedNavigator.Buttons.PrevPage.Visible = False
        Me.GridControl3.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(2)
        Me.GridControl3.EmbeddedNavigator.TextStringFormat = "Εγγραφή {0} of {1}"
        Me.GridControl3.Location = New System.Drawing.Point(12, 12)
        Me.GridControl3.MainView = Me.GridView3
        Me.GridControl3.Name = "GridControl3"
        Me.GridControl3.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemAmt})
        Me.GridControl3.Size = New System.Drawing.Size(1318, 1181)
        Me.GridControl3.TabIndex = 0
        Me.GridControl3.UseEmbeddedNavigator = True
        Me.GridControl3.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView3})
        '
        'VwTRANSEXTRACHARGESBindingSource
        '
        Me.VwTRANSEXTRACHARGESBindingSource.DataMember = "vw_TRANS_EXTRA_CHARGES"
        Me.VwTRANSEXTRACHARGESBindingSource.DataSource = Me.DM_TRANS
        '
        'GridView3
        '
        Me.GridView3.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colID2, Me.colcode1, Me.colname, Me.colamt1, Me.coltranshID2, Me.colmodifiedBy1, Me.colmodifiedOn2, Me.colcreatedOn2, Me.colcreatedBy1, Me.colRealName1})
        Me.GridView3.DetailHeight = 297
        Me.GridView3.GridControl = Me.GridControl3
        Me.GridView3.Name = "GridView3"
        Me.GridView3.OptionsEditForm.PopupEditFormWidth = 720
        Me.GridView3.OptionsMenu.ShowFooterItem = True
        Me.GridView3.OptionsView.ShowFooter = True
        Me.GridView3.OptionsView.ShowGroupPanel = False
        '
        'colID2
        '
        Me.colID2.FieldName = "ID"
        Me.colID2.MinWidth = 31
        Me.colID2.Name = "colID2"
        Me.colID2.Width = 118
        '
        'colcode1
        '
        Me.colcode1.FieldName = "code"
        Me.colcode1.MinWidth = 31
        Me.colcode1.Name = "colcode1"
        Me.colcode1.Width = 118
        '
        'colname
        '
        Me.colname.Caption = "Περιγραφή"
        Me.colname.FieldName = "name"
        Me.colname.MinWidth = 31
        Me.colname.Name = "colname"
        Me.colname.Visible = True
        Me.colname.VisibleIndex = 0
        Me.colname.Width = 118
        '
        'colamt1
        '
        Me.colamt1.Caption = "Κόστος"
        Me.colamt1.ColumnEdit = Me.RepositoryItemAmt
        Me.colamt1.DisplayFormat.FormatString = "{0:n2}€"
        Me.colamt1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colamt1.FieldName = "amt"
        Me.colamt1.MinWidth = 31
        Me.colamt1.Name = "colamt1"
        Me.colamt1.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "amt", "Σύνολο={0:n2}€")})
        Me.colamt1.Visible = True
        Me.colamt1.VisibleIndex = 1
        Me.colamt1.Width = 118
        '
        'RepositoryItemAmt
        '
        Me.RepositoryItemAmt.AutoHeight = False
        Me.RepositoryItemAmt.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.RepositoryItemAmt.EditFormat.FormatString = "c"
        Me.RepositoryItemAmt.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.RepositoryItemAmt.HideSelection = False
        Me.RepositoryItemAmt.MaskSettings.Set("MaskManagerType", GetType(DevExpress.Data.Mask.NumericMaskManager))
        Me.RepositoryItemAmt.MaskSettings.Set("MaskManagerSignature", "allowNull=False")
        Me.RepositoryItemAmt.MaskSettings.Set("mask", "c")
        Me.RepositoryItemAmt.Name = "RepositoryItemAmt"
        Me.RepositoryItemAmt.NullText = "0,00"
        Me.RepositoryItemAmt.UseMaskAsDisplayFormat = True
        '
        'coltranshID2
        '
        Me.coltranshID2.FieldName = "transhID"
        Me.coltranshID2.MinWidth = 31
        Me.coltranshID2.Name = "coltranshID2"
        Me.coltranshID2.Width = 118
        '
        'colmodifiedBy1
        '
        Me.colmodifiedBy1.FieldName = "modifiedBy"
        Me.colmodifiedBy1.MinWidth = 31
        Me.colmodifiedBy1.Name = "colmodifiedBy1"
        Me.colmodifiedBy1.Width = 118
        '
        'colmodifiedOn2
        '
        Me.colmodifiedOn2.FieldName = "modifiedOn"
        Me.colmodifiedOn2.MinWidth = 31
        Me.colmodifiedOn2.Name = "colmodifiedOn2"
        Me.colmodifiedOn2.Width = 118
        '
        'colcreatedOn2
        '
        Me.colcreatedOn2.FieldName = "createdOn"
        Me.colcreatedOn2.MinWidth = 31
        Me.colcreatedOn2.Name = "colcreatedOn2"
        Me.colcreatedOn2.Width = 118
        '
        'colcreatedBy1
        '
        Me.colcreatedBy1.FieldName = "createdBy"
        Me.colcreatedBy1.MinWidth = 31
        Me.colcreatedBy1.Name = "colcreatedBy1"
        Me.colcreatedBy1.Width = 118
        '
        'colRealName1
        '
        Me.colRealName1.FieldName = "RealName"
        Me.colRealName1.MinWidth = 31
        Me.colRealName1.Name = "colRealName1"
        Me.colRealName1.Width = 118
        '
        'LayoutControlGroup6
        '
        Me.LayoutControlGroup6.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup6.GroupBordersVisible = False
        Me.LayoutControlGroup6.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem43})
        Me.LayoutControlGroup6.Name = "LayoutControlGroup6"
        Me.LayoutControlGroup6.Size = New System.Drawing.Size(1342, 1205)
        Me.LayoutControlGroup6.TextVisible = False
        '
        'LayoutControlItem43
        '
        Me.LayoutControlItem43.Control = Me.GridControl3
        Me.LayoutControlItem43.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem43.Name = "LayoutControlItem43"
        Me.LayoutControlItem43.Size = New System.Drawing.Size(1322, 1185)
        Me.LayoutControlItem43.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem43.TextVisible = False
        '
        'cmdExit
        '
        Me.cmdExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdExit.ImageOptions.Image = Global.DreamyKitchenCRM.My.Resources.Resources.icons8_exit_24
        Me.cmdExit.Location = New System.Drawing.Point(1174, 1270)
        Me.cmdExit.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(180, 32)
        Me.cmdExit.StyleController = Me.LayoutControl1
        Me.cmdExit.TabIndex = 47
        Me.cmdExit.Text = "Έξοδος"
        '
        'txtBal
        '
        Me.txtBal.EditValue = "0,00 €"
        Me.txtBal.Location = New System.Drawing.Point(969, 1270)
        Me.txtBal.Margin = New System.Windows.Forms.Padding(4)
        Me.txtBal.Name = "txtBal"
        Me.txtBal.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.txtBal.Properties.Appearance.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.txtBal.Properties.Appearance.Options.UseFont = True
        Me.txtBal.Properties.Appearance.Options.UseForeColor = True
        Me.txtBal.Properties.DisplayFormat.FormatString = "c"
        Me.txtBal.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtBal.Properties.EditFormat.FormatString = "n2"
        Me.txtBal.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtBal.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtBal.Properties.MaskSettings.Set("MaskManagerType", GetType(DevExpress.Data.Mask.NumericMaskManager))
        Me.txtBal.Properties.MaskSettings.Set("mask", "c2")
        Me.txtBal.Properties.ReadOnly = True
        Me.txtBal.Properties.Tag = "OfferPrice"
        Me.txtBal.Size = New System.Drawing.Size(201, 30)
        Me.txtBal.StyleController = Me.LayoutControl1
        Me.txtBal.TabIndex = 42
        Me.txtBal.Tag = ""
        '
        'Root
        '
        Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.Root.GroupBordersVisible = False
        Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem29, Me.LayoutControlItem31, Me.LayoutControlItem27, Me.EmptySpaceItem4})
        Me.Root.Name = "Root"
        Me.Root.Size = New System.Drawing.Size(1366, 1314)
        Me.Root.TextVisible = False
        '
        'LayoutControlItem29
        '
        Me.LayoutControlItem29.Control = Me.TabPane1
        Me.LayoutControlItem29.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem29.Name = "LayoutControlItem29"
        Me.LayoutControlItem29.Size = New System.Drawing.Size(1346, 1258)
        Me.LayoutControlItem29.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem29.TextVisible = False
        '
        'LayoutControlItem31
        '
        Me.LayoutControlItem31.Control = Me.cmdExit
        Me.LayoutControlItem31.Location = New System.Drawing.Point(1162, 1258)
        Me.LayoutControlItem31.Name = "LayoutControlItem31"
        Me.LayoutControlItem31.Size = New System.Drawing.Size(184, 36)
        Me.LayoutControlItem31.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem31.TextVisible = False
        '
        'LayoutControlItem27
        '
        Me.LayoutControlItem27.AppearanceItemCaption.BackColor = System.Drawing.Color.Maroon
        Me.LayoutControlItem27.AppearanceItemCaption.BackColor2 = System.Drawing.Color.Maroon
        Me.LayoutControlItem27.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.LayoutControlItem27.AppearanceItemCaption.ForeColor = System.Drawing.Color.White
        Me.LayoutControlItem27.AppearanceItemCaption.Options.UseBackColor = True
        Me.LayoutControlItem27.AppearanceItemCaption.Options.UseFont = True
        Me.LayoutControlItem27.AppearanceItemCaption.Options.UseForeColor = True
        Me.LayoutControlItem27.Control = Me.txtBal
        Me.LayoutControlItem27.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem27.CustomizationFormText = "Υπόλοιπο"
        Me.LayoutControlItem27.HighlightFocusedItem = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlItem27.Location = New System.Drawing.Point(859, 1258)
        Me.LayoutControlItem27.Name = "LayoutControlItem27"
        Me.LayoutControlItem27.Size = New System.Drawing.Size(303, 36)
        Me.LayoutControlItem27.Text = "Υπόλοιπο"
        Me.LayoutControlItem27.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
        Me.LayoutControlItem27.TextSize = New System.Drawing.Size(93, 24)
        Me.LayoutControlItem27.TextToControlDistance = 5
        '
        'EmptySpaceItem4
        '
        Me.EmptySpaceItem4.AllowHotTrack = False
        Me.EmptySpaceItem4.Location = New System.Drawing.Point(0, 1258)
        Me.EmptySpaceItem4.Name = "EmptySpaceItem4"
        Me.EmptySpaceItem4.Size = New System.Drawing.Size(859, 36)
        Me.EmptySpaceItem4.TextSize = New System.Drawing.Size(0, 0)
        '
        'VwTRANSDBindingSource
        '
        Me.VwTRANSDBindingSource.DataMember = "vw_TRANSD"
        Me.VwTRANSDBindingSource.DataSource = Me.DM_TRANS
        '
        'Vw_BANKSTableAdapter
        '
        Me.Vw_BANKSTableAdapter.ClearBeforeFill = True
        '
        'XtraOpenFileDialog1
        '
        Me.XtraOpenFileDialog1.Multiselect = True
        Me.XtraOpenFileDialog1.Title = "Επιλογή αρχείων"
        '
        'Vw_INVTYPESTableAdapter
        '
        Me.Vw_INVTYPESTableAdapter.ClearBeforeFill = True
        '
        'VwSCANFILENAMESBindingSource
        '
        Me.VwSCANFILENAMESBindingSource.DataMember = "vw_SCAN_FILE_NAMES"
        Me.VwSCANFILENAMESBindingSource.DataSource = Me.DreamyKitchenDataSet
        '
        'Vw_SCAN_FILE_NAMESTableAdapter
        '
        Me.Vw_SCAN_FILE_NAMESTableAdapter.ClearBeforeFill = True
        '
        'DreamyKitchenDataSet2
        '
        Me.DreamyKitchenDataSet2.DataSetName = "DreamyKitchenDataSet"
        Me.DreamyKitchenDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TRANSH_FTableAdapter
        '
        Me.TRANSH_FTableAdapter.ClearBeforeFill = True
        '
        'Vw_TRANSDTableAdapter
        '
        Me.Vw_TRANSDTableAdapter.ClearBeforeFill = True
        '
        'Vw_TRANSH_CTableAdapter
        '
        Me.Vw_TRANSH_CTableAdapter.ClearBeforeFill = True
        '
        'Vw_PAYTYPESTableAdapter
        '
        Me.Vw_PAYTYPESTableAdapter.ClearBeforeFill = True
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar1})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.bbEMP_T, Me.BBProjectCosts, Me.BBInstallations, Me.BBCctOrdersKitchen, Me.BBCctOrdersDoor, Me.BBCctOrdersCloset, Me.BBCctOrdersSC, Me.BBAgreement, Me.BarWorkspaceMenuItem1})
        Me.BarManager1.MaxItemId = 9
        '
        'Bar1
        '
        Me.Bar1.BarName = "Tools"
        Me.Bar1.DockCol = 0
        Me.Bar1.DockRow = 0
        Me.Bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Left
        Me.Bar1.FloatLocation = New System.Drawing.Point(51, 368)
        Me.Bar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.bbEMP_T), New DevExpress.XtraBars.LinkPersistInfo(Me.BBProjectCosts), New DevExpress.XtraBars.LinkPersistInfo(Me.BBInstallations), New DevExpress.XtraBars.LinkPersistInfo(Me.BBCctOrdersKitchen), New DevExpress.XtraBars.LinkPersistInfo(Me.BBCctOrdersCloset), New DevExpress.XtraBars.LinkPersistInfo(Me.BBCctOrdersDoor), New DevExpress.XtraBars.LinkPersistInfo(Me.BBCctOrdersSC), New DevExpress.XtraBars.LinkPersistInfo(Me.BBAgreement)})
        Me.Bar1.Offset = 15
        Me.Bar1.Text = "Tools"
        '
        'bbEMP_T
        '
        Me.bbEMP_T.Caption = "Τζίροι - Ποσοστά Έκθεσης"
        Me.bbEMP_T.Id = 0
        Me.bbEMP_T.ImageOptions.Image = Global.DreamyKitchenCRM.My.Resources.Resources.icons8_businessman_24
        Me.bbEMP_T.Name = "bbEMP_T"
        '
        'BBProjectCosts
        '
        Me.BBProjectCosts.Caption = "Ανάλυση Έργου"
        Me.BBProjectCosts.Id = 1
        Me.BBProjectCosts.ImageOptions.Image = Global.DreamyKitchenCRM.My.Resources.Resources.icons8_group_of_projects_24
        Me.BBProjectCosts.Name = "BBProjectCosts"
        '
        'BBInstallations
        '
        Me.BBInstallations.Caption = "Μισθοδοσία Τοποθετών"
        Me.BBInstallations.Id = 2
        Me.BBInstallations.ImageOptions.Image = CType(resources.GetObject("BBInstallations.ImageOptions.Image"), System.Drawing.Image)
        Me.BBInstallations.Name = "BBInstallations"
        '
        'BBCctOrdersKitchen
        '
        Me.BBCctOrdersKitchen.Caption = "Παραγγελία Κουζίνας"
        Me.BBCctOrdersKitchen.Id = 3
        Me.BBCctOrdersKitchen.ImageOptions.Image = Global.DreamyKitchenCRM.My.Resources.Resources.icons8_order_24
        Me.BBCctOrdersKitchen.Name = "BBCctOrdersKitchen"
        '
        'BBCctOrdersCloset
        '
        Me.BBCctOrdersCloset.Caption = "Παραγγελία Ντουλάπας"
        Me.BBCctOrdersCloset.Id = 5
        Me.BBCctOrdersCloset.ImageOptions.Image = Global.DreamyKitchenCRM.My.Resources.Resources.icons8_order_24
        Me.BBCctOrdersCloset.Name = "BBCctOrdersCloset"
        '
        'BBCctOrdersDoor
        '
        Me.BBCctOrdersDoor.Caption = "Παραγγελία Πόρτας"
        Me.BBCctOrdersDoor.Id = 4
        Me.BBCctOrdersDoor.ImageOptions.Image = Global.DreamyKitchenCRM.My.Resources.Resources.icons8_order_24
        Me.BBCctOrdersDoor.Name = "BBCctOrdersDoor"
        '
        'BBCctOrdersSC
        '
        Me.BBCctOrdersSC.Caption = "Παραγγελία Ειδ. Κατασκευών"
        Me.BBCctOrdersSC.Id = 6
        Me.BBCctOrdersSC.ImageOptions.Image = Global.DreamyKitchenCRM.My.Resources.Resources.icons8_order_24
        Me.BBCctOrdersSC.Name = "BBCctOrdersSC"
        '
        'BBAgreement
        '
        Me.BBAgreement.Caption = "Ιδ. Συμφωνητικό"
        Me.BBAgreement.Id = 7
        Me.BBAgreement.ImageOptions.Image = Global.DreamyKitchenCRM.My.Resources.Resources.icons8_agreement_24
        Me.BBAgreement.Name = "BBAgreement"
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Manager = Me.BarManager1
        Me.barDockControlTop.Size = New System.Drawing.Size(1416, 0)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 1314)
        Me.barDockControlBottom.Manager = Me.BarManager1
        Me.barDockControlBottom.Size = New System.Drawing.Size(1416, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlLeft.Manager = Me.BarManager1
        Me.barDockControlLeft.Size = New System.Drawing.Size(50, 1314)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(1416, 0)
        Me.barDockControlRight.Manager = Me.BarManager1
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 1314)
        '
        'BarWorkspaceMenuItem1
        '
        Me.BarWorkspaceMenuItem1.Caption = "BarWorkspaceMenuItem1"
        Me.BarWorkspaceMenuItem1.Id = 8
        Me.BarWorkspaceMenuItem1.Name = "BarWorkspaceMenuItem1"
        Me.BarWorkspaceMenuItem1.WorkspaceManager = Me.WorkspaceManager1
        '
        'WorkspaceManager1
        '
        Me.WorkspaceManager1.TargetControl = Me
        Me.WorkspaceManager1.TransitionType = PushTransition1
        '
        'Vw_TRANS_EXTRA_CHARGESTableAdapter
        '
        Me.Vw_TRANS_EXTRA_CHARGESTableAdapter.ClearBeforeFill = True
        '
        'Vw_FILE_CATTableAdapter
        '
        Me.Vw_FILE_CATTableAdapter.ClearBeforeFill = True
        '
        'VwCCTBindingSource
        '
        Me.VwCCTBindingSource.DataMember = "vw_CCT"
        Me.VwCCTBindingSource.DataSource = Me.DreamyKitchenDataSet
        '
        'Vw_CCTTableAdapter
        '
        Me.Vw_CCTTableAdapter.ClearBeforeFill = True
        '
        'CCT_TRANSHTableAdapter
        '
        Me.CCT_TRANSHTableAdapter.ClearBeforeFill = True
        '
        'Vw_COMPTableAdapter
        '
        Me.Vw_COMPTableAdapter.ClearBeforeFill = True
        '
        'Vw_TRANSD_CreditTableAdapter
        '
        Me.Vw_TRANSD_CreditTableAdapter.ClearBeforeFill = True
        '
        'Vw_TRANSD_DebitTableAdapter
        '
        Me.Vw_TRANSD_DebitTableAdapter.ClearBeforeFill = True
        '
        'COMP_CCT_TRANSHTableAdapter
        '
        Me.COMP_CCT_TRANSHTableAdapter.ClearBeforeFill = True
        '
        'BarButtonItem6
        '
        Me.BarButtonItem6.Caption = "BarButtonItem1"
        Me.BarButtonItem6.Id = 3
        Me.BarButtonItem6.Name = "BarButtonItem6"
        '
        'Vw_TRANSHTableAdapter
        '
        Me.Vw_TRANSHTableAdapter.ClearBeforeFill = True
        '
        'frmTransactions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(144.0!, 144.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1416, 1314)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.IconOptions.Image = Global.DreamyKitchenCRM.My.Resources.Resources.favicon
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmTransactions"
        Me.Text = "Έργο"
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.TabPane1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPane1.ResumeLayout(False)
        Me.TabNavigationPage1.ResumeLayout(False)
        CType(Me.LayoutControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl2.ResumeLayout(False)
        CType(Me.LayoutControl7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl7.ResumeLayout(False)
        CType(Me.chkcompProject.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboCompany.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VwCOMPBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DM_CCT, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkreceiveDateAgreement.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkwaitingForAgreement.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkofferCusAcceptance.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboTransC.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VwTRANSHCBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DM_TRANS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodeH.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboSaler.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboCOU.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboAREAS.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboADR.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MemoEdit12.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboCompProject.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboCUS.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtCharge.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtCharge.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit1.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtreceiveDateAgreement.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtreceiveDateAgreement.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtComments.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem20, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem32, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem33, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LComp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LCompProject, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LCUS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem38, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem40, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem44, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem55, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem54, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem19, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem34, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem35, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem56, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TabPane2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPane2.ResumeLayout(False)
        Me.TabNavigationPage5.ResumeLayout(False)
        CType(Me.LayoutControl6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl6.ResumeLayout(False)
        CType(Me.cboInvoiceType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VwINVTYPESBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DreamyKitchenDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDevicesCost.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtbenchPurchasePrice.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtbenchSalesPrice.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtbenchProfit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtExtraCost.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTotAmt.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAmtH.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtVatAmt.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem22, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem48, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem49, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem50, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem28, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem51, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem45, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem26, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabNavigationPage6.ResumeLayout(False)
        CType(Me.GridControl4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VwTRANSDDebitBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemBanks, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VwBANKSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemPayTypes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VwPAYTYPESBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCctTransh, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.COMPCCTTRANSHBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCusTranshID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VwTRANSHBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkCompleted.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem25, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem47, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem23, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem52, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LPrintCompOffer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabNavigationPage2.ResumeLayout(False)
        CType(Me.LayoutControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl3.ResumeLayout(False)
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VwTRANSDCreditBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCCT, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CCTTRANSHBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkCash.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtPay.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtPay.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodeD.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboBANK.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MemoEdit11.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboPayType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtamtD.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCMTD.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboCUSD.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem30, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem17, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem24, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lCusD, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabNavigationPage3.ResumeLayout(False)
        CType(Me.LayoutControl4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl4.ResumeLayout(False)
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TRANSHFBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFiles.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboTanshFCategory.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VwFILECATBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem41, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem42, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabNavigationPage4.ResumeLayout(False)
        CType(Me.LayoutControl5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl5.ResumeLayout(False)
        CType(Me.GridControl3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VwTRANSEXTRACHARGESBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemAmt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem43, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtBal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem29, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem31, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem27, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VwTRANSDBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VwSCANFILENAMESBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DreamyKitchenDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VwCCTBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents Root As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents cmdExit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents DreamyKitchenDataSet As DreamyKitchenDataSet
    Friend WithEvents VwTRANSDBindingSource As BindingSource
    Friend WithEvents VwBANKSBindingSource As BindingSource
    Friend WithEvents Vw_BANKSTableAdapter As DreamyKitchenDataSetTableAdapters.vw_BANKSTableAdapter
    Friend WithEvents txtBal As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem27 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents XtraOpenFileDialog1 As DevExpress.XtraEditors.XtraOpenFileDialog
    Friend WithEvents VwINVTYPESBindingSource As BindingSource
    Friend WithEvents Vw_INVTYPESTableAdapter As DreamyKitchenDataSetTableAdapters.vw_INVTYPESTableAdapter
    Friend WithEvents VwSCANFILENAMESBindingSource As BindingSource
    Friend WithEvents Vw_SCAN_FILE_NAMESTableAdapter As DreamyKitchenDataSetTableAdapters.vw_SCAN_FILE_NAMESTableAdapter
    Friend WithEvents cboPayType As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents DreamyKitchenDataSet2 As DreamyKitchenDataSet
    Friend WithEvents TRANSHFBindingSource As BindingSource
    Friend WithEvents DM_TRANS As DM_TRANS
    Friend WithEvents TRANSH_FTableAdapter As DM_TRANSTableAdapters.TRANSH_FTableAdapter
    Friend WithEvents Vw_TRANSDTableAdapter As DM_TRANSTableAdapters.vw_TRANSDTableAdapter
    Friend WithEvents VwTRANSHCBindingSource As BindingSource
    Friend WithEvents Vw_TRANSH_CTableAdapter As DM_TRANSTableAdapters.vw_TRANSH_CTableAdapter
    Friend WithEvents VwPAYTYPESBindingSource As BindingSource
    Friend WithEvents Vw_PAYTYPESTableAdapter As DM_TRANSTableAdapters.vw_PAYTYPESTableAdapter
    Friend WithEvents LayoutControlItem31 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar1 As DevExpress.XtraBars.Bar
    Friend WithEvents bbEMP_T As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BBProjectCosts As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents TabPane1 As DevExpress.XtraBars.Navigation.TabPane
    Friend WithEvents TabNavigationPage1 As DevExpress.XtraBars.Navigation.TabNavigationPage
    Friend WithEvents LayoutControl2 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents TabNavigationPage2 As DevExpress.XtraBars.Navigation.TabNavigationPage
    Friend WithEvents LayoutControlItem29 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents dtCharge As DevExpress.XtraEditors.DateEdit
    Friend WithEvents txtDevicesCost As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtExtraCost As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtTotAmt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControl3 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents chkCash As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents dtPay As DevExpress.XtraEditors.DateEdit
    Friend WithEvents txtCodeD As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cboBANK As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents MemoEdit11 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem30 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem17 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem24 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents txtamtD As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents chkCompleted As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents cmdSaveTransH As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdPrintAll As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem25 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem23 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coltranshID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colbankID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents colBankName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colcash As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colamt As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colcmt As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldtPay As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRealName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colmodifiedOn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colcreatedOn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPayTypeID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemLookUpEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents colpaid As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldepositor As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cmdSaveTransD As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtCMTD As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LayoutControlItem10 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem11 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem4 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents BBInstallations As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents EmptySpaceItem5 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LayoutControlGroup4 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents TabNavigationPage3 As DevExpress.XtraBars.Navigation.TabNavigationPage
    Friend WithEvents LayoutControl4 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup5 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents GridControl2 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colID1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colcode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coltranshID1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colfilename As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colcomefrom As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colextension As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colmodifiedBy As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colmodifiedOn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colcreatedOn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colcreatedBy As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtFiles As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents LayoutControlItem12 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem16 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents TabNavigationPage4 As DevExpress.XtraBars.Navigation.TabNavigationPage
    Friend WithEvents LayoutControl5 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup6 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents cboTanshFCategory As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LayoutControlItem41 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents cmdSaveTransF As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem42 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem3 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents GridControl3 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LayoutControlItem43 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents VwTRANSEXTRACHARGESBindingSource As BindingSource
    Friend WithEvents colID2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colcode1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colname As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colamt1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coltranshID2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colmodifiedBy1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colmodifiedOn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colcreatedOn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colcreatedBy1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRealName1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Vw_TRANS_EXTRA_CHARGESTableAdapter As DM_TRANSTableAdapters.vw_TRANS_EXTRA_CHARGESTableAdapter
    Friend WithEvents RepositoryItemAmt As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents VwFILECATBindingSource As BindingSource
    Friend WithEvents Vw_FILE_CATTableAdapter As DreamyKitchenDataSetTableAdapters.vw_FILE_CATTableAdapter
    Friend WithEvents cboCUSD As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lCusD As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents RepositoryItemCCT As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents VwCCTBindingSource As BindingSource
    Friend WithEvents Vw_CCTTableAdapter As DreamyKitchenDataSetTableAdapters.vw_CCTTableAdapter
    Friend WithEvents CCTTRANSHBindingSource As BindingSource
    Friend WithEvents CCT_TRANSHTableAdapter As DM_TRANSTableAdapters.CCT_TRANSHTableAdapter
    Friend WithEvents colcusID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DM_CCT As DM_CCT
    Friend WithEvents VwCOMPBindingSource As BindingSource
    Friend WithEvents Vw_COMPTableAdapter As DM_CCTTableAdapters.vw_COMPTableAdapter
    Friend WithEvents TabPane2 As DevExpress.XtraBars.Navigation.TabPane
    Friend WithEvents TabNavigationPage5 As DevExpress.XtraBars.Navigation.TabNavigationPage
    Friend WithEvents LayoutControl6 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup7 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents TabNavigationPage6 As DevExpress.XtraBars.Navigation.TabNavigationPage
    Friend WithEvents LayoutControlItem47 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem22 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem36 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem28 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem13 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem15 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem18 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem37 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents txtbenchPurchasePrice As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtbenchSalesPrice As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtbenchProfit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem48 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem49 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem50 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents txtAmtH As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem51 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents cboInvoiceType As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents txtVatAmt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem45 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem26 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents GridControl4 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView4 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemBanks As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn9 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn10 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn11 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn12 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemPayTypes As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents GridColumn13 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn14 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn15 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCctTransh As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents LayoutControl7 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup8 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem52 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem46 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem39 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents txtCodeH As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cboSaler As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents cboTransC As DevExpress.XtraEditors.CheckedComboBoxEdit
    Friend WithEvents cboCOU As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents cboAREAS As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents cboADR As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents MemoEdit12 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cboCompProject As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents cboCUS As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents DateEdit1 As DevExpress.XtraEditors.DateEdit
    Friend WithEvents chkreceiveDateAgreement As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkwaitingForAgreement As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkofferCusAcceptance As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents dtreceiveDateAgreement As DevExpress.XtraEditors.DateEdit
    Friend WithEvents cboCompany As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents txtComments As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LayoutControlItem20 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem19 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem32 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem33 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem34 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem35 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LComp As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LCompProject As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LCUS As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem54 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem38 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem40 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem44 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem55 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem14 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem6 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents VwTRANSDDebitBindingSource As BindingSource
    Friend WithEvents VwTRANSDCreditBindingSource As BindingSource
    Friend WithEvents Vw_TRANSD_CreditTableAdapter As DM_TRANSTableAdapters.vw_TRANSD_CreditTableAdapter
    Friend WithEvents Vw_TRANSD_DebitTableAdapter As DM_TRANSTableAdapters.vw_TRANSD_DebitTableAdapter
    Friend WithEvents chkcompProject As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents LayoutControlItem56 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents cmdPrintCompOffer As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LPrintCompOffer As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents COMPCCTTRANSHBindingSource As BindingSource
    Friend WithEvents COMP_CCT_TRANSHTableAdapter As DM_TRANSTableAdapters.COMP_CCT_TRANSHTableAdapter
    Friend WithEvents BBCctOrdersKitchen As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BBCctOrdersDoor As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BBCctOrdersCloset As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BBCctOrdersSC As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BBAgreement As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem6 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents colcustranshid As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCusTranshID As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents VwTRANSHBindingSource As BindingSource
    Friend WithEvents Vw_TRANSHTableAdapter As DM_TRANSTableAdapters.vw_TRANSHTableAdapter
    Friend WithEvents BarWorkspaceMenuItem1 As DevExpress.XtraBars.BarWorkspaceMenuItem
    Friend WithEvents WorkspaceManager1 As DevExpress.Utils.WorkspaceManager
End Class
