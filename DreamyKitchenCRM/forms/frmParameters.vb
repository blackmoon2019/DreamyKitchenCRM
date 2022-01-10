Imports System.Data.SqlClient
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraNavBar

Public Class frmParameters
    Private sID As String
    Private Ctrl As DevExpress.XtraGrid.Views.Grid.GridView
    Private Frm As DevExpress.XtraEditors.XtraForm
    Public Mode As Byte
    Private Valid As New ValidateControls
    Private Cls As New ClearControls
    Private Prog_Prop As New ProgProp
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

    Private Sub frmParameters_Load(sender As Object, e As EventArgs) Handles Me.Load
        'TODO: This line of code loads data into the 'DreamyKitchenDataSet.vw_BENCH' table. You can move, or remove it, as needed.
        Me.Vw_BENCHTableAdapter.Fill(Me.DreamyKitchenDataSet.vw_BENCH)
        'TODO: This line of code loads data into the 'DreamyKitchenDataSet.vw_COLORSPVC' table. You can move, or remove it, as needed.
        Me.Vw_COLORSPVCTableAdapter.Fill(Me.DreamyKitchenDataSet.vw_COLORSPVC)
        'TODO: This line of code loads data into the 'DreamyKitchenDataSet.vw_COLORSBOX' table. You can move, or remove it, as needed.
        Me.Vw_COLORSBOXTableAdapter.Fill(Me.DreamyKitchenDataSet.vw_COLORSBOX)
        Me.CenterToScreen()
        TablePanel1.Rows.Item(0).Visible = False
        TablePanel1.Rows.Item(1).Visible = False

        'TablePanel1.Rows.Item(2).Visible = False
        'TablePanel1.Rows.Item(3).Visible = False
    End Sub

    Private Sub frmParameters_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        If Me.WindowState = FormWindowState.Maximized Then frmMain.XtraTabbedMdiManager1.Dock(Me, frmMain.XtraTabbedMdiManager1)
    End Sub

    Private Sub navGen_LinkClicked(sender As Object, e As NavBarLinkEventArgs) Handles navGen.LinkClicked
        TablePanel1.Rows.Item(0).Visible = True
        TablePanel1.Rows.Item(1).Visible = False
        'Δεκαδικά Προγράμματος
        txtDecimals.EditValue = Prog_Prop.GetProgDecimals()
        'Technical Support Email
        txtEmail.EditValue = Prog_Prop.GetProgTechSupportEmail
    End Sub

    Private Sub navDisplay_LinkClicked(sender As Object, e As NavBarLinkEventArgs) Handles navDisplay.LinkClicked
        'TablePanel1.Rows.Item(0).Visible = True
        'TablePanel1.Rows.Item(1).Visible = False
        'TablePanel1.Rows.Item(2).Visible = False
    End Sub

    Private Sub txtDecimals_Validated(sender As Object, e As EventArgs) Handles txtDecimals.Validated
        'Δεκαδικά Προγράμματος
        Prog_Prop.SetProgDecimals(txtDecimals.EditValue)
    End Sub

    Private Sub txtEmail_Validated(sender As Object, e As EventArgs) Handles txtEmail.Validated
        'Email Support
        Prog_Prop.SetProgTechSupportEmail(txtEmail.EditValue)
    End Sub


    Private Sub txtCusDiscount_Validated(sender As Object, e As EventArgs)
        'Γενική έκπτωση πελατών
        'Prog_Prop.SetProgCusDiscount(txtCusDiscount.EditValue)
    End Sub
    Private Sub cboBENCH_ButtonClick(sender As Object, e As ButtonPressedEventArgs)
        Select Case e.Button.Index
            Case 1 : BENCH.EditValue = Nothing : ManageBENCH()
            Case 2 : If BENCH.EditValue <> Nothing Then ManageBENCH()
            Case 3 : BENCH.EditValue = Nothing
        End Select
    End Sub
    Private Sub cboVBOXColors_ButtonClick(sender As Object, e As ButtonPressedEventArgs)
        Select Case e.Button.Index
            Case 1 : V_BOX_COLOR.EditValue = Nothing : ManageColors(V_BOX_COLOR)
            Case 2 : If V_BOX_COLOR.EditValue <> Nothing Then ManageColors(V_BOX_COLOR)
            Case 3 : V_BOX_COLOR.EditValue = Nothing
        End Select
    End Sub
    Private Sub ManageColors(ByVal CallerControl As LookUpEdit)
        Dim frmColors As frmColors = New frmColors
        frmColors.Text = "Χρώματα"
        frmColors.CallerForm = "frmColors"
        frmColors.CallerControlLKUP = CallerControl
        frmColors.CalledFromControl = True
        frmColors.MdiParent = frmMain
        If CallerControl.EditValue <> Nothing Then
            frmColors.ID = CallerControl.EditValue.ToString
            frmColors.Mode = FormMode.EditRecord
        Else
            frmColors.Mode = FormMode.NewRecord
        End If
        frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(frmColors), New Point(CInt(frmColors.Parent.ClientRectangle.Width / 2 - frmColors.Width / 2), CInt(frmColors.Parent.ClientRectangle.Height / 2 - frmColors.Height / 2)))
        frmColors.Show()
    End Sub
    Private Sub ManageBENCH()
        Dim frmBench As frmBench = New frmBench
        frmBench.CallerForm = "frmOffer"
        frmBench.CallerControl = BENCH
        frmBench.CalledFromControl = True
        frmBench.MdiParent = frmMain
        If BENCH.EditValue <> Nothing Then
            frmBench.ID = BENCH.EditValue.ToString
            frmBench.Mode = FormMode.EditRecord
        Else
            frmBench.Mode = FormMode.NewRecord
        End If
        frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(frmBench), New Point(CInt(frmBench.Parent.ClientRectangle.Width / 2 - frmBench.Width / 2), CInt(frmBench.Parent.ClientRectangle.Height / 2 - frmBench.Height / 2)))
        frmBench.Show()
    End Sub

    Private Sub cboVPVCColors_ButtonClick(sender As Object, e As ButtonPressedEventArgs)
        Select Case e.Button.Index
            Case 1 : V_BOX_COLOR.EditValue = Nothing : ManageColors(V_PVC_COLOR)
            Case 2 : If V_PVC_COLOR.EditValue <> Nothing Then ManageColors(V_PVC_COLOR)
            Case 3 : V_PVC_COLOR.EditValue = Nothing
        End Select
    End Sub
    Private Sub cboKBOXColors_ButtonClick(sender As Object, e As ButtonPressedEventArgs)
        Select Case e.Button.Index
            Case 1 : V_BOX_COLOR.EditValue = Nothing : ManageColors(K_BOX_COLOR)
            Case 2 : If K_BOX_COLOR.EditValue <> Nothing Then ManageColors(K_BOX_COLOR)
            Case 3 : K_BOX_COLOR.EditValue = Nothing
        End Select
    End Sub

    Private Sub cboKPVCColors_ButtonClick(sender As Object, e As ButtonPressedEventArgs)
        Select Case e.Button.Index
            Case 1 : V_BOX_COLOR.EditValue = Nothing : ManageColors(K_PVC_COLOR)
            Case 2 : If K_PVC_COLOR.EditValue <> Nothing Then ManageColors(K_PVC_COLOR)
            Case 3 : K_PVC_COLOR.EditValue = Nothing
        End Select
    End Sub

    Private Sub cboYBOXColors_ButtonClick(sender As Object, e As ButtonPressedEventArgs)
        Select Case e.Button.Index
            Case 1 : V_BOX_COLOR.EditValue = Nothing : ManageColors(Y_BOX_COLOR)
            Case 2 : If Y_BOX_COLOR.EditValue <> Nothing Then ManageColors(Y_BOX_COLOR)
            Case 3 : Y_BOX_COLOR.EditValue = Nothing
        End Select
    End Sub

    Private Sub cboYPVCColors_ButtonClick(sender As Object, e As ButtonPressedEventArgs)
        Select Case e.Button.Index
            Case 1 : V_BOX_COLOR.EditValue = Nothing : ManageColors(Y_PVC_COLOR)
            Case 2 : If Y_PVC_COLOR.EditValue <> Nothing Then ManageColors(Y_PVC_COLOR)
            Case 3 : Y_PVC_COLOR.EditValue = Nothing
        End Select
    End Sub

    Private Sub NavCusOffer_LinkClicked(sender As Object, e As NavBarLinkEventArgs) Handles NavCusOffer.LinkClicked
        Prog_Prop.GetProgPROSF(LayoutControl3)
    End Sub


    Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click
        Prog_Prop.SetProgPROSF(LayoutControl3)
        XtraMessageBox.Show("Η εγγραφή αποθηκέυτηκε με επιτυχία", "Dreamy Kitchen CRM", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class