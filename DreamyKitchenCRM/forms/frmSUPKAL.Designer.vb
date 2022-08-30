<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmSUPKal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSUPKal))
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.cmdSave = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdExit = New DevExpress.XtraEditors.SimpleButton()
        Me.dtissueDate = New DevExpress.XtraEditors.DateEdit()
        Me.grdMain = New DevExpress.XtraGrid.GridControl()
        Me.VwBUYBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DreamyKitchenDataSet = New DreamyKitchenCRM.DreamyKitchenDataSet()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colcode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coldtBuy = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colinvoiceNumber = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsupID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colcusID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coltranshID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colnetAmount = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colvatAmount = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colmodifiedBy = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colmodifiedOn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colcreatedOn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colcreatedBy = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSupFullName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCusFullname = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTranshDescription = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRealName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBuyCName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colcmt = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colbuyCID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colkitchen = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colcloset = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colgeneral = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colmaterials = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colbathroomFurn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDevicesBuy = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPayName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colpayID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colpaid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colkitchenV = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colclosetV = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colgeneralV = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colmaterialsV = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colbathroomFurnV = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDevicesBuyV = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colisCredit = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cboSUP = New DevExpress.XtraEditors.LookUpEdit()
        Me.VwSUPBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.dtpayDate = New DevExpress.XtraEditors.DateEdit()
        Me.txtCode = New DevExpress.XtraEditors.TextEdit()
        Me.txtcheckNum = New DevExpress.XtraEditors.TextEdit()
        Me.txtAmt = New DevExpress.XtraEditors.TextEdit()
        Me.cboPAY = New DevExpress.XtraEditors.LookUpEdit()
        Me.VwPAYBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.txtBal = New DevExpress.XtraEditors.TextEdit()
        Me.cboBANK = New DevExpress.XtraEditors.LookUpEdit()
        Me.VwBANKSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.txtDepositNum = New DevExpress.XtraEditors.TextEdit()
        Me.txtComments = New DevExpress.XtraEditors.MemoEdit()
        Me.dtendDate = New DevExpress.XtraEditors.DateEdit()
        Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem12 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem18 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem14 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem10 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem11 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem13 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.Vw_SUPTableAdapter = New DreamyKitchenCRM.DreamyKitchenDataSetTableAdapters.vw_SUPTableAdapter()
        Me.Vw_BUYTableAdapter = New DreamyKitchenCRM.DreamyKitchenDataSetTableAdapters.vw_BUYTableAdapter()
        Me.Vw_PAYTableAdapter = New DreamyKitchenCRM.DreamyKitchenDataSetTableAdapters.vw_PAYTableAdapter()
        Me.Vw_BANKSTableAdapter = New DreamyKitchenCRM.DreamyKitchenDataSetTableAdapters.vw_BANKSTableAdapter()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.dtissueDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtissueDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdMain, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VwBUYBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DreamyKitchenDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboSUP.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VwSUPBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpayDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpayDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtcheckNum.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAmt.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboPAY.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VwPAYBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtBal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboBANK.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VwBANKSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDepositNum.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtComments.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtendDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtendDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem18, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LayoutControl1.Controls.Add(Me.cmdSave)
        Me.LayoutControl1.Controls.Add(Me.cmdExit)
        Me.LayoutControl1.Controls.Add(Me.dtissueDate)
        Me.LayoutControl1.Controls.Add(Me.grdMain)
        Me.LayoutControl1.Controls.Add(Me.cboSUP)
        Me.LayoutControl1.Controls.Add(Me.dtpayDate)
        Me.LayoutControl1.Controls.Add(Me.txtCode)
        Me.LayoutControl1.Controls.Add(Me.txtcheckNum)
        Me.LayoutControl1.Controls.Add(Me.txtAmt)
        Me.LayoutControl1.Controls.Add(Me.cboPAY)
        Me.LayoutControl1.Controls.Add(Me.txtBal)
        Me.LayoutControl1.Controls.Add(Me.cboBANK)
        Me.LayoutControl1.Controls.Add(Me.txtDepositNum)
        Me.LayoutControl1.Controls.Add(Me.txtComments)
        Me.LayoutControl1.Controls.Add(Me.dtendDate)
        Me.LayoutControl1.Location = New System.Drawing.Point(-3, -4)
        Me.LayoutControl1.Margin = New System.Windows.Forms.Padding(5)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(503, 94, 650, 400)
        Me.LayoutControl1.Root = Me.Root
        Me.LayoutControl1.Size = New System.Drawing.Size(1746, 1297)
        Me.LayoutControl1.TabIndex = 6
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'cmdSave
        '
        Me.cmdSave.ImageOptions.Image = Global.DreamyKitchenCRM.My.Resources.Resources.icons8_save_close_24
        Me.cmdSave.Location = New System.Drawing.Point(1339, 1246)
        Me.cmdSave.Margin = New System.Windows.Forms.Padding(5)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(212, 39)
        Me.cmdSave.StyleController = Me.LayoutControl1
        Me.cmdSave.TabIndex = 34
        Me.cmdSave.Text = "Αποθήκευση"
        '
        'cmdExit
        '
        Me.cmdExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdExit.ImageOptions.Image = Global.DreamyKitchenCRM.My.Resources.Resources.icons8_exit_24
        Me.cmdExit.Location = New System.Drawing.Point(1555, 1246)
        Me.cmdExit.Margin = New System.Windows.Forms.Padding(5)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(179, 39)
        Me.cmdExit.StyleController = Me.LayoutControl1
        Me.cmdExit.TabIndex = 33
        Me.cmdExit.Text = "Έξοδος"
        '
        'dtissueDate
        '
        Me.dtissueDate.EditValue = Nothing
        Me.dtissueDate.Location = New System.Drawing.Point(203, 350)
        Me.dtissueDate.Margin = New System.Windows.Forms.Padding(5)
        Me.dtissueDate.Name = "dtissueDate"
        Me.dtissueDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtissueDate.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtissueDate.Properties.ReadOnly = True
        Me.dtissueDate.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.dtissueDate.Size = New System.Drawing.Size(668, 38)
        Me.dtissueDate.StyleController = Me.LayoutControl1
        Me.dtissueDate.TabIndex = 44
        Me.dtissueDate.Tag = "issueDate,0,1,2"
        '
        'grdMain
        '
        Me.grdMain.Cursor = System.Windows.Forms.Cursors.Default
        Me.grdMain.DataSource = Me.VwBUYBindingSource
        Me.grdMain.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(5)
        Me.grdMain.Location = New System.Drawing.Point(12, 516)
        Me.grdMain.MainView = Me.GridView1
        Me.grdMain.Margin = New System.Windows.Forms.Padding(5)
        Me.grdMain.Name = "grdMain"
        Me.grdMain.Size = New System.Drawing.Size(1722, 726)
        Me.grdMain.TabIndex = 43
        Me.grdMain.UseEmbeddedNavigator = True
        Me.grdMain.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        Me.grdMain.Visible = False
        '
        'VwBUYBindingSource
        '
        Me.VwBUYBindingSource.DataMember = "vw_BUY"
        Me.VwBUYBindingSource.DataSource = Me.DreamyKitchenDataSet
        '
        'DreamyKitchenDataSet
        '
        Me.DreamyKitchenDataSet.DataSetName = "DreamyKitchenDataSet"
        Me.DreamyKitchenDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colID, Me.colcode, Me.coldtBuy, Me.colinvoiceNumber, Me.colsupID, Me.colcusID, Me.coltranshID, Me.colnetAmount, Me.colvatAmount, Me.colmodifiedBy, Me.colmodifiedOn, Me.colcreatedOn, Me.colcreatedBy, Me.colSupFullName, Me.colCusFullname, Me.colTranshDescription, Me.colRealName, Me.colBuyCName, Me.colcmt, Me.colbuyCID, Me.colkitchen, Me.colcloset, Me.colgeneral, Me.colmaterials, Me.colbathroomFurn, Me.colDevicesBuy, Me.colPayName, Me.colpayID, Me.colpaid, Me.colkitchenV, Me.colclosetV, Me.colgeneralV, Me.colmaterialsV, Me.colbathroomFurnV, Me.colDevicesBuyV, Me.colisCredit})
        Me.GridView1.DetailHeight = 619
        Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus
        Me.GridView1.GridControl = Me.grdMain
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.AutoExpandAllGroups = True
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsBehavior.ReadOnly = True
        Me.GridView1.OptionsLayout.Columns.StoreAppearance = True
        Me.GridView1.OptionsLayout.StoreAllOptions = True
        Me.GridView1.OptionsLayout.StoreAppearance = True
        Me.GridView1.OptionsLayout.StoreFormatRules = True
        Me.GridView1.OptionsMenu.ShowConditionalFormattingItem = True
        Me.GridView1.OptionsMenu.ShowFooterItem = True
        Me.GridView1.OptionsMenu.ShowGroupSummaryEditorItem = True
        Me.GridView1.OptionsPrint.PrintPreview = True
        Me.GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.EnableAppearanceEvenRow = True
        Me.GridView1.OptionsView.ShowFooter = True
        '
        'colID
        '
        Me.colID.FieldName = "ID"
        Me.colID.MinWidth = 35
        Me.colID.Name = "colID"
        Me.colID.Visible = True
        Me.colID.VisibleIndex = 0
        Me.colID.Width = 131
        '
        'colcode
        '
        Me.colcode.FieldName = "code"
        Me.colcode.MinWidth = 35
        Me.colcode.Name = "colcode"
        Me.colcode.Visible = True
        Me.colcode.VisibleIndex = 1
        Me.colcode.Width = 131
        '
        'coldtBuy
        '
        Me.coldtBuy.FieldName = "dtBuy"
        Me.coldtBuy.MinWidth = 35
        Me.coldtBuy.Name = "coldtBuy"
        Me.coldtBuy.Visible = True
        Me.coldtBuy.VisibleIndex = 2
        Me.coldtBuy.Width = 131
        '
        'colinvoiceNumber
        '
        Me.colinvoiceNumber.FieldName = "invoiceNumber"
        Me.colinvoiceNumber.MinWidth = 35
        Me.colinvoiceNumber.Name = "colinvoiceNumber"
        Me.colinvoiceNumber.Visible = True
        Me.colinvoiceNumber.VisibleIndex = 3
        Me.colinvoiceNumber.Width = 131
        '
        'colsupID
        '
        Me.colsupID.FieldName = "supID"
        Me.colsupID.MinWidth = 35
        Me.colsupID.Name = "colsupID"
        Me.colsupID.Visible = True
        Me.colsupID.VisibleIndex = 4
        Me.colsupID.Width = 131
        '
        'colcusID
        '
        Me.colcusID.FieldName = "cusID"
        Me.colcusID.MinWidth = 35
        Me.colcusID.Name = "colcusID"
        Me.colcusID.Visible = True
        Me.colcusID.VisibleIndex = 5
        Me.colcusID.Width = 131
        '
        'coltranshID
        '
        Me.coltranshID.FieldName = "transhID"
        Me.coltranshID.MinWidth = 35
        Me.coltranshID.Name = "coltranshID"
        Me.coltranshID.Visible = True
        Me.coltranshID.VisibleIndex = 6
        Me.coltranshID.Width = 131
        '
        'colnetAmount
        '
        Me.colnetAmount.FieldName = "netAmount"
        Me.colnetAmount.MinWidth = 35
        Me.colnetAmount.Name = "colnetAmount"
        Me.colnetAmount.Visible = True
        Me.colnetAmount.VisibleIndex = 7
        Me.colnetAmount.Width = 131
        '
        'colvatAmount
        '
        Me.colvatAmount.FieldName = "vatAmount"
        Me.colvatAmount.MinWidth = 35
        Me.colvatAmount.Name = "colvatAmount"
        Me.colvatAmount.Visible = True
        Me.colvatAmount.VisibleIndex = 8
        Me.colvatAmount.Width = 131
        '
        'colmodifiedBy
        '
        Me.colmodifiedBy.FieldName = "modifiedBy"
        Me.colmodifiedBy.MinWidth = 35
        Me.colmodifiedBy.Name = "colmodifiedBy"
        Me.colmodifiedBy.Visible = True
        Me.colmodifiedBy.VisibleIndex = 9
        Me.colmodifiedBy.Width = 131
        '
        'colmodifiedOn
        '
        Me.colmodifiedOn.FieldName = "modifiedOn"
        Me.colmodifiedOn.MinWidth = 35
        Me.colmodifiedOn.Name = "colmodifiedOn"
        Me.colmodifiedOn.Visible = True
        Me.colmodifiedOn.VisibleIndex = 10
        Me.colmodifiedOn.Width = 131
        '
        'colcreatedOn
        '
        Me.colcreatedOn.FieldName = "createdOn"
        Me.colcreatedOn.MinWidth = 35
        Me.colcreatedOn.Name = "colcreatedOn"
        Me.colcreatedOn.Visible = True
        Me.colcreatedOn.VisibleIndex = 11
        Me.colcreatedOn.Width = 131
        '
        'colcreatedBy
        '
        Me.colcreatedBy.FieldName = "createdBy"
        Me.colcreatedBy.MinWidth = 35
        Me.colcreatedBy.Name = "colcreatedBy"
        Me.colcreatedBy.Visible = True
        Me.colcreatedBy.VisibleIndex = 12
        Me.colcreatedBy.Width = 131
        '
        'colSupFullName
        '
        Me.colSupFullName.FieldName = "SupFullName"
        Me.colSupFullName.MinWidth = 35
        Me.colSupFullName.Name = "colSupFullName"
        Me.colSupFullName.Visible = True
        Me.colSupFullName.VisibleIndex = 13
        Me.colSupFullName.Width = 131
        '
        'colCusFullname
        '
        Me.colCusFullname.FieldName = "CusFullname"
        Me.colCusFullname.MinWidth = 35
        Me.colCusFullname.Name = "colCusFullname"
        Me.colCusFullname.Visible = True
        Me.colCusFullname.VisibleIndex = 14
        Me.colCusFullname.Width = 131
        '
        'colTranshDescription
        '
        Me.colTranshDescription.FieldName = "TranshDescription"
        Me.colTranshDescription.MinWidth = 35
        Me.colTranshDescription.Name = "colTranshDescription"
        Me.colTranshDescription.Visible = True
        Me.colTranshDescription.VisibleIndex = 15
        Me.colTranshDescription.Width = 131
        '
        'colRealName
        '
        Me.colRealName.FieldName = "RealName"
        Me.colRealName.MinWidth = 35
        Me.colRealName.Name = "colRealName"
        Me.colRealName.Visible = True
        Me.colRealName.VisibleIndex = 16
        Me.colRealName.Width = 131
        '
        'colBuyCName
        '
        Me.colBuyCName.FieldName = "BuyCName"
        Me.colBuyCName.MinWidth = 35
        Me.colBuyCName.Name = "colBuyCName"
        Me.colBuyCName.Visible = True
        Me.colBuyCName.VisibleIndex = 17
        Me.colBuyCName.Width = 131
        '
        'colcmt
        '
        Me.colcmt.FieldName = "cmt"
        Me.colcmt.MinWidth = 35
        Me.colcmt.Name = "colcmt"
        Me.colcmt.Visible = True
        Me.colcmt.VisibleIndex = 18
        Me.colcmt.Width = 131
        '
        'colbuyCID
        '
        Me.colbuyCID.FieldName = "buyCID"
        Me.colbuyCID.MinWidth = 35
        Me.colbuyCID.Name = "colbuyCID"
        Me.colbuyCID.Visible = True
        Me.colbuyCID.VisibleIndex = 19
        Me.colbuyCID.Width = 131
        '
        'colkitchen
        '
        Me.colkitchen.FieldName = "kitchen"
        Me.colkitchen.MinWidth = 35
        Me.colkitchen.Name = "colkitchen"
        Me.colkitchen.Visible = True
        Me.colkitchen.VisibleIndex = 20
        Me.colkitchen.Width = 131
        '
        'colcloset
        '
        Me.colcloset.FieldName = "closet"
        Me.colcloset.MinWidth = 35
        Me.colcloset.Name = "colcloset"
        Me.colcloset.Visible = True
        Me.colcloset.VisibleIndex = 21
        Me.colcloset.Width = 131
        '
        'colgeneral
        '
        Me.colgeneral.FieldName = "general"
        Me.colgeneral.MinWidth = 35
        Me.colgeneral.Name = "colgeneral"
        Me.colgeneral.Visible = True
        Me.colgeneral.VisibleIndex = 22
        Me.colgeneral.Width = 131
        '
        'colmaterials
        '
        Me.colmaterials.FieldName = "materials"
        Me.colmaterials.MinWidth = 35
        Me.colmaterials.Name = "colmaterials"
        Me.colmaterials.Visible = True
        Me.colmaterials.VisibleIndex = 23
        Me.colmaterials.Width = 131
        '
        'colbathroomFurn
        '
        Me.colbathroomFurn.FieldName = "bathroomFurn"
        Me.colbathroomFurn.MinWidth = 35
        Me.colbathroomFurn.Name = "colbathroomFurn"
        Me.colbathroomFurn.Visible = True
        Me.colbathroomFurn.VisibleIndex = 24
        Me.colbathroomFurn.Width = 131
        '
        'colDevicesBuy
        '
        Me.colDevicesBuy.FieldName = "DevicesBuy"
        Me.colDevicesBuy.MinWidth = 35
        Me.colDevicesBuy.Name = "colDevicesBuy"
        Me.colDevicesBuy.Visible = True
        Me.colDevicesBuy.VisibleIndex = 25
        Me.colDevicesBuy.Width = 131
        '
        'colPayName
        '
        Me.colPayName.FieldName = "PayName"
        Me.colPayName.MinWidth = 35
        Me.colPayName.Name = "colPayName"
        Me.colPayName.Visible = True
        Me.colPayName.VisibleIndex = 26
        Me.colPayName.Width = 131
        '
        'colpayID
        '
        Me.colpayID.FieldName = "payID"
        Me.colpayID.MinWidth = 35
        Me.colpayID.Name = "colpayID"
        Me.colpayID.Visible = True
        Me.colpayID.VisibleIndex = 27
        Me.colpayID.Width = 131
        '
        'colpaid
        '
        Me.colpaid.FieldName = "paid"
        Me.colpaid.MinWidth = 35
        Me.colpaid.Name = "colpaid"
        Me.colpaid.Visible = True
        Me.colpaid.VisibleIndex = 28
        Me.colpaid.Width = 131
        '
        'colkitchenV
        '
        Me.colkitchenV.FieldName = "kitchenV"
        Me.colkitchenV.MinWidth = 35
        Me.colkitchenV.Name = "colkitchenV"
        Me.colkitchenV.Visible = True
        Me.colkitchenV.VisibleIndex = 29
        Me.colkitchenV.Width = 131
        '
        'colclosetV
        '
        Me.colclosetV.FieldName = "closetV"
        Me.colclosetV.MinWidth = 35
        Me.colclosetV.Name = "colclosetV"
        Me.colclosetV.Visible = True
        Me.colclosetV.VisibleIndex = 30
        Me.colclosetV.Width = 131
        '
        'colgeneralV
        '
        Me.colgeneralV.FieldName = "generalV"
        Me.colgeneralV.MinWidth = 35
        Me.colgeneralV.Name = "colgeneralV"
        Me.colgeneralV.Visible = True
        Me.colgeneralV.VisibleIndex = 31
        Me.colgeneralV.Width = 131
        '
        'colmaterialsV
        '
        Me.colmaterialsV.FieldName = "materialsV"
        Me.colmaterialsV.MinWidth = 35
        Me.colmaterialsV.Name = "colmaterialsV"
        Me.colmaterialsV.Visible = True
        Me.colmaterialsV.VisibleIndex = 32
        Me.colmaterialsV.Width = 131
        '
        'colbathroomFurnV
        '
        Me.colbathroomFurnV.FieldName = "bathroomFurnV"
        Me.colbathroomFurnV.MinWidth = 35
        Me.colbathroomFurnV.Name = "colbathroomFurnV"
        Me.colbathroomFurnV.Visible = True
        Me.colbathroomFurnV.VisibleIndex = 33
        Me.colbathroomFurnV.Width = 131
        '
        'colDevicesBuyV
        '
        Me.colDevicesBuyV.FieldName = "DevicesBuyV"
        Me.colDevicesBuyV.MinWidth = 35
        Me.colDevicesBuyV.Name = "colDevicesBuyV"
        Me.colDevicesBuyV.Visible = True
        Me.colDevicesBuyV.VisibleIndex = 34
        Me.colDevicesBuyV.Width = 131
        '
        'colisCredit
        '
        Me.colisCredit.FieldName = "isCredit"
        Me.colisCredit.MinWidth = 35
        Me.colisCredit.Name = "colisCredit"
        Me.colisCredit.Visible = True
        Me.colisCredit.VisibleIndex = 35
        Me.colisCredit.Width = 131
        '
        'cboSUP
        '
        Me.cboSUP.Location = New System.Drawing.Point(203, 54)
        Me.cboSUP.Margin = New System.Windows.Forms.Padding(5)
        Me.cboSUP.Name = "cboSUP"
        Me.cboSUP.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.cboSUP.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Search), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Clear)})
        Me.cboSUP.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 35, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("code", "code", 55, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Fullname", "Fullname", 91, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ttl", "ttl", 31, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("bal", "bal", 40, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default])})
        Me.cboSUP.Properties.DataSource = Me.VwSUPBindingSource
        Me.cboSUP.Properties.DisplayMember = "Fullname"
        Me.cboSUP.Properties.NullText = ""
        Me.cboSUP.Properties.PopupSizeable = False
        Me.cboSUP.Properties.ValueMember = "ID"
        Me.cboSUP.Size = New System.Drawing.Size(1023, 38)
        Me.cboSUP.StyleController = Me.LayoutControl1
        Me.cboSUP.TabIndex = 5
        Me.cboSUP.Tag = "supID,0,1,2"
        '
        'VwSUPBindingSource
        '
        Me.VwSUPBindingSource.DataMember = "vw_SUP"
        Me.VwSUPBindingSource.DataSource = Me.DreamyKitchenDataSet
        '
        'dtpayDate
        '
        Me.dtpayDate.EditValue = Nothing
        Me.dtpayDate.Location = New System.Drawing.Point(203, 98)
        Me.dtpayDate.Margin = New System.Windows.Forms.Padding(5)
        Me.dtpayDate.Name = "dtpayDate"
        Me.dtpayDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtpayDate.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtpayDate.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.dtpayDate.Size = New System.Drawing.Size(1531, 38)
        Me.dtpayDate.StyleController = Me.LayoutControl1
        Me.dtpayDate.TabIndex = 32
        Me.dtpayDate.Tag = "payDate,0,1,2"
        '
        'txtCode
        '
        Me.txtCode.Location = New System.Drawing.Point(203, 12)
        Me.txtCode.Margin = New System.Windows.Forms.Padding(5)
        Me.txtCode.Name = "txtCode"
        Me.txtCode.Properties.Appearance.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.txtCode.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtCode.Properties.Appearance.Options.UseBackColor = True
        Me.txtCode.Properties.Appearance.Options.UseFont = True
        Me.txtCode.Properties.ReadOnly = True
        Me.txtCode.Size = New System.Drawing.Size(196, 38)
        Me.txtCode.StyleController = Me.LayoutControl1
        Me.txtCode.TabIndex = 4
        Me.txtCode.Tag = "code,0"
        '
        'txtcheckNum
        '
        Me.txtcheckNum.Location = New System.Drawing.Point(203, 308)
        Me.txtcheckNum.Margin = New System.Windows.Forms.Padding(5)
        Me.txtcheckNum.Name = "txtcheckNum"
        Me.txtcheckNum.Properties.ReadOnly = True
        Me.txtcheckNum.Size = New System.Drawing.Size(1531, 38)
        Me.txtcheckNum.StyleController = Me.LayoutControl1
        Me.txtcheckNum.TabIndex = 22
        Me.txtcheckNum.Tag = "checkNum,0,1,2"
        '
        'txtAmt
        '
        Me.txtAmt.EditValue = "0,00 €"
        Me.txtAmt.Location = New System.Drawing.Point(203, 182)
        Me.txtAmt.Margin = New System.Windows.Forms.Padding(5)
        Me.txtAmt.Name = "txtAmt"
        Me.txtAmt.Properties.DisplayFormat.FormatString = "c"
        Me.txtAmt.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtAmt.Properties.EditFormat.FormatString = "n2"
        Me.txtAmt.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtAmt.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtAmt.Properties.MaskSettings.Set("MaskManagerType", GetType(DevExpress.Data.Mask.NumericMaskManager))
        Me.txtAmt.Properties.MaskSettings.Set("mask", "c2")
        Me.txtAmt.Properties.Tag = "BenchExtraPrice"
        Me.txtAmt.Properties.UseReadOnlyAppearance = False
        Me.txtAmt.Size = New System.Drawing.Size(1531, 38)
        Me.txtAmt.StyleController = Me.LayoutControl1
        Me.txtAmt.TabIndex = 42
        Me.txtAmt.Tag = "amt,0,1,2"
        Me.txtAmt.Visible = False
        '
        'cboPAY
        '
        Me.cboPAY.Location = New System.Drawing.Point(203, 140)
        Me.cboPAY.Margin = New System.Windows.Forms.Padding(5)
        Me.cboPAY.Name = "cboPAY"
        Me.cboPAY.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.cboPAY.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Search), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Clear)})
        Me.cboPAY.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 35, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("name", "name", 62, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default])})
        Me.cboPAY.Properties.DataSource = Me.VwPAYBindingSource
        Me.cboPAY.Properties.DisplayMember = "name"
        Me.cboPAY.Properties.NullText = ""
        Me.cboPAY.Properties.PopupSizeable = False
        Me.cboPAY.Properties.ValueMember = "ID"
        Me.cboPAY.Size = New System.Drawing.Size(1531, 38)
        Me.cboPAY.StyleController = Me.LayoutControl1
        Me.cboPAY.TabIndex = 6
        Me.cboPAY.Tag = "payID,0,1,2"
        '
        'VwPAYBindingSource
        '
        Me.VwPAYBindingSource.DataMember = "vw_PAY"
        Me.VwPAYBindingSource.DataSource = Me.DreamyKitchenDataSet
        '
        'txtBal
        '
        Me.txtBal.EditValue = "0,00 €"
        Me.txtBal.Location = New System.Drawing.Point(1421, 54)
        Me.txtBal.Margin = New System.Windows.Forms.Padding(5)
        Me.txtBal.Name = "txtBal"
        Me.txtBal.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txtBal.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtBal.Properties.Appearance.Options.UseFont = True
        Me.txtBal.Properties.Appearance.Options.UseForeColor = True
        Me.txtBal.Properties.DisplayFormat.FormatString = "c"
        Me.txtBal.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtBal.Properties.EditFormat.FormatString = "n2"
        Me.txtBal.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtBal.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtBal.Properties.MaskSettings.Set("MaskManagerType", GetType(DevExpress.Data.Mask.NumericMaskManager))
        Me.txtBal.Properties.MaskSettings.Set("mask", "c2")
        Me.txtBal.Properties.ReadOnly = True
        Me.txtBal.Properties.Tag = "BenchExtraPrice"
        Me.txtBal.Size = New System.Drawing.Size(313, 40)
        Me.txtBal.StyleController = Me.LayoutControl1
        Me.txtBal.TabIndex = 42
        Me.txtBal.Tag = ""
        Me.txtBal.Visible = False
        '
        'cboBANK
        '
        Me.cboBANK.Location = New System.Drawing.Point(203, 224)
        Me.cboBANK.Margin = New System.Windows.Forms.Padding(5)
        Me.cboBANK.Name = "cboBANK"
        Me.cboBANK.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.cboBANK.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Search), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Clear)})
        Me.cboBANK.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("RealName", "Real Name", 106, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 35, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("code", "code", 55, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("name", "Τράπεζα", 62, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("modifiedBy", "modified By", 113, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("modifiedOn", "modified On", 117, DevExpress.Utils.FormatType.DateTime, "d/M/yyyy", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("createdOn", "created On", 108, DevExpress.Utils.FormatType.DateTime, "d/M/yyyy", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("createdBy", "created By", 104, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default])})
        Me.cboBANK.Properties.DataSource = Me.VwBANKSBindingSource
        Me.cboBANK.Properties.DisplayMember = "name"
        Me.cboBANK.Properties.NullText = ""
        Me.cboBANK.Properties.PopupSizeable = False
        Me.cboBANK.Properties.ReadOnly = True
        Me.cboBANK.Properties.ValueMember = "ID"
        Me.cboBANK.Size = New System.Drawing.Size(1531, 38)
        Me.cboBANK.StyleController = Me.LayoutControl1
        Me.cboBANK.TabIndex = 6
        Me.cboBANK.Tag = "bankID,0,1,2"
        '
        'VwBANKSBindingSource
        '
        Me.VwBANKSBindingSource.DataMember = "vw_BANKS"
        Me.VwBANKSBindingSource.DataSource = Me.DreamyKitchenDataSet
        '
        'txtDepositNum
        '
        Me.txtDepositNum.Location = New System.Drawing.Point(203, 266)
        Me.txtDepositNum.Margin = New System.Windows.Forms.Padding(5)
        Me.txtDepositNum.Name = "txtDepositNum"
        Me.txtDepositNum.Properties.ReadOnly = True
        Me.txtDepositNum.Size = New System.Drawing.Size(1531, 38)
        Me.txtDepositNum.StyleController = Me.LayoutControl1
        Me.txtDepositNum.TabIndex = 22
        Me.txtDepositNum.Tag = "depositNum,0,1,2"
        '
        'txtComments
        '
        Me.txtComments.Location = New System.Drawing.Point(203, 392)
        Me.txtComments.Margin = New System.Windows.Forms.Padding(5)
        Me.txtComments.Name = "txtComments"
        Me.txtComments.Size = New System.Drawing.Size(1531, 120)
        Me.txtComments.StyleController = Me.LayoutControl1
        Me.txtComments.TabIndex = 17
        Me.txtComments.Tag = "cmt,0,1,2"
        '
        'dtendDate
        '
        Me.dtendDate.EditValue = Nothing
        Me.dtendDate.Location = New System.Drawing.Point(1066, 350)
        Me.dtendDate.Margin = New System.Windows.Forms.Padding(5)
        Me.dtendDate.Name = "dtendDate"
        Me.dtendDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtendDate.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtendDate.Properties.ReadOnly = True
        Me.dtendDate.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.dtendDate.Size = New System.Drawing.Size(668, 38)
        Me.dtendDate.StyleController = Me.LayoutControl1
        Me.dtendDate.TabIndex = 44
        Me.dtendDate.Tag = "endDate,0,1,2"
        '
        'Root
        '
        Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.Root.GroupBordersVisible = False
        Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem9, Me.LayoutControlItem4, Me.EmptySpaceItem1, Me.LayoutControlItem12, Me.LayoutControlItem6, Me.LayoutControlItem7, Me.LayoutControlItem5, Me.LayoutControlItem18, Me.LayoutControlItem14, Me.LayoutControlItem2, Me.LayoutControlItem10, Me.LayoutControlItem11, Me.LayoutControlItem8, Me.LayoutControlItem1, Me.LayoutControlItem3, Me.EmptySpaceItem2, Me.LayoutControlItem13})
        Me.Root.Name = "Root"
        Me.Root.Size = New System.Drawing.Size(1746, 1297)
        Me.Root.TextVisible = False
        '
        'LayoutControlItem9
        '
        Me.LayoutControlItem9.Control = Me.cboSUP
        Me.LayoutControlItem9.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem9.CustomizationFormText = "Νομός"
        Me.LayoutControlItem9.HighlightFocusedItem = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlItem9.ImageOptions.Image = CType(resources.GetObject("LayoutControlItem9.ImageOptions.Image"), System.Drawing.Image)
        Me.LayoutControlItem9.Location = New System.Drawing.Point(0, 42)
        Me.LayoutControlItem9.Name = "LayoutControlItem9"
        Me.LayoutControlItem9.Size = New System.Drawing.Size(1218, 44)
        Me.LayoutControlItem9.Tag = "1"
        Me.LayoutControlItem9.Text = "Προμηθευτής"
        Me.LayoutControlItem9.TextSize = New System.Drawing.Size(179, 23)
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.txtCode
        Me.LayoutControlItem4.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem4.CustomizationFormText = "Κωδικός"
        Me.LayoutControlItem4.HighlightFocusedItem = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(391, 42)
        Me.LayoutControlItem4.Text = "Κωδικός"
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(179, 23)
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(391, 0)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(1335, 42)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem12
        '
        Me.LayoutControlItem12.Control = Me.txtcheckNum
        Me.LayoutControlItem12.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem12.CustomizationFormText = "Τηλέφωνο"
        Me.LayoutControlItem12.HighlightFocusedItem = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlItem12.Location = New System.Drawing.Point(0, 296)
        Me.LayoutControlItem12.Name = "LayoutControlItem12"
        Me.LayoutControlItem12.Size = New System.Drawing.Size(1726, 42)
        Me.LayoutControlItem12.Tag = ""
        Me.LayoutControlItem12.Text = "Αρ. Επιταγής"
        Me.LayoutControlItem12.TextSize = New System.Drawing.Size(179, 23)
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.grdMain
        Me.LayoutControlItem6.Location = New System.Drawing.Point(0, 504)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(1726, 730)
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem6.TextVisible = False
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.Control = Me.txtBal
        Me.LayoutControlItem7.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem7.CustomizationFormText = "Τελική Αξία"
        Me.LayoutControlItem7.HighlightFocusedItem = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlItem7.Location = New System.Drawing.Point(1218, 42)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(508, 44)
        Me.LayoutControlItem7.Text = "Υπόλοιπο Προμ."
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(179, 23)
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.cboBANK
        Me.LayoutControlItem5.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem5.CustomizationFormText = "Περιοχή"
        Me.LayoutControlItem5.HighlightFocusedItem = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 212)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(1726, 42)
        Me.LayoutControlItem5.Text = "Τράπεζα"
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(179, 23)
        '
        'LayoutControlItem18
        '
        Me.LayoutControlItem18.Control = Me.txtAmt
        Me.LayoutControlItem18.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem18.CustomizationFormText = "Τελική Αξία"
        Me.LayoutControlItem18.HighlightFocusedItem = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlItem18.ImageOptions.Image = Global.DreamyKitchenCRM.My.Resources.Resources.rsz_11rsz_asterisk
        Me.LayoutControlItem18.Location = New System.Drawing.Point(0, 170)
        Me.LayoutControlItem18.Name = "LayoutControlItem18"
        Me.LayoutControlItem18.Size = New System.Drawing.Size(1726, 42)
        Me.LayoutControlItem18.Tag = "1"
        Me.LayoutControlItem18.Text = "Ποσό Κάλυψης"
        Me.LayoutControlItem18.TextSize = New System.Drawing.Size(179, 23)
        '
        'LayoutControlItem14
        '
        Me.LayoutControlItem14.Control = Me.txtComments
        Me.LayoutControlItem14.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem14.CustomizationFormText = "Σχόλια"
        Me.LayoutControlItem14.HighlightFocusedItem = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlItem14.Location = New System.Drawing.Point(0, 380)
        Me.LayoutControlItem14.Name = "LayoutControlItem14"
        Me.LayoutControlItem14.Size = New System.Drawing.Size(1726, 124)
        Me.LayoutControlItem14.Text = "Σχόλια"
        Me.LayoutControlItem14.TextSize = New System.Drawing.Size(179, 23)
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.dtpayDate
        Me.LayoutControlItem2.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem2.CustomizationFormText = "Ημερ/νία Ολοκλήρωσης"
        Me.LayoutControlItem2.ImageOptions.Image = CType(resources.GetObject("LayoutControlItem2.ImageOptions.Image"), System.Drawing.Image)
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 86)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(1726, 42)
        Me.LayoutControlItem2.Tag = "1"
        Me.LayoutControlItem2.Text = "Ημερ/νία Πληρωμής"
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(179, 23)
        '
        'LayoutControlItem10
        '
        Me.LayoutControlItem10.Control = Me.cboPAY
        Me.LayoutControlItem10.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem10.CustomizationFormText = "Περιοχή"
        Me.LayoutControlItem10.HighlightFocusedItem = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlItem10.ImageOptions.Image = CType(resources.GetObject("LayoutControlItem10.ImageOptions.Image"), System.Drawing.Image)
        Me.LayoutControlItem10.Location = New System.Drawing.Point(0, 128)
        Me.LayoutControlItem10.Name = "LayoutControlItem10"
        Me.LayoutControlItem10.Size = New System.Drawing.Size(1726, 42)
        Me.LayoutControlItem10.Tag = "1"
        Me.LayoutControlItem10.Text = "Τρόπος Πληρωμής"
        Me.LayoutControlItem10.TextSize = New System.Drawing.Size(179, 23)
        '
        'LayoutControlItem11
        '
        Me.LayoutControlItem11.Control = Me.txtDepositNum
        Me.LayoutControlItem11.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem11.CustomizationFormText = "Τηλέφωνο"
        Me.LayoutControlItem11.HighlightFocusedItem = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlItem11.Location = New System.Drawing.Point(0, 254)
        Me.LayoutControlItem11.Name = "LayoutControlItem11"
        Me.LayoutControlItem11.Size = New System.Drawing.Size(1726, 42)
        Me.LayoutControlItem11.Text = "Αρ. Καταθετηρίου"
        Me.LayoutControlItem11.TextSize = New System.Drawing.Size(179, 23)
        '
        'LayoutControlItem8
        '
        Me.LayoutControlItem8.Control = Me.dtissueDate
        Me.LayoutControlItem8.Location = New System.Drawing.Point(0, 338)
        Me.LayoutControlItem8.Name = "LayoutControlItem8"
        Me.LayoutControlItem8.Size = New System.Drawing.Size(863, 42)
        Me.LayoutControlItem8.Text = "Ημερ/νία Έκδοσης"
        Me.LayoutControlItem8.TextSize = New System.Drawing.Size(179, 23)
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.cmdSave
        Me.LayoutControlItem1.Location = New System.Drawing.Point(1327, 1234)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(216, 43)
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.cmdExit
        Me.LayoutControlItem3.Location = New System.Drawing.Point(1543, 1234)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(183, 43)
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem3.TextVisible = False
        '
        'EmptySpaceItem2
        '
        Me.EmptySpaceItem2.AllowHotTrack = False
        Me.EmptySpaceItem2.Location = New System.Drawing.Point(0, 1234)
        Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Size = New System.Drawing.Size(1327, 43)
        Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem13
        '
        Me.LayoutControlItem13.Control = Me.dtendDate
        Me.LayoutControlItem13.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem13.CustomizationFormText = "Ημερ/νία Έκδοσης"
        Me.LayoutControlItem13.Location = New System.Drawing.Point(863, 338)
        Me.LayoutControlItem13.Name = "LayoutControlItem13"
        Me.LayoutControlItem13.Size = New System.Drawing.Size(863, 42)
        Me.LayoutControlItem13.Text = "Ημερ/νία  Λήξης"
        Me.LayoutControlItem13.TextSize = New System.Drawing.Size(179, 23)
        '
        'Vw_SUPTableAdapter
        '
        Me.Vw_SUPTableAdapter.ClearBeforeFill = True
        '
        'Vw_BUYTableAdapter
        '
        Me.Vw_BUYTableAdapter.ClearBeforeFill = True
        '
        'Vw_PAYTableAdapter
        '
        Me.Vw_PAYTableAdapter.ClearBeforeFill = True
        '
        'Vw_BANKSTableAdapter
        '
        Me.Vw_BANKSTableAdapter.ClearBeforeFill = True
        '
        'frmSUPKal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 23.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1741, 1287)
        Me.Controls.Add(Me.LayoutControl1)
        Me.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.None
        Me.IconOptions.Image = Global.DreamyKitchenCRM.My.Resources.Resources.favicon
        Me.Name = "frmSUPKal"
        Me.Text = "frmSUPKAL"
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.dtissueDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtissueDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdMain, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VwBUYBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DreamyKitchenDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboSUP.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VwSUPBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpayDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpayDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtcheckNum.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAmt.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboPAY.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VwPAYBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtBal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboBANK.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VwBANKSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDepositNum.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtComments.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtendDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtendDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem18, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents cmdSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdExit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents dtissueDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents grdMain As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents cboSUP As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents dtpayDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents txtCode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtcheckNum As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtAmt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cboPAY As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents txtBal As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cboBANK As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents txtDepositNum As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtComments As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents Root As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LayoutControlItem12 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem18 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem14 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem10 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem11 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents VwBUYBindingSource As BindingSource
    Friend WithEvents DreamyKitchenDataSet As DreamyKitchenDataSet
    Friend WithEvents VwSUPBindingSource As BindingSource
    Friend WithEvents VwPAYBindingSource As BindingSource
    Friend WithEvents VwBANKSBindingSource As BindingSource
    Friend WithEvents Vw_SUPTableAdapter As DreamyKitchenDataSetTableAdapters.vw_SUPTableAdapter
    Friend WithEvents Vw_BUYTableAdapter As DreamyKitchenDataSetTableAdapters.vw_BUYTableAdapter
    Friend WithEvents Vw_PAYTableAdapter As DreamyKitchenDataSetTableAdapters.vw_PAYTableAdapter
    Friend WithEvents Vw_BANKSTableAdapter As DreamyKitchenDataSetTableAdapters.vw_BANKSTableAdapter
    Friend WithEvents colID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colcode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldtBuy As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colinvoiceNumber As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsupID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colcusID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coltranshID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colnetAmount As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colvatAmount As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colmodifiedBy As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colmodifiedOn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colcreatedOn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colcreatedBy As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSupFullName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCusFullname As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTranshDescription As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRealName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBuyCName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colcmt As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colbuyCID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colkitchen As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colcloset As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colgeneral As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colmaterials As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colbathroomFurn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDevicesBuy As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPayName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colpayID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colpaid As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colkitchenV As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colclosetV As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colgeneralV As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colmaterialsV As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colbathroomFurnV As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDevicesBuyV As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colisCredit As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents dtendDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LayoutControlItem13 As DevExpress.XtraLayout.LayoutControlItem
End Class
