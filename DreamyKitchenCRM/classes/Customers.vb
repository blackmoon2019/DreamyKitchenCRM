Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Tab
Imports DevExpress.XtraEditors
Imports DevExpress.XtraSplashScreen

Public Class Customers
    Private LoadForms As New FormLoader
    Private Valid As New ValidateControls
    Private DBQ As New DBQueries
    Private FrmScr As DevExpress.XtraEditors.XtraForm
    Private Frm As frmCustomers
    Private ID As String
    Private Mode As Byte
    Private CalledFromCtrl As Boolean
    Private CtrlCombo As DevExpress.XtraEditors.LookUpEdit
    Private FillCbo As New FillCombos


    Public Sub Initialize(ByVal sFrm As frmCustomers, ByVal sID As String, ByVal sMode As Byte, ByVal sCalledFromCtrl As Boolean, ByVal sCtrlCombo As DevExpress.XtraEditors.LookUpEdit, ByVal sFrmScr As DevExpress.XtraEditors.XtraForm)
        Frm = sFrm
        ID = sID
        Mode = sMode
        CalledFromCtrl = sCalledFromCtrl
        CtrlCombo = sCtrlCombo
        FrmScr = sFrmScr
        FillCbo.COU(Frm.cboCOU) : FillCbo.SRC(Frm.cboSRC)
        FillCbo.PRF(Frm.cboPRF) : FillCbo.DOY(Frm.cboDOY)

    End Sub
    Public Sub DeleteRecord()
        Dim sSQL As String
        Try

            If Frm.GridView1.GetRowCellValue(Frm.GridView1.FocusedRowHandle, "ID") = Nothing Then Exit Sub
            If XtraMessageBox.Show("Θέλετε να διαγραφεί η τρέχουσα εγγραφή?", ProgProps.ProgTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                sSQL = "DELETE FROM CCT_F WHERE ID = '" & Frm.GridView1.GetRowCellValue(Frm.GridView1.FocusedRowHandle, "ID").ToString & "'"

                Using oCmd As New SqlCommand(sSQL, CNDB)
                    oCmd.ExecuteNonQuery()
                End Using
                XtraMessageBox.Show("Η εγγραφή διαγράφηκε με επιτυχία", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Information)
                LoadForms.LoadDataToGrid(Frm.GridControl1, Frm.GridView1, "select ID,cctID,filename,comefrom,createdon,realname From vw_CCT_F where cctID = '" & ID & "'")
                LoadForms.RestoreLayoutFromXml(Frm.GridView1, "vw_CCT_F_def.xml")
            End If

        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub
    Public Sub SaveRecord()
        Dim sResult As Boolean
        Dim sGuid As String
        Try
            If Valid.ValidateForm(Frm.LayoutControl1) Then
                Select Case Mode
                    Case FormMode.NewRecord
                        sGuid = System.Guid.NewGuid.ToString
                        sResult = DBQ.InsertData(Frm.LayoutControl1, "CCT", sGuid)
                    Case FormMode.EditRecord
                        sResult = DBQ.UpdateData(Frm.LayoutControl1, "CCT", ID)
                        sGuid = ID
                End Select

                If Frm.txtFileNames.Text <> "" And sResult = True Then
                    sResult = DBQ.InsertDataFiles(Frm.XtraOpenFileDialog1, sGuid, "CCT_F")
                    LoadForms.LoadDataToGrid(Frm.GridControl1, Frm.GridView1, "select ID,cctID,files,filename,comefrom,createdon,realname From vw_CCT_F where isINVOICE = 0 AND cctID = '" & sGuid & "'")
                    LoadForms.RestoreLayoutFromXml(Frm.GridView1, "vw_CCT_F_def.xml")
                End If
                Frm.txtCode.Text = DBQ.GetNextId("CCT")
                If CalledFromCtrl Then
                    Dim FillCbo As New FillCombos
                    If Frm.chkCompany.CheckState = CheckState.Checked Then FillCbo.COMPANY(CtrlCombo) Else FillCbo.CUS(CtrlCombo)
                    CtrlCombo.EditValue = System.Guid.Parse(sGuid)
                    FillCbo = Nothing
                End If
                'Cls.ClearCtrls(LayoutControl1)
                If sResult = True Then
                    XtraMessageBox.Show("Η εγγραφή αποθηκέυτηκε με επιτυχία", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Information)

                    Mode = FormMode.EditRecord
                    Frm.txtFileNames.Text = ""
                    If XtraMessageBox.Show("Θέλετε να καταχωρήσετε κίνηση στον πελάτη?", ProgProps.ProgTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                        Dim form1 As frmCusMov = New frmCusMov()
                        form1.Text = "Κινήσεις Πελατών"
                        form1.MdiParent = frmMain
                        form1.Mode = FormMode.NewRecord
                        form1.FormScrollerExist = False
                        form1.CusID = sGuid
                        frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(form1), New Point(CInt(form1.Parent.ClientRectangle.Width / 2 - form1.Width / 2), CInt(form1.Parent.ClientRectangle.Height / 2 - form1.Height / 2)))
                        form1.Show()
                    End If
                End If
            End If

        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Public Function GetNextID() As Integer
        Return DBQ.GetNextId("CCT")
    End Function
End Class
