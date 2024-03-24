Imports System.ComponentModel
Imports System.Data.SqlClient
Imports DevExpress.Utils
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls

Public Event HyperlinkClick As HyperlinkClickEventHandler
Public Class frmCUSPrivateAgreement
    Private CusPrivateAgreement As New CusPrivateAgreement
    Private ManageCbo As New CombosManager
    Private sID As String
    Private Ctrl As DevExpress.XtraGrid.Views.Grid.GridView
    Private Frm As DevExpress.XtraEditors.XtraForm
    Public Mode As Byte
    Private ChangeVal As Boolean = False
    Private Valid As New ValidateControls
    Private FScrollerExist As Boolean = False
    Private Log As New Transactions
    Private FillCbo As New FillCombos
    Private DBQ As New DBQueries
    Private LoadForms As New FormLoader
    Private Cls As New ClearControls
    Private CtrlCombo As DevExpress.XtraEditors.LookUpEdit
    Private CalledFromCtrl As Boolean
    Private WorkingTime As Integer
    Private AgreementSalary As Double
    Private UserPermissions As New CheckPermissions
    Private Prog_Prop As New ProgProp
    Public sCompanyID As Guid
    Public sCompTranshID As Guid
    Public sCusID As Guid
    Public sTranshID As Guid
    Public sEmpID As Guid
    Public WriteOnly Property Company As Guid
        Set(value As Guid)
            sCompanyID = value
        End Set
    End Property
    Public WriteOnly Property CompProject As Guid
        Set(value As Guid)
            sCompTranshID = value
        End Set
    End Property
    Public WriteOnly Property CUS As Guid
        Set(value As Guid)
            sCusID = value
        End Set
    End Property
    Public WriteOnly Property TRANSH As Guid
        Set(value As Guid)
            sTranshID = value
        End Set
    End Property
    Public WriteOnly Property EMP As Guid
        Set(value As Guid)
            sEmpID = value
        End Set
    End Property

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
    Private Sub cmdExit_Click(sender As Object, e As EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub
    Private Sub frmPrivateAgreement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitializeForm()
        Me.CenterToScreen()
    End Sub

    Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click
        If CusPrivateAgreement.SaveRecord(sID) = True Then
            LMsg.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
            LCheckList.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
            Mode = FormMode.EditRecord
        End If
    End Sub

    Private Sub frmPrivateAgreement_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        If Me.WindowState = FormWindowState.Maximized Then frmMain.XtraTabbedMdiManager1.Dock(Me, frmMain.XtraTabbedMdiManager1)
    End Sub

    Public Sub InitializeForm()
        CusPrivateAgreement.CompanyID = sCompanyID
        CusPrivateAgreement.CompTranshID = sCompTranshID
        CusPrivateAgreement.CusID = sCusID
        CusPrivateAgreement.TranshID = sTranshID
        CusPrivateAgreement.EmpID = sEmpID
        CusPrivateAgreement.Initialize(Me, sID, Mode, CalledFromCtrl, CtrlCombo)
        CusPrivateAgreement.LoadForm()
    End Sub
    Private Sub cboEMP_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboEMP.ButtonClick
        Select Case e.Button.Index
            Case 1 : ManageCbo.ManageEMP(cboEMP, FormMode.NewRecord)
            Case 2 : ManageCbo.ManageEMP(cboEMP, FormMode.EditRecord)
            Case 3 : cboEMP.EditValue = Nothing
        End Select
    End Sub
    Private Sub cboCUS_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboCUS.ButtonClick
        Select Case e.Button.Index
            Case 1 : ManageCbo.ManageCCT(FormMode.NewRecord, False,, cboCUS) : GetCusFields()
            Case 2 : ManageCbo.ManageCCT(FormMode.EditRecord, False,, cboCUS) : GetCusFields()
            Case 3 : cboCUS.EditValue = Nothing
        End Select
    End Sub
    Private Sub GetCusFields()
        Dim cmd As SqlCommand
        Dim sdr As SqlDataReader

        Try
            cmd = New SqlCommand("SELECT FatherName,AREAS_Name,DOY_Name,afm,AdrID FROM VW_CCT WHERE ID = " & toSQLValueS(cboCUS.EditValue.ToString), CNDB)
            sdr = cmd.ExecuteReader()
            If (sdr.Read() = True) Then
                If sdr.IsDBNull(sdr.GetOrdinal("FatherName")) = False Then txtFatherName.EditValue = sdr.GetString(sdr.GetOrdinal("FatherName")).ToString
                If sdr.IsDBNull(sdr.GetOrdinal("AREAS_Name")) = False Then txtArea.EditValue = sdr.GetString(sdr.GetOrdinal("AREAS_Name")).ToString
                If sdr.IsDBNull(sdr.GetOrdinal("DOY_Name")) = False Then txtDOY.EditValue = sdr.GetString(sdr.GetOrdinal("DOY_Name")).ToString
                If sdr.IsDBNull(sdr.GetOrdinal("afm")) = False Then txtAFM.EditValue = sdr.GetString(sdr.GetOrdinal("afm")).ToString
                If sdr.IsDBNull(sdr.GetOrdinal("AdrID")) = False Then cboADR.EditValue = sdr.GetGuid(sdr.GetOrdinal("AdrID")).ToString
            End If
            sdr.Close()
        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
    Private Sub cboTRANSH_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboTRANSH.ButtonClick
        Select Case e.Button.Index
            Case 1 : ManageCbo.ManageTRANSHSmall(cboTRANSH, FormMode.NewRecord, cboCUS.EditValue)
            Case 2 : ManageCbo.ManageTRANSHSmall(cboTRANSH, FormMode.EditRecord, cboCUS.EditValue)
            Case 3 : cboTRANSH.EditValue = Nothing
        End Select
    End Sub


    Private Sub cmdPrintOffer_Click(sender As Object, e As EventArgs) Handles cmdPrintOffer.Click

        If cboCUS.EditValue <> cboCompany.EditValue Then ' Ενα αφορά το συμφωνητικό τον Κατασκευαστή δεν μας ενδιαφέρει η check List
            If CheckListExist() = False Then
                XtraMessageBox.Show(String.Format("Δεν μπορεί να εκτυπωθεί το Συμφωνητικό γιατί δεν έχει συμπληρωθεί η CheckList του Έργου"), ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
        End If
        CusPrivateAgreement.PrintAgreement()
    End Sub

    Private Sub txtTotalPrice_EditValueChanged(sender As Object, e As EventArgs) Handles TxtTotalVat.EditValueChanged
        If Me.IsActive = False Then Exit Sub
        Dim Price As Double, PartOfVat As Double
        If TxtTotalVat.EditValue <> Nothing Then Price = DbnullToZero(TxtTotalVat) : txtTotalVatPrice.EditValue = Price * ProgProps.AlternateVAT
        If txtPartofVat.EditValue <> Nothing Then PartOfVat = DbnullToZero(txtPartofVat)
    End Sub
    Private Sub txtPartofVat_EditValueChanged(sender As Object, e As EventArgs) Handles txtPartofVat.EditValueChanged
        If Me.IsActive = False Then Exit Sub
        Dim TotalPrice As Double, Price As Double, PartOfVat As Double
        If txtPartofVat.EditValue <> Nothing Then TotalPrice = DbnullToZero(txtPartofVat)
        TotalPrice = (TotalPrice * 100) / ProgProps.VAT + TotalPrice
        txtPosoParastatikou.EditValue = TotalPrice
        If TxtTotalVat.EditValue <> Nothing Then Price = DbnullToZero(TxtTotalVat)
        If txtPartofVat.EditValue <> Nothing Then PartOfVat = DbnullToZero(txtPartofVat)
    End Sub


    Private Sub txtPayinAdvance_EditValueChanged(sender As Object, e As EventArgs) Handles txtPayinAdvanceTot.EditValueChanged
        If Me.IsActive = False Then Exit Sub
        Dim TotalPayinAdvance As Double, CloseTot As Double, BalPayinAdvance As Double
        If txtPayinAdvanceTot.EditValue <> Nothing Then TotalPayinAdvance = DbnullToZero(txtPayinAdvanceTot)
        If txtCloseTot.EditValue <> Nothing Then CloseTot = DbnullToZero(txtCloseTot)
        BalPayinAdvance = CusPayInAdvanceInf() - (TotalPayinAdvance + CloseTot)
        txtPayinAdvanceBal.EditValue = BalPayinAdvance
    End Sub

    Private Sub txtGenTot_EditValueChanged(sender As Object, e As EventArgs) Handles txtGenTot.EditValueChanged
        lblPayInAdvnace.Text = "Ο πελάτης πρέπει να καταβάλει το 50% του έργου: " & CusPayInAdvanceInf() & "€"
    End Sub
    Private Function CusPayInAdvanceInf() As Double
        Dim PayinAdvance As Double
        If txtGenTot.EditValue <> Nothing Then
            PayinAdvance = DbnullToZero(txtGenTot)
            PayinAdvance = PayinAdvance / 2
            lblPayInAdvnace.Text = "Ο πελάτης πρέπει να καταβάλει το 50% του έργου: " & PayinAdvance & "€"
        End If
        Return PayinAdvance
    End Function
    Private Sub chkHasCloset_Click(sender As Object, e As EventArgs) Handles chkHasCloset.Click
        CusPrivateAgreement.OpenOrder(3, cboTRANSH.EditValue.ToString)
    End Sub

    Private Sub chkHasDoors_Click(sender As Object, e As EventArgs) Handles chkHasDoors.Click
        CusPrivateAgreement.OpenOrder(2, cboTRANSH.EditValue.ToString)
    End Sub

    Private Sub chkHasKitchen_Click(sender As Object, e As EventArgs) Handles chkHasKitchen.Click
        CusPrivateAgreement.OpenOrder(1, cboTRANSH.EditValue.ToString)
    End Sub

    Private Sub chkHasSC_Click(sender As Object, e As EventArgs) Handles chkHasSC.Click
        CusPrivateAgreement.OpenOrder(4, cboTRANSH.EditValue.ToString)
    End Sub

    Private Sub cboADR_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboADR.ButtonClick
        Select Case e.Button.Index
            Case 1 : cboADR.EditValue = Nothing : ManageCbo.ManageADR(cboADR, FormMode.NewRecord)
            Case 2 : If cboADR.EditValue <> Nothing Then ManageCbo.ManageADR(cboADR, FormMode.EditRecord)
            Case 3 : cboADR.EditValue = Nothing
        End Select
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
            Case 2 : ManageCbo.ManageCCT(FormMode.EditRecord, False,, cboCompany) : If cboCUS.EditValue = cboCompany.EditValue Then GetCusFields()
            Case 3 : cboCompany.EditValue = Nothing : LCompProject.ImageOptions.Image = Nothing : cmdCompCollection.Enabled = False
        End Select
    End Sub

    Private Sub cmdCollection_Click(sender As Object, e As EventArgs) Handles cmdCompCollection.Click
        If cboCompProject.EditValue Is Nothing Then XtraMessageBox.Show("Δεν έχετε επιλέξει έργο", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error) : Exit Sub
        Dim Frm As frmTransactions = New frmTransactions()
        Frm.Text = "Είσπραξη Πελάτη"
        Frm.CreditOnly = True
        Frm.Mode = FormMode.EditRecord
        Frm.ID = cboCompProject.EditValue.ToString
        Frm.ShowDialog()
        Frm.isCompany = True
        Frm.LayoutControlItem16.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
        If cboCUS.EditValue = cboCompany.EditValue Then
            CusPrivateAgreement.GetKLeisimoAmt(cboTRANSH.EditValue.ToString)
            CusPrivateAgreement.GetPayInAdvanceAmt(cboTRANSH.EditValue.ToString)
            LMsg.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
        End If

    End Sub

    Private Sub cmdCusCollection_Click(sender As Object, e As EventArgs) Handles cmdCusCollection.Click
        If cboTRANSH.EditValue Is Nothing Then XtraMessageBox.Show("Δεν έχετε επιλέξει έργο", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error) : Exit Sub
        Dim Frm As frmTransactions = New frmTransactions()
        Frm.Text = "Είσπραξη Πελάτη"
        Frm.CreditOnly = True
        Frm.Mode = FormMode.EditRecord
        Frm.ID = cboTRANSH.EditValue.ToString
        Frm.lCusD.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        Frm.ShowDialog()
        CusPrivateAgreement.GetKLeisimoAmt(cboTRANSH.EditValue.ToString)
        CusPrivateAgreement.GetPayInAdvanceAmt(cboTRANSH.EditValue.ToString)
        LMsg.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always

    End Sub
    Private Sub GetCreditAmountsFromProject()
        Dim cmd As SqlCommand
        Dim sdr As SqlDataReader
        Try
            cmd = New SqlCommand("SELECT isnull(sum(amt),0) as amt FROM TRANSD WHERE cash=0 and paytypeID='90A295A1-D2A0-40B7-B260-A532B2C322AC'  and transhID = " & toSQLValueS(cboTRANSH.EditValue.ToString), CNDB)
            sdr = cmd.ExecuteReader()
            If (sdr.Read() = True) Then
                If sdr.IsDBNull(sdr.GetOrdinal("amt")) = False Then txtCloseBank.EditValue = sdr.GetDecimal(sdr.GetOrdinal("amt")) Else txtCloseBank.EditValue = Nothing
            Else
                lblBank.Text = ""
                txtCloseBank.EditValue = "0"
            End If
            sdr.Close()
        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cmdCheckList_Click(sender As Object, e As EventArgs) Handles cmdCheckList.Click
        Dim frmAgreementCheckList As New frmAgreementCheckList
        frmAgreementCheckList.ID = sID
        If CheckListExist() Then frmAgreementCheckList.Mode = FormMode.EditRecord Else frmAgreementCheckList.Mode = FormMode.NewRecord
        frmAgreementCheckList.ShowDialog()
    End Sub
    Private Function CheckListExist() As Boolean
        Dim cmd As SqlCommand
        Dim sdr As SqlDataReader
        Dim oID As String = ""
        Try
            cmd = New SqlCommand("select top 1 ID from AGREEMENT_CHECKLIST where AgreementID =  " & toSQLValueS(sID), CNDB)
            sdr = cmd.ExecuteReader()
            If (sdr.Read() = True) Then
                sdr.Close()
                Return True
            Else
                sdr.Close()
                Return False
            End If

        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Function

    Private Sub frmCUSPrivateAgreement_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        If Mode = FormMode.NewRecord Then
            XtraMessageBox.Show("Το συμφωνητικό δεν έχει αποθηκευθεί.", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
            e.Cancel = True
        End If
    End Sub
End Class