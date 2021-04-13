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
        Me.grdMain = New DevExpress.XtraGrid.GridControl()
        Me.VwERMBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DreamyKitchenDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DreamyKitchenDataSet = New DreamyKitchenCRM.DreamyKitchenDataSet()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colcode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCustomCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colcatSubErmName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colcatErmName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colheight = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coldoorName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colcat = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colcatSubErmID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colwidth = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coldepth = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coldoor = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colphoto = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colphoto21 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colphoto31 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPVCcolorName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBoxColorName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBoxColorPhoto = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDoorTypeID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colcatErmID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colcalculations = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDoorPrice = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colcalcID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.chkMech = New DevExpress.XtraEditors.CheckedListBoxControl()
        Me.cmdOffersNew = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdSaveOff = New DevExpress.XtraEditors.SimpleButton()
        Me.txtdtPresentation = New DevExpress.XtraEditors.TextEdit()
        Me.txtQTY = New DevExpress.XtraEditors.TextEdit()
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
        Me.Pic1 = New DevExpress.XtraEditors.PictureEdit()
        Me.chkDimChanged = New DevExpress.XtraEditors.CheckEdit()
        Me.cboERM = New DevExpress.XtraEditors.LookUpEdit()
        Me.txtlegs = New DevExpress.XtraEditors.TextEdit()
        Me.cboBENCH = New DevExpress.XtraEditors.LookUpEdit()
        Me.cboSides = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.cboDim = New DevExpress.XtraEditors.LookUpEdit()
        Me.dtpresentation = New DevExpress.XtraEditors.DateEdit()
        Me.txtCalc = New DevExpress.XtraEditors.TextEdit()
        Me.txtTotalPrice = New DevExpress.XtraEditors.TextEdit()
        Me.cboExtraBENCH = New DevExpress.XtraEditors.LookUpEdit()
        Me.txtbenchExtraDim = New DevExpress.XtraEditors.TextEdit()
        Me.txtBenchExtraPrice = New DevExpress.XtraEditors.TextEdit()
        Me.cboDoorType = New DevExpress.XtraEditors.LookUpEdit()
        Me.cboCatSubErm = New DevExpress.XtraEditors.LookUpEdit()
        Me.Pic3 = New DevExpress.XtraEditors.PictureEdit()
        Me.Pic2 = New DevExpress.XtraEditors.PictureEdit()
        Me.PicMech = New DevExpress.XtraEditors.PictureEdit()
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
        Me.LayoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem19 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem31 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem39 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem4 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem5 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem11 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem15 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem52 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem22 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem21 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem26 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem25 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem29 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem20 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem44 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem23 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem24 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem14 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem43 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem45 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem46 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem48 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem14 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem56 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem27 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.SimpleLabelItem1 = New DevExpress.XtraLayout.SimpleLabelItem()
        Me.LayoutControlItem16 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem50 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem49 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem41 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem28 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem40 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem35 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.VwSIDESBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Vw_ERMTableAdapter = New DreamyKitchenCRM.DreamyKitchenDataSetTableAdapters.vw_ERMTableAdapter()
        Me.Vw_COLORSBOXTableAdapter = New DreamyKitchenCRM.DreamyKitchenDataSetTableAdapters.vw_COLORSBOXTableAdapter()
        Me.Vw_COLORSPVCTableAdapter = New DreamyKitchenCRM.DreamyKitchenDataSetTableAdapters.vw_COLORSPVCTableAdapter()
        Me.OFFERSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OFFERSTableAdapter = New DreamyKitchenCRM.DreamyKitchenDataSetTableAdapters.vw_OFFERSTableAdapter()
        Me.LayoutControl2 = New DevExpress.XtraLayout.LayoutControl()
        Me.cmdRecalc = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdTotalOffPrice = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdPrintOffer = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdOffersRefresh = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdOffersEdit = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdOffersDel = New DevExpress.XtraEditors.SimpleButton()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colID3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colqty = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colheight1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colwidth1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coldepth1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coldoor1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPhoto4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collegs = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDoorTypeName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coloffID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colcatErmID1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colermID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDoorTypeID1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colcatSubErmID1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colcalculations1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDoorPrice1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCatErmName1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCatSubErmName1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOfferPrice = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colHasMech = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colHasSides = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cmdSameOffer = New DevExpress.XtraEditors.SimpleButton()
        Me.chkDoorTypes = New DevExpress.XtraEditors.CheckedListBoxControl()
        Me.LayoutControlGroup3 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem32 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.SimpleLabelItem2 = New DevExpress.XtraLayout.SimpleLabelItem()
        Me.LayoutControlItem33 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem34 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem9 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem10 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem36 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem37 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem38 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem51 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem47 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem54 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.VwDOORTYPEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Vw_DOOR_TYPETableAdapter = New DreamyKitchenCRM.DreamyKitchenDataSetTableAdapters.vw_DOOR_TYPETableAdapter()
        Me.Vw_SIDESTableAdapter = New DreamyKitchenCRM.DreamyKitchenDataSetTableAdapters.vw_SIDESTableAdapter()
        CType(Me.grdMain, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VwERMBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DreamyKitchenDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DreamyKitchenDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.chkMech, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtdtPresentation.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtQTY.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
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
        CType(Me.Pic1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkDimChanged.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboERM.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtlegs.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboBENCH.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboSides.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboDim.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpresentation.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpresentation.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCalc.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTotalPrice.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboExtraBENCH.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtbenchExtraDim.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtBenchExtraPrice.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboDoorType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboCatSubErm.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pic3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pic2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicMech.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
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
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem19, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem31, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem39, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem52, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem22, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem21, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem26, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem25, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem29, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem20, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem44, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem23, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem24, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem43, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem45, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem46, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem48, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem56, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem27, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SimpleLabelItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem50, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem49, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem41, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem28, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem40, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem35, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VwSIDESBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OFFERSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl2.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkDoorTypes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem32, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SimpleLabelItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem33, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem34, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem36, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem37, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem38, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem51, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem47, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem54, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VwDOORTYPEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grdMain
        '
        Me.grdMain.Cursor = System.Windows.Forms.Cursors.Default
        Me.grdMain.DataSource = Me.VwERMBindingSource
        Me.grdMain.Location = New System.Drawing.Point(24, 204)
        Me.grdMain.MainView = Me.GridView1
        Me.grdMain.Name = "grdMain"
        Me.grdMain.Size = New System.Drawing.Size(1066, 216)
        Me.grdMain.TabIndex = 43
        Me.grdMain.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
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
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colID, Me.colcode, Me.colCustomCode, Me.colcatSubErmName, Me.colcatErmName, Me.colheight, Me.coldoorName, Me.colcat, Me.colcatSubErmID, Me.colwidth, Me.coldepth, Me.coldoor, Me.colphoto, Me.colphoto21, Me.colphoto31, Me.colPVCcolorName, Me.colBoxColorName, Me.colBoxColorPhoto, Me.colDoorTypeID, Me.colcatErmID, Me.colcalculations, Me.colDoorPrice, Me.colcalcID})
        Me.GridView1.GridControl = Me.grdMain
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsBehavior.ReadOnly = True
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
        'colcatSubErmName
        '
        Me.colcatSubErmName.FieldName = "catSubErmName"
        Me.colcatSubErmName.Name = "colcatSubErmName"
        Me.colcatSubErmName.Visible = True
        Me.colcatSubErmName.VisibleIndex = 3
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
        'colcatSubErmID
        '
        Me.colcatSubErmID.FieldName = "catSubErmID"
        Me.colcatSubErmID.Name = "colcatSubErmID"
        Me.colcatSubErmID.Visible = True
        Me.colcatSubErmID.VisibleIndex = 8
        '
        'colwidth
        '
        Me.colwidth.FieldName = "width"
        Me.colwidth.Name = "colwidth"
        Me.colwidth.Visible = True
        Me.colwidth.VisibleIndex = 9
        '
        'coldepth
        '
        Me.coldepth.FieldName = "depth"
        Me.coldepth.Name = "coldepth"
        Me.coldepth.Visible = True
        Me.coldepth.VisibleIndex = 10
        '
        'coldoor
        '
        Me.coldoor.FieldName = "door"
        Me.coldoor.Name = "coldoor"
        Me.coldoor.Visible = True
        Me.coldoor.VisibleIndex = 11
        '
        'colphoto
        '
        Me.colphoto.FieldName = "photo1"
        Me.colphoto.Name = "colphoto"
        Me.colphoto.Visible = True
        Me.colphoto.VisibleIndex = 12
        '
        'colphoto21
        '
        Me.colphoto21.FieldName = "photo2"
        Me.colphoto21.Name = "colphoto21"
        Me.colphoto21.Visible = True
        Me.colphoto21.VisibleIndex = 13
        '
        'colphoto31
        '
        Me.colphoto31.FieldName = "photo3"
        Me.colphoto31.Name = "colphoto31"
        Me.colphoto31.Visible = True
        Me.colphoto31.VisibleIndex = 14
        '
        'colPVCcolorName
        '
        Me.colPVCcolorName.FieldName = "PVCcolorName"
        Me.colPVCcolorName.Name = "colPVCcolorName"
        Me.colPVCcolorName.Visible = True
        Me.colPVCcolorName.VisibleIndex = 15
        '
        'colBoxColorName
        '
        Me.colBoxColorName.FieldName = "BoxColorName"
        Me.colBoxColorName.Name = "colBoxColorName"
        Me.colBoxColorName.Visible = True
        Me.colBoxColorName.VisibleIndex = 16
        '
        'colBoxColorPhoto
        '
        Me.colBoxColorPhoto.FieldName = "BoxColorPhoto"
        Me.colBoxColorPhoto.Name = "colBoxColorPhoto"
        Me.colBoxColorPhoto.Visible = True
        Me.colBoxColorPhoto.VisibleIndex = 17
        '
        'colDoorTypeID
        '
        Me.colDoorTypeID.FieldName = "DoorTypeID"
        Me.colDoorTypeID.Name = "colDoorTypeID"
        Me.colDoorTypeID.Visible = True
        Me.colDoorTypeID.VisibleIndex = 18
        '
        'colcatErmID
        '
        Me.colcatErmID.FieldName = "catErmID"
        Me.colcatErmID.Name = "colcatErmID"
        Me.colcatErmID.Visible = True
        Me.colcatErmID.VisibleIndex = 19
        '
        'colcalculations
        '
        Me.colcalculations.FieldName = "calculations"
        Me.colcalculations.Name = "colcalculations"
        Me.colcalculations.Visible = True
        Me.colcalculations.VisibleIndex = 20
        '
        'colDoorPrice
        '
        Me.colDoorPrice.FieldName = "DoorPrice"
        Me.colDoorPrice.Name = "colDoorPrice"
        Me.colDoorPrice.Visible = True
        Me.colDoorPrice.VisibleIndex = 21
        '
        'colcalcID
        '
        Me.colcalcID.FieldName = "calcID"
        Me.colcalcID.Name = "colcalcID"
        Me.colcalcID.Visible = True
        Me.colcalcID.VisibleIndex = 22
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.chkMech)
        Me.LayoutControl1.Controls.Add(Me.cmdOffersNew)
        Me.LayoutControl1.Controls.Add(Me.cmdSaveOff)
        Me.LayoutControl1.Controls.Add(Me.txtdtPresentation)
        Me.LayoutControl1.Controls.Add(Me.txtQTY)
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
        Me.LayoutControl1.Controls.Add(Me.txtCustomCode)
        Me.LayoutControl1.Controls.Add(Me.cboCategory)
        Me.LayoutControl1.Controls.Add(Me.txtADR)
        Me.LayoutControl1.Controls.Add(Me.txtArea)
        Me.LayoutControl1.Controls.Add(Me.txtTK)
        Me.LayoutControl1.Controls.Add(Me.cboPVCColors)
        Me.LayoutControl1.Controls.Add(Me.cboBOXColors)
        Me.LayoutControl1.Controls.Add(Me.Pic1)
        Me.LayoutControl1.Controls.Add(Me.chkDimChanged)
        Me.LayoutControl1.Controls.Add(Me.cboERM)
        Me.LayoutControl1.Controls.Add(Me.txtlegs)
        Me.LayoutControl1.Controls.Add(Me.cboBENCH)
        Me.LayoutControl1.Controls.Add(Me.cboSides)
        Me.LayoutControl1.Controls.Add(Me.cboDim)
        Me.LayoutControl1.Controls.Add(Me.dtpresentation)
        Me.LayoutControl1.Controls.Add(Me.txtCalc)
        Me.LayoutControl1.Controls.Add(Me.txtTotalPrice)
        Me.LayoutControl1.Controls.Add(Me.cboExtraBENCH)
        Me.LayoutControl1.Controls.Add(Me.txtbenchExtraDim)
        Me.LayoutControl1.Controls.Add(Me.txtBenchExtraPrice)
        Me.LayoutControl1.Controls.Add(Me.cboDoorType)
        Me.LayoutControl1.Controls.Add(Me.cboCatSubErm)
        Me.LayoutControl1.Controls.Add(Me.Pic3)
        Me.LayoutControl1.Controls.Add(Me.Pic2)
        Me.LayoutControl1.Controls.Add(Me.PicMech)
        Me.LayoutControl1.Location = New System.Drawing.Point(1, -7)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(1090, 555, 650, 400)
        Me.LayoutControl1.Root = Me.Root
        Me.LayoutControl1.Size = New System.Drawing.Size(1114, 824)
        Me.LayoutControl1.TabIndex = 0
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'chkMech
        '
        Me.chkMech.CheckOnClick = True
        Me.chkMech.HorizontalScrollbar = True
        Me.chkMech.Location = New System.Drawing.Point(404, 441)
        Me.chkMech.Name = "chkMech"
        Me.chkMech.Size = New System.Drawing.Size(265, 136)
        Me.chkMech.SortOrder = System.Windows.Forms.SortOrder.Ascending
        Me.chkMech.StyleController = Me.LayoutControl1
        Me.chkMech.TabIndex = 58
        Me.chkMech.Tag = ""
        '
        'cmdOffersNew
        '
        Me.cmdOffersNew.ImageOptions.Image = Global.DreamyKitchenCRM.My.Resources.Resources.AddFile_16x16
        Me.cmdOffersNew.Location = New System.Drawing.Point(12, 784)
        Me.cmdOffersNew.Name = "cmdOffersNew"
        Me.cmdOffersNew.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light
        Me.cmdOffersNew.Size = New System.Drawing.Size(129, 22)
        Me.cmdOffersNew.StyleController = Me.LayoutControl1
        Me.cmdOffersNew.TabIndex = 55
        Me.cmdOffersNew.Text = "Νέα Εγγραφή"
        '
        'cmdSaveOff
        '
        Me.cmdSaveOff.ImageOptions.Image = Global.DreamyKitchenCRM.My.Resources.Resources.icons8_save_close_24
        Me.cmdSaveOff.Location = New System.Drawing.Point(917, 85)
        Me.cmdSaveOff.Name = "cmdSaveOff"
        Me.cmdSaveOff.Size = New System.Drawing.Size(173, 28)
        Me.cmdSaveOff.StyleController = Me.LayoutControl1
        Me.cmdSaveOff.TabIndex = 51
        Me.cmdSaveOff.Text = "Αποθήκευση"
        '
        'txtdtPresentation
        '
        Me.txtdtPresentation.Location = New System.Drawing.Point(668, 45)
        Me.txtdtPresentation.Name = "txtdtPresentation"
        Me.txtdtPresentation.Properties.UseReadOnlyAppearance = False
        Me.txtdtPresentation.Size = New System.Drawing.Size(192, 20)
        Me.txtdtPresentation.StyleController = Me.LayoutControl1
        Me.txtdtPresentation.TabIndex = 50
        Me.txtdtPresentation.Tag = "delivery,0,1,2"
        '
        'txtQTY
        '
        Me.txtQTY.EditValue = "1"
        Me.txtQTY.Location = New System.Drawing.Point(851, 748)
        Me.txtQTY.Name = "txtQTY"
        Me.txtQTY.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtQTY.Properties.EditFormat.FormatString = "n0"
        Me.txtQTY.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtQTY.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtQTY.Properties.MaskSettings.Set("MaskManagerType", GetType(DevExpress.Data.Mask.NumericMaskManager))
        Me.txtQTY.Properties.MaskSettings.Set("mask", "n0")
        Me.txtQTY.Properties.Tag = "qty"
        Me.txtQTY.Size = New System.Drawing.Size(239, 20)
        Me.txtQTY.StyleController = Me.LayoutControl1
        Me.txtQTY.TabIndex = 49
        Me.txtQTY.Tag = "qty,0,1,2"
        '
        'txtCou
        '
        Me.txtCou.Location = New System.Drawing.Point(75, 93)
        Me.txtCou.Name = "txtCou"
        Me.txtCou.Properties.ReadOnly = True
        Me.txtCou.Properties.UseReadOnlyAppearance = False
        Me.txtCou.Size = New System.Drawing.Size(229, 20)
        Me.txtCou.StyleController = Me.LayoutControl1
        Me.txtCou.TabIndex = 44
        Me.txtCou.Tag = "COU_name"
        '
        'cmdSave
        '
        Me.cmdSave.ImageOptions.Image = Global.DreamyKitchenCRM.My.Resources.Resources.icons8_save_close_24
        Me.cmdSave.Location = New System.Drawing.Point(848, 784)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(106, 28)
        Me.cmdSave.StyleController = Me.LayoutControl1
        Me.cmdSave.TabIndex = 22
        Me.cmdSave.Text = "Αποθήκευση"
        '
        'cmdExit
        '
        Me.cmdExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdExit.ImageOptions.Image = Global.DreamyKitchenCRM.My.Resources.Resources.icons8_exit_24
        Me.cmdExit.Location = New System.Drawing.Point(958, 784)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(144, 28)
        Me.cmdExit.StyleController = Me.LayoutControl1
        Me.cmdExit.TabIndex = 21
        Me.cmdExit.Text = "Έξοδος"
        '
        'cboCUS
        '
        Me.cboCUS.Location = New System.Drawing.Point(75, 69)
        Me.cboCUS.Name = "cboCUS"
        Me.cboCUS.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.cboCUS.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Search), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Clear)})
        Me.cboCUS.Properties.NullText = ""
        Me.cboCUS.Properties.PopupSizeable = False
        Me.cboCUS.Size = New System.Drawing.Size(229, 20)
        Me.cboCUS.StyleController = Me.LayoutControl1
        Me.cboCUS.TabIndex = 5
        Me.cboCUS.Tag = "cusID,0,1,2"
        '
        'txtCode
        '
        Me.txtCode.Location = New System.Drawing.Point(76, 45)
        Me.txtCode.Name = "txtCode"
        Me.txtCode.Properties.Appearance.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.txtCode.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtCode.Properties.Appearance.Options.UseBackColor = True
        Me.txtCode.Properties.Appearance.Options.UseFont = True
        Me.txtCode.Properties.ReadOnly = True
        Me.txtCode.Size = New System.Drawing.Size(50, 20)
        Me.txtCode.StyleController = Me.LayoutControl1
        Me.txtCode.TabIndex = 4
        Me.txtCode.Tag = "code,0"
        '
        'txtPhn
        '
        Me.txtPhn.Location = New System.Drawing.Point(668, 69)
        Me.txtPhn.Name = "txtPhn"
        Me.txtPhn.Properties.ReadOnly = True
        Me.txtPhn.Properties.UseReadOnlyAppearance = False
        Me.txtPhn.Size = New System.Drawing.Size(95, 20)
        Me.txtPhn.StyleController = Me.LayoutControl1
        Me.txtPhn.TabIndex = 22
        Me.txtPhn.Tag = "phn"
        '
        'txtMob
        '
        Me.txtMob.Location = New System.Drawing.Point(432, 69)
        Me.txtMob.Name = "txtMob"
        Me.txtMob.Properties.ReadOnly = True
        Me.txtMob.Properties.UseReadOnlyAppearance = False
        Me.txtMob.Size = New System.Drawing.Size(128, 20)
        Me.txtMob.StyleController = Me.LayoutControl1
        Me.txtMob.TabIndex = 23
        Me.txtMob.Tag = "mob"
        '
        'txtAR
        '
        Me.txtAR.Location = New System.Drawing.Point(810, 93)
        Me.txtAR.Name = "txtAR"
        Me.txtAR.Properties.ReadOnly = True
        Me.txtAR.Properties.UseReadOnlyAppearance = False
        Me.txtAR.Size = New System.Drawing.Size(50, 20)
        Me.txtAR.StyleController = Me.LayoutControl1
        Me.txtAR.TabIndex = 10
        Me.txtAR.Tag = "ar"
        '
        'txtComments
        '
        Me.txtComments.Location = New System.Drawing.Point(24, 728)
        Me.txtComments.Name = "txtComments"
        Me.txtComments.Size = New System.Drawing.Size(376, 40)
        Me.txtComments.StyleController = Me.LayoutControl1
        Me.txtComments.TabIndex = 17
        Me.txtComments.Tag = "comments,0,1,2"
        '
        'txtHeight
        '
        Me.txtHeight.EditValue = "0,00 €"
        Me.txtHeight.Location = New System.Drawing.Point(160, 448)
        Me.txtHeight.Name = "txtHeight"
        Me.txtHeight.Properties.DisplayFormat.FormatString = "n"
        Me.txtHeight.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtHeight.Properties.EditFormat.FormatString = "n2"
        Me.txtHeight.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtHeight.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtHeight.Properties.MaskSettings.Set("MaskManagerType", GetType(DevExpress.Data.Mask.NumericMaskManager))
        Me.txtHeight.Properties.MaskSettings.Set("mask", "n2")
        Me.txtHeight.Size = New System.Drawing.Size(240, 20)
        Me.txtHeight.StyleController = Me.LayoutControl1
        Me.txtHeight.TabIndex = 42
        Me.txtHeight.Tag = "height,0,1,2"
        '
        'txtDepth
        '
        Me.txtDepth.EditValue = "0,00 €"
        Me.txtDepth.Location = New System.Drawing.Point(160, 496)
        Me.txtDepth.Name = "txtDepth"
        Me.txtDepth.Properties.DisplayFormat.FormatString = "n"
        Me.txtDepth.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtDepth.Properties.EditFormat.FormatString = "n2"
        Me.txtDepth.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtDepth.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtDepth.Properties.MaskSettings.Set("MaskManagerType", GetType(DevExpress.Data.Mask.NumericMaskManager))
        Me.txtDepth.Properties.MaskSettings.Set("mask", "n2")
        Me.txtDepth.Size = New System.Drawing.Size(240, 20)
        Me.txtDepth.StyleController = Me.LayoutControl1
        Me.txtDepth.TabIndex = 42
        Me.txtDepth.Tag = "depth,0,1,2"
        '
        'txtWidth
        '
        Me.txtWidth.EditValue = "0,00"
        Me.txtWidth.Location = New System.Drawing.Point(160, 472)
        Me.txtWidth.Name = "txtWidth"
        Me.txtWidth.Properties.DisplayFormat.FormatString = "n"
        Me.txtWidth.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtWidth.Properties.EditFormat.FormatString = "n2"
        Me.txtWidth.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtWidth.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtWidth.Properties.MaskSettings.Set("MaskManagerType", GetType(DevExpress.Data.Mask.NumericMaskManager))
        Me.txtWidth.Properties.MaskSettings.Set("mask", "n2")
        Me.txtWidth.Size = New System.Drawing.Size(240, 20)
        Me.txtWidth.StyleController = Me.LayoutControl1
        Me.txtWidth.TabIndex = 42
        Me.txtWidth.Tag = "width,0,1,2"
        '
        'txtDoor
        '
        Me.txtDoor.EditValue = "0"
        Me.txtDoor.Location = New System.Drawing.Point(160, 616)
        Me.txtDoor.Name = "txtDoor"
        Me.txtDoor.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtDoor.Properties.EditFormat.FormatString = "n0"
        Me.txtDoor.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtDoor.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtDoor.Properties.MaskSettings.Set("MaskManagerType", GetType(DevExpress.Data.Mask.NumericMaskManager))
        Me.txtDoor.Properties.MaskSettings.Set("mask", "n0")
        Me.txtDoor.Size = New System.Drawing.Size(92, 20)
        Me.txtDoor.StyleController = Me.LayoutControl1
        Me.txtDoor.TabIndex = 37
        Me.txtDoor.Tag = "door,0,1,2"
        '
        'txtCustomCode
        '
        Me.txtCustomCode.Location = New System.Drawing.Point(234, 45)
        Me.txtCustomCode.Name = "txtCustomCode"
        Me.txtCustomCode.Properties.Appearance.BackColor = System.Drawing.SystemColors.Info
        Me.txtCustomCode.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtCustomCode.Properties.Appearance.Options.UseBackColor = True
        Me.txtCustomCode.Properties.Appearance.Options.UseFont = True
        Me.txtCustomCode.Size = New System.Drawing.Size(70, 20)
        Me.txtCustomCode.StyleController = Me.LayoutControl1
        Me.txtCustomCode.TabIndex = 4
        Me.txtCustomCode.Tag = "CustomCode,0,1,2"
        '
        'cboCategory
        '
        Me.cboCategory.Location = New System.Drawing.Point(24, 180)
        Me.cboCategory.Name = "cboCategory"
        Me.cboCategory.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.cboCategory.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Search), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Clear)})
        Me.cboCategory.Properties.NullText = ""
        Me.cboCategory.Properties.PopupSizeable = False
        Me.cboCategory.Size = New System.Drawing.Size(269, 20)
        Me.cboCategory.StyleController = Me.LayoutControl1
        Me.cboCategory.TabIndex = 21
        Me.cboCategory.Tag = ""
        '
        'txtADR
        '
        Me.txtADR.Location = New System.Drawing.Point(619, 93)
        Me.txtADR.Name = "txtADR"
        Me.txtADR.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.txtADR.Properties.ReadOnly = True
        Me.txtADR.Properties.UseReadOnlyAppearance = False
        Me.txtADR.Size = New System.Drawing.Size(144, 20)
        Me.txtADR.StyleController = Me.LayoutControl1
        Me.txtADR.TabIndex = 7
        Me.txtADR.Tag = "ADR_name"
        '
        'txtArea
        '
        Me.txtArea.Location = New System.Drawing.Point(351, 93)
        Me.txtArea.Name = "txtArea"
        Me.txtArea.Properties.ReadOnly = True
        Me.txtArea.Properties.UseReadOnlyAppearance = False
        Me.txtArea.Size = New System.Drawing.Size(209, 20)
        Me.txtArea.StyleController = Me.LayoutControl1
        Me.txtArea.TabIndex = 44
        Me.txtArea.Tag = "AREAS_name"
        '
        'txtTK
        '
        Me.txtTK.Location = New System.Drawing.Point(810, 69)
        Me.txtTK.Name = "txtTK"
        Me.txtTK.Properties.ReadOnly = True
        Me.txtTK.Properties.UseReadOnlyAppearance = False
        Me.txtTK.Size = New System.Drawing.Size(50, 20)
        Me.txtTK.StyleController = Me.LayoutControl1
        Me.txtTK.TabIndex = 10
        Me.txtTK.Tag = "tk"
        '
        'cboPVCColors
        '
        Me.cboPVCColors.EditValue = ""
        Me.cboPVCColors.Location = New System.Drawing.Point(160, 544)
        Me.cboPVCColors.Name = "cboPVCColors"
        Me.cboPVCColors.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Search), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Clear)})
        Me.cboPVCColors.Properties.DataSource = Me.VwCOLORSPVCBindingSource
        Me.cboPVCColors.Properties.DisplayMember = "name"
        Me.cboPVCColors.Properties.NullText = ""
        Me.cboPVCColors.Properties.PopupView = Me.GridLookUpEdit2View
        Me.cboPVCColors.Properties.ValueMember = "ID"
        Me.cboPVCColors.Size = New System.Drawing.Size(240, 20)
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
        Me.cboBOXColors.Location = New System.Drawing.Point(160, 520)
        Me.cboBOXColors.Name = "cboBOXColors"
        Me.cboBOXColors.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Search), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Clear)})
        Me.cboBOXColors.Properties.DataSource = Me.VwCOLORSBOXBindingSource
        Me.cboBOXColors.Properties.DisplayMember = "name"
        Me.cboBOXColors.Properties.NullText = ""
        Me.cboBOXColors.Properties.PopupView = Me.GridLookUpEdit2View1
        Me.cboBOXColors.Properties.ValueMember = "ID"
        Me.cboBOXColors.Size = New System.Drawing.Size(240, 20)
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
        'Pic1
        '
        Me.Pic1.Location = New System.Drawing.Point(673, 440)
        Me.Pic1.Name = "Pic1"
        Me.Pic1.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.Pic1.Properties.Appearance.Options.UseBackColor = True
        Me.Pic1.Properties.PictureStoreMode = DevExpress.XtraEditors.Controls.PictureStoreMode.ByteArray
        Me.Pic1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Always
        Me.Pic1.Properties.ShowScrollBars = True
        Me.Pic1.Properties.ShowZoomSubMenu = DevExpress.Utils.DefaultBoolean.[True]
        Me.Pic1.Properties.Tag = "photo1"
        Me.Pic1.Size = New System.Drawing.Size(142, 278)
        Me.Pic1.StyleController = Me.LayoutControl1
        Me.Pic1.TabIndex = 44
        Me.Pic1.Tag = "photo1,0,1,2"
        '
        'chkDimChanged
        '
        Me.chkDimChanged.EditValue = CType(0, Byte)
        Me.chkDimChanged.Location = New System.Drawing.Point(24, 424)
        Me.chkDimChanged.Name = "chkDimChanged"
        Me.chkDimChanged.Properties.Appearance.BackColor = System.Drawing.Color.LightSlateGray
        Me.chkDimChanged.Properties.Appearance.ForeColor = System.Drawing.Color.White
        Me.chkDimChanged.Properties.Appearance.Options.UseBackColor = True
        Me.chkDimChanged.Properties.Appearance.Options.UseForeColor = True
        Me.chkDimChanged.Properties.Caption = "Αλλαγή Διαστάσεων"
        Me.chkDimChanged.Properties.Tag = "dimChanged"
        Me.chkDimChanged.Properties.ValueChecked = CType(1, Byte)
        Me.chkDimChanged.Properties.ValueUnchecked = CType(0, Byte)
        Me.chkDimChanged.Size = New System.Drawing.Size(139, 20)
        Me.chkDimChanged.StyleController = Me.LayoutControl1
        Me.chkDimChanged.TabIndex = 46
        Me.chkDimChanged.Tag = ""
        '
        'cboERM
        '
        Me.cboERM.Location = New System.Drawing.Point(210, 424)
        Me.cboERM.Name = "cboERM"
        Me.cboERM.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.cboERM.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Search), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Clear)})
        Me.cboERM.Properties.NullText = ""
        Me.cboERM.Properties.PopupSizeable = False
        Me.cboERM.Properties.ReadOnly = True
        Me.cboERM.Properties.Tag = "ErmID"
        Me.cboERM.Properties.UseReadOnlyAppearance = False
        Me.cboERM.Size = New System.Drawing.Size(190, 20)
        Me.cboERM.StyleController = Me.LayoutControl1
        Me.cboERM.TabIndex = 21
        Me.cboERM.Tag = "ErmID,0,1,2"
        '
        'txtlegs
        '
        Me.txtlegs.EditValue = "0"
        Me.txtlegs.Location = New System.Drawing.Point(288, 616)
        Me.txtlegs.Name = "txtlegs"
        Me.txtlegs.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtlegs.Properties.EditFormat.FormatString = "n0"
        Me.txtlegs.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtlegs.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtlegs.Properties.MaskSettings.Set("MaskManagerType", GetType(DevExpress.Data.Mask.NumericMaskManager))
        Me.txtlegs.Properties.MaskSettings.Set("mask", "n0")
        Me.txtlegs.Size = New System.Drawing.Size(69, 20)
        Me.txtlegs.StyleController = Me.LayoutControl1
        Me.txtlegs.TabIndex = 37
        Me.txtlegs.Tag = "legs,0,1,2"
        '
        'cboBENCH
        '
        Me.cboBENCH.Location = New System.Drawing.Point(160, 640)
        Me.cboBENCH.Name = "cboBENCH"
        Me.cboBENCH.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.cboBENCH.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Search), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Clear)})
        Me.cboBENCH.Properties.NullText = ""
        Me.cboBENCH.Properties.PopupSizeable = False
        Me.cboBENCH.Properties.Tag = "benchID"
        Me.cboBENCH.Size = New System.Drawing.Size(240, 20)
        Me.cboBENCH.StyleController = Me.LayoutControl1
        Me.cboBENCH.TabIndex = 21
        Me.cboBENCH.Tag = "benchID,0,1,2"
        '
        'cboSides
        '
        Me.cboSides.Location = New System.Drawing.Point(160, 568)
        Me.cboSides.Name = "cboSides"
        Me.cboSides.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboSides.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboSides.Size = New System.Drawing.Size(240, 20)
        Me.cboSides.StyleController = Me.LayoutControl1
        Me.cboSides.TabIndex = 47
        Me.cboSides.Tag = "side,0,1,2"
        '
        'cboDim
        '
        Me.cboDim.Location = New System.Drawing.Point(160, 592)
        Me.cboDim.Name = "cboDim"
        Me.cboDim.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Search), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Clear)})
        Me.cboDim.Properties.NullText = ""
        Me.cboDim.Size = New System.Drawing.Size(240, 20)
        Me.cboDim.StyleController = Me.LayoutControl1
        Me.cboDim.TabIndex = 9
        Me.cboDim.Tag = "dimID,0,1,2"
        '
        'dtpresentation
        '
        Me.dtpresentation.EditValue = Nothing
        Me.dtpresentation.Location = New System.Drawing.Point(425, 45)
        Me.dtpresentation.Name = "dtpresentation"
        Me.dtpresentation.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtpresentation.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtpresentation.Size = New System.Drawing.Size(135, 20)
        Me.dtpresentation.StyleController = Me.LayoutControl1
        Me.dtpresentation.TabIndex = 32
        Me.dtpresentation.Tag = "dtpresentation,0,1,2"
        '
        'txtCalc
        '
        Me.txtCalc.Enabled = False
        Me.txtCalc.Location = New System.Drawing.Point(404, 740)
        Me.txtCalc.Name = "txtCalc"
        Me.txtCalc.Size = New System.Drawing.Size(354, 20)
        Me.txtCalc.StyleController = Me.LayoutControl1
        Me.txtCalc.TabIndex = 52
        '
        'txtTotalPrice
        '
        Me.txtTotalPrice.EditValue = "0,00 €"
        Me.txtTotalPrice.Location = New System.Drawing.Point(851, 722)
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
        Me.txtTotalPrice.Properties.Tag = "OfferPrice"
        Me.txtTotalPrice.Size = New System.Drawing.Size(239, 22)
        Me.txtTotalPrice.StyleController = Me.LayoutControl1
        Me.txtTotalPrice.TabIndex = 42
        Me.txtTotalPrice.Tag = "OfferPrice,0,1,2"
        '
        'cboExtraBENCH
        '
        Me.cboExtraBENCH.Location = New System.Drawing.Point(160, 664)
        Me.cboExtraBENCH.Name = "cboExtraBENCH"
        Me.cboExtraBENCH.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.cboExtraBENCH.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Search), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Clear)})
        Me.cboExtraBENCH.Properties.NullText = ""
        Me.cboExtraBENCH.Properties.PopupSizeable = False
        Me.cboExtraBENCH.Properties.Tag = "benchExtraID"
        Me.cboExtraBENCH.Size = New System.Drawing.Size(240, 20)
        Me.cboExtraBENCH.StyleController = Me.LayoutControl1
        Me.cboExtraBENCH.TabIndex = 21
        Me.cboExtraBENCH.Tag = "benchExtraID,0,1,2"
        '
        'txtbenchExtraDim
        '
        Me.txtbenchExtraDim.EditValue = "0,00"
        Me.txtbenchExtraDim.Enabled = False
        Me.txtbenchExtraDim.Location = New System.Drawing.Point(160, 688)
        Me.txtbenchExtraDim.Name = "txtbenchExtraDim"
        Me.txtbenchExtraDim.Properties.DisplayFormat.FormatString = "n"
        Me.txtbenchExtraDim.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtbenchExtraDim.Properties.EditFormat.FormatString = "n2"
        Me.txtbenchExtraDim.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtbenchExtraDim.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtbenchExtraDim.Properties.MaskSettings.Set("MaskManagerType", GetType(DevExpress.Data.Mask.NumericMaskManager))
        Me.txtbenchExtraDim.Properties.MaskSettings.Set("mask", "n2")
        Me.txtbenchExtraDim.Properties.Tag = "benchExtraDim"
        Me.txtbenchExtraDim.Size = New System.Drawing.Size(50, 20)
        Me.txtbenchExtraDim.StyleController = Me.LayoutControl1
        Me.txtbenchExtraDim.TabIndex = 42
        Me.txtbenchExtraDim.Tag = "benchExtraDim,0,1,2"
        '
        'txtBenchExtraPrice
        '
        Me.txtBenchExtraPrice.EditValue = "0,00 €"
        Me.txtBenchExtraPrice.Enabled = False
        Me.txtBenchExtraPrice.Location = New System.Drawing.Point(350, 688)
        Me.txtBenchExtraPrice.Name = "txtBenchExtraPrice"
        Me.txtBenchExtraPrice.Properties.DisplayFormat.FormatString = "c"
        Me.txtBenchExtraPrice.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtBenchExtraPrice.Properties.EditFormat.FormatString = "n2"
        Me.txtBenchExtraPrice.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtBenchExtraPrice.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtBenchExtraPrice.Properties.MaskSettings.Set("MaskManagerType", GetType(DevExpress.Data.Mask.NumericMaskManager))
        Me.txtBenchExtraPrice.Properties.MaskSettings.Set("mask", "c2")
        Me.txtBenchExtraPrice.Properties.Tag = "BenchExtraPrice"
        Me.txtBenchExtraPrice.Size = New System.Drawing.Size(50, 20)
        Me.txtBenchExtraPrice.StyleController = Me.LayoutControl1
        Me.txtBenchExtraPrice.TabIndex = 42
        Me.txtBenchExtraPrice.Tag = "BenchExtraPrice,0,1,2"
        '
        'cboDoorType
        '
        Me.cboDoorType.Location = New System.Drawing.Point(612, 180)
        Me.cboDoorType.Name = "cboDoorType"
        Me.cboDoorType.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.cboDoorType.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Search), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Clear)})
        Me.cboDoorType.Properties.NullText = ""
        Me.cboDoorType.Properties.PopupSizeable = False
        Me.cboDoorType.Size = New System.Drawing.Size(478, 20)
        Me.cboDoorType.StyleController = Me.LayoutControl1
        Me.cboDoorType.TabIndex = 21
        Me.cboDoorType.Tag = ""
        '
        'cboCatSubErm
        '
        Me.cboCatSubErm.Location = New System.Drawing.Point(297, 180)
        Me.cboCatSubErm.Name = "cboCatSubErm"
        Me.cboCatSubErm.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.cboCatSubErm.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Search), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Clear)})
        Me.cboCatSubErm.Properties.NullText = ""
        Me.cboCatSubErm.Properties.PopupSizeable = False
        Me.cboCatSubErm.Size = New System.Drawing.Size(311, 20)
        Me.cboCatSubErm.StyleController = Me.LayoutControl1
        Me.cboCatSubErm.TabIndex = 21
        Me.cboCatSubErm.Tag = ""
        '
        'Pic3
        '
        Me.Pic3.Location = New System.Drawing.Point(966, 440)
        Me.Pic3.Name = "Pic3"
        Me.Pic3.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.Pic3.Properties.Appearance.Options.UseBackColor = True
        Me.Pic3.Properties.PictureStoreMode = DevExpress.XtraEditors.Controls.PictureStoreMode.ByteArray
        Me.Pic3.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Always
        Me.Pic3.Properties.ShowScrollBars = True
        Me.Pic3.Properties.ShowZoomSubMenu = DevExpress.Utils.DefaultBoolean.[True]
        Me.Pic3.Properties.Tag = "photo3"
        Me.Pic3.Size = New System.Drawing.Size(124, 278)
        Me.Pic3.StyleController = Me.LayoutControl1
        Me.Pic3.TabIndex = 44
        Me.Pic3.Tag = "photo3,0,1,2"
        '
        'Pic2
        '
        Me.Pic2.Location = New System.Drawing.Point(819, 440)
        Me.Pic2.Name = "Pic2"
        Me.Pic2.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.Pic2.Properties.Appearance.Options.UseBackColor = True
        Me.Pic2.Properties.PictureStoreMode = DevExpress.XtraEditors.Controls.PictureStoreMode.ByteArray
        Me.Pic2.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Always
        Me.Pic2.Properties.ShowScrollBars = True
        Me.Pic2.Properties.ShowZoomSubMenu = DevExpress.Utils.DefaultBoolean.[True]
        Me.Pic2.Properties.Tag = "photo2"
        Me.Pic2.Size = New System.Drawing.Size(143, 278)
        Me.Pic2.StyleController = Me.LayoutControl1
        Me.Pic2.TabIndex = 44
        Me.Pic2.Tag = "photo2,0,1,2"
        '
        'PicMech
        '
        Me.PicMech.Location = New System.Drawing.Point(404, 597)
        Me.PicMech.Name = "PicMech"
        Me.PicMech.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.PicMech.Properties.Appearance.Options.UseBackColor = True
        Me.PicMech.Properties.PictureStoreMode = DevExpress.XtraEditors.Controls.PictureStoreMode.ByteArray
        Me.PicMech.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Always
        Me.PicMech.Properties.ShowScrollBars = True
        Me.PicMech.Properties.ShowZoomSubMenu = DevExpress.Utils.DefaultBoolean.[True]
        Me.PicMech.Properties.Tag = ""
        Me.PicMech.Size = New System.Drawing.Size(265, 121)
        Me.PicMech.StyleController = Me.LayoutControl1
        Me.PicMech.TabIndex = 44
        Me.PicMech.Tag = ""
        '
        'Root
        '
        Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.Root.GroupBordersVisible = False
        Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem2, Me.LayoutControlItem1, Me.EmptySpaceItem2, Me.LayoutControlGroup1, Me.LayoutControlGroup2, Me.LayoutControlItem35})
        Me.Root.Name = "Root"
        Me.Root.Size = New System.Drawing.Size(1114, 824)
        Me.Root.TextVisible = False
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.cmdExit
        Me.LayoutControlItem2.Location = New System.Drawing.Point(946, 772)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(148, 32)
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem2.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.cmdSave
        Me.LayoutControlItem1.Location = New System.Drawing.Point(836, 772)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(110, 32)
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'EmptySpaceItem2
        '
        Me.EmptySpaceItem2.AllowHotTrack = False
        Me.EmptySpaceItem2.Location = New System.Drawing.Point(133, 772)
        Me.EmptySpaceItem2.MinSize = New System.Drawing.Size(104, 24)
        Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Size = New System.Drawing.Size(703, 32)
        Me.EmptySpaceItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem13, Me.LayoutControlItem12, Me.LayoutControlItem17, Me.LayoutControlItem18, Me.LayoutControlItem7, Me.LayoutControlItem4, Me.LayoutControlItem10, Me.LayoutControlItem30, Me.LayoutControlItem8, Me.LayoutControlItem9, Me.LayoutControlItem19, Me.LayoutControlItem31, Me.LayoutControlItem39, Me.EmptySpaceItem4, Me.EmptySpaceItem5})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(1094, 117)
        Me.LayoutControlGroup1.Text = "Στοιχεία Προσφοράς"
        '
        'LayoutControlItem13
        '
        Me.LayoutControlItem13.Control = Me.txtMob
        Me.LayoutControlItem13.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem13.CustomizationFormText = "Κινητό"
        Me.LayoutControlItem13.Location = New System.Drawing.Point(284, 24)
        Me.LayoutControlItem13.Name = "LayoutControlItem13"
        Me.LayoutControlItem13.Size = New System.Drawing.Size(256, 24)
        Me.LayoutControlItem13.Spacing = New DevExpress.XtraLayout.Utils.Padding(88, 0, 0, 0)
        Me.LayoutControlItem13.Text = "Κινητό"
        Me.LayoutControlItem13.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
        Me.LayoutControlItem13.TextLocation = DevExpress.Utils.Locations.Left
        Me.LayoutControlItem13.TextSize = New System.Drawing.Size(31, 13)
        Me.LayoutControlItem13.TextToControlDistance = 5
        '
        'LayoutControlItem12
        '
        Me.LayoutControlItem12.Control = Me.txtPhn
        Me.LayoutControlItem12.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem12.CustomizationFormText = "Τηλέφωνο"
        Me.LayoutControlItem12.Location = New System.Drawing.Point(540, 24)
        Me.LayoutControlItem12.Name = "LayoutControlItem12"
        Me.LayoutControlItem12.Size = New System.Drawing.Size(203, 24)
        Me.LayoutControlItem12.Spacing = New DevExpress.XtraLayout.Utils.Padding(48, 0, 0, 0)
        Me.LayoutControlItem12.Text = "Τηλέφωνο"
        Me.LayoutControlItem12.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
        Me.LayoutControlItem12.TextSize = New System.Drawing.Size(51, 13)
        Me.LayoutControlItem12.TextToControlDistance = 5
        '
        'LayoutControlItem17
        '
        Me.LayoutControlItem17.Control = Me.txtCou
        Me.LayoutControlItem17.Location = New System.Drawing.Point(0, 48)
        Me.LayoutControlItem17.MaxSize = New System.Drawing.Size(0, 24)
        Me.LayoutControlItem17.MinSize = New System.Drawing.Size(191, 24)
        Me.LayoutControlItem17.Name = "LayoutControlItem17"
        Me.LayoutControlItem17.Padding = New DevExpress.XtraLayout.Utils.Padding(18, 2, 2, 2)
        Me.LayoutControlItem17.Size = New System.Drawing.Size(284, 24)
        Me.LayoutControlItem17.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem17.Text = "Νομός"
        Me.LayoutControlItem17.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
        Me.LayoutControlItem17.TextSize = New System.Drawing.Size(30, 13)
        Me.LayoutControlItem17.TextToControlDistance = 5
        '
        'LayoutControlItem18
        '
        Me.LayoutControlItem18.Control = Me.txtArea
        Me.LayoutControlItem18.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem18.CustomizationFormText = "LayoutControlItem17"
        Me.LayoutControlItem18.Location = New System.Drawing.Point(284, 48)
        Me.LayoutControlItem18.Name = "LayoutControlItem18"
        Me.LayoutControlItem18.Size = New System.Drawing.Size(256, 24)
        Me.LayoutControlItem18.Text = "Περιοχή"
        Me.LayoutControlItem18.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
        Me.LayoutControlItem18.TextSize = New System.Drawing.Size(38, 13)
        Me.LayoutControlItem18.TextToControlDistance = 5
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.Control = Me.txtADR
        Me.LayoutControlItem7.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem7.CustomizationFormText = "Διεύθυνση"
        Me.LayoutControlItem7.Location = New System.Drawing.Point(540, 48)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(203, 24)
        Me.LayoutControlItem7.Text = "Διεύθυνση"
        Me.LayoutControlItem7.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
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
        Me.LayoutControlItem4.Size = New System.Drawing.Size(106, 24)
        Me.LayoutControlItem4.Spacing = New DevExpress.XtraLayout.Utils.Padding(8, 0, 0, 0)
        Me.LayoutControlItem4.Text = "Κωδικός"
        Me.LayoutControlItem4.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(39, 13)
        Me.LayoutControlItem4.TextToControlDistance = 5
        '
        'LayoutControlItem10
        '
        Me.LayoutControlItem10.Control = Me.txtCustomCode
        Me.LayoutControlItem10.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem10.CustomizationFormText = "Κωδικός"
        Me.LayoutControlItem10.Location = New System.Drawing.Point(106, 0)
        Me.LayoutControlItem10.Name = "LayoutControlItem10"
        Me.LayoutControlItem10.Size = New System.Drawing.Size(178, 24)
        Me.LayoutControlItem10.Text = "Κωδικός Αναζήτησης"
        Me.LayoutControlItem10.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
        Me.LayoutControlItem10.TextSize = New System.Drawing.Size(99, 13)
        Me.LayoutControlItem10.TextToControlDistance = 5
        '
        'LayoutControlItem30
        '
        Me.LayoutControlItem30.Control = Me.dtpresentation
        Me.LayoutControlItem30.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem30.CustomizationFormText = "Ημερ/νία Προσφοράς"
        Me.LayoutControlItem30.ImageOptions.Image = Global.DreamyKitchenCRM.My.Resources.Resources.rsz_11rsz_asterisk
        Me.LayoutControlItem30.Location = New System.Drawing.Point(284, 0)
        Me.LayoutControlItem30.Name = "LayoutControlItem30"
        Me.LayoutControlItem30.Size = New System.Drawing.Size(256, 24)
        Me.LayoutControlItem30.Tag = "1"
        Me.LayoutControlItem30.Text = "Ημερ/νία Προσφοράς"
        Me.LayoutControlItem30.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
        Me.LayoutControlItem30.TextSize = New System.Drawing.Size(112, 13)
        Me.LayoutControlItem30.TextToControlDistance = 5
        '
        'LayoutControlItem8
        '
        Me.LayoutControlItem8.Control = Me.txtAR
        Me.LayoutControlItem8.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem8.CustomizationFormText = "Αριθμός"
        Me.LayoutControlItem8.Location = New System.Drawing.Point(743, 48)
        Me.LayoutControlItem8.Name = "LayoutControlItem8"
        Me.LayoutControlItem8.Size = New System.Drawing.Size(97, 24)
        Me.LayoutControlItem8.Text = "Αριθμός"
        Me.LayoutControlItem8.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
        Me.LayoutControlItem8.TextSize = New System.Drawing.Size(38, 13)
        Me.LayoutControlItem8.TextToControlDistance = 5
        '
        'LayoutControlItem9
        '
        Me.LayoutControlItem9.Control = Me.cboCUS
        Me.LayoutControlItem9.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem9.CustomizationFormText = "Νομός"
        Me.LayoutControlItem9.ImageOptions.Image = CType(resources.GetObject("LayoutControlItem9.ImageOptions.Image"), System.Drawing.Image)
        Me.LayoutControlItem9.Location = New System.Drawing.Point(0, 24)
        Me.LayoutControlItem9.Name = "LayoutControlItem9"
        Me.LayoutControlItem9.Size = New System.Drawing.Size(284, 24)
        Me.LayoutControlItem9.Text = "Πελάτης"
        Me.LayoutControlItem9.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
        Me.LayoutControlItem9.TextLocation = DevExpress.Utils.Locations.Left
        Me.LayoutControlItem9.TextSize = New System.Drawing.Size(51, 13)
        Me.LayoutControlItem9.TextToControlDistance = 0
        '
        'LayoutControlItem19
        '
        Me.LayoutControlItem19.Control = Me.txtTK
        Me.LayoutControlItem19.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem19.CustomizationFormText = "Αριθμός"
        Me.LayoutControlItem19.Location = New System.Drawing.Point(743, 24)
        Me.LayoutControlItem19.Name = "LayoutControlItem19"
        Me.LayoutControlItem19.Size = New System.Drawing.Size(97, 24)
        Me.LayoutControlItem19.Spacing = New DevExpress.XtraLayout.Utils.Padding(22, 0, 0, 0)
        Me.LayoutControlItem19.Text = "Τ.Κ"
        Me.LayoutControlItem19.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
        Me.LayoutControlItem19.TextSize = New System.Drawing.Size(16, 13)
        Me.LayoutControlItem19.TextToControlDistance = 5
        '
        'LayoutControlItem31
        '
        Me.LayoutControlItem31.Control = Me.txtdtPresentation
        Me.LayoutControlItem31.Location = New System.Drawing.Point(540, 0)
        Me.LayoutControlItem31.Name = "LayoutControlItem31"
        Me.LayoutControlItem31.Size = New System.Drawing.Size(300, 24)
        Me.LayoutControlItem31.Text = "Ημερ/νία Παράδοσης"
        Me.LayoutControlItem31.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
        Me.LayoutControlItem31.TextSize = New System.Drawing.Size(99, 13)
        Me.LayoutControlItem31.TextToControlDistance = 5
        '
        'LayoutControlItem39
        '
        Me.LayoutControlItem39.Control = Me.cmdSaveOff
        Me.LayoutControlItem39.Location = New System.Drawing.Point(893, 40)
        Me.LayoutControlItem39.Name = "LayoutControlItem39"
        Me.LayoutControlItem39.Size = New System.Drawing.Size(177, 32)
        Me.LayoutControlItem39.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem39.TextVisible = False
        '
        'EmptySpaceItem4
        '
        Me.EmptySpaceItem4.AllowHotTrack = False
        Me.EmptySpaceItem4.Location = New System.Drawing.Point(840, 0)
        Me.EmptySpaceItem4.Name = "EmptySpaceItem4"
        Me.EmptySpaceItem4.Size = New System.Drawing.Size(53, 72)
        Me.EmptySpaceItem4.TextSize = New System.Drawing.Size(0, 0)
        '
        'EmptySpaceItem5
        '
        Me.EmptySpaceItem5.AllowHotTrack = False
        Me.EmptySpaceItem5.Location = New System.Drawing.Point(893, 0)
        Me.EmptySpaceItem5.Name = "EmptySpaceItem5"
        Me.EmptySpaceItem5.Size = New System.Drawing.Size(177, 40)
        Me.EmptySpaceItem5.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlGroup2
        '
        Me.LayoutControlGroup2.CustomizationFormText = "Υλικά"
        Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem11, Me.LayoutControlItem15, Me.LayoutControlItem52, Me.LayoutControlItem22, Me.LayoutControlItem21, Me.LayoutControlItem26, Me.LayoutControlItem25, Me.LayoutControlItem29, Me.LayoutControlItem20, Me.LayoutControlItem44, Me.LayoutControlItem23, Me.LayoutControlItem24, Me.EmptySpaceItem14, Me.LayoutControlItem43, Me.LayoutControlItem6, Me.LayoutControlItem3, Me.LayoutControlItem45, Me.LayoutControlItem46, Me.LayoutControlItem48, Me.LayoutControlItem14, Me.LayoutControlItem56, Me.LayoutControlItem27, Me.SimpleLabelItem1, Me.LayoutControlItem41, Me.LayoutControlItem28, Me.LayoutControlItem40, Me.LayoutControlItem16, Me.LayoutControlItem50, Me.LayoutControlItem49, Me.LayoutControlItem5})
        Me.LayoutControlGroup2.Location = New System.Drawing.Point(0, 117)
        Me.LayoutControlGroup2.Name = "LayoutControlGroup2"
        Me.LayoutControlGroup2.Size = New System.Drawing.Size(1094, 655)
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
        Me.LayoutControlItem11.Size = New System.Drawing.Size(273, 42)
        Me.LayoutControlItem11.Text = "Κατηγορία"
        Me.LayoutControlItem11.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
        Me.LayoutControlItem11.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem11.TextSize = New System.Drawing.Size(60, 13)
        Me.LayoutControlItem11.TextToControlDistance = 5
        '
        'LayoutControlItem15
        '
        Me.LayoutControlItem15.Control = Me.grdMain
        Me.LayoutControlItem15.Location = New System.Drawing.Point(0, 42)
        Me.LayoutControlItem15.Name = "LayoutControlItem15"
        Me.LayoutControlItem15.Size = New System.Drawing.Size(1070, 220)
        Me.LayoutControlItem15.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem15.TextVisible = False
        '
        'LayoutControlItem52
        '
        Me.LayoutControlItem52.Control = Me.txtDoor
        Me.LayoutControlItem52.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem52.CustomizationFormText = "Κατηγορία"
        Me.LayoutControlItem52.HighlightFocusedItem = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlItem52.Location = New System.Drawing.Point(0, 454)
        Me.LayoutControlItem52.Name = "LayoutControlItem52"
        Me.LayoutControlItem52.Size = New System.Drawing.Size(232, 24)
        Me.LayoutControlItem52.Text = "Πόρτα"
        Me.LayoutControlItem52.TextSize = New System.Drawing.Size(124, 13)
        '
        'LayoutControlItem22
        '
        Me.LayoutControlItem22.Control = Me.chkDimChanged
        Me.LayoutControlItem22.Location = New System.Drawing.Point(0, 262)
        Me.LayoutControlItem22.Name = "LayoutControlItem22"
        Me.LayoutControlItem22.Size = New System.Drawing.Size(143, 24)
        Me.LayoutControlItem22.Text = "Αλλαγή Διαστάσεων"
        Me.LayoutControlItem22.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem22.TextVisible = False
        '
        'LayoutControlItem21
        '
        Me.LayoutControlItem21.Control = Me.cboBOXColors
        Me.LayoutControlItem21.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem21.CustomizationFormText = "Χρώμα PVC"
        Me.LayoutControlItem21.Location = New System.Drawing.Point(0, 358)
        Me.LayoutControlItem21.Name = "LayoutControlItem21"
        Me.LayoutControlItem21.Size = New System.Drawing.Size(380, 24)
        Me.LayoutControlItem21.Text = "Χρώμα Κουτιού"
        Me.LayoutControlItem21.TextSize = New System.Drawing.Size(124, 13)
        '
        'LayoutControlItem26
        '
        Me.LayoutControlItem26.Control = Me.cboSides
        Me.LayoutControlItem26.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem26.CustomizationFormText = "Εμφανές Πλαϊνο"
        Me.LayoutControlItem26.Location = New System.Drawing.Point(0, 406)
        Me.LayoutControlItem26.Name = "LayoutControlItem26"
        Me.LayoutControlItem26.Size = New System.Drawing.Size(380, 24)
        Me.LayoutControlItem26.Text = "Εμφανές Πλαϊνο"
        Me.LayoutControlItem26.TextSize = New System.Drawing.Size(124, 13)
        '
        'LayoutControlItem25
        '
        Me.LayoutControlItem25.Control = Me.cboBENCH
        Me.LayoutControlItem25.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem25.CustomizationFormText = "Κατηγορία"
        Me.LayoutControlItem25.Location = New System.Drawing.Point(0, 478)
        Me.LayoutControlItem25.Name = "LayoutControlItem25"
        Me.LayoutControlItem25.Size = New System.Drawing.Size(380, 24)
        Me.LayoutControlItem25.Text = "Πάγκος"
        Me.LayoutControlItem25.TextSize = New System.Drawing.Size(124, 13)
        '
        'LayoutControlItem29
        '
        Me.LayoutControlItem29.Control = Me.cboDim
        Me.LayoutControlItem29.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem29.CustomizationFormText = "Επωνυμία"
        Me.LayoutControlItem29.Location = New System.Drawing.Point(0, 430)
        Me.LayoutControlItem29.Name = "LayoutControlItem29"
        Me.LayoutControlItem29.Size = New System.Drawing.Size(380, 24)
        Me.LayoutControlItem29.Text = "Διάσταση"
        Me.LayoutControlItem29.TextSize = New System.Drawing.Size(124, 13)
        '
        'LayoutControlItem20
        '
        Me.LayoutControlItem20.Control = Me.cboPVCColors
        Me.LayoutControlItem20.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem20.CustomizationFormText = "Χρώμα PVC"
        Me.LayoutControlItem20.Location = New System.Drawing.Point(0, 382)
        Me.LayoutControlItem20.Name = "LayoutControlItem20"
        Me.LayoutControlItem20.Size = New System.Drawing.Size(380, 24)
        Me.LayoutControlItem20.Text = "Χρώμα PVC"
        Me.LayoutControlItem20.TextSize = New System.Drawing.Size(124, 13)
        '
        'LayoutControlItem44
        '
        Me.LayoutControlItem44.Control = Me.cboExtraBENCH
        Me.LayoutControlItem44.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem44.CustomizationFormText = "Κατηγορία"
        Me.LayoutControlItem44.Location = New System.Drawing.Point(0, 502)
        Me.LayoutControlItem44.Name = "LayoutControlItem44"
        Me.LayoutControlItem44.Size = New System.Drawing.Size(380, 24)
        Me.LayoutControlItem44.Text = "Extra Πάγκος"
        Me.LayoutControlItem44.TextSize = New System.Drawing.Size(124, 13)
        '
        'LayoutControlItem23
        '
        Me.LayoutControlItem23.Control = Me.cboERM
        Me.LayoutControlItem23.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem23.CustomizationFormText = "Κατηγορία"
        Me.LayoutControlItem23.Location = New System.Drawing.Point(143, 262)
        Me.LayoutControlItem23.Name = "LayoutControlItem23"
        Me.LayoutControlItem23.Size = New System.Drawing.Size(237, 24)
        Me.LayoutControlItem23.Text = "Ερμάριο"
        Me.LayoutControlItem23.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
        Me.LayoutControlItem23.TextSize = New System.Drawing.Size(38, 13)
        Me.LayoutControlItem23.TextToControlDistance = 5
        '
        'LayoutControlItem24
        '
        Me.LayoutControlItem24.Control = Me.txtlegs
        Me.LayoutControlItem24.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem24.CustomizationFormText = "Κατηγορία"
        Me.LayoutControlItem24.HighlightFocusedItem = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlItem24.Location = New System.Drawing.Point(232, 454)
        Me.LayoutControlItem24.Name = "LayoutControlItem24"
        Me.LayoutControlItem24.Size = New System.Drawing.Size(105, 24)
        Me.LayoutControlItem24.Text = "Πόδια"
        Me.LayoutControlItem24.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
        Me.LayoutControlItem24.TextSize = New System.Drawing.Size(27, 13)
        Me.LayoutControlItem24.TextToControlDistance = 5
        '
        'EmptySpaceItem14
        '
        Me.EmptySpaceItem14.AllowHotTrack = False
        Me.EmptySpaceItem14.Location = New System.Drawing.Point(337, 454)
        Me.EmptySpaceItem14.Name = "EmptySpaceItem14"
        Me.EmptySpaceItem14.Size = New System.Drawing.Size(43, 24)
        Me.EmptySpaceItem14.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem43
        '
        Me.LayoutControlItem43.Control = Me.txtbenchExtraDim
        Me.LayoutControlItem43.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem43.CustomizationFormText = "Ύψος"
        Me.LayoutControlItem43.HighlightFocusedItem = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlItem43.Location = New System.Drawing.Point(0, 526)
        Me.LayoutControlItem43.Name = "LayoutControlItem43"
        Me.LayoutControlItem43.Size = New System.Drawing.Size(190, 24)
        Me.LayoutControlItem43.Text = "Διάσταση (m)"
        Me.LayoutControlItem43.TextSize = New System.Drawing.Size(124, 13)
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.txtWidth
        Me.LayoutControlItem6.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem6.CustomizationFormText = "Ύψος"
        Me.LayoutControlItem6.HighlightFocusedItem = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlItem6.ImageOptions.Image = CType(resources.GetObject("LayoutControlItem6.ImageOptions.Image"), System.Drawing.Image)
        Me.LayoutControlItem6.Location = New System.Drawing.Point(0, 310)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(380, 24)
        Me.LayoutControlItem6.Text = "Πλάτος (cm)"
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(124, 13)
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.txtDepth
        Me.LayoutControlItem3.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem3.CustomizationFormText = "Βάθος"
        Me.LayoutControlItem3.HighlightFocusedItem = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlItem3.ImageOptions.Image = CType(resources.GetObject("LayoutControlItem3.ImageOptions.Image"), System.Drawing.Image)
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 334)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(380, 24)
        Me.LayoutControlItem3.Text = "Βάθος (cm)"
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(124, 13)
        '
        'LayoutControlItem45
        '
        Me.LayoutControlItem45.Control = Me.txtBenchExtraPrice
        Me.LayoutControlItem45.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem45.CustomizationFormText = "Τελική Αξία"
        Me.LayoutControlItem45.HighlightFocusedItem = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlItem45.Location = New System.Drawing.Point(190, 526)
        Me.LayoutControlItem45.Name = "LayoutControlItem45"
        Me.LayoutControlItem45.Size = New System.Drawing.Size(190, 24)
        Me.LayoutControlItem45.Text = "Τιμή Extra Πάγκου"
        Me.LayoutControlItem45.TextSize = New System.Drawing.Size(124, 13)
        '
        'LayoutControlItem46
        '
        Me.LayoutControlItem46.Control = Me.cboDoorType
        Me.LayoutControlItem46.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem46.CustomizationFormText = "Κατηγορία"
        Me.LayoutControlItem46.ImageOptions.Image = CType(resources.GetObject("LayoutControlItem46.ImageOptions.Image"), System.Drawing.Image)
        Me.LayoutControlItem46.Location = New System.Drawing.Point(588, 0)
        Me.LayoutControlItem46.Name = "LayoutControlItem46"
        Me.LayoutControlItem46.Size = New System.Drawing.Size(482, 42)
        Me.LayoutControlItem46.Text = "Πορτάκι"
        Me.LayoutControlItem46.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
        Me.LayoutControlItem46.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem46.TextSize = New System.Drawing.Size(49, 13)
        Me.LayoutControlItem46.TextToControlDistance = 5
        '
        'LayoutControlItem48
        '
        Me.LayoutControlItem48.Control = Me.cboCatSubErm
        Me.LayoutControlItem48.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem48.CustomizationFormText = "Υποκατηγορία"
        Me.LayoutControlItem48.ImageOptions.Image = CType(resources.GetObject("LayoutControlItem48.ImageOptions.Image"), System.Drawing.Image)
        Me.LayoutControlItem48.Location = New System.Drawing.Point(273, 0)
        Me.LayoutControlItem48.Name = "LayoutControlItem48"
        Me.LayoutControlItem48.Size = New System.Drawing.Size(315, 42)
        Me.LayoutControlItem48.Text = "Υποκατηγορία "
        Me.LayoutControlItem48.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
        Me.LayoutControlItem48.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem48.TextSize = New System.Drawing.Size(81, 13)
        Me.LayoutControlItem48.TextToControlDistance = 5
        '
        'LayoutControlItem14
        '
        Me.LayoutControlItem14.Control = Me.txtComments
        Me.LayoutControlItem14.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem14.CustomizationFormText = "Σχόλια"
        Me.LayoutControlItem14.Location = New System.Drawing.Point(0, 550)
        Me.LayoutControlItem14.MinSize = New System.Drawing.Size(129, 36)
        Me.LayoutControlItem14.Name = "LayoutControlItem14"
        Me.LayoutControlItem14.Size = New System.Drawing.Size(380, 60)
        Me.LayoutControlItem14.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem14.Text = "Παρατηρήσεις"
        Me.LayoutControlItem14.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem14.TextSize = New System.Drawing.Size(124, 13)
        '
        'LayoutControlItem56
        '
        Me.LayoutControlItem56.Control = Me.txtHeight
        Me.LayoutControlItem56.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem56.CustomizationFormText = "Ύψος"
        Me.LayoutControlItem56.HighlightFocusedItem = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlItem56.ImageOptions.Image = CType(resources.GetObject("LayoutControlItem56.ImageOptions.Image"), System.Drawing.Image)
        Me.LayoutControlItem56.Location = New System.Drawing.Point(0, 286)
        Me.LayoutControlItem56.Name = "LayoutControlItem56"
        Me.LayoutControlItem56.Size = New System.Drawing.Size(380, 24)
        Me.LayoutControlItem56.Text = "Ύψος (cm)"
        Me.LayoutControlItem56.TextSize = New System.Drawing.Size(124, 13)
        '
        'LayoutControlItem27
        '
        Me.LayoutControlItem27.Control = Me.chkMech
        Me.LayoutControlItem27.Location = New System.Drawing.Point(380, 279)
        Me.LayoutControlItem27.Name = "LayoutControlItem27"
        Me.LayoutControlItem27.Size = New System.Drawing.Size(269, 140)
        Me.LayoutControlItem27.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem27.TextVisible = False
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
        Me.SimpleLabelItem1.Location = New System.Drawing.Point(380, 262)
        Me.SimpleLabelItem1.Name = "SimpleLabelItem1"
        Me.SimpleLabelItem1.Size = New System.Drawing.Size(269, 17)
        Me.SimpleLabelItem1.Text = "Μηχανισμοί"
        Me.SimpleLabelItem1.TextSize = New System.Drawing.Size(124, 13)
        '
        'LayoutControlItem16
        '
        Me.LayoutControlItem16.Control = Me.Pic1
        Me.LayoutControlItem16.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem16.CustomizationFormText = "Φωτογραφία"
        Me.LayoutControlItem16.Location = New System.Drawing.Point(649, 262)
        Me.LayoutControlItem16.Name = "LayoutControlItem16"
        Me.LayoutControlItem16.Size = New System.Drawing.Size(146, 298)
        Me.LayoutControlItem16.Text = "Φωτογραφία Ερμάριου 1"
        Me.LayoutControlItem16.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem16.TextSize = New System.Drawing.Size(124, 13)
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.PicMech
        Me.LayoutControlItem5.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem5.CustomizationFormText = "Φωτογραφία"
        Me.LayoutControlItem5.Location = New System.Drawing.Point(380, 419)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(269, 141)
        Me.LayoutControlItem5.Text = "Φωτογραφία Μηχανισμών"
        Me.LayoutControlItem5.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(124, 13)
        '
        'LayoutControlItem50
        '
        Me.LayoutControlItem50.Control = Me.Pic2
        Me.LayoutControlItem50.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem50.CustomizationFormText = "Φωτογραφία Ερμάριου 1"
        Me.LayoutControlItem50.Location = New System.Drawing.Point(795, 262)
        Me.LayoutControlItem50.Name = "LayoutControlItem50"
        Me.LayoutControlItem50.Size = New System.Drawing.Size(147, 298)
        Me.LayoutControlItem50.Text = "Φωτογραφία Ερμάριου 2"
        Me.LayoutControlItem50.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem50.TextSize = New System.Drawing.Size(124, 13)
        '
        'LayoutControlItem49
        '
        Me.LayoutControlItem49.Control = Me.Pic3
        Me.LayoutControlItem49.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem49.CustomizationFormText = "Φωτογραφία"
        Me.LayoutControlItem49.Location = New System.Drawing.Point(942, 262)
        Me.LayoutControlItem49.Name = "LayoutControlItem49"
        Me.LayoutControlItem49.Size = New System.Drawing.Size(128, 298)
        Me.LayoutControlItem49.Text = "Φωτογραφία Ερμάριου 3"
        Me.LayoutControlItem49.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem49.TextSize = New System.Drawing.Size(124, 13)
        '
        'LayoutControlItem41
        '
        Me.LayoutControlItem41.Control = Me.txtTotalPrice
        Me.LayoutControlItem41.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem41.CustomizationFormText = "Τελική Αξία"
        Me.LayoutControlItem41.HighlightFocusedItem = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlItem41.ImageOptions.Image = CType(resources.GetObject("LayoutControlItem41.ImageOptions.Image"), System.Drawing.Image)
        Me.LayoutControlItem41.Location = New System.Drawing.Point(738, 560)
        Me.LayoutControlItem41.Name = "LayoutControlItem41"
        Me.LayoutControlItem41.Size = New System.Drawing.Size(332, 26)
        Me.LayoutControlItem41.Text = "Συνολική Τιμή"
        Me.LayoutControlItem41.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
        Me.LayoutControlItem41.TextSize = New System.Drawing.Size(78, 13)
        Me.LayoutControlItem41.TextToControlDistance = 11
        '
        'LayoutControlItem28
        '
        Me.LayoutControlItem28.Control = Me.txtQTY
        Me.LayoutControlItem28.Location = New System.Drawing.Point(738, 586)
        Me.LayoutControlItem28.Name = "LayoutControlItem28"
        Me.LayoutControlItem28.Size = New System.Drawing.Size(332, 24)
        Me.LayoutControlItem28.Text = "Τεμάχια"
        Me.LayoutControlItem28.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
        Me.LayoutControlItem28.TextSize = New System.Drawing.Size(37, 13)
        Me.LayoutControlItem28.TextToControlDistance = 52
        '
        'LayoutControlItem40
        '
        Me.LayoutControlItem40.Control = Me.txtCalc
        Me.LayoutControlItem40.Location = New System.Drawing.Point(380, 560)
        Me.LayoutControlItem40.MaxSize = New System.Drawing.Size(358, 50)
        Me.LayoutControlItem40.MinSize = New System.Drawing.Size(358, 50)
        Me.LayoutControlItem40.Name = "LayoutControlItem40"
        Me.LayoutControlItem40.Size = New System.Drawing.Size(358, 50)
        Me.LayoutControlItem40.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem40.Text = "Υπολογισμός"
        Me.LayoutControlItem40.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
        Me.LayoutControlItem40.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem40.TextSize = New System.Drawing.Size(61, 13)
        Me.LayoutControlItem40.TextToControlDistance = 5
        '
        'LayoutControlItem35
        '
        Me.LayoutControlItem35.Control = Me.cmdOffersNew
        Me.LayoutControlItem35.Location = New System.Drawing.Point(0, 772)
        Me.LayoutControlItem35.Name = "LayoutControlItem35"
        Me.LayoutControlItem35.Size = New System.Drawing.Size(133, 32)
        Me.LayoutControlItem35.TextLocation = DevExpress.Utils.Locations.Bottom
        Me.LayoutControlItem35.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem35.TextVisible = False
        '
        'VwSIDESBindingSource
        '
        Me.VwSIDESBindingSource.DataMember = "vw_SIDES"
        Me.VwSIDESBindingSource.DataSource = Me.DreamyKitchenDataSetBindingSource
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
        Me.LayoutControl2.Controls.Add(Me.cmdRecalc)
        Me.LayoutControl2.Controls.Add(Me.cmdTotalOffPrice)
        Me.LayoutControl2.Controls.Add(Me.cmdPrintOffer)
        Me.LayoutControl2.Controls.Add(Me.cmdOffersRefresh)
        Me.LayoutControl2.Controls.Add(Me.cmdOffersEdit)
        Me.LayoutControl2.Controls.Add(Me.cmdOffersDel)
        Me.LayoutControl2.Controls.Add(Me.GridControl1)
        Me.LayoutControl2.Controls.Add(Me.cmdSameOffer)
        Me.LayoutControl2.Controls.Add(Me.chkDoorTypes)
        Me.LayoutControl2.Location = New System.Drawing.Point(1105, -7)
        Me.LayoutControl2.Name = "LayoutControl2"
        Me.LayoutControl2.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(1398, 544, 650, 400)
        Me.LayoutControl2.Root = Me.LayoutControlGroup3
        Me.LayoutControl2.Size = New System.Drawing.Size(765, 823)
        Me.LayoutControl2.TabIndex = 2
        Me.LayoutControl2.Text = "LayoutControl2"
        '
        'cmdRecalc
        '
        Me.cmdRecalc.Location = New System.Drawing.Point(501, 789)
        Me.cmdRecalc.Name = "cmdRecalc"
        Me.cmdRecalc.Size = New System.Drawing.Size(98, 22)
        Me.cmdRecalc.StyleController = Me.LayoutControl2
        Me.cmdRecalc.TabIndex = 57
        Me.cmdRecalc.Text = "Επαναυπολογισμός"
        '
        'cmdTotalOffPrice
        '
        Me.cmdTotalOffPrice.Location = New System.Drawing.Point(603, 789)
        Me.cmdTotalOffPrice.Name = "cmdTotalOffPrice"
        Me.cmdTotalOffPrice.Size = New System.Drawing.Size(89, 22)
        Me.cmdTotalOffPrice.StyleController = Me.LayoutControl2
        Me.cmdTotalOffPrice.TabIndex = 56
        Me.cmdTotalOffPrice.Text = "Συνολική Τιμή"
        '
        'cmdPrintOffer
        '
        Me.cmdPrintOffer.Location = New System.Drawing.Point(696, 789)
        Me.cmdPrintOffer.Name = "cmdPrintOffer"
        Me.cmdPrintOffer.Size = New System.Drawing.Size(57, 22)
        Me.cmdPrintOffer.StyleController = Me.LayoutControl2
        Me.cmdPrintOffer.TabIndex = 55
        Me.cmdPrintOffer.Text = "Εκτύπωση"
        '
        'cmdOffersRefresh
        '
        Me.cmdOffersRefresh.ImageOptions.Image = Global.DreamyKitchenCRM.My.Resources.Resources.icons8_refresh_16
        Me.cmdOffersRefresh.Location = New System.Drawing.Point(12, 318)
        Me.cmdOffersRefresh.Name = "cmdOffersRefresh"
        Me.cmdOffersRefresh.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light
        Me.cmdOffersRefresh.Size = New System.Drawing.Size(33, 22)
        Me.cmdOffersRefresh.StyleController = Me.LayoutControl2
        Me.cmdOffersRefresh.TabIndex = 53
        '
        'cmdOffersEdit
        '
        Me.cmdOffersEdit.ImageOptions.Image = Global.DreamyKitchenCRM.My.Resources.Resources.Edit_16x16
        Me.cmdOffersEdit.Location = New System.Drawing.Point(12, 292)
        Me.cmdOffersEdit.Name = "cmdOffersEdit"
        Me.cmdOffersEdit.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light
        Me.cmdOffersEdit.Size = New System.Drawing.Size(33, 22)
        Me.cmdOffersEdit.StyleController = Me.LayoutControl2
        Me.cmdOffersEdit.TabIndex = 52
        '
        'cmdOffersDel
        '
        Me.cmdOffersDel.ImageOptions.Image = Global.DreamyKitchenCRM.My.Resources.Resources.Remove_16x16
        Me.cmdOffersDel.Location = New System.Drawing.Point(12, 266)
        Me.cmdOffersDel.Name = "cmdOffersDel"
        Me.cmdOffersDel.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light
        Me.cmdOffersDel.Size = New System.Drawing.Size(33, 22)
        Me.cmdOffersDel.StyleController = Me.LayoutControl2
        Me.cmdOffersDel.TabIndex = 51
        '
        'GridControl1
        '
        Me.GridControl1.DataSource = Me.OFFERSBindingSource
        Me.GridControl1.Location = New System.Drawing.Point(49, 266)
        Me.GridControl1.MainView = Me.GridView3
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(704, 519)
        Me.GridControl1.TabIndex = 3
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView3})
        '
        'GridView3
        '
        Me.GridView3.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colID3, Me.colqty, Me.colheight1, Me.colwidth1, Me.coldepth1, Me.coldoor1, Me.colPhoto4, Me.collegs, Me.colDoorTypeName, Me.coloffID, Me.colcatErmID1, Me.colermID, Me.colDoorTypeID1, Me.colcatSubErmID1, Me.colcalculations1, Me.colDoorPrice1, Me.colCatErmName1, Me.colCatSubErmName1, Me.colOfferPrice, Me.colHasMech, Me.colHasSides})
        Me.GridView3.GridControl = Me.GridControl1
        Me.GridView3.GroupCount = 1
        Me.GridView3.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.None, "DoorTypeName", Nothing, ""), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "OfferPrice", Nothing, " (Σύνολο {0:n2}€)")})
        Me.GridView3.Name = "GridView3"
        Me.GridView3.OptionsBehavior.Editable = False
        Me.GridView3.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colDoorTypeName, DevExpress.Data.ColumnSortOrder.Ascending), New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colHasSides, DevExpress.Data.ColumnSortOrder.Ascending)})
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
        Me.colqty.VisibleIndex = 2
        '
        'colheight1
        '
        Me.colheight1.Caption = "Ύψος"
        Me.colheight1.FieldName = "height"
        Me.colheight1.Name = "colheight1"
        Me.colheight1.Visible = True
        Me.colheight1.VisibleIndex = 3
        '
        'colwidth1
        '
        Me.colwidth1.Caption = "Πλάτος"
        Me.colwidth1.FieldName = "width"
        Me.colwidth1.Name = "colwidth1"
        Me.colwidth1.Visible = True
        Me.colwidth1.VisibleIndex = 4
        '
        'coldepth1
        '
        Me.coldepth1.Caption = "Βάθος"
        Me.coldepth1.FieldName = "depth"
        Me.coldepth1.Name = "coldepth1"
        Me.coldepth1.Visible = True
        Me.coldepth1.VisibleIndex = 5
        '
        'coldoor1
        '
        Me.coldoor1.Caption = "Πόρτα"
        Me.coldoor1.FieldName = "door"
        Me.coldoor1.Name = "coldoor1"
        Me.coldoor1.Visible = True
        Me.coldoor1.VisibleIndex = 6
        '
        'colPhoto4
        '
        Me.colPhoto4.Caption = "Φώτο"
        Me.colPhoto4.FieldName = "Photo"
        Me.colPhoto4.Name = "colPhoto4"
        Me.colPhoto4.Visible = True
        Me.colPhoto4.VisibleIndex = 8
        '
        'collegs
        '
        Me.collegs.Caption = "Πόδια"
        Me.collegs.FieldName = "legs"
        Me.collegs.Name = "collegs"
        Me.collegs.Visible = True
        Me.collegs.VisibleIndex = 7
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
        'colDoorTypeID1
        '
        Me.colDoorTypeID1.FieldName = "DoorTypeID"
        Me.colDoorTypeID1.Name = "colDoorTypeID1"
        '
        'colcatSubErmID1
        '
        Me.colcatSubErmID1.FieldName = "catSubErmID"
        Me.colcatSubErmID1.Name = "colcatSubErmID1"
        '
        'colcalculations1
        '
        Me.colcalculations1.FieldName = "calculations"
        Me.colcalculations1.Name = "colcalculations1"
        '
        'colDoorPrice1
        '
        Me.colDoorPrice1.FieldName = "DoorPrice"
        Me.colDoorPrice1.Name = "colDoorPrice1"
        '
        'colCatErmName1
        '
        Me.colCatErmName1.Caption = "Κατηγορία"
        Me.colCatErmName1.FieldName = "CatErmName"
        Me.colCatErmName1.Name = "colCatErmName1"
        Me.colCatErmName1.Visible = True
        Me.colCatErmName1.VisibleIndex = 0
        '
        'colCatSubErmName1
        '
        Me.colCatSubErmName1.Caption = "Υποκατηγορία"
        Me.colCatSubErmName1.FieldName = "CatSubErmName"
        Me.colCatSubErmName1.Name = "colCatSubErmName1"
        Me.colCatSubErmName1.Visible = True
        Me.colCatSubErmName1.VisibleIndex = 1
        '
        'colOfferPrice
        '
        Me.colOfferPrice.Caption = "Τιμή"
        Me.colOfferPrice.FieldName = "OfferPrice"
        Me.colOfferPrice.Name = "colOfferPrice"
        Me.colOfferPrice.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "OfferPrice", "SUM={0:0.##}")})
        Me.colOfferPrice.Visible = True
        Me.colOfferPrice.VisibleIndex = 9
        '
        'colHasMech
        '
        Me.colHasMech.Caption = "Μηχανισμοί"
        Me.colHasMech.FieldName = "HasMech"
        Me.colHasMech.Name = "colHasMech"
        Me.colHasMech.Visible = True
        Me.colHasMech.VisibleIndex = 10
        '
        'colHasSides
        '
        Me.colHasSides.Caption = "Πλαϊνά-Καταφραγές"
        Me.colHasSides.FieldName = "HasSides"
        Me.colHasSides.Name = "colHasSides"
        Me.colHasSides.Visible = True
        Me.colHasSides.VisibleIndex = 11
        '
        'cmdSameOffer
        '
        Me.cmdSameOffer.Location = New System.Drawing.Point(49, 240)
        Me.cmdSameOffer.Name = "cmdSameOffer"
        Me.cmdSameOffer.Size = New System.Drawing.Size(704, 22)
        Me.cmdSameOffer.StyleController = Me.LayoutControl2
        Me.cmdSameOffer.TabIndex = 4
        Me.cmdSameOffer.Text = "Ίδια Προσφορά για επιλεγμένα πορτάκια"
        '
        'chkDoorTypes
        '
        Me.chkDoorTypes.CheckOnClick = True
        Me.chkDoorTypes.HorizontalScrollbar = True
        Me.chkDoorTypes.Location = New System.Drawing.Point(49, 29)
        Me.chkDoorTypes.MultiColumn = True
        Me.chkDoorTypes.Name = "chkDoorTypes"
        Me.chkDoorTypes.Size = New System.Drawing.Size(704, 207)
        Me.chkDoorTypes.SortOrder = System.Windows.Forms.SortOrder.Ascending
        Me.chkDoorTypes.StyleController = Me.LayoutControl2
        Me.chkDoorTypes.TabIndex = 49
        Me.chkDoorTypes.Tag = ""
        '
        'LayoutControlGroup3
        '
        Me.LayoutControlGroup3.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup3.GroupBordersVisible = False
        Me.LayoutControlGroup3.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem32, Me.SimpleLabelItem2, Me.LayoutControlItem33, Me.LayoutControlItem34, Me.EmptySpaceItem9, Me.EmptySpaceItem10, Me.LayoutControlItem36, Me.LayoutControlItem37, Me.LayoutControlItem38, Me.LayoutControlItem51, Me.EmptySpaceItem1, Me.LayoutControlItem47, Me.LayoutControlItem54})
        Me.LayoutControlGroup3.Name = "Root"
        Me.LayoutControlGroup3.Size = New System.Drawing.Size(765, 823)
        Me.LayoutControlGroup3.TextVisible = False
        '
        'LayoutControlItem32
        '
        Me.LayoutControlItem32.Control = Me.chkDoorTypes
        Me.LayoutControlItem32.Location = New System.Drawing.Point(37, 17)
        Me.LayoutControlItem32.Name = "LayoutControlItem32"
        Me.LayoutControlItem32.Size = New System.Drawing.Size(708, 211)
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
        Me.SimpleLabelItem2.Location = New System.Drawing.Point(37, 0)
        Me.SimpleLabelItem2.Name = "SimpleLabelItem2"
        Me.SimpleLabelItem2.Size = New System.Drawing.Size(708, 17)
        Me.SimpleLabelItem2.Text = "Πορτάκια"
        Me.SimpleLabelItem2.TextSize = New System.Drawing.Size(53, 13)
        '
        'LayoutControlItem33
        '
        Me.LayoutControlItem33.Control = Me.cmdSameOffer
        Me.LayoutControlItem33.Location = New System.Drawing.Point(37, 228)
        Me.LayoutControlItem33.Name = "LayoutControlItem33"
        Me.LayoutControlItem33.Size = New System.Drawing.Size(708, 26)
        Me.LayoutControlItem33.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem33.TextVisible = False
        '
        'LayoutControlItem34
        '
        Me.LayoutControlItem34.Control = Me.GridControl1
        Me.LayoutControlItem34.Location = New System.Drawing.Point(37, 254)
        Me.LayoutControlItem34.Name = "LayoutControlItem34"
        Me.LayoutControlItem34.Size = New System.Drawing.Size(708, 523)
        Me.LayoutControlItem34.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem34.TextVisible = False
        '
        'EmptySpaceItem9
        '
        Me.EmptySpaceItem9.AllowHotTrack = False
        Me.EmptySpaceItem9.Location = New System.Drawing.Point(0, 332)
        Me.EmptySpaceItem9.Name = "EmptySpaceItem9"
        Me.EmptySpaceItem9.Size = New System.Drawing.Size(37, 445)
        Me.EmptySpaceItem9.TextSize = New System.Drawing.Size(0, 0)
        '
        'EmptySpaceItem10
        '
        Me.EmptySpaceItem10.AllowHotTrack = False
        Me.EmptySpaceItem10.Location = New System.Drawing.Point(0, 0)
        Me.EmptySpaceItem10.Name = "EmptySpaceItem10"
        Me.EmptySpaceItem10.Size = New System.Drawing.Size(37, 254)
        Me.EmptySpaceItem10.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem36
        '
        Me.LayoutControlItem36.Control = Me.cmdOffersDel
        Me.LayoutControlItem36.Location = New System.Drawing.Point(0, 254)
        Me.LayoutControlItem36.Name = "LayoutControlItem36"
        Me.LayoutControlItem36.Size = New System.Drawing.Size(37, 26)
        Me.LayoutControlItem36.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem36.TextVisible = False
        '
        'LayoutControlItem37
        '
        Me.LayoutControlItem37.Control = Me.cmdOffersEdit
        Me.LayoutControlItem37.Location = New System.Drawing.Point(0, 280)
        Me.LayoutControlItem37.Name = "LayoutControlItem37"
        Me.LayoutControlItem37.Size = New System.Drawing.Size(37, 26)
        Me.LayoutControlItem37.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem37.TextVisible = False
        '
        'LayoutControlItem38
        '
        Me.LayoutControlItem38.Control = Me.cmdOffersRefresh
        Me.LayoutControlItem38.Location = New System.Drawing.Point(0, 306)
        Me.LayoutControlItem38.Name = "LayoutControlItem38"
        Me.LayoutControlItem38.Size = New System.Drawing.Size(37, 26)
        Me.LayoutControlItem38.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem38.TextVisible = False
        '
        'LayoutControlItem51
        '
        Me.LayoutControlItem51.Control = Me.cmdPrintOffer
        Me.LayoutControlItem51.Location = New System.Drawing.Point(684, 777)
        Me.LayoutControlItem51.Name = "LayoutControlItem51"
        Me.LayoutControlItem51.Size = New System.Drawing.Size(61, 26)
        Me.LayoutControlItem51.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem51.TextVisible = False
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(0, 777)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(489, 26)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem47
        '
        Me.LayoutControlItem47.Control = Me.cmdTotalOffPrice
        Me.LayoutControlItem47.Location = New System.Drawing.Point(591, 777)
        Me.LayoutControlItem47.Name = "LayoutControlItem47"
        Me.LayoutControlItem47.Size = New System.Drawing.Size(93, 26)
        Me.LayoutControlItem47.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem47.TextVisible = False
        '
        'LayoutControlItem54
        '
        Me.LayoutControlItem54.Control = Me.cmdRecalc
        Me.LayoutControlItem54.Location = New System.Drawing.Point(489, 777)
        Me.LayoutControlItem54.Name = "LayoutControlItem54"
        Me.LayoutControlItem54.Size = New System.Drawing.Size(102, 26)
        Me.LayoutControlItem54.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem54.TextVisible = False
        '
        'VwDOORTYPEBindingSource
        '
        Me.VwDOORTYPEBindingSource.DataMember = "vw_DOOR_TYPE"
        Me.VwDOORTYPEBindingSource.DataSource = Me.DreamyKitchenDataSetBindingSource
        '
        'Vw_DOOR_TYPETableAdapter
        '
        Me.Vw_DOOR_TYPETableAdapter.ClearBeforeFill = True
        '
        'Vw_SIDESTableAdapter
        '
        Me.Vw_SIDESTableAdapter.ClearBeforeFill = True
        '
        'frmOffer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.cmdExit
        Me.ClientSize = New System.Drawing.Size(1869, 810)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Controls.Add(Me.LayoutControl2)
        Me.IconOptions.Image = Global.DreamyKitchenCRM.My.Resources.Resources.favicon
        Me.Name = "frmOffer"
        Me.Text = "frmOffer"
        CType(Me.grdMain, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VwERMBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DreamyKitchenDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DreamyKitchenDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.chkMech, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtdtPresentation.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtQTY.Properties, System.ComponentModel.ISupportInitialize).EndInit()
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
        CType(Me.Pic1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkDimChanged.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboERM.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtlegs.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboBENCH.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboSides.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboDim.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpresentation.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpresentation.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCalc.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTotalPrice.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboExtraBENCH.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtbenchExtraDim.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtBenchExtraPrice.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboDoorType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboCatSubErm.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pic3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pic2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicMech.Properties, System.ComponentModel.ISupportInitialize).EndInit()
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
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem19, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem31, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem39, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem52, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem22, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem21, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem26, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem25, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem29, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem20, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem44, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem23, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem24, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem43, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem45, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem46, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem48, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem56, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem27, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SimpleLabelItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem50, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem49, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem41, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem28, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem40, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem35, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VwSIDESBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OFFERSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl2.ResumeLayout(False)
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkDoorTypes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem32, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SimpleLabelItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem33, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem34, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem36, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem37, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem38, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem51, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem47, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem54, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VwDOORTYPEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents LayoutControlItem56 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem52 As DevExpress.XtraLayout.LayoutControlItem
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
    Friend WithEvents Pic1 As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents LayoutControlItem16 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents chkDimChanged As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents LayoutControlItem22 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents cboERM As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LayoutControlItem23 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents txtlegs As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem24 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents cboBENCH As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LayoutControlItem25 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents cboSides As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LayoutControlItem26 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents SimpleLabelItem1 As DevExpress.XtraLayout.SimpleLabelItem
    Friend WithEvents txtQTY As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem28 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents cboDim As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LayoutControlItem29 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents dtpresentation As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LayoutControlItem30 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents txtdtPresentation As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem31 As DevExpress.XtraLayout.LayoutControlItem
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
    Friend WithEvents collegs As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDoorTypeName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LayoutControlItem33 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem34 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents cmdOffersRefresh As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdOffersEdit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdOffersDel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents EmptySpaceItem9 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem10 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LayoutControlItem36 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem37 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem38 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents coloffID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cmdSaveOff As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem39 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents colcatErmID1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colermID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtCalc As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem40 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents txtTotalPrice As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem41 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents cboExtraBENCH As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LayoutControlItem44 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents txtbenchExtraDim As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem43 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem14 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents txtBenchExtraPrice As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem45 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents cboDoorType As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LayoutControlItem46 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents cboCatSubErm As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LayoutControlItem48 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents Pic3 As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents LayoutControlItem49 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents Pic2 As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents LayoutControlItem50 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents VwSIDESBindingSource As BindingSource
    Friend WithEvents Vw_SIDESTableAdapter As DreamyKitchenDataSetTableAdapters.vw_SIDESTableAdapter
    Friend WithEvents colPhoto4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDoorTypeID1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colcatSubErmID1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PicMech As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents colcalculations1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDoorPrice1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cmdPrintOffer As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem51 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem4 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents cmdOffersNew As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem35 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem3 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents chkMech As DevExpress.XtraEditors.CheckedListBoxControl
    Friend WithEvents LayoutControlItem27 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem5 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents colCatSubErmName1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCatErmName1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colcode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCustomCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colcatSubErmName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colcatErmName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colheight As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldoorName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colcat As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colcatSubErmID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colwidth As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldepth As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldoor As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colphoto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colphoto21 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colphoto31 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPVCcolorName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBoxColorName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBoxColorPhoto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDoorTypeID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colcatErmID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colcalculations As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDoorPrice As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colcalcID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOfferPrice As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colHasMech As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colHasSides As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cmdTotalOffPrice As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem47 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents cmdRecalc As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem54 As DevExpress.XtraLayout.LayoutControlItem
End Class
