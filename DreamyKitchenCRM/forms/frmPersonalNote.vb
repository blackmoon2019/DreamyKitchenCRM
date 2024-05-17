
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls

Public Class frmPersonalNote
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

    Private Sub frmPersonalNote_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim sSQL As New System.Text.StringBuilder
        FillCbo.SALER_CAL_STATUS(cboStatus)

        Select Case Mode
            Case FormMode.NewRecord
                txtCode.Text = DBQ.GetNextId("SALER_CALENDAR")
                'dtInsertedDate.EditValue = Date.Now
            Case FormMode.EditRecord
                LoadForms.LoadForm(LayoutControl1, "Select * from vw_SALER_CALENDAR where id ='" + sID + "'")
        End Select
        Me.CenterToScreen()
        cmdSave.Enabled = IIf(Mode = FormMode.NewRecord, UserProps.AllowInsert, UserProps.AllowEdit)

    End Sub

    Private Sub frmPersonalNote_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        If Me.WindowState = FormWindowState.Maximized Then frmMain.XtraTabbedMdiManager1.Dock(Me, frmMain.XtraTabbedMdiManager1)
    End Sub
    Private Sub ManageSALER_CAL_STATUS()
        Dim form1 As frmGen = New frmGen()
        form1.Text = "Status Προσωπικού Ημερολογίου"
        form1.L1.Text = "Κωδικός"
        form1.L2.Text = "Status"
        form1.L6.Text = "Χρώμα"
        form1.DataTable = "SALER_CAL_STATUS"
        form1.CallerControl = cboStatus
        form1.CalledFromControl = True
        form1.L6.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
        If cboStatus.EditValue isnot Nothing Then form1.ID = cboStatus.EditValue.ToString
        form1.MdiParent = frmMain
        If cboStatus.EditValue isnot Nothing Then form1.Mode = FormMode.EditRecord Else form1.Mode = FormMode.NewRecord
        frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(form1), New Point(CInt(form1.Parent.ClientRectangle.Width / 2 - form1.Width / 2), CInt(form1.Parent.ClientRectangle.Height / 2 - form1.Height / 2)))
        form1.Show()
    End Sub
    Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click
        Dim sResult As Boolean
        Dim sGuid As String
        Try
            If Valid.ValidateForm(LayoutControl1) Then
                Select Case Mode
                    Case FormMode.NewRecord
                        sGuid = System.Guid.NewGuid.ToString
                        sResult = DBQ.InsertNewData(DBQueries.InsertMode.OneLayoutControl, "SALER_CALENDAR", LayoutControl1,,, sGuid,, "empID", toSQLValueS(System.Guid.Parse(UserProps.EmpID.ToString).ToString))
                    Case FormMode.EditRecord
                        sResult = DBQ.UpdateNewData(DBQueries.InsertMode.OneLayoutControl, "SALER_CALENDAR", LayoutControl1,,, sID, True)
                        sGuid = sID
                End Select
                txtCode.Text = DBQ.GetNextId("SALER_CALENDAR")
                If FScrollerExist = True Then
                    Dim form As frmScroller = Frm
                    form.LoadRecords("vw_SALER_CAL_STATUS")
                End If

                If sResult = True Then XtraMessageBox.Show("Η εγγραφή αποθηκέυτηκε με επιτυχία", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Information)
                If Mode = FormMode.NewRecord Then Cls.ClearCtrls(LayoutControl1)
            End If

        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cboStatus_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboStatus.ButtonClick
        Select Case e.Button.Index
            Case 1 : cboStatus.EditValue = Nothing : ManageSALER_CAL_STATUS()
            Case 2 : If cboStatus.EditValue isnot Nothing Then ManageSALER_CAL_STATUS()
            Case 3 : cboStatus.EditValue = Nothing
        End Select
    End Sub
End Class