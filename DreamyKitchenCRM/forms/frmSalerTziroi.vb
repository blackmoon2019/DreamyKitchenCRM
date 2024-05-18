
Imports System.Data.SqlClient
Imports DevExpress.Utils
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls

Public Class frmSalerTziroi
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
    Private UserPermissions As New CheckPermissions

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

    Private Sub frmSalerTziroi_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim sSQL As New System.Text.StringBuilder
        FillCbo.SALERS(cboSaler)
        FillCbo.CUS(cboCUS)
        FillCbo.TRANSH(cboTransH)


        Select Case Mode
            Case FormMode.NewRecord
                txtCode.Text = DBQ.GetNextId("EMP_T")
            Case FormMode.EditRecord
                LoadForms.LoadForm(LayoutControl1, "Select * from vw_EMP_T where id ='" + sID + "'")
        End Select
        Me.CenterToScreen()
        cmdSave.Enabled = IIf(Mode = FormMode.NewRecord, UserProps.AllowInsert, UserProps.AllowEdit)

    End Sub

    Private Sub frmSalerTziroi_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        If Me.WindowState = FormWindowState.Maximized Then frmMain.XtraTabbedMdiManager1.Dock(Me, frmMain.XtraTabbedMdiManager1)
    End Sub
    Private Sub ManageTRANSH()
        Dim form1 As frmTransactions = New frmTransactions()
        form1.Text = "Έργα Πελατών"
        form1.CallerControl = cboTransH
        form1.CalledFromControl = True
        form1.MdiParent = frmMain
        If cboTransH.EditValue isnot Nothing Then
            form1.ID = cboTransH.EditValue.ToString
            form1.Mode = FormMode.EditRecord
        End If
        frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(form1), New Point(CInt(form1.Parent.ClientRectangle.Width / 2 - form1.Width / 2), CInt(form1.Parent.ClientRectangle.Height / 2 - form1.Height / 2)))
        form1.Show()
    End Sub
    Private Sub ManageCus()
        Dim form1 As frmCustomers = New frmCustomers()
        form1.Text = "Πελάτες"
        form1.CallerControl = cboCUS
        form1.CalledFromControl = True
        form1.MdiParent = frmMain
        If cboCUS.EditValue isnot Nothing Then
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
        If cboSaler.EditValue isnot Nothing Then
            form1.ID = cboSaler.EditValue.ToString
            form1.Mode = FormMode.EditRecord
        Else
            form1.Mode = FormMode.NewRecord
        End If
        frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(form1), New Point(CInt(form1.Parent.ClientRectangle.Width / 2 - form1.Width / 2), CInt(form1.Parent.ClientRectangle.Height / 2 - form1.Height / 2)))
        form1.Show()
    End Sub

    Private Sub cboCUS_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboCUS.ButtonClick
        Select Case e.Button.Index
            Case 1 : cboCUS.EditValue = Nothing : ManageCus()
            Case 2 : If cboCUS.EditValue isnot Nothing Then ManageCus()
            Case 3 : cboCUS.EditValue = Nothing
        End Select
    End Sub

    Private Sub cboSaler_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboSaler.ButtonClick
        Select Case e.Button.Index
            Case 1 : If UserProps.ID.ToString.ToUpper = "3F9DC32E-BE5B-4D46-A13C-EA606566CF32" Or UserProps.ID.ToString.ToUpper = "E9CEFD11-47C0-4796-A46B-BC41C4C3606B" Then  cboSaler.EditValue = Nothing : ManageSaler()
            Case 2 : If UserProps.ID.ToString.ToUpper = "3F9DC32E-BE5B-4D46-A13C-EA606566CF32" Or UserProps.ID.ToString.ToUpper = "E9CEFD11-47C0-4796-A46B-BC41C4C3606B" Then  If cboSaler.EditValue isnot Nothing Then ManageSaler()
            Case 3 : cboSaler.EditValue = Nothing
        End Select
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
                        sResult = DBQ.InsertNewData(DBQueries.InsertMode.OneLayoutControl, "EMP_T", LayoutControl1,,, sGuid, True)
                    Case FormMode.EditRecord
                        sResult = DBQ.UpdateNewData(DBQueries.InsertMode.OneLayoutControl, "EMP_T", LayoutControl1,,, sID, True)
                        sGuid = sID
                End Select
                If FScrollerExist = True Then
                    Dim form As frmScroller = Frm
                    form.LoadRecords("vw_EMP_T")
                End If

                If cboTransH.EditValue IsNot Nothing Then
                    ' Άνοιγμα έργου αν δεν υπάρχει ή ενημέρωση ποσών
                    Using oCmd As New SqlCommand("usp_AddOrUpdateProjectcost", CNDB)
                        oCmd.CommandType = CommandType.StoredProcedure
                        oCmd.Parameters.AddWithValue("@transhID", cboTransH.EditValue.ToString)
                        oCmd.ExecuteNonQuery()
                    End Using
                End If


                If sResult = True Then XtraMessageBox.Show("Η εγγραφή αποθηκέυτηκε με επιτυχία", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Information)
                If Mode = FormMode.NewRecord Then
                    Cls.ClearCtrls(LayoutControl1)
                    txtCode.Text = DBQ.GetNextId("EMP_T")
                End If
            End If

        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtbusisnessProfit_LostFocus(sender As Object, e As EventArgs) Handles txtbusisnessProfit.LostFocus

    End Sub

    Private Sub txtnormalPrice_Validated(sender As Object, e As EventArgs) Handles txtnormalPrice.Validated
        txtbusisnessProfit.EditValue = txtGenTotAmt.EditValue - txtnormalPrice.EditValue
    End Sub

    Private Sub txtsalePrice_Validated(sender As Object, e As EventArgs) Handles txtsalePrice.Validated
        txtbusisnessProfit.EditValue = txtGenTotAmt.EditValue - txtnormalPrice.EditValue

    End Sub

    Private Sub cboCUS_EditValueChanged(sender As Object, e As EventArgs) Handles cboCUS.EditValueChanged
        Dim sCusID As String
        If cboCUS.EditValue Is Nothing Then sCusID = toSQLValueS(Guid.Empty.ToString) Else sCusID = toSQLValueS(cboCUS.EditValue.ToString)
        Dim sSQL As New System.Text.StringBuilder
        sSQL.AppendLine("Select id,FullTranshDescription,Totamt from vw_TRANSH where cusid = " & sCusID & "order by FullTranshDescription")
        FillCbo.TRANSH(cboTransH, sSQL)
    End Sub

    Private Sub cboTransH_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboTransH.ButtonClick
        Select Case e.Button.Index
            Case 1 : If UserProps.ID.ToString.ToUpper = "3F9DC32E-BE5B-4D46-A13C-EA606566CF32" Or UserProps.ID.ToString.ToUpper = "E9CEFD11-47C0-4796-A46B-BC41C4C3606B" Then   cboTransH.EditValue = Nothing : ManageTRANSH()
            Case 2 : If UserProps.ID.ToString.ToUpper = "3F9DC32E-BE5B-4D46-A13C-EA606566CF32" Or UserProps.ID.ToString.ToUpper = "E9CEFD11-47C0-4796-A46B-BC41C4C3606B" Then   If cboTransH.EditValue isnot Nothing Then ManageTRANSH()
            Case 3 : cboTransH.EditValue = Nothing
        End Select
    End Sub

    Private Sub txtbusisnessProfit_Validated(sender As Object, e As EventArgs) Handles txtbusisnessProfit.Validated

    End Sub

    Private Sub txtbusisnessProfit_EditValueChanged(sender As Object, e As EventArgs) Handles txtbusisnessProfit.EditValueChanged
        'If cboSaler.GetColumnValue("profitPerc") = Nothing Then Exit Sub
        'txtsalerProfit.EditValue = (txtbusisnessProfit.EditValue / 100) * cboSaler.GetColumnValue("profitPerc")
    End Sub

    Private Sub txtsalePrice_EditValueChanged(sender As Object, e As EventArgs) Handles txtsalePrice.EditValueChanged

    End Sub

    Private Sub txtnormalPrice_EditValueChanged(sender As Object, e As EventArgs) Handles txtnormalPrice.EditValueChanged

    End Sub
End Class