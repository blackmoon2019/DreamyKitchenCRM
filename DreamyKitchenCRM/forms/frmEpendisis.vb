Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls

Public Class frmEpendisis
    Private sID As String
    Private Ctrl As DevExpress.XtraGrid.Views.Grid.GridView
    Private Frm As DevExpress.XtraEditors.XtraForm
    Public Mode As Byte
    Private Valid As New ValidateControls
    Private Log As New Transactions
    Private FillCbo As New FillCombos
    Private DBQ As New DBQueries
    Private LoadForms As New FormLoader
    Private Cls As New ClearControls
    Private CtrlCombo As DevExpress.XtraEditors.LookUpEdit
    Private CtrlCombo2 As DevExpress.XtraEditors.CheckedComboBoxEdit
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
    Public WriteOnly Property CallerControlCombo As DevExpress.XtraEditors.CheckedComboBoxEdit
        Set(value As DevExpress.XtraEditors.CheckedComboBoxEdit)
            CtrlCombo2 = value
        End Set
    End Property

    Public WriteOnly Property CalledFromControl As Boolean
        Set(value As Boolean)
            CalledFromCtrl = value
        End Set
    End Property
    Private Sub cmdExit_Click(sender As Object, e As EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub

    Private Sub frmEpendisis_Load(sender As Object, e As EventArgs) Handles Me.Load
        'Κατηγορίες Ερμαρίων

        FillCbo.DOOR_TYPE(cboDoorType)
        Select Case Mode
            Case FormMode.NewRecord
                txtCode.Text = DBQ.GetNextId("SIDES")
            Case FormMode.EditRecord
                LoadForms.LoadForm(LayoutControl1, "Select * from vw_SIDES where id ='" + sID + "'")
        End Select
        Me.CenterToScreen()
        My.Settings.frmEpendisis = Me.Location
        My.Settings.Save()
        cmdSave.Enabled = IIf(Mode = FormMode.NewRecord, UserProps.AllowInsert, UserProps.AllowEdit)
        txtCustomCode.Select()
    End Sub

    Private Sub frmEpendisis_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        If Me.WindowState = FormWindowState.Maximized Then frmMain.XtraTabbedMdiManager1.Dock(Me, frmMain.XtraTabbedMdiManager1)
    End Sub

    Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click
        Dim sResult As Boolean
        Dim sGuid As String
        Try
            If Valid.ValidateForm(LayoutControl1) Then
                Select Case Mode
                    Case FormMode.NewRecord
                        sGuid = System.Guid.NewGuid.ToString
                        sResult = DBQ.InsertData(LayoutControl1, "SIDES", sGuid)
                    Case FormMode.EditRecord
                        sResult = DBQ.UpdateData(LayoutControl1, "SIDES", sID)
                        sGuid = sID
                End Select
                If CalledFromCtrl Then
                    FillCbo.SIDES(CtrlCombo)
                    CtrlCombo.EditValue = System.Guid.Parse(sGuid)
                Else
                    Dim form As frmScroller = Frm
                    form.LoadRecords("vw_SIDES")
                End If
                txtCustomCode.Select()
                If sResult = True Then
                    XtraMessageBox.Show("Η εγγραφή αποθηκέυτηκε με επιτυχία", "Dreamy Kitchen CRM", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    If Mode = FormMode.NewRecord Then
                        Cls.ClearCtrls(LayoutControl1)
                        txtCode.Text = DBQ.GetNextId("SIDES")
                    End If
                End If
            End If

        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), "Dreamy Kitchen CRM", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub cboDoorType_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboDoorType.ButtonClick
        Select Case e.Button.Index
            Case 1 : ManageDoorType()
            Case 2 : cboDoorType.EditValue = Nothing
        End Select
    End Sub
    Private Sub ManageDoorType()
        Dim frmDoorType As frmDoorType = New frmDoorType
        frmDoorType.CallerControl = cboDoorType
        frmDoorType.CalledFromControl = True
        If cboDoorType.EditValue <> Nothing Then frmDoorType.ID = cboDoorType.EditValue.ToString
        frmDoorType.MdiParent = frmMain
        If cboDoorType.EditValue <> Nothing Then frmDoorType.Mode = FormMode.EditRecord Else frmDoorType.Mode = FormMode.NewRecord
        frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(frmDoorType), New Point(CInt(frmDoorType.Parent.ClientRectangle.Width / 2 - frmDoorType.Width / 2), CInt(frmDoorType.Parent.ClientRectangle.Height / 2 - frmDoorType.Height / 2)))
        frmDoorType.Show()
    End Sub

    Private Sub txtPricePerMeter_EditValueChanged(sender As Object, e As EventArgs) Handles txtPricePerMeter.EditValueChanged
        Dim H As Decimal, W As Decimal, P As Decimal
        If txtHeight.EditValue Is Nothing Or txtWidth.EditValue Is Nothing Or txtPricePerMeter.EditValue Is Nothing Then Exit Sub
        H = txtHeight.EditValue.ToString.Replace(".", ",") : H = H / 100
        W = txtWidth.EditValue.ToString.Replace(".", ",") : W = W / 100
        P = txtPricePerMeter.EditValue.ToString.Replace(".", ",")
        txtTotPrice.EditValue = (H * W) * P
    End Sub
    
    Private Sub txtHeight_EditValueChanged(sender As Object, e As EventArgs) Handles txtHeight.EditValueChanged
        Dim H As Decimal, W As Decimal, P As Decimal
        If txtHeight.EditValue Is Nothing Or txtWidth.EditValue Is Nothing Or txtPricePerMeter.EditValue Is Nothing Then Exit Sub
        H = txtHeight.EditValue.ToString.Replace(".", ",") : H = H / 100
        W = txtWidth.EditValue.ToString.Replace(".", ",") : W = W / 100
        P = txtPricePerMeter.EditValue.ToString.Replace(".", ",")
        txtTotPrice.EditValue = (H * W) * P
    End Sub

    Private Sub txtWidth_EditValueChanged(sender As Object, e As EventArgs) Handles txtWidth.EditValueChanged
        Dim H As Decimal, W As Decimal, P As Decimal
        If txtHeight.EditValue Is Nothing Or txtWidth.EditValue Is Nothing Or txtPricePerMeter.EditValue Is Nothing Then Exit Sub
        H = txtHeight.EditValue.ToString.Replace(".", ",") : H = H / 100
        W = txtWidth.EditValue.ToString.Replace(".", ",") : W = W / 100
        P = txtPricePerMeter.EditValue.ToString.Replace(".", ",")
        txtTotPrice.EditValue = (H * W) * P
    End Sub
End Class