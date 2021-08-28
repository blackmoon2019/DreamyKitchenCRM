<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmInstallations
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInstallations))
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.chkPaid = New DevExpress.XtraEditors.CheckEdit()
        Me.chkCompleted = New DevExpress.XtraEditors.CheckEdit()
        Me.cmdExit = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdSave = New DevExpress.XtraEditors.SimpleButton()
        Me.cboSER = New DevExpress.XtraEditors.LookUpEdit()
        Me.cboCUS = New DevExpress.XtraEditors.LookUpEdit()
        Me.dtDeliverDate = New DevExpress.XtraEditors.DateEdit()
        Me.txtComments = New DevExpress.XtraEditors.MemoEdit()
        Me.txtCode = New DevExpress.XtraEditors.TextEdit()
        Me.txtCost = New DevExpress.XtraEditors.TextEdit()
        Me.txtExtraCost = New DevExpress.XtraEditors.TextEdit()
        Me.cboSaler = New DevExpress.XtraEditors.LookUpEdit()
        Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.Lcost = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LExtracost = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem14 = New DevExpress.XtraLayout.LayoutControlItem()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.chkPaid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkCompleted.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboSER.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboCUS.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtDeliverDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtDeliverDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtComments.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCost.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtExtraCost.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboSaler.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Lcost, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LExtracost, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.chkPaid)
        Me.LayoutControl1.Controls.Add(Me.chkCompleted)
        Me.LayoutControl1.Controls.Add(Me.cmdExit)
        Me.LayoutControl1.Controls.Add(Me.cmdSave)
        Me.LayoutControl1.Controls.Add(Me.cboSER)
        Me.LayoutControl1.Controls.Add(Me.cboCUS)
        Me.LayoutControl1.Controls.Add(Me.dtDeliverDate)
        Me.LayoutControl1.Controls.Add(Me.txtComments)
        Me.LayoutControl1.Controls.Add(Me.txtCode)
        Me.LayoutControl1.Controls.Add(Me.txtCost)
        Me.LayoutControl1.Controls.Add(Me.txtExtraCost)
        Me.LayoutControl1.Controls.Add(Me.cboSaler)
        Me.LayoutControl1.Location = New System.Drawing.Point(-6, -10)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(503, 94, 650, 400)
        Me.LayoutControl1.Root = Me.Root
        Me.LayoutControl1.Size = New System.Drawing.Size(461, 365)
        Me.LayoutControl1.TabIndex = 2
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'chkPaid
        '
        Me.chkPaid.EditValue = CType(0, Byte)
        Me.chkPaid.Location = New System.Drawing.Point(206, 156)
        Me.chkPaid.Name = "chkPaid"
        Me.chkPaid.Properties.Caption = "Εξοφλημένο"
        Me.chkPaid.Properties.ValueChecked = CType(1, Byte)
        Me.chkPaid.Properties.ValueUnchecked = CType(0, Byte)
        Me.chkPaid.Size = New System.Drawing.Size(243, 20)
        Me.chkPaid.StyleController = Me.LayoutControl1
        Me.chkPaid.TabIndex = 43
        Me.chkPaid.Tag = "paid,0,1,2"
        '
        'chkCompleted
        '
        Me.chkCompleted.EditValue = CType(0, Byte)
        Me.chkCompleted.Location = New System.Drawing.Point(12, 156)
        Me.chkCompleted.Name = "chkCompleted"
        Me.chkCompleted.Properties.Caption = "Ολοκληρώθηκε"
        Me.chkCompleted.Properties.ValueChecked = CType(1, Byte)
        Me.chkCompleted.Properties.ValueUnchecked = CType(0, Byte)
        Me.chkCompleted.Size = New System.Drawing.Size(190, 20)
        Me.chkCompleted.StyleController = Me.LayoutControl1
        Me.chkCompleted.TabIndex = 35
        Me.chkCompleted.Tag = "completed,0,1,2"
        '
        'cmdExit
        '
        Me.cmdExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdExit.ImageOptions.Image = Global.DreamyKitchenCRM.My.Resources.Resources.icons8_exit_24
        Me.cmdExit.Location = New System.Drawing.Point(310, 325)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(139, 28)
        Me.cmdExit.StyleController = Me.LayoutControl1
        Me.cmdExit.TabIndex = 33
        Me.cmdExit.Text = "Έξοδος"
        '
        'cmdSave
        '
        Me.cmdSave.ImageOptions.Image = Global.DreamyKitchenCRM.My.Resources.Resources.icons8_save_close_24
        Me.cmdSave.Location = New System.Drawing.Point(188, 325)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(118, 28)
        Me.cmdSave.StyleController = Me.LayoutControl1
        Me.cmdSave.TabIndex = 34
        Me.cmdSave.Text = "Αποθήκευση"
        '
        'cboSER
        '
        Me.cboSER.Location = New System.Drawing.Point(143, 60)
        Me.cboSER.Name = "cboSER"
        Me.cboSER.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.cboSER.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Search), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Clear)})
        Me.cboSER.Properties.NullText = ""
        Me.cboSER.Properties.PopupSizeable = False
        Me.cboSER.Size = New System.Drawing.Size(306, 20)
        Me.cboSER.StyleController = Me.LayoutControl1
        Me.cboSER.TabIndex = 5
        Me.cboSER.Tag = "serid,0,1,2"
        '
        'cboCUS
        '
        Me.cboCUS.Location = New System.Drawing.Point(143, 84)
        Me.cboCUS.Name = "cboCUS"
        Me.cboCUS.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.cboCUS.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Search), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Clear)})
        Me.cboCUS.Properties.NullText = ""
        Me.cboCUS.Properties.PopupSizeable = False
        Me.cboCUS.Size = New System.Drawing.Size(306, 20)
        Me.cboCUS.StyleController = Me.LayoutControl1
        Me.cboCUS.TabIndex = 6
        Me.cboCUS.Tag = "cusID,0,1,2"
        '
        'dtDeliverDate
        '
        Me.dtDeliverDate.EditValue = Nothing
        Me.dtDeliverDate.Location = New System.Drawing.Point(143, 108)
        Me.dtDeliverDate.Name = "dtDeliverDate"
        Me.dtDeliverDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtDeliverDate.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtDeliverDate.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.dtDeliverDate.Size = New System.Drawing.Size(306, 20)
        Me.dtDeliverDate.StyleController = Me.LayoutControl1
        Me.dtDeliverDate.TabIndex = 32
        Me.dtDeliverDate.Tag = "dtDeliverDate,0,1,2"
        '
        'txtComments
        '
        Me.txtComments.Location = New System.Drawing.Point(143, 180)
        Me.txtComments.Name = "txtComments"
        Me.txtComments.Size = New System.Drawing.Size(306, 141)
        Me.txtComments.StyleController = Me.LayoutControl1
        Me.txtComments.TabIndex = 17
        Me.txtComments.Tag = "cmt,0,1,2"
        '
        'txtCode
        '
        Me.txtCode.Location = New System.Drawing.Point(143, 12)
        Me.txtCode.Name = "txtCode"
        Me.txtCode.Properties.Appearance.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.txtCode.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtCode.Properties.Appearance.Options.UseBackColor = True
        Me.txtCode.Properties.Appearance.Options.UseFont = True
        Me.txtCode.Properties.ReadOnly = True
        Me.txtCode.Size = New System.Drawing.Size(59, 20)
        Me.txtCode.StyleController = Me.LayoutControl1
        Me.txtCode.TabIndex = 4
        Me.txtCode.Tag = "code,0"
        '
        'txtCost
        '
        Me.txtCost.EditValue = "0,00 €"
        Me.txtCost.Location = New System.Drawing.Point(143, 132)
        Me.txtCost.Name = "txtCost"
        Me.txtCost.Properties.DisplayFormat.FormatString = "c"
        Me.txtCost.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtCost.Properties.EditFormat.FormatString = "n2"
        Me.txtCost.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtCost.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtCost.Properties.MaskSettings.Set("MaskManagerType", GetType(DevExpress.Data.Mask.NumericMaskManager))
        Me.txtCost.Properties.MaskSettings.Set("mask", "c2")
        Me.txtCost.Properties.Tag = "BenchExtraPrice"
        Me.txtCost.Size = New System.Drawing.Size(54, 20)
        Me.txtCost.StyleController = Me.LayoutControl1
        Me.txtCost.TabIndex = 42
        Me.txtCost.Tag = "cost,0,1,2"
        Me.txtCost.Visible = False
        '
        'txtExtraCost
        '
        Me.txtExtraCost.EditValue = "0,00 €"
        Me.txtExtraCost.Location = New System.Drawing.Point(332, 132)
        Me.txtExtraCost.Name = "txtExtraCost"
        Me.txtExtraCost.Properties.DisplayFormat.FormatString = "c"
        Me.txtExtraCost.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtExtraCost.Properties.EditFormat.FormatString = "n2"
        Me.txtExtraCost.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtExtraCost.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtExtraCost.Properties.MaskSettings.Set("MaskManagerType", GetType(DevExpress.Data.Mask.NumericMaskManager))
        Me.txtExtraCost.Properties.MaskSettings.Set("mask", "c2")
        Me.txtExtraCost.Properties.Tag = "BenchExtraPrice"
        Me.txtExtraCost.Size = New System.Drawing.Size(117, 20)
        Me.txtExtraCost.StyleController = Me.LayoutControl1
        Me.txtExtraCost.TabIndex = 42
        Me.txtExtraCost.Tag = "extraCost,0,1,2"
        Me.txtExtraCost.Visible = False
        '
        'cboSaler
        '
        Me.cboSaler.Location = New System.Drawing.Point(143, 36)
        Me.cboSaler.Name = "cboSaler"
        Me.cboSaler.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.cboSaler.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Search), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Clear)})
        Me.cboSaler.Properties.NullText = ""
        Me.cboSaler.Properties.PopupSizeable = False
        Me.cboSaler.Size = New System.Drawing.Size(306, 20)
        Me.cboSaler.StyleController = Me.LayoutControl1
        Me.cboSaler.TabIndex = 6
        Me.cboSaler.Tag = "SalerId,0,1,2"
        '
        'Root
        '
        Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.Root.GroupBordersVisible = False
        Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem9, Me.LayoutControlItem5, Me.LayoutControlItem2, Me.LayoutControlItem4, Me.LayoutControlItem3, Me.LayoutControlItem1, Me.EmptySpaceItem1, Me.LayoutControlItem6, Me.Lcost, Me.LExtracost, Me.EmptySpaceItem2, Me.LayoutControlItem7, Me.LayoutControlItem8, Me.LayoutControlItem14})
        Me.Root.Name = "Root"
        Me.Root.Size = New System.Drawing.Size(461, 365)
        Me.Root.TextVisible = False
        '
        'LayoutControlItem9
        '
        Me.LayoutControlItem9.Control = Me.cboSER
        Me.LayoutControlItem9.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem9.CustomizationFormText = "Νομός"
        Me.LayoutControlItem9.HighlightFocusedItem = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlItem9.ImageOptions.Image = CType(resources.GetObject("LayoutControlItem9.ImageOptions.Image"), System.Drawing.Image)
        Me.LayoutControlItem9.Location = New System.Drawing.Point(0, 48)
        Me.LayoutControlItem9.Name = "LayoutControlItem9"
        Me.LayoutControlItem9.Size = New System.Drawing.Size(441, 24)
        Me.LayoutControlItem9.Tag = "1"
        Me.LayoutControlItem9.Text = "Συνεργείο"
        Me.LayoutControlItem9.TextSize = New System.Drawing.Size(119, 13)
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.cboCUS
        Me.LayoutControlItem5.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem5.CustomizationFormText = "Περιοχή"
        Me.LayoutControlItem5.HighlightFocusedItem = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 72)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(441, 24)
        Me.LayoutControlItem5.Text = "Πελάτης"
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(119, 13)
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.dtDeliverDate
        Me.LayoutControlItem2.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem2.CustomizationFormText = "Ημερ/νία Ολοκλήρωσης"
        Me.LayoutControlItem2.ImageOptions.Image = CType(resources.GetObject("LayoutControlItem2.ImageOptions.Image"), System.Drawing.Image)
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 96)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(441, 24)
        Me.LayoutControlItem2.Tag = "1"
        Me.LayoutControlItem2.Text = "Ημερ/νία Τοποθέτησης"
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(119, 13)
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.txtCode
        Me.LayoutControlItem4.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem4.CustomizationFormText = "Κωδικός"
        Me.LayoutControlItem4.HighlightFocusedItem = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(194, 24)
        Me.LayoutControlItem4.Text = "Κωδικός"
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(119, 13)
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.cmdSave
        Me.LayoutControlItem3.Location = New System.Drawing.Point(176, 313)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(122, 32)
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem3.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.cmdExit
        Me.LayoutControlItem1.Location = New System.Drawing.Point(298, 313)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(143, 32)
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(194, 0)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(247, 24)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.chkCompleted
        Me.LayoutControlItem6.Location = New System.Drawing.Point(0, 144)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(194, 24)
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem6.TextVisible = False
        '
        'Lcost
        '
        Me.Lcost.Control = Me.txtCost
        Me.Lcost.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.Lcost.CustomizationFormText = "Τελική Αξία"
        Me.Lcost.HighlightFocusedItem = DevExpress.Utils.DefaultBoolean.[True]
        Me.Lcost.Location = New System.Drawing.Point(0, 120)
        Me.Lcost.Name = "Lcost"
        Me.Lcost.Size = New System.Drawing.Size(189, 24)
        Me.Lcost.Text = "Κόστος"
        Me.Lcost.TextSize = New System.Drawing.Size(119, 13)
        '
        'LExtracost
        '
        Me.LExtracost.Control = Me.txtExtraCost
        Me.LExtracost.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LExtracost.CustomizationFormText = "Τελική Αξία"
        Me.LExtracost.HighlightFocusedItem = DevExpress.Utils.DefaultBoolean.[True]
        Me.LExtracost.Location = New System.Drawing.Point(189, 120)
        Me.LExtracost.Name = "LExtracost"
        Me.LExtracost.Size = New System.Drawing.Size(252, 24)
        Me.LExtracost.Text = "Extra Κόστος"
        Me.LExtracost.TextSize = New System.Drawing.Size(119, 13)
        '
        'EmptySpaceItem2
        '
        Me.EmptySpaceItem2.AllowHotTrack = False
        Me.EmptySpaceItem2.Location = New System.Drawing.Point(0, 313)
        Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Size = New System.Drawing.Size(176, 32)
        Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.Control = Me.cboSaler
        Me.LayoutControlItem7.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem7.CustomizationFormText = "Περιοχή"
        Me.LayoutControlItem7.HighlightFocusedItem = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlItem7.ImageOptions.Image = Global.DreamyKitchenCRM.My.Resources.Resources.rsz_11rsz_asterisk
        Me.LayoutControlItem7.Location = New System.Drawing.Point(0, 24)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(441, 24)
        Me.LayoutControlItem7.Tag = "1"
        Me.LayoutControlItem7.Text = "Πωλητής"
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(119, 13)
        '
        'LayoutControlItem8
        '
        Me.LayoutControlItem8.Control = Me.chkPaid
        Me.LayoutControlItem8.Location = New System.Drawing.Point(194, 144)
        Me.LayoutControlItem8.Name = "LayoutControlItem8"
        Me.LayoutControlItem8.Size = New System.Drawing.Size(247, 24)
        Me.LayoutControlItem8.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem8.TextVisible = False
        '
        'LayoutControlItem14
        '
        Me.LayoutControlItem14.Control = Me.txtComments
        Me.LayoutControlItem14.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem14.CustomizationFormText = "Σχόλια"
        Me.LayoutControlItem14.HighlightFocusedItem = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlItem14.Location = New System.Drawing.Point(0, 168)
        Me.LayoutControlItem14.Name = "LayoutControlItem14"
        Me.LayoutControlItem14.Size = New System.Drawing.Size(441, 145)
        Me.LayoutControlItem14.Text = "Σχόλια"
        Me.LayoutControlItem14.TextSize = New System.Drawing.Size(119, 13)
        '
        'frmInstallations
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(454, 349)
        Me.Controls.Add(Me.LayoutControl1)
        Me.IconOptions.Image = Global.DreamyKitchenCRM.My.Resources.Resources.favicon
        Me.Name = "frmInstallations"
        Me.Text = "Τοποθετήσεις"
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.chkPaid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkCompleted.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboSER.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboCUS.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtDeliverDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtDeliverDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtComments.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCost.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtExtraCost.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboSaler.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Lcost, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LExtracost, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents Root As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents cmdExit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents cboSER As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents cboCUS As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents dtDeliverDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents txtComments As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents txtCode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem14 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents chkCompleted As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents txtCost As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtExtraCost As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Lcost As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LExtracost As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents cboSaler As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents chkPaid As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
End Class
