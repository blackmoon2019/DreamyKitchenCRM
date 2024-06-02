Imports System.Data.SqlClient
Imports DevExpress.XtraEditors

Public Class CheckPermissions
    Public Sub GetUserPermissions()
        'ByVal frm As DevExpress.XtraEditors.XtraForm
        Dim sSQL As String
        Dim cmd As SqlCommand
        Dim sdr As SqlDataReader
        Try
            sSQL = "select [DELETE],[INSERT],[EDIT],[VIEW] from RIGHTS  where UID= '" & UserProps.ID.ToString & "'"
            cmd = New SqlCommand(sSQL, CNDB)
            sdr = cmd.ExecuteReader()
            If (sdr.Read() = True) Then
                UserProps.AllowView = sdr.GetBoolean(sdr.GetOrdinal("VIEW"))
                UserProps.AllowDelete = sdr.GetBoolean(sdr.GetOrdinal("DELETE"))
                UserProps.AllowEdit = sdr.GetBoolean(sdr.GetOrdinal("EDIT"))
                UserProps.AllowInsert = sdr.GetBoolean(sdr.GetOrdinal("INSERT"))

            End If

        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Public Function CheckViewPermission(ByVal FormName As String) As Boolean
        Dim sSQL As String
        Dim cmd As SqlCommand
        Dim sdr As SqlDataReader
        Try
            'Blackmoon user
            If UserProps.ID.ToString.ToUpper = "E9CEFD11-47C0-4796-A46B-BC41C4C3606B" Then Return True
            sSQL = "select [view] from vw_FORMS F
                    inner join vw_FORM_RIGHTS  FR on F.ID = FR.F_ID 
                    inner join vw_RIGHTS R on R.ID=FR.Rid 
                    where f.name= " & toSQLValueS(FormName) &
                    " and uid = " & toSQLValueS(UserProps.ID.ToString)

            cmd = New SqlCommand(sSQL, CNDB)
            sdr = cmd.ExecuteReader()
            If (sdr.Read() = True) Then Return sdr.GetBoolean(sdr.GetOrdinal("VIEW")) Else Return False


        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Function


End Class
