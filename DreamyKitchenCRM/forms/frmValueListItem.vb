Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DreamyKitchenCRM.DreamyKitchenDataSetTableAdapters
Imports Org.BouncyCastle.Asn1

Public Class frmValueListItem
    Private sID As String
    Private sGroupName As String
    Private Ctrl As DevExpress.XtraGrid.Views.Grid.GridView
    Private Frm As DevExpress.XtraEditors.XtraForm
    Public Mode As Byte
    Private Valid As New ValidateControls
    Private Log As New Transactions
    Private FillCbo As New FillCombos
    Private DBQ As New DBQueries
    Private LoadForms As New FormLoader
    Private Cls As New ClearControls
    Private CtrlCombo As DevExpress.XtraEditors.LookUpEdit
    Private CtrlComboChecked As DevExpress.XtraEditors.CheckedComboBoxEdit
    Private ManageCbo As New CombosManager
    Private CalledFromCtrl As Boolean
    Private sValueListID As String


    Public WriteOnly Property ValueListID As String
        Set(value As String)
            sValueListID = value
        End Set
    End Property
    Public WriteOnly Property ID As String
        Set(value As String)
            sID = value
        End Set
    End Property
    Public WriteOnly Property GroupName As String
        Set(value As String)
            sGroupName = value
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
    Public WriteOnly Property CallerControlChecked As DevExpress.XtraEditors.CheckedComboBoxEdit
        Set(value As DevExpress.XtraEditors.CheckedComboBoxEdit)
            CtrlComboChecked = value
        End Set
    End Property

    Public WriteOnly Property CalledFromControl As Boolean
        Set(value As Boolean)
            CalledFromCtrl = value
        End Set
    End Property
    Private Sub cmdExit_Click(sender As Object, e As EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub

    Private Sub frmVALUELISTITEM_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        If Me.WindowState = FormWindowState.Maximized Then frmMain.XtraTabbedMdiManager1.Dock(Me, frmMain.XtraTabbedMdiManager1)
    End Sub

    Private Sub frmVALUELISTITEM_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.Vw_SUPTableAdapter.Fill(Me.DreamyKitchenDataSet.vw_SUP)
        If sGroupName Is Nothing Then Me.Vw_VALUELISTTableAdapter.Fill(Me.DM_VALUELISTITEM.vw_VALUELIST) Else Me.Vw_VALUELISTTableAdapter.FillByGroupName(Me.DM_VALUELISTITEM.vw_VALUELIST, sGroupName)
        Me.Vw_DIMTableAdapter.Fill(Me.DreamyKitchenDataSet.vw_DIM)
        Me.Vw_COLORSBOXTableAdapter.Fill(Me.DreamyKitchenDataSet.vw_COLORSBOX)
        If Mode = FormMode.EditRecord Then cboValueList.EditValue = System.Guid.Parse(sValueListID)
        ShowRequiredItems()
        Select Case Mode
            Case FormMode.NewRecord
                txtCode.Text = DBQ.GetNextId("valueListItem")
            Case FormMode.EditRecord
                LoadForms.LoadForm(LayoutControl1, "Select * from valueListItem where id ='" + sID + "'")
        End Select

        Me.CenterToScreen()
        cmdSave.Enabled = IIf(Mode = FormMode.NewRecord, UserProps.AllowInsert, UserProps.AllowEdit)
    End Sub
    Private Sub ShowRequiredItems()
        If cboValueList.EditValue = Nothing Then
            LName.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
            LName.ImageOptions.Image = Global.DreamyKitchenCRM.My.Resources.Resources.rsz_11rsz_asterisk
            LName.Tag = "1"
            LDescription.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
            Exit Sub
        End If
        Select Case cboValueList.EditValue.ToString.ToUpper
            Case "3C68F058-6A47-4995-8B0C-26538F38580A" ' Μοντέλα Κουζίνας
                Me.Text = "Μοντέλα Κουζίνας"
                LName.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
                LName.ImageOptions.Image = Global.DreamyKitchenCRM.My.Resources.Resources.rsz_11rsz_asterisk
                LName.Tag = "1"
                LDescription.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
                cboValueList.ReadOnly = True
            Case "AFDD6E1A-EBA3-4FE9-AB28-EDE277939F29"  ' Ντουλάπες
                Me.Text = "Μοντέλα Ντουλαπών"
                LCat.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
                LName.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
                LName.ImageOptions.Image = Global.DreamyKitchenCRM.My.Resources.Resources.rsz_11rsz_asterisk
                LName.Tag = "1"
                LDescription.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
                cboValueList.ReadOnly = True
            Case "D08B9371-F94A-48F9-8021-C1661120ED8C" ' Πάγκοι
                Me.Text = "Πάγκοι"
                LCat.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
                LName.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
                LName.ImageOptions.Image = Global.DreamyKitchenCRM.My.Resources.Resources.rsz_11rsz_asterisk
                LName.Tag = "1"
                LDescription.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
                Lprice.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
                cboValueList.ReadOnly = False
            Case "DE86FD16-2154-4E2A-B025-4D34BDF8C808" ' Κωδικοί Χρωμάτων
                Me.Text = "Κωδικοί Χρωμάτων"
                LCat.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
                LName.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
                LName.ImageOptions.Image = Global.DreamyKitchenCRM.My.Resources.Resources.rsz_11rsz_asterisk
                LName.Tag = "1"
                LDescription.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
                Lprice.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
                cboValueList.ReadOnly = False
            Case "CF47FAEE-7CD7-49AD-9455-3BC69D438DE9" ' Ειδικές Κατασκευές
                Me.Text = "Ειδικές Κατασκευές"
                LCat.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
                LName.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
                LName.ImageOptions.Image = Global.DreamyKitchenCRM.My.Resources.Resources.rsz_11rsz_asterisk
                LName.Tag = "1"
                LDescription.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
                cboValueList.ReadOnly = True
            Case "CA8BACF7-3205-43AF-BCBB-A0DA4915C046" 'CHECKLIST
                Me.Text = "CheckList Έργων"
                LName.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
                LName.ImageOptions.Image = Global.DreamyKitchenCRM.My.Resources.Resources.rsz_11rsz_asterisk
                LName.Tag = "1"
                LName.Text = "Περιγραφή"
                cboValueList.ReadOnly = True
            Case "E6733593-7DA0-4180-8951-B09315E1F13D" 'Πόρτες Εσωτερικές
                Me.Text = "Κατηγορία Πόρτας"
                LName.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
                LName.ImageOptions.Image = Global.DreamyKitchenCRM.My.Resources.Resources.rsz_11rsz_asterisk
                LName.Tag = "1"
                LName.Text = "Περιγραφή"
                Lkasa.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
                Lprice.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
                cboValueList.ReadOnly = False

        End Select
    End Sub
    Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click
        Dim sResult As Boolean
        Dim sGuid As String
        Dim sValuelistItemID As String
        Try
            If Valid.ValidateForm(LayoutControl1) Then
                Select Case Mode
                    Case FormMode.NewRecord
                        sGuid = System.Guid.NewGuid.ToString
                        sResult = DBQ.InsertData(LayoutControl1, "valueListItem", sGuid)
                    Case FormMode.EditRecord
                        sResult = DBQ.UpdateData(LayoutControl1, "valueListItem", sID)
                        sGuid = sID
                End Select
                If CalledFromCtrl Then
                    If CtrlCombo IsNot Nothing Then
                        FillCbo.valueListItem(CtrlCombo)
                        CtrlCombo.EditValue = System.Guid.Parse(sGuid)
                    Else
                        Dim sSQL As System.Text.StringBuilder
                        sSQL = New System.Text.StringBuilder
                        sSQL.AppendLine("SELECT  id,name,price FROM vw_VALUELISTITEM WHERE valueListID = 'DE86FD16-2154-4E2A-B025-4D34BDF8C808' order by name ")
                        Select Case cboValueList.EditValue.ToString.ToUpper
                            ' Μοντέλα Κουζίνας
                            Case "3C68F058-6A47-4995-8B0C-26538F38580A"
                                FillCbo.valueListItem(, sSQL, CtrlComboChecked)
                            ' Ντουλάπες
                            Case "AFDD6E1A-EBA3-4FE9-AB28-EDE277939F29"
                                FillCbo.valueListItem(, sSQL, CtrlComboChecked)
                            ' Πόρτες
                            Case "DE86FD16-2154-4E2A-B025-4D34BDF8C808"
                                FillCbo.valueListItem(, sSQL)
                            ' Ειδικές Κατασκευές
                            Case "CF47FAEE-7CD7-49AD-9455-3BC69D438DE9"
                                FillCbo.valueListItem(, sSQL)
                        End Select
                        CtrlCombo.EditValue = System.Guid.Parse(sGuid)
                        '       CtrlCombo.EditValue = System.Guid.Parse(sGuid)
                    End If
                Else
                    Dim form As frmScroller = Frm
                    form.LoadRecords("vw_VALUELISTITEM")
                End If
                If sResult = True Then
                    XtraMessageBox.Show("Η εγγραφή αποθηκέυτηκε με επιτυχία", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    If Mode = FormMode.NewRecord Then
                        sValuelistItemID = cboValueList.EditValue.ToString
                        Cls.ClearCtrls(LayoutControl1)
                        txtCode.Text = DBQ.GetNextId("valueListItem")
                        txtCustomCode.Select()
                        cboValueList.EditValue = sValuelistItemID
                    End If
                End If
            End If

        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cboType_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboType.ButtonClick
        Select Case e.Button.Index
            Case 1 : cboType.EditValue = Nothing
        End Select
    End Sub

    Private Sub cboKasa_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboKasa.ButtonClick
        Select Case e.Button.Index
            Case 1 : cboKasa.EditValue = Nothing
        End Select
    End Sub

    Private Sub cboVALUELISTITEM_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboValueListItem.ButtonClick
        Select Case e.Button.Index
            Case 1 : cboValueListItem.EditValue = Nothing
        End Select
    End Sub
    Private Sub cboValueList_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboValueList.ButtonClick
        Select Case e.Button.Index
            Case 1 : cboValueList.EditValue = Nothing : ManageDoorCAT()
            Case 2 : If cboValueList.EditValue IsNot Nothing Then ManageDoorCAT()
            Case 3 : cboValueList.EditValue = Nothing
        End Select
    End Sub
    Private Sub ManageDoorCAT()
        Dim form1 As frmGen = New frmGen()
        form1.Text = "Κατηγορία Πόρτας"
        form1.L1.Text = "Κωδικός"
        form1.L2.Text = "Κατηγορία"
        form1.DataTable = "VALUELIST"
        form1.CallerControl = cboValueList
        form1.CalledFromControl = True
        If cboValueList.EditValue IsNot Nothing Then form1.ID = cboValueList.EditValue.ToString
        form1.MdiParent = frmMain
        If cboValueList.EditValue IsNot Nothing Then form1.Mode = FormMode.EditRecord Else form1.Mode = FormMode.NewRecord
        frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(form1), New Point(CInt(form1.Parent.ClientRectangle.Width / 2 - form1.Width / 2), CInt(form1.Parent.ClientRectangle.Height / 2 - form1.Height / 2)))
        form1.Show()
    End Sub

    Private Sub cboDim_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboDim.ButtonClick
        Select Case e.Button.Index
            Case 1 : cboDim.EditValue = Nothing : ManageDIM()
            Case 2 : If cboDim.EditValue IsNot Nothing Then ManageDIM()
            Case 3 : cboDim.EditValue = Nothing
        End Select
    End Sub
    Private Sub ManageDIM()
        Dim form1 As frmGen = New frmGen()
        form1.Text = "Διάσταση"
        form1.L1.Text = "Κωδικός"
        form1.L2.Text = "Διάσταση"
        form1.DataTable = "DIM"
        form1.CallerControl = cboDim
        form1.CalledFromControl = True
        If cboDim.EditValue IsNot Nothing Then form1.ID = cboDim.EditValue.ToString
        form1.MdiParent = frmMain
        If cboDim.EditValue IsNot Nothing Then form1.Mode = FormMode.EditRecord Else form1.Mode = FormMode.NewRecord
        frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(form1), New Point(CInt(form1.Parent.ClientRectangle.Width / 2 - form1.Width / 2), CInt(form1.Parent.ClientRectangle.Height / 2 - form1.Height / 2)))
        form1.Show()
    End Sub

    Private Sub cboVALUELISTITEM1_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboClosetType.ButtonClick
        Select Case e.Button.Index
            Case 1 : cboClosetType.EditValue = Nothing
        End Select

    End Sub


    Private Sub cboDoorColor_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboDoorColor.ButtonClick
        Select Case e.Button.Index
            Case 1 : ManageCbo.ManageColors(cboDoorColor, FormMode.NewRecord)
            Case 2 : ManageCbo.ManageColors(cboDoorColor, FormMode.EditRecord)
            Case 3 : cboDoorColor.EditValue = Nothing
        End Select
    End Sub
    Private Sub ManageColors(ByVal CallerControl As LookUpEdit)
        Dim frmColors As frmColors = New frmColors
        frmColors.ColorCategory = "40C7BFFB-43EB-48FB-A467-74C0BCBE09FA"
        frmColors.Text = "Χρώματα"
        frmColors.CallerForm = "frmVALUELISTITEM"
        frmColors.CallerControlLKUP = CallerControl
        frmColors.CalledFromControl = True
        frmColors.MdiParent = frmMain
        If CallerControl.EditValue IsNot Nothing Then
            frmColors.ID = CallerControl.EditValue.ToString
            frmColors.Mode = FormMode.EditRecord
        Else
            frmColors.Mode = FormMode.NewRecord
        End If
        frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(frmColors), New Point(CInt(frmColors.Parent.ClientRectangle.Width / 2 - frmColors.Width / 2), CInt(frmColors.Parent.ClientRectangle.Height / 2 - frmColors.Height / 2)))
        frmColors.Show()
    End Sub

    Private Sub cboSUP_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles cboSup.ButtonClick
        Select Case e.Button.Index
            Case 1 : ManageCbo.ManageSup(cboSup, FormMode.NewRecord)
            Case 2 : ManageCbo.ManageSup(cboSup, FormMode.EditRecord)
            Case 3 : cboSup.EditValue = Nothing
        End Select
    End Sub
End Class