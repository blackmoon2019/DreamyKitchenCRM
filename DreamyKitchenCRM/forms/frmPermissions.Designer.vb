<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPermissions
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
        Me.txtFormName = New DevExpress.XtraEditors.TextEdit()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colRealName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colview = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colinsert = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coledit = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coldelete = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colname = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cmdExit = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdSave = New DevExpress.XtraEditors.SimpleButton()
        Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.DMDataSet = New DreamyKitchenCRM.DMDataSet()
        Me.FORMRIGHTSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FORMRIGHTSTableAdapter = New DreamyKitchenCRM.DMDataSetTableAdapters.FORMRIGHTSTableAdapter()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.txtFormName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DMDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FORMRIGHTSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.txtFormName)
        Me.LayoutControl1.Controls.Add(Me.GridControl1)
        Me.LayoutControl1.Controls.Add(Me.cmdExit)
        Me.LayoutControl1.Controls.Add(Me.cmdSave)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(416, 136, 650, 400)
        Me.LayoutControl1.Root = Me.Root
        Me.LayoutControl1.Size = New System.Drawing.Size(1643, 1107)
        Me.LayoutControl1.TabIndex = 2
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'txtFormName
        '
        Me.txtFormName.Location = New System.Drawing.Point(790, 1065)
        Me.txtFormName.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtFormName.Name = "txtFormName"
        Me.txtFormName.Size = New System.Drawing.Size(532, 26)
        Me.txtFormName.StyleController = Me.LayoutControl1
        Me.txtFormName.TabIndex = 13
        '
        'GridControl1
        '
        Me.GridControl1.DataSource = Me.FORMRIGHTSBindingSource
        Me.GridControl1.EmbeddedNavigator.Buttons.Append.Visible = False
        Me.GridControl1.EmbeddedNavigator.Buttons.CancelEdit.Visible = False
        Me.GridControl1.EmbeddedNavigator.Buttons.Edit.Visible = False
        Me.GridControl1.EmbeddedNavigator.Buttons.EndEdit.Visible = False
        Me.GridControl1.EmbeddedNavigator.Buttons.Remove.Visible = False
        Me.GridControl1.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GridControl1.Location = New System.Drawing.Point(11, 10)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(1621, 1051)
        Me.GridControl1.TabIndex = 12
        Me.GridControl1.UseEmbeddedNavigator = True
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colRealName, Me.colID, Me.colview, Me.colinsert, Me.coledit, Me.coldelete, Me.colname})
        Me.GridView1.DetailHeight = 164
        Me.GridView1.FixedLineWidth = 3
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsEditForm.PopupEditFormWidth = 720
        Me.GridView1.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colRealName, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'colRealName
        '
        Me.colRealName.AppearanceHeader.Options.UseTextOptions = True
        Me.colRealName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colRealName.Caption = "Χρήστης"
        Me.colRealName.FieldName = "RealName"
        Me.colRealName.MinWidth = 31
        Me.colRealName.Name = "colRealName"
        Me.colRealName.OptionsColumn.AllowEdit = False
        Me.colRealName.Visible = True
        Me.colRealName.VisibleIndex = 0
        Me.colRealName.Width = 438
        '
        'colID
        '
        Me.colID.AppearanceHeader.Options.UseTextOptions = True
        Me.colID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colID.FieldName = "ID"
        Me.colID.MinWidth = 31
        Me.colID.Name = "colID"
        Me.colID.Width = 438
        '
        'colview
        '
        Me.colview.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colview.AppearanceCell.Options.UseBackColor = True
        Me.colview.AppearanceHeader.Options.UseTextOptions = True
        Me.colview.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colview.Caption = "Προβολή"
        Me.colview.FieldName = "view"
        Me.colview.MinWidth = 31
        Me.colview.Name = "colview"
        Me.colview.Visible = True
        Me.colview.VisibleIndex = 2
        Me.colview.Width = 182
        '
        'colinsert
        '
        Me.colinsert.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.colinsert.AppearanceCell.Options.UseBackColor = True
        Me.colinsert.AppearanceHeader.Options.UseTextOptions = True
        Me.colinsert.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colinsert.Caption = "Καταχώρηση"
        Me.colinsert.FieldName = "insert"
        Me.colinsert.MinWidth = 31
        Me.colinsert.Name = "colinsert"
        Me.colinsert.Visible = True
        Me.colinsert.VisibleIndex = 3
        Me.colinsert.Width = 184
        '
        'coledit
        '
        Me.coledit.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.coledit.AppearanceCell.Options.UseBackColor = True
        Me.coledit.AppearanceHeader.Options.UseTextOptions = True
        Me.coledit.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.coledit.Caption = "Επεξεργασία"
        Me.coledit.FieldName = "edit"
        Me.coledit.MinWidth = 31
        Me.coledit.Name = "coledit"
        Me.coledit.Visible = True
        Me.coledit.VisibleIndex = 4
        Me.coledit.Width = 191
        '
        'coldelete
        '
        Me.coldelete.AppearanceCell.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.coldelete.AppearanceCell.Options.UseBackColor = True
        Me.coldelete.AppearanceHeader.Options.UseTextOptions = True
        Me.coldelete.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.coldelete.Caption = "Διαγραφή"
        Me.coldelete.FieldName = "delete"
        Me.coldelete.MinWidth = 31
        Me.coldelete.Name = "coldelete"
        Me.coldelete.Visible = True
        Me.coldelete.VisibleIndex = 5
        Me.coldelete.Width = 1199
        '
        'colname
        '
        Me.colname.AppearanceHeader.Options.UseTextOptions = True
        Me.colname.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colname.Caption = "Φόρμα"
        Me.colname.FieldName = "name"
        Me.colname.MinWidth = 31
        Me.colname.Name = "colname"
        Me.colname.OptionsColumn.AllowEdit = False
        Me.colname.Visible = True
        Me.colname.VisibleIndex = 1
        Me.colname.Width = 438
        '
        'cmdExit
        '
        Me.cmdExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdExit.Location = New System.Drawing.Point(1543, 1065)
        Me.cmdExit.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(89, 32)
        Me.cmdExit.StyleController = Me.LayoutControl1
        Me.cmdExit.TabIndex = 6
        Me.cmdExit.Text = "Έξοδος"
        '
        'cmdSave
        '
        Me.cmdSave.Location = New System.Drawing.Point(1326, 1065)
        Me.cmdSave.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(213, 32)
        Me.cmdSave.StyleController = Me.LayoutControl1
        Me.cmdSave.TabIndex = 7
        Me.cmdSave.Text = "Προσθήκη νέας Φορμας"
        '
        'Root
        '
        Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.Root.GroupBordersVisible = False
        Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem4, Me.LayoutControlItem8, Me.EmptySpaceItem1, Me.LayoutControlItem1, Me.LayoutControlItem5})
        Me.Root.Name = "Root"
        Me.Root.Size = New System.Drawing.Size(1643, 1107)
        Me.Root.TextVisible = False
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.cmdExit
        Me.LayoutControlItem4.Location = New System.Drawing.Point(1532, 1055)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(93, 36)
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem4.TextVisible = False
        '
        'LayoutControlItem8
        '
        Me.LayoutControlItem8.Control = Me.GridControl1
        Me.LayoutControlItem8.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem8.Name = "LayoutControlItem8"
        Me.LayoutControlItem8.Size = New System.Drawing.Size(1625, 1055)
        Me.LayoutControlItem8.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem8.TextVisible = False
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(0, 1055)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(658, 36)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.txtFormName
        Me.LayoutControlItem1.Location = New System.Drawing.Point(658, 1055)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(657, 36)
        Me.LayoutControlItem1.Text = "Όνομα Φόρμας"
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(110, 19)
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.cmdSave
        Me.LayoutControlItem5.Location = New System.Drawing.Point(1315, 1055)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(217, 36)
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem5.TextVisible = False
        '
        'DMDataSet
        '
        Me.DMDataSet.DataSetName = "DMDataSet"
        Me.DMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'FORMRIGHTSBindingSource
        '
        Me.FORMRIGHTSBindingSource.DataMember = "FORMRIGHTS"
        Me.FORMRIGHTSBindingSource.DataSource = Me.DMDataSet
        '
        'FORMRIGHTSTableAdapter
        '
        Me.FORMRIGHTSTableAdapter.ClearBeforeFill = True
        '
        'frmPermissions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.CancelButton = Me.cmdExit
        Me.ClientSize = New System.Drawing.Size(1643, 1107)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frmPermissions"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "frmPermissions"
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.txtFormName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DMDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FORMRIGHTSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents cmdExit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Root As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
    'Friend WithEvents FORMRIGHTSTableAdapter As Priamos_NETDataSet3TableAdapters.FORMRIGHTSTableAdapter
    Friend WithEvents colRealName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colview As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colinsert As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coledit As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldelete As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colname As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents txtFormName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents DMDataSet As DMDataSet
    Friend WithEvents FORMRIGHTSBindingSource As BindingSource
    Friend WithEvents FORMRIGHTSTableAdapter As DMDataSetTableAdapters.FORMRIGHTSTableAdapter
End Class
