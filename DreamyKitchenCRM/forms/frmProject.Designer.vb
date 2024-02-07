Imports DevExpress.XtraLayout

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmProject
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
        Dim EditorButtonImageOptions1 As DevExpress.XtraEditors.Controls.EditorButtonImageOptions = New DevExpress.XtraEditors.Controls.EditorButtonImageOptions()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProject))
        Dim SerializableAppearanceObject1 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject2 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject3 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject4 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.cboInvoiceType = New DevExpress.XtraEditors.LookUpEdit()
        Me.VwINVTYPESBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DreamyKitchenDataSet = New DreamyKitchenCRM.DreamyKitchenDataSet()
        Me.MemoEdit1 = New DevExpress.XtraEditors.TextEdit()
        Me.cmdOpenTransh = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdExit = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdSaveTransH = New DevExpress.XtraEditors.SimpleButton()
        Me.cboCUS = New DevExpress.XtraEditors.LookUpEdit()
        Me.dtCharge = New DevExpress.XtraEditors.DateEdit()
        Me.txtCodeH = New DevExpress.XtraEditors.TextEdit()
        Me.cboSaler = New DevExpress.XtraEditors.LookUpEdit()
        Me.cboTransC = New DevExpress.XtraEditors.CheckedComboBoxEdit()
        Me.VwTRANSHCBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DM_TRANS = New DreamyKitchenCRM.DM_TRANS()
        Me.cboCOU = New DevExpress.XtraEditors.LookUpEdit()
        Me.cboAREAS = New DevExpress.XtraEditors.LookUpEdit()
        Me.cboADR = New DevExpress.XtraEditors.LookUpEdit()
        Me.txtDebitCost = New DevExpress.XtraEditors.TextEdit()
        Me.cboCompany = New DevExpress.XtraEditors.LookUpEdit()
        Me.VwCOMPBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DM_CCT = New DreamyKitchenCRM.DM_CCT()
        Me.cboCompProject = New DevExpress.XtraEditors.LookUpEdit()
        Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LCodeH = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LSaler = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LTransC = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LCus = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LCou = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LArea = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LAdr = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LDescr = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LdtCharge = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LDebitCost = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LComp = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LCompProject = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.Vw_COMPTableAdapter = New DreamyKitchenCRM.DM_CCTTableAdapters.vw_COMPTableAdapter()
        Me.Vw_INVTYPESTableAdapter = New DreamyKitchenCRM.DreamyKitchenDataSetTableAdapters.vw_INVTYPESTableAdapter()
        Me.Vw_TRANSH_CTableAdapter = New DreamyKitchenCRM.DM_TRANSTableAdapters.vw_TRANSH_CTableAdapter()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.cboInvoiceType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VwINVTYPESBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DreamyKitchenDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MemoEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboCUS.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtCharge.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtCharge.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodeH.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboSaler.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboTransC.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VwTRANSHCBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DM_TRANS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboCOU.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboAREAS.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboADR.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDebitCost.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboCompany.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VwCOMPBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DM_CCT, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboCompProject.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LCodeH, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LSaler, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LTransC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LCus, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LCou, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LArea, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LAdr, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LDescr, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LdtCharge, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LDebitCost, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LComp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LCompProject, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.cboInvoiceType)
        Me.LayoutControl1.Controls.Add(Me.MemoEdit1)
        Me.LayoutControl1.Controls.Add(Me.cmdOpenTransh)
        Me.LayoutControl1.Controls.Add(Me.cmdExit)
        Me.LayoutControl1.Controls.Add(Me.cmdSaveTransH)
        Me.LayoutControl1.Controls.Add(Me.cboCUS)
        Me.LayoutControl1.Controls.Add(Me.dtCharge)
        Me.LayoutControl1.Controls.Add(Me.txtCodeH)
        Me.LayoutControl1.Controls.Add(Me.cboSaler)
        Me.LayoutControl1.Controls.Add(Me.cboTransC)
        Me.LayoutControl1.Controls.Add(Me.cboCOU)
        Me.LayoutControl1.Controls.Add(Me.cboAREAS)
        Me.LayoutControl1.Controls.Add(Me.cboADR)
        Me.LayoutControl1.Controls.Add(Me.txtDebitCost)
        Me.LayoutControl1.Controls.Add(Me.cboCompany)
        Me.LayoutControl1.Controls.Add(Me.cboCompProject)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Margin = New System.Windows.Forms.Padding(2)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.Root = Me.Root
        Me.LayoutControl1.Size = New System.Drawing.Size(539, 420)
        Me.LayoutControl1.TabIndex = 0
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'cboInvoiceType
        '
        Me.cboInvoiceType.Location = New System.Drawing.Point(134, 184)
        Me.cboInvoiceType.Name = "cboInvoiceType"
        Me.cboInvoiceType.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboInvoiceType.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("invType", "inv Type", 50, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("invTypeDescr", "ΤΥΠΟΣ ΠΑΡΑΣΤΑΤΙΚΟΥ", 80, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default])})
        Me.cboInvoiceType.Properties.DataSource = Me.VwINVTYPESBindingSource
        Me.cboInvoiceType.Properties.DisplayMember = "invTypeDescr"
        Me.cboInvoiceType.Properties.NullText = ""
        Me.cboInvoiceType.Properties.PopupSizeable = False
        Me.cboInvoiceType.Properties.ValueMember = "invType"
        Me.cboInvoiceType.Size = New System.Drawing.Size(393, 20)
        Me.cboInvoiceType.StyleController = Me.LayoutControl1
        Me.cboInvoiceType.TabIndex = 98
        Me.cboInvoiceType.Tag = "invType,0,1,2"
        '
        'VwINVTYPESBindingSource
        '
        Me.VwINVTYPESBindingSource.DataMember = "vw_INVTYPES"
        Me.VwINVTYPESBindingSource.DataSource = Me.DreamyKitchenDataSet
        '
        'DreamyKitchenDataSet
        '
        Me.DreamyKitchenDataSet.DataSetName = "DreamyKitchenDataSet"
        Me.DreamyKitchenDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MemoEdit1
        '
        Me.MemoEdit1.Location = New System.Drawing.Point(146, 337)
        Me.MemoEdit1.Name = "MemoEdit1"
        Me.MemoEdit1.Size = New System.Drawing.Size(369, 20)
        Me.MemoEdit1.StyleController = Me.LayoutControl1
        Me.MemoEdit1.TabIndex = 63
        Me.MemoEdit1.Tag = "description,0,1,2"
        '
        'cmdOpenTransh
        '
        Me.cmdOpenTransh.Enabled = False
        Me.cmdOpenTransh.ImageOptions.Image = Global.DreamyKitchenCRM.My.Resources.Resources.icons8_project_24
        Me.cmdOpenTransh.Location = New System.Drawing.Point(12, 373)
        Me.cmdOpenTransh.Name = "cmdOpenTransh"
        Me.cmdOpenTransh.Size = New System.Drawing.Size(173, 28)
        Me.cmdOpenTransh.StyleController = Me.LayoutControl1
        Me.cmdOpenTransh.TabIndex = 49
        Me.cmdOpenTransh.Text = "Πλήρης Στοιχεία Έργου"
        '
        'cmdExit
        '
        Me.cmdExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdExit.ImageOptions.Image = Global.DreamyKitchenCRM.My.Resources.Resources.icons8_exit_24
        Me.cmdExit.Location = New System.Drawing.Point(423, 373)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(104, 28)
        Me.cmdExit.StyleController = Me.LayoutControl1
        Me.cmdExit.TabIndex = 48
        Me.cmdExit.Text = "Έξοδος"
        '
        'cmdSaveTransH
        '
        Me.cmdSaveTransH.ImageOptions.Image = Global.DreamyKitchenCRM.My.Resources.Resources.icons8_save_close_24
        Me.cmdSaveTransH.Location = New System.Drawing.Point(306, 373)
        Me.cmdSaveTransH.Name = "cmdSaveTransH"
        Me.cmdSaveTransH.Size = New System.Drawing.Size(113, 28)
        Me.cmdSaveTransH.StyleController = Me.LayoutControl1
        Me.cmdSaveTransH.TabIndex = 44
        Me.cmdSaveTransH.Text = "Αποθήκευση"
        '
        'cboCUS
        '
        Me.cboCUS.Location = New System.Drawing.Point(134, 108)
        Me.cboCUS.Name = "cboCUS"
        Me.cboCUS.Properties.AllowMouseWheel = False
        Me.cboCUS.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        EditorButtonImageOptions1.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.[False]
        EditorButtonImageOptions1.Image = CType(resources.GetObject("EditorButtonImageOptions1.Image"), System.Drawing.Image)
        Me.cboCUS.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, True, EditorButtonImageOptions1, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, SerializableAppearanceObject2, SerializableAppearanceObject3, SerializableAppearanceObject4, "", Nothing, Nothing, DevExpress.Utils.ToolTipAnchor.[Default]), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Search), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Clear)})
        Me.cboCUS.Properties.NullText = ""
        Me.cboCUS.Properties.PopupSizeable = False
        Me.cboCUS.Size = New System.Drawing.Size(393, 24)
        Me.cboCUS.StyleController = Me.LayoutControl1
        Me.cboCUS.TabIndex = 34
        Me.cboCUS.Tag = "cusID,0,1,2"
        '
        'dtCharge
        '
        Me.dtCharge.EditValue = Nothing
        Me.dtCharge.Location = New System.Drawing.Point(134, 160)
        Me.dtCharge.Name = "dtCharge"
        Me.dtCharge.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtCharge.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtCharge.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.dtCharge.Size = New System.Drawing.Size(393, 20)
        Me.dtCharge.StyleController = Me.LayoutControl1
        Me.dtCharge.TabIndex = 37
        Me.dtCharge.Tag = "dtCharge,0,1,2"
        '
        'txtCodeH
        '
        Me.txtCodeH.Location = New System.Drawing.Point(134, 12)
        Me.txtCodeH.Name = "txtCodeH"
        Me.txtCodeH.Properties.Appearance.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.txtCodeH.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtCodeH.Properties.Appearance.Options.UseBackColor = True
        Me.txtCodeH.Properties.Appearance.Options.UseFont = True
        Me.txtCodeH.Properties.ReadOnly = True
        Me.txtCodeH.Size = New System.Drawing.Size(57, 20)
        Me.txtCodeH.StyleController = Me.LayoutControl1
        Me.txtCodeH.TabIndex = 33
        Me.txtCodeH.Tag = "code,0"
        '
        'cboSaler
        '
        Me.cboSaler.Location = New System.Drawing.Point(134, 36)
        Me.cboSaler.Name = "cboSaler"
        Me.cboSaler.Properties.AllowMouseWheel = False
        Me.cboSaler.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.cboSaler.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Search), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Clear)})
        Me.cboSaler.Properties.NullText = ""
        Me.cboSaler.Properties.PopupSizeable = False
        Me.cboSaler.Size = New System.Drawing.Size(393, 20)
        Me.cboSaler.StyleController = Me.LayoutControl1
        Me.cboSaler.TabIndex = 35
        Me.cboSaler.Tag = "empID,0,1,2"
        '
        'cboTransC
        '
        Me.cboTransC.EditValue = ""
        Me.cboTransC.Location = New System.Drawing.Point(134, 136)
        Me.cboTransC.Name = "cboTransC"
        Me.cboTransC.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Clear)})
        Me.cboTransC.Properties.DataSource = Me.VwTRANSHCBindingSource
        Me.cboTransC.Properties.DisplayMember = "name"
        Me.cboTransC.Properties.ValueMember = "ID"
        Me.cboTransC.Size = New System.Drawing.Size(393, 20)
        Me.cboTransC.StyleController = Me.LayoutControl1
        Me.cboTransC.TabIndex = 36
        Me.cboTransC.Tag = ""
        '
        'VwTRANSHCBindingSource
        '
        Me.VwTRANSHCBindingSource.DataMember = "vw_TRANSH_C"
        Me.VwTRANSHCBindingSource.DataSource = Me.DM_TRANS
        '
        'DM_TRANS
        '
        Me.DM_TRANS.DataSetName = "DM_TRANS"
        Me.DM_TRANS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'cboCOU
        '
        Me.cboCOU.Location = New System.Drawing.Point(146, 265)
        Me.cboCOU.Name = "cboCOU"
        Me.cboCOU.Properties.AllowMouseWheel = False
        Me.cboCOU.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.cboCOU.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Search), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Clear)})
        Me.cboCOU.Properties.NullText = ""
        Me.cboCOU.Properties.PopupSizeable = False
        Me.cboCOU.Size = New System.Drawing.Size(369, 20)
        Me.cboCOU.StyleController = Me.LayoutControl1
        Me.cboCOU.TabIndex = 5
        Me.cboCOU.Tag = "couid,0,1,2"
        '
        'cboAREAS
        '
        Me.cboAREAS.Location = New System.Drawing.Point(146, 289)
        Me.cboAREAS.Name = "cboAREAS"
        Me.cboAREAS.Properties.AllowMouseWheel = False
        Me.cboAREAS.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.cboAREAS.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Search), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Clear)})
        Me.cboAREAS.Properties.NullText = ""
        Me.cboAREAS.Properties.PopupSizeable = False
        Me.cboAREAS.Size = New System.Drawing.Size(369, 20)
        Me.cboAREAS.StyleController = Me.LayoutControl1
        Me.cboAREAS.TabIndex = 6
        Me.cboAREAS.Tag = "AreaId,0,1,2"
        '
        'cboADR
        '
        Me.cboADR.Location = New System.Drawing.Point(146, 313)
        Me.cboADR.Name = "cboADR"
        Me.cboADR.Properties.AllowMouseWheel = False
        Me.cboADR.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.cboADR.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Search), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Clear)})
        Me.cboADR.Properties.NullText = ""
        Me.cboADR.Properties.PopupSizeable = False
        Me.cboADR.Size = New System.Drawing.Size(369, 20)
        Me.cboADR.StyleController = Me.LayoutControl1
        Me.cboADR.TabIndex = 7
        Me.cboADR.Tag = "adrid,0,1,2"
        '
        'txtDebitCost
        '
        Me.txtDebitCost.EditValue = "0,00 €"
        Me.txtDebitCost.Location = New System.Drawing.Point(134, 208)
        Me.txtDebitCost.Name = "txtDebitCost"
        Me.txtDebitCost.Properties.DisplayFormat.FormatString = "c"
        Me.txtDebitCost.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtDebitCost.Properties.EditFormat.FormatString = "n2"
        Me.txtDebitCost.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtDebitCost.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtDebitCost.Properties.MaskSettings.Set("MaskManagerType", GetType(DevExpress.Data.Mask.NumericMaskManager))
        Me.txtDebitCost.Properties.MaskSettings.Set("mask", "c2")
        Me.txtDebitCost.Properties.Tag = "BenchExtraPrice"
        Me.txtDebitCost.Size = New System.Drawing.Size(393, 20)
        Me.txtDebitCost.StyleController = Me.LayoutControl1
        Me.txtDebitCost.TabIndex = 42
        Me.txtDebitCost.Tag = "DebitCost,0,1,2"
        Me.txtDebitCost.Visible = False
        '
        'cboCompany
        '
        Me.cboCompany.Location = New System.Drawing.Point(134, 60)
        Me.cboCompany.Name = "cboCompany"
        Me.cboCompany.Properties.AllowMouseWheel = False
        Me.cboCompany.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.cboCompany.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Search), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Clear)})
        Me.cboCompany.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 21, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("code", "code", 33, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Fullname", "Όνομα", 55, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CouID", "Cou ID", 44, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("AreaID", "Area ID", 47, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("AdrID", "Adr ID", 42, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("SourceID", "Source ID", 59, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("SalerID", "Saler ID", 50, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("DoyID", "Doy ID", 44, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("PrfID", "Prf ID", 38, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("phn", "Τηλέφωνο", 29, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("mob", "mob", 31, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("fax", "fax", 24, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("email", "email", 35, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("afm", "afm", 28, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("cmt", "cmt", 28, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("modifiedBy", "modified By", 68, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("modifiedOn", "modified On", 70, DevExpress.Utils.FormatType.DateTime, "d/M/yyyy", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("createdOn", "created On", 65, DevExpress.Utils.FormatType.DateTime, "d/M/yyyy", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("name", "name", 37, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("RealName", "Real Name", 64, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("COU_Name", "COU_Name", 66, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("SRC_Name", "SRC_Name", 65, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("AREAS_Name", "AREAS_Name", 78, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ADR_Name", "ADR_Name", 66, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("PRF_Name", "PRF_Name", 64, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("SALERS_Name", "SALERS_Name", 83, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("color", "color", 33, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Ar", "Ar", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("tk", "tk", 19, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("createdby_Realname", "createdby_Realname", 115, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("HasFiles", "Has Files", 53, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("createdBy", "created By", 62, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default])})
        Me.cboCompany.Properties.DataSource = Me.VwCOMPBindingSource
        Me.cboCompany.Properties.DisplayMember = "Fullname"
        Me.cboCompany.Properties.NullText = ""
        Me.cboCompany.Properties.PopupSizeable = False
        Me.cboCompany.Properties.ValueMember = "ID"
        Me.cboCompany.Size = New System.Drawing.Size(393, 20)
        Me.cboCompany.StyleController = Me.LayoutControl1
        Me.cboCompany.TabIndex = 96
        Me.cboCompany.Tag = "compID,0,1,2"
        '
        'VwCOMPBindingSource
        '
        Me.VwCOMPBindingSource.DataMember = "vw_COMP"
        Me.VwCOMPBindingSource.DataSource = Me.DM_CCT
        '
        'DM_CCT
        '
        Me.DM_CCT.DataSetName = "DM_CCT"
        Me.DM_CCT.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'cboCompProject
        '
        Me.cboCompProject.Location = New System.Drawing.Point(134, 84)
        Me.cboCompProject.Name = "cboCompProject"
        Me.cboCompProject.Properties.AllowMouseWheel = False
        Me.cboCompProject.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.cboCompProject.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Search), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Clear)})
        Me.cboCompProject.Properties.DisplayMember = "description"
        Me.cboCompProject.Properties.NullText = ""
        Me.cboCompProject.Properties.PopupSizeable = False
        Me.cboCompProject.Properties.ValueMember = "ID"
        Me.cboCompProject.Size = New System.Drawing.Size(393, 20)
        Me.cboCompProject.StyleController = Me.LayoutControl1
        Me.cboCompProject.TabIndex = 97
        Me.cboCompProject.Tag = "compTrashID,0,1,2"
        '
        'Root
        '
        Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.Root.GroupBordersVisible = False
        Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LCodeH, Me.LSaler, Me.EmptySpaceItem1, Me.LayoutControlItem6, Me.LayoutControlItem7, Me.EmptySpaceItem2, Me.LayoutControlItem8, Me.LTransC, Me.LCus, Me.LayoutControlGroup1, Me.LdtCharge, Me.LDebitCost, Me.LComp, Me.LCompProject, Me.LayoutControlItem1})
        Me.Root.Name = "Root"
        Me.Root.Size = New System.Drawing.Size(539, 420)
        Me.Root.TextVisible = False
        '
        'LCodeH
        '
        Me.LCodeH.Control = Me.txtCodeH
        Me.LCodeH.Location = New System.Drawing.Point(0, 0)
        Me.LCodeH.Name = "LCodeH"
        Me.LCodeH.Size = New System.Drawing.Size(183, 24)
        Me.LCodeH.Text = "Κωδικός"
        Me.LCodeH.TextSize = New System.Drawing.Size(110, 13)
        '
        'LSaler
        '
        Me.LSaler.Control = Me.cboSaler
        Me.LSaler.ImageOptions.Image = Global.DreamyKitchenCRM.My.Resources.Resources.rsz_11rsz_asterisk
        Me.LSaler.Location = New System.Drawing.Point(0, 24)
        Me.LSaler.Name = "LSaler"
        Me.LSaler.Size = New System.Drawing.Size(519, 24)
        Me.LSaler.Tag = "1"
        Me.LSaler.Text = "Πωλητής"
        Me.LSaler.TextSize = New System.Drawing.Size(110, 13)
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(183, 0)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(336, 24)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.cmdSaveTransH
        Me.LayoutControlItem6.Location = New System.Drawing.Point(294, 361)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(117, 39)
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem6.TextVisible = False
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.Control = Me.cmdExit
        Me.LayoutControlItem7.Location = New System.Drawing.Point(411, 361)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(108, 39)
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem7.TextVisible = False
        '
        'EmptySpaceItem2
        '
        Me.EmptySpaceItem2.AllowHotTrack = False
        Me.EmptySpaceItem2.Location = New System.Drawing.Point(177, 361)
        Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Size = New System.Drawing.Size(117, 39)
        Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem8
        '
        Me.LayoutControlItem8.Control = Me.cmdOpenTransh
        Me.LayoutControlItem8.Location = New System.Drawing.Point(0, 361)
        Me.LayoutControlItem8.Name = "LayoutControlItem8"
        Me.LayoutControlItem8.Size = New System.Drawing.Size(177, 39)
        Me.LayoutControlItem8.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem8.TextVisible = False
        '
        'LTransC
        '
        Me.LTransC.Control = Me.cboTransC
        Me.LTransC.ImageOptions.Image = Global.DreamyKitchenCRM.My.Resources.Resources.rsz_11rsz_asterisk
        Me.LTransC.Location = New System.Drawing.Point(0, 124)
        Me.LTransC.Name = "LTransC"
        Me.LTransC.Size = New System.Drawing.Size(519, 24)
        Me.LTransC.Tag = "1"
        Me.LTransC.Text = "Κατηγορία"
        Me.LTransC.TextSize = New System.Drawing.Size(110, 13)
        '
        'LCus
        '
        Me.LCus.Control = Me.cboCUS
        Me.LCus.ImageOptions.Image = Global.DreamyKitchenCRM.My.Resources.Resources.rsz_11rsz_asterisk
        Me.LCus.Location = New System.Drawing.Point(0, 96)
        Me.LCus.Name = "LCus"
        Me.LCus.Size = New System.Drawing.Size(519, 28)
        Me.LCus.Tag = "1"
        Me.LCus.Text = "Πελάτης"
        Me.LCus.TextSize = New System.Drawing.Size(110, 13)
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.AppearanceGroup.BorderColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Primary
        Me.LayoutControlGroup1.AppearanceGroup.Options.UseBorderColor = True
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LCou, Me.LArea, Me.LAdr, Me.LDescr})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 220)
        Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(519, 141)
        Me.LayoutControlGroup1.Text = "Στοιχεία Ακινήτου"
        '
        'LCou
        '
        Me.LCou.Control = Me.cboCOU
        Me.LCou.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LCou.CustomizationFormText = "Νομός"
        Me.LCou.HighlightFocusedItem = DevExpress.Utils.DefaultBoolean.[True]
        Me.LCou.ImageOptions.Image = CType(resources.GetObject("LCou.ImageOptions.Image"), System.Drawing.Image)
        Me.LCou.Location = New System.Drawing.Point(0, 0)
        Me.LCou.Name = "LCou"
        Me.LCou.Size = New System.Drawing.Size(495, 24)
        Me.LCou.Tag = "1"
        Me.LCou.Text = "Νομός"
        Me.LCou.TextSize = New System.Drawing.Size(110, 13)
        '
        'LArea
        '
        Me.LArea.Control = Me.cboAREAS
        Me.LArea.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LArea.CustomizationFormText = "Περιοχή"
        Me.LArea.HighlightFocusedItem = DevExpress.Utils.DefaultBoolean.[True]
        Me.LArea.ImageOptions.Image = CType(resources.GetObject("LArea.ImageOptions.Image"), System.Drawing.Image)
        Me.LArea.Location = New System.Drawing.Point(0, 24)
        Me.LArea.Name = "LArea"
        Me.LArea.Size = New System.Drawing.Size(495, 24)
        Me.LArea.Tag = "1"
        Me.LArea.Text = "Περιοχή"
        Me.LArea.TextSize = New System.Drawing.Size(110, 13)
        '
        'LAdr
        '
        Me.LAdr.Control = Me.cboADR
        Me.LAdr.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LAdr.CustomizationFormText = "Διεύθυνση"
        Me.LAdr.HighlightFocusedItem = DevExpress.Utils.DefaultBoolean.[True]
        Me.LAdr.ImageOptions.Image = Global.DreamyKitchenCRM.My.Resources.Resources.rsz_11rsz_asterisk
        Me.LAdr.Location = New System.Drawing.Point(0, 48)
        Me.LAdr.Name = "LAdr"
        Me.LAdr.Size = New System.Drawing.Size(495, 24)
        Me.LAdr.Tag = "1"
        Me.LAdr.Text = "Διεύθυνση"
        Me.LAdr.TextSize = New System.Drawing.Size(110, 13)
        '
        'LDescr
        '
        Me.LDescr.Control = Me.MemoEdit1
        Me.LDescr.ImageOptions.Image = Global.DreamyKitchenCRM.My.Resources.Resources.rsz_11rsz_asterisk
        Me.LDescr.Location = New System.Drawing.Point(0, 72)
        Me.LDescr.Name = "LDescr"
        Me.LDescr.Size = New System.Drawing.Size(495, 24)
        Me.LDescr.Tag = "1"
        Me.LDescr.Text = "Περιγραφή"
        Me.LDescr.TextSize = New System.Drawing.Size(110, 13)
        '
        'LdtCharge
        '
        Me.LdtCharge.Control = Me.dtCharge
        Me.LdtCharge.ImageOptions.Image = Global.DreamyKitchenCRM.My.Resources.Resources.rsz_11rsz_asterisk
        Me.LdtCharge.Location = New System.Drawing.Point(0, 148)
        Me.LdtCharge.Name = "LdtCharge"
        Me.LdtCharge.Size = New System.Drawing.Size(519, 24)
        Me.LdtCharge.Tag = "1"
        Me.LdtCharge.Text = "Ημερομηνία"
        Me.LdtCharge.TextSize = New System.Drawing.Size(110, 13)
        '
        'LDebitCost
        '
        Me.LDebitCost.Control = Me.txtDebitCost
        Me.LDebitCost.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LDebitCost.CustomizationFormText = "Τελική Αξία"
        Me.LDebitCost.HighlightFocusedItem = DevExpress.Utils.DefaultBoolean.[True]
        Me.LDebitCost.ImageOptions.Image = CType(resources.GetObject("LDebitCost.ImageOptions.Image"), System.Drawing.Image)
        Me.LDebitCost.Location = New System.Drawing.Point(0, 196)
        Me.LDebitCost.Name = "LDebitCost"
        Me.LDebitCost.Size = New System.Drawing.Size(519, 24)
        Me.LDebitCost.Tag = "1"
        Me.LDebitCost.Text = "Πώληση Έργου"
        Me.LDebitCost.TextSize = New System.Drawing.Size(110, 13)
        '
        'LComp
        '
        Me.LComp.Control = Me.cboCompany
        Me.LComp.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LComp.CustomizationFormText = "Εταιρία"
        Me.LComp.Location = New System.Drawing.Point(0, 48)
        Me.LComp.Name = "LComp"
        Me.LComp.Size = New System.Drawing.Size(519, 24)
        Me.LComp.Text = "Εταιρία"
        Me.LComp.TextSize = New System.Drawing.Size(110, 13)
        '
        'LCompProject
        '
        Me.LCompProject.Control = Me.cboCompProject
        Me.LCompProject.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LCompProject.CustomizationFormText = "Έργο Εταιρίας"
        Me.LCompProject.Location = New System.Drawing.Point(0, 72)
        Me.LCompProject.Name = "LCompProject"
        Me.LCompProject.Size = New System.Drawing.Size(519, 24)
        Me.LCompProject.Text = "Έργο Εταιρίας"
        Me.LCompProject.TextSize = New System.Drawing.Size(110, 13)
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.cboInvoiceType
        Me.LayoutControlItem1.ImageOptions.Image = Global.DreamyKitchenCRM.My.Resources.Resources.rsz_11rsz_asterisk
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 172)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(519, 24)
        Me.LayoutControlItem1.Tag = "1"
        Me.LayoutControlItem1.Text = "Τύπος Παραστατικού"
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(110, 13)
        '
        'Vw_COMPTableAdapter
        '
        Me.Vw_COMPTableAdapter.ClearBeforeFill = True
        '
        'Vw_INVTYPESTableAdapter
        '
        Me.Vw_INVTYPESTableAdapter.ClearBeforeFill = True
        '
        'Vw_TRANSH_CTableAdapter
        '
        Me.Vw_TRANSH_CTableAdapter.ClearBeforeFill = True
        '
        'frmProject
        '
        Me.Appearance.Options.UseFont = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(539, 420)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.IconOptions.Image = Global.DreamyKitchenCRM.My.Resources.Resources.favicon
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MinimumSize = New System.Drawing.Size(455, 418)
        Me.Name = "frmProject"
        Me.Text = "Έργο"
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.cboInvoiceType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VwINVTYPESBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DreamyKitchenDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MemoEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboCUS.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtCharge.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtCharge.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodeH.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboSaler.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboTransC.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VwTRANSHCBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DM_TRANS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboCOU.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboAREAS.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboADR.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDebitCost.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboCompany.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VwCOMPBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DM_CCT, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboCompProject.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LCodeH, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LSaler, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LTransC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LCus, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LCou, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LArea, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LAdr, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LDescr, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LdtCharge, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LDebitCost, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LComp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LCompProject, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LayoutControl1 As LayoutControl
    Friend WithEvents Root As LayoutControlGroup
    Friend WithEvents cboCUS As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents dtCharge As DevExpress.XtraEditors.DateEdit
    Friend WithEvents txtCodeH As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cboSaler As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents cboTransC As DevExpress.XtraEditors.CheckedComboBoxEdit
    Friend WithEvents LCus As LayoutControlItem
    Friend WithEvents EmptySpaceItem1 As EmptySpaceItem
    Friend WithEvents LdtCharge As LayoutControlItem
    Friend WithEvents LSaler As LayoutControlItem
    Friend WithEvents LTransC As LayoutControlItem
    Friend WithEvents LCodeH As LayoutControlItem
    Friend WithEvents cmdSaveTransH As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem6 As LayoutControlItem
    Friend WithEvents cmdExit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem7 As LayoutControlItem
    Friend WithEvents EmptySpaceItem2 As EmptySpaceItem
    Friend WithEvents DM_TRANS As DM_TRANS
    Friend WithEvents VwTRANSHCBindingSource As BindingSource
    Friend WithEvents Vw_TRANSH_CTableAdapter As DM_TRANSTableAdapters.vw_TRANSH_CTableAdapter
    Friend WithEvents cmdOpenTransh As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem8 As LayoutControlItem
    Friend WithEvents MemoEdit1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LDescr As LayoutControlItem
    Friend WithEvents cboCOU As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents cboAREAS As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents cboADR As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LayoutControlGroup1 As LayoutControlGroup
    Friend WithEvents LCou As LayoutControlItem
    Friend WithEvents LArea As LayoutControlItem
    Friend WithEvents LAdr As LayoutControlItem
    Friend WithEvents txtDebitCost As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LDebitCost As LayoutControlItem
    Friend WithEvents cboCompany As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LComp As LayoutControlItem
    Friend WithEvents DM_CCT As DM_CCT
    Friend WithEvents cboCompProject As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LCompProject As LayoutControlItem
    Friend WithEvents VwCOMPBindingSource As BindingSource
    Friend WithEvents Vw_COMPTableAdapter As DM_CCTTableAdapters.vw_COMPTableAdapter
    Friend WithEvents cboInvoiceType As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LayoutControlItem1 As LayoutControlItem
    Friend WithEvents DreamyKitchenDataSet As DreamyKitchenDataSet
    Friend WithEvents VwINVTYPESBindingSource As BindingSource
    Friend WithEvents Vw_INVTYPESTableAdapter As DreamyKitchenDataSetTableAdapters.vw_INVTYPESTableAdapter
End Class
