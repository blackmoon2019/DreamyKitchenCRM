Imports System.Data.SqlClient
Imports DevExpress.ClipboardSource.SpreadsheetML
Imports DevExpress.DataAccess.Excel
Imports DevExpress.Spreadsheet
Imports System.IO
Imports DevExpress.XtraEditors
Imports DevExpress.DataAccess.UI.Excel
Imports System.ComponentModel
Imports System.Data.OleDb
Imports DevExpress.DataAccess.Native.Sql.MasterDetail

Public Class PriceListBatchUpdateKanellopoulos
    Dim Frm As frmPriceListBatchUpdate
    Private LoadForms As New FormLoader
    Private sSUP_ID As String
    Private sFileName As String
    Private DBQ As New DBQueries
    Public WriteOnly Property SUP_ID As String
        Set(value As String)
            sSUP_ID = value
        End Set
    End Property

    Public Sub Initialize(ByVal sFrm As frmPriceListBatchUpdate)
        Frm = sFrm
        'Frm.PRICELISTS_KEYWORDSTableAdapter.FillBySupID(Frm.DMDataSet.PRICELISTS_KEYWORDS, System.Guid.Parse(sSUP_ID))
        'LoadForms.RestoreLayoutFromXml(Frm.GridView1, "PRICELISTS_KEYWORDS_def.xml")
    End Sub

    Public Sub FilesSelection()
        Try
            Frm.XtraOpenFileDialog1.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*"
            Frm.XtraOpenFileDialog1.Title = "Άνοιγμα αρχείου ΚΑΝΕΛΛΟΠΟΥΛΟΣ"
            Frm.XtraOpenFileDialog1.FilterIndex = 1
            Frm.XtraOpenFileDialog1.InitialDirectory = Application.ExecutablePath
            Frm.XtraOpenFileDialog1.FileName = ""
            Frm.XtraOpenFileDialog1.CheckFileExists = False
            Frm.XtraOpenFileDialog1.Multiselect = False
            Frm.XtraOpenFileDialog1.RestoreDirectory = True
            Dim result As DialogResult = Frm.XtraOpenFileDialog1.ShowDialog()
            If result = DialogResult.OK Then
                sFileName = Frm.XtraOpenFileDialog1.SafeFileName
                ReadFromExcelWorkbook()
            End If


        Catch ex As DevExpress.DataAccess.Excel.InvalidWorksheetNameValidationException
            XtraMessageBox.Show("Το excel που επιλέξατε δεν ανήκει στον προμηθευτή Κανελλόπουλο", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub
    Private Sub ReadFromExcelWorkbook()
        'Imports System.Data.OleDb
        'Example Excel ConnectionString:

        Dim ExcelConnectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Frm.XtraOpenFileDialog1.FileName & ";Extended Properties=""Excel 12.0 Xml;HDR=YES"";"
        Dim TotalRows As Int16 = 0
        Dim sValueListiID As String
        Dim Status As Int16
        Try
            Dim WorksheetsDataTable As DataTable = GetExcelWorksheets(ExcelConnectionString)
            Dim Kanellopoulos As New DataTable("Kanellopoulos")
            Frm.ProgressBarControl1.EditValue = 0
            Frm.ProgressBarControl1.Properties.Step = 1
            Frm.ProgressBarControl1.Properties.PercentView = True
            Frm.ProgressBarControl1.Properties.Minimum = 0
            For Each WorksheetRow As DataRow In WorksheetsDataTable.Rows
                Dim WorksheetName As String = WorksheetRow.Item("TABLE_NAME")
                Dim ExcelDataTable As New DataTable(WorksheetName)
                ExcelDataTable.TableName = WorksheetName
                sValueListiID = GetValueListID(WorksheetName)
                Dim Sql As String = "Select * FROM [" & WorksheetName & "]"
                Dim MyConnection As New OleDbConnection(ExcelConnectionString)
                MyConnection.Open()
                Dim MyCommand As New OleDbCommand(Sql, MyConnection)
                Dim MyDataAdapter As New OleDbDataAdapter(MyCommand)
                MyDataAdapter.Fill(ExcelDataTable)
                Frm.ProgressBarControl1.Properties.Maximum = ExcelDataTable.Rows.Count
                AddColumnsToDataTable(ExcelDataTable, Kanellopoulos)


                For i As Integer = 0 To ExcelDataTable.Rows.Count - 1

                    If IsDBNull(ExcelDataTable.Rows(i)(0)) = False Then
                        Kanellopoulos.ImportRow(ExcelDataTable.Rows(i))
                        Kanellopoulos.Rows(TotalRows)("ValueListName") = WorksheetName.Replace("$", "").Replace("'", "")
                        Kanellopoulos.Rows(TotalRows)("ValueListID") = sValueListiID
                        Kanellopoulos.Rows(TotalRows)("SupID") = sSUP_ID
                        If CheckRow(Kanellopoulos, TotalRows, Status) Then InsertRowToPriceListTemp(Kanellopoulos, TotalRows, Status)
                        TotalRows = TotalRows + 1
                        Frm.ProgressBarControl1.PerformStep()
                        Frm.ProgressBarControl1.Update()
                    End If
                Next
                MyConnection.Close()
            Next

            'Frm.GridView5.Columns.Clear() : Frm.grdPRICELIST.DataSource = Nothing
            'Frm.grdPRICELIST.DataSource = Kanellopoulos
            'Frm.grdPRICELIST.ForceInitialize() : Frm.grdPRICELIST.DefaultView.PopulateColumns()
            Frm.PRICELIST_TEMPTableAdapter.FillBySupID(Frm.DMDataSet.PRICELIST_TEMP, System.Guid.Parse(sSUP_ID))

        Catch ex As Exception
            MsgBox(ex.Message & " (" & System.Reflection.MethodBase.GetCurrentMethod.Name & ")")
        End Try
    End Sub
    Private Function InsertRowToPriceListTemp(ByVal Kanellopoulos As DataTable, ByVal Row As Int16, ByVal Status As Int16)
        Try
            Dim sSQL As New System.Text.StringBuilder
            Dim sKanelopoulosID As String = System.Guid.NewGuid.ToString
            sSQL.Clear()
            sSQL.AppendLine("INSERT INTO PRICELIST_TEMP ([ID], [supID], [valuelistID], [CustomCode], [name], [description], [InitialPrice], [discount], [Price], [Status]) VALUES( ")
            sSQL.AppendLine(toSQLValueS(sKanelopoulosID) & ",")
            sSQL.AppendLine(toSQLValueS(Kanellopoulos.Rows(Row)("SupID")) & ",")
            sSQL.AppendLine(toSQLValueS(Kanellopoulos.Rows(Row)("ValueListID")) & ",")
            sSQL.AppendLine(toSQLValueS(Kanellopoulos.Rows(Row)("Κωδικός")) & ",")
            sSQL.AppendLine(toSQLValueS(Kanellopoulos.Rows(Row)("Περιγραφή")) & ",")
            sSQL.AppendLine(toSQLValueS("ECO") & ",")
            sSQL.AppendLine(toSQLValueS(IIf(IsDBNull(Kanellopoulos.Rows(Row)("Λιανικής")), 0, Kanellopoulos.Rows(Row)("Λιανικής")), True) & ",")
            sSQL.AppendLine(toSQLValueS(0, True) & ",")
            sSQL.AppendLine(toSQLValueS(0, True) & ",")
            sSQL.AppendLine(toSQLValueS(Status, True) & ")")

            Using oCmd As New SqlCommand(sSQL.ToString, CNDB)
                oCmd.ExecuteNonQuery()
            End Using
            Frm.lstLog.Items.Add("Η εγγραφή Καταχωρήθηκε με επιτυχία!-->" & Kanellopoulos.Rows(Row)("Κωδικός"))
            Frm.lstLog.Items(Frm.lstLog.Items.Count - 1).ImageOptions.Image = Frm.ImageCollection1.Images.Item(0)
            Frm.lstLog.Items(Frm.lstLog.Items.Count - 1).Tag = sKanelopoulosID
            Frm.lstLog.SelectedIndex = Frm.lstLog.ItemCount + 1
            Frm.lstLog.Refresh()

        Catch dbException As System.Data.SqlClient.SqlException
            If dbException.Number = 2627 Then
                Frm.lstLog.Items.Add("Ο Κωδικός " & Kanellopoulos.Rows(Row)("Κωδικός") & " υπάρχει ήδη.")
                Frm.lstLog.Items(Frm.lstLog.Items.Count - 1).ImageOptions.Image = Frm.ImageCollection1.Images.Item(4)
            Else
                Frm.lstLog.Items.Add(dbException.Message.ToString.Replace(vbCrLf, ""))
                Frm.lstLog.Items(Frm.lstLog.Items.Count - 1).ImageOptions.Image = Frm.ImageCollection1.Images.Item(1)
            End If


            'ItemsWrong = ItemsWrong + 1
            Frm.lstLog.SelectedIndex = Frm.lstLog.ItemCount + 1
            Frm.lstLog.Refresh()

        Catch ex As Exception
            Frm.lstLog.Items.Add(ex.Message.ToString.Replace(vbCrLf, ""))
            Frm.lstLog.Items(Frm.lstLog.Items.Count - 1).ImageOptions.Image = Frm.ImageCollection1.Images.Item(1)
            'ItemsWrong = ItemsWrong + 1
            Frm.lstLog.SelectedIndex = Frm.lstLog.ItemCount + 1
            Frm.lstLog.Refresh()

        End Try
    End Function
    Private Function GetValueListID(ByVal Keyword As String) As String
        Dim Cmd As SqlCommand, sdr As SqlDataReader
        Dim sValueListiID As String = ""
        Try
            ' Παίρνω την κατηγορία από τα Keywords
            Cmd = New SqlCommand("SELECT top 1 valuelistID FROM PRICELISTS_KEYWORDS (nolock) WHERE supID = " & toSQLValueS(sSUP_ID) & " and keyword = " & toSQLValueS(Keyword.Replace("$", "").Replace("'", "")), CNDB)
            sdr = Cmd.ExecuteReader()
            If (sdr.Read() = True) Then sValueListiID = sdr.GetGuid(sdr.GetOrdinal("valuelistID")).ToString
            sdr.Close()
            Return sValueListiID
        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function
    Private Sub AddColumnsToDataTable(ByRef sourceDT As DataTable, ByRef destinationDT As DataTable)
        ' Αυτη η γραμμή ειναι για να πάρουμε το schema
        If destinationDT.Columns.Count = 0 Then
            destinationDT = sourceDT.Clone
            Dim cValueListName As New DataColumn
            cValueListName.ColumnName = "ValueListName"
            cValueListName.DataType = System.Type.GetType("System.String")
            cValueListName.Caption = "Κατηγορία"
            destinationDT.Columns.Add(cValueListName)

            Dim cValueListID As New DataColumn
            cValueListID.ColumnName = "ValueListID"
            cValueListID.DataType = System.Type.GetType("System.String")
            cValueListID.Caption = "ID Κατηγορίαs"
            destinationDT.Columns.Add(cValueListID)

            Dim cValueListItemStatus As New DataColumn
            cValueListItemStatus.ColumnName = "Status"
            cValueListItemStatus.DataType = GetType(Integer)
            cValueListItemStatus.Caption = "Status"
            destinationDT.Columns.Add(cValueListItemStatus)

            Dim cSupID As New DataColumn
            cSupID.ColumnName = "SupID"
            cSupID.DataType = System.Type.GetType("System.String")
            cSupID.Caption = "ID Προμηθευτή"
            destinationDT.Columns.Add(cSupID)
        Else
            sourceDT.Columns(0).ColumnName = destinationDT.Columns(0).ColumnName
            sourceDT.Columns(1).ColumnName = destinationDT.Columns(1).ColumnName
            sourceDT.Columns(2).ColumnName = destinationDT.Columns(2).ColumnName
            sourceDT.Columns(3).ColumnName = destinationDT.Columns(3).ColumnName
        End If
    End Sub
    Private Function CheckRow(ByVal dt As DataTable, ByVal Row As Int16, ByRef Status As Int16) As Boolean
        Dim Cmd As SqlCommand, sdr As SqlDataReader
        Dim sName As String, sOriginalName As String
        Dim Price As Double, OriginalPrice As Double
        Try
            Cmd = New SqlCommand("SELECT Top 1 name,Price from VALUELISTITEM (nolock)  where valuelistID = " & toSQLValueS(dt.Rows(Row)("ValueListID")) & " and " &
                                "CustomCode = " & toSQLValueS(dt.Rows(Row)(0)) & " and " &
                                "supID = " & toSQLValueS(sSUP_ID), CNDB)
            sdr = Cmd.ExecuteReader()
            If (sdr.Read() = True) Then
                If IsDBNull(dt.Rows(Row)(1)) = False Then sName = dt.Rows(Row)(1) Else sName = ""
                If IsDBNull(dt.Rows(Row)(2)) = False Then Price = dt.Rows(Row)(2) Else Price = 0
                sOriginalName = sdr.GetString(sdr.GetOrdinal("name")).ToString
                OriginalPrice = sdr.GetDecimal(sdr.GetOrdinal("Price"))
                If sOriginalName = sName And Price = OriginalPrice Then dt.Rows(Row)("Status") = 0 Else dt.Rows(Row)("Status") = 1
            Else
                dt.Rows(Row)("Status") = 2
            End If
            sdr.Close()
            Status = dt.Rows(Row)("Status")
            If dt.Rows(Row)("Status") = 0 Then Return False Else Return True
        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Function

    ''' <summary>
    ''' Returns a DataTable of worksheets in the submitted Excel workbook
    ''' </summary>
    ''' <param name="ExcelConnectionString"></param>
    ''' <returns>DataTable</returns>
    Public Function GetExcelWorksheets(ExcelConnectionString As String) As DataTable
        Dim ExcelWorksheetsDataTable As New DataTable
        Try
            Dim MyConnection As New OleDbConnection(ExcelConnectionString)
            MyConnection.Open()
            ExcelWorksheetsDataTable = MyConnection.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, Nothing)
            MyConnection.Close()
        Catch ex As Exception
            MsgBox(ex.Message & " (" & System.Reflection.MethodBase.GetCurrentMethod.Name & ")")
        End Try
        Return ExcelWorksheetsDataTable
    End Function

    'Private Sub KANELOPOULOS_TRANS()
    '    Dim sInvNumber As String, sDate As String, sVatAmount As Double, sNetAmount As Double
    '    Dim sOrd As Integer, isCredit As Boolean
    '    Dim sdocTypeID As String, sdocTypeDescr As String
    '    Dim Cmd As SqlCommand, sdr As SqlDataReader
    '    Dim ItemsCorrect As Integer = 0, ItemsWrong As Integer = 0
    '    Dim sKanelopoulosID As String, sKanelopoulosFileID As String
    '    With Frm
    '        Try
    '            .LayoutControlItem4.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
    '            .ProgressBarControl1.EditValue = 0
    '            .ProgressBarControl1.Properties.Step = 1
    '            .ProgressBarControl1.Properties.PercentView = True
    '            .ProgressBarControl1.Properties.Maximum = .GridView5.DataRowCount - 1
    '            .ProgressBarControl1.Properties.Minimum = 0
    '            .lstLog.Items.Clear()
    '            Dim sSQL As New System.Text.StringBuilder
    '            'Cmd = New SqlCommand("TRUNCATE TABLE KANELLOPOULOS", CNDB) : Cmd.ExecuteNonQuery()
    '            sKanelopoulosFileID = System.Guid.NewGuid.ToString
    '            For i As Integer = 0 To .GridView5.DataRowCount - 1
    '                If .GridView5.GetRowCellValue(i, .GridView5.Columns(2).FieldName) IsNot Nothing Then
    '                    If .GridView5.GetRowCellValue(i, .GridView5.Columns(2).FieldName) IsNot Nothing Then sInvNumber = .GridView5.GetRowCellValue(i, .GridView5.Columns(2).FieldName).ToString().Trim
    '                    If sInvNumber <> "Παραστατικό" And sInvNumber <> "Από μεταφορά" And sInvNumber <> "" Then
    '                        If sInvNumber.Substring(0, 4) <> "ΕΠΠΛ" And sInvNumber.Substring(0, 4) <> "ΕΜΒΠ" Then

    '                            If .GridView5.GetRowCellValue(i, .GridView5.Columns(1).FieldName) IsNot Nothing Then sDate = CDate(.GridView5.GetRowCellValue(i, .GridView5.Columns(1).FieldName).ToString())
    '                            sOrd = .GridView5.GetRowCellValue(i, .GridView5.Columns(0).FieldName)
    '                            If .GridView5.GetRowCellValue(i, .GridView5.Columns(4).FieldName) IsNot Nothing Then
    '                                sVatAmount = .GridView5.GetRowCellValue(i, .GridView5.Columns(4).FieldName)
    '                                sNetAmount = sVatAmount / 1.24
    '                            Else
    '                                sVatAmount = 0
    '                            End If

    '                            sdocTypeDescr = .GridView5.GetRowCellValue(i, .GridView5.Columns(3).FieldName)
    '                            If sdocTypeDescr.Length > 0 Then
    '                                Cmd = New SqlCommand("SELECT top 1 ID,Vmultiplier FROM DOC_TYPES (nolock) WHERE name= " & toSQLValueS(sdocTypeDescr) & " and supID= " & toSQLValueS(sSUP_ID), CNDB)
    '                                sdr = Cmd.ExecuteReader()
    '                                If (sdr.Read() = True) Then
    '                                    sdocTypeID = sdr.GetGuid(sdr.GetOrdinal("ID")).ToString
    '                                    'Αυτόματη Είσπραξη Μετρητών(Aπο Τιμολογηση)
    '                                    If sdocTypeID.ToUpper = "D5257744-1705-4D27-BB6B-E908EA65DAE4" Then
    '                                        sVatAmount = .GridView5.GetRowCellValue(i, .GridView5.Columns(5).FieldName) * sdr.GetInt32(sdr.GetOrdinal("Vmultiplier"))
    '                                        sNetAmount = sVatAmount / 1.24
    '                                    End If
    '                                End If
    '                                sdr.Close()
    '                            End If
    '                            If sNetAmount < 0 Then isCredit = 1 Else isCredit = 0
    '                            Try
    '                                sKanelopoulosID = System.Guid.NewGuid.ToString
    '                                'Εισαγωγή εγγραφών από Excel sthn Βάση
    '                                sSQL.AppendLine("INSERT INTO KANELLOPOULOS (ID,ord,supID,invDate,invNumber,netAmount,vatAmount, docTypeId,uploadDate,createdOn,createdBy,isCredit,buyFID) VALUES( ")
    '                                sSQL.AppendLine(toSQLValueS(sKanelopoulosID) & ",")
    '                                sSQL.AppendLine(toSQLValueS(sOrd, True) & ",")
    '                                sSQL.AppendLine(toSQLValueS(sSUP_ID) & ",")
    '                                If sDate.Length > 0 Then sSQL.AppendLine(toSQLValueS(CDate(sDate).ToString("yyyyMMdd")) & ",") Else sSQL.AppendLine("NULL,")
    '                                sSQL.AppendLine(toSQLValueS(sInvNumber) & ",")
    '                                sSQL.AppendLine(toSQLValueS(sNetAmount, True) & ",")
    '                                sSQL.AppendLine(toSQLValueS(sVatAmount, True) & ",")
    '                                sSQL.AppendLine(toSQLValueS(sdocTypeID) & ",")
    '                                sSQL.AppendLine("getdate(),")
    '                                sSQL.AppendLine("getdate(),")
    '                                sSQL.AppendLine(toSQLValueS(UserProps.ID.ToString) & ",")
    '                                sSQL.AppendLine(toSQLValueS(isCredit) & ",")
    '                                sSQL.AppendLine(toSQLValueS(sKanelopoulosFileID) & ")")

    '                                Using oCmd As New SqlCommand(sSQL.ToString, CNDB)
    '                                    oCmd.ExecuteNonQuery()
    '                                End Using
    '                                .lstLog.Items.Add("Η εγγραφή Καταχωρήθηκε με επιτυχία!-->" & sInvNumber)
    '                                .lstLog.Items(.lstLog.Items.Count - 1).ImageOptions.Image = .ImageCollection1.Images.Item(0)
    '                                .lstLog.Items(.lstLog.Items.Count - 1).Tag = sKanelopoulosID
    '                                ItemsCorrect = ItemsCorrect + 1
    '                                .lstLog.SelectedIndex = .lstLog.ItemCount + 1
    '                                .lstLog.Refresh()
    '                            Catch dbException As System.Data.SqlClient.SqlException
    '                                .lstLog.Items.Add("Το τιμολόγιο με αριθμό " & sInvNumber & " και ημερομηνία " & sDate & " υπάρχει ήδη.")
    '                                .lstLog.Items(.lstLog.Items.Count - 1).ImageOptions.Image = .ImageCollection1.Images.Item(4)
    '                                ItemsWrong = ItemsWrong + 1
    '                                .lstLog.SelectedIndex = .lstLog.ItemCount + 1
    '                                .lstLog.Refresh()
    '                            Catch ex As Exception
    '                                .lstLog.Items.Add(ex.Message.ToString.Replace(vbCrLf, ""))
    '                                .lstLog.Items(.lstLog.Items.Count - 1).ImageOptions.Image = .ImageCollection1.Images.Item(1)
    '                                ItemsWrong = ItemsWrong + 1
    '                                .lstLog.SelectedIndex = .lstLog.ItemCount + 1
    '                                .lstLog.Refresh()
    '                            End Try
    '                            sSQL.Clear()
    '                        End If
    '                    End If
    '                End If
    '                .ProgressBarControl1.PerformStep()
    '                .ProgressBarControl1.Update()
    '                sInvNumber = "" : sDate = ""
    '            Next i
    '            .grdPRICELIST.DataSource = Nothing
    '            .KANELLOPOULOSTableAdapter.Fill(.DMDataSet.KANELLOPOULOS)
    '            .grdPRICELIST.DataSource = .DMDataSet.KANELLOPOULOS
    '            .grdPRICELIST.ForceInitialize() : .grdPRICELIST.DefaultView.PopulateColumns()
    '            LoadForms.RestoreLayoutFromXml(.GridView5, "KANELLOPOULOS.xml")


    '            .lstLog.Items.Add("Καταχωρήθηκαν: " & ItemsCorrect & " Λάθοι: " & ItemsWrong)
    '            .lstLog.Items(.lstLog.Items.Count - 1).ImageOptions.Image = .ImageCollection1.Images.Item(2)
    '            .lstLog.SelectedIndex = .lstLog.ItemCount + 1
    '            .lstLog.Refresh()
    '            If ItemsCorrect > 0 Then
    '                Dim sResult As Boolean = DBQ.InsertNewDataFiles(.XtraOpenFileDialog1, "BUY_F", sKanelopoulosFileID)
    '                If sResult = False Then XtraMessageBox.Show("Προσοχή το αρχείο Excel δεν αποθηκεύθηκε στην βάση", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
    '            End If
    '            .LayoutControlItem4.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
    '        Catch ex As Exception
    '            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
    '            .LayoutControlItem4.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
    '        End Try
    '    End With
    'End Sub
End Class
