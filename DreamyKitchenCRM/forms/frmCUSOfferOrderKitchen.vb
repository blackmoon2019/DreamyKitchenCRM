Imports System.Data.SqlClient
Imports DevExpress.XtraBars.Navigation
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid

Public Class frmCUSOfferOrderKitchen
    Private CusOfferOrderKitchen As New CusOfferOrderKitchen
    Private ManageCbo As New CombosManager
    Private sID As String
    Private sBaseCat As Integer
    Private sIsOrder As Boolean
    Private Ctrl As DevExpress.XtraGrid.Views.Grid.GridView
    Private Frm As DevExpress.XtraEditors.XtraForm
    Public Mode As Byte
    Private FScrollerExist As Boolean = False
    Private FillCbo As New FillCombos
    Private DBQ As New DBQueries
    Private LoadForms As New FormLoader
    Private CtrlCombo As DevExpress.XtraEditors.LookUpEdit
    Private CalledFromCtrl As Boolean
    Public WriteOnly Property BaseCat As Integer
        Set(value As Integer)
            sBaseCat = value
        End Set
    End Property
    Public WriteOnly Property IsOrder As Boolean
        Set(value As Boolean)
            sIsOrder = value
        End Set
    End Property
    Public ReadOnly Property IsOrderRead As Boolean
        Get
            Return sIsOrder
        End Get
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
    Private Sub frmCUSOrderKitchen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CusOfferOrderKitchen.Initialize(Me, sID, Mode, CalledFromCtrl, CtrlCombo, sIsOrder, sBaseCat)
        CusOfferOrderKitchen.LoadForm()
        Me.CenterToScreen()
    End Sub


    Private Sub RepDefPrice_ButtonPressed(sender As Object, e As ButtonPressedEventArgs) Handles RepDefPrice.ButtonPressed
        Select Case e.Button.Index
            Case 0
                Dim sDefPrice As Decimal
                If GridView2.GetRowCellValue(GridView2.FocusedRowHandle, "defPrice") = Nothing Then
                    sDefPrice = 0
                Else
                    sDefPrice = GridView2.GetRowCellValue(GridView2.FocusedRowHandle, "defPrice")
                End If
                GridView2.SetRowCellValue(GridView2.FocusedRowHandle, "price", sDefPrice)
            Case 1 : GridView2.SetRowCellValue(GridView2.FocusedRowHandle, "price", "0.00")
        End Select
    End Sub

    Private Sub frmCUSOrderKitchen_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        If Me.WindowState = FormWindowState.Maximized Then frmMain.XtraTabbedMdiManager1.Dock(Me, frmMain.XtraTabbedMdiManager1)
    End Sub

    Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click
        CusOfferOrderKitchen.SaveRecord(sID)
    End Sub

    Private Sub cboCUS_EditValueChanged(sender As Object, e As EventArgs) Handles cboCUS.EditValueChanged
        FillCusTransh
    End Sub

    Private Sub txtdtdaysOfDelivery_EditValueChanged(sender As Object, e As EventArgs) Handles txtdtdaysOfDelivery.EditValueChanged
        If dtOrder.EditValue Is Nothing Then Exit Sub
        If dtOrder.EditValue.ToString = "" Then Exit Sub
        Dim FirstDate As Date = dtOrder.EditValue
        lblDate.Text = "Ημερομηνία Παράδοσης: " & DateAdd("d", CDbl(txtdtdaysOfDelivery.EditValue.ToString), FirstDate).ToString("dd/MM/yyyy")
    End Sub

    Private Sub dtpresentation_EditValueChanged(sender As Object, e As EventArgs) Handles dtOrder.EditValueChanged
        If dtOrder.EditValue Is Nothing Then Exit Sub
        If dtOrder.EditValue.ToString = "" Then Exit Sub
        Dim FirstDate As Date = dtOrder.EditValue
        If txtdtdaysOfDelivery.EditValue Is Nothing Then txtdtdaysOfDelivery.EditValue = 0
        lblDate.Text = "Ημερομηνία Παράδοσης: " & DateAdd("d", CDbl(txtdtdaysOfDelivery.EditValue.ToString), FirstDate).ToString("dd/MM/yyyy")
    End Sub

    Private Sub cboVType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboVType.SelectedIndexChanged
        If cboVType.SelectedIndex = 1 Then
            cboGOLAColors.ReadOnly = False
        Else
            cboGOLAColors.ReadOnly = True
            cboGOLAColors.EditValue = Nothing
        End If
    End Sub

    Private Sub txtTotalErmariaVat_EditValueChanged(sender As Object, e As EventArgs) Handles txtTotalErmariaVat.EditValueChanged
        Dim TotalErmariaPrice As Double
        TotalErmariaPrice = (txtTotalErmariaVat.EditValue * (ProgProps.VAT / 100)) + txtTotalErmariaVat.EditValue
        txtTotalErmariaPice.EditValue = TotalErmariaPrice
    End Sub

    Private Sub GridView1_PopupMenuShowing(sender As Object, e As PopupMenuShowingEventArgs) Handles GridView1.PopupMenuShowing
        If e.MenuType = GridMenuType.Column Then LoadForms.PopupMenuShow(e, GridView1, "CCT_ORDERS_KITCHEN_DEVICES_def.xml", "vw_CCT_ORDERS_KITCHEN_DEVICES")
    End Sub
    Private Sub GridView2_PopupMenuShowing(sender As Object, e As PopupMenuShowingEventArgs) Handles GridView2.PopupMenuShowing
        If e.MenuType = GridMenuType.Column Then LoadForms.PopupMenuShow(e, GridView2, "CCT_ORDERS_KITCHEN_EQUIPMENT_def.xml", "vw_CCT_ORDERS_KITCHEN_EQUIPMENT")
    End Sub

    Private Sub cmdPrintOffer_Click(sender As Object, e As EventArgs) Handles cmdPrintOffer.Click
        CusOfferOrderKitchen.PrintOffer()
    End Sub

    Private Sub cboTRANSH_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboTRANSH.ButtonClick
        Select Case e.Button.Index
            Case 1
                If cboEMP.Text = "" Then XtraMessageBox.Show("Δεν έχετε επιλέξει πωλητή", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error) : Exit Sub
                ManageCbo.ManageTRANSHSmall(cboTRANSH, FormMode.NewRecord, cboCUS.EditValue,, cboEMP.EditValue, cboCompany.EditValue, cboCompProject.EditValue)
            Case 2 : ManageCbo.ManageTRANSHSmall(cboTRANSH, FormMode.EditRecord, cboCUS.EditValue)
            Case 3 : cboTRANSH.EditValue = Nothing
        End Select
    End Sub

    Private Sub cmdSaveEquipDev_Click(sender As Object, e As EventArgs) Handles cmdSaveEquipDev.Click
        CusOfferOrderKitchen.InsertSelectedRows(True)
    End Sub

    Private Sub GridView1_CustomDrawFooterCell(sender As Object, e As FooterCellCustomDrawEventArgs) Handles GridView1.CustomDrawFooterCell
        Dim sSQL As String
        Dim cmd As SqlCommand
        Try
            txtTotalDevicesPrice.EditValue = GridView1.Columns("price").SummaryItem.SummaryValue

            sSQL = "Update CCT_ORDERS_KITCHEN set TotalEquipmentPrice = " & toSQLValueS(txtTotalDevicesPrice.EditValue.ToString, True) & " where ID = " & toSQLValueS(sID)
            cmd = New SqlCommand(sSQL, CNDB) : cmd.ExecuteNonQuery()
        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub chkVatVisible_CheckedChanged(sender As Object, e As EventArgs) Handles chkVatVisible.CheckedChanged
        Dim cmd As SqlCommand
        If chkVatVisible.Checked = True Then
            cmd = New SqlCommand("Update CCT_ORDERS_KITCHEN set visibleVAT = 1 where ID = " & toSQLValueS(sID), CNDB) : cmd.ExecuteNonQuery()
        Else
            cmd = New SqlCommand("Update CCT_ORDERS_KITCHEN set visibleVAT = 0 where ID = " & toSQLValueS(sID), CNDB) : cmd.ExecuteNonQuery()
        End If
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
            Case 1 : ManageCbo.ManageCCT(FormMode.NewRecord, False,, cboCUS)
            Case 2 : ManageCbo.ManageCCT(FormMode.EditRecord, False,, cboCUS)
            Case 3 : cboCUS.EditValue = Nothing
        End Select
    End Sub
    Private Sub cboVBOXColors_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboVBOXColors.ButtonClick
        Select Case e.Button.Index
            Case 1 : ManageCbo.ManageValueListItem(cboVBOXColors, FormMode.NewRecord, "DE86FD16-2154-4E2A-B025-4D34BDF8C808")
            Case 2 : ManageCbo.ManageValueListItem(cboVBOXColors, FormMode.EditRecord)
            Case 3 : cboVBOXColors.EditValue = Nothing
        End Select
    End Sub

    Private Sub cboKBOXColors_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboKBOXColors.ButtonClick
        Select Case e.Button.Index
            Case 1 : ManageCbo.ManageValueListItem(cboKBOXColors, FormMode.NewRecord, "DE86FD16-2154-4E2A-B025-4D34BDF8C808")
            Case 2 : ManageCbo.ManageValueListItem(cboKBOXColors, FormMode.EditRecord)
            Case 3 : cboKBOXColors.EditValue = Nothing
        End Select
    End Sub


    Private Sub cboYBOXColors_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboYBOXColors.ButtonClick
        Select Case e.Button.Index
            Case 1 : ManageCbo.ManageValueListItem(cboYBOXColors, FormMode.NewRecord, "DE86FD16-2154-4E2A-B025-4D34BDF8C808")
            Case 2 : ManageCbo.ManageValueListItem(cboYBOXColors, FormMode.EditRecord)
            Case 3 : cboYBOXColors.EditValue = Nothing
        End Select
    End Sub

    Private Sub cboGOLAColors_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboGOLAColors.ButtonClick
        Select Case e.Button.Index
            Case 1 : ManageCbo.ManageValueListItem(cboGOLAColors, FormMode.NewRecord, "DE86FD16-2154-4E2A-B025-4D34BDF8C808")
            Case 2 : ManageCbo.ManageValueListItem(cboGOLAColors, FormMode.EditRecord)
            Case 3 : cboGOLAColors.EditValue = Nothing
        End Select
    End Sub

    Private Sub cboVVALUELISTITEM_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboVVALUELISTITEM.ButtonClick
        Select Case e.Button.Index
            Case 1 : ManageCbo.ManageValueListItem(cboVVALUELISTITEM, FormMode.NewRecord, "DE86FD16-2154-4E2A-B025-4D34BDF8C808")
            Case 2 : ManageCbo.ManageValueListItem(cboVVALUELISTITEM, FormMode.EditRecord)
            Case 3 : cboVVALUELISTITEM.EditValue = Nothing
        End Select
    End Sub
    Private Sub cboKVALUELISTITEM_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboKVALUELISTITEM.ButtonClick
        Select Case e.Button.Index
            Case 1 : ManageCbo.ManageValueListItem(cboKVALUELISTITEM, FormMode.NewRecord, "DE86FD16-2154-4E2A-B025-4D34BDF8C808")
            Case 2 : ManageCbo.ManageValueListItem(cboKVALUELISTITEM, FormMode.EditRecord)
            Case 3 : cboKVALUELISTITEM.EditValue = Nothing
        End Select
    End Sub
    Private Sub cboYVALUELISTITEM_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboYVALUELISTITEM.ButtonClick
        Select Case e.Button.Index
            Case 1 : ManageCbo.ManageValueListItem(cboYVALUELISTITEM, FormMode.NewRecord, "DE86FD16-2154-4E2A-B025-4D34BDF8C808")
            Case 2 : ManageCbo.ManageValueListItem(cboYVALUELISTITEM, FormMode.EditRecord)
            Case 3 : cboYVALUELISTITEM.EditValue = Nothing
        End Select
    End Sub
    Private Sub cboVVALUELISTITEM1_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboVVALUELISTITEM1.ButtonClick
        Select Case e.Button.Index
            Case 1 : ManageCbo.ManageValueListItem(cboVVALUELISTITEM1, FormMode.NewRecord, "DE86FD16-2154-4E2A-B025-4D34BDF8C808")
            Case 2 : ManageCbo.ManageValueListItem(cboVVALUELISTITEM1, FormMode.EditRecord)
            Case 3 : cboVVALUELISTITEM1.EditValue = Nothing
        End Select
    End Sub
    Private Sub cboKVALUELISTITEM1_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboKVALUELISTITEM1.ButtonClick
        Select Case e.Button.Index
            Case 1 : ManageCbo.ManageValueListItem(cboKVALUELISTITEM1, FormMode.NewRecord, "DE86FD16-2154-4E2A-B025-4D34BDF8C808")
            Case 2 : ManageCbo.ManageValueListItem(cboKVALUELISTITEM1, FormMode.EditRecord)
            Case 3 : cboKVALUELISTITEM1.EditValue = Nothing
        End Select
    End Sub
    Private Sub cboYVALUELISTITEM1_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboYVALUELISTITEM1.ButtonClick
        Select Case e.Button.Index
            Case 1 : ManageCbo.ManageValueListItem(cboYVALUELISTITEM1, FormMode.NewRecord, "DE86FD16-2154-4E2A-B025-4D34BDF8C808")
            Case 2 : ManageCbo.ManageValueListItem(cboYVALUELISTITEM1, FormMode.EditRecord)
            Case 3 : cboYVALUELISTITEM1.EditValue = Nothing
        End Select
    End Sub
    Private Sub cboVependisisVALUELISTITEM_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboVependisisVALUELISTITEM.ButtonClick
        Select Case e.Button.Index
            Case 1 : ManageCbo.ManageValueListItem(cboVependisisVALUELISTITEM, FormMode.NewRecord, "DE86FD16-2154-4E2A-B025-4D34BDF8C808")
            Case 2 : ManageCbo.ManageValueListItem(cboVependisisVALUELISTITEM, FormMode.EditRecord)
            Case 3 : cboVependisisVALUELISTITEM.EditValue = Nothing
        End Select
    End Sub
    Private Sub cboKependisisVALUELISTITEM_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboKependisisVALUELISTITEM.ButtonClick
        Select Case e.Button.Index
            Case 1 : ManageCbo.ManageValueListItem(cboKependisisVALUELISTITEM, FormMode.NewRecord, "DE86FD16-2154-4E2A-B025-4D34BDF8C808")
            Case 2 : ManageCbo.ManageValueListItem(cboKependisisVALUELISTITEM, FormMode.EditRecord)
            Case 3 : cboKependisisVALUELISTITEM.EditValue = Nothing
        End Select
    End Sub
    Private Sub cboSndEpendisisVALUELISTITEM_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboSndEpendisisVALUELISTITEM.ButtonClick
        Select Case e.Button.Index
            Case 1 : ManageCbo.ManageValueListItem(cboSndEpendisisVALUELISTITEM, FormMode.NewRecord, "DE86FD16-2154-4E2A-B025-4D34BDF8C808")
            Case 2 : ManageCbo.ManageValueListItem(cboSndEpendisisVALUELISTITEM, FormMode.EditRecord)
            Case 3 : cboSndEpendisisVALUELISTITEM.EditValue = Nothing
        End Select
    End Sub
    Private Sub cboNependisisVALUELISTITEM_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboNependisisVALUELISTITEM.ButtonClick
        Select Case e.Button.Index
            Case 1 : ManageCbo.ManageValueListItem(cboNependisisVALUELISTITEM, FormMode.NewRecord, "DE86FD16-2154-4E2A-B025-4D34BDF8C808")
            Case 2 : ManageCbo.ManageValueListItem(cboNependisisVALUELISTITEM, FormMode.EditRecord)
            Case 3 : cboNependisisVALUELISTITEM.EditValue = Nothing
        End Select
    End Sub
    Private Sub cboVRafieraVALUELISTITEM_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboVRafieraVALUELISTITEM.ButtonClick
        Select Case e.Button.Index
            Case 1 : ManageCbo.ManageValueListItem(cboVRafieraVALUELISTITEM, FormMode.NewRecord, "DE86FD16-2154-4E2A-B025-4D34BDF8C808")
            Case 2 : ManageCbo.ManageValueListItem(cboVRafieraVALUELISTITEM, FormMode.EditRecord)
            Case 3 : cboVRafieraVALUELISTITEM.EditValue = Nothing
        End Select
    End Sub
    Private Sub cboYRafieraVALUELISTITEM_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboYRafieraVALUELISTITEM.ButtonClick
        Select Case e.Button.Index
            Case 1 : ManageCbo.ManageValueListItem(cboYRafieraVALUELISTITEM, FormMode.NewRecord, "DE86FD16-2154-4E2A-B025-4D34BDF8C808")
            Case 2 : ManageCbo.ManageValueListItem(cboYRafieraVALUELISTITEM, FormMode.EditRecord)
            Case 3 : cboYRafieraVALUELISTITEM.EditValue = Nothing
        End Select
    End Sub
    Private Sub cboKRafieraVALUELISTITEM_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboKRafieraVALUELISTITEM.ButtonClick
        Select Case e.Button.Index
            Case 1 : ManageCbo.ManageValueListItem(cboKRafieraVALUELISTITEM, FormMode.NewRecord, "DE86FD16-2154-4E2A-B025-4D34BDF8C808")
            Case 2 : ManageCbo.ManageValueListItem(cboKRafieraVALUELISTITEM, FormMode.EditRecord)
            Case 3 : cboKRafieraVALUELISTITEM.EditValue = Nothing
        End Select
    End Sub
    Private Sub cboBenchType_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboBenchType.ButtonClick
        Select Case e.Button.Index
            Case 1 : ManageCbo.ManageValueListItem(cboBenchType, FormMode.NewRecord, "D08B9371-F94A-48F9-8021-C1661120ED8C")
            Case 2 : ManageCbo.ManageValueListItem(cboBenchType, FormMode.EditRecord)
            Case 3 : cboBenchType.EditValue = Nothing
        End Select
    End Sub
    Private Sub cboBenchType1_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboBenchType1.ButtonClick
        Select Case e.Button.Index
            Case 1 : ManageCbo.ManageValueListItem(cboBenchType1, FormMode.NewRecord, "D08B9371-F94A-48F9-8021-C1661120ED8C")
            Case 2 : ManageCbo.ManageValueListItem(cboBenchType1, FormMode.EditRecord)
            Case 3 : cboBenchType1.EditValue = Nothing
        End Select
    End Sub
    Private Sub cboBenchType2_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboBenchType2.ButtonClick
        Select Case e.Button.Index
            Case 1 : ManageCbo.ManageValueListItem(cboBenchType2, FormMode.NewRecord, "D08B9371-F94A-48F9-8021-C1661120ED8C")
            Case 2 : ManageCbo.ManageValueListItem(cboBenchType2, FormMode.EditRecord)
            Case 3 : cboBenchType2.EditValue = Nothing
        End Select
    End Sub
    Private Sub cboBack_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboBack.ButtonClick
        Select Case e.Button.Index
            Case 1 : ManageCbo.ManageValueListItem(cboBack, FormMode.NewRecord, "D08B9371-F94A-48F9-8021-C1661120ED8C")
            Case 2 : ManageCbo.ManageValueListItem(cboBack, FormMode.EditRecord)
            Case 3 : cboBack.EditValue = Nothing
        End Select
    End Sub
    Private Sub cboKWallRafiaVALUELISTITEM_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboKWallRafiaVALUELISTITEM.ButtonClick
        Select Case e.Button.Index
            Case 1 : ManageCbo.ManageValueListItem(cboKWallRafiaVALUELISTITEM, FormMode.NewRecord, "DE86FD16-2154-4E2A-B025-4D34BDF8C808")
            Case 2 : ManageCbo.ManageValueListItem(cboKWallRafiaVALUELISTITEM, FormMode.EditRecord)
            Case 3 : cboKWallRafiaVALUELISTITEM.EditValue = Nothing
        End Select
    End Sub
    Private Sub cboPependisisVALUELISTITEM_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboPependisisVALUELISTITEM.ButtonClick
        Select Case e.Button.Index
            Case 1 : ManageCbo.ManageValueListItem(cboPependisisVALUELISTITEM, FormMode.NewRecord, "DE86FD16-2154-4E2A-B025-4D34BDF8C808")
            Case 2 : ManageCbo.ManageValueListItem(cboPependisisVALUELISTITEM, FormMode.EditRecord)
            Case 3 : cboPependisisVALUELISTITEM.EditValue = Nothing
        End Select
    End Sub
    Private Sub cboPependisisVALUELISTITEM2_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboPependisisVALUELISTITEM2.ButtonClick

        Select Case e.Button.Index
            Case 1 : ManageCbo.ManageValueListItem(cboPependisisVALUELISTITEM2, FormMode.NewRecord, "DE86FD16-2154-4E2A-B025-4D34BDF8C808")
            Case 2 : ManageCbo.ManageValueListItem(cboPependisisVALUELISTITEM2, FormMode.EditRecord)
            Case 3 : cboPependisisVALUELISTITEM2.EditValue = Nothing
        End Select
    End Sub
    Private Sub cbovType_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboVType.ButtonClick
        Select Case e.Button.Index
            Case 1 : cboVType.EditValue = Nothing : cboVBOXColors.EditValue = Nothing
        End Select
    End Sub
    Private Sub cboKType_ButtonClick(sender As Object, e As ButtonPressedEventArgs)
        Select Case e.Button.Index
            Case 1 : cboKBOXColors.EditValue = Nothing
        End Select
    End Sub
    Private Sub cboyType_ButtonClick(sender As Object, e As ButtonPressedEventArgs)
        Select Case e.Button.Index
            Case 1 : cboYBOXColors.EditValue = Nothing
        End Select
    End Sub

    Private Sub cboBaza_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboBaza.ButtonClick
        Select Case e.Button.Index
            Case 1 : cboBaza.EditValue = Nothing
        End Select
    End Sub

    Private Sub cboLegs_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboLegs.ButtonClick
        Select Case e.Button.Index
            Case 1 : cboLegs.EditValue = Nothing
        End Select
    End Sub

    Private Sub cboVwater_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboVwater.ButtonClick
        Select Case e.Button.Index
            Case 1 : cboVwater.EditValue = Nothing
        End Select
    End Sub
    Private Sub cboYwater_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboYwater.ButtonClick
        Select Case e.Button.Index
            Case 1 : cboYwater.EditValue = Nothing
        End Select
    End Sub
    Private Sub cboKwater_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboKwater.ButtonClick
        Select Case e.Button.Index
            Case 1 : cboKwater.EditValue = Nothing
        End Select
    End Sub

    Private Sub cboLedProfil_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboLedProfil.ButtonClick
        Select Case e.Button.Index
            Case 1 : cboLedProfil.EditValue = Nothing
        End Select
    End Sub

    Private Sub TabPane1_SelectedPageChanged(sender As Object, e As SelectedPageChangedEventArgs) Handles TabPane1.SelectedPageChanged
        Select Case TabPane1.SelectedPageIndex
            Case 1
                LoadForms.RestoreLayoutFromXml(GridView2, "CCT_ORDERS_KITCHEN_EQUIPMENT_def.xml")
                LoadForms.RestoreLayoutFromXml(GridView1, "CCT_ORDERS_KITCHEN_DEVICES_def.xml")
            Case 2
            Case 3
                LoadForms.RestoreLayoutFromXml(GridView3, "vw_TRANSH_F_KITCHEN_def.xml")
                TRANSH_FTableAdapter.FillByTanshID(DM_TRANS.TRANSH_F, System.Guid.Parse(cboTRANSH.EditValue.ToString))
        End Select
    End Sub
    Private Sub GridControl2_DoubleClick(sender As Object, e As EventArgs) Handles GridControl2.DoubleClick
        OpenFileFromGrid(GridView3, "TRANSH_F")
    End Sub

    Private Sub GridView2_ValidatingEditor(sender As Object, e As BaseContainerValidateEditorEventArgs) Handles GridView2.ValidatingEditor
        Dim grdView As GridView = sender
        If grdView.FocusedColumn.FieldName = "checked" Then
            If CStr(e.Value) = "False" Then
                GridView2.SetRowCellValue(GridView2.FocusedRowHandle, "QTY", 0)
            Else
                GridView2.SetRowCellValue(GridView2.FocusedRowHandle, "QTY", 1)
                GridView2.SetRowCellValue(GridView2.FocusedRowHandle, "price", GridView2.GetRowCellValue(GridView2.FocusedRowHandle, "defPrice"))
            End If
        End If
        If grdView.FocusedColumn.FieldName = "QTY" Then
            If CStr(e.Value) = "" Then Exit Sub
            Dim sTot As Decimal = e.Value * GridView2.GetRowCellValue(GridView2.FocusedRowHandle, "defPrice")
            GridView2.SetRowCellValue(GridView2.FocusedRowHandle, "price", sTot)
        End If
    End Sub

    Private Sub cmdConvertToOrder_Click(sender As Object, e As EventArgs) Handles cmdConvertToOrder.Click
        CusOfferOrderKitchen.ConvertToOrder()
    End Sub
    Private Sub ApplyDiscount(ByVal DiscMode As Integer, Optional ByVal DiscountChangedByUser As Boolean = False)
        Dim Disc As Double, Discount As Double, InitialPrice As Double, FinalPrice As Double
        If Me.IsActive = False Then Exit Sub
        Select Case DiscMode
            Case 1
                If DiscountChangedByUser = False Then txtDisc1.EditValue = ProgProps.CusDiscountKitchen
                If ProgProps.CusDiscountKitchen > 0 Then
                    InitialPrice = txtInitialPrice1.EditValue
                    If DiscountChangedByUser = False Then Disc = ProgProps.CusDiscountKitchen / 100 Else Disc = txtDisc1.EditValue / 100
                    Discount = Disc * InitialPrice
                    FinalPrice = InitialPrice - Discount
                    txtInitialPrice1.EditValue = InitialPrice
                    txtDiscount1.EditValue = Discount
                    txtFinalPrice1.EditValue = FinalPrice
                End If
            Case 2
                If DiscountChangedByUser = False Then txtDisc2.EditValue = ProgProps.CusDiscountKitchen
                If ProgProps.CusDiscountKitchen > 0 Then
                    InitialPrice = txtInitialPrice2.EditValue
                    If DiscountChangedByUser = False Then Disc = ProgProps.CusDiscountKitchen / 100 Else Disc = txtDisc2.EditValue / 100
                    Discount = Disc * InitialPrice
                    FinalPrice = InitialPrice - Discount
                    txtInitialPrice2.EditValue = InitialPrice
                    txtDiscount2.EditValue = Discount
                    txtFinalPrice2.EditValue = FinalPrice
                End If
            Case 3
                If DiscountChangedByUser = False Then txtDisc3.EditValue = ProgProps.CusDiscountKitchen
                If ProgProps.CusDiscountKitchen > 0 Then
                    InitialPrice = txtInitialPrice3.EditValue
                    If DiscountChangedByUser = False Then Disc = ProgProps.CusDiscountKitchen / 100 Else Disc = txtDisc3.EditValue / 100
                    Discount = Disc * InitialPrice
                    FinalPrice = InitialPrice - Discount
                    txtInitialPrice3.EditValue = InitialPrice
                    txtDiscount3.EditValue = Discount
                    txtFinalPrice3.EditValue = FinalPrice
                End If
            Case 4
                If DiscountChangedByUser = False Then txtDisc4.EditValue = ProgProps.CusDiscountKitchen
                If ProgProps.CusDiscountKitchen > 0 Then
                    InitialPrice = txtInitialPrice4.EditValue
                    If DiscountChangedByUser = False Then Disc = ProgProps.CusDiscountKitchen / 100 Else Disc = txtDisc4.EditValue / 100
                    Discount = Disc * InitialPrice
                    FinalPrice = InitialPrice - Discount
                    txtInitialPrice4.EditValue = InitialPrice
                    txtDiscount4.EditValue = Discount
                    txtFinalPrice4.EditValue = FinalPrice
                End If
        End Select
    End Sub

    Private Sub txtInitialPrice1_EditValueChanged(sender As Object, e As EventArgs) Handles txtInitialPrice1.EditValueChanged
        ApplyDiscount(1)
    End Sub

    Private Sub txtInitialPrice2_EditValueChanged(sender As Object, e As EventArgs) Handles txtInitialPrice2.EditValueChanged
        ApplyDiscount(2)
    End Sub

    Private Sub txtInitialPrice3_EditValueChanged(sender As Object, e As EventArgs) Handles txtInitialPrice3.EditValueChanged
        ApplyDiscount(3)
    End Sub

    Private Sub txtInitialPrice4_EditValueChanged(sender As Object, e As EventArgs) Handles txtInitialPrice4.EditValueChanged
        ApplyDiscount(4)
    End Sub
    Private Sub txtDisc1_EditValueChanged(sender As Object, e As EventArgs) Handles txtDisc1.EditValueChanged
        ApplyDiscount(1, True)
    End Sub
    Private Sub txtDisc2_EditValueChanged(sender As Object, e As EventArgs) Handles txtDisc2.EditValueChanged
        ApplyDiscount(2, True)
    End Sub

    Private Sub txtDisc3_EditValueChanged(sender As Object, e As EventArgs) Handles txtDisc3.EditValueChanged
        ApplyDiscount(3, True)
    End Sub

    Private Sub txtDisc4_EditValueChanged(sender As Object, e As EventArgs) Handles txtDisc4.EditValueChanged
        ApplyDiscount(4, True)
    End Sub
    Private Sub cboVVALUELISTITEM_ProcessNewValue(sender As Object, e As ProcessNewValueEventArgs) Handles cboVVALUELISTITEM.ProcessNewValue
        If CStr(e.DisplayValue) <> String.Empty Then
            Dim sVALUELISTITEMID = DBQ.InsertNewValueListItem(cboVVALUELISTITEM, e.DisplayValue)
            If sVALUELISTITEMID <> "" Then
                Me.Vw_VALUELISTITEM_V2TableAdapter.Fill(Me.DM_VALUELISTITEM.vw_VALUELISTITEM_V2)
                cboVVALUELISTITEM.EditValue = System.Guid.Parse(sVALUELISTITEMID)
            End If
            e.Handled = True
        End If
    End Sub
    Private Sub cboVVALUELISTITEM1_ProcessNewValue(sender As Object, e As ProcessNewValueEventArgs) Handles cboVVALUELISTITEM1.ProcessNewValue
        If CStr(e.DisplayValue) <> String.Empty Then
            Dim sVALUELISTITEMID = DBQ.InsertNewValueListItem(cboVVALUELISTITEM1, e.DisplayValue)
            If sVALUELISTITEMID <> "" Then
                Me.Vw_VALUELISTITEM_V2TableAdapter.Fill(Me.DM_VALUELISTITEM.vw_VALUELISTITEM_V2)
                cboVVALUELISTITEM1.EditValue = System.Guid.Parse(sVALUELISTITEMID)
            End If
            e.Handled = True
        End If
    End Sub
    Private Sub cboVependisisVALUELISTITEM_ProcessNewValue(sender As Object, e As ProcessNewValueEventArgs) Handles cboVependisisVALUELISTITEM.ProcessNewValue
        If CStr(e.DisplayValue) <> String.Empty Then
            Dim sVALUELISTITEMID = DBQ.InsertNewValueListItem(cboVependisisVALUELISTITEM, e.DisplayValue)
            If sVALUELISTITEMID <> "" Then
                Me.Vw_VALUELISTITEM_V2TableAdapter.Fill(Me.DM_VALUELISTITEM.vw_VALUELISTITEM_V2)
                cboVependisisVALUELISTITEM.EditValue = System.Guid.Parse(sVALUELISTITEMID)
            End If
            e.Handled = True
        End If
    End Sub
    Private Sub cboNependisisVALUELISTITEM_ProcessNewValue(sender As Object, e As ProcessNewValueEventArgs) Handles cboNependisisVALUELISTITEM.ProcessNewValue
        If CStr(e.DisplayValue) <> String.Empty Then
            Dim sVALUELISTITEMID = DBQ.InsertNewValueListItem(cboNependisisVALUELISTITEM, e.DisplayValue)
            If sVALUELISTITEMID <> "" Then
                Me.Vw_VALUELISTITEM_V2TableAdapter.Fill(Me.DM_VALUELISTITEM.vw_VALUELISTITEM_V2)
                cboNependisisVALUELISTITEM.EditValue = System.Guid.Parse(sVALUELISTITEMID)
            End If
            e.Handled = True
        End If
    End Sub
    Private Sub cboKVALUELISTITEM_ProcessNewValue(sender As Object, e As ProcessNewValueEventArgs) Handles cboKVALUELISTITEM.ProcessNewValue
        If CStr(e.DisplayValue) <> String.Empty Then
            Dim sVALUELISTITEMID = DBQ.InsertNewValueListItem(cboKVALUELISTITEM, e.DisplayValue)
            If sVALUELISTITEMID <> "" Then
                Me.Vw_VALUELISTITEM_V2TableAdapter.Fill(Me.DM_VALUELISTITEM.vw_VALUELISTITEM_V2)
                cboKVALUELISTITEM.EditValue = System.Guid.Parse(sVALUELISTITEMID)
            End If
            e.Handled = True
        End If
    End Sub
    Private Sub cboKVALUELISTITEM1_ProcessNewValue(sender As Object, e As ProcessNewValueEventArgs) Handles cboKVALUELISTITEM1.ProcessNewValue
        If CStr(e.DisplayValue) <> String.Empty Then
            Dim sVALUELISTITEMID = DBQ.InsertNewValueListItem(cboKVALUELISTITEM1, e.DisplayValue)
            If sVALUELISTITEMID <> "" Then
                Me.Vw_VALUELISTITEM_V2TableAdapter.Fill(Me.DM_VALUELISTITEM.vw_VALUELISTITEM_V2)
                cboKVALUELISTITEM1.EditValue = System.Guid.Parse(sVALUELISTITEMID)
            End If
            e.Handled = True
        End If
    End Sub
    Private Sub cboKependisisVALUELISTITEM_ProcessNewValue(sender As Object, e As ProcessNewValueEventArgs) Handles cboKependisisVALUELISTITEM.ProcessNewValue
        If CStr(e.DisplayValue) <> String.Empty Then
            Dim sVALUELISTITEMID = DBQ.InsertNewValueListItem(cboKependisisVALUELISTITEM, e.DisplayValue)
            If sVALUELISTITEMID <> "" Then
                Me.Vw_VALUELISTITEM_V2TableAdapter.Fill(Me.DM_VALUELISTITEM.vw_VALUELISTITEM_V2)
                cboKependisisVALUELISTITEM.EditValue = System.Guid.Parse(sVALUELISTITEMID)
            End If
            e.Handled = True
        End If
    End Sub
    Private Sub cboSndEpendisisVALUELISTITEM_ProcessNewValue(sender As Object, e As ProcessNewValueEventArgs) Handles cboSndEpendisisVALUELISTITEM.ProcessNewValue
        If CStr(e.DisplayValue) <> String.Empty Then
            Dim sVALUELISTITEMID = DBQ.InsertNewValueListItem(cboSndEpendisisVALUELISTITEM, e.DisplayValue)
            If sVALUELISTITEMID <> "" Then
                Me.Vw_VALUELISTITEM_V2TableAdapter.Fill(Me.DM_VALUELISTITEM.vw_VALUELISTITEM_V2)
                cboSndEpendisisVALUELISTITEM.EditValue = System.Guid.Parse(sVALUELISTITEMID)
            End If
            e.Handled = True
        End If
    End Sub
    Private Sub cboYVALUELISTITEM_ProcessNewValue(sender As Object, e As ProcessNewValueEventArgs) Handles cboYVALUELISTITEM.ProcessNewValue
        If CStr(e.DisplayValue) <> String.Empty Then
            Dim sVALUELISTITEMID = DBQ.InsertNewValueListItem(cboYVALUELISTITEM, e.DisplayValue)
            If sVALUELISTITEMID <> "" Then
                Me.Vw_VALUELISTITEM_V2TableAdapter.Fill(Me.DM_VALUELISTITEM.vw_VALUELISTITEM_V2)
                cboYVALUELISTITEM.EditValue = System.Guid.Parse(sVALUELISTITEMID)
            End If
            e.Handled = True
        End If
    End Sub
    Private Sub cboYVALUELISTITEM1_ProcessNewValue(sender As Object, e As ProcessNewValueEventArgs) Handles cboYVALUELISTITEM1.ProcessNewValue
        If CStr(e.DisplayValue) <> String.Empty Then
            Dim sVALUELISTITEMID = DBQ.InsertNewValueListItem(cboYVALUELISTITEM1, e.DisplayValue)
            If sVALUELISTITEMID <> "" Then
                Me.Vw_VALUELISTITEM_V2TableAdapter.Fill(Me.DM_VALUELISTITEM.vw_VALUELISTITEM_V2)
                cboYVALUELISTITEM1.EditValue = System.Guid.Parse(sVALUELISTITEMID)
            End If
            e.Handled = True
        End If
    End Sub

    Private Sub cboVRafieraVALUELISTITEM_ProcessNewValue(sender As Object, e As ProcessNewValueEventArgs) Handles cboVRafieraVALUELISTITEM.ProcessNewValue
        If CStr(e.DisplayValue) <> String.Empty Then
            Dim sVALUELISTITEMID = DBQ.InsertNewValueListItem(cboVRafieraVALUELISTITEM, e.DisplayValue)
            If sVALUELISTITEMID <> "" Then
                Me.Vw_VALUELISTITEM_V2TableAdapter.Fill(Me.DM_VALUELISTITEM.vw_VALUELISTITEM_V2)
                cboVRafieraVALUELISTITEM.EditValue = System.Guid.Parse(sVALUELISTITEMID)
            End If
            e.Handled = True
        End If
    End Sub
    Private Sub cboKRafieraVALUELISTITEM_ProcessNewValue(sender As Object, e As ProcessNewValueEventArgs) Handles cboKRafieraVALUELISTITEM.ProcessNewValue
        If CStr(e.DisplayValue) <> String.Empty Then
            Dim sVALUELISTITEMID = DBQ.InsertNewValueListItem(cboKRafieraVALUELISTITEM, e.DisplayValue)
            If sVALUELISTITEMID <> "" Then
                Me.Vw_VALUELISTITEM_V2TableAdapter.Fill(Me.DM_VALUELISTITEM.vw_VALUELISTITEM_V2)
                cboKRafieraVALUELISTITEM.EditValue = System.Guid.Parse(sVALUELISTITEMID)
            End If
            e.Handled = True
        End If
    End Sub

    Private Sub cboYRafieraVALUELISTITEM_ProcessNewValue(sender As Object, e As ProcessNewValueEventArgs) Handles cboYRafieraVALUELISTITEM.ProcessNewValue
        If CStr(e.DisplayValue) <> String.Empty Then
            Dim sVALUELISTITEMID = DBQ.InsertNewValueListItem(cboYRafieraVALUELISTITEM, e.DisplayValue)
            If sVALUELISTITEMID <> "" Then
                Me.Vw_VALUELISTITEM_V2TableAdapter.Fill(Me.DM_VALUELISTITEM.vw_VALUELISTITEM_V2)
                cboYRafieraVALUELISTITEM.EditValue = System.Guid.Parse(sVALUELISTITEMID)
            End If
            e.Handled = True
        End If
    End Sub
    Private Sub cboKWallRafiaVALUELISTITEM_ProcessNewValue(sender As Object, e As ProcessNewValueEventArgs) Handles cboKWallRafiaVALUELISTITEM.ProcessNewValue
        If CStr(e.DisplayValue) <> String.Empty Then
            Dim sVALUELISTITEMID = DBQ.InsertNewValueListItem(cboKWallRafiaVALUELISTITEM, e.DisplayValue)
            If sVALUELISTITEMID <> "" Then
                Me.Vw_VALUELISTITEM_V2TableAdapter.Fill(Me.DM_VALUELISTITEM.vw_VALUELISTITEM_V2)
                cboKWallRafiaVALUELISTITEM.EditValue = System.Guid.Parse(sVALUELISTITEMID)
            End If
            e.Handled = True
        End If
    End Sub

    Private Sub cboVBOXColors_ProcessNewValue(sender As Object, e As ProcessNewValueEventArgs) Handles cboVBOXColors.ProcessNewValue
        If CStr(e.DisplayValue) <> String.Empty Then
            Dim sVALUELISTITEMID = DBQ.InsertNewValueListItem(cboVBOXColors, e.DisplayValue)
            If sVALUELISTITEMID <> "" Then
                Me.Vw_VALUELISTITEM_V2TableAdapter.Fill(Me.DM_VALUELISTITEM.vw_VALUELISTITEM_V2)
                cboVBOXColors.EditValue = System.Guid.Parse(sVALUELISTITEMID)
            End If
            e.Handled = True
        End If
    End Sub

    Private Sub cboKBOXColors_ProcessNewValue(sender As Object, e As ProcessNewValueEventArgs) Handles cboKBOXColors.ProcessNewValue
        If CStr(e.DisplayValue) <> String.Empty Then
            Dim sVALUELISTITEMID = DBQ.InsertNewValueListItem(cboKBOXColors, e.DisplayValue)
            If sVALUELISTITEMID <> "" Then
                Me.Vw_VALUELISTITEM_V2TableAdapter.Fill(Me.DM_VALUELISTITEM.vw_VALUELISTITEM_V2)
                cboKBOXColors.EditValue = System.Guid.Parse(sVALUELISTITEMID)
            End If
            e.Handled = True
        End If
    End Sub

    Private Sub cboYBOXColors_ProcessNewValue(sender As Object, e As ProcessNewValueEventArgs) Handles cboYBOXColors.ProcessNewValue
        If CStr(e.DisplayValue) <> String.Empty Then
            Dim sVALUELISTITEMID = DBQ.InsertNewValueListItem(cboYBOXColors, e.DisplayValue)
            If sVALUELISTITEMID <> "" Then
                Me.Vw_VALUELISTITEM_V2TableAdapter.Fill(Me.DM_VALUELISTITEM.vw_VALUELISTITEM_V2)
                cboYBOXColors.EditValue = System.Guid.Parse(sVALUELISTITEMID)
            End If
            e.Handled = True
        End If
    End Sub

    Private Sub cboGOLAColors_ProcessNewValue(sender As Object, e As ProcessNewValueEventArgs) Handles cboGOLAColors.ProcessNewValue
        If CStr(e.DisplayValue) <> String.Empty Then
            Dim sVALUELISTITEMID = DBQ.InsertNewValueListItem(cboGOLAColors, e.DisplayValue)
            If sVALUELISTITEMID <> "" Then
                Me.Vw_VALUELISTITEM_V2TableAdapter.Fill(Me.DM_VALUELISTITEM.vw_VALUELISTITEM_V2)
                cboGOLAColors.EditValue = System.Guid.Parse(sVALUELISTITEMID)
            End If
            e.Handled = True
        End If
    End Sub
    Private Sub txtCUSOfferOrderFilename_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles txtCUSOfferOrderFilename.ButtonClick
        Try
            Select Case e.Button.Index
                Case 0 : FilesSelection(XtraOpenFileDialog1, txtCUSOfferOrderFilename, False) : txtbenchSalesPrice.ReadOnly = False
                Case 1 : OpenFile("CCT_ORDERS_KITCHEN_F", sID)
                Case 2
                    If txtCUSOfferOrderFilename.EditValue = Nothing Then Exit Sub
                    If XtraMessageBox.Show("Θέλετε να διαγραφεί το αρχείο?", ProgProps.ProgTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                        DBQ.DeleteDataFiles("CCT_ORDERS_KITCHEN_F", sID)
                        txtCUSOfferOrderFilename.EditValue = Nothing : txtbenchSalesPrice.EditValue = 0 : txtbenchSalesPrice.ReadOnly = True
                    End If
            End Select
        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub cboSup_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboSup.ButtonClick
        Select Case e.Button.Index
            Case 1 : ManageCbo.ManageSup(cboSup, FormMode.NewRecord)
            Case 2 : ManageCbo.ManageSup(cboSup, FormMode.EditRecord)
            Case 3 : cboSup.EditValue = Nothing
        End Select
    End Sub

    Private Sub cboBaseCat_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboBaseCat.ButtonClick
        Select Case e.Button.Index
            Case 1 : ManageCbo.ManageBaseCat(cboBaseCat, FormMode.NewRecord)
            Case 2 : ManageCbo.ManageBaseCat(cboBaseCat, FormMode.EditRecord)
            Case 3 : cboBaseCat.EditValue = Nothing
        End Select
    End Sub

    Private Sub cboModel1_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboModel1.ButtonClick
        Select Case e.Button.Index
            Case 1 : ManageCbo.ManageValueListItemChecked(cboModel1, FormMode.NewRecord, "3C68F058-6A47-4995-8B0C-26538F38580A")
            Case 2 : ManageCbo.ManageValueListItemChecked(cboModel1, FormMode.EditRecord)
            Case 3 : cboModel1.SetEditValue(-1)
        End Select
    End Sub

    Private Sub cboModel2_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboModel2.ButtonClick
        Select Case e.Button.Index
            Case 1 : ManageCbo.ManageValueListItemChecked(cboModel2, FormMode.NewRecord, "3C68F058-6A47-4995-8B0C-26538F38580A")
            Case 2 : ManageCbo.ManageValueListItemChecked(cboModel2, FormMode.EditRecord)
            Case 3 : cboModel2.SetEditValue(-1)
        End Select
    End Sub

    Private Sub cboModel3_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboModel3.ButtonClick
        Select Case e.Button.Index
            Case 1 : ManageCbo.ManageValueListItemChecked(cboModel3, FormMode.NewRecord, "3C68F058-6A47-4995-8B0C-26538F38580A")
            Case 2 : ManageCbo.ManageValueListItemChecked(cboModel3, FormMode.EditRecord)
            Case 3 : cboModel3.SetEditValue(-1)
        End Select
    End Sub

    Private Sub cboModel4_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboModel4.ButtonClick
        Select Case e.Button.Index
            Case 1 : ManageCbo.ManageValueListItemChecked(cboModel4, FormMode.NewRecord, "3C68F058-6A47-4995-8B0C-26538F38580A")
            Case 2 : ManageCbo.ManageValueListItemChecked(cboModel4, FormMode.EditRecord)
            Case 3 : cboModel4.SetEditValue(-1)
        End Select
    End Sub

    Private Sub cmdSavePhotos_Click(sender As Object, e As EventArgs) Handles cmdSavePhotos.Click
        CusOfferOrderKitchen.SavePhotoRecord(sID, FormMode.NewRecord)
    End Sub


    Private Sub CardView1_ValidateRow(sender As Object, e As ValidateRowEventArgs) Handles CardView1.ValidateRow
        CusOfferOrderKitchen.SavePhotoRecord(sID, FormMode.EditRecord)
    End Sub

    Private Sub CardView1_KeyDown(sender As Object, e As KeyEventArgs) Handles CardView1.KeyDown
        If e.KeyCode = Keys.Delete And UserProps.AllowDelete = True Then DeleteRecord()
    End Sub
    Private Sub DeleteRecord()
        CusOfferOrderKitchen.DeletePhotoRecord
    End Sub

    Private Sub cboSUP1_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboSUP1.ButtonClick
        Select Case e.Button.Index
            Case 1 : ManageCbo.ManageSup(cboSUP1, FormMode.NewRecord)
            Case 2 : ManageCbo.ManageSup(cboSUP1, FormMode.EditRecord)
            Case 3 : cboSUP1.EditValue = Nothing
            Case 4
                If IsDBNull(cboSUP1.GetColumnValue("site")) Then Exit Sub
                Dim webAddress As String = cboSUP1.GetColumnValue("site")
                If webAddress = Nothing Then XtraMessageBox.Show("Δεν έχει οριστεί Site στον Προμηθευτή", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error) Else Process.Start(webAddress)
        End Select

    End Sub

    Private Sub cboPhotoValueListItem_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboPhotoValueListItem.ButtonClick
        Select Case e.Button.Index
            Case 1 : ManageCbo.ManageValueListItem(cboPhotoValueListItem, FormMode.NewRecord, "DE86FD16-2154-4E2A-B025-4D34BDF8C808")
            Case 2 : ManageCbo.ManageValueListItem(cboPhotoValueListItem, FormMode.EditRecord)
            Case 3 : cboPhotoValueListItem.EditValue = Nothing
        End Select
    End Sub

    Private Sub cboColorsCat_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboColorsCat.ButtonClick
        Select Case e.Button.Index
        '    Case 1 : ManageCbo.ManageColors(cboPhotoValueListItem, FormMode.NewRecord, "DE86FD16-2154-4E2A-B025-4D34BDF8C808")
        '    Case 2 : ManageCbo.ManageColors(cboPhotoValueListItem, FormMode.EditRecord)
            Case 3 : cboColorsCat.EditValue = Nothing
        End Select
    End Sub

    Private Sub cmdPrintPhotos_Click(sender As Object, e As EventArgs) Handles cmdPrintPhotos.Click
        CardView1.ShowPrintPreview()
    End Sub

    Private Sub GridView3_PopupMenuShowing(sender As Object, e As PopupMenuShowingEventArgs) Handles GridView3.PopupMenuShowing
        If e.MenuType = GridMenuType.Column Then LoadForms.PopupMenuShow(e, GridView3, "vw_TRANSH_F_KITCHEN_def.xml", "vw_TRANSH_F")
    End Sub

    Private Sub cboCompany_EditValueChanged(sender As Object, e As EventArgs) Handles cboCompany.EditValueChanged
        Dim sCompID As String
        If cboCompany.EditValue Is Nothing Then sCompID = toSQLValueS(Guid.Empty.ToString) Else sCompID = toSQLValueS(cboCompany.EditValue.ToString)
        Dim sSQL As New System.Text.StringBuilder
        sSQL.AppendLine("Select T.id,FullTranshDescription,Description,Iskitchen,Iscloset,Isdoor,Issc
                        from vw_TRANSH t
                        where  T.cusid = " & sCompID & " order by description")
        FillCbo.TRANSH(cboCompProject, sSQL)
        LCompProject.ImageOptions.Image = Global.DreamyKitchenCRM.My.Resources.Resources.rsz_11rsz_asterisk
        If chkGenOffer.CheckState = CheckState.Checked Then
            cboCUS.EditValue = cboCompany.EditValue
            cboTRANSH.EditValue = cboCompProject.EditValue
        End If
        cmdCompCollection.Enabled = True
    End Sub

    Private Sub cboCompProject_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboCompProject.ButtonClick
        Select Case e.Button.Index
            Case 1
                If cboEMP.Text = "" Then XtraMessageBox.Show("Δεν έχετε επιλέξει πωλητή", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error) : Exit Sub
                ManageCbo.ManageTRANSHSmall(cboCompProject, FormMode.NewRecord, cboCompany.EditValue, True, cboEMP.EditValue, cboCompany.EditValue, cboCompProject.EditValue, 1)
            Case 2 : If cboCompProject.EditValue IsNot Nothing Then ManageCbo.ManageTRANSHSmall(cboCompProject, FormMode.EditRecord, cboCompany.EditValue, True)
            Case 3 : cboCompProject.EditValue = Nothing
        End Select
    End Sub

    Private Sub cboCompany_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboCompany.ButtonClick
        Select Case e.Button.Index
            Case 1 : ManageCbo.ManageCCT(FormMode.NewRecord, False,, cboCompany)
            Case 2 : ManageCbo.ManageCCT(FormMode.EditRecord, False,, cboCompany)
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

    End Sub

    Private Sub FillCusTransh()
        Dim sCusID As String, scompTrashID As String
        If cboCUS.EditValue Is Nothing Then sCusID = toSQLValueS(Guid.Empty.ToString) Else sCusID = toSQLValueS(cboCUS.EditValue.ToString)
        If chkGenOffer.CheckState = CheckState.Unchecked Then
            If cboCompProject.EditValue Is Nothing Then scompTrashID = " and T.compTrashID  IS NULL" Else scompTrashID = " and T.compTrashID   = " & toSQLValueS(cboCompProject.EditValue.ToString)
        End If
        Dim sSQL As New System.Text.StringBuilder
        sSQL.AppendLine("Select T.id,FullTranshDescription,Description,Iskitchen,Iscloset,Isdoor,Issc,AgreementExist,AgreementID
                        from vw_TRANSH t
                        INNER JOIN TRANSC on transc.transhID = t.id and TRANSC.transhcID = '60344B92-1925-42E9-8D0F-0525990B0D5F' 
                        where   completed = 0  and T.cusid = " & sCusID & scompTrashID & " order by description")
        FillCbo.TRANSH(cboTRANSH, sSQL)
        If chkGenOffer.CheckState = CheckState.Checked Then
            cboCUS.EditValue = cboCompany.EditValue
            cboTRANSH.EditValue = cboCompProject.EditValue
        End If
    End Sub

    Private Sub cboCompProject_EditValueChanged(sender As Object, e As EventArgs) Handles cboCompProject.EditValueChanged
        FillCusTransh()
    End Sub

    Private Sub chkGenOffer_CheckedChanged(sender As Object, e As EventArgs) Handles chkGenOffer.CheckedChanged
        If chkGenOffer.CheckState = CheckState.Checked Then
            FillCusTransh()
            cboCUS.Enabled = False : cboTRANSH.Enabled = False
            cboCUS.EditValue = cboCompany.EditValue
            cboTRANSH.EditValue = cboCompProject.EditValue
        Else
            cboCUS.Enabled = True : cboTRANSH.Enabled = True
        End If
    End Sub

    Private Sub cmdNewRecord_Click(sender As Object, e As EventArgs) Handles cmdNewRecord.Click
        CusOfferOrderKitchen.NewRecord()
    End Sub

    Private Sub cmdPrivateAgreement_Click(sender As Object, e As EventArgs) Handles cmdPrivateAgreement.Click
        Dim frmPrivateAgreement As frmCUSPrivateAgreement = New frmCUSPrivateAgreement()
        With frmPrivateAgreement
            .cboCompany.EditValue = cboCompany.EditValue
            .FillCompanyProjects()
            .cboCompProject.EditValue = cboCompProject.EditValue
            .cboCUS.EditValue = cboCUS.EditValue
            .FillCusTransh()
            .cboTRANSH.EditValue = cboTRANSH.EditValue
            .cboEMP.EditValue = cboEMP.EditValue
            .txtFatherName.EditValue = cboCUS.GetColumnValue("FatherName")
            .txtArea.EditValue = cboCUS.GetColumnValue("AREAS_Name")
            .txtDOY.EditValue = cboCUS.GetColumnValue("DOY_Name")
            .txtAFM.EditValue = cboCUS.GetColumnValue("afm")
            .cboADR.EditValue = cboCUS.GetColumnValue("AdrID")

            .Text = "Ιδ. Συμφωνητικό"
            If cboTRANSH.GetColumnValue("AgreementExist") = "1" Then
                .ID = cboTRANSH.GetColumnValue("AgreementID").ToString
                .Mode = FormMode.EditRecord
            Else
                .Mode = FormMode.NewRecord
                '   .InitializeForm()
            End If

            .ShowDialog()
        End With

    End Sub


    Private Sub chkGenOffer_CheckStateChanged(sender As Object, e As EventArgs) Handles chkGenOffer.CheckStateChanged
        If chkGenOffer.CheckState = CheckState.Checked Then cmdCusCollection.Enabled = False Else cmdCusCollection.Enabled = True
    End Sub
End Class