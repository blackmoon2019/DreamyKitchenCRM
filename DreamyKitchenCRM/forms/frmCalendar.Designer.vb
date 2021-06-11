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
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.CommonBar1 = New DevExpress.XtraScheduler.UI.CommonBar()
        Me.OpenScheduleItem1 = New DevExpress.XtraScheduler.UI.OpenScheduleItem()
        Me.SaveScheduleItem1 = New DevExpress.XtraScheduler.UI.SaveScheduleItem()
        Me.PrintBar1 = New DevExpress.XtraScheduler.UI.PrintBar()
        Me.PrintPreviewItem1 = New DevExpress.XtraScheduler.UI.PrintPreviewItem()
        Me.PrintItem1 = New DevExpress.XtraScheduler.UI.PrintItem()
        Me.PrintPageSetupItem1 = New DevExpress.XtraScheduler.UI.PrintPageSetupItem()
        Me.AppointmentBar1 = New DevExpress.XtraScheduler.UI.AppointmentBar()
        Me.NewAppointmentItem1 = New DevExpress.XtraScheduler.UI.NewAppointmentItem()
        Me.NewRecurringAppointmentItem1 = New DevExpress.XtraScheduler.UI.NewRecurringAppointmentItem()
        Me.NavigatorBar1 = New DevExpress.XtraScheduler.UI.NavigatorBar()
        Me.NavigateViewBackwardItem1 = New DevExpress.XtraScheduler.UI.NavigateViewBackwardItem()
        Me.NavigateViewForwardItem1 = New DevExpress.XtraScheduler.UI.NavigateViewForwardItem()
        Me.GotoTodayItem1 = New DevExpress.XtraScheduler.UI.GotoTodayItem()
        Me.ViewZoomInItem1 = New DevExpress.XtraScheduler.UI.ViewZoomInItem()
        Me.ViewZoomOutItem1 = New DevExpress.XtraScheduler.UI.ViewZoomOutItem()
        Me.ArrangeBar1 = New DevExpress.XtraScheduler.UI.ArrangeBar()
        Me.SwitchToDayViewItem1 = New DevExpress.XtraScheduler.UI.SwitchToDayViewItem()
        Me.SwitchToWorkWeekViewItem1 = New DevExpress.XtraScheduler.UI.SwitchToWorkWeekViewItem()
        Me.SwitchToWeekViewItem1 = New DevExpress.XtraScheduler.UI.SwitchToWeekViewItem()
        Me.SwitchToFullWeekViewItem1 = New DevExpress.XtraScheduler.UI.SwitchToFullWeekViewItem()
        Me.SwitchToMonthViewItem1 = New DevExpress.XtraScheduler.UI.SwitchToMonthViewItem()
        Me.SwitchToTimelineViewItem1 = New DevExpress.XtraScheduler.UI.SwitchToTimelineViewItem()
        Me.SwitchToGanttViewItem1 = New DevExpress.XtraScheduler.UI.SwitchToGanttViewItem()
        Me.SwitchToAgendaViewItem1 = New DevExpress.XtraScheduler.UI.SwitchToAgendaViewItem()
        Me.GroupByBar1 = New DevExpress.XtraScheduler.UI.GroupByBar()
        Me.GroupByNoneItem1 = New DevExpress.XtraScheduler.UI.GroupByNoneItem()
        Me.GroupByDateItem1 = New DevExpress.XtraScheduler.UI.GroupByDateItem()
        Me.GroupByResourceItem1 = New DevExpress.XtraScheduler.UI.GroupByResourceItem()
        Me.BarEditItem1 = New DevExpress.XtraBars.BarEditItem()
        Me.cboStatus = New DevExpress.XtraEditors.Repository.RepositoryItemCheckedComboBoxEdit()
        Me.Ο = New DevExpress.XtraBars.BarEditItem()
        Me.cboCompleted = New DevExpress.XtraEditors.Repository.RepositoryItemCheckedComboBoxEdit()
        Me.BarEditItem2 = New DevExpress.XtraBars.BarEditItem()
        Me.txtSearch = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.Ανανέωση = New DevExpress.XtraBars.BarButtonItem()
        Me.BarNewRec = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.BarHeaderItem1 = New DevExpress.XtraBars.BarHeaderItem()
        Me.DreamyKitchenAdapter = New DreamyKitchenCRM.DreamyKitchenDataSetTableAdapters.vw_SALERSTableAdapter()
        Me.SchedulerBarController1 = New DevExpress.XtraScheduler.UI.SchedulerBarController(Me.components)
        CType(Me.SchedulerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SchedulerDataStorage1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VwSALERSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DreamyKitchenDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboStatus, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboCompleted, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSearch, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SchedulerBarController1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SchedulerControl1
        '
        Me.SchedulerControl1.DataStorage = Me.SchedulerDataStorage1
        Me.SchedulerControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SchedulerControl1.Location = New System.Drawing.Point(0, 24)
        Me.SchedulerControl1.MenuManager = Me.BarManager1
        Me.SchedulerControl1.Name = "SchedulerControl1"
        Me.SchedulerControl1.Size = New System.Drawing.Size(1495, 688)
        Me.SchedulerControl1.Start = New Date(2020, 10, 5, 0, 0, 0, 0)
        Me.SchedulerControl1.TabIndex = 0
        Me.SchedulerControl1.Text = "SchedulerControl1"
        Me.SchedulerControl1.Views.DayView.TimeRulers.Add(TimeRuler1)
        Me.SchedulerControl1.Views.FullWeekView.Enabled = True
        Me.SchedulerControl1.Views.FullWeekView.TimeRulers.Add(TimeRuler2)
        Me.SchedulerControl1.Views.WeekView.Enabled = False
        Me.SchedulerControl1.Views.WorkWeekView.TimeRulers.Add(TimeRuler3)
        Me.SchedulerControl1.Views.YearView.UseOptimizedScrolling = False
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
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.CommonBar1, Me.PrintBar1, Me.AppointmentBar1, Me.NavigatorBar1, Me.ArrangeBar1, Me.GroupByBar1})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.OpenScheduleItem1, Me.SaveScheduleItem1, Me.PrintPreviewItem1, Me.PrintItem1, Me.PrintPageSetupItem1, Me.NewAppointmentItem1, Me.NewRecurringAppointmentItem1, Me.NavigateViewBackwardItem1, Me.NavigateViewForwardItem1, Me.GotoTodayItem1, Me.ViewZoomInItem1, Me.ViewZoomOutItem1, Me.SwitchToDayViewItem1, Me.SwitchToWorkWeekViewItem1, Me.SwitchToWeekViewItem1, Me.SwitchToFullWeekViewItem1, Me.SwitchToMonthViewItem1, Me.SwitchToTimelineViewItem1, Me.SwitchToGanttViewItem1, Me.SwitchToAgendaViewItem1, Me.GroupByNoneItem1, Me.GroupByDateItem1, Me.GroupByResourceItem1, Me.BarEditItem1, Me.Ανανέωση, Me.BarNewRec, Me.Ο, Me.BarHeaderItem1, Me.BarEditItem2})
        Me.BarManager1.MaxItemId = 70
        Me.BarManager1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.cboStatus, Me.cboCompleted, Me.txtSearch})
        '
        'CommonBar1
        '
        Me.CommonBar1.Control = Me.SchedulerControl1
        Me.CommonBar1.DockCol = 0
        Me.CommonBar1.DockRow = 0
        Me.CommonBar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.CommonBar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.OpenScheduleItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.SaveScheduleItem1)})
        '
        'OpenScheduleItem1
        '
        Me.OpenScheduleItem1.Id = 41
        Me.OpenScheduleItem1.Name = "OpenScheduleItem1"
        '
        'SaveScheduleItem1
        '
        Me.SaveScheduleItem1.Id = 42
        Me.SaveScheduleItem1.Name = "SaveScheduleItem1"
        '
        'PrintBar1
        '
        Me.PrintBar1.Control = Me.SchedulerControl1
        Me.PrintBar1.DockCol = 1
        Me.PrintBar1.DockRow = 0
        Me.PrintBar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.PrintBar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.PrintPreviewItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.PrintItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.PrintPageSetupItem1)})
        '
        'PrintPreviewItem1
        '
        Me.PrintPreviewItem1.Id = 43
        Me.PrintPreviewItem1.Name = "PrintPreviewItem1"
        '
        'PrintItem1
        '
        Me.PrintItem1.Id = 44
        Me.PrintItem1.Name = "PrintItem1"
        '
        'PrintPageSetupItem1
        '
        Me.PrintPageSetupItem1.Id = 45
        Me.PrintPageSetupItem1.Name = "PrintPageSetupItem1"
        '
        'AppointmentBar1
        '
        Me.AppointmentBar1.Control = Me.SchedulerControl1
        Me.AppointmentBar1.DockCol = 2
        Me.AppointmentBar1.DockRow = 0
        Me.AppointmentBar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.AppointmentBar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.NewAppointmentItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.NewRecurringAppointmentItem1)})
        '
        'NewAppointmentItem1
        '
        Me.NewAppointmentItem1.Id = 46
        Me.NewAppointmentItem1.Name = "NewAppointmentItem1"
        '
        'NewRecurringAppointmentItem1
        '
        Me.NewRecurringAppointmentItem1.Id = 47
        Me.NewRecurringAppointmentItem1.Name = "NewRecurringAppointmentItem1"
        '
        'NavigatorBar1
        '
        Me.NavigatorBar1.Control = Me.SchedulerControl1
        Me.NavigatorBar1.DockCol = 3
        Me.NavigatorBar1.DockRow = 0
        Me.NavigatorBar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.NavigatorBar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.NavigateViewBackwardItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.NavigateViewForwardItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.GotoTodayItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.ViewZoomInItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.ViewZoomOutItem1)})
        '
        'NavigateViewBackwardItem1
        '
        Me.NavigateViewBackwardItem1.Id = 48
        Me.NavigateViewBackwardItem1.Name = "NavigateViewBackwardItem1"
        '
        'NavigateViewForwardItem1
        '
        Me.NavigateViewForwardItem1.Id = 49
        Me.NavigateViewForwardItem1.Name = "NavigateViewForwardItem1"
        '
        'GotoTodayItem1
        '
        Me.GotoTodayItem1.Id = 50
        Me.GotoTodayItem1.Name = "GotoTodayItem1"
        '
        'ViewZoomInItem1
        '
        Me.ViewZoomInItem1.Id = 51
        Me.ViewZoomInItem1.Name = "ViewZoomInItem1"
        '
        'ViewZoomOutItem1
        '
        Me.ViewZoomOutItem1.Id = 52
        Me.ViewZoomOutItem1.Name = "ViewZoomOutItem1"
        '
        'ArrangeBar1
        '
        Me.ArrangeBar1.Control = Me.SchedulerControl1
        Me.ArrangeBar1.DockCol = 4
        Me.ArrangeBar1.DockRow = 0
        Me.ArrangeBar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.ArrangeBar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.SwitchToDayViewItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.SwitchToWorkWeekViewItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.SwitchToWeekViewItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.SwitchToFullWeekViewItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.SwitchToMonthViewItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.SwitchToTimelineViewItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.SwitchToGanttViewItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.SwitchToAgendaViewItem1)})
        '
        'SwitchToDayViewItem1
        '
        Me.SwitchToDayViewItem1.Id = 53
        Me.SwitchToDayViewItem1.Name = "SwitchToDayViewItem1"
        '
        'SwitchToWorkWeekViewItem1
        '
        Me.SwitchToWorkWeekViewItem1.Id = 54
        Me.SwitchToWorkWeekViewItem1.Name = "SwitchToWorkWeekViewItem1"
        '
        'SwitchToWeekViewItem1
        '
        Me.SwitchToWeekViewItem1.Id = 55
        Me.SwitchToWeekViewItem1.Name = "SwitchToWeekViewItem1"
        '
        'SwitchToFullWeekViewItem1
        '
        Me.SwitchToFullWeekViewItem1.Id = 56
        Me.SwitchToFullWeekViewItem1.Name = "SwitchToFullWeekViewItem1"
        '
        'SwitchToMonthViewItem1
        '
        Me.SwitchToMonthViewItem1.Id = 57
        Me.SwitchToMonthViewItem1.Name = "SwitchToMonthViewItem1"
        '
        'SwitchToTimelineViewItem1
        '
        Me.SwitchToTimelineViewItem1.Id = 58
        Me.SwitchToTimelineViewItem1.Name = "SwitchToTimelineViewItem1"
        '
        'SwitchToGanttViewItem1
        '
        Me.SwitchToGanttViewItem1.Id = 59
        Me.SwitchToGanttViewItem1.Name = "SwitchToGanttViewItem1"
        '
        'SwitchToAgendaViewItem1
        '
        Me.SwitchToAgendaViewItem1.Id = 60
        Me.SwitchToAgendaViewItem1.Name = "SwitchToAgendaViewItem1"
        '
        'GroupByBar1
        '
        Me.GroupByBar1.Control = Me.SchedulerControl1
        Me.GroupByBar1.DockCol = 5
        Me.GroupByBar1.DockRow = 0
        Me.GroupByBar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.GroupByBar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.GroupByNoneItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.GroupByDateItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.GroupByResourceItem1), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.Width, Me.BarEditItem1, "", False, True, True, 152), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.Width, Me.Ο, "", False, True, True, 68), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.Width, Me.BarEditItem2, "", False, True, True, 193), New DevExpress.XtraBars.LinkPersistInfo(Me.Ανανέωση), New DevExpress.XtraBars.LinkPersistInfo(Me.BarNewRec)})
        '
        'GroupByNoneItem1
        '
        Me.GroupByNoneItem1.Id = 61
        Me.GroupByNoneItem1.Name = "GroupByNoneItem1"
        '
        'GroupByDateItem1
        '
        Me.GroupByDateItem1.Id = 62
        Me.GroupByDateItem1.Name = "GroupByDateItem1"
        '
        'GroupByResourceItem1
        '
        Me.GroupByResourceItem1.Id = 63
        Me.GroupByResourceItem1.Name = "GroupByResourceItem1"
        '
        'BarEditItem1
        '
        Me.BarEditItem1.Caption = "Status"
        Me.BarEditItem1.Edit = Me.cboStatus
        Me.BarEditItem1.Hint = "Status"
        Me.BarEditItem1.Id = 64
        Me.BarEditItem1.Name = "BarEditItem1"
        Me.BarEditItem1.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.Caption
        '
        'cboStatus
        '
        Me.cboStatus.AllowMultiSelect = True
        Me.cboStatus.AutoHeight = False
        Me.cboStatus.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboStatus.DisplayMember = "name"
        Me.cboStatus.Name = "cboStatus"
        '
        'Ο
        '
        Me.Ο.Caption = "Ολοκληρώθηκε"
        Me.Ο.Edit = Me.cboCompleted
        Me.Ο.Hint = "Ολοκληρωμένες Ειδοποιήσεις"
        Me.Ο.Id = 67
        Me.Ο.Name = "Ο"
        Me.Ο.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.Caption
        '
        'cboCompleted
        '
        Me.cboCompleted.AllowMultiSelect = True
        Me.cboCompleted.AutoHeight = False
        Me.cboCompleted.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboCompleted.Name = "cboCompleted"
        '
        'BarEditItem2
        '
        Me.BarEditItem2.Caption = "Πελάτης"
        Me.BarEditItem2.Edit = Me.txtSearch
        Me.BarEditItem2.Hint = "Αναζήτηση Πελάτη"
        Me.BarEditItem2.Id = 69
        Me.BarEditItem2.Name = "BarEditItem2"
        Me.BarEditItem2.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        '
        'txtSearch
        '
        Me.txtSearch.AutoHeight = False
        Me.txtSearch.Name = "txtSearch"
        '
        'Ανανέωση
        '
        Me.Ανανέωση.Hint = "Ανανέωση Εγγραφών"
        Me.Ανανέωση.Id = 65
        Me.Ανανέωση.ImageOptions.Image = Global.DreamyKitchenCRM.My.Resources.Resources.icons8_refresh_16
        Me.Ανανέωση.Name = "Ανανέωση"
        '
        'BarNewRec
        '
        Me.BarNewRec.Hint = "Νέα Κίνηση"
        Me.BarNewRec.Id = 66
        Me.BarNewRec.ImageOptions.Image = Global.DreamyKitchenCRM.My.Resources.Resources.AddFile_16x16
        Me.BarNewRec.Name = "BarNewRec"
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Manager = Me.BarManager1
        Me.barDockControlTop.Size = New System.Drawing.Size(1495, 24)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 712)
        Me.barDockControlBottom.Manager = Me.BarManager1
        Me.barDockControlBottom.Size = New System.Drawing.Size(1495, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 24)
        Me.barDockControlLeft.Manager = Me.BarManager1
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 688)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(1495, 24)
        Me.barDockControlRight.Manager = Me.BarManager1
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 688)
        '
        'BarHeaderItem1
        '
        Me.BarHeaderItem1.Caption = "BarHeaderItem1"
        Me.BarHeaderItem1.Id = 68
        Me.BarHeaderItem1.Name = "BarHeaderItem1"
        '
        'DreamyKitchenAdapter
        '
        Me.DreamyKitchenAdapter.ClearBeforeFill = True
        '
        'SchedulerBarController1
        '
        Me.SchedulerBarController1.BarItems.Add(Me.OpenScheduleItem1)
        Me.SchedulerBarController1.BarItems.Add(Me.SaveScheduleItem1)
        Me.SchedulerBarController1.BarItems.Add(Me.PrintPreviewItem1)
        Me.SchedulerBarController1.BarItems.Add(Me.PrintItem1)
        Me.SchedulerBarController1.BarItems.Add(Me.PrintPageSetupItem1)
        Me.SchedulerBarController1.BarItems.Add(Me.NewAppointmentItem1)
        Me.SchedulerBarController1.BarItems.Add(Me.NewRecurringAppointmentItem1)
        Me.SchedulerBarController1.BarItems.Add(Me.NavigateViewBackwardItem1)
        Me.SchedulerBarController1.BarItems.Add(Me.NavigateViewForwardItem1)
        Me.SchedulerBarController1.BarItems.Add(Me.GotoTodayItem1)
        Me.SchedulerBarController1.BarItems.Add(Me.ViewZoomInItem1)
        Me.SchedulerBarController1.BarItems.Add(Me.ViewZoomOutItem1)
        Me.SchedulerBarController1.BarItems.Add(Me.SwitchToDayViewItem1)
        Me.SchedulerBarController1.BarItems.Add(Me.SwitchToWorkWeekViewItem1)
        Me.SchedulerBarController1.BarItems.Add(Me.SwitchToWeekViewItem1)
        Me.SchedulerBarController1.BarItems.Add(Me.SwitchToFullWeekViewItem1)
        Me.SchedulerBarController1.BarItems.Add(Me.SwitchToMonthViewItem1)
        Me.SchedulerBarController1.BarItems.Add(Me.SwitchToTimelineViewItem1)
        Me.SchedulerBarController1.BarItems.Add(Me.SwitchToGanttViewItem1)
        Me.SchedulerBarController1.BarItems.Add(Me.SwitchToAgendaViewItem1)
        Me.SchedulerBarController1.BarItems.Add(Me.GroupByNoneItem1)
        Me.SchedulerBarController1.BarItems.Add(Me.GroupByDateItem1)
        Me.SchedulerBarController1.BarItems.Add(Me.GroupByResourceItem1)
        Me.SchedulerBarController1.Control = Me.SchedulerControl1
        '
        'frmCalendar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1495, 712)
        Me.Controls.Add(Me.SchedulerControl1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.IconOptions.Image = Global.DreamyKitchenCRM.My.Resources.Resources.favicon
        Me.Name = "frmCalendar"
        Me.Text = "frmCalendar"
        CType(Me.SchedulerControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SchedulerDataStorage1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VwSALERSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DreamyKitchenDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboStatus, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboCompleted, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSearch, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SchedulerBarController1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub


    Friend WithEvents SchedulerControl1 As DevExpress.XtraScheduler.SchedulerControl
    Friend WithEvents SchedulerDataStorage1 As DevExpress.XtraScheduler.SchedulerDataStorage
    Friend WithEvents DreamyKitchenDataSet As DreamyKitchenDataSet
    Friend WithEvents VwSALERSBindingSource As BindingSource
    Friend WithEvents DreamyKitchenAdapter As DreamyKitchenDataSetTableAdapters.vw_SALERSTableAdapter
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents CommonBar1 As DevExpress.XtraScheduler.UI.CommonBar
    Friend WithEvents OpenScheduleItem1 As DevExpress.XtraScheduler.UI.OpenScheduleItem
    Friend WithEvents SaveScheduleItem1 As DevExpress.XtraScheduler.UI.SaveScheduleItem
    Friend WithEvents PrintBar1 As DevExpress.XtraScheduler.UI.PrintBar
    Friend WithEvents PrintPreviewItem1 As DevExpress.XtraScheduler.UI.PrintPreviewItem
    Friend WithEvents PrintItem1 As DevExpress.XtraScheduler.UI.PrintItem
    Friend WithEvents PrintPageSetupItem1 As DevExpress.XtraScheduler.UI.PrintPageSetupItem
    Friend WithEvents AppointmentBar1 As DevExpress.XtraScheduler.UI.AppointmentBar
    Friend WithEvents NewAppointmentItem1 As DevExpress.XtraScheduler.UI.NewAppointmentItem
    Friend WithEvents NewRecurringAppointmentItem1 As DevExpress.XtraScheduler.UI.NewRecurringAppointmentItem
    Friend WithEvents NavigatorBar1 As DevExpress.XtraScheduler.UI.NavigatorBar
    Friend WithEvents NavigateViewBackwardItem1 As DevExpress.XtraScheduler.UI.NavigateViewBackwardItem
    Friend WithEvents NavigateViewForwardItem1 As DevExpress.XtraScheduler.UI.NavigateViewForwardItem
    Friend WithEvents GotoTodayItem1 As DevExpress.XtraScheduler.UI.GotoTodayItem
    Friend WithEvents ViewZoomInItem1 As DevExpress.XtraScheduler.UI.ViewZoomInItem
    Friend WithEvents ViewZoomOutItem1 As DevExpress.XtraScheduler.UI.ViewZoomOutItem
    Friend WithEvents ArrangeBar1 As DevExpress.XtraScheduler.UI.ArrangeBar
    Friend WithEvents SwitchToDayViewItem1 As DevExpress.XtraScheduler.UI.SwitchToDayViewItem
    Friend WithEvents SwitchToWorkWeekViewItem1 As DevExpress.XtraScheduler.UI.SwitchToWorkWeekViewItem
    Friend WithEvents SwitchToWeekViewItem1 As DevExpress.XtraScheduler.UI.SwitchToWeekViewItem
    Friend WithEvents SwitchToFullWeekViewItem1 As DevExpress.XtraScheduler.UI.SwitchToFullWeekViewItem
    Friend WithEvents SwitchToMonthViewItem1 As DevExpress.XtraScheduler.UI.SwitchToMonthViewItem
    Friend WithEvents SwitchToTimelineViewItem1 As DevExpress.XtraScheduler.UI.SwitchToTimelineViewItem
    Friend WithEvents SwitchToGanttViewItem1 As DevExpress.XtraScheduler.UI.SwitchToGanttViewItem
    Friend WithEvents SwitchToAgendaViewItem1 As DevExpress.XtraScheduler.UI.SwitchToAgendaViewItem
    Friend WithEvents GroupByBar1 As DevExpress.XtraScheduler.UI.GroupByBar
    Friend WithEvents GroupByNoneItem1 As DevExpress.XtraScheduler.UI.GroupByNoneItem
    Friend WithEvents GroupByDateItem1 As DevExpress.XtraScheduler.UI.GroupByDateItem
    Friend WithEvents GroupByResourceItem1 As DevExpress.XtraScheduler.UI.GroupByResourceItem
    Friend WithEvents SchedulerBarController1 As DevExpress.XtraScheduler.UI.SchedulerBarController
    Friend WithEvents BarEditItem1 As DevExpress.XtraBars.BarEditItem
    Friend WithEvents cboStatus As DevExpress.XtraEditors.Repository.RepositoryItemCheckedComboBoxEdit
    Friend WithEvents Ανανέωση As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarNewRec As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents Ο As DevExpress.XtraBars.BarEditItem
    Friend WithEvents cboCompleted As DevExpress.XtraEditors.Repository.RepositoryItemCheckedComboBoxEdit
    Friend WithEvents BarEditItem2 As DevExpress.XtraBars.BarEditItem
    Friend WithEvents txtSearch As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents BarHeaderItem1 As DevExpress.XtraBars.BarHeaderItem
End Class
