Imports System.Data.SqlClient
Imports DevExpress.XtraEditors
Imports DevExpress.XtraLayout
Imports DevExpress.XtraReports.UI

Public Class CusOfferOrderDoors
    Private Valid As New ValidateControls
    Private ID As String
    Private Cls As New ClearControls
    Private sIsOrder As Boolean
    Private Mode As Byte
    Private CalledFromCtrl As Boolean
    Private CtrlCombo As DevExpress.XtraEditors.LookUpEdit
    Private DBQ As New DBQueries
    Private LoadForms As New FormLoader
    Private Frm As frmCUSOfferOrderDoors
    Private Prog_Prop As New ProgProp
    Public Sub Initialize(ByVal sFrm As frmCUSOfferOrderDoors, ByVal sID As String, ByVal sMode As Byte, ByVal sCalledFromCtrl As Boolean, ByVal sCtrlCombo As DevExpress.XtraEditors.LookUpEdit, ByVal IsOrder As Boolean)
        Frm = sFrm
        ID = sID
        Mode = sMode
        CalledFromCtrl = sCalledFromCtrl
        CtrlCombo = sCtrlCombo
        sIsOrder = IsOrder
    End Sub
    Public Sub LoadForm()
        'TODO: This line of code loads data into the 'DM_TRANS.CCT_TRANSH' table. You can move, or remove it, as needed.
        Frm.CCT_TRANSHTableAdapter.Fill(Frm.DM_TRANS.CCT_TRANSH)
        'FrmODO: This line of code loads data into the 'DreamyKitchenDataSet.vw_CCT' table. You can move, or remove it, as needed.
        Frm.Vw_CCTTableAdapter.Fill(Frm.DreamyKitchenDataSet.vw_CCT)
        'FrmODO: This line of code loads data into the 'DM_VALUELISTITEM.vw_VALUELISTITEM_V2' table. You can move, or remove it, as needed.
        Frm.Vw_VALUELISTITEM_V2TableAdapter.Fill(Frm.DM_VALUELISTITEM.vw_VALUELISTITEM_V2)
        'FrmODO: This line of code loads data into the 'DMDataSet.CCT_TRANSH' table. You can move, or remove it, as needed.
        Frm.CCT_TRANSHTableAdapter.Fill(Frm.DM_TRANS.CCT_TRANSH)
        'FrmODO: This line of code loads data into the 'DreamyKitchenDataSet.vw_COLORSDOORS' table. You can move, or remove it, as needed.
        Frm.Vw_COLORSDOORSTableAdapter.Fill(Frm.DreamyKitchenDataSet.vw_COLORSDOORS)
        'FrmODO: This line of code loads data into the 'DreamyKitchenDataSet.vw_SALERS' table. You can move, or remove it, as needed.
        Frm.Vw_SALERSTableAdapter.Fill(Frm.DreamyKitchenDataSet.vw_SALERS)
        Frm.Vw_COLORS_CATTableAdapter.Fill(Frm.DreamyKitchenDataSet.vw_COLORS_CAT)
        Frm.Vw_SUPTableAdapter.Fill(Frm.DreamyKitchenDataSet.vw_SUP)
        Frm.Vw_CCT_ORDERS_PHOTOSTableAdapter.FillByOrderType(Frm.DM_CCT.vw_CCT_ORDERS_PHOTOS, 2, System.Guid.Parse(ID))
        Prog_Prop.GetProgPROSF()

        If sIsOrder = True Then
            ' LayoutControlItem41.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
            Frm.LayoutControlItem53.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
            Frm.LayoutControlItem54.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
            Frm.LayoutControlItem55.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
            Frm.LayoutControlItem69.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
            Frm.LayoutControlItem70.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
            Frm.LayoutControlItem72.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
            Frm.LofferAccepted.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
            Frm.LayoutControlGroup1.Text = "Στοιχεία Παραγγελίας"
            Frm.LayoutControlGroup4.Text = "Στοιχεία Παραγγελίας"
            Frm.LayoutControlItem30.Text = "Ημερ/νία Παραγγελίας"
        Else
            Frm.LayoutControlItem41.Tag = 0
            Frm.LayoutControlItem4.Text = "Αρ. Προσφοράς"
            Frm.LayoutControlGroup1.Text = "Στοιχεία Προσφοράς"
            Frm.LayoutControlGroup4.Text = "Στοιχεία Προσφοράς"
            Frm.LayoutControlItem30.Text = "Ημερ/νία Προσφοράς"
            Frm.LayoutControlGroup10.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
            Frm.TabNavigationPage2.PageVisible = False
            Frm.TabNavigationPage3.PageVisible = False
        End If
        Select Case Mode
            Case FormMode.NewRecord
                Frm.txtarProt.Text = DBQ.GetNextId("CCT_ORDERS_DOOR")
                Frm.cboEMP.EditValue = System.Guid.Parse(UserProps.ID.ToString.ToUpper)
                Frm.txtdtdaysOfDelivery.EditValue = ProgProps.DAYS_OF_DELIVERY
                Frm.txtDescription.EditValue = ProgProps.DOOR_DESCRIPTION
                Frm.txtComments.EditValue = ProgProps.DOOR_CMT
                Frm.txtNotes.EditValue = ProgProps.CUS_NOTES
                Frm.txtTransp.EditValue = ProgProps.DoorTransp
                Frm.txtMeasurement.EditValue = ProgProps.DoorMeasurement
                Frm.txtRemove.EditValue = ProgProps.DoorRemove
                'cmdConvertToOrder.Enabled = False
                Frm.LayoutControlItem7.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
            Case FormMode.EditRecord
                Dim sFields As New Dictionary(Of String, String)
                LoadForms.LoadForm(Frm.LayoutControl1, "Select [ORDER].id as OrderID,CCT_ORDERS_DOOR.* " &
                                                   " from CCT_ORDERS_DOOR " &
                                                   " left join CCT_ORDERS_DOOR  [ORDER] on [ORDER].CreatedFromOfferID =  CCT_ORDERS_DOOR.id " &
                                                   " where CCT_ORDERS_DOOR.id = " & toSQLValueS(ID), sFields)
                If sIsOrder = False Then
                    If sFields("OrderID") <> "" Then
                        'cmdConvertToOrder.Enabled = False
                        Frm.LayoutControlItem7.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
                        Frm.cmdSave.Enabled = False
                        Frm.LabelControl1.Text = "Δεν μπορείτε να κάνετε αλλαγές στην προσφορά γιατί έχει δημιουργηθεί παραγγελία."
                    End If
                Else
                    Frm.LayoutControlItem7.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
                    If sFields("CreatedFromOfferID") <> "" Then
                        Frm.cboCUS.Enabled = False
                        Frm.cboCompany.Enabled = False
                        Frm.cboCompProject.Enabled = False
                        Frm.cboTRANSH.Enabled = False
                    End If

                End If


                sFields = Nothing

        End Select

    End Sub
    Public Sub SaveRecord(ByRef sID As String)
        Dim sResult As Boolean
        Dim sGuid As String
        Try
            If Valid.ValiDationRules(Frm.Name, Frm) = False Then Exit Sub
            If Valid.ValidateForm(Frm.LayoutControl1) Then
                Select Case Mode
                    Case FormMode.NewRecord
                        sGuid = System.Guid.NewGuid.ToString
                        Dim sDate As String = Frm.lblDate.Text.Replace("Ημερομηνία Παράδοσης: ", "")
                        sResult = DBQ.InsertNewData(DBQueries.InsertMode.OneLayoutControl, "CCT_ORDERS_DOOR", Frm.LayoutControl1,,, sGuid, , "dtDeliver,IsOrder", toSQLValueS(CDate(sDate).ToString("yyyyMMdd")) & "," & IIf(sIsOrder = True, 1, 0))
                        ID = sGuid : sID = ID
                    Case FormMode.EditRecord
                        Dim sDate As String = Frm.lblDate.Text.Replace("Ημερομηνία Παράδοσης: ", "")
                        sResult = DBQ.UpdateNewData(DBQueries.InsertMode.OneLayoutControl, "CCT_ORDERS_DOOR", Frm.LayoutControl1,,, sID, ,,,, "dtDeliver=" & toSQLValueS(CDate(sDate).ToString("yyyyMMdd")) & ",IsOrder = " & IIf(sIsOrder = True, 1, 0))
                        sGuid = ID : sID = ID
                End Select


                If sResult = True Then
                    XtraMessageBox.Show("Η εγγραφή αποθηκέυτηκε με επιτυχία", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    If Mode = FormMode.NewRecord Then
                        Mode = FormMode.EditRecord
                        'cmdConvertToOrder.Enabled = True
                        Frm.LayoutControlItem7.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
                    End If
                    If sIsOrder Then
                        Dim HasKitchen As Boolean, HasCloset As Boolean, HasDoors As Boolean, HasSc As Boolean
                        HasKitchen = Frm.cboTRANSH.GetColumnValue("Iskitchen")
                        HasCloset = Frm.cboTRANSH.GetColumnValue("Iscloset")
                        HasDoors = Frm.cboTRANSH.GetColumnValue("Isdoor")
                        HasSc = Frm.cboTRANSH.GetColumnValue("Issc")
                        If HasKitchen = False And HasCloset = False And HasDoors = False And HasSc = False Then
                            XtraMessageBox.Show("Κοστολόγηση δεν θα δημιουργηθεί λόγω έλλειψης συμφωνητικού", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                            Exit Sub
                        End If
                        Dim cmd As SqlCommand
                        Dim sdr As SqlDataReader
                        Dim sSQL As String
                        Dim cctOrderKitchen As String = "00000000-0000-0000-0000-000000000000"

                        sSQL = "select ID from CCT_ORDERS_KITCHEN where transhID = " & (toSQLValueS(Frm.cboTRANSH.EditValue.ToString))
                        cmd = New SqlCommand(sSQL, CNDB)
                        sdr = cmd.ExecuteReader()
                        If (sdr.Read() = True) Then
                            If sdr.IsDBNull(sdr.GetOrdinal("ID")) = False Then cctOrderKitchen = sdr.GetGuid(sdr.GetOrdinal("ID")).ToString
                        End If
                        sdr.Close()
                        cmd.Dispose()
                        ' Δημιουργία/Ενημέρωση Κοστολόγησης
                        Using oCmd As New SqlCommand("usp_InsertOrUpdateTransCost", CNDB)
                            oCmd.CommandType = CommandType.StoredProcedure
                            oCmd.Parameters.AddWithValue("@transhID", Frm.cboTRANSH.EditValue.ToString)
                            oCmd.Parameters.AddWithValue("@cctOrderKitchenID", System.Guid.Parse(cctOrderKitchen))
                            oCmd.Parameters.AddWithValue("@Mode", 3)
                            oCmd.Parameters.AddWithValue("@UserID", UserProps.ID.ToString)
                            oCmd.ExecuteNonQuery()
                        End Using
                    End If
                End If
            End If

        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Public Sub PrintOfferOrder()
        If sIsOrder Then
            Dim report As New RepCUSOrderDoors()
            report.Parameters.Item(0).Value = ID
            report.CreateDocument()
            Dim printTool As New ReportPrintTool(report)
            printTool.ShowRibbonPreview()
        Else
            Dim report As New RepCUSOfferDoors()
            report.Parameters.Item(0).Value = ID
            report.CreateDocument()
            Dim printTool As New ReportPrintTool(report)
            printTool.ShowRibbonPreview()
        End If
    End Sub
    Public Sub ConvertToOrder()
        Try
            If XtraMessageBox.Show("Θέλετε να μετατραπεί σε παραγγελία η προσφορά ?", ProgProps.ProgTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                Using oCmd As New SqlCommand("ConvertToOrder", CNDB)
                    oCmd.CommandType = CommandType.StoredProcedure
                    oCmd.Parameters.AddWithValue("@OfferID", ID)
                    oCmd.Parameters.AddWithValue("@createdBy", UserProps.ID)
                    oCmd.Parameters.AddWithValue("@Mode", 3)
                    oCmd.ExecuteNonQuery()
                End Using
                XtraMessageBox.Show("Η μετατροπή ολοκληρώθηκε με επιτυχία", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Information)
                'cmdConvertToOrder.Enabled = False
                Frm.cmdSave.Enabled = False
                Frm.LayoutControlItem7.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
                Frm.LabelControl1.Text = "Δεν μπορείτε να κάνετε αλλαγές στην προσφορά γιατί έχει δημιουργηθεί παραγγελία."
            End If
        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Public Sub SavePhotoRecord(ByVal sID As String, ByVal LocalMode As Integer)
        Dim sResult As Boolean
        Dim sGuid As String
        Try
            If Valid.ValidateForm(Frm.LayoutControl3) Then
                Select Case LocalMode
                    Case FormMode.NewRecord
                        sGuid = System.Guid.NewGuid.ToString
                        sResult = DBQ.InsertNewData(DBQueries.InsertMode.OneLayoutControl, "CCT_ORDERS_PHOTOS", Frm.LayoutControl3,,, sGuid, , "orderID,orderType", toSQLValueS(sID) & ",2")
                    Case FormMode.EditRecord
                        sResult = DBQ.UpdateDataCardGRD(Frm.CardView1, "CCT_ORDERS_PHOTOS",, True)
                End Select
                If sResult = True Then
                    XtraMessageBox.Show("Η εγγραφή αποθηκέυτηκε με επιτυχία", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Cls.ClearCtrls(Frm.LayoutControl3)
                    Frm.Vw_CCT_ORDERS_PHOTOSTableAdapter.FillByOrderType(Frm.DM_CCT.vw_CCT_ORDERS_PHOTOS, 0, System.Guid.Parse(sID))
                End If
            End If

        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Public Sub DeletePhotoRecord()
        If Frm.CardView1.GetRowCellValue(Frm.CardView1.FocusedRowHandle, "ID") = Nothing Then Exit Sub
        If XtraMessageBox.Show("Θέλετε να διαγραφεί η τρέχουσα εγγραφή?", ProgProps.ProgTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            Dim sSQL As String = "DELETE FROM CCT_ORDERS_PHOTOS WHERE ID = '" & Frm.CardView1.GetRowCellValue(Frm.CardView1.FocusedRowHandle, "ID").ToString & "'"
            Using oCmd As New SqlCommand(sSQL, CNDB)
                oCmd.ExecuteNonQuery()
            End Using
            Frm.Vw_CCT_ORDERS_PHOTOSTableAdapter.FillByOrderType(Frm.DM_CCT.vw_CCT_ORDERS_PHOTOS, 0, System.Guid.Parse(ID))
        End If
    End Sub

End Class
