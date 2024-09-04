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
            CtrlCombo.Properties.Columns.Clear()
            CtrlCombo.Properties.ForceInitialize()
            CtrlCombo.Properties.PopulateColumns()
            CtrlCombo.Properties.Columns(0).Visible = False
            CtrlCombo.Properties.Columns(1).Caption = "Περιοχές"
            sdr.Close()
        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
    Public Sub BASE_CAT(CtrlCombo As DevExpress.XtraEditors.LookUpEdit)
        Try
            Dim cmd As SqlCommand = New SqlCommand("Select id,Name from vw_BASE_CAT order by name", CNDB)
            Dim sdr As SqlDataReader = cmd.ExecuteReader()

            CtrlCombo.Properties.DataSource = sdr
            CtrlCombo.Properties.DisplayMember = "Name"
            CtrlCombo.Properties.ValueMember = "id"
            CtrlCombo.Properties.Columns.Clear()
            CtrlCombo.Properties.ForceInitialize()
            CtrlCombo.Properties.PopulateColumns()
            CtrlCombo.Properties.Columns(0).Visible = False
            CtrlCombo.Properties.Columns(1).Caption = "Κεντρικές Κατηγορίες Ερμαρίων"
            sdr.Close()
        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
    Public Sub TRANSH_C(CtrlCombo As DevExpress.XtraEditors.LookUpEdit)
        Try
            Dim cmd As SqlCommand = New SqlCommand("Select id,Name from vw_TRANSH_C order by name", CNDB)
            Dim sdr As SqlDataReader = cmd.ExecuteReader()

            CtrlCombo.Properties.DataSource = sdr
            CtrlCombo.Properties.DisplayMember = "Name"
            CtrlCombo.Properties.ValueMember = "id"
            CtrlCombo.Properties.Columns.Clear()
            CtrlCombo.Properties.ForceInitialize()
            CtrlCombo.Properties.PopulateColumns()
            CtrlCombo.Properties.Columns(0).Visible = False
            CtrlCombo.Properties.Columns(1).Caption = "Κατηγορίες Έργων"
            sdr.Close()
        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
    Public Sub FILE_CAT(CtrlCombo As DevExpress.XtraEditors.LookUpEdit)
        Try
            Dim cmd As SqlCommand = New SqlCommand("Select id,Name from vw_FILE_CAT order by name", CNDB)
            Dim sdr As SqlDataReader = cmd.ExecuteReader()

            CtrlCombo.Properties.DataSource = sdr
            CtrlCombo.Properties.DisplayMember = "Name"
            CtrlCombo.Properties.ValueMember = "id"
            CtrlCombo.Properties.Columns.Clear()
            CtrlCombo.Properties.ForceInitialize()
            CtrlCombo.Properties.PopulateColumns()
            CtrlCombo.Properties.Columns(0).Visible = False
            CtrlCombo.Properties.Columns(1).Caption = "Κατηγορία"
            sdr.Close()
        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Public Sub PAY_TYPE(CtrlCombo As DevExpress.XtraEditors.LookUpEdit)
        Try
            Dim cmd As SqlCommand = New SqlCommand("Select id,Name from vw_PAY_TYPE order by name", CNDB)
            Dim sdr As SqlDataReader = cmd.ExecuteReader()

            CtrlCombo.Properties.DataSource = sdr
            CtrlCombo.Properties.DisplayMember = "Name"
            CtrlCombo.Properties.ValueMember = "id"
            CtrlCombo.Properties.Columns.Clear()
            CtrlCombo.Properties.ForceInitialize()
            CtrlCombo.Properties.PopulateColumns()
            CtrlCombo.Properties.Columns(0).Visible = False
            CtrlCombo.Properties.Columns(1).Caption = "Τύποι Πληρωμής"
            sdr.Close()
        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
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
            CtrlCombo.Properties.Columns.Clear()
            CtrlCombo.Properties.ForceInitialize()
            CtrlCombo.Properties.PopulateColumns()
            CtrlCombo.Properties.Columns(0).Visible = False
            CtrlCombo.Properties.Columns(1).Caption = "Κατηγορίες Τεχνικής Υποστήριξης"
            sdr.Close()
        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
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
            CtrlCombo.Properties.Columns.Clear()
            CtrlCombo.Properties.ForceInitialize()
            CtrlCombo.Properties.PopulateColumns()
            CtrlCombo.Properties.Columns(0).Visible = False
            CtrlCombo.Properties.Columns(1).Caption = "Κατηγορίες Χρωμάτων"
            sdr.Close()
        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
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
            CtrlCombo.Properties.Columns.Clear()
            CtrlCombo.Properties.ForceInitialize()
            CtrlCombo.Properties.PopulateColumns()
            CtrlCombo.Properties.Columns(0).Visible = False
            CtrlCombo.Properties.Columns(1).Caption = "Χρώματα"
            sdr.Close()
        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
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
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
    Public Sub ADR(CtrlCombo As DevExpress.XtraEditors.LookUpEdit, Optional ByVal sSQL As System.Text.StringBuilder = Nothing)
        Try
            If sSQL Is Nothing Then
                sSQL = New System.Text.StringBuilder
                sSQL.AppendLine("Select id,Name + ' - ' + isnull(ar,'') as Name from vw_ADR ")
            Else
                If sSQL.Length = 0 Then
                    sSQL = New System.Text.StringBuilder
                    sSQL.AppendLine("Select id,Name + ' - ' + isnull(ar,'') as Name from vw_ADR ")
                End If
            End If
            Dim cmd As SqlCommand = New SqlCommand(sSQL.ToString, CNDB)
            Dim sdr As SqlDataReader = cmd.ExecuteReader()
            CtrlCombo.Properties.DataSource = ""
            CtrlCombo.Properties.Columns.Clear()
            CtrlCombo.Properties.DataSource = sdr
            CtrlCombo.Properties.DisplayMember = "Name"
            CtrlCombo.Properties.ValueMember = "id"
            CtrlCombo.Properties.Columns.Clear()
            CtrlCombo.Properties.ForceInitialize()
            CtrlCombo.Properties.PopulateColumns()
            CtrlCombo.Properties.Columns(0).Visible = False
            CtrlCombo.Properties.Columns(1).Caption = "Διευθύνσεις"
            sdr.Close()
        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Public Sub USR(CtrlCombo As DevExpress.XtraEditors.LookUpEdit)
        Try
            Dim cmd As SqlCommand = New SqlCommand("Select id,un,Realname from vw_USR where isactive=1 order by un", CNDB)
            Dim sdr As SqlDataReader = cmd.ExecuteReader()

            CtrlCombo.Properties.DataSource = sdr
            CtrlCombo.Properties.DisplayMember = "un"
            CtrlCombo.Properties.ValueMember = "id"
            CtrlCombo.Properties.Columns.Clear()
            CtrlCombo.Properties.ForceInitialize()
            CtrlCombo.Properties.PopulateColumns()
            CtrlCombo.Properties.Columns(0).Visible = False
            CtrlCombo.Properties.Columns(1).Visible = False
            CtrlCombo.Properties.Columns(1).Caption = "Χρήστης"
            sdr.Close()
        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Public Sub COU(CtrlCombo As DevExpress.XtraEditors.LookUpEdit)
        Try
            Dim cmd As SqlCommand = New SqlCommand("Select id,Name from vw_COU order by name", CNDB)
            Dim sdr As SqlDataReader = cmd.ExecuteReader()

            CtrlCombo.Properties.DataSource = sdr
            CtrlCombo.Properties.DisplayMember = "Name"
            CtrlCombo.Properties.ValueMember = "id"
            CtrlCombo.Properties.Columns.Clear()
            CtrlCombo.Properties.ForceInitialize()
            CtrlCombo.Properties.PopulateColumns()
            CtrlCombo.Properties.Columns(0).Visible = False
            CtrlCombo.Properties.Columns(1).Caption = "Νομοί"
            sdr.Close()
        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
    Public Sub DOC_TYPES(CtrlCombo As DevExpress.XtraEditors.LookUpEdit)
        Try
            Dim cmd As SqlCommand = New SqlCommand("Select id,Name from vw_DOC_TYPES order by name", CNDB)
            Dim sdr As SqlDataReader = cmd.ExecuteReader()

            CtrlCombo.Properties.DataSource = sdr
            CtrlCombo.Properties.DisplayMember = "Name"
            CtrlCombo.Properties.ValueMember = "id"
            CtrlCombo.Properties.Columns.Clear()
            CtrlCombo.Properties.ForceInitialize()
            CtrlCombo.Properties.PopulateColumns()
            CtrlCombo.Properties.Columns(0).Visible = False
            CtrlCombo.Properties.Columns(1).Caption = "Τύποι Παραστατικών"
            sdr.Close()
        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Public Sub EMP_S(CtrlCombo As DevExpress.XtraEditors.LookUpEdit)
        Try
            Dim cmd As SqlCommand = New SqlCommand("Select id,Name from vw_EMP_S order by name", CNDB)
            Dim sdr As SqlDataReader = cmd.ExecuteReader()

            CtrlCombo.Properties.DataSource = sdr
            CtrlCombo.Properties.DisplayMember = "Name"
            CtrlCombo.Properties.ValueMember = "id"
            CtrlCombo.Properties.Columns.Clear()
            CtrlCombo.Properties.ForceInitialize()
            CtrlCombo.Properties.PopulateColumns()
            CtrlCombo.Properties.Columns(0).Visible = False
            CtrlCombo.Properties.Columns(1).Caption = "Statuses Παρουσιολογίου"
            sdr.Close()
        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
    Public Sub SALER_CAL_STATUS(CtrlCombo As DevExpress.XtraEditors.LookUpEdit)
        Try
            Dim cmd As SqlCommand = New SqlCommand("Select id,Name from vw_SALER_CAL_STATUS order by name", CNDB)
            Dim sdr As SqlDataReader = cmd.ExecuteReader()

            CtrlCombo.Properties.DataSource = sdr
            CtrlCombo.Properties.DisplayMember = "Name"
            CtrlCombo.Properties.ValueMember = "id"
            CtrlCombo.Properties.Columns.Clear()
            CtrlCombo.Properties.ForceInitialize()
            CtrlCombo.Properties.PopulateColumns()
            CtrlCombo.Properties.Columns(0).Visible = False
            CtrlCombo.Properties.Columns(1).Caption = "Statuses Προσ. Ημερολογίου"
            sdr.Close()
        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
    Public Sub CONSTR_CAT(CtrlCombo As DevExpress.XtraEditors.LookUpEdit)
        Try
            Dim cmd As SqlCommand = New SqlCommand("Select id,Name from vw_CONSTR_CAT order by name", CNDB)
            Dim sdr As SqlDataReader = cmd.ExecuteReader()

            CtrlCombo.Properties.DataSource = sdr
            CtrlCombo.Properties.DisplayMember = "Name"
            CtrlCombo.Properties.ValueMember = "id"
            CtrlCombo.Properties.Columns.Clear()
            CtrlCombo.Properties.ForceInitialize()
            CtrlCombo.Properties.PopulateColumns()
            CtrlCombo.Properties.Columns(0).Visible = False
            CtrlCombo.Properties.Columns(1).Caption = "Κατηγορίες Εργασίας"
            sdr.Close()
        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
    Public Sub BUY_C(CtrlCombo As DevExpress.XtraEditors.LookUpEdit)
        Try
            Dim cmd As SqlCommand = New SqlCommand("Select id,Name from vw_BUY_C order by name", CNDB)
            Dim sdr As SqlDataReader = cmd.ExecuteReader()

            CtrlCombo.Properties.DataSource = sdr
            CtrlCombo.Properties.DisplayMember = "Name"
            CtrlCombo.Properties.ValueMember = "id"
            CtrlCombo.Properties.Columns.Clear()
            CtrlCombo.Properties.ForceInitialize()
            CtrlCombo.Properties.PopulateColumns()
            CtrlCombo.Properties.Columns(0).Visible = False
            CtrlCombo.Properties.Columns(1).Caption = "Κατηγορίες Αγορών"
            sdr.Close()
        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
    Public Sub DEVICES(CtrlCombo As DevExpress.XtraEditors.LookUpEdit)
        Try
            Dim cmd As SqlCommand = New SqlCommand("Select id,Name from vw_DEVICES order by name", CNDB)
            Dim sdr As SqlDataReader = cmd.ExecuteReader()

            CtrlCombo.Properties.DataSource = sdr
            CtrlCombo.Properties.DisplayMember = "Name"
            CtrlCombo.Properties.ValueMember = "id"
            CtrlCombo.Properties.Columns.Clear()
            CtrlCombo.Properties.ForceInitialize()
            CtrlCombo.Properties.PopulateColumns()
            CtrlCombo.Properties.Columns(0).Visible = False
            CtrlCombo.Properties.Columns(1).Caption = "Συσκευές"
            sdr.Close()
        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
    Public Sub EQUIPMENT(CtrlCombo As DevExpress.XtraEditors.LookUpEdit)
        Try
            Dim cmd As SqlCommand = New SqlCommand("Select id,Name from vw_EQUIPMENT order by name", CNDB)
            Dim sdr As SqlDataReader = cmd.ExecuteReader()

            CtrlCombo.Properties.DataSource = sdr
            CtrlCombo.Properties.DisplayMember = "Name"
            CtrlCombo.Properties.ValueMember = "id"
            CtrlCombo.Properties.Columns.Clear()
            CtrlCombo.Properties.ForceInitialize()
            CtrlCombo.Properties.PopulateColumns()
            CtrlCombo.Properties.Columns(0).Visible = False
            CtrlCombo.Properties.Columns(1).Caption = "Εξοπλισμός"
            sdr.Close()
        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
    Public Sub EQUIPMENT_CAT(CtrlCombo As DevExpress.XtraEditors.LookUpEdit)
        Try
            Dim cmd As SqlCommand = New SqlCommand("Select id,Name from vw_EQUIPMENT_CAT order by name", CNDB)
            Dim sdr As SqlDataReader = cmd.ExecuteReader()

            CtrlCombo.Properties.DataSource = sdr
            CtrlCombo.Properties.DisplayMember = "Name"
            CtrlCombo.Properties.ValueMember = "id"
            CtrlCombo.Properties.Columns.Clear()
            CtrlCombo.Properties.ForceInitialize()
            CtrlCombo.Properties.PopulateColumns()
            CtrlCombo.Properties.Columns(0).Visible = False
            CtrlCombo.Properties.Columns(1).Caption = "Κατηγορίες Εξαρτημάτων"
            sdr.Close()
        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Public Sub CONSTR_TYPE(CtrlCombo As DevExpress.XtraEditors.LookUpEdit)
        Try
            Dim cmd As SqlCommand = New SqlCommand("Select id,Name from vw_CONSTR_TYPE order by name", CNDB)
            Dim sdr As SqlDataReader = cmd.ExecuteReader()

            CtrlCombo.Properties.DataSource = sdr
            CtrlCombo.Properties.DisplayMember = "Name"
            CtrlCombo.Properties.ValueMember = "id"
            CtrlCombo.Properties.Columns.Clear()
            CtrlCombo.Properties.ForceInitialize()
            CtrlCombo.Properties.PopulateColumns()
            CtrlCombo.Properties.Columns(0).Visible = False
            CtrlCombo.Properties.Columns(1).Caption = "Είδη Κατασκευής"
            sdr.Close()
        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub



    Public Sub PAY(CtrlCombo As DevExpress.XtraEditors.LookUpEdit)
        Try
            Dim cmd As SqlCommand = New SqlCommand("Select id,Name from vw_PAY order by name", CNDB)
            Dim sdr As SqlDataReader = cmd.ExecuteReader()

            CtrlCombo.Properties.DataSource = sdr
            CtrlCombo.Properties.DisplayMember = "Name"
            CtrlCombo.Properties.ValueMember = "id"
            CtrlCombo.Properties.Columns.Clear()
            CtrlCombo.Properties.ForceInitialize()
            CtrlCombo.Properties.PopulateColumns()
            CtrlCombo.Properties.Columns(0).Visible = False
            CtrlCombo.Properties.Columns(1).Caption = "Τρόποι Πληρωμής"
            sdr.Close()
        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
    Public Sub EP_STATUS(CtrlCombo As DevExpress.XtraEditors.LookUpEdit)
        Try
            Dim cmd As SqlCommand = New SqlCommand("Select id,Name from vw_EP_STATUS order by name", CNDB)
            Dim sdr As SqlDataReader = cmd.ExecuteReader()

            CtrlCombo.Properties.DataSource = sdr
            CtrlCombo.Properties.DisplayMember = "Name"
            CtrlCombo.Properties.ValueMember = "id"
            CtrlCombo.Properties.Columns.Clear()
            CtrlCombo.Properties.ForceInitialize()
            CtrlCombo.Properties.PopulateColumns()
            CtrlCombo.Properties.Columns(0).Visible = False
            CtrlCombo.Properties.Columns(1).Caption = "Status Εποπτείας"
            sdr.Close()
        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
    Public Sub JOBS(CtrlCombo As DevExpress.XtraEditors.LookUpEdit)
        Try
            Dim cmd As SqlCommand = New SqlCommand("Select id,Name from vw_JOBS order by name", CNDB)
            Dim sdr As SqlDataReader = cmd.ExecuteReader()

            CtrlCombo.Properties.DataSource = sdr
            CtrlCombo.Properties.DisplayMember = "Name"
            CtrlCombo.Properties.ValueMember = "id"
            CtrlCombo.Properties.Columns.Clear()
            CtrlCombo.Properties.ForceInitialize()
            CtrlCombo.Properties.PopulateColumns()
            CtrlCombo.Properties.Columns(0).Visible = False
            CtrlCombo.Properties.Columns(1).Caption = "Θέσεις Εργασίας"
            sdr.Close()
        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
    Public Sub SCAN_FILE_NAMES(CtrlCombo As DevExpress.XtraEditors.LookUpEdit)
        Try
            Dim cmd As SqlCommand = New SqlCommand("Select id,Name from vw_SCAN_FILE_NAMES order by name", CNDB)
            Dim sdr As SqlDataReader = cmd.ExecuteReader()

            CtrlCombo.Properties.DataSource = sdr
            CtrlCombo.Properties.DisplayMember = "Name"
            CtrlCombo.Properties.ValueMember = "id"
            CtrlCombo.Properties.Columns.Clear()
            CtrlCombo.Properties.ForceInitialize()
            CtrlCombo.Properties.PopulateColumns()
            CtrlCombo.Properties.Columns(0).Visible = False
            CtrlCombo.Properties.Columns(1).Caption = "Ονομασίες Scan αρχείων"
            sdr.Close()
        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
    Public Sub EMP_M_S(CtrlCombo As DevExpress.XtraEditors.LookUpEdit)
        Try
            Dim cmd As SqlCommand = New SqlCommand("Select id,Name from vw_EMP_M_S order by name", CNDB)
            Dim sdr As SqlDataReader = cmd.ExecuteReader()

            CtrlCombo.Properties.DataSource = sdr
            CtrlCombo.Properties.DisplayMember = "Name"
            CtrlCombo.Properties.ValueMember = "id"
            CtrlCombo.Properties.Columns.Clear()
            CtrlCombo.Properties.ForceInitialize()
            CtrlCombo.Properties.PopulateColumns()
            CtrlCombo.Properties.Columns(0).Visible = False
            CtrlCombo.Properties.Columns(1).Caption = "Statuses Μισθοδοσίας"
            sdr.Close()
        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Public Sub DEP(CtrlCombo As DevExpress.XtraEditors.LookUpEdit)
        Try
            Dim cmd As SqlCommand = New SqlCommand("Select id,Name from vw_DEP order by name", CNDB)
            Dim sdr As SqlDataReader = cmd.ExecuteReader()

            CtrlCombo.Properties.DataSource = sdr
            CtrlCombo.Properties.DisplayMember = "Name"
            CtrlCombo.Properties.ValueMember = "id"
            CtrlCombo.Properties.Columns.Clear()
            CtrlCombo.Properties.ForceInitialize()
            CtrlCombo.Properties.PopulateColumns()
            CtrlCombo.Properties.Columns(0).Visible = False
            CtrlCombo.Properties.Columns(1).Caption = "Τμήματα"
            sdr.Close()
        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Public Sub BANKS(CtrlCombo As DevExpress.XtraEditors.LookUpEdit)
        Try
            Dim cmd As SqlCommand = New SqlCommand("Select id,Name from vw_BANKS order by name", CNDB)
            Dim sdr As SqlDataReader = cmd.ExecuteReader()

            CtrlCombo.Properties.DataSource = sdr
            CtrlCombo.Properties.DisplayMember = "Name"
            CtrlCombo.Properties.ValueMember = "id"
            CtrlCombo.Properties.Columns.Clear()
            CtrlCombo.Properties.ForceInitialize()
            CtrlCombo.Properties.PopulateColumns()
            CtrlCombo.Properties.Columns(0).Visible = False
            CtrlCombo.Properties.Columns(1).Caption = "Τράπεζες"
            sdr.Close()
        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
    Public Sub FillCheckedListSER(CtrlList As DevExpress.XtraEditors.CheckedListBoxControl, ByVal mode As Byte, Optional ByVal sID As String = "", Optional ByVal sCategory As Int16 = 0)
        Try
            Dim sSQL As String
            If mode = FormMode.NewRecord Then
                sSQL = "Select id,Fullname,salary,tmIN,tmOUT,isnull(externalPartner,0) as externalPartner from vw_EMP where active=1 and isnull(externalPartner,0) = 0 
                        and jobID IN('A7C491B1-965B-4E86-95CF-C7881935C77D','F1A60661-D448-41B7-8CF0-CE6B9FF6E518') order by Fullname"
            Else
                Dim category As String
                Select Case sCategory
                    Case 0 : category = " and kitchen = 1"
                    Case 1 : category = " and closet = 1"
                    Case 2 : category = " and doors = 1"
                    Case 3 : category = " and sc = 1"
                End Select

                sSQL = "Select id,Fullname ,isnull(externalPartner,0) as externalPartner,
                       isnull((select case when INST_SER.id is not null then 1 else 0 end as checked
		               from INST_SER where instID = '" & sID & "' and INST_SER.empID = M.ID " & category & " ),0) as checked
                       from vw_EMP M where active=1  and isnull(externalPartner,0) = 0 and jobID IN('A7C491B1-965B-4E86-95CF-C7881935C77D','F1A60661-D448-41B7-8CF0-CE6B9FF6E518') order by Fullname"
            End If
            Dim cmd As SqlCommand = New SqlCommand(sSQL, CNDB)
            Dim sdr As SqlDataReader = cmd.ExecuteReader()
            'chkLstUsers.DataSource = sdr
            CtrlList.MultiColumn = True
            CtrlList.Items.Clear()
            CtrlList.DisplayMember = "Fullname"
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
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
    Public Sub FillCheckedListINST_ELLIPSE_SER(CtrlList As DevExpress.XtraEditors.CheckedListBoxControl, ByVal mode As Byte, Optional ByVal sID As String = "")
        Try
            Dim sSQL As String
            If mode = FormMode.NewRecord Then
                sSQL = "Select id,Fullname,salary,tmIN,tmOUT from vw_EMP where active=1 and jobID IN('A7C491B1-965B-4E86-95CF-C7881935C77D','F1A60661-D448-41B7-8CF0-CE6B9FF6E518') order by Fullname"
            Else
                sSQL = "Select id,Fullname ,
                       isnull((select case when INST_ELLIPSE_SER.id is not null then 1 else 0 end as checked
		               from INST_ELLIPSE_SER where instEllipseID = '" & sID & "' and INST_ELLIPSE_SER.empID = M.ID),0) as checked
                       from vw_EMP M where active=1 and jobID IN('A7C491B1-965B-4E86-95CF-C7881935C77D','F1A60661-D448-41B7-8CF0-CE6B9FF6E518') order by Fullname"
            End If
            Dim cmd As SqlCommand = New SqlCommand(sSQL, CNDB)
            Dim sdr As SqlDataReader = cmd.ExecuteReader()
            'chkLstUsers.DataSource = sdr
            CtrlList.Items.Clear()
            CtrlList.DisplayMember = "Fullname"
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
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
    Public Sub FillCheckedListPROJECT_JOBS_SER(CtrlList As DevExpress.XtraEditors.CheckedListBoxControl, ByVal mode As Byte, Optional ByVal sID As String = "")
        Try
            Dim sSQL As String
            If mode = FormMode.NewRecord Then
                sSQL = "Select id,Fullname,salary,tmIN,tmOUT from vw_EMP where active=1 and jobID IN('A7C491B1-965B-4E86-95CF-C7881935C77D','F1A60661-D448-41B7-8CF0-CE6B9FF6E518') order by Fullname"
            Else
                sSQL = "Select id,Fullname ,
                       isnull((select case when PROJECT_JOBS_SER.id is not null then 1 else 0 end as checked
		               from PROJECT_JOBS_SER where projectJobID = '" & sID & "' and PROJECT_JOBS_SER.empID = M.ID),0) as checked
                       from vw_EMP M where active=1 and jobID IN('A7C491B1-965B-4E86-95CF-C7881935C77D','F1A60661-D448-41B7-8CF0-CE6B9FF6E518') order by Fullname"
            End If
            Dim cmd As SqlCommand = New SqlCommand(sSQL, CNDB)
            Dim sdr As SqlDataReader = cmd.ExecuteReader()
            'chkLstUsers.DataSource = sdr
            CtrlList.Items.Clear()
            CtrlList.DisplayMember = "Fullname"
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
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
    Public Sub SER(CtrlCombo As DevExpress.XtraEditors.LookUpEdit, Optional ByVal sSQL As System.Text.StringBuilder = Nothing)
        Try
            If sSQL Is Nothing Then
                sSQL = New System.Text.StringBuilder
                sSQL.AppendLine("Select id,Fullname,salary,tmIN,tmOUT from vw_EMP order by Fullname")
            End If

            Dim cmd As SqlCommand = New SqlCommand(sSQL.ToString, CNDB)
            Dim sdr As SqlDataReader = cmd.ExecuteReader()

            CtrlCombo.Properties.DataSource = sdr
            CtrlCombo.Properties.DisplayMember = "Fullname"
            CtrlCombo.Properties.ValueMember = "id"
            CtrlCombo.Properties.Columns.Clear()
            CtrlCombo.Properties.ForceInitialize()
            CtrlCombo.Properties.PopulateColumns()
            CtrlCombo.Properties.Columns(0).Visible = False
            CtrlCombo.Properties.Columns(1).Caption = "Συνεργεία"
            CtrlCombo.Properties.Columns(2).Caption = "Μισθός"
            CtrlCombo.Properties.Columns(2).Visible = False
            CtrlCombo.Properties.Columns(3).Caption = "Ώρα Εισόδου"
            CtrlCombo.Properties.Columns(3).Visible = False
            CtrlCombo.Properties.Columns(4).Caption = "Ώρα Εξόδου"
            CtrlCombo.Properties.Columns(4).Visible = False
            sdr.Close()
        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
    Public Sub EXTPARTNERS(CtrlCombo As DevExpress.XtraEditors.LookUpEdit, Optional ByVal sSQL As System.Text.StringBuilder = Nothing)
        Try
            If sSQL Is Nothing Then
                sSQL = New System.Text.StringBuilder
                sSQL.AppendLine("Select id,Fullname,salary,tmIN,tmOUT from vw_EMP where externalPartner=1 order by Fullname")
            End If

            Dim cmd As SqlCommand = New SqlCommand(sSQL.ToString, CNDB)
            Dim sdr As SqlDataReader = cmd.ExecuteReader()

            CtrlCombo.Properties.DataSource = sdr
            CtrlCombo.Properties.DisplayMember = "Fullname"
            CtrlCombo.Properties.ValueMember = "id"
            CtrlCombo.Properties.Columns.Clear()
            CtrlCombo.Properties.ForceInitialize()
            CtrlCombo.Properties.PopulateColumns()
            CtrlCombo.Properties.Columns(0).Visible = False
            CtrlCombo.Properties.Columns(1).Caption = "Συνεργεία"
            CtrlCombo.Properties.Columns(2).Caption = "Μισθός"
            CtrlCombo.Properties.Columns(2).Visible = False
            CtrlCombo.Properties.Columns(3).Caption = "Ώρα Εισόδου"
            CtrlCombo.Properties.Columns(3).Visible = False
            CtrlCombo.Properties.Columns(4).Caption = "Ώρα Εξόδου"
            CtrlCombo.Properties.Columns(4).Visible = False
            sdr.Close()
        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Public Sub NOTES_L(CtrlCombo As DevExpress.XtraEditors.LookUpEdit)
        Try
            Dim cmd As SqlCommand = New SqlCommand("Select id,Name from vw_NOTES_L order by name", CNDB)
            Dim sdr As SqlDataReader = cmd.ExecuteReader()

            CtrlCombo.Properties.DataSource = sdr
            CtrlCombo.Properties.DisplayMember = "Name"
            CtrlCombo.Properties.ValueMember = "id"
            CtrlCombo.Properties.Columns.Clear()
            CtrlCombo.Properties.ForceInitialize()
            CtrlCombo.Properties.PopulateColumns()
            CtrlCombo.Properties.Columns(0).Visible = False
            CtrlCombo.Properties.Columns(1).Caption = "Εττικέτες"
            sdr.Close()
        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
    Public Sub EMP(CtrlCombo As DevExpress.XtraEditors.LookUpEdit, Optional ByVal sSQL As System.Text.StringBuilder = Nothing)
        Try
            If sSQL Is Nothing Then
                sSQL = New System.Text.StringBuilder
                sSQL.AppendLine("Select id,Fullname,salary  from vw_EMP order by Fullname")
            End If

            Dim cmd As SqlCommand = New SqlCommand(sSQL.ToString, CNDB)
            Dim sdr As SqlDataReader = cmd.ExecuteReader()
            CtrlCombo.Properties.DataSource = sdr
            CtrlCombo.Properties.DisplayMember = "Fullname"
            CtrlCombo.Properties.ValueMember = "id"
            CtrlCombo.Properties.Columns.Clear()
            CtrlCombo.Properties.ForceInitialize()
            CtrlCombo.Properties.PopulateColumns()
            CtrlCombo.Properties.Columns(0).Visible = False
            CtrlCombo.Properties.Columns(1).Caption = "Προσωπικό"
            If sdr.FieldCount > 2 Then
                CtrlCombo.Properties.Columns(2).Caption = "Μισθός"
                CtrlCombo.Properties.Columns(2).Visible = False
            End If
            sdr.Close()
        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
    Public Sub CUS(CtrlCombo As DevExpress.XtraEditors.LookUpEdit, Optional ByVal sSQL As System.Text.StringBuilder = Nothing)
        Try
            If sSQL Is Nothing Then
                sSQL = New System.Text.StringBuilder
                sSQL.AppendLine("Select id,Fullname,'00000000-0000-0000-0000-000000000000' as SalerID,phn,AdrID,email,isCompany from vw_CCT order by Fullname")
            End If

            Dim cmd As SqlCommand = New SqlCommand(sSQL.ToString, CNDB)
            Dim sdr As SqlDataReader = cmd.ExecuteReader()
            CtrlCombo.Properties.DisplayMember = "Fullname"
            CtrlCombo.Properties.ValueMember = "id"
            CtrlCombo.Properties.DataSource = sdr
            CtrlCombo.Properties.Columns.Clear()
            CtrlCombo.Properties.ForceInitialize()
            CtrlCombo.Properties.PopulateColumns()
            CtrlCombo.Properties.Columns(0).Visible = False
            CtrlCombo.Properties.Columns(1).Caption = "Πελάτες"
            CtrlCombo.Properties.Columns(2).Visible = False
            CtrlCombo.Properties.Columns(3).Caption = "Τηλέφωνο"
            CtrlCombo.Properties.Columns(4).Visible = False
            sdr.Close()
        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
    Public Sub COMPANY(CtrlCombo As DevExpress.XtraEditors.LookUpEdit, Optional ByVal sSQL As System.Text.StringBuilder = Nothing)
        Try
            If sSQL Is Nothing Then
                sSQL = New System.Text.StringBuilder
                sSQL.AppendLine("Select id,Fullname,'00000000-0000-0000-0000-000000000000' as SalerID,phn,AdrID,email,isCompany from vw_CCT WHERE isCompany = 1 order by Fullname")
            End If

            Dim cmd As SqlCommand = New SqlCommand(sSQL.ToString, CNDB)
            Dim sdr As SqlDataReader = cmd.ExecuteReader()
            CtrlCombo.Properties.DisplayMember = "Fullname"
            CtrlCombo.Properties.ValueMember = "id"
            CtrlCombo.Properties.DataSource = sdr
            CtrlCombo.Properties.Columns.Clear()
            CtrlCombo.Properties.ForceInitialize()
            CtrlCombo.Properties.PopulateColumns()
            CtrlCombo.Properties.Columns(0).Visible = False
            CtrlCombo.Properties.Columns(1).Caption = "Πελάτες"
            CtrlCombo.Properties.Columns(2).Visible = False
            CtrlCombo.Properties.Columns(3).Caption = "Τηλέφωνο"
            CtrlCombo.Properties.Columns(4).Visible = False
            sdr.Close()
        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
    Public Sub SUP(CtrlCombo As DevExpress.XtraEditors.LookUpEdit)
        Try
            'Dim cmd As SqlCommand = New SqlCommand("Select id,Fullname,isnull(SalerID,'00000000-0000-0000-0000-000000000000') as SalerID from vw_CCT order by Fullname", CNDB)
            Dim cmd As SqlCommand = New SqlCommand("Select id,Fullname,payID from vw_SUP order by Fullname", CNDB)
            Dim sdr As SqlDataReader = cmd.ExecuteReader()
            CtrlCombo.Properties.DataSource = sdr
            CtrlCombo.Properties.DisplayMember = "Fullname"
            CtrlCombo.Properties.ValueMember = "id"
            CtrlCombo.Properties.Columns.Clear()
            CtrlCombo.Properties.ForceInitialize()
            CtrlCombo.Properties.PopulateColumns()
            CtrlCombo.Properties.Columns(0).Visible = False
            CtrlCombo.Properties.Columns(1).Caption = "Προμηθευτές"
            CtrlCombo.Properties.Columns(2).Visible = False
            sdr.Close()
        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Public Sub TRANSH(CtrlCombo As DevExpress.XtraEditors.LookUpEdit, Optional ByVal sSQL As System.Text.StringBuilder = Nothing)
        Try
            If sSQL Is Nothing Then
                sSQL = New System.Text.StringBuilder
                sSQL.AppendLine("Select id,FullTranshDescription,Totamt,Iskitchen,Iscloset,Isdoor,Issc,offerCusAcceptance
                                from vw_TRANSH  order by FullTranshDescription")
            End If
            Dim cmd As SqlCommand = New SqlCommand(sSQL.ToString, CNDB)
            Dim sdr As SqlDataReader = cmd.ExecuteReader()
            CtrlCombo.Properties.DisplayMember = "FullTranshDescription"
            CtrlCombo.Properties.ValueMember = "id"
            CtrlCombo.Properties.Columns.Clear()
            CtrlCombo.Properties.DataSource = sdr
            CtrlCombo.Properties.ForceInitialize()
            CtrlCombo.Properties.PopulateColumns()
            CtrlCombo.Properties.Columns(0).Visible = False
            CtrlCombo.Properties.Columns(1).Caption = "Έργα"
            For i As Integer = 0 To CtrlCombo.Properties.Columns.Count - 1
                If i <> 1 Then CtrlCombo.Properties.Columns(i).Visible = False
            Next
            If sSQL.ToString.Contains("offerCusAcceptance") Then
                CtrlCombo.Properties.Columns("offerCusAcceptance").Caption = "Αποδοχή Προσφοράς"
                CtrlCombo.Properties.Columns("offerCusAcceptance").Visible = True
            End If

            sdr.Close()
        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
    Public Sub TRANSH_FOR_PROJECTCOST(CtrlCombo As DevExpress.XtraEditors.LookUpEdit, ByVal sSQL As System.Text.StringBuilder)
        Try
            Dim cmd As SqlCommand = New SqlCommand(sSQL.ToString, CNDB)
            Dim sdr As SqlDataReader = cmd.ExecuteReader()
            CtrlCombo.Properties.DataSource = ""
            CtrlCombo.Properties.Columns.Clear()
            CtrlCombo.Properties.DataSource = sdr
            CtrlCombo.Properties.DisplayMember = "FullTranshDescription"
            CtrlCombo.Properties.ValueMember = "id"
            CtrlCombo.Properties.ForceInitialize()
            CtrlCombo.Properties.PopulateColumns()

            CtrlCombo.Properties.Columns(0).Visible = False
            CtrlCombo.Properties.Columns(1).Caption = "Έργα"
            If sdr.HasRows Then
                CtrlCombo.Properties.Columns(2).Visible = False
                CtrlCombo.Properties.Columns(3).Visible = False
                CtrlCombo.Properties.Columns(4).Visible = False
                CtrlCombo.Properties.Columns(5).Visible = False
                CtrlCombo.Properties.Columns(6).Visible = False
                CtrlCombo.Properties.Columns(7).Visible = False
                CtrlCombo.Properties.Columns(8).Visible = False
                CtrlCombo.Properties.Columns(9).Visible = False
                CtrlCombo.Properties.Columns(10).Visible = False
                CtrlCombo.Properties.Columns(11).Visible = False
                CtrlCombo.Properties.Columns(12).Visible = False
                CtrlCombo.Properties.Columns(13).Visible = False
                CtrlCombo.Properties.Columns(14).Visible = False
            End If
            sdr.Close()
        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try

    End Sub
    Public Sub CALC(CtrlCombo As DevExpress.XtraEditors.LookUpEdit)
        Try
            Dim cmd As SqlCommand = New SqlCommand("Select id,name,calculations from vw_CALC order by name", CNDB)
            Dim sdr As SqlDataReader = cmd.ExecuteReader()
            CtrlCombo.Properties.DataSource = sdr
            CtrlCombo.Properties.DisplayMember = "name"
            CtrlCombo.Properties.ValueMember = "id"
            CtrlCombo.Properties.Columns.Clear()
            CtrlCombo.Properties.ForceInitialize()
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
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Public Sub valueListItem(Optional CtrlCombo As DevExpress.XtraEditors.LookUpEdit = Nothing, Optional ByVal sSQL As System.Text.StringBuilder = Nothing, Optional CtrlCheckedCombo As DevExpress.XtraEditors.CheckedComboBoxEdit = Nothing)
        Try
            Dim sVal As String
            If sSQL Is Nothing Then
                sSQL = New System.Text.StringBuilder
                sSQL.AppendLine("Select id,name,price from vw_VALUELISTITEM order by code")
            End If
            Dim cmd As SqlCommand = New SqlCommand(sSQL.ToString, CNDB)
            Dim sdr As SqlDataReader = cmd.ExecuteReader()
            If CtrlCombo IsNot Nothing Then
                CtrlCombo.Properties.DataSource = sdr
                CtrlCombo.Properties.DisplayMember = "name"
                CtrlCombo.Properties.ValueMember = "id"
                CtrlCombo.Properties.Columns.Clear()
                CtrlCombo.Properties.ForceInitialize()
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
            Else
                CtrlCheckedCombo.Properties.DataSource = sdr
                CtrlCheckedCombo.Properties.DisplayMember = "name"
                CtrlCheckedCombo.Properties.ValueMember = "id"
            End If
            'CtrlCombo.EditValue = Nothing
            sdr.Close()
        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
    Public Sub ERM(CtrlCombo As DevExpress.XtraEditors.LookUpEdit)
        Try
            Dim cmd As SqlCommand = New SqlCommand("Select id,catErmName,catSubErmName from vw_ERM order by catErmName,catSubErmName ", CNDB)
            Dim sdr As SqlDataReader = cmd.ExecuteReader()
            CtrlCombo.Properties.DataSource = sdr
            CtrlCombo.Properties.DisplayMember = "catErmName"
            CtrlCombo.Properties.ValueMember = "id"
            CtrlCombo.Properties.Columns.Clear()
            CtrlCombo.Properties.ForceInitialize()
            CtrlCombo.Properties.PopulateColumns()
            CtrlCombo.Properties.Columns(0).Visible = False
            CtrlCombo.Properties.Columns(1).Caption = "Κατηγορία"
            CtrlCombo.Properties.Columns(1).Width = 150
            CtrlCombo.Properties.Columns(2).Visible = True
            CtrlCombo.Properties.Columns(2).Caption = "Υποκατηγορία"
            CtrlCombo.Properties.Columns(2).Width = 150
            sdr.Close()
        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
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
                CtrlCombo.Properties.Columns.Clear()
                CtrlCombo.Properties.ForceInitialize()
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
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
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
            CtrlCombo.Properties.Columns.Clear()
            CtrlCombo.Properties.ForceInitialize()
            CtrlCombo.Properties.PopulateColumns()
            CtrlCombo.Properties.Columns(0).Visible = False
            CtrlCombo.Properties.Columns(1).Caption = "Υποκατηγορίες Ερμαρίων"
            'CtrlCombo.Properties.Columns(2).Visible = False
            sdr.Close()
        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
    Public Sub CCE_ORDERS_KITCHEN(CtrlCombo As DevExpress.XtraEditors.LookUpEdit, Optional ByVal sSQL As System.Text.StringBuilder = Nothing)
        Try
            If sSQL Is Nothing Then
                sSQL = New System.Text.StringBuilder
                sSQL.AppendLine("Select id,code,dtOffer from CCT_ORDERS_KITCHEN order by code")
            End If
            Dim cmd As SqlCommand = New SqlCommand(sSQL.ToString, CNDB)
            Dim sdr As SqlDataReader = cmd.ExecuteReader()
            CtrlCombo.Properties.DataSource = sdr
            CtrlCombo.Properties.DisplayMember = "code"
            CtrlCombo.Properties.ValueMember = "id"
            CtrlCombo.Properties.Columns.Clear()
            CtrlCombo.Properties.ForceInitialize()
            CtrlCombo.Properties.PopulateColumns()
            CtrlCombo.Properties.Columns(0).Visible = False
            CtrlCombo.Properties.Columns(1).Caption = "Κωδικός Παραγγελίας"
            CtrlCombo.Properties.Columns(2).Caption = "Ημερ/νία Παραγγελίας"
            'CtrlCombo.Properties.Columns(2).Visible = False
            sdr.Close()
        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
    Public Sub BENCH(CtrlCombo As DevExpress.XtraEditors.LookUpEdit)
        Try
            Dim cmd As SqlCommand = New SqlCommand("Select id,name,pricePerMeter from vw_BENCH order by name", CNDB)
            Dim sdr As SqlDataReader = cmd.ExecuteReader()
            CtrlCombo.Properties.DataSource = sdr
            CtrlCombo.Properties.DisplayMember = "name"
            CtrlCombo.Properties.ValueMember = "id"
            CtrlCombo.Properties.Columns.Clear()
            CtrlCombo.Properties.ForceInitialize()
            CtrlCombo.Properties.PopulateColumns()
            CtrlCombo.Properties.Columns(0).Visible = False
            CtrlCombo.Properties.Columns(1).Caption = "Πάγκοι"
            CtrlCombo.Properties.Columns(2).Visible = False
            sdr.Close()
        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
    Public Sub MECH(CtrlCombo As DevExpress.XtraEditors.LookUpEdit)
        Try
            Dim cmd As SqlCommand = New SqlCommand("Select id,name from vw_MECH order by name", CNDB)
            Dim sdr As SqlDataReader = cmd.ExecuteReader()
            CtrlCombo.Properties.DataSource = sdr
            CtrlCombo.Properties.DisplayMember = "name"
            CtrlCombo.Properties.ValueMember = "id"
            CtrlCombo.Properties.Columns.Clear()
            CtrlCombo.Properties.ForceInitialize()
            CtrlCombo.Properties.PopulateColumns()
            CtrlCombo.Properties.Columns(0).Visible = False
            CtrlCombo.Properties.Columns(1).Caption = "Μηχανισμοί"
            CtrlCombo.Properties.Columns(2).Visible = False
            sdr.Close()
        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Public Sub STATUS(CtrlCombo As DevExpress.XtraEditors.LookUpEdit)
        Try
            Dim cmd As SqlCommand = New SqlCommand("Select id,Name,allowschedule,RequiredSaler,RequiredCounter,RequiredAddress from vw_STATUS order by name", CNDB)
            Dim sdr As SqlDataReader = cmd.ExecuteReader()

            CtrlCombo.Properties.DataSource = sdr
            CtrlCombo.Properties.DisplayMember = "Name"
            CtrlCombo.Properties.ValueMember = "id"
            CtrlCombo.Properties.Columns.Clear()
            CtrlCombo.Properties.ForceInitialize()
            CtrlCombo.Properties.PopulateColumns()
            CtrlCombo.Properties.Columns(0).Visible = False
            CtrlCombo.Properties.Columns(1).Caption = "Status"
            CtrlCombo.Properties.Columns(2).Visible = False
            CtrlCombo.Properties.Columns(3).Visible = False
            CtrlCombo.Properties.Columns(4).Visible = False
            CtrlCombo.Properties.Columns(5).Visible = False
            sdr.Close()
        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
    Public Sub DIMENSION(CtrlCombo As DevExpress.XtraEditors.LookUpEdit)
        Try
            Dim cmd As SqlCommand = New SqlCommand("Select id,Name from vw_DIM order by name", CNDB)
            Dim sdr As SqlDataReader = cmd.ExecuteReader()

            CtrlCombo.Properties.DataSource = sdr
            CtrlCombo.Properties.DisplayMember = "Name"
            CtrlCombo.Properties.ValueMember = "id"
            CtrlCombo.Properties.Columns.Clear()
            CtrlCombo.Properties.ForceInitialize()
            CtrlCombo.Properties.PopulateColumns()
            CtrlCombo.Properties.Columns(0).Visible = False
            CtrlCombo.Properties.Columns(1).Caption = "Διάσταση"
            sdr.Close()
        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
    Public Sub VALUELIST(CtrlCombo As DevExpress.XtraEditors.LookUpEdit)
        Try
            Dim cmd As SqlCommand = New SqlCommand("Select id,Name from vw_VALUELIST order by name", CNDB)
            Dim sdr As SqlDataReader = cmd.ExecuteReader()

            CtrlCombo.Properties.DataSource = sdr
            CtrlCombo.Properties.DisplayMember = "Name"
            CtrlCombo.Properties.ValueMember = "id"
            CtrlCombo.Properties.Columns.Clear()
            CtrlCombo.Properties.ForceInitialize()
            CtrlCombo.Properties.PopulateColumns()
            CtrlCombo.Properties.Columns(0).Visible = False
            CtrlCombo.Properties.Columns(1).Caption = "Κατηγορίας Πόρτας"
            sdr.Close()
        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Public Sub REM_VALUES(CtrlCombo As DevExpress.XtraEditors.LookUpEdit)
        Try
            Dim cmd As SqlCommand = New SqlCommand("Select id,Name from vw_REM_VALUES order by code", CNDB)
            Dim sdr As SqlDataReader = cmd.ExecuteReader()

            CtrlCombo.Properties.DataSource = sdr
            CtrlCombo.Properties.DisplayMember = "Name"
            CtrlCombo.Properties.ValueMember = "id"
            CtrlCombo.Properties.Columns.Clear()
            CtrlCombo.Properties.ForceInitialize()
            CtrlCombo.Properties.PopulateColumns()
            CtrlCombo.Properties.Columns(0).Visible = False
            CtrlCombo.Properties.Columns(1).Caption = ""
            sdr.Close()
        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
    Public Sub SRC(CtrlCombo As DevExpress.XtraEditors.LookUpEdit)
        Try
            Dim cmd As SqlCommand = New SqlCommand("Select id,Name from vw_SOURCE order by name", CNDB)
            Dim sdr As SqlDataReader = cmd.ExecuteReader()

            CtrlCombo.Properties.DataSource = sdr
            CtrlCombo.Properties.DisplayMember = "Name"
            CtrlCombo.Properties.ValueMember = "id"
            CtrlCombo.Properties.Columns.Clear()
            CtrlCombo.Properties.ForceInitialize()
            CtrlCombo.Properties.PopulateColumns()
            CtrlCombo.Properties.Columns(0).Visible = False
            CtrlCombo.Properties.Columns(1).Caption = "Πηγές"
            sdr.Close()
        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
    Public Sub INST(CtrlCombo As DevExpress.XtraEditors.LookUpEdit)
        Try
            Dim cmd As SqlCommand = New SqlCommand("Select id,grmonth,cctName,SerName ,SalerName,cmt,cusID,email,transhID,dtDeliverDate from vw_INST     " &
                                                   "UNION " &
                                                   "Select id,null As grmonth,'CRM' As cctName,null As SerName ,null As SalerName,cmt,cusID,null As email,null as transhID,dtDeliverDate from INST where id='00000001-0001-0001-0001-000000000001' order by grmonth,Sername ", CNDB)
            Dim sdr As SqlDataReader = cmd.ExecuteReader()

            CtrlCombo.Properties.DataSource = sdr
            CtrlCombo.Properties.DisplayMember = "cctName"
            CtrlCombo.Properties.ValueMember = "id"
            CtrlCombo.Properties.Columns.Clear()
            CtrlCombo.Properties.ForceInitialize()
            CtrlCombo.Properties.PopulateColumns()
            CtrlCombo.Properties.Columns(0).Visible = False
            CtrlCombo.Properties.Columns(1).Caption = "Μήνας"
            CtrlCombo.Properties.Columns(1).Width = 200
            CtrlCombo.Properties.Columns(2).Visible = True
            CtrlCombo.Properties.Columns(2).Caption = "Πελάτης"
            CtrlCombo.Properties.Columns(2).Width = 300
            CtrlCombo.Properties.Columns(3).Visible = True
            CtrlCombo.Properties.Columns(3).Caption = "Πωλητής"
            CtrlCombo.Properties.Columns(3).Width = 300
            CtrlCombo.Properties.Columns(4).Visible = True
            CtrlCombo.Properties.Columns(4).Caption = "Συνεργείο"
            CtrlCombo.Properties.Columns(4).Width = 300
            CtrlCombo.Properties.Columns(5).Visible = True
            CtrlCombo.Properties.Columns(5).Caption = "Σχόλια"
            CtrlCombo.Properties.Columns(5).Width = 400
            CtrlCombo.Properties.Columns(6).Visible = False
            CtrlCombo.Properties.Columns(7).Visible = False
            CtrlCombo.Properties.Columns(8).Visible = False
            CtrlCombo.Properties.Columns(8).FormatType = DevExpress.Utils.FormatType.DateTime
            CtrlCombo.Properties.Columns(8).FormatString = "dd/MM/yyyy"
            Dim s As Size
            s.Width = 1000 : s.Height = 300
            CtrlCombo.Properties.PopupFormMinSize = s
            sdr.Close()
        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Public Sub SALERS(CtrlCombo As DevExpress.XtraEditors.LookUpEdit)
        Try
            Dim cmd As SqlCommand = New SqlCommand("Select id,Name,color,code,profitPerc from vw_SALERS order by name", CNDB)
            Dim sdr As SqlDataReader = cmd.ExecuteReader()

            CtrlCombo.Properties.DataSource = sdr
            CtrlCombo.Properties.DisplayMember = "Name"
            CtrlCombo.Properties.ValueMember = "id"
            CtrlCombo.Properties.Columns.Clear()
            CtrlCombo.Properties.ForceInitialize()
            CtrlCombo.Properties.PopulateColumns()
            CtrlCombo.Properties.Columns(0).Visible = False
            CtrlCombo.Properties.Columns(1).Caption = "Πωλητές"
            CtrlCombo.Properties.Columns(2).Visible = False
            CtrlCombo.Properties.Columns(3).Visible = False
            CtrlCombo.Properties.Columns(4).Visible = False
            sdr.Close()
        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
    Public Sub COUNTERS(CtrlCombo As DevExpress.XtraEditors.LookUpEdit)
        Try
            Dim cmd As SqlCommand = New SqlCommand("Select id,Name,color,code,profitPerc from vw_COUNTERS order by name", CNDB)
            Dim sdr As SqlDataReader = cmd.ExecuteReader()

            CtrlCombo.Properties.DataSource = sdr
            CtrlCombo.Properties.DisplayMember = "Name"
            CtrlCombo.Properties.ValueMember = "id"
            CtrlCombo.Properties.Columns.Clear()
            CtrlCombo.Properties.ForceInitialize()
            CtrlCombo.Properties.PopulateColumns()
            CtrlCombo.Properties.Columns(0).Visible = False
            CtrlCombo.Properties.Columns(1).Caption = "Επιμετρητές"
            CtrlCombo.Properties.Columns(2).Visible = False
            CtrlCombo.Properties.Columns(3).Visible = False
            CtrlCombo.Properties.Columns(4).Visible = False
            sdr.Close()
        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Public Sub USERS(CtrlCombo As DevExpress.XtraEditors.LookUpEdit)
        Try
            Dim cmd As SqlCommand = New SqlCommand("Select id,RealName from vw_USR", CNDB)
            Dim sdr As SqlDataReader = cmd.ExecuteReader()

            CtrlCombo.Properties.DataSource = sdr
            CtrlCombo.Properties.DisplayMember = "RealName"
            CtrlCombo.Properties.ValueMember = "id"
            CtrlCombo.Properties.Columns.Clear()
            CtrlCombo.Properties.ForceInitialize()
            CtrlCombo.Properties.PopulateColumns()
            CtrlCombo.Properties.Columns(0).Visible = False
            CtrlCombo.Properties.Columns(1).Caption = "Χρήστης"
            sdr.Close()
        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
    Public Sub DOY(CtrlCombo As DevExpress.XtraEditors.LookUpEdit)
        Try
            Dim cmd As SqlCommand = New SqlCommand("Select id,Name from vw_DOY order by name", CNDB)
            Dim sdr As SqlDataReader = cmd.ExecuteReader()

            CtrlCombo.Properties.DataSource = sdr
            CtrlCombo.Properties.DisplayMember = "Name"
            CtrlCombo.Properties.ValueMember = "id"
            CtrlCombo.Properties.Columns.Clear()
            CtrlCombo.Properties.ForceInitialize()
            CtrlCombo.Properties.PopulateColumns()
            CtrlCombo.Properties.Columns(0).Visible = False
            CtrlCombo.Properties.Columns(1).Caption = "ΔΟΥ"
            sdr.Close()
        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
    Public Sub PRF(CtrlCombo As DevExpress.XtraEditors.LookUpEdit)
        Try
            Dim cmd As SqlCommand = New SqlCommand("Select id,Name from vw_PRF order by name", CNDB)
            Dim sdr As SqlDataReader = cmd.ExecuteReader()

            CtrlCombo.Properties.DataSource = sdr
            CtrlCombo.Properties.DisplayMember = "Name"
            CtrlCombo.Properties.ValueMember = "id"
            CtrlCombo.Properties.Columns.Clear()
            CtrlCombo.Properties.ForceInitialize()
            CtrlCombo.Properties.PopulateColumns()
            CtrlCombo.Properties.Columns(0).Visible = False
            CtrlCombo.Properties.Columns(1).Caption = "Επαγγέλματα"
            sdr.Close()
        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
    Public Sub CAT_ERM(CtrlCombo As DevExpress.XtraEditors.LookUpEdit)
        Try
            Dim cmd As SqlCommand = New SqlCommand("Select id,Name from vw_CAT_ERM order by name", CNDB)
            Dim sdr As SqlDataReader = cmd.ExecuteReader()

            CtrlCombo.Properties.DataSource = sdr
            CtrlCombo.Properties.DisplayMember = "Name"
            CtrlCombo.Properties.ValueMember = "id"
            CtrlCombo.Properties.Columns.Clear()
            CtrlCombo.Properties.ForceInitialize()
            CtrlCombo.Properties.PopulateColumns()
            CtrlCombo.Properties.Columns(0).Visible = False
            CtrlCombo.Properties.Columns(1).Caption = "Κατηγορίες Ερμαρίων"
            sdr.Close()
        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
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
            CtrlCombo.Properties.Columns.Clear()
            CtrlCombo.Properties.ForceInitialize()
            CtrlCombo.Properties.PopulateColumns()
            CtrlCombo.Properties.Columns(0).Visible = False
            CtrlCombo.Properties.Columns(1).Caption = "Email Account"
            CtrlCombo.Properties.Columns(2).Caption = "Server"
            sdr.Close()
        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
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
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
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
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
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
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Public Sub FillCheckedListVALUELISTITEMs(CtrlList As DevExpress.XtraEditors.CheckedListBoxControl, ByVal mode As Byte, Optional ByVal sID As String = "")
        Try
            Dim sSQL As String
            If mode = FormMode.NewRecord Then
                sSQL = "Select id,name,price from [vw_VALUELISTITEM]"
            Else
                sSQL = "Select id,name,price,
                       isnull((select case when OM.id is not null then 1 else 0 end as checked
		               from vw_VALUELISTITEM DT where offerid = '" & sID & "' and OM.mechID = M.ID),0) as checked
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
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
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
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
End Class

