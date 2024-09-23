Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip
Imports System.Data.SqlClient
Imports DevExpress.XtraEditors


Public Class InstM
    Private Frm As frmInstM
    Private Valid As New ValidateControls
    Private FillCbo As New FillCombos
    Private DBQ As New DBQueries
    Private LoadForms As New FormLoader
    Private Cls As New ClearControls
    Private UserPermissions As New CheckPermissions
    Private ID As String
    Public Mode As Byte

    Public Sub Initialize(ByVal sFrm As frmInstM, ByVal sID As String, ByVal sMode As Byte)
        Frm = sFrm
        ID = sID
        Mode = sMode
        FillCbo.EXTPARTNERS(Frm.cboSER)
        UserPermissions.GetUserPermissions("Πληρωμές Εξωτερικών Τοποθετών")
    End Sub
    Public Sub LoadForm()
        Select Case Mode
            Case FormMode.NewRecord
                Frm.txtCode.Text = DBQ.GetNextId("INST_M")
            Case FormMode.EditRecord
                LoadForms.LoadForm(Frm.LayoutControl1, "Select * from vw_INST_M where id ='" + ID + "'")
                Frm.Vw_INSTPerSerTableAdapter.FillByID(Frm.DreamyKitchenDataSet.vw_INSTPerSer, System.Guid.Parse(ID))
        End Select
        With Frm.GridView3
            LoadForms.RestoreLayoutFromXml(Frm.GridView3, "INSTPERSER.xml")
            .OptionsMenu.ShowFooterItem = True
            .OptionsMenu.EnableFooterMenu = True
            .OptionsMenu.EnableGroupPanelMenu = True
            .OptionsMenu.EnableGroupRowMenu = True
            .OptionsView.ShowFooter = True
            .OptionsMenu.ShowGroupSummaryEditorItem = True
            .OptionsMenu.ShowGroupSortSummaryItems = True
            .OptionsMenu.ShowConditionalFormattingItem = True
        End With
        Frm.cmdSave.Enabled = IIf(Mode = FormMode.NewRecord, UserProps.AllowInsert, UserProps.AllowEdit)
    End Sub
    Public Sub SaveRecord(ByRef sID As String)
        Dim sResult As Boolean
        Dim sGuid As String
        Dim sSQL As String
        Try
            With Frm.GridView3
                If Valid.ValidateForm(Frm.LayoutControl1) Then
                    Dim sValCategory As String
                    If .GetRowCellValue(.FocusedRowHandle, "kitchen").ToString = "True" Then sValCategory = ",1" Else sValCategory = ",0"
                    If .GetRowCellValue(.FocusedRowHandle, "closet").ToString = "True" Then sValCategory = sValCategory & ",1" Else sValCategory = sValCategory & ",0"
                    If .GetRowCellValue(.FocusedRowHandle, "doors").ToString = "True" Then sValCategory = sValCategory & ",1" Else sValCategory = sValCategory & ",0"
                    If .GetRowCellValue(.FocusedRowHandle, "sc").ToString = "True" Then sValCategory = sValCategory & ",1" Else sValCategory = sValCategory & ",0"

                    Select Case Mode
                        Case FormMode.NewRecord
                            sGuid = System.Guid.NewGuid.ToString
                            sResult = DBQ.InsertNewData(DBQueries.InsertMode.OneLayoutControl, "INST_M", Frm.LayoutControl1,,, sGuid, True, "instID,instCostID,extPartnerID,kitchen,closet,doors,sc", toSQLValueS(.GetRowCellValue(.FocusedRowHandle, "instID").ToString) & "," & toSQLValueS(.GetRowCellValue(.FocusedRowHandle, "ID").ToString) & "," & toSQLValueS(Frm.cboSER.EditValue.ToString) & sValCategory)
                            ID = sGuid : sID = sGuid
                        Case FormMode.EditRecord
                            Dim ExtraFieldsAndValues As String
                            If .GetRowCellValue(.FocusedRowHandle, "kitchen").ToString = "True" Then ExtraFieldsAndValues = "Kitchen =1" Else ExtraFieldsAndValues = "Kitchen =0"
                            If .GetRowCellValue(.FocusedRowHandle, "closet").ToString = "True" Then ExtraFieldsAndValues = ExtraFieldsAndValues & ",closet=1" Else ExtraFieldsAndValues = ExtraFieldsAndValues & ",closet=0"
                            If .GetRowCellValue(.FocusedRowHandle, "doors").ToString = "True" Then ExtraFieldsAndValues = ExtraFieldsAndValues & ",doors=1" Else ExtraFieldsAndValues = ExtraFieldsAndValues & ",doors=0"
                            If .GetRowCellValue(.FocusedRowHandle, "sc").ToString = "True" Then ExtraFieldsAndValues = ExtraFieldsAndValues & ",sc=1" Else ExtraFieldsAndValues = ExtraFieldsAndValues & ",sc=0"
                            ExtraFieldsAndValues = ExtraFieldsAndValues & ",extPartnerID = " & toSQLValueS(Frm.cboSER.EditValue.ToString)
                            ExtraFieldsAndValues = ExtraFieldsAndValues & ",instCostID = " & toSQLValueS(.GetRowCellValue(.FocusedRowHandle, "ID").ToString)
                            sResult = DBQ.UpdateNewData(DBQueries.InsertMode.OneLayoutControl, "INST_M", Frm.LayoutControl1,,, sID, True,,,, ExtraFieldsAndValues)
                            ID = sID
                    End Select
                    Frm.txtCode.Text = DBQ.GetNextId("INST_M")


                    If sResult = True Then

                        ' Αν υπάρχει στην μισθοδοσία τοποθετών εγγραφή στο ίδιο έργο και με ίδιο ποσό γίνεται εξοφλημενη

                        Dim sCategory As String
                        If .GetRowCellValue(.FocusedRowHandle, "kitchen").ToString = "True" Then sCategory = " and Kitchen = 1 "
                        If .GetRowCellValue(.FocusedRowHandle, "closet").ToString = "True" Then sCategory = " and closet = 1 "
                        If .GetRowCellValue(.FocusedRowHandle, "doors").ToString = "True" Then sCategory = " and doors = 1 "
                        If .GetRowCellValue(.FocusedRowHandle, "sc").ToString = "True" Then sCategory = " and sc = 1 "


                        sSQL = "update INST_COST SET PAID=1,dtPayOFF= " & toSQLValueS(CDate(Frm.dtDeliverDate.Text.ToString).ToString("yyyyMMdd")) &
                               "from INST_COST I 
                            inner join(
                            SELECT i.instID ,SUM(I.cost + I.extraCost) as InstCostAmt,(SELECT SUM(IM.amt) FROM INST_M im WHERE INSTID=I.INSTID and im.extPartnerID=I.extPartnerID " & sCategory & " ) as InstMAmt 
                            From INST_COST I
                            where I.ID= " & toSQLValueS(.GetRowCellValue(.FocusedRowHandle, "ID").ToString) & sCategory &
                                "group by i.instID,I.extPartnerID ) AS S on s.instID = i.instID and InstCostAmt = InstMAmt and InstCostAmt <>0 and paid= 0 " & sCategory


                        Using oCmd As New SqlCommand(sSQL, CNDB)
                            oCmd.ExecuteNonQuery()
                        End Using
                        XtraMessageBox.Show("Η εγγραφή αποθηκέυτηκε με επιτυχία", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                    If Mode = FormMode.NewRecord Then
                        Cls.ClearCtrls(Frm.LayoutControl1)
                        Frm.txtCode.Text = DBQ.GetNextId("INST_M")
                        Frm.Vw_INSTPerSerTableAdapter.Fill(Frm.DreamyKitchenDataSet.vw_INSTPerSer, System.Guid.Parse(Guid.Empty.ToString))
                    End If
                End If
            End With
        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
