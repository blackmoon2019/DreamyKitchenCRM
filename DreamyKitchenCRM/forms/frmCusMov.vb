﻿Imports System.CodeDom.Compiler
Imports System.Data.SqlClient
Imports System.IO
Imports DevExpress.XtraBars.Navigation
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraExport.Xls
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraLayout.Converter

Public Class frmCusMov
    Private sID As String
    Private sCusID As String
    Private Ctrl As DevExpress.XtraGrid.Views.Grid.GridView
    Private Frm As DevExpress.XtraEditors.XtraForm
    Public Mode As Byte
    Private FScrollerExist As Boolean = False
    Private Valid As New ValidateControls
    Private Log As New Transactions
    Private FillCbo As New FillCombos
    Private DBQ As New DBQueries
    Private LoadForms As New FormLoader
    Private Cls As New ClearControls
    Private Calendar As New InitializeCalendar
    Private sColor As Integer


    Public WriteOnly Property ID As String
        Set(value As String)
            sID = value
        End Set
    End Property
    Public WriteOnly Property CusID As String
        Set(value As String)
            sCusID = value
        End Set
    End Property
    Public WriteOnly Property Scroller As DevExpress.XtraGrid.Views.Grid.GridView
        Set(value As DevExpress.XtraGrid.Views.Grid.GridView)
            Ctrl = value
        End Set
    End Property
    Public WriteOnly Property FormScroller As DevExpress.XtraEditors.XtraForm
        Set(value As DevExpress.XtraEditors.XtraForm)
            Frm = value
        End Set
    End Property
    Public WriteOnly Property FormScrollerExist As Boolean
        Set(value As Boolean)
            FScrollerExist = value
        End Set
    End Property
    Private Sub cmdExit_Click(sender As Object, e As EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub

    Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click
        Dim sResult As Boolean
        Dim sComments As String
        Dim sRemValues As String

        Try
            If Valid.ValidateForm(LayoutControl1) Then
                Select Case Mode
                    Case FormMode.NewRecord
                        If cboSTATUS.GetColumnValue("allowschedule") <> Nothing Then
                            If dtReminder.Text.ToString = "" Then
                                XtraMessageBox.Show("Δεν έχετε επιλέξει ημερομηνία ειδοποίησης", "Dreamy Kitchen CRM", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                Exit Sub
                            Else
                                sID = System.Guid.NewGuid.ToString
                                sResult = DBQ.InsertData(LayoutControl1, "CCT_M", sID)
                            End If
                        Else
                            sID = System.Guid.NewGuid.ToString
                            sResult = DBQ.InsertData(LayoutControl1, "CCT_M", sID)
                        End If
                        txtCode.Text = DBQ.GetNextId("CCT_M")
                    Case FormMode.EditRecord
                        If cboSTATUS.GetColumnValue("allowschedule") <> Nothing Then
                            If dtReminder.Text.ToString = "" Then
                                XtraMessageBox.Show("Δεν έχετε επιλέξει ημερομηνία ειδοποίησης", "Dreamy Kitchen CRM", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                Exit Sub
                            Else
                                sResult = DBQ.UpdateData(LayoutControl1, "CCT_M", sID)
                            End If
                        Else
                            sResult = DBQ.UpdateData(LayoutControl1, "CCT_M", sID)
                        End If

                End Select
                'dtDTS.EditValue = DateTime.Now

                If FScrollerExist = True Then
                    Dim form As frmScroller = Frm
                    form.LoadRecords("vw_CCT_M")
                End If
                If sResult = True Then
                    If txtComments.EditValue <> Nothing Then sComments = txtComments.Text Else sComments = ""
                    If cboRemValues.EditValue <> Nothing Then sRemValues = cboRemValues.EditValue.ToString Else sRemValues = ""
                    If cboSTATUS.GetColumnValue("allowschedule") <> Nothing Then
                        If cboSTATUS.GetColumnValue("allowschedule") = True Then
                            If Mode = FormMode.EditRecord Then
                                'ΔΙΑΓΡΑΦΗ APOINTMENT
                                Dim apt As DevExpress.XtraScheduler.Appointment
                                apt = frmCalendar.SchedulerDataStorage1.Appointments.GetAppointmentById(sID)
                                If apt IsNot Nothing Then frmCalendar.SchedulerDataStorage1.Appointments.Remove(apt)
                            End If
                            If txtSch.Text = "" Then txtSch.Text = 0
                            Calendar.CreateAppointment(sID, frmCalendar.SchedulerDataStorage1, dtReminder.Text.ToString, cboSTATUS.Text, txtSch.Text, Color.FromArgb(cboSaler.GetColumnValue("color")), sComments, cboSaler.GetColumnValue("code"), cboCUS.Text, sRemValues, tmReminder.Text.ToString, chkCompleted.Checked)
                        End If
                    End If

                    XtraMessageBox.Show("Η εγγραφή αποθηκέυτηκε με επιτυχία", "Dreamy Kitchen CRM", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    Mode = FormMode.EditRecord
                End If
                'Καθαρισμός Controls
                If Mode = FormMode.NewRecord Then
                    Cls.ClearCtrls(LayoutControl1)
                    txtCode.Text = DBQ.GetNextId("CCT_M")
                End If

            End If

        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), "Dreamy Kitchen CRM", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub frmCusMov_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim sSQL As New System.Text.StringBuilder
        'πΕΛΆΤΕς
        FillCbo.CUS(cboCUS)
        FillCbo.STATUS(cboSTATUS)
        FillCbo.REM_VALUES(cboRemValues)
        FillCbo.SALERS(cboSaler)
        cboRemValues.Properties.AllowNullInput = True
        Select Case Mode
            Case FormMode.NewRecord
                'dtCompleted.EditValue = DateTime.Now
                txtCode.Text = DBQ.GetNextId("CCT_M")
                dtReminder.ReadOnly = True : txtSch.ReadOnly = True : cboRemValues.ReadOnly = True : tmReminder.ReadOnly = True
            Case FormMode.EditRecord
                LoadForms.LoadForm(LayoutControl1, "Select * from vw_CCT_M where id ='" + sID + "'")
        End Select
        If sCusID <> "" Then cboCUS.EditValue = System.Guid.Parse(sCusID) Else FScrollerExist = True
        Me.CenterToScreen()
        My.Settings.frmCusMov = Me.Location
        My.Settings.Save()
        cmdSave.Enabled = IIf(Mode = FormMode.NewRecord, UserProps.AllowInsert, UserProps.AllowEdit)

    End Sub

    Private Sub cmdCboManageCUS_Click(sender As Object, e As EventArgs)
        Dim form1 As frmCustomers = New frmCustomers()
        form1.Text = "Πελάτες"
        form1.CallerControl = cboCUS
        form1.CalledFromControl = True
        form1.MdiParent = frmMain
        If cboCUS.EditValue <> Nothing Then
            form1.ID = cboCUS.EditValue.ToString
            form1.Mode = FormMode.EditRecord
        Else
            form1.Mode = FormMode.NewRecord
        End If
        frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(form1), New Point(CInt(form1.Parent.ClientRectangle.Width / 2 - form1.Width / 2), CInt(form1.Parent.ClientRectangle.Height / 2 - form1.Height / 2)))
        form1.Show()
    End Sub

    Private Sub cmdCboManageSTATUS_Click(sender As Object, e As EventArgs)
        Dim form1 As frmGen = New frmGen()
        form1.Text = "STATUS"
        form1.L1.Text = "Κωδικός"
        form1.L2.Text = "Status"
        form1.L6.Text = "Χρώμα"
        form1.DataTable = "STATUS"
        form1.CallerControl = cboSTATUS
        form1.CalledFromControl = True
        If cboSTATUS.EditValue <> Nothing Then form1.ID = cboSTATUS.EditValue.ToString
        form1.MdiParent = frmMain
        form1.chk1.Text = "Επιτρέπονται ειδοποιήσεις"
        form1.chk1.Visible = True
        form1.L5.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
        form1.L6.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
        If cboSTATUS.EditValue <> Nothing Then form1.Mode = FormMode.EditRecord Else form1.Mode = FormMode.NewRecord
        frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(form1), New Point(CInt(form1.Parent.ClientRectangle.Width / 2 - form1.Width / 2), CInt(form1.Parent.ClientRectangle.Height / 2 - form1.Height / 2)))
        form1.Show()
    End Sub

    Private Sub frmCusMov_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        If Me.WindowState = FormWindowState.Maximized Then frmMain.XtraTabbedMdiManager1.Dock(Me, frmMain.XtraTabbedMdiManager1)
    End Sub

    Private Sub chkCompleted_CheckedChanged(sender As Object, e As EventArgs) Handles chkCompleted.CheckedChanged
        Dim Edit As CheckEdit = CType(sender, CheckEdit)
        If Edit.Checked = True Then dtCompleted.EditValue = Date.Now Else dtCompleted.Enabled = False : dtCompleted.EditValue = ""
    End Sub
    Private Sub cboCUS_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboCUS.ButtonClick
        Select Case e.Button.Index
            Case 1 : cboCUS.EditValue = Nothing : ManageCus()
            Case 2 : If cboCUS.EditValue <> Nothing Then ManageCus()
            Case 3 : cboCUS.EditValue = Nothing
        End Select
    End Sub
    Private Sub cboSaler_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboSaler.ButtonClick
        Select Case e.Button.Index
            Case 1 : cboSaler.EditValue = Nothing : ManageSaler()
            Case 2 : If cboSaler.EditValue <> Nothing Then ManageSaler()
            Case 3 : cboSaler.EditValue = Nothing
        End Select
    End Sub
    Private Sub ManageStatus()
        Dim form3 As frmGen = New frmGen()
        form3.Text = "Status"
        form3.MdiParent = frmMain
        If cboSTATUS.EditValue <> Nothing Then
            form3.ID = cboSTATUS.EditValue.ToString
            form3.Mode = FormMode.EditRecord
        Else
            form3.Mode = FormMode.NewRecord
        End If
        form3.DataTable = "STATUS"
        form3.L1.Text = "Κωδικός"
        form3.L2.Text = "Status"
        form3.L6.Text = "Χρώμα"
        form3.chk1.Text = "Επιτρέπονται ειδοποιήσεις"
        form3.chk1.Visible = True
        form3.L5.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
        form3.FormScroller = Me
        form3.CalledFromControl = False
        form3.L6.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
        frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(form3), New Point(CInt(form3.Parent.ClientRectangle.Width / 2 - form3.Width / 2), CInt(form3.Parent.ClientRectangle.Height / 2 - form3.Height / 2)))
        form3.Show()
    End Sub
    Private Sub ManageCus()
        Dim form1 As frmCustomers = New frmCustomers()
        form1.Text = "Πελάτες"
        form1.CallerControl = cboCUS
        form1.CalledFromControl = True
        form1.MdiParent = frmMain
        If cboCUS.EditValue <> Nothing Then
            form1.ID = cboCUS.EditValue.ToString
            form1.Mode = FormMode.EditRecord
        Else
            form1.Mode = FormMode.NewRecord
        End If
        frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(form1), New Point(CInt(form1.Parent.ClientRectangle.Width / 2 - form1.Width / 2), CInt(form1.Parent.ClientRectangle.Height / 2 - form1.Height / 2)))
        form1.Show()
    End Sub
    Private Sub ManageSaler()
        Dim form1 As frmEMP = New frmEMP()
        form1.Text = "Πωλητές"
        form1.CallerControl = cboSaler
        form1.CalledFromControl = True
        form1.MdiParent = frmMain
        If cboSaler.EditValue <> Nothing Then
            form1.ID = cboSaler.EditValue.ToString
            form1.Mode = FormMode.EditRecord
        Else
            form1.Mode = FormMode.NewRecord
        End If
        frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(form1), New Point(CInt(form1.Parent.ClientRectangle.Width / 2 - form1.Width / 2), CInt(form1.Parent.ClientRectangle.Height / 2 - form1.Height / 2)))
        form1.Show()
    End Sub

    Private Sub cboSTATUS_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboSTATUS.ButtonClick
        Select Case e.Button.Index
            Case 1 : cboSTATUS.EditValue = Nothing : ManageStatus()
            Case 2 : If cboSTATUS.EditValue <> Nothing Then ManageStatus()
            Case 3 : cboSTATUS.EditValue = Nothing
        End Select

    End Sub

    Private Sub cboCUS_EditValueChanged(sender As Object, e As EventArgs) Handles cboCUS.EditValueChanged
        If cboCUS.GetColumnValue("SalerID") <> Nothing Then cboSaler.EditValue = System.Guid.Parse(cboCUS.GetColumnValue("SalerID").ToString)
    End Sub

    Private Sub cboSaler_EditValueChanged(sender As Object, e As EventArgs) Handles cboSaler.EditValueChanged
        sColor = cboSaler.GetColumnValue("color")
    End Sub

    Private Sub cboSTATUS_EditValueChanged(sender As Object, e As EventArgs) Handles cboSTATUS.EditValueChanged
        If cboSTATUS.GetColumnValue("allowschedule") <> Nothing Then
            dtReminder.ReadOnly = False : txtSch.ReadOnly = False : cboRemValues.ReadOnly = False
            tmReminder.ReadOnly = False
        Else
            dtReminder.EditValue = "" : dtReminder.Text = "" : dtReminder.ReadOnly = True
            tmReminder.EditValue = "" : tmReminder.Text = "" : tmReminder.ReadOnly = True
            txtSch.EditValue = "" : txtSch.ReadOnly = True
            cboRemValues.EditValue = Nothing : cboRemValues.Text = "" : cboRemValues.ReadOnly = True

        End If
    End Sub
End Class