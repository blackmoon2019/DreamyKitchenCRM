<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAgreementCheckList
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
        Me.cmdExit = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdSave = New DevExpress.XtraEditors.SimpleButton()
        Me.GridControl4 = New DevExpress.XtraGrid.GridControl()
        Me.VwPROJECTCHECKLISTBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DM_VALUELISTITEM = New DreamyKitchenCRM.DM_VALUELISTITEM()
        Me.GridView4 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colcode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colname = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colmodifiedBy = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colmodifiedOn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colcreatedOn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colcreatedBy = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colvalueListID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colvalueListName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colGroupName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colValue = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemCheck = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.Vw_PROJECTCHECKLISTTableAdapter = New DreamyKitchenCRM.DM_VALUELISTITEMTableAdapters.vw_PROJECTCHECKLISTTableAdapter()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.GridControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VwPROJECTCHECKLISTBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DM_VALUELISTITEM, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheck, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.cmdExit)
        Me.LayoutControl1.Controls.Add(Me.cmdSave)
        Me.LayoutControl1.Controls.Add(Me.GridControl4)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(1430, 476, 1137, 700)
        Me.LayoutControl1.Root = Me.Root
        Me.LayoutControl1.Size = New System.Drawing.Size(1345, 924)
        Me.LayoutControl1.TabIndex = 0
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'cmdExit
        '
        Me.cmdExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdExit.ImageOptions.Image = Global.DreamyKitchenCRM.My.Resources.Resources.icons8_exit_24
        Me.cmdExit.Location = New System.Drawing.Point(1171, 873)
        Me.cmdExit.Margin = New System.Windows.Forms.Padding(18)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(162, 39)
        Me.cmdExit.StyleController = Me.LayoutControl1
        Me.cmdExit.TabIndex = 66
        Me.cmdExit.Text = "Έξοδος"
        '
        'cmdSave
        '
        Me.cmdSave.ImageOptions.Image = Global.DreamyKitchenCRM.My.Resources.Resources.icons8_save_close_24
        Me.cmdSave.Location = New System.Drawing.Point(1024, 873)
        Me.cmdSave.Margin = New System.Windows.Forms.Padding(18)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(143, 39)
        Me.cmdSave.StyleController = Me.LayoutControl1
        Me.cmdSave.TabIndex = 65
        Me.cmdSave.Text = "Αποθήκευση"
        '
        'GridControl4
        '
        Me.GridControl4.DataSource = Me.VwPROJECTCHECKLISTBindingSource
        Me.GridControl4.EmbeddedNavigator.Buttons.EndEdit.Visible = False
        Me.GridControl4.EmbeddedNavigator.Buttons.First.Visible = False
        Me.GridControl4.EmbeddedNavigator.Buttons.Last.Visible = False
        Me.GridControl4.EmbeddedNavigator.Buttons.Next.Visible = False
        Me.GridControl4.EmbeddedNavigator.Buttons.NextPage.Visible = False
        Me.GridControl4.EmbeddedNavigator.Buttons.Prev.Visible = False
        Me.GridControl4.EmbeddedNavigator.Buttons.PrevPage.Visible = False
        Me.GridControl4.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(5)
        Me.GridControl4.Location = New System.Drawing.Point(12, 12)
        Me.GridControl4.MainView = Me.GridView4
        Me.GridControl4.Margin = New System.Windows.Forms.Padding(5)
        Me.GridControl4.Name = "GridControl4"
        Me.GridControl4.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCheck})
        Me.GridControl4.Size = New System.Drawing.Size(1321, 857)
        Me.GridControl4.TabIndex = 12
        Me.GridControl4.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView4})
        '
        'VwPROJECTCHECKLISTBindingSource
        '
        Me.VwPROJECTCHECKLISTBindingSource.DataMember = "vw_PROJECTCHECKLIST"
        Me.VwPROJECTCHECKLISTBindingSource.DataSource = Me.DM_VALUELISTITEM
        '
        'DM_VALUELISTITEM
        '
        Me.DM_VALUELISTITEM.DataSetName = "DM_VALUELISTITEM"
        Me.DM_VALUELISTITEM.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView4
        '
        Me.GridView4.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colID, Me.colcode, Me.colname, Me.colmodifiedBy, Me.colmodifiedOn, Me.colcreatedOn, Me.colcreatedBy, Me.colvalueListID, Me.colvalueListName, Me.colGroupName, Me.colValue})
        Me.GridView4.DetailHeight = 612
        Me.GridView4.GridControl = Me.GridControl4
        Me.GridView4.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "amt", Nothing, " Σύνολο {0:n2}€")})
        Me.GridView4.Name = "GridView4"
        Me.GridView4.OptionsEditForm.PopupEditFormWidth = 840
        Me.GridView4.OptionsMenu.ShowConditionalFormattingItem = True
        Me.GridView4.OptionsView.EnableAppearanceEvenRow = True
        Me.GridView4.OptionsView.ShowFooter = True
        Me.GridView4.OptionsView.ShowGroupedColumns = True
        Me.GridView4.OptionsView.ShowGroupPanel = False
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
        Me.colcode.FieldName = "code"
        Me.colcode.MinWidth = 35
        Me.colcode.Name = "colcode"
        Me.colcode.Width = 131
        '
        'colname
        '
        Me.colname.Caption = "Περιγραφή"
        Me.colname.FieldName = "name"
        Me.colname.MinWidth = 35
        Me.colname.Name = "colname"
        Me.colname.OptionsColumn.AllowEdit = False
        Me.colname.Visible = True
        Me.colname.VisibleIndex = 0
        Me.colname.Width = 131
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
        'colvalueListID
        '
        Me.colvalueListID.FieldName = "valueListID"
        Me.colvalueListID.MinWidth = 35
        Me.colvalueListID.Name = "colvalueListID"
        Me.colvalueListID.Width = 131
        '
        'colvalueListName
        '
        Me.colvalueListName.FieldName = "valueListName"
        Me.colvalueListName.MinWidth = 35
        Me.colvalueListName.Name = "colvalueListName"
        Me.colvalueListName.Width = 131
        '
        'colGroupName
        '
        Me.colGroupName.FieldName = "GroupName"
        Me.colGroupName.MinWidth = 35
        Me.colGroupName.Name = "colGroupName"
        Me.colGroupName.Width = 131
        '
        'colValue
        '
        Me.colValue.Caption = "Check"
        Me.colValue.ColumnEdit = Me.RepositoryItemCheck
        Me.colValue.FieldName = "Value"
        Me.colValue.MinWidth = 35
        Me.colValue.Name = "colValue"
        Me.colValue.Visible = True
        Me.colValue.VisibleIndex = 1
        Me.colValue.Width = 131
        '
        'RepositoryItemCheck
        '
        Me.RepositoryItemCheck.AutoHeight = False
        Me.RepositoryItemCheck.Name = "RepositoryItemCheck"
        Me.RepositoryItemCheck.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked
        '
        'Root
        '
        Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.Root.GroupBordersVisible = False
        Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem2, Me.LayoutControlItem3, Me.EmptySpaceItem1})
        Me.Root.Name = "Root"
        Me.Root.Size = New System.Drawing.Size(1345, 924)
        Me.Root.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.GridControl4
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(1325, 861)
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.cmdSave
        Me.LayoutControlItem2.Location = New System.Drawing.Point(1012, 861)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(147, 43)
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem2.TextVisible = False
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.cmdExit
        Me.LayoutControlItem3.Location = New System.Drawing.Point(1159, 861)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(166, 43)
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem3.TextVisible = False
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(0, 861)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(1012, 43)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'Vw_PROJECTCHECKLISTTableAdapter
        '
        Me.Vw_PROJECTCHECKLISTTableAdapter.ClearBeforeFill = True
        '
        'frmAgreementCheckList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 23.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1345, 924)
        Me.Controls.Add(Me.LayoutControl1)
        Me.IconOptions.Image = Global.DreamyKitchenCRM.My.Resources.Resources.favicon
        Me.Name = "frmAgreementCheckList"
        Me.Text = "Check List Έργου"
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.GridControl4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VwPROJECTCHECKLISTBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DM_VALUELISTITEM, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheck, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents Root As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents DM_VALUELISTITEM As DM_VALUELISTITEM
    Friend WithEvents VwPROJECTCHECKLISTBindingSource As BindingSource
    Friend WithEvents Vw_PROJECTCHECKLISTTableAdapter As DM_VALUELISTITEMTableAdapters.vw_PROJECTCHECKLISTTableAdapter
    Friend WithEvents GridControl4 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView4 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colcode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colname As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colmodifiedBy As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colmodifiedOn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colcreatedOn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colcreatedBy As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colvalueListID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colvalueListName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colGroupName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCheck As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents cmdSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents cmdExit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents colValue As DevExpress.XtraGrid.Columns.GridColumn
End Class
