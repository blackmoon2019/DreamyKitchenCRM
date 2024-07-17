<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInstM
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInstM))
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.grdInst = New DevExpress.XtraGrid.GridControl()
        Me.VwINSTPerSerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DreamyKitchenDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DreamyKitchenDataSet = New DreamyKitchenCRM.DreamyKitchenDataSet()
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colcctName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFullTranshDescription = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coldtDeliverDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colGRMONTH = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSalerName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colcmt = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTotalCost = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colYPOL = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colkitchen = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colcloset = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coldoors = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsc = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemButtonOil = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.cmdExit = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdSave = New DevExpress.XtraEditors.SimpleButton()
        Me.cboSER = New DevExpress.XtraEditors.LookUpEdit()
        Me.dtDeliverDate = New DevExpress.XtraEditors.DateEdit()
        Me.txtComments = New DevExpress.XtraEditors.MemoEdit()
        Me.txtCode = New DevExpress.XtraEditors.TextEdit()
        Me.txtCost = New DevExpress.XtraEditors.TextEdit()
        Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem14 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.Lcost = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.Vw_INSTPerSerTableAdapter = New DreamyKitchenCRM.DreamyKitchenDataSetTableAdapters.vw_INSTPerSerTableAdapter()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.grdInst, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VwINSTPerSerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DreamyKitchenDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DreamyKitchenDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemButtonOil, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboSER.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtDeliverDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtDeliverDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtComments.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCost.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Lcost, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.grdInst)
        Me.LayoutControl1.Controls.Add(Me.cmdExit)
        Me.LayoutControl1.Controls.Add(Me.cmdSave)
        Me.LayoutControl1.Controls.Add(Me.cboSER)
        Me.LayoutControl1.Controls.Add(Me.dtDeliverDate)
        Me.LayoutControl1.Controls.Add(Me.txtComments)
        Me.LayoutControl1.Controls.Add(Me.txtCode)
        Me.LayoutControl1.Controls.Add(Me.txtCost)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Margin = New System.Windows.Forms.Padding(4)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(503, 94, 650, 400)
        Me.LayoutControl1.Root = Me.Root
        Me.LayoutControl1.Size = New System.Drawing.Size(1734, 953)
        Me.LayoutControl1.TabIndex = 3
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'grdInst
        '
        Me.grdInst.DataSource = Me.VwINSTPerSerBindingSource
        Me.grdInst.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(6)
        Me.grdInst.Location = New System.Drawing.Point(12, 74)
        Me.grdInst.MainView = Me.GridView3
        Me.grdInst.Margin = New System.Windows.Forms.Padding(4)
        Me.grdInst.Name = "grdInst"
        Me.grdInst.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemButtonOil})
        Me.grdInst.Size = New System.Drawing.Size(1710, 502)
        Me.grdInst.TabIndex = 43
        Me.grdInst.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView3})
        '
        'VwINSTPerSerBindingSource
        '
        Me.VwINSTPerSerBindingSource.DataMember = "vw_INSTPerSer"
        Me.VwINSTPerSerBindingSource.DataSource = Me.DreamyKitchenDataSetBindingSource
        '
        'DreamyKitchenDataSetBindingSource
        '
        Me.DreamyKitchenDataSetBindingSource.DataSource = Me.DreamyKitchenDataSet
        Me.DreamyKitchenDataSetBindingSource.Position = 0
        '
        'DreamyKitchenDataSet
        '
        Me.DreamyKitchenDataSet.DataSetName = "DreamyKitchenDataSet"
        Me.DreamyKitchenDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView3
        '
        Me.GridView3.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colID, Me.colcctName, Me.colFullTranshDescription, Me.coldtDeliverDate, Me.colGRMONTH, Me.colSalerName, Me.colcmt, Me.colTotalCost, Me.colYPOL, Me.colkitchen, Me.colcloset, Me.coldoors, Me.colsc})
        Me.GridView3.GridControl = Me.grdInst
        Me.GridView3.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always
        Me.GridView3.LevelIndent = 0
        Me.GridView3.Name = "GridView3"
        Me.GridView3.OptionsBehavior.AlignGroupSummaryInGroupRow = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridView3.OptionsBehavior.Editable = False
        Me.GridView3.OptionsEditForm.PopupEditFormWidth = 720
        Me.GridView3.OptionsMenu.EnableGroupRowMenu = True
        Me.GridView3.OptionsMenu.ShowConditionalFormattingItem = True
        Me.GridView3.OptionsMenu.ShowFooterItem = True
        Me.GridView3.OptionsMenu.ShowGroupSummaryEditorItem = True
        Me.GridView3.OptionsView.ColumnAutoWidth = False
        Me.GridView3.OptionsView.ShowFooter = True
        Me.GridView3.PreviewIndent = 0
        Me.GridView3.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.coldtDeliverDate, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'colID
        '
        Me.colID.FieldName = "ID"
        Me.colID.MinWidth = 18
        Me.colID.Name = "colID"
        Me.colID.Width = 67
        '
        'colcctName
        '
        Me.colcctName.Caption = "Πελάτης"
        Me.colcctName.FieldName = "cctName"
        Me.colcctName.MinWidth = 18
        Me.colcctName.Name = "colcctName"
        Me.colcctName.Visible = True
        Me.colcctName.VisibleIndex = 0
        Me.colcctName.Width = 308
        '
        'colFullTranshDescription
        '
        Me.colFullTranshDescription.Caption = "Έργο"
        Me.colFullTranshDescription.FieldName = "FullTranshDescription"
        Me.colFullTranshDescription.MinWidth = 18
        Me.colFullTranshDescription.Name = "colFullTranshDescription"
        Me.colFullTranshDescription.Visible = True
        Me.colFullTranshDescription.VisibleIndex = 1
        Me.colFullTranshDescription.Width = 522
        '
        'coldtDeliverDate
        '
        Me.coldtDeliverDate.Caption = "Ημερ/νία Τοποθέτησης"
        Me.coldtDeliverDate.FieldName = "dtDeliverDate"
        Me.coldtDeliverDate.MinWidth = 18
        Me.coldtDeliverDate.Name = "coldtDeliverDate"
        Me.coldtDeliverDate.Width = 135
        '
        'colGRMONTH
        '
        Me.colGRMONTH.Caption = "Μήνας"
        Me.colGRMONTH.FieldName = "GRMONTH"
        Me.colGRMONTH.MinWidth = 18
        Me.colGRMONTH.Name = "colGRMONTH"
        Me.colGRMONTH.Width = 68
        '
        'colSalerName
        '
        Me.colSalerName.Caption = "Πωλητής"
        Me.colSalerName.FieldName = "SalerName"
        Me.colSalerName.MinWidth = 18
        Me.colSalerName.Name = "colSalerName"
        Me.colSalerName.Visible = True
        Me.colSalerName.VisibleIndex = 2
        Me.colSalerName.Width = 240
        '
        'colcmt
        '
        Me.colcmt.Caption = "Σχόλια"
        Me.colcmt.FieldName = "cmt"
        Me.colcmt.MinWidth = 18
        Me.colcmt.Name = "colcmt"
        Me.colcmt.Width = 175
        '
        'colTotalCost
        '
        Me.colTotalCost.Caption = "Συνολικό Κόστος"
        Me.colTotalCost.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colTotalCost.FieldName = "TotalCost"
        Me.colTotalCost.MinWidth = 18
        Me.colTotalCost.Name = "colTotalCost"
        Me.colTotalCost.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TotalCost", "SUM={0:0.##}")})
        Me.colTotalCost.Visible = True
        Me.colTotalCost.VisibleIndex = 3
        Me.colTotalCost.Width = 153
        '
        'colYPOL
        '
        Me.colYPOL.Caption = "Υπόλοιπο"
        Me.colYPOL.FieldName = "YPOL"
        Me.colYPOL.MinWidth = 18
        Me.colYPOL.Name = "colYPOL"
        Me.colYPOL.Visible = True
        Me.colYPOL.VisibleIndex = 4
        Me.colYPOL.Width = 99
        '
        'colkitchen
        '
        Me.colkitchen.Caption = "Κουζίνα"
        Me.colkitchen.FieldName = "kitchen"
        Me.colkitchen.MinWidth = 30
        Me.colkitchen.Name = "colkitchen"
        Me.colkitchen.Visible = True
        Me.colkitchen.VisibleIndex = 5
        Me.colkitchen.Width = 77
        '
        'colcloset
        '
        Me.colcloset.Caption = "Ντουλάπες"
        Me.colcloset.FieldName = "closet"
        Me.colcloset.MinWidth = 30
        Me.colcloset.Name = "colcloset"
        Me.colcloset.Visible = True
        Me.colcloset.VisibleIndex = 6
        Me.colcloset.Width = 99
        '
        'coldoors
        '
        Me.coldoors.Caption = "Πόρτες"
        Me.coldoors.FieldName = "doors"
        Me.coldoors.MinWidth = 30
        Me.coldoors.Name = "coldoors"
        Me.coldoors.Visible = True
        Me.coldoors.VisibleIndex = 7
        Me.coldoors.Width = 76
        '
        'colsc
        '
        Me.colsc.Caption = "Κουζίνα"
        Me.colsc.CustomizationCaption = "Ειδ. Κατασκευές"
        Me.colsc.FieldName = "sc"
        Me.colsc.MinWidth = 30
        Me.colsc.Name = "colsc"
        Me.colsc.Visible = True
        Me.colsc.VisibleIndex = 8
        Me.colsc.Width = 77
        '
        'RepositoryItemButtonOil
        '
        Me.RepositoryItemButtonOil.AutoHeight = False
        Me.RepositoryItemButtonOil.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.RepositoryItemButtonOil.Name = "RepositoryItemButtonOil"
        '
        'cmdExit
        '
        Me.cmdExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdExit.ImageOptions.Image = Global.DreamyKitchenCRM.My.Resources.Resources.icons8_exit_24
        Me.cmdExit.Location = New System.Drawing.Point(1492, 909)
        Me.cmdExit.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(230, 32)
        Me.cmdExit.StyleController = Me.LayoutControl1
        Me.cmdExit.TabIndex = 33
        Me.cmdExit.Text = "Έξοδος"
        '
        'cmdSave
        '
        Me.cmdSave.ImageOptions.Image = Global.DreamyKitchenCRM.My.Resources.Resources.icons8_save_close_24
        Me.cmdSave.Location = New System.Drawing.Point(1290, 909)
        Me.cmdSave.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(198, 32)
        Me.cmdSave.StyleController = Me.LayoutControl1
        Me.cmdSave.TabIndex = 34
        Me.cmdSave.Text = "Αποθήκευση"
        '
        'cboSER
        '
        Me.cboSER.Location = New System.Drawing.Point(178, 44)
        Me.cboSER.Margin = New System.Windows.Forms.Padding(4)
        Me.cboSER.Name = "cboSER"
        Me.cboSER.Properties.AllowMouseWheel = False
        Me.cboSER.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.cboSER.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Search), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Clear)})
        Me.cboSER.Properties.NullText = ""
        Me.cboSER.Properties.PopupSizeable = False
        Me.cboSER.Size = New System.Drawing.Size(1544, 26)
        Me.cboSER.StyleController = Me.LayoutControl1
        Me.cboSER.TabIndex = 5
        Me.cboSER.Tag = "serid,0"
        '
        'dtDeliverDate
        '
        Me.dtDeliverDate.EditValue = Nothing
        Me.dtDeliverDate.Location = New System.Drawing.Point(178, 580)
        Me.dtDeliverDate.Margin = New System.Windows.Forms.Padding(4)
        Me.dtDeliverDate.Name = "dtDeliverDate"
        Me.dtDeliverDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtDeliverDate.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtDeliverDate.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.dtDeliverDate.Size = New System.Drawing.Size(1544, 26)
        Me.dtDeliverDate.StyleController = Me.LayoutControl1
        Me.dtDeliverDate.TabIndex = 32
        Me.dtDeliverDate.Tag = "dtPay,0,1,2"
        '
        'txtComments
        '
        Me.txtComments.Location = New System.Drawing.Point(178, 640)
        Me.txtComments.Margin = New System.Windows.Forms.Padding(4)
        Me.txtComments.Name = "txtComments"
        Me.txtComments.Size = New System.Drawing.Size(1544, 265)
        Me.txtComments.StyleController = Me.LayoutControl1
        Me.txtComments.TabIndex = 17
        Me.txtComments.Tag = "cmt,0,1,2"
        '
        'txtCode
        '
        Me.txtCode.Location = New System.Drawing.Point(178, 12)
        Me.txtCode.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCode.Name = "txtCode"
        Me.txtCode.Properties.Appearance.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.txtCode.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtCode.Properties.Appearance.Options.UseBackColor = True
        Me.txtCode.Properties.Appearance.Options.UseFont = True
        Me.txtCode.Properties.ReadOnly = True
        Me.txtCode.Size = New System.Drawing.Size(130, 28)
        Me.txtCode.StyleController = Me.LayoutControl1
        Me.txtCode.TabIndex = 4
        Me.txtCode.Tag = "code,0"
        '
        'txtCost
        '
        Me.txtCost.EditValue = "0,00 €"
        Me.txtCost.Location = New System.Drawing.Point(178, 610)
        Me.txtCost.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCost.Name = "txtCost"
        Me.txtCost.Properties.DisplayFormat.FormatString = "c"
        Me.txtCost.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtCost.Properties.EditFormat.FormatString = "n2"
        Me.txtCost.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtCost.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtCost.Properties.MaskSettings.Set("MaskManagerType", GetType(DevExpress.Data.Mask.NumericMaskManager))
        Me.txtCost.Properties.MaskSettings.Set("mask", "c2")
        Me.txtCost.Properties.Tag = "BenchExtraPrice"
        Me.txtCost.Size = New System.Drawing.Size(1544, 26)
        Me.txtCost.StyleController = Me.LayoutControl1
        Me.txtCost.TabIndex = 42
        Me.txtCost.Tag = "amt,0,1,2"
        Me.txtCost.Visible = False
        '
        'Root
        '
        Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.Root.GroupBordersVisible = False
        Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem9, Me.LayoutControlItem2, Me.LayoutControlItem14, Me.LayoutControlItem4, Me.LayoutControlItem3, Me.LayoutControlItem1, Me.EmptySpaceItem1, Me.Lcost, Me.EmptySpaceItem2, Me.LayoutControlItem5})
        Me.Root.Name = "Root"
        Me.Root.Size = New System.Drawing.Size(1734, 953)
        Me.Root.TextVisible = False
        '
        'LayoutControlItem9
        '
        Me.LayoutControlItem9.Control = Me.cboSER
        Me.LayoutControlItem9.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem9.CustomizationFormText = "Νομός"
        Me.LayoutControlItem9.HighlightFocusedItem = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlItem9.ImageOptions.Image = CType(resources.GetObject("LayoutControlItem9.ImageOptions.Image"), System.Drawing.Image)
        Me.LayoutControlItem9.Location = New System.Drawing.Point(0, 32)
        Me.LayoutControlItem9.Name = "LayoutControlItem9"
        Me.LayoutControlItem9.Size = New System.Drawing.Size(1714, 30)
        Me.LayoutControlItem9.Tag = "1"
        Me.LayoutControlItem9.Text = "Τοποθέτες"
        Me.LayoutControlItem9.TextSize = New System.Drawing.Size(154, 19)
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.dtDeliverDate
        Me.LayoutControlItem2.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem2.CustomizationFormText = "Ημερ/νία Ολοκλήρωσης"
        Me.LayoutControlItem2.ImageOptions.Image = CType(resources.GetObject("LayoutControlItem2.ImageOptions.Image"), System.Drawing.Image)
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 568)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(1714, 30)
        Me.LayoutControlItem2.Tag = "1"
        Me.LayoutControlItem2.Text = "Ημερ/νία Πληρωμής"
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(154, 19)
        '
        'LayoutControlItem14
        '
        Me.LayoutControlItem14.Control = Me.txtComments
        Me.LayoutControlItem14.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem14.CustomizationFormText = "Σχόλια"
        Me.LayoutControlItem14.HighlightFocusedItem = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlItem14.Location = New System.Drawing.Point(0, 628)
        Me.LayoutControlItem14.Name = "LayoutControlItem14"
        Me.LayoutControlItem14.Size = New System.Drawing.Size(1714, 269)
        Me.LayoutControlItem14.Text = "Σχόλια"
        Me.LayoutControlItem14.TextSize = New System.Drawing.Size(154, 19)
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.txtCode
        Me.LayoutControlItem4.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem4.CustomizationFormText = "Κωδικός"
        Me.LayoutControlItem4.HighlightFocusedItem = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(300, 32)
        Me.LayoutControlItem4.Text = "Κωδικός"
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(154, 19)
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.cmdSave
        Me.LayoutControlItem3.Location = New System.Drawing.Point(1278, 897)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(202, 36)
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem3.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.cmdExit
        Me.LayoutControlItem1.Location = New System.Drawing.Point(1480, 897)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(234, 36)
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(300, 0)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(1414, 32)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'Lcost
        '
        Me.Lcost.Control = Me.txtCost
        Me.Lcost.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.Lcost.CustomizationFormText = "Τελική Αξία"
        Me.Lcost.HighlightFocusedItem = DevExpress.Utils.DefaultBoolean.[True]
        Me.Lcost.ImageOptions.Image = Global.DreamyKitchenCRM.My.Resources.Resources.rsz_11rsz_asterisk
        Me.Lcost.Location = New System.Drawing.Point(0, 598)
        Me.Lcost.Name = "Lcost"
        Me.Lcost.Size = New System.Drawing.Size(1714, 30)
        Me.Lcost.Tag = "1"
        Me.Lcost.Text = "Ποσό"
        Me.Lcost.TextSize = New System.Drawing.Size(154, 19)
        '
        'EmptySpaceItem2
        '
        Me.EmptySpaceItem2.AllowHotTrack = False
        Me.EmptySpaceItem2.Location = New System.Drawing.Point(0, 897)
        Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Size = New System.Drawing.Size(1278, 36)
        Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.grdInst
        Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 62)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(1714, 506)
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem5.TextVisible = False
        '
        'Vw_INSTPerSerTableAdapter
        '
        Me.Vw_INSTPerSerTableAdapter.ClearBeforeFill = True
        '
        'frmInstM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1734, 953)
        Me.Controls.Add(Me.LayoutControl1)
        Me.IconOptions.Image = Global.DreamyKitchenCRM.My.Resources.Resources.favicon
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmInstM"
        Me.Text = "Έργα Τοποθετών"
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.grdInst, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VwINSTPerSerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DreamyKitchenDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DreamyKitchenDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemButtonOil, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboSER.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtDeliverDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtDeliverDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtComments.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCost.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Lcost, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents cmdExit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cboSER As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents dtDeliverDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents txtComments As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents txtCode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtCost As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Root As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem14 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents Lcost As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents grdInst As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RepositoryItemButtonOil As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents DreamyKitchenDataSetBindingSource As BindingSource
    Friend WithEvents DreamyKitchenDataSet As DreamyKitchenDataSet
    Friend WithEvents VwINSTPerSerBindingSource As BindingSource
    Friend WithEvents colID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colcctName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldtDeliverDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSalerName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colcmt As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTotalCost As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Vw_INSTPerSerTableAdapter As DreamyKitchenDataSetTableAdapters.vw_INSTPerSerTableAdapter
    Friend WithEvents colGRMONTH As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colYPOL As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFullTranshDescription As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colkitchen As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colcloset As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldoors As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsc As DevExpress.XtraGrid.Columns.GridColumn
End Class
