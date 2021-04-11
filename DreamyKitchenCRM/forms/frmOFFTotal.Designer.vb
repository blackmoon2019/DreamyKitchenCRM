<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmOFFTotal
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
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.cmdExit = New DevExpress.XtraEditors.SimpleButton()
        Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.VwOFFERSTOTALBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DreamyKitchenDataSet = New DreamyKitchenCRM.DreamyKitchenDataSet()
        Me.Vw_OFFERS_TOTALTableAdapter = New DreamyKitchenCRM.DreamyKitchenDataSetTableAdapters.vw_OFFERS_TOTALTableAdapter()
        Me.grdOffTotal = New DevExpress.XtraGrid.GridControl()
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.RepositoryItemButtonOil = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VwOFFERSTOTALBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DreamyKitchenDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdOffTotal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemButtonOil, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.grdOffTotal)
        Me.LayoutControl1.Controls.Add(Me.cmdExit)
        Me.LayoutControl1.Location = New System.Drawing.Point(-6, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.Root = Me.Root
        Me.LayoutControl1.Size = New System.Drawing.Size(938, 484)
        Me.LayoutControl1.TabIndex = 0
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'cmdExit
        '
        Me.cmdExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdExit.ImageOptions.Image = Global.DreamyKitchenCRM.My.Resources.Resources.icons8_exit_24
        Me.cmdExit.Location = New System.Drawing.Point(816, 444)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(110, 28)
        Me.cmdExit.StyleController = Me.LayoutControl1
        Me.cmdExit.TabIndex = 22
        Me.cmdExit.Text = "Έξοδος"
        '
        'Root
        '
        Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.Root.GroupBordersVisible = False
        Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem2, Me.EmptySpaceItem1, Me.LayoutControlItem1})
        Me.Root.Name = "Root"
        Me.Root.Size = New System.Drawing.Size(938, 484)
        Me.Root.TextVisible = False
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.cmdExit
        Me.LayoutControlItem2.Location = New System.Drawing.Point(804, 432)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(114, 32)
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem2.TextVisible = False
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(0, 432)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(804, 32)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'VwOFFERSTOTALBindingSource
        '
        Me.VwOFFERSTOTALBindingSource.DataMember = "vw_OFFERS_TOTAL"
        Me.VwOFFERSTOTALBindingSource.DataSource = Me.DreamyKitchenDataSet
        '
        'DreamyKitchenDataSet
        '
        Me.DreamyKitchenDataSet.DataSetName = "DreamyKitchenDataSet"
        Me.DreamyKitchenDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Vw_OFFERS_TOTALTableAdapter
        '
        Me.Vw_OFFERS_TOTALTableAdapter.ClearBeforeFill = True
        '
        'grdOffTotal
        '
        Me.grdOffTotal.Location = New System.Drawing.Point(12, 12)
        Me.grdOffTotal.MainView = Me.GridView3
        Me.grdOffTotal.Name = "grdOffTotal"
        Me.grdOffTotal.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemButtonOil})
        Me.grdOffTotal.Size = New System.Drawing.Size(914, 428)
        Me.grdOffTotal.TabIndex = 37
        Me.grdOffTotal.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView3})
        '
        'GridView3
        '
        Me.GridView3.GridControl = Me.grdOffTotal
        Me.GridView3.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always
        Me.GridView3.LevelIndent = 0
        Me.GridView3.Name = "GridView3"
        Me.GridView3.OptionsBehavior.Editable = False
        Me.GridView3.OptionsView.ColumnAutoWidth = False
        Me.GridView3.PreviewIndent = 0
        '
        'RepositoryItemButtonOil
        '
        Me.RepositoryItemButtonOil.AutoHeight = False
        Me.RepositoryItemButtonOil.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.RepositoryItemButtonOil.Name = "RepositoryItemButtonOil"
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.grdOffTotal
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(918, 432)
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'frmOFFTotal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(932, 484)
        Me.Controls.Add(Me.LayoutControl1)
        Me.IconOptions.Image = Global.DreamyKitchenCRM.My.Resources.Resources.favicon
        Me.Name = "frmOFFTotal"
        Me.Text = "frmOFFTotal"
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.Root, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VwOFFERSTOTALBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DreamyKitchenDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdOffTotal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemButtonOil, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents Root As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents cmdExit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents DreamyKitchenDataSet As DreamyKitchenDataSet
    Friend WithEvents VwOFFERSTOTALBindingSource As BindingSource
    Friend WithEvents Vw_OFFERS_TOTALTableAdapter As DreamyKitchenDataSetTableAdapters.vw_OFFERS_TOTALTableAdapter
    Friend WithEvents grdOffTotal As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RepositoryItemButtonOil As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
End Class
