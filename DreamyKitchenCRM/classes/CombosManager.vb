Imports DevExpress.XtraEditors

Public Class CombosManager
    Public Sub ManageDIM(ByVal CallerControl As LookUpEdit)
        Dim form1 As frmGen = New frmGen()
        form1.Text = "Διάσταση"
        form1.L1.Text = "Κωδικός"
        form1.L2.Text = "Διάσταση"
        form1.DataTable = "DIM"
        form1.CallerControl = CallerControl
        form1.CalledFromControl = True
        If CallerControl.EditValue <> Nothing Then form1.ID = CallerControl.EditValue.ToString
        form1.MdiParent = frmMain
        If CallerControl.EditValue <> Nothing Then form1.Mode = FormMode.EditRecord Else form1.Mode = FormMode.NewRecord
        frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(form1), New Point(CInt(form1.Parent.ClientRectangle.Width / 2 - form1.Width / 2), CInt(form1.Parent.ClientRectangle.Height / 2 - form1.Height / 2)))
        form1.Show()
    End Sub
    Public Sub ManageBenchCat(ByVal CallerControl As LookUpEdit)
        Dim form1 As frmGen = New frmGen()
        form1.Text = "Πάγκοι"
        form1.L1.Text = "Κωδικός"
        form1.L2.Text = "Πάγκοι"
        form1.DataTable = "BASE_CAT"
        form1.CallerControl = CallerControl
        form1.CalledFromControl = True
        If CallerControl.EditValue <> Nothing Then form1.ID = CallerControl.EditValue.ToString
        form1.MdiParent = frmMain
        If CallerControl.EditValue <> Nothing Then form1.Mode = FormMode.EditRecord Else form1.Mode = FormMode.NewRecord
        frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(form1), New Point(CInt(form1.Parent.ClientRectangle.Width / 2 - form1.Width / 2), CInt(form1.Parent.ClientRectangle.Height / 2 - form1.Height / 2)))
        form1.Show()
    End Sub

    Public Sub ManageDoorType(ByVal CallerControl As LookUpEdit)
        Dim frmDoorType As frmDoorType = New frmDoorType
        frmDoorType.Text = "Κατηγορία Πόρτας"
        frmDoorType.CallerControl = CallerControl
        frmDoorType.CalledFromControl = True
        If CallerControl.EditValue <> Nothing Then frmDoorType.ID = CallerControl.EditValue.ToString
        frmDoorType.MdiParent = frmMain
        If CallerControl.EditValue <> Nothing Then frmDoorType.Mode = FormMode.EditRecord Else frmDoorType.Mode = FormMode.NewRecord
        frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(frmDoorType), New Point(CInt(frmDoorType.Parent.ClientRectangle.Width / 2 - frmDoorType.Width / 2), CInt(frmDoorType.Parent.ClientRectangle.Height / 2 - frmDoorType.Height / 2)))
        frmDoorType.Show()
    End Sub
    Public Sub ManageDoorBaseCat(ByVal CallerControl As LookUpEdit)
        Dim form1 As frmGen = New frmGen()
        form1.Text = "Κεντρική Κατηγορία Πόρτας"
        form1.L1.Text = "Κωδικός"
        form1.L2.Text = "Κατηγορία"
        form1.DataTable = "BASE_CAT"
        form1.CallerControl = CallerControl
        form1.CalledFromControl = True
        If CallerControl.EditValue <> Nothing Then form1.ID = CallerControl.EditValue.ToString
        form1.MdiParent = frmMain
        If CallerControl.EditValue <> Nothing Then form1.Mode = FormMode.EditRecord Else form1.Mode = FormMode.NewRecord
        frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(form1), New Point(CInt(form1.Parent.ClientRectangle.Width / 2 - form1.Width / 2), CInt(form1.Parent.ClientRectangle.Height / 2 - form1.Height / 2)))
        form1.Show()
    End Sub
    Public Sub ManageBENCH(ByVal CallerControl As LookUpEdit, Optional ByVal CallerForm As String = "")
        Dim frmBench As frmBench = New frmBench
        frmBench.CallerForm = CallerForm
        frmBench.CallerControl = CallerControl
        frmBench.CalledFromControl = True
        frmBench.MdiParent = frmMain
        If CallerControl.EditValue <> Nothing Then
            frmBench.ID = CallerControl.EditValue.ToString
            frmBench.Mode = FormMode.EditRecord
        Else
            frmBench.Mode = FormMode.NewRecord
        End If
        frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(frmBench), New Point(CInt(frmBench.Parent.ClientRectangle.Width / 2 - frmBench.Width / 2), CInt(frmBench.Parent.ClientRectangle.Height / 2 - frmBench.Height / 2)))
        frmBench.Show()
    End Sub

    Public Sub ManageDoorCAT(ByVal CallerControl As LookUpEdit)
        Dim form1 As frmGen = New frmGen()
        form1.Text = "Κατηγορία Πόρτας"
        form1.L1.Text = "Κωδικός"
        form1.L2.Text = "Κατηγορία"
        form1.DataTable = "DOOR_CAT"
        form1.CallerControl = CallerControl
        form1.CalledFromControl = True
        If CallerControl.EditValue <> Nothing Then form1.ID = CallerControl.EditValue.ToString
        form1.MdiParent = frmMain
        If CallerControl.EditValue <> Nothing Then form1.Mode = FormMode.EditRecord Else form1.Mode = FormMode.NewRecord
        frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(form1), New Point(CInt(form1.Parent.ClientRectangle.Width / 2 - form1.Width / 2), CInt(form1.Parent.ClientRectangle.Height / 2 - form1.Height / 2)))
        form1.Show()
    End Sub
    Public Sub ManageColors(ByVal CallerControl As LookUpEdit)
        Dim frmColors As frmColors = New frmColors
        Select Case CallerControl.Name
            Case "cboGOLAColors" : frmColors.ColorCategory = "1FA658C9-A338-4805-B38F-7E6503A5CD25"
            Case "cboVBOXColors", "cboKBOXColors", "cboYBOXColors" : frmColors.ColorCategory = "40C7BFFB-43EB-48FB-A467-74C0BCBE09FA"
            Case "cboVPVCColors", "cboKPVCColors", "cboYPVCColors" : frmColors.ColorCategory = "1226147D-2FF2-4076-B24D-92ABC8FB4663"
        End Select
        frmColors.Text = "Χρώματα"
        frmColors.CallerForm = "frmCUSOrderKitchen"
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

    Public Sub ManageCus(ByVal CallerControl As LookUpEdit, ByVal FrmMode As Byte)
        Dim form1 As frmCustomers = New frmCustomers()
        If FrmMode = FormMode.NewRecord Then CallerControl.EditValue = Nothing
        form1.Text = "Πελάτες"
        form1.CallerControl = CallerControl
        form1.CalledFromControl = True
        form1.MdiParent = frmMain
        If CallerControl.EditValue <> Nothing Then
            form1.ID = CallerControl.EditValue.ToString
            form1.Mode = FormMode.EditRecord
        Else
            form1.Mode = FormMode.NewRecord
        End If
        frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(form1), New Point(CInt(form1.Parent.ClientRectangle.Width / 2 - form1.Width / 2), CInt(form1.Parent.ClientRectangle.Height / 2 - form1.Height / 2)))
        form1.Show()

    End Sub

    Public Sub ManageEMP(ByVal CallerControl As LookUpEdit, ByVal FrmMode As Byte)
        If UserProps.ID.ToString.ToUpper <> "3F9DC32E-BE5B-4D46-A13C-EA606566CF32" Or UserProps.ID.ToString.ToUpper <> "E9CEFD11-47C0-4796-A46B-BC41C4C3606B" Then Exit Sub
        If FrmMode = FormMode.NewRecord Then CallerControl.EditValue = Nothing
        Dim form1 As frmEMP = New frmEMP()
        form1.Text = "Προσωπικό"
        form1.CallerControl = CallerControl
        form1.CalledFromControl = True
        form1.MdiParent = frmMain
        If CallerControl.EditValue <> Nothing Then
            form1.ID = CallerControl.EditValue.ToString
            form1.Mode = FrmMode
        Else
            form1.Mode = FrmMode
        End If
            frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(form1), New Point(CInt(form1.Parent.ClientRectangle.Width / 2 - form1.Width / 2), CInt(form1.Parent.ClientRectangle.Height / 2 - form1.Height / 2)))
            form1.Show()
    End Sub
    Public Sub ManageTRANSH(ByVal CallerControl As LookUpEdit, ByVal FrmMode As Byte)
        If UserProps.ID.ToString.ToUpper <> "3F9DC32E-BE5B-4D46-A13C-EA606566CF32" Or UserProps.ID.ToString.ToUpper <> "E9CEFD11-47C0-4796-A46B-BC41C4C3606B" Then Exit Sub
        If FrmMode = FormMode.NewRecord Then CallerControl.EditValue = Nothing
        Dim form1 As frmTransactions = New frmTransactions()
        form1.Text = "Χρεωπιστώσεις Πελατών"
        form1.CallerControl = CallerControl
        form1.CalledFromControl = True
        form1.MdiParent = frmMain
        If CallerControl.EditValue <> Nothing Then
            form1.ID = CallerControl.EditValue.ToString
            form1.Mode = FrmMode
        Else
            form1.Mode = FrmMode
        End If
        frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(form1), New Point(CInt(form1.Parent.ClientRectangle.Width / 2 - form1.Width / 2), CInt(form1.Parent.ClientRectangle.Height / 2 - form1.Height / 2)))
        form1.Show()
    End Sub
End Class
