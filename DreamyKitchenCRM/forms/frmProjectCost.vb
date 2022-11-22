Imports System.ComponentModel
Imports System.Data.SqlClient
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls

Public Class frmProjectCost
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

    Private Sub frmProjectCost_Load(sender As Object, e As EventArgs) Handles Me.Load
        FillCbo.CUS(cboCUS)

        Select Case Mode
            Case FormMode.NewRecord
                txtCode.Text = DBQ.GetNextId("PROJECT_COST")
            Case FormMode.EditRecord
                LoadForms.LoadForm(LayoutControl1, "Select * from vw_PROJECT_COST where id ='" + sID + "'")
        End Select
        Me.CenterToScreen()
        My.Settings.frmServices = Me.Location
        My.Settings.Save()
        cmdSave.Enabled = IIf(Mode = FormMode.NewRecord, UserProps.AllowInsert, UserProps.AllowEdit)

    End Sub

    Private Sub frmProjectCost_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        If Me.WindowState = FormWindowState.Maximized Then frmMain.XtraTabbedMdiManager1.Dock(Me, frmMain.XtraTabbedMdiManager1)
    End Sub
    Private Sub cboCUS_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboCUS.ButtonClick
        Select Case e.Button.Index
            Case 1 : cboCUS.EditValue = Nothing : ManageCus()
            Case 2 : If cboCUS.EditValue <> Nothing Then ManageCus()
            Case 3 : cboCUS.EditValue = Nothing
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
    Private Sub ManageTRANSH()
        Dim form1 As frmTransactions = New frmTransactions()
        form1.Text = "Χρεωπιστώσεις Πελατών"
        form1.CallerControl = cboTRANSH
        form1.CalledFromControl = True
        form1.MdiParent = frmMain
        If cboTRANSH.EditValue <> Nothing Then
            form1.ID = cboTRANSH.EditValue.ToString
            form1.Mode = FormMode.EditRecord
        End If
        frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(form1), New Point(CInt(form1.Parent.ClientRectangle.Width / 2 - form1.Width / 2), CInt(form1.Parent.ClientRectangle.Height / 2 - form1.Height / 2)))
        form1.Show()
    End Sub
    Private Sub cboTransH_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboTRANSH.ButtonClick
        Select Case e.Button.Index
            Case 1 : If UserProps.ID.ToString.ToUpper = "3F9DC32E-BE5B-4D46-A13C-EA606566CF32" Then  cboTRANSH.EditValue = Nothing : ManageTRANSH()
            Case 2 : If UserProps.ID.ToString.ToUpper = "3F9DC32E-BE5B-4D46-A13C-EA606566CF32" Then  If cboTRANSH.EditValue <> Nothing Then ManageTRANSH()
            Case 3 : cboTRANSH.EditValue = Nothing
        End Select
    End Sub
    Private Sub cboCUS_EditValueChanged(sender As Object, e As EventArgs) Handles cboCUS.EditValueChanged
        Dim sCusID As String
        If cboCUS.EditValue Is Nothing Then sCusID = toSQLValueS(Guid.Empty.ToString) Else sCusID = toSQLValueS(cboCUS.EditValue.ToString)
        Dim sSQL As New System.Text.StringBuilder
        sSQL.AppendLine("Select T.id,FullTranshDescription,Description,
                        DebitCost,DevicesCost,Totamt,isnull(SalerProfit,0) as  SalerProfit,
                        ISNULL((Select sum(ISNULL(C.salary, 0) + ISNULL(C.extracost, 0)) from constr C where transhid=t.id),0) as ConstrPayroll,
                        ISNULL((Select sum(ISNULL(I.cost, 0) + ISNULL(I.extraCost, 0)) from INST I where transhid=t.id),0) as InstPayroll,
                        ISNULL((SELECT sum(KITCHENV) kitchen from BUY B where B.transhID=T.ID),0) as kitchen,
                        ISNULL((SELECT sum(DEVICESBUYV) DEVICESBUY from BUY B where B.transhID=T.ID),0) as DEVICESBUY,
                        ISNULL((SELECT sum(closetV) closet from BUY B where B.transhID=T.ID),0) as closet,
                        ISNULL((SELECT sum(generalV) general from BUY B where B.transhID=T.ID),0) as general,
                        ISNULL((SELECT sum(materialsV) materials from BUY B where B.transhID=T.ID),0) as materials,
                        ISNULL((SELECT sum(bathroomFurnV) bathroomFurn from BUY B where B.transhID=T.ID),0) as bathroomFurn,
                        ISNULL((SELECT sum(measurementV) measurement from BUY B where B.transhID=T.ID),0) as measurement
                        from vw_TRANSH t
                        where  T.cusid = " & sCusID & "order by description")
        FillCbo.TRANSH_FOR_PROJECTCOST(cboTRANSH, sSQL)
    End Sub

    Private Sub cboTRANSH_EditValueChanged(sender As Object, e As EventArgs) Handles cboTRANSH.EditValueChanged
        If cboTRANSH.EditValue = Nothing Then
            txtDebitCost.EditValue = "0" : txtDevicesCost.EditValue = "0" : txtTotAmt.EditValue = "0" : txtSalerProfit.EditValue = "0"
            txtConstrPayroll.EditValue = "0" : txtInstPayroll.EditValue = "0" : txtbathroomFurn.EditValue = "0" : txtcloset.EditValue = "0"
            txtgeneral.EditValue = "0" : txtmaterials.EditValue = "0" : txtDevicesBuy.EditValue = "0" : txtkitchen.EditValue = "0"
        Else
            txtDebitCost.EditValue = cboTRANSH.GetColumnValue("DebitCost")
            txtDevicesCost.EditValue = cboTRANSH.GetColumnValue("DevicesCost")
            txtTotAmt.EditValue = cboTRANSH.GetColumnValue("Totamt")
            txtSalerProfit.EditValue = cboTRANSH.GetColumnValue("SalerProfit")
            txtConstrPayroll.EditValue = cboTRANSH.GetColumnValue("ConstrPayroll")
            txtInstPayroll.EditValue = cboTRANSH.GetColumnValue("InstPayroll")
            txtbathroomFurn.EditValue = cboTRANSH.GetColumnValue("bathroomFurn")
            txtcloset.EditValue = cboTRANSH.GetColumnValue("closet")
            txtgeneral.EditValue = cboTRANSH.GetColumnValue("general")
            txtmaterials.EditValue = cboTRANSH.GetColumnValue("materials")
            txtDevicesBuy.EditValue = cboTRANSH.GetColumnValue("DEVICESBUY")
            txtkitchen.EditValue = cboTRANSH.GetColumnValue("kitchen")
        End If
    End Sub

    Private Sub txtDevicesBuy_EditValueChanged(sender As Object, e As EventArgs) Handles txtDevicesBuy.EditValueChanged
        Dim DevicesBuy As Double, DevicesCost As Double
        If txtDevicesBuy.EditValue Is Nothing Or txtDevicesCost.EditValue Is Nothing Then Exit Sub
        DevicesBuy = DbnullToZero(txtDevicesBuy) : DevicesCost = DbnullToZero(txtDevicesCost)
        txtDevicesProfit.EditValue = DevicesCost - DevicesBuy
    End Sub

    Private Sub txtDevicesCost_EditValueChanged(sender As Object, e As EventArgs) Handles txtDevicesCost.EditValueChanged
        Dim DevicesBuy As Double, DevicesCost As Double
        If txtDevicesBuy.EditValue Is Nothing Or txtDevicesCost.EditValue Is Nothing Then Exit Sub
        DevicesBuy = DbnullToZero(txtDevicesBuy) : DevicesCost = DbnullToZero(txtDevicesCost)
        txtDevicesProfit.EditValue = DevicesCost - DevicesBuy

    End Sub

    Private Sub txtkitchen_EditValueChanged(sender As Object, e As EventArgs) Handles txtkitchen.EditValueChanged
        txtTotBuy.EditValue = TotalBuy()
    End Sub
    Private Function TotalBuy() As Double
        Dim Kitchen As Double, Closet As Double, general As Double, Materials As Double, Doors As Double
        Dim Varnishes As Double, ExtraCus As Double, Transportation As Double, ConstrPayroll As Double
        Dim InstPayroll As Double, salerProfit As Double, Total As Double, DebitCost As Double, Glasses As Double, measurement As Double
        Kitchen = DbnullToZero(txtkitchen) : Closet = DbnullToZero(txtcloset) : general = DbnullToZero(txtgeneral)
        Materials = DbnullToZero(txtmaterials) : Varnishes = DbnullToZero(txtvarnishes) : ExtraCus = DbnullToZero(txtextraCus)
        Transportation = DbnullToZero(txttransportation) : ConstrPayroll = DbnullToZero(txtConstrPayroll) : Glasses = DbnullToZero(txtglasses) : measurement = DbnullToZero(txtmeasurement)
        Doors = DbnullToZero(txtdoors) : InstPayroll = DbnullToZero(txtInstPayroll) : salerProfit = DbnullToZero(txtSalerProfit)
        DebitCost = DbnullToZero(txtDebitCost)
        Total = Kitchen + Closet + general + Materials + Varnishes + ExtraCus + Transportation + ConstrPayroll + Doors + InstPayroll + salerProfit + Glasses + measurement
        Dim TotAmt As Double, TotBuy As Double, MixProfit As Double
        TotAmt = DbnullToZero(txtTotAmt) : TotBuy = DbnullToZero(txtTotBuy)
        txtMixProfit.EditValue = DebitCost - TotBuy : MixProfit = DbnullToZero(txtMixProfit)
        txtMixProfitPerc.EditValue = (MixProfit / DebitCost) * 100
        Return Total
    End Function

    Private Sub txtcloset_EditValueChanged(sender As Object, e As EventArgs) Handles txtcloset.EditValueChanged
        txtTotBuy.EditValue = TotalBuy()
    End Sub

    Private Sub txtgeneral_EditValueChanged(sender As Object, e As EventArgs) Handles txtgeneral.EditValueChanged
        txtTotBuy.EditValue = TotalBuy()
    End Sub

    Private Sub txtmaterials_EditValueChanged(sender As Object, e As EventArgs) Handles txtmaterials.EditValueChanged
        txtTotBuy.EditValue = TotalBuy()
    End Sub

    Private Sub txtdoors_EditValueChanged(sender As Object, e As EventArgs) Handles txtdoors.EditValueChanged
        txtTotBuy.EditValue = TotalBuy()
    End Sub

    Private Sub txtvarnishes_EditValueChanged(sender As Object, e As EventArgs) Handles txtvarnishes.EditValueChanged
        txtTotBuy.EditValue = TotalBuy()
    End Sub

    Private Sub txtextraCus_EditValueChanged(sender As Object, e As EventArgs) Handles txtextraCus.EditValueChanged
        txtTotBuy.EditValue = TotalBuy()
    End Sub

    Private Sub txttransportation_EditValueChanged(sender As Object, e As EventArgs) Handles txttransportation.EditValueChanged
        txtTotBuy.EditValue = TotalBuy()
    End Sub

    Private Sub txtConstrPayroll_EditValueChanged(sender As Object, e As EventArgs) Handles txtConstrPayroll.EditValueChanged
        txtTotBuy.EditValue = TotalBuy()
    End Sub

    Private Sub txtInstPayroll_EditValueChanged(sender As Object, e As EventArgs) Handles txtInstPayroll.EditValueChanged
        txtTotBuy.EditValue = TotalBuy()
    End Sub

    Private Sub txtSalerProfit_EditValueChanged(sender As Object, e As EventArgs) Handles txtSalerProfit.EditValueChanged
        txtTotBuy.EditValue = TotalBuy()
    End Sub

    Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click
        Dim sResult As Boolean
        Dim sGuid As String
        Dim sSQL As New System.Text.StringBuilder
        Dim Kitchen As Double, Closet As Double, general As Double

        Try
            If Valid.ValidateForm(LayoutControl1) Then
                Select Case Mode
                    Case FormMode.NewRecord
                        sGuid = System.Guid.NewGuid.ToString
                        sResult = DBQ.InsertNewData(DBQueries.InsertMode.OneLayoutControl, "PROJECT_COST", LayoutControl1,,, sGuid, True)
                        sID = sGuid
                    Case FormMode.EditRecord
                        sResult = DBQ.UpdateNewData(DBQueries.InsertMode.OneLayoutControl, "PROJECT_COST", LayoutControl1,,, sID, True)
                End Select

                If FScrollerExist = True Then
                    Dim form As frmScroller = Frm
                    form.LoadRecords("vw_PROJECT_COST")
                End If

                If sResult = True Then
                    XtraMessageBox.Show("Η εγγραφή αποθηκέυτηκε με επιτυχία", "Dreamy Kitchen CRM", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    If Mode = FormMode.NewRecord Then
                        Cls.ClearCtrls(LayoutControl1)
                        txtCode.Text = DBQ.GetNextId("PROJECT_COST")
                    End If
                End If
            End If

        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), "Dreamy Kitchen CRM", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cmdExit_Click(sender As Object, e As EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub

    Private Sub txtTotBuy_EditValueChanged(sender As Object, e As EventArgs) Handles txtTotBuy.EditValueChanged
        txtTotBuy.EditValue = TotalBuy()
    End Sub

    Private Sub txtglasses_EditValueChanged(sender As Object, e As EventArgs) Handles txtglasses.EditValueChanged
        txtTotBuy.EditValue = TotalBuy()
    End Sub

    Private Sub txtmeasurement_EditValueChanged(sender As Object, e As EventArgs) Handles txtmeasurement.EditValueChanged
        txtTotBuy.EditValue = TotalBuy()
    End Sub
End Class