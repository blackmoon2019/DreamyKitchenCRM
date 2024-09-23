<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPriceListsKeywords
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
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.PRICELISTSKEYWORDSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DMDataSet = New DreamyKitchenCRM.DMDataSet()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsupID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colkeyword = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colvalueListID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepValueList = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.VwVALUELISTBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DM_VALUELISTITEM = New DreamyKitchenCRM.DM_VALUELISTITEM()
        Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.Vw_VALUELISTTableAdapter = New DreamyKitchenCRM.DM_VALUELISTITEMTableAdapters.vw_VALUELISTTableAdapter()
        Me.PRICELISTS_KEYWORDSTableAdapter = New DreamyKitchenCRM.DMDataSetTableAdapters.PRICELISTS_KEYWORDSTableAdapter()
        Me.colActive = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PRICELISTSKEYWORDSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DMDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepValueList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VwVALUELISTBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DM_VALUELISTITEM, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.GridControl1)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.Root = Me.Root
        Me.LayoutControl1.Size = New System.Drawing.Size(804, 550)
        Me.LayoutControl1.TabIndex = 0
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'GridControl1
        '
        Me.GridControl1.DataSource = Me.PRICELISTSKEYWORDSBindingSource
        Me.GridControl1.EmbeddedNavigator.Buttons.EndEdit.Visible = False
        Me.GridControl1.EmbeddedNavigator.Buttons.First.Visible = False
        Me.GridControl1.EmbeddedNavigator.Buttons.Last.Visible = False
        Me.GridControl1.EmbeddedNavigator.Buttons.Next.Visible = False
        Me.GridControl1.EmbeddedNavigator.Buttons.NextPage.Visible = False
        Me.GridControl1.EmbeddedNavigator.Buttons.Prev.Visible = False
        Me.GridControl1.EmbeddedNavigator.Buttons.PrevPage.Visible = False
        Me.GridControl1.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.GridControl1.Location = New System.Drawing.Point(12, 12)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepValueList})
        Me.GridControl1.Size = New System.Drawing.Size(780, 526)
        Me.GridControl1.TabIndex = 15
        Me.GridControl1.UseEmbeddedNavigator = True
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'PRICELISTSKEYWORDSBindingSource
        '
        Me.PRICELISTSKEYWORDSBindingSource.DataMember = "PRICELISTS_KEYWORDS"
        Me.PRICELISTSKEYWORDSBindingSource.DataSource = Me.DMDataSet
        '
        'DMDataSet
        '
        Me.DMDataSet.DataSetName = "DMDataSet"
        Me.DMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colID, Me.colsupID, Me.colkeyword, Me.colvalueListID, Me.colActive})
        Me.GridView1.DetailHeight = 289
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsEditForm.PopupEditFormWidth = 720
        Me.GridView1.OptionsView.ShowAutoFilterRow = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'colID
        '
        Me.colID.FieldName = "ID"
        Me.colID.MinWidth = 30
        Me.colID.Name = "colID"
        Me.colID.Width = 112
        '
        'colsupID
        '
        Me.colsupID.FieldName = "supID"
        Me.colsupID.MinWidth = 30
        Me.colsupID.Name = "colsupID"
        Me.colsupID.Width = 112
        '
        'colkeyword
        '
        Me.colkeyword.Caption = "Λέξη"
        Me.colkeyword.FieldName = "keyword"
        Me.colkeyword.MinWidth = 30
        Me.colkeyword.Name = "colkeyword"
        Me.colkeyword.Visible = True
        Me.colkeyword.VisibleIndex = 0
        Me.colkeyword.Width = 112
        '
        'colvalueListID
        '
        Me.colvalueListID.Caption = "Κατηγορία"
        Me.colvalueListID.ColumnEdit = Me.RepValueList
        Me.colvalueListID.FieldName = "valueListID"
        Me.colvalueListID.MinWidth = 30
        Me.colvalueListID.Name = "colvalueListID"
        Me.colvalueListID.Visible = True
        Me.colvalueListID.VisibleIndex = 1
        Me.colvalueListID.Width = 112
        '
        'RepValueList
        '
        Me.RepValueList.AutoHeight = False
        Me.RepValueList.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepValueList.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 30, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("name", "Κατηγορία", 52, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("GroupName", "Group Name", 103, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default])})
        Me.RepValueList.DataSource = Me.VwVALUELISTBindingSource
        Me.RepValueList.DisplayMember = "name"
        Me.RepValueList.Name = "RepValueList"
        Me.RepValueList.NullText = ""
        Me.RepValueList.ValueMember = "ID"
        '
        'VwVALUELISTBindingSource
        '
        Me.VwVALUELISTBindingSource.DataMember = "vw_VALUELIST"
        Me.VwVALUELISTBindingSource.DataSource = Me.DM_VALUELISTITEM
        '
        'DM_VALUELISTITEM
        '
        Me.DM_VALUELISTITEM.DataSetName = "DM_VALUELISTITEM"
        Me.DM_VALUELISTITEM.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Root
        '
        Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.Root.GroupBordersVisible = False
        Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1})
        Me.Root.Name = "Root"
        Me.Root.Size = New System.Drawing.Size(804, 550)
        Me.Root.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.GridControl1
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(784, 530)
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'Vw_VALUELISTTableAdapter
        '
        Me.Vw_VALUELISTTableAdapter.ClearBeforeFill = True
        '
        'PRICELISTS_KEYWORDSTableAdapter
        '
        Me.PRICELISTS_KEYWORDSTableAdapter.ClearBeforeFill = True
        '
        'colActive
        '
        Me.colActive.Caption = "Ενεργό"
        Me.colActive.FieldName = "Active"
        Me.colActive.MinWidth = 30
        Me.colActive.Name = "colActive"
        Me.colActive.Visible = True
        Me.colActive.VisibleIndex = 2
        Me.colActive.Width = 112
        '
        'frmPriceListsKeywords
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(804, 550)
        Me.Controls.Add(Me.LayoutControl1)
        Me.IconOptions.Image = Global.DreamyKitchenCRM.My.Resources.Resources.favicon
        Me.Name = "frmPriceListsKeywords"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Λέξεις Κλειδιά"
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PRICELISTSKEYWORDSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DMDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepValueList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VwVALUELISTBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DM_VALUELISTITEM, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents Root As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents colID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsupID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colkeyword As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colvalueListID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepValueList As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents DM_VALUELISTITEM As DM_VALUELISTITEM
    Friend WithEvents VwVALUELISTBindingSource As BindingSource
    Friend WithEvents Vw_VALUELISTTableAdapter As DM_VALUELISTITEMTableAdapters.vw_VALUELISTTableAdapter
    Friend WithEvents PRICELISTSKEYWORDSBindingSource As BindingSource
    Friend WithEvents DMDataSet As DMDataSet
    Friend WithEvents PRICELISTS_KEYWORDSTableAdapter As DMDataSetTableAdapters.PRICELISTS_KEYWORDSTableAdapter
    Friend WithEvents colActive As DevExpress.XtraGrid.Columns.GridColumn
End Class
