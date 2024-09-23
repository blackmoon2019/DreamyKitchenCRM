<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPriceListBatchUpdate))
        Dim GridFormatRule1 As DevExpress.XtraGrid.GridFormatRule = New DevExpress.XtraGrid.GridFormatRule()
        Dim FormatConditionRuleIconSet1 As DevExpress.XtraEditors.FormatConditionRuleIconSet = New DevExpress.XtraEditors.FormatConditionRuleIconSet()
        Dim FormatConditionIconSet1 As DevExpress.XtraEditors.FormatConditionIconSet = New DevExpress.XtraEditors.FormatConditionIconSet()
        Dim FormatConditionIconSetIcon1 As DevExpress.XtraEditors.FormatConditionIconSetIcon = New DevExpress.XtraEditors.FormatConditionIconSetIcon()
        Dim FormatConditionIconSetIcon2 As DevExpress.XtraEditors.FormatConditionIconSetIcon = New DevExpress.XtraEditors.FormatConditionIconSetIcon()
        Dim FormatConditionIconSetIcon3 As DevExpress.XtraEditors.FormatConditionIconSetIcon = New DevExpress.XtraEditors.FormatConditionIconSetIcon()
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
        Me.colStatus = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepCopyDelete = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.DockManager1 = New DevExpress.XtraBars.Docking.DockManager(Me.components)
        Me.DockPanel1 = New DevExpress.XtraBars.Docking.DockPanel()
        Me.DockPanel1_Container = New DevExpress.XtraBars.Docking.ControlContainer()
        Me.TileNavPane1 = New DevExpress.XtraBars.Navigation.TileNavPane()
        Me.NavKanelopoulos = New DevExpress.XtraBars.Navigation.NavButton()
        Me.panelContainer1 = New DevExpress.XtraBars.Docking.DockPanel()
        Me.DockPanel3 = New DevExpress.XtraBars.Docking.DockPanel()
        Me.DockPanel3_Container = New DevExpress.XtraBars.Docking.ControlContainer()
        Me.LayoutControl2 = New DevExpress.XtraLayout.LayoutControl()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.PRICELISTSPRMBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DMDataSet = New DreamyKitchenCRM.DMDataSet()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colFromValue = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colToValue = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colvalue = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsupID1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepValueList = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.txtDiscount = New DevExpress.XtraEditors.TextEdit()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.Lcost3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.DockPanel2 = New DevExpress.XtraBars.Docking.DockPanel()
        Me.DockPanel2_Container = New DevExpress.XtraBars.Docking.ControlContainer()
        Me.lstLog = New DevExpress.XtraEditors.ImageListBoxControl()
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.cmdExcel = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdKeywords = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdSave = New DevExpress.XtraEditors.SimpleButton()
        Me.ProgressBarControl1 = New DevExpress.XtraEditors.ProgressBarControl()
        Me.cmdExit = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdDelete = New DevExpress.XtraEditors.SimpleButton()
        Me.grdPRICELIST = New DevExpress.XtraGrid.GridControl()
        Me.PRICELISTTEMPBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView5 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colcode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsupID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colvaluelistID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCustomCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colname = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coldescription = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colInitialPrice = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPriceVat = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coldiscount = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPrice = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colcompleted = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDiscountPrice = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colvalueListItemID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepCus = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.txtImageCorrect = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.txtImageError = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.RepColBtn = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.RepTransh = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.RepColExcel = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.RepKan_O = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.ReptxtO = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.KANELLOPOULOSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.XtraOpenFileDialog1 = New DevExpress.XtraEditors.XtraOpenFileDialog(Me.components)
        Me.ImageCollection1 = New DevExpress.Utils.ImageCollection(Me.components)
        Me.PRICELIST_TEMPTableAdapter = New DreamyKitchenCRM.DMDataSetTableAdapters.PRICELIST_TEMPTableAdapter()
        Me.PRICELISTS_PRMTableAdapter = New DreamyKitchenCRM.DMDataSetTableAdapters.PRICELISTS_PRMTableAdapter()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        CType(Me.RepCopyDelete, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DockManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DockPanel1.SuspendLayout()
        Me.DockPanel1_Container.SuspendLayout()
        CType(Me.TileNavPane1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelContainer1.SuspendLayout()
        Me.DockPanel3.SuspendLayout()
        Me.DockPanel3_Container.SuspendLayout()
        CType(Me.LayoutControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl2.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PRICELISTSPRMBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DMDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepValueList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDiscount.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Lcost3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DockPanel2.SuspendLayout()
        Me.DockPanel2_Container.SuspendLayout()
        CType(Me.lstLog, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.ProgressBarControl1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdPRICELIST, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PRICELISTTEMPBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepCus, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtImageCorrect, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtImageError, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepColBtn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepTransh, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepColExcel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepKan_O, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReptxtO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KANELLOPOULOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImageCollection1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'colStatus
        '
        Me.colStatus.AppearanceCell.Options.UseBackColor = True
        Me.colStatus.Caption = " "
        Me.colStatus.FieldName = "Status"
        Me.colStatus.MinWidth = 30
        Me.colStatus.Name = "colStatus"
        Me.colStatus.OptionsColumn.AllowEdit = False
        Me.colStatus.Visible = True
        Me.colStatus.VisibleIndex = 10
        Me.colStatus.Width = 38
        '
        'RepCopyDelete
        '
        Me.RepCopyDelete.AutoHeight = False
        EditorButtonImageOptions1.Image = Global.DreamyKitchenCRM.My.Resources.Resources.icons8_copy_16
        Me.RepCopyDelete.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, EditorButtonImageOptions1, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, SerializableAppearanceObject2, SerializableAppearanceObject3, SerializableAppearanceObject4, "", Nothing, Nothing, DevExpress.Utils.ToolTipAnchor.[Default]), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete)})
        Me.RepCopyDelete.Name = "RepCopyDelete"
        '
        'DockManager1
        '
        Me.DockManager1.Form = Me
        Me.DockManager1.RootPanels.AddRange(New DevExpress.XtraBars.Docking.DockPanel() {Me.DockPanel1, Me.panelContainer1})
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
        'panelContainer1
        '
        Me.panelContainer1.Controls.Add(Me.DockPanel3)
        Me.panelContainer1.Controls.Add(Me.DockPanel2)
        Me.panelContainer1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Right
        Me.panelContainer1.ID = New System.Guid("5a4357ff-89fc-44bd-91a8-cb56a63203a4")
        Me.panelContainer1.Location = New System.Drawing.Point(1324, 140)
        Me.panelContainer1.Name = "panelContainer1"
        Me.panelContainer1.OriginalSize = New System.Drawing.Size(822, 226)
        Me.panelContainer1.Size = New System.Drawing.Size(822, 1008)
        Me.panelContainer1.Text = "panelContainer1"
        '
        'DockPanel3
        '
        Me.DockPanel3.Controls.Add(Me.DockPanel3_Container)
        Me.DockPanel3.Dock = DevExpress.XtraBars.Docking.DockingStyle.Fill
        Me.DockPanel3.FloatVertical = True
        Me.DockPanel3.ID = New System.Guid("8087a73d-6cc1-4366-a744-cc381866efee")
        Me.DockPanel3.Location = New System.Drawing.Point(0, 0)
        Me.DockPanel3.Name = "DockPanel3"
        Me.DockPanel3.OriginalSize = New System.Drawing.Size(200, 200)
        Me.DockPanel3.Size = New System.Drawing.Size(822, 451)
        Me.DockPanel3.Text = "Παράμετροι"
        '
        'DockPanel3_Container
        '
        Me.DockPanel3_Container.Controls.Add(Me.LayoutControl2)
        Me.DockPanel3_Container.Location = New System.Drawing.Point(7, 38)
        Me.DockPanel3_Container.Name = "DockPanel3_Container"
        Me.DockPanel3_Container.Size = New System.Drawing.Size(811, 406)
        Me.DockPanel3_Container.TabIndex = 0
        '
        'LayoutControl2
        '
        Me.LayoutControl2.Controls.Add(Me.GridControl1)
        Me.LayoutControl2.Controls.Add(Me.txtDiscount)
        Me.LayoutControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl2.Name = "LayoutControl2"
        Me.LayoutControl2.Root = Me.LayoutControlGroup1
        Me.LayoutControl2.Size = New System.Drawing.Size(811, 406)
        Me.LayoutControl2.TabIndex = 0
        Me.LayoutControl2.Text = "LayoutControl2"
        '
        'GridControl1
        '
        Me.GridControl1.DataSource = Me.PRICELISTSPRMBindingSource
        Me.GridControl1.EmbeddedNavigator.Buttons.EndEdit.Visible = False
        Me.GridControl1.EmbeddedNavigator.Buttons.First.Visible = False
        Me.GridControl1.EmbeddedNavigator.Buttons.Last.Visible = False
        Me.GridControl1.EmbeddedNavigator.Buttons.Next.Visible = False
        Me.GridControl1.EmbeddedNavigator.Buttons.NextPage.Visible = False
        Me.GridControl1.EmbeddedNavigator.Buttons.Prev.Visible = False
        Me.GridControl1.EmbeddedNavigator.Buttons.PrevPage.Visible = False
        Me.GridControl1.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.GridControl1.Location = New System.Drawing.Point(12, 64)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepValueList})
        Me.GridControl1.Size = New System.Drawing.Size(787, 330)
        Me.GridControl1.TabIndex = 2
        Me.GridControl1.UseEmbeddedNavigator = True
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'PRICELISTSPRMBindingSource
        '
        Me.PRICELISTSPRMBindingSource.DataMember = "PRICELISTS_PRM"
        Me.PRICELISTSPRMBindingSource.DataSource = Me.DMDataSet
        '
        'DMDataSet
        '
        Me.DMDataSet.DataSetName = "DMDataSet"
        Me.DMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colFromValue, Me.colToValue, Me.colvalue, Me.colID, Me.colsupID1})
        Me.GridView1.DetailHeight = 289
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.AlignGroupSummaryInGroupRow = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridView1.OptionsEditForm.PopupEditFormWidth = 720
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'colFromValue
        '
        Me.colFromValue.Caption = "Από"
        Me.colFromValue.DisplayFormat.FormatString = "c2"
        Me.colFromValue.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colFromValue.FieldName = "FromValue"
        Me.colFromValue.MinWidth = 30
        Me.colFromValue.Name = "colFromValue"
        Me.colFromValue.Visible = True
        Me.colFromValue.VisibleIndex = 0
        Me.colFromValue.Width = 112
        '
        'colToValue
        '
        Me.colToValue.Caption = "Έως"
        Me.colToValue.DisplayFormat.FormatString = "c2"
        Me.colToValue.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colToValue.FieldName = "ToValue"
        Me.colToValue.MinWidth = 30
        Me.colToValue.Name = "colToValue"
        Me.colToValue.Visible = True
        Me.colToValue.VisibleIndex = 1
        Me.colToValue.Width = 112
        '
        'colvalue
        '
        Me.colvalue.Caption = "Περιγραφή"
        Me.colvalue.FieldName = "value"
        Me.colvalue.MinWidth = 30
        Me.colvalue.Name = "colvalue"
        Me.colvalue.Visible = True
        Me.colvalue.VisibleIndex = 2
        Me.colvalue.Width = 112
        '
        'colID
        '
        Me.colID.FieldName = "ID"
        Me.colID.MinWidth = 30
        Me.colID.Name = "colID"
        Me.colID.Width = 112
        '
        'colsupID1
        '
        Me.colsupID1.FieldName = "supID"
        Me.colsupID1.MinWidth = 30
        Me.colsupID1.Name = "colsupID1"
        Me.colsupID1.Width = 112
        '
        'RepValueList
        '
        Me.RepValueList.AutoHeight = False
        Me.RepValueList.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepValueList.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 30, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("name", "Κατηγορία", 52, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("GroupName", "Group Name", 103, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default])})
        Me.RepValueList.DisplayMember = "name"
        Me.RepValueList.Name = "RepValueList"
        Me.RepValueList.NullText = ""
        Me.RepValueList.ValueMember = "ID"
        '
        'txtDiscount
        '
        Me.txtDiscount.EditValue = "0%"
        Me.txtDiscount.Location = New System.Drawing.Point(12, 34)
        Me.txtDiscount.Margin = New System.Windows.Forms.Padding(15)
        Me.txtDiscount.Name = "txtDiscount"
        Me.txtDiscount.Properties.DisplayFormat.FormatString = "c"
        Me.txtDiscount.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtDiscount.Properties.EditFormat.FormatString = "n2"
        Me.txtDiscount.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtDiscount.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtDiscount.Properties.MaskSettings.Set("MaskManagerType", GetType(DevExpress.Data.Mask.NumericMaskManager))
        Me.txtDiscount.Properties.MaskSettings.Set("mask", "P0")
        Me.txtDiscount.Properties.Tag = "BenchExtraPrice"
        Me.txtDiscount.Properties.UseReadOnlyAppearance = False
        Me.txtDiscount.Size = New System.Drawing.Size(787, 26)
        Me.txtDiscount.StyleController = Me.LayoutControl2
        Me.txtDiscount.TabIndex = 0
        Me.txtDiscount.Tag = "discount1,0,1,2"
        Me.txtDiscount.Visible = False
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.Lcost3, Me.LayoutControlItem7})
        Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(811, 406)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'Lcost3
        '
        Me.Lcost3.Control = Me.txtDiscount
        Me.Lcost3.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.Lcost3.CustomizationFormText = "Έκπτωση"
        Me.Lcost3.HighlightFocusedItem = DevExpress.Utils.DefaultBoolean.[True]
        Me.Lcost3.Location = New System.Drawing.Point(0, 0)
        Me.Lcost3.Name = "Lcost3"
        Me.Lcost3.Size = New System.Drawing.Size(791, 52)
        Me.Lcost3.Text = "Έκπτωση"
        Me.Lcost3.TextLocation = DevExpress.Utils.Locations.Top
        Me.Lcost3.TextSize = New System.Drawing.Size(66, 19)
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.Control = Me.GridControl1
        Me.LayoutControlItem7.Location = New System.Drawing.Point(0, 52)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(791, 334)
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem7.TextVisible = False
        '
        'DockPanel2
        '
        Me.DockPanel2.Controls.Add(Me.DockPanel2_Container)
        Me.DockPanel2.Dock = DevExpress.XtraBars.Docking.DockingStyle.Fill
        Me.DockPanel2.ID = New System.Guid("3ffe703d-37e8-45f1-bd6f-ffd119d21394")
        Me.DockPanel2.Location = New System.Drawing.Point(0, 451)
        Me.DockPanel2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DockPanel2.Name = "DockPanel2"
        Me.DockPanel2.OriginalSize = New System.Drawing.Size(822, 226)
        Me.DockPanel2.Size = New System.Drawing.Size(822, 557)
        Me.DockPanel2.Text = "Αρχείο Καταγραφής"
        '
        'DockPanel2_Container
        '
        Me.DockPanel2_Container.Controls.Add(Me.lstLog)
        Me.DockPanel2_Container.Location = New System.Drawing.Point(7, 38)
        Me.DockPanel2_Container.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DockPanel2_Container.Name = "DockPanel2_Container"
        Me.DockPanel2_Container.Size = New System.Drawing.Size(811, 515)
        Me.DockPanel2_Container.TabIndex = 0
        '
        'lstLog
        '
        Me.lstLog.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lstLog.Location = New System.Drawing.Point(0, 0)
        Me.lstLog.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lstLog.Name = "lstLog"
        Me.lstLog.Size = New System.Drawing.Size(811, 515)
        Me.lstLog.TabIndex = 6
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.cmdExcel)
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
        Me.LayoutControl1.Size = New System.Drawing.Size(1324, 1008)
        Me.LayoutControl1.TabIndex = 2
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'cmdExcel
        '
        Me.cmdExcel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdExcel.ImageOptions.Image = Global.DreamyKitchenCRM.My.Resources.Resources.ExportXlsLarge
        Me.cmdExcel.Location = New System.Drawing.Point(12, 960)
        Me.cmdExcel.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdExcel.Name = "cmdExcel"
        Me.cmdExcel.Size = New System.Drawing.Size(214, 36)
        Me.cmdExcel.StyleController = Me.LayoutControl1
        Me.cmdExcel.TabIndex = 6
        Me.cmdExcel.Text = "Επιλογή Τιμοκαταλόγου"
        '
        'cmdKeywords
        '
        Me.cmdKeywords.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdKeywords.Enabled = False
        Me.cmdKeywords.ImageOptions.Image = Global.DreamyKitchenCRM.My.Resources.Resources.icons8_keyword_241
        Me.cmdKeywords.Location = New System.Drawing.Point(469, 960)
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
        Me.cmdSave.Location = New System.Drawing.Point(230, 960)
        Me.cmdSave.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(125, 32)
        Me.cmdSave.StyleController = Me.LayoutControl1
        Me.cmdSave.TabIndex = 4
        Me.cmdSave.Text = "Αποθήκευση"
        '
        'ProgressBarControl1
        '
        Me.ProgressBarControl1.Location = New System.Drawing.Point(607, 960)
        Me.ProgressBarControl1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ProgressBarControl1.Name = "ProgressBarControl1"
        Me.ProgressBarControl1.Properties.ShowTitle = True
        Me.ProgressBarControl1.Size = New System.Drawing.Size(602, 20)
        Me.ProgressBarControl1.StyleController = Me.LayoutControl1
        Me.ProgressBarControl1.TabIndex = 1
        Me.ProgressBarControl1.Visible = False
        '
        'cmdExit
        '
        Me.cmdExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdExit.ImageOptions.Image = CType(resources.GetObject("cmdExit.ImageOptions.Image"), System.Drawing.Image)
        Me.cmdExit.Location = New System.Drawing.Point(1223, 960)
        Me.cmdExit.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(89, 32)
        Me.cmdExit.StyleController = Me.LayoutControl1
        Me.cmdExit.TabIndex = 3
        Me.cmdExit.Text = "Έξοδος"
        '
        'cmdDelete
        '
        Me.cmdDelete.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdDelete.ImageOptions.Image = Global.DreamyKitchenCRM.My.Resources.Resources.icons8_delete_24
        Me.cmdDelete.Location = New System.Drawing.Point(359, 960)
        Me.cmdDelete.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(106, 32)
        Me.cmdDelete.StyleController = Me.LayoutControl1
        Me.cmdDelete.TabIndex = 2
        Me.cmdDelete.Text = "Διαγραφή"
        '
        'grdPRICELIST
        '
        Me.grdPRICELIST.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdPRICELIST.DataSource = Me.PRICELISTTEMPBindingSource
        Me.grdPRICELIST.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(6)
        Me.grdPRICELIST.Location = New System.Drawing.Point(12, 12)
        Me.grdPRICELIST.MainView = Me.GridView5
        Me.grdPRICELIST.Margin = New System.Windows.Forms.Padding(4)
        Me.grdPRICELIST.Name = "grdPRICELIST"
        Me.grdPRICELIST.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepCus, Me.txtImageCorrect, Me.txtImageError, Me.RepColBtn, Me.RepTransh, Me.RepColExcel, Me.RepCopyDelete, Me.RepKan_O, Me.ReptxtO})
        Me.grdPRICELIST.Size = New System.Drawing.Size(1300, 944)
        Me.grdPRICELIST.TabIndex = 0
        Me.grdPRICELIST.UseEmbeddedNavigator = True
        Me.grdPRICELIST.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView5})
        '
        'PRICELISTTEMPBindingSource
        '
        Me.PRICELISTTEMPBindingSource.DataMember = "PRICELIST_TEMP"
        Me.PRICELISTTEMPBindingSource.DataSource = Me.DMDataSet
        '
        'GridView5
        '
        Me.GridView5.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.colcode, Me.colsupID, Me.colvaluelistID, Me.colCustomCode, Me.colname, Me.coldescription, Me.colInitialPrice, Me.colPriceVat, Me.coldiscount, Me.colPrice, Me.colStatus, Me.colcompleted, Me.colDiscountPrice, Me.colvalueListItemID})
        Me.GridView5.DetailHeight = 289
        Me.GridView5.FixedLineWidth = 3
        GridFormatRule1.Column = Me.colStatus
        GridFormatRule1.Name = "Format0"
        FormatConditionIconSet1.CategoryName = "Symbols"
        FormatConditionIconSetIcon1.PredefinedName = "Symbols23_1.png"
        FormatConditionIconSetIcon1.Value = New Decimal(New Integer() {2, 0, 0, 0})
        FormatConditionIconSetIcon1.ValueComparison = DevExpress.XtraEditors.FormatConditionComparisonType.GreaterOrEqual
        FormatConditionIconSetIcon2.PredefinedName = "Symbols23_2.png"
        FormatConditionIconSetIcon2.Value = New Decimal(New Integer() {1, 0, 0, 0})
        FormatConditionIconSetIcon2.ValueComparison = DevExpress.XtraEditors.FormatConditionComparisonType.GreaterOrEqual
        FormatConditionIconSetIcon3.PredefinedName = "Symbols23_3.png"
        FormatConditionIconSetIcon3.ValueComparison = DevExpress.XtraEditors.FormatConditionComparisonType.GreaterOrEqual
        FormatConditionIconSet1.Icons.Add(FormatConditionIconSetIcon1)
        FormatConditionIconSet1.Icons.Add(FormatConditionIconSetIcon2)
        FormatConditionIconSet1.Icons.Add(FormatConditionIconSetIcon3)
        FormatConditionIconSet1.Name = "Symbols3Circled"
        FormatConditionIconSet1.ValueType = DevExpress.XtraEditors.FormatConditionValueType.Number
        FormatConditionRuleIconSet1.IconSet = FormatConditionIconSet1
        GridFormatRule1.Rule = FormatConditionRuleIconSet1
        Me.GridView5.FormatRules.Add(GridFormatRule1)
        Me.GridView5.GridControl = Me.grdPRICELIST
        Me.GridView5.LevelIndent = 0
        Me.GridView5.Name = "GridView5"
        Me.GridView5.OptionsBehavior.AlignGroupSummaryInGroupRow = DevExpress.Utils.DefaultBoolean.[False]
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
        '
        'GridColumn1
        '
        Me.GridColumn1.AppearanceCell.Options.UseBackColor = True
        Me.GridColumn1.FieldName = "ID"
        Me.GridColumn1.MinWidth = 30
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.OptionsColumn.AllowEdit = False
        Me.GridColumn1.Width = 112
        '
        'colcode
        '
        Me.colcode.AppearanceCell.Options.UseBackColor = True
        Me.colcode.FieldName = "code"
        Me.colcode.MinWidth = 30
        Me.colcode.Name = "colcode"
        Me.colcode.OptionsColumn.AllowEdit = False
        Me.colcode.Width = 112
        '
        'colsupID
        '
        Me.colsupID.AppearanceCell.Options.UseBackColor = True
        Me.colsupID.FieldName = "supID"
        Me.colsupID.MinWidth = 30
        Me.colsupID.Name = "colsupID"
        Me.colsupID.OptionsColumn.AllowEdit = False
        Me.colsupID.Width = 112
        '
        'colvaluelistID
        '
        Me.colvaluelistID.AppearanceCell.Options.UseBackColor = True
        Me.colvaluelistID.FieldName = "valuelistID"
        Me.colvaluelistID.MinWidth = 30
        Me.colvaluelistID.Name = "colvaluelistID"
        Me.colvaluelistID.OptionsColumn.AllowEdit = False
        Me.colvaluelistID.Width = 112
        '
        'colCustomCode
        '
        Me.colCustomCode.AppearanceCell.Options.UseBackColor = True
        Me.colCustomCode.Caption = "Κωδικός"
        Me.colCustomCode.FieldName = "CustomCode"
        Me.colCustomCode.MinWidth = 30
        Me.colCustomCode.Name = "colCustomCode"
        Me.colCustomCode.OptionsColumn.AllowEdit = False
        Me.colCustomCode.Visible = True
        Me.colCustomCode.VisibleIndex = 1
        Me.colCustomCode.Width = 91
        '
        'colname
        '
        Me.colname.AppearanceCell.Options.UseBackColor = True
        Me.colname.Caption = "Περιγραφή"
        Me.colname.FieldName = "name"
        Me.colname.MinWidth = 30
        Me.colname.Name = "colname"
        Me.colname.OptionsColumn.AllowEdit = False
        Me.colname.Visible = True
        Me.colname.VisibleIndex = 2
        Me.colname.Width = 609
        '
        'coldescription
        '
        Me.coldescription.AppearanceCell.Options.UseBackColor = True
        Me.coldescription.Caption = "Δευτερεόυσα Περιγραφή"
        Me.coldescription.FieldName = "description"
        Me.coldescription.MinWidth = 30
        Me.coldescription.Name = "coldescription"
        Me.coldescription.OptionsColumn.AllowEdit = False
        Me.coldescription.Visible = True
        Me.coldescription.VisibleIndex = 3
        Me.coldescription.Width = 208
        '
        'colInitialPrice
        '
        Me.colInitialPrice.AppearanceCell.Options.UseBackColor = True
        Me.colInitialPrice.Caption = "Αρχική Τιμή"
        Me.colInitialPrice.DisplayFormat.FormatString = "c2"
        Me.colInitialPrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colInitialPrice.FieldName = "InitialPrice"
        Me.colInitialPrice.MinWidth = 30
        Me.colInitialPrice.Name = "colInitialPrice"
        Me.colInitialPrice.OptionsColumn.AllowEdit = False
        Me.colInitialPrice.Visible = True
        Me.colInitialPrice.VisibleIndex = 4
        Me.colInitialPrice.Width = 118
        '
        'colPriceVat
        '
        Me.colPriceVat.Caption = "Αρχική Τιμή με ΦΠΑ"
        Me.colPriceVat.DisplayFormat.FormatString = "c2"
        Me.colPriceVat.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colPriceVat.FieldName = "PriceVat"
        Me.colPriceVat.MinWidth = 30
        Me.colPriceVat.Name = "colPriceVat"
        Me.colPriceVat.Visible = True
        Me.colPriceVat.VisibleIndex = 8
        Me.colPriceVat.Width = 154
        '
        'coldiscount
        '
        Me.coldiscount.AppearanceCell.Options.UseBackColor = True
        Me.coldiscount.Caption = "Έκπτωση %"
        Me.coldiscount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.coldiscount.FieldName = "discount"
        Me.coldiscount.MinWidth = 30
        Me.coldiscount.Name = "coldiscount"
        Me.coldiscount.OptionsColumn.AllowEdit = False
        Me.coldiscount.Visible = True
        Me.coldiscount.VisibleIndex = 5
        Me.coldiscount.Width = 123
        '
        'colPrice
        '
        Me.colPrice.AppearanceCell.Options.UseBackColor = True
        Me.colPrice.Caption = "Τιμή Λιανικής"
        Me.colPrice.DisplayFormat.FormatString = "c2"
        Me.colPrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colPrice.FieldName = "Price"
        Me.colPrice.MinWidth = 30
        Me.colPrice.Name = "colPrice"
        Me.colPrice.OptionsColumn.AllowEdit = False
        Me.colPrice.Visible = True
        Me.colPrice.VisibleIndex = 7
        Me.colPrice.Width = 130
        '
        'colcompleted
        '
        Me.colcompleted.Caption = "Ολοκληρωμένο"
        Me.colcompleted.FieldName = "completed"
        Me.colcompleted.MinWidth = 30
        Me.colcompleted.Name = "colcompleted"
        Me.colcompleted.Visible = True
        Me.colcompleted.VisibleIndex = 9
        Me.colcompleted.Width = 112
        '
        'colDiscountPrice
        '
        Me.colDiscountPrice.AppearanceCell.BackColor = System.Drawing.Color.Bisque
        Me.colDiscountPrice.AppearanceCell.Options.UseBackColor = True
        Me.colDiscountPrice.Caption = "Έκπτωση"
        Me.colDiscountPrice.DisplayFormat.FormatString = "c2"
        Me.colDiscountPrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colDiscountPrice.FieldName = "DiscountPrice"
        Me.colDiscountPrice.MinWidth = 30
        Me.colDiscountPrice.Name = "colDiscountPrice"
        Me.colDiscountPrice.Visible = True
        Me.colDiscountPrice.VisibleIndex = 6
        Me.colDiscountPrice.Width = 112
        '
        'colvalueListItemID
        '
        Me.colvalueListItemID.AppearanceCell.BackColor = System.Drawing.Color.Bisque
        Me.colvalueListItemID.AppearanceCell.Options.UseBackColor = True
        Me.colvalueListItemID.FieldName = "valueListItemID"
        Me.colvalueListItemID.MinWidth = 30
        Me.colvalueListItemID.Name = "colvalueListItemID"
        Me.colvalueListItemID.Visible = True
        Me.colvalueListItemID.VisibleIndex = 11
        Me.colvalueListItemID.Width = 112
        '
        'RepCus
        '
        Me.RepCus.AutoHeight = False
        Me.RepCus.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Clear), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Search)})
        Me.RepCus.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 31, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("code", "code", 49, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Fullname", "Ονοματεπώνυμο", 82, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("FatherName", "Father Name", 112, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CouID", "Cou ID", 66, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("AreaID", "Area ID", 71, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("AdrID", "Adr ID", 63, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("SourceID", "Source ID", 89, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("SalerID", "Saler ID", 75, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("DoyID", "Doy ID", 66, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("PrfID", "Prf ID", 58, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("phn", "phn", 43, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("mob", "mob", 47, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("fax", "fax", 36, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("email", "email", 53, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("afm", "afm", 42, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("cmt", "cmt", 41, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("modifiedBy", "modified By", 102, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("modifiedOn", "modified On", 105, DevExpress.Utils.FormatType.DateTime, "d/M/yyyy", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("createdOn", "created On", 97, DevExpress.Utils.FormatType.DateTime, "d/M/yyyy", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("createdBy", "created By", 94, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("nam", "nam", 47, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ttl", "ttl", 28, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ord", "ord", 39, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("name", "name", 56, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("OwnerFullName", "Owner Full Name", 144, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("TenantFullName", "Tenant Full Name", 148, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("bal", "bal", 36, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("out", "out", 38, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("closed", "closed", 60, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("RealName", "Real Name", 95, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("bdgNam", "bdg Nam", 84, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("bdgID", "bdg ID", 67, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("flrID", "flr ID", 52, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("OwnerID", "Owner ID", 86, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("TenantID", "Tenant ID", 90, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("old_code", "old_code", 81, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("sameOwnerTenant", "same Owner Tenant", 166, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("bdgCode", "bdg Code", 86, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("AdrName", "Adr Name", 89, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ar", "ar", 29, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("AreaName", "Area Name", 97, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("RepresentativeID", "Representative ID", 148, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("RepresentativeFullname", "Representative Fullname", 199, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default])})
        Me.RepCus.DisplayMember = "Fullname"
        Me.RepCus.Name = "RepCus"
        Me.RepCus.NullText = ""
        Me.RepCus.ValueMember = "ID"
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
        EditorButtonImageOptions2.SvgImage = CType(resources.GetObject("EditorButtonImageOptions2.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.RepColBtn.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, EditorButtonImageOptions2, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject5, SerializableAppearanceObject6, SerializableAppearanceObject7, SerializableAppearanceObject8, "", Nothing, Nothing, DevExpress.Utils.ToolTipAnchor.[Default])})
        Me.RepColBtn.Name = "RepColBtn"
        Me.RepColBtn.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'RepTransh
        '
        Me.RepTransh.AutoHeight = False
        Me.RepTransh.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Clear), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Search)})
        Me.RepTransh.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 30, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("code", "code", 46, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("cusID", "cus ID", 58, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("dtCharge", "dt Charge", 82, DevExpress.Utils.FormatType.DateTime, "d/M/yyyy", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("GRMONTH", "GRMONTH", 90, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("amt", "amt", 40, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("cmt", "cmt", 39, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("modifiedBy", "modified By", 97, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("modifiedOn", "modified On", 101, DevExpress.Utils.FormatType.DateTime, "d/M/yyyy", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("createdOn", "created On", 90, DevExpress.Utils.FormatType.DateTime, "d/M/yyyy", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("createdBy", "created By", 86, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Fullname", "Fullname", 77, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("RealName", "Real Name", 89, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Totamt", "Totamt", 64, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("vatamt", "vatamt", 61, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("bal", "bal", 34, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("SalerName", "Saler Name", 94, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("SalerID", "Saler ID", 70, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("EmpTID", "Emp TID", 77, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("invTypeDescr", "inv Type Descr", 118, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("description", "description", 90, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("invType", "inv Type", 74, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("empID", "emp ID", 66, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("DebitCost", "Debit Cost", 86, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("DevicesCost", "Devices Cost", 102, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("salerProfit", "saler Profit", 89, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("FullTranshDescription", "Έργα", 176, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("AreaId", "Area Id", 66, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("adrid", "adrid", 49, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("couid", "couid", 51, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("benchSalesPrice", "bench Sales Price", 135, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("benchPurchasePrice", "bench Purchase Price", 162, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("benchProfit", "bench Profit", 98, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("dtAgreement", "dt Agreement", 110, DevExpress.Utils.FormatType.DateTime, "d/M/yyyy", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("offerCusAcceptance", "Αποδοχή Προσφοράς", 161, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("waitingForAgreement", "waiting For Agreement", 175, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Iskitchen", "Iskitchen", 76, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Iscloset", "Iscloset", 66, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Isdoor", "Isdoor", 59, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Issc", "Issc", 40, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default])})
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
        'RepColExcel
        '
        Me.RepColExcel.AutoHeight = False
        EditorButtonImageOptions3.SvgImage = CType(resources.GetObject("EditorButtonImageOptions3.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.RepColExcel.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, EditorButtonImageOptions3, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject9, SerializableAppearanceObject10, SerializableAppearanceObject11, SerializableAppearanceObject12, "", Nothing, Nothing, DevExpress.Utils.ToolTipAnchor.[Default])})
        Me.RepColExcel.Name = "RepColExcel"
        Me.RepColExcel.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'RepKan_O
        '
        Me.RepKan_O.AllowMouseWheel = False
        Me.RepKan_O.AutoHeight = False
        Me.RepKan_O.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Minus)})
        Me.RepKan_O.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 31, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("kanID", "kan ID", 64, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("code", "code", 49, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("name", "Δελτία", 56, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default])})
        Me.RepKan_O.DisplayMember = "name"
        Me.RepKan_O.Name = "RepKan_O"
        Me.RepKan_O.NullText = ""
        Me.RepKan_O.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.RepKan_O.ValueMember = "ID"
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
        Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem3, Me.LayoutControlItem5, Me.LayoutControlItem2, Me.LayoutControlItem6, Me.LayoutControlItem4, Me.LayoutControlItem8, Me.EmptySpaceItem1})
        Me.Root.Name = "Root"
        Me.Root.Size = New System.Drawing.Size(1324, 1008)
        Me.Root.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.grdPRICELIST
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(1304, 948)
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.cmdExit
        Me.LayoutControlItem3.Location = New System.Drawing.Point(1211, 948)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(93, 40)
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem3.TextVisible = False
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.cmdSave
        Me.LayoutControlItem5.Location = New System.Drawing.Point(218, 948)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(129, 40)
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem5.TextVisible = False
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.cmdDelete
        Me.LayoutControlItem2.Location = New System.Drawing.Point(347, 948)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(110, 40)
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem2.TextVisible = False
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.cmdKeywords
        Me.LayoutControlItem6.Location = New System.Drawing.Point(457, 948)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(138, 40)
        Me.LayoutControlItem6.Text = "Λέξεις Κλειδιά"
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem6.TextVisible = False
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.ProgressBarControl1
        Me.LayoutControlItem4.Location = New System.Drawing.Point(595, 948)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(606, 40)
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem4.TextVisible = False
        '
        'LayoutControlItem8
        '
        Me.LayoutControlItem8.Control = Me.cmdExcel
        Me.LayoutControlItem8.Location = New System.Drawing.Point(0, 948)
        Me.LayoutControlItem8.Name = "LayoutControlItem8"
        Me.LayoutControlItem8.Size = New System.Drawing.Size(218, 40)
        Me.LayoutControlItem8.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem8.TextVisible = False
        '
        'KANELLOPOULOSBindingSource
        '
        Me.KANELLOPOULOSBindingSource.DataMember = "KANELLOPOULOS"
        Me.KANELLOPOULOSBindingSource.DataSource = Me.DMDataSet
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
        'PRICELIST_TEMPTableAdapter
        '
        Me.PRICELIST_TEMPTableAdapter.ClearBeforeFill = True
        '
        'PRICELISTS_PRMTableAdapter
        '
        Me.PRICELISTS_PRMTableAdapter.ClearBeforeFill = True
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(1201, 948)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(10, 40)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'frmPriceListBatchUpdate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(2146, 1148)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Controls.Add(Me.panelContainer1)
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
        Me.panelContainer1.ResumeLayout(False)
        Me.DockPanel3.ResumeLayout(False)
        Me.DockPanel3_Container.ResumeLayout(False)
        CType(Me.LayoutControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl2.ResumeLayout(False)
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PRICELISTSPRMBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DMDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepValueList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDiscount.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Lcost3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DockPanel2.ResumeLayout(False)
        Me.DockPanel2_Container.ResumeLayout(False)
        CType(Me.lstLog, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.ProgressBarControl1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdPRICELIST, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PRICELISTTEMPBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepCus, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtImageCorrect, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtImageError, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepColBtn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepTransh, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepColExcel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepKan_O, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReptxtO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KANELLOPOULOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImageCollection1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents ProgressBarControl1 As DevExpress.XtraEditors.ProgressBarControl
    Friend WithEvents cmdExit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdDelete As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents grdPRICELIST As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView5 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RepCus As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents RepTransh As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents RepColBtn As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents RepColExcel As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents txtImageCorrect As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents txtImageError As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents Root As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents XtraOpenFileDialog1 As DevExpress.XtraEditors.XtraOpenFileDialog
    Friend WithEvents ImageCollection1 As DevExpress.Utils.ImageCollection
    Friend WithEvents DMDataSet As DMDataSet
    Friend WithEvents KANELLOPOULOSBindingSource As BindingSource
    Friend WithEvents RepCopyDelete As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents cmdSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents RepKan_O As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents ReptxtO As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents cmdKeywords As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents PRICELISTTEMPBindingSource As BindingSource
    Friend WithEvents colStatus As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PRICELIST_TEMPTableAdapter As DMDataSetTableAdapters.PRICELIST_TEMPTableAdapter
    Friend WithEvents DockPanel3 As DevExpress.XtraBars.Docking.DockPanel
    Friend WithEvents DockPanel3_Container As DevExpress.XtraBars.Docking.ControlContainer
    Friend WithEvents LayoutControl2 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents txtDiscount As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Lcost3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents panelContainer1 As DevExpress.XtraBars.Docking.DockPanel
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RepValueList As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents PRICELISTSPRMBindingSource As BindingSource
    Friend WithEvents colFromValue As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colToValue As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colvalue As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PRICELISTS_PRMTableAdapter As DMDataSetTableAdapters.PRICELISTS_PRMTableAdapter
    Friend WithEvents cmdExcel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents colID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsupID1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colcode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsupID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colvaluelistID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCustomCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colname As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldescription As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colInitialPrice As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldiscount As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPrice As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPriceVat As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colcompleted As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colvalueListItemID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDiscountPrice As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
End Class
