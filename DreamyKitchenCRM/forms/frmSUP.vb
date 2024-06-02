Imports System.Data.SqlClient
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls

Public Class frmSUP
    Private sID As String
    Private Ctrl As DevExpress.XtraGrid.Views.Grid.GridView
    Private Frm As DevExpress.XtraEditors.XtraForm
    Public Mode As Byte
    Private Valid As New ValidateControls
    Private Log As New Transactions
    Private FillCbo As New FillCombos
    Private FScrollerExist As Boolean = False
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

    Private Sub frmSUP_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim sSQL As New System.Text.StringBuilder
        'Νομοί
        FillCbo.COU(cboCOU)
        FillCbo.PAY(cboPAY)
        FillCbo.PRF(cboPRF)
        FillCbo.DOY(cboDOY)
        Select Case Mode
            Case FormMode.NewRecord
                'dtDTS.EditValue = DateTime.Now
                txtCode.Text = DBQ.GetNextId("SUP")
            Case FormMode.EditRecord
                If cboCOU.EditValue isnot Nothing Then sSQL.AppendLine(" where couid = " & toSQLValueS(cboCOU.EditValue.ToString))
                FillCbo.AREAS(cboAREAS, sSQL)
                LoadForms.LoadForm(LayoutControl1, "Select * from vw_SUP where id ='" + sID + "'")
        End Select
        Me.CenterToScreen()
        cmdSave.Enabled = IIf(Mode = FormMode.NewRecord, UserProps.AllowInsert, UserProps.AllowEdit)
    End Sub

    Private Sub frmSUP_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        If Me.WindowState = FormWindowState.Maximized Then frmMain.XtraTabbedMdiManager1.Dock(Me, frmMain.XtraTabbedMdiManager1)
    End Sub

    Private Sub ManageAREAS()
        Dim form1 As frmGen = New frmGen()
        form1.Text = "Περιοχές"
        form1.L1.Text = "Κωδικός"
        form1.L2.Text = "Περιοχή"
        form1.L3.Text = "Νομός"
        form1.DataTable = "AREAS"
        form1.L3.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
        form1.CalledFromControl = True
        form1.CallerControl = cboAREAS
        If cboAREAS.EditValue isnot Nothing Then form1.ID = cboAREAS.EditValue.ToString
        form1.MdiParent = frmMain
        If cboAREAS.EditValue isnot Nothing Then form1.Mode = FormMode.EditRecord Else form1.Mode = FormMode.NewRecord
        frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(form1), New Point(CInt(form1.Parent.ClientRectangle.Width / 2 - form1.Width / 2), CInt(form1.Parent.ClientRectangle.Height / 2 - form1.Height / 2)))
        form1.Show()
    End Sub
    Private Function ADRsSQL() As System.Text.StringBuilder
        Dim sSQL As New System.Text.StringBuilder
        Dim CouID As String = ""
        Dim AreaID As String = ""
        If cboCOU.EditValue isnot Nothing Then CouID = cboCOU.EditValue.ToString
        If cboAREAS.EditValue isnot Nothing Then AreaID = cboAREAS.EditValue.ToString
        sSQL.AppendLine("Select id,Name + ' - ' + isnull(ar,'') as Name from vw_ADR ")
        If CouID.Length > 0 Or AreaID.Length > 0 Or txtTK.Text.Length > 0 Then sSQL.AppendLine(" where ")
        If CouID.Length > 0 Then sSQL.AppendLine(" couid = " & toSQLValueS(CouID))
        If AreaID.Length > 0 Then
            If CouID.Length > 0 Then sSQL.AppendLine(" AND ")
            sSQL.AppendLine(" AreaID = " & toSQLValueS(AreaID))
        End If
        If txtTK.Text.Length > 0 Then
            If CouID.Length > 0 Or AreaID.Length > 0 Then sSQL.AppendLine(" AND ")
            sSQL.AppendLine(" TK = " & toSQLValue(txtTK))
        End If
        sSQL.AppendLine(" order by name ")
        Return sSQL
    End Function

    Private Sub ManageADR()
        Dim form1 As frmGen = New frmGen()
        form1.Text = "Διευθύνσεις"
        form1.L1.Text = "Κωδικός"
        form1.L2.Text = "Διεύθυνση"
        form1.L3.Text = "Νομός"
        form1.L4.Text = "Περιοχές"
        form1.L8.Text = "Αριθμός"
        form1.DataTable = "ADR"
        form1.CalledFromControl = True
        form1.CallerControl = cboADR
        form1.L3.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
        form1.L4.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
        form1.L8.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
        form1.L8.Control.Tag = "Ar,0,1,2"
        If cboADR.EditValue isnot Nothing Then form1.ID = cboADR.EditValue.ToString
        form1.MdiParent = frmMain

        If cboADR.EditValue isnot Nothing Then form1.Mode = FormMode.EditRecord Else form1.Mode = FormMode.NewRecord
        frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(form1), New Point(CInt(form1.Parent.ClientRectangle.Width / 2 - form1.Width / 2), CInt(form1.Parent.ClientRectangle.Height / 2 - form1.Height / 2)))
        form1.Show()

    End Sub
    Private Sub ManageCOU()
        Dim form1 As frmGen = New frmGen()
        form1.Text = "Νομοί"
        form1.L1.Text = "Κωδικός"
        form1.L2.Text = "Νομός"
        form1.DataTable = "COU"
        form1.CallerControl = cboCOU
        form1.CalledFromControl = True
        If cboCOU.EditValue isnot Nothing Then form1.ID = cboCOU.EditValue.ToString
        form1.MdiParent = frmMain
        If cboCOU.EditValue isnot Nothing Then form1.Mode = FormMode.EditRecord Else form1.Mode = FormMode.NewRecord
        frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(form1), New Point(CInt(form1.Parent.ClientRectangle.Width / 2 - form1.Width / 2), CInt(form1.Parent.ClientRectangle.Height / 2 - form1.Height / 2)))
        form1.Show()
    End Sub
    Private Sub ManagePAY()
        Dim form1 As frmGen = New frmGen()
        form1.Text = "Τρόποι Πληρωμής"
        form1.L1.Text = "Κωδικός"
        form1.L2.Text = "Τρόπος Πληρωμής"
        form1.DataTable = "PAY"
        form1.CallerControl = cboPAY
        form1.CalledFromControl = True
        If cboPAY.EditValue isnot Nothing Then form1.ID = cboPAY.EditValue.ToString
        form1.MdiParent = frmMain
        If cboPAY.EditValue isnot Nothing Then form1.Mode = FormMode.EditRecord Else form1.Mode = FormMode.NewRecord
        frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(form1), New Point(CInt(form1.Parent.ClientRectangle.Width / 2 - form1.Width / 2), CInt(form1.Parent.ClientRectangle.Height / 2 - form1.Height / 2)))
        form1.Show()
    End Sub
    Private Sub ManageDOY()
        Dim form1 As frmGen = New frmGen()
        form1.Text = "ΔΟΥ"
        form1.L1.Text = "Κωδικός"
        form1.L2.Text = "ΔΟΥ"
        form1.DataTable = "DOY"
        form1.CallerControl = cboDOY
        form1.CalledFromControl = True
        If cboDOY.EditValue isnot Nothing Then form1.ID = cboDOY.EditValue.ToString
        form1.MdiParent = frmMain
        If cboDOY.EditValue isnot Nothing Then form1.Mode = FormMode.EditRecord Else form1.Mode = FormMode.NewRecord
        frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(form1), New Point(CInt(form1.Parent.ClientRectangle.Width / 2 - form1.Width / 2), CInt(form1.Parent.ClientRectangle.Height / 2 - form1.Height / 2)))
        form1.Show()
    End Sub

    Private Sub ManagePRF()
        Dim form1 As frmGen = New frmGen()
        form1.Text = "Επαγγέλματα"
        form1.L1.Text = "Κωδικός"
        form1.L2.Text = "Επάγγελμα"
        form1.DataTable = "PRF"
        form1.CallerControl = cboPRF
        form1.CalledFromControl = True
        If cboPRF.EditValue isnot Nothing Then form1.ID = cboPRF.EditValue.ToString
        form1.MdiParent = frmMain
        If cboPRF.EditValue isnot Nothing Then form1.Mode = FormMode.EditRecord Else form1.Mode = FormMode.NewRecord
        frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(form1), New Point(CInt(form1.Parent.ClientRectangle.Width / 2 - form1.Width / 2), CInt(form1.Parent.ClientRectangle.Height / 2 - form1.Height / 2)))
        form1.Show()
    End Sub
    Private Sub cboCOU_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboCOU.ButtonClick
        Select Case e.Button.Index
            Case 1 : cboCOU.EditValue = Nothing : ManageCOU()
            Case 2 : If cboCOU.EditValue isnot Nothing Then ManageCOU()
            Case 3 : cboCOU.EditValue = Nothing
        End Select
    End Sub
    Private Sub cboDOY_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboDOY.ButtonClick
        Select Case e.Button.Index
            Case 1 : cboDOY.EditValue = Nothing : ManageDOY()
            Case 2 : If cboDOY.EditValue isnot Nothing Then ManageDOY()
            Case 3 : cboDOY.EditValue = Nothing
        End Select
    End Sub
    Private Sub cboPRF_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboPRF.ButtonClick
        Select Case e.Button.Index
            Case 1 : cboPRF.EditValue = Nothing : ManagePRF()
            Case 2 : If cboPRF.EditValue isnot Nothing Then ManagePRF()
            Case 3 : cboPRF.EditValue = Nothing
        End Select
    End Sub

    Private Sub cboAREAS_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboAREAS.ButtonClick
        Select Case e.Button.Index
            Case 1 : cboAREAS.EditValue = Nothing : ManageAREAS()
            Case 2 : If cboAREAS.EditValue isnot Nothing Then ManageAREAS()
            Case 3 : cboAREAS.EditValue = Nothing
        End Select
    End Sub

    Private Sub cboADR_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboADR.ButtonClick
        Select Case e.Button.Index
            Case 1 : cboADR.EditValue = Nothing : ManageADR()
            Case 2 : If cboADR.EditValue isnot Nothing Then ManageADR()
            Case 3 : cboADR.EditValue = Nothing
        End Select
    End Sub
    Private Sub cboPAY_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboPAY.ButtonClick
        Select Case e.Button.Index
            Case 1 : cboPAY.EditValue = Nothing : ManagePAY()
            Case 2 : If cboPAY.EditValue isnot Nothing Then ManagePAY()
            Case 3 : cboPAY.EditValue = Nothing
        End Select
    End Sub
    Private Sub txtTK_LostFocus(sender As Object, e As EventArgs) Handles txtTK.LostFocus
        FillCbo.ADR(cboADR, ADRsSQL)
    End Sub
    Private Sub cboCOU_EditValueChanged(sender As Object, e As EventArgs) Handles cboCOU.EditValueChanged
        Dim sSQL As New System.Text.StringBuilder
        If cboCOU.EditValue isnot Nothing Then sSQL.AppendLine(" where couid = " & toSQLValueS(cboCOU.EditValue.ToString))
        FillCbo.AREAS(cboAREAS, sSQL)
        FillCbo.ADR(cboADR, ADRsSQL)
    End Sub

    Private Sub cboAREAS_EditValueChanged(sender As Object, e As EventArgs) Handles cboAREAS.EditValueChanged
        FillCbo.ADR(cboADR, ADRsSQL)
    End Sub

    Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click
        Dim sResult As Boolean
        Dim sGuid As String
        Try
            If Valid.ValidateForm(LayoutControl1) Then
                Select Case Mode
                    Case FormMode.NewRecord
                        sGuid = System.Guid.NewGuid.ToString
                        sResult = DBQ.InsertData(LayoutControl1, "SUP", sGuid)
                        sID = sGuid
                    Case FormMode.EditRecord
                        sResult = DBQ.UpdateData(LayoutControl1, "SUP", sID)
                        sGuid = sID
                End Select
                'Καθαρισμός Controls
                txtCode.Text = DBQ.GetNextId("SUP")
                If CalledFromCtrl Then
                    FillCbo.SUP(CtrlCombo)
                    CtrlCombo.EditValue = System.Guid.Parse(sGuid)
                Else
                    Dim form As frmScroller = Frm
                    form.LoadRecords("vw_SUP")
                End If
                'Cls.ClearCtrls(LayoutControl1)
                If sResult = True Then
                    XtraMessageBox.Show("Η εγγραφή αποθηκέυτηκε με επιτυχία", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Cls.ClearCtrls(LayoutControl1)
                    Mode = FormMode.NewRecord
                    txtCode.Text = DBQ.GetNextId("SUP")
                End If
            End If

        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub cmdExit_Click(sender As Object, e As EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Dim sSQL As String
        Dim cmd As SqlCommand
        Dim sdr As SqlDataReader


        Using oCmd As New SqlCommand("FIX_SUP_BAL", CNDB)
            oCmd.CommandType = CommandType.StoredProcedure
            oCmd.Parameters.AddWithValue("@supplierID", sID)
            oCmd.ExecuteNonQuery()
        End Using
        sSQL = "Select  BAL from SUP WHERE ID = " & toSQLValueS(sID)
        cmd = New SqlCommand(sSQL, CNDB)
        sdr = cmd.ExecuteReader()
        If sdr.Read() = True Then txtBal.EditValue = sdr.GetDecimal(sdr.GetOrdinal("BAL"))
        sdr.Close()
    End Sub
End Class