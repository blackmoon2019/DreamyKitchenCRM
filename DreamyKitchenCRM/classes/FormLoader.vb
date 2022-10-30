Imports System.Data.SqlClient
Imports DevExpress.XtraLayout
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraVerticalGrid.Rows
Imports DevExpress.Utils.Menu
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Menu
Imports DevExpress.Utils

Public Class FormLoader
    Private GRDview As GridView
    Private XMLName As String
    Private DbTblName As String
    Private DbQuery As String

    Public Function LoadForm(ByVal control As DevExpress.XtraLayout.LayoutControl, ByVal sSQL As String) As Boolean

        Dim cmd As SqlCommand = New SqlCommand(sSQL, CNDB)
        Dim sdr As SqlDataReader = cmd.ExecuteReader()
        Dim sTable As DataTable
        Dim TagValue As String()
        'Tag Value = 0 For Load
        'Tag Value = 1 For Insert
        'Tag Value = 2 For Update
        Dim TagV As String
        Try
            sTable = sdr.GetSchemaTable()
            If (sdr.Read() = True) Then

                For Each item As BaseLayoutItem In control.Items
                    If TypeOf item Is LayoutControlItem Then
                        Dim LItem As LayoutControlItem = CType(item, LayoutControlItem)
                        If LItem.ControlName <> Nothing Then
                            'Γίνεται διαχείριση όταν υπάρχει RadioGroup με optionButtons
                            If TypeOf LItem.Control Is DevExpress.XtraEditors.RadioGroup Then
                                Dim RDG As DevExpress.XtraEditors.RadioGroup
                                RDG = LItem.Control
                                For i As Integer = 0 To RDG.Properties.Items.Count - 1
                                    'Βάζω τις τιμές του TAG σε array
                                    If RDG.Properties.Items(i).Tag <> Nothing Then
                                        TagValue = RDG.Properties.Items(i).Tag.Split(",")
                                        'Ψάχνω αν το πεδίο έχει δικάιωμα μεταβολής
                                        Dim value As String = Array.Find(TagValue, Function(x) (x.StartsWith("2")))
                                        If value <> Nothing Then
                                            TagV = TagValue(0).Replace("[", "").Replace("]", "")
                                            Console.WriteLine(TagV)
                                            sdr.GetDataTypeName(sdr.GetOrdinal(TagV))
                                            Dim index = sdr.GetOrdinal(TagV)
                                            Console.WriteLine(sdr.GetDataTypeName(index))
                                            If sdr.IsDBNull(sdr.GetOrdinal(TagV)) = False Then
                                                If sdr.GetBoolean(sdr.GetOrdinal(TagV)) = True Then RDG.SelectedIndex = i
                                            End If
                                        End If
                                    End If
                                Next i
                            End If
                            ' Εαν δεν έχω ορίσει tag στο Control δεν θα συμπεριληφθεί στο INSERT-UPDATE
                            If LItem.Control.Tag <> "" Then
                                'Βάζω τις τιμές του TAG σε array
                                TagValue = LItem.Control.Tag.ToString.Split(",")
                                'Ψάχνω αν το πεδίο έχει δικάιωμα Προβολής
                                Dim value As String = Array.Find(TagValue, Function(x) (x.StartsWith("0")))
                                ' Εαν δεν είναι visible το Control δεν θα συμπεριληφθεί στο INSERT-UPDATE
                                If LItem.Control.Visible = True Then
                                    If value <> Nothing Then
                                        TagV = TagValue(0).Replace("[", "").Replace("]", "")
                                        Console.WriteLine(TagV)
                                        sdr.GetDataTypeName(sdr.GetOrdinal(TagV))
                                        Dim index = sdr.GetOrdinal(TagV)
                                        Console.WriteLine(sdr.GetDataTypeName(index))
                                        Select Case sdr.GetDataTypeName(index)
                                            Case "nvarchar"
                                                If sdr.IsDBNull(sdr.GetOrdinal(TagV)) = False Then SetValueToControl(LItem, sdr.GetString(sdr.GetOrdinal(TagV)))
                                            Case "int"
                                                If sdr.IsDBNull(sdr.GetOrdinal(TagV)) = False Then SetValueToControl(LItem, sdr.GetInt32(sdr.GetOrdinal(TagV)))
                                            Case "uniqueidentifier"
                                                'If sdr.IsDBNull(sdr.GetOrdinal(TagV)) = False Then SetValueToControl(LItem, (sdr.GetOrdinal(TagV)).ToString)
                                                If sdr.IsDBNull(sdr.GetOrdinal(TagV)) = False Then SetValueToControl(LItem, sdr.GetGuid(sdr.GetOrdinal(TagV)).ToString)
                                            Case "bit"
                                                If sdr.IsDBNull(sdr.GetOrdinal(TagV)) = False Then SetValueToControl(LItem, sdr.GetBoolean(sdr.GetOrdinal(TagV)))
                                            Case "decimal"
                                                If sdr.IsDBNull(sdr.GetOrdinal(TagV)) = False Then SetValueToControl(LItem, sdr.GetDecimal(sdr.GetOrdinal(TagV)))
                                            Case "datetime"
                                                If sdr.IsDBNull(sdr.GetOrdinal(TagV)) = False Then SetValueToControl(LItem, sdr.GetDateTime(sdr.GetOrdinal(TagV)))
                                            Case "date"
                                                If sdr.IsDBNull(sdr.GetOrdinal(TagV)) = False Then SetValueToControl(LItem, sdr.GetDateTime(sdr.GetOrdinal(TagV)))
                                            Case "varbinary"
                                                If sdr.IsDBNull(sdr.GetOrdinal(TagV)) = False Then
                                                    Dim pic As DevExpress.XtraEditors.PictureEdit
                                                    Dim bytes As Byte()
                                                    pic = LItem.Control
                                                    bytes = DirectCast(sdr(TagV), Byte())
                                                    pic.EditValue = bytes
                                                End If
                                        End Select
                                    End If
                                End If
                            End If
                        End If
                    End If
                Next
            End If
            sdr.Close()
        Catch ex As Exception
            Dim trace = New System.Diagnostics.StackTrace(ex, True)
            Dim line As String = Strings.Right(trace.ToString, 5)

            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message & " Error in- Line number: " & line), "Dreamy Kitchen CRM", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function
    Public Function LoadFormGRP(ByVal GRP As DevExpress.XtraLayout.LayoutControlGroup, ByVal sSQL As String, Optional ByVal IgnoreVisibility As Boolean = True) As Boolean

        Dim cmd As SqlCommand = New SqlCommand(sSQL, CNDB)
        Dim sdr As SqlDataReader = cmd.ExecuteReader()
        Dim sTable As DataTable
        Dim TagValue As String()
        'Tag Value = 0 For Load
        'Tag Value = 1 For Insert
        'Tag Value = 2 For Update
        Dim TagV As String
        Try
            sTable = sdr.GetSchemaTable()
            If (sdr.Read() = True) Then
                For Each item As BaseLayoutItem In GRP.Items
                    If TypeOf item Is LayoutControlItem Then
                        Dim LItem As LayoutControlItem = CType(item, LayoutControlItem)
                        If LItem.ControlName <> Nothing Then
                            ' Εαν δεν έχω ορίσει tag στο Control δεν θα συμπεριληφθεί στο INSERT-UPDATE
                            If LItem.Control.Tag <> "" Then
                                'Βάζω τις τιμές του TAG σε array
                                TagValue = LItem.Control.Tag.ToString.Split(",")
                                'Ψάχνω αν το πεδίο έχει δικάιωμα Προβολής
                                Dim value As String = Array.Find(TagValue, Function(x) (x.StartsWith("0")))
                                ' Εαν δεν είναι visible το Control δεν θα συμπεριληφθεί στο INSERT-UPDATE
                                If IgnoreVisibility = True Then
                                    If LItem.Control.Visible = False Then GoTo NextItem
                                End If

                                'If LItem.Control.Visible = True Then
                                If value <> Nothing Then
                                        TagV = TagValue(0).Replace("[", "").Replace("]", "")
                                        Console.WriteLine(TagV)
                                        If sdr.GetSchemaTable().Select("ColumnName='" & TagV & "'").Length > 0 Then
                                            sdr.GetDataTypeName(sdr.GetOrdinal(TagV))
                                            Dim index = sdr.GetOrdinal(TagV)
                                            Console.WriteLine(sdr.GetDataTypeName(index))
                                            Select Case sdr.GetDataTypeName(index)
                                                Case "nvarchar"
                                                    If sdr.IsDBNull(sdr.GetOrdinal(TagV)) = False Then SetValueToControl(LItem, sdr.GetString(sdr.GetOrdinal(TagV)))
                                                Case "int"
                                                    If sdr.IsDBNull(sdr.GetOrdinal(TagV)) = False Then SetValueToControl(LItem, sdr.GetInt32(sdr.GetOrdinal(TagV)))
                                            Case "uniqueidentifier"
                                                If sdr.IsDBNull(sdr.GetOrdinal(TagV)) = False Then SetValueToControl(LItem, sdr.GetGuid(sdr.GetOrdinal(TagV)).ToString)
                                            Case "bit"
                                                    If sdr.IsDBNull(sdr.GetOrdinal(TagV)) = False Then SetValueToControl(LItem, sdr.GetBoolean(sdr.GetOrdinal(TagV)))
                                                Case "decimal"
                                                    If sdr.IsDBNull(sdr.GetOrdinal(TagV)) = False Then SetValueToControl(LItem, sdr.GetDecimal(sdr.GetOrdinal(TagV)))
                                                Case "datetime"
                                                    If sdr.IsDBNull(sdr.GetOrdinal(TagV)) = False Then SetValueToControl(LItem, sdr.GetDateTime(sdr.GetOrdinal(TagV)))
                                                Case "date"
                                                    If sdr.IsDBNull(sdr.GetOrdinal(TagV)) = False Then SetValueToControl(LItem, sdr.GetDateTime(sdr.GetOrdinal(TagV)))
                                                Case "varbinary"
                                                    If sdr.IsDBNull(sdr.GetOrdinal(TagV)) = False Then
                                                        Dim pic As DevExpress.XtraEditors.PictureEdit
                                                        Dim bytes As Byte()
                                                        pic = LItem.Control
                                                        bytes = DirectCast(sdr(TagV), Byte())
                                                        pic.EditValue = bytes
                                                    End If
                                            End Select
                                        End If
                                    End If
NextItem:
                                    'End If
                                End If
                        End If
                    End If
                Next
            End If
            sdr.Close()
        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), "Dreamy Kitchen CRM", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function
    Private Sub SetValueToControl(ByVal LItem As LayoutControlItem, ByVal sValue As String)
        Dim Ctrl As Control = LItem.Control
        Try

            If TypeOf Ctrl Is DevExpress.XtraEditors.LookUpEdit Then
                Dim cbo As DevExpress.XtraEditors.LookUpEdit
                Dim stestGuid As Guid
                Dim isValid As Boolean = Guid.TryParse(sValue, stestGuid)
                cbo = Ctrl
                If isValid = True Then
                    cbo.EditValue = System.Guid.Parse(sValue)
                Else
                    cbo.EditValue = Convert.ToInt32(sValue)
                End If
            ElseIf TypeOf Ctrl Is DevExpress.XtraEditors.ComboBoxEdit Then
                Dim cbo As DevExpress.XtraEditors.ComboBoxEdit
                cbo = Ctrl
                If sValue = "False" Or sValue = "True" Then
                    If sValue = "False" Then cbo.SelectedIndex = 0 Else cbo.SelectedIndex = 1
                ElseIf cbo.Properties.tag = "String" Then
                    cbo.EditValue = sValue
                ElseIf IsNumeric(sValue) Then
                    cbo.SelectedIndex = sValue
                Else
                    cbo.EditValue = sValue
                End If
            ElseIf TypeOf Ctrl Is DevExpress.XtraEditors.DateEdit Then
                Dim dt As DevExpress.XtraEditors.DateEdit
                dt = Ctrl
                dt.EditValue = CDate(sValue)
            ElseIf TypeOf Ctrl Is DevExpress.XtraEditors.TimeEdit Then
                Dim tm As DevExpress.XtraEditors.TimeEdit
                tm = Ctrl
                tm.EditValue = CDate(sValue).ToString("HH:mm")
            ElseIf TypeOf Ctrl Is DevExpress.XtraEditors.MemoEdit Then
                Dim txt As DevExpress.XtraEditors.MemoEdit
                txt = Ctrl
                If txt.Properties.Mask.EditMask = "c" & ProgProps.Decimals Then
                    txt.Text = Math.Round(CDec(sValue), ProgProps.Decimals)
                Else
                    txt.Text = sValue
                End If
            ElseIf TypeOf Ctrl Is DevExpress.XtraEditors.RatingControl Then
                Dim Rt As DevExpress.XtraEditors.RatingControl
                Rt = Ctrl
                Rt.EditValue = sValue
            ElseIf TypeOf Ctrl Is DevExpress.XtraEditors.TextEdit Then
                Dim txt As DevExpress.XtraEditors.TextEdit
                txt = Ctrl
                If txt.Properties.Mask.EditMask = "c" & ProgProps.Decimals Then
                    txt.Text = Math.Round(CDec(sValue), ProgProps.Decimals)
                ElseIf txt.Properties.Mask.EditMask = "d" Then ' Αφορά το DateEditControl
                    'sSQL.Append(toSQLValueS(CDate(txt.Text).ToString("yyyyMMdd")))
                    txt.Text = sValue
                Else
                    txt.Text = sValue
                End If
            ElseIf TypeOf Ctrl Is DevExpress.XtraEditors.CheckEdit Then
                Dim chk As DevExpress.XtraEditors.CheckEdit
                chk = Ctrl
                chk.EditValue = sValue
                chk.Checked = sValue
            ElseIf TypeOf Ctrl Is DevExpress.XtraEditors.DateEdit Then

            End If
        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), "Dreamy Kitchen CRM", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Public Sub LoadDataToGrid(ByRef GRDControl As DevExpress.XtraGrid.GridControl, ByRef GRDView As DevExpress.XtraGrid.Views.Grid.GridView,
                              ByVal sSQL As String, Optional ByVal AddColumnButton As Boolean = False, Optional ByVal AddColumnInteger As Boolean = False)
        Dim myCmd As SqlCommand
        Dim myReader As SqlDataReader
        Dim dt As New DataTable("sTable")
        Dim sTable As DataTable
        Try
            myCmd = CNDB.CreateCommand
            myCmd.CommandText = sSQL
            GRDView.Columns.Clear()
            myReader = myCmd.ExecuteReader()
            dt.Load(myReader)
            ' Κάνω όλες τις στήλες Editable
            For Each myField As DataColumn In dt.Columns
                myField.ReadOnly = False
            Next
            'dt.Columns.Item("selected").ReadOnly = False
            If AddColumnInteger = True Then
                dt.Columns.Add("QTY", GetType(Int32))
                'dt.Columns.Item("QTY").AllowDBNull = False
                dt.Columns.Item("QTY").DefaultValue = 0
                dt.Columns.Add("TOTALPRICE", GetType(Decimal))
                dt.Columns.Item("TOTALPRICE").DefaultValue = 0
            End If
            GRDControl.DataSource = dt
            GRDControl.ForceInitialize()
            GRDControl.DefaultView.PopulateColumns()
            'Προσθήκη Στήλης BUTTON(Θα πρέπει στον Designer να έχω προσθέσει ενα repositoryitem τύπου Button)
            If AddColumnButton Then
                Dim C2 As New GridColumn
                Dim Btn As New RepositoryItemButtonEdit()
                Btn = GRDControl.RepositoryItems.Item(0)
                'Btn.ContextImageOptions.Image = My.Resources.icons8_upload_link_document_16
                C2.ColumnEdit = Btn
                C2.VisibleIndex = 0
                GRDView.Columns.Add(C2)
            End If
            If dt.Rows.Count = 0 And GRDView.Columns.Count = 0 Then
                For Each myField As DataColumn In dt.Columns
                    Dim columnNameValue As String = myField.ColumnName
                    Dim C As New GridColumn
                    C.Name = columnNameValue
                    C.Caption = columnNameValue
                    C.Visible = True
                    C.OptionsColumn.ReadOnly = True
                    C.OptionsColumn.AllowEdit = False
                    GRDView.Columns.Add(C)
                Next
            End If

        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), "Dreamy Kitchen CRM", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Public Sub LoadDataToVGrid(ByRef GRDControl As DevExpress.XtraVerticalGrid.VGridControl,
                              ByVal sSQL As String, ByRef HasRows As Boolean)
        Dim myCmd As SqlCommand
        Dim myReader As SqlDataReader
        Dim dt As New DataTable("sTable")
        Try
            myCmd = CNDB.CreateCommand
            myCmd.CommandText = sSQL
            myReader = myCmd.ExecuteReader()
            If myReader.HasRows = False Then HasRows = False Else HasRows = True
            dt.Load(myReader)
            GRDControl.Rows.Clear()
            Dim columnName As String

            Dim Crow As New CategoryRow("ΓΙΑ ΠΡΟΣΦΟΡΑ")
            Crow.Name = "OFFER"
            GRDControl.Rows.Add(Crow)
            Dim Roffer As CategoryRow = GRDControl.Rows("OFFER")

            Dim Crow2 As New CategoryRow("ΒΑΣΕΩΣ")
            Crow2.Name = "VASEOS"
            Crow.ChildRows.Add(Crow2)
            Dim RVaseos As CategoryRow = GRDControl.Rows("VASEOS")

            Crow2 = New CategoryRow("ΚΡΕΜΑΣΤΑ")
            Crow2.Name = "KREMASTA"
            Crow.ChildRows.Add(Crow2)
            Dim RKremasta As CategoryRow = GRDControl.Rows("KREMASTA")

            Crow2 = New CategoryRow("ΥΨΗΛΑ")
            Crow2.Name = "YPSILA"
            Crow.ChildRows.Add(Crow2)
            Dim RYpsila As CategoryRow = GRDControl.Rows("YPSILA")

            Crow2 = New CategoryRow("ΠΑΓΚΟΙ")
            Crow2.Name = "BENCH"
            Crow.ChildRows.Add(Crow2)
            Dim RBench As CategoryRow = GRDControl.Rows("BENCH")

            Crow = New CategoryRow("ΓΙΑ ΠΑΡΑΓΓΕΛΙΑ")
            Crow.Name = "ORDER"
            GRDControl.Rows.Add(Crow)
            Dim ROrder As CategoryRow = GRDControl.Rows("ORDER")

            Crow2 = New CategoryRow("ΣΤΟΙΧΕΙΑ ΠΑΡΑΓΓΕΛΙΑΣ")
            Crow2.Name = "DETORDERS"
            Crow.ChildRows.Add(Crow2)
            Dim RDet As CategoryRow = GRDControl.Rows("DETORDERS")

            Crow2 = New CategoryRow("ΣΥΣΚΕΥΕΣ")
            Crow2.Name = "MECHS"
            Crow.ChildRows.Add(Crow2)
            Dim RMech As CategoryRow = GRDControl.Rows("MECHS")


            'Γεμίζω τις τιμές από την Βάση
            For Each myField As DataColumn In dt.Columns
                Dim columnNameValue As String = myField.ColumnName

                Dim C As New EditorRow(columnNameValue)
                C.Name = columnNameValue
                For Each row As DataRow In dt.Rows
                    If columnNameValue = "gola" Then
                        C.Properties.Value = row.Item(columnNameValue)
                    Else
                        columnName = row.Item(columnNameValue).ToString
                        C.Properties.Value = columnName
                    End If
                Next
                C.Visible = True
                'Τίτλοι Στηλών
                Select Case columnNameValue
                    Case "ID", "code", "offID", "modifiedBy", "modifiedOn", "createdOn", "createdBy", "RealName" : C.Visible = False
                    Case "benchID" : C.Properties.Caption = "Πάγκος"
                    Case "extraBench" : C.Properties.Caption = "Extra Πάγκος"
                    Case "boxVColorID", "boxKColorID", "boxYColorID" : C.Properties.Caption = "Χρώμα κασώμ/τος"
                    Case "pvcVColorID", "pvcKColorID", "pvcYColorID" : C.Properties.Caption = "Χρώμα PVC"
                    Case "finalHeightKitchen" : C.Properties.Caption = "Τελικό Ύψος"
                    Case "bazaColorID" : C.Properties.Caption = "Χρώμα μπάζας"
                    Case "backColorID" : C.Properties.Caption = "Χρώμα πλάτης"
                    Case "legsV", "legsY" : C.Properties.Caption = "Πόδια"
                    Case "rafia" : C.Properties.Caption = "Ραφιέρα-Ράφια"
                    Case "pomola" : C.Properties.Caption = "Πόμολα"
                    Case "doorThickness" : C.Properties.Caption = "Πάχος Κασώματος"
                    Case "backThickness" : C.Properties.Caption = "Πάχος Πλάτης"
                    Case "doorVaseos" : C.Properties.Caption = "Πορτάκι Βάσεως"
                    Case "doorVaseosH" : C.Properties.Caption = "Ύψος Ερμαρίων"
                    Case "doorKremasta" : C.Properties.Caption = "Πορτάκι κρεμαστών"
                    Case "doorKremastaH" : C.Properties.Caption = "Ύψος Ερμαρίων"
                    Case "doorYpsila" : C.Properties.Caption = "Πορτάκι Υψηλών"
                    Case "doorYpsilaH" : C.Properties.Caption = "Ύψος Ερμαρίων"
                    Case "bench" : C.Properties.Caption = "Πάγκος Εργασίας"
                    Case "gola" : C.Properties.Caption = "Gola"
                    Case "table_back" : C.Properties.Caption = "Τραπέζι/Πλάτη"
                    Case "sink" : C.Properties.Caption = "Νεροχύτης"
                    Case "sink_P" : C.Properties.Caption = "Τιμή"
                    Case "battery" : C.Properties.Caption = "Μπαταρία"
                    Case "battery_P" : C.Properties.Caption = "Τιμή"
                    Case "absorber" : C.Properties.Caption = "Αποροφητήρας"
                    Case "absorber_P" : C.Properties.Caption = "Τιμή"
                    Case "dishwasher" : C.Properties.Caption = "Πλυντήριο Πιάτων"
                    Case "dishwasher_P" : C.Properties.Caption = "Τιμή"
                    Case "oven" : C.Properties.Caption = "Φούρνος"
                    Case "oven_P" : C.Properties.Caption = "Τιμή"
                    Case "furnace" : C.Properties.Caption = "Εστία"
                    Case "furnace_P" : C.Properties.Caption = "Τιμή"
                    Case "fridge" : C.Properties.Caption = "Ψυγείο"
                    Case "fridge_P" : C.Properties.Caption = "Τιμή"
                    Case "Dispenser" : C.Properties.Caption = "Dispenser"
                    Case "Dispenser_P" : C.Properties.Caption = "Τιμή"
                End Select

                Select Case columnNameValue
                    Case "boxVColorID", "boxKColorID", "boxYColorID"
                        C.Properties.RowEdit = GRDControl.RepositoryItems.Item("boxColorID")
                        Dim GRDlookup As New RepositoryItemGridLookUpEdit
                        GRDlookup = GRDControl.RepositoryItems.Item("boxColorID")
                        GRDlookup.View.PopulateColumns(GRDlookup.DataSource)
                        GRDlookup.View.Columns("ID").Visible = False
                        GRDlookup.View.Columns("name").Caption = "Όνομα"
                        GRDlookup.View.Columns("photo").Caption = "Φωτο"
                    Case "pvcVColorID", "pvcKColorID", "pvcYColorID"
                        C.Properties.RowEdit = GRDControl.RepositoryItems.Item("pvcColorID")
                        Dim GRDlookup As New RepositoryItemGridLookUpEdit
                        GRDlookup = GRDControl.RepositoryItems.Item("pvcColorID")
                        GRDlookup.View.PopulateColumns(GRDlookup.DataSource)
                        GRDlookup.View.Columns("ID").Visible = False
                        GRDlookup.View.Columns("name").Caption = "Όνομα"
                        GRDlookup.View.Columns("photo").Caption = "Φωτο"
                    Case "bazaColorID", "backColorID"
                        C.Properties.RowEdit = GRDControl.RepositoryItems.Item(columnNameValue)
                        Dim GRDlookup As New RepositoryItemGridLookUpEdit
                        GRDlookup = GRDControl.RepositoryItems.Item(columnNameValue)
                        GRDlookup.View.PopulateColumns(GRDlookup.DataSource)
                        GRDlookup.View.Columns("ID").Visible = False
                        GRDlookup.View.Columns("name").Caption = "Όνομα"
                        GRDlookup.View.Columns("photo").Caption = "Φωτο"

                    Case "benchID"
                        C.Properties.RowEdit = GRDControl.RepositoryItems.Item(columnNameValue)
                        Dim GRDlookup As New RepositoryItemGridLookUpEdit
                        GRDlookup = GRDControl.RepositoryItems.Item(columnNameValue)
                        GRDlookup.View.PopulateColumns(GRDlookup.DataSource)
                        GRDlookup.View.Columns("ID").Visible = False
                        'GRDlookup.View.Columns("name").Caption = "Όνομα"
                        'GRDlookup.View.Columns("photo").Caption = "Φωτο"

                    Case "legsV", "legsY", "doorThickness", "backThickness"
                        C.Properties.RowEdit = GRDControl.RepositoryItems.Item("numericINT")
                    Case "doorVaseosH", "doorKremastaH", "doorYpsilaH", "finalHeightKitchen"
                        C.Properties.RowEdit = GRDControl.RepositoryItems.Item("numericDEC")
                    Case "sink_P", "battery_P", "absorber_P", "dishwasher_P", "oven_P", "furnace_P", "fridge_P", "Dispenser_P"
                        C.Properties.RowEdit = GRDControl.RepositoryItems.Item("numericCUR")
                    Case "gola"
                        C.Properties.RowEdit = GRDControl.RepositoryItems.Item("CheckEdit")
                    Case Else : C.Properties.RowEdit = GRDControl.RepositoryItems.Item("textEdit")
                End Select
                C.Properties.ReadOnly = False
                C.Properties.AllowEdit = True
                Select Case columnNameValue
                    Case "ID", "code", "offID", "modifiedBy", "modifiedOn", "createdOn", "createdBy", "RealName"
                    Case "boxVColorID", "pvcVColorID", "doorVaseosH", "legsV" : RVaseos.ChildRows.Add(C)
                    Case "boxKColorID", "pvcKColorID", "doorKremastaH" : RKremasta.ChildRows.Add(C)
                    Case "boxYColorID", "pvcYColorID", "doorYpsilaH", "legsY" : RYpsila.ChildRows.Add(C)
                    Case "benchID", "extraBench" : RBench.ChildRows.Add(C)
                    Case "gola", "finalHeightKitchen" : Roffer.ChildRows.Add(C)
                    Case "sink", "sink_P", "battery", "battery_P", "absorber", "absorber_P", "dishwasher", "dishwasher_P", "oven", "oven_P", "furnace", "furnace_P", "fridge", "fridge_P", "Dispenser", "Dispenser_P"
                        RMech.ChildRows.Add(C)
                    Case Else : RDet.ChildRows.Add(C)
                End Select


            Next
            GRDControl.Refresh()
            'End If

        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), "Dreamy Kitchen CRM", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Public Sub LoadColumnDescriptionNames(ByRef GRDControl As DevExpress.XtraGrid.GridControl, ByRef GRDView As DevExpress.XtraGrid.Views.Grid.GridView,
                                         Optional ByVal sTable As String = "", Optional ByVal sView As String = "")
        Dim myCmd As SqlCommand
        Dim myReader As SqlDataReader
        Dim sSQL As String
        Dim dt As New DataTable("sTable")
        Try
            If sView.Length > 0 Then
                sSQL = "Select  VIEW_COLUMN_NAME = c.name,VIEW_CATALOG,VIEW_SCHEMA,VIEW_NAME,TABLE_CATALOG,TABLE_SCHEMA,TABLE_NAME,ISNULL(c.name,COLUMN_NAME) AS COLUMN_NAME, ISNULL(ep.value,ISNULL(c.name,COLUMN_NAME)) As 'COLUMN_DESCRIPTION'
                        From sys.columns c
                        INNER Join sys.views vw on c.OBJECT_ID = vw.OBJECT_ID
                        INNER Join sys.schemas s ON s.schema_id = vw.schema_id
                        Left Join INFORMATION_SCHEMA.VIEW_COLUMN_USAGE vcu on vw.name = vcu.VIEW_NAME And s.name = vcu.VIEW_SCHEMA And c.name = vcu.COLUMN_NAME
                        Left Join(
                            SELECT distinct SCM_Name=SCM.Name, TBL_Name = TBL.name, COLName = COL.name, COL_Object_id = COL.object_id, COL_column_id = COL.column_id
                            FROM
                            SYS.COLUMNS COL
                            INNER Join SYS.TABLES TBL on COL.object_id = TBL.object_id
                            INNER Join SYS.SCHEMAS SCM ON TBL.schema_id = SCM.schema_id) tempTBL on tempTBL.TBL_Name=vcu.TABLE_NAME And tempTBL.SCM_Name=TABLE_SCHEMA And tempTBL.COLName = vcu.COLUMN_NAME
                        Left Join sys.extended_properties ep on tempTBL.COL_Object_id = ep.major_id And tempTBL.COL_column_id = ep.minor_id
                        where vw.NAME = '" & sView & "'"
            ElseIf sTable.Length > 0 Then
                sSQL = "Select   objname, [value] FROM fn_listextendedproperty(NULL, 'SCHEMA', 'dbo', 'TABLE', '" & sTable & "','COLUMN', NULL)"
            Else
                Exit Sub
            End If

            myCmd = CNDB.CreateCommand
            myCmd.CommandText = sSQL
            myReader = myCmd.ExecuteReader()
            dt.Load(myReader)
            For Each row As DataRow In dt.Rows
                Dim columnName As String = row.Item("COLUMN_NAME").ToString
                Dim columnNameValue As String = row.Item("COLUMN_DESCRIPTION").ToString

                If columnName.Length > 0 And columnNameValue.Length > 0 Then
                    Dim C As New GridColumn
                    C = GRDView.Columns.ColumnByName("col" & columnName)
                    If C IsNot Nothing Then
                        If C.Caption = "" Then C.Caption = columnNameValue
                        C = Nothing
                    End If
                End If
                'If columnName.Length > 0 And GRDView.Columns.Item(columnName) IsNot Nothing Then GRDView.Columns.Item(columnName).Caption = columnNameValue
            Next
        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), "Dreamy Kitchen CRM", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Public Sub RestoreLayoutFromXml(ByVal GridView As GridView, ByVal sXMLName As String)
        If My.Computer.FileSystem.FileExists(Application.StartupPath & "\DSGNS\DEF\" & sXMLName) Then GridView.RestoreLayoutFromXml(Application.StartupPath & "\DSGNS\DEF\" & sXMLName, OptionsLayoutBase.FullLayout)
    End Sub

    Public Sub PopupMenuShow(ByVal e As Views.Grid.PopupMenuShowingEventArgs, ByVal GridView As GridView, ByVal sXMLName As String, Optional ByVal sTableName As String = "",
                             Optional ByVal sQuery As String = "")
        If e.MenuType = GridMenuType.Column Then
            Dim menu As DevExpress.XtraGrid.Menu.GridViewColumnMenu = TryCast(e.Menu, GridViewColumnMenu)
            Dim item As New DXEditMenuItem()
            Dim itemColor As New DXEditMenuItem()
            GRDview = GridView : XMLName = sXMLName
            'menu.Items.Clear()
            If menu.Column IsNot Nothing Then
                'Για να προσθέσουμε menu item στο Default menu πρέπει πρώτα να προσθέσουμε ένα Repository Item 
                'Υπάρχουν πολλών ειδών Repositorys
                '1st Custom Menu Item
                Dim popRenameColumn As New RepositoryItemTextEdit
                popRenameColumn.Name = "RenameColumn"
                menu.Items.Add(New DXEditMenuItem("Μετονομασία Στήλης", popRenameColumn, AddressOf OnEditValueChanged, Nothing, Nothing, 100, 0))

                item = menu.Items.Item("Μετονομασία Στήλης")
                item.EditValue = menu.Column.GetTextCaption
                item.Tag = menu.Column.AbsoluteIndex

                '2nd Custom Menu Item
                menu.Items.Add(CreateCheckItem("Κλείδωμα Στήλης", menu.Column, Nothing))

                '3rd Custom Menu Item
                Dim popColorsColumn As New RepositoryItemColorEdit
                popColorsColumn.Name = "ColorsColumn"
                menu.Items.Add(New DXEditMenuItem("Χρώμα Στήλης", popColorsColumn, AddressOf OnColumnsColorChanged, Nothing, Nothing, 100, 0))
                itemColor = menu.Items.Item("Χρώμα Στήλης")
                itemColor.EditValue = menu.Column.AppearanceCell.BackColor
                itemColor.Tag = menu.Column.AbsoluteIndex
                '4nd Custom Menu Item
                menu.Items.Add(New DXMenuItem("Εκτύπωση όψης", AddressOf OnPrintView, Nothing, Nothing, Nothing, Nothing))
                '5nd Custom Menu Item
                menu.Items.Add(New DXMenuItem("Αποθήκευση όψης", AddressOf OnSaveView, Nothing, Nothing, Nothing, Nothing))
                '6nd Custom Menu Item
                menu.Items.Add(New DXMenuItem("Συγχρονισμός όψης από Server", AddressOf OnSyncView, Nothing, Nothing, Nothing, Nothing))

                If sTableName <> "" Then
                    DbTblName = sTableName
                    '7nd Custom Menu Item
                    menu.Items.Add(New DXMenuItem("Ενημέρωση πεδίων όψης από Βάση", AddressOf OnUpdateViewFromDB, Nothing, Nothing, Nothing, Nothing))
                ElseIf sQuery <> "" Then
                    DbQuery = sQuery
                    '7nd Custom Menu Item
                    menu.Items.Add(New DXMenuItem("Ενημέρωση πεδίων όψης από Βάση", AddressOf OnUpdateViewFromDB, Nothing, Nothing, Nothing, Nothing))
                End If
            End If
        End If

    End Sub
    Private Sub OnUpdateViewFromDB(ByVal sender As System.Object, ByVal e As EventArgs)
        'ReadXml.UpdateXMLFile(Application.StartupPath & "\DSGNS\DEF\" & sDataTable & "_def.xml")
        'My.Computer.FileSystem.DeleteFile(Application.StartupPath & "\DSGNS\DEF\" & sDataTable & "_def.xml")
        Try
            Dim col1 As GridColumn
            Dim Col2 As GridColumn
            Dim grdColumns As List(Of GridColumn)
            Dim sSQL As String
            Dim myCmd As SqlCommand
            Dim myReader As SqlDataReader
            If DbTblName <> "" Then
                sSQL = "SELECT top 1 * FROM " & DbTblName
            ElseIf DbQuery <> "" Then
                sSQL = DbQuery
            End If
            myCmd = CNDB.CreateCommand
            myCmd.CommandText = sSQL
            myReader = myCmd.ExecuteReader()


            If myReader Is Nothing Then Exit Sub
            'Εαν υπάρχουν πεδία που πρέπει να προστεθούν από την βάση
            If myReader.FieldCount >= GRDview.Columns.Count Then
                Dim schema As DataTable = myReader.GetSchemaTable()
                grdColumns = GRDview.Columns.ToList()
                For i As Integer = 0 To myReader.FieldCount - 1
                    Console.WriteLine(myReader.GetName(i))
                    If i < GRDview.Columns.Count Then
                        'Col2 = GridView1.Columns.Item(i)
                        Col2 = GRDview.Columns.ColumnByFieldName(myReader.GetName(i))
                    Else
                        Col2 = Nothing
                    End If
                    If Col2 Is Nothing Then
                        col1 = GRDview.Columns.AddField(myReader.GetName(i))
                        col1.FieldName = myReader.GetName(i)
                        col1.Visible = True
                        col1.VisibleIndex = 0
                        col1.AppearanceCell.BackColor = Color.Bisque
                    End If

                Next
                'Εαν έχουν σβηστεί πεδία από την βάση τα αφαιρεί και από το grid
            ElseIf myReader.FieldCount < GRDview.Columns.Count Then
                Dim schema As DataTable = myReader.GetSchemaTable()
                grdColumns = GRDview.Columns.ToList()

                For i As Integer = 0 To grdColumns.Count - 1
                    Try
                        Col2 = grdColumns(i)
                        Dim sOrd As String = myReader.GetOrdinal(Col2.FieldName)
                    Catch ex As Exception
                        Col2 = grdColumns(i)
                        GRDview.Columns.Remove(Col2)
                        Console.WriteLine(ex.Message)

                        Continue For
                    End Try

                Next

            End If
            If DbTblName <> "" Then LoadColumnDescriptionNames(GRDview, , DbTblName)
            myReader.Close()
        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
    Public Sub LoadColumnDescriptionNames(ByRef GRDView As DevExpress.XtraGrid.Views.Grid.GridView, Optional ByVal sTable As String = "", Optional ByVal sView As String = "")
        Dim myCmd As SqlCommand
        Dim myReader As SqlDataReader
        Dim sSQL As String
        Dim dt As New DataTable("sTable")
        Try
            If sView.Length > 0 Then
                sSQL = "Select  VIEW_COLUMN_NAME = c.name,VIEW_CATALOG,VIEW_SCHEMA,VIEW_NAME,TABLE_CATALOG,TABLE_SCHEMA,TABLE_NAME,ISNULL(c.name,COLUMN_NAME) AS COLUMN_NAME, ISNULL(ep.value,ISNULL(c.name,COLUMN_NAME)) As 'COLUMN_DESCRIPTION'
                        From sys.columns c
                        INNER Join sys.views vw on c.OBJECT_ID = vw.OBJECT_ID
                        INNER Join sys.schemas s ON s.schema_id = vw.schema_id
                        Left Join INFORMATION_SCHEMA.VIEW_COLUMN_USAGE vcu on vw.name = vcu.VIEW_NAME And s.name = vcu.VIEW_SCHEMA And c.name = vcu.COLUMN_NAME
                        Left Join(
                            SELECT distinct SCM_Name=SCM.Name, TBL_Name = TBL.name, COLName = COL.name, COL_Object_id = COL.object_id, COL_column_id = COL.column_id
                            FROM
                            SYS.COLUMNS COL
                            INNER Join SYS.TABLES TBL on COL.object_id = TBL.object_id
                            INNER Join SYS.SCHEMAS SCM ON TBL.schema_id = SCM.schema_id) tempTBL on tempTBL.TBL_Name=vcu.TABLE_NAME And tempTBL.SCM_Name=TABLE_SCHEMA And tempTBL.COLName = vcu.COLUMN_NAME
                        Left Join sys.extended_properties ep on tempTBL.COL_Object_id = ep.major_id And tempTBL.COL_column_id = ep.minor_id
                        where vw.NAME = '" & sView & "'"
            ElseIf sTable.Length > 0 Then
                sSQL = "Select   objname, [value] FROM fn_listextendedproperty(NULL, 'SCHEMA', 'dbo', 'TABLE', '" & sTable & "','COLUMN', NULL)"
            Else
                Exit Sub
            End If

            myCmd = CNDB.CreateCommand
            myCmd.CommandText = sSQL
            myReader = myCmd.ExecuteReader()
            dt.Load(myReader)
            For Each row As DataRow In dt.Rows
                Dim columnName As String = row.Item("COLUMN_NAME").ToString
                Dim columnNameValue As String = row.Item("COLUMN_DESCRIPTION").ToString

                If columnName.Length > 0 And columnNameValue.Length > 0 Then
                    Dim C As New GridColumn
                    C = GRDView.Columns.ColumnByName("col" & columnName)
                    If C IsNot Nothing Then
                        If C.Caption = "" Then C.Caption = columnNameValue
                        C = Nothing
                    End If
                End If
                'If columnName.Length > 0 And GRDView.Columns.Item(columnName) IsNot Nothing Then GRDView.Columns.Item(columnName).Caption = columnNameValue
            Next
        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    'Αποθήκευση όψης 
    Private Sub OnSaveView(ByVal sender As System.Object, ByVal e As EventArgs)
        Dim grdVer As Decimal
        Dim item As DXMenuItem = TryCast(sender, DXMenuItem)
        grdVer = IIf(GRDview.OptionsLayout.LayoutVersion = "", 0.5, GRDview.OptionsLayout.LayoutVersion)
        grdVer = grdVer + 0.5 : GRDview.OptionsLayout.LayoutVersion = grdVer
        GRDview.SaveLayoutToXml(Application.StartupPath & "\DSGNS\DEF\" & XMLName, OptionsLayoutBase.FullLayout)
        XtraMessageBox.Show("Η όψη αποθηκεύτηκε με επιτυχία", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Information)

        If UserProps.ID.ToString.ToUpper = "3F9DC32E-BE5B-4D46-A13C-EA606566CF32" Or UserProps.ID.ToString.ToUpper = "E9CEFD11-47C0-4796-A46B-BC41C4C3606B" Then
            If XtraMessageBox.Show("Θέλετε να γίνει κοινοποίηση της όψης? Εαν επιλέξετε 'Yes' όλοι οι χρήστες θα έχουν την ίδια όψη", ProgProps.ProgTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                If My.Computer.FileSystem.FileExists(UserProps.ServerViewsPath & "DSGNS\DEF\" & XMLName) = False Then GRDview.OptionsLayout.LayoutVersion = "v1"
                GRDview.SaveLayoutToXml(UserProps.ServerViewsPath & "DSGNS\DEF\" & XMLName, OptionsLayoutBase.FullLayout)
            End If
        End If
    End Sub

    'Μετονομασία Στήλης Master
    Private Sub OnEditValueChanged(ByVal sender As System.Object, ByVal e As EventArgs)
        Dim item As New DXEditMenuItem()
        item = sender
        If item.Tag Is Nothing Then Exit Sub
        If item.Tag = -1 Then Exit Sub
        GRDview.Columns(item.Tag).Caption = item.EditValue
        'MessageBox.Show(item.EditValue.ToString())
    End Sub
    Private Function CreateCheckItem(ByVal caption As String, ByVal column As GridColumn, ByVal image As Image) As DXMenuCheckItem
        Dim item As New DXMenuCheckItem(caption, (Not column.OptionsColumn.AllowMove), image, New EventHandler(AddressOf OnCanMoveItemClick))
        item.Tag = New MenuColumnInfo(column)
        Return item
    End Function
    'Αλλαγή Χρώματος Στήλης Master
    Private Sub OnColumnsColorChanged(ByVal sender As System.Object, ByVal e As EventArgs)
        Dim item As DXEditMenuItem = TryCast(sender, DXEditMenuItem)
        item = sender
        If item.Tag Is Nothing Or item.Tag = -1 Then Exit Sub
        GRDview.Columns(item.Tag).AppearanceCell.BackColor = item.EditValue
    End Sub
    'Κλείδωμα Στήλης Master
    Private Sub OnCanMoveItemClick(ByVal sender As Object, ByVal e As EventArgs)
        Dim item As DXMenuCheckItem = TryCast(sender, DXMenuCheckItem)
        Dim info As MenuColumnInfo = TryCast(item.Tag, MenuColumnInfo)
        If info Is Nothing Then
            Return
        End If
        info.Column.OptionsColumn.AllowMove = Not item.Checked
    End Sub
    'Εκτύπωση Όψης
    Private Sub OnPrintView(ByVal sender As System.Object, ByVal e As EventArgs)
        Dim item As DXMenuItem = TryCast(sender, DXMenuItem)
        GRDview.GridControl.ShowRibbonPrintPreview()
    End Sub
    'Συγχρονισμός όψης από Server
    Private Sub OnSyncView(ByVal sender As System.Object, ByVal e As EventArgs)
        If XtraMessageBox.Show("Θέλετε να γίνει μεταφορά της όψης από τον server?", ProgProps.ProgTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            ' Έλεγχος αν υπάρχει όψη με μεταγενέστερη ημερομηνία στον Server
            If System.IO.File.Exists(UserProps.ServerViewsPath & "DSGNS\DEF\" & XMLName) = True Then
                My.Computer.FileSystem.CopyFile(UserProps.ServerViewsPath & "DSGNS\DEF\" & XMLName, Application.StartupPath & "\DSGNS\DEF\" & XMLName, True)
                GRDview.RestoreLayoutFromXml(Application.StartupPath & "\DSGNS\DEF\" & XMLName, OptionsLayoutBase.FullLayout)
            End If
            'If System.IO.File.Exists(UserProps.ServerViewsPath & "DSGNS\DEF\APMIL_D_def.xml") = True Then
            '    My.Computer.FileSystem.CopyFile(UserProps.ServerViewsPath & "DSGNS\DEF\APMIL_D_def.xml", Application.StartupPath & "\DSGNS\DEF\APMIL_D_def.xml", True)
            '    '        GridView7.RestoreLayoutFromXml(Application.StartupPath & "\DSGNS\DEF\APMIL_D_def.xml", OptionsLayoutBase.FullLayout)
            'End If

        End If
    End Sub
    Friend Class MenuColumnInfo
        Public Sub New(ByVal column As GridColumn)
            Me.Column = column
        End Sub
        Public Column As GridColumn
    End Class

End Class

