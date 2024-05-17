Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls

Public Class frmBench
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
    Private CalledFromCtrl As Boolean
    Private CallerFormName As String


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
    Public WriteOnly Property CallerForm As String
        Set(value As String)
            CallerFormName = value
        End Set
    End Property
    Private Sub cmdExit_Click(sender As Object, e As EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub

    Private Sub frmBench_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        If Me.WindowState = FormWindowState.Maximized Then frmMain.XtraTabbedMdiManager1.Dock(Me, frmMain.XtraTabbedMdiManager1)
    End Sub

    Private Sub frmBench_Load(sender As Object, e As EventArgs) Handles Me.Load
        FillCbo.DIMENSION(cboDim)
        'Πάγκοι
        Select Case Mode
            Case FormMode.NewRecord
                txtCode.Text = DBQ.GetNextId("BENCH")
            Case FormMode.EditRecord
                LoadForms.LoadForm(LayoutControl1, "Select * from vw_BENCH where id ='" + sID + "'")
        End Select
        Me.CenterToScreen()
        cmdSave.Enabled = IIf(Mode = FormMode.NewRecord, UserProps.AllowInsert, UserProps.AllowEdit)
        txtCustomCode.Select()

    End Sub

    Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click
        Dim sResult As Boolean
        Dim sGuid As String
        Try
            If Valid.ValidateForm(LayoutControl1) Then
                Select Case Mode
                    Case FormMode.NewRecord
                        sGuid = System.Guid.NewGuid.ToString
                        sResult = DBQ.InsertData(LayoutControl1, "BENCH", sGuid)
                    Case FormMode.EditRecord
                        sResult = DBQ.UpdateData(LayoutControl1, "BENCH", sID)
                        sGuid = sID
                End Select
                If CalledFromCtrl Then
                    FillCbo.BENCH(CtrlCombo)
                    CtrlCombo.EditValue = System.Guid.Parse(sGuid)
                Else
                    Dim form As frmScroller = Frm
                    form.LoadRecords("vw_BENCH")
                End If
                txtCustomCode.Select()
                If sResult = True Then
                    XtraMessageBox.Show("Η εγγραφή αποθηκέυτηκε με επιτυχία", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Cls.ClearCtrls(LayoutControl1)
                    txtCode.Text = DBQ.GetNextId("BENCH")
                End If
            End If

        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub cboDim_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboDim.ButtonClick
        Select Case e.Button.Index
            Case 1 : cboDim.EditValue = Nothing : ManageDIM()
            Case 2 : If cboDim.EditValue isnot Nothing Then ManageDIM()
            Case 3 : cboDim.EditValue = Nothing
        End Select
    End Sub
    Private Sub ManageDIM()
        Dim form1 As frmGen = New frmGen()
        form1.Text = "Διάσταση"
        form1.L1.Text = "Κωδικός"
        form1.L2.Text = "Διάσταση"
        form1.DataTable = "DIM"
        form1.CallerControl = cboDim
        form1.CalledFromControl = True
        If cboDim.EditValue isnot Nothing Then form1.ID = cboDim.EditValue.ToString
        form1.MdiParent = frmMain
        If cboDim.EditValue isnot Nothing Then form1.Mode = FormMode.EditRecord Else form1.Mode = FormMode.NewRecord
        frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(form1), New Point(CInt(form1.Parent.ClientRectangle.Width / 2 - form1.Width / 2), CInt(form1.Parent.ClientRectangle.Height / 2 - form1.Height / 2)))
        form1.Show()
    End Sub
End Class