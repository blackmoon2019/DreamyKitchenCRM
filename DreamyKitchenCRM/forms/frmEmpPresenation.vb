Imports System.Data.SqlClient
Imports System.IO
Imports DevExpress.Spreadsheet
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraPrinting
Imports DevExpress.XtraSpreadsheet

Public Class frmEmpPresentation
    Private repository As RepositoryItemLookUpEdit
    Private LastDetailRow As Integer
    Private bIsConstr As Boolean

    Public WriteOnly Property IsConstr As Boolean
        Set(value As Boolean)
            bIsConstr = value
        End Set
    End Property
    Private Sub frmEmpMov_Load(sender As Object, e As EventArgs) Handles Me.Load
        'TODO: This line of code loads data into the 'DreamyKitchenDataSet.vw_EMP_S' table. You can move, or remove it, as needed.
        Me.Vw_EMP_STableAdapter.Fill(Me.DreamyKitchenDataSet.vw_EMP_S)
        If bIsConstr = True Then
            Me.Vw_EMPTableAdapter.Fill(Me.DreamyKitchenDataSet.vw_EMP, System.Guid.Parse("16228C6D-FAE6-4CFD-82D1-A9910D909952"))
        Else
            Me.Vw_EMPTableAdapter.Fill(Me.DreamyKitchenDataSet.vw_EMP, System.Guid.Parse("9812E975-2FD4-4653-B043-3D6CAF440888"))
        End If

        Dim worksheet As Worksheet = SPR.ActiveWorksheet
        SPR.WorksheetDisplayArea.SetSize(SPR.ActiveWorksheet.Name, 32, 2)
        worksheet.Columns.Item(0).Width = 700
        worksheet.ActiveView.ShowHeadings = False
        Dim currentDate As Date = DateTime.Now
        lstMonths.SelectedIndex = currentDate.Month - 1
        dtFDate.EditValue = DateTime.Now
        'dtFDate.Text = DateTime.Now.Year.ToString
        'SPR.BeginUpdate()
        'FillDays()
        'SPR.EndUpdate()

    End Sub
    Private Sub FillEMP()
        Try
            Dim sSQL As String
            Dim i As Integer = 3
            Dim emp_s As Int16
            Dim StatusCols As New List(Of String)
            If bIsConstr = True Then
                sSQL = "Select ID,FullName from vw_EMP where active=1 and depid='16228C6D-FAE6-4CFD-82D1-A9910D909952' order by 2"
            Else
                sSQL = "Select ID,FullName from vw_EMP where active=1 and depid='9812E975-2FD4-4653-B043-3D6CAF440888' order by 2"
            End If

            Dim cmd As SqlCommand = New SqlCommand(sSQL, CNDB)
            Dim sdr As SqlDataReader = cmd.ExecuteReader()
            Dim worksheet As Worksheet = SPR.ActiveWorksheet
            While sdr.Read()
                worksheet.Rows.Insert(i)
                worksheet.Cells("A" & i).Value = sdr.Item(1).ToString
                worksheet.Cells("A" & i).Tag = sdr.Item(0).ToString
                FillEmp_P(sdr.Item(0).ToString, i - 1)
                i = i + 1
            End While
            LastDetailRow = i

            worksheet.Range("A1:AK" & i - 1).Alignment.Horizontal = SpreadsheetHorizontalAlignment.Center
            worksheet.Range("A1:AK" & i - 1).Alignment.Vertical = SpreadsheetVerticalAlignment.Center
            worksheet.Range("A1:A2").Alignment.Horizontal = SpreadsheetHorizontalAlignment.Center
            sdr.Close()
            '*****************ΣΥΓΚΕΝΤΡΩΤΙΚΑ ΑΠΟΤΕΛΕΣΜΑΤΑ*******************
            'i + 3= Πάμε 3 γραμμές παρακάτω από εκεί που τελείωσε για να γράψουμε τον τίτλο
            Dim Row As Integer
            Row = i + 3
            worksheet.Rows.Insert(Row)
            worksheet.Range("A" & Row).Value = "ΣΥΓΚΕΝΤΡΩΤΙΚΑ ΑΝΑ STATUS"
            ' Παίρνω το πλήθος των Status ώστε να κάνω το merge της στήλης
            cmd = New SqlCommand("SELECT COUNT(*) AS CountS FROM EMP_S", CNDB)
            emp_s = Convert.ToInt16(cmd.ExecuteScalar())
            Dim CellRange As CellRange = worksheet.Range.FromLTRB(0, Row - 1, emp_s, Row - 1)
            worksheet.MergeCells(CellRange)
            CellRange.Alignment.Horizontal = SpreadsheetHorizontalAlignment.Center
            CellRange.Alignment.Vertical = SpreadsheetHorizontalAlignment.Center
            CellRange.Borders.SetAllBorders(Color.Black, 2)
            CellRange.Font.Color = Color.Red
            worksheet.Rows.Insert(Row)

            ' Παίρνουμε τα Status από την βάση ώστε να φτιάξω τις στήλες των Headers των συγκεντρωτικών
            cmd = New SqlCommand("SELECT shortName,color  FROM vw_EMP_S order by shortName ", CNDB)
            sdr = cmd.ExecuteReader()
            Dim Col As Integer
            Col = 1
            While sdr.Read()
                worksheet.Cells.Item(Row, Col).Value = sdr.Item(0).ToString
                'Βαζω τα Status σε μια λίστα με την γραμμή και την στήλη ώστε να μπορέσω να το βρίσκω ευκολα
                'StatusCols.Add(Row.ToString & ":" & Col.ToString & ":" & sdr.Item(0).ToString)
                StatusCols.Add(sdr.Item(0).ToString)
                worksheet.Cells.Item(Row, Col).Font.Bold = True
                If Not IsDBNull(sdr.Item(1)) Then worksheet.Cells.Item(Row, Col).FillColor = Color.FromArgb(sdr.Item(1).ToString)
                worksheet.Cells.Item(Row, Col).Alignment.Horizontal = SpreadsheetHorizontalAlignment.Center
                worksheet.Cells.Item(Row, Col).Alignment.Vertical = SpreadsheetHorizontalAlignment.Center
                Col = Col + 1
            End While
            sdr.Close()
            ' Προσθήκη νέας γραμμής
            worksheet.Rows.Insert(Row)
            Row = Row + 1
            ' Για να μην τα ξαναφέρνω από την βάση κάνω Copy paste τους υπαλλήλους
            ' CellRange = worksheet.Range("A" & 2 & ":A" & LastDetailRow)
            'worksheet.Range("A" & Row).CopyFrom(CellRange, PasteSpecial.Values)
            If bIsConstr = True Then
                ' Πάιρνω ανα υπάλληλο το πλήθος των Status
                cmd = New SqlCommand("SELECT COUNT(p.id),shortName ,P.fullname
                                    FROM vw_EMP_P P
                                    inner join vw_EMP_S S on P.statusID = S.ID 
                                    inner join vw_EMP E on e.id = P.empID 
                                    where depid='16228C6D-FAE6-4CFD-82D1-A9910D909952' and 
                                    month(dtpresent)= " & toSQLValueS(lstMonths.SelectedIndex + 1) & "and year(dtPresent)= " & toSQLValueS(dtFDate.Text) &
                                    " group by P.fullname,shortName 
                                    order by P.fullname,shortName  ", CNDB)

            Else
                ' Πάιρνω ανα υπάλληλο το πλήθος των Status
                cmd = New SqlCommand("SELECT COUNT(p.id),shortName ,P.fullname
                                    FROM vw_EMP_P P
                                    inner join vw_EMP_S S on P.statusID = S.ID 
                                    inner join vw_EMP E on e.id = P.empID 
                                    where depid='9812E975-2FD4-4653-B043-3D6CAF440888' and 
                                    month(dtpresent)= " & toSQLValueS(lstMonths.SelectedIndex + 1) & "and year(dtPresent)= " & toSQLValueS(dtFDate.Text) &
                                    " group by P.fullname,shortName 
                                    order by P.fullname,shortName  ", CNDB)

            End If
            sdr = cmd.ExecuteReader()
            Dim tmpFullname As String
            Dim TotRow As Integer = Row
            Dim ListVal() As String
            While sdr.Read()
                If tmpFullname <> sdr.Item(2).ToString Then
                    TotRow = TotRow + 1
                    worksheet.Cells.Item(TotRow, 0).Value = sdr.Item(2).ToString
                    worksheet.Cells.Item(TotRow, StatusCols.IndexOf(sdr.Item(1).ToString) + 1).Value = sdr.Item(0).ToString
                    worksheet.Cells.Item(TotRow, StatusCols.IndexOf(sdr.Item(1).ToString) + 1).Alignment.Horizontal = SpreadsheetHorizontalAlignment.Center
                    worksheet.Cells.Item(TotRow, StatusCols.IndexOf(sdr.Item(1).ToString) + 1).Alignment.Vertical = SpreadsheetHorizontalAlignment.Center
                    tmpFullname = sdr.Item(2).ToString
                Else
                    worksheet.Cells.Item(TotRow, 0).Value = sdr.Item(2).ToString
                    worksheet.Cells.Item(TotRow, StatusCols.IndexOf(sdr.Item(1).ToString) + 1).Value = sdr.Item(0).ToString
                    worksheet.Cells.Item(TotRow, StatusCols.IndexOf(sdr.Item(1).ToString) + 1).Alignment.Horizontal = SpreadsheetHorizontalAlignment.Center
                    worksheet.Cells.Item(TotRow, StatusCols.IndexOf(sdr.Item(1).ToString) + 1).Alignment.Vertical = SpreadsheetHorizontalAlignment.Center
                    tmpFullname = sdr.Item(2).ToString
                End If
            End While
            Row = Row + LastDetailRow
            SPR.WorksheetDisplayArea.SetSize(SPR.ActiveWorksheet.Name, 32, Row)

        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), "Dreamy Kitchen CRM", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub FillEmp_P(ByVal EmpID As String, Row As Integer)
        Try
            Dim sSQL As String
            sSQL = "Select ID,EmpStatusShort,day(dtpresent) as dtpresent,color 
                from vw_EMP_P where month(dtpresent)= " & toSQLValueS(lstMonths.SelectedIndex + 1) &
                "and year(dtPresent)= " & toSQLValueS(dtFDate.Text) & " and  empid= " & toSQLValueS(EmpID) & "  order by dtPresent"
            Dim cmd As SqlCommand = New SqlCommand(sSQL, CNDB)
            Dim sdr As SqlDataReader = cmd.ExecuteReader()
            Dim worksheet As Worksheet = SPR.ActiveWorksheet
            While sdr.Read()
                worksheet.Cells.Item(Row, sdr.Item(2).ToString).Value = sdr.Item(1).ToString
                worksheet.Cells.Item(Row, sdr.Item(2).ToString).Tag = sdr.Item(0).ToString
                If Not sdr.IsDBNull(3) Then worksheet.Cells.Item(Row, sdr.Item(2).ToString).FillColor = Color.FromArgb(sdr.Item(3).ToString)
            End While
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
        Dim days As Integer
        Dim sDate As Date
        If dtFDate.EditValue.ToString.Length = 4 Then
            days = System.DateTime.DaysInMonth(dtFDate.EditValue, lstMonths.SelectedIndex + 1)
        Else
            days = System.DateTime.DaysInMonth(CDate(dtFDate.EditValue).Year, lstMonths.SelectedIndex + 1)
        End If

        Dim myCulture As System.Globalization.CultureInfo = Globalization.CultureInfo.CurrentCulture
        Dim worksheet As Worksheet = SPR.ActiveWorksheet
        worksheet.Cells.Clear
        For i = 1 To days
            If dtFDate.EditValue.ToString.Length = 4 Then
                sDate = i.ToString & "-" & lstMonths.SelectedIndex + 1 & "-" & dtFDate.EditValue
            Else
                sDate = i.ToString & "-" & lstMonths.SelectedIndex + 1 & "-" & CDate(dtFDate.EditValue).Year
            End If

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
        SPR.BeginUpdate()
        FillDays()
        SPR.EndUpdate()

    End Sub

    Private Sub dtFDate_EditValueChanged(sender As Object, e As EventArgs) Handles dtFDate.EditValueChanged
        If dtFDate.EditValue Is Nothing Then Exit Sub
        SPR.BeginUpdate()
        FillDays()
        SPR.EndUpdate()

    End Sub

    Private Sub SPR_CustomCellEdit(sender As Object, e As SpreadsheetCustomCellEditEventArgs) Handles SPR.CustomCellEdit
        If e.RowIndex > LastDetailRow Then Exit Sub
        repository = New RepositoryItemLookUpEdit
        repository.DataSource = Vw_EMP_SBindingSource
        repository.DisplayMember = "shortName"
        repository.ValueMember = "shortName"
        repository.PopulateColumns()
        repository.Columns.Item(0).Visible = False
        repository.Columns.Item(1).Visible = False
        repository.Columns.Item(2).Visible = True : repository.Columns.Item(2).Caption = "STATUS"
        repository.Columns.Item(3).Visible = False
        If e.ColumnIndex >= 1 AndAlso e.RowIndex > 1 Then
            e.RepositoryItem = repository
            AddHandler repository.EditValueChanged, AddressOf Repository_Changed
        End If
    End Sub
    Friend Sub Repository_Changed(sender As Object, e As EventArgs)
        Try
            Dim editor As DevExpress.XtraEditors.LookUpEdit = TryCast(sender, DevExpress.XtraEditors.LookUpEdit)
            Dim value As Object = editor.GetColumnValue("ID")
            Dim valueColor As Object = editor.GetColumnValue("color")
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
            SPR.ActiveWorksheet.Cells.Item(SPR.ActiveCell.RowIndex, SPR.ActiveCell.ColumnIndex).FillColor = Color.FromArgb(valueColor)
        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), "Dreamy Kitchen CRM", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub frmEmpPresenation_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        If Me.WindowState = FormWindowState.Maximized Then frmMain.XtraTabbedMdiManager1.Dock(Me, frmMain.XtraTabbedMdiManager1)
    End Sub

    Private Sub SPR_KeyDown(sender As Object, e As KeyEventArgs) Handles SPR.KeyDown
        If e.KeyCode = Keys.Delete Then
            Dim sSQL As String = "DELETE FROM EMP_P WHERE ID = " & toSQLValueS(SPR.ActiveWorksheet.Cells.Item(SPR.ActiveCell.RowIndex, SPR.ActiveCell.ColumnIndex).Tag)
            Using oCmd As New SqlCommand(sSQL, CNDB)
                oCmd.ExecuteNonQuery()
                SPR.ActiveWorksheet.Cells.Item(SPR.ActiveCell.RowIndex, SPR.ActiveCell.ColumnIndex).FillColor = Color.Empty
            End Using
        End If
    End Sub

    Private Sub SPR_RangeCopied(sender As Object, e As RangeCopiedEventArgs) Handles SPR.RangeCopied

    End Sub

    Private Sub SPR_AfterFillRange(sender As Object, e As AfterFillRangeEventArgs) Handles SPR.AfterFillRange
        'Dim rangeCellsTarget As CellRange
        'Dim rangeCellsSource As CellRange
        'rangeCellsTarget = e.TargetRange
        'rangeCellsSource = e.SourceRange

        'Dim i As Integer
        'Dim s As String
        'For i = SPR.ActiveCell.ColumnIndex To rangeCellsTarget.ColumnCount

        '    s = SPR.ActiveWorksheet.Cells.Item(SPR.ActiveCell.RowIndex, SPR.ActiveCell.ColumnIndex + i).Value.ToString
        'Next i
    End Sub

    Private Sub cmdExportToPDF_Click(sender As Object, e As EventArgs) Handles cmdExportToPDF.Click
        FilesSelection()
    End Sub
    Private Sub FilesSelection()

        XtraSaveFileDialog1.Filter = "PDF files (*.PDF)|*.pdf"
        XtraSaveFileDialog1.FilterIndex = 1
        XtraSaveFileDialog1.InitialDirectory = "C:\"
        XtraSaveFileDialog1.Title = "Save File"
        XtraSaveFileDialog1.FileName = "Παρουσιολόγιο_" & lstMonths.SelectedIndex + 1 & "-" & dtFDate.Text
        XtraSaveFileDialog1.CheckFileExists = False

        Dim result As DialogResult = XtraSaveFileDialog1.ShowDialog()
        If result = DialogResult.OK Then
            SPR.Document.Worksheets.ActiveWorksheet.PrintOptions.FitToPage = True
            SPR.Document.Worksheets.ActiveWorksheet.PrintOptions.FitToWidth = 1
            SPR.Document.Worksheets.ActiveWorksheet.PrintOptions.FitToHeight = 0
            SPR.ExportToPdf(XtraSaveFileDialog1.FileName)

        End If
    End Sub


    Private Sub SPR_CopiedRangePasted(sender As Object, e As CopiedRangePastedEventArgs) Handles SPR.CopiedRangePasted
        Dim rangeCellsTarget As CellRange
        Dim rangeCellsSource As CellRange
        rangeCellsTarget = e.TargetRange
        rangeCellsSource = e.SourceRange

        For Each cell As Cell In e.TargetRange
                Dim dr2 As DataRow() = Me.DreamyKitchenDataSet.vw_EMP_S.Select("name = " & toSQLValueS(cell.Value.TextValue), "name DESC")
                Dim value As Object = dr2(0).Item("ID")
                Dim valueColor As Object = dr2(0).Item("color")
                Dim sDate As Date
                Dim recID As String
                sDate = SPR.ActiveWorksheet.Cells.Item(1, cell.ColumnIndex).Value.ToString & "-" & lstMonths.SelectedIndex + 1 & "-" & dtFDate.Text
                If value Is Nothing Then Exit Sub
                If cell.Tag Is Nothing Then
                    recID = System.Guid.NewGuid.ToString
                    cell.Tag = recID
                Else
                    recID = cell.Tag
                End If
                Using oCmd As New SqlCommand("SaveEmp_P", CNDB)
                    oCmd.CommandType = CommandType.StoredProcedure
                    oCmd.Parameters.AddWithValue("@ID", recID)
                    oCmd.Parameters.AddWithValue("@dtPresent", sDate)
                    oCmd.Parameters.AddWithValue("@EmpID", SPR.ActiveWorksheet.Cells.Item(cell.RowIndex, 0).Tag)
                    oCmd.Parameters.AddWithValue("@StatusID", value)
                    oCmd.Parameters.AddWithValue("@user", UserProps.ID.ToString)
                    oCmd.ExecuteNonQuery()
                End Using
            SPR.ActiveWorksheet.Cells.Item(cell.RowIndex, cell.ColumnIndex).FillColor = Color.FromArgb(valueColor)
        Next cell


    End Sub
End Class