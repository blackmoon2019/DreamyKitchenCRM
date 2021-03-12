<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmColors
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmColors))
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.cmdExit = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdSave = New DevExpress.XtraEditors.SimpleButton()
        Me.txtCode = New DevExpress.XtraEditors.TextEdit()
        Me.txtNam = New DevExpress.XtraEditors.TextEdit()
        Me.PictureEdit2 = New DevExpress.XtraEditors.PictureEdit()
        Me.ColorPickEdit11 = New DevExpress.XtraEditors.ColorPickEdit()
        Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.color = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem12 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.cboColorsCat = New DevExpress.XtraEditors.LookUpEdit()
        Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem3 = New DevExpress.XtraLayout.EmptySpaceItem()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.txtCode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNam.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColorPickEdit11.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.color, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboColorsCat.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.cmdExit)
        Me.LayoutControl1.Controls.Add(Me.cmdSave)
        Me.LayoutControl1.Controls.Add(Me.txtCode)
        Me.LayoutControl1.Controls.Add(Me.txtNam)
        Me.LayoutControl1.Controls.Add(Me.PictureEdit2)
        Me.LayoutControl1.Controls.Add(Me.ColorPickEdit11)
        Me.LayoutControl1.Controls.Add(Me.cboColorsCat)
        Me.LayoutControl1.Location = New System.Drawing.Point(6, -3)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.Root = Me.Root
        Me.LayoutControl1.Size = New System.Drawing.Size(568, 349)
        Me.LayoutControl1.TabIndex = 0
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'cmdExit
        '
        Me.cmdExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdExit.ImageOptions.Image = Global.DreamyKitchenCRM.My.Resources.Resources.icons8_exit_24
        Me.cmdExit.Location = New System.Drawing.Point(383, 309)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(173, 28)
        Me.cmdExit.StyleController = Me.LayoutControl1
        Me.cmdExit.TabIndex = 45
        Me.cmdExit.Text = "Έξοδος"
        '
        'cmdSave
        '
        Me.cmdSave.ImageOptions.Image = Global.DreamyKitchenCRM.My.Resources.Resources.icons8_save_close_24
        Me.cmdSave.Location = New System.Drawing.Point(285, 309)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(94, 28)
        Me.cmdSave.StyleController = Me.LayoutControl1
        Me.cmdSave.TabIndex = 46
        Me.cmdSave.Text = "Αποθήκευση"
        '
        'txtCode
        '
        Me.txtCode.Location = New System.Drawing.Point(87, 12)
        Me.txtCode.Name = "txtCode"
        Me.txtCode.Properties.Appearance.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.txtCode.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtCode.Properties.Appearance.Options.UseBackColor = True
        Me.txtCode.Properties.Appearance.Options.UseFont = True
        Me.txtCode.Properties.ReadOnly = True
        Me.txtCode.Size = New System.Drawing.Size(63, 20)
        Me.txtCode.StyleController = Me.LayoutControl1
        Me.txtCode.TabIndex = 4
        Me.txtCode.Tag = "code,0"
        '
        'txtNam
        '
        Me.txtNam.Location = New System.Drawing.Point(87, 36)
        Me.txtNam.Name = "txtNam"
        Me.txtNam.Size = New System.Drawing.Size(233, 20)
        Me.txtNam.StyleController = Me.LayoutControl1
        Me.txtNam.TabIndex = 9
        Me.txtNam.Tag = "name,0,1,2"
        '
        'PictureEdit2
        '
        Me.PictureEdit2.Location = New System.Drawing.Point(87, 84)
        Me.PictureEdit2.Name = "PictureEdit2"
        Me.PictureEdit2.Properties.PictureStoreMode = DevExpress.XtraEditors.Controls.PictureStoreMode.ByteArray
        Me.PictureEdit2.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Always
        Me.PictureEdit2.Properties.ShowScrollBars = True
        Me.PictureEdit2.Properties.ShowZoomSubMenu = DevExpress.Utils.DefaultBoolean.[True]
        Me.PictureEdit2.Size = New System.Drawing.Size(469, 221)
        Me.PictureEdit2.StyleController = Me.LayoutControl1
        Me.PictureEdit2.TabIndex = 44
        Me.PictureEdit2.Tag = "photo,0,1,2"
        '
        'ColorPickEdit11
        '
        Me.ColorPickEdit11.EditValue = System.Drawing.Color.Empty
        Me.ColorPickEdit11.Location = New System.Drawing.Point(87, 60)
        Me.ColorPickEdit11.Name = "ColorPickEdit11"
        Me.ColorPickEdit11.Properties.AutomaticColor = System.Drawing.Color.Black
        Me.ColorPickEdit11.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ColorPickEdit11.Properties.ColorText = DevExpress.XtraEditors.Controls.ColorText.[Integer]
        Me.ColorPickEdit11.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.ColorPickEdit11.Size = New System.Drawing.Size(195, 20)
        Me.ColorPickEdit11.StyleController = Me.LayoutControl1
        Me.ColorPickEdit11.TabIndex = 20
        Me.ColorPickEdit11.Tag = "color,0,1,2"
        '
        'Root
        '
        Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.Root.GroupBordersVisible = False
        Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem4, Me.LayoutControlItem5, Me.color, Me.LayoutControlItem1, Me.LayoutControlItem2, Me.EmptySpaceItem2, Me.LayoutControlItem12, Me.LayoutControlItem8, Me.EmptySpaceItem3, Me.EmptySpaceItem1})
        Me.Root.Name = "Root"
        Me.Root.Size = New System.Drawing.Size(568, 349)
        Me.Root.TextVisible = False
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.txtCode
        Me.LayoutControlItem4.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem4.CustomizationFormText = "Κωδικός"
        Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(142, 24)
        Me.LayoutControlItem4.Text = "Κωδικός"
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(63, 13)
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.txtNam
        Me.LayoutControlItem5.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem5.CustomizationFormText = "Επωνυμία"
        Me.LayoutControlItem5.ImageOptions.Image = CType(resources.GetObject("LayoutControlItem5.ImageOptions.Image"), System.Drawing.Image)
        Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 24)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(312, 24)
        Me.LayoutControlItem5.Tag = "1"
        Me.LayoutControlItem5.Text = "Περιγραφή"
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(63, 13)
        '
        'color
        '
        Me.color.Control = Me.ColorPickEdit11
        Me.color.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.color.CustomizationFormText = "L6"
        Me.color.Location = New System.Drawing.Point(0, 48)
        Me.color.Name = "color"
        Me.color.Size = New System.Drawing.Size(274, 24)
        Me.color.Text = "Χρώμα"
        Me.color.TextSize = New System.Drawing.Size(63, 13)
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.cmdExit
        Me.LayoutControlItem1.Location = New System.Drawing.Point(371, 297)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(177, 32)
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.cmdSave
        Me.LayoutControlItem2.Location = New System.Drawing.Point(273, 297)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(98, 32)
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem2.TextVisible = False
        '
        'EmptySpaceItem2
        '
        Me.EmptySpaceItem2.AllowHotTrack = False
        Me.EmptySpaceItem2.Location = New System.Drawing.Point(0, 297)
        Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Size = New System.Drawing.Size(273, 32)
        Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem12
        '
        Me.LayoutControlItem12.Control = Me.PictureEdit2
        Me.LayoutControlItem12.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem12.CustomizationFormText = "Φωτογραφία"
        Me.LayoutControlItem12.Location = New System.Drawing.Point(0, 72)
        Me.LayoutControlItem12.Name = "LayoutControlItem12"
        Me.LayoutControlItem12.Size = New System.Drawing.Size(548, 225)
        Me.LayoutControlItem12.Text = "Φωτογραφία"
        Me.LayoutControlItem12.TextLocation = DevExpress.Utils.Locations.Left
        Me.LayoutControlItem12.TextSize = New System.Drawing.Size(63, 13)
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(274, 48)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(274, 24)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'cboColorsCat
        '
        Me.cboColorsCat.Location = New System.Drawing.Point(399, 36)
        Me.cboColorsCat.Name = "cboColorsCat"
        Me.cboColorsCat.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.cboColorsCat.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Search), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Clear)})
        Me.cboColorsCat.Properties.NullText = ""
        Me.cboColorsCat.Properties.PopupSizeable = False
        Me.cboColorsCat.Size = New System.Drawing.Size(157, 20)
        Me.cboColorsCat.StyleController = Me.LayoutControl1
        Me.cboColorsCat.TabIndex = 21
        Me.cboColorsCat.Tag = "colorsCatID,0,1,2"
        '
        'LayoutControlItem8
        '
        Me.LayoutControlItem8.Control = Me.cboColorsCat
        Me.LayoutControlItem8.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem8.CustomizationFormText = "Πορτάκι"
        Me.LayoutControlItem8.ImageOptions.Image = CType(resources.GetObject("LayoutControlItem8.ImageOptions.Image"), System.Drawing.Image)
        Me.LayoutControlItem8.Location = New System.Drawing.Point(312, 24)
        Me.LayoutControlItem8.Name = "LayoutControlItem8"
        Me.LayoutControlItem8.Size = New System.Drawing.Size(236, 24)
        Me.LayoutControlItem8.Text = "Κατηγορία"
        Me.LayoutControlItem8.TextSize = New System.Drawing.Size(63, 13)
        '
        'EmptySpaceItem3
        '
        Me.EmptySpaceItem3.AllowHotTrack = False
        Me.EmptySpaceItem3.Location = New System.Drawing.Point(142, 0)
        Me.EmptySpaceItem3.Name = "EmptySpaceItem3"
        Me.EmptySpaceItem3.Size = New System.Drawing.Size(406, 24)
        Me.EmptySpaceItem3.TextSize = New System.Drawing.Size(0, 0)
        '
        'frmColors
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(569, 341)
        Me.Controls.Add(Me.LayoutControl1)
        Me.IconOptions.Image = Global.DreamyKitchenCRM.My.Resources.Resources.favicon
        Me.Name = "frmColors"
        Me.Text = "frmColors"
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.txtCode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNam.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColorPickEdit11.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.color, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboColorsCat.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents txtCode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtNam As DevExpress.XtraEditors.TextEdit
    Friend WithEvents PictureEdit2 As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents Root As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem12 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ColorPickEdit11 As DevExpress.XtraEditors.ColorPickEdit
    Friend WithEvents color As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents cmdExit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents cboColorsCat As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem3 As DevExpress.XtraLayout.EmptySpaceItem
End Class
