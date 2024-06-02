Imports System.Data.SqlClient
Imports DevExpress.DashboardWin.Native
Imports DevExpress.XtraEditors
Imports DevExpress.XtraLayout
Imports DevExpress.XtraPrinting.Export
Imports DreamyKitchenCRM.Main

Public Class Parameters
    Private Prog_Prop As New ProgProp
    Private Frm As frmParameters
    Private LoadForms As New FormLoader

    Public Sub Initialize(ByVal sFrm As frmParameters)
        Frm = sFrm
        'TODO: This line of code loads data into the 'DM_VALUELISTITEM.vw_VALUELISTITEM_V2' table. You can move, or remove it, as needed.
        Frm.Vw_VALUELISTITEM_V2TableAdapter.Fill(Frm.DM_VALUELISTITEM.vw_VALUELISTITEM_V2)
        'TODO: This line of code loads data into the 'DreamyKitchenDataSet1.MAILS' table. You can move, or remove it, as needed.
        Frm.MAILSTableAdapter.Fill(Frm.DreamyKitchenDataSet1.MAILS)
        'TODO: This line of code loads data into the 'DreamyKitchenDataSet.vw_BENCH' table. You can move, or remove it, as needed.
        Frm.Vw_BENCHTableAdapter.Fill(Frm.DreamyKitchenDataSet.vw_BENCH)
        'TODO: This line of code loads data into the 'DreamyKitchenDataSet.vw_COLORSPVC' table. You can move, or remove it, as needed.
        Frm.Vw_COLORSPVCTableAdapter.Fill(Frm.DreamyKitchenDataSet.vw_COLORSPVC)
        'TODO: This line of code loads data into the 'DreamyKitchenDataSet.vw_COLORSBOX' table. You can move, or remove it, as needed.
        Frm.Vw_COLORSBOXTableAdapter.Fill(Frm.DreamyKitchenDataSet.vw_COLORSBOX)
        'ΦΠΑ
        Frm.txtVAT.EditValue = Prog_Prop.GetProgvat()
        'Δεκαδικά Προγράμματος
        Frm.txtDecimals.EditValue = Prog_Prop.GetProgDecimals()
        'Technical Support Email
        Frm.txtEmail.EditValue = Prog_Prop.GetProgTechSupportEmail
    End Sub
    Public Sub SaveDefaultOffer()
        Prog_Prop.SetProgPROSF(Frm.LayoutControl6)
        Prog_Prop.SetProgPROSF(Frm.LayoutControl7)
        Prog_Prop.SetProgPROSF(Frm.LayoutControl8)
        Prog_Prop.SetProgPROSF(Frm.LayoutControl9)
        Prog_Prop.SetProgPROSF(Frm.LayoutControl10)
        Prog_Prop.GetProgPROSF()
        XtraMessageBox.Show("Η εγγραφή αποθηκέυτηκε με επιτυχία", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
    Public Sub SaveDefaultOrderGen()
        Prog_Prop.SetProgPROSF(Frm.LayoutControl12)
        Prog_Prop.GetProgPROSF()
        XtraMessageBox.Show("Η εγγραφή αποθηκέυτηκε με επιτυχία", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
    Public Sub SaveDefaultOrderCloset()
        Prog_Prop.SetProgPROSF(Frm.LayoutControl13)
        Prog_Prop.GetProgPROSF()
        XtraMessageBox.Show("Η εγγραφή αποθηκέυτηκε με επιτυχία", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
    Public Sub SaveDefaultOrderEquipment()
        InsertSelectedRows()
        InsertSelectedClosetRows()
        XtraMessageBox.Show("Η εγγραφή αποθηκέυτηκε με επιτυχία", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Public Sub SaveDefaultGen()
        'ΦΠΑ Προγράμματος
        Prog_Prop.SetProgVAT(Frm.txtVAT.EditValue)

        'Δεκαδικά Προγράμματος
        Prog_Prop.SetProgDecimals(Frm.txtDecimals.EditValue)

        'Email Support
        Prog_Prop.SetProgTechSupportEmail(Frm.txtEmail.EditValue)

    End Sub
    Public Sub SaveDefaultInstEmail()
        Prog_Prop.SetProgInstEmail(Frm.ELLIPSE_BODY_INF.Text, Frm.INSTALLATIONS_EMAIL.Text, Frm.ELLIPSE_SUBJECT_INF.Text, Frm.INSTALLATIONS_EMAIL_SUP.Text,
                                   Frm.ELLIPSE_SUBJECT_SUP_INF.Text, Frm.ELLIPSE_BODY_SUP_INF.Text, Frm.ELLIPSE_BODY_INF_APPOINTMENT.Text, Frm.INSTALLATIONS_SUBJECT_INF.Text,
                                   Frm.INSTALLATIONS_BODY_INF_APPOINTMENT.Text, Frm.ELLIPSE_SUBJECT_INF_APPOINTMENT.Text, Frm.ELLIPSE_SUBJECT_COMPLETE_INF.Text,
                                   Frm.ELLIPSE_BODY_COMPLETE_INF.Text)
        Prog_Prop.GetProgEmailInst(Frm.LayoutControl5)
        Prog_Prop.SetProgSupEmail(Frm.SUP_ORDERS_MAIL.Text)
        Prog_Prop.GetProgEmailSup(Frm.LayoutControlItem76)
        XtraMessageBox.Show("Η εγγραφή αποθηκέυτηκε με επιτυχία", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub
    Public Sub LoadDefaultGen()
        'ΦΠΑ
        Frm.txtVAT.EditValue = Prog_Prop.GetProgvat()
        'Δεκαδικά Προγράμματος
        Frm.txtDecimals.EditValue = Prog_Prop.GetProgDecimals()
        'Technical Support Email
        Frm.txtEmail.EditValue = Prog_Prop.GetProgTechSupportEmail
    End Sub

    Public Sub LoadDefaultOffer()
        Prog_Prop.GetProgPROSF(Frm.LayoutControl6)
        Prog_Prop.GetProgPROSF(Frm.LayoutControl7)
        Prog_Prop.GetProgPROSF(Frm.LayoutControl8)
        Prog_Prop.GetProgPROSF(Frm.LayoutControl9)
        Prog_Prop.GetProgPROSF(Frm.LayoutControl10)
    End Sub
    Public Sub LoadDefaultOrder()
        Prog_Prop.GetProgPROSF(Frm.LayoutControl12)
        Prog_Prop.GetProgPROSF(Frm.LayoutControl13)
    End Sub
    Public Sub LoadDefaultKitchenEquipment()
        LoadForms.LoadDataToGrid(Frm.grdEquipment, Frm.GridView2,
                    "Select  E.ID,E.code,name ,price,cast(case when (SELECT FLdVAL FROM PRM_DET WHERE TBL='EQUIPMENT' AND fld='ID' AND fldVal=e.id) is null then 0 else 1 end as bit) as  checked " &
                     "From vw_EQUIPMENT E where equipmentCatID='8AA21DC8-7D98-4596-8B73-9E664E955FFB' ORDER BY NAME")
        LoadForms.RestoreLayoutFromXml(Frm.GridView2, "CCT_ORDERS_KITCHEN_EQUIPMENT_PRM_def.xml")
        Frm.GridView2.Columns.Item("name").OptionsColumn.AllowEdit = False : Frm.GridView2.Columns.Item("code").OptionsColumn.AllowEdit = False : Frm.GridView2.Columns.Item("price").OptionsColumn.AllowEdit = False

    End Sub
    Public Sub LoadDefaultClosetEquipment()
        LoadForms.LoadDataToGrid(Frm.grdEquipmentCloset, Frm.GridView1,
                    "Select  E.ID,E.code,name ,price,cast(case when (SELECT FLdVAL FROM PRM_DET WHERE TBL='EQUIPMENT' AND fld='ID' AND fldVal=e.id) is null then 0 else 1 end as bit) as  checked " &
                     "From vw_EQUIPMENT E where equipmentCatID='DB158CAB-11EA-423B-9430-0C8A0CEB1D62' ORDER BY NAME")
        LoadForms.RestoreLayoutFromXml(Frm.GridView1, "CCT_ORDERS_KITCHEN_EQUIPMENT_CLOSET_PRM_def.xml")
        Frm.GridView1.Columns.Item("name").OptionsColumn.AllowEdit = False : Frm.GridView1.Columns.Item("code").OptionsColumn.AllowEdit = False : Frm.GridView1.Columns.Item("price").OptionsColumn.AllowEdit = False
    End Sub
    Public Sub LoadDefaultEmailInst()
        Prog_Prop.GetProgEmailInst(Frm.LayoutControl5)
        Prog_Prop.GetProgEmailSup(Frm.LayoutControlItem76)
        Frm.SUP_ORDERS_MAIL.EditValue = ProgProps.EmailOrders
    End Sub
    Private Sub InsertSelectedRows()
        Dim sSQL As String
        Dim I As Integer
        sSQL = "DELETE FROM PRM_DET WHERE tbl='EQUIPMENT'"
        Using oCmd As New SqlCommand(sSQL, CNDB)
            oCmd.ExecuteNonQuery()
        End Using
        Dim Selected As Boolean
        For I = 0 To Frm.GridView2.RowCount - 1
            Selected = Frm.GridView2.GetRowCellValue(I, "checked")
            If Selected = True Then
                sSQL = "INSERT INTO PRM_DET(TBL,FLD,fldVal,defVal)  VALUES ( 'EQUIPMENT','ID'," & toSQLValueS(Frm.GridView2.GetRowCellValue(I, "ID").ToString) & ",1)"
                Using oCmd As New SqlCommand(sSQL, CNDB)
                    oCmd.ExecuteNonQuery()
                End Using
            End If
        Next
    End Sub
    Private Sub InsertSelectedClosetRows()
        Dim sSQL As String
        Dim I As Integer
        'sSQL = "DELETE FROM PRM_DET WHERE tbl='EQUIPMENT'"
        'Using oCmd As New SqlCommand(sSQL, CNDB)
        '    oCmd.ExecuteNonQuery()
        'End Using
        Dim Selected As Boolean
        For I = 0 To Frm.GridView1.RowCount - 1
            Selected = Frm.GridView1.GetRowCellValue(I, "checked")
            If Selected = True Then
                sSQL = "INSERT INTO PRM_DET(TBL,FLD,fldVal,defVal)  VALUES ( 'EQUIPMENT','ID'," & toSQLValueS(Frm.GridView1.GetRowCellValue(I, "ID").ToString) & ",1)"
                Using oCmd As New SqlCommand(sSQL, CNDB)
                    oCmd.ExecuteNonQuery()
                End Using
            End If
        Next
    End Sub

End Class
