<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCloneOffer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCloneOffer))
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.cmdSave = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdExit = New DevExpress.XtraEditors.SimpleButton()
        Me.cboSubOffName = New DevExpress.XtraEditors.LookUpEdit()
        Me.VwOFFSUBOFFBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DreamyKitchenDataSet = New DreamyKitchenCRM.DreamyKitchenDataSet()
        Me.txtCode = New DevExpress.XtraEditors.TextEdit()
        Me.cboDoorType = New DevExpress.XtraEditors.LookUpEdit()
        Me.VwOFFERDOORTYPESBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.cboDoorType1 = New DevExpress.XtraEditors.LookUpEdit()
        Me.VwDOORTYPEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem11 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem46 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem3 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.Vw_OFF_SUBOFFTableAdapter = New DreamyKitchenCRM.DreamyKitchenDataSetTableAdapters.vw_OFF_SUBOFFTableAdapter()
        Me.Vw_DOOR_TYPETableAdapter = New DreamyKitchenCRM.DreamyKitchenDataSetTableAdapters.vw_DOOR_TYPETableAdapter()
        Me.Vw_OFFER_DOORTYPES = New DreamyKitchenCRM.DreamyKitchenDataSetTableAdapters.vw_OFFER_DOORTYPES()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.cboSubOffName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VwOFFSUBOFFBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DreamyKitchenDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboDoorType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VwOFFERDOORTYPESBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboDoorType1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VwDOORTYPEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem46, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.cmdSave)
        Me.LayoutControl1.Controls.Add(Me.cmdExit)
        Me.LayoutControl1.Controls.Add(Me.cboSubOffName)
        Me.LayoutControl1.Controls.Add(Me.txtCode)
        Me.LayoutControl1.Controls.Add(Me.cboDoorType)
        Me.LayoutControl1.Controls.Add(Me.cboDoorType1)
        Me.LayoutControl1.Location = New System.Drawing.Point(-4, -5)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.Root = Me.Root
        Me.LayoutControl1.Size = New System.Drawing.Size(362, 244)
        Me.LayoutControl1.TabIndex = 0
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'cmdSave
        '
        Me.cmdSave.ImageOptions.Image = CType(resources.GetObject("cmdSave.ImageOptions.Image"), System.Drawing.Image)
        Me.cmdSave.Location = New System.Drawing.Point(197, 204)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(79, 28)
        Me.cmdSave.StyleController = Me.LayoutControl1
        Me.cmdSave.TabIndex = 24
        Me.cmdSave.Text = "Εκτέλεση"
        '
        'cmdExit
        '
        Me.cmdExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdExit.ImageOptions.Image = CType(resources.GetObject("cmdExit.ImageOptions.Image"), System.Drawing.Image)
        Me.cmdExit.Location = New System.Drawing.Point(280, 204)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(70, 28)
        Me.cmdExit.StyleController = Me.LayoutControl1
        Me.cmdExit.TabIndex = 23
        Me.cmdExit.Text = "Έξοδος"
        '
        'cboSubOffName
        '
        Me.cboSubOffName.Location = New System.Drawing.Point(12, 54)
        Me.cboSubOffName.Name = "cboSubOffName"
        Me.cboSubOffName.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.cboSubOffName.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Search), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Clear)})
        Me.cboSubOffName.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("SubOFFName", "Τίτλος", 80, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default])})
        Me.cboSubOffName.Properties.DataSource = Me.VwOFFSUBOFFBindingSource
        Me.cboSubOffName.Properties.DisplayMember = "SubOFFName"
        Me.cboSubOffName.Properties.NullText = ""
        Me.cboSubOffName.Properties.PopupSizeable = False
        Me.cboSubOffName.Properties.ValueMember = "ID"
        Me.cboSubOffName.Size = New System.Drawing.Size(338, 20)
        Me.cboSubOffName.StyleController = Me.LayoutControl1
        Me.cboSubOffName.TabIndex = 21
        Me.cboSubOffName.Tag = ""
        '
        'VwOFFSUBOFFBindingSource
        '
        Me.VwOFFSUBOFFBindingSource.DataMember = "vw_OFF_SUBOFF"
        Me.VwOFFSUBOFFBindingSource.DataSource = Me.DreamyKitchenDataSet
        '
        'DreamyKitchenDataSet
        '
        Me.DreamyKitchenDataSet.DataSetName = "DreamyKitchenDataSet"
        Me.DreamyKitchenDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txtCode
        '
        Me.txtCode.Location = New System.Drawing.Point(64, 12)
        Me.txtCode.Name = "txtCode"
        Me.txtCode.Properties.Appearance.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.txtCode.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtCode.Properties.Appearance.Options.UseBackColor = True
        Me.txtCode.Properties.Appearance.Options.UseFont = True
        Me.txtCode.Properties.ReadOnly = True
        Me.txtCode.Size = New System.Drawing.Size(98, 20)
        Me.txtCode.StyleController = Me.LayoutControl1
        Me.txtCode.TabIndex = 4
        Me.txtCode.Tag = "code,0"
        '
        'cboDoorType
        '
        Me.cboDoorType.Location = New System.Drawing.Point(12, 96)
        Me.cboDoorType.Name = "cboDoorType"
        Me.cboDoorType.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.cboDoorType.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Search), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Clear)})
        Me.cboDoorType.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("DoorTypeID", "Door Type ID", 73, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("DoorTypeName", "Door Type Name", 89, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default])})
        Me.cboDoorType.Properties.DataSource = Me.VwOFFERDOORTYPESBindingSource
        Me.cboDoorType.Properties.DisplayMember = "DoorTypeName"
        Me.cboDoorType.Properties.NullText = ""
        Me.cboDoorType.Properties.PopupSizeable = False
        Me.cboDoorType.Properties.ValueMember = "DoorTypeID"
        Me.cboDoorType.Size = New System.Drawing.Size(338, 20)
        Me.cboDoorType.StyleController = Me.LayoutControl1
        Me.cboDoorType.TabIndex = 21
        Me.cboDoorType.Tag = ""
        '
        'VwOFFERDOORTYPESBindingSource
        '
        Me.VwOFFERDOORTYPESBindingSource.DataMember = "vw_OFFER_DOORTYPES"
        Me.VwOFFERDOORTYPESBindingSource.DataSource = Me.DreamyKitchenDataSet
        '
        'cboDoorType1
        '
        Me.cboDoorType1.Location = New System.Drawing.Point(12, 138)
        Me.cboDoorType1.Name = "cboDoorType1"
        Me.cboDoorType1.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.cboDoorType1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Search), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Clear)})
        Me.cboDoorType1.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("name", "Πορτάκι", 300, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Price", "Τιμή", 50, DevExpress.Utils.FormatType.Numeric, "", True, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default])})
        Me.cboDoorType1.Properties.DataSource = Me.VwDOORTYPEBindingSource
        Me.cboDoorType1.Properties.DisplayMember = "name"
        Me.cboDoorType1.Properties.NullText = ""
        Me.cboDoorType1.Properties.PopupSizeable = False
        Me.cboDoorType1.Properties.ValueMember = "ID"
        Me.cboDoorType1.Size = New System.Drawing.Size(338, 20)
        Me.cboDoorType1.StyleController = Me.LayoutControl1
        Me.cboDoorType1.TabIndex = 21
        Me.cboDoorType1.Tag = ""
        '
        'VwDOORTYPEBindingSource
        '
        Me.VwDOORTYPEBindingSource.DataMember = "vw_DOOR_TYPE"
        Me.VwDOORTYPEBindingSource.DataSource = Me.DreamyKitchenDataSet
        '
        'Root
        '
        Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.Root.GroupBordersVisible = False
        Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.EmptySpaceItem1, Me.LayoutControlItem2, Me.LayoutControlItem1, Me.LayoutControlItem11, Me.LayoutControlItem4, Me.LayoutControlItem46, Me.LayoutControlItem3, Me.EmptySpaceItem2, Me.EmptySpaceItem3})
        Me.Root.Name = "Root"
        Me.Root.Size = New System.Drawing.Size(362, 244)
        Me.Root.TextVisible = False
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(0, 150)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(342, 42)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.cmdExit
        Me.LayoutControlItem2.Location = New System.Drawing.Point(268, 192)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(74, 32)
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem2.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.cmdSave
        Me.LayoutControlItem1.Location = New System.Drawing.Point(185, 192)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(83, 32)
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'LayoutControlItem11
        '
        Me.LayoutControlItem11.Control = Me.cboSubOffName
        Me.LayoutControlItem11.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem11.CustomizationFormText = "Τίτλος Προσφοράς"
        Me.LayoutControlItem11.ImageOptions.Image = CType(resources.GetObject("LayoutControlItem11.ImageOptions.Image"), System.Drawing.Image)
        Me.LayoutControlItem11.Location = New System.Drawing.Point(0, 24)
        Me.LayoutControlItem11.Name = "LayoutControlItem11"
        Me.LayoutControlItem11.Size = New System.Drawing.Size(342, 42)
        Me.LayoutControlItem11.Text = "Τίτλος Προσφοράς"
        Me.LayoutControlItem11.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
        Me.LayoutControlItem11.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem11.TextSize = New System.Drawing.Size(100, 13)
        Me.LayoutControlItem11.TextToControlDistance = 5
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.txtCode
        Me.LayoutControlItem4.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem4.CustomizationFormText = "Κωδικός Προσφοράς"
        Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(154, 24)
        Me.LayoutControlItem4.Spacing = New DevExpress.XtraLayout.Utils.Padding(8, 0, 0, 0)
        Me.LayoutControlItem4.Text = "Κωδικός"
        Me.LayoutControlItem4.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(39, 13)
        Me.LayoutControlItem4.TextToControlDistance = 5
        '
        'LayoutControlItem46
        '
        Me.LayoutControlItem46.Control = Me.cboDoorType
        Me.LayoutControlItem46.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem46.CustomizationFormText = "Κατηγορία"
        Me.LayoutControlItem46.ImageOptions.Image = CType(resources.GetObject("LayoutControlItem46.ImageOptions.Image"), System.Drawing.Image)
        Me.LayoutControlItem46.Location = New System.Drawing.Point(0, 66)
        Me.LayoutControlItem46.Name = "LayoutControlItem46"
        Me.LayoutControlItem46.Size = New System.Drawing.Size(342, 42)
        Me.LayoutControlItem46.Text = "Πορτάκι"
        Me.LayoutControlItem46.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
        Me.LayoutControlItem46.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem46.TextSize = New System.Drawing.Size(49, 13)
        Me.LayoutControlItem46.TextToControlDistance = 5
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.cboDoorType1
        Me.LayoutControlItem3.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem3.CustomizationFormText = "Νέο Πορτάκι"
        Me.LayoutControlItem3.ImageOptions.Image = CType(resources.GetObject("LayoutControlItem3.ImageOptions.Image"), System.Drawing.Image)
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 108)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(342, 42)
        Me.LayoutControlItem3.Text = "Νέο Πορτάκι"
        Me.LayoutControlItem3.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
        Me.LayoutControlItem3.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(70, 13)
        Me.LayoutControlItem3.TextToControlDistance = 5
        '
        'EmptySpaceItem2
        '
        Me.EmptySpaceItem2.AllowHotTrack = False
        Me.EmptySpaceItem2.Location = New System.Drawing.Point(0, 192)
        Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Size = New System.Drawing.Size(185, 32)
        Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
        '
        'EmptySpaceItem3
        '
        Me.EmptySpaceItem3.AllowHotTrack = False
        Me.EmptySpaceItem3.Location = New System.Drawing.Point(154, 0)
        Me.EmptySpaceItem3.Name = "EmptySpaceItem3"
        Me.EmptySpaceItem3.Size = New System.Drawing.Size(188, 24)
        Me.EmptySpaceItem3.TextSize = New System.Drawing.Size(0, 0)
        '
        'Vw_OFF_SUBOFFTableAdapter
        '
        Me.Vw_OFF_SUBOFFTableAdapter.ClearBeforeFill = True
        '
        'Vw_DOOR_TYPETableAdapter
        '
        Me.Vw_DOOR_TYPETableAdapter.ClearBeforeFill = True
        '
        'Vw_OFFER_DOORTYPES
        '
        Me.Vw_OFFER_DOORTYPES.ClearBeforeFill = True
        '
        'frmCloneOffer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(352, 235)
        Me.Controls.Add(Me.LayoutControl1)
        Me.IconOptions.Image = Global.DreamyKitchenCRM.My.Resources.Resources.favicon
        Me.Name = "frmCloneOffer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmCloneOffer"
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.cboSubOffName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VwOFFSUBOFFBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DreamyKitchenDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboDoorType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VwOFFERDOORTYPESBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboDoorType1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VwDOORTYPEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem46, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents Root As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents cmdSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdExit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents cboSubOffName As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LayoutControlItem11 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents txtCode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents cboDoorType As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents cboDoorType1 As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LayoutControlItem46 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem3 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents VwOFFSUBOFFBindingSource As BindingSource
    Friend WithEvents DreamyKitchenDataSet As DreamyKitchenDataSet
    Friend WithEvents Vw_OFF_SUBOFFTableAdapter As DreamyKitchenDataSetTableAdapters.vw_OFF_SUBOFFTableAdapter
    Friend WithEvents VwDOORTYPEBindingSource As BindingSource
    Friend WithEvents Vw_DOOR_TYPETableAdapter As DreamyKitchenDataSetTableAdapters.vw_DOOR_TYPETableAdapter
    Friend WithEvents VwOFFERDOORTYPESBindingSource As BindingSource
    Friend WithEvents Vw_OFFER_DOORTYPES As DreamyKitchenDataSetTableAdapters.vw_OFFER_DOORTYPES
End Class
