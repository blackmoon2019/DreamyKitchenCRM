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
        Me.VwSALERSANDCOUNTERSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
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
        Me.BarEditItem3 = New DevExpress.XtraBars.BarEditItem()
        Me.txtSearch2 = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.Ανανέωση = New DevExpress.XtraBars.BarButtonItem()
        Me.BarNewRec = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.BarHeaderItem1 = New DevExpress.XtraBars.BarHeaderItem()
        Me.txtSearch = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.VwSALERSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DreamyKitchenAdapter = New DreamyKitchenCRM.DreamyKitchenDataSetTableAdapters.vw_SALERSTableAdapter()
        Me.SchedulerBarController1 = New DevExpress.XtraScheduler.UI.SchedulerBarController(Me.components)
        Me.VwCCTMBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Vw_CCT_MTableAdapter = New DreamyKitchenCRM.DreamyKitchenDataSetTableAdapters.vw_CCT_MTableAdapter()
        Me.PanelResults = New DevExpress.XtraEditors.PanelControl()
        Me.cmdExit = New DevExpress.XtraEditors.SimpleButton()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFullname = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colmob = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colemail = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colcct_cmt = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colcode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSTATUS_Name = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colallowschedule = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSALERS_Name = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colcolor = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colADR_Name = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAr = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coltk = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRealName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAREAS_Name = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colstatusID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colcusID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsch = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colcompleted = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coldtcompleted = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colcmt = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colcreatedOn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colmodifiedOn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsalersID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSALERS_Code = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coldtReminderDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colREM_VALUES_name = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colremValueID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colReminder = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colS_CCT_M_Code = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colS_CCT_M_Color = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colS_CCT_M_name = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coltmReminder = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coldtReceiveDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coldtDeliverDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCusSaler = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colcreatedby_Realname = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colphn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Vw_SALERS_AND_COUNTERSTableAdapter = New DreamyKitchenCRM.DreamyKitchenDataSetTableAdapters.vw_SALERS_AND_COUNTERSTableAdapter()
        Me.TableAdapterManager = New DreamyKitchenCRM.DreamyKitchenDataSetTableAdapters.TableAdapterManager()
        CType(Me.SchedulerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SchedulerDataStorage1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VwSALERSANDCOUNTERSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DreamyKitchenDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboStatus, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboCompleted, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSearch2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSearch, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VwSALERSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SchedulerBarController1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VwCCTMBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelResults, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelResults.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SchedulerControl1
        '
        Me.SchedulerControl1.DataStorage = Me.SchedulerDataStorage1
        Me.SchedulerControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SchedulerControl1.Location = New System.Drawing.Point(0, 40)
        Me.SchedulerControl1.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.SchedulerControl1.MenuManager = Me.BarManager1
        Me.SchedulerControl1.Name = "SchedulerControl1"
        Me.SchedulerControl1.OptionsRangeControl.RangeMaximum = New Date(2021, 12, 1, 0, 0, 0, 0)
        Me.SchedulerControl1.OptionsRangeControl.RangeMinimum = New Date(2021, 9, 1, 0, 0, 0, 0)
        Me.SchedulerControl1.Size = New System.Drawing.Size(2623, 1220)
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
        Me.SchedulerDataStorage1.Labels.DataSource = Me.VwSALERSANDCOUNTERSBindingSource
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
        'VwSALERSANDCOUNTERSBindingSource
        '
        Me.VwSALERSANDCOUNTERSBindingSource.DataMember = "vw_SALERS_AND_COUNTERS"
        Me.VwSALERSANDCOUNTERSBindingSource.DataSource = Me.DreamyKitchenDataSet
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
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.OpenScheduleItem1, Me.SaveScheduleItem1, Me.PrintPreviewItem1, Me.PrintItem1, Me.PrintPageSetupItem1, Me.NewAppointmentItem1, Me.NewRecurringAppointmentItem1, Me.NavigateViewBackwardItem1, Me.NavigateViewForwardItem1, Me.GotoTodayItem1, Me.ViewZoomInItem1, Me.ViewZoomOutItem1, Me.SwitchToDayViewItem1, Me.SwitchToWorkWeekViewItem1, Me.SwitchToWeekViewItem1, Me.SwitchToFullWeekViewItem1, Me.SwitchToMonthViewItem1, Me.SwitchToTimelineViewItem1, Me.SwitchToGanttViewItem1, Me.SwitchToAgendaViewItem1, Me.GroupByNoneItem1, Me.GroupByDateItem1, Me.GroupByResourceItem1, Me.BarEditItem1, Me.Ανανέωση, Me.BarNewRec, Me.Ο, Me.BarHeaderItem1, Me.BarEditItem3})
        Me.BarManager1.MaxItemId = 71
        Me.BarManager1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.cboStatus, Me.cboCompleted, Me.txtSearch, Me.txtSearch2})
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
        Me.GroupByBar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.GroupByNoneItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.GroupByDateItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.GroupByResourceItem1), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.Width, Me.BarEditItem1, "", False, True, True, 152), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.Width, Me.Ο, "", False, True, True, 68), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.Width, Me.BarEditItem3, "", False, True, True, 157), New DevExpress.XtraBars.LinkPersistInfo(Me.Ανανέωση), New DevExpress.XtraBars.LinkPersistInfo(Me.BarNewRec)})
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
        'BarEditItem3
        '
        Me.BarEditItem3.Caption = "Πελάτης"
        Me.BarEditItem3.Edit = Me.txtSearch2
        Me.BarEditItem3.Hint = "Αναζήτηση Πελάτη"
        Me.BarEditItem3.Id = 70
        Me.BarEditItem3.Name = "BarEditItem3"
        Me.BarEditItem3.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        '
        'txtSearch2
        '
        Me.txtSearch2.AutoHeight = False
        Me.txtSearch2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Search)})
        Me.txtSearch2.Name = "txtSearch2"
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
        Me.barDockControlTop.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.barDockControlTop.Size = New System.Drawing.Size(2623, 40)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 1260)
        Me.barDockControlBottom.Manager = Me.BarManager1
        Me.barDockControlBottom.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.barDockControlBottom.Size = New System.Drawing.Size(2623, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 40)
        Me.barDockControlLeft.Manager = Me.BarManager1
        Me.barDockControlLeft.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 1220)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(2623, 40)
        Me.barDockControlRight.Manager = Me.BarManager1
        Me.barDockControlRight.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 1220)
        '
        'BarHeaderItem1
        '
        Me.BarHeaderItem1.Caption = "BarHeaderItem1"
        Me.BarHeaderItem1.Id = 68
        Me.BarHeaderItem1.Name = "BarHeaderItem1"
        '
        'txtSearch
        '
        Me.txtSearch.AutoHeight = False
        Me.txtSearch.Name = "txtSearch"
        '
        'VwSALERSBindingSource
        '
        Me.VwSALERSBindingSource.DataMember = "vw_SALERS"
        Me.VwSALERSBindingSource.DataSource = Me.DreamyKitchenDataSet
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
        'VwCCTMBindingSource
        '
        Me.VwCCTMBindingSource.DataMember = "vw_CCT_M"
        Me.VwCCTMBindingSource.DataSource = Me.DreamyKitchenDataSet
        '
        'Vw_CCT_MTableAdapter
        '
        Me.Vw_CCT_MTableAdapter.ClearBeforeFill = True
        '
        'PanelResults
        '
        Me.PanelResults.Controls.Add(Me.cmdExit)
        Me.PanelResults.Controls.Add(Me.GridControl1)
        Me.PanelResults.Location = New System.Drawing.Point(628, 175)
        Me.PanelResults.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.PanelResults.Name = "PanelResults"
        Me.PanelResults.Size = New System.Drawing.Size(1585, 775)
        Me.PanelResults.TabIndex = 10
        '
        'cmdExit
        '
        Me.cmdExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdExit.ImageOptions.Image = Global.DreamyKitchenCRM.My.Resources.Resources.icons8_exit_24
        Me.cmdExit.Location = New System.Drawing.Point(1428, 709)
        Me.cmdExit.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(148, 50)
        Me.cmdExit.TabIndex = 13
        Me.cmdExit.Text = "Έξοδος"
        '
        'GridControl1
        '
        Me.GridControl1.DataSource = Me.VwCCTMBindingSource
        Me.GridControl1.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.GridControl1.Location = New System.Drawing.Point(8, 5)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.GridControl1.MenuManager = Me.BarManager1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(1568, 694)
        Me.GridControl1.TabIndex = 7
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colID, Me.colFullname, Me.colmob, Me.colemail, Me.colcct_cmt, Me.colcode, Me.colSTATUS_Name, Me.colallowschedule, Me.colSALERS_Name, Me.colcolor, Me.colADR_Name, Me.colAr, Me.coltk, Me.colRealName, Me.colAREAS_Name, Me.colstatusID, Me.colcusID, Me.colsch, Me.colcompleted, Me.coldtcompleted, Me.colcmt, Me.colcreatedOn, Me.colmodifiedOn, Me.colsalersID, Me.colSALERS_Code, Me.coldtReminderDate, Me.colREM_VALUES_name, Me.colremValueID, Me.colReminder, Me.colS_CCT_M_Code, Me.colS_CCT_M_Color, Me.colS_CCT_M_name, Me.coltmReminder, Me.coldtReceiveDate, Me.coldtDeliverDate, Me.colCusSaler, Me.colcreatedby_Realname, Me.colphn})
        Me.GridView1.DetailHeight = 619
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsBehavior.ReadOnly = True
        '
        'colID
        '
        Me.colID.FieldName = "ID"
        Me.colID.MinWidth = 33
        Me.colID.Name = "colID"
        Me.colID.Width = 125
        '
        'colFullname
        '
        Me.colFullname.Caption = "ΠΕΛΑΤΗΣ"
        Me.colFullname.FieldName = "Fullname"
        Me.colFullname.MinWidth = 33
        Me.colFullname.Name = "colFullname"
        Me.colFullname.Visible = True
        Me.colFullname.VisibleIndex = 2
        Me.colFullname.Width = 125
        '
        'colmob
        '
        Me.colmob.Caption = "ΚΙΝΗΤΟ"
        Me.colmob.FieldName = "mob"
        Me.colmob.MinWidth = 33
        Me.colmob.Name = "colmob"
        Me.colmob.Width = 125
        '
        'colemail
        '
        Me.colemail.Caption = "EMAIL"
        Me.colemail.FieldName = "email"
        Me.colemail.MinWidth = 33
        Me.colemail.Name = "colemail"
        Me.colemail.Width = 125
        '
        'colcct_cmt
        '
        Me.colcct_cmt.FieldName = "cct_cmt"
        Me.colcct_cmt.MinWidth = 33
        Me.colcct_cmt.Name = "colcct_cmt"
        Me.colcct_cmt.Width = 125
        '
        'colcode
        '
        Me.colcode.FieldName = "code"
        Me.colcode.MinWidth = 33
        Me.colcode.Name = "colcode"
        Me.colcode.Width = 125
        '
        'colSTATUS_Name
        '
        Me.colSTATUS_Name.Caption = "STATUS"
        Me.colSTATUS_Name.FieldName = "STATUS_Name"
        Me.colSTATUS_Name.MinWidth = 33
        Me.colSTATUS_Name.Name = "colSTATUS_Name"
        Me.colSTATUS_Name.Visible = True
        Me.colSTATUS_Name.VisibleIndex = 0
        Me.colSTATUS_Name.Width = 125
        '
        'colallowschedule
        '
        Me.colallowschedule.FieldName = "allowschedule"
        Me.colallowschedule.MinWidth = 33
        Me.colallowschedule.Name = "colallowschedule"
        Me.colallowschedule.Width = 125
        '
        'colSALERS_Name
        '
        Me.colSALERS_Name.FieldName = "SALERS_Name"
        Me.colSALERS_Name.MinWidth = 33
        Me.colSALERS_Name.Name = "colSALERS_Name"
        Me.colSALERS_Name.Width = 125
        '
        'colcolor
        '
        Me.colcolor.FieldName = "color"
        Me.colcolor.MinWidth = 33
        Me.colcolor.Name = "colcolor"
        Me.colcolor.Width = 125
        '
        'colADR_Name
        '
        Me.colADR_Name.FieldName = "ADR_Name"
        Me.colADR_Name.MinWidth = 33
        Me.colADR_Name.Name = "colADR_Name"
        Me.colADR_Name.Width = 125
        '
        'colAr
        '
        Me.colAr.FieldName = "Ar"
        Me.colAr.MinWidth = 33
        Me.colAr.Name = "colAr"
        Me.colAr.Width = 125
        '
        'coltk
        '
        Me.coltk.FieldName = "tk"
        Me.coltk.MinWidth = 33
        Me.coltk.Name = "coltk"
        Me.coltk.Width = 125
        '
        'colRealName
        '
        Me.colRealName.FieldName = "RealName"
        Me.colRealName.MinWidth = 33
        Me.colRealName.Name = "colRealName"
        Me.colRealName.Width = 125
        '
        'colAREAS_Name
        '
        Me.colAREAS_Name.FieldName = "AREAS_Name"
        Me.colAREAS_Name.MinWidth = 33
        Me.colAREAS_Name.Name = "colAREAS_Name"
        Me.colAREAS_Name.Width = 125
        '
        'colstatusID
        '
        Me.colstatusID.FieldName = "statusID"
        Me.colstatusID.MinWidth = 33
        Me.colstatusID.Name = "colstatusID"
        Me.colstatusID.Width = 125
        '
        'colcusID
        '
        Me.colcusID.FieldName = "cusID"
        Me.colcusID.MinWidth = 33
        Me.colcusID.Name = "colcusID"
        Me.colcusID.Width = 125
        '
        'colsch
        '
        Me.colsch.FieldName = "sch"
        Me.colsch.MinWidth = 33
        Me.colsch.Name = "colsch"
        Me.colsch.Width = 125
        '
        'colcompleted
        '
        Me.colcompleted.FieldName = "completed"
        Me.colcompleted.MinWidth = 33
        Me.colcompleted.Name = "colcompleted"
        Me.colcompleted.Width = 125
        '
        'coldtcompleted
        '
        Me.coldtcompleted.FieldName = "dtcompleted"
        Me.coldtcompleted.MinWidth = 33
        Me.coldtcompleted.Name = "coldtcompleted"
        Me.coldtcompleted.Width = 125
        '
        'colcmt
        '
        Me.colcmt.FieldName = "cmt"
        Me.colcmt.MinWidth = 33
        Me.colcmt.Name = "colcmt"
        Me.colcmt.Width = 125
        '
        'colcreatedOn
        '
        Me.colcreatedOn.FieldName = "createdOn"
        Me.colcreatedOn.MinWidth = 33
        Me.colcreatedOn.Name = "colcreatedOn"
        Me.colcreatedOn.Width = 125
        '
        'colmodifiedOn
        '
        Me.colmodifiedOn.FieldName = "modifiedOn"
        Me.colmodifiedOn.MinWidth = 33
        Me.colmodifiedOn.Name = "colmodifiedOn"
        Me.colmodifiedOn.Width = 125
        '
        'colsalersID
        '
        Me.colsalersID.FieldName = "salersID"
        Me.colsalersID.MinWidth = 33
        Me.colsalersID.Name = "colsalersID"
        Me.colsalersID.Width = 125
        '
        'colSALERS_Code
        '
        Me.colSALERS_Code.FieldName = "SALERS_Code"
        Me.colSALERS_Code.MinWidth = 33
        Me.colSALERS_Code.Name = "colSALERS_Code"
        Me.colSALERS_Code.Width = 125
        '
        'coldtReminderDate
        '
        Me.coldtReminderDate.Caption = "ΗΜΕΡΟΜΗΝΙΑ ΕΙΔΟΠΟΙΗΣΗΣ"
        Me.coldtReminderDate.FieldName = "dtReminderDate"
        Me.coldtReminderDate.MinWidth = 33
        Me.coldtReminderDate.Name = "coldtReminderDate"
        Me.coldtReminderDate.Visible = True
        Me.coldtReminderDate.VisibleIndex = 3
        Me.coldtReminderDate.Width = 125
        '
        'colREM_VALUES_name
        '
        Me.colREM_VALUES_name.FieldName = "REM_VALUES_name"
        Me.colREM_VALUES_name.MinWidth = 33
        Me.colREM_VALUES_name.Name = "colREM_VALUES_name"
        Me.colREM_VALUES_name.Width = 125
        '
        'colremValueID
        '
        Me.colremValueID.FieldName = "remValueID"
        Me.colremValueID.MinWidth = 33
        Me.colremValueID.Name = "colremValueID"
        Me.colremValueID.Width = 125
        '
        'colReminder
        '
        Me.colReminder.FieldName = "Reminder"
        Me.colReminder.MinWidth = 33
        Me.colReminder.Name = "colReminder"
        Me.colReminder.Width = 125
        '
        'colS_CCT_M_Code
        '
        Me.colS_CCT_M_Code.FieldName = "S_CCT_M_Code"
        Me.colS_CCT_M_Code.MinWidth = 33
        Me.colS_CCT_M_Code.Name = "colS_CCT_M_Code"
        Me.colS_CCT_M_Code.Width = 125
        '
        'colS_CCT_M_Color
        '
        Me.colS_CCT_M_Color.Caption = "ΧΡΩΜΑ"
        Me.colS_CCT_M_Color.FieldName = "S_CCT_M_Color"
        Me.colS_CCT_M_Color.MinWidth = 33
        Me.colS_CCT_M_Color.Name = "colS_CCT_M_Color"
        Me.colS_CCT_M_Color.Width = 125
        '
        'colS_CCT_M_name
        '
        Me.colS_CCT_M_name.Caption = "ΠΩΛΗΤΗΣ"
        Me.colS_CCT_M_name.FieldName = "S_CCT_M_name"
        Me.colS_CCT_M_name.MinWidth = 33
        Me.colS_CCT_M_name.Name = "colS_CCT_M_name"
        Me.colS_CCT_M_name.Visible = True
        Me.colS_CCT_M_name.VisibleIndex = 1
        Me.colS_CCT_M_name.Width = 125
        '
        'coltmReminder
        '
        Me.coltmReminder.FieldName = "tmReminder"
        Me.coltmReminder.MinWidth = 33
        Me.coltmReminder.Name = "coltmReminder"
        Me.coltmReminder.Width = 125
        '
        'coldtReceiveDate
        '
        Me.coldtReceiveDate.FieldName = "dtReceiveDate"
        Me.coldtReceiveDate.MinWidth = 33
        Me.coldtReceiveDate.Name = "coldtReceiveDate"
        Me.coldtReceiveDate.Width = 125
        '
        'coldtDeliverDate
        '
        Me.coldtDeliverDate.FieldName = "dtDeliverDate"
        Me.coldtDeliverDate.MinWidth = 33
        Me.coldtDeliverDate.Name = "coldtDeliverDate"
        Me.coldtDeliverDate.Width = 125
        '
        'colCusSaler
        '
        Me.colCusSaler.FieldName = "CusSaler"
        Me.colCusSaler.MinWidth = 33
        Me.colCusSaler.Name = "colCusSaler"
        Me.colCusSaler.Width = 125
        '
        'colcreatedby_Realname
        '
        Me.colcreatedby_Realname.FieldName = "createdby_Realname"
        Me.colcreatedby_Realname.MinWidth = 33
        Me.colcreatedby_Realname.Name = "colcreatedby_Realname"
        Me.colcreatedby_Realname.Width = 125
        '
        'colphn
        '
        Me.colphn.Caption = "ΤΗΛΕΦΩΝΟ"
        Me.colphn.FieldName = "phn"
        Me.colphn.MinWidth = 33
        Me.colphn.Name = "colphn"
        Me.colphn.Visible = True
        Me.colphn.VisibleIndex = 4
        Me.colphn.Width = 125
        '
        'Vw_SALERS_AND_COUNTERSTableAdapter
        '
        Me.Vw_SALERS_AND_COUNTERSTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.UpdateOrder = DreamyKitchenCRM.DreamyKitchenDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'frmCalendar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 23.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(2623, 1260)
        Me.Controls.Add(Me.PanelResults)
        Me.Controls.Add(Me.SchedulerControl1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.IconOptions.Image = Global.DreamyKitchenCRM.My.Resources.Resources.favicon
        Me.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.Name = "frmCalendar"
        Me.Text = "frmCalendar"
        CType(Me.SchedulerControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SchedulerDataStorage1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VwSALERSANDCOUNTERSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DreamyKitchenDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboStatus, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboCompleted, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSearch2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSearch, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VwSALERSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SchedulerBarController1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VwCCTMBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelResults, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelResults.ResumeLayout(False)
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents txtSearch As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents BarHeaderItem1 As DevExpress.XtraBars.BarHeaderItem
    Friend WithEvents VwCCTMBindingSource As BindingSource
    Friend WithEvents Vw_CCT_MTableAdapter As DreamyKitchenDataSetTableAdapters.vw_CCT_MTableAdapter
    Friend WithEvents PanelResults As DevExpress.XtraEditors.PanelControl
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFullname As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colmob As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colemail As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colcct_cmt As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colcode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSTATUS_Name As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colallowschedule As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSALERS_Name As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colcolor As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colADR_Name As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAr As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coltk As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRealName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAREAS_Name As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colstatusID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colcusID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsch As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colcompleted As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldtcompleted As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colcmt As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colcreatedOn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colmodifiedOn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsalersID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSALERS_Code As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldtReminderDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colREM_VALUES_name As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colremValueID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colReminder As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colS_CCT_M_Code As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colS_CCT_M_Color As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colS_CCT_M_name As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coltmReminder As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldtReceiveDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldtDeliverDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCusSaler As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colcreatedby_Realname As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colphn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cmdExit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BarEditItem3 As DevExpress.XtraBars.BarEditItem
    Friend WithEvents txtSearch2 As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents VwSALERSANDCOUNTERSBindingSource As BindingSource
    Friend WithEvents Vw_SALERS_AND_COUNTERSTableAdapter As DreamyKitchenDataSetTableAdapters.vw_SALERS_AND_COUNTERSTableAdapter
    Friend WithEvents TableAdapterManager As DreamyKitchenDataSetTableAdapters.TableAdapterManager
End Class
