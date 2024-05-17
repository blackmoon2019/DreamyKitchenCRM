Imports DevExpress.XtraCharts

Public Class frmEpopteiaChart
    Private FillCbo As New FillCombos
    Private Sub frmEpopteiaChart_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DreamyKitchenDataSet.vw_CCT' table. You can move, or remove it, as needed.
        Me.Vw_CCTTableAdapter.Fill(Me.DreamyKitchenDataSet.vw_CCT)
        'TODO: This line of code loads data into the 'DreamyKitchenDataSet.vw_EPOPTEIA' table. You can move, or remove it, as needed.
        Me.Vw_EPOPTEIATableAdapter.Fill(Me.DreamyKitchenDataSet.vw_EPOPTEIA)
        ChartControl1.Series(0).FilterString = "FullTranshDescription=''"
        ChartControl1.Series(1).FilterString = "FullTranshDescription=''"
        ChartControl1.Series(2).FilterString = "FullTranshDescription=''"
        ChartControl1.Series(3).FilterString = "FullTranshDescription=''"

        Me.CenterToScreen()
    End Sub
    Private Sub cboCUS_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles cboCUS.ButtonClick
        Select Case e.Button.Index
            Case 1 : cboCUS.EditValue = Nothing : ManageCus()
            Case 2 : If cboCUS.EditValue isnot Nothing Then ManageCus()
            Case 3 : cboCUS.EditValue = Nothing
        End Select
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
    Private Sub cboCUS_EditValueChanged_1(sender As Object, e As EventArgs) Handles cboCUS.EditValueChanged
        Dim sCusID As String
        If cboCUS.EditValue Is Nothing Then sCusID = toSQLValueS(Guid.Empty.ToString) Else sCusID = toSQLValueS(cboCUS.EditValue.ToString)
        Dim sSQL As New System.Text.StringBuilder
        sSQL.AppendLine("Select T.id,FullTranshDescription,Description
                        from vw_TRANSH t
                        where  T.cusid = " & sCusID & "order by description")
        FillCbo.TRANSH(cboTRANSH, sSQL)

    End Sub

    Private Sub cboTRANSH_EditValueChanged(sender As Object, e As EventArgs) Handles cboTRANSH.EditValueChanged
        ChartControl1.Series(0).FilterString = "FullTranshDescription=" & toSQLValueS(cboTRANSH.Text.ToString)
        ChartControl1.Series(1).FilterString = "FullTranshDescription=" & toSQLValueS(cboTRANSH.Text.ToString)
        ChartControl1.Series(2).FilterString = "FullTranshDescription=" & toSQLValueS(cboTRANSH.Text.ToString)
        ChartControl1.Series(3).FilterString = "FullTranshDescription=" & toSQLValueS(cboTRANSH.Text.ToString)
    End Sub

    Private Sub frmEpopteiaChart_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        If Me.WindowState = FormWindowState.Maximized Then frmMain.XtraTabbedMdiManager1.Dock(Me, frmMain.XtraTabbedMdiManager1)
    End Sub
End Class