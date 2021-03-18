Imports System.Text.RegularExpressions
Imports System.Data.SqlClient
Imports DevExpress.Utils
Imports DevExpress.Utils.Menu
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Menu
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports DevExpress.XtraLayout

Public Class frmOffer

    Private sID As String
    Private sOffersID As String
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
    Private DoorTypeID As String
    Private DoorPrice As Double
    Private CatErmID As String
    Private ErmName As String
    Private Calculations As String


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

    Private Sub frmOffer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DreamyKitchenDataSet.vw_DOOR_TYPE' table. You can move, or remove it, as needed.
        Me.Vw_DOOR_TYPETableAdapter.Fill(Me.DreamyKitchenDataSet.vw_DOOR_TYPE)
        'TODO: This line of code loads data into the 'DreamyKitchenDataSet.vw_COLORSPVC' table. You can move, or remove it, as needed.
        Me.Vw_COLORSPVCTableAdapter.Fill(Me.DreamyKitchenDataSet.vw_COLORSPVC)
        'TODO: This line of code loads data into the 'DreamyKitchenDataSet.vw_COLORSBOX' table. You can move, or remove it, as needed.
        Me.Vw_COLORSBOXTableAdapter.Fill(Me.DreamyKitchenDataSet.vw_COLORSBOX)
        FillCbo.CUS(cboCUS)
        FillCbo.CAT_ERM(cboCategory)
        FillCbo.ERM(cboERM)
        FillCbo.BENCH(cboBENCH)
        FillCbo.DIMENSION(cboDim)
        FillCbo.FillCheckedListMech(chkMech, FormMode.NewRecord)
        'FillCbo.FillCheckedListDoorTypes(chkDoorTypes, FormMode.NewRecord)
        cboSides.Properties.Items.Add("Δεξί")
        cboSides.Properties.Items.Add("Αριστερό")

        If cboCategory.EditValue Is Nothing Then
            Me.Vw_ERMTableAdapter.FillByAll(Me.DreamyKitchenDataSet.vw_ERM)
        Else
            Me.Vw_ERMTableAdapter.Fill(Me.DreamyKitchenDataSet.vw_ERM, System.Guid.Parse(cboCategory.EditValue.ToString))
        End If

        Select Case Mode
            Case FormMode.NewRecord
                LayoutControlGroup2.Enabled = False
                LayoutControl2.Enabled = False
                FillCbo.FillCheckedListMech(chkMech, FormMode.NewRecord)
                txtCode.Text = DBQ.GetNextId("[OFF]")
            Case FormMode.EditRecord
                'FillCbo.FillCheckedListMech(chkMech, FormMode.EditRecord, sID)
                Me.OFFERSTableAdapter.Fill(Me.DreamyKitchenDataSet.vw_OFFERS, System.Guid.Parse(sID))
                LoadForms.LoadFormGRP(LayoutControlGroup1, "Select * from vw_OFF where id ='" + sID + "'")
                cmdSave.Enabled = False
        End Select
        Me.CenterToScreen()
        My.Settings.frmDoorType = Me.Location
        My.Settings.Save()
        If My.Computer.FileSystem.FileExists(Application.StartupPath & "\DSGNS\DEF\OFF_erm.xml") Then GridView1.RestoreLayoutFromXml(Application.StartupPath & "\DSGNS\DEF\OFF_erm.xml", OptionsLayoutBase.FullLayout)
        'Φορτώνει όλες τις ονομασίες των στηλών από τον SQL. Από το πεδίο Description
        LoadForms.LoadColumnDescriptionNames(grdMain, GridView1, , "ERM")
        GridView3.OptionsBehavior.AutoExpandAllGroups = True
        cmdSaveOff.Enabled = IIf(Mode = FormMode.NewRecord, UserProps.AllowInsert, UserProps.AllowEdit)
        txtHeight.ReadOnly = True
        txtWidth.ReadOnly = True
        txtDepth.ReadOnly = True
        txtCustomCode.Select()

    End Sub

    Private Sub frmOffer_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        If Me.WindowState = FormWindowState.Maximized Then frmMain.XtraTabbedMdiManager1.Dock(Me, frmMain.XtraTabbedMdiManager1)
    End Sub

    Private Sub cboCUS_EditValueChanged(sender As Object, e As EventArgs) Handles cboCUS.EditValueChanged
        If cboCUS.EditValue Is Nothing Then Exit Sub
        Dim cmd As SqlCommand = New SqlCommand("Select * from vw_CCT where ID = '" & cboCUS.EditValue.ToString & "'", CNDB)
        Dim sdr As SqlDataReader = cmd.ExecuteReader()
        If (sdr.Read() = True) Then
            If sdr.IsDBNull(sdr.GetOrdinal("mob")) = False Then txtMob.EditValue = sdr.GetString(sdr.GetOrdinal("mob"))
            If sdr.IsDBNull(sdr.GetOrdinal("phn")) = False Then txtPhn.EditValue = sdr.GetString(sdr.GetOrdinal("phn"))
            If sdr.IsDBNull(sdr.GetOrdinal("COU_Name")) = False Then txtCou.EditValue = sdr.GetString(sdr.GetOrdinal("COU_Name"))
            If sdr.IsDBNull(sdr.GetOrdinal("AREAS_Name")) = False Then txtArea.EditValue = sdr.GetString(sdr.GetOrdinal("AREAS_Name"))
            If sdr.IsDBNull(sdr.GetOrdinal("ADR_Name")) = False Then txtADR.EditValue = sdr.GetString(sdr.GetOrdinal("ADR_Name"))
            If sdr.IsDBNull(sdr.GetOrdinal("Ar")) = False Then txtAR.EditValue = sdr.GetString(sdr.GetOrdinal("Ar"))
            If sdr.IsDBNull(sdr.GetOrdinal("Tk")) = False Then txtTK.EditValue = sdr.GetString(sdr.GetOrdinal("Tk"))
        End If
        sdr.Close()
    End Sub

    Private Sub cboCUS_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboCUS.ButtonClick
        Select Case e.Button.Index
            Case 1 : ManageCus()
            Case 2 : cboCUS.EditValue = Nothing : Cls.ClearCtrlsGRP(LayoutControlGroup1)
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
        frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(form1), New POINT(CInt(form1.Parent.ClientRectangle.Width / 2 - form1.Width / 2), CInt(form1.Parent.ClientRectangle.Height / 2 - form1.Height / 2)))
        form1.Show()
    End Sub

    Private Sub cboCategory_EditValueChanged(sender As Object, e As EventArgs) Handles cboCategory.EditValueChanged
        If cboCategory.EditValue Is Nothing Then
            Me.Vw_ERMTableAdapter.FillByAll(Me.DreamyKitchenDataSet.vw_ERM)
        Else
            Me.Vw_ERMTableAdapter.Fill(Me.DreamyKitchenDataSet.vw_ERM, System.Guid.Parse(cboCategory.EditValue.ToString))
        End If
    End Sub
    Private Sub grdMain_DoubleClick(sender As Object, e As EventArgs) Handles grdMain.DoubleClick
        chkDimChanged.Checked = False
        LoadForms.LoadFormGRP(LayoutControlGroup2, "Select * from vw_ERM where id ='" + GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "ID").ToString() + "'")
        DoorTypeID = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "DoorTypeID").ToString()
        ErmName = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "name").ToString()
        cboERM.EditValue = System.Guid.Parse(GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "ID").ToString())
        CatErmID = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "catErmID").ToString()
        Calculations = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "calculations").ToString()
        DoorPrice = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "DoorPrice").ToString()
        txtCalc.EditValue = Calculations
        cmdSave.Enabled = True
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
        frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(frmGen), New POINT(CInt(frmGen.Parent.ClientRectangle.Width / 2 - frmGen.Width / 2), CInt(frmGen.Parent.ClientRectangle.Height / 2 - frmGen.Height / 2)))
        frmGen.Show()
    End Sub

    Private Sub chkDimChanged_CheckedChanged(sender As Object, e As EventArgs) Handles chkDimChanged.CheckedChanged
        Dim Edit As CheckEdit = CType(sender, CheckEdit)
        If Edit.Checked = True Then
            txtHeight.ReadOnly = False : txtWidth.ReadOnly = False : txtDepth.ReadOnly = False
        Else
            txtHeight.ReadOnly = True : txtWidth.ReadOnly = True : txtDepth.ReadOnly = True
            txtHeight.EditValue = "0,00" : txtWidth.EditValue = "0,00" : txtDepth.EditValue = "0,00"
        End If
    End Sub

    Private Sub cboDim_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboDim.ButtonClick
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
        frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(frmGen), New POINT(CInt(frmGen.Parent.ClientRectangle.Width / 2 - frmGen.Width / 2), CInt(frmGen.Parent.ClientRectangle.Height / 2 - frmGen.Height / 2)))
        frmGen.Show()
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
        frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(frmColors), New POINT(CInt(frmColors.Parent.ClientRectangle.Width / 2 - frmColors.Width / 2), CInt(frmColors.Parent.ClientRectangle.Height / 2 - frmColors.Height / 2)))
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
        frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(frmColors), New POINT(CInt(frmColors.Parent.ClientRectangle.Width / 2 - frmColors.Width / 2), CInt(frmColors.Parent.ClientRectangle.Height / 2 - frmColors.Height / 2)))
        frmColors.Show()
    End Sub

    Private Sub cboBENCH_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboBENCH.ButtonClick
        Select Case e.Button.Index
            Case 1 : ManageBENCH()
            Case 2 : cboBENCH.EditValue = Nothing
        End Select
    End Sub
    Private Sub ManageBENCH()
        Dim frmBench As frmBench = New frmBench
        frmBench.CallerForm = Me.Name
        frmBench.CallerControl = cboBENCH
        frmBench.CalledFromControl = True
        If cboBENCH.EditValue <> Nothing Then frmBench.ID = cboBENCH.EditValue.ToString
        frmBench.MdiParent = frmMain
        If cboBENCH.EditValue <> Nothing Then frmBench.Mode = FormMode.EditRecord Else frmBench.Mode = FormMode.NewRecord
        frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(frmBench), New POINT(CInt(frmBench.Parent.ClientRectangle.Width / 2 - frmBench.Width / 2), CInt(frmBench.Parent.ClientRectangle.Height / 2 - frmBench.Height / 2)))
        frmBench.Show()
    End Sub

    Private Sub GridView1_PopupMenuShowing(sender As Object, e As DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs) Handles GridView1.PopupMenuShowing
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
                menu.Items.Add(New DXMenuItem("Αποθήκευση όψης", AddressOf OnSaveViewErm, Nothing, Nothing, Nothing, Nothing))

            End If
        End If
    End Sub
    'Αποθήκευση όψης Ερμάριων
    Private Sub OnSaveViewErm(ByVal sender As System.Object, ByVal e As EventArgs)
        Dim item As DXMenuItem = TryCast(sender, DXMenuItem)
        GridView1.SaveLayoutToXml(Application.StartupPath & "\DSGNS\DEF\OFF_erm.xml", OptionsLayoutBase.FullLayout)
        XtraMessageBox.Show("Η όψη αποθηκεύτηκε με επιτυχία", "Dreamy Kitchen CRM", MessageBoxButtons.OK, MessageBoxIcon.Information)
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

    Friend Class MenuColumnInfo
        Public Sub New(ByVal column As GridColumn)
            Me.Column = column
        End Sub
        Public Column As GridColumn
    End Class

    Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click
        Dim sResult As Boolean, sResult2 As Boolean
        Dim sGuid As String, sSQL As String, ExceptFields As New List(Of String)
        Try
            If Valid.ValidateForm(LayoutControl1) Then
                If chkDimChanged.Checked = True Then
                    XtraMessageBox.Show("Έχετε επιλέξει αλλαγή διάστασης. Θα ενημερωθεί η βιβλιοθήκη με την νέα διάσταση.", "Dreamy Kitchen CRM", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    ExceptFields.Add(cboERM.Properties.Tag)
                    ExceptFields.Add(txtQTY.Properties.Tag)
                    ExceptFields.Add(cboBENCH.Properties.Tag)
                    ExceptFields.Add(chkDimChanged.Properties.Tag)
                    sGuid = System.Guid.NewGuid.ToString
                    sResult = DBQ.InsertNewData(DBQueries.InsertMode.GroupLayoutControl, "ERM",,, LayoutControlGroup2, sGuid,, "DoorTypeID,name,catErmID", toSQLValueS(DoorTypeID) & "," & toSQLValueS(ErmName) & "," & toSQLValueS(CatErmID), ExceptFields)
                End If
                If sOffersID = "" Then
                    sGuid = System.Guid.NewGuid.ToString
                    sResult = DBQ.InsertNewData(DBQueries.InsertMode.GroupLayoutControl, "OFFERS",,, LayoutControlGroup2, sGuid,, "offID", toSQLValueS(sID))
                Else
                    sResult = DBQ.UpdateNewData(DBQueries.InsertMode.GroupLayoutControl, "OFFERS",,, LayoutControlGroup2, sOffersID)
                    '  FillCbo.FillCheckedListMech(chkMech, FormMode.EditRecord, sID)
                End If
                If sResult = True Then

                    'Όταν είναι σε EditMode διαγραφουμε όλους τους μηχανισμούς
                    If sOffersID <> "" Then
                        sSQL = "DELETE FROM OFFER_MECH where OFFERID = '" & sOffersID & "'"
                        Using oCmd As New SqlCommand(sSQL, CNDB)
                            oCmd.ExecuteNonQuery()
                        End Using
                    End If

                    ' Καταχώρηση Μηχανισμών
                    For Each item As DevExpress.XtraEditors.Controls.CheckedListBoxItem In chkMech.CheckedItems
                        sSQL = "INSERT INTO OFFER_MECH ([OFFID],[OFFERID],[MECHID],[modifiedBy],[createdOn])  
                        values (" & toSQLValueS(sID) & "," & toSQLValueS(sOffersID) & "," & toSQLValueS(item.Tag.ToString()) & "," &
                                            toSQLValueS(UserProps.ID.ToString) & ", getdate() )"
                        Using oCmd As New SqlCommand(sSQL, CNDB)
                            oCmd.ExecuteNonQuery()
                        End Using
                    Next
                    sResult2 = True

                    XtraMessageBox.Show("Η εγγραφή αποθηκέυτηκε με επιτυχία", "Dreamy Kitchen CRM", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Cls.ClearCtrlsGRP(LayoutControlGroup2)
                    sOffersID = ""
                    FillCbo.FillCheckedListMech(chkMech, FormMode.NewRecord)
                    Me.OFFERSTableAdapter.Fill(Me.DreamyKitchenDataSet.vw_OFFERS, System.Guid.Parse(sID))
                    cmdSave.Enabled = False
                End If
            End If

        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), "Dreamy Kitchen CRM", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub cmdSaveOff_Click(sender As Object, e As EventArgs) Handles cmdSaveOff.Click
        Dim sResult As Boolean
        Try
            If Valid.ValidateForm(LayoutControl1) Then
                Select Case Mode
                    Case FormMode.NewRecord
                        sID = System.Guid.NewGuid.ToString
                        sResult = DBQ.InsertNewData(DBQueries.InsertMode.GroupLayoutControl, "[OFF]",,, LayoutControlGroup1, sID)
                    Case FormMode.EditRecord
                        sResult = DBQ.UpdateNewData(DBQueries.InsertMode.GroupLayoutControl, "[OFF]",,, LayoutControlGroup1, sID)
                End Select
                'If CalledFromCtrl Then
                '    FillCbo.ERM(CtrlCombo)
                '    CtrlCombo.EditValue = System.Guid.Parse(sGuid)
                'Else
                Dim form As frmScroller = Frm
                form.LoadRecords("vw_OFF")
                'End If
                txtCustomCode.Select()
                If sResult = True Then
                    XtraMessageBox.Show("Η εγγραφή αποθηκέυτηκε με επιτυχία", "Dreamy Kitchen CRM", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    LayoutControlGroup2.Enabled = True : LayoutControl2.Enabled = True
                    'Cls.ClearCtrls(LayoutControl1)
                    'txtCode.Text = DBQ.GetNextId("[OFF]")
                End If
            End If

        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), "Dreamy Kitchen CRM", MessageBoxButtons.OK, MessageBoxIcon.Error)
            'Όταν είναι νέα εγγραφή και κάτι δεν έχει πάει κάλά στην προσπάθεια των καταχωρήσεων κάνει ολική διαγραφή όλων 
        End Try
    End Sub
    Private Sub cmdOffersNew_Click(sender As Object, e As EventArgs) Handles cmdOffersNew.Click
        Cls.ClearCtrlsGRP(LayoutControlGroup2)
        txtHeight.ReadOnly = True
        txtWidth.ReadOnly = True
        txtDepth.ReadOnly = True
        cmdSave.Enabled = True
    End Sub

    Private Sub GridView3_DoubleClick(sender As Object, e As EventArgs) Handles GridView3.DoubleClick
        If GridView3.GetRowCellValue(GridView3.FocusedRowHandle, "ID") = Nothing Then Exit Sub
        LoadForms.LoadFormGRP(LayoutControlGroup2, "Select * from vw_OFFERS where id ='" + GridView3.GetRowCellValue(GridView3.FocusedRowHandle, "ID").ToString() + "'")
        sOffersID = GridView3.GetRowCellValue(GridView3.FocusedRowHandle, "ID").ToString()
        FillCbo.FillCheckedListMech(chkMech, FormMode.EditRecord, sOffersID)
        cmdSave.Enabled = True
        cboERM.EditValue = System.Guid.Parse(GridView3.GetRowCellValue(GridView3.FocusedRowHandle, "ermID").ToString())
    End Sub

    Private Sub cmdOffersEdit_Click(sender As Object, e As EventArgs) Handles cmdOffersEdit.Click
        sOffersID = ""
        cmdSave.Enabled = True
    End Sub
    Private Sub cmdSameOffer_Click(sender As Object, e As EventArgs) Handles cmdSameOffer.Click
        Dim sSQL As String
        If XtraMessageBox.Show("Θέλετε να δημιουργήσω προσφορά για τα επιλεγμένα πορτάκια?", "Dreamy Kitchen CRM", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            ' Καταχώρηση Μηχανισμών
            For Each item As DevExpress.XtraEditors.Controls.CheckedListBoxItem In chkMech.CheckedItems
                sSQL = "INSERT INTO OFFERS ([ID],[OFFID],[DIMCHANGED],[QTY],[createdOn])  
                        values (" & toSQLValueS(sID) & "," & toSQLValueS(sOffersID) & "," & toSQLValueS(item.Tag.ToString()) & "," &
                                    toSQLValueS(UserProps.ID.ToString) & ", getdate() )"
                Using oCmd As New SqlCommand(sSQL, CNDB)
                    oCmd.ExecuteNonQuery()
                End Using
            Next

        End If

    End Sub

    Private Sub cmdOffersDel_Click(sender As Object, e As EventArgs) Handles cmdOffersDel.Click
        If UserProps.AllowDelete = True Then DeleteOffers() : Me.OFFERSTableAdapter.Fill(Me.DreamyKitchenDataSet.vw_OFFERS, System.Guid.Parse(sID))
    End Sub
    Private Sub DeleteOffers()
        Try
            Dim sSQL As String
            If GridView3.GetRowCellValue(GridView3.FocusedRowHandle, "ID") = Nothing Then Exit Sub
            If XtraMessageBox.Show("Θέλετε να διαγραφεί η τρέχουσα εγγραφή?", "Dreamy Kitchen CRM", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                sSQL = "DELETE FROM [OFFER_MECH] WHERE OFFERID = '" & GridView3.GetRowCellValue(GridView3.FocusedRowHandle, "ID").ToString & "'"
                Using oCmd As New SqlCommand(sSQL, CNDB)
                    oCmd.ExecuteNonQuery()
                End Using
                sSQL = "DELETE FROM [OFFERS] WHERE ID = '" & GridView3.GetRowCellValue(GridView3.FocusedRowHandle, "ID").ToString & "'"
                Using oCmd As New SqlCommand(sSQL, CNDB)
                    oCmd.ExecuteNonQuery()
                End Using
                Me.OFFERSTableAdapter.Fill(Me.DreamyKitchenDataSet.vw_OFFERS, System.Guid.Parse(sID))
                Cls.ClearCtrlsGRP(LayoutControlGroup2)
                cmdSave.Enabled = False
            End If
        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), "Dreamy Kitchen CRM", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub GridControl1_KeyDown(sender As Object, e As KeyEventArgs) Handles GridControl1.KeyDown
        Select Case e.KeyCode
            Case Keys.F2  'If UserProps.AllowInsert = True Then NewRecord()
            Case Keys.F3 'If UserProps.AllowEdit = True Then EditRecord()
            Case Keys.F5  'DeleteOffers()
            Case Keys.Delete : If UserProps.AllowDelete = True Then DeleteOffers()
        End Select
    End Sub

    Private Sub cmdOffersRefresh_Click(sender As Object, e As EventArgs) Handles cmdOffersRefresh.Click
        Me.OFFERSTableAdapter.Fill(Me.DreamyKitchenDataSet.vw_OFFERS, System.Guid.Parse(sID))
    End Sub

    Private Sub cmdCalc_Click(sender As Object, e As EventArgs) Handles cmdCalc.Click
        Try
            Dim sCalc As Decimal, W As Decimal, P As Decimal, TransformationCalc As String
            W = txtWidth.EditValue / 100
            TransformationCalc = txtCalc.EditValue
            TransformationCalc = TransformationCalc.Replace("W", W)
            TransformationCalc = TransformationCalc.Replace("P", DoorPrice).Replace(",", ".")
            Dim cmd As SqlCommand = New SqlCommand("Select " & TransformationCalc, CNDB)
            Dim sdr As SqlDataReader = cmd.ExecuteReader()
            If sdr.Read() = True Then sCalc = sdr.GetDecimal(0) : txtTotalPrice.EditValue = sCalc
            sdr.Close()
        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), "Dreamy Kitchen CRM", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub chkMech_ItemCheck(sender As Object, e As ItemCheckEventArgs) Handles chkMech.ItemCheck
        Dim Total As String, MechItem As String, sCalc As Decimal
        Dim LItem As DevExpress.XtraEditors.CheckedListBoxControl = CType(sender, DevExpress.XtraEditors.CheckedListBoxControl)
        Dim m As Match = Regex.Match(LItem.Items(e.Index).Value.ToString, "[\d.,]+")
        Dim m2 As Match = Regex.Match(txtTotalPrice.EditValue, "[\d.,]+")
        MechItem = m2.Value.Replace(",", ".") : Total = m.Value.Replace(",", ".")
        If e.State = CheckState.Checked Then
            If LItem.Items(e.Index).CheckState = CheckState.Checked Then
                Dim cmd As SqlCommand = New SqlCommand("Select " & MechItem + " + " + Total, CNDB)
                Dim sdr As SqlDataReader = cmd.ExecuteReader()
                If sdr.Read() = True Then sCalc = sdr.GetDecimal(0) : txtTotalPrice.EditValue = sCalc
                sdr.Close()
            End If
        Else
            Dim cmd As SqlCommand = New SqlCommand("Select " & MechItem + " - " + Total, CNDB)
            Dim sdr As SqlDataReader = cmd.ExecuteReader()
            If sdr.Read() = True Then sCalc = sdr.GetDecimal(0) : txtTotalPrice.EditValue = sCalc
            sdr.Close()

        End If
        'MsgBox(Decimal.Parse(Regex.Replace(x, "[^\d]", "")))
    End Sub
End Class