Imports MarkupConverter.RtfToHtmlConverter
Imports System.Net.Mail
Imports System.Data.SqlClient
Imports DevExpress.XtraEditors
Imports DevExpress.DataAccess
Imports System.IO
Imports System.Text
Imports DevExpress.DataAccess.Native

Public Class SendEmail
    Private EmailUserName As String
    Private EmailPassword As String
    Private EmailPort As Integer
    Private EmailSSL As Boolean
    Private EmailServer As String
    Public Function SendEmail(ByVal EmailAccount As String, ByVal Subject As String, ByVal Body As String, ByVal sToEmail As String, ByVal sAttachment As String, ByRef statusMsg As String, Optional ByVal GetAttachmentsFromTable As Dictionary(Of String, String) = Nothing) As Boolean
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
            e_mail.IsBodyHtml = False
            'Body.Replace("\n", "<br />")
            e_mail.Body = Body
            e_mail.Headers.Add("Disposition-Notification-To", EmailAccount)

            e_mail.DeliveryNotificationOptions = DeliveryNotificationOptions.OnSuccess
            Dim myMailHTMLBody = "<html><head></head><body>" & Body & " </body></html>"
            If sAttachment <> "" Then
                If System.IO.File.Exists(sAttachment) Then
                    Dim data As System.Net.Mail.Attachment = New System.Net.Mail.Attachment(sAttachment)
                    e_mail.Attachments.Add(data)
                    Smtp_Server.Send(e_mail)
                Else
                    statusMsg = "Δεν βρέθηκε το αρχείο " & sAttachment
                    'XtraMessageBox.Show("Δεν βρέθηκε το αρχείο " & sFile, ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return False
                End If
            ElseIf GetAttachmentsFromTable IsNot Nothing Then
                Dim sSQL As String = "select files,filename FROM " & GetAttachmentsFromTable.Values(0).ToString & "  where supOrderID = " & toSQLValueS(GetAttachmentsFromTable.Keys(0).ToString)
                Dim cmd As SqlCommand
                Dim sdr As SqlDataReader
                cmd = New SqlCommand(sSQL, CNDB)
                sdr = cmd.ExecuteReader()
                Dim vAttachment As Byte()
                While sdr.Read()
                    vAttachment = sdr.GetSqlBinary(sdr.GetOrdinal("files"))
                    Dim ContentStream As New MemoryStream(vAttachment)
                    Dim data As System.Net.Mail.Attachment = New System.Net.Mail.Attachment(ContentStream, sdr.GetString(sdr.GetOrdinal("filename")))
                    e_mail.Attachments.Add(data)
                End While
                Smtp_Server.Send(e_mail)
            Else
                Smtp_Server.Send(e_mail)
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
            Dim sSQL As String = "select * FROM MAILS where un= " & toSQLValueS(EmailAccount)
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