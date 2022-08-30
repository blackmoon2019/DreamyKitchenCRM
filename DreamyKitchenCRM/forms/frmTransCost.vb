Imports System.Data.SqlClient
Imports DevExpress.XtraBars.Navigation
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls

Public Class frmTransCost
    Private FillCbo As New FillCombos
    Private Valid As New ValidateControls
    Private LoadForms As New FormLoader
    Private DBQ As New DBQueries
    Private Ctrl As DevExpress.XtraGrid.Views.Grid.GridView
    Private Frm As DevExpress.XtraEditors.XtraForm
    Private CtrlCombo As DevExpress.XtraEditors.LookUpEdit
    Private CalledFromCtrl As Boolean
    Private FScrollerExist As Boolean = False
    Private sID As String
    Public Mode As Byte
    Private Structure Cost_Prices
        'ΕΡΜΑΡΙΑ ΒΑΣΕΩΣ
        Dim VDoorPrice1 As Double
        Dim VDoorPrice2 As Double
        Dim Vtrm1 As Double
        Dim Vtrm2 As Double
        Dim VFinalPrice1 As Double
        Dim VFinalPrice2 As Double
        Dim VTotal As Double
        Dim VDoorType1 As Guid
        Dim VDoorType2 As Guid
        'ΕΡΜΑΡΙΑ ΚΡΕΜΑΣΤΑ
        Dim KDoorPrice1 As Double
        Dim KDoorPrice2 As Double
        Dim Ktrm1 As Double
        Dim Ktrm2 As Double
        Dim KFinalPrice1 As Double
        Dim KFinalPrice2 As Double
        Dim KTotal As Double
        Dim KDoorType1 As Guid
        Dim KDoorType2 As Guid
        'ΕΡΜΑΡΙΑ ΥΨΗΛΑ
        Dim YDoorPrice1 As Double
        Dim YDoorPrice2 As Double
        Dim Ytrm1 As Double
        Dim Ytrm2 As Double
        Dim YFinalPrice1 As Double
        Dim YFinalPrice2 As Double
        Dim YTotal As Double
        Dim YDoorType1 As Guid
        Dim YDoorType2 As Guid
        'STANDAR ΕΞΟΔΑ ΚΟΥΖΙΝΑΣ
        Dim KMeasurement As Double
        Dim KTransp As Double
        Dim KRemove As Double
        Dim KPartofVat As Double
        'STANDAR ΕΞΟΔΑ ΝΤΟΥΛΑΠΑΣ
        Dim CMeasurement As Double
        Dim CTransp As Double
        Dim CRemove As Double
        Dim CPartofVat As Double
        'STANDAR ΕΞΟΔΑ ΠΟΡΤΑΣ
        Dim DMeasurement As Double
        Dim DTransp As Double
        Dim DRemove As Double
        Dim DPartofVat As Double
        'STANDAR ΕΙΔΙΚΩΝ ΚΑΤΑΣΚΕΥΩΝ
        Dim SCMeasurement As Double
        Dim SCTransp As Double
        Dim SCRemove As Double
        Dim SCPartofVat As Double
        'Γενικό σύνολο έργου
        Dim GenTot As Double
        ' ΤΟ ΕΡΓΟ ΑΦΟΡΑ
        Dim AgreementID As Guid
        Dim Kitchen As Boolean
        Dim Closet As Boolean
        Dim Doors As Boolean
        Dim SC As Boolean
    End Structure
    Private CostPrices As New Cost_Prices
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

    Private Sub frmTransCost_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim Prog_Prop As New ProgProp
        Prog_Prop.GetProgPROSF()
        'TODO: This line of code loads data into the 'DreamyKitchenDataSet.vw_COLORSBOX' table. You can move, or remove it, as needed.
        Me.Vw_COLORSBOXTableAdapter.Fill(Me.DreamyKitchenDataSet.vw_COLORSBOX)
        'TODO: This line of code loads data into the 'DreamyKitchenDataSet.vw_CCT' table. You can move, or remove it, as needed.
        Me.Vw_CCTTableAdapter.Fill(Me.DreamyKitchenDataSet.vw_CCT)
        'TODO: This line of code loads data into the 'DreamyKitchenDataSet.vw_SALERS' table. You can move, or remove it, as needed.
        Me.Vw_SALERSTableAdapter.Fill(Me.DreamyKitchenDataSet.vw_SALERS)
        XtraTabPage1.Visible = False

        Select Case Mode
            Case FormMode.NewRecord
                txtCode.Text = DBQ.GetNextId("TRANSCOST")
                cboEMP.EditValue = System.Guid.Parse(UserProps.ID.ToString.ToUpper)
                TileNavPane1.Enabled = False
            Case FormMode.EditRecord
                LoadForms.LoadForm(LayoutControl1, "Select * from TRANSCOST where id = " & toSQLValueS(sID))
                TileNavPane1.Enabled = True
        End Select

        Me.CenterToScreen()
        cmdSave.Enabled = IIf(Mode = FormMode.NewRecord, UserProps.AllowInsert, UserProps.AllowEdit)
    End Sub

    Private Sub TErmaria_ElementClick(sender As Object, e As NavElementEventArgs) Handles TErmaria.ElementClick
        XtraTabPage1.Visible = True
        Maintab.SelectedTabPage = XtraTabPage1
    End Sub
    Private Sub TKitchen_ElementClick(sender As Object, e As NavElementEventArgs) Handles TKitchen.ElementClick
        Maintab.SelectedTabPage = XtraTabPage7
    End Sub

    Private Sub TCloset_ElementClick(sender As Object, e As NavElementEventArgs) Handles TCloset.ElementClick
        Maintab.SelectedTabPage = XtraTabPage8
        XtraTabPage8.Visible = True
    End Sub

    Private Sub TDoor_ElementClick(sender As Object, e As NavElementEventArgs) Handles TDoor.ElementClick
        Maintab.SelectedTabPage = XtraTabPage9
        XtraTabPage9.Visible = True
    End Sub

    Private Sub TVaseos_ElementClick(sender As Object, e As NavElementEventArgs)
        Maintab.SelectedTabPage = XtraTabPage1
        XtraTabPage1.Visible = True
    End Sub


    Private Sub TYpsila_ElementClick(sender As Object, e As NavElementEventArgs)
        Maintab.SelectedTabPage = XtraTabPage3
        XtraTabPage3.Visible = True
    End Sub

    Private Sub cboCUS_EditValueChanged(sender As Object, e As EventArgs) Handles cboCUS.EditValueChanged
        Dim sCusID As String
        If cboCUS.EditValue Is Nothing Then sCusID = toSQLValueS(Guid.Empty.ToString) Else sCusID = toSQLValueS(cboCUS.EditValue.ToString)
        Dim sSQL As New System.Text.StringBuilder
        sSQL.AppendLine("Select T.id,FullTranshDescription,Description
                        from vw_TRANSH t
                        where  T.cusid = " & sCusID & "order by description")
        FillCbo.TRANSH(cboTRANSH, sSQL)
    End Sub

    Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click
        Dim sResult As Boolean
        Dim sGuid As String
        Try
            If Valid.ValidateForm(LayoutControl1) Then
                If CostPrices.AgreementID.ToString = "" Then
                    XtraMessageBox.Show("Για να γίνει κοστολόγηση έργου πρέπει πρώτα να καταχωρηθεί Ιδ. Συμφωνητικό.", "Dreamy Kitchen CRM", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If

                Select Case Mode
                    Case FormMode.NewRecord
                        sGuid = System.Guid.NewGuid.ToString
                        sResult = DBQ.InsertNewData(DBQueries.InsertMode.OneLayoutControl, "TRANSCOST", LayoutControl1,,, sGuid, True)
                        sID = sGuid
                    Case FormMode.EditRecord
                        sResult = DBQ.UpdateNewData(DBQueries.InsertMode.OneLayoutControl, "TRANSCOST", LayoutControl1,,, sID, True)
                End Select

                If FScrollerExist = True Then
                    Dim form As frmScroller = Frm
                    form.LoadRecords("vw_TRANSCOST")
                End If

                If sResult = True Then
                    TileNavPane1.Enabled = True
                    XtraMessageBox.Show("Η εγγραφή αποθηκέυτηκε με επιτυχία", "Dreamy Kitchen CRM", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Dim sSQL As New System.Text.StringBuilder
                    If CostPrices.Kitchen = True And Mode = FormMode.NewRecord Then Dim oCmd As New SqlCommand("INSERT INTO TRANSCOST_K (transCostID) SELECT " & toSQLValueS(sID), CNDB) : oCmd.ExecuteNonQuery()
                    If Mode = FormMode.NewRecord Then Mode = FormMode.EditRecord
                End If
            End If

        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), "Dreamy Kitchen CRM", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub frmTransCost_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        If Me.WindowState = FormWindowState.Maximized Then frmMain.XtraTabbedMdiManager1.Dock(Me, frmMain.XtraTabbedMdiManager1)
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
    Private Sub cboTRANSH_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles cboTRANSH.ButtonClick
        Select Case e.Button.Index
            Case 1 : If UserProps.ID.ToString.ToUpper = "3F9DC32E-BE5B-4D46-A13C-EA606566CF32" Then cboTRANSH.EditValue = Nothing : ManageTRANSH()
            Case 2 : If UserProps.ID.ToString.ToUpper = "3F9DC32E-BE5B-4D46-A13C-EA606566CF32" Then If cboTRANSH.EditValue <> Nothing Then ManageTRANSH()
            Case 3 : cboTRANSH.EditValue = Nothing
        End Select
    End Sub
    Private Sub ManageTRANSH()
        Dim form1 As frmTransactions = New frmTransactions()
        form1.Text = "Χρεωπιστώσεις Πελατών"
        form1.CallerControl = cboTRANSH
        form1.CalledFromControl = True
        form1.MdiParent = frmMain
        If cboTRANSH.EditValue <> Nothing Then
            form1.ID = cboTRANSH.EditValue.ToString
            form1.Mode = FormMode.EditRecord
        End If
        frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(form1), New Point(CInt(form1.Parent.ClientRectangle.Width / 2 - form1.Width / 2), CInt(form1.Parent.ClientRectangle.Height / 2 - form1.Height / 2)))
        form1.Show()
    End Sub


    Private Sub cboCUS_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles cboCUS.ButtonClick
        Select Case e.Button.Index
            Case 1 : cboCUS.EditValue = Nothing : ManageCus()
            Case 2 : If cboCUS.EditValue <> Nothing Then ManageCus()
            Case 3 : cboCUS.EditValue = Nothing
        End Select
    End Sub
    Private Sub cboEMP_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles cboEMP.ButtonClick
        Select Case e.Button.Index
            Case 1 : If UserProps.ID.ToString.ToUpper = "3F9DC32E-BE5B-4D46-A13C-EA606566CF32" Then cboEMP.EditValue = Nothing : ManageEMP()
            Case 2 : If UserProps.ID.ToString.ToUpper = "3F9DC32E-BE5B-4D46-A13C-EA606566CF32" Then If cboEMP.EditValue <> Nothing Then ManageEMP()
            Case 3 : cboEMP.EditValue = Nothing
        End Select
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
    Private Sub ManageColors(ByVal CallerControl As LookUpEdit)
        Dim frmColors As frmColors = New frmColors
        Select Case CallerControl.Name
            'Case "cboGOLAColors" : frmColors.ColorCategory = "1FA658C9-A338-4805-B38F-7E6503A5CD25"
            Case "cboVBOXColors1", "cboVBOXColors2", "cboKBOXColors1", "cboKBOXColors2", "cboYBOXColors1", "cboYBOXColors2" : frmColors.ColorCategory = "40C7BFFB-43EB-48FB-A467-74C0BCBE09FA"
                'Case "cboVPVCColors", "cboKPVCColors", "cboYPVCColors" : frmColors.ColorCategory = "1226147D-2FF2-4076-B24D-92ABC8FB4663"
        End Select
        frmColors.Text = "Χρώματα"
        frmColors.CallerForm = "frmTransCost"
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

    Private Sub cboVBOXColors1_ButtonClick(sender As Object, e As ButtonPressedEventArgs)
        Select Case e.Button.Index
            Case 1 : cboVBOXColors1.EditValue = Nothing : ManageColors(cboVBOXColors1)
            Case 2 : If cboVBOXColors1.EditValue <> Nothing Then ManageColors(cboVBOXColors1)
            Case 3 : cboVBOXColors1.EditValue = Nothing
        End Select
    End Sub
    'Private Sub cboVBOXColors2_ButtonClick(sender As Object, e As ButtonPressedEventArgs)
    '    Select Case e.Button.Index
    '        Case 1 : cboVBOXColors2.EditValue = Nothing : ManageColors(cboVBOXColors2)
    '        Case 2 : If cboVBOXColors2.EditValue <> Nothing Then ManageColors(cboVBOXColors2)
    '        Case 3 : cboVBOXColors2.EditValue = Nothing
    '    End Select
    'End Sub
    'Private Sub cboVBOXColors1_EditValueChanged(sender As Object, e As EventArgs)
    '    If cboVType1.SelectedIndex = -1 Then Exit Sub
    '    Dim sSQL = New System.Text.StringBuilder
    '    sSQL.AppendLine("Select id,name,price from vw_DOOR_TYPE where type = " & cboVType1.SelectedIndex & " and doorColorID = " & toSQLValueS(cboVBOXColors1.EditValue.ToString))
    '    FillCbo.DOOR_TYPE(cboVDoorType1, sSQL)
    '    cboVDoorType1.Enabled = True
    'End Sub

    'Private Sub cboVType1_ButtonClick(sender As Object, e As ButtonPressedEventArgs)
    '    Select Case e.Button.Index
    '        Case 1 : cboVType1.EditValue = Nothing : cboVBOXColors1.EditValue = Nothing : CostPrices.VDoorPrice1 = 0
    '    End Select
    'End Sub
    'Private Sub cboVType2_ButtonClick(sender As Object, e As ButtonPressedEventArgs)
    '    Select Case e.Button.Index
    '        Case 1 : cboVType2.EditValue = Nothing : cboVBOXColors2.EditValue = Nothing : CostPrices.VDoorPrice2 = 0
    '    End Select
    'End Sub

    'Private Sub cboVBOXColors2_EditValueChanged(sender As Object, e As EventArgs)
    '    If cboVType2.SelectedIndex = -1 Then Exit Sub
    '    Dim sSQL = New System.Text.StringBuilder
    '    sSQL.AppendLine("Select id,name,price from vw_DOOR_TYPE where type = " & cboVType2.SelectedIndex & " and doorColorID = " & toSQLValueS(cboVBOXColors2.EditValue.ToString))
    '    FillCbo.DOOR_TYPE(cboVDoorType2, sSQL)
    '    cboVDoorType2.Enabled = True
    'End Sub

    'Private Sub cboVType1_EditValueChanged(sender As Object, e As EventArgs)
    '    cboVBOXColors1.Enabled = True
    'End Sub

    'Private Sub cboVType2_EditValueChanged(sender As Object, e As EventArgs)
    '    cboVBOXColors2.Enabled = True
    'End Sub

    Private Sub cboVDoorType1_EditValueChanged(sender As Object, e As EventArgs) Handles cboVDoorType1.EditValueChanged
        CostPrices.VDoorPrice1 = cboVDoorType1.GetColumnValue("price")
        txtVDoorPrice1.EditValue = CostPrices.VDoorPrice1
    End Sub

    Private Sub cboVDoorType2_EditValueChanged(sender As Object, e As EventArgs) Handles cboVDoorType2.EditValueChanged
        CostPrices.VDoorPrice2 = cboVDoorType2.GetColumnValue("price")
        txtVDoorPrice2.EditValue = CostPrices.VDoorPrice2
    End Sub

    Private Sub Vtrm1_EditValueChanged(sender As Object, e As EventArgs) Handles Vtrm1.EditValueChanged
        CostPrices.Vtrm1 = Vtrm1.EditValue
        CostPrices.VFinalPrice1 = CostPrices.Vtrm1 * CostPrices.VDoorPrice1
        txtvPrice1.EditValue = CostPrices.VFinalPrice1
    End Sub

    Private Sub Vtrm2_EditValueChanged(sender As Object, e As EventArgs) Handles Vtrm2.EditValueChanged
        CostPrices.Vtrm2 = Vtrm2.EditValue
        CostPrices.VFinalPrice2 = CostPrices.Vtrm2 * CostPrices.VDoorPrice2
        txtvPrice2.EditValue = CostPrices.VFinalPrice2
    End Sub

    Private Sub txtvPrice1_EditValueChanged(sender As Object, e As EventArgs) Handles txtvPrice1.EditValueChanged
        CostPrices.VTotal = CostPrices.VFinalPrice1 + CostPrices.VFinalPrice2
        txtVTotal.EditValue = CostPrices.VTotal
    End Sub

    Private Sub txtvPrice2_EditValueChanged(sender As Object, e As EventArgs) Handles txtvPrice2.EditValueChanged
        CostPrices.VTotal = CostPrices.VFinalPrice1 + CostPrices.VFinalPrice2
        txtVTotal.EditValue = CostPrices.VTotal
    End Sub

    'Private Sub cboKBOXColors1_ButtonClick(sender As Object, e As ButtonPressedEventArgs)
    '    Select Case e.Button.Index
    '        Case 1 : cboKBOXColors1.EditValue = Nothing : ManageColors(cboKBOXColors1)
    '        Case 2 : If cboKBOXColors1.EditValue <> Nothing Then ManageColors(cboKBOXColors1)
    '        Case 3 : cboKBOXColors1.EditValue = Nothing
    '    End Select
    'End Sub
    'Private Sub cboKBOXColors2_ButtonClick(sender As Object, e As ButtonPressedEventArgs)
    '    Select Case e.Button.Index
    '        Case 1 : cboKBOXColors2.EditValue = Nothing : ManageColors(cboKBOXColors2)
    '        Case 2 : If cboKBOXColors2.EditValue <> Nothing Then ManageColors(cboKBOXColors2)
    '        Case 3 : cboKBOXColors2.EditValue = Nothing
    '    End Select
    'End Sub
    'Private Sub cboKBOXColors1_EditValueChanged(sender As Object, e As EventArgs)
    '    If cboKType1.SelectedIndex = -1 Then Exit Sub
    '    Dim sSQL = New System.Text.StringBuilder
    '    sSQL.AppendLine("Select id,name,price from vw_DOOR_TYPE where type = " & cboKType1.SelectedIndex & " and doorColorID = " & toSQLValueS(cboKBOXColors1.EditValue.ToString))
    '    FillCbo.DOOR_TYPE(cboKDoorType1, sSQL)
    '    cboKDoorType1.Enabled = True
    'End Sub

    'Private Sub cboKType1_ButtonClick(sender As Object, e As ButtonPressedEventArgs)
    '    Select Case e.Button.Index
    '        Case 1 : cboKType1.EditValue = Nothing : cboKBOXColors1.EditValue = Nothing : CostPrices.KDoorPrice1 = 0
    '    End Select
    'End Sub
    'Private Sub cboKType2_ButtonClick(sender As Object, e As ButtonPressedEventArgs)
    '    Select Case e.Button.Index
    '        Case 1 : cboKType2.EditValue = Nothing : cboKBOXColors2.EditValue = Nothing : CostPrices.KDoorPrice2 = 0
    '    End Select
    'End Sub

    'Private Sub cboKBOXColors2_EditValueChanged(sender As Object, e As EventArgs)
    '    If cboKType2.SelectedIndex = -1 Then Exit Sub
    '    Dim sSQL = New System.Text.StringBuilder
    '    sSQL.AppendLine("Select id,name,price from vw_DOOR_TYPE where type = " & cboKType2.SelectedIndex & " and doorColorID = " & toSQLValueS(cboKBOXColors2.EditValue.ToString))
    '    FillCbo.DOOR_TYPE(cboKDoorType2, sSQL)
    '    cboKDoorType2.Enabled = True
    'End Sub

    'Private Sub cboKType1_EditValueChanged(sender As Object, e As EventArgs)
    '    cboKBOXColors1.Enabled = True
    'End Sub

    'Private Sub cboKType2_EditValueChanged(sender As Object, e As EventArgs)
    '    cboKBOXColors2.Enabled = True
    'End Sub

    Private Sub cboKDoorType1_EditValueChanged(sender As Object, e As EventArgs)
        CostPrices.KDoorPrice1 = cboKDoorType1.GetColumnValue("price")
        txtKDoorPrice1.EditValue = CostPrices.KDoorPrice1
    End Sub

    Private Sub cboKDoorType2_EditValueChanged(sender As Object, e As EventArgs)
        CostPrices.KDoorPrice2 = cboKDoorType2.GetColumnValue("price")
        txtKDoorPrice2.EditValue = CostPrices.KDoorPrice2
    End Sub

    Private Sub Ktrm1_EditValueChanged(sender As Object, e As EventArgs)
        CostPrices.Ktrm1 = Ktrm1.EditValue
        CostPrices.KFinalPrice1 = CostPrices.Ktrm1 * CostPrices.KDoorPrice1
        txtKPrice1.EditValue = CostPrices.KFinalPrice1
    End Sub

    Private Sub Ktrm2_EditValueChanged(sender As Object, e As EventArgs)
        CostPrices.Ktrm2 = Ktrm2.EditValue
        CostPrices.KFinalPrice2 = CostPrices.Ktrm2 * CostPrices.KDoorPrice2
        txtKPrice2.EditValue = CostPrices.KFinalPrice2
    End Sub

    'Private Sub txtKPrice1_EditValueChanged(sender As Object, e As EventArgs)
    '    CostPrices.KTotal = CostPrices.KFinalPrice1 + CostPrices.KFinalPrice2
    '    txtKTotal.EditValue = CostPrices.KTotal
    'End Sub

    'Private Sub txtKPrice2_EditValueChanged(sender As Object, e As EventArgs)
    '    CostPrices.KTotal = CostPrices.KFinalPrice1 + CostPrices.KFinalPrice2
    '    txtKTotal.EditValue = CostPrices.KTotal
    'End Sub

    'Private Sub cboYBOXColors1_ButtonClick(sender As Object, e As ButtonPressedEventArgs)
    '    Select Case e.Button.Index
    '        Case 1 : cboYBOXColors1.EditValue = Nothing : ManageColors(cboYBOXColors1)
    '        Case 2 : If cboYBOXColors1.EditValue <> Nothing Then ManageColors(cboYBOXColors1)
    '        Case 3 : cboYBOXColors1.EditValue = Nothing
    '    End Select
    'End Sub
    'Private Sub cboYBOXColors2_ButtonClick(sender As Object, e As ButtonPressedEventArgs)
    '    Select Case e.Button.Index
    '        Case 1 : cboYBOXColors2.EditValue = Nothing : ManageColors(cboYBOXColors2)
    '        Case 2 : If cboYBOXColors2.EditValue <> Nothing Then ManageColors(cboYBOXColors2)
    '        Case 3 : cboYBOXColors2.EditValue = Nothing
    '    End Select
    'End Sub
    'Private Sub cboYBOXColors1_EditValueChanged(sender As Object, e As EventArgs)
    '    If cboYType1.SelectedIndex = -1 Then Exit Sub
    '    Dim sSQL = New System.Text.StringBuilder
    '    sSQL.AppendLine("Select id,name,price from vw_DOOR_TYPE where type = " & cboYType1.SelectedIndex & " and doorColorID = " & toSQLValueS(cboYBOXColors1.EditValue.ToString))
    '    FillCbo.DOOR_TYPE(cboYDoorType1, sSQL)
    '    cboYDoorType1.Enabled = True
    'End Sub

    'Private Sub cboYType1_ButtonClick(sender As Object, e As ButtonPressedEventArgs)
    '    Select Case e.Button.Index
    '        Case 1 : cboYType1.EditValue = Nothing : cboYBOXColors1.EditValue = Nothing : CostPrices.KDoorPrice1 = 0
    '    End Select
    'End Sub
    'Private Sub cboYType2_ButtonClick(sender As Object, e As ButtonPressedEventArgs)
    '    Select Case e.Button.Index
    '        Case 1 : cboYType2.EditValue = Nothing : cboYBOXColors2.EditValue = Nothing : CostPrices.KDoorPrice2 = 0
    '    End Select
    'End Sub

    'Private Sub cboYBOXColors2_EditValueChanged(sender As Object, e As EventArgs)
    '    If cboYType2.SelectedIndex = -1 Then Exit Sub
    '    Dim sSQL = New System.Text.StringBuilder
    '    sSQL.AppendLine("Select id,name,price from vw_DOOR_TYPE where type = " & cboYType2.SelectedIndex & " and doorColorID = " & toSQLValueS(cboYBOXColors2.EditValue.ToString))
    '    FillCbo.DOOR_TYPE(cboYDoorType2, sSQL)
    '    cboYDoorType2.Enabled = True
    'End Sub

    'Private Sub cboYType1_EditValueChanged(sender As Object, e As EventArgs)
    '    cboYBOXColors1.Enabled = True
    'End Sub

    'Private Sub cboYType2_EditValueChanged(sender As Object, e As EventArgs)
    '    cboYBOXColors2.Enabled = True
    'End Sub

    Private Sub cboYDoorType1_EditValueChanged(sender As Object, e As EventArgs)
        CostPrices.YDoorPrice1 = cboYDoorType1.GetColumnValue("price")
        txtYDoorPrice1.EditValue = CostPrices.YDoorPrice1
    End Sub

    Private Sub cboYDoorType2_EditValueChanged(sender As Object, e As EventArgs)
        CostPrices.YDoorPrice2 = cboYDoorType2.GetColumnValue("price")
        txtYDoorPrice2.EditValue = CostPrices.YDoorPrice2
    End Sub

    Private Sub Ytrm1_EditValueChanged(sender As Object, e As EventArgs)
        CostPrices.Ytrm1 = Ytrm1.EditValue
        CostPrices.YFinalPrice1 = CostPrices.Ytrm1 * CostPrices.YDoorPrice1
        txtYPrice1.EditValue = CostPrices.YFinalPrice1
    End Sub

    Private Sub ytrm2_EditValueChanged(sender As Object, e As EventArgs)
        CostPrices.Ytrm2 = Ytrm2.EditValue
        CostPrices.YFinalPrice2 = CostPrices.Ytrm2 * CostPrices.YDoorPrice2
        txtYPrice2.EditValue = CostPrices.YFinalPrice2
    End Sub

    'Private Sub txtYPrice1_EditValueChanged(sender As Object, e As EventArgs)
    '    CostPrices.YTotal = CostPrices.YFinalPrice1 + CostPrices.YFinalPrice2
    '    txtYTotal.EditValue = CostPrices.YTotal
    'End Sub

    'Private Sub txtYPrice2_EditValueChanged(sender As Object, e As EventArgs)
    '    CostPrices.YTotal = CostPrices.YFinalPrice1 + CostPrices.YFinalPrice2
    '    txtYTotal.EditValue = CostPrices.YTotal
    'End Sub

    Private Sub txtYTotal_EditValueChanged(sender As Object, e As EventArgs)
        CostPrices.GenTot = CostPrices.VTotal + CostPrices.KTotal + CostPrices.YTotal
        txtGenTot.EditValue = CostPrices.GenTot
    End Sub

    Private Sub txtVTotal_EditValueChanged(sender As Object, e As EventArgs) Handles txtVTotal.EditValueChanged
        CostPrices.GenTot = CostPrices.VTotal + CostPrices.KTotal + CostPrices.YTotal
        txtGenTot.EditValue = CostPrices.GenTot
    End Sub
    Private Sub txtKTotal_EditValueChanged(sender As Object, e As EventArgs)
        CostPrices.GenTot = CostPrices.VTotal + CostPrices.KTotal + CostPrices.YTotal
        txtGenTot.EditValue = CostPrices.GenTot
    End Sub

    Private Sub cboTRANSH_EditValueChanged(sender As Object, e As EventArgs) Handles cboTRANSH.EditValueChanged
        Dim sSQL As String
        sSQL = "Select A.ID as AgreementID,kitchen,closet,doors,sc,
                ISNULL(K.PartOfVat, 0) As KPartOfVat,
                ISNULL(C.PartOfVat, 0) As CPartOfVat,
                ISNULL(D.PartOfVat, 0) As DPartOfVat,
                ISNULL(sc.PartOfVat, 0) As scPartOfVat,
				ISNULL(k.Measurement, 0) as KMeasurement,
				ISNULL(c.Measurement, 0) as CMeasurement,
				ISNULL(d.Measurement, 0) as DMeasurement,
				ISNULL(sc.Measurement, 0) as SCMeasurement,
				ISNULL(k.remove, 0) as KRemove,
				ISNULL(c.remove, 0) as CRemove,
				ISNULL(d.remove, 0) as DRemove,
				ISNULL(sc.Remove, 0) as SCRemove,
				ISNULL(k.ExtraTransp , 0) as KTransp,
				ISNULL(c.ExtraTransp, 0) as CTransp,
				ISNULL(d.ExtraTransp, 0) as DTransp,
				ISNULL(sc.ExtraTransp, 0) as SCTransp,
                ISNULL(k.VDoorTypeID ,'00000000-0000-0000-0000-000000000000') AS VDoorTypeID, 
	            ISNULL(k.KDoorTypeID ,'00000000-0000-0000-0000-000000000000') AS KDoorTypeID, 
	            ISNULL(k.YDoorTypeID ,'00000000-0000-0000-0000-000000000000') AS YDoorTypeID, 
	            ISNULL(k.KDoorTypeID2,'00000000-0000-0000-0000-000000000000') AS KDoorTypeID2, 
                ISNULL(k.VDoorTypeID2,'00000000-0000-0000-0000-000000000000') AS VDoorTypeID2, 
	            ISNULL(k.YDoorTypeID2,'00000000-0000-0000-0000-000000000000') AS YDoorTypeID2,
				ISNULL((SELECT PRICE FROM DOOR_TYPE WHERE ID = K.VDoorTypeID),0) AS VDoorPrice1,
				ISNULL((SELECT PRICE FROM DOOR_TYPE WHERE ID = K.VDoorTypeID2),0) AS VDoorPrice2,
				ISNULL((SELECT PRICE FROM DOOR_TYPE WHERE ID = K.KDoorTypeID),0) AS KDoorPrice1,
				ISNULL((SELECT PRICE FROM DOOR_TYPE WHERE ID = K.KDoorTypeID2),0) AS KDoorPrice2,
				ISNULL((SELECT PRICE FROM DOOR_TYPE WHERE ID = K.YDoorTypeID),0) AS YDoorPrice1,
				ISNULL((SELECT PRICE FROM DOOR_TYPE WHERE ID = K.YDoorTypeID2),0) AS YDoorPrice2
                From AGREEMENT  A
                INNER Join TRANSH T ON T.ID = A.transhID 
                Left Join [dbo].[CCT_ORDERS_KITCHEN] K on K.transhID  = t.ID 
                Left Join [dbo].[CCT_ORDERS_CLOSET]  C on C.transhID  = t.ID 
                Left Join [dbo].[CCT_ORDERS_DOOR]   D on D.transhID  = t.ID 
                Left Join [dbo].[CCT_ORDERS_SPECIAL_CONSTR]   SC on SC.transhID  = t.ID  " &
                "where T.ID = " & toSQLValueS(cboTRANSH.EditValue.ToString)
        Dim cmd As SqlCommand
        Dim sdr As SqlDataReader
        cmd = New SqlCommand(sSQL, CNDB)
        sdr = cmd.ExecuteReader()
        If (sdr.Read() = True) Then

            'ΕΠΙΛΟΓΕΣ ΕΡΓΟΥ(ΚΟΥΖΙΝΑ-ΝΤΟΥΛΑΠΑ-ΠΟΡΤΑ-ΕΙΔΙΚΗ ΚΑΤΑΣΚΕΥΗ)
            CostPrices.Kitchen = sdr.GetBoolean(sdr.GetOrdinal("kitchen"))
            CostPrices.Closet = sdr.GetBoolean(sdr.GetOrdinal("closet"))
            CostPrices.Doors = sdr.GetBoolean(sdr.GetOrdinal("doors"))
            CostPrices.SC = sdr.GetBoolean(sdr.GetOrdinal("sc"))
            CostPrices.AgreementID = sdr.GetGuid(sdr.GetOrdinal("AgreementID"))

            If CostPrices.Kitchen = True Then TileNavPane1.Categories.Item(0).Tile.Visible = True Else TileNavPane1.Categories.Item(0).Tile.Visible = False
            If CostPrices.Closet = True Then TileNavPane1.Categories.Item(1).Tile.Visible = True Else TileNavPane1.Categories.Item(1).Tile.Visible = False
            If CostPrices.Doors = True Then TileNavPane1.Categories.Item(2).Tile.Visible = True Else TileNavPane1.Categories.Item(2).Tile.Visible = False
            If CostPrices.SC = True Then TileNavPane1.Categories.Item(3).Tile.Visible = True Else TileNavPane1.Categories.Item(3).Tile.Visible = False

            '********************************* Κ Ο Υ Ζ Ι Ν Α**************************************
            'Β Α Σ Ε Ω Σ
            CostPrices.VDoorType1 = sdr.GetGuid(sdr.GetOrdinal("VDoorTypeID")) : cboVDoorType1.EditValue = CostPrices.VDoorType1
            CostPrices.VDoorType2 = sdr.GetGuid(sdr.GetOrdinal("VDoorTypeID2")) : cboVDoorType2.EditValue = CostPrices.VDoorType2
            CostPrices.VDoorPrice1 = sdr.GetDecimal(sdr.GetOrdinal("VDoorPrice1")) : txtVDoorPrice1.EditValue = CostPrices.VDoorPrice1
            CostPrices.VDoorPrice2 = sdr.GetDecimal(sdr.GetOrdinal("VDoorPrice2")) : txtVDoorPrice2.EditValue = CostPrices.VDoorPrice2

            'Κ Ρ Ε Μ Α Σ Τ Α
            CostPrices.KDoorType1 = sdr.GetGuid(sdr.GetOrdinal("KDoorTypeID")) : cboKDoorType1.EditValue = CostPrices.KDoorType1
            CostPrices.KDoorType2 = sdr.GetGuid(sdr.GetOrdinal("KDoorTypeID2")) : cboKDoorType2.EditValue = CostPrices.KDoorType2
            CostPrices.KDoorPrice1 = sdr.GetDecimal(sdr.GetOrdinal("KDoorPrice1")) : txtKDoorPrice1.EditValue = CostPrices.KDoorPrice1
            CostPrices.KDoorPrice2 = sdr.GetDecimal(sdr.GetOrdinal("KDoorPrice2")) : txtKDoorPrice2.EditValue = CostPrices.KDoorPrice2

            'Υ Ψ Η Λ Α
            CostPrices.YDoorType1 = sdr.GetGuid(sdr.GetOrdinal("YDoorTypeID")) : cboYDoorType1.EditValue = CostPrices.YDoorType1
            CostPrices.YDoorType2 = sdr.GetGuid(sdr.GetOrdinal("YDoorTypeID2")) : cboYDoorType2.EditValue = CostPrices.YDoorType2
            CostPrices.YDoorPrice1 = sdr.GetDecimal(sdr.GetOrdinal("YDoorPrice1")) : txtYDoorPrice1.EditValue = CostPrices.YDoorPrice1
            CostPrices.YDoorPrice2 = sdr.GetDecimal(sdr.GetOrdinal("YDoorPrice2")) : txtYDoorPrice2.EditValue = CostPrices.YDoorPrice2

            ' ΜΕΤΑΦΟΡΑ
            CostPrices.KTransp = sdr.GetDecimal(sdr.GetOrdinal("KTransp")) : txtKtransport.EditValue = CostPrices.KTransp
            CostPrices.CTransp = sdr.GetDecimal(sdr.GetOrdinal("CTransp")) : txtCtransport.EditValue = CostPrices.CTransp
            CostPrices.DTransp = sdr.GetDecimal(sdr.GetOrdinal("DTransp")) : txtDtransport.EditValue = CostPrices.DTransp
            CostPrices.SCTransp = sdr.GetDecimal(sdr.GetOrdinal("SCTransp")) : txtSCtransport.EditValue = CostPrices.SCTransp


            ' ΣΥΜΦΩΝΗΘΕΝ ΦΠΑ
            CostPrices.KPartofVat = sdr.GetDecimal(sdr.GetOrdinal("KPartOfVat")) : txtKPartOfVat.EditValue = CostPrices.KPartofVat
            CostPrices.CPartofVat = sdr.GetDecimal(sdr.GetOrdinal("CPartOfVat")) : txtCPartOfVat.EditValue = CostPrices.CPartofVat
            CostPrices.DPartofVat = sdr.GetDecimal(sdr.GetOrdinal("DPartOfVat")) : txtDPartOfVat.EditValue = CostPrices.DPartofVat
            CostPrices.SCPartofVat = sdr.GetDecimal(sdr.GetOrdinal("scPartOfVat")) : txtSCPartOfVat.EditValue = CostPrices.SCPartofVat


            ' ΕΠΙΜΕΤΡΗΣΗ
            CostPrices.KMeasurement = sdr.GetDecimal(sdr.GetOrdinal("KMeasurement")) : txtKmeasurement.EditValue = CostPrices.KMeasurement
            CostPrices.CMeasurement = sdr.GetDecimal(sdr.GetOrdinal("CMeasurement")) : txtCmeasurement.EditValue = CostPrices.CMeasurement
            CostPrices.DMeasurement = sdr.GetDecimal(sdr.GetOrdinal("DMeasurement")) : txtDmeasurement.EditValue = CostPrices.DMeasurement
            CostPrices.SCMeasurement = sdr.GetDecimal(sdr.GetOrdinal("SCMeasurement")) : txtDmeasurement.EditValue = CostPrices.SCMeasurement


            ' ΑΠΟΞΥΛΩΣΗ
            CostPrices.KRemove = sdr.GetDecimal(sdr.GetOrdinal("KRemove")) : txtKRemove.EditValue = CostPrices.KRemove
            CostPrices.CRemove = sdr.GetDecimal(sdr.GetOrdinal("CRemove")) : txtCRemove.EditValue = CostPrices.CRemove
            CostPrices.DRemove = sdr.GetDecimal(sdr.GetOrdinal("DRemove")) : txtDRemove.EditValue = CostPrices.DRemove
            CostPrices.SCRemove = sdr.GetDecimal(sdr.GetOrdinal("SCRemove")) : txtDRemove.EditValue = CostPrices.SCRemove


        End If
        sdr.Close()

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

    Private Sub cboVDoorType1_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboVDoorType1.ButtonClick
        Select Case e.Button.Index
            Case 1 : cboVDoorType1.EditValue = Nothing : ManageDoorType(cboVDoorType1)
            Case 2 : If cboVDoorType1.EditValue <> Nothing Then ManageDoorType(cboVDoorType1)
            Case 3 : cboVDoorType1.EditValue = Nothing
        End Select
    End Sub
    Private Sub cboVDoorType2_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboVDoorType2.ButtonClick
        Select Case e.Button.Index
            Case 2 : cboVDoorType2.EditValue = Nothing : ManageDoorType(cboVDoorType2)
            Case 2 : If cboVDoorType2.EditValue <> Nothing Then ManageDoorType(cboVDoorType2)
            Case 3 : cboVDoorType2.EditValue = Nothing
        End Select
    End Sub
    Private Sub cboKDoorType1_ButtonClick(sender As Object, e As ButtonPressedEventArgs)
        Select Case e.Button.Index
            Case 1 : cboKDoorType1.EditValue = Nothing : ManageDoorType(cboKDoorType1)
            Case 2 : If cboKDoorType1.EditValue <> Nothing Then ManageDoorType(cboKDoorType1)
            Case 3 : cboKDoorType1.EditValue = Nothing
        End Select
    End Sub
    Private Sub cboKDoorType2_ButtonClick(sender As Object, e As ButtonPressedEventArgs)
        Select Case e.Button.Index
            Case 2 : cboKDoorType2.EditValue = Nothing : ManageDoorType(cboKDoorType2)
            Case 2 : If cboKDoorType2.EditValue <> Nothing Then ManageDoorType(cboKDoorType2)
            Case 3 : cboKDoorType2.EditValue = Nothing
        End Select
    End Sub
    Private Sub cboYDoorType1_ButtonClick(sender As Object, e As ButtonPressedEventArgs)
        Select Case e.Button.Index
            Case 1 : cboYDoorType1.EditValue = Nothing : ManageDoorType(cboYDoorType1)
            Case 2 : If cboYDoorType1.EditValue <> Nothing Then ManageDoorType(cboYDoorType1)
            Case 3 : cboYDoorType1.EditValue = Nothing
        End Select
    End Sub
    Private Sub cboYDoorType2_ButtonClick(sender As Object, e As ButtonPressedEventArgs)
        Select Case e.Button.Index
            Case 2 : cboYDoorType2.EditValue = Nothing : ManageDoorType(cboYDoorType2)
            Case 2 : If cboYDoorType2.EditValue <> Nothing Then ManageDoorType(cboYDoorType2)
            Case 3 : cboYDoorType2.EditValue = Nothing
        End Select
    End Sub


End Class