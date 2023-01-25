Imports System.Data.SqlClient
Imports System.Text
Imports System.Text.RegularExpressions
Imports DevExpress.CodeParser
Imports DevExpress.DataAccess
Imports DevExpress.DataAccess.Native
Imports DevExpress.Office.PInvoke.Win32
Imports DevExpress.Xpo
Imports DevExpress.XtraBars.Navigation
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraExport.Helpers
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraLayout
Imports DevExpress.XtraMap.Drawing.DirectD3D9
Imports DevExpress.XtraRichEdit.Utils
Imports iTextSharp.text

Public Class frmBuyCollectionInsert
    Private DBQ As New DBQueries
    Private LoadForms As New FormLoader
    Private SupMode As Integer
    Private sFileName As String
    Private repCCTID As String = ""
    Private reptranshID As String = ""
    Private sCmt As String = ""

    Private Sub frmBuyCollectionInsert_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DMDataSet.CCT_TRANSH' table. You can move, or remove it, as needed.
        Me.CCT_TRANSHTableAdapter.Fill(Me.DMDataSet.CCT_TRANSH)
        'TODO: This line of code loads data into the 'DreamyKitchenDataSet.vw_BUY' table. You can move, or remove it, as needed.
        Me.KANELLOPOULOSTableAdapter.Fill(Me.DMDataSet.KANELLOPOULOS)
        LoadForms.RestoreLayoutFromXml(GridView5, "KANELLOPOULOS.xml")
        AddHandler RepTransh.EditValueChanged, AddressOf RepTransh_Changed
        AddHandler RepCus.EditValueChanged, AddressOf RepCus_Changed
        AddHandler RepKan_O.KeyDown, AddressOf RepKan_O_KeyDown
        SupMode = 1
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
        reptranshID = editor.EditValue.ToString
        repCCTID = GridView5.GetRowCellValue(GridView5.FocusedRowHandle, "cctID").ToString.ToUpper
    End Sub
    Private Sub RepCus_Changed(sender As Object, e As EventArgs)
        Dim editor As DevExpress.XtraEditors.LookUpEdit = TryCast(sender, DevExpress.XtraEditors.LookUpEdit)
        If editor.EditValue Is Nothing Then Exit Sub
        repCCTID = editor.EditValue.ToString
    End Sub
    Private Sub RepKan_O_KeyDown(sender As Object, e As EventArgs)
        Dim k As KeyEventArgs = e
        If k.KeyCode = Keys.Enter Then
            Dim editor As DevExpress.XtraEditors.LookUpEdit = TryCast(sender, DevExpress.XtraEditors.LookUpEdit)
            If editor.Controls(0).Text Is Nothing Then Exit Sub
            Dim KanOName As String = editor.Controls(0).Text
            Dim sSQL As New System.Text.StringBuilder
            sSQL.AppendLine("INSERT INTO KANELLOPOULOS_O (kanID,name) VALUES( ")
            sSQL.AppendLine(toSQLValueS(GridView5.GetRowCellValue(GridView5.FocusedRowHandle, "ID").ToString.ToUpper) & ",")
            sSQL.AppendLine(toSQLValueS(KanOName) & ")")
            Using oCmd As New SqlCommand(sSQL.ToString, CNDB)
                oCmd.ExecuteNonQuery()
            End Using
            Dim ID As String = GridView5.GetRowCellValue(GridView5.FocusedRowHandle, "ID").ToString()
            If ID.Length > 0 Then editor.Properties.DataSource = Me.KANELLOPOULOS_OTableAdapter.GetData(System.Guid.Parse(ID))
            editor.EditValue = 0
            editor.Text = ""
        End If

    End Sub

    Private Sub GridView5_ShownEditor(sender As Object, e As EventArgs) Handles GridView5.ShownEditor
        Dim view As ColumnView = DirectCast(sender, ColumnView)
        Try
            If GridView5.FocusedRowHandle < 0 Then Exit Sub
            Dim cctID As String = GridView5.GetRowCellValue(GridView5.FocusedRowHandle, "cctID").ToString()
            Dim ID As String = GridView5.GetRowCellValue(GridView5.FocusedRowHandle, "ID").ToString()
            If view.FocusedColumn.FieldName = "transhID" Then
                Dim editor As LookUpEdit = CType(view.ActiveEditor, LookUpEdit)
                If cctID.Length > 0 Then editor.Properties.DataSource = Me.Vw_TRANSHTableAdapter.GetData(System.Guid.Parse(cctID))
            ElseIf view.FocusedColumn.Name = "colKanO" Then
                Dim editor As LookUpEdit = CType(view.ActiveEditor, LookUpEdit)
                If ID.Length > 0 Then editor.Properties.DataSource = Me.KANELLOPOULOS_OTableAdapter.GetData(System.Guid.Parse(ID))
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

                End Select
            Else
                grdINVOICES.DataSource = Nothing
                Select Case SupMode
                    Case 1
                        Me.KANELLOPOULOSTableAdapter.Fill(Me.DMDataSet.KANELLOPOULOS)
                        grdINVOICES.DataSource = Me.DMDataSet.KANELLOPOULOS
                        grdINVOICES.ForceInitialize() : grdINVOICES.DefaultView.PopulateColumns()
                        LoadForms.RestoreLayoutFromXml(GridView5, "KANELLOPOULOS.xml")

                End Select
            End If


        Catch ex As DevExpress.DataAccess.Excel.InvalidWorksheetNameValidationException
            Select Case SupMode
                Case 1 : XtraMessageBox.Show("Το excel που επιλέξατε δεν ανήκει στον προμηθευτή Κανελλόπουλο", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Select

        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try

    End Sub
    Private Sub KANELOPOULOS_TRANS()
        Dim sInvNumber As String, sDate As String, sVatAmount As Double, sNetAmount As Double
        Dim sOrd As Integer, isCredit As Boolean
        Dim supID As String = "89251045-64C7-4E35-9CAF-51D020279CFE", sdocTypeID As String, sdocTypeDescr As String
        Dim Cmd As SqlCommand, sdr As SqlDataReader
        Dim ItemsCorrect As Integer = 0, ItemsWrong As Integer = 0
        Dim sKanelopoulosID As String, sKanelopoulosFileID As String
        Try
            LayoutControlItem4.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
            ProgressBarControl1.EditValue = 0
            ProgressBarControl1.Properties.Step = 1
            ProgressBarControl1.Properties.PercentView = True
            ProgressBarControl1.Properties.Maximum = GridView5.DataRowCount - 1
            ProgressBarControl1.Properties.Minimum = 0
            lstLog.Items.Clear()
            Dim sSQL As New System.Text.StringBuilder
            'Cmd = New SqlCommand("TRUNCATE TABLE KANELLOPOULOS", CNDB) : Cmd.ExecuteNonQuery()
            sKanelopoulosFileID = System.Guid.NewGuid.ToString
            For i As Integer = 0 To GridView5.DataRowCount - 1
                If GridView5.GetRowCellValue(i, GridView5.Columns(2).FieldName) IsNot Nothing Then
                    If GridView5.GetRowCellValue(i, GridView5.Columns(2).FieldName) IsNot Nothing Then sInvNumber = GridView5.GetRowCellValue(i, GridView5.Columns(2).FieldName).ToString().Trim
                    If sInvNumber <> "Παραστατικό" And sInvNumber <> "Από μεταφορά" And sInvNumber <> "" Then
                        If sInvNumber.Substring(0, 4) <> "ΕΠΠΛ" And sInvNumber.Substring(0, 4) <> "ΕΜΒΠ" Then

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
                                Cmd = New SqlCommand("SELECT top 1 ID,Vmultiplier FROM DOC_TYPES (nolock) WHERE name= " & toSQLValueS(sdocTypeDescr) & " and supID= " & toSQLValueS(supID), CNDB)
                                sdr = Cmd.ExecuteReader()
                                If (sdr.Read() = True) Then
                                    sdocTypeID = sdr.GetGuid(sdr.GetOrdinal("ID")).ToString
                                    'Αυτόματη Είσπραξη Μετρητών(Aπο Τιμολογηση)
                                    If sdocTypeID.ToUpper = "D5257744-1705-4D27-BB6B-E908EA65DAE4" Then
                                        sVatAmount = GridView5.GetRowCellValue(i, GridView5.Columns(5).FieldName) * sdr.GetInt32(sdr.GetOrdinal("Vmultiplier"))
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
                                sSQL.AppendLine(toSQLValueS(supID) & ",")
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
                                lstLog.Items.Add("Η εγγραφή Καταχωρήθηκε με επιτυχία!-->" & sInvNumber)
                                lstLog.Items(lstLog.Items.Count - 1).ImageOptions.Image = ImageCollection1.Images.Item(0)
                                lstLog.Items(lstLog.Items.Count - 1).Tag = sKanelopoulosID
                                ItemsCorrect = ItemsCorrect + 1
                                lstLog.SelectedIndex = lstLog.ItemCount + 1
                                lstLog.Refresh()
                            Catch dbException As System.Data.SqlClient.SqlException
                                lstLog.Items.Add("Το τιμολόγιο με αριθμό " & sInvNumber & " και ημερομηνία " & sDate & " υπάρχει ήδη.")
                                lstLog.Items(lstLog.Items.Count - 1).ImageOptions.Image = ImageCollection1.Images.Item(4)
                                ItemsWrong = ItemsWrong + 1
                                lstLog.SelectedIndex = lstLog.ItemCount + 1
                                lstLog.Refresh()
                            Catch ex As Exception
                                lstLog.Items.Add(ex.Message.ToString.Replace(vbCrLf, ""))
                                lstLog.Items(lstLog.Items.Count - 1).ImageOptions.Image = ImageCollection1.Images.Item(1)
                                ItemsWrong = ItemsWrong + 1
                                lstLog.SelectedIndex = lstLog.ItemCount + 1
                                lstLog.Refresh()
                            End Try
                            sSQL.Clear()
                        End If
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


            lstLog.Items.Add("Καταχωρήθηκαν: " & ItemsCorrect & " Λάθοι: " & ItemsWrong)
            lstLog.Items(lstLog.Items.Count - 1).ImageOptions.Image = ImageCollection1.Images.Item(2)
            lstLog.SelectedIndex = lstLog.ItemCount + 1
            lstLog.Refresh()
            If ItemsCorrect > 0 Then
                Dim sResult As Boolean = DBQ.InsertNewDataFiles(XtraOpenFileDialog1, "BUY_F", sKanelopoulosFileID)
                If sResult = False Then XtraMessageBox.Show("Προσοχή το αρχείο Excel δεν αποθηκεύθηκε στην βάση", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            LayoutControlItem4.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
            LayoutControlItem4.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        End Try

    End Sub
    Private Sub InsertRecordsToBuy()
        Dim sInvNumber As String, sDate As String, sVatAmount As Double, sNetAmount As Double
        Dim kitchen As Double, materials As Double, general As Double, closet As Double, bathroomFurn As Double
        Dim sOrd As String, cmt As String
        Dim supID As String, sdocTypeID As String, sCusID As String, sTranshID As String, sPayID As String
        Dim selectedRowHandles As Int32() = GridView5.GetSelectedRows
        Dim ItemsCorrect As Integer = 0, ItemsWrong As Integer = 0
        Dim sbuyID As String
        Dim Found As Integer = 0
        Try
            LayoutControlItem4.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
            ProgressBarControl1.EditValue = 0
            ProgressBarControl1.Properties.Step = 1
            ProgressBarControl1.Properties.PercentView = True
            ProgressBarControl1.Properties.Maximum = GridView5.DataRowCount - 1
            ProgressBarControl1.Properties.Minimum = 0
            lstLog.Items.Clear()
            Dim sSQL As New System.Text.StringBuilder
            For I = 0 To selectedRowHandles.Length - 1
                Try
                    Dim selectedRowHandle As Int32 = selectedRowHandles(I)
                    If GridView5.GetRowCellValue(selectedRowHandle, "completed") = "False" Then

                        sbuyID = System.Guid.NewGuid.ToString
                        supID = GridView5.GetRowCellValue(selectedRowHandle, "supID").ToString
                        sInvNumber = GridView5.GetRowCellValue(selectedRowHandle, "invNumber")
                        cmt = GridView5.GetRowCellValue(selectedRowHandle, "cmt").ToString
                        sDate = CDate(GridView5.GetRowCellValue(selectedRowHandle, "invDate"))
                        sdocTypeID = GridView5.GetRowCellValue(selectedRowHandle, "docTypeID").ToString
                        sOrd = "(select max(ord) + 1 FROM BUY where supID = " & toSQLValueS(supID) & " and dtYBuy = " & toSQLValueS(Year(GridView5.GetRowCellValue(selectedRowHandle, "invDate")), True) & ")"
                        sCusID = GridView5.GetRowCellValue(selectedRowHandle, "cctID").ToString
                        sTranshID = GridView5.GetRowCellValue(selectedRowHandle, "transhID").ToString
                        sPayID = "(select PAY.ID from PAY inner join sup on sup.payID=PAY.id where sup.id = " & toSQLValueS(supID) & ")"
                        kitchen = GridView5.GetRowCellValue(selectedRowHandle, "kitchen")
                        materials = GridView5.GetRowCellValue(selectedRowHandle, "materials")
                        general = GridView5.GetRowCellValue(selectedRowHandle, "general")
                        closet = GridView5.GetRowCellValue(selectedRowHandle, "closet")
                        bathroomFurn = GridView5.GetRowCellValue(selectedRowHandle, "bathroomFurn")
                        sNetAmount = GridView5.GetRowCellValue(selectedRowHandle, "netAmount")
                        sVatAmount = GridView5.GetRowCellValue(selectedRowHandle, "vatAmount")
                        If kitchen <> 0 Then Found = Found + 1
                        If materials <> 0 Then Found = Found + 1
                        If general <> 0 Then Found = Found + 1
                        If closet <> 0 Then Found = Found + 1
                        If bathroomFurn <> 0 Then Found = Found + 1

                        'Εαν έχει περάσει έστω και ένα ποσό μόνο τότε θα γίνει η καταχώρηση στις αγορές
                        If Found > 0 Then


                            sSQL.AppendLine("INSERT INTO BUY (ID, ord, dtBuy, invoiceNumber, docTypeID, supID, cusID, transhID, payID, paid, kitchen, closet, general, materials, bathroomFurn, netAmount, " &
                                            " vatAmount,ComeFrom,cmt,createdOn,createdBy) VALUES( ")
                            sSQL.AppendLine(toSQLValueS(sbuyID) & ",")
                            sSQL.AppendLine(sOrd & ",")
                            sSQL.AppendLine(toSQLValueS(CDate(sDate).ToString("yyyyMMdd")) & ",")
                            sSQL.AppendLine(toSQLValueS(sInvNumber) & ",")
                            sSQL.AppendLine(toSQLValueS(sdocTypeID) & ",")
                            sSQL.AppendLine(toSQLValueS(supID) & ",")
                            sSQL.AppendLine(toSQLValueS(sCusID) & ",")
                            sSQL.AppendLine(toSQLValueS(sTranshID) & ",")
                            sSQL.AppendLine(sPayID & ",")
                            sSQL.AppendLine("0" & ",")
                            sSQL.AppendLine(toSQLValueS(kitchen, True) & ",")
                            sSQL.AppendLine(toSQLValueS(closet, True) & ",")
                            sSQL.AppendLine(toSQLValueS(general, True) & ",")
                            sSQL.AppendLine(toSQLValueS(materials, True) & ",")
                            sSQL.AppendLine(toSQLValueS(bathroomFurn, True) & ",")
                            sSQL.AppendLine(toSQLValueS(sNetAmount, True) & ",")
                            sSQL.AppendLine(toSQLValueS(sVatAmount, True) & ",")
                            sSQL.AppendLine("1" & ",")
                            sSQL.AppendLine(toSQLValueS(cmt) & ",")
                            sSQL.AppendLine("getdate(),")
                            sSQL.AppendLine(toSQLValueS(UserProps.ID.ToString) & ")")

                            Using oCmd As New SqlCommand(sSQL.ToString, CNDB)
                                oCmd.ExecuteNonQuery()
                            End Using
                            lstLog.Items.Add("Η εγγραφή με ημερομηνία " & sDate & " Καταχωρήθηκε με επιτυχία!-->" & sInvNumber)
                            lstLog.Items(lstLog.Items.Count - 1).ImageOptions.Image = ImageCollection1.Images.Item(0)

                            'Ενημέρωση πίνακα KANELLOPOYLOS με ολοκληρωμένο
                            Using oCmd As New SqlCommand("UPDATE KANELLOPOULOS SET buyID = " & toSQLValueS(sbuyID) & ", completed = 1 where ID = " & toSQLValueS(GridView5.GetRowCellValue(selectedRowHandle, "ID").ToString), CNDB)
                                oCmd.ExecuteNonQuery()
                            End Using

                            Dim ssSQL = "DELETE FROM SUP_PAYMENTS_P  WHERE buyID = " & toSQLValueS(sbuyID)
                            Using oCmd As New SqlCommand(ssSQL, CNDB)
                                oCmd.ExecuteNonQuery()
                            End Using
                            ssSQL = "INSERT SUP_PAYMENTS_P  SELECT NEWID(),ID,vatAmount from BUY WHERE ID = " & toSQLValueS(sbuyID)
                            Using oCmd As New SqlCommand(ssSQL, CNDB)
                                oCmd.ExecuteNonQuery()
                            End Using

                            ' Διαγραφή δελτίων Παραγγελίας
                            ssSQL = "DELETE FROM BUY_O WHERE buyID = " & toSQLValueS(sbuyID)
                            Using oCmd As New SqlCommand(ssSQL, CNDB)
                                oCmd.ExecuteNonQuery()
                            End Using
                            ' ΚΑταχώρηση δελτίων Παραγγελίας
                            ssSQL = "INSERT INTO BUY_O (name,buyID,createdON,createdBy,modifiedBy) SELECT name," & toSQLValueS(sbuyID) & ",getdate()," & toSQLValueS(UserProps.ID.ToString) & "," & toSQLValueS(UserProps.ID.ToString) & " FROM KANELLOPOULOS_O where kanID = " & toSQLValueS(GridView5.GetRowCellValue(selectedRowHandle, "ID").ToString)
                            Using oCmd As New SqlCommand(ssSQL, CNDB)
                                oCmd.ExecuteNonQuery()
                            End Using

                            If sTranshID.Length > 0 Then
                                ' Άνοιγμα έργου αν δεν υπάρχει ή ενημέρωση ποσών
                                Using oCmd As New SqlCommand("usp_CreateProjectcost", CNDB)
                                    oCmd.CommandType = CommandType.StoredProcedure
                                    oCmd.Parameters.AddWithValue("@transhID", sTranshID)
                                    oCmd.ExecuteNonQuery()
                                End Using
                            End If


                            ItemsCorrect = ItemsCorrect + 1
                            ProgressBarControl1.PerformStep()
                            ProgressBarControl1.Update()
                        Else
                            lstLog.Items.Add("Η εγγραφή με ημερομηνία " & sDate & " είναι και παραστατικό-->" & sInvNumber & " δεν έχει ποσά περασμένα")
                            lstLog.Items(lstLog.Items.Count - 1).ImageOptions.Image = ImageCollection1.Images.Item(1)
                            Found = 0
                        End If
                    Else
                        lstLog.Items.Add("Η εγγραφή με ημερομηνία " & sDate & " είναι ήδη ολοκληρωμένη και δεν θα καταχωρηθεί ξανά!-->" & sInvNumber)
                        lstLog.Items(lstLog.Items.Count - 1).ImageOptions.Image = ImageCollection1.Images.Item(1)
                    End If
                Catch dbException As System.Data.SqlClient.SqlException
                    lstLog.Items.Add("Το τιμολόγιο με αριθμό " & sInvNumber & " και ημερομηνία " & sDate & " υπάρχει ήδη.")
                    lstLog.Items(lstLog.Items.Count - 1).ImageOptions.Image = ImageCollection1.Images.Item(4)
                    ItemsWrong = ItemsWrong + 1
                Catch ex As Exception
                    lstLog.Items.Add(ex.Message.ToString.Replace(vbCrLf, ""))
                    lstLog.Items(lstLog.Items.Count - 1).ImageOptions.Image = ImageCollection1.Images.Item(1)
                    ItemsWrong = ItemsWrong + 1
                End Try
                sSQL.Clear() : Found = 0
            Next I

            If ItemsCorrect > 0 Then
                'Ενημέρωση υπολοίπου προμηθευτή όταν το τιμολόγιο δεν είναι πληρωμένο και δεν είναι μετρητοίς
                Using oCmd As New SqlCommand("FIX_SUP_BAL", CNDB)
                    oCmd.CommandType = CommandType.StoredProcedure
                    oCmd.Parameters.AddWithValue("@supplierID", supID)
                    oCmd.ExecuteNonQuery()
                End Using
            End If

            grdINVOICES.DataSource = Nothing
            Me.KANELLOPOULOSTableAdapter.Fill(Me.DMDataSet.KANELLOPOULOS)
            grdINVOICES.DataSource = Me.DMDataSet.KANELLOPOULOS
            grdINVOICES.ForceInitialize() : grdINVOICES.DefaultView.PopulateColumns()
            LoadForms.RestoreLayoutFromXml(GridView5, "KANELLOPOULOS.xml")


            lstLog.Items.Add("Καταχωρήθηκαν: " & ItemsCorrect & " Λάθοι: " & ItemsWrong)
            lstLog.Items(lstLog.Items.Count - 1).ImageOptions.Image = ImageCollection1.Images.Item(2)

            LayoutControlItem4.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
            LayoutControlItem4.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        End Try

    End Sub
    Private Sub GridView5_ValidatingEditor(sender As Object, e As BaseContainerValidateEditorEventArgs) Handles GridView5.ValidatingEditor
        Dim kitchen As Double, materials As Double, general As Double, closet As Double, bathroomFurn As Double
        Dim Found As Integer = 0
        If GridView5.FocusedColumn.Name = "colKanO" Then Exit Sub
        If GridView5.GetRowCellValue(GridView5.FocusedRowHandle, "completed") = "True" And sender.FocusedColumn.FieldName <> "completed" Then
            e.ErrorText = "Δεν μπορείτε να αλλάξετε Ολοκληρωμένη εγγραφή"
            e.Valid = False
            Exit Sub
        End If


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
            Exit Sub
        End If
        If Found = 0 And sender.FocusedColumn.FieldName = "completed" And e.Value = Nothing Then
            e.ErrorText = "Δεν μπορείτε να κάνετε ολοκληρωμένο το Παραστατικό χωρίς να έχετε περάσει ποσά"
            e.Valid = False
            Exit Sub
        End If
        If e.Value IsNot Nothing Then
            If Found = 0 And sender.FocusedColumn.FieldName = "completed" And e.Value.ToString = "True" Then
                e.ErrorText = "Δεν μπορείτε να κάνετε ολοκληρωμένο το Παραστατικό χωρίς να έχετε περάσει ποσά"
                e.Valid = False
                Exit Sub
            End If
        End If

        If sender.FocusedColumn.FieldName = "cmt" Then GridView5.SetRowCellValue(GridView5.FocusedRowHandle, "cmt", e.Value)

        Dim CellValue As String = ""
        If e.Value IsNot Nothing Then CellValue = e.Value.ToString.ToUpper
        If sender.FocusedColumn.FieldName = "cctID" And CellValue = "" Then
            GridView5.SetRowCellValue(GridView5.FocusedRowHandle, "transhID", "") : GridView5.SetRowCellValue(GridView5.FocusedRowHandle, "FullTranshDescription", "")
        ElseIf sender.FocusedColumn.FieldName = "cctID" And CellValue <> GridView5.GetRowCellValue(GridView5.FocusedRowHandle, "cctID").ToString.ToUpper Then
            GridView5.SetRowCellValue(GridView5.FocusedRowHandle, "transhID", "") : GridView5.SetRowCellValue(GridView5.FocusedRowHandle, "FullTranshDescription", "")
        End If
        If sender.FocusedColumn.FieldName = "completed" Then UpdateColBuy(CellValue) Else UpdateColBuy()
    End Sub

    Private Sub RepCopy_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles RepCopyDelete.ButtonClick
        Select Case e.Button.Index
            Case 0 : GridView5.SetRowCellValue(GridView5.FocusedRowHandle, GridView5.FocusedColumn.FieldName, GridView5.GetRowCellValue(GridView5.FocusedRowHandle, "netAmount"))
            Case 1 : GridView5.SetRowCellValue(GridView5.FocusedRowHandle, GridView5.FocusedColumn.FieldName, 0)
        End Select
        repCCTID = GridView5.GetRowCellValue(GridView5.FocusedRowHandle, "cctID").ToString.ToUpper
        reptranshID = GridView5.GetRowCellValue(GridView5.FocusedRowHandle, "transhID").ToString.ToUpper
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
    Private Sub RepColExcel_Click(sender As Object, e As EventArgs) Handles RepColExcel.Click
        Dim sFName As String
        If GridView5.GetRowCellValue(GridView5.FocusedRowHandle, "buyFID") Is DBNull.Value Then Exit Sub

        Dim b() As Byte = GetFile(GridView5.GetRowCellValue(GridView5.FocusedRowHandle, "buyFID").ToString, sFName)
        If b Is Nothing Then XtraMessageBox.Show("Δεν έχει αντιστοιχηθεί αρχείο με την εγγραφή", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error) : Exit Sub
        If My.Computer.FileSystem.FileExists(My.Computer.FileSystem.SpecialDirectories.Temp & "\" & sFName) Then My.Computer.FileSystem.DeleteFile(My.Computer.FileSystem.SpecialDirectories.Temp & "\" & sFName)
        Try
            'Dim fs As IO.FileStream = New IO.FileStream(ProgProps.ServerPath & sFName, IO.FileMode.Create)
            Dim fs As System.IO.FileStream = New System.IO.FileStream(My.Computer.FileSystem.SpecialDirectories.Temp & "\" & sFName, System.IO.FileMode.Create)
            fs.Write(b, 0, b.Length)
            fs.Close()
            ShellExecute(My.Computer.FileSystem.SpecialDirectories.Temp & "\" & sFName)
        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Function GetFile(ByVal sRowID As String, ByRef sFName As String) As Byte()
        Dim sSQL As String
        Dim cmd As SqlCommand
        Dim sdr As SqlDataReader
        Dim bytes As Byte()

        sSQL = "Select  filename,files From BUY_F  WHERE ID = " & toSQLValueS(sRowID)
        cmd = New SqlCommand(sSQL, CNDB) : sdr = cmd.ExecuteReader()
        If sdr.Read() = True Then
            bytes = DirectCast(sdr("files"), Byte())
            sFName = sdr("filename")
            Return bytes
        End If
        sdr.Close()

    End Function
    Private Sub ShellExecute(ByVal File As String)
        Dim myProcess As New Process
        myProcess.StartInfo.FileName = File
        myProcess.StartInfo.UseShellExecute = True
        myProcess.StartInfo.RedirectStandardOutput = False
        myProcess.Start()
        myProcess.Dispose()
        myProcess.Close()
    End Sub
    Private Sub DeleteBatchRecords()
        Dim sSQL As String
        Dim selectedRowHandles As Int32() = GridView5.GetSelectedRows()
        Dim I As Integer
        Dim ItemsCorrect As Integer = 0, ItemsWrong As Integer = 0
        Try
            If selectedRowHandles.Length = 0 Then Exit Sub
            If XtraMessageBox.Show("Θέλετε να διαγραφούν η τρέχουσες εγγραφές?", "Dreamy Kitchen CRM", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbNo Then Exit Sub
            LayoutControlItem4.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
            ProgressBarControl1.EditValue = 0
            ProgressBarControl1.Properties.Step = 1
            ProgressBarControl1.Properties.PercentView = True
            ProgressBarControl1.Properties.Maximum = selectedRowHandles.Length - 1
            ProgressBarControl1.Properties.Minimum = 0
            lstLog.Items.Clear()

            For I = 0 To selectedRowHandles.Length - 1
                Dim selectedRowHandle As Int32 = selectedRowHandles(I)

                'If GridView5.GetRowCellValue(selectedRowHandle, "ID") = Nothing Then Exit Sub
                If GridView5.GetRowCellValue(selectedRowHandle, "completed") = "False" Then

                    Select Case SupMode
                        Case 1 : sSQL = "DELETE FROM KANELLOPOULOS WHERE ID = '" & GridView5.GetRowCellValue(selectedRowHandle, "ID").ToString & "'"
                    End Select
                    Try

                        Using oCmd As New SqlCommand(sSQL, CNDB)
                            oCmd.ExecuteNonQuery()
                        End Using

                        lstLog.Items.Add("Η εγγραφή Διαγράφηκε με επιτυχία!-->" & GridView5.GetRowCellValue(selectedRowHandle, "invNumber").ToString)
                        lstLog.Items(lstLog.Items.Count - 1).ImageOptions.Image = ImageCollection1.Images.Item(0)
                        ItemsCorrect = ItemsCorrect + 1
                    Catch ex As Exception
                        lstLog.Items.Add(ex.Message.ToString.Replace(vbCrLf, ""))
                        lstLog.Items(lstLog.Items.Count - 1).ImageOptions.Image = ImageCollection1.Images.Item(1)
                        ItemsWrong = ItemsWrong + 1
                    End Try
                Else
                    ItemsWrong = ItemsWrong + 1
                    lstLog.Items.Add("Η εγγραφή είναι ολοκληρωμένη. Δεν μπορεί να γίνει διαγραφή!-->" & GridView5.GetRowCellValue(selectedRowHandle, "invNumber").ToString)
                    lstLog.Items(lstLog.Items.Count - 1).ImageOptions.Image = ImageCollection1.Images.Item(1)
                End If
                ProgressBarControl1.PerformStep()
                ProgressBarControl1.Update()
            Next I
            grdINVOICES.DataSource = Nothing
            Select Case SupMode
                Case 1
                    Me.KANELLOPOULOSTableAdapter.Fill(Me.DMDataSet.KANELLOPOULOS)
                    grdINVOICES.DataSource = Me.DMDataSet.KANELLOPOULOS
                    grdINVOICES.ForceInitialize() : grdINVOICES.DefaultView.PopulateColumns()
                    LoadForms.RestoreLayoutFromXml(GridView5, "KANELLOPOULOS.xml")
                Case 2
                Case 3
                Case 4
            End Select
            lstLog.Items.Add("Διαγράφηκαν: " & ItemsCorrect & " Λάθοι: " & ItemsWrong)
            lstLog.Items(lstLog.Items.Count - 1).ImageOptions.Image = ImageCollection1.Images.Item(2)
            LayoutControlItem4.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never

        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
            LayoutControlItem4.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        End Try
    End Sub

    Private Sub cmdDelete_Click(sender As Object, e As EventArgs) Handles cmdDelete.Click
        DeleteBatchRecords()
    End Sub
    Private Sub UpdateColBuy(Optional ByVal Completed As String = "")
        Dim sSQL As New StringBuilder
        Dim CompletedCell As String = Completed
        Try

            '   If GridView5.GetRowCellValue(GridView5.FocusedRowHandle, "completed").ToString = "True" Then Exit Sub
            sSQL.Clear()
            Select Case SupMode
                Case 1 : sSQL.AppendLine("UPDATE KANELLOPOULOS SET ")
            End Select

            If CompletedCell = "" Then CompletedCell = GridView5.GetRowCellValue(GridView5.FocusedRowHandle, "completed").ToString
            sSQL.AppendLine("Completed= " & toSQLValueS(CompletedCell) & ",")
            sSQL.AppendLine("cctID = " & toSQLValueS(repCCTID) & ",")
            sSQL.AppendLine("transhID = " & toSQLValueS(reptranshID) & ",")
            sSQL.AppendLine("FullTranshDescription = " & toSQLValueS(GridView5.GetRowCellValue(GridView5.FocusedRowHandle, "FullTranshDescription").ToString) & ",")
            sSQL.AppendLine("cmt= " & toSQLValueS(GridView5.GetRowCellValue(GridView5.FocusedRowHandle, "cmt").ToString) & ",")
            sSQL.AppendLine("kitchen= " & toSQLValueS(GridView5.GetRowCellValue(GridView5.FocusedRowHandle, "kitchen").ToString, True) & ",")
            sSQL.AppendLine("closet= " & toSQLValueS(GridView5.GetRowCellValue(GridView5.FocusedRowHandle, "closet").ToString, True) & ",")
            sSQL.AppendLine("general= " & toSQLValueS(GridView5.GetRowCellValue(GridView5.FocusedRowHandle, "general").ToString, True) & ",")
            sSQL.AppendLine("materials= " & toSQLValueS(GridView5.GetRowCellValue(GridView5.FocusedRowHandle, "materials").ToString, True) & ",")
            sSQL.AppendLine("bathroomFurn= " & toSQLValueS(GridView5.GetRowCellValue(GridView5.FocusedRowHandle, "bathroomFurn").ToString, True))
            sSQL.AppendLine("WHERE ID = " & toSQLValueS(GridView5.GetRowCellValue(GridView5.FocusedRowHandle, "ID").ToString))
            Using oCmd As New SqlCommand(sSQL.ToString, CNDB)
                oCmd.ExecuteNonQuery()
            End Using
            repCCTID = "" : reptranshID = ""

            lstLog.Items.Add("Η εγγραφή Ενημερώθηκε Επιτυχώς!")
            lstLog.Items(lstLog.Items.Count - 1).ImageOptions.Image = ImageCollection1.Images.Item(2)
        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
            lstLog.Items.Add("Η εγγραφή δεν ενημερώθηκε: " & ex.Message)
            lstLog.Items(lstLog.Items.Count - 1).ImageOptions.Image = ImageCollection1.Images.Item(1)
        End Try

    End Sub

    Private Sub RepTransh_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles RepTransh.ButtonClick
        Select Case e.Button.Index
            Case 0
            Case 1 : reptranshID = "" : GridView5.ActiveEditor.EditValue = Nothing : GridView5.ValidateEditor()
            Case 2
                reptranshID = GridView5.GetRowCellValue(GridView5.FocusedRowHandle, "transhID").ToString.ToUpper
                If reptranshID <> "" Then
                    Dim frmTransactions As frmTransactions = New frmTransactions()
                    frmTransactions.CalledFromControl = True
                    frmTransactions.Text = "Χρεωπιστώσεις"
                    frmTransactions.ID = reptranshID
                    frmTransactions.MdiParent = frmMain
                    frmTransactions.Mode = FormMode.EditRecord
                    frmTransactions.FormScroller = Me
                    frmTransactions.Scroller = GridView5
                    frmTransactions.Show()
                End If
        End Select
    End Sub

    Private Sub RepCus_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles RepCus.ButtonClick
        Select Case e.Button.Index
            Case 0
            Case 1 : repCCTID = "" : GridView5.ActiveEditor.EditValue = Nothing : GridView5.ValidateEditor()
            Case 2
                repCCTID = GridView5.GetRowCellValue(GridView5.FocusedRowHandle, "cctID").ToString.ToUpper
                If repCCTID <> "" Then
                    Dim frmCustomers As frmCustomers = New frmCustomers()
                    frmCustomers.Text = "Πελάτες"
                    frmCustomers.ID = repCCTID
                    frmCustomers.CalledFromControl = True
                    frmCustomers.MdiParent = frmMain
                    frmCustomers.Mode = FormMode.EditRecord
                    frmCustomers.FormScroller = Me
                    frmCustomers.Scroller = GridView5
                    frmCustomers.Show()
                End If
        End Select
    End Sub

    Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click
        InsertRecordsToBuy()
    End Sub

    Private Sub GridView5_DoubleClick(sender As Object, e As EventArgs) Handles GridView5.DoubleClick
        Dim sBuyID As String
        If sender.FocusedColumn.FieldName <> "invNumber" Then Exit Sub
        sBuyID = GridView5.GetRowCellValue(GridView5.FocusedRowHandle, "buyID").ToString.ToUpper
        If sBuyID <> "" Then
            Dim frmBUY As frmBUY = New frmBUY()
            frmBUY.Text = "Αγορές"
            frmBUY.ID = GridView5.GetRowCellValue(GridView5.FocusedRowHandle, "buyID").ToString
            frmBUY.MdiParent = frmMain
            frmBUY.Mode = FormMode.EditRecord
            frmBUY.Scroller = GridView5
            frmBUY.FormScroller = Me
            frmBUY.Show()
        End If
    End Sub

    Private Sub RepKan_O_ButtonPressed(sender As Object, e As ButtonPressedEventArgs) Handles RepKan_O.ButtonPressed
        Select Case e.Button.Index
            Case 1
                Dim editor As DevExpress.XtraEditors.LookUpEdit = TryCast(sender, DevExpress.XtraEditors.LookUpEdit)
                If editor.Controls(0).Text Is Nothing Then Exit Sub
                Dim KanOName As String = editor.Controls(0).Text
                If KanOName = "" Then Exit Sub
                Dim sSQL As New System.Text.StringBuilder
                sSQL.AppendLine("DELETE FROM KANELLOPOULOS_O WHERE ID = " & toSQLValueS(editor.EditValue.ToString))
                Using oCmd As New SqlCommand(sSQL.ToString, CNDB)
                    oCmd.ExecuteNonQuery()
                End Using
                Dim ID As String = GridView5.GetRowCellValue(GridView5.FocusedRowHandle, "ID").ToString()
                If ID.Length > 0 Then editor.Properties.DataSource = Me.KANELLOPOULOS_OTableAdapter.GetData(System.Guid.Parse(ID))
        End Select

    End Sub

    Private Sub RepKan_O_ProcessNewValue(sender As Object, e As ProcessNewValueEventArgs) Handles RepKan_O.ProcessNewValue

    End Sub
End Class