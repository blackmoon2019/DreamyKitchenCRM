Imports System.Data.SqlClient
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Grid

Module Main
    Public CNDB As New SqlConnection()
    Public CNDB2 As New SqlConnection()
    Public Const Company As String = "Dreamy Kitchen CRM"

    Enum FormMode
        NewRecord = 1
        EditRecord = 2
        DeleteRecord = 3
        ViewRecord = 4
    End Enum

    Public Structure USER_PROPS
        Public ID As Guid
        Public EmpID As Guid
        Public Code As String
        Public RealName As String
        Public UN As String
        Public PWD As String
        Public DataTable As String
        Public CurrentView As String
        Public AllowInsert As Boolean
        Public AllowEdit As Boolean
        Public AllowDelete As Boolean
        Public AllowView As Boolean
        Public Email As String
        Public EmailServer As String
        Public EmailPassword As String
        Public EmailPort As Integer
        Public EmailSSL As Boolean
        Public UNSave As String
    End Structure
    Public UserProps As USER_PROPS
    Public Structure PROG_PROPS
        Public ServerViewsPath As String
        Public ServerPath As String
        Public Records As Integer
        Public TempFolderPath As String
        Public TempPicturesFolderPath As String
        Public ProgTitle As String
        Public VAT As Integer
        Public Decimals As Integer
        Public EmailOrders As String
        Public SupportEmail As String
        Public InstEllipseInfBody As String
        Public InstEllipseInfAppointmentBody As String
        Public InstEllipseInfSubject As String
        Public InstEllipseInfBodySup As String
        Public InstEllipseInfSubjectSup As String
        Public InstEmailAccount As String
        Public InstEmailAccountSup As String
        Public InstInfSubject As String
        Public InstInfAppointmentBody As String
        Public InstEllipseInfAppointmentSubject As String
        Public InstEllipseInfSubjectComplete As String
        Public InstEllipseInfBodyComplete As String
        Public KitchenTransp As Decimal
        Public ClosetTransp As Decimal
        Public DoorTransp As Decimal
        Public SCTransp As Decimal
        Public KCOMPANY_PROFIT As Integer
        Public CCOMPANY_PROFIT As Integer
        Public DCOMPANY_PROFIT As Integer
        Public SCCOMPANY_PROFIT As Integer
        Public KitchenMeasurement As Decimal
        Public ClosetMeasurement As Decimal
        Public DoorMeasurement As Decimal
        Public SCMeasurement As Decimal
        Public KitchenRemove As Decimal
        Public ClosetRemove As Decimal
        Public DoorRemove As Decimal
        Public SCRemove As Decimal
        Public CusDiscountKitchen As Integer
        Public CusDiscountCloset As Integer
        Public CusDiscountDoors As Integer
        Public CusDiscountSpecial As Integer
        Public V_HEIGHT As String
        Public K_HEIGHT As String
        Public Y_HEIGHT As String
        Public V_BOX_COLOR As String
        Public K_BOX_COLOR As String
        Public Y_BOX_COLOR As String
        Public V_PVC_COLOR As String
        Public K_PVC_COLOR As String
        Public Y_PVC_COLOR As String
        Public LEGS As String
        Public K_FINAL_HEIGHT As Double
        Public Y_FINAL_HEIGHT As Double
        Public BENCH As String
        Public DAYS_OF_DELIVERY As Integer
        Public KNOBS As String
        Public BAZA As Integer
        Public DRAWERS As Integer
        Public SHELVES As Integer
        Public DOOR_DESCRIPTION As String
        Public DOOR_CMT As String
        Public CUS_NOTES As String
        Public KITCHEN_DESCRIPTION As String
        Public CLOSET_DESCRIPTION As String
        Public CLOSET_BACK_THIKNESS As String
        Public CLOSET_BOX_COLOR As String
        Public CLOSET_BOX_THIKNESS As String
        Public CLOSET_DRAWERS As String
        Public CLOSET_LEGS As String
        Public CLOSET_PVC_COLOR As String
        Public CLOSET_SHELVES As String
    End Structure
    Public ProgProps As PROG_PROPS
    Public Function toSQLValue(t As DevExpress.XtraEditors.TextEdit, Optional ByVal isnum As Boolean = False) As String
        If t.Text.Length = 0 Then
            Return "NULL" 'this will pass through any SQL statement without notice  
        Else 'Lets suppose our textbox is checked to contain only numbers, so we count on it  
            Dim sValue As String = t.Text
            If Not isnum Then
                Return "'" + sValue + "'"
            Else
                sValue = sValue.Replace(" €", "")
                sValue = sValue.Replace("%", "")
                Dim Result As Double
                Double.TryParse(sValue, Result)
                sValue = sValue.Replace(",", ".")
                'Return sValue
                Return Result.ToString.Replace(",", ".")
            End If
        End If
    End Function
    Public Function toSQLValueS(t As String, Optional ByVal isnum As Boolean = False) As String
        Try
            If t <> Nothing Then
                If t.Length = 0 Then
                    Return "NULL" 'this will pass through any SQL statement without notice  
                Else 'Lets suppose our textbox is checked to contain only numbers, so we count on it  
                    If Not isnum Then
                        Return "'" + t + "'"
                    Else
                        t = t.Replace(",", ".")
                        t = t.Replace(" €", "")
                        t = t.Replace("€", "")
                        t = t.Replace("%", "")
                        Return t
                    End If
                End If
            Else
                Return "NULL" 'this will pass through any SQL statement without notice  
            End If
        Catch ex As Exception
            DevExpress.XtraEditors.XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), Company, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function
    Public Function DbnullToZero(t As DevExpress.XtraEditors.TextEdit) As Double
        If IsDBNull(t) = False Then
            If t.Text = "" Then Return 0 Else Return t.EditValue.ToString.Replace(".", ",")
        Else
            Return 0
        End If
    End Function

    Public Sub HideColumns(GridView1 As DevExpress.XtraGrid.Views.Grid.GridView, sExclude As String)
        Dim col As GridColumn
        For Each col In GridView1.Columns
            ' Look at FieldName, not Name (name of Column)  
            If col.FieldName.Contains(sExclude) Then col.Visible = False
        Next
    End Sub
    Public Sub GetFileFromServer(ByVal sFile As String)
        Try
            Dim ServerFile As String = ProgProps.ServerViewsPath & "DSGNS\DEF\" & System.IO.Path.GetFileName(sFile)
            My.Computer.FileSystem.CopyFile(ServerFile, sFile, True)
        Catch ex As Exception
            DevExpress.XtraEditors.XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), Company, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Public Sub GetNewestFileFromServer(ByVal sFile As String)
        Try
            Dim LastModifiedF1 As Date, LastModifiedF2 As Date
            Dim ServerFile As String = ProgProps.ServerViewsPath & "DSGNS\DEF\" & System.IO.Path.GetFileName(sFile)
            LastModifiedF1 = System.IO.File.GetLastWriteTime(sFile)
            LastModifiedF2 = System.IO.File.GetLastWriteTime(ServerFile)
            Dim result As Integer = DateTime.Compare(LastModifiedF1, LastModifiedF2)
            If result < 0 Then
                If XtraMessageBox.Show("Βρέθηκε νεώτερη προεπιλεγμένη όψη στον Server. Να μεταφερθεί?", ProgProps.ProgTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                    My.Computer.FileSystem.CopyFile(ServerFile, sFile, True)
                    LastModifiedF1 = System.IO.File.GetLastWriteTime(sFile)
                Else
                    Exit Sub
                End If
                Do

                Loop Until LastModifiedF1 = LastModifiedF2
            End If
        Catch ex As Exception
            DevExpress.XtraEditors.XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), Company, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
    Public Sub ShellExecute(ByVal File As String)
        Dim myProcess As New Process
        myProcess.StartInfo.FileName = File
        myProcess.StartInfo.UseShellExecute = True
        myProcess.StartInfo.RedirectStandardOutput = False
        myProcess.Start()
        myProcess.Dispose()
    End Sub

    Public Function GetFile(ByVal sRowID As String, ByVal sTable As String, Optional ByRef sFileName As String = "") As Byte()
        Dim sSQL As String
        Dim cmd As SqlCommand
        Dim sdr As SqlDataReader
        Dim bytes As Byte()

        sSQL = "Select filename, files From " & sTable & " WHERE ID = " & toSQLValueS(sRowID)
        cmd = New SqlCommand(sSQL, CNDB) : sdr = cmd.ExecuteReader()
        If sdr.Read() = True Then
            bytes = DirectCast(sdr("files"), Byte())
            sFileName = sdr.GetString(sdr.GetOrdinal("filename").ToString).ToString
            sdr.Close()
            Return bytes
        End If
        sdr.Close()

    End Function
    Public Sub FilesSelection(ByVal XtraOpenFileDialog1 As XtraOpenFileDialog, ByVal txtFileNames As TextEdit)

        'XtraOpenFileDialog1.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*"
        XtraOpenFileDialog1.FilterIndex = 1
        XtraOpenFileDialog1.InitialDirectory = "C:\"
        XtraOpenFileDialog1.Title = "Open File"
        XtraOpenFileDialog1.CheckFileExists = False
        XtraOpenFileDialog1.Multiselect = True
        Dim result As DialogResult = XtraOpenFileDialog1.ShowDialog()
        If result = DialogResult.OK Then
            txtFileNames.EditValue = ""
            For I = 0 To XtraOpenFileDialog1.FileNames.Count - 1
                txtFileNames.EditValue = txtFileNames.EditValue & IIf(txtFileNames.EditValue <> "", ";", "") & XtraOpenFileDialog1.SafeFileNames(I).Replace("'", "")
            Next I
        End If
    End Sub
    Public Sub OpenFile(ByVal GridView1 As GridView)
        Try
            Dim sFilename = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "filename")
            Dim fs As IO.FileStream = New IO.FileStream(ProgProps.TempFolderPath & sFilename, IO.FileMode.Create)
            Dim b() As Byte = GetFile(GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "ID").ToString, "vw_CCT_F")
            fs.Write(b, 0, b.Length)
            fs.Close()
            ShellExecute(ProgProps.TempFolderPath & sFilename)
        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), Company, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    'Public Function FindItemByValChkListBox(ByVal sValue As String, ByVal chkList As DevExpress.XtraEditors.CheckedListBoxControl) As DevExpress.XtraEditors.Controls.CheckedListBoxItem
    '    For Each item As DevExpress.XtraEditors.Controls.CheckedListBoxItem In chkList

    '    Next
    'End Function

End Module

'Private Sub SetUserSettings()
'    Dim cf As New XML_Serialization.User_Settings
'    cf.user = New XML_Serialization.User() With {.ID = sUserCode}
'    cf.user.Settings = New XML_Serialization.Settings With {.DataTable = sDataTable, .CurrentView = BarViews.EditValue}
'    Dim s As New Xml.Serialization.XmlSerializer(GetType(XML_Serialization.User_Settings))
'    Using fs As New System.IO.FileStream(Application.StartupPath & "\file.xml", System.IO.FileMode.OpenOrCreate)
'        s.Serialize(fs, cf)
'    End Using
'End Sub
'Private Sub GetUserSettings()
'    Dim reader As New System.Xml.Serialization.XmlSerializer(GetType(XML_Serialization.User_Settings))
'    Dim file As New System.IO.StreamReader(Application.StartupPath & "\file.xml")
'    Dim overview As XML_Serialization.User_Settings
'    overview = CType(reader.Deserialize(file), XML_Serialization.User_Settings)
'    Console.WriteLine(overview.user.Settings.DataTable)

'End Sub

'Dim Col As GridColumn
'Col = GridView1.Columns.ColumnByFieldName("id")
'        MsgBox(GridView1.GetRowCellValue(sender.FocusedRowHandle, "id").ToString)
