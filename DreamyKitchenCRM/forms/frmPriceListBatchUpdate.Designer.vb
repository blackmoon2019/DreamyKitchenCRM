﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPriceListBatchUpdate
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
        Dim FieldInfo1 As DevExpress.DataAccess.Excel.FieldInfo = New DevExpress.DataAccess.Excel.FieldInfo()
        Dim FieldInfo2 As DevExpress.DataAccess.Excel.FieldInfo = New DevExpress.DataAccess.Excel.FieldInfo()
        Dim FieldInfo3 As DevExpress.DataAccess.Excel.FieldInfo = New DevExpress.DataAccess.Excel.FieldInfo()
        Dim FieldInfo4 As DevExpress.DataAccess.Excel.FieldInfo = New DevExpress.DataAccess.Excel.FieldInfo()
        Dim ExcelWorksheetSettings1 As DevExpress.DataAccess.Excel.ExcelWorksheetSettings = New DevExpress.DataAccess.Excel.ExcelWorksheetSettings()
        Dim ExcelSourceOptions1 As DevExpress.DataAccess.Excel.ExcelSourceOptions = New DevExpress.DataAccess.Excel.ExcelSourceOptions(ExcelWorksheetSettings1)
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPriceListBatchUpdate))
        Dim GridFormatRule1 As DevExpress.XtraGrid.GridFormatRule = New DevExpress.XtraGrid.GridFormatRule()
        Dim FormatConditionRuleExpression1 As DevExpress.XtraEditors.FormatConditionRuleExpression = New DevExpress.XtraEditors.FormatConditionRuleExpression()
        Dim GridFormatRule2 As DevExpress.XtraGrid.GridFormatRule = New DevExpress.XtraGrid.GridFormatRule()
        Dim FormatConditionRuleExpression2 As DevExpress.XtraEditors.FormatConditionRuleExpression = New DevExpress.XtraEditors.FormatConditionRuleExpression()
        Dim EditorButtonImageOptions2 As DevExpress.XtraEditors.Controls.EditorButtonImageOptions = New DevExpress.XtraEditors.Controls.EditorButtonImageOptions()
        Dim SerializableAppearanceObject5 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject6 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject7 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject8 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim EditorButtonImageOptions3 As DevExpress.XtraEditors.Controls.EditorButtonImageOptions = New DevExpress.XtraEditors.Controls.EditorButtonImageOptions()
        Dim SerializableAppearanceObject9 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject10 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject11 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject12 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Me.colkitchen = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepCopyDelete = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.colvatAmount = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDocType = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.DockManager1 = New DevExpress.XtraBars.Docking.DockManager(Me.components)
        Me.DockPanel1 = New DevExpress.XtraBars.Docking.DockPanel()
        Me.DockPanel1_Container = New DevExpress.XtraBars.Docking.ControlContainer()
        Me.TileNavPane1 = New DevExpress.XtraBars.Navigation.TileNavPane()
        Me.NavKanelopoulos = New DevExpress.XtraBars.Navigation.NavButton()
        Me.DockPanel2 = New DevExpress.XtraBars.Docking.DockPanel()
        Me.DockPanel2_Container = New DevExpress.XtraBars.Docking.ControlContainer()
        Me.lstLog = New DevExpress.XtraEditors.ImageListBoxControl()
        Me.KANELOPOULOS = New DevExpress.DataAccess.Excel.ExcelDataSource()
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.cmdKeywords = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdSave = New DevExpress.XtraEditors.SimpleButton()
        Me.ProgressBarControl1 = New DevExpress.XtraEditors.ProgressBarControl()
        Me.cmdExit = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdDelete = New DevExpress.XtraEditors.SimpleButton()
        Me.grdPRICELIST = New DevExpress.XtraGrid.GridControl()
        Me.KANELLOPOULOSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DMDataSet = New DreamyKitchenCRM.DMDataSet()
        Me.GridView5 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colFullTranshDescription = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colinvoiceNumber = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colcusID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepCus = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.CCTTRANSHBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DM_TRANS = New DreamyKitchenCRM.DM_TRANS()
        Me.coldtBuy = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coltranshID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepTransh = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.VwTRANSHBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.colnetAmount = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepColExcel = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.colbuyFID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCompleted = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colmaterials = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colgeneral = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colcloset = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colextraCus = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colbathroomFurn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colisCredit = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colord = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsupID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coluploadDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coldtYBuy = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colcreatedOn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colcreatedBy = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colbuyID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colcmt1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colKanO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepKan_O = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.KANELLOPOULOSOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.colDeltOrders = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtImageCorrect = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.txtImageError = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.RepColBtn = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.ReptxtO = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.DreamyKitchenDataSet = New DreamyKitchenCRM.DreamyKitchenDataSet()
        Me.VwBUYBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.XtraOpenFileDialog1 = New DevExpress.XtraEditors.XtraOpenFileDialog(Me.components)
        Me.ImageCollection1 = New DevExpress.Utils.ImageCollection(Me.components)
        Me.Vw_BUYTableAdapter = New DreamyKitchenCRM.DreamyKitchenDataSetTableAdapters.vw_BUYTableAdapter()
        Me.KANELLOPOULOSTableAdapter = New DreamyKitchenCRM.DMDataSetTableAdapters.KANELLOPOULOSTableAdapter()
        Me.KANELLOPOULOS_OTableAdapter = New DreamyKitchenCRM.DMDataSetTableAdapters.KANELLOPOULOS_OTableAdapter()
        Me.Vw_TRANSHTableAdapter = New DreamyKitchenCRM.DM_TRANSTableAdapters.vw_TRANSHTableAdapter()
        Me.CCT_TRANSHTableAdapter = New DreamyKitchenCRM.DM_TRANSTableAdapters.CCT_TRANSHTableAdapter()
        CType(Me.RepCopyDelete, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DockManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DockPanel1.SuspendLayout()
        Me.DockPanel1_Container.SuspendLayout()
        CType(Me.TileNavPane1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DockPanel2.SuspendLayout()
        Me.DockPanel2_Container.SuspendLayout()
        CType(Me.lstLog, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.ProgressBarControl1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdPRICELIST, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KANELLOPOULOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DMDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepCus, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CCTTRANSHBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DM_TRANS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepTransh, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VwTRANSHBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepColExcel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepKan_O, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KANELLOPOULOSOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtImageCorrect, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtImageError, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepColBtn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReptxtO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DreamyKitchenDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VwBUYBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImageCollection1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'colkitchen
        '
        Me.colkitchen.Caption = "Κουζίνα"
        Me.colkitchen.ColumnEdit = Me.RepCopyDelete
        Me.colkitchen.DisplayFormat.FormatString = "c2"
        Me.colkitchen.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colkitchen.FieldName = "kitchen"
        Me.colkitchen.MinWidth = 31
        Me.colkitchen.Name = "colkitchen"
        Me.colkitchen.Visible = True
        Me.colkitchen.VisibleIndex = 8
        Me.colkitchen.Width = 133
        '
        'RepCopyDelete
        '
        Me.RepCopyDelete.AutoHeight = False
        EditorButtonImageOptions1.Image = Global.DreamyKitchenCRM.My.Resources.Resources.icons8_copy_16
        Me.RepCopyDelete.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, EditorButtonImageOptions1, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, SerializableAppearanceObject2, SerializableAppearanceObject3, SerializableAppearanceObject4, "", Nothing, Nothing, DevExpress.Utils.ToolTipAnchor.[Default]), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete)})
        Me.RepCopyDelete.Name = "RepCopyDelete"
        '
        'colvatAmount
        '
        Me.colvatAmount.Caption = "Αξία με ΦΠΑ"
        Me.colvatAmount.DisplayFormat.FormatString = "c2"
        Me.colvatAmount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colvatAmount.FieldName = "vatAmount"
        Me.colvatAmount.MinWidth = 31
        Me.colvatAmount.Name = "colvatAmount"
        Me.colvatAmount.OptionsColumn.AllowEdit = False
        Me.colvatAmount.OptionsColumn.ReadOnly = True
        Me.colvatAmount.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "vatAmount", "Σύνολο={0:c2}")})
        Me.colvatAmount.Visible = True
        Me.colvatAmount.VisibleIndex = 14
        Me.colvatAmount.Width = 159
        '
        'colDocType
        '
        Me.colDocType.Caption = "Τύπος Παραστατικού"
        Me.colDocType.FieldName = "docTypeID"
        Me.colDocType.MinWidth = 31
        Me.colDocType.Name = "colDocType"
        Me.colDocType.OptionsColumn.AllowEdit = False
        Me.colDocType.OptionsColumn.ReadOnly = True
        Me.colDocType.Width = 252
        '
        'DockManager1
        '
        Me.DockManager1.Form = Me
        Me.DockManager1.RootPanels.AddRange(New DevExpress.XtraBars.Docking.DockPanel() {Me.DockPanel1, Me.DockPanel2})
        Me.DockManager1.TopZIndexControls.AddRange(New String() {"DevExpress.XtraBars.BarDockControl", "DevExpress.XtraBars.StandaloneBarDockControl", "System.Windows.Forms.MenuStrip", "System.Windows.Forms.StatusStrip", "System.Windows.Forms.StatusBar", "DevExpress.XtraBars.Ribbon.RibbonStatusBar", "DevExpress.XtraBars.Ribbon.RibbonControl", "DevExpress.XtraBars.Navigation.OfficeNavigationBar", "DevExpress.XtraBars.Navigation.TileNavPane", "DevExpress.XtraBars.TabFormControl", "DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl", "DevExpress.XtraBars.ToolbarForm.ToolbarFormControl"})
        '
        'DockPanel1
        '
        Me.DockPanel1.Controls.Add(Me.DockPanel1_Container)
        Me.DockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Top
        Me.DockPanel1.ID = New System.Guid("41c43a6f-f527-4717-82be-4c331a154b7c")
        Me.DockPanel1.Location = New System.Drawing.Point(0, 0)
        Me.DockPanel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DockPanel1.Name = "DockPanel1"
        Me.DockPanel1.OriginalSize = New System.Drawing.Size(200, 140)
        Me.DockPanel1.Size = New System.Drawing.Size(2146, 140)
        Me.DockPanel1.Text = "Προμηθευτές"
        '
        'DockPanel1_Container
        '
        Me.DockPanel1_Container.Controls.Add(Me.TileNavPane1)
        Me.DockPanel1_Container.Location = New System.Drawing.Point(4, 38)
        Me.DockPanel1_Container.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DockPanel1_Container.Name = "DockPanel1_Container"
        Me.DockPanel1_Container.Size = New System.Drawing.Size(2138, 95)
        Me.DockPanel1_Container.TabIndex = 0
        '
        'TileNavPane1
        '
        Me.TileNavPane1.Buttons.Add(Me.NavKanelopoulos)
        '
        'TileNavCategory1
        '
        Me.TileNavPane1.DefaultCategory.Name = "TileNavCategory1"
        '
        '
        '
        Me.TileNavPane1.DefaultCategory.Tile.DropDownOptions.BeakColor = System.Drawing.Color.Empty
        Me.TileNavPane1.Dock = System.Windows.Forms.DockStyle.Top
        Me.TileNavPane1.Location = New System.Drawing.Point(0, 0)
        Me.TileNavPane1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TileNavPane1.Name = "TileNavPane1"
        Me.TileNavPane1.Size = New System.Drawing.Size(2138, 64)
        Me.TileNavPane1.TabIndex = 0
        Me.TileNavPane1.Text = "TileNavPane1"
        '
        'NavKanelopoulos
        '
        Me.NavKanelopoulos.Alignment = DevExpress.XtraBars.Navigation.NavButtonAlignment.Left
        Me.NavKanelopoulos.Caption = "ΚΑΝΕΛΛΟΠΟΥΛΟΣ"
        Me.NavKanelopoulos.Name = "NavKanelopoulos"
        '
        'DockPanel2
        '
        Me.DockPanel2.Controls.Add(Me.DockPanel2_Container)
        Me.DockPanel2.Dock = DevExpress.XtraBars.Docking.DockingStyle.Bottom
        Me.DockPanel2.ID = New System.Guid("3ffe703d-37e8-45f1-bd6f-ffd119d21394")
        Me.DockPanel2.Location = New System.Drawing.Point(0, 922)
        Me.DockPanel2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DockPanel2.Name = "DockPanel2"
        Me.DockPanel2.OriginalSize = New System.Drawing.Size(200, 226)
        Me.DockPanel2.Size = New System.Drawing.Size(2146, 226)
        Me.DockPanel2.Text = "Αρχείο Καταγραφής"
        '
        'DockPanel2_Container
        '
        Me.DockPanel2_Container.Controls.Add(Me.lstLog)
        Me.DockPanel2_Container.Location = New System.Drawing.Point(4, 41)
        Me.DockPanel2_Container.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DockPanel2_Container.Name = "DockPanel2_Container"
        Me.DockPanel2_Container.Size = New System.Drawing.Size(2138, 181)
        Me.DockPanel2_Container.TabIndex = 0
        '
        'lstLog
        '
        Me.lstLog.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lstLog.Location = New System.Drawing.Point(0, 0)
        Me.lstLog.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lstLog.Name = "lstLog"
        Me.lstLog.Size = New System.Drawing.Size(2138, 181)
        Me.lstLog.TabIndex = 6
        '
        'KANELOPOULOS
        '
        Me.KANELOPOULOS.FileName = "C:\Users\USER\Downloads\ΤΙΜΟΚΑΤΑΛΟΓΟΙ.xlsx"
        Me.KANELOPOULOS.Name = "KANELOPOULOS"
        Me.KANELOPOULOS.ResultSchemaSerializable = "PFZpZXc+PEZpZWxkIE5hbWU9ImNvZGUiIFR5cGU9IlN0cmluZyIgLz48RmllbGQgTmFtZT0ibmFtZSIgV" &
    "HlwZT0iU3RyaW5nIiAvPjxGaWVsZCBOYW1lPSJwcmljZSIgVHlwZT0iRGVjaW1hbCIgLz48L1ZpZXc+"
        FieldInfo1.Name = "code"
        FieldInfo1.OriginalName = "Column1"
        FieldInfo1.Type = GetType(String)
        FieldInfo2.Name = "name"
        FieldInfo2.OriginalName = "Column2"
        FieldInfo2.Type = GetType(String)
        FieldInfo3.Name = "price"
        FieldInfo3.OriginalName = "Column3"
        FieldInfo3.Type = GetType(Decimal)
        FieldInfo4.Name = "Column4"
        FieldInfo4.OriginalName = "Column4"
        FieldInfo4.Selected = False
        FieldInfo4.Type = GetType(Decimal)
        Me.KANELOPOULOS.Schema.AddRange(New DevExpress.DataAccess.Excel.FieldInfo() {FieldInfo1, FieldInfo2, FieldInfo3, FieldInfo4})
        ExcelWorksheetSettings1.CellRange = Nothing
        ExcelWorksheetSettings1.WorksheetIndex = Nothing
        ExcelWorksheetSettings1.WorksheetName = "vario"
        ExcelSourceOptions1.ImportSettings = ExcelWorksheetSettings1
        ExcelSourceOptions1.UseFirstRowAsHeader = False
        Me.KANELOPOULOS.SourceOptions = ExcelSourceOptions1
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.cmdKeywords)
        Me.LayoutControl1.Controls.Add(Me.cmdSave)
        Me.LayoutControl1.Controls.Add(Me.ProgressBarControl1)
        Me.LayoutControl1.Controls.Add(Me.cmdExit)
        Me.LayoutControl1.Controls.Add(Me.cmdDelete)
        Me.LayoutControl1.Controls.Add(Me.grdPRICELIST)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 140)
        Me.LayoutControl1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(1327, 705, 1137, 700)
        Me.LayoutControl1.Root = Me.Root
        Me.LayoutControl1.Size = New System.Drawing.Size(2146, 782)
        Me.LayoutControl1.TabIndex = 2
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'cmdKeywords
        '
        Me.cmdKeywords.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdKeywords.Enabled = False
        Me.cmdKeywords.ImageOptions.Image = Global.DreamyKitchenCRM.My.Resources.Resources.icons8_keyword_241
        Me.cmdKeywords.Location = New System.Drawing.Point(414, 714)
        Me.cmdKeywords.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdKeywords.Name = "cmdKeywords"
        Me.cmdKeywords.Size = New System.Drawing.Size(134, 32)
        Me.cmdKeywords.StyleController = Me.LayoutControl1
        Me.cmdKeywords.TabIndex = 5
        Me.cmdKeywords.Text = "Λέξεις Κλειδιά"
        '
        'cmdSave
        '
        Me.cmdSave.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdSave.ImageOptions.Image = Global.DreamyKitchenCRM.My.Resources.Resources.icons8_save_close_24
        Me.cmdSave.Location = New System.Drawing.Point(12, 714)
        Me.cmdSave.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(194, 32)
        Me.cmdSave.StyleController = Me.LayoutControl1
        Me.cmdSave.TabIndex = 4
        Me.cmdSave.Text = "Αποθήκευση"
        '
        'ProgressBarControl1
        '
        Me.ProgressBarControl1.Location = New System.Drawing.Point(12, 750)
        Me.ProgressBarControl1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ProgressBarControl1.Name = "ProgressBarControl1"
        Me.ProgressBarControl1.Properties.ShowTitle = True
        Me.ProgressBarControl1.Size = New System.Drawing.Size(1952, 20)
        Me.ProgressBarControl1.StyleController = Me.LayoutControl1
        Me.ProgressBarControl1.TabIndex = 1
        Me.ProgressBarControl1.Visible = False
        '
        'cmdExit
        '
        Me.cmdExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdExit.ImageOptions.Image = CType(resources.GetObject("cmdExit.ImageOptions.Image"), System.Drawing.Image)
        Me.cmdExit.Location = New System.Drawing.Point(1968, 714)
        Me.cmdExit.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(166, 32)
        Me.cmdExit.StyleController = Me.LayoutControl1
        Me.cmdExit.TabIndex = 3
        Me.cmdExit.Text = "Έξοδος"
        '
        'cmdDelete
        '
        Me.cmdDelete.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdDelete.ImageOptions.Image = Global.DreamyKitchenCRM.My.Resources.Resources.icons8_delete_24
        Me.cmdDelete.Location = New System.Drawing.Point(210, 714)
        Me.cmdDelete.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(200, 32)
        Me.cmdDelete.StyleController = Me.LayoutControl1
        Me.cmdDelete.TabIndex = 2
        Me.cmdDelete.Text = "Διαγραφή"
        '
        'grdPRICELIST
        '
        Me.grdPRICELIST.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdPRICELIST.DataSource = Me.KANELLOPOULOSBindingSource
        Me.grdPRICELIST.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(6)
        Me.grdPRICELIST.Location = New System.Drawing.Point(12, 12)
        Me.grdPRICELIST.MainView = Me.GridView5
        Me.grdPRICELIST.Margin = New System.Windows.Forms.Padding(4)
        Me.grdPRICELIST.Name = "grdPRICELIST"
        Me.grdPRICELIST.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepCus, Me.txtImageCorrect, Me.txtImageError, Me.RepColBtn, Me.RepTransh, Me.RepColExcel, Me.RepCopyDelete, Me.RepKan_O, Me.ReptxtO})
        Me.grdPRICELIST.Size = New System.Drawing.Size(2122, 698)
        Me.grdPRICELIST.TabIndex = 0
        Me.grdPRICELIST.UseEmbeddedNavigator = True
        Me.grdPRICELIST.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView5})
        '
        'KANELLOPOULOSBindingSource
        '
        Me.KANELLOPOULOSBindingSource.DataMember = "KANELLOPOULOS"
        Me.KANELLOPOULOSBindingSource.DataSource = Me.DMDataSet
        '
        'DMDataSet
        '
        Me.DMDataSet.DataSetName = "DMDataSet"
        Me.DMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView5
        '
        Me.GridView5.ActiveFilterString = "[completed] = False"
        Me.GridView5.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colFullTranshDescription, Me.colID, Me.colinvoiceNumber, Me.colcusID, Me.coldtBuy, Me.coltranshID, Me.colDocType, Me.colvatAmount, Me.colnetAmount, Me.GridColumn3, Me.colbuyFID, Me.colCompleted, Me.colkitchen, Me.colmaterials, Me.colgeneral, Me.colcloset, Me.colextraCus, Me.colbathroomFurn, Me.colisCredit, Me.colord, Me.colsupID, Me.coluploadDate, Me.coldtYBuy, Me.colcreatedOn, Me.colcreatedBy, Me.colbuyID, Me.colcmt1, Me.colKanO, Me.colDeltOrders})
        Me.GridView5.DetailHeight = 289
        Me.GridView5.FixedLineWidth = 3
        GridFormatRule1.ApplyToRow = True
        GridFormatRule1.Column = Me.colkitchen
        GridFormatRule1.Name = "Format0"
        FormatConditionRuleExpression1.Expression = "[kitchen] <> 0.0m Or [general] <> 0.0m Or [bathroomFurn] <> 0.0m Or [closet] <> 0" &
    ".0m Or [materials] <> 0.0m"
        FormatConditionRuleExpression1.PredefinedName = "Green Fill"
        GridFormatRule1.Rule = FormatConditionRuleExpression1
        GridFormatRule2.ApplyToRow = True
        GridFormatRule2.Column = Me.colvatAmount
        GridFormatRule2.Name = "Format1"
        FormatConditionRuleExpression2.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        FormatConditionRuleExpression2.Appearance.Options.UseForeColor = True
        FormatConditionRuleExpression2.Expression = "[vatAmount] < 0.0m"
        GridFormatRule2.Rule = FormatConditionRuleExpression2
        Me.GridView5.FormatRules.Add(GridFormatRule1)
        Me.GridView5.FormatRules.Add(GridFormatRule2)
        Me.GridView5.GridControl = Me.grdPRICELIST
        Me.GridView5.LevelIndent = 0
        Me.GridView5.Name = "GridView5"
        Me.GridView5.OptionsBehavior.AlignGroupSummaryInGroupRow = DevExpress.Utils.DefaultBoolean.[True]
        Me.GridView5.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.MouseDown
        Me.GridView5.OptionsDetail.EnableMasterViewMode = False
        Me.GridView5.OptionsEditForm.PopupEditFormWidth = 720
        Me.GridView5.OptionsLayout.StoreAllOptions = True
        Me.GridView5.OptionsLayout.StoreAppearance = True
        Me.GridView5.OptionsLayout.StoreFormatRules = True
        Me.GridView5.OptionsMenu.EnableGroupRowMenu = True
        Me.GridView5.OptionsMenu.ShowAddNewSummaryItem = DevExpress.Utils.DefaultBoolean.[True]
        Me.GridView5.OptionsMenu.ShowConditionalFormattingItem = True
        Me.GridView5.OptionsMenu.ShowFooterItem = True
        Me.GridView5.OptionsMenu.ShowGroupSummaryEditorItem = True
        Me.GridView5.OptionsPrint.PrintPreview = True
        Me.GridView5.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView5.OptionsSelection.MultiSelect = True
        Me.GridView5.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect
        Me.GridView5.OptionsView.ColumnAutoWidth = False
        Me.GridView5.OptionsView.EnableAppearanceEvenRow = True
        Me.GridView5.OptionsView.ShowFooter = True
        Me.GridView5.OptionsView.ShowGroupPanel = False
        Me.GridView5.PreviewIndent = 0
        Me.GridView5.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colord, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'colFullTranshDescription
        '
        Me.colFullTranshDescription.Caption = "GridColumn1"
        Me.colFullTranshDescription.FieldName = "FullTranshDescription"
        Me.colFullTranshDescription.MinWidth = 31
        Me.colFullTranshDescription.Name = "colFullTranshDescription"
        Me.colFullTranshDescription.Width = 119
        '
        'colID
        '
        Me.colID.FieldName = "ID"
        Me.colID.MinWidth = 31
        Me.colID.Name = "colID"
        Me.colID.OptionsColumn.AllowEdit = False
        Me.colID.OptionsColumn.ReadOnly = True
        Me.colID.Width = 375
        '
        'colinvoiceNumber
        '
        Me.colinvoiceNumber.Caption = "Αρ. Παραστατικού"
        Me.colinvoiceNumber.FieldName = "invNumber"
        Me.colinvoiceNumber.MinWidth = 31
        Me.colinvoiceNumber.Name = "colinvoiceNumber"
        Me.colinvoiceNumber.OptionsColumn.AllowEdit = False
        Me.colinvoiceNumber.OptionsColumn.ReadOnly = True
        Me.colinvoiceNumber.Visible = True
        Me.colinvoiceNumber.VisibleIndex = 3
        Me.colinvoiceNumber.Width = 193
        '
        'colcusID
        '
        Me.colcusID.Caption = "Πελάτης"
        Me.colcusID.ColumnEdit = Me.RepCus
        Me.colcusID.FieldName = "cctID"
        Me.colcusID.MinWidth = 31
        Me.colcusID.Name = "colcusID"
        Me.colcusID.Visible = True
        Me.colcusID.VisibleIndex = 4
        Me.colcusID.Width = 337
        '
        'RepCus
        '
        Me.RepCus.AutoHeight = False
        Me.RepCus.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Clear), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Search)})
        Me.RepCus.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 31, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("code", "code", 49, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Fullname", "Ονοματεπώνυμο", 82, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("FatherName", "Father Name", 112, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CouID", "Cou ID", 66, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("AreaID", "Area ID", 71, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("AdrID", "Adr ID", 63, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("SourceID", "Source ID", 89, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("SalerID", "Saler ID", 75, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("DoyID", "Doy ID", 66, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("PrfID", "Prf ID", 58, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("phn", "phn", 43, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("mob", "mob", 47, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("fax", "fax", 36, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("email", "email", 53, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("afm", "afm", 42, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("cmt", "cmt", 41, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("modifiedBy", "modified By", 102, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("modifiedOn", "modified On", 105, DevExpress.Utils.FormatType.DateTime, "d/M/yyyy", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("createdOn", "created On", 97, DevExpress.Utils.FormatType.DateTime, "d/M/yyyy", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("createdBy", "created By", 94, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("nam", "nam", 47, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ttl", "ttl", 28, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ord", "ord", 39, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("name", "name", 56, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("OwnerFullName", "Owner Full Name", 144, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("TenantFullName", "Tenant Full Name", 148, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("bal", "bal", 36, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("out", "out", 38, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("closed", "closed", 60, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("RealName", "Real Name", 95, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("bdgNam", "bdg Nam", 84, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("bdgID", "bdg ID", 67, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("flrID", "flr ID", 52, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("OwnerID", "Owner ID", 86, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("TenantID", "Tenant ID", 90, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("old_code", "old_code", 81, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("sameOwnerTenant", "same Owner Tenant", 166, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("bdgCode", "bdg Code", 86, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("AdrName", "Adr Name", 89, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ar", "ar", 29, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("AreaName", "Area Name", 97, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("RepresentativeID", "Representative ID", 148, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("RepresentativeFullname", "Representative Fullname", 199, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default])})
        Me.RepCus.DataSource = Me.CCTTRANSHBindingSource
        Me.RepCus.DisplayMember = "Fullname"
        Me.RepCus.Name = "RepCus"
        Me.RepCus.NullText = ""
        Me.RepCus.ValueMember = "ID"
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
        'coldtBuy
        '
        Me.coldtBuy.Caption = "Ημερ/νία"
        Me.coldtBuy.FieldName = "invDate"
        Me.coldtBuy.MinWidth = 31
        Me.coldtBuy.Name = "coldtBuy"
        Me.coldtBuy.OptionsColumn.AllowEdit = False
        Me.coldtBuy.OptionsColumn.ReadOnly = True
        Me.coldtBuy.Visible = True
        Me.coldtBuy.VisibleIndex = 2
        Me.coldtBuy.Width = 97
        '
        'coltranshID
        '
        Me.coltranshID.Caption = "Έργο"
        Me.coltranshID.ColumnEdit = Me.RepTransh
        Me.coltranshID.FieldName = "transhID"
        Me.coltranshID.MinWidth = 31
        Me.coltranshID.Name = "coltranshID"
        Me.coltranshID.Visible = True
        Me.coltranshID.VisibleIndex = 5
        Me.coltranshID.Width = 453
        '
        'RepTransh
        '
        Me.RepTransh.AutoHeight = False
        Me.RepTransh.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Clear), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Search)})
        Me.RepTransh.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 30, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("code", "code", 46, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("cusID", "cus ID", 58, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("dtCharge", "dt Charge", 82, DevExpress.Utils.FormatType.DateTime, "d/M/yyyy", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("GRMONTH", "GRMONTH", 90, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("amt", "amt", 40, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("cmt", "cmt", 39, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("modifiedBy", "modified By", 97, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("modifiedOn", "modified On", 101, DevExpress.Utils.FormatType.DateTime, "d/M/yyyy", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("createdOn", "created On", 90, DevExpress.Utils.FormatType.DateTime, "d/M/yyyy", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("createdBy", "created By", 86, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Fullname", "Fullname", 77, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("RealName", "Real Name", 89, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Totamt", "Totamt", 64, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("vatamt", "vatamt", 61, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("bal", "bal", 34, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("SalerName", "Saler Name", 94, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("SalerID", "Saler ID", 70, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("EmpTID", "Emp TID", 77, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("invTypeDescr", "inv Type Descr", 118, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("description", "description", 90, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("invType", "inv Type", 74, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("empID", "emp ID", 66, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("DebitCost", "Debit Cost", 86, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("DevicesCost", "Devices Cost", 102, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("salerProfit", "saler Profit", 89, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("FullTranshDescription", "Έργα", 176, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("AreaId", "Area Id", 66, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("adrid", "adrid", 49, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("couid", "couid", 51, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("benchSalesPrice", "bench Sales Price", 135, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("benchPurchasePrice", "bench Purchase Price", 162, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("benchProfit", "bench Profit", 98, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("dtAgreement", "dt Agreement", 110, DevExpress.Utils.FormatType.DateTime, "d/M/yyyy", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("offerCusAcceptance", "Αποδοχή Προσφοράς", 161, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("waitingForAgreement", "waiting For Agreement", 175, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Iskitchen", "Iskitchen", 76, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Iscloset", "Iscloset", 66, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Isdoor", "Isdoor", 59, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Issc", "Issc", 40, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default])})
        Me.RepTransh.DataSource = Me.VwTRANSHBindingSource
        Me.RepTransh.DisplayMember = "FullTranshDescription"
        Me.RepTransh.Name = "RepTransh"
        Me.RepTransh.NullText = ""
        Me.RepTransh.PopupWidth = 315
        Me.RepTransh.PopupWidthMode = DevExpress.XtraEditors.PopupWidthMode.ContentWidth
        Me.RepTransh.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoSuggest
        Me.RepTransh.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.RepTransh.UseAdvancedMode = DevExpress.Utils.DefaultBoolean.[True]
        Me.RepTransh.ValueMember = "ID"
        '
        'VwTRANSHBindingSource
        '
        Me.VwTRANSHBindingSource.DataMember = "vw_TRANSH"
        Me.VwTRANSHBindingSource.DataSource = Me.DM_TRANS
        '
        'colnetAmount
        '
        Me.colnetAmount.Caption = "Καθαρή Αξία"
        Me.colnetAmount.DisplayFormat.FormatString = "c2"
        Me.colnetAmount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colnetAmount.FieldName = "netAmount"
        Me.colnetAmount.MinWidth = 31
        Me.colnetAmount.Name = "colnetAmount"
        Me.colnetAmount.OptionsColumn.AllowEdit = False
        Me.colnetAmount.OptionsColumn.ReadOnly = True
        Me.colnetAmount.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "netAmount", "Σύνολο={0:c2}")})
        Me.colnetAmount.Visible = True
        Me.colnetAmount.VisibleIndex = 13
        Me.colnetAmount.Width = 150
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "Αρχείο"
        Me.GridColumn3.ColumnEdit = Me.RepColExcel
        Me.GridColumn3.MinWidth = 31
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 17
        Me.GridColumn3.Width = 83
        '
        'RepColExcel
        '
        Me.RepColExcel.AutoHeight = False
        EditorButtonImageOptions2.SvgImage = CType(resources.GetObject("EditorButtonImageOptions2.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.RepColExcel.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, EditorButtonImageOptions2, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject5, SerializableAppearanceObject6, SerializableAppearanceObject7, SerializableAppearanceObject8, "", Nothing, Nothing, DevExpress.Utils.ToolTipAnchor.[Default])})
        Me.RepColExcel.Name = "RepColExcel"
        Me.RepColExcel.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'colbuyFID
        '
        Me.colbuyFID.FieldName = "buyFID"
        Me.colbuyFID.MinWidth = 31
        Me.colbuyFID.Name = "colbuyFID"
        Me.colbuyFID.Width = 119
        '
        'colCompleted
        '
        Me.colCompleted.Caption = "Ολοκληρωμένη"
        Me.colCompleted.FieldName = "completed"
        Me.colCompleted.MinWidth = 31
        Me.colCompleted.Name = "colCompleted"
        Me.colCompleted.Visible = True
        Me.colCompleted.VisibleIndex = 16
        Me.colCompleted.Width = 147
        '
        'colmaterials
        '
        Me.colmaterials.Caption = "Υλικά"
        Me.colmaterials.ColumnEdit = Me.RepCopyDelete
        Me.colmaterials.DisplayFormat.FormatString = "c2"
        Me.colmaterials.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colmaterials.FieldName = "materials"
        Me.colmaterials.MinWidth = 31
        Me.colmaterials.Name = "colmaterials"
        Me.colmaterials.Visible = True
        Me.colmaterials.VisibleIndex = 11
        Me.colmaterials.Width = 124
        '
        'colgeneral
        '
        Me.colgeneral.Caption = "Διάφορα"
        Me.colgeneral.ColumnEdit = Me.RepCopyDelete
        Me.colgeneral.DisplayFormat.FormatString = "c2"
        Me.colgeneral.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colgeneral.FieldName = "general"
        Me.colgeneral.MinWidth = 31
        Me.colgeneral.Name = "colgeneral"
        Me.colgeneral.Visible = True
        Me.colgeneral.VisibleIndex = 12
        Me.colgeneral.Width = 142
        '
        'colcloset
        '
        Me.colcloset.Caption = "Ντουλάπα"
        Me.colcloset.ColumnEdit = Me.RepCopyDelete
        Me.colcloset.DisplayFormat.FormatString = "c2"
        Me.colcloset.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colcloset.FieldName = "closet"
        Me.colcloset.MinWidth = 31
        Me.colcloset.Name = "colcloset"
        Me.colcloset.Visible = True
        Me.colcloset.VisibleIndex = 9
        Me.colcloset.Width = 124
        '
        'colextraCus
        '
        Me.colextraCus.Caption = "Έξτρα Πελατών"
        Me.colextraCus.ColumnEdit = Me.RepCopyDelete
        Me.colextraCus.DisplayFormat.FormatString = "c2"
        Me.colextraCus.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colextraCus.FieldName = "extraCus"
        Me.colextraCus.MinWidth = 30
        Me.colextraCus.Name = "colextraCus"
        Me.colextraCus.Visible = True
        Me.colextraCus.VisibleIndex = 19
        Me.colextraCus.Width = 67
        '
        'colbathroomFurn
        '
        Me.colbathroomFurn.Caption = "Έπιπλα μπάνιου"
        Me.colbathroomFurn.ColumnEdit = Me.RepCopyDelete
        Me.colbathroomFurn.DisplayFormat.FormatString = "c2"
        Me.colbathroomFurn.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colbathroomFurn.FieldName = "bathroomFurn"
        Me.colbathroomFurn.MinWidth = 31
        Me.colbathroomFurn.Name = "colbathroomFurn"
        Me.colbathroomFurn.Visible = True
        Me.colbathroomFurn.VisibleIndex = 10
        Me.colbathroomFurn.Width = 147
        '
        'colisCredit
        '
        Me.colisCredit.Caption = "Πιστωτικό"
        Me.colisCredit.FieldName = "isCredit"
        Me.colisCredit.MinWidth = 52
        Me.colisCredit.Name = "colisCredit"
        Me.colisCredit.OptionsColumn.AllowEdit = False
        Me.colisCredit.OptionsColumn.ReadOnly = True
        Me.colisCredit.Visible = True
        Me.colisCredit.VisibleIndex = 15
        Me.colisCredit.Width = 115
        '
        'colord
        '
        Me.colord.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colord.AppearanceCell.Options.UseBackColor = True
        Me.colord.Caption = "ΑΑ"
        Me.colord.FieldName = "ord"
        Me.colord.MinWidth = 30
        Me.colord.Name = "colord"
        Me.colord.OptionsColumn.AllowEdit = False
        Me.colord.OptionsColumn.ReadOnly = True
        Me.colord.Visible = True
        Me.colord.VisibleIndex = 1
        Me.colord.Width = 67
        '
        'colsupID
        '
        Me.colsupID.AppearanceCell.BackColor = System.Drawing.Color.Bisque
        Me.colsupID.AppearanceCell.Options.UseBackColor = True
        Me.colsupID.FieldName = "supID"
        Me.colsupID.MinWidth = 30
        Me.colsupID.Name = "colsupID"
        Me.colsupID.Width = 67
        '
        'coluploadDate
        '
        Me.coluploadDate.AppearanceCell.BackColor = System.Drawing.Color.Bisque
        Me.coluploadDate.AppearanceCell.Options.UseBackColor = True
        Me.coluploadDate.FieldName = "uploadDate"
        Me.coluploadDate.MinWidth = 30
        Me.coluploadDate.Name = "coluploadDate"
        Me.coluploadDate.Width = 67
        '
        'coldtYBuy
        '
        Me.coldtYBuy.AppearanceCell.BackColor = System.Drawing.Color.Bisque
        Me.coldtYBuy.AppearanceCell.Options.UseBackColor = True
        Me.coldtYBuy.FieldName = "dtYBuy"
        Me.coldtYBuy.MinWidth = 30
        Me.coldtYBuy.Name = "coldtYBuy"
        Me.coldtYBuy.Width = 67
        '
        'colcreatedOn
        '
        Me.colcreatedOn.AppearanceCell.BackColor = System.Drawing.Color.Bisque
        Me.colcreatedOn.AppearanceCell.Options.UseBackColor = True
        Me.colcreatedOn.FieldName = "createdOn"
        Me.colcreatedOn.MinWidth = 30
        Me.colcreatedOn.Name = "colcreatedOn"
        Me.colcreatedOn.Width = 67
        '
        'colcreatedBy
        '
        Me.colcreatedBy.AppearanceCell.BackColor = System.Drawing.Color.Bisque
        Me.colcreatedBy.AppearanceCell.Options.UseBackColor = True
        Me.colcreatedBy.FieldName = "createdBy"
        Me.colcreatedBy.MinWidth = 30
        Me.colcreatedBy.Name = "colcreatedBy"
        Me.colcreatedBy.Width = 67
        '
        'colbuyID
        '
        Me.colbuyID.FieldName = "buyID"
        Me.colbuyID.MinWidth = 31
        Me.colbuyID.Name = "colbuyID"
        Me.colbuyID.Width = 119
        '
        'colcmt1
        '
        Me.colcmt1.Caption = "Σχόλια"
        Me.colcmt1.FieldName = "cmt"
        Me.colcmt1.MinWidth = 31
        Me.colcmt1.Name = "colcmt1"
        Me.colcmt1.Visible = True
        Me.colcmt1.VisibleIndex = 7
        Me.colcmt1.Width = 129
        '
        'colKanO
        '
        Me.colKanO.Caption = "Δελτία Π."
        Me.colKanO.ColumnEdit = Me.RepKan_O
        Me.colKanO.MinWidth = 31
        Me.colKanO.Name = "colKanO"
        Me.colKanO.Visible = True
        Me.colKanO.VisibleIndex = 6
        Me.colKanO.Width = 169
        '
        'RepKan_O
        '
        Me.RepKan_O.AllowMouseWheel = False
        Me.RepKan_O.AutoHeight = False
        Me.RepKan_O.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Minus)})
        Me.RepKan_O.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 31, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("kanID", "kan ID", 64, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("code", "code", 49, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("name", "Δελτία", 56, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default])})
        Me.RepKan_O.DataSource = Me.KANELLOPOULOSOBindingSource
        Me.RepKan_O.DisplayMember = "name"
        Me.RepKan_O.Name = "RepKan_O"
        Me.RepKan_O.NullText = ""
        Me.RepKan_O.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.RepKan_O.ValueMember = "ID"
        '
        'KANELLOPOULOSOBindingSource
        '
        Me.KANELLOPOULOSOBindingSource.DataMember = "KANELLOPOULOS_O"
        Me.KANELLOPOULOSOBindingSource.DataSource = Me.DMDataSet
        '
        'colDeltOrders
        '
        Me.colDeltOrders.Caption = "Έχει Δελτία"
        Me.colDeltOrders.FieldName = "DeltOrders"
        Me.colDeltOrders.MinWidth = 31
        Me.colDeltOrders.Name = "colDeltOrders"
        Me.colDeltOrders.Visible = True
        Me.colDeltOrders.VisibleIndex = 18
        Me.colDeltOrders.Width = 118
        '
        'txtImageCorrect
        '
        Me.txtImageCorrect.AutoHeight = False
        Me.txtImageCorrect.ContextImageOptions.SvgImage = CType(resources.GetObject("txtImageCorrect.ContextImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.txtImageCorrect.Name = "txtImageCorrect"
        Me.txtImageCorrect.NullText = "Matched"
        '
        'txtImageError
        '
        Me.txtImageError.AutoHeight = False
        Me.txtImageError.ContextImageOptions.SvgImage = CType(resources.GetObject("txtImageError.ContextImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.txtImageError.Name = "txtImageError"
        Me.txtImageError.NullText = "Not Matched"
        '
        'RepColBtn
        '
        Me.RepColBtn.AutoHeight = False
        EditorButtonImageOptions3.SvgImage = CType(resources.GetObject("EditorButtonImageOptions3.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.RepColBtn.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, EditorButtonImageOptions3, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject9, SerializableAppearanceObject10, SerializableAppearanceObject11, SerializableAppearanceObject12, "", Nothing, Nothing, DevExpress.Utils.ToolTipAnchor.[Default])})
        Me.RepColBtn.Name = "RepColBtn"
        Me.RepColBtn.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'ReptxtO
        '
        Me.ReptxtO.AutoHeight = False
        Me.ReptxtO.Name = "ReptxtO"
        '
        'Root
        '
        Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.Root.GroupBordersVisible = False
        Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem3, Me.EmptySpaceItem1, Me.LayoutControlItem4, Me.EmptySpaceItem2, Me.LayoutControlItem5, Me.LayoutControlItem2, Me.LayoutControlItem6})
        Me.Root.Name = "Root"
        Me.Root.Size = New System.Drawing.Size(2146, 782)
        Me.Root.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.grdPRICELIST
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(2126, 702)
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.cmdExit
        Me.LayoutControlItem3.Location = New System.Drawing.Point(1956, 702)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(170, 36)
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem3.TextVisible = False
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(540, 702)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(1416, 36)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.ProgressBarControl1
        Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 738)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(1956, 24)
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem4.TextVisible = False
        '
        'EmptySpaceItem2
        '
        Me.EmptySpaceItem2.AllowHotTrack = False
        Me.EmptySpaceItem2.Location = New System.Drawing.Point(1956, 738)
        Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Size = New System.Drawing.Size(170, 24)
        Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.cmdSave
        Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 702)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(198, 36)
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem5.TextVisible = False
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.cmdDelete
        Me.LayoutControlItem2.Location = New System.Drawing.Point(198, 702)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(204, 36)
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem2.TextVisible = False
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.cmdKeywords
        Me.LayoutControlItem6.Location = New System.Drawing.Point(402, 702)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(138, 36)
        Me.LayoutControlItem6.Text = "Λέξεις Κλειδιά"
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem6.TextVisible = False
        '
        'DreamyKitchenDataSet
        '
        Me.DreamyKitchenDataSet.DataSetName = "DreamyKitchenDataSet"
        Me.DreamyKitchenDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'VwBUYBindingSource
        '
        Me.VwBUYBindingSource.DataMember = "vw_BUY"
        Me.VwBUYBindingSource.DataSource = Me.DreamyKitchenDataSet
        '
        'XtraOpenFileDialog1
        '
        Me.XtraOpenFileDialog1.FileName = "XtraOpenFileDialog1"
        '
        'ImageCollection1
        '
        Me.ImageCollection1.ImageStream = CType(resources.GetObject("ImageCollection1.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        Me.ImageCollection1.Images.SetKeyName(0, "apply_16x16.png")
        Me.ImageCollection1.Images.SetKeyName(1, "cancel_16x16.png")
        Me.ImageCollection1.Images.SetKeyName(2, "pivot_16x16.png")
        Me.ImageCollection1.Images.SetKeyName(3, "clear_16x16.png")
        Me.ImageCollection1.Images.SetKeyName(4, "duplicatevalues_16x16.png")
        '
        'Vw_BUYTableAdapter
        '
        Me.Vw_BUYTableAdapter.ClearBeforeFill = True
        '
        'KANELLOPOULOSTableAdapter
        '
        Me.KANELLOPOULOSTableAdapter.ClearBeforeFill = True
        '
        'KANELLOPOULOS_OTableAdapter
        '
        Me.KANELLOPOULOS_OTableAdapter.ClearBeforeFill = True
        '
        'Vw_TRANSHTableAdapter
        '
        Me.Vw_TRANSHTableAdapter.ClearBeforeFill = True
        '
        'CCT_TRANSHTableAdapter
        '
        Me.CCT_TRANSHTableAdapter.ClearBeforeFill = True
        '
        'frmPriceListBatchUpdate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(2146, 1148)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Controls.Add(Me.DockPanel2)
        Me.Controls.Add(Me.DockPanel1)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "frmPriceListBatchUpdate"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Μαζική Ενημέρωση Τιμοκαταλόγων"
        CType(Me.RepCopyDelete, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DockManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DockPanel1.ResumeLayout(False)
        Me.DockPanel1_Container.ResumeLayout(False)
        CType(Me.TileNavPane1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DockPanel2.ResumeLayout(False)
        Me.DockPanel2_Container.ResumeLayout(False)
        CType(Me.lstLog, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.ProgressBarControl1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdPRICELIST, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KANELLOPOULOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DMDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepCus, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CCTTRANSHBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DM_TRANS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepTransh, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VwTRANSHBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepColExcel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepKan_O, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KANELLOPOULOSOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtImageCorrect, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtImageError, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepColBtn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReptxtO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DreamyKitchenDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VwBUYBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImageCollection1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DockManager1 As DevExpress.XtraBars.Docking.DockManager
    Friend WithEvents DockPanel1 As DevExpress.XtraBars.Docking.DockPanel
    Friend WithEvents DockPanel1_Container As DevExpress.XtraBars.Docking.ControlContainer
    Friend WithEvents DockPanel2 As DevExpress.XtraBars.Docking.DockPanel
    Friend WithEvents DockPanel2_Container As DevExpress.XtraBars.Docking.ControlContainer
    Friend WithEvents lstLog As DevExpress.XtraEditors.ImageListBoxControl
    Friend WithEvents TileNavPane1 As DevExpress.XtraBars.Navigation.TileNavPane
    Friend WithEvents NavKanelopoulos As DevExpress.XtraBars.Navigation.NavButton
    Friend WithEvents KANELOPOULOS As DevExpress.DataAccess.Excel.ExcelDataSource
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents ProgressBarControl1 As DevExpress.XtraEditors.ProgressBarControl
    Friend WithEvents cmdExit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdDelete As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents grdPRICELIST As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView5 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colinvoiceNumber As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colcusID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepCus As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents coldtBuy As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coltranshID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepTransh As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents colDocType As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colvatAmount As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepColBtn As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepColExcel As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents colbuyFID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCompleted As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtImageCorrect As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents txtImageError As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents Root As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents XtraOpenFileDialog1 As DevExpress.XtraEditors.XtraOpenFileDialog
    Friend WithEvents ImageCollection1 As DevExpress.Utils.ImageCollection
    Friend WithEvents DreamyKitchenDataSet As DreamyKitchenDataSet
    Friend WithEvents VwBUYBindingSource As BindingSource
    Friend WithEvents Vw_BUYTableAdapter As DreamyKitchenDataSetTableAdapters.vw_BUYTableAdapter
    Friend WithEvents DMDataSet As DMDataSet
    Friend WithEvents CCTTRANSHBindingSource As BindingSource
    Friend WithEvents VwTRANSHBindingSource As BindingSource
    Friend WithEvents KANELLOPOULOSBindingSource As BindingSource
    Friend WithEvents KANELLOPOULOSTableAdapter As DMDataSetTableAdapters.KANELLOPOULOSTableAdapter
    Friend WithEvents colnetAmount As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colkitchen As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colmaterials As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colgeneral As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colcloset As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colbathroomFurn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepCopyDelete As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents colFullTranshDescription As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cmdSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents colisCredit As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colord As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsupID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coluploadDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldtYBuy As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colcreatedOn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colcreatedBy As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colbuyID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colcmt1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepKan_O As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents KANELLOPOULOSOBindingSource As BindingSource
    Friend WithEvents KANELLOPOULOS_OTableAdapter As DMDataSetTableAdapters.KANELLOPOULOS_OTableAdapter
    Friend WithEvents colKanO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ReptxtO As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents colDeltOrders As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DM_TRANS As DM_TRANS
    Friend WithEvents Vw_TRANSHTableAdapter As DM_TRANSTableAdapters.vw_TRANSHTableAdapter
    Friend WithEvents CCT_TRANSHTableAdapter As DM_TRANSTableAdapters.CCT_TRANSHTableAdapter
    Friend WithEvents colextraCus As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cmdKeywords As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
End Class
