Imports System.Data.SqlClient
Imports DevExpress.XtraEditors
Public Class FillCombos
    Public Sub AREAS(CtrlCombo As DevExpress.XtraEditors.LookUpEdit, ByVal sSQL As System.Text.StringBuilder)
        Try

            Dim cmd As SqlCommand = New SqlCommand("Select id,Name from vw_AREAS  " & sSQL.ToString & " order by name", CNDB)
            Dim sdr As SqlDataReader = cmd.ExecuteReader()
            CtrlCombo.Properties.DataSource = ""
            CtrlCombo.Properties.Columns.Clear()
            CtrlCombo.Properties.DataSource = sdr
            CtrlCombo.Properties.DisplayMember = "Name"
            CtrlCombo.Properties.ValueMember = "id"
            CtrlCombo.Properties.PopulateColumns()
            CtrlCombo.Properties.Columns(0).Visible = False
            CtrlCombo.Properties.Columns(1).Caption = "Περιοχές"
            sdr.Close()
        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), "Dreamy Kitchen CRM", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
    Public Sub TECH_CAT(CtrlCombo As DevExpress.XtraEditors.LookUpEdit)
        Try

            Dim cmd As SqlCommand = New SqlCommand("Select id,Name from vw_TECH_CAT order by name", CNDB)
            Dim sdr As SqlDataReader = cmd.ExecuteReader()
            CtrlCombo.Properties.DataSource = ""
            CtrlCombo.Properties.Columns.Clear()
            CtrlCombo.Properties.DataSource = sdr
            CtrlCombo.Properties.DisplayMember = "Name"
            CtrlCombo.Properties.ValueMember = "id"
            CtrlCombo.Properties.PopulateColumns()
            CtrlCombo.Properties.Columns(0).Visible = False
            CtrlCombo.Properties.Columns(1).Caption = "Κατηγορίες Τεχνικής Υποστήριξης"
            sdr.Close()
        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), "Dreamy Kitchen CRM", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
    Public Sub COLORS_CAT(CtrlCombo As DevExpress.XtraEditors.LookUpEdit)
        Try

            Dim cmd As SqlCommand = New SqlCommand("Select id,Name from vw_COLORS_CAT order by name", CNDB)
            Dim sdr As SqlDataReader = cmd.ExecuteReader()
            CtrlCombo.Properties.DataSource = ""
            CtrlCombo.Properties.Columns.Clear()
            CtrlCombo.Properties.DataSource = sdr
            CtrlCombo.Properties.DisplayMember = "Name"
            CtrlCombo.Properties.ValueMember = "id"
            CtrlCombo.Properties.PopulateColumns()
            CtrlCombo.Properties.Columns(0).Visible = False
            CtrlCombo.Properties.Columns(1).Caption = "Κατηγορίες Χρωμάτων"
            sdr.Close()
        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), "Dreamy Kitchen CRM", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Public Sub COLORS(CtrlCombo As DevExpress.XtraEditors.LookUpEdit, ByVal sSQL As System.Text.StringBuilder)
        Try

            Dim cmd As SqlCommand = New SqlCommand("Select id,Name,photo from vw_COLORS  " & sSQL.ToString & " order by name", CNDB)
            Dim sdr As SqlDataReader = cmd.ExecuteReader()
            CtrlCombo.Properties.DataSource = ""
            CtrlCombo.Properties.Columns.Clear()
            CtrlCombo.Properties.DataSource = sdr
            CtrlCombo.Properties.DisplayMember = "Name"
            CtrlCombo.Properties.ValueMember = "id"
            CtrlCombo.Properties.PopulateColumns()
            CtrlCombo.Properties.Columns(0).Visible = False
            CtrlCombo.Properties.Columns(1).Caption = "Χρώματα"
            sdr.Close()
        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), "Dreamy Kitchen CRM", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
    Public Sub SUBOFF(ByRef CtrlCombo As DevExpress.XtraEditors.LookUpEdit, ByVal sSQL As String)
        Try

            Dim cmd As SqlCommand = New SqlCommand("Select id,SubOFFName from vw_OFF_SUBOFF " & sSQL & " order by SubOFFName", CNDB)
            Dim sdr As SqlDataReader = cmd.ExecuteReader()
            CtrlCombo.Properties.DataSource = ""
            CtrlCombo.Properties.Columns.Clear()
            Dim col As New Controls.LookUpColumnInfo
            col.Visible = False : col.FieldName = "id"
            CtrlCombo.Properties.Columns.Add(col)
            col = Nothing
            col = New Controls.LookUpColumnInfo
            col.Visible = True : col.FieldName = "SubOFFName" : col.Caption = "Τίτλοι Προσφοράς"
            CtrlCombo.Properties.Columns.Add(col)
            col = Nothing
            CtrlCombo.Properties.DataSource = sdr
            CtrlCombo.Properties.DisplayMember = "SubOFFName"
            CtrlCombo.Properties.ValueMember = "id"
            'CtrlCombo.Properties.PopulateColumns()
            'CtrlCombo.Properties.Columns(0).Visible = False
            'CtrlCombo.Properties.Columns(1).Caption = "Τίτλοι Προσφοράς"

            'sdr.Close()
        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), "Dreamy Kitchen CRM", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
    Public Sub ADR(CtrlCombo As DevExpress.XtraEditors.LookUpEdit, ByVal sSQL As System.Text.StringBuilder)
        Try
            If sSQL.Length = 0 Then sSQL.AppendLine("Select id,Name from vw_ADR ")
            Dim cmd As SqlCommand = New SqlCommand(sSQL.ToString, CNDB)
            Dim sdr As SqlDataReader = cmd.ExecuteReader()
            CtrlCombo.Properties.DataSource = ""
            CtrlCombo.Properties.Columns.Clear()
            CtrlCombo.Properties.DataSource = sdr
            CtrlCombo.Properties.DisplayMember = "Name"
            CtrlCombo.Properties.ValueMember = "id"
            CtrlCombo.Properties.PopulateColumns()
            CtrlCombo.Properties.Columns(0).Visible = False
            CtrlCombo.Properties.Columns(1).Caption = "Διευθύνσεις"
            sdr.Close()
        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), "Dreamy Kitchen CRM", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Public Sub USR(CtrlCombo As DevExpress.XtraEditors.LookUpEdit)
        Try
            Dim cmd As SqlCommand = New SqlCommand("Select id,un,Realname from vw_USR order by un", CNDB)
            Dim sdr As SqlDataReader = cmd.ExecuteReader()

            CtrlCombo.Properties.DataSource = sdr
            CtrlCombo.Properties.DisplayMember = "un"
            CtrlCombo.Properties.ValueMember = "id"
            CtrlCombo.Properties.PopulateColumns()
            CtrlCombo.Properties.Columns(0).Visible = False
            CtrlCombo.Properties.Columns(1).Visible = False
            CtrlCombo.Properties.Columns(1).Caption = "Χρήστης"
            sdr.Close()
        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), "Dreamy Kitchen CRM", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Public Sub COU(CtrlCombo As DevExpress.XtraEditors.LookUpEdit)
        Try
            Dim cmd As SqlCommand = New SqlCommand("Select id,Name from vw_COU order by name", CNDB)
            Dim sdr As SqlDataReader = cmd.ExecuteReader()

            CtrlCombo.Properties.DataSource = sdr
            CtrlCombo.Properties.DisplayMember = "Name"
            CtrlCombo.Properties.ValueMember = "id"
            CtrlCombo.Properties.PopulateColumns()
            CtrlCombo.Properties.Columns(0).Visible = False
            CtrlCombo.Properties.Columns(1).Caption = "Νομοί"
            sdr.Close()
        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), "Dreamy Kitchen CRM", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
    Public Sub NOTES_L(CtrlCombo As DevExpress.XtraEditors.LookUpEdit)
        Try
            Dim cmd As SqlCommand = New SqlCommand("Select id,Name from vw_NOTES_L order by name", CNDB)
            Dim sdr As SqlDataReader = cmd.ExecuteReader()

            CtrlCombo.Properties.DataSource = sdr
            CtrlCombo.Properties.DisplayMember = "Name"
            CtrlCombo.Properties.ValueMember = "id"
            CtrlCombo.Properties.PopulateColumns()
            CtrlCombo.Properties.Columns(0).Visible = False
            CtrlCombo.Properties.Columns(1).Caption = "Εττικέτες"
            sdr.Close()
        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), "Dreamy Kitchen CRM", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
    Public Sub CUS(CtrlCombo As DevExpress.XtraEditors.LookUpEdit)
        Try
            Dim cmd As SqlCommand = New SqlCommand("Select id,Fullname,isnull(SalerID,'00000000-0000-0000-0000-000000000000') as SalerID from vw_CCT order by Fullname", CNDB)
            Dim sdr As SqlDataReader = cmd.ExecuteReader()
            CtrlCombo.Properties.DataSource = sdr
            CtrlCombo.Properties.DisplayMember = "Fullname"
            CtrlCombo.Properties.ValueMember = "id"
            CtrlCombo.Properties.PopulateColumns()
            CtrlCombo.Properties.Columns(0).Visible = False
            CtrlCombo.Properties.Columns(1).Caption = "Πελάτες"
            CtrlCombo.Properties.Columns(2).Visible = False
            sdr.Close()
        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), "Dreamy Kitchen CRM", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
    Public Sub CALC(CtrlCombo As DevExpress.XtraEditors.LookUpEdit)
        Try
            Dim cmd As SqlCommand = New SqlCommand("Select id,name,calculations from vw_CALC order by name", CNDB)
            Dim sdr As SqlDataReader = cmd.ExecuteReader()
            CtrlCombo.Properties.DataSource = sdr
            CtrlCombo.Properties.DisplayMember = "name"
            CtrlCombo.Properties.ValueMember = "id"
            CtrlCombo.Properties.PopulateColumns()
            CtrlCombo.Properties.Columns(0).Visible = False
            CtrlCombo.Properties.Columns(1).Caption = "Περιγραφή"
            CtrlCombo.Properties.Columns(1).Width = 200
            CtrlCombo.Properties.Columns(2).Caption = "Υπολογισμός"
            CtrlCombo.Properties.Columns(2).Width = 200
            Dim s As Size
            s.Width = 400 : s.Height = 400
            CtrlCombo.Properties.PopupFormMinSize = s
            sdr.Close()
        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), "Dreamy Kitchen CRM", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Public Sub DOOR_TYPE(CtrlCombo As DevExpress.XtraEditors.LookUpEdit)
        Try
            Dim cmd As SqlCommand = New SqlCommand("Select id,name,price from vw_DOOR_TYPE order by code", CNDB)
            Dim sdr As SqlDataReader = cmd.ExecuteReader()
            CtrlCombo.Properties.DataSource = sdr
            CtrlCombo.Properties.DisplayMember = "name"
            CtrlCombo.Properties.ValueMember = "id"
            CtrlCombo.Properties.PopulateColumns()
            CtrlCombo.Properties.Columns(0).Visible = False
            CtrlCombo.Properties.Columns(1).Caption = "Κατηγορία Πόρτας"
            CtrlCombo.Properties.Columns(2).Caption = "Τιμή"
            CtrlCombo.Properties.Columns(2).FormatType = DevExpress.Utils.FormatType.Numeric
            CtrlCombo.Properties.Columns(2).FormatString = "c2"
            CtrlCombo.Properties.Columns(2).Width = 150
            Dim s As Size
            s.Width = 400 : s.Height = 300
            CtrlCombo.Properties.PopupFormMinSize = s
            sdr.Close()
        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), "Dreamy Kitchen CRM", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
    Public Sub ERM(CtrlCombo As DevExpress.XtraEditors.LookUpEdit)
        Try
            Dim cmd As SqlCommand = New SqlCommand("Select id,catErmName,catSubErmName from vw_ERM order by catErmName,catSubErmName ", CNDB)
            Dim sdr As SqlDataReader = cmd.ExecuteReader()
            CtrlCombo.Properties.DataSource = sdr
            CtrlCombo.Properties.DisplayMember = "catErmName"
            CtrlCombo.Properties.ValueMember = "id"
            CtrlCombo.Properties.PopulateColumns()
            CtrlCombo.Properties.Columns(0).Visible = False
            CtrlCombo.Properties.Columns(1).Caption = "Κατηγορία"
            CtrlCombo.Properties.Columns(1).Width = 150
            CtrlCombo.Properties.Columns(2).Visible = True
            CtrlCombo.Properties.Columns(2).Caption = "Υποκατηγορία"
            CtrlCombo.Properties.Columns(2).Width = 150
            sdr.Close()
        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), "Dreamy Kitchen CRM", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
    Public Sub SIDES(Optional CtrlCombo As DevExpress.XtraEditors.LookUpEdit = Nothing, Optional CtrlCheckedCombo As DevExpress.XtraEditors.CheckedComboBoxEdit = Nothing)
        Try
            Dim cmd As SqlCommand = New SqlCommand("Select id,name from vw_SIDES order by name", CNDB)
            Dim sdr As SqlDataReader = cmd.ExecuteReader()
            If CtrlCombo IsNot Nothing Then
                CtrlCombo.Properties.DataSource = sdr
                CtrlCombo.Properties.DisplayMember = "name"
                CtrlCombo.Properties.ValueMember = "id"
                CtrlCombo.Properties.PopulateColumns()
                CtrlCombo.Properties.Columns(0).Visible = False
                CtrlCombo.Properties.Columns(1).Caption = "Επενδύσης - Καταφραγές"
            ElseIf CtrlCheckedCombo IsNot Nothing Then
                CtrlCheckedCombo.Properties.DataSource = sdr
                CtrlCheckedCombo.Properties.DisplayMember = "name"
                CtrlCheckedCombo.Properties.ValueMember = "id"
            End If
            'CtrlCombo.Properties.Columns(2).Visible = False
            sdr.Close()
        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), "Dreamy Kitchen CRM", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
    Public Sub CAT_SUB_ERM(CtrlCombo As DevExpress.XtraEditors.LookUpEdit, Optional ByVal sSQL As System.Text.StringBuilder = Nothing)
        Try
            If sSQL Is Nothing Then
                sSQL = New System.Text.StringBuilder
                sSQL.AppendLine("Select id,name from vw_CAT_SUB_ERM order by name")
            End If
            Dim cmd As SqlCommand = New SqlCommand(sSQL.ToString, CNDB)
            Dim sdr As SqlDataReader = cmd.ExecuteReader()
            CtrlCombo.Properties.DataSource = sdr
            CtrlCombo.Properties.DisplayMember = "name"
            CtrlCombo.Properties.ValueMember = "id"
            CtrlCombo.Properties.PopulateColumns()
            CtrlCombo.Properties.Columns(0).Visible = False
            CtrlCombo.Properties.Columns(1).Caption = "Υποκατηγορίες Ερμαρίων"
            'CtrlCombo.Properties.Columns(2).Visible = False
            sdr.Close()
        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), "Dreamy Kitchen CRM", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Public Sub BENCH(CtrlCombo As DevExpress.XtraEditors.LookUpEdit)
        Try
            Dim cmd As SqlCommand = New SqlCommand("Select id,name,pricePerMeter from vw_BENCH order by name", CNDB)
            Dim sdr As SqlDataReader = cmd.ExecuteReader()
            CtrlCombo.Properties.DataSource = sdr
            CtrlCombo.Properties.DisplayMember = "name"
            CtrlCombo.Properties.ValueMember = "id"
            CtrlCombo.Properties.PopulateColumns()
            CtrlCombo.Properties.Columns(0).Visible = False
            CtrlCombo.Properties.Columns(1).Caption = "Πάγκοι"
            CtrlCombo.Properties.Columns(2).Visible = False
            sdr.Close()
        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), "Dreamy Kitchen CRM", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
    Public Sub MECH(CtrlCombo As DevExpress.XtraEditors.LookUpEdit)
        Try
            Dim cmd As SqlCommand = New SqlCommand("Select id,name from vw_MECH order by name", CNDB)
            Dim sdr As SqlDataReader = cmd.ExecuteReader()
            CtrlCombo.Properties.DataSource = sdr
            CtrlCombo.Properties.DisplayMember = "name"
            CtrlCombo.Properties.ValueMember = "id"
            CtrlCombo.Properties.PopulateColumns()
            CtrlCombo.Properties.Columns(0).Visible = False
            CtrlCombo.Properties.Columns(1).Caption = "Μηχανισμοί"
            CtrlCombo.Properties.Columns(2).Visible = False
            sdr.Close()
        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), "Dreamy Kitchen CRM", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Public Sub STATUS(CtrlCombo As DevExpress.XtraEditors.LookUpEdit)
        Try
            Dim cmd As SqlCommand = New SqlCommand("Select id,Name,allowschedule from vw_STATUS order by name", CNDB)
            Dim sdr As SqlDataReader = cmd.ExecuteReader()

            CtrlCombo.Properties.DataSource = sdr
            CtrlCombo.Properties.DisplayMember = "Name"
            CtrlCombo.Properties.ValueMember = "id"
            CtrlCombo.Properties.PopulateColumns()
            CtrlCombo.Properties.Columns(0).Visible = False
            CtrlCombo.Properties.Columns(1).Caption = "Status"
            CtrlCombo.Properties.Columns(2).Visible = False
            sdr.Close()
        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), "Dreamy Kitchen CRM", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
    Public Sub DIMENSION(CtrlCombo As DevExpress.XtraEditors.LookUpEdit)
        Try
            Dim cmd As SqlCommand = New SqlCommand("Select id,Name from vw_DIM order by name", CNDB)
            Dim sdr As SqlDataReader = cmd.ExecuteReader()

            CtrlCombo.Properties.DataSource = sdr
            CtrlCombo.Properties.DisplayMember = "Name"
            CtrlCombo.Properties.ValueMember = "id"
            CtrlCombo.Properties.PopulateColumns()
            CtrlCombo.Properties.Columns(0).Visible = False
            CtrlCombo.Properties.Columns(1).Caption = "Διάσταση"
            sdr.Close()
        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), "Dreamy Kitchen CRM", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Public Sub REM_VALUES(CtrlCombo As DevExpress.XtraEditors.LookUpEdit)
        Try
            Dim cmd As SqlCommand = New SqlCommand("Select id,Name from vw_REM_VALUES order by code", CNDB)
            Dim sdr As SqlDataReader = cmd.ExecuteReader()

            CtrlCombo.Properties.DataSource = sdr
            CtrlCombo.Properties.DisplayMember = "Name"
            CtrlCombo.Properties.ValueMember = "id"
            CtrlCombo.Properties.PopulateColumns()
            CtrlCombo.Properties.Columns(0).Visible = False
            CtrlCombo.Properties.Columns(1).Caption = ""
            sdr.Close()
        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), "Dreamy Kitchen CRM", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
    Public Sub SRC(CtrlCombo As DevExpress.XtraEditors.LookUpEdit)
        Try
            Dim cmd As SqlCommand = New SqlCommand("Select id,Name from vw_SOURCE order by name", CNDB)
            Dim sdr As SqlDataReader = cmd.ExecuteReader()

            CtrlCombo.Properties.DataSource = sdr
            CtrlCombo.Properties.DisplayMember = "Name"
            CtrlCombo.Properties.ValueMember = "id"
            CtrlCombo.Properties.PopulateColumns()
            CtrlCombo.Properties.Columns(0).Visible = False
            CtrlCombo.Properties.Columns(1).Caption = "Πηγές"
            sdr.Close()
        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), "Dreamy Kitchen CRM", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
    Public Sub SALERS(CtrlCombo As DevExpress.XtraEditors.LookUpEdit)
        Try
            Dim cmd As SqlCommand = New SqlCommand("Select id,Name,color,code from vw_SALERS order by name", CNDB)
            Dim sdr As SqlDataReader = cmd.ExecuteReader()

            CtrlCombo.Properties.DataSource = sdr
            CtrlCombo.Properties.DisplayMember = "Name"
            CtrlCombo.Properties.ValueMember = "id"
            CtrlCombo.Properties.PopulateColumns()
            CtrlCombo.Properties.Columns(0).Visible = False
            CtrlCombo.Properties.Columns(1).Caption = "Πωλητές"
            CtrlCombo.Properties.Columns(2).Visible = False
            CtrlCombo.Properties.Columns(3).Visible = False
            sdr.Close()
        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), "Dreamy Kitchen CRM", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
    Public Sub USERS(CtrlCombo As DevExpress.XtraEditors.LookUpEdit)
        Try
            Dim cmd As SqlCommand = New SqlCommand("Select id,RealName from vw_USR", CNDB)
            Dim sdr As SqlDataReader = cmd.ExecuteReader()

            CtrlCombo.Properties.DataSource = sdr
            CtrlCombo.Properties.DisplayMember = "RealName"
            CtrlCombo.Properties.ValueMember = "id"
            CtrlCombo.Properties.PopulateColumns()
            CtrlCombo.Properties.Columns(0).Visible = False
            CtrlCombo.Properties.Columns(1).Caption = "Χρήστης"
            sdr.Close()
        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), "Dreamy Kitchen CRM", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
    Public Sub DOY(CtrlCombo As DevExpress.XtraEditors.LookUpEdit)
        Try
            Dim cmd As SqlCommand = New SqlCommand("Select id,Name from vw_DOY order by name", CNDB)
            Dim sdr As SqlDataReader = cmd.ExecuteReader()

            CtrlCombo.Properties.DataSource = sdr
            CtrlCombo.Properties.DisplayMember = "Name"
            CtrlCombo.Properties.ValueMember = "id"
            CtrlCombo.Properties.PopulateColumns()
            CtrlCombo.Properties.Columns(0).Visible = False
            CtrlCombo.Properties.Columns(1).Caption = "ΔΟΥ"
            sdr.Close()
        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), "Dreamy Kitchen CRM", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
    Public Sub PRF(CtrlCombo As DevExpress.XtraEditors.LookUpEdit)
        Try
            Dim cmd As SqlCommand = New SqlCommand("Select id,Name from vw_PRF order by name", CNDB)
            Dim sdr As SqlDataReader = cmd.ExecuteReader()

            CtrlCombo.Properties.DataSource = sdr
            CtrlCombo.Properties.DisplayMember = "Name"
            CtrlCombo.Properties.ValueMember = "id"
            CtrlCombo.Properties.PopulateColumns()
            CtrlCombo.Properties.Columns(0).Visible = False
            CtrlCombo.Properties.Columns(1).Caption = "Επαγγέλματα"
            sdr.Close()
        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), "Dreamy Kitchen CRM", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
    Public Sub CAT_ERM(CtrlCombo As DevExpress.XtraEditors.LookUpEdit)
        Try
            Dim cmd As SqlCommand = New SqlCommand("Select id,Name from vw_CAT_ERM order by name", CNDB)
            Dim sdr As SqlDataReader = cmd.ExecuteReader()

            CtrlCombo.Properties.DataSource = sdr
            CtrlCombo.Properties.DisplayMember = "Name"
            CtrlCombo.Properties.ValueMember = "id"
            CtrlCombo.Properties.PopulateColumns()
            CtrlCombo.Properties.Columns(0).Visible = False
            CtrlCombo.Properties.Columns(1).Caption = "Κατηγορίες Ερμαρίων"
            sdr.Close()
        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), "Dreamy Kitchen CRM", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
    Public Sub MAIL(CtrlCombo As DevExpress.XtraEditors.LookUpEdit)
        Try
            Dim ds As DataSet = New DataSet
            Dim cmd As SqlCommand = New SqlCommand("Select id,un,Server from vw_MAILS", CNDB)
            Dim sdr As SqlDataReader = cmd.ExecuteReader()

            CtrlCombo.Properties.DataSource = sdr
            CtrlCombo.Properties.DisplayMember = "un"
            CtrlCombo.Properties.ValueMember = "id"
            CtrlCombo.Properties.PopulateColumns()
            CtrlCombo.Properties.Columns(0).Visible = False
            CtrlCombo.Properties.Columns(1).Caption = "Email Account"
            CtrlCombo.Properties.Columns(2).Caption = "Server"
            sdr.Close()
        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), "Dreamy Kitchen CRM", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
    Public Sub FillCheckedListForms(CtrlList As DevExpress.XtraEditors.CheckedListBoxControl, ByVal mode As Byte, Optional ByVal sID As String = "")
        Try
            Dim sSQL As String
            If mode = FormMode.NewRecord Then
                sSQL = "Select id,name from vw_FORMS"
            Else
                sSQL = "SELECT F.id,F.name,isnull(( 
					    select case when VF.id is not null then 1 else 0 end as checked
					    from vw_FORMs VF
					    inner join vw_FORM_RIGHTS FR on FR.F_ID  = VF.ID 
					    inner join vw_RIGHTS R on R.ID  = FR.rID 
					    where R.ID = '" + sID + "'  and VF.ID=F.ID),0) as checked
                        from vw_FORMs F "
            End If
            Dim cmd As SqlCommand = New SqlCommand(sSQL, CNDB)
            Dim sdr As SqlDataReader = cmd.ExecuteReader()

            'chkLstUsers.DataSource = sdr
            CtrlList.DisplayMember = "name"
            CtrlList.ValueMember = "id"
            While sdr.Read()
                Dim chkLstItem As New DevExpress.XtraEditors.Controls.CheckedListBoxItem
                chkLstItem.Value = sdr.Item(1).ToString
                chkLstItem.Tag = sdr.Item(0).ToString
                If mode = FormMode.EditRecord Then chkLstItem.CheckState = sdr.Item(2).ToString

                CtrlList.Items.Add(chkLstItem)
            End While
            sdr.Close()
        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), "Dreamy Kitchen CRM", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub FillCheckedListMech(CtrlList As DevExpress.XtraEditors.CheckedListBoxControl, ByVal mode As Byte, Optional ByVal sID As String = "")
        Try
            Dim sSQL As String
            If mode = FormMode.NewRecord Then
                sSQL = "Select id,name + '(' + cast(isnull(price,'0') as nvarchar(10)) + '€)' as name ,price from vw_MECH"
            Else
                sSQL = "Select id,name + '(' + cast(isnull(price,'0') as nvarchar(10)) + '€)' as name,price,
                       isnull((select case when OM.id is not null then 1 else 0 end as checked
		               from vw_OFFER_MECH OM where offerid = '" & sID & "' and OM.mechID = M.ID),0) as checked
                       from vw_MECH M"
            End If
            Dim cmd As SqlCommand = New SqlCommand(sSQL, CNDB)
            Dim sdr As SqlDataReader = cmd.ExecuteReader()
            'chkLstUsers.DataSource = sdr
            CtrlList.Items.Clear()
            CtrlList.DisplayMember = "name"
            CtrlList.ValueMember = "id"
            While sdr.Read()
                Dim chkLstItem As New DevExpress.XtraEditors.Controls.CheckedListBoxItem
                chkLstItem.Value = sdr.Item(1).ToString
                chkLstItem.Tag = sdr.Item(0).ToString
                If mode = FormMode.EditRecord Then chkLstItem.CheckState = sdr.Item("checked").ToString Else chkLstItem.CheckState = CheckState.Unchecked
                CtrlList.Items.Add(chkLstItem)
            End While
            sdr.Close()
        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), "Dreamy Kitchen CRM", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
    Public Sub FillCheckedListSides(CtrlList As DevExpress.XtraEditors.CheckedListBoxControl, ByVal mode As Byte, Optional ByVal sID As String = "")
        Try
            Dim sSQL As String
            If mode = FormMode.NewRecord Then
                sSQL = "Select id,name + '(' + cast(isnull(TotPrice,'0') as nvarchar(10)) + '€)' as name ,TotPrice from vw_SIDES"
            Else
                sSQL = "Select id,name + '(' + cast(isnull(TotPrice,'0') as nvarchar(10)) + '€)' as name,TotPrice,
                       isnull((select case when OM.id is not null then 1 else 0 end as checked
		               from vw_OFFER_SIDES OM where offerid = '" & sID & "' and OM.sideID = S.ID),0) as checked
                       from vw_SIDES s"
            End If
            Dim cmd As SqlCommand = New SqlCommand(sSQL, CNDB)
            Dim sdr As SqlDataReader = cmd.ExecuteReader()
            'chkLstUsers.DataSource = sdr
            CtrlList.Items.Clear()
            CtrlList.DisplayMember = "name"
            CtrlList.ValueMember = "id"
            While sdr.Read()
                Dim chkLstItem As New DevExpress.XtraEditors.Controls.CheckedListBoxItem
                chkLstItem.Value = sdr.Item(1).ToString
                chkLstItem.Tag = sdr.Item(0).ToString
                If mode = FormMode.EditRecord Then chkLstItem.CheckState = sdr.Item("checked").ToString
                CtrlList.Items.Add(chkLstItem)
            End While
            sdr.Close()
        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), "Dreamy Kitchen CRM", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Public Sub FillCheckedListDoorTypes(CtrlList As DevExpress.XtraEditors.CheckedListBoxControl, ByVal mode As Byte, Optional ByVal sID As String = "")
        Try
            Dim sSQL As String
            If mode = FormMode.NewRecord Then
                sSQL = "Select id,name,price from [vw_DOOR_TYPE]"
            Else
                sSQL = "Select id,name,price,
                       isnull((select case when OM.id is not null then 1 else 0 end as checked
		               from vw_DOOR_TYPE DT where offerid = '" & sID & "' and OM.mechID = M.ID),0) as checked
                       from vw_MECH M"
            End If
            Dim cmd As SqlCommand = New SqlCommand(sSQL, CNDB)
            Dim sdr As SqlDataReader = cmd.ExecuteReader()
            'chkLstUsers.DataSource = sdr
            CtrlList.Items.Clear()
            CtrlList.DisplayMember = "name"
            CtrlList.ValueMember = "id"
            While sdr.Read()
                Dim chkLstItem As New DevExpress.XtraEditors.Controls.CheckedListBoxItem
                chkLstItem.Value = sdr.Item(1).ToString
                chkLstItem.Tag = sdr.Item(0).ToString
                If mode = FormMode.EditRecord Then chkLstItem.CheckState = sdr.Item("checked").ToString
                CtrlList.Items.Add(chkLstItem)
            End While
            sdr.Close()
        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), "Dreamy Kitchen CRM", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
    Public Sub FillCheckedListSubOff(CtrlList As DevExpress.XtraEditors.CheckedListBoxControl, ByVal sWhere As String)
        Try
            Dim sSQL As String
            sSQL = "Select id,SubOFFName from vw_OFF_SUBOFF " & sWhere & " order by SubOFFName"
            Dim cmd As SqlCommand = New SqlCommand(sSQL, CNDB)
            Dim sdr As SqlDataReader = cmd.ExecuteReader()
            'chkLstUsers.DataSource = sdr
            CtrlList.Items.Clear()
            CtrlList.DisplayMember = "SubOFFName"
            CtrlList.ValueMember = "id"
            While sdr.Read()
                Dim chkLstItem As New DevExpress.XtraEditors.Controls.CheckedListBoxItem
                chkLstItem.Value = sdr.Item(1).ToString
                chkLstItem.Tag = sdr.Item(0).ToString
                chkLstItem.CheckState = CheckState.Checked
                CtrlList.Items.Add(chkLstItem)
            End While
            sdr.Close()
        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), "Dreamy Kitchen CRM", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
End Class
