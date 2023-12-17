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
        Me.MemoEdit1 = New DevExpress.XtraEditors.TextEdit()
        Me.cmdOpenTransh = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdExit = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdSaveTransH = New DevExpress.XtraEditors.SimpleButton()
        Me.cboCUS = New DevExpress.XtraEditors.LookUpEdit()
        Me.dtCharge = New DevExpress.XtraEditors.DateEdit()
        Me.txtCodeH = New DevExpress.XtraEditors.TextEdit()
        Me.cboSaler = New DevExpress.XtraEditors.LookUpEdit()
        Me.cboTransC = New DevExpress.XtraEditors.CheckedComboBoxEdit()
        Me.cboCOU = New DevExpress.XtraEditors.LookUpEdit()
        Me.cboAREAS = New DevExpress.XtraEditors.LookUpEdit()
        Me.cboADR = New DevExpress.XtraEditors.LookUpEdit()
        Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LCus = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem10 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem11 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.VwTRANSHCBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DM_TRANS = New DreamyKitchenCRM.DM_TRANS()
        Me.Vw_TRANSH_CTableAdapter = New DreamyKitchenCRM.DM_TRANSTableAdapters.vw_TRANSH_CTableAdapter()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.MemoEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboCUS.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtCharge.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtCharge.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodeH.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboSaler.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboTransC.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboCOU.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboAREAS.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboADR.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LCus, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VwTRANSHCBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DM_TRANS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LayoutControl1
        '
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
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.Root = Me.Root
        Me.LayoutControl1.Size = New System.Drawing.Size(838, 510)
        Me.LayoutControl1.TabIndex = 0
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'MemoEdit1
        '
        Me.MemoEdit1.Location = New System.Drawing.Point(147, 397)
        Me.MemoEdit1.Margin = New System.Windows.Forms.Padding(5)
        Me.MemoEdit1.Name = "MemoEdit1"
        Me.MemoEdit1.Size = New System.Drawing.Size(666, 38)
        Me.MemoEdit1.StyleController = Me.LayoutControl1
        Me.MemoEdit1.TabIndex = 63
        Me.MemoEdit1.Tag = "description,0,1,2"
        '
        'cmdOpenTransh
        '
        Me.cmdOpenTransh.Enabled = False
        Me.cmdOpenTransh.ImageOptions.Image = Global.DreamyKitchenCRM.My.Resources.Resources.icons8_project_24
        Me.cmdOpenTransh.Location = New System.Drawing.Point(12, 452)
        Me.cmdOpenTransh.Margin = New System.Windows.Forms.Padding(5)
        Me.cmdOpenTransh.Name = "cmdOpenTransh"
        Me.cmdOpenTransh.Size = New System.Drawing.Size(241, 39)
        Me.cmdOpenTransh.StyleController = Me.LayoutControl1
        Me.cmdOpenTransh.TabIndex = 49
        Me.cmdOpenTransh.Text = "Πλήρης Στοιχεία Έργου"
        '
        'cmdExit
        '
        Me.cmdExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdExit.ImageOptions.Image = Global.DreamyKitchenCRM.My.Resources.Resources.icons8_exit_24
        Me.cmdExit.Location = New System.Drawing.Point(600, 452)
        Me.cmdExit.Margin = New System.Windows.Forms.Padding(5)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(226, 39)
        Me.cmdExit.StyleController = Me.LayoutControl1
        Me.cmdExit.TabIndex = 48
        Me.cmdExit.Text = "Έξοδος"
        '
        'cmdSaveTransH
        '
        Me.cmdSaveTransH.ImageOptions.Image = Global.DreamyKitchenCRM.My.Resources.Resources.icons8_save_close_24
        Me.cmdSaveTransH.Location = New System.Drawing.Point(447, 452)
        Me.cmdSaveTransH.Margin = New System.Windows.Forms.Padding(5)
        Me.cmdSaveTransH.Name = "cmdSaveTransH"
        Me.cmdSaveTransH.Size = New System.Drawing.Size(149, 39)
        Me.cmdSaveTransH.StyleController = Me.LayoutControl1
        Me.cmdSaveTransH.TabIndex = 44
        Me.cmdSaveTransH.Text = "Αποθήκευση"
        '
        'cboCUS
        '
        Me.cboCUS.Location = New System.Drawing.Point(134, 96)
        Me.cboCUS.Margin = New System.Windows.Forms.Padding(5)
        Me.cboCUS.Name = "cboCUS"
        Me.cboCUS.Properties.AllowMouseWheel = False
        Me.cboCUS.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        EditorButtonImageOptions1.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.[False]
        EditorButtonImageOptions1.Image = CType(resources.GetObject("EditorButtonImageOptions1.Image"), System.Drawing.Image)
        Me.cboCUS.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, True, EditorButtonImageOptions1, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, SerializableAppearanceObject2, SerializableAppearanceObject3, SerializableAppearanceObject4, "", Nothing, Nothing, DevExpress.Utils.ToolTipAnchor.[Default]), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Search), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Clear)})
        Me.cboCUS.Properties.NullText = ""
        Me.cboCUS.Properties.PopupSizeable = False
        Me.cboCUS.Size = New System.Drawing.Size(692, 38)
        Me.cboCUS.StyleController = Me.LayoutControl1
        Me.cboCUS.TabIndex = 34
        Me.cboCUS.Tag = "cusID,0,1,2"
        '
        'dtCharge
        '
        Me.dtCharge.EditValue = Nothing
        Me.dtCharge.Location = New System.Drawing.Point(134, 180)
        Me.dtCharge.Margin = New System.Windows.Forms.Padding(5)
        Me.dtCharge.Name = "dtCharge"
        Me.dtCharge.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtCharge.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtCharge.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.dtCharge.Size = New System.Drawing.Size(692, 38)
        Me.dtCharge.StyleController = Me.LayoutControl1
        Me.dtCharge.TabIndex = 37
        Me.dtCharge.Tag = "dtCharge,0,1,2"
        '
        'txtCodeH
        '
        Me.txtCodeH.Location = New System.Drawing.Point(134, 12)
        Me.txtCodeH.Margin = New System.Windows.Forms.Padding(5)
        Me.txtCodeH.Name = "txtCodeH"
        Me.txtCodeH.Properties.Appearance.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.txtCodeH.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtCodeH.Properties.Appearance.Options.UseBackColor = True
        Me.txtCodeH.Properties.Appearance.Options.UseFont = True
        Me.txtCodeH.Properties.ReadOnly = True
        Me.txtCodeH.Size = New System.Drawing.Size(95, 38)
        Me.txtCodeH.StyleController = Me.LayoutControl1
        Me.txtCodeH.TabIndex = 33
        Me.txtCodeH.Tag = "code,0"
        '
        'cboSaler
        '
        Me.cboSaler.Location = New System.Drawing.Point(134, 54)
        Me.cboSaler.Margin = New System.Windows.Forms.Padding(5)
        Me.cboSaler.Name = "cboSaler"
        Me.cboSaler.Properties.AllowMouseWheel = False
        Me.cboSaler.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.cboSaler.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Search), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Clear)})
        Me.cboSaler.Properties.NullText = ""
        Me.cboSaler.Properties.PopupSizeable = False
        Me.cboSaler.Size = New System.Drawing.Size(692, 38)
        Me.cboSaler.StyleController = Me.LayoutControl1
        Me.cboSaler.TabIndex = 35
        Me.cboSaler.Tag = "empID,0,1,2"
        '
        'cboTransC
        '
        Me.cboTransC.EditValue = ""
        Me.cboTransC.Location = New System.Drawing.Point(134, 138)
        Me.cboTransC.Margin = New System.Windows.Forms.Padding(5)
        Me.cboTransC.Name = "cboTransC"
        Me.cboTransC.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Clear)})
        Me.cboTransC.Properties.DataSource = Me.VwTRANSHCBindingSource
        Me.cboTransC.Properties.DisplayMember = "name"
        Me.cboTransC.Properties.ValueMember = "ID"
        Me.cboTransC.Size = New System.Drawing.Size(692, 38)
        Me.cboTransC.StyleController = Me.LayoutControl1
        Me.cboTransC.TabIndex = 36
        Me.cboTransC.Tag = ""
        '
        'cboCOU
        '
        Me.cboCOU.Location = New System.Drawing.Point(147, 271)
        Me.cboCOU.Margin = New System.Windows.Forms.Padding(5)
        Me.cboCOU.Name = "cboCOU"
        Me.cboCOU.Properties.AllowMouseWheel = False
        Me.cboCOU.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.cboCOU.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Search), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Clear)})
        Me.cboCOU.Properties.NullText = ""
        Me.cboCOU.Properties.PopupSizeable = False
        Me.cboCOU.Size = New System.Drawing.Size(666, 38)
        Me.cboCOU.StyleController = Me.LayoutControl1
        Me.cboCOU.TabIndex = 5
        Me.cboCOU.Tag = "couid,0,1,2"
        '
        'cboAREAS
        '
        Me.cboAREAS.Location = New System.Drawing.Point(147, 313)
        Me.cboAREAS.Margin = New System.Windows.Forms.Padding(5)
        Me.cboAREAS.Name = "cboAREAS"
        Me.cboAREAS.Properties.AllowMouseWheel = False
        Me.cboAREAS.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.cboAREAS.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Search), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Clear)})
        Me.cboAREAS.Properties.NullText = ""
        Me.cboAREAS.Properties.PopupSizeable = False
        Me.cboAREAS.Size = New System.Drawing.Size(666, 38)
        Me.cboAREAS.StyleController = Me.LayoutControl1
        Me.cboAREAS.TabIndex = 6
        Me.cboAREAS.Tag = "AreaId,0,1,2"
        '
        'cboADR
        '
        Me.cboADR.Location = New System.Drawing.Point(147, 355)
        Me.cboADR.Margin = New System.Windows.Forms.Padding(5)
        Me.cboADR.Name = "cboADR"
        Me.cboADR.Properties.AllowMouseWheel = False
        Me.cboADR.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.cboADR.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Search), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Clear)})
        Me.cboADR.Properties.NullText = ""
        Me.cboADR.Properties.PopupSizeable = False
        Me.cboADR.Size = New System.Drawing.Size(666, 38)
        Me.cboADR.StyleController = Me.LayoutControl1
        Me.cboADR.TabIndex = 7
        Me.cboADR.Tag = "adrid,0,1,2"
        '
        'Root
        '
        Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.Root.GroupBordersVisible = False
        Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem3, Me.LayoutControlItem4, Me.EmptySpaceItem1, Me.LayoutControlItem6, Me.LayoutControlItem7, Me.EmptySpaceItem2, Me.LayoutControlItem8, Me.LayoutControlItem5, Me.LCus, Me.LayoutControlGroup1, Me.LayoutControlItem2})
        Me.Root.Name = "Root"
        Me.Root.Size = New System.Drawing.Size(838, 510)
        Me.Root.TextVisible = False
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.txtCodeH
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(221, 42)
        Me.LayoutControlItem3.Text = "Κωδικός"
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(110, 23)
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.cboSaler
        Me.LayoutControlItem4.ImageOptions.Image = Global.DreamyKitchenCRM.My.Resources.Resources.rsz_11rsz_asterisk
        Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 42)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(818, 42)
        Me.LayoutControlItem4.Tag = "1"
        Me.LayoutControlItem4.Text = "Πωλητής"
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(110, 23)
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(221, 0)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(597, 42)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.cmdSaveTransH
        Me.LayoutControlItem6.Location = New System.Drawing.Point(435, 440)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(153, 50)
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem6.TextVisible = False
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.Control = Me.cmdExit
        Me.LayoutControlItem7.Location = New System.Drawing.Point(588, 440)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(230, 50)
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem7.TextVisible = False
        '
        'EmptySpaceItem2
        '
        Me.EmptySpaceItem2.AllowHotTrack = False
        Me.EmptySpaceItem2.Location = New System.Drawing.Point(245, 440)
        Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Size = New System.Drawing.Size(190, 50)
        Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem8
        '
        Me.LayoutControlItem8.Control = Me.cmdOpenTransh
        Me.LayoutControlItem8.Location = New System.Drawing.Point(0, 440)
        Me.LayoutControlItem8.Name = "LayoutControlItem8"
        Me.LayoutControlItem8.Size = New System.Drawing.Size(245, 50)
        Me.LayoutControlItem8.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem8.TextVisible = False
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.cboTransC
        Me.LayoutControlItem5.ImageOptions.Image = Global.DreamyKitchenCRM.My.Resources.Resources.rsz_11rsz_asterisk
        Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 126)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(818, 42)
        Me.LayoutControlItem5.Tag = "1"
        Me.LayoutControlItem5.Text = "Κατηγορία"
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(110, 23)
        '
        'LCus
        '
        Me.LCus.Control = Me.cboCUS
        Me.LCus.ImageOptions.Image = Global.DreamyKitchenCRM.My.Resources.Resources.rsz_11rsz_asterisk
        Me.LCus.Location = New System.Drawing.Point(0, 84)
        Me.LCus.Name = "LCus"
        Me.LCus.Size = New System.Drawing.Size(818, 42)
        Me.LCus.Tag = "1"
        Me.LCus.Text = "Πελάτης"
        Me.LCus.TextSize = New System.Drawing.Size(110, 23)
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.AppearanceGroup.BorderColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Primary
        Me.LayoutControlGroup1.AppearanceGroup.Options.UseBorderColor = True
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem9, Me.LayoutControlItem10, Me.LayoutControlItem11, Me.LayoutControlItem1})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 210)
        Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(818, 230)
        Me.LayoutControlGroup1.Text = "Στοιχεία Ακινήτου"
        '
        'LayoutControlItem9
        '
        Me.LayoutControlItem9.Control = Me.cboCOU
        Me.LayoutControlItem9.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem9.CustomizationFormText = "Νομός"
        Me.LayoutControlItem9.HighlightFocusedItem = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlItem9.ImageOptions.Image = CType(resources.GetObject("LayoutControlItem9.ImageOptions.Image"), System.Drawing.Image)
        Me.LayoutControlItem9.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem9.Name = "LayoutControlItem9"
        Me.LayoutControlItem9.Size = New System.Drawing.Size(792, 42)
        Me.LayoutControlItem9.Text = "Νομός"
        Me.LayoutControlItem9.TextSize = New System.Drawing.Size(110, 23)
        '
        'LayoutControlItem10
        '
        Me.LayoutControlItem10.Control = Me.cboAREAS
        Me.LayoutControlItem10.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem10.CustomizationFormText = "Περιοχή"
        Me.LayoutControlItem10.HighlightFocusedItem = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlItem10.ImageOptions.Image = CType(resources.GetObject("LayoutControlItem10.ImageOptions.Image"), System.Drawing.Image)
        Me.LayoutControlItem10.Location = New System.Drawing.Point(0, 42)
        Me.LayoutControlItem10.Name = "LayoutControlItem10"
        Me.LayoutControlItem10.Size = New System.Drawing.Size(792, 42)
        Me.LayoutControlItem10.Text = "Περιοχή"
        Me.LayoutControlItem10.TextSize = New System.Drawing.Size(110, 23)
        '
        'LayoutControlItem11
        '
        Me.LayoutControlItem11.Control = Me.cboADR
        Me.LayoutControlItem11.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem11.CustomizationFormText = "Διεύθυνση"
        Me.LayoutControlItem11.HighlightFocusedItem = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlItem11.ImageOptions.Image = Global.DreamyKitchenCRM.My.Resources.Resources.rsz_11rsz_asterisk
        Me.LayoutControlItem11.Location = New System.Drawing.Point(0, 84)
        Me.LayoutControlItem11.Name = "LayoutControlItem11"
        Me.LayoutControlItem11.Size = New System.Drawing.Size(792, 42)
        Me.LayoutControlItem11.Tag = "1"
        Me.LayoutControlItem11.Text = "Διεύθυνση"
        Me.LayoutControlItem11.TextSize = New System.Drawing.Size(110, 23)
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.MemoEdit1
        Me.LayoutControlItem1.ImageOptions.Image = Global.DreamyKitchenCRM.My.Resources.Resources.rsz_11rsz_asterisk
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 126)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(792, 42)
        Me.LayoutControlItem1.Tag = "1"
        Me.LayoutControlItem1.Text = "Περιγραφή"
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(110, 23)
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.dtCharge
        Me.LayoutControlItem2.ImageOptions.Image = Global.DreamyKitchenCRM.My.Resources.Resources.rsz_11rsz_asterisk
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 168)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(818, 42)
        Me.LayoutControlItem2.Tag = "1"
        Me.LayoutControlItem2.Text = "Ημερομηνία"
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(110, 23)
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
        'Vw_TRANSH_CTableAdapter
        '
        Me.Vw_TRANSH_CTableAdapter.ClearBeforeFill = True
        '
        'frmProject
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 23.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(838, 510)
        Me.Controls.Add(Me.LayoutControl1)
        Me.IconOptions.Image = Global.DreamyKitchenCRM.My.Resources.Resources.favicon
        Me.Name = "frmProject"
        Me.Text = "Έργο"
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.MemoEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboCUS.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtCharge.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtCharge.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodeH.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboSaler.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboTransC.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboCOU.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboAREAS.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboADR.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LCus, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VwTRANSHCBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DM_TRANS, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents LayoutControlItem2 As LayoutControlItem
    Friend WithEvents LayoutControlItem4 As LayoutControlItem
    Friend WithEvents LayoutControlItem5 As LayoutControlItem
    Friend WithEvents LayoutControlItem3 As LayoutControlItem
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
    Friend WithEvents LayoutControlItem1 As LayoutControlItem
    Friend WithEvents cboCOU As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents cboAREAS As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents cboADR As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LayoutControlGroup1 As LayoutControlGroup
    Friend WithEvents LayoutControlItem9 As LayoutControlItem
    Friend WithEvents LayoutControlItem10 As LayoutControlItem
    Friend WithEvents LayoutControlItem11 As LayoutControlItem
End Class
