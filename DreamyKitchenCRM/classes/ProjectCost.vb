Imports DevExpress.XtraEditors

Public Class ProjectCost
    Private FillCbo As New FillCombos
    Private Valid As New ValidateControls
    Private ID As String
    Private Mode As Byte
    Private CalledFromCtrl As Boolean
    Private CtrlCombo As DevExpress.XtraEditors.LookUpEdit
    Private Cls As New ClearControls
    Private DBQ As New DBQueries
    Private LoadForms As New FormLoader
    Private Frm As frmProjectCost

    Public Sub Initialize(ByVal sFrm As frmProjectCost, ByVal sID As String, ByVal sMode As Byte, ByVal sCalledFromCtrl As Boolean, ByVal sCtrlCombo As DevExpress.XtraEditors.LookUpEdit)
        Frm = sFrm
        ID = sID
        Mode = sMode
        CalledFromCtrl = sCalledFromCtrl
        CtrlCombo = sCtrlCombo
        Frm.Vw_COMPTableAdapter.Fill(Frm.DM_CCT.vw_COMP)
    End Sub
    Public Sub LoadForm()
        FillCbo.CUS(Frm.cboCUS)
        Select Case Mode
            Case FormMode.NewRecord
                Frm.txtCode.Text = DBQ.GetNextId("PROJECT_COST")
            Case FormMode.EditRecord
                LoadForms.LoadForm(Frm.LayoutControl1, "Select * from vw_PROJECT_COST where id ='" + ID + "'")
                FillCompanyProjects(lkupEditValue(Frm.cboCompany), lkupEditValue(Frm.cboCompProject))
        End Select
        Frm.cmdSave.Enabled = IIf(Mode = FormMode.NewRecord, UserProps.AllowInsert, UserProps.AllowEdit)
    End Sub
    Public Sub SaveRecord(ByRef sID As String)
        Dim sResult As Boolean
        Dim sGuid As String
        Dim sSQL As New System.Text.StringBuilder


        Try
            If Valid.ValidateForm(Frm.LayoutControl1) Then
                Select Case Mode
                    Case FormMode.NewRecord
                        sGuid = System.Guid.NewGuid.ToString
                        sResult = DBQ.InsertNewData(DBQueries.InsertMode.OneLayoutControl, "PROJECT_COST", Frm.LayoutControl1,,, sGuid, True)
                        sID = sGuid
                    Case FormMode.EditRecord
                        sResult = DBQ.UpdateNewData(DBQueries.InsertMode.OneLayoutControl, "PROJECT_COST", Frm.LayoutControl1,,, sID, True)
                End Select

                If sResult = True Then
                    XtraMessageBox.Show("Η εγγραφή αποθηκέυτηκε με επιτυχία", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    If Mode = FormMode.NewRecord Then Cls.ClearCtrls(Frm.LayoutControl1) : Frm.txtCode.Text = DBQ.GetNextId("PROJECT_COST")
                End If
            End If

        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Public Function TotalBuy() As Double
        Dim Kitchen As Double, Closet As Double, general As Double, Materials As Double, Doors As Double, kitchenDoors As Double
        Dim Varnishes As Double, ExtraCus As Double, Transportation As Double, ConstrPayroll As Double
        Dim InstPayroll As Double, salerProfit As Double, Total As Double, DebitCost As Double, Glasses As Double, measurement As Double, DevicesBuy As Double
        Kitchen = DbnullToZero(Frm.txtkitchen) : Closet = DbnullToZero(Frm.txtcloset) : general = DbnullToZero(Frm.txtgeneral) : kitchenDoors = DbnullToZero(Frm.txtkitchenDoors)
        Materials = DbnullToZero(Frm.txtmaterials) : Varnishes = DbnullToZero(Frm.txtvarnishes) : ExtraCus = DbnullToZero(Frm.txtextraCus)
        Transportation = DbnullToZero(Frm.txttransportation) : ConstrPayroll = DbnullToZero(Frm.txtConstrPayroll) : Glasses = DbnullToZero(Frm.txtglasses) : measurement = DbnullToZero(Frm.txtmeasurement)
        Doors = DbnullToZero(Frm.txtdoors) : InstPayroll = DbnullToZero(Frm.txtInstPayroll) : salerProfit = DbnullToZero(Frm.txtSalerProfit) : DevicesBuy = DbnullToZero(Frm.txtDevicesBuy)
        DebitCost = DbnullToZero(Frm.txtTotAmt)

        Total = Kitchen + Closet + general + Materials + Varnishes + ExtraCus + Transportation + ConstrPayroll + Doors + InstPayroll + salerProfit + Glasses + measurement + DevicesBuy + kitchenDoors

        Dim TotAmt As Double, TotBuy As Double, MixProfit As Double
        TotAmt = DbnullToZero(Frm.txtTotAmt) : TotBuy = DbnullToZero(Frm.txtTotBuy)
        Frm.txtMixProfit.EditValue = DebitCost - TotBuy : MixProfit = DbnullToZero(Frm.txtMixProfit)
        Frm.txtMixProfitPerc.EditValue = ((TotAmt - TotBuy) / TotAmt) * 100
        Return Total
    End Function
    Public Sub FillCompanyProjects(ByVal sCompID As String, ByVal scompTrashID As String)
        If sCompID = "" Then sCompID = toSQLValueS(Guid.Empty.ToString) Else sCompID = toSQLValueS(sCompID)
        Dim sSQL As New System.Text.StringBuilder
        sSQL.AppendLine("Select T.id,FullTranshDescription,Description
                        from vw_TRANSH t
                        where  T.cusid = " & sCompID & "order by description")
        FillCbo.TRANSH(Frm.cboCompProject, sSQL)
        Frm.LCompProject.ImageOptions.Image = Global.DreamyKitchenCRM.My.Resources.Resources.rsz_11rsz_asterisk
        If scompTrashID <> "" Then Frm.cboCompProject.EditValue = System.Guid.Parse(scompTrashID)
    End Sub
End Class
