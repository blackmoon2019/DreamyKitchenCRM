Imports System.Data.SqlClient
Imports DevExpress.XtraEditors.Controls


Public Class frmProject
    Private ManageCbo As New CombosManager
    Private Projects As New Projects
    Private LoadForms As New FormLoader
    Private Frm As frmProject
    Private FillCbo As New FillCombos
    Private sID As String
    Public Mode As Byte
    Private IsCompany As Integer = 0

    Public WriteOnly Property ID As String
        Set(value As String)
            sID = value
        End Set
    End Property
    Private Sub cmdExit_Click(sender As Object, e As EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub


    Private Sub frmProject_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DM_TRANS.vw_TRANSH_C' table. You can move, or remove it, as needed.
        Me.Vw_TRANSH_CTableAdapter.Fill(Me.DM_TRANS.vw_TRANSH_C)
        Projects.InitializeSmall(Me, sID, Mode)

        Select Case Mode
            Case FormMode.NewRecord
                dtCharge.EditValue = DateTime.Now : txtCodeH.Text = Projects.GetNextID
            Case FormMode.EditRecord
                If UserProps.ID.ToString.ToUpper = "3F9DC32E-BE5B-4D46-A13C-EA606566CF32" Or UserProps.ID.ToString.ToUpper = "E9CEFD11-47C0-4796-A46B-BC41C4C3606B" Then cmdOpenTransh.Enabled = True
                LoadForms.LoadForm(LayoutControl1, "Select * from vw_TRANSH_SMALL with(nolock) where id ='" + sID + "'")
                Dim cmd As SqlCommand = New SqlCommand("Select transhCID from TRANSC WHERE transhID = " & toSQLValueS(sID), CNDB)
                Dim sdr As SqlDataReader = cmd.ExecuteReader()
                If sdr.HasRows Then
                    While sdr.Read()
                        cboTransC.Properties.GetItems.Item(System.Guid.Parse(sdr("transhCID").ToString)).CheckState = CheckState.Checked
                    End While
                End If
                sdr.Close()
        End Select
        Me.CenterToScreen()

        cmdSaveTransH.Enabled = IIf(Mode = FormMode.NewRecord, UserProps.AllowInsert, UserProps.AllowEdit)
    End Sub

    Private Sub cmdSaveTransH_Click(sender As Object, e As EventArgs) Handles cmdSaveTransH.Click
        Projects.SaveRecordSmallH()
    End Sub

    Private Sub frmProject_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        If Me.WindowState = FormWindowState.Maximized Then frmMain.XtraTabbedMdiManager1.Dock(Me, frmMain.XtraTabbedMdiManager1)
    End Sub
    Private Sub cboCUS_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboCUS.ButtonClick
        Select Case e.Button.Index
            Case 1
                If IsCompany = 0 Then IsCompany = 1 Else IsCompany = 0
                Dim sSQL As New System.Text.StringBuilder
                sSQL.AppendLine("Select id,Fullname,'00000000-0000-0000-0000-000000000000' as SalerID,phn,AdrID,email from vw_CCT where isCompany = " & IsCompany & " order by Fullname")
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

    Private Sub cmdOpenTransh_Click(sender As Object, e As EventArgs) Handles cmdOpenTransh.Click
        If UserProps.ID.ToString.ToUpper = "3F9DC32E-BE5B-4D46-A13C-EA606566CF32" Or UserProps.ID.ToString.ToUpper = "E9CEFD11-47C0-4796-A46B-BC41C4C3606B" Then
            Dim Frm As frmTransactions = New frmTransactions()
            Frm.Text = "Χρεωπιστώσεις Πελατών"
            Frm.MdiParent = frmMain
            If Mode = FormMode.EditRecord Then Frm.ID = sID : Frm.Mode = FormMode.EditRecord
            frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(Frm), New Point(CInt(Frm.Parent.ClientRectangle.Width / 2 - Frm.Width / 2), CInt(Frm.Parent.ClientRectangle.Height / 2 - Frm.Height / 2)))
            Frm.Show()
        End If
    End Sub
End Class