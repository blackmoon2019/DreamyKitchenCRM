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
        Dim EditorButtonImageOptions1 As DevExpress.XtraEditors.Controls.EditorButtonImageOptions = New DevExpress.XtraEditors.Controls.EditorButtonImageOptions()
        Dim SerializableAppearanceObject1 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject2 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject3 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject4 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTransactions))
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.cmdExit = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdPrintAll = New DevExpress.XtraEditors.SimpleButton()
        Me.chkCompleted = New DevExpress.XtraEditors.CheckEdit()
        Me.txtEMP_T_ID = New DevExpress.XtraEditors.TextEdit()
        Me.chkCash = New DevExpress.XtraEditors.CheckEdit()
        Me.GridControl2 = New DevExpress.XtraGrid.GridControl()
        Me.TRANSHFBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DM_TRANS = New DreamyKitchenCRM.DM_TRANS()
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
        Me.cmdSaveTransD = New DevExpress.XtraEditors.SimpleButton()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.VwTRANSDBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coltranshID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colbankID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.VwBANKSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DreamyKitchenDataSet = New DreamyKitchenCRM.DreamyKitchenDataSet()
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
        Me.VwPAYTYPESBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.colpaid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coldepositor = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cmdSaveTransH = New DevExpress.XtraEditors.SimpleButton()
        Me.cboCUS = New DevExpress.XtraEditors.LookUpEdit()
        Me.dtCharge = New DevExpress.XtraEditors.DateEdit()
        Me.txtCodeH = New DevExpress.XtraEditors.TextEdit()
        Me.txtComments = New DevExpress.XtraEditors.MemoEdit()
        Me.txtVatAmt = New DevExpress.XtraEditors.TextEdit()
        Me.txtCodeD = New DevExpress.XtraEditors.TextEdit()
        Me.dtPay = New DevExpress.XtraEditors.DateEdit()
        Me.txtamtD = New DevExpress.XtraEditors.TextEdit()
        Me.txtCMTD = New DevExpress.XtraEditors.MemoEdit()
        Me.cboBANK = New DevExpress.XtraEditors.LookUpEdit()
        Me.txtInvoiceFilename = New DevExpress.XtraEditors.ButtonEdit()
        Me.txtTotAmt = New DevExpress.XtraEditors.TextEdit()
        Me.txtAmtH = New DevExpress.XtraEditors.TextEdit()
        Me.txtBal = New DevExpress.XtraEditors.TextEdit()
        Me.cboInvoiceType = New DevExpress.XtraEditors.LookUpEdit()
        Me.VwINVTYPESBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.cboSaler = New DevExpress.XtraEditors.LookUpEdit()
        Me.txtDebitCost = New DevExpress.XtraEditors.TextEdit()
        Me.txtDevicesCost = New DevExpress.XtraEditors.TextEdit()
        Me.cboPayType = New DevExpress.XtraEditors.LookUpEdit()
        Me.txtExtraCost = New DevExpress.XtraEditors.TextEdit()
        Me.cboTransC = New DevExpress.XtraEditors.CheckedComboBoxEdit()
        Me.VwTRANSHCBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MemoEdit1 = New DevExpress.XtraEditors.TextEdit()
        Me.MemoEdit11 = New DevExpress.XtraEditors.TextEdit()
        Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem3 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem45 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem15 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem13 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem18 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem26 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem19 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem20 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem21 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem22 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem5 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem23 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem25 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem28 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem12 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem16 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem14 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem29 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem10 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem11 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem4 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem17 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem24 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem30 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem27 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem7 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem31 = New DevExpress.XtraLayout.LayoutControlItem()
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
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.chkCompleted.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEMP_T_ID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkCash.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TRANSHFBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DM_TRANS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VwTRANSDBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VwBANKSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DreamyKitchenDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VwPAYTYPESBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboCUS.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtCharge.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtCharge.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodeH.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtComments.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtVatAmt.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodeD.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtPay.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtPay.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtamtD.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCMTD.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboBANK.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtInvoiceFilename.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTotAmt.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAmtH.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtBal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboInvoiceType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VwINVTYPESBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboSaler.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDebitCost.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDevicesCost.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboPayType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtExtraCost.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboTransC.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VwTRANSHCBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MemoEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MemoEdit11.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem45, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem18, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem26, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem19, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem20, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem21, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem22, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem23, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem25, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem28, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem29, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem17, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem24, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem30, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem27, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem31, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VwSCANFILENAMESBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DreamyKitchenDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.cmdExit)
        Me.LayoutControl1.Controls.Add(Me.cmdPrintAll)
        Me.LayoutControl1.Controls.Add(Me.chkCompleted)
        Me.LayoutControl1.Controls.Add(Me.txtEMP_T_ID)
        Me.LayoutControl1.Controls.Add(Me.chkCash)
        Me.LayoutControl1.Controls.Add(Me.GridControl2)
        Me.LayoutControl1.Controls.Add(Me.cmdSaveTransD)
        Me.LayoutControl1.Controls.Add(Me.GridControl1)
        Me.LayoutControl1.Controls.Add(Me.cmdSaveTransH)
        Me.LayoutControl1.Controls.Add(Me.cboCUS)
        Me.LayoutControl1.Controls.Add(Me.dtCharge)
        Me.LayoutControl1.Controls.Add(Me.txtCodeH)
        Me.LayoutControl1.Controls.Add(Me.txtComments)
        Me.LayoutControl1.Controls.Add(Me.txtVatAmt)
        Me.LayoutControl1.Controls.Add(Me.txtCodeD)
        Me.LayoutControl1.Controls.Add(Me.dtPay)
        Me.LayoutControl1.Controls.Add(Me.txtamtD)
        Me.LayoutControl1.Controls.Add(Me.txtCMTD)
        Me.LayoutControl1.Controls.Add(Me.cboBANK)
        Me.LayoutControl1.Controls.Add(Me.txtInvoiceFilename)
        Me.LayoutControl1.Controls.Add(Me.txtTotAmt)
        Me.LayoutControl1.Controls.Add(Me.txtAmtH)
        Me.LayoutControl1.Controls.Add(Me.txtBal)
        Me.LayoutControl1.Controls.Add(Me.cboInvoiceType)
        Me.LayoutControl1.Controls.Add(Me.cboSaler)
        Me.LayoutControl1.Controls.Add(Me.txtDebitCost)
        Me.LayoutControl1.Controls.Add(Me.txtDevicesCost)
        Me.LayoutControl1.Controls.Add(Me.cboPayType)
        Me.LayoutControl1.Controls.Add(Me.txtExtraCost)
        Me.LayoutControl1.Controls.Add(Me.cboTransC)
        Me.LayoutControl1.Controls.Add(Me.MemoEdit1)
        Me.LayoutControl1.Controls.Add(Me.MemoEdit11)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(58, 0)
        Me.LayoutControl1.Margin = New System.Windows.Forms.Padding(5)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(1177, 502, 650, 400)
        Me.LayoutControl1.Root = Me.Root
        Me.LayoutControl1.Size = New System.Drawing.Size(1919, 1545)
        Me.LayoutControl1.TabIndex = 0
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'cmdExit
        '
        Me.cmdExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdExit.ImageOptions.Image = Global.DreamyKitchenCRM.My.Resources.Resources.icons8_exit_24
        Me.cmdExit.Location = New System.Drawing.Point(1729, 1491)
        Me.cmdExit.Margin = New System.Windows.Forms.Padding(5)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(178, 39)
        Me.cmdExit.StyleController = Me.LayoutControl1
        Me.cmdExit.TabIndex = 47
        Me.cmdExit.Text = "Έξοδος"
        '
        'cmdPrintAll
        '
        Me.cmdPrintAll.Location = New System.Drawing.Point(490, 1435)
        Me.cmdPrintAll.Margin = New System.Windows.Forms.Padding(5)
        Me.cmdPrintAll.Name = "cmdPrintAll"
        Me.cmdPrintAll.Size = New System.Drawing.Size(235, 39)
        Me.cmdPrintAll.StyleController = Me.LayoutControl1
        Me.cmdPrintAll.TabIndex = 61
        Me.cmdPrintAll.Text = "Έντυπα"
        '
        'chkCompleted
        '
        Me.chkCompleted.EditValue = CType(0, Byte)
        Me.chkCompleted.Location = New System.Drawing.Point(131, 1435)
        Me.chkCompleted.Margin = New System.Windows.Forms.Padding(5)
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
        Me.chkCompleted.Size = New System.Drawing.Size(240, 39)
        Me.chkCompleted.StyleController = Me.LayoutControl1
        Me.chkCompleted.TabIndex = 60
        Me.chkCompleted.Tag = "completed,0,1,2"
        '
        'txtEMP_T_ID
        '
        Me.txtEMP_T_ID.Location = New System.Drawing.Point(25, 1435)
        Me.txtEMP_T_ID.Margin = New System.Windows.Forms.Padding(5)
        Me.txtEMP_T_ID.Name = "txtEMP_T_ID"
        Me.txtEMP_T_ID.Properties.ReadOnly = True
        Me.txtEMP_T_ID.Size = New System.Drawing.Size(92, 38)
        Me.txtEMP_T_ID.StyleController = Me.LayoutControl1
        Me.txtEMP_T_ID.TabIndex = 49
        Me.txtEMP_T_ID.Tag = "EmpTID,0"
        Me.txtEMP_T_ID.Visible = False
        '
        'chkCash
        '
        Me.chkCash.EditValue = CType(0, Byte)
        Me.chkCash.Location = New System.Drawing.Point(954, 229)
        Me.chkCash.Margin = New System.Windows.Forms.Padding(5)
        Me.chkCash.Name = "chkCash"
        Me.chkCash.Properties.Caption = "Μετρητά"
        Me.chkCash.Properties.ValueChecked = CType(1, Byte)
        Me.chkCash.Properties.ValueUnchecked = CType(0, Byte)
        Me.chkCash.Size = New System.Drawing.Size(940, 35)
        Me.chkCash.StyleController = Me.LayoutControl1
        Me.chkCash.TabIndex = 48
        Me.chkCash.Tag = "cash,0,1,2"
        '
        'GridControl2
        '
        Me.GridControl2.DataSource = Me.TRANSHFBindingSource
        Me.GridControl2.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(8, 9, 8, 9)
        Me.GridControl2.Location = New System.Drawing.Point(25, 941)
        Me.GridControl2.MainView = Me.GridView2
        Me.GridControl2.Margin = New System.Windows.Forms.Padding(5)
        Me.GridControl2.Name = "GridControl2"
        Me.GridControl2.Size = New System.Drawing.Size(899, 490)
        Me.GridControl2.TabIndex = 47
        Me.GridControl2.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2})
        '
        'TRANSHFBindingSource
        '
        Me.TRANSHFBindingSource.DataMember = "TRANSH_F"
        Me.TRANSHFBindingSource.DataSource = Me.DM_TRANS
        '
        'DM_TRANS
        '
        Me.DM_TRANS.DataSetName = "DM_TRANS"
        Me.DM_TRANS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colID1, Me.colcode, Me.coltranshID1, Me.colfilename, Me.colcomefrom, Me.colextension, Me.colmodifiedBy, Me.colmodifiedOn1, Me.colcreatedOn1, Me.colcreatedBy})
        Me.GridView2.DetailHeight = 619
        Me.GridView2.GridControl = Me.GridControl2
        Me.GridView2.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsBehavior.Editable = False
        Me.GridView2.OptionsView.ColumnAutoWidth = False
        Me.GridView2.OptionsView.ShowGroupPanel = False
        '
        'colID1
        '
        Me.colID1.FieldName = "ID"
        Me.colID1.MinWidth = 35
        Me.colID1.Name = "colID1"
        Me.colID1.Visible = True
        Me.colID1.VisibleIndex = 0
        Me.colID1.Width = 131
        '
        'colcode
        '
        Me.colcode.FieldName = "code"
        Me.colcode.MinWidth = 35
        Me.colcode.Name = "colcode"
        Me.colcode.Visible = True
        Me.colcode.VisibleIndex = 1
        Me.colcode.Width = 131
        '
        'coltranshID1
        '
        Me.coltranshID1.FieldName = "transhID"
        Me.coltranshID1.MinWidth = 35
        Me.coltranshID1.Name = "coltranshID1"
        Me.coltranshID1.Visible = True
        Me.coltranshID1.VisibleIndex = 2
        Me.coltranshID1.Width = 131
        '
        'colfilename
        '
        Me.colfilename.FieldName = "filename"
        Me.colfilename.MinWidth = 35
        Me.colfilename.Name = "colfilename"
        Me.colfilename.Visible = True
        Me.colfilename.VisibleIndex = 3
        Me.colfilename.Width = 131
        '
        'colcomefrom
        '
        Me.colcomefrom.FieldName = "comefrom"
        Me.colcomefrom.MinWidth = 35
        Me.colcomefrom.Name = "colcomefrom"
        Me.colcomefrom.Visible = True
        Me.colcomefrom.VisibleIndex = 4
        Me.colcomefrom.Width = 131
        '
        'colextension
        '
        Me.colextension.FieldName = "extension"
        Me.colextension.MinWidth = 35
        Me.colextension.Name = "colextension"
        Me.colextension.Visible = True
        Me.colextension.VisibleIndex = 5
        Me.colextension.Width = 131
        '
        'colmodifiedBy
        '
        Me.colmodifiedBy.FieldName = "modifiedBy"
        Me.colmodifiedBy.MinWidth = 35
        Me.colmodifiedBy.Name = "colmodifiedBy"
        Me.colmodifiedBy.Visible = True
        Me.colmodifiedBy.VisibleIndex = 6
        Me.colmodifiedBy.Width = 131
        '
        'colmodifiedOn1
        '
        Me.colmodifiedOn1.FieldName = "modifiedOn"
        Me.colmodifiedOn1.MinWidth = 35
        Me.colmodifiedOn1.Name = "colmodifiedOn1"
        Me.colmodifiedOn1.Visible = True
        Me.colmodifiedOn1.VisibleIndex = 7
        Me.colmodifiedOn1.Width = 131
        '
        'colcreatedOn1
        '
        Me.colcreatedOn1.FieldName = "createdOn"
        Me.colcreatedOn1.MinWidth = 35
        Me.colcreatedOn1.Name = "colcreatedOn1"
        Me.colcreatedOn1.Visible = True
        Me.colcreatedOn1.VisibleIndex = 8
        Me.colcreatedOn1.Width = 131
        '
        'colcreatedBy
        '
        Me.colcreatedBy.FieldName = "createdBy"
        Me.colcreatedBy.MinWidth = 35
        Me.colcreatedBy.Name = "colcreatedBy"
        Me.colcreatedBy.Visible = True
        Me.colcreatedBy.VisibleIndex = 9
        Me.colcreatedBy.Width = 131
        '
        'cmdSaveTransD
        '
        Me.cmdSaveTransD.ImageOptions.Image = Global.DreamyKitchenCRM.My.Resources.Resources.icons8_save_close_24
        Me.cmdSaveTransD.Location = New System.Drawing.Point(1736, 771)
        Me.cmdSaveTransD.Margin = New System.Windows.Forms.Padding(5)
        Me.cmdSaveTransD.Name = "cmdSaveTransD"
        Me.cmdSaveTransD.Size = New System.Drawing.Size(158, 39)
        Me.cmdSaveTransD.StyleController = Me.LayoutControl1
        Me.cmdSaveTransD.TabIndex = 46
        Me.cmdSaveTransD.Text = "Αποθήκευση"
        '
        'GridControl1
        '
        Me.GridControl1.DataSource = Me.VwTRANSDBindingSource
        Me.GridControl1.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(8, 9, 8, 9)
        Me.GridControl1.Location = New System.Drawing.Point(941, 827)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Margin = New System.Windows.Forms.Padding(5)
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemLookUpEdit1, Me.RepositoryItemLookUpEdit2})
        Me.GridControl1.Size = New System.Drawing.Size(966, 660)
        Me.GridControl1.TabIndex = 45
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'VwTRANSDBindingSource
        '
        Me.VwTRANSDBindingSource.DataMember = "vw_TRANSD"
        Me.VwTRANSDBindingSource.DataSource = Me.DM_TRANS
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colID, Me.coltranshID, Me.colbankID, Me.colBankName, Me.colcash, Me.colamt, Me.colcmt, Me.coldtPay, Me.colRealName, Me.colmodifiedOn, Me.colcreatedOn, Me.colPayTypeID, Me.colpaid, Me.coldepositor})
        Me.GridView1.DetailHeight = 619
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "amt", Me.colamt, " Σύνολο {0:n2}€")})
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsMenu.ShowConditionalFormattingItem = True
        Me.GridView1.OptionsView.EnableAppearanceEvenRow = True
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.OptionsView.ShowGroupedColumns = True
        '
        'colID
        '
        Me.colID.FieldName = "ID"
        Me.colID.MinWidth = 33
        Me.colID.Name = "colID"
        Me.colID.Width = 125
        '
        'coltranshID
        '
        Me.coltranshID.FieldName = "transhID"
        Me.coltranshID.MinWidth = 33
        Me.coltranshID.Name = "coltranshID"
        Me.coltranshID.Width = 125
        '
        'colbankID
        '
        Me.colbankID.Caption = "Τράπεζα"
        Me.colbankID.ColumnEdit = Me.RepositoryItemLookUpEdit1
        Me.colbankID.FieldName = "bankID"
        Me.colbankID.MinWidth = 33
        Me.colbankID.Name = "colbankID"
        Me.colbankID.Visible = True
        Me.colbankID.VisibleIndex = 3
        Me.colbankID.Width = 117
        '
        'RepositoryItemLookUpEdit1
        '
        Me.RepositoryItemLookUpEdit1.AutoHeight = False
        Me.RepositoryItemLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Clear)})
        Me.RepositoryItemLookUpEdit1.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("RealName", "Real Name", 100, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 33, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("code", "code", 53, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("name", "name", 58, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("modifiedBy", "modified By", 107, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("modifiedOn", "modified On", 110, DevExpress.Utils.FormatType.DateTime, "d/M/yyyy", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("createdOn", "created On", 105, DevExpress.Utils.FormatType.DateTime, "d/M/yyyy", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("createdBy", "created By", 102, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default])})
        Me.RepositoryItemLookUpEdit1.DataSource = Me.VwBANKSBindingSource
        Me.RepositoryItemLookUpEdit1.DisplayMember = "name"
        Me.RepositoryItemLookUpEdit1.Name = "RepositoryItemLookUpEdit1"
        Me.RepositoryItemLookUpEdit1.NullText = ""
        Me.RepositoryItemLookUpEdit1.ValueMember = "ID"
        '
        'VwBANKSBindingSource
        '
        Me.VwBANKSBindingSource.DataMember = "vw_BANKS"
        Me.VwBANKSBindingSource.DataSource = Me.DreamyKitchenDataSet
        '
        'DreamyKitchenDataSet
        '
        Me.DreamyKitchenDataSet.DataSetName = "DreamyKitchenDataSet"
        Me.DreamyKitchenDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'colBankName
        '
        Me.colBankName.Caption = "Τράπεζα"
        Me.colBankName.FieldName = "BankName"
        Me.colBankName.MinWidth = 33
        Me.colBankName.Name = "colBankName"
        Me.colBankName.Width = 542
        '
        'colcash
        '
        Me.colcash.Caption = "Μετρητά"
        Me.colcash.FieldName = "cash"
        Me.colcash.MinWidth = 33
        Me.colcash.Name = "colcash"
        Me.colcash.Visible = True
        Me.colcash.VisibleIndex = 2
        Me.colcash.Width = 204
        '
        'colamt
        '
        Me.colamt.Caption = "Ποσό"
        Me.colamt.DisplayFormat.FormatString = "{0:n2}€"
        Me.colamt.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colamt.FieldName = "amt"
        Me.colamt.MinWidth = 33
        Me.colamt.Name = "colamt"
        Me.colamt.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "amt", " Σύνολο {0:n2}€")})
        Me.colamt.Visible = True
        Me.colamt.VisibleIndex = 1
        Me.colamt.Width = 241
        '
        'colcmt
        '
        Me.colcmt.Caption = "Σχόλια"
        Me.colcmt.FieldName = "cmt"
        Me.colcmt.MinWidth = 33
        Me.colcmt.Name = "colcmt"
        Me.colcmt.Visible = True
        Me.colcmt.VisibleIndex = 5
        Me.colcmt.Width = 872
        '
        'coldtPay
        '
        Me.coldtPay.Caption = "Ημερομηνία"
        Me.coldtPay.FieldName = "dtPay"
        Me.coldtPay.MinWidth = 33
        Me.coldtPay.Name = "coldtPay"
        Me.coldtPay.Visible = True
        Me.coldtPay.VisibleIndex = 0
        Me.coldtPay.Width = 196
        '
        'colRealName
        '
        Me.colRealName.Caption = "Ενημερώθηκε από"
        Me.colRealName.FieldName = "RealName"
        Me.colRealName.MinWidth = 33
        Me.colRealName.Name = "colRealName"
        Me.colRealName.Width = 125
        '
        'colmodifiedOn
        '
        Me.colmodifiedOn.FieldName = "modifiedOn"
        Me.colmodifiedOn.MinWidth = 33
        Me.colmodifiedOn.Name = "colmodifiedOn"
        Me.colmodifiedOn.Width = 125
        '
        'colcreatedOn
        '
        Me.colcreatedOn.FieldName = "createdOn"
        Me.colcreatedOn.MinWidth = 33
        Me.colcreatedOn.Name = "colcreatedOn"
        Me.colcreatedOn.Width = 125
        '
        'colPayTypeID
        '
        Me.colPayTypeID.Caption = "Τύπος Πληρωμής"
        Me.colPayTypeID.ColumnEdit = Me.RepositoryItemLookUpEdit2
        Me.colPayTypeID.FieldName = "PayTypeID"
        Me.colPayTypeID.MinWidth = 35
        Me.colPayTypeID.Name = "colPayTypeID"
        Me.colPayTypeID.Visible = True
        Me.colPayTypeID.VisibleIndex = 6
        Me.colPayTypeID.Width = 131
        '
        'RepositoryItemLookUpEdit2
        '
        Me.RepositoryItemLookUpEdit2.AutoHeight = False
        Me.RepositoryItemLookUpEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit2.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 35, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("code", "code", 55, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("name", "Τύπος Πληρωμής", 62, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("modifiedBy", "modified By", 113, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("modifiedOn", "modified On", 117, DevExpress.Utils.FormatType.DateTime, "d/M/yyyy", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("createdOn", "created On", 108, DevExpress.Utils.FormatType.DateTime, "d/M/yyyy", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("createdBy", "created By", 104, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("RealName", "Real Name", 106, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default])})
        Me.RepositoryItemLookUpEdit2.DataSource = Me.VwPAYTYPESBindingSource
        Me.RepositoryItemLookUpEdit2.DisplayMember = "name"
        Me.RepositoryItemLookUpEdit2.Name = "RepositoryItemLookUpEdit2"
        Me.RepositoryItemLookUpEdit2.NullText = ""
        Me.RepositoryItemLookUpEdit2.ValueMember = "ID"
        '
        'VwPAYTYPESBindingSource
        '
        Me.VwPAYTYPESBindingSource.DataMember = "vw_PAYTYPES"
        Me.VwPAYTYPESBindingSource.DataSource = Me.DM_TRANS
        '
        'colpaid
        '
        Me.colpaid.Caption = "Πληρώθηκε"
        Me.colpaid.FieldName = "paid"
        Me.colpaid.MinWidth = 35
        Me.colpaid.Name = "colpaid"
        Me.colpaid.Visible = True
        Me.colpaid.VisibleIndex = 4
        Me.colpaid.Width = 131
        '
        'coldepositor
        '
        Me.coldepositor.Caption = "Καταθέτης"
        Me.coldepositor.FieldName = "depositor"
        Me.coldepositor.MinWidth = 35
        Me.coldepositor.Name = "coldepositor"
        Me.coldepositor.Visible = True
        Me.coldepositor.VisibleIndex = 7
        Me.coldepositor.Width = 131
        '
        'cmdSaveTransH
        '
        Me.cmdSaveTransH.ImageOptions.Image = Global.DreamyKitchenCRM.My.Resources.Resources.icons8_save_close_24
        Me.cmdSaveTransH.Location = New System.Drawing.Point(729, 1435)
        Me.cmdSaveTransH.Margin = New System.Windows.Forms.Padding(5)
        Me.cmdSaveTransH.Name = "cmdSaveTransH"
        Me.cmdSaveTransH.Size = New System.Drawing.Size(195, 39)
        Me.cmdSaveTransH.StyleController = Me.LayoutControl1
        Me.cmdSaveTransH.TabIndex = 43
        Me.cmdSaveTransH.Text = "Αποθήκευση"
        '
        'cboCUS
        '
        Me.cboCUS.Location = New System.Drawing.Point(249, 229)
        Me.cboCUS.Margin = New System.Windows.Forms.Padding(5)
        Me.cboCUS.Name = "cboCUS"
        Me.cboCUS.Properties.AllowMouseWheel = False
        Me.cboCUS.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.cboCUS.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Search), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Clear)})
        Me.cboCUS.Properties.NullText = ""
        Me.cboCUS.Properties.PopupSizeable = False
        Me.cboCUS.Size = New System.Drawing.Size(675, 38)
        Me.cboCUS.StyleController = Me.LayoutControl1
        Me.cboCUS.TabIndex = 6
        Me.cboCUS.Tag = "cusID,0,1,2"
        '
        'dtCharge
        '
        Me.dtCharge.EditValue = Nothing
        Me.dtCharge.Location = New System.Drawing.Point(249, 271)
        Me.dtCharge.Margin = New System.Windows.Forms.Padding(5)
        Me.dtCharge.Name = "dtCharge"
        Me.dtCharge.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtCharge.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtCharge.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.dtCharge.Size = New System.Drawing.Size(675, 38)
        Me.dtCharge.StyleController = Me.LayoutControl1
        Me.dtCharge.TabIndex = 32
        Me.dtCharge.Tag = "dtCharge,0,1,2"
        '
        'txtCodeH
        '
        Me.txtCodeH.Location = New System.Drawing.Point(249, 61)
        Me.txtCodeH.Margin = New System.Windows.Forms.Padding(5)
        Me.txtCodeH.Name = "txtCodeH"
        Me.txtCodeH.Properties.Appearance.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.txtCodeH.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtCodeH.Properties.Appearance.Options.UseBackColor = True
        Me.txtCodeH.Properties.Appearance.Options.UseFont = True
        Me.txtCodeH.Properties.ReadOnly = True
        Me.txtCodeH.Size = New System.Drawing.Size(142, 38)
        Me.txtCodeH.StyleController = Me.LayoutControl1
        Me.txtCodeH.TabIndex = 4
        Me.txtCodeH.Tag = "code,0"
        '
        'txtComments
        '
        Me.txtComments.Location = New System.Drawing.Point(249, 649)
        Me.txtComments.Margin = New System.Windows.Forms.Padding(5)
        Me.txtComments.Name = "txtComments"
        Me.txtComments.Size = New System.Drawing.Size(675, 288)
        Me.txtComments.StyleController = Me.LayoutControl1
        Me.txtComments.TabIndex = 17
        Me.txtComments.Tag = "cmt,0,1,2"
        '
        'txtVatAmt
        '
        Me.txtVatAmt.EditValue = "0,00 €"
        Me.txtVatAmt.Location = New System.Drawing.Point(249, 565)
        Me.txtVatAmt.Margin = New System.Windows.Forms.Padding(5)
        Me.txtVatAmt.Name = "txtVatAmt"
        Me.txtVatAmt.Properties.DisplayFormat.FormatString = "c"
        Me.txtVatAmt.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtVatAmt.Properties.EditFormat.FormatString = "n2"
        Me.txtVatAmt.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtVatAmt.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtVatAmt.Properties.MaskSettings.Set("MaskManagerType", GetType(DevExpress.Data.Mask.NumericMaskManager))
        Me.txtVatAmt.Properties.MaskSettings.Set("mask", "c2")
        Me.txtVatAmt.Properties.Tag = "BenchExtraPrice"
        Me.txtVatAmt.Size = New System.Drawing.Size(675, 38)
        Me.txtVatAmt.StyleController = Me.LayoutControl1
        Me.txtVatAmt.TabIndex = 42
        Me.txtVatAmt.Tag = "vatamt,0,1,2"
        Me.txtVatAmt.Visible = False
        '
        'txtCodeD
        '
        Me.txtCodeD.Location = New System.Drawing.Point(1178, 61)
        Me.txtCodeD.Margin = New System.Windows.Forms.Padding(5)
        Me.txtCodeD.Name = "txtCodeD"
        Me.txtCodeD.Properties.Appearance.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.txtCodeD.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtCodeD.Properties.Appearance.Options.UseBackColor = True
        Me.txtCodeD.Properties.Appearance.Options.UseFont = True
        Me.txtCodeD.Properties.ReadOnly = True
        Me.txtCodeD.Size = New System.Drawing.Size(150, 38)
        Me.txtCodeD.StyleController = Me.LayoutControl1
        Me.txtCodeD.TabIndex = 4
        Me.txtCodeD.Tag = "code,0"
        '
        'dtPay
        '
        Me.dtPay.EditValue = Nothing
        Me.dtPay.Location = New System.Drawing.Point(1178, 103)
        Me.dtPay.Margin = New System.Windows.Forms.Padding(5)
        Me.dtPay.Name = "dtPay"
        Me.dtPay.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtPay.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtPay.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.dtPay.Size = New System.Drawing.Size(716, 38)
        Me.dtPay.StyleController = Me.LayoutControl1
        Me.dtPay.TabIndex = 32
        Me.dtPay.Tag = "dtPay,0,1,2"
        '
        'txtamtD
        '
        Me.txtamtD.EditValue = "0,00 €"
        Me.txtamtD.Location = New System.Drawing.Point(1178, 310)
        Me.txtamtD.Margin = New System.Windows.Forms.Padding(5)
        Me.txtamtD.Name = "txtamtD"
        Me.txtamtD.Properties.DisplayFormat.FormatString = "c"
        Me.txtamtD.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtamtD.Properties.EditFormat.FormatString = "n2"
        Me.txtamtD.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtamtD.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtamtD.Properties.MaskSettings.Set("MaskManagerType", GetType(DevExpress.Data.Mask.NumericMaskManager))
        Me.txtamtD.Properties.MaskSettings.Set("mask", "c2")
        Me.txtamtD.Properties.Tag = "BenchExtraPrice"
        Me.txtamtD.Size = New System.Drawing.Size(716, 38)
        Me.txtamtD.StyleController = Me.LayoutControl1
        Me.txtamtD.TabIndex = 42
        Me.txtamtD.Tag = "amt,0,1,2"
        Me.txtamtD.Visible = False
        '
        'txtCMTD
        '
        Me.txtCMTD.Location = New System.Drawing.Point(1178, 352)
        Me.txtCMTD.Margin = New System.Windows.Forms.Padding(5)
        Me.txtCMTD.Name = "txtCMTD"
        Me.txtCMTD.Size = New System.Drawing.Size(716, 415)
        Me.txtCMTD.StyleController = Me.LayoutControl1
        Me.txtCMTD.TabIndex = 17
        Me.txtCMTD.Tag = "cmt,0,1,2"
        '
        'cboBANK
        '
        Me.cboBANK.Location = New System.Drawing.Point(1178, 145)
        Me.cboBANK.Margin = New System.Windows.Forms.Padding(5)
        Me.cboBANK.Name = "cboBANK"
        Me.cboBANK.Properties.AllowMouseWheel = False
        Me.cboBANK.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.cboBANK.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Search), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Clear)})
        Me.cboBANK.Properties.NullText = ""
        Me.cboBANK.Properties.PopupSizeable = False
        Me.cboBANK.Size = New System.Drawing.Size(716, 38)
        Me.cboBANK.StyleController = Me.LayoutControl1
        Me.cboBANK.TabIndex = 6
        Me.cboBANK.Tag = "bankID,0,1,2"
        '
        'txtInvoiceFilename
        '
        Me.txtInvoiceFilename.Location = New System.Drawing.Point(249, 607)
        Me.txtInvoiceFilename.Margin = New System.Windows.Forms.Padding(5)
        Me.txtInvoiceFilename.Name = "txtInvoiceFilename"
        Me.txtInvoiceFilename.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        EditorButtonImageOptions1.Image = Global.DreamyKitchenCRM.My.Resources.Resources.icons8_scanner_16
        Me.txtInvoiceFilename.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, EditorButtonImageOptions1, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, SerializableAppearanceObject2, SerializableAppearanceObject3, SerializableAppearanceObject4, "", Nothing, Nothing, DevExpress.Utils.ToolTipAnchor.[Default]), New DevExpress.XtraEditors.Controls.EditorButton(), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete)})
        Me.txtInvoiceFilename.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.txtInvoiceFilename.Size = New System.Drawing.Size(675, 38)
        Me.txtInvoiceFilename.StyleController = Me.LayoutControl1
        Me.txtInvoiceFilename.TabIndex = 6
        Me.txtInvoiceFilename.Tag = ""
        '
        'txtTotAmt
        '
        Me.txtTotAmt.EditValue = "0,00 €"
        Me.txtTotAmt.Location = New System.Drawing.Point(249, 439)
        Me.txtTotAmt.Margin = New System.Windows.Forms.Padding(5)
        Me.txtTotAmt.Name = "txtTotAmt"
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
        Me.txtTotAmt.Size = New System.Drawing.Size(675, 38)
        Me.txtTotAmt.StyleController = Me.LayoutControl1
        Me.txtTotAmt.TabIndex = 42
        Me.txtTotAmt.Tag = "Totamt,0,1,2"
        Me.txtTotAmt.Visible = False
        '
        'txtAmtH
        '
        Me.txtAmtH.EditValue = "0,00 €"
        Me.txtAmtH.Location = New System.Drawing.Point(249, 523)
        Me.txtAmtH.Margin = New System.Windows.Forms.Padding(5)
        Me.txtAmtH.Name = "txtAmtH"
        Me.txtAmtH.Properties.DisplayFormat.FormatString = "c"
        Me.txtAmtH.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtAmtH.Properties.EditFormat.FormatString = "n2"
        Me.txtAmtH.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtAmtH.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtAmtH.Properties.MaskSettings.Set("MaskManagerType", GetType(DevExpress.Data.Mask.NumericMaskManager))
        Me.txtAmtH.Properties.MaskSettings.Set("mask", "c2")
        Me.txtAmtH.Properties.Tag = "BenchExtraPrice"
        Me.txtAmtH.Size = New System.Drawing.Size(675, 38)
        Me.txtAmtH.StyleController = Me.LayoutControl1
        Me.txtAmtH.TabIndex = 42
        Me.txtAmtH.Tag = "amt,0,1,2"
        Me.txtAmtH.Visible = False
        '
        'txtBal
        '
        Me.txtBal.EditValue = "0,00 €"
        Me.txtBal.Location = New System.Drawing.Point(1053, 1491)
        Me.txtBal.Margin = New System.Windows.Forms.Padding(5)
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
        Me.txtBal.Size = New System.Drawing.Size(672, 42)
        Me.txtBal.StyleController = Me.LayoutControl1
        Me.txtBal.TabIndex = 42
        Me.txtBal.Tag = ""
        '
        'cboInvoiceType
        '
        Me.cboInvoiceType.Location = New System.Drawing.Point(249, 481)
        Me.cboInvoiceType.Margin = New System.Windows.Forms.Padding(5)
        Me.cboInvoiceType.Name = "cboInvoiceType"
        Me.cboInvoiceType.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Clear)})
        Me.cboInvoiceType.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("invType", "inv Type", 83, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("invTypeDescr", "ΤΥΠΟΣ ΠΑΡΑΣΤΑΤΙΚΟΥ", 133, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default])})
        Me.cboInvoiceType.Properties.DataSource = Me.VwINVTYPESBindingSource
        Me.cboInvoiceType.Properties.DisplayMember = "invTypeDescr"
        Me.cboInvoiceType.Properties.NullText = ""
        Me.cboInvoiceType.Properties.PopupSizeable = False
        Me.cboInvoiceType.Properties.ValueMember = "invType"
        Me.cboInvoiceType.Size = New System.Drawing.Size(675, 38)
        Me.cboInvoiceType.StyleController = Me.LayoutControl1
        Me.cboInvoiceType.TabIndex = 47
        Me.cboInvoiceType.Tag = "invType,0,1,2"
        '
        'VwINVTYPESBindingSource
        '
        Me.VwINVTYPESBindingSource.DataMember = "vw_INVTYPES"
        Me.VwINVTYPESBindingSource.DataSource = Me.DreamyKitchenDataSet
        '
        'cboSaler
        '
        Me.cboSaler.Location = New System.Drawing.Point(249, 103)
        Me.cboSaler.Margin = New System.Windows.Forms.Padding(5)
        Me.cboSaler.Name = "cboSaler"
        Me.cboSaler.Properties.AllowMouseWheel = False
        Me.cboSaler.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.cboSaler.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Search), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Clear)})
        Me.cboSaler.Properties.NullText = ""
        Me.cboSaler.Properties.PopupSizeable = False
        Me.cboSaler.Size = New System.Drawing.Size(675, 38)
        Me.cboSaler.StyleController = Me.LayoutControl1
        Me.cboSaler.TabIndex = 6
        Me.cboSaler.Tag = "empID,0,1,2"
        '
        'txtDebitCost
        '
        Me.txtDebitCost.EditValue = "0,00 €"
        Me.txtDebitCost.Location = New System.Drawing.Point(249, 313)
        Me.txtDebitCost.Margin = New System.Windows.Forms.Padding(5)
        Me.txtDebitCost.Name = "txtDebitCost"
        Me.txtDebitCost.Properties.DisplayFormat.FormatString = "c"
        Me.txtDebitCost.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtDebitCost.Properties.EditFormat.FormatString = "n2"
        Me.txtDebitCost.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtDebitCost.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtDebitCost.Properties.MaskSettings.Set("MaskManagerType", GetType(DevExpress.Data.Mask.NumericMaskManager))
        Me.txtDebitCost.Properties.MaskSettings.Set("mask", "c2")
        Me.txtDebitCost.Properties.Tag = "BenchExtraPrice"
        Me.txtDebitCost.Size = New System.Drawing.Size(675, 38)
        Me.txtDebitCost.StyleController = Me.LayoutControl1
        Me.txtDebitCost.TabIndex = 42
        Me.txtDebitCost.Tag = "DebitCost,0,1,2"
        Me.txtDebitCost.Visible = False
        '
        'txtDevicesCost
        '
        Me.txtDevicesCost.EditValue = "0,00 €"
        Me.txtDevicesCost.Location = New System.Drawing.Point(249, 355)
        Me.txtDevicesCost.Margin = New System.Windows.Forms.Padding(5)
        Me.txtDevicesCost.Name = "txtDevicesCost"
        Me.txtDevicesCost.Properties.DisplayFormat.FormatString = "c"
        Me.txtDevicesCost.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtDevicesCost.Properties.EditFormat.FormatString = "n2"
        Me.txtDevicesCost.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtDevicesCost.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtDevicesCost.Properties.MaskSettings.Set("MaskManagerType", GetType(DevExpress.Data.Mask.NumericMaskManager))
        Me.txtDevicesCost.Properties.MaskSettings.Set("mask", "c2")
        Me.txtDevicesCost.Properties.Tag = "BenchExtraPrice"
        Me.txtDevicesCost.Size = New System.Drawing.Size(675, 38)
        Me.txtDevicesCost.StyleController = Me.LayoutControl1
        Me.txtDevicesCost.TabIndex = 42
        Me.txtDevicesCost.Tag = "DevicesCost,0,1,2"
        Me.txtDevicesCost.Visible = False
        '
        'cboPayType
        '
        Me.cboPayType.Location = New System.Drawing.Point(1178, 268)
        Me.cboPayType.Margin = New System.Windows.Forms.Padding(5)
        Me.cboPayType.Name = "cboPayType"
        Me.cboPayType.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Search), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Clear)})
        Me.cboPayType.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 35, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("code", "code", 55, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("name", "Τύπος Πληρωμής", 62, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("modifiedBy", "modified By", 113, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("modifiedOn", "modified On", 117, DevExpress.Utils.FormatType.DateTime, "d/M/yyyy", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("createdOn", "created On", 108, DevExpress.Utils.FormatType.DateTime, "d/M/yyyy", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("createdBy", "created By", 104, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("RealName", "Real Name", 106, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default])})
        Me.cboPayType.Properties.DataSource = Me.VwPAYTYPESBindingSource
        Me.cboPayType.Properties.DisplayMember = "name"
        Me.cboPayType.Properties.NullText = ""
        Me.cboPayType.Properties.PopupSizeable = False
        Me.cboPayType.Properties.ValueMember = "ID"
        Me.cboPayType.Size = New System.Drawing.Size(716, 38)
        Me.cboPayType.StyleController = Me.LayoutControl1
        Me.cboPayType.TabIndex = 47
        Me.cboPayType.Tag = "PayTypeID,0,1,2"
        '
        'txtExtraCost
        '
        Me.txtExtraCost.EditValue = "0,00 €"
        Me.txtExtraCost.Location = New System.Drawing.Point(249, 397)
        Me.txtExtraCost.Margin = New System.Windows.Forms.Padding(5)
        Me.txtExtraCost.Name = "txtExtraCost"
        Me.txtExtraCost.Properties.DisplayFormat.FormatString = "c"
        Me.txtExtraCost.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtExtraCost.Properties.EditFormat.FormatString = "n2"
        Me.txtExtraCost.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtExtraCost.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtExtraCost.Properties.MaskSettings.Set("MaskManagerType", GetType(DevExpress.Data.Mask.NumericMaskManager))
        Me.txtExtraCost.Properties.MaskSettings.Set("mask", "c2")
        Me.txtExtraCost.Properties.Tag = "BenchExtraPrice"
        Me.txtExtraCost.Properties.UseReadOnlyAppearance = False
        Me.txtExtraCost.Size = New System.Drawing.Size(675, 38)
        Me.txtExtraCost.StyleController = Me.LayoutControl1
        Me.txtExtraCost.TabIndex = 42
        Me.txtExtraCost.Tag = "extracost,0,1,2"
        Me.txtExtraCost.Visible = False
        '
        'cboTransC
        '
        Me.cboTransC.Location = New System.Drawing.Point(249, 145)
        Me.cboTransC.Margin = New System.Windows.Forms.Padding(5)
        Me.cboTransC.Name = "cboTransC"
        Me.cboTransC.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Clear)})
        Me.cboTransC.Properties.DataSource = Me.VwTRANSHCBindingSource
        Me.cboTransC.Properties.DisplayMember = "name"
        Me.cboTransC.Properties.ValueMember = "ID"
        Me.cboTransC.Size = New System.Drawing.Size(675, 38)
        Me.cboTransC.StyleController = Me.LayoutControl1
        Me.cboTransC.TabIndex = 17
        Me.cboTransC.Tag = ""
        '
        'VwTRANSHCBindingSource
        '
        Me.VwTRANSHCBindingSource.DataMember = "vw_TRANSH_C"
        Me.VwTRANSHCBindingSource.DataSource = Me.DM_TRANS
        '
        'MemoEdit1
        '
        Me.MemoEdit1.Location = New System.Drawing.Point(249, 187)
        Me.MemoEdit1.Margin = New System.Windows.Forms.Padding(5)
        Me.MemoEdit1.Name = "MemoEdit1"
        Me.MemoEdit1.Size = New System.Drawing.Size(675, 38)
        Me.MemoEdit1.StyleController = Me.LayoutControl1
        Me.MemoEdit1.TabIndex = 62
        Me.MemoEdit1.Tag = "description,0,1,2"
        '
        'MemoEdit11
        '
        Me.MemoEdit11.Location = New System.Drawing.Point(1178, 187)
        Me.MemoEdit11.Margin = New System.Windows.Forms.Padding(5)
        Me.MemoEdit11.Name = "MemoEdit11"
        Me.MemoEdit11.Size = New System.Drawing.Size(716, 38)
        Me.MemoEdit11.StyleController = Me.LayoutControl1
        Me.MemoEdit11.TabIndex = 62
        Me.MemoEdit11.Tag = "depositor,0,1,2"
        '
        'Root
        '
        Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.Root.GroupBordersVisible = False
        Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlGroup1, Me.LayoutControlGroup2, Me.LayoutControlItem27, Me.EmptySpaceItem7, Me.LayoutControlItem3, Me.LayoutControlItem31})
        Me.Root.Name = "Root"
        Me.Root.Size = New System.Drawing.Size(1919, 1545)
        Me.Root.TextVisible = False
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.AppearanceGroup.BorderColor = System.Drawing.Color.DarkRed
        Me.LayoutControlGroup1.AppearanceGroup.Options.UseBorderColor = True
        Me.LayoutControlGroup1.AppearanceGroup.Options.UseTextOptions = True
        Me.LayoutControlGroup1.GroupStyle = DevExpress.Utils.GroupStyle.Card
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem4, Me.EmptySpaceItem3, Me.LayoutControlItem2, Me.LayoutControlItem5, Me.LayoutControlItem1, Me.EmptySpaceItem1, Me.LayoutControlItem45, Me.LayoutControlItem15, Me.LayoutControlItem13, Me.LayoutControlItem18, Me.LayoutControlItem26, Me.LayoutControlItem19, Me.LayoutControlItem20, Me.LayoutControlItem21, Me.LayoutControlItem22, Me.EmptySpaceItem5, Me.LayoutControlItem23, Me.LayoutControlItem25, Me.LayoutControlItem28, Me.LayoutControlItem12, Me.LayoutControlItem16, Me.LayoutControlItem14, Me.LayoutControlItem29})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(929, 1479)
        Me.LayoutControlGroup1.Text = "Στοιχεία Χρέωσης"
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.txtCodeH
        Me.LayoutControlItem4.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem4.CustomizationFormText = "Κωδικός"
        Me.LayoutControlItem4.HighlightFocusedItem = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(370, 42)
        Me.LayoutControlItem4.Text = "Κωδικός"
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(212, 23)
        '
        'EmptySpaceItem3
        '
        Me.EmptySpaceItem3.AllowHotTrack = False
        Me.EmptySpaceItem3.Location = New System.Drawing.Point(370, 0)
        Me.EmptySpaceItem3.Name = "EmptySpaceItem3"
        Me.EmptySpaceItem3.Size = New System.Drawing.Size(533, 42)
        Me.EmptySpaceItem3.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.dtCharge
        Me.LayoutControlItem2.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem2.CustomizationFormText = "Ημερ/νία Ολοκλήρωσης"
        Me.LayoutControlItem2.ImageOptions.Image = CType(resources.GetObject("LayoutControlItem2.ImageOptions.Image"), System.Drawing.Image)
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 210)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(903, 42)
        Me.LayoutControlItem2.Tag = "1"
        Me.LayoutControlItem2.Text = "Ημερ/νία "
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(212, 23)
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.cboCUS
        Me.LayoutControlItem5.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem5.CustomizationFormText = "Περιοχή"
        Me.LayoutControlItem5.HighlightFocusedItem = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlItem5.ImageOptions.Image = CType(resources.GetObject("LayoutControlItem5.ImageOptions.Image"), System.Drawing.Image)
        Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 168)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(903, 42)
        Me.LayoutControlItem5.Tag = "1"
        Me.LayoutControlItem5.Text = "Πελάτης"
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(212, 23)
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.cmdSaveTransH
        Me.LayoutControlItem1.Location = New System.Drawing.Point(704, 1374)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(199, 43)
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(96, 1374)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(10, 43)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem45
        '
        Me.LayoutControlItem45.Control = Me.txtVatAmt
        Me.LayoutControlItem45.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem45.CustomizationFormText = "Τελική Αξία"
        Me.LayoutControlItem45.HighlightFocusedItem = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlItem45.Location = New System.Drawing.Point(0, 504)
        Me.LayoutControlItem45.Name = "LayoutControlItem45"
        Me.LayoutControlItem45.Size = New System.Drawing.Size(903, 42)
        Me.LayoutControlItem45.Text = "ΦΠΑ Παραστατικού"
        Me.LayoutControlItem45.TextSize = New System.Drawing.Size(212, 23)
        '
        'LayoutControlItem15
        '
        Me.LayoutControlItem15.Control = Me.txtAmtH
        Me.LayoutControlItem15.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem15.CustomizationFormText = "Τελική Αξία"
        Me.LayoutControlItem15.HighlightFocusedItem = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlItem15.Location = New System.Drawing.Point(0, 462)
        Me.LayoutControlItem15.Name = "LayoutControlItem15"
        Me.LayoutControlItem15.Size = New System.Drawing.Size(903, 42)
        Me.LayoutControlItem15.Text = "Ποσό Παραστατικού"
        Me.LayoutControlItem15.TextSize = New System.Drawing.Size(212, 23)
        '
        'LayoutControlItem13
        '
        Me.LayoutControlItem13.Control = Me.txtTotAmt
        Me.LayoutControlItem13.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem13.CustomizationFormText = "Τελική Αξία"
        Me.LayoutControlItem13.HighlightFocusedItem = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlItem13.ImageOptions.Image = CType(resources.GetObject("LayoutControlItem13.ImageOptions.Image"), System.Drawing.Image)
        Me.LayoutControlItem13.Location = New System.Drawing.Point(0, 378)
        Me.LayoutControlItem13.Name = "LayoutControlItem13"
        Me.LayoutControlItem13.Size = New System.Drawing.Size(903, 42)
        Me.LayoutControlItem13.Tag = "1"
        Me.LayoutControlItem13.Text = "Γενικό Σύνολο Πώλησης"
        Me.LayoutControlItem13.TextSize = New System.Drawing.Size(212, 23)
        '
        'LayoutControlItem18
        '
        Me.LayoutControlItem18.Control = Me.txtEMP_T_ID
        Me.LayoutControlItem18.Location = New System.Drawing.Point(0, 1374)
        Me.LayoutControlItem18.Name = "LayoutControlItem18"
        Me.LayoutControlItem18.Size = New System.Drawing.Size(96, 43)
        Me.LayoutControlItem18.Tag = ""
        Me.LayoutControlItem18.Text = " "
        Me.LayoutControlItem18.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem18.TextVisible = False
        '
        'LayoutControlItem26
        '
        Me.LayoutControlItem26.Control = Me.cboInvoiceType
        Me.LayoutControlItem26.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem26.CustomizationFormText = "Εμφανές Πλαϊνο"
        Me.LayoutControlItem26.ImageOptions.Image = Global.DreamyKitchenCRM.My.Resources.Resources.rsz_11rsz_asterisk
        Me.LayoutControlItem26.Location = New System.Drawing.Point(0, 420)
        Me.LayoutControlItem26.Name = "LayoutControlItem26"
        Me.LayoutControlItem26.Size = New System.Drawing.Size(903, 42)
        Me.LayoutControlItem26.Tag = "1"
        Me.LayoutControlItem26.Text = "Τύπος Παραστατικού"
        Me.LayoutControlItem26.TextSize = New System.Drawing.Size(212, 23)
        '
        'LayoutControlItem19
        '
        Me.LayoutControlItem19.Control = Me.cboTransC
        Me.LayoutControlItem19.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem19.CustomizationFormText = "Σχόλια"
        Me.LayoutControlItem19.HighlightFocusedItem = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlItem19.ImageOptions.Image = Global.DreamyKitchenCRM.My.Resources.Resources.rsz_11rsz_asterisk
        Me.LayoutControlItem19.Location = New System.Drawing.Point(0, 84)
        Me.LayoutControlItem19.Name = "LayoutControlItem19"
        Me.LayoutControlItem19.Size = New System.Drawing.Size(903, 42)
        Me.LayoutControlItem19.Tag = "1"
        Me.LayoutControlItem19.Text = "Κατηγορία Έργου"
        Me.LayoutControlItem19.TextSize = New System.Drawing.Size(212, 23)
        '
        'LayoutControlItem20
        '
        Me.LayoutControlItem20.Control = Me.cboSaler
        Me.LayoutControlItem20.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem20.CustomizationFormText = "Περιοχή"
        Me.LayoutControlItem20.HighlightFocusedItem = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlItem20.ImageOptions.Image = CType(resources.GetObject("LayoutControlItem20.ImageOptions.Image"), System.Drawing.Image)
        Me.LayoutControlItem20.Location = New System.Drawing.Point(0, 42)
        Me.LayoutControlItem20.Name = "LayoutControlItem20"
        Me.LayoutControlItem20.Size = New System.Drawing.Size(903, 42)
        Me.LayoutControlItem20.Tag = "1"
        Me.LayoutControlItem20.Text = "Πωλητής"
        Me.LayoutControlItem20.TextSize = New System.Drawing.Size(212, 23)
        '
        'LayoutControlItem21
        '
        Me.LayoutControlItem21.Control = Me.txtDebitCost
        Me.LayoutControlItem21.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem21.CustomizationFormText = "Τελική Αξία"
        Me.LayoutControlItem21.HighlightFocusedItem = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlItem21.ImageOptions.Image = CType(resources.GetObject("LayoutControlItem21.ImageOptions.Image"), System.Drawing.Image)
        Me.LayoutControlItem21.Location = New System.Drawing.Point(0, 252)
        Me.LayoutControlItem21.Name = "LayoutControlItem21"
        Me.LayoutControlItem21.Size = New System.Drawing.Size(903, 42)
        Me.LayoutControlItem21.Text = "Πώληση Έργου"
        Me.LayoutControlItem21.TextSize = New System.Drawing.Size(212, 23)
        '
        'LayoutControlItem22
        '
        Me.LayoutControlItem22.Control = Me.txtDevicesCost
        Me.LayoutControlItem22.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem22.CustomizationFormText = "Τελική Αξία"
        Me.LayoutControlItem22.HighlightFocusedItem = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlItem22.ImageOptions.Image = CType(resources.GetObject("LayoutControlItem22.ImageOptions.Image"), System.Drawing.Image)
        Me.LayoutControlItem22.Location = New System.Drawing.Point(0, 294)
        Me.LayoutControlItem22.Name = "LayoutControlItem22"
        Me.LayoutControlItem22.Size = New System.Drawing.Size(903, 42)
        Me.LayoutControlItem22.Text = "Πώληση Συσκευών"
        Me.LayoutControlItem22.TextSize = New System.Drawing.Size(212, 23)
        '
        'EmptySpaceItem5
        '
        Me.EmptySpaceItem5.AllowHotTrack = False
        Me.EmptySpaceItem5.Location = New System.Drawing.Point(350, 1374)
        Me.EmptySpaceItem5.Name = "EmptySpaceItem5"
        Me.EmptySpaceItem5.Size = New System.Drawing.Size(115, 43)
        Me.EmptySpaceItem5.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem23
        '
        Me.LayoutControlItem23.Control = Me.chkCompleted
        Me.LayoutControlItem23.Location = New System.Drawing.Point(106, 1374)
        Me.LayoutControlItem23.Name = "LayoutControlItem23"
        Me.LayoutControlItem23.Size = New System.Drawing.Size(244, 43)
        Me.LayoutControlItem23.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem23.TextVisible = False
        '
        'LayoutControlItem25
        '
        Me.LayoutControlItem25.Control = Me.cmdPrintAll
        Me.LayoutControlItem25.Location = New System.Drawing.Point(465, 1374)
        Me.LayoutControlItem25.Name = "LayoutControlItem25"
        Me.LayoutControlItem25.Size = New System.Drawing.Size(239, 43)
        Me.LayoutControlItem25.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem25.TextVisible = False
        '
        'LayoutControlItem28
        '
        Me.LayoutControlItem28.Control = Me.txtExtraCost
        Me.LayoutControlItem28.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem28.CustomizationFormText = "Τελική Αξία"
        Me.LayoutControlItem28.HighlightFocusedItem = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlItem28.Location = New System.Drawing.Point(0, 336)
        Me.LayoutControlItem28.Name = "LayoutControlItem28"
        Me.LayoutControlItem28.Size = New System.Drawing.Size(903, 42)
        Me.LayoutControlItem28.Text = "Έξτρα Χρεώσεις"
        Me.LayoutControlItem28.TextSize = New System.Drawing.Size(212, 23)
        '
        'LayoutControlItem12
        '
        Me.LayoutControlItem12.Control = Me.txtInvoiceFilename
        Me.LayoutControlItem12.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem12.CustomizationFormText = "Περιοχή"
        Me.LayoutControlItem12.HighlightFocusedItem = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlItem12.Location = New System.Drawing.Point(0, 546)
        Me.LayoutControlItem12.Name = "LayoutControlItem12"
        Me.LayoutControlItem12.Size = New System.Drawing.Size(903, 42)
        Me.LayoutControlItem12.Text = "Αρχεία"
        Me.LayoutControlItem12.TextSize = New System.Drawing.Size(212, 23)
        '
        'LayoutControlItem16
        '
        Me.LayoutControlItem16.Control = Me.GridControl2
        Me.LayoutControlItem16.Location = New System.Drawing.Point(0, 880)
        Me.LayoutControlItem16.Name = "LayoutControlItem16"
        Me.LayoutControlItem16.Size = New System.Drawing.Size(903, 494)
        Me.LayoutControlItem16.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem16.TextVisible = False
        '
        'LayoutControlItem14
        '
        Me.LayoutControlItem14.Control = Me.txtComments
        Me.LayoutControlItem14.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem14.CustomizationFormText = "Σχόλια"
        Me.LayoutControlItem14.HighlightFocusedItem = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlItem14.Location = New System.Drawing.Point(0, 588)
        Me.LayoutControlItem14.Name = "LayoutControlItem14"
        Me.LayoutControlItem14.Size = New System.Drawing.Size(903, 292)
        Me.LayoutControlItem14.Text = "Σχόλια"
        Me.LayoutControlItem14.TextSize = New System.Drawing.Size(212, 23)
        '
        'LayoutControlItem29
        '
        Me.LayoutControlItem29.Control = Me.MemoEdit1
        Me.LayoutControlItem29.Location = New System.Drawing.Point(0, 126)
        Me.LayoutControlItem29.Name = "LayoutControlItem29"
        Me.LayoutControlItem29.Size = New System.Drawing.Size(903, 42)
        Me.LayoutControlItem29.Text = "Περιγραφή"
        Me.LayoutControlItem29.TextSize = New System.Drawing.Size(212, 23)
        '
        'LayoutControlGroup2
        '
        Me.LayoutControlGroup2.AppearanceGroup.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LayoutControlGroup2.AppearanceGroup.Options.UseBorderColor = True
        Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem10, Me.LayoutControlItem9, Me.LayoutControlItem7, Me.LayoutControlItem6, Me.EmptySpaceItem2, Me.LayoutControlItem8, Me.LayoutControlItem11, Me.EmptySpaceItem4, Me.LayoutControlItem17, Me.LayoutControlItem24, Me.LayoutControlItem30})
        Me.LayoutControlGroup2.Location = New System.Drawing.Point(929, 0)
        Me.LayoutControlGroup2.Name = "LayoutControlGroup2"
        Me.LayoutControlGroup2.Size = New System.Drawing.Size(970, 815)
        Me.LayoutControlGroup2.Text = "Στοιχεία Πίστωσης"
        '
        'LayoutControlItem10
        '
        Me.LayoutControlItem10.Control = Me.txtCMTD
        Me.LayoutControlItem10.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem10.CustomizationFormText = "Σχόλια"
        Me.LayoutControlItem10.HighlightFocusedItem = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlItem10.Location = New System.Drawing.Point(0, 291)
        Me.LayoutControlItem10.Name = "LayoutControlItem10"
        Me.LayoutControlItem10.Size = New System.Drawing.Size(944, 419)
        Me.LayoutControlItem10.Text = "Σχόλια"
        Me.LayoutControlItem10.TextSize = New System.Drawing.Size(212, 23)
        '
        'LayoutControlItem9
        '
        Me.LayoutControlItem9.Control = Me.txtamtD
        Me.LayoutControlItem9.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem9.CustomizationFormText = "Τελική Αξία"
        Me.LayoutControlItem9.HighlightFocusedItem = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlItem9.ImageOptions.Image = Global.DreamyKitchenCRM.My.Resources.Resources.rsz_11rsz_asterisk
        Me.LayoutControlItem9.Location = New System.Drawing.Point(0, 249)
        Me.LayoutControlItem9.Name = "LayoutControlItem9"
        Me.LayoutControlItem9.Size = New System.Drawing.Size(944, 42)
        Me.LayoutControlItem9.Tag = "1"
        Me.LayoutControlItem9.Text = "Ποσό"
        Me.LayoutControlItem9.TextSize = New System.Drawing.Size(212, 23)
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.Control = Me.dtPay
        Me.LayoutControlItem7.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem7.CustomizationFormText = "Ημερ/νία Ολοκλήρωσης"
        Me.LayoutControlItem7.ImageOptions.Image = CType(resources.GetObject("LayoutControlItem7.ImageOptions.Image"), System.Drawing.Image)
        Me.LayoutControlItem7.Location = New System.Drawing.Point(0, 42)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(944, 42)
        Me.LayoutControlItem7.Tag = "1"
        Me.LayoutControlItem7.Text = "Ημερ/νία"
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(212, 23)
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.txtCodeD
        Me.LayoutControlItem6.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem6.CustomizationFormText = "Κωδικός"
        Me.LayoutControlItem6.HighlightFocusedItem = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlItem6.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(378, 42)
        Me.LayoutControlItem6.Text = "Κωδικός"
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(212, 23)
        '
        'EmptySpaceItem2
        '
        Me.EmptySpaceItem2.AllowHotTrack = False
        Me.EmptySpaceItem2.Location = New System.Drawing.Point(378, 0)
        Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Size = New System.Drawing.Size(566, 42)
        Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem8
        '
        Me.LayoutControlItem8.Control = Me.cboBANK
        Me.LayoutControlItem8.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem8.CustomizationFormText = "Τράπεζα"
        Me.LayoutControlItem8.HighlightFocusedItem = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlItem8.Location = New System.Drawing.Point(0, 84)
        Me.LayoutControlItem8.Name = "LayoutControlItem8"
        Me.LayoutControlItem8.Size = New System.Drawing.Size(944, 42)
        Me.LayoutControlItem8.Tag = ""
        Me.LayoutControlItem8.Text = "Τράπεζα"
        Me.LayoutControlItem8.TextSize = New System.Drawing.Size(212, 23)
        '
        'LayoutControlItem11
        '
        Me.LayoutControlItem11.Control = Me.cmdSaveTransD
        Me.LayoutControlItem11.Location = New System.Drawing.Point(782, 710)
        Me.LayoutControlItem11.Name = "LayoutControlItem11"
        Me.LayoutControlItem11.Size = New System.Drawing.Size(162, 43)
        Me.LayoutControlItem11.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem11.TextVisible = False
        '
        'EmptySpaceItem4
        '
        Me.EmptySpaceItem4.AllowHotTrack = False
        Me.EmptySpaceItem4.Location = New System.Drawing.Point(0, 710)
        Me.EmptySpaceItem4.Name = "EmptySpaceItem4"
        Me.EmptySpaceItem4.Size = New System.Drawing.Size(782, 43)
        Me.EmptySpaceItem4.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem17
        '
        Me.LayoutControlItem17.Control = Me.chkCash
        Me.LayoutControlItem17.Location = New System.Drawing.Point(0, 168)
        Me.LayoutControlItem17.Name = "LayoutControlItem17"
        Me.LayoutControlItem17.Size = New System.Drawing.Size(944, 39)
        Me.LayoutControlItem17.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem17.TextVisible = False
        '
        'LayoutControlItem24
        '
        Me.LayoutControlItem24.Control = Me.cboPayType
        Me.LayoutControlItem24.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem24.CustomizationFormText = "Εμφανές Πλαϊνο"
        Me.LayoutControlItem24.ImageOptions.Image = CType(resources.GetObject("LayoutControlItem24.ImageOptions.Image"), System.Drawing.Image)
        Me.LayoutControlItem24.Location = New System.Drawing.Point(0, 207)
        Me.LayoutControlItem24.Name = "LayoutControlItem24"
        Me.LayoutControlItem24.Size = New System.Drawing.Size(944, 42)
        Me.LayoutControlItem24.Tag = "1"
        Me.LayoutControlItem24.Text = "Τύπος Πληρωμής"
        Me.LayoutControlItem24.TextSize = New System.Drawing.Size(212, 23)
        '
        'LayoutControlItem30
        '
        Me.LayoutControlItem30.Control = Me.MemoEdit11
        Me.LayoutControlItem30.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem30.CustomizationFormText = "Περιγραφή"
        Me.LayoutControlItem30.Location = New System.Drawing.Point(0, 126)
        Me.LayoutControlItem30.Name = "LayoutControlItem30"
        Me.LayoutControlItem30.Size = New System.Drawing.Size(944, 42)
        Me.LayoutControlItem30.Text = "Καταθέτης"
        Me.LayoutControlItem30.TextSize = New System.Drawing.Size(212, 23)
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
        Me.LayoutControlItem27.Location = New System.Drawing.Point(929, 1479)
        Me.LayoutControlItem27.Name = "LayoutControlItem27"
        Me.LayoutControlItem27.Size = New System.Drawing.Size(788, 46)
        Me.LayoutControlItem27.Text = "Υπόλοιπο"
        Me.LayoutControlItem27.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
        Me.LayoutControlItem27.TextSize = New System.Drawing.Size(107, 28)
        Me.LayoutControlItem27.TextToControlDistance = 5
        '
        'EmptySpaceItem7
        '
        Me.EmptySpaceItem7.AllowHotTrack = False
        Me.EmptySpaceItem7.Location = New System.Drawing.Point(0, 1479)
        Me.EmptySpaceItem7.Name = "EmptySpaceItem7"
        Me.EmptySpaceItem7.Size = New System.Drawing.Size(929, 46)
        Me.EmptySpaceItem7.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.GridControl1
        Me.LayoutControlItem3.Location = New System.Drawing.Point(929, 815)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(970, 664)
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem3.TextVisible = False
        '
        'LayoutControlItem31
        '
        Me.LayoutControlItem31.Control = Me.cmdExit
        Me.LayoutControlItem31.Location = New System.Drawing.Point(1717, 1479)
        Me.LayoutControlItem31.Name = "LayoutControlItem31"
        Me.LayoutControlItem31.Size = New System.Drawing.Size(182, 46)
        Me.LayoutControlItem31.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem31.TextVisible = False
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
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.bbEMP_T, Me.BBProjectCosts})
        Me.BarManager1.MaxItemId = 2
        '
        'Bar1
        '
        Me.Bar1.BarName = "Tools"
        Me.Bar1.DockCol = 0
        Me.Bar1.DockRow = 0
        Me.Bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Left
        Me.Bar1.FloatLocation = New System.Drawing.Point(51, 368)
        Me.Bar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.bbEMP_T), New DevExpress.XtraBars.LinkPersistInfo(Me.BBProjectCosts)})
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
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Manager = Me.BarManager1
        Me.barDockControlTop.Size = New System.Drawing.Size(1977, 0)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 1545)
        Me.barDockControlBottom.Manager = Me.BarManager1
        Me.barDockControlBottom.Size = New System.Drawing.Size(1977, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlLeft.Manager = Me.BarManager1
        Me.barDockControlLeft.Size = New System.Drawing.Size(58, 1545)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(1977, 0)
        Me.barDockControlRight.Manager = Me.BarManager1
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 1545)
        '
        'frmTransactions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 23.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1977, 1545)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.IconOptions.Image = Global.DreamyKitchenCRM.My.Resources.Resources.favicon
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "frmTransactions"
        Me.Text = "Έργο"
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.chkCompleted.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEMP_T_ID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkCash.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TRANSHFBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DM_TRANS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VwTRANSDBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VwBANKSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DreamyKitchenDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VwPAYTYPESBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboCUS.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtCharge.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtCharge.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodeH.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtComments.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtVatAmt.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodeD.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtPay.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtPay.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtamtD.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCMTD.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboBANK.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtInvoiceFilename.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTotAmt.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAmtH.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtBal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboInvoiceType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VwINVTYPESBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboSaler.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDebitCost.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDevicesCost.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboPayType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtExtraCost.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboTransC.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VwTRANSHCBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MemoEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MemoEdit11.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem45, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem18, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem26, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem19, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem20, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem21, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem22, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem23, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem25, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem28, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem29, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem17, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem24, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem30, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem27, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem31, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VwSCANFILENAMESBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DreamyKitchenDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents Root As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents cboCUS As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents dtCharge As DevExpress.XtraEditors.DateEdit
    Friend WithEvents txtCodeH As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtComments As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents txtVatAmt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cmdSaveTransH As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem3 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem45 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem14 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents txtCodeD As DevExpress.XtraEditors.TextEdit
    Friend WithEvents dtPay As DevExpress.XtraEditors.DateEdit
    Friend WithEvents txtamtD As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtCMTD As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem10 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents EmptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents cmdSaveTransD As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cboBANK As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem11 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem4 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LayoutControlItem12 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents txtInvoiceFilename As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents cmdExit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtTotAmt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem13 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents txtAmtH As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem15 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents GridControl2 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LayoutControlItem16 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents chkCash As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents LayoutControlItem17 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents DreamyKitchenDataSet As DreamyKitchenDataSet
    Friend WithEvents VwTRANSDBindingSource As BindingSource
    Friend WithEvents colID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coltranshID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBankName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colcash As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colamt As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colcmt As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldtPay As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRealName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colmodifiedOn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colcreatedOn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colbankID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents VwBANKSBindingSource As BindingSource
    Friend WithEvents Vw_BANKSTableAdapter As DreamyKitchenDataSetTableAdapters.vw_BANKSTableAdapter
    Friend WithEvents txtBal As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem27 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents XtraOpenFileDialog1 As DevExpress.XtraEditors.XtraOpenFileDialog
    Friend WithEvents txtEMP_T_ID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem18 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem26 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem19 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents cboInvoiceType As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents VwINVTYPESBindingSource As BindingSource
    Friend WithEvents Vw_INVTYPESTableAdapter As DreamyKitchenDataSetTableAdapters.vw_INVTYPESTableAdapter
    Friend WithEvents cboSaler As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LayoutControlItem20 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents VwSCANFILENAMESBindingSource As BindingSource
    Friend WithEvents Vw_SCAN_FILE_NAMESTableAdapter As DreamyKitchenDataSetTableAdapters.vw_SCAN_FILE_NAMESTableAdapter
    Friend WithEvents txtDebitCost As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem21 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents txtDevicesCost As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem22 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents chkCompleted As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents LayoutControlItem23 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem7 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem5 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents cboPayType As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LayoutControlItem24 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents DreamyKitchenDataSet2 As DreamyKitchenDataSet
    Friend WithEvents RepositoryItemLookUpEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents colpaid As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cmdPrintAll As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem25 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents txtExtraCost As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem28 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents TRANSHFBindingSource As BindingSource
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
    Friend WithEvents cboTransC As DevExpress.XtraEditors.CheckedComboBoxEdit
    Friend WithEvents DM_TRANS As DM_TRANS
    Friend WithEvents TRANSH_FTableAdapter As DM_TRANSTableAdapters.TRANSH_FTableAdapter
    Friend WithEvents Vw_TRANSDTableAdapter As DM_TRANSTableAdapters.vw_TRANSDTableAdapter
    Friend WithEvents VwTRANSHCBindingSource As BindingSource
    Friend WithEvents Vw_TRANSH_CTableAdapter As DM_TRANSTableAdapters.vw_TRANSH_CTableAdapter
    Friend WithEvents MemoEdit1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem29 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents VwPAYTYPESBindingSource As BindingSource
    Friend WithEvents Vw_PAYTYPESTableAdapter As DM_TRANSTableAdapters.vw_PAYTYPESTableAdapter
    Friend WithEvents colPayTypeID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MemoEdit11 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem30 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents coldepositor As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LayoutControlItem31 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar1 As DevExpress.XtraBars.Bar
    Friend WithEvents bbEMP_T As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BBProjectCosts As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
End Class
