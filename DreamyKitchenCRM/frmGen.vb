﻿Imports System.Data.SqlClient
Imports System.IO
Imports System.Threading
Imports DevExpress.CodeParser
Imports DevExpress.XtraEditors
Imports DevExpress.XtraExport.Xls
Public Class frmGen
    Private sID As String
    Private Ctrl As DevExpress.XtraGrid.Views.Grid.GridView
    Private CtrlCombo As DevExpress.XtraEditors.LookUpEdit
    Private Frm As DevExpress.XtraEditors.XtraForm
    Public Mode As Byte
    Private CalledFromCtrl As Boolean
    Private Valid As New ValidateControls
    Private Log As New Transactions
    Private DBQ As New DBQueries
    Private FillCbo As New FillCombos
    Private sDataTable As String
    Private S As New System.Text.StringBuilder
    Private Cls As New ClearControls
    Private LoadForms As New FormLoader

    Public WriteOnly Property ID As String
        Set(value As String)
            sID = value
        End Set
    End Property
    Public WriteOnly Property Scroller As DevExpress.XtraGrid.Views.Grid.GridView
        Set(value As DevExpress.XtraGrid.Views.Grid.GridView)
            Ctrl = value
        End Set
    End Property
    Public WriteOnly Property FormScroller As DevExpress.XtraEditors.XtraForm
        Set(value As DevExpress.XtraEditors.XtraForm)
            Frm = value
        End Set
    End Property
    Public WriteOnly Property CallerControl As DevExpress.XtraEditors.LookUpEdit
        Set(value As DevExpress.XtraEditors.LookUpEdit)
            CtrlCombo = value
        End Set
    End Property
    Public WriteOnly Property CalledFromControl As Boolean
        Set(value As Boolean)
            CalledFromCtrl = value
        End Set
    End Property

    Public WriteOnly Property DataTable As String
        Set(value As String)
            sDataTable = value
        End Set
    End Property

    Private Sub cmdExit_Click(sender As Object, e As EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub

    Private Sub frmGen_Load(sender As Object, e As EventArgs) Handles Me.Load
        LoadGen()
        Me.CenterToScreen()
        My.Settings.frmGen = Me.Location
        My.Settings.Save()
    End Sub

    Private Sub cmdNew_Click(sender As Object, e As EventArgs) Handles cmdNew.Click
        Mode = FormMode.NewRecord
        LoadGen()
        txtName.Text = ""
        cbo1.EditValue = Nothing
        cbo2.EditValue = Nothing
    End Sub

    Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click
        Dim sGuid As String
        Dim sResult As Boolean
        Try
            If Valid.ValidateForm(LayoutControl1) Then
                Select Case Mode
                    Case FormMode.NewRecord
                        Select Case sDataTable
                            Case "COU"
                                sGuid = System.Guid.NewGuid.ToString
                                sResult = DBQ.InsertData(LayoutControl1, "COU", sGuid)
                                If CalledFromCtrl Then
                                    FillCbo.COU(CtrlCombo)
                                    CtrlCombo.EditValue = System.Guid.Parse(sGuid)
                                Else
                                    Dim form As frmScroller = Frm
                                    form.LoadRecords("vw_COU")
                                End If
                                'Καθαρισμός Controls
                                Cls.ClearCtrls(LayoutControl1)
                                txtCode.Text = DBQ.GetNextId("COU")
                            Case "AREAS"
                                sGuid = System.Guid.NewGuid.ToString
                                sResult = DBQ.InsertData(LayoutControl1, "AREAS", sGuid)
                                If CalledFromCtrl Then
                                    FillCbo.AREAS(CtrlCombo, S)
                                    CtrlCombo.EditValue = System.Guid.Parse(sGuid)
                                Else
                                    Dim form As frmScroller = Frm
                                    form.LoadRecords("vw_AREAS")
                                End If
                                'Καθαρισμός Controls
                                Cls.ClearCtrls(LayoutControl1)
                                txtCode.Text = DBQ.GetNextId("AREAS")
                            Case "ADR"
                                sGuid = System.Guid.NewGuid.ToString
                                sResult = DBQ.InsertData(LayoutControl1, "ADR", sGuid)
                                If CalledFromCtrl Then
                                    FillCbo.ADR(CtrlCombo, S)
                                    CtrlCombo.EditValue = System.Guid.Parse(sGuid)
                                Else
                                    Dim form As frmScroller = Frm
                                    form.LoadRecords("vw_ADR")
                                End If
                                'Καθαρισμός Controls
                                Cls.ClearCtrls(LayoutControl1)
                                txtCode.Text = DBQ.GetNextId("ADR")
                            Case "DOY"
                                sGuid = System.Guid.NewGuid.ToString
                                sResult = DBQ.InsertData(LayoutControl1, "DOY", sGuid)
                                If CalledFromCtrl Then
                                    FillCbo.DOY(CtrlCombo)
                                    CtrlCombo.EditValue = System.Guid.Parse(sGuid)
                                Else
                                    Dim form As frmScroller = Frm
                                    form.LoadRecords("vw_DOY")
                                End If
                                'Καθαρισμός Controls
                                Cls.ClearCtrls(LayoutControl1)
                                txtCode.Text = DBQ.GetNextId("DOY")
                            Case "PRF"
                                sGuid = System.Guid.NewGuid.ToString
                                sResult = DBQ.InsertData(LayoutControl1, "PRF", sGuid)
                                If CalledFromCtrl Then
                                    FillCbo.PRF(CtrlCombo)
                                    CtrlCombo.EditValue = System.Guid.Parse(sGuid)
                                Else
                                    Dim form As frmScroller = Frm
                                    form.LoadRecords("vw_PRF")
                                End If
                                'Καθαρισμός Controls
                                Cls.ClearCtrls(LayoutControl1)
                                txtCode.Text = DBQ.GetNextId("PRF")
                        End Select
                    Case FormMode.EditRecord
                        Select Case sDataTable
                            Case "COU"
                                sResult = DBQ.UpdateData(LayoutControl1, "COU", sID)
                                If CalledFromCtrl Then
                                    FillCbo.COU(CtrlCombo)
                                    CtrlCombo.EditValue = System.Guid.Parse(sID)
                                Else
                                    Dim form As frmScroller = Frm
                                    form.LoadRecords("vw_COU")
                                End If
                            Case "AREAS"
                                sResult = DBQ.UpdateData(LayoutControl1, "AREAS", sID)
                                If CalledFromCtrl Then
                                    FillCbo.AREAS(CtrlCombo, S)
                                    CtrlCombo.EditValue = System.Guid.Parse(sID)
                                Else
                                    Dim form As frmScroller = Frm
                                    form.LoadRecords("vw_AREAS")
                                End If
                            Case "ADR"
                                sResult = DBQ.UpdateData(LayoutControl1, "ADR", sID)
                                If CalledFromCtrl Then
                                    FillCbo.ADR(CtrlCombo, S)
                                    CtrlCombo.EditValue = System.Guid.Parse(sID)
                                Else
                                    Dim form As frmScroller = Frm
                                    form.LoadRecords("vw_ADR")
                                End If
                            Case "DOY"
                                sResult = DBQ.UpdateData(LayoutControl1, "DOY", sID)
                                If CalledFromCtrl Then
                                    FillCbo.DOY(CtrlCombo)
                                    CtrlCombo.EditValue = System.Guid.Parse(sID)
                                Else
                                    Dim form As frmScroller = Frm
                                    form.LoadRecords("vw_DOY")
                                End If
                            Case "PRF"
                                sResult = DBQ.UpdateData(LayoutControl1, "PRF", sID)
                                If CalledFromCtrl Then
                                    FillCbo.PRF(CtrlCombo)
                                    CtrlCombo.EditValue = System.Guid.Parse(sID)
                                Else
                                    Dim form As frmScroller = Frm
                                    form.LoadRecords("vw_PRF")
                                End If
                        End Select
                End Select
                If sResult Then XtraMessageBox.Show("Η εγγραφή αποθηκέυτηκε με επιτυχία", "PRIAMOS .NET", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), "PRIAMOS .NET", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub LoadGen()
        Select Case sDataTable
            Case "COU"
                If Mode = FormMode.NewRecord Then
                    txtCode.Text = DBQ.GetNextId("COU")
                Else
                    LoadForms.LoadForm(LayoutControl1, "Select * from vw_COU where id ='" + sID + "'")
                End If
            Case "AREAS"
                FillCbo.COU(cbo1)
                If Mode = FormMode.NewRecord Then
                    txtCode.Text = DBQ.GetNextId("AREAS")
                Else
                    LoadForms.LoadForm(LayoutControl1, "Select * from vw_AREAS where id ='" + sID + "'")
                End If
            Case "ADR"
                FillCbo.COU(cbo1)
                Dim sSQL As New System.Text.StringBuilder
                FillCbo.AREAS(cbo2, sSQL)
                If Mode = FormMode.NewRecord Then
                    txtCode.Text = DBQ.GetNextId("ADR")
                Else
                    LoadForms.LoadForm(LayoutControl1, "Select * from vw_ADR where id ='" + sID + "'")
                End If
            Case "DOY"
                If Mode = FormMode.NewRecord Then
                    txtCode.Text = DBQ.GetNextId("DOY")
                Else
                    LoadForms.LoadForm(LayoutControl1, "Select * from vw_DOY where id ='" + sID + "'")
                End If
            Case "PRF"
                If Mode = FormMode.NewRecord Then
                    txtCode.Text = DBQ.GetNextId("PRF")
                Else
                    LoadForms.LoadForm(LayoutControl1, "Select * from vw_PRF where id ='" + sID + "'")
                End If
        End Select
        cmdSave.Enabled = IIf(Mode = FormMode.NewRecord, UserProps.AllowInsert, UserProps.AllowEdit)
        cmdDelete.Enabled = IIf(Mode = FormMode.NewRecord, False, UserProps.AllowDelete)

    End Sub

    Private Sub cmdDelete_Click(sender As Object, e As EventArgs) Handles cmdDelete.Click
        DeleteRecord()
    End Sub
    'Διαγραφη Εγγραφής
    Private Sub DeleteRecord()
        Dim sSQL As String
        Try
            If XtraMessageBox.Show("Θέλετε να διαγραφεί η τρέχουσα εγγραφή?", "PRIAMOS .NET", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                sSQL = "DELETE FROM " & sDataTable & " WHERE ID = " & toSQLValueS(sID)
                Using oCmd As New SqlCommand(sSQL, CNDB)
                    oCmd.ExecuteNonQuery()
                End Using
                Select Case sDataTable
                    Case "COU"
                        If CalledFromCtrl Then
                            FillCbo.COU(CtrlCombo)
                        Else
                            Dim form As frmScroller = Frm
                            form.LoadRecords("vw_COU")
                        End If
                    Case "AREAS"
                        If CalledFromCtrl Then
                            FillCbo.AREAS(CtrlCombo, S)
                        Else
                            Dim form As frmScroller = Frm
                            form.LoadRecords("vw_AREAS")
                        End If
                    Case "ADR"
                        If CalledFromCtrl Then
                            FillCbo.ADR(CtrlCombo, S)
                        Else
                            Dim form As frmScroller = Frm
                            form.LoadRecords("vw_ADR")
                        End If
                    Case "DOY"
                        If CalledFromCtrl Then
                            FillCbo.DOY(CtrlCombo)
                        Else
                            Dim form As frmScroller = Frm
                            form.LoadRecords("vw_DOY")
                        End If
                    Case "PRF"
                        If CalledFromCtrl Then
                            FillCbo.PRF(CtrlCombo)
                        Else
                            Dim form As frmScroller = Frm
                            form.LoadRecords("vw_PRF")
                        End If
                End Select
                Cls.ClearCtrls(LayoutControl1)
                txtCode.Text = DBQ.GetNextId(sDataTable)
                If CalledFromCtrl Then CtrlCombo.EditValue = Nothing

                XtraMessageBox.Show("Η εγγραφή διαγράφηκε με επιτυχία", "PRIAMOS .NET", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), "PRIAMOS .NET", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cbo1_GotFocus(sender As Object, e As EventArgs) Handles cbo1.GotFocus
        frmMain.bbFields.Caption = "DB Field: " & sDataTable & ".couid"
    End Sub

    Private Sub cbo2_GotFocus(sender As Object, e As EventArgs) Handles cbo2.GotFocus
        frmMain.bbFields.Caption = "DB Field: " & sDataTable & ".areaid"
    End Sub

    Private Sub txtCode_GotFocus(sender As Object, e As EventArgs) Handles txtCode.GotFocus
        frmMain.bbFields.Caption = "DB Field: " & sDataTable & ".code"
    End Sub

    Private Sub txtName_GotFocus(sender As Object, e As EventArgs) Handles txtName.GotFocus
        frmMain.bbFields.Caption = "DB Field: " & sDataTable & ".name"
    End Sub
End Class