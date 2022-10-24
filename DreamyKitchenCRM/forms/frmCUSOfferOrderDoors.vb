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
        'TODO: This line of code loads data into the 'DreamyKitchenDataSet.vw_COLORSDOORS' table. You can move, or remove it, as needed.
        Me.Vw_COLORSDOORSTableAdapter.Fill(Me.DreamyKitchenDataSet.vw_COLORSDOORS)
        'TODO: This line of code loads data into the 'DreamyKitchenDataSet.vw_CCT' table. You can move, or remove it, as needed.
        Me.Vw_CCTTableAdapter.Fill(Me.DreamyKitchenDataSet.vw_CCT)
        'TODO: This line of code loads data into the 'DreamyKitchenDataSet.vw_SALERS' table. You can move, or remove it, as needed.
        Me.Vw_SALERSTableAdapter.Fill(Me.DreamyKitchenDataSet.vw_SALERS)
        Prog_Prop.GetProgPROSF()

        If sIsOrder = True Then
            LayoutControlItem41.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
            LayoutControlItem53.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
            LayoutControlItem54.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
            LayoutControlItem55.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
            LayoutControlItem69.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
            LayoutControlItem70.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
            LayoutControlItem72.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
        End If
        Select Case Mode
            Case FormMode.NewRecord
                txtCode.Text = IIf(sIsOrder = True, DBQ.GetNextId("CCT_ORDERS_DOOR"), DBQ.GetNextId("CCT_OFFERS_DOOR"))
                cboEMP.EditValue = System.Guid.Parse(UserProps.ID.ToString.ToUpper)
                txtdtdaysOfDelivery.EditValue = ProgProps.DAYS_OF_DELIVERY
                txtDescription.EditValue = ProgProps.DOOR_DESCRIPTION
                txtComments.EditValue = ProgProps.DOOR_CMT
                txtNotes.EditValue = ProgProps.CUS_NOTES
                txtTransp.EditValue = ProgProps.DoorTransp
                txtMeasurement.EditValue = ProgProps.DoorMeasurement
                txtRemove.EditValue = ProgProps.DoorRemove
            Case FormMode.EditRecord
                LoadForms.LoadForm(LayoutControl1, IIf(sIsOrder = True, "Select * from CCT_ORDERS_DOOR where id ='" + sID + "'", "Select * from CCT_OFFERS_DOOR where id ='" + sID + "'"))
        End Select
        Me.CenterToScreen()
        cmdSave.Enabled = IIf(Mode = FormMode.NewRecord, UserProps.AllowInsert, UserProps.AllowEdit)
    End Sub
    Private Sub cboEMP_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboEMP.ButtonClick
        Select Case e.Button.Index
            Case 1 : If UserProps.ID.ToString.ToUpper = "3F9DC32E-BE5B-4D46-A13C-EA606566CF32" Then cboEMP.EditValue = Nothing : ManageEMP()
            Case 2 : If UserProps.ID.ToString.ToUpper = "3F9DC32E-BE5B-4D46-A13C-EA606566CF32" Then If cboEMP.EditValue <> Nothing Then ManageEMP()
            Case 3 : cboEMP.EditValue = Nothing
        End Select
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

    Private Sub ManageEMP()
        Dim form1 As frmEMP = New frmEMP()
        form1.Text = "Προσωπικό"
        form1.CallerControl = cboEMP
        form1.CalledFromControl = True
        form1.MdiParent = frmMain
        If cboEMP.EditValue <> Nothing Then
            form1.ID = cboEMP.EditValue.ToString
            form1.Mode = FormMode.EditRecord
        Else
            form1.Mode = FormMode.NewRecord
        End If
        frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(form1), New Point(CInt(form1.Parent.ClientRectangle.Width / 2 - form1.Width / 2), CInt(form1.Parent.ClientRectangle.Height / 2 - form1.Height / 2)))
        form1.Show()
    End Sub
    Private Sub cboCUS_EditValueChanged(sender As Object, e As EventArgs) Handles cboCUS.EditValueChanged
        txtPhn.EditValue = cboCUS.GetColumnValue("phn")
        txtArea.EditValue = cboCUS.GetColumnValue("AREAS_Name")
        txtADR.EditValue = cboCUS.GetColumnValue("ADR_Name")
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
        lblDate.Text = DateAdd("d", CDbl(txtdtdaysOfDelivery.EditValue.ToString), FirstDate)
    End Sub

    Private Sub dtpresentation_EditValueChanged(sender As Object, e As EventArgs) Handles dtpresentation.EditValueChanged
        If dtpresentation.EditValue Is Nothing Or txtdtdaysOfDelivery.EditValue Is Nothing Then Exit Sub
        If dtpresentation.EditValue.ToString = "" Then Exit Sub
        Dim FirstDate As Date = dtpresentation.EditValue
        If txtdtdaysOfDelivery.EditValue Is Nothing Then txtdtdaysOfDelivery.EditValue = 0
        lblDate.Text = DateAdd("d", CDbl(txtdtdaysOfDelivery.EditValue.ToString), FirstDate)
    End Sub
    Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click
        Dim sResult As Boolean
        Dim sGuid As String
        Try
            If Valid.ValidateForm(LayoutControl1) Then
                Select Case Mode
                    Case FormMode.NewRecord
                        sGuid = System.Guid.NewGuid.ToString
                        If sIsOrder = True Then
                            sResult = DBQ.InsertNewData(DBQueries.InsertMode.OneLayoutControl, "CCT_ORDERS_DOOR", LayoutControl1,,, sGuid, True)
                        Else
                            sResult = DBQ.InsertNewData(DBQueries.InsertMode.OneLayoutControl, "CCT_OFFERS_DOOR", LayoutControl1,,, sGuid, True)
                        End If

                        sID = sGuid
                    Case FormMode.EditRecord
                        If sIsOrder = True Then
                            sResult = DBQ.UpdateNewData(DBQueries.InsertMode.OneLayoutControl, "CCT_ORDERS_DOOR", LayoutControl1,,, sID, True)
                        Else
                            sResult = DBQ.UpdateNewData(DBQueries.InsertMode.OneLayoutControl, "CCT_OFFERS_DOOR", LayoutControl1,,, sID, True)
                        End If

                        'sGuid = sID
                End Select

                If FScrollerExist = True Then
                    Dim form As frmScroller = Frm
                    If sIsOrder = True Then
                        form.LoadRecords("vw_CCT_ORDERS_DOOR")
                    Else
                        form.LoadRecords("vw_CCT_OFFERS_DOOR")
                    End If

                End If

                If sResult = True Then
                    XtraMessageBox.Show("Η εγγραφή αποθηκέυτηκε με επιτυχία", "Dreamy Kitchen CRM", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    If Mode = FormMode.NewRecord Then
                        '    Cls.ClearCtrls(LayoutControl1)
                        '    txtCode.Text = DBQ.GetNextId("CCT_OFFERS_DOOR")
                        Mode = FormMode.EditRecord
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

    Private Sub cboVBOXColors_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboVBOXColors.ButtonClick
        Select Case e.Button.Index
            Case 1 : cboVBOXColors.EditValue = Nothing : ManageColors(cboVBOXColors)
            Case 2 : If cboVBOXColors.EditValue <> Nothing Then ManageColors(cboVBOXColors)
            Case 3 : cboVBOXColors.EditValue = Nothing
        End Select
    End Sub
    Private Sub ManageColors(ByVal CallerControl As LookUpEdit)
        Dim frmColors As frmColors = New frmColors

        frmColors.ColorCategory = "F7FEADFC-507E-421B-9AB2-CB84DD3A2505"
        frmColors.Text = "Χρώματα"
        frmColors.CallerForm = "frmCUSOfferOrderDoors"
        frmColors.CallerControlLKUP = CallerControl
        frmColors.CalledFromControl = True
        frmColors.MdiParent = frmMain
        If CallerControl.EditValue <> Nothing Then
            frmColors.ID = CallerControl.EditValue.ToString
            frmColors.Mode = FormMode.EditRecord
        Else
            frmColors.Mode = FormMode.NewRecord
        End If
        frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(frmColors), New Point(CInt(frmColors.Parent.ClientRectangle.Width / 2 - frmColors.Width / 2), CInt(frmColors.Parent.ClientRectangle.Height / 2 - frmColors.Height / 2)))
        frmColors.Show()
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
    Private Sub ManageDoorType(ByVal CallerControl As LookUpEdit)
        Dim frmDoorType As frmDoorType = New frmDoorType
        frmDoorType.Text = "Κατηγορία Πόρτας"
        frmDoorType.CallerControl = CallerControl
        frmDoorType.CalledFromControl = True
        If CallerControl.EditValue <> Nothing Then frmDoorType.ID = CallerControl.EditValue.ToString
        frmDoorType.MdiParent = frmMain
        If CallerControl.EditValue <> Nothing Then frmDoorType.Mode = FormMode.EditRecord Else frmDoorType.Mode = FormMode.NewRecord
        frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(frmDoorType), New Point(CInt(frmDoorType.Parent.ClientRectangle.Width / 2 - frmDoorType.Width / 2), CInt(frmDoorType.Parent.ClientRectangle.Height / 2 - frmDoorType.Height / 2)))
        frmDoorType.Show()
    End Sub

    Private Sub cboDoorType_ButtonClick(sender As Object, e As ButtonPressedEventArgs)
        Select Case e.Button.Index
            Case 1 : cboDoorType.EditValue = Nothing : ManageDoorType(cboDoorType)
            Case 2 : If cboDoorType.EditValue <> Nothing Then ManageDoorType(cboDoorType)
            Case 3 : cboDoorType.EditValue = Nothing
        End Select
    End Sub
    Private Sub cboDoorType2_ButtonClick(sender As Object, e As ButtonPressedEventArgs)
        Select Case e.Button.Index
            Case 1 : cboDoorType2.EditValue = Nothing : ManageDoorType(cboDoorType2)
            Case 2 : If cboDoorType2.EditValue <> Nothing Then ManageDoorType(cboDoorType2)
            Case 3 : cboDoorType2.EditValue = Nothing
        End Select
    End Sub

    Private Sub cboDoorType3_ButtonClick(sender As Object, e As ButtonPressedEventArgs)
        Select Case e.Button.Index
            Case 1 : cboDoorType3.EditValue = Nothing : ManageDoorType(cboDoorType3)
            Case 2 : If cboDoorType3.EditValue <> Nothing Then ManageDoorType(cboDoorType3)
            Case 3 : cboDoorType3.EditValue = Nothing
        End Select
    End Sub
    Private Sub cboDoorType4_ButtonClick(sender As Object, e As ButtonPressedEventArgs)
        Select Case e.Button.Index
            Case 1 : cboDoorType4.EditValue = Nothing : ManageDoorType(cboDoorType4)
            Case 2 : If cboDoorType4.EditValue <> Nothing Then ManageDoorType(cboDoorType4)
            Case 3 : cboDoorType4.EditValue = Nothing
        End Select
    End Sub
    Private Sub cboDoorType5_ButtonClick(sender As Object, e As ButtonPressedEventArgs)
        Select Case e.Button.Index
            Case 1 : cboDoorType5.EditValue = Nothing : ManageDoorType(cboDoorType5)
            Case 2 : If cboDoorType5.EditValue <> Nothing Then ManageDoorType(cboDoorType5)
            Case 3 : cboDoorType5.EditValue = Nothing
        End Select
    End Sub
    Private Sub cboDoorType6_ButtonClick(sender As Object, e As ButtonPressedEventArgs)
        Select Case e.Button.Index
            Case 1 : cboDoorType6.EditValue = Nothing : ManageDoorType(cboDoorType6)
            Case 2 : If cboDoorType6.EditValue <> Nothing Then ManageDoorType(cboDoorType6)
            Case 3 : cboDoorType6.EditValue = Nothing
        End Select
    End Sub

    Private Sub LoadDoorType(ByVal cboEdit As ComboBoxEdit, ByVal cboKasa As ComboBoxEdit, ByVal lkupEditDoorType As LookUpEdit)
        If cboEdit.SelectedIndex = -1 Or cboKasa.EditValue = -1 Then Exit Sub
        Dim sSQL = New System.Text.StringBuilder
        sSQL.AppendLine("Select id,name,price from vw_DOOR_TYPE where doorCatID='E6733593-7DA0-4180-8951-B09315E1F13D' and doorType = " & cboEdit.SelectedIndex & " and kasa = " & cboKasa.SelectedIndex)
        FillCbo.DOOR_TYPE(lkupEditDoorType, sSQL)
        'If Me.IsActive = False Then Exit Sub
        'If cboEdit.SelectedIndex = -1 Or lkupEditDoorType.EditValue = Nothing Then Exit Sub
        'Me.Vw_DOOR_TYPEDOORSTableAdapter.Fill(Me.DMDataSet.vw_DOOR_TYPEDOORS, cboEdit.SelectedIndex, cboKasa.SelectedIndex)
    End Sub


    Private Sub cboType1_EditValueChanged(sender As Object, e As EventArgs) Handles cboType1.EditValueChanged
        LoadDoorType(cboType1, cboKasa1, cboDoorType)
    End Sub

    Private Sub cboType2_EditValueChanged(sender As Object, e As EventArgs) Handles cboType2.EditValueChanged
        LoadDoorType(cboType2, cboKasa2, cboDoorType2)
    End Sub

    Private Sub cboType3_EditValueChanged(sender As Object, e As EventArgs) Handles cboType3.EditValueChanged
        LoadDoorType(cboType3, cboKasa3, cboDoorType3)
    End Sub

    Private Sub cboType4_EditValueChanged(sender As Object, e As EventArgs) Handles cboType4.EditValueChanged
        LoadDoorType(cboType4, cboKasa4, cboDoorType4)
    End Sub

    Private Sub cboType5_EditValueChanged(sender As Object, e As EventArgs) Handles cboType5.EditValueChanged
        LoadDoorType(cboType5, cboKasa5, cboDoorType5)
    End Sub

    Private Sub cboType6_EditValueChanged(sender As Object, e As EventArgs) Handles cboType6.EditValueChanged
        LoadDoorType(cboType6, cboKasa6, cboDoorType6)
    End Sub
    Private Sub cboKasa1_EditValueChanged(sender As Object, e As EventArgs) Handles cboKasa1.EditValueChanged
        LoadDoorType(cboType1, cboKasa1, cboDoorType)
    End Sub
    Private Sub cboKasa2_EditValueChanged(sender As Object, e As EventArgs) Handles cboKasa2.EditValueChanged
        LoadDoorType(cboType2, cboKasa2, cboDoorType2)
    End Sub

    Private Sub cboKasa3_EditValueChanged(sender As Object, e As EventArgs) Handles cboKasa3.EditValueChanged
        LoadDoorType(cboType3, cboKasa3, cboDoorType3)
    End Sub

    Private Sub cboKasa4_EditValueChanged(sender As Object, e As EventArgs) Handles cboKasa4.EditValueChanged
        LoadDoorType(cboType4, cboKasa4, cboDoorType4)
    End Sub

    Private Sub cboKasa5_EditValueChanged(sender As Object, e As EventArgs) Handles cboKasa5.EditValueChanged
        LoadDoorType(cboType5, cboKasa5, cboDoorType5)
    End Sub

    Private Sub cboKasa6_EditValueChanged(sender As Object, e As EventArgs) Handles cboKasa6.EditValueChanged
        LoadDoorType(cboType6, cboKasa6, cboDoorType6)
    End Sub

    Private Sub cboType1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboType1.SelectedIndexChanged

    End Sub

    Private Sub cboKasa1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboKasa1.SelectedIndexChanged

    End Sub
End Class