Imports System.ComponentModel
Imports System.Data.SqlClient
Imports System.Text
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
Imports DevExpress.XtraScheduler.Drawing

Public Class frmCalendarInst
    Private Calendar As New InitializeCalendar
    Private Sub frmCalendarInst_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DreamyKitchenDataSet.vw_SER' table. You can move, or remove it, as needed.
        Me.Vw_SERTableAdapter.Fill(Me.DreamyKitchenDataSet.vw_SER)

        Try
            Dim sSQL As String
            PanelResults.Visible = False
            sSQL = "SELECT * FROM vw_INST where completed = 0 order by code"
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
            If My.Computer.FileSystem.FileExists(Application.StartupPath & "\DSGNS\DEF\Inst.xml") Then GridView1.RestoreLayoutFromXml(Application.StartupPath & "\DSGNS\DEF\Inst.xml", OptionsLayoutBase.FullLayout)
        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), "Dreamy Kitchen CRM", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub BarNewRec_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BarNewRec.ItemClick
        Dim form1 As frmInstallations = New frmInstallations()
        form1.Text = "Τοποθετήσεις"
        form1.MdiParent = frmMain
        form1.Mode = FormMode.NewRecord
        frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(form1), New Point(CInt(form1.Parent.ClientRectangle.Width / 2 - form1.Width / 2), CInt(form1.Parent.ClientRectangle.Height / 2 - form1.Height / 2)))
        form1.Show()
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
        For i As Integer = 0 To SchedulerControl1.SelectedAppointments.Count - 1
            Dim apt As Appointment = SchedulerControl1.SelectedAppointments(i)
            Dim form1 As frmInstallations = New frmInstallations()
            form1.Text = "Τοποθετήσεις"
            form1.ID = apt.Id
            form1.MdiParent = frmMain
            form1.Mode = FormMode.EditRecord
            form1.Scroller = frmScroller.GridView1
            form1.FormScroller = frmScroller
            frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(form1), New Point(CInt(form1.Parent.ClientRectangle.Width / 2 - form1.Width / 2), CInt(form1.Parent.ClientRectangle.Height / 2 - form1.Height / 2)))
            form1.Show()
        Next i

    End Sub
    Private Sub SetCalendarFilter(Optional ByVal sWhere As String = "")
        Dim sSQL As String
        Dim sIDS As New StringBuilder
        SchedulerDataStorage1.Appointments.Clear()
        sSQL = "SELECT * FROM vw_INST "
        If sWhere.Length > 0 Then sSQL = sSQL & " where cctName like " & toSQLValueS("%" & sWhere & "%")
        For i As Integer = 0 To cboCompleted.Items.Count - 1
            If cboCompleted.Items(i).CheckState = CheckState.Checked Then
                If sIDS.Length > 0 Then sIDS.Append(",")
                sIDS.Append(toSQLValueS(cboCompleted.Items(i).Tag.ToString))
            End If

        Next
        If sIDS.Length > 0 And sWhere.Length > 0 Then
            sSQL = sSQL + " and completed in (" & sIDS.ToString & ")"
        ElseIf sIDS.Length > 0 Then
            sSQL = sSQL + " where completed in (" & sIDS.ToString & ")"
        End If
        Calendar.InitializeInst(SchedulerControl1, SchedulerDataStorage1, sSQL, False)
    End Sub
    Private Sub OkButton_Click(ByVal sender As Object, ByVal e As EventArgs)
        SetCalendarFilter()
    End Sub
    Private Sub BarRefresh_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles Ανανέωση.ItemClick
        SetCalendarFilter()
    End Sub
    Private Sub OkComletedButton_Click(ByVal sender As Object, ByVal e As EventArgs)
        SetCalendarFilter()
    End Sub
    Private Sub cboCompleted_Popup(sender As Object, e As EventArgs) Handles cboCompleted.Popup
        Dim edit = TryCast(sender, CheckedComboBoxEdit)
        Dim form = edit.GetPopupEditForm()
        RemoveHandler form.OkButton.Click, AddressOf OkComletedButton_Click
        AddHandler form.OkButton.Click, AddressOf OkComletedButton_Click
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
    Friend Class MenuColumnInfo
        Public Sub New(ByVal column As GridColumn)
            Me.Column = column
        End Sub
        Public Column As GridColumn
    End Class
End Class