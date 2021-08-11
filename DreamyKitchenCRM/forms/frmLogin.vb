
Imports System.Data.SqlClient
Imports DevExpress.XtraEditors

Public Class frmLogin
    Private UserPermissions As New CheckPermissions
    Private Prog_Prop As New ProgProp
    Private CheckFUpdate As New CheckForUpdates
    Private FillCbo As New FillCombos
    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim CN As New CN
        'My.Settings.Upgrade()
        'My.Settings.Save()
        'MultipleActiveResultSets=True
        chkRememberUN.EditValue = My.Settings.UNSave
        If CNDB.ConnectionString.ToString = "" Then
            If CN.OpenConnection = False Then XtraMessageBox.Show("Παρουσιάστηκε πρόβλημα κατά την σύνδεση στο Dreamy Kitchen CRM", "Dreamy Kitchen CRM", MessageBoxButtons.OK, MessageBoxIcon.Error)

            'Έλεγχος νέας έκδοσης
            If CheckFUpdate.FindNewVersion Then

            End If
        End If
        FillCbo.USR(txtUN)
        If My.Settings.UNSave = True Then txtUN.EditValue = System.Guid.Parse(My.Settings.UN.ToString)
        If Debugger.IsAttached Then
            txtUN.EditValue = System.Guid.Parse("3f9dc32e-be5b-4d46-a13c-ea606566cf32")
            txtPWD.Text = "2017"
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

            sSQL = "select Realname,code,ID,M_UN,M_pwd,server,port,ssl,salerID from vw_USR 
                where UN= '" & txtUN.Text & "' and pwd = '" & txtPWD.Text & "'"
            cmd = New SqlCommand(sSQL, CNDB)
            sdr = cmd.ExecuteReader()
            If (sdr.Read() = True) Then
                If sdr.IsDBNull(sdr.GetOrdinal("Realname")) = False Then
                    UserProps.Code = sdr.GetInt32(sdr.GetOrdinal("code"))
                    UserProps.RealName = sdr.GetString(sdr.GetOrdinal("Realname"))
                    UserProps.ID = sdr.GetGuid(sdr.GetOrdinal("ID"))
                    If sdr.IsDBNull(sdr.GetOrdinal("salerID")) = False Then UserProps.SalerID = sdr.GetGuid(sdr.GetOrdinal("salerID"))
                    If sdr.IsDBNull(sdr.GetOrdinal("ID")) = False Then UserProps.ID = sdr.GetGuid(sdr.GetOrdinal("ID"))
                    If sdr.IsDBNull(sdr.GetOrdinal("M_un")) = False Then UserProps.Email = sdr.GetString(sdr.GetOrdinal("M_un"))
                    If sdr.IsDBNull(sdr.GetOrdinal("server")) = False Then UserProps.EmailServer = sdr.GetString(sdr.GetOrdinal("server"))
                    If sdr.IsDBNull(sdr.GetOrdinal("M_pwd")) = False Then UserProps.EmailPassword = sdr.GetString(sdr.GetOrdinal("M_pwd"))
                    If sdr.IsDBNull(sdr.GetOrdinal("port")) = False Then UserProps.EmailPort = sdr.GetInt32(sdr.GetOrdinal("port"))
                    If sdr.IsDBNull(sdr.GetOrdinal("ssl")) = False Then UserProps.EmailSSL = sdr.GetBoolean(sdr.GetOrdinal("ssl"))
                    'Support Email
                    ProgProps.SupportEmail = "johnmavroselinos@gmail.com" 'Prog_Prop.GetProgTechSupportEmail

                    'General Permissions
                    UserPermissions.GetUserPermissions()
                    sSQL = "UPDATE USR SET dtLogin = getdate()  where ID = " & toSQLValueS(UserProps.ID.ToString)
                    cmd = New SqlCommand(sSQL, CNDB) : cmd.ExecuteNonQuery()
                    'Δεκαδικά Προγράμματος
                    Prog_Prop.GetProgDecimals()
                    XtraMessageBox.Show("Καλως ήρθατε στο Dreamy Kitchen CRM " & UserProps.RealName, "Dreamy Kitchen CRM", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    If chkRememberUN.EditValue = True Then
                        My.Settings.UNSave = True
                        My.Settings.UN = txtUN.EditValue
                        My.Settings.UN = txtUN.EditValue
                        My.Settings.Save()
                    End If
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
            My.Settings.UN = System.Guid.Parse("00000000-0000-0000-0000-000000000000")
            My.Settings.Save()
        End If
    End Sub

    Private Sub cmdConnect_Click(sender As Object, e As EventArgs) Handles cmdConnect.Click
        frmDBConnection.Show()
        Me.Close()
    End Sub
End Class