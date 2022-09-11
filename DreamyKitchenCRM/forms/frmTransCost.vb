Imports System.Data.SqlClient
Imports DevExpress.Utils
Imports DevExpress.XtraBars.Navigation
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGrid.Views.Grid

Public Class frmTransCost
    Private FillCbo As New FillCombos
    Private Valid As New ValidateControls
    Private LoadForms As New FormLoader
    Private DBQ As New DBQueries
    Private Ctrl As DevExpress.XtraGrid.Views.Grid.GridView
    Private Cls As New ClearControls
    Private Frm As DevExpress.XtraEditors.XtraForm
    Private CtrlCombo As DevExpress.XtraEditors.LookUpEdit
    Private CalledFromCtrl As Boolean
    Private FScrollerExist As Boolean = False
    Private sID As String
    Public Mode As Byte
    Private Structure Cost_Prices
        '****ΠΟΣΟΣΤΟ ΠΩΛΗΤΗ******
        Dim profitPercK As Integer
        Dim profitPercC As Integer
        Dim profitPercD As Integer
        Dim profitPercSC As Integer
        '****ΠΟΣΟΣΤΟ ΕΠΙΧΕΙΡΗΣΗΣ******
        Dim profitPercCompK As Integer
        Dim profitPercCompC As Integer
        Dim profitPercCompD As Integer
        Dim profitPercCompSC As Integer
        '****ΚΕΡΔΟΣ ΠΩΛΗΤΗ******
        Dim SprofitK As Integer
        Dim SprofitC As Integer
        Dim SprofitD As Integer
        Dim SprofitSC As Integer
        '****ΚΕΡΔΟΣ ΕΠΙΧΕΙΡΗΣΗΣ******
        Dim CprofitK As Integer
        Dim CprofitC As Integer
        Dim CprofitD As Integer
        Dim CprofitSC As Integer

        '****ΕΡΜΑΡΙΑ*******
        'ΕΡΜΑΡΙΑ ΒΑΣΕΩΣ
        Dim VDoorPrice1 As Double
        Dim VDoorPrice2 As Double
        Dim Vtrm1 As Double
        Dim Vtrm2 As Double
        Dim VFinalPrice1 As Double
        Dim VFinalPrice2 As Double
        Dim VTotal As Double
        Dim VDoorType1 As Guid
        Dim VDoorType2 As Guid
        'ΕΡΜΑΡΙΑ ΚΡΕΜΑΣΤΑ
        Dim KDoorPrice1 As Double
        Dim KDoorPrice2 As Double
        Dim Ktrm1 As Double
        Dim Ktrm2 As Double
        Dim KFinalPrice1 As Double
        Dim KFinalPrice2 As Double
        Dim KTotal As Double
        Dim KDoorType1 As Guid
        Dim KDoorType2 As Guid
        'ΕΡΜΑΡΙΑ ΥΨΗΛΑ
        Dim YDoorPrice1 As Double
        Dim YDoorPrice2 As Double
        Dim Ytrm1 As Double
        Dim Ytrm2 As Double
        Dim YFinalPrice1 As Double
        Dim YFinalPrice2 As Double
        Dim YTotal As Double
        Dim YDoorType1 As Guid
        Dim YDoorType2 As Guid
        '****ΕΠΕΝΔΥΣΕΙΣ-ΡΑΦΙΕΡΕΣ*******
        'ΕΠΕΝΔΥΣΕΙΣ ΒΑΣΕΩΣ - ΡΑΦΙΕΡΑ
        Dim VependisisPrice As Double
        Dim NependisisPrice As Double
        Dim VRafieraPrice As Double
        Dim VEpendTrm As Double
        Dim NEpendTrm As Double
        Dim VRafTem As Double
        Dim VependisisFinalPrice As Double
        Dim NependisisFinalPrice As Double
        Dim VRafieraFinalPrice As Double
        Dim VEpendisisTotal As Double
        Dim VependisisDoorTypeID As Guid
        Dim NependisisDoorTypeID As Guid
        Dim VRafieraDoorTypeID As Guid
        'ΕΠΕΝΔΥΣΕΙΣ ΚΡΕΜΑΣΤΩΝ - ΡΑΦΙΕΡΑ
        Dim KependisisPrice As Double
        Dim SependisisPrice As Double
        Dim KRafieraPrice As Double
        Dim WRafieraPrice As Double
        Dim KEpendTrm As Double
        Dim SEpendTrm As Double
        Dim KRafTem As Double
        Dim WRafTem As Double
        Dim KependisisFinalPrice As Double
        Dim SependisisFinalPrice As Double
        Dim KRafieraFinalPrice As Double
        Dim WRafieraFinalPrice As Double
        Dim KEpendisisTotal As Double
        Dim KependisisDoorTypeID As Guid
        Dim SependisisDoorTypeID As Guid
        Dim KRafieraDoorTypeID As Guid
        Dim KWallRafiaDoorTypeID As Guid
        'ΕΠΕΝΔΥΣΕΙΣ ΥΨΗΛΩΝ - ΡΑΦΙΕΡΑ
        Dim YependisisPrice As Double
        Dim YRafieraPrice As Double
        Dim YEpendTrm As Double
        Dim YRafTem As Double
        Dim YependisisFinalPrice As Double
        Dim YRafieraFinalPrice As Double
        Dim YEpendisisTotal As Double
        Dim YependisisDoorTypeID As Guid
        Dim YRafieraDoorTypeID As Guid
        '****ΠΑΓΚΟΙ*******
        Dim BenchPrice1 As Double
        Dim BenchPrice2 As Double
        Dim BackPrice As Double
        Dim BenchFinalPrice1 As Double
        Dim BenchFinalPrice2 As Double
        Dim BackFinalPrice As Double
        Dim BenchTem1 As Double
        Dim BenchTem2 As Double
        Dim BackTem As Double
        Dim BenchBackTotal As Double
        Dim BenchID As Guid
        Dim BenchID2 As Guid
        Dim BackID As Guid
        'ΜΗΧΑΝΙΣΜΟΊ - ΚΟΥΖΙΝΑΣ
        Dim TotKEquipment As Double
        '****ΝΤΟΥΛΑΠΕΣ*******
        Dim BoxColorID As Guid
        Dim BoxColorID2 As Guid
        Dim BoxColorID3 As Guid
        Dim BoxColorID4 As Guid
        Dim BoxColorID5 As Guid
        Dim BoxColorID6 As Guid
        Dim DoorTypeID As Guid
        Dim DoorTypeID2 As Guid
        Dim DoorTypeID3 As Guid
        Dim DoorTypeID4 As Guid
        Dim DoorTypeID5 As Guid
        Dim DoorTypeID6 As Guid
        Dim DoorTypeID7 As Guid
        Dim DoorTypeID8 As Guid
        Dim DoorTypeID9 As Guid
        Dim DoorTypeID10 As Guid
        Dim DoorTypeID11 As Guid
        Dim DoorTypeID12 As Guid
        Dim SidesID1 As Guid
        Dim SidesID2 As Guid
        Dim SidesID3 As Guid
        Dim SidesID4 As Guid
        Dim SidesID5 As Guid
        Dim SidesID6 As Guid
        Dim Model1 As String
        Dim Model2 As String
        Dim Model3 As String
        Dim Model4 As String
        Dim Model5 As String
        Dim Model6 As String
        Dim CTm1 As Double
        Dim CTm2 As Double
        Dim CTm3 As Double
        Dim CTm4 As Double
        Dim CTm5 As Double
        Dim CTm6 As Double
        Dim CTm7 As Double
        Dim CTm8 As Double
        Dim CTm9 As Double
        Dim CTm10 As Double
        Dim CTm11 As Double
        Dim CTm12 As Double
        Dim ModelPrice1 As Double
        Dim ModelPrice2 As Double
        Dim ModelPrice3 As Double
        Dim ModelPrice4 As Double
        Dim ModelPrice5 As Double
        Dim ModelPrice6 As Double
        Dim ModelPrice7 As Double
        Dim ModelPrice8 As Double
        Dim ModelPrice9 As Double
        Dim ModelPrice10 As Double
        Dim ModelPrice11 As Double
        Dim ModelPrice12 As Double
        Dim ModelFinalPrice1 As Double
        Dim ModelFinalPrice2 As Double
        Dim ModelFinalPrice3 As Double
        Dim ModelFinalPrice4 As Double
        Dim ModelFinalPrice5 As Double
        Dim ModelFinalPrice6 As Double
        Dim ModelFinalPrice7 As Double
        Dim ModelFinalPrice8 As Double
        Dim ModelFinalPrice9 As Double
        Dim ModelFinalPrice10 As Double
        Dim ModelFinalPrice11 As Double
        Dim ModelFinalPrice12 As Double
        Dim PTem1 As Double
        Dim PTem2 As Double
        Dim PTem3 As Double
        Dim PTem4 As Double
        Dim PTem5 As Double
        Dim PTem6 As Double
        Dim PlainaPrice1 As Double
        Dim PlainaPrice2 As Double
        Dim PlainaPrice3 As Double
        Dim PlainaPrice4 As Double
        Dim PlainaPrice5 As Double
        Dim PlainaPrice6 As Double
        Dim PlainaFinalPrice1 As Double
        Dim PlainaFinalPrice2 As Double
        Dim PlainaFinalPrice3 As Double
        Dim PlainaFinalPrice4 As Double
        Dim PlainaFinalPrice5 As Double
        Dim PlainaFinalPrice6 As Double
        Dim CErmariaTotal As Double
        'ΜΗΧΑΝΙΣΜΟΊ - ΝΤΟΥΛΑΠΑΣ
        Dim TotCEquipment As Double
        '****ΠΟΡΤΕΣ*******
        Dim DDoorTypeID1 As Guid
        Dim DDoorTypeID2 As Guid
        Dim DDoorTypeID3 As Guid
        Dim DDoorTypeID4 As Guid
        Dim DDoorTypeID5 As Guid
        Dim DDoorTypeID6 As Guid
        Dim DDoorPrice1 As Double
        Dim DDoorPrice2 As Double
        Dim DDoorPrice3 As Double
        Dim DDoorPrice4 As Double
        Dim DDoorPrice5 As Double
        Dim DDoorPrice6 As Double
        Dim DDoorFinalPrice1 As Double
        Dim DDoorFinalPrice2 As Double
        Dim DDoorFinalPrice3 As Double
        Dim DDoorFinalPrice4 As Double
        Dim DDoorFinalPrice5 As Double
        Dim DDoorFinalPrice6 As Double
        Dim DTem1 As Double
        Dim DTem2 As Double
        Dim DTem3 As Double
        Dim DTem4 As Double
        Dim DTem5 As Double
        Dim DTem6 As Double
        Dim DoorType1 As String
        Dim DoorType2 As String
        Dim DoorType3 As String
        Dim DoorType4 As String
        Dim DoorType5 As String
        Dim DoorType6 As String
        Dim Kasa1 As String
        Dim Kasa2 As String
        Dim Kasa3 As String
        Dim Kasa4 As String
        Dim Kasa5 As String
        Dim Kasa6 As String
        Dim DTotal As Double
        '****ΕΙΔΙΚΗ ΚΑΤΑΣΚΕΥΗ*******
        Dim ScpecialConstr1 As Guid
        Dim ScpecialConstr2 As Guid
        Dim ScpecialConstr3 As Guid
        Dim ScpecialConstr4 As Guid
        Dim SCDoorTypeID1 As Guid
        Dim SCDoorTypeID2 As Guid
        Dim SCDoorTypeID3 As Guid
        Dim SCDoorTypeID4 As Guid
        Dim SCDoorFinalPrice1 As Double
        Dim SCDoorFinalPrice2 As Double
        Dim SCDoorFinalPrice3 As Double
        Dim SCDoorFinalPrice4 As Double
        Dim SCTotal As Double
        'STANDAR ΕΞΟΔΑ ΚΟΥΖΙΝΑΣ
        Dim KMeasurement As Double
        Dim KTransp As Double
        Dim KRemove As Double
        Dim KPartofVat As Double
        Dim KStandarTotal As Double
        'STANDAR ΕΞΟΔΑ ΝΤΟΥΛΑΠΑΣ
        Dim CMeasurement As Double
        Dim CTransp As Double
        Dim CRemove As Double
        Dim CPartofVat As Double
        Dim CStandarTotal As Double
        'STANDAR ΕΞΟΔΑ ΠΟΡΤΑΣ
        Dim DMeasurement As Double
        Dim DTransp As Double
        Dim DRemove As Double
        Dim DPartofVat As Double
        Dim DDesign As Double
        Dim DStandarTotal As Double
        'STANDAR ΕΙΔΙΚΩΝ ΚΑΤΑΣΚΕΥΩΝ
        Dim SCMeasurement As Double
        Dim SCTransp As Double
        Dim SCRemove As Double
        Dim SCPartofVat As Double
        Dim SCDesign As Double
        Dim SCStandarTotal As Double
        '*****Γενικά Σύνολα******
        'Γενικα σύνολο έργου
        Dim GenTot As Double
        'Γενικα σύνολο έργου χωρίς κέρδος
        Dim GenTotWithoutProfit As Double
        'Γενικα σύνολο κουζίνας
        Dim GenTotK As Double
        'Γενικα σύνολο ντουλάπας
        Dim GenTotC As Double
        'Γενικα σύνολο πόρτας
        Dim GenTotD As Double
        'Γενικα σύνολο ειδικής κατασκευής
        Dim GenTotSC As Double
        ' ΤΟ ΕΡΓΟ ΑΦΟΡΑ
        Dim AgreementID As Guid
        Dim Kitchen As Boolean
        Dim Closet As Boolean
        Dim Doors As Boolean
        Dim SC As Boolean
    End Structure
    Private CostPrices As New Cost_Prices
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

    Private Sub frmTransCost_Load(sender As Object, e As EventArgs) Handles Me.Load
        'TODO: This line of code loads data into the 'DMDataSet.vw_DOOR_TYPERafiaWall' table. You can move, or remove it, as needed.
        Me.Vw_DOOR_TYPERafiaWallTableAdapter.FillByRafiaWall(Me.DMDataSet.vw_DOOR_TYPERafiaWall)
        'TODO: This line of code loads data into the 'DMDataSet.vw_DOOR_TYPESpecialConstr' table. You can move, or remove it, as needed.
        Me.Vw_DOOR_TYPESpecialConstrTableAdapter.Fill(Me.DMDataSet.vw_DOOR_TYPESpecialConstr)
        'TODO: This line of code loads data into the 'DMDataSet.vw_CONSTR_TYPE' table. You can move, or remove it, as needed.
        Me.Vw_CONSTR_TYPETableAdapter.Fill(Me.DMDataSet.vw_CONSTR_TYPE)
        'TODO: This line of code loads data into the 'DMDataSet.vw_DOOR_TYPEEpendisisCloset' table. You can move, or remove it, as needed.
        Me.Vw_DOOR_TYPEEpendisisClosetTableAdapter.FillBYEpendisisCloset(Me.DMDataSet.vw_DOOR_TYPEEpendisisCloset)
        'TODO: This line of code loads data into the 'DreamyKitchenDataSet.vw_BENCH' table. You can move, or remove it, as needed.
        Me.Vw_BENCHTableAdapter.Fill(Me.DreamyKitchenDataSet.vw_BENCH)
        'TODO: This line of code loads data into the 'DMDataSet.vw_DOOR_TYPERafieresY' table. You can move, or remove it, as needed.
        Me.Vw_DOOR_TYPERafieresYTableAdapter.FillByRafieresY(Me.DMDataSet.vw_DOOR_TYPERafieresY)
        'TODO: This line of code loads data into the 'DMDataSet.vw_DOOR_TYPEPlainaYpsila' table. You can move, or remove it, as needed.
        Me.Vw_DOOR_TYPEPlainaYpsilaTableAdapter.FillBYPlainaYpsila(Me.DMDataSet.vw_DOOR_TYPEPlainaYpsila)
        'TODO: This line of code loads data into the 'DMDataSet.vw_DOOR_TYPERafieresK' table. You can move, or remove it, as needed.
        Me.Vw_DOOR_TYPERafieresKTableAdapter.FillByRafieresK(Me.DMDataSet.vw_DOOR_TYPERafieresK)
        'TODO: This line of code loads data into the 'DMDataSet.vw_DOOR_TYPEPlainaKremasta' table. You can move, or remove it, as needed.
        Me.Vw_DOOR_TYPEPlainaKremastaTableAdapter.FillByPlainaKremasta(Me.DMDataSet.vw_DOOR_TYPEPlainaKremasta)
        'TODO: This line of code loads data into the 'DMDataSet.vw_DOOR_TYPERafieresV' table. You can move, or remove it, as needed.
        Me.Vw_DOOR_TYPERafieresVTableAdapter.FillByRafieresV(Me.DMDataSet.vw_DOOR_TYPERafieresV)
        'TODO: This line of code loads data into the 'DMDataSet.vw_DOOR_TYPE' table. You can move, or remove it, as needed.
        Me.Vw_DOOR_TYPETableAdapter.FillBYNisida(Me.DMDataSet.vw_DOOR_TYPE)
        'TODO: This line of code loads data into the 'DMDataSet.DOOR_TYPE' table. You can move, or remove it, as needed.
        Me.DOOR_TYPETableAdapter.FillBYPlainaVaseos(Me.DMDataSet.DOOR_TYPE)
        'TODO: This line of code loads data into the 'DMDataSet.vw_DOOR_TYPE1' table. You can move, or remove it, as needed.
        Me.Vw_DOOR_TYPE1TableAdapter.FillBYErmaria(Me.DMDataSet.vw_DOOR_TYPE1)
        'TODO: This line of code loads data into the 'DreamyKitchenDataSet.vw_COLORSBOX' table. You can move, or remove it, as needed.
        Me.Vw_COLORSBOXTableAdapter.Fill(Me.DreamyKitchenDataSet.vw_COLORSBOX)
        'TODO: This line of code loads data into the 'DreamyKitchenDataSet.vw_CCT' table. You can move, or remove it, as needed.
        Me.Vw_CCTTableAdapter.Fill(Me.DreamyKitchenDataSet.vw_CCT)
        'TODO: This line of code loads data into the 'DreamyKitchenDataSet.vw_SALERS' table. You can move, or remove it, as needed.
        Me.Vw_SALERSTableAdapter.Fill(Me.DreamyKitchenDataSet.vw_SALERS)
        Dim Prog_Prop As New ProgProp
        Prog_Prop.GetProgPROSF()

        FillCbo.CUS(cboCUS)

        XtraTabPage1.Visible = False

        Select Case Mode
            Case FormMode.NewRecord
                txtCode.Text = DBQ.GetNextId("TRANSCOST")
                cboEMP.EditValue = System.Guid.Parse(UserProps.ID.ToString.ToUpper)
                TileNavPane1.Enabled = False
            Case FormMode.EditRecord
                'Γενικά Στοιχεία Κοστολόγησης
                LoadForms.LoadFormGRP(LayoutControlGroup1, "Select [ID],[code],[empID],[cusID],[transhID] ,[cctOrderKitchenID],[cmt] from TRANSCOST where id = " & toSQLValueS(sID), False)
                TileNavPane1.Enabled = True
                'Γενικά Στοιχεία Ντουλάπας
                LoadForms.LoadFormGRP(LayoutControlGroup30, "Select * from TRANSCOST where id = " & toSQLValueS(sID), False)
                'Γενικά Στοιχεία Κουζίνας
                LoadForms.LoadFormGRP(LayoutControlGroup28, "Select * from TRANSCOST where id = " & toSQLValueS(sID), False)
                'Ανάλυση Ειδ. Κατασκευής
                LoadForms.LoadFormGRP(LayoutControlGroup27, "Select * from TRANSCOST where id = " & toSQLValueS(sID), False)
                'Γενικά Στοιχεία Ειδ. Κατασκευής
                LoadForms.LoadFormGRP(LayoutControlGroup26, "Select * from TRANSCOST where id = " & toSQLValueS(sID), False)
                'Γενικά Στοιχεία Πόρτας
                LoadForms.LoadFormGRP(LayoutControlGroup18, "Select * from TRANSCOST where id = " & toSQLValueS(sID), False)
                'Ανάλυση Πορτών
                LoadForms.LoadFormGRP(LayoutControlGroup19, "Select * from TRANSCOST where id = " & toSQLValueS(sID), False)
                'Ερμάρια Βάσεως
                LoadForms.LoadFormGRP(LayoutControlGroup5, "Select * from TRANSCOST where id = " & toSQLValueS(sID), False)
                'Ερμάρια Κρεμαστά
                LoadForms.LoadFormGRP(LayoutControlGroup3, "Select * from TRANSCOST where id = " & toSQLValueS(sID), False)
                'Ερμάρια Υψηλά
                LoadForms.LoadFormGRP(LayoutControlGroup6, "Select * from TRANSCOST where id = " & toSQLValueS(sID), False)
                'Επενδύσεις-Ραφιέρες-Ράφια Βάσεως
                LoadForms.LoadFormGRP(LayoutControlGroup8, "Select * from TRANSCOST where id = " & toSQLValueS(sID), False)
                'Επενδύσεις-Ραφιέρες-Ράφια Κρεμαστά
                LoadForms.LoadFormGRP(LayoutControlGroup10, "Select * from TRANSCOST where id = " & toSQLValueS(sID), False)
                'Επενδύσεις-Ραφιέρες-Ράφια Υψηλά
                LoadForms.LoadFormGRP(LayoutControlGroup11, "Select * from TRANSCOST where id = " & toSQLValueS(sID), False)
                'Πάγκοι-Πλάτες
                LoadForms.LoadFormGRP(LayoutControlGroup29, "Select * from TRANSCOST where id = " & toSQLValueS(sID), False)
                'Ανάλυση Ντουλαπών
                LoadForms.LoadFormGRP(LayoutControlGroup20, "Select * from TRANSCOST where id = " & toSQLValueS(sID), False)
                LoadForms.LoadFormGRP(LayoutControlGroup21, "Select * from TRANSCOST where id = " & toSQLValueS(sID), False)
                LoadForms.LoadFormGRP(LayoutControlGroup22, "Select * from TRANSCOST where id = " & toSQLValueS(sID), False)
                LoadForms.LoadFormGRP(LayoutControlGroup23, "Select * from TRANSCOST where id = " & toSQLValueS(sID), False)
                LoadForms.LoadFormGRP(LayoutControlGroup24, "Select * from TRANSCOST where id = " & toSQLValueS(sID), False)
                LoadForms.LoadFormGRP(LayoutControlGroup25, "Select * from TRANSCOST where id = " & toSQLValueS(sID), False)

                Dim sSQL As String = "Select Totamt, TotKErm, TotKEpendRaf, TotBackBench, TotK, TotC, TotD, TotSC, TotDErm,TotalSalerProfit,TotalCompanyProfit,TotamtWithoutProfit from TRANSCOST where id = " & toSQLValueS(sID)
                Dim cmd As SqlCommand
                Dim sdr As SqlDataReader
                cmd = New SqlCommand(sSQL.ToString, CNDB)
                sdr = cmd.ExecuteReader()
                If (sdr.Read() = True) Then
                    txtGenTot.EditValue = sdr.GetDecimal(sdr.GetOrdinal("TotAmt"))
                    txtGenTotWithoutProfit.EditValue = sdr.GetDecimal(sdr.GetOrdinal("TotamtWithoutProfit"))
                    txtErmTotal.EditValue = sdr.GetDecimal(sdr.GetOrdinal("TotKErm"))
                    txtEpendTotal.EditValue = sdr.GetDecimal(sdr.GetOrdinal("TotKEpendRaf"))
                    txtBenchTotal.EditValue = sdr.GetDecimal(sdr.GetOrdinal("TotBackBench"))
                    txtKTotalStandar.EditValue = sdr.GetDecimal(sdr.GetOrdinal("TotK"))
                    txtCTotalStandar.EditValue = sdr.GetDecimal(sdr.GetOrdinal("TotC"))
                    txtDTotal.EditValue = sdr.GetDecimal(sdr.GetOrdinal("TotD"))
                    txtSCTotal.EditValue = sdr.GetDecimal(sdr.GetOrdinal("TotSC"))
                    txtCErmTotal.EditValue = sdr.GetDecimal(sdr.GetOrdinal("TotDErm"))
                    txtTotalSalerProfit.EditValue = sdr.GetDecimal(sdr.GetOrdinal("TotalSalerProfit"))
                    txtTotalCompanyProfit.EditValue = sdr.GetDecimal(sdr.GetOrdinal("TotalCompanyProfit"))
                End If
                sdr.Close()
                FillDataGridM()
                FillDataGridC()
                FillCostFromDB()
        End Select
        Me.CenterToScreen()
        cmdSave.Enabled = IIf(Mode = FormMode.NewRecord, UserProps.AllowInsert, UserProps.AllowEdit)
    End Sub
    ' Κ Ο Υ Ζ Ι Ν Α
    Private Sub TErmaria_ElementClick(sender As Object, e As NavElementEventArgs) Handles TErmaria.ElementClick
        XtraTabPage1.Visible = True
        Maintab.SelectedTabPage = XtraTabPage1
        'If Mode = FormMode.EditRecord Then Exit Sub
        'FillCost(0)
    End Sub

    Private Sub TEpendisis_ElementClick(sender As Object, e As NavElementEventArgs) Handles TEpendisis.ElementClick
        XtraTabPage2.Visible = True
        Maintab.SelectedTabPage = XtraTabPage2
        'FillCost(0)
    End Sub
    Private Sub TBech_ElementClick(sender As Object, e As NavElementEventArgs) Handles TBech.ElementClick
        Maintab.SelectedTabPage = XtraTabPage3
        XtraTabPage3.Visible = True
        'FillCost(0)
    End Sub
    Private Sub TKitchen_ElementClick(sender As Object, e As NavElementEventArgs) Handles TKitchen.ElementClick
        Maintab.SelectedTabPage = XtraTabPage7
        'If Mode = FormMode.EditRecord Then Exit Sub
        'FillCost(4)
    End Sub

    ' Ν Τ Ο Υ Λ Α Π Α
    Private Sub TCloset_ElementClick(sender As Object, e As NavElementEventArgs) Handles TCloset.ElementClick
        Maintab.SelectedTabPage = XtraTabPage8
        XtraTabPage8.Visible = True
        'If Mode = FormMode.EditRecord Then Exit Sub
        'FillCost(5)
    End Sub

    Private Sub TCErmaria_ElementClick(sender As Object, e As NavElementEventArgs) Handles TCErmaria.ElementClick
        Maintab.SelectedTabPage = XtraTabPage5
        XtraTabPage5.Visible = True
        'If Mode = FormMode.EditRecord Then Exit Sub
        'FillCost(1)

    End Sub

    Private Sub TDoor_ElementClick(sender As Object, e As NavElementEventArgs) Handles TDoor.ElementClick
        Maintab.SelectedTabPage = XtraTabPage9
        XtraTabPage9.Visible = True
        'If Mode = FormMode.EditRecord Then Exit Sub
        'FillCost(2)
    End Sub
    Private Sub TMech_ElementClick(sender As Object, e As NavElementEventArgs) Handles TMech.ElementClick
        Maintab.SelectedTabPage = XtraTabPage4
        XtraTabPage4.Visible = True
        'FillDataGridM()
    End Sub
    Private Sub FillDataGridM()
        LoadForms.LoadDataToGrid(grdEquipment, GridView2,
                    "select EQ.ID,EQ.code,E.name, EQ.price,EQ.qty,(EQ.price * EQ.qty ) AS Total
					from CCT_ORDERS_KITCHEN_EQUIPMENT EQ
					INNER JOIN EQUIPMENT E ON E.ID = EQ.equipmentID 
					INNER JOIN CCT_ORDERS_KITCHEN COK ON EQ.cctOrdersKitchenID =  COK.ID 
					INNER JOIN TRANSH ON TRANSH.ID =  COK.transhID 
					where TRANSH.ID = " & toSQLValueS(cboTRANSH.EditValue.ToString))
        If System.IO.File.Exists(Application.StartupPath & "\DSGNS\DEF\CCT_ORDERS_KITCHEN_EQUIPMENT_COST_def.xml") = True Then
            GridView2.RestoreLayoutFromXml(Application.StartupPath & "\DSGNS\DEF\CCT_ORDERS_KITCHEN_EQUIPMENT_COST_def.xml", OptionsLayoutBase.FullLayout)
        End If
        GridView2.Columns.Item("name").OptionsColumn.AllowEdit = False : GridView2.Columns.Item("code").OptionsColumn.AllowEdit = False
        GridView2.Columns.Item("qty").OptionsColumn.AllowEdit = False : GridView2.Columns.Item("qty").OptionsColumn.AllowEdit = False
        GridView2.Columns.Item("price").OptionsColumn.AllowEdit = False : GridView2.Columns.Item("price").OptionsColumn.AllowEdit = False
        GridView2.Columns.Item("Total").OptionsColumn.AllowEdit = False : GridView2.Columns.Item("Total").OptionsColumn.AllowEdit = False
        CostPrices.TotKEquipment = GridView2.Columns("Total").SummaryItem.SummaryValue
    End Sub
    Private Sub TVaseos_ElementClick(sender As Object, e As NavElementEventArgs)
        Maintab.SelectedTabPage = XtraTabPage1
        XtraTabPage1.Visible = True
    End Sub
    Private Sub TSC_ElementClick(sender As Object, e As NavElementEventArgs) Handles TSC.ElementClick
        Maintab.SelectedTabPage = XtraTabPage10
        XtraTabPage10.Visible = True
        'If Mode = FormMode.EditRecord Then Exit Sub
        'FillCost(3)
    End Sub


    Private Sub cboCUS_EditValueChanged(sender As Object, e As EventArgs) Handles cboCUS.EditValueChanged
        Dim sCusID As String
        If cboCUS.EditValue Is Nothing Then sCusID = toSQLValueS(Guid.Empty.ToString) Else sCusID = toSQLValueS(cboCUS.EditValue.ToString)
        Dim sSQL As New System.Text.StringBuilder
        sSQL.AppendLine("Select T.id,FullTranshDescription,Description
                        from vw_TRANSH t
                        where  T.cusid = " & sCusID & "order by description")
        FillCbo.TRANSH(cboTRANSH, sSQL)
    End Sub

    Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click
        Dim sResult As Boolean
        Dim sGuid As String
        Try
            If Valid.ValidateFormGRP(LayoutControlGroup1) Then
                If CostPrices.AgreementID.ToString = "" Then
                    XtraMessageBox.Show("Για να γίνει κοστολόγηση έργου πρέπει πρώτα να καταχωρηθεί Ιδ. Συμφωνητικό.", "Dreamy Kitchen CRM", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If

                Select Case Mode
                    Case FormMode.NewRecord
                        sGuid = System.Guid.NewGuid.ToString
                        sResult = DBQ.InsertNewData(DBQueries.InsertMode.GroupLayoutControl, "TRANSCOST",,, LayoutControlGroup1, sGuid, True)
                        sID = sGuid
                    Case FormMode.EditRecord
                        Dim ExtraFieldsAndValues As New System.Text.StringBuilder
                        ExtraFieldsAndValues.Append("TotAmt = " & toSQLValue(txtGenTot, True))
                        ExtraFieldsAndValues.Append(",TotKErm = " & toSQLValue(txtErmTotal, True))
                        ExtraFieldsAndValues.Append(",TotKEpendRaf = " & toSQLValue(txtEpendTotal, True))
                        ExtraFieldsAndValues.Append(",TotBackBench = " & toSQLValue(txtBenchTotal, True))
                        ExtraFieldsAndValues.Append(",TotK = " & toSQLValue(txtKTotalStandar, True))
                        ExtraFieldsAndValues.Append(",TotC = " & toSQLValue(txtCTotalStandar, True))
                        ExtraFieldsAndValues.Append(",TotD = " & toSQLValue(txtDTotal, True))
                        ExtraFieldsAndValues.Append(",TotSC = " & toSQLValue(txtSCTotal, True))
                        ExtraFieldsAndValues.Append(",TotDErm = " & toSQLValue(txtCErmTotal, True))
                        ExtraFieldsAndValues.Append(",TotalSalerProfit = " & toSQLValue(txtTotalSalerProfit, True))
                        ExtraFieldsAndValues.Append(",TotalCompanyProfit = " & toSQLValue(txtTotalCompanyProfit, True))
                        ExtraFieldsAndValues.Append(",TotamtWithoutProfit = " & toSQLValue(txtGenTotWithoutProfit, True))

                        'Γενικά Στοιχεία Κοστολόγησης
                        sResult = DBQ.UpdateNewData(DBQueries.InsertMode.GroupLayoutControl, "TRANSCOST",,, LayoutControlGroup1, sID, True,,,, ExtraFieldsAndValues.ToString)
                        'Ερμάρια Βάσεως
                        If sResult = True Then DBQ.UpdateNewData(DBQueries.InsertMode.GroupLayoutControl, "TRANSCOST",,, LayoutControlGroup5, sID)
                        'Ερμάρια Κρεμαστά
                        If sResult = True Then DBQ.UpdateNewData(DBQueries.InsertMode.GroupLayoutControl, "TRANSCOST",,, LayoutControlGroup3, sID)
                        'Ερμάρια Υψηλά
                        If sResult = True Then DBQ.UpdateNewData(DBQueries.InsertMode.GroupLayoutControl, "TRANSCOST",,, LayoutControlGroup6, sID)
                        'Επενδύσεις-Ραφιέρες-Ράφια Βάσεως
                        If sResult = True Then DBQ.UpdateNewData(DBQueries.InsertMode.GroupLayoutControl, "TRANSCOST",,, LayoutControlGroup8, sID)
                        'Επενδύσεις-Ραφιέρες-Ράφια Κρεμαστά
                        If sResult = True Then DBQ.UpdateNewData(DBQueries.InsertMode.GroupLayoutControl, "TRANSCOST",,, LayoutControlGroup10, sID)
                        'Επενδύσεις-Ραφιέρες-Ράφια Υψηλά
                        If sResult = True Then DBQ.UpdateNewData(DBQueries.InsertMode.GroupLayoutControl, "TRANSCOST",,, LayoutControlGroup11, sID)
                        'Πάγκοι-Πλάτες
                        If sResult = True Then DBQ.UpdateNewData(DBQueries.InsertMode.GroupLayoutControl, "TRANSCOST",,, LayoutControlGroup29, sID)
                        'Ανάλυση Πορτών
                        If sResult = True Then DBQ.UpdateNewData(DBQueries.InsertMode.GroupLayoutControl, "TRANSCOST",,, LayoutControlGroup19, sID)
                        'Ανάλυση Ειδ. Κατασκευής
                        If sResult = True Then DBQ.UpdateNewData(DBQueries.InsertMode.GroupLayoutControl, "TRANSCOST",,, LayoutControlGroup27, sID)
                        'Γενικά Στοιχεία Κουζίνας
                        If sResult = True Then DBQ.UpdateNewData(DBQueries.InsertMode.GroupLayoutControl, "TRANSCOST",,, LayoutControlGroup28, sID)
                        'Γενικά Στοιχεία Ντουλάπας
                        If sResult = True Then DBQ.UpdateNewData(DBQueries.InsertMode.GroupLayoutControl, "TRANSCOST",,, LayoutControlGroup30, sID)
                        'Γενικά Στοιχεία Πόρτας
                        If sResult = True Then DBQ.UpdateNewData(DBQueries.InsertMode.GroupLayoutControl, "TRANSCOST",,, LayoutControlGroup18, sID)
                        'Γενικά Στοιχεία Ειδ. Κατασκευής
                        If sResult = True Then DBQ.UpdateNewData(DBQueries.InsertMode.GroupLayoutControl, "TRANSCOST",,, LayoutControlGroup26, sID)
                        'Ανάλυση Ντουλαπών
                        If sResult = True Then DBQ.UpdateNewData(DBQueries.InsertMode.GroupLayoutControl, "TRANSCOST",,, LayoutControlGroup20, sID)
                        If sResult = True Then DBQ.UpdateNewData(DBQueries.InsertMode.GroupLayoutControl, "TRANSCOST",,, LayoutControlGroup21, sID)
                        If sResult = True Then DBQ.UpdateNewData(DBQueries.InsertMode.GroupLayoutControl, "TRANSCOST",,, LayoutControlGroup22, sID)
                        If sResult = True Then DBQ.UpdateNewData(DBQueries.InsertMode.GroupLayoutControl, "TRANSCOST",,, LayoutControlGroup23, sID)
                        If sResult = True Then DBQ.UpdateNewData(DBQueries.InsertMode.GroupLayoutControl, "TRANSCOST",,, LayoutControlGroup24, sID)
                        If sResult = True Then DBQ.UpdateNewData(DBQueries.InsertMode.GroupLayoutControl, "TRANSCOST",,, LayoutControlGroup25, sID)

                        'Μηχανισμοι Ντουλάπας - Κουζίνας
                        InsertSelectedRows()

                End Select

                If FScrollerExist = True Then
                    Dim form As frmScroller = Frm
                    form.LoadRecords("vw_TRANSCOST")
                End If

                If sResult = True Then
                    TileNavPane1.Enabled = True
                    XtraMessageBox.Show("Η εγγραφή αποθηκέυτηκε με επιτυχία", "Dreamy Kitchen CRM", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    '      Dim sSQL As New System.Text.StringBuilder
                    '     If CostPrices.Kitchen = True And Mode = FormMode.NewRecord Then Dim oCmd As New SqlCommand("INSERT INTO TRANSCOST_K (transCostID) SELECT " & toSQLValueS(sID), CNDB) : oCmd.ExecuteNonQuery()
                    If Mode = FormMode.NewRecord Then Mode = FormMode.EditRecord
                End If
            End If

        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), "Dreamy Kitchen CRM", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub InsertSelectedRows()
        Dim sSQL As String
        Dim I As Integer
        Try
            sSQL = "DELETE FROM TRANSCOST_EQ WHERE transCostID = " & toSQLValueS(sID)
            Using oCmd As New SqlCommand(sSQL, CNDB)
                oCmd.ExecuteNonQuery()
            End Using
            For I = 0 To GridView2.RowCount - 1
                sSQL = "INSERT INTO TRANSCOST_EQ(transCostID,cctOrdersKitchenEquipmentID,price,qty,Total,isKitchen) " &
                    " VALUES ( " & toSQLValueS(sID) & "," & toSQLValueS(GridView2.GetRowCellValue(I, "ID").ToString) & "," & toSQLValueS(GridView2.GetRowCellValue(I, "price").ToString, True) & "," & toSQLValueS(GridView2.GetRowCellValue(I, "qty").ToString, True) & "," & toSQLValueS(GridView2.GetRowCellValue(I, "Total").ToString, True) & ",1 )"
                Using oCmd As New SqlCommand(sSQL, CNDB)
                    oCmd.ExecuteNonQuery()
                End Using
            Next

            For I = 0 To GridView1.RowCount - 1
                sSQL = "INSERT INTO TRANSCOST_EQ(transCostID,cctOrdersKitchenEquipmentID,price,qty,Total,isCloset) " &
                    " VALUES ( " & toSQLValueS(sID) & "," & toSQLValueS(GridView1.GetRowCellValue(I, "ID").ToString) & "," & toSQLValueS(GridView1.GetRowCellValue(I, "price").ToString, True) & "," & toSQLValueS(GridView1.GetRowCellValue(I, "qty").ToString, True) & "," & toSQLValueS(GridView1.GetRowCellValue(I, "Total").ToString, True) & ",1 )"
                Using oCmd As New SqlCommand(sSQL, CNDB)
                    oCmd.ExecuteNonQuery()
                End Using
            Next
        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), "Dreamy Kitchen CRM", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub frmTransCost_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        If Me.WindowState = FormWindowState.Maximized Then frmMain.XtraTabbedMdiManager1.Dock(Me, frmMain.XtraTabbedMdiManager1)
    End Sub
    Private Sub ManageCus()
        Dim form1 As frmCustomers = New frmCustomers()
        form1.Text = "Πελάτες"
        form1.CallerControl = cboCUS
        form1.CalledFromControl = True
        form1.MdiParent = frmMain
        If cboCUS.EditValue <> Nothing Then
            form1.ID = cboCUS.EditValue.ToString
            form1.Mode = FormMode.EditRecord
        Else
            form1.Mode = FormMode.NewRecord
        End If
        frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(form1), New Point(CInt(form1.Parent.ClientRectangle.Width / 2 - form1.Width / 2), CInt(form1.Parent.ClientRectangle.Height / 2 - form1.Height / 2)))
        form1.Show()

    End Sub

    Private Sub cboTRANSH_EditValueChanged(sender As Object, e As EventArgs) Handles cboTRANSH.EditValueChanged
        Try
            If cboTRANSH.EditValue = Nothing Then
                Cls.ClearCtrls(LayoutControl2)
                Cls.ClearCtrls(LayoutControl3)
                Cls.ClearCtrls(LayoutControl4)
                Cls.ClearCtrls(LayoutControl5)
                Cls.ClearCtrls(LayoutControl6)
                Cls.ClearCtrls(LayoutControl7)
                Cls.ClearCtrls(LayoutControl8)
                Cls.ClearCtrls(LayoutControl9)
                Exit Sub
            End If
            Dim sSQL As New System.Text.StringBuilder
            sSQL.Append("Select id,code,dtOffer from CCT_ORDERS_KITCHEN where transhID = " & toSQLValueS(cboTRANSH.EditValue.ToString) & " order by code")
            FillCbo.CCE_ORDERS_KITCHEN(cboKcctOrders, sSQL)
            sSQL.Clear()

            sSQL.Append("Select A.ID As AgreementID, kitchen, closet, doors, sc
                        From AGREEMENT  A
                        INNER Join TRANSH T ON T.ID = A.transhID where T.ID = " & toSQLValueS(cboTRANSH.EditValue.ToString))
            Dim cmd As SqlCommand
            Dim sdr As SqlDataReader
            cmd = New SqlCommand(sSQL.ToString, CNDB)
            sdr = cmd.ExecuteReader()
            If (sdr.Read() = True) Then

                'ΕΠΙΛΟΓΕΣ ΕΡΓΟΥ(ΚΟΥΖΙΝΑ-ΝΤΟΥΛΑΠΑ-ΠΟΡΤΑ-ΕΙΔΙΚΗ ΚΑΤΑΣΚΕΥΗ)
                CostPrices.Kitchen = sdr.GetBoolean(sdr.GetOrdinal("kitchen"))
                CostPrices.Closet = sdr.GetBoolean(sdr.GetOrdinal("closet"))
                CostPrices.Doors = sdr.GetBoolean(sdr.GetOrdinal("doors"))
                CostPrices.SC = sdr.GetBoolean(sdr.GetOrdinal("sc"))
                CostPrices.AgreementID = sdr.GetGuid(sdr.GetOrdinal("AgreementID"))

                If CostPrices.Kitchen = True Then TileNavPane1.Categories.Item(0).Tile.Visible = True Else TileNavPane1.Categories.Item(0).Tile.Visible = False
                If CostPrices.Closet = True Then TileNavPane1.Categories.Item(1).Tile.Visible = True Else TileNavPane1.Categories.Item(1).Tile.Visible = False
                If CostPrices.Doors = True Then TileNavPane1.Categories.Item(2).Tile.Visible = True Else TileNavPane1.Categories.Item(2).Tile.Visible = False
                If CostPrices.SC = True Then TileNavPane1.Categories.Item(3).Tile.Visible = True Else TileNavPane1.Categories.Item(3).Tile.Visible = False
            End If
            sdr.Close()

        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), "Dreamy Kitchen CRM", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub
    Private Sub FillCostFromDB()
        '********************************* Κ Ο Υ Ζ Ι Ν Α**************************************
        CostPrices.KTransp = txtKtransport.EditValue            ' ΜΕΤΑΦΟΡΑ
        CostPrices.KPartofVat = txtKPartOfVat.EditValue         ' ΣΥΜΦΩΝΗΘΕΝ ΦΠΑ
        CostPrices.KMeasurement = txtKmeasurement.EditValue     ' ΕΠΙΜΕΤΡΗΣΗ
        CostPrices.KRemove = txtKRemove.EditValue               ' ΑΠΟΞΥΛΩΣΗ 
        CostPrices.KStandarTotal = CostPrices.KTransp + CostPrices.KPartofVat + CostPrices.KMeasurement + CostPrices.KRemove    ' ΣΥΝΟΛΟ ΓΕΝΙΚΩΝ ΣΤΟΙΧΕΙΩΝ
        ' ΕΡΜΑΡΙΑ
        CostPrices.VDoorPrice1 = txtVDoorPrice1.EditValue
        CostPrices.VDoorPrice2 = txtVDoorPrice2.EditValue
        CostPrices.KDoorPrice1 = txtKDoorPrice1.EditValue
        CostPrices.KDoorPrice2 = txtKDoorPrice2.EditValue
        CostPrices.YDoorPrice1 = txtYDoorPrice1.EditValue
        CostPrices.YDoorPrice2 = txtYDoorPrice2.EditValue
        CostPrices.Vtrm1 = Vtrm1.EditValue : CostPrices.VFinalPrice1 = CostPrices.Vtrm1 * CostPrices.VDoorPrice1
        CostPrices.Vtrm2 = Vtrm2.EditValue : CostPrices.VFinalPrice2 = CostPrices.Vtrm2 * CostPrices.VDoorPrice2
        CostPrices.VTotal = CostPrices.VFinalPrice1 + CostPrices.VFinalPrice2
        CostPrices.Ktrm1 = Ktrm1.EditValue : CostPrices.KFinalPrice1 = CostPrices.Ktrm1 * CostPrices.KDoorPrice1
        CostPrices.Ktrm2 = Ktrm2.EditValue : CostPrices.KFinalPrice2 = CostPrices.Ktrm2 * CostPrices.KDoorPrice2
        CostPrices.KTotal = CostPrices.KFinalPrice1 + CostPrices.KFinalPrice2
        CostPrices.Ytrm1 = Ytrm1.EditValue : CostPrices.YFinalPrice1 = CostPrices.Ytrm1 * CostPrices.YDoorPrice1
        CostPrices.Ytrm2 = Ytrm2.EditValue : CostPrices.YFinalPrice2 = CostPrices.Ytrm2 * CostPrices.YDoorPrice2
        CostPrices.YTotal = CostPrices.YFinalPrice1 + CostPrices.YFinalPrice2

        ' ΠΑΓΚΟΙ - ΠΛΑΤΕΣ
        CostPrices.BenchPrice1 = txtBenchDoorPrice1.EditValue
        CostPrices.BenchPrice2 = txtBenchDoorPrice2.EditValue
        CostPrices.BackPrice = txtBackDoorPrice.EditValue
        CostPrices.BenchTem1 = BenchTem1.EditValue : CostPrices.BenchFinalPrice1 = CostPrices.BenchTem1 * CostPrices.BenchPrice1
        CostPrices.BenchTem2 = BenchTem2.EditValue : CostPrices.BenchFinalPrice2 = CostPrices.BenchTem2 * CostPrices.BenchPrice2
        CostPrices.BackTem = BackTem.EditValue : CostPrices.BackFinalPrice = CostPrices.BackTem * CostPrices.BackPrice
        CostPrices.BenchBackTotal = CostPrices.BenchFinalPrice1 + CostPrices.BenchFinalPrice2 + CostPrices.BackFinalPrice

        ' ΕΠΕΝΔΥΣΕΙΣ - ΡΑΦΙΕΡΕΣ -ΡΑΦΙΑ
        CostPrices.VependisisPrice = txtVEpendDoorPrice.EditValue
        CostPrices.NependisisPrice = txtNEpendDoorPrice.EditValue
        CostPrices.VRafieraPrice = txtVRafPrice.EditValue
        CostPrices.KependisisPrice = txtKEpendDoorPrice.EditValue
        CostPrices.SependisisPrice = txtSEpendDoorPrice.EditValue
        CostPrices.KRafieraPrice = txtKRafPrice.EditValue
        CostPrices.YependisisPrice = txtYEpendDoorPrice.EditValue
        CostPrices.YRafieraPrice = txtYRafPrice.EditValue
        CostPrices.WRafieraPrice = txtWRafPrice.EditValue

        CostPrices.VEpendTrm = VEpendTrm.EditValue : CostPrices.VependisisFinalPrice = CostPrices.VEpendTrm * CostPrices.VependisisPrice
        CostPrices.NEpendTrm = NEpendTrm.EditValue : CostPrices.NependisisFinalPrice = CostPrices.NEpendTrm * CostPrices.NependisisPrice
        CostPrices.VRafTem = VRafTem.EditValue : CostPrices.VRafieraFinalPrice = CostPrices.VRafTem * CostPrices.VRafieraPrice
        CostPrices.KEpendTrm = KEpendTrm.EditValue : CostPrices.KependisisFinalPrice = CostPrices.KEpendTrm * CostPrices.KependisisPrice
        CostPrices.SEpendTrm = SEpendTrm.EditValue : CostPrices.SependisisFinalPrice = CostPrices.SEpendTrm * CostPrices.SependisisPrice
        CostPrices.KRafTem = KRafTem.EditValue : CostPrices.KRafieraFinalPrice = CostPrices.KRafTem * CostPrices.KRafieraPrice
        CostPrices.YEpendTrm = YEpendTrm.EditValue : CostPrices.YependisisFinalPrice = CostPrices.YEpendTrm * CostPrices.YependisisPrice
        CostPrices.YRafTem = YRafTem.EditValue : CostPrices.YRafieraFinalPrice = CostPrices.YRafTem * CostPrices.YRafieraPrice
        CostPrices.WRafTem = WRafTem.EditValue : CostPrices.WRafieraFinalPrice = CostPrices.WRafTem * CostPrices.WRafieraPrice

        CostPrices.VEpendisisTotal = CostPrices.VependisisFinalPrice + CostPrices.NependisisFinalPrice + CostPrices.VRafieraFinalPrice
        CostPrices.KEpendisisTotal = CostPrices.KependisisFinalPrice + CostPrices.SependisisFinalPrice + CostPrices.KRafieraFinalPrice + CostPrices.WRafieraFinalPrice
        CostPrices.YEpendisisTotal = CostPrices.YependisisFinalPrice + CostPrices.YRafieraFinalPrice
        CostPrices.BenchBackTotal = CostPrices.BenchFinalPrice1 + CostPrices.BenchFinalPrice2 + CostPrices.BackFinalPrice
        '********************************* Ν Τ Ο Υ Λ Α Π Α**************************************
        CostPrices.CTransp = txtCtransport.EditValue                ' ΜΕΤΑΦΟΡΑ
        CostPrices.CPartofVat = txtCPartOfVat.EditValue             ' ΣΥΜΦΩΝΗΘΕΝ ΦΠΑ
        CostPrices.CMeasurement = txtCmeasurement.EditValue         ' ΕΠΙΜΕΤΡΗΣΗ    
        CostPrices.CRemove = txtCRemove.EditValue                   ' ΑΠΟΞΥΛΩΣΗ
        CostPrices.CStandarTotal = CostPrices.CTransp + CostPrices.CPartofVat + CostPrices.CMeasurement + CostPrices.CRemove    ' ΣΥΝΟΛΟ ΓΕΝΙΚΩΝ ΣΤΟΙΧΕΙΩΝ

        ' ΑΝΑΛΥΣΗ ΝΤΟΥΛΑΠΩΝ
        CostPrices.ModelPrice1 = txtCDoorPrice1.EditValue
        CostPrices.ModelPrice2 = txtCDoorPrice2.EditValue
        CostPrices.ModelPrice3 = txtCDoorPrice3.EditValue
        CostPrices.ModelPrice4 = txtCDoorPrice4.EditValue
        CostPrices.ModelPrice5 = txtCDoorPrice5.EditValue
        CostPrices.ModelPrice6 = txtCDoorPrice6.EditValue
        CostPrices.ModelPrice7 = txtCDoorPrice7.EditValue
        CostPrices.ModelPrice8 = txtCDoorPrice8.EditValue
        CostPrices.ModelPrice9 = txtCDoorPrice9.EditValue
        CostPrices.ModelPrice10 = txtCDoorPrice10.EditValue
        CostPrices.ModelPrice11 = txtCDoorPrice11.EditValue
        CostPrices.ModelPrice12 = txtCDoorPrice12.EditValue
        CostPrices.PlainaPrice1 = txtPDoorPrice1.EditValue
        CostPrices.PlainaPrice2 = txtPDoorPrice2.EditValue
        CostPrices.PlainaPrice3 = txtPDoorPrice3.EditValue
        CostPrices.PlainaPrice4 = txtPDoorPrice4.EditValue
        CostPrices.PlainaPrice5 = txtPDoorPrice5.EditValue
        CostPrices.PlainaPrice6 = txtPDoorPrice6.EditValue

        CostPrices.CTm1 = Ctm1.EditValue
        CostPrices.CTm2 = Ctm2.EditValue
        CostPrices.CTm3 = Ctm3.EditValue
        CostPrices.CTm4 = Ctm4.EditValue
        CostPrices.CTm5 = Ctm5.EditValue
        CostPrices.CTm6 = Ctm6.EditValue
        CostPrices.CTm7 = Ctm7.EditValue
        CostPrices.CTm8 = Ctm8.EditValue
        CostPrices.CTm9 = Ctm9.EditValue
        CostPrices.CTm10 = Ctm10.EditValue
        CostPrices.CTm11 = Ctm11.EditValue
        CostPrices.CTm12 = Ctm12.EditValue


        CostPrices.ModelFinalPrice1 = CostPrices.CTm1 * CostPrices.ModelPrice1
        CostPrices.ModelFinalPrice2 = CostPrices.CTm2 * CostPrices.ModelPrice2
        CostPrices.ModelFinalPrice3 = CostPrices.CTm3 * CostPrices.ModelPrice3
        CostPrices.ModelFinalPrice4 = CostPrices.CTm4 * CostPrices.ModelPrice4
        CostPrices.ModelFinalPrice5 = CostPrices.CTm5 * CostPrices.ModelPrice5
        CostPrices.ModelFinalPrice6 = CostPrices.CTm6 * CostPrices.ModelPrice6
        CostPrices.ModelFinalPrice7 = CostPrices.CTm7 * CostPrices.ModelPrice7
        CostPrices.ModelFinalPrice8 = CostPrices.CTm8 * CostPrices.ModelPrice8
        CostPrices.ModelFinalPrice9 = CostPrices.CTm9 * CostPrices.ModelPrice9
        CostPrices.ModelFinalPrice10 = CostPrices.CTm10 * CostPrices.ModelPrice10
        CostPrices.ModelFinalPrice11 = CostPrices.CTm11 * CostPrices.ModelPrice11
        CostPrices.ModelFinalPrice12 = CostPrices.CTm12 * CostPrices.ModelPrice12

        CostPrices.PTem1 = CTem1.EditValue : CostPrices.PlainaFinalPrice1 = CostPrices.PTem1 * CostPrices.PlainaPrice1
        CostPrices.PTem2 = CTem2.EditValue : CostPrices.PlainaFinalPrice2 = CostPrices.PTem2 * CostPrices.PlainaPrice2
        CostPrices.PTem3 = CTem3.EditValue : CostPrices.PlainaFinalPrice3 = CostPrices.PTem3 * CostPrices.PlainaPrice3
        CostPrices.PTem4 = CTem4.EditValue : CostPrices.PlainaFinalPrice4 = CostPrices.PTem4 * CostPrices.PlainaPrice4
        CostPrices.PTem5 = CTem5.EditValue : CostPrices.PlainaFinalPrice5 = CostPrices.PTem5 * CostPrices.PlainaPrice5
        CostPrices.PTem6 = CTem6.EditValue : CostPrices.PlainaFinalPrice6 = CostPrices.PTem6 * CostPrices.PlainaPrice6

        CalculateCErmariaTotal()
        '********************************* Π Ο Ρ Τ Α **************************************
        'ΓΕΝΙΚΑ ΣΤΟΙΧΕΙΑ - ΠΟΡΤΑ
        CostPrices.DTransp = txtDtransport.EditValue            ' ΜΕΤΑΦΟΡΑ
        CostPrices.DPartofVat = txtDPartOfVat.EditValue         ' ΣΥΜΦΩΝΗΘΕΝ ΦΠΑ
        CostPrices.DMeasurement = txtDmeasurement.EditValue     ' ΕΠΙΜΕΤΡΗΣΗ
        CostPrices.DRemove = txtDRemove.EditValue               ' ΑΠΟΞΥΛΩΣΗ
        CostPrices.DStandarTotal = CostPrices.DTransp + CostPrices.DPartofVat + CostPrices.DMeasurement + CostPrices.DRemove           ' ΣΥΝΟΛΟ ΓΕΝΙΚΩΝ ΣΤΟΙΧΕΙΩΝ 

        ' ΑΝΑΛΥΣΗ ΠΟΡΤΩΝ
        CostPrices.DDoorPrice1 = txtDDoorPrice1.EditValue
        CostPrices.DDoorPrice2 = txtDDoorPrice2.EditValue
        CostPrices.DDoorPrice3 = txtDDoorPrice3.EditValue
        CostPrices.DDoorPrice4 = txtDDoorPrice4.EditValue
        CostPrices.DDoorPrice5 = txtDDoorPrice5.EditValue
        CostPrices.DDoorPrice6 = txtDDoorPrice6.EditValue
        CostPrices.DTem1 = DTem1.EditValue : CostPrices.DDoorFinalPrice1 = CostPrices.DTem1 * CostPrices.DDoorPrice1
        CostPrices.DTem2 = DTem2.EditValue : CostPrices.DDoorFinalPrice2 = CostPrices.DTem2 * CostPrices.DDoorPrice2
        CostPrices.DTem3 = DTem3.EditValue : CostPrices.DDoorFinalPrice3 = CostPrices.DTem3 * CostPrices.DDoorPrice3
        CostPrices.DTem4 = DTem4.EditValue : CostPrices.DDoorFinalPrice4 = CostPrices.DTem4 * CostPrices.DDoorPrice4
        CostPrices.DTem5 = DTem5.EditValue : CostPrices.DDoorFinalPrice5 = CostPrices.DTem5 * CostPrices.DDoorPrice5
        CostPrices.DTem6 = DTem6.EditValue : CostPrices.DDoorFinalPrice6 = CostPrices.DTem6 * CostPrices.DDoorPrice6

        CalculateDTotal()

        '********************************* Ε Ι Δ . Κ Α Τ Α Σ Κ Ε Υ Η **************************************
        'ΓΕΝΙΚΑ ΣΤΟΙΧΕΙΑ - ΕΙΔ. ΚΑΤΑΣΚΕΥΗ
        CostPrices.SCTransp = txtSCtransport.EditValue              ' ΜΕΤΑΦΟΡΑ
        CostPrices.SCPartofVat = txtSCPartOfVat.EditValue           ' ΣΥΜΦΩΝΗΘΕΝ ΦΠΑ    
        CostPrices.SCMeasurement = txtSCmeasurement.EditValue       ' ΕΠΙΜΕΤΡΗΣΗ    
        CostPrices.SCRemove = txtSCRemove.EditValue                 ' ΑΠΟΞΥΛΩΣΗ
        CostPrices.SCStandarTotal = CostPrices.SCTransp + CostPrices.SCPartofVat + CostPrices.SCMeasurement + CostPrices.SCRemove       ' ΣΥΝΟΛΟ ΓΕΝΙΚΩΝ ΣΤΟΙΧΕΙΩΝ

        ' ΑΝΑΛΥΣΗ ΕΙΔ. ΚΑΤΑΣΚΕΥΗΣ
        CostPrices.SCDoorFinalPrice1 = txtSCPrice1.EditValue
        CostPrices.SCDoorFinalPrice2 = txtSCPrice2.EditValue
        CostPrices.SCDoorFinalPrice3 = txtSCPrice3.EditValue
        CostPrices.SCDoorFinalPrice4 = txtSCPrice4.EditValue
        CostPrices.SCTotal = CostPrices.SCDoorFinalPrice1 + CostPrices.SCDoorFinalPrice2 + CostPrices.SCDoorFinalPrice3 + CostPrices.SCDoorFinalPrice4


        '********************************* Σ Υ Ν Ο Λ Α **************************************
        ' Γενικό σύνολο από όλα τα είδη πώλησης. Με ποσοστά
        CalculateGenTot()

    End Sub
    Private Sub CalculateGenTot()
        ' Ποσοστό κέρδους Πωλητή
        CostPrices.profitPercK = cboEMP.GetColumnValue("profitPercK")
        CostPrices.profitPercC = cboEMP.GetColumnValue("profitPercC")
        CostPrices.profitPercD = cboEMP.GetColumnValue("profitPercD")
        CostPrices.profitPercSC = cboEMP.GetColumnValue("profitPercSC")

        ' Ποσοστό κέρδους Επιχείρησης
        CostPrices.profitPercCompK = ProgProps.KCOMPANY_PROFIT - CostPrices.profitPercK
        CostPrices.profitPercCompC = ProgProps.CCOMPANY_PROFIT - CostPrices.profitPercC
        CostPrices.profitPercCompD = ProgProps.DCOMPANY_PROFIT - CostPrices.profitPercD
        CostPrices.profitPercCompSC = ProgProps.SCCOMPANY_PROFIT - CostPrices.profitPercSC


        ' ΚΟΥΖΙΝΑ ΣΥΝΟΛΑ
        CostPrices.GenTotK = CostPrices.KStandarTotal + CostPrices.VTotal + CostPrices.KTotal + CostPrices.YTotal + CostPrices.VEpendisisTotal + CostPrices.KEpendisisTotal +
                             CostPrices.YEpendisisTotal + CostPrices.BenchBackTotal + CostPrices.TotKEquipment
        CostPrices.SprofitK = (CostPrices.GenTotK / 100) * CostPrices.profitPercK
        CostPrices.CprofitK = (CostPrices.GenTotK / 100) * CostPrices.profitPercCompK
        CostPrices.GenTotK = CostPrices.GenTotK + CostPrices.SprofitK + CostPrices.CprofitK

        ' ΝΤΟΥΛΑΠΑ ΣΥΝΟΛΑ
        CostPrices.GenTotC = CostPrices.CStandarTotal + CostPrices.CErmariaTotal + CostPrices.TotCEquipment
        CostPrices.CprofitC = (CostPrices.GenTotC / 100) * CostPrices.profitPercCompC
        CostPrices.SprofitC = (CostPrices.GenTotC / 100) * CostPrices.profitPercC
        CostPrices.GenTotC = CostPrices.GenTotC + CostPrices.SprofitC + CostPrices.CprofitC

        ' ΠΟΡΤΑ ΣΥΝΟΛΑ
        CostPrices.GenTotD = CostPrices.DStandarTotal + CostPrices.DTotal + CostPrices.DDesign
        CostPrices.CprofitD = (CostPrices.GenTotD / 100) * CostPrices.profitPercCompD
        CostPrices.SprofitD = (CostPrices.GenTotD / 100) * CostPrices.profitPercD
        CostPrices.GenTotD = CostPrices.GenTotD + CostPrices.SprofitD + CostPrices.CprofitD

        ' ΕΙΔΙΚΗ ΚΑΤΑΣΚΕΥΗ ΣΥΝΟΛΑ
        CostPrices.GenTotSC = CostPrices.SCStandarTotal + CostPrices.SCTotal + CostPrices.SCDesign
        CostPrices.CprofitSC = (CostPrices.GenTotSC / 100) * CostPrices.profitPercCompSC
        CostPrices.SprofitSC = (CostPrices.GenTotSC / 100) * CostPrices.profitPercSC
        CostPrices.GenTotSC = CostPrices.GenTotSC + CostPrices.SprofitSC + CostPrices.CprofitSC
        CostPrices.GenTot = CostPrices.VTotal + CostPrices.KTotal + CostPrices.YTotal + CostPrices.VEpendisisTotal + CostPrices.KEpendisisTotal + CostPrices.YEpendisisTotal + CostPrices.BenchBackTotal + CostPrices.TotKEquipment +
                            CostPrices.CErmariaTotal + CostPrices.TotCEquipment + CostPrices.DTotal + CostPrices.KStandarTotal + CostPrices.CStandarTotal + CostPrices.DStandarTotal + CostPrices.SCStandarTotal
        ' Γενικό σύνολο από όλα τα είδη πώλησης και με τα ποσοστά
        CostPrices.GenTotWithoutProfit = CostPrices.GenTot

        CostPrices.GenTot = CostPrices.GenTot +
                            CostPrices.SprofitK + CostPrices.CprofitK +
                            CostPrices.SprofitC + CostPrices.CprofitC +
                            CostPrices.SprofitD + CostPrices.CprofitD +
                            CostPrices.SprofitSC + CostPrices.CprofitSC
        txtGenTot.EditValue = CostPrices.GenTot
        txtGenTotWithoutProfit.EditValue = CostPrices.GenTotWithoutProfit
        txtTotalSalerProfit.EditValue = CostPrices.SprofitK + CostPrices.SprofitC + CostPrices.SprofitD + CostPrices.SprofitSC
        txtTotalCompanyProfit.EditValue = CostPrices.CprofitK + CostPrices.CprofitC + CostPrices.CprofitD + CostPrices.CprofitSC
    End Sub
    Private Sub CalculateCErmariaTotal()
        CostPrices.CErmariaTotal = CostPrices.ModelFinalPrice1 + CostPrices.ModelFinalPrice2 + CostPrices.ModelFinalPrice3 + CostPrices.ModelFinalPrice4 + CostPrices.ModelFinalPrice5 + CostPrices.ModelFinalPrice6 +
                    CostPrices.ModelFinalPrice7 + CostPrices.ModelFinalPrice8 + +CostPrices.ModelFinalPrice9 + CostPrices.ModelFinalPrice10 + CostPrices.ModelFinalPrice11 + CostPrices.ModelFinalPrice12 +
                    CostPrices.PlainaFinalPrice1 + CostPrices.PlainaFinalPrice2 + CostPrices.PlainaFinalPrice3 + CostPrices.PlainaFinalPrice4 + CostPrices.PlainaFinalPrice5 + CostPrices.PlainaFinalPrice6
        txtCErmTotal.EditValue = CostPrices.CErmariaTotal
    End Sub
    Private Sub CalculateEpendisisTotal()
        CostPrices.VEpendisisTotal = CostPrices.VependisisFinalPrice + CostPrices.NependisisFinalPrice + CostPrices.VRafieraFinalPrice
        txtEpendTotal.EditValue = CostPrices.VEpendisisTotal + CostPrices.KEpendisisTotal + CostPrices.YEpendisisTotal

        CostPrices.KEpendisisTotal = CostPrices.KependisisFinalPrice + CostPrices.SependisisFinalPrice + CostPrices.KRafieraFinalPrice + CostPrices.WRafieraFinalPrice
        txtEpendTotal.EditValue = CostPrices.VEpendisisTotal + CostPrices.KEpendisisTotal + CostPrices.YEpendisisTotal

        CostPrices.YEpendisisTotal = CostPrices.YependisisFinalPrice + CostPrices.YRafieraFinalPrice
        txtEpendTotal.EditValue = CostPrices.VEpendisisTotal + CostPrices.KEpendisisTotal + CostPrices.YEpendisisTotal
    End Sub
    Private Sub CalculateBenchBackTotal()
        CostPrices.BenchBackTotal = CostPrices.BenchFinalPrice1 + CostPrices.BenchFinalPrice2 + CostPrices.BackFinalPrice
        txtBenchTotal.EditValue = CostPrices.BenchBackTotal
    End Sub
    Private Sub CalculateErmTotal()
        CostPrices.VTotal = CostPrices.VFinalPrice1 + CostPrices.VFinalPrice2
        CostPrices.KTotal = CostPrices.KFinalPrice1 + CostPrices.KFinalPrice2
        CostPrices.YTotal = CostPrices.YFinalPrice1 + CostPrices.YFinalPrice2
        txtErmTotal.EditValue = CostPrices.VTotal + CostPrices.KTotal + CostPrices.YTotal
    End Sub
    Private Sub CalculateDTotal()
        CostPrices.DTotal = CostPrices.DDoorFinalPrice1 + CostPrices.DDoorFinalPrice2 + CostPrices.DDoorFinalPrice3 + CostPrices.DDoorFinalPrice4 + CostPrices.DDoorFinalPrice5 + CostPrices.DDoorFinalPrice6 + CostPrices.DStandarTotal +
            CostPrices.DDesign
        txtDTotal.EditValue = CostPrices.DTotal
    End Sub
    Private Sub cboTRANSH_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles cboTRANSH.ButtonClick
        Select Case e.Button.Index
            Case 1 : If UserProps.ID.ToString.ToUpper = "3F9DC32E-BE5B-4D46-A13C-EA606566CF32" Then cboTRANSH.EditValue = Nothing : ManageTRANSH()
            Case 2 : If UserProps.ID.ToString.ToUpper = "3F9DC32E-BE5B-4D46-A13C-EA606566CF32" Then If cboTRANSH.EditValue <> Nothing Then ManageTRANSH()
            Case 3 : cboTRANSH.EditValue = Nothing
        End Select
    End Sub
    Private Sub ManageTRANSH()
        Dim form1 As frmTransactions = New frmTransactions()
        form1.Text = "Χρεωπιστώσεις Πελατών"
        form1.CallerControl = cboTRANSH
        form1.CalledFromControl = True
        form1.MdiParent = frmMain
        If cboTRANSH.EditValue <> Nothing Then
            form1.ID = cboTRANSH.EditValue.ToString
            form1.Mode = FormMode.EditRecord
        End If
        frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(form1), New Point(CInt(form1.Parent.ClientRectangle.Width / 2 - form1.Width / 2), CInt(form1.Parent.ClientRectangle.Height / 2 - form1.Height / 2)))
        form1.Show()
    End Sub
    Private Sub cboCUS_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles cboCUS.ButtonClick
        Select Case e.Button.Index
            Case 1 : cboCUS.EditValue = Nothing : ManageCus()
            Case 2 : If cboCUS.EditValue <> Nothing Then ManageCus()
            Case 3 : cboCUS.EditValue = Nothing
        End Select
    End Sub
    Private Sub cboEMP_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles cboEMP.ButtonClick
        Select Case e.Button.Index
            Case 1 : If UserProps.ID.ToString.ToUpper = "3F9DC32E-BE5B-4D46-A13C-EA606566CF32" Then cboEMP.EditValue = Nothing : ManageEMP()
            Case 2 : If UserProps.ID.ToString.ToUpper = "3F9DC32E-BE5B-4D46-A13C-EA606566CF32" Then If cboEMP.EditValue <> Nothing Then ManageEMP()
            Case 3 : cboEMP.EditValue = Nothing
        End Select
    End Sub
    Private Sub ManageEMP()
        Dim form1 As frmEMP = New frmEMP()
        form1.Text = "Προσωπικό"
        form1.CallerControl = cboEMP
        form1.CalledFromControl = True
        form1.MdiParent = frmMain
        If cboEMP.EditValue <> Nothing Then
            form1.ID = cboEMP.EditValue.ToString
            form1.Mode = FormMode.EditRecord
        Else
            form1.Mode = FormMode.NewRecord
        End If
        frmMain.XtraTabbedMdiManager1.Float(frmMain.XtraTabbedMdiManager1.Pages(form1), New Point(CInt(form1.Parent.ClientRectangle.Width / 2 - form1.Width / 2), CInt(form1.Parent.ClientRectangle.Height / 2 - form1.Height / 2)))
        form1.Show()
    End Sub

    Private Sub Vtrm1_EditValueChanged(sender As Object, e As EventArgs) Handles Vtrm1.EditValueChanged
        If Me.IsActive = False Then Exit Sub
        CostPrices.Vtrm1 = Vtrm1.EditValue
        CostPrices.VFinalPrice1 = CostPrices.Vtrm1 * CostPrices.VDoorPrice1
        txtvPrice1.EditValue = CostPrices.VFinalPrice1
    End Sub

    Private Sub Vtrm2_EditValueChanged(sender As Object, e As EventArgs) Handles Vtrm2.EditValueChanged
        If Me.IsActive = False Then Exit Sub
        CostPrices.Vtrm2 = Vtrm2.EditValue
        CostPrices.VFinalPrice2 = CostPrices.Vtrm2 * CostPrices.VDoorPrice2
        txtvPrice2.EditValue = CostPrices.VFinalPrice2
    End Sub

    Private Sub txtvPrice1_EditValueChanged(sender As Object, e As EventArgs) Handles txtvPrice1.EditValueChanged
        If Me.IsActive = True Then CalculateErmTotal()
    End Sub

    Private Sub txtvPrice2_EditValueChanged(sender As Object, e As EventArgs) Handles txtvPrice2.EditValueChanged
        If Me.IsActive = True Then CalculateErmTotal()
    End Sub
    Private Sub txtKPrice1_EditValueChanged(sender As Object, e As EventArgs) Handles txtKPrice1.EditValueChanged
        If Me.IsActive = True Then CalculateErmTotal()
    End Sub

    Private Sub txtKPrice2_EditValueChanged(sender As Object, e As EventArgs) Handles txtKPrice2.EditValueChanged
        If Me.IsActive = True Then CalculateErmTotal()
    End Sub

    Private Sub txtYDoorPrice1_EditValueChanged(sender As Object, e As EventArgs) Handles txtYDoorPrice1.EditValueChanged
        If Me.IsActive = True Then CalculateErmTotal()
    End Sub

    Private Sub txtYDoorPrice2_EditValueChanged(sender As Object, e As EventArgs) Handles txtYDoorPrice2.EditValueChanged
        If Me.IsActive = True Then CalculateErmTotal()
    End Sub

    Private Sub txtErmTotal_EditValueChanged(sender As Object, e As EventArgs) Handles txtErmTotal.EditValueChanged
        If Me.IsActive = True Then CalculateGenTot()
    End Sub
    Private Sub Ktrm1_EditValueChanged(sender As Object, e As EventArgs) Handles Ktrm1.EditValueChanged
        If Me.IsActive = False Then Exit Sub
        CostPrices.Ktrm1 = Ktrm1.EditValue
        CostPrices.KFinalPrice1 = CostPrices.Ktrm1 * CostPrices.KDoorPrice1
        txtKPrice1.EditValue = CostPrices.KFinalPrice1
    End Sub
    Private Sub Ktrm2_EditValueChanged(sender As Object, e As EventArgs) Handles Ktrm2.EditValueChanged
        If Me.IsActive = False Then Exit Sub
        CostPrices.Ktrm2 = Ktrm2.EditValue
        CostPrices.KFinalPrice2 = CostPrices.Ktrm2 * CostPrices.KDoorPrice2
        txtKPrice2.EditValue = CostPrices.KFinalPrice2
    End Sub

    Private Sub Ytrm1_EditValueChanged(sender As Object, e As EventArgs) Handles Ytrm1.EditValueChanged
        If Me.IsActive = False Then Exit Sub
        CostPrices.Ytrm1 = Ytrm1.EditValue
        CostPrices.YFinalPrice1 = CostPrices.Ytrm1 * CostPrices.YDoorPrice1
        txtYPrice1.EditValue = CostPrices.YFinalPrice1
    End Sub

    Private Sub Ytrm2_EditValueChanged(sender As Object, e As EventArgs) Handles Ytrm2.EditValueChanged
        If Me.IsActive = False Then Exit Sub
        CostPrices.Ytrm2 = Ytrm2.EditValue
        CostPrices.YFinalPrice2 = CostPrices.Ytrm2 * CostPrices.YDoorPrice2
        txtYPrice2.EditValue = CostPrices.YFinalPrice2
    End Sub

    Private Sub txtYPrice1_EditValueChanged(sender As Object, e As EventArgs) Handles txtYPrice1.EditValueChanged
        If Me.IsActive = True Then CalculateErmTotal()
    End Sub

    Private Sub txtYPrice2_EditValueChanged(sender As Object, e As EventArgs) Handles txtYPrice2.EditValueChanged
        If Me.IsActive = True Then CalculateErmTotal()
    End Sub
    Private Sub VEpendTrm_EditValueChanged(sender As Object, e As EventArgs) Handles VEpendTrm.EditValueChanged
        If Me.IsActive = False Then Exit Sub
        CostPrices.VEpendTrm = VEpendTrm.EditValue
        CostPrices.VependisisFinalPrice = CostPrices.VEpendTrm * CostPrices.VependisisPrice
        txtVEpendPrice.EditValue = CostPrices.VependisisFinalPrice
    End Sub

    Private Sub NEpendTrm_EditValueChanged(sender As Object, e As EventArgs) Handles NEpendTrm.EditValueChanged
        If Me.IsActive = False Then Exit Sub
        CostPrices.NEpendTrm = NEpendTrm.EditValue
        CostPrices.NependisisFinalPrice = CostPrices.NEpendTrm * CostPrices.NependisisPrice
        txtNEpendPrice.EditValue = CostPrices.NependisisFinalPrice
    End Sub
    Private Sub VRafTem_EditValueChanged(sender As Object, e As EventArgs) Handles VRafTem.EditValueChanged
        If Me.IsActive = False Then Exit Sub
        CostPrices.VRafTem = VRafTem.EditValue
        CostPrices.VRafieraFinalPrice = CostPrices.VRafTem * CostPrices.VRafieraPrice
        txtVTotRafPrice.EditValue = CostPrices.VRafieraFinalPrice
    End Sub

    Private Sub KEpendTrm_EditValueChanged(sender As Object, e As EventArgs) Handles KEpendTrm.EditValueChanged
        If Me.IsActive = False Then Exit Sub
        CostPrices.KEpendTrm = KEpendTrm.EditValue
        CostPrices.KependisisFinalPrice = CostPrices.KEpendTrm * CostPrices.KependisisPrice
        txtKEpendPrice.EditValue = CostPrices.KependisisFinalPrice
    End Sub

    Private Sub SEpendTrm_EditValueChanged(sender As Object, e As EventArgs) Handles SEpendTrm.EditValueChanged
        If Me.IsActive = False Then Exit Sub
        CostPrices.SEpendTrm = SEpendTrm.EditValue
        CostPrices.SependisisFinalPrice = CostPrices.SEpendTrm * CostPrices.SependisisPrice
        txtSEpendPrice.EditValue = CostPrices.SependisisFinalPrice
    End Sub

    Private Sub KRafTem_EditValueChanged(sender As Object, e As EventArgs) Handles KRafTem.EditValueChanged
        If Me.IsActive = False Then Exit Sub
        CostPrices.KRafTem = KRafTem.EditValue
        CostPrices.KRafieraFinalPrice = CostPrices.KRafTem * CostPrices.KRafieraPrice
        txtKTotRafPrice.EditValue = CostPrices.KRafieraFinalPrice
    End Sub

    Private Sub YEpendTrm_EditValueChanged(sender As Object, e As EventArgs) Handles YEpendTrm.EditValueChanged
        If Me.IsActive = False Then Exit Sub
        CostPrices.YEpendTrm = YEpendTrm.EditValue
        CostPrices.YependisisFinalPrice = CostPrices.YEpendTrm * CostPrices.YependisisPrice
        txtYEpendPrice.EditValue = CostPrices.YependisisFinalPrice
    End Sub

    Private Sub YRafTem_EditValueChanged(sender As Object, e As EventArgs) Handles YRafTem.EditValueChanged
        If Me.IsActive = False Then Exit Sub
        CostPrices.YRafTem = YRafTem.EditValue
        CostPrices.YRafieraFinalPrice = CostPrices.YRafTem * CostPrices.YRafieraPrice
        txtYTotRafPrice.EditValue = CostPrices.YRafieraFinalPrice
    End Sub

    Private Sub txtVEpendPrice_EditValueChanged(sender As Object, e As EventArgs) Handles txtVEpendPrice.EditValueChanged
        If Me.IsActive = True Then CalculateEpendisisTotal()
    End Sub

    Private Sub txtNEpendPrice_EditValueChanged(sender As Object, e As EventArgs) Handles txtNEpendPrice.EditValueChanged
        If Me.IsActive = True Then CalculateEpendisisTotal()
    End Sub

    Private Sub txtVTotRafPrice_EditValueChanged(sender As Object, e As EventArgs) Handles txtVTotRafPrice.EditValueChanged
        If Me.IsActive = True Then CalculateEpendisisTotal()
    End Sub

    Private Sub txtKEpendPrice_EditValueChanged(sender As Object, e As EventArgs) Handles txtKEpendPrice.EditValueChanged
        If Me.IsActive = True Then CalculateEpendisisTotal()
    End Sub

    Private Sub txtSEpendPrice_EditValueChanged(sender As Object, e As EventArgs) Handles txtSEpendPrice.EditValueChanged
        If Me.IsActive = True Then CalculateEpendisisTotal()
    End Sub

    Private Sub txtKTotRafPrice_EditValueChanged(sender As Object, e As EventArgs) Handles txtKTotRafPrice.EditValueChanged
        If Me.IsActive = True Then CalculateEpendisisTotal()
    End Sub

    Private Sub txtYEpendPrice_EditValueChanged(sender As Object, e As EventArgs) Handles txtYEpendPrice.EditValueChanged
        If Me.IsActive = True Then CalculateEpendisisTotal()
    End Sub

    Private Sub txtYTotRafPrice_EditValueChanged(sender As Object, e As EventArgs) Handles txtYTotRafPrice.EditValueChanged
        If Me.IsActive = True Then CalculateEpendisisTotal()
    End Sub

    Private Sub txtEpendTotal_EditValueChanged(sender As Object, e As EventArgs) Handles txtEpendTotal.EditValueChanged
        If Me.IsActive = True Then CalculateGenTot()
    End Sub

    Private Sub BenchTem1_EditValueChanged(sender As Object, e As EventArgs) Handles BenchTem1.EditValueChanged
        If Me.IsActive = False Then Exit Sub
        CostPrices.BenchTem1 = BenchTem1.EditValue
        CostPrices.BenchFinalPrice1 = CostPrices.BenchTem1 * CostPrices.BenchPrice1
        txtBenchPrice1.EditValue = CostPrices.BenchFinalPrice1
    End Sub

    Private Sub BenchTem2_EditValueChanged(sender As Object, e As EventArgs) Handles BenchTem2.EditValueChanged
        If Me.IsActive = False Then Exit Sub
        CostPrices.BenchTem2 = BenchTem2.EditValue
        CostPrices.BenchFinalPrice2 = CostPrices.BenchTem2 * CostPrices.BenchPrice2
        txtBenchPrice2.EditValue = CostPrices.BenchFinalPrice2
    End Sub

    Private Sub txtBenchTotal_EditValueChanged(sender As Object, e As EventArgs) Handles txtBenchTotal.EditValueChanged
        If Me.IsActive = True Then CalculateGenTot()
    End Sub

    Private Sub txtBenchPrice1_EditValueChanged(sender As Object, e As EventArgs) Handles txtBenchPrice1.EditValueChanged
        If Me.IsActive = True Then CalculateBenchBackTotal()
    End Sub

    Private Sub txtBenchPrice2_EditValueChanged(sender As Object, e As EventArgs) Handles txtBenchPrice2.EditValueChanged
        If Me.IsActive = True Then CalculateBenchBackTotal()
    End Sub

    Private Sub BackTem_EditValueChanged(sender As Object, e As EventArgs) Handles BackTem.EditValueChanged
        If Me.IsActive = False Then Exit Sub
        CostPrices.BackTem = BackTem.EditValue
        CostPrices.BackFinalPrice = CostPrices.BackTem * CostPrices.BackPrice
        txtBackPrice.EditValue = CostPrices.BackFinalPrice
    End Sub

    Private Sub txtBackPrice_EditValueChanged(sender As Object, e As EventArgs) Handles txtBackPrice.EditValueChanged
        If Me.IsActive = True Then CalculateBenchBackTotal()
    End Sub

    Private Sub GridView2_PopupMenuShowing(sender As Object, e As PopupMenuShowingEventArgs) Handles GridView2.PopupMenuShowing
        If e.MenuType = GridMenuType.Column Then LoadForms.PopupMenuShow(e, GridView2, "CCT_ORDERS_KITCHEN_EQUIPMENT_COST_def.xml", "vw_CCT_ORDERS_KITCHEN_EQUIPMENT")
    End Sub

    Private Sub Ctm1_EditValueChanged(sender As Object, e As EventArgs) Handles Ctm1.EditValueChanged
        If Me.IsActive = False Then Exit Sub
        CostPrices.CTm1 = Ctm1.EditValue
        CostPrices.ModelFinalPrice1 = CostPrices.CTm1 * CostPrices.ModelPrice1
        txtCPrice1.EditValue = CostPrices.ModelFinalPrice1
    End Sub
    Private Sub Ctm2_EditValueChanged(sender As Object, e As EventArgs) Handles Ctm2.EditValueChanged
        If Me.IsActive = False Then Exit Sub
        CostPrices.CTm2 = Ctm2.EditValue
        CostPrices.ModelFinalPrice2 = CostPrices.CTm2 * CostPrices.ModelPrice2
        txtCPrice2.EditValue = CostPrices.ModelFinalPrice2
    End Sub

    Private Sub Ctm3_EditValueChanged(sender As Object, e As EventArgs) Handles Ctm3.EditValueChanged
        If Me.IsActive = False Then Exit Sub
        CostPrices.CTm3 = Ctm3.EditValue
        CostPrices.ModelFinalPrice3 = CostPrices.CTm3 * CostPrices.ModelPrice3
        txtCPrice3.EditValue = CostPrices.ModelFinalPrice3
    End Sub

    Private Sub Ctm4_EditValueChanged(sender As Object, e As EventArgs) Handles Ctm4.EditValueChanged
        If Me.IsActive = False Then Exit Sub
        CostPrices.CTm4 = Ctm4.EditValue
        CostPrices.ModelFinalPrice4 = CostPrices.CTm4 * CostPrices.ModelPrice4
        txtCPrice4.EditValue = CostPrices.ModelFinalPrice4
    End Sub

    Private Sub Ctm5_EditValueChanged(sender As Object, e As EventArgs) Handles Ctm5.EditValueChanged
        If Me.IsActive = False Then Exit Sub
        CostPrices.CTm5 = Ctm5.EditValue
        CostPrices.ModelFinalPrice5 = CostPrices.CTm5 * CostPrices.ModelPrice5
        txtCPrice5.EditValue = CostPrices.ModelFinalPrice5
    End Sub

    Private Sub Ctm6_EditValueChanged(sender As Object, e As EventArgs) Handles Ctm6.EditValueChanged
        If Me.IsActive = False Then Exit Sub
        CostPrices.CTm6 = Ctm6.EditValue
        CostPrices.ModelFinalPrice6 = CostPrices.CTm6 * CostPrices.ModelPrice6
        txtCPrice6.EditValue = CostPrices.ModelFinalPrice6
    End Sub

    Private Sub Ctm7_EditValueChanged(sender As Object, e As EventArgs) Handles Ctm7.EditValueChanged
        If Me.IsActive = False Then Exit Sub
        CostPrices.CTm7 = Ctm7.EditValue
        CostPrices.ModelFinalPrice7 = CostPrices.CTm7 * CostPrices.ModelPrice7
        txtCPrice7.EditValue = CostPrices.ModelFinalPrice7
    End Sub

    Private Sub Ctm8_EditValueChanged(sender As Object, e As EventArgs) Handles Ctm8.EditValueChanged
        If Me.IsActive = False Then Exit Sub
        CostPrices.CTm8 = Ctm8.EditValue
        CostPrices.ModelFinalPrice8 = CostPrices.CTm8 * CostPrices.ModelPrice8
        txtCPrice8.EditValue = CostPrices.ModelFinalPrice8
    End Sub

    Private Sub Ctm9_EditValueChanged(sender As Object, e As EventArgs) Handles Ctm9.EditValueChanged
        If Me.IsActive = False Then Exit Sub
        CostPrices.CTm9 = Ctm9.EditValue
        CostPrices.ModelFinalPrice9 = CostPrices.CTm9 * CostPrices.ModelPrice9
        txtCPrice9.EditValue = CostPrices.ModelFinalPrice9
    End Sub

    Private Sub Ctm10_EditValueChanged(sender As Object, e As EventArgs) Handles Ctm10.EditValueChanged
        If Me.IsActive = False Then Exit Sub
        CostPrices.CTm10 = Ctm10.EditValue
        CostPrices.ModelFinalPrice10 = CostPrices.CTm10 * CostPrices.ModelPrice10
        txtCPrice10.EditValue = CostPrices.ModelFinalPrice10
    End Sub

    Private Sub Ctm11_EditValueChanged(sender As Object, e As EventArgs) Handles Ctm11.EditValueChanged
        If Me.IsActive = False Then Exit Sub
        CostPrices.CTm11 = Ctm11.EditValue
        CostPrices.ModelFinalPrice11 = CostPrices.CTm11 * CostPrices.ModelPrice11
        txtCPrice11.EditValue = CostPrices.ModelFinalPrice11
    End Sub

    Private Sub Ctm12_EditValueChanged(sender As Object, e As EventArgs) Handles Ctm12.EditValueChanged
        If Me.IsActive = False Then Exit Sub
        CostPrices.CTm12 = Ctm12.EditValue
        CostPrices.ModelFinalPrice12 = CostPrices.CTm12 * CostPrices.ModelPrice12
        txtCPrice12.EditValue = CostPrices.ModelFinalPrice12
    End Sub

    Private Sub CTem1_EditValueChanged(sender As Object, e As EventArgs) Handles CTem1.EditValueChanged
        If Me.IsActive = False Then Exit Sub
        CostPrices.PTem1 = CTem1.EditValue
        CostPrices.PlainaFinalPrice1 = CostPrices.PTem1 * CostPrices.PlainaPrice1
        txtPPrice1.EditValue = CostPrices.PlainaFinalPrice1
    End Sub

    Private Sub CTem2_EditValueChanged(sender As Object, e As EventArgs) Handles CTem2.EditValueChanged
        If Me.IsActive = False Then Exit Sub
        CostPrices.PTem2 = CTem2.EditValue
        CostPrices.PlainaFinalPrice2 = CostPrices.PTem2 * CostPrices.PlainaPrice2
        txtPPrice2.EditValue = CostPrices.PlainaFinalPrice2
    End Sub

    Private Sub CTem3_EditValueChanged(sender As Object, e As EventArgs) Handles CTem3.EditValueChanged
        If Me.IsActive = False Then Exit Sub
        CostPrices.PTem3 = CTem3.EditValue
        CostPrices.PlainaFinalPrice3 = CostPrices.PTem3 * CostPrices.PlainaPrice3
        txtPPrice3.EditValue = CostPrices.PlainaFinalPrice3
    End Sub

    Private Sub CTem4_EditValueChanged(sender As Object, e As EventArgs) Handles CTem4.EditValueChanged
        If Me.IsActive = False Then Exit Sub
        CostPrices.PTem4 = CTem4.EditValue
        CostPrices.PlainaFinalPrice4 = CostPrices.PTem4 * CostPrices.PlainaPrice4
        txtPPrice4.EditValue = CostPrices.PlainaFinalPrice4
    End Sub

    Private Sub CTem5_EditValueChanged(sender As Object, e As EventArgs) Handles CTem5.EditValueChanged
        If Me.IsActive = False Then Exit Sub
        CostPrices.PTem5 = CTem5.EditValue
        CostPrices.PlainaFinalPrice5 = CostPrices.PTem5 * CostPrices.PlainaPrice5
        txtPPrice5.EditValue = CostPrices.PlainaFinalPrice5
    End Sub

    Private Sub CTem6_EditValueChanged(sender As Object, e As EventArgs) Handles CTem6.EditValueChanged
        If Me.IsActive = False Then Exit Sub
        CostPrices.PTem6 = CTem6.EditValue
        CostPrices.PlainaFinalPrice6 = CostPrices.PTem6 * CostPrices.PlainaPrice6
        txtPPrice6.EditValue = CostPrices.PlainaFinalPrice6
    End Sub

    Private Sub txtCPrice1_EditValueChanged(sender As Object, e As EventArgs) Handles txtCPrice1.EditValueChanged
        If Me.IsActive = True Then CalculateCErmariaTotal()
    End Sub

    Private Sub txtCPrice2_EditValueChanged(sender As Object, e As EventArgs) Handles txtCPrice2.EditValueChanged
        If Me.IsActive = True Then CalculateCErmariaTotal()
    End Sub

    Private Sub txtPPrice1_EditValueChanged(sender As Object, e As EventArgs) Handles txtPPrice1.EditValueChanged
        If Me.IsActive = True Then CalculateCErmariaTotal()
    End Sub

    Private Sub txtCPrice3_EditValueChanged(sender As Object, e As EventArgs) Handles txtCPrice3.EditValueChanged
        If Me.IsActive = True Then CalculateCErmariaTotal()
    End Sub

    Private Sub txtCPrice4_EditValueChanged(sender As Object, e As EventArgs) Handles txtCPrice4.EditValueChanged
        If Me.IsActive = True Then CalculateCErmariaTotal()
    End Sub

    Private Sub txtPPrice2_EditValueChanged(sender As Object, e As EventArgs) Handles txtPPrice2.EditValueChanged
        If Me.IsActive = True Then CalculateCErmariaTotal()
    End Sub

    Private Sub txtCPrice5_EditValueChanged(sender As Object, e As EventArgs) Handles txtCPrice5.EditValueChanged
        If Me.IsActive = True Then CalculateCErmariaTotal()
    End Sub

    Private Sub txtCPrice6_EditValueChanged(sender As Object, e As EventArgs) Handles txtCPrice6.EditValueChanged
        If Me.IsActive = True Then CalculateCErmariaTotal()
    End Sub

    Private Sub txtPPrice3_EditValueChanged(sender As Object, e As EventArgs) Handles txtPPrice3.EditValueChanged
        If Me.IsActive = True Then CalculateCErmariaTotal()
    End Sub

    Private Sub txtCPrice7_EditValueChanged(sender As Object, e As EventArgs) Handles txtCPrice7.EditValueChanged
        If Me.IsActive = True Then CalculateCErmariaTotal()
    End Sub

    Private Sub txtCPrice8_EditValueChanged(sender As Object, e As EventArgs) Handles txtCPrice8.EditValueChanged
        If Me.IsActive = True Then CalculateCErmariaTotal()
    End Sub

    Private Sub txtPPrice4_EditValueChanged(sender As Object, e As EventArgs) Handles txtPPrice4.EditValueChanged
        If Me.IsActive = True Then CalculateCErmariaTotal()
    End Sub

    Private Sub txtCPrice9_EditValueChanged(sender As Object, e As EventArgs) Handles txtCPrice9.EditValueChanged
        If Me.IsActive = True Then CalculateCErmariaTotal()
    End Sub

    Private Sub txtCPrice10_EditValueChanged(sender As Object, e As EventArgs) Handles txtCPrice10.EditValueChanged
        If Me.IsActive = True Then CalculateCErmariaTotal()
    End Sub

    Private Sub txtPPrice5_EditValueChanged(sender As Object, e As EventArgs) Handles txtPPrice5.EditValueChanged
        If Me.IsActive = True Then CalculateCErmariaTotal()
    End Sub

    Private Sub txtCPrice11_EditValueChanged(sender As Object, e As EventArgs) Handles txtCPrice11.EditValueChanged
        If Me.IsActive = True Then CalculateCErmariaTotal()
    End Sub

    Private Sub txtCPrice12_EditValueChanged(sender As Object, e As EventArgs) Handles txtCPrice12.EditValueChanged
        If Me.IsActive = True Then CalculateCErmariaTotal()
    End Sub

    Private Sub txtPPrice6_EditValueChanged(sender As Object, e As EventArgs) Handles txtPPrice6.EditValueChanged
        If Me.IsActive = True Then CalculateCErmariaTotal()
    End Sub

    Private Sub txtCErmTotal_EditValueChanged(sender As Object, e As EventArgs) Handles txtCErmTotal.EditValueChanged
        If Me.IsActive = True Then CalculateGenTot()
    End Sub

    Private Sub TCMech_ElementClick(sender As Object, e As NavElementEventArgs) Handles TCMech.ElementClick
        Maintab.SelectedTabPage = XtraTabPage6
        XtraTabPage6.Visible = True
        'FillDataGridC()
    End Sub
    Private Sub FillDataGridC()
        LoadForms.LoadDataToGrid(GridControl1, GridView1,
                    "select EQ.ID,EQ.code,E.name, EQ.price,EQ.qty,(EQ.price * EQ.qty ) AS Total
					from CCT_ORDERS_CLOSET_EQUIPMENT  EQ
					INNER JOIN EQUIPMENT E ON E.ID = EQ.equipmentID 
					INNER JOIN CCT_ORDERS_CLOSET COK ON EQ.cctOrdersClosetID =  COK.ID 
					INNER JOIN TRANSH ON TRANSH.ID =  COK.transhID 
					where TRANSH.ID = " & toSQLValueS(cboTRANSH.EditValue.ToString))
        If System.IO.File.Exists(Application.StartupPath & "\DSGNS\DEF\CCT_ORDERS_CLOSET_EQUIPMENT_COST_def.xml") = True Then
            GridView1.RestoreLayoutFromXml(Application.StartupPath & "\DSGNS\DEF\CCT_ORDERS_CLOSET_EQUIPMENT_COST_def.xml", OptionsLayoutBase.FullLayout)
        End If
        GridView1.Columns.Item("name").OptionsColumn.AllowEdit = False : GridView1.Columns.Item("code").OptionsColumn.AllowEdit = False
        GridView1.Columns.Item("qty").OptionsColumn.AllowEdit = False : GridView1.Columns.Item("qty").OptionsColumn.AllowEdit = False
        GridView1.Columns.Item("price").OptionsColumn.AllowEdit = False : GridView1.Columns.Item("price").OptionsColumn.AllowEdit = False
        GridView1.Columns.Item("Total").OptionsColumn.AllowEdit = False : GridView1.Columns.Item("Total").OptionsColumn.AllowEdit = False
        CostPrices.TotCEquipment = GridView1.Columns("Total").SummaryItem.SummaryValue
    End Sub

    Private Sub GridView1_PopupMenuShowing(sender As Object, e As PopupMenuShowingEventArgs) Handles GridView1.PopupMenuShowing
        If e.MenuType = GridMenuType.Column Then LoadForms.PopupMenuShow(e, GridView1, "CCT_ORDERS_CLOSET_EQUIPMENT_COST_def.xml", "vw_CCT_ORDERS_CLOSET_EQUIPMENT")
    End Sub

    Private Sub DTem1_EditValueChanged(sender As Object, e As EventArgs) Handles DTem1.EditValueChanged
        If Me.IsActive = False Then Exit Sub
        CostPrices.DTem1 = DTem1.EditValue
        CostPrices.DDoorFinalPrice1 = CostPrices.DTem1 * CostPrices.DDoorPrice1
        txtDPrice1.EditValue = CostPrices.DDoorFinalPrice1

    End Sub

    Private Sub DTem2_EditValueChanged(sender As Object, e As EventArgs) Handles DTem2.EditValueChanged
        If Me.IsActive = False Then Exit Sub
        CostPrices.DTem2 = DTem2.EditValue
        CostPrices.DDoorFinalPrice2 = CostPrices.DTem2 * CostPrices.DDoorPrice2
        txtDPrice2.EditValue = CostPrices.DDoorFinalPrice2
    End Sub

    Private Sub DTem3_EditValueChanged(sender As Object, e As EventArgs) Handles DTem3.EditValueChanged
        If Me.IsActive = False Then Exit Sub
        CostPrices.DTem3 = DTem3.EditValue
        CostPrices.DDoorFinalPrice3 = CostPrices.DTem3 * CostPrices.DDoorPrice3
        txtDPrice3.EditValue = CostPrices.DDoorFinalPrice3
    End Sub

    Private Sub DTem4_EditValueChanged(sender As Object, e As EventArgs) Handles DTem4.EditValueChanged
        If Me.IsActive = False Then Exit Sub
        CostPrices.DTem4 = DTem4.EditValue
        CostPrices.DDoorFinalPrice4 = CostPrices.DTem4 * CostPrices.DDoorPrice4
        txtDPrice4.EditValue = CostPrices.DDoorFinalPrice4
    End Sub

    Private Sub DTem5_EditValueChanged(sender As Object, e As EventArgs) Handles DTem5.EditValueChanged
        If Me.IsActive = False Then Exit Sub
        CostPrices.DTem5 = DTem5.EditValue
        CostPrices.DDoorFinalPrice5 = CostPrices.DTem5 * CostPrices.DDoorPrice5
        txtDPrice5.EditValue = CostPrices.DDoorFinalPrice5
    End Sub

    Private Sub DTem6_EditValueChanged(sender As Object, e As EventArgs) Handles DTem6.EditValueChanged
        If Me.IsActive = False Then Exit Sub
        CostPrices.DTem6 = DTem6.EditValue
        CostPrices.DDoorFinalPrice6 = CostPrices.DTem6 * CostPrices.DDoorPrice6
        txtDPrice6.EditValue = CostPrices.DDoorFinalPrice6
    End Sub

    Private Sub txtDPrice1_EditValueChanged(sender As Object, e As EventArgs) Handles txtDPrice1.EditValueChanged
        If Me.IsActive = True Then CalculateDTotal()
    End Sub

    Private Sub txtDPrice2_EditValueChanged(sender As Object, e As EventArgs) Handles txtDPrice2.EditValueChanged
        If Me.IsActive = True Then CalculateDTotal()
    End Sub

    Private Sub txtDPrice3_EditValueChanged(sender As Object, e As EventArgs) Handles txtDPrice3.EditValueChanged
        If Me.IsActive = True Then CalculateDTotal()
    End Sub

    Private Sub txtDPrice4_EditValueChanged(sender As Object, e As EventArgs) Handles txtDPrice4.EditValueChanged
        If Me.IsActive = True Then CalculateDTotal()
    End Sub

    Private Sub txtDPrice5_EditValueChanged(sender As Object, e As EventArgs) Handles txtDPrice5.EditValueChanged
        If Me.IsActive = True Then CalculateDTotal()
    End Sub

    Private Sub txtDPrice6_EditValueChanged(sender As Object, e As EventArgs) Handles txtDPrice6.EditValueChanged
        If Me.IsActive = True Then CalculateDTotal()
    End Sub

    Private Sub txtDTotal_EditValueChanged(sender As Object, e As EventArgs) Handles txtDTotal.EditValueChanged
        If Me.IsActive = True Then CalculateDTotal()
    End Sub
    Private Sub txtDDesigner_EditValueChanged(sender As Object, e As EventArgs) Handles txtDDesigner.EditValueChanged
        If Me.IsActive = True Then CalculateDTotal()
    End Sub

    Private Sub txtVDoorPrice1_EditValueChanged(sender As Object, e As EventArgs) Handles txtVDoorPrice1.EditValueChanged
        If Me.IsActive = True Then CalculateErmTotal()
    End Sub

    Private Sub txtVDoorPrice2_EditValueChanged(sender As Object, e As EventArgs) Handles txtVDoorPrice2.EditValueChanged
        If Me.IsActive = True Then CalculateErmTotal()
    End Sub

    Private Sub txtKDoorPrice1_EditValueChanged(sender As Object, e As EventArgs) Handles txtKDoorPrice1.EditValueChanged
        If Me.IsActive = True Then CalculateErmTotal()
    End Sub

    Private Sub txtKDoorPrice2_EditValueChanged(sender As Object, e As EventArgs) Handles txtKDoorPrice2.EditValueChanged
        If Me.IsActive = True Then CalculateErmTotal()
    End Sub

    Private Sub WRafTem_EditValueChanged(sender As Object, e As EventArgs) Handles WRafTem.EditValueChanged
        If Me.IsActive = False Then Exit Sub
        CostPrices.WRafTem = WRafTem.EditValue
        CostPrices.WRafieraFinalPrice = CostPrices.WRafTem * CostPrices.WRafieraPrice
        txtWTotRafPrice.EditValue = CostPrices.WRafieraFinalPrice
    End Sub
    Private Sub txtSCDesigner_EditValueChanged(sender As Object, e As EventArgs) Handles txtSCDesigner.EditValueChanged
        If Me.IsActive = False Then Exit Sub
        CostPrices.SCDesign = txtSCDesigner.EditValue
        CostPrices.DTotal = CostPrices.SCDoorFinalPrice1 + CostPrices.SCDoorFinalPrice2 + CostPrices.SCDoorFinalPrice3 + CostPrices.SCDoorFinalPrice4 + CostPrices.SCStandarTotal + CostPrices.SCDesign
        txtSCTotal.EditValue = CostPrices.SCTotal
    End Sub
    Private Sub txtWTotRafPrice_EditValueChanged(sender As Object, e As EventArgs) Handles txtWTotRafPrice.EditValueChanged
        If Me.IsActive = True Then CalculateEpendisisTotal()
    End Sub

End Class