<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNotes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmNotes))
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.cmdExit = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdSave = New DevExpress.XtraEditors.SimpleButton()
        Me.txtCode = New DevExpress.XtraEditors.TextEdit()
        Me.txtNotes = New DevExpress.XtraEditors.MemoEdit()
        Me.txtNam = New DevExpress.XtraEditors.TextEdit()
        Me.cboNotesL = New DevExpress.XtraEditors.LookUpEdit()
        Me.txtFileNames = New DevExpress.XtraEditors.ButtonEdit()
        Me.cboSaler = New DevExpress.XtraEditors.LookUpEdit()
        Me.chkReaded = New DevExpress.XtraEditors.CheckEdit()
        Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem14 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem25 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem3 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem23 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.cmdCboManagePRF = New DevExpress.XtraEditors.SimpleButton()
        Me.XtraOpenFileDialog1 = New DevExpress.XtraEditors.XtraOpenFileDialog(Me.components)
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNotes.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNam.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboNotesL.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFileNames.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboSaler.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkReaded.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem25, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem23, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.GridControl1)
        Me.LayoutControl1.Controls.Add(Me.cmdExit)
        Me.LayoutControl1.Controls.Add(Me.cmdSave)
        Me.LayoutControl1.Controls.Add(Me.txtCode)
        Me.LayoutControl1.Controls.Add(Me.txtNotes)
        Me.LayoutControl1.Controls.Add(Me.txtNam)
        Me.LayoutControl1.Controls.Add(Me.cboNotesL)
        Me.LayoutControl1.Controls.Add(Me.txtFileNames)
        Me.LayoutControl1.Controls.Add(Me.cboSaler)
        Me.LayoutControl1.Controls.Add(Me.chkReaded)
        Me.LayoutControl1.Location = New System.Drawing.Point(-3, -5)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.Root = Me.Root
        Me.LayoutControl1.Size = New System.Drawing.Size(701, 448)
        Me.LayoutControl1.TabIndex = 0
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'GridControl1
        '
        Me.GridControl1.Location = New System.Drawing.Point(12, 204)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(677, 200)
        Me.GridControl1.TabIndex = 31
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        '
        'cmdExit
        '
        Me.cmdExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdExit.ImageOptions.Image = Global.DreamyKitchenCRM.My.Resources.Resources.icons8_exit_24
        Me.cmdExit.Location = New System.Drawing.Point(573, 408)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(116, 28)
        Me.cmdExit.StyleController = Me.LayoutControl1
        Me.cmdExit.TabIndex = 14
        Me.cmdExit.Text = "Έξοδος"
        '
        'cmdSave
        '
        Me.cmdSave.ImageOptions.Image = Global.DreamyKitchenCRM.My.Resources.Resources.icons8_save_close_24
        Me.cmdSave.Location = New System.Drawing.Point(458, 408)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(111, 28)
        Me.cmdSave.StyleController = Me.LayoutControl1
        Me.cmdSave.TabIndex = 15
        Me.cmdSave.Text = "Αποθήκευση"
        '
        'txtCode
        '
        Me.txtCode.Location = New System.Drawing.Point(118, 12)
        Me.txtCode.Name = "txtCode"
        Me.txtCode.Properties.Appearance.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.txtCode.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtCode.Properties.Appearance.Options.UseBackColor = True
        Me.txtCode.Properties.Appearance.Options.UseFont = True
        Me.txtCode.Properties.ReadOnly = True
        Me.txtCode.Size = New System.Drawing.Size(86, 20)
        Me.txtCode.StyleController = Me.LayoutControl1
        Me.txtCode.TabIndex = 4
        Me.txtCode.Tag = "code,0"
        '
        'txtNotes
        '
        Me.txtNotes.Location = New System.Drawing.Point(118, 108)
        Me.txtNotes.Name = "txtNotes"
        Me.txtNotes.Size = New System.Drawing.Size(571, 68)
        Me.txtNotes.StyleController = Me.LayoutControl1
        Me.txtNotes.TabIndex = 17
        Me.txtNotes.Tag = "note,0,1,2"
        '
        'txtNam
        '
        Me.txtNam.Location = New System.Drawing.Point(118, 36)
        Me.txtNam.Name = "txtNam"
        Me.txtNam.Size = New System.Drawing.Size(571, 20)
        Me.txtNam.StyleController = Me.LayoutControl1
        Me.txtNam.TabIndex = 9
        Me.txtNam.Tag = "title,0,1,2"
        '
        'cboNotesL
        '
        Me.cboNotesL.Location = New System.Drawing.Point(118, 84)
        Me.cboNotesL.Name = "cboNotesL"
        Me.cboNotesL.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.cboNotesL.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Search), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Clear)})
        Me.cboNotesL.Properties.NullText = ""
        Me.cboNotesL.Properties.PopupSizeable = False
        Me.cboNotesL.Size = New System.Drawing.Size(211, 20)
        Me.cboNotesL.StyleController = Me.LayoutControl1
        Me.cboNotesL.TabIndex = 5
        Me.cboNotesL.Tag = "Notes_LID,0,1,2"
        '
        'txtFileNames
        '
        Me.txtFileNames.Location = New System.Drawing.Point(118, 180)
        Me.txtFileNames.Name = "txtFileNames"
        Me.txtFileNames.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Search), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Clear)})
        Me.txtFileNames.Properties.Tag = True
        Me.txtFileNames.Size = New System.Drawing.Size(571, 20)
        Me.txtFileNames.StyleController = Me.LayoutControl1
        Me.txtFileNames.TabIndex = 30
        Me.txtFileNames.Tag = ""
        '
        'cboSaler
        '
        Me.cboSaler.Location = New System.Drawing.Point(118, 60)
        Me.cboSaler.Name = "cboSaler"
        Me.cboSaler.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.cboSaler.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Search), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Clear)})
        Me.cboSaler.Properties.NullText = ""
        Me.cboSaler.Properties.PopupSizeable = False
        Me.cboSaler.Size = New System.Drawing.Size(211, 20)
        Me.cboSaler.StyleController = Me.LayoutControl1
        Me.cboSaler.TabIndex = 5
        Me.cboSaler.Tag = "SalerID,0,1,2"
        '
        'chkReaded
        '
        Me.chkReaded.EditValue = CType(0, Byte)
        Me.chkReaded.Location = New System.Drawing.Point(208, 12)
        Me.chkReaded.Name = "chkReaded"
        Me.chkReaded.Properties.Caption = "Διαβάστηκε"
        Me.chkReaded.Properties.ValueChecked = CType(1, Byte)
        Me.chkReaded.Properties.ValueUnchecked = CType(0, Byte)
        Me.chkReaded.Size = New System.Drawing.Size(78, 20)
        Me.chkReaded.StyleController = Me.LayoutControl1
        Me.chkReaded.TabIndex = 32
        Me.chkReaded.Tag = "readed,0,1,2"
        '
        'Root
        '
        Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.Root.GroupBordersVisible = False
        Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem4, Me.LayoutControlItem3, Me.LayoutControlItem14, Me.LayoutControlItem25, Me.LayoutControlItem1, Me.LayoutControlItem2, Me.EmptySpaceItem2, Me.EmptySpaceItem1, Me.LayoutControlItem5, Me.LayoutControlItem6, Me.EmptySpaceItem3, Me.LayoutControlItem23, Me.LayoutControlItem7})
        Me.Root.Name = "Root"
        Me.Root.Size = New System.Drawing.Size(701, 448)
        Me.Root.TextVisible = False
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.txtCode
        Me.LayoutControlItem4.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem4.CustomizationFormText = "Κωδικός"
        Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(196, 24)
        Me.LayoutControlItem4.Text = "Κωδικός"
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(94, 13)
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.txtNam
        Me.LayoutControlItem3.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem3.CustomizationFormText = "Επωνυμία"
        Me.LayoutControlItem3.ImageOptions.Image = CType(resources.GetObject("LayoutControlItem3.ImageOptions.Image"), System.Drawing.Image)
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 24)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(681, 24)
        Me.LayoutControlItem3.Tag = "1"
        Me.LayoutControlItem3.Text = "Τίτλος"
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(94, 13)
        '
        'LayoutControlItem14
        '
        Me.LayoutControlItem14.Control = Me.txtNotes
        Me.LayoutControlItem14.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem14.CustomizationFormText = "Σημέιωση"
        Me.LayoutControlItem14.ImageOptions.Image = Global.DreamyKitchenCRM.My.Resources.Resources.rsz_11rsz_asterisk
        Me.LayoutControlItem14.Location = New System.Drawing.Point(0, 96)
        Me.LayoutControlItem14.Name = "LayoutControlItem14"
        Me.LayoutControlItem14.Size = New System.Drawing.Size(681, 72)
        Me.LayoutControlItem14.Tag = "1"
        Me.LayoutControlItem14.Text = "Σημείωση"
        Me.LayoutControlItem14.TextSize = New System.Drawing.Size(94, 13)
        '
        'LayoutControlItem25
        '
        Me.LayoutControlItem25.Control = Me.txtFileNames
        Me.LayoutControlItem25.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem25.CustomizationFormText = "Αρχεία"
        Me.LayoutControlItem25.Location = New System.Drawing.Point(0, 168)
        Me.LayoutControlItem25.Name = "LayoutControlItem25"
        Me.LayoutControlItem25.Size = New System.Drawing.Size(681, 24)
        Me.LayoutControlItem25.Text = "Αρχεία"
        Me.LayoutControlItem25.TextSize = New System.Drawing.Size(94, 13)
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.cmdExit
        Me.LayoutControlItem1.Location = New System.Drawing.Point(561, 396)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(120, 32)
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.cmdSave
        Me.LayoutControlItem2.Location = New System.Drawing.Point(446, 396)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(115, 32)
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem2.TextVisible = False
        '
        'EmptySpaceItem2
        '
        Me.EmptySpaceItem2.AllowHotTrack = False
        Me.EmptySpaceItem2.Location = New System.Drawing.Point(278, 0)
        Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Size = New System.Drawing.Size(403, 24)
        Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(0, 396)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(446, 32)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.GridControl1
        Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 192)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(681, 204)
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem5.TextVisible = False
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.cboSaler
        Me.LayoutControlItem6.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem6.CustomizationFormText = "Αφορά τον Πωλητή"
        Me.LayoutControlItem6.Location = New System.Drawing.Point(0, 48)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(321, 24)
        Me.LayoutControlItem6.Text = "Αφορά τον Πωλητή"
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(94, 13)
        '
        'EmptySpaceItem3
        '
        Me.EmptySpaceItem3.AllowHotTrack = False
        Me.EmptySpaceItem3.Location = New System.Drawing.Point(321, 48)
        Me.EmptySpaceItem3.Name = "EmptySpaceItem3"
        Me.EmptySpaceItem3.Size = New System.Drawing.Size(360, 48)
        Me.EmptySpaceItem3.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem23
        '
        Me.LayoutControlItem23.Control = Me.cboNotesL
        Me.LayoutControlItem23.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem23.CustomizationFormText = "Ετικέττα"
        Me.LayoutControlItem23.Location = New System.Drawing.Point(0, 72)
        Me.LayoutControlItem23.Name = "LayoutControlItem23"
        Me.LayoutControlItem23.Size = New System.Drawing.Size(321, 24)
        Me.LayoutControlItem23.Tag = ""
        Me.LayoutControlItem23.Text = "Εττικέτα"
        Me.LayoutControlItem23.TextSize = New System.Drawing.Size(94, 13)
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.Control = Me.chkReaded
        Me.LayoutControlItem7.Location = New System.Drawing.Point(196, 0)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(82, 24)
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem7.TextVisible = False
        '
        'cmdCboManagePRF
        '
        Me.cmdCboManagePRF.Location = New System.Drawing.Point(563, 60)
        Me.cmdCboManagePRF.Name = "cmdCboManagePRF"
        Me.cmdCboManagePRF.Size = New System.Drawing.Size(22, 22)
        Me.cmdCboManagePRF.TabIndex = 29
        '
        'XtraOpenFileDialog1
        '
        Me.XtraOpenFileDialog1.Multiselect = True
        Me.XtraOpenFileDialog1.Title = "Επιλογή αρχείων"
        '
        'frmNotes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(693, 439)
        Me.Controls.Add(Me.LayoutControl1)
        Me.IconOptions.Image = Global.DreamyKitchenCRM.My.Resources.Resources.favicon
        Me.Name = "frmNotes"
        Me.Text = "frmNotes"
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNotes.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNam.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboNotesL.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFileNames.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboSaler.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkReaded.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem25, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem23, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents Root As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents cmdExit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents txtCode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtNotes As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents txtNam As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cboNotesL As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem23 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem14 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents cmdCboManagePRF As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem25 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents txtFileNames As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents cboSaler As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem3 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents chkReaded As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents XtraOpenFileDialog1 As DevExpress.XtraEditors.XtraOpenFileDialog
End Class
