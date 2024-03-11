Imports System.Data.SqlClient
Imports DevExpress.XtraEditors.Controls


Public Class frmProject
    Private ManageCbo As New CombosManager
    Private Projects As New Projects
    Private LoadForms As New FormLoader
    Private Frm As frmProject
    Private FillCbo As New FillCombos
    Private CtrlCombo As DevExpress.XtraEditors.LookUpEdit
    Private CalledFromCtrl As Boolean
    Private HideCompany As Boolean
    Private sCusID As Guid
    Private sEmpID As Guid
    Private sCompID As Guid
    Private sCompProjectID As Guid
    Private sTransCID As Guid
    Private sID As String
    Private sisOrder As Boolean
    Public Mode As Byte

    Public WriteOnly Property isOrder As Boolean
        Set(value As Boolean)
            sisOrder = value
        End Set
    End Property
    Public WriteOnly Property CusID As Guid
        Set(value As Guid)
            sCusID = value
        End Set
    End Property
    Public WriteOnly Property EmpID As Guid
        Set(value As Guid)
            sEmpID = value
        End Set
    End Property
    Public WriteOnly Property TransCID As Guid
        Set(value As Guid)
            sTransCID = value
        End Set
    End Property
    Public WriteOnly Property CompID As Guid
        Set(value As Guid)
            sCompID = value
        End Set
    End Property
    Public WriteOnly Property CompProjectID As Guid
        Set(value As Guid)
            sCompProjectID = value
        End Set
    End Property

    Public WriteOnly Property ID As String
        Set(value As String)
            sID = value
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
    Public WriteOnly Property HideCompanyFields As Boolean
        Set(value As Boolean)
            HideCompany = value
        End Set
    End Property

    Private Sub cmdExit_Click(sender As Object, e As EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub


    Private Sub frmProject_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DreamyKitchenDataSet.vw_INVTYPES' table. You can move, or remove it, as needed.
        Me.Vw_INVTYPESTableAdapter.Fill(Me.DreamyKitchenDataSet.vw_INVTYPES)
        'TODO: This line of code loads data into the 'DM_CCT.vw_COMP' table. You can move, or remove it, as needed.
        Me.Vw_COMPTableAdapter.Fill(Me.DM_CCT.vw_COMP)
        Projects.InitializeSmall(Me, sID, Mode, CalledFromCtrl, CtrlCombo, sisOrder)
        If sCusID <> Nothing Then cboCUS.EditValue = sCusID : cboCUS.Enabled = False
        If sEmpID <> Nothing Then cboSaler.EditValue = sEmpID : cboSaler.Enabled = False
        If sCompID <> Nothing Then cboCompany.EditValue = sCompID : cboCompany.Enabled = False
        If sCompProjectID <> Nothing Then cboCompProject.EditValue = sCompProjectID : cboCompProject.Enabled = False
        Select Case Mode
            Case FormMode.NewRecord
                dtCharge.EditValue = DateTime.Now : txtCodeH.Text = Projects.GetNextID
                If sTransCID <> Nothing Then cboTransC.Properties.GetItems.Item(System.Guid.Parse(sTransCID.ToString)).CheckState = CheckState.Checked
            Case FormMode.EditRecord
                If UserProps.ID.ToString.ToUpper = "3F9DC32E-BE5B-4D46-A13C-EA606566CF32" Or UserProps.ID.ToString.ToUpper = "E9CEFD11-47C0-4796-A46B-BC41C4C3606B" Then cmdOpenTransh.Enabled = True
                Dim sSQL As New System.Text.StringBuilder
                If cboCOU.EditValue <> Nothing Then sSQL.AppendLine(" where couid = " & toSQLValueS(cboCOU.EditValue.ToString))
                FillCbo.AREAS(cboAREAS, sSQL)
                LoadForms.LoadForm(LayoutControl1, "Select * from vw_TRANSH_SMALL with(nolock) where id ='" + sID + "'")
                CheckStateTransItems()
                If cboCUS.GetColumnValue("isCompany") = True Then LCus.Text = "Εταιρία"
                If chkcompProject.CheckState = CheckState.Checked Then chkcompProject.Enabled = False
                If sisOrder = True Then LCompProject.Enabled = False : LComp.Enabled = False : LdtCharge.Enabled = False
        End Select
        Me.CenterToScreen()

        cmdSaveTransH.Enabled = IIf(Mode = FormMode.NewRecord, UserProps.AllowInsert, UserProps.AllowEdit)
    End Sub
    Private Sub CheckStateTransItems()
        Dim cmd As SqlCommand = New SqlCommand("Select transhCID from TRANSC WHERE transhID = " & toSQLValueS(sID), CNDB)
        Dim sdr As SqlDataReader = cmd.ExecuteReader()
        If sdr.HasRows Then
            While sdr.Read()
                cboTransC.Properties.GetItems.Item(System.Guid.Parse(sdr("transhCID").ToString)).CheckState = CheckState.Checked
            End While
        End If
        sdr.Close()
    End Sub
    Private Sub cmdSaveTransH_Click(sender As Object, e As EventArgs) Handles cmdSaveTransH.Click
        Projects.SaveRecordSmallH(sID)
    End Sub

    Private Sub frmProject_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        If Me.WindowState = FormWindowState.Maximized Then frmMain.XtraTabbedMdiManager1.Dock(Me, frmMain.XtraTabbedMdiManager1)
    End Sub
    Private Sub cboCOU_EditValueChanged(sender As Object, e As EventArgs) Handles cboCOU.EditValueChanged
        Dim sSQL As New System.Text.StringBuilder
        If cboCOU.EditValue <> Nothing Then sSQL.AppendLine(" where couid = " & toSQLValueS(cboCOU.EditValue.ToString))
        FillCbo.AREAS(cboAREAS, sSQL)
        FillCbo.ADR(cboADR, ManageCbo.ADRsSQL(cboCOU, cboAREAS))
    End Sub

    Private Sub cboAREAS_EditValueChanged(sender As Object, e As EventArgs) Handles cboAREAS.EditValueChanged
        FillCbo.ADR(cboADR, ManageCbo.ADRsSQL(cboCOU, cboAREAS))
    End Sub
    Private Sub cboCUS_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboCUS.ButtonClick
        Select Case e.Button.Index
            Case 1
                If e.Button.Tag = "" Or e.Button.Tag = "0" Then e.Button.Tag = "1" : LCus.Text = "Εταιρία" Else e.Button.Tag = "0" : LCus.Text = "Πελάτης"
                Dim sSQL As New System.Text.StringBuilder
                sSQL.AppendLine("Select id,Fullname,'00000000-0000-0000-0000-000000000000' as SalerID,phn,AdrID,email from vw_CCT where isCompany = " & e.Button.Tag & " order by Fullname")
                FillCbo.CUS(Me.cboCUS, sSQL)
            Case 2 : ManageCbo.ManageCCT(FormMode.NewRecord, False,, cboCUS)
            Case 3 : ManageCbo.ManageCCT(FormMode.EditRecord, False,, cboCUS)
            Case 4 : cboCUS.EditValue = Nothing
        End Select
    End Sub
    Private Sub cboSaler_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboSaler.ButtonClick
        Select Case e.Button.Index
            Case 1 : ManageCbo.ManageSaler(cboSaler, FormMode.NewRecord)
            Case 2 : ManageCbo.ManageSaler(cboSaler, FormMode.EditRecord)
            Case 3 : cboSaler.EditValue = Nothing
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
    Private Sub cmdOpenTransh_Click(sender As Object, e As EventArgs) Handles cmdOpenTransh.Click
        If UserProps.ID.ToString.ToUpper = "3F9DC32E-BE5B-4D46-A13C-EA606566CF32" Or UserProps.ID.ToString.ToUpper = "E9CEFD11-47C0-4796-A46B-BC41C4C3606B" Then
            Dim Frm As frmTransactions = New frmTransactions()
            Frm.Text = "Έργα Πελατών"
            Frm.MdiParent = frmMain
            Frm.LCompProject.Visibility = HideCompany
            Frm.LComp.Visibility = HideCompany
            If Mode = FormMode.EditRecord Then Frm.ID = sID : Frm.Mode = FormMode.EditRecord
            frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(Frm), New Point(CInt(Frm.Parent.ClientRectangle.Width / 2 - Frm.Width / 2), CInt(Frm.Parent.ClientRectangle.Height / 2 - Frm.Height / 2)))
            Frm.Show()
        End If
    End Sub
    Private Sub cboCompany_EditValueChanged(sender As Object, e As EventArgs) Handles cboCompany.EditValueChanged
        Dim sCompID As String
        If cboCompany.EditValue Is Nothing Then sCompID = toSQLValueS(Guid.Empty.ToString) Else sCompID = toSQLValueS(cboCompany.EditValue.ToString)
        Dim sSQL As New System.Text.StringBuilder
        sSQL.AppendLine("Select T.id,FullTranshDescription,Description,Iskitchen,Iscloset,Isdoor,Issc,CouID,AreaID,AdrID
                        from vw_TRANSH t
                        where  T.cusid = " & sCompID & "order by description")
        FillCbo.TRANSH(cboCompProject, sSQL)
        LCompProject.ImageOptions.Image = Global.DreamyKitchenCRM.My.Resources.Resources.rsz_11rsz_asterisk

    End Sub

    Private Sub cboCompProject_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboCompProject.ButtonClick
        Select Case e.Button.Index
            Case 1 : ManageCbo.ManageTRANSHSmall(cboCompProject, FormMode.NewRecord, cboCompany.EditValue, True)
            Case 2 : ManageCbo.ManageTRANSHSmall(cboCompProject, FormMode.EditRecord, cboCompany.EditValue, True)
            Case 3 : cboCompProject.EditValue = Nothing
        End Select
    End Sub

    Private Sub cboCompany_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboCompany.ButtonClick
        Select Case e.Button.Index
            Case 1 : ManageCbo.ManageCCT(FormMode.NewRecord, False,, cboCompany)
            Case 2 : ManageCbo.ManageCCT(FormMode.EditRecord, False,, cboCompany)
            Case 3 : cboCompany.EditValue = Nothing : LCompProject.ImageOptions.Image = Nothing
        End Select
    End Sub

    Private Sub cboCompProject_EditValueChanged(sender As Object, e As EventArgs) Handles cboCompProject.EditValueChanged
        cboCOU.EditValue = cboCompProject.GetColumnValue("CouID") : cboCOU.Enabled = False
        cboAREAS.EditValue = cboCompProject.GetColumnValue("AreaID") : cboAREAS.Enabled = False
        cboADR.EditValue = cboCompProject.GetColumnValue("AdrID") : cboADR.Enabled = False
    End Sub


End Class