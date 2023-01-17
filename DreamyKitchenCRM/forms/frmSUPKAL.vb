Imports System.Data.SqlClient
Imports DevExpress.Utils
Imports DevExpress.Utils.Menu
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Menu
Imports DevExpress.XtraGrid.Views.Grid

Public Class frmSUPKal
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

    Private Sub frmSUPKal_Load(sender As Object, e As EventArgs) Handles Me.Load
        'TODO: This line of code loads data into the 'DreamyKitchenDataSet.vw_BANKS' table. You can move, or remove it, as needed.
        Me.Vw_BANKSTableAdapter.Fill(Me.DreamyKitchenDataSet.vw_BANKS)
        'TODO: This line of code loads data into the 'DreamyKitchenDataSet.vw_PAY' table. You can move, or remove it, as needed.
        Me.Vw_PAYTableAdapter.Fill(Me.DreamyKitchenDataSet.vw_PAY)
        'TODO: This line of code loads data into the 'DreamyKitchenDataSet.vw_SUP' table. You can move, or remove it, as needed.
        Me.Vw_SUPTableAdapter.Fill(Me.DreamyKitchenDataSet.vw_SUP)
        Select Case Mode
            Case FormMode.NewRecord
                txtCode.Text = DBQ.GetNextId("SUP_PAYMENTS_H")
            Case FormMode.EditRecord
                LoadForms.LoadForm(LayoutControl1, "Select * from SUP_PAYMENTS_H where id ='" + sID + "'")
        End Select
        LoadForms.RestoreLayoutFromXml(GridView1, "vw_BUY_INV_def.xml")
        Me.CenterToScreen()
        cmdSave.Enabled = IIf(Mode = FormMode.NewRecord, UserProps.AllowInsert, UserProps.AllowEdit)

    End Sub
    Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click
        Dim sResult As Boolean
        Dim sGuid As String
        Dim sSQL As String
        Try
            If Valid.ValidateForm(LayoutControl1) Then
                Select Case Mode
                    Case FormMode.NewRecord
                        sGuid = System.Guid.NewGuid.ToString
                        sResult = DBQ.InsertNewData(DBQueries.InsertMode.OneLayoutControl, "SUP_PAYMENTS_H", LayoutControl1,,, sGuid, True)
                        sID = sGuid
                    Case FormMode.EditRecord
                        sResult = DBQ.UpdateNewData(DBQueries.InsertMode.OneLayoutControl, "SUP_PAYMENTS_H", LayoutControl1,,, sID, True)
                        sGuid = sID
                End Select

                'If FScrollerExist = True Then
                '    Dim form As frmScroller = Frm
                '    form.LoadRecords("vw_SUP_PAYMENTS_H")
                'End If

                ' Ενημέρωση πληρωμών
                Using oCmd As New SqlCommand("SUP_PAYMENTS", CNDB)
                    oCmd.CommandType = CommandType.StoredProcedure
                    oCmd.Parameters.AddWithValue("@supplierID ", cboSUP.EditValue.ToString)
                    oCmd.Parameters.AddWithValue("@supPaymentHID", sGuid)
                    oCmd.Parameters.AddWithValue("@amt", toSQLValueS(txtAmt.EditValue.ToString, True))
                    oCmd.ExecuteNonQuery()
                End Using

                If sResult = True Then XtraMessageBox.Show("Η εγγραφή αποθηκέυτηκε με επιτυχία", "Dreamy Kitchen CRM", MessageBoxButtons.OK, MessageBoxIcon.Information)

                If Mode = FormMode.NewRecord Then
                    Cls.ClearCtrls(LayoutControl1)
                    txtCode.Text = DBQ.GetNextId("SUP_PAYMENTS_H")
                End If
            End If

        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), "Dreamy Kitchen CRM", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub cboSUP_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboSUP.ButtonClick
        Select Case e.Button.Index
            Case 1 : cboSUP.EditValue = Nothing : ManageSup()
            Case 2 : If cboSUP.EditValue <> Nothing Then ManageSup()
            Case 3 : cboSUP.EditValue = Nothing : cboPAY.EditValue = Nothing : txtBal.EditValue = "0.00"
        End Select
    End Sub
    Private Sub ManageSup()
        Dim form1 As frmSUP = New frmSUP()
        form1.Text = "Προμηθευτές"
        form1.CallerControl = cboSUP
        form1.CalledFromControl = True
        form1.MdiParent = frmMain
        If cboSUP.EditValue <> Nothing Then
            form1.ID = cboSUP.EditValue.ToString
            form1.Mode = FormMode.EditRecord
        Else
            form1.Mode = FormMode.NewRecord
        End If
        frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(form1), New Point(CInt(form1.Parent.ClientRectangle.Width / 2 - form1.Width / 2), CInt(form1.Parent.ClientRectangle.Height / 2 - form1.Height / 2)))
        form1.Show()

    End Sub
    Private Sub cboBANK_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboBANK.ButtonClick
        Select Case e.Button.Index
            Case 1 : cboBANK.EditValue = Nothing : ManageBank()
            Case 2 : If cboBANK.EditValue <> Nothing Then ManageBank()
            Case 3 : cboBANK.EditValue = Nothing
        End Select
    End Sub
    Private Sub ManageBank()
        Dim form1 As frmGen = New frmGen()
        form1.Text = "Τράπεζες"
        form1.L1.Text = "Κωδικός"
        form1.L2.Text = "Τράπεζα"
        form1.DataTable = "BANKS"
        form1.CalledFromControl = True
        form1.CallerControl = cboBANK
        If cboBANK.EditValue <> Nothing Then form1.ID = cboBANK.EditValue.ToString
        form1.MdiParent = frmMain
        If cboBANK.EditValue <> Nothing Then form1.Mode = FormMode.EditRecord Else form1.Mode = FormMode.NewRecord
        frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(form1), New Point(CInt(form1.Parent.ClientRectangle.Width / 2 - form1.Width / 2), CInt(form1.Parent.ClientRectangle.Height / 2 - form1.Height / 2)))
        form1.Show()
    End Sub
    Private Sub ManagePAY()
        Dim form1 As frmGen = New frmGen()
        form1.Text = "Τρόποι Πληρωμής"
        form1.L1.Text = "Κωδικός"
        form1.L2.Text = "Τρόπος Πληρωμής"
        form1.DataTable = "PAY"
        form1.CallerControl = cboPAY
        form1.CalledFromControl = True
        If cboPAY.EditValue <> Nothing Then form1.ID = cboPAY.EditValue.ToString
        form1.MdiParent = frmMain
        If cboPAY.EditValue <> Nothing Then form1.Mode = FormMode.EditRecord Else form1.Mode = FormMode.NewRecord
        frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(form1), New Point(CInt(form1.Parent.ClientRectangle.Width / 2 - form1.Width / 2), CInt(form1.Parent.ClientRectangle.Height / 2 - form1.Height / 2)))
        form1.Show()
    End Sub
    Private Sub cboPAY_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboPAY.ButtonClick
        Select Case e.Button.Index
            Case 1 : cboPAY.EditValue = Nothing : ManagePAY()
            Case 2 : If cboPAY.EditValue <> Nothing Then ManagePAY()
            Case 3 : cboPAY.EditValue = Nothing
        End Select
    End Sub

    Private Sub cboSUP_EditValueChanged(sender As Object, e As EventArgs) Handles cboSUP.EditValueChanged
        If cboSUP.EditValue = Nothing Then Exit Sub
        txtBal.EditValue = cboSUP.GetColumnValue("bal")
        If Mode = FormMode.EditRecord Then
            Me.Vw_BUYTableAdapter.FillBysupID_with_Paid(Me.DreamyKitchenDataSet.vw_BUY, System.Guid.Parse(cboSUP.EditValue.ToString))
        Else
            Me.Vw_BUYTableAdapter.FillBysupID_with_noPaid(Me.DreamyKitchenDataSet.vw_BUY, System.Guid.Parse(cboSUP.EditValue.ToString))
        End If
    End Sub

    Private Sub GridView1_PopupMenuShowing(sender As Object, e As PopupMenuShowingEventArgs) Handles GridView1.PopupMenuShowing
        If e.MenuType = GridMenuType.Column Then
            Dim menu As DevExpress.XtraGrid.Menu.GridViewColumnMenu = TryCast(e.Menu, GridViewColumnMenu)
            Dim item As New DXEditMenuItem()
            Dim itemColor As New DXEditMenuItem()

            'menu.Items.Clear()
            If menu.Column IsNot Nothing Then
                'Για να προσθέσουμε menu item στο Default menu πρέπει πρώτα να προσθέσουμε ένα Repository Item 
                'Υπάρχουν πολλών ειδών Repositorys
                '1st Custom Menu Item
                Dim popRenameColumn As New RepositoryItemTextEdit
                popRenameColumn.Name = "RenameColumn"
                menu.Items.Add(New DXEditMenuItem("Μετονομασία Στήλης", popRenameColumn, AddressOf OnEditValueChanged, Nothing, Nothing, 100, 0))
                item = menu.Items.Item("Μετονομασία Στήλης")
                item.EditValue = menu.Column.GetTextCaption
                item.Tag = menu.Column.AbsoluteIndex

                '2nd Custom Menu Item
                menu.Items.Add(CreateCheckItem("Κλείδωμα Στήλης", menu.Column, Nothing))

                '3rd Custom Menu Item
                Dim popColorsColumn As New RepositoryItemColorEdit
                popColorsColumn.Name = "ColorsColumn"
                menu.Items.Add(New DXEditMenuItem("Χρώμα Στήλης", popColorsColumn, AddressOf OnColumnsColorChanged, Nothing, Nothing, 100, 0))
                itemColor = menu.Items.Item("Χρώμα Στήλης")
                itemColor.EditValue = menu.Column.AppearanceCell.BackColor
                itemColor.Tag = menu.Column.AbsoluteIndex

                '4nd Custom Menu Item
                menu.Items.Add(New DXMenuItem("Αποθήκευση όψης", AddressOf OnSaveView, Nothing, Nothing, Nothing, Nothing))

                '5nd Custom Menu Item
                menu.Items.Add(New DXMenuItem("Συγχρονισμός όψης από Server", AddressOf OnSyncView, Nothing, Nothing, Nothing, Nothing))

            End If
        End If
    End Sub

    'Μετονομασία Στήλης Master
    Private Sub OnEditValueChanged(ByVal sender As System.Object, ByVal e As EventArgs)
        Dim item As New DXEditMenuItem()
        item = sender
        If item.Tag Is Nothing Then Exit Sub
        GridView1.Columns(item.Tag).Caption = item.EditValue
        'MessageBox.Show(item.EditValue.ToString())
    End Sub
    Private Function CreateCheckItem(ByVal caption As String, ByVal column As GridColumn, ByVal image As Image) As DXMenuCheckItem
        Dim item As New DXMenuCheckItem(caption, (Not column.OptionsColumn.AllowMove), image, New EventHandler(AddressOf OnCanMoveItemClick))
        item.Tag = New MenuColumnInfo(column)
        Return item
    End Function
    'Αλλαγή Χρώματος Στήλης Master
    Private Sub OnColumnsColorChanged(ByVal sender As System.Object, ByVal e As EventArgs)
        Dim item As DXEditMenuItem = TryCast(sender, DXEditMenuItem)
        item = sender
        If item.Tag Is Nothing Then Exit Sub
        GridView1.Columns(item.Tag).AppearanceCell.BackColor = item.EditValue
    End Sub
    'Κλείδωμα Στήλης Master
    Private Sub OnCanMoveItemClick(ByVal sender As Object, ByVal e As EventArgs)
        Dim item As DXMenuCheckItem = TryCast(sender, DXMenuCheckItem)
        Dim info As MenuColumnInfo = TryCast(item.Tag, MenuColumnInfo)
        If info Is Nothing Then
            Return
        End If
        info.Column.OptionsColumn.AllowMove = Not item.Checked
    End Sub
    'Αποθήκευση όψης 
    Private Sub OnSaveView(ByVal sender As System.Object, ByVal e As EventArgs)
        Dim item As DXMenuItem = TryCast(sender, DXMenuItem)
        GridView1.SaveLayoutToXml(Application.StartupPath & "\DSGNS\DEF\vw_BUY_INV_def.xml", OptionsLayoutBase.FullLayout)
        XtraMessageBox.Show("Η όψη αποθηκεύτηκε με επιτυχία", "Dreamy Kitchen CRM", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ' Μόνο αν ο Χρήστης είναι ο Παναγόπουλος
        If UserProps.ID.ToString.ToUpper = "3F9DC32E-BE5B-4D46-A13C-EA606566CF32" Or UserProps.ID.ToString.ToUpper = "E9CEFD11-47C0-4796-A46B-BC41C4C3606B" Then 
            If XtraMessageBox.Show("Θέλετε να γίνει κοινοποίηση της όψης? Εαν επιλέξετε 'Yes' όλοι οι χρήστες θα έχουν την ίδια όψη", "Dreamy Kitchen CRM", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                If My.Computer.FileSystem.FileExists(ProgProps.ServerViewsPath & "DSGNS\DEF\vw_BUY_INV_def.xml") = False Then GridView1.OptionsLayout.LayoutVersion = "v1"
                GridView1.SaveLayoutToXml(ProgProps.ServerViewsPath & "DSGNS\DEF\vw_BUY_INV_def.xml", OptionsLayoutBase.FullLayout)
            End If
        End If

    End Sub
    'Συγχρονισμός όψης από Server
    Private Sub OnSyncView(ByVal sender As System.Object, ByVal e As EventArgs)
        If XtraMessageBox.Show("Θέλετε να γίνει μεταφορά της όψης από τον server?", "Dreamy Kitchen CRM", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            ' Έλεγχος αν υπάρχει όψη με μεταγενέστερη ημερομηνία στον Server
            If System.IO.File.Exists(ProgProps.ServerViewsPath & "DSGNS\DEF\vw_BUY_INV_def.xml") = True Then
                My.Computer.FileSystem.CopyFile(ProgProps.ServerViewsPath & "DSGNS\DEF\vw_BUY_INV_def.xml", Application.StartupPath & "\DSGNS\DEF\vw_BUY_INV_def.xml", True)
                GridView1.RestoreLayoutFromXml(Application.StartupPath & "\DSGNS\DEF\vw_BUY_INV_def.xml", OptionsLayoutBase.FullLayout)
            End If
        End If
    End Sub

    Private Sub frmSUPKal_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        If Me.WindowState = FormWindowState.Maximized Then frmMain.XtraTabbedMdiManager1.Dock(Me, frmMain.XtraTabbedMdiManager1)

    End Sub

    Friend Class MenuColumnInfo
        Public Sub New(ByVal column As GridColumn)
            Me.Column = column
        End Sub
        Public Column As GridColumn
    End Class

    Private Sub cboPAY_EditValueChanged(sender As Object, e As EventArgs) Handles cboPAY.EditValueChanged
        If cboPAY.EditValue = Nothing Then Exit Sub
        Select Case cboPAY.EditValue.ToString.ToUpper
            Case "1E1BAE0C-A11E-4D42-9FB2-4BB020A9FE3C"
                txtcheckNum.ReadOnly = False : dtissueDate.ReadOnly = False : dtendDate.ReadOnly = False : cboBANK.ReadOnly = False
                txtDepositNum.ReadOnly = True : txtDepositNum.EditValue = Nothing
            Case "092BA027-3C52-4102-A691-FF2797D40A13"
                txtDepositNum.ReadOnly = False
                txtcheckNum.ReadOnly = True : dtissueDate.ReadOnly = True : cboBANK.ReadOnly = False : dtendDate.ReadOnly = True
                txtcheckNum.EditValue = Nothing : dtissueDate.EditValue = Nothing : cboBANK.EditValue = Nothing : dtendDate.EditValue = Nothing
            Case Else
                txtcheckNum.ReadOnly = True : dtissueDate.ReadOnly = True : cboBANK.ReadOnly = True : dtendDate.ReadOnly = True
                txtcheckNum.EditValue = Nothing : dtissueDate.EditValue = Nothing : cboBANK.EditValue = Nothing
                txtDepositNum.ReadOnly = True : txtDepositNum.EditValue = Nothing : dtendDate.EditValue = Nothing
        End Select
    End Sub
End Class