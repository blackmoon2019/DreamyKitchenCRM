Imports System.Data.SqlClient
Imports DevExpress.XtraBars.Navigation
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGrid.Views.Grid

Public Class frmParameters
    Private sID As String
    Private ManageCbo As New CombosManager
    Private Ctrl As DevExpress.XtraGrid.Views.Grid.GridView
    Private Frm As DevExpress.XtraEditors.XtraForm
    Public Mode As Byte
    Private Valid As New ValidateControls
    Private Cls As New ClearControls
    Private Prog_Prop As New ProgProp
    Private LoadForms As New FormLoader
    Private Parameters As New Parameters
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

    Private Sub frmParameters_Load(sender As Object, e As EventArgs) Handles Me.Load
        Parameters.Initialize(Me)
        Me.CenterToScreen()
    End Sub

    Private Sub frmParameters_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        If Me.WindowState = FormWindowState.Maximized Then frmMain.XtraTabbedMdiManager1.Dock(Me, frmMain.XtraTabbedMdiManager1)
    End Sub

    Private Sub V_BOX_COLOR_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles V_BOX_COLOR.ButtonClick

        Select Case e.Button.Index
            Case 1 : ManageCbo.ManageValueListItem(V_BOX_COLOR, FormMode.NewRecord, "DE86FD16-2154-4E2A-B025-4D34BDF8C808", "MATERIALS")
            Case 2 : ManageCbo.ManageValueListItem(V_BOX_COLOR, FormMode.EditRecord)
            Case 3 : V_BOX_COLOR.EditValue = Nothing
        End Select
    End Sub



    Private Sub K_BOX_COLOR_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles K_BOX_COLOR.ButtonClick
        Select Case e.Button.Index
            Case 1 : ManageCbo.ManageValueListItem(K_BOX_COLOR, FormMode.NewRecord, "DE86FD16-2154-4E2A-B025-4D34BDF8C808", "MATERIALS")
            Case 2 : ManageCbo.ManageValueListItem(K_BOX_COLOR, FormMode.EditRecord)
            Case 3 : K_BOX_COLOR.EditValue = Nothing
        End Select
    End Sub


    Private Sub Y_BOX_COLOR_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles Y_BOX_COLOR.ButtonClick
        Select Case e.Button.Index
            Case 1 : ManageCbo.ManageValueListItem(Y_BOX_COLOR, FormMode.NewRecord, "DE86FD16-2154-4E2A-B025-4D34BDF8C808", "MATERIALS")
            Case 2 : ManageCbo.ManageValueListItem(Y_BOX_COLOR, FormMode.EditRecord)
            Case 3 : Y_BOX_COLOR.EditValue = Nothing
        End Select
    End Sub

    Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSaveDefaultOffer.Click
        Parameters.SaveDefaultOffer()
    End Sub
    Private Sub cmdExit_Click(sender As Object, e As EventArgs) Handles cmdExitDefaultOffer.Click
        Me.Close()
    End Sub

    Private Sub cmdSaveGen_Click(sender As Object, e As EventArgs) Handles cmdSaveGen.Click
        Parameters.SaveDefaultGen()
    End Sub

    Private Sub TabPane2_SelectedPageChanged(sender As Object, e As SelectedPageChangedEventArgs) Handles TabPane2.SelectedPageChanged
        If Me.IsActive = False Then Exit Sub
        Select Case TabPane2.SelectedPageIndex
            Case 0 : Parameters.LoadDefaultGen()
            Case 1 : Parameters.LoadDefaultOffer()
            Case 2
                Parameters.LoadDefaultKitchenEquipment()
                Parameters.LoadDefaultClosetEquipment()
                Parameters.LoadDefaultOrder()
            Case 3 : Parameters.LoadDefaultEmailInstAndEllipse()
            Case 4 : Parameters.LoadDefaultEmailPJ()
            Case Else
        End Select
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Me.Close()
    End Sub

    Private Sub GridView2_PopupMenuShowing(sender As Object, e As PopupMenuShowingEventArgs) Handles GridView2.PopupMenuShowing
        If e.MenuType = GridMenuType.Column Then LoadForms.PopupMenuShow(e, GridView2, "CCT_ORDERS_KITCHEN_EQUIPMENT_PRM_def.xml", "vw_CCT_ORDERS_CLOSET_EQUIPMENT")
    End Sub
    Private Sub GridView1_PopupMenuShowing(sender As Object, e As PopupMenuShowingEventArgs) Handles GridView1.PopupMenuShowing
        If e.MenuType = GridMenuType.Column Then LoadForms.PopupMenuShow(e, GridView1, "CCT_ORDERS_KITCHEN_EQUIPMENT_CLOSET_PRM_def.xml", "vw_CCT_ORDERS_KITCHEN_EQUIPMENT")
    End Sub


    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles cmdExitDefaultOrder.Click
        Me.Close()
    End Sub

    Private Sub cmdSaveDefaultOrder_Click(sender As Object, e As EventArgs) Handles cmdSaveDefaultOrder.Click
        Select Case XtraTabControl2.SelectedTabPageIndex
            Case 0 : Parameters.SaveDefaultOrderGen()
            Case 1 : Parameters.SaveDefaultOrderCloset()
            Case 2 : Parameters.SaveDefaultOrderEquipment()
        End Select
    End Sub
    Private Sub SimpleButton2_Click_1(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub cmdSaveInstEmail_Click(sender As Object, e As EventArgs) Handles cmdSaveEmailInst.Click
        Parameters.SaveDefaultInstAndEllipseEmail()
    End Sub

    Private Sub cmdExitInstEmail_Click(sender As Object, e As EventArgs) Handles cmdExitInstEmail.Click
        Me.Close()
    End Sub

    Private Sub V_HEIGHT_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles V_HEIGHT.ButtonClick
        Select Case e.Button.Index
            Case 1 : V_HEIGHT.EditValue = Nothing
        End Select
    End Sub
    Private Sub K_HEIGHT_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles K_HEIGHT.ButtonClick
        Select Case e.Button.Index
            Case 1 : K_HEIGHT.EditValue = Nothing
        End Select
    End Sub
    Private Sub Y_HEIGHT_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles Y_HEIGHT.ButtonClick
        Select Case e.Button.Index
            Case 1 : Y_HEIGHT.EditValue = Nothing
        End Select
    End Sub
    Private Sub legs_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles LEGS.ButtonClick
        Select Case e.Button.Index
            Case 1 : LEGS.EditValue = Nothing
        End Select
    End Sub

    Private Sub CLOSET_BOX_COLOR_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles CLOSET_BOX_COLOR.ButtonClick
        Select Case e.Button.Index
            Case 1 : ManageCbo.ManageValueListItem(CLOSET_BOX_COLOR, FormMode.NewRecord, "DE86FD16-2154-4E2A-B025-4D34BDF8C808", "MATERIALS")
            Case 2 : ManageCbo.ManageValueListItem(CLOSET_BOX_COLOR, FormMode.EditRecord)
            Case 3 : CLOSET_BOX_COLOR.EditValue = Nothing
        End Select
    End Sub

    Private Sub cmdSaveEmailProjectJobs_Click(sender As Object, e As EventArgs) Handles cmdSaveEmailProjectJobs.Click
        Parameters.SaveDefaultProjectJobsEmail()
    End Sub

End Class