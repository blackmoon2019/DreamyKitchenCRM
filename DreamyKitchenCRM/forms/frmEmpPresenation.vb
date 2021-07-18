Imports System.Data.SqlClient
Imports DevExpress.Spreadsheet
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraSpreadsheet

Public Class frmEmpPresenation
    Private repository As RepositoryItemLookUpEdit
    Private Sub frmEmpMov_Load(sender As Object, e As EventArgs) Handles Me.Load
        'TODO: This line of code loads data into the 'DreamyKitchenDataSet.vw_EMP_S' table. You can move, or remove it, as needed.
        Me.Vw_EMP_STableAdapter.Fill(Me.DreamyKitchenDataSet.vw_EMP_S)
        Dim worksheet As Worksheet = SPR.ActiveWorksheet
        SPR.WorksheetDisplayArea.SetSize(SPR.ActiveWorksheet.Name, 33, 2)
        worksheet.Columns.Item(0).Width = 700
        worksheet.ActiveView.ShowHeadings = False
        Dim currentDate As Date = DateTime.Now
        lstMonths.SelectedIndex = currentDate.Month - 1
        dtFDate.EditValue = DateTime.Now
        FillDays()


    End Sub
    Private Sub FillEMP()
        Try
            Dim sSQL As String
            Dim i As Integer = 3
            sSQL = "Select ID,FullName from vw_EMP"
            Dim cmd As SqlCommand = New SqlCommand(sSQL, CNDB)
            Dim sdr As SqlDataReader = cmd.ExecuteReader()
            Dim worksheet As Worksheet = SPR.ActiveWorksheet
            While sdr.Read()
                worksheet.Rows.Insert(i)
                worksheet.Cells("A" & i).Value = sdr.Item(1).ToString
                worksheet.Cells("A" & i).Tag = sdr.Item(0).ToString
                i = i + 1
            End While
            SPR.WorksheetDisplayArea.SetSize(SPR.ActiveWorksheet.Name, 33, i - 1)
            worksheet.Range("A1:AK" & i - 1).Alignment.Horizontal = SpreadsheetHorizontalAlignment.Center
            worksheet.Range("A1:AK" & i - 1).Alignment.Vertical = SpreadsheetVerticalAlignment.Center
            worksheet.Range("A1:A2").Alignment.Horizontal = SpreadsheetHorizontalAlignment.Center
            sdr.Close()
        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), "Dreamy Kitchen CRM", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub SPR_CellBeginEdit(sender As Object, e As SpreadsheetCellCancelEventArgs) Handles SPR.CellBeginEdit
        If e.ColumnIndex = 0 Then e.Cancel = True
    End Sub
    Private Sub FillDays()
        If dtFDate.EditValue Is Nothing Then Exit Sub
        Dim i As Integer
        Dim days As Integer = System.DateTime.DaysInMonth(CDate(dtFDate.EditValue).Year, lstMonths.SelectedIndex + 1)
        Dim myCulture As System.Globalization.CultureInfo = Globalization.CultureInfo.CurrentCulture
        Dim worksheet As Worksheet = SPR.ActiveWorksheet
        For i = 1 To days
            Dim sDate As Date = i.ToString & "-" & lstMonths.SelectedIndex + 1 & "-" & dtFDate.Text
            Dim dayOfWeek As DayOfWeek = myCulture.Calendar.GetDayOfWeek(sDate)
            Dim dayName As String = myCulture.DateTimeFormat.GetDayName(dayOfWeek).Substring(0, 3)
            worksheet.Cells.Item(0, i).Value = dayName
            worksheet.Cells.Item(0, i).Alignment.Horizontal = SpreadsheetHorizontalAlignment.Center
            worksheet.Cells.Item(0, i).Alignment.Vertical = SpreadsheetVerticalAlignment.Center
            worksheet.Cells.Item(1, i).Value = i
            worksheet.Cells.Item(1, i).Alignment.Horizontal = SpreadsheetHorizontalAlignment.Center
            worksheet.Cells.Item(1, i).Alignment.Vertical = SpreadsheetVerticalAlignment.Center
            worksheet.Cells.Item(1, i).FillColor = Color.Black
            worksheet.Cells.Item(1, i).Font.Color = Color.White
            worksheet.Columns(i).Width = 150
        Next
        worksheet.Cells.Item(1, 0).Value = "ΥΠΑΛΛΗΛΟΙ"
        worksheet.MergeCells(worksheet.Range("A1:A2"))
        worksheet.Range("A1:A2").Alignment.Horizontal = SpreadsheetHorizontalAlignment.Center
        worksheet.Range("A1:A2").Alignment.Vertical = SpreadsheetVerticalAlignment.Center
        FillEMP()
    End Sub

    Private Sub lstMonths_SelectedValueChanged(sender As Object, e As EventArgs) Handles lstMonths.SelectedValueChanged
        FillDays()
    End Sub

    Private Sub dtFDate_EditValueChanged(sender As Object, e As EventArgs) Handles dtFDate.EditValueChanged
        FillDays()
    End Sub

    Private Sub SPR_CustomCellEdit(sender As Object, e As SpreadsheetCustomCellEditEventArgs) Handles SPR.CustomCellEdit
        repository = New RepositoryItemLookUpEdit
        repository.DataSource = Vw_EMP_SBindingSource
        Repository.DisplayMember = "shortName"
        Repository.ValueMember = "shortName"
        Repository.PopulateColumns()
        Repository.Columns.Item(0).Visible = False
        Repository.Columns.Item(1).Visible = False
        Repository.Columns.Item(2).Visible = True
        If e.ColumnIndex >= 1 AndAlso e.RowIndex > 1 Then
            e.RepositoryItem = repository
            AddHandler repository.EditValueChanged, AddressOf Repository_Changed
        End If
    End Sub
    Friend Sub Repository_Changed(sender As Object, e As EventArgs)
        Try
            Dim editor As DevExpress.XtraEditors.LookUpEdit = TryCast(sender, DevExpress.XtraEditors.LookUpEdit)
            Dim value As Object = editor.GetColumnValue("ID")
            Dim sDate As Date
            Dim recID As String
            sDate = SPR.ActiveWorksheet.Cells.Item(1, SPR.ActiveCell.ColumnIndex).Value.ToString & "-" & lstMonths.SelectedIndex + 1 & "-" & dtFDate.Text
            If value Is Nothing Then Exit Sub
            If SPR.ActiveCell.Tag Is Nothing Then
                recID = System.Guid.NewGuid.ToString
                SPR.ActiveCell.Tag = recID
            Else
                recID = SPR.ActiveCell.Tag
            End If
            Using oCmd As New SqlCommand("SaveEmp_P", CNDB)
                oCmd.CommandType = CommandType.StoredProcedure
                oCmd.Parameters.AddWithValue("@ID", recID)
                oCmd.Parameters.AddWithValue("@dtPresent", sDate)
                oCmd.Parameters.AddWithValue("@EmpID", SPR.ActiveWorksheet.Cells.Item(SPR.ActiveCell.RowIndex, 0).Tag)
                oCmd.Parameters.AddWithValue("@StatusID", value)
                oCmd.Parameters.AddWithValue("@user", UserProps.ID.ToString)
                oCmd.ExecuteNonQuery()
            End Using
        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), "Dreamy Kitchen CRM", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub frmEmpPresenation_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        If Me.WindowState = FormWindowState.Maximized Then frmMain.XtraTabbedMdiManager1.Dock(Me, frmMain.XtraTabbedMdiManager1)
    End Sub
End Class