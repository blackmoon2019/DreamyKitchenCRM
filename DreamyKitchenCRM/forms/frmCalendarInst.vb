﻿Imports System.ComponentModel
Imports System.Data.SqlClient
Imports System.Text
Imports DevExpress.PivotGrid.QueryMode
Imports DevExpress.Utils
Imports DevExpress.Utils.Menu
Imports DevExpress.XtraBars
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Menu
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraScheduler
Imports DevExpress.XtraScheduler.Commands
Imports DevExpress.XtraScheduler.Drawing
Imports DevExpress.XtraScheduler.Localization
Imports DevExpress.XtraScheduler.Services

Public Class frmCalendarInst
    Private Calendar As New InitializeCalendar
    Private LoadForms As New FormLoader
    Private Sub frmCalendarInst_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DreamyKitchenDataSet.vw_SER' table. You can move, or remove it, as needed.
        Me.Vw_SERTableAdapter.Fill(Me.DreamyKitchenDataSet.vw_SER)

        Try
            Dim sSQL As String
            PanelResults.Visible = False
            SchedulerLocalizer.Active = New MySchedulerLocalizer()
            'sSQL = "SELECT *,vw_INST_ELLIPSE.ID as EllipseID FROM vw_INST " &
            '        "left join vw_INST_ELLIPSE on vw_INST.ID = vw_INST_ELLIPSE.instID And vw_INST_ELLIPSE.completed=0 and comeFrom = 0  order by vw_INST.code"
            sSQL = "Select * FROM(
                select '0' as CalendarType,NULL AS EllipseID ,dtDeliverDate,cctName,vw_INST.ID,color,SerName,tmIN,tmOUT,vw_INST.cmt,vw_INST.code,SerCode,vw_INST.completed,SalerName  from vw_INST where dtDeliverDate  is NOT null 
                union
                Select '1' as CalendarType,IE.ID AS EllipseID ,DateDelivered,cctName,vw_INST.ID,IE.color,IE.SerName,tmINFrom,tmINTo,vw_INST.cmt,vw_INST.code,IE.SerCode,IE.completed,IE.SalerName from vw_INST INNER JOIN vw_INST_ELLIPSE IE ON IE.instID = vw_INST.ID  where comefrom=0 and IE.DateDelivered IS NOT NULL
                union
                Select '2' as CalendarType,NULL AS EllipseID ,dtParadosis,cctName,vw_INST.ID,color,SerName,tmIN,tmOUT,vw_INST.cmt,vw_INST.code,SerCode,vw_INST.completed,SalerName  from vw_INST  where   dtParadosis IS NOT NULL
                union
                Select '3' as CalendarType,NULL AS EllipseID , visitDate,cctName,ID,color,SerName,visitTimeF,visitTimeT,cmt,code,SerCode,completed,EmpFullName FROM VW_PROJECT_JOBS) AS Calendars "
            'Δημιουργία Appointments
            Calendar.InitializeInst(SchedulerControl1, SchedulerDataStorage1, sSQL, True)
            'TODO: This line of code loads data into the 'DreamyKitchenDataSet.vw_INST' table. You can move, or remove it, as needed.
            Me.Vw_INSTTableAdapter.Fill(Me.DreamyKitchenDataSet.vw_INST, "")
            cboCompleted.Items.Add("Όχι", True)
            cboCompleted.Items(0).Tag = 0
            cboCompleted.Items(0).CheckState = CheckState.Checked
            cboCompleted.Items.Add("Ναι", True)
            cboCompleted.Items(1).Tag = 1
            cboCompleted.Items(1).CheckState = CheckState.Unchecked

            'Κεντράρισμα Panel
            PanelResults.Parent = frmMain
            PanelResults.Left = (PanelResults.Parent.Width - PanelResults.Width) / 2
            PanelResults.Top = (PanelResults.Parent.Height - PanelResults.Height) / 2

            Me.DreamyKitchenAdapter.Fill(Me.DreamyKitchenDataSet.vw_SALERS)
            SchedulerControl1.Start = Now.Date

            LoadForms.RestoreLayoutFromXml(GridView1, "Inst.xml")
        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), "Dreamy Kitchen CRM", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub BarNewRec_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BarNewRec.ItemClick
        Dim form1 As frmInstallations = New frmInstallations()
        form1.Text = "Τοποθετήσεις"
        'form1.MdiParent = frmMain
        form1.Mode = FormMode.NewRecord
        form1.dtDeliverDate.EditValue = SchedulerControl1.SelectedInterval.Start
        'frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(form1), New Point(CInt(form1.Parent.ClientRectangle.Width / 2 - form1.Width / 2), CInt(form1.Parent.ClientRectangle.Height / 2 - form1.Height / 2)))
        form1.ShowDialog()
        SetCalendarFilter()
    End Sub
    Private Sub cmdExit_Click(sender As Object, e As EventArgs) Handles cmdExit.Click
        PanelResults.Visible = False
    End Sub
    Private Sub SchedulerControl1_MouseMove(sender As Object, e As MouseEventArgs) Handles SchedulerControl1.MouseMove
        Dim scheduler As DevExpress.XtraScheduler.SchedulerControl = sender

        Dim pos As Point = New Point(e.X, e.Y)
        Dim viewInfo As SchedulerViewInfoBase
        Dim hitInfo As SchedulerHitInfo
        viewInfo = SchedulerControl1.ActiveView.ViewInfo
        hitInfo = viewInfo.CalcHitInfo(pos, False)

        If (hitInfo.HitTest = SchedulerHitTest.AppointmentContent) Then
            scheduler.Cursor = Cursors.Hand
        Else
            scheduler.Cursor = Cursors.Default
        End If
    End Sub
    Private Sub SchedulerControl1_DoubleClick(sender As Object, e As EventArgs) Handles SchedulerControl1.DoubleClick

        Dim form1 As frmInstallations = New frmInstallations()
        form1.Text = "Τοποθετήσεις"
        form1.Scroller = frmScroller.GridView1
        form1.FormScroller = frmScroller
        Dim apt As Appointment
        If SchedulerControl1.SelectedAppointments.Count = 0 Then
            form1.Mode = FormMode.NewRecord
            form1.dtDeliverDate.EditValue = SchedulerControl1.SelectedInterval.Start
        Else
            For i As Integer = 0 To SchedulerControl1.SelectedAppointments.Count - 1
                apt = SchedulerControl1.SelectedAppointments(i)
                form1.ID = apt.Id
                form1.Mode = FormMode.EditRecord
            Next i
        End If
        If apt IsNot Nothing Then
            If apt.CustomFields.Item("IsInst") = True Or apt.CustomFields.Item("IsDelivery") = True Then
                form1.ShowDialog()
                Exit Sub
            End If
            If apt.CustomFields.Item("IsEllipse") = True Then
                Dim frmInstEllipse As frmInstEllipse = New frmInstEllipse()
                frmInstEllipse.ID = apt.CustomFields.Item("EllipseID").ToString
                frmInstEllipse.INST_ID = apt.Id
                frmInstEllipse.Text = "Εκκρεμότητες Έργων"
                frmInstEllipse.Mode = FormMode.EditRecord
                frmInstEllipse.CalledFromControl = False
                frmInstEllipse.ShowDialog()
                form1.Dispose()
                form1 = Nothing
            End If
            If apt.CustomFields.Item("IsProjectJob") = True Then
                Dim frmProjectJobs As frmProjectJobs = New frmProjectJobs()
                frmProjectJobs.ID = apt.CustomFields.Item("ProjectJobID").ToString
                frmProjectJobs.Text = "Εργασίες"
                frmProjectJobs.Mode = FormMode.EditRecord
                frmProjectJobs.CalledFromControl = False
                frmProjectJobs.ShowDialog()
                form1.Dispose()
                form1 = Nothing
            End If
        Else
            form1.ShowDialog()
        End If
        'SetCalendarFilter()
    End Sub
    Private Sub SetCalendarFilter(Optional ByVal sWhere As String = "")
        Dim sSQL As String
        Dim sIDS As New StringBuilder
        Dim sCalendars As New StringBuilder
        SchedulerDataStorage1.Appointments.Clear()
        For i As Integer = 0 To cboCalendars.Items.Count - 1
            If cboCalendars.Items(i).CheckState = CheckState.Checked Then
                If sCalendars.Length > 0 Then sCalendars.Append(",")
                sCalendars.Append(toSQLValueS(cboCalendars.Items(i).Value.ToString))
            End If
        Next

        'sSQL = "SELECT *,vw_INST_ELLIPSE.ID as EllipseID FROM vw_INST left join vw_INST_ELLIPSE on vw_INST.ID = vw_INST_ELLIPSE.instID and vw_INST_ELLIPSE.completed=0  and comeFrom = 0 order by vw_INST.code"

        sSQL = "Select * FROM(
                select '0' as CalendarType,NULL AS EllipseID ,dtDeliverDate,cctName,vw_INST.ID,color,SerName,tmIN,tmOUT,vw_INST.cmt,vw_INST.code,SerCode,vw_INST.completed,SalerName  from vw_INST where dtDeliverDate  is NOT null 
                union
                Select '1' as CalendarType,IE.ID AS EllipseID ,DateDelivered,cctName,vw_INST.ID,IE.color,IE.SerName,tmINFrom,tmINTo,vw_INST.cmt,vw_INST.code,IE.SerCode,IE.completed,IE.SalerName from vw_INST INNER JOIN vw_INST_ELLIPSE IE ON IE.instID = vw_INST.ID  where comefrom=0 and IE.DateDelivered IS NOT NULL
                union
                Select '2' as CalendarType,NULL AS EllipseID ,dtParadosis,cctName,vw_INST.ID,color,SerName,tmIN,tmOUT,vw_INST.cmt,vw_INST.code,SerCode,vw_INST.completed,SalerName  from vw_INST  where   dtParadosis IS NOT NULL
                union
                Select '3' as CalendarType,NULL AS EllipseID , visitDate,cctName,ID,color,SerName,visitTimeF,visitTimeT,cmt,code,SerCode,completed,EmpFullName FROM VW_PROJECT_JOBS) AS Calendars "



        If sWhere.Length > 0 Then sSQL = sSQL & " where Calendars.cctName like " & toSQLValueS("%" & sWhere & "%")
        For i As Integer = 0 To cboCompleted.Items.Count - 1
            If cboCompleted.Items(i).CheckState = CheckState.Checked Then
                If sIDS.Length > 0 Then sIDS.Append(",")
                sIDS.Append(toSQLValueS(cboCompleted.Items(i).Tag.ToString))
            End If
        Next
        If sIDS.Length > 0 And sWhere.Length > 0 Then
            sSQL = sSQL + " and Calendars.completed in (" & sIDS.ToString & ")"
        ElseIf sIDS.Length > 0 Then
            sSQL = sSQL + " where Calendars.completed in (" & sIDS.ToString & ")"
        End If
        If sCalendars.Length > 0 And (sWhere.Length > 0 Or sIDS.Length > 0) Then
            sSQL = sSQL + " and Calendars.CalendarType in (" & sCalendars.ToString & ")"
        ElseIf sCalendars.Length > 0 Then
            sSQL = sSQL + " where Calendars.CalendarType in (" & sCalendars.ToString & ")"
        End If

        Calendar.InitializeInst(SchedulerControl1, SchedulerDataStorage1, sSQL, False)
        SchedulerControl1.Start = Now.Date
    End Sub
    Private Sub OkButton_Click(ByVal sender As Object, ByVal e As EventArgs)
        SetCalendarFilter()
    End Sub
    Private Sub BarRefresh_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BBrefresh.ItemClick
        SetCalendarFilter()
    End Sub
    Private Sub OkComletedButton_Click(ByVal sender As Object, ByVal e As EventArgs)
        SetCalendarFilter()
    End Sub
    Private Sub OkCalendarsButton_Click(ByVal sender As Object, ByVal e As EventArgs)
        SetCalendarFilter()
    End Sub

    Private Sub cboCompleted_Popup(sender As Object, e As EventArgs) Handles cboCompleted.Popup
        Dim edit = TryCast(sender, CheckedComboBoxEdit)
        Dim form = edit.GetPopupEditForm()
        RemoveHandler form.OkButton.Click, AddressOf OkComletedButton_Click
        AddHandler form.OkButton.Click, AddressOf OkComletedButton_Click
    End Sub
    Private Sub cboCalendars_Popup(sender As Object, e As EventArgs) Handles cboCalendars.Popup
        Dim edit = TryCast(sender, CheckedComboBoxEdit)
        Dim form = edit.GetPopupEditForm()
        RemoveHandler form.OkButton.Click, AddressOf OkCalendarsButton_Click
        AddHandler form.OkButton.Click, AddressOf OkCalendarsButton_Click
    End Sub
    Private Sub txtSearch2_EditValueChanged(sender As Object, e As EventArgs) Handles txtSearch2.EditValueChanged
        Dim value As Object = (TryCast(sender, TextEdit)).EditValue
        Dim teText As String = If(value Is Nothing, String.Empty, value.ToString())
        SetCalendarFilter(teText)
        Me.Vw_INSTTableAdapter.Fill(Me.DreamyKitchenDataSet.vw_INST, teText)
    End Sub
    Private Sub txtSearch2_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles txtSearch2.ButtonClick
        PanelResults.Visible = True
    End Sub
    Private Sub GridView1_DoubleClick(sender As Object, e As EventArgs) Handles GridView1.DoubleClick
        Dim form12 As frmInstallations = New frmInstallations()
        form12.Text = "Τοποθετήσεις"
        form12.ID = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "ID").ToString
        form12.MdiParent = frmMain
        form12.Mode = FormMode.EditRecord
        form12.Scroller = GridView1
        frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(form12), New Point(CInt(Me.Parent.ClientRectangle.Width / 2 - Me.Width / 2), CInt(Me.Parent.ClientRectangle.Height / 2 - Me.Height / 2)))
        form12.Show()
    End Sub

    Private Sub GridView1_PopupMenuShowing(sender As Object, e As DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs) Handles GridView1.PopupMenuShowing
        If e.MenuType = GridMenuType.Column Then
            Dim menu As DevExpress.XtraGrid.Menu.GridViewColumnMenu = TryCast(e.Menu, GridViewColumnMenu)
            Dim item As New DXEditMenuItem()
            Dim itemColor As New DXEditMenuItem()

            'menu.Items.Clear()
            If menu.Column IsNot Nothing Then
                'Για να προσθέσουμε menu item στο Default menu πρέπει πρώτα να προσθέσουμε ένα Repository Item 
                'Υπάρχουν πολλών ειδών Repositorys
                '1st Custom Menu Item
                Dim popRenameColumn As New RepositoryItemTextEdit
                popRenameColumn.Name = "RenameColumn"
                menu.Items.Add(New DXEditMenuItem("Μετονομασία Στήλης", popRenameColumn, AddressOf OnEditValueChanged, Nothing, Nothing, 100, 0))
                item = menu.Items.Item("Μετονομασία Στήλης")
                item.EditValue = menu.Column.GetTextCaption
                item.Tag = menu.Column.AbsoluteIndex

                '2nd Custom Menu Item
                menu.Items.Add(CreateCheckItem("Κλείδωμα Στήλης", menu.Column, Nothing))

                '3rd Custom Menu Item
                Dim popColorsColumn As New RepositoryItemColorEdit
                popColorsColumn.Name = "ColorsColumn"
                menu.Items.Add(New DXEditMenuItem("Χρώμα Στήλης", popColorsColumn, AddressOf OnColumnsColorChanged, Nothing, Nothing, 100, 0))
                itemColor = menu.Items.Item("Χρώμα Στήλης")
                itemColor.EditValue = menu.Column.AppearanceCell.BackColor
                itemColor.Tag = menu.Column.AbsoluteIndex

                '4nd Custom Menu Item
                menu.Items.Add(New DXMenuItem("Αποθήκευση όψης", AddressOf OnSaveView, Nothing, Nothing, Nothing, Nothing))

            End If
        End If
    End Sub
    Private Sub OnEditValueChanged(ByVal sender As System.Object, ByVal e As EventArgs)
        Dim item As New DXEditMenuItem()
        item = sender
        If item.Tag Is Nothing Then Exit Sub
        GridView1.Columns(item.Tag).Caption = item.EditValue
        'MessageBox.Show(item.EditValue.ToString())
    End Sub
    Private Function CreateCheckItem(ByVal caption As String, ByVal column As GridColumn, ByVal image As Image) As DXMenuCheckItem
        Dim item As New DXMenuCheckItem(caption, (Not column.OptionsColumn.AllowMove), image, New EventHandler(AddressOf OnCanMoveItemClick))
        item.Tag = New MenuColumnInfo(column)
        Return item
    End Function
    'Αλλαγή Χρώματος Στήλης Master
    Private Sub OnColumnsColorChanged(ByVal sender As System.Object, ByVal e As EventArgs)
        Dim item As DXEditMenuItem = TryCast(sender, DXEditMenuItem)
        item = sender
        If item.Tag Is Nothing Then Exit Sub
        GridView1.Columns(item.Tag).AppearanceCell.BackColor = item.EditValue
    End Sub
    'Κλείδωμα Στήλης Master
    Private Sub OnCanMoveItemClick(ByVal sender As Object, ByVal e As EventArgs)
        Dim item As DXMenuCheckItem = TryCast(sender, DXMenuCheckItem)
        Dim info As MenuColumnInfo = TryCast(item.Tag, MenuColumnInfo)
        If info Is Nothing Then
            Return
        End If
        info.Column.OptionsColumn.AllowMove = Not item.Checked
    End Sub
    'Αποθήκευση όψης 
    Private Sub OnSaveView(ByVal sender As System.Object, ByVal e As EventArgs)
        Dim item As DXMenuItem = TryCast(sender, DXMenuItem)
        GridView1.SaveLayoutToXml(Application.StartupPath & "\DSGNS\DEF\Inst.xml", OptionsLayoutBase.FullLayout)
        XtraMessageBox.Show("Η όψη αποθηκεύτηκε με επιτυχία", "Dreamy Kitchen CRM", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub SchedulerControl1_KeyDown(sender As Object, e As KeyEventArgs) Handles SchedulerControl1.KeyDown
        Dim sSQL As String
        If e.KeyCode = Keys.Delete Then
            For i As Integer = 0 To SchedulerControl1.SelectedAppointments.Count - 1

                Dim apt As Appointment = SchedulerControl1.SelectedAppointments(i)
                sSQL = "DELETE FROM inst WHERE ID = " & toSQLValueS(apt.Id)
                Using oCmd As New SqlCommand(sSQL, CNDB)
                    oCmd.ExecuteNonQuery()
                End Using
            Next i
            SetCalendarFilter()
        End If
    End Sub

    Private Sub SchedulerControl1_PopupMenuShowing(sender As Object, e As DevExpress.XtraScheduler.PopupMenuShowingEventArgs) Handles SchedulerControl1.PopupMenuShowing
        If e.Menu.Id = DevExpress.XtraScheduler.SchedulerMenuItemId.AppointmentMenu Then
            ' Hide the "Change View To" menu item.
            Dim itemChangeViewTo As SchedulerPopupMenu = e.Menu.GetPopupMenuById(SchedulerMenuItemId.LabelSubMenu)
            itemChangeViewTo.Visible = False

            ' Create a menu item for the Scheduler command.
            Dim service As ISchedulerCommandFactoryService = SchedulerControl1.GetService(Of ISchedulerCommandFactoryService)()
            Dim cmd As SchedulerCommand = service.CreateCommand(SchedulerCommandId.SwitchToGroupByResource)
            Dim menuItemCommandAdapter As New SchedulerMenuItemCommandWinAdapter(cmd)
            Dim menuItem As DXMenuItem = CType(menuItemCommandAdapter.CreateMenuItem(DXMenuItemPriority.Normal), DXMenuItem)
            menuItem.BeginGroup = True
            e.Menu.Items.Add(menuItem)

            ' Insert a new item into the Scheduler popup menu and handle its click event.
            e.Menu.Items.Add(New SchedulerMenuItem("Δημιουργία Εκκρεμότητας", AddressOf MyClickHandler))
        End If
    End Sub
    Public Sub MyClickHandler(ByVal sender As Object, ByVal e As EventArgs)
        For i As Integer = 0 To SchedulerControl1.SelectedAppointments.Count - 1
            Dim apt As Appointment = SchedulerControl1.SelectedAppointments(i)
            Dim frmInstEllipse As New frmInstEllipse
            frmInstEllipse.Text = "Εκκρεμότητες Έργων"
            frmInstEllipse.Mode = FormMode.NewRecord
            frmInstEllipse.INST_ID = apt.Id
            frmInstEllipse.CalledFromControl = False
            frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(frmInstEllipse), New Point(CInt(Me.Parent.ClientRectangle.Width / 2 - Me.Width / 2), CInt(Me.Parent.ClientRectangle.Height / 2 - Me.Height / 2)))
            frmInstEllipse.Show()
        Next i
    End Sub

    Private Sub SchedulerControl1_InitAppointmentImages(sender As Object, e As AppointmentImagesEventArgs) Handles SchedulerControl1.InitAppointmentImages

        Dim info As AppointmentImageInfo = New AppointmentImageInfo()
        If e.Appointment.CustomFields.Item("IsInst") = True Then info.Image = ImageCollection1.Images.Item(3)
        If e.Appointment.CustomFields.Item("IsEllipse") = True Then info.Image = ImageCollection1.Images.Item(0)
        If e.Appointment.CustomFields.Item("IsDelivery") = True Then info.Image = ImageCollection1.Images.Item(2)
        If e.Appointment.CustomFields.Item("IsProjectJob") = True Then info.Image = ImageCollection1.Images.Item(1)
        e.ImageInfoList.Add(info)
    End Sub
    Private Sub SchedulerControl1_InitAppointmentDisplayText(sender As Object, e As AppointmentDisplayTextEventArgs) Handles SchedulerControl1.InitAppointmentDisplayText
        'e.Text = e.Text & vbCrLf + "Σχόλια: " + e.Description
    End Sub
    Friend Class MenuColumnInfo
        Public Sub New(ByVal column As GridColumn)
            Me.Column = column
        End Sub
        Public Column As GridColumn
    End Class
    Public Class MySchedulerLocalizer
        Inherits SchedulerLocalizer
        Public Overrides Function GetLocalizedString(ByVal id As SchedulerStringId) As String
            Select Case id
                Case SchedulerStringId.FlyoutCaption_Location : Return "Πωλητής:"
                    'Case SchedulerStringId.FlyoutCaption_Reminder : Return "Σχόλια:"
            End Select
            Return MyBase.GetLocalizedString(id)
        End Function
    End Class

    Private Sub BBEllipse_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BBEllipse.ItemClick
        Dim form As frmScroller = New frmScroller()
        form.Text = "Εκκρεμότητες Έργων"
        form.DataTable = "vw_INST_ELLIPSE"
        form.DataDetail = "INST_ELLIPSE_JOBS"
        form.WindowState = FormWindowState.Maximized
        'form.MdiParent = form
        form.Show()
    End Sub


End Class

