Imports DevExpress.XtraGrid.Views.Grid

Public Class frmAgreementCheckList
    Private AgreementCheckList As New AgreementCheckList
    Private LoadForms As New FormLoader
    Private sID As String
    Public Mode As Byte

    Public WriteOnly Property ID As String
        Set(value As String)
            sID = value
        End Set
    End Property

    Private Sub frmAgreementCheckList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AgreementCheckList.Initialize(Me, sID, Mode)
        AgreementCheckList.LoadForm()
        Me.CenterToScreen()

    End Sub

    Private Sub cmdSaveEquipDev_Click(sender As Object, e As EventArgs) Handles cmdSave.Click
        AgreementCheckList.InsertSelectedRows()
    End Sub

    Private Sub GridView4_PopupMenuShowing(sender As Object, e As PopupMenuShowingEventArgs) Handles GridView4.PopupMenuShowing
        If e.MenuType = GridMenuType.Column Then LoadForms.PopupMenuShow(e, GridView4, "vw_AGREEMENT_CHECKLIST_def.xml", "vw_PROJECTCHECKLIST")
    End Sub

    Private Sub cmdExit_Click(sender As Object, e As EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub
End Class