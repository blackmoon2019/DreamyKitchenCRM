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
        'TODO: This line of code loads data into the 'DM_DOORTYPES.vw_DOOR_TYPE_V2' table. You can move, or remove it, as needed.
        Me.Vw_DOOR_TYPE_V2TableAdapter.Fill(Me.DM_DOORTYPES.vw_DOOR_TYPE_V2)
        'TODO: This line of code loads data into the 'DMDataSet.CCT_TRANSH' table. You can move, or remove it, as needed.
        Me.CCT_TRANSHTableAdapter.Fill(Me.DMDataSet.CCT_TRANSH)
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
                cmdConvertToOrder.Enabled = False
            Case FormMode.EditRecord
                Dim sFields As New Dictionary(Of String, String)
                LoadForms.LoadForm(LayoutControl1, "Select [ORDER].id as OrderID,CCT_ORDERS_DOOR.* " &
                                                   " from CCT_ORDERS_DOOR " &
                                                   " left join CCT_ORDERS_DOOR  [ORDER] on [ORDER].CreatedFromOfferID =  CCT_ORDERS_DOOR.id " &
                                                   " where CCT_ORDERS_DOOR.id = " & toSQLValueS(sID), sFields)
                If sIsOrder = False Then
                    If sFields("OrderID") <> "" Then
                        cmdConvertToOrder.Enabled = False
                        cmdSave.Enabled = False
                        LabelControl1.Text = "Δεν μπορείτε να κάνετε αλλαγές στην προσφορά γιατί έχει δημιουργηθεί παραγγελία."
                    End If
                Else
                    cmdConvertToOrder.Enabled = False
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
                        sResult = DBQ.InsertNewData(DBQueries.InsertMode.OneLayoutControl, "CCT_ORDERS_DOOR", LayoutControl1,,, sGuid, True, "dtDeliver,IsOrder", toSQLValueS(CDate(sDate).ToString("yyyyMMdd")) & "," & IIf(sIsOrder = True, 1, 0))
                        sID = sGuid
                    Case FormMode.EditRecord
                        Dim sDate As String = lblDate.Text.Replace("Ημερομηνία Παράδοσης: ", "")
                        sResult = DBQ.UpdateNewData(DBQueries.InsertMode.OneLayoutControl, "CCT_ORDERS_DOOR", LayoutControl1,,, sID, True,,,, "dtDeliver=" & toSQLValueS(CDate(sDate).ToString("yyyyMMdd")) & ",IsOrder = " & IIf(sIsOrder = True, 1, 0))

                        'sGuid = sID
                End Select

                If FScrollerExist = True Then
                    Dim form As frmScroller = Frm
                    form.LoadRecords("vw_CCT_ORDERS_DOOR")
                End If

                If sResult = True Then
                    XtraMessageBox.Show("Η εγγραφή αποθηκέυτηκε με επιτυχία", "Dreamy Kitchen CRM", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    If Mode = FormMode.NewRecord Then
                        Mode = FormMode.EditRecord
                        cmdConvertToOrder.Enabled = True
                    End If
                    If sIsOrder Then
                        Dim HasKitchen As Boolean, HasCloset As Boolean, HasDoors As Boolean, HasSc As Boolean
                        HasKitchen = cboTRANSH.GetColumnValue("Iskitchen")
                        HasCloset = cboTRANSH.GetColumnValue("Iscloset")
                        HasDoors = cboTRANSH.GetColumnValue("Isdoors")
                        HasSc = cboTRANSH.GetColumnValue("Issc")
                        If HasKitchen = False And HasCloset = False And HasDoors = False And HasSc = False Then
                            XtraMessageBox.Show("Κοστολόγηση δεν θα δημιουργηθεί λόγω έλλειψης συμφωνητικού", "Dreamy Kitchen CRM", MessageBoxButtons.OK, MessageBoxIcon.Warning)
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
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), "Dreamy Kitchen CRM", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Function TotalPrice() As Double
        Dim Price1 As Double, Price2 As Double, Price3 As Double, Price4 As Double, Price5 As Double, Price6 As Double
        Dim Total As Double
        Price1 = DbnullToZero(txtPrice1)
        Price2 = DbnullToZero(txtPrice2)
        Price3 = DbnullToZero(txtPrice3)
        Price4 = DbnullToZero(txtPrice4)
        Price5 = DbnullToZero(txtPrice5)
        Price6 = DbnullToZero(txtPrice6)
        Total = Price1 + Price2 + Price3 + Price4 + Price5 + Price6
        Return Total
    End Function
    Private Function TotalVatPrice() As Double
        Dim Price1 As Double, Price2 As Double, Price3 As Double, Price4 As Double, Price5 As Double, Price6 As Double
        Dim Total As Double
        Price1 = DbnullToZero(txtvatPrice1)
        Price2 = DbnullToZero(txtVatPrice2)
        Price3 = DbnullToZero(txtVatPrice3)
        Price4 = DbnullToZero(txtVatPrice4)
        Price5 = DbnullToZero(txtVatPrice5)
        Price6 = DbnullToZero(txtVatPrice6)
        Total = Price1 + Price2 + Price3 + Price4 + Price5 + Price6
        Return Total
    End Function

    Private Sub txtVatPrice1_EditValueChanged(sender As Object, e As EventArgs) Handles txtVatPrice1.EditValueChanged
        Dim Price As Double
        Price = DbnullToZero(txtVatPrice1)
        txtPrice1.EditValue = Price * (ProgProps.VAT / 100) + Price
        txtTotalVatPrice.EditValue = TotalVatPrice() : txtTotalPrice.EditValue = TotalPrice()
    End Sub

    Private Sub txtVatPrice2_EditValueChanged(sender As Object, e As EventArgs) Handles txtVatPrice2.EditValueChanged
        Dim Price As Double
        Price = DbnullToZero(txtVatPrice2)
        txtPrice2.EditValue = Price * (ProgProps.VAT / 100) + Price
        txtTotalVatPrice.EditValue = TotalVatPrice() : txtTotalPrice.EditValue = TotalPrice()
    End Sub

    Private Sub txtVatPrice3_EditValueChanged(sender As Object, e As EventArgs) Handles txtVatPrice3.EditValueChanged
        Dim Price As Double
        Price = DbnullToZero(txtVatPrice3)
        txtPrice3.EditValue = Price * (ProgProps.VAT / 100) + Price
        txtTotalVatPrice.EditValue = TotalVatPrice() : txtTotalPrice.EditValue = TotalPrice()
    End Sub

    Private Sub txtVatPrice4_EditValueChanged(sender As Object, e As EventArgs) Handles txtVatPrice4.EditValueChanged
        Dim Price As Double
        Price = DbnullToZero(txtVatPrice4)
        txtPrice4.EditValue = Price * (ProgProps.VAT / 100) + Price
        txtTotalVatPrice.EditValue = TotalVatPrice() : txtTotalPrice.EditValue = TotalPrice()
    End Sub

    Private Sub txtVatPrice5_EditValueChanged(sender As Object, e As EventArgs) Handles txtVatPrice5.EditValueChanged
        Dim Price As Double
        Price = DbnullToZero(txtVatPrice5)
        txtPrice5.EditValue = Price * (ProgProps.VAT / 100) + Price
        txtTotalVatPrice.EditValue = TotalVatPrice() : txtTotalPrice.EditValue = TotalPrice()
    End Sub

    Private Sub txtVatPrice6_EditValueChanged(sender As Object, e As EventArgs) Handles txtVatPrice6.EditValueChanged
        Dim Price As Double
        Price = DbnullToZero(txtVatPrice6)
        txtPrice6.EditValue = Price * (ProgProps.VAT / 100) + Price
        txtTotalVatPrice.EditValue = TotalVatPrice() : txtTotalPrice.EditValue = TotalPrice()
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

    Private Sub cboDoorType_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboDoorType.ButtonClick
        Select Case e.Button.Index
            Case 1 : ManageCbo.ManageDoorType(cboDoorType, FormMode.NewRecord, "DE86FD16-2154-4E2A-B025-4D34BDF8C808")
            Case 2 : ManageCbo.ManageDoorType(cboDoorType, FormMode.EditRecord)
            Case 3 : cboDoorType.EditValue = Nothing
        End Select
    End Sub
    Private Sub cboDoorType2_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboDoorType2.ButtonClick
        Select Case e.Button.Index
            Case 1 : ManageCbo.ManageDoorType(cboDoorType2, FormMode.NewRecord, "DE86FD16-2154-4E2A-B025-4D34BDF8C808")
            Case 2 : ManageCbo.ManageDoorType(cboDoorType2, FormMode.EditRecord)
            Case 3 : cboDoorType2.EditValue = Nothing
        End Select
    End Sub
    Private Sub cboDoorType3_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboDoorType3.ButtonClick
        Select Case e.Button.Index
            Case 1 : ManageCbo.ManageDoorType(cboDoorType3, FormMode.NewRecord, "DE86FD16-2154-4E2A-B025-4D34BDF8C808")
            Case 2 : ManageCbo.ManageDoorType(cboDoorType3, FormMode.EditRecord)
            Case 3 : cboDoorType3.EditValue = Nothing
        End Select
    End Sub
    Private Sub cboDoorType4_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboDoorType4.ButtonClick
        Select Case e.Button.Index
            Case 1 : ManageCbo.ManageDoorType(cboDoorType4, FormMode.NewRecord, "DE86FD16-2154-4E2A-B025-4D34BDF8C808")
            Case 2 : ManageCbo.ManageDoorType(cboDoorType4, FormMode.EditRecord)
            Case 3 : cboDoorType4.EditValue = Nothing
        End Select
    End Sub
    Private Sub cboDoorType5_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboDoorType5.ButtonClick
        Select Case e.Button.Index
            Case 1 : ManageCbo.ManageDoorType(cboDoorType5, FormMode.NewRecord, "DE86FD16-2154-4E2A-B025-4D34BDF8C808")
            Case 2 : ManageCbo.ManageDoorType(cboDoorType5, FormMode.EditRecord)
            Case 3 : cboDoorType5.EditValue = Nothing
        End Select
    End Sub
    Private Sub cboDoorType6_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboDoorType6.ButtonClick
        Select Case e.Button.Index
            Case 1 : ManageCbo.ManageDoorType(cboDoorType6, FormMode.NewRecord, "DE86FD16-2154-4E2A-B025-4D34BDF8C808")
            Case 2 : ManageCbo.ManageDoorType(cboDoorType6, FormMode.EditRecord)
            Case 3 : cboDoorType6.EditValue = Nothing
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
            If XtraMessageBox.Show("Θέλετε να μετατραπεί σε παραγγελία η προσφορά ?", "Dreamy Kitchen CRM", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                Using oCmd As New SqlCommand("ConvertToOrder", CNDB)
                    oCmd.CommandType = CommandType.StoredProcedure
                    oCmd.Parameters.AddWithValue("@OfferID", sID)
                    oCmd.Parameters.AddWithValue("@createdBy", UserProps.ID)
                    oCmd.Parameters.AddWithValue("@Mode", 3)
                    oCmd.ExecuteNonQuery()
                End Using
                XtraMessageBox.Show("Η μετατροπή ολοκληρώθηκε με επιτυχία", "Dreamy Kitchen CRM", MessageBoxButtons.OK, MessageBoxIcon.Information)
                cmdConvertToOrder.Enabled = False : cmdSave.Enabled = False
                LabelControl1.Text = "Δεν μπορείτε να κάνετε αλλαγές στην προσφορά γιατί έχει δημιουργηθεί παραγγελία."
            End If
        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), "Dreamy Kitchen CRM", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
            Dim sDoorTypeID = DBQ.InsertNewDoorType(cboDoorType2, e.DisplayValue)
            If sDoorTypeID <> "" Then
                Me.Vw_DOOR_TYPE_V2TableAdapter.Fill(Me.DM_DOORTYPES.vw_DOOR_TYPE_V2)
                cboDoorType2.EditValue = System.Guid.Parse(sDoorTypeID)
            End If
            e.Handled = True
        End If
    End Sub
    Private Sub cboDoorType3_ProcessNewValue(sender As Object, e As ProcessNewValueEventArgs) Handles cboDoorType3.ProcessNewValue
        If CStr(e.DisplayValue) <> String.Empty Then
            Dim sDoorTypeID = DBQ.InsertNewDoorType(cboDoorType3, e.DisplayValue)
            If sDoorTypeID <> "" Then
                Me.Vw_DOOR_TYPE_V2TableAdapter.Fill(Me.DM_DOORTYPES.vw_DOOR_TYPE_V2)
                cboDoorType3.EditValue = System.Guid.Parse(sDoorTypeID)
            End If
            e.Handled = True
        End If
    End Sub
    Private Sub cboDoorType4_ProcessNewValue(sender As Object, e As ProcessNewValueEventArgs) Handles cboDoorType4.ProcessNewValue
        If CStr(e.DisplayValue) <> String.Empty Then
            Dim sDoorTypeID = DBQ.InsertNewDoorType(cboDoorType4, e.DisplayValue)
            If sDoorTypeID <> "" Then
                Me.Vw_DOOR_TYPE_V2TableAdapter.Fill(Me.DM_DOORTYPES.vw_DOOR_TYPE_V2)
                cboDoorType4.EditValue = System.Guid.Parse(sDoorTypeID)
            End If
            e.Handled = True
        End If
    End Sub
    Private Sub cboDoorType5_ProcessNewValue(sender As Object, e As ProcessNewValueEventArgs) Handles cboDoorType5.ProcessNewValue
        If CStr(e.DisplayValue) <> String.Empty Then
            Dim sDoorTypeID = DBQ.InsertNewDoorType(cboDoorType5, e.DisplayValue)
            If sDoorTypeID <> "" Then
                Me.Vw_DOOR_TYPE_V2TableAdapter.Fill(Me.DM_DOORTYPES.vw_DOOR_TYPE_V2)
                cboDoorType5.EditValue = System.Guid.Parse(sDoorTypeID)
            End If
            e.Handled = True
        End If
    End Sub
    Private Sub cboDoorType6_ProcessNewValue(sender As Object, e As ProcessNewValueEventArgs) Handles cboDoorType6.ProcessNewValue
        If CStr(e.DisplayValue) <> String.Empty Then
            Dim sDoorTypeID = DBQ.InsertNewDoorType(cboDoorType6, e.DisplayValue)
            If sDoorTypeID <> "" Then
                Me.Vw_DOOR_TYPE_V2TableAdapter.Fill(Me.DM_DOORTYPES.vw_DOOR_TYPE_V2)
                cboDoorType6.EditValue = System.Guid.Parse(sDoorTypeID)
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