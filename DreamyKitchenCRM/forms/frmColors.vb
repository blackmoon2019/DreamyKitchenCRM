Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls

Public Class frmColors
    Private sID As String
    Private sColorCategory As String
    Private Ctrl As DevExpress.XtraGrid.Views.Grid.GridView
    Private Frm As DevExpress.XtraEditors.XtraForm
    Public Mode As Byte
    Private Valid As New ValidateControls
    Private Log As New Transactions
    Private FillCbo As New FillCombos
    Private DBQ As New DBQueries
    Private LoadForms As New FormLoader
    Private Cls As New ClearControls
    Private CtrlCombo As DevExpress.XtraEditors.GridLookUpEdit
    Private CtrlComboLKUP As DevExpress.XtraEditors.LookUpEdit
    Private CalledFromCtrl As Boolean
    Private CallerFormName As String


    Public WriteOnly Property ID As String
        Set(value As String)
            sID = value
        End Set
    End Property
    Public WriteOnly Property ColorCategory As String
        Set(value As String)
            sColorCategory = value
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
    Public WriteOnly Property CallerControl As DevExpress.XtraEditors.GridLookUpEdit
        Set(value As DevExpress.XtraEditors.GridLookUpEdit)
            CtrlCombo = value
        End Set
    End Property
    Public WriteOnly Property CallerControlLKUP As DevExpress.XtraEditors.LookUpEdit
        Set(value As DevExpress.XtraEditors.LookUpEdit)
            CtrlComboLKUP = value
        End Set
    End Property

    Public WriteOnly Property CalledFromControl As Boolean
        Set(value As Boolean)
            CalledFromCtrl = value
        End Set
    End Property
    Public WriteOnly Property CallerForm As String
        Set(value As String)
            CallerFormName = value
        End Set
    End Property
    Private Sub cmdExit_Click(sender As Object, e As EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub

    Private Sub frmColors_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        If Me.WindowState = FormWindowState.Maximized Then frmMain.XtraTabbedMdiManager1.Dock(Me, frmMain.XtraTabbedMdiManager1)
    End Sub

    Private Sub frmColors_Load(sender As Object, e As EventArgs) Handles Me.Load
        FillCbo.COLORS_CAT(cboColorsCat)
        Select Case Mode
            Case FormMode.NewRecord
                txtCode.Text = DBQ.GetNextId("COLORS")
                If sColorCategory IsNot Nothing Then cboColorsCat.EditValue = System.Guid.Parse(sColorCategory)
            Case FormMode.EditRecord
                LoadForms.LoadForm(LayoutControl1, "Select * from vw_COLORS where id ='" + sID + "'")
        End Select
        Me.CenterToScreen()
        cmdSave.Enabled = IIf(Mode = FormMode.NewRecord, UserProps.AllowInsert, UserProps.AllowEdit)
        txtNam.Select()
    End Sub

    Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click
        Dim sResult As Boolean
        Dim sGuid As String
        Try
            If Valid.ValidateForm(LayoutControl1) Then
                Select Case Mode
                    Case FormMode.NewRecord
                        sGuid = System.Guid.NewGuid.ToString
                        sResult = DBQ.InsertData(LayoutControl1, "COLORS", sGuid)
                    Case FormMode.EditRecord
                        sResult = DBQ.UpdateData(LayoutControl1, "COLORS", sID)
                        sGuid = sID
                End Select
                If CalledFromCtrl Then
                    Dim sSQL As New System.Text.StringBuilder
                    Select Case CallerFormName
                        Case "frmErmaria"
                            Select Case CtrlCombo.Name
                                Case "cboPVCColors"
                                    frmErmaria.Vw_COLORSPVCTableAdapter.Fill(frmErmaria.DreamyKitchenDataSet.vw_COLORSPVC)
                                    CtrlCombo.Properties.DataSource = frmErmaria.VwCOLORSPVCBindingSource
                                Case "cboBOXColors"
                                    frmErmaria.Vw_COLORSBOXTableAdapter.Fill(frmErmaria.DreamyKitchenDataSet.vw_COLORSBOX)
                                    CtrlCombo.Properties.DataSource = frmErmaria.VwCOLORSBOXBindingSource
                            End Select
                        Case "frmOffer"
                            Select Case CtrlCombo.Name
                                Case "cboPVCColors"
                                    frmOffer.Vw_COLORSPVCTableAdapter.Fill(frmOffer.DreamyKitchenDataSet.vw_COLORSPVC)
                                    CtrlCombo.Properties.DataSource = frmOffer.VwCOLORSPVCBindingSource
                                Case "cboBOXColors"
                                    'TODO: This line of code loads data into the 'DreamyKitchenDataSet.vw_COLORSBOX' table. You can move, or remove it, as needed.
                                    frmOffer.Vw_COLORSBOXTableAdapter.Fill(frmOffer.DreamyKitchenDataSet.vw_COLORSBOX)
                                    CtrlCombo.Properties.DataSource = frmOffer.VwCOLORSBOXBindingSource
                            End Select
                        Case "frmCUSOrderKitchen"
                            Select Case CtrlComboLKUP.Name
                                Case "cboGOLAColors"
                                    frmCUSOfferOrderKitchen.Vw_COLORSGOLATableAdapter.Fill(frmCUSOfferOrderKitchen.DreamyKitchenDataSet.vw_COLORSGOLA)
                                    CtrlComboLKUP.Properties.DataSource = frmCUSOfferOrderKitchen.VwCOLORSGOLABindingSource
                                Case "cboVBOXColors", "cboKBOXColors", "cboYBOXColors"
                                    'TODO: This line of code loads data into the 'DreamyKitchenDataSet.vw_COLORSBOX' table. You can move, or remove it, as needed.
                                    'frmCUSOrderKitchen.Vw_COLORSBOXTableAdapter.Fill(frmCUSOrderKitchen.DreamyKitchenDataSet.vw_COLORSBOX)
                                   ' CtrlComboLKUP.Properties.DataSource = frmCUSOrderKitchen.VwCOLORSBOXBindingSource
                                Case "cboVPVCColors", "cboKPVCColors", "cboYPVCColors"
                                    'frmCUSOrderKitchen.Vw_COLORSPVCTableAdapter.Fill(frmCUSOrderKitchen.DreamyKitchenDataSet.vw_COLORSPVC)
                                    'CtrlComboLKUP.Properties.DataSource = frmCUSOrderKitchen.VwCOLORSPVCBindingSource
                            End Select
                        Case "frmCUSOfferOrderDoors"
                            frmCUSOfferOrderDoors.Vw_COLORSDOORSTableAdapter.Fill(frmCUSOfferOrderDoors.DreamyKitchenDataSet.vw_COLORSDOORS)
                            CtrlComboLKUP.Properties.DataSource = frmCUSOfferOrderDoors.VwCOLORSDOORSBindingSource
                        Case "frmCUSOrderCloset"
                            Select Case CtrlComboLKUP.Name
                                Case "cboBOXColors"
                                    'TODO: This line of code loads data into the 'DreamyKitchenDataSet.vw_COLORSBOX' table. You can move, or remove it, as needed.
                                    'frmCUSOrderCloset.Vw_COLORSBOXTableAdapter.Fill(frmCUSOrderCloset.DreamyKitchenDataSet.vw_COLORSBOX)
                                    'CtrlComboLKUP.Properties.DataSource = frmCUSOrderCloset.VwCOLORSBOXBindingSource
                                    'Case "cboPVCColors"
                                    '    frmCUSOrderCloset.Vw_COLORSPVCTableAdapter.Fill(frmCUSOrderCloset.DreamyKitchenDataSet.vw_COLORSPVC)
                                    '    CtrlComboLKUP.Properties.DataSource = frmCUSOrderCloset.VwCOLORSPVCBindingSource
                            End Select

                    End Select
                    If CtrlCombo Is Nothing Then
                        CtrlComboLKUP.EditValue = System.Guid.Parse(sGuid)
                    Else
                        CtrlCombo.EditValue = System.Guid.Parse(sGuid)
                    End If

                Else
                    Dim form As frmScroller = Frm
                    form.LoadRecords("vw_COLORS")
                End If
                txtCode.Text = DBQ.GetNextId("COLORS")
                txtNam.Select()
                If sResult = True Then
                    XtraMessageBox.Show("Η εγγραφή αποθηκέυτηκε με επιτυχία", "Dreamy Kitchen CRM", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    If Mode = FormMode.NewRecord Then
                        Cls.ClearCtrls(LayoutControl1)
                        txtCode.Text = DBQ.GetNextId("COLORS")
                        txtNam.Select()
                    End If
                End If
            End If

        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), "Dreamy Kitchen CRM", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub cboColorsCat_EditValueChanged(sender As Object, e As EventArgs) Handles cboColorsCat.EditValueChanged

    End Sub

    Private Sub cboColorsCat_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboColorsCat.ButtonClick
        Select Case e.Button.Index
            Case 1 : ManageColorCat()
            Case 2 : cboColorsCat.EditValue = Nothing
        End Select
    End Sub
    Private Sub ManageColorCat()
        Dim frmGen As frmGen = New frmGen
        frmGen.Text = "Κατηγορίες Χρωμάτων"
        frmGen.L1.Text = "Κωδικός"
        frmGen.L2.Text = "Κατηγορία"
        frmGen.DataTable = "COLORS_CAT"
        frmGen.CallerControl = cboColorsCat
        frmGen.CalledFromControl = True
        If cboColorsCat.EditValue <> Nothing Then frmGen.ID = cboColorsCat.EditValue.ToString
        frmGen.MdiParent = frmMain
        If cboColorsCat.EditValue <> Nothing Then frmGen.Mode = FormMode.EditRecord Else frmGen.Mode = FormMode.NewRecord
        frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(frmGen), New Point(CInt(frmGen.Parent.ClientRectangle.Width / 2 - frmGen.Width / 2), CInt(frmGen.Parent.ClientRectangle.Height / 2 - frmGen.Height / 2)))
        frmGen.Show()
    End Sub
End Class