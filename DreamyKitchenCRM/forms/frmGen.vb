Imports System.Data.SqlClient
Imports System.IO
Imports System.Threading
Imports DevExpress.CodeParser
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraExport.Xls
Public Class frmGen
    Private sID As String
    Private Ctrl As DevExpress.XtraGrid.Views.Grid.GridView
    Private CtrlCombo As DevExpress.XtraEditors.LookUpEdit
    Private Frm As DevExpress.XtraEditors.XtraForm
    Private FrmCaller As DevExpress.XtraEditors.XtraForm
    Public Mode As Byte
    Private CalledFromCtrl As Boolean
    Private Valid As New ValidateControls
    Private Log As New Transactions
    Private DBQ As New DBQueries
    Private FillCbo As New FillCombos
    Private sDataTable As String
    Private S As New System.Text.StringBuilder
    Private Cls As New ClearControls
    Private LoadForms As New FormLoader

    Public WriteOnly Property ID As String
        Set(value As String)
            sID = value
        End Set
    End Property
    Public WriteOnly Property CallerForm As DevExpress.XtraEditors.XtraForm
        Set(value As DevExpress.XtraEditors.XtraForm)
            FrmCaller = value
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

    Public WriteOnly Property DataTable As String
        Set(value As String)
            sDataTable = value
        End Set
    End Property

    Private Sub cmdExit_Click(sender As Object, e As EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub

    Private Sub frmGen_Load(sender As Object, e As EventArgs) Handles Me.Load
        LoadGen()
        Me.CenterToScreen()
        My.Settings.frmGen = Me.Location
        My.Settings.Save()
    End Sub

    Private Sub cmdNew_Click(sender As Object, e As EventArgs) Handles cmdNew.Click
        Mode = FormMode.NewRecord
        Cls.ClearCtrls(LayoutControl1)
        LoadGen()
    End Sub

    Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click
        Dim sGuid As String
        Dim sResult As Boolean
        Try
            If Valid.ValidateForm(LayoutControl1) Then
                Select Case Mode
                    Case FormMode.NewRecord
                        Select Case sDataTable
                            Case "JOBS"
                                sGuid = System.Guid.NewGuid.ToString
                                sResult = DBQ.InsertData(LayoutControl1, "JOBS", sGuid)
                                If CalledFromCtrl Then
                                    FillCbo.JOBS(CtrlCombo)
                                    CtrlCombo.EditValue = System.Guid.Parse(sGuid)
                                Else

                                    Dim form As frmScroller = Frm
                                    form.LoadRecords("vw_JOBS")
                                End If
                                'Καθαρισμός Controls
                                Cls.ClearCtrls(LayoutControl1)
                                txtCode.Text = DBQ.GetNextId("JOBS")
                            Case "CONSTR_CAT"
                                sGuid = System.Guid.NewGuid.ToString
                                sResult = DBQ.InsertData(LayoutControl1, "CONSTR_CAT", sGuid)
                                If CalledFromCtrl Then
                                    FillCbo.CONSTR_CAT(CtrlCombo)
                                    CtrlCombo.EditValue = System.Guid.Parse(sGuid)
                                Else
                                    Dim form As frmScroller = Frm
                                    form.LoadRecords("vw_CONSTR_CAT")
                                End If
                                'Καθαρισμός Controls
                                Cls.ClearCtrls(LayoutControl1)
                                txtCode.Text = DBQ.GetNextId("CONSTR_CAT")
                            Case "EMP_M_S"
                                sGuid = System.Guid.NewGuid.ToString
                                sResult = DBQ.InsertData(LayoutControl1, "EMP_M_S", sGuid)
                                If CalledFromCtrl Then
                                    FillCbo.EMP_M_S(CtrlCombo)
                                    CtrlCombo.EditValue = System.Guid.Parse(sGuid)
                                Else
                                    Dim form As frmScroller = Frm
                                    form.LoadRecords("vw_EMP_M_S")
                                End If
                                'Καθαρισμός Controls
                                Cls.ClearCtrls(LayoutControl1)
                                txtCode.Text = DBQ.GetNextId("EMP_M_S")
                            Case "SALER_CAL_STATUS"
                                sGuid = System.Guid.NewGuid.ToString
                                sResult = DBQ.InsertData(LayoutControl1, "SALER_CAL_STATUS", sGuid)
                                If CalledFromCtrl Then
                                    FillCbo.SALER_CAL_STATUS(CtrlCombo)
                                    CtrlCombo.EditValue = System.Guid.Parse(sGuid)
                                Else
                                    Dim form As frmScroller = Frm
                                    form.LoadRecords("vw_SALER_CAL_STATUS")
                                End If
                                'Καθαρισμός Controls
                                Cls.ClearCtrls(LayoutControl1)
                                txtCode.Text = DBQ.GetNextId("SALER_CAL_STATUS")
                            Case "EMP_S"
                                sGuid = System.Guid.NewGuid.ToString
                                sResult = DBQ.InsertData(LayoutControl1, "EMP_S", sGuid)
                                If CalledFromCtrl Then
                                    FillCbo.EMP_S(CtrlCombo)
                                    CtrlCombo.EditValue = System.Guid.Parse(sGuid)
                                Else
                                    Dim form As frmScroller = Frm
                                    form.LoadRecords("vw_EMP_S")
                                End If
                                'Καθαρισμός Controls
                                Cls.ClearCtrls(LayoutControl1)
                                txtCode.Text = DBQ.GetNextId("EMP_S")
                            Case "DEP"
                                sGuid = System.Guid.NewGuid.ToString
                                sResult = DBQ.InsertData(LayoutControl1, "DEP", sGuid)
                                If CalledFromCtrl Then
                                    FillCbo.DEP(CtrlCombo)
                                    CtrlCombo.EditValue = System.Guid.Parse(sGuid)
                                Else
                                    Dim form As frmScroller = Frm
                                    form.LoadRecords("vw_DEP")
                                End If
                                'Καθαρισμός Controls
                                Cls.ClearCtrls(LayoutControl1)
                                txtCode.Text = DBQ.GetNextId("DEP")
                            Case "BANKS"
                                sGuid = System.Guid.NewGuid.ToString
                                sResult = DBQ.InsertData(LayoutControl1, "BANKS", sGuid)
                                If CalledFromCtrl Then
                                    FillCbo.BANKS(CtrlCombo)
                                    CtrlCombo.EditValue = System.Guid.Parse(sGuid)
                                Else
                                    Dim form As frmScroller = Frm
                                    form.LoadRecords("vw_BANKS")
                                End If
                                'Καθαρισμός Controls
                                Cls.ClearCtrls(LayoutControl1)
                                txtCode.Text = DBQ.GetNextId("BANKS")
                            Case "SER"
                                sGuid = System.Guid.NewGuid.ToString
                                sResult = DBQ.InsertData(LayoutControl1, "SER", sGuid)
                                If CalledFromCtrl Then
                                    FillCbo.SER(CtrlCombo)
                                    CtrlCombo.EditValue = System.Guid.Parse(sGuid)
                                Else
                                    Dim form As frmScroller = Frm
                                    form.LoadRecords("vw_SER")
                                End If
                                'Καθαρισμός Controls
                                Cls.ClearCtrls(LayoutControl1)
                                txtCode.Text = DBQ.GetNextId("SER")
                            Case "COU"
                                sGuid = System.Guid.NewGuid.ToString
                                sResult = DBQ.InsertData(LayoutControl1, "COU", sGuid)
                                If CalledFromCtrl Then
                                    FillCbo.COU(CtrlCombo)
                                    CtrlCombo.EditValue = System.Guid.Parse(sGuid)
                                Else
                                    Dim form As frmScroller = Frm
                                    form.LoadRecords("vw_COU")
                                End If
                                'Καθαρισμός Controls
                                Cls.ClearCtrls(LayoutControl1)
                                txtCode.Text = DBQ.GetNextId("COU")
                            Case "AREAS"
                                sGuid = System.Guid.NewGuid.ToString
                                sResult = DBQ.InsertData(LayoutControl1, "AREAS", sGuid)
                                If CalledFromCtrl Then
                                    FillCbo.AREAS(CtrlCombo, S)
                                    CtrlCombo.EditValue = System.Guid.Parse(sGuid)
                                Else
                                    Dim form As frmScroller = Frm
                                    form.LoadRecords("vw_AREAS")
                                End If
                                'Καθαρισμός Controls
                                Cls.ClearCtrls(LayoutControl1)
                                txtCode.Text = DBQ.GetNextId("AREAS")
                            Case "ADR"
                                sGuid = System.Guid.NewGuid.ToString
                                sResult = DBQ.InsertData(LayoutControl1, "ADR", sGuid)
                                If CalledFromCtrl Then
                                    FillCbo.ADR(CtrlCombo, S)
                                    CtrlCombo.EditValue = System.Guid.Parse(sGuid)
                                Else
                                    Dim form As frmScroller = Frm
                                    form.LoadRecords("vw_ADR")
                                End If
                                'Καθαρισμός Controls
                                Cls.ClearCtrls(LayoutControl1)
                                txtCode.Text = DBQ.GetNextId("ADR")
                            Case "DOY"
                                sGuid = System.Guid.NewGuid.ToString
                                sResult = DBQ.InsertData(LayoutControl1, "DOY", sGuid)
                                If CalledFromCtrl Then
                                    FillCbo.DOY(CtrlCombo)
                                    CtrlCombo.EditValue = System.Guid.Parse(sGuid)
                                Else
                                    Dim form As frmScroller = Frm
                                    form.LoadRecords("vw_DOY")
                                End If
                                'Καθαρισμός Controls
                                Cls.ClearCtrls(LayoutControl1)
                                txtCode.Text = DBQ.GetNextId("DOY")
                            Case "PRF"
                                sGuid = System.Guid.NewGuid.ToString
                                sResult = DBQ.InsertData(LayoutControl1, "PRF", sGuid)
                                If CalledFromCtrl Then
                                    FillCbo.PRF(CtrlCombo)
                                    CtrlCombo.EditValue = System.Guid.Parse(sGuid)
                                Else
                                    Dim form As frmScroller = Frm
                                    form.LoadRecords("vw_PRF")
                                End If
                                'Καθαρισμός Controls
                                Cls.ClearCtrls(LayoutControl1)
                                txtCode.Text = DBQ.GetNextId("PRF")
                            Case "STATUS"
                                sGuid = System.Guid.NewGuid.ToString
                                sResult = DBQ.InsertData(LayoutControl1, "STATUS", sGuid)
                                If CalledFromCtrl Then
                                    FillCbo.STATUS(CtrlCombo)
                                    CtrlCombo.EditValue = System.Guid.Parse(sGuid)
                                Else
                                    Dim form As frmScroller = Frm
                                    form.LoadRecords("vw_STATUS")
                                End If
                                'Καθαρισμός Controls
                                Cls.ClearCtrls(LayoutControl1)
                                txtCode.Text = DBQ.GetNextId("STATUS")
                            Case "SRC"
                                sGuid = System.Guid.NewGuid.ToString
                                sResult = DBQ.InsertData(LayoutControl1, "SRC", sGuid)
                                If CalledFromCtrl Then
                                    FillCbo.SRC(CtrlCombo)
                                    CtrlCombo.EditValue = System.Guid.Parse(sGuid)
                                Else
                                    Dim form As frmScroller = Frm
                                    form.LoadRecords("vw_SOURCE")
                                End If
                                'Καθαρισμός Controls
                                Cls.ClearCtrls(LayoutControl1)
                                txtCode.Text = DBQ.GetNextId("SRC")
                            Case "SALERS"
                                sGuid = System.Guid.NewGuid.ToString
                                sResult = DBQ.InsertData(LayoutControl1, "SALERS", sGuid)
                                If CalledFromCtrl Then
                                    FillCbo.SALERS(CtrlCombo)
                                    CtrlCombo.EditValue = System.Guid.Parse(sGuid)
                                Else
                                    Dim form As frmScroller = Frm
                                    form.LoadRecords("vw_SALERS")
                                End If
                                'Καθαρισμός Controls
                                Cls.ClearCtrls(LayoutControl1)
                                txtCode.Text = DBQ.GetNextId("SALERS")
                            Case "NOTES_L"
                                sGuid = System.Guid.NewGuid.ToString
                                sResult = DBQ.InsertData(LayoutControl1, "NOTES_L", sGuid)
                                If CalledFromCtrl Then
                                    FillCbo.NOTES_L(CtrlCombo)
                                    CtrlCombo.EditValue = System.Guid.Parse(sGuid)
                                Else
                                    Dim form As frmScroller = Frm
                                    form.LoadRecords("vw_NOTES_L")
                                End If
                                'Καθαρισμός Controls
                                Cls.ClearCtrls(LayoutControl1)
                                txtCode.Text = DBQ.GetNextId("NOTES_L")
                            Case "CAT_ERM"
                                sGuid = System.Guid.NewGuid.ToString
                                sResult = DBQ.InsertData(LayoutControl1, "CAT_ERM", sGuid)
                                If CalledFromCtrl Then
                                    FillCbo.CAT_ERM(CtrlCombo)
                                    CtrlCombo.EditValue = System.Guid.Parse(sGuid)
                                Else
                                    Dim form As frmScroller = Frm
                                    form.LoadRecords("vw_CAT_ERM")
                                End If
                                'Καθαρισμός Controls
                                Cls.ClearCtrls(LayoutControl1)
                                txtCode.Text = DBQ.GetNextId("CAT_ERM")
                            Case "TECH_CAT"
                                sGuid = System.Guid.NewGuid.ToString
                                sResult = DBQ.InsertNewData(DBQueries.InsertMode.OneLayoutControl, "TECH_CAT", LayoutControl1,,, sGuid, True)
                                If CalledFromCtrl Then
                                    FillCbo.TECH_CAT(CtrlCombo)
                                    CtrlCombo.EditValue = System.Guid.Parse(sGuid)
                                Else
                                    Dim form As New frmScroller
                                    form = Frm
                                    form.LoadRecords("vw_TECH_CAT")
                                End If
                                'Καθαρισμός Controls
                                Cls.ClearCtrls(LayoutControl1)
                                txtCode.Text = DBQ.GetNextId("TECH_CAT")
                            Case "COLORS_CAT"
                                sGuid = System.Guid.NewGuid.ToString
                                sResult = DBQ.InsertNewData(DBQueries.InsertMode.OneLayoutControl, "COLORS_CAT", LayoutControl1,,, sGuid, True)
                                If CalledFromCtrl Then
                                    FillCbo.COLORS_CAT(CtrlCombo)
                                    CtrlCombo.EditValue = System.Guid.Parse(sGuid)
                                Else
                                    Dim form As New frmScroller
                                    form = Frm
                                    form.LoadRecords("vw_COLORS_CAT")
                                End If
                                'Καθαρισμός Controls
                                Cls.ClearCtrls(LayoutControl1)
                                txtCode.Text = DBQ.GetNextId("COLORS_CAT")
                            Case "DIM"
                                sGuid = System.Guid.NewGuid.ToString
                                sResult = DBQ.InsertData(LayoutControl1, "DIM", sGuid)
                                If CalledFromCtrl Then
                                    FillCbo.DIMENSION(CtrlCombo)
                                    CtrlCombo.EditValue = System.Guid.Parse(sGuid)
                                Else
                                    Dim form As frmScroller = Frm
                                    form.LoadRecords("vw_DIM")
                                End If
                                'Καθαρισμός Controls
                                Cls.ClearCtrls(LayoutControl1)
                                txtCode.Text = DBQ.GetNextId("DIM")


                        End Select
                    Case FormMode.EditRecord
                        Select Case sDataTable
                            Case "JOBS"
                                sResult = DBQ.UpdateData(LayoutControl1, "JOBS", sID)
                                If CalledFromCtrl Then
                                    FillCbo.JOBS(CtrlCombo)
                                    CtrlCombo.EditValue = System.Guid.Parse(sID)
                                Else
                                    Dim form As frmScroller = Frm
                                    form.LoadRecords("vw_JOBS")
                                End If
                            Case "CONSTR_CAT"
                                sResult = DBQ.UpdateData(LayoutControl1, "CONSTR_CAT", sID)
                                If CalledFromCtrl Then
                                    FillCbo.CONSTR_CAT(CtrlCombo)
                                    CtrlCombo.EditValue = System.Guid.Parse(sID)
                                Else
                                    Dim form As frmScroller = Frm
                                    form.LoadRecords("vw_CONSTR_CAT")
                                End If
                            Case "EMP_M_S"
                                sResult = DBQ.UpdateData(LayoutControl1, "EMP_M_S", sID)
                                If CalledFromCtrl Then
                                    FillCbo.EMP_M_S(CtrlCombo)
                                    CtrlCombo.EditValue = System.Guid.Parse(sID)
                                Else
                                    Dim form As frmScroller = Frm
                                    form.LoadRecords("vw_EMP_M_S")
                                End If
                            Case "SALER_CAL_STATUS"
                                sResult = DBQ.UpdateData(LayoutControl1, "SALER_CAL_STATUS", sID)
                                If CalledFromCtrl Then
                                    FillCbo.SALER_CAL_STATUS(CtrlCombo)
                                    CtrlCombo.EditValue = System.Guid.Parse(sID)
                                Else
                                    Dim form As frmScroller = Frm
                                    form.LoadRecords("vw_SALER_CAL_STATUS")
                                End If
                            Case "EMP_S"
                                sResult = DBQ.UpdateData(LayoutControl1, "EMP_S", sID)
                                If CalledFromCtrl Then
                                    FillCbo.EMP_S(CtrlCombo)
                                    CtrlCombo.EditValue = System.Guid.Parse(sID)
                                Else
                                    Dim form As frmScroller = Frm
                                    form.LoadRecords("vw_EMP_S")
                                End If
                            Case "DEP"
                                sResult = DBQ.UpdateData(LayoutControl1, "DEP", sID)
                                If CalledFromCtrl Then
                                    FillCbo.DEP(CtrlCombo)
                                    CtrlCombo.EditValue = System.Guid.Parse(sID)
                                Else
                                    Dim form As frmScroller = Frm
                                    form.LoadRecords("vw_DEP")
                                End If
                            Case "BANKS"
                                sResult = DBQ.UpdateData(LayoutControl1, "BANKS", sID)
                                If CalledFromCtrl Then
                                    FillCbo.BANKS(CtrlCombo)
                                    CtrlCombo.EditValue = System.Guid.Parse(sID)
                                Else
                                    Dim form As frmScroller = Frm
                                    form.LoadRecords("vw_BANKS")
                                End If
                            Case "SER"
                                sResult = DBQ.UpdateData(LayoutControl1, "SER", sID)
                                If CalledFromCtrl Then
                                    FillCbo.SER(CtrlCombo)
                                    CtrlCombo.EditValue = System.Guid.Parse(sID)
                                Else
                                    Dim form As frmScroller = Frm
                                    form.LoadRecords("vw_SER")
                                End If
                            Case "COU"
                                sResult = DBQ.UpdateData(LayoutControl1, "COU", sID)
                                If CalledFromCtrl Then
                                    FillCbo.COU(CtrlCombo)
                                    CtrlCombo.EditValue = System.Guid.Parse(sID)
                                Else
                                    Dim form As frmScroller = Frm
                                    form.LoadRecords("vw_COU")
                                End If
                            Case "AREAS"
                                sResult = DBQ.UpdateData(LayoutControl1, "AREAS", sID)
                                If CalledFromCtrl Then
                                    FillCbo.AREAS(CtrlCombo, S)
                                    CtrlCombo.EditValue = System.Guid.Parse(sID)
                                Else
                                    Dim form As frmScroller = Frm
                                    form.LoadRecords("vw_AREAS")
                                End If
                            Case "ADR"
                                sResult = DBQ.UpdateData(LayoutControl1, "ADR", sID)
                                If CalledFromCtrl Then
                                    FillCbo.ADR(CtrlCombo, S)
                                    CtrlCombo.EditValue = System.Guid.Parse(sID)
                                Else
                                    Dim form As frmScroller = Frm
                                    form.LoadRecords("vw_ADR")
                                End If
                            Case "DOY"
                                sResult = DBQ.UpdateData(LayoutControl1, "DOY", sID)
                                If CalledFromCtrl Then
                                    FillCbo.DOY(CtrlCombo)
                                    CtrlCombo.EditValue = System.Guid.Parse(sID)
                                Else
                                    Dim form As frmScroller = Frm
                                    form.LoadRecords("vw_DOY")
                                End If
                            Case "PRF"
                                sResult = DBQ.UpdateData(LayoutControl1, "PRF", sID)
                                If CalledFromCtrl Then
                                    FillCbo.PRF(CtrlCombo)
                                    CtrlCombo.EditValue = System.Guid.Parse(sID)
                                Else
                                    Dim form As frmScroller = Frm
                                    form.LoadRecords("vw_PRF")
                                End If
                            Case "STATUS"
                                sResult = DBQ.UpdateData(LayoutControl1, "STATUS", sID)
                                If CalledFromCtrl Then
                                    FillCbo.STATUS(CtrlCombo)
                                    CtrlCombo.EditValue = System.Guid.Parse(sID)
                                Else
                                    Dim form As frmScroller = Frm
                                    form.LoadRecords("vw_STATUS")
                                End If
                            Case "SRC"
                                sResult = DBQ.UpdateData(LayoutControl1, "SRC", sID)
                                If CalledFromCtrl Then
                                    FillCbo.SRC(CtrlCombo)
                                    CtrlCombo.EditValue = System.Guid.Parse(sID)
                                Else
                                    Dim form As frmScroller = Frm
                                    form.LoadRecords("vw_SOURCE")
                                End If
                            Case "SALERS"
                                sResult = DBQ.UpdateData(LayoutControl1, "SALERS", sID)
                                If CalledFromCtrl Then
                                    FillCbo.SALERS(CtrlCombo)
                                    CtrlCombo.EditValue = System.Guid.Parse(sID)
                                Else
                                    Dim form As frmScroller = Frm
                                    form.LoadRecords("vw_SALERS")
                                End If
                            Case "NOTES_L"
                                sResult = DBQ.UpdateData(LayoutControl1, "NOTES_L", sID)
                                If CalledFromCtrl Then
                                    FillCbo.NOTES_L(CtrlCombo)
                                    CtrlCombo.EditValue = System.Guid.Parse(sID)
                                Else
                                    Dim form As frmScroller = Frm
                                    form.LoadRecords("vw_NOTES_L")
                                End If
                            Case "CAT_ERM"
                                sResult = DBQ.UpdateData(LayoutControl1, "CAT_ERM", sID)
                                If CalledFromCtrl Then
                                    FillCbo.CAT_ERM(CtrlCombo)
                                    CtrlCombo.EditValue = System.Guid.Parse(sGuid)
                                Else
                                    Dim form As frmScroller = Frm
                                    form.LoadRecords("vw_CAT_ERM")
                                End If
                            Case "TECH_CAT"
                                sResult = DBQ.UpdateNewData(DBQueries.InsertMode.OneLayoutControl, "TECH_CAT", LayoutControl1,,, sID, True)
                                If CalledFromCtrl Then
                                    FillCbo.TECH_CAT(CtrlCombo)
                                    CtrlCombo.EditValue = System.Guid.Parse(sID)
                                Else
                                    Dim form As New frmScroller
                                    form = Frm
                                    form.LoadRecords("vw_TECH_CAT")
                                End If
                            Case "COLORS_CAT"
                                sResult = DBQ.UpdateNewData(DBQueries.InsertMode.OneLayoutControl, "COLORS_CAT", LayoutControl1,,, sID, True)
                                If CalledFromCtrl Then
                                    FillCbo.COLORS_CAT(CtrlCombo)
                                    CtrlCombo.EditValue = System.Guid.Parse(sGuid)
                                Else
                                    Dim form As New frmScroller
                                    form = Frm
                                    form.LoadRecords("vw_COLORS_CAT")
                                End If
                            Case "DIM"
                                sResult = DBQ.UpdateNewData(DBQueries.InsertMode.OneLayoutControl, "DIM", LayoutControl1,,, sID, True)
                                If CalledFromCtrl Then
                                    FillCbo.DIMENSION(CtrlCombo)
                                    CtrlCombo.EditValue = System.Guid.Parse(sGuid)
                                Else
                                    Dim form As New frmScroller
                                    form = Frm
                                    form.LoadRecords("vw_DIM")
                                End If
                        End Select
                End Select
                If sResult Then XtraMessageBox.Show("Η εγγραφή αποθηκέυτηκε με επιτυχία", "Dreamy Kitchen CRM", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), "Dreamy Kitchen CRM", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub LoadGen()
        Select Case sDataTable
            Case "JOBS"
                If Mode = FormMode.NewRecord Then
                    txtCode.Text = DBQ.GetNextId("JOBS")
                Else
                    LoadForms.LoadForm(LayoutControl1, "Select * from vw_JOBS where id ='" + sID + "'")
                End If
            Case "CONSTR_CAT"
                If Mode = FormMode.NewRecord Then
                    txtCode.Text = DBQ.GetNextId("CONSTR_CAT")
                Else
                    LoadForms.LoadForm(LayoutControl1, "Select * from vw_CONSTR_CAT where id ='" + sID + "'")
                End If
            Case "EMP_M_S"
                If Mode = FormMode.NewRecord Then
                    txtCode.Text = DBQ.GetNextId("EMP_M_S")
                Else
                    LoadForms.LoadForm(LayoutControl1, "Select * from vw_EMP_M_S where id ='" + sID + "'")
                End If
            Case "SALER_CAL_STATUS"
                If Mode = FormMode.NewRecord Then
                    txtCode.Text = DBQ.GetNextId("SALER_CAL_STATUS")
                Else
                    LoadForms.LoadForm(LayoutControl1, "Select * from vw_SALER_CAL_STATUS where id ='" + sID + "'")
                End If

            Case "EMP_S"
                If Mode = FormMode.NewRecord Then
                    txtCode.Text = DBQ.GetNextId("EMP_S")
                Else
                    LoadForms.LoadForm(LayoutControl1, "Select * from vw_EMP_S where id ='" + sID + "'")
                End If

            Case "DEP"
                If Mode = FormMode.NewRecord Then
                    txtCode.Text = DBQ.GetNextId("DEP")
                Else
                    LoadForms.LoadForm(LayoutControl1, "Select * from vw_DEP where id ='" + sID + "'")
                End If

            Case "BANKS"
                If Mode = FormMode.NewRecord Then
                    txtCode.Text = DBQ.GetNextId("BANKS")
                Else
                    LoadForms.LoadForm(LayoutControl1, "Select * from vw_BANKS where id ='" + sID + "'")
                End If

            Case "SER"
                If Mode = FormMode.NewRecord Then
                    txtCode.Text = DBQ.GetNextId("SER")
                Else
                    LoadForms.LoadForm(LayoutControl1, "Select * from vw_SER where id ='" + sID + "'")
                End If
            Case "COU"
                If Mode = FormMode.NewRecord Then
                    txtCode.Text = DBQ.GetNextId("COU")
                Else
                    LoadForms.LoadForm(LayoutControl1, "Select * from vw_COU where id ='" + sID + "'")
                End If
            Case "AREAS"
                FillCbo.COU(cbo1)
                If Mode = FormMode.NewRecord Then
                    txtCode.Text = DBQ.GetNextId("AREAS")
                Else
                    LoadForms.LoadForm(LayoutControl1, "Select * from vw_AREAS where id ='" + sID + "'")
                End If
            Case "ADR"
                FillCbo.COU(cbo1)
                Dim sSQL As New System.Text.StringBuilder
                FillCbo.AREAS(cbo2, sSQL)
                If Mode = FormMode.NewRecord Then
                    txtCode.Text = DBQ.GetNextId("ADR")
                Else
                    LoadForms.LoadForm(LayoutControl1, "Select * from vw_ADR where id ='" + sID + "'")
                End If
            Case "DOY"
                If Mode = FormMode.NewRecord Then
                    txtCode.Text = DBQ.GetNextId("DOY")
                Else
                    LoadForms.LoadForm(LayoutControl1, "Select * from vw_DOY where id ='" + sID + "'")
                End If
            Case "PRF"
                If Mode = FormMode.NewRecord Then
                    txtCode.Text = DBQ.GetNextId("PRF")
                Else
                    LoadForms.LoadForm(LayoutControl1, "Select * from vw_PRF where id ='" + sID + "'")
                End If
            Case "STATUS"
                If Mode = FormMode.NewRecord Then
                    txtCode.Text = DBQ.GetNextId("STATUS")
                Else
                    LoadForms.LoadForm(LayoutControl1, "Select * from vw_STATUS where id ='" + sID + "'")
                End If
            Case "SRC"
                If Mode = FormMode.NewRecord Then
                    txtCode.Text = DBQ.GetNextId("SRC")
                Else
                    LoadForms.LoadForm(LayoutControl1, "Select * from vw_SOURCE where id ='" + sID + "'")
                End If
            Case "SALERS"
                If Mode = FormMode.NewRecord Then
                    txtCode.Text = DBQ.GetNextId("SALERS")
                Else
                    LoadForms.LoadForm(LayoutControl1, "Select * from vw_SALERS where id ='" + sID + "'")
                End If
            Case "NOTES_L"
                If Mode = FormMode.NewRecord Then
                    txtCode.Text = DBQ.GetNextId("NOTES_L")
                Else
                    LoadForms.LoadForm(LayoutControl1, "Select * from vw_NOTES_L where id ='" + sID + "'")
                End If
            Case "CAT_ERM"
                If Mode = FormMode.NewRecord Then
                    txtCode.Text = DBQ.GetNextId("CAT_ERM")
                Else
                    LoadForms.LoadForm(LayoutControl1, "Select * from vw_CAT_ERM where id ='" + sID + "'")
                End If
            Case "TECH_CAT"
                If Mode = FormMode.NewRecord Then
                    txtCode.Text = DBQ.GetNextId("TECH_CAT")
                Else
                    LoadForms.LoadForm(LayoutControl1, "Select * from vw_TECH_CAT where id ='" + sID + "'")
                End If
            Case "COLORS_CAT"
                If Mode = FormMode.NewRecord Then
                    txtCode.Text = DBQ.GetNextId("COLORS_CAT")
                Else
                    LoadForms.LoadForm(LayoutControl1, "Select * from vw_COLORS_CAT where id ='" + sID + "'")
                End If
            Case "DIM"
                If Mode = FormMode.NewRecord Then
                    txtCode.Text = DBQ.GetNextId("DIM")
                Else
                    LoadForms.LoadForm(LayoutControl1, "Select * from vw_DIM where id ='" + sID + "'")
                End If
        End Select
        cmdSave.Enabled = IIf(Mode = FormMode.NewRecord, UserProps.AllowInsert, UserProps.AllowEdit)
        cmdDelete.Enabled = IIf(Mode = FormMode.NewRecord, False, UserProps.AllowDelete)
        txtName.Select()
    End Sub

    Private Sub cmdDelete_Click(sender As Object, e As EventArgs) Handles cmdDelete.Click
        DeleteRecord()
    End Sub
    'Διαγραφη Εγγραφής
    Private Sub DeleteRecord()
        Dim sSQL As String
        Try
            If XtraMessageBox.Show("Θέλετε να διαγραφεί η τρέχουσα εγγραφή?", "Dreamy Kitchen CRM", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                sSQL = "DELETE FROM " & sDataTable & " WHERE ID = " & toSQLValueS(sID)
                Using oCmd As New SqlCommand(sSQL, CNDB)
                    oCmd.ExecuteNonQuery()
                End Using

                Select Case sDataTable
                    Case "JOBS"
                        If CalledFromCtrl Then
                            FillCbo.JOBS(CtrlCombo)
                        Else
                            Dim form As frmScroller = Frm
                            form.LoadRecords("vw_JOBS")
                        End If
                    Case "CONSTR_CAT"
                        If CalledFromCtrl Then
                            FillCbo.CONSTR_CAT(CtrlCombo)
                        Else
                            Dim form As frmScroller = Frm
                            form.LoadRecords("vw_CONSTR_CAT")
                        End If

                    Case "EMP_M_S "
                        If CalledFromCtrl Then
                            FillCbo.EMP_M_S(CtrlCombo)
                        Else
                            Dim form As frmScroller = Frm
                            form.LoadRecords("vw_EMP_M_S")
                        End If

                    Case "SALER_CAL_STATUS"
                        If CalledFromCtrl Then
                            FillCbo.SALER_CAL_STATUS(CtrlCombo)
                        Else
                            Dim form As frmScroller = Frm
                            form.LoadRecords("vw_SALER_CAL_STATUS")
                        End If

                    Case "EMP_S"
                        If CalledFromCtrl Then
                            FillCbo.EMP_S(CtrlCombo)
                        Else
                            Dim form As frmScroller = Frm
                            form.LoadRecords("vw_EMP_S")
                        End If
                    Case "DEP"
                        If CalledFromCtrl Then
                            FillCbo.DEP(CtrlCombo)
                        Else
                            Dim form As frmScroller = Frm
                            form.LoadRecords("vw_DEP")
                        End If
                    Case "BANKS"
                        If CalledFromCtrl Then
                            FillCbo.BANKS(CtrlCombo)
                        Else
                            Dim form As frmScroller = Frm
                            form.LoadRecords("vw_BANKS")
                        End If
                    Case "SER"
                        If CalledFromCtrl Then
                            FillCbo.SER(CtrlCombo)
                        Else
                            Dim form As frmScroller = Frm
                            form.LoadRecords("vw_SER")
                        End If
                    Case "COU"
                        If CalledFromCtrl Then
                            FillCbo.COU(CtrlCombo)
                        Else
                            Dim form As frmScroller = Frm
                            form.LoadRecords("vw_COU")
                        End If
                    Case "AREAS"
                        If CalledFromCtrl Then
                            FillCbo.AREAS(CtrlCombo, S)
                        Else
                            Dim form As frmScroller = Frm
                            form.LoadRecords("vw_AREAS")
                        End If
                    Case "ADR"
                        If CalledFromCtrl Then
                            FillCbo.ADR(CtrlCombo, S)
                        Else
                            Dim form As frmScroller = Frm
                            form.LoadRecords("vw_ADR")
                        End If
                    Case "DOY"
                        If CalledFromCtrl Then
                            FillCbo.DOY(CtrlCombo)
                        Else
                            Dim form As frmScroller = Frm
                            form.LoadRecords("vw_DOY")
                        End If
                    Case "PRF"
                        If CalledFromCtrl Then
                            FillCbo.PRF(CtrlCombo)
                        Else
                            Dim form As frmScroller = Frm
                            form.LoadRecords("vw_PRF")
                        End If
                    Case "SALERS"
                        If CalledFromCtrl Then
                            FillCbo.SALERS(CtrlCombo)
                        Else
                            Dim form As frmScroller = Frm
                            form.LoadRecords("vw_SALERS")
                        End If
                    Case "NOTES_L"
                        If CalledFromCtrl Then
                            FillCbo.NOTES_L(CtrlCombo)
                        Else
                            Dim form As frmScroller = Frm
                            form.LoadRecords("vw_NOTES_L")
                        End If
                    Case "TECH_CAT"
                        If CalledFromCtrl Then
                            FillCbo.TECH_CAT(CtrlCombo)
                        Else
                            Dim form As New frmScroller
                            form.LoadRecords("vw_TECH_CAT")
                        End If
                    Case "COLORS_CAT"
                        If CalledFromCtrl Then
                            FillCbo.COLORS_CAT(CtrlCombo)
                        Else
                            Dim form As New frmScroller
                            form.LoadRecords("vw_COLORS_CAT")
                        End If
                    Case "DIM"
                        If CalledFromCtrl Then
                            FillCbo.DIMENSION(CtrlCombo)
                        Else
                            Dim form As New frmScroller
                            form.LoadRecords("vw_DIM")
                        End If
                End Select
                Cls.ClearCtrls(LayoutControl1)
                txtCode.Text = DBQ.GetNextId(sDataTable)
                If CalledFromCtrl Then CtrlCombo.EditValue = Nothing

                XtraMessageBox.Show("Η εγγραφή διαγράφηκε με επιτυχία", "Dreamy Kitchen CRM", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), "Dreamy Kitchen CRM", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ColorPickEdit1_EditValueChanged(sender As Object, e As EventArgs) Handles ColorPickEdit1.EditValueChanged

    End Sub

    Private Sub ColorPickEdit1_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles ColorPickEdit1.ButtonClick
        Select Case e.Button.Index
            Case 1 : ColorPickEdit1.EditValue = Nothing
        End Select
    End Sub

    'Private Sub cbo1_GotFocus(sender As Object, e As EventArgs) Handles cbo1.GotFocus
    '    frmMain.bbFields.Caption = "DB Field: " & sDataTable & ".couid"
    'End Sub

    'Private Sub cbo2_GotFocus(sender As Object, e As EventArgs) Handles cbo2.GotFocus
    '    frmMain.bbFields.Caption = "DB Field: " & sDataTable & ".areaid"
    'End Sub

    'Private Sub txtCode_GotFocus(sender As Object, e As EventArgs) Handles txtCode.GotFocus
    '    frmMain.bbFields.Caption = "DB Field: " & sDataTable & ".code"
    'End Sub

    'Private Sub txtName_GotFocus(sender As Object, e As EventArgs) Handles txtName.GotFocus
    '    frmMain.bbFields.Caption = "DB Field: " & sDataTable & ".name"
    'End Sub
End Class