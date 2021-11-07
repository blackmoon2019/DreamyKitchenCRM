
Imports System.ComponentModel
Imports System.Data.SqlClient
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls

Public Class frmConstrunction
    Private sID As String
    Private Ctrl As DevExpress.XtraGrid.Views.Grid.GridView
    Private Frm As DevExpress.XtraEditors.XtraForm
    Public Mode As Byte
    Private Valid As New ValidateControls
    Private FScrollerExist As Boolean = False
    Private Log As New Transactions
    Private FillCbo As New FillCombos
    Private DBQ As New DBQueries
    Private LoadForms As New FormLoader
    Private Cls As New ClearControls
    Private CtrlCombo As DevExpress.XtraEditors.LookUpEdit
    Private CalledFromCtrl As Boolean
    Private WorkingTime As Integer
    Private AgreementSalary As Double

    Public WriteOnly Property ID As String
        Set(value As String)
            sID = value
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
    Public WriteOnly Property CallerControl As DevExpress.XtraEditors.LookUpEdit
        Set(value As DevExpress.XtraEditors.LookUpEdit)
            CtrlCombo = value
        End Set
    End Property
    Public WriteOnly Property CalledFromControl As Boolean
        Set(value As Boolean)
            CalledFromCtrl = value
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

    Private Sub frmConstrunction_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim sSQL As New System.Text.StringBuilder
        sSQL.AppendLine("Select id,Fullname,salary,tmIN,tmOUT from vw_EMP where jobID='F1A60661-D448-41B7-8CF0-CE6B9FF6E518' order by Fullname")
        FillCbo.SER(cboSER, sSQL)
        FillCbo.CUS(cboCUS)
        FillCbo.CONSTR_CAT(cboConstrCat)

        Select Case Mode
            Case FormMode.NewRecord
                txtCode.Text = DBQ.GetNextId("CONSTR")
                dtDeliverDate.EditValue = Now.Date
            Case FormMode.EditRecord
                LoadForms.LoadForm(LayoutControl1, "Select * from vw_CONSTR where id ='" + sID + "'")
        End Select
        Me.CenterToScreen()
        My.Settings.frmServices = Me.Location
        My.Settings.Save()
        cmdSave.Enabled = IIf(Mode = FormMode.NewRecord, UserProps.AllowInsert, UserProps.AllowEdit)
    End Sub

    Private Sub frmConstrunction_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        If Me.WindowState = FormWindowState.Maximized Then frmMain.XtraTabbedMdiManager1.Dock(Me, frmMain.XtraTabbedMdiManager1)
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


    Private Sub ManageSer()
        Dim form1 As frmEMP = New frmEMP()
        form1.Text = "Συνεργεία"
        form1.CallerControl = cboSER
        form1.CalledFromControl = True
        form1.MdiParent = frmMain
        If cboSER.EditValue <> Nothing Then
            form1.ID = cboSER.EditValue.ToString
            form1.Mode = FormMode.EditRecord
        Else
            form1.Mode = FormMode.NewRecord
        End If
        frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(form1), New Point(CInt(form1.Parent.ClientRectangle.Width / 2 - form1.Width / 2), CInt(form1.Parent.ClientRectangle.Height / 2 - form1.Height / 2)))
        form1.Show()

    End Sub
    Private Sub ManageConstrCat()
        Dim form1 As frmGen = New frmGen()
        form1.Text = "Κατηγορίες Εργασιών"
        form1.L1.Text = "Κωδικός"
        form1.L2.Text = "Κατηγορία"
        form1.DataTable = "CONSTR_CAT"
        form1.CalledFromControl = True
        form1.CallerControl = cboConstrCat
        If cboConstrCat.EditValue <> Nothing Then form1.ID = cboConstrCat.EditValue.ToString
        form1.MdiParent = frmMain
        If cboConstrCat.EditValue <> Nothing Then form1.Mode = FormMode.EditRecord Else form1.Mode = FormMode.NewRecord
        frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(form1), New Point(CInt(form1.Parent.ClientRectangle.Width / 2 - form1.Width / 2), CInt(form1.Parent.ClientRectangle.Height / 2 - form1.Height / 2)))
        form1.Show()

    End Sub

    Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click
        Dim sResult As Boolean
        Dim sGuid As String
        Dim sSQL As New System.Text.StringBuilder
        Try
            If Valid.ValidateForm(LayoutControl1) Then
                Select Case Mode
                    Case FormMode.NewRecord
                        sGuid = System.Guid.NewGuid.ToString
                        sResult = DBQ.InsertNewData(DBQueries.InsertMode.OneLayoutControl, "CONSTR", LayoutControl1,,, sGuid, True)
                        sID = sGuid
                    Case FormMode.EditRecord
                        sResult = DBQ.UpdateNewData(DBQueries.InsertMode.OneLayoutControl, "CONSTR", LayoutControl1,,, sID, True)
                        'sGuid = sID
                End Select

                If FScrollerExist = True Then
                    Dim form As frmScroller = Frm
                    form.LoadRecords("vw_CONSTR")
                End If

                If sResult = True Then XtraMessageBox.Show("Η εγγραφή αποθηκέυτηκε με επιτυχία", "Dreamy Kitchen CRM", MessageBoxButtons.OK, MessageBoxIcon.Information)
                If Mode = FormMode.NewRecord Then
                    Cls.ClearCtrls(LayoutControl1)
                    txtCode.Text = DBQ.GetNextId("CONSTR")
                End If
            End If

        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), "Dreamy Kitchen CRM", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub cboSER_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboSER.ButtonClick
        Select Case e.Button.Index
            Case 1 : cboSER.EditValue = Nothing : ManageSer()
            Case 2 : If cboSER.EditValue <> Nothing Then ManageSer()
            Case 3 : cboSER.EditValue = Nothing : txtSalary.Text = "0.00"
        End Select
    End Sub

    Private Sub cboCUS_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboCUS.ButtonClick
        Select Case e.Button.Index
            Case 1 : cboCUS.EditValue = Nothing : ManageCus()
            Case 2 : If cboCUS.EditValue <> Nothing Then ManageCus()
            Case 3 : cboCUS.EditValue = Nothing
        End Select
    End Sub

    Private Sub cboConstrCat_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboConstrCat.ButtonClick
        Select Case e.Button.Index
            Case 1 : cboConstrCat.EditValue = Nothing : ManageConstrCat()
            Case 2 : If cboConstrCat.EditValue <> Nothing Then ManageConstrCat()
            Case 3 : cboConstrCat.EditValue = Nothing
        End Select
    End Sub

    Private Sub cboSER_EditValueChanged(sender As Object, e As EventArgs) Handles cboSER.EditValueChanged
        txtSalary.EditValue = cboSER.GetColumnValue("salary")
        tmIN.EditValue = cboSER.GetColumnValue("tmIN")
        tmOUT.EditValue = cboSER.GetColumnValue("tmOUT")
        If txtSalary.EditValue Is Nothing Then Exit Sub
        AgreementSalary = txtSalary.EditValue
        WorkingTime = TimeWorkCalculate()
    End Sub
    Private Function TimeWorkCalculate() As Integer
        Try
            Dim startTime As New DateTime(Now.Year, Now.Month, Now.Day, tmIN.Text.ToString.Substring(0, 2), tmIN.Text.ToString.Substring(3, 2), 0)     ' 10:30 AM today
            Dim endTime As New DateTime(Now.Year, Now.Month, Now.Day, tmOUT.Text.ToString.Substring(0, 2), tmOUT.Text.ToString.Substring(3, 2), 0)     ' 10:30 AM today

            Dim duration As TimeSpan = endTime - startTime        'Subtract start time from end time
            Return duration.TotalMinutes
            Console.WriteLine(duration.TotalMinutes)
        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), "Dreamy Kitchen CRM", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function

    Private Sub tmIN_Validated(sender As Object, e As EventArgs) Handles tmIN.Validated
        ' 480 ΛΕΠΤΑ ΕΙΝΑΙ ΤΟ 8ΑΩΡΟ
        Dim TotalWork As Integer
        Dim OverWork As Integer
        Dim SalaryPerMinute As Double
        Dim ExtraCost As Double
        If tmIN.Text = "" Or txtSalary.EditValue = Nothing Then Exit Sub
        TotalWork = TimeWorkCalculate()
        SalaryPerMinute = AgreementSalary / WorkingTime
        txtSalary.EditValue = TotalWork * SalaryPerMinute
        If TotalWork > 480 Then
            OverWork = TotalWork - 480
            txtOverWork.EditValue = OverWork
            ExtraCost = TotalWork * SalaryPerMinute
            ExtraCost = ExtraCost - AgreementSalary
        Else
            OverWork = 0
            'txtExtraCost.EditValue = "0"
        End If
        txtOverWork.EditValue = OverWork
        ' txtExtraCost.EditValue = ExtraCost

    End Sub
    Private Sub tmOUT_Validated(sender As Object, e As EventArgs) Handles tmOUT.Validated
        ' 480 ΛΕΠΤΑ ΕΙΝΑΙ ΤΟ 8ΑΩΡΟ
        Dim TotalWork As Integer
        Dim OverWork As Integer
        Dim SalaryPerMinute As Double
        Dim ExtraCost As Double
        If tmIN.Text = "" Or txtSalary.EditValue = Nothing Then Exit Sub
        TotalWork = TimeWorkCalculate()
        SalaryPerMinute = AgreementSalary / WorkingTime
        txtSalary.EditValue = TotalWork * SalaryPerMinute
        If TotalWork > 480 Then
            OverWork = TotalWork - 480
            txtOverWork.EditValue = OverWork
            ExtraCost = TotalWork * SalaryPerMinute
            ExtraCost = ExtraCost - AgreementSalary
        Else
            OverWork = 0
            ' txtExtraCost.EditValue = "0"
        End If
        txtOverWork.EditValue = OverWork
        ' txtExtraCost.EditValue = ExtraCost
    End Sub
End Class