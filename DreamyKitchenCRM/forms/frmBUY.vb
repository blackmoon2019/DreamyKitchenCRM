Imports System.ComponentModel
Imports System.Data.SqlClient
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls

Public Class frmBUY
    Private sID As String
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
    Private WorkingTime As Integer
    Private AgreementSalary As Double
    Private UserPermissions As New CheckPermissions

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

    Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click
        Dim sResult As Boolean
        Dim sGuid As String
        Dim sSQL As String
        Try
            If Valid.ValidateForm(LayoutControl1) Then
                Select Case Mode
                    Case FormMode.NewRecord
                        sGuid = System.Guid.NewGuid.ToString
                        sResult = DBQ.InsertNewData(DBQueries.InsertMode.OneLayoutControl, "BUY", LayoutControl1,,, sGuid, True)
                        sID = sGuid
                    Case FormMode.EditRecord
                        sResult = DBQ.UpdateNewData(DBQueries.InsertMode.OneLayoutControl, "BUY", LayoutControl1,,, sID, True)
                        'sGuid = sID
                End Select

                If FScrollerExist = True Then
                    Dim form As frmScroller = Frm
                    form.LoadRecords("vw_BUY")
                End If

                If sResult = True Then
                    XtraMessageBox.Show("Η εγγραφή αποθηκέυτηκε με επιτυχία", "Dreamy Kitchen CRM", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    'Ενημέρωση υπολοίπου προμηθευτή όταν το τιμολόγιο δεν είναι πληρωμένο και δεν είναι μετρητοίς
                    sSQL = "update sup set bal = (select isnull(sum(vatamount),0) from buy where buy.supID=sup.ID and payID<>'88E7A725-AE4C-4818-ADEE-7F9E26F20165' and paid=0)  WHERE ID = " & toSQLValueS(cboSUP.EditValue.ToString)
                    Using oCmd As New SqlCommand(sSQL, CNDB)
                        oCmd.ExecuteNonQuery()
                    End Using
                    If cboTRANSH.EditValue IsNot Nothing Then
                        ' Άνοιγμα έργου αν δεν υπάρχει ή ενημέρωση ποσών
                        Using oCmd As New SqlCommand("usp_CreateProjectcost", CNDB)
                            oCmd.CommandType = CommandType.StoredProcedure
                            oCmd.Parameters.AddWithValue("@transhID", cboTRANSH.EditValue.ToString)
                            oCmd.ExecuteNonQuery()
                        End Using
                    End If
                    If Mode = FormMode.NewRecord Then
                            Cls.ClearCtrls(LayoutControl1)
                            txtCode.Text = DBQ.GetNextId("BUY")
                        End If
                    End If
                End If

        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), "Dreamy Kitchen CRM", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub frmBUY_Load(sender As Object, e As EventArgs) Handles Me.Load
        FillCbo.CUS(cboCUS)
        FillCbo.SUP(cboSUP)
        FillCbo.BUY_C(cbobuyC)
        FillCbo.PAY(cboPAY)

        Select Case Mode
            Case FormMode.NewRecord
                txtCode.Text = DBQ.GetNextId("BUY")
            Case FormMode.EditRecord
                LoadForms.LoadForm(LayoutControl1, "Select * from vw_BUY where id ='" + sID + "'")
        End Select
        Me.CenterToScreen()
        My.Settings.frmBUY = Me.Location
        My.Settings.Save()
        cmdSave.Enabled = IIf(Mode = FormMode.NewRecord, UserProps.AllowInsert, UserProps.AllowEdit)

    End Sub
    Private Sub cboCUS_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboCUS.ButtonClick
        Select Case e.Button.Index
            Case 1 : cboCUS.EditValue = Nothing : ManageCus()
            Case 2 : If cboCUS.EditValue <> Nothing Then ManageCus()
            Case 3 : cboCUS.EditValue = Nothing
        End Select
    End Sub
    Private Sub cboCUS_EditValueChanged(sender As Object, e As EventArgs) Handles cboCUS.EditValueChanged
        Dim sCusID As String
        If cboCUS.EditValue Is Nothing Then sCusID = Guid.Empty.ToString Else sCusID = cboCUS.EditValue.ToString
        Me.Vw_TRANSHTableAdapter.Fill(Me.DreamyKitchenDataSet.vw_TRANSH, System.Guid.Parse(sCusID))
    End Sub

    Private Sub frmBUY_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        If Me.WindowState = FormWindowState.Maximized Then frmMain.XtraTabbedMdiManager1.Dock(Me, frmMain.XtraTabbedMdiManager1)
    End Sub
    Private Sub ManageTRANSH()
        Dim form1 As frmTransactions = New frmTransactions()
        form1.Text = "Χρεωπιστώσεις Πελατών"
        form1.CallerControl = cboTRANSH
        form1.CalledFromControl = True
        form1.MdiParent = frmMain
        If cboTRANSH.EditValue <> Nothing Then
            form1.ID = cboTRANSH.EditValue.ToString
            form1.Mode = FormMode.EditRecord
        Else
            form1.Mode = FormMode.NewRecord
        End If

        frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(form1), New Point(CInt(form1.Parent.ClientRectangle.Width / 2 - form1.Width / 2), CInt(form1.Parent.ClientRectangle.Height / 2 - form1.Height / 2)))
        form1.Show()
    End Sub
    Private Sub cboTRANSH_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboTRANSH.ButtonClick
        Select Case e.Button.Index
            Case 1 : If UserPermissions.CheckViewPermission("Χρεωπιστώσεις") Then cboTRANSH.EditValue = Nothing : ManageTRANSH()
            Case 2 : If UserPermissions.CheckViewPermission("Χρεωπιστώσεις") Then If cboTRANSH.EditValue <> Nothing Then ManageTRANSH()
            Case 3 : cboTRANSH.EditValue = Nothing
        End Select
    End Sub
    Private Sub ManageCus()
        Dim form1 As frmCustomers = New frmCustomers()
        form1.Text = "Πελάτες"
        form1.CallerControl = cboCUS
        form1.CalledFromControl = True
        form1.MdiParent = frmMain
        If cboCUS.EditValue <> Nothing Then
            form1.ID = cboCUS.EditValue.ToString
            form1.Mode = FormMode.EditRecord
        Else
            form1.Mode = FormMode.NewRecord
        End If
        frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(form1), New Point(CInt(form1.Parent.ClientRectangle.Width / 2 - form1.Width / 2), CInt(form1.Parent.ClientRectangle.Height / 2 - form1.Height / 2)))
        form1.Show()

    End Sub

    Private Sub cboSUP_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboSUP.ButtonClick
        Select Case e.Button.Index
            Case 1 : cboSUP.EditValue = Nothing : ManageSup()
            Case 2 : If cboSUP.EditValue <> Nothing Then ManageSup()
            Case 3 : cboSUP.EditValue = Nothing : cboPAY.EditValue = Nothing
        End Select
    End Sub
    Private Sub ManageSup()
        Dim form1 As frmSUP = New frmSUP()
        form1.Text = "Προμηθευτές"
        form1.CallerControl = cboSUP
        form1.CalledFromControl = True
        form1.MdiParent = frmMain
        If cboSUP.EditValue <> Nothing Then
            form1.ID = cboSUP.EditValue.ToString
            form1.Mode = FormMode.EditRecord
        Else
            form1.Mode = FormMode.NewRecord
        End If
        frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(form1), New Point(CInt(form1.Parent.ClientRectangle.Width / 2 - form1.Width / 2), CInt(form1.Parent.ClientRectangle.Height / 2 - form1.Height / 2)))
        form1.Show()

    End Sub

    Private Sub cbobuyC_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cbobuyC.ButtonClick
        Select Case e.Button.Index
            Case 1 : cbobuyC.EditValue = Nothing : ManageBUY_C()
            Case 2 : If cbobuyC.EditValue <> Nothing Then ManageBUY_C()
            Case 3 : cbobuyC.EditValue = Nothing
        End Select
    End Sub
    Private Sub ManageBUY_C()
        Dim form1 As frmGen = New frmGen()
        form1.Text = "Κατηγορίες Αγορών"
        form1.CallerControl = cbobuyC
        form1.CalledFromControl = True
        form1.MdiParent = frmMain
        If cbobuyC.EditValue <> Nothing Then
            form1.ID = cbobuyC.EditValue.ToString
            form1.Mode = FormMode.EditRecord
        Else
            form1.Mode = FormMode.NewRecord
        End If
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
        If cboPAY.EditValue <> Nothing Then form1.ID = cboPAY.EditValue.ToString
        form1.MdiParent = frmMain
        If cboPAY.EditValue <> Nothing Then form1.Mode = FormMode.EditRecord Else form1.Mode = FormMode.NewRecord
        frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(form1), New Point(CInt(form1.Parent.ClientRectangle.Width / 2 - form1.Width / 2), CInt(form1.Parent.ClientRectangle.Height / 2 - form1.Height / 2)))
        form1.Show()
    End Sub
    Private Sub txtnetAmount_EditValueChanged(sender As Object, e As EventArgs) Handles txtnetAmount.EditValueChanged
        Dim Net As Double, Vat As Double
        If txtnetAmount.EditValue Is Nothing Or txtvatAmount.EditValue Is Nothing Then Exit Sub
        Net = DbnullToZero(txtnetAmount) : Vat = DbnullToZero(txtvatAmount)
        txtvatAmount.EditValue = Net * 1.24
    End Sub

    Private Sub txtDevicesBuy_EditValueChanged(sender As Object, e As EventArgs) Handles txtDevicesBuy.EditValueChanged
        txtnetAmount.EditValue = CalculateNetAmount()
    End Sub
    Private Function CalculateNetAmount() As Double
        Dim DevicesBuy As Double, bathroomFurn As Double, closet As Double, general As Double, materials As Double, kitchen As Double, Total As Double
        Dim Bench As Double, transportation As Double, glasses As Double
        DevicesBuy = DbnullToZero(txtDevicesBuy) : bathroomFurn = DbnullToZero(txtbathroomFurn) : closet = DbnullToZero(txtcloset)
        transportation = DbnullToZero(txttransportation) : Bench = DbnullToZero(txtbench) : glasses = DbnullToZero(txtglasses)
        general = DbnullToZero(txtgeneral) : materials = DbnullToZero(txtmaterials) : kitchen = DbnullToZero(txtkitchen)
        Total = DevicesBuy + bathroomFurn + closet + general + materials + kitchen + transportation + Bench + glasses
        If chkCredit.Checked = True Then Total = Total * -1 Else Total = Math.Abs(Total)
        Return Total
    End Function

    Private Sub txtkitchen_EditValueChanged(sender As Object, e As EventArgs) Handles txtkitchen.EditValueChanged
        txtnetAmount.EditValue = CalculateNetAmount()
    End Sub

    Private Sub txtcloset_EditValueChanged(sender As Object, e As EventArgs) Handles txtcloset.EditValueChanged
        txtnetAmount.EditValue = CalculateNetAmount()
    End Sub

    Private Sub txtbathroomFurn_EditValueChanged(sender As Object, e As EventArgs) Handles txtbathroomFurn.EditValueChanged
        txtnetAmount.EditValue = CalculateNetAmount()
    End Sub

    Private Sub txtmaterials_EditValueChanged(sender As Object, e As EventArgs) Handles txtmaterials.EditValueChanged
        txtnetAmount.EditValue = CalculateNetAmount()
    End Sub

    Private Sub txtgeneral_EditValueChanged(sender As Object, e As EventArgs) Handles txtgeneral.EditValueChanged
        txtnetAmount.EditValue = CalculateNetAmount()
    End Sub


    Private Sub cboPAY_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboPAY.ButtonClick
        Select Case e.Button.Index
            Case 1 : cboPAY.EditValue = Nothing : ManagePAY()
            Case 2 : If cboPAY.EditValue <> Nothing Then ManagePAY()
            Case 3 : cboPAY.EditValue = Nothing
        End Select
    End Sub

    Private Sub cboSUP_EditValueChanged(sender As Object, e As EventArgs) Handles cboSUP.EditValueChanged
        cboPAY.EditValue = cboSUP.GetColumnValue("payID")
        If cboPAY.EditValue = Nothing Then Exit Sub
        If cboPAY.EditValue.ToString.ToUpper = "88E7A725-AE4C-4818-ADEE-7F9E26F20165" Then chkPaid.CheckState = CheckState.Checked Else chkPaid.CheckState = CheckState.Unchecked
    End Sub

    Private Sub txttransportation_EditValueChanged(sender As Object, e As EventArgs) Handles txttransportation.EditValueChanged
        txtnetAmount.EditValue = CalculateNetAmount()
    End Sub

    Private Sub txtglasses_EditValueChanged(sender As Object, e As EventArgs) Handles txtglasses.EditValueChanged
        txtnetAmount.EditValue = CalculateNetAmount()
    End Sub

    Private Sub txtbench_EditValueChanged(sender As Object, e As EventArgs) Handles txtbench.EditValueChanged
        txtnetAmount.EditValue = CalculateNetAmount()
    End Sub
End Class