﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPermissions
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
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.chkDelete = New DevExpress.XtraEditors.CheckEdit()
        Me.chkLstUsers = New DevExpress.XtraEditors.CheckedListBoxControl()
        Me.chkEdit = New DevExpress.XtraEditors.CheckEdit()
        Me.chkInsert = New DevExpress.XtraEditors.CheckEdit()
        Me.cboUsers = New DevExpress.XtraEditors.LookUpEdit()
        Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.cmdExit = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdSave = New DevExpress.XtraEditors.SimpleButton()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.chkDelete.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkLstUsers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkInsert.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboUsers.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.chkDelete)
        Me.LayoutControl1.Controls.Add(Me.chkLstUsers)
        Me.LayoutControl1.Controls.Add(Me.chkEdit)
        Me.LayoutControl1.Controls.Add(Me.chkInsert)
        Me.LayoutControl1.Controls.Add(Me.cmdExit)
        Me.LayoutControl1.Controls.Add(Me.cmdSave)
        Me.LayoutControl1.Controls.Add(Me.cboUsers)
        Me.LayoutControl1.Location = New System.Drawing.Point(2, 2)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(416, 136, 650, 400)
        Me.LayoutControl1.Root = Me.Root
        Me.LayoutControl1.Size = New System.Drawing.Size(589, 200)
        Me.LayoutControl1.TabIndex = 2
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'chkDelete
        '
        Me.chkDelete.EditValue = CType(0, Byte)
        Me.chkDelete.Location = New System.Drawing.Point(311, 84)
        Me.chkDelete.Name = "chkDelete"
        Me.chkDelete.Properties.Caption = "Διαγραφή"
        Me.chkDelete.Properties.ValueChecked = CType(1, Byte)
        Me.chkDelete.Properties.ValueUnchecked = CType(0, Byte)
        Me.chkDelete.Size = New System.Drawing.Size(266, 20)
        Me.chkDelete.StyleController = Me.LayoutControl1
        Me.chkDelete.TabIndex = 11
        Me.chkDelete.Tag = "[delete],0,1,2"
        '
        'chkLstUsers
        '
        Me.chkLstUsers.HorizontalScrollbar = True
        Me.chkLstUsers.Location = New System.Drawing.Point(12, 12)
        Me.chkLstUsers.Name = "chkLstUsers"
        Me.chkLstUsers.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple
        Me.chkLstUsers.Size = New System.Drawing.Size(295, 176)
        Me.chkLstUsers.SortOrder = System.Windows.Forms.SortOrder.Ascending
        Me.chkLstUsers.StyleController = Me.LayoutControl1
        Me.chkLstUsers.TabIndex = 9
        Me.chkLstUsers.Tag = ""
        '
        'chkEdit
        '
        Me.chkEdit.EditValue = CType(0, Byte)
        Me.chkEdit.Location = New System.Drawing.Point(311, 60)
        Me.chkEdit.Name = "chkEdit"
        Me.chkEdit.Properties.Caption = "Επεξεργασία"
        Me.chkEdit.Properties.ValueChecked = CType(1, Byte)
        Me.chkEdit.Properties.ValueUnchecked = CType(0, Byte)
        Me.chkEdit.Size = New System.Drawing.Size(266, 20)
        Me.chkEdit.StyleController = Me.LayoutControl1
        Me.chkEdit.TabIndex = 10
        Me.chkEdit.Tag = "[edit],0,1,2"
        '
        'chkInsert
        '
        Me.chkInsert.EditValue = CType(0, Byte)
        Me.chkInsert.Location = New System.Drawing.Point(311, 36)
        Me.chkInsert.Name = "chkInsert"
        Me.chkInsert.Properties.Caption = "Καταχώρηση"
        Me.chkInsert.Properties.ValueChecked = CType(1, Byte)
        Me.chkInsert.Properties.ValueUnchecked = CType(0, Byte)
        Me.chkInsert.Size = New System.Drawing.Size(266, 20)
        Me.chkInsert.StyleController = Me.LayoutControl1
        Me.chkInsert.TabIndex = 9
        Me.chkInsert.Tag = "[insert],0,1,2"
        '
        'cboUsers
        '
        Me.cboUsers.Location = New System.Drawing.Point(365, 12)
        Me.cboUsers.Name = "cboUsers"
        Me.cboUsers.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.cboUsers.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboUsers.Properties.NullText = ""
        Me.cboUsers.Properties.PopupSizeable = False
        Me.cboUsers.Size = New System.Drawing.Size(212, 20)
        Me.cboUsers.StyleController = Me.LayoutControl1
        Me.cboUsers.TabIndex = 8
        Me.cboUsers.Tag = "uid,0,1,2"
        '
        'Root
        '
        Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.Root.GroupBordersVisible = False
        Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem6, Me.LayoutControlItem1, Me.LayoutControlItem2, Me.LayoutControlItem3, Me.LayoutControlItem7, Me.LayoutControlItem4, Me.LayoutControlItem5, Me.EmptySpaceItem1})
        Me.Root.Name = "Root"
        Me.Root.Size = New System.Drawing.Size(589, 200)
        Me.Root.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.chkInsert
        Me.LayoutControlItem1.Location = New System.Drawing.Point(299, 24)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(270, 24)
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.chkEdit
        Me.LayoutControlItem2.Location = New System.Drawing.Point(299, 48)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(270, 24)
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem2.TextVisible = False
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.chkDelete
        Me.LayoutControlItem3.Location = New System.Drawing.Point(299, 72)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(270, 24)
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem3.TextVisible = False
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.Control = Me.chkLstUsers
        Me.LayoutControlItem7.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(299, 180)
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem7.TextVisible = False
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(299, 96)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(270, 52)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'cmdExit
        '
        Me.cmdExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdExit.ImageOptions.Image = Global.DreamyKitchenCRM.My.Resources.Resources.icons8_exit_24
        Me.cmdExit.Location = New System.Drawing.Point(311, 160)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(135, 28)
        Me.cmdExit.StyleController = Me.LayoutControl1
        Me.cmdExit.TabIndex = 6
        Me.cmdExit.Text = "Έξοδος"
        '
        'cmdSave
        '
        Me.cmdSave.ImageOptions.Image = Global.DreamyKitchenCRM.My.Resources.Resources.icons8_save_close_24
        Me.cmdSave.Location = New System.Drawing.Point(450, 160)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(127, 28)
        Me.cmdSave.StyleController = Me.LayoutControl1
        Me.cmdSave.TabIndex = 7
        Me.cmdSave.Text = "Αποθήκευση"
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.cboUsers
        Me.LayoutControlItem6.ImageOptions.Alignment = System.Drawing.ContentAlignment.MiddleRight
        Me.LayoutControlItem6.ImageOptions.Image = Global.DreamyKitchenCRM.My.Resources.Resources.rsz_11rsz_asterisk
        Me.LayoutControlItem6.Location = New System.Drawing.Point(299, 0)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(270, 24)
        Me.LayoutControlItem6.Tag = "1"
        Me.LayoutControlItem6.Text = "Χρήστης"
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(51, 13)
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.cmdExit
        Me.LayoutControlItem4.Location = New System.Drawing.Point(299, 148)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(139, 32)
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem4.TextVisible = False
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.cmdSave
        Me.LayoutControlItem5.Location = New System.Drawing.Point(438, 148)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(131, 32)
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem5.TextVisible = False
        '
        'frmPermissions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(592, 200)
        Me.Controls.Add(Me.LayoutControl1)
        Me.IconOptions.Image = Global.DreamyKitchenCRM.My.Resources.Resources.favicon
        Me.Name = "frmPermissions"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "frmPermissions"
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.chkDelete.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkLstUsers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkInsert.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboUsers.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents cmdExit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cboUsers As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Root As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents chkDelete As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkLstUsers As DevExpress.XtraEditors.CheckedListBoxControl
    Friend WithEvents chkEdit As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkInsert As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
End Class
