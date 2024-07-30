

Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Grid

Public Class frmInstM
    Private InstM As New InstM
    Private sID As String
    Private sInstID As String
    Private Ctrl As DevExpress.XtraGrid.Views.Grid.GridView
    Private Frm As DevExpress.XtraEditors.XtraForm
    Public Mode As Byte
    Private FScrollerExist As Boolean = False
    Private ManageCbo As New CombosManager
    Private DBQ As New DBQueries
    Private LoadForms As New FormLoader
    Private CtrlCombo As DevExpress.XtraEditors.LookUpEdit
    Private CalledFromCtrl As Boolean
    Public WriteOnly Property ID As String
        Set(value As String)
            sID = value
        End Set
    End Property
    Public WriteOnly Property InstID As String
        Set(value As String)
            sInstID = value
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

    Private Sub frmInstM_Load(sender As Object, e As EventArgs) Handles Me.Load
        InstM.Initialize(Me, sID, Mode)
        InstM.LoadForm()
        Me.CenterToScreen()
    End Sub

    Private Sub cboSER_EditValueChanged(sender As Object, e As EventArgs) Handles cboSER.EditValueChanged
        If cboSER.EditValue Is Nothing Then Exit Sub
        Me.Vw_INSTPerSerTableAdapter.Fill(Me.DreamyKitchenDataSet.vw_INSTPerSer, System.Guid.Parse(cboSER.EditValue.ToString))
    End Sub


    Private Sub GridView3_PopupMenuShowing(sender As Object, e As PopupMenuShowingEventArgs) Handles GridView3.PopupMenuShowing
        If e.MenuType = GridMenuType.Column Then LoadForms.PopupMenuShow(e, GridView3, "INSTPERSER.xml", "vw_INST_COST")
    End Sub

    Private Sub frmInstM_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        If Me.WindowState = FormWindowState.Maximized Then frmMain.XtraTabbedMdiManager1.Dock(Me, frmMain.XtraTabbedMdiManager1)
    End Sub

    Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click
        InstM.SaveRecord(sID)
    End Sub

    Private Sub GridView3_RowClick(sender As Object, e As RowClickEventArgs) Handles GridView3.RowClick
        txtCost.EditValue = GridView3.GetRowCellValue(GridView3.FocusedRowHandle, "YPOL")
        dtDeliverDate.EditValue = GridView3.GetRowCellValue(GridView3.FocusedRowHandle, "dtDeliverDate")
    End Sub

    Private Sub cboSER_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboSER.ButtonClick
        Select Case e.Button.Index
            Case 1 : ManageCbo.ManageExtPartners(cboSER, FormMode.NewRecord)
            Case 2 : ManageCbo.ManageExtPartners(cboSER, FormMode.EditRecord)
            Case 3 : cboSER.EditValue = Nothing
        End Select
    End Sub

End Class