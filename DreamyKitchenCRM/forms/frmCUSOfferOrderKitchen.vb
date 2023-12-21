Imports System.Data.SqlClient
Imports DevExpress.XtraBars.Navigation
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
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
        'TODO: This line of code loads data into the 'DreamyKitchenDataSet.vw_SUP' table. You can move, or remove it, as needed.
        Me.Vw_SUPTableAdapter.Fill(Me.DreamyKitchenDataSet.vw_SUP)
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
        Dim sCusID As String
        If cboCUS.EditValue Is Nothing Then sCusID = toSQLValueS(Guid.Empty.ToString) Else sCusID = toSQLValueS(cboCUS.EditValue.ToString)
        Dim sSQL As New System.Text.StringBuilder
        sSQL.AppendLine("Select T.id,FullTranshDescription,Description,Iskitchen,Iscloset,Isdoors,Issc
                        from vw_TRANSH t
                        where  T.cusid = " & sCusID & "order by description")
        FillCbo.TRANSH(cboTRANSH, sSQL)

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
            Case 1 : ManageCbo.ManageTRANSHSmall(cboTRANSH, FormMode.NewRecord, cboCUS.EditValue)
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
            Case 1 : ManageCbo.ManageDoorType(cboVBOXColors, FormMode.NewRecord, "DE86FD16-2154-4E2A-B025-4D34BDF8C808")
            Case 2 : ManageCbo.ManageDoorType(cboVBOXColors, FormMode.EditRecord)
            Case 3 : cboVBOXColors.EditValue = Nothing
        End Select
    End Sub

    Private Sub cboKBOXColors_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboKBOXColors.ButtonClick
        Select Case e.Button.Index
            Case 1 : ManageCbo.ManageDoorType(cboKBOXColors, FormMode.NewRecord, "DE86FD16-2154-4E2A-B025-4D34BDF8C808")
            Case 2 : ManageCbo.ManageDoorType(cboKBOXColors, FormMode.EditRecord)
            Case 3 : cboKBOXColors.EditValue = Nothing
        End Select
    End Sub


    Private Sub cboYBOXColors_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboYBOXColors.ButtonClick
        Select Case e.Button.Index
            Case 1 : ManageCbo.ManageDoorType(cboYBOXColors, FormMode.NewRecord, "DE86FD16-2154-4E2A-B025-4D34BDF8C808")
            Case 2 : ManageCbo.ManageDoorType(cboYBOXColors, FormMode.EditRecord)
            Case 3 : cboYBOXColors.EditValue = Nothing
        End Select
    End Sub

    Private Sub cboGOLAColors_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboGOLAColors.ButtonClick
        Select Case e.Button.Index
            Case 1 : ManageCbo.ManageDoorType(cboGOLAColors, FormMode.NewRecord, "DE86FD16-2154-4E2A-B025-4D34BDF8C808")
            Case 2 : ManageCbo.ManageDoorType(cboGOLAColors, FormMode.EditRecord)
            Case 3 : cboGOLAColors.EditValue = Nothing
        End Select
    End Sub

    Private Sub cboVDoorType_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboVDoorType.ButtonClick
        Select Case e.Button.Index
            Case 1 : ManageCbo.ManageDoorType(cboVDoorType, FormMode.NewRecord, "DE86FD16-2154-4E2A-B025-4D34BDF8C808")
            Case 2 : ManageCbo.ManageDoorType(cboVDoorType, FormMode.EditRecord)
            Case 3 : cboVDoorType.EditValue = Nothing
        End Select
    End Sub
    Private Sub cboKDoorType_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboKDoorType.ButtonClick
        Select Case e.Button.Index
            Case 1 : ManageCbo.ManageDoorType(cboKDoorType, FormMode.NewRecord, "DE86FD16-2154-4E2A-B025-4D34BDF8C808")
            Case 2 : ManageCbo.ManageDoorType(cboKDoorType, FormMode.EditRecord)
            Case 3 : cboKDoorType.EditValue = Nothing
        End Select
    End Sub
    Private Sub cboYDoorType_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboYDoorType.ButtonClick
        Select Case e.Button.Index
            Case 1 : ManageCbo.ManageDoorType(cboYDoorType, FormMode.NewRecord, "DE86FD16-2154-4E2A-B025-4D34BDF8C808")
            Case 2 : ManageCbo.ManageDoorType(cboYDoorType, FormMode.EditRecord)
            Case 3 : cboYDoorType.EditValue = Nothing
        End Select
    End Sub
    Private Sub cboVDoorType1_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboVDoorType1.ButtonClick
        Select Case e.Button.Index
            Case 1 : ManageCbo.ManageDoorType(cboVDoorType1, FormMode.NewRecord, "DE86FD16-2154-4E2A-B025-4D34BDF8C808")
            Case 2 : ManageCbo.ManageDoorType(cboVDoorType1, FormMode.EditRecord)
            Case 3 : cboVDoorType1.EditValue = Nothing
        End Select
    End Sub
    Private Sub cboKDoorType1_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboKDoorType1.ButtonClick
        Select Case e.Button.Index
            Case 1 : ManageCbo.ManageDoorType(cboKDoorType1, FormMode.NewRecord, "DE86FD16-2154-4E2A-B025-4D34BDF8C808")
            Case 2 : ManageCbo.ManageDoorType(cboKDoorType1, FormMode.EditRecord)
            Case 3 : cboKDoorType1.EditValue = Nothing
        End Select
    End Sub
    Private Sub cboYDoorType1_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboYDoorType1.ButtonClick
        Select Case e.Button.Index
            Case 1 : ManageCbo.ManageDoorType(cboYDoorType1, FormMode.NewRecord, "DE86FD16-2154-4E2A-B025-4D34BDF8C808")
            Case 2 : ManageCbo.ManageDoorType(cboYDoorType1, FormMode.EditRecord)
            Case 3 : cboYDoorType1.EditValue = Nothing
        End Select
    End Sub
    Private Sub cboVependisisDoorType_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboVependisisDoorType.ButtonClick
        Select Case e.Button.Index
            Case 1 : ManageCbo.ManageDoorType(cboVependisisDoorType, FormMode.NewRecord, "DE86FD16-2154-4E2A-B025-4D34BDF8C808")
            Case 2 : ManageCbo.ManageDoorType(cboVependisisDoorType, FormMode.EditRecord)
            Case 3 : cboVependisisDoorType.EditValue = Nothing
        End Select
    End Sub
    Private Sub cboKependisisDoorType_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboKependisisDoorType.ButtonClick
        Select Case e.Button.Index
            Case 1 : ManageCbo.ManageDoorType(cboKependisisDoorType, FormMode.NewRecord, "DE86FD16-2154-4E2A-B025-4D34BDF8C808")
            Case 2 : ManageCbo.ManageDoorType(cboKependisisDoorType, FormMode.EditRecord)
            Case 3 : cboKependisisDoorType.EditValue = Nothing
        End Select
    End Sub
    Private Sub cboSndEpendisisDoorType_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboSndEpendisisDoorType.ButtonClick
        Select Case e.Button.Index
            Case 1 : ManageCbo.ManageDoorType(cboSndEpendisisDoorType, FormMode.NewRecord, "DE86FD16-2154-4E2A-B025-4D34BDF8C808")
            Case 2 : ManageCbo.ManageDoorType(cboSndEpendisisDoorType, FormMode.EditRecord)
            Case 3 : cboSndEpendisisDoorType.EditValue = Nothing
        End Select
    End Sub
    Private Sub cboNependisisDoorType_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboNependisisDoorType.ButtonClick
        Select Case e.Button.Index
            Case 1 : ManageCbo.ManageDoorType(cboNependisisDoorType, FormMode.NewRecord, "DE86FD16-2154-4E2A-B025-4D34BDF8C808")
            Case 2 : ManageCbo.ManageDoorType(cboNependisisDoorType, FormMode.EditRecord)
            Case 3 : cboNependisisDoorType.EditValue = Nothing
        End Select
    End Sub
    Private Sub cboVRafieraDoorType_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboVRafieraDoorType.ButtonClick
        Select Case e.Button.Index
            Case 1 : ManageCbo.ManageDoorType(cboVRafieraDoorType, FormMode.NewRecord, "DE86FD16-2154-4E2A-B025-4D34BDF8C808")
            Case 2 : ManageCbo.ManageDoorType(cboVRafieraDoorType, FormMode.EditRecord)
            Case 3 : cboVRafieraDoorType.EditValue = Nothing
        End Select
    End Sub
    Private Sub cboYRafieraDoorType_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboYRafieraDoorType.ButtonClick
        Select Case e.Button.Index
            Case 1 : ManageCbo.ManageDoorType(cboYRafieraDoorType, FormMode.NewRecord, "DE86FD16-2154-4E2A-B025-4D34BDF8C808")
            Case 2 : ManageCbo.ManageDoorType(cboYRafieraDoorType, FormMode.EditRecord)
            Case 3 : cboYRafieraDoorType.EditValue = Nothing
        End Select
    End Sub
    Private Sub cboKRafieraDoorType_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboKRafieraDoorType.ButtonClick
        Select Case e.Button.Index
            Case 1 : ManageCbo.ManageDoorType(cboKRafieraDoorType, FormMode.NewRecord, "DE86FD16-2154-4E2A-B025-4D34BDF8C808")
            Case 2 : ManageCbo.ManageDoorType(cboKRafieraDoorType, FormMode.EditRecord)
            Case 3 : cboKRafieraDoorType.EditValue = Nothing
        End Select
    End Sub
    Private Sub cboBenchType_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboBenchType.ButtonClick
        Select Case e.Button.Index
            Case 1 : ManageCbo.ManageDoorType(cboBenchType, FormMode.NewRecord, "D08B9371-F94A-48F9-8021-C1661120ED8C")
            Case 2 : ManageCbo.ManageDoorType(cboBenchType, FormMode.EditRecord)
            Case 3 : cboBenchType.EditValue = Nothing
        End Select
    End Sub
    Private Sub cboBenchType1_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboBenchType1.ButtonClick
        Select Case e.Button.Index
            Case 1 : ManageCbo.ManageDoorType(cboBenchType1, FormMode.NewRecord, "D08B9371-F94A-48F9-8021-C1661120ED8C")
            Case 2 : ManageCbo.ManageDoorType(cboBenchType1, FormMode.EditRecord)
            Case 3 : cboBenchType1.EditValue = Nothing
        End Select
    End Sub
    Private Sub cboBenchType2_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboBenchType2.ButtonClick
        Select Case e.Button.Index
            Case 1 : ManageCbo.ManageDoorType(cboBenchType2, FormMode.NewRecord, "D08B9371-F94A-48F9-8021-C1661120ED8C")
            Case 2 : ManageCbo.ManageDoorType(cboBenchType2, FormMode.EditRecord)
            Case 3 : cboBenchType2.EditValue = Nothing
        End Select
    End Sub
    Private Sub cboBack_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboBack.ButtonClick
        Select Case e.Button.Index
            Case 1 : ManageCbo.ManageDoorType(cboBack, FormMode.NewRecord, "D08B9371-F94A-48F9-8021-C1661120ED8C")
            Case 2 : ManageCbo.ManageDoorType(cboBack, FormMode.EditRecord)
            Case 3 : cboBack.EditValue = Nothing
        End Select
    End Sub
    Private Sub cboKWallRafiaDoorType_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboKWallRafiaDoorType.ButtonClick
        Select Case e.Button.Index
            Case 1 : ManageCbo.ManageDoorType(cboKWallRafiaDoorType, FormMode.NewRecord, "DE86FD16-2154-4E2A-B025-4D34BDF8C808")
            Case 2 : ManageCbo.ManageDoorType(cboKWallRafiaDoorType, FormMode.EditRecord)
            Case 3 : cboKWallRafiaDoorType.EditValue = Nothing
        End Select
    End Sub
    Private Sub cboPependisisDoorType_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboPependisisDoorType.ButtonClick
        Select Case e.Button.Index
            Case 1 : ManageCbo.ManageDoorType(cboPependisisDoorType, FormMode.NewRecord, "DE86FD16-2154-4E2A-B025-4D34BDF8C808")
            Case 2 : ManageCbo.ManageDoorType(cboPependisisDoorType, FormMode.EditRecord)
            Case 3 : cboPependisisDoorType.EditValue = Nothing
        End Select
    End Sub
    Private Sub cboPependisisDoorType2_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboPependisisDoorType2.ButtonClick

        Select Case e.Button.Index
            Case 1 : ManageCbo.ManageDoorType(cboPependisisDoorType2, FormMode.NewRecord, "DE86FD16-2154-4E2A-B025-4D34BDF8C808")
            Case 2 : ManageCbo.ManageDoorType(cboPependisisDoorType2, FormMode.EditRecord)
            Case 3 : cboPependisisDoorType2.EditValue = Nothing
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
        End Select
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
    Private Sub txtInitialPrice1_EditValueChanged(sender As Object, e As EventArgs) Handles txtInitialPrice1.EditValueChanged
        Dim Disc As Double, Discount As Double, InitialPrice As Double, FinalPrice As Double
        txtDisc1.EditValue = ProgProps.CusDiscountKitchen
        If ProgProps.CusDiscountKitchen > 0 Then
            InitialPrice = txtInitialPrice1.EditValue
            Disc = ProgProps.CusDiscountKitchen / 100
            Discount = Disc * InitialPrice
            FinalPrice = InitialPrice - Discount
            txtInitialPrice1.EditValue = InitialPrice
            txtDiscount1.EditValue = Discount
            txtFinalPrice1.EditValue = FinalPrice
        End If
    End Sub

    Private Sub txtInitialPrice2_EditValueChanged(sender As Object, e As EventArgs) Handles txtInitialPrice2.EditValueChanged
        Dim Disc As Double, Discount As Double, InitialPrice As Double, FinalPrice As Double
        txtDisc2.EditValue = ProgProps.CusDiscountKitchen
        If ProgProps.CusDiscountKitchen > 0 Then
            InitialPrice = txtInitialPrice2.EditValue
            Disc = ProgProps.CusDiscountKitchen / 100
            Discount = Disc * InitialPrice
            FinalPrice = InitialPrice - Discount
            txtInitialPrice2.EditValue = InitialPrice
            txtDiscount2.EditValue = Discount
            txtFinalPrice2.EditValue = FinalPrice
        End If

    End Sub

    Private Sub txtInitialPrice3_EditValueChanged(sender As Object, e As EventArgs) Handles txtInitialPrice3.EditValueChanged
        Dim Disc As Double, Discount As Double, InitialPrice As Double, FinalPrice As Double
        txtDisc3.EditValue = ProgProps.CusDiscountKitchen
        If ProgProps.CusDiscountKitchen > 0 Then
            InitialPrice = txtInitialPrice3.EditValue
            Disc = ProgProps.CusDiscountKitchen / 100
            Discount = Disc * InitialPrice
            FinalPrice = InitialPrice - Discount
            txtInitialPrice3.EditValue = InitialPrice
            txtDiscount3.EditValue = Discount
            txtFinalPrice3.EditValue = FinalPrice
        End If
    End Sub

    Private Sub txtInitialPrice4_EditValueChanged(sender As Object, e As EventArgs) Handles txtInitialPrice4.EditValueChanged
        Dim Disc As Double, Discount As Double, InitialPrice As Double, FinalPrice As Double
        txtDisc4.EditValue = ProgProps.CusDiscountKitchen
        If ProgProps.CusDiscountKitchen > 0 Then
            InitialPrice = txtInitialPrice4.EditValue
            Disc = ProgProps.CusDiscountKitchen / 100
            Discount = Disc * InitialPrice
            FinalPrice = InitialPrice - Discount
            txtInitialPrice4.EditValue = InitialPrice
            txtDiscount4.EditValue = Discount
            txtFinalPrice4.EditValue = FinalPrice
        End If
    End Sub

    Private Sub cboVDoorType_ProcessNewValue(sender As Object, e As ProcessNewValueEventArgs) Handles cboVDoorType.ProcessNewValue
        If CStr(e.DisplayValue) <> String.Empty Then
            Dim sDoorTypeID = DBQ.InsertNewDoorType(cboVDoorType, e.DisplayValue)
            If sDoorTypeID <> "" Then
                Me.Vw_DOOR_TYPE_V2TableAdapter.Fill(Me.DM_DOORTYPES.vw_DOOR_TYPE_V2)
                cboVDoorType.EditValue = System.Guid.Parse(sDoorTypeID)
            End If
            e.Handled = True
        End If
    End Sub
    Private Sub cboVDoorType1_ProcessNewValue(sender As Object, e As ProcessNewValueEventArgs) Handles cboVDoorType1.ProcessNewValue
        If CStr(e.DisplayValue) <> String.Empty Then
            Dim sDoorTypeID = DBQ.InsertNewDoorType(cboVDoorType1, e.DisplayValue)
            If sDoorTypeID <> "" Then
                Me.Vw_DOOR_TYPE_V2TableAdapter.Fill(Me.DM_DOORTYPES.vw_DOOR_TYPE_V2)
                cboVDoorType1.EditValue = System.Guid.Parse(sDoorTypeID)
            End If
            e.Handled = True
        End If
    End Sub
    Private Sub cboVependisisDoorType_ProcessNewValue(sender As Object, e As ProcessNewValueEventArgs) Handles cboVependisisDoorType.ProcessNewValue
        If CStr(e.DisplayValue) <> String.Empty Then
            Dim sDoorTypeID = DBQ.InsertNewDoorType(cboVependisisDoorType, e.DisplayValue)
            If sDoorTypeID <> "" Then
                Me.Vw_DOOR_TYPE_V2TableAdapter.Fill(Me.DM_DOORTYPES.vw_DOOR_TYPE_V2)
                cboVependisisDoorType.EditValue = System.Guid.Parse(sDoorTypeID)
            End If
            e.Handled = True
        End If
    End Sub
    Private Sub cboNependisisDoorType_ProcessNewValue(sender As Object, e As ProcessNewValueEventArgs) Handles cboNependisisDoorType.ProcessNewValue
        If CStr(e.DisplayValue) <> String.Empty Then
            Dim sDoorTypeID = DBQ.InsertNewDoorType(cboNependisisDoorType, e.DisplayValue)
            If sDoorTypeID <> "" Then
                Me.Vw_DOOR_TYPE_V2TableAdapter.Fill(Me.DM_DOORTYPES.vw_DOOR_TYPE_V2)
                cboNependisisDoorType.EditValue = System.Guid.Parse(sDoorTypeID)
            End If
            e.Handled = True
        End If
    End Sub
    Private Sub cboKDoorType_ProcessNewValue(sender As Object, e As ProcessNewValueEventArgs) Handles cboKDoorType.ProcessNewValue
        If CStr(e.DisplayValue) <> String.Empty Then
            Dim sDoorTypeID = DBQ.InsertNewDoorType(cboKDoorType, e.DisplayValue)
            If sDoorTypeID <> "" Then
                Me.Vw_DOOR_TYPE_V2TableAdapter.Fill(Me.DM_DOORTYPES.vw_DOOR_TYPE_V2)
                cboKDoorType.EditValue = System.Guid.Parse(sDoorTypeID)
            End If
            e.Handled = True
        End If
    End Sub
    Private Sub cboKDoorType1_ProcessNewValue(sender As Object, e As ProcessNewValueEventArgs) Handles cboKDoorType1.ProcessNewValue
        If CStr(e.DisplayValue) <> String.Empty Then
            Dim sDoorTypeID = DBQ.InsertNewDoorType(cboKDoorType1, e.DisplayValue)
            If sDoorTypeID <> "" Then
                Me.Vw_DOOR_TYPE_V2TableAdapter.Fill(Me.DM_DOORTYPES.vw_DOOR_TYPE_V2)
                cboKDoorType1.EditValue = System.Guid.Parse(sDoorTypeID)
            End If
            e.Handled = True
        End If
    End Sub
    Private Sub cboKependisisDoorType_ProcessNewValue(sender As Object, e As ProcessNewValueEventArgs) Handles cboKependisisDoorType.ProcessNewValue
        If CStr(e.DisplayValue) <> String.Empty Then
            Dim sDoorTypeID = DBQ.InsertNewDoorType(cboKependisisDoorType, e.DisplayValue)
            If sDoorTypeID <> "" Then
                Me.Vw_DOOR_TYPE_V2TableAdapter.Fill(Me.DM_DOORTYPES.vw_DOOR_TYPE_V2)
                cboKependisisDoorType.EditValue = System.Guid.Parse(sDoorTypeID)
            End If
            e.Handled = True
        End If
    End Sub
    Private Sub cboSndEpendisisDoorType_ProcessNewValue(sender As Object, e As ProcessNewValueEventArgs) Handles cboSndEpendisisDoorType.ProcessNewValue
        If CStr(e.DisplayValue) <> String.Empty Then
            Dim sDoorTypeID = DBQ.InsertNewDoorType(cboSndEpendisisDoorType, e.DisplayValue)
            If sDoorTypeID <> "" Then
                Me.Vw_DOOR_TYPE_V2TableAdapter.Fill(Me.DM_DOORTYPES.vw_DOOR_TYPE_V2)
                cboSndEpendisisDoorType.EditValue = System.Guid.Parse(sDoorTypeID)
            End If
            e.Handled = True
        End If
    End Sub
    Private Sub cboYDoorType_ProcessNewValue(sender As Object, e As ProcessNewValueEventArgs) Handles cboYDoorType.ProcessNewValue
        If CStr(e.DisplayValue) <> String.Empty Then
            Dim sDoorTypeID = DBQ.InsertNewDoorType(cboYDoorType, e.DisplayValue)
            If sDoorTypeID <> "" Then
                Me.Vw_DOOR_TYPE_V2TableAdapter.Fill(Me.DM_DOORTYPES.vw_DOOR_TYPE_V2)
                cboYDoorType.EditValue = System.Guid.Parse(sDoorTypeID)
            End If
            e.Handled = True
        End If
    End Sub
    Private Sub cboYDoorType1_ProcessNewValue(sender As Object, e As ProcessNewValueEventArgs) Handles cboYDoorType1.ProcessNewValue
        If CStr(e.DisplayValue) <> String.Empty Then
            Dim sDoorTypeID = DBQ.InsertNewDoorType(cboYDoorType1, e.DisplayValue)
            If sDoorTypeID <> "" Then
                Me.Vw_DOOR_TYPE_V2TableAdapter.Fill(Me.DM_DOORTYPES.vw_DOOR_TYPE_V2)
                cboYDoorType1.EditValue = System.Guid.Parse(sDoorTypeID)
            End If
            e.Handled = True
        End If
    End Sub

    Private Sub cboVRafieraDoorType_ProcessNewValue(sender As Object, e As ProcessNewValueEventArgs) Handles cboVRafieraDoorType.ProcessNewValue
        If CStr(e.DisplayValue) <> String.Empty Then
            Dim sDoorTypeID = DBQ.InsertNewDoorType(cboVRafieraDoorType, e.DisplayValue)
            If sDoorTypeID <> "" Then
                Me.Vw_DOOR_TYPE_V2TableAdapter.Fill(Me.DM_DOORTYPES.vw_DOOR_TYPE_V2)
                cboVRafieraDoorType.EditValue = System.Guid.Parse(sDoorTypeID)
            End If
            e.Handled = True
        End If
    End Sub
    Private Sub cboKRafieraDoorType_ProcessNewValue(sender As Object, e As ProcessNewValueEventArgs) Handles cboKRafieraDoorType.ProcessNewValue
        If CStr(e.DisplayValue) <> String.Empty Then
            Dim sDoorTypeID = DBQ.InsertNewDoorType(cboKRafieraDoorType, e.DisplayValue)
            If sDoorTypeID <> "" Then
                Me.Vw_DOOR_TYPE_V2TableAdapter.Fill(Me.DM_DOORTYPES.vw_DOOR_TYPE_V2)
                cboKRafieraDoorType.EditValue = System.Guid.Parse(sDoorTypeID)
            End If
            e.Handled = True
        End If
    End Sub

    Private Sub cboYRafieraDoorType_ProcessNewValue(sender As Object, e As ProcessNewValueEventArgs) Handles cboYRafieraDoorType.ProcessNewValue
        If CStr(e.DisplayValue) <> String.Empty Then
            Dim sDoorTypeID = DBQ.InsertNewDoorType(cboYRafieraDoorType, e.DisplayValue)
            If sDoorTypeID <> "" Then
                Me.Vw_DOOR_TYPE_V2TableAdapter.Fill(Me.DM_DOORTYPES.vw_DOOR_TYPE_V2)
                cboYRafieraDoorType.EditValue = System.Guid.Parse(sDoorTypeID)
            End If
            e.Handled = True
        End If
    End Sub
    Private Sub cboKWallRafiaDoorType_ProcessNewValue(sender As Object, e As ProcessNewValueEventArgs) Handles cboKWallRafiaDoorType.ProcessNewValue
        If CStr(e.DisplayValue) <> String.Empty Then
            Dim sDoorTypeID = DBQ.InsertNewDoorType(cboKWallRafiaDoorType, e.DisplayValue)
            If sDoorTypeID <> "" Then
                Me.Vw_DOOR_TYPE_V2TableAdapter.Fill(Me.DM_DOORTYPES.vw_DOOR_TYPE_V2)
                cboKWallRafiaDoorType.EditValue = System.Guid.Parse(sDoorTypeID)
            End If
            e.Handled = True
        End If
    End Sub

    Private Sub cboVBOXColors_ProcessNewValue(sender As Object, e As ProcessNewValueEventArgs) Handles cboVBOXColors.ProcessNewValue
        If CStr(e.DisplayValue) <> String.Empty Then
            Dim sDoorTypeID = DBQ.InsertNewDoorType(cboVBOXColors, e.DisplayValue)
            If sDoorTypeID <> "" Then
                Me.Vw_DOOR_TYPE_V2TableAdapter.Fill(Me.DM_DOORTYPES.vw_DOOR_TYPE_V2)
                cboVBOXColors.EditValue = System.Guid.Parse(sDoorTypeID)
            End If
            e.Handled = True
        End If
    End Sub

    Private Sub cboKBOXColors_ProcessNewValue(sender As Object, e As ProcessNewValueEventArgs) Handles cboKBOXColors.ProcessNewValue
        If CStr(e.DisplayValue) <> String.Empty Then
            Dim sDoorTypeID = DBQ.InsertNewDoorType(cboKBOXColors, e.DisplayValue)
            If sDoorTypeID <> "" Then
                Me.Vw_DOOR_TYPE_V2TableAdapter.Fill(Me.DM_DOORTYPES.vw_DOOR_TYPE_V2)
                cboKBOXColors.EditValue = System.Guid.Parse(sDoorTypeID)
            End If
            e.Handled = True
        End If
    End Sub

    Private Sub cboYBOXColors_ProcessNewValue(sender As Object, e As ProcessNewValueEventArgs) Handles cboYBOXColors.ProcessNewValue
        If CStr(e.DisplayValue) <> String.Empty Then
            Dim sDoorTypeID = DBQ.InsertNewDoorType(cboYBOXColors, e.DisplayValue)
            If sDoorTypeID <> "" Then
                Me.Vw_DOOR_TYPE_V2TableAdapter.Fill(Me.DM_DOORTYPES.vw_DOOR_TYPE_V2)
                cboYBOXColors.EditValue = System.Guid.Parse(sDoorTypeID)
            End If
            e.Handled = True
        End If
    End Sub

    Private Sub cboGOLAColors_ProcessNewValue(sender As Object, e As ProcessNewValueEventArgs) Handles cboGOLAColors.ProcessNewValue
        If CStr(e.DisplayValue) <> String.Empty Then
            Dim sDoorTypeID = DBQ.InsertNewDoorType(cboGOLAColors, e.DisplayValue)
            If sDoorTypeID <> "" Then
                Me.Vw_DOOR_TYPE_V2TableAdapter.Fill(Me.DM_DOORTYPES.vw_DOOR_TYPE_V2)
                cboGOLAColors.EditValue = System.Guid.Parse(sDoorTypeID)
            End If
            e.Handled = True
        End If
    End Sub

    Private Sub cboCompany_EditValueChanged(sender As Object, e As EventArgs) Handles cboCompany.EditValueChanged
        Dim sCompID As String
        If cboCompany.EditValue Is Nothing Then sCompID = toSQLValueS(Guid.Empty.ToString) Else sCompID = toSQLValueS(cboCompany.EditValue.ToString)
        Dim sSQL As New System.Text.StringBuilder
        sSQL.AppendLine("Select T.id,FullTranshDescription,Description,Iskitchen,Iscloset,Isdoors,Issc
                        from vw_TRANSH t
                        where  T.cusid = " & sCompID & "order by description")
        FillCbo.TRANSH(cboCompProject, sSQL)
        LCompProject.ImageOptions.Image = Global.DreamyKitchenCRM.My.Resources.Resources.rsz_11rsz_asterisk
    End Sub

    Private Sub cboCompProject_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboCompProject.ButtonClick
        Select Case e.Button.Index
            Case 1 : ManageCbo.ManageTRANSHSmall(cboCompProject, FormMode.NewRecord, cboCompany.EditValue)
            Case 2 : ManageCbo.ManageTRANSHSmall(cboCompProject, FormMode.EditRecord, cboCompany.EditValue)
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
End Class