﻿Imports System.Data.SqlClient
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
    Public Sub MAIL(CtrlCombo As DevExpress.XtraEditors.LookUpEdit)
        Try
            Dim ds As DataSet = New DataSet
            Dim cmd As SqlCommand = New SqlCommand("Select id,Server from vw_MAILS", CNDB)
            Dim sdr As SqlDataReader = cmd.ExecuteReader()

            CtrlCombo.Properties.DataSource = sdr
            CtrlCombo.Properties.DisplayMember = "Server"
            CtrlCombo.Properties.ValueMember = "id"
            CtrlCombo.Properties.PopulateColumns()
            CtrlCombo.Properties.Columns(0).Visible = False
            CtrlCombo.Properties.Columns(1).Caption = "Email Account"
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

End Class
