﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmBUY
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBUY))
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.chkCredit = New DevExpress.XtraEditors.CheckEdit()
        Me.chkPaid = New DevExpress.XtraEditors.CheckEdit()
        Me.cmdExit = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdSave = New DevExpress.XtraEditors.SimpleButton()
        Me.cboSUP = New DevExpress.XtraEditors.LookUpEdit()
        Me.cboCUS = New DevExpress.XtraEditors.LookUpEdit()
        Me.dtBuy = New DevExpress.XtraEditors.DateEdit()
        Me.txtComments = New DevExpress.XtraEditors.MemoEdit()
        Me.txtCode = New DevExpress.XtraEditors.TextEdit()
        Me.cbobuyC = New DevExpress.XtraEditors.LookUpEdit()
        Me.txtnetAmount = New DevExpress.XtraEditors.TextEdit()
        Me.txtvatAmount = New DevExpress.XtraEditors.TextEdit()
        Me.cboTRANSH = New DevExpress.XtraEditors.LookUpEdit()
        Me.txtinvoiceNumber = New DevExpress.XtraEditors.TextEdit()
        Me.txtgeneral = New DevExpress.XtraEditors.TextEdit()
        Me.txtcloset = New DevExpress.XtraEditors.TextEdit()
        Me.txtkitchen = New DevExpress.XtraEditors.TextEdit()
        Me.txtbathroomFurn = New DevExpress.XtraEditors.TextEdit()
        Me.txtmaterials = New DevExpress.XtraEditors.TextEdit()
        Me.txtDevicesBuy = New DevExpress.XtraEditors.TextEdit()
        Me.cboPAY = New DevExpress.XtraEditors.LookUpEdit()
        Me.txtOrd = New DevExpress.XtraEditors.TextEdit()
        Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LExtracost = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem12 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem22 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem21 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem19 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem18 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem13 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem14 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.Lcost1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem3 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem4 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem10 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem11 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem15 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem16 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.BehaviorManager1 = New DevExpress.Utils.Behaviors.BehaviorManager(Me.components)
        Me.txttransportation = New DevExpress.XtraEditors.TextEdit()
        Me.LayoutControlItem17 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.txtglasses = New DevExpress.XtraEditors.TextEdit()
        Me.LayoutControlItem20 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.txtbench = New DevExpress.XtraEditors.TextEdit()
        Me.LayoutControlItem23 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.VwTRANSHBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DreamyKitchenDataSet = New DreamyKitchenCRM.DreamyKitchenDataSet()
        Me.Vw_PAYTableAdapter = New DreamyKitchenCRM.DreamyKitchenDataSetTableAdapters.vw_PAYTableAdapter()
        Me.VwPAYBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Vw_TRANSHTableAdapter = New DreamyKitchenCRM.DreamyKitchenDataSetTableAdapters.vw_TRANSHTableAdapter()
        Me.DreamyKitchenDataSet2 = New DreamyKitchenCRM.DreamyKitchenDataSet()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.chkCredit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkPaid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboSUP.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboCUS.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtBuy.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtBuy.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtComments.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbobuyC.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtnetAmount.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtvatAmount.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboTRANSH.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtinvoiceNumber.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtgeneral.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtcloset.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtkitchen.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtbathroomFurn.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtmaterials.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDevicesBuy.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboPAY.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtOrd.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LExtracost, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem22, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem21, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem19, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem18, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Lcost1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BehaviorManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txttransportation.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem17, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtglasses.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem20, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtbench.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem23, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VwTRANSHBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DreamyKitchenDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VwPAYBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DreamyKitchenDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.chkCredit)
        Me.LayoutControl1.Controls.Add(Me.chkPaid)
        Me.LayoutControl1.Controls.Add(Me.cmdExit)
        Me.LayoutControl1.Controls.Add(Me.cmdSave)
        Me.LayoutControl1.Controls.Add(Me.cboSUP)
        Me.LayoutControl1.Controls.Add(Me.cboCUS)
        Me.LayoutControl1.Controls.Add(Me.dtBuy)
        Me.LayoutControl1.Controls.Add(Me.txtComments)
        Me.LayoutControl1.Controls.Add(Me.txtCode)
        Me.LayoutControl1.Controls.Add(Me.cbobuyC)
        Me.LayoutControl1.Controls.Add(Me.txtnetAmount)
        Me.LayoutControl1.Controls.Add(Me.txtvatAmount)
        Me.LayoutControl1.Controls.Add(Me.cboTRANSH)
        Me.LayoutControl1.Controls.Add(Me.txtinvoiceNumber)
        Me.LayoutControl1.Controls.Add(Me.txtgeneral)
        Me.LayoutControl1.Controls.Add(Me.txtcloset)
        Me.LayoutControl1.Controls.Add(Me.txtkitchen)
        Me.LayoutControl1.Controls.Add(Me.txtbathroomFurn)
        Me.LayoutControl1.Controls.Add(Me.txtmaterials)
        Me.LayoutControl1.Controls.Add(Me.txtDevicesBuy)
        Me.LayoutControl1.Controls.Add(Me.cboPAY)
        Me.LayoutControl1.Controls.Add(Me.txtOrd)
        Me.LayoutControl1.Controls.Add(Me.txttransportation)
        Me.LayoutControl1.Controls.Add(Me.txtglasses)
        Me.LayoutControl1.Controls.Add(Me.txtbench)
        Me.LayoutControl1.Location = New System.Drawing.Point(2, -10)
        Me.LayoutControl1.Margin = New System.Windows.Forms.Padding(5)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(503, 94, 650, 400)
        Me.LayoutControl1.Root = Me.Root
        Me.LayoutControl1.Size = New System.Drawing.Size(1091, 943)
        Me.LayoutControl1.TabIndex = 4
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'chkCredit
        '
        Me.chkCredit.EditValue = CType(0, Byte)
        Me.chkCredit.Location = New System.Drawing.Point(748, 96)
        Me.chkCredit.Margin = New System.Windows.Forms.Padding(5)
        Me.chkCredit.Name = "chkCredit"
        Me.chkCredit.Properties.Caption = "Πιστωτικό"
        Me.chkCredit.Properties.ValueChecked = CType(1, Byte)
        Me.chkCredit.Properties.ValueUnchecked = CType(0, Byte)
        Me.chkCredit.Size = New System.Drawing.Size(331, 35)
        Me.chkCredit.StyleController = Me.LayoutControl1
        Me.chkCredit.TabIndex = 44
        Me.chkCredit.Tag = "isCredit,0,1,2"
        '
        'chkPaid
        '
        Me.chkPaid.EditValue = CType(0, Byte)
        Me.chkPaid.Location = New System.Drawing.Point(12, 766)
        Me.chkPaid.Margin = New System.Windows.Forms.Padding(5)
        Me.chkPaid.Name = "chkPaid"
        Me.chkPaid.Properties.Caption = "Πληρώθηκε"
        Me.chkPaid.Properties.ValueChecked = CType(1, Byte)
        Me.chkPaid.Properties.ValueUnchecked = CType(0, Byte)
        Me.chkPaid.Size = New System.Drawing.Size(185, 35)
        Me.chkPaid.StyleController = Me.LayoutControl1
        Me.chkPaid.TabIndex = 43
        Me.chkPaid.Tag = "paid,0,1,2"
        '
        'cmdExit
        '
        Me.cmdExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdExit.ImageOptions.Image = Global.DreamyKitchenCRM.My.Resources.Resources.icons8_exit_24
        Me.cmdExit.Location = New System.Drawing.Point(880, 892)
        Me.cmdExit.Margin = New System.Windows.Forms.Padding(5)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(199, 39)
        Me.cmdExit.StyleController = Me.LayoutControl1
        Me.cmdExit.TabIndex = 33
        Me.cmdExit.Text = "Έξοδος"
        '
        'cmdSave
        '
        Me.cmdSave.ImageOptions.Image = Global.DreamyKitchenCRM.My.Resources.Resources.icons8_save_close_24
        Me.cmdSave.Location = New System.Drawing.Point(729, 892)
        Me.cmdSave.Margin = New System.Windows.Forms.Padding(5)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(147, 39)
        Me.cmdSave.StyleController = Me.LayoutControl1
        Me.cmdSave.TabIndex = 34
        Me.cmdSave.Text = "Αποθήκευση"
        '
        'cboSUP
        '
        Me.cboSUP.Location = New System.Drawing.Point(204, 54)
        Me.cboSUP.Margin = New System.Windows.Forms.Padding(5)
        Me.cboSUP.Name = "cboSUP"
        Me.cboSUP.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.cboSUP.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Search), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Clear)})
        Me.cboSUP.Properties.NullText = ""
        Me.cboSUP.Properties.PopupSizeable = False
        Me.cboSUP.Size = New System.Drawing.Size(875, 38)
        Me.cboSUP.StyleController = Me.LayoutControl1
        Me.cboSUP.TabIndex = 5
        Me.cboSUP.Tag = "supID,0,1,2"
        '
        'cboCUS
        '
        Me.cboCUS.Location = New System.Drawing.Point(204, 138)
        Me.cboCUS.Margin = New System.Windows.Forms.Padding(5)
        Me.cboCUS.Name = "cboCUS"
        Me.cboCUS.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.cboCUS.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Search), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Clear)})
        Me.cboCUS.Properties.NullText = ""
        Me.cboCUS.Properties.PopupSizeable = False
        Me.cboCUS.Size = New System.Drawing.Size(875, 38)
        Me.cboCUS.StyleController = Me.LayoutControl1
        Me.cboCUS.TabIndex = 6
        Me.cboCUS.Tag = "cusID,0,1,2"
        '
        'dtBuy
        '
        Me.dtBuy.EditValue = Nothing
        Me.dtBuy.Location = New System.Drawing.Point(564, 96)
        Me.dtBuy.Margin = New System.Windows.Forms.Padding(5)
        Me.dtBuy.Name = "dtBuy"
        Me.dtBuy.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtBuy.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtBuy.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.dtBuy.Size = New System.Drawing.Size(180, 38)
        Me.dtBuy.StyleController = Me.LayoutControl1
        Me.dtBuy.TabIndex = 32
        Me.dtBuy.Tag = "dtBuy,0,1,2"
        '
        'txtComments
        '
        Me.txtComments.Location = New System.Drawing.Point(204, 578)
        Me.txtComments.Margin = New System.Windows.Forms.Padding(5)
        Me.txtComments.Name = "txtComments"
        Me.txtComments.Size = New System.Drawing.Size(875, 184)
        Me.txtComments.StyleController = Me.LayoutControl1
        Me.txtComments.TabIndex = 17
        Me.txtComments.Tag = "cmt,0,1,2"
        '
        'txtCode
        '
        Me.txtCode.Location = New System.Drawing.Point(204, 12)
        Me.txtCode.Margin = New System.Windows.Forms.Padding(5)
        Me.txtCode.Name = "txtCode"
        Me.txtCode.Properties.Appearance.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.txtCode.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtCode.Properties.Appearance.Options.UseBackColor = True
        Me.txtCode.Properties.Appearance.Options.UseFont = True
        Me.txtCode.Properties.ReadOnly = True
        Me.txtCode.Size = New System.Drawing.Size(145, 38)
        Me.txtCode.StyleController = Me.LayoutControl1
        Me.txtCode.TabIndex = 4
        Me.txtCode.Tag = "code,0"
        '
        'cbobuyC
        '
        Me.cbobuyC.Location = New System.Drawing.Point(204, 850)
        Me.cbobuyC.Margin = New System.Windows.Forms.Padding(5)
        Me.cbobuyC.Name = "cbobuyC"
        Me.cbobuyC.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.cbobuyC.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Search), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Clear)})
        Me.cbobuyC.Properties.NullText = ""
        Me.cbobuyC.Properties.PopupSizeable = False
        Me.cbobuyC.Size = New System.Drawing.Size(875, 38)
        Me.cbobuyC.StyleController = Me.LayoutControl1
        Me.cbobuyC.TabIndex = 6
        Me.cbobuyC.Tag = "buyCID,0,1,2"
        '
        'txtnetAmount
        '
        Me.txtnetAmount.EditValue = "0,00 €"
        Me.txtnetAmount.Location = New System.Drawing.Point(582, 766)
        Me.txtnetAmount.Margin = New System.Windows.Forms.Padding(5)
        Me.txtnetAmount.Name = "txtnetAmount"
        Me.txtnetAmount.Properties.DisplayFormat.FormatString = "c"
        Me.txtnetAmount.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtnetAmount.Properties.EditFormat.FormatString = "n2"
        Me.txtnetAmount.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtnetAmount.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtnetAmount.Properties.MaskSettings.Set("MaskManagerType", GetType(DevExpress.Data.Mask.NumericMaskManager))
        Me.txtnetAmount.Properties.MaskSettings.Set("mask", "c2")
        Me.txtnetAmount.Properties.Tag = "BenchExtraPrice"
        Me.txtnetAmount.Size = New System.Drawing.Size(497, 38)
        Me.txtnetAmount.StyleController = Me.LayoutControl1
        Me.txtnetAmount.TabIndex = 42
        Me.txtnetAmount.Tag = "netAmount,0,1,2"
        Me.txtnetAmount.Visible = False
        '
        'txtvatAmount
        '
        Me.txtvatAmount.EditValue = "0,00 €"
        Me.txtvatAmount.Location = New System.Drawing.Point(584, 808)
        Me.txtvatAmount.Margin = New System.Windows.Forms.Padding(5)
        Me.txtvatAmount.Name = "txtvatAmount"
        Me.txtvatAmount.Properties.DisplayFormat.FormatString = "c"
        Me.txtvatAmount.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtvatAmount.Properties.EditFormat.FormatString = "n2"
        Me.txtvatAmount.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtvatAmount.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtvatAmount.Properties.MaskSettings.Set("MaskManagerType", GetType(DevExpress.Data.Mask.NumericMaskManager))
        Me.txtvatAmount.Properties.MaskSettings.Set("mask", "c2")
        Me.txtvatAmount.Properties.Tag = "BenchExtraPrice"
        Me.txtvatAmount.Size = New System.Drawing.Size(495, 38)
        Me.txtvatAmount.StyleController = Me.LayoutControl1
        Me.txtvatAmount.TabIndex = 42
        Me.txtvatAmount.Tag = "vatAmount,0,1,2"
        Me.txtvatAmount.Visible = False
        '
        'cboTRANSH
        '
        Me.cboTRANSH.Location = New System.Drawing.Point(204, 180)
        Me.cboTRANSH.Margin = New System.Windows.Forms.Padding(5)
        Me.cboTRANSH.Name = "cboTRANSH"
        Me.cboTRANSH.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.cboTRANSH.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Search), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Clear)})
        Me.cboTRANSH.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 33, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("code", "code", 53, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("cusID", "cus ID", 65, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("dtCharge", "dt Charge", 95, DevExpress.Utils.FormatType.DateTime, "d/M/yyyy", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("GRMONTH", "GRMONTH", 98, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("amt", "amt", 45, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("cmt", "cmt", 43, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("modifiedBy", "modified By", 107, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("modifiedOn", "modified On", 110, DevExpress.Utils.FormatType.DateTime, "d/M/yyyy", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("createdOn", "created On", 105, DevExpress.Utils.FormatType.DateTime, "d/M/yyyy", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("createdBy", "created By", 102, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Fullname", "Fullname", 85, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("RealName", "Real Name", 100, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Totamt", "Totamt", 72, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("vatamt", "vatamt", 72, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("bal", "bal", 38, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("SalerName", "Saler Name", 105, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("SalerID", "Saler ID", 78, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("EmpTID", "Emp TID", 82, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("invTypeDescr", "inv Type Descr", 133, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("description", "Περιγραφή Έργου", 102, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("invType", "inv Type", 83, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("empID", "emp ID", 72, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default])})
        Me.cboTRANSH.Properties.DataSource = Me.VwTRANSHBindingSource
        Me.cboTRANSH.Properties.DisplayMember = "FullTranshDescription"
        Me.cboTRANSH.Properties.NullText = ""
        Me.cboTRANSH.Properties.PopupSizeable = False
        Me.cboTRANSH.Properties.ValueMember = "ID"
        Me.cboTRANSH.Size = New System.Drawing.Size(875, 38)
        Me.cboTRANSH.StyleController = Me.LayoutControl1
        Me.cboTRANSH.TabIndex = 6
        Me.cboTRANSH.Tag = "transhID,0,1,2"
        '
        'txtinvoiceNumber
        '
        Me.txtinvoiceNumber.Location = New System.Drawing.Point(204, 96)
        Me.txtinvoiceNumber.Margin = New System.Windows.Forms.Padding(5)
        Me.txtinvoiceNumber.Name = "txtinvoiceNumber"
        Me.txtinvoiceNumber.Size = New System.Drawing.Size(164, 38)
        Me.txtinvoiceNumber.StyleController = Me.LayoutControl1
        Me.txtinvoiceNumber.TabIndex = 22
        Me.txtinvoiceNumber.Tag = "invoiceNumber,0,1,2"
        '
        'txtgeneral
        '
        Me.txtgeneral.EditValue = "0,00 €"
        Me.txtgeneral.Location = New System.Drawing.Point(217, 523)
        Me.txtgeneral.Margin = New System.Windows.Forms.Padding(5)
        Me.txtgeneral.Name = "txtgeneral"
        Me.txtgeneral.Properties.DisplayFormat.FormatString = "c"
        Me.txtgeneral.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtgeneral.Properties.EditFormat.FormatString = "n2"
        Me.txtgeneral.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtgeneral.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtgeneral.Properties.MaskSettings.Set("MaskManagerType", GetType(DevExpress.Data.Mask.NumericMaskManager))
        Me.txtgeneral.Properties.MaskSettings.Set("mask", "c2")
        Me.txtgeneral.Properties.Tag = "BenchExtraPrice"
        Me.txtgeneral.Size = New System.Drawing.Size(349, 38)
        Me.txtgeneral.StyleController = Me.LayoutControl1
        Me.txtgeneral.TabIndex = 42
        Me.txtgeneral.Tag = "general,0,1,2"
        Me.txtgeneral.Visible = False
        '
        'txtcloset
        '
        Me.txtcloset.EditValue = "0,00 €"
        Me.txtcloset.Location = New System.Drawing.Point(217, 397)
        Me.txtcloset.Margin = New System.Windows.Forms.Padding(5)
        Me.txtcloset.Name = "txtcloset"
        Me.txtcloset.Properties.DisplayFormat.FormatString = "c"
        Me.txtcloset.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtcloset.Properties.EditFormat.FormatString = "n2"
        Me.txtcloset.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtcloset.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtcloset.Properties.MaskSettings.Set("MaskManagerType", GetType(DevExpress.Data.Mask.NumericMaskManager))
        Me.txtcloset.Properties.MaskSettings.Set("mask", "c2")
        Me.txtcloset.Properties.Tag = "BenchExtraPrice"
        Me.txtcloset.Size = New System.Drawing.Size(349, 38)
        Me.txtcloset.StyleController = Me.LayoutControl1
        Me.txtcloset.TabIndex = 42
        Me.txtcloset.Tag = "closet,0,1,2"
        Me.txtcloset.Visible = False
        '
        'txtkitchen
        '
        Me.txtkitchen.EditValue = "0,00 €"
        Me.txtkitchen.Location = New System.Drawing.Point(217, 355)
        Me.txtkitchen.Margin = New System.Windows.Forms.Padding(5)
        Me.txtkitchen.Name = "txtkitchen"
        Me.txtkitchen.Properties.DisplayFormat.FormatString = "c"
        Me.txtkitchen.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtkitchen.Properties.EditFormat.FormatString = "n2"
        Me.txtkitchen.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtkitchen.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtkitchen.Properties.MaskSettings.Set("MaskManagerType", GetType(DevExpress.Data.Mask.NumericMaskManager))
        Me.txtkitchen.Properties.MaskSettings.Set("mask", "c2")
        Me.txtkitchen.Properties.Tag = "BenchExtraPrice"
        Me.txtkitchen.Size = New System.Drawing.Size(349, 38)
        Me.txtkitchen.StyleController = Me.LayoutControl1
        Me.txtkitchen.TabIndex = 42
        Me.txtkitchen.Tag = "kitchen,0,1,2"
        Me.txtkitchen.Visible = False
        '
        'txtbathroomFurn
        '
        Me.txtbathroomFurn.EditValue = "0,00 €"
        Me.txtbathroomFurn.Location = New System.Drawing.Point(217, 439)
        Me.txtbathroomFurn.Margin = New System.Windows.Forms.Padding(5)
        Me.txtbathroomFurn.Name = "txtbathroomFurn"
        Me.txtbathroomFurn.Properties.DisplayFormat.FormatString = "c"
        Me.txtbathroomFurn.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtbathroomFurn.Properties.EditFormat.FormatString = "n2"
        Me.txtbathroomFurn.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtbathroomFurn.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtbathroomFurn.Properties.MaskSettings.Set("MaskManagerType", GetType(DevExpress.Data.Mask.NumericMaskManager))
        Me.txtbathroomFurn.Properties.MaskSettings.Set("mask", "c2")
        Me.txtbathroomFurn.Properties.Tag = "BenchExtraPrice"
        Me.txtbathroomFurn.Size = New System.Drawing.Size(349, 38)
        Me.txtbathroomFurn.StyleController = Me.LayoutControl1
        Me.txtbathroomFurn.TabIndex = 42
        Me.txtbathroomFurn.Tag = "bathroomFurn,0,1,2"
        Me.txtbathroomFurn.Visible = False
        '
        'txtmaterials
        '
        Me.txtmaterials.EditValue = "0,00 €"
        Me.txtmaterials.Location = New System.Drawing.Point(217, 481)
        Me.txtmaterials.Margin = New System.Windows.Forms.Padding(5)
        Me.txtmaterials.Name = "txtmaterials"
        Me.txtmaterials.Properties.DisplayFormat.FormatString = "c"
        Me.txtmaterials.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtmaterials.Properties.EditFormat.FormatString = "n2"
        Me.txtmaterials.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtmaterials.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtmaterials.Properties.MaskSettings.Set("MaskManagerType", GetType(DevExpress.Data.Mask.NumericMaskManager))
        Me.txtmaterials.Properties.MaskSettings.Set("mask", "c2")
        Me.txtmaterials.Properties.Tag = "BenchExtraPrice"
        Me.txtmaterials.Size = New System.Drawing.Size(349, 38)
        Me.txtmaterials.StyleController = Me.LayoutControl1
        Me.txtmaterials.TabIndex = 42
        Me.txtmaterials.Tag = "materials,0,1,2"
        Me.txtmaterials.Visible = False
        '
        'txtDevicesBuy
        '
        Me.txtDevicesBuy.EditValue = "0,00 €"
        Me.txtDevicesBuy.Location = New System.Drawing.Point(217, 313)
        Me.txtDevicesBuy.Margin = New System.Windows.Forms.Padding(5)
        Me.txtDevicesBuy.Name = "txtDevicesBuy"
        Me.txtDevicesBuy.Properties.DisplayFormat.FormatString = "c"
        Me.txtDevicesBuy.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtDevicesBuy.Properties.EditFormat.FormatString = "n2"
        Me.txtDevicesBuy.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtDevicesBuy.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtDevicesBuy.Properties.MaskSettings.Set("MaskManagerType", GetType(DevExpress.Data.Mask.NumericMaskManager))
        Me.txtDevicesBuy.Properties.MaskSettings.Set("mask", "c2")
        Me.txtDevicesBuy.Properties.Tag = "BenchExtraPrice"
        Me.txtDevicesBuy.Properties.UseReadOnlyAppearance = False
        Me.txtDevicesBuy.Size = New System.Drawing.Size(349, 38)
        Me.txtDevicesBuy.StyleController = Me.LayoutControl1
        Me.txtDevicesBuy.TabIndex = 42
        Me.txtDevicesBuy.Tag = "DevicesBuy,0,1,2"
        Me.txtDevicesBuy.Visible = False
        '
        'cboPAY
        '
        Me.cboPAY.Location = New System.Drawing.Point(204, 222)
        Me.cboPAY.Margin = New System.Windows.Forms.Padding(5)
        Me.cboPAY.Name = "cboPAY"
        Me.cboPAY.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.cboPAY.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Search), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Clear)})
        Me.cboPAY.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 33, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("code", "code", 53, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("cusID", "cus ID", 65, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("dtCharge", "dt Charge", 95, DevExpress.Utils.FormatType.DateTime, "d/M/yyyy", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("GRMONTH", "GRMONTH", 98, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("amt", "amt", 45, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("cmt", "cmt", 43, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("modifiedBy", "modified By", 107, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("modifiedOn", "modified On", 110, DevExpress.Utils.FormatType.DateTime, "d/M/yyyy", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("createdOn", "created On", 105, DevExpress.Utils.FormatType.DateTime, "d/M/yyyy", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("createdBy", "created By", 102, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Fullname", "Fullname", 85, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("RealName", "Real Name", 100, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Totamt", "Totamt", 72, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("vatamt", "vatamt", 72, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("bal", "bal", 38, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("SalerName", "Saler Name", 105, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("SalerID", "Saler ID", 78, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("EmpTID", "Emp TID", 82, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("invTypeDescr", "inv Type Descr", 133, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("description", "Περιγραφή Έργου", 102, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("invType", "inv Type", 83, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("empID", "emp ID", 72, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default])})
        Me.cboPAY.Properties.NullText = ""
        Me.cboPAY.Properties.PopupSizeable = False
        Me.cboPAY.Size = New System.Drawing.Size(875, 38)
        Me.cboPAY.StyleController = Me.LayoutControl1
        Me.cboPAY.TabIndex = 6
        Me.cboPAY.Tag = "payID,0,1,2"
        '
        'txtOrd
        '
        Me.txtOrd.EditValue = "0"
        Me.txtOrd.Location = New System.Drawing.Point(545, 12)
        Me.txtOrd.Margin = New System.Windows.Forms.Padding(5)
        Me.txtOrd.Name = "txtOrd"
        Me.txtOrd.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtOrd.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtOrd.Properties.Appearance.Options.UseBackColor = True
        Me.txtOrd.Properties.Appearance.Options.UseFont = True
        Me.txtOrd.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtOrd.Properties.EditFormat.FormatString = "n0"
        Me.txtOrd.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtOrd.Properties.MaskSettings.Set("MaskManagerType", GetType(DevExpress.Data.Mask.NumericMaskManager))
        Me.txtOrd.Properties.MaskSettings.Set("MaskManagerSignature", "allowNull=False")
        Me.txtOrd.Properties.MaskSettings.Set("mask", "n0")
        Me.txtOrd.Properties.UseMaskAsDisplayFormat = True
        Me.txtOrd.Size = New System.Drawing.Size(95, 38)
        Me.txtOrd.StyleController = Me.LayoutControl1
        Me.txtOrd.TabIndex = 4
        Me.txtOrd.Tag = "ord,0,1,2"
        '
        'Root
        '
        Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.Root.GroupBordersVisible = False
        Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem9, Me.LayoutControlItem4, Me.LayoutControlItem3, Me.LayoutControlItem1, Me.EmptySpaceItem1, Me.EmptySpaceItem2, Me.LayoutControlItem2, Me.LExtracost, Me.LayoutControlItem12, Me.LayoutControlGroup2, Me.LayoutControlItem6, Me.LayoutControlItem5, Me.LayoutControlItem13, Me.LayoutControlItem14, Me.Lcost1, Me.EmptySpaceItem3, Me.EmptySpaceItem4, Me.LayoutControlItem10, Me.LayoutControlItem11, Me.LayoutControlItem15, Me.LayoutControlItem16, Me.LayoutControlGroup1})
        Me.Root.Name = "Root"
        Me.Root.Size = New System.Drawing.Size(1091, 943)
        Me.Root.TextVisible = False
        '
        'LayoutControlItem9
        '
        Me.LayoutControlItem9.Control = Me.cboSUP
        Me.LayoutControlItem9.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem9.CustomizationFormText = "Νομός"
        Me.LayoutControlItem9.HighlightFocusedItem = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlItem9.ImageOptions.Image = CType(resources.GetObject("LayoutControlItem9.ImageOptions.Image"), System.Drawing.Image)
        Me.LayoutControlItem9.Location = New System.Drawing.Point(0, 42)
        Me.LayoutControlItem9.Name = "LayoutControlItem9"
        Me.LayoutControlItem9.Size = New System.Drawing.Size(1071, 42)
        Me.LayoutControlItem9.Tag = "1"
        Me.LayoutControlItem9.Text = "Προμηθευτής"
        Me.LayoutControlItem9.TextSize = New System.Drawing.Size(180, 23)
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.txtCode
        Me.LayoutControlItem4.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem4.CustomizationFormText = "Κωδικός"
        Me.LayoutControlItem4.HighlightFocusedItem = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(341, 42)
        Me.LayoutControlItem4.Text = "Κωδικός"
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(180, 23)
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.cmdSave
        Me.LayoutControlItem3.Location = New System.Drawing.Point(717, 880)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(151, 43)
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem3.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.cmdExit
        Me.LayoutControlItem1.Location = New System.Drawing.Point(868, 880)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(203, 43)
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(632, 0)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(439, 42)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'EmptySpaceItem2
        '
        Me.EmptySpaceItem2.AllowHotTrack = False
        Me.EmptySpaceItem2.Location = New System.Drawing.Point(0, 880)
        Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Size = New System.Drawing.Size(717, 43)
        Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.dtBuy
        Me.LayoutControlItem2.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem2.CustomizationFormText = "Ημερ/νία Ολοκλήρωσης"
        Me.LayoutControlItem2.ImageOptions.Image = CType(resources.GetObject("LayoutControlItem2.ImageOptions.Image"), System.Drawing.Image)
        Me.LayoutControlItem2.Location = New System.Drawing.Point(360, 84)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(376, 42)
        Me.LayoutControlItem2.Tag = "1"
        Me.LayoutControlItem2.Text = "Ημερ/νία Τιμολογίου"
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(180, 23)
        '
        'LExtracost
        '
        Me.LExtracost.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 8.142858!, System.Drawing.FontStyle.Bold)
        Me.LExtracost.AppearanceItemCaption.Options.UseFont = True
        Me.LExtracost.Control = Me.txtvatAmount
        Me.LExtracost.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LExtracost.CustomizationFormText = "Τελική Αξία"
        Me.LExtracost.HighlightFocusedItem = DevExpress.Utils.DefaultBoolean.[True]
        Me.LExtracost.Location = New System.Drawing.Point(380, 796)
        Me.LExtracost.Name = "LExtracost"
        Me.LExtracost.Size = New System.Drawing.Size(691, 42)
        Me.LExtracost.Text = "Αξία Με ΦΠΑ"
        Me.LExtracost.TextSize = New System.Drawing.Size(180, 23)
        '
        'LayoutControlItem12
        '
        Me.LayoutControlItem12.Control = Me.txtinvoiceNumber
        Me.LayoutControlItem12.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem12.CustomizationFormText = "Τηλέφωνο"
        Me.LayoutControlItem12.HighlightFocusedItem = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlItem12.ImageOptions.Image = Global.DreamyKitchenCRM.My.Resources.Resources.rsz_11rsz_asterisk
        Me.LayoutControlItem12.Location = New System.Drawing.Point(0, 84)
        Me.LayoutControlItem12.Name = "LayoutControlItem12"
        Me.LayoutControlItem12.Size = New System.Drawing.Size(360, 42)
        Me.LayoutControlItem12.Tag = "1"
        Me.LayoutControlItem12.Text = "Τιμολόγιο"
        Me.LayoutControlItem12.TextSize = New System.Drawing.Size(180, 23)
        '
        'LayoutControlGroup2
        '
        Me.LayoutControlGroup2.CustomizationFormText = "Ξυλεία"
        Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem7, Me.LayoutControlItem22, Me.LayoutControlItem21, Me.LayoutControlItem8, Me.LayoutControlItem19, Me.LayoutControlItem18})
        Me.LayoutControlGroup2.Location = New System.Drawing.Point(0, 252)
        Me.LayoutControlGroup2.Name = "LayoutControlGroup2"
        Me.LayoutControlGroup2.OptionsItemText.TextToControlDistance = 3
        Me.LayoutControlGroup2.Size = New System.Drawing.Size(571, 314)
        Me.LayoutControlGroup2.Text = "Ξυλεία/Συσκευές(Χωρίς ΦΠΑ)"
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.Control = Me.txtgeneral
        Me.LayoutControlItem7.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem7.CustomizationFormText = "Τελική Αξία"
        Me.LayoutControlItem7.HighlightFocusedItem = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlItem7.Location = New System.Drawing.Point(0, 210)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(545, 42)
        Me.LayoutControlItem7.Text = "Διάφορα"
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(180, 23)
        '
        'LayoutControlItem22
        '
        Me.LayoutControlItem22.Control = Me.txtcloset
        Me.LayoutControlItem22.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem22.CustomizationFormText = "Τελική Αξία"
        Me.LayoutControlItem22.HighlightFocusedItem = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlItem22.Location = New System.Drawing.Point(0, 84)
        Me.LayoutControlItem22.Name = "LayoutControlItem22"
        Me.LayoutControlItem22.Size = New System.Drawing.Size(545, 42)
        Me.LayoutControlItem22.Text = "Ντουλάπα"
        Me.LayoutControlItem22.TextSize = New System.Drawing.Size(180, 23)
        '
        'LayoutControlItem21
        '
        Me.LayoutControlItem21.Control = Me.txtkitchen
        Me.LayoutControlItem21.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem21.CustomizationFormText = "Τελική Αξία"
        Me.LayoutControlItem21.HighlightFocusedItem = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlItem21.Location = New System.Drawing.Point(0, 42)
        Me.LayoutControlItem21.Name = "LayoutControlItem21"
        Me.LayoutControlItem21.Size = New System.Drawing.Size(545, 42)
        Me.LayoutControlItem21.Text = "Κουζίνα"
        Me.LayoutControlItem21.TextSize = New System.Drawing.Size(180, 23)
        '
        'LayoutControlItem8
        '
        Me.LayoutControlItem8.Control = Me.txtbathroomFurn
        Me.LayoutControlItem8.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem8.CustomizationFormText = "Τελική Αξία"
        Me.LayoutControlItem8.HighlightFocusedItem = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlItem8.Location = New System.Drawing.Point(0, 126)
        Me.LayoutControlItem8.Name = "LayoutControlItem8"
        Me.LayoutControlItem8.Size = New System.Drawing.Size(545, 42)
        Me.LayoutControlItem8.Text = "Έπιπλο Μπάνιου"
        Me.LayoutControlItem8.TextSize = New System.Drawing.Size(180, 23)
        '
        'LayoutControlItem19
        '
        Me.LayoutControlItem19.Control = Me.txtmaterials
        Me.LayoutControlItem19.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem19.CustomizationFormText = "Τελική Αξία"
        Me.LayoutControlItem19.HighlightFocusedItem = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlItem19.Location = New System.Drawing.Point(0, 168)
        Me.LayoutControlItem19.Name = "LayoutControlItem19"
        Me.LayoutControlItem19.Size = New System.Drawing.Size(545, 42)
        Me.LayoutControlItem19.Text = "Υλικά"
        Me.LayoutControlItem19.TextSize = New System.Drawing.Size(180, 23)
        '
        'LayoutControlItem18
        '
        Me.LayoutControlItem18.Control = Me.txtDevicesBuy
        Me.LayoutControlItem18.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem18.CustomizationFormText = "Τελική Αξία"
        Me.LayoutControlItem18.HighlightFocusedItem = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlItem18.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem18.Name = "LayoutControlItem18"
        Me.LayoutControlItem18.Size = New System.Drawing.Size(545, 42)
        Me.LayoutControlItem18.Text = "Αγορά Συσκευών"
        Me.LayoutControlItem18.TextSize = New System.Drawing.Size(180, 23)
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.cbobuyC
        Me.LayoutControlItem6.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem6.CustomizationFormText = "Περιοχή"
        Me.LayoutControlItem6.HighlightFocusedItem = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlItem6.ImageOptions.Image = Global.DreamyKitchenCRM.My.Resources.Resources.rsz_11rsz_asterisk
        Me.LayoutControlItem6.Location = New System.Drawing.Point(0, 838)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(1071, 42)
        Me.LayoutControlItem6.Tag = "1"
        Me.LayoutControlItem6.Text = "Κατηγορία Αγορών"
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(180, 23)
        Me.LayoutControlItem6.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.OnlyInCustomization
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.cboCUS
        Me.LayoutControlItem5.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem5.CustomizationFormText = "Περιοχή"
        Me.LayoutControlItem5.HighlightFocusedItem = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 126)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(1071, 42)
        Me.LayoutControlItem5.Tag = ""
        Me.LayoutControlItem5.Text = "Πελάτης"
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(180, 23)
        '
        'LayoutControlItem13
        '
        Me.LayoutControlItem13.Control = Me.cboTRANSH
        Me.LayoutControlItem13.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem13.CustomizationFormText = "Περιοχή"
        Me.LayoutControlItem13.HighlightFocusedItem = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlItem13.Location = New System.Drawing.Point(0, 168)
        Me.LayoutControlItem13.Name = "LayoutControlItem13"
        Me.LayoutControlItem13.Size = New System.Drawing.Size(1071, 42)
        Me.LayoutControlItem13.Tag = ""
        Me.LayoutControlItem13.Text = "Έργο Πελάτη"
        Me.LayoutControlItem13.TextSize = New System.Drawing.Size(180, 23)
        '
        'LayoutControlItem14
        '
        Me.LayoutControlItem14.Control = Me.txtComments
        Me.LayoutControlItem14.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem14.CustomizationFormText = "Σχόλια"
        Me.LayoutControlItem14.HighlightFocusedItem = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlItem14.Location = New System.Drawing.Point(0, 566)
        Me.LayoutControlItem14.Name = "LayoutControlItem14"
        Me.LayoutControlItem14.Size = New System.Drawing.Size(1071, 188)
        Me.LayoutControlItem14.Text = "Σχόλια"
        Me.LayoutControlItem14.TextSize = New System.Drawing.Size(180, 23)
        '
        'Lcost1
        '
        Me.Lcost1.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 8.142858!, System.Drawing.FontStyle.Bold)
        Me.Lcost1.AppearanceItemCaption.Options.UseFont = True
        Me.Lcost1.Control = Me.txtnetAmount
        Me.Lcost1.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.Lcost1.CustomizationFormText = "Τελική Αξία"
        Me.Lcost1.HighlightFocusedItem = DevExpress.Utils.DefaultBoolean.[True]
        Me.Lcost1.Location = New System.Drawing.Point(378, 754)
        Me.Lcost1.Name = "Lcost1"
        Me.Lcost1.Size = New System.Drawing.Size(693, 42)
        Me.Lcost1.Text = "Καθαρή Αξία"
        Me.Lcost1.TextSize = New System.Drawing.Size(180, 23)
        '
        'EmptySpaceItem3
        '
        Me.EmptySpaceItem3.AllowHotTrack = False
        Me.EmptySpaceItem3.Location = New System.Drawing.Point(189, 754)
        Me.EmptySpaceItem3.Name = "EmptySpaceItem3"
        Me.EmptySpaceItem3.Size = New System.Drawing.Size(189, 42)
        Me.EmptySpaceItem3.TextSize = New System.Drawing.Size(0, 0)
        '
        'EmptySpaceItem4
        '
        Me.EmptySpaceItem4.AllowHotTrack = False
        Me.EmptySpaceItem4.Location = New System.Drawing.Point(0, 796)
        Me.EmptySpaceItem4.Name = "EmptySpaceItem4"
        Me.EmptySpaceItem4.Size = New System.Drawing.Size(380, 42)
        Me.EmptySpaceItem4.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem10
        '
        Me.LayoutControlItem10.Control = Me.cboPAY
        Me.LayoutControlItem10.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem10.CustomizationFormText = "Περιοχή"
        Me.LayoutControlItem10.HighlightFocusedItem = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlItem10.ImageOptions.Image = CType(resources.GetObject("LayoutControlItem10.ImageOptions.Image"), System.Drawing.Image)
        Me.LayoutControlItem10.Location = New System.Drawing.Point(0, 210)
        Me.LayoutControlItem10.Name = "LayoutControlItem10"
        Me.LayoutControlItem10.Size = New System.Drawing.Size(1071, 42)
        Me.LayoutControlItem10.Text = "Τρόπος Πληρωμής"
        Me.LayoutControlItem10.TextSize = New System.Drawing.Size(180, 23)
        '
        'LayoutControlItem11
        '
        Me.LayoutControlItem11.Control = Me.chkPaid
        Me.LayoutControlItem11.Location = New System.Drawing.Point(0, 754)
        Me.LayoutControlItem11.Name = "LayoutControlItem11"
        Me.LayoutControlItem11.Size = New System.Drawing.Size(189, 42)
        Me.LayoutControlItem11.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem11.TextVisible = False
        '
        'LayoutControlItem15
        '
        Me.LayoutControlItem15.Control = Me.chkCredit
        Me.LayoutControlItem15.Location = New System.Drawing.Point(736, 84)
        Me.LayoutControlItem15.Name = "LayoutControlItem15"
        Me.LayoutControlItem15.Size = New System.Drawing.Size(335, 42)
        Me.LayoutControlItem15.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem15.TextVisible = False
        '
        'LayoutControlItem16
        '
        Me.LayoutControlItem16.Control = Me.txtOrd
        Me.LayoutControlItem16.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem16.CustomizationFormText = "Κωδικός"
        Me.LayoutControlItem16.HighlightFocusedItem = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlItem16.Location = New System.Drawing.Point(341, 0)
        Me.LayoutControlItem16.Name = "LayoutControlItem16"
        Me.LayoutControlItem16.Size = New System.Drawing.Size(291, 42)
        Me.LayoutControlItem16.Text = "Σειρά Ταξινόμησης"
        Me.LayoutControlItem16.TextSize = New System.Drawing.Size(180, 23)
        '
        'txttransportation
        '
        Me.txttransportation.EditValue = "0,00 €"
        Me.txttransportation.Location = New System.Drawing.Point(788, 313)
        Me.txttransportation.Margin = New System.Windows.Forms.Padding(5)
        Me.txttransportation.Name = "txttransportation"
        Me.txttransportation.Properties.DisplayFormat.FormatString = "c"
        Me.txttransportation.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txttransportation.Properties.EditFormat.FormatString = "n2"
        Me.txttransportation.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txttransportation.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txttransportation.Properties.MaskSettings.Set("MaskManagerType", GetType(DevExpress.Data.Mask.NumericMaskManager))
        Me.txttransportation.Properties.MaskSettings.Set("mask", "c2")
        Me.txttransportation.Properties.Tag = "BenchExtraPrice"
        Me.txttransportation.Properties.UseReadOnlyAppearance = False
        Me.txttransportation.Size = New System.Drawing.Size(278, 38)
        Me.txttransportation.StyleController = Me.LayoutControl1
        Me.txttransportation.TabIndex = 42
        Me.txttransportation.Tag = "transportation,0,1,2"
        Me.txttransportation.Visible = False
        '
        'LayoutControlItem17
        '
        Me.LayoutControlItem17.Control = Me.txttransportation
        Me.LayoutControlItem17.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem17.CustomizationFormText = "Τελική Αξία"
        Me.LayoutControlItem17.HighlightFocusedItem = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlItem17.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem17.Name = "LayoutControlItem17"
        Me.LayoutControlItem17.Size = New System.Drawing.Size(474, 42)
        Me.LayoutControlItem17.Text = "Μεταφορική"
        Me.LayoutControlItem17.TextSize = New System.Drawing.Size(180, 23)
        '
        'txtglasses
        '
        Me.txtglasses.EditValue = "0,00 €"
        Me.txtglasses.Location = New System.Drawing.Point(788, 355)
        Me.txtglasses.Margin = New System.Windows.Forms.Padding(5)
        Me.txtglasses.Name = "txtglasses"
        Me.txtglasses.Properties.DisplayFormat.FormatString = "c"
        Me.txtglasses.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtglasses.Properties.EditFormat.FormatString = "n2"
        Me.txtglasses.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtglasses.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtglasses.Properties.MaskSettings.Set("MaskManagerType", GetType(DevExpress.Data.Mask.NumericMaskManager))
        Me.txtglasses.Properties.MaskSettings.Set("mask", "c2")
        Me.txtglasses.Properties.Tag = "BenchExtraPrice"
        Me.txtglasses.Properties.UseReadOnlyAppearance = False
        Me.txtglasses.Size = New System.Drawing.Size(278, 38)
        Me.txtglasses.StyleController = Me.LayoutControl1
        Me.txtglasses.TabIndex = 42
        Me.txtglasses.Tag = "glasses,0,1,2"
        Me.txtglasses.Visible = False
        '
        'LayoutControlItem20
        '
        Me.LayoutControlItem20.Control = Me.txtglasses
        Me.LayoutControlItem20.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem20.CustomizationFormText = "Τελική Αξία"
        Me.LayoutControlItem20.HighlightFocusedItem = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlItem20.Location = New System.Drawing.Point(0, 42)
        Me.LayoutControlItem20.Name = "LayoutControlItem20"
        Me.LayoutControlItem20.Size = New System.Drawing.Size(474, 42)
        Me.LayoutControlItem20.Text = "Τζάμια"
        Me.LayoutControlItem20.TextSize = New System.Drawing.Size(180, 23)
        '
        'txtbench
        '
        Me.txtbench.EditValue = "0,00 €"
        Me.txtbench.Location = New System.Drawing.Point(788, 397)
        Me.txtbench.Margin = New System.Windows.Forms.Padding(5)
        Me.txtbench.Name = "txtbench"
        Me.txtbench.Properties.DisplayFormat.FormatString = "c"
        Me.txtbench.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtbench.Properties.EditFormat.FormatString = "n2"
        Me.txtbench.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtbench.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtbench.Properties.MaskSettings.Set("MaskManagerType", GetType(DevExpress.Data.Mask.NumericMaskManager))
        Me.txtbench.Properties.MaskSettings.Set("mask", "c2")
        Me.txtbench.Properties.Tag = "BenchExtraPrice"
        Me.txtbench.Properties.UseReadOnlyAppearance = False
        Me.txtbench.Size = New System.Drawing.Size(278, 38)
        Me.txtbench.StyleController = Me.LayoutControl1
        Me.txtbench.TabIndex = 42
        Me.txtbench.Tag = "bench,0,1,2"
        Me.txtbench.Visible = False
        '
        'LayoutControlItem23
        '
        Me.LayoutControlItem23.Control = Me.txtbench
        Me.LayoutControlItem23.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem23.CustomizationFormText = "Τελική Αξία"
        Me.LayoutControlItem23.HighlightFocusedItem = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlItem23.Location = New System.Drawing.Point(0, 84)
        Me.LayoutControlItem23.Name = "LayoutControlItem23"
        Me.LayoutControlItem23.Size = New System.Drawing.Size(474, 168)
        Me.LayoutControlItem23.Text = "Πάγκοι"
        Me.LayoutControlItem23.TextSize = New System.Drawing.Size(180, 23)
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem17, Me.LayoutControlItem20, Me.LayoutControlItem23})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(571, 252)
        Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(500, 314)
        Me.LayoutControlGroup1.Text = "Διάφορα(Χωρίς ΦΠΑ)"
        '
        'VwTRANSHBindingSource
        '
        Me.VwTRANSHBindingSource.DataMember = "vw_TRANSH"
        Me.VwTRANSHBindingSource.DataSource = Me.DreamyKitchenDataSet
        '
        'DreamyKitchenDataSet
        '
        Me.DreamyKitchenDataSet.DataSetName = "DreamyKitchenDataSet"
        Me.DreamyKitchenDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Vw_PAYTableAdapter
        '
        Me.Vw_PAYTableAdapter.ClearBeforeFill = True
        '
        'VwPAYBindingSource
        '
        Me.VwPAYBindingSource.DataMember = "vw_PAY"
        Me.VwPAYBindingSource.DataSource = Me.DreamyKitchenDataSet
        '
        'Vw_TRANSHTableAdapter
        '
        Me.Vw_TRANSHTableAdapter.ClearBeforeFill = True
        '
        'DreamyKitchenDataSet2
        '
        Me.DreamyKitchenDataSet2.DataSetName = "DreamyKitchenDataSet"
        Me.DreamyKitchenDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'frmBUY
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 23.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1086, 926)
        Me.Controls.Add(Me.LayoutControl1)
        Me.IconOptions.Image = Global.DreamyKitchenCRM.My.Resources.Resources.favicon
        Me.Name = "frmBUY"
        Me.Text = "Αγορές"
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.chkCredit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkPaid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboSUP.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboCUS.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtBuy.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtBuy.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtComments.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbobuyC.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtnetAmount.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtvatAmount.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboTRANSH.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtinvoiceNumber.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtgeneral.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtcloset.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtkitchen.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtbathroomFurn.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtmaterials.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDevicesBuy.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboPAY.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtOrd.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LExtracost, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem22, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem21, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem19, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem18, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Lcost1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BehaviorManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txttransportation.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem17, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtglasses.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem20, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtbench.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem23, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VwTRANSHBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DreamyKitchenDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VwPAYBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DreamyKitchenDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents cmdExit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cboSUP As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents cboCUS As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents dtBuy As DevExpress.XtraEditors.DateEdit
    Friend WithEvents txtComments As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents txtCode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cbobuyC As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents txtnetAmount As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtvatAmount As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cboTRANSH As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Root As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LayoutControlItem14 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents Lcost1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LExtracost As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem13 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents txtinvoiceNumber As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem12 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents VwTRANSHBindingSource As BindingSource
    Friend WithEvents DreamyKitchenDataSet As DreamyKitchenDataSet
    Friend WithEvents Vw_TRANSHTableAdapter As DreamyKitchenDataSetTableAdapters.vw_TRANSHTableAdapter
    Friend WithEvents txtgeneral As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtcloset As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtkitchen As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtbathroomFurn As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtmaterials As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem22 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem21 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem19 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents txtDevicesBuy As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem18 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem3 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem4 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents cboPAY As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LayoutControlItem10 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents DreamyKitchenDataSet2 As DreamyKitchenDataSet
    Friend WithEvents VwPAYBindingSource As BindingSource
    Friend WithEvents Vw_PAYTableAdapter As DreamyKitchenDataSetTableAdapters.vw_PAYTableAdapter
    Friend WithEvents chkPaid As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents LayoutControlItem11 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents chkCredit As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents LayoutControlItem15 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents BehaviorManager1 As DevExpress.Utils.Behaviors.BehaviorManager
    Friend WithEvents txtOrd As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem16 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents txttransportation As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtglasses As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtbench As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem17 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem20 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem23 As DevExpress.XtraLayout.LayoutControlItem
End Class