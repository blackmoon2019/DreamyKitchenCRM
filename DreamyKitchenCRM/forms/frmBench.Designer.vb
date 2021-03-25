<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBench
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBench))
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.cmdSave = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdExit = New DevExpress.XtraEditors.SimpleButton()
        Me.txtCode = New DevExpress.XtraEditors.TextEdit()
        Me.txtPricePerMeter = New DevExpress.XtraEditors.TextEdit()
        Me.txtCustomCode = New DevExpress.XtraEditors.TextEdit()
        Me.txtNam = New DevExpress.XtraEditors.TextEdit()
        Me.txtHeight = New DevExpress.XtraEditors.TextEdit()
        Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem56 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.txtCode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPricePerMeter.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCustomCode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNam.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtHeight.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem56, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.cmdSave)
        Me.LayoutControl1.Controls.Add(Me.cmdExit)
        Me.LayoutControl1.Controls.Add(Me.txtCode)
        Me.LayoutControl1.Controls.Add(Me.txtPricePerMeter)
        Me.LayoutControl1.Controls.Add(Me.txtCustomCode)
        Me.LayoutControl1.Controls.Add(Me.txtNam)
        Me.LayoutControl1.Controls.Add(Me.txtHeight)
        Me.LayoutControl1.Location = New System.Drawing.Point(-1, -6)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.Root = Me.Root
        Me.LayoutControl1.Size = New System.Drawing.Size(409, 127)
        Me.LayoutControl1.TabIndex = 0
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'cmdSave
        '
        Me.cmdSave.ImageOptions.Image = Global.DreamyKitchenCRM.My.Resources.Resources.icons8_save_close_24
        Me.cmdSave.Location = New System.Drawing.Point(206, 84)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(95, 28)
        Me.cmdSave.StyleController = Me.LayoutControl1
        Me.cmdSave.TabIndex = 44
        Me.cmdSave.Text = "Αποθήκευση"
        '
        'cmdExit
        '
        Me.cmdExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdExit.ImageOptions.Image = Global.DreamyKitchenCRM.My.Resources.Resources.icons8_exit_24
        Me.cmdExit.Location = New System.Drawing.Point(305, 84)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(92, 28)
        Me.cmdExit.StyleController = Me.LayoutControl1
        Me.cmdExit.TabIndex = 43
        Me.cmdExit.Text = "Έξοδος"
        '
        'txtCode
        '
        Me.txtCode.Location = New System.Drawing.Point(123, 12)
        Me.txtCode.Name = "txtCode"
        Me.txtCode.Properties.Appearance.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.txtCode.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtCode.Properties.Appearance.Options.UseBackColor = True
        Me.txtCode.Properties.Appearance.Options.UseFont = True
        Me.txtCode.Properties.ReadOnly = True
        Me.txtCode.Size = New System.Drawing.Size(65, 20)
        Me.txtCode.StyleController = Me.LayoutControl1
        Me.txtCode.TabIndex = 4
        Me.txtCode.Tag = "code,0"
        '
        'txtPricePerMeter
        '
        Me.txtPricePerMeter.EditValue = "0,00 €"
        Me.txtPricePerMeter.Location = New System.Drawing.Point(123, 60)
        Me.txtPricePerMeter.Name = "txtPricePerMeter"
        Me.txtPricePerMeter.Properties.DisplayFormat.FormatString = "c"
        Me.txtPricePerMeter.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtPricePerMeter.Properties.EditFormat.FormatString = "n2"
        Me.txtPricePerMeter.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtPricePerMeter.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtPricePerMeter.Properties.MaskSettings.Set("MaskManagerType", GetType(DevExpress.Data.Mask.NumericMaskManager))
        Me.txtPricePerMeter.Properties.MaskSettings.Set("mask", "c2")
        Me.txtPricePerMeter.Size = New System.Drawing.Size(79, 20)
        Me.txtPricePerMeter.StyleController = Me.LayoutControl1
        Me.txtPricePerMeter.TabIndex = 42
        Me.txtPricePerMeter.Tag = "PricePerMeter,0,1,2"
        '
        'txtCustomCode
        '
        Me.txtCustomCode.Location = New System.Drawing.Point(303, 12)
        Me.txtCustomCode.Name = "txtCustomCode"
        Me.txtCustomCode.Properties.Appearance.BackColor = System.Drawing.SystemColors.Info
        Me.txtCustomCode.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtCustomCode.Properties.Appearance.Options.UseBackColor = True
        Me.txtCustomCode.Properties.Appearance.Options.UseFont = True
        Me.txtCustomCode.Size = New System.Drawing.Size(94, 20)
        Me.txtCustomCode.StyleController = Me.LayoutControl1
        Me.txtCustomCode.TabIndex = 4
        Me.txtCustomCode.Tag = "CustomCode,0,1,2"
        '
        'txtNam
        '
        Me.txtNam.Location = New System.Drawing.Point(123, 36)
        Me.txtNam.Name = "txtNam"
        Me.txtNam.Size = New System.Drawing.Size(274, 20)
        Me.txtNam.StyleController = Me.LayoutControl1
        Me.txtNam.TabIndex = 9
        Me.txtNam.Tag = "name,0,1,2"
        '
        'txtHeight
        '
        Me.txtHeight.EditValue = "0,00 €"
        Me.txtHeight.Location = New System.Drawing.Point(317, 60)
        Me.txtHeight.Name = "txtHeight"
        Me.txtHeight.Properties.DisplayFormat.FormatString = "n"
        Me.txtHeight.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtHeight.Properties.EditFormat.FormatString = "n2"
        Me.txtHeight.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtHeight.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtHeight.Properties.MaskSettings.Set("MaskManagerType", GetType(DevExpress.Data.Mask.NumericMaskManager))
        Me.txtHeight.Properties.MaskSettings.Set("mask", "n2")
        Me.txtHeight.Size = New System.Drawing.Size(80, 20)
        Me.txtHeight.StyleController = Me.LayoutControl1
        Me.txtHeight.TabIndex = 42
        Me.txtHeight.Tag = "width,0,1,2"
        '
        'Root
        '
        Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.Root.GroupBordersVisible = False
        Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem4, Me.LayoutControlItem56, Me.LayoutControlItem3, Me.LayoutControlItem5, Me.LayoutControlItem1, Me.LayoutControlItem6, Me.LayoutControlItem2, Me.EmptySpaceItem1})
        Me.Root.Name = "Root"
        Me.Root.Size = New System.Drawing.Size(409, 127)
        Me.Root.TextVisible = False
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.txtCode
        Me.LayoutControlItem4.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem4.CustomizationFormText = "Κωδικός"
        Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(180, 24)
        Me.LayoutControlItem4.Text = "Κωδικός"
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(99, 13)
        '
        'LayoutControlItem56
        '
        Me.LayoutControlItem56.Control = Me.txtPricePerMeter
        Me.LayoutControlItem56.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem56.CustomizationFormText = "Τελική Αξία"
        Me.LayoutControlItem56.HighlightFocusedItem = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlItem56.ImageOptions.Image = CType(resources.GetObject("LayoutControlItem56.ImageOptions.Image"), System.Drawing.Image)
        Me.LayoutControlItem56.Location = New System.Drawing.Point(0, 48)
        Me.LayoutControlItem56.Name = "LayoutControlItem56"
        Me.LayoutControlItem56.Size = New System.Drawing.Size(194, 24)
        Me.LayoutControlItem56.Text = "Τιμή Τετρ. Μ."
        Me.LayoutControlItem56.TextSize = New System.Drawing.Size(99, 13)
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.txtCustomCode
        Me.LayoutControlItem3.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem3.CustomizationFormText = "Κωδικός"
        Me.LayoutControlItem3.Location = New System.Drawing.Point(180, 0)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(209, 24)
        Me.LayoutControlItem3.Text = "Κωδικός Αναζήτησης"
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(99, 13)
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.txtNam
        Me.LayoutControlItem5.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem5.CustomizationFormText = "Επωνυμία"
        Me.LayoutControlItem5.ImageOptions.Image = CType(resources.GetObject("LayoutControlItem5.ImageOptions.Image"), System.Drawing.Image)
        Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 24)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(389, 24)
        Me.LayoutControlItem5.Text = "Περιγραφή"
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(99, 13)
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.txtHeight
        Me.LayoutControlItem1.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem1.CustomizationFormText = "Πλάτος"
        Me.LayoutControlItem1.HighlightFocusedItem = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlItem1.ImageOptions.Image = CType(resources.GetObject("LayoutControlItem1.ImageOptions.Image"), System.Drawing.Image)
        Me.LayoutControlItem1.Location = New System.Drawing.Point(194, 48)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(195, 24)
        Me.LayoutControlItem1.Text = "Πλάτος (cm)"
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(99, 13)
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.cmdExit
        Me.LayoutControlItem6.Location = New System.Drawing.Point(293, 72)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(96, 35)
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem6.TextVisible = False
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.cmdSave
        Me.LayoutControlItem2.Location = New System.Drawing.Point(194, 72)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(99, 35)
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem2.TextVisible = False
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(0, 72)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(194, 35)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'frmBench
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(413, 113)
        Me.Controls.Add(Me.LayoutControl1)
        Me.IconOptions.Image = Global.DreamyKitchenCRM.My.Resources.Resources.favicon
        Me.Name = "frmBench"
        Me.Text = "frmBench"
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.txtCode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPricePerMeter.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCustomCode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNam.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtHeight.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem56, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents Root As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents txtCode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtPricePerMeter As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtCustomCode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtNam As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem56 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents txtHeight As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents cmdSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdExit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
End Class
