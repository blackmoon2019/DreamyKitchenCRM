Imports System.Data.SqlClient
Imports DevExpress.XtraBars.Navigation
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraExport.Helpers
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid

Public Class frmCUSOfferOrderCloset
    Private CusOfferOrderCloset As New CusOfferOrderCloset
    Private ManageCbo As New CombosManager
    Private sID As String
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
    Private Prog_Prop As New ProgProp
    Public WriteOnly Property ID As String
        Set(value As String)
            sID = value
        End Set
    End Property
    Public WriteOnly Property IsOrder As Boolean
        Set(value As Boolean)
            sIsOrder = value
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

    Private Sub frmCUSOrderCloset_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DM_CCT.vw_COMP' table. You can move, or remove it, as needed.
        Me.Vw_COMPTableAdapter.Fill(Me.DM_CCT.vw_COMP)
        CusOfferOrderCloset.Initialize(Me, sID, Mode, CalledFromCtrl, CtrlCombo, sIsOrder)
        CusOfferOrderCloset.LoadForm()
        Me.CenterToScreen()
    End Sub


    Private Sub frmCUSOrderCloset_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        If Me.WindowState = FormWindowState.Maximized Then frmMain.XtraTabbedMdiManager1.Dock(Me, frmMain.XtraTabbedMdiManager1)
    End Sub

    Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click
        CusOfferOrderCloset.SaveRecord(sID)
    End Sub
    Private Sub cboCUS_EditValueChanged(sender As Object, e As EventArgs) Handles cboCUS.EditValueChanged
        Dim sCusID As String
        If cboCUS.EditValue Is Nothing Then sCusID = toSQLValueS(Guid.Empty.ToString) Else sCusID = toSQLValueS(cboCUS.EditValue.ToString)
        Dim sSQL As New System.Text.StringBuilder
        sSQL.AppendLine("Select T.id,FullTranshDescription,Description,Iskitchen,Iscloset,Isdoor,Issc
                        from vw_TRANSH t
                        INNER JOIN TRANSC on transc.transhID = t.id and TRANSC.transhcID = '3DAF9172-E9C4-402D-9BE7-4A3F64ABDAE4' 
                        where  completed = 0 and T.cusid = " & sCusID & "order by description")
        Dim sVal As String
        If cboTRANSH.EditValue IsNot Nothing Then sVal = cboTRANSH.EditValue.ToString
        FillCbo.TRANSH(cboTRANSH, sSQL)
        If sVal <> "" Then cboTRANSH.EditValue = Guid.Parse(sVal)
    End Sub
    Private Sub txtdtdaysOfDelivery_EditValueChanged(sender As Object, e As EventArgs) Handles txtdtdaysOfDelivery.EditValueChanged
        If dtpresentation.EditValue Is Nothing Then Exit Sub
        If dtpresentation.EditValue.ToString = "" Then Exit Sub
        Dim FirstDate As Date = dtpresentation.EditValue
        lblDate.Text = "Ημερομηνία Παράδοσης: " & DateAdd("d", CDbl(txtdtdaysOfDelivery.EditValue.ToString), FirstDate).ToString("dd/MM/yyyy")
    End Sub

    Private Sub dtpresentation_EditValueChanged(sender As Object, e As EventArgs) Handles dtpresentation.EditValueChanged
        If dtpresentation.EditValue Is Nothing Then Exit Sub
        If dtpresentation.EditValue.ToString = "" Then Exit Sub
        Dim FirstDate As Date = dtpresentation.EditValue
        If txtdtdaysOfDelivery.EditValue Is Nothing Then txtdtdaysOfDelivery.EditValue = 0
        lblDate.Text = "Ημερομηνία Παράδοσης: " & DateAdd("d", CDbl(txtdtdaysOfDelivery.EditValue.ToString), FirstDate).ToString("dd/MM/yyyy")
    End Sub

    Private Sub txtTotalClosetVat_EditValueChanged(sender As Object, e As EventArgs) Handles txtTotalClosetVat.EditValueChanged
        Dim TotalClosetPrice As Double
        TotalClosetPrice = (txtTotalClosetVat.EditValue * (ProgProps.VAT / 100)) + txtTotalClosetVat.EditValue
        txtTotalClosetPice.EditValue = TotalClosetPrice
    End Sub
    Private Sub RepDefPrice_ButtonPressed(sender As Object, e As ButtonPressedEventArgs) Handles RepDefPrice.ButtonPressed
        Select Case e.Button.Index
            Case 0 : GridView2.SetRowCellValue(GridView2.FocusedRowHandle, "price", GridView2.GetRowCellValue(GridView2.FocusedRowHandle, "defPrice").ToString)
            Case 1 : GridView2.SetRowCellValue(GridView2.FocusedRowHandle, "price", "0.00")
        End Select
    End Sub

    Private Sub GridView2_PopupMenuShowing(sender As Object, e As PopupMenuShowingEventArgs) Handles GridView2.PopupMenuShowing
        If e.MenuType = GridMenuType.Column Then LoadForms.PopupMenuShow(e, GridView2, "CCT_ORDERS_CLOSET_EQUIPMENT_def.xml", "vw_CCT_ORDERS_CLOSET_EQUIPMENT")
    End Sub

    Private Sub cmdPrintOffer_Click(sender As Object, e As EventArgs) Handles cmdPrintOffer.Click
        CusOfferOrderCloset.PrintOfferOrder()
    End Sub
    Private Sub cboTRANSH_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboTRANSH.ButtonClick
        Select Case e.Button.Index
            Case 1 : ManageCbo.ManageTRANSHSmall(cboTRANSH, FormMode.NewRecord, cboCUS.EditValue)
            Case 2 : ManageCbo.ManageTRANSHSmall(cboTRANSH, FormMode.EditRecord, cboCUS.EditValue)
            Case 3 : cboTRANSH.EditValue = Nothing
        End Select
    End Sub


    Private Sub cmdSaveEquipDev_Click(sender As Object, e As EventArgs) Handles cmdSaveEquipDev.Click
        CusOfferOrderCloset.InsertSelectedRows()
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
    Private Sub cboBOXColors_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboBOXColors.ButtonClick
        Select Case e.Button.Index
            Case 1 : ManageCbo.ManageValueListItem(cboBOXColors, FormMode.NewRecord, "DE86FD16-2154-4E2A-B025-4D34BDF8C808")
            Case 2 : ManageCbo.ManageValueListItem(cboBOXColors, FormMode.EditRecord)
            Case 3 : cboBOXColors.EditValue = Nothing
        End Select
    End Sub
    Private Sub cboBOXColors2_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboBOXColors2.ButtonClick
        Select Case e.Button.Index
            Case 1 : ManageCbo.ManageValueListItem(cboBOXColors2, FormMode.NewRecord, "DE86FD16-2154-4E2A-B025-4D34BDF8C808")
            Case 2 : ManageCbo.ManageValueListItem(cboBOXColors2, FormMode.EditRecord)
            Case 3 : cboBOXColors2.EditValue = Nothing
        End Select
    End Sub
    Private Sub cboBOXColors3_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboBOXColors3.ButtonClick
        Select Case e.Button.Index
            Case 1 : ManageCbo.ManageValueListItem(cboBOXColors3, FormMode.NewRecord, "DE86FD16-2154-4E2A-B025-4D34BDF8C808")
            Case 2 : ManageCbo.ManageValueListItem(cboBOXColors3, FormMode.EditRecord)
            Case 3 : cboBOXColors3.EditValue = Nothing
        End Select
    End Sub
    Private Sub cboBOXColors4_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboBOXColors4.ButtonClick
        Select Case e.Button.Index
            Case 1 : ManageCbo.ManageValueListItem(cboBOXColors4, FormMode.NewRecord, "DE86FD16-2154-4E2A-B025-4D34BDF8C808")
            Case 2 : ManageCbo.ManageValueListItem(cboBOXColors4, FormMode.EditRecord)
            Case 3 : cboBOXColors4.EditValue = Nothing
        End Select
    End Sub
    Private Sub cboBOXColors5_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboBOXColors5.ButtonClick
        Select Case e.Button.Index
            Case 1 : ManageCbo.ManageValueListItem(cboBOXColors5, FormMode.NewRecord, "DE86FD16-2154-4E2A-B025-4D34BDF8C808")
            Case 2 : ManageCbo.ManageValueListItem(cboBOXColors5, FormMode.EditRecord)
            Case 3 : cboBOXColors5.EditValue = Nothing
        End Select
    End Sub
    Private Sub cboBOXColors6_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboBOXColors6.ButtonClick
        Select Case e.Button.Index
            Case 1 : ManageCbo.ManageValueListItem(cboBOXColors6, FormMode.NewRecord, "DE86FD16-2154-4E2A-B025-4D34BDF8C808")
            Case 2 : ManageCbo.ManageValueListItem(cboBOXColors6, FormMode.EditRecord)
            Case 3 : cboBOXColors6.EditValue = Nothing
        End Select
    End Sub

    Private Sub cboValueListItemID_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboValueListItem.ButtonClick
        Select Case e.Button.Index
            Case 1 : ManageCbo.ManageValueListItem(cboValueListItem, FormMode.NewRecord, "DE86FD16-2154-4E2A-B025-4D34BDF8C808")
            Case 2 : ManageCbo.ManageValueListItem(cboValueListItem, FormMode.EditRecord)
            Case 3 : cboValueListItem.EditValue = Nothing
        End Select
    End Sub
    Private Sub cboValueListItemID2_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboValueListItem2.ButtonClick
        Select Case e.Button.Index
            Case 1 : ManageCbo.ManageValueListItem(cboValueListItem8, FormMode.NewRecord, "DE86FD16-2154-4E2A-B025-4D34BDF8C808")
            Case 2 : ManageCbo.ManageValueListItem(cboValueListItem8, FormMode.EditRecord)
            Case 3 : cboValueListItem8.EditValue = Nothing
        End Select
    End Sub
    Private Sub cboValueListItemID3_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboValueListItem3.ButtonClick
        Select Case e.Button.Index
            Case 1 : ManageCbo.ManageValueListItem(cboValueListItem9, FormMode.NewRecord, "DE86FD16-2154-4E2A-B025-4D34BDF8C808")
            Case 2 : ManageCbo.ManageValueListItem(cboValueListItem9, FormMode.EditRecord)
            Case 3 : cboValueListItem9.EditValue = Nothing
        End Select
    End Sub
    Private Sub cboValueListItemID4_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboValueListItem4.ButtonClick
        Select Case e.Button.Index
            Case 1 : ManageCbo.ManageValueListItem(cboValueListItem4, FormMode.NewRecord, "DE86FD16-2154-4E2A-B025-4D34BDF8C808")
            Case 2 : ManageCbo.ManageValueListItem(cboValueListItem4, FormMode.EditRecord)
            Case 3 : cboValueListItem4.EditValue = Nothing
        End Select
    End Sub
    Private Sub cboValueListItemID5_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboValueListItem5.ButtonClick
        Select Case e.Button.Index
            Case 1 : ManageCbo.ManageValueListItem(cboValueListItem5, FormMode.NewRecord, "DE86FD16-2154-4E2A-B025-4D34BDF8C808")
            Case 2 : ManageCbo.ManageValueListItem(cboValueListItem5, FormMode.EditRecord)
            Case 3 : cboValueListItem5.EditValue = Nothing
        End Select
    End Sub
    Private Sub cboValueListItemID6_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboValueListItem6.ButtonClick
        Select Case e.Button.Index
            Case 1 : ManageCbo.ManageValueListItem(cboValueListItem6, FormMode.NewRecord, "DE86FD16-2154-4E2A-B025-4D34BDF8C808")
            Case 2 : ManageCbo.ManageValueListItem(cboValueListItem6, FormMode.EditRecord)
            Case 3 : cboValueListItem6.EditValue = Nothing
        End Select
    End Sub
    Private Sub cboValueListItemID7_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboValueListItem7.ButtonClick
        Select Case e.Button.Index
            Case 1 : ManageCbo.ManageValueListItem(cboValueListItem7, FormMode.NewRecord, "DE86FD16-2154-4E2A-B025-4D34BDF8C808")
            Case 2 : ManageCbo.ManageValueListItem(cboValueListItem7, FormMode.EditRecord)
            Case 3 : cboValueListItem7.EditValue = Nothing
        End Select
    End Sub
    Private Sub cboValueListItemID8_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboValueListItem8.ButtonClick
        Select Case e.Button.Index
            Case 1 : ManageCbo.ManageValueListItem(cboValueListItem2, FormMode.NewRecord, "DE86FD16-2154-4E2A-B025-4D34BDF8C808")
            Case 2 : ManageCbo.ManageValueListItem(cboValueListItem2, FormMode.EditRecord)
            Case 3 : cboValueListItem2.EditValue = Nothing
        End Select
    End Sub
    Private Sub cboValueListItemID9_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboValueListItem9.ButtonClick
        Select Case e.Button.Index
            Case 1 : ManageCbo.ManageValueListItem(cboValueListItem3, FormMode.NewRecord, "DE86FD16-2154-4E2A-B025-4D34BDF8C808")
            Case 2 : ManageCbo.ManageValueListItem(cboValueListItem3, FormMode.EditRecord)
            Case 3 : cboValueListItem3.EditValue = Nothing
        End Select
    End Sub
    Private Sub cboValueListItemID10_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboValueListItem10.ButtonClick
        Select Case e.Button.Index
            Case 1 : ManageCbo.ManageValueListItem(cboValueListItem10, FormMode.NewRecord, "DE86FD16-2154-4E2A-B025-4D34BDF8C808")
            Case 2 : ManageCbo.ManageValueListItem(cboValueListItem10, FormMode.EditRecord)
            Case 3 : cboValueListItem10.EditValue = Nothing
        End Select
    End Sub
    Private Sub cboValueListItemID11_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboValueListItem11.ButtonClick
        Select Case e.Button.Index
            Case 1 : ManageCbo.ManageValueListItem(cboValueListItem11, FormMode.NewRecord, "DE86FD16-2154-4E2A-B025-4D34BDF8C808")
            Case 2 : ManageCbo.ManageValueListItem(cboValueListItem11, FormMode.EditRecord)
            Case 3 : cboValueListItem11.EditValue = Nothing
        End Select
    End Sub
    Private Sub cboValueListItemID12_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboValueListItem12.ButtonClick
        Select Case e.Button.Index
            Case 1 : ManageCbo.ManageValueListItem(cboValueListItem12, FormMode.NewRecord, "DE86FD16-2154-4E2A-B025-4D34BDF8C808")
            Case 2 : ManageCbo.ManageValueListItem(cboValueListItem12, FormMode.EditRecord)
            Case 3 : cboValueListItem12.EditValue = Nothing
        End Select
    End Sub
    Private Sub cboSides1_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboSides1.ButtonClick
        Select Case e.Button.Index
            Case 1 : ManageCbo.ManageValueListItem(cboSides1, FormMode.NewRecord, "DE86FD16-2154-4E2A-B025-4D34BDF8C808")
            Case 2 : ManageCbo.ManageValueListItem(cboSides1, FormMode.EditRecord)
            Case 3 : cboSides1.EditValue = Nothing
        End Select
    End Sub

    Private Sub cboSides2_ButtonClick(sender As Object, e As ButtonPressedEventArgs)
        Select Case e.Button.Index
            Case 1 : ManageCbo.ManageValueListItem(cboSides2, FormMode.NewRecord, "DE86FD16-2154-4E2A-B025-4D34BDF8C808")
            Case 2 : ManageCbo.ManageValueListItem(cboSides2, FormMode.EditRecord)
            Case 3 : cboSides2.EditValue = Nothing
        End Select
    End Sub

    Private Sub cboSides3_ButtonClick(sender As Object, e As ButtonPressedEventArgs)
        Select Case e.Button.Index
            Case 1 : ManageCbo.ManageValueListItem(cboSides3, FormMode.NewRecord, "DE86FD16-2154-4E2A-B025-4D34BDF8C808")
            Case 2 : ManageCbo.ManageValueListItem(cboSides3, FormMode.EditRecord)
            Case 3 : cboSides3.EditValue = Nothing
        End Select
    End Sub

    Private Sub cboSides4_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboSides4.ButtonClick
        Select Case e.Button.Index
            Case 1 : ManageCbo.ManageValueListItem(cboSides4, FormMode.NewRecord, "DE86FD16-2154-4E2A-B025-4D34BDF8C808")
            Case 2 : ManageCbo.ManageValueListItem(cboSides1, FormMode.EditRecord)
            Case 3 : cboSides4.EditValue = Nothing
        End Select
    End Sub

    Private Sub cboSides5_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboSides5.ButtonClick
        Select Case e.Button.Index
            Case 1 : ManageCbo.ManageValueListItem(cboSides5, FormMode.NewRecord, "DE86FD16-2154-4E2A-B025-4D34BDF8C808")
            Case 2 : ManageCbo.ManageValueListItem(cboSides5, FormMode.EditRecord)
            Case 3 : cboSides5.EditValue = Nothing
        End Select
    End Sub


    Private Sub cboSides6_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboSides6.ButtonClick
        Select Case e.Button.Index
            Case 1 : ManageCbo.ManageValueListItem(cboSides6, FormMode.NewRecord, "DE86FD16-2154-4E2A-B025-4D34BDF8C808")
            Case 2 : ManageCbo.ManageValueListItem(cboSides6, FormMode.EditRecord)
            Case 3 : cboSides6.EditValue = Nothing
        End Select
    End Sub

    Private Sub cboShelves1_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboShelves1.ButtonClick
        Select Case e.Button.Index
            Case 1 : ManageCbo.ManageValueListItem(cboShelves1, FormMode.NewRecord, "DE86FD16-2154-4E2A-B025-4D34BDF8C808")
            Case 2 : ManageCbo.ManageValueListItem(cboShelves1, FormMode.EditRecord)
            Case 3 : cboShelves1.EditValue = Nothing
        End Select
    End Sub

    Private Sub cboShelves2_ButtonClick(sender As Object, e As ButtonPressedEventArgs)
        Select Case e.Button.Index
            Case 1 : ManageCbo.ManageValueListItem(cboShelves2, FormMode.NewRecord, "DE86FD16-2154-4E2A-B025-4D34BDF8C808")
            Case 2 : ManageCbo.ManageValueListItem(cboShelves2, FormMode.EditRecord)
            Case 3 : cboShelves2.EditValue = Nothing
        End Select
    End Sub

    Private Sub cboShelves3_ButtonClick(sender As Object, e As ButtonPressedEventArgs)
        Select Case e.Button.Index
            Case 1 : ManageCbo.ManageValueListItem(cboShelves3, FormMode.NewRecord, "DE86FD16-2154-4E2A-B025-4D34BDF8C808")
            Case 2 : ManageCbo.ManageValueListItem(cboShelves3, FormMode.EditRecord)
            Case 3 : cboShelves3.EditValue = Nothing
        End Select
    End Sub

    Private Sub cboShelves4_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboShelves4.ButtonClick
        Select Case e.Button.Index
            Case 1 : ManageCbo.ManageValueListItem(cboShelves4, FormMode.NewRecord, "DE86FD16-2154-4E2A-B025-4D34BDF8C808")
            Case 2 : ManageCbo.ManageValueListItem(cboShelves1, FormMode.EditRecord)
            Case 3 : cboShelves4.EditValue = Nothing
        End Select
    End Sub

    Private Sub cboShelves5_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboShelves5.ButtonClick
        Select Case e.Button.Index
            Case 1 : ManageCbo.ManageValueListItem(cboShelves5, FormMode.NewRecord, "DE86FD16-2154-4E2A-B025-4D34BDF8C808")
            Case 2 : ManageCbo.ManageValueListItem(cboShelves5, FormMode.EditRecord)
            Case 3 : cboShelves5.EditValue = Nothing
        End Select
    End Sub
    Private Sub cboShelves6_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboShelves6.ButtonClick
        Select Case e.Button.Index
            Case 1 : ManageCbo.ManageValueListItem(cboShelves6, FormMode.NewRecord, "DE86FD16-2154-4E2A-B025-4D34BDF8C808")
            Case 2 : ManageCbo.ManageValueListItem(cboShelves6, FormMode.EditRecord)
            Case 3 : cboShelves6.EditValue = Nothing
        End Select
    End Sub

    Private Sub cboClosetType1_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboClosetType1.ButtonClick
        Select Case e.Button.Index
            Case 1 : cboClosetType1.EditValue = Nothing
        End Select
    End Sub
    Private Sub cboClosetType2_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboClosetType2.ButtonClick
        Select Case e.Button.Index
            Case 1 : cboClosetType2.EditValue = Nothing
        End Select
    End Sub
    Private Sub cboClosetType3_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboClosetType3.ButtonClick
        Select Case e.Button.Index
            Case 1 : cboClosetType3.EditValue = Nothing
        End Select
    End Sub
    Private Sub cboClosetType4_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboClosetType4.ButtonClick
        Select Case e.Button.Index
            Case 1 : cboClosetType4.EditValue = Nothing
        End Select
    End Sub
    Private Sub cboClosetType5_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboClosetType5.ButtonClick
        Select Case e.Button.Index
            Case 1 : cboClosetType5.EditValue = Nothing
        End Select
    End Sub
    Private Sub cboClosetType6_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboClosetType6.ButtonClick
        Select Case e.Button.Index
            Case 1 : cboClosetType6.EditValue = Nothing
        End Select
    End Sub
    Private Sub GridView2_ValidatingEditor(sender As Object, e As BaseContainerValidateEditorEventArgs) Handles GridView2.ValidatingEditor
        Dim grdView As GridView = sender
        If grdView.FocusedColumn.FieldName = "checked" Then
            If CStr(e.Value) = "false" Then
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
        CusOfferOrderCloset.ConvertToOrder()
    End Sub
    Private Sub ApplyDiscount(ByVal DiscMode As Integer, Optional ByVal DiscountChangedByUser As Boolean = False)
        Dim Disc As Double, Discount As Double, InitialPrice As Double, FinalPrice As Double
        If Me.IsActive = False Then Exit Sub
        Select Case DiscMode
            Case 1
                If DiscountChangedByUser = False Then txtDisc1.EditValue = ProgProps.CusDiscountCloset
                InitialPrice = txtInitialPrice1.EditValue
                If DiscountChangedByUser = False Then Disc = ProgProps.CusDiscountCloset / 100 Else Disc = txtDisc1.EditValue / 100
                Discount = Disc * InitialPrice
                FinalPrice = InitialPrice - Discount
                txtInitialPrice1.EditValue = InitialPrice
                txtDiscount1.EditValue = Discount
                txtFinalPrice1.EditValue = FinalPrice
            Case 2
                If DiscountChangedByUser = False Then txtDisc2.EditValue = ProgProps.CusDiscountCloset
                InitialPrice = txtInitialPrice2.EditValue
                If DiscountChangedByUser = False Then Disc = ProgProps.CusDiscountCloset / 100 Else Disc = txtDisc2.EditValue / 100
                Discount = Disc * InitialPrice
                FinalPrice = InitialPrice - Discount
                txtInitialPrice2.EditValue = InitialPrice
                txtDiscount2.EditValue = Discount
                txtFinalPrice2.EditValue = FinalPrice
            Case 3
                If DiscountChangedByUser = False Then txtDisc3.EditValue = ProgProps.CusDiscountCloset
                InitialPrice = txtInitialPrice3.EditValue
                If DiscountChangedByUser = False Then Disc = ProgProps.CusDiscountCloset / 100 Else Disc = txtDisc3.EditValue / 100
                Discount = Disc * InitialPrice
                FinalPrice = InitialPrice - Discount
                txtInitialPrice3.EditValue = InitialPrice
                txtDiscount3.EditValue = Discount
                txtFinalPrice3.EditValue = FinalPrice
            Case 4
                If DiscountChangedByUser = False Then txtDisc4.EditValue = ProgProps.CusDiscountCloset
                InitialPrice = txtInitialPrice4.EditValue
                If DiscountChangedByUser = False Then Disc = ProgProps.CusDiscountCloset / 100 Else Disc = txtDisc4.EditValue / 100
                Discount = Disc * InitialPrice
                FinalPrice = InitialPrice - Discount
                txtInitialPrice4.EditValue = InitialPrice
                txtDiscount4.EditValue = Discount
                txtFinalPrice4.EditValue = FinalPrice
            Case 5
                If DiscountChangedByUser = False Then txtDisc5.EditValue = ProgProps.CusDiscountCloset
                InitialPrice = txtInitialPrice5.EditValue
                If DiscountChangedByUser = False Then Disc = ProgProps.CusDiscountCloset / 100 Else Disc = txtDisc5.EditValue / 100
                Discount = Disc * InitialPrice
                FinalPrice = InitialPrice - Discount
                txtInitialPrice5.EditValue = InitialPrice
                txtDiscount5.EditValue = Discount
                txtFinalPrice5.EditValue = FinalPrice
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
    Private Sub txtInitialPrice5_EditValueChanged(sender As Object, e As EventArgs) Handles txtInitialPrice5.EditValueChanged
        ApplyDiscount(5)
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
    Private Sub txtDisc5_EditValueChanged(sender As Object, e As EventArgs) Handles txtDisc5.EditValueChanged
        ApplyDiscount(5, True)
    End Sub

    Private Sub cboValueListItemID_ProcessNewValue(sender As Object, e As ProcessNewValueEventArgs) Handles cboValueListItem.ProcessNewValue
        If CStr(e.DisplayValue) <> String.Empty Then
            Dim sValueListItemID = DBQ.InsertNewValueListItem(cboValueListItem, e.DisplayValue)
            If sValueListItemID <> "" Then
                Me.Vw_VALUELISTITEM_V2TableAdapter.Fill(Me.DM_VALUELISTITEM.vw_VALUELISTITEM_V2)
                cboValueListItem.EditValue = System.Guid.Parse(sValueListItemID)
            End If
            e.Handled = True
        End If
    End Sub
    Private Sub cboValueListItemID7_ProcessNewValue(sender As Object, e As ProcessNewValueEventArgs) Handles cboValueListItem7.ProcessNewValue
        If CStr(e.DisplayValue) <> String.Empty Then
            Dim sValueListItemID = DBQ.InsertNewValueListItem(cboValueListItem7, e.DisplayValue)
            If sValueListItemID <> "" Then
                Me.Vw_VALUELISTITEM_V2TableAdapter.Fill(Me.DM_VALUELISTITEM.vw_VALUELISTITEM_V2)
                cboValueListItem7.EditValue = System.Guid.Parse(sValueListItemID)
            End If
            e.Handled = True
        End If
    End Sub
    Private Sub cboSides1_ProcessNewValue(sender As Object, e As ProcessNewValueEventArgs) Handles cboSides1.ProcessNewValue
        If CStr(e.DisplayValue) <> String.Empty Then
            Dim sValueListItemID = DBQ.InsertNewValueListItem(cboSides1, e.DisplayValue)
            If sValueListItemID <> "" Then
                Me.Vw_VALUELISTITEM_V2TableAdapter.Fill(Me.DM_VALUELISTITEM.vw_VALUELISTITEM_V2)
                cboSides1.EditValue = System.Guid.Parse(sValueListItemID)
            End If
            e.Handled = True
        End If
    End Sub
    Private Sub cboShelves1_ProcessNewValue(sender As Object, e As ProcessNewValueEventArgs) Handles cboShelves1.ProcessNewValue
        If CStr(e.DisplayValue) <> String.Empty Then
            Dim sValueListItemID = DBQ.InsertNewValueListItem(cboShelves1, e.DisplayValue)
            If sValueListItemID <> "" Then
                Me.Vw_VALUELISTITEM_V2TableAdapter.Fill(Me.DM_VALUELISTITEM.vw_VALUELISTITEM_V2)
                cboShelves1.EditValue = System.Guid.Parse(sValueListItemID)
            End If
            e.Handled = True
        End If
    End Sub

    Private Sub cboValueListItemID2_ProcessNewValue(sender As Object, e As ProcessNewValueEventArgs) Handles cboValueListItem2.ProcessNewValue
        If CStr(e.DisplayValue) <> String.Empty Then
            Dim sValueListItemID = DBQ.InsertNewValueListItem(cboValueListItem2, e.DisplayValue)
            If sValueListItemID <> "" Then
                Me.Vw_VALUELISTITEM_V2TableAdapter.Fill(Me.DM_VALUELISTITEM.vw_VALUELISTITEM_V2)
                cboValueListItem2.EditValue = System.Guid.Parse(sValueListItemID)
            End If
            e.Handled = True
        End If
    End Sub
    Private Sub cboValueListItemID8_ProcessNewValue(sender As Object, e As ProcessNewValueEventArgs) Handles cboValueListItem8.ProcessNewValue
        If CStr(e.DisplayValue) <> String.Empty Then
            Dim sValueListItemID = DBQ.InsertNewValueListItem(cboValueListItem8, e.DisplayValue)
            If sValueListItemID <> "" Then
                Me.Vw_VALUELISTITEM_V2TableAdapter.Fill(Me.DM_VALUELISTITEM.vw_VALUELISTITEM_V2)
                cboValueListItem8.EditValue = System.Guid.Parse(sValueListItemID)
            End If
            e.Handled = True
        End If
    End Sub
    Private Sub cboSides2_ProcessNewValue(sender As Object, e As ProcessNewValueEventArgs) Handles cboSides2.ProcessNewValue
        If CStr(e.DisplayValue) <> String.Empty Then
            Dim sValueListItemID = DBQ.InsertNewValueListItem(cboSides2, e.DisplayValue)
            If sValueListItemID <> "" Then
                Me.Vw_VALUELISTITEM_V2TableAdapter.Fill(Me.DM_VALUELISTITEM.vw_VALUELISTITEM_V2)
                cboSides2.EditValue = System.Guid.Parse(sValueListItemID)
            End If
            e.Handled = True
        End If
    End Sub
    Private Sub cboShelves2_ProcessNewValue(sender As Object, e As ProcessNewValueEventArgs) Handles cboShelves2.ProcessNewValue
        If CStr(e.DisplayValue) <> String.Empty Then
            Dim sValueListItemID = DBQ.InsertNewValueListItem(cboShelves2, e.DisplayValue)
            If sValueListItemID <> "" Then
                Me.Vw_VALUELISTITEM_V2TableAdapter.Fill(Me.DM_VALUELISTITEM.vw_VALUELISTITEM_V2)
                cboShelves2.EditValue = System.Guid.Parse(sValueListItemID)
            End If
            e.Handled = True
        End If
    End Sub

    Private Sub cboValueListItemID3_ProcessNewValue(sender As Object, e As ProcessNewValueEventArgs) Handles cboValueListItem3.ProcessNewValue
        If CStr(e.DisplayValue) <> String.Empty Then
            Dim sValueListItemID = DBQ.InsertNewValueListItem(cboValueListItem3, e.DisplayValue)
            If sValueListItemID <> "" Then
                Me.Vw_VALUELISTITEM_V2TableAdapter.Fill(Me.DM_VALUELISTITEM.vw_VALUELISTITEM_V2)
                cboValueListItem3.EditValue = System.Guid.Parse(sValueListItemID)
            End If
            e.Handled = True
        End If
    End Sub
    Private Sub cboValueListItemID9_ProcessNewValue(sender As Object, e As ProcessNewValueEventArgs) Handles cboValueListItem9.ProcessNewValue
        If CStr(e.DisplayValue) <> String.Empty Then
            Dim sValueListItemID = DBQ.InsertNewValueListItem(cboValueListItem9, e.DisplayValue)
            If sValueListItemID <> "" Then
                Me.Vw_VALUELISTITEM_V2TableAdapter.Fill(Me.DM_VALUELISTITEM.vw_VALUELISTITEM_V2)
                cboValueListItem9.EditValue = System.Guid.Parse(sValueListItemID)
            End If
            e.Handled = True
        End If
    End Sub
    Private Sub cboSides3_ProcessNewValue(sender As Object, e As ProcessNewValueEventArgs) Handles cboSides3.ProcessNewValue
        If CStr(e.DisplayValue) <> String.Empty Then
            Dim sValueListItemID = DBQ.InsertNewValueListItem(cboSides3, e.DisplayValue)
            If sValueListItemID <> "" Then
                Me.Vw_VALUELISTITEM_V2TableAdapter.Fill(Me.DM_VALUELISTITEM.vw_VALUELISTITEM_V2)
                cboSides3.EditValue = System.Guid.Parse(sValueListItemID)
            End If
            e.Handled = True
        End If
    End Sub
    Private Sub cboShelves3_ProcessNewValue(sender As Object, e As ProcessNewValueEventArgs) Handles cboShelves3.ProcessNewValue
        If CStr(e.DisplayValue) <> String.Empty Then
            Dim sValueListItemID = DBQ.InsertNewValueListItem(cboShelves3, e.DisplayValue)
            If sValueListItemID <> "" Then
                Me.Vw_VALUELISTITEM_V2TableAdapter.Fill(Me.DM_VALUELISTITEM.vw_VALUELISTITEM_V2)
                cboShelves3.EditValue = System.Guid.Parse(sValueListItemID)
            End If
            e.Handled = True
        End If
    End Sub

    Private Sub cboValueListItemID4_ProcessNewValue(sender As Object, e As ProcessNewValueEventArgs) Handles cboValueListItem4.ProcessNewValue
        If CStr(e.DisplayValue) <> String.Empty Then
            Dim sValueListItemID = DBQ.InsertNewValueListItem(cboValueListItem4, e.DisplayValue)
            If sValueListItemID <> "" Then
                Me.Vw_VALUELISTITEM_V2TableAdapter.Fill(Me.DM_VALUELISTITEM.vw_VALUELISTITEM_V2)
                cboValueListItem4.EditValue = System.Guid.Parse(sValueListItemID)
            End If
            e.Handled = True
        End If
    End Sub
    Private Sub cboValueListItemID10_ProcessNewValue(sender As Object, e As ProcessNewValueEventArgs) Handles cboValueListItem10.ProcessNewValue
        If CStr(e.DisplayValue) <> String.Empty Then
            Dim sValueListItemID = DBQ.InsertNewValueListItem(cboValueListItem10, e.DisplayValue)
            If sValueListItemID <> "" Then
                Me.Vw_VALUELISTITEM_V2TableAdapter.Fill(Me.DM_VALUELISTITEM.vw_VALUELISTITEM_V2)
                cboValueListItem10.EditValue = System.Guid.Parse(sValueListItemID)
            End If
            e.Handled = True
        End If
    End Sub
    Private Sub cboSides4_ProcessNewValue(sender As Object, e As ProcessNewValueEventArgs) Handles cboSides4.ProcessNewValue
        If CStr(e.DisplayValue) <> String.Empty Then
            Dim sValueListItemID = DBQ.InsertNewValueListItem(cboSides4, e.DisplayValue)
            If sValueListItemID <> "" Then
                Me.Vw_VALUELISTITEM_V2TableAdapter.Fill(Me.DM_VALUELISTITEM.vw_VALUELISTITEM_V2)
                cboSides4.EditValue = System.Guid.Parse(sValueListItemID)
            End If
            e.Handled = True
        End If
    End Sub
    Private Sub cboShelves4_ProcessNewValue(sender As Object, e As ProcessNewValueEventArgs) Handles cboShelves4.ProcessNewValue
        If CStr(e.DisplayValue) <> String.Empty Then
            Dim sValueListItemID = DBQ.InsertNewValueListItem(cboShelves4, e.DisplayValue)
            If sValueListItemID <> "" Then
                Me.Vw_VALUELISTITEM_V2TableAdapter.Fill(Me.DM_VALUELISTITEM.vw_VALUELISTITEM_V2)
                cboShelves4.EditValue = System.Guid.Parse(sValueListItemID)
            End If
            e.Handled = True
        End If
    End Sub

    Private Sub cboValueListItemID5_ProcessNewValue(sender As Object, e As ProcessNewValueEventArgs) Handles cboValueListItem5.ProcessNewValue
        If CStr(e.DisplayValue) <> String.Empty Then
            Dim sValueListItemID = DBQ.InsertNewValueListItem(cboValueListItem5, e.DisplayValue)
            If sValueListItemID <> "" Then
                Me.Vw_VALUELISTITEM_V2TableAdapter.Fill(Me.DM_VALUELISTITEM.vw_VALUELISTITEM_V2)
                cboValueListItem5.EditValue = System.Guid.Parse(sValueListItemID)
            End If
            e.Handled = True
        End If
    End Sub
    Private Sub cboValueListItemID11_ProcessNewValue(sender As Object, e As ProcessNewValueEventArgs) Handles cboValueListItem11.ProcessNewValue
        If CStr(e.DisplayValue) <> String.Empty Then
            Dim sValueListItemID = DBQ.InsertNewValueListItem(cboValueListItem11, e.DisplayValue)
            If sValueListItemID <> "" Then
                Me.Vw_VALUELISTITEM_V2TableAdapter.Fill(Me.DM_VALUELISTITEM.vw_VALUELISTITEM_V2)
                cboValueListItem11.EditValue = System.Guid.Parse(sValueListItemID)
            End If
            e.Handled = True
        End If
    End Sub
    Private Sub cboSides5_ProcessNewValue(sender As Object, e As ProcessNewValueEventArgs) Handles cboSides5.ProcessNewValue
        If CStr(e.DisplayValue) <> String.Empty Then
            Dim sValueListItemID = DBQ.InsertNewValueListItem(cboSides5, e.DisplayValue)
            If sValueListItemID <> "" Then
                Me.Vw_VALUELISTITEM_V2TableAdapter.Fill(Me.DM_VALUELISTITEM.vw_VALUELISTITEM_V2)
                cboSides5.EditValue = System.Guid.Parse(sValueListItemID)
            End If
            e.Handled = True
        End If
    End Sub
    Private Sub cboShelves5_ProcessNewValue(sender As Object, e As ProcessNewValueEventArgs) Handles cboShelves5.ProcessNewValue
        If CStr(e.DisplayValue) <> String.Empty Then
            Dim sValueListItemID = DBQ.InsertNewValueListItem(cboShelves5, e.DisplayValue)
            If sValueListItemID <> "" Then
                Me.Vw_VALUELISTITEM_V2TableAdapter.Fill(Me.DM_VALUELISTITEM.vw_VALUELISTITEM_V2)
                cboShelves5.EditValue = System.Guid.Parse(sValueListItemID)
            End If
            e.Handled = True
        End If
    End Sub


    Private Sub cboValueListItemID6_ProcessNewValue(sender As Object, e As ProcessNewValueEventArgs) Handles cboValueListItem6.ProcessNewValue
        If CStr(e.DisplayValue) <> String.Empty Then
            Dim sValueListItemID = DBQ.InsertNewValueListItem(cboValueListItem6, e.DisplayValue)
            If sValueListItemID <> "" Then
                Me.Vw_VALUELISTITEM_V2TableAdapter.Fill(Me.DM_VALUELISTITEM.vw_VALUELISTITEM_V2)
                cboValueListItem6.EditValue = System.Guid.Parse(sValueListItemID)
            End If
            e.Handled = True
        End If
    End Sub
    Private Sub cboValueListItemID12_ProcessNewValue(sender As Object, e As ProcessNewValueEventArgs) Handles cboValueListItem12.ProcessNewValue
        If CStr(e.DisplayValue) <> String.Empty Then
            Dim sValueListItemID = DBQ.InsertNewValueListItem(cboValueListItem12, e.DisplayValue)
            If sValueListItemID <> "" Then
                Me.Vw_VALUELISTITEM_V2TableAdapter.Fill(Me.DM_VALUELISTITEM.vw_VALUELISTITEM_V2)
                cboValueListItem12.EditValue = System.Guid.Parse(sValueListItemID)
            End If
            e.Handled = True
        End If
    End Sub
    Private Sub cboSides6_ProcessNewValue(sender As Object, e As ProcessNewValueEventArgs) Handles cboSides6.ProcessNewValue
        If CStr(e.DisplayValue) <> String.Empty Then
            Dim sValueListItemID = DBQ.InsertNewValueListItem(cboSides6, e.DisplayValue)
            If sValueListItemID <> "" Then
                Me.Vw_VALUELISTITEM_V2TableAdapter.Fill(Me.DM_VALUELISTITEM.vw_VALUELISTITEM_V2)
                cboSides6.EditValue = System.Guid.Parse(sValueListItemID)
            End If
            e.Handled = True
        End If
    End Sub
    Private Sub cboShelves6_ProcessNewValue(sender As Object, e As ProcessNewValueEventArgs) Handles cboShelves6.ProcessNewValue
        If CStr(e.DisplayValue) <> String.Empty Then
            Dim sValueListItemID = DBQ.InsertNewValueListItem(cboShelves6, e.DisplayValue)
            If sValueListItemID <> "" Then
                Me.Vw_VALUELISTITEM_V2TableAdapter.Fill(Me.DM_VALUELISTITEM.vw_VALUELISTITEM_V2)
                cboShelves6.EditValue = System.Guid.Parse(sValueListItemID)
            End If
            e.Handled = True
        End If
    End Sub
    Private Sub chkVatVisible_CheckedChanged(sender As Object, e As EventArgs) Handles chkVatVisible.CheckedChanged
        Dim cmd As SqlCommand
        If chkVatVisible.Checked = True Then
            cmd = New SqlCommand("Update CCT_ORDERS_CLOSET set visibleVAT = 1 where ID = " & toSQLValueS(sID), CNDB) : cmd.ExecuteNonQuery()
        Else
            cmd = New SqlCommand("Update CCT_ORDERS_CLOSET set visibleVAT = 0 where ID = " & toSQLValueS(sID), CNDB) : cmd.ExecuteNonQuery()
        End If
    End Sub

    Private Sub cboBOXColors_ProcessNewValue(sender As Object, e As ProcessNewValueEventArgs) Handles cboBOXColors.ProcessNewValue
        If CStr(e.DisplayValue) <> String.Empty Then
            Dim sValueListItemID = DBQ.InsertNewValueListItem(cboBOXColors, e.DisplayValue)
            If sValueListItemID <> "" Then
                Me.Vw_VALUELISTITEM_V2TableAdapter.Fill(Me.DM_VALUELISTITEM.vw_VALUELISTITEM_V2)
                cboBOXColors.EditValue = System.Guid.Parse(sValueListItemID)
            End If
            e.Handled = True
        End If
    End Sub

    Private Sub cboBOXColors2_ProcessNewValue(sender As Object, e As ProcessNewValueEventArgs) Handles cboBOXColors2.ProcessNewValue
        If CStr(e.DisplayValue) <> String.Empty Then
            Dim sValueListItemID = DBQ.InsertNewValueListItem(cboBOXColors2, e.DisplayValue)
            If sValueListItemID <> "" Then
                Me.Vw_VALUELISTITEM_V2TableAdapter.Fill(Me.DM_VALUELISTITEM.vw_VALUELISTITEM_V2)
                cboBOXColors2.EditValue = System.Guid.Parse(sValueListItemID)
            End If
            e.Handled = True
        End If
    End Sub

    Private Sub cboBOXColors3_ProcessNewValue(sender As Object, e As ProcessNewValueEventArgs) Handles cboBOXColors3.ProcessNewValue
        If CStr(e.DisplayValue) <> String.Empty Then
            Dim sValueListItemID = DBQ.InsertNewValueListItem(cboBOXColors3, e.DisplayValue)
            If sValueListItemID <> "" Then
                Me.Vw_VALUELISTITEM_V2TableAdapter.Fill(Me.DM_VALUELISTITEM.vw_VALUELISTITEM_V2)
                cboBOXColors3.EditValue = System.Guid.Parse(sValueListItemID)
            End If
            e.Handled = True
        End If
    End Sub

    Private Sub cboBOXColors4_ProcessNewValue(sender As Object, e As ProcessNewValueEventArgs) Handles cboBOXColors4.ProcessNewValue
        If CStr(e.DisplayValue) <> String.Empty Then
            Dim sValueListItemID = DBQ.InsertNewValueListItem(cboBOXColors4, e.DisplayValue)
            If sValueListItemID <> "" Then
                Me.Vw_VALUELISTITEM_V2TableAdapter.Fill(Me.DM_VALUELISTITEM.vw_VALUELISTITEM_V2)
                cboBOXColors4.EditValue = System.Guid.Parse(sValueListItemID)
            End If
            e.Handled = True
        End If
    End Sub

    Private Sub cboBOXColors5_ProcessNewValue(sender As Object, e As ProcessNewValueEventArgs) Handles cboBOXColors5.ProcessNewValue
        If CStr(e.DisplayValue) <> String.Empty Then
            Dim sValueListItemID = DBQ.InsertNewValueListItem(cboBOXColors5, e.DisplayValue)
            If sValueListItemID <> "" Then
                Me.Vw_VALUELISTITEM_V2TableAdapter.Fill(Me.DM_VALUELISTITEM.vw_VALUELISTITEM_V2)
                cboBOXColors5.EditValue = System.Guid.Parse(sValueListItemID)
            End If
            e.Handled = True
        End If
    End Sub

    Private Sub cboBOXColors6_ProcessNewValue(sender As Object, e As ProcessNewValueEventArgs) Handles cboBOXColors6.ProcessNewValue
        If CStr(e.DisplayValue) <> String.Empty Then
            Dim sValueListItemID = DBQ.InsertNewValueListItem(cboBOXColors6, e.DisplayValue)
            If sValueListItemID <> "" Then
                Me.Vw_VALUELISTITEM_V2TableAdapter.Fill(Me.DM_VALUELISTITEM.vw_VALUELISTITEM_V2)
                cboBOXColors6.EditValue = System.Guid.Parse(sValueListItemID)
            End If
            e.Handled = True
        End If
    End Sub

    Private Sub cboModel11_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboModel11.ButtonClick
        Select Case e.Button.Index
            Case 1 : ManageCbo.ManageValueListItemChecked(cboModel11, FormMode.NewRecord, "AFDD6E1A-EBA3-4FE9-AB28-EDE277939F29")
            Case 2 : ManageCbo.ManageValueListItemChecked(cboModel11, FormMode.EditRecord)
            Case 3 : cboModel11.SetEditValue(-1)
        End Select
    End Sub

    Private Sub cboModel21_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboModel21.ButtonClick
        Select Case e.Button.Index
            Case 1 : ManageCbo.ManageValueListItemChecked(cboModel21, FormMode.NewRecord, "AFDD6E1A-EBA3-4FE9-AB28-EDE277939F29")
            Case 2 : ManageCbo.ManageValueListItemChecked(cboModel21, FormMode.EditRecord)
            Case 3 : cboModel21.SetEditValue(-1)
        End Select
    End Sub

    Private Sub cboModel31_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboModel31.ButtonClick
        Select Case e.Button.Index
            Case 1 : ManageCbo.ManageValueListItemChecked(cboModel31, FormMode.NewRecord, "AFDD6E1A-EBA3-4FE9-AB28-EDE277939F29")
            Case 2 : ManageCbo.ManageValueListItemChecked(cboModel31, FormMode.EditRecord)
            Case 3 : cboModel31.SetEditValue(-1)
        End Select
    End Sub

    Private Sub cboModel41_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboModel41.ButtonClick
        Select Case e.Button.Index
            Case 1 : ManageCbo.ManageValueListItemChecked(cboModel41, FormMode.NewRecord, "AFDD6E1A-EBA3-4FE9-AB28-EDE277939F29")
            Case 2 : ManageCbo.ManageValueListItemChecked(cboModel41, FormMode.EditRecord)
            Case 3 : cboModel41.SetEditValue(-1)
        End Select
    End Sub

    Private Sub cboModel51_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboModel51.ButtonClick
        Select Case e.Button.Index
            Case 1 : ManageCbo.ManageValueListItemChecked(cboModel51, FormMode.NewRecord, "AFDD6E1A-EBA3-4FE9-AB28-EDE277939F29")
            Case 2 : ManageCbo.ManageValueListItemChecked(cboModel51, FormMode.EditRecord)
            Case 3 : cboModel51.SetEditValue(-1)
        End Select
    End Sub


    Private Sub cmdSavePhotos_Click(sender As Object, e As EventArgs) Handles cmdSavePhotos.Click
        CusOfferOrderCloset.SavePhotoRecord(sID, FormMode.NewRecord)
    End Sub


    Private Sub CardView1_ValidateRow(sender As Object, e As ValidateRowEventArgs) Handles CardView1.ValidateRow
        CusOfferOrderCloset.SavePhotoRecord(sID, FormMode.EditRecord)
    End Sub

    Private Sub CardView1_KeyDown(sender As Object, e As KeyEventArgs) Handles CardView1.KeyDown
        If e.KeyCode = Keys.Delete And UserProps.AllowDelete = True Then DeleteRecord()
    End Sub
    Private Sub DeleteRecord()
        CusOfferOrderCloset.DeletePhotoRecord()
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
        If e.MenuType = GridMenuType.Column Then LoadForms.PopupMenuShow(e, GridView3, "vw_TRANSH_F_CLOSET_def.xml", "vw_TRANSH_F")
    End Sub

    Private Sub TabPane1_SelectedPageChanged(sender As Object, e As SelectedPageChangedEventArgs) Handles TabPane1.SelectedPageChanged
        Select Case TabPane1.SelectedPageIndex
            Case 3
                LoadForms.RestoreLayoutFromXml(GridView3, "vw_TRANSH_F_CLOSET_def.xml")
                TRANSH_FTableAdapter.FillByTanshID(DM_TRANS.TRANSH_F, System.Guid.Parse(cboTRANSH.EditValue.ToString))
        End Select
    End Sub
    Private Sub cboCompany_EditValueChanged(sender As Object, e As EventArgs) Handles cboCompany.EditValueChanged
        Dim sCompID As String
        If cboCompany.EditValue Is Nothing Then sCompID = toSQLValueS(Guid.Empty.ToString) Else sCompID = toSQLValueS(cboCompany.EditValue.ToString)
        Dim sSQL As New System.Text.StringBuilder
        sSQL.AppendLine("Select T.id,FullTranshDescription,Description,Iskitchen,Iscloset,Isdoor,Issc
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
        Frm.lCusD.Visibility = False
        Frm.ShowDialog()

    End Sub

    Private Sub FillCusTransh()
        Dim sCusID As String, scompTrashID As String
        If cboCUS.EditValue Is Nothing Then sCusID = toSQLValueS(Guid.Empty.ToString) Else sCusID = toSQLValueS(cboCUS.EditValue.ToString)
        If cboCompProject.EditValue Is Nothing Then scompTrashID = toSQLValueS(Guid.Empty.ToString) Else scompTrashID = toSQLValueS(cboCompProject.EditValue.ToString)
        Dim sSQL As New System.Text.StringBuilder
        sSQL.AppendLine("Select T.id,FullTranshDescription,Description,Iskitchen,Iscloset,Isdoor,Issc
                        from vw_TRANSH t
                        INNER JOIN TRANSC on transc.transhID = t.id and TRANSC.transhcID = '3DAF9172-E9C4-402D-9BE7-4A3F64ABDAE4' 
                        where   completed = 0  and T.cusid = " & sCusID & " and T.compTrashID = " & scompTrashID & " order by description")
        FillCbo.TRANSH(cboTRANSH, sSQL)
    End Sub

    Private Sub cboCompProject_EditValueChanged(sender As Object, e As EventArgs) Handles cboCompProject.EditValueChanged
        FillCusTransh()
    End Sub
End Class