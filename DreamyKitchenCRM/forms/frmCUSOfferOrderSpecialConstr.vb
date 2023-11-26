Imports System.Data.SqlClient
Imports DevExpress.Utils
Imports DevExpress.Utils.Menu
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Menu
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraLayout
Imports DevExpress.XtraReports.UI

Public Class frmCUSOfferOrderSpecialConstr
    Private sID As String
    Private ManageCbo As New CombosManager
    Private Ctrl As DevExpress.XtraGrid.Views.Grid.GridView
    Private Frm As DevExpress.XtraEditors.XtraForm
    Public Mode As Byte
    Private sIsOrder As Boolean
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
    Private Sub frmCUSOfferSpecialConstr_Load(sender As Object, e As EventArgs) Handles Me.Load
        'TODO: This line of code loads data into the 'DreamyKitchenDataSet.vw_CCT' table. You can move, or remove it, as needed.
        Me.Vw_CCTTableAdapter.Fill(Me.DreamyKitchenDataSet.vw_CCT)
        'TODO: This line of code loads data into the 'DM_DOORTYPES.vw_DOOR_TYPE_V2' table. You can move, or remove it, as needed.
        Me.Vw_DOOR_TYPE_V2TableAdapter.Fill(Me.DM_DOORTYPES.vw_DOOR_TYPE_V2)
        'TODO: This line of code loads data into the 'DMDataSet.CCT_TRANSH' table. You can move, or remove it, as needed.
        Me.CCT_TRANSHTableAdapter.Fill(Me.DMDataSet.CCT_TRANSH)
        'TODO: This line of code loads data into the 'DM_DOORTYPES1.vw_DOOR_TYPESpecialConstr' table. You can move, or remove it, as needed.
        Me.Vw_DOOR_TYPESpecialConstrTableAdapter.Fill(Me.DM_DOORTYPES.vw_DOOR_TYPESpecialConstr)
        'TODO: This line of code loads data into the 'DM_DOORTYPES1.vw_DOOR_TYPESpecialConstr' table. You can move, or remove it, as needed.
        Me.Vw_CONSTR_TYPETableAdapter.Fill(Me.DMDataSet.vw_CONSTR_TYPE)
        'TODO: This line of code loads data into the 'DreamyKitchenDataSet.vw_SALERS' table. You can move, or remove it, as needed.
        Me.Vw_SALERSTableAdapter.Fill(Me.DreamyKitchenDataSet.vw_SALERS)
        Prog_Prop.GetProgPROSF()


        If sIsOrder = True Then
            LayoutControlGroup2.Text = "Στοιχεία Παραγγελίας"
            LayoutControlGroup1.Text = "Στοιχεία Παραγγελίας"
            LayoutControlItem12.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
            LayoutControlItem15.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
            LayoutControlItem16.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
            LayoutControlItem50.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
            LayoutControlItem57.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
            LayoutControlItem72.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
            LayoutControlItem30.Text = "Ημερ/νία Παραγγελίας"
        Else
            LayoutControlGroup1.Text = "Στοιχεία Προσφοράς"
            LayoutControlGroup2.Text = "Στοιχεία Προσφοράς"
            LayoutControlItem30.Text = "Ημερ/νία Προσφοράς"
            LayoutControlItem4.Text = "Αρ. Προσφοράς"
            LayoutControlItem11.Tag = 0
        End If
        Select Case Mode
            Case FormMode.NewRecord
                txtarProt.Text = DBQ.GetNextId("CCT_ORDERS_SPECIAL_CONSTR")
                cboEMP.EditValue = System.Guid.Parse(UserProps.ID.ToString.ToUpper)
                txtdtdaysOfDelivery.EditValue = ProgProps.DAYS_OF_DELIVERY
                txtnotes.EditValue = ProgProps.CUS_NOTES
                txtTransp.EditValue = ProgProps.SCTransp
                txtMeasurement.EditValue = ProgProps.SCMeasurement
                txtRemove.EditValue = ProgProps.SCRemove
                'cmdConvertToOrder.Enabled = False
                LayoutControlItem7.Visibility = Utils.LayoutVisibility.Never
            Case FormMode.EditRecord
                Dim sFields As New Dictionary(Of String, String)
                LoadForms.LoadForm(LayoutControl1, "Select [ORDER].id as OrderID,CCT_ORDERS_SPECIAL_CONSTR.* " &
                                                   " from CCT_ORDERS_SPECIAL_CONSTR " &
                                                   " left join CCT_ORDERS_SPECIAL_CONSTR  [ORDER] on [ORDER].CreatedFromOfferID =  CCT_ORDERS_SPECIAL_CONSTR.id " &
                                                   " where CCT_ORDERS_SPECIAL_CONSTR.id = " & toSQLValueS(sID), sFields)
                If sIsOrder = False Then
                    If sFields("OrderID") <> "" Then
                        'cmdConvertToOrder.Enabled = False
                        LayoutControlItem7.Visibility = Utils.LayoutVisibility.Never
                        cmdSave.Enabled = False
                        LabelControl1.Text = "Δεν μπορείτε να κάνετε αλλαγές στην προσφορά γιατί έχει δημιουργηθεί παραγγελία."
                    End If
                Else
                    LayoutControlItem7.Visibility = Utils.LayoutVisibility.Never
                    'cmdConvertToOrder.Enabled = False
                End If
        End Select
        Me.CenterToScreen()
        'cmdSave.Enabled = IIf(Mode = FormMode.NewRecord, UserProps.AllowInsert, UserProps.AllowEdit)
    End Sub
    Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click
        Dim sResult As Boolean
        Dim sGuid As String
        Try
            If Valid.ValidateForm(LayoutControl1) Then
                Select Case Mode
                    Case FormMode.NewRecord
                        sGuid = System.Guid.NewGuid.ToString
                        Dim sDate As String = lblDate.Text.Replace("Ημερομηνία Παράδοσης: ", "")
                        sResult = DBQ.InsertNewData(DBQueries.InsertMode.OneLayoutControl, "CCT_ORDERS_SPECIAL_CONSTR", LayoutControl1,,, sGuid, , "dtDeliver,IsOrder", toSQLValueS(CDate(sDate).ToString("yyyyMMdd")) & "," & IIf(sIsOrder = True, 1, 0))
                        sID = sGuid
                    Case FormMode.EditRecord
                        Dim sDate As String = lblDate.Text.Replace("Ημερομηνία Παράδοσης: ", "")
                        sResult = DBQ.UpdateNewData(DBQueries.InsertMode.OneLayoutControl, "CCT_ORDERS_SPECIAL_CONSTR", LayoutControl1,,, sID, ,,,, "dtDeliver=" & toSQLValueS(CDate(sDate).ToString("yyyyMMdd")) & ",IsOrder = " & IIf(sIsOrder = True, 1, 0))
                        'sGuid = sID
                End Select

                If FScrollerExist = True Then
                    Dim form As frmScroller = Frm
                    form.LoadRecords("CCT_ORDERS_SPECIAL_CONSTR")
                End If

                If sResult = True Then
                    XtraMessageBox.Show("Η εγγραφή αποθηκέυτηκε με επιτυχία", Company, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    If Mode = FormMode.NewRecord Then Mode = FormMode.EditRecord
                    If sIsOrder Then
                        Dim HasKitchen As Boolean, HasCloset As Boolean, HasDoors As Boolean, HasSc As Boolean
                        HasKitchen = cboTRANSH.GetColumnValue("Iskitchen")
                        HasCloset = cboTRANSH.GetColumnValue("Iscloset")
                        HasDoors = cboTRANSH.GetColumnValue("Isdoors")
                        HasSc = cboTRANSH.GetColumnValue("Issc")
                        If HasKitchen = False And HasCloset = False And HasDoors = False And HasSc = False Then
                            XtraMessageBox.Show("Κοστολόγηση δεν θα δημιουργηθεί λόγω έλλειψης συμφωνητικού", Company, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                            Exit Sub
                        End If
                        Dim cmd As SqlCommand
                        Dim sdr As SqlDataReader
                        Dim sSQL As String
                        Dim cctOrderKitchen As String = "00000000-0000-0000-0000-000000000000"

                        sSQL = "select ID from CCT_ORDERS_KITCHEN where transhID = " & (toSQLValueS(cboTRANSH.EditValue.ToString))
                        cmd = New SqlCommand(sSQL, CNDB)
                        sdr = cmd.ExecuteReader()
                        If (sdr.Read() = True) Then
                            If sdr.IsDBNull(sdr.GetOrdinal("ID")) = False Then cctOrderKitchen = sdr.GetGuid(sdr.GetOrdinal("ID")).ToString
                        End If
                        sdr.Close()
                        cmd.Dispose()
                    End If

                    '    Cls.ClearCtrls(LayoutControl1)
                    '    txtCode.Text = DBQ.GetNextId("CCT_OFFERS_SPECIAL_CONSTR")
                End If
            End If

        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), Company, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
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

    Private Sub txtInitialPrice1_EditValueChanged(sender As Object, e As EventArgs) Handles txtInitialPrice1.EditValueChanged
        Dim Disc As Double, Discount As Double, InitialPrice As Double, FinalPrice As Double
        txtDisc1.EditValue = ProgProps.CusDiscountSpecial
        ' If ProgProps.CusDiscountSpecial > 0 Then
        InitialPrice = txtInitialPrice1.EditValue
        Disc = ProgProps.CusDiscountSpecial / 100
        Discount = Disc * InitialPrice
        FinalPrice = InitialPrice - Discount
        txtInitialPrice1.EditValue = InitialPrice
        txtDiscount1.EditValue = Discount
        txtFinalPrice1.EditValue = FinalPrice
        'End If
    End Sub

    Private Sub txtInitialPrice2_EditValueChanged(sender As Object, e As EventArgs) Handles txtInitialPrice2.EditValueChanged
        Dim Disc As Double, Discount As Double, InitialPrice As Double, FinalPrice As Double
        txtDisc2.EditValue = ProgProps.CusDiscountSpecial
        '   If ProgProps.CusDiscountSpecial > 0 Then
        InitialPrice = txtInitialPrice2.EditValue
        Disc = ProgProps.CusDiscountSpecial / 100
        Discount = Disc * InitialPrice
        FinalPrice = InitialPrice - Discount
        txtInitialPrice2.EditValue = InitialPrice
        txtDiscount2.EditValue = Discount
        txtFinalPrice2.EditValue = FinalPrice
        '  End If

    End Sub

    Private Sub txtInitialPrice3_EditValueChanged(sender As Object, e As EventArgs) Handles txtInitialPrice3.EditValueChanged
        Dim Disc As Double, Discount As Double, InitialPrice As Double, FinalPrice As Double
        txtDisc3.EditValue = ProgProps.CusDiscountSpecial
        ' If ProgProps.CusDiscountSpecial > 0 Then
        InitialPrice = txtInitialPrice3.EditValue
        Disc = ProgProps.CusDiscountSpecial / 100
        Discount = Disc * InitialPrice
        FinalPrice = InitialPrice - Discount
        txtInitialPrice3.EditValue = InitialPrice
        txtDiscount3.EditValue = Discount
        txtFinalPrice3.EditValue = FinalPrice
        '  End If
    End Sub

    Private Sub txtInitialPrice4_EditValueChanged(sender As Object, e As EventArgs) Handles txtInitialPrice4.EditValueChanged
        Dim Disc As Double, Discount As Double, InitialPrice As Double, FinalPrice As Double
        txtDisc4.EditValue = ProgProps.CusDiscountSpecial
        '  If ProgProps.CusDiscountSpecial > 0 Then
        InitialPrice = txtInitialPrice4.EditValue
        Disc = ProgProps.CusDiscountSpecial / 100
        Discount = Disc * InitialPrice
        FinalPrice = InitialPrice - Discount
        txtInitialPrice4.EditValue = InitialPrice
        txtDiscount4.EditValue = Discount
        txtFinalPrice4.EditValue = FinalPrice
        ' End If
    End Sub

    Private Sub cboCUS_EditValueChanged(sender As Object, e As EventArgs) Handles cboCUS.EditValueChanged
        'txtPhn.EditValue = cboCUS.GetColumnValue("phn")
        'txtArea.EditValue = cboCUS.GetColumnValue("AREAS_Name")
        'txtADR.EditValue = cboCUS.GetColumnValue("ADR_Name")
        Dim sCusID As String
        If cboCUS.EditValue Is Nothing Then sCusID = toSQLValueS(Guid.Empty.ToString) Else sCusID = toSQLValueS(cboCUS.EditValue.ToString)
        Dim sSQL As New System.Text.StringBuilder
        sSQL.AppendLine("Select T.id,FullTranshDescription,Description,Iskitchen,Iscloset,Isdoors,Issc
                        from vw_TRANSH t
                        where completed = 0 and  T.cusid = " & sCusID & "order by description")
        FillCbo.TRANSH(cboTRANSH, sSQL)
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

    Private Function TotalPrice() As Double
        Dim Price1 As Double, Price2 As Double, Price3 As Double, Price4 As Double
        Dim Total As Double
        Price1 = DbnullToZero(txtFinalPrice1)
        Price2 = DbnullToZero(txtFinalPrice2)
        Price3 = DbnullToZero(txtFinalPrice3)
        Price4 = DbnullToZero(txtFinalPrice4)
        Total = Price1 + Price2 + Price3 + Price4
        Return Total
    End Function

    Private Sub cmdPrintOffer_Click(sender As Object, e As EventArgs) Handles cmdPrintOffer.Click
        If sIsOrder = False Then
            Dim report As New RepCUSOfferSpecialContr()
            report.Parameters.Item(0).Value = sID
            report.CreateDocument()
            Dim printTool As New ReportPrintTool(report)
            printTool.ShowRibbonPreview()
        Else
            Dim report As New RepCUSOrderSpecialConstr
            report.Parameters.Item(0).Value = sID
            report.CreateDocument()
            Dim printTool As New ReportPrintTool(report)
            printTool.ShowRibbonPreview()
        End If
    End Sub
    Private Sub frmCUSOfferSpecialConstr_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        If Me.WindowState = FormWindowState.Maximized Then frmMain.XtraTabbedMdiManager1.Dock(Me, frmMain.XtraTabbedMdiManager1)
    End Sub

    Private Sub txtTotalSpecialVat_EditValueChanged(sender As Object, e As EventArgs) Handles txtTotalSpecialVat.EditValueChanged
        Dim TotalSpecialPrice As Double
        TotalSpecialPrice = (txtTotalSpecialVat.EditValue * (ProgProps.VAT / 100)) + txtTotalSpecialVat.EditValue
        txtTotalSpecialPrice.EditValue = TotalSpecialPrice
    End Sub

    Private Sub cboTRANSH_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboTRANSH.ButtonClick
        Select Case e.Button.Index
            Case 1 : ManageCbo.ManageTRANSH(cboTRANSH, FormMode.NewRecord)
            Case 2 : ManageCbo.ManageTRANSH(cboTRANSH, FormMode.EditRecord)
            Case 3 : cboTRANSH.EditValue = Nothing
        End Select
    End Sub


    Private Sub txtFinalPrice4_EditValueChanged(sender As Object, e As EventArgs) Handles txtFinalPrice4.EditValueChanged
        txtTotalSpecialVat.EditValue = TotalPrice()
    End Sub

    Private Sub txtFinalPrice1_EditValueChanged(sender As Object, e As EventArgs) Handles txtFinalPrice1.EditValueChanged
        txtTotalSpecialVat.EditValue = TotalPrice()
    End Sub

    Private Sub txtFinalPrice2_EditValueChanged(sender As Object, e As EventArgs) Handles txtFinalPrice2.EditValueChanged
        txtTotalSpecialVat.EditValue = TotalPrice()
    End Sub

    Private Sub txtFinalPrice3_EditValueChanged(sender As Object, e As EventArgs) Handles txtFinalPrice3.EditValueChanged
        txtTotalSpecialVat.EditValue = TotalPrice()
        Dim Price As Double
        Price = DbnullToZero(txtTotalSpecialVat)
        txtTotalSpecialPrice.EditValue = Price * (ProgProps.VAT / 100) + Price
    End Sub

    Private Sub cboDoorType_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboDoorType.ButtonClick
        Select Case e.Button.Index
            Case 1 : ManageCbo.ManageDoorType(cboDoorType, FormMode.NewRecord, "CF47FAEE-7CD7-49AD-9455-3BC69D438DE9")
            Case 2 : ManageCbo.ManageDoorType(cboDoorType, FormMode.EditRecord, "CF47FAEE-7CD7-49AD-9455-3BC69D438DE9")
            Case 3 : cboDoorType.EditValue = Nothing
        End Select
    End Sub
    Private Sub cboDoorType2_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboDoorType2.ButtonClick
        Select Case e.Button.Index
            Case 1 : ManageCbo.ManageDoorType(cboDoorType2, FormMode.NewRecord, "CF47FAEE-7CD7-49AD-9455-3BC69D438DE9")
            Case 2 : ManageCbo.ManageDoorType(cboDoorType2, FormMode.EditRecord, "CF47FAEE-7CD7-49AD-9455-3BC69D438DE9")
            Case 3 : cboDoorType2.EditValue = Nothing
        End Select
    End Sub
    Private Sub cboDoorType3_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboDoorType3.ButtonClick
        Select Case e.Button.Index
            Case 1 : ManageCbo.ManageDoorType(cboDoorType3, FormMode.NewRecord, "CF47FAEE-7CD7-49AD-9455-3BC69D438DE9")
            Case 2 : ManageCbo.ManageDoorType(cboDoorType3, FormMode.EditRecord, "CF47FAEE-7CD7-49AD-9455-3BC69D438DE9")
            Case 3 : cboDoorType3.EditValue = Nothing
        End Select
    End Sub
    Private Sub cboDoorType4_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboDoorType4.ButtonClick
        Select Case e.Button.Index
            Case 1 : ManageCbo.ManageDoorType(cboDoorType4, FormMode.NewRecord, "CF47FAEE-7CD7-49AD-9455-3BC69D438DE9")
            Case 2 : ManageCbo.ManageDoorType(cboDoorType4, FormMode.EditRecord, "CF47FAEE-7CD7-49AD-9455-3BC69D438DE9")
            Case 3 : cboDoorType4.EditValue = Nothing
        End Select
    End Sub

    Private Sub cboScpecialConstr1_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboScpecialConstr1.ButtonClick
        Select Case e.Button.Index
            Case 1 : ManageCbo.ManageSpecialConstr(cboScpecialConstr1, FormMode.NewRecord)
            Case 2 : ManageCbo.ManageSpecialConstr(cboScpecialConstr1, FormMode.EditRecord)
            Case 3 : cboScpecialConstr1.EditValue = Nothing
        End Select
    End Sub


    Private Sub cboScpecialConstr2_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboScpecialConstr2.ButtonClick
        Select Case e.Button.Index
            Case 1 : ManageCbo.ManageSpecialConstr(cboScpecialConstr2, FormMode.NewRecord)
            Case 2 : ManageCbo.ManageSpecialConstr(cboScpecialConstr2, FormMode.EditRecord)
            Case 3 : cboScpecialConstr2.EditValue = Nothing
        End Select
    End Sub

    Private Sub cboScpecialConstr3_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboScpecialConstr3.ButtonClick
        Select Case e.Button.Index
            Case 1 : ManageCbo.ManageSpecialConstr(cboScpecialConstr3, FormMode.NewRecord)
            Case 2 : ManageCbo.ManageSpecialConstr(cboScpecialConstr3, FormMode.EditRecord)
            Case 3 : cboScpecialConstr3.EditValue = Nothing
        End Select
    End Sub

    Private Sub cboScpecialConstr4_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboScpecialConstr4.ButtonClick
        Select Case e.Button.Index
            Case 1 : ManageCbo.ManageSpecialConstr(cboScpecialConstr4, FormMode.NewRecord)
            Case 2 : ManageCbo.ManageSpecialConstr(cboScpecialConstr4, FormMode.EditRecord)
            Case 3 : cboScpecialConstr4.EditValue = Nothing
        End Select
    End Sub

    Private Sub cmdConvertToOrder_Click(sender As Object, e As EventArgs) Handles cmdConvertToOrder.Click
        Try
            If XtraMessageBox.Show("Θέλετε να μετατραπεί σε παραγγελία η προσφορά ?", Company, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                Using oCmd As New SqlCommand("ConvertToOrder", CNDB)
                    oCmd.CommandType = CommandType.StoredProcedure
                    oCmd.Parameters.AddWithValue("@OfferID", sID)
                    oCmd.Parameters.AddWithValue("@createdBy", UserProps.ID)
                    oCmd.Parameters.AddWithValue("@Mode", 4)
                    oCmd.ExecuteNonQuery()
                End Using
                XtraMessageBox.Show("Η μετατροπή ολοκληρώθηκε με επιτυχία", Company, MessageBoxButtons.OK, MessageBoxIcon.Information)
                'cmdConvertToOrder.Enabled = False
                cmdSave.Enabled = False
                LayoutControlItem7.Visibility = Utils.LayoutVisibility.Always
                LabelControl1.Text = "Δεν μπορείτε να κάνετε αλλαγές στην προσφορά γιατί έχει δημιουργηθεί παραγγελία."
            End If
        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), Company, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub cboDoorType_ProcessNewValue(sender As Object, e As ProcessNewValueEventArgs) Handles cboDoorType.ProcessNewValue
        If CStr(e.DisplayValue) <> String.Empty Then
            Dim sDoorTypeID = DBQ.InsertNewDoorType(cboDoorType, e.DisplayValue)
            If sDoorTypeID <> "" Then
                Me.Vw_DOOR_TYPE_V2TableAdapter.Fill(Me.DM_DOORTYPES.vw_DOOR_TYPE_V2)
                cboDoorType.EditValue = System.Guid.Parse(sDoorTypeID)
            End If
            e.Handled = True
        End If
    End Sub

    Private Sub cboDoorType2_ProcessNewValue(sender As Object, e As ProcessNewValueEventArgs) Handles cboDoorType2.ProcessNewValue
        If CStr(e.DisplayValue) <> String.Empty Then
            Dim sDoorTypeID = DBQ.InsertNewDoorType(cboDoorType, e.DisplayValue)
            If sDoorTypeID <> "" Then
                Me.Vw_DOOR_TYPE_V2TableAdapter.Fill(Me.DM_DOORTYPES.vw_DOOR_TYPE_V2)
                cboDoorType2.EditValue = System.Guid.Parse(sDoorTypeID)
            End If
            e.Handled = True
        End If
    End Sub
    Private Sub cboDoorType3_ProcessNewValue(sender As Object, e As ProcessNewValueEventArgs) Handles cboDoorType3.ProcessNewValue
        If CStr(e.DisplayValue) <> String.Empty Then
            Dim sDoorTypeID = DBQ.InsertNewDoorType(cboDoorType, e.DisplayValue)
            If sDoorTypeID <> "" Then
                Me.Vw_DOOR_TYPE_V2TableAdapter.Fill(Me.DM_DOORTYPES.vw_DOOR_TYPE_V2)
                cboDoorType3.EditValue = System.Guid.Parse(sDoorTypeID)
            End If
            e.Handled = True
        End If
    End Sub
    Private Sub cboDoorType4_ProcessNewValue(sender As Object, e As ProcessNewValueEventArgs) Handles cboDoorType4.ProcessNewValue
        If CStr(e.DisplayValue) <> String.Empty Then
            Dim sDoorTypeID = DBQ.InsertNewDoorType(cboDoorType, e.DisplayValue)
            If sDoorTypeID <> "" Then
                Me.Vw_DOOR_TYPE_V2TableAdapter.Fill(Me.DM_DOORTYPES.vw_DOOR_TYPE_V2)
                cboDoorType4.EditValue = System.Guid.Parse(sDoorTypeID)
            End If
            e.Handled = True
        End If
    End Sub
    Private Sub chkVatVisible_CheckedChanged(sender As Object, e As EventArgs) Handles chkVatVisible.CheckedChanged
        Dim cmd As SqlCommand
        If chkVatVisible.Checked = True Then
            cmd = New SqlCommand("Update CCT_ORDERS_SPECIAL_CONSTR set visibleVAT = 1 where ID = " & toSQLValueS(sID), CNDB) : cmd.ExecuteNonQuery()
        Else
            cmd = New SqlCommand("Update CCT_ORDERS_SPECIAL_CONSTR set visibleVAT = 0 where ID = " & toSQLValueS(sID), CNDB) : cmd.ExecuteNonQuery()
        End If
    End Sub
End Class