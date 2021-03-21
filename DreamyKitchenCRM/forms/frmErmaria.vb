Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls

Public Class frmErmaria
    Private sID As String
    Private Ctrl As DevExpress.XtraGrid.Views.Grid.GridView
    Private Frm As DevExpress.XtraEditors.XtraForm
    Public Mode As Byte
    Private Valid As New ValidateControls
    Private Log As New Transactions
    Private FillCbo As New FillCombos
    Private DBQ As New DBQueries
    Private LoadForms As New FormLoader
    Private Cls As New ClearControls
    Private CtrlCombo As DevExpress.XtraEditors.LookUpEdit
    Private CalledFromCtrl As Boolean


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
    Private Sub cmdExit_Click(sender As Object, e As EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub

    Private Sub frmErmaria_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        If Me.WindowState = FormWindowState.Maximized Then frmMain.XtraTabbedMdiManager1.Dock(Me, frmMain.XtraTabbedMdiManager1)
    End Sub

    Private Sub frmErmaria_Load(sender As Object, e As EventArgs) Handles Me.Load
        'TODO: This line of code loads data into the 'DreamyKitchenDataSet.vw_COLORSPVC' table. You can move, or remove it, as needed.
        Me.Vw_COLORSPVCTableAdapter.Fill(Me.DreamyKitchenDataSet.vw_COLORSPVC)
        'TODO: This line of code loads data into the 'DreamyKitchenDataSet.vw_COLORSBOX' table. You can move, or remove it, as needed.
        Me.Vw_COLORSBOXTableAdapter.Fill(Me.DreamyKitchenDataSet.vw_COLORSBOX)
        'Κατηγορίες Ερμαρίων
        FillCbo.CAT_ERM(cboCategory)
        'Ερμάρια
        FillCbo.DOOR_TYPE(cboDoorType)
        'Διαστάσεις
        FillCbo.DIMENSION(cboDim)
        'Τύποι Υπολογισμών
        FillCbo.CALC(cboCalc)

        cboSides.Properties.Items.Add("Δεξί")
        cboSides.Properties.Items.Add("Αριστερό")
        Select Case Mode
            Case FormMode.NewRecord
                txtCode.Text = DBQ.GetNextId("ERM")
            Case FormMode.EditRecord
                LoadForms.LoadForm(LayoutControl1, "Select * from vw_ERM where id ='" + sID + "'")
        End Select
        Me.CenterToScreen()
        My.Settings.frmDoorType = Me.Location
        My.Settings.Save()
        cmdSave.Enabled = IIf(Mode = FormMode.NewRecord, UserProps.AllowInsert, UserProps.AllowEdit)
        txtCustomCode.Select()
    End Sub

    Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click
        Dim sResult As Boolean
        Dim sGuid As String
        Try
            If Valid.ValidateForm(LayoutControl1) Then
                Select Case Mode
                    Case FormMode.NewRecord
                        sGuid = System.Guid.NewGuid.ToString
                        sResult = DBQ.InsertData(LayoutControl1, "ERM", sGuid)
                    Case FormMode.EditRecord
                        sResult = DBQ.UpdateData(LayoutControl1, "ERM", sID)
                        sGuid = sID
                End Select
                If CalledFromCtrl Then
                    FillCbo.ERM(CtrlCombo)
                    CtrlCombo.EditValue = System.Guid.Parse(sGuid)
                Else
                    Dim form As frmScroller = Frm
                    form.LoadRecords("vw_ERM")
                End If
                txtCustomCode.Select()
                If sResult = True Then
                    XtraMessageBox.Show("Η εγγραφή αποθηκέυτηκε με επιτυχία", "Dreamy Kitchen CRM", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    If Mode = FormMode.NewRecord Then Cls.ClearCtrls(LayoutControl1) : txtCode.Text = DBQ.GetNextId("ERM")
                End If
            End If

        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), "Dreamy Kitchen CRM", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cboCategory_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboCategory.ButtonClick
        Select Case e.Button.Index
            Case 1 : ManageCAT()
            Case 2 : cboCategory.EditValue = Nothing
        End Select
    End Sub
    Private Sub ManageCAT()
        Dim frmGen As frmGen = New frmGen
        frmGen.Text = "Κατηγορίες Ερμαρίων"
        frmGen.L1.Text = "Κωδικός"
        frmGen.L2.Text = "Κατηγορία"
        frmGen.DataTable = "CAT_ERM"
        frmGen.CallerControl = cboCategory
        frmGen.CalledFromControl = True
        If cboCategory.EditValue <> Nothing Then frmGen.ID = cboCategory.EditValue.ToString
        frmGen.MdiParent = frmMain
        frmGen.L3.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        frmGen.L4.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        frmGen.L5.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        frmGen.L6.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        frmGen.L7.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        If cboCategory.EditValue <> Nothing Then frmGen.Mode = FormMode.EditRecord Else frmGen.Mode = FormMode.NewRecord
        frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(frmGen), New Point(CInt(frmGen.Parent.ClientRectangle.Width / 2 - frmGen.Width / 2), CInt(frmGen.Parent.ClientRectangle.Height / 2 - frmGen.Height / 2)))
        frmGen.Show()
    End Sub

    Private Sub cboDoorType_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboDoorType.ButtonClick
        Select Case e.Button.Index
            Case 1 : ManageDoorType()
            Case 2 : cboDoorType.EditValue = Nothing
        End Select
    End Sub
    Private Sub ManageDoorType()
        Dim frmDoorType As frmDoorType = New frmDoorType
        frmDoorType.CallerControl = cboDoorType
        frmDoorType.CalledFromControl = True
        If cboDoorType.EditValue <> Nothing Then frmDoorType.ID = cboDoorType.EditValue.ToString
        frmDoorType.MdiParent = frmMain
        If cboDoorType.EditValue <> Nothing Then frmDoorType.Mode = FormMode.EditRecord Else frmDoorType.Mode = FormMode.NewRecord
        frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(frmDoorType), New Point(CInt(frmDoorType.Parent.ClientRectangle.Width / 2 - frmDoorType.Width / 2), CInt(frmDoorType.Parent.ClientRectangle.Height / 2 - frmDoorType.Height / 2)))
        frmDoorType.Show()
    End Sub
    Private Sub cboPVCColors_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboPVCColors.ButtonClick
        Select Case e.Button.Index
            Case 1 : ManagePVCColors()
            Case 2 : cboPVCColors.EditValue = Nothing
        End Select
    End Sub
    Private Sub ManagePVCColors()
        Dim frmColors As frmColors = New frmColors
        frmColors.CallerForm = Me.Name
        frmColors.CallerControl = cboPVCColors
        frmColors.CalledFromControl = True
        If cboPVCColors.EditValue <> Nothing Then frmColors.ID = cboPVCColors.EditValue.ToString
        frmColors.MdiParent = frmMain
        If cboPVCColors.EditValue <> Nothing Then frmColors.Mode = FormMode.EditRecord Else frmColors.Mode = FormMode.NewRecord
        frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(frmColors), New Point(CInt(frmColors.Parent.ClientRectangle.Width / 2 - frmColors.Width / 2), CInt(frmColors.Parent.ClientRectangle.Height / 2 - frmColors.Height / 2)))
        frmColors.Show()
    End Sub

    Private Sub cboBOXColors_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboBOXColors.ButtonClick
        Select Case e.Button.Index
            Case 1 : ManageBOXColors()
            Case 2 : cboBOXColors.EditValue = Nothing
        End Select
    End Sub
    Private Sub ManageBOXColors()
        Dim frmColors As frmColors = New frmColors
        frmColors.CallerForm = Me.Name
        frmColors.CallerControl = cboBOXColors
        frmColors.CalledFromControl = True
        If cboBOXColors.EditValue <> Nothing Then frmColors.ID = cboBOXColors.EditValue.ToString
        frmColors.MdiParent = frmMain
        If cboBOXColors.EditValue <> Nothing Then frmColors.Mode = FormMode.EditRecord Else frmColors.Mode = FormMode.NewRecord
        frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(frmColors), New Point(CInt(frmColors.Parent.ClientRectangle.Width / 2 - frmColors.Width / 2), CInt(frmColors.Parent.ClientRectangle.Height / 2 - frmColors.Height / 2)))
        frmColors.Show()
    End Sub
    Private Sub cboDimID_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboDim.ButtonClick
        Select Case e.Button.Index
            Case 1 : ManageDIM()
            Case 2 : cboDim.EditValue = Nothing
        End Select
    End Sub
    Private Sub ManageDIM()
        Dim frmGen As frmGen = New frmGen
        frmGen.Text = "Διαστάσεις"
        frmGen.L1.Text = "Κωδικός"
        frmGen.L2.Text = "Διάσταση"
        frmGen.DataTable = "DIM"
        frmGen.CallerControl = cboDim
        frmGen.CalledFromControl = True
        If cboDim.EditValue <> Nothing Then frmGen.ID = cboDim.EditValue.ToString
        frmGen.MdiParent = frmMain
        frmGen.L3.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        frmGen.L4.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        frmGen.L5.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        frmGen.L6.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        frmGen.L7.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        If cboDim.EditValue <> Nothing Then frmGen.Mode = FormMode.EditRecord Else frmGen.Mode = FormMode.NewRecord
        frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(frmGen), New Point(CInt(frmGen.Parent.ClientRectangle.Width / 2 - frmGen.Width / 2), CInt(frmGen.Parent.ClientRectangle.Height / 2 - frmGen.Height / 2)))
        frmGen.Show()
    End Sub


    Private Sub cboCalc_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboCalc.ButtonClick
        Select Case e.Button.Index
            Case 1 : ManageCALC()
            Case 2 : cboCalc.EditValue = Nothing
        End Select
    End Sub
    Private Sub ManageCALC()
        Dim frmCalculations As frmCalculations = New frmCalculations
        frmCalculations.CallerControl = cboCalc
        frmCalculations.CalledFromControl = True
        If cboCalc.EditValue <> Nothing Then frmCalculations.ID = cboCalc.EditValue.ToString
        frmCalculations.MdiParent = frmMain
        If cboCalc.EditValue <> Nothing Then frmCalculations.Mode = FormMode.EditRecord Else frmCalculations.Mode = FormMode.NewRecord
        frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(frmCalculations), New Point(CInt(frmCalculations.Parent.ClientRectangle.Width / 2 - frmCalculations.Width / 2), CInt(frmCalculations.Parent.ClientRectangle.Height / 2 - frmCalculations.Height / 2)))
        frmCalculations.Show()
    End Sub


    Private Sub cboCategory_EditValueChanged(sender As Object, e As EventArgs) Handles cboCategory.EditValueChanged
        If cboCategory.EditValue Is Nothing Then Exit Sub
        Dim sSQL As New System.Text.StringBuilder
        sSQL.AppendLine("Select id,name from vw_CAT_SUB_ERM where CatErmID = " & toSQLValueS(cboCategory.EditValue.ToString) & "order by name")
        FillCbo.CAT_SUB_ERM(cboCatSubErm, sSQL)
    End Sub

    Private Sub cboCatSubErm_EditValueChanged(sender As Object, e As EventArgs) Handles cboCatSubErm.EditValueChanged

    End Sub

    Private Sub cboCatSubErm_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboCatSubErm.ButtonClick
        Select Case e.Button.Index
            Case 1 : ManageCATSUBERM()
            Case 2 : cboCatSubErm.EditValue = Nothing
        End Select
    End Sub
    Private Sub ManageCATSUBERM()
        Dim frmCatSubErm As frmCatSubErm = New frmCatSubErm
        frmCatSubErm.CallerControl = cboCatSubErm
        frmCatSubErm.CalledFromControl = True
        If cboCatSubErm.EditValue <> Nothing Then frmCatSubErm.ID = cboCatSubErm.EditValue.ToString
        frmCatSubErm.MdiParent = frmMain
        If cboCatSubErm.EditValue <> Nothing Then frmCatSubErm.Mode = FormMode.EditRecord Else frmCatSubErm.Mode = FormMode.NewRecord
        frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(frmCatSubErm), New Point(CInt(frmCatSubErm.Parent.ClientRectangle.Width / 2 - frmCatSubErm.Width / 2), CInt(frmCatSubErm.Parent.ClientRectangle.Height / 2 - frmCatSubErm.Height / 2)))
        frmCatSubErm.Show()
    End Sub

End Class