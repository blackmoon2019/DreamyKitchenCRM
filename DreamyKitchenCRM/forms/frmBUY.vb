Imports System.Data.SqlClient
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGrid.Views.Base

Public Class frmBUY
    Private sID As String
    Private Ctrl As DevExpress.XtraGrid.Views.Grid.GridView
    Private Frm As DevExpress.XtraEditors.XtraForm
    Public Mode As Byte
    Private ManageCbo As New CombosManager
    Private Valid As New ValidateControls
    Private FScrollerExist As Boolean = False
    Private FillCbo As New FillCombos
    Private DBQ As New DBQueries
    Private LoadForms As New FormLoader
    Private Cls As New ClearControls
    Private CtrlCombo As DevExpress.XtraEditors.LookUpEdit
    Private CalledFromCtrl As Boolean
    Private WorkingTime As Integer
    Private AgreementSalary As Double
    Private UserPermissions As New CheckPermissions
    Private Multiplier As Integer

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
    Public WriteOnly Property FormScrollerExist As Boolean
        Set(value As Boolean)
            FScrollerExist = value
        End Set
    End Property
    Private Sub cmdExit_Click(sender As Object, e As EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub
    Private Sub frmBUY_Load(sender As Object, e As EventArgs) Handles Me.Load
        'TODO: This line of code loads data into the 'DMDataSet.CCT_TRANSH' table. You can move, or remove it, as needed.
        Me.CCT_TRANSHTableAdapter.Fill(Me.DMDataSet.CCT_TRANSH)

        'FillCbo.CUS(cboCUS)
        FillCbo.SUP(cboSUP)
        FillCbo.BUY_C(cbobuyC)
        FillCbo.PAY(cboPAY)
        AddHandler GridControl1.EmbeddedNavigator.ButtonClick, AddressOf Grid_EmbeddedNavigator_ButtonClick


        Select Case Mode
            Case FormMode.NewRecord
                txtCode.Text = DBQ.GetNextId("BUY")
                LayoutControlItem25.Enabled = False
            Case FormMode.EditRecord
                LoadForms.LoadForm(LayoutControl1, "Select * from vw_BUY where id ='" + sID + "'")
                Me.Vw_BUY_OTableAdapter.FillbyBuyID(Me.DMDataSet.vw_BUY_O, System.Guid.Parse(sID))
                Dim sCusID As String
                If cboCUS.EditValue Is Nothing Then sCusID = Guid.Empty.ToString Else sCusID = cboCUS.EditValue.ToString
                Me.Vw_TRANSHTableAdapter.Fill(Me.DreamyKitchenDataSet.vw_TRANSH, System.Guid.Parse(sCusID))
                If cboSUP.EditValue IsNot Nothing Then Me.Vw_DOC_TYPESTableAdapter.FillBySupID(Me.DMDataSet.vw_DOC_TYPES, System.Guid.Parse(cboSUP.EditValue.ToString))
                Multiplier = cboDocType.GetColumnValue("Vmultiplier") : If Multiplier = 0 Then Multiplier = 1
        End Select
        Me.CenterToScreen()
        cmdSave.Enabled = IIf(Mode = FormMode.NewRecord, UserProps.AllowInsert, UserProps.AllowEdit)
        'If chkPaid.Checked = True Then cmdSave.Enabled = False
    End Sub
    Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click
        Dim sResult As Boolean
        Dim sGuid As String
        Dim sSQL As String
        Try
            If Valid.ValidateForm(LayoutControl1) Then

                Select Case Mode
                    Case FormMode.NewRecord
                        sGuid = System.Guid.NewGuid.ToString
                        sResult = DBQ.InsertNewData(DBQueries.InsertMode.OneLayoutControl, "BUY", LayoutControl1,,, sGuid, True)
                        sID = sGuid
                    Case FormMode.EditRecord
                        sResult = DBQ.UpdateNewData(DBQueries.InsertMode.OneLayoutControl, "BUY", LayoutControl1,,, sID, True)
                        'sGuid = sID
                End Select

                'If FScrollerExist = True Then
                '    Dim form As frmScroller = Frm
                '    form.LoadRecords("vw_BUY")
                'End If

                If sResult = True Then
                    XtraMessageBox.Show("Η εγγραφή αποθηκέυτηκε με επιτυχία", "Dreamy Kitchen CRM", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    LayoutControlItem25.Enabled = True
                    If Mode = FormMode.NewRecord Then Mode = FormMode.EditRecord

                    ' ΚΑΝΕΛΛΟΠΟΥΛΟΣ
                    If cboSUP.EditValue.ToString.ToUpper = "89251045-64C7-4E35-9CAF-51D020279CFE" Then
                        Dim sTranshID As String, cctID As String
                        If cboTRANSH.EditValue = Nothing Then sTranshID = "" Else sTranshID = cboTRANSH.EditValue.ToString
                        If cboCUS.EditValue = Nothing Then cctID = "" Else cctID = cboCUS.EditValue.ToString

                        'Ενημέρωση πίνακα KANELLOPOYLOS με έργο - πελάτη
                        Using oCmd As New SqlCommand("UPDATE KANELLOPOULOS SET transhID = " & toSQLValueS(sTranshID) & ", cctID = " & toSQLValueS(cctID) & " where buyID = " & toSQLValueS(sID), CNDB)
                            oCmd.ExecuteNonQuery()
                        End Using
                    End If
                    'Ενημέρωση υπολοίπου προμηθευτή όταν το τιμολόγιο δεν είναι πληρωμένο και δεν είναι μετρητοίς
                    Using oCmd As New SqlCommand("FIX_SUP_BAL", CNDB)
                        oCmd.CommandType = CommandType.StoredProcedure
                        oCmd.Parameters.AddWithValue("@supplierID", cboSUP.EditValue.ToString)
                        oCmd.ExecuteNonQuery()
                    End Using
                    sSQL = "DELETE FROM SUP_PAYMENTS_P  WHERE buyID = " & toSQLValueS(sID)
                    Using oCmd As New SqlCommand(sSQL, CNDB)
                        oCmd.ExecuteNonQuery()
                    End Using
                    sSQL = "INSERT SUP_PAYMENTS_P  SELECT NEWID(),ID,vatAmount from BUY WHERE ID = " & toSQLValueS(sID)
                    Using oCmd As New SqlCommand(sSQL, CNDB)
                        oCmd.ExecuteNonQuery()
                    End Using


                    If cboTRANSH.EditValue IsNot Nothing Then
                        ' Άνοιγμα έργου αν δεν υπάρχει ή ενημέρωση ποσών
                        Using oCmd As New SqlCommand("usp_CreateProjectcost", CNDB)
                            oCmd.CommandType = CommandType.StoredProcedure
                            oCmd.Parameters.AddWithValue("@transhID", cboTRANSH.EditValue.ToString)
                            oCmd.ExecuteNonQuery()
                        End Using
                    End If


                End If
            End If

        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), "Dreamy Kitchen CRM", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub cboCUS_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboCUS.ButtonClick
        Select Case e.Button.Index
            Case 1 : ManageCbo.ManageCCT(FormMode.NewRecord, False,, cboCUS)
            Case 2 : ManageCbo.ManageCCT(FormMode.EditRecord, False,, cboCUS)
            Case 3 : cboCUS.EditValue = Nothing
        End Select
    End Sub
    Private Sub cboCUS_EditValueChanged(sender As Object, e As EventArgs) Handles cboCUS.EditValueChanged
        If Me.isFormPainted = False Then Exit Sub
        Dim sCusID As String
        If cboCUS.EditValue Is Nothing Then sCusID = Guid.Empty.ToString Else sCusID = cboCUS.EditValue.ToString
        Me.Vw_TRANSHTableAdapter.Fill(Me.DreamyKitchenDataSet.vw_TRANSH, System.Guid.Parse(sCusID))
    End Sub

    Private Sub frmBUY_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        If Me.WindowState = FormWindowState.Maximized Then frmMain.XtraTabbedMdiManager1.Dock(Me, frmMain.XtraTabbedMdiManager1)
    End Sub
    Private Sub cboTRANSH_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboTRANSH.ButtonClick
        Select Case e.Button.Index
            Case 1 : ManageCbo.ManageTRANSH(cboTRANSH, FormMode.NewRecord)
            Case 2 : ManageCbo.ManageTRANSH(cboTRANSH, FormMode.EditRecord)
            Case 3 : cboTRANSH.EditValue = Nothing
        End Select
    End Sub

    Private Sub cboSUP_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboSUP.ButtonClick
        Select Case e.Button.Index
            Case 1 : ManageCbo.ManageSup(cboSUP, FormMode.NewRecord)
            Case 2 : ManageCbo.ManageSup(cboSUP, FormMode.EditRecord)
            Case 3 : cboSUP.EditValue = Nothing
        End Select
    End Sub

    Private Sub cbobuyC_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cbobuyC.ButtonClick
        Select Case e.Button.Index
            Case 1 : ManageCbo.ManageBUY_C(cbobuyC, FormMode.NewRecord)
            Case 2 : ManageCbo.ManageBUY_C(cbobuyC, FormMode.EditRecord)
            Case 3 : cbobuyC.EditValue = Nothing
        End Select
    End Sub
    Private Sub txtnetAmount_EditValueChanged(sender As Object, e As EventArgs) Handles txtnetAmount.EditValueChanged
        If Me.isFormPainted = False Then Exit Sub
        Dim Net As Double, Vat As Double
        If txtnetAmount.EditValue Is Nothing Or txtvatAmount.EditValue Is Nothing Then Exit Sub
        Net = DbnullToZero(txtnetAmount) : Vat = DbnullToZero(txtvatAmount)
        Net = Math.Abs(Net) * Multiplier
        txtvatAmount.EditValue = Net * 1.24
    End Sub

    Private Sub txtDevicesBuy_EditValueChanged(sender As Object, e As EventArgs) Handles txtDevicesBuy.EditValueChanged
        If Me.isFormPainted Then txtnetAmount.EditValue = CalculateNetAmount()
    End Sub
    Private Function CalculateNetAmount() As Double
        Dim DevicesBuy As Double, bathroomFurn As Double, closet As Double, general As Double, materials As Double, kitchen As Double, Total As Double
        Dim Bench As Double, transportation As Double, glasses As Double, measurement As Double
        DevicesBuy = DbnullToZero(txtDevicesBuy) : bathroomFurn = DbnullToZero(txtbathroomFurn) : closet = DbnullToZero(txtcloset)
        transportation = DbnullToZero(txttransportation) : Bench = DbnullToZero(txtbench) : glasses = DbnullToZero(txtglasses)
        general = DbnullToZero(txtgeneral) : materials = DbnullToZero(txtmaterials) : kitchen = DbnullToZero(txtkitchen)
        measurement = DbnullToZero(txtmeasurement)
        Total = DevicesBuy + bathroomFurn + closet + general + materials + kitchen + transportation + Bench + glasses + measurement
        Total = Math.Abs(Total) * Multiplier
        Return Total
    End Function

    Private Sub txtkitchen_EditValueChanged(sender As Object, e As EventArgs) Handles txtkitchen.EditValueChanged
        If Me.isFormPainted Then txtnetAmount.EditValue = CalculateNetAmount()
    End Sub

    Private Sub txtcloset_EditValueChanged(sender As Object, e As EventArgs) Handles txtcloset.EditValueChanged
        If Me.isFormPainted Then txtnetAmount.EditValue = CalculateNetAmount()
    End Sub

    Private Sub txtbathroomFurn_EditValueChanged(sender As Object, e As EventArgs) Handles txtbathroomFurn.EditValueChanged
        If Me.isFormPainted Then txtnetAmount.EditValue = CalculateNetAmount()
    End Sub

    Private Sub txtmaterials_EditValueChanged(sender As Object, e As EventArgs) Handles txtmaterials.EditValueChanged
        If Me.isFormPainted Then txtnetAmount.EditValue = CalculateNetAmount()
    End Sub

    Private Sub txtgeneral_EditValueChanged(sender As Object, e As EventArgs) Handles txtgeneral.EditValueChanged
        If Me.isFormPainted Then txtnetAmount.EditValue = CalculateNetAmount()
    End Sub


    Private Sub cboPAY_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboPAY.ButtonClick
        Select Case e.Button.Index
            Case 1 : ManageCbo.ManagePAY(cboPAY, FormMode.NewRecord)
            Case 2 : ManageCbo.ManagePAY(cboPAY, FormMode.EditRecord)
            Case 3 : cboPAY.EditValue = Nothing
        End Select
    End Sub

    Private Sub cboSUP_EditValueChanged(sender As Object, e As EventArgs) Handles cboSUP.EditValueChanged
        If Me.isFormPainted = False Then Exit Sub
        cboPAY.EditValue = cboSUP.GetColumnValue("payID")
        If cboPAY.EditValue = Nothing Then Exit Sub
        If cboPAY.EditValue.ToString.ToUpper = "88E7A725-AE4C-4818-ADEE-7F9E26F20165" Then chkPaid.CheckState = CheckState.Checked Else chkPaid.CheckState = CheckState.Unchecked
        Me.Vw_DOC_TYPESTableAdapter.FillBySupID(Me.DMDataSet.vw_DOC_TYPES, System.Guid.Parse(cboSUP.EditValue.ToString))
        MaxOrd()
    End Sub

    Private Sub txttransportation_EditValueChanged(sender As Object, e As EventArgs) Handles txttransportation.EditValueChanged
        If Me.isFormPainted Then txtnetAmount.EditValue = CalculateNetAmount()
    End Sub

    Private Sub txtglasses_EditValueChanged(sender As Object, e As EventArgs) Handles txtglasses.EditValueChanged
        If Me.isFormPainted Then txtnetAmount.EditValue = CalculateNetAmount()
    End Sub

    Private Sub txtbench_EditValueChanged(sender As Object, e As EventArgs) Handles txtbench.EditValueChanged
        If Me.isFormPainted Then txtnetAmount.EditValue = CalculateNetAmount()
    End Sub

    Private Sub txtmeasurement_EditValueChanged(sender As Object, e As EventArgs) Handles txtmeasurement.EditValueChanged
        If Me.isFormPainted Then txtnetAmount.EditValue = CalculateNetAmount()
    End Sub

    Private Sub GridView1_KeyDown(sender As Object, e As KeyEventArgs) Handles GridView1.KeyDown
        If e.KeyCode = Keys.Delete And UserProps.AllowDelete = True Then DeleteRecord()
        If e.KeyCode = Keys.Down And UserProps.AllowInsert Then GridView1.AddNewRow()
    End Sub
    Private Sub DeleteRecord()
        If GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "ID") = Nothing Then Exit Sub
        If XtraMessageBox.Show("Θέλετε να διαγραφεί η τρέχουσα εγγραφή?", "Dreamy Kitchen CRM", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            Dim sSQL As String = "DELETE FROM BUY_O WHERE ID = '" & GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "ID").ToString & "'"
            Using oCmd As New SqlCommand(sSQL, CNDB)
                oCmd.ExecuteNonQuery()
            End Using
            Me.Vw_BUY_OTableAdapter.FillbyBuyID(Me.DMDataSet.vw_BUY_O, System.Guid.Parse(sID))
        End If
    End Sub


    Private Sub GridView1_ValidateRow(sender As Object, e As ValidateRowEventArgs) Handles GridView1.ValidateRow
        Dim sSQL As New System.Text.StringBuilder
        Try
            sSQL.Clear()
            If e.RowHandle = GridControl1.NewItemRowHandle Then
                If GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "name").ToString = "" Then
                    e.ErrorText = "Παρακαλώ συμπληρώστε το Αριθμό Δελτίου Παραγγελίας"
                    e.Valid = False
                    Exit Sub
                End If
                sSQL.AppendLine("INSERT INTO BUY_O (buyID,name,[modifiedBy],[createdby],[createdOn])")
                sSQL.AppendLine("Select " & toSQLValueS(sID) & ",")
                sSQL.AppendLine(toSQLValueS(GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "name").ToString) & ",")
                sSQL.Append(toSQLValueS(UserProps.ID.ToString) & "," & toSQLValueS(UserProps.ID.ToString) & ", getdate()")
                'Εκτέλεση QUERY
                Using oCmd As New SqlCommand(sSQL.ToString, CNDB)
                    oCmd.ExecuteNonQuery()
                End Using
                Me.Vw_BUY_OTableAdapter.FillbyBuyID(Me.DMDataSet.vw_BUY_O, System.Guid.Parse(sID))
            Else
                sSQL.AppendLine("UPDATE BUY_O	SET name= " & toSQLValueS(GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "name").ToString) & ",")
                sSQL.AppendLine("modifiedBY = " & toSQLValueS(UserProps.ID.ToString) & ",")
                sSQL.AppendLine("modifiedON = getdate() ")
                sSQL.AppendLine("WHERE ID = " & toSQLValueS(GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "ID").ToString))
                'Εκτέλεση QUERY
                Using oCmd As New SqlCommand(sSQL.ToString, CNDB)
                    oCmd.ExecuteNonQuery()
                End Using
                Me.Vw_BUY_OTableAdapter.FillbyBuyID(Me.DMDataSet.vw_BUY_O, System.Guid.Parse(sID))
            End If
        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), "Dreamy Kitchen CRM", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub Grid_EmbeddedNavigator_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.NavigatorButtonClickEventArgs)
        Select Case e.Button.ButtonType
            Case e.Button.ButtonType.Remove : DeleteRecord() : e.Handled = True
        End Select
    End Sub

    Private Sub GridView1_InvalidRowException(sender As Object, e As InvalidRowExceptionEventArgs) Handles GridView1.InvalidRowException
        e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction
    End Sub

    Private Sub cboDocType_EditValueChanged(sender As Object, e As EventArgs) Handles cboDocType.EditValueChanged
        If Me.isFormPainted = False Then Exit Sub
        Multiplier = cboDocType.GetColumnValue("Vmultiplier") : If Multiplier = 0 Then Multiplier = 1
        Dim Net As Double = txtnetAmount.EditValue, Vat As Double = txtvatAmount.EditValue
        txtnetAmount.EditValue = Math.Abs(Net) * Multiplier
        txtvatAmount.EditValue = Math.Abs(Vat) * Multiplier
    End Sub

    Private Sub cboDocType_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboDocType.ButtonClick
        Select Case e.Button.Index
            Case 1 : ManageCbo.ManageDOCTYPES(cboDocType, FormMode.NewRecord)
            Case 2 : ManageCbo.ManageDOCTYPES(cboDocType, FormMode.EditRecord)
            Case 3 : cboDocType.EditValue = Nothing
        End Select

    End Sub

    Private Sub dtBuy_EditValueChanged(sender As Object, e As EventArgs) Handles dtBuy.EditValueChanged
        MaxOrd()
    End Sub
    Private Sub MaxOrd()
        If Me.isFormPainted = False Then Exit Sub
        If cboSUP.EditValue Is Nothing Or dtBuy.EditValue Is Nothing Then Exit Sub
        ' Παίρνει το μεγαλύτερο Α/Α και το αυξάνει κατα 1
        Dim cmd As SqlCommand = New SqlCommand("Select  MAX(ORD) + 1 As ORD FROM BUY WHERE supID= " & toSQLValueS(cboSUP.EditValue.ToString) & " and dtYBuy = " & toSQLValueS(Year(dtBuy.EditValue.ToString)), CNDB)
        Dim sdr As SqlDataReader = cmd.ExecuteReader()
        If (sdr.Read() = True) Then
            If sdr.IsDBNull(sdr.GetOrdinal("ORD")) = False Then txtOrd.EditValue = sdr.GetInt32(sdr.GetOrdinal("ORD")) Else txtOrd.EditValue = 1
        End If
    End Sub

    Private Sub txtvatAmount_EditValueChanging(sender As Object, e As ChangingEventArgs) Handles txtvatAmount.EditValueChanging
        If Me.isFormPainted = False Then Exit Sub
        Dim CountP As Integer
        If e.OldValue <> e.NewValue Then
            Dim cmd As SqlCommand = New SqlCommand("Select count(ID) as CountP FROM SUP_PAYMENTS_D WHERE buyID= " & toSQLValueS(sID), CNDB)
            Dim sdr As SqlDataReader = cmd.ExecuteReader()
            If (sdr.Read() = True) Then
                If sdr.IsDBNull(sdr.GetOrdinal("CountP")) = False Then CountP = sdr.GetInt32(sdr.GetOrdinal("CountP")) Else CountP = 0
                If CountP > 0 Then
                    XtraMessageBox.Show("Δεν μπορείτε να μεταβάλετε ποσό παραστατικού όταν έχουν πραγματοποιηθεί πληρωμές. " & vbCrLf &
                        "Πρέπει να σβήσετε τις πληρωμές και μετά να αλλάξετε το παραστατικό ή να σβήσετε όλο το παραστατικό.", "Dreamy Kitchen CRM", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    e.Cancel = True
                End If
            End If
        End If
    End Sub
End Class