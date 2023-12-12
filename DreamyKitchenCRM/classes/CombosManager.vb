Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Grid
Public Class CombosManager
    Public Sub ManageCCT(ByVal FrmMode As Byte, ByVal isFromGrid As Boolean, Optional ByRef RecID As String = "", Optional ByVal CallerControl As LookUpEdit = Nothing, Optional ByVal grdView As GridView = Nothing)
        Dim Frm As frmCustomers = New frmCustomers()
        Frm.Text = "Πελάτες"
        If isFromGrid = False Then
            If FrmMode = FormMode.NewRecord Then CallerControl.EditValue = Nothing
            Frm.CallerControl = CallerControl
            Frm.CalledFromControl = False
            If CallerControl.EditValue <> Nothing Then
                Frm.ID = CallerControl.EditValue.ToString
                Frm.Mode = FormMode.EditRecord
            Else
                Frm.Mode = FormMode.NewRecord
            End If
        Else
            If grdView.GetRowCellValue(grdView.FocusedRowHandle, "cctID").ToString <> Nothing Then
                Frm.ID = grdView.GetRowCellValue(grdView.FocusedRowHandle, "cctID").ToString
                Frm.Mode = FormMode.EditRecord
            Else
                Frm.Mode = FormMode.NewRecord
            End If
        End If
        Frm.ShowDialog()
    End Sub
    Public Sub ManageTRANSH(ByVal CallerControl As LookUpEdit, ByVal FrmMode As Byte)
        If UserProps.ID.ToString.ToUpper = "3F9DC32E-BE5B-4D46-A13C-EA606566CF32" Or UserProps.ID.ToString.ToUpper = "E9CEFD11-47C0-4796-A46B-BC41C4C3606B" Then
            Dim Frm As frmTransactions = New frmTransactions()
            If FrmMode = FormMode.NewRecord Then CallerControl.EditValue = Nothing
            Frm.Text = "Χρεωπιστώσεις Πελατών"
            Frm.CallerControl = CallerControl
            Frm.CalledFromControl = True
            Frm.MdiParent = frmMain
            If CallerControl.EditValue <> Nothing Then
                Frm.ID = CallerControl.EditValue.ToString
                Frm.Mode = FormMode.EditRecord
            Else
                Frm.Mode = FormMode.NewRecord
            End If

            frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(Frm), New Point(CInt(Frm.Parent.ClientRectangle.Width / 2 - Frm.Width / 2), CInt(Frm.Parent.ClientRectangle.Height / 2 - Frm.Height / 2)))
            Frm.Show()
        End If
    End Sub
    Public Sub ManageTRANSHSmall(ByVal CallerControl As LookUpEdit, ByVal FrmMode As Byte)
        Dim Frm As frmProject = New frmProject()
        If FrmMode = FormMode.NewRecord Then CallerControl.EditValue = Nothing
        Frm.Text = "Έργα Πελατών"
        Frm.MdiParent = frmMain
        If CallerControl.EditValue <> Nothing Then
            Frm.ID = CallerControl.EditValue.ToString
            Frm.Mode = FormMode.EditRecord
        Else
            Frm.Mode = FormMode.NewRecord
        End If

        frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(Frm), New Point(CInt(Frm.Parent.ClientRectangle.Width / 2 - Frm.Width / 2), CInt(Frm.Parent.ClientRectangle.Height / 2 - Frm.Height / 2)))
        Frm.Show()
    End Sub

    Public Sub ManageSup(ByVal CallerControl As LookUpEdit, ByVal FrmMode As Byte)
        If UserProps.ID.ToString.ToUpper = "3F9DC32E-BE5B-4D46-A13C-EA606566CF32" Or UserProps.ID.ToString.ToUpper = "E9CEFD11-47C0-4796-A46B-BC41C4C3606B" Then
            Dim Frm As frmSUP = New frmSUP()
            If FrmMode = FormMode.NewRecord Then CallerControl.EditValue = Nothing
            Frm.Text = "Προμηθευτές"
            Frm.CallerControl = CallerControl
            Frm.CalledFromControl = True
            Frm.MdiParent = frmMain
            If CallerControl.EditValue <> Nothing Then
                Frm.ID = CallerControl.EditValue.ToString
                Frm.Mode = FormMode.EditRecord
            Else
                Frm.Mode = FormMode.NewRecord
            End If
            frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(Frm), New Point(CInt(Frm.Parent.ClientRectangle.Width / 2 - Frm.Width / 2), CInt(Frm.Parent.ClientRectangle.Height / 2 - Frm.Height / 2)))
            Frm.Show()
        End If
    End Sub
    Public Sub ManageBUY_C(ByVal CallerControl As LookUpEdit, ByVal FrmMode As Byte)
        If UserProps.ID.ToString.ToUpper = "3F9DC32E-BE5B-4D46-A13C-EA606566CF32" Or UserProps.ID.ToString.ToUpper = "E9CEFD11-47C0-4796-A46B-BC41C4C3606B" Then
            Dim Frm As frmGen = New frmGen()
            If FrmMode = FormMode.NewRecord Then CallerControl.EditValue = Nothing
            Frm.Text = "Κατηγορίες Αγορών"
            Frm.DataTable = "BUY_C"
            Frm.L1.Text = "Κωδικός"
            Frm.L2.Text = "Όνομα"
            Frm.CallerControl = CallerControl
            Frm.CalledFromControl = True
            Frm.MdiParent = frmMain
            If CallerControl.EditValue <> Nothing Then
                Frm.ID = CallerControl.EditValue.ToString
                Frm.Mode = FormMode.EditRecord
            Else
                Frm.Mode = FormMode.NewRecord
            End If
            frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(Frm), New Point(CInt(Frm.Parent.ClientRectangle.Width / 2 - Frm.Width / 2), CInt(Frm.Parent.ClientRectangle.Height / 2 - Frm.Height / 2)))
            Frm.Show()
        End If
    End Sub
    Public Sub ManagePAY(ByVal CallerControl As LookUpEdit, ByVal FrmMode As Byte)
        Dim Frm As frmGen = New frmGen()
        If FrmMode = FormMode.NewRecord Then CallerControl.EditValue = Nothing
        Frm.Text = "Τρόποι Πληρωμής"
        Frm.L1.Text = "Κωδικός"
        Frm.L2.Text = "Τρόπος Πληρωμής"
        Frm.DataTable = "PAY"
        Frm.CallerControl = CallerControl
        Frm.CalledFromControl = True
        If CallerControl.EditValue <> Nothing Then Frm.ID = CallerControl.EditValue.ToString
        Frm.MdiParent = frmMain
        If CallerControl.EditValue <> Nothing Then Frm.Mode = FormMode.EditRecord Else Frm.Mode = FormMode.NewRecord
        frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(Frm), New Point(CInt(Frm.Parent.ClientRectangle.Width / 2 - Frm.Width / 2), CInt(Frm.Parent.ClientRectangle.Height / 2 - Frm.Height / 2)))
        Frm.Show()
    End Sub
    Public Sub ManagePAY_TYPE(ByVal CallerControl As LookUpEdit, ByVal FrmMode As Byte)
        Dim Frm As frmGen = New frmGen()
        If FrmMode = FormMode.NewRecord Then CallerControl.EditValue = Nothing
        Frm.Text = "Τύποι Πληρωμής"
        Frm.L1.Text = "Κωδικός"
        Frm.L2.Text = "Τύπος Πληρωμής"
        Frm.DataTable = "PAY_TYPE"
        Frm.CallerControl = CallerControl
        Frm.CalledFromControl = True
        If CallerControl.EditValue <> Nothing Then Frm.ID = CallerControl.EditValue.ToString
        Frm.MdiParent = frmMain
        If CallerControl.EditValue <> Nothing Then Frm.Mode = FormMode.EditRecord Else Frm.Mode = FormMode.NewRecord
        frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(Frm), New Point(CInt(Frm.Parent.ClientRectangle.Width / 2 - Frm.Width / 2), CInt(Frm.Parent.ClientRectangle.Height / 2 - Frm.Height / 2)))
        Frm.Show()
    End Sub
    Public Sub ManageDOCTYPES(ByVal CallerControl As LookUpEdit, ByVal FrmMode As Byte)
        Dim Frm As frmGen = New frmGen()
        If FrmMode = FormMode.NewRecord Then CallerControl.EditValue = Nothing
        Frm.Text = "Τύποι Παραστατικών"
        Frm.L1.Text = "Κωδικός"
        Frm.L2.Text = "Τύπος"
        Frm.L8.Control.Tag = "Vmultiplier,0,1,2"
        Frm.L8.Text = "Πολλαπλασιαστής"
        Frm.L3.Text = "Προμηθευτής"
        Frm.L3.Control.Tag = "supID,0,1,2"
        Frm.DataTable = "DOC_TYPES"
        Frm.L8.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
        Frm.L3.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
        Frm.CallerControl = CallerControl
        Frm.CalledFromControl = True
        Frm.MdiParent = frmMain
        If CallerControl.EditValue <> Nothing Then
            Frm.ID = CallerControl.EditValue.ToString
            Frm.Mode = FormMode.EditRecord
        Else
            Frm.Mode = FormMode.NewRecord
        End If

        frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(Frm), New Point(CInt(Frm.Parent.ClientRectangle.Width / 2 - Frm.Width / 2), CInt(Frm.Parent.ClientRectangle.Height / 2 - Frm.Height / 2)))
        Frm.Show()
    End Sub
    Public Sub ManageEMP(ByVal CallerControl As LookUpEdit, ByVal FrmMode As Byte)
        If UserProps.ID.ToString.ToUpper = "3F9DC32E-BE5B-4D46-A13C-EA606566CF32" Or UserProps.ID.ToString.ToUpper = "E9CEFD11-47C0-4796-A46B-BC41C4C3606B" Then
            Dim Frm As frmEMP = New frmEMP()
            If FrmMode = FormMode.NewRecord Then CallerControl.EditValue = Nothing
            Frm.Text = "Προσωπικό"
            Frm.CallerControl = CallerControl
            Frm.CalledFromControl = True
            Frm.MdiParent = frmMain
            If CallerControl.EditValue <> Nothing Then
                Frm.ID = CallerControl.EditValue.ToString
                Frm.Mode = FormMode.EditRecord
            Else
                Frm.Mode = FormMode.NewRecord
            End If
            frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(Frm), New Point(CInt(Frm.Parent.ClientRectangle.Width / 2 - Frm.Width / 2), CInt(Frm.Parent.ClientRectangle.Height / 2 - Frm.Height / 2)))
            Frm.Show()
        End If
    End Sub
    Public Sub ManageSaler(ByVal CallerControl As LookUpEdit, ByVal FrmMode As Byte)
        If UserProps.ID.ToString.ToUpper = "3F9DC32E-BE5B-4D46-A13C-EA606566CF32" Or UserProps.ID.ToString.ToUpper = "E9CEFD11-47C0-4796-A46B-BC41C4C3606B" Then
            Dim Frm As frmEMP = New frmEMP()
            Frm.Text = "Πωλητές"
            Frm.CallerControl = CallerControl
            Frm.CalledFromControl = True
            Frm.MdiParent = frmMain
            If CallerControl.EditValue <> Nothing Then
                Frm.ID = CallerControl.EditValue.ToString
                Frm.Mode = FormMode.EditRecord
            Else
                Frm.Mode = FormMode.NewRecord
            End If
            frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(Frm), New Point(CInt(Frm.Parent.ClientRectangle.Width / 2 - Frm.Width / 2), CInt(Frm.Parent.ClientRectangle.Height / 2 - Frm.Height / 2)))
            Frm.Show()
        End If
    End Sub
    Public Sub ManageINST(ByVal CallerControl As LookUpEdit, ByVal FrmMode As Byte)
        Dim Frm As frmInstallations = New frmInstallations()
        If FrmMode = FormMode.NewRecord Then CallerControl.EditValue = Nothing
        Frm.Text = "Μισθοδοσία Τοποθετών"
        Frm.CallerControl = CallerControl
        Frm.CalledFromControl = True
        Frm.MdiParent = frmMain
        If CallerControl.EditValue <> Nothing Then
            Frm.ID = CallerControl.EditValue.ToString
            Frm.Mode = FormMode.EditRecord
        Else
            Frm.Mode = FormMode.NewRecord
        End If
        frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(Frm), New Point(CInt(Frm.Parent.ClientRectangle.Width / 2 - Frm.Width / 2), CInt(Frm.Parent.ClientRectangle.Height / 2 - Frm.Height / 2)))
        Frm.Show()
    End Sub
    Public Sub ManageBank(ByVal CallerControl As LookUpEdit, ByVal FrmMode As Byte)
        Dim Frm As frmGen = New frmGen()
        If FrmMode = FormMode.NewRecord Then CallerControl.EditValue = Nothing
        Frm.Text = "Τράπεζες"
        Frm.L1.Text = "Κωδικός"
        Frm.L2.Text = "Τράπεζα"
        Frm.DataTable = "BANKS"
        Frm.CalledFromControl = True
        Frm.CallerControl = CallerControl
        If CallerControl.EditValue <> Nothing Then
            Frm.ID = CallerControl.EditValue.ToString
            Frm.Mode = FormMode.EditRecord
        Else
            Frm.Mode = FormMode.NewRecord
        End If
        frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(Frm), New Point(CInt(Frm.Parent.ClientRectangle.Width / 2 - Frm.Width / 2), CInt(Frm.Parent.ClientRectangle.Height / 2 - Frm.Height / 2)))
        Frm.Show()
    End Sub
    Public Sub ManageDoorType(ByVal CallerControl As LookUpEdit, ByVal FrmMode As Byte, Optional ByVal DoorCatID As String = Nothing)
        Dim Frm As frmDoorType = New frmDoorType
        If FrmMode = FormMode.NewRecord Then CallerControl.EditValue = Nothing
        Frm.Text = "Κατηγορία Πόρτας"
        Frm.CallerControl = CallerControl
        Frm.CalledFromControl = True
        Frm.cboDoorCat.EditValue = DoorCatID
        If CallerControl.EditValue <> Nothing Then Frm.ID = CallerControl.EditValue.ToString
        Frm.MdiParent = frmMain
        If CallerControl.EditValue <> Nothing Then Frm.Mode = FormMode.EditRecord Else Frm.Mode = FormMode.NewRecord
        frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(Frm), New Point(CInt(Frm.Parent.ClientRectangle.Width / 2 - Frm.Width / 2), CInt(Frm.Parent.ClientRectangle.Height / 2 - Frm.Height / 2)))
        Frm.Show()
    End Sub
    Public Sub ManageBENCH(ByVal CallerControl As LookUpEdit, ByVal FrmCaller As DevExpress.XtraEditors.XtraForm, ByVal FrmMode As Byte)
        Dim Frm As frmBench = New frmBench
        If FrmMode = FormMode.NewRecord Then CallerControl.EditValue = Nothing
        Frm.CallerForm = FrmCaller.Name
        Frm.CallerControl = CallerControl
        Frm.CalledFromControl = True
        Frm.MdiParent = frmMain
        If CallerControl.EditValue <> Nothing Then
            Frm.ID = CallerControl.EditValue.ToString
            Frm.Mode = FormMode.EditRecord
        Else
            Frm.Mode = FormMode.NewRecord
        End If
        frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(Frm), New Point(CInt(Frm.Parent.ClientRectangle.Width / 2 - Frm.Width / 2), CInt(Frm.Parent.ClientRectangle.Height / 2 - Frm.Height / 2)))
        Frm.Show()
    End Sub
    Public Sub ManageColors(ByVal CallerControl As LookUpEdit, ByVal FrmMode As Byte)
        Dim Frm As frmColors = New frmColors
        If FrmMode = FormMode.NewRecord Then CallerControl.EditValue = Nothing
        Select Case CallerControl.Name
            Case "cboGOLAColors" : Frm.ColorCategory = "1FA658C9-A338-4805-B38F-7E6503A5CD25"
            Case "cboVBOXColors", "cboKBOXColors", "cboYBOXColors", "cboBOXColors", "cboBOXColors2",
                 "cboBOXColors3", "cboBOXColors4", "cboBOXColors5", "cboBOXColors6" : Frm.ColorCategory = "40C7BFFB-43EB-48FB-A467-74C0BCBE09FA"
            Case "cboVPVCColors", "cboKPVCColors", "cboYPVCColors" : Frm.ColorCategory = "1226147D-2FF2-4076-B24D-92ABC8FB4663"
        End Select
        Frm.Text = "Χρώματα"
        Frm.CallerForm = "frmCUSOrderKitchen"
        Frm.CallerControlLKUP = CallerControl
        Frm.CalledFromControl = True
        Frm.MdiParent = frmMain
        If CallerControl.EditValue <> Nothing Then
            Frm.ID = CallerControl.EditValue.ToString
            Frm.Mode = FormMode.EditRecord
        Else
            Frm.Mode = FormMode.NewRecord
        End If
        frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(Frm), New Point(CInt(Frm.Parent.ClientRectangle.Width / 2 - Frm.Width / 2), CInt(Frm.Parent.ClientRectangle.Height / 2 - Frm.Height / 2)))
        Frm.Show()
    End Sub
    Public Sub ManageSpecialConstr(ByVal CallerControl As LookUpEdit, ByVal FrmMode As Byte)
        Dim Frm As frmGen = New frmGen()
        If FrmMode = FormMode.NewRecord Then CallerControl.EditValue = Nothing
        Frm.Text = "Είδη Κατασκευής"
        Frm.L1.Text = "Κωδικός"
        Frm.L2.Text = "Είδος"
        Frm.DataTable = "CONSTR_TYPE"
        Frm.CallerControl = CallerControl
        Frm.CalledFromControl = True
        Frm.MdiParent = frmMain
        If CallerControl.EditValue <> Nothing Then
            Frm.ID = CallerControl.EditValue.ToString
            Frm.Mode = FormMode.EditRecord
        Else
            Frm.Mode = FormMode.NewRecord
        End If
        frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(Frm), New Point(CInt(Frm.Parent.ClientRectangle.Width / 2 - Frm.Width / 2), CInt(Frm.Parent.ClientRectangle.Height / 2 - Frm.Height / 2)))
        Frm.Show()
    End Sub
    Public Sub ManageAREAS(ByVal CallerControl As LookUpEdit, ByVal FrmMode As Byte)
        Dim Frm As frmGen = New frmGen()
        If FrmMode = FormMode.NewRecord Then CallerControl.EditValue = Nothing
        Frm.Text = "Περιοχές"
        Frm.L1.Text = "Κωδικός"
        Frm.L2.Text = "Περιοχή"
        Frm.L3.Text = "Νομός"
        Frm.DataTable = "AREAS"
        Frm.L3.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
        Frm.CalledFromControl = True
        Frm.CallerControl = CallerControl
        Frm.MdiParent = frmMain
        If CallerControl.EditValue <> Nothing Then
            Frm.ID = CallerControl.EditValue.ToString
            Frm.Mode = FormMode.EditRecord
        Else
            Frm.Mode = FormMode.NewRecord
        End If
        frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(Frm), New Point(CInt(Frm.Parent.ClientRectangle.Width / 2 - Frm.Width / 2), CInt(Frm.Parent.ClientRectangle.Height / 2 - Frm.Height / 2)))
        Frm.Show()
    End Sub
    Public Function ADRsSQL(ByVal cboCOU As LookUpEdit, ByVal cboAREAS As LookUpEdit, ByVal txtTK As TextEdit) As System.Text.StringBuilder
        Dim sSQL As New System.Text.StringBuilder
        Dim CouID As String = ""
        Dim AreaID As String = ""
        If cboCOU.EditValue <> Nothing Then CouID = cboCOU.EditValue.ToString
        If cboAREAS.EditValue <> Nothing Then AreaID = cboAREAS.EditValue.ToString
        sSQL.AppendLine("Select id,Name + ' - ' + isnull(ar,'') as Name from vw_ADR ")
        If CouID.Length > 0 Or AreaID.Length > 0 Or txtTK.Text.Length > 0 Then sSQL.AppendLine(" where ")
        If CouID.Length > 0 Then sSQL.AppendLine(" couid = " & toSQLValueS(CouID))
        If AreaID.Length > 0 Then
            If CouID.Length > 0 Then sSQL.AppendLine(" AND ")
            sSQL.AppendLine(" AreaID = " & toSQLValueS(AreaID))
        End If
        If txtTK.Text.Length > 0 Then
            If CouID.Length > 0 Or AreaID.Length > 0 Then sSQL.AppendLine(" AND ")
            sSQL.AppendLine(" TK = " & toSQLValue(txtTK))
        End If
        sSQL.AppendLine(" order by name ")
        Return sSQL
    End Function

    Public Sub ManageADR(ByVal CallerControl As LookUpEdit, ByVal FrmMode As Byte)
        Dim Frm As frmGen = New frmGen()
        If FrmMode = FormMode.NewRecord Then CallerControl.EditValue = Nothing
        Frm.Text = "Διευθύνσεις"
        Frm.L1.Text = "Κωδικός"
        Frm.L2.Text = "Διεύθυνση"
        Frm.L3.Text = "Νομός"
        Frm.L4.Text = "Περιοχές"
        Frm.L8.Text = "Αριθμός"
        Frm.DataTable = "ADR"
        Frm.CalledFromControl = True
        Frm.CallerControl = CallerControl
        Frm.L3.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
        Frm.L4.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
        Frm.L8.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
        Frm.L8.Control.Tag = "Ar,0,1,2"
        Frm.MdiParent = frmMain
        If CallerControl.EditValue <> Nothing Then
            Frm.ID = CallerControl.EditValue.ToString
            Frm.Mode = FormMode.EditRecord
        Else
            Frm.Mode = FormMode.NewRecord
        End If
        frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(Frm), New Point(CInt(Frm.Parent.ClientRectangle.Width / 2 - Frm.Width / 2), CInt(Frm.Parent.ClientRectangle.Height / 2 - Frm.Height / 2)))
        Frm.Show()
    End Sub
    Public Sub ManageCOU(ByVal CallerControl As LookUpEdit, ByVal FrmMode As Byte)
        Dim Frm As frmGen = New frmGen()
        If FrmMode = FormMode.NewRecord Then CallerControl.EditValue = Nothing
        Frm.Text = "Νομοί"
        Frm.L1.Text = "Κωδικός"
        Frm.L2.Text = "Νομός"
        Frm.DataTable = "COU"
        Frm.CallerControl = CallerControl
        Frm.CalledFromControl = True
        Frm.MdiParent = frmMain
        If CallerControl.EditValue <> Nothing Then
            Frm.ID = CallerControl.EditValue.ToString
            Frm.Mode = FormMode.EditRecord
        Else
            Frm.Mode = FormMode.NewRecord
        End If
        frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(Frm), New Point(CInt(Frm.Parent.ClientRectangle.Width / 2 - Frm.Width / 2), CInt(Frm.Parent.ClientRectangle.Height / 2 - Frm.Height / 2)))
        Frm.Show()
    End Sub

    Public Sub ManageDOY(ByVal CallerControl As LookUpEdit, ByVal FrmMode As Byte)
        Dim Frm As frmGen = New frmGen()
        If FrmMode = FormMode.NewRecord Then CallerControl.EditValue = Nothing
        Frm.Text = "ΔΟΥ"
        Frm.L1.Text = "Κωδικός"
        Frm.L2.Text = "ΔΟΥ"
        Frm.DataTable = "DOY"
        Frm.CallerControl = CallerControl
        Frm.CalledFromControl = True
        If CallerControl.EditValue <> Nothing Then
            Frm.ID = CallerControl.EditValue.ToString
            Frm.Mode = FormMode.EditRecord
        Else
            Frm.Mode = FormMode.NewRecord
        End If
        Frm.MdiParent = frmMain
        frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(Frm), New Point(CInt(Frm.Parent.ClientRectangle.Width / 2 - Frm.Width / 2), CInt(Frm.Parent.ClientRectangle.Height / 2 - Frm.Height / 2)))
        Frm.Show()
    End Sub

    Public Sub ManagePRF(ByVal CallerControl As LookUpEdit, ByVal FrmMode As Byte)
        Dim Frm As frmGen = New frmGen()
        If FrmMode = FormMode.NewRecord Then CallerControl.EditValue = Nothing
        Frm.Text = "Επαγγέλματα"
        Frm.L1.Text = "Κωδικός"
        Frm.L2.Text = "Επάγγελμα"
        Frm.DataTable = "PRF"
        Frm.CallerControl = CallerControl
        Frm.CalledFromControl = True
        Frm.MdiParent = frmMain
        If CallerControl.EditValue <> Nothing Then
            Frm.ID = CallerControl.EditValue.ToString
            Frm.Mode = FormMode.EditRecord
        Else
            Frm.Mode = FormMode.NewRecord
        End If
        frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(Frm), New Point(CInt(Frm.Parent.ClientRectangle.Width / 2 - Frm.Width / 2), CInt(Frm.Parent.ClientRectangle.Height / 2 - Frm.Height / 2)))
        Frm.Show()
    End Sub

    Public Sub ManageSRC(ByVal CallerControl As LookUpEdit, ByVal FrmMode As Byte)
        Dim Frm As frmGen = New frmGen()
        If FrmMode = FormMode.NewRecord Then CallerControl.EditValue = Nothing
        Frm.Text = "Πηγές"
        Frm.L1.Text = "Κωδικός"
        Frm.L2.Text = "Πηγή"
        Frm.DataTable = "SRC"
        Frm.CalledFromControl = True
        Frm.CallerControl = CallerControl
        Frm.MdiParent = frmMain
        If CallerControl.EditValue <> Nothing Then
            Frm.ID = CallerControl.EditValue.ToString
            Frm.Mode = FormMode.EditRecord
        Else
            Frm.Mode = FormMode.NewRecord
        End If
        frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(Frm), New Point(CInt(Frm.Parent.ClientRectangle.Width / 2 - Frm.Width / 2), CInt(Frm.Parent.ClientRectangle.Height / 2 - Frm.Height / 2)))
        Frm.Show()
    End Sub
End Class
