Imports System.ComponentModel
Imports System.Data.SqlClient
Imports DevExpress.CodeParser
Imports DevExpress.DataAccess
Imports DevExpress.DataAccess.Native
Imports DevExpress.PivotGrid.QueryMode
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid
Public Class CombosManager
    Public Sub ManageCCT(ByVal FrmMode As Byte, ByVal isFromGrid As Boolean, Optional ByRef RecID As String = "", Optional ByVal CallerControl As LookUpEdit = Nothing, Optional ByVal grdView As GridView = Nothing)
        Dim form1 As frmCustomers = New frmCustomers()
        form1.Text = "Πελάτες"
        If isFromGrid = False Then
            If FrmMode = FormMode.NewRecord Then CallerControl.EditValue = Nothing
            form1.CallerControl = CallerControl
            form1.CalledFromControl = False
            If CallerControl.EditValue <> Nothing Then
                form1.ID = CallerControl.EditValue.ToString
                form1.Mode = FormMode.EditRecord
            Else
                form1.Mode = FormMode.NewRecord
            End If
        Else
            If grdView.GetRowCellValue(grdView.FocusedRowHandle, "cctID").ToString <> Nothing Then
                form1.ID = grdView.GetRowCellValue(grdView.FocusedRowHandle, "cctID").ToString
                form1.Mode = FormMode.EditRecord
            Else
                form1.Mode = FormMode.NewRecord
            End If
        End If
        form1.ShowDialog()
    End Sub
    Public Sub ManageTRANSH(ByVal CallerControl As LookUpEdit, ByVal FrmMode As Byte)
        If UserProps.ID.ToString.ToUpper = "3F9DC32E-BE5B-4D46-A13C-EA606566CF32" Or UserProps.ID.ToString.ToUpper = "E9CEFD11-47C0-4796-A46B-BC41C4C3606B" Then
            Dim form1 As frmTransactions = New frmTransactions()
            If FrmMode = FormMode.NewRecord Then CallerControl.EditValue = Nothing
            form1.Text = "Χρεωπιστώσεις Πελατών"
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
        End If
    End Sub
    Public Sub ManageSup(ByVal CallerControl As LookUpEdit, ByVal FrmMode As Byte)
        If UserProps.ID.ToString.ToUpper = "3F9DC32E-BE5B-4D46-A13C-EA606566CF32" Or UserProps.ID.ToString.ToUpper = "E9CEFD11-47C0-4796-A46B-BC41C4C3606B" Then
            Dim form1 As frmSUP = New frmSUP()
            If FrmMode = FormMode.NewRecord Then CallerControl.EditValue = Nothing
            form1.Text = "Προμηθευτές"
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
        End If
    End Sub
    Public Sub ManageBUY_C(ByVal CallerControl As LookUpEdit, ByVal FrmMode As Byte)
        If UserProps.ID.ToString.ToUpper = "3F9DC32E-BE5B-4D46-A13C-EA606566CF32" Or UserProps.ID.ToString.ToUpper = "E9CEFD11-47C0-4796-A46B-BC41C4C3606B" Then
            Dim form1 As frmGen = New frmGen()
            If FrmMode = FormMode.NewRecord Then CallerControl.EditValue = Nothing
            form1.Text = "Κατηγορίες Αγορών"
            form1.DataTable = "BUY_C"
            form1.L1.Text = "Κωδικός"
            form1.L2.Text = "Όνομα"
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
        End If
    End Sub
    Public Sub ManagePAY(ByVal CallerControl As LookUpEdit, ByVal FrmMode As Byte)
        Dim form1 As frmGen = New frmGen()
        If FrmMode = FormMode.NewRecord Then CallerControl.EditValue = Nothing
        form1.Text = "Τρόποι Πληρωμής"
        form1.L1.Text = "Κωδικός"
        form1.L2.Text = "Τρόπος Πληρωμής"
        form1.DataTable = "PAY"
        form1.CallerControl = CallerControl
        form1.CalledFromControl = True
        If CallerControl.EditValue <> Nothing Then form1.ID = CallerControl.EditValue.ToString
        form1.MdiParent = frmMain
        If CallerControl.EditValue <> Nothing Then form1.Mode = FormMode.EditRecord Else form1.Mode = FormMode.NewRecord
        frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(form1), New Point(CInt(form1.Parent.ClientRectangle.Width / 2 - form1.Width / 2), CInt(form1.Parent.ClientRectangle.Height / 2 - form1.Height / 2)))
        form1.Show()
    End Sub
    Public Sub ManageDOCTYPES(ByVal CallerControl As LookUpEdit, ByVal FrmMode As Byte)
        Dim form1 As frmGen = New frmGen()
        If FrmMode = FormMode.NewRecord Then CallerControl.EditValue = Nothing
        form1.Text = "Τύποι Παραστατικών"
        form1.L1.Text = "Κωδικός"
        form1.L2.Text = "Τύπος"
        form1.L8.Control.Tag = "Vmultiplier,0,1,2"
        form1.L8.Text = "Πολλαπλασιαστής"
        form1.L3.Text = "Προμηθευτής"
        form1.L3.Control.Tag = "supID,0,1,2"
        form1.DataTable = "DOC_TYPES"
        form1.L8.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
        form1.L3.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
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
        If UserProps.ID.ToString.ToUpper = "3F9DC32E-BE5B-4D46-A13C-EA606566CF32" Or UserProps.ID.ToString.ToUpper = "E9CEFD11-47C0-4796-A46B-BC41C4C3606B" Then
            Dim form1 As frmEMP = New frmEMP()
            If FrmMode = FormMode.NewRecord Then CallerControl.EditValue = Nothing
            form1.Text = "Προσωπικό"
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
        End If
    End Sub
    Public Sub ManageINST(ByVal CallerControl As LookUpEdit, ByVal FrmMode As Byte)
        Dim form1 As frmInstallations = New frmInstallations()
        If FrmMode = FormMode.NewRecord Then CallerControl.EditValue = Nothing
        form1.Text = "Μισθοδοσία Τοποθετών"
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
    Public Sub ManageDoorType(ByVal CallerControl As LookUpEdit, ByVal FrmMode As Byte, Optional ByVal DoorCatID As String = Nothing)
        Dim frmDoorType As frmDoorType = New frmDoorType
        If FrmMode = FormMode.NewRecord Then CallerControl.EditValue = Nothing
        frmDoorType.Text = "Κατηγορία Πόρτας"
        frmDoorType.CallerControl = CallerControl
        frmDoorType.CalledFromControl = True
        frmDoorType.cboDoorCat.EditValue = DoorCatID
        If CallerControl.EditValue <> Nothing Then frmDoorType.ID = CallerControl.EditValue.ToString
        frmDoorType.MdiParent = frmMain
        If CallerControl.EditValue <> Nothing Then frmDoorType.Mode = FormMode.EditRecord Else frmDoorType.Mode = FormMode.NewRecord
        frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(frmDoorType), New Point(CInt(frmDoorType.Parent.ClientRectangle.Width / 2 - frmDoorType.Width / 2), CInt(frmDoorType.Parent.ClientRectangle.Height / 2 - frmDoorType.Height / 2)))
        frmDoorType.Show()
    End Sub
    Public Sub ManageBENCH(ByVal CallerControl As LookUpEdit, ByVal FrmCaller As DevExpress.XtraEditors.XtraForm, ByVal FrmMode As Byte)
        Dim frmBench As frmBench = New frmBench
        If FrmMode = FormMode.NewRecord Then CallerControl.EditValue = Nothing
        frmBench.CallerForm = FrmCaller.Name
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
    Public Sub ManageColors(ByVal CallerControl As LookUpEdit, ByVal FrmMode As Byte)
        Dim frmColors As frmColors = New frmColors
        If FrmMode = FormMode.NewRecord Then CallerControl.EditValue = Nothing
        Select Case CallerControl.Name
            Case "cboGOLAColors" : frmColors.ColorCategory = "1FA658C9-A338-4805-B38F-7E6503A5CD25"
            Case "cboVBOXColors", "cboKBOXColors", "cboYBOXColors", "cboBOXColors", "cboBOXColors2",
                 "cboBOXColors3", "cboBOXColors4", "cboBOXColors5", "cboBOXColors6" : frmColors.ColorCategory = "40C7BFFB-43EB-48FB-A467-74C0BCBE09FA"
            Case "cboVPVCColors", "cboKPVCColors", "cboYPVCColors" : frmColors.ColorCategory = "1226147D-2FF2-4076-B24D-92ABC8FB4663"
        End Select
        frmColors.Text = "Χρώματα"
        frmColors.CallerForm = "frmCUSOrderKitchen"
        frmColors.CallerControlLKUP = CallerControl
        frmColors.CalledFromControl = True
        frmColors.MdiParent = frmMain
        If CallerControl.EditValue <> Nothing Then
            frmColors.ID = CallerControl.EditValue.ToString
            frmColors.Mode = FormMode.EditRecord
        Else
            frmColors.Mode = FormMode.NewRecord
        End If
        frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(frmColors), New Point(CInt(frmColors.Parent.ClientRectangle.Width / 2 - frmColors.Width / 2), CInt(frmColors.Parent.ClientRectangle.Height / 2 - frmColors.Height / 2)))
        frmColors.Show()
    End Sub
    Public Sub ManageSpecialConstr(ByVal CallerControl As LookUpEdit, ByVal FrmMode As Byte)
        Dim form1 As frmGen = New frmGen()
        If FrmMode = FormMode.NewRecord Then CallerControl.EditValue = Nothing
        form1.Text = "Είδη Κατασκευής"
        form1.L1.Text = "Κωδικός"
        form1.L2.Text = "Είδος"
        form1.DataTable = "CONSTR_TYPE"
        form1.CallerControl = CallerControl
        form1.CalledFromControl = True
        If CallerControl.EditValue <> Nothing Then
            form1.ID = CallerControl.EditValue.ToString
            form1.Mode = FormMode.EditRecord
        Else
            form1.Mode = FormMode.NewRecord
        End If
        form1.MdiParent = frmMain
        frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(form1), New Point(CInt(form1.Parent.ClientRectangle.Width / 2 - form1.Width / 2), CInt(form1.Parent.ClientRectangle.Height / 2 - form1.Height / 2)))
        form1.Show()
    End Sub
End Class
