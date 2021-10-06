<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmEmpPayroll
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEmpPayroll))
        Me.txtAmt = New DevExpress.XtraEditors.TextEdit()
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.chkCash = New DevExpress.XtraEditors.CheckEdit()
        Me.cmdExit = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdSave = New DevExpress.XtraEditors.SimpleButton()
        Me.cboEMP = New DevExpress.XtraEditors.LookUpEdit()
        Me.dtPay = New DevExpress.XtraEditors.DateEdit()
        Me.txtComments = New DevExpress.XtraEditors.MemoEdit()
        Me.txtCode = New DevExpress.XtraEditors.TextEdit()
        Me.txtSalary = New DevExpress.XtraEditors.TextEdit()
        Me.cboEMP_M_S = New DevExpress.XtraEditors.LookUpEdit()
        Me.cboBANK = New DevExpress.XtraEditors.LookUpEdit()
        Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem14 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem3 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.Lcost4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem5 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.Lcost = New DevExpress.XtraLayout.LayoutControlItem()
        CType(Me.txtAmt.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.chkCash.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboEMP.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtPay.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtPay.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtComments.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSalary.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboEMP_M_S.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboBANK.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Lcost4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Lcost, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtAmt
        '
        Me.txtAmt.EditValue = "0,00 €"
        Me.txtAmt.Location = New System.Drawing.Point(248, 132)
        Me.txtAmt.Name = "txtAmt"
        Me.txtAmt.Properties.DisplayFormat.FormatString = "c"
        Me.txtAmt.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtAmt.Properties.EditFormat.FormatString = "n2"
        Me.txtAmt.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtAmt.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtAmt.Properties.MaskSettings.Set("MaskManagerType", GetType(DevExpress.Data.Mask.NumericMaskManager))
        Me.txtAmt.Properties.MaskSettings.Set("mask", "c2")
        Me.txtAmt.Properties.Tag = "BenchExtraPrice"
        Me.txtAmt.Size = New System.Drawing.Size(342, 20)
        Me.txtAmt.StyleController = Me.LayoutControl1
        Me.txtAmt.TabIndex = 42
        Me.txtAmt.Tag = "amt,0,1,2"
        Me.txtAmt.Visible = False
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LayoutControl1.Controls.Add(Me.chkCash)
        Me.LayoutControl1.Controls.Add(Me.cmdExit)
        Me.LayoutControl1.Controls.Add(Me.cmdSave)
        Me.LayoutControl1.Controls.Add(Me.cboEMP)
        Me.LayoutControl1.Controls.Add(Me.dtPay)
        Me.LayoutControl1.Controls.Add(Me.txtComments)
        Me.LayoutControl1.Controls.Add(Me.txtCode)
        Me.LayoutControl1.Controls.Add(Me.txtAmt)
        Me.LayoutControl1.Controls.Add(Me.txtSalary)
        Me.LayoutControl1.Controls.Add(Me.cboEMP_M_S)
        Me.LayoutControl1.Controls.Add(Me.cboBANK)
        Me.LayoutControl1.Location = New System.Drawing.Point(-5, -7)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(503, 94, 650, 400)
        Me.LayoutControl1.Root = Me.Root
        Me.LayoutControl1.Size = New System.Drawing.Size(602, 378)
        Me.LayoutControl1.TabIndex = 4
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'chkCash
        '
        Me.chkCash.EditValue = CType(0, Byte)
        Me.chkCash.Location = New System.Drawing.Point(12, 132)
        Me.chkCash.Name = "chkCash"
        Me.chkCash.Properties.Caption = "Μετρητά"
        Me.chkCash.Properties.ValueChecked = CType(1, Byte)
        Me.chkCash.Properties.ValueUnchecked = CType(0, Byte)
        Me.chkCash.Size = New System.Drawing.Size(114, 20)
        Me.chkCash.StyleController = Me.LayoutControl1
        Me.chkCash.TabIndex = 49
        Me.chkCash.Tag = "cash,0,1,2"
        '
        'cmdExit
        '
        Me.cmdExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdExit.ImageOptions.Image = Global.DreamyKitchenCRM.My.Resources.Resources.icons8_exit_24
        Me.cmdExit.Location = New System.Drawing.Point(422, 338)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(168, 28)
        Me.cmdExit.StyleController = Me.LayoutControl1
        Me.cmdExit.TabIndex = 33
        Me.cmdExit.Text = "Έξοδος"
        '
        'cmdSave
        '
        Me.cmdSave.ImageOptions.Image = Global.DreamyKitchenCRM.My.Resources.Resources.icons8_save_close_24
        Me.cmdSave.Location = New System.Drawing.Point(279, 338)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(139, 28)
        Me.cmdSave.StyleController = Me.LayoutControl1
        Me.cmdSave.TabIndex = 34
        Me.cmdSave.Text = "Αποθήκευση"
        '
        'cboEMP
        '
        Me.cboEMP.Location = New System.Drawing.Point(130, 36)
        Me.cboEMP.Name = "cboEMP"
        Me.cboEMP.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.cboEMP.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Search), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Clear)})
        Me.cboEMP.Properties.NullText = ""
        Me.cboEMP.Properties.PopupSizeable = False
        Me.cboEMP.Size = New System.Drawing.Size(249, 20)
        Me.cboEMP.StyleController = Me.LayoutControl1
        Me.cboEMP.TabIndex = 5
        Me.cboEMP.Tag = "empID,0,1,2"
        '
        'dtPay
        '
        Me.dtPay.EditValue = Nothing
        Me.dtPay.Location = New System.Drawing.Point(130, 60)
        Me.dtPay.Name = "dtPay"
        Me.dtPay.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtPay.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtPay.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.dtPay.Size = New System.Drawing.Size(172, 20)
        Me.dtPay.StyleController = Me.LayoutControl1
        Me.dtPay.TabIndex = 32
        Me.dtPay.Tag = "dtPay,0,1,2"
        '
        'txtComments
        '
        Me.txtComments.Location = New System.Drawing.Point(130, 156)
        Me.txtComments.Name = "txtComments"
        Me.txtComments.Size = New System.Drawing.Size(460, 178)
        Me.txtComments.StyleController = Me.LayoutControl1
        Me.txtComments.TabIndex = 17
        Me.txtComments.Tag = "cmt,0,1,2"
        '
        'txtCode
        '
        Me.txtCode.Location = New System.Drawing.Point(130, 12)
        Me.txtCode.Name = "txtCode"
        Me.txtCode.Properties.Appearance.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.txtCode.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtCode.Properties.Appearance.Options.UseBackColor = True
        Me.txtCode.Properties.Appearance.Options.UseFont = True
        Me.txtCode.Properties.ReadOnly = True
        Me.txtCode.Size = New System.Drawing.Size(81, 20)
        Me.txtCode.StyleController = Me.LayoutControl1
        Me.txtCode.TabIndex = 4
        Me.txtCode.Tag = "code,0"
        '
        'txtSalary
        '
        Me.txtSalary.EditValue = "0,00 €"
        Me.txtSalary.Location = New System.Drawing.Point(428, 36)
        Me.txtSalary.Name = "txtSalary"
        Me.txtSalary.Properties.DisplayFormat.FormatString = "c"
        Me.txtSalary.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtSalary.Properties.EditFormat.FormatString = "n2"
        Me.txtSalary.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtSalary.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtSalary.Properties.MaskSettings.Set("MaskManagerType", GetType(DevExpress.Data.Mask.NumericMaskManager))
        Me.txtSalary.Properties.MaskSettings.Set("mask", "c2")
        Me.txtSalary.Size = New System.Drawing.Size(66, 20)
        Me.txtSalary.StyleController = Me.LayoutControl1
        Me.txtSalary.TabIndex = 42
        Me.txtSalary.Tag = ""
        Me.txtSalary.Visible = False
        '
        'cboEMP_M_S
        '
        Me.cboEMP_M_S.Location = New System.Drawing.Point(130, 84)
        Me.cboEMP_M_S.Name = "cboEMP_M_S"
        Me.cboEMP_M_S.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.cboEMP_M_S.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Search), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Clear)})
        Me.cboEMP_M_S.Properties.NullText = ""
        Me.cboEMP_M_S.Properties.PopupSizeable = False
        Me.cboEMP_M_S.Size = New System.Drawing.Size(460, 20)
        Me.cboEMP_M_S.StyleController = Me.LayoutControl1
        Me.cboEMP_M_S.TabIndex = 6
        Me.cboEMP_M_S.Tag = "empmsID,0,1,2"
        '
        'cboBANK
        '
        Me.cboBANK.Location = New System.Drawing.Point(130, 108)
        Me.cboBANK.Name = "cboBANK"
        Me.cboBANK.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.cboBANK.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Search), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Clear)})
        Me.cboBANK.Properties.NullText = ""
        Me.cboBANK.Properties.PopupSizeable = False
        Me.cboBANK.Size = New System.Drawing.Size(460, 20)
        Me.cboBANK.StyleController = Me.LayoutControl1
        Me.cboBANK.TabIndex = 6
        Me.cboBANK.Tag = "bankID,0,1,2"
        '
        'Root
        '
        Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.Root.GroupBordersVisible = False
        Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem9, Me.LayoutControlItem14, Me.LayoutControlItem3, Me.LayoutControlItem1, Me.EmptySpaceItem1, Me.EmptySpaceItem2, Me.LayoutControlItem4, Me.LayoutControlItem2, Me.EmptySpaceItem3, Me.Lcost4, Me.EmptySpaceItem5, Me.LayoutControlItem8, Me.LayoutControlItem6, Me.LayoutControlItem5, Me.Lcost})
        Me.Root.Name = "Root"
        Me.Root.Size = New System.Drawing.Size(602, 378)
        Me.Root.TextVisible = False
        '
        'LayoutControlItem9
        '
        Me.LayoutControlItem9.Control = Me.cboEMP
        Me.LayoutControlItem9.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem9.CustomizationFormText = "Νομός"
        Me.LayoutControlItem9.HighlightFocusedItem = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlItem9.ImageOptions.Image = CType(resources.GetObject("LayoutControlItem9.ImageOptions.Image"), System.Drawing.Image)
        Me.LayoutControlItem9.Location = New System.Drawing.Point(0, 24)
        Me.LayoutControlItem9.Name = "LayoutControlItem9"
        Me.LayoutControlItem9.Size = New System.Drawing.Size(371, 24)
        Me.LayoutControlItem9.Tag = "1"
        Me.LayoutControlItem9.Text = "Υπάλληλος"
        Me.LayoutControlItem9.TextSize = New System.Drawing.Size(106, 13)
        '
        'LayoutControlItem14
        '
        Me.LayoutControlItem14.Control = Me.txtComments
        Me.LayoutControlItem14.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem14.CustomizationFormText = "Σχόλια"
        Me.LayoutControlItem14.HighlightFocusedItem = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlItem14.Location = New System.Drawing.Point(0, 144)
        Me.LayoutControlItem14.Name = "LayoutControlItem14"
        Me.LayoutControlItem14.Size = New System.Drawing.Size(582, 182)
        Me.LayoutControlItem14.Text = "Σχόλια"
        Me.LayoutControlItem14.TextSize = New System.Drawing.Size(106, 13)
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.cmdSave
        Me.LayoutControlItem3.Location = New System.Drawing.Point(267, 326)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(143, 32)
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem3.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.cmdExit
        Me.LayoutControlItem1.Location = New System.Drawing.Point(410, 326)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(172, 32)
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(203, 0)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(379, 24)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'EmptySpaceItem2
        '
        Me.EmptySpaceItem2.AllowHotTrack = False
        Me.EmptySpaceItem2.Location = New System.Drawing.Point(0, 326)
        Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Size = New System.Drawing.Size(267, 32)
        Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.txtCode
        Me.LayoutControlItem4.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem4.CustomizationFormText = "Κωδικός"
        Me.LayoutControlItem4.HighlightFocusedItem = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(203, 24)
        Me.LayoutControlItem4.Text = "Κωδικός"
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(106, 13)
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.dtPay
        Me.LayoutControlItem2.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem2.CustomizationFormText = "Ημερ/νία Ολοκλήρωσης"
        Me.LayoutControlItem2.ImageOptions.Image = CType(resources.GetObject("LayoutControlItem2.ImageOptions.Image"), System.Drawing.Image)
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 48)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(294, 24)
        Me.LayoutControlItem2.Tag = "1"
        Me.LayoutControlItem2.Text = "Ημερ/νία Πληρωμής"
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(106, 13)
        '
        'EmptySpaceItem3
        '
        Me.EmptySpaceItem3.AllowHotTrack = False
        Me.EmptySpaceItem3.Location = New System.Drawing.Point(294, 48)
        Me.EmptySpaceItem3.Name = "EmptySpaceItem3"
        Me.EmptySpaceItem3.Size = New System.Drawing.Size(288, 24)
        Me.EmptySpaceItem3.TextSize = New System.Drawing.Size(0, 0)
        '
        'Lcost4
        '
        Me.Lcost4.AppearanceItemCaptionDisabled.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.WindowText
        Me.Lcost4.AppearanceItemCaptionDisabled.Options.UseForeColor = True
        Me.Lcost4.Control = Me.txtSalary
        Me.Lcost4.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.Lcost4.CustomizationFormText = "Τελική Αξία"
        Me.Lcost4.Enabled = False
        Me.Lcost4.HighlightFocusedItem = DevExpress.Utils.DefaultBoolean.[True]
        Me.Lcost4.Location = New System.Drawing.Point(371, 24)
        Me.Lcost4.Name = "Lcost4"
        Me.Lcost4.Size = New System.Drawing.Size(115, 24)
        Me.Lcost4.Text = "Μισθός"
        Me.Lcost4.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
        Me.Lcost4.TextSize = New System.Drawing.Size(33, 13)
        Me.Lcost4.TextToControlDistance = 12
        '
        'EmptySpaceItem5
        '
        Me.EmptySpaceItem5.AllowHotTrack = False
        Me.EmptySpaceItem5.Location = New System.Drawing.Point(486, 24)
        Me.EmptySpaceItem5.Name = "EmptySpaceItem5"
        Me.EmptySpaceItem5.Size = New System.Drawing.Size(96, 24)
        Me.EmptySpaceItem5.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem8
        '
        Me.LayoutControlItem8.Control = Me.cboBANK
        Me.LayoutControlItem8.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem8.CustomizationFormText = "Τράπεζα"
        Me.LayoutControlItem8.HighlightFocusedItem = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlItem8.Location = New System.Drawing.Point(0, 96)
        Me.LayoutControlItem8.Name = "LayoutControlItem8"
        Me.LayoutControlItem8.Size = New System.Drawing.Size(582, 24)
        Me.LayoutControlItem8.Text = "Τράπεζα"
        Me.LayoutControlItem8.TextSize = New System.Drawing.Size(106, 13)
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.chkCash
        Me.LayoutControlItem6.Location = New System.Drawing.Point(0, 120)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(118, 24)
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem6.TextVisible = False
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.cboEMP_M_S
        Me.LayoutControlItem5.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem5.CustomizationFormText = "Τμήμα"
        Me.LayoutControlItem5.HighlightFocusedItem = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlItem5.ImageOptions.Image = CType(resources.GetObject("LayoutControlItem5.ImageOptions.Image"), System.Drawing.Image)
        Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 72)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(582, 24)
        Me.LayoutControlItem5.Tag = "1"
        Me.LayoutControlItem5.Text = "Status"
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(106, 13)
        '
        'Lcost
        '
        Me.Lcost.Control = Me.txtAmt
        Me.Lcost.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.Lcost.CustomizationFormText = "Τελική Αξία"
        Me.Lcost.HighlightFocusedItem = DevExpress.Utils.DefaultBoolean.[True]
        Me.Lcost.ImageOptions.Image = Global.DreamyKitchenCRM.My.Resources.Resources.rsz_11rsz_asterisk
        Me.Lcost.Location = New System.Drawing.Point(118, 120)
        Me.Lcost.Name = "Lcost"
        Me.Lcost.Size = New System.Drawing.Size(464, 24)
        Me.Lcost.Tag = "1"
        Me.Lcost.Text = "Ποσό καταβολής"
        Me.Lcost.TextSize = New System.Drawing.Size(106, 13)
        '
        'frmEmpPayroll
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(593, 366)
        Me.Controls.Add(Me.LayoutControl1)
        Me.IconOptions.Image = Global.DreamyKitchenCRM.My.Resources.Resources.favicon
        Me.Name = "frmEmpPayroll"
        Me.Text = "Μισθοδοσία"
        CType(Me.txtAmt.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.chkCash.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboEMP.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtPay.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtPay.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtComments.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSalary.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboEMP_M_S.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboBANK.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Lcost4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Lcost, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents cmdExit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cboEMP As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents dtPay As DevExpress.XtraEditors.DateEdit
    Friend WithEvents txtComments As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents txtCode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtAmt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Root As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem14 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents Lcost As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem3 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents txtSalary As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Lcost4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem5 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents cboEMP_M_S As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents cboBANK As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents chkCash As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
End Class
