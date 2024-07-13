Imports System.Data.SqlClient
Imports DevExpress.XtraBars.Navigation
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid

Public Class frmCUSOfferOrderKitchen
    Private ScanFile As ScanToPDF
    Private CusOfferOrderKitchen As New CusOfferOrderKitchen
    Private ManageCbo As New CombosManager
    Private sID As String
    Private sOrderID As String
    Private sBaseCat As Integer
    Private sIsOrder As Boolean
    Private Ctrl As DevExpress.XtraGrid.Views.Grid.GridView
    Private Frm As DevExpress.XtraEditors.XtraForm
    Public Mode As Byte
    Private FScrollerExist As Boolean = False
    Private DBQ As New DBQueries
    Private LoadForms As New FormLoader
    Private CtrlCombo As DevExpress.XtraEditors.LookUpEdit
    Private CalledFromCtrl As Boolean
    Private receiveAgreement As Boolean = False
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
    Public ReadOnly Property orderCreated As Boolean
        Get
            Return sIsOrder
        End Get
    End Property
    Public WriteOnly Property orderID As String
        Set(value As String)
            sOrderID = value
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
    Private Sub frmCUSOrderKitchen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CusOfferOrderKitchen.Initialize(Me, sID, Mode, CalledFromCtrl, CtrlCombo, sIsOrder, sBaseCat)
        CusOfferOrderKitchen.LoadForm()
        If receiveAgreement = True Then cmdSave.Enabled = False : cmdSaveEquipDev.Enabled = False : cmdSavePhotos.Enabled = False : cmdSaveTransF.Enabled = False
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
        txtTotalErmariaPrice.EditValue = TotalErmariaPrice
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
                ManageCbo.ManageTRANSHSmall(cboTRANSH, FormMode.NewRecord, cboCUS.EditValue,, cboEMP.EditValue, cboCompany.EditValue, cboCompProject.EditValue, 0, sIsOrder, System.Guid.Parse("60344B92-1925-42E9-8D0F-0525990B0D5F"))
            Case 2 : ManageCbo.ManageTRANSHSmall(cboTRANSH, FormMode.EditRecord, cboCUS.EditValue,,,,,, sIsOrder)
            Case 3 : cboTRANSH.EditValue = Nothing : cmdCusCollection.Enabled = False
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
    Private Sub cboVBOXColors_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboVBOXColors.ButtonClick
        Select Case e.Button.Index
            Case 1 : ManageCbo.ManageValueListItem(cboVBOXColors, FormMode.NewRecord, "DE86FD16-2154-4E2A-B025-4D34BDF8C808", "MATERIALS")
            Case 2 : ManageCbo.ManageValueListItem(cboVBOXColors, FormMode.EditRecord)
            Case 3 : cboVBOXColors.EditValue = Nothing
        End Select
    End Sub

    Private Sub cboKBOXColors_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboKBOXColors.ButtonClick
        Select Case e.Button.Index
            Case 1 : ManageCbo.ManageValueListItem(cboKBOXColors, FormMode.NewRecord, "DE86FD16-2154-4E2A-B025-4D34BDF8C808", "MATERIALS")
            Case 2 : ManageCbo.ManageValueListItem(cboKBOXColors, FormMode.EditRecord)
            Case 3 : cboKBOXColors.EditValue = Nothing
        End Select
    End Sub


    Private Sub cboYBOXColors_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboYBOXColors.ButtonClick
        Select Case e.Button.Index
            Case 1 : ManageCbo.ManageValueListItem(cboYBOXColors, FormMode.NewRecord, "DE86FD16-2154-4E2A-B025-4D34BDF8C808", "MATERIALS")
            Case 2 : ManageCbo.ManageValueListItem(cboYBOXColors, FormMode.EditRecord)
            Case 3 : cboYBOXColors.EditValue = Nothing
        End Select
    End Sub

    Private Sub cboGOLAColors_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboGOLAColors.ButtonClick
        Select Case e.Button.Index
            Case 1 : ManageCbo.ManageValueListItem(cboGOLAColors, FormMode.NewRecord, "DE86FD16-2154-4E2A-B025-4D34BDF8C808", "MATERIALS")
            Case 2 : ManageCbo.ManageValueListItem(cboGOLAColors, FormMode.EditRecord)
            Case 3 : cboGOLAColors.EditValue = Nothing
        End Select
    End Sub

    Private Sub cboVVALUELISTITEM_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboVVALUELISTITEM.ButtonClick
        Select Case e.Button.Index
            Case 1 : ManageCbo.ManageValueListItem(cboVVALUELISTITEM, FormMode.NewRecord, "DE86FD16-2154-4E2A-B025-4D34BDF8C808", "MATERIALS")
            Case 2 : ManageCbo.ManageValueListItem(cboVVALUELISTITEM, FormMode.EditRecord)
            Case 3 : cboVVALUELISTITEM.EditValue = Nothing
        End Select
    End Sub
    Private Sub cboKVALUELISTITEM_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboKVALUELISTITEM.ButtonClick
        Select Case e.Button.Index
            Case 1 : ManageCbo.ManageValueListItem(cboKVALUELISTITEM, FormMode.NewRecord, "DE86FD16-2154-4E2A-B025-4D34BDF8C808", "MATERIALS")
            Case 2 : ManageCbo.ManageValueListItem(cboKVALUELISTITEM, FormMode.EditRecord)
            Case 3 : cboKVALUELISTITEM.EditValue = Nothing
        End Select
    End Sub
    Private Sub cboYVALUELISTITEM_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboYVALUELISTITEM.ButtonClick
        Select Case e.Button.Index
            Case 1 : ManageCbo.ManageValueListItem(cboYVALUELISTITEM, FormMode.NewRecord, "DE86FD16-2154-4E2A-B025-4D34BDF8C808", "MATERIALS")
            Case 2 : ManageCbo.ManageValueListItem(cboYVALUELISTITEM, FormMode.EditRecord)
            Case 3 : cboYVALUELISTITEM.EditValue = Nothing
        End Select
    End Sub
    Private Sub cboVVALUELISTITEM1_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboVVALUELISTITEM1.ButtonClick
        Select Case e.Button.Index
            Case 1 : ManageCbo.ManageValueListItem(cboVVALUELISTITEM1, FormMode.NewRecord, "DE86FD16-2154-4E2A-B025-4D34BDF8C808", "MATERIALS")
            Case 2 : ManageCbo.ManageValueListItem(cboVVALUELISTITEM1, FormMode.EditRecord)
            Case 3 : cboVVALUELISTITEM1.EditValue = Nothing
        End Select
    End Sub
    Private Sub cboKVALUELISTITEM1_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboKVALUELISTITEM1.ButtonClick
        Select Case e.Button.Index
            Case 1 : ManageCbo.ManageValueListItem(cboKVALUELISTITEM1, FormMode.NewRecord, "DE86FD16-2154-4E2A-B025-4D34BDF8C808", "MATERIALS")
            Case 2 : ManageCbo.ManageValueListItem(cboKVALUELISTITEM1, FormMode.EditRecord)
            Case 3 : cboKVALUELISTITEM1.EditValue = Nothing
        End Select
    End Sub
    Private Sub cboYVALUELISTITEM1_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboYVALUELISTITEM1.ButtonClick
        Select Case e.Button.Index
            Case 1 : ManageCbo.ManageValueListItem(cboYVALUELISTITEM1, FormMode.NewRecord, "DE86FD16-2154-4E2A-B025-4D34BDF8C808", "MATERIALS")
            Case 2 : ManageCbo.ManageValueListItem(cboYVALUELISTITEM1, FormMode.EditRecord)
            Case 3 : cboYVALUELISTITEM1.EditValue = Nothing
        End Select
    End Sub
    Private Sub cboVependisisVALUELISTITEM_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboVependisisVALUELISTITEM.ButtonClick
        Select Case e.Button.Index
            Case 1 : ManageCbo.ManageValueListItem(cboVependisisVALUELISTITEM, FormMode.NewRecord, "DE86FD16-2154-4E2A-B025-4D34BDF8C808", "MATERIALS")
            Case 2 : ManageCbo.ManageValueListItem(cboVependisisVALUELISTITEM, FormMode.EditRecord)
            Case 3 : cboVependisisVALUELISTITEM.EditValue = Nothing
        End Select
    End Sub
    Private Sub cboKependisisVALUELISTITEM_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboKependisisVALUELISTITEM.ButtonClick
        Select Case e.Button.Index
            Case 1 : ManageCbo.ManageValueListItem(cboKependisisVALUELISTITEM, FormMode.NewRecord, "DE86FD16-2154-4E2A-B025-4D34BDF8C808", "MATERIALS")
            Case 2 : ManageCbo.ManageValueListItem(cboKependisisVALUELISTITEM, FormMode.EditRecord)
            Case 3 : cboKependisisVALUELISTITEM.EditValue = Nothing
        End Select
    End Sub
    Private Sub cboSndEpendisisVALUELISTITEM_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboSndEpendisisVALUELISTITEM.ButtonClick
        Select Case e.Button.Index
            Case 1 : ManageCbo.ManageValueListItem(cboSndEpendisisVALUELISTITEM, FormMode.NewRecord, "DE86FD16-2154-4E2A-B025-4D34BDF8C808", "MATERIALS")
            Case 2 : ManageCbo.ManageValueListItem(cboSndEpendisisVALUELISTITEM, FormMode.EditRecord)
            Case 3 : cboSndEpendisisVALUELISTITEM.EditValue = Nothing
        End Select
    End Sub
    Private Sub cboNependisisVALUELISTITEM_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboNependisisVALUELISTITEM.ButtonClick
        Select Case e.Button.Index
            Case 1 : ManageCbo.ManageValueListItem(cboNependisisVALUELISTITEM, FormMode.NewRecord, "DE86FD16-2154-4E2A-B025-4D34BDF8C808", "MATERIALS")
            Case 2 : ManageCbo.ManageValueListItem(cboNependisisVALUELISTITEM, FormMode.EditRecord)
            Case 3 : cboNependisisVALUELISTITEM.EditValue = Nothing
        End Select
    End Sub
    Private Sub cboVRafieraVALUELISTITEM_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboVRafieraVALUELISTITEM.ButtonClick
        Select Case e.Button.Index
            Case 1 : ManageCbo.ManageValueListItem(cboVRafieraVALUELISTITEM, FormMode.NewRecord, "DE86FD16-2154-4E2A-B025-4D34BDF8C808", "MATERIALS")
            Case 2 : ManageCbo.ManageValueListItem(cboVRafieraVALUELISTITEM, FormMode.EditRecord)
            Case 3 : cboVRafieraVALUELISTITEM.EditValue = Nothing
        End Select
    End Sub
    Private Sub cboYRafieraVALUELISTITEM_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboYRafieraVALUELISTITEM.ButtonClick
        Select Case e.Button.Index
            Case 1 : ManageCbo.ManageValueListItem(cboYRafieraVALUELISTITEM, FormMode.NewRecord, "DE86FD16-2154-4E2A-B025-4D34BDF8C808", "MATERIALS")
            Case 2 : ManageCbo.ManageValueListItem(cboYRafieraVALUELISTITEM, FormMode.EditRecord)
            Case 3 : cboYRafieraVALUELISTITEM.EditValue = Nothing
        End Select
    End Sub
    Private Sub cboKRafieraVALUELISTITEM_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboKRafieraVALUELISTITEM.ButtonClick
        Select Case e.Button.Index
            Case 1 : ManageCbo.ManageValueListItem(cboKRafieraVALUELISTITEM, FormMode.NewRecord, "DE86FD16-2154-4E2A-B025-4D34BDF8C808", "MATERIALS")
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
            Case 1 : ManageCbo.ManageValueListItem(cboKWallRafiaVALUELISTITEM, FormMode.NewRecord, "DE86FD16-2154-4E2A-B025-4D34BDF8C808", "MATERIALS")
            Case 2 : ManageCbo.ManageValueListItem(cboKWallRafiaVALUELISTITEM, FormMode.EditRecord)
            Case 3 : cboKWallRafiaVALUELISTITEM.EditValue = Nothing
        End Select
    End Sub
    Private Sub cboPependisisVALUELISTITEM_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboPependisisVALUELISTITEM.ButtonClick
        Select Case e.Button.Index
            Case 1 : ManageCbo.ManageValueListItem(cboPependisisVALUELISTITEM, FormMode.NewRecord, "DE86FD16-2154-4E2A-B025-4D34BDF8C808", "MATERIALS")
            Case 2 : ManageCbo.ManageValueListItem(cboPependisisVALUELISTITEM, FormMode.EditRecord)
            Case 3 : cboPependisisVALUELISTITEM.EditValue = Nothing
        End Select
    End Sub
    Private Sub cboPependisisVALUELISTITEM2_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboPependisisVALUELISTITEM2.ButtonClick

        Select Case e.Button.Index
            Case 1 : ManageCbo.ManageValueListItem(cboPependisisVALUELISTITEM2, FormMode.NewRecord, "DE86FD16-2154-4E2A-B025-4D34BDF8C808", "MATERIALS")
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
                CusOfferOrderKitchen.LoadEquipments()
                If sIsOrder = True Then CusOfferOrderKitchen.LoadDevices()
                LoadForms.RestoreLayoutFromXml(GridView1, "CCT_ORDERS_KITCHEN_DEVICES_def.xml")
                LoadForms.RestoreLayoutFromXml(GridView2, "CCT_ORDERS_KITCHEN_EQUIPMENT_def")
                GridView2.Columns.Item("name").OptionsColumn.AllowEdit = False : GridView2.Columns.Item("code").OptionsColumn.AllowEdit = False
                GridView1.Columns.Item("name").OptionsColumn.AllowEdit = False : GridView1.Columns.Item("code").OptionsColumn.AllowEdit = False
                GridView2.Columns.Item("price").OptionsColumn.AllowEdit = True
                GridView2.Columns.Item("standard").OptionsColumn.AllowEdit = False
                GridView1.OptionsMenu.ShowConditionalFormattingItem = True
            Case 2 : If sID IsNot Nothing Then Vw_CCT_ORDERS_PHOTOSTableAdapter.FillByOrderType(DM_CCT.vw_CCT_ORDERS_PHOTOS, 0, System.Guid.Parse(sID))
            Case 3
                LoadForms.RestoreLayoutFromXml(GridView3, "vw_TRANSH_F_KITCHEN_def.xml")
                TRANSH_FTableAdapter.FillByTranshID(DM_TRANS.TRANSH_F, System.Guid.Parse(cboTRANSH.EditValue.ToString))
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
        Dim Disc As Double, Discount As Double, InitialPrice As Double, FinalPrice As Double, VatPrice As Double
        If Me.IsActive = False Then Exit Sub
        Select Case DiscMode
            Case 1
                If DiscountChangedByUser = False Then txtDisc1.EditValue = ProgProps.CusDiscountKitchen
                If ProgProps.CusDiscountKitchen > 0 Then
                    InitialPrice = txtInitialPrice1.EditValue.ToString.Replace(".", ",")
                    If DiscountChangedByUser = False Then Disc = ProgProps.CusDiscountKitchen / 100 Else Disc = txtDisc1.EditValue / 100
                    Discount = Disc * InitialPrice
                    FinalPrice = InitialPrice - Discount
                    FinalPrice = FinalPrice + (FinalPrice * (ProgProps.VAT / 100))
                    VatPrice = InitialPrice - Discount
                    txtInitialPrice1.EditValue = InitialPrice
                    txtDiscount1.EditValue = Discount
                    txtFinalPrice1.EditValue = FinalPrice
                    txtVatPrice1.EditValue = VatPrice
                End If
            Case 2
                If DiscountChangedByUser = False Then txtDisc2.EditValue = ProgProps.CusDiscountKitchen
                If ProgProps.CusDiscountKitchen > 0 Then
                    InitialPrice = txtInitialPrice2.EditValue.ToString.Replace(".", ",")
                    If DiscountChangedByUser = False Then Disc = ProgProps.CusDiscountKitchen / 100 Else Disc = txtDisc2.EditValue / 100
                    Discount = Disc * InitialPrice
                    FinalPrice = InitialPrice - Discount
                    FinalPrice = FinalPrice + (FinalPrice * (ProgProps.VAT / 100))
                    VatPrice = InitialPrice - Discount
                    txtInitialPrice2.EditValue = InitialPrice
                    txtDiscount2.EditValue = Discount
                    txtFinalPrice2.EditValue = FinalPrice
                    txtVatPrice2.EditValue = VatPrice
                End If
            Case 3
                If DiscountChangedByUser = False Then txtDisc3.EditValue = ProgProps.CusDiscountKitchen
                If ProgProps.CusDiscountKitchen > 0 Then
                    InitialPrice = txtInitialPrice3.EditValue.ToString.Replace(".", ",")
                    If DiscountChangedByUser = False Then Disc = ProgProps.CusDiscountKitchen / 100 Else Disc = txtDisc3.EditValue / 100
                    Discount = Disc * InitialPrice
                    FinalPrice = InitialPrice - Discount
                    FinalPrice = FinalPrice + (FinalPrice * (ProgProps.VAT / 100))
                    VatPrice = InitialPrice - Discount
                    txtInitialPrice3.EditValue = InitialPrice
                    txtDiscount3.EditValue = Discount
                    txtFinalPrice3.EditValue = FinalPrice
                    txtVatPrice3.EditValue = VatPrice
                End If
            Case 4
                If DiscountChangedByUser = False Then txtDisc4.EditValue = ProgProps.CusDiscountKitchen
                If ProgProps.CusDiscountKitchen > 0 Then
                    InitialPrice = txtInitialPrice4.EditValue.ToString.Replace(".", ",")
                    If DiscountChangedByUser = False Then Disc = ProgProps.CusDiscountKitchen / 100 Else Disc = txtDisc4.EditValue / 100
                    Discount = Disc * InitialPrice
                    FinalPrice = InitialPrice - Discount
                    FinalPrice = FinalPrice + (FinalPrice * (ProgProps.VAT / 100))
                    VatPrice = InitialPrice - Discount
                    txtInitialPrice4.EditValue = InitialPrice
                    txtDiscount4.EditValue = Discount
                    txtFinalPrice4.EditValue = FinalPrice
                    txtVatPrice4.EditValue = VatPrice
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
                Case 1 : OpenFile("TRANSH_F", cboTRANSH.EditValue.ToString, sID)
                Case 2
                    If txtCUSOfferOrderFilename.EditValue = Nothing Then Exit Sub
                    If XtraMessageBox.Show("Θέλετε να διαγραφεί το αρχείο?", ProgProps.ProgTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                        DBQ.DeleteDataFiles("TRANSH_F", cboTRANSH.EditValue.ToString, sID, "EEA48A0A-4171-46FE-BBC5-D02F2712B04C")
                        txtCUSOfferOrderFilename.EditValue = Nothing : txtbenchSalesPrice.EditValue = 0 : txtbenchSalesPrice.ReadOnly = True : cboSup.EditValue = Nothing
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
        DeleteRecord()
    End Sub
    Private Sub DeleteRecord()
        CusOfferOrderKitchen.DeletePhotoRecord()
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
            Case 1 : ManageCbo.ManageValueListItem(cboPhotoValueListItem, FormMode.NewRecord, "DE86FD16-2154-4E2A-B025-4D34BDF8C808", "MATERIALS")
            Case 2 : ManageCbo.ManageValueListItem(cboPhotoValueListItem, FormMode.EditRecord)
            Case 3 : cboPhotoValueListItem.EditValue = Nothing
        End Select
    End Sub

    Private Sub cboColorsCat_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboColorsCat.ButtonClick
        Select Case e.Button.Index
        '    Case 1 : ManageCbo.ManageColors(cboPhotoValueListItem, FormMode.NewRecord, "DE86FD16-2154-4E2A-B025-4D34BDF8C808", "MATERIALS")
        '    Case 2 : ManageCbo.ManageColors(cboPhotoValueListItem, FormMode.EditRecord)
            Case 3 : cboColorsCat.EditValue = Nothing
        End Select
    End Sub

    Private Sub cmdPrintPhotos_Click(sender As Object, e As EventArgs) Handles cmdPrintPhotos.Click
        CardView1.Columns(2).Visible = False
        CardView1.ShowPrintPreview()
    End Sub

    Private Sub GridView3_PopupMenuShowing(sender As Object, e As PopupMenuShowingEventArgs) Handles GridView3.PopupMenuShowing
        If e.MenuType = GridMenuType.Column Then LoadForms.PopupMenuShow(e, GridView3, "vw_TRANSH_F_KITCHEN_def.xml", "vw_TRANSH_F")
    End Sub

    Private Sub cmdCollection_Click(sender As Object, e As EventArgs) Handles cmdCompCollection.Click
        If cboCompProject.EditValue Is Nothing Then XtraMessageBox.Show("Δεν έχετε επιλέξει έργο", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error) : Exit Sub
        If sID = "" Then XtraMessageBox.Show("Δεν έχετε αποθηκεύσει την προσφορά", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error) : Exit Sub
        Dim Frm As frmTransactions = New frmTransactions()
        Frm.Text = "Είσπραξη Πελάτη"
        Frm.CreditOnly = True
        Frm.TypeOfProject = 1 'Κουζίνα
        Frm.isOrder = sIsOrder
        Frm.OfferID = sID
        Frm.Mode = FormMode.EditRecord
        Frm.ID = cboCompProject.EditValue.ToString
        Frm.isCompany = True
        Frm.ShowDialog()
        If Frm.orderCreated Then
            cmdSave.Enabled = False : cmdSaveEquipDev.Enabled = False : cmdOrder.Enabled = True
            LblMsg.Text = "Δεν μπορείτε να κάνετε αλλαγές στην προσφορά γιατί έχει δημιουργηθεί παραγγελία."
        End If
    End Sub

    Private Sub cmdCusCollection_Click(sender As Object, e As EventArgs) Handles cmdCusCollection.Click
        If cboTRANSH.EditValue Is Nothing Then XtraMessageBox.Show("Δεν έχετε επιλέξει έργο", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error) : Exit Sub
        If sID = "" Then XtraMessageBox.Show("Δεν έχετε αποθηκεύσει την προσφορά", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error) : Exit Sub
        Dim Frm As frmTransactions = New frmTransactions()
        Frm.Text = "Είσπραξη Πελάτη"
        Frm.CreditOnly = True
        Frm.TypeOfProject = 1 'Κουζίνα
        Frm.isOrder = sIsOrder
        Frm.OfferID = sID
        Frm.Mode = FormMode.EditRecord
        Frm.ID = cboTRANSH.EditValue.ToString
        Frm.lCusD.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        Frm.ShowDialog()
        If Frm.orderCreated Then
            cmdSave.Enabled = False : cmdSaveEquipDev.Enabled = False : cmdOrder.Enabled = True
            LblMsg.Text = "Δεν μπορείτε να κάνετε αλλαγές στην προσφορά γιατί έχει δημιουργηθεί παραγγελία."
        End If
    End Sub
    Private Sub chkGenOffer_CheckedChanged(sender As Object, e As EventArgs) Handles chkGenOffer.CheckedChanged
        If chkGenOffer.CheckState = CheckState.Checked Then
            cboCUS.Enabled = False : cboTRANSH.Enabled = False
            cboCUS.EditValue = cboCompany.EditValue
            cboCUS.Text = cboCompany.Text
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
        Dim AgreementID As String
        Dim sTranshID As Guid
        With frmPrivateAgreement
            .Company = cboCompany.EditValue
            .CompProject = cboCompProject.EditValue
            .CUS = cboCUS.EditValue
            sTranshID = System.Guid.Parse(cboTRANSH.EditValue.ToString)
            .TRANSH = sTranshID
            .EMP = cboEMP.EditValue
            .Text = "Ιδ. Συμφωνητικό"
            If AgreementExist(AgreementID) Then .Mode = FormMode.EditRecord Else .Mode = FormMode.NewRecord
            .ID = AgreementID
            .ShowDialog()
        End With

    End Sub
    ' Έλεγχος αν υτπάρχει συφωνητικό για την Κουζίνα
    Private Function AgreementExist(ByRef AgreementID As String) As Boolean
        Dim cmd As SqlCommand
        Dim sdr As SqlDataReader
        Try
            cmd = New SqlCommand("  select  id from Agreement where Kitchen = 1 and transhID =  " & toSQLValueS(cboTRANSH.EditValue.ToString), CNDB)
            sdr = cmd.ExecuteReader()
            If (sdr.Read() = True) Then
                AgreementID = sdr.GetGuid(sdr.GetOrdinal("id")).ToString()
                sdr.Close() : Return True
            Else
                sdr.Close() : Return False
            End If
        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
            sdr.Close()
        End Try
    End Function
    Private Sub chkModel1_CheckStateChanged(sender As Object, e As EventArgs) Handles chkModel1.CheckStateChanged
        If chkModel1.CheckState = CheckState.Checked Then
            chkModel2.CheckState = CheckState.Unchecked
            chkModel3.CheckState = CheckState.Unchecked
            chkModel4.CheckState = CheckState.Unchecked
            LModel1.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 8.142858!, System.Drawing.FontStyle.Bold) : LModel1.AppearanceItemCaption.Options.UseFont = True
            LDisc1.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 8.142858!, System.Drawing.FontStyle.Bold) : LDisc1.AppearanceItemCaption.Options.UseFont = True
            LDiscount1.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 8.142858!, System.Drawing.FontStyle.Bold) : LDiscount1.AppearanceItemCaption.Options.UseFont = True
            LInitialPrice1.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 8.142858!, System.Drawing.FontStyle.Bold) : LInitialPrice1.AppearanceItemCaption.Options.UseFont = True
            LFinalPrice1.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 8.142858!, System.Drawing.FontStyle.Bold) : LFinalPrice1.AppearanceItemCaption.Options.UseFont = True
            txtTotAmt.EditValue = txtFinalPrice1.EditValue
        Else
            LModel1.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 8.142858!, System.Drawing.FontStyle.Regular) : LModel1.AppearanceItemCaption.Options.UseFont = False
            LDisc1.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 8.142858!, System.Drawing.FontStyle.Regular) : LDisc1.AppearanceItemCaption.Options.UseFont = False
            LDiscount1.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 8.142858!, System.Drawing.FontStyle.Regular) : LDiscount1.AppearanceItemCaption.Options.UseFont = False
            LInitialPrice1.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 8.142858!, System.Drawing.FontStyle.Regular) : LInitialPrice1.AppearanceItemCaption.Options.UseFont = False
            LFinalPrice1.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 8.142858!, System.Drawing.FontStyle.Regular) : LFinalPrice1.AppearanceItemCaption.Options.UseFont = False
        End If
    End Sub

    Private Sub chkModel2_CheckStateChanged(sender As Object, e As EventArgs) Handles chkModel2.CheckStateChanged
        If chkModel2.CheckState = CheckState.Checked Then
            chkModel1.CheckState = CheckState.Unchecked
            chkModel3.CheckState = CheckState.Unchecked
            chkModel4.CheckState = CheckState.Unchecked
            LModel2.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 8.142858!, System.Drawing.FontStyle.Bold) : LModel2.AppearanceItemCaption.Options.UseFont = True
            LDisc2.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 8.142858!, System.Drawing.FontStyle.Bold) : LDisc2.AppearanceItemCaption.Options.UseFont = True
            LDiscount2.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 8.142858!, System.Drawing.FontStyle.Bold) : LDiscount2.AppearanceItemCaption.Options.UseFont = True
            LInitialPrice2.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 8.142858!, System.Drawing.FontStyle.Bold) : LInitialPrice2.AppearanceItemCaption.Options.UseFont = True
            LFinalPrice2.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 8.142858!, System.Drawing.FontStyle.Bold) : LFinalPrice2.AppearanceItemCaption.Options.UseFont = True
            txtTotAmt.EditValue = txtFinalPrice2.EditValue
        Else
            LModel2.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 8.142858!, System.Drawing.FontStyle.Regular) : LModel2.AppearanceItemCaption.Options.UseFont = False
            LDisc2.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 8.142858!, System.Drawing.FontStyle.Regular) : LDisc2.AppearanceItemCaption.Options.UseFont = False
            LDiscount2.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 8.142858!, System.Drawing.FontStyle.Regular) : LDiscount2.AppearanceItemCaption.Options.UseFont = False
            LInitialPrice2.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 8.142858!, System.Drawing.FontStyle.Regular) : LInitialPrice2.AppearanceItemCaption.Options.UseFont = False
            LFinalPrice2.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 8.142858!, System.Drawing.FontStyle.Regular) : LFinalPrice2.AppearanceItemCaption.Options.UseFont = False
        End If
    End Sub

    Private Sub chkModel3_CheckStateChanged(sender As Object, e As EventArgs) Handles chkModel3.CheckStateChanged
        If chkModel3.CheckState = CheckState.Checked Then
            chkModel1.CheckState = CheckState.Unchecked
            chkModel2.CheckState = CheckState.Unchecked
            chkModel4.CheckState = CheckState.Unchecked
            LModel3.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 8.142858!, System.Drawing.FontStyle.Bold) : LModel3.AppearanceItemCaption.Options.UseFont = True
            LDisc3.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 8.142858!, System.Drawing.FontStyle.Bold) : LDisc3.AppearanceItemCaption.Options.UseFont = True
            LDiscount3.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 8.142858!, System.Drawing.FontStyle.Bold) : LDiscount3.AppearanceItemCaption.Options.UseFont = True
            LInitialPrice3.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 8.142858!, System.Drawing.FontStyle.Bold) : LInitialPrice3.AppearanceItemCaption.Options.UseFont = True
            LFinalPrice3.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 8.142858!, System.Drawing.FontStyle.Bold) : LFinalPrice3.AppearanceItemCaption.Options.UseFont = True
            txtTotAmt.EditValue = txtFinalPrice3.EditValue
        Else
            LModel3.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 8.142858!, System.Drawing.FontStyle.Regular) : LModel3.AppearanceItemCaption.Options.UseFont = False
            LDisc3.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 8.142858!, System.Drawing.FontStyle.Regular) : LDisc3.AppearanceItemCaption.Options.UseFont = False
            LDiscount3.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 8.142858!, System.Drawing.FontStyle.Regular) : LDiscount3.AppearanceItemCaption.Options.UseFont = False
            LInitialPrice3.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 8.142858!, System.Drawing.FontStyle.Regular) : LInitialPrice3.AppearanceItemCaption.Options.UseFont = False
            LFinalPrice3.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 8.142858!, System.Drawing.FontStyle.Regular) : LFinalPrice3.AppearanceItemCaption.Options.UseFont = False
        End If
    End Sub

    Private Sub chkModel4_CheckStateChanged(sender As Object, e As EventArgs) Handles chkModel4.CheckStateChanged
        If chkModel4.CheckState = CheckState.Checked Then
            chkModel1.CheckState = CheckState.Unchecked
            chkModel2.CheckState = CheckState.Unchecked
            chkModel3.CheckState = CheckState.Unchecked
            LModel4.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 8.142858!, System.Drawing.FontStyle.Bold) : LModel4.AppearanceItemCaption.Options.UseFont = True
            LDisc4.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 8.142858!, System.Drawing.FontStyle.Bold) : LDisc4.AppearanceItemCaption.Options.UseFont = True
            LDiscount4.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 8.142858!, System.Drawing.FontStyle.Bold) : LDiscount4.AppearanceItemCaption.Options.UseFont = True
            LInitialPrice4.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 8.142858!, System.Drawing.FontStyle.Bold) : LInitialPrice4.AppearanceItemCaption.Options.UseFont = True
            LFinalPrice4.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 8.142858!, System.Drawing.FontStyle.Bold) : LFinalPrice4.AppearanceItemCaption.Options.UseFont = True
            txtTotAmt.EditValue = txtFinalPrice4.EditValue
        Else
            LModel4.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 8.142858!, System.Drawing.FontStyle.Regular) : LModel4.AppearanceItemCaption.Options.UseFont = False
            LDisc4.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 8.142858!, System.Drawing.FontStyle.Regular) : LDisc4.AppearanceItemCaption.Options.UseFont = False
            LDiscount4.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 8.142858!, System.Drawing.FontStyle.Regular) : LDiscount4.AppearanceItemCaption.Options.UseFont = False
            LInitialPrice4.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 8.142858!, System.Drawing.FontStyle.Regular) : LInitialPrice4.AppearanceItemCaption.Options.UseFont = False
            LFinalPrice4.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 8.142858!, System.Drawing.FontStyle.Regular) : LFinalPrice4.AppearanceItemCaption.Options.UseFont = False
        End If
    End Sub

    Private Sub cmdSaveTransF_Click(sender As Object, e As EventArgs) Handles cmdSaveTransF.Click
        XtraOpenFileDialog2.Tag = cboTanshFCategory.EditValue.ToString
        CusOfferOrderKitchen.SaveRecordF(0)
    End Sub
    Private Sub cboTanshFCategory_ButtonPressed(sender As Object, e As ButtonPressedEventArgs) Handles cboTanshFCategory.ButtonPressed
        Select Case e.Button.Index
            Case 1 : cboTanshFCategory.EditValue = Nothing : ManageCbo.ManageFCategory(cboTanshFCategory, FormMode.NewRecord)
            Case 2 : If cboTanshFCategory.EditValue IsNot Nothing Then ManageCbo.ManageFCategory(cboTanshFCategory, FormMode.EditRecord)
            Case 3 : cboTanshFCategory.EditValue = Nothing
        End Select

    End Sub
    Private Sub txtFiles_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles txtFiles.ButtonClick
        Dim sFilename As String
        Select Case e.Button.Index
            Case 0
                Dim result = XtraInputBox.Show("Πληκτρολογήστε το πλήθος σελίδων που θα σκανάρετε", "Όνομα Αρχείου", "1")
                ScanFile = New ScanToPDF
                If ScanFile.Scan(sFilename, Me.VwSCANFILENAMESBindingSource, result) = False Then Exit Sub
                txtFiles.EditValue = sFilename
                If txtFiles.Text <> "" Then CusOfferOrderKitchen.SaveRecordF(1, sFilename)
                ScanFile = Nothing
            Case 1 : FilesSelection(XtraOpenFileDialog2, txtFiles)

            Case 2 : txtFiles.EditValue = Nothing
        End Select
    End Sub

    Private Sub cboCUS_EditValueChanged(sender As Object, e As EventArgs) Handles cboCUS.EditValueChanged
        If Mode = FormMode.NewRecord Then CusOfferOrderKitchen.FillCusTransh(lkupEditValue(cboCUS), lkupEditValue(cboCompProject), chkGenOffer.CheckState, "")
    End Sub
    Private Sub cboCompany_EditValueChanged(sender As Object, e As EventArgs) Handles cboCompany.EditValueChanged
        If Mode = FormMode.NewRecord Then CusOfferOrderKitchen.FillCompanyProjects(lkupEditValue(cboCompany), chkGenOffer.CheckState, "")
    End Sub
    Private Sub CalculateTotAmt()
        If Me.IsActive = False Then Exit Sub
        Dim KitchenVat As Double
        Dim ExtraInst As Double = DbnullToZero(txtExtraInst)                        'Τοποθέτηση
        Dim ExtraTransp As Double = DbnullToZero(txtExtraTransp)                    'Μεταφορά
        Dim TotalErmariaPrice As Double = DbnullToZero(txtTotalErmariaPrice)        'Συνολική Αξία με ΦΠΑ
        Dim TotalDevicesPrice As Double = DbnullToZero(txtTotalDevicesPrice)        'Συνολική Αξία Συσκευών με ΦΠΑ
        Dim TotalBenchSalePrice As Double = DbnullToZero(txtbenchSalesPrice)        'Συνολική Αξία Πάγκου
        Dim TotalErmariaVat As Double = DbnullToZero(txtTotalErmariaVat)            'Συνολική Αξία προ ΦΠΑ
        Dim PartofVat As Double = DbnullToZero(txtPartofVat)                        'Συμφωνηθέν ΦΠΑ

        txtTotalbenchSalesPrice.EditValue = txtbenchSalesPrice.EditValue
        TotalErmariaPrice = TotalErmariaVat + ExtraInst + ExtraTransp
        KitchenVat = TotalErmariaPrice / ProgProps.AlternateVAT
        TotalErmariaPrice = TotalErmariaPrice * ProgProps.AlternateVAT
        Dim TotAmt As Double = TotalDevicesPrice + TotalBenchSalePrice + IIf(PartofVat > 0, TotalErmariaVat + PartofVat, TotalErmariaPrice)
        txtTotalErmariaPrice.EditValue = TotAmt - TotalDevicesPrice - TotalBenchSalePrice
        txtTotAmt.EditValue = TotAmt
    End Sub
    Private Sub txtExtraInst_EditValueChanged(sender As Object, e As EventArgs) Handles txtExtraInst.EditValueChanged
        CalculateTotAmt()
    End Sub

    Private Sub txtExtraTransp_EditValueChanged(sender As Object, e As EventArgs) Handles txtExtraTransp.EditValueChanged
        CalculateTotAmt()
    End Sub

    Private Sub txtTotalErmariaPrice_EditValueChanged(sender As Object, e As EventArgs) Handles txtTotalErmariaPrice.EditValueChanged
        CalculateTotAmt()
    End Sub

    Private Sub txtPartofVat_EditValueChanged(sender As Object, e As EventArgs) Handles txtPartofVat.EditValueChanged
        CalculateTotAmt()
    End Sub

    Private Sub txtFinalPrice1_EditValueChanged(sender As Object, e As EventArgs) Handles txtFinalPrice1.EditValueChanged
        If chkModel1.CheckState = CheckState.Checked Then txtTotAmt.EditValue = txtFinalPrice1.EditValue
    End Sub

    Private Sub txtFinalPrice2_EditValueChanged(sender As Object, e As EventArgs) Handles txtFinalPrice2.EditValueChanged
        If chkModel2.CheckState = CheckState.Checked Then txtTotAmt.EditValue = txtFinalPrice2.EditValue
    End Sub

    Private Sub txtFinalPrice3_EditValueChanged(sender As Object, e As EventArgs) Handles txtFinalPrice3.EditValueChanged
        If chkModel3.CheckState = CheckState.Checked Then txtTotAmt.EditValue = txtFinalPrice3.EditValue
    End Sub

    Private Sub txtFinalPrice4_EditValueChanged(sender As Object, e As EventArgs) Handles txtFinalPrice4.EditValueChanged
        If chkModel4.CheckState = CheckState.Checked Then txtTotAmt.EditValue = txtFinalPrice4.EditValue
    End Sub

    Private Sub cmdOrder_Click(sender As Object, e As EventArgs) Handles cmdOrder.Click
        Dim frmCUSOfferOrderKitchen As frmCUSOfferOrderKitchen = New frmCUSOfferOrderKitchen()
        frmCUSOfferOrderKitchen.ID = sOrderID
        frmCUSOfferOrderKitchen.Mode = FormMode.EditRecord
        frmCUSOfferOrderKitchen.IsOrder = True
        frmCUSOfferOrderKitchen.Text = "Έντυπο Παραγγελίας Πελατών(Κουζίνα)"
        frmCUSOfferOrderKitchen.ShowDialog()
    End Sub

    Private Sub txtTotalDevicesPrice_EditValueChanged(sender As Object, e As EventArgs) Handles txtTotalDevicesPrice.EditValueChanged
        CalculateTotAmt()
    End Sub


    Private Sub cboCompProject_EditValueChanged(sender As Object, e As EventArgs) Handles cboCompProject.EditValueChanged
        If Mode = FormMode.NewRecord Then CusOfferOrderKitchen.FillCusTransh(lkupEditValue(cboCUS), lkupEditValue(cboCompProject), chkGenOffer.CheckState, "")
        If DirectCast(e, DevExpress.XtraEditors.Controls.ChangingEventArgs).NewValue IsNot Nothing And chkGenOffer.CheckState = CheckState.Checked Then cmdCompCollection.Enabled = True Else cmdCompCollection.Enabled = False
    End Sub
    Private Sub chkGenOffer_CheckStateChanged(sender As Object, e As EventArgs) Handles chkGenOffer.CheckStateChanged
        If chkGenOffer.CheckState = CheckState.Checked Then cmdCompCollection.Enabled = True : cmdCusCollection.Enabled = False Else cmdCompCollection.Enabled = False : cmdCusCollection.Enabled = True
    End Sub
    Private Sub cboTRANSH_EditValueChanged(sender As Object, e As EventArgs) Handles cboTRANSH.EditValueChanged
        receiveAgreement = cboTRANSH.GetColumnValue("receiveAgreement")
        If DirectCast(e, DevExpress.XtraEditors.Controls.ChangingEventArgs).NewValue IsNot Nothing Then cmdCusCollection.Enabled = True Else cmdCusCollection.Enabled = False
    End Sub
    Private Sub cboCompProject_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboCompProject.ButtonClick
        Select Case e.Button.Index
            Case 1
                If cboEMP.Text = "" Then XtraMessageBox.Show("Δεν έχετε επιλέξει πωλητή", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error) : Exit Sub
                ManageCbo.ManageTRANSHSmall(cboCompProject, FormMode.NewRecord, cboCompany.EditValue, True, cboEMP.EditValue, cboCompany.EditValue, cboCompProject.EditValue, 1, sIsOrder, System.Guid.Parse("60344B92-1925-42E9-8D0F-0525990B0D5F"))
            Case 2 : If cboCompProject.EditValue IsNot Nothing Then ManageCbo.ManageTRANSHSmall(cboCompProject, FormMode.EditRecord, cboCompany.EditValue, True,,,,, sIsOrder)
            Case 3 : cboCompProject.EditValue = Nothing : cmdCompCollection.Enabled = False
        End Select
    End Sub

    Private Sub cboCompany_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboCompany.ButtonClick
        Select Case e.Button.Index
            Case 1 : ManageCbo.ManageCCT(FormMode.NewRecord, False,, cboCompany) ': Vw_CCTTableAdapter.Fill(DreamyKitchenDataSet.vw_CCT)
            Case 2 : ManageCbo.ManageCCT(FormMode.EditRecord, False,, cboCompany)
            Case 3 : cboCompany.EditValue = Nothing : LCompProject.ImageOptions.Image = Nothing : cmdCompCollection.Enabled = False
        End Select
    End Sub
    Private Sub cboCUS_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboCUS.ButtonClick
        Select Case e.Button.Index
            Case 1 : ManageCbo.ManageCCT(FormMode.NewRecord, False,, cboCUS)
            Case 2 : ManageCbo.ManageCCT(FormMode.EditRecord, False,, cboCUS)
            Case 3 : cboCUS.EditValue = Nothing : cmdCusCollection.Enabled = False
        End Select
    End Sub

    Private Sub txtbenchSalesPrice_EditValueChanged(sender As Object, e As EventArgs) Handles txtbenchSalesPrice.EditValueChanged
        CalculateTotAmt()
    End Sub

    Private Sub cboLegs1_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboLegs1.ButtonClick
        Select Case e.Button.Index
            Case 1 : cboLegs1.EditValue = Nothing
        End Select

    End Sub

    Private Sub cbobenchThickness_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cbobenchThickness.ButtonClick
        Select Case e.Button.Index
            Case 1 : cbobenchThickness.EditValue = Nothing
        End Select

    End Sub

    Private Sub cbobenchThickness1_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cbobenchThickness1.ButtonClick
        Select Case e.Button.Index
            Case 1 : cbobenchThickness1.EditValue = Nothing
        End Select

    End Sub

    Private Sub cbobenchThickness2_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cbobenchThickness2.ButtonClick
        Select Case e.Button.Index
            Case 1 : cbobenchThickness2.EditValue = Nothing
        End Select

    End Sub

    Private Sub cbobenchThickness3_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cbobenchThickness3.ButtonClick
        Select Case e.Button.Index
            Case 1 : cbobenchThickness3.EditValue = Nothing
        End Select

    End Sub

    Private Sub GridView3_ValidateRow(sender As Object, e As ValidateRowEventArgs) Handles GridView3.ValidateRow
        Dim sSQL As New System.Text.StringBuilder
        Try
            sSQL.Clear()
            sSQL.AppendLine("UPDATE TRANSH_F	SET FileCatID= " & toSQLValueS(GridView3.GetRowCellValue(GridView3.FocusedRowHandle, "fileCatID").ToString) & ",")
            sSQL.AppendLine("modifiedBY = " & toSQLValueS(UserProps.ID.ToString) & ",")
            sSQL.AppendLine("modifiedON = getdate() ")
            sSQL.AppendLine("WHERE ID = " & toSQLValueS(GridView3.GetRowCellValue(GridView3.FocusedRowHandle, "ID").ToString))
            'Εκτέλεση QUERY
            Using oCmd As New SqlCommand(sSQL.ToString, CNDB)
                oCmd.ExecuteNonQuery()
            End Using
        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class