Imports System.Windows.Forms
Imports System.Data.SqlClient
Imports DevExpress.XtraSplashScreen
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraBars
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.Utils.Menu
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Menu
Imports DevExpress.XtraPrinting
Imports DevExpress.Export
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.Utils
Imports DevExpress.XtraGrid.Views.Card
Imports DevExpress.XtraGrid.Localization
Imports DevExpress.XtraGrid

Public Class frmScroller
    Private myConn As SqlConnection
    Private myCmd As SqlCommand
    Private myReader As SqlDataReader
    Private sDataTable As String
    Private sWhereCondition As String
    Private sDataDetail As String
    Private CurrentView As String
    Private LoadForms As New FormLoader
    Public WriteOnly Property DataTable As String
        Set(value As String)
            sDataTable = value
        End Set
    End Property
    Public WriteOnly Property DataDetail As String
        Set(value As String)
            sDataDetail = value
        End Set
    End Property
    Public WriteOnly Property DataTableWhereCondition As String
        Set(value As String)
            sWhereCondition = value
        End Set
    End Property

    'Private settings = System.Configuration.ConfigurationManager.AppSettings
    Private Sub frmScroller_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            'Λίστα με τιμές για TOP RECORDS
            LoadComboRecordValues()
            popSaveAsView.EditValue = BarViews.EditValue
            If BarViews.EditValue = "" Then popSaveView.Enabled = False : popDeleteView.Enabled = False
            'Φορτώνει όλες τις ονομασίες των στηλών από τον SQL. Από το πεδίο Description
            'LoadForms.LoadColumnDescriptionNames(grdMain, GridView1, , sDataTable)

            'Παίρνω το όνομα της όψης για τον συγκεκριμένο χρήστη και για τον συγκεκριμένο πίνακα 
            GetCurrentView(True)
            'Φορτώνει όλες τις ονομασίες των στηλών από τον SQL. Από το πεδίο Description
            LoadForms.LoadColumnDescriptionNames(grdMain, GridView1, , sDataTable)

            'Φόρτωση Εγγραφών
            LoadRecords()
            'Φόρτωση Σχεδίων στην Λίστα βάση επιλογής από το μενού
            'LoadViews()

            LoadConditionalFormatting()

            GridLocalizer.Active = New GreekGridLocalizer()
            'Κρύψιμο Στηλών
            'HideColumns(GridView1, "ID")
            'Δικαιώματα
            BarNewRec.Enabled = UserProps.AllowInsert
            BarDelete.Enabled = UserProps.AllowDelete
            BarEdit.Enabled = UserProps.AllowEdit
            If sDataTable = "vw_CCT" Then
                Dim sItem As BarButtonItem = New BarButtonItem(BarManager1, "vw_CCT")
                sItem.Caption = "Εμφάνιση Κινήσεων Πελάτη"
                sItem.Name = "ViewCusMov"
                PopupMenuRows.AddItem(sItem)
            End If
        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), "Dreamy Kitchen CRM", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub LoadConditionalFormatting()
        Select Case sDataTable
            Case "vw_OFF"
                Dim formatConditionRuleExpression As New StyleFormatCondition()
                formatConditionRuleExpression.Appearance.ForeColor = Color.Red
                formatConditionRuleExpression.Appearance.Options.UseBackColor = True
                formatConditionRuleExpression.ApplyToRow = True
                formatConditionRuleExpression.Column = GridView1.Columns("cancelOFF")
                formatConditionRuleExpression.Condition = FormatConditionEnum.Expression
                formatConditionRuleExpression.Expression = "cancelOFF = 1"
                GridView1.FormatConditions.Add(formatConditionRuleExpression)
        End Select
    End Sub

    'Λίστα με τιμές για TOP RECORDS
    'Φόρτωση Λίστας με εγγραφές 
    Private Sub LoadComboRecordValues()
        CType(BarRecords.Edit, RepositoryItemComboBox).Items.Add("30")
        CType(BarRecords.Edit, RepositoryItemComboBox).Items.Add("200")
        CType(BarRecords.Edit, RepositoryItemComboBox).Items.Add("1000")
        CType(BarRecords.Edit, RepositoryItemComboBox).Items.Add("10000")
        CType(BarRecords.Edit, RepositoryItemComboBox).Items.Add("ALL")
        BarRecords.EditValue = My.Settings.Records
    End Sub
    'Φόρτωση όψεων Per User στο Combo
    Private Sub LoadViews()
        Try
            BarViews.EditValue = ""
            'Εαν δεν υπάρχει Default Σχέδιο δημιουργεί
            If My.Computer.FileSystem.FileExists(Application.StartupPath & "\DSGNS\DEF\" & sDataTable & "_def.xml") = False Then
                GridView1.OptionsLayout.LayoutVersion = "v1"
                GridView1.SaveLayoutToXml(Application.StartupPath & "\DSGNS\DEF\" & sDataTable & "_def.xml", OptionsLayoutBase.FullLayout)
            End If
            If My.Computer.FileSystem.FileExists(Application.StartupPath & "\DSGNS\DEF\" & sDataDetail & "_def.xml") = False Then
                If sDataDetail <> "" Then GridView2.SaveLayoutToXml(Application.StartupPath & "\DSGNS\DEF\" & sDataDetail & "_def.xml", OptionsLayoutBase.FullLayout)
            End If

            'Εαν δεν υπάρχει Folder Σχεδίου για το συγκεκριμένο πίνακα δημιουργεί
            If My.Computer.FileSystem.DirectoryExists(Application.StartupPath & "\DSGNS\" & sDataTable) = False Then _
                My.Computer.FileSystem.CreateDirectory(Application.StartupPath & "\DSGNS\" & sDataTable)

            'Εαν δεν υπάρχει Folder Σχεδίου για το Detail πίνακα δημιουργεί
            If My.Computer.FileSystem.DirectoryExists(Application.StartupPath & "\DSGNS\" & sDataDetail) = False Then _
                My.Computer.FileSystem.CreateDirectory(Application.StartupPath & "\DSGNS\" & sDataDetail)

            CType(BarViews.Edit, RepositoryItemComboBox).Items.Clear()
            'Ψάχνει όλα τα σχέδια  του συκεκριμένου χρήστη για τον συγκεκριμένο πίνακα
            Dim files() As String = IO.Directory.GetFiles(Application.StartupPath & "\DSGNS\" & sDataTable, "*_" & UserProps.Code & "*")
            For Each sFile As String In files
                CType(BarViews.Edit, RepositoryItemComboBox).Items.Add(System.IO.Path.GetFileName(sFile))
            Next
            BarViews.EditValue = CurrentView
            If CurrentView = "" Then
                'grdMain.DefaultView.RestoreLayoutFromXml(Application.StartupPath & "\DSGNS\DEF\" & sDataTable & "_def.xml")
                GridView1.RestoreLayoutFromXml(Application.StartupPath & "\DSGNS\DEF\" & sDataTable & "_def.xml", OptionsLayoutBase.FullLayout)
                If sDataDetail <> "" Then GridView2.RestoreLayoutFromXml(Application.StartupPath & "\DSGNS\DEF\" & sDataDetail & "_def.xml", OptionsLayoutBase.FullLayout)
            Else
                'grdMain.DefaultView.RestoreLayoutFromXml(Application.StartupPath & "\DSGNS\" & sDataTable & "\" & BarViews.EditValue)
                GridView1.RestoreLayoutFromXml(Application.StartupPath & "\DSGNS\" & sDataTable & "\" & BarViews.EditValue, OptionsLayoutBase.FullLayout)
                If sDataDetail <> "" Then GridView2.RestoreLayoutFromXml(Application.StartupPath & "\DSGNS\" & sDataDetail & "\" & BarViews.EditValue, OptionsLayoutBase.FullLayout)
            End If
        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), "Dreamy Kitchen CRM", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    'Διαγραφη Εγγραφής
    Private Sub DeleteRecord()
        Dim sSQL As String
        Dim sSQL2 As String
        Try
            If GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "ID") = Nothing Then Exit Sub
            If XtraMessageBox.Show("Θέλετε να διαγραφεί η τρέχουσα εγγραφή?", "Dreamy Kitchen CRM", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                Select Case sDataTable
                    Case "vw_USR" : sSQL = "DELETE FROM USR WHERE ID = '" & GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "ID").ToString & "'"
                    Case "vw_MAILS" : sSQL = "DELETE FROM MAILS WHERE ID = '" & GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "ID").ToString & "'"
                    Case "vw_RIGHTS" : sSQL = "DELETE FROM RIGHTS WHERE ID = '" & GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "ID").ToString & "'"
                        sSQL2 = "DELETE FROM FORM_RIGHTS WHERE RID = '" & GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "ID").ToString & "'"
                    Case "vw_COU" : sSQL = "DELETE FROM COU WHERE ID = '" & GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "ID").ToString & "'"
                    Case "vw_AREAS" : sSQL = "DELETE FROM AREAS WHERE ID = '" & GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "ID").ToString & "'"
                    Case "vw_ADR" : sSQL = "DELETE FROM ADR WHERE ID = '" & GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "ID").ToString & "'"
                    Case "vw_DOY" : sSQL = "DELETE FROM DOY WHERE ID = '" & GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "ID").ToString & "'"
                    Case "vw_PRF" : sSQL = "DELETE FROM PRF WHERE ID = '" & GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "ID").ToString & "'"
                    Case "vw_STATUS" : sSQL = "DELETE FROM STATUS WHERE ID = '" & GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "ID").ToString & "'"
                    Case "vw_SOURCE" : sSQL = "DELETE FROM SCR WHERE ID = '" & GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "ID").ToString & "'"
                    Case "vw_CCT" : sSQL = "DELETE FROM CCT WHERE ID = '" & GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "ID").ToString & "'"
                    Case "vw_SALERS" : sSQL = "DELETE FROM SALERS WHERE ID = '" & GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "ID").ToString & "'"
                    Case "vw_CCT_M" : sSQL = "DELETE FROM CCT_M WHERE ID = '" & GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "ID").ToString & "'"
                    Case "vw_REM_VALUES" : sSQL = "DELETE FROM REM_VALUES WHERE ID = '" & GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "ID").ToString & "'"
                    Case "vw_NOTES_L" : sSQL = "DELETE FROM NOTES_L WHERE ID = '" & GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "ID").ToString & "'"
                    Case "vw_DOOR_TYPE" : sSQL = "DELETE FROM DOOR_TYPE WHERE ID = '" & GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "ID").ToString & "'"
                    Case "vw_CAT_ERM" : sSQL = "DELETE FROM CAT_ERM WHERE ID = '" & GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "ID").ToString & "'"
                    Case "vw_ERM" : sSQL = "DELETE FROM ERM WHERE ID = '" & GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "ID").ToString & "'"
                    Case "vw_BENCH" : sSQL = "DELETE FROM BENCH WHERE ID = '" & GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "ID").ToString & "'"
                    Case "vw_MECH" : sSQL = "DELETE FROM MECH WHERE ID = '" & GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "ID").ToString & "'"
                    Case "vw_TECH_CAT" : sSQL = "DELETE FROM TECH_CAT WHERE ID = '" & GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "ID").ToString & "'"
                    Case "vw_TECH_SUP" : sSQL = "DELETE FROM TECH_SUP WHERE ID = '" & GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "ID").ToString & "'"
                    Case "vw_COLORS" : sSQL = "DELETE FROM COLORS WHERE ID = '" & GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "ID").ToString & "'"
                    Case "vw_SIDES" : sSQL = "DELETE FROM SIDES WHERE ID = '" & GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "ID").ToString & "'"
                    Case "vw_DIM" : sSQL = "DELETE FROM DIM WHERE ID = '" & GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "ID").ToString & "'"
                    Case "vw_SER" : sSQL = "DELETE FROM SER WHERE ID = '" & GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "ID").ToString & "'"
                    Case "vw_INST" : sSQL = "DELETE FROM INST WHERE ID = '" & GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "ID").ToString & "'"
                    Case "vw_BANKS" : sSQL = "DELETE FROM BANKS WHERE ID = '" & GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "ID").ToString & "'"
                    Case "vw_TRANSH"
                        sSQL = "DELETE FROM CCTF FROM CCT_F CCTF INNER JOIN TRANSH ON CCTF.cctID = TRANSH.cusID AND CCTF.isinvoice=1 
                                WHERE TRANSH.ID = '" & GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "ID").ToString & "'"
                        Using oCmd As New SqlCommand(sSQL, CNDB)
                            oCmd.ExecuteNonQuery()
                        End Using
                        sSQL = "DELETE FROM TRANSD WHERE TRANSHID = '" & GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "ID").ToString & "'"
                        Using oCmd As New SqlCommand(sSQL, CNDB)
                            oCmd.ExecuteNonQuery()
                        End Using
                        sSQL = "DELETE FROM TRANSH WHERE ID = '" & GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "ID").ToString & "'"
                    Case "vw_OFF"
                        sSQL = "DELETE FROM [OFFER_MECH] WHERE offID = '" & GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "ID").ToString & "'"
                        Using oCmd As New SqlCommand(sSQL, CNDB)
                            oCmd.ExecuteNonQuery()
                        End Using
                        sSQL = "DELETE FROM [OFFER_SIDES] WHERE offID = '" & GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "ID").ToString & "'"
                        Using oCmd As New SqlCommand(sSQL, CNDB)
                            oCmd.ExecuteNonQuery()
                        End Using
                        sSQL = "DELETE FROM [OFF_TOTAL] WHERE offID = '" & GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "ID").ToString & "'"
                        Using oCmd As New SqlCommand(sSQL, CNDB)
                            oCmd.ExecuteNonQuery()
                        End Using
                        sSQL = "DELETE FROM [OFFERS] WHERE offID = '" & GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "ID").ToString & "'"
                        Using oCmd As New SqlCommand(sSQL, CNDB)
                            oCmd.ExecuteNonQuery()
                        End Using
                        sSQL = "DELETE FROM [OFF_SUBOFF] WHERE offID = '" & GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "ID").ToString & "'"
                        Using oCmd As New SqlCommand(sSQL, CNDB)
                            oCmd.ExecuteNonQuery()
                        End Using
                        sSQL = "DELETE FROM [OFF_DET] WHERE offID = '" & GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "ID").ToString & "'"
                        Using oCmd As New SqlCommand(sSQL, CNDB)
                            oCmd.ExecuteNonQuery()
                        End Using
                        sSQL = "DELETE FROM [OFF] WHERE ID = '" & GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "ID").ToString & "'"
                    Case "vw_CALC" : sSQL = "DELETE FROM CALC WHERE ID = '" & GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "ID").ToString & "'"
                    Case "vw_CAT_SUB_ERM" : sSQL = "DELETE FROM CAT_SUB_ERM WHERE ID = '" & GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "ID").ToString & "'"

                End Select

                Using oCmd As New SqlCommand(sSQL, CNDB)
                    oCmd.ExecuteNonQuery()
                End Using
                If sSQL2 <> "" Then
                    Using oCmd As New SqlCommand(sSQL2, CNDB)
                        oCmd.ExecuteNonQuery()
                    End Using
                End If
                LoadRecords()
                XtraMessageBox.Show("Η εγγραφή διαγράφηκε με επιτυχία", "Dreamy Kitchen CRM", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), "Dreamy Kitchen CRM", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    'Επιλογή όψης
    Private Sub BarViews_EditValueChanged(sender As Object, e As EventArgs) Handles BarViews.EditValueChanged
        Try
            popSaveAsView.EditValue = BarViews.EditValue
            If BarViews.EditValue <> "" Then
                'grdMain.DefaultView.RestoreLayoutFromXml(Application.StartupPath & "\DSGNS\" & sDataTable & "\" & BarViews.EditValue)
                GridView1.RestoreLayoutFromXml(Application.StartupPath & "\DSGNS\" & sDataTable & "\" & BarViews.EditValue, OptionsLayoutBase.FullLayout)
                If sDataDetail <> "" Then GridView2.RestoreLayoutFromXml(Application.StartupPath & "\DSGNS\" & sDataDetail & "\" & BarViews.EditValue, OptionsLayoutBase.FullLayout)
                CurrentView = BarViews.EditValue
                popSaveView.Enabled = True
                popDeleteView.Enabled = True
            End If
        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), "Dreamy Kitchen CRM", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    'Κλείσιμο Φόρμας
    Private Sub frmScroller_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        'Παίρνω το όνομα της όψης για τον συγκεκριμένο χρήστη και για τον συγκεκριμένο πίνακα και το αποθηκεύω στην βάση
        GetCurrentView(False)
        If sDataDetail = "" Then myReader.Close()
    End Sub
    'Διαγραφή όψης
    Private Sub popDeleteView_ItemClick(sender As Object, e As ItemClickEventArgs) Handles popDeleteView.ItemClick
        If XtraMessageBox.Show("Θέλετε να διαγραφεί η τρέχουσα όψη?", "Dreamy Kitchen CRM", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            If BarViews.EditValue <> "" Then
                My.Computer.FileSystem.DeleteFile(Application.StartupPath & "\DSGNS\" & sDataTable & "\" & BarViews.EditValue)
                If sDataDetail <> "" Then My.Computer.FileSystem.DeleteFile(Application.StartupPath & "\DSGNS\" & sDataDetail & "\" & BarViews.EditValue)
                CType(BarViews.Edit, RepositoryItemComboBox).Items.Remove(BarViews.EditValue)
                BarViews.EditValue = "" : CurrentView = "" : popSaveView.Enabled = False
            End If
        End If

    End Sub
    'Αποθήκευση ως όψης
    Private Sub RepositoryPopSaveAsView_KeyDown(sender As Object, e As KeyEventArgs) Handles RepositoryPopSaveAsView.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                If GridView1.OptionsLayout.LayoutVersion <> "" Then
                    Dim sVer As Integer = GridView1.OptionsLayout.LayoutVersion.Replace("v", "")
                    GridView1.OptionsLayout.LayoutVersion = "v" & sVer + 1
                Else
                    GridView1.OptionsLayout.LayoutVersion = "v1"
                End If
                GridView1.SaveLayoutToXml(Application.StartupPath & "\DSGNS\" & sDataTable & "\" & sender.EditValue & "_" & UserProps.Code & ".xml", OptionsLayoutBase.FullLayout)
                If sDataDetail <> "" Then GridView2.SaveLayoutToXml(Application.StartupPath & "\DSGNS\" & sDataDetail & "\" & sender.EditValue & "_" & UserProps.Code & ".xml", OptionsLayoutBase.FullLayout)
                'grdMain.DefaultView.SaveLayoutToXml(Application.StartupPath & "\DSGNS\" & sDataTable & "\" & sender.EditValue & "_" & UserProps.Code & ".xml")
                CType(BarViews.Edit, RepositoryItemComboBox).Items.Add(sender.EditValue & "_" & UserProps.Code & ".xml")

                BarViews.EditValue = sender.EditValue & "_" & UserProps.Code & ".xml"
                CurrentView = BarViews.EditValue
            End If
        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), "Dreamy Kitchen CRM", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    'Αποθήκευση όψης
    Private Sub popSaveView_ItemClick(sender As Object, e As ItemClickEventArgs) Handles popSaveView.ItemClick
        If BarViews.EditValue <> "" Then
            'grdMain.DefaultView.SaveLayoutToXml(Application.StartupPath & "\DSGNS\" & sDataTable & "\" & BarViews.EditValue)
            My.Computer.FileSystem.DeleteFile(Application.StartupPath & "\DSGNS\" & sDataTable & "\" & BarViews.EditValue)
            If GridView1.OptionsLayout.LayoutVersion <> "" Then
                Dim sVer As Integer = GridView1.OptionsLayout.LayoutVersion.Replace("v", "")
                GridView1.OptionsLayout.LayoutVersion = "v" & sVer + 1
            Else
                GridView1.OptionsLayout.LayoutVersion = "v1"
            End If
            GridView1.SaveLayoutToXml(Application.StartupPath & "\DSGNS\" & sDataTable & "\" & BarViews.EditValue, OptionsLayoutBase.FullLayout)
            If sDataDetail <> "" Then
                My.Computer.FileSystem.DeleteFile(Application.StartupPath & "\DSGNS\" & sDataDetail & "\" & BarViews.EditValue)
                GridView2.SaveLayoutToXml(Application.StartupPath & "\DSGNS\" & sDataDetail & "\" & BarViews.EditValue, OptionsLayoutBase.FullLayout)
            End If
            'GridView1.SaveLayoutToXml(Application.StartupPath & "\DSGNS\" & sDataTable & "\" & BarViews.EditValue)
            XtraMessageBox.Show("Η όψη αποθηκέυτηκε με επιτυχία", "Dreamy Kitchen CRM", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
    'Επαναφορά Default όψης
    Private Sub popRestoreView_ItemClick(sender As Object, e As ItemClickEventArgs) Handles popRestoreView.ItemClick
        grdMain.DefaultView.RestoreLayoutFromXml(Application.StartupPath & "\DSGNS\DEF\" & sDataTable & "_def.xml", OptionsLayoutBase.FullLayout)
        BarViews.EditValue = "" : popSaveAsView.EditValue = "" : popSaveView.Enabled = False : popDeleteView.Enabled = False
        CurrentView = ""
    End Sub

    Private Sub RepositoryBarViews_SelectedIndexChanged(sender As Object, e As EventArgs) Handles RepositoryBarViews.SelectedIndexChanged
        My.Settings.CurrentView = sender.EditValue
        My.Settings.Save()
    End Sub

    Private Sub RepositoryBarRecords_SelectedIndexChanged(sender As Object, e As EventArgs) Handles RepositoryBarRecords.SelectedIndexChanged
        My.Settings.Records = BarRecords.EditValue
        My.Settings.Save()
        LoadRecords()
    End Sub

    'Προσθήκη επιλογών στο Standar Header Menu
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

            End If
        Else
            PopupMenuRows.ShowPopup(Control.MousePosition)
        End If
    End Sub
    'Προσθήκη επιλογών στο Standar Detail Menu
    Private Sub GridView2_PopupMenuShowing(sender As Object, e As PopupMenuShowingEventArgs) Handles GridView2.PopupMenuShowing
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
                menu.Items.Add(New DXEditMenuItem("Μετονομασία Στήλης", popRenameColumn, AddressOf OnDetailEditValueChanged, Nothing, Nothing, 100, 0))
                item = menu.Items.Item("Μετονομασία Στήλης")
                item.EditValue = menu.Column.GetTextCaption
                item.Tag = menu.Column.AbsoluteIndex
                '2nd Custom Menu Item
                menu.Items.Add(CreateCheckItemDetail("Κλείδωμα Στήλης", menu.Column, Nothing))

                '3rd Custom Menu Item
                Dim popColorsColumn As New RepositoryItemColorEdit
                popColorsColumn.Name = "ColorsColumn"
                menu.Items.Add(New DXEditMenuItem("Χρώμα Στήλης", popColorsColumn, AddressOf OnDetailColumnsColorChanged, Nothing, Nothing, 100, 0))
                itemColor = menu.Items.Item("Χρώμα Στήλης")
                itemColor.EditValue = menu.Column.AppearanceCell.BackColor
                itemColor.Tag = menu.Column.AbsoluteIndex
            End If
        Else
            PopupMenuRowsDetail.ShowPopup(Control.MousePosition)
        End If
    End Sub
    'Αλλαγή Χρώματος Στήλης Master
    Private Sub OnColumnsColorChanged(ByVal sender As System.Object, ByVal e As EventArgs)
        Dim item As DXEditMenuItem = TryCast(sender, DXEditMenuItem)
        item = sender
        If item.Tag Is Nothing Then Exit Sub
        GridView1.Columns(item.Tag).AppearanceCell.BackColor = item.EditValue
    End Sub
    'Αλλαγή Χρώματος Στήλης Detail
    Private Sub OnDetailColumnsColorChanged(ByVal sender As System.Object, ByVal e As EventArgs)
        Dim item As DXEditMenuItem = TryCast(sender, DXEditMenuItem)
        item = sender
        If item.Tag Is Nothing Then Exit Sub
        GridView2.Columns(item.Tag).AppearanceCell.BackColor = item.EditValue
    End Sub
    'Μετονομασία Στήλης Master
    Private Sub OnEditValueChanged(ByVal sender As System.Object, ByVal e As EventArgs)
        Dim item As New DXEditMenuItem()
        item = sender
        If item.Tag Is Nothing Then Exit Sub
        GridView1.Columns(item.Tag).Caption = item.EditValue
        'MessageBox.Show(item.EditValue.ToString())
    End Sub
    'Μετονομασία Στήλης Detail
    Private Sub OnDetailEditValueChanged(ByVal sender As System.Object, ByVal e As EventArgs)
        Dim item As New DXEditMenuItem()
        item = sender
        If item.Tag Is Nothing Then Exit Sub
        GridView2.Columns(item.Tag).Caption = item.EditValue
        'MessageBox.Show(item.EditValue.ToString())
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
    'Κλείδωμα Στήλης Detail
    Private Sub OnCanMoveItemClickDetail(ByVal sender As Object, ByVal e As EventArgs)
        Dim item As DXMenuCheckItem = TryCast(sender, DXMenuCheckItem)
        Dim info As MenuColumnInfo = TryCast(item.Tag, MenuColumnInfo)
        If info Is Nothing Then
            Return
        End If
        info.Column.OptionsColumn.AllowMove = Not item.Checked
    End Sub
    Private Function CreateCheckItem(ByVal caption As String, ByVal column As GridColumn, ByVal image As Image) As DXMenuCheckItem
        Dim item As New DXMenuCheckItem(caption, (Not column.OptionsColumn.AllowMove), image, New EventHandler(AddressOf OnCanMoveItemClick))
        item.Tag = New MenuColumnInfo(column)
        Return item
    End Function
    Private Function CreateCheckItemDetail(ByVal caption As String, ByVal column As GridColumn, ByVal image As Image) As DXMenuCheckItem
        Dim item As New DXMenuCheckItem(caption, (Not column.OptionsColumn.AllowMove), image, New EventHandler(AddressOf OnCanMoveItemClickDetail))
        item.Tag = New MenuColumnInfo(column)
        Return item
    End Function
    'Print Preview
    Private Sub BarPrintPreview_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BarPrintPreview.ItemClick
        GridView1.GridControl.ShowRibbonPrintPreview()
    End Sub
    'XLSX Export
    Private Sub BarExportXLSX_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BarExportXLSX.ItemClick
        Dim options = New XlsxExportOptionsEx()
        options.UnboundExpressionExportMode = UnboundExpressionExportMode.AsFormula
        XtraSaveFileDialog1.Filter = "XLSX Files (*.xlsx*)|*.xlsx"
        If XtraSaveFileDialog1.ShowDialog() = DialogResult.OK Then
            GridView1.GridControl.ExportToXlsx(XtraSaveFileDialog1.FileName, options)
            Process.Start(XtraSaveFileDialog1.FileName)
        End If
    End Sub
    'PDF Export
    Private Sub BarPDFExport_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BarPDFExport.ItemClick
        XtraSaveFileDialog1.Filter = "PDF Files (*.pdf*)|*.pdf"
        If XtraSaveFileDialog1.ShowDialog() = DialogResult.OK Then
            GridView1.GridControl.ExportToPdf(XtraSaveFileDialog1.FileName)
            Process.Start(XtraSaveFileDialog1.FileName)
        End If
    End Sub

    Friend Class MenuColumnInfo
        Public Sub New(ByVal column As GridColumn)
            Me.Column = column
        End Sub
        Public Column As GridColumn
    End Class
    ' Πάιρνω από την βάση την τρέχουσα όψη του χρήστη
    Private Sub GetCurrentView(ByVal GetVal As Boolean)
        Dim Cmd As SqlCommand, sdr As SqlDataReader
        Try
            If GetVal Then
                Cmd = New SqlCommand("SELECT currentview FROM USR_V WHERE USRID = '" & UserProps.ID.ToString & "' and  DATATABLE = '" & sDataTable & "'", CNDB)
                sdr = Cmd.ExecuteReader()
                If (sdr.Read() = True) Then
                    If sdr.IsDBNull(sdr.GetOrdinal("currentview")) = False Then CurrentView = sdr.GetString(sdr.GetOrdinal("currentview"))
                    'Έλεγχος αν το τελευταίο σχέδιο που έχει αποθηκευτεί στην βάση υπάρχει στον δίσκο
                    If My.Computer.FileSystem.FileExists(Application.StartupPath & "\DSGNS\" & sDataTable & "\" & CurrentView) = False Then CurrentView = ""
                Else
                    CurrentView = ""
                End If
                sdr.Close()

            Else
                If CurrentView <> "" Then
                    Cmd = CNDB.CreateCommand
                    Cmd.CommandType = CommandType.StoredProcedure
                    Cmd.Parameters.Add(New SqlParameter("@sDataTable", sDataTable))
                    Cmd.Parameters.Add(New SqlParameter("@ID", UserProps.ID))
                    Cmd.Parameters.Add(New SqlParameter("@CurrentView", CurrentView))
                    Cmd.CommandText = "SetUserView"
                    Cmd.ExecuteNonQuery()
                End If
            End If
        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), "Dreamy Kitchen CRM", MessageBoxButtons.OK, MessageBoxIcon.Error)
            If GetVal Then sdr.Close()
        End Try

    End Sub
    Private Sub GridView1_DoubleClick(sender As Object, e As EventArgs) Handles GridView1.DoubleClick
        EditRecord()
    End Sub
    'Νέα Εγγραφή
    Private Sub BarNewRec_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BarNewRec.ItemClick
        NewRecord()
    End Sub
    'Επεξεργασία Εγγραφής
    Private Sub BarEdit_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BarEdit.ItemClick
        EditRecord()
    End Sub
    'Διαγραφή Εγγραφής
    Private Sub BarDelete_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BarDelete.ItemClick
        DeleteRecord()
    End Sub
    'Ανανέωση εγγραφών
    Private Sub BarRefresh_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BarRefresh.ItemClick
        LoadRecords()
    End Sub
    'Επεξεργασία Εγγραφής
    Private Sub EditRecord()
        Dim form As frmUsers = New frmUsers()
        Dim form1 As frmPermissions = New frmPermissions()
        Dim form2 As frmMailSettings = New frmMailSettings()
        Dim form3 As frmGen = New frmGen()
        Dim form4 As frmGen = New frmGen()
        Dim form5 As frmGen = New frmGen()
        Dim form6 As frmGen = New frmGen()
        Dim form7 As frmGen = New frmGen()
        Dim form8 As frmGen = New frmGen()
        Dim form9 As frmGen = New frmGen()
        Dim form10 As frmCustomers = New frmCustomers()
        Dim form11 As frmGen = New frmGen()
        Dim form12 As frmCusMov = New frmCusMov()
        Dim form13 As frmGen = New frmGen()
        Dim form14 As frmDoorType = New frmDoorType()
        Dim form15 As frmGen = New frmGen()
        Dim form16 As frmErmaria = New frmErmaria()
        Dim form17 As frmBench = New frmBench()
        Dim form18 As frmMech = New frmMech()
        Dim form19 As frmGen = New frmGen()
        Dim form20 As frmGen = New frmGen()
        Dim form21 As frmGen = New frmGen()
        Dim form22 As frmGen = New frmGen()
        Dim fTechicalSupport As frmTecnicalSupport = New frmTecnicalSupport()
        Dim frmColors As frmColors = New frmColors
        Dim frmoffer As frmOffer = New frmOffer
        Dim frmEpendisis As frmEpendisis = New frmEpendisis
        Dim frmServices As frmServices = New frmServices()
        Dim frmCalculations As frmCalculations = New frmCalculations()
        Dim frmCatSubErm As New frmCatSubErm
        Dim frmInstallations As New frmInstallations
        Dim frmTransactions As New frmTransactions
        Select Case sDataTable
            Case "vw_TRANSH"
                frmTransactions.Text = "Χρεωπιστώσεις"
                frmTransactions.ID = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "ID").ToString
                frmTransactions.MdiParent = frmMain
                frmTransactions.Mode = FormMode.EditRecord
                frmTransactions.Scroller = GridView1
                frmTransactions.FormScroller = Me
                frmTransactions.CalledFromControl = False
                frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(frmTransactions), New Point(CInt(Me.Parent.ClientRectangle.Width / 2 - Me.Width / 2), CInt(Me.Parent.ClientRectangle.Height / 2 - Me.Height / 2)))
                frmTransactions.Show()

            Case "vw_BANKS"
                form22.Text = "Τράπεζες"
                form22.ID = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "ID").ToString
                form22.MdiParent = frmMain
                form22.Mode = FormMode.EditRecord
                form22.Scroller = GridView1
                form22.FormScroller = Me
                form22.DataTable = "BANKS"
                form22.L1.Text = "Κωδικός"
                form22.L2.Text = "Τράπεζα"
                form22.FormScroller = Me
                form22.CalledFromControl = False
                form22.L3.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
                form22.L4.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
                form22.L5.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
                form22.L6.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
                form22.L8.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
                frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(form22), New Point(CInt(Me.Parent.ClientRectangle.Width / 2 - Me.Width / 2), CInt(Me.Parent.ClientRectangle.Height / 2 - Me.Height / 2)))
                form22.Show()
            Case "vw_INST"
                frmInstallations.Text = "Τοποθετήσεις"
                frmInstallations.ID = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "ID").ToString
                frmInstallations.MdiParent = frmMain
                frmInstallations.Mode = FormMode.EditRecord
                frmInstallations.Scroller = GridView1
                frmInstallations.FormScroller = Me
                frmInstallations.CalledFromControl = False
                frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(frmInstallations), New Point(CInt(Me.Parent.ClientRectangle.Width / 2 - Me.Width / 2), CInt(Me.Parent.ClientRectangle.Height / 2 - Me.Height / 2)))
                frmInstallations.Show()
            Case "vw_SER"
                frmServices.Text = "Συνεργεία"
                frmServices.ID = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "ID").ToString
                frmServices.MdiParent = frmMain
                frmServices.Mode = FormMode.EditRecord
                frmServices.Scroller = GridView1
                frmServices.FormScroller = Me
                frmServices.CalledFromControl = False
                frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(frmServices), New Point(CInt(Me.Parent.ClientRectangle.Width / 2 - Me.Width / 2), CInt(Me.Parent.ClientRectangle.Height / 2 - Me.Height / 2)))
                frmServices.Show()
            Case "vw_CAT_SUB_ERM"
                frmCatSubErm.Text = "Υποκατηγορίες Ερμαρίων"
                frmCatSubErm.MdiParent = frmMain
                frmCatSubErm.ID = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "ID").ToString
                frmCatSubErm.Mode = FormMode.EditRecord
                frmCatSubErm.Scroller = GridView1
                frmCatSubErm.FormScroller = Me
                frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(frmCatSubErm), New Point(CInt(Me.Parent.ClientRectangle.Width / 2 - Me.Width / 2), CInt(Me.Parent.ClientRectangle.Height / 2 - Me.Height / 2)))
                frmCatSubErm.Show()
            Case "vw_CALC"
                frmCalculations.Text = "Υπολογισμοί"
                frmCalculations.MdiParent = frmMain
                frmCalculations.ID = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "ID").ToString
                frmCalculations.Mode = FormMode.EditRecord
                frmCalculations.Scroller = GridView1
                frmCalculations.FormScroller = Me
                frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(frmCalculations), New Point(CInt(Me.Parent.ClientRectangle.Width / 2 - Me.Width / 2), CInt(Me.Parent.ClientRectangle.Height / 2 - Me.Height / 2)))
                frmCalculations.Show()
            Case "vw_DIM"
                form21.Text = "Διαστάσεις"
                form21.ID = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "ID").ToString
                form21.MdiParent = frmMain
                form21.Mode = FormMode.EditRecord
                form21.Scroller = GridView1
                form21.FormScroller = Me
                form21.DataTable = "DIM"
                form21.L1.Text = "Κωδικός"
                form21.L2.Text = "Διάσταση"
                form21.FormScroller = Me
                form21.CalledFromControl = False
                form21.L3.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
                form21.L4.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
                form21.L5.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
                form21.L6.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
                form21.L8.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
                frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(form21), New Point(CInt(Me.Parent.ClientRectangle.Width / 2 - Me.Width / 2), CInt(Me.Parent.ClientRectangle.Height / 2 - Me.Height / 2)))
                form21.Show()
            Case "vw_SIDES"
                frmEpendisis.Text = "Επενδύσης - Καταφραγές"
                frmEpendisis.MdiParent = frmMain
                frmEpendisis.ID = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "ID").ToString
                frmEpendisis.Mode = FormMode.EditRecord
                frmEpendisis.Scroller = GridView1
                frmEpendisis.FormScroller = Me
                frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(frmEpendisis), New Point(CInt(Me.Parent.ClientRectangle.Width / 2 - Me.Width / 2), CInt(Me.Parent.ClientRectangle.Height / 2 - Me.Height / 2)))
                frmEpendisis.Show()
            Case "vw_OFF"
                frmoffer.Text = "Προσφορές"
                frmoffer.MdiParent = frmMain
                frmoffer.ID = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "ID").ToString
                frmoffer.Mode = FormMode.EditRecord
                frmoffer.Scroller = GridView1
                frmoffer.FormScroller = Me
                frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(frmoffer), New Point(CInt(Me.Parent.ClientRectangle.Width / 2 - Me.Width / 2), CInt(Me.Parent.ClientRectangle.Height / 2 - Me.Height / 2)))
                frmoffer.Show()
            Case "vw_COLORS"
                frmColors.Text = "Χρώματα"
                frmColors.MdiParent = frmMain
                frmColors.ID = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "ID").ToString
                frmColors.Mode = FormMode.EditRecord
                frmColors.Scroller = GridView1
                frmColors.FormScroller = Me
                frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(frmColors), New Point(CInt(Me.Parent.ClientRectangle.Width / 2 - Me.Width / 2), CInt(Me.Parent.ClientRectangle.Height / 2 - Me.Height / 2)))
                frmColors.Show()
            Case "vw_TECH_SUP"
                fTechicalSupport.Text = "Διαχείριση Τεχνικής Υποστήριξης"
                fTechicalSupport.ID = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "ID").ToString
                fTechicalSupport.MdiParent = frmMain
                fTechicalSupport.Mode = FormMode.EditRecord
                fTechicalSupport.Scroller = GridView1
                fTechicalSupport.FormScroller = Me
                frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(fTechicalSupport), New Point(CInt(Me.Parent.ClientRectangle.Width / 2 - Me.Width / 2), CInt(Me.Parent.ClientRectangle.Height / 2 - Me.Height / 2)))
                fTechicalSupport.Show()
            Case "vw_RIGHTS"
                form1.Text = "Δικαιώματα"
                form1.ID = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "ID").ToString
                form1.MdiParent = frmMain
                form1.Mode = FormMode.EditRecord
                form1.Scroller = GridView1
                form1.FormScroller = Me
                frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(form1), New Point(CInt(Me.Parent.ClientRectangle.Width / 2 - Me.Width / 2), CInt(Me.Parent.ClientRectangle.Height / 2 - Me.Height / 2)))
                form1.Show()
            Case "vw_USR"
                form.Text = "Διαχείριση Χρηστών"
                form.ID = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "ID").ToString
                form.MdiParent = frmMain
                form.Mode = FormMode.EditRecord
                form.Scroller = GridView1
                form.FormScroller = Me
                frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(form), New Point(CInt(Me.Parent.ClientRectangle.Width / 2 - Me.Width / 2), CInt(Me.Parent.ClientRectangle.Height / 2 - Me.Height / 2)))
                form.Show()
            Case "vw_MAILS"
                form2.Text = "Email Settings"
                form2.ID = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "ID").ToString
                form2.MdiParent = frmMain
                form2.Mode = FormMode.EditRecord
                form2.Scroller = GridView1
                form2.FormScroller = Me
                frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(form2), New Point(CInt(Me.Parent.ClientRectangle.Width / 2 - Me.Width / 2), CInt(Me.Parent.ClientRectangle.Height / 2 - Me.Height / 2)))
                form2.Show()
            Case "vw_STATUS"
                form3.Text = "Status"
                form3.ID = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "ID").ToString
                form3.MdiParent = frmMain
                form3.Mode = FormMode.EditRecord
                form3.Scroller = GridView1
                form3.FormScroller = Me
                form3.DataTable = "STATUS"
                form3.L1.Text = "Κωδικός"
                form3.L2.Text = "Status"
                form3.L6.Text = "Χρώμα"
                form3.chk1.Text = "Επιτρέπονται ειδοποιήσεις"
                form3.FormScroller = Me
                form3.CalledFromControl = False
                form3.L3.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
                form3.L4.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
                form3.L6.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
                form3.L8.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
                frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(form3), New Point(CInt(Me.Parent.ClientRectangle.Width / 2 - Me.Width / 2), CInt(Me.Parent.ClientRectangle.Height / 2 - Me.Height / 2)))
                form3.Show()
            Case "vw_SOURCE"
                form4.Text = "Πηγές"
                form4.MdiParent = frmMain
                form4.ID = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "ID").ToString
                form4.Mode = FormMode.EditRecord
                form4.Scroller = GridView1
                form4.FormScroller = Me
                form4.DataTable = "SRC"
                form4.L1.Text = "Κωδικός"
                form4.L2.Text = "Πηγή"
                form4.FormScroller = Me
                form4.CalledFromControl = False
                form4.L3.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
                form4.L4.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
                form4.L5.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
                form4.L6.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
                form4.L8.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
                frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(form4), New Point(CInt(Me.Parent.ClientRectangle.Width / 2 - Me.Width / 2), CInt(Me.Parent.ClientRectangle.Height / 2 - Me.Height / 2)))
                form4.Show()
            Case "vw_CCT"
                form10.Text = "Πελάτες"
                form10.ID = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "ID").ToString
                form10.MdiParent = frmMain
                form10.Mode = FormMode.EditRecord
                form10.Scroller = GridView1
                form10.FormScroller = Me
                frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(form10), New Point(CInt(Me.Parent.ClientRectangle.Width / 2 - Me.Width / 2), CInt(Me.Parent.ClientRectangle.Height / 2 - Me.Height / 2)))
                form10.Show()
            Case "vw_COU"
                form5.Text = "Νομοί"
                form5.ID = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "ID").ToString
                form5.MdiParent = frmMain
                form5.Mode = FormMode.EditRecord
                form5.Scroller = GridView1
                form5.FormScroller = Me
                form5.DataTable = "COU"
                form5.L1.Text = "Κωδικός"
                form5.L2.Text = "Νομός"
                form5.FormScroller = Me
                form5.CalledFromControl = False
                form5.L3.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
                form5.L4.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
                form5.L5.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
                form5.L6.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
                form5.L8.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
                frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(form5), New Point(CInt(Me.Parent.ClientRectangle.Width / 2 - Me.Width / 2), CInt(Me.Parent.ClientRectangle.Height / 2 - Me.Height / 2)))
                form5.Show()
            Case "vw_AREAS"
                form6.Text = "Περιοχές"
                form6.ID = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "ID").ToString
                form6.MdiParent = frmMain
                form6.Mode = FormMode.EditRecord
                form6.Scroller = GridView1
                form6.DataTable = "AREAS"
                form6.L1.Text = "Κωδικός"
                form6.L2.Text = "Περιοχή"
                form6.L3.Text = "Νομός"
                form6.FormScroller = Me
                form6.CalledFromControl = False
                form6.L4.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
                form6.L5.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
                form6.L6.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
                form6.L8.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
                frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(form6), New Point(CInt(Me.Parent.ClientRectangle.Width / 2 - Me.Width / 2), CInt(Me.Parent.ClientRectangle.Height / 2 - Me.Height / 2)))
                form6.Show()
            Case "vw_ADR"
                form7.Text = "Διευθύνσεις"
                form7.ID = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "ID").ToString
                form7.MdiParent = frmMain
                form7.Mode = FormMode.EditRecord
                form7.Scroller = GridView1
                form7.DataTable = "ADR"
                form7.L1.Text = "Κωδικός"
                form7.L2.Text = "Διεύθυνση"
                form7.L3.Text = "Νομός"
                form7.L4.Text = "Περιοχές"
                form7.FormScroller = Me
                form7.CalledFromControl = False
                form7.L5.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
                form7.L6.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
                form7.L7.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
                frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(form7), New Point(CInt(Me.Parent.ClientRectangle.Width / 2 - Me.Width / 2), CInt(Me.Parent.ClientRectangle.Height / 2 - Me.Height / 2)))
                form7.Show()
            Case "vw_DOY"
                form8.Text = "ΔΟΥ"
                form8.MdiParent = frmMain
                form8.ID = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "ID").ToString
                form8.Mode = FormMode.EditRecord
                form8.Scroller = GridView1
                form8.DataTable = "DOY"
                form8.L1.Text = "Κωδικός"
                form8.L2.Text = "ΔΟΥ"
                form8.FormScroller = Me
                form8.CalledFromControl = False
                form8.L3.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
                form8.L4.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
                form8.L5.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
                form8.L6.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
                form8.L8.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
                frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(form8), New Point(CInt(Me.Parent.ClientRectangle.Width / 2 - Me.Width / 2), CInt(Me.Parent.ClientRectangle.Height / 2 - Me.Height / 2)))
                form8.Show()
            Case "vw_PRF"
                form9.Text = "Επαγγέλματα"
                form9.MdiParent = frmMain
                form9.ID = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "ID").ToString
                form9.Mode = FormMode.EditRecord
                form9.Scroller = GridView1
                form9.DataTable = "PRF"
                form9.L1.Text = "Κωδικός"
                form9.L2.Text = "Επάγγελμα"
                form9.FormScroller = Me
                form9.CalledFromControl = False
                form9.L3.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
                form9.L4.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
                form9.L5.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
                form9.L6.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
                form9.L8.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
                frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(form9), New Point(CInt(Me.Parent.ClientRectangle.Width / 2 - Me.Width / 2), CInt(Me.Parent.ClientRectangle.Height / 2 - Me.Height / 2)))
                form9.Show()
            Case "vw_SALERS"
                form11.Text = "Πωλητές"
                form11.ID = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "ID").ToString
                form11.MdiParent = frmMain
                form11.Mode = FormMode.EditRecord
                form11.Scroller = GridView1
                form11.DataTable = "SALERS"
                form11.L1.Text = "Κωδικός"
                form11.L2.Text = "Πωλητής"
                form11.L6.Text = "Χρώμα"
                form11.L8.Text = "Αρ. Πρωτοκόλου"
                form11.FormScroller = Me
                form11.CalledFromControl = False
                form11.L3.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
                form11.L4.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
                form11.L5.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
                form11.L8.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
                frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(form11), New Point(CInt(Me.Parent.ClientRectangle.Width / 2 - Me.Width / 2), CInt(Me.Parent.ClientRectangle.Height / 2 - Me.Height / 2)))
                form11.Show()
            Case "vw_CCT_M"
                form12.Text = "Κινήσεις Πελατών"
                form12.ID = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "ID").ToString
                form12.MdiParent = frmMain
                form12.Mode = FormMode.EditRecord
                form12.Scroller = GridView1
                form12.FormScroller = Me
                frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(form12), New Point(CInt(Me.Parent.ClientRectangle.Width / 2 - Me.Width / 2), CInt(Me.Parent.ClientRectangle.Height / 2 - Me.Height / 2)))
                form12.Show()
            Case "vw_NOTES_L"
                form13.Text = "Εττικέτες"
                form13.ID = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "ID").ToString
                form13.MdiParent = frmMain
                form13.Mode = FormMode.EditRecord
                form13.Scroller = GridView1
                form13.DataTable = "NOTES_L"
                form13.L1.Text = "Κωδικός"
                form13.L2.Text = "Εττικέτα"
                form13.FormScroller = Me
                form13.CalledFromControl = False
                form13.L3.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
                form13.L4.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
                form13.L5.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
                form13.L6.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
                form13.L8.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
                frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(form13), New Point(CInt(Me.Parent.ClientRectangle.Width / 2 - Me.Width / 2), CInt(Me.Parent.ClientRectangle.Height / 2 - Me.Height / 2)))
                form13.Show()
            Case "vw_DOOR_TYPE"
                form14.Text = "Κατηγορία Πόρτας"
                form14.ID = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "ID").ToString
                form14.MdiParent = frmMain
                form14.Mode = FormMode.EditRecord
                form14.Scroller = GridView1
                form14.FormScroller = Me
                frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(form14), New Point(CInt(Me.Parent.ClientRectangle.Width / 2 - Me.Width / 2), CInt(Me.Parent.ClientRectangle.Height / 2 - Me.Height / 2)))
                form14.Show()
            Case "vw_CAT_ERM"
                form15.Text = "Κατηγορίες Ερμαριών"
                form15.MdiParent = frmMain
                form15.ID = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "ID").ToString
                form15.Mode = FormMode.EditRecord
                form15.Scroller = GridView1
                form15.DataTable = "CAT_ERM"
                form15.L1.Text = "Κωδικός"
                form15.L2.Text = "Κατηγορίες Ερμαρίων"
                form15.FormScroller = Me
                form15.CalledFromControl = False
                form15.L3.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
                form15.L4.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
                form15.L5.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
                form15.L6.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
                form15.L8.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
                frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(form15), New Point(CInt(Me.Parent.ClientRectangle.Width / 2 - Me.Width / 2), CInt(Me.Parent.ClientRectangle.Height / 2 - Me.Height / 2)))
                form15.Show()
            Case "vw_ERM"
                form16.Text = "Ερμάρια"
                form16.ID = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "ID").ToString
                form16.MdiParent = frmMain
                form16.Mode = FormMode.EditRecord
                form16.Scroller = GridView1
                form16.FormScroller = Me
                frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(form16), New Point(CInt(Me.Parent.ClientRectangle.Width / 2 - Me.Width / 2), CInt(Me.Parent.ClientRectangle.Height / 2 - Me.Height / 2)))
                form16.Show()
            Case "vw_BENCH"
                form17.Text = "Πάγκοι"
                form17.ID = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "ID").ToString
                form17.MdiParent = frmMain
                form17.Mode = FormMode.EditRecord
                form17.Scroller = GridView1
                form17.FormScroller = Me
                frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(form17), New Point(CInt(Me.Parent.ClientRectangle.Width / 2 - Me.Width / 2), CInt(Me.Parent.ClientRectangle.Height / 2 - Me.Height / 2)))
                form17.Show()
            Case "vw_MECH"
                form18.Text = "Μηχανισμοί"
                form18.ID = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "ID").ToString
                form18.MdiParent = frmMain
                form18.Mode = FormMode.EditRecord
                form18.Scroller = GridView1
                form18.FormScroller = Me
                frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(form18), New Point(CInt(Me.Parent.ClientRectangle.Width / 2 - Me.Width / 2), CInt(Me.Parent.ClientRectangle.Height / 2 - Me.Height / 2)))
                form18.Show()
            Case "vw_TECH_CAT"
                form19.Text = "Κατηγορίες Τεχνικής Υποστήριξης"
                form19.MdiParent = frmMain
                form19.ID = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "ID").ToString
                form19.Mode = FormMode.EditRecord
                form19.Scroller = GridView1
                form19.DataTable = "TECH_CAT"
                form19.L1.Text = "Κωδικός"
                form19.L2.Text = "Κατηγορία"
                form19.FormScroller = Me
                form19.CalledFromControl = False
                form19.L3.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
                form19.L4.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
                form19.L5.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
                form19.L6.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
                form19.L8.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
                frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(form19), New Point(CInt(Me.Parent.ClientRectangle.Width / 2 - Me.Width / 2), CInt(Me.Parent.ClientRectangle.Height / 2 - Me.Height / 2)))
                form19.Show()
            Case "vw_COLORS_CAT"
                form20.Text = "Κατηγορίες Χρωμάτων"
                form20.MdiParent = frmMain
                form20.ID = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "ID").ToString
                form20.Mode = FormMode.EditRecord
                form20.Scroller = GridView1
                form20.DataTable = "COLORS_CAT"
                form20.L1.Text = "Κωδικός"
                form20.L2.Text = "Κατηγορίες Χρωμάτων"
                form20.FormScroller = Me
                form20.CalledFromControl = False
                form20.L3.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
                form20.L4.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
                form20.L5.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
                form20.L6.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
                form20.L8.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
                frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(form20), New Point(CInt(Me.Parent.ClientRectangle.Width / 2 - Me.Width / 2), CInt(Me.Parent.ClientRectangle.Height / 2 - Me.Height / 2)))
                form20.Show()

        End Select
    End Sub
    'Νέα Εγγραφή
    Private Sub NewRecord()
        Dim form As frmUsers = New frmUsers()
        Dim form1 As frmPermissions = New frmPermissions()
        Dim form2 As frmMailSettings = New frmMailSettings()
        Dim form3 As frmGen = New frmGen()
        Dim form4 As frmGen = New frmGen()
        Dim form5 As frmGen = New frmGen()
        Dim form6 As frmGen = New frmGen()
        Dim form7 As frmGen = New frmGen()
        Dim form8 As frmGen = New frmGen()
        Dim form9 As frmGen = New frmGen()
        Dim form10 As frmCustomers = New frmCustomers()
        Dim form11 As frmGen = New frmGen()
        Dim form12 As frmCusMov = New frmCusMov()
        Dim form13 As frmGen = New frmGen()
        Dim form14 As frmDoorType = New frmDoorType
        Dim form15 As frmGen = New frmGen()
        Dim form16 As frmErmaria = New frmErmaria
        Dim form17 As frmBench = New frmBench
        Dim form18 As frmMech = New frmMech
        Dim form19 As frmGen = New frmGen()
        Dim form20 As frmGen = New frmGen()
        Dim fTechicalSupport As frmTecnicalSupport = New frmTecnicalSupport()
        Dim frmColors As frmColors = New frmColors
        Dim form21 As frmGen = New frmGen()
        Dim form22 As frmGen = New frmGen()
        Dim frmOffer As frmOffer = New frmOffer
        Dim frmEpendisis As frmEpendisis = New frmEpendisis
        Dim frmServices As frmServices = New frmServices()
        Dim frmCalculations As frmCalculations = New frmCalculations()
        Dim frmCatSubErm As New frmCatSubErm
        Dim frmInstallations As New frmInstallations
        Dim frmTransactions As New frmTransactions
        Select Case sDataTable
            Case "vw_TRANSH"
                frmTransactions.Text = "Χρεωπιστώσεις"
                frmTransactions.MdiParent = frmMain
                frmTransactions.Mode = FormMode.NewRecord
                frmTransactions.Scroller = GridView1
                frmTransactions.FormScroller = Me
                frmTransactions.CalledFromControl = False
                frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(frmTransactions), New Point(CInt(Me.Parent.ClientRectangle.Width / 2 - Me.Width / 2), CInt(Me.Parent.ClientRectangle.Height / 2 - Me.Height / 2)))
                frmTransactions.Show()
            Case "vw_BANKS"
                form22.Text = "Τράπεζες"
                form22.MdiParent = frmMain
                form22.Mode = FormMode.NewRecord
                form22.Scroller = GridView1
                form22.FormScroller = Me
                form22.DataTable = "BANKS"
                form22.L1.Text = "Κωδικός"
                form22.L2.Text = "Τράπεζα"
                form22.FormScroller = Me
                form22.CalledFromControl = False
                form22.L3.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
                form22.L4.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
                form22.L5.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
                form22.L6.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
                form22.L8.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
                frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(form22), New Point(CInt(Me.Parent.ClientRectangle.Width / 2 - Me.Width / 2), CInt(Me.Parent.ClientRectangle.Height / 2 - Me.Height / 2)))
                form22.Show()
            Case "vw_INST"
                frmInstallations.Text = "Τοποθετήσεις"
                frmInstallations.MdiParent = frmMain
                frmInstallations.Mode = FormMode.NewRecord
                frmInstallations.Scroller = GridView1
                frmInstallations.FormScroller = Me
                frmInstallations.CalledFromControl = False
                frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(frmInstallations), New Point(CInt(Me.Parent.ClientRectangle.Width / 2 - Me.Width / 2), CInt(Me.Parent.ClientRectangle.Height / 2 - Me.Height / 2)))
                frmInstallations.Show()
            Case "vw_SER"
                frmServices.Text = "Συνεργεία"
                frmServices.MdiParent = frmMain
                frmServices.Mode = FormMode.NewRecord
                frmServices.Scroller = GridView1
                frmServices.FormScroller = Me
                frmServices.CalledFromControl = False
                frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(frmServices), New Point(CInt(Me.Parent.ClientRectangle.Width / 2 - Me.Width / 2), CInt(Me.Parent.ClientRectangle.Height / 2 - Me.Height / 2)))
                frmServices.Show()
            Case "vw_CAT_SUB_ERM"
                frmCatSubErm.Text = "Υποκατηγορίες Ερμαρίων"
                frmCatSubErm.MdiParent = frmMain
                frmCatSubErm.Mode = FormMode.NewRecord
                frmCatSubErm.Scroller = GridView1
                frmCatSubErm.FormScroller = Me
                frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(frmCatSubErm), New Point(CInt(Me.Parent.ClientRectangle.Width / 2 - Me.Width / 2), CInt(Me.Parent.ClientRectangle.Height / 2 - Me.Height / 2)))
                frmCatSubErm.Show()
            Case "vw_CALC"
                frmCalculations.Text = "Υπολογισμοί"
                frmCalculations.MdiParent = frmMain
                frmCalculations.Mode = FormMode.NewRecord
                frmCalculations.Scroller = GridView1
                frmCalculations.FormScroller = Me
                frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(frmCalculations), New Point(CInt(Me.Parent.ClientRectangle.Width / 2 - Me.Width / 2), CInt(Me.Parent.ClientRectangle.Height / 2 - Me.Height / 2)))
                frmCalculations.Show()
            Case "vw_DIM"
                form21.Text = "Διαστάσεις"
                form21.MdiParent = frmMain
                form21.Mode = FormMode.NewRecord
                form21.Scroller = GridView1
                form21.FormScroller = Me
                form21.DataTable = "DIM"
                form21.L1.Text = "Κωδικός"
                form21.L2.Text = "Διάσταση"
                form21.FormScroller = Me
                form21.CalledFromControl = False
                form21.L3.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
                form21.L4.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
                form21.L5.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
                form21.L6.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
                form21.L8.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
                frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(form21), New Point(CInt(Me.Parent.ClientRectangle.Width / 2 - Me.Width / 2), CInt(Me.Parent.ClientRectangle.Height / 2 - Me.Height / 2)))
                form21.Show()
            Case "vw_SIDES"
                frmEpendisis.Text = "Επενδύσης - Καταφραγές"
                frmEpendisis.MdiParent = frmMain
                frmEpendisis.Mode = FormMode.NewRecord
                frmEpendisis.Scroller = GridView1
                frmEpendisis.FormScroller = Me
                frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(frmEpendisis), New Point(CInt(Me.Parent.ClientRectangle.Width / 2 - Me.Width / 2), CInt(Me.Parent.ClientRectangle.Height / 2 - Me.Height / 2)))
                frmEpendisis.Show()
            Case "vw_OFF"
                frmOffer.Text = "Προσφορές"
                frmOffer.MdiParent = frmMain
                frmOffer.Mode = FormMode.NewRecord
                frmOffer.Scroller = GridView1
                frmOffer.FormScroller = Me
                frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(frmOffer), New Point(CInt(Me.Parent.ClientRectangle.Width / 2 - Me.Width / 2), CInt(Me.Parent.ClientRectangle.Height / 2 - Me.Height / 2)))
                frmOffer.Show()
            Case "vw_COLORS"
                frmColors.Text = "Χρώματα"
                frmColors.MdiParent = frmMain
                frmColors.Mode = FormMode.NewRecord
                frmColors.Scroller = GridView1
                frmColors.FormScroller = Me
                frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(frmColors), New Point(CInt(Me.Parent.ClientRectangle.Width / 2 - Me.Width / 2), CInt(Me.Parent.ClientRectangle.Height / 2 - Me.Height / 2)))
                frmColors.Show()
            Case "vw_TECH_SUP"
                fTechicalSupport.Text = "Διαχείριση Τεχνικής Υποστήριξης"
                fTechicalSupport.MdiParent = frmMain
                fTechicalSupport.Mode = FormMode.NewRecord
                fTechicalSupport.Scroller = GridView1
                fTechicalSupport.FormScroller = Me
                frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(fTechicalSupport), New Point(CInt(Me.Parent.ClientRectangle.Width / 2 - Me.Width / 2), CInt(Me.Parent.ClientRectangle.Height / 2 - Me.Height / 2)))
                fTechicalSupport.Show()
            Case "vw_RIGHTS"
                form1.Text = "Δικαιώματα"
                form1.MdiParent = frmMain
                form1.Mode = FormMode.NewRecord
                form1.Scroller = GridView1
                form1.FormScroller = Me
                frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(form1), New Point(CInt(Me.Parent.ClientRectangle.Width / 2 - Me.Width / 2), CInt(Me.Parent.ClientRectangle.Height / 2 - Me.Height / 2)))
                form1.Show()
            Case "vw_USR"
                form.Text = "Διαχείριση Χρηστών"
                form.MdiParent = frmMain
                form.Mode = FormMode.NewRecord
                form.Scroller = GridView1
                form.FormScroller = Me
                frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(form), New Point(CInt(Me.Parent.ClientRectangle.Width / 2 - Me.Width / 2), CInt(Me.Parent.ClientRectangle.Height / 2 - Me.Height / 2)))
                form.Show()
            Case "vw_MAILS"
                form2.Text = "Email Settings"
                form2.MdiParent = frmMain
                form2.Mode = FormMode.NewRecord
                form2.Scroller = GridView1
                form2.FormScroller = Me
                frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(form2), New Point(CInt(Me.Parent.ClientRectangle.Width / 2 - Me.Width / 2), CInt(Me.Parent.ClientRectangle.Height / 2 - Me.Height / 2)))
                form2.Show()
            Case "vw_STATUS"
                form3.Text = "Status"
                form3.MdiParent = frmMain
                form3.Mode = FormMode.NewRecord
                form3.Scroller = GridView1
                form3.FormScroller = Me
                form3.DataTable = "STATUS"
                form3.L1.Text = "Κωδικός"
                form3.L2.Text = "Status"
                form3.L6.Text = "Χρώμα"
                form3.chk1.Text = "Επιτρέπονται ειδοποιήσεις"
                form3.FormScroller = Me
                form3.CalledFromControl = False
                form3.L3.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
                form3.L4.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
                form3.L6.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
                form3.L8.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
                frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(form3), New Point(CInt(Me.Parent.ClientRectangle.Width / 2 - Me.Width / 2), CInt(Me.Parent.ClientRectangle.Height / 2 - Me.Height / 2)))
                form3.Show()
            Case "vw_SOURCE"
                form4.Text = "Πηγές"
                form4.MdiParent = frmMain
                form4.Mode = FormMode.NewRecord
                form4.Scroller = GridView1
                form4.FormScroller = Me
                form4.DataTable = "SRC"
                form4.L1.Text = "Κωδικός"
                form4.L2.Text = "Πηγή"
                form4.FormScroller = Me
                form4.CalledFromControl = False
                form4.L3.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
                form4.L4.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
                form4.L5.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
                form4.L6.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
                form4.L8.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
                frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(form4), New Point(CInt(Me.Parent.ClientRectangle.Width / 2 - Me.Width / 2), CInt(Me.Parent.ClientRectangle.Height / 2 - Me.Height / 2)))
                form4.Show()
            Case "vw_CCT"
                form10.Text = "Πελάτες"
                form10.MdiParent = frmMain
                form10.Mode = FormMode.NewRecord
                form10.Scroller = GridView1
                form10.FormScroller = Me
                frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(form10), New Point(CInt(Me.Parent.ClientRectangle.Width / 2 - Me.Width / 2), CInt(Me.Parent.ClientRectangle.Height / 2 - Me.Height / 2)))
                form10.Show()
            Case "vw_COU"
                form5.Text = "Νομοί"
                form5.MdiParent = frmMain
                form5.Mode = FormMode.NewRecord
                form5.Scroller = GridView1
                form5.DataTable = "COU"
                form5.L1.Text = "Κωδικός"
                form5.L2.Text = "Νομός"
                form5.FormScroller = Me
                form5.CalledFromControl = False
                form5.L3.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
                form5.L4.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
                form5.L5.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
                form5.L5.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
                form5.L6.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
                form5.L8.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
                frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(form5), New Point(CInt(Me.Parent.ClientRectangle.Width / 2 - Me.Width / 2), CInt(Me.Parent.ClientRectangle.Height / 2 - Me.Height / 2)))
                form5.Show()
            Case "vw_SALERS"
                form11.Text = "Πωλητές"
                form11.MdiParent = frmMain
                form11.Mode = FormMode.NewRecord
                form11.Scroller = GridView1
                form11.DataTable = "SALERS"
                form11.L1.Text = "Κωδικός"
                form11.L2.Text = "Πωλητής"
                form11.L6.Text = "Χρώμα"
                form11.L8.Text = "Αρ. Πρωτοκόλου"
                form11.FormScroller = Me
                form11.CalledFromControl = False
                form11.L3.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
                form11.L4.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
                form11.L5.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
                form11.L8.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
                frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(form11), New Point(CInt(Me.Parent.ClientRectangle.Width / 2 - Me.Width / 2), CInt(Me.Parent.ClientRectangle.Height / 2 - Me.Height / 2)))
                form11.Show()
            Case "vw_AREAS"
                form6.Text = "Περιοχές"
                form6.MdiParent = frmMain
                form6.Mode = FormMode.NewRecord
                form6.Scroller = GridView1
                form6.DataTable = "AREAS"
                form6.L1.Text = "Κωδικός"
                form6.L2.Text = "Περιοχή"
                form6.L3.Text = "Νομός"
                form6.FormScroller = Me
                form6.CalledFromControl = False
                form6.L4.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
                form6.L5.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
                form6.L6.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
                form6.L8.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
                frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(form6), New Point(CInt(Me.Parent.ClientRectangle.Width / 2 - Me.Width / 2), CInt(Me.Parent.ClientRectangle.Height / 2 - Me.Height / 2)))
                form6.Show()
            Case "vw_ADR"
                form7.Text = "Διευθύνσεις"
                form7.MdiParent = frmMain
                form7.Mode = FormMode.NewRecord
                form7.Scroller = GridView1
                form7.DataTable = "ADR"
                form7.L1.Text = "Κωδικός"
                form7.L2.Text = "Διεύθυνση"
                form7.L3.Text = "Νομός"
                form7.L4.Text = "Περιοχές"
                form7.FormScroller = Me
                form7.CalledFromControl = False
                form7.L5.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
                form7.L6.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
                form7.L8.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
                frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(form7), New Point(CInt(Me.Parent.ClientRectangle.Width / 2 - Me.Width / 2), CInt(Me.Parent.ClientRectangle.Height / 2 - Me.Height / 2)))
                form7.Show()
            Case "vw_DOY"
                form8.Text = "ΔΟΥ"
                form8.MdiParent = frmMain
                form8.Mode = FormMode.NewRecord
                form8.Scroller = GridView1
                form8.DataTable = "DOY"
                form8.L1.Text = "Κωδικός"
                form8.L2.Text = "ΔΟΥ"
                form8.FormScroller = Me
                form8.CalledFromControl = False
                form8.L3.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
                form8.L4.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
                form8.L5.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
                form8.L6.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
                form8.L8.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
                frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(form8), New Point(CInt(Me.Parent.ClientRectangle.Width / 2 - Me.Width / 2), CInt(Me.Parent.ClientRectangle.Height / 2 - Me.Height / 2)))
                form8.Show()
            Case "vw_PRF"
                form9.Text = "Επαγγέλματα"
                form9.MdiParent = frmMain
                form9.Mode = FormMode.NewRecord
                form9.Scroller = GridView1
                form9.DataTable = "PRF"
                form9.L1.Text = "Κωδικός"
                form9.L2.Text = "Επάγγελμα"
                form9.FormScroller = Me
                form9.CalledFromControl = False
                form9.L3.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
                form9.L4.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
                form9.L5.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
                form9.L6.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
                form9.L8.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
                frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(form9), New Point(CInt(Me.Parent.ClientRectangle.Width / 2 - Me.Width / 2), CInt(Me.Parent.ClientRectangle.Height / 2 - Me.Height / 2)))
                form9.Show()
            Case "vw_CCT_M"
                form12.Text = "Κινήσεις Πελατών"
                form12.MdiParent = frmMain
                form12.Mode = FormMode.NewRecord
                form12.Scroller = GridView1
                form12.FormScroller = Me
                frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(form12), New Point(CInt(Me.Parent.ClientRectangle.Width / 2 - Me.Width / 2), CInt(Me.Parent.ClientRectangle.Height / 2 - Me.Height / 2)))
                form12.Show()
            Case "vw_NOTES_L"
                form13.Text = "Εττικέτες"
                form13.MdiParent = frmMain
                form13.Mode = FormMode.NewRecord
                form13.Scroller = GridView1
                form13.DataTable = "NOTES_L"
                form13.L1.Text = "Κωδικός"
                form13.L2.Text = "Εττικέτα"
                form13.FormScroller = Me
                form13.CalledFromControl = False
                form13.L3.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
                form13.L4.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
                form13.L5.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
                form13.L6.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
                form13.L8.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
                frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(form13), New Point(CInt(Me.Parent.ClientRectangle.Width / 2 - Me.Width / 2), CInt(Me.Parent.ClientRectangle.Height / 2 - Me.Height / 2)))
                form13.Show()
            Case "vw_DOOR_TYPE"
                form14.Text = "Κατηγορία Πόρτας"
                form14.MdiParent = frmMain
                form14.Mode = FormMode.NewRecord
                form14.Scroller = GridView1
                form14.FormScroller = Me
                frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(form14), New Point(CInt(Me.Parent.ClientRectangle.Width / 2 - Me.Width / 2), CInt(Me.Parent.ClientRectangle.Height / 2 - Me.Height / 2)))
                form14.Show()
            Case "vw_CAT_ERM"
                form15.Text = "Κατηγορίες Ερμαρίων"
                form15.MdiParent = frmMain
                form15.Mode = FormMode.NewRecord
                form15.Scroller = GridView1
                form15.DataTable = "CAT_ERM"
                form15.L1.Text = "Κωδικός"
                form15.L2.Text = "Κατηγορία"
                form15.FormScroller = Me
                form15.CalledFromControl = False
                form15.L3.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
                form15.L4.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
                form15.L5.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
                form15.L6.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
                form15.L8.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
                frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(form15), New Point(CInt(Me.Parent.ClientRectangle.Width / 2 - Me.Width / 2), CInt(Me.Parent.ClientRectangle.Height / 2 - Me.Height / 2)))
                form15.Show()
            Case "vw_ERM"
                form16.Text = "Ερμάρια"
                form16.MdiParent = frmMain
                form16.Mode = FormMode.NewRecord
                form16.Scroller = GridView1
                form16.FormScroller = Me
                frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(form16), New Point(CInt(Me.Parent.ClientRectangle.Width / 2 - Me.Width / 2), CInt(Me.Parent.ClientRectangle.Height / 2 - Me.Height / 2)))
                form16.Show()
            Case "vw_BENCH"
                form17.Text = "Πάγκοι"
                form17.MdiParent = frmMain
                form17.Mode = FormMode.NewRecord
                form17.Scroller = GridView1
                form17.FormScroller = Me
                frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(form17), New Point(CInt(Me.Parent.ClientRectangle.Width / 2 - Me.Width / 2), CInt(Me.Parent.ClientRectangle.Height / 2 - Me.Height / 2)))
                form17.Show()
            Case "vw_MECH"
                form18.Text = "Μηχανισμοί"
                form18.MdiParent = frmMain
                form18.Mode = FormMode.NewRecord
                form18.Scroller = GridView1
                form18.FormScroller = Me
                frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(form18), New Point(CInt(Me.Parent.ClientRectangle.Width / 2 - Me.Width / 2), CInt(Me.Parent.ClientRectangle.Height / 2 - Me.Height / 2)))
                form18.Show()
            Case "vw_TECH_CAT"
                form19.Text = "Κατηγορίες Τεχνικής Υποστήριξης"
                form19.MdiParent = frmMain
                form19.Mode = FormMode.NewRecord
                form19.Scroller = GridView1
                form19.DataTable = "TECH_CAT"
                form19.L1.Text = "Κωδικός"
                form19.L2.Text = "Κατηγορία"
                form19.FormScroller = Me
                form19.CalledFromControl = False
                form19.L3.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
                form19.L4.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
                form19.L5.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
                form19.L6.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
                form19.L8.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
                frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(form19), New Point(CInt(Me.Parent.ClientRectangle.Width / 2 - Me.Width / 2), CInt(Me.Parent.ClientRectangle.Height / 2 - Me.Height / 2)))
                form19.Show()
            Case "vw_COLORS_CAT"
                form20.Text = "Κατηγορίες Χρωμάτων"
                form20.MdiParent = frmMain
                form20.Mode = FormMode.NewRecord
                form20.Scroller = GridView1
                form20.DataTable = "COLORS_CAT"
                form20.L1.Text = "Κωδικός"
                form20.L2.Text = "Κατηγορίες Χρωμάτων"
                form20.FormScroller = Me
                form20.CalledFromControl = False
                form20.L3.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
                form20.L4.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
                form20.L5.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
                form20.L6.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
                form20.L8.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
                frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(form20), New Point(CInt(Me.Parent.ClientRectangle.Width / 2 - Me.Width / 2), CInt(Me.Parent.ClientRectangle.Height / 2 - Me.Height / 2)))
                form20.Show()

        End Select
    End Sub
    'Φορτώνω τις εγγραφές στο GRID
    Public Sub LoadRecords(Optional ByVal sDataTable2 As String = "", Optional ByVal sWhere As String = "")
        Dim sSQL As String
        Dim sSQL2 As String
        Try
            If BarRecords.EditValue <> "ALL" And BarRecords.EditValue <> "" Then
                sSQL = "SELECT top " & BarRecords.EditValue & " * FROM " & IIf(sDataTable = "", sDataTable2, sDataTable) & " " & sWhereCondition
                If sDataDetail <> "" Then sSQL2 = "SELECT top " & BarRecords.EditValue & " * FROM " & sDataDetail
            Else
                sSQL = "SELECT  * FROM " & IIf(sDataTable = "", sDataTable2, sDataTable) & " " & sWhereCondition
                If sDataDetail <> "" Then sSQL2 = "SELECT  * FROM " & sDataDetail
            End If

            If sDataDetail = "" Then
                myCmd = CNDB.CreateCommand
                myCmd.CommandText = sSQL
                GridView1.Columns.Clear()
                myReader = myCmd.ExecuteReader()
                grdMain.DataSource = myReader
            Else
                Select Case sDataDetail
                    Case "vw_FORM_RIGHTS"
                        Dim AdapterMaster As New SqlDataAdapter(sSQL, CNDB)
                        Dim AdapterDetail As New SqlDataAdapter(sSQL2, CNDB)
                        Dim sdataSet As New DataSet()
                        AdapterMaster.Fill(sdataSet, IIf(sDataTable = "", sDataTable2, sDataTable))
                        AdapterDetail.Fill(sdataSet, sDataDetail)
                        Dim keyColumn As DataColumn = sdataSet.Tables(IIf(sDataTable = "", sDataTable2, sDataTable)).Columns("ID")
                        Dim foreignKeyColumn As DataColumn = sdataSet.Tables(sDataDetail).Columns("RID")
                        sdataSet.Relations.Add("Φόρμες", keyColumn, foreignKeyColumn)
                        GridView1.Columns.Clear()
                        GridView2.Columns.Clear()
                        grdMain.DataSource = sdataSet.Tables(IIf(sDataTable = "", sDataTable2, sDataTable))
                        grdMain.ForceInitialize()
                End Select
            End If
            grdMain.DefaultView.PopulateColumns()

            'Εαν δεν έχει data το Dataset αναγκαστικά προσθέτω μόνος μου τις στήλες
            If sDataDetail = "" Then
                If myReader.HasRows = False Then
                    For i As Integer = 0 To myReader.FieldCount - 1
                        Dim C As New GridColumn
                        C.Name = "col" & myReader.GetName(i).ToString
                        C.Caption = myReader.GetName(i).ToString
                        C.Visible = True
                        GridView1.Columns.Add(C)
                    Next i
                Else
                    LoadViews()
                End If
            Else
                LoadViews()
            End If
        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), "Dreamy Kitchen CRM", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        'If grdMain.DefaultView.DataRowCount <> 0 Then myReader.Close() 'myReader.Close()
    End Sub
    Private Sub grdMain_KeyDown(sender As Object, e As KeyEventArgs) Handles grdMain.KeyDown
        Select Case e.KeyCode
            Case Keys.F2 : If UserProps.AllowInsert = True Then NewRecord()
            Case Keys.F3 : If UserProps.AllowEdit = True Then EditRecord()
            Case Keys.F5 : LoadRecords()
            Case Keys.Delete : If UserProps.AllowDelete = True Then DeleteRecord()
        End Select
    End Sub

    Private Sub frmScroller_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        If Me.WindowState = FormWindowState.Maximized Then frmMain.XtraTabbedMdiManager1.Dock(Me, frmMain.XtraTabbedMdiManager1)
    End Sub

    Private Sub GridView1_CustomColumnDisplayText(sender As Object, e As CustomColumnDisplayTextEventArgs) Handles GridView1.CustomColumnDisplayText
        If e.Column.FieldName.Contains("pwd") Then e.DisplayText = StrDup(e.DisplayText.Length, "*")

    End Sub

    Private Sub GridView1_KeyDown(sender As Object, e As KeyEventArgs) Handles GridView1.KeyDown
        Dim view As GridView = CType(sender, GridView)
        If e.Control AndAlso e.KeyCode = Keys.C Then
            If view.GetRowCellValue(view.FocusedRowHandle, view.FocusedColumn) IsNot Nothing AndAlso view.GetRowCellValue(view.FocusedRowHandle, view.FocusedColumn).ToString() <> [String].Empty Then
                Clipboard.SetText(view.GetRowCellValue(view.FocusedRowHandle, view.FocusedColumn).ToString())
            End If
            e.Handled = True
        End If
    End Sub
    'Ορίζουμε το Detail View στο GridView2 που προσθέσαμε στο Design.  
    Private Sub grdMain_ViewRegistered(sender As Object, e As DevExpress.XtraGrid.ViewOperationEventArgs) Handles grdMain.ViewRegistered
        GridView2 = TryCast(e.View, GridView)
        GridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus
        GridView2.OptionsBehavior.Editable = False
        GridView2.OptionsBehavior.ReadOnly = True
        GridView2.OptionsLayout.Columns.StoreAllOptions = True
        GridView2.OptionsLayout.Columns.StoreAppearance = True
        GridView2.OptionsLayout.StoreAllOptions = True
        GridView2.OptionsLayout.StoreAppearance = True
        GridView2.OptionsLayout.StoreFormatRules = True
        GridView2.OptionsPrint.PrintPreview = True
        GridView2.OptionsSelection.EnableAppearanceFocusedCell = False
        GridView2.OptionsView.EnableAppearanceEvenRow = True
        If CurrentView = "" Then
            If sDataDetail <> "" Then GridView2.RestoreLayoutFromXml(Application.StartupPath & "\DSGNS\DEF\" & sDataDetail & "_def.xml", OptionsLayoutBase.FullLayout)
        Else
            If sDataDetail <> "" Then GridView2.RestoreLayoutFromXml(Application.StartupPath & "\DSGNS\" & sDataDetail & "\" & BarViews.EditValue, OptionsLayoutBase.FullLayout)
        End If
    End Sub
    'Αποθήκευση όψης ως Default
    Private Sub popSaveAsDefault_ItemClick(sender As Object, e As ItemClickEventArgs) Handles popSaveAsDefault.ItemClick
        If GridView1.OptionsLayout.LayoutVersion <> "" Then
            Dim sVer As Integer = GridView1.OptionsLayout.LayoutVersion.Replace("v", "")
            GridView1.OptionsLayout.LayoutVersion = "v" & sVer + 1
        Else
            GridView1.OptionsLayout.LayoutVersion = "v1"
        End If

        GridView1.SaveLayoutToXml(Application.StartupPath & "\DSGNS\DEF\" & sDataTable & "_def.xml", OptionsLayoutBase.FullLayout)
        If sDataDetail <> "" Then GridView2.SaveLayoutToXml(Application.StartupPath & "\DSGNS\DEF\" & sDataDetail & "_def.xml", OptionsLayoutBase.FullLayout)
        XtraMessageBox.Show("Η όψη αποθηκέυτηκε με επιτυχία", "Dreamy Kitchen CRM", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub
    ' Copy Cell
    Private Sub BarCopyCell_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BarCopyCell.ItemClick
        Dim view As GridView = CType(GridView1, GridView)
        If view.GetRowCellValue(view.FocusedRowHandle, view.FocusedColumn) IsNot Nothing AndAlso view.GetRowCellValue(view.FocusedRowHandle, view.FocusedColumn).ToString() <> [String].Empty Then
            Clipboard.SetText(view.GetRowCellValue(view.FocusedRowHandle, view.FocusedColumn).ToString())
        End If
    End Sub
    'Copy All
    Private Sub BarCopyAll_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BarCopyAll.ItemClick
        GridView1.OptionsSelection.MultiSelect = True
        GridView1.SelectAll()
        GridView1.CopyToClipboard()
        GridView1.OptionsSelection.MultiSelect = False
    End Sub
    'Copy Row
    Private Sub BarCopyRow_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BarCopyRow.ItemClick
        Dim view As GridView = CType(GridView1, GridView)
        If view.GetRowCellValue(view.FocusedRowHandle, view.FocusedColumn) IsNot Nothing AndAlso view.GetRowCellValue(view.FocusedRowHandle, view.FocusedColumn).ToString() <> [String].Empty Then
            GridView1.OptionsSelection.MultiSelect = True
            GridView1.SelectRow(view.FocusedRowHandle)
            GridView1.CopyToClipboard()
            GridView1.OptionsSelection.MultiSelect = False
        End If
    End Sub
    'Copy Row
    Private Sub BarCopyRow_D_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BarCopyRow_D.ItemClick
        Dim view As GridView = CType(GridView2, GridView)
        If view.GetRowCellValue(view.FocusedRowHandle, view.FocusedColumn) IsNot Nothing AndAlso view.GetRowCellValue(view.FocusedRowHandle, view.FocusedColumn).ToString() <> [String].Empty Then
            GridView2.OptionsSelection.MultiSelect = True
            GridView2.SelectRow(view.FocusedRowHandle)
            GridView2.CopyToClipboard()
            GridView2.OptionsSelection.MultiSelect = False
        End If
    End Sub
    'Copy All
    Private Sub BarCopyAll_D_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BarCopyAll_D.ItemClick
        GridView2.OptionsSelection.MultiSelect = True
        GridView2.SelectAll()
        GridView2.CopyToClipboard()
        GridView2.OptionsSelection.MultiSelect = False
    End Sub
    ' Copy Cell
    Private Sub BarCopyCell_D_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BarCopyCell_D.ItemClick
        Dim view As GridView = CType(GridView2, GridView)
        If view.GetRowCellValue(view.FocusedRowHandle, view.FocusedColumn) IsNot Nothing AndAlso view.GetRowCellValue(view.FocusedRowHandle, view.FocusedColumn).ToString() <> [String].Empty Then
            Clipboard.SetText(view.GetRowCellValue(view.FocusedRowHandle, view.FocusedColumn).ToString())
        End If
    End Sub

    Private Sub GridView2_KeyDown(sender As Object, e As KeyEventArgs) Handles GridView2.KeyDown
        Dim view As GridView = CType(sender, GridView)
        If e.Control AndAlso e.KeyCode = Keys.C Then
            If view.GetRowCellValue(view.FocusedRowHandle, view.FocusedColumn) IsNot Nothing AndAlso view.GetRowCellValue(view.FocusedRowHandle, view.FocusedColumn).ToString() <> [String].Empty Then
                Clipboard.SetText(view.GetRowCellValue(view.FocusedRowHandle, view.FocusedColumn).ToString())
            End If
            e.Handled = True
        End If
    End Sub

    Private Sub GridView1_RowCellStyle(sender As Object, e As RowCellStyleEventArgs) Handles GridView1.RowCellStyle
        Try
            Select Case e.Column.FieldName
                Case "color"
                    If Not IsDBNull(e.CellValue) Then e.Appearance.BackColor = Color.FromArgb(e.CellValue)
                Case "S_CCT_M_Color"
                    'If e.CellValue <> "" Then
                    If Not IsDBNull(e.CellValue) Then
                        e.Appearance.BackColor = Color.FromArgb(e.CellValue)
                    End If
            End Select
        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), "Dreamy Kitchen CRM", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BarManager1_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BarManager1.ItemClick
        'MessageBox.Show("Item '" & e.Item.Caption & "' has been clicked")
        If e.Item.Name = "ViewCusMov" Then
            'form1.ID = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "ID").ToString
            Dim form As frmScroller = New frmScroller()
            form.Text = "Στατιστικά Πελατών"
            form.DataTable = "vw_CUS_REPORT1"
            form.DataTableWhereCondition = "Where ID = " & toSQLValueS(GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "ID").ToString)
            'form.MdiParent = Me
            form.Show()
        End If
    End Sub

    Private Sub BBUpdateViewFromDB_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BBUpdateViewFromDB.ItemClick
        'ReadXml.UpdateXMLFile(Application.StartupPath & "\DSGNS\DEF\" & sDataTable & "_def.xml")
        'My.Computer.FileSystem.DeleteFile(Application.StartupPath & "\DSGNS\DEF\" & sDataTable & "_def.xml")
        Dim col1 As GridColumn
        Dim grdColumns As List(Of GridColumn)
        LoadRecords()
        If myReader Is Nothing Then Exit Sub
        'Εαν υπάρχουν πεδία που πρέπει να προστεθούν από την βάση
        If myReader.FieldCount >= GridView1.Columns.Count Then
            Dim schema As DataTable = myReader.GetSchemaTable()
            grdColumns = GridView1.Columns.ToList()
            For i As Integer = 0 To myReader.FieldCount - 1
                Console.WriteLine(myReader.GetName(i))
                Dim Col2 As GridColumn = GridView1.Columns(myReader.GetName(i))
                If Col2 Is Nothing Then
                    col1 = GridView1.Columns.AddField(myReader.GetName(i))
                    col1.FieldName = myReader.GetName(i)
                    col1.Visible = True
                    col1.VisibleIndex = 0
                    col1.AppearanceCell.BackColor = Color.Bisque
                End If

            Next
            'Εαν έχουν σβηστεί πεδία από την βάση τα αφαιρεί και από το grid
        ElseIf myReader.FieldCount < GridView1.Columns.Count Then
            Dim schema As DataTable = myReader.GetSchemaTable()
            grdColumns = GridView1.Columns.ToList()

            For i As Integer = 0 To grdColumns.Count - 1
                Try
                    Dim Col2 As GridColumn = grdColumns(i)
                    Dim sOrd As String = myReader.GetOrdinal(Col2.FieldName)
                Catch ex As Exception
                    Dim Col2 As GridColumn = grdColumns(i)
                    GridView1.Columns.Remove(Col2)
                    Console.WriteLine(ex.Message)

                    Continue For
                End Try

            Next

        End If
    End Sub


End Class