<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCalendar
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
        Dim TimeRuler1 As DevExpress.XtraScheduler.TimeRuler = New DevExpress.XtraScheduler.TimeRuler()
        Dim TimeRuler2 As DevExpress.XtraScheduler.TimeRuler = New DevExpress.XtraScheduler.TimeRuler()
        Dim TimeRuler3 As DevExpress.XtraScheduler.TimeRuler = New DevExpress.XtraScheduler.TimeRuler()
        Me.SchedulerControl1 = New DevExpress.XtraScheduler.SchedulerControl()
        Me.SchedulerDataStorage1 = New DevExpress.XtraScheduler.SchedulerDataStorage(Me.components)
        Me.VwSALERSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DreamyKitchenDataSet = New DreamyKitchenCRM.DreamyKitchenDataSet()
        Me.Vw_SALERSTableAdapter = New DreamyKitchenCRM.DreamyKitchenDataSetTableAdapters.vw_SALERSTableAdapter()
        CType(Me.SchedulerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SchedulerDataStorage1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VwSALERSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DreamyKitchenDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SchedulerControl1
        '
        Me.SchedulerControl1.DataStorage = Me.SchedulerDataStorage1
        Me.SchedulerControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SchedulerControl1.Location = New System.Drawing.Point(0, 0)
        Me.SchedulerControl1.Name = "SchedulerControl1"
        Me.SchedulerControl1.Size = New System.Drawing.Size(1160, 712)
        Me.SchedulerControl1.Start = New Date(2020, 10, 5, 0, 0, 0, 0)
        Me.SchedulerControl1.TabIndex = 0
        Me.SchedulerControl1.Text = "SchedulerControl1"
        Me.SchedulerControl1.Views.DayView.TimeRulers.Add(TimeRuler1)
        Me.SchedulerControl1.Views.FullWeekView.Enabled = True
        Me.SchedulerControl1.Views.FullWeekView.TimeRulers.Add(TimeRuler2)
        Me.SchedulerControl1.Views.WeekView.Enabled = False
        Me.SchedulerControl1.Views.WorkWeekView.TimeRulers.Add(TimeRuler3)
        '
        'SchedulerDataStorage1
        '
        '
        '
        '
        Me.SchedulerDataStorage1.AppointmentDependencies.AutoReload = False
        '
        '
        '
        Me.SchedulerDataStorage1.Appointments.CustomFieldMappings.Add(New DevExpress.XtraScheduler.AppointmentCustomFieldMapping("SALERSName", "SALERS_Name"))
        '
        '
        '
        Me.SchedulerDataStorage1.Labels.ColorSaving = DevExpress.XtraScheduler.DXColorSavingType.ArgbColor
        Me.SchedulerDataStorage1.Labels.DataSource = Me.VwSALERSBindingSource
        Me.SchedulerDataStorage1.Labels.Mappings.Color = "color"
        Me.SchedulerDataStorage1.Labels.Mappings.DisplayName = "name"
        Me.SchedulerDataStorage1.Labels.Mappings.Id = "code"
        Me.SchedulerDataStorage1.Labels.Mappings.MenuCaption = "name"
        '
        '
        '
        Me.SchedulerDataStorage1.Resources.CustomFieldMappings.Add(New DevExpress.XtraScheduler.ResourceCustomFieldMapping("SALERSName", "SALERS_Name"))
        Me.SchedulerDataStorage1.Resources.Mappings.Caption = "STATUS_Name"
        Me.SchedulerDataStorage1.Resources.Mappings.Color = "color"
        Me.SchedulerDataStorage1.Resources.Mappings.Id = "ID"
        '
        'VwSALERSBindingSource
        '
        Me.VwSALERSBindingSource.DataMember = "vw_SALERS"
        Me.VwSALERSBindingSource.DataSource = Me.DreamyKitchenDataSet
        '
        'DreamyKitchenDataSet
        '
        Me.DreamyKitchenDataSet.DataSetName = "DreamyKitchenDataSet"
        Me.DreamyKitchenDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Vw_SALERSTableAdapter
        '
        Me.Vw_SALERSTableAdapter.ClearBeforeFill = True
        '
        'frmCalendar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1160, 712)
        Me.Controls.Add(Me.SchedulerControl1)
        Me.Name = "frmCalendar"
        Me.Text = "frmCalendar"
        CType(Me.SchedulerControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SchedulerDataStorage1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VwSALERSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DreamyKitchenDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SchedulerControl1 As DevExpress.XtraScheduler.SchedulerControl
    Friend WithEvents SchedulerDataStorage1 As DevExpress.XtraScheduler.SchedulerDataStorage
    Friend WithEvents DreamyKitchenDataSet As DreamyKitchenDataSet
    Friend WithEvents VwSALERSBindingSource As BindingSource
    Friend WithEvents Vw_SALERSTableAdapter As DreamyKitchenDataSetTableAdapters.vw_SALERSTableAdapter
End Class
