<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCalendarInst
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim TimeRuler1 As DevExpress.XtraScheduler.TimeRuler = New DevExpress.XtraScheduler.TimeRuler()
        Dim TimeRuler2 As DevExpress.XtraScheduler.TimeRuler = New DevExpress.XtraScheduler.TimeRuler()
        Dim TimeRuler3 As DevExpress.XtraScheduler.TimeRuler = New DevExpress.XtraScheduler.TimeRuler()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCalendarInst))
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colcode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colcusID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsalersID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colserID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coldtDeliverDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colGRMONTH = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colcmt = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colmodifiedBy = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colmodifiedOn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colcreatedOn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colcreatedBy = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colcctName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSalerName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRealName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSerName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colcolor = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colcompleted = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.VwINSTBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DreamyKitchenDataSet = New DreamyKitchenCRM.DreamyKitchenDataSet()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.CommonBar1 = New DevExpress.XtraScheduler.UI.CommonBar()
        Me.SchedulerControl1 = New DevExpress.XtraScheduler.SchedulerControl()
        Me.SchedulerDataStorage1 = New DevExpress.XtraScheduler.SchedulerDataStorage(Me.components)
        Me.VwSERBindingSource = New System.Windows.Forms.BindingSource(Me.components)
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
        Me.cboCalendars = New DevExpress.XtraEditors.Repository.RepositoryItemCheckedComboBoxEdit()
        Me.Ο = New DevExpress.XtraBars.BarEditItem()
        Me.cboCompleted = New DevExpress.XtraEditors.Repository.RepositoryItemCheckedComboBoxEdit()
        Me.BarEditItem3 = New DevExpress.XtraBars.BarEditItem()
        Me.txtSearch2 = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.BBrefresh = New DevExpress.XtraBars.BarButtonItem()
        Me.BarNewRec = New DevExpress.XtraBars.BarButtonItem()
        Me.BBEllipse = New DevExpress.XtraBars.BarButtonItem()
        Me.BarDockControl1 = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.BarHeaderItem1 = New DevExpress.XtraBars.BarHeaderItem()
        Me.cboStatus = New DevExpress.XtraEditors.Repository.RepositoryItemCheckedComboBoxEdit()
        Me.txtSearch = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.VwCCTMBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VwSALERSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.cmdExit = New DevExpress.XtraEditors.SimpleButton()
        Me.PanelResults = New DevExpress.XtraEditors.PanelControl()
        Me.Vw_CCT_MTableAdapter = New DreamyKitchenCRM.DreamyKitchenDataSetTableAdapters.vw_CCT_MTableAdapter()
        Me.SchedulerBarController1 = New DevExpress.XtraScheduler.UI.SchedulerBarController(Me.components)
        Me.DreamyKitchenAdapter = New DreamyKitchenCRM.DreamyKitchenDataSetTableAdapters.vw_SALERSTableAdapter()
        Me.Vw_SERTableAdapter = New DreamyKitchenCRM.DreamyKitchenDataSetTableAdapters.vw_SERTableAdapter()
        Me.Vw_INSTTableAdapter = New DreamyKitchenCRM.DreamyKitchenDataSetTableAdapters.vw_INSTTableAdapter()
        Me.SvgImageCollection1 = New DevExpress.Utils.SvgImageCollection(Me.components)
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VwINSTBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DreamyKitchenDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SchedulerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SchedulerDataStorage1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VwSERBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboCalendars, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboCompleted, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSearch2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboStatus, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSearch, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VwCCTMBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VwSALERSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelResults, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelResults.SuspendLayout()
        CType(Me.SchedulerBarController1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SvgImageCollection1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 40)
        Me.barDockControlTop.Manager = Nothing
        Me.barDockControlTop.Margin = New System.Windows.Forms.Padding(6)
        Me.barDockControlTop.Size = New System.Drawing.Size(2860, 0)
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colID, Me.colcode, Me.colcusID, Me.colsalersID, Me.colserID, Me.coldtDeliverDate, Me.colGRMONTH, Me.colcmt, Me.colmodifiedBy, Me.colmodifiedOn, Me.colcreatedOn, Me.colcreatedBy, Me.colcctName, Me.colSalerName, Me.colRealName, Me.colSerName, Me.colcolor, Me.colcompleted})
        Me.GridView1.DetailHeight = 646
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsBehavior.ReadOnly = True
        Me.GridView1.OptionsMenu.ShowConditionalFormattingItem = True
        '
        'colID
        '
        Me.colID.FieldName = "ID"
        Me.colID.MinWidth = 37
        Me.colID.Name = "colID"
        Me.colID.Width = 137
        '
        'colcode
        '
        Me.colcode.FieldName = "code"
        Me.colcode.MinWidth = 37
        Me.colcode.Name = "colcode"
        Me.colcode.Width = 137
        '
        'colcusID
        '
        Me.colcusID.FieldName = "cusID"
        Me.colcusID.MinWidth = 37
        Me.colcusID.Name = "colcusID"
        Me.colcusID.Width = 137
        '
        'colsalersID
        '
        Me.colsalersID.FieldName = "salersID"
        Me.colsalersID.MinWidth = 37
        Me.colsalersID.Name = "colsalersID"
        Me.colsalersID.Width = 137
        '
        'colserID
        '
        Me.colserID.FieldName = "serID"
        Me.colserID.MinWidth = 37
        Me.colserID.Name = "colserID"
        Me.colserID.Width = 137
        '
        'coldtDeliverDate
        '
        Me.coldtDeliverDate.Caption = "ΗΜΕΡΟΜΗΝΙΑ"
        Me.coldtDeliverDate.FieldName = "dtDeliverDate"
        Me.coldtDeliverDate.MinWidth = 37
        Me.coldtDeliverDate.Name = "coldtDeliverDate"
        Me.coldtDeliverDate.Visible = True
        Me.coldtDeliverDate.VisibleIndex = 5
        Me.coldtDeliverDate.Width = 137
        '
        'colGRMONTH
        '
        Me.colGRMONTH.Caption = "ΜΗΝΑΣ"
        Me.colGRMONTH.FieldName = "GRMONTH"
        Me.colGRMONTH.MinWidth = 37
        Me.colGRMONTH.Name = "colGRMONTH"
        Me.colGRMONTH.Visible = True
        Me.colGRMONTH.VisibleIndex = 4
        Me.colGRMONTH.Width = 137
        '
        'colcmt
        '
        Me.colcmt.Caption = "ΣΧΟΛΙΑ"
        Me.colcmt.FieldName = "cmt"
        Me.colcmt.MinWidth = 37
        Me.colcmt.Name = "colcmt"
        Me.colcmt.Visible = True
        Me.colcmt.VisibleIndex = 3
        Me.colcmt.Width = 137
        '
        'colmodifiedBy
        '
        Me.colmodifiedBy.FieldName = "modifiedBy"
        Me.colmodifiedBy.MinWidth = 37
        Me.colmodifiedBy.Name = "colmodifiedBy"
        Me.colmodifiedBy.Width = 137
        '
        'colmodifiedOn
        '
        Me.colmodifiedOn.FieldName = "modifiedOn"
        Me.colmodifiedOn.MinWidth = 37
        Me.colmodifiedOn.Name = "colmodifiedOn"
        Me.colmodifiedOn.Width = 137
        '
        'colcreatedOn
        '
        Me.colcreatedOn.FieldName = "createdOn"
        Me.colcreatedOn.MinWidth = 37
        Me.colcreatedOn.Name = "colcreatedOn"
        Me.colcreatedOn.Width = 137
        '
        'colcreatedBy
        '
        Me.colcreatedBy.FieldName = "createdBy"
        Me.colcreatedBy.MinWidth = 37
        Me.colcreatedBy.Name = "colcreatedBy"
        Me.colcreatedBy.Width = 137
        '
        'colcctName
        '
        Me.colcctName.Caption = "ΠΕΛΑΤΗΣ"
        Me.colcctName.FieldName = "cctName"
        Me.colcctName.MinWidth = 37
        Me.colcctName.Name = "colcctName"
        Me.colcctName.Visible = True
        Me.colcctName.VisibleIndex = 1
        Me.colcctName.Width = 137
        '
        'colSalerName
        '
        Me.colSalerName.Caption = "ΠΩΛΗΤΗΣ"
        Me.colSalerName.FieldName = "SalerName"
        Me.colSalerName.MinWidth = 37
        Me.colSalerName.Name = "colSalerName"
        Me.colSalerName.Visible = True
        Me.colSalerName.VisibleIndex = 2
        Me.colSalerName.Width = 137
        '
        'colRealName
        '
        Me.colRealName.FieldName = "RealName"
        Me.colRealName.MinWidth = 37
        Me.colRealName.Name = "colRealName"
        Me.colRealName.Width = 137
        '
        'colSerName
        '
        Me.colSerName.Caption = "ΣΥΝΕΡΓΕΙΟ"
        Me.colSerName.FieldName = "SerName"
        Me.colSerName.MinWidth = 37
        Me.colSerName.Name = "colSerName"
        Me.colSerName.Visible = True
        Me.colSerName.VisibleIndex = 0
        Me.colSerName.Width = 137
        '
        'colcolor
        '
        Me.colcolor.FieldName = "color"
        Me.colcolor.MinWidth = 37
        Me.colcolor.Name = "colcolor"
        Me.colcolor.Width = 137
        '
        'colcompleted
        '
        Me.colcompleted.Caption = "ΟΛΟΚΛΗΡΩΘΗΚΕ"
        Me.colcompleted.FieldName = "completed"
        Me.colcompleted.MinWidth = 37
        Me.colcompleted.Name = "colcompleted"
        Me.colcompleted.Visible = True
        Me.colcompleted.VisibleIndex = 6
        Me.colcompleted.Width = 137
        '
        'GridControl1
        '
        Me.GridControl1.DataSource = Me.VwINSTBindingSource
        Me.GridControl1.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(6)
        Me.GridControl1.Location = New System.Drawing.Point(9, 6)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Margin = New System.Windows.Forms.Padding(6)
        Me.GridControl1.MenuManager = Me.BarManager1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(1725, 724)
        Me.GridControl1.TabIndex = 7
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'VwINSTBindingSource
        '
        Me.VwINSTBindingSource.DataMember = "vw_INST"
        Me.VwINSTBindingSource.DataSource = Me.DreamyKitchenDataSet
        '
        'DreamyKitchenDataSet
        '
        Me.DreamyKitchenDataSet.DataSetName = "DreamyKitchenDataSet"
        Me.DreamyKitchenDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.CommonBar1, Me.PrintBar1, Me.AppointmentBar1, Me.NavigatorBar1, Me.ArrangeBar1, Me.GroupByBar1})
        Me.BarManager1.DockControls.Add(Me.BarDockControl1)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.OpenScheduleItem1, Me.SaveScheduleItem1, Me.PrintPreviewItem1, Me.PrintItem1, Me.PrintPageSetupItem1, Me.NewAppointmentItem1, Me.NewRecurringAppointmentItem1, Me.NavigateViewBackwardItem1, Me.NavigateViewForwardItem1, Me.GotoTodayItem1, Me.ViewZoomInItem1, Me.ViewZoomOutItem1, Me.SwitchToDayViewItem1, Me.SwitchToWorkWeekViewItem1, Me.SwitchToWeekViewItem1, Me.SwitchToFullWeekViewItem1, Me.SwitchToMonthViewItem1, Me.SwitchToTimelineViewItem1, Me.SwitchToGanttViewItem1, Me.SwitchToAgendaViewItem1, Me.GroupByNoneItem1, Me.GroupByDateItem1, Me.GroupByResourceItem1, Me.BBrefresh, Me.BarNewRec, Me.Ο, Me.BarHeaderItem1, Me.BarEditItem3, Me.BBEllipse, Me.BarEditItem1})
        Me.BarManager1.MaxItemId = 73
        Me.BarManager1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.cboStatus, Me.cboCompleted, Me.txtSearch, Me.txtSearch2, Me.cboCalendars})
        '
        'CommonBar1
        '
        Me.CommonBar1.Control = Me.SchedulerControl1
        Me.CommonBar1.DockCol = 0
        Me.CommonBar1.DockRow = 0
        Me.CommonBar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.CommonBar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.OpenScheduleItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.SaveScheduleItem1)})
        '
        'SchedulerControl1
        '
        Me.SchedulerControl1.ActiveViewType = DevExpress.XtraScheduler.SchedulerViewType.Month
        Me.SchedulerControl1.DataStorage = Me.SchedulerDataStorage1
        Me.SchedulerControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SchedulerControl1.Location = New System.Drawing.Point(0, 40)
        Me.SchedulerControl1.Margin = New System.Windows.Forms.Padding(6)
        Me.SchedulerControl1.MenuManager = Me.BarManager1
        Me.SchedulerControl1.Name = "SchedulerControl1"
        Me.SchedulerControl1.Size = New System.Drawing.Size(2860, 1262)
        Me.SchedulerControl1.Start = New Date(2020, 10, 5, 0, 0, 0, 0)
        Me.SchedulerControl1.TabIndex = 11
        Me.SchedulerControl1.Text = "SchedulerControl1"
        Me.SchedulerControl1.Views.DayView.TimeRulers.Add(TimeRuler1)
        Me.SchedulerControl1.Views.FullWeekView.Enabled = True
        Me.SchedulerControl1.Views.FullWeekView.TimeRulers.Add(TimeRuler2)
        Me.SchedulerControl1.Views.MonthView.AppointmentDisplayOptions.AppointmentAutoHeight = True
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
        Me.SchedulerDataStorage1.Labels.DataSource = Me.VwSERBindingSource
        Me.SchedulerDataStorage1.Labels.Mappings.Color = "color"
        Me.SchedulerDataStorage1.Labels.Mappings.DisplayName = "Fullname"
        Me.SchedulerDataStorage1.Labels.Mappings.Id = "code"
        Me.SchedulerDataStorage1.Labels.Mappings.MenuCaption = "Fullname"
        '
        '
        '
        Me.SchedulerDataStorage1.Resources.CustomFieldMappings.Add(New DevExpress.XtraScheduler.ResourceCustomFieldMapping("SALERSName", "SALERS_Name"))
        Me.SchedulerDataStorage1.Resources.Mappings.Caption = "STATUS_Name"
        Me.SchedulerDataStorage1.Resources.Mappings.Color = "color"
        Me.SchedulerDataStorage1.Resources.Mappings.Id = "ID"
        '
        'VwSERBindingSource
        '
        Me.VwSERBindingSource.DataMember = "vw_SER"
        Me.VwSERBindingSource.DataSource = Me.DreamyKitchenDataSet
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
        Me.GroupByBar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.GroupByNoneItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.GroupByDateItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.GroupByResourceItem1), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.Width, Me.BarEditItem1, "", False, True, True, 183), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.Width, Me.Ο, "", False, True, True, 68), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.Width, Me.BarEditItem3, "", False, True, True, 157), New DevExpress.XtraBars.LinkPersistInfo(Me.BBrefresh), New DevExpress.XtraBars.LinkPersistInfo(Me.BarNewRec), New DevExpress.XtraBars.LinkPersistInfo(Me.BBEllipse)})
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
        Me.BarEditItem1.Caption = "Ημερολόγια"
        Me.BarEditItem1.Edit = Me.cboCalendars
        Me.BarEditItem1.Hint = "Ημερολόγια"
        Me.BarEditItem1.Id = 72
        Me.BarEditItem1.Name = "BarEditItem1"
        Me.BarEditItem1.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.Caption
        '
        'cboCalendars
        '
        Me.cboCalendars.AllowMultiSelect = True
        Me.cboCalendars.AutoHeight = False
        Me.cboCalendars.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboCalendars.Items.AddRange(New DevExpress.XtraEditors.Controls.CheckedListBoxItem() {New DevExpress.XtraEditors.Controls.CheckedListBoxItem("0", "Τοποθετήσεις"), New DevExpress.XtraEditors.Controls.CheckedListBoxItem("1", "Εκκρεμότητες"), New DevExpress.XtraEditors.Controls.CheckedListBoxItem("2", "Παραδόσεις"), New DevExpress.XtraEditors.Controls.CheckedListBoxItem("3", "Εργασίες")})
        Me.cboCalendars.Name = "cboCalendars"
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
        'BBrefresh
        '
        Me.BBrefresh.Hint = "Ανανέωση Εγγραφών"
        Me.BBrefresh.Id = 65
        Me.BBrefresh.ImageOptions.Image = Global.DreamyKitchenCRM.My.Resources.Resources.icons8_refresh_16
        Me.BBrefresh.Name = "BBrefresh"
        '
        'BarNewRec
        '
        Me.BarNewRec.Hint = "Νέα Κίνηση"
        Me.BarNewRec.Id = 66
        Me.BarNewRec.ImageOptions.Image = Global.DreamyKitchenCRM.My.Resources.Resources.AddFile_16x16
        Me.BarNewRec.Name = "BarNewRec"
        '
        'BBEllipse
        '
        Me.BBEllipse.Caption = "Εκκρεμότητες"
        Me.BBEllipse.Id = 71
        Me.BBEllipse.ImageOptions.Image = Global.DreamyKitchenCRM.My.Resources.Resources.icons8_bank_card_missing_16
        Me.BBEllipse.Name = "BBEllipse"
        '
        'BarDockControl1
        '
        Me.BarDockControl1.CausesValidation = False
        Me.BarDockControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.BarDockControl1.Location = New System.Drawing.Point(0, 0)
        Me.BarDockControl1.Manager = Me.BarManager1
        Me.BarDockControl1.Margin = New System.Windows.Forms.Padding(6)
        Me.BarDockControl1.Size = New System.Drawing.Size(2860, 40)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 1302)
        Me.barDockControlBottom.Manager = Me.BarManager1
        Me.barDockControlBottom.Margin = New System.Windows.Forms.Padding(6)
        Me.barDockControlBottom.Size = New System.Drawing.Size(2860, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 40)
        Me.barDockControlLeft.Manager = Me.BarManager1
        Me.barDockControlLeft.Margin = New System.Windows.Forms.Padding(6)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 1262)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(2860, 40)
        Me.barDockControlRight.Manager = Me.BarManager1
        Me.barDockControlRight.Margin = New System.Windows.Forms.Padding(6)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 1262)
        '
        'BarHeaderItem1
        '
        Me.BarHeaderItem1.Caption = "BarHeaderItem1"
        Me.BarHeaderItem1.Id = 68
        Me.BarHeaderItem1.Name = "BarHeaderItem1"
        '
        'cboStatus
        '
        Me.cboStatus.AllowMultiSelect = True
        Me.cboStatus.AutoHeight = False
        Me.cboStatus.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboStatus.DisplayMember = "name"
        Me.cboStatus.Name = "cboStatus"
        '
        'txtSearch
        '
        Me.txtSearch.AutoHeight = False
        Me.txtSearch.Name = "txtSearch"
        '
        'VwCCTMBindingSource
        '
        Me.VwCCTMBindingSource.DataMember = "vw_CCT_M"
        Me.VwCCTMBindingSource.DataSource = Me.DreamyKitchenDataSet
        '
        'VwSALERSBindingSource
        '
        Me.VwSALERSBindingSource.DataMember = "vw_SALERS"
        Me.VwSALERSBindingSource.DataSource = Me.DreamyKitchenDataSet
        '
        'cmdExit
        '
        Me.cmdExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdExit.ImageOptions.Image = Global.DreamyKitchenCRM.My.Resources.Resources.icons8_exit_24
        Me.cmdExit.Location = New System.Drawing.Point(1571, 740)
        Me.cmdExit.Margin = New System.Windows.Forms.Padding(6)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(163, 52)
        Me.cmdExit.TabIndex = 13
        Me.cmdExit.Text = "Έξοδος"
        '
        'PanelResults
        '
        Me.PanelResults.Controls.Add(Me.cmdExit)
        Me.PanelResults.Controls.Add(Me.GridControl1)
        Me.PanelResults.Location = New System.Drawing.Point(691, 161)
        Me.PanelResults.Margin = New System.Windows.Forms.Padding(6)
        Me.PanelResults.Name = "PanelResults"
        Me.PanelResults.Size = New System.Drawing.Size(1744, 809)
        Me.PanelResults.TabIndex = 12
        '
        'Vw_CCT_MTableAdapter
        '
        Me.Vw_CCT_MTableAdapter.ClearBeforeFill = True
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
        'DreamyKitchenAdapter
        '
        Me.DreamyKitchenAdapter.ClearBeforeFill = True
        '
        'Vw_SERTableAdapter
        '
        Me.Vw_SERTableAdapter.ClearBeforeFill = True
        '
        'Vw_INSTTableAdapter
        '
        Me.Vw_INSTTableAdapter.ClearBeforeFill = True
        '
        'SvgImageCollection1
        '
        Me.SvgImageCollection1.Add("shipment", "image://svgimages/outlook inspired/shipment.svg")
        Me.SvgImageCollection1.Add("actions_settings", "image://svgimages/icon builder/actions_settings.svg")
        Me.SvgImageCollection1.Add("switchtimescalesto", "image://svgimages/scheduling/switchtimescalesto.svg")
        Me.SvgImageCollection1.Add("bo_project", "image://svgimages/business objects/bo_project.svg")
        '
        'frmCalendarInst
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(2860, 1302)
        Me.Controls.Add(Me.PanelResults)
        Me.Controls.Add(Me.SchedulerControl1)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.BarDockControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.Name = "frmCalendarInst"
        Me.Text = "frmCalendarInst"
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VwINSTBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DreamyKitchenDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SchedulerControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SchedulerDataStorage1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VwSERBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboCalendars, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboCompleted, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSearch2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboStatus, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSearch, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VwCCTMBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VwSALERSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelResults, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelResults.ResumeLayout(False)
        CType(Me.SchedulerBarController1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SvgImageCollection1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents VwCCTMBindingSource As BindingSource
    Friend WithEvents DreamyKitchenDataSet As DreamyKitchenDataSet
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents CommonBar1 As DevExpress.XtraScheduler.UI.CommonBar
    Friend WithEvents SchedulerControl1 As DevExpress.XtraScheduler.SchedulerControl
    Friend WithEvents SchedulerDataStorage1 As DevExpress.XtraScheduler.SchedulerDataStorage
    Friend WithEvents VwSALERSBindingSource As BindingSource
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
    Friend WithEvents cboStatus As DevExpress.XtraEditors.Repository.RepositoryItemCheckedComboBoxEdit
    Friend WithEvents Ο As DevExpress.XtraBars.BarEditItem
    Friend WithEvents cboCompleted As DevExpress.XtraEditors.Repository.RepositoryItemCheckedComboBoxEdit
    Friend WithEvents BarEditItem3 As DevExpress.XtraBars.BarEditItem
    Friend WithEvents txtSearch2 As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents BBrefresh As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarNewRec As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarDockControl1 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents PanelResults As DevExpress.XtraEditors.PanelControl
    Friend WithEvents cmdExit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BarHeaderItem1 As DevExpress.XtraBars.BarHeaderItem
    Friend WithEvents txtSearch As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents Vw_CCT_MTableAdapter As DreamyKitchenDataSetTableAdapters.vw_CCT_MTableAdapter
    Friend WithEvents SchedulerBarController1 As DevExpress.XtraScheduler.UI.SchedulerBarController
    Friend WithEvents DreamyKitchenAdapter As DreamyKitchenDataSetTableAdapters.vw_SALERSTableAdapter
    Friend WithEvents VwSERBindingSource As BindingSource
    Friend WithEvents Vw_SERTableAdapter As DreamyKitchenDataSetTableAdapters.vw_SERTableAdapter
    Friend WithEvents VwINSTBindingSource As BindingSource
    Friend WithEvents Vw_INSTTableAdapter As DreamyKitchenDataSetTableAdapters.vw_INSTTableAdapter
    Friend WithEvents colID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colcode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colcusID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsalersID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colserID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldtDeliverDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colGRMONTH As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colcmt As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colmodifiedBy As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colmodifiedOn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colcreatedOn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colcreatedBy As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colcctName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSalerName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRealName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSerName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colcolor As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colcompleted As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SvgImageCollection1 As DevExpress.Utils.SvgImageCollection
    Friend WithEvents BBEllipse As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarEditItem1 As DevExpress.XtraBars.BarEditItem
    Friend WithEvents cboCalendars As DevExpress.XtraEditors.Repository.RepositoryItemCheckedComboBoxEdit
End Class
