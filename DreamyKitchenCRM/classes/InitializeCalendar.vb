Imports System.Data.SqlClient
Imports System.Drawing.Drawing2D
Imports DevExpress.Data.Async
Imports DevExpress.XtraEditors
Imports DevExpress.XtraScheduler


Public Class InitializeCalendar
    Public Sub Initialize(ByVal SCH As DevExpress.XtraScheduler.SchedulerControl, ByVal SCH_Storage As DevExpress.XtraScheduler.SchedulerDataStorage, ByVal sSQL As String, ByVal Reminder As Boolean)
        Dim sDate As String
        Dim sStatus As String
        Dim sReminder As Integer
        Dim sColor As Color
        Dim sStatusColor As Color
        Dim Cmt As String
        Dim SalersCode As Integer
        Dim sCusName As String
        Dim sRemValues As String
        Dim sID As String
        Dim stmReminder As String
        Dim sCompleted As Boolean
        'Color.FromArgb(e.CellValue)
        'Αλλαγή όψης
        SCH.ActiveViewType = SchedulerViewType.FullWeek
        SCH.OptionsCustomization.AllowAppointmentCreate = UsedAppointmentType.None
        SCH.OptionsCustomization.AllowAppointmentDelete = UsedAppointmentType.None
        SCH.OptionsCustomization.AllowAppointmentEdit = UsedAppointmentType.None
        Dim cmd As SqlCommand = New SqlCommand(sSQL, CNDB)
        Dim sdr As SqlDataReader = cmd.ExecuteReader()
        If sdr.HasRows Then
            While sdr.Read()
                If sdr.IsDBNull(sdr.GetOrdinal("dtReminderDate")) = False Then sDate = sdr.GetDateTime(sdr.GetOrdinal("dtReminderDate"))
                If sdr.IsDBNull(sdr.GetOrdinal("tmReminder")) = False Then stmReminder = sdr.GetString(sdr.GetOrdinal("tmReminder"))
                sCusName = sdr.GetString(sdr.GetOrdinal("Fullname"))
                sID = sdr.GetGuid(sdr.GetOrdinal("ID")).ToString
                If sdr.IsDBNull(sdr.GetOrdinal("sch")) = False Then sReminder = sdr.GetInt32(sdr.GetOrdinal("sch"))
                If sdr.IsDBNull(sdr.GetOrdinal("color")) = False Then sColor = Color.FromArgb(sdr.GetInt32(sdr.GetOrdinal("color")))
                'Εαν το Status έχει χρώμα τότε υπερτερεί αυτό το χρώμα έναντι του πωλητή
                If sdr.IsDBNull(sdr.GetOrdinal("StatusColor")) = False Then
                    sStatusColor = Color.FromArgb(sdr.GetInt32(sdr.GetOrdinal("StatusColor")))
                    sColor = sStatusColor
                End If
                If sdr.IsDBNull(sdr.GetOrdinal("STATUS_Name")) = False Then sStatus = sdr.GetString(sdr.GetOrdinal("STATUS_Name"))
                If sdr.IsDBNull(sdr.GetOrdinal("REM_VALUES_name")) = False Then sRemValues = sdr.GetString(sdr.GetOrdinal("REM_VALUES_name"))
                If sdr.IsDBNull(sdr.GetOrdinal("cmt")) = False Then Cmt = sdr.GetString(sdr.GetOrdinal("cmt"))
                If sdr.IsDBNull(sdr.GetOrdinal("SALERS_code")) = False Then SalersCode = sdr.GetInt32(sdr.GetOrdinal("SALERS_code"))
                If sdr.IsDBNull(sdr.GetOrdinal("completed")) = False Then sCompleted = sdr.GetBoolean(sdr.GetOrdinal("completed"))
                CreateAppointment(sID, SCH_Storage, sDate, sStatus, sReminder, sColor, Cmt, SalersCode, sCusName, sRemValues, stmReminder, sCompleted, Reminder)
            End While
        End If
        sdr.Close()
        sdr = Nothing
    End Sub
    Public Sub InitializeInst(ByVal SCH As DevExpress.XtraScheduler.SchedulerControl, ByVal SCH_Storage As DevExpress.XtraScheduler.SchedulerDataStorage, ByVal sSQL As String, ByVal Reminder As Boolean)
        Dim sDate As String, sStatus As String, Cmt As String
        Dim sCusName As String, sRemValues As String, sID As String, FTime As String, TTime As String, sSalerName As String
        Dim sReminder As Integer, SalersCode As Integer, SerCode As Integer
        Dim sColor As Color, sStatusColor As Color
        Dim sCompleted As Boolean
        'Color.FromArgb(e.CellValue)
        'Αλλαγή όψης
        SCH.ActiveViewType = SchedulerViewType.Month
        SCH.OptionsCustomization.AllowAppointmentCreate = UsedAppointmentType.None
        SCH.OptionsCustomization.AllowAppointmentDelete = UsedAppointmentType.None
        SCH.OptionsCustomization.AllowAppointmentEdit = UsedAppointmentType.None
        Dim cmd As SqlCommand = New SqlCommand(sSQL, CNDB)
        Dim sdr As SqlDataReader = cmd.ExecuteReader()
        If sdr.HasRows Then
            While sdr.Read()
                If sdr.IsDBNull(sdr.GetOrdinal("dtDeliverDate")) = False Then sDate = sdr.GetDateTime(sdr.GetOrdinal("dtDeliverDate"))
                If sdr.IsDBNull(sdr.GetOrdinal("cctName")) = False Then sCusName = sdr.GetString(sdr.GetOrdinal("cctName"))
                sID = sdr.GetGuid(sdr.GetOrdinal("ID")).ToString
                If sdr.IsDBNull(sdr.GetOrdinal("color")) = False Then sColor = Color.FromArgb(sdr.GetInt32(sdr.GetOrdinal("color")))
                If sdr.IsDBNull(sdr.GetOrdinal("SalerName")) = False Then sSalerName = sdr.GetString(sdr.GetOrdinal("SalerName"))
                If sdr.IsDBNull(sdr.GetOrdinal("SerName")) = False Then sStatus = "Συνεργείο: " & sdr.GetString(sdr.GetOrdinal("SerName"))
                sRemValues = ""
                If sdr.IsDBNull(sdr.GetOrdinal("tmIN")) = False Then FTime = sdr.GetString(sdr.GetOrdinal("tmIN"))
                If sdr.IsDBNull(sdr.GetOrdinal("tmOUT")) = False Then TTime = sdr.GetString(sdr.GetOrdinal("tmOUT"))
                If sdr.IsDBNull(sdr.GetOrdinal("cmt")) = False Then Cmt = sdr.GetString(sdr.GetOrdinal("cmt"))
                If sdr.IsDBNull(sdr.GetOrdinal("code")) = False Then SalersCode = sdr.GetInt32(sdr.GetOrdinal("code"))
                If sdr.IsDBNull(sdr.GetOrdinal("SerCode")) = False Then SerCode = sdr.GetInt32(sdr.GetOrdinal("SerCode"))
                If sdr.IsDBNull(sdr.GetOrdinal("completed")) = False Then sCompleted = sdr.GetBoolean(sdr.GetOrdinal("completed"))
                If sdr.IsDBNull(sdr.GetOrdinal("SalerName")) = False Then sSalerName = sdr.GetString(sdr.GetOrdinal("SalerName"))
                CreateAppointmentInst(sID, SCH_Storage, sDate, sStatus, sReminder, sColor, Cmt, SerCode, sCusName, sRemValues, FTime, sCompleted, sSalerName, Reminder, TTime)
                sCusName = ""
            End While
        End If
        sdr.Close()
        sdr = Nothing
    End Sub
    Public Sub InitializePersonal(ByVal SCH As DevExpress.XtraScheduler.SchedulerControl, ByVal SCH_Storage As DevExpress.XtraScheduler.SchedulerDataStorage, ByVal sSQL As String, ByVal Reminder As Boolean)
        Dim sDate As String, sStatus As String, Cmt As String
        Dim sTitle As String, sRemValues As String, sID As String, stmReminder As String, sSalerName As String
        Dim sReminder As Integer, SalersCode As Integer, status_Code As Integer
        Dim sColor As Color, sStatusColor As Color
        Dim sCompleted As Boolean
        Try
            'Color.FromArgb(e.CellValue)
            'Αλλαγή όψης
            'SCH.ActiveViewType = SchedulerViewType.FullWeek
            SCH.OptionsCustomization.AllowAppointmentCreate = UsedAppointmentType.None
            SCH.OptionsCustomization.AllowAppointmentDelete = UsedAppointmentType.None
            SCH.OptionsCustomization.AllowAppointmentEdit = UsedAppointmentType.None
            Dim cmd As SqlCommand = New SqlCommand(sSQL, CNDB)
            Dim sdr As SqlDataReader = cmd.ExecuteReader()
            If sdr.HasRows Then
                While sdr.Read()
                    If sdr.IsDBNull(sdr.GetOrdinal("dtInsertedDate")) = False Then sDate = sdr.GetDateTime(sdr.GetOrdinal("dtInsertedDate"))
                    sID = sdr.GetGuid(sdr.GetOrdinal("ID")).ToString
                    If sdr.IsDBNull(sdr.GetOrdinal("color")) = False Then sColor = Color.FromArgb(sdr.GetInt32(sdr.GetOrdinal("color")))
                    sRemValues = ""
                    If sdr.IsDBNull(sdr.GetOrdinal("cmt")) = False Then Cmt = sdr.GetString(sdr.GetOrdinal("cmt"))
                    If sdr.IsDBNull(sdr.GetOrdinal("title")) = False Then sTitle = sdr.GetString(sdr.GetOrdinal("title"))
                    If sdr.IsDBNull(sdr.GetOrdinal("code")) = False Then SalersCode = sdr.GetInt32(sdr.GetOrdinal("code"))
                    If sdr.IsDBNull(sdr.GetOrdinal("status_Code")) = False Then status_Code = sdr.GetInt32(sdr.GetOrdinal("status_Code"))
                    If sdr.IsDBNull(sdr.GetOrdinal("completed")) = False Then sCompleted = sdr.GetBoolean(sdr.GetOrdinal("completed"))
                    CreateAppointmentPersonal(sID, SCH_Storage, sDate, sStatus, sReminder, sColor, Cmt, status_Code, sTitle, sRemValues, stmReminder, sCompleted, sSalerName, Reminder)
                End While
            End If
            sdr.Close()
            sdr = Nothing
        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), "Dreamy Kitchen CRM", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub CreateAppointment(ByVal ID As String, ByVal SCH_Storage As DevExpress.XtraScheduler.SchedulerDataStorage,
                                  ByVal AptDate As String, ByVal AptSubject As String, ByVal sReminder As Integer,
                                  ByVal sColor As Color, ByVal Cmt As String, ByVal sLabelID As Integer,
                                  ByVal sCusname As String, ByVal sRemValues As String, ByVal AptTime As String, ByVal Completed As Boolean,
                                   Optional ByVal EnableReminder As Boolean = False
                                  )
        Dim apt As Appointment = SCH_Storage.CreateAppointment(AppointmentType.Normal, CDate(AptDate), CDate(AptDate), AptSubject & "(" & sCusname & ")")
        Try

            Dim Field As New DevExpress.XtraScheduler.Native.CustomField("StatusColor", sColor)
            apt.CustomFields.Add(Field)
            apt.Location = sCusname
            apt.Description = Cmt
            'apt.AllDay = True
            If AptTime <> Nothing Then
                apt.Start = CDate(AptDate) & " " & AptTime
                '2/29/2016 22:00:00
                apt.End = CDate(AptDate) & " " & AptTime
            Else
                apt.Start = CDate(AptDate)
                apt.End = CDate(AptDate)
            End If
            ' Κλειδί
            apt.SetId(ID)
            apt.LabelKey = sLabelID

            'apt.RecurrenceInfo.Type = RecurrenceType.Daily
            'apt.RecurrenceInfo.Periodicity = 2
            'apt.RecurrenceInfo.Start = apt.Start
            'apt.RecurrenceInfo.Range = RecurrenceRange.OccurrenceCount
            'apt.RecurrenceInfo.OccurrenceCount = 5
            'apt.LabelKey = sLabelID

            If EnableReminder Then
                Dim reminder As Reminder = apt.CreateNewReminder()
                reminder.TimeBeforeStart = New TimeSpan(0, sReminder, 0)
                Select Case sRemValues
                    Case "Λεπτά" : reminder.TimeBeforeStart = TimeSpan.FromMinutes(sReminder)
                    Case "Ώρες" : reminder.TimeBeforeStart = TimeSpan.FromHours(sReminder)
                    Case "Μέρες" : reminder.TimeBeforeStart = TimeSpan.FromDays(sReminder)
                    Case "Εβδομάδες" : reminder.TimeBeforeStart = TimeSpan.FromDays(sReminder * 7)
                End Select
                If Completed = False Then
                    If sReminder <> 0 And sRemValues <> "" Then apt.Reminders.Add(reminder)
                End If
            End If
            SCH_Storage.Appointments.Add(apt)


            'Dim lbl = SCH_Storage.Appointments.Labels.CreateNewLabel("vi", "Very Important")
            'lbl.SetColor(sColor)
            'SCH_Storage.Appointments.Labels.Add(lbl)

            'Dim status = SCH_Storage.Appointments.Statuses.CreateNewStatus("vb", "Very Busy")
            'status.SetBrush(New HatchBrush(HatchStyle.ForwardDiagonal, sColor, sColor))
            'SCH_Storage.Appointments.Statuses.Add(status)

            'apt.StatusKey = "vb"
            'apt.LabelKey = "vi"
        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), "Dreamy Kitchen CRM", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Public Sub CreateAppointmentInst(ByVal ID As String, ByVal SCH_Storage As DevExpress.XtraScheduler.SchedulerDataStorage,
                                      ByVal AptDate As String, ByVal AptSubject As String, ByVal sReminder As Integer,
                                      ByVal sColor As Color, ByVal Cmt As String, ByVal sLabelID As Integer,
                                      ByVal sCusname As String, ByVal sRemValues As String, ByVal FTime As String, ByVal Completed As Boolean,
                                       ByVal SalerName As String, Optional ByVal EnableReminder As Boolean = False, Optional ByVal TTime As String = ""
                                      )
        Dim apt As Appointment = SCH_Storage.CreateAppointment(AppointmentType.Normal, CDate(AptDate), CDate(AptDate),
                                                               "Πελάτης: " & sCusname & vbCrLf & AptSubject & vbCrLf)
        Try

            Dim Field As New DevExpress.XtraScheduler.Native.CustomField("StatusColor", sColor)

            '   apt.CustomFields.Add(Field)
            'apt.Location = SalerName
            'apt.Description = Cmt

            'apt.AllDay = True
            If FTime <> "" Then
                apt.Start = CDate(AptDate) & " " & FTime
                '2/29/2016 22:00:00
                apt.End = CDate(AptDate) & " " & TTime
            Else
                apt.Start = CDate(AptDate)
                apt.End = CDate(AptDate)
            End If
            ' Κλειδί
            apt.SetId(ID)
            apt.LabelKey = sLabelID

            'apt.RecurrenceInfo.Type = RecurrenceType.Daily
            'apt.RecurrenceInfo.Periodicity = 2
            'apt.RecurrenceInfo.Start = apt.Start
            'apt.RecurrenceInfo.Range = RecurrenceRange.OccurrenceCount
            'apt.RecurrenceInfo.OccurrenceCount = 5
            'apt.LabelKey = sLabelID

            If EnableReminder Then
                Dim reminder As Reminder = apt.CreateNewReminder()
                reminder.TimeBeforeStart = New TimeSpan(0, sReminder, 0)
                Select Case sRemValues
                    Case "Λεπτά" : reminder.TimeBeforeStart = TimeSpan.FromMinutes(sReminder)
                    Case "Ώρες" : reminder.TimeBeforeStart = TimeSpan.FromHours(sReminder)
                    Case "Μέρες" : reminder.TimeBeforeStart = TimeSpan.FromDays(sReminder)
                    Case "Εβδομάδες" : reminder.TimeBeforeStart = TimeSpan.FromDays(sReminder * 7)
                End Select
                If Completed = False Then
                    If sReminder <> 0 And sRemValues <> "" Then apt.Reminders.Add(reminder)
                End If
            End If
            SCH_Storage.Appointments.Add(apt)


            'Dim lbl = SCH_Storage.Appointments.Labels.CreateNewLabel("vi", "Very Important")
            'lbl.SetColor(sColor)
            'SCH_Storage.Appointments.Labels.Add(lbl)

            'Dim status = SCH_Storage.Appointments.Statuses.CreateNewStatus("vb", "Very Busy")
            'status.SetBrush(New HatchBrush(HatchStyle.ForwardDiagonal, sColor, sColor))
            'SCH_Storage.Appointments.Statuses.Add(status)

            'apt.StatusKey = "vb"
            'apt.LabelKey = "vi"
        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), "Dreamy Kitchen CRM", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Public Sub CreateAppointmentPersonal(ByVal ID As String, ByVal SCH_Storage As DevExpress.XtraScheduler.SchedulerDataStorage,
                                      ByVal AptDate As String, ByVal AptSubject As String, ByVal sReminder As Integer,
                                      ByVal sColor As Color, ByVal Cmt As String, ByVal sLabelID As Integer,
                                      ByVal sTitle As String, ByVal sRemValues As String, ByVal AptTime As String, ByVal Completed As Boolean,
                                       ByVal SalerName As String, Optional ByVal EnableReminder As Boolean = False
                                      )
        Dim apt As Appointment = SCH_Storage.CreateAppointment(AppointmentType.Normal, CDate(AptDate), CDate(AptDate), AptSubject & "(Θέμα: " & sTitle & ")")
        Try

            'Dim Field As New DevExpress.XtraScheduler.Native.CustomField("StatusColor", sColor)

            'apt.CustomFields.Add(Field)
            'apt.Location = sTitle
            apt.Description = Cmt

            apt.AllDay = True
            'If AptTime <> Nothing Then
            '    apt.Start = CDate(AptDate) & " " & AptTime
            '    '2/29/2016 22:00:00
            '    apt.End = CDate(AptDate) & " " & AptTime
            'Else
            '    apt.Start = CDate(AptDate)
            '    apt.End = CDate(AptDate)
            'End If
            ' Κλειδί
            apt.SetId(ID)
            apt.LabelKey = sLabelID

            'If EnableReminder Then
            '    Dim reminder As Reminder = apt.CreateNewReminder()
            '    reminder.TimeBeforeStart = New TimeSpan(0, sReminder, 0)
            '    Select Case sRemValues
            '        Case "Λεπτά" : reminder.TimeBeforeStart = TimeSpan.FromMinutes(sReminder)
            '        Case "Ώρες" : reminder.TimeBeforeStart = TimeSpan.FromHours(sReminder)
            '        Case "Μέρες" : reminder.TimeBeforeStart = TimeSpan.FromDays(sReminder)
            '        Case "Εβδομάδες" : reminder.TimeBeforeStart = TimeSpan.FromDays(sReminder * 7)
            '    End Select
            '    If Completed = False Then
            '        If sReminder <> 0 And sRemValues <> "" Then apt.Reminders.Add(reminder)
            '    End If
            'End If
            SCH_Storage.Appointments.Add(apt)


        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), "Dreamy Kitchen CRM", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Class
