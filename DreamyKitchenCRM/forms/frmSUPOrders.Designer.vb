﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmSUPOrders
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSUPOrders))
        Me.VwCCTBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DreamyKitchenDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DreamyKitchenDataSet = New DreamyKitchenCRM.DreamyKitchenDataSet()
        Me.VwORDERMANAGERSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VwSUPBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Vw_ORDER_MANAGERSTableAdapter = New DreamyKitchenCRM.DreamyKitchenDataSetTableAdapters.vw_ORDER_MANAGERSTableAdapter()
        Me.Vw_SUPTableAdapter = New DreamyKitchenCRM.DreamyKitchenDataSetTableAdapters.vw_SUPTableAdapter()
        Me.Vw_CCTTableAdapter = New DreamyKitchenCRM.DreamyKitchenDataSetTableAdapters.vw_CCTTableAdapter()
        Me.XtraOpenFileDialog1 = New DevExpress.XtraEditors.XtraOpenFileDialog(Me.components)
        Me.TabPane1 = New DevExpress.XtraBars.Navigation.TabPane()
        Me.TabNavigationPage1 = New DevExpress.XtraBars.Navigation.TabNavigationPage()
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.cmdExit = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdSave = New DevExpress.XtraEditors.SimpleButton()
        Me.cboCUS = New DevExpress.XtraEditors.LookUpEdit()
        Me.CCTTRANSHBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DM_TRANS = New DreamyKitchenCRM.DM_TRANS()
        Me.txtCode = New DevExpress.XtraEditors.TextEdit()
        Me.txtPhn = New DevExpress.XtraEditors.TextEdit()
        Me.txtADR = New DevExpress.XtraEditors.TextEdit()
        Me.dtOrder = New DevExpress.XtraEditors.DateEdit()
        Me.txtArea = New DevExpress.XtraEditors.TextEdit()
        Me.cboEMP = New DevExpress.XtraEditors.LookUpEdit()
        Me.cboTRANSH = New DevExpress.XtraEditors.LookUpEdit()
        Me.cboSUP = New DevExpress.XtraEditors.LookUpEdit()
        Me.dtReceipt = New DevExpress.XtraEditors.DateEdit()
        Me.txtFileNames = New DevExpress.XtraEditors.ButtonEdit()
        Me.txtComments = New DevExpress.XtraEditors.MemoEdit()
        Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem26 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem27 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem3 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem30 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem46 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem31 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem13 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem25 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem14 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.TabNavigationPage2 = New DevExpress.XtraBars.Navigation.TabNavigationPage()
        Me.LayoutControl2 = New DevExpress.XtraLayout.LayoutControl()
        Me.LayoutControl4 = New DevExpress.XtraLayout.LayoutControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.cmdSendEmail = New DevExpress.XtraEditors.SimpleButton()
        Me.txtBody = New DevExpress.XtraEditors.MemoEdit()
        Me.txtTo = New DevExpress.XtraEditors.TextEdit()
        Me.GridControl2 = New DevExpress.XtraGrid.GridControl()
        Me.SUPORDERSMAILBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DMDataSet = New DreamyKitchenCRM.DMDataSet()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colcode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsupOrderID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colemailFrom = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colemailTo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colemailSubject = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colemailBody = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colemailMode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDateOfEmail = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colcreatedOn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colcreatedBy = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtSubject = New DevExpress.XtraEditors.TextEdit()
        Me.LayoutControlGroup31 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem17 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem18 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem19 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem21 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem22 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem23 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem4 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.SUP_ORDERS_MAILTableAdapter = New DreamyKitchenCRM.DMDataSetTableAdapters.SUP_ORDERS_MAILTableAdapter()
        Me.CCT_TRANSHTableAdapter = New DreamyKitchenCRM.DM_TRANSTableAdapters.CCT_TRANSHTableAdapter()
        CType(Me.VwCCTBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DreamyKitchenDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DreamyKitchenDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VwORDERMANAGERSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VwSUPBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TabPane1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPane1.SuspendLayout()
        Me.TabNavigationPage1.SuspendLayout()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboCUS.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CCTTRANSHBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DM_TRANS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPhn.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtADR.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtOrder.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtOrder.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtArea.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboEMP.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboTRANSH.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboSUP.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtReceipt.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtReceipt.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFileNames.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtComments.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem26, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem27, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem30, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem46, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem31, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem25, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabNavigationPage2.SuspendLayout()
        CType(Me.LayoutControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl2.SuspendLayout()
        CType(Me.LayoutControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl4.SuspendLayout()
        CType(Me.txtBody.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SUPORDERSMAILBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DMDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSubject.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup31, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem17, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem18, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem19, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem21, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem22, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem23, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'VwCCTBindingSource
        '
        Me.VwCCTBindingSource.DataMember = "vw_CCT"
        Me.VwCCTBindingSource.DataSource = Me.DreamyKitchenDataSetBindingSource
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
        'VwORDERMANAGERSBindingSource
        '
        Me.VwORDERMANAGERSBindingSource.DataMember = "vw_ORDER_MANAGERS"
        Me.VwORDERMANAGERSBindingSource.DataSource = Me.DreamyKitchenDataSetBindingSource
        '
        'VwSUPBindingSource
        '
        Me.VwSUPBindingSource.DataMember = "vw_SUP"
        Me.VwSUPBindingSource.DataSource = Me.DreamyKitchenDataSetBindingSource
        '
        'Vw_ORDER_MANAGERSTableAdapter
        '
        Me.Vw_ORDER_MANAGERSTableAdapter.ClearBeforeFill = True
        '
        'Vw_SUPTableAdapter
        '
        Me.Vw_SUPTableAdapter.ClearBeforeFill = True
        '
        'Vw_CCTTableAdapter
        '
        Me.Vw_CCTTableAdapter.ClearBeforeFill = True
        '
        'XtraOpenFileDialog1
        '
        Me.XtraOpenFileDialog1.Multiselect = True
        Me.XtraOpenFileDialog1.Title = "Επιλογή αρχείων"
        '
        'TabPane1
        '
        Me.TabPane1.Controls.Add(Me.TabNavigationPage1)
        Me.TabPane1.Controls.Add(Me.TabNavigationPage2)
        Me.TabPane1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabPane1.Location = New System.Drawing.Point(0, 0)
        Me.TabPane1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabPane1.Name = "TabPane1"
        Me.TabPane1.Pages.AddRange(New DevExpress.XtraBars.Navigation.NavigationPageBase() {Me.TabNavigationPage1, Me.TabNavigationPage2})
        Me.TabPane1.RegularSize = New System.Drawing.Size(1098, 783)
        Me.TabPane1.SelectedPage = Me.TabNavigationPage1
        Me.TabPane1.Size = New System.Drawing.Size(1098, 783)
        Me.TabPane1.TabIndex = 0
        Me.TabPane1.Text = "TabPane1"
        '
        'TabNavigationPage1
        '
        Me.TabNavigationPage1.Caption = "Στοιχεία Παραγγελίας"
        Me.TabNavigationPage1.Controls.Add(Me.LayoutControl1)
        Me.TabNavigationPage1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabNavigationPage1.Name = "TabNavigationPage1"
        Me.TabNavigationPage1.Size = New System.Drawing.Size(1098, 734)
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.GridControl1)
        Me.LayoutControl1.Controls.Add(Me.cmdExit)
        Me.LayoutControl1.Controls.Add(Me.cmdSave)
        Me.LayoutControl1.Controls.Add(Me.cboCUS)
        Me.LayoutControl1.Controls.Add(Me.txtCode)
        Me.LayoutControl1.Controls.Add(Me.txtPhn)
        Me.LayoutControl1.Controls.Add(Me.txtADR)
        Me.LayoutControl1.Controls.Add(Me.dtOrder)
        Me.LayoutControl1.Controls.Add(Me.txtArea)
        Me.LayoutControl1.Controls.Add(Me.cboEMP)
        Me.LayoutControl1.Controls.Add(Me.cboTRANSH)
        Me.LayoutControl1.Controls.Add(Me.cboSUP)
        Me.LayoutControl1.Controls.Add(Me.dtReceipt)
        Me.LayoutControl1.Controls.Add(Me.txtFileNames)
        Me.LayoutControl1.Controls.Add(Me.txtComments)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(1090, 555, 650, 400)
        Me.LayoutControl1.Root = Me.Root
        Me.LayoutControl1.Size = New System.Drawing.Size(1098, 734)
        Me.LayoutControl1.TabIndex = 4
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'GridControl1
        '
        Me.GridControl1.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.GridControl1.Location = New System.Drawing.Point(11, 341)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(1076, 347)
        Me.GridControl1.TabIndex = 62
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.DetailHeight = 511
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always
        Me.GridView1.LevelIndent = 0
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsEditForm.PopupEditFormWidth = 720
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        Me.GridView1.PreviewIndent = 0
        '
        'cmdExit
        '
        Me.cmdExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdExit.ImageOptions.Image = CType(resources.GetObject("cmdExit.ImageOptions.Image"), System.Drawing.Image)
        Me.cmdExit.Location = New System.Drawing.Point(924, 692)
        Me.cmdExit.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(163, 32)
        Me.cmdExit.StyleController = Me.LayoutControl1
        Me.cmdExit.TabIndex = 21
        Me.cmdExit.Text = "Έξοδος"
        '
        'cmdSave
        '
        Me.cmdSave.ImageOptions.Image = CType(resources.GetObject("cmdSave.ImageOptions.Image"), System.Drawing.Image)
        Me.cmdSave.Location = New System.Drawing.Point(766, 692)
        Me.cmdSave.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(154, 32)
        Me.cmdSave.StyleController = Me.LayoutControl1
        Me.cmdSave.TabIndex = 61
        Me.cmdSave.Text = "Αποθήκευση"
        '
        'cboCUS
        '
        Me.cboCUS.Location = New System.Drawing.Point(181, 102)
        Me.cboCUS.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cboCUS.Name = "cboCUS"
        Me.cboCUS.Properties.AllowMouseWheel = False
        Me.cboCUS.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.cboCUS.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Search), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Clear)})
        Me.cboCUS.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 31, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("code", "code", 49, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Fullname", "Όνομα", 82, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CouID", "Cou ID", 66, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("AreaID", "Area ID", 71, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("AdrID", "Adr ID", 63, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("SourceID", "Source ID", 89, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("SalerID", "Saler ID", 75, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("DoyID", "Doy ID", 66, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("PrfID", "Prf ID", 58, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("phn", "Τηλέφωνο", 43, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("mob", "mob", 47, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("fax", "fax", 36, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("email", "email", 53, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("afm", "afm", 42, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("cmt", "cmt", 41, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("modifiedBy", "modified By", 102, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("modifiedOn", "modified On", 105, DevExpress.Utils.FormatType.DateTime, "d/M/yyyy", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("createdOn", "created On", 97, DevExpress.Utils.FormatType.DateTime, "d/M/yyyy", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("name", "name", 56, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("RealName", "Real Name", 95, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("COU_Name", "COU_Name", 99, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("SRC_Name", "SRC_Name", 97, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("AREAS_Name", "AREAS_Name", 117, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ADR_Name", "ADR_Name", 99, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("PRF_Name", "PRF_Name", 95, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("SALERS_Name", "SALERS_Name", 125, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("color", "color", 49, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Ar", "Ar", 30, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("tk", "tk", 28, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("createdby_Realname", "createdby_Realname", 172, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("HasFiles", "Has Files", 79, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("createdBy", "created By", 94, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default])})
        Me.cboCUS.Properties.DataSource = Me.CCTTRANSHBindingSource
        Me.cboCUS.Properties.DisplayMember = "Fullname"
        Me.cboCUS.Properties.NullText = ""
        Me.cboCUS.Properties.PopupSizeable = False
        Me.cboCUS.Properties.ValueMember = "ID"
        Me.cboCUS.Size = New System.Drawing.Size(906, 26)
        Me.cboCUS.StyleController = Me.LayoutControl1
        Me.cboCUS.TabIndex = 5
        Me.cboCUS.Tag = "cusID,0,1,2"
        '
        'CCTTRANSHBindingSource
        '
        Me.CCTTRANSHBindingSource.DataMember = "CCT_TRANSH"
        Me.CCTTRANSHBindingSource.DataSource = Me.DM_TRANS
        '
        'DM_TRANS
        '
        Me.DM_TRANS.DataSetName = "DM_TRANS"
        Me.DM_TRANS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txtCode
        '
        Me.txtCode.Location = New System.Drawing.Point(181, 10)
        Me.txtCode.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtCode.Name = "txtCode"
        Me.txtCode.Properties.Appearance.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.txtCode.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtCode.Properties.Appearance.Options.UseBackColor = True
        Me.txtCode.Properties.Appearance.Options.UseFont = True
        Me.txtCode.Properties.ReadOnly = True
        Me.txtCode.Size = New System.Drawing.Size(143, 28)
        Me.txtCode.StyleController = Me.LayoutControl1
        Me.txtCode.TabIndex = 4
        Me.txtCode.Tag = "code,0"
        '
        'txtPhn
        '
        Me.txtPhn.Location = New System.Drawing.Point(181, 162)
        Me.txtPhn.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtPhn.Name = "txtPhn"
        Me.txtPhn.Properties.ReadOnly = True
        Me.txtPhn.Properties.UseReadOnlyAppearance = False
        Me.txtPhn.Size = New System.Drawing.Size(167, 26)
        Me.txtPhn.StyleController = Me.LayoutControl1
        Me.txtPhn.TabIndex = 23
        Me.txtPhn.Tag = "phn"
        '
        'txtADR
        '
        Me.txtADR.Location = New System.Drawing.Point(431, 162)
        Me.txtADR.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtADR.Name = "txtADR"
        Me.txtADR.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.txtADR.Properties.ReadOnly = True
        Me.txtADR.Properties.UseReadOnlyAppearance = False
        Me.txtADR.Size = New System.Drawing.Size(366, 26)
        Me.txtADR.StyleController = Me.LayoutControl1
        Me.txtADR.TabIndex = 7
        Me.txtADR.Tag = "ADR_name"
        '
        'dtOrder
        '
        Me.dtOrder.EditValue = Nothing
        Me.dtOrder.Location = New System.Drawing.Point(181, 192)
        Me.dtOrder.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dtOrder.Name = "dtOrder"
        Me.dtOrder.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtOrder.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtOrder.Size = New System.Drawing.Size(342, 26)
        Me.dtOrder.StyleController = Me.LayoutControl1
        Me.dtOrder.TabIndex = 32
        Me.dtOrder.Tag = "dtOrder,0,1,2"
        '
        'txtArea
        '
        Me.txtArea.Location = New System.Drawing.Point(843, 162)
        Me.txtArea.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtArea.Name = "txtArea"
        Me.txtArea.Properties.ReadOnly = True
        Me.txtArea.Properties.UseReadOnlyAppearance = False
        Me.txtArea.Size = New System.Drawing.Size(244, 26)
        Me.txtArea.StyleController = Me.LayoutControl1
        Me.txtArea.TabIndex = 23
        Me.txtArea.Tag = "mob"
        '
        'cboEMP
        '
        Me.cboEMP.Location = New System.Drawing.Point(181, 42)
        Me.cboEMP.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cboEMP.Name = "cboEMP"
        Me.cboEMP.Properties.AllowMouseWheel = False
        Me.cboEMP.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.cboEMP.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Search), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Clear)})
        Me.cboEMP.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 31, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("code", "code", 49, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Fullname", "Υπέυθυνος Παραγγελιών", 82, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CouID", "Cou ID", 66, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("AreaID", "Area ID", 71, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("AdrID", "Adr ID", 63, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("DoyID", "Doy ID", 66, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("PrfID", "Prf ID", 58, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("salary", "salary", 57, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("hireDate", "hire Date", 83, DevExpress.Utils.FormatType.DateTime, "d/M/yyyy", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("phn", "phn", 43, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("mob", "mob", 47, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("fax", "fax", 36, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("email", "email", 53, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("afm", "afm", 42, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("cmt", "cmt", 41, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("modifiedBy", "modified By", 102, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("modifiedOn", "modified On", 105, DevExpress.Utils.FormatType.DateTime, "d/M/yyyy", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("createdOn", "created On", 97, DevExpress.Utils.FormatType.DateTime, "d/M/yyyy", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("createdBy", "created By", 94, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("RealName", "Real Name", 95, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CouName", "Cou Name", 92, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("AdrName", "Adr Name", 89, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("AreaName", "Area Name", 97, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("DoyName", "Doy Name", 92, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("PrfName", "Prf Name", 84, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("depID", "dep ID", 66, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("DepName", "Dep Name", 94, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Ar", "Ar", 30, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("tk", "tk", 28, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("HasFiles", "Has Files", 79, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("color", "color", 49, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("serID", "ser ID", 59, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("salerID", "saler ID", 72, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("SerName", "Ser Name", 88, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("SalerName", "Saler Name", 101, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("tmIN", "tm IN", 57, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("tmOUT", "tm OUT", 72, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("arProt", "ar Prot", 64, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("profitPerc", "profit Perc", 91, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("JobName", "Job Name", 89, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("jobID", "job ID", 60, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("isActive", "is Active", 74, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("usrName", "usr Name", 86, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("active", "active", 57, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default])})
        Me.cboEMP.Properties.DataSource = Me.VwORDERMANAGERSBindingSource
        Me.cboEMP.Properties.DisplayMember = "Fullname"
        Me.cboEMP.Properties.NullText = ""
        Me.cboEMP.Properties.PopupSizeable = False
        Me.cboEMP.Properties.ValueMember = "ID"
        Me.cboEMP.Size = New System.Drawing.Size(906, 26)
        Me.cboEMP.StyleController = Me.LayoutControl1
        Me.cboEMP.TabIndex = 5
        Me.cboEMP.Tag = "empID,0,1,2"
        '
        'cboTRANSH
        '
        Me.cboTRANSH.Location = New System.Drawing.Point(181, 132)
        Me.cboTRANSH.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cboTRANSH.Name = "cboTRANSH"
        Me.cboTRANSH.Properties.AllowMouseWheel = False
        Me.cboTRANSH.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.cboTRANSH.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Search), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Clear)})
        Me.cboTRANSH.Properties.DisplayMember = "description"
        Me.cboTRANSH.Properties.NullText = ""
        Me.cboTRANSH.Properties.PopupSizeable = False
        Me.cboTRANSH.Properties.ValueMember = "ID"
        Me.cboTRANSH.Size = New System.Drawing.Size(906, 26)
        Me.cboTRANSH.StyleController = Me.LayoutControl1
        Me.cboTRANSH.TabIndex = 6
        Me.cboTRANSH.Tag = "transhID,0,1,2"
        '
        'cboSUP
        '
        Me.cboSUP.Location = New System.Drawing.Point(181, 72)
        Me.cboSUP.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cboSUP.Name = "cboSUP"
        Me.cboSUP.Properties.AllowMouseWheel = False
        Me.cboSUP.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.cboSUP.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Search), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Clear)})
        Me.cboSUP.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 31, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("code", "code", 49, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Fullname", "Προμηθευτής", 82, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ttl", "ttl", 28, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("bal", "bal", 36, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default])})
        Me.cboSUP.Properties.DataSource = Me.VwSUPBindingSource
        Me.cboSUP.Properties.DisplayMember = "Fullname"
        Me.cboSUP.Properties.NullText = ""
        Me.cboSUP.Properties.PopupSizeable = False
        Me.cboSUP.Properties.ValueMember = "ID"
        Me.cboSUP.Size = New System.Drawing.Size(906, 26)
        Me.cboSUP.StyleController = Me.LayoutControl1
        Me.cboSUP.TabIndex = 5
        Me.cboSUP.Tag = "supID,0,1,2"
        '
        'dtReceipt
        '
        Me.dtReceipt.EditValue = Nothing
        Me.dtReceipt.Location = New System.Drawing.Point(697, 192)
        Me.dtReceipt.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dtReceipt.Name = "dtReceipt"
        Me.dtReceipt.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtReceipt.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtReceipt.Properties.MaskSettings.Set("mask", "d")
        Me.dtReceipt.Properties.UseReadOnlyAppearance = False
        Me.dtReceipt.Size = New System.Drawing.Size(390, 26)
        Me.dtReceipt.StyleController = Me.LayoutControl1
        Me.dtReceipt.TabIndex = 50
        Me.dtReceipt.Tag = "dtReceipt,0,1,2"
        '
        'txtFileNames
        '
        Me.txtFileNames.Location = New System.Drawing.Point(181, 311)
        Me.txtFileNames.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtFileNames.Name = "txtFileNames"
        Me.txtFileNames.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Search), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Clear)})
        Me.txtFileNames.Size = New System.Drawing.Size(906, 26)
        Me.txtFileNames.StyleController = Me.LayoutControl1
        Me.txtFileNames.TabIndex = 30
        Me.txtFileNames.Tag = ""
        '
        'txtComments
        '
        Me.txtComments.Location = New System.Drawing.Point(181, 222)
        Me.txtComments.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtComments.Name = "txtComments"
        Me.txtComments.Size = New System.Drawing.Size(906, 85)
        Me.txtComments.StyleController = Me.LayoutControl1
        Me.txtComments.TabIndex = 17
        Me.txtComments.Tag = "cmt,0,1,2"
        '
        'Root
        '
        Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.Root.GroupBordersVisible = False
        Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem26, Me.LayoutControlItem27, Me.EmptySpaceItem3, Me.LayoutControlItem9, Me.LayoutControlItem30, Me.LayoutControlItem7, Me.LayoutControlItem4, Me.EmptySpaceItem1, Me.LayoutControlItem46, Me.LayoutControlItem1, Me.LayoutControlItem8, Me.LayoutControlItem31, Me.LayoutControlItem13, Me.LayoutControlItem3, Me.LayoutControlItem25, Me.LayoutControlItem5, Me.LayoutControlItem14})
        Me.Root.Name = "Root"
        Me.Root.OptionsItemText.TextToControlDistance = 1
        Me.Root.Size = New System.Drawing.Size(1098, 734)
        Me.Root.TextVisible = False
        '
        'LayoutControlItem26
        '
        Me.LayoutControlItem26.Control = Me.cmdSave
        Me.LayoutControlItem26.Location = New System.Drawing.Point(755, 682)
        Me.LayoutControlItem26.Name = "LayoutControlItem26"
        Me.LayoutControlItem26.Size = New System.Drawing.Size(158, 36)
        Me.LayoutControlItem26.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem26.TextVisible = False
        '
        'LayoutControlItem27
        '
        Me.LayoutControlItem27.Control = Me.cmdExit
        Me.LayoutControlItem27.Location = New System.Drawing.Point(913, 682)
        Me.LayoutControlItem27.Name = "LayoutControlItem27"
        Me.LayoutControlItem27.Size = New System.Drawing.Size(167, 36)
        Me.LayoutControlItem27.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem27.TextVisible = False
        '
        'EmptySpaceItem3
        '
        Me.EmptySpaceItem3.AllowHotTrack = False
        Me.EmptySpaceItem3.Location = New System.Drawing.Point(0, 682)
        Me.EmptySpaceItem3.Name = "EmptySpaceItem3"
        Me.EmptySpaceItem3.Size = New System.Drawing.Size(755, 36)
        Me.EmptySpaceItem3.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem9
        '
        Me.LayoutControlItem9.Control = Me.cboCUS
        Me.LayoutControlItem9.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem9.CustomizationFormText = "Νομός"
        Me.LayoutControlItem9.ImageOptions.Image = CType(resources.GetObject("LayoutControlItem9.ImageOptions.Image"), System.Drawing.Image)
        Me.LayoutControlItem9.Location = New System.Drawing.Point(0, 92)
        Me.LayoutControlItem9.Name = "LayoutControlItem9"
        Me.LayoutControlItem9.Size = New System.Drawing.Size(1080, 30)
        Me.LayoutControlItem9.Tag = "1"
        Me.LayoutControlItem9.Text = "Πελάτης"
        Me.LayoutControlItem9.TextLocation = DevExpress.Utils.Locations.Left
        Me.LayoutControlItem9.TextSize = New System.Drawing.Size(169, 19)
        '
        'LayoutControlItem30
        '
        Me.LayoutControlItem30.Control = Me.dtOrder
        Me.LayoutControlItem30.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem30.CustomizationFormText = "Ημερ/νία Παραγγελίας"
        Me.LayoutControlItem30.ImageOptions.Image = CType(resources.GetObject("LayoutControlItem30.ImageOptions.Image"), System.Drawing.Image)
        Me.LayoutControlItem30.Location = New System.Drawing.Point(0, 182)
        Me.LayoutControlItem30.Name = "LayoutControlItem30"
        Me.LayoutControlItem30.Size = New System.Drawing.Size(516, 30)
        Me.LayoutControlItem30.Tag = "1"
        Me.LayoutControlItem30.Text = "Ημερ/νία Παραγγελίας"
        Me.LayoutControlItem30.TextSize = New System.Drawing.Size(169, 19)
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.Control = Me.txtADR
        Me.LayoutControlItem7.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem7.CustomizationFormText = "Διεύθυνση"
        Me.LayoutControlItem7.Location = New System.Drawing.Point(341, 152)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(449, 30)
        Me.LayoutControlItem7.Text = "Διεύθυνση"
        Me.LayoutControlItem7.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(74, 19)
        Me.LayoutControlItem7.TextToControlDistance = 5
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.txtCode
        Me.LayoutControlItem4.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem4.CustomizationFormText = "Κωδικός"
        Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(317, 32)
        Me.LayoutControlItem4.Text = "Κωδικός"
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(169, 19)
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(317, 0)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(763, 32)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem46
        '
        Me.LayoutControlItem46.Control = Me.cboEMP
        Me.LayoutControlItem46.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem46.CustomizationFormText = "Νομός"
        Me.LayoutControlItem46.ImageOptions.Image = CType(resources.GetObject("LayoutControlItem46.ImageOptions.Image"), System.Drawing.Image)
        Me.LayoutControlItem46.Location = New System.Drawing.Point(0, 32)
        Me.LayoutControlItem46.Name = "LayoutControlItem46"
        Me.LayoutControlItem46.Size = New System.Drawing.Size(1080, 30)
        Me.LayoutControlItem46.Tag = "1"
        Me.LayoutControlItem46.Text = "Υπεύθυνος Παραγγ."
        Me.LayoutControlItem46.TextLocation = DevExpress.Utils.Locations.Left
        Me.LayoutControlItem46.TextSize = New System.Drawing.Size(169, 19)
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.cboTRANSH
        Me.LayoutControlItem1.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem1.CustomizationFormText = "Περιοχή"
        Me.LayoutControlItem1.HighlightFocusedItem = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlItem1.ImageOptions.Image = CType(resources.GetObject("LayoutControlItem1.ImageOptions.Image"), System.Drawing.Image)
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 122)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(1080, 30)
        Me.LayoutControlItem1.Tag = "1"
        Me.LayoutControlItem1.Text = "Έργο Πελάτη"
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(169, 19)
        '
        'LayoutControlItem8
        '
        Me.LayoutControlItem8.Control = Me.txtArea
        Me.LayoutControlItem8.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem8.CustomizationFormText = "Κινητό"
        Me.LayoutControlItem8.Location = New System.Drawing.Point(790, 152)
        Me.LayoutControlItem8.Name = "LayoutControlItem8"
        Me.LayoutControlItem8.Size = New System.Drawing.Size(290, 30)
        Me.LayoutControlItem8.Text = "Πόλη"
        Me.LayoutControlItem8.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
        Me.LayoutControlItem8.TextLocation = DevExpress.Utils.Locations.Left
        Me.LayoutControlItem8.TextSize = New System.Drawing.Size(37, 19)
        Me.LayoutControlItem8.TextToControlDistance = 5
        '
        'LayoutControlItem31
        '
        Me.LayoutControlItem31.Control = Me.dtReceipt
        Me.LayoutControlItem31.Location = New System.Drawing.Point(516, 182)
        Me.LayoutControlItem31.Name = "LayoutControlItem31"
        Me.LayoutControlItem31.Size = New System.Drawing.Size(564, 30)
        Me.LayoutControlItem31.Tag = ""
        Me.LayoutControlItem31.Text = "Ημερ/νία Παραλαβής"
        Me.LayoutControlItem31.TextSize = New System.Drawing.Size(169, 19)
        '
        'LayoutControlItem13
        '
        Me.LayoutControlItem13.Control = Me.txtPhn
        Me.LayoutControlItem13.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem13.CustomizationFormText = "Κινητό"
        Me.LayoutControlItem13.Location = New System.Drawing.Point(0, 152)
        Me.LayoutControlItem13.Name = "LayoutControlItem13"
        Me.LayoutControlItem13.Size = New System.Drawing.Size(341, 30)
        Me.LayoutControlItem13.Text = "Κινητό"
        Me.LayoutControlItem13.TextLocation = DevExpress.Utils.Locations.Left
        Me.LayoutControlItem13.TextSize = New System.Drawing.Size(169, 19)
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.cboSUP
        Me.LayoutControlItem3.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem3.CustomizationFormText = "Νομός"
        Me.LayoutControlItem3.ImageOptions.Image = CType(resources.GetObject("LayoutControlItem3.ImageOptions.Image"), System.Drawing.Image)
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 62)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(1080, 30)
        Me.LayoutControlItem3.Text = "Προμηθευτής"
        Me.LayoutControlItem3.TextLocation = DevExpress.Utils.Locations.Left
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(169, 19)
        '
        'LayoutControlItem25
        '
        Me.LayoutControlItem25.Control = Me.txtFileNames
        Me.LayoutControlItem25.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem25.CustomizationFormText = "Αρχεία"
        Me.LayoutControlItem25.HighlightFocusedItem = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlItem25.Location = New System.Drawing.Point(0, 301)
        Me.LayoutControlItem25.Name = "LayoutControlItem25"
        Me.LayoutControlItem25.Size = New System.Drawing.Size(1080, 30)
        Me.LayoutControlItem25.Text = "Αρχεία"
        Me.LayoutControlItem25.TextSize = New System.Drawing.Size(169, 19)
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.GridControl1
        Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 331)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(1080, 351)
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem5.TextVisible = False
        '
        'LayoutControlItem14
        '
        Me.LayoutControlItem14.Control = Me.txtComments
        Me.LayoutControlItem14.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem14.CustomizationFormText = "Σχόλια"
        Me.LayoutControlItem14.HighlightFocusedItem = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlItem14.Location = New System.Drawing.Point(0, 212)
        Me.LayoutControlItem14.Name = "LayoutControlItem14"
        Me.LayoutControlItem14.Size = New System.Drawing.Size(1080, 89)
        Me.LayoutControlItem14.Text = "Σχόλια"
        Me.LayoutControlItem14.TextSize = New System.Drawing.Size(169, 19)
        '
        'TabNavigationPage2
        '
        Me.TabNavigationPage2.Caption = "Email"
        Me.TabNavigationPage2.Controls.Add(Me.LayoutControl2)
        Me.TabNavigationPage2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabNavigationPage2.Name = "TabNavigationPage2"
        Me.TabNavigationPage2.Size = New System.Drawing.Size(1098, 735)
        '
        'LayoutControl2
        '
        Me.LayoutControl2.Controls.Add(Me.LayoutControl4)
        Me.LayoutControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.LayoutControl2.Name = "LayoutControl2"
        Me.LayoutControl2.Root = Me.LayoutControlGroup1
        Me.LayoutControl2.Size = New System.Drawing.Size(1098, 735)
        Me.LayoutControl2.TabIndex = 0
        Me.LayoutControl2.Text = "LayoutControl2"
        '
        'LayoutControl4
        '
        Me.LayoutControl4.Controls.Add(Me.LabelControl3)
        Me.LayoutControl4.Controls.Add(Me.cmdSendEmail)
        Me.LayoutControl4.Controls.Add(Me.txtBody)
        Me.LayoutControl4.Controls.Add(Me.txtTo)
        Me.LayoutControl4.Controls.Add(Me.GridControl2)
        Me.LayoutControl4.Controls.Add(Me.txtSubject)
        Me.LayoutControl4.Location = New System.Drawing.Point(11, 10)
        Me.LayoutControl4.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.LayoutControl4.Name = "LayoutControl4"
        Me.LayoutControl4.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(1438, 612, 1137, 700)
        Me.LayoutControl4.Root = Me.LayoutControlGroup31
        Me.LayoutControl4.Size = New System.Drawing.Size(1076, 715)
        Me.LayoutControl4.TabIndex = 10
        Me.LayoutControl4.Text = "LayoutControl4"
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.LabelControl3.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Appearance.Options.UseForeColor = True
        Me.LabelControl3.Location = New System.Drawing.Point(11, 280)
        Me.LabelControl3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(133, 22)
        Me.LabelControl3.StyleController = Me.LayoutControl4
        Me.LabelControl3.TabIndex = 49
        Me.LabelControl3.Text = "Ιστορικό Email"
        '
        'cmdSendEmail
        '
        Me.cmdSendEmail.ImageOptions.Image = CType(resources.GetObject("cmdSendEmail.ImageOptions.Image"), System.Drawing.Image)
        Me.cmdSendEmail.Location = New System.Drawing.Point(835, 240)
        Me.cmdSendEmail.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmdSendEmail.Name = "cmdSendEmail"
        Me.cmdSendEmail.Size = New System.Drawing.Size(230, 36)
        Me.cmdSendEmail.StyleController = Me.LayoutControl4
        Me.cmdSendEmail.TabIndex = 6
        Me.cmdSendEmail.Text = "Αποστολή Email"
        '
        'txtBody
        '
        Me.txtBody.Location = New System.Drawing.Point(75, 70)
        Me.txtBody.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtBody.Name = "txtBody"
        Me.txtBody.Size = New System.Drawing.Size(990, 166)
        Me.txtBody.StyleController = Me.LayoutControl4
        Me.txtBody.TabIndex = 4
        '
        'txtTo
        '
        Me.txtTo.Location = New System.Drawing.Point(75, 10)
        Me.txtTo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtTo.Name = "txtTo"
        Me.txtTo.Size = New System.Drawing.Size(990, 26)
        Me.txtTo.StyleController = Me.LayoutControl4
        Me.txtTo.TabIndex = 2
        '
        'GridControl2
        '
        Me.GridControl2.Cursor = System.Windows.Forms.Cursors.Default
        Me.GridControl2.DataSource = Me.SUPORDERSMAILBindingSource
        Me.GridControl2.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GridControl2.Location = New System.Drawing.Point(11, 306)
        Me.GridControl2.MainView = Me.GridView2
        Me.GridControl2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GridControl2.Name = "GridControl2"
        Me.GridControl2.Size = New System.Drawing.Size(1054, 399)
        Me.GridControl2.TabIndex = 7
        Me.GridControl2.UseEmbeddedNavigator = True
        Me.GridControl2.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2})
        '
        'SUPORDERSMAILBindingSource
        '
        Me.SUPORDERSMAILBindingSource.DataMember = "SUP_ORDERS_MAIL"
        Me.SUPORDERSMAILBindingSource.DataSource = Me.DMDataSet
        '
        'DMDataSet
        '
        Me.DMDataSet.DataSetName = "DMDataSet"
        Me.DMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colID, Me.colcode, Me.colsupOrderID, Me.colemailFrom, Me.colemailTo, Me.colemailSubject, Me.colemailBody, Me.colemailMode, Me.colDateOfEmail, Me.colcreatedOn, Me.colcreatedBy})
        Me.GridView2.DetailHeight = 511
        Me.GridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus
        Me.GridView2.GridControl = Me.GridControl2
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsBehavior.AutoExpandAllGroups = True
        Me.GridView2.OptionsBehavior.Editable = False
        Me.GridView2.OptionsBehavior.ReadOnly = True
        Me.GridView2.OptionsEditForm.PopupEditFormWidth = 720
        Me.GridView2.OptionsLayout.Columns.StoreAppearance = True
        Me.GridView2.OptionsLayout.StoreAllOptions = True
        Me.GridView2.OptionsLayout.StoreAppearance = True
        Me.GridView2.OptionsLayout.StoreFormatRules = True
        Me.GridView2.OptionsMenu.ShowConditionalFormattingItem = True
        Me.GridView2.OptionsMenu.ShowFooterItem = True
        Me.GridView2.OptionsMenu.ShowGroupSummaryEditorItem = True
        Me.GridView2.OptionsPrint.PrintPreview = True
        Me.GridView2.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView2.OptionsView.ColumnAutoWidth = False
        Me.GridView2.OptionsView.EnableAppearanceEvenRow = True
        Me.GridView2.OptionsView.ShowGroupPanel = False
        '
        'colID
        '
        Me.colID.FieldName = "ID"
        Me.colID.MinWidth = 31
        Me.colID.Name = "colID"
        Me.colID.Visible = True
        Me.colID.VisibleIndex = 0
        Me.colID.Width = 118
        '
        'colcode
        '
        Me.colcode.FieldName = "code"
        Me.colcode.MinWidth = 31
        Me.colcode.Name = "colcode"
        Me.colcode.Visible = True
        Me.colcode.VisibleIndex = 1
        Me.colcode.Width = 118
        '
        'colsupOrderID
        '
        Me.colsupOrderID.FieldName = "supOrderID"
        Me.colsupOrderID.MinWidth = 31
        Me.colsupOrderID.Name = "colsupOrderID"
        Me.colsupOrderID.Visible = True
        Me.colsupOrderID.VisibleIndex = 2
        Me.colsupOrderID.Width = 118
        '
        'colemailFrom
        '
        Me.colemailFrom.FieldName = "emailFrom"
        Me.colemailFrom.MinWidth = 31
        Me.colemailFrom.Name = "colemailFrom"
        Me.colemailFrom.Visible = True
        Me.colemailFrom.VisibleIndex = 3
        Me.colemailFrom.Width = 118
        '
        'colemailTo
        '
        Me.colemailTo.FieldName = "emailTo"
        Me.colemailTo.MinWidth = 31
        Me.colemailTo.Name = "colemailTo"
        Me.colemailTo.Visible = True
        Me.colemailTo.VisibleIndex = 4
        Me.colemailTo.Width = 118
        '
        'colemailSubject
        '
        Me.colemailSubject.FieldName = "emailSubject"
        Me.colemailSubject.MinWidth = 31
        Me.colemailSubject.Name = "colemailSubject"
        Me.colemailSubject.Visible = True
        Me.colemailSubject.VisibleIndex = 5
        Me.colemailSubject.Width = 118
        '
        'colemailBody
        '
        Me.colemailBody.FieldName = "emailBody"
        Me.colemailBody.MinWidth = 31
        Me.colemailBody.Name = "colemailBody"
        Me.colemailBody.Visible = True
        Me.colemailBody.VisibleIndex = 6
        Me.colemailBody.Width = 118
        '
        'colemailMode
        '
        Me.colemailMode.FieldName = "emailMode"
        Me.colemailMode.MinWidth = 31
        Me.colemailMode.Name = "colemailMode"
        Me.colemailMode.Visible = True
        Me.colemailMode.VisibleIndex = 7
        Me.colemailMode.Width = 118
        '
        'colDateOfEmail
        '
        Me.colDateOfEmail.FieldName = "DateOfEmail"
        Me.colDateOfEmail.MinWidth = 31
        Me.colDateOfEmail.Name = "colDateOfEmail"
        Me.colDateOfEmail.Visible = True
        Me.colDateOfEmail.VisibleIndex = 8
        Me.colDateOfEmail.Width = 118
        '
        'colcreatedOn
        '
        Me.colcreatedOn.FieldName = "createdOn"
        Me.colcreatedOn.MinWidth = 31
        Me.colcreatedOn.Name = "colcreatedOn"
        Me.colcreatedOn.Visible = True
        Me.colcreatedOn.VisibleIndex = 9
        Me.colcreatedOn.Width = 118
        '
        'colcreatedBy
        '
        Me.colcreatedBy.FieldName = "createdBy"
        Me.colcreatedBy.MinWidth = 31
        Me.colcreatedBy.Name = "colcreatedBy"
        Me.colcreatedBy.Visible = True
        Me.colcreatedBy.VisibleIndex = 10
        Me.colcreatedBy.Width = 118
        '
        'txtSubject
        '
        Me.txtSubject.Location = New System.Drawing.Point(75, 40)
        Me.txtSubject.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtSubject.Name = "txtSubject"
        Me.txtSubject.Size = New System.Drawing.Size(990, 26)
        Me.txtSubject.StyleController = Me.LayoutControl4
        Me.txtSubject.TabIndex = 3
        '
        'LayoutControlGroup31
        '
        Me.LayoutControlGroup31.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup31.GroupBordersVisible = False
        Me.LayoutControlGroup31.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem17, Me.LayoutControlItem18, Me.LayoutControlItem19, Me.LayoutControlItem21, Me.LayoutControlItem22, Me.LayoutControlItem23, Me.EmptySpaceItem4})
        Me.LayoutControlGroup31.Name = "LayoutControlGroup31"
        Me.LayoutControlGroup31.Size = New System.Drawing.Size(1076, 715)
        Me.LayoutControlGroup31.TextVisible = False
        '
        'LayoutControlItem17
        '
        Me.LayoutControlItem17.Control = Me.GridControl2
        Me.LayoutControlItem17.Location = New System.Drawing.Point(0, 296)
        Me.LayoutControlItem17.Name = "LayoutControlItem17"
        Me.LayoutControlItem17.Size = New System.Drawing.Size(1058, 403)
        Me.LayoutControlItem17.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem17.TextVisible = False
        '
        'LayoutControlItem18
        '
        Me.LayoutControlItem18.Control = Me.txtTo
        Me.LayoutControlItem18.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem18.Name = "LayoutControlItem18"
        Me.LayoutControlItem18.Size = New System.Drawing.Size(1058, 30)
        Me.LayoutControlItem18.Text = "Προς"
        Me.LayoutControlItem18.TextSize = New System.Drawing.Size(53, 19)
        '
        'LayoutControlItem19
        '
        Me.LayoutControlItem19.Control = Me.txtBody
        Me.LayoutControlItem19.Location = New System.Drawing.Point(0, 60)
        Me.LayoutControlItem19.Name = "LayoutControlItem19"
        Me.LayoutControlItem19.Size = New System.Drawing.Size(1058, 170)
        Me.LayoutControlItem19.Text = "Κείμενο"
        Me.LayoutControlItem19.TextSize = New System.Drawing.Size(53, 19)
        '
        'LayoutControlItem21
        '
        Me.LayoutControlItem21.Control = Me.txtSubject
        Me.LayoutControlItem21.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem21.CustomizationFormText = "Προς"
        Me.LayoutControlItem21.Location = New System.Drawing.Point(0, 30)
        Me.LayoutControlItem21.Name = "LayoutControlItem21"
        Me.LayoutControlItem21.Size = New System.Drawing.Size(1058, 30)
        Me.LayoutControlItem21.Text = "Θέμα"
        Me.LayoutControlItem21.TextSize = New System.Drawing.Size(53, 19)
        '
        'LayoutControlItem22
        '
        Me.LayoutControlItem22.Control = Me.LabelControl3
        Me.LayoutControlItem22.Location = New System.Drawing.Point(0, 270)
        Me.LayoutControlItem22.Name = "LayoutControlItem22"
        Me.LayoutControlItem22.Size = New System.Drawing.Size(1058, 26)
        Me.LayoutControlItem22.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem22.TextVisible = False
        '
        'LayoutControlItem23
        '
        Me.LayoutControlItem23.Control = Me.cmdSendEmail
        Me.LayoutControlItem23.Location = New System.Drawing.Point(824, 230)
        Me.LayoutControlItem23.Name = "LayoutControlItem23"
        Me.LayoutControlItem23.Size = New System.Drawing.Size(234, 40)
        Me.LayoutControlItem23.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem23.TextVisible = False
        '
        'EmptySpaceItem4
        '
        Me.EmptySpaceItem4.AllowHotTrack = False
        Me.EmptySpaceItem4.Location = New System.Drawing.Point(0, 230)
        Me.EmptySpaceItem4.Name = "EmptySpaceItem4"
        Me.EmptySpaceItem4.Size = New System.Drawing.Size(824, 40)
        Me.EmptySpaceItem4.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem6})
        Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(1098, 735)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.LayoutControl4
        Me.LayoutControlItem6.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(1080, 719)
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem6.TextVisible = False
        '
        'SUP_ORDERS_MAILTableAdapter
        '
        Me.SUP_ORDERS_MAILTableAdapter.ClearBeforeFill = True
        '
        'CCT_TRANSHTableAdapter
        '
        Me.CCT_TRANSHTableAdapter.ClearBeforeFill = True
        '
        'frmSUPOrders
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1098, 783)
        Me.Controls.Add(Me.TabPane1)
        Me.IconOptions.Image = Global.DreamyKitchenCRM.My.Resources.Resources.favicon
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "frmSUPOrders"
        Me.Text = "frmSUPOrders"
        CType(Me.VwCCTBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DreamyKitchenDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DreamyKitchenDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VwORDERMANAGERSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VwSUPBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TabPane1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPane1.ResumeLayout(False)
        Me.TabNavigationPage1.ResumeLayout(False)
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboCUS.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CCTTRANSHBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DM_TRANS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPhn.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtADR.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtOrder.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtOrder.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtArea.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboEMP.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboTRANSH.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboSUP.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtReceipt.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtReceipt.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFileNames.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtComments.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem26, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem27, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem30, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem46, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem31, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem25, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabNavigationPage2.ResumeLayout(False)
        CType(Me.LayoutControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl2.ResumeLayout(False)
        CType(Me.LayoutControl4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl4.ResumeLayout(False)
        CType(Me.txtBody.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SUPORDERSMAILBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DMDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSubject.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup31, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem17, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem18, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem19, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem21, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem22, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem23, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DreamyKitchenDataSetBindingSource As BindingSource
    Friend WithEvents DreamyKitchenDataSet As DreamyKitchenDataSet
    Friend WithEvents VwORDERMANAGERSBindingSource As BindingSource
    Friend WithEvents Vw_ORDER_MANAGERSTableAdapter As DreamyKitchenDataSetTableAdapters.vw_ORDER_MANAGERSTableAdapter
    Friend WithEvents VwSUPBindingSource As BindingSource
    Friend WithEvents Vw_SUPTableAdapter As DreamyKitchenDataSetTableAdapters.vw_SUPTableAdapter
    Friend WithEvents VwCCTBindingSource As BindingSource
    Friend WithEvents Vw_CCTTableAdapter As DreamyKitchenDataSetTableAdapters.vw_CCTTableAdapter
    Friend WithEvents XtraOpenFileDialog1 As DevExpress.XtraEditors.XtraOpenFileDialog
    Friend WithEvents TabPane1 As DevExpress.XtraBars.Navigation.TabPane
    Friend WithEvents TabNavigationPage1 As DevExpress.XtraBars.Navigation.TabNavigationPage
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents cmdExit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cboCUS As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents txtCode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtPhn As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtADR As DevExpress.XtraEditors.TextEdit
    Friend WithEvents dtOrder As DevExpress.XtraEditors.DateEdit
    Friend WithEvents txtArea As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cboEMP As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents cboTRANSH As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents cboSUP As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents dtReceipt As DevExpress.XtraEditors.DateEdit
    Friend WithEvents txtFileNames As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents txtComments As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents Root As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem26 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem27 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem3 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LayoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem30 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LayoutControlItem46 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem31 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem13 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem25 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem14 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents TabNavigationPage2 As DevExpress.XtraBars.Navigation.TabNavigationPage
    Friend WithEvents LayoutControl2 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControl4 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmdSendEmail As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtBody As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents txtTo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents GridControl2 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents txtSubject As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlGroup31 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem17 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem18 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem19 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem21 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem22 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem23 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem4 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents SUPORDERSMAILBindingSource As BindingSource
    Friend WithEvents DMDataSet As DMDataSet
    Friend WithEvents colID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colcode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsupOrderID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colemailFrom As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colemailTo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colemailSubject As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colemailBody As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colemailMode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDateOfEmail As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colcreatedOn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colcreatedBy As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SUP_ORDERS_MAILTableAdapter As DMDataSetTableAdapters.SUP_ORDERS_MAILTableAdapter
    Friend WithEvents CCTTRANSHBindingSource As BindingSource
    Friend WithEvents DM_TRANS As DM_TRANS
    Friend WithEvents CCT_TRANSHTableAdapter As DM_TRANSTableAdapters.CCT_TRANSHTableAdapter
End Class
