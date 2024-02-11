Imports DevExpress.XtraEditors
Imports System.Data.SqlClient

Public Class AgreementCheckList
    Private ID As String
    Private Mode As Byte
    Private DBQ As New DBQueries
    Private LoadForms As New FormLoader
    Private Frm As frmAgreementCheckList
    Private Prog_Prop As New ProgProp

    Public Sub Initialize(ByVal sFrm As frmAgreementCheckList, ByVal sID As String, ByVal sMode As Byte)
        Frm = sFrm
        ID = sID
        Mode = sMode
        Frm.Vw_PROJECTCHECKLISTTableAdapter.Fill(Frm.DM_VALUELISTITEM.vw_PROJECTCHECKLIST)
    End Sub
    Public Sub LoadForm()
        Select Case Mode
            Case FormMode.NewRecord

            Case FormMode.EditRecord

                LoadForms.LoadDataToGrid(Frm.GridControl4, Frm.GridView4,
                    "select ID,AgreementID,valueListItemID,Value,name,[modifiedBy],[modifiedOn]
                    from VW_AGREEMENT_CHECKLIST 
                    where AgreementID= " & toSQLValueS(ID) & " ORDER BY NAME")
        End Select

        LoadForms.RestoreLayoutFromXml(Frm.GridView4, "vw_AGREEMENT_CHECKLIST_def.xml")


    End Sub
    Public Sub InsertSelectedRows()
        Dim sSQL As String
        Dim I As Integer
        sSQL = "DELETE FROM AGREEMENT_CHECKLIST WHERE AgreementID = " & toSQLValueS(ID)
        Using oCmd As New SqlCommand(sSQL, CNDB)
            oCmd.ExecuteNonQuery()
        End Using

        Dim Selected As Boolean
        For I = 0 To Frm.GridView4.RowCount - 1
            Selected = Frm.GridView4.GetRowCellValue(I, "Value")
            sSQL = "INSERT INTO AGREEMENT_CHECKLIST(AgreementID,valueListItemID,Value,[modifiedBy],[modifiedOn]) " &
                    " VALUES ( " & toSQLValueS(ID) & "," & toSQLValueS(Frm.GridView4.GetRowCellValue(I, "ID").ToString) & "," & IIf(Selected = True, 1, 0) & "," & toSQLValueS(UserProps.ID.ToString) & ",getdate())"
            Using oCmd As New SqlCommand(sSQL, CNDB)
                oCmd.ExecuteNonQuery()
            End Using
        Next

        XtraMessageBox.Show("Η εγγραφή αποθηκέυτηκε με επιτυχία", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Information)


    End Sub
End Class
