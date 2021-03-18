<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmOffer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmOffer))
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.grdMain = New DevExpress.XtraGrid.GridControl()
        Me.VwERMBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DreamyKitchenDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DreamyKitchenDataSet = New DreamyKitchenCRM.DreamyKitchenDataSet()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colcode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCustomCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colname = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colcatErmName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colheight = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coldoorName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colcat = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colwidth = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coldepth = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coldoor = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPrice = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colphoto = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPVCcolorName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBoxColorName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBoxColorPhoto = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDoorTypeID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colcatErmID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colcalculations = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDoorPrice = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.cmdSaveOff = New DevExpress.XtraEditors.SimpleButton()
        Me.TextEdit2 = New DevExpress.XtraEditors.TextEdit()
        Me.txtQTY = New DevExpress.XtraEditors.TextEdit()
        Me.chkMech = New DevExpress.XtraEditors.CheckedListBoxControl()
        Me.txtCou = New DevExpress.XtraEditors.TextEdit()
        Me.cmdSave = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdExit = New DevExpress.XtraEditors.SimpleButton()
        Me.cboCUS = New DevExpress.XtraEditors.LookUpEdit()
        Me.txtCode = New DevExpress.XtraEditors.TextEdit()
        Me.txtPhn = New DevExpress.XtraEditors.TextEdit()
        Me.txtMob = New DevExpress.XtraEditors.TextEdit()
        Me.txtAR = New DevExpress.XtraEditors.TextEdit()
        Me.txtComments = New DevExpress.XtraEditors.MemoEdit()
        Me.txtHeight = New DevExpress.XtraEditors.TextEdit()
        Me.txtDepth = New DevExpress.XtraEditors.TextEdit()
        Me.txtWidth = New DevExpress.XtraEditors.TextEdit()
        Me.txtDoor = New DevExpress.XtraEditors.TextEdit()
        Me.txtPrice = New DevExpress.XtraEditors.TextEdit()
        Me.txtCustomCode = New DevExpress.XtraEditors.TextEdit()
        Me.cboCategory = New DevExpress.XtraEditors.LookUpEdit()
        Me.txtADR = New DevExpress.XtraEditors.TextEdit()
        Me.txtArea = New DevExpress.XtraEditors.TextEdit()
        Me.txtTK = New DevExpress.XtraEditors.TextEdit()
        Me.cboPVCColors = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.VwCOLORSPVCBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridLookUpEdit2View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colID2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colname2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colphoto2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cboBOXColors = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.VwCOLORSBOXBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridLookUpEdit2View1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colID1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colname1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colphoto1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PictureEdit2 = New DevExpress.XtraEditors.PictureEdit()
        Me.chkDimChanged = New DevExpress.XtraEditors.CheckEdit()
        Me.cboERM = New DevExpress.XtraEditors.LookUpEdit()
        Me.txtDoor1 = New DevExpress.XtraEditors.TextEdit()
        Me.cboBENCH = New DevExpress.XtraEditors.LookUpEdit()
        Me.cboSides = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.cboDim = New DevExpress.XtraEditors.LookUpEdit()
        Me.dtpresentation = New DevExpress.XtraEditors.DateEdit()
        Me.txtCalc = New DevExpress.XtraEditors.TextEdit()
        Me.txtTotalPrice = New DevExpress.XtraEditors.TextEdit()
        Me.cmdCalc = New DevExpress.XtraEditors.SimpleButton()
        Me.txtDepth1 = New DevExpress.XtraEditors.TextEdit()
        Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem13 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem12 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem17 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem18 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem10 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem30 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem19 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem31 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem3 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem8 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem39 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem11 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem11 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem15 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem56 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem52 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem14 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem5 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem16 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem22 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem21 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem23 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem20 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem24 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem26 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.SimpleLabelItem1 = New DevExpress.XtraLayout.SimpleLabelItem()
        Me.LayoutControlItem25 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem29 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem40 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem28 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem27 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem42 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem41 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem43 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.Vw_ERMTableAdapter = New DreamyKitchenCRM.DreamyKitchenDataSetTableAdapters.vw_ERMTableAdapter()
        Me.Vw_COLORSBOXTableAdapter = New DreamyKitchenCRM.DreamyKitchenDataSetTableAdapters.vw_COLORSBOXTableAdapter()
        Me.Vw_COLORSPVCTableAdapter = New DreamyKitchenCRM.DreamyKitchenDataSetTableAdapters.vw_COLORSPVCTableAdapter()
        Me.OFFERSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OFFERSTableAdapter = New DreamyKitchenCRM.DreamyKitchenDataSetTableAdapters.vw_OFFERSTableAdapter()
        Me.LayoutControl2 = New DevExpress.XtraLayout.LayoutControl()
        Me.cmdOffersRefresh = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdOffersEdit = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdOffersDel = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdOffersNew = New DevExpress.XtraEditors.SimpleButton()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colID3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colqty = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colheight1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colwidth1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coldepth1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coldoor1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colphoto3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collegs = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPrice1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDoorTypeName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coloffID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colcatErmID1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colermID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cmdSameOffer = New DevExpress.XtraEditors.SimpleButton()
        Me.chkDoorTypes = New DevExpress.XtraEditors.CheckedListBoxControl()
        Me.VwDOORTYPEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LayoutControlGroup3 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem32 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.SimpleLabelItem2 = New DevExpress.XtraLayout.SimpleLabelItem()
        Me.LayoutControlItem33 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem34 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem35 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem9 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem10 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem36 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem37 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem38 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.Vw_DOOR_TYPETableAdapter = New DreamyKitchenCRM.DreamyKitchenDataSetTableAdapters.vw_DOOR_TYPETableAdapter()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdMain, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VwERMBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DreamyKitchenDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DreamyKitchenDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.TextEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtQTY.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkMech, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCou.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboCUS.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPhn.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMob.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAR.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtComments.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtHeight.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDepth.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtWidth.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDoor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPrice.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCustomCode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboCategory.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtADR.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtArea.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTK.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboPVCColors.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VwCOLORSPVCBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLookUpEdit2View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboBOXColors.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VwCOLORSBOXBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLookUpEdit2View1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkDimChanged.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboERM.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDoor1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboBENCH.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboSides.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboDim.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpresentation.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpresentation.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCalc.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTotalPrice.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDepth1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem17, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem18, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem30, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem19, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem31, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem39, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem56, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem52, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem22, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem21, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem23, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem20, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem24, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem26, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SimpleLabelItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem25, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem29, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem40, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem28, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem27, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem42, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem41, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem43, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OFFERSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl2.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkDoorTypes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VwDOORTYPEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem32, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SimpleLabelItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem33, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem34, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem35, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem36, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem37, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem38, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GridView2
        '
        Me.GridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus
        Me.GridView2.GridControl = Me.grdMain
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsBehavior.Editable = False
        Me.GridView2.OptionsBehavior.ReadOnly = True
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
        'grdMain
        '
        Me.grdMain.Cursor = System.Windows.Forms.Cursors.Default
        Me.grdMain.DataSource = Me.VwERMBindingSource
        Me.grdMain.Location = New System.Drawing.Point(24, 218)
        Me.grdMain.MainView = Me.GridView1
        Me.grdMain.Name = "grdMain"
        Me.grdMain.Size = New System.Drawing.Size(976, 259)
        Me.grdMain.TabIndex = 43
        Me.grdMain.UseEmbeddedNavigator = True
        Me.grdMain.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1, Me.GridView2})
        '
        'VwERMBindingSource
        '
        Me.VwERMBindingSource.DataMember = "vw_ERM"
        Me.VwERMBindingSource.DataSource = Me.DreamyKitchenDataSetBindingSource
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
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colID, Me.colcode, Me.colCustomCode, Me.colname, Me.colcatErmName, Me.colheight, Me.coldoorName, Me.colcat, Me.colwidth, Me.coldepth, Me.coldoor, Me.colPrice, Me.colphoto, Me.colPVCcolorName, Me.colBoxColorName, Me.colBoxColorPhoto, Me.colDoorTypeID, Me.colcatErmID, Me.colcalculations, Me.colDoorPrice})
        Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus
        Me.GridView1.GridControl = Me.grdMain
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsBehavior.ReadOnly = True
        Me.GridView1.OptionsLayout.Columns.StoreAppearance = True
        Me.GridView1.OptionsLayout.StoreAllOptions = True
        Me.GridView1.OptionsLayout.StoreAppearance = True
        Me.GridView1.OptionsLayout.StoreFormatRules = True
        Me.GridView1.OptionsPrint.PrintPreview = True
        Me.GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.EnableAppearanceEvenRow = True
        '
        'colID
        '
        Me.colID.FieldName = "ID"
        Me.colID.Name = "colID"
        Me.colID.Visible = True
        Me.colID.VisibleIndex = 0
        '
        'colcode
        '
        Me.colcode.FieldName = "code"
        Me.colcode.Name = "colcode"
        Me.colcode.Visible = True
        Me.colcode.VisibleIndex = 1
        '
        'colCustomCode
        '
        Me.colCustomCode.FieldName = "CustomCode"
        Me.colCustomCode.Name = "colCustomCode"
        Me.colCustomCode.Visible = True
        Me.colCustomCode.VisibleIndex = 2
        '
        'colname
        '
        Me.colname.FieldName = "name"
        Me.colname.Name = "colname"
        Me.colname.Visible = True
        Me.colname.VisibleIndex = 3
        '
        'colcatErmName
        '
        Me.colcatErmName.FieldName = "catErmName"
        Me.colcatErmName.Name = "colcatErmName"
        Me.colcatErmName.Visible = True
        Me.colcatErmName.VisibleIndex = 4
        '
        'colheight
        '
        Me.colheight.FieldName = "height"
        Me.colheight.Name = "colheight"
        Me.colheight.Visible = True
        Me.colheight.VisibleIndex = 5
        '
        'coldoorName
        '
        Me.coldoorName.FieldName = "doorName"
        Me.coldoorName.Name = "coldoorName"
        Me.coldoorName.Visible = True
        Me.coldoorName.VisibleIndex = 6
        '
        'colcat
        '
        Me.colcat.FieldName = "cat"
        Me.colcat.Name = "colcat"
        Me.colcat.Visible = True
        Me.colcat.VisibleIndex = 7
        '
        'colwidth
        '
        Me.colwidth.FieldName = "width"
        Me.colwidth.Name = "colwidth"
        Me.colwidth.Visible = True
        Me.colwidth.VisibleIndex = 8
        '
        'coldepth
        '
        Me.coldepth.FieldName = "depth"
        Me.coldepth.Name = "coldepth"
        Me.coldepth.Visible = True
        Me.coldepth.VisibleIndex = 9
        '
        'coldoor
        '
        Me.coldoor.FieldName = "door"
        Me.coldoor.Name = "coldoor"
        Me.coldoor.Visible = True
        Me.coldoor.VisibleIndex = 10
        '
        'colPrice
        '
        Me.colPrice.FieldName = "Price"
        Me.colPrice.Name = "colPrice"
        Me.colPrice.Visible = True
        Me.colPrice.VisibleIndex = 11
        '
        'colphoto
        '
        Me.colphoto.FieldName = "photo"
        Me.colphoto.Name = "colphoto"
        Me.colphoto.Visible = True
        Me.colphoto.VisibleIndex = 12
        '
        'colPVCcolorName
        '
        Me.colPVCcolorName.FieldName = "PVCcolorName"
        Me.colPVCcolorName.Name = "colPVCcolorName"
        Me.colPVCcolorName.Visible = True
        Me.colPVCcolorName.VisibleIndex = 13
        '
        'colBoxColorName
        '
        Me.colBoxColorName.FieldName = "BoxColorName"
        Me.colBoxColorName.Name = "colBoxColorName"
        Me.colBoxColorName.Visible = True
        Me.colBoxColorName.VisibleIndex = 14
        '
        'colBoxColorPhoto
        '
        Me.colBoxColorPhoto.FieldName = "BoxColorPhoto"
        Me.colBoxColorPhoto.Name = "colBoxColorPhoto"
        Me.colBoxColorPhoto.Visible = True
        Me.colBoxColorPhoto.VisibleIndex = 15
        '
        'colDoorTypeID
        '
        Me.colDoorTypeID.FieldName = "DoorTypeID"
        Me.colDoorTypeID.Name = "colDoorTypeID"
        '
        'colcatErmID
        '
        Me.colcatErmID.FieldName = "catErmID"
        Me.colcatErmID.Name = "colcatErmID"
        '
        'colcalculations
        '
        Me.colcalculations.FieldName = "calculations"
        Me.colcalculations.Name = "colcalculations"
        '
        'colDoorPrice
        '
        Me.colDoorPrice.FieldName = "DoorPrice"
        Me.colDoorPrice.Name = "colDoorPrice"
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.cmdSaveOff)
        Me.LayoutControl1.Controls.Add(Me.TextEdit2)
        Me.LayoutControl1.Controls.Add(Me.txtQTY)
        Me.LayoutControl1.Controls.Add(Me.chkMech)
        Me.LayoutControl1.Controls.Add(Me.txtCou)
        Me.LayoutControl1.Controls.Add(Me.grdMain)
        Me.LayoutControl1.Controls.Add(Me.cmdSave)
        Me.LayoutControl1.Controls.Add(Me.cmdExit)
        Me.LayoutControl1.Controls.Add(Me.cboCUS)
        Me.LayoutControl1.Controls.Add(Me.txtCode)
        Me.LayoutControl1.Controls.Add(Me.txtPhn)
        Me.LayoutControl1.Controls.Add(Me.txtMob)
        Me.LayoutControl1.Controls.Add(Me.txtAR)
        Me.LayoutControl1.Controls.Add(Me.txtComments)
        Me.LayoutControl1.Controls.Add(Me.txtHeight)
        Me.LayoutControl1.Controls.Add(Me.txtDepth)
        Me.LayoutControl1.Controls.Add(Me.txtWidth)
        Me.LayoutControl1.Controls.Add(Me.txtDoor)
        Me.LayoutControl1.Controls.Add(Me.txtPrice)
        Me.LayoutControl1.Controls.Add(Me.txtCustomCode)
        Me.LayoutControl1.Controls.Add(Me.cboCategory)
        Me.LayoutControl1.Controls.Add(Me.txtADR)
        Me.LayoutControl1.Controls.Add(Me.txtArea)
        Me.LayoutControl1.Controls.Add(Me.txtTK)
        Me.LayoutControl1.Controls.Add(Me.cboPVCColors)
        Me.LayoutControl1.Controls.Add(Me.cboBOXColors)
        Me.LayoutControl1.Controls.Add(Me.PictureEdit2)
        Me.LayoutControl1.Controls.Add(Me.chkDimChanged)
        Me.LayoutControl1.Controls.Add(Me.cboERM)
        Me.LayoutControl1.Controls.Add(Me.txtDoor1)
        Me.LayoutControl1.Controls.Add(Me.cboBENCH)
        Me.LayoutControl1.Controls.Add(Me.cboSides)
        Me.LayoutControl1.Controls.Add(Me.cboDim)
        Me.LayoutControl1.Controls.Add(Me.dtpresentation)
        Me.LayoutControl1.Controls.Add(Me.txtCalc)
        Me.LayoutControl1.Controls.Add(Me.txtTotalPrice)
        Me.LayoutControl1.Controls.Add(Me.cmdCalc)
        Me.LayoutControl1.Controls.Add(Me.txtDepth1)
        Me.LayoutControl1.Location = New System.Drawing.Point(1, -7)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.Root = Me.Root
        Me.LayoutControl1.Size = New System.Drawing.Size(1024, 841)
        Me.LayoutControl1.TabIndex = 0
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'cmdSaveOff
        '
        Me.cmdSaveOff.ImageOptions.Image = Global.DreamyKitchenCRM.My.Resources.Resources.icons8_save_close_24
        Me.cmdSaveOff.Location = New System.Drawing.Point(847, 117)
        Me.cmdSaveOff.Name = "cmdSaveOff"
        Me.cmdSaveOff.Size = New System.Drawing.Size(153, 28)
        Me.cmdSaveOff.StyleController = Me.LayoutControl1
        Me.cmdSaveOff.TabIndex = 51
        Me.cmdSaveOff.Text = "Αποθήκευση Προσφοράς"
        '
        'TextEdit2
        '
        Me.TextEdit2.Location = New System.Drawing.Point(783, 45)
        Me.TextEdit2.Name = "TextEdit2"
        Me.TextEdit2.Properties.ReadOnly = True
        Me.TextEdit2.Properties.UseReadOnlyAppearance = False
        Me.TextEdit2.Size = New System.Drawing.Size(154, 20)
        Me.TextEdit2.StyleController = Me.LayoutControl1
        Me.TextEdit2.TabIndex = 50
        Me.TextEdit2.Tag = "delivery,0,1,2"
        '
        'txtQTY
        '
        Me.txtQTY.EditValue = "1"
        Me.txtQTY.Location = New System.Drawing.Point(149, 745)
        Me.txtQTY.Name = "txtQTY"
        Me.txtQTY.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtQTY.Properties.EditFormat.FormatString = "n0"
        Me.txtQTY.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtQTY.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtQTY.Properties.MaskSettings.Set("MaskManagerType", GetType(DevExpress.Data.Mask.NumericMaskManager))
        Me.txtQTY.Properties.MaskSettings.Set("mask", "n0")
        Me.txtQTY.Properties.Tag = "qty"
        Me.txtQTY.Size = New System.Drawing.Size(50, 20)
        Me.txtQTY.StyleController = Me.LayoutControl1
        Me.txtQTY.TabIndex = 49
        Me.txtQTY.Tag = "qty,0,1,2"
        '
        'chkMech
        '
        Me.chkMech.CheckOnClick = True
        Me.chkMech.HorizontalScrollbar = True
        Me.chkMech.Location = New System.Drawing.Point(371, 546)
        Me.chkMech.Name = "chkMech"
        Me.chkMech.Size = New System.Drawing.Size(243, 171)
        Me.chkMech.SortOrder = System.Windows.Forms.SortOrder.Ascending
        Me.chkMech.StyleController = Me.LayoutControl1
        Me.chkMech.TabIndex = 48
        Me.chkMech.Tag = ""
        '
        'txtCou
        '
        Me.txtCou.Location = New System.Drawing.Point(59, 93)
        Me.txtCou.Name = "txtCou"
        Me.txtCou.Properties.ReadOnly = True
        Me.txtCou.Properties.UseReadOnlyAppearance = False
        Me.txtCou.Size = New System.Drawing.Size(197, 20)
        Me.txtCou.StyleController = Me.LayoutControl1
        Me.txtCou.TabIndex = 44
        Me.txtCou.Tag = "COU_name"
        '
        'cmdSave
        '
        Me.cmdSave.ImageOptions.Image = Global.DreamyKitchenCRM.My.Resources.Resources.icons8_save_close_24
        Me.cmdSave.Location = New System.Drawing.Point(728, 801)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(141, 28)
        Me.cmdSave.StyleController = Me.LayoutControl1
        Me.cmdSave.TabIndex = 22
        Me.cmdSave.Text = "Αποθήκευση Ερμάριου"
        '
        'cmdExit
        '
        Me.cmdExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdExit.ImageOptions.Image = Global.DreamyKitchenCRM.My.Resources.Resources.icons8_exit_24
        Me.cmdExit.Location = New System.Drawing.Point(873, 801)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(139, 28)
        Me.cmdExit.StyleController = Me.LayoutControl1
        Me.cmdExit.TabIndex = 21
        Me.cmdExit.Text = "Έξοδος"
        '
        'cboCUS
        '
        Me.cboCUS.Location = New System.Drawing.Point(78, 69)
        Me.cboCUS.Name = "cboCUS"
        Me.cboCUS.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.cboCUS.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Search), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Clear)})
        Me.cboCUS.Properties.NullText = ""
        Me.cboCUS.Properties.PopupSizeable = False
        Me.cboCUS.Size = New System.Drawing.Size(232, 20)
        Me.cboCUS.StyleController = Me.LayoutControl1
        Me.cboCUS.TabIndex = 5
        Me.cboCUS.Tag = "cusID,0,1,2"
        '
        'txtCode
        '
        Me.txtCode.Location = New System.Drawing.Point(125, 45)
        Me.txtCode.Name = "txtCode"
        Me.txtCode.Properties.Appearance.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.txtCode.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtCode.Properties.Appearance.Options.UseBackColor = True
        Me.txtCode.Properties.Appearance.Options.UseFont = True
        Me.txtCode.Properties.ReadOnly = True
        Me.txtCode.Size = New System.Drawing.Size(75, 20)
        Me.txtCode.StyleController = Me.LayoutControl1
        Me.txtCode.TabIndex = 4
        Me.txtCode.Tag = "code,0"
        '
        'txtPhn
        '
        Me.txtPhn.Location = New System.Drawing.Point(522, 69)
        Me.txtPhn.Name = "txtPhn"
        Me.txtPhn.Properties.ReadOnly = True
        Me.txtPhn.Properties.UseReadOnlyAppearance = False
        Me.txtPhn.Size = New System.Drawing.Size(132, 20)
        Me.txtPhn.StyleController = Me.LayoutControl1
        Me.txtPhn.TabIndex = 22
        Me.txtPhn.Tag = "phn"
        '
        'txtMob
        '
        Me.txtMob.Location = New System.Drawing.Point(350, 69)
        Me.txtMob.Name = "txtMob"
        Me.txtMob.Properties.ReadOnly = True
        Me.txtMob.Properties.UseReadOnlyAppearance = False
        Me.txtMob.Size = New System.Drawing.Size(112, 20)
        Me.txtMob.StyleController = Me.LayoutControl1
        Me.txtMob.TabIndex = 23
        Me.txtMob.Tag = "mob"
        '
        'txtAR
        '
        Me.txtAR.Location = New System.Drawing.Point(701, 93)
        Me.txtAR.Name = "txtAR"
        Me.txtAR.Properties.ReadOnly = True
        Me.txtAR.Properties.UseReadOnlyAppearance = False
        Me.txtAR.Size = New System.Drawing.Size(70, 20)
        Me.txtAR.StyleController = Me.LayoutControl1
        Me.txtAR.TabIndex = 10
        Me.txtAR.Tag = "ar"
        '
        'txtComments
        '
        Me.txtComments.Location = New System.Drawing.Point(149, 769)
        Me.txtComments.Name = "txtComments"
        Me.txtComments.Size = New System.Drawing.Size(393, 16)
        Me.txtComments.StyleController = Me.LayoutControl1
        Me.txtComments.TabIndex = 17
        Me.txtComments.Tag = "comments,0,1,2"
        '
        'txtHeight
        '
        Me.txtHeight.EditValue = "0,00 €"
        Me.txtHeight.Location = New System.Drawing.Point(149, 553)
        Me.txtHeight.Name = "txtHeight"
        Me.txtHeight.Properties.DisplayFormat.FormatString = "n"
        Me.txtHeight.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtHeight.Properties.EditFormat.FormatString = "n2"
        Me.txtHeight.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtHeight.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtHeight.Properties.MaskSettings.Set("MaskManagerType", GetType(DevExpress.Data.Mask.NumericMaskManager))
        Me.txtHeight.Properties.MaskSettings.Set("mask", "n2")
        Me.txtHeight.Size = New System.Drawing.Size(218, 20)
        Me.txtHeight.StyleController = Me.LayoutControl1
        Me.txtHeight.TabIndex = 42
        Me.txtHeight.Tag = "height,0,1,2"
        '
        'txtDepth
        '
        Me.txtDepth.EditValue = "0,00 €"
        Me.txtDepth.Location = New System.Drawing.Point(149, 601)
        Me.txtDepth.Name = "txtDepth"
        Me.txtDepth.Properties.DisplayFormat.FormatString = "n"
        Me.txtDepth.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtDepth.Properties.EditFormat.FormatString = "n2"
        Me.txtDepth.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtDepth.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtDepth.Properties.MaskSettings.Set("MaskManagerType", GetType(DevExpress.Data.Mask.NumericMaskManager))
        Me.txtDepth.Properties.MaskSettings.Set("mask", "n2")
        Me.txtDepth.Size = New System.Drawing.Size(218, 20)
        Me.txtDepth.StyleController = Me.LayoutControl1
        Me.txtDepth.TabIndex = 42
        Me.txtDepth.Tag = "depth,0,1,2"
        '
        'txtWidth
        '
        Me.txtWidth.EditValue = "0,00"
        Me.txtWidth.Location = New System.Drawing.Point(149, 577)
        Me.txtWidth.Name = "txtWidth"
        Me.txtWidth.Properties.DisplayFormat.FormatString = "n"
        Me.txtWidth.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtWidth.Properties.EditFormat.FormatString = "n2"
        Me.txtWidth.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtWidth.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtWidth.Properties.MaskSettings.Set("MaskManagerType", GetType(DevExpress.Data.Mask.NumericMaskManager))
        Me.txtWidth.Properties.MaskSettings.Set("mask", "n2")
        Me.txtWidth.Size = New System.Drawing.Size(218, 20)
        Me.txtWidth.StyleController = Me.LayoutControl1
        Me.txtWidth.TabIndex = 42
        Me.txtWidth.Tag = "width,0,1,2"
        '
        'txtDoor
        '
        Me.txtDoor.EditValue = "0"
        Me.txtDoor.Location = New System.Drawing.Point(149, 649)
        Me.txtDoor.Name = "txtDoor"
        Me.txtDoor.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtDoor.Properties.EditFormat.FormatString = "n0"
        Me.txtDoor.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtDoor.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtDoor.Properties.MaskSettings.Set("MaskManagerType", GetType(DevExpress.Data.Mask.NumericMaskManager))
        Me.txtDoor.Properties.MaskSettings.Set("mask", "n0")
        Me.txtDoor.Size = New System.Drawing.Size(218, 20)
        Me.txtDoor.StyleController = Me.LayoutControl1
        Me.txtDoor.TabIndex = 37
        Me.txtDoor.Tag = "door,0,1,2"
        '
        'txtPrice
        '
        Me.txtPrice.EditValue = "0,00 €"
        Me.txtPrice.Location = New System.Drawing.Point(286, 721)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Properties.DisplayFormat.FormatString = "c"
        Me.txtPrice.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtPrice.Properties.EditFormat.FormatString = "n2"
        Me.txtPrice.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtPrice.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtPrice.Properties.MaskSettings.Set("MaskManagerType", GetType(DevExpress.Data.Mask.NumericMaskManager))
        Me.txtPrice.Properties.MaskSettings.Set("mask", "c2")
        Me.txtPrice.Size = New System.Drawing.Size(77, 20)
        Me.txtPrice.StyleController = Me.LayoutControl1
        Me.txtPrice.TabIndex = 42
        Me.txtPrice.Tag = "price,0,1,2"
        '
        'txtCustomCode
        '
        Me.txtCustomCode.Location = New System.Drawing.Point(316, 45)
        Me.txtCustomCode.Name = "txtCustomCode"
        Me.txtCustomCode.Properties.Appearance.BackColor = System.Drawing.SystemColors.Info
        Me.txtCustomCode.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtCustomCode.Properties.Appearance.Options.UseBackColor = True
        Me.txtCustomCode.Properties.Appearance.Options.UseFont = True
        Me.txtCustomCode.Size = New System.Drawing.Size(80, 20)
        Me.txtCustomCode.StyleController = Me.LayoutControl1
        Me.txtCustomCode.TabIndex = 4
        Me.txtCustomCode.Tag = "CustomCode,0,1,2"
        '
        'cboCategory
        '
        Me.cboCategory.Location = New System.Drawing.Point(149, 194)
        Me.cboCategory.Name = "cboCategory"
        Me.cboCategory.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.cboCategory.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Search), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Clear)})
        Me.cboCategory.Properties.NullText = ""
        Me.cboCategory.Properties.PopupSizeable = False
        Me.cboCategory.Size = New System.Drawing.Size(212, 20)
        Me.cboCategory.StyleController = Me.LayoutControl1
        Me.cboCategory.TabIndex = 21
        Me.cboCategory.Tag = ""
        '
        'txtADR
        '
        Me.txtADR.Location = New System.Drawing.Point(521, 93)
        Me.txtADR.Name = "txtADR"
        Me.txtADR.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.txtADR.Properties.ReadOnly = True
        Me.txtADR.Properties.UseReadOnlyAppearance = False
        Me.txtADR.Size = New System.Drawing.Size(133, 20)
        Me.txtADR.StyleController = Me.LayoutControl1
        Me.txtADR.TabIndex = 7
        Me.txtADR.Tag = "ADR_name"
        '
        'txtArea
        '
        Me.txtArea.Location = New System.Drawing.Point(310, 93)
        Me.txtArea.Name = "txtArea"
        Me.txtArea.Properties.ReadOnly = True
        Me.txtArea.Properties.UseReadOnlyAppearance = False
        Me.txtArea.Size = New System.Drawing.Size(152, 20)
        Me.txtArea.StyleController = Me.LayoutControl1
        Me.txtArea.TabIndex = 44
        Me.txtArea.Tag = "AREAS_name"
        '
        'txtTK
        '
        Me.txtTK.Location = New System.Drawing.Point(701, 69)
        Me.txtTK.Name = "txtTK"
        Me.txtTK.Properties.ReadOnly = True
        Me.txtTK.Properties.UseReadOnlyAppearance = False
        Me.txtTK.Size = New System.Drawing.Size(70, 20)
        Me.txtTK.StyleController = Me.LayoutControl1
        Me.txtTK.TabIndex = 10
        Me.txtTK.Tag = "tk"
        '
        'cboPVCColors
        '
        Me.cboPVCColors.EditValue = ""
        Me.cboPVCColors.Location = New System.Drawing.Point(393, 505)
        Me.cboPVCColors.Name = "cboPVCColors"
        Me.cboPVCColors.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Search), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Clear)})
        Me.cboPVCColors.Properties.DataSource = Me.VwCOLORSPVCBindingSource
        Me.cboPVCColors.Properties.DisplayMember = "name"
        Me.cboPVCColors.Properties.NullText = ""
        Me.cboPVCColors.Properties.PopupView = Me.GridLookUpEdit2View
        Me.cboPVCColors.Properties.ValueMember = "ID"
        Me.cboPVCColors.Size = New System.Drawing.Size(221, 20)
        Me.cboPVCColors.StyleController = Me.LayoutControl1
        Me.cboPVCColors.TabIndex = 45
        Me.cboPVCColors.Tag = "pvcColorID,0,1,2"
        '
        'VwCOLORSPVCBindingSource
        '
        Me.VwCOLORSPVCBindingSource.DataMember = "vw_COLORSPVC"
        Me.VwCOLORSPVCBindingSource.DataSource = Me.DreamyKitchenDataSetBindingSource
        '
        'GridLookUpEdit2View
        '
        Me.GridLookUpEdit2View.Appearance.Row.Options.UseImage = True
        Me.GridLookUpEdit2View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colID2, Me.colname2, Me.colphoto2})
        Me.GridLookUpEdit2View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridLookUpEdit2View.Name = "GridLookUpEdit2View"
        Me.GridLookUpEdit2View.OptionsCustomization.AllowRowSizing = True
        Me.GridLookUpEdit2View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridLookUpEdit2View.OptionsView.ShowGroupPanel = False
        Me.GridLookUpEdit2View.RowHeight = 64
        '
        'colID2
        '
        Me.colID2.FieldName = "ID"
        Me.colID2.Name = "colID2"
        '
        'colname2
        '
        Me.colname2.Caption = "Κωδικός"
        Me.colname2.FieldName = "name"
        Me.colname2.Name = "colname2"
        Me.colname2.Visible = True
        Me.colname2.VisibleIndex = 0
        '
        'colphoto2
        '
        Me.colphoto2.Caption = "Φωτογραφία"
        Me.colphoto2.FieldName = "photo"
        Me.colphoto2.Name = "colphoto2"
        Me.colphoto2.Visible = True
        Me.colphoto2.VisibleIndex = 1
        '
        'cboBOXColors
        '
        Me.cboBOXColors.EditValue = ""
        Me.cboBOXColors.Location = New System.Drawing.Point(149, 505)
        Me.cboBOXColors.Name = "cboBOXColors"
        Me.cboBOXColors.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Search), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Clear)})
        Me.cboBOXColors.Properties.DataSource = Me.VwCOLORSBOXBindingSource
        Me.cboBOXColors.Properties.DisplayMember = "name"
        Me.cboBOXColors.Properties.NullText = ""
        Me.cboBOXColors.Properties.PopupView = Me.GridLookUpEdit2View1
        Me.cboBOXColors.Properties.ValueMember = "ID"
        Me.cboBOXColors.Size = New System.Drawing.Size(181, 20)
        Me.cboBOXColors.StyleController = Me.LayoutControl1
        Me.cboBOXColors.TabIndex = 45
        Me.cboBOXColors.Tag = "boxColorID,0,1,2"
        '
        'VwCOLORSBOXBindingSource
        '
        Me.VwCOLORSBOXBindingSource.DataMember = "vw_COLORSBOX"
        Me.VwCOLORSBOXBindingSource.DataSource = Me.DreamyKitchenDataSetBindingSource
        '
        'GridLookUpEdit2View1
        '
        Me.GridLookUpEdit2View1.Appearance.Row.Options.UseImage = True
        Me.GridLookUpEdit2View1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colID1, Me.colname1, Me.colphoto1})
        Me.GridLookUpEdit2View1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridLookUpEdit2View1.Name = "GridLookUpEdit2View1"
        Me.GridLookUpEdit2View1.OptionsCustomization.AllowRowSizing = True
        Me.GridLookUpEdit2View1.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridLookUpEdit2View1.OptionsView.ShowGroupPanel = False
        Me.GridLookUpEdit2View1.RowHeight = 64
        '
        'colID1
        '
        Me.colID1.FieldName = "ID"
        Me.colID1.Name = "colID1"
        '
        'colname1
        '
        Me.colname1.Caption = "Κωδικός"
        Me.colname1.FieldName = "name"
        Me.colname1.Name = "colname1"
        Me.colname1.Visible = True
        Me.colname1.VisibleIndex = 0
        '
        'colphoto1
        '
        Me.colphoto1.Caption = "Φωτογραφία"
        Me.colphoto1.FieldName = "photo"
        Me.colphoto1.Name = "colphoto1"
        Me.colphoto1.Visible = True
        Me.colphoto1.VisibleIndex = 1
        '
        'PictureEdit2
        '
        Me.PictureEdit2.Location = New System.Drawing.Point(618, 497)
        Me.PictureEdit2.Name = "PictureEdit2"
        Me.PictureEdit2.Properties.PictureStoreMode = DevExpress.XtraEditors.Controls.PictureStoreMode.ByteArray
        Me.PictureEdit2.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Always
        Me.PictureEdit2.Properties.ShowScrollBars = True
        Me.PictureEdit2.Properties.ShowZoomSubMenu = DevExpress.Utils.DefaultBoolean.[True]
        Me.PictureEdit2.Size = New System.Drawing.Size(382, 288)
        Me.PictureEdit2.StyleController = Me.LayoutControl1
        Me.PictureEdit2.TabIndex = 44
        Me.PictureEdit2.Tag = "photo,0,1,2"
        '
        'chkDimChanged
        '
        Me.chkDimChanged.EditValue = CType(0, Byte)
        Me.chkDimChanged.Location = New System.Drawing.Point(24, 481)
        Me.chkDimChanged.Name = "chkDimChanged"
        Me.chkDimChanged.Properties.Appearance.BackColor = System.Drawing.Color.LightSlateGray
        Me.chkDimChanged.Properties.Appearance.ForeColor = System.Drawing.Color.White
        Me.chkDimChanged.Properties.Appearance.Options.UseBackColor = True
        Me.chkDimChanged.Properties.Appearance.Options.UseForeColor = True
        Me.chkDimChanged.Properties.Caption = "Αλλαγή Διαστάσεων"
        Me.chkDimChanged.Properties.Tag = "dimChanged"
        Me.chkDimChanged.Properties.ValueChecked = CType(1, Byte)
        Me.chkDimChanged.Properties.ValueUnchecked = CType(0, Byte)
        Me.chkDimChanged.Size = New System.Drawing.Size(120, 20)
        Me.chkDimChanged.StyleController = Me.LayoutControl1
        Me.chkDimChanged.TabIndex = 46
        Me.chkDimChanged.Tag = "dimChanged,0,1,2"
        '
        'cboERM
        '
        Me.cboERM.Location = New System.Drawing.Point(185, 481)
        Me.cboERM.Name = "cboERM"
        Me.cboERM.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.cboERM.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Search), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Clear)})
        Me.cboERM.Properties.NullText = ""
        Me.cboERM.Properties.PopupSizeable = False
        Me.cboERM.Properties.ReadOnly = True
        Me.cboERM.Properties.Tag = "ErmID"
        Me.cboERM.Properties.UseReadOnlyAppearance = False
        Me.cboERM.Size = New System.Drawing.Size(145, 20)
        Me.cboERM.StyleController = Me.LayoutControl1
        Me.cboERM.TabIndex = 21
        Me.cboERM.Tag = "ErmID,0,1,2"
        '
        'txtDoor1
        '
        Me.txtDoor1.EditValue = "0"
        Me.txtDoor1.Location = New System.Drawing.Point(149, 673)
        Me.txtDoor1.Name = "txtDoor1"
        Me.txtDoor1.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtDoor1.Properties.EditFormat.FormatString = "n0"
        Me.txtDoor1.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtDoor1.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtDoor1.Properties.MaskSettings.Set("MaskManagerType", GetType(DevExpress.Data.Mask.NumericMaskManager))
        Me.txtDoor1.Properties.MaskSettings.Set("mask", "n0")
        Me.txtDoor1.Size = New System.Drawing.Size(218, 20)
        Me.txtDoor1.StyleController = Me.LayoutControl1
        Me.txtDoor1.TabIndex = 37
        Me.txtDoor1.Tag = "legs,0,1,2"
        '
        'cboBENCH
        '
        Me.cboBENCH.Location = New System.Drawing.Point(149, 697)
        Me.cboBENCH.Name = "cboBENCH"
        Me.cboBENCH.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.cboBENCH.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Search), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Clear)})
        Me.cboBENCH.Properties.NullText = ""
        Me.cboBENCH.Properties.PopupSizeable = False
        Me.cboBENCH.Properties.Tag = "benchID"
        Me.cboBENCH.Size = New System.Drawing.Size(218, 20)
        Me.cboBENCH.StyleController = Me.LayoutControl1
        Me.cboBENCH.TabIndex = 21
        Me.cboBENCH.Tag = "benchID,0,1,2"
        '
        'cboSides
        '
        Me.cboSides.Location = New System.Drawing.Point(149, 529)
        Me.cboSides.Name = "cboSides"
        Me.cboSides.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboSides.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboSides.Size = New System.Drawing.Size(218, 20)
        Me.cboSides.StyleController = Me.LayoutControl1
        Me.cboSides.TabIndex = 47
        Me.cboSides.Tag = "side,0,1,2"
        '
        'cboDim
        '
        Me.cboDim.Location = New System.Drawing.Point(149, 625)
        Me.cboDim.Name = "cboDim"
        Me.cboDim.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Search), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Clear)})
        Me.cboDim.Properties.NullText = ""
        Me.cboDim.Size = New System.Drawing.Size(218, 20)
        Me.cboDim.StyleController = Me.LayoutControl1
        Me.cboDim.TabIndex = 9
        Me.cboDim.Tag = "dimID,0,1,2"
        '
        'dtpresentation
        '
        Me.dtpresentation.EditValue = Nothing
        Me.dtpresentation.Location = New System.Drawing.Point(526, 45)
        Me.dtpresentation.Name = "dtpresentation"
        Me.dtpresentation.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtpresentation.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtpresentation.Size = New System.Drawing.Size(128, 20)
        Me.dtpresentation.StyleController = Me.LayoutControl1
        Me.dtpresentation.TabIndex = 32
        Me.dtpresentation.Tag = "dtpresentation,0,1,2"
        '
        'txtCalc
        '
        Me.txtCalc.Location = New System.Drawing.Point(400, 481)
        Me.txtCalc.Name = "txtCalc"
        Me.txtCalc.Size = New System.Drawing.Size(214, 20)
        Me.txtCalc.StyleController = Me.LayoutControl1
        Me.txtCalc.TabIndex = 52
        '
        'txtTotalPrice
        '
        Me.txtTotalPrice.EditValue = "0,00 €"
        Me.txtTotalPrice.Location = New System.Drawing.Point(450, 721)
        Me.txtTotalPrice.Name = "txtTotalPrice"
        Me.txtTotalPrice.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.txtTotalPrice.Properties.Appearance.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.txtTotalPrice.Properties.Appearance.Options.UseFont = True
        Me.txtTotalPrice.Properties.Appearance.Options.UseForeColor = True
        Me.txtTotalPrice.Properties.DisplayFormat.FormatString = "c"
        Me.txtTotalPrice.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtTotalPrice.Properties.EditFormat.FormatString = "n2"
        Me.txtTotalPrice.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtTotalPrice.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtTotalPrice.Properties.MaskSettings.Set("MaskManagerType", GetType(DevExpress.Data.Mask.NumericMaskManager))
        Me.txtTotalPrice.Properties.MaskSettings.Set("mask", "c2")
        Me.txtTotalPrice.Size = New System.Drawing.Size(92, 22)
        Me.txtTotalPrice.StyleController = Me.LayoutControl1
        Me.txtTotalPrice.TabIndex = 42
        Me.txtTotalPrice.Tag = "price,0,1,2"
        '
        'cmdCalc
        '
        Me.cmdCalc.Location = New System.Drawing.Point(546, 721)
        Me.cmdCalc.Name = "cmdCalc"
        Me.cmdCalc.Size = New System.Drawing.Size(68, 22)
        Me.cmdCalc.StyleController = Me.LayoutControl1
        Me.cmdCalc.TabIndex = 53
        Me.cmdCalc.Text = "Υπολογισμός"
        '
        'txtDepth1
        '
        Me.txtDepth1.EditValue = "0,00 €"
        Me.txtDepth1.Location = New System.Drawing.Point(149, 721)
        Me.txtDepth1.Name = "txtDepth1"
        Me.txtDepth1.Properties.DisplayFormat.FormatString = "n"
        Me.txtDepth1.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtDepth1.Properties.EditFormat.FormatString = "n2"
        Me.txtDepth1.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtDepth1.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtDepth1.Properties.MaskSettings.Set("MaskManagerType", GetType(DevExpress.Data.Mask.NumericMaskManager))
        Me.txtDepth1.Properties.MaskSettings.Set("mask", "n2")
        Me.txtDepth1.Size = New System.Drawing.Size(50, 20)
        Me.txtDepth1.StyleController = Me.LayoutControl1
        Me.txtDepth1.TabIndex = 42
        Me.txtDepth1.Tag = "depth,0,1,2"
        '
        'Root
        '
        Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.Root.GroupBordersVisible = False
        Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem2, Me.LayoutControlItem1, Me.EmptySpaceItem2, Me.LayoutControlGroup1, Me.LayoutControlGroup2})
        Me.Root.Name = "Root"
        Me.Root.Size = New System.Drawing.Size(1024, 841)
        Me.Root.TextVisible = False
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.cmdExit
        Me.LayoutControlItem2.Location = New System.Drawing.Point(861, 789)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(143, 32)
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem2.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.cmdSave
        Me.LayoutControlItem1.Location = New System.Drawing.Point(716, 789)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(145, 32)
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'EmptySpaceItem2
        '
        Me.EmptySpaceItem2.AllowHotTrack = False
        Me.EmptySpaceItem2.Location = New System.Drawing.Point(0, 789)
        Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Size = New System.Drawing.Size(716, 32)
        Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem13, Me.LayoutControlItem12, Me.LayoutControlItem17, Me.LayoutControlItem18, Me.LayoutControlItem7, Me.LayoutControlItem4, Me.LayoutControlItem10, Me.LayoutControlItem30, Me.LayoutControlItem8, Me.EmptySpaceItem1, Me.LayoutControlItem9, Me.LayoutControlItem19, Me.LayoutControlItem31, Me.EmptySpaceItem3, Me.EmptySpaceItem8, Me.LayoutControlItem39, Me.EmptySpaceItem11})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(1004, 149)
        Me.LayoutControlGroup1.Text = "Στοιχεία Προσφοράς"
        '
        'LayoutControlItem13
        '
        Me.LayoutControlItem13.Control = Me.txtMob
        Me.LayoutControlItem13.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem13.CustomizationFormText = "Κινητό"
        Me.LayoutControlItem13.Location = New System.Drawing.Point(290, 24)
        Me.LayoutControlItem13.Name = "LayoutControlItem13"
        Me.LayoutControlItem13.Size = New System.Drawing.Size(152, 24)
        Me.LayoutControlItem13.Text = "Κινητό"
        Me.LayoutControlItem13.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
        Me.LayoutControlItem13.TextLocation = DevExpress.Utils.Locations.Left
        Me.LayoutControlItem13.TextSize = New System.Drawing.Size(31, 13)
        Me.LayoutControlItem13.TextToControlDistance = 5
        '
        'LayoutControlItem12
        '
        Me.LayoutControlItem12.Control = Me.txtPhn
        Me.LayoutControlItem12.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem12.CustomizationFormText = "Τηλέφωνο"
        Me.LayoutControlItem12.Location = New System.Drawing.Point(442, 24)
        Me.LayoutControlItem12.Name = "LayoutControlItem12"
        Me.LayoutControlItem12.Size = New System.Drawing.Size(192, 24)
        Me.LayoutControlItem12.Text = "Τηλέφωνο"
        Me.LayoutControlItem12.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
        Me.LayoutControlItem12.TextSize = New System.Drawing.Size(51, 13)
        Me.LayoutControlItem12.TextToControlDistance = 5
        '
        'LayoutControlItem17
        '
        Me.LayoutControlItem17.Control = Me.txtCou
        Me.LayoutControlItem17.Location = New System.Drawing.Point(0, 48)
        Me.LayoutControlItem17.Name = "LayoutControlItem17"
        Me.LayoutControlItem17.Size = New System.Drawing.Size(236, 24)
        Me.LayoutControlItem17.Text = "Νομός"
        Me.LayoutControlItem17.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
        Me.LayoutControlItem17.TextSize = New System.Drawing.Size(30, 13)
        Me.LayoutControlItem17.TextToControlDistance = 5
        '
        'LayoutControlItem18
        '
        Me.LayoutControlItem18.Control = Me.txtArea
        Me.LayoutControlItem18.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem18.CustomizationFormText = "LayoutControlItem17"
        Me.LayoutControlItem18.Location = New System.Drawing.Point(236, 48)
        Me.LayoutControlItem18.Name = "LayoutControlItem18"
        Me.LayoutControlItem18.Size = New System.Drawing.Size(206, 24)
        Me.LayoutControlItem18.Text = "Περιοχή"
        Me.LayoutControlItem18.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
        Me.LayoutControlItem18.TextSize = New System.Drawing.Size(38, 13)
        Me.LayoutControlItem18.TextToControlDistance = 12
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.Control = Me.txtADR
        Me.LayoutControlItem7.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem7.CustomizationFormText = "Διεύθυνση"
        Me.LayoutControlItem7.Location = New System.Drawing.Point(442, 48)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(192, 24)
        Me.LayoutControlItem7.Text = "Διεύθυνση"
        Me.LayoutControlItem7.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(50, 13)
        Me.LayoutControlItem7.TextToControlDistance = 5
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.txtCode
        Me.LayoutControlItem4.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem4.CustomizationFormText = "Κωδικός"
        Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(180, 24)
        Me.LayoutControlItem4.Text = "Κωδικός Προσφοράς"
        Me.LayoutControlItem4.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(98, 13)
        Me.LayoutControlItem4.TextToControlDistance = 3
        '
        'LayoutControlItem10
        '
        Me.LayoutControlItem10.Control = Me.txtCustomCode
        Me.LayoutControlItem10.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem10.CustomizationFormText = "Κωδικός"
        Me.LayoutControlItem10.Location = New System.Drawing.Point(180, 0)
        Me.LayoutControlItem10.Name = "LayoutControlItem10"
        Me.LayoutControlItem10.Size = New System.Drawing.Size(196, 24)
        Me.LayoutControlItem10.Text = "Κωδικός Αναζήτησης"
        Me.LayoutControlItem10.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
        Me.LayoutControlItem10.TextSize = New System.Drawing.Size(107, 13)
        Me.LayoutControlItem10.TextToControlDistance = 5
        '
        'LayoutControlItem30
        '
        Me.LayoutControlItem30.Control = Me.dtpresentation
        Me.LayoutControlItem30.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem30.CustomizationFormText = "Ημερ/νία Παρουσίασης"
        Me.LayoutControlItem30.ImageOptions.Image = Global.DreamyKitchenCRM.My.Resources.Resources.rsz_11rsz_asterisk
        Me.LayoutControlItem30.Location = New System.Drawing.Point(376, 0)
        Me.LayoutControlItem30.Name = "LayoutControlItem30"
        Me.LayoutControlItem30.Size = New System.Drawing.Size(258, 24)
        Me.LayoutControlItem30.Tag = "1"
        Me.LayoutControlItem30.Text = "Ημερ/νία Παρουσίασης"
        Me.LayoutControlItem30.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
        Me.LayoutControlItem30.TextSize = New System.Drawing.Size(114, 13)
        Me.LayoutControlItem30.TextToControlDistance = 12
        '
        'LayoutControlItem8
        '
        Me.LayoutControlItem8.Control = Me.txtAR
        Me.LayoutControlItem8.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem8.CustomizationFormText = "Αριθμός"
        Me.LayoutControlItem8.Location = New System.Drawing.Point(634, 48)
        Me.LayoutControlItem8.Name = "LayoutControlItem8"
        Me.LayoutControlItem8.Size = New System.Drawing.Size(117, 24)
        Me.LayoutControlItem8.Text = "Αριθμός"
        Me.LayoutControlItem8.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
        Me.LayoutControlItem8.TextSize = New System.Drawing.Size(38, 13)
        Me.LayoutControlItem8.TextToControlDistance = 5
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(917, 0)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(63, 24)
        Me.EmptySpaceItem1.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem9
        '
        Me.LayoutControlItem9.Control = Me.cboCUS
        Me.LayoutControlItem9.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem9.CustomizationFormText = "Νομός"
        Me.LayoutControlItem9.ImageOptions.Image = CType(resources.GetObject("LayoutControlItem9.ImageOptions.Image"), System.Drawing.Image)
        Me.LayoutControlItem9.Location = New System.Drawing.Point(0, 24)
        Me.LayoutControlItem9.Name = "LayoutControlItem9"
        Me.LayoutControlItem9.Size = New System.Drawing.Size(290, 24)
        Me.LayoutControlItem9.Text = "Πελάτης"
        Me.LayoutControlItem9.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
        Me.LayoutControlItem9.TextSize = New System.Drawing.Size(51, 13)
        Me.LayoutControlItem9.TextToControlDistance = 3
        '
        'LayoutControlItem19
        '
        Me.LayoutControlItem19.Control = Me.txtTK
        Me.LayoutControlItem19.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem19.CustomizationFormText = "Αριθμός"
        Me.LayoutControlItem19.Location = New System.Drawing.Point(634, 24)
        Me.LayoutControlItem19.Name = "LayoutControlItem19"
        Me.LayoutControlItem19.Size = New System.Drawing.Size(117, 24)
        Me.LayoutControlItem19.Spacing = New DevExpress.XtraLayout.Utils.Padding(22, 0, 0, 0)
        Me.LayoutControlItem19.Text = "Τ.Κ"
        Me.LayoutControlItem19.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
        Me.LayoutControlItem19.TextSize = New System.Drawing.Size(16, 13)
        Me.LayoutControlItem19.TextToControlDistance = 5
        '
        'LayoutControlItem31
        '
        Me.LayoutControlItem31.Control = Me.TextEdit2
        Me.LayoutControlItem31.Location = New System.Drawing.Point(634, 0)
        Me.LayoutControlItem31.Name = "LayoutControlItem31"
        Me.LayoutControlItem31.Size = New System.Drawing.Size(283, 24)
        Me.LayoutControlItem31.Text = "Ημερ/νία Παράδοσης"
        Me.LayoutControlItem31.TextSize = New System.Drawing.Size(113, 13)
        '
        'EmptySpaceItem3
        '
        Me.EmptySpaceItem3.AllowHotTrack = False
        Me.EmptySpaceItem3.Location = New System.Drawing.Point(751, 24)
        Me.EmptySpaceItem3.Name = "EmptySpaceItem3"
        Me.EmptySpaceItem3.Size = New System.Drawing.Size(229, 24)
        Me.EmptySpaceItem3.TextSize = New System.Drawing.Size(0, 0)
        '
        'EmptySpaceItem8
        '
        Me.EmptySpaceItem8.AllowHotTrack = False
        Me.EmptySpaceItem8.Location = New System.Drawing.Point(751, 48)
        Me.EmptySpaceItem8.Name = "EmptySpaceItem8"
        Me.EmptySpaceItem8.Size = New System.Drawing.Size(229, 24)
        Me.EmptySpaceItem8.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem39
        '
        Me.LayoutControlItem39.Control = Me.cmdSaveOff
        Me.LayoutControlItem39.Location = New System.Drawing.Point(823, 72)
        Me.LayoutControlItem39.Name = "LayoutControlItem39"
        Me.LayoutControlItem39.Size = New System.Drawing.Size(157, 32)
        Me.LayoutControlItem39.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem39.TextVisible = False
        '
        'EmptySpaceItem11
        '
        Me.EmptySpaceItem11.AllowHotTrack = False
        Me.EmptySpaceItem11.Location = New System.Drawing.Point(0, 72)
        Me.EmptySpaceItem11.Name = "EmptySpaceItem11"
        Me.EmptySpaceItem11.Size = New System.Drawing.Size(823, 32)
        Me.EmptySpaceItem11.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlGroup2
        '
        Me.LayoutControlGroup2.CustomizationFormText = "Υλικά"
        Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem11, Me.LayoutControlItem15, Me.LayoutControlItem56, Me.LayoutControlItem6, Me.LayoutControlItem3, Me.LayoutControlItem52, Me.LayoutControlItem14, Me.EmptySpaceItem5, Me.LayoutControlItem16, Me.LayoutControlItem22, Me.LayoutControlItem21, Me.LayoutControlItem23, Me.LayoutControlItem20, Me.LayoutControlItem24, Me.LayoutControlItem26, Me.SimpleLabelItem1, Me.LayoutControlItem25, Me.LayoutControlItem29, Me.LayoutControlItem40, Me.LayoutControlItem28, Me.LayoutControlItem5, Me.LayoutControlItem27, Me.LayoutControlItem42, Me.LayoutControlItem41, Me.LayoutControlItem43})
        Me.LayoutControlGroup2.Location = New System.Drawing.Point(0, 149)
        Me.LayoutControlGroup2.Name = "LayoutControlGroup2"
        Me.LayoutControlGroup2.Size = New System.Drawing.Size(1004, 640)
        Me.LayoutControlGroup2.Text = "Υλικά"
        '
        'LayoutControlItem11
        '
        Me.LayoutControlItem11.Control = Me.cboCategory
        Me.LayoutControlItem11.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem11.CustomizationFormText = "Κατηγορία"
        Me.LayoutControlItem11.ImageOptions.Image = CType(resources.GetObject("LayoutControlItem11.ImageOptions.Image"), System.Drawing.Image)
        Me.LayoutControlItem11.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem11.Name = "LayoutControlItem11"
        Me.LayoutControlItem11.Size = New System.Drawing.Size(341, 24)
        Me.LayoutControlItem11.Text = "Κατηγορία Ερμαρίου"
        Me.LayoutControlItem11.TextSize = New System.Drawing.Size(113, 13)
        '
        'LayoutControlItem15
        '
        Me.LayoutControlItem15.Control = Me.grdMain
        Me.LayoutControlItem15.Location = New System.Drawing.Point(0, 24)
        Me.LayoutControlItem15.Name = "LayoutControlItem15"
        Me.LayoutControlItem15.Size = New System.Drawing.Size(980, 263)
        Me.LayoutControlItem15.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem15.TextVisible = False
        '
        'LayoutControlItem56
        '
        Me.LayoutControlItem56.Control = Me.txtHeight
        Me.LayoutControlItem56.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem56.CustomizationFormText = "Ύψος"
        Me.LayoutControlItem56.HighlightFocusedItem = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlItem56.ImageOptions.Image = CType(resources.GetObject("LayoutControlItem56.ImageOptions.Image"), System.Drawing.Image)
        Me.LayoutControlItem56.Location = New System.Drawing.Point(0, 359)
        Me.LayoutControlItem56.Name = "LayoutControlItem56"
        Me.LayoutControlItem56.Size = New System.Drawing.Size(347, 24)
        Me.LayoutControlItem56.Text = "Ύψος"
        Me.LayoutControlItem56.TextSize = New System.Drawing.Size(113, 13)
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.txtWidth
        Me.LayoutControlItem6.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem6.CustomizationFormText = "Ύψος"
        Me.LayoutControlItem6.HighlightFocusedItem = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlItem6.ImageOptions.Image = CType(resources.GetObject("LayoutControlItem6.ImageOptions.Image"), System.Drawing.Image)
        Me.LayoutControlItem6.Location = New System.Drawing.Point(0, 383)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(347, 24)
        Me.LayoutControlItem6.Text = "Πλάτος"
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(113, 13)
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.txtDepth
        Me.LayoutControlItem3.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem3.CustomizationFormText = "Βάθος"
        Me.LayoutControlItem3.HighlightFocusedItem = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlItem3.ImageOptions.Image = CType(resources.GetObject("LayoutControlItem3.ImageOptions.Image"), System.Drawing.Image)
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 407)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(347, 24)
        Me.LayoutControlItem3.Text = "Βάθος"
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(113, 13)
        '
        'LayoutControlItem52
        '
        Me.LayoutControlItem52.Control = Me.txtDoor
        Me.LayoutControlItem52.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem52.CustomizationFormText = "Κατηγορία"
        Me.LayoutControlItem52.HighlightFocusedItem = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlItem52.Location = New System.Drawing.Point(0, 455)
        Me.LayoutControlItem52.Name = "LayoutControlItem52"
        Me.LayoutControlItem52.Size = New System.Drawing.Size(347, 24)
        Me.LayoutControlItem52.Text = "Πόρτα"
        Me.LayoutControlItem52.TextSize = New System.Drawing.Size(113, 13)
        '
        'LayoutControlItem14
        '
        Me.LayoutControlItem14.Control = Me.txtComments
        Me.LayoutControlItem14.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem14.CustomizationFormText = "Σχόλια"
        Me.LayoutControlItem14.Location = New System.Drawing.Point(0, 575)
        Me.LayoutControlItem14.Name = "LayoutControlItem14"
        Me.LayoutControlItem14.Size = New System.Drawing.Size(522, 20)
        Me.LayoutControlItem14.Text = "Παρατηρήσεις"
        Me.LayoutControlItem14.TextSize = New System.Drawing.Size(113, 13)
        '
        'EmptySpaceItem5
        '
        Me.EmptySpaceItem5.AllowHotTrack = False
        Me.EmptySpaceItem5.Location = New System.Drawing.Point(341, 0)
        Me.EmptySpaceItem5.Name = "EmptySpaceItem5"
        Me.EmptySpaceItem5.Size = New System.Drawing.Size(639, 24)
        Me.EmptySpaceItem5.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem16
        '
        Me.LayoutControlItem16.Control = Me.PictureEdit2
        Me.LayoutControlItem16.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem16.CustomizationFormText = "Φωτογραφία"
        Me.LayoutControlItem16.Location = New System.Drawing.Point(594, 287)
        Me.LayoutControlItem16.Name = "LayoutControlItem16"
        Me.LayoutControlItem16.Size = New System.Drawing.Size(386, 308)
        Me.LayoutControlItem16.Text = "Φωτογραφία"
        Me.LayoutControlItem16.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem16.TextSize = New System.Drawing.Size(113, 13)
        '
        'LayoutControlItem22
        '
        Me.LayoutControlItem22.Control = Me.chkDimChanged
        Me.LayoutControlItem22.Location = New System.Drawing.Point(0, 287)
        Me.LayoutControlItem22.Name = "LayoutControlItem22"
        Me.LayoutControlItem22.Size = New System.Drawing.Size(124, 24)
        Me.LayoutControlItem22.Text = "Αλλαγή Διαστάσεων"
        Me.LayoutControlItem22.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem22.TextVisible = False
        '
        'LayoutControlItem21
        '
        Me.LayoutControlItem21.Control = Me.cboBOXColors
        Me.LayoutControlItem21.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem21.CustomizationFormText = "Χρώμα PVC"
        Me.LayoutControlItem21.Location = New System.Drawing.Point(0, 311)
        Me.LayoutControlItem21.Name = "LayoutControlItem21"
        Me.LayoutControlItem21.Size = New System.Drawing.Size(310, 24)
        Me.LayoutControlItem21.Text = "Χρώμα Κουτιού"
        Me.LayoutControlItem21.TextSize = New System.Drawing.Size(113, 13)
        '
        'LayoutControlItem23
        '
        Me.LayoutControlItem23.Control = Me.cboERM
        Me.LayoutControlItem23.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem23.CustomizationFormText = "Κατηγορία"
        Me.LayoutControlItem23.Location = New System.Drawing.Point(124, 287)
        Me.LayoutControlItem23.Name = "LayoutControlItem23"
        Me.LayoutControlItem23.Size = New System.Drawing.Size(186, 24)
        Me.LayoutControlItem23.Text = "Ερμάρι"
        Me.LayoutControlItem23.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
        Me.LayoutControlItem23.TextSize = New System.Drawing.Size(32, 13)
        Me.LayoutControlItem23.TextToControlDistance = 5
        '
        'LayoutControlItem20
        '
        Me.LayoutControlItem20.Control = Me.cboPVCColors
        Me.LayoutControlItem20.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem20.CustomizationFormText = "Χρώμα PVC"
        Me.LayoutControlItem20.Location = New System.Drawing.Point(310, 311)
        Me.LayoutControlItem20.Name = "LayoutControlItem20"
        Me.LayoutControlItem20.Size = New System.Drawing.Size(284, 24)
        Me.LayoutControlItem20.Text = "Χρώμα PVC"
        Me.LayoutControlItem20.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
        Me.LayoutControlItem20.TextSize = New System.Drawing.Size(54, 13)
        Me.LayoutControlItem20.TextToControlDistance = 5
        '
        'LayoutControlItem24
        '
        Me.LayoutControlItem24.Control = Me.txtDoor1
        Me.LayoutControlItem24.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem24.CustomizationFormText = "Κατηγορία"
        Me.LayoutControlItem24.HighlightFocusedItem = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlItem24.Location = New System.Drawing.Point(0, 479)
        Me.LayoutControlItem24.Name = "LayoutControlItem24"
        Me.LayoutControlItem24.Size = New System.Drawing.Size(347, 24)
        Me.LayoutControlItem24.Text = "Πόδια"
        Me.LayoutControlItem24.TextSize = New System.Drawing.Size(113, 13)
        '
        'LayoutControlItem26
        '
        Me.LayoutControlItem26.Control = Me.cboSides
        Me.LayoutControlItem26.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem26.CustomizationFormText = "Εμφανές Πλαϊνο"
        Me.LayoutControlItem26.ImageOptions.Image = CType(resources.GetObject("LayoutControlItem26.ImageOptions.Image"), System.Drawing.Image)
        Me.LayoutControlItem26.Location = New System.Drawing.Point(0, 335)
        Me.LayoutControlItem26.Name = "LayoutControlItem26"
        Me.LayoutControlItem26.Size = New System.Drawing.Size(347, 24)
        Me.LayoutControlItem26.Text = "Εμφανές Πλαϊνο"
        Me.LayoutControlItem26.TextSize = New System.Drawing.Size(113, 13)
        '
        'SimpleLabelItem1
        '
        Me.SimpleLabelItem1.AllowHotTrack = False
        Me.SimpleLabelItem1.AppearanceItemCaption.BackColor = System.Drawing.Color.LightSlateGray
        Me.SimpleLabelItem1.AppearanceItemCaption.BackColor2 = System.Drawing.Color.White
        Me.SimpleLabelItem1.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.SimpleLabelItem1.AppearanceItemCaption.ForeColor = System.Drawing.Color.White
        Me.SimpleLabelItem1.AppearanceItemCaption.Options.UseBackColor = True
        Me.SimpleLabelItem1.AppearanceItemCaption.Options.UseFont = True
        Me.SimpleLabelItem1.AppearanceItemCaption.Options.UseForeColor = True
        Me.SimpleLabelItem1.Location = New System.Drawing.Point(347, 335)
        Me.SimpleLabelItem1.Name = "SimpleLabelItem1"
        Me.SimpleLabelItem1.Size = New System.Drawing.Size(247, 17)
        Me.SimpleLabelItem1.Text = "Μηχανισμοί"
        Me.SimpleLabelItem1.TextSize = New System.Drawing.Size(113, 13)
        '
        'LayoutControlItem25
        '
        Me.LayoutControlItem25.Control = Me.cboBENCH
        Me.LayoutControlItem25.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem25.CustomizationFormText = "Κατηγορία"
        Me.LayoutControlItem25.Location = New System.Drawing.Point(0, 503)
        Me.LayoutControlItem25.Name = "LayoutControlItem25"
        Me.LayoutControlItem25.Size = New System.Drawing.Size(347, 24)
        Me.LayoutControlItem25.Text = "Πάγκος"
        Me.LayoutControlItem25.TextSize = New System.Drawing.Size(113, 13)
        '
        'LayoutControlItem29
        '
        Me.LayoutControlItem29.Control = Me.cboDim
        Me.LayoutControlItem29.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem29.CustomizationFormText = "Επωνυμία"
        Me.LayoutControlItem29.Location = New System.Drawing.Point(0, 431)
        Me.LayoutControlItem29.Name = "LayoutControlItem29"
        Me.LayoutControlItem29.Size = New System.Drawing.Size(347, 24)
        Me.LayoutControlItem29.Text = "Διάσταση"
        Me.LayoutControlItem29.TextSize = New System.Drawing.Size(113, 13)
        '
        'LayoutControlItem40
        '
        Me.LayoutControlItem40.Control = Me.txtCalc
        Me.LayoutControlItem40.Location = New System.Drawing.Point(310, 287)
        Me.LayoutControlItem40.Name = "LayoutControlItem40"
        Me.LayoutControlItem40.Size = New System.Drawing.Size(284, 24)
        Me.LayoutControlItem40.Text = "Υπολογισμός"
        Me.LayoutControlItem40.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
        Me.LayoutControlItem40.TextSize = New System.Drawing.Size(61, 13)
        Me.LayoutControlItem40.TextToControlDistance = 5
        '
        'LayoutControlItem28
        '
        Me.LayoutControlItem28.Control = Me.txtQTY
        Me.LayoutControlItem28.Location = New System.Drawing.Point(0, 551)
        Me.LayoutControlItem28.Name = "LayoutControlItem28"
        Me.LayoutControlItem28.Size = New System.Drawing.Size(179, 24)
        Me.LayoutControlItem28.Text = "Τεμάχια"
        Me.LayoutControlItem28.TextSize = New System.Drawing.Size(113, 13)
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.txtPrice
        Me.LayoutControlItem5.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem5.CustomizationFormText = "Τελική Αξία"
        Me.LayoutControlItem5.HighlightFocusedItem = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlItem5.ImageOptions.Image = CType(resources.GetObject("LayoutControlItem5.ImageOptions.Image"), System.Drawing.Image)
        Me.LayoutControlItem5.Location = New System.Drawing.Point(179, 527)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(164, 48)
        Me.LayoutControlItem5.Text = "Τιμή Ερμάριου"
        Me.LayoutControlItem5.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(78, 13)
        Me.LayoutControlItem5.TextToControlDistance = 5
        '
        'LayoutControlItem27
        '
        Me.LayoutControlItem27.Control = Me.chkMech
        Me.LayoutControlItem27.Location = New System.Drawing.Point(347, 352)
        Me.LayoutControlItem27.Name = "LayoutControlItem27"
        Me.LayoutControlItem27.Size = New System.Drawing.Size(247, 175)
        Me.LayoutControlItem27.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem27.TextVisible = False
        '
        'LayoutControlItem42
        '
        Me.LayoutControlItem42.Control = Me.cmdCalc
        Me.LayoutControlItem42.Location = New System.Drawing.Point(522, 527)
        Me.LayoutControlItem42.Name = "LayoutControlItem42"
        Me.LayoutControlItem42.Size = New System.Drawing.Size(72, 68)
        Me.LayoutControlItem42.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem42.TextVisible = False
        '
        'LayoutControlItem41
        '
        Me.LayoutControlItem41.Control = Me.txtTotalPrice
        Me.LayoutControlItem41.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem41.CustomizationFormText = "Τελική Αξία"
        Me.LayoutControlItem41.HighlightFocusedItem = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlItem41.ImageOptions.Image = CType(resources.GetObject("LayoutControlItem41.ImageOptions.Image"), System.Drawing.Image)
        Me.LayoutControlItem41.Location = New System.Drawing.Point(343, 527)
        Me.LayoutControlItem41.Name = "LayoutControlItem41"
        Me.LayoutControlItem41.Size = New System.Drawing.Size(179, 48)
        Me.LayoutControlItem41.Text = "Συνολική Τιμή"
        Me.LayoutControlItem41.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
        Me.LayoutControlItem41.TextSize = New System.Drawing.Size(78, 13)
        Me.LayoutControlItem41.TextToControlDistance = 5
        '
        'LayoutControlItem43
        '
        Me.LayoutControlItem43.Control = Me.txtDepth1
        Me.LayoutControlItem43.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem43.CustomizationFormText = "Βάθος"
        Me.LayoutControlItem43.HighlightFocusedItem = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlItem43.Location = New System.Drawing.Point(0, 527)
        Me.LayoutControlItem43.Name = "LayoutControlItem43"
        Me.LayoutControlItem43.Size = New System.Drawing.Size(179, 24)
        Me.LayoutControlItem43.Text = "Διάσταση Extra Πάγκου"
        Me.LayoutControlItem43.TextSize = New System.Drawing.Size(113, 13)
        '
        'Vw_ERMTableAdapter
        '
        Me.Vw_ERMTableAdapter.ClearBeforeFill = True
        '
        'Vw_COLORSBOXTableAdapter
        '
        Me.Vw_COLORSBOXTableAdapter.ClearBeforeFill = True
        '
        'Vw_COLORSPVCTableAdapter
        '
        Me.Vw_COLORSPVCTableAdapter.ClearBeforeFill = True
        '
        'OFFERSBindingSource
        '
        Me.OFFERSBindingSource.DataMember = "vw_OFFERS"
        Me.OFFERSBindingSource.DataSource = Me.DreamyKitchenDataSetBindingSource
        '
        'OFFERSTableAdapter
        '
        Me.OFFERSTableAdapter.ClearBeforeFill = True
        '
        'LayoutControl2
        '
        Me.LayoutControl2.Controls.Add(Me.cmdOffersRefresh)
        Me.LayoutControl2.Controls.Add(Me.cmdOffersEdit)
        Me.LayoutControl2.Controls.Add(Me.cmdOffersDel)
        Me.LayoutControl2.Controls.Add(Me.cmdOffersNew)
        Me.LayoutControl2.Controls.Add(Me.GridControl1)
        Me.LayoutControl2.Controls.Add(Me.cmdSameOffer)
        Me.LayoutControl2.Controls.Add(Me.chkDoorTypes)
        Me.LayoutControl2.Location = New System.Drawing.Point(1016, -7)
        Me.LayoutControl2.Name = "LayoutControl2"
        Me.LayoutControl2.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(1398, 544, 650, 400)
        Me.LayoutControl2.Root = Me.LayoutControlGroup3
        Me.LayoutControl2.Size = New System.Drawing.Size(577, 810)
        Me.LayoutControl2.TabIndex = 2
        Me.LayoutControl2.Text = "LayoutControl2"
        '
        'cmdOffersRefresh
        '
        Me.cmdOffersRefresh.ImageOptions.Image = Global.DreamyKitchenCRM.My.Resources.Resources.icons8_refresh_16
        Me.cmdOffersRefresh.Location = New System.Drawing.Point(12, 285)
        Me.cmdOffersRefresh.Name = "cmdOffersRefresh"
        Me.cmdOffersRefresh.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light
        Me.cmdOffersRefresh.Size = New System.Drawing.Size(23, 22)
        Me.cmdOffersRefresh.StyleController = Me.LayoutControl2
        Me.cmdOffersRefresh.TabIndex = 53
        '
        'cmdOffersEdit
        '
        Me.cmdOffersEdit.ImageOptions.Image = Global.DreamyKitchenCRM.My.Resources.Resources.Edit_16x16
        Me.cmdOffersEdit.Location = New System.Drawing.Point(12, 259)
        Me.cmdOffersEdit.Name = "cmdOffersEdit"
        Me.cmdOffersEdit.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light
        Me.cmdOffersEdit.Size = New System.Drawing.Size(23, 22)
        Me.cmdOffersEdit.StyleController = Me.LayoutControl2
        Me.cmdOffersEdit.TabIndex = 52
        '
        'cmdOffersDel
        '
        Me.cmdOffersDel.ImageOptions.Image = Global.DreamyKitchenCRM.My.Resources.Resources.Remove_16x16
        Me.cmdOffersDel.Location = New System.Drawing.Point(12, 233)
        Me.cmdOffersDel.Name = "cmdOffersDel"
        Me.cmdOffersDel.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light
        Me.cmdOffersDel.Size = New System.Drawing.Size(23, 22)
        Me.cmdOffersDel.StyleController = Me.LayoutControl2
        Me.cmdOffersDel.TabIndex = 51
        '
        'cmdOffersNew
        '
        Me.cmdOffersNew.ImageOptions.Image = Global.DreamyKitchenCRM.My.Resources.Resources.AddFile_16x16
        Me.cmdOffersNew.Location = New System.Drawing.Point(12, 207)
        Me.cmdOffersNew.Name = "cmdOffersNew"
        Me.cmdOffersNew.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light
        Me.cmdOffersNew.Size = New System.Drawing.Size(23, 22)
        Me.cmdOffersNew.StyleController = Me.LayoutControl2
        Me.cmdOffersNew.TabIndex = 50
        '
        'GridControl1
        '
        Me.GridControl1.DataSource = Me.OFFERSBindingSource
        Me.GridControl1.Location = New System.Drawing.Point(39, 207)
        Me.GridControl1.MainView = Me.GridView3
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(526, 591)
        Me.GridControl1.TabIndex = 3
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView3})
        '
        'GridView3
        '
        Me.GridView3.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colID3, Me.colqty, Me.colheight1, Me.colwidth1, Me.coldepth1, Me.coldoor1, Me.colphoto3, Me.collegs, Me.colPrice1, Me.colDoorTypeName, Me.coloffID, Me.colcatErmID1, Me.colermID})
        Me.GridView3.GridControl = Me.GridControl1
        Me.GridView3.GroupCount = 1
        Me.GridView3.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.None, "DoorTypeName", Nothing, "")})
        Me.GridView3.Name = "GridView3"
        Me.GridView3.OptionsBehavior.Editable = False
        Me.GridView3.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colDoorTypeName, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'colID3
        '
        Me.colID3.FieldName = "ID"
        Me.colID3.Name = "colID3"
        '
        'colqty
        '
        Me.colqty.Caption = "Τεμάχια"
        Me.colqty.FieldName = "qty"
        Me.colqty.Name = "colqty"
        Me.colqty.Visible = True
        Me.colqty.VisibleIndex = 0
        '
        'colheight1
        '
        Me.colheight1.Caption = "Ύψος"
        Me.colheight1.FieldName = "height"
        Me.colheight1.Name = "colheight1"
        Me.colheight1.Visible = True
        Me.colheight1.VisibleIndex = 1
        '
        'colwidth1
        '
        Me.colwidth1.Caption = "Πλάτος"
        Me.colwidth1.FieldName = "width"
        Me.colwidth1.Name = "colwidth1"
        Me.colwidth1.Visible = True
        Me.colwidth1.VisibleIndex = 2
        '
        'coldepth1
        '
        Me.coldepth1.Caption = "Βάθος"
        Me.coldepth1.FieldName = "depth"
        Me.coldepth1.Name = "coldepth1"
        Me.coldepth1.Visible = True
        Me.coldepth1.VisibleIndex = 3
        '
        'coldoor1
        '
        Me.coldoor1.Caption = "Πόρτα"
        Me.coldoor1.FieldName = "door"
        Me.coldoor1.Name = "coldoor1"
        Me.coldoor1.Visible = True
        Me.coldoor1.VisibleIndex = 4
        '
        'colphoto3
        '
        Me.colphoto3.Caption = "Φώτο"
        Me.colphoto3.FieldName = "photo"
        Me.colphoto3.Name = "colphoto3"
        Me.colphoto3.Visible = True
        Me.colphoto3.VisibleIndex = 5
        '
        'collegs
        '
        Me.collegs.Caption = "Πόδια"
        Me.collegs.FieldName = "legs"
        Me.collegs.Name = "collegs"
        Me.collegs.Visible = True
        Me.collegs.VisibleIndex = 6
        '
        'colPrice1
        '
        Me.colPrice1.Caption = "Τιμή"
        Me.colPrice1.FieldName = "Price"
        Me.colPrice1.Name = "colPrice1"
        Me.colPrice1.Visible = True
        Me.colPrice1.VisibleIndex = 7
        '
        'colDoorTypeName
        '
        Me.colDoorTypeName.Caption = "Πορτάκι"
        Me.colDoorTypeName.FieldName = "DoorTypeName"
        Me.colDoorTypeName.Name = "colDoorTypeName"
        Me.colDoorTypeName.Visible = True
        Me.colDoorTypeName.VisibleIndex = 8
        '
        'coloffID
        '
        Me.coloffID.FieldName = "offID"
        Me.coloffID.Name = "coloffID"
        '
        'colcatErmID1
        '
        Me.colcatErmID1.FieldName = "catErmID"
        Me.colcatErmID1.Name = "colcatErmID1"
        '
        'colermID
        '
        Me.colermID.FieldName = "ermID"
        Me.colermID.Name = "colermID"
        '
        'cmdSameOffer
        '
        Me.cmdSameOffer.Location = New System.Drawing.Point(39, 181)
        Me.cmdSameOffer.Name = "cmdSameOffer"
        Me.cmdSameOffer.Size = New System.Drawing.Size(526, 22)
        Me.cmdSameOffer.StyleController = Me.LayoutControl2
        Me.cmdSameOffer.TabIndex = 4
        Me.cmdSameOffer.Text = "Ίδια Προσφορά για επιλεγμένα πορτάκια"
        '
        'chkDoorTypes
        '
        Me.chkDoorTypes.CheckOnClick = True
        Me.chkDoorTypes.DataSource = Me.VwDOORTYPEBindingSource
        Me.chkDoorTypes.DisplayMember = "name"
        Me.chkDoorTypes.HorizontalScrollbar = True
        Me.chkDoorTypes.Location = New System.Drawing.Point(39, 29)
        Me.chkDoorTypes.MultiColumn = True
        Me.chkDoorTypes.Name = "chkDoorTypes"
        Me.chkDoorTypes.Size = New System.Drawing.Size(526, 148)
        Me.chkDoorTypes.SortOrder = System.Windows.Forms.SortOrder.Ascending
        Me.chkDoorTypes.StyleController = Me.LayoutControl2
        Me.chkDoorTypes.TabIndex = 49
        Me.chkDoorTypes.Tag = ""
        Me.chkDoorTypes.ValueMember = "ID"
        '
        'VwDOORTYPEBindingSource
        '
        Me.VwDOORTYPEBindingSource.DataMember = "vw_DOOR_TYPE"
        Me.VwDOORTYPEBindingSource.DataSource = Me.DreamyKitchenDataSetBindingSource
        '
        'LayoutControlGroup3
        '
        Me.LayoutControlGroup3.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup3.GroupBordersVisible = False
        Me.LayoutControlGroup3.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem32, Me.SimpleLabelItem2, Me.LayoutControlItem33, Me.LayoutControlItem34, Me.LayoutControlItem35, Me.EmptySpaceItem9, Me.EmptySpaceItem10, Me.LayoutControlItem36, Me.LayoutControlItem37, Me.LayoutControlItem38})
        Me.LayoutControlGroup3.Name = "Root"
        Me.LayoutControlGroup3.Size = New System.Drawing.Size(577, 810)
        Me.LayoutControlGroup3.TextVisible = False
        '
        'LayoutControlItem32
        '
        Me.LayoutControlItem32.Control = Me.chkDoorTypes
        Me.LayoutControlItem32.Location = New System.Drawing.Point(27, 17)
        Me.LayoutControlItem32.Name = "LayoutControlItem32"
        Me.LayoutControlItem32.Size = New System.Drawing.Size(530, 152)
        Me.LayoutControlItem32.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem32.TextVisible = False
        '
        'SimpleLabelItem2
        '
        Me.SimpleLabelItem2.AllowHotTrack = False
        Me.SimpleLabelItem2.AppearanceItemCaption.BackColor = System.Drawing.Color.LightSlateGray
        Me.SimpleLabelItem2.AppearanceItemCaption.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.SimpleLabelItem2.AppearanceItemCaption.FontStyleDelta = System.Drawing.FontStyle.Bold
        Me.SimpleLabelItem2.AppearanceItemCaption.ForeColor = System.Drawing.Color.White
        Me.SimpleLabelItem2.AppearanceItemCaption.Options.UseBackColor = True
        Me.SimpleLabelItem2.AppearanceItemCaption.Options.UseFont = True
        Me.SimpleLabelItem2.AppearanceItemCaption.Options.UseForeColor = True
        Me.SimpleLabelItem2.Location = New System.Drawing.Point(27, 0)
        Me.SimpleLabelItem2.Name = "SimpleLabelItem2"
        Me.SimpleLabelItem2.Size = New System.Drawing.Size(530, 17)
        Me.SimpleLabelItem2.Text = "Πορτάκια"
        Me.SimpleLabelItem2.TextSize = New System.Drawing.Size(53, 13)
        '
        'LayoutControlItem33
        '
        Me.LayoutControlItem33.Control = Me.cmdSameOffer
        Me.LayoutControlItem33.Location = New System.Drawing.Point(27, 169)
        Me.LayoutControlItem33.Name = "LayoutControlItem33"
        Me.LayoutControlItem33.Size = New System.Drawing.Size(530, 26)
        Me.LayoutControlItem33.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem33.TextVisible = False
        '
        'LayoutControlItem34
        '
        Me.LayoutControlItem34.Control = Me.GridControl1
        Me.LayoutControlItem34.Location = New System.Drawing.Point(27, 195)
        Me.LayoutControlItem34.Name = "LayoutControlItem34"
        Me.LayoutControlItem34.Size = New System.Drawing.Size(530, 595)
        Me.LayoutControlItem34.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem34.TextVisible = False
        '
        'LayoutControlItem35
        '
        Me.LayoutControlItem35.Control = Me.cmdOffersNew
        Me.LayoutControlItem35.Location = New System.Drawing.Point(0, 195)
        Me.LayoutControlItem35.Name = "LayoutControlItem35"
        Me.LayoutControlItem35.Size = New System.Drawing.Size(27, 26)
        Me.LayoutControlItem35.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem35.TextVisible = False
        '
        'EmptySpaceItem9
        '
        Me.EmptySpaceItem9.AllowHotTrack = False
        Me.EmptySpaceItem9.Location = New System.Drawing.Point(0, 299)
        Me.EmptySpaceItem9.Name = "EmptySpaceItem9"
        Me.EmptySpaceItem9.Size = New System.Drawing.Size(27, 491)
        Me.EmptySpaceItem9.TextSize = New System.Drawing.Size(0, 0)
        '
        'EmptySpaceItem10
        '
        Me.EmptySpaceItem10.AllowHotTrack = False
        Me.EmptySpaceItem10.Location = New System.Drawing.Point(0, 0)
        Me.EmptySpaceItem10.Name = "EmptySpaceItem10"
        Me.EmptySpaceItem10.Size = New System.Drawing.Size(27, 195)
        Me.EmptySpaceItem10.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem36
        '
        Me.LayoutControlItem36.Control = Me.cmdOffersDel
        Me.LayoutControlItem36.Location = New System.Drawing.Point(0, 221)
        Me.LayoutControlItem36.Name = "LayoutControlItem36"
        Me.LayoutControlItem36.Size = New System.Drawing.Size(27, 26)
        Me.LayoutControlItem36.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem36.TextVisible = False
        '
        'LayoutControlItem37
        '
        Me.LayoutControlItem37.Control = Me.cmdOffersEdit
        Me.LayoutControlItem37.Location = New System.Drawing.Point(0, 247)
        Me.LayoutControlItem37.Name = "LayoutControlItem37"
        Me.LayoutControlItem37.Size = New System.Drawing.Size(27, 26)
        Me.LayoutControlItem37.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem37.TextVisible = False
        '
        'LayoutControlItem38
        '
        Me.LayoutControlItem38.Control = Me.cmdOffersRefresh
        Me.LayoutControlItem38.Location = New System.Drawing.Point(0, 273)
        Me.LayoutControlItem38.Name = "LayoutControlItem38"
        Me.LayoutControlItem38.Size = New System.Drawing.Size(27, 26)
        Me.LayoutControlItem38.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem38.TextVisible = False
        '
        'Vw_DOOR_TYPETableAdapter
        '
        Me.Vw_DOOR_TYPETableAdapter.ClearBeforeFill = True
        '
        'frmOffer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.cmdExit
        Me.ClientSize = New System.Drawing.Size(1590, 836)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Controls.Add(Me.LayoutControl2)
        Me.IconOptions.Image = Global.DreamyKitchenCRM.My.Resources.Resources.favicon
        Me.Name = "frmOffer"
        Me.Text = "frmOffer"
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdMain, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VwERMBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DreamyKitchenDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DreamyKitchenDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.TextEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtQTY.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkMech, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCou.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboCUS.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPhn.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMob.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAR.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtComments.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtHeight.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDepth.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtWidth.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDoor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPrice.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCustomCode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboCategory.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtADR.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtArea.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTK.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboPVCColors.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VwCOLORSPVCBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLookUpEdit2View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboBOXColors.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VwCOLORSBOXBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLookUpEdit2View1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkDimChanged.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboERM.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDoor1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboBENCH.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboSides.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboDim.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpresentation.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpresentation.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCalc.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTotalPrice.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDepth1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem17, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem18, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem30, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem19, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem31, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem39, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem56, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem52, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem22, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem21, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem23, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem20, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem24, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem26, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SimpleLabelItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem25, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem29, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem40, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem28, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem27, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem42, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem41, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem43, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OFFERSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl2.ResumeLayout(False)
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkDoorTypes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VwDOORTYPEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem32, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SimpleLabelItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem33, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem34, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem35, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem36, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem37, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem38, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents Root As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents cmdSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdExit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents cboCUS As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents txtCode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents txtPhn As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtMob As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem13 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem12 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents txtAR As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents txtComments As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents txtHeight As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtDepth As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtWidth As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtDoor As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtPrice As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem56 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem52 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem14 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents DreamyKitchenDataSetBindingSource As BindingSource
    Friend WithEvents DreamyKitchenDataSet As DreamyKitchenDataSet
    Friend WithEvents VwERMBindingSource As BindingSource
    Friend WithEvents Vw_ERMTableAdapter As DreamyKitchenDataSetTableAdapters.vw_ERMTableAdapter
    Friend WithEvents txtCustomCode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem10 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents cboCategory As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LayoutControlItem11 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents grdMain As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colcode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCustomCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colname As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colcatErmName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colheight As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldoorName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colcat As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colwidth As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldepth As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldoor As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPrice As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colphoto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPVCcolorName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBoxColorName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBoxColorPhoto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LayoutControlItem15 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents txtADR As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtCou As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem17 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents txtArea As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem18 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents txtTK As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem19 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents cboPVCColors As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridLookUpEdit2View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colID2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colname2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colphoto2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cboBOXColors As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridLookUpEdit2View1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colID1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colname1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colphoto1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LayoutControlItem21 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem20 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents VwCOLORSBOXBindingSource As BindingSource
    Friend WithEvents Vw_COLORSBOXTableAdapter As DreamyKitchenDataSetTableAdapters.vw_COLORSBOXTableAdapter
    Friend WithEvents VwCOLORSPVCBindingSource As BindingSource
    Friend WithEvents Vw_COLORSPVCTableAdapter As DreamyKitchenDataSetTableAdapters.vw_COLORSPVCTableAdapter
    Friend WithEvents EmptySpaceItem5 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents PictureEdit2 As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents LayoutControlItem16 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents chkDimChanged As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents LayoutControlItem22 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents cboERM As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LayoutControlItem23 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents txtDoor1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem24 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents cboBENCH As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LayoutControlItem25 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents chkMech As DevExpress.XtraEditors.CheckedListBoxControl
    Friend WithEvents cboSides As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LayoutControlItem26 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem27 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents SimpleLabelItem1 As DevExpress.XtraLayout.SimpleLabelItem
    Friend WithEvents txtQTY As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem28 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents cboDim As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LayoutControlItem29 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents dtpresentation As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LayoutControlItem30 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents TextEdit2 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem31 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem3 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem8 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents OFFERSBindingSource As BindingSource
    Friend WithEvents OFFERSTableAdapter As DreamyKitchenDataSetTableAdapters.vw_OFFERSTableAdapter
    Friend WithEvents LayoutControl2 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup3 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents chkDoorTypes As DevExpress.XtraEditors.CheckedListBoxControl
    Friend WithEvents LayoutControlItem32 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents SimpleLabelItem2 As DevExpress.XtraLayout.SimpleLabelItem
    Friend WithEvents VwDOORTYPEBindingSource As BindingSource
    Friend WithEvents Vw_DOOR_TYPETableAdapter As DreamyKitchenDataSetTableAdapters.vw_DOOR_TYPETableAdapter
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents cmdSameOffer As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents colID3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colqty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colheight1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colwidth1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldepth1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldoor1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colphoto3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collegs As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPrice1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDoorTypeName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LayoutControlItem33 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem34 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents cmdOffersRefresh As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdOffersEdit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdOffersDel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdOffersNew As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem35 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem9 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem10 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LayoutControlItem36 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem37 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem38 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents coloffID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cmdSaveOff As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem39 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem11 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents colDoorTypeID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colcatErmID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colcatErmID1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colermID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colcalculations As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtCalc As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem40 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents colDoorPrice As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtTotalPrice As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem41 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents cmdCalc As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem42 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents txtDepth1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem43 As DevExpress.XtraLayout.LayoutControlItem
End Class
