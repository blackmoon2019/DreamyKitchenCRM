<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmNotesScroller
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmNotesScroller))
        Me.RepositoryItemMemoEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
        Me.grdMain = New DevExpress.XtraGrid.GridControl()
        Me.VwNOTESBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DreamyKitchenDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DreamyKitchenDataSet = New DreamyKitchenCRM.DreamyKitchenDataSet()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Layout.LayoutView()
        Me.colID = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
        Me.layoutViewField_colID1 = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
        Me.colcode = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
        Me.layoutViewField_colcode1 = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
        Me.coltitle = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
        Me.layoutViewField_coltitle1 = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
        Me.colHasFiles = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
        Me.layoutViewField_colHasFiles1 = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
        Me.colReaded = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
        Me.layoutViewField_colReaded = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
        Me.colNote = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
        Me.RepositoryItemMemoEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
        Me.layoutViewField_colNote1 = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
        Me.colSalerName = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
        Me.layoutViewField_colSalerName = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
        Me.colRealName = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
        Me.layoutViewField_colRealName1 = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
        Me.colLabel = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
        Me.layoutViewField_colLabel1 = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
        Me.LayoutViewColumn1 = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
        Me.layoutViewField_LayoutViewColumn1 = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
        Me.LayoutViewCard1 = New DevExpress.XtraGrid.Views.Layout.LayoutViewCard()
        Me.Vw_NOTESTableAdapter = New DreamyKitchenCRM.DreamyKitchenDataSetTableAdapters.vw_NOTESTableAdapter()
        Me.Bar1 = New DevExpress.XtraBars.Bar()
        Me.Bar3 = New DevExpress.XtraBars.Bar()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar5 = New DevExpress.XtraBars.Bar()
        Me.BarNewRec = New DevExpress.XtraBars.BarButtonItem()
        Me.BarDelete = New DevExpress.XtraBars.BarButtonItem()
        Me.BarEdit = New DevExpress.XtraBars.BarButtonItem()
        Me.BarRefresh = New DevExpress.XtraBars.BarButtonItem()
        Me.BarIncoming = New DevExpress.XtraBars.BarButtonItem()
        Me.BarOutgoing = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.Bar2 = New DevExpress.XtraBars.Bar()
        Me.Bar4 = New DevExpress.XtraBars.Bar()
        CType(Me.RepositoryItemMemoEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdMain, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VwNOTESBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DreamyKitchenDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DreamyKitchenDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.layoutViewField_colID1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.layoutViewField_colcode1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.layoutViewField_coltitle1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.layoutViewField_colHasFiles1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.layoutViewField_colReaded, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.layoutViewField_colNote1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.layoutViewField_colSalerName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.layoutViewField_colRealName1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.layoutViewField_colLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.layoutViewField_LayoutViewColumn1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutViewCard1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RepositoryItemMemoEdit1
        '
        Me.RepositoryItemMemoEdit1.Name = "RepositoryItemMemoEdit1"
        '
        'grdMain
        '
        Me.grdMain.DataSource = Me.VwNOTESBindingSource
        Me.grdMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdMain.Location = New System.Drawing.Point(26, 0)
        Me.grdMain.MainView = Me.GridView1
        Me.grdMain.Name = "grdMain"
        Me.grdMain.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemMemoEdit2})
        Me.grdMain.Size = New System.Drawing.Size(1338, 771)
        Me.grdMain.TabIndex = 1
        Me.grdMain.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'VwNOTESBindingSource
        '
        Me.VwNOTESBindingSource.DataMember = "vw_NOTES"
        Me.VwNOTESBindingSource.DataSource = Me.DreamyKitchenDataSetBindingSource
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
        'GridView1
        '
        Me.GridView1.CardMinSize = New System.Drawing.Size(375, 395)
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.LayoutViewColumn() {Me.colID, Me.colcode, Me.coltitle, Me.colHasFiles, Me.colReaded, Me.colNote, Me.colSalerName, Me.colRealName, Me.colLabel, Me.LayoutViewColumn1})
        Me.GridView1.GridControl = Me.grdMain
        Me.GridView1.HiddenItems.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutViewField_colID1, Me.layoutViewField_colcode1})
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsBehavior.ReadOnly = True
        Me.GridView1.OptionsView.ShowCardCaption = False
        Me.GridView1.OptionsView.ViewMode = DevExpress.XtraGrid.Views.Layout.LayoutViewMode.MultiColumn
        Me.GridView1.TemplateCard = Me.LayoutViewCard1
        '
        'colID
        '
        Me.colID.Caption = "ID"
        Me.colID.CustomizationCaption = "ID"
        Me.colID.FieldName = "ID"
        Me.colID.LayoutViewField = Me.layoutViewField_colID1
        Me.colID.Name = "colID"
        '
        'layoutViewField_colID1
        '
        Me.layoutViewField_colID1.EditorPreferredWidth = 20
        Me.layoutViewField_colID1.Location = New System.Drawing.Point(0, 0)
        Me.layoutViewField_colID1.Name = "layoutViewField_colID1"
        Me.layoutViewField_colID1.Size = New System.Drawing.Size(350, 165)
        Me.layoutViewField_colID1.TextSize = New System.Drawing.Size(49, 13)
        '
        'colcode
        '
        Me.colcode.Caption = "Κωδικός"
        Me.colcode.CustomizationCaption = "Κωδικός"
        Me.colcode.FieldName = "code"
        Me.colcode.LayoutViewField = Me.layoutViewField_colcode1
        Me.colcode.Name = "colcode"
        '
        'layoutViewField_colcode1
        '
        Me.layoutViewField_colcode1.EditorPreferredWidth = 20
        Me.layoutViewField_colcode1.Location = New System.Drawing.Point(0, 0)
        Me.layoutViewField_colcode1.Name = "layoutViewField_colcode1"
        Me.layoutViewField_colcode1.Size = New System.Drawing.Size(350, 165)
        Me.layoutViewField_colcode1.TextSize = New System.Drawing.Size(49, 13)
        '
        'coltitle
        '
        Me.coltitle.Caption = "Τίτλος"
        Me.coltitle.CustomizationCaption = "Τίτλος"
        Me.coltitle.FieldName = "title"
        Me.coltitle.LayoutViewField = Me.layoutViewField_coltitle1
        Me.coltitle.Name = "coltitle"
        '
        'layoutViewField_coltitle1
        '
        Me.layoutViewField_coltitle1.EditorPreferredWidth = 243
        Me.layoutViewField_coltitle1.Location = New System.Drawing.Point(0, 0)
        Me.layoutViewField_coltitle1.Name = "layoutViewField_coltitle1"
        Me.layoutViewField_coltitle1.Size = New System.Drawing.Size(367, 24)
        Me.layoutViewField_coltitle1.TextSize = New System.Drawing.Size(115, 13)
        '
        'colHasFiles
        '
        Me.colHasFiles.Caption = "Επισυναπτόμενα"
        Me.colHasFiles.CustomizationCaption = "Επισυναπτόμενα"
        Me.colHasFiles.FieldName = "HasFiles"
        Me.colHasFiles.LayoutViewField = Me.layoutViewField_colHasFiles1
        Me.colHasFiles.Name = "colHasFiles"
        '
        'layoutViewField_colHasFiles1
        '
        Me.layoutViewField_colHasFiles1.EditorPreferredWidth = 243
        Me.layoutViewField_colHasFiles1.ImageOptions.Image = CType(resources.GetObject("layoutViewField_colHasFiles1.ImageOptions.Image"), System.Drawing.Image)
        Me.layoutViewField_colHasFiles1.Location = New System.Drawing.Point(0, 117)
        Me.layoutViewField_colHasFiles1.Name = "layoutViewField_colHasFiles1"
        Me.layoutViewField_colHasFiles1.Size = New System.Drawing.Size(367, 24)
        Me.layoutViewField_colHasFiles1.TextSize = New System.Drawing.Size(115, 16)
        '
        'colReaded
        '
        Me.colReaded.Caption = "Διαβάστηκε"
        Me.colReaded.CustomizationCaption = "Διαβάστηκε"
        Me.colReaded.FieldName = "Readed"
        Me.colReaded.LayoutViewField = Me.layoutViewField_colReaded
        Me.colReaded.Name = "colReaded"
        '
        'layoutViewField_colReaded
        '
        Me.layoutViewField_colReaded.EditorPreferredWidth = 243
        Me.layoutViewField_colReaded.Location = New System.Drawing.Point(0, 141)
        Me.layoutViewField_colReaded.Name = "layoutViewField_colReaded"
        Me.layoutViewField_colReaded.Size = New System.Drawing.Size(367, 24)
        Me.layoutViewField_colReaded.TextSize = New System.Drawing.Size(115, 13)
        '
        'colNote
        '
        Me.colNote.Caption = "Διαβάστηκε"
        Me.colNote.ColumnEdit = Me.RepositoryItemMemoEdit2
        Me.colNote.CustomizationCaption = "Διαβάστηκε"
        Me.colNote.FieldName = "Note"
        Me.colNote.LayoutViewField = Me.layoutViewField_colNote1
        Me.colNote.Name = "colNote"
        '
        'RepositoryItemMemoEdit2
        '
        Me.RepositoryItemMemoEdit2.Name = "RepositoryItemMemoEdit2"
        '
        'layoutViewField_colNote1
        '
        Me.layoutViewField_colNote1.EditorPreferredWidth = 243
        Me.layoutViewField_colNote1.Location = New System.Drawing.Point(0, 24)
        Me.layoutViewField_colNote1.Name = "layoutViewField_colNote1"
        Me.layoutViewField_colNote1.Size = New System.Drawing.Size(367, 21)
        Me.layoutViewField_colNote1.TextSize = New System.Drawing.Size(115, 13)
        '
        'colSalerName
        '
        Me.colSalerName.Caption = "Αφορά τον Πωλητή"
        Me.colSalerName.CustomizationCaption = "Αφορά τον Πωλητή"
        Me.colSalerName.FieldName = "SalerName"
        Me.colSalerName.LayoutViewField = Me.layoutViewField_colSalerName
        Me.colSalerName.Name = "colSalerName"
        '
        'layoutViewField_colSalerName
        '
        Me.layoutViewField_colSalerName.EditorPreferredWidth = 243
        Me.layoutViewField_colSalerName.Location = New System.Drawing.Point(0, 69)
        Me.layoutViewField_colSalerName.Name = "layoutViewField_colSalerName"
        Me.layoutViewField_colSalerName.Size = New System.Drawing.Size(367, 24)
        Me.layoutViewField_colSalerName.TextSize = New System.Drawing.Size(115, 13)
        '
        'colRealName
        '
        Me.colRealName.Caption = "Χρήστης"
        Me.colRealName.CustomizationCaption = "Χρήστης"
        Me.colRealName.FieldName = "RealName"
        Me.colRealName.LayoutViewField = Me.layoutViewField_colRealName1
        Me.colRealName.Name = "colRealName"
        '
        'layoutViewField_colRealName1
        '
        Me.layoutViewField_colRealName1.EditorPreferredWidth = 243
        Me.layoutViewField_colRealName1.Location = New System.Drawing.Point(0, 45)
        Me.layoutViewField_colRealName1.Name = "layoutViewField_colRealName1"
        Me.layoutViewField_colRealName1.Size = New System.Drawing.Size(367, 24)
        Me.layoutViewField_colRealName1.TextSize = New System.Drawing.Size(115, 13)
        '
        'colLabel
        '
        Me.colLabel.Caption = "Εττικέτα"
        Me.colLabel.CustomizationCaption = "Εττικέτα"
        Me.colLabel.FieldName = "Label"
        Me.colLabel.LayoutViewField = Me.layoutViewField_colLabel1
        Me.colLabel.Name = "colLabel"
        '
        'layoutViewField_colLabel1
        '
        Me.layoutViewField_colLabel1.EditorPreferredWidth = 243
        Me.layoutViewField_colLabel1.Location = New System.Drawing.Point(0, 93)
        Me.layoutViewField_colLabel1.Name = "layoutViewField_colLabel1"
        Me.layoutViewField_colLabel1.Size = New System.Drawing.Size(367, 24)
        Me.layoutViewField_colLabel1.TextSize = New System.Drawing.Size(115, 13)
        '
        'LayoutViewColumn1
        '
        Me.LayoutViewColumn1.Caption = "Ημερν/ια Καταχώρησης"
        Me.LayoutViewColumn1.CustomizationCaption = "Ημερν/ια Καταχώρησης"
        Me.LayoutViewColumn1.FieldName = "createdOn"
        Me.LayoutViewColumn1.LayoutViewField = Me.layoutViewField_LayoutViewColumn1
        Me.LayoutViewColumn1.Name = "LayoutViewColumn1"
        '
        'layoutViewField_LayoutViewColumn1
        '
        Me.layoutViewField_LayoutViewColumn1.EditorPreferredWidth = 10
        Me.layoutViewField_LayoutViewColumn1.Location = New System.Drawing.Point(0, 165)
        Me.layoutViewField_LayoutViewColumn1.Name = "layoutViewField_LayoutViewColumn1"
        Me.layoutViewField_LayoutViewColumn1.Size = New System.Drawing.Size(367, 20)
        Me.layoutViewField_LayoutViewColumn1.TextSize = New System.Drawing.Size(115, 13)
        '
        'LayoutViewCard1
        '
        Me.LayoutViewCard1.CustomizationFormText = "TemplateCard"
        Me.LayoutViewCard1.GroupBordersVisible = False
        Me.LayoutViewCard1.HeaderButtonsLocation = DevExpress.Utils.GroupElementLocation.AfterText
        Me.LayoutViewCard1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutViewField_coltitle1, Me.layoutViewField_colNote1, Me.layoutViewField_colRealName1, Me.layoutViewField_colLabel1, Me.layoutViewField_colHasFiles1, Me.layoutViewField_colSalerName, Me.layoutViewField_colReaded, Me.layoutViewField_LayoutViewColumn1})
        Me.LayoutViewCard1.Name = "LayoutViewCard1"
        Me.LayoutViewCard1.OptionsItemText.TextToControlDistance = 5
        Me.LayoutViewCard1.Text = "TemplateCard"
        '
        'Vw_NOTESTableAdapter
        '
        Me.Vw_NOTESTableAdapter.ClearBeforeFill = True
        '
        'Bar1
        '
        Me.Bar1.BarName = "MainMenu"
        Me.Bar1.DockCol = 0
        Me.Bar1.DockRow = 0
        Me.Bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar1.OptionsBar.MultiLine = True
        Me.Bar1.OptionsBar.UseWholeRow = True
        Me.Bar1.Text = "MainMenu"
        '
        'Bar3
        '
        Me.Bar3.BarName = "StatusBar"
        Me.Bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        Me.Bar3.DockCol = 0
        Me.Bar3.DockRow = 0
        Me.Bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.Bar3.OptionsBar.AllowQuickCustomization = False
        Me.Bar3.OptionsBar.DrawDragBorder = False
        Me.Bar3.OptionsBar.UseWholeRow = True
        Me.Bar3.Text = "StatusBar"
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar5})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.BarNewRec, Me.BarDelete, Me.BarEdit, Me.BarRefresh, Me.BarIncoming, Me.BarOutgoing})
        Me.BarManager1.MaxItemId = 51
        '
        'Bar5
        '
        Me.Bar5.BarName = "Custom 4"
        Me.Bar5.DockCol = 0
        Me.Bar5.DockRow = 0
        Me.Bar5.DockStyle = DevExpress.XtraBars.BarDockStyle.Left
        Me.Bar5.FloatLocation = New System.Drawing.Point(49, 225)
        Me.Bar5.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarNewRec), New DevExpress.XtraBars.LinkPersistInfo(Me.BarDelete), New DevExpress.XtraBars.LinkPersistInfo(Me.BarEdit), New DevExpress.XtraBars.LinkPersistInfo(Me.BarRefresh), New DevExpress.XtraBars.LinkPersistInfo(Me.BarIncoming), New DevExpress.XtraBars.LinkPersistInfo(Me.BarOutgoing)})
        Me.Bar5.Offset = 1
        Me.Bar5.Text = "Custom 4"
        '
        'BarNewRec
        '
        Me.BarNewRec.Caption = "Νέα Εγγραφή"
        Me.BarNewRec.Id = 32
        Me.BarNewRec.ImageOptions.Image = Global.DreamyKitchenCRM.My.Resources.Resources.AddFile_16x16
        Me.BarNewRec.Name = "BarNewRec"
        '
        'BarDelete
        '
        Me.BarDelete.Caption = "Διαγραφή Εγγραφής"
        Me.BarDelete.Id = 33
        Me.BarDelete.ImageOptions.Image = Global.DreamyKitchenCRM.My.Resources.Resources.Remove_16x16
        Me.BarDelete.Name = "BarDelete"
        '
        'BarEdit
        '
        Me.BarEdit.Caption = "Διόρθωση Εγγραφής"
        Me.BarEdit.Id = 34
        Me.BarEdit.ImageOptions.Image = Global.DreamyKitchenCRM.My.Resources.Resources.Edit_16x16
        Me.BarEdit.Name = "BarEdit"
        '
        'BarRefresh
        '
        Me.BarRefresh.Caption = "Ανανέωση Εγγραφών"
        Me.BarRefresh.Id = 35
        Me.BarRefresh.ImageOptions.Image = Global.DreamyKitchenCRM.My.Resources.Resources.icons8_refresh_16
        Me.BarRefresh.Name = "BarRefresh"
        '
        'BarIncoming
        '
        Me.BarIncoming.Caption = "Εισερχόμενα"
        Me.BarIncoming.Id = 49
        Me.BarIncoming.Name = "BarIncoming"
        '
        'BarOutgoing
        '
        Me.BarOutgoing.Caption = "Εξερχόμενα"
        Me.BarOutgoing.Id = 50
        Me.BarOutgoing.Name = "BarOutgoing"
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Manager = Me.BarManager1
        Me.barDockControlTop.Size = New System.Drawing.Size(1364, 0)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 771)
        Me.barDockControlBottom.Manager = Me.BarManager1
        Me.barDockControlBottom.Size = New System.Drawing.Size(1364, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlLeft.Manager = Me.BarManager1
        Me.barDockControlLeft.Size = New System.Drawing.Size(26, 771)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(1364, 0)
        Me.barDockControlRight.Manager = Me.BarManager1
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 771)
        '
        'Bar2
        '
        Me.Bar2.BarName = "MainMenu"
        Me.Bar2.DockCol = 0
        Me.Bar2.DockRow = 0
        Me.Bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar2.OptionsBar.MultiLine = True
        Me.Bar2.OptionsBar.UseWholeRow = True
        Me.Bar2.Text = "MainMenu"
        '
        'Bar4
        '
        Me.Bar4.BarName = "StatusBar"
        Me.Bar4.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        Me.Bar4.DockCol = 0
        Me.Bar4.DockRow = 0
        Me.Bar4.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.Bar4.OptionsBar.AllowQuickCustomization = False
        Me.Bar4.OptionsBar.DrawDragBorder = False
        Me.Bar4.OptionsBar.UseWholeRow = True
        Me.Bar4.Text = "StatusBar"
        '
        'frmNotesScroller
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1364, 771)
        Me.Controls.Add(Me.grdMain)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Name = "frmNotesScroller"
        Me.Text = "Σημειώματα"
        CType(Me.RepositoryItemMemoEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdMain, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VwNOTESBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DreamyKitchenDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DreamyKitchenDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.layoutViewField_colID1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.layoutViewField_colcode1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.layoutViewField_coltitle1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.layoutViewField_colHasFiles1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.layoutViewField_colReaded, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.layoutViewField_colNote1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.layoutViewField_colSalerName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.layoutViewField_colRealName1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.layoutViewField_colLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.layoutViewField_LayoutViewColumn1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutViewCard1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DreamyKitchenDataSetBindingSource As BindingSource
    Friend WithEvents DreamyKitchenDataSet As DreamyKitchenDataSet
    Friend WithEvents VwNOTESBindingSource As BindingSource
    Friend WithEvents Vw_NOTESTableAdapter As DreamyKitchenDataSetTableAdapters.vw_NOTESTableAdapter
    Friend WithEvents RepositoryItemMemoEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents grdMain As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Layout.LayoutView
    Friend WithEvents Bar1 As DevExpress.XtraBars.Bar
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar5 As DevExpress.XtraBars.Bar
    Friend WithEvents BarNewRec As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarDelete As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarEdit As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarRefresh As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents Bar2 As DevExpress.XtraBars.Bar
    Friend WithEvents Bar4 As DevExpress.XtraBars.Bar
    Friend WithEvents RepositoryItemMemoEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents colID As DevExpress.XtraGrid.Columns.LayoutViewColumn
    Friend WithEvents colcode As DevExpress.XtraGrid.Columns.LayoutViewColumn
    Friend WithEvents coltitle As DevExpress.XtraGrid.Columns.LayoutViewColumn
    Friend WithEvents colNote As DevExpress.XtraGrid.Columns.LayoutViewColumn
    Friend WithEvents colRealName As DevExpress.XtraGrid.Columns.LayoutViewColumn
    Friend WithEvents colLabel As DevExpress.XtraGrid.Columns.LayoutViewColumn
    Friend WithEvents colHasFiles As DevExpress.XtraGrid.Columns.LayoutViewColumn
    Friend WithEvents colSalerName As DevExpress.XtraGrid.Columns.LayoutViewColumn
    Friend WithEvents layoutViewField_colID1 As DevExpress.XtraGrid.Views.Layout.LayoutViewField
    Friend WithEvents layoutViewField_colcode1 As DevExpress.XtraGrid.Views.Layout.LayoutViewField
    Friend WithEvents layoutViewField_coltitle1 As DevExpress.XtraGrid.Views.Layout.LayoutViewField
    Friend WithEvents layoutViewField_colHasFiles1 As DevExpress.XtraGrid.Views.Layout.LayoutViewField
    Friend WithEvents colReaded As DevExpress.XtraGrid.Columns.LayoutViewColumn
    Friend WithEvents layoutViewField_colReaded As DevExpress.XtraGrid.Views.Layout.LayoutViewField
    Friend WithEvents layoutViewField_colNote1 As DevExpress.XtraGrid.Views.Layout.LayoutViewField
    Friend WithEvents layoutViewField_colSalerName As DevExpress.XtraGrid.Views.Layout.LayoutViewField
    Friend WithEvents layoutViewField_colRealName1 As DevExpress.XtraGrid.Views.Layout.LayoutViewField
    Friend WithEvents layoutViewField_colLabel1 As DevExpress.XtraGrid.Views.Layout.LayoutViewField
    Friend WithEvents LayoutViewCard1 As DevExpress.XtraGrid.Views.Layout.LayoutViewCard
    Friend WithEvents BarIncoming As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarOutgoing As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents LayoutViewColumn1 As DevExpress.XtraGrid.Columns.LayoutViewColumn
    Friend WithEvents layoutViewField_LayoutViewColumn1 As DevExpress.XtraGrid.Views.Layout.LayoutViewField
End Class
