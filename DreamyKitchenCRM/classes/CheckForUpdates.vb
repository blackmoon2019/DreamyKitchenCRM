﻿Imports System.Data.SqlClient
Imports DevExpress.XtraEditors

Public Class CheckForUpdates
    Public Function FindNewVersion() As Boolean
        Dim sSQL As String
        Dim cmd As SqlCommand
        Dim sdr As SqlDataReader
        Dim sExeVer As String, sDbVer As String
        Dim UpdatePath As String
        Try
            '------Arguments--------
            '1 Current Version
            '2 Server Update Path
            '3 Server Application Path
            '4 Version To be Updated

            sSQL = "select * from VER"
            cmd = New SqlCommand(sSQL, CNDB)
            sdr = cmd.ExecuteReader()
            If (sdr.Read() = True) Then
                If sdr.IsDBNull(sdr.GetOrdinal("ExeVer")) = True Then
                    Return False
                Else

                    If sdr.IsDBNull(sdr.GetOrdinal("ExeVer")) = False Then sExeVer = sdr.GetString(sdr.GetOrdinal("ExeVer"))
                    If sdr.IsDBNull(sdr.GetOrdinal("DbVer")) = False Then sDbVer = sdr.GetString(sdr.GetOrdinal("DbVer"))
                    If sdr.IsDBNull(sdr.GetOrdinal("UpdatePath")) = False Then UpdatePath = sdr.GetString(sdr.GetOrdinal("UpdatePath"))
                    'If My.Settings.UNSave = True Then My.Settings.UN = txtUN.Text : My.Settings.Save()

                    If My.Application.Info.Version.ToString <> sExeVer Then
                        XtraMessageBox.Show("Βρέθηκε νέα έκδοση του προγράμματος " & sExeVer & "." & vbCrLf &
                                            "Θα πραγματοποιηθεί έξοδος του προγράμματος και έναρξη της αναβάθμισης", "Dreamy Kitchen CRM", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        sdr.Close()
                        ' Shell(Application.StartupPath & "\Updater\PriamosUpdate.exe")
                        Dim pHelp As New ProcessStartInfo
                        pHelp.WorkingDirectory = Application.StartupPath & "\Updater"
                        pHelp.FileName = "DreamyKitchenUpdater.exe"
                        pHelp.Arguments = My.Settings.ExeVer & "," & UpdatePath & "," & Application.StartupPath & "," & sExeVer
                        pHelp.UseShellExecute = True
                        pHelp.WindowStyle = ProcessWindowStyle.Normal
                        Dim proc As Process = Process.Start(pHelp)
                        End
                    Else
                        My.Settings.ExeVer = sExeVer
                        My.Settings.DbVer = sExeVer
                    End If
                End If
            End If
            sdr.Close()
        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), "Dreamy Kitchen CRM", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Return False
    End Function
End Class

