Imports System.Data.SqlClient
Imports DevExpress.Utils
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraVerticalGrid.Events

Public Class frmOfferDet
    Private sID As String
    Private Ctrl As DevExpress.XtraGrid.Views.Grid.GridView
    Private Frm As DevExpress.XtraEditors.XtraForm
    Public Mode As Byte
    Private Log As New Transactions
    Private LoadForms As New FormLoader
    Private Cls As New ClearControls
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

    Sub New()

        InitializeComponent()
        'SqlDataSource1.Fill()
    End Sub

    Private Sub frmOfferDet_Load(sender As Object, e As EventArgs) Handles Me.Load
        'TODO: This line of code loads data into the 'DreamyKitchenDataSet1.vw_BENCH' table. You can move, or remove it, as needed.
        Me.Vw_BENCHTableAdapter.Fill(Me.DreamyKitchenDataSet1.vw_BENCH)
        'TODO: This line of code loads data into the 'DreamyKitchenDataSet.vw_COLORSBACK' table. You can move, or remove it, as needed.
        Me.Vw_COLORSBACKTableAdapter.Fill(Me.DreamyKitchenDataSet.vw_COLORSBACK)
        'TODO: This line of code loads data into the 'DreamyKitchenDataSet.vw_COLORSBAZA' table. You can move, or remove it, as needed.
        Me.Vw_COLORSBAZATableAdapter.Fill(Me.DreamyKitchenDataSet.vw_COLORSBAZA)
        'TODO: This line of code loads data into the 'DreamyKitchenDataSet.vw_COLORSPVC' table. You can move, or remove it, as needed.
        Me.Vw_COLORSPVCTableAdapter.Fill(Me.DreamyKitchenDataSet.vw_COLORSPVC)
        'TODO: This line of code loads data into the 'DreamyKitchenDataSet.vw_COLORSBOX' table. You can move, or remove it, as needed.
        Me.Vw_COLORSBOXTableAdapter.Fill(Me.DreamyKitchenDataSet.vw_COLORSBOX)
        'TODO: This line of code loads data into the 'DreamyKitchenDataSet.vw_COLORSBOX' table. You can move, or remove it, as needed.
        Dim sSQL As String
        sSQL = "select ID, code, offID,  doorVaseos,doorKremasta,doorYpsila,doorThickness,backThickness, backColorID,bench,table_back,
                bazaColorID, legsV,legsY, 
                boxVColorID, boxKColorID, boxYColorID, pvcVColorID, pvcKColorID, pvcYColorID,finalHeightKitchen,
    	        rafia, pomola,  doorVaseosH,doorKremastaH, doorYpsilaH,
		        benchID,extraBench, gola,  
		        sink, sink_P, battery, battery_P, absorber, absorber_P, dishwasher, dishwasher_P, oven, oven_P, furnace, furnace_P, 
                fridge, fridge_P, Dispenser, Dispenser_P,
		        modifiedBy, modifiedOn, createdOn, createdBy, RealName  
                from vw_OFF_DET where offID = " & toSQLValueS(sID)
        Dim HasRows As Boolean
        LoadForms.LoadDataToVGrid(VGridControl1, sSQL, HasRows)
        'Εαν δεν υπάρχουν στοιχεία προσφοράς καταχωρώ την γραμμή ώστε μετα να γίνεται update στο data entry
        If HasRows = False Then
            sSQL = "INSERT INTO OFF_DET (offID, createdBy ,createdOn,gola) SELECT " & toSQLValueS(sID) & "," & toSQLValueS(UserProps.ID.ToString) & ",GETDATE(),0"
            Using oCmd As New SqlCommand(sSQL, CNDB)
                oCmd.ExecuteNonQuery()
            End Using
        End If
        Console.WriteLine(VGridControl1.RecordCount)
        'backColorID.View.PopulateColumns(backColorID.DataSource)
        'backColorID.View.Columns("ID").Visible = False
        'If My.Computer.FileSystem.FileExists(Application.StartupPath & "\DSGNS\DEF\OFFDET.xml") Then VGridControl1.RestoreLayoutFromXml(Application.StartupPath & "\DSGNS\DEF\OFFDET.xml", OptionsLayoutBase.FullLayout)
        'VGridControl1.SaveLayoutToXml(Application.StartupPath & "\DSGNS\DEF\OFFDET.xml", OptionsLayoutBase.FullLayout)

        'GridView3.Columns("SubOFFName").OptionsColumn.ReadOnly = True
        'GridView3.Columns("SubOFFName").OptionsColumn.AllowEdit = False
        'GridView3.Columns("NewPrice").OptionsColumn.ReadOnly = False
        'GridView3.Columns("NewPrice").OptionsColumn.AllowEdit = True
        'GridView3.Columns("Price").OptionsColumn.AllowEdit = False
        'GridView3.Columns("name").OptionsColumn.AllowEdit = False
        'GridView3.OptionsBehavior.Editable = True

    End Sub

    Private Sub VGridControl1_CellValueChanged(sender As Object, e As CellValueChangedEventArgs) Handles VGridControl1.CellValueChanged
        Try
            Dim sSQL As String
            sSQL = "UPDATE [OFF_DET] SET " & e.Row.Name & "= " & toSQLValueS(e.Value.ToString) & " WHERE offID = " & toSQLValueS(sID)
            Using oCmd As New SqlCommand(sSQL, CNDB)
                oCmd.ExecuteNonQuery()
            End Using

        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), "Dreamy Kitchen CRM", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub CheckEdit_Click(sender As Object, e As EventArgs) Handles CheckEdit.Click

    End Sub

    Private Sub backColorID_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles backColorID.ButtonClick
        'Select Case e.Button.Index
        '    'Case 1 : ManageBACKColors()
        '    Case 2 : backColorID.Tag = "d"
        'End Select
    End Sub
    'Private Sub ManageBACKColors()
    '    Dim frmColors As frmColors = New frmColors
    '    frmColors.CallerForm = "frmOffer"
    '    frmColors.CallerControl = cboBOXColors
    '    frmColors.CalledFromControl = True
    '    If cboBOXColors.EditValue <> Nothing Then frmColors.ID = cboBOXColors.EditValue.ToString
    '    frmColors.MdiParent = frmMain
    '    If cboBOXColors.EditValue <> Nothing Then frmColors.Mode = FormMode.EditRecord Else frmColors.Mode = FormMode.NewRecord
    '    frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(frmColors), New Point(CInt(frmColors.Parent.ClientRectangle.Width / 2 - frmColors.Width / 2), CInt(frmColors.Parent.ClientRectangle.Height / 2 - frmColors.Height / 2)))
    '    frmColors.Show()
    'End Sub
    'Private Sub ManageBOXColors()
    '    Dim frmColors As frmColors = New frmColors
    '    frmColors.CallerForm = "frmOffer"
    '    frmColors.CallerControl = cboBOXColors
    '    frmColors.CalledFromControl = True
    '    If cboBOXColors.EditValue <> Nothing Then frmColors.ID = cboBOXColors.EditValue.ToString
    '    frmColors.MdiParent = frmMain
    '    If cboBOXColors.EditValue <> Nothing Then frmColors.Mode = FormMode.EditRecord Else frmColors.Mode = FormMode.NewRecord
    '    frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(frmColors), New Point(CInt(frmColors.Parent.ClientRectangle.Width / 2 - frmColors.Width / 2), CInt(frmColors.Parent.ClientRectangle.Height / 2 - frmColors.Height / 2)))
    '    frmColors.Show()
    'End Sub

    Private Sub bazaColorID_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles bazaColorID.ButtonClick
        
        Select Case e.Button.Index
            'Case 1 : ManageBazaColors()
            'Case 2 : cboBazaColors.EditValue = Nothing
        End Select
    End Sub

    Private Sub cmdExit_Click(sender As Object, e As EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub
    'Private Sub ManageBazaColors()
    '    Dim frmColors As frmColors = New frmColors
    '    frmColors.CallerForm = "frmOffer"
    '    frmColors.CallerControl = cboBazaColors
    '    frmColors.CalledFromControl = True
    '    If cboBazaColors.EditValue <> Nothing Then frmColors.ID = cboBazaColors.EditValue.ToString
    '    frmColors.MdiParent = frmMain
    '    If cboBazaColors.EditValue <> Nothing Then frmColors.Mode = FormMode.EditRecord Else frmColors.Mode = FormMode.NewRecord
    '    frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(frmColors), New Point(CInt(frmColors.Parent.ClientRectangle.Width / 2 - frmColors.Width / 2), CInt(frmColors.Parent.ClientRectangle.Height / 2 - frmColors.Height / 2)))
    '    frmColors.Show()
    'End Sub

    'Private Sub boxColorID_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles boxColorID.ButtonClick
    '    Select Case e.Button.Index
    '        Case 1 : ManageBazaColors()
    '        Case 2 : cboBazaColors.EditValue = Nothing
    '    End Select
    'End Sub

    'Private Sub pvcColorID_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles pvcColorID.ButtonClick
    '    Select Case e.Button.Index
    '        Case 1 : ManageBazaColors()
    '        Case 2 : cboBazaColors.EditValue = Nothing
    '    End Select
    'End Sub
    'Private Sub ManagePVCColors()
    '    Dim frmColors As frmColors = New frmColors
    '    frmColors.CallerForm = "frmOffer"
    '    frmColors.CallerControl = cboPVCColors
    '    frmColors.CalledFromControl = True
    '    If cboPVCColors.EditValue <> Nothing Then frmColors.ID = cboPVCColors.EditValue.ToString
    '    frmColors.MdiParent = frmMain
    '    If cboPVCColors.EditValue <> Nothing Then frmColors.Mode = FormMode.EditRecord Else frmColors.Mode = FormMode.NewRecord
    '    frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(frmColors), New Point(CInt(frmColors.Parent.ClientRectangle.Width / 2 - frmColors.Width / 2), CInt(frmColors.Parent.ClientRectangle.Height / 2 - frmColors.Height / 2)))
    '    frmColors.Show()
    'End Sub
End Class