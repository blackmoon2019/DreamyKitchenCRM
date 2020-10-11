<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCusMov
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCusMov))
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.dtCompleted = New DevExpress.XtraEditors.DateEdit()
        Me.chkCompleted = New DevExpress.XtraEditors.CheckEdit()
        Me.txtCode = New DevExpress.XtraEditors.TextEdit()
        Me.cboCUS = New DevExpress.XtraEditors.LookUpEdit()
        Me.cboSTATUS = New DevExpress.XtraEditors.LookUpEdit()
        Me.txtNam1 = New DevExpress.XtraEditors.TextEdit()
        Me.txtComments = New DevExpress.XtraEditors.MemoEdit()
        Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem20 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem4 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem14 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.cmdCboManageCOU = New DevExpress.XtraEditors.SimpleButton()
        Me.dtCompleted1 = New DevExpress.XtraEditors.DateEdit()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.cboRemValues = New DevExpress.XtraEditors.LookUpEdit()
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.cmdExit = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdSave = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdCboManageSTATUS = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdCboManageCUS = New DevExpress.XtraEditors.SimpleButton()
        Me.LayoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem16 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.dtCompleted.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtCompleted.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkCompleted.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboCUS.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboSTATUS.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNam1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtComments.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem20, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtCompleted1.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtCompleted1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboRemValues.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.cboRemValues)
        Me.LayoutControl1.Controls.Add(Me.dtCompleted)
        Me.LayoutControl1.Controls.Add(Me.chkCompleted)
        Me.LayoutControl1.Controls.Add(Me.cmdCboManageSTATUS)
        Me.LayoutControl1.Controls.Add(Me.cmdCboManageCUS)
        Me.LayoutControl1.Controls.Add(Me.txtCode)
        Me.LayoutControl1.Controls.Add(Me.cboCUS)
        Me.LayoutControl1.Controls.Add(Me.cboSTATUS)
        Me.LayoutControl1.Controls.Add(Me.txtNam1)
        Me.LayoutControl1.Controls.Add(Me.txtComments)
        Me.LayoutControl1.Controls.Add(Me.dtCompleted1)
        Me.LayoutControl1.Location = New System.Drawing.Point(9, 2)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.Root = Me.Root
        Me.LayoutControl1.Size = New System.Drawing.Size(662, 345)
        Me.LayoutControl1.TabIndex = 0
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'dtCompleted
        '
        Me.dtCompleted.EditValue = Nothing
        Me.dtCompleted.Location = New System.Drawing.Point(231, 62)
        Me.dtCompleted.Name = "dtCompleted"
        Me.dtCompleted.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtCompleted.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtCompleted.Size = New System.Drawing.Size(146, 20)
        Me.dtCompleted.StyleController = Me.LayoutControl1
        Me.dtCompleted.TabIndex = 32
        Me.dtCompleted.Tag = "dtCompleted,0,1,2"
        '
        'chkCompleted
        '
        Me.chkCompleted.EditValue = CType(0, Byte)
        Me.chkCompleted.Location = New System.Drawing.Point(12, 62)
        Me.chkCompleted.Name = "chkCompleted"
        Me.chkCompleted.Properties.Caption = "Ολοκληρώθηκε"
        Me.chkCompleted.Properties.ValueChecked = CType(1, Byte)
        Me.chkCompleted.Properties.ValueUnchecked = CType(0, Byte)
        Me.chkCompleted.Size = New System.Drawing.Size(98, 20)
        Me.chkCompleted.StyleController = Me.LayoutControl1
        Me.chkCompleted.TabIndex = 31
        Me.chkCompleted.Tag = "completed,0,1,2"
        '
        'txtCode
        '
        Me.txtCode.Location = New System.Drawing.Point(54, 12)
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
        'cboCUS
        '
        Me.cboCUS.Location = New System.Drawing.Point(162, 12)
        Me.cboCUS.Name = "cboCUS"
        Me.cboCUS.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.cboCUS.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboCUS.Properties.NullText = ""
        Me.cboCUS.Properties.PopupSizeable = False
        Me.cboCUS.Size = New System.Drawing.Size(189, 20)
        Me.cboCUS.StyleController = Me.LayoutControl1
        Me.cboCUS.TabIndex = 5
        Me.cboCUS.Tag = "cusID,0,1,2"
        '
        'cboSTATUS
        '
        Me.cboSTATUS.Location = New System.Drawing.Point(426, 12)
        Me.cboSTATUS.Name = "cboSTATUS"
        Me.cboSTATUS.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.cboSTATUS.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboSTATUS.Properties.NullText = ""
        Me.cboSTATUS.Properties.PopupSizeable = False
        Me.cboSTATUS.Size = New System.Drawing.Size(198, 20)
        Me.cboSTATUS.StyleController = Me.LayoutControl1
        Me.cboSTATUS.TabIndex = 5
        Me.cboSTATUS.Tag = "statusid,0,1,2"
        '
        'txtNam1
        '
        Me.txtNam1.Location = New System.Drawing.Point(382, 38)
        Me.txtNam1.Name = "txtNam1"
        Me.txtNam1.Properties.Mask.EditMask = "n0"
        Me.txtNam1.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtNam1.Size = New System.Drawing.Size(93, 20)
        Me.txtNam1.StyleController = Me.LayoutControl1
        Me.txtNam1.TabIndex = 9
        Me.txtNam1.Tag = "sch,0,1,2"
        '
        'txtComments
        '
        Me.txtComments.Location = New System.Drawing.Point(45, 86)
        Me.txtComments.Name = "txtComments"
        Me.txtComments.Size = New System.Drawing.Size(605, 247)
        Me.txtComments.StyleController = Me.LayoutControl1
        Me.txtComments.TabIndex = 17
        Me.txtComments.Tag = "cmt,0,1,2"
        '
        'Root
        '
        Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.Root.GroupBordersVisible = False
        Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem4, Me.LayoutControlItem9, Me.LayoutControlItem1, Me.LayoutControlItem5, Me.LayoutControlItem3, Me.EmptySpaceItem4, Me.LayoutControlItem14, Me.LayoutControlItem6, Me.LayoutControlItem20, Me.LayoutControlItem16, Me.LayoutControlItem2, Me.LayoutControlItem7})
        Me.Root.Name = "Root"
        Me.Root.Size = New System.Drawing.Size(662, 345)
        Me.Root.TextVisible = False
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.txtCode
        Me.LayoutControlItem4.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem4.CustomizationFormText = "Κωδικός"
        Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(96, 26)
        Me.LayoutControlItem4.Text = "Κωδικός"
        Me.LayoutControlItem4.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(39, 13)
        Me.LayoutControlItem4.TextToControlDistance = 3
        '
        'LayoutControlItem20
        '
        Me.LayoutControlItem20.Control = Me.txtNam1
        Me.LayoutControlItem20.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem20.CustomizationFormText = "Ειδοποίηση πριν"
        Me.LayoutControlItem20.Location = New System.Drawing.Point(292, 26)
        Me.LayoutControlItem20.Name = "LayoutControlItem20"
        Me.LayoutControlItem20.Size = New System.Drawing.Size(175, 24)
        Me.LayoutControlItem20.Text = "Ειδοποίηση πριν"
        Me.LayoutControlItem20.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
        Me.LayoutControlItem20.TextSize = New System.Drawing.Size(75, 13)
        Me.LayoutControlItem20.TextToControlDistance = 3
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.dtCompleted
        Me.LayoutControlItem5.Location = New System.Drawing.Point(102, 50)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(267, 24)
        Me.LayoutControlItem5.Text = "Ημερ/νία Ολοκλήρωσης"
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(114, 13)
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.chkCompleted
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 50)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(102, 24)
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem3.TextVisible = False
        '
        'EmptySpaceItem4
        '
        Me.EmptySpaceItem4.AllowHotTrack = False
        Me.EmptySpaceItem4.Location = New System.Drawing.Point(369, 50)
        Me.EmptySpaceItem4.Name = "EmptySpaceItem4"
        Me.EmptySpaceItem4.Size = New System.Drawing.Size(273, 24)
        Me.EmptySpaceItem4.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem14
        '
        Me.LayoutControlItem14.Control = Me.txtComments
        Me.LayoutControlItem14.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem14.CustomizationFormText = "Σχόλια"
        Me.LayoutControlItem14.Location = New System.Drawing.Point(0, 74)
        Me.LayoutControlItem14.Name = "LayoutControlItem14"
        Me.LayoutControlItem14.Size = New System.Drawing.Size(642, 251)
        Me.LayoutControlItem14.Text = "Σχόλια"
        Me.LayoutControlItem14.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
        Me.LayoutControlItem14.TextSize = New System.Drawing.Size(32, 13)
        Me.LayoutControlItem14.TextToControlDistance = 1
        '
        'cmdCboManageCOU
        '
        Me.cmdCboManageCOU.Location = New System.Drawing.Point(234, 110)
        Me.cmdCboManageCOU.Name = "cmdCboManageCOU"
        Me.cmdCboManageCOU.Size = New System.Drawing.Size(22, 22)
        Me.cmdCboManageCOU.TabIndex = 28
        '
        'dtCompleted1
        '
        Me.dtCompleted1.EditValue = Nothing
        Me.dtCompleted1.Location = New System.Drawing.Point(129, 38)
        Me.dtCompleted1.Name = "dtCompleted1"
        Me.dtCompleted1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtCompleted1.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtCompleted1.Size = New System.Drawing.Size(171, 20)
        Me.dtCompleted1.StyleController = Me.LayoutControl1
        Me.dtCompleted1.TabIndex = 32
        Me.dtCompleted1.Tag = "dtReminderDate,0,1,2"
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.dtCompleted1
        Me.LayoutControlItem6.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem6.CustomizationFormText = "Ημερ/νία Ειδοποίησης"
        Me.LayoutControlItem6.Location = New System.Drawing.Point(0, 26)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(292, 24)
        Me.LayoutControlItem6.Text = "Ημερ/νία Ειδοποίησης"
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(114, 13)
        '
        'cboRemValues
        '
        Me.cboRemValues.Location = New System.Drawing.Point(479, 38)
        Me.cboRemValues.Name = "cboRemValues"
        Me.cboRemValues.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboRemValues.Properties.NullText = ""
        Me.cboRemValues.Size = New System.Drawing.Size(171, 20)
        Me.cboRemValues.StyleController = Me.LayoutControl1
        Me.cboRemValues.TabIndex = 33
        Me.cboRemValues.Tag = "remValueID,0,1,2"
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.Control = Me.cboRemValues
        Me.LayoutControlItem7.Location = New System.Drawing.Point(467, 26)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(175, 24)
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem7.TextVisible = False
        '
        'cmdExit
        '
        Me.cmdExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdExit.ImageOptions.Image = Global.DreamyKitchenCRM.My.Resources.Resources.icons8_exit_24
        Me.cmdExit.Location = New System.Drawing.Point(555, 346)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(110, 28)
        Me.cmdExit.TabIndex = 14
        Me.cmdExit.Text = "Έξοδος"
        '
        'cmdSave
        '
        Me.cmdSave.ImageOptions.Image = Global.DreamyKitchenCRM.My.Resources.Resources.icons8_save_close_24
        Me.cmdSave.Location = New System.Drawing.Point(438, 346)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(111, 28)
        Me.cmdSave.TabIndex = 15
        Me.cmdSave.Text = "Αποθήκευση"
        '
        'cmdCboManageSTATUS
        '
        Me.cmdCboManageSTATUS.ImageOptions.Image = Global.DreamyKitchenCRM.My.Resources.Resources.icons8_form_16
        Me.cmdCboManageSTATUS.Location = New System.Drawing.Point(628, 12)
        Me.cmdCboManageSTATUS.Name = "cmdCboManageSTATUS"
        Me.cmdCboManageSTATUS.Size = New System.Drawing.Size(22, 22)
        Me.cmdCboManageSTATUS.StyleController = Me.LayoutControl1
        Me.cmdCboManageSTATUS.TabIndex = 30
        '
        'cmdCboManageCUS
        '
        Me.cmdCboManageCUS.ImageOptions.Image = Global.DreamyKitchenCRM.My.Resources.Resources.icons8_form_16
        Me.cmdCboManageCUS.Location = New System.Drawing.Point(355, 12)
        Me.cmdCboManageCUS.Name = "cmdCboManageCUS"
        Me.cmdCboManageCUS.Size = New System.Drawing.Size(22, 22)
        Me.cmdCboManageCUS.StyleController = Me.LayoutControl1
        Me.cmdCboManageCUS.TabIndex = 29
        '
        'LayoutControlItem9
        '
        Me.LayoutControlItem9.Control = Me.cboCUS
        Me.LayoutControlItem9.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem9.CustomizationFormText = "Νομός"
        Me.LayoutControlItem9.ImageOptions.Image = CType(resources.GetObject("LayoutControlItem9.ImageOptions.Image"), System.Drawing.Image)
        Me.LayoutControlItem9.Location = New System.Drawing.Point(96, 0)
        Me.LayoutControlItem9.Name = "LayoutControlItem9"
        Me.LayoutControlItem9.Size = New System.Drawing.Size(247, 26)
        Me.LayoutControlItem9.Tag = "1"
        Me.LayoutControlItem9.Text = "Πελάτης"
        Me.LayoutControlItem9.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
        Me.LayoutControlItem9.TextSize = New System.Drawing.Size(51, 13)
        Me.LayoutControlItem9.TextToControlDistance = 3
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.cmdCboManageCUS
        Me.LayoutControlItem1.Location = New System.Drawing.Point(343, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(26, 26)
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'LayoutControlItem16
        '
        Me.LayoutControlItem16.Control = Me.cboSTATUS
        Me.LayoutControlItem16.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem16.CustomizationFormText = "Status"
        Me.LayoutControlItem16.ImageOptions.Image = CType(resources.GetObject("LayoutControlItem16.ImageOptions.Image"), System.Drawing.Image)
        Me.LayoutControlItem16.Location = New System.Drawing.Point(369, 0)
        Me.LayoutControlItem16.Name = "LayoutControlItem16"
        Me.LayoutControlItem16.Size = New System.Drawing.Size(247, 26)
        Me.LayoutControlItem16.Tag = "1"
        Me.LayoutControlItem16.Text = "Status"
        Me.LayoutControlItem16.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
        Me.LayoutControlItem16.TextSize = New System.Drawing.Size(42, 13)
        Me.LayoutControlItem16.TextToControlDistance = 3
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.cmdCboManageSTATUS
        Me.LayoutControlItem2.Location = New System.Drawing.Point(616, 0)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(26, 26)
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem2.TextVisible = False
        '
        'frmCusMov
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(668, 386)
        Me.Controls.Add(Me.cmdExit)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Name = "frmCusMov"
        Me.Text = "frmCusMov"
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.dtCompleted.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtCompleted.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkCompleted.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboCUS.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboSTATUS.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNam1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtComments.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem20, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtCompleted1.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtCompleted1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboRemValues.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents Root As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents cmdExit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtCode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents cmdCboManageCOU As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cboCUS As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LayoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents cmdCboManageCUS As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents cboSTATUS As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LayoutControlItem16 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents cmdCboManageSTATUS As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents txtNam1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem20 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents chkCompleted As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents dtCompleted As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem4 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents txtComments As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LayoutControlItem14 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents dtCompleted1 As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents cboRemValues As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
End Class
