Imports System.CodeDom.Compiler
Imports System.Data.SqlClient
Imports System.IO
Imports DevExpress.XtraBars.Navigation
Imports DevExpress.XtraEditors
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
                            Calendar.CreateAppointment(sID, frmCalendar.SchedulerDataStorage1, dtReminder.Text.ToString, cboSTATUS.Text, txtSch.Text, Color.FromArgb(cboSaler.GetColumnValue("color")), sComments, cboSaler.GetColumnValue("code"), cboCUS.Text, sRemValues, tmReminder.Text.ToString)
                        End If
                    End If

                    XtraMessageBox.Show("Η εγγραφή αποθηκέυτηκε με επιτυχία", "Dreamy Kitchen CRM", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    Mode = FormMode.EditRecord
                End If
                'Καθαρισμός Controls
                If Mode = FormMode.NewRecord Then Cls.ClearCtrls(LayoutControl1)

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

    Private Sub cmdCboManageCUS_Click(sender As Object, e As EventArgs) Handles cmdCboManageCUS.Click
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

    Private Sub cmdCboManageSTATUS_Click(sender As Object, e As EventArgs) Handles cmdCboManageSTATUS.Click
        Dim form1 As frmGen = New frmGen()
        form1.Text = "STATUS"
        form1.L1.Text = "Κωδικός"
        form1.L2.Text = "Status"
        form1.DataTable = "STATUS"
        form1.CallerControl = cboSTATUS
        form1.CalledFromControl = True
        If cboSTATUS.EditValue <> Nothing Then form1.ID = cboSTATUS.EditValue.ToString
        form1.MdiParent = frmMain
        form1.L3.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        form1.L4.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        'form1.L5.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        form1.chk1.Text = "Επιτρέπονται ειδοποιήσεις"
        form1.L6.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        If cboSTATUS.EditValue <> Nothing Then form1.Mode = FormMode.EditRecord Else form1.Mode = FormMode.NewRecord
        frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(form1), New Point(CInt(form1.Parent.ClientRectangle.Width / 2 - form1.Width / 2), CInt(form1.Parent.ClientRectangle.Height / 2 - form1.Height / 2)))
        form1.Show()
    End Sub

    Private Sub cmdCBOManageSaler_Click(sender As Object, e As EventArgs) Handles cmdCBOManageSaler.Click
        Dim form1 As frmGen = New frmGen()
        form1.Text = "Πωλητές"
        form1.L1.Text = "Κωδικός"
        form1.L2.Text = "Πωλητής"
        form1.DataTable = "SALERS"
        form1.CalledFromControl = True
        form1.CallerControl = cboSaler
        If cboSaler.EditValue <> Nothing Then form1.ID = cboSaler.EditValue.ToString
        form1.MdiParent = frmMain
        form1.L3.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        form1.L4.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        form1.L5.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        form1.L6.Text = "Χρώμα"
        If cboSaler.EditValue <> Nothing Then form1.Mode = FormMode.EditRecord Else form1.Mode = FormMode.NewRecord
        frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(form1), New Point(CInt(form1.Parent.ClientRectangle.Width / 2 - form1.Width / 2), CInt(form1.Parent.ClientRectangle.Height / 2 - form1.Height / 2)))
        form1.Show()
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

    Private Sub frmCusMov_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        If Me.WindowState = FormWindowState.Maximized Then frmMain.XtraTabbedMdiManager1.Dock(Me, frmMain.XtraTabbedMdiManager1)
    End Sub
End Class