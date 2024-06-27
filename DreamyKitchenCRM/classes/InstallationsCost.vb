﻿Imports DevExpress.XtraEditors
Imports System.Data.SqlClient

Public Class InstallationsCost
    Private Prog_Prop As New ProgProp
    Private ID As String
    Private sInstID As String
    Private sTRANSH_ID As String
    Private bKitchen As Boolean
    Private bCloset As Boolean
    Private bDoors As Boolean
    Private bSC As Boolean
    Private Ctrl As DevExpress.XtraGrid.Views.Grid.GridView
    Public Mode As Byte
    Private Valid As New ValidateControls
    Private FillCbo As New FillCombos
    Private DBQ As New DBQueries
    Private LoadForms As New FormLoader
    Private Cls As New ClearControls
    Private CtrlCombo As DevExpress.XtraEditors.LookUpEdit
    Private CalledFromCtrl As Boolean
    Private UserPermissions As New CheckPermissions
    Private Frm As frmInstallationsCost
    Public Sub Initialize(ByVal sFrm As frmInstallationsCost, ByVal sInstCostID As String, ByVal InstID As String, ByVal sMode As Byte,
                          ByVal Kitchen As Boolean, Closet As Boolean, Doors As Boolean, SC As Boolean)
        Frm = sFrm
        ID = sInstCostID
        sInstID = InstID
        Mode = sMode
        bKitchen = Kitchen
        bCloset = Closet
        bDoors = Doors
        bSC = SC
        Dim sSQL = New System.Text.StringBuilder
        sSQL.AppendLine("select CCT.id,CCT.Fullname,'00000000-0000-0000-0000-000000000000' as SalerID,phn,AdrID,email,isCompany from CCT INNER JOIN INST ON INST.cusID = CCT.ID Where INST.ID = " & toSQLValueS(InstID))
        FillCbo.CUS(Frm.cboCUS, sSQL)
        sSQL.Clear()
        sSQL.AppendLine("select T.id,T.FullTranshDescription from vw_transh T INNER JOIN INST ON INST.transhID = T.ID Where INST.ID = " & toSQLValueS(InstID))
        FillCbo.TRANSH(Frm.cboTRANSH, sSQL)
        sSQL.Clear()
        If bKitchen = True Then
            sSQL.AppendLine("select  EMP.ID,Fullname  from EMP inner join INST_SER on INST_SER.empID = EMP.ID where externalPartner = 1 and  kitchen=1  and instID = " & toSQLValueS(InstID))
            Frm.chkHasKitchen.CheckState = CheckState.Checked : Frm.chkHasKitchen.ReadOnly = True
        End If
        If bCloset = True Then
            sSQL.AppendLine("select  EMP.ID,Fullname  from EMP inner join INST_SER on INST_SER.empID = EMP.ID where externalPartner = 1 and  Closet=1  and instID = " & toSQLValueS(InstID))
            Frm.chkHasCloset.CheckState = CheckState.Checked : Frm.chkHasCloset.ReadOnly = True
        End If
        If bDoors = True Then
            sSQL.AppendLine("select  EMP.ID,Fullname  from EMP inner join INST_SER on INST_SER.empID = EMP.ID where externalPartner = 1 and  doors=1  and instID = " & toSQLValueS(InstID))
            Frm.chkHasDoors.CheckState = CheckState.Checked : Frm.chkHasDoors.ReadOnly = True
        End If
        If bSC = True Then
            sSQL.AppendLine("select  EMP.ID,Fullname  from EMP inner join INST_SER on INST_SER.empID = EMP.ID where externalPartner = 1 and  sc=1  and instID = " & toSQLValueS(InstID))
            Frm.chkHasSC.CheckState = CheckState.Checked : Frm.chkHasSC.ReadOnly = True
        End If
        FillCbo.EMP(Frm.cboExternalPartners, sSQL)

    End Sub
    Public Sub LoadForm()
        Select Case Mode
            Case FormMode.NewRecord
                Frm.txtCode.Text = DBQ.GetNextId("INST_COST")
            Case FormMode.EditRecord
                LoadForms.LoadForm(Frm.LayoutControl1, "Select * from INST_COST where id ='" + ID + "'")
        End Select
        UserPermissions.GetUserPermissions(Frm.Text)
        Frm.cmdSave.Enabled = IIf(Mode = FormMode.NewRecord, UserProps.AllowInsert, UserProps.AllowEdit)


    End Sub
    Public Sub SaveRecord(ByRef sID As String)
        Dim sResult As Boolean
        Dim sGuid As String
        Try
            If Valid.ValidateForm(Frm.LayoutControl1) Then
                Valid.ID = Frm.cboTRANSH.EditValue.ToString
                If Valid.ValiDationRules(Frm.Name, Frm) = False Then Exit Sub
                Select Case Mode
                    Case FormMode.NewRecord
                        sGuid = System.Guid.NewGuid.ToString
                        sResult = DBQ.InsertNewData(DBQueries.InsertMode.OneLayoutControl, "INST_COST", Frm.LayoutControl1,,, sGuid)
                        ID = sGuid : sID = sGuid
                    Case FormMode.EditRecord
                        sResult = DBQ.UpdateNewData(DBQueries.InsertMode.OneLayoutControl, "INST_COST", Frm.LayoutControl1,,, sID)
                        ID = sID
                End Select

                XtraMessageBox.Show("Η εγγραφή αποθηκέυτηκε με επιτυχία", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
