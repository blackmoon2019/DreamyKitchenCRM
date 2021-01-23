
Imports System.Data.SqlClient
Imports DevExpress.Utils
Imports DevExpress.XtraBars
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Columns

Public Class frmNotesScroller
    Private myReader As SqlDataReader
    Private myCmd As SqlCommand
    Private Sub frmNotesScroller_Load(sender As Object, e As EventArgs) Handles Me.Load
        'Dim strSql As String = "SELECT *  FROM vw_NOTES where UserID = " & toSQLValueS(UserProps.ID.ToString)
        'Dim dtb As New DataTable
        'Using dad As New SqlDataAdapter(strSql, CNDB)
        '    dad.Fill(dtb)
        'End Using

        Me.Vw_NOTESTableAdapter.FillBy1(Me.DreamyKitchenDataSet.vw_NOTES, UserProps.SalerID, UserProps.ID)
        Me.Text = "Εισερχόμενα/Εξερχόμενα Σημειώματα"
        'Εαν δεν υπάρχει Default Σχέδιο δημιουργεί
        If My.Computer.FileSystem.FileExists(Application.StartupPath & "\DSGNS\DEF\vw_NOTES_def.xml") = False Then
            GridView1.SaveLayoutToXml(Application.StartupPath & "\DSGNS\DEF\vw_NOTES_def.xml", OptionsLayoutBase.FullLayout)
        Else
            GridView1.RestoreLayoutFromXml(Application.StartupPath & "\DSGNS\DEF\vw_NOTES_def.xml", OptionsLayoutBase.FullLayout)
        End If
        'Δικαιώματα
        BarNewRec.Enabled = UserProps.AllowInsert
        BarDelete.Enabled = UserProps.AllowDelete
        BarEdit.Enabled = UserProps.AllowEdit

    End Sub

    Private Sub BarNewRec_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarNewRec.ItemClick
        Dim form1 As frmNotes = New frmNotes()
        form1.Text = "Σημειώματα"
        form1.MdiParent = frmMain
        form1.Mode = FormMode.NewRecord
        form1.Scroller = GridView1
        form1.FormScroller = Me
        frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(form1), New Point(CInt(Me.Parent.ClientRectangle.Width / 2 - Me.Width / 2), CInt(Me.Parent.ClientRectangle.Height / 2 - Me.Height / 2)))
        form1.Show()
    End Sub
    Public Sub LoadRecords(Optional ByVal sDataTable As String = "", Optional ByVal sWhere As String = "")
        Dim sSQL As String
        Try
            sSQL = "SELECT  * FROM " & sDataTable & " " & sWhere

            myCmd = CNDB.CreateCommand
            myCmd.CommandText = sSQL
            GridView1.Columns.Clear()
            myReader = myCmd.ExecuteReader()
            grdMain.DataSource = myReader
            grdMain.DefaultView.PopulateColumns()

            'Εαν δεν έχει data το Dataset αναγκαστικά προσθέτω μόνος μου τις στήλες
            If myReader.HasRows = False Then
                'For i As Integer = 0 To myReader.FieldCount - 1
                '    Dim C As New GridColumn
                '    C.Name = myReader.GetName(i).ToString
                '    C.Caption = myReader.GetName(i).ToString
                '    C.Visible = True
                '    GridView1.Columns.Add(C)
                'Next i
            End If
            'LoadViews()
            GridView1.RestoreLayoutFromXml(Application.StartupPath & "\DSGNS\DEF\vw_NOTES_def.xml", OptionsLayoutBase.FullLayout)
        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), "Dreamy Kitchen CRM", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        'If grdMain.DefaultView.DataRowCount <> 0 Then myReader.Close() 'myReader.Close()
    End Sub

    Private Sub GridView1_DoubleClick(sender As Object, e As EventArgs) Handles GridView1.DoubleClick
        EditRecord()
    End Sub
    'Διαγραφη Εγγραφής
    Private Sub DeleteRecord()
        Dim sSQL As String
        Try
            If GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "ID") = Nothing Then Exit Sub
            If XtraMessageBox.Show("Θέλετε να διαγραφεί η τρέχουσα εγγραφή?", "Dreamy Kitchen CRM", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                sSQL = "DELETE FROM NOTES WHERE ID = '" & GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "ID").ToString & "'"

                Using oCmd As New SqlCommand(sSQL, CNDB)
                    oCmd.ExecuteNonQuery()
                End Using
                LoadRecords("vw_NOTES", "where (salerid = '" & UserProps.SalerID.ToString & "' or createdby = '" & UserProps.ID.ToString & "')")
                XtraMessageBox.Show("Η εγγραφή διαγράφηκε με επιτυχία", "Dreamy Kitchen CRM", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), "Dreamy Kitchen CRM", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    'Επεξεργασία Εγγραφής
    Private Sub EditRecord()
        Dim form10 As frmNotes = New frmNotes()
        form10.Text = "Σημειώματα"
        form10.ID = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "ID").ToString
        form10.MdiParent = frmMain
        form10.Mode = FormMode.EditRecord
        form10.Scroller = GridView1
        form10.FormScroller = Me
        frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(form10), New Point(CInt(Me.Parent.ClientRectangle.Width / 2 - Me.Width / 2), CInt(Me.Parent.ClientRectangle.Height / 2 - Me.Height / 2)))
        form10.Show()
    End Sub
    Private Sub BarDelete_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarDelete.ItemClick
        DeleteRecord()
    End Sub

    Private Sub BarRefresh_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarRefresh.ItemClick
        'LoadRecords("vw_NOTES")
        LoadRecords("vw_NOTES", "where (salerid = '" & UserProps.SalerID.ToString & "' or createdby = '" & UserProps.ID.ToString & "')")
        Me.Text = "Εισερχόμενα/Εξερχόμενα Σημειώματα"
    End Sub

    Private Sub BarEdit_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BarEdit.ItemClick
        EditRecord()
    End Sub

    Private Sub BarIncoming_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BarIncoming.ItemClick
        LoadRecords("vw_NOTES", "where (salerid = '" & UserProps.SalerID.ToString & "')")
        Me.Text = "Εισερχόμενα Σημειώματα"
    End Sub

    Private Sub BarOutgoing_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BarOutgoing.ItemClick
        LoadRecords("vw_NOTES", "where (createdby = '" & UserProps.ID.ToString & "')")
        Me.Text = "Εξερχόμενα Σημειώματα"
    End Sub
End Class