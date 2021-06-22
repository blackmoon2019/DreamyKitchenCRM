<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTransactions))
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.chkCash = New DevExpress.XtraEditors.CheckEdit()
        Me.GridControl2 = New DevExpress.XtraGrid.GridControl()
        Me.VwCCTFBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DreamyKitchenDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DreamyKitchenDataSet = New DreamyKitchenCRM.DreamyKitchenDataSet()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colID1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colcode1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colcctID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colfiles = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colfilename = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colisinvoice = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colcomefrom = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colextension = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colmodifiedOn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colcreatedOn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRealName1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cmdSaveTransD = New DevExpress.XtraEditors.SimpleButton()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.VwTRANSDBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coltranshID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colbankID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.VwBANKSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.colBankName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colcash = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colamt = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colcmt = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coldtPay = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRealName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colmodifiedOn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colcreatedOn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cmdSaveTransH = New DevExpress.XtraEditors.SimpleButton()
        Me.cboCUS = New DevExpress.XtraEditors.LookUpEdit()
        Me.dtCharge = New DevExpress.XtraEditors.DateEdit()
        Me.txtCode = New DevExpress.XtraEditors.TextEdit()
        Me.txtComments = New DevExpress.XtraEditors.MemoEdit()
        Me.txtVatAmt = New DevExpress.XtraEditors.TextEdit()
        Me.txtCode1 = New DevExpress.XtraEditors.TextEdit()
        Me.dtPay = New DevExpress.XtraEditors.DateEdit()
        Me.txtamtD = New DevExpress.XtraEditors.TextEdit()
        Me.txtCMTD = New DevExpress.XtraEditors.MemoEdit()
        Me.cboBANK = New DevExpress.XtraEditors.LookUpEdit()
        Me.txtInvoiceFilename = New DevExpress.XtraEditors.ButtonEdit()
        Me.txtTotAmt = New DevExpress.XtraEditors.TextEdit()
        Me.txtAmtH = New DevExpress.XtraEditors.TextEdit()
        Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem3 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem14 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem45 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem15 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem13 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem16 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem12 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
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
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.cmdExit = New DevExpress.XtraEditors.SimpleButton()
        Me.Vw_CCT_FTableAdapter = New DreamyKitchenCRM.DreamyKitchenDataSetTableAdapters.vw_CCT_FTableAdapter()
        Me.Vw_TRANSDTableAdapter = New DreamyKitchenCRM.DreamyKitchenDataSetTableAdapters.vw_TRANSDTableAdapter()
        Me.Vw_BANKSTableAdapter = New DreamyKitchenCRM.DreamyKitchenDataSetTableAdapters.vw_BANKSTableAdapter()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.chkCash.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VwCCTFBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DreamyKitchenDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DreamyKitchenDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VwTRANSDBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VwBANKSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboCUS.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtCharge.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtCharge.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtComments.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtVatAmt.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCode1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtPay.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtPay.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtamtD.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCMTD.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboBANK.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtInvoiceFilename.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTotAmt.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAmtH.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem45, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.SuspendLayout()
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.chkCash)
        Me.LayoutControl1.Controls.Add(Me.GridControl2)
        Me.LayoutControl1.Controls.Add(Me.cmdSaveTransD)
        Me.LayoutControl1.Controls.Add(Me.GridControl1)
        Me.LayoutControl1.Controls.Add(Me.cmdSaveTransH)
        Me.LayoutControl1.Controls.Add(Me.cboCUS)
        Me.LayoutControl1.Controls.Add(Me.dtCharge)
        Me.LayoutControl1.Controls.Add(Me.txtCode)
        Me.LayoutControl1.Controls.Add(Me.txtComments)
        Me.LayoutControl1.Controls.Add(Me.txtVatAmt)
        Me.LayoutControl1.Controls.Add(Me.txtCode1)
        Me.LayoutControl1.Controls.Add(Me.dtPay)
        Me.LayoutControl1.Controls.Add(Me.txtamtD)
        Me.LayoutControl1.Controls.Add(Me.txtCMTD)
        Me.LayoutControl1.Controls.Add(Me.cboBANK)
        Me.LayoutControl1.Controls.Add(Me.txtInvoiceFilename)
        Me.LayoutControl1.Controls.Add(Me.txtTotAmt)
        Me.LayoutControl1.Controls.Add(Me.txtAmtH)
        Me.LayoutControl1.Location = New System.Drawing.Point(5, 6)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.Root = Me.Root
        Me.LayoutControl1.Size = New System.Drawing.Size(1124, 757)
        Me.LayoutControl1.TabIndex = 0
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'chkCash
        '
        Me.chkCash.EditValue = CType(0, Byte)
        Me.chkCash.Location = New System.Drawing.Point(582, 117)
        Me.chkCash.Name = "chkCash"
        Me.chkCash.Properties.Caption = "Μετρητά"
        Me.chkCash.Properties.ValueChecked = CType(1, Byte)
        Me.chkCash.Properties.ValueUnchecked = CType(0, Byte)
        Me.chkCash.Size = New System.Drawing.Size(518, 20)
        Me.chkCash.StyleController = Me.LayoutControl1
        Me.chkCash.TabIndex = 48
        Me.chkCash.Tag = "cash,0,1,2"
        '
        'GridControl2
        '
        Me.GridControl2.DataSource = Me.VwCCTFBindingSource
        Me.GridControl2.Location = New System.Drawing.Point(24, 252)
        Me.GridControl2.MainView = Me.GridView2
        Me.GridControl2.Name = "GridControl2"
        Me.GridControl2.Size = New System.Drawing.Size(530, 173)
        Me.GridControl2.TabIndex = 47
        Me.GridControl2.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2})
        '
        'VwCCTFBindingSource
        '
        Me.VwCCTFBindingSource.DataMember = "vw_CCT_F"
        Me.VwCCTFBindingSource.DataSource = Me.DreamyKitchenDataSetBindingSource
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
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colID1, Me.colcode1, Me.colcctID, Me.colfiles, Me.colfilename, Me.colisinvoice, Me.colcomefrom, Me.colextension, Me.colmodifiedOn1, Me.colcreatedOn1, Me.colRealName1})
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
        Me.colID1.Name = "colID1"
        '
        'colcode1
        '
        Me.colcode1.FieldName = "code"
        Me.colcode1.Name = "colcode1"
        '
        'colcctID
        '
        Me.colcctID.FieldName = "cctID"
        Me.colcctID.Name = "colcctID"
        '
        'colfiles
        '
        Me.colfiles.FieldName = "files"
        Me.colfiles.Name = "colfiles"
        '
        'colfilename
        '
        Me.colfilename.Caption = "Όνομα Αρχείου"
        Me.colfilename.FieldName = "filename"
        Me.colfilename.Name = "colfilename"
        Me.colfilename.Visible = True
        Me.colfilename.VisibleIndex = 0
        Me.colfilename.Width = 157
        '
        'colisinvoice
        '
        Me.colisinvoice.FieldName = "isinvoice"
        Me.colisinvoice.Name = "colisinvoice"
        '
        'colcomefrom
        '
        Me.colcomefrom.Caption = "Τοποθεσία"
        Me.colcomefrom.FieldName = "comefrom"
        Me.colcomefrom.Name = "colcomefrom"
        Me.colcomefrom.Visible = True
        Me.colcomefrom.VisibleIndex = 1
        Me.colcomefrom.Width = 229
        '
        'colextension
        '
        Me.colextension.Caption = "Επέκταση"
        Me.colextension.FieldName = "extension"
        Me.colextension.Name = "colextension"
        Me.colextension.Visible = True
        Me.colextension.VisibleIndex = 2
        Me.colextension.Width = 63
        '
        'colmodifiedOn1
        '
        Me.colmodifiedOn1.FieldName = "modifiedOn"
        Me.colmodifiedOn1.Name = "colmodifiedOn1"
        '
        'colcreatedOn1
        '
        Me.colcreatedOn1.FieldName = "createdOn"
        Me.colcreatedOn1.Name = "colcreatedOn1"
        '
        'colRealName1
        '
        Me.colRealName1.FieldName = "RealName"
        Me.colRealName1.Name = "colRealName1"
        '
        'cmdSaveTransD
        '
        Me.cmdSaveTransD.ImageOptions.Image = Global.DreamyKitchenCRM.My.Resources.Resources.icons8_save_close_24
        Me.cmdSaveTransD.Location = New System.Drawing.Point(1005, 429)
        Me.cmdSaveTransD.Name = "cmdSaveTransD"
        Me.cmdSaveTransD.Size = New System.Drawing.Size(95, 28)
        Me.cmdSaveTransD.StyleController = Me.LayoutControl1
        Me.cmdSaveTransD.TabIndex = 46
        Me.cmdSaveTransD.Text = "Αποθήκευση"
        '
        'GridControl1
        '
        Me.GridControl1.DataSource = Me.VwTRANSDBindingSource
        Me.GridControl1.Location = New System.Drawing.Point(12, 473)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemLookUpEdit1})
        Me.GridControl1.Size = New System.Drawing.Size(1100, 272)
        Me.GridControl1.TabIndex = 45
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'VwTRANSDBindingSource
        '
        Me.VwTRANSDBindingSource.DataMember = "vw_TRANSD"
        Me.VwTRANSDBindingSource.DataSource = Me.DreamyKitchenDataSetBindingSource
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colID, Me.coltranshID, Me.colbankID, Me.colBankName, Me.colcash, Me.colamt, Me.colcmt, Me.coldtPay, Me.colRealName, Me.colmodifiedOn, Me.colcreatedOn})
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
        Me.colID.Name = "colID"
        '
        'coltranshID
        '
        Me.coltranshID.FieldName = "transhID"
        Me.coltranshID.Name = "coltranshID"
        '
        'colbankID
        '
        Me.colbankID.Caption = "Τράπεζα"
        Me.colbankID.ColumnEdit = Me.RepositoryItemLookUpEdit1
        Me.colbankID.FieldName = "bankID"
        Me.colbankID.Name = "colbankID"
        Me.colbankID.Visible = True
        Me.colbankID.VisibleIndex = 3
        Me.colbankID.Width = 213
        '
        'RepositoryItemLookUpEdit1
        '
        Me.RepositoryItemLookUpEdit1.AutoHeight = False
        Me.RepositoryItemLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit1.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("RealName", "Real Name", 60, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("code", "code", 32, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("name", "name", 35, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("modifiedBy", "modified By", 64, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("modifiedOn", "modified On", 66, DevExpress.Utils.FormatType.DateTime, "d/M/yyyy", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("createdOn", "created On", 63, DevExpress.Utils.FormatType.DateTime, "d/M/yyyy", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("createdBy", "created By", 61, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default])})
        Me.RepositoryItemLookUpEdit1.DataSource = Me.VwBANKSBindingSource
        Me.RepositoryItemLookUpEdit1.DisplayMember = "name"
        Me.RepositoryItemLookUpEdit1.Name = "RepositoryItemLookUpEdit1"
        Me.RepositoryItemLookUpEdit1.NullText = ""
        Me.RepositoryItemLookUpEdit1.ValueMember = "ID"
        '
        'VwBANKSBindingSource
        '
        Me.VwBANKSBindingSource.DataMember = "vw_BANKS"
        Me.VwBANKSBindingSource.DataSource = Me.DreamyKitchenDataSetBindingSource
        '
        'colBankName
        '
        Me.colBankName.Caption = "Τράπεζα"
        Me.colBankName.FieldName = "BankName"
        Me.colBankName.Name = "colBankName"
        Me.colBankName.Width = 325
        '
        'colcash
        '
        Me.colcash.Caption = "Μετρητά"
        Me.colcash.FieldName = "cash"
        Me.colcash.Name = "colcash"
        Me.colcash.Visible = True
        Me.colcash.VisibleIndex = 2
        Me.colcash.Width = 195
        '
        'colamt
        '
        Me.colamt.Caption = "Ποσό"
        Me.colamt.FieldName = "amt"
        Me.colamt.Name = "colamt"
        Me.colamt.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "amt", " Σύνολο {0:n2}€")})
        Me.colamt.Visible = True
        Me.colamt.VisibleIndex = 1
        Me.colamt.Width = 231
        '
        'colcmt
        '
        Me.colcmt.Caption = "Σχόλια"
        Me.colcmt.FieldName = "cmt"
        Me.colcmt.Name = "colcmt"
        Me.colcmt.Visible = True
        Me.colcmt.VisibleIndex = 4
        Me.colcmt.Width = 916
        '
        'coldtPay
        '
        Me.coldtPay.Caption = "Ημερομηνία"
        Me.coldtPay.FieldName = "dtPay"
        Me.coldtPay.Name = "coldtPay"
        Me.coldtPay.Visible = True
        Me.coldtPay.VisibleIndex = 0
        Me.coldtPay.Width = 188
        '
        'colRealName
        '
        Me.colRealName.Caption = "Ενημερώθηκε από"
        Me.colRealName.FieldName = "RealName"
        Me.colRealName.Name = "colRealName"
        '
        'colmodifiedOn
        '
        Me.colmodifiedOn.FieldName = "modifiedOn"
        Me.colmodifiedOn.Name = "colmodifiedOn"
        '
        'colcreatedOn
        '
        Me.colcreatedOn.FieldName = "createdOn"
        Me.colcreatedOn.Name = "colcreatedOn"
        '
        'cmdSaveTransH
        '
        Me.cmdSaveTransH.ImageOptions.Image = Global.DreamyKitchenCRM.My.Resources.Resources.icons8_save_close_24
        Me.cmdSaveTransH.Location = New System.Drawing.Point(459, 429)
        Me.cmdSaveTransH.Name = "cmdSaveTransH"
        Me.cmdSaveTransH.Size = New System.Drawing.Size(95, 28)
        Me.cmdSaveTransH.StyleController = Me.LayoutControl1
        Me.cmdSaveTransH.TabIndex = 43
        Me.cmdSaveTransH.Text = "Αποθήκευση"
        '
        'cboCUS
        '
        Me.cboCUS.Location = New System.Drawing.Point(131, 69)
        Me.cboCUS.Name = "cboCUS"
        Me.cboCUS.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.cboCUS.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Search), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Clear)})
        Me.cboCUS.Properties.NullText = ""
        Me.cboCUS.Properties.PopupSizeable = False
        Me.cboCUS.Size = New System.Drawing.Size(423, 20)
        Me.cboCUS.StyleController = Me.LayoutControl1
        Me.cboCUS.TabIndex = 6
        Me.cboCUS.Tag = "cusID,0,1,2"
        '
        'dtCharge
        '
        Me.dtCharge.EditValue = Nothing
        Me.dtCharge.Location = New System.Drawing.Point(131, 93)
        Me.dtCharge.Name = "dtCharge"
        Me.dtCharge.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtCharge.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtCharge.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.dtCharge.Size = New System.Drawing.Size(423, 20)
        Me.dtCharge.StyleController = Me.LayoutControl1
        Me.dtCharge.TabIndex = 32
        Me.dtCharge.Tag = "dtCharge,0,1,2"
        '
        'txtCode
        '
        Me.txtCode.Location = New System.Drawing.Point(131, 45)
        Me.txtCode.Name = "txtCode"
        Me.txtCode.Properties.Appearance.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.txtCode.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtCode.Properties.Appearance.Options.UseBackColor = True
        Me.txtCode.Properties.Appearance.Options.UseFont = True
        Me.txtCode.Properties.ReadOnly = True
        Me.txtCode.Size = New System.Drawing.Size(52, 20)
        Me.txtCode.StyleController = Me.LayoutControl1
        Me.txtCode.TabIndex = 4
        Me.txtCode.Tag = "code,0"
        '
        'txtComments
        '
        Me.txtComments.Location = New System.Drawing.Point(131, 189)
        Me.txtComments.Name = "txtComments"
        Me.txtComments.Size = New System.Drawing.Size(423, 35)
        Me.txtComments.StyleController = Me.LayoutControl1
        Me.txtComments.TabIndex = 17
        Me.txtComments.Tag = "cmt,0,1,2"
        '
        'txtVatAmt
        '
        Me.txtVatAmt.EditValue = "0,00 €"
        Me.txtVatAmt.Location = New System.Drawing.Point(131, 165)
        Me.txtVatAmt.Name = "txtVatAmt"
        Me.txtVatAmt.Properties.DisplayFormat.FormatString = "c"
        Me.txtVatAmt.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtVatAmt.Properties.EditFormat.FormatString = "n2"
        Me.txtVatAmt.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtVatAmt.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtVatAmt.Properties.MaskSettings.Set("MaskManagerType", GetType(DevExpress.Data.Mask.NumericMaskManager))
        Me.txtVatAmt.Properties.MaskSettings.Set("mask", "c2")
        Me.txtVatAmt.Properties.Tag = "BenchExtraPrice"
        Me.txtVatAmt.Size = New System.Drawing.Size(423, 20)
        Me.txtVatAmt.StyleController = Me.LayoutControl1
        Me.txtVatAmt.TabIndex = 42
        Me.txtVatAmt.Tag = "vatamt,0,1,2"
        Me.txtVatAmt.Visible = False
        '
        'txtCode1
        '
        Me.txtCode1.Location = New System.Drawing.Point(689, 45)
        Me.txtCode1.Name = "txtCode1"
        Me.txtCode1.Properties.Appearance.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.txtCode1.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtCode1.Properties.Appearance.Options.UseBackColor = True
        Me.txtCode1.Properties.Appearance.Options.UseFont = True
        Me.txtCode1.Properties.ReadOnly = True
        Me.txtCode1.Size = New System.Drawing.Size(55, 20)
        Me.txtCode1.StyleController = Me.LayoutControl1
        Me.txtCode1.TabIndex = 4
        Me.txtCode1.Tag = "code,0"
        '
        'dtPay
        '
        Me.dtPay.EditValue = Nothing
        Me.dtPay.Location = New System.Drawing.Point(689, 69)
        Me.dtPay.Name = "dtPay"
        Me.dtPay.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtPay.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtPay.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.dtPay.Size = New System.Drawing.Size(411, 20)
        Me.dtPay.StyleController = Me.LayoutControl1
        Me.dtPay.TabIndex = 32
        Me.dtPay.Tag = "dtPay,0,1,2"
        '
        'txtamtD
        '
        Me.txtamtD.EditValue = "0,00 €"
        Me.txtamtD.Location = New System.Drawing.Point(689, 141)
        Me.txtamtD.Name = "txtamtD"
        Me.txtamtD.Properties.DisplayFormat.FormatString = "c"
        Me.txtamtD.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtamtD.Properties.EditFormat.FormatString = "n2"
        Me.txtamtD.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtamtD.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtamtD.Properties.MaskSettings.Set("MaskManagerType", GetType(DevExpress.Data.Mask.NumericMaskManager))
        Me.txtamtD.Properties.MaskSettings.Set("mask", "c2")
        Me.txtamtD.Properties.Tag = "BenchExtraPrice"
        Me.txtamtD.Size = New System.Drawing.Size(411, 20)
        Me.txtamtD.StyleController = Me.LayoutControl1
        Me.txtamtD.TabIndex = 42
        Me.txtamtD.Tag = "amt,0,1,2"
        Me.txtamtD.Visible = False
        '
        'txtCMTD
        '
        Me.txtCMTD.Location = New System.Drawing.Point(689, 165)
        Me.txtCMTD.Name = "txtCMTD"
        Me.txtCMTD.Size = New System.Drawing.Size(411, 260)
        Me.txtCMTD.StyleController = Me.LayoutControl1
        Me.txtCMTD.TabIndex = 17
        Me.txtCMTD.Tag = "cmt,0,1,2"
        '
        'cboBANK
        '
        Me.cboBANK.Location = New System.Drawing.Point(689, 93)
        Me.cboBANK.Name = "cboBANK"
        Me.cboBANK.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.cboBANK.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Search), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Clear)})
        Me.cboBANK.Properties.NullText = ""
        Me.cboBANK.Properties.PopupSizeable = False
        Me.cboBANK.Size = New System.Drawing.Size(411, 20)
        Me.cboBANK.StyleController = Me.LayoutControl1
        Me.cboBANK.TabIndex = 6
        Me.cboBANK.Tag = "bankID,0,1,2"
        '
        'txtInvoiceFilename
        '
        Me.txtInvoiceFilename.Location = New System.Drawing.Point(131, 228)
        Me.txtInvoiceFilename.Name = "txtInvoiceFilename"
        Me.txtInvoiceFilename.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.txtInvoiceFilename.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete)})
        Me.txtInvoiceFilename.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.txtInvoiceFilename.Size = New System.Drawing.Size(423, 20)
        Me.txtInvoiceFilename.StyleController = Me.LayoutControl1
        Me.txtInvoiceFilename.TabIndex = 6
        Me.txtInvoiceFilename.Tag = ""
        '
        'txtTotAmt
        '
        Me.txtTotAmt.EditValue = "0,00 €"
        Me.txtTotAmt.Location = New System.Drawing.Point(131, 117)
        Me.txtTotAmt.Name = "txtTotAmt"
        Me.txtTotAmt.Properties.DisplayFormat.FormatString = "c"
        Me.txtTotAmt.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtTotAmt.Properties.EditFormat.FormatString = "n2"
        Me.txtTotAmt.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtTotAmt.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtTotAmt.Properties.MaskSettings.Set("MaskManagerType", GetType(DevExpress.Data.Mask.NumericMaskManager))
        Me.txtTotAmt.Properties.MaskSettings.Set("mask", "c2")
        Me.txtTotAmt.Properties.Tag = "BenchExtraPrice"
        Me.txtTotAmt.Size = New System.Drawing.Size(423, 20)
        Me.txtTotAmt.StyleController = Me.LayoutControl1
        Me.txtTotAmt.TabIndex = 42
        Me.txtTotAmt.Tag = "Totamt,0,1,2"
        Me.txtTotAmt.Visible = False
        '
        'txtAmtH
        '
        Me.txtAmtH.EditValue = "0,00 €"
        Me.txtAmtH.Location = New System.Drawing.Point(131, 141)
        Me.txtAmtH.Name = "txtAmtH"
        Me.txtAmtH.Properties.DisplayFormat.FormatString = "c"
        Me.txtAmtH.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtAmtH.Properties.EditFormat.FormatString = "n2"
        Me.txtAmtH.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtAmtH.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtAmtH.Properties.MaskSettings.Set("MaskManagerType", GetType(DevExpress.Data.Mask.NumericMaskManager))
        Me.txtAmtH.Properties.MaskSettings.Set("mask", "c2")
        Me.txtAmtH.Properties.Tag = "BenchExtraPrice"
        Me.txtAmtH.Size = New System.Drawing.Size(423, 20)
        Me.txtAmtH.StyleController = Me.LayoutControl1
        Me.txtAmtH.TabIndex = 42
        Me.txtAmtH.Tag = "amt,0,1,2"
        Me.txtAmtH.Visible = False
        '
        'Root
        '
        Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.Root.GroupBordersVisible = False
        Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlGroup1, Me.LayoutControlItem3, Me.LayoutControlGroup2})
        Me.Root.Name = "Root"
        Me.Root.Size = New System.Drawing.Size(1124, 757)
        Me.Root.TextVisible = False
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.AppearanceGroup.BorderColor = System.Drawing.Color.DarkRed
        Me.LayoutControlGroup1.AppearanceGroup.Options.UseBorderColor = True
        Me.LayoutControlGroup1.AppearanceGroup.Options.UseTextOptions = True
        Me.LayoutControlGroup1.GroupStyle = DevExpress.Utils.GroupStyle.Card
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem4, Me.EmptySpaceItem3, Me.LayoutControlItem2, Me.LayoutControlItem5, Me.LayoutControlItem14, Me.LayoutControlItem1, Me.EmptySpaceItem1, Me.LayoutControlItem45, Me.LayoutControlItem15, Me.LayoutControlItem13, Me.LayoutControlItem16, Me.LayoutControlItem12})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(558, 461)
        Me.LayoutControlGroup1.Text = "Στοιχεία Χρέωσης"
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.txtCode
        Me.LayoutControlItem4.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem4.CustomizationFormText = "Κωδικός"
        Me.LayoutControlItem4.HighlightFocusedItem = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(163, 24)
        Me.LayoutControlItem4.Text = "Κωδικός"
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(95, 13)
        '
        'EmptySpaceItem3
        '
        Me.EmptySpaceItem3.AllowHotTrack = False
        Me.EmptySpaceItem3.Location = New System.Drawing.Point(163, 0)
        Me.EmptySpaceItem3.Name = "EmptySpaceItem3"
        Me.EmptySpaceItem3.Size = New System.Drawing.Size(371, 24)
        Me.EmptySpaceItem3.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.dtCharge
        Me.LayoutControlItem2.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem2.CustomizationFormText = "Ημερ/νία Ολοκλήρωσης"
        Me.LayoutControlItem2.ImageOptions.Image = CType(resources.GetObject("LayoutControlItem2.ImageOptions.Image"), System.Drawing.Image)
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 48)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(534, 24)
        Me.LayoutControlItem2.Tag = "1"
        Me.LayoutControlItem2.Text = "Ημερ/νία "
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(95, 13)
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.cboCUS
        Me.LayoutControlItem5.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem5.CustomizationFormText = "Περιοχή"
        Me.LayoutControlItem5.HighlightFocusedItem = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlItem5.ImageOptions.Image = CType(resources.GetObject("LayoutControlItem5.ImageOptions.Image"), System.Drawing.Image)
        Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 24)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(534, 24)
        Me.LayoutControlItem5.Tag = "1"
        Me.LayoutControlItem5.Text = "Πελάτης"
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(95, 13)
        '
        'LayoutControlItem14
        '
        Me.LayoutControlItem14.Control = Me.txtComments
        Me.LayoutControlItem14.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem14.CustomizationFormText = "Σχόλια"
        Me.LayoutControlItem14.HighlightFocusedItem = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlItem14.Location = New System.Drawing.Point(0, 144)
        Me.LayoutControlItem14.Name = "LayoutControlItem14"
        Me.LayoutControlItem14.Size = New System.Drawing.Size(534, 39)
        Me.LayoutControlItem14.Text = "Σχόλια"
        Me.LayoutControlItem14.TextSize = New System.Drawing.Size(95, 13)
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.cmdSaveTransH
        Me.LayoutControlItem1.Location = New System.Drawing.Point(435, 384)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(99, 32)
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(0, 384)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(435, 32)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem45
        '
        Me.LayoutControlItem45.Control = Me.txtVatAmt
        Me.LayoutControlItem45.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem45.CustomizationFormText = "Τελική Αξία"
        Me.LayoutControlItem45.HighlightFocusedItem = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlItem45.Location = New System.Drawing.Point(0, 120)
        Me.LayoutControlItem45.Name = "LayoutControlItem45"
        Me.LayoutControlItem45.Size = New System.Drawing.Size(534, 24)
        Me.LayoutControlItem45.Text = "ΦΠΑ Παραστατικού"
        Me.LayoutControlItem45.TextSize = New System.Drawing.Size(95, 13)
        '
        'LayoutControlItem15
        '
        Me.LayoutControlItem15.Control = Me.txtAmtH
        Me.LayoutControlItem15.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem15.CustomizationFormText = "Τελική Αξία"
        Me.LayoutControlItem15.HighlightFocusedItem = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlItem15.Location = New System.Drawing.Point(0, 96)
        Me.LayoutControlItem15.Name = "LayoutControlItem15"
        Me.LayoutControlItem15.Size = New System.Drawing.Size(534, 24)
        Me.LayoutControlItem15.Text = "Ποσό Παραστατικού"
        Me.LayoutControlItem15.TextSize = New System.Drawing.Size(95, 13)
        '
        'LayoutControlItem13
        '
        Me.LayoutControlItem13.Control = Me.txtTotAmt
        Me.LayoutControlItem13.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem13.CustomizationFormText = "Τελική Αξία"
        Me.LayoutControlItem13.HighlightFocusedItem = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlItem13.ImageOptions.Image = CType(resources.GetObject("LayoutControlItem13.ImageOptions.Image"), System.Drawing.Image)
        Me.LayoutControlItem13.Location = New System.Drawing.Point(0, 72)
        Me.LayoutControlItem13.Name = "LayoutControlItem13"
        Me.LayoutControlItem13.Size = New System.Drawing.Size(534, 24)
        Me.LayoutControlItem13.Tag = "1"
        Me.LayoutControlItem13.Text = "Γενικό Σύνολο"
        Me.LayoutControlItem13.TextSize = New System.Drawing.Size(95, 13)
        '
        'LayoutControlItem16
        '
        Me.LayoutControlItem16.Control = Me.GridControl2
        Me.LayoutControlItem16.Location = New System.Drawing.Point(0, 207)
        Me.LayoutControlItem16.Name = "LayoutControlItem16"
        Me.LayoutControlItem16.Size = New System.Drawing.Size(534, 177)
        Me.LayoutControlItem16.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem16.TextVisible = False
        '
        'LayoutControlItem12
        '
        Me.LayoutControlItem12.Control = Me.txtInvoiceFilename
        Me.LayoutControlItem12.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem12.CustomizationFormText = "Περιοχή"
        Me.LayoutControlItem12.HighlightFocusedItem = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlItem12.Location = New System.Drawing.Point(0, 183)
        Me.LayoutControlItem12.Name = "LayoutControlItem12"
        Me.LayoutControlItem12.Size = New System.Drawing.Size(534, 24)
        Me.LayoutControlItem12.Text = "Αρχεία"
        Me.LayoutControlItem12.TextSize = New System.Drawing.Size(95, 13)
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.GridControl1
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 461)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(1104, 276)
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem3.TextVisible = False
        '
        'LayoutControlGroup2
        '
        Me.LayoutControlGroup2.AppearanceGroup.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LayoutControlGroup2.AppearanceGroup.Options.UseBorderColor = True
        Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem10, Me.LayoutControlItem9, Me.LayoutControlItem7, Me.LayoutControlItem6, Me.EmptySpaceItem2, Me.LayoutControlItem8, Me.LayoutControlItem11, Me.EmptySpaceItem4, Me.LayoutControlItem17})
        Me.LayoutControlGroup2.Location = New System.Drawing.Point(558, 0)
        Me.LayoutControlGroup2.Name = "LayoutControlGroup2"
        Me.LayoutControlGroup2.Size = New System.Drawing.Size(546, 461)
        Me.LayoutControlGroup2.Text = "Στοιχεία Πίστωσης"
        '
        'LayoutControlItem10
        '
        Me.LayoutControlItem10.Control = Me.txtCMTD
        Me.LayoutControlItem10.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem10.CustomizationFormText = "Σχόλια"
        Me.LayoutControlItem10.HighlightFocusedItem = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlItem10.Location = New System.Drawing.Point(0, 120)
        Me.LayoutControlItem10.Name = "LayoutControlItem10"
        Me.LayoutControlItem10.Size = New System.Drawing.Size(522, 264)
        Me.LayoutControlItem10.Text = "Σχόλια"
        Me.LayoutControlItem10.TextSize = New System.Drawing.Size(95, 13)
        '
        'LayoutControlItem9
        '
        Me.LayoutControlItem9.Control = Me.txtamtD
        Me.LayoutControlItem9.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem9.CustomizationFormText = "Τελική Αξία"
        Me.LayoutControlItem9.HighlightFocusedItem = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlItem9.ImageOptions.Image = Global.DreamyKitchenCRM.My.Resources.Resources.rsz_11rsz_asterisk
        Me.LayoutControlItem9.Location = New System.Drawing.Point(0, 96)
        Me.LayoutControlItem9.Name = "LayoutControlItem9"
        Me.LayoutControlItem9.Size = New System.Drawing.Size(522, 24)
        Me.LayoutControlItem9.Tag = "1"
        Me.LayoutControlItem9.Text = "Ποσό"
        Me.LayoutControlItem9.TextSize = New System.Drawing.Size(95, 13)
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.Control = Me.dtPay
        Me.LayoutControlItem7.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem7.CustomizationFormText = "Ημερ/νία Ολοκλήρωσης"
        Me.LayoutControlItem7.ImageOptions.Image = CType(resources.GetObject("LayoutControlItem7.ImageOptions.Image"), System.Drawing.Image)
        Me.LayoutControlItem7.Location = New System.Drawing.Point(0, 24)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(522, 24)
        Me.LayoutControlItem7.Tag = "1"
        Me.LayoutControlItem7.Text = "Ημερ/νία"
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(95, 13)
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.txtCode1
        Me.LayoutControlItem6.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem6.CustomizationFormText = "Κωδικός"
        Me.LayoutControlItem6.HighlightFocusedItem = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlItem6.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(166, 24)
        Me.LayoutControlItem6.Text = "Κωδικός"
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(95, 13)
        '
        'EmptySpaceItem2
        '
        Me.EmptySpaceItem2.AllowHotTrack = False
        Me.EmptySpaceItem2.Location = New System.Drawing.Point(166, 0)
        Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Size = New System.Drawing.Size(356, 24)
        Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem8
        '
        Me.LayoutControlItem8.Control = Me.cboBANK
        Me.LayoutControlItem8.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem8.CustomizationFormText = "Τράπεζα"
        Me.LayoutControlItem8.HighlightFocusedItem = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlItem8.Location = New System.Drawing.Point(0, 48)
        Me.LayoutControlItem8.Name = "LayoutControlItem8"
        Me.LayoutControlItem8.Size = New System.Drawing.Size(522, 24)
        Me.LayoutControlItem8.Tag = ""
        Me.LayoutControlItem8.Text = "Τράπεζα"
        Me.LayoutControlItem8.TextSize = New System.Drawing.Size(95, 13)
        '
        'LayoutControlItem11
        '
        Me.LayoutControlItem11.Control = Me.cmdSaveTransD
        Me.LayoutControlItem11.Location = New System.Drawing.Point(423, 384)
        Me.LayoutControlItem11.Name = "LayoutControlItem11"
        Me.LayoutControlItem11.Size = New System.Drawing.Size(99, 32)
        Me.LayoutControlItem11.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem11.TextVisible = False
        '
        'EmptySpaceItem4
        '
        Me.EmptySpaceItem4.AllowHotTrack = False
        Me.EmptySpaceItem4.Location = New System.Drawing.Point(0, 384)
        Me.EmptySpaceItem4.Name = "EmptySpaceItem4"
        Me.EmptySpaceItem4.Size = New System.Drawing.Size(423, 32)
        Me.EmptySpaceItem4.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem17
        '
        Me.LayoutControlItem17.Control = Me.chkCash
        Me.LayoutControlItem17.Location = New System.Drawing.Point(0, 72)
        Me.LayoutControlItem17.Name = "LayoutControlItem17"
        Me.LayoutControlItem17.Size = New System.Drawing.Size(522, 24)
        Me.LayoutControlItem17.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem17.TextVisible = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        Me.OpenFileDialog1.Title = "Επιλογή Αρχείων"
        '
        'cmdExit
        '
        Me.cmdExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdExit.ImageOptions.Image = Global.DreamyKitchenCRM.My.Resources.Resources.icons8_exit_24
        Me.cmdExit.Location = New System.Drawing.Point(1026, 764)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(93, 28)
        Me.cmdExit.TabIndex = 47
        Me.cmdExit.Text = "Έξοδος"
        '
        'Vw_CCT_FTableAdapter
        '
        Me.Vw_CCT_FTableAdapter.ClearBeforeFill = True
        '
        'Vw_TRANSDTableAdapter
        '
        Me.Vw_TRANSDTableAdapter.ClearBeforeFill = True
        '
        'Vw_BANKSTableAdapter
        '
        Me.Vw_BANKSTableAdapter.ClearBeforeFill = True
        '
        'frmTransactions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1129, 804)
        Me.Controls.Add(Me.cmdExit)
        Me.Controls.Add(Me.LayoutControl1)
        Me.IconOptions.Image = Global.DreamyKitchenCRM.My.Resources.Resources.favicon
        Me.Name = "frmTransactions"
        Me.Text = "Χρεωπιστώσεις"
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.chkCash.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VwCCTFBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DreamyKitchenDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DreamyKitchenDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VwTRANSDBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VwBANKSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboCUS.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtCharge.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtCharge.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtComments.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtVatAmt.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCode1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtPay.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtPay.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtamtD.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCMTD.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboBANK.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtInvoiceFilename.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTotAmt.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAmtH.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem45, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
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
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents Root As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents cboCUS As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents dtCharge As DevExpress.XtraEditors.DateEdit
    Friend WithEvents txtCode As DevExpress.XtraEditors.TextEdit
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
    Friend WithEvents txtCode1 As DevExpress.XtraEditors.TextEdit
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
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
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
    Friend WithEvents DreamyKitchenDataSetBindingSource As BindingSource
    Friend WithEvents DreamyKitchenDataSet As DreamyKitchenDataSet
    Friend WithEvents VwCCTFBindingSource As BindingSource
    Friend WithEvents colID1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colcode1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colcctID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colfiles As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colfilename As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colisinvoice As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colcomefrom As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colextension As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colmodifiedOn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colcreatedOn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRealName1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Vw_CCT_FTableAdapter As DreamyKitchenDataSetTableAdapters.vw_CCT_FTableAdapter
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
    Friend WithEvents Vw_TRANSDTableAdapter As DreamyKitchenDataSetTableAdapters.vw_TRANSDTableAdapter
    Friend WithEvents RepositoryItemLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents VwBANKSBindingSource As BindingSource
    Friend WithEvents Vw_BANKSTableAdapter As DreamyKitchenDataSetTableAdapters.vw_BANKSTableAdapter
End Class
