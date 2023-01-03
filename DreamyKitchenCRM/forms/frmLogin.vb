
Imports System.Data.SqlClient
Imports DevExpress.XtraEditors

Public Class frmLogin
    Private UserPermissions As New CheckPermissions
    Private Prog_Prop As New ProgProp
    Private CheckFUpdate As New CheckForUpdates
    Private FillCbo As New FillCombos
    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim CN As New CN
        'MultipleActiveResultSets=True
        ProgProps.ProgTitle = "DreamyKitchenCRM"
        UserProps.UNSave = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\DreamyKitchen", "UNSave", "2")
        If UserProps.UNSave Is Nothing Then UserProps.UNSave = 2
        chkRememberUN.Checked = UserProps.UNSave
        If CNDB.ConnectionString.ToString = "" Then
            If CN.OpenConnection = False Then XtraMessageBox.Show("Παρουσιάστηκε πρόβλημα κατά την σύνδεση στο Dreamy Kitchen CRM", "Dreamy Kitchen CRM", MessageBoxButtons.OK, MessageBoxIcon.Error)

            'Έλεγχος νέας έκδοσης
            If CheckFUpdate.FindNewVersion Then

            End If
        End If
        FillCbo.USR(cboUN)
        UserProps.UN = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\DreamyKitchen", "UN", System.Guid.Empty.ToString)
        If UserProps.UNSave = "1" Then cboUN.EditValue = System.Guid.Parse(UserProps.UN)
        If Debugger.IsAttached Then
            cboUN.EditValue = System.Guid.Parse("E9CEFD11-47C0-4796-A46B-BC41C4C3606B")
            txtPWD.Text = "1"
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

            sSQL = "select Realname,code,ID,M_UN,M_pwd,server,port,ssl,empID from vw_USR 
                where UN= '" & cboUN.Text & "' and pwd = '" & txtPWD.Text & "'"
            cmd = New SqlCommand(sSQL, CNDB)
            sdr = cmd.ExecuteReader()
            If (sdr.Read() = True) Then
                If sdr.IsDBNull(sdr.GetOrdinal("Realname")) = False Then
                    UserProps.Code = sdr.GetInt32(sdr.GetOrdinal("code"))
                    UserProps.RealName = sdr.GetString(sdr.GetOrdinal("Realname"))
                    UserProps.ID = sdr.GetGuid(sdr.GetOrdinal("ID"))
                    If sdr.IsDBNull(sdr.GetOrdinal("empID")) = False Then UserProps.EmpID = sdr.GetGuid(sdr.GetOrdinal("empID"))
                    If sdr.IsDBNull(sdr.GetOrdinal("ID")) = False Then UserProps.ID = sdr.GetGuid(sdr.GetOrdinal("ID"))
                    If sdr.IsDBNull(sdr.GetOrdinal("M_un")) = False Then UserProps.Email = sdr.GetString(sdr.GetOrdinal("M_un"))
                    If sdr.IsDBNull(sdr.GetOrdinal("server")) = False Then UserProps.EmailServer = sdr.GetString(sdr.GetOrdinal("server"))
                    If sdr.IsDBNull(sdr.GetOrdinal("M_pwd")) = False Then UserProps.EmailPassword = sdr.GetString(sdr.GetOrdinal("M_pwd"))
                    If sdr.IsDBNull(sdr.GetOrdinal("port")) = False Then UserProps.EmailPort = sdr.GetInt32(sdr.GetOrdinal("port"))
                    If sdr.IsDBNull(sdr.GetOrdinal("ssl")) = False Then UserProps.EmailSSL = sdr.GetBoolean(sdr.GetOrdinal("ssl"))
                    sdr.Close()
                    cmd.Dispose()
                    'General Permissions
                    UserPermissions.GetUserPermissions()
                    sSQL = "UPDATE USR SET dtLogin = getdate()  where ID = " & toSQLValueS(UserProps.ID.ToString)
                    cmd = New SqlCommand(sSQL, CNDB) : cmd.ExecuteNonQuery()
                    cmd.Dispose()
                    'Support Email
                    Prog_Prop.GetProgTechSupportEmail()
                    'Δεκαδικά Προγράμματος
                    Prog_Prop.GetProgDecimals()
                    'ΦΠΑ Προγράμματος
                    Prog_Prop.GetProgvat()

                    'Δημιουργία Κλειδιών

                    If Microsoft.Win32.Registry.CurrentUser.OpenSubKey("SOFTWARE\\DreamyKitchen") Is Nothing Then My.Computer.Registry.CurrentUser.CreateSubKey("SOFTWARE\\DreamyKitchen")
                    ProgProps.ServerViewsPath = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\DreamyKitchen", "SERVERVIEWS", "")
                    ProgProps.ServerPath = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\DreamyKitchen", "SERVER_PATH", "")
                    ProgProps.Records = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\DreamyKitchen", "Records", 0)
                    UserProps.UNSave = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\DreamyKitchen", "UNSave", "2")

                    If ProgProps.ServerPath = "" Then My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\DreamyKitchen", "SERVER_PATH", "\\10.10.5.7\TempCrm\")
                    If ProgProps.ServerViewsPath = "" Then My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\DreamyKitchen", "SERVERVIEWS", "\\10.10.5.7\CrmViews\")
                    If ProgProps.Records = 0 Then My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\DreamyKitchen", "Records", "1000")
                    If chkRememberUN.CheckState = CheckState.Checked Then
                        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\DreamyKitchen", "UNSave", "1")
                    Else
                        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\DreamyKitchen", "UNSave", "0")
                    End If

                    My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\DreamyKitchen", "UN", cboUN.EditValue.ToString) : UserProps.UN = cboUN.EditValue.ToString



                    'Διαδρομή TEMP FOLDER για ανοιγμα αρχείων
                    If My.Computer.FileSystem.DirectoryExists(Application.StartupPath & "\TEMP\") = False Then My.Computer.FileSystem.CreateDirectory(Application.StartupPath & "\TEMP\")
                    If My.Computer.FileSystem.DirectoryExists(Application.StartupPath & "\TEMP\Pictures") = False Then My.Computer.FileSystem.CreateDirectory(Application.StartupPath & "\TEMP\Pictures")
                    ProgProps.TempFolderPath = Application.StartupPath & "\TEMP\"
                    ProgProps.TempPicturesFolderPath = Application.StartupPath & "\TEMP\Pictures\"
                    XtraMessageBox.Show("Καλως ήρθατε στο Dreamy Kitchen CRM " & UserProps.RealName, "Dreamy Kitchen CRM", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
                frmMain.Show()
                Me.Close()
                frmCalendar.MdiParent = frmMain
                frmCalendar.Text = "Ημερολόγιο Κινήσεων"
                frmCalendar.Show()
                'frmEpopteiaChart.Show()

            Else
                XtraMessageBox.Show("Πληκτρολογήσατε λάθος στοιχεία. Παρακαλώ προσπαθήστε ξανά.", "Dreamy Kitchen CRM", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            sdr.Close()
        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), "Dreamy Kitchen CRM", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub txtUN_KeyDown(sender As Object, e As KeyEventArgs) Handles cboUN.KeyDown
        If e.KeyCode = Keys.Enter Then txtPWD.Select()
    End Sub

    Private Sub txtPWD_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPWD.KeyDown
        If e.KeyCode = Keys.Enter Then cmdLogin.Select()
    End Sub

    Private Sub chkRememberUN_CheckedChanged(sender As Object, e As EventArgs) Handles chkRememberUN.CheckedChanged
        If chkRememberUN.Checked = False Then
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\DreamyKitchen", "UNSave", "0")
            UserProps.UNSave = "0"
        Else
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\DreamyKitchen", "UNSave", "1")
            UserProps.UNSave = "1"
        End If
    End Sub

    Private Sub cmdConnect_Click(sender As Object, e As EventArgs) Handles cmdConnect.Click
        frmDBConnection.Show()
        Me.Close()
    End Sub
End Class