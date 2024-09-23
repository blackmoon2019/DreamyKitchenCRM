Imports DevExpress.XtraExport.Helpers
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo

Public Class frmPriceListsKeywords
    Private sSUP_ID As String
    Private LoadForms As New FormLoader
    Private PriceListKeyword As New PriceListKeyWordsKanelopoulos
    Public WriteOnly Property SUP_ID As String
        Set(value As String)
            sSUP_ID = value
        End Set
    End Property
    Private Sub frmPriceListsKeywords_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Vw_VALUELISTTableAdapter.Fill(Me.DM_VALUELISTITEM.vw_VALUELIST)
        AddHandler GridControl1.EmbeddedNavigator.ButtonClick, AddressOf Grid_EmbeddedNavigator_ButtonClick
        Select Case sSUP_ID
            Case "89251045-64C7-4E35-9CAF-51D020279CFE" ' ΚΑΝΕΛΛΟΠΟΥΛΟΣ
                PriceListKeyword.SUP_ID = sSUP_ID
                PriceListKeyword.Initialize(Me)
                LoadForms.RestoreLayoutFromXml(GridView1, "KanellopoulosPriceListKeywords.xml")
        End Select
    End Sub
    Private Sub GridView1_ValidateRow(sender As Object, e As ValidateRowEventArgs) Handles GridView1.ValidateRow
        Select Case sSUP_ID
            Case "89251045-64C7-4E35-9CAF-51D020279CFE" ' ΚΑΝΕΛΛΟΠΟΥΛΟΣ
                PriceListKeyword.SaveRecord(e)
        End Select
    End Sub
    Private Sub Grid_EmbeddedNavigator_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.NavigatorButtonClickEventArgs)
        Select Case e.Button.ButtonType
            Case e.Button.ButtonType.Remove : PriceListKeyword.DeleteRecord() : e.Handled = True
            Case e.Button.ButtonType.Append
        End Select
    End Sub

    Private Sub GridView1_KeyDown(sender As Object, e As KeyEventArgs) Handles GridView1.KeyDown
        If e.KeyCode = Keys.Delete And UserProps.AllowDelete = True Then PriceListKeyword.DeleteRecord()
        If e.KeyCode = Keys.Down And UserProps.AllowInsert Then
            If sender.FocusedRowHandle < 0 Then Exit Sub
            Dim viewInfo As GridViewInfo = TryCast(sender.GetViewInfo(), GridViewInfo)
            If sender.FocusedRowHandle = viewInfo.RowsInfo.Last().RowHandle Then
                GridView1.PostEditor() : GridView1.AddNewRow()
            End If
        End If
    End Sub
    Private Sub GridView1_PopupMenuShowing(sender As Object, e As DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs) Handles GridView1.PopupMenuShowing
        If e.MenuType = GridMenuType.Column Then LoadForms.PopupMenuShow(e, GridView1, "KanellopoulosPriceListKeywords.xml", "PRICELISTS_KEYWORDS")
    End Sub

End Class