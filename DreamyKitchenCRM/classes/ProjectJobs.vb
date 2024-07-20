Imports DevExpress.XtraEditors
Imports System.Data.SqlClient

Public Class ProjectJobs
    Dim Frm As frmProjectJobs
    Private Valid As New ValidateControls
    Private FillCbo As New FillCombos
    Private DBQ As New DBQueries
    Private LoadForms As New FormLoader
    Private Cls As New ClearControls
    Private UserPermissions As New CheckPermissions
    Private ID As String
    Public Mode As Byte

    Public Sub Initialize(ByVal sFrm As frmProjectJobs, ByVal sID As String, ByVal sMode As Byte)
        Frm = sFrm
        ID = sID
        Mode = sMode
        HandleGridEmbeddedNavigatorButtons()
        Frm.CCT_TRANSHTableAdapter.Fill(Frm.DM_TRANS.CCT_TRANSH)
        Frm.Vw_SUPTableAdapter.Fill(Frm.DreamyKitchenDataSet.vw_SUP)
        Frm.Vw_ORDER_MANAGERSTableAdapter.Fill(Frm.DreamyKitchenDataSet.vw_ORDER_MANAGERS)
        Frm.Vw_PROJECT_JOBS_DTableAdapter.FillByProjectJobID(Frm.DMDataSet.vw_PROJECT_JOBS_D, System.Guid.Parse(ID))
        UserPermissions.GetUserPermissions("Εργασίες Έργων")
    End Sub
    Public Sub LoadForm()
        Select Case Mode
            Case FormMode.NewRecord
                Frm.txtCode.Text = DBQ.GetNextId("PROJECT_JOBS")
                FillCbo.FillCheckedListPROJECT_JOBS_SER(Frm.chkSER, FormMode.NewRecord)
            Case FormMode.EditRecord
                LoadForms.LoadForm(Frm.LayoutControl1, "Select * from PROJECT_JOBS where id ='" + ID + "'")
                FillCbo.FillCheckedListPROJECT_JOBS_SER(Frm.chkSER, FormMode.EditRecord, ID)
        End Select
        Frm.cmdSave.Enabled = IIf(Mode = FormMode.NewRecord, UserProps.AllowInsert, UserProps.AllowEdit)
    End Sub
    Private Sub HandleGridEmbeddedNavigatorButtons()
        Dim navigator As ControlNavigator = Frm.GridControl1.EmbeddedNavigator
        navigator.Buttons.BeginUpdate()
        Try
            If Mode = FormMode.NewRecord Then
                navigator.Buttons.Append.Enabled = False
                navigator.Buttons.Remove.Enabled = False
            Else
                navigator.Buttons.Append.Enabled = True
                navigator.Buttons.Remove.Enabled = True
            End If
        Finally
            navigator.Buttons.EndUpdate()
        End Try
    End Sub
    Public Sub SaveRecord(ByRef sID As String)
        Dim sResult As Boolean
        Dim sSQL As String
        Dim sGuid As String
        Try
            If Valid.ValidateForm(Frm.LayoutControl1) Then
                Select Case Mode
                    Case FormMode.NewRecord
                        sGuid = System.Guid.NewGuid.ToString
                        sResult = DBQ.InsertNewData(DBQueries.InsertMode.OneLayoutControl, "PROJECT_JOBS", Frm.LayoutControl1,,, sGuid, True)
                        ID = sGuid : sID = sGuid
                    Case FormMode.EditRecord
                        sResult = DBQ.UpdateNewData(DBQueries.InsertMode.OneLayoutControl, "PROJECT_JOBS", Frm.LayoutControl1,,, sID, True)
                        ID = sID
                        If sResult = True Then
                            ' Διαγραφή όλων των συνεργείων πάντα στην επεξεργασία εγγραφής
                            sSQL = "DELETE FROM PROJECT_JOBS_SER where projectJobID = '" & sID & "'"
                            Using oCmd As New SqlCommand(sSQL, CNDB)
                                oCmd.ExecuteNonQuery()
                            End Using
                        End If

                End Select

                If sResult = True Then
                    ' Καταχώρηση Συνεργείων 
                    For Each item As DevExpress.XtraEditors.Controls.CheckedListBoxItem In Frm.chkSER.CheckedItems
                        sSQL = "INSERT INTO PROJECT_JOBS_SER (projectJobID,empID,[createdBy],[createdOn]) values (" & toSQLValueS(sID) & "," & toSQLValueS(item.Tag.ToString()) & "," & toSQLValueS(UserProps.ID.ToString) & ", getdate() )"
                        Using oCmd As New SqlCommand(sSQL, CNDB)
                            oCmd.ExecuteNonQuery()
                        End Using
                    Next
                    FillCbo.FillCheckedListPROJECT_JOBS_SER(Frm.chkSER, FormMode.EditRecord, sID)
                    Mode = FormMode.EditRecord
                    HandleGridEmbeddedNavigatorButtons()
                    XtraMessageBox.Show("Η εγγραφή αποθηκέυτηκε με επιτυχία", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Public Sub CUSEditValueChanged()
        Dim sCusID As String
        If Frm.cboCUS.EditValue Is Nothing Then sCusID = toSQLValueS("00000000-0000-0000-0000-000000000000") Else sCusID = toSQLValueS(Frm.cboCUS.EditValue.ToString)
        Dim sSQL As New System.Text.StringBuilder
        sSQL.AppendLine("Select T.id,FullTranshDescription,Description,Iskitchen,Iscloset,Isdoor,Issc,instdtDeliverDate
                        from vw_TRANSH t
                        where  T.cusid = " & sCusID & "order by description")
        FillCbo.TRANSH(Frm.cboTRANSH, sSQL)
    End Sub
    Public Sub DeleteRecord()
        If Frm.GridView1.GetRowCellValue(Frm.GridView1.FocusedRowHandle, "ID") = Nothing Then Exit Sub
        If XtraMessageBox.Show("Θέλετε να διαγραφεί η τρέχουσα εγγραφή?", ProgProps.ProgTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            Dim sSQL As String = "DELETE FROM PROJECT_JOBS_D WHERE ID = '" & Frm.GridView1.GetRowCellValue(Frm.GridView1.FocusedRowHandle, "ID").ToString & "'"
            Using oCmd As New SqlCommand(sSQL, CNDB)
                oCmd.ExecuteNonQuery()
            End Using
            Frm.Vw_PROJECT_JOBS_DTableAdapter.FillByProjectJobID(Frm.DMDataSet.vw_PROJECT_JOBS_D, System.Guid.Parse(ID))
        End If
    End Sub
End Class
