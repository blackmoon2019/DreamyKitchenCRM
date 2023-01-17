Imports System.Data.SqlClient
Imports System.Text.RegularExpressions
Imports DevExpress.DataAccess
Imports DevExpress.Office.PInvoke.Win32
Imports DevExpress.Xpo
Imports DevExpress.XtraBars.Navigation
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraExport.Helpers
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraLayout

Public Class frmBuyCollectionInsert
    Private DBQ As New DBQueries
    Private LoadForms As New FormLoader
    Private SupMode As Integer
    Private sFileName As String
    Private Sub frmBuyCollectionInsert_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DMDataSet.CCT_TRANSH' table. You can move, or remove it, as needed.
        Me.CCT_TRANSHTableAdapter.Fill(Me.DMDataSet.CCT_TRANSH)
        'TODO: This line of code loads data into the 'DreamyKitchenDataSet.vw_BUY' table. You can move, or remove it, as needed.
        Me.KANELLOPOULOSTableAdapter.Fill(Me.DMDataSet.KANELLOPOULOS)
        LoadForms.RestoreLayoutFromXml(GridView5, "KANELLOPOULOS.xml")
        AddHandler RepTransh.EditValueChanged, AddressOf RepTransh_Changed
    End Sub
    Private Sub NavKanelopoulos_ElementClick(sender As Object, e As NavElementEventArgs) Handles NavKanelopoulos.ElementClick
        SupMode = 1 : FilesSelection()
    End Sub
    Friend Sub RepTransh_Changed(sender As Object, e As EventArgs)
        Dim editor As DevExpress.XtraEditors.LookUpEdit = TryCast(sender, DevExpress.XtraEditors.LookUpEdit)
        Dim transhDescription As String = ""
        If editor.EditValue Is Nothing Then GridView5.SetRowCellValue(GridView5.FocusedRowHandle, "FullTranshDescription", "") : Exit Sub
        transhDescription = editor.GetColumnValue("FullTranshDescription").ToString
        GridView5.SetRowCellValue(GridView5.FocusedRowHandle, "FullTranshDescription", transhDescription)
    End Sub
    Private Sub GridView5_ShownEditor(sender As Object, e As EventArgs) Handles GridView5.ShownEditor
        Dim view As ColumnView = DirectCast(sender, ColumnView)
        Try
            If GridView5.FocusedRowHandle < 0 Then Exit Sub
            Dim cctID As String = GridView5.GetRowCellValue(GridView5.FocusedRowHandle, "cctID").ToString()
            If view.FocusedColumn.FieldName = "transhID" Then
                Dim editor As LookUpEdit = CType(view.ActiveEditor, LookUpEdit)
                If cctID.Length > 0 Then editor.Properties.DataSource = Me.Vw_TRANSHTableAdapter.GetData(System.Guid.Parse(cctID))
            End If
        Catch ex As Exception
            'XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub GridView5_CustomDrawCell(sender As Object, e As RowCellCustomDrawEventArgs) Handles GridView5.CustomDrawCell
        Dim GRD5 As GridView = sender
        If GRD5 Is Nothing Then Exit Sub
        If e.CellValue Is Nothing Then Exit Sub
        If e.Column.FieldName = "transhID" Then
            e.DisplayText = GRD5.GetRowCellValue(e.RowHandle, "FullTranshDescription").ToString()
        End If
        'If e.Column.FieldName = "inhID" Then e.DisplayText = GRD5.GetRowCellValue(e.RowHandle, "completeDate").ToString()
    End Sub
    Private Sub FilesSelection()
        Try
            Select Case SupMode
                Case 1, 4 : XtraOpenFileDialog1.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*"
                Case 2, 3 : XtraOpenFileDialog1.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*"
            End Select
            XtraOpenFileDialog1.FilterIndex = 1
            XtraOpenFileDialog1.InitialDirectory = Application.ExecutablePath
            Select Case SupMode
                Case 1 : XtraOpenFileDialog1.Title = "Άνοιγμα αρχείου ΚΑΝΕΛΛΟΠΟΥΛΟΣ"
                Case 2 : XtraOpenFileDialog1.Title = "Άνοιγμα αρχείου ALPHA"
                Case 3 : XtraOpenFileDialog1.Title = "Άνοιγμα αρχείου EUROBANK"
                Case 4 : XtraOpenFileDialog1.Title = "Άνοιγμα αρχείου ΕΘΝΙΚΗΣ"
            End Select
            XtraOpenFileDialog1.FileName = ""
            XtraOpenFileDialog1.CheckFileExists = False
            XtraOpenFileDialog1.Multiselect = False
            XtraOpenFileDialog1.RestoreDirectory = True
            Dim result As DialogResult = XtraOpenFileDialog1.ShowDialog()
            If result = DialogResult.OK Then
                Select Case SupMode
                    Case 1
                        KANELOPOULOS.FileName = XtraOpenFileDialog1.FileName
                        sFileName = XtraOpenFileDialog1.SafeFileName
                        GridView5.Columns.Clear() : grdINVOICES.DataSource = Nothing : KANELOPOULOS.Fill() : grdINVOICES.DataSource = KANELOPOULOS
                        grdINVOICES.ForceInitialize() : grdINVOICES.DefaultView.PopulateColumns()
                        GridView5.Columns(0).Caption = "Α/Α"
                        GridView5.Columns(1).Caption = "Ημερ/νία Καταχώρησης"
                        GridView5.Columns(2).Caption = "Αρ. Τιμολογίου"
                        GridView5.Columns(3).Caption = "Τύπος"
                        GridView5.Columns(4).Caption = "Ποσό"
                        KANELOPOULOS.Dispose()
                        KANELOPOULOS_TRANS()
                        'Case 2
                        '    ALPHA.FileName = XtraOpenFileDialog1.FileName
                        '    sFileName = XtraOpenFileDialog1.SafeFileName
                        '    GridView5.Columns.Clear() : grdBANKS.DataSource = Nothing : ALPHA.Fill() : grdBANKS.DataSource = ALPHA
                        '    grdBANKS.ForceInitialize() : grdBANKS.DefaultView.PopulateColumns()
                        '    GridView5.Columns(0).Caption = "Ημερ/νία Καταχώρησης"
                        '    GridView5.Columns(1).Caption = "Αιτιολογία"
                        '    GridView5.Columns(2).Caption = "Ποσό"
                        '    ALPHA.Dispose()
                        '    ALPHA_TRANS()
                        'Case 3
                        '    EUROBANK.FileName = XtraOpenFileDialog1.FileName
                        '    sFileName = XtraOpenFileDialog1.SafeFileName
                        '    GridView5.Columns.Clear() : grdBANKS.DataSource = Nothing : EUROBANK.Fill() : grdBANKS.DataSource = EUROBANK
                        '    grdBANKS.ForceInitialize() : grdBANKS.DefaultView.PopulateColumns()
                        '    GridView5.Columns(0).Caption = "Ημερ/νία Καταχώρησης"
                        '    GridView5.Columns(1).Caption = "Αιτιολογία"
                        '    GridView5.Columns(2).Caption = "Ποσό"
                        '    EUROBANK.Dispose()
                        '    EUROBANK_TRANS()
                        'Case 4
                        '    NBG.FileName = XtraOpenFileDialog1.FileName
                        '    sFileName = XtraOpenFileDialog1.SafeFileName
                        '    GridView5.Columns.Clear() : grdBANKS.DataSource = Nothing : NBG.Fill() : grdBANKS.DataSource = NBG
                        '    grdBANKS.ForceInitialize() : grdBANKS.DefaultView.PopulateColumns()
                        '    GridView5.Columns(0).Caption = "Ημερ/νία Καταχώρησης"
                        '    GridView5.Columns(1).Caption = "Ποσό"
                        '    GridView5.Columns(2).Caption = "Αιτιολογία"
                        '    NBG.Dispose()
                        '    NBG_TRANS()
                End Select
            Else
                grdINVOICES.DataSource = Nothing
                Select Case SupMode
                    Case 1
                        'Dim sActiveFilter As String
                        'sActiveFilter = GridView5.ActiveFilterString
                        'GridView5.ActiveFilterString = ""
                        'Me.PIREOSTableAdapter.Fill(Me.Priamos_NETDataSet3.PIREOS)
                        'grdINVOICES.DataSource = Me.Priamos_NETDataSet3.PIREOS
                        'grdINVOICES.ForceInitialize() : grdINVOICES.DefaultView.PopulateColumns()
                        'LoadForms.RestoreLayoutFromXml(GridView5, "PIREOS.xml")
                        'GridView5.ActiveFilterString = sActiveFilter

                        'Case 2
                        '    'Dim sActiveFilter As String
                        '    'sActiveFilter = GridView5.ActiveFilterString
                        '    'GridView5.ActiveFilterString = ""
                        '    Me.ALPHATableAdapter.Fill(Me.Priamos_NETDataSet3.ALPHA)
                        '    grdINVOICES.DataSource = Me.Priamos_NETDataSet3.ALPHA
                        '    grdINVOICES.ForceInitialize() : grdINVOICES.DefaultView.PopulateColumns()
                        '    LoadForms.RestoreLayoutFromXml(GridView5, "ALPHA.xml")
                        '    'GridView5.ActiveFilterString = sActiveFilter

                        'Case 3
                        '    'Dim sActiveFilter As String
                        '    'sActiveFilter = GridView5.ActiveFilterString

                        '    'GridView5.ActiveFilterString = ""
                        '    Me.EUROBANKTableAdapter.Fill(Me.Priamos_NETDataSet3.EUROBANK)
                        '    grdINVOICES.DataSource = Me.Priamos_NETDataSet3.EUROBANK
                        '    grdINVOICES.ForceInitialize() : grdINVOICES.DefaultView.PopulateColumns()
                        '    LoadForms.RestoreLayoutFromXml(GridView5, "EUROBANK.xml")
                        '    'GridView5.ActiveFilterString = sActiveFilter

                        'Case 4
                        '    'Dim sActiveFilter As String
                        '    'sActiveFilter = GridView5.ActiveFilterString

                        '    'GridView5.ActiveFilterString = ""
                        '    Me.NBGTableAdapter.Fill(Me.Priamos_NETDataSet3.NBG)
                        '    grdINVOICES.DataSource = Me.Priamos_NETDataSet3.NBG
                        '    grdINVOICES.ForceInitialize() : grdINVOICES.DefaultView.PopulateColumns()
                        '    LoadForms.RestoreLayoutFromXml(GridView5, "NBG.xml")
                        '    'GridView5.ActiveFilterString = sActiveFilter

                End Select
            End If
            GridView5.BestFitColumns()

        Catch ex As DevExpress.DataAccess.Excel.InvalidWorksheetNameValidationException
            Select Case SupMode
                Case 1 : XtraMessageBox.Show("Το excel που επιλέξατε δεν ανήκει στον προμηθευτή Κανελλόπουλο", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Case 2 : XtraMessageBox.Show("Το excel που επιλέξατε δεν ανήκει στην τράπεζα Alpha", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Case 3 : XtraMessageBox.Show("Το excel που επιλέξατε δεν ανήκει στην τράπεζα Eurobank", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Case 4 : XtraMessageBox.Show("Το excel που επιλέξατε δεν ανήκει στην τράπεζα Εθνική", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Select

        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try

    End Sub
    Private Sub KANELOPOULOS_TRANS()
        Dim sInvNumber As String, sDate As String, sVatAmount As Double, sNetAmount As Double
        Dim sOrd As Integer
        Dim supID As String = "89251045-64C7-4E35-9CAF-51D020279CFE", sdocTypeID As String, sdocTypeDescr As String
        Dim Cmd As SqlCommand, sdr As SqlDataReader
        Dim ItemsCorrect As Integer = 0, ItemsWrong As Integer = 0
        Dim sKanelopoulosID As String, sKanelopoulosFileID As String
        Try
            '    LayoutControlItem8.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
            ProgressBarControl1.EditValue = 0
            ProgressBarControl1.Properties.Step = 1
            ProgressBarControl1.Properties.PercentView = True
            ProgressBarControl1.Properties.Maximum = GridView5.DataRowCount - 1
            ProgressBarControl1.Properties.Minimum = 0
            lstLog.Items.Clear()
            Dim sSQL As New System.Text.StringBuilder
            Cmd = New SqlCommand("TRUNCATE TABLE KANELLOPOULOS", CNDB) : Cmd.ExecuteNonQuery()
            sKanelopoulosFileID = System.Guid.NewGuid.ToString
            For i As Integer = 0 To GridView5.DataRowCount - 1
                If GridView5.GetRowCellValue(i, GridView5.Columns(2).FieldName) IsNot Nothing Then
                    If GridView5.GetRowCellValue(i, GridView5.Columns(2).FieldName) IsNot Nothing Then sInvNumber = GridView5.GetRowCellValue(i, GridView5.Columns(2).FieldName).ToString().Trim
                    If sInvNumber <> "Παραστατικό" And sInvNumber <> "Από μεταφορά" Then
                        If GridView5.GetRowCellValue(i, GridView5.Columns(1).FieldName) IsNot Nothing Then sDate = CDate(GridView5.GetRowCellValue(i, GridView5.Columns(1).FieldName).ToString())
                        sOrd = GridView5.GetRowCellValue(i, GridView5.Columns(0).FieldName)
                        If GridView5.GetRowCellValue(i, GridView5.Columns(4).FieldName) IsNot Nothing Then
                            sVatAmount = GridView5.GetRowCellValue(i, GridView5.Columns(4).FieldName)
                            sNetAmount = sVatAmount / 1.24
                        Else
                            sVatAmount = 0
                        End If

                        sdocTypeDescr = GridView5.GetRowCellValue(i, GridView5.Columns(3).FieldName)
                        If sdocTypeDescr.Length > 0 Then
                            Cmd = New SqlCommand("SELECT top 1 ID FROM DOC_TYPES (nolock) WHERE name= " & toSQLValueS(sdocTypeDescr) & " and supID= " & toSQLValueS(supID), CNDB)
                            sdr = Cmd.ExecuteReader()
                            If (sdr.Read() = True) Then sdocTypeID = sdr.GetGuid(sdr.GetOrdinal("ID")).ToString
                            sdr.Close()
                        End If
                        Try
                            sKanelopoulosID = System.Guid.NewGuid.ToString
                            'Εισαγωγή εγγραφών από Excel sthn Βάση
                            sSQL.AppendLine("INSERT INTO KANELLOPOULOS (ID,ord,supID,invDate,invNumber,netAmount,vatAmount, docTypeId,uploadDate,createdOn,createdBy,buyFID) VALUES( ")
                            sSQL.AppendLine(toSQLValueS(sKanelopoulosID) & ",")
                            sSQL.AppendLine(toSQLValueS(sOrd, True) & ",")
                            sSQL.AppendLine(toSQLValueS(supID) & ",")
                            If sDate.Length > 0 Then sSQL.AppendLine(toSQLValueS(CDate(sDate).ToString("yyyyMMdd")) & ",") Else sSQL.AppendLine("NULL,")
                            sSQL.AppendLine(toSQLValueS(sInvNumber) & ",")
                            sSQL.AppendLine(toSQLValueS(sNetAmount, True) & ",")
                            sSQL.AppendLine(toSQLValueS(sVatAmount, True) & ",")
                            sSQL.AppendLine(toSQLValueS(sdocTypeID) & ",")
                            sSQL.AppendLine("getdate(),")
                            sSQL.AppendLine("getdate(),")
                            sSQL.AppendLine(toSQLValueS(UserProps.ID.ToString) & ",")
                            sSQL.AppendLine(toSQLValueS(sKanelopoulosFileID) & ")")

                            Using oCmd As New SqlCommand(sSQL.ToString, CNDB)
                                oCmd.ExecuteNonQuery()
                            End Using
                            lstLog.Items.Add("Η εγγραφή Καταχωρήθηκε με επιτυχία!-->" & sInvNumber)
                            lstLog.Items(lstLog.Items.Count - 1).ImageOptions.Image = ImageCollection1.Images.Item(0)
                            lstLog.Items(lstLog.Items.Count - 1).Tag = sKanelopoulosID
                            ItemsCorrect = ItemsCorrect + 1
                        Catch dbException As System.Data.SqlClient.SqlException
                            lstLog.Items.Add("Το τιμολόγιο με αριθμό " & sInvNumber & " και ημερομηνία " & sDate & " υπάρχει ήδη.")
                            lstLog.Items(lstLog.Items.Count - 1).ImageOptions.Image = ImageCollection1.Images.Item(4)
                            ItemsWrong = ItemsWrong + 1
                        Catch ex As Exception
                            lstLog.Items.Add(ex.Message.ToString.Replace(vbCrLf, ""))
                            lstLog.Items(lstLog.Items.Count - 1).ImageOptions.Image = ImageCollection1.Images.Item(1)
                            ItemsWrong = ItemsWrong + 1
                        End Try
                        sSQL.Clear()
                    End If
                End If
                ProgressBarControl1.PerformStep()
                ProgressBarControl1.Update()
                sInvNumber = "" : sDate = ""
            Next i
            grdINVOICES.DataSource = Nothing
            Me.KANELLOPOULOSTableAdapter.Fill(Me.DMDataSet.KANELLOPOULOS)
            grdINVOICES.DataSource = Me.DMDataSet.KANELLOPOULOS
            grdINVOICES.ForceInitialize() : grdINVOICES.DefaultView.PopulateColumns()
            LoadForms.RestoreLayoutFromXml(GridView5, "KANELLOPOULOS.xml")
            GridView5.BestFitColumns()

            lstLog.Items.Add("Καταχωρήθηκαν: " & ItemsCorrect & " Λάθοι: " & ItemsWrong)
            lstLog.Items(lstLog.Items.Count - 1).ImageOptions.Image = ImageCollection1.Images.Item(2)
            If ItemsCorrect > 0 Then
                Dim sResult As Boolean = DBQ.InsertNewDataFiles(XtraOpenFileDialog1, "BUY_F", sKanelopoulosFileID)
                If sResult = False Then XtraMessageBox.Show("Προσοχή το αρχείο Excel δεν αποθηκεύθηκε στην βάση", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            '    LayoutControlItem8.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
            'LayoutControlItem8.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        End Try

    End Sub
    Private Sub GridView5_ValidatingEditor(sender As Object, e As BaseContainerValidateEditorEventArgs) Handles GridView5.ValidatingEditor
        Dim kitchen As Double, materials As Double, general As Double, closet As Double, bathroomFurn As Double
        Dim Found As Integer = 0

        kitchen = GridView5.GetRowCellValue(GridView5.FocusedRowHandle, "kitchen")
        materials = GridView5.GetRowCellValue(GridView5.FocusedRowHandle, "materials")
        general = GridView5.GetRowCellValue(GridView5.FocusedRowHandle, "general")
        closet = GridView5.GetRowCellValue(GridView5.FocusedRowHandle, "closet")
        bathroomFurn = GridView5.GetRowCellValue(GridView5.FocusedRowHandle, "bathroomFurn")
        If kitchen <> 0 Then Found = Found + 1
        If materials <> 0 Then Found = Found + 1
        If general <> 0 Then Found = Found + 1
        If closet <> 0 Then Found = Found + 1
        If bathroomFurn <> 0 Then Found = Found + 1

        If Found > 1 Then
            e.ErrorText = "Έχετε συμπληρώσει περισσότερες από 2 στήλες με ποσό στο ίδιο παραστατικό"
            GridView5.SetRowCellValue(GridView5.FocusedRowHandle, GridView5.FocusedColumn.FieldName, 0)
            e.Valid = False
        End If
    End Sub

    Private Sub RepCopy_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles RepCopy.ButtonClick
        GridView5.SetRowCellValue(GridView5.FocusedRowHandle, GridView5.FocusedColumn.FieldName, GridView5.GetRowCellValue(GridView5.FocusedRowHandle, "netAmount"))
        GridView5.ValidateEditor()
    End Sub

    Private Sub cmdExit_Click(sender As Object, e As EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub

    Private Sub GridView5_PopupMenuShowing(sender As Object, e As DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs) Handles GridView5.PopupMenuShowing
        If e.MenuType = GridMenuType.Column Then

            LoadForms.PopupMenuShow(e, GridView5, "KANELLOPOULOS.xml", "KANELLOPOULOS")


        End If
    End Sub
End Class