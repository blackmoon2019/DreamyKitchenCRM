
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
        Select Case Mode
            Case FormMode.NewRecord
                txtCode.Text = DBQ.GetNextId("EMP_T")
            Case FormMode.EditRecord
                LoadForms.LoadForm(LayoutControl1, "Select * from vw_EMP_T where id ='" + sID + "'")
        End Select
        Me.CenterToScreen()
        My.Settings.frmSalerTziroi = Me.Location
        My.Settings.Save()
        cmdSave.Enabled = IIf(Mode = FormMode.NewRecord, UserProps.AllowInsert, UserProps.AllowEdit)

    End Sub

    Private Sub frmSalerTziroi_Resize(sender As Object, e As EventArgs) Handles Me.Resize
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
    Private Sub ManageSaler()
        Dim form1 As frmGen = New frmGen()
        form1.Text = "Πωλητές"
        form1.L1.Text = "Κωδικός"
        form1.L2.Text = "Πωλητής"
        form1.L6.Text = "Χρώμα"
        form1.DataTable = "SALERS"
        form1.L9.Text = "Ποσοστό κέρδους"
        form1.L9.Control.Tag = "profitPerc,0,1,2"
        Dim profitPerc As DevExpress.XtraEditors.TextEdit = TryCast(form1.L9.Control, DevExpress.XtraEditors.TextEdit)
        profitPerc.Properties.EditFormat.FormatString = "n0"
        profitPerc.Properties.EditFormat.FormatType = FormatType.Numeric
        profitPerc.Properties.MaskSettings.MaskExpression = "n0"
        profitPerc.Properties.Mask.MaskType = Mask.MaskType.Numeric
        profitPerc.Properties.UseMaskAsDisplayFormat = True
        form1.CalledFromControl = True
        form1.CallerControl = cboSaler
        If cboSaler.EditValue <> Nothing Then form1.ID = cboSaler.EditValue.ToString
        form1.MdiParent = frmMain
        form1.L6.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
        form1.L9.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
        form1.L8.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
        form1.L6.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
        If cboSaler.EditValue <> Nothing Then form1.Mode = FormMode.EditRecord Else form1.Mode = FormMode.NewRecord
        frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(form1), New Point(CInt(form1.Parent.ClientRectangle.Width / 2 - form1.Width / 2), CInt(form1.Parent.ClientRectangle.Height / 2 - form1.Height / 2)))
        form1.Show()
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

                If sResult = True Then XtraMessageBox.Show("Η εγγραφή αποθηκέυτηκε με επιτυχία", "Dreamy Kitchen CRM", MessageBoxButtons.OK, MessageBoxIcon.Information)
                If Mode = FormMode.NewRecord Then
                    Cls.ClearCtrls(LayoutControl1)
                    txtCode.Text = DBQ.GetNextId("EMP_T")
                End If
            End If

        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), "Dreamy Kitchen CRM", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtbusisnessProfit_LostFocus(sender As Object, e As EventArgs) Handles txtbusisnessProfit.LostFocus
        If cboSaler.GetColumnValue("profitPerc") = Nothing Then Exit Sub
        txtsalerProfit.EditValue = (txtbusisnessProfit.EditValue / 100) * cboSaler.GetColumnValue("profitPerc")
    End Sub

    Private Sub txtnormalPrice_Validated(sender As Object, e As EventArgs) Handles txtnormalPrice.Validated
        txtbusisnessProfit.EditValue = txtsalePrice.EditValue - txtnormalPrice.EditValue
    End Sub

    Private Sub txtsalePrice_Validated(sender As Object, e As EventArgs) Handles txtsalePrice.Validated
        txtbusisnessProfit.EditValue = txtsalePrice.EditValue - txtnormalPrice.EditValue

    End Sub
End Class