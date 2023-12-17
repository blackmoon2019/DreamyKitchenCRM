Imports DevExpress.Utils
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Grid

Public Class frmCustomers
    Private Customers As New Customers
    Private sID As String
    Private Ctrl As DevExpress.XtraGrid.Views.Grid.GridView
    Private Frm As DevExpress.XtraEditors.XtraForm
    Public Mode As Byte
    Private ManageCbo As New CombosManager
    Private FillCbo As New FillCombos
    Private LoadForms As New FormLoader
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


    Private Sub frmCustomers_Load(sender As Object, e As EventArgs) Handles Me.Load

        Customers.Initialize(Me, sID, Mode, CalledFromCtrl, CtrlCombo, Frm)
        Select Case Mode
            Case FormMode.NewRecord
                txtCode.Text = Customers.GetNextID
            Case FormMode.EditRecord
                Dim sSQL As New System.Text.StringBuilder
                If cboCOU.EditValue <> Nothing Then sSQL.AppendLine(" where couid = " & toSQLValueS(cboCOU.EditValue.ToString))
                FillCbo.AREAS(cboAREAS, sSQL)
                LoadForms.LoadForm(LayoutControl1, "Select * from vw_CCT where id ='" + sID + "'")
                LoadForms.LoadDataToGrid(GridControl1, GridView1, "select ID,cctID,filename,comefrom,createdon,realname From vw_CCT_F where isnull(isInvoice,0)=0 and cctID = '" & sID & "'")
        End Select
        LoadForms.RestoreLayoutFromXml(GridView1, "vw_CCT_F_def.xml")
        Me.CenterToScreen()
        cmdSave.Enabled = IIf(Mode = FormMode.NewRecord, UserProps.AllowInsert, UserProps.AllowEdit)
    End Sub
    Private Sub DeleteRecord()
        Customers.DeleteRecord()
    End Sub
    Private Sub frmCustomers_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        If Me.WindowState = FormWindowState.Maximized Then frmMain.XtraTabbedMdiManager1.Dock(Me, frmMain.XtraTabbedMdiManager1)
    End Sub

    Private Sub txtFileNames_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles txtFileNames.ButtonClick
        If e.Button.Index = 0 Then
            FilesSelection(XtraOpenFileDialog1, txtFileNames)
        Else
            txtFileNames.EditValue = Nothing
        End If
    End Sub

    Private Sub cboDOY_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboDOY.ButtonClick
        Select Case e.Button.Index
            Case 1 : cboDOY.EditValue = Nothing : ManageCbo.ManageDOY(cboDOY, FormMode.NewRecord)
            Case 2 : If cboDOY.EditValue <> Nothing Then ManageCbo.ManageDOY(cboDOY, FormMode.EditRecord)
            Case 3 : cboDOY.EditValue = Nothing
        End Select
    End Sub
    Private Sub cboPRF_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboPRF.ButtonClick
        Select Case e.Button.Index
            Case 1 : cboPRF.EditValue = Nothing : ManageCbo.ManagePRF(cboPRF, FormMode.NewRecord)
            Case 2 : If cboPRF.EditValue <> Nothing Then ManageCbo.ManagePRF(cboPRF, FormMode.EditRecord)
            Case 3 : cboPRF.EditValue = Nothing
        End Select
    End Sub
    Private Sub cboCOU_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboCOU.ButtonClick
        Select Case e.Button.Index
            Case 1 : cboCOU.EditValue = Nothing : ManageCbo.ManageCOU(cboCOU, FormMode.NewRecord)
            Case 2 : If cboCOU.EditValue <> Nothing Then ManageCbo.ManageCOU(cboCOU, FormMode.EditRecord)
            Case 3 : cboCOU.EditValue = Nothing
        End Select
    End Sub
    Private Sub cboAREAS_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboAREAS.ButtonClick
        Select Case e.Button.Index
            Case 1 : cboAREAS.EditValue = Nothing : ManageCbo.ManageAREAS(cboAREAS, FormMode.NewRecord)
            Case 2 : If cboAREAS.EditValue <> Nothing Then ManageCbo.ManageAREAS(cboAREAS, FormMode.EditRecord)
            Case 3 : cboAREAS.EditValue = Nothing
        End Select
    End Sub

    Private Sub cboADR_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboADR.ButtonClick
        Select Case e.Button.Index
            Case 1 : cboADR.EditValue = Nothing : ManageCbo.ManageADR(cboADR, FormMode.NewRecord)
            Case 2 : If cboADR.EditValue <> Nothing Then ManageCbo.ManageADR(cboADR, FormMode.EditRecord)
            Case 3 : cboADR.EditValue = Nothing
        End Select
    End Sub


    Private Sub frmCustomers_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        GridView1.SaveLayoutToXml(Application.StartupPath & "\DSGNS\DEF\vw_CCT_F_def.xml", OptionsLayoutBase.FullLayout)
    End Sub

    Private Sub txtTK_LostFocus(sender As Object, e As EventArgs) Handles txtTK.LostFocus
        FillCbo.ADR(cboADR, ManageCbo.ADRsSQL(cboCOU, cboAREAS, txtTK))
    End Sub

    Private Sub GridControl1_DoubleClick(sender As Object, e As EventArgs) Handles GridControl1.DoubleClick
        OpenFile(GridView1, "vw_CCT_F")
    End Sub
    Private Sub cboCOU_EditValueChanged(sender As Object, e As EventArgs) Handles cboCOU.EditValueChanged
        Dim sSQL As New System.Text.StringBuilder
        If cboCOU.EditValue <> Nothing Then sSQL.AppendLine(" where couid = " & toSQLValueS(cboCOU.EditValue.ToString))
        FillCbo.AREAS(cboAREAS, sSQL)
        FillCbo.ADR(cboADR, ManageCbo.ADRsSQL(cboCOU, cboAREAS, txtTK))
    End Sub

    Private Sub cboAREAS_EditValueChanged(sender As Object, e As EventArgs) Handles cboAREAS.EditValueChanged
        FillCbo.ADR(cboADR, ManageCbo.ADRsSQL(cboCOU, cboAREAS, txtTK))
    End Sub

    Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click
        Customers.SaveRecord()
    End Sub

    Private Sub GridView1_KeyDown(sender As Object, e As KeyEventArgs) Handles GridView1.KeyDown
        Select Case e.KeyCode
            'Case Keys.F2 : If UserProps.AllowInsert = True Then NewRecord()
            'Case Keys.F3 : If UserProps.AllowEdit = True Then EditRecord()
            'Case Keys.F5 : LoadRecords()
            Case Keys.Delete : DeleteRecord() 'If UserProps.AllowDelete = True Then DeleteRecord()
        End Select

    End Sub


    Private Sub cboSRC_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboSRC.ButtonClick
        Select Case e.Button.Index
            Case 1 : cboSRC.EditValue = Nothing : ManageCbo.ManageSRC(cboSRC, FormMode.NewRecord)
            Case 2 : If cboSRC.EditValue <> Nothing Then ManageCbo.ManageSRC(cboSRC, FormMode.EditRecord)
            Case 3 : cboSRC.EditValue = Nothing
        End Select
    End Sub

    Private Sub cmdExit_Click(sender As Object, e As EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub

    Private Sub GridView1_PopupMenuShowing(sender As Object, e As PopupMenuShowingEventArgs) Handles GridView1.PopupMenuShowing
        If e.MenuType = GridMenuType.Column Then LoadForms.PopupMenuShow(e, GridView1, "vw_CCT_F_def.xml",, "select top 1 [filename], [RealName], [code], [comefrom], [extension], [modifiedOn], [createdOn], [ID], [cctID], [isinvoice] from vw_CCT_F")
    End Sub


    Private Sub cmdImageSlider_Click(sender As Object, e As EventArgs) Handles cmdImageSlider.Click
        SplashScreenManager1.ShowWaitForm()
        SplashScreenManager1.SetWaitFormCaption("Παρακαλώ περιμένετε")

        Dim frmImageSlider As frmImageSlider = New frmImageSlider()
        frmImageSlider.CCT_ID = sID
        frmImageSlider.Spl = SplashScreenManager1
        frmImageSlider.ShowDialog()

    End Sub

    Private Sub frmCustomers_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Customers = Nothing
    End Sub

    Private Sub chkCompany_CheckedChanged(sender As Object, e As EventArgs) Handles chkCompany.CheckedChanged
        If chkCompany.CheckState = CheckState.Checked Then
            LAfm.Tag = 1 : LAfm.ImageOptions.Image = My.Resources.rsz_11rsz_asterisk
            LPrf.Tag = 1 : LPrf.ImageOptions.Image = My.Resources.rsz_11rsz_asterisk
            LDoy.Tag = 1 : LDoy.ImageOptions.Image = My.Resources.rsz_11rsz_asterisk
        Else
            LAfm.Tag = "" : LAfm.ImageOptions.Image = Nothing
            LPrf.Tag = "" : LPrf.ImageOptions.Image = Nothing
            LDoy.Tag = "" : LDoy.ImageOptions.Image = Nothing

        End If
    End Sub
End Class
