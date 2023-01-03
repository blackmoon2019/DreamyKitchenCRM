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
Imports System.IO
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo

Public Class frmScroller

    Private myConn As SqlConnection
    Private myCmd As SqlCommand
    Private myReader As SqlDataReader
    Private sDataTable As String
    Private sWhereCondition As String
    Private sDataDetail As String
    Private CurrentView As String
    Private LoadForms As New FormLoader
    Private bIsConstr As Boolean

    Public WriteOnly Property IsConstr As Boolean
        Set(value As Boolean)
            bIsConstr = value
        End Set
    End Property

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

            'Φόρτωση Εγγραφών
            LoadRecords()

            'Φόρτωση Σχεδίων στην Λίστα βάση επιλογής από το μενού
            'LoadViews()
            'Φορτώνει όλες τις ονομασίες των στηλών από τον SQL. Από το πεδίο Description
            'LoadForms.LoadColumnDescriptionNames(grdMain, GridView1, , sDataTable)


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
            GridView1.OptionsBehavior.AutoExpandAllGroups = True
            GridView1.OptionsMenu.ShowFooterItem = True
            GridView1.OptionsMenu.EnableFooterMenu = True
            GridView1.OptionsMenu.EnableGroupPanelMenu = True
            GridView1.OptionsMenu.EnableGroupRowMenu = True
            GridView1.OptionsView.ShowFooter = True
            GridView1.OptionsMenu.ShowGroupSummaryEditorItem = True
            GridView1.OptionsMenu.ShowGroupSortSummaryItems = True
            GridView1.OptionsMenu.ShowConditionalFormattingItem = True
            GridView1.OptionsSelection.MultiSelect = True
            GridView1.OptionsSelection.MultiSelectMode = GridMultiSelectMode.RowSelect

            GridView2.OptionsBehavior.AutoExpandAllGroups = True
            GridView2.OptionsMenu.ShowFooterItem = True
            GridView2.OptionsMenu.EnableFooterMenu = True
            GridView2.OptionsMenu.EnableGroupPanelMenu = True
            GridView2.OptionsMenu.EnableGroupRowMenu = True
            GridView2.OptionsView.ShowFooter = True
            GridView2.OptionsMenu.ShowGroupSummaryEditorItem = True
            GridView2.OptionsMenu.ShowGroupSortSummaryItems = True
            GridView2.OptionsMenu.ShowConditionalFormattingItem = True
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
        CType(BarRecords.Edit, RepositoryItemComboBox).Items.Add("1000000")
        BarRecords.EditValue = ProgProps.Records
    End Sub
    'Φόρτωση όψεων Per User στο Combo
    Private Sub LoadViews()
        Try
            BarViews.EditValue = ""

            ''Εαν δεν υπάρχει Default Σχέδιο δημιουργεί
            If System.IO.File.Exists(Application.StartupPath & "\DSGNS\DEF\" & sDataTable & "_def.xml") = False Then
                'LoadForms.RestoreLayoutFromXml(GridView1, sDataTable & "_def.xml")
                GetNewestFileFromServer(Application.StartupPath & "\DSGNS\DEF\" & sDataTable & "_def.xml")
                'GridView1.OptionsLayout.LayoutVersion = "v1"
                'GridView1.SaveLayoutToXml(Application.StartupPath & "\DSGNS\DEF\" & sDataTable & "_def.xml", OptionsLayoutBase.FullLayout)
            End If
            If System.IO.File.Exists(Application.StartupPath & "\DSGNS\DEF\D_" & sDataDetail & "_def.xml") = False Then
                If sDataDetail <> "" Then GridView2.SaveLayoutToXml(Application.StartupPath & "\DSGNS\DEF\D_" & sDataDetail & "_def.xml", OptionsLayoutBase.FullLayout)
            End If

            'Εαν δεν υπάρχει Folder Σχεδίου για το συγκεκριμένο πίνακα δημιουργεί
            If My.Computer.FileSystem.DirectoryExists(Application.StartupPath & "\DSGNS\" & sDataTable) = False Then _
                My.Computer.FileSystem.CreateDirectory(Application.StartupPath & "\DSGNS\" & sDataTable)

            'Εαν δεν υπάρχει Folder Σχεδίου για το Detail πίνακα δημιουργεί
            If My.Computer.FileSystem.DirectoryExists(Application.StartupPath & "\DSGNS\D_" & sDataDetail) = False Then _
                My.Computer.FileSystem.CreateDirectory(Application.StartupPath & "\DSGNS\D_" & sDataDetail)

            CType(BarViews.Edit, RepositoryItemComboBox).Items.Clear()
            'Ψάχνει όλα τα σχέδια  του συκεκριμένου χρήστη για τον συγκεκριμένο πίνακα
            Dim files() As String = IO.Directory.GetFiles(Application.StartupPath & "\DSGNS\" & sDataTable, "*_" & UserProps.Code & "*")
            For Each sFile As String In files
                CType(BarViews.Edit, RepositoryItemComboBox).Items.Add(System.IO.Path.GetFileName(sFile))
            Next
            BarViews.EditValue = CurrentView
            If CurrentView = "" Then
                LoadForms.RestoreLayoutFromXml(GridView1, sDataTable & "_def.xml")
                GridView1.OptionsBehavior.AlignGroupSummaryInGroupRow = DefaultBoolean.True
                If sDataDetail <> "" Then LoadForms.RestoreLayoutFromXml(GridView2, sDataDetail & "_def.xml")
            Else
                GridView1.RestoreLayoutFromXml(Application.StartupPath & "\DSGNS\" & sDataTable & "\" & BarViews.EditValue, OptionsLayoutBase.FullLayout)
                GridView1.OptionsBehavior.AlignGroupSummaryInGroupRow = DefaultBoolean.True
                If sDataDetail <> "" Then GridView2.RestoreLayoutFromXml(Application.StartupPath & "\DSGNS\D_" & sDataDetail & "\" & BarViews.EditValue, OptionsLayoutBase.FullLayout)
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
                    Case "vw_DOOR_CAT" : sSQL = "DELETE FROM DOOR_CAT WHERE ID = '" & GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "ID").ToString & "'"
                    Case "vw_SER" : sSQL = "DELETE FROM SER WHERE ID = '" & GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "ID").ToString & "'"
                    Case "vw_INST" : sSQL = "DELETE FROM INST WHERE ID = '" & GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "ID").ToString & "'"
                    Case "vw_INST_M" : sSQL = "DELETE FROM INST_M WHERE ID = '" & GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "ID").ToString & "'"
                    Case "vw_INST_ELLIPSE" : sSQL = "DELETE FROM INST_ELLIPSE WHERE ID = '" & GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "ID").ToString & "'"
                    Case "vw_BANKS" : sSQL = "DELETE FROM BANKS WHERE ID = '" & GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "ID").ToString & "'"
                    Case "vw_EMP" : sSQL = "DELETE FROM EMP WHERE ID = '" & GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "ID").ToString & "'"
                    Case "vw_EMP_S" : sSQL = "DELETE FROM EMP_S WHERE ID = '" & GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "ID").ToString & "'"
                    Case "vw_EMP_M_S" : sSQL = "DELETE FROM EMP_M_S WHERE ID = '" & GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "ID").ToString & "'"
                    Case "vw_EMP_M" : sSQL = "DELETE FROM EMP_M WHERE ID = '" & GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "ID").ToString & "'"
                    Case "vw_EMP_T" : sSQL = "DELETE FROM EMP_T WHERE ID = '" & GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "ID").ToString & "'"
                    Case "vw_DEP" : sSQL = "DELETE FROM DEP WHERE ID = '" & GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "ID").ToString & "'"
                    Case "vw_SALER_CAL_STATUS" : sSQL = "DELETE FROM SALER_CAL_STATUS WHERE ID = '" & GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "ID").ToString & "'"
                    Case "vw_CONSTR_CAT" : sSQL = "DELETE FROM CONSTR_CAT WHERE ID = '" & GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "ID").ToString & "'"
                    Case "vw_CONSTR" : sSQL = "DELETE FROM CONSTR WHERE ID = '" & GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "ID").ToString & "'"
                    Case "vw_JOBS" : sSQL = "DELETE FROM JOBS WHERE ID = '" & GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "ID").ToString & "'"
                    Case "vw_SCAN_FILE_NAMES" : sSQL = "DELETE FROM SCAN_FILE_NAMES WHERE ID = '" & GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "ID").ToString & "'"
                    Case "vw_PROJECT_COST" : sSQL = "DELETE FROM PROJECT_COST WHERE ID = '" & GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "ID").ToString & "'"
                    Case "vw_NOTES" : sSQL = "DELETE FROM NOTES WHERE ID = '" & GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "ID").ToString & "'"
                    Case "vw_PAY" : sSQL = "DELETE FROM PAY WHERE ID = '" & GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "ID").ToString & "'"
                    Case "vw_SUP" : sSQL = "DELETE FROM SUP WHERE ID = '" & GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "ID").ToString & "'"
                    Case "vw_BUY_C" : sSQL = "DELETE FROM BUY_C WHERE ID = '" & GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "ID").ToString & "'"
                    Case "vw_CCT_OFFERS" : sSQL = "DELETE FROM CCT_OFFERS WHERE ID = '" & GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "ID").ToString & "'"
                    Case "vw_CCT_OFFERS_CLOSET" : sSQL = "DELETE FROM CCT_OFFERS_CLOSET WHERE ID = '" & GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "ID").ToString & "'"
                    Case "vw_CCT_OFFERS_DOOR" : sSQL = "DELETE FROM CCT_OFFERS_DOOR WHERE ID = '" & GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "ID").ToString & "'"
                    Case "vw_CCT_OFFERS_SPECIAL_CONSTR" : sSQL = "DELETE FROM CCT_OFFERS_SPECIAL_CONSTR WHERE ID = '" & GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "ID").ToString & "'"
                    Case "vw_CCT_ORDERS_SPECIAL_CONSTR" : sSQL = "DELETE FROM CCT_ORDERS_SPECIAL_CONSTR WHERE ID = '" & GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "ID").ToString & "'"
                    Case "vw_CCT_ORDERS_KITCHEN" : sSQL = "DELETE FROM CCT_ORDERS_KITCHEN WHERE ID = '" & GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "ID").ToString & "'"
                    Case "vw_CCT_ORDERS_DOOR" : sSQL = "DELETE FROM CCT_ORDERS_DOOR WHERE ID = '" & GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "ID").ToString & "'"
                    Case "vw_SUP_ORDERS" : sSQL = "DELETE FROM SUP_ORDERS WHERE ID = '" & GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "ID").ToString & "'"
                    Case "vw_EQUIPMENT" : sSQL = "DELETE FROM EQUIPMENT WHERE ID = '" & GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "ID").ToString & "'"
                    Case "vw_EQUIPMENT_CAT" : sSQL = "DELETE FROM vw_EQUIPMENT_CAT WHERE ID = '" & GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "ID").ToString & "'"
                    Case "vw_DEVICES" : sSQL = "DELETE FROM DEVICES WHERE ID = '" & GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "ID").ToString & "'"
                    Case "vw_CCT_ORDERS_CLOSET" : sSQL = "DELETE FROM CCT_ORDERS_CLOSET WHERE ID = '" & GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "ID").ToString & "'"
                    Case "vw_AGREEMENT" : sSQL = "DELETE FROM AGREEMENT WHERE ID = '" & GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "ID").ToString & "'"
                    Case "vw_EP_STATUS" : sSQL = "DELETE FROM EP_STATUS WHERE ID = '" & GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "ID").ToString & "'"
                    Case "vw_TRANS_CONSTR" : sSQL = "DELETE FROM TRANS_CONSTR WHERE ID = '" & GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "ID").ToString & "'"
                    Case "vw_TRANSCOST" : sSQL = "DELETE FROM TRANSCOST WHERE ID = '" & GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "ID").ToString & "'"
                    Case "vw_CONSTR_TYPE" : sSQL = "DELETE FROM CONSTR_TYPE WHERE ID = '" & GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "ID").ToString & "'"
                    Case "vw_DMVER" : sSQL = "DELETE FROM DMVER WHERE ID = '" & GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "ID").ToString & "'"
                    Case "vw_SUP_PAYMENTS_H"
                        ' Επαναφορά τιμολογίων σε απλήρωτα όπου αυτό χρειάζεται
                        sSQL = "UPDATE BUY	SET PAID=0	FROM BUY INNER JOIN	SUP_PAYMENTS_D SD ON SD.buyID=BUY.ID WHERE SD.supPaymentHID= '" & GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "ID").ToString & "'"
                        Using oCmd As New SqlCommand(sSQL, CNDB)
                            oCmd.ExecuteNonQuery()
                        End Using

                        sSQL = "DELETE FROM SUP_PAYMENTS_H WHERE ID = '" & GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "ID").ToString & "'"
                        Using oCmd As New SqlCommand(sSQL, CNDB)
                            oCmd.ExecuteNonQuery()
                        End Using
                        'Ενημέρωση υπολοίπου προμηθευτή όταν το τιμολόγιο δεν είναι πληρωμένο και δεν είναι μετρητοίς
                        Using oCmd As New SqlCommand("FIX_SUP_BAL", CNDB)
                            oCmd.CommandType = CommandType.StoredProcedure
                            oCmd.Parameters.AddWithValue("@supplierID", GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "supID").ToString)
                            oCmd.ExecuteNonQuery()
                        End Using

                    Case "vw_BUY"

                        sSQL = "DELETE FROM BUY WHERE ID = '" & GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "ID").ToString & "'"
                        Using oCmd As New SqlCommand(sSQL, CNDB)
                            oCmd.ExecuteNonQuery()
                        End Using
                        'Ενημέρωση υπολοίπου προμηθευτή όταν το τιμολόγιο δεν είναι πληρωμένο και δεν είναι μετρητοίς
                        Using oCmd As New SqlCommand("FIX_SUP_BAL", CNDB)
                            oCmd.CommandType = CommandType.StoredProcedure
                            oCmd.Parameters.AddWithValue("@supplierID", GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "supID").ToString)
                            oCmd.ExecuteNonQuery()
                        End Using

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
    'Διαγραφη Εγγραφών
    Private Sub DeleteBatchRecords()
        Dim sSQL As String
        Dim sSQL2 As String
        Dim selectedRowHandles As Int32() = GridView1.GetSelectedRows()
        Dim I As Integer
        Try
            If XtraMessageBox.Show("Θέλετε να διαγραφούν η τρέχουσες εγγραφές?", "Dreamy Kitchen CRM", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbNo Then Exit Sub
            For I = 0 To selectedRowHandles.Length - 1
                Dim selectedRowHandle As Int32 = selectedRowHandles(I)

                If GridView1.GetRowCellValue(selectedRowHandle, "ID") = Nothing Then Exit Sub
                Select Case sDataTable
                    Case "vw_USR" : sSQL = "DELETE FROM USR WHERE ID = '" & GridView1.GetRowCellValue(selectedRowHandle, "ID").ToString & "'"
                    Case "vw_MAILS" : sSQL = "DELETE FROM MAILS WHERE ID = '" & GridView1.GetRowCellValue(selectedRowHandle, "ID").ToString & "'"
                    Case "vw_RIGHTS" : sSQL = "DELETE FROM RIGHTS WHERE ID = '" & GridView1.GetRowCellValue(selectedRowHandle, "ID").ToString & "'"
                        sSQL2 = "DELETE FROM FORM_RIGHTS WHERE RID = '" & GridView1.GetRowCellValue(selectedRowHandle, "ID").ToString & "'"
                    Case "vw_COU" : sSQL = "DELETE FROM COU WHERE ID = '" & GridView1.GetRowCellValue(selectedRowHandle, "ID").ToString & "'"
                    Case "vw_AREAS" : sSQL = "DELETE FROM AREAS WHERE ID = '" & GridView1.GetRowCellValue(selectedRowHandle, "ID").ToString & "'"
                    Case "vw_ADR" : sSQL = "DELETE FROM ADR WHERE ID = '" & GridView1.GetRowCellValue(selectedRowHandle, "ID").ToString & "'"
                    Case "vw_DOY" : sSQL = "DELETE FROM DOY WHERE ID = '" & GridView1.GetRowCellValue(selectedRowHandle, "ID").ToString & "'"
                    Case "vw_PRF" : sSQL = "DELETE FROM PRF WHERE ID = '" & GridView1.GetRowCellValue(selectedRowHandle, "ID").ToString & "'"
                    Case "vw_STATUS" : sSQL = "DELETE FROM STATUS WHERE ID = '" & GridView1.GetRowCellValue(selectedRowHandle, "ID").ToString & "'"
                    Case "vw_SOURCE" : sSQL = "DELETE FROM SCR WHERE ID = '" & GridView1.GetRowCellValue(selectedRowHandle, "ID").ToString & "'"
                    Case "vw_CCT" : sSQL = "DELETE FROM CCT WHERE ID = '" & GridView1.GetRowCellValue(selectedRowHandle, "ID").ToString & "'"
                    Case "vw_SALERS" : sSQL = "DELETE FROM SALERS WHERE ID = '" & GridView1.GetRowCellValue(selectedRowHandle, "ID").ToString & "'"
                    Case "vw_CCT_M" : sSQL = "DELETE FROM CCT_M WHERE ID = '" & GridView1.GetRowCellValue(selectedRowHandle, "ID").ToString & "'"
                    Case "vw_REM_VALUES" : sSQL = "DELETE FROM REM_VALUES WHERE ID = '" & GridView1.GetRowCellValue(selectedRowHandle, "ID").ToString & "'"
                    Case "vw_NOTES_L" : sSQL = "DELETE FROM NOTES_L WHERE ID = '" & GridView1.GetRowCellValue(selectedRowHandle, "ID").ToString & "'"
                    Case "vw_DOOR_TYPE" : sSQL = "DELETE FROM DOOR_TYPE WHERE ID = '" & GridView1.GetRowCellValue(selectedRowHandle, "ID").ToString & "'"
                    Case "vw_CAT_ERM" : sSQL = "DELETE FROM CAT_ERM WHERE ID = '" & GridView1.GetRowCellValue(selectedRowHandle, "ID").ToString & "'"
                    Case "vw_ERM" : sSQL = "DELETE FROM ERM WHERE ID = '" & GridView1.GetRowCellValue(selectedRowHandle, "ID").ToString & "'"
                    Case "vw_BENCH" : sSQL = "DELETE FROM BENCH WHERE ID = '" & GridView1.GetRowCellValue(selectedRowHandle, "ID").ToString & "'"
                    Case "vw_MECH" : sSQL = "DELETE FROM MECH WHERE ID = '" & GridView1.GetRowCellValue(selectedRowHandle, "ID").ToString & "'"
                    Case "vw_TECH_CAT" : sSQL = "DELETE FROM TECH_CAT WHERE ID = '" & GridView1.GetRowCellValue(selectedRowHandle, "ID").ToString & "'"
                    Case "vw_TECH_SUP" : sSQL = "DELETE FROM TECH_SUP WHERE ID = '" & GridView1.GetRowCellValue(selectedRowHandle, "ID").ToString & "'"
                    Case "vw_COLORS" : sSQL = "DELETE FROM COLORS WHERE ID = '" & GridView1.GetRowCellValue(selectedRowHandle, "ID").ToString & "'"
                    Case "vw_SIDES" : sSQL = "DELETE FROM SIDES WHERE ID = '" & GridView1.GetRowCellValue(selectedRowHandle, "ID").ToString & "'"
                    Case "vw_DIM" : sSQL = "DELETE FROM DIM WHERE ID = '" & GridView1.GetRowCellValue(selectedRowHandle, "ID").ToString & "'"
                    Case "vw_DOOR_CAT" : sSQL = "DELETE FROM DOOR_CAT WHERE ID = '" & GridView1.GetRowCellValue(selectedRowHandle, "ID").ToString & "'"
                    Case "vw_SER" : sSQL = "DELETE FROM SER WHERE ID = '" & GridView1.GetRowCellValue(selectedRowHandle, "ID").ToString & "'"
                    Case "vw_INST" : sSQL = "DELETE FROM INST WHERE ID = '" & GridView1.GetRowCellValue(selectedRowHandle, "ID").ToString & "'"
                    Case "vw_INST_M" : sSQL = "DELETE FROM INST_M WHERE ID = '" & GridView1.GetRowCellValue(selectedRowHandle, "ID").ToString & "'"
                    Case "vw_INST_ELLIPSE" : sSQL = "DELETE FROM INST_ELLIPSE WHERE ID = '" & GridView1.GetRowCellValue(selectedRowHandle, "ID").ToString & "'"
                    Case "vw_BANKS" : sSQL = "DELETE FROM BANKS WHERE ID = '" & GridView1.GetRowCellValue(selectedRowHandle, "ID").ToString & "'"
                    Case "vw_EMP" : sSQL = "DELETE FROM EMP WHERE ID = '" & GridView1.GetRowCellValue(selectedRowHandle, "ID").ToString & "'"
                    Case "vw_EMP_S" : sSQL = "DELETE FROM EMP_S WHERE ID = '" & GridView1.GetRowCellValue(selectedRowHandle, "ID").ToString & "'"
                    Case "vw_EMP_M_S" : sSQL = "DELETE FROM EMP_M_S WHERE ID = '" & GridView1.GetRowCellValue(selectedRowHandle, "ID").ToString & "'"
                    Case "vw_EMP_M" : sSQL = "DELETE FROM EMP_M WHERE ID = '" & GridView1.GetRowCellValue(selectedRowHandle, "ID").ToString & "'"
                    Case "vw_EMP_T" : sSQL = "DELETE FROM EMP_T WHERE ID = '" & GridView1.GetRowCellValue(selectedRowHandle, "ID").ToString & "'"
                    Case "vw_DEP" : sSQL = "DELETE FROM DEP WHERE ID = '" & GridView1.GetRowCellValue(selectedRowHandle, "ID").ToString & "'"
                    Case "vw_SALER_CAL_STATUS" : sSQL = "DELETE FROM SALER_CAL_STATUS WHERE ID = '" & GridView1.GetRowCellValue(selectedRowHandle, "ID").ToString & "'"
                    Case "vw_CONSTR_CAT" : sSQL = "DELETE FROM CONSTR_CAT WHERE ID = '" & GridView1.GetRowCellValue(selectedRowHandle, "ID").ToString & "'"
                    Case "vw_CONSTR" : sSQL = "DELETE FROM CONSTR WHERE ID = '" & GridView1.GetRowCellValue(selectedRowHandle, "ID").ToString & "'"
                    Case "vw_JOBS" : sSQL = "DELETE FROM JOBS WHERE ID = '" & GridView1.GetRowCellValue(selectedRowHandle, "ID").ToString & "'"
                    Case "vw_SCAN_FILE_NAMES" : sSQL = "DELETE FROM SCAN_FILE_NAMES WHERE ID = '" & GridView1.GetRowCellValue(selectedRowHandle, "ID").ToString & "'"
                    Case "vw_PROJECT_COST" : sSQL = "DELETE FROM PROJECT_COST WHERE ID = '" & GridView1.GetRowCellValue(selectedRowHandle, "ID").ToString & "'"
                    Case "vw_NOTES" : sSQL = "DELETE FROM NOTES WHERE ID = '" & GridView1.GetRowCellValue(selectedRowHandle, "ID").ToString & "'"
                    Case "vw_PAY" : sSQL = "DELETE FROM PAY WHERE ID = '" & GridView1.GetRowCellValue(selectedRowHandle, "ID").ToString & "'"
                    Case "vw_SUP" : sSQL = "DELETE FROM SUP WHERE ID = '" & GridView1.GetRowCellValue(selectedRowHandle, "ID").ToString & "'"
                    Case "vw_BUY_C" : sSQL = "DELETE FROM BUY_C WHERE ID = '" & GridView1.GetRowCellValue(selectedRowHandle, "ID").ToString & "'"
                    Case "vw_CCT_OFFERS" : sSQL = "DELETE FROM CCT_OFFERS WHERE ID = '" & GridView1.GetRowCellValue(selectedRowHandle, "ID").ToString & "'"
                    Case "vw_CCT_OFFERS_CLOSET" : sSQL = "DELETE FROM CCT_OFFERS_CLOSET WHERE ID = '" & GridView1.GetRowCellValue(selectedRowHandle, "ID").ToString & "'"
                    Case "vw_CCT_OFFERS_DOOR" : sSQL = "DELETE FROM CCT_OFFERS_DOOR WHERE ID = '" & GridView1.GetRowCellValue(selectedRowHandle, "ID").ToString & "'"
                    Case "vw_CCT_OFFERS_SPECIAL_CONSTR" : sSQL = "DELETE FROM CCT_OFFERS_SPECIAL_CONSTR WHERE ID = '" & GridView1.GetRowCellValue(selectedRowHandle, "ID").ToString & "'"
                    Case "vw_CCT_ORDERS_SPECIAL_CONSTR" : sSQL = "DELETE FROM CCT_ORDERS_SPECIAL_CONSTR WHERE ID = '" & GridView1.GetRowCellValue(selectedRowHandle, "ID").ToString & "'"
                    Case "vw_CCT_ORDERS_KITCHEN" : sSQL = "DELETE FROM CCT_ORDERS_KITCHEN WHERE ID = '" & GridView1.GetRowCellValue(selectedRowHandle, "ID").ToString & "'"
                    Case "vw_CCT_ORDERS_DOOR" : sSQL = "DELETE FROM CCT_ORDERS_DOOR WHERE ID = '" & GridView1.GetRowCellValue(selectedRowHandle, "ID").ToString & "'"
                    Case "vw_SUP_ORDERS" : sSQL = "DELETE FROM SUP_ORDERS WHERE ID = '" & GridView1.GetRowCellValue(selectedRowHandle, "ID").ToString & "'"
                    Case "vw_EQUIPMENT" : sSQL = "DELETE FROM EQUIPMENT WHERE ID = '" & GridView1.GetRowCellValue(selectedRowHandle, "ID").ToString & "'"
                    Case "vw_EQUIPMENT_CAT" : sSQL = "DELETE FROM vw_EQUIPMENT_CAT WHERE ID = '" & GridView1.GetRowCellValue(selectedRowHandle, "ID").ToString & "'"
                    Case "vw_DEVICES" : sSQL = "DELETE FROM DEVICES WHERE ID = '" & GridView1.GetRowCellValue(selectedRowHandle, "ID").ToString & "'"
                    Case "vw_CCT_ORDERS_CLOSET" : sSQL = "DELETE FROM CCT_ORDERS_CLOSET WHERE ID = '" & GridView1.GetRowCellValue(selectedRowHandle, "ID").ToString & "'"
                    Case "vw_AGREEMENT" : sSQL = "DELETE FROM AGREEMENT WHERE ID = '" & GridView1.GetRowCellValue(selectedRowHandle, "ID").ToString & "'"
                    Case "vw_EP_STATUS" : sSQL = "DELETE FROM EP_STATUS WHERE ID = '" & GridView1.GetRowCellValue(selectedRowHandle, "ID").ToString & "'"
                    Case "vw_TRANS_CONSTR" : sSQL = "DELETE FROM TRANS_CONSTR WHERE ID = '" & GridView1.GetRowCellValue(selectedRowHandle, "ID").ToString & "'"
                    Case "vw_CONSTR_TYPE" : sSQL = "DELETE FROM CONSTR_TYPE WHERE ID = '" & GridView1.GetRowCellValue(selectedRowHandle, "ID").ToString & "'"
                    Case "vw_DMVER" : sSQL = "DELETE FROM DMVER WHERE ID = '" & GridView1.GetRowCellValue(selectedRowHandle, "ID").ToString & "'"
                    Case "vw_TRANSCOST" : sSQL = "DELETE FROM TRANSCOST WHERE ID = '" & GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "ID").ToString & "'"
                    Case "vw_SUP_PAYMENTS_H"
                        ' Επαναφορά τιμολογίων σε απλήρωτα όπου αυτό χρειάζεται
                        sSQL = "UPDATE BUY	SET PAID=0	FROM BUY INNER JOIN	SUP_PAYMENTS_D SD ON SD.buyID=BUY.ID WHERE SD.supPaymentHID= '" & GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "ID").ToString & "'"
                        Using oCmd As New SqlCommand(sSQL, CNDB)
                            oCmd.ExecuteNonQuery()
                        End Using
                        'Ενημέρωση υπολοίπου προμηθευτή όταν το τιμολόγιο δεν είναι πληρωμένο και δεν είναι μετρητοίς
                        Using oCmd As New SqlCommand("FIX_SUP_BAL", CNDB)
                            oCmd.CommandType = CommandType.StoredProcedure
                            oCmd.Parameters.AddWithValue("@supplierID", GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "supID").ToString)
                            oCmd.ExecuteNonQuery()
                        End Using

                        sSQL = "DELETE FROM SUP_PAYMENTS_H WHERE ID = '" & GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "ID").ToString & "'"
                        Using oCmd As New SqlCommand(sSQL, CNDB)
                            oCmd.ExecuteNonQuery()
                        End Using

                    Case "vw_BUY"
                        'Ενημέρωση υπολοίπου προμηθευτή όταν το τιμολόγιο δεν είναι πληρωμένο και δεν είναι μετρητοίς
                        Using oCmd As New SqlCommand("FIX_SUP_BAL", CNDB)
                            oCmd.CommandType = CommandType.StoredProcedure
                            oCmd.Parameters.AddWithValue("@supplierID", GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "supID").ToString)
                            oCmd.ExecuteNonQuery()
                        End Using

                        sSQL = "DELETE FROM BUY WHERE ID = '" & GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "ID").ToString & "'"
                        Using oCmd As New SqlCommand(sSQL, CNDB)
                            oCmd.ExecuteNonQuery()
                        End Using

                    Case "vw_TRANSH"
                        sSQL = "DELETE FROM CCTF FROM CCT_F CCTF INNER JOIN TRANSH ON CCTF.cctID = TRANSH.cusID AND CCTF.isinvoice=1 
                                WHERE TRANSH.ID = '" & GridView1.GetRowCellValue(selectedRowHandle, "ID").ToString & "'"
                        Using oCmd As New SqlCommand(sSQL, CNDB)
                            oCmd.ExecuteNonQuery()
                        End Using
                        sSQL = "DELETE FROM TRANSD WHERE TRANSHID = '" & GridView1.GetRowCellValue(selectedRowHandle, "ID").ToString & "'"
                        Using oCmd As New SqlCommand(sSQL, CNDB)
                            oCmd.ExecuteNonQuery()
                        End Using
                        sSQL = "DELETE FROM TRANSH WHERE ID = '" & GridView1.GetRowCellValue(selectedRowHandle, "ID").ToString & "'"
                    Case "vw_OFF"
                        sSQL = "DELETE FROM [OFFER_MECH] WHERE offID = '" & GridView1.GetRowCellValue(selectedRowHandle, "ID").ToString & "'"
                        Using oCmd As New SqlCommand(sSQL, CNDB)
                            oCmd.ExecuteNonQuery()
                        End Using
                        sSQL = "DELETE FROM [OFFER_SIDES] WHERE offID = '" & GridView1.GetRowCellValue(selectedRowHandle, "ID").ToString & "'"
                        Using oCmd As New SqlCommand(sSQL, CNDB)
                            oCmd.ExecuteNonQuery()
                        End Using
                        sSQL = "DELETE FROM [OFF_TOTAL] WHERE offID = '" & GridView1.GetRowCellValue(selectedRowHandle, "ID").ToString & "'"
                        Using oCmd As New SqlCommand(sSQL, CNDB)
                            oCmd.ExecuteNonQuery()
                        End Using
                        sSQL = "DELETE FROM [OFFERS] WHERE offID = '" & GridView1.GetRowCellValue(selectedRowHandle, "ID").ToString & "'"
                        Using oCmd As New SqlCommand(sSQL, CNDB)
                            oCmd.ExecuteNonQuery()
                        End Using
                        sSQL = "DELETE FROM [OFF_SUBOFF] WHERE offID = '" & GridView1.GetRowCellValue(selectedRowHandle, "ID").ToString & "'"
                        Using oCmd As New SqlCommand(sSQL, CNDB)
                            oCmd.ExecuteNonQuery()
                        End Using
                        sSQL = "DELETE FROM [OFF_DET] WHERE offID = '" & GridView1.GetRowCellValue(selectedRowHandle, "ID").ToString & "'"
                        Using oCmd As New SqlCommand(sSQL, CNDB)
                            oCmd.ExecuteNonQuery()
                        End Using
                        sSQL = "DELETE FROM [OFF] WHERE ID = '" & GridView1.GetRowCellValue(selectedRowHandle, "ID").ToString & "'"
                    Case "vw_CALC" : sSQL = "DELETE FROM CALC WHERE ID = '" & GridView1.GetRowCellValue(selectedRowHandle, "ID").ToString & "'"
                    Case "vw_CAT_SUB_ERM" : sSQL = "DELETE FROM CAT_SUB_ERM WHERE ID = '" & GridView1.GetRowCellValue(selectedRowHandle, "ID").ToString & "'"

                End Select

                Using oCmd As New SqlCommand(sSQL, CNDB)
                    oCmd.ExecuteNonQuery()
                End Using
                If sSQL2 <> "" Then
                    Using oCmd As New SqlCommand(sSQL2, CNDB)
                        oCmd.ExecuteNonQuery()
                    End Using
                End If
            Next

            LoadRecords()
            XtraMessageBox.Show("Η εγγραφές διαγράφηκαν με επιτυχία", "Dreamy Kitchen CRM", MessageBoxButtons.OK, MessageBoxIcon.Information)
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
                If sDataDetail <> "" Then GridView2.RestoreLayoutFromXml(Application.StartupPath & "\DSGNS\D_" & sDataDetail & "\" & BarViews.EditValue, OptionsLayoutBase.FullLayout)
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
        If sDataDetail = "" Then
            If myReader Is Nothing Then Exit Sub
            myReader.Close()
        End If
    End Sub
    'Διαγραφή όψης
    Private Sub popDeleteView_ItemClick(sender As Object, e As ItemClickEventArgs) Handles popDeleteView.ItemClick
        If XtraMessageBox.Show("Θέλετε να διαγραφεί η τρέχουσα όψη?", "Dreamy Kitchen CRM", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            If BarViews.EditValue <> "" Then
                My.Computer.FileSystem.DeleteFile(Application.StartupPath & "\DSGNS\" & sDataTable & "\" & BarViews.EditValue)
                If sDataDetail <> "" Then My.Computer.FileSystem.DeleteFile(Application.StartupPath & "\DSGNS\D_" & sDataDetail & "\" & BarViews.EditValue)
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
                If My.Computer.FileSystem.FileExists(Application.StartupPath & "\DSGNS\" & sDataTable & "\" & sender.EditValue) = True Then
                    GridView1.SaveLayoutToXml(Application.StartupPath & "\DSGNS\" & sDataTable & "\" & sender.EditValue, OptionsLayoutBase.FullLayout)
                    CType(BarViews.Edit, RepositoryItemComboBox).Items.Add(sender.EditValue)
                    BarViews.EditValue = sender.EditValue
                Else
                    GridView1.SaveLayoutToXml(Application.StartupPath & "\DSGNS\" & sDataTable & "\" & sender.EditValue & "_" & UserProps.Code & ".xml", OptionsLayoutBase.FullLayout)
                    CType(BarViews.Edit, RepositoryItemComboBox).Items.Add(sender.EditValue & "_" & UserProps.Code & ".xml")
                    BarViews.EditValue = sender.EditValue & "_" & UserProps.Code & ".xml"
                End If

                If sDataDetail <> "" Then
                    If My.Computer.FileSystem.FileExists(Application.StartupPath & "\DSGNS\" & sDataTable & "\" & sender.EditValue) = True Then
                        GridView2.SaveLayoutToXml(Application.StartupPath & "\DSGNS\D_" & sDataDetail & "\" & sender.EditValue, OptionsLayoutBase.FullLayout)
                    Else
                        GridView2.SaveLayoutToXml(Application.StartupPath & "\DSGNS\D_" & sDataDetail & "\" & sender.EditValue & "_" & UserProps.Code & ".xml", OptionsLayoutBase.FullLayout)
                    End If
                End If
                'grdMain.DefaultView.SaveLayoutToXml(Application.StartupPath & "\DSGNS\" & sDataTable & "\" & sender.EditValue & "_" & UserProps.Code & ".xml")
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
                My.Computer.FileSystem.DeleteFile(Application.StartupPath & "\DSGNS\D_" & sDataDetail & "\" & BarViews.EditValue)
                GridView2.SaveLayoutToXml(Application.StartupPath & "\DSGNS\D_" & sDataDetail & "\" & BarViews.EditValue, OptionsLayoutBase.FullLayout)
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
        ProgProps.Records = BarRecords.EditValue
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\DreamyKitchen", "Records", BarRecords.EditValue)
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
            Dim menuItem As DevExpress.Utils.Menu.DXEditMenuItem
            Dim item As New DXEditMenuItem()
            Dim itemColor As New DXEditMenuItem()

            menuItem = menu.Items.Item("Μετονομασία Στήλης")
            'menu.Items.Clear()
            If menu.Column IsNot Nothing And menuItem Is Nothing Then
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

                '4nd Custom Menu Item
                menu.Items.Add(New DXMenuItem("Αποθήκευση όψης", AddressOf OnSaveView, Nothing, Nothing, Nothing, Nothing))

                '5nd Custom Menu Item
                menu.Items.Add(New DXMenuItem("Συγχρονισμός όψης από Server", AddressOf OnSyncView, Nothing, Nothing, Nothing, Nothing))

                '6nd Custom Menu Item
                menu.Items.Add(New DXMenuItem("Ενημέρωση πεδίων όψης από Βάση", AddressOf OnUpdateViewFromDB, Nothing, Nothing, Nothing, Nothing))

            End If
        Else
            PopupMenuRowsDetail.ShowPopup(Control.MousePosition)
        End If
    End Sub
    Private Sub OnUpdateViewFromDB(ByVal sender As System.Object, ByVal e As EventArgs)
        UpdateViewFromDB(GridView2)
    End Sub
    Private Sub OnSaveView(ByVal sender As System.Object, ByVal e As EventArgs)
        Dim item As DXMenuItem = TryCast(sender, DXMenuItem)
        GridView2.SaveLayoutToXml(Application.StartupPath & "\DSGNS\DEF\D_" & sDataDetail & "_def.xml", OptionsLayoutBase.FullLayout)
        XtraMessageBox.Show("Η όψη αποθηκεύτηκε με επιτυχία", "Dreamy Kitchen CRM", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ' Μόνο αν ο Χρήστης είναι ο Παναγόπουλος
        If UserProps.ID.ToString.ToUpper = "3F9DC32E-BE5B-4D46-A13C-EA606566CF32" Then
            If XtraMessageBox.Show("Θέλετε να γίνει κοινοποίηση της όψης? Εαν επιλέξετε 'Yes' όλοι οι χρήστες θα έχουν την ίδια όψη", "Dreamy Kitchen CRM", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                If My.Computer.FileSystem.FileExists(ProgProps.ServerViewsPath & "DSGNS\DEF\" & sDataDetail & "_def.xml") = False Then GridView2.OptionsLayout.LayoutVersion = "v1"
                GridView2.SaveLayoutToXml(ProgProps.ServerViewsPath & "DSGNS\DEF\D_" & sDataDetail & "_def.xml", OptionsLayoutBase.FullLayout)
            End If
        End If

    End Sub
    'Συγχρονισμός όψης από Server
    Private Sub OnSyncView(ByVal sender As System.Object, ByVal e As EventArgs)
        If XtraMessageBox.Show("Θέλετε να γίνει μεταφορά της όψης από τον server?", "Dreamy Kitchen CRM", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            ' Έλεγχος αν υπάρχει όψη με μεταγενέστερη ημερομηνία στον Server
            If System.IO.File.Exists(ProgProps.ServerViewsPath & "DSGNS\DEF\D_" & sDataDetail & "_def.xml") = True Then
                My.Computer.FileSystem.CopyFile(ProgProps.ServerViewsPath & "DSGNS\DEF\D_" & sDataDetail & "_def.xml", Application.StartupPath & "\DSGNS\DEF\D_" & sDataDetail & "_def.xml", True)
                GridView2.RestoreLayoutFromXml(Application.StartupPath & "\DSGNS\DEF\D_" & sDataDetail & "_def.xml", OptionsLayoutBase.FullLayout)
            End If
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
        If GridView1.IsGroupRow(GridView1.FocusedRowHandle) Then Exit Sub Else EditRecord()
    End Sub
    'Νέα Εγγραφή
    Private Sub BarNewRec_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BarNewRec.ItemClick
        NewRecord()
    End Sub
    'Επεξεργασία Εγγραφής
    Private Sub BarEdit_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BarEdit.ItemClick

        If GridView1.IsGroupRow(GridView1.FocusedRowHandle) Then Exit Sub Else EditRecord()
    End Sub
    'Διαγραφή Εγγραφής
    Private Sub BarDelete_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BarDelete.ItemClick
        If GridView1.IsGroupRow(GridView1.FocusedRowHandle) Then
            Exit Sub
        Else
            If GridView1.SelectedRowsCount = 1 Then
                DeleteRecord()
            Else
                DeleteBatchRecords()
            End If
        End If
    End Sub
    'Ανανέωση εγγραφών
    Private Sub BarRefresh_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BarRefresh.ItemClick
        LoadRecords()
    End Sub
    'Επεξεργασία Εγγραφής
    Private Sub EditRecord()
        Dim frmGen As frmGen = New frmGen()
        If GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "ID") Is Nothing Then Exit Sub
        Select Case sDataTable
            Case "vw_DMVER"
                Dim frmVersions As frmVersions = New frmVersions()
                frmVersions.Text = "Εκδόσεις"
                frmVersions.ID = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "ID").ToString
                frmVersions.MdiParent = frmMain
                frmVersions.Mode = FormMode.EditRecord
                frmVersions.Scroller = GridView1
                frmVersions.FormScroller = Me
                frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(frmVersions), New Point(CInt(Me.Parent.ClientRectangle.Width / 2 - Me.Width / 2), CInt(Me.Parent.ClientRectangle.Height / 2 - Me.Height / 2)))
                frmVersions.Show()
            Case "vw_TRANSCOST"
                Dim frmTransCost As frmTransCost = New frmTransCost()
                frmTransCost.Text = "Κοστολόγηση Έργων"
                frmTransCost.ID = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "ID").ToString
                frmTransCost.MdiParent = frmMain
                frmTransCost.Mode = FormMode.EditRecord
                frmTransCost.Scroller = GridView1
                frmTransCost.FormScroller = Me
                frmTransCost.FormScrollerExist = True
                frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(frmTransCost), New Point(CInt(Me.Parent.ClientRectangle.Width / 2 - Me.Width / 2), CInt(Me.Parent.ClientRectangle.Height / 2 - Me.Height / 2)))
                frmTransCost.Show()
            Case "vw_TRANS_CONSTR"
                Dim frmTransConstr As frmTransConstr = New frmTransConstr()
                frmTransConstr.Text = "Κλείσιμο Κατασκευής"
                frmTransConstr.ID = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "ID").ToString
                frmTransConstr.MdiParent = frmMain
                frmTransConstr.Mode = FormMode.EditRecord
                frmTransConstr.Scroller = GridView1
                frmTransConstr.FormScroller = Me
                frmTransConstr.FormScrollerExist = True
                frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(frmTransConstr), New Point(CInt(Me.Parent.ClientRectangle.Width / 2 - Me.Width / 2), CInt(Me.Parent.ClientRectangle.Height / 2 - Me.Height / 2)))
                frmTransConstr.Show()
            Case "vw_SUP_ORDERS"
                Dim frmSUPOrders As frmSUPOrders = New frmSUPOrders()
                frmSUPOrders.Text = "Παραγγελίες Προμηθευτών"
                frmSUPOrders.ID = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "ID").ToString
                frmSUPOrders.MdiParent = frmMain
                frmSUPOrders.Mode = FormMode.EditRecord
                frmSUPOrders.Scroller = GridView1
                frmSUPOrders.FormScroller = Me
                frmSUPOrders.FormScrollerExist = True
                frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(frmSUPOrders), New Point(CInt(Me.Parent.ClientRectangle.Width / 2 - Me.Width / 2), CInt(Me.Parent.ClientRectangle.Height / 2 - Me.Height / 2)))
                frmSUPOrders.Show()
            Case "vw_AGREEMENT"
                Dim frmPrivateAgreement As frmCUSPrivateAgreement = New frmCUSPrivateAgreement()
                frmPrivateAgreement.Text = "Ιδ. Συμφωνητικό"
                frmPrivateAgreement.ID = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "ID").ToString
                frmPrivateAgreement.MdiParent = frmMain
                frmPrivateAgreement.Mode = FormMode.EditRecord
                frmPrivateAgreement.Scroller = GridView1
                frmPrivateAgreement.FormScroller = Me
                frmPrivateAgreement.FormScrollerExist = True
                frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(frmPrivateAgreement), New Point(CInt(Me.Parent.ClientRectangle.Width / 2 - Me.Width / 2), CInt(Me.Parent.ClientRectangle.Height / 2 - Me.Height / 2)))
                frmPrivateAgreement.Show()
            Case "vw_CCT_ORDERS_CLOSET"
                Dim frmCUSOrderCloset As frmCUSOrderCloset = New frmCUSOrderCloset()
                frmCUSOrderCloset.Text = "Έντυπο Παραγγελίας Πελατών(Ντουλάπα)"
                frmCUSOrderCloset.ID = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "ID").ToString
                frmCUSOrderCloset.MdiParent = frmMain
                frmCUSOrderCloset.Mode = FormMode.EditRecord
                frmCUSOrderCloset.Scroller = GridView1
                frmCUSOrderCloset.FormScroller = Me
                frmCUSOrderCloset.FormScrollerExist = True
                frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(frmCUSOrderCloset), New Point(CInt(Me.Parent.ClientRectangle.Width / 2 - Me.Width / 2), CInt(Me.Parent.ClientRectangle.Height / 2 - Me.Height / 2)))
                frmCUSOrderCloset.Show()
            Case "vw_CCT_ORDERS_KITCHEN"
                Dim frmCUSOrderKitchen As frmCUSOrderKitchen = New frmCUSOrderKitchen()
                frmCUSOrderKitchen.Text = "Έντυπο Παραγγελίας Πελατών(Κουζίνα)"
                frmCUSOrderKitchen.ID = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "ID").ToString
                frmCUSOrderKitchen.MdiParent = frmMain
                frmCUSOrderKitchen.Mode = FormMode.EditRecord
                frmCUSOrderKitchen.Scroller = GridView1
                frmCUSOrderKitchen.FormScroller = Me
                frmCUSOrderKitchen.FormScrollerExist = True
                frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(frmCUSOrderKitchen), New Point(CInt(Me.Parent.ClientRectangle.Width / 2 - Me.Width / 2), CInt(Me.Parent.ClientRectangle.Height / 2 - Me.Height / 2)))
                frmCUSOrderKitchen.Show()
            Case "vw_CCT_ORDERS_SPECIAL_CONSTR"
                Dim frmCUSOfferSpecialConstr As frmCUSOfferOrderSpecialConstr = New frmCUSOfferOrderSpecialConstr()
                frmCUSOfferSpecialConstr.Text = "Έντυπο Παραγγελίας Πελατών(Έπιπλο Μπάνιου)"
                frmCUSOfferSpecialConstr.ID = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "ID").ToString
                frmCUSOfferSpecialConstr.MdiParent = frmMain
                frmCUSOfferSpecialConstr.IsOrder = True
                frmCUSOfferSpecialConstr.Mode = FormMode.EditRecord
                frmCUSOfferSpecialConstr.Scroller = GridView1
                frmCUSOfferSpecialConstr.FormScroller = Me
                frmCUSOfferSpecialConstr.FormScrollerExist = True
                frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(frmCUSOfferSpecialConstr), New Point(CInt(Me.Parent.ClientRectangle.Width / 2 - Me.Width / 2), CInt(Me.Parent.ClientRectangle.Height / 2 - Me.Height / 2)))
                frmCUSOfferSpecialConstr.Show()
            Case "vw_CCT_OFFERS_SPECIAL_CONSTR"
                Dim frmCUSOfferSpecialConstr As frmCUSOfferOrderSpecialConstr = New frmCUSOfferOrderSpecialConstr()
                frmCUSOfferSpecialConstr.Text = "Έντυπο Προσφοράς Πελατών(Έπιπλο Μπάνιου)"
                frmCUSOfferSpecialConstr.ID = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "ID").ToString
                frmCUSOfferSpecialConstr.IsOrder = False
                frmCUSOfferSpecialConstr.MdiParent = frmMain
                frmCUSOfferSpecialConstr.Mode = FormMode.EditRecord
                frmCUSOfferSpecialConstr.Scroller = GridView1
                frmCUSOfferSpecialConstr.FormScroller = Me
                frmCUSOfferSpecialConstr.FormScrollerExist = True
                frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(frmCUSOfferSpecialConstr), New Point(CInt(Me.Parent.ClientRectangle.Width / 2 - Me.Width / 2), CInt(Me.Parent.ClientRectangle.Height / 2 - Me.Height / 2)))
                frmCUSOfferSpecialConstr.Show()
            Case "vw_CCT_OFFERS_DOOR", "vw_CCT_ORDERS_DOOR"
                Dim frmCUSOfferOrderDoors As frmCUSOfferOrderDoors = New frmCUSOfferOrderDoors()
                If sDataTable = "vw_CCT_OFFERS_DOOR" Then
                    frmCUSOfferOrderDoors.Text = "Έντυπο Προσφοράς Πελατών(Πόρτες)"
                    frmCUSOfferOrderDoors.IsOrder = False
                Else
                    frmCUSOfferOrderDoors.Text = "Έντυπο Παραγγελίας Πελατών(Πόρτες)"
                    frmCUSOfferOrderDoors.IsOrder = True
                End If
                frmCUSOfferOrderDoors.ID = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "ID").ToString
                frmCUSOfferOrderDoors.MdiParent = frmMain
                frmCUSOfferOrderDoors.Mode = FormMode.EditRecord
                frmCUSOfferOrderDoors.Scroller = GridView1
                frmCUSOfferOrderDoors.FormScroller = Me
                frmCUSOfferOrderDoors.FormScrollerExist = True
                frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(frmCUSOfferOrderDoors), New Point(CInt(Me.Parent.ClientRectangle.Width / 2 - Me.Width / 2), CInt(Me.Parent.ClientRectangle.Height / 2 - Me.Height / 2)))
                frmCUSOfferOrderDoors.Show()
            Case "vw_CCT_OFFERS_CLOSET"
                Dim frmCUSOfferCloset As frmCUSOfferCloset = New frmCUSOfferCloset()
                frmCUSOfferCloset.Text = "Έντυπο Προσφοράς Πελατών(Ντουλάπες)"
                frmCUSOfferCloset.ID = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "ID").ToString
                frmCUSOfferCloset.MdiParent = frmMain
                frmCUSOfferCloset.Mode = FormMode.EditRecord
                frmCUSOfferCloset.Scroller = GridView1
                frmCUSOfferCloset.FormScroller = Me
                frmCUSOfferCloset.FormScrollerExist = True
                frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(frmCUSOfferCloset), New Point(CInt(Me.Parent.ClientRectangle.Width / 2 - Me.Width / 2), CInt(Me.Parent.ClientRectangle.Height / 2 - Me.Height / 2)))
                frmCUSOfferCloset.Show()
            Case "vw_CCT_OFFERS"
                Dim frmCUSOffer As frmCUSOfferKitchen = New frmCUSOfferKitchen()
                frmCUSOffer.Text = "Έντυπο Προσφοράς Πελατών(Κουζίνα)"
                frmCUSOffer.ID = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "ID").ToString
                frmCUSOffer.MdiParent = frmMain
                frmCUSOffer.Mode = FormMode.EditRecord
                frmCUSOffer.Scroller = GridView1
                frmCUSOffer.FormScroller = Me
                frmCUSOffer.FormScrollerExist = True
                frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(frmCUSOffer), New Point(CInt(Me.Parent.ClientRectangle.Width / 2 - Me.Width / 2), CInt(Me.Parent.ClientRectangle.Height / 2 - Me.Height / 2)))
                frmCUSOffer.Show()
            Case "vw_SUP_PAYMENTS_H"
                Dim frmSUPKal As frmSUPKal = New frmSUPKal()
                frmSUPKal.Text = "Πληρωμές Παραστατικών Προμηθευτών"
                frmSUPKal.ID = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "ID").ToString
                frmSUPKal.MdiParent = frmMain
                frmSUPKal.Mode = FormMode.EditRecord
                frmSUPKal.Scroller = GridView1
                frmSUPKal.FormScroller = Me
                frmSUPKal.FormScrollerExist = True
                frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(frmSUPKal), New Point(CInt(Me.Parent.ClientRectangle.Width / 2 - Me.Width / 2), CInt(Me.Parent.ClientRectangle.Height / 2 - Me.Height / 2)))
                frmSUPKal.Show()
            Case "vw_BUY"
                Dim frmBUY As frmBUY = New frmBUY()
                frmBUY.Text = "Αγορές"
                frmBUY.ID = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "ID").ToString
                frmBUY.MdiParent = frmMain
                frmBUY.Mode = FormMode.EditRecord
                frmBUY.Scroller = GridView1
                frmBUY.FormScroller = Me
                frmBUY.FormScrollerExist = True
                frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(frmBUY), New Point(CInt(Me.Parent.ClientRectangle.Width / 2 - Me.Width / 2), CInt(Me.Parent.ClientRectangle.Height / 2 - Me.Height / 2)))
                frmBUY.Show()
            Case "vw_NOTES"
                Dim form10 As frmNotes = New frmNotes()
                form10.Text = "Σημειώματα"
                form10.ID = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "ID").ToString
                form10.MdiParent = frmMain
                form10.Mode = FormMode.EditRecord
                form10.Scroller2 = GridView1
                form10.FormScroller = Me
                frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(form10), New Point(CInt(Me.Parent.ClientRectangle.Width / 2 - Me.Width / 2), CInt(Me.Parent.ClientRectangle.Height / 2 - Me.Height / 2)))
                form10.Show()
            Case "vw_EQUIPMENT"
                frmGen.Text = "Εξοπλισμός"
                frmGen.ID = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "ID").ToString
                frmGen.MdiParent = frmMain
                frmGen.Mode = FormMode.EditRecord
                frmGen.Scroller = GridView1
                frmGen.FormScroller = Me
                frmGen.DataTable = "EQUIPMENT"
                frmGen.L1.Text = "Κωδικός"
                frmGen.L2.Text = "Όνομα"
                frmGen.L3.Text = "Κατηγορία"
                frmGen.L3.Control.Tag = "equipmentCatID,0,1,2"
                frmGen.L3.Tag = ""
                frmGen.L3.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
                frmGen.L13.Text = "Τιμή"
                frmGen.L13.Control.Tag = "price,0,1,2"
                frmGen.L13.Tag = ""
                frmGen.L13.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
                frmGen.FormScroller = Me
                frmGen.CalledFromControl = False
                frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(frmGen), New Point(CInt(Me.Parent.ClientRectangle.Width / 2 - Me.Width / 2), CInt(Me.Parent.ClientRectangle.Height / 2 - Me.Height / 2)))
                frmGen.Show()
            Case "vw_EP_STATUS"
                frmGen.Text = "Status Εποπτείας"
                frmGen.ID = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "ID").ToString
                frmGen.MdiParent = frmMain
                frmGen.Mode = FormMode.EditRecord
                frmGen.Scroller = GridView1
                frmGen.FormScroller = Me
                frmGen.DataTable = "EP_STATUS"
                frmGen.L1.Text = "Κωδικός"
                frmGen.L2.Text = "Status"
                frmGen.L8.Text = "Χρονική Διάρκεια(Μέρες)"
                frmGen.L8.Control.Tag = "period,0,1,2"
                frmGen.L8.Tag = ""
                frmGen.L8.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
                frmGen.FormScroller = Me
                frmGen.CalledFromControl = False
                frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(frmGen), New Point(CInt(Me.Parent.ClientRectangle.Width / 2 - Me.Width / 2), CInt(Me.Parent.ClientRectangle.Height / 2 - Me.Height / 2)))
                frmGen.Show()
            Case "vw_EQUIPMENT_CAT"
                frmGen.Text = "Κατηγορίες Εξαρτημάτων"
                frmGen.ID = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "ID").ToString
                frmGen.MdiParent = frmMain
                frmGen.Mode = FormMode.EditRecord
                frmGen.Scroller = GridView1
                frmGen.FormScroller = Me
                frmGen.DataTable = "EQUIPMENT_CAT"
                frmGen.L1.Text = "Κωδικός"
                frmGen.L2.Text = "Όνομα"
                frmGen.FormScroller = Me
                frmGen.CalledFromControl = False
                frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(frmGen), New Point(CInt(Me.Parent.ClientRectangle.Width / 2 - Me.Width / 2), CInt(Me.Parent.ClientRectangle.Height / 2 - Me.Height / 2)))
                frmGen.Show()
            Case "vw_DEVICES"
                frmGen.Text = "Συσκευές"
                frmGen.ID = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "ID").ToString
                frmGen.MdiParent = frmMain
                frmGen.Mode = FormMode.EditRecord
                frmGen.Scroller = GridView1
                frmGen.FormScroller = Me
                frmGen.DataTable = "DEVICES"
                frmGen.L1.Text = "Κωδικός"
                frmGen.L2.Text = "Όνομα"
                frmGen.FormScroller = Me
                frmGen.CalledFromControl = False
                frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(frmGen), New Point(CInt(Me.Parent.ClientRectangle.Width / 2 - Me.Width / 2), CInt(Me.Parent.ClientRectangle.Height / 2 - Me.Height / 2)))
                frmGen.Show()
            Case "vw_BUY_C"
                frmGen.Text = "Κατηγορίες Αγορών"
                frmGen.ID = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "ID").ToString
                frmGen.MdiParent = frmMain
                frmGen.Mode = FormMode.EditRecord
                frmGen.Scroller = GridView1
                frmGen.FormScroller = Me
                frmGen.DataTable = "BUY_C"
                frmGen.L1.Text = "Κωδικός"
                frmGen.L2.Text = "Όνομα"
                frmGen.FormScroller = Me
                frmGen.CalledFromControl = False
                frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(frmGen), New Point(CInt(Me.Parent.ClientRectangle.Width / 2 - Me.Width / 2), CInt(Me.Parent.ClientRectangle.Height / 2 - Me.Height / 2)))
                frmGen.Show()
            Case "vw_SCAN_FILE_NAMES"
                frmGen.Text = "Ονομασίες Scan αρχείων"
                frmGen.ID = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "ID").ToString
                frmGen.MdiParent = frmMain
                frmGen.Mode = FormMode.EditRecord
                frmGen.Scroller = GridView1
                frmGen.FormScroller = Me
                frmGen.DataTable = "SCAN_FILE_NAMES"
                frmGen.L1.Text = "Κωδικός"
                frmGen.L2.Text = "Όνομα"
                frmGen.FormScroller = Me
                frmGen.CalledFromControl = False
                frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(frmGen), New Point(CInt(Me.Parent.ClientRectangle.Width / 2 - Me.Width / 2), CInt(Me.Parent.ClientRectangle.Height / 2 - Me.Height / 2)))
                frmGen.Show()
            Case "vw_JOBS"
                frmGen.Text = "Θέσεις Εργασίας"
                frmGen.ID = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "ID").ToString
                frmGen.MdiParent = frmMain
                frmGen.Mode = FormMode.EditRecord
                frmGen.Scroller = GridView1
                frmGen.FormScroller = Me
                frmGen.DataTable = "JOBS"
                frmGen.L1.Text = "Κωδικός"
                frmGen.L2.Text = "Θέση"
                frmGen.FormScroller = Me
                frmGen.CalledFromControl = False
                frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(frmGen), New Point(CInt(Me.Parent.ClientRectangle.Width / 2 - Me.Width / 2), CInt(Me.Parent.ClientRectangle.Height / 2 - Me.Height / 2)))
                frmGen.Show()
            Case "vw_PAY"
                frmGen.Text = "Τρόποι Πληρωμής"
                frmGen.ID = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "ID").ToString
                frmGen.MdiParent = frmMain
                frmGen.Mode = FormMode.EditRecord
                frmGen.Scroller = GridView1
                frmGen.FormScroller = Me
                frmGen.DataTable = "PAY"
                frmGen.L1.Text = "Κωδικός"
                frmGen.L2.Text = "Τρόπος Πληρωμής"
                frmGen.FormScroller = Me
                frmGen.CalledFromControl = False
                frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(frmGen), New Point(CInt(Me.Parent.ClientRectangle.Width / 2 - Me.Width / 2), CInt(Me.Parent.ClientRectangle.Height / 2 - Me.Height / 2)))
                frmGen.Show()
            Case "vw_CONSTR"
                Dim frmConstrunction As New frmConstrunction
                frmConstrunction.Text = "Μισθοδοσία Κατασκευαστικού"
                frmConstrunction.ID = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "ID").ToString
                frmConstrunction.MdiParent = frmMain
                frmConstrunction.Mode = FormMode.EditRecord
                frmConstrunction.Scroller = GridView1
                frmConstrunction.FormScroller = Me
                frmConstrunction.CalledFromControl = False
                frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(frmConstrunction), New Point(CInt(Me.Parent.ClientRectangle.Width / 2 - Me.Width / 2), CInt(Me.Parent.ClientRectangle.Height / 2 - Me.Height / 2)))
                frmConstrunction.Show()
            Case "vw_PROJECT_COST"
                Dim frmProjectCost As New frmProjectCost
                frmProjectCost.Text = "Ανάλυση Έργων"
                frmProjectCost.ID = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "ID").ToString
                frmProjectCost.MdiParent = frmMain
                frmProjectCost.Mode = FormMode.EditRecord
                frmProjectCost.Scroller = GridView1
                frmProjectCost.FormScroller = Me
                frmProjectCost.CalledFromControl = False
                frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(frmProjectCost), New Point(CInt(Me.Parent.ClientRectangle.Width / 2 - Me.Width / 2), CInt(Me.Parent.ClientRectangle.Height / 2 - Me.Height / 2)))
                frmProjectCost.Show()
            Case "vw_INST_ELLIPSE"
                Dim frmInstEllipse As New frmInstEllipse
                frmInstEllipse.Text = "Ελλείψεις Τοποθετήσεων"
                frmInstEllipse.ID = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "ID").ToString
                frmInstEllipse.MdiParent = frmMain
                frmInstEllipse.Mode = FormMode.EditRecord
                frmInstEllipse.Scroller = GridView1
                frmInstEllipse.FormScroller = Me
                frmInstEllipse.CalledFromControl = False
                frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(frmInstEllipse), New Point(CInt(Me.Parent.ClientRectangle.Width / 2 - Me.Width / 2), CInt(Me.Parent.ClientRectangle.Height / 2 - Me.Height / 2)))
                frmInstEllipse.Show()
            Case "vw_EMP_T"
                Dim frmSalerTziroi As New frmSalerTziroi
                frmSalerTziroi.Text = "Τζίροι-Ποσοστά έκθεσης"
                frmSalerTziroi.ID = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "ID").ToString
                frmSalerTziroi.MdiParent = frmMain
                frmSalerTziroi.Mode = FormMode.EditRecord
                frmSalerTziroi.Scroller = GridView1
                frmSalerTziroi.FormScroller = Me
                frmSalerTziroi.FormScrollerExist = True
                frmSalerTziroi.CalledFromControl = False
                frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(frmSalerTziroi), New Point(CInt(Me.Parent.ClientRectangle.Width / 2 - Me.Width / 2), CInt(Me.Parent.ClientRectangle.Height / 2 - Me.Height / 2)))
                frmSalerTziroi.Show()
            Case "vw_SUP"
                Dim frmSUP As New frmSUP
                frmSUP.Text = "Προμηθευτές"
                frmSUP.ID = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "ID").ToString
                frmSUP.MdiParent = frmMain
                frmSUP.Mode = FormMode.EditRecord
                frmSUP.Scroller = GridView1
                frmSUP.FormScroller = Me
                frmSUP.FormScrollerExist = True
                frmSUP.CalledFromControl = False
                frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(frmSUP), New Point(CInt(Me.Parent.ClientRectangle.Width / 2 - Me.Width / 2), CInt(Me.Parent.ClientRectangle.Height / 2 - Me.Height / 2)))
                frmSUP.Show()
            Case "vw_EMP_M"
                Dim frmEmpPayroll As New frmEmpPayroll
                frmEmpPayroll.Text = "Μισθοδοσία"
                frmEmpPayroll.ID = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "ID").ToString
                frmEmpPayroll.IsConstr = bIsConstr
                frmEmpPayroll.MdiParent = frmMain
                frmEmpPayroll.Mode = FormMode.EditRecord
                frmEmpPayroll.Scroller = GridView1
                frmEmpPayroll.FormScroller = Me
                frmEmpPayroll.FormScrollerExist = True
                frmEmpPayroll.CalledFromControl = False
                frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(frmEmpPayroll), New Point(CInt(Me.Parent.ClientRectangle.Width / 2 - Me.Width / 2), CInt(Me.Parent.ClientRectangle.Height / 2 - Me.Height / 2)))
                frmEmpPayroll.Show()
            Case "vw_EMP_M_S"
                frmGen.Text = "Status Μισθοδοσίας"
                frmGen.ID = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "ID").ToString
                frmGen.MdiParent = frmMain
                frmGen.Mode = FormMode.EditRecord
                frmGen.Scroller = GridView1
                frmGen.FormScroller = Me
                frmGen.DataTable = "EMP_M_S"
                frmGen.L1.Text = "Κωδικός"
                frmGen.L2.Text = "Status"
                frmGen.FormScroller = Me
                frmGen.CalledFromControl = False
                frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(frmGen), New Point(CInt(Me.Parent.ClientRectangle.Width / 2 - Me.Width / 2), CInt(Me.Parent.ClientRectangle.Height / 2 - Me.Height / 2)))
                frmGen.Show()
            Case "vw_CONSTR_CAT"
                frmGen.Text = "Κατηγορίες Εργασιών"
                frmGen.ID = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "ID").ToString
                frmGen.MdiParent = frmMain
                frmGen.Mode = FormMode.EditRecord
                frmGen.Scroller = GridView1
                frmGen.FormScroller = Me
                frmGen.DataTable = "CONSTR_CAT"
                frmGen.L1.Text = "Κωδικός"
                frmGen.L2.Text = "Κατηγορία"
                frmGen.FormScroller = Me
                frmGen.CalledFromControl = False
                frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(frmGen), New Point(CInt(Me.Parent.ClientRectangle.Width / 2 - Me.Width / 2), CInt(Me.Parent.ClientRectangle.Height / 2 - Me.Height / 2)))
                frmGen.Show()
            Case "vw_CONSTR_TYPE"
                frmGen.Text = "Είδη Κατασκευής"
                frmGen.ID = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "ID").ToString
                frmGen.MdiParent = frmMain
                frmGen.Mode = FormMode.EditRecord
                frmGen.Scroller = GridView1
                frmGen.FormScroller = Me
                frmGen.DataTable = "CONSTR_TYPE"
                frmGen.L1.Text = "Κωδικός"
                frmGen.L2.Text = "Είδος"
                frmGen.FormScroller = Me
                frmGen.CalledFromControl = False
                frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(frmGen), New Point(CInt(Me.Parent.ClientRectangle.Width / 2 - Me.Width / 2), CInt(Me.Parent.ClientRectangle.Height / 2 - Me.Height / 2)))
                frmGen.Show()
            Case "vw_INST_M"
                Dim frmInstM As New frmInstM
                frmInstM.Text = "Χρεωπιστώσεις Τοποθετών"
                frmInstM.ID = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "ID").ToString
                frmInstM.InstID = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "instID").ToString
                frmInstM.MdiParent = frmMain
                frmInstM.Mode = FormMode.EditRecord
                frmInstM.Scroller = GridView1
                frmInstM.FormScroller = Me
                frmInstM.CalledFromControl = False
                frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(frmInstM), New Point(CInt(Me.Parent.ClientRectangle.Width / 2 - Me.Width / 2), CInt(Me.Parent.ClientRectangle.Height / 2 - Me.Height / 2)))
                frmInstM.Show()
            Case "vw_EMP"
                Dim frmEMP As New frmEMP
                frmEMP.Text = "Διαχείριση Προσωπικού"
                frmEMP.ID = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "ID").ToString
                frmEMP.MdiParent = frmMain
                frmEMP.Mode = FormMode.EditRecord
                frmEMP.Scroller = GridView1
                frmEMP.FormScroller = Me
                frmEMP.CalledFromControl = False
                frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(frmEMP), New Point(CInt(Me.Parent.ClientRectangle.Width / 2 - Me.Width / 2), CInt(Me.Parent.ClientRectangle.Height / 2 - Me.Height / 2)))
                frmEMP.Show()
            Case "vw_TRANSH"
                Dim frmTransactions As New frmTransactions
                frmTransactions.Text = "Χρεωπιστώσεις"
                frmTransactions.ID = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "ID").ToString
                frmTransactions.MdiParent = frmMain
                frmTransactions.Mode = FormMode.EditRecord
                frmTransactions.Scroller = GridView1
                frmTransactions.FormScroller = Me
                frmTransactions.CalledFromControl = False
                frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(frmTransactions), New Point(CInt(Me.Parent.ClientRectangle.Width / 2 - Me.Width / 2), CInt(Me.Parent.ClientRectangle.Height / 2 - Me.Height / 2)))
                frmTransactions.Show()
            Case "vw_SALER_CAL_STATUS"
                frmGen.Text = "Status Προσωπικού Ημερολογίου"
                frmGen.ID = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "ID").ToString
                frmGen.MdiParent = frmMain
                frmGen.Mode = FormMode.EditRecord
                frmGen.Scroller = GridView1
                frmGen.FormScroller = Me
                frmGen.DataTable = "SALER_CAL_STATUS"
                frmGen.L1.Text = "Κωδικός"
                frmGen.L2.Text = "Status"
                frmGen.L6.Text = "Χρώμα"
                frmGen.FormScroller = Me
                frmGen.CalledFromControl = False
                frmGen.L6.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
                frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(frmGen), New Point(CInt(Me.Parent.ClientRectangle.Width / 2 - Me.Width / 2), CInt(Me.Parent.ClientRectangle.Height / 2 - Me.Height / 2)))
                frmGen.Show()
            Case "vw_EMP_S"
                frmGen.Text = "Statuses Παρουσιολογίου"
                frmGen.ID = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "ID").ToString
                frmGen.MdiParent = frmMain
                frmGen.Mode = FormMode.EditRecord
                frmGen.Scroller = GridView1
                frmGen.FormScroller = Me
                frmGen.DataTable = "EMP_S"
                frmGen.L1.Text = "Κωδικός"
                frmGen.L2.Text = "Status"
                frmGen.L9.Control.Tag = "shortName,0,1,2"
                frmGen.L9.Text = "Συντομογραφία"
                frmGen.L6.Text = "Χρώμα"
                frmGen.FormScroller = Me
                frmGen.CalledFromControl = False
                frmGen.L6.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
                frmGen.L9.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
                frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(frmGen), New Point(CInt(Me.Parent.ClientRectangle.Width / 2 - Me.Width / 2), CInt(Me.Parent.ClientRectangle.Height / 2 - Me.Height / 2)))
                frmGen.Show()
            Case "vw_DEP"
                frmGen.Text = "Τμήματα Εταιρίας"
                frmGen.ID = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "ID").ToString
                frmGen.MdiParent = frmMain
                frmGen.Mode = FormMode.EditRecord
                frmGen.Scroller = GridView1
                frmGen.FormScroller = Me
                frmGen.DataTable = "DEP"
                frmGen.L1.Text = "Κωδικός"
                frmGen.L2.Text = "Τμήμα"
                frmGen.FormScroller = Me
                frmGen.CalledFromControl = False
                frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(frmGen), New Point(CInt(Me.Parent.ClientRectangle.Width / 2 - Me.Width / 2), CInt(Me.Parent.ClientRectangle.Height / 2 - Me.Height / 2)))
                frmGen.Show()
            Case "vw_BANKS"
                frmGen.Text = "Τράπεζες"
                frmGen.ID = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "ID").ToString
                frmGen.MdiParent = frmMain
                frmGen.Mode = FormMode.EditRecord
                frmGen.Scroller = GridView1
                frmGen.FormScroller = Me
                frmGen.DataTable = "BANKS"
                frmGen.L1.Text = "Κωδικός"
                frmGen.L2.Text = "Τράπεζα"
                frmGen.FormScroller = Me
                frmGen.CalledFromControl = False
                frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(frmGen), New Point(CInt(Me.Parent.ClientRectangle.Width / 2 - Me.Width / 2), CInt(Me.Parent.ClientRectangle.Height / 2 - Me.Height / 2)))
                frmGen.Show()
            Case "vw_INST"
                Dim frmInstallations As New frmInstallations
                frmInstallations.Text = "Μισθοδοσία Τοποθετών"
                frmInstallations.ID = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "ID").ToString
                frmInstallations.MdiParent = frmMain
                frmInstallations.Mode = FormMode.EditRecord
                frmInstallations.Scroller = GridView1
                frmInstallations.FormScroller = Me
                frmInstallations.CalledFromControl = False
                frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(frmInstallations), New Point(CInt(Me.Parent.ClientRectangle.Width / 2 - Me.Width / 2), CInt(Me.Parent.ClientRectangle.Height / 2 - Me.Height / 2)))
                frmInstallations.Show()
            Case "vw_SER"
                Dim frmServices As frmServices = New frmServices()
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
                Dim frmCatSubErm As New frmCatSubErm
                frmCatSubErm.Text = "Υποκατηγορίες Ερμαρίων"
                frmCatSubErm.MdiParent = frmMain
                frmCatSubErm.ID = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "ID").ToString
                frmCatSubErm.Mode = FormMode.EditRecord
                frmCatSubErm.Scroller = GridView1
                frmCatSubErm.FormScroller = Me
                frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(frmCatSubErm), New Point(CInt(Me.Parent.ClientRectangle.Width / 2 - Me.Width / 2), CInt(Me.Parent.ClientRectangle.Height / 2 - Me.Height / 2)))
                frmCatSubErm.Show()
            Case "vw_CALC"
                Dim frmCalculations As frmCalculations = New frmCalculations()
                frmCalculations.Text = "Υπολογισμοί"
                frmCalculations.MdiParent = frmMain
                frmCalculations.ID = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "ID").ToString
                frmCalculations.Mode = FormMode.EditRecord
                frmCalculations.Scroller = GridView1
                frmCalculations.FormScroller = Me
                frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(frmCalculations), New Point(CInt(Me.Parent.ClientRectangle.Width / 2 - Me.Width / 2), CInt(Me.Parent.ClientRectangle.Height / 2 - Me.Height / 2)))
                frmCalculations.Show()
            Case "vw_DIM"
                frmGen.Text = "Διαστάσεις"
                frmGen.ID = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "ID").ToString
                frmGen.MdiParent = frmMain
                frmGen.Mode = FormMode.EditRecord
                frmGen.Scroller = GridView1
                frmGen.FormScroller = Me
                frmGen.DataTable = "DIM"
                frmGen.L1.Text = "Κωδικός"
                frmGen.L2.Text = "Διάσταση"
                frmGen.FormScroller = Me
                frmGen.CalledFromControl = False
                frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(frmGen), New Point(CInt(Me.Parent.ClientRectangle.Width / 2 - Me.Width / 2), CInt(Me.Parent.ClientRectangle.Height / 2 - Me.Height / 2)))
                frmGen.Show()
            Case "vw_DOOR_CAT"
                frmGen.Text = "Κατηγορίες Διαστάσεων"
                frmGen.ID = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "ID").ToString
                frmGen.MdiParent = frmMain
                frmGen.Mode = FormMode.EditRecord
                frmGen.Scroller = GridView1
                frmGen.FormScroller = Me
                frmGen.DataTable = "DOOR_CAT"
                frmGen.L1.Text = "Κωδικός"
                frmGen.L2.Text = "Κατηγορία"
                frmGen.FormScroller = Me
                frmGen.CalledFromControl = False
                frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(frmGen), New Point(CInt(Me.Parent.ClientRectangle.Width / 2 - Me.Width / 2), CInt(Me.Parent.ClientRectangle.Height / 2 - Me.Height / 2)))
                frmGen.Show()
            Case "vw_SIDES"
                Dim frmEpendisis As frmEpendisis = New frmEpendisis
                frmEpendisis.Text = "Επενδύσης - Καταφραγές"
                frmEpendisis.MdiParent = frmMain
                frmEpendisis.ID = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "ID").ToString
                frmEpendisis.Mode = FormMode.EditRecord
                frmEpendisis.Scroller = GridView1
                frmEpendisis.FormScroller = Me
                frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(frmEpendisis), New Point(CInt(Me.Parent.ClientRectangle.Width / 2 - Me.Width / 2), CInt(Me.Parent.ClientRectangle.Height / 2 - Me.Height / 2)))
                frmEpendisis.Show()
            Case "vw_OFF"
                Dim frmoffer As frmOffer = New frmOffer
                frmoffer.Text = "Προσφορές"
                frmoffer.MdiParent = frmMain
                frmoffer.ID = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "ID").ToString
                frmoffer.Mode = FormMode.EditRecord
                frmoffer.Scroller = GridView1
                frmoffer.FormScroller = Me
                frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(frmoffer), New Point(CInt(Me.Parent.ClientRectangle.Width / 2 - Me.Width / 2), CInt(Me.Parent.ClientRectangle.Height / 2 - Me.Height / 2)))
                frmoffer.Show()
            Case "vw_COLORS"
                Dim frmColors As frmColors = New frmColors
                frmColors.Text = "Χρώματα"
                frmColors.MdiParent = frmMain
                frmColors.ID = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "ID").ToString
                frmColors.Mode = FormMode.EditRecord
                frmColors.Scroller = GridView1
                frmColors.FormScroller = Me
                frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(frmColors), New Point(CInt(Me.Parent.ClientRectangle.Width / 2 - Me.Width / 2), CInt(Me.Parent.ClientRectangle.Height / 2 - Me.Height / 2)))
                frmColors.Show()
            Case "vw_TECH_SUP"
                Dim fTechicalSupport As frmTecnicalSupport = New frmTecnicalSupport()
                fTechicalSupport.Text = "Διαχείριση Τεχνικής Υποστήριξης"
                fTechicalSupport.ID = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "ID").ToString
                fTechicalSupport.MdiParent = frmMain
                fTechicalSupport.Mode = FormMode.EditRecord
                fTechicalSupport.Scroller = GridView1
                fTechicalSupport.FormScroller = Me
                frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(fTechicalSupport), New Point(CInt(Me.Parent.ClientRectangle.Width / 2 - Me.Width / 2), CInt(Me.Parent.ClientRectangle.Height / 2 - Me.Height / 2)))
                fTechicalSupport.Show()
            Case "vw_RIGHTS"
                Dim frmPermissions As frmPermissions = New frmPermissions()
                frmPermissions.Text = "Δικαιώματα"
                frmPermissions.ID = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "ID").ToString
                frmPermissions.MdiParent = frmMain
                frmPermissions.Mode = FormMode.EditRecord
                frmPermissions.Scroller = GridView1
                frmPermissions.FormScroller = Me
                frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(frmPermissions), New Point(CInt(Me.Parent.ClientRectangle.Width / 2 - Me.Width / 2), CInt(Me.Parent.ClientRectangle.Height / 2 - Me.Height / 2)))
                frmPermissions.Show()
            Case "vw_USR"
                Dim frmUsers As frmUsers = New frmUsers()
                frmUsers.Text = "Διαχείριση Χρηστών"
                frmUsers.ID = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "ID").ToString
                frmUsers.MdiParent = frmMain
                frmUsers.Mode = FormMode.EditRecord
                frmUsers.Scroller = GridView1
                frmUsers.FormScroller = Me
                frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(frmUsers), New Point(CInt(Me.Parent.ClientRectangle.Width / 2 - Me.Width / 2), CInt(Me.Parent.ClientRectangle.Height / 2 - Me.Height / 2)))
                frmUsers.Show()
            Case "vw_MAILS"
                Dim frmMailSettings As frmMailSettings = New frmMailSettings()
                frmMailSettings.Text = "Email Settings"
                frmMailSettings.ID = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "ID").ToString
                frmMailSettings.MdiParent = frmMain
                frmMailSettings.Mode = FormMode.EditRecord
                frmMailSettings.Scroller = GridView1
                frmMailSettings.FormScroller = Me
                frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(frmMailSettings), New Point(CInt(Me.Parent.ClientRectangle.Width / 2 - Me.Width / 2), CInt(Me.Parent.ClientRectangle.Height / 2 - Me.Height / 2)))
                frmMailSettings.Show()
            Case "vw_STATUS"
                frmGen.Text = "Status"
                frmGen.ID = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "ID").ToString
                frmGen.MdiParent = frmMain
                frmGen.Mode = FormMode.EditRecord
                frmGen.Scroller = GridView1
                frmGen.FormScroller = Me
                frmGen.DataTable = "STATUS"
                frmGen.L1.Text = "Κωδικός"
                frmGen.L2.Text = "Status"
                frmGen.L6.Text = "Χρώμα"
                frmGen.chk1.Text = "Επιτρέπονται ειδοποιήσεις"
                frmGen.chk1.Visible = True
                frmGen.chk2.Text = "Υποχρεωτικότητα Πωλητή"
                frmGen.chk2.Visible = True
                frmGen.chk3.Text = "Υποχρεωτικότητα Πωλητή"
                frmGen.chk3.Visible = True
                frmGen.L10.Control.Tag = "RequiredSaler,0,1,2"
                frmGen.chk4.Text = "Υποχρεωτικότητα Διεύθυνσης"
                frmGen.chk4.Visible = True
                frmGen.L11.Control.Tag = "RequiredCounter,0,1,2"
                frmGen.L12.Control.Tag = "RequiredAddress,0,1,2"
                frmGen.L12.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
                frmGen.L11.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
                frmGen.L5.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
                frmGen.L10.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
                frmGen.FormScroller = Me
                frmGen.CalledFromControl = False
                frmGen.L6.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
                frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(frmGen), New Point(CInt(Me.Parent.ClientRectangle.Width / 2 - Me.Width / 2), CInt(Me.Parent.ClientRectangle.Height / 2 - Me.Height / 2)))
                frmGen.Show()
            Case "vw_SOURCE"
                frmGen.Text = "Πηγές"
                frmGen.MdiParent = frmMain
                frmGen.ID = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "ID").ToString
                frmGen.Mode = FormMode.EditRecord
                frmGen.Scroller = GridView1
                frmGen.FormScroller = Me
                frmGen.DataTable = "SRC"
                frmGen.L1.Text = "Κωδικός"
                frmGen.L2.Text = "Πηγή"
                frmGen.FormScroller = Me
                frmGen.CalledFromControl = False
                frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(frmGen), New Point(CInt(Me.Parent.ClientRectangle.Width / 2 - Me.Width / 2), CInt(Me.Parent.ClientRectangle.Height / 2 - Me.Height / 2)))
                frmGen.Show()
            Case "vw_CCT"
                Dim frmCustomers As frmCustomers = New frmCustomers()
                frmCustomers.Text = "Πελάτες"
                frmCustomers.ID = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "ID").ToString
                frmCustomers.MdiParent = frmMain
                frmCustomers.Mode = FormMode.EditRecord
                frmCustomers.Scroller = GridView1
                frmCustomers.FormScroller = Me
                frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(frmCustomers), New Point(CInt(Me.Parent.ClientRectangle.Width / 2 - Me.Width / 2), CInt(Me.Parent.ClientRectangle.Height / 2 - Me.Height / 2)))
                frmCustomers.Show()
            Case "vw_COU"
                frmGen.Text = "Νομοί"
                frmGen.ID = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "ID").ToString
                frmGen.MdiParent = frmMain
                frmGen.Mode = FormMode.EditRecord
                frmGen.Scroller = GridView1
                frmGen.FormScroller = Me
                frmGen.DataTable = "COU"
                frmGen.L1.Text = "Κωδικός"
                frmGen.L2.Text = "Νομός"
                frmGen.FormScroller = Me
                frmGen.CalledFromControl = False
                frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(frmGen), New Point(CInt(Me.Parent.ClientRectangle.Width / 2 - Me.Width / 2), CInt(Me.Parent.ClientRectangle.Height / 2 - Me.Height / 2)))
                frmGen.Show()
            Case "vw_AREAS"
                frmGen.Text = "Περιοχές"
                frmGen.ID = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "ID").ToString
                frmGen.MdiParent = frmMain
                frmGen.Mode = FormMode.EditRecord
                frmGen.Scroller = GridView1
                frmGen.DataTable = "AREAS"
                frmGen.L1.Text = "Κωδικός"
                frmGen.L2.Text = "Περιοχή"
                frmGen.L3.Text = "Νομός"
                frmGen.FormScroller = Me
                frmGen.CalledFromControl = False
                frmGen.L3.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
                frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(frmGen), New Point(CInt(Me.Parent.ClientRectangle.Width / 2 - Me.Width / 2), CInt(Me.Parent.ClientRectangle.Height / 2 - Me.Height / 2)))
                frmGen.Show()
            Case "vw_ADR"
                frmGen.Text = "Διευθύνσεις"
                frmGen.ID = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "ID").ToString
                frmGen.MdiParent = frmMain
                frmGen.Mode = FormMode.EditRecord
                frmGen.Scroller = GridView1
                frmGen.DataTable = "ADR"
                frmGen.L1.Text = "Κωδικός"
                frmGen.L2.Text = "Διεύθυνση"
                frmGen.L3.Text = "Νομός"
                frmGen.L4.Text = "Περιοχές"
                frmGen.L8.Text = "Αριθμός"
                frmGen.FormScroller = Me
                frmGen.CalledFromControl = False
                frmGen.L3.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
                frmGen.L4.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
                frmGen.L8.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
                frmGen.L8.Control.Tag = "Ar,0,1,2"
                frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(frmGen), New Point(CInt(Me.Parent.ClientRectangle.Width / 2 - Me.Width / 2), CInt(Me.Parent.ClientRectangle.Height / 2 - Me.Height / 2)))
                frmGen.Show()
            Case "vw_DOY"
                frmGen.Text = "ΔΟΥ"
                frmGen.MdiParent = frmMain
                frmGen.ID = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "ID").ToString
                frmGen.Mode = FormMode.EditRecord
                frmGen.Scroller = GridView1
                frmGen.DataTable = "DOY"
                frmGen.L1.Text = "Κωδικός"
                frmGen.L2.Text = "ΔΟΥ"
                frmGen.FormScroller = Me
                frmGen.CalledFromControl = False
                frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(frmGen), New Point(CInt(Me.Parent.ClientRectangle.Width / 2 - Me.Width / 2), CInt(Me.Parent.ClientRectangle.Height / 2 - Me.Height / 2)))
                frmGen.Show()
            Case "vw_PRF"
                frmGen.Text = "Επαγγέλματα"
                frmGen.MdiParent = frmMain
                frmGen.ID = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "ID").ToString
                frmGen.Mode = FormMode.EditRecord
                frmGen.Scroller = GridView1
                frmGen.DataTable = "PRF"
                frmGen.L1.Text = "Κωδικός"
                frmGen.L2.Text = "Επάγγελμα"
                frmGen.FormScroller = Me
                frmGen.CalledFromControl = False
                frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(frmGen), New Point(CInt(Me.Parent.ClientRectangle.Width / 2 - Me.Width / 2), CInt(Me.Parent.ClientRectangle.Height / 2 - Me.Height / 2)))
                frmGen.Show()
            Case "vw_SALERS"
                frmGen.Text = "Πωλητές"
                frmGen.ID = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "ID").ToString
                frmGen.MdiParent = frmMain
                frmGen.Mode = FormMode.EditRecord
                frmGen.Scroller = GridView1
                frmGen.DataTable = "SALERS"
                frmGen.L1.Text = "Κωδικός"
                frmGen.L2.Text = "Πωλητής"
                frmGen.L6.Text = "Χρώμα"
                frmGen.L8.Text = "Αρ. Πρωτοκόλου"
                frmGen.L9.Text = "Ποσοστό κέρδους"
                frmGen.L9.Control.Tag = "profitPerc,0,1,2"
                Dim profitPerc As DevExpress.XtraEditors.TextEdit = TryCast(frmGen.L9.Control, DevExpress.XtraEditors.TextEdit)
                profitPerc.Properties.EditFormat.FormatString = "n0"
                profitPerc.Properties.EditFormat.FormatType = FormatType.Numeric
                profitPerc.Properties.MaskSettings.MaskExpression = "n0"
                profitPerc.Properties.Mask.MaskType = Mask.MaskType.Numeric
                profitPerc.Properties.UseMaskAsDisplayFormat = True

                frmGen.FormScroller = Me
                frmGen.CalledFromControl = False
                frmGen.L9.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
                frmGen.L8.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
                frmGen.L6.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
                frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(frmGen), New Point(CInt(Me.Parent.ClientRectangle.Width / 2 - Me.Width / 2), CInt(Me.Parent.ClientRectangle.Height / 2 - Me.Height / 2)))
                frmGen.Show()
            Case "vw_CCT_M"
                Dim frmCusMov As frmCusMov = New frmCusMov()
                frmCusMov.Text = "Κινήσεις Πελατών"
                frmCusMov.ID = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "ID").ToString
                frmCusMov.MdiParent = frmMain
                frmCusMov.Mode = FormMode.EditRecord
                frmCusMov.Scroller = GridView1
                frmCusMov.FormScroller = Me
                frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(frmCusMov), New Point(CInt(Me.Parent.ClientRectangle.Width / 2 - Me.Width / 2), CInt(Me.Parent.ClientRectangle.Height / 2 - Me.Height / 2)))
                frmCusMov.Show()
            Case "vw_NOTES_L"
                frmGen.Text = "Εττικέτες"
                frmGen.ID = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "ID").ToString
                frmGen.MdiParent = frmMain
                frmGen.Mode = FormMode.EditRecord
                frmGen.Scroller = GridView1
                frmGen.DataTable = "NOTES_L"
                frmGen.L1.Text = "Κωδικός"
                frmGen.L2.Text = "Εττικέτα"
                frmGen.FormScroller = Me
                frmGen.CalledFromControl = False
                frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(frmGen), New Point(CInt(Me.Parent.ClientRectangle.Width / 2 - Me.Width / 2), CInt(Me.Parent.ClientRectangle.Height / 2 - Me.Height / 2)))
                frmGen.Show()
            Case "vw_DOOR_TYPE"
                Dim frmDoorType As frmDoorType = New frmDoorType
                frmDoorType.Text = "Κατηγορία Πόρτας"
                frmDoorType.ID = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "ID").ToString
                frmDoorType.MdiParent = frmMain
                frmDoorType.Mode = FormMode.EditRecord
                frmDoorType.Scroller = GridView1
                frmDoorType.FormScroller = Me
                frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(frmDoorType), New Point(CInt(Me.Parent.ClientRectangle.Width / 2 - Me.Width / 2), CInt(Me.Parent.ClientRectangle.Height / 2 - Me.Height / 2)))
                frmDoorType.Show()

            Case "vw_CAT_ERM"
                frmGen.Text = "Κατηγορίες Ερμαριών"
                frmGen.MdiParent = frmMain
                frmGen.ID = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "ID").ToString
                frmGen.Mode = FormMode.EditRecord
                frmGen.Scroller = GridView1
                frmGen.DataTable = "CAT_ERM"
                frmGen.L1.Text = "Κωδικός"
                frmGen.L2.Text = "Κατηγορίες Ερμαρίων"
                frmGen.FormScroller = Me
                frmGen.CalledFromControl = False
                frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(frmGen), New Point(CInt(Me.Parent.ClientRectangle.Width / 2 - Me.Width / 2), CInt(Me.Parent.ClientRectangle.Height / 2 - Me.Height / 2)))
                frmGen.Show()
            Case "vw_ERM"
                Dim frmErmaria As frmErmaria = New frmErmaria
                frmErmaria.Text = "Ερμάρια"
                frmErmaria.ID = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "ID").ToString
                frmErmaria.MdiParent = frmMain
                frmErmaria.Mode = FormMode.EditRecord
                frmErmaria.Scroller = GridView1
                frmErmaria.FormScroller = Me
                frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(frmErmaria), New Point(CInt(Me.Parent.ClientRectangle.Width / 2 - Me.Width / 2), CInt(Me.Parent.ClientRectangle.Height / 2 - Me.Height / 2)))
                frmErmaria.Show()
            Case "vw_BENCH"
                Dim frmBench As frmBench = New frmBench
                frmBench.Text = "Πάγκοι"
                frmBench.ID = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "ID").ToString
                frmBench.MdiParent = frmMain
                frmBench.Mode = FormMode.EditRecord
                frmBench.Scroller = GridView1
                frmBench.FormScroller = Me
                frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(frmBench), New Point(CInt(Me.Parent.ClientRectangle.Width / 2 - Me.Width / 2), CInt(Me.Parent.ClientRectangle.Height / 2 - Me.Height / 2)))
                frmBench.Show()
            Case "vw_MECH"
                frmGen.Text = "Μηχανισμοί"
                frmGen.ID = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "ID").ToString
                frmGen.MdiParent = frmMain
                frmGen.Mode = FormMode.EditRecord
                frmGen.Scroller = GridView1
                frmGen.FormScroller = Me
                frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(frmGen), New Point(CInt(Me.Parent.ClientRectangle.Width / 2 - Me.Width / 2), CInt(Me.Parent.ClientRectangle.Height / 2 - Me.Height / 2)))
                frmGen.Show()
            Case "vw_TECH_CAT"
                frmGen.Text = "Κατηγορίες Τεχνικής Υποστήριξης"
                frmGen.MdiParent = frmMain
                frmGen.ID = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "ID").ToString
                frmGen.Mode = FormMode.EditRecord
                frmGen.Scroller = GridView1
                frmGen.DataTable = "TECH_CAT"
                frmGen.L1.Text = "Κωδικός"
                frmGen.L2.Text = "Κατηγορία"
                frmGen.FormScroller = Me
                frmGen.CalledFromControl = False
                frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(frmGen), New Point(CInt(Me.Parent.ClientRectangle.Width / 2 - Me.Width / 2), CInt(Me.Parent.ClientRectangle.Height / 2 - Me.Height / 2)))
                frmGen.Show()
            Case "vw_COLORS_CAT"
                frmGen.Text = "Κατηγορίες Χρωμάτων"
                frmGen.MdiParent = frmMain
                frmGen.ID = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "ID").ToString
                frmGen.Mode = FormMode.EditRecord
                frmGen.Scroller = GridView1
                frmGen.DataTable = "COLORS_CAT"
                frmGen.L1.Text = "Κωδικός"
                frmGen.L2.Text = "Κατηγορίες Χρωμάτων"
                frmGen.FormScroller = Me
                frmGen.CalledFromControl = False
                frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(frmGen), New Point(CInt(Me.Parent.ClientRectangle.Width / 2 - Me.Width / 2), CInt(Me.Parent.ClientRectangle.Height / 2 - Me.Height / 2)))
                frmGen.Show()

        End Select
    End Sub
    'Νέα Εγγραφή
    Private Sub NewRecord()
        Dim frmGen As frmGen = New frmGen()
        Select Case sDataTable
            Case "vw_DMVER"
                Dim frmVersions As frmVersions = New frmVersions()
                frmVersions.Text = "Εκδόσεις"
                frmVersions.MdiParent = frmMain
                frmVersions.Mode = FormMode.NewRecord
                frmVersions.Scroller = GridView1
                frmVersions.FormScroller = Me
                frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(frmVersions), New Point(CInt(Me.Parent.ClientRectangle.Width / 2 - Me.Width / 2), CInt(Me.Parent.ClientRectangle.Height / 2 - Me.Height / 2)))
                frmVersions.Show()
            Case "vw_TRANSCOST"
                Dim frmTransCost As frmTransCost = New frmTransCost()
                frmTransCost.Text = "Κοστολόγηση Έργων"
                frmTransCost.MdiParent = frmMain
                frmTransCost.Mode = FormMode.NewRecord
                frmTransCost.Scroller = GridView1
                frmTransCost.FormScroller = Me
                frmTransCost.FormScrollerExist = True
                frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(frmTransCost), New Point(CInt(Me.Parent.ClientRectangle.Width / 2 - Me.Width / 2), CInt(Me.Parent.ClientRectangle.Height / 2 - Me.Height / 2)))
                frmTransCost.Show()
            Case "vw_EP_STATUS"
                frmGen.Text = "Status Εποπτείας"
                frmGen.MdiParent = frmMain
                frmGen.Mode = FormMode.NewRecord
                frmGen.Scroller = GridView1
                frmGen.FormScroller = Me
                frmGen.DataTable = "EP_STATUS"
                frmGen.L1.Text = "Κωδικός"
                frmGen.L2.Text = "Status"
                frmGen.L8.Text = "Χρονική Διάρκεια(Μέρες)"
                frmGen.L8.Control.Tag = "period,0,1,2"
                frmGen.L8.Tag = ""
                frmGen.L8.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
                frmGen.FormScroller = Me
                frmGen.CalledFromControl = False
                frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(frmGen), New Point(CInt(Me.Parent.ClientRectangle.Width / 2 - Me.Width / 2), CInt(Me.Parent.ClientRectangle.Height / 2 - Me.Height / 2)))
                frmGen.Show()
            Case "vw_TRANS_CONSTR"
                Dim frmTransConstr As frmTransConstr = New frmTransConstr()
                frmTransConstr.Text = "Κλείσιμο Κατασκευής"
                frmTransConstr.MdiParent = frmMain
                frmTransConstr.Mode = FormMode.NewRecord
                frmTransConstr.Scroller = GridView1
                frmTransConstr.FormScroller = Me
                frmTransConstr.FormScrollerExist = True
                frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(frmTransConstr), New Point(CInt(Me.Parent.ClientRectangle.Width / 2 - Me.Width / 2), CInt(Me.Parent.ClientRectangle.Height / 2 - Me.Height / 2)))
                frmTransConstr.Show()
            Case "vw_SUP_ORDERS"
                Dim frmSUPOrders As frmSUPOrders = New frmSUPOrders()
                frmSUPOrders.Text = "Παραγγελίες Προμηθευτών"
                frmSUPOrders.MdiParent = frmMain
                frmSUPOrders.Mode = FormMode.NewRecord
                frmSUPOrders.Scroller = GridView1
                frmSUPOrders.FormScroller = Me
                frmSUPOrders.FormScrollerExist = True
                frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(frmSUPOrders), New Point(CInt(Me.Parent.ClientRectangle.Width / 2 - Me.Width / 2), CInt(Me.Parent.ClientRectangle.Height / 2 - Me.Height / 2)))
                frmSUPOrders.Show()
            Case "vw_AGREEMENT"
                Dim frmPrivateAgreement As frmCUSPrivateAgreement = New frmCUSPrivateAgreement()
                frmPrivateAgreement.Text = "Ιδ. Συμφωνητικό"
                frmPrivateAgreement.MdiParent = frmMain
                frmPrivateAgreement.Mode = FormMode.NewRecord
                frmPrivateAgreement.Scroller = GridView1
                frmPrivateAgreement.FormScroller = Me
                frmPrivateAgreement.FormScrollerExist = True
                frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(frmPrivateAgreement), New Point(CInt(Me.Parent.ClientRectangle.Width / 2 - Me.Width / 2), CInt(Me.Parent.ClientRectangle.Height / 2 - Me.Height / 2)))
                frmPrivateAgreement.Show()
            Case "vw_CCT_ORDERS_CLOSET"
                Dim frmCUSOrderCloset As frmCUSOrderCloset = New frmCUSOrderCloset()
                frmCUSOrderCloset.Text = "Έντυπο Παραγγελίας Πελατών(Ντουλάπα)"
                frmCUSOrderCloset.MdiParent = frmMain
                frmCUSOrderCloset.Mode = FormMode.NewRecord
                frmCUSOrderCloset.Scroller = GridView1
                frmCUSOrderCloset.FormScroller = Me
                frmCUSOrderCloset.FormScrollerExist = True
                frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(frmCUSOrderCloset), New Point(CInt(Me.Parent.ClientRectangle.Width / 2 - Me.Width / 2), CInt(Me.Parent.ClientRectangle.Height / 2 - Me.Height / 2)))
                frmCUSOrderCloset.Show()
            Case "vw_CCT_ORDERS_KITCHEN"
                Dim frmCUSOrderKitchen As frmCUSOrderKitchen = New frmCUSOrderKitchen()
                frmCUSOrderKitchen.Text = "Έντυπο Παραγγελίας Πελατών(Κουζίνα)"
                frmCUSOrderKitchen.MdiParent = frmMain
                frmCUSOrderKitchen.Mode = FormMode.NewRecord
                frmCUSOrderKitchen.Scroller = GridView1
                frmCUSOrderKitchen.FormScroller = Me
                frmCUSOrderKitchen.FormScrollerExist = True
                frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(frmCUSOrderKitchen), New Point(CInt(Me.Parent.ClientRectangle.Width / 2 - Me.Width / 2), CInt(Me.Parent.ClientRectangle.Height / 2 - Me.Height / 2)))
                frmCUSOrderKitchen.Show()
            Case "vw_CCT_ORDERS_SPECIAL_CONSTR"
                Dim frmCUSOfferSpecialConstr As frmCUSOfferOrderSpecialConstr = New frmCUSOfferOrderSpecialConstr()
                frmCUSOfferSpecialConstr.Text = "Έντυπο Παραγγελίας Πελατών(Έπιπλο Μπάνιου)"
                frmCUSOfferSpecialConstr.MdiParent = frmMain
                frmCUSOfferSpecialConstr.IsOrder = True
                frmCUSOfferSpecialConstr.Mode = FormMode.NewRecord
                frmCUSOfferSpecialConstr.Scroller = GridView1
                frmCUSOfferSpecialConstr.FormScroller = Me
                frmCUSOfferSpecialConstr.FormScrollerExist = True
                frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(frmCUSOfferSpecialConstr), New Point(CInt(Me.Parent.ClientRectangle.Width / 2 - Me.Width / 2), CInt(Me.Parent.ClientRectangle.Height / 2 - Me.Height / 2)))
                frmCUSOfferSpecialConstr.Show()
            Case "vw_CCT_OFFERS_SPECIAL_CONSTR"
                Dim frmCUSOfferSpecialConstr As frmCUSOfferOrderSpecialConstr = New frmCUSOfferOrderSpecialConstr()
                frmCUSOfferSpecialConstr.Text = "Έντυπο Προσφοράς Πελατών(Έπιπλο Μπάνιου)"
                frmCUSOfferSpecialConstr.IsOrder = False
                frmCUSOfferSpecialConstr.MdiParent = frmMain
                frmCUSOfferSpecialConstr.Mode = FormMode.NewRecord
                frmCUSOfferSpecialConstr.Scroller = GridView1
                frmCUSOfferSpecialConstr.FormScroller = Me
                frmCUSOfferSpecialConstr.FormScrollerExist = True
                frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(frmCUSOfferSpecialConstr), New Point(CInt(Me.Parent.ClientRectangle.Width / 2 - Me.Width / 2), CInt(Me.Parent.ClientRectangle.Height / 2 - Me.Height / 2)))
                frmCUSOfferSpecialConstr.Show()
            Case "vw_CCT_OFFERS_DOOR", "vw_CCT_ORDERS_DOOR"
                Dim frmCUSOfferOrderDoors As frmCUSOfferOrderDoors = New frmCUSOfferOrderDoors()
                If sDataTable = "vw_CCT_OFFERS_DOOR" Then
                    frmCUSOfferOrderDoors.Text = "Έντυπο Προσφοράς Πελατών(Πόρτες)"
                    frmCUSOfferOrderDoors.IsOrder = False
                Else
                    frmCUSOfferOrderDoors.Text = "Έντυπο Παραγγελίας Πελατών(Πόρτες)"
                    frmCUSOfferOrderDoors.IsOrder = True
                End If
                frmCUSOfferOrderDoors.MdiParent = frmMain
                frmCUSOfferOrderDoors.Mode = FormMode.NewRecord
                frmCUSOfferOrderDoors.Scroller = GridView1
                frmCUSOfferOrderDoors.FormScroller = Me
                frmCUSOfferOrderDoors.FormScrollerExist = True
                frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(frmCUSOfferOrderDoors), New Point(CInt(Me.Parent.ClientRectangle.Width / 2 - Me.Width / 2), CInt(Me.Parent.ClientRectangle.Height / 2 - Me.Height / 2)))
                frmCUSOfferOrderDoors.Show()
            Case "vw_CCT_OFFERS_CLOSET"
                Dim frmCUSOfferCloset As frmCUSOfferCloset = New frmCUSOfferCloset()
                frmCUSOfferCloset.Text = "Έντυπο Προσφοράς Πελατών(Ντουλάπες)"
                frmCUSOfferCloset.MdiParent = frmMain
                frmCUSOfferCloset.Mode = FormMode.NewRecord
                frmCUSOfferCloset.Scroller = GridView1
                frmCUSOfferCloset.FormScroller = Me
                frmCUSOfferCloset.FormScrollerExist = True
                frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(frmCUSOfferCloset), New Point(CInt(Me.Parent.ClientRectangle.Width / 2 - Me.Width / 2), CInt(Me.Parent.ClientRectangle.Height / 2 - Me.Height / 2)))
                frmCUSOfferCloset.Show()
            Case "vw_CCT_OFFERS"
                Dim frmCUSOffer As frmCUSOfferKitchen = New frmCUSOfferKitchen()
                frmCUSOffer.Text = "Έντυπο Προσφοράς Πελατών"
                frmCUSOffer.MdiParent = frmMain
                frmCUSOffer.Mode = FormMode.NewRecord
                frmCUSOffer.Scroller = GridView1
                frmCUSOffer.FormScroller = Me
                frmCUSOffer.FormScrollerExist = True
                frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(frmCUSOffer), New Point(CInt(Me.Parent.ClientRectangle.Width / 2 - Me.Width / 2), CInt(Me.Parent.ClientRectangle.Height / 2 - Me.Height / 2)))
                frmCUSOffer.Show()
            Case "vw_SUP_PAYMENTS_H"
                Dim frmSUPKal As frmSUPKal = New frmSUPKal()
                frmSUPKal.Text = "Πληρωμές Παραστατικών Προμηθευτών"
                frmSUPKal.MdiParent = frmMain
                frmSUPKal.Mode = FormMode.NewRecord
                frmSUPKal.Scroller = GridView1
                frmSUPKal.FormScroller = Me
                frmSUPKal.FormScrollerExist = True
                frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(frmSUPKal), New Point(CInt(frmSUPKal.Parent.ClientRectangle.Width / 2 - frmSUPKal.Width / 2), CInt(frmSUPKal.Parent.ClientRectangle.Height / 2 - Me.Height / 2)))
                frmSUPKal.Show()
            Case "vw_BUY"
                Dim frmBUY As frmBUY = New frmBUY()
                frmBUY.Text = "Αγορές"
                frmBUY.MdiParent = frmMain
                frmBUY.Mode = FormMode.NewRecord
                frmBUY.Scroller = GridView1
                frmBUY.FormScroller = Me
                frmBUY.FormScrollerExist = True
                frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(frmBUY), New Point(CInt(Me.Parent.ClientRectangle.Width / 2 - Me.Width / 2), CInt(Me.Parent.ClientRectangle.Height / 2 - Me.Height / 2)))
                frmBUY.Show()
            Case "vw_EQUIPMENT"
                frmGen.Text = "Εξοπλισμός"
                frmGen.MdiParent = frmMain
                frmGen.Mode = FormMode.NewRecord
                frmGen.Scroller = GridView1
                frmGen.FormScroller = Me
                frmGen.DataTable = "EQUIPMENT"
                frmGen.L1.Text = "Κωδικός"
                frmGen.L2.Text = "Όνομα"
                frmGen.L3.Text = "Κατηγορία"
                frmGen.L3.Control.Tag = "equipmentCatID,0,1,2"
                frmGen.L3.Tag = ""
                frmGen.L3.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
                frmGen.L13.Text = "Τιμή"
                frmGen.L13.Control.Tag = "price,0,1,2"
                frmGen.L13.Tag = ""
                frmGen.L13.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
                frmGen.FormScroller = Me
                frmGen.CalledFromControl = False
                frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(frmGen), New Point(CInt(Me.Parent.ClientRectangle.Width / 2 - Me.Width / 2), CInt(Me.Parent.ClientRectangle.Height / 2 - Me.Height / 2)))
                frmGen.Show()
            Case "vw_EQUIPMENT_CAT"
                frmGen.Text = "Κατηγορίες Εξαρτημάτων"
                frmGen.MdiParent = frmMain
                frmGen.Mode = FormMode.NewRecord
                frmGen.Scroller = GridView1
                frmGen.FormScroller = Me
                frmGen.DataTable = "EQUIPMENT_CAT"
                frmGen.L1.Text = "Κωδικός"
                frmGen.L2.Text = "Όνομα"
                frmGen.FormScroller = Me
                frmGen.CalledFromControl = False
                frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(frmGen), New Point(CInt(Me.Parent.ClientRectangle.Width / 2 - Me.Width / 2), CInt(Me.Parent.ClientRectangle.Height / 2 - Me.Height / 2)))
                frmGen.Show()
            Case "vw_DEVICES"
                frmGen.Text = "Συσκευές"
                frmGen.MdiParent = frmMain
                frmGen.Mode = FormMode.NewRecord
                frmGen.Scroller = GridView1
                frmGen.FormScroller = Me
                frmGen.DataTable = "DEVICES"
                frmGen.L1.Text = "Κωδικός"
                frmGen.L2.Text = "Όνομα"
                frmGen.FormScroller = Me
                frmGen.CalledFromControl = False
                frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(frmGen), New Point(CInt(Me.Parent.ClientRectangle.Width / 2 - Me.Width / 2), CInt(Me.Parent.ClientRectangle.Height / 2 - Me.Height / 2)))
                frmGen.Show()
            Case "vw_BUY_C"
                frmGen.Text = "Κατηγορίες Αγορών"
                frmGen.MdiParent = frmMain
                frmGen.Mode = FormMode.NewRecord
                frmGen.Scroller = GridView1
                frmGen.FormScroller = Me
                frmGen.DataTable = "BUY_C"
                frmGen.L1.Text = "Κωδικός"
                frmGen.L2.Text = "Όνομα"
                frmGen.FormScroller = Me
                frmGen.CalledFromControl = False
                frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(frmGen), New Point(CInt(Me.Parent.ClientRectangle.Width / 2 - Me.Width / 2), CInt(Me.Parent.ClientRectangle.Height / 2 - Me.Height / 2)))
                frmGen.Show()
            Case "vw_SUP"
                Dim frmSUP As New frmSUP
                frmSUP.Text = "Προμηθευτές"
                frmSUP.MdiParent = frmMain
                frmSUP.Mode = FormMode.NewRecord
                frmSUP.Scroller = GridView1
                frmSUP.FormScroller = Me
                frmSUP.FormScrollerExist = True
                frmSUP.CalledFromControl = False
                frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(frmSUP), New Point(CInt(Me.Parent.ClientRectangle.Width / 2 - Me.Width / 2), CInt(Me.Parent.ClientRectangle.Height / 2 - Me.Height / 2)))
                frmSUP.Show()
            Case "vw_NOTES"
                Dim form1 As frmNotes = New frmNotes()
                form1.Text = "Σημειώματα"
                form1.MdiParent = frmMain
                form1.Mode = FormMode.NewRecord
                form1.Scroller2 = GridView1
                form1.FormScroller = Me
                frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(form1), New Point(CInt(Me.Parent.ClientRectangle.Width / 2 - Me.Width / 2), CInt(Me.Parent.ClientRectangle.Height / 2 - Me.Height / 2)))
                form1.Show()
            Case "vw_PROJECT_COST"
                Dim frmProjectCost As New frmProjectCost
                frmProjectCost.Text = "Ανάλυση Έργων"
                frmProjectCost.MdiParent = frmMain
                frmProjectCost.Mode = FormMode.NewRecord
                frmProjectCost.Scroller = GridView1
                frmProjectCost.FormScroller = Me
                frmProjectCost.CalledFromControl = False
                frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(frmProjectCost), New Point(CInt(Me.Parent.ClientRectangle.Width / 2 - Me.Width / 2), CInt(Me.Parent.ClientRectangle.Height / 2 - Me.Height / 2)))
                frmProjectCost.Show()
            Case "vw_SCAN_FILE_NAMES"
                frmGen.Text = "Ονομασίες Scan αρχείων"
                frmGen.MdiParent = frmMain
                frmGen.Mode = FormMode.NewRecord
                frmGen.Scroller = GridView1
                frmGen.FormScroller = Me
                frmGen.DataTable = "SCAN_FILE_NAMES"
                frmGen.L1.Text = "Κωδικός"
                frmGen.L2.Text = "Όνομα"
                frmGen.FormScroller = Me
                frmGen.CalledFromControl = False
                frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(frmGen), New Point(CInt(Me.Parent.ClientRectangle.Width / 2 - Me.Width / 2), CInt(Me.Parent.ClientRectangle.Height / 2 - Me.Height / 2)))
                frmGen.Show()
            Case "vw_JOBS"
                frmGen.Text = "Θέσεις Εργασίας"
                frmGen.MdiParent = frmMain
                frmGen.Mode = FormMode.NewRecord
                frmGen.Scroller = GridView1
                frmGen.FormScroller = Me
                frmGen.DataTable = "JOBS"
                frmGen.L1.Text = "Κωδικός"
                frmGen.L2.Text = "Θέση"
                frmGen.FormScroller = Me
                frmGen.CalledFromControl = False
                frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(frmGen), New Point(CInt(Me.Parent.ClientRectangle.Width / 2 - Me.Width / 2), CInt(Me.Parent.ClientRectangle.Height / 2 - Me.Height / 2)))
                frmGen.Show()
            Case "vw_PAY"
                frmGen.Text = "Τρόποι Πληρωμής"
                frmGen.MdiParent = frmMain
                frmGen.Mode = FormMode.NewRecord
                frmGen.Scroller = GridView1
                frmGen.FormScroller = Me
                frmGen.DataTable = "PAY"
                frmGen.L1.Text = "Κωδικός"
                frmGen.L2.Text = "Τρόπος Πληρωμής"
                frmGen.FormScroller = Me
                frmGen.CalledFromControl = False
                frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(frmGen), New Point(CInt(Me.Parent.ClientRectangle.Width / 2 - Me.Width / 2), CInt(Me.Parent.ClientRectangle.Height / 2 - Me.Height / 2)))
                frmGen.Show()
            Case "vw_CONSTR"
                Dim frmConstrunction As New frmConstrunction
                frmConstrunction.Text = "Μισθοδοσία Κατασκευαστικού"
                frmConstrunction.MdiParent = frmMain
                frmConstrunction.Mode = FormMode.NewRecord
                frmConstrunction.Scroller = GridView1
                frmConstrunction.FormScroller = Me
                frmConstrunction.CalledFromControl = False
                frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(frmConstrunction), New Point(CInt(Me.Parent.ClientRectangle.Width / 2 - Me.Width / 2), CInt(Me.Parent.ClientRectangle.Height / 2 - Me.Height / 2)))
                frmConstrunction.Show()
            Case "vw_INST_ELLIPSE"
                Dim frmInstEllipse As New frmInstEllipse
                frmInstEllipse.Text = "Ελλείψεις Τοποθετήσεων"
                frmInstEllipse.MdiParent = frmMain
                frmInstEllipse.Mode = FormMode.NewRecord
                frmInstEllipse.Scroller = GridView1
                frmInstEllipse.FormScroller = Me
                frmInstEllipse.CalledFromControl = False
                frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(frmInstEllipse), New Point(CInt(Me.Parent.ClientRectangle.Width / 2 - Me.Width / 2), CInt(Me.Parent.ClientRectangle.Height / 2 - Me.Height / 2)))
                frmInstEllipse.Show()
            Case "vw_EMP_T"
                Dim frmSalerTziroi As New frmSalerTziroi
                frmSalerTziroi.Text = "Τζίροι-Ποσοστά έκθεσης"
                frmSalerTziroi.MdiParent = frmMain
                frmSalerTziroi.Mode = FormMode.NewRecord
                frmSalerTziroi.Scroller = GridView1
                frmSalerTziroi.FormScroller = Me
                frmSalerTziroi.FormScrollerExist = True
                frmSalerTziroi.CalledFromControl = False
                frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(frmSalerTziroi), New Point(CInt(Me.Parent.ClientRectangle.Width / 2 - Me.Width / 2), CInt(Me.Parent.ClientRectangle.Height / 2 - Me.Height / 2)))
                frmSalerTziroi.Show()
            Case "vw_EMP_M"
                Dim frmEmpPayroll As New frmEmpPayroll
                frmEmpPayroll.Text = "Μισθοθοσία"
                frmEmpPayroll.IsConstr = bIsConstr
                frmEmpPayroll.MdiParent = frmMain
                frmEmpPayroll.Mode = FormMode.NewRecord
                frmEmpPayroll.Scroller = GridView1
                frmEmpPayroll.FormScroller = Me
                frmEmpPayroll.FormScrollerExist = True
                frmEmpPayroll.CalledFromControl = False
                frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(frmEmpPayroll), New Point(CInt(Me.Parent.ClientRectangle.Width / 2 - Me.Width / 2), CInt(Me.Parent.ClientRectangle.Height / 2 - Me.Height / 2)))
                frmEmpPayroll.Show()
            Case "vw_EMP_M_S"
                frmGen.Text = "Status Μισθοδοσίας"
                frmGen.MdiParent = frmMain
                frmGen.Mode = FormMode.NewRecord
                frmGen.Scroller = GridView1
                frmGen.FormScroller = Me
                frmGen.DataTable = "EMP_M_S"
                frmGen.L1.Text = "Κωδικός"
                frmGen.L2.Text = "Status"
                frmGen.FormScroller = Me
                frmGen.CalledFromControl = False
                frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(frmGen), New Point(CInt(Me.Parent.ClientRectangle.Width / 2 - Me.Width / 2), CInt(Me.Parent.ClientRectangle.Height / 2 - Me.Height / 2)))
                frmGen.Show()
            Case "vw_CONSTR_CAT"
                frmGen.Text = "Κατηγορίες Εργασιών"
                frmGen.MdiParent = frmMain
                frmGen.Mode = FormMode.NewRecord
                frmGen.Scroller = GridView1
                frmGen.FormScroller = Me
                frmGen.DataTable = "CONSTR_CAT"
                frmGen.L1.Text = "Κωδικός"
                frmGen.L2.Text = "Κατηγορία"
                frmGen.FormScroller = Me
                frmGen.CalledFromControl = False
                frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(frmGen), New Point(CInt(Me.Parent.ClientRectangle.Width / 2 - Me.Width / 2), CInt(Me.Parent.ClientRectangle.Height / 2 - Me.Height / 2)))
                frmGen.Show()
            Case "vw_CONSTR_TYPE"
                frmGen.Text = "Είδη Κατασκευής"
                frmGen.MdiParent = frmMain
                frmGen.Mode = FormMode.NewRecord
                frmGen.Scroller = GridView1
                frmGen.FormScroller = Me
                frmGen.DataTable = "CONSTR_TYPE"
                frmGen.L1.Text = "Κωδικός"
                frmGen.L2.Text = "Είδος"
                frmGen.FormScroller = Me
                frmGen.CalledFromControl = False
                frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(frmGen), New Point(CInt(Me.Parent.ClientRectangle.Width / 2 - Me.Width / 2), CInt(Me.Parent.ClientRectangle.Height / 2 - Me.Height / 2)))
                frmGen.Show()
            Case "vw_INST_M"
                Dim frmInstM As New frmInstM
                frmInstM.Text = "Χρεωπιστώσεις Τοποθετών"
                frmInstM.MdiParent = frmMain
                frmInstM.Mode = FormMode.NewRecord
                frmInstM.Scroller = GridView1
                frmInstM.FormScroller = Me
                frmInstM.CalledFromControl = False
                frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(frmInstM), New Point(CInt(Me.Parent.ClientRectangle.Width / 2 - Me.Width / 2), CInt(Me.Parent.ClientRectangle.Height / 2 - Me.Height / 2)))
                frmInstM.Show()
            Case "vw_EMP"
                Dim frmEMP As New frmEMP
                frmEMP.Text = "Διαχείριση Προσωπικού"
                frmEMP.MdiParent = frmMain
                frmEMP.Mode = FormMode.NewRecord
                frmEMP.Scroller = GridView1
                frmEMP.FormScroller = Me
                frmEMP.CalledFromControl = False
                frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(frmEMP), New Point(CInt(Me.Parent.ClientRectangle.Width / 2 - Me.Width / 2), CInt(Me.Parent.ClientRectangle.Height / 2 - Me.Height / 2)))
                frmEMP.Show()
            Case "vw_TRANSH"
                Dim frmTransactions As New frmTransactions
                frmTransactions.Text = "Χρεωπιστώσεις"
                frmTransactions.MdiParent = frmMain
                frmTransactions.Mode = FormMode.NewRecord
                frmTransactions.Scroller = GridView1
                frmTransactions.FormScroller = Me
                frmTransactions.CalledFromControl = False
                frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(frmTransactions), New Point(CInt(Me.Parent.ClientRectangle.Width / 2 - Me.Width / 2), CInt(Me.Parent.ClientRectangle.Height / 2 - Me.Height / 2)))
                frmTransactions.Show()
            Case "vw_BANKS"
                frmGen.Text = "Τράπεζες"
                frmGen.MdiParent = frmMain
                frmGen.Mode = FormMode.NewRecord
                frmGen.Scroller = GridView1
                frmGen.FormScroller = Me
                frmGen.DataTable = "BANKS"
                frmGen.L1.Text = "Κωδικός"
                frmGen.L2.Text = "Τράπεζα"
                frmGen.FormScroller = Me
                frmGen.CalledFromControl = False
                frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(frmGen), New Point(CInt(Me.Parent.ClientRectangle.Width / 2 - Me.Width / 2), CInt(Me.Parent.ClientRectangle.Height / 2 - Me.Height / 2)))
                frmGen.Show()
            Case "vw_DEP"
                frmGen.Text = "Τμήματα Εταιρίας"
                frmGen.MdiParent = frmMain
                frmGen.Mode = FormMode.NewRecord
                frmGen.Scroller = GridView1
                frmGen.FormScroller = Me
                frmGen.DataTable = "DEP"
                frmGen.L1.Text = "Κωδικός"
                frmGen.L2.Text = "Τμήμα"
                frmGen.FormScroller = Me
                frmGen.CalledFromControl = False
                frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(frmGen), New Point(CInt(Me.Parent.ClientRectangle.Width / 2 - Me.Width / 2), CInt(Me.Parent.ClientRectangle.Height / 2 - Me.Height / 2)))
                frmGen.Show()
            Case "vw_EMP_S"
                frmGen.Text = "Statuses Παρουσιολογίου"
                frmGen.MdiParent = frmMain
                frmGen.Mode = FormMode.NewRecord
                frmGen.Scroller = GridView1
                frmGen.FormScroller = Me
                frmGen.DataTable = "EMP_S"
                frmGen.L1.Text = "Κωδικός"
                frmGen.L2.Text = "Status"
                frmGen.L9.Control.Tag = "shortName,0,1,2"
                frmGen.L9.Text = "Συντομογραφία"
                frmGen.L6.Text = "Χρώμα"
                frmGen.FormScroller = Me
                frmGen.CalledFromControl = False
                frmGen.L6.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
                frmGen.L9.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
                frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(frmGen), New Point(CInt(Me.Parent.ClientRectangle.Width / 2 - Me.Width / 2), CInt(Me.Parent.ClientRectangle.Height / 2 - Me.Height / 2)))
                frmGen.Show()
            Case "vw_SALER_CAL_STATUS"
                frmGen.Text = "Status Προσωπικού Ημερολογίου"
                frmGen.MdiParent = frmMain
                frmGen.Mode = FormMode.NewRecord
                frmGen.Scroller = GridView1
                frmGen.FormScroller = Me
                frmGen.DataTable = "SALER_CAL_STATUS"
                frmGen.L1.Text = "Κωδικός"
                frmGen.L2.Text = "Status"
                frmGen.L6.Text = "Χρώμα"
                frmGen.FormScroller = Me
                frmGen.CalledFromControl = False
                frmGen.L6.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
                frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(frmGen), New Point(CInt(Me.Parent.ClientRectangle.Width / 2 - Me.Width / 2), CInt(Me.Parent.ClientRectangle.Height / 2 - Me.Height / 2)))
                frmGen.Show()
            Case "vw_INST"
                Dim frmInstallations As New frmInstallations
                frmInstallations.Text = "Μισθοδοσία Τοποθετών"
                frmInstallations.MdiParent = frmMain
                frmInstallations.Mode = FormMode.NewRecord
                frmInstallations.Scroller = GridView1
                frmInstallations.FormScroller = Me
                frmInstallations.CalledFromControl = False
                frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(frmInstallations), New Point(CInt(Me.Parent.ClientRectangle.Width / 2 - Me.Width / 2), CInt(Me.Parent.ClientRectangle.Height / 2 - Me.Height / 2)))
                frmInstallations.Show()
            Case "vw_SER"
                Dim frmServices As frmServices = New frmServices()
                frmServices.Text = "Συνεργεία"
                frmServices.MdiParent = frmMain
                frmServices.Mode = FormMode.NewRecord
                frmServices.Scroller = GridView1
                frmServices.FormScroller = Me
                frmServices.CalledFromControl = False
                frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(frmServices), New Point(CInt(Me.Parent.ClientRectangle.Width / 2 - Me.Width / 2), CInt(Me.Parent.ClientRectangle.Height / 2 - Me.Height / 2)))
                frmServices.Show()
            Case "vw_CAT_SUB_ERM"
                Dim frmCatSubErm As New frmCatSubErm
                frmCatSubErm.Text = "Υποκατηγορίες Ερμαρίων"
                frmCatSubErm.MdiParent = frmMain
                frmCatSubErm.Mode = FormMode.NewRecord
                frmCatSubErm.Scroller = GridView1
                frmCatSubErm.FormScroller = Me
                frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(frmCatSubErm), New Point(CInt(Me.Parent.ClientRectangle.Width / 2 - Me.Width / 2), CInt(Me.Parent.ClientRectangle.Height / 2 - Me.Height / 2)))
                frmCatSubErm.Show()
            Case "vw_CALC"
                Dim frmCalculations As frmCalculations = New frmCalculations()
                frmCalculations.Text = "Υπολογισμοί"
                frmCalculations.MdiParent = frmMain
                frmCalculations.Mode = FormMode.NewRecord
                frmCalculations.Scroller = GridView1
                frmCalculations.FormScroller = Me
                frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(frmCalculations), New Point(CInt(Me.Parent.ClientRectangle.Width / 2 - Me.Width / 2), CInt(Me.Parent.ClientRectangle.Height / 2 - Me.Height / 2)))
                frmCalculations.Show()
            Case "vw_DIM"
                frmGen.Text = "Διαστάσεις"
                frmGen.MdiParent = frmMain
                frmGen.Mode = FormMode.NewRecord
                frmGen.Scroller = GridView1
                frmGen.FormScroller = Me
                frmGen.DataTable = "DIM"
                frmGen.L1.Text = "Κωδικός"
                frmGen.L2.Text = "Διάσταση"
                frmGen.FormScroller = Me
                frmGen.CalledFromControl = False
                frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(frmGen), New Point(CInt(Me.Parent.ClientRectangle.Width / 2 - Me.Width / 2), CInt(Me.Parent.ClientRectangle.Height / 2 - Me.Height / 2)))
                frmGen.Show()
            Case "vw_DOOR_CAT"
                frmGen.Text = "Κατηγορίες Διαστάσεων"
                frmGen.MdiParent = frmMain
                frmGen.Mode = FormMode.NewRecord
                frmGen.Scroller = GridView1
                frmGen.FormScroller = Me
                frmGen.DataTable = "DOOR_CAT"
                frmGen.L1.Text = "Κωδικός"
                frmGen.L2.Text = "Κατηγορία"
                frmGen.FormScroller = Me
                frmGen.CalledFromControl = False
                frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(frmGen), New Point(CInt(Me.Parent.ClientRectangle.Width / 2 - Me.Width / 2), CInt(Me.Parent.ClientRectangle.Height / 2 - Me.Height / 2)))
                frmGen.Show()
            Case "vw_SIDES"
                Dim frmEpendisis As frmEpendisis = New frmEpendisis
                frmEpendisis.Text = "Επενδύσης - Καταφραγές"
                frmEpendisis.MdiParent = frmMain
                frmEpendisis.Mode = FormMode.NewRecord
                frmEpendisis.Scroller = GridView1
                frmEpendisis.FormScroller = Me
                frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(frmEpendisis), New Point(CInt(Me.Parent.ClientRectangle.Width / 2 - Me.Width / 2), CInt(Me.Parent.ClientRectangle.Height / 2 - Me.Height / 2)))
                frmEpendisis.Show()
            Case "vw_OFF"
                Dim frmOffer As frmOffer = New frmOffer
                frmOffer.Text = "Προσφορές"
                frmOffer.MdiParent = frmMain
                frmOffer.Mode = FormMode.NewRecord
                frmOffer.Scroller = GridView1
                frmOffer.FormScroller = Me
                frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(frmOffer), New Point(CInt(Me.Parent.ClientRectangle.Width / 2 - Me.Width / 2), CInt(Me.Parent.ClientRectangle.Height / 2 - Me.Height / 2)))
                frmOffer.Show()
            Case "vw_COLORS"
                Dim frmColors As frmColors = New frmColors
                frmColors.Text = "Χρώματα"
                frmColors.MdiParent = frmMain
                frmColors.Mode = FormMode.NewRecord
                frmColors.Scroller = GridView1
                frmColors.FormScroller = Me
                frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(frmColors), New Point(CInt(Me.Parent.ClientRectangle.Width / 2 - Me.Width / 2), CInt(Me.Parent.ClientRectangle.Height / 2 - Me.Height / 2)))
                frmColors.Show()
            Case "vw_TECH_SUP"
                Dim fTechicalSupport As frmTecnicalSupport = New frmTecnicalSupport()
                fTechicalSupport.Text = "Διαχείριση Τεχνικής Υποστήριξης"
                fTechicalSupport.MdiParent = frmMain
                fTechicalSupport.Mode = FormMode.NewRecord
                fTechicalSupport.Scroller = GridView1
                fTechicalSupport.FormScroller = Me
                frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(fTechicalSupport), New Point(CInt(Me.Parent.ClientRectangle.Width / 2 - Me.Width / 2), CInt(Me.Parent.ClientRectangle.Height / 2 - Me.Height / 2)))
                fTechicalSupport.Show()
            Case "vw_RIGHTS"
                Dim frmPermissions As frmPermissions = New frmPermissions()
                frmPermissions.Text = "Δικαιώματα"
                frmPermissions.MdiParent = frmMain
                frmPermissions.Mode = FormMode.NewRecord
                frmPermissions.Scroller = GridView1
                frmPermissions.FormScroller = Me
                frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(frmPermissions), New Point(CInt(Me.Parent.ClientRectangle.Width / 2 - Me.Width / 2), CInt(Me.Parent.ClientRectangle.Height / 2 - Me.Height / 2)))
                frmPermissions.Show()
            Case "vw_USR"
                Dim frmUsers As frmUsers = New frmUsers()
                frmUsers.Text = "Διαχείριση Χρηστών"
                frmUsers.MdiParent = frmMain
                frmUsers.Mode = FormMode.NewRecord
                frmUsers.Scroller = GridView1
                frmUsers.FormScroller = Me
                frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(frmUsers), New Point(CInt(Me.Parent.ClientRectangle.Width / 2 - Me.Width / 2), CInt(Me.Parent.ClientRectangle.Height / 2 - Me.Height / 2)))
                frmUsers.Show()
            Case "vw_MAILS"
                Dim frmMailSettings As frmMailSettings = New frmMailSettings()
                frmMailSettings.Text = "Email Settings"
                frmMailSettings.MdiParent = frmMain
                frmMailSettings.Mode = FormMode.NewRecord
                frmMailSettings.Scroller = GridView1
                frmMailSettings.FormScroller = Me
                frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(frmMailSettings), New Point(CInt(Me.Parent.ClientRectangle.Width / 2 - Me.Width / 2), CInt(Me.Parent.ClientRectangle.Height / 2 - Me.Height / 2)))
                frmMailSettings.Show()
            Case "vw_STATUS"
                frmGen.Text = "Status"
                frmGen.MdiParent = frmMain
                frmGen.Mode = FormMode.NewRecord
                frmGen.Scroller = GridView1
                frmGen.FormScroller = Me
                frmGen.DataTable = "STATUS"
                frmGen.L1.Text = "Κωδικός"
                frmGen.L2.Text = "Status"
                frmGen.L6.Text = "Χρώμα"
                frmGen.chk1.Text = "Επιτρέπονται ειδοποιήσεις"
                frmGen.chk1.Visible = True
                frmGen.chk2.Text = "Υποχρεωτικότητα Πωλητή"
                frmGen.chk2.Visible = True
                frmGen.chk3.Text = "Υποχρεωτικότητα Πωλητή"
                frmGen.chk3.Visible = True
                frmGen.L10.Control.Tag = "RequiredSaler,0,1,2"
                frmGen.chk4.Text = "Υποχρεωτικότητα Διεύθυνσης"
                frmGen.chk4.Visible = True
                frmGen.L11.Control.Tag = "RequiredCounter,0,1,2"
                frmGen.L12.Control.Tag = "RequiredAddress,0,1,2"
                frmGen.L12.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
                frmGen.L11.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
                frmGen.L5.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
                frmGen.L10.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
                frmGen.FormScroller = Me
                frmGen.CalledFromControl = False
                frmGen.L6.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
                frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(frmGen), New Point(CInt(Me.Parent.ClientRectangle.Width / 2 - Me.Width / 2), CInt(Me.Parent.ClientRectangle.Height / 2 - Me.Height / 2)))
                frmGen.Show()
            Case "vw_SOURCE"
                frmGen.Text = "Πηγές"
                frmGen.MdiParent = frmMain
                frmGen.Mode = FormMode.NewRecord
                frmGen.Scroller = GridView1
                frmGen.FormScroller = Me
                frmGen.DataTable = "SRC"
                frmGen.L1.Text = "Κωδικός"
                frmGen.L2.Text = "Πηγή"
                frmGen.FormScroller = Me
                frmGen.CalledFromControl = False
                frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(frmGen), New Point(CInt(Me.Parent.ClientRectangle.Width / 2 - Me.Width / 2), CInt(Me.Parent.ClientRectangle.Height / 2 - Me.Height / 2)))
                frmGen.Show()
            Case "vw_CCT"
                Dim frmCustomers As frmCustomers = New frmCustomers()
                frmCustomers.Text = "Πελάτες"
                frmCustomers.MdiParent = frmMain
                frmCustomers.Mode = FormMode.NewRecord
                frmCustomers.Scroller = GridView1
                frmCustomers.FormScroller = Me
                frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(frmCustomers), New Point(CInt(Me.Parent.ClientRectangle.Width / 2 - Me.Width / 2), CInt(Me.Parent.ClientRectangle.Height / 2 - Me.Height / 2)))
                frmCustomers.Show()
            Case "vw_COU"
                frmGen.Text = "Νομοί"
                frmGen.MdiParent = frmMain
                frmGen.Mode = FormMode.NewRecord
                frmGen.Scroller = GridView1
                frmGen.DataTable = "COU"
                frmGen.L1.Text = "Κωδικός"
                frmGen.L2.Text = "Νομός"
                frmGen.FormScroller = Me
                frmGen.CalledFromControl = False
                frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(frmGen), New Point(CInt(Me.Parent.ClientRectangle.Width / 2 - Me.Width / 2), CInt(Me.Parent.ClientRectangle.Height / 2 - Me.Height / 2)))
                frmGen.Show()
            Case "vw_SALERS"
                frmGen.Text = "Πωλητές"
                frmGen.MdiParent = frmMain
                frmGen.Mode = FormMode.NewRecord
                frmGen.Scroller = GridView1
                frmGen.DataTable = "SALERS"
                frmGen.L1.Text = "Κωδικός"
                frmGen.L2.Text = "Πωλητής"
                frmGen.L6.Text = "Χρώμα"
                frmGen.L8.Text = "Αρ. Πρωτοκόλου"
                frmGen.L9.Text = "Ποσοστό κέρδους"
                frmGen.L9.Control.Tag = "profitPerc,0,1,2"
                Dim profitPerc As DevExpress.XtraEditors.TextEdit = TryCast(frmGen.L9.Control, DevExpress.XtraEditors.TextEdit)
                profitPerc.Properties.EditFormat.FormatString = "n0"
                profitPerc.Properties.EditFormat.FormatType = FormatType.Numeric
                profitPerc.Properties.MaskSettings.MaskExpression = "n0"
                profitPerc.Properties.Mask.MaskType = Mask.MaskType.Numeric
                profitPerc.Properties.UseMaskAsDisplayFormat = True
                frmGen.FormScroller = Me
                frmGen.CalledFromControl = False
                frmGen.L9.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
                frmGen.L8.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
                frmGen.L6.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
                frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(frmGen), New Point(CInt(Me.Parent.ClientRectangle.Width / 2 - Me.Width / 2), CInt(Me.Parent.ClientRectangle.Height / 2 - Me.Height / 2)))
                frmGen.Show()
            Case "vw_AREAS"
                frmGen.Text = "Περιοχές"
                frmGen.MdiParent = frmMain
                frmGen.Mode = FormMode.NewRecord
                frmGen.Scroller = GridView1
                frmGen.DataTable = "AREAS"
                frmGen.L1.Text = "Κωδικός"
                frmGen.L2.Text = "Περιοχή"
                frmGen.L3.Text = "Νομός"
                frmGen.FormScroller = Me
                frmGen.CalledFromControl = False
                frmGen.L3.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
                frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(frmGen), New Point(CInt(Me.Parent.ClientRectangle.Width / 2 - Me.Width / 2), CInt(Me.Parent.ClientRectangle.Height / 2 - Me.Height / 2)))
                frmGen.Show()
            Case "vw_ADR"
                frmGen.Text = "Διευθύνσεις"
                frmGen.MdiParent = frmMain
                frmGen.Mode = FormMode.NewRecord
                frmGen.Scroller = GridView1
                frmGen.DataTable = "ADR"
                frmGen.L1.Text = "Κωδικός"
                frmGen.L2.Text = "Διεύθυνση"
                frmGen.L3.Text = "Νομός"
                frmGen.L4.Text = "Περιοχές"
                frmGen.L8.Text = "Αριθμός"
                frmGen.FormScroller = Me
                frmGen.CalledFromControl = False
                frmGen.L3.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
                frmGen.L4.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
                frmGen.L8.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
                frmGen.L8.Control.Tag = "Ar,0,1,2"
                frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(frmGen), New Point(CInt(Me.Parent.ClientRectangle.Width / 2 - Me.Width / 2), CInt(Me.Parent.ClientRectangle.Height / 2 - Me.Height / 2)))
                frmGen.Show()
            Case "vw_DOY"
                frmGen.Text = "ΔΟΥ"
                frmGen.MdiParent = frmMain
                frmGen.Mode = FormMode.NewRecord
                frmGen.Scroller = GridView1
                frmGen.DataTable = "DOY"
                frmGen.L1.Text = "Κωδικός"
                frmGen.L2.Text = "ΔΟΥ"
                frmGen.FormScroller = Me
                frmGen.CalledFromControl = False
                frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(frmGen), New Point(CInt(Me.Parent.ClientRectangle.Width / 2 - Me.Width / 2), CInt(Me.Parent.ClientRectangle.Height / 2 - Me.Height / 2)))
                frmGen.Show()
            Case "vw_PRF"
                frmGen.Text = "Επαγγέλματα"
                frmGen.MdiParent = frmMain
                frmGen.Mode = FormMode.NewRecord
                frmGen.Scroller = GridView1
                frmGen.DataTable = "PRF"
                frmGen.L1.Text = "Κωδικός"
                frmGen.L2.Text = "Επάγγελμα"
                frmGen.FormScroller = Me
                frmGen.CalledFromControl = False
                frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(frmGen), New Point(CInt(Me.Parent.ClientRectangle.Width / 2 - Me.Width / 2), CInt(Me.Parent.ClientRectangle.Height / 2 - Me.Height / 2)))
                frmGen.Show()
            Case "vw_CCT_M"
                Dim frmCusMov As frmCusMov = New frmCusMov()
                frmCusMov.Text = "Κινήσεις Πελατών"
                frmCusMov.MdiParent = frmMain
                frmCusMov.Mode = FormMode.NewRecord
                frmCusMov.Scroller = GridView1
                frmCusMov.FormScroller = Me
                frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(frmCusMov), New Point(CInt(Me.Parent.ClientRectangle.Width / 2 - Me.Width / 2), CInt(Me.Parent.ClientRectangle.Height / 2 - Me.Height / 2)))
                frmCusMov.Show()
            Case "vw_NOTES_L"
                frmGen.Text = "Εττικέτες"
                frmGen.MdiParent = frmMain
                frmGen.Mode = FormMode.NewRecord
                frmGen.Scroller = GridView1
                frmGen.DataTable = "NOTES_L"
                frmGen.L1.Text = "Κωδικός"
                frmGen.L2.Text = "Εττικέτα"
                frmGen.FormScroller = Me
                frmGen.CalledFromControl = False
                frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(frmGen), New Point(CInt(Me.Parent.ClientRectangle.Width / 2 - Me.Width / 2), CInt(Me.Parent.ClientRectangle.Height / 2 - Me.Height / 2)))
                frmGen.Show()
            Case "vw_DOOR_TYPE"
                Dim frmDoorType As frmDoorType = New frmDoorType
                frmDoorType.Text = "Κατηγορία Πόρτας"
                frmDoorType.MdiParent = frmMain
                frmDoorType.Mode = FormMode.NewRecord
                frmDoorType.Scroller = GridView1
                frmDoorType.FormScroller = Me
                frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(frmDoorType), New Point(CInt(Me.Parent.ClientRectangle.Width / 2 - Me.Width / 2), CInt(Me.Parent.ClientRectangle.Height / 2 - Me.Height / 2)))
                frmDoorType.Show()
            Case "vw_CAT_ERM"
                frmGen.Text = "Κατηγορίες Ερμαρίων"
                frmGen.MdiParent = frmMain
                frmGen.Mode = FormMode.NewRecord
                frmGen.Scroller = GridView1
                frmGen.DataTable = "CAT_ERM"
                frmGen.L1.Text = "Κωδικός"
                frmGen.L2.Text = "Κατηγορία"
                frmGen.FormScroller = Me
                frmGen.CalledFromControl = False
                frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(frmGen), New Point(CInt(Me.Parent.ClientRectangle.Width / 2 - Me.Width / 2), CInt(Me.Parent.ClientRectangle.Height / 2 - Me.Height / 2)))
                frmGen.Show()
            Case "vw_ERM"
                Dim frmErmaria As frmErmaria = New frmErmaria
                frmErmaria.Text = "Ερμάρια"
                frmErmaria.MdiParent = frmMain
                frmErmaria.Mode = FormMode.NewRecord
                frmErmaria.Scroller = GridView1
                frmErmaria.FormScroller = Me
                frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(frmErmaria), New Point(CInt(Me.Parent.ClientRectangle.Width / 2 - Me.Width / 2), CInt(Me.Parent.ClientRectangle.Height / 2 - Me.Height / 2)))
                frmErmaria.Show()
            Case "vw_BENCH"
                Dim frmBench As frmBench = New frmBench
                frmBench.Text = "Πάγκοι"
                frmBench.MdiParent = frmMain
                frmBench.Mode = FormMode.NewRecord
                frmBench.Scroller = GridView1
                frmBench.FormScroller = Me
                frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(frmBench), New Point(CInt(Me.Parent.ClientRectangle.Width / 2 - Me.Width / 2), CInt(Me.Parent.ClientRectangle.Height / 2 - Me.Height / 2)))
                frmBench.Show()
            Case "vw_MECH"
                Dim frmMech As frmMech = New frmMech
                frmMech.Text = "Μηχανισμοί"
                frmMech.MdiParent = frmMain
                frmMech.Mode = FormMode.NewRecord
                frmMech.Scroller = GridView1
                frmMech.FormScroller = Me
                frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(frmMech), New Point(CInt(Me.Parent.ClientRectangle.Width / 2 - Me.Width / 2), CInt(Me.Parent.ClientRectangle.Height / 2 - Me.Height / 2)))
                frmMech.Show()
            Case "vw_TECH_CAT"
                frmGen.Text = "Κατηγορίες Τεχνικής Υποστήριξης"
                frmGen.MdiParent = frmMain
                frmGen.Mode = FormMode.NewRecord
                frmGen.Scroller = GridView1
                frmGen.DataTable = "TECH_CAT"
                frmGen.L1.Text = "Κωδικός"
                frmGen.L2.Text = "Κατηγορία"
                frmGen.FormScroller = Me
                frmGen.CalledFromControl = False
                frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(frmGen), New Point(CInt(Me.Parent.ClientRectangle.Width / 2 - Me.Width / 2), CInt(Me.Parent.ClientRectangle.Height / 2 - Me.Height / 2)))
                frmGen.Show()
            Case "vw_COLORS_CAT"
                frmGen.Text = "Κατηγορίες Χρωμάτων"
                frmGen.MdiParent = frmMain
                frmGen.Mode = FormMode.NewRecord
                frmGen.Scroller = GridView1
                frmGen.DataTable = "COLORS_CAT"
                frmGen.L1.Text = "Κωδικός"
                frmGen.L2.Text = "Κατηγορίες Χρωμάτων"
                frmGen.FormScroller = Me
                frmGen.CalledFromControl = False
                frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(frmGen), New Point(CInt(Me.Parent.ClientRectangle.Width / 2 - Me.Width / 2), CInt(Me.Parent.ClientRectangle.Height / 2 - Me.Height / 2)))
                frmGen.Show()
        End Select
    End Sub
    'Φορτώνω τις εγγραφές στο GRID
    Public Sub LoadRecords(Optional ByVal sDataTable2 As String = "", Optional ByVal sWhere As String = "", Optional ByVal CloseReader As Boolean = True)
        Try
            Dim sSQL As String
            Dim sSQL2 As String
            Dim sVal As Integer
            Dim sActiveFilter As String

            sActiveFilter = GridView1.ActiveFilterString
            sVal = RepositoryBarRecords.Items.IndexOf(BarRecords.EditValue)

            If sVal <> 4 And BarRecords.EditValue <> Nothing Then
                sSQL = "SELECT top " & BarRecords.EditValue & " * FROM " & IIf(sDataTable = "", sDataTable2, sDataTable) & " " & sWhereCondition
            Else
                sSQL = "SELECT  * FROM " & IIf(sDataTable = "", sDataTable2, sDataTable) & " " & sWhereCondition
            End If
            If sDataDetail <> "" Then sSQL2 = "SELECT  * FROM " & sDataDetail
            myCmd = CNDB.CreateCommand
            myCmd.CommandText = sSQL
            GridView1.Columns.Clear()
            myReader = myCmd.ExecuteReader()

            If sDataDetail = "" Then
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
                        If grdMain.LevelTree.Nodes.Count = 1 Then
                            Dim GrdView As New GridView(grdMain)
                            grdMain.LevelTree.Nodes.Add("Φόρμες", GridView2)
                            'Specify text to be displayed within detail tabs.
                            GrdView.ViewCaption = "Φόρμες"
                        End If
                    Case "vw_TRANSD"
                        Dim AdapterMaster As New SqlDataAdapter(sSQL, CNDB)
                        Dim AdapterDetail As New SqlDataAdapter(sSQL2, CNDB)
                        Dim sdataSet As New DataSet()
                        AdapterMaster.Fill(sdataSet, IIf(sDataTable = "", sDataTable2, sDataTable))
                        AdapterDetail.Fill(sdataSet, sDataDetail)
                        Dim keyColumn As DataColumn = sdataSet.Tables(IIf(sDataTable = "", sDataTable2, sDataTable)).Columns("ID")
                        Dim foreignKeyColumn As DataColumn = sdataSet.Tables(sDataDetail).Columns("transhID")
                        sdataSet.Relations.Add("Χρεωπιστώσεις", keyColumn, foreignKeyColumn, False)
                        GridView1.Columns.Clear() : GridView2.Columns.Clear()
                        grdMain.DataSource = sdataSet.Tables(IIf(sDataTable = "", sDataTable2, sDataTable))
                        grdMain.ForceInitialize()
                        If grdMain.LevelTree.Nodes.Count = 1 Then
                            Dim GrdView As New GridView(grdMain)
                            grdMain.LevelTree.Nodes.Add("Χρεωπιστώσεις", GridView2)
                            'Specify text to be displayed within detail tabs.
                            GrdView.ViewCaption = "Χρεωπιστώσεις"
                        End If
                    Case "vw_INST_M"
                        Dim AdapterMaster As New SqlDataAdapter(sSQL, CNDB)
                        Dim AdapterDetail As New SqlDataAdapter(sSQL2, CNDB)
                        Dim sdataSet As New DataSet()
                        AdapterMaster.Fill(sdataSet, IIf(sDataTable = "", sDataTable2, sDataTable))
                        AdapterDetail.Fill(sdataSet, sDataDetail)
                        Dim keyColumn As DataColumn = sdataSet.Tables(IIf(sDataTable = "", sDataTable2, sDataTable)).Columns("ID")
                        Dim foreignKeyColumn As DataColumn = sdataSet.Tables(sDataDetail).Columns("instID")
                        sdataSet.Relations.Add("Χρεωπιστώσεις Τοποθετών", keyColumn, foreignKeyColumn, False)
                        GridView1.Columns.Clear() : GridView2.Columns.Clear()
                        grdMain.DataSource = sdataSet.Tables(IIf(sDataTable = "", sDataTable2, sDataTable))
                        grdMain.ForceInitialize()
                        If grdMain.LevelTree.Nodes.Count = 1 Then
                            Dim GrdView As New GridView(grdMain)
                            grdMain.LevelTree.Nodes.Add("Χρεωπιστώσεις Τοποθετών", GridView2)
                            'Specify text to be displayed within detail tabs.
                            GrdView.ViewCaption = "Χρεωπιστώσεις Τοποθετών"
                        End If
                    Case "vw_SUP_PAYMENTS_D"
                        Dim AdapterMaster As New SqlDataAdapter(sSQL, CNDB)
                        Dim AdapterDetail As New SqlDataAdapter(sSQL2, CNDB)
                        Dim sdataSet As New DataSet()
                        AdapterMaster.Fill(sdataSet, IIf(sDataTable = "", sDataTable2, sDataTable))
                        AdapterDetail.Fill(sdataSet, sDataDetail)
                        Dim keyColumn As DataColumn = sdataSet.Tables(IIf(sDataTable = "", sDataTable2, sDataTable)).Columns("ID")
                        Dim foreignKeyColumn As DataColumn = sdataSet.Tables(sDataDetail).Columns("buyID")
                        sdataSet.Relations.Add("Ανάλυση Πληρωμών", keyColumn, foreignKeyColumn, False)
                        GridView1.Columns.Clear() : GridView2.Columns.Clear()
                        grdMain.DataSource = sdataSet.Tables(IIf(sDataTable = "", sDataTable2, sDataTable))
                        grdMain.ForceInitialize()
                        If grdMain.LevelTree.Nodes.Count = 1 Then
                            Dim GrdView As New GridView(grdMain)
                            grdMain.LevelTree.Nodes.Add("Ανάλυση Πληρωμών", GridView2)
                            'Specify text to be displayed within detail tabs.
                            GrdView.ViewCaption = "Ανάλυση Πληρωμών"
                        End If

                End Select
            End If
            grdMain.DefaultView.PopulateColumns()

            'Εαν δεν έχει data το Dataset αναγκαστικά προσθέτω μόνος μου τις στήλες
            If sDataDetail = "" Then
                If myReader.HasRows = False Then
                    GridView1.Columns.Clear()
                    For i As Integer = 0 To myReader.FieldCount - 1
                        Dim C As New GridColumn
                        C.Name = "col" & myReader.GetName(i).ToString
                        C.Caption = myReader.GetName(i).ToString
                        C.Visible = True
                        GridView1.Columns.Add(C)
                    Next i
                    'LoadViews()
                Else
                    'LoadViews()
                End If
            Else
                'LoadViews()
            End If
            LoadViews()
            If sActiveFilter <> "" Then GridView1.ActiveFilterString = sActiveFilter
            myCmd.Dispose()
            If CloseReader = True Then myReader.Close()
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
            ElseIf e.KeyCode = Keys.Enter Then
                If GridView1.IsGroupRow(GridView1.FocusedRowHandle) Then Exit Sub Else EditRecord()
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
            If sDataDetail <> "" Then LoadForms.RestoreLayoutFromXml(GridView2, sDataDetail & "_def.xml")
        Else
            If My.Computer.FileSystem.FileExists(Application.StartupPath & "\DSGNS\DEF\D_" & sDataDetail & "\" & BarViews.EditValue) = False Then
                If sDataDetail <> "" Then GridView2.RestoreLayoutFromXml(Application.StartupPath & "\DSGNS\D_" & sDataDetail & "\" & BarViews.EditValue, OptionsLayoutBase.FullLayout)
            End If
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
        If sDataDetail <> "" Then GridView2.SaveLayoutToXml(Application.StartupPath & "\DSGNS\DEF\D_" & sDataDetail & "_def.xml", OptionsLayoutBase.FullLayout)
        XtraMessageBox.Show("Η όψη αποθηκέυτηκε με επιτυχία", "Dreamy Kitchen CRM", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ' Μόνο αν ο Χρήστης είναι ο Παναγόπουλος
        If UserProps.ID.ToString.ToUpper = "3F9DC32E-BE5B-4D46-A13C-EA606566CF32" Then
            If XtraMessageBox.Show("Θέλετε να γίνει κοινοποίηση της όψης? Εαν επιλέξετε 'Yes' όλοι οι χρήστες θα έχουν την ίδια όψη", "Dreamy Kitchen CRM", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                If My.Computer.FileSystem.FileExists(ProgProps.ServerViewsPath & "DSGNS\DEF\" & sDataTable & "_def.xml") = False Then GridView1.OptionsLayout.LayoutVersion = "v1"
                GridView1.SaveLayoutToXml(ProgProps.ServerViewsPath & "DSGNS\DEF\" & sDataTable & "_def.xml", OptionsLayoutBase.FullLayout)
            End If
        End If

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
    Private Sub UpdateViewFromDB(ByVal GRDView As GridView)
        Try
            Dim col1 As GridColumn
            Dim Col2 As GridColumn
            Dim grdColumns As List(Of GridColumn)
            LoadRecords(,, False)
            If myReader Is Nothing Then Exit Sub
            'Εαν υπάρχουν πεδία που πρέπει να προστεθούν από την βάση
            If myReader.FieldCount >= GridView1.Columns.Count Then
                Dim schema As DataTable = myReader.GetSchemaTable()
                grdColumns = GridView1.Columns.ToList()
                For i As Integer = 0 To myReader.FieldCount - 1
                    Console.WriteLine(myReader.GetName(i))
                    If i < GridView1.Columns.Count Then
                        'Col2 = GridView1.Columns.Item(i)
                        Col2 = GridView1.Columns.ColumnByFieldName(myReader.GetName(i))
                    Else
                        Col2 = Nothing
                    End If
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
                        Col2 = grdColumns(i)
                        Dim sOrd As String = myReader.GetOrdinal(Col2.FieldName)
                    Catch ex As Exception
                        Col2 = grdColumns(i)
                        GridView1.Columns.Remove(Col2)
                        Console.WriteLine(ex.Message)

                        Continue For
                    End Try

                Next

            End If
            LoadForms.LoadColumnDescriptionNames(grdMain, GridView1, , sDataTable)
            myReader.Close()
        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), "Dreamy Kitchen CRM", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub BBUpdateViewFromDB_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BBUpdateViewFromDB.ItemClick
        'ReadXml.UpdateXMLFile(Application.StartupPath & "\DSGNS\DEF\" & sDataTable & "_def.xml")
        'My.Computer.FileSystem.DeleteFile(Application.StartupPath & "\DSGNS\DEF\" & sDataTable & "_def.xml")
        UpdateViewFromDB(GridView1)
    End Sub
    Private Sub GridView1_CustomDrawGroupRow(sender As Object, e As RowObjectCustomDrawEventArgs) Handles GridView1.CustomDrawGroupRow
        Select Case sDataTable
            Case "vw_EMP_M"
                If GridView1.GetRowLevel(e.RowHandle) = 1 Then e.Appearance.BackColor = Color.DarkGray
                Dim info As GridGroupRowInfo = TryCast(e.Info, GridGroupRowInfo)
                info.GroupText = info.GroupText.Replace("Μέσος Όρος", "")
            Case "vw_EMP_T"
                'If GridView1.GetRowLevel(e.RowHandle) = 1 Then
                'e.Appearance.BackColor = Color.FromArgb(GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "color"))
                'If GridView1.IsGroupRow(e.RowHandle) Then
                '    e.Appearance.ForeColor = Color.FromArgb(GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "color"))

                '    GridView1.RefreshRow(e.RowHandle)
                'End If

                'End If


            Case "vw_INST"
                If GridView1.GetRowLevel(e.RowHandle) = 1 Then e.Appearance.BackColor = Color.DarkGray
        End Select
    End Sub

    Private Sub GridView1_RowStyle(sender As Object, e As RowStyleEventArgs) Handles GridView1.RowStyle

    End Sub

    Private Sub BBUpdateViewFileFromServer_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BBUpdateViewFileFromServer.ItemClick
        If XtraMessageBox.Show("Θέλετε να γίνει μεταφορά της όψης από τον server?", "Dreamy Kitchen CRM", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            ' Έλεγχος αν υπάρχει όψη με μεταγενέστερη ημερομηνία στον Server
            If System.IO.File.Exists(ProgProps.ServerViewsPath & "DSGNS\DEF\" & sDataTable & "_def.xml") = True Then
                My.Computer.FileSystem.CopyFile(ProgProps.ServerViewsPath & "DSGNS\DEF\" & sDataTable & "_def.xml", Application.StartupPath & "\DSGNS\DEF\" & sDataTable & "_def.xml", True)
                GridView1.RestoreLayoutFromXml(Application.StartupPath & "\DSGNS\DEF\" & sDataTable & "_def.xml", OptionsLayoutBase.FullLayout)
            End If
        End If
    End Sub


End Class