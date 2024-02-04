Imports System.Data.SqlClient
Imports DevExpress.XtraBars.Navigation
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraExport.Helpers
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid

Public Class frmCUSOfferOrderDoors
    Private CusOfferOrderDoors As New CusOfferOrderDoors
    Private ManageCbo As New CombosManager
    Private sID As String
    Private sIsOrder As Boolean
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

    Private Sub frmCUSOfferDoors_Load(sender As Object, e As EventArgs) Handles Me.Load
        'TODO: This line of code loads data into the 'DM_CCT.vw_COMP' table. You can move, or remove it, as needed.
        Me.Vw_COMPTableAdapter.Fill(Me.DM_CCT.vw_COMP)
        CusOfferOrderDoors.Initialize(Me, sID, Mode, CalledFromCtrl, CtrlCombo, sIsOrder)
        CusOfferOrderDoors.LoadForm()
        Me.CenterToScreen()
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

    Private Sub cboCUS_EditValueChanged(sender As Object, e As EventArgs) Handles cboCUS.EditValueChanged
        FillCusTransh()
    End Sub

    Private Sub txtdtdaysOfDelivery_EditValueChanged(sender As Object, e As EventArgs) Handles txtdtdaysOfDelivery.EditValueChanged
        If dtpresentation.EditValue Is Nothing Then Exit Sub
        If dtpresentation.EditValue.ToString = "" Then Exit Sub
        Dim FirstDate As Date = dtpresentation.EditValue
        lblDate.Text = "Ημερομηνία Παράδοσης: " & DateAdd("d", CDbl(txtdtdaysOfDelivery.EditValue.ToString), FirstDate).ToString("dd/MM/yyyy")
    End Sub

    Private Sub dtpresentation_EditValueChanged(sender As Object, e As EventArgs) Handles dtpresentation.EditValueChanged
        If dtpresentation.EditValue Is Nothing Or txtdtdaysOfDelivery.EditValue Is Nothing Then Exit Sub
        If dtpresentation.EditValue.ToString = "" Then Exit Sub
        Dim FirstDate As Date = dtpresentation.EditValue
        If txtdtdaysOfDelivery.EditValue Is Nothing Then txtdtdaysOfDelivery.EditValue = 0
        lblDate.Text = "Ημερομηνία Παράδοσης: " & DateAdd("d", CDbl(txtdtdaysOfDelivery.EditValue.ToString), FirstDate).ToString("dd/MM/yyyy")
    End Sub
    Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click
        CusOfferOrderDoors.SaveRecord(sID)
    End Sub

    Private Sub ApplyDiscount(ByVal DiscMode As Integer, Optional ByVal DiscountChangedByUser As Boolean = False)
        Dim Disc As Double, Discount As Double, InitialPrice As Double, FinalPrice As Double
        If Me.IsActive = False Then Exit Sub
        Select Case DiscMode
            Case 1
                If DiscountChangedByUser = False Then txtDisc1.EditValue = ProgProps.CusDiscountDoors
                InitialPrice = txtInitialPrice1.EditValue
                If DiscountChangedByUser = False Then Disc = ProgProps.CusDiscountDoors / 100 Else Disc = txtDisc1.EditValue / 100
                Discount = Disc * InitialPrice
                FinalPrice = InitialPrice - Discount
                txtInitialPrice1.EditValue = InitialPrice
                txtDiscount1.EditValue = Discount
                txtFinalPrice1.EditValue = FinalPrice
            Case 2
                If DiscountChangedByUser = False Then txtDisc2.EditValue = ProgProps.CusDiscountDoors
                InitialPrice = txtInitialPrice2.EditValue
                If DiscountChangedByUser = False Then Disc = ProgProps.CusDiscountDoors / 100 Else Disc = txtDisc2.EditValue / 100
                Discount = Disc * InitialPrice
                FinalPrice = InitialPrice - Discount
                txtInitialPrice2.EditValue = InitialPrice
                txtDiscount2.EditValue = Discount
                txtFinalPrice2.EditValue = FinalPrice
            Case 3
                If DiscountChangedByUser = False Then txtDisc3.EditValue = ProgProps.CusDiscountDoors
                InitialPrice = txtInitialPrice3.EditValue
                If DiscountChangedByUser = False Then Disc = ProgProps.CusDiscountDoors / 100 Else Disc = txtDisc3.EditValue / 100
                Discount = Disc * InitialPrice
                FinalPrice = InitialPrice - Discount
                txtInitialPrice3.EditValue = InitialPrice
                txtDiscount3.EditValue = Discount
                txtFinalPrice3.EditValue = FinalPrice
            Case 4
                If DiscountChangedByUser = False Then txtDisc4.EditValue = ProgProps.CusDiscountDoors
                InitialPrice = txtInitialPrice4.EditValue
                If DiscountChangedByUser = False Then Disc = ProgProps.CusDiscountDoors / 100 Else Disc = txtDisc4.EditValue / 100
                Discount = Disc * InitialPrice
                FinalPrice = InitialPrice - Discount
                txtInitialPrice4.EditValue = InitialPrice
                txtDiscount4.EditValue = Discount
                txtFinalPrice4.EditValue = FinalPrice
            Case 5
                If DiscountChangedByUser = False Then txtDisc5.EditValue = ProgProps.CusDiscountDoors
                InitialPrice = txtInitialPrice5.EditValue
                If DiscountChangedByUser = False Then Disc = ProgProps.CusDiscountDoors / 100 Else Disc = txtDisc5.EditValue / 100
                Discount = Disc * InitialPrice
                FinalPrice = InitialPrice - Discount
                txtInitialPrice5.EditValue = InitialPrice
                txtDiscount5.EditValue = Discount
                txtFinalPrice5.EditValue = FinalPrice
            Case 6
                If DiscountChangedByUser = False Then txtDisc6.EditValue = ProgProps.CusDiscountDoors
                InitialPrice = txtInitialPrice6.EditValue
                If DiscountChangedByUser = False Then Disc = ProgProps.CusDiscountDoors / 100 Else Disc = txtDisc6.EditValue / 100
                Discount = Disc * InitialPrice
                FinalPrice = InitialPrice - Discount
                txtInitialPrice6.EditValue = InitialPrice
                txtDiscount6.EditValue = Discount
                txtFinalPrice6.EditValue = FinalPrice
            Case 7
                If DiscountChangedByUser = False Then txtDisc7.EditValue = ProgProps.CusDiscountDoors
                InitialPrice = txtInitialPrice7.EditValue
                If DiscountChangedByUser = False Then Disc = ProgProps.CusDiscountDoors / 100 Else Disc = txtDisc7.EditValue / 100
                Discount = Disc * InitialPrice
                FinalPrice = InitialPrice - Discount
                txtInitialPrice7.EditValue = InitialPrice
                txtDiscount7.EditValue = Discount
                txtFinalPrice7.EditValue = FinalPrice
            Case 8
                If DiscountChangedByUser = False Then txtDisc8.EditValue = ProgProps.CusDiscountDoors
                InitialPrice = txtInitialPrice8.EditValue
                If DiscountChangedByUser = False Then Disc = ProgProps.CusDiscountDoors / 100 Else Disc = txtDisc8.EditValue / 100
                Discount = Disc * InitialPrice
                FinalPrice = InitialPrice - Discount
                txtInitialPrice8.EditValue = InitialPrice
                txtDiscount8.EditValue = Discount
                txtFinalPrice8.EditValue = FinalPrice
            Case 9
                If DiscountChangedByUser = False Then txtDisc9.EditValue = ProgProps.CusDiscountDoors
                InitialPrice = txtInitialPrice9.EditValue
                If DiscountChangedByUser = False Then Disc = ProgProps.CusDiscountDoors / 100 Else Disc = txtDisc9.EditValue / 100
                Discount = Disc * InitialPrice
                FinalPrice = InitialPrice - Discount
                txtInitialPrice9.EditValue = InitialPrice
                txtDiscount9.EditValue = Discount
                txtFinalPrice9.EditValue = FinalPrice
            Case 10
                If DiscountChangedByUser = False Then txtDisc10.EditValue = ProgProps.CusDiscountDoors
                InitialPrice = txtInitialPrice10.EditValue
                If DiscountChangedByUser = False Then Disc = ProgProps.CusDiscountDoors / 100 Else Disc = txtDisc10.EditValue / 100
                Discount = Disc * InitialPrice
                FinalPrice = InitialPrice - Discount
                txtInitialPrice10.EditValue = InitialPrice
                txtDiscount10.EditValue = Discount
                txtFinalPrice10.EditValue = FinalPrice
        End Select
    End Sub
    Private Sub cmdPrintOffer_Click(sender As Object, e As EventArgs) Handles cmdPrintOffer.Click
        CusOfferOrderDoors.PrintOfferOrder()
    End Sub

    Private Sub frmCUSOfferDoors_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        If Me.WindowState = FormWindowState.Maximized Then frmMain.XtraTabbedMdiManager1.Dock(Me, frmMain.XtraTabbedMdiManager1)
    End Sub


    Private Sub cboFora1_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboFora1.ButtonClick
        Select Case e.Button.Index
            Case 1 : cboFora1.EditValue = Nothing
        End Select
    End Sub

    Private Sub cboFora2_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboFora2.ButtonClick
        Select Case e.Button.Index
            Case 1 : cboFora2.EditValue = Nothing
        End Select
    End Sub

    Private Sub cboFora3_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboFora3.ButtonClick
        Select Case e.Button.Index
            Case 1 : cboFora3.EditValue = Nothing
        End Select
    End Sub

    Private Sub cboFora4_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboFora4.ButtonClick
        Select Case e.Button.Index
            Case 1 : cboFora4.EditValue = Nothing
        End Select
    End Sub

    Private Sub cboFora5_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboFora5.ButtonClick
        Select Case e.Button.Index
            Case 1 : cboFora5.EditValue = Nothing
        End Select
    End Sub

    Private Sub cboFora6_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboFora6.ButtonClick
        Select Case e.Button.Index
            Case 1 : cboFora6.EditValue = Nothing
        End Select
    End Sub
    Private Sub cboFora7_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboFora7.ButtonClick
        Select Case e.Button.Index
            Case 1 : cboFora7.EditValue = Nothing
        End Select
    End Sub
    Private Sub cboFora8_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboFora8.ButtonClick
        Select Case e.Button.Index
            Case 1 : cboFora8.EditValue = Nothing
        End Select
    End Sub
    Private Sub cboFora9_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboFora9.ButtonClick
        Select Case e.Button.Index
            Case 1 : cboFora9.EditValue = Nothing
        End Select
    End Sub
    Private Sub cboFora10_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboFora10.ButtonClick
        Select Case e.Button.Index
            Case 1 : cboFora10.EditValue = Nothing
        End Select
    End Sub
    Private Sub cboKasa1_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboKasa1.ButtonClick
        Select Case e.Button.Index
            Case 1 : cboKasa1.EditValue = Nothing
        End Select
    End Sub

    Private Sub cboKasa2_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboKasa2.ButtonClick
        Select Case e.Button.Index
            Case 1 : cboKasa2.EditValue = Nothing
        End Select
    End Sub

    Private Sub cboKasa3_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboKasa3.ButtonClick
        Select Case e.Button.Index
            Case 1 : cboKasa3.EditValue = Nothing
        End Select
    End Sub

    Private Sub cboKasa4_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboKasa4.ButtonClick
        Select Case e.Button.Index
            Case 1 : cboKasa4.EditValue = Nothing
        End Select
    End Sub

    Private Sub cboKasa5_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboKasa5.ButtonClick
        Select Case e.Button.Index
            Case 1 : cboKasa5.EditValue = Nothing
        End Select
    End Sub

    Private Sub cboKasa6_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboKasa6.ButtonClick
        Select Case e.Button.Index
            Case 1 : cboKasa6.EditValue = Nothing
        End Select
    End Sub
    Private Sub cboKasa7_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboKasa7.ButtonClick
        Select Case e.Button.Index
            Case 1 : cboKasa7.EditValue = Nothing
        End Select
    End Sub
    Private Sub cboKasa8_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboKasa8.ButtonClick
        Select Case e.Button.Index
            Case 1 : cboKasa8.EditValue = Nothing
        End Select
    End Sub
    Private Sub cboKasa9_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboKasa9.ButtonClick
        Select Case e.Button.Index
            Case 1 : cboKasa9.EditValue = Nothing
        End Select
    End Sub
    Private Sub cboKasa10_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboKasa10.ButtonClick
        Select Case e.Button.Index
            Case 1 : cboKasa10.EditValue = Nothing
        End Select
    End Sub

    Private Sub cboType1_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboType1.ButtonClick
        Select Case e.Button.Index
            Case 1 : cboType1.EditValue = Nothing
        End Select
    End Sub

    Private Sub cboType2_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboType2.ButtonClick
        Select Case e.Button.Index
            Case 1 : cboType2.EditValue = Nothing
        End Select
    End Sub

    Private Sub cboType3_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboType3.ButtonClick
        Select Case e.Button.Index
            Case 1 : cboType3.EditValue = Nothing
        End Select
    End Sub

    Private Sub cboType4_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboType4.ButtonClick
        Select Case e.Button.Index
            Case 1 : cboType4.EditValue = Nothing
        End Select
    End Sub

    Private Sub cboType5_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboType5.ButtonClick
        Select Case e.Button.Index
            Case 1 : cboType5.EditValue = Nothing
        End Select
    End Sub

    Private Sub cboType6_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboType6.ButtonClick
        Select Case e.Button.Index
            Case 1 : cboType6.EditValue = Nothing
        End Select
    End Sub
    Private Sub cboType7_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboType7.ButtonClick
        Select Case e.Button.Index
            Case 1 : cboType7.EditValue = Nothing
        End Select
    End Sub
    Private Sub cboType8_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboType8.ButtonClick
        Select Case e.Button.Index
            Case 1 : cboType8.EditValue = Nothing
        End Select
    End Sub
    Private Sub cboType9_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboType9.ButtonClick
        Select Case e.Button.Index
            Case 1 : cboType9.EditValue = Nothing
        End Select
    End Sub
    Private Sub cboType10_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboType10.ButtonClick
        Select Case e.Button.Index
            Case 1 : cboType10.EditValue = Nothing
        End Select
    End Sub
    Private Sub cboVALUELISTITEM_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboValueListItem.ButtonClick
        Select Case e.Button.Index
            Case 1 : ManageCbo.ManageValueListItem(cboValueListItem, FormMode.NewRecord, "DE86FD16-2154-4E2A-B025-4D34BDF8C808")
            Case 2 : ManageCbo.ManageValueListItem(cboValueListItem, FormMode.EditRecord)
            Case 3 : cboValueListItem.EditValue = Nothing
        End Select
    End Sub
    Private Sub cboVALUELISTITEM2_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboVALUELISTITEM2.ButtonClick
        Select Case e.Button.Index
            Case 1 : ManageCbo.ManageValueListItem(cboVALUELISTITEM2, FormMode.NewRecord, "DE86FD16-2154-4E2A-B025-4D34BDF8C808")
            Case 2 : ManageCbo.ManageValueListItem(cboVALUELISTITEM2, FormMode.EditRecord)
            Case 3 : cboVALUELISTITEM2.EditValue = Nothing
        End Select
    End Sub
    Private Sub cboVALUELISTITEM3_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboVALUELISTITEM3.ButtonClick
        Select Case e.Button.Index
            Case 1 : ManageCbo.ManageValueListItem(cboVALUELISTITEM3, FormMode.NewRecord, "DE86FD16-2154-4E2A-B025-4D34BDF8C808")
            Case 2 : ManageCbo.ManageValueListItem(cboVALUELISTITEM3, FormMode.EditRecord)
            Case 3 : cboVALUELISTITEM3.EditValue = Nothing
        End Select
    End Sub
    Private Sub cboVALUELISTITEM4_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboVALUELISTITEM4.ButtonClick
        Select Case e.Button.Index
            Case 1 : ManageCbo.ManageValueListItem(cboVALUELISTITEM4, FormMode.NewRecord, "DE86FD16-2154-4E2A-B025-4D34BDF8C808")
            Case 2 : ManageCbo.ManageValueListItem(cboVALUELISTITEM4, FormMode.EditRecord)
            Case 3 : cboVALUELISTITEM4.EditValue = Nothing
        End Select
    End Sub
    Private Sub cboVALUELISTITEM5_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboVALUELISTITEM5.ButtonClick
        Select Case e.Button.Index
            Case 1 : ManageCbo.ManageValueListItem(cboVALUELISTITEM5, FormMode.NewRecord, "DE86FD16-2154-4E2A-B025-4D34BDF8C808")
            Case 2 : ManageCbo.ManageValueListItem(cboVALUELISTITEM5, FormMode.EditRecord)
            Case 3 : cboVALUELISTITEM5.EditValue = Nothing
        End Select
    End Sub
    Private Sub cboVALUELISTITEM6_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboValueListItem.ButtonClick
        Select Case e.Button.Index
            Case 1 : ManageCbo.ManageValueListItem(cboVALUELISTITEM6, FormMode.NewRecord, "DE86FD16-2154-4E2A-B025-4D34BDF8C808")
            Case 2 : ManageCbo.ManageValueListItem(cboVALUELISTITEM6, FormMode.EditRecord)
            Case 3 : cboVALUELISTITEM6.EditValue = Nothing
        End Select
    End Sub
    Private Sub cboVALUELISTITEM7_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboVALUELISTITEM7.ButtonClick
        Select Case e.Button.Index
            Case 1 : ManageCbo.ManageValueListItem(cboVALUELISTITEM7, FormMode.NewRecord, "DE86FD16-2154-4E2A-B025-4D34BDF8C808")
            Case 2 : ManageCbo.ManageValueListItem(cboVALUELISTITEM7, FormMode.EditRecord)
            Case 3 : cboVALUELISTITEM7.EditValue = Nothing
        End Select
    End Sub
    Private Sub cboVALUELISTITEM8_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboVALUELISTITEM8.ButtonClick
        Select Case e.Button.Index
            Case 1 : ManageCbo.ManageValueListItem(cboVALUELISTITEM8, FormMode.NewRecord, "DE86FD16-2154-4E2A-B025-4D34BDF8C808")
            Case 2 : ManageCbo.ManageValueListItem(cboVALUELISTITEM8, FormMode.EditRecord)
            Case 3 : cboVALUELISTITEM8.EditValue = Nothing
        End Select
    End Sub
    Private Sub cboVALUELISTITEM9_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboVALUELISTITEM9.ButtonClick
        Select Case e.Button.Index
            Case 1 : ManageCbo.ManageValueListItem(cboVALUELISTITEM9, FormMode.NewRecord, "DE86FD16-2154-4E2A-B025-4D34BDF8C808")
            Case 2 : ManageCbo.ManageValueListItem(cboVALUELISTITEM9, FormMode.EditRecord)
            Case 3 : cboVALUELISTITEM9.EditValue = Nothing
        End Select
    End Sub
    Private Sub cboVALUELISTITEM10_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboVALUELISTITEM10.ButtonClick
        Select Case e.Button.Index
            Case 1 : ManageCbo.ManageValueListItem(cboVALUELISTITEM10, FormMode.NewRecord, "DE86FD16-2154-4E2A-B025-4D34BDF8C808")
            Case 2 : ManageCbo.ManageValueListItem(cboVALUELISTITEM10, FormMode.EditRecord)
            Case 3 : cboVALUELISTITEM10.EditValue = Nothing
        End Select
    End Sub
    Private Sub cboTRANSH_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboTRANSH.ButtonClick
        Select Case e.Button.Index
            Case 1 : ManageCbo.ManageTRANSHSmall(cboTRANSH, FormMode.NewRecord, cboCUS.EditValue)
            Case 2 : ManageCbo.ManageTRANSHSmall(cboTRANSH, FormMode.EditRecord, cboCUS.EditValue)
            Case 3 : cboTRANSH.EditValue = Nothing
        End Select
    End Sub

    Private Sub cmdConvertToOrder_Click(sender As Object, e As EventArgs) Handles cmdConvertToOrder.Click
        CusOfferOrderDoors.ConvertToOrder()
    End Sub
    Private Sub cboVALUELISTITEM_ProcessNewValue(sender As Object, e As ProcessNewValueEventArgs) Handles cboValueListItem.ProcessNewValue
        If CStr(e.DisplayValue) <> String.Empty Then
            Dim sVALUELISTITEMID = DBQ.InsertNewValueListItem(cboValueListItem, e.DisplayValue)
            If sVALUELISTITEMID <> "" Then
                Me.Vw_VALUELISTITEM_V2TableAdapter.Fill(Me.DM_VALUELISTITEM.vw_VALUELISTITEM_V2)
                cboValueListItem.EditValue = System.Guid.Parse(sVALUELISTITEMID)
            End If
            e.Handled = True
        End If
    End Sub

    Private Sub cboVALUELISTITEM2_ProcessNewValue(sender As Object, e As ProcessNewValueEventArgs) Handles cboVALUELISTITEM2.ProcessNewValue
        If CStr(e.DisplayValue) <> String.Empty Then
            Dim sVALUELISTITEMID = DBQ.InsertNewValueListItem(cboVALUELISTITEM2, e.DisplayValue)
            If sVALUELISTITEMID <> "" Then
                Me.Vw_VALUELISTITEM_V2TableAdapter.Fill(Me.DM_VALUELISTITEM.vw_VALUELISTITEM_V2)
                cboVALUELISTITEM2.EditValue = System.Guid.Parse(sVALUELISTITEMID)
            End If
            e.Handled = True
        End If
    End Sub
    Private Sub cboVALUELISTITEM3_ProcessNewValue(sender As Object, e As ProcessNewValueEventArgs) Handles cboVALUELISTITEM3.ProcessNewValue
        If CStr(e.DisplayValue) <> String.Empty Then
            Dim sVALUELISTITEMID = DBQ.InsertNewValueListItem(cboVALUELISTITEM3, e.DisplayValue)
            If sVALUELISTITEMID <> "" Then
                Me.Vw_VALUELISTITEM_V2TableAdapter.Fill(Me.DM_VALUELISTITEM.vw_VALUELISTITEM_V2)
                cboVALUELISTITEM3.EditValue = System.Guid.Parse(sVALUELISTITEMID)
            End If
            e.Handled = True
        End If
    End Sub
    Private Sub cboVALUELISTITEM4_ProcessNewValue(sender As Object, e As ProcessNewValueEventArgs) Handles cboVALUELISTITEM4.ProcessNewValue
        If CStr(e.DisplayValue) <> String.Empty Then
            Dim sVALUELISTITEMID = DBQ.InsertNewValueListItem(cboVALUELISTITEM4, e.DisplayValue)
            If sVALUELISTITEMID <> "" Then
                Me.Vw_VALUELISTITEM_V2TableAdapter.Fill(Me.DM_VALUELISTITEM.vw_VALUELISTITEM_V2)
                cboVALUELISTITEM4.EditValue = System.Guid.Parse(sVALUELISTITEMID)
            End If
            e.Handled = True
        End If
    End Sub
    Private Sub cboVALUELISTITEM5_ProcessNewValue(sender As Object, e As ProcessNewValueEventArgs) Handles cboVALUELISTITEM5.ProcessNewValue
        If CStr(e.DisplayValue) <> String.Empty Then
            Dim sVALUELISTITEMID = DBQ.InsertNewValueListItem(cboVALUELISTITEM5, e.DisplayValue)
            If sVALUELISTITEMID <> "" Then
                Me.Vw_VALUELISTITEM_V2TableAdapter.Fill(Me.DM_VALUELISTITEM.vw_VALUELISTITEM_V2)
                cboVALUELISTITEM5.EditValue = System.Guid.Parse(sVALUELISTITEMID)
            End If
            e.Handled = True
        End If
    End Sub
    Private Sub cboVALUELISTITEM6_ProcessNewValue(sender As Object, e As ProcessNewValueEventArgs) Handles cboVALUELISTITEM6.ProcessNewValue
        If CStr(e.DisplayValue) <> String.Empty Then
            Dim sVALUELISTITEMID = DBQ.InsertNewValueListItem(cboVALUELISTITEM6, e.DisplayValue)
            If sVALUELISTITEMID <> "" Then
                Me.Vw_VALUELISTITEM_V2TableAdapter.Fill(Me.DM_VALUELISTITEM.vw_VALUELISTITEM_V2)
                cboVALUELISTITEM6.EditValue = System.Guid.Parse(sVALUELISTITEMID)
            End If
            e.Handled = True
        End If
    End Sub
    Private Sub chkVatVisible_CheckedChanged(sender As Object, e As EventArgs) Handles chkVatVisible.CheckedChanged
        Dim cmd As SqlCommand
        If chkVatVisible.Checked = True Then
            cmd = New SqlCommand("Update CCT_ORDERS_DOOR set visibleVAT = 1 where ID = " & toSQLValueS(sID), CNDB) : cmd.ExecuteNonQuery()
        Else
            cmd = New SqlCommand("Update CCT_ORDERS_DOOR set visibleVAT = 0 where ID = " & toSQLValueS(sID), CNDB) : cmd.ExecuteNonQuery()
        End If
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
    Private Sub txtInitialPrice6_EditValueChanged(sender As Object, e As EventArgs) Handles txtInitialPrice6.EditValueChanged
        ApplyDiscount(6)
    End Sub
    Private Sub txtInitialPrice7_EditValueChanged(sender As Object, e As EventArgs) Handles txtInitialPrice7.EditValueChanged
        ApplyDiscount(7)
    End Sub
    Private Sub txtInitialPrice8_EditValueChanged(sender As Object, e As EventArgs) Handles txtInitialPrice8.EditValueChanged
        ApplyDiscount(8)
    End Sub
    Private Sub txtInitialPrice9_EditValueChanged(sender As Object, e As EventArgs) Handles txtInitialPrice9.EditValueChanged
        ApplyDiscount(9)
    End Sub
    Private Sub txtInitialPrice10_EditValueChanged(sender As Object, e As EventArgs) Handles txtInitialPrice10.EditValueChanged
        ApplyDiscount(10)
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

    Private Sub txtDisc6_EditValueChanged(sender As Object, e As EventArgs) Handles txtDisc6.EditValueChanged
        ApplyDiscount(6, True)
    End Sub

    Private Sub txtDisc7_EditValueChanged(sender As Object, e As EventArgs) Handles txtDisc7.EditValueChanged
        ApplyDiscount(7, True)
    End Sub

    Private Sub txtDisc8_EditValueChanged(sender As Object, e As EventArgs) Handles txtDisc8.EditValueChanged
        ApplyDiscount(8, True)
    End Sub

    Private Sub txtDisc9_EditValueChanged(sender As Object, e As EventArgs) Handles txtDisc9.EditValueChanged
        ApplyDiscount(9, True)
    End Sub

    Private Sub txtDisc10_EditValueChanged(sender As Object, e As EventArgs) Handles txtDisc10.EditValueChanged
        ApplyDiscount(10, True)
    End Sub

    Private Sub cmdSavePhotos_Click(sender As Object, e As EventArgs) Handles cmdSavePhotos.Click
        CusOfferOrderDoors.SavePhotoRecord(sID, FormMode.NewRecord)
    End Sub


    Private Sub CardView1_ValidateRow(sender As Object, e As ValidateRowEventArgs) Handles CardView1.ValidateRow
        CusOfferOrderDoors.SavePhotoRecord(sID, FormMode.EditRecord)
    End Sub

    Private Sub CardView1_KeyDown(sender As Object, e As KeyEventArgs) Handles CardView1.KeyDown
        If e.KeyCode = Keys.Delete And UserProps.AllowDelete = True Then DeleteRecord()
    End Sub
    Private Sub DeleteRecord()
        CusOfferOrderDoors.DeletePhotoRecord()
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
        If e.MenuType = GridMenuType.Column Then LoadForms.PopupMenuShow(e, GridView3, "vw_TRANSH_F_DOORS_def.xml", "vw_TRANSH_F")
    End Sub
    Private Sub TabPane1_SelectedPageChanged(sender As Object, e As SelectedPageChangedEventArgs) Handles TabPane1.SelectedPageChanged
        Select Case TabPane1.SelectedPageIndex
            Case 2
                LoadForms.RestoreLayoutFromXml(GridView3, "vw_TRANSH_F_DOORS_def.xml")
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
        If cboCompProject.EditValue Is Nothing Then scompTrashID = "IS NULL" Else scompTrashID = " = " & toSQLValueS(cboCompProject.EditValue.ToString)
        Dim sSQL As New System.Text.StringBuilder
        sSQL.AppendLine("Select T.id,FullTranshDescription,Description,Iskitchen,Iscloset,Isdoor,Issc
                        from vw_TRANSH t
                        INNER JOIN TRANSC on transc.transhID = t.id and TRANSC.transhcID = '47618E49-33E8-4685-969F-55419EDFAC58' 
                        where   completed = 0  and T.cusid = " & sCusID & " and T.compTrashID  " & scompTrashID & " order by description")
        FillCbo.TRANSH(cboTRANSH, sSQL)
    End Sub

    Private Sub cboCompProject_EditValueChanged(sender As Object, e As EventArgs) Handles cboCompProject.EditValueChanged
        FillCusTransh()
    End Sub
End Class