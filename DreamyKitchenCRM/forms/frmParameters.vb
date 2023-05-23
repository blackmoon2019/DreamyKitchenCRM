Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Tab
Imports DevExpress.Utils
Imports DevExpress.Utils.Menu
Imports DevExpress.XtraBars.Navigation
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraExport.Helpers
Imports DevExpress.XtraGrid.Menu
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraNavBar

Public Class frmParameters
    Private sID As String
    Private ManageCbo As New CombosManager
    Private Ctrl As DevExpress.XtraGrid.Views.Grid.GridView
    Private Frm As DevExpress.XtraEditors.XtraForm
    Public Mode As Byte
    Private Valid As New ValidateControls
    Private Cls As New ClearControls
    Private Prog_Prop As New ProgProp
    Private LoadForms As New FormLoader
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

    Private Sub frmParameters_Load(sender As Object, e As EventArgs) Handles Me.Load
        'TODO: This line of code loads data into the 'DM_DOORTYPES.vw_DOOR_TYPE_V2' table. You can move, or remove it, as needed.
        Me.Vw_DOOR_TYPE_V2TableAdapter.Fill(Me.DM_DOORTYPES.vw_DOOR_TYPE_V2)
        'TODO: This line of code loads data into the 'DreamyKitchenDataSet1.MAILS' table. You can move, or remove it, as needed.
        Me.MAILSTableAdapter.Fill(Me.DreamyKitchenDataSet1.MAILS)
        'TODO: This line of code loads data into the 'DreamyKitchenDataSet.vw_BENCH' table. You can move, or remove it, as needed.
        Me.Vw_BENCHTableAdapter.Fill(Me.DreamyKitchenDataSet.vw_BENCH)
        'TODO: This line of code loads data into the 'DreamyKitchenDataSet.vw_COLORSPVC' table. You can move, or remove it, as needed.
        Me.Vw_COLORSPVCTableAdapter.Fill(Me.DreamyKitchenDataSet.vw_COLORSPVC)
        'TODO: This line of code loads data into the 'DreamyKitchenDataSet.vw_COLORSBOX' table. You can move, or remove it, as needed.
        Me.Vw_COLORSBOXTableAdapter.Fill(Me.DreamyKitchenDataSet.vw_COLORSBOX)
        'ΦΠΑ
        txtVAT.EditValue = Prog_Prop.GetProgvat()
        'Δεκαδικά Προγράμματος
        txtDecimals.EditValue = Prog_Prop.GetProgDecimals()
        'Technical Support Email
        txtEmail.EditValue = Prog_Prop.GetProgTechSupportEmail
        Me.CenterToScreen()

    End Sub

    Private Sub frmParameters_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        If Me.WindowState = FormWindowState.Maximized Then frmMain.XtraTabbedMdiManager1.Dock(Me, frmMain.XtraTabbedMdiManager1)
    End Sub

    Private Sub navGen_LinkClicked(sender As Object, e As NavBarLinkEventArgs)
    End Sub

    Private Sub V_BOX_COLOR_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles V_BOX_COLOR.ButtonClick

        Select Case e.Button.Index
            Case 1 : ManageCbo.ManageDoorType(V_BOX_COLOR, FormMode.NewRecord, "DE86FD16-2154-4E2A-B025-4D34BDF8C808")
            Case 2 : ManageCbo.ManageDoorType(V_BOX_COLOR, FormMode.EditRecord)
            Case 3 : V_BOX_COLOR.EditValue = Nothing
        End Select
    End Sub



    Private Sub K_BOX_COLOR_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles K_BOX_COLOR.ButtonClick
        Select Case e.Button.Index
            Case 1 : ManageCbo.ManageDoorType(K_BOX_COLOR, FormMode.NewRecord, "DE86FD16-2154-4E2A-B025-4D34BDF8C808")
            Case 2 : ManageCbo.ManageDoorType(K_BOX_COLOR, FormMode.EditRecord)
            Case 3 : K_BOX_COLOR.EditValue = Nothing
        End Select
    End Sub


    Private Sub Y_BOX_COLOR_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles Y_BOX_COLOR.ButtonClick
        Select Case e.Button.Index
            Case 1 : ManageCbo.ManageDoorType(Y_BOX_COLOR, FormMode.NewRecord, "DE86FD16-2154-4E2A-B025-4D34BDF8C808")
            Case 2 : ManageCbo.ManageDoorType(Y_BOX_COLOR, FormMode.EditRecord)
            Case 3 : Y_BOX_COLOR.EditValue = Nothing
        End Select
    End Sub



    Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click
        Prog_Prop.SetProgPROSF(LayoutControl3)
        Prog_Prop.GetProgPROSF()
        XtraMessageBox.Show("Η εγγραφή αποθηκέυτηκε με επιτυχία", "Dreamy Kitchen CRM", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
    Private Sub cmdExit_Click(sender As Object, e As EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub

    Private Sub cmdSaveGen_Click(sender As Object, e As EventArgs) Handles cmdSaveGen.Click
        'ΦΠΑ Προγράμματος
        Prog_Prop.SetProgVAT(txtVAT.EditValue)

        'Δεκαδικά Προγράμματος
        Prog_Prop.SetProgDecimals(txtDecimals.EditValue)

        'Email Support
        Prog_Prop.SetProgTechSupportEmail(txtEmail.EditValue)


    End Sub

    Private Sub TabPane2_SelectedPageChanged(sender As Object, e As SelectedPageChangedEventArgs) Handles TabPane2.SelectedPageChanged
        Select Case TabPane2.SelectedPageIndex
            Case 0
                'ΦΠΑ
                txtVAT.EditValue = Prog_Prop.GetProgvat()
                'Δεκαδικά Προγράμματος
                txtDecimals.EditValue = Prog_Prop.GetProgDecimals()
                'Technical Support Email
                txtEmail.EditValue = Prog_Prop.GetProgTechSupportEmail
            Case 1 : Prog_Prop.GetProgPROSF(LayoutControl3)
            Case 2
                LoadForms.LoadDataToGrid(grdEquipment, GridView2,
                    "Select  E.ID,E.code,name ,price,cast(case when (SELECT FLdVAL FROM PRM_DET WHERE TBL='EQUIPMENT' AND fld='ID' AND fldVal=e.id) is null then 0 else 1 end as bit) as  checked " &
                     "From vw_EQUIPMENT E where equipmentCatID='8AA21DC8-7D98-4596-8B73-9E664E955FFB' ORDER BY NAME")
                LoadForms.RestoreLayoutFromXml(GridView2, "CCT_ORDERS_KITCHEN_EQUIPMENT_PRM_def.xml")
                GridView2.Columns.Item("name").OptionsColumn.AllowEdit = False : GridView2.Columns.Item("code").OptionsColumn.AllowEdit = False : GridView2.Columns.Item("price").OptionsColumn.AllowEdit = False
                LoadForms.LoadDataToGrid(grdEquipmentCloset, GridView1,
                    "Select  E.ID,E.code,name ,price,cast(case when (SELECT FLdVAL FROM PRM_DET WHERE TBL='EQUIPMENT' AND fld='ID' AND fldVal=e.id) is null then 0 else 1 end as bit) as  checked " &
                     "From vw_EQUIPMENT E where equipmentCatID='DB158CAB-11EA-423B-9430-0C8A0CEB1D62' ORDER BY NAME")
                LoadForms.RestoreLayoutFromXml(GridView1, "CCT_ORDERS_KITCHEN_EQUIPMENT_CLOSET_PRM_def.xml")
                GridView1.Columns.Item("name").OptionsColumn.AllowEdit = False : GridView1.Columns.Item("code").OptionsColumn.AllowEdit = False : GridView1.Columns.Item("price").OptionsColumn.AllowEdit = False
            Case 3 : Prog_Prop.GetProgPROSF(LayoutControl4)
            Case 4 : Prog_Prop.GetProgEmailInst(LayoutControl5) : Prog_Prop.GetProgEmailSup(LayoutControlItem76) : SUP_ORDERS_MAIL.EditValue = ProgProps.EmailOrders
            Case Else
        End Select
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Me.Close()
    End Sub

    Private Sub GridView2_PopupMenuShowing(sender As Object, e As PopupMenuShowingEventArgs) Handles GridView2.PopupMenuShowing
        If e.MenuType = GridMenuType.Column Then
            Dim menu As DevExpress.XtraGrid.Menu.GridViewColumnMenu = TryCast(e.Menu, GridViewColumnMenu)
            Dim item As New DXEditMenuItem()
            'menu.Items.Clear()
            If menu.Column IsNot Nothing Then
                Dim popRenameColumn As New RepositoryItemTextEdit
                popRenameColumn.Name = "RenameColumn"
                menu.Items.Add(New DXEditMenuItem("Μετονομασία Στήλης", popRenameColumn, AddressOf OnEditValueChanged, Nothing, Nothing, 100, 0))
                item = menu.Items.Item("Μετονομασία Στήλης")
                item.EditValue = menu.Column.GetTextCaption
                item.Tag = menu.Column.AbsoluteIndex

                menu.Items.Add(New DXMenuItem("Αποθήκευση όψης", AddressOf OnSaveView, Nothing, Nothing, Nothing, Nothing))
                '5nd Custom Menu Item
                menu.Items.Add(New DXMenuItem("Συγχρονισμός όψης από Server", AddressOf OnSyncView, Nothing, Nothing, Nothing, Nothing))

            End If
        End If
    End Sub
    'Συγχρονισμός όψης από Server
    Private Sub OnSyncView(ByVal sender As System.Object, ByVal e As EventArgs)
        If XtraMessageBox.Show("Θέλετε να γίνει μεταφορά της όψης από τον server?", "Dreamy Kitchen CRM", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            ' Έλεγχος αν υπάρχει όψη με μεταγενέστερη ημερομηνία στον Server
            If System.IO.File.Exists(ProgProps.ServerViewsPath & "DSGNS\DEF\CCT_ORDERS_KITCHEN_EQUIPMENT_PRM_def.xml") = True Then
                My.Computer.FileSystem.CopyFile(ProgProps.ServerViewsPath & "DSGNS\DEF\CCT_ORDERS_KITCHEN_EQUIPMENT_PRM_def.xml", Application.StartupPath & "\DSGNS\DEF\CCT_ORDERS_KITCHEN_EQUIPMENT_PRM_def.xml", True)
                GridView2.RestoreLayoutFromXml(Application.StartupPath & "\DSGNS\DEF\CCT_ORDERS_KITCHEN_EQUIPMENT_PRM_def.xml", OptionsLayoutBase.FullLayout)
            End If
        End If
    End Sub

    Private Sub OnSaveView(ByVal sender As System.Object, ByVal e As EventArgs)
        Dim item As DXMenuItem = TryCast(sender, DXMenuItem)
        GridView2.SaveLayoutToXml(Application.StartupPath & "\DSGNS\DEF\CCT_ORDERS_KITCHEN_EQUIPMENT_PRM_def.xml", OptionsLayoutBase.FullLayout)
        XtraMessageBox.Show("Η όψη αποθηκεύτηκε με επιτυχία", "Dreamy Kitchen CRM", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ' Μόνο αν ο Χρήστης είναι ο Παναγόπουλος
        If UserProps.ID.ToString.ToUpper = "3F9DC32E-BE5B-4D46-A13C-EA606566CF32" Or UserProps.ID.ToString.ToUpper = "E9CEFD11-47C0-4796-A46B-BC41C4C3606B" Then
            If XtraMessageBox.Show("Θέλετε να γίνει κοινοποίηση της όψης? Εαν επιλέξετε 'Yes' όλοι οι χρήστες θα έχουν την ίδια όψη", "Dreamy Kitchen CRM", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                If My.Computer.FileSystem.FileExists(ProgProps.ServerViewsPath & "DSGNS\DEF\CCT_ORDERS_KITCHEN_EQUIPMENT_PRM_def.xml") = False Then GridView2.OptionsLayout.LayoutVersion = "v1"
                GridView2.SaveLayoutToXml(ProgProps.ServerViewsPath & "DSGNS\DEF\CCT_ORDERS_KITCHEN_EQUIPMENT_PRM_def.xml", OptionsLayoutBase.FullLayout)
            End If
        End If

    End Sub
    Private Sub OnEditValueChanged(ByVal sender As System.Object, ByVal e As EventArgs)
        Dim item As New DXEditMenuItem()
        item = sender
        If item.Tag Is Nothing Then Exit Sub
        GridView2.Columns(item.Tag).Caption = item.EditValue
        'MessageBox.Show(item.EditValue.ToString())
    End Sub
    Private Sub GridView1_PopupMenuShowing(sender As Object, e As PopupMenuShowingEventArgs) Handles GridView1.PopupMenuShowing
        If e.MenuType = GridMenuType.Column Then
            Dim menu As DevExpress.XtraGrid.Menu.GridViewColumnMenu = TryCast(e.Menu, GridViewColumnMenu)
            Dim item As New DXEditMenuItem()
            'menu.Items.Clear()
            If menu.Column IsNot Nothing Then
                Dim popRenameColumn As New RepositoryItemTextEdit
                popRenameColumn.Name = "RenameColumn"
                menu.Items.Add(New DXEditMenuItem("Μετονομασία Στήλης", popRenameColumn, AddressOf OnEditValueChangedCloset, Nothing, Nothing, 100, 0))
                item = menu.Items.Item("Μετονομασία Στήλης")
                item.EditValue = menu.Column.GetTextCaption
                item.Tag = menu.Column.AbsoluteIndex

                menu.Items.Add(New DXMenuItem("Αποθήκευση όψης", AddressOf OnSaveViewCloset, Nothing, Nothing, Nothing, Nothing))
                '5nd Custom Menu Item
                menu.Items.Add(New DXMenuItem("Συγχρονισμός όψης από Server", AddressOf OnSyncViewCloset, Nothing, Nothing, Nothing, Nothing))

            End If
        End If
    End Sub
    'Συγχρονισμός όψης από Server
    Private Sub OnSyncViewCloset(ByVal sender As System.Object, ByVal e As EventArgs)
        If XtraMessageBox.Show("Θέλετε να γίνει μεταφορά της όψης από τον server?", "Dreamy Kitchen CRM", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            ' Έλεγχος αν υπάρχει όψη με μεταγενέστερη ημερομηνία στον Server
            If System.IO.File.Exists(ProgProps.ServerViewsPath & "DSGNS\DEF\CCT_ORDERS_KITCHEN_EQUIPMENT_CLOSET_PRM_def.xml") = True Then
                My.Computer.FileSystem.CopyFile(ProgProps.ServerViewsPath & "DSGNS\DEF\CCT_ORDERS_KITCHEN_EQUIPMENT_CLOSET_PRM_def.xml", Application.StartupPath & "\DSGNS\DEF\CCT_ORDERS_KITCHEN_EQUIPMENT_CLOSET_PRM_def.xml", True)
                GridView1.RestoreLayoutFromXml(Application.StartupPath & "\DSGNS\DEF\CCT_ORDERS_KITCHEN_EQUIPMENT_CLOSET_PRM_def.xml", OptionsLayoutBase.FullLayout)
            End If
        End If
    End Sub

    Private Sub OnSaveViewCloset(ByVal sender As System.Object, ByVal e As EventArgs)
        Dim item As DXMenuItem = TryCast(sender, DXMenuItem)
        GridView1.SaveLayoutToXml(Application.StartupPath & "\DSGNS\DEF\CCT_ORDERS_KITCHEN_EQUIPMENT_CLOSET_PRM_def.xml", OptionsLayoutBase.FullLayout)
        XtraMessageBox.Show("Η όψη αποθηκεύτηκε με επιτυχία", "Dreamy Kitchen CRM", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ' Μόνο αν ο Χρήστης είναι ο Παναγόπουλος
        If UserProps.ID.ToString.ToUpper = "3F9DC32E-BE5B-4D46-A13C-EA606566CF32" Or UserProps.ID.ToString.ToUpper = "E9CEFD11-47C0-4796-A46B-BC41C4C3606B" Then
            If XtraMessageBox.Show("Θέλετε να γίνει κοινοποίηση της όψης? Εαν επιλέξετε 'Yes' όλοι οι χρήστες θα έχουν την ίδια όψη", "Dreamy Kitchen CRM", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                If My.Computer.FileSystem.FileExists(ProgProps.ServerViewsPath & "DSGNS\DEF\CCT_ORDERS_KITCHEN_EQUIPMENT_CLOSET_PRM_def.xml") = False Then GridView1.OptionsLayout.LayoutVersion = "v1"
                GridView1.SaveLayoutToXml(ProgProps.ServerViewsPath & "DSGNS\DEF\CCT_ORDERS_KITCHEN_EQUIPMENT_CLOSET_PRM_def.xml", OptionsLayoutBase.FullLayout)
            End If
        End If

    End Sub
    Private Sub OnEditValueChangedCloset(ByVal sender As System.Object, ByVal e As EventArgs)
        Dim item As New DXEditMenuItem()
        item = sender
        If item.Tag Is Nothing Then Exit Sub
        GridView1.Columns(item.Tag).Caption = item.EditValue
        'MessageBox.Show(item.EditValue.ToString())
    End Sub


    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles cmdExit2.Click
        Me.Close()
    End Sub

    Private Sub cmdSaveEquipment_Click(sender As Object, e As EventArgs) Handles cmdSaveEquipment.Click
        InsertSelectedRows()
        InsertSelectedClosetRows()
    End Sub
    Private Sub InsertSelectedRows()
        Dim sSQL As String
        Dim I As Integer
        sSQL = "DELETE FROM PRM_DET WHERE tbl='EQUIPMENT'"
        Using oCmd As New SqlCommand(sSQL, CNDB)
            oCmd.ExecuteNonQuery()
        End Using
        Dim Selected As Boolean
        For I = 0 To GridView2.RowCount - 1
            Selected = GridView2.GetRowCellValue(I, "checked")
            If Selected = True Then
                sSQL = "INSERT INTO PRM_DET(TBL,FLD,fldVal,defVal)  VALUES ( 'EQUIPMENT','ID'," & toSQLValueS(GridView2.GetRowCellValue(I, "ID").ToString) & ",1)"
                Using oCmd As New SqlCommand(sSQL, CNDB)
                    oCmd.ExecuteNonQuery()
                End Using
            End If
        Next
        XtraMessageBox.Show("Η εγγραφή αποθηκέυτηκε με επιτυχία", "Dreamy Kitchen CRM", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
    Private Sub InsertSelectedClosetRows()
        Dim sSQL As String
        Dim I As Integer
        'sSQL = "DELETE FROM PRM_DET WHERE tbl='EQUIPMENT'"
        'Using oCmd As New SqlCommand(sSQL, CNDB)
        '    oCmd.ExecuteNonQuery()
        'End Using
        Dim Selected As Boolean
        For I = 0 To GridView1.RowCount - 1
            Selected = GridView1.GetRowCellValue(I, "checked")
            If Selected = True Then
                sSQL = "INSERT INTO PRM_DET(TBL,FLD,fldVal,defVal)  VALUES ( 'EQUIPMENT','ID'," & toSQLValueS(GridView1.GetRowCellValue(I, "ID").ToString) & ",1)"
                Using oCmd As New SqlCommand(sSQL, CNDB)
                    oCmd.ExecuteNonQuery()
                End Using
            End If
        Next
        XtraMessageBox.Show("Η εγγραφή αποθηκέυτηκε με επιτυχία", "Dreamy Kitchen CRM", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub SimpleButton3_Click(sender As Object, e As EventArgs) Handles SimpleButton3.Click
        Prog_Prop.SetProgPROSF(LayoutControl4)
        Prog_Prop.GetProgPROSF()
        XtraMessageBox.Show("Η εγγραφή αποθηκέυτηκε με επιτυχία", "Dreamy Kitchen CRM", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub SimpleButton2_Click_1(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        Me.Close()
    End Sub

    Private Sub cmdSaveInstEmail_Click(sender As Object, e As EventArgs) Handles cmdSaveEmail.Click
        Prog_Prop.SetProgInstEmail(ELLIPSE_BODY_INF.Text, INSTALLATIONS_EMAIL.Text, ELLIPSE_SUBJECT_INF.Text, INSTALLATIONS_EMAIL_SUP.Text,
                                   ELLIPSE_SUBJECT_SUP_INF.Text, ELLIPSE_BODY_SUP_INF.Text, ELLIPSE_BODY_INF_APPOINTMENT.Text, INSTALLATIONS_SUBJECT_INF.Text,
                                   INSTALLATIONS_BODY_INF_APPOINTMENT.Text, ELLIPSE_SUBJECT_INF_APPOINTMENT.Text, ELLIPSE_SUBJECT_COMPLETE_INF.Text,
                                   ELLIPSE_BODY_COMPLETE_INF.Text)
        Prog_Prop.GetProgEmailInst(LayoutControl5)
        Prog_Prop.SetProgSupEmail(SUP_ORDERS_MAIL.Text)
        Prog_Prop.GetProgEmailSup(LayoutControlItem76)
        XtraMessageBox.Show("Η εγγραφή αποθηκέυτηκε με επιτυχία", "Dreamy Kitchen CRM", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub cmdExitInstEmail_Click(sender As Object, e As EventArgs) Handles cmdExitInstEmail.Click
        Me.Close()
    End Sub

    Private Sub V_HEIGHT_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles V_HEIGHT.ButtonClick
        Select Case e.Button.Index
            Case 1 : V_HEIGHT.EditValue = Nothing
        End Select
    End Sub
    Private Sub K_HEIGHT_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles K_HEIGHT.ButtonClick
        Select Case e.Button.Index
            Case 1 : K_HEIGHT.EditValue = Nothing
        End Select
    End Sub
    Private Sub Y_HEIGHT_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles Y_HEIGHT.ButtonClick
        Select Case e.Button.Index
            Case 1 : Y_HEIGHT.EditValue = Nothing
        End Select
    End Sub
    Private Sub legs_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles LEGS.ButtonClick
        Select Case e.Button.Index
            Case 1 : LEGS.EditValue = Nothing
        End Select
    End Sub

    Private Sub CLOSET_BOX_COLOR_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles CLOSET_BOX_COLOR.ButtonClick
        Select Case e.Button.Index
            Case 1 : ManageCbo.ManageDoorType(CLOSET_BOX_COLOR, FormMode.NewRecord, "DE86FD16-2154-4E2A-B025-4D34BDF8C808")
            Case 2 : ManageCbo.ManageDoorType(CLOSET_BOX_COLOR, FormMode.EditRecord)
            Case 3 : CLOSET_BOX_COLOR.EditValue = Nothing
        End Select
    End Sub
End Class