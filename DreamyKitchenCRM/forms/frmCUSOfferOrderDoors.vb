Imports System.Data.SqlClient
Imports DevExpress.Utils
Imports DevExpress.Utils.Menu
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Menu
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraReports.UI

Public Class frmCUSOfferOrderDoors
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
        'TODO: This line of code loads data into the 'DM_TRANS.CCT_TRANSH' table. You can move, or remove it, as needed.
        Me.CCT_TRANSHTableAdapter.Fill(Me.DM_TRANS.CCT_TRANSH)
        'TODO: This line of code loads data into the 'DreamyKitchenDataSet.vw_CCT' table. You can move, or remove it, as needed.
        Me.Vw_CCTTableAdapter.Fill(Me.DreamyKitchenDataSet.vw_CCT)
        'TODO: This line of code loads data into the 'DM_VALUELISTITEM.vw_VALUELISTITEM_V2' table. You can move, or remove it, as needed.
        Me.Vw_VALUELISTITEM_V2TableAdapter.Fill(Me.DM_VALUELISTITEM.vw_VALUELISTITEM_V2)
        'TODO: This line of code loads data into the 'DMDataSet.CCT_TRANSH' table. You can move, or remove it, as needed.
        Me.CCT_TRANSHTableAdapter.Fill(Me.DM_TRANS.CCT_TRANSH)
        'TODO: This line of code loads data into the 'DreamyKitchenDataSet.vw_COLORSDOORS' table. You can move, or remove it, as needed.
        Me.Vw_COLORSDOORSTableAdapter.Fill(Me.DreamyKitchenDataSet.vw_COLORSDOORS)
        'TODO: This line of code loads data into the 'DreamyKitchenDataSet.vw_SALERS' table. You can move, or remove it, as needed.
        Me.Vw_SALERSTableAdapter.Fill(Me.DreamyKitchenDataSet.vw_SALERS)
        Prog_Prop.GetProgPROSF()

        If sIsOrder = True Then
            ' LayoutControlItem41.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
            LayoutControlItem53.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
            LayoutControlItem54.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
            LayoutControlItem55.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
            LayoutControlItem69.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
            LayoutControlItem70.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
            LayoutControlItem72.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
            LayoutControlGroup1.Text = "Στοιχεία Παραγγελίας"
            LayoutControlGroup4.Text = "Στοιχεία Παραγγελίας"
            LayoutControlItem30.Text = "Ημερ/νία Παραγγελίας"
        Else
            LayoutControlItem41.Tag = 0
            LayoutControlItem4.Text = "Αρ. Προσφοράς"
            LayoutControlGroup1.Text = "Στοιχεία Προσφοράς"
            LayoutControlGroup4.Text = "Στοιχεία Προσφοράς"
            LayoutControlItem30.Text = "Ημερ/νία Προσφοράς"
        End If
        Select Case Mode
            Case FormMode.NewRecord
                txtarProt.Text = DBQ.GetNextId("CCT_ORDERS_DOOR")
                cboEMP.EditValue = System.Guid.Parse(UserProps.ID.ToString.ToUpper)
                txtdtdaysOfDelivery.EditValue = ProgProps.DAYS_OF_DELIVERY
                txtDescription.EditValue = ProgProps.DOOR_DESCRIPTION
                txtComments.EditValue = ProgProps.DOOR_CMT
                txtNotes.EditValue = ProgProps.CUS_NOTES
                txtTransp.EditValue = ProgProps.DoorTransp
                txtMeasurement.EditValue = ProgProps.DoorMeasurement
                txtRemove.EditValue = ProgProps.DoorRemove
                'cmdConvertToOrder.Enabled = False
                LayoutControlItem7.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
            Case FormMode.EditRecord
                Dim sFields As New Dictionary(Of String, String)
                LoadForms.LoadForm(LayoutControl1, "Select [ORDER].id as OrderID,CCT_ORDERS_DOOR.* " &
                                                   " from CCT_ORDERS_DOOR " &
                                                   " left join CCT_ORDERS_DOOR  [ORDER] on [ORDER].CreatedFromOfferID =  CCT_ORDERS_DOOR.id " &
                                                   " where CCT_ORDERS_DOOR.id = " & toSQLValueS(sID), sFields)
                If sIsOrder = False Then
                    If sFields("OrderID") <> "" Then
                        'cmdConvertToOrder.Enabled = False
                        LayoutControlItem7.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
                        cmdSave.Enabled = False
                        LabelControl1.Text = "Δεν μπορείτε να κάνετε αλλαγές στην προσφορά γιατί έχει δημιουργηθεί παραγγελία."
                    End If
                Else
                    'cmdConvertToOrder.Enabled = False
                    LayoutControlItem7.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
                End If


                sFields = Nothing

        End Select
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
        If dtpresentation.EditValue Is Nothing Or txtdtdaysOfDelivery.EditValue Is Nothing Then Exit Sub
        If dtpresentation.EditValue.ToString = "" Then Exit Sub
        Dim FirstDate As Date = dtpresentation.EditValue
        If txtdtdaysOfDelivery.EditValue Is Nothing Then txtdtdaysOfDelivery.EditValue = 0
        lblDate.Text = "Ημερομηνία Παράδοσης: " & DateAdd("d", CDbl(txtdtdaysOfDelivery.EditValue.ToString), FirstDate).ToString("dd/MM/yyyy")
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
                        sResult = DBQ.InsertNewData(DBQueries.InsertMode.OneLayoutControl, "CCT_ORDERS_DOOR", LayoutControl1,,, sGuid, , "dtDeliver,IsOrder", toSQLValueS(CDate(sDate).ToString("yyyyMMdd")) & "," & IIf(sIsOrder = True, 1, 0))
                        sID = sGuid
                    Case FormMode.EditRecord
                        Dim sDate As String = lblDate.Text.Replace("Ημερομηνία Παράδοσης: ", "")
                        sResult = DBQ.UpdateNewData(DBQueries.InsertMode.OneLayoutControl, "CCT_ORDERS_DOOR", LayoutControl1,,, sID, ,,,, "dtDeliver=" & toSQLValueS(CDate(sDate).ToString("yyyyMMdd")) & ",IsOrder = " & IIf(sIsOrder = True, 1, 0))
                        'sGuid = sID
                End Select

                If FScrollerExist = True Then
                    Dim form As frmScroller = Frm
                    form.LoadRecords("vw_CCT_ORDERS_DOOR")
                End If

                If sResult = True Then
                    XtraMessageBox.Show("Η εγγραφή αποθηκέυτηκε με επιτυχία", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    If Mode = FormMode.NewRecord Then
                        Mode = FormMode.EditRecord
                        'cmdConvertToOrder.Enabled = True
                        LayoutControlItem7.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
                    End If
                    If sIsOrder Then
                        Dim HasKitchen As Boolean, HasCloset As Boolean, HasDoors As Boolean, HasSc As Boolean
                        HasKitchen = cboTRANSH.GetColumnValue("Iskitchen")
                        HasCloset = cboTRANSH.GetColumnValue("Iscloset")
                        HasDoors = cboTRANSH.GetColumnValue("Isdoors")
                        HasSc = cboTRANSH.GetColumnValue("Issc")
                        If HasKitchen = False And HasCloset = False And HasDoors = False And HasSc = False Then
                            XtraMessageBox.Show("Κοστολόγηση δεν θα δημιουργηθεί λόγω έλλειψης συμφωνητικού", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning)
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
                        ' Δημιουργία/Ενημέρωση Κοστολόγησης
                        Using oCmd As New SqlCommand("usp_InsertOrUpdateTransCost", CNDB)
                            oCmd.CommandType = CommandType.StoredProcedure
                            oCmd.Parameters.AddWithValue("@transhID", cboTRANSH.EditValue.ToString)
                            oCmd.Parameters.AddWithValue("@cctOrderKitchenID", System.Guid.Parse(cctOrderKitchen))
                            oCmd.Parameters.AddWithValue("@Mode", 3)
                            oCmd.Parameters.AddWithValue("@UserID", UserProps.ID.ToString)
                            oCmd.ExecuteNonQuery()
                        End Using
                    End If
                End If
            End If

        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ApplyDiscount(ByVal DiscMode As Integer, Optional ByVal DiscountChangedByUser As Boolean = False)
        Dim Disc As Double, Discount As Double, InitialPrice As Double, FinalPrice As Double
        If Me.IsActive = False Then Exit Sub
        Select Case DiscMode
            Case 1
                If DiscountChangedByUser = False Then txtDisc1.EditValue = ProgProps.CusDiscountDoors
                If ProgProps.CusDiscountDoors > 0 Then
                    InitialPrice = txtInitialPrice1.EditValue
                    If DiscountChangedByUser = False Then Disc = ProgProps.CusDiscountDoors / 100 Else Disc = txtDisc1.EditValue / 100
                    Discount = Disc * InitialPrice
                    FinalPrice = InitialPrice - Discount
                    txtInitialPrice1.EditValue = InitialPrice
                    txtDiscount1.EditValue = Discount
                    txtFinalPrice1.EditValue = FinalPrice
                End If
            Case 2
                If DiscountChangedByUser = False Then txtDisc2.EditValue = ProgProps.CusDiscountCloset
                If ProgProps.CusDiscountDoors > 0 Then
                    InitialPrice = txtInitialPrice2.EditValue
                    If DiscountChangedByUser = False Then Disc = ProgProps.CusDiscountDoors / 100 Else Disc = txtDisc2.EditValue / 100
                    Discount = Disc * InitialPrice
                    FinalPrice = InitialPrice - Discount
                    txtInitialPrice2.EditValue = InitialPrice
                    txtDiscount2.EditValue = Discount
                    txtFinalPrice2.EditValue = FinalPrice
                End If
            Case 3
                If DiscountChangedByUser = False Then txtDisc3.EditValue = ProgProps.CusDiscountCloset
                If ProgProps.CusDiscountDoors > 0 Then
                    InitialPrice = txtInitialPrice3.EditValue
                    If DiscountChangedByUser = False Then Disc = ProgProps.CusDiscountDoors / 100 Else Disc = txtDisc3.EditValue / 100
                    Discount = Disc * InitialPrice
                    FinalPrice = InitialPrice - Discount
                    txtInitialPrice3.EditValue = InitialPrice
                    txtDiscount3.EditValue = Discount
                    txtFinalPrice3.EditValue = FinalPrice
                End If
            Case 4
                If DiscountChangedByUser = False Then txtDisc4.EditValue = ProgProps.CusDiscountCloset
                If ProgProps.CusDiscountDoors > 0 Then
                    InitialPrice = txtInitialPrice4.EditValue
                    If DiscountChangedByUser = False Then Disc = ProgProps.CusDiscountDoors / 100 Else Disc = txtDisc4.EditValue / 100
                    Discount = Disc * InitialPrice
                    FinalPrice = InitialPrice - Discount
                    txtInitialPrice4.EditValue = InitialPrice
                    txtDiscount4.EditValue = Discount
                    txtFinalPrice4.EditValue = FinalPrice
                End If
            Case 5
                If DiscountChangedByUser = False Then txtDisc5.EditValue = ProgProps.CusDiscountCloset
                If ProgProps.CusDiscountDoors > 0 Then
                    InitialPrice = txtInitialPrice5.EditValue
                    If DiscountChangedByUser = False Then Disc = ProgProps.CusDiscountDoors / 100 Else Disc = txtDisc5.EditValue / 100
                    Discount = Disc * InitialPrice
                    FinalPrice = InitialPrice - Discount
                    txtInitialPrice5.EditValue = InitialPrice
                    txtDiscount5.EditValue = Discount
                    txtFinalPrice5.EditValue = FinalPrice
                End If
            Case 6
                If DiscountChangedByUser = False Then txtDisc6.EditValue = ProgProps.CusDiscountDoors
                If ProgProps.CusDiscountDoors > 0 Then
                    InitialPrice = txtInitialPrice6.EditValue
                    If DiscountChangedByUser = False Then Disc = ProgProps.CusDiscountDoors / 100 Else Disc = txtDisc6.EditValue / 100
                    Discount = Disc * InitialPrice
                    FinalPrice = InitialPrice - Discount
                    txtInitialPrice6.EditValue = InitialPrice
                    txtDiscount6.EditValue = Discount
                    txtFinalPrice6.EditValue = FinalPrice
                End If
            Case 7
                If DiscountChangedByUser = False Then txtDisc7.EditValue = ProgProps.CusDiscountCloset
                If ProgProps.CusDiscountDoors > 0 Then
                    InitialPrice = txtInitialPrice7.EditValue
                    If DiscountChangedByUser = False Then Disc = ProgProps.CusDiscountDoors / 100 Else Disc = txtDisc7.EditValue / 100
                    Discount = Disc * InitialPrice
                    FinalPrice = InitialPrice - Discount
                    txtInitialPrice7.EditValue = InitialPrice
                    txtDiscount7.EditValue = Discount
                    txtFinalPrice7.EditValue = FinalPrice
                End If
            Case 8
                If DiscountChangedByUser = False Then txtDisc8.EditValue = ProgProps.CusDiscountCloset
                If ProgProps.CusDiscountDoors > 0 Then
                    InitialPrice = txtInitialPrice8.EditValue
                    If DiscountChangedByUser = False Then Disc = ProgProps.CusDiscountDoors / 100 Else Disc = txtDisc8.EditValue / 100
                    Discount = Disc * InitialPrice
                    FinalPrice = InitialPrice - Discount
                    txtInitialPrice8.EditValue = InitialPrice
                    txtDiscount8.EditValue = Discount
                    txtFinalPrice8.EditValue = FinalPrice
                End If
            Case 9
                If DiscountChangedByUser = False Then txtDisc9.EditValue = ProgProps.CusDiscountCloset
                If ProgProps.CusDiscountDoors > 0 Then
                    InitialPrice = txtInitialPrice9.EditValue
                    If DiscountChangedByUser = False Then Disc = ProgProps.CusDiscountDoors / 100 Else Disc = txtDisc9.EditValue / 100
                    Discount = Disc * InitialPrice
                    FinalPrice = InitialPrice - Discount
                    txtInitialPrice9.EditValue = InitialPrice
                    txtDiscount9.EditValue = Discount
                    txtFinalPrice9.EditValue = FinalPrice
                End If
            Case 10
                If DiscountChangedByUser = False Then txtDisc10.EditValue = ProgProps.CusDiscountCloset
                If ProgProps.CusDiscountDoors > 0 Then
                    InitialPrice = txtInitialPrice10.EditValue
                    If DiscountChangedByUser = False Then Disc = ProgProps.CusDiscountDoors / 100 Else Disc = txtDisc10.EditValue / 100
                    Discount = Disc * InitialPrice
                    FinalPrice = InitialPrice - Discount
                    txtInitialPrice10.EditValue = InitialPrice
                    txtDiscount10.EditValue = Discount
                    txtFinalPrice10.EditValue = FinalPrice
                End If
        End Select
    End Sub
    Private Sub cmdPrintOffer_Click(sender As Object, e As EventArgs) Handles cmdPrintOffer.Click
        If sIsOrder Then
            Dim report As New RepCUSOrderDoors()
            report.Parameters.Item(0).Value = sID
            report.CreateDocument()
            Dim printTool As New ReportPrintTool(report)
            printTool.ShowRibbonPreview()
        Else
            Dim report As New RepCUSOfferDoors()
            report.Parameters.Item(0).Value = sID
            report.CreateDocument()
            Dim printTool As New ReportPrintTool(report)
            printTool.ShowRibbonPreview()
        End If
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
    Private Sub cboVALUELISTITEM6_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboVALUELISTITEM6.ButtonClick
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
            Case 1 : ManageCbo.ManageTRANSH(cboTRANSH, FormMode.NewRecord)
            Case 2 : ManageCbo.ManageTRANSH(cboTRANSH, FormMode.EditRecord)
            Case 3 : cboTRANSH.EditValue = Nothing
        End Select
    End Sub

    Private Sub cmdConvertToOrder_Click(sender As Object, e As EventArgs) Handles cmdConvertToOrder.Click
        Try
            If XtraMessageBox.Show("Θέλετε να μετατραπεί σε παραγγελία η προσφορά ?", ProgProps.ProgTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                Using oCmd As New SqlCommand("ConvertToOrder", CNDB)
                    oCmd.CommandType = CommandType.StoredProcedure
                    oCmd.Parameters.AddWithValue("@OfferID", sID)
                    oCmd.Parameters.AddWithValue("@createdBy", UserProps.ID)
                    oCmd.Parameters.AddWithValue("@Mode", 3)
                    oCmd.ExecuteNonQuery()
                End Using
                XtraMessageBox.Show("Η μετατροπή ολοκληρώθηκε με επιτυχία", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Information)
                'cmdConvertToOrder.Enabled = False
                cmdSave.Enabled = False
                LayoutControlItem7.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
                LabelControl1.Text = "Δεν μπορείτε να κάνετε αλλαγές στην προσφορά γιατί έχει δημιουργηθεί παραγγελία."
            End If
        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub cboVALUELISTITEM_ProcessNewValue(sender As Object, e As ProcessNewValueEventArgs) Handles cboValueListItem.ProcessNewValue
        If CStr(e.DisplayValue) <> String.Empty Then
            Dim sVALUELISTITEMID = DBQ.InsertNewVALUELISTITEM(cboValueListItem, e.DisplayValue)
            If sVALUELISTITEMID <> "" Then
                Me.Vw_VALUELISTITEM_V2TableAdapter.Fill(Me.DM_VALUELISTITEM.vw_VALUELISTITEM_V2)
                cboValueListItem.EditValue = System.Guid.Parse(sVALUELISTITEMID)
            End If
            e.Handled = True
        End If
    End Sub

    Private Sub cboVALUELISTITEM2_ProcessNewValue(sender As Object, e As ProcessNewValueEventArgs) Handles cboVALUELISTITEM2.ProcessNewValue
        If CStr(e.DisplayValue) <> String.Empty Then
            Dim sVALUELISTITEMID = DBQ.InsertNewVALUELISTITEM(cboVALUELISTITEM2, e.DisplayValue)
            If sVALUELISTITEMID <> "" Then
                Me.Vw_VALUELISTITEM_V2TableAdapter.Fill(Me.DM_VALUELISTITEM.vw_VALUELISTITEM_V2)
                cboVALUELISTITEM2.EditValue = System.Guid.Parse(sVALUELISTITEMID)
            End If
            e.Handled = True
        End If
    End Sub
    Private Sub cboVALUELISTITEM3_ProcessNewValue(sender As Object, e As ProcessNewValueEventArgs) Handles cboVALUELISTITEM3.ProcessNewValue
        If CStr(e.DisplayValue) <> String.Empty Then
            Dim sVALUELISTITEMID = DBQ.InsertNewVALUELISTITEM(cboVALUELISTITEM3, e.DisplayValue)
            If sVALUELISTITEMID <> "" Then
                Me.Vw_VALUELISTITEM_V2TableAdapter.Fill(Me.DM_VALUELISTITEM.vw_VALUELISTITEM_V2)
                cboVALUELISTITEM3.EditValue = System.Guid.Parse(sVALUELISTITEMID)
            End If
            e.Handled = True
        End If
    End Sub
    Private Sub cboVALUELISTITEM4_ProcessNewValue(sender As Object, e As ProcessNewValueEventArgs) Handles cboVALUELISTITEM4.ProcessNewValue
        If CStr(e.DisplayValue) <> String.Empty Then
            Dim sVALUELISTITEMID = DBQ.InsertNewVALUELISTITEM(cboVALUELISTITEM4, e.DisplayValue)
            If sVALUELISTITEMID <> "" Then
                Me.Vw_VALUELISTITEM_V2TableAdapter.Fill(Me.DM_VALUELISTITEM.vw_VALUELISTITEM_V2)
                cboVALUELISTITEM4.EditValue = System.Guid.Parse(sVALUELISTITEMID)
            End If
            e.Handled = True
        End If
    End Sub
    Private Sub cboVALUELISTITEM5_ProcessNewValue(sender As Object, e As ProcessNewValueEventArgs) Handles cboVALUELISTITEM5.ProcessNewValue
        If CStr(e.DisplayValue) <> String.Empty Then
            Dim sVALUELISTITEMID = DBQ.InsertNewVALUELISTITEM(cboVALUELISTITEM5, e.DisplayValue)
            If sVALUELISTITEMID <> "" Then
                Me.Vw_VALUELISTITEM_V2TableAdapter.Fill(Me.DM_VALUELISTITEM.vw_VALUELISTITEM_V2)
                cboVALUELISTITEM5.EditValue = System.Guid.Parse(sVALUELISTITEMID)
            End If
            e.Handled = True
        End If
    End Sub
    Private Sub cboVALUELISTITEM6_ProcessNewValue(sender As Object, e As ProcessNewValueEventArgs) Handles cboVALUELISTITEM6.ProcessNewValue
        If CStr(e.DisplayValue) <> String.Empty Then
            Dim sVALUELISTITEMID = DBQ.InsertNewVALUELISTITEM(cboVALUELISTITEM6, e.DisplayValue)
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

End Class