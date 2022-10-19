
Imports System.ComponentModel
Imports System.Data.SqlClient
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls

Public Class frmInstallations
    Private sID As String
    Private sEMP_T_ID As String
    Private sTRANSH_ID As String
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
    Private UserPermissions As New CheckPermissions

    Public WriteOnly Property ID As String
        Set(value As String)
            sID = value
        End Set
    End Property
    Public WriteOnly Property EMP_T_ID As String
        Set(value As String)
            sEMP_T_ID = value
        End Set
    End Property
    Public WriteOnly Property TRANSH_ID As String
        Set(value As String)
            sTRANSH_ID = value
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

    Private Sub frmInstallations_Load(sender As Object, e As EventArgs) Handles Me.Load
        'TODO: This line of code loads data into the 'DreamyKitchenDataSet.vw_TRANSH' table. You can move, or remove it, as needed.
        Dim sSQL As New System.Text.StringBuilder
        sSQL.AppendLine("Select id,Fullname,salary,tmIN,tmOUT from vw_EMP where active=1 and jobID IN('A7C491B1-965B-4E86-95CF-C7881935C77D','F1A60661-D448-41B7-8CF0-CE6B9FF6E518') order by Fullname")
        FillCbo.SER(cboSER, sSQL)
        FillCbo.CUS(cboCUS)
        FillCbo.SALERS(cboSaler)
        ' Μόνο αν ο Χρήστης ΔΕΝ είναι ο Παναγόπουλος
        If UserProps.ID.ToString.ToUpper <> "3F9DC32E-BE5B-4D46-A13C-EA606566CF32" And UserProps.ID.ToString.ToUpper <> "E9CEFD11-47C0-4796-A46B-BC41C4C3606B" Then Lcost.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never : LExtracost.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        Select Case Mode
            Case FormMode.NewRecord
                txtCode.Text = DBQ.GetNextId("INST")
            Case FormMode.EditRecord
                LoadForms.LoadForm(LayoutControl1, "Select * from vw_INST where id ='" + sID + "'")
                cmdInstEllipse.Enabled = True
        End Select
        Me.CenterToScreen()
        My.Settings.frmServices = Me.Location
        My.Settings.Save()
        cmdSave.Enabled = IIf(Mode = FormMode.NewRecord, UserProps.AllowInsert, UserProps.AllowEdit)

        End Sub

    Private Sub frmInstallations_Resize(sender As Object, e As EventArgs) Handles Me.Resize
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
    Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click
        Dim sResult As Boolean
        Dim sGuid As String
        Dim sSQL As New System.Text.StringBuilder
        Try
            If Valid.ValidateForm(LayoutControl1) Then
                If txtTmIN.Text = "00:00" Or txtTmOUT.Text = "00:00" Then XtraMessageBox.Show("Η ώρα δεν μπορεί να είναι 00:00", "Dreamy Kitchen CRM", MessageBoxButtons.OK, MessageBoxIcon.Error) : Exit Sub
                Dim Hours As Long = DateDiff(DateInterval.Hour, txtTmIN.EditValue, txtTmOUT.EditValue)
                If Hours < 0 Then XtraMessageBox.Show("Η ώρα ΑΠΟ δεν μπορεί να είναι μικρότερη από την ΕΩΣ", "Dreamy Kitchen CRM", MessageBoxButtons.OK, MessageBoxIcon.Error) : Exit Sub
                Select Case Mode
                    Case FormMode.NewRecord
                        sGuid = System.Guid.NewGuid.ToString
                        sResult = DBQ.InsertNewData(DBQueries.InsertMode.OneLayoutControl, "INST", LayoutControl1,,, sGuid, True)
                        sID = sGuid
                    Case FormMode.EditRecord
                        sResult = DBQ.UpdateNewData(DBQueries.InsertMode.OneLayoutControl, "INST", LayoutControl1,,, sID, True)
                        'sGuid = sID
                End Select

                'If FScrollerExist = True Then
                '    Dim form As frmScroller = Frm
                '    form.LoadRecords("vw_INST")
                'End If

                If sResult = True Then
                    sSQL.Clear()
                    sSQL.AppendLine("UPDATE PROJECT_COST SET InstPayroll = (Select sum(ISNULL(I.cost, 0) + ISNULL(I.extracost, 0)) from INST I where I.transhid= " & toSQLValueS(cboTRANSH.EditValue.ToString) & ")")
                    sSQL.AppendLine("WHERE TRANSHID = " & toSQLValueS(cboTRANSH.EditValue.ToString))
                    'Εκτέλεση QUERY
                    Using oCmd As New SqlCommand(sSQL.ToString, CNDB)
                        oCmd.ExecuteNonQuery()
                    End Using
                    XtraMessageBox.Show("Η εγγραφή αποθηκέυτηκε με επιτυχία", "Dreamy Kitchen CRM", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
                If Mode = FormMode.NewRecord Then
                    'XtraMessageBox.Show("Θα δημιουργηθεί αυτόματη κίνηση εξόφλησης", "Dreamy Kitchen CRM", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    'If chkPaid.Checked = True Then
                    '    sSQL.AppendLine("INSERT INTO INST_M (instID,amt,dtpay,createdby,createdOn")
                    '    sSQL.AppendLine("Select " & toSQLValueS(sGuid) & ",")
                    '    sSQL.AppendLine(toSQLValueS(txtCost.EditValue, True) & ",")
                    '    sSQL.AppendLine(toSQLValueS(dtDeliverDate.EditValue.ToString) & ",")
                    '    sSQL.AppendLine(toSQLValueS(UserProps.ID.ToString) & "," & " getdate()")
                    'End If
                    ''Εκτέλεση QUERY
                    'Using oCmd As New SqlCommand(sSQL.ToString, CNDB)
                    '    oCmd.ExecuteNonQuery()
                    'End Using
                    Cls.ClearCtrls(LayoutControl1)
                    txtCode.Text = DBQ.GetNextId("INST")
                End If
                End If

                Catch ex As Exception
                XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), "Dreamy Kitchen CRM", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub ManageTRANSH()
        Dim form1 As frmTransactions = New frmTransactions()
        form1.Text = "Χρεωπιστώσεις Πελατών"
        form1.CallerControl = cboTRANSH
        form1.CalledFromControl = True
        form1.MdiParent = frmMain
        If cboTRANSH.EditValue <> Nothing Then
            form1.ID = cboTRANSH.EditValue.ToString
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
    Private Sub cboSER_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboSER.ButtonClick
        Select Case e.Button.Index
            Case 1 : cboSER.EditValue = Nothing : ManageSer()
            Case 2 : If cboSER.EditValue <> Nothing Then ManageSer()
            Case 3 : cboSER.EditValue = Nothing
        End Select
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
            Case 1 : If UserProps.ID.ToString.ToUpper = "3F9DC32E-BE5B-4D46-A13C-EA606566CF32" Then cboSaler.EditValue = Nothing : ManageSaler()
            Case 2 : If UserProps.ID.ToString.ToUpper = "3F9DC32E-BE5B-4D46-A13C-EA606566CF32" Then If cboSaler.EditValue <> Nothing Then ManageSaler()
            Case 3 : cboSaler.EditValue = Nothing
        End Select
    End Sub

    Private Sub frmInstallations_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        'If Mode <> FormMode.NewRecord Then Exit Sub
        If sEMP_T_ID Is Nothing Then Exit Sub
        If XtraMessageBox.Show("Θέλετε να ενημερώσετε τους Τζίρους-Ποσοστά Έκθεσης?", "Dreamy Kitchen CRM", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            frmSalerTziroi.Text = "Τζίροι-Ποσοστά έκθεσης"
            frmSalerTziroi.ID = sEMP_T_ID
            frmSalerTziroi.MdiParent = frmMain
            frmSalerTziroi.Mode = FormMode.EditRecord

            frmSalerTziroi.FormScrollerExist = False
            frmSalerTziroi.CalledFromControl = False
            frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(frmSalerTziroi), New Point(CInt(frmSalerTziroi.Parent.ClientRectangle.Width / 2 - frmSalerTziroi.Width / 2), CInt(frmSalerTziroi.Parent.ClientRectangle.Height / 2 - frmSalerTziroi.Height / 2)))
            frmSalerTziroi.Show()
        End If
    End Sub

    Private Sub cmdInstEllipse_Click(sender As Object, e As EventArgs) Handles cmdInstEllipse.Click
        Dim frmInstEllipse As New frmInstEllipse
        frmInstEllipse.Text = "Ελλείψεις Τοποθετήσεων"
        frmInstEllipse.Mode = FormMode.NewRecord
        frmInstEllipse.INST_ID = sID
        frmInstEllipse.CalledFromControl = False
        'frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(frmInstEllipse), New Point(CInt(frmInstEllipse.Parent.ClientRectangle.Width / 2 - frmInstEllipse.Width / 2), CInt(frmInstEllipse.Parent.ClientRectangle.Height / 2 - frmInstEllipse.Height / 2)))
        frmInstEllipse.Show()
    End Sub

    Private Sub cboCUS_EditValueChanged(sender As Object, e As EventArgs) Handles cboCUS.EditValueChanged
        Dim sCusID As String
        If cboCUS.EditValue Is Nothing Then sCusID = Guid.Empty.ToString Else sCusID = cboCUS.EditValue.ToString
        Me.Vw_TRANSHTableAdapter.Fill(Me.DreamyKitchenDataSet.vw_TRANSH, System.Guid.Parse(sCusID))
    End Sub


    Private Sub cboTRANSH_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboTRANSH.ButtonClick
        Select Case e.Button.Index
            Case 1 : If UserProps.ID.ToString.ToUpper = "3F9DC32E-BE5B-4D46-A13C-EA606566CF32" Then  cboTRANSH.EditValue = Nothing : ManageTRANSH()
            Case 2 : If UserProps.ID.ToString.ToUpper = "3F9DC32E-BE5B-4D46-A13C-EA606566CF32" Then  If cboTRANSH.EditValue <> Nothing Then ManageTRANSH()
            Case 3 : cboTRANSH.EditValue = Nothing
        End Select
    End Sub

    Private Sub cboTRANSH_EditValueChanged(sender As Object, e As EventArgs) Handles cboTRANSH.EditValueChanged

    End Sub
End Class