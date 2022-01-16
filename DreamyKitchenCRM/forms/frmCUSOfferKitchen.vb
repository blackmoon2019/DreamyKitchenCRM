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

Public Class frmCUSOfferKitchen
    Private sID As String
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

    Private Sub frmCUSOffer_Load(sender As Object, e As EventArgs) Handles Me.Load
        'TODO: This line of code loads data into the 'DreamyKitchenDataSet.vw_CCT' table. You can move, or remove it, as needed.
        Me.Vw_CCTTableAdapter.Fill(Me.DreamyKitchenDataSet.vw_CCT)
        'TODO: This line of code loads data into the 'DreamyKitchenDataSet.vw_BENCH' table. You can move, or remove it, as needed.
        Me.Vw_BENCHTableAdapter.Fill(Me.DreamyKitchenDataSet.vw_BENCH)
        'TODO: This line of code loads data into the 'DreamyKitchenDataSet.vw_COLORSPVC' table. You can move, or remove it, as needed.
        Me.Vw_COLORSPVCTableAdapter.Fill(Me.DreamyKitchenDataSet.vw_COLORSPVC)
        'TODO: This line of code loads data into the 'DreamyKitchenDataSet.vw_COLORSBOX' table. You can move, or remove it, as needed.
        Me.Vw_COLORSBOXTableAdapter.Fill(Me.DreamyKitchenDataSet.vw_COLORSBOX)
        'TODO: This line of code loads data into the 'DreamyKitchenDataSet.vw_SALERS' table. You can move, or remove it, as needed.
        Me.Vw_SALERSTableAdapter.Fill(Me.DreamyKitchenDataSet.vw_SALERS)
        Prog_Prop.GetProgPROSF()

        Select Case Mode
            Case FormMode.NewRecord
                txtCode.Text = DBQ.GetNextId("CCT_OFFERS")
                txtVHeight.EditValue = ProgProps.V_HEIGHT
                txtKHeight.EditValue = ProgProps.K_HEIGHT
                txtYHeight.EditValue = ProgProps.Y_HEIGHT
                cboVBOXColors.EditValue = System.Guid.Parse(ProgProps.V_BOX_COLOR)
                cboKBOXColors.EditValue = System.Guid.Parse(ProgProps.K_BOX_COLOR)
                cboYBOXColors.EditValue = System.Guid.Parse(ProgProps.Y_BOX_COLOR)
                cboVPVCColors.EditValue = System.Guid.Parse(ProgProps.V_PVC_COLOR)
                cboKPVCColors.EditValue = System.Guid.Parse(ProgProps.K_PVC_COLOR)
                cboYPVCColors.EditValue = System.Guid.Parse(ProgProps.Y_PVC_COLOR)
                cboBENCH.EditValue = System.Guid.Parse(ProgProps.BENCH)
                txtlegs.EditValue = ProgProps.LEGS
                txtKFinalHeight.EditValue = ProgProps.K_FINAL_HEIGHT
                txtYFinalHeight.EditValue = ProgProps.Y_FINAL_HEIGHT
                cboEMP.EditValue = System.Guid.Parse(UserProps.ID.ToString.ToUpper)
                txtdtdaysOfDelivery.EditValue = ProgProps.DAYS_OF_DELIVERY
            Case FormMode.EditRecord
                LoadForms.LoadForm(LayoutControl1, "Select * from CCT_OFFERS where id ='" + sID + "'")
        End Select
        Me.CenterToScreen()
        cmdSave.Enabled = IIf(Mode = FormMode.NewRecord, UserProps.AllowInsert, UserProps.AllowEdit)

    End Sub
    Private Sub cboEMP_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboEMP.ButtonClick
        Select Case e.Button.Index
            Case 1 : cboEMP.EditValue = Nothing : ManageEMP()
            Case 2 : If cboEMP.EditValue <> Nothing Then ManageEMP()
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
    Private Sub cboBENCH_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboBENCH.ButtonClick
        Select Case e.Button.Index
            Case 1 : cboBENCH.EditValue = Nothing : ManageBENCH()
            Case 2 : If cboBENCH.EditValue <> Nothing Then ManageBENCH()
            Case 3 : cboBENCH.EditValue = Nothing
        End Select
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
        frmColors.Text = "Χρώματα"
        frmColors.CallerForm = "frmCUSOffer"
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
    Private Sub ManageBENCH()
        Dim frmBench As frmBench = New frmBench
        frmBench.CallerForm = "frmOffer"
        frmBench.CallerControl = cboBENCH
        frmBench.CalledFromControl = True
        frmBench.MdiParent = frmMain
        If cboBENCH.EditValue <> Nothing Then
            frmBench.ID = cboBENCH.EditValue.ToString
            frmBench.Mode = FormMode.EditRecord
        Else
            frmBench.Mode = FormMode.NewRecord
        End If
        frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(frmBench), New Point(CInt(frmBench.Parent.ClientRectangle.Width / 2 - frmBench.Width / 2), CInt(frmBench.Parent.ClientRectangle.Height / 2 - frmBench.Height / 2)))
        frmBench.Show()
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

    Private Sub cboVPVCColors_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboVPVCColors.ButtonClick
        Select Case e.Button.Index
            Case 1 : cboVPVCColors.EditValue = Nothing : ManageColors(cboVPVCColors)
            Case 2 : If cboVPVCColors.EditValue <> Nothing Then ManageColors(cboVPVCColors)
            Case 3 : cboVPVCColors.EditValue = Nothing
        End Select
    End Sub
    Private Sub cboKBOXColors_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboKBOXColors.ButtonClick
        Select Case e.Button.Index
            Case 1 : cboVBOXColors.EditValue = Nothing : ManageColors(cboKBOXColors)
            Case 2 : If cboKBOXColors.EditValue <> Nothing Then ManageColors(cboKBOXColors)
            Case 3 : cboKBOXColors.EditValue = Nothing
        End Select
    End Sub

    Private Sub cboKPVCColors_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboKPVCColors.ButtonClick
        Select Case e.Button.Index
            Case 1 : cboVBOXColors.EditValue = Nothing : ManageColors(cboKPVCColors)
            Case 2 : If cboKPVCColors.EditValue <> Nothing Then ManageColors(cboKPVCColors)
            Case 3 : cboKPVCColors.EditValue = Nothing
        End Select
    End Sub

    Private Sub cboYBOXColors_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboYBOXColors.ButtonClick
        Select Case e.Button.Index
            Case 1 : cboVBOXColors.EditValue = Nothing : ManageColors(cboYBOXColors)
            Case 2 : If cboYBOXColors.EditValue <> Nothing Then ManageColors(cboYBOXColors)
            Case 3 : cboYBOXColors.EditValue = Nothing
        End Select
    End Sub

    Private Sub cboYPVCColors_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboYPVCColors.ButtonClick
        Select Case e.Button.Index
            Case 1 : cboVBOXColors.EditValue = Nothing : ManageColors(cboYPVCColors)
            Case 2 : If cboYPVCColors.EditValue <> Nothing Then ManageColors(cboYPVCColors)
            Case 3 : cboYPVCColors.EditValue = Nothing
        End Select
    End Sub

    Private Sub txtInitialPrice1_EditValueChanged(sender As Object, e As EventArgs) Handles txtInitialPrice1.EditValueChanged
        Dim Disc As Double, Discount As Double, InitialPrice As Double, FinalPrice As Double
        txtDisc1.EditValue = ProgProps.CusDiscount
        If ProgProps.CusDiscount > 0 Then
            InitialPrice = txtInitialPrice1.EditValue
            Disc = ProgProps.CusDiscount / 100
            Discount = Disc * InitialPrice
            FinalPrice = InitialPrice - Discount
            txtInitialPrice1.EditValue = InitialPrice
            txtDiscount1.EditValue = Discount
            txtFinalPrice1.EditValue = FinalPrice
        End If
    End Sub

    Private Sub txtInitialPrice2_EditValueChanged(sender As Object, e As EventArgs) Handles txtInitialPrice2.EditValueChanged
        Dim Disc As Double, Discount As Double, InitialPrice As Double, FinalPrice As Double
        txtDisc2.EditValue = ProgProps.CusDiscount
        If ProgProps.CusDiscount > 0 Then
            InitialPrice = txtInitialPrice2.EditValue
            Disc = ProgProps.CusDiscount / 100
            Discount = Disc * InitialPrice
            FinalPrice = InitialPrice - Discount
            txtInitialPrice2.EditValue = InitialPrice
            txtDiscount2.EditValue = Discount
            txtFinalPrice2.EditValue = FinalPrice
        End If

    End Sub

    Private Sub txtInitialPrice3_EditValueChanged(sender As Object, e As EventArgs) Handles txtInitialPrice3.EditValueChanged
        Dim Disc As Double, Discount As Double, InitialPrice As Double, FinalPrice As Double
        txtDisc3.EditValue = ProgProps.CusDiscount
        If ProgProps.CusDiscount > 0 Then
            InitialPrice = txtInitialPrice3.EditValue
            Disc = ProgProps.CusDiscount / 100
            Discount = Disc * InitialPrice
            FinalPrice = InitialPrice - Discount
            txtInitialPrice3.EditValue = InitialPrice
            txtDiscount3.EditValue = Discount
            txtFinalPrice3.EditValue = FinalPrice
        End If
    End Sub

    Private Sub txtInitialPrice4_EditValueChanged(sender As Object, e As EventArgs) Handles txtInitialPrice4.EditValueChanged
        Dim Disc As Double, Discount As Double, InitialPrice As Double, FinalPrice As Double
        txtDisc4.EditValue = ProgProps.CusDiscount
        If ProgProps.CusDiscount > 0 Then
            InitialPrice = txtInitialPrice4.EditValue
            Disc = ProgProps.CusDiscount / 100
            Discount = Disc * InitialPrice
            FinalPrice = InitialPrice - Discount
            txtInitialPrice4.EditValue = InitialPrice
            txtDiscount4.EditValue = Discount
            txtFinalPrice4.EditValue = FinalPrice
        End If
    End Sub

    Private Sub cboCUS_EditValueChanged(sender As Object, e As EventArgs) Handles cboCUS.EditValueChanged
        txtPhn.EditValue = cboCUS.GetColumnValue("phn")
        txtArea.EditValue = cboCUS.GetColumnValue("AREAS_Name")
        txtADR.EditValue = cboCUS.GetColumnValue("ADR_Name")
    End Sub

    Private Sub txtdtdaysOfDelivery_EditValueChanged(sender As Object, e As EventArgs) Handles txtdtdaysOfDelivery.EditValueChanged
        If dtpresentation.EditValue Is Nothing Then Exit Sub
        Dim FirstDate As Date = dtpresentation.EditValue
        lblDate.Text = DateAdd("d", CDbl(txtdtdaysOfDelivery.EditValue.ToString), FirstDate)
    End Sub

    Private Sub dtpresentation_EditValueChanged(sender As Object, e As EventArgs) Handles dtpresentation.EditValueChanged
        If dtpresentation.EditValue Is Nothing Or txtdtdaysOfDelivery.EditValue Is Nothing Then Exit Sub
        If dtpresentation.EditValue = "" Then Exit Sub
        Dim FirstDate As Date = dtpresentation.EditValue
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
                        sResult = DBQ.InsertNewData(DBQueries.InsertMode.OneLayoutControl, "CCT_OFFERS", LayoutControl1,,, sGuid, True)
                        sID = sGuid
                    Case FormMode.EditRecord
                        sResult = DBQ.UpdateNewData(DBQueries.InsertMode.OneLayoutControl, "CCT_OFFERS", LayoutControl1,,, sID, True)
                        'sGuid = sID
                End Select

                If FScrollerExist = True Then
                    Dim form As frmScroller = Frm
                    form.LoadRecords("vw_CCT_OFFERS")
                End If

                If sResult = True Then
                    XtraMessageBox.Show("Η εγγραφή αποθηκέυτηκε με επιτυχία", "Dreamy Kitchen CRM", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    If Mode = FormMode.NewRecord Then
                        Cls.ClearCtrls(LayoutControl1)
                        txtCode.Text = DBQ.GetNextId("CCT_OFFERS")
                    End If
                End If
            End If

        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), "Dreamy Kitchen CRM", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cmdPrintOffer_Click(sender As Object, e As EventArgs) Handles cmdPrintOffer.Click
        Dim report As New RepCUSOfferKitchen()

        report.Parameters.Item(0).Value = sID
        report.CreateDocument()
        Dim report2 As New Rep_Offer2ndPage

        report2.CreateDocument()
        report.ModifyDocument(Sub(x)
                                  x.AddPages(report2.Pages)
                              End Sub)
        Dim printTool As New ReportPrintTool(report)
        printTool.ShowRibbonPreview()
    End Sub
End Class