Imports System.Net.Mail
Imports System.Data.SqlClient
Imports DevExpress.XtraEditors
Imports DevExpress.DataAccess

Public Class SendEmail
    Private EmailUserName As String
    Private EmailPassword As String
    Private EmailPort As Integer
    Private EmailSSL As Boolean
    Private EmailServer As String
    Public Function SendEmail(ByVal EmailAccount As String, ByVal Subject As String, ByVal Body As String, ByVal sToEmail As String, ByVal sFile As String, ByRef statusMsg As String) As Boolean
        Try
            Dim Smtp_Server As New SmtpClient
            Dim e_mail As New MailMessage()
            Smtp_Server.UseDefaultCredentials = False
            getEmailProperties(EmailAccount)
            If EmailServer = "" Then
                XtraMessageBox.Show("Δημιουργήθηκε πρόβλημα κατά την ανάγνωση των ρυθμίσεων του Email " & EmailAccount, "Dreamy Kitchen CRM", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            End If
            Smtp_Server.Credentials = New System.Net.NetworkCredential(EmailUserName, EmailPassword)

            Smtp_Server.Port = EmailPort
            Smtp_Server.EnableSsl = EmailSSL
            Smtp_Server.Host = EmailServer

            e_mail = New MailMessage()
            e_mail.From = New MailAddress(EmailUserName)
            Dim parts As String() = sToEmail.Split(";")

            ' Loop through result strings with For Each.
            'e_mail.To.Add("johnmavroselinos@gmail.com")
            For Each part As String In parts
                If part.Length > 0 Then e_mail.To.Add(part)
            Next

            'If txtCC.Text <> "" Then e_mail.CC.Add(txtCC.Text)
            e_mail.Subject = Subject
            e_mail.IsBodyHtml = True
            Body.Replace("\n", "<br />")
            e_mail.Body = Body
            e_mail.Headers.Add("Disposition-Notification-To", EmailAccount)

            e_mail.DeliveryNotificationOptions = DeliveryNotificationOptions.OnSuccess
            Dim myMailHTMLBody = "<html><head></head><body>" & Body & " </body></html>"
            If System.IO.File.Exists(sFile) Then
                Dim data As System.Net.Mail.Attachment = New System.Net.Mail.Attachment(sFile)
                e_mail.Attachments.Add(data)
                Smtp_Server.Send(e_mail)
            Else
                statusMsg = "Δεν βρέθηκε το αρχείο " & sFile
                'XtraMessageBox.Show("Δεν βρέθηκε το αρχείο " & sFile, ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            End If
            e_mail.Dispose()
            Smtp_Server.Dispose()
            statusMsg = "Email Sent Successfully"
            Return True
        Catch ex As Exception
            statusMsg = String.Format("Error: {0}", ex.Message)
            'XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function
    Private Sub getEmailProperties(ByVal EmailAccount As String)
        Dim cmd As SqlCommand
        Dim sdr As SqlDataReader
        Try
            Dim sSQL As String = "select * FROM MAILS where ID= " & toSQLValueS(EmailAccount)
            cmd = New SqlCommand(sSQL, CNDB)
            sdr = cmd.ExecuteReader()
            If (sdr.Read() = True) Then
                EmailUserName = sdr.GetString(sdr.GetOrdinal("un"))
                EmailPassword = sdr.GetString(sdr.GetOrdinal("pwd"))
                EmailPort = sdr.GetInt32(sdr.GetOrdinal("port"))
                EmailSSL = sdr.GetBoolean(sdr.GetOrdinal("ssl"))
                EmailServer = sdr.GetString(sdr.GetOrdinal("server"))
            End If
            sdr.Close()
            sdr = Nothing
        Catch ex As Exception
            sdr.Close()
            sdr = Nothing
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Class