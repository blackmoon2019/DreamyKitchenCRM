<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProjectJobs
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProjectJobs))
        Dim EditorButtonImageOptions2 As DevExpress.XtraEditors.Controls.EditorButtonImageOptions = New DevExpress.XtraEditors.Controls.EditorButtonImageOptions()
        Dim SerializableAppearanceObject5 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject6 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject7 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject8 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim EditorButtonImageOptions3 As DevExpress.XtraEditors.Controls.EditorButtonImageOptions = New DevExpress.XtraEditors.Controls.EditorButtonImageOptions()
        Dim SerializableAppearanceObject9 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject10 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject11 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject12 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Me.VwPROJECTJOBSDBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DMDataSet = New DreamyKitchenCRM.DMDataSet()
        Me.Vw_PROJECT_JOBS_DTableAdapter = New DreamyKitchenCRM.DMDataSetTableAdapters.vw_PROJECT_JOBS_DTableAdapter()
        Me.TabPane1 = New DevExpress.XtraBars.Navigation.TabPane()
        Me.TabNavigationPage1 = New DevExpress.XtraBars.Navigation.TabNavigationPage()
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.cboSUP = New DevExpress.XtraEditors.LookUpEdit()
        Me.VwSUPBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DreamyKitchenDataSet = New DreamyKitchenCRM.DreamyKitchenDataSet()
        Me.cmdViewOrder = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdNewProjectJob = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdConvertToOrder = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdPrintAll = New DevExpress.XtraEditors.SimpleButton()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.coldescription = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coldescriptionSup = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colcost = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepCost = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.colcmt = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coltoOrder = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colcompleted = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coldtCompleted = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.chkCompleted = New DevExpress.XtraEditors.CheckEdit()
        Me.chkSER = New DevExpress.XtraEditors.CheckedListBoxControl()
        Me.cmdExit = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdSave = New DevExpress.XtraEditors.SimpleButton()
        Me.cboCUS = New DevExpress.XtraEditors.LookUpEdit()
        Me.CCTTRANSHBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DM_TRANS = New DreamyKitchenCRM.DM_TRANS()
        Me.txtCode = New DevExpress.XtraEditors.TextEdit()
        Me.cboEmp = New DevExpress.XtraEditors.LookUpEdit()
        Me.VwORDERMANAGERSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.txtComments = New DevExpress.XtraEditors.MemoEdit()
        Me.dtVisitDate = New DevExpress.XtraEditors.DateEdit()
        Me.cboTRANSH = New DevExpress.XtraEditors.LookUpEdit()
        Me.txtTmIN = New DevExpress.XtraEditors.TimeEdit()
        Me.txtTmOUT = New DevExpress.XtraEditors.TimeEdit()
        Me.txtComments1 = New DevExpress.XtraEditors.MemoEdit()
        Me.dtInstDeliverDate = New DevExpress.XtraEditors.DateEdit()
        Me.txtfProjectNameComplete = New DevExpress.XtraEditors.ButtonEdit()
        Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem17 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem18 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem12 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem19 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem20 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LCus = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LTransh = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem11 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LTmINFrom = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LTmINTo = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LfInstEllipseName1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem14 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem3 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem10 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.TabNavigationPage2 = New DevExpress.XtraBars.Navigation.TabNavigationPage()
        Me.LayoutControl2 = New DevExpress.XtraLayout.LayoutControl()
        Me.cmdSendEmailComplete = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdDefEmail = New DevExpress.XtraEditors.DropDownButton()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.cmdSendApointmentEmail = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdSendEmail = New DevExpress.XtraEditors.SimpleButton()
        Me.txtBody = New DevExpress.XtraEditors.MemoEdit()
        Me.txtTo = New DevExpress.XtraEditors.TextEdit()
        Me.grdMain = New DevExpress.XtraGrid.GridControl()
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colID1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colcode1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colinstID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colinstEllipseID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colemailFrom = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colemailTo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colemailSubject = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colemailBody = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDateOfEmail = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colcreatedOn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colcreatedBy = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColAttchment = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtImageAttachment = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.txtSubject = New DevExpress.XtraEditors.TextEdit()
        Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem21 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem22 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem23 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem24 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem25 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem26 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem27 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem28 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem29 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.TabNavigationPage3 = New DevExpress.XtraBars.Navigation.TabNavigationPage()
        Me.LayoutControl4 = New DevExpress.XtraLayout.LayoutControl()
        Me.cmdSaveTransF = New DevExpress.XtraEditors.SimpleButton()
        Me.cboTanshFCategory = New DevExpress.XtraEditors.LookUpEdit()
        Me.GridControl2 = New DevExpress.XtraGrid.GridControl()
        Me.GridView4 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colfilename = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colcomefrom = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colextension = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colmodifiedOn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colcreatedOn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coltranshID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colfileCatID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepFileCat = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.colownerID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colbelongsTo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtFiles = New DevExpress.XtraEditors.ButtonEdit()
        Me.LayoutControlGroup11 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem99 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem30 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem31 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem37 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem4 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.Vw_ORDER_MANAGERSTableAdapter = New DreamyKitchenCRM.DreamyKitchenDataSetTableAdapters.vw_ORDER_MANAGERSTableAdapter()
        Me.Vw_SUPTableAdapter = New DreamyKitchenCRM.DreamyKitchenDataSetTableAdapters.vw_SUPTableAdapter()
        Me.CCT_TRANSHTableAdapter = New DreamyKitchenCRM.DM_TRANSTableAdapters.CCT_TRANSHTableAdapter()
        Me.XtraOpenFileDialog1 = New DevExpress.XtraEditors.XtraOpenFileDialog(Me.components)
        CType(Me.VwPROJECTJOBSDBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DMDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TabPane1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPane1.SuspendLayout()
        Me.TabNavigationPage1.SuspendLayout()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.cboSUP.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VwSUPBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DreamyKitchenDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepCost, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkCompleted.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkSER, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboCUS.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CCTTRANSHBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DM_TRANS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboEmp.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VwORDERMANAGERSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtComments.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtVisitDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtVisitDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboTRANSH.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTmIN.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTmOUT.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtComments1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtInstDeliverDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtInstDeliverDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtfProjectNameComplete.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem17, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem18, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem19, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem20, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LCus, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LTransh, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LTmINFrom, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LTmINTo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LfInstEllipseName1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabNavigationPage2.SuspendLayout()
        CType(Me.LayoutControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl2.SuspendLayout()
        CType(Me.txtBody.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdMain, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtImageAttachment, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSubject.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem21, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem22, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem23, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem24, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem25, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem26, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem27, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem28, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem29, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabNavigationPage3.SuspendLayout()
        CType(Me.LayoutControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl4.SuspendLayout()
        CType(Me.cboTanshFCategory.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepFileCat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFiles.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem99, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem30, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem31, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem37, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'VwPROJECTJOBSDBindingSource
        '
        Me.VwPROJECTJOBSDBindingSource.DataMember = "vw_PROJECT_JOBS_D"
        Me.VwPROJECTJOBSDBindingSource.DataSource = Me.DMDataSet
        '
        'DMDataSet
        '
        Me.DMDataSet.DataSetName = "DMDataSet"
        Me.DMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Vw_PROJECT_JOBS_DTableAdapter
        '
        Me.Vw_PROJECT_JOBS_DTableAdapter.ClearBeforeFill = True
        '
        'TabPane1
        '
        Me.TabPane1.Controls.Add(Me.TabNavigationPage1)
        Me.TabPane1.Controls.Add(Me.TabNavigationPage2)
        Me.TabPane1.Controls.Add(Me.TabNavigationPage3)
        Me.TabPane1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabPane1.Location = New System.Drawing.Point(0, 0)
        Me.TabPane1.Name = "TabPane1"
        Me.TabPane1.Pages.AddRange(New DevExpress.XtraBars.Navigation.NavigationPageBase() {Me.TabNavigationPage1, Me.TabNavigationPage2, Me.TabNavigationPage3})
        Me.TabPane1.RegularSize = New System.Drawing.Size(1484, 1144)
        Me.TabPane1.SelectedPage = Me.TabNavigationPage1
        Me.TabPane1.Size = New System.Drawing.Size(1484, 1144)
        Me.TabPane1.TabIndex = 1
        Me.TabPane1.Text = "TabPane1"
        '
        'TabNavigationPage1
        '
        Me.TabNavigationPage1.Caption = "Εργασίες"
        Me.TabNavigationPage1.Controls.Add(Me.LayoutControl1)
        Me.TabNavigationPage1.Name = "TabNavigationPage1"
        Me.TabNavigationPage1.Size = New System.Drawing.Size(1484, 1095)
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.cboSUP)
        Me.LayoutControl1.Controls.Add(Me.cmdViewOrder)
        Me.LayoutControl1.Controls.Add(Me.cmdNewProjectJob)
        Me.LayoutControl1.Controls.Add(Me.cmdConvertToOrder)
        Me.LayoutControl1.Controls.Add(Me.cmdPrintAll)
        Me.LayoutControl1.Controls.Add(Me.GridControl1)
        Me.LayoutControl1.Controls.Add(Me.chkCompleted)
        Me.LayoutControl1.Controls.Add(Me.chkSER)
        Me.LayoutControl1.Controls.Add(Me.cmdExit)
        Me.LayoutControl1.Controls.Add(Me.cmdSave)
        Me.LayoutControl1.Controls.Add(Me.cboCUS)
        Me.LayoutControl1.Controls.Add(Me.txtCode)
        Me.LayoutControl1.Controls.Add(Me.cboEmp)
        Me.LayoutControl1.Controls.Add(Me.txtComments)
        Me.LayoutControl1.Controls.Add(Me.dtVisitDate)
        Me.LayoutControl1.Controls.Add(Me.cboTRANSH)
        Me.LayoutControl1.Controls.Add(Me.txtTmIN)
        Me.LayoutControl1.Controls.Add(Me.txtTmOUT)
        Me.LayoutControl1.Controls.Add(Me.txtComments1)
        Me.LayoutControl1.Controls.Add(Me.dtInstDeliverDate)
        Me.LayoutControl1.Controls.Add(Me.txtfProjectNameComplete)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(1700, 573, 975, 600)
        Me.LayoutControl1.Root = Me.Root
        Me.LayoutControl1.Size = New System.Drawing.Size(1484, 1095)
        Me.LayoutControl1.TabIndex = 2
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'cboSUP
        '
        Me.cboSUP.Location = New System.Drawing.Point(318, 118)
        Me.cboSUP.Margin = New System.Windows.Forms.Padding(4)
        Me.cboSUP.Name = "cboSUP"
        Me.cboSUP.Properties.AllowMouseWheel = False
        Me.cboSUP.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.cboSUP.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Search), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Clear)})
        Me.cboSUP.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 30, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("code", "code", 46, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Fullname", "Προμηθευτές", 77, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ttl", "ttl", 27, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("bal", "bal", 34, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("email", "email", 51, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("site", "site", 37, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default])})
        Me.cboSUP.Properties.DataSource = Me.VwSUPBindingSource
        Me.cboSUP.Properties.DisplayMember = "Fullname"
        Me.cboSUP.Properties.NullText = ""
        Me.cboSUP.Properties.PopupSizeable = False
        Me.cboSUP.Properties.ValueMember = "ID"
        Me.cboSUP.Size = New System.Drawing.Size(1142, 26)
        Me.cboSUP.StyleController = Me.LayoutControl1
        Me.cboSUP.TabIndex = 3
        Me.cboSUP.Tag = "supID,0,1,2"
        '
        'VwSUPBindingSource
        '
        Me.VwSUPBindingSource.DataMember = "vw_SUP"
        Me.VwSUPBindingSource.DataSource = Me.DreamyKitchenDataSet
        '
        'DreamyKitchenDataSet
        '
        Me.DreamyKitchenDataSet.DataSetName = "DreamyKitchenDataSet"
        Me.DreamyKitchenDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'cmdViewOrder
        '
        Me.cmdViewOrder.ImageOptions.Image = CType(resources.GetObject("cmdViewOrder.ImageOptions.Image"), System.Drawing.Image)
        Me.cmdViewOrder.Location = New System.Drawing.Point(448, 1047)
        Me.cmdViewOrder.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdViewOrder.Name = "cmdViewOrder"
        Me.cmdViewOrder.Size = New System.Drawing.Size(238, 36)
        Me.cmdViewOrder.StyleController = Me.LayoutControl1
        Me.cmdViewOrder.TabIndex = 19
        Me.cmdViewOrder.Text = "Προβολή Παραγγελίας"
        '
        'cmdNewProjectJob
        '
        Me.cmdNewProjectJob.ImageOptions.Image = CType(resources.GetObject("cmdNewProjectJob.ImageOptions.Image"), System.Drawing.Image)
        Me.cmdNewProjectJob.Location = New System.Drawing.Point(12, 1047)
        Me.cmdNewProjectJob.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdNewProjectJob.Name = "cmdNewProjectJob"
        Me.cmdNewProjectJob.Size = New System.Drawing.Size(165, 36)
        Me.cmdNewProjectJob.StyleController = Me.LayoutControl1
        Me.cmdNewProjectJob.TabIndex = 52
        Me.cmdNewProjectJob.Text = "Νέα Εγγραφή"
        '
        'cmdConvertToOrder
        '
        Me.cmdConvertToOrder.ImageOptions.Image = Global.DreamyKitchenCRM.My.Resources.Resources.ConvertToOrder24
        Me.cmdConvertToOrder.Location = New System.Drawing.Point(181, 1047)
        Me.cmdConvertToOrder.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdConvertToOrder.Name = "cmdConvertToOrder"
        Me.cmdConvertToOrder.Size = New System.Drawing.Size(263, 32)
        Me.cmdConvertToOrder.StyleController = Me.LayoutControl1
        Me.cmdConvertToOrder.TabIndex = 53
        Me.cmdConvertToOrder.Text = "Μετατροπή σε Παραγγελία"
        '
        'cmdPrintAll
        '
        Me.cmdPrintAll.ImageOptions.Image = CType(resources.GetObject("cmdPrintAll.ImageOptions.Image"), System.Drawing.Image)
        Me.cmdPrintAll.Location = New System.Drawing.Point(690, 1047)
        Me.cmdPrintAll.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdPrintAll.Name = "cmdPrintAll"
        Me.cmdPrintAll.Size = New System.Drawing.Size(200, 36)
        Me.cmdPrintAll.StyleController = Me.LayoutControl1
        Me.cmdPrintAll.TabIndex = 55
        Me.cmdPrintAll.Text = "Έντυπο"
        '
        'GridControl1
        '
        Me.GridControl1.DataSource = Me.VwPROJECTJOBSDBindingSource
        Me.GridControl1.EmbeddedNavigator.Buttons.EndEdit.Visible = False
        Me.GridControl1.EmbeddedNavigator.Buttons.First.Visible = False
        Me.GridControl1.EmbeddedNavigator.Buttons.Last.Visible = False
        Me.GridControl1.EmbeddedNavigator.Buttons.Next.Visible = False
        Me.GridControl1.EmbeddedNavigator.Buttons.NextPage.Visible = False
        Me.GridControl1.EmbeddedNavigator.Buttons.Prev.Visible = False
        Me.GridControl1.EmbeddedNavigator.Buttons.PrevPage.Visible = False
        Me.GridControl1.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.GridControl1.Location = New System.Drawing.Point(12, 625)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepCost})
        Me.GridControl1.Size = New System.Drawing.Size(1460, 418)
        Me.GridControl1.TabIndex = 16
        Me.GridControl1.UseEmbeddedNavigator = True
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.coldescription, Me.coldescriptionSup, Me.colcost, Me.colcmt, Me.coltoOrder, Me.colcompleted, Me.coldtCompleted})
        Me.GridView1.DetailHeight = 289
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsEditForm.PopupEditFormWidth = 720
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'coldescription
        '
        Me.coldescription.Caption = "Περιγραφή"
        Me.coldescription.FieldName = "description"
        Me.coldescription.MinWidth = 30
        Me.coldescription.Name = "coldescription"
        Me.coldescription.Visible = True
        Me.coldescription.VisibleIndex = 0
        Me.coldescription.Width = 112
        '
        'coldescriptionSup
        '
        Me.coldescriptionSup.Caption = "Περιγραφή(Για Παραγγελία)"
        Me.coldescriptionSup.FieldName = "descriptionSup"
        Me.coldescriptionSup.MinWidth = 30
        Me.coldescriptionSup.Name = "coldescriptionSup"
        Me.coldescriptionSup.Visible = True
        Me.coldescriptionSup.VisibleIndex = 1
        Me.coldescriptionSup.Width = 112
        '
        'colcost
        '
        Me.colcost.Caption = "Κόστος"
        Me.colcost.ColumnEdit = Me.RepCost
        Me.colcost.DisplayFormat.FormatString = "{0:n2}€"
        Me.colcost.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colcost.FieldName = "cost"
        Me.colcost.MinWidth = 30
        Me.colcost.Name = "colcost"
        Me.colcost.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "cost", "Σύνολο {0:n2}€")})
        Me.colcost.Visible = True
        Me.colcost.VisibleIndex = 2
        Me.colcost.Width = 112
        '
        'RepCost
        '
        Me.RepCost.AutoHeight = False
        Me.RepCost.DisplayFormat.FormatString = "c"
        Me.RepCost.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.RepCost.EditFormat.FormatString = "n2"
        Me.RepCost.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.RepCost.MaskSettings.Set("MaskManagerType", GetType(DevExpress.Data.Mask.NumericMaskManager))
        Me.RepCost.MaskSettings.Set("mask", "c2")
        Me.RepCost.Name = "RepCost"
        '
        'colcmt
        '
        Me.colcmt.Caption = "Σχόλια"
        Me.colcmt.FieldName = "cmt"
        Me.colcmt.MinWidth = 30
        Me.colcmt.Name = "colcmt"
        Me.colcmt.Visible = True
        Me.colcmt.VisibleIndex = 6
        Me.colcmt.Width = 112
        '
        'coltoOrder
        '
        Me.coltoOrder.Caption = "Προς Παραγγελία"
        Me.coltoOrder.FieldName = "toOrder"
        Me.coltoOrder.MinWidth = 30
        Me.coltoOrder.Name = "coltoOrder"
        Me.coltoOrder.Visible = True
        Me.coltoOrder.VisibleIndex = 3
        Me.coltoOrder.Width = 112
        '
        'colcompleted
        '
        Me.colcompleted.Caption = "Ολοκληρώθηκε"
        Me.colcompleted.FieldName = "completed"
        Me.colcompleted.MinWidth = 30
        Me.colcompleted.Name = "colcompleted"
        Me.colcompleted.Visible = True
        Me.colcompleted.VisibleIndex = 4
        Me.colcompleted.Width = 112
        '
        'coldtCompleted
        '
        Me.coldtCompleted.Caption = "Ημερ/νία Ολοκλήρωσης"
        Me.coldtCompleted.FieldName = "dtCompleted"
        Me.coldtCompleted.MinWidth = 30
        Me.coldtCompleted.Name = "coldtCompleted"
        Me.coldtCompleted.Visible = True
        Me.coldtCompleted.VisibleIndex = 5
        Me.coldtCompleted.Width = 112
        '
        'chkCompleted
        '
        Me.chkCompleted.EditValue = CType(0, Byte)
        Me.chkCompleted.Location = New System.Drawing.Point(1283, 426)
        Me.chkCompleted.Margin = New System.Windows.Forms.Padding(4)
        Me.chkCompleted.Name = "chkCompleted"
        Me.chkCompleted.Properties.Caption = "Ολοκληρώθηκε"
        Me.chkCompleted.Properties.ValueChecked = CType(1, Byte)
        Me.chkCompleted.Properties.ValueUnchecked = CType(0, Byte)
        Me.chkCompleted.Size = New System.Drawing.Size(177, 27)
        Me.chkCompleted.StyleController = Me.LayoutControl1
        Me.chkCompleted.TabIndex = 11
        Me.chkCompleted.Tag = "completed,0,1,2"
        '
        'chkSER
        '
        Me.chkSER.CheckOnClick = True
        Me.chkSER.HorizontalScrollbar = True
        Me.chkSER.Location = New System.Drawing.Point(24, 208)
        Me.chkSER.Margin = New System.Windows.Forms.Padding(4)
        Me.chkSER.Name = "chkSER"
        Me.chkSER.Size = New System.Drawing.Size(1436, 184)
        Me.chkSER.SortOrder = System.Windows.Forms.SortOrder.Ascending
        Me.chkSER.StyleController = Me.LayoutControl1
        Me.chkSER.TabIndex = 7
        Me.chkSER.Tag = ""
        '
        'cmdExit
        '
        Me.cmdExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdExit.ImageOptions.Image = Global.DreamyKitchenCRM.My.Resources.Resources.icons8_exit_24
        Me.cmdExit.Location = New System.Drawing.Point(1237, 1047)
        Me.cmdExit.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(235, 32)
        Me.cmdExit.StyleController = Me.LayoutControl1
        Me.cmdExit.TabIndex = 47
        Me.cmdExit.Text = "Έξοδος"
        '
        'cmdSave
        '
        Me.cmdSave.ImageOptions.Image = Global.DreamyKitchenCRM.My.Resources.Resources.icons8_save_close_24
        Me.cmdSave.Location = New System.Drawing.Point(1260, 577)
        Me.cmdSave.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(200, 32)
        Me.cmdSave.StyleController = Me.LayoutControl1
        Me.cmdSave.TabIndex = 48
        Me.cmdSave.Text = "Αποθήκευση"
        '
        'cboCUS
        '
        Me.cboCUS.Location = New System.Drawing.Point(318, 148)
        Me.cboCUS.Margin = New System.Windows.Forms.Padding(4)
        Me.cboCUS.Name = "cboCUS"
        Me.cboCUS.Properties.AllowMouseWheel = False
        Me.cboCUS.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.cboCUS.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Search), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Clear)})
        Me.cboCUS.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 30, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("code", "code", 46, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Fullname", "Πελάτες", 77, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("FatherName", "Father Name", 103, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CouID", "Cou ID", 63, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("AreaID", "Area ID", 68, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("AdrID", "Adr ID", 61, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("SourceID", "Source ID", 83, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("SalerID", "Saler ID", 70, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("DoyID", "Doy ID", 63, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("PrfID", "Prf ID", 55, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("phn", "phn", 40, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("mob", "mob", 45, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("fax", "fax", 34, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("email", "email", 51, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("afm", "afm", 40, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("cmt", "cmt", 39, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("modifiedBy", "modified By", 97, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("modifiedOn", "modified On", 101, DevExpress.Utils.FormatType.DateTime, "d/M/yyyy", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("createdOn", "created On", 90, DevExpress.Utils.FormatType.DateTime, "d/M/yyyy", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("createdBy", "created By", 86, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default])})
        Me.cboCUS.Properties.DataSource = Me.CCTTRANSHBindingSource
        Me.cboCUS.Properties.DisplayMember = "Fullname"
        Me.cboCUS.Properties.NullText = ""
        Me.cboCUS.Properties.PopupSizeable = False
        Me.cboCUS.Properties.ValueMember = "ID"
        Me.cboCUS.Size = New System.Drawing.Size(1142, 26)
        Me.cboCUS.StyleController = Me.LayoutControl1
        Me.cboCUS.TabIndex = 4
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
        Me.txtCode.Location = New System.Drawing.Point(318, 56)
        Me.txtCode.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCode.Name = "txtCode"
        Me.txtCode.Properties.Appearance.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.txtCode.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtCode.Properties.Appearance.Options.UseBackColor = True
        Me.txtCode.Properties.Appearance.Options.UseFont = True
        Me.txtCode.Properties.ReadOnly = True
        Me.txtCode.Size = New System.Drawing.Size(1142, 28)
        Me.txtCode.StyleController = Me.LayoutControl1
        Me.txtCode.TabIndex = 0
        Me.txtCode.Tag = "code,0"
        '
        'cboEmp
        '
        Me.cboEmp.Location = New System.Drawing.Point(318, 88)
        Me.cboEmp.Margin = New System.Windows.Forms.Padding(4)
        Me.cboEmp.Name = "cboEmp"
        Me.cboEmp.Properties.AllowMouseWheel = False
        Me.cboEmp.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.cboEmp.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Search), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Clear)})
        Me.cboEmp.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 30, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("code", "code", 46, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Fullname", "Υπεύθυνος", 77, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CouID", "Cou ID", 63, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("AreaID", "Area ID", 68, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("AdrID", "Adr ID", 61, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("DoyID", "Doy ID", 63, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("PrfID", "Prf ID", 55, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("salary", "salary", 54, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("hireDate", "hire Date", 77, DevExpress.Utils.FormatType.DateTime, "d/M/yyyy", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("phn", "phn", 40, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("mob", "mob", 45, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("fax", "fax", 34, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("email", "email", 51, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("afm", "afm", 40, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("cmt", "cmt", 39, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("modifiedBy", "modified By", 97, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("modifiedOn", "modified On", 101, DevExpress.Utils.FormatType.DateTime, "d/M/yyyy", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("createdOn", "created On", 90, DevExpress.Utils.FormatType.DateTime, "d/M/yyyy", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("createdBy", "created By", 86, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("RealName", "Real Name", 89, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CouName", "Cou Name", 87, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("AdrName", "Adr Name", 85, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("AreaName", "Area Name", 92, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("DoyName", "Doy Name", 87, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("PrfName", "Prf Name", 79, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("depID", "dep ID", 61, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("DepName", "Dep Name", 87, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Ar", "Ar", 30, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("tk", "tk", 27, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("HasFiles", "Has Files", 75, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("color", "color", 48, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("salerID", "saler ID", 68, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("SalerName", "Saler Name", 94, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("tmIN", "tm IN", 54, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("tmOUT", "tm OUT", 70, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("arProt", "ar Prot", 61, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("profitPerc", "profit Perc", 86, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("JobName", "Job Name", 84, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("jobID", "job ID", 58, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("isActive", "is Active", 72, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("usrName", "usr Name", 81, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("active", "active", 53, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default])})
        Me.cboEmp.Properties.DataSource = Me.VwORDERMANAGERSBindingSource
        Me.cboEmp.Properties.DisplayMember = "Fullname"
        Me.cboEmp.Properties.NullText = ""
        Me.cboEmp.Properties.PopupSizeable = False
        Me.cboEmp.Properties.ValueMember = "ID"
        Me.cboEmp.Size = New System.Drawing.Size(1142, 26)
        Me.cboEmp.StyleController = Me.LayoutControl1
        Me.cboEmp.TabIndex = 2
        Me.cboEmp.Tag = "empID,0,1,2"
        '
        'VwORDERMANAGERSBindingSource
        '
        Me.VwORDERMANAGERSBindingSource.DataMember = "vw_ORDER_MANAGERS"
        Me.VwORDERMANAGERSBindingSource.DataSource = Me.DreamyKitchenDataSet
        '
        'txtComments
        '
        Me.txtComments.Location = New System.Drawing.Point(24, 479)
        Me.txtComments.Margin = New System.Windows.Forms.Padding(4)
        Me.txtComments.Name = "txtComments"
        Me.txtComments.Size = New System.Drawing.Size(717, 94)
        Me.txtComments.StyleController = Me.LayoutControl1
        Me.txtComments.TabIndex = 13
        Me.txtComments.Tag = "cmt,0,1,2"
        '
        'dtVisitDate
        '
        Me.dtVisitDate.EditValue = Nothing
        Me.dtVisitDate.Location = New System.Drawing.Point(318, 396)
        Me.dtVisitDate.Margin = New System.Windows.Forms.Padding(4)
        Me.dtVisitDate.Name = "dtVisitDate"
        Me.dtVisitDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtVisitDate.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtVisitDate.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.dtVisitDate.Size = New System.Drawing.Size(247, 26)
        Me.dtVisitDate.StyleController = Me.LayoutControl1
        Me.dtVisitDate.TabIndex = 8
        Me.dtVisitDate.Tag = "visitDate,0,1,2"
        '
        'cboTRANSH
        '
        Me.cboTRANSH.Location = New System.Drawing.Point(318, 178)
        Me.cboTRANSH.Margin = New System.Windows.Forms.Padding(4)
        Me.cboTRANSH.Name = "cboTRANSH"
        Me.cboTRANSH.Properties.AllowMouseWheel = False
        Me.cboTRANSH.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.cboTRANSH.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Search), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Clear)})
        Me.cboTRANSH.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 30, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("code", "code", 48, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("cusID", "cus ID", 58, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("dtCharge", "dt Charge", 85, DevExpress.Utils.FormatType.DateTime, "d/M/yyyy", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("GRMONTH", "GRMONTH", 88, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("amt", "amt", 40, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("cmt", "cmt", 39, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("modifiedBy", "modified By", 96, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("modifiedOn", "modified On", 99, DevExpress.Utils.FormatType.DateTime, "d/M/yyyy", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("createdOn", "created On", 94, DevExpress.Utils.FormatType.DateTime, "d/M/yyyy", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("createdBy", "created By", 92, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Fullname", "Fullname", 76, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("RealName", "Real Name", 90, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Totamt", "Totamt", 65, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("vatamt", "vatamt", 65, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("bal", "bal", 34, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("SalerName", "Saler Name", 94, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("SalerID", "Saler ID", 70, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("EmpTID", "Emp TID", 74, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("invTypeDescr", "inv Type Descr", 120, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("description", "Περιγραφή Έργου", 92, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("invType", "inv Type", 75, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("empID", "emp ID", 65, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default])})
        Me.cboTRANSH.Properties.DisplayMember = "FullTranshDescription"
        Me.cboTRANSH.Properties.NullText = ""
        Me.cboTRANSH.Properties.PopupSizeable = False
        Me.cboTRANSH.Properties.ValueMember = "ID"
        Me.cboTRANSH.Size = New System.Drawing.Size(684, 26)
        Me.cboTRANSH.StyleController = Me.LayoutControl1
        Me.cboTRANSH.TabIndex = 5
        Me.cboTRANSH.Tag = "transhID,0,1,2"
        '
        'txtTmIN
        '
        Me.txtTmIN.EditValue = New Date(2021, 9, 30, 0, 0, 0, 0)
        Me.txtTmIN.Location = New System.Drawing.Point(746, 396)
        Me.txtTmIN.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTmIN.Name = "txtTmIN"
        Me.txtTmIN.Properties.BeepOnError = True
        Me.txtTmIN.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtTmIN.Properties.MaskSettings.Set("mask", "HH:mm")
        Me.txtTmIN.Properties.TimeEditStyle = DevExpress.XtraEditors.Repository.TimeEditStyle.TouchUI
        Me.txtTmIN.Properties.UseMaskAsDisplayFormat = True
        Me.txtTmIN.Size = New System.Drawing.Size(354, 26)
        Me.txtTmIN.StyleController = Me.LayoutControl1
        Me.txtTmIN.TabIndex = 9
        Me.txtTmIN.Tag = "visitTimeF,0,1,2"
        '
        'txtTmOUT
        '
        Me.txtTmOUT.EditValue = New Date(2021, 9, 30, 0, 0, 0, 0)
        Me.txtTmOUT.Location = New System.Drawing.Point(1140, 396)
        Me.txtTmOUT.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTmOUT.Name = "txtTmOUT"
        Me.txtTmOUT.Properties.BeepOnError = True
        Me.txtTmOUT.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtTmOUT.Properties.MaskSettings.Set("mask", "HH:mm")
        Me.txtTmOUT.Properties.TimeEditStyle = DevExpress.XtraEditors.Repository.TimeEditStyle.TouchUI
        Me.txtTmOUT.Properties.UseMaskAsDisplayFormat = True
        Me.txtTmOUT.Size = New System.Drawing.Size(320, 26)
        Me.txtTmOUT.StyleController = Me.LayoutControl1
        Me.txtTmOUT.TabIndex = 10
        Me.txtTmOUT.Tag = "visitTimeT,0,1,2"
        '
        'txtComments1
        '
        Me.txtComments1.Location = New System.Drawing.Point(745, 479)
        Me.txtComments1.Margin = New System.Windows.Forms.Padding(4)
        Me.txtComments1.Name = "txtComments1"
        Me.txtComments1.Size = New System.Drawing.Size(715, 94)
        Me.txtComments1.StyleController = Me.LayoutControl1
        Me.txtComments1.TabIndex = 14
        Me.txtComments1.Tag = "description,0,1,2"
        '
        'dtInstDeliverDate
        '
        Me.dtInstDeliverDate.EditValue = Nothing
        Me.dtInstDeliverDate.Location = New System.Drawing.Point(1300, 178)
        Me.dtInstDeliverDate.Margin = New System.Windows.Forms.Padding(4)
        Me.dtInstDeliverDate.Name = "dtInstDeliverDate"
        Me.dtInstDeliverDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtInstDeliverDate.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtInstDeliverDate.Properties.ReadOnly = True
        Me.dtInstDeliverDate.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.dtInstDeliverDate.Properties.UseReadOnlyAppearance = False
        Me.dtInstDeliverDate.Size = New System.Drawing.Size(160, 26)
        Me.dtInstDeliverDate.StyleController = Me.LayoutControl1
        Me.dtInstDeliverDate.TabIndex = 6
        Me.dtInstDeliverDate.Tag = ""
        '
        'txtfProjectNameComplete
        '
        Me.txtfProjectNameComplete.Location = New System.Drawing.Point(318, 426)
        Me.txtfProjectNameComplete.Margin = New System.Windows.Forms.Padding(4)
        Me.txtfProjectNameComplete.Name = "txtfProjectNameComplete"
        Me.txtfProjectNameComplete.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        EditorButtonImageOptions2.Image = CType(resources.GetObject("EditorButtonImageOptions2.Image"), System.Drawing.Image)
        Me.txtfProjectNameComplete.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, EditorButtonImageOptions2, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject5, SerializableAppearanceObject6, SerializableAppearanceObject7, SerializableAppearanceObject8, "", Nothing, Nothing, DevExpress.Utils.ToolTipAnchor.[Default]), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete)})
        Me.txtfProjectNameComplete.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.txtfProjectNameComplete.Size = New System.Drawing.Size(961, 26)
        Me.txtfProjectNameComplete.StyleController = Me.LayoutControl1
        Me.txtfProjectNameComplete.TabIndex = 12
        Me.txtfProjectNameComplete.Tag = "fProjectNameComplete,0,1,2"
        '
        'Root
        '
        Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.Root.GroupBordersVisible = False
        Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.EmptySpaceItem2, Me.LayoutControlItem17, Me.LayoutControlItem18, Me.LayoutControlItem12, Me.LayoutControlItem19, Me.LayoutControlGroup1, Me.LayoutControlItem10})
        Me.Root.Name = "Root"
        Me.Root.Size = New System.Drawing.Size(1484, 1095)
        Me.Root.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.cmdExit
        Me.LayoutControlItem1.Location = New System.Drawing.Point(1225, 1035)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(239, 40)
        Me.LayoutControlItem1.Text = "Έξοδος"
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'EmptySpaceItem2
        '
        Me.EmptySpaceItem2.AllowHotTrack = False
        Me.EmptySpaceItem2.Location = New System.Drawing.Point(882, 1035)
        Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Size = New System.Drawing.Size(343, 40)
        Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem17
        '
        Me.LayoutControlItem17.Control = Me.cmdNewProjectJob
        Me.LayoutControlItem17.Location = New System.Drawing.Point(0, 1035)
        Me.LayoutControlItem17.Name = "LayoutControlItem17"
        Me.LayoutControlItem17.Size = New System.Drawing.Size(169, 40)
        Me.LayoutControlItem17.Text = "Νέα Εγγραφή"
        Me.LayoutControlItem17.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem17.TextVisible = False
        '
        'LayoutControlItem18
        '
        Me.LayoutControlItem18.Control = Me.cmdConvertToOrder
        Me.LayoutControlItem18.Location = New System.Drawing.Point(169, 1035)
        Me.LayoutControlItem18.Name = "LayoutControlItem18"
        Me.LayoutControlItem18.Size = New System.Drawing.Size(267, 40)
        Me.LayoutControlItem18.Text = "Μετατροπή σε Παραγγελία"
        Me.LayoutControlItem18.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem18.TextVisible = False
        '
        'LayoutControlItem12
        '
        Me.LayoutControlItem12.Control = Me.cmdViewOrder
        Me.LayoutControlItem12.Location = New System.Drawing.Point(436, 1035)
        Me.LayoutControlItem12.Name = "LayoutControlItem12"
        Me.LayoutControlItem12.Size = New System.Drawing.Size(242, 40)
        Me.LayoutControlItem12.Text = "Προβολή Παραγγελίας"
        Me.LayoutControlItem12.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem12.TextVisible = False
        '
        'LayoutControlItem19
        '
        Me.LayoutControlItem19.Control = Me.cmdPrintAll
        Me.LayoutControlItem19.Location = New System.Drawing.Point(678, 1035)
        Me.LayoutControlItem19.Name = "LayoutControlItem19"
        Me.LayoutControlItem19.Size = New System.Drawing.Size(204, 40)
        Me.LayoutControlItem19.Text = "Έντυπο"
        Me.LayoutControlItem19.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem19.TextVisible = False
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem4, Me.LayoutControlItem7, Me.LayoutControlItem20, Me.LCus, Me.LTransh, Me.LayoutControlItem2, Me.LayoutControlItem8, Me.LayoutControlItem11, Me.LTmINFrom, Me.LTmINTo, Me.LayoutControlItem9, Me.LfInstEllipseName1, Me.LayoutControlItem14, Me.LayoutControlItem6, Me.LayoutControlItem3, Me.EmptySpaceItem3})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(1464, 613)
        Me.LayoutControlGroup1.Text = " "
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.txtCode
        Me.LayoutControlItem4.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem4.CustomizationFormText = "Κωδικός"
        Me.LayoutControlItem4.HighlightFocusedItem = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(1440, 32)
        Me.LayoutControlItem4.Text = "Κωδικός"
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(282, 19)
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.Control = Me.cboEmp
        Me.LayoutControlItem7.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem7.CustomizationFormText = "Υπεύθυνος"
        Me.LayoutControlItem7.HighlightFocusedItem = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlItem7.ImageOptions.Image = CType(resources.GetObject("LayoutControlItem7.ImageOptions.Image"), System.Drawing.Image)
        Me.LayoutControlItem7.Location = New System.Drawing.Point(0, 32)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(1440, 30)
        Me.LayoutControlItem7.Tag = "1"
        Me.LayoutControlItem7.Text = "Υπεύθυνος"
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(282, 19)
        '
        'LayoutControlItem20
        '
        Me.LayoutControlItem20.Control = Me.cboSUP
        Me.LayoutControlItem20.Location = New System.Drawing.Point(0, 62)
        Me.LayoutControlItem20.Name = "LayoutControlItem20"
        Me.LayoutControlItem20.Size = New System.Drawing.Size(1440, 30)
        Me.LayoutControlItem20.Text = "Προμηθευτής"
        Me.LayoutControlItem20.TextSize = New System.Drawing.Size(282, 19)
        '
        'LCus
        '
        Me.LCus.Control = Me.cboCUS
        Me.LCus.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LCus.CustomizationFormText = "Πελάτης"
        Me.LCus.HighlightFocusedItem = DevExpress.Utils.DefaultBoolean.[True]
        Me.LCus.ImageOptions.Image = CType(resources.GetObject("LCus.ImageOptions.Image"), System.Drawing.Image)
        Me.LCus.Location = New System.Drawing.Point(0, 92)
        Me.LCus.Name = "LCus"
        Me.LCus.Size = New System.Drawing.Size(1440, 30)
        Me.LCus.Tag = "1"
        Me.LCus.Text = "Πελάτης"
        Me.LCus.TextSize = New System.Drawing.Size(282, 19)
        '
        'LTransh
        '
        Me.LTransh.Control = Me.cboTRANSH
        Me.LTransh.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LTransh.CustomizationFormText = "Έργο Πελάτη"
        Me.LTransh.HighlightFocusedItem = DevExpress.Utils.DefaultBoolean.[True]
        Me.LTransh.Location = New System.Drawing.Point(0, 122)
        Me.LTransh.Name = "LTransh"
        Me.LTransh.Size = New System.Drawing.Size(982, 30)
        Me.LTransh.Tag = ""
        Me.LTransh.Text = "Έργο Πελάτη"
        Me.LTransh.TextSize = New System.Drawing.Size(282, 19)
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.dtInstDeliverDate
        Me.LayoutControlItem2.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem2.CustomizationFormText = "Ημερ/νία Αρχ. Τοποθέτησης"
        Me.LayoutControlItem2.Location = New System.Drawing.Point(982, 122)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(458, 30)
        Me.LayoutControlItem2.Text = "Ημερ/νία Αρχ. Τοποθέτησης"
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(282, 19)
        '
        'LayoutControlItem8
        '
        Me.LayoutControlItem8.Control = Me.chkSER
        Me.LayoutControlItem8.Location = New System.Drawing.Point(0, 152)
        Me.LayoutControlItem8.Name = "LayoutControlItem8"
        Me.LayoutControlItem8.Size = New System.Drawing.Size(1440, 188)
        Me.LayoutControlItem8.Text = "Συνεργεία"
        Me.LayoutControlItem8.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem8.TextVisible = False
        '
        'LayoutControlItem11
        '
        Me.LayoutControlItem11.Control = Me.dtVisitDate
        Me.LayoutControlItem11.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem11.CustomizationFormText = "Ημερ/νία Επίσκεψης"
        Me.LayoutControlItem11.Location = New System.Drawing.Point(0, 340)
        Me.LayoutControlItem11.Name = "LayoutControlItem11"
        Me.LayoutControlItem11.Size = New System.Drawing.Size(545, 30)
        Me.LayoutControlItem11.Text = "Ημερ/νία Επίσκεψης"
        Me.LayoutControlItem11.TextSize = New System.Drawing.Size(282, 19)
        '
        'LTmINFrom
        '
        Me.LTmINFrom.Control = Me.txtTmIN
        Me.LTmINFrom.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LTmINFrom.CustomizationFormText = "Ώρα Άφιξης(Διάστημα)"
        Me.LTmINFrom.Location = New System.Drawing.Point(545, 340)
        Me.LTmINFrom.Name = "LTmINFrom"
        Me.LTmINFrom.Size = New System.Drawing.Size(535, 30)
        Me.LTmINFrom.Text = "Ώρα Άφιξης(Διάστημα)"
        Me.LTmINFrom.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
        Me.LTmINFrom.TextSize = New System.Drawing.Size(165, 19)
        Me.LTmINFrom.TextToControlDistance = 12
        '
        'LTmINTo
        '
        Me.LTmINTo.Control = Me.txtTmOUT
        Me.LTmINTo.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LTmINTo.CustomizationFormText = "Έως"
        Me.LTmINTo.Location = New System.Drawing.Point(1080, 340)
        Me.LTmINTo.Name = "LTmINTo"
        Me.LTmINTo.Size = New System.Drawing.Size(360, 30)
        Me.LTmINTo.Text = "Έως"
        Me.LTmINTo.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
        Me.LTmINTo.TextSize = New System.Drawing.Size(31, 19)
        Me.LTmINTo.TextToControlDistance = 5
        '
        'LayoutControlItem9
        '
        Me.LayoutControlItem9.Control = Me.chkCompleted
        Me.LayoutControlItem9.Location = New System.Drawing.Point(1259, 370)
        Me.LayoutControlItem9.Name = "LayoutControlItem9"
        Me.LayoutControlItem9.Size = New System.Drawing.Size(181, 31)
        Me.LayoutControlItem9.Text = "Ολοκληρώθηκε"
        Me.LayoutControlItem9.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem9.TextVisible = False
        '
        'LfInstEllipseName1
        '
        Me.LfInstEllipseName1.Control = Me.txtfProjectNameComplete
        Me.LfInstEllipseName1.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LfInstEllipseName1.CustomizationFormText = "Έντυπο Ολοκλήρωσης(Υπογεγραμμένο)"
        Me.LfInstEllipseName1.Location = New System.Drawing.Point(0, 370)
        Me.LfInstEllipseName1.Name = "LfInstEllipseName1"
        Me.LfInstEllipseName1.Size = New System.Drawing.Size(1259, 31)
        Me.LfInstEllipseName1.Text = "Έντυπο Ολοκλήρωσης(Υπογεγραμμένο)"
        Me.LfInstEllipseName1.TextSize = New System.Drawing.Size(282, 19)
        '
        'LayoutControlItem14
        '
        Me.LayoutControlItem14.Control = Me.txtComments
        Me.LayoutControlItem14.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem14.CustomizationFormText = "Σχόλια"
        Me.LayoutControlItem14.HighlightFocusedItem = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlItem14.Location = New System.Drawing.Point(0, 401)
        Me.LayoutControlItem14.Name = "LayoutControlItem14"
        Me.LayoutControlItem14.Size = New System.Drawing.Size(721, 120)
        Me.LayoutControlItem14.Text = "Σχόλια"
        Me.LayoutControlItem14.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem14.TextSize = New System.Drawing.Size(282, 19)
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.txtComments1
        Me.LayoutControlItem6.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem6.CustomizationFormText = "Περιγραφή"
        Me.LayoutControlItem6.HighlightFocusedItem = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlItem6.Location = New System.Drawing.Point(721, 401)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(719, 120)
        Me.LayoutControlItem6.Text = "Περιγραφή"
        Me.LayoutControlItem6.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(282, 19)
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.cmdSave
        Me.LayoutControlItem3.Location = New System.Drawing.Point(1236, 521)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(204, 36)
        Me.LayoutControlItem3.Text = "Αποθήκευση"
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem3.TextVisible = False
        '
        'EmptySpaceItem3
        '
        Me.EmptySpaceItem3.AllowHotTrack = False
        Me.EmptySpaceItem3.Location = New System.Drawing.Point(0, 521)
        Me.EmptySpaceItem3.Name = "EmptySpaceItem3"
        Me.EmptySpaceItem3.Size = New System.Drawing.Size(1236, 36)
        Me.EmptySpaceItem3.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem10
        '
        Me.LayoutControlItem10.Control = Me.GridControl1
        Me.LayoutControlItem10.Location = New System.Drawing.Point(0, 613)
        Me.LayoutControlItem10.Name = "LayoutControlItem10"
        Me.LayoutControlItem10.Size = New System.Drawing.Size(1464, 422)
        Me.LayoutControlItem10.Text = "Εργασίες"
        Me.LayoutControlItem10.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem10.TextVisible = False
        '
        'TabNavigationPage2
        '
        Me.TabNavigationPage2.Caption = "Email"
        Me.TabNavigationPage2.Controls.Add(Me.LayoutControl2)
        Me.TabNavigationPage2.Name = "TabNavigationPage2"
        Me.TabNavigationPage2.Size = New System.Drawing.Size(1484, 1095)
        '
        'LayoutControl2
        '
        Me.LayoutControl2.Controls.Add(Me.cmdSendEmailComplete)
        Me.LayoutControl2.Controls.Add(Me.cmdDefEmail)
        Me.LayoutControl2.Controls.Add(Me.LabelControl3)
        Me.LayoutControl2.Controls.Add(Me.cmdSendApointmentEmail)
        Me.LayoutControl2.Controls.Add(Me.cmdSendEmail)
        Me.LayoutControl2.Controls.Add(Me.txtBody)
        Me.LayoutControl2.Controls.Add(Me.txtTo)
        Me.LayoutControl2.Controls.Add(Me.grdMain)
        Me.LayoutControl2.Controls.Add(Me.txtSubject)
        Me.LayoutControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl2.Name = "LayoutControl2"
        Me.LayoutControl2.Root = Me.LayoutControlGroup2
        Me.LayoutControl2.Size = New System.Drawing.Size(1484, 1095)
        Me.LayoutControl2.TabIndex = 10
        Me.LayoutControl2.Text = "LayoutControl2"
        '
        'cmdSendEmailComplete
        '
        Me.cmdSendEmailComplete.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Success
        Me.cmdSendEmailComplete.Appearance.Options.UseBackColor = True
        Me.cmdSendEmailComplete.ImageOptions.Image = CType(resources.GetObject("cmdSendEmailComplete.ImageOptions.Image"), System.Drawing.Image)
        Me.cmdSendEmailComplete.Location = New System.Drawing.Point(265, 336)
        Me.cmdSendEmailComplete.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdSendEmailComplete.Name = "cmdSendEmailComplete"
        Me.cmdSendEmailComplete.Size = New System.Drawing.Size(483, 36)
        Me.cmdSendEmailComplete.StyleController = Me.LayoutControl2
        Me.cmdSendEmailComplete.TabIndex = 5
        Me.cmdSendEmailComplete.Text = "Αποστολή Email Ολοκλήρωσης Ενημέρωσης Εκκρεμοτήτων"
        '
        'cmdDefEmail
        '
        Me.cmdDefEmail.ImageOptions.Image = CType(resources.GetObject("cmdDefEmail.ImageOptions.Image"), System.Drawing.Image)
        Me.cmdDefEmail.Location = New System.Drawing.Point(12, 336)
        Me.cmdDefEmail.Name = "cmdDefEmail"
        Me.cmdDefEmail.Size = New System.Drawing.Size(249, 36)
        Me.cmdDefEmail.StyleController = Me.LayoutControl2
        Me.cmdDefEmail.TabIndex = 4
        Me.cmdDefEmail.Text = "Προεπιλεγμένο Κείμενο"
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.LabelControl3.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Appearance.Options.UseForeColor = True
        Me.LabelControl3.Location = New System.Drawing.Point(12, 376)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(133, 22)
        Me.LabelControl3.StyleController = Me.LayoutControl2
        Me.LabelControl3.TabIndex = 1
        Me.LabelControl3.Text = "Ιστορικό Email"
        '
        'cmdSendApointmentEmail
        '
        Me.cmdSendApointmentEmail.ImageOptions.Image = CType(resources.GetObject("cmdSendApointmentEmail.ImageOptions.Image"), System.Drawing.Image)
        Me.cmdSendApointmentEmail.Location = New System.Drawing.Point(1133, 336)
        Me.cmdSendApointmentEmail.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdSendApointmentEmail.Name = "cmdSendApointmentEmail"
        Me.cmdSendApointmentEmail.Size = New System.Drawing.Size(339, 36)
        Me.cmdSendApointmentEmail.StyleController = Me.LayoutControl2
        Me.cmdSendApointmentEmail.TabIndex = 7
        Me.cmdSendApointmentEmail.Text = "Αποστολή Email Ενημέρωσης Ραντεβού"
        '
        'cmdSendEmail
        '
        Me.cmdSendEmail.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Question
        Me.cmdSendEmail.Appearance.Options.UseBackColor = True
        Me.cmdSendEmail.ImageOptions.Image = CType(resources.GetObject("cmdSendEmail.ImageOptions.Image"), System.Drawing.Image)
        Me.cmdSendEmail.Location = New System.Drawing.Point(752, 336)
        Me.cmdSendEmail.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdSendEmail.Name = "cmdSendEmail"
        Me.cmdSendEmail.Size = New System.Drawing.Size(377, 36)
        Me.cmdSendEmail.StyleController = Me.LayoutControl2
        Me.cmdSendEmail.TabIndex = 6
        Me.cmdSendEmail.Text = "Αποστολή Email Ενημέρωσης Εκκρεμοτήτων"
        '
        'txtBody
        '
        Me.txtBody.Location = New System.Drawing.Point(77, 72)
        Me.txtBody.Name = "txtBody"
        Me.txtBody.Size = New System.Drawing.Size(1395, 260)
        Me.txtBody.StyleController = Me.LayoutControl2
        Me.txtBody.TabIndex = 3
        '
        'txtTo
        '
        Me.txtTo.Location = New System.Drawing.Point(77, 12)
        Me.txtTo.Name = "txtTo"
        Me.txtTo.Size = New System.Drawing.Size(1395, 26)
        Me.txtTo.StyleController = Me.LayoutControl2
        Me.txtTo.TabIndex = 0
        '
        'grdMain
        '
        Me.grdMain.Cursor = System.Windows.Forms.Cursors.Default
        Me.grdMain.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(4)
        Me.grdMain.Location = New System.Drawing.Point(12, 402)
        Me.grdMain.MainView = Me.GridView3
        Me.grdMain.Margin = New System.Windows.Forms.Padding(4)
        Me.grdMain.Name = "grdMain"
        Me.grdMain.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.txtImageAttachment})
        Me.grdMain.Size = New System.Drawing.Size(1460, 681)
        Me.grdMain.TabIndex = 8
        Me.grdMain.UseEmbeddedNavigator = True
        Me.grdMain.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView3, Me.GridView2})
        '
        'GridView3
        '
        Me.GridView3.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colID1, Me.colcode1, Me.colinstID, Me.colinstEllipseID, Me.colemailFrom, Me.colemailTo, Me.colemailSubject, Me.colemailBody, Me.colDateOfEmail, Me.colcreatedOn, Me.colcreatedBy, Me.ColAttchment})
        Me.GridView3.DetailHeight = 512
        Me.GridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus
        Me.GridView3.GridControl = Me.grdMain
        Me.GridView3.Name = "GridView3"
        Me.GridView3.OptionsBehavior.AutoExpandAllGroups = True
        Me.GridView3.OptionsBehavior.Editable = False
        Me.GridView3.OptionsBehavior.ReadOnly = True
        Me.GridView3.OptionsEditForm.PopupEditFormWidth = 720
        Me.GridView3.OptionsLayout.Columns.StoreAppearance = True
        Me.GridView3.OptionsLayout.StoreAllOptions = True
        Me.GridView3.OptionsLayout.StoreAppearance = True
        Me.GridView3.OptionsLayout.StoreFormatRules = True
        Me.GridView3.OptionsMenu.ShowConditionalFormattingItem = True
        Me.GridView3.OptionsMenu.ShowFooterItem = True
        Me.GridView3.OptionsMenu.ShowGroupSummaryEditorItem = True
        Me.GridView3.OptionsPrint.PrintPreview = True
        Me.GridView3.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView3.OptionsView.ColumnAutoWidth = False
        Me.GridView3.OptionsView.EnableAppearanceEvenRow = True
        Me.GridView3.OptionsView.ShowGroupPanel = False
        '
        'colID1
        '
        Me.colID1.FieldName = "ID"
        Me.colID1.MinWidth = 31
        Me.colID1.Name = "colID1"
        Me.colID1.Visible = True
        Me.colID1.VisibleIndex = 0
        Me.colID1.Width = 118
        '
        'colcode1
        '
        Me.colcode1.FieldName = "code"
        Me.colcode1.MinWidth = 31
        Me.colcode1.Name = "colcode1"
        Me.colcode1.Visible = True
        Me.colcode1.VisibleIndex = 1
        Me.colcode1.Width = 118
        '
        'colinstID
        '
        Me.colinstID.FieldName = "instID"
        Me.colinstID.MinWidth = 31
        Me.colinstID.Name = "colinstID"
        Me.colinstID.Visible = True
        Me.colinstID.VisibleIndex = 2
        Me.colinstID.Width = 118
        '
        'colinstEllipseID
        '
        Me.colinstEllipseID.FieldName = "instEllipseID"
        Me.colinstEllipseID.MinWidth = 31
        Me.colinstEllipseID.Name = "colinstEllipseID"
        Me.colinstEllipseID.Visible = True
        Me.colinstEllipseID.VisibleIndex = 3
        Me.colinstEllipseID.Width = 118
        '
        'colemailFrom
        '
        Me.colemailFrom.FieldName = "emailFrom"
        Me.colemailFrom.MinWidth = 31
        Me.colemailFrom.Name = "colemailFrom"
        Me.colemailFrom.Visible = True
        Me.colemailFrom.VisibleIndex = 4
        Me.colemailFrom.Width = 118
        '
        'colemailTo
        '
        Me.colemailTo.FieldName = "emailTo"
        Me.colemailTo.MinWidth = 31
        Me.colemailTo.Name = "colemailTo"
        Me.colemailTo.Visible = True
        Me.colemailTo.VisibleIndex = 5
        Me.colemailTo.Width = 118
        '
        'colemailSubject
        '
        Me.colemailSubject.FieldName = "emailSubject"
        Me.colemailSubject.MinWidth = 31
        Me.colemailSubject.Name = "colemailSubject"
        Me.colemailSubject.Visible = True
        Me.colemailSubject.VisibleIndex = 6
        Me.colemailSubject.Width = 118
        '
        'colemailBody
        '
        Me.colemailBody.FieldName = "emailBody"
        Me.colemailBody.MinWidth = 31
        Me.colemailBody.Name = "colemailBody"
        Me.colemailBody.Visible = True
        Me.colemailBody.VisibleIndex = 7
        Me.colemailBody.Width = 118
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
        'ColAttchment
        '
        Me.ColAttchment.Caption = "Επισυναπτόμενο"
        Me.ColAttchment.FieldName = "imageCell"
        Me.ColAttchment.ImageOptions.Alignment = System.Drawing.StringAlignment.Center
        Me.ColAttchment.MinWidth = 31
        Me.ColAttchment.Name = "ColAttchment"
        Me.ColAttchment.OptionsColumn.AllowEdit = False
        Me.ColAttchment.OptionsColumn.ReadOnly = True
        Me.ColAttchment.Visible = True
        Me.ColAttchment.VisibleIndex = 11
        Me.ColAttchment.Width = 118
        '
        'txtImageAttachment
        '
        Me.txtImageAttachment.AutoHeight = False
        Me.txtImageAttachment.ContextImageOptions.Image = CType(resources.GetObject("txtImageAttachment.ContextImageOptions.Image"), System.Drawing.Image)
        Me.txtImageAttachment.Name = "txtImageAttachment"
        '
        'GridView2
        '
        Me.GridView2.DetailHeight = 512
        Me.GridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus
        Me.GridView2.GridControl = Me.grdMain
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsBehavior.Editable = False
        Me.GridView2.OptionsBehavior.ReadOnly = True
        Me.GridView2.OptionsEditForm.PopupEditFormWidth = 720
        Me.GridView2.OptionsLayout.Columns.StoreAllOptions = True
        Me.GridView2.OptionsLayout.Columns.StoreAppearance = True
        Me.GridView2.OptionsLayout.StoreAllOptions = True
        Me.GridView2.OptionsLayout.StoreAppearance = True
        Me.GridView2.OptionsLayout.StoreFormatRules = True
        Me.GridView2.OptionsPrint.PrintPreview = True
        Me.GridView2.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView2.OptionsView.ColumnAutoWidth = False
        Me.GridView2.OptionsView.EnableAppearanceEvenRow = True
        '
        'txtSubject
        '
        Me.txtSubject.Location = New System.Drawing.Point(77, 42)
        Me.txtSubject.Name = "txtSubject"
        Me.txtSubject.Size = New System.Drawing.Size(1395, 26)
        Me.txtSubject.StyleController = Me.LayoutControl2
        Me.txtSubject.TabIndex = 2
        '
        'LayoutControlGroup2
        '
        Me.LayoutControlGroup2.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup2.GroupBordersVisible = False
        Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem21, Me.LayoutControlItem22, Me.LayoutControlItem23, Me.LayoutControlItem24, Me.LayoutControlItem25, Me.LayoutControlItem26, Me.LayoutControlItem27, Me.LayoutControlItem28, Me.LayoutControlItem29})
        Me.LayoutControlGroup2.Name = "Root"
        Me.LayoutControlGroup2.Size = New System.Drawing.Size(1484, 1095)
        Me.LayoutControlGroup2.TextVisible = False
        '
        'LayoutControlItem21
        '
        Me.LayoutControlItem21.Control = Me.grdMain
        Me.LayoutControlItem21.Location = New System.Drawing.Point(0, 390)
        Me.LayoutControlItem21.Name = "LayoutControlItem15"
        Me.LayoutControlItem21.Size = New System.Drawing.Size(1464, 685)
        Me.LayoutControlItem21.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem21.TextVisible = False
        '
        'LayoutControlItem22
        '
        Me.LayoutControlItem22.Control = Me.txtTo
        Me.LayoutControlItem22.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem22.Name = "LayoutControlItem16"
        Me.LayoutControlItem22.Size = New System.Drawing.Size(1464, 30)
        Me.LayoutControlItem22.Text = "Προς"
        Me.LayoutControlItem22.TextSize = New System.Drawing.Size(53, 19)
        '
        'LayoutControlItem23
        '
        Me.LayoutControlItem23.Control = Me.txtBody
        Me.LayoutControlItem23.Location = New System.Drawing.Point(0, 60)
        Me.LayoutControlItem23.Name = "LayoutControlItem18"
        Me.LayoutControlItem23.Size = New System.Drawing.Size(1464, 264)
        Me.LayoutControlItem23.Text = "Κείμενο"
        Me.LayoutControlItem23.TextSize = New System.Drawing.Size(53, 19)
        '
        'LayoutControlItem24
        '
        Me.LayoutControlItem24.Control = Me.txtSubject
        Me.LayoutControlItem24.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem24.CustomizationFormText = "Προς"
        Me.LayoutControlItem24.Location = New System.Drawing.Point(0, 30)
        Me.LayoutControlItem24.Name = "LayoutControlItem19"
        Me.LayoutControlItem24.Size = New System.Drawing.Size(1464, 30)
        Me.LayoutControlItem24.Text = "Θέμα"
        Me.LayoutControlItem24.TextSize = New System.Drawing.Size(53, 19)
        '
        'LayoutControlItem25
        '
        Me.LayoutControlItem25.Control = Me.LabelControl3
        Me.LayoutControlItem25.Location = New System.Drawing.Point(0, 364)
        Me.LayoutControlItem25.Name = "LayoutControlItem20"
        Me.LayoutControlItem25.Size = New System.Drawing.Size(1464, 26)
        Me.LayoutControlItem25.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem25.TextVisible = False
        '
        'LayoutControlItem26
        '
        Me.LayoutControlItem26.Control = Me.cmdSendApointmentEmail
        Me.LayoutControlItem26.Location = New System.Drawing.Point(1121, 324)
        Me.LayoutControlItem26.Name = "LayoutControlItem12"
        Me.LayoutControlItem26.Size = New System.Drawing.Size(343, 40)
        Me.LayoutControlItem26.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem26.TextVisible = False
        '
        'LayoutControlItem27
        '
        Me.LayoutControlItem27.Control = Me.cmdDefEmail
        Me.LayoutControlItem27.Location = New System.Drawing.Point(0, 324)
        Me.LayoutControlItem27.Name = "LayoutControlItem17"
        Me.LayoutControlItem27.Size = New System.Drawing.Size(253, 40)
        Me.LayoutControlItem27.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem27.TextVisible = False
        '
        'LayoutControlItem28
        '
        Me.LayoutControlItem28.Control = Me.cmdSendEmail
        Me.LayoutControlItem28.Location = New System.Drawing.Point(740, 324)
        Me.LayoutControlItem28.Name = "LayoutControlItem13"
        Me.LayoutControlItem28.Size = New System.Drawing.Size(381, 40)
        Me.LayoutControlItem28.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem28.TextVisible = False
        '
        'LayoutControlItem29
        '
        Me.LayoutControlItem29.Control = Me.cmdSendEmailComplete
        Me.LayoutControlItem29.Location = New System.Drawing.Point(253, 324)
        Me.LayoutControlItem29.Name = "LayoutControlItem22"
        Me.LayoutControlItem29.Size = New System.Drawing.Size(487, 40)
        Me.LayoutControlItem29.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem29.TextVisible = False
        '
        'TabNavigationPage3
        '
        Me.TabNavigationPage3.Caption = "Αρχεία"
        Me.TabNavigationPage3.Controls.Add(Me.LayoutControl4)
        Me.TabNavigationPage3.Name = "TabNavigationPage3"
        Me.TabNavigationPage3.Size = New System.Drawing.Size(1484, 1095)
        '
        'LayoutControl4
        '
        Me.LayoutControl4.Controls.Add(Me.cmdSaveTransF)
        Me.LayoutControl4.Controls.Add(Me.cboTanshFCategory)
        Me.LayoutControl4.Controls.Add(Me.GridControl2)
        Me.LayoutControl4.Controls.Add(Me.txtFiles)
        Me.LayoutControl4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl4.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl4.Margin = New System.Windows.Forms.Padding(9, 10, 9, 10)
        Me.LayoutControl4.Name = "LayoutControl4"
        Me.LayoutControl4.Root = Me.LayoutControlGroup11
        Me.LayoutControl4.Size = New System.Drawing.Size(1484, 1095)
        Me.LayoutControl4.TabIndex = 1
        Me.LayoutControl4.Text = "LayoutControl4"
        '
        'cmdSaveTransF
        '
        Me.cmdSaveTransF.ImageOptions.Image = Global.DreamyKitchenCRM.My.Resources.Resources.icons8_save_close_24
        Me.cmdSaveTransF.Location = New System.Drawing.Point(1289, 72)
        Me.cmdSaveTransF.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdSaveTransF.Name = "cmdSaveTransF"
        Me.cmdSaveTransF.Size = New System.Drawing.Size(183, 32)
        Me.cmdSaveTransF.StyleController = Me.LayoutControl4
        Me.cmdSaveTransF.TabIndex = 3
        Me.cmdSaveTransF.Text = "Αποθήκευση"
        '
        'cboTanshFCategory
        '
        Me.cboTanshFCategory.Location = New System.Drawing.Point(109, 42)
        Me.cboTanshFCategory.Margin = New System.Windows.Forms.Padding(4)
        Me.cboTanshFCategory.Name = "cboTanshFCategory"
        Me.cboTanshFCategory.Properties.AllowMouseWheel = False
        Me.cboTanshFCategory.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.cboTanshFCategory.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Search), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Clear)})
        Me.cboTanshFCategory.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 31, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("code", "code", 49, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("name", "Κατηγορία", 55, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("modifiedBy", "modified By", 102, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("modifiedOn", "modified On", 105, DevExpress.Utils.FormatType.DateTime, "d/M/yyyy", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("createdOn", "created On", 97, DevExpress.Utils.FormatType.DateTime, "d/M/yyyy", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("createdBy", "created By", 93, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("RealName", "Real Name", 96, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default])})
        Me.cboTanshFCategory.Properties.DisplayMember = "name"
        Me.cboTanshFCategory.Properties.NullText = ""
        Me.cboTanshFCategory.Properties.PopupSizeable = False
        Me.cboTanshFCategory.Properties.ValueMember = "ID"
        Me.cboTanshFCategory.Size = New System.Drawing.Size(1363, 26)
        Me.cboTanshFCategory.StyleController = Me.LayoutControl4
        Me.cboTanshFCategory.TabIndex = 2
        Me.cboTanshFCategory.Tag = "fileCatID,0,1,2"
        '
        'GridControl2
        '
        Me.GridControl2.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(8, 9, 8, 9)
        Me.GridControl2.Location = New System.Drawing.Point(12, 108)
        Me.GridControl2.MainView = Me.GridView4
        Me.GridControl2.Margin = New System.Windows.Forms.Padding(15)
        Me.GridControl2.Name = "GridControl2"
        Me.GridControl2.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepFileCat})
        Me.GridControl2.Size = New System.Drawing.Size(1460, 975)
        Me.GridControl2.TabIndex = 4
        Me.GridControl2.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView4})
        '
        'GridView4
        '
        Me.GridView4.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn6, Me.GridColumn1, Me.colfilename, Me.colcomefrom, Me.colextension, Me.colmodifiedOn1, Me.colcreatedOn1, Me.coltranshID, Me.GridColumn7, Me.GridColumn8, Me.colfileCatID, Me.colownerID, Me.colbelongsTo})
        Me.GridView4.GridControl = Me.GridControl2
        Me.GridView4.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always
        Me.GridView4.Name = "GridView4"
        Me.GridView4.OptionsBehavior.AlignGroupSummaryInGroupRow = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridView4.OptionsEditForm.PopupEditFormWidth = 480
        Me.GridView4.OptionsView.ColumnAutoWidth = False
        Me.GridView4.OptionsView.ShowGroupPanel = False
        Me.GridView4.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colfilename, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'GridColumn6
        '
        Me.GridColumn6.FieldName = "ID"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.OptionsColumn.AllowEdit = False
        '
        'GridColumn1
        '
        Me.GridColumn1.FieldName = "code"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.OptionsColumn.AllowEdit = False
        '
        'colfilename
        '
        Me.colfilename.Caption = "Όνομα Αρχείου"
        Me.colfilename.FieldName = "filename"
        Me.colfilename.Name = "colfilename"
        Me.colfilename.OptionsColumn.AllowEdit = False
        Me.colfilename.Visible = True
        Me.colfilename.VisibleIndex = 1
        Me.colfilename.Width = 468
        '
        'colcomefrom
        '
        Me.colcomefrom.Caption = "Τοποθεσία"
        Me.colcomefrom.FieldName = "comefrom"
        Me.colcomefrom.Name = "colcomefrom"
        Me.colcomefrom.OptionsColumn.AllowEdit = False
        Me.colcomefrom.Visible = True
        Me.colcomefrom.VisibleIndex = 2
        Me.colcomefrom.Width = 213
        '
        'colextension
        '
        Me.colextension.Caption = "Επέκταση"
        Me.colextension.FieldName = "extension"
        Me.colextension.Name = "colextension"
        Me.colextension.OptionsColumn.AllowEdit = False
        Me.colextension.Visible = True
        Me.colextension.VisibleIndex = 3
        Me.colextension.Width = 115
        '
        'colmodifiedOn1
        '
        Me.colmodifiedOn1.FieldName = "modifiedOn"
        Me.colmodifiedOn1.Name = "colmodifiedOn1"
        Me.colmodifiedOn1.OptionsColumn.AllowEdit = False
        '
        'colcreatedOn1
        '
        Me.colcreatedOn1.FieldName = "createdOn"
        Me.colcreatedOn1.Name = "colcreatedOn1"
        Me.colcreatedOn1.OptionsColumn.AllowEdit = False
        '
        'coltranshID
        '
        Me.coltranshID.AppearanceCell.BackColor = System.Drawing.Color.Bisque
        Me.coltranshID.AppearanceCell.Options.UseBackColor = True
        Me.coltranshID.Caption = "transhID"
        Me.coltranshID.FieldName = "transhID"
        Me.coltranshID.MinWidth = 33
        Me.coltranshID.Name = "coltranshID"
        Me.coltranshID.OptionsColumn.AllowEdit = False
        '
        'GridColumn7
        '
        Me.GridColumn7.AppearanceCell.BackColor = System.Drawing.Color.Bisque
        Me.GridColumn7.AppearanceCell.Options.UseBackColor = True
        Me.GridColumn7.Caption = "modifiedBy"
        Me.GridColumn7.FieldName = "modifiedBy"
        Me.GridColumn7.MinWidth = 33
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.OptionsColumn.AllowEdit = False
        '
        'GridColumn8
        '
        Me.GridColumn8.AppearanceCell.BackColor = System.Drawing.Color.Bisque
        Me.GridColumn8.AppearanceCell.Options.UseBackColor = True
        Me.GridColumn8.Caption = "createdBy"
        Me.GridColumn8.FieldName = "createdBy"
        Me.GridColumn8.MinWidth = 33
        Me.GridColumn8.Name = "GridColumn8"
        Me.GridColumn8.OptionsColumn.AllowEdit = False
        '
        'colfileCatID
        '
        Me.colfileCatID.AppearanceCell.BackColor = System.Drawing.Color.Bisque
        Me.colfileCatID.AppearanceCell.Options.UseBackColor = True
        Me.colfileCatID.Caption = "Κατηγορία"
        Me.colfileCatID.ColumnEdit = Me.RepFileCat
        Me.colfileCatID.FieldName = "fileCatID"
        Me.colfileCatID.MinWidth = 30
        Me.colfileCatID.Name = "colfileCatID"
        Me.colfileCatID.Visible = True
        Me.colfileCatID.VisibleIndex = 0
        Me.colfileCatID.Width = 112
        '
        'RepFileCat
        '
        Me.RepFileCat.AutoHeight = False
        Me.RepFileCat.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepFileCat.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 30, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("code", "code", 46, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("name", "Κατηγορία", 52, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("modifiedBy", "modified By", 97, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("modifiedOn", "modified On", 101, DevExpress.Utils.FormatType.DateTime, "d/M/yyyy", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("createdOn", "created On", 90, DevExpress.Utils.FormatType.DateTime, "d/M/yyyy", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("createdBy", "created By", 86, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("RealName", "Real Name", 89, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default])})
        Me.RepFileCat.DisplayMember = "name"
        Me.RepFileCat.Name = "RepFileCat"
        Me.RepFileCat.NullText = ""
        Me.RepFileCat.ValueMember = "ID"
        '
        'colownerID
        '
        Me.colownerID.AppearanceCell.BackColor = System.Drawing.Color.Bisque
        Me.colownerID.AppearanceCell.Options.UseBackColor = True
        Me.colownerID.Caption = "ownerID"
        Me.colownerID.FieldName = "ownerID"
        Me.colownerID.MinWidth = 30
        Me.colownerID.Name = "colownerID"
        Me.colownerID.OptionsColumn.AllowEdit = False
        Me.colownerID.Width = 112
        '
        'colbelongsTo
        '
        Me.colbelongsTo.AppearanceCell.BackColor = System.Drawing.Color.Bisque
        Me.colbelongsTo.AppearanceCell.Options.UseBackColor = True
        Me.colbelongsTo.Caption = "Προέλευση"
        Me.colbelongsTo.FieldName = "belongsTo"
        Me.colbelongsTo.MinWidth = 30
        Me.colbelongsTo.Name = "colbelongsTo"
        Me.colbelongsTo.OptionsColumn.AllowEdit = False
        Me.colbelongsTo.Visible = True
        Me.colbelongsTo.VisibleIndex = 4
        Me.colbelongsTo.Width = 112
        '
        'txtFiles
        '
        Me.txtFiles.Location = New System.Drawing.Point(109, 12)
        Me.txtFiles.Margin = New System.Windows.Forms.Padding(4)
        Me.txtFiles.Name = "txtFiles"
        Me.txtFiles.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        EditorButtonImageOptions3.Image = Global.DreamyKitchenCRM.My.Resources.Resources.icons8_scanner_16
        Me.txtFiles.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, EditorButtonImageOptions3, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject9, SerializableAppearanceObject10, SerializableAppearanceObject11, SerializableAppearanceObject12, "", Nothing, Nothing, DevExpress.Utils.ToolTipAnchor.[Default]), New DevExpress.XtraEditors.Controls.EditorButton(), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete)})
        Me.txtFiles.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.txtFiles.Size = New System.Drawing.Size(1363, 26)
        Me.txtFiles.StyleController = Me.LayoutControl4
        Me.txtFiles.TabIndex = 0
        Me.txtFiles.Tag = ""
        '
        'LayoutControlGroup11
        '
        Me.LayoutControlGroup11.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup11.GroupBordersVisible = False
        Me.LayoutControlGroup11.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem99, Me.LayoutControlItem30, Me.LayoutControlItem31, Me.LayoutControlItem37, Me.EmptySpaceItem4})
        Me.LayoutControlGroup11.Name = "Root"
        Me.LayoutControlGroup11.Size = New System.Drawing.Size(1484, 1095)
        Me.LayoutControlGroup11.TextVisible = False
        '
        'LayoutControlItem99
        '
        Me.LayoutControlItem99.Control = Me.GridControl2
        Me.LayoutControlItem99.Location = New System.Drawing.Point(0, 96)
        Me.LayoutControlItem99.Name = "LayoutControlItem99"
        Me.LayoutControlItem99.Size = New System.Drawing.Size(1464, 979)
        Me.LayoutControlItem99.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem99.TextVisible = False
        '
        'LayoutControlItem30
        '
        Me.LayoutControlItem30.Control = Me.txtFiles
        Me.LayoutControlItem30.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem30.CustomizationFormText = "Αρχεία"
        Me.LayoutControlItem30.HighlightFocusedItem = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlItem30.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem30.Name = "LayoutControlItem22"
        Me.LayoutControlItem30.Size = New System.Drawing.Size(1464, 30)
        Me.LayoutControlItem30.Text = "Αρχεία"
        Me.LayoutControlItem30.TextSize = New System.Drawing.Size(85, 19)
        '
        'LayoutControlItem31
        '
        Me.LayoutControlItem31.Control = Me.cboTanshFCategory
        Me.LayoutControlItem31.ImageOptions.Image = Global.DreamyKitchenCRM.My.Resources.Resources.rsz_11rsz_asterisk
        Me.LayoutControlItem31.Location = New System.Drawing.Point(0, 30)
        Me.LayoutControlItem31.Name = "LayoutControlItem25"
        Me.LayoutControlItem31.Size = New System.Drawing.Size(1464, 30)
        Me.LayoutControlItem31.Tag = "1"
        Me.LayoutControlItem31.Text = "Κατηγορία"
        Me.LayoutControlItem31.TextSize = New System.Drawing.Size(85, 19)
        '
        'LayoutControlItem37
        '
        Me.LayoutControlItem37.Control = Me.cmdSaveTransF
        Me.LayoutControlItem37.Location = New System.Drawing.Point(1277, 60)
        Me.LayoutControlItem37.Name = "LayoutControlItem37"
        Me.LayoutControlItem37.Size = New System.Drawing.Size(187, 36)
        Me.LayoutControlItem37.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem37.TextVisible = False
        '
        'EmptySpaceItem4
        '
        Me.EmptySpaceItem4.AllowHotTrack = False
        Me.EmptySpaceItem4.Location = New System.Drawing.Point(0, 60)
        Me.EmptySpaceItem4.Name = "EmptySpaceItem4"
        Me.EmptySpaceItem4.Size = New System.Drawing.Size(1277, 36)
        Me.EmptySpaceItem4.TextSize = New System.Drawing.Size(0, 0)
        '
        'Vw_ORDER_MANAGERSTableAdapter
        '
        Me.Vw_ORDER_MANAGERSTableAdapter.ClearBeforeFill = True
        '
        'Vw_SUPTableAdapter
        '
        Me.Vw_SUPTableAdapter.ClearBeforeFill = True
        '
        'CCT_TRANSHTableAdapter
        '
        Me.CCT_TRANSHTableAdapter.ClearBeforeFill = True
        '
        'XtraOpenFileDialog1
        '
        Me.XtraOpenFileDialog1.Multiselect = True
        Me.XtraOpenFileDialog1.Title = "Επιλογή αρχείων"
        '
        'frmProjectJobs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1484, 1144)
        Me.Controls.Add(Me.TabPane1)
        Me.IconOptions.Image = Global.DreamyKitchenCRM.My.Resources.Resources.favicon
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "frmProjectJobs"
        Me.Text = "Εργασίες"
        CType(Me.VwPROJECTJOBSDBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DMDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TabPane1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPane1.ResumeLayout(False)
        Me.TabNavigationPage1.ResumeLayout(False)
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.cboSUP.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VwSUPBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DreamyKitchenDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepCost, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkCompleted.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkSER, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboCUS.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CCTTRANSHBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DM_TRANS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboEmp.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VwORDERMANAGERSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtComments.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtVisitDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtVisitDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboTRANSH.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTmIN.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTmOUT.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtComments1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtInstDeliverDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtInstDeliverDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtfProjectNameComplete.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem17, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem18, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem19, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem20, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LCus, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LTransh, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LTmINFrom, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LTmINTo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LfInstEllipseName1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabNavigationPage2.ResumeLayout(False)
        CType(Me.LayoutControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl2.ResumeLayout(False)
        CType(Me.txtBody.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdMain, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtImageAttachment, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSubject.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem21, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem22, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem23, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem24, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem25, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem26, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem27, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem28, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem29, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabNavigationPage3.ResumeLayout(False)
        CType(Me.LayoutControl4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl4.ResumeLayout(False)
        CType(Me.cboTanshFCategory.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepFileCat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFiles.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem99, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem30, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem31, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem37, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DMDataSet As DMDataSet
    Friend WithEvents VwPROJECTJOBSDBindingSource As BindingSource
    Friend WithEvents Vw_PROJECT_JOBS_DTableAdapter As DMDataSetTableAdapters.vw_PROJECT_JOBS_DTableAdapter
    Friend WithEvents TabPane1 As DevExpress.XtraBars.Navigation.TabPane
    Friend WithEvents TabNavigationPage1 As DevExpress.XtraBars.Navigation.TabNavigationPage
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents cmdViewOrder As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdNewProjectJob As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdConvertToOrder As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdPrintAll As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents coldescription As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldescriptionSup As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colcost As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colcmt As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coltoOrder As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colcompleted As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldtCompleted As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents chkCompleted As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkSER As DevExpress.XtraEditors.CheckedListBoxControl
    Friend WithEvents cmdExit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cboCUS As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents txtCode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cboEmp As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents txtComments As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents dtVisitDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents cboTRANSH As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents txtTmIN As DevExpress.XtraEditors.TimeEdit
    Friend WithEvents txtTmOUT As DevExpress.XtraEditors.TimeEdit
    Friend WithEvents txtComments1 As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents dtInstDeliverDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents txtfProjectNameComplete As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents Root As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LCus As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LTransh As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LTmINFrom As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LTmINTo As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem11 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem10 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem14 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LfInstEllipseName1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem17 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem18 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem12 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem19 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents TabNavigationPage2 As DevExpress.XtraBars.Navigation.TabNavigationPage
    Friend WithEvents TabNavigationPage3 As DevExpress.XtraBars.Navigation.TabNavigationPage
    Friend WithEvents cboSUP As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LayoutControlItem20 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControl2 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents cmdSendEmailComplete As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdDefEmail As DevExpress.XtraEditors.DropDownButton
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmdSendApointmentEmail As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdSendEmail As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtBody As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents txtTo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents grdMain As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colID1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colcode1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colinstID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colinstEllipseID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colemailFrom As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colemailTo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colemailSubject As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colemailBody As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDateOfEmail As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colcreatedOn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colcreatedBy As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColAttchment As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtImageAttachment As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents txtSubject As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem21 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem22 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem23 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem24 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem25 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem26 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem27 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem28 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem29 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControl4 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents cmdSaveTransF As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cboTanshFCategory As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents GridControl2 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView4 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colfilename As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colcomefrom As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colextension As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colmodifiedOn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colcreatedOn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coltranshID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colfileCatID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepFileCat As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents colownerID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colbelongsTo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtFiles As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents LayoutControlGroup11 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem99 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem30 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem31 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem37 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem4 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents DreamyKitchenDataSet As DreamyKitchenDataSet
    Friend WithEvents VwORDERMANAGERSBindingSource As BindingSource
    Friend WithEvents Vw_ORDER_MANAGERSTableAdapter As DreamyKitchenDataSetTableAdapters.vw_ORDER_MANAGERSTableAdapter
    Friend WithEvents VwSUPBindingSource As BindingSource
    Friend WithEvents Vw_SUPTableAdapter As DreamyKitchenDataSetTableAdapters.vw_SUPTableAdapter
    Friend WithEvents DM_TRANS As DM_TRANS
    Friend WithEvents CCTTRANSHBindingSource As BindingSource
    Friend WithEvents CCT_TRANSHTableAdapter As DM_TRANSTableAdapters.CCT_TRANSHTableAdapter
    Friend WithEvents EmptySpaceItem3 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents RepCost As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents XtraOpenFileDialog1 As DevExpress.XtraEditors.XtraOpenFileDialog
End Class
