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
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Function
    Public Sub SetProgVAT(ByVal sValue As Integer)
        Dim sSQL As String
        Dim cmd As SqlCommand
        Try
            sSQL = "Update PRM set val = '" & sValue & "' where prm= 'VAT'"
            cmd = New SqlCommand(sSQL, CNDB) : cmd.ExecuteNonQuery()
        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Public Sub SetProgDecimals(ByVal sValue As Integer)
        Dim sSQL As String
        Dim cmd As SqlCommand
        Try
            sSQL = "Update PRM set val = '" & sValue & "' where prm= 'DECIMAL_PLACES'"
            cmd = New SqlCommand(sSQL, CNDB) : cmd.ExecuteNonQuery()
        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
    Public Function GetProgvat() As Integer
        Dim sSQL As String
        Dim cmd As SqlCommand
        Dim sdr As SqlDataReader
        Try
            sSQL = "select val FROM PRM where prm= 'VAT'"
            cmd = New SqlCommand(sSQL, CNDB)
            sdr = cmd.ExecuteReader()
            If (sdr.Read() = True) Then ProgProps.VAT = sdr.GetString(sdr.GetOrdinal("VAL"))
            Return ProgProps.VAT
        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function
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
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
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
                            Case "KNOBS" : ProgProps.KNOBS = sdr.GetString(sdr.GetOrdinal("val"))
                            Case "BAZA" : ProgProps.BAZA = sdr.GetString(sdr.GetOrdinal("val"))
                            Case "DRAWERS" : ProgProps.DRAWERS = sdr.GetString(sdr.GetOrdinal("val"))
                            Case "SHELVES" : ProgProps.SHELVES = sdr.GetString(sdr.GetOrdinal("val"))
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
                            Case "DOOR_DESCRIPTION" : ProgProps.DOOR_DESCRIPTION = sdr.GetString(sdr.GetOrdinal("val"))
                            Case "DOOR_CMT" : ProgProps.DOOR_CMT = sdr.GetString(sdr.GetOrdinal("val"))
                            Case "CUS_NOTES" : ProgProps.CUS_NOTES = sdr.GetString(sdr.GetOrdinal("val"))
                            Case "CUS_DISCOUNT_KITCHEN" : ProgProps.CusDiscountKitchen = sdr.GetString(sdr.GetOrdinal("val"))
                            Case "CUS_DISCOUNT_CLOSET" : ProgProps.CusDiscountCloset = sdr.GetString(sdr.GetOrdinal("val"))
                            Case "CUS_DISCOUNT_DOORS" : ProgProps.CusDiscountDoors = sdr.GetString(sdr.GetOrdinal("val"))
                            Case "CUS_DISCOUNT_SPECIAL" : ProgProps.CusDiscountSpecial = sdr.GetString(sdr.GetOrdinal("val"))
                            Case "CLOSET_DESCRIPTION" : ProgProps.CLOSET_DESCRIPTION = sdr.GetString(sdr.GetOrdinal("val"))
                            Case "KITCHEN_DESCRIPTION" : ProgProps.KITCHEN_DESCRIPTION = sdr.GetString(sdr.GetOrdinal("val"))
                            Case "CLOSET_BACK_THIKNESS" : ProgProps.CLOSET_BACK_THIKNESS = sdr.GetString(sdr.GetOrdinal("val"))
                            Case "CLOSET_BOX_COLOR" : ProgProps.CLOSET_BOX_COLOR = sdr.GetString(sdr.GetOrdinal("val"))
                            Case "CLOSET_BOX_THIKNESS" : ProgProps.CLOSET_BOX_THIKNESS = sdr.GetString(sdr.GetOrdinal("val"))
                            Case "CLOSET_DRAWERS" : ProgProps.CLOSET_DRAWERS = sdr.GetString(sdr.GetOrdinal("val"))
                            Case "CLOSET_LEGS" : ProgProps.CLOSET_LEGS = sdr.GetString(sdr.GetOrdinal("val"))
                            Case "CLOSET_PVC_COLOR" : ProgProps.CLOSET_PVC_COLOR = sdr.GetString(sdr.GetOrdinal("val"))
                            Case "CLOSET_SHELVES" : ProgProps.CLOSET_SHELVES = sdr.GetString(sdr.GetOrdinal("val"))
                            Case "CLOSET_TRANSP" : ProgProps.ClosetTransp = sdr.GetString(sdr.GetOrdinal("val"))
                            Case "KITCHEN_TRANSP" : ProgProps.KitchenTransp = sdr.GetString(sdr.GetOrdinal("val"))
                            Case "DOOR_TRANSP" : ProgProps.DoorTransp = sdr.GetString(sdr.GetOrdinal("val"))
                            Case "SC_TRANSP" : ProgProps.SCTransp = sdr.GetString(sdr.GetOrdinal("val"))
                            Case "KITCHEN_MEASUREMENT" : ProgProps.KitchenMeasurement = sdr.GetString(sdr.GetOrdinal("val"))
                            Case "CLOSET_MEASUREMENT" : ProgProps.ClosetMeasurement = sdr.GetString(sdr.GetOrdinal("val"))
                            Case "DOOR_MEASUREMENT" : ProgProps.DoorMeasurement = sdr.GetString(sdr.GetOrdinal("val"))
                            Case "SC_MEASUREMENT" : ProgProps.SCMeasurement = sdr.GetString(sdr.GetOrdinal("val"))
                            Case "KITCHEN_REMOVE" : ProgProps.KitchenRemove = sdr.GetString(sdr.GetOrdinal("val"))
                            Case "CLOSET_REMOVE" : ProgProps.ClosetRemove = sdr.GetString(sdr.GetOrdinal("val"))
                            Case "DOOR_REMOVE" : ProgProps.DoorRemove = sdr.GetString(sdr.GetOrdinal("val"))
                            Case "SC_REMOVE" : ProgProps.SCRemove = sdr.GetString(sdr.GetOrdinal("val"))
                            Case "KCOMPANY_PROFIT" : ProgProps.KCOMPANY_PROFIT = sdr.GetString(sdr.GetOrdinal("val"))
                            Case "CCOMPANY_PROFIT" : ProgProps.CCOMPANY_PROFIT = sdr.GetString(sdr.GetOrdinal("val"))
                            Case "DCOMPANY_PROFIT" : ProgProps.DCOMPANY_PROFIT = sdr.GetString(sdr.GetOrdinal("val"))
                            Case "SCCOMPANY_PROFIT" : ProgProps.SCCOMPANY_PROFIT = sdr.GetString(sdr.GetOrdinal("val"))
                        End Select
                    End If
                Else
                    Dim Ctrl As Control = control.GetControlByName(sPrm)
                    If Ctrl IsNot Nothing Then
                        Dim LItem As LayoutControlItem = control.GetItemByControl(Ctrl)
                        If sdr.IsDBNull(sdr.GetOrdinal("val")) = False Then SetValueToControl(LItem, sdr.GetString(sdr.GetOrdinal("val")))
                    End If
                End If

            End While
            sdr.Close()
            sdr = Nothing
            'End If
        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
            sdr.Close()
            sdr = Nothing
        End Try
    End Sub
    Public Sub GetProgEmailInst(Optional ByVal control As DevExpress.XtraLayout.LayoutControl = Nothing)
        Dim sSQL As String
        Dim sVal As String, sPrm As String
        Dim cmd As SqlCommand
        Dim sdr As SqlDataReader
        Try
            sSQL = "select prm,val FROM PRM where grpName= 'EMAIL_INSTALLATIONS' ORDER by prm"
            cmd = New SqlCommand(sSQL, CNDB)
            sdr = cmd.ExecuteReader()
            While sdr.Read()
                sPrm = sdr.GetString(sdr.GetOrdinal("prm"))
                If control Is Nothing Then
                    If sdr.IsDBNull(sdr.GetOrdinal("val")) = False Then
                        Select Case sPrm
                            Case "ELLIPSE_BODY_INF" : ProgProps.InstEllipseInfBody = sdr.GetString(sdr.GetOrdinal("val"))
                            Case "INSTALLATIONS_EMAIL" : ProgProps.InstEmailAccount = sdr.GetString(sdr.GetOrdinal("val"))
                            Case "ELLIPSE_SUBJECT_INF" : ProgProps.InstEllipseInfSubject = sdr.GetString(sdr.GetOrdinal("val"))
                            Case "INSTALLATIONS_EMAIL_SUP" : ProgProps.InstEmailAccountSup = sdr.GetString(sdr.GetOrdinal("val"))
                            Case "ELLIPSE_BODY_SUP_INF" : ProgProps.InstEllipseInfBodySup = sdr.GetString(sdr.GetOrdinal("val"))
                            Case "ELLIPSE_SUBJECT_SUP_INF" : ProgProps.InstEllipseInfSubjectSup = sdr.GetString(sdr.GetOrdinal("val"))
                            Case "ELLIPSE_BODY_INF_APPOINTMENT" : ProgProps.InstEllipseInfAppointmentBody = sdr.GetString(sdr.GetOrdinal("val"))
                            Case "INSTALLATIONS_SUBJECT_INF" : ProgProps.InstInfSubject = sdr.GetString(sdr.GetOrdinal("val"))
                            Case "INSTALLATIONS_BODY_INF_APPOINTMENT" : ProgProps.InstInfAppointmentBody = sdr.GetString(sdr.GetOrdinal("val"))
                            Case "ELLIPSE_SUBJECT_INF_APPOINTMENT" : ProgProps.InstEllipseInfAppointmentSubject = sdr.GetString(sdr.GetOrdinal("val"))
                            Case "ELLIPSE_SUBJECT_COMPLETE_INF" : ProgProps.InstEllipseInfSubjectComplete = sdr.GetString(sdr.GetOrdinal("val"))
                            Case "ELLIPSE_BODY_COMPLETE_INF" : ProgProps.InstEllipseInfBodyComplete = sdr.GetString(sdr.GetOrdinal("val"))
                        End Select
                    End If
                Else
                    Dim Ctrl As Control = control.GetControlByName(sPrm)
                    If Ctrl IsNot Nothing Then
                        Dim LItem As LayoutControlItem = control.GetItemByControl(Ctrl)
                        If sdr.IsDBNull(sdr.GetOrdinal("val")) = False Then
                            SetValueToControl(LItem, sdr.GetString(sdr.GetOrdinal("val")))
                            Select Case sPrm
                                Case "ELLIPSE_BODY_INF" : ProgProps.InstEllipseInfBody = sdr.GetString(sdr.GetOrdinal("val"))
                                Case "INSTALLATIONS_EMAIL" : ProgProps.InstEmailAccount = sdr.GetString(sdr.GetOrdinal("val"))
                                Case "ELLIPSE_SUBJECT_INF" : ProgProps.InstEllipseInfSubject = sdr.GetString(sdr.GetOrdinal("val"))
                                Case "INSTALLATIONS_EMAIL_SUP" : ProgProps.InstEmailAccountSup = sdr.GetString(sdr.GetOrdinal("val"))
                                Case "ELLIPSE_BODY_SUP_INF" : ProgProps.InstEllipseInfBodySup = sdr.GetString(sdr.GetOrdinal("val"))
                                Case "ELLIPSE_SUBJECT_SUP_INF" : ProgProps.InstEllipseInfSubjectSup = sdr.GetString(sdr.GetOrdinal("val"))
                                Case "ELLIPSE_BODY_INF_APPOINTMENT" : ProgProps.InstEllipseInfAppointmentBody = sdr.GetString(sdr.GetOrdinal("val"))
                                Case "INSTALLATIONS_SUBJECT_INF" : ProgProps.InstInfSubject = sdr.GetString(sdr.GetOrdinal("val"))
                                Case "INSTALLATIONS_BODY_INF_APPOINTMENT" : ProgProps.InstInfAppointmentBody = sdr.GetString(sdr.GetOrdinal("val"))
                                Case "ELLIPSE_SUBJECT_INF_APPOINTMENT" : ProgProps.InstEllipseInfAppointmentSubject = sdr.GetString(sdr.GetOrdinal("val"))
                                Case "ELLIPSE_SUBJECT_COMPLETE_INF" : ProgProps.InstEllipseInfSubjectComplete = sdr.GetString(sdr.GetOrdinal("val"))
                                Case "ELLIPSE_BODY_COMPLETE_INF" : ProgProps.InstEllipseInfBodyComplete = sdr.GetString(sdr.GetOrdinal("val"))
                            End Select
                        End If
                    End If
                End If
            End While
            sdr.Close()
            sdr = Nothing
            'End If
        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
            sdr.Close()
            sdr = Nothing
        End Try
    End Sub

    Private Sub SetValueToControl(ByVal LItem As LayoutControlItem, ByVal sValue As String)
        Try
            Dim Ctrl As Control = LItem.Control
            If TypeOf Ctrl Is DevExpress.XtraEditors.LookUpEdit Then
                Dim cbo As DevExpress.XtraEditors.LookUpEdit
                Dim stestGuid As Guid
                Dim isint As Integer
                Dim isValid As Boolean = Guid.TryParse(sValue, stestGuid)
                cbo = Ctrl
                If isValid = True Then
                    cbo.EditValue = System.Guid.Parse(sValue)
                Else
                    If Integer.TryParse(sValue, isint) Then
                        cbo.EditValue = Convert.ToInt32(sValue)
                    Else
                        cbo.EditValue = sValue
                        Dim sVal = cbo.Properties.GetKeyValueByDisplayText(sValue)
                        If sVal IsNot Nothing Then cbo.EditValue = sVal
                    End If
                End If
            ElseIf TypeOf Ctrl Is DevExpress.XtraEditors.ComboBoxEdit Then
                Dim cbo As DevExpress.XtraEditors.ComboBoxEdit
                cbo = Ctrl
                If sValue = "False" Or sValue = "True" Then
                    If sValue = "False" Then cbo.SelectedIndex = 0 Else cbo.SelectedIndex = 1
                ElseIf IsNumeric(sValue) Then
                    cbo.SelectedIndex = sValue
                Else
                    cbo.EditValue = sValue
                End If
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
        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
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
                            ElseIf TypeOf Ctrl Is DevExpress.XtraEditors.ComboBoxEdit Then
                                Dim cbo As DevExpress.XtraEditors.ComboBoxEdit
                                cbo = Ctrl
                                If cbo.EditValue <> Nothing Then
                                    If cbo.EditValue = "False" Or cbo.EditValue = "True" Or cbo.Properties.Tag = "0" Then
                                        sSQL.Append(cbo.SelectedIndex)
                                    Else
                                        If cbo.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric Then
                                            sSQL.Append(cbo.SelectedIndex)
                                        Else
                                            sSQL.Append(toSQLValueS(cbo.EditValue.ToString))
                                        End If
                                    End If
                                Else
                                    sSQL.Append("NULL")
                                End If
                            ElseIf TypeOf Ctrl Is DevExpress.XtraEditors.TextEdit Then
                                Dim txt As DevExpress.XtraEditors.TextEdit
                                txt = Ctrl
                                If txt.Properties.Mask.EditMask = "c" & ProgProps.Decimals Or txt.Properties.Mask.MaskType = Mask.MaskType.Numeric Or txt.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric Then
                                    sSQL.Append(toSQLValueS(txt.EditValue, True))
                                Else
                                    'sSQL.Append(toSQLValueS(txt.Text.Replace("%", "")))
                                    sSQL.Append(toSQLValueS(txt.Text))
                                End If
                            ElseIf TypeOf Ctrl Is DevExpress.XtraEditors.MemoEdit Then
                                Dim txt As DevExpress.XtraEditors.MemoEdit
                                txt = Ctrl
                                If txt.Properties.Mask.EditMask = "c" & ProgProps.Decimals Or txt.Properties.Mask.MaskType = Mask.MaskType.Numeric Or txt.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric Then
                                    sSQL.Append(toSQLValueS(txt.EditValue, True))
                                Else
                                    sSQL.Append(toSQLValueS(txt.Text))
                                End If
                            End If
                            sSQL.AppendLine(" where prm  = " & toSQLValueS(LItem.Control.Tag.ToString))
                            Debug.Print(sSQL.ToString)
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
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub SetProgTechSupportEmail(ByVal sValue As String)
        Dim sSQL As String
        Dim cmd As SqlCommand
        Try
            sSQL = "Update PRM set val = '" & sValue & "' where prm= 'SUPPORT_EMAIL'"
            cmd = New SqlCommand(sSQL, CNDB) : cmd.ExecuteNonQuery()
        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub SetProgInstEmail(ByVal sValue As String, ByVal sValue2 As String, ByVal sValue3 As String, ByVal sValue4 As String, ByVal sValue5 As String,
                                ByVal sValue6 As String, ByVal sValue7 As String, ByVal sValue8 As String, ByVal sValue9 As String, ByVal sValue10 As String,
                                ByVal sValue11 As String, ByVal sValue12 As String)
        Dim sSQL As String
        Dim cmd As SqlCommand
        Try

            If sValue.Length > 0 Then sSQL = "Update PRM set val = '" & sValue & "' where prm= 'ELLIPSE_BODY_INF'" : cmd = New SqlCommand(sSQL, CNDB) : cmd.ExecuteNonQuery()
            If sValue2.Length > 0 Then sSQL = "Update PRM set val = '" & sValue2 & "' where prm= 'INSTALLATIONS_EMAIL'" : cmd = New SqlCommand(sSQL, CNDB) : cmd.ExecuteNonQuery()
            If sValue3.Length > 0 Then sSQL = "Update PRM set val = '" & sValue3 & "' where prm= 'ELLIPSE_SUBJECT_INF'" : cmd = New SqlCommand(sSQL, CNDB) : cmd.ExecuteNonQuery()
            If sValue4.Length > 0 Then sSQL = "Update PRM set val = '" & sValue4 & "' where prm= 'INSTALLATIONS_EMAIL_SUP'" : cmd = New SqlCommand(sSQL, CNDB) : cmd.ExecuteNonQuery()
            If sValue5.Length > 0 Then sSQL = "Update PRM set val = '" & sValue5 & "' where prm= 'ELLIPSE_SUBJECT_SUP_INF'" : cmd = New SqlCommand(sSQL, CNDB) : cmd.ExecuteNonQuery()
            If sValue6.Length > 0 Then sSQL = "Update PRM set val = '" & sValue6 & "' where prm= 'ELLIPSE_BODY_SUP_INF'" : cmd = New SqlCommand(sSQL, CNDB) : cmd.ExecuteNonQuery()
            If sValue7.Length > 0 Then sSQL = "Update PRM set val = '" & sValue7 & "' where prm= 'ELLIPSE_BODY_INF_APPOINTMENT'" : cmd = New SqlCommand(sSQL, CNDB) : cmd.ExecuteNonQuery()
            If sValue8.Length > 0 Then sSQL = "Update PRM set val = '" & sValue8 & "' where prm= 'INSTALLATIONS_SUBJECT_INF'" : cmd = New SqlCommand(sSQL, CNDB) : cmd.ExecuteNonQuery()
            If sValue9.Length > 0 Then sSQL = "Update PRM set val = '" & sValue9 & "' where prm= 'INSTALLATIONS_BODY_INF_APPOINTMENT'" : cmd = New SqlCommand(sSQL, CNDB) : cmd.ExecuteNonQuery()
            If sValue10.Length > 0 Then sSQL = "Update PRM set val = '" & sValue10 & "' where prm= 'ELLIPSE_SUBJECT_INF_APPOINTMENT'" : cmd = New SqlCommand(sSQL, CNDB) : cmd.ExecuteNonQuery()
            If sValue11.Length > 0 Then sSQL = "Update PRM set val = '" & sValue11 & "' where prm= 'ELLIPSE_SUBJECT_COMPLETE_INF'" : cmd = New SqlCommand(sSQL, CNDB) : cmd.ExecuteNonQuery()
            If sValue12.Length > 0 Then sSQL = "Update PRM set val = '" & sValue12 & "' where prm= 'ELLIPSE_BODY_COMPLETE_INF'" : cmd = New SqlCommand(sSQL, CNDB) : cmd.ExecuteNonQuery()

        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub SetProgSupEmail(ByVal sValue As String)
        Dim sSQL As String
        Dim cmd As SqlCommand
        Try

            If sValue.Length > 0 Then sSQL = "Update PRM set val = '" & sValue & "' where prm= 'SUP_ORDERS_EMAIL'" : cmd = New SqlCommand(sSQL, CNDB) : cmd.ExecuteNonQuery()
        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Public Function GetProgEmailSup(Optional ByVal LItem As LayoutControlItem = Nothing) As String

        Dim sSQL As String
        Dim cmd As SqlCommand
        Dim sdr As SqlDataReader
        Try
            sSQL = "select val FROM PRM where prm= 'SUP_ORDERS_EMAIL' "
            cmd = New SqlCommand(sSQL, CNDB)
            sdr = cmd.ExecuteReader()
            If (sdr.Read() = True) Then ProgProps.EmailOrders = sdr.GetString(sdr.GetOrdinal("VAL")) : If LItem IsNot Nothing Then SetValueToControl(LItem, sdr.GetString(sdr.GetOrdinal("val")))
            Return ProgProps.EmailOrders
        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function
End Class
