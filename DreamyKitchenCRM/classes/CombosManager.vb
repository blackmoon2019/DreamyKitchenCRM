Imports System.ComponentModel
Imports System.Data.SqlClient
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

End Class
