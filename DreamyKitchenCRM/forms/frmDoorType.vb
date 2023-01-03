Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls

Public Class frmDoorType
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

    Private Sub frmDoorType_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        If Me.WindowState = FormWindowState.Maximized Then frmMain.XtraTabbedMdiManager1.Dock(Me, frmMain.XtraTabbedMdiManager1)
    End Sub

    Private Sub frmDoorType_Load(sender As Object, e As EventArgs) Handles Me.Load
        'TODO: This line of code loads data into the 'DreamyKitchenDataSet.vw_DOOR_CAT' table. You can move, or remove it, as needed.
        Me.Vw_DOOR_CATTableAdapter.Fill(Me.DreamyKitchenDataSet.vw_DOOR_CAT)
        'TODO: This line of code loads data into the 'DreamyKitchenDataSet.vw_DIM' table. You can move, or remove it, as needed.
        Me.Vw_DIMTableAdapter.Fill(Me.DreamyKitchenDataSet.vw_DIM)
        'TODO: This line of code loads data into the 'DreamyKitchenDataSet.vw_COLORSBOX' table. You can move, or remove it, as needed.
        Me.Vw_COLORSBOXTableAdapter.Fill(Me.DreamyKitchenDataSet.vw_COLORSBOX)
        Select Case Mode
            Case FormMode.NewRecord
                txtCode.Text = DBQ.GetNextId("DOOR_TYPE")
            Case FormMode.EditRecord
                LoadForms.LoadForm(LayoutControl1, "Select * from DOOR_TYPE where id ='" + sID + "'")
        End Select
        Me.CenterToScreen()
        cmdSave.Enabled = IIf(Mode = FormMode.NewRecord, UserProps.AllowInsert, UserProps.AllowEdit)
    End Sub

    Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click
        Dim sResult As Boolean
        Dim sGuid As String
        Try
            If Valid.ValidateForm(LayoutControl1) Then
                Select Case Mode
                    Case FormMode.NewRecord
                        sGuid = System.Guid.NewGuid.ToString
                        sResult = DBQ.InsertData(LayoutControl1, "DOOR_TYPE", sGuid)
                    Case FormMode.EditRecord
                        sResult = DBQ.UpdateData(LayoutControl1, "DOOR_TYPE", sID)
                        sGuid = sID
                End Select
                If CalledFromCtrl Then
                    FillCbo.DOOR_TYPE(CtrlCombo)
                    CtrlCombo.EditValue = System.Guid.Parse(sGuid)
                Else
                    Dim form As frmScroller = Frm
                    form.LoadRecords("vw_DOOR_TYPE")
                End If
                If sResult = True Then
                    XtraMessageBox.Show("Η εγγραφή αποθηκέυτηκε με επιτυχία", "Dreamy Kitchen CRM", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    If Mode = FormMode.NewRecord Then
                        Cls.ClearCtrls(LayoutControl1)
                        txtCode.Text = DBQ.GetNextId("DOOR_TYPE")
                        txtCustomCode.Select()
                    End If
                End If
            End If

        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), "Dreamy Kitchen CRM", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cboType_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboType.ButtonClick
        Select Case e.Button.Index
            Case 1 : cboType.EditValue = Nothing
        End Select
    End Sub

    Private Sub cboKasa_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboKasa.ButtonClick
        Select Case e.Button.Index
            Case 1 : cboKasa.EditValue = Nothing
        End Select
    End Sub

    Private Sub cboDoorType_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboDoorType.ButtonClick
        Select Case e.Button.Index
            Case 1 : cboDoorType.EditValue = Nothing
        End Select
    End Sub
    Private Sub cboDoorCat_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboDoorCat.ButtonClick
        Select Case e.Button.Index
            Case 1 : cboDoorCat.EditValue = Nothing : ManageDoorCAT()
            Case 2 : If cboDoorCat.EditValue <> Nothing Then ManageDoorCAT()
            Case 3 : cboDoorCat.EditValue = Nothing
        End Select
    End Sub
    Private Sub ManageDoorCAT()
        Dim form1 As frmGen = New frmGen()
        form1.Text = "Κατηγορία Πόρτας"
        form1.L1.Text = "Κωδικός"
        form1.L2.Text = "Κατηγορία"
        form1.DataTable = "DOOR_CAT"
        form1.CallerControl = cboDoorCat
        form1.CalledFromControl = True
        If cboDoorCat.EditValue <> Nothing Then form1.ID = cboDoorCat.EditValue.ToString
        form1.MdiParent = frmMain
        If cboDoorCat.EditValue <> Nothing Then form1.Mode = FormMode.EditRecord Else form1.Mode = FormMode.NewRecord
        frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(form1), New Point(CInt(form1.Parent.ClientRectangle.Width / 2 - form1.Width / 2), CInt(form1.Parent.ClientRectangle.Height / 2 - form1.Height / 2)))
        form1.Show()
    End Sub

    Private Sub cboDim_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboDim.ButtonClick
        Select Case e.Button.Index
            Case 1 : cboDim.EditValue = Nothing : ManageDIM()
            Case 2 : If cboDim.EditValue <> Nothing Then ManageDIM()
            Case 3 : cboDim.EditValue = Nothing
        End Select
    End Sub
    Private Sub ManageDIM()
        Dim form1 As frmGen = New frmGen()
        form1.Text = "Διάσταση"
        form1.L1.Text = "Κωδικός"
        form1.L2.Text = "Διάσταση"
        form1.DataTable = "DIM"
        form1.CallerControl = cboDim
        form1.CalledFromControl = True
        If cboDim.EditValue <> Nothing Then form1.ID = cboDim.EditValue.ToString
        form1.MdiParent = frmMain
        If cboDim.EditValue <> Nothing Then form1.Mode = FormMode.EditRecord Else form1.Mode = FormMode.NewRecord
        frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(form1), New Point(CInt(form1.Parent.ClientRectangle.Width / 2 - form1.Width / 2), CInt(form1.Parent.ClientRectangle.Height / 2 - form1.Height / 2)))
        form1.Show()
    End Sub

    Private Sub cboDoorType1_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboDoorType1.ButtonClick
        Select Case e.Button.Index
            Case 1 : cboDoorType1.EditValue = Nothing
        End Select

    End Sub


    Private Sub cboDoorColor_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboDoorColor.ButtonClick
        Select Case e.Button.Index
            Case 1 : cboDoorColor.EditValue = Nothing : ManageColors(cboDoorColor)
            Case 2 : If cboDoorColor.EditValue <> Nothing Then ManageColors(cboDoorColor)
            Case 3 : cboDoorColor.EditValue = Nothing
        End Select

    End Sub
    Private Sub ManageColors(ByVal CallerControl As LookUpEdit)
        Dim frmColors As frmColors = New frmColors
        frmColors.ColorCategory = "40C7BFFB-43EB-48FB-A467-74C0BCBE09FA"
        frmColors.Text = "Χρώματα"
        frmColors.CallerForm = "frmDoorType"
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

End Class