
Imports System.Data.SqlClient
Imports DevExpress.XtraEditors

Public Class frmLogin
    Private UserPermissions As New CheckPermissions
    Private Prog_Prop As New ProgProp
    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim CN As New CN

        'MultipleActiveResultSets=True
        chkRememberUN.EditValue = My.Settings.UNSave
        If My.Settings.UNSave = True Then txtUN.Text = My.Settings.UN
        If CN.OpenConnection = False Then XtraMessageBox.Show("Παρουσιάστηκε πρόβλημα κατά την σύνδεση στο Dreamy Kitchen CRM", "Dreamy Kitchen CRM", MessageBoxButtons.OK, MessageBoxIcon.Error)

        If Debugger.IsAttached Then
            txtUN.Text = "blackmoon"
            txtPWD.Text = "mavros1!"
            cmdLogin.Select()
        Else
            ' Assume we aren't running from the IDE
        End If
    End Sub

    Private Sub cmdLogin_Click(sender As Object, e As EventArgs) Handles cmdLogin.Click
        Dim sSQL As String
        Dim cmd As SqlCommand
        Dim sdr As SqlDataReader
        Try

            sSQL = "select Realname,code,ID,salerID from USR 
                where UN= '" & txtUN.Text & "' and pwd = '" & txtPWD.Text & "'"
            cmd = New SqlCommand(sSQL, CNDB)
            sdr = cmd.ExecuteReader()
            If (sdr.Read() = True) Then
                If sdr.IsDBNull(sdr.GetOrdinal("Realname")) = False Then
                    UserProps.Code = sdr.GetInt32(sdr.GetOrdinal("code"))
                    UserProps.RealName = sdr.GetString(sdr.GetOrdinal("Realname"))
                    UserProps.ID = sdr.GetGuid(sdr.GetOrdinal("ID"))
                    If sdr.IsDBNull(sdr.GetOrdinal("salerID")) = False Then UserProps.SalerID = sdr.GetGuid(sdr.GetOrdinal("salerID"))
                    'General Permissions
                    UserPermissions.GetUserPermissions()
                    sSQL = "UPDATE USR SET dtLogin = getdate() where ID = " & toSQLValueS(UserProps.ID.ToString)
                    cmd = New SqlCommand(sSQL, CNDB) : cmd.ExecuteNonQuery()
                        'Δεκαδικά Προγράμματος
                        Prog_Prop.GetProgDecimals()
                        XtraMessageBox.Show("Καλως ήρθατε στο Dreamy Kitchen CRM " & UserProps.RealName, "Dreamy Kitchen CRM", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        If My.Settings.UNSave = True Then My.Settings.UN = txtUN.Text : My.Settings.Save()
                    End If
                    frmMain.Show()
                Me.Close()
                frmCalendar.MdiParent = frmMain
                frmCalendar.Text = "Ημερολόγιο Κινήσεων"
                frmCalendar.Show()

            Else
                XtraMessageBox.Show("Πληκτρολογήσατε λάθος στοιχεία. Παρακαλώ προσπαθήστε ξανά.", "Dreamy Kitchen CRM", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            sdr.Close()
        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), "Dreamy Kitchen CRM", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub txtUN_KeyDown(sender As Object, e As KeyEventArgs) Handles txtUN.KeyDown
        If e.KeyCode = Keys.Enter Then txtPWD.Select()
    End Sub

    Private Sub txtPWD_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPWD.KeyDown
        If e.KeyCode = Keys.Enter Then cmdLogin.Select()
    End Sub

    Private Sub chkRememberUN_CheckedChanged(sender As Object, e As EventArgs) Handles chkRememberUN.CheckedChanged
        My.Settings.UNSave = chkRememberUN.EditValue
        If My.Settings.UNSave = False Then
            My.Settings.UN = ""
            My.Settings.Save()
        End If
    End Sub

End Class