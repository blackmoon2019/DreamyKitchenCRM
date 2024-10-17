Imports System.Data.SqlClient
Imports DevExpress.XtraBars.Navigation
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraExport.Helpers
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraReports.UI
Public Class frmSUPOrders
    Private SupOrders As New SupOrders
    Private ManageCbo As New CombosManager
    Private Valid As New ValidateControls
    Private FillCbo As New FillCombos
    Private LoadForms As New FormLoader
    Private Ctrl As DevExpress.XtraGrid.Views.Grid.GridView
    Private Frm As DevExpress.XtraEditors.XtraForm
    Private CtrlCombo As DevExpress.XtraEditors.LookUpEdit
    Private sID As String
    Private sComeFrom As Int16
    Public Mode As Byte
    Private sFields As New Dictionary(Of String, String)
    Private FScrollerExist As Boolean = False
    Private CalledFromCtrl As Boolean
    Public WriteOnly Property ID As String
        Set(value As String)
            sID = value
        End Set
    End Property
    Public Property ComeFrom() As Int16
        Get
            Return sComeFrom
        End Get
        Set(value As Int16)
            sComeFrom = value
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
    Private Sub frmSUPOrders_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SupOrders.Initialize(Me, sID, Mode)
        SupOrders.LoadForm()
        Me.CenterToScreen()
    End Sub
    Private Sub cboEMP_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboEMP.ButtonClick
        Select Case e.Button.Index
            Case 1 : ManageCbo.ManageEMP(cboEMP, FormMode.NewRecord)
            Case 2 : ManageCbo.ManageEMP(cboEMP, FormMode.EditRecord)
            Case 3 : cboEMP.EditValue = Nothing
        End Select
    End Sub
    Private Sub cboCUS_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboCUS.ButtonClick
        Select Case e.Button.Index
            Case 1 : ManageCbo.ManageCCT(FormMode.NewRecord, False,, cboCUS)
            Case 2 : ManageCbo.ManageCCT(FormMode.EditRecord, False,, cboCUS)
            Case 3 : cboCUS.EditValue = Nothing
        End Select
    End Sub
    Private Sub cboCUS_EditValueChanged(sender As Object, e As EventArgs) Handles cboCUS.EditValueChanged
        txtPhn.EditValue = cboCUS.GetColumnValue("phn")
        txtArea.EditValue = cboCUS.GetColumnValue("AREAS_Name")
        txtADR.EditValue = cboCUS.GetColumnValue("ADR_Name")
        Dim sCusID As String
        If cboCUS.EditValue Is Nothing Then sCusID = toSQLValueS(Guid.Empty.ToString) Else sCusID = toSQLValueS(cboCUS.EditValue.ToString)
        Dim sSQL As New System.Text.StringBuilder
        sSQL.AppendLine("Select T.id,FullTranshDescription,Description,offerCusAcceptance
                        from vw_TRANSH t
                        where  T.cusid = " & sCusID & "order by description")
        FillCbo.TRANSH(cboTRANSH, sSQL)

    End Sub
    Private Sub cboTRANSH_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboTRANSH.ButtonClick
        Select Case e.Button.Index
            Case 1 : ManageCbo.ManageTRANSH(cboTRANSH, FormMode.NewRecord)
            Case 2 : ManageCbo.ManageTRANSH(cboTRANSH, FormMode.EditRecord)
            Case 3 : cboTRANSH.EditValue = Nothing
        End Select
    End Sub

    Private Sub frmSUPOrders_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        If Me.WindowState = FormWindowState.Maximized Then frmMain.XtraTabbedMdiManager1.Dock(Me, frmMain.XtraTabbedMdiManager1)
    End Sub
    Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click
        SupOrders.SaveRecord()
    End Sub
    Private Sub GridView1_KeyDown(sender As Object, e As KeyEventArgs) Handles GridView1.KeyDown
        Select Case e.KeyCode
            Case Keys.Delete : SupOrders.DeleteRecord()
        End Select
    End Sub
    Private Sub GridControl1_DoubleClick(sender As Object, e As EventArgs) Handles GridControl1.DoubleClick
        SupOrders.OpenFile()
    End Sub

    Private Sub txtFiles_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles txtFiles.ButtonClick
        If e.Button.Index = 0 Then SupOrders.FilesSelection() Else txtFiles.EditValue = Nothing
    End Sub


    Private Sub cmdSendEmail_Click(sender As Object, e As EventArgs) Handles cmdSendEmail.Click
        SupOrders.ValidateEmail()
    End Sub
    Private Sub TabPane1_SelectedPageChanged(sender As Object, e As SelectedPageChangedEventArgs) Handles TabPane1.SelectedPageChanged
        Select Case TabPane1.SelectedPageIndex
            Case 1 : SupOrders.EmailTabSelected()
            Case 2 : SupOrders.FilesTabSelected()
        End Select
    End Sub

    Private Sub GridView1_PopupMenuShowing(sender As Object, e As DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs) Handles GridView1.PopupMenuShowing
        If e.MenuType = GridMenuType.Column Then LoadForms.PopupMenuShow(e, GridView1, "vw_SUP_ORDERS_F_def.xml",, "select top 1 [filename], [RealName], [code], [comefrom], [extension], [modifiedOn], [createdOn], [ID], [supOrderID]  from vw_SUP_ORDERS_F")
    End Sub

    Private Sub GridView2_PopupMenuShowing(sender As Object, e As DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs) Handles GridView2.PopupMenuShowing
        If e.MenuType = GridMenuType.Column Then LoadForms.PopupMenuShow(e, GridView2, "SUP_ORDERS_MAIL_def.xml",, "select top 1 [ID], [code], [supOrderID], [emailFrom], [emailTo], [emailSubject], [emailBody], [DateOfEmail], [createdOn], [createdBy]  from SUP_ORDERS_MAIL")
    End Sub

    Private Sub cmdPrintAll_Click(sender As Object, e As EventArgs) Handles cmdPrintAll.Click
        SupOrders.PrintAll()
    End Sub

    Private Sub GridView3_ValidateRow(sender As Object, e As ValidateRowEventArgs) Handles GridView3.ValidateRow
        SupOrders.SaveRecordD(e)
    End Sub

    Private Sub GridView3_PopupMenuShowing(sender As Object, e As PopupMenuShowingEventArgs) Handles GridView3.PopupMenuShowing
        If e.MenuType = GridMenuType.Column Then LoadForms.PopupMenuShow(e, GridView3, "SUP_ORDERS_D_def.xml", "SUP_ORDERSD")
    End Sub

    Private Sub GridView3_KeyDown(sender As Object, e As KeyEventArgs) Handles GridView3.KeyDown
        If e.KeyCode = Keys.Delete And UserProps.AllowDelete = True Then SupOrders.DeleteRecordD()
    End Sub

    Private Sub cmdSaveTransF_Click(sender As Object, e As EventArgs) Handles cmdSaveTransF.Click

    End Sub

    Private Sub RepFiles_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles RepFiles.ButtonClick
        Select Case e.Button.Index
            Case 0 : SupOrders.FilesSelection() : GridView3.SetRowCellValue(GridView3.FocusedRowHandle, "HasFiles", 1)
            Case 1 : SupOrders.OpenFiles()
            Case 2 : SupOrders.DeleteRecordF()
        End Select
    End Sub
End Class