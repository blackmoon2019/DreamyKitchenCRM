﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmEmpPresenation
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
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.dtFDate = New DevExpress.XtraEditors.DateEdit()
        Me.lstMonths = New DevExpress.XtraEditors.ListBoxControl()
        Me.SPR = New DevExpress.XtraSpreadsheet.SpreadsheetControl()
        Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.DreamyKitchenDataSet = New DreamyKitchenCRM.DreamyKitchenDataSet()
        Me.Vw_EMPTableAdapter = New DreamyKitchenCRM.DreamyKitchenDataSetTableAdapters.vw_EMPTableAdapter()
        Me.TableAdapterManager = New DreamyKitchenCRM.DreamyKitchenDataSetTableAdapters.TableAdapterManager()
        Me.Vw_EMP_STableAdapter = New DreamyKitchenCRM.DreamyKitchenDataSetTableAdapters.vw_EMP_STableAdapter()
        Me.Vw_EMP_SBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.cmdExportToPDF = New DevExpress.XtraEditors.SimpleButton()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.XtraSaveFileDialog1 = New DevExpress.XtraEditors.XtraSaveFileDialog(Me.components)
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.dtFDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtFDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lstMonths, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DreamyKitchenDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Vw_EMP_SBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LayoutControl1.Controls.Add(Me.cmdExportToPDF)
        Me.LayoutControl1.Controls.Add(Me.dtFDate)
        Me.LayoutControl1.Controls.Add(Me.lstMonths)
        Me.LayoutControl1.Controls.Add(Me.SPR)
        Me.LayoutControl1.Location = New System.Drawing.Point(2, -2)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.Root = Me.Root
        Me.LayoutControl1.Size = New System.Drawing.Size(1608, 682)
        Me.LayoutControl1.TabIndex = 0
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'dtFDate
        '
        Me.dtFDate.EditValue = Nothing
        Me.dtFDate.Location = New System.Drawing.Point(50, 12)
        Me.dtFDate.Name = "dtFDate"
        Me.dtFDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtFDate.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtFDate.Properties.MaskSettings.Set("mask", "yyyy")
        Me.dtFDate.Properties.ShowMonthNavigationButtons = DevExpress.Utils.DefaultBoolean.[True]
        Me.dtFDate.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.dtFDate.Properties.UseMaskAsDisplayFormat = True
        Me.dtFDate.Properties.VistaCalendarInitialViewStyle = DevExpress.XtraEditors.VistaCalendarInitialViewStyle.YearsGroupView
        Me.dtFDate.Properties.VistaCalendarViewStyle = DevExpress.XtraEditors.VistaCalendarViewStyle.YearsGroupView
        Me.dtFDate.Size = New System.Drawing.Size(82, 20)
        Me.dtFDate.StyleController = Me.LayoutControl1
        Me.dtFDate.TabIndex = 39
        Me.dtFDate.Tag = "fDate,0,1,2"
        '
        'lstMonths
        '
        Me.lstMonths.Items.AddRange(New Object() {"ΙΑΝΟΥΑΡΙΟΣ", "ΦΕΒΡΟΥΑΡΙΟΣ", "ΜΑΡΤΙΟΣ", "ΑΠΡΙΛΙΟΣ", "ΜΑΪΟΣ", "ΙΟΥΝΙΟΣ", "ΙΟΥΛΙΟΣ", "ΑΥΓΟΥΣΤΟΣ", "ΣΕΠΤΕΜΒΡΙΟΣ", "ΟΚΤΩΒΡΙΟΣ", "ΝΟΕΜΒΡΙΟΣ", "ΔΕΚΕΜΒΡΙΟΣ"})
        Me.lstMonths.Location = New System.Drawing.Point(12, 36)
        Me.lstMonths.Name = "lstMonths"
        Me.lstMonths.Size = New System.Drawing.Size(120, 608)
        Me.lstMonths.StyleController = Me.LayoutControl1
        Me.lstMonths.TabIndex = 5
        '
        'SPR
        '
        Me.SPR.Location = New System.Drawing.Point(136, 12)
        Me.SPR.Name = "SPR"
        Me.SPR.Options.Behavior.Drag = DevExpress.XtraSpreadsheet.DocumentCapability.Enabled
        Me.SPR.Options.Behavior.Drawing.Move = DevExpress.XtraSpreadsheet.DocumentCapability.Disabled
        Me.SPR.Options.Behavior.Worksheet.Delete = DevExpress.XtraSpreadsheet.DocumentCapability.Disabled
        Me.SPR.Options.Behavior.Worksheet.Hide = DevExpress.XtraSpreadsheet.DocumentCapability.Disabled
        Me.SPR.Options.Behavior.Worksheet.Insert = DevExpress.XtraSpreadsheet.DocumentCapability.Disabled
        Me.SPR.Options.Behavior.Worksheet.Unhide = DevExpress.XtraSpreadsheet.DocumentCapability.Disabled
        Me.SPR.Size = New System.Drawing.Size(1460, 658)
        Me.SPR.TabIndex = 4
        Me.SPR.Text = "SpreadsheetControl1"
        '
        'Root
        '
        Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.Root.GroupBordersVisible = False
        Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem2, Me.LayoutControlItem3, Me.LayoutControlItem4})
        Me.Root.Name = "Root"
        Me.Root.Size = New System.Drawing.Size(1608, 682)
        Me.Root.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.SPR
        Me.LayoutControlItem1.Location = New System.Drawing.Point(124, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(1464, 662)
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.lstMonths
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 24)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(124, 612)
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem2.TextVisible = False
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.dtFDate
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(124, 24)
        Me.LayoutControlItem3.Text = "ΕΤΟΣ"
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(26, 13)
        '
        'DreamyKitchenDataSet
        '
        Me.DreamyKitchenDataSet.DataSetName = "DreamyKitchenDataSet"
        Me.DreamyKitchenDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Vw_EMPTableAdapter
        '
        Me.Vw_EMPTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.UpdateOrder = DreamyKitchenCRM.DreamyKitchenDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Vw_EMP_STableAdapter
        '
        Me.Vw_EMP_STableAdapter.ClearBeforeFill = True
        '
        'Vw_EMP_SBindingSource
        '
        Me.Vw_EMP_SBindingSource.DataMember = "vw_EMP_S"
        Me.Vw_EMP_SBindingSource.DataSource = Me.DreamyKitchenDataSet
        '
        'cmdExportToPDF
        '
        Me.cmdExportToPDF.Location = New System.Drawing.Point(12, 648)
        Me.cmdExportToPDF.Name = "cmdExportToPDF"
        Me.cmdExportToPDF.Size = New System.Drawing.Size(120, 22)
        Me.cmdExportToPDF.StyleController = Me.LayoutControl1
        Me.cmdExportToPDF.TabIndex = 40
        Me.cmdExportToPDF.Text = "Export To PDF"
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.cmdExportToPDF
        Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 636)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(124, 26)
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem4.TextVisible = False
        '
        'XtraSaveFileDialog1
        '
        Me.XtraSaveFileDialog1.FileName = "XtraSaveFileDialog1"
        '
        'frmEmpPresenation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1611, 677)
        Me.Controls.Add(Me.LayoutControl1)
        Me.IconOptions.Image = Global.DreamyKitchenCRM.My.Resources.Resources.favicon
        Me.Name = "frmEmpPresenation"
        Me.Text = "Παρουσιολόγιο Έκθεσης"
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.dtFDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtFDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lstMonths, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DreamyKitchenDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Vw_EMP_SBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents SPR As DevExpress.XtraSpreadsheet.SpreadsheetControl
    Friend WithEvents Root As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents dtFDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents lstMonths As DevExpress.XtraEditors.ListBoxControl
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents DreamyKitchenDataSet As DreamyKitchenDataSet
    Friend WithEvents Vw_EMP_SBindingSource As BindingSource
    Friend WithEvents Vw_EMP_STableAdapter As DreamyKitchenDataSetTableAdapters.vw_EMP_STableAdapter
    Friend WithEvents Vw_EMPTableAdapter As DreamyKitchenDataSetTableAdapters.vw_EMPTableAdapter
    Friend WithEvents TableAdapterManager As DreamyKitchenDataSetTableAdapters.TableAdapterManager
    Friend WithEvents cmdExportToPDF As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents XtraSaveFileDialog1 As DevExpress.XtraEditors.XtraSaveFileDialog
End Class