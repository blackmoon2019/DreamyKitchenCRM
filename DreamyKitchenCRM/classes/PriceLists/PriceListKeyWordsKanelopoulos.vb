Imports System.Data.SqlClient
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Base

Public Class PriceListKeyWordsKanelopoulos
    Dim Frm As frmPriceListsKeywords
    Private LoadForms As New FormLoader
    Private sSUP_ID As String
    Public WriteOnly Property SUP_ID As String
        Set(value As String)
            sSUP_ID = value
        End Set
    End Property

    Public Sub Initialize(ByVal sFrm As frmPriceListsKeywords)
        Frm = sFrm
        Frm.PRICELISTS_KEYWORDSTableAdapter.FillBySupID(Frm.DMDataSet.PRICELISTS_KEYWORDS, System.Guid.Parse(sSUP_ID))
        LoadForms.RestoreLayoutFromXml(Frm.GridView1, "PRICELISTS_KEYWORDS_def.xml")
    End Sub

    Public Sub SaveRecord(ByVal e As ValidateRowEventArgs)
        Dim sSQL As New System.Text.StringBuilder
        Try
            sSQL.Clear()
            If e.RowHandle = Frm.GridControl1.NewItemRowHandle Then
                If Frm.GridView1.GetRowCellValue(Frm.GridView1.FocusedRowHandle, "keyword").ToString = "" Then
                    e.ErrorText = "Παρακαλώ συμπληρώστε την λέξη κλειδί"
                    e.Valid = False
                    Exit Sub
                End If
                sSQL.AppendLine("INSERT INTO PRICELISTS_KEYWORDS (ID,keyword,supID,valuelistID,Active,[modifiedBy],[createdby],[createdOn])")
                sSQL.AppendLine("Select newid()" & ",")
                sSQL.AppendLine(toSQLValueS(Frm.GridView1.GetRowCellValue(Frm.GridView1.FocusedRowHandle, "keyword").ToString) & ",")
                sSQL.AppendLine(toSQLValueS(sSUP_ID) & ",")
                sSQL.AppendLine(toSQLValueS(Frm.GridView1.GetRowCellValue(Frm.GridView1.FocusedRowHandle, "valueListID").ToString) & ",")
                sSQL.AppendLine(toSQLValueS(Frm.GridView1.GetRowCellValue(Frm.GridView1.FocusedRowHandle, "Active").ToString) & ",")
                sSQL.Append(toSQLValueS(UserProps.ID.ToString) & "," & toSQLValueS(UserProps.ID.ToString) & ", getdate()")
                'Εκτέλεση QUERY
                Using oCmd As New SqlCommand(sSQL.ToString, CNDB)
                    oCmd.ExecuteNonQuery()
                End Using
            Else
                sSQL.AppendLine("UPDATE PRICELISTS_KEYWORDS	SET keyword= " & toSQLValueS(Frm.GridView1.GetRowCellValue(Frm.GridView1.FocusedRowHandle, "keyword").ToString) & ",")
                sSQL.AppendLine("valuelistID = " & toSQLValueS(Frm.GridView1.GetRowCellValue(Frm.GridView1.FocusedRowHandle, "valueListID").ToString) & ",")
                sSQL.AppendLine("Active = " & toSQLValueS(Frm.GridView1.GetRowCellValue(Frm.GridView1.FocusedRowHandle, "Active").ToString) & ",")
                sSQL.AppendLine("modifiedBY = " & toSQLValueS(UserProps.ID.ToString) & ",")
                sSQL.AppendLine("modifiedON = getdate() ")
                sSQL.AppendLine("WHERE ID = " & toSQLValueS(Frm.GridView1.GetRowCellValue(Frm.GridView1.FocusedRowHandle, "ID").ToString))
                'Εκτέλεση QUERY
                Using oCmd As New SqlCommand(sSQL.ToString, CNDB)
                    oCmd.ExecuteNonQuery()
                End Using
            End If
            Frm.PRICELISTS_KEYWORDSTableAdapter.FillBySupID(Frm.DMDataSet.PRICELISTS_KEYWORDS, System.Guid.Parse(sSUP_ID))
        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Public Sub DeleteRecord()
        If Frm.GridView1.FocusedRowHandle < 0 Then
            XtraMessageBox.Show("Δεν μπορείτε να διαγράψετε εγγραφή που επεξεργάζεστε. Αν θέλετε να φύγετε από την εγγραφή πατήστε ESC", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If Frm.GridView1.GetRowCellValue(Frm.GridView1.FocusedRowHandle, "ID") = Nothing Then Exit Sub
        If XtraMessageBox.Show("Θέλετε να διαγραφεί η τρέχουσα εγγραφή?", ProgProps.ProgTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            Dim sSQL As String = "DELETE FROM PRICELISTS_KEYWORDS WHERE ID = '" & Frm.GridView1.GetRowCellValue(Frm.GridView1.FocusedRowHandle, "ID").ToString & "'"
            Using oCmd As New SqlCommand(sSQL, CNDB)
                oCmd.ExecuteNonQuery()
            End Using
            Frm.PRICELISTS_KEYWORDSTableAdapter.FillBySupID(Frm.DMDataSet.PRICELISTS_KEYWORDS, System.Guid.Parse(sSUP_ID))
        End If
    End Sub
End Class
