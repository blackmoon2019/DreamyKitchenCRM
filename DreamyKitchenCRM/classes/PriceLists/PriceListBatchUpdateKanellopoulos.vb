Imports System.Data.SqlClient
Imports DevExpress.ClipboardSource.SpreadsheetML
Imports DevExpress.DataAccess.Excel
Imports DevExpress.Spreadsheet
Imports System.IO
Imports DevExpress.XtraEditors

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
                Frm.KANELOPOULOS.FileName = Frm.XtraOpenFileDialog1.FileName
                sFileName = Frm.XtraOpenFileDialog1.SafeFileName
                Frm.GridView5.Columns.Clear() : Frm.grdPRICELIST.DataSource = Nothing : Frm.KANELOPOULOS.Fill() : Frm.grdPRICELIST.DataSource = Frm.KANELOPOULOS
                Frm.grdPRICELIST.ForceInitialize() : Frm.grdPRICELIST.DefaultView.PopulateColumns()
                Frm.GridView5.Columns(0).Caption = "Κωδικός"
                Frm.GridView5.Columns(1).Caption = "Περιγραφή"
                Frm.GridView5.Columns(2).Caption = "Λιανικής"
                Frm.KANELOPOULOS.Dispose()
                'Frm.KANELOPOULOS_TRANS()

            Else
                Frm.grdPRICELIST.DataSource = Nothing
                Frm.KANELLOPOULOSTableAdapter.Fill(Frm.DMDataSet.KANELLOPOULOS)
                Frm.grdPRICELIST.DataSource = Frm.DMDataSet.KANELLOPOULOS
                Frm.grdPRICELIST.ForceInitialize() : Frm.grdPRICELIST.DefaultView.PopulateColumns()
                'LoadForms.RestoreLayoutFromXml(GridView5, "KANELLOPOULOS.xml")
            End If


        Catch ex As DevExpress.DataAccess.Excel.InvalidWorksheetNameValidationException
            XtraMessageBox.Show("Το excel που επιλέξατε δεν ανήκει στον προμηθευτή Κανελλόπουλο", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub
    Private Function GetExcelDataSource() As ExcelDataSource
        Dim ds As New ExcelDataSource()
        ds.FileName = sFileName
        Dim excelSourceOptions1 As New DevExpress.DataAccess.Excel.ExcelSourceOptions()
        Dim excelWorksheetSettings1 As New DevExpress.DataAccess.Excel.ExcelWorksheetSettings()
        excelWorksheetSettings1.WorksheetName = GetWorkSheetNameByIndex(0)
        excelSourceOptions1.ImportSettings = excelWorksheetSettings1
        ds.SourceOptions = excelSourceOptions1
        ds.Fill()
        Return ds
    End Function

    Private Function GetWorkSheetNameByIndex(ByVal p As Integer) As String
        Dim workbook As IWorkbook = New Workbook()
        Using stream As New FileStream(fileName, FileMode.Open)
            workbook.LoadDocument(stream, DocumentFormat.OpenXml)
        End Using
        Dim worksheets As WorksheetCollection = workbook.Worksheets
        Return worksheets(p).Name
    End Function
    Private Sub KANELOPOULOS_TRANS()
        Dim sInvNumber As String, sDate As String, sVatAmount As Double, sNetAmount As Double
        Dim sOrd As Integer, isCredit As Boolean
        Dim sdocTypeID As String, sdocTypeDescr As String
        Dim Cmd As SqlCommand, sdr As SqlDataReader
        Dim ItemsCorrect As Integer = 0, ItemsWrong As Integer = 0
        Dim sKanelopoulosID As String, sKanelopoulosFileID As String
        With Frm
            Try
                .LayoutControlItem4.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
                .ProgressBarControl1.EditValue = 0
                .ProgressBarControl1.Properties.Step = 1
                .ProgressBarControl1.Properties.PercentView = True
                .ProgressBarControl1.Properties.Maximum = .GridView5.DataRowCount - 1
                .ProgressBarControl1.Properties.Minimum = 0
                .lstLog.Items.Clear()
                Dim sSQL As New System.Text.StringBuilder
                'Cmd = New SqlCommand("TRUNCATE TABLE KANELLOPOULOS", CNDB) : Cmd.ExecuteNonQuery()
                sKanelopoulosFileID = System.Guid.NewGuid.ToString
                For i As Integer = 0 To .GridView5.DataRowCount - 1
                    If .GridView5.GetRowCellValue(i, .GridView5.Columns(2).FieldName) IsNot Nothing Then
                        If .GridView5.GetRowCellValue(i, .GridView5.Columns(2).FieldName) IsNot Nothing Then sInvNumber = .GridView5.GetRowCellValue(i, .GridView5.Columns(2).FieldName).ToString().Trim
                        If sInvNumber <> "Παραστατικό" And sInvNumber <> "Από μεταφορά" And sInvNumber <> "" Then
                            If sInvNumber.Substring(0, 4) <> "ΕΠΠΛ" And sInvNumber.Substring(0, 4) <> "ΕΜΒΠ" Then

                                If .GridView5.GetRowCellValue(i, .GridView5.Columns(1).FieldName) IsNot Nothing Then sDate = CDate(.GridView5.GetRowCellValue(i, .GridView5.Columns(1).FieldName).ToString())
                                sOrd = .GridView5.GetRowCellValue(i, .GridView5.Columns(0).FieldName)
                                If .GridView5.GetRowCellValue(i, .GridView5.Columns(4).FieldName) IsNot Nothing Then
                                    sVatAmount = .GridView5.GetRowCellValue(i, .GridView5.Columns(4).FieldName)
                                    sNetAmount = sVatAmount / 1.24
                                Else
                                    sVatAmount = 0
                                End If

                                sdocTypeDescr = .GridView5.GetRowCellValue(i, .GridView5.Columns(3).FieldName)
                                If sdocTypeDescr.Length > 0 Then
                                    Cmd = New SqlCommand("SELECT top 1 ID,Vmultiplier FROM DOC_TYPES (nolock) WHERE name= " & toSQLValueS(sdocTypeDescr) & " and supID= " & toSQLValueS(supID), CNDB)
                                    sdr = Cmd.ExecuteReader()
                                    If (sdr.Read() = True) Then
                                        sdocTypeID = sdr.GetGuid(sdr.GetOrdinal("ID")).ToString
                                        'Αυτόματη Είσπραξη Μετρητών(Aπο Τιμολογηση)
                                        If sdocTypeID.ToUpper = "D5257744-1705-4D27-BB6B-E908EA65DAE4" Then
                                            sVatAmount = .GridView5.GetRowCellValue(i, .GridView5.Columns(5).FieldName) * sdr.GetInt32(sdr.GetOrdinal("Vmultiplier"))
                                            sNetAmount = sVatAmount / 1.24
                                        End If
                                    End If
                                    sdr.Close()
                                End If
                                If sNetAmount < 0 Then isCredit = 1 Else isCredit = 0
                                Try
                                    sKanelopoulosID = System.Guid.NewGuid.ToString
                                    'Εισαγωγή εγγραφών από Excel sthn Βάση
                                    sSQL.AppendLine("INSERT INTO KANELLOPOULOS (ID,ord,supID,invDate,invNumber,netAmount,vatAmount, docTypeId,uploadDate,createdOn,createdBy,isCredit,buyFID) VALUES( ")
                                    sSQL.AppendLine(toSQLValueS(sKanelopoulosID) & ",")
                                    sSQL.AppendLine(toSQLValueS(sOrd, True) & ",")
                                    sSQL.AppendLine(toSQLValueS(sSUP_ID) & ",")
                                    If sDate.Length > 0 Then sSQL.AppendLine(toSQLValueS(CDate(sDate).ToString("yyyyMMdd")) & ",") Else sSQL.AppendLine("NULL,")
                                    sSQL.AppendLine(toSQLValueS(sInvNumber) & ",")
                                    sSQL.AppendLine(toSQLValueS(sNetAmount, True) & ",")
                                    sSQL.AppendLine(toSQLValueS(sVatAmount, True) & ",")
                                    sSQL.AppendLine(toSQLValueS(sdocTypeID) & ",")
                                    sSQL.AppendLine("getdate(),")
                                    sSQL.AppendLine("getdate(),")
                                    sSQL.AppendLine(toSQLValueS(UserProps.ID.ToString) & ",")
                                    sSQL.AppendLine(toSQLValueS(isCredit) & ",")
                                    sSQL.AppendLine(toSQLValueS(sKanelopoulosFileID) & ")")

                                    Using oCmd As New SqlCommand(sSQL.ToString, CNDB)
                                        oCmd.ExecuteNonQuery()
                                    End Using
                                    .lstLog.Items.Add("Η εγγραφή Καταχωρήθηκε με επιτυχία!-->" & sInvNumber)
                                    .lstLog.Items(.lstLog.Items.Count - 1).ImageOptions.Image = .ImageCollection1.Images.Item(0)
                                    .lstLog.Items(.lstLog.Items.Count - 1).Tag = sKanelopoulosID
                                    ItemsCorrect = ItemsCorrect + 1
                                    .lstLog.SelectedIndex = .lstLog.ItemCount + 1
                                    .lstLog.Refresh()
                                Catch dbException As System.Data.SqlClient.SqlException
                                    .lstLog.Items.Add("Το τιμολόγιο με αριθμό " & sInvNumber & " και ημερομηνία " & sDate & " υπάρχει ήδη.")
                                    .lstLog.Items(.lstLog.Items.Count - 1).ImageOptions.Image = .ImageCollection1.Images.Item(4)
                                    ItemsWrong = ItemsWrong + 1
                                    .lstLog.SelectedIndex = .lstLog.ItemCount + 1
                                    .lstLog.Refresh()
                                Catch ex As Exception
                                    .lstLog.Items.Add(ex.Message.ToString.Replace(vbCrLf, ""))
                                    .lstLog.Items(.lstLog.Items.Count - 1).ImageOptions.Image = .ImageCollection1.Images.Item(1)
                                    ItemsWrong = ItemsWrong + 1
                                    .lstLog.SelectedIndex = .lstLog.ItemCount + 1
                                    .lstLog.Refresh()
                                End Try
                                sSQL.Clear()
                            End If
                        End If
                    End If
                    .ProgressBarControl1.PerformStep()
                    .ProgressBarControl1.Update()
                    sInvNumber = "" : sDate = ""
                Next i
                .grdPRICELIST.DataSource = Nothing
                .KANELLOPOULOSTableAdapter.Fill(.DMDataSet.KANELLOPOULOS)
                .grdPRICELIST.DataSource = .DMDataSet.KANELLOPOULOS
                .grdPRICELIST.ForceInitialize() : .grdPRICELIST.DefaultView.PopulateColumns()
                LoadForms.RestoreLayoutFromXml(.GridView5, "KANELLOPOULOS.xml")


                .lstLog.Items.Add("Καταχωρήθηκαν: " & ItemsCorrect & " Λάθοι: " & ItemsWrong)
                .lstLog.Items(.lstLog.Items.Count - 1).ImageOptions.Image = .ImageCollection1.Images.Item(2)
                .lstLog.SelectedIndex = .lstLog.ItemCount + 1
                .lstLog.Refresh()
                If ItemsCorrect > 0 Then
                    Dim sResult As Boolean = DBQ.InsertNewDataFiles(.XtraOpenFileDialog1, "BUY_F", sKanelopoulosFileID)
                    If sResult = False Then XtraMessageBox.Show("Προσοχή το αρχείο Excel δεν αποθηκεύθηκε στην βάση", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
                .LayoutControlItem4.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
            Catch ex As Exception
                XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
                .LayoutControlItem4.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
            End Try
        End With
    End Sub
End Class
