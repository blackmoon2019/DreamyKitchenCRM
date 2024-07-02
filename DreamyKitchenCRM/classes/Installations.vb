﻿Imports System.Data.SqlClient
Imports System.IO
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Grid

Public Class Installations
    Private Prog_Prop As New ProgProp
    Private ID As String
    Private sEmpTID As String
    Private sTranshID As String
    Public bHasInstCostKitchen As Boolean
    Public bHasInstCostCloset As Boolean
    Public bHasInstCostDoors As Boolean
    Public bHasInstCostSC As Boolean
    Private Ctrl As DevExpress.XtraGrid.Views.Grid.GridView
    Public Mode As Byte
    Private Valid As New ValidateControls
    Private FScrollerExist As Boolean = False
    Private FillCbo As New FillCombos
    Private DBQ As New DBQueries
    Private LoadForms As New FormLoader
    Private Cls As New ClearControls
    Private CtrlCombo As DevExpress.XtraEditors.LookUpEdit
    Private CalledFromCtrl As Boolean
    Private UserPermissions As New CheckPermissions
    Private Frm As frmInstallations
    Private sFields As New Dictionary(Of String, String)
    Public Sub Initialize(ByVal sFrm As frmInstallations, ByVal sInstID As String, ByVal sMode As Byte, ByVal sCalledFromCtrl As Boolean,
                          ByVal sCtrlCombo As DevExpress.XtraEditors.LookUpEdit, ByVal EmpTID As String)
        Frm = sFrm
        ID = sInstID
        sEmpTID = EmpTID
        Mode = sMode
        Frm.Vw_FILE_CATTableAdapter.Fill(Frm.DreamyKitchenDataSet.vw_FILE_CAT)
        Frm.Vw_ExtPartnersTableAdapter.Fill(Frm.DMDataSet.vw_ExtPartners)
        Frm.cmdConstInstK.Enabled = False
        Frm.cmdConstInstC.Enabled = False
        Frm.cmdConstInstD.Enabled = False
        Frm.cmdConstInstSC.Enabled = False

    End Sub

    Public Sub LoadForm()
        'TODO: This line of code loads data into the 'DreamyKitchenDataSet.vw_TRANSH' table. You can move, or remove it, as needed.
        Dim sSQL As New System.Text.StringBuilder
        sSQL.AppendLine(" Select C.id,C.Fullname,'00000000-0000-0000-0000-000000000000' as SalerID,phn,C.AdrID,email " &
                            "from vw_CCT C " &
                            "inner join vw_TRANSH T On C.ID = T.cusID  " &
                            "where completed=0 " &
                            "order by Fullname")

        FillCbo.CUS(Frm.cboCUS, sSQL)
        FillCbo.SALERS(Frm.cboSaler)
        ' Μόνο αν ο Χρήστης ΔΕΝ είναι ο Παναγόπουλος
        'If UserProps.ID.ToString.ToUpper <> "3F9DC32E-BE5B-4D46-A13C-EA606566CF32" And UserProps.ID.ToString.ToUpper <> "E9CEFD11-47C0-4796-A46B-BC41C4C3606B" Then Frm.Lcost.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never : Frm.LExtracost.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        Select Case Mode
            Case FormMode.NewRecord
                Frm.txtCode.Text = DBQ.GetNextId("INST")
                Frm.cmdConstInstK.Enabled = False : Frm.cmdConstInstC.Enabled = False
                Frm.cmdConstInstD.Enabled = False : Frm.cmdConstInstSC.Enabled = False
            Case FormMode.EditRecord
                Dim myLayoutControls As New List(Of System.Windows.Forms.Control)
                myLayoutControls.Add(Frm.LayoutControl1)
                myLayoutControls.Add(Frm.LayoutControl3)
                myLayoutControls.Add(Frm.LayoutControl6)
                myLayoutControls.Add(Frm.LayoutControl7)
                myLayoutControls.Add(Frm.LayoutControl8)
                myLayoutControls.Add(Frm.LayoutControl9)

                LoadForms.LoadFormNew(myLayoutControls, "Select * from vw_INST where id ='" + ID + "'",, sFields)
                Frm.cmdInstEllipse.Enabled = True
                bHasInstCostKitchen = sFields("HasInstCostKitchen")
                bHasInstCostCloset = sFields("HasInstCostCloset")
                bHasInstCostDoors = sFields("HasInstCostDoors")
                bHasInstCostSC = sFields("HasInstCostSC")
        End Select


        If CheckIfExistInstEllipse() = True Then Frm.LInstFilename.Enabled = False
        If Frm.txtInstFilename.Text.Length > 0 Then Frm.cmdInstEllipse.Enabled = False
        'ΚΟΥΖΙΝΑ
        If Frm.cboTRANSH.GetColumnValue("Iskitchen") = "True" Then
            FillListSER(0)
            Frm.TabNavKitchen.Enabled = Frm.cboTRANSH.GetColumnValue("Iskitchen")
        End If
        'ΝΤΟΥΛΑΠΑ
        If Frm.cboTRANSH.GetColumnValue("Iscloset") = "True" Then
            FillListSER(1)
            Frm.TabNavCloset.Enabled = Frm.cboTRANSH.GetColumnValue("Iscloset")
        End If
        'ΠΟΡΤΑ
        If Frm.cboTRANSH.GetColumnValue("Isdoor") = "True" Then
            FillListSER(2)
            Frm.TabNavCloset.Enabled = Frm.cboTRANSH.GetColumnValue("Isdoor")
        End If
        'ΕΙΔΙΚΗ ΚΑΤΑΣΚΕΥΗ
        If Frm.cboTRANSH.GetColumnValue("Issc") = "True" Then
            FillListSER(3)
            Frm.TabNavCloset.Enabled = Frm.cboTRANSH.GetColumnValue("Issc")
        End If
        Frm.cmdSave.Enabled = IIf(Mode = FormMode.NewRecord, UserProps.AllowInsert, UserProps.AllowEdit)
    End Sub
    Public Sub FillListSER(ByVal sCategory As Int16)
        Select Case Mode
            Case FormMode.NewRecord
                Select Case sCategory
                    Case 0 : FillCbo.FillCheckedListSER(Frm.chkSERK, FormMode.NewRecord,, 0)        'ΚΟΥΖΙΝΑ
                    Case 1 : FillCbo.FillCheckedListSER(Frm.chkSERC, FormMode.NewRecord,, 1)        'ΝΤΟΥΛΑΠΑ
                    Case 2 : FillCbo.FillCheckedListSER(Frm.chkSERD, FormMode.NewRecord,, 2)        'ΠΟΡΤΑ
                    Case 3 : FillCbo.FillCheckedListSER(Frm.chkSERSC, FormMode.NewRecord,, 3)       'ΕΙΔΙΚΗ ΚΑΤΑΣΚΕΥΗ
                End Select
            Case FormMode.EditRecord
                Select Case sCategory
                    Case 0 : FillCbo.FillCheckedListSER(Frm.chkSERK, FormMode.EditRecord, ID, 0)   'ΚΟΥΖΙΝΑ
                        If sFields("ExtPartnerKitchenID") <> "" Then Frm.cboExtPartnerKitchen.EditValue = System.Guid.Parse(sFields("ExtPartnerKitchenID"))
                    Case 1 : FillCbo.FillCheckedListSER(Frm.chkSERC, FormMode.EditRecord, ID, 1)   'ΝΤΟΥΛΑΠΑ
                        If sFields("ExtPartnerClosetID") <> "" Then Frm.cboExtPartnerCloset.EditValue = System.Guid.Parse(sFields("ExtPartnerClosetID"))
                    Case 2 : FillCbo.FillCheckedListSER(Frm.chkSERD, FormMode.EditRecord, ID, 2)   'ΠΟΡΤΑ
                        If sFields("ExtPartnerDoorsID") <> "" Then Frm.cboExtPartnerDoors.EditValue = System.Guid.Parse(sFields("ExtPartnerDoorsID"))
                    Case 3 : FillCbo.FillCheckedListSER(Frm.chkSERSC, FormMode.EditRecord, ID, 3)  'ΕΙΔΙΚΗ ΚΑΤΑΣΚΕΥΗ
                        If sFields("ExtPartnerSCID") <> "" Then Frm.cboExtPartnerSC.EditValue = System.Guid.Parse(sFields("ExtPartnerSCID"))
                End Select
        End Select
    End Sub
    Public Sub SaveRecord(ByRef sID As String)
        Dim sResult As Boolean
        Dim sGuid As String
        Dim sSQL As New System.Text.StringBuilder
        Try
            If Valid.ValidateForm(Frm.LayoutControl1) Then
                If CheckIfTimeisValid() = False Then Exit Sub
                If CheckIfInstFExist() = False Then Exit Sub
                Dim myLayoutControls As New List(Of System.Windows.Forms.Control)
                myLayoutControls.Add(Frm.LayoutControl1)
                myLayoutControls.Add(Frm.LayoutControl3)
                myLayoutControls.Add(Frm.LayoutControl6)
                myLayoutControls.Add(Frm.LayoutControl7)
                myLayoutControls.Add(Frm.LayoutControl8)
                myLayoutControls.Add(Frm.LayoutControl9)
                Select Case Mode
                    Case FormMode.NewRecord
                        sGuid = System.Guid.NewGuid.ToString
                        sResult = DBQ.InsertNewData(DBQueries.InsertMode.MultipleLayoutControls, "INST",, myLayoutControls,, sGuid, True)
                        sID = sGuid
                    Case FormMode.EditRecord
                        sResult = DBQ.UpdateNewData(DBQueries.InsertMode.MultipleLayoutControls, "INST",, myLayoutControls,, sID, True)
                        'sGuid = sID
                End Select

                If sResult = True Then
                    If Frm.cboTRANSH.EditValue IsNot Nothing Then
                        sSQL.Clear()
                        sSQL.AppendLine("UPDATE PROJECT_COST SET InstPayroll = (Select sum(ISNULL(I.cost, 0) + ISNULL(I.extracost, 0)) from INST I where I.transhid= " & toSQLValueS(Frm.cboTRANSH.EditValue.ToString) & ")")
                        sSQL.AppendLine("WHERE TRANSHID = " & toSQLValueS(Frm.cboTRANSH.EditValue.ToString))
                        'Εκτέλεση QUERY
                        Using oCmd As New SqlCommand(sSQL.ToString, CNDB)
                            oCmd.ExecuteNonQuery()
                        End Using
                        ' Άνοιγμα έργου αν δεν υπάρχει ή ενημέρωση ποσών
                        Using oCmd As New SqlCommand("usp_AddOrUpdateProjectcost", CNDB)
                            oCmd.CommandType = CommandType.StoredProcedure
                            oCmd.Parameters.AddWithValue("@transhID", Frm.cboTRANSH.EditValue.ToString)
                            oCmd.ExecuteNonQuery()
                        End Using
                        Frm.cmdConstInstK.Enabled = True : Frm.cmdConstInstC.Enabled = True
                        Frm.cmdConstInstD.Enabled = True : Frm.cmdConstInstSC.Enabled = True
                    End If

                    XtraMessageBox.Show("Η εγγραφή αποθηκέυτηκε με επιτυχία", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
                Dim sSQL2 As String
                If Mode = FormMode.EditRecord Then
                    sSQL2 = "DELETE FROM INST_SER where instID = '" & sID & "'"
                    Using oCmd As New SqlCommand(sSQL2, CNDB)
                        oCmd.ExecuteNonQuery()
                    End Using
                End If

                If Frm.cboTRANSH.GetColumnValue("Iskitchen") = True Then
                    ' Καταχώρηση Συνεργείων
                    For Each item As DevExpress.XtraEditors.Controls.CheckedListBoxItem In Frm.chkSERK.CheckedItems
                        sSQL2 = "INSERT INTO INST_SER (instID,empID,[createdBy],[createdOn],kitchen)  
                                        values (" & toSQLValueS(sID) & "," & toSQLValueS(item.Tag.ToString()) & "," &
                                                            toSQLValueS(UserProps.ID.ToString) & ", getdate(),1 )"
                        Using oCmd As New SqlCommand(sSQL2, CNDB)
                            oCmd.ExecuteNonQuery()
                        End Using
                    Next
                    If Frm.cboExtPartnerKitchen.EditValue IsNot Nothing Then
                        sSQL2 = "INSERT INTO INST_SER (instID,empID,[createdBy],[createdOn],kitchen)  
                                        values (" & toSQLValueS(sID) & "," & toSQLValueS(Frm.cboExtPartnerKitchen.EditValue.ToString()) & "," &
                                                            toSQLValueS(UserProps.ID.ToString) & ", getdate(),1 )"
                        Using oCmd As New SqlCommand(sSQL2, CNDB)
                            oCmd.ExecuteNonQuery()
                        End Using
                        sFields("ExtPartnerKitchenID") = Frm.cboExtPartnerKitchen.EditValue.ToString()
                    End If
                    FillListSER(0)
                End If



                If Frm.cboTRANSH.GetColumnValue("Iscloset") = True Then
                    ' Καταχώρηση Συνεργείων
                    For Each item As DevExpress.XtraEditors.Controls.CheckedListBoxItem In Frm.chkSERC.CheckedItems
                        sSQL2 = "INSERT INTO INST_SER (instID,empID,[createdBy],[createdOn],closet)  
                                        values (" & toSQLValueS(sID) & "," & toSQLValueS(item.Tag.ToString()) & "," &
                                                            toSQLValueS(UserProps.ID.ToString) & ", getdate(),1 )"
                        Using oCmd As New SqlCommand(sSQL2, CNDB)
                            oCmd.ExecuteNonQuery()
                        End Using
                    Next
                    If Frm.cboExtPartnerCloset.EditValue IsNot Nothing Then
                        sSQL2 = "INSERT INTO INST_SER (instID,empID,[createdBy],[createdOn],closet)  
                                        values (" & toSQLValueS(sID) & "," & toSQLValueS(Frm.cboExtPartnerCloset.EditValue.ToString()) & "," &
                                                            toSQLValueS(UserProps.ID.ToString) & ", getdate(),1 )"
                        Using oCmd As New SqlCommand(sSQL2, CNDB)
                            oCmd.ExecuteNonQuery()
                        End Using
                        sFields("ExtPartnerClosetID") = Frm.cboExtPartnerCloset.EditValue.ToString()
                    End If
                    FillListSER(1)
                End If
                If Frm.cboTRANSH.GetColumnValue("Isdoor") = True Then
                    ' Καταχώρηση Συνεργείων
                    For Each item As DevExpress.XtraEditors.Controls.CheckedListBoxItem In Frm.chkSERD.CheckedItems
                        sSQL2 = "INSERT INTO INST_SER (instID,empID,[createdBy],[createdOn],doors)  
                                        values (" & toSQLValueS(sID) & "," & toSQLValueS(item.Tag.ToString()) & "," &
                                                        toSQLValueS(UserProps.ID.ToString) & ", getdate(),1 )"
                        Using oCmd As New SqlCommand(sSQL2, CNDB)
                            oCmd.ExecuteNonQuery()
                        End Using
                    Next
                    If Frm.cboExtPartnerDoors.EditValue IsNot Nothing Then
                        sSQL2 = "INSERT INTO INST_SER (instID,empID,[createdBy],[createdOn],doors)  
                                        values (" & toSQLValueS(sID) & "," & toSQLValueS(Frm.cboExtPartnerDoors.EditValue.ToString()) & "," &
                                                            toSQLValueS(UserProps.ID.ToString) & ", getdate(),1 )"
                        Using oCmd As New SqlCommand(sSQL2, CNDB)
                            oCmd.ExecuteNonQuery()
                        End Using
                        sFields("ExtPartnerDoorsID") = Frm.cboExtPartnerDoors.EditValue.ToString()
                    End If
                    FillListSER(2)
                End If
                If Frm.cboTRANSH.GetColumnValue("Issc") = True Then
                    ' Καταχώρηση Συνεργείων
                    For Each item As DevExpress.XtraEditors.Controls.CheckedListBoxItem In Frm.chkSERSC.CheckedItems
                        sSQL2 = "INSERT INTO INST_SER (instID,empID,[createdBy],[createdOn],sc)  
                                        values (" & toSQLValueS(sID) & "," & toSQLValueS(item.Tag.ToString()) & "," &
                                                            toSQLValueS(UserProps.ID.ToString) & ", getdate(),1 )"
                        Using oCmd As New SqlCommand(sSQL2, CNDB)
                            oCmd.ExecuteNonQuery()
                        End Using
                    Next
                    If Frm.cboExtPartnerSC.EditValue IsNot Nothing Then
                        sSQL2 = "INSERT INTO INST_SER (instID,empID,[createdBy],[createdOn],sc)  
                                        values (" & toSQLValueS(sID) & "," & toSQLValueS(Frm.cboExtPartnerSC.EditValue.ToString()) & "," &
                                                            toSQLValueS(UserProps.ID.ToString) & ", getdate(),1 )"
                        Using oCmd As New SqlCommand(sSQL2, CNDB)
                            oCmd.ExecuteNonQuery()
                        End Using
                        sFields("ExtPartnerSCID") = Frm.cboExtPartnerSC.EditValue.ToString()
                    End If
                    FillListSER(3)
                End If
            End If

        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Public Sub SaveRecordF(ByVal sMode As Integer, Optional ByVal sFilename As String = "")
        Dim sResultF As Boolean
        If Frm.cboTanshFCategory.EditValue = Nothing Then XtraMessageBox.Show("Δεν έχετε επιλέξει Κατηγορία.", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error) : Exit Sub
        If Frm.txtFiles.Text = "" Then XtraMessageBox.Show("Δεν έχετε επιλέξει Αρχείο.", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error) : Exit Sub
        Select Case sMode
            Case 0 : sResultF = DBQ.InsertDataFiles(Frm.XtraOpenFileDialog1, Frm.cboTRANSH.EditValue.ToString, "TRANSH_F", ID, "Τοποθετήσεις")
            Case 1 : sResultF = DBQ.InsertDataFilesFromScanner(sFilename, Frm.cboTRANSH.EditValue.ToString, "TRANSH_F", Frm.cboTanshFCategory.EditValue.ToString, ID, "Τοποθετήσεις")
        End Select
        Frm.txtFiles.EditValue = Nothing
        Frm.TRANSH_FTableAdapter.FillByTranshID(Frm.DM_TRANS.TRANSH_F, System.Guid.Parse(Frm.cboTRANSH.EditValue.ToString))
    End Sub

    Public Sub OpenInstEllipseForm(ByVal NewRecord As Boolean)
        Dim frmInstEllipse As New frmInstEllipse
        frmInstEllipse.Text = "Εκκρεμότητες Έργων"
        frmInstEllipse.CalledFromControl = False
        If NewRecord Then
            frmInstEllipse.Mode = FormMode.NewRecord
            frmInstEllipse.INST_ID = ID
            frmInstEllipse.ComeFrom = 0
            frmInstEllipse.Show()
        Else
            frmInstEllipse.Text = "Εκκρεμότητες Έργων"
            frmInstEllipse.Mode = FormMode.EditRecord
            frmInstEllipse.ID = Frm.GridView1.GetRowCellValue(Frm.GridView1.FocusedRowHandle, "ID").ToString
            frmInstEllipse.Scroller = Frm.GridView1
            frmInstEllipse.FormScroller = Frm
            frmInstEllipse.ComeFrom = 1
            frmInstEllipse.ShowDialog()
        End If
    End Sub
    Public Sub SetCostButtonEnabled(ByVal Category As Int16)
        Select Case Category
            Case 0 : If Frm.cboExtPartnerKitchen.EditValue Is Nothing Then Exit Sub
                If sFields("ExtPartnerKitchenID") <> "" And sFields("ExtPartnerKitchenID") = Frm.cboExtPartnerKitchen.EditValue.ToString Then Frm.cmdConstInstK.Enabled = True
            Case 1 : If Frm.cboExtPartnerCloset.EditValue Is Nothing Then Exit Sub
                If sFields("ExtPartnerClosetID") <> "" And sFields("ExtPartnerClosetID") = Frm.cboExtPartnerCloset.EditValue.ToString Then Frm.cmdConstInstC.Enabled = True
            Case 2 : If Frm.cboExtPartnerDoors.EditValue Is Nothing Then Exit Sub
                If sFields("ExtPartnerDoorsID") <> "" And sFields("ExtPartnerDoorsID") = Frm.cboExtPartnerDoors.EditValue.ToString Then Frm.cmdConstInstD.Enabled = True
            Case 3 : If Frm.cboExtPartnerSC.EditValue Is Nothing Then Exit Sub
                If sFields("ExtPartnerSCID") <> "" And sFields("ExtPartnerSCID") = Frm.cboExtPartnerSC.EditValue.ToString Then Frm.cmdConstInstSC.Enabled = True
        End Select
    End Sub
    Public Sub OpenCostForm(ByVal Category As Int16)
        Dim frmInstallationsCost As frmInstallationsCost = New frmInstallationsCost()
        With frmInstallationsCost
            .InstID = ID
            .Form = Frm
            Select Case Category
                Case 0
                    .Kitchen = True
                    .ExtPartner = Frm.cboExtPartnerKitchen.EditValue.ToString
                    If bHasInstCostKitchen = True Then
                        .Mode = FormMode.EditRecord
                    Else
                        .Mode = FormMode.NewRecord
                        .dtDeliverDateF.EditValue = Frm.dtDeliverDateKF.EditValue
                        .dtDeliverDateT.EditValue = Frm.dtDeliverDateKT.EditValue
                        .txtTmIN.EditValue = Frm.txtTmKIN.EditValue
                        .txtTmOUT.EditValue = Frm.txtTmKOUT.EditValue
                    End If
                Case 1
                    .Closet = True
                    .ExtPartner = Frm.cboExtPartnerCloset.EditValue.ToString
                    If bHasInstCostCloset = True Then
                        .Mode = FormMode.EditRecord
                    Else
                        .Mode = FormMode.NewRecord
                        .dtDeliverDateF.EditValue = Frm.dtDeliverDateCF.EditValue
                        .dtDeliverDateT.EditValue = Frm.dtDeliverDateCT.EditValue
                        .txtTmIN.EditValue = Frm.txtTmCIN.EditValue
                        .txtTmOUT.EditValue = Frm.txtTmCOUT.EditValue
                    End If
                Case 2
                    .Doors = True
                    .ExtPartner = Frm.cboExtPartnerDoors.EditValue.ToString
                    If bHasInstCostDoors = True Then
                        .Mode = FormMode.EditRecord
                    Else
                        .Mode = FormMode.NewRecord
                        .dtDeliverDateF.EditValue = Frm.dtDeliverDateDF.EditValue
                        .dtDeliverDateT.EditValue = Frm.dtDeliverDateDT.EditValue
                        .txtTmIN.EditValue = Frm.txtTmDIN.EditValue
                        .txtTmOUT.EditValue = Frm.txtTmDOUT.EditValue
                    End If
                Case 3
                    .SC = True
                    .ExtPartner = Frm.cboExtPartnerSC.EditValue.ToString
                    If bHasInstCostSC = True Then
                        .Mode = FormMode.EditRecord
                    Else
                        .Mode = FormMode.NewRecord
                        .dtDeliverDateF.EditValue = Frm.dtDeliverDateSCF.EditValue
                        .dtDeliverDateT.EditValue = Frm.dtDeliverDateSCT.EditValue
                        .txtTmIN.EditValue = Frm.txtTmSCIN.EditValue
                        .txtTmOUT.EditValue = Frm.txtTmSCOUT.EditValue
                    End If
            End Select
            .ShowDialog()
        End With
    End Sub
    Public Sub UpdateSaleTziroi()
        If XtraMessageBox.Show("Θέλετε να ενημερώσετε τους Τζίρους-Ποσοστά Έκθεσης?", ProgProps.ProgTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            frmSalerTziroi.Text = "Τζίροι-Ποσοστά έκθεσης"
            frmSalerTziroi.ID = sEmpTID
            frmSalerTziroi.MdiParent = frmMain
            frmSalerTziroi.Mode = FormMode.EditRecord
            frmSalerTziroi.FormScrollerExist = False
            frmSalerTziroi.CalledFromControl = False
            frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(frmSalerTziroi), New Point(CInt(frmSalerTziroi.Parent.ClientRectangle.Width / 2 - frmSalerTziroi.Width / 2), CInt(frmSalerTziroi.Parent.ClientRectangle.Height / 2 - frmSalerTziroi.Height / 2)))
            frmSalerTziroi.Show()
        End If
    End Sub
    Public Sub TabMail()
        If Frm.dtDeliverDateKF.EditValue = Nothing Or Frm.txtTmKIN.Text = "00:00" Or Frm.txtTmKOUT.EditValue = "00:00" Then Frm.cmdSendApointmentEmail.Enabled = False Else Frm.cmdSendApointmentEmail.Enabled = True
        Frm.INST_MAILTableAdapter.FillByinstID(Frm.DMDataSet.INST_MAIL, System.Guid.Parse(ID))
        LoadForms.RestoreLayoutFromXml(Frm.GridView3, "INST_MAIL.xml")
        Prog_Prop.GetProgEmailInst()
        Frm.txtTo.EditValue = Frm.cboCUS.GetColumnValue("email")
        Frm.txtSubject.EditValue = ProgProps.InstInfSubject
        Frm.txtBody.EditValue = ProgProps.InstInfAppointmentBody
    End Sub
    'Έλεγχος αν υπάρχει εκκρεμότητα ανολοκλήρωτη
    Public Function CheckIfExistInstEllipse() As Boolean
        Dim Cmd As SqlCommand, sdr As SqlDataReader
        Dim EllipseID As String = ""
        Try
            Cmd = New SqlCommand("Select TOP 1 ID FROM INST_ELLIPSE IE WHERE completed = 0 and IE.instID= " & toSQLValueS(ID), CNDB)
            sdr = Cmd.ExecuteReader()
            If (sdr.Read() = True) Then
                EllipseID = sdr.GetGuid(sdr.GetOrdinal("ID")).ToString.ToUpper
                If EllipseID <> "" Then
                    sdr.Close()
                    Return True
                Else
                    sdr.Close()
                    Return False
                End If
            Else
                sdr.Close()
                Return False
            End If
        Catch ex As Exception
            Return False
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Function
    Private Function CheckIfTimeisValid() As Boolean
        If Frm.txtTmKIN.Text = "00:00" Or Frm.txtTmKOUT.Text = "00:00" Then XtraMessageBox.Show("Η ώρα δεν μπορεί να είναι 00:00", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error) : Return False
        Frm.txtTmKIN.EditValue = Frm.txtTmKIN.Text : Frm.txtTmKOUT.EditValue = Frm.txtTmKOUT.Text
        Dim Hours As Long = DateDiff(DateInterval.Hour, Frm.txtTmKIN.EditValue, Frm.txtTmKOUT.EditValue)
        If Hours < 0 Then XtraMessageBox.Show("Η ώρα ΑΠΟ δεν μπορεί να είναι μικρότερη από την ΕΩΣ", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error) : Return False
        Return True
    End Function
    Public Function CheckIfInstFExist() As Boolean
        Dim sFilename As String = ""
        If Frm.chkCompleted.Checked = True Then
            Dim Cmd As SqlCommand, sdr As SqlDataReader
            Dim sSQL As String = "SELECT fInstName  FROM INST WHERE ID= " & toSQLValueS(ID)
            Cmd = New SqlCommand(sSQL.ToString, CNDB)
            sdr = Cmd.ExecuteReader()
            If (sdr.Read() = True) Then
                If sdr.IsDBNull(sdr.GetOrdinal("fInstName")) = False Then sFilename = sdr.GetString(sdr.GetOrdinal("fInstName"))
                If sFilename = "" Then
                    XtraMessageBox.Show("Δεν μπορείτε να ολοκληρώσετε την Τοποθέτηση χωρίς να επισυνάψετε έντυπο", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
                    sdr.Close()
                    Return False
                Else
                    sdr.Close()
                    Return True
                End If
            Else
                XtraMessageBox.Show("Δεν μπορείτε να ολοκληρώσετε την Τοποθέτηση χωρίς να επισυνάψετε έντυπο", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            End If
        Else
            Return True
        End If
    End Function
    Public Function CheckIfEllipseHasCompleteDocument() As Boolean
        Dim Cmd As SqlCommand, sdr As SqlDataReader
        Dim sSQL As String
        sSQL = "SELECT fInstEllipseNameComplete FROM INST_ELLIPSE WHERE instID= " & toSQLValueS(ID)
        Cmd = New SqlCommand(sSQL.ToString, CNDB)
        sdr = Cmd.ExecuteReader()
        Dim fInstEllipseNameComplete As String
        If (sdr.Read() = True) Then
            If sdr.IsDBNull(sdr.GetOrdinal("fInstEllipseNameComplete")) = False Then fInstEllipseNameComplete = sdr.GetString(sdr.GetOrdinal("fInstEllipseNameComplete")) Else fInstEllipseNameComplete = ""
            If fInstEllipseNameComplete <> "" Then Return True Else Return False
        End If
        sdr.Close()
    End Function

    Public Function CheckIfHasInstNotCompleted()
        Dim Cmd As SqlCommand, sdr As SqlDataReader
        Dim sSQL As String
        sSQL = "SELECT top 1 id FROM INST_ELLIPSE WHERE completed = 0  and instID= " & toSQLValueS(ID)
        Cmd = New SqlCommand(sSQL.ToString, CNDB)
        sdr = Cmd.ExecuteReader()
        Dim EllipseID As String
        If (sdr.Read() = True) Then
            If sdr.IsDBNull(sdr.GetOrdinal("id")) = False Then EllipseID = sdr.GetGuid(sdr.GetOrdinal("id")).ToString Else EllipseID = ""
            If EllipseID <> "" Then Return True Else Return False
        Else
            Return False
        End If
        sdr.Close()

    End Function
    Public Sub OpenFile()
        Try
            Dim Cmd As SqlCommand, sdr As SqlDataReader
            Dim sSQL As String = "SELECT fInst,fInstName  FROM INST WHERE ID= " & toSQLValueS(ID)
            Cmd = New SqlCommand(sSQL.ToString, CNDB)
            sdr = Cmd.ExecuteReader()
            If (sdr.Read() = True) Then
                If sdr.IsDBNull(sdr.GetOrdinal("fInstName")) = False Then
                    Dim sFilename = Path.GetFileName(sdr.GetString(sdr.GetOrdinal("fInstName")))
                    Dim fs As IO.FileStream = New IO.FileStream(ProgProps.TempFolderPath & sFilename, IO.FileMode.Create)
                    Dim b As Byte()
                    b = DirectCast(sdr("fInst"), Byte())
                    fs.Write(b, 0, b.Length)
                    fs.Close()
                    ShellExecute(ProgProps.TempFolderPath & sFilename)
                End If
            End If
            sdr.Close()
        Catch exfs As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", exfs.Message), ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally

        End Try

    End Sub
    Public Sub DeleteFile()
        If XtraMessageBox.Show("Θέλετε να διαγραφεί το αρχείο?", ProgProps.ProgTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            Dim sSQL As String
            sSQL = "UPDATE INST SET completed = 0 ,fInstName =  NULL ,fInst =  NULL where ID = " & toSQLValueS(ID)
            'Εκτέλεση QUERY
            Using oCmd As New SqlCommand(sSQL, CNDB)
                oCmd.ExecuteNonQuery()
            End Using
            Frm.txtInstFilename.EditValue = Nothing : Frm.cmdInstEllipse.Enabled = True : Frm.chkCompleted.CheckState = CheckState.Unchecked
            ' Ενημέρωση έργου σε ΜΗ ολοκληρωμένο
            UpdateTranshToComplete(False)
        End If
    End Sub
    Public Sub FileSelect()
        'XtraOpenFileDialog1.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*"
        Frm.XtraOpenFileDialog1.FilterIndex = 1
        Frm.XtraOpenFileDialog1.InitialDirectory = "C:\"
        Frm.XtraOpenFileDialog1.Title = "Open File"
        Frm.XtraOpenFileDialog1.CheckFileExists = False
        Frm.XtraOpenFileDialog1.Multiselect = False
        Dim result As DialogResult = Frm.XtraOpenFileDialog1.ShowDialog()
        If result = DialogResult.OK Then
            Frm.txtInstFilename.EditValue = Frm.XtraOpenFileDialog1.FileName
            Dim sSQL As String
            Try
                My.Computer.FileSystem.CopyFile(Frm.XtraOpenFileDialog1.FileName, ProgProps.ServerPath & Path.GetFileName(Frm.XtraOpenFileDialog1.FileName), True)

                sSQL = "UPDATE INST SET completed = 1, fInstName =  " & toSQLValueS(Path.GetFileName(Frm.XtraOpenFileDialog1.FileName).ToString) & ",fInst =  BulkColumn from Openrowset( Bulk " & toSQLValueS(ProgProps.ServerPath & Path.GetFileName(Frm.XtraOpenFileDialog1.FileName)) & ", Single_Blob) as InstF where ID = " & toSQLValueS(ID)
                'Εκτέλεση QUERY
                Using oCmd As New SqlCommand(sSQL, CNDB)
                    oCmd.ExecuteNonQuery()
                End Using
                Frm.chkCompleted.CheckState = CheckState.Checked : Frm.cmdInstEllipse.Enabled = False
                XtraMessageBox.Show("Το αρχείο αποθηκεύτηκε με επιτυχία", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Frm.cmdInstEllipse.Enabled = False
                ' Ενημέρωση έργου σε ολοκληρωμένο
                UpdateTranshToComplete(True)
            Catch ex As Exception
                XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

        End If
    End Sub
    Private Sub UpdateTranshToComplete(ByVal Completed As Boolean)
        Dim sSQL As String
        Try
            If Completed Then
                sSQL = "UPDATE TRANSH SET completed = 1 where ID = " & toSQLValueS(Frm.cboTRANSH.EditValue.ToString)
            Else
                sSQL = "UPDATE TRANSH SET completed = 0 where ID = " & toSQLValueS(Frm.cboTRANSH.EditValue.ToString)
            End If
            'Εκτέλεση QUERY
            Using oCmd As New SqlCommand(sSQL, CNDB)
                oCmd.ExecuteNonQuery()
            End Using
        Catch ex As Exception
            If Completed Then
                XtraMessageBox.Show("Παρουσιάστηκε πρόβλημα κατα την ενημέρωση του έργου σε ολοκληρωμένο: " & String.Format("Error: {0}", ex.Message), ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                XtraMessageBox.Show("Παρουσιάστηκε πρόβλημα κατα την ενημέρωση του έργου σε μη ολοκληρωμένο: " & String.Format("Error: {0}", ex.Message), ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End Try
    End Sub
    Private Sub ShellExecute(ByVal File As String)
        Dim myProcess As New Process
        myProcess.StartInfo.FileName = File
        myProcess.StartInfo.UseShellExecute = True
        myProcess.StartInfo.RedirectStandardOutput = False
        myProcess.Start()
        myProcess.Dispose()
    End Sub
    Public Sub ValidateEmail()
        If Frm.txtBody.Text = "" Then XtraMessageBox.Show("Παρακαλώ συμπληρώστε κείμενο", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error) : Exit Sub
        If Frm.txtSubject.Text = "" Then XtraMessageBox.Show("Παρακαλώ συμπληρώστε το θέμα", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error) : Exit Sub
        If Frm.txtTo.Text = "" Then XtraMessageBox.Show("Δεν υπάρχει καταχωρήμενο email στον πελάτη.", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error) : Exit Sub
        If XtraMessageBox.Show("Θέλετε να αποσταλεί το Email?", ProgProps.ProgTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            SendEmail()
            Frm.INST_MAILTableAdapter.FillByinstID(Frm.DMDataSet.INST_MAIL, System.Guid.Parse(ID))
        End If
    End Sub
    Private Sub SendEmail()
        Dim Cmd As SqlCommand, sdr As SqlDataReader
        Dim Emails As New SendEmail
        Dim statusMsg As String = ""
        Dim sEmailTo As String
        Dim sSubject As String
        Dim sBody As String
        Dim sFile As String = ""
        Dim sSQL As String
        Try



            sEmailTo = Frm.txtTo.EditValue
            sBody = Frm.txtBody.EditValue
            sSubject = Frm.txtSubject.EditValue
            sBody = sBody.Replace("{INST_DATE_DELIVERED}", Date.Now.Date)

            ' sEmailTo = "dreamykitchen@gmail.com"
            ' sEmailTo = "johnmavroselinos@gmail.com"


            If Emails.SendEmail(ProgProps.InstEmailAccount, sSubject, sBody, sEmailTo, sFile, statusMsg) = True Then
                sSQL = "Update INST SET emailApp = 1,DateOfEmailApp=getdate() WHERE ID = " & toSQLValueS(ID)


                Cmd = New SqlCommand(sSQL, CNDB) : Cmd.ExecuteNonQuery()

                ' Εισαγωγή ιστορικού email
                sSQL = "INSERT INTO INST_MAIL (instID,emailFrom,emailTo,emailSubject,emailBody,DateofEmail,[createdBy],[createdOn],emailMode,ComeFrom)  
                        values (" & toSQLValueS(ID) & "," & toSQLValueS(ProgProps.InstEmailAccount.ToString) & "," &
                                    toSQLValue(Frm.txtTo) & "," & toSQLValue(Frm.txtSubject) & "," &
                                    toSQLValue(Frm.txtBody) & ",getdate(), " &
                                    toSQLValueS(UserProps.ID.ToString) & ", getdate(),0,0 )"
                Using oCmd As New SqlCommand(sSQL, CNDB)
                    oCmd.ExecuteNonQuery()
                End Using


                XtraMessageBox.Show("Το email στάλθηκε με επιτυχία", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                XtraMessageBox.Show("Παρουσιάστηκε πρόβλημα με σφάλμα " & statusMsg, ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub LoadRecords()
        Dim sSQL As String = "SELECT  * FROM vw_INST_ELLIPSE where instID = " & toSQLValueS(ID)
        Dim sSQL2 As String = "SELECT  * FROM  INST_ELLIPSE_JOBS where instID = " & toSQLValueS(ID)
        Dim AdapterMaster As New SqlDataAdapter(sSQL, CNDB)
        Dim AdapterDetail As New SqlDataAdapter(sSQL2, CNDB)
        Dim sdataSet As New DataSet()
        AdapterMaster.Fill(sdataSet, "vw_INST_ELLIPSE")
        AdapterDetail.Fill(sdataSet, "INST_ELLIPSE_JOBS")
        Dim keyColumn As DataColumn = sdataSet.Tables("vw_INST_ELLIPSE").Columns("ID")
        Dim foreignKeyColumn As DataColumn = sdataSet.Tables("INST_ELLIPSE_JOBS").Columns("instEllipseID")
        sdataSet.Relations.Add("Εκκρεμότητες", keyColumn, foreignKeyColumn, False)
        Frm.GridView1.Columns.Clear() : Frm.GridView2.Columns.Clear()
        Frm.grdMain.DataSource = sdataSet.Tables("vw_INST_ELLIPSE")
        Frm.grdMain.ForceInitialize()
        If Frm.grdMain.LevelTree.Nodes.Count = 1 Then
            Dim GrdView As New GridView(Frm.grdMain)
            Frm.grdMain.LevelTree.Nodes.Add("Εκκρεμότητες", Frm.GridView2)
            'Specify text to be displayed within detail tabs.
            GrdView.ViewCaption = "Εκκρεμότητες"
        End If
        LoadForms.RestoreLayoutFromXml(Frm.GridView1, "vw_INST_ELLIPSE_INSIDE.xml")
        LoadForms.RestoreLayoutFromXml(Frm.GridView2, "D_INST_ELLIPSE_JOBS_INSIDE.xml")
    End Sub
    Public Sub InstEllipseDelete()
        Dim sSQL As String
        If UserProps.AllowDelete = False Then Exit Sub
        If XtraMessageBox.Show("Θέλετε να διαγραφεί η εκκρεμότητα?", ProgProps.ProgTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            Dim Cmd As SqlCommand, sdr As SqlDataReader
            sSQL = "SELECT count (id) as CountEllipse  FROM INST_ELLIPSE WHERE comefrom= 0 and instID= " & toSQLValueS(Frm.GridView1.GetRowCellValue(Frm.GridView1.FocusedRowHandle, "instID").ToString) &
                    " and DATEADD(ms, -DATEPART(ms, createdOn), createdOn)> " & toSQLValueS(DateTime.Parse(Frm.GridView1.GetRowCellValue(Frm.GridView1.FocusedRowHandle, "createdOn")).ToString("yyyy-MM-dd HH:mm:ss.fff"))
            Cmd = New SqlCommand(sSQL.ToString, CNDB)
            sdr = Cmd.ExecuteReader()
            Dim CountEllipse As Integer
            If (sdr.Read() = True) Then
                If sdr.IsDBNull(sdr.GetOrdinal("CountEllipse")) = False Then CountEllipse = sdr.GetInt32(sdr.GetOrdinal("CountEllipse")) Else CountEllipse = 0
                If CountEllipse > 0 Then
                    XtraMessageBox.Show("Δεν μπορείτε να διαγράψετε έλλειψη όταν υπάρχει κι αλλη έλλειψη για το έργο σε μεταγενέστερη ημερομηνία.", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
                    sdr.Close()
                    Exit Sub
                Else
                    Try
                        sSQL = "DELETE FROM INST_ELLIPSE WHERE ID = '" & Frm.GridView1.GetRowCellValue(Frm.GridView1.FocusedRowHandle, "ID").ToString & "'"
                        Using oCmd As New SqlCommand(sSQL, CNDB)
                            oCmd.ExecuteNonQuery()
                        End Using
                    Catch ex As SqlException
                        If ex.ErrorCode = -2146232060 Then
                            XtraMessageBox.Show("Δεν μπορεί να διαγραφέι η εκκρεμότητα από την στιγμή που έχει αποσταλεί Email", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Else
                            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If

                    End Try
                    LoadRecords()
                End If
            Else
                XtraMessageBox.Show("Παρουσιάστηκε κάποιο πρόβλημα στην ανάγνωση εγγραφών.", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
                sdr.Close()
                Exit Sub
            End If
        End If
    End Sub

End Class
