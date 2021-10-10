﻿
Imports System.Data.SqlClient
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls

Public Class frmEmpPayroll
    Private sID As String
    Private bIsConstr As Boolean
    Private Ctrl As DevExpress.XtraGrid.Views.Grid.GridView
    Private Frm As DevExpress.XtraEditors.XtraForm
    Public Mode As Byte
    Private Valid As New ValidateControls
    Private FScrollerExist As Boolean = False
    Private Log As New Transactions
    Private FillCbo As New FillCombos
    Private DBQ As New DBQueries
    Private LoadForms As New FormLoader
    Private Cls As New ClearControls
    Private CtrlCombo As DevExpress.XtraEditors.LookUpEdit
    Private CalledFromCtrl As Boolean

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
    Public WriteOnly Property FormScrollerExist As Boolean
        Set(value As Boolean)
            FScrollerExist = value
        End Set
    End Property
    Public WriteOnly Property IsConstr As Boolean
        Set(value As Boolean)
            bIsConstr = value
        End Set
    End Property
    Private Sub cmdExit_Click(sender As Object, e As EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub

    Private Sub frmEmpPayroll_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim sSQL As New System.Text.StringBuilder
        If bIsConstr = True Then
            sSQL.AppendLine("Select id,Fullname,salary  from vw_EMP where depID='16228C6D-FAE6-4CFD-82D1-A9910D909952' order by Fullname")
        Else
            sSQL.AppendLine("Select id,Fullname,salary  from vw_EMP where depID='9812E975-2FD4-4653-B043-3D6CAF440888' order by Fullname")
        End If

        FillCbo.EMP(cboEMP, sSQL)
        FillCbo.EMP_M_S(cboEMP_M_S)
        FillCbo.BANKS(cboBANK)
        Select Case Mode
            Case FormMode.NewRecord
                txtCode.Text = DBQ.GetNextId("EMP_M")
            Case FormMode.EditRecord
                LoadForms.LoadForm(LayoutControl1, "Select * from vw_EMP_M   where id ='" + sID & "'")
        End Select
        Me.CenterToScreen()
        My.Settings.frmEmpPayroll = Me.Location
        My.Settings.Save()
        cmdSave.Enabled = IIf(Mode = FormMode.NewRecord, UserProps.AllowInsert, UserProps.AllowEdit)
    End Sub

    Private Sub cboEMP_EditValueChanged(sender As Object, e As EventArgs) Handles cboEMP.EditValueChanged
        txtSalary.EditValue = cboEMP.GetColumnValue("salary")
    End Sub

    Private Sub frmEmpPayroll_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        If Me.WindowState = FormWindowState.Maximized Then frmMain.XtraTabbedMdiManager1.Dock(Me, frmMain.XtraTabbedMdiManager1)
    End Sub
    Private Sub ManageEMP()
        Dim form1 As frmEMP = New frmEMP()
        form1.Text = "Προσωπικό"
        form1.CallerControl = cboEMP
        form1.CalledFromControl = True
        form1.MdiParent = frmMain
        If cboEMP.EditValue <> Nothing Then
            form1.ID = cboEMP.EditValue.ToString
            form1.Mode = FormMode.EditRecord
        Else
            form1.Mode = FormMode.NewRecord
        End If
        frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(form1), New Point(CInt(form1.Parent.ClientRectangle.Width / 2 - form1.Width / 2), CInt(form1.Parent.ClientRectangle.Height / 2 - form1.Height / 2)))
        form1.Show()
    End Sub
    Private Sub ManageEMP_M_S()
        Dim form1 As frmGen = New frmGen()
        form1.Text = "Status Μισθοδοσίας"
        form1.L1.Text = "Κωδικός"
        form1.L2.Text = "Status"
        form1.DataTable = "EMP_M_S"
        form1.CalledFromControl = True
        form1.CallerControl = cboEMP_M_S
        If cboEMP_M_S.EditValue <> Nothing Then form1.ID = cboEMP_M_S.EditValue.ToString
        form1.MdiParent = frmMain
        If cboEMP_M_S.EditValue <> Nothing Then form1.Mode = FormMode.EditRecord Else form1.Mode = FormMode.NewRecord
        frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(form1), New Point(CInt(form1.Parent.ClientRectangle.Width / 2 - form1.Width / 2), CInt(form1.Parent.ClientRectangle.Height / 2 - form1.Height / 2)))
        form1.Show()
    End Sub

    Private Sub cboEMP_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboEMP.ButtonClick
        Select Case e.Button.Index
            Case 1 : cboEMP.EditValue = Nothing : ManageEMP()
            Case 2 : If cboEMP.EditValue <> Nothing Then ManageEMP()
            Case 3 : cboEMP.EditValue = Nothing
        End Select

    End Sub

    Private Sub cboEMP_M_S_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboEMP_M_S.ButtonClick
        Select Case e.Button.Index
            Case 1 : cboEMP_M_S.EditValue = Nothing : ManageEMP_M_S()
            Case 2 : If cboEMP_M_S.EditValue <> Nothing Then ManageEMP_M_S()
            Case 3 : cboEMP_M_S.EditValue = Nothing
        End Select
    End Sub

    Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click
        Dim sResult As Boolean
        Dim sGuid As String
        Dim sSQL As New System.Text.StringBuilder
        Try
            If Valid.ValidateForm(LayoutControl1) Then
                Select Case Mode
                    Case FormMode.NewRecord
                        sGuid = System.Guid.NewGuid.ToString
                        sResult = DBQ.InsertNewData(DBQueries.InsertMode.OneLayoutControl, "EMP_M", LayoutControl1,,, sGuid, True, "isConstr", IIf(bIsConstr = False, 0, 1))
                    Case FormMode.EditRecord
                        sResult = DBQ.UpdateNewData(DBQueries.InsertMode.OneLayoutControl, "EMP_M", LayoutControl1,,, sID, True,,,, "isConstr = " & IIf(bIsConstr = False, 0, 1))
                        sGuid = sID
                End Select
                If FScrollerExist = True Then
                    Dim form As frmScroller = Frm
                    form.DataTableWhereCondition = IIf(bIsConstr = True, "where depid='16228C6D-FAE6-4CFD-82D1-A9910D909952'", "where depid='9812E975-2FD4-4653-B043-3D6CAF440888'")
                    form.LoadRecords("vw_EMP_M")
                End If

                If sResult = True Then XtraMessageBox.Show("Η εγγραφή αποθηκέυτηκε με επιτυχία", "Dreamy Kitchen CRM", MessageBoxButtons.OK, MessageBoxIcon.Information)
                If Mode = FormMode.NewRecord Then
                    Cls.ClearCtrls(LayoutControl1)
                    txtCode.Text = DBQ.GetNextId("EMP_M")
                End If
            End If

        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), "Dreamy Kitchen CRM", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cboBANK_EditValueChanged(sender As Object, e As EventArgs) Handles cboBANK.EditValueChanged
        If cboBANK.EditValue IsNot Nothing Then chkCash.Enabled = False : chkCash.Checked = False Else chkCash.Enabled = True
    End Sub
    Private Sub cboBANK_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboBANK.ButtonClick
        Select Case e.Button.Index
            Case 1 : cboBANK.EditValue = Nothing : ManageBank()
            Case 2 : If cboBANK.EditValue <> Nothing Then ManageBank()
            Case 3 : cboBANK.EditValue = Nothing
        End Select
    End Sub
    Private Sub ManageBank()
        Dim form1 As frmGen = New frmGen()
        form1.Text = "Τράπεζες"
        form1.L1.Text = "Κωδικός"
        form1.L2.Text = "Τράπεζα"
        form1.DataTable = "BANKS"
        form1.CalledFromControl = True
        form1.CallerControl = cboBANK
        If cboBANK.EditValue <> Nothing Then form1.ID = cboBANK.EditValue.ToString
        form1.MdiParent = frmMain
        If cboBANK.EditValue <> Nothing Then form1.Mode = FormMode.EditRecord Else form1.Mode = FormMode.NewRecord
        frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(form1), New Point(CInt(form1.Parent.ClientRectangle.Width / 2 - form1.Width / 2), CInt(form1.Parent.ClientRectangle.Height / 2 - form1.Height / 2)))
        form1.Show()
    End Sub
End Class