Imports System.Data.SqlClient
Imports DevExpress.XtraEditors
Imports DevExpress.XtraLayout

Public Class ProgProp
    Public Function GetProgTechSupportEmail() As String
        Dim sSQL As String
        Dim cmd As SqlCommand
        Dim sdr As SqlDataReader
        Try
            sSQL = "select val FROM PRM where prm= 'SUPPORT_EMAIL'"
            cmd = New SqlCommand(sSQL, CNDB)
            sdr = cmd.ExecuteReader()
            If (sdr.Read() = True) Then ProgProps.SupportEmail = sdr.GetString(sdr.GetOrdinal("VAL"))
            Return ProgProps.SupportEmail
        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), "PRIAMOS .NET", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Function
    Public Sub SetProgDecimals(ByVal sValue As Integer)
        Dim sSQL As String
        Dim cmd As SqlCommand
        Try
            sSQL = "Update PRM set val = '" & sValue & "' where prm= 'DECIMAL_PLACES'"
            cmd = New SqlCommand(sSQL, CNDB) : cmd.ExecuteNonQuery()
        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), "PRIAMOS .NET", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
    Public Function GetProgDecimals() As Integer
        Dim sSQL As String
        Dim cmd As SqlCommand
        Dim sdr As SqlDataReader
        Try
            sSQL = "select val FROM PRM where prm= 'DECIMAL_PLACES'"
            cmd = New SqlCommand(sSQL, CNDB)
            sdr = cmd.ExecuteReader()
            If (sdr.Read() = True) Then ProgProps.Decimals = sdr.GetString(sdr.GetOrdinal("VAL"))
            Return ProgProps.Decimals
        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), "Dreamy Kitchen CRM", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function
    Public Sub GetProgPROSF(Optional ByVal control As DevExpress.XtraLayout.LayoutControl = Nothing)
        Dim sSQL As String
        Dim sVal As String, sPrm As String
        Dim cmd As SqlCommand
        Dim sdr As SqlDataReader
        Try
            sSQL = "select prm,val FROM PRM where grpName= 'PROSF' ORDER by prm"
            cmd = New SqlCommand(sSQL, CNDB)
            sdr = cmd.ExecuteReader()
            'If (sdr.Read() = True) Then
            While sdr.Read()
                sPrm = sdr.GetString(sdr.GetOrdinal("prm"))
                If control Is Nothing Then
                    If sdr.IsDBNull(sdr.GetOrdinal("val")) = False Then
                        Select Case sPrm
                            Case "V_HEIGHT" : ProgProps.V_HEIGHT = sdr.GetString(sdr.GetOrdinal("val"))
                            Case "K_HEIGHT" : ProgProps.K_HEIGHT = sdr.GetString(sdr.GetOrdinal("val"))
                            Case "Y_HEIGHT" : ProgProps.Y_HEIGHT = sdr.GetString(sdr.GetOrdinal("val"))
                            Case "V_BOX_COLOR" : ProgProps.V_BOX_COLOR = sdr.GetString(sdr.GetOrdinal("val"))
                            Case "K_BOX_COLOR" : ProgProps.K_BOX_COLOR = sdr.GetString(sdr.GetOrdinal("val"))
                            Case "Y_BOX_COLOR" : ProgProps.Y_BOX_COLOR = sdr.GetString(sdr.GetOrdinal("val"))
                            Case "V_PVC_COLOR" : ProgProps.V_PVC_COLOR = sdr.GetString(sdr.GetOrdinal("val"))
                            Case "K_PVC_COLOR" : ProgProps.K_PVC_COLOR = sdr.GetString(sdr.GetOrdinal("val"))
                            Case "Y_PVC_COLOR" : ProgProps.Y_PVC_COLOR = sdr.GetString(sdr.GetOrdinal("val"))
                            Case "LEGS" : ProgProps.LEGS = sdr.GetString(sdr.GetOrdinal("val"))
                            Case "K_FINAL_HEIGHT" : ProgProps.K_FINAL_HEIGHT = sdr.GetString(sdr.GetOrdinal("val"))
                            Case "Y_FINAL_HEIGHT" : ProgProps.Y_FINAL_HEIGHT = sdr.GetString(sdr.GetOrdinal("val"))
                            Case "BENCH" : ProgProps.BENCH = sdr.GetString(sdr.GetOrdinal("val"))
                            Case "DAYS_OF_DELIVERY" : ProgProps.DAYS_OF_DELIVERY = sdr.GetString(sdr.GetOrdinal("val"))
                        End Select
                    End If
                Else
                    Dim Ctrl As Control = control.GetControlByName(sPrm)
                    Dim LItem As LayoutControlItem = control.GetItemByControl(Ctrl)
                    If sdr.IsDBNull(sdr.GetOrdinal("val")) = False Then SetValueToControl(LItem, sdr.GetString(sdr.GetOrdinal("val")))
                End If

            End While
                sdr.Close()
                sdr = Nothing
            'End If
        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), "Dreamy Kitchen CRM", MessageBoxButtons.OK, MessageBoxIcon.Error)
            sdr.Close()
            sdr = Nothing
        End Try
    End Sub
    Private Sub SetValueToControl(ByVal LItem As LayoutControlItem, ByVal sValue As String)
        Dim Ctrl As Control = LItem.Control
        If TypeOf Ctrl Is DevExpress.XtraEditors.LookUpEdit Then
            Dim cbo As DevExpress.XtraEditors.LookUpEdit
            Dim stestGuid As Guid
            Dim isValid As Boolean = Guid.TryParse(sValue, stestGuid)
            cbo = Ctrl
            If isValid = True Then
                cbo.EditValue = System.Guid.Parse(sValue)
            Else
                cbo.EditValue = Convert.ToInt32(sValue)
            End If
        ElseIf TypeOf Ctrl Is DevExpress.XtraEditors.ComboBoxEdit Then
            Dim cbo As DevExpress.XtraEditors.ComboBoxEdit
            cbo = Ctrl
            If sValue = "False" Then cbo.SelectedIndex = 0 Else cbo.SelectedIndex = 1
        ElseIf TypeOf Ctrl Is DevExpress.XtraEditors.DateEdit Then
            Dim dt As DevExpress.XtraEditors.DateEdit
            dt = Ctrl
            dt.EditValue = CDate(sValue)
        ElseIf TypeOf Ctrl Is DevExpress.XtraEditors.TimeEdit Then
            Dim tm As DevExpress.XtraEditors.TimeEdit
            tm = Ctrl

            tm.EditValue = CDate(sValue).ToString("HH:mm")
        ElseIf TypeOf Ctrl Is DevExpress.XtraEditors.MemoEdit Then
            Dim txt As DevExpress.XtraEditors.MemoEdit
            txt = Ctrl
            If txt.Properties.Mask.EditMask = "c" & ProgProps.Decimals Then
                txt.Text = Math.Round(CDec(sValue), ProgProps.Decimals)
            Else
                txt.Text = sValue
            End If
        ElseIf TypeOf Ctrl Is DevExpress.XtraEditors.TextEdit Then
            Dim txt As DevExpress.XtraEditors.TextEdit
            txt = Ctrl
            If txt.Properties.Mask.EditMask = "c" & ProgProps.Decimals Then
                txt.Text = Math.Round(CDec(sValue), ProgProps.Decimals)
            ElseIf txt.Properties.Mask.EditMask = "d" Then ' Αφορά το DateEditControl
                'sSQL.Append(toSQLValueS(CDate(txt.Text).ToString("yyyyMMdd")))
                txt.Text = sValue
            Else
                txt.Text = sValue
            End If
        ElseIf TypeOf Ctrl Is DevExpress.XtraEditors.CheckEdit Then
            Dim chk As DevExpress.XtraEditors.CheckEdit
            chk = Ctrl
            chk.EditValue = sValue
            chk.Checked = sValue
        ElseIf TypeOf Ctrl Is DevExpress.XtraEditors.DateEdit Then

        End If
    End Sub
    Public Sub SetProgPROSF(ByVal control As DevExpress.XtraLayout.LayoutControl)
        Dim sSQL As New System.Text.StringBuilder
        Dim cmd As SqlCommand
        Try
            For Each item As BaseLayoutItem In control.Items
                If TypeOf item Is LayoutControlItem Then
                    Dim LItem As LayoutControlItem = CType(item, LayoutControlItem)
                    Dim Ctrl As Control = LItem.Control
                    sSQL.Clear()
                    If LItem.Control IsNot Nothing Then
                        If LItem.Control.Tag <> "" Then
                            sSQL.AppendLine("UPDATE PRM SET val = ")
                            If TypeOf Ctrl Is DevExpress.XtraEditors.LookUpEdit Then
                                Dim cbo As DevExpress.XtraEditors.LookUpEdit
                                cbo = Ctrl
                                If cbo.EditValue <> Nothing Then
                                    sSQL.Append(toSQLValueS(cbo.EditValue.ToString))
                                Else
                                    sSQL.Append("NULL")
                                End If
                            ElseIf TypeOf Ctrl Is DevExpress.XtraEditors.TextEdit Then
                                Dim txt As DevExpress.XtraEditors.TextEdit
                                txt = Ctrl
                                If txt.Properties.Mask.EditMask = "c" & ProgProps.Decimals Or txt.Properties.Mask.MaskType = Mask.MaskType.Numeric Or txt.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric Then
                                    sSQL.Append(toSQLValueS(txt.EditValue, True))
                                Else
                                    sSQL.Append(toSQLValueS(txt.Text.Replace("%", "")))
                                End If
                            End If
                            sSQL.AppendLine(" where prm  = " & toSQLValueS(LItem.Control.Tag.ToString))
                            'Εκτέλεση QUERY
                            Using oCmd As New SqlCommand(sSQL.ToString, CNDB)
                                oCmd.ExecuteNonQuery()
                            End Using
                        End If
                    End If
                End If
            Next
        Catch ex As Exception
            Dim trace = New System.Diagnostics.StackTrace(ex, True)
            Dim line As String = Strings.Right(trace.ToString, 5)
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), "Dreamy Kitchen CRM", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Function GetProgCusDecimals() As Integer
        Dim sSQL As String
        Dim cmd As SqlCommand
        Dim sdr As SqlDataReader
        Try
            sSQL = "select val FROM PRM where prm= 'CUS_DISCOUNT'"
            cmd = New SqlCommand(sSQL, CNDB)
            sdr = cmd.ExecuteReader()
            If (sdr.Read() = True) Then ProgProps.CusDiscount = sdr.GetString(sdr.GetOrdinal("VAL"))
            Return ProgProps.CusDiscount
        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), "Dreamy Kitchen CRM", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function
    Public Sub SetProgTechSupportEmail(ByVal sValue As String)
        Dim sSQL As String
        Dim cmd As SqlCommand
        Try
            sSQL = "Update PRM set val = '" & sValue & "' where prm= 'SUPPORT_EMAIL'"
            cmd = New SqlCommand(sSQL, CNDB) : cmd.ExecuteNonQuery()
        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), "PRIAMOS .NET", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Public Sub SetProgCusDiscount(ByVal sValue As String)
        Dim sSQL As String
        Dim cmd As SqlCommand
        Try
            sSQL = "Update PRM set val = '" & sValue & "' where prm= 'CUS_DISCOUNT'"
            cmd = New SqlCommand(sSQL, CNDB) : cmd.ExecuteNonQuery()
        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), "PRIAMOS .NET", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Class
