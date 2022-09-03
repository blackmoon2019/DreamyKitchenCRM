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
        Dim KEpendTrm As Double
        Dim SEpendTrm As Double
        Dim KRafTem As Double
        Dim KependisisFinalPrice As Double
        Dim SependisisFinalPrice As Double
        Dim KRafieraFinalPrice As Double
        Dim KEpendisisTotal As Double
        Dim KependisisDoorTypeID As Guid
        Dim SependisisDoorTypeID As Guid
        Dim KRafieraDoorTypeID As Guid
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
        'Γενικό σύνολο έργου
        Dim GenTot As Double
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
        Dim Prog_Prop As New ProgProp
        Prog_Prop.GetProgPROSF()
        'TODO: This line of code loads data into the 'DreamyKitchenDataSet.vw_COLORSBOX' table. You can move, or remove it, as needed.
        Me.Vw_COLORSBOXTableAdapter.Fill(Me.DreamyKitchenDataSet.vw_COLORSBOX)
        'TODO: This line of code loads data into the 'DreamyKitchenDataSet.vw_CCT' table. You can move, or remove it, as needed.
        Me.Vw_CCTTableAdapter.Fill(Me.DreamyKitchenDataSet.vw_CCT)
        'TODO: This line of code loads data into the 'DreamyKitchenDataSet.vw_SALERS' table. You can move, or remove it, as needed.
        Me.Vw_SALERSTableAdapter.Fill(Me.DreamyKitchenDataSet.vw_SALERS)
        XtraTabPage1.Visible = False

        Select Case Mode
            Case FormMode.NewRecord
                txtCode.Text = DBQ.GetNextId("TRANSCOST")
                cboEMP.EditValue = System.Guid.Parse(UserProps.ID.ToString.ToUpper)
                TileNavPane1.Enabled = False
            Case FormMode.EditRecord
                LoadForms.LoadForm(LayoutControl1, "Select * from TRANSCOST where id = " & toSQLValueS(sID))
                TileNavPane1.Enabled = True
        End Select

        Me.CenterToScreen()
        cmdSave.Enabled = IIf(Mode = FormMode.NewRecord, UserProps.AllowInsert, UserProps.AllowEdit)
    End Sub
    ' Κ Ο Υ Ζ Ι Ν Α
    Private Sub TErmaria_ElementClick(sender As Object, e As NavElementEventArgs) Handles TErmaria.ElementClick
        XtraTabPage1.Visible = True
        Maintab.SelectedTabPage = XtraTabPage1

        FillCost(0)

        CostPrices.VDoorPrice1 = cboVDoorType1.GetColumnValue("Price")
        txtVDoorPrice1.EditValue = CostPrices.VDoorPrice1

        CostPrices.VDoorPrice2 = cboVDoorType2.GetColumnValue("Price")
        txtVDoorPrice2.EditValue = CostPrices.VDoorPrice2

        CostPrices.KDoorPrice1 = cboKDoorType1.GetColumnValue("Price")
        txtKDoorPrice1.EditValue = CostPrices.KDoorPrice1

        CostPrices.KDoorPrice2 = cboKDoorType2.GetColumnValue("Price")
        txtKDoorPrice2.EditValue = CostPrices.KDoorPrice2

        CostPrices.YDoorPrice1 = cboYDoorType1.GetColumnValue("Price")
        txtYDoorPrice1.EditValue = CostPrices.YDoorPrice1

        CostPrices.YDoorPrice2 = cboYDoorType2.GetColumnValue("Price")
        txtYDoorPrice2.EditValue = CostPrices.YDoorPrice2

    End Sub

    Private Sub TEpendisis_ElementClick(sender As Object, e As NavElementEventArgs) Handles TEpendisis.ElementClick
        XtraTabPage2.Visible = True
        Maintab.SelectedTabPage = XtraTabPage2

        CostPrices.VependisisPrice = cboVependisisDoorType.GetColumnValue("Price")
        txtVEpendDoorPrice.EditValue = CostPrices.VependisisPrice

        CostPrices.NependisisPrice = cboNependisisDoorType.GetColumnValue("Price")
        txtNEpendDoorPrice.EditValue = CostPrices.NependisisPrice

        CostPrices.VRafieraPrice = cboVRafieraDoorType.GetColumnValue("Price")
        txtVRafPrice.EditValue = CostPrices.VRafieraPrice

        CostPrices.KependisisPrice = cboKependisisDoorType.GetColumnValue("Price")
        txtKEpendDoorPrice.EditValue = CostPrices.KependisisPrice

        CostPrices.SependisisPrice = cboSndEpendisisDoorType.GetColumnValue("Price")
        txtSEpendDoorPrice.EditValue = CostPrices.SependisisPrice

        CostPrices.KRafieraPrice = cboKRafieraDoorType.GetColumnValue("Price")
        txtKRafPrice.EditValue = CostPrices.KRafieraPrice

        CostPrices.YependisisPrice = cboPependisisDoorType.GetColumnValue("Price")
        txtYEpendDoorPrice.EditValue = CostPrices.YependisisPrice

        CostPrices.YRafieraPrice = cboYRafieraDoorType.GetColumnValue("Price")
        txtYRafPrice.EditValue = CostPrices.YRafieraPrice


    End Sub
    Private Sub TBech_ElementClick(sender As Object, e As NavElementEventArgs) Handles TBech.ElementClick
        Maintab.SelectedTabPage = XtraTabPage3
        XtraTabPage3.Visible = True

        CostPrices.BenchPrice1 = cboBenchType.GetColumnValue("pricePerMeter")
        txtBenchDoorPrice1.EditValue = CostPrices.BenchPrice1

        CostPrices.BenchPrice2 = cboBenchType2.GetColumnValue("pricePerMeter")
        txtBenchDoorPrice2.EditValue = CostPrices.BenchPrice2

        CostPrices.BackPrice = cboBack.GetColumnValue("pricePerMeter")
        txtBackDoorPrice.EditValue = CostPrices.BackPrice

    End Sub
    Private Sub TKitchen_ElementClick(sender As Object, e As NavElementEventArgs) Handles TKitchen.ElementClick
        Maintab.SelectedTabPage = XtraTabPage7
        FillCost(4)
    End Sub

    ' Ν Τ Ο Υ Λ Α Π Α
    Private Sub TCloset_ElementClick(sender As Object, e As NavElementEventArgs) Handles TCloset.ElementClick
        Maintab.SelectedTabPage = XtraTabPage8
        XtraTabPage8.Visible = True
        FillCost(5)
    End Sub

    Private Sub TCErmaria_ElementClick(sender As Object, e As NavElementEventArgs) Handles TCErmaria.ElementClick
        Maintab.SelectedTabPage = XtraTabPage5
        XtraTabPage5.Visible = True
        FillCost(1)

        CostPrices.ModelPrice1 = cboDoorType.GetColumnValue("price")
        txtCDoorPrice1.EditValue = CostPrices.ModelPrice1

        CostPrices.ModelPrice2 = cboDoorType2.GetColumnValue("price")
        txtCDoorPrice2.EditValue = CostPrices.ModelPrice2

        CostPrices.ModelPrice3 = cboDoorType3.GetColumnValue("price")
        txtCDoorPrice3.EditValue = CostPrices.ModelPrice3

        CostPrices.ModelPrice4 = cboDoorType4.GetColumnValue("price")
        txtCDoorPrice4.EditValue = CostPrices.ModelPrice4

        CostPrices.ModelPrice5 = cboDoorType5.GetColumnValue("price")
        txtCDoorPrice5.EditValue = CostPrices.ModelPrice5

        CostPrices.ModelPrice6 = cboDoorType6.GetColumnValue("price")
        txtCDoorPrice6.EditValue = CostPrices.ModelPrice6

        CostPrices.ModelPrice7 = cboDoorType7.GetColumnValue("price")
        txtCDoorPrice7.EditValue = CostPrices.ModelPrice7

        CostPrices.ModelPrice8 = cboDoorType8.GetColumnValue("price")
        txtCDoorPrice8.EditValue = CostPrices.ModelPrice8

        CostPrices.ModelPrice9 = cboDoorType9.GetColumnValue("price")
        txtCDoorPrice9.EditValue = CostPrices.ModelPrice9

        CostPrices.ModelPrice10 = cboDoorType10.GetColumnValue("price")
        txtCDoorPrice10.EditValue = CostPrices.ModelPrice10

        CostPrices.ModelPrice11 = cboDoorType11.GetColumnValue("price")
        txtCDoorPrice11.EditValue = CostPrices.ModelPrice11

        CostPrices.ModelPrice12 = cboDoorType12.GetColumnValue("price")
        txtCDoorPrice12.EditValue = CostPrices.ModelPrice12

        CostPrices.PlainaPrice1 = cboSides1.GetColumnValue("Price")
        txtPDoorPrice1.EditValue = CostPrices.PlainaPrice1

        CostPrices.PlainaPrice2 = cboSides2.GetColumnValue("Price")
        txtPDoorPrice2.EditValue = CostPrices.PlainaPrice2

        CostPrices.PlainaPrice3 = cboSides3.GetColumnValue("Price")
        txtPDoorPrice3.EditValue = CostPrices.PlainaPrice3

        CostPrices.PlainaPrice4 = cboSides4.GetColumnValue("Price")
        txtPDoorPrice4.EditValue = CostPrices.PlainaPrice4

        CostPrices.PlainaPrice5 = cboSides5.GetColumnValue("Price")
        txtPDoorPrice5.EditValue = CostPrices.PlainaPrice5

        CostPrices.PlainaPrice6 = cboSides6.GetColumnValue("Price")
        txtPDoorPrice6.EditValue = CostPrices.PlainaPrice6
    End Sub

    Private Sub TDoor_ElementClick(sender As Object, e As NavElementEventArgs) Handles TDoor.ElementClick
        Maintab.SelectedTabPage = XtraTabPage9
        XtraTabPage9.Visible = True
        FillCost(2)

        CostPrices.DDoorPrice1 = cboDDoorType1.GetColumnValue("price")
        txtDDoorPrice1.EditValue = CostPrices.DDoorPrice1

        CostPrices.DDoorPrice2 = cboDDoorType2.GetColumnValue("price")
        txtDDoorPrice2.EditValue = CostPrices.DDoorPrice2

        CostPrices.DDoorPrice3 = cboDDoorType3.GetColumnValue("price")
        txtDDoorPrice3.EditValue = CostPrices.DDoorPrice3

        CostPrices.DDoorPrice4 = cboDDoorType4.GetColumnValue("price")
        txtDDoorPrice4.EditValue = CostPrices.DDoorPrice4

        CostPrices.DDoorPrice5 = cboDDoorType5.GetColumnValue("price")
        txtDDoorPrice5.EditValue = CostPrices.DDoorPrice5

        CostPrices.DDoorPrice6 = cboDDoorType6.GetColumnValue("price")
        txtDDoorPrice6.EditValue = CostPrices.DDoorPrice6
    End Sub
    Private Sub TMech_ElementClick(sender As Object, e As NavElementEventArgs) Handles TMech.ElementClick
        Maintab.SelectedTabPage = XtraTabPage4
        XtraTabPage4.Visible = True

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

    End Sub

    Private Sub TVaseos_ElementClick(sender As Object, e As NavElementEventArgs)
        Maintab.SelectedTabPage = XtraTabPage1
        XtraTabPage1.Visible = True
    End Sub
    Private Sub TSC_ElementClick(sender As Object, e As NavElementEventArgs) Handles TSC.ElementClick
        Maintab.SelectedTabPage = XtraTabPage10
        XtraTabPage10.Visible = True
        FillCost(3)
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
            If Valid.ValidateForm(LayoutControl1) Then
                If CostPrices.AgreementID.ToString = "" Then
                    XtraMessageBox.Show("Για να γίνει κοστολόγηση έργου πρέπει πρώτα να καταχωρηθεί Ιδ. Συμφωνητικό.", "Dreamy Kitchen CRM", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If

                Select Case Mode
                    Case FormMode.NewRecord
                        sGuid = System.Guid.NewGuid.ToString
                        sResult = DBQ.InsertNewData(DBQueries.InsertMode.OneLayoutControl, "TRANSCOST", LayoutControl1,,, sGuid, True)
                        sID = sGuid
                    Case FormMode.EditRecord
                        sResult = DBQ.UpdateNewData(DBQueries.InsertMode.OneLayoutControl, "TRANSCOST", LayoutControl1,,, sID, True)
                End Select

                If FScrollerExist = True Then
                    Dim form As frmScroller = Frm
                    form.LoadRecords("vw_TRANSCOST")
                End If

                If sResult = True Then
                    TileNavPane1.Enabled = True
                    XtraMessageBox.Show("Η εγγραφή αποθηκέυτηκε με επιτυχία", "Dreamy Kitchen CRM", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Dim sSQL As New System.Text.StringBuilder
                    If CostPrices.Kitchen = True And Mode = FormMode.NewRecord Then Dim oCmd As New SqlCommand("INSERT INTO TRANSCOST_K (transCostID) SELECT " & toSQLValueS(sID), CNDB) : oCmd.ExecuteNonQuery()
                    If Mode = FormMode.NewRecord Then Mode = FormMode.EditRecord
                End If
            End If

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
            Dim sSQL As String
            sSQL = "Select A.ID as AgreementID,kitchen,closet,doors,sc
                    From AGREEMENT  A
                    INNER Join TRANSH T ON T.ID = A.transhID where T.ID = " & toSQLValueS(cboTRANSH.EditValue.ToString)
            Dim cmd As SqlCommand
            Dim sdr As SqlDataReader
            cmd = New SqlCommand(sSQL, CNDB)
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
    Private Sub FillCost(ByVal WhichOrder As Integer)
        Dim sSQL As String
        Try
            Select Case WhichOrder
                Case 0  'ΚΟΥΖΙΝΑ

                    sSQL = "Select A.ID as AgreementID,
                        ISNULL(K.PartOfVat, 0) As KPartOfVat,
				        ISNULL(K.Measurement, 0) as KMeasurement,
				        ISNULL(K.remove, 0) as KRemove,
				        ISNULL(K.ExtraTransp , 0) as KTransp,
                        ISNULL(K.VDoorTypeID ,'00000000-0000-0000-0000-000000000000') AS VDoorTypeID, 
	                    ISNULL(K.KDoorTypeID ,'00000000-0000-0000-0000-000000000000') AS KDoorTypeID, 
	                    ISNULL(K.YDoorTypeID ,'00000000-0000-0000-0000-000000000000') AS YDoorTypeID, 
	                    ISNULL(K.KDoorTypeID2,'00000000-0000-0000-0000-000000000000') AS KDoorTypeID2, 
                        ISNULL(K.VDoorTypeID2,'00000000-0000-0000-0000-000000000000') AS VDoorTypeID2, 
	                    ISNULL(K.YDoorTypeID2,'00000000-0000-0000-0000-000000000000') AS YDoorTypeID2,
				        ISNULL(K.BenchID,'00000000-0000-0000-0000-000000000000') AS BenchID, 
	                    ISNULL(K.BenchID2 ,'00000000-0000-0000-0000-000000000000') AS BenchID2, 
                        ISNULL(K.VependisisDoorTypeID ,'00000000-0000-0000-0000-000000000000') AS VependisisDoorTypeID,
                        ISNULL(K.NependisisDoorTypeID ,'00000000-0000-0000-0000-000000000000') AS NependisisDoorTypeID,
                        ISNULL(K.KependisisDoorTypeID ,'00000000-0000-0000-0000-000000000000') AS KependisisDoorTypeID ,
                        ISNULL(K.SndEpendisisDoorTypeID,'00000000-0000-0000-0000-000000000000') AS SndEpendisisDoorTypeID,
                        ISNULL(K.VRafieraDoorTypeID,'00000000-0000-0000-0000-000000000000') AS VRafieraDoorTypeID,
                        ISNULL(K.KRafieraDoorTypeID,'00000000-0000-0000-0000-000000000000') AS KRafieraDoorTypeID,
                        ISNULL(K.YRafieraDoorTypeID,'00000000-0000-0000-0000-000000000000') AS YRafieraDoorTypeID,
                        ISNULL(K.PependisisDoorTypeID,'00000000-0000-0000-0000-000000000000') AS PependisisDoorTypeID,
                        ISNULL(K.BackID,'00000000-0000-0000-0000-000000000000') AS BackID 
                        From AGREEMENT  A
                        INNER Join TRANSH T ON T.ID = A.transhID 
                        Left Join [dbo].[CCT_ORDERS_KITCHEN] K on K.transhID  = t.ID  " &
                        "where T.ID = " & toSQLValueS(cboTRANSH.EditValue.ToString)

                Case 1  'ΝΤΟΥΛΑΠΑ
                    sSQL = "Select A.ID as AgreementID,
                        ISNULL(C.PartOfVat, 0) As CPartOfVat,
				        ISNULL(C.Measurement, 0) as CMeasurement,
				        ISNULL(C.remove, 0) as CRemove,
				        ISNULL(C.ExtraTransp, 0) as CTransp,
                        ISNULL(C.BoxColorID  ,'00000000-0000-0000-0000-000000000000') AS BoxColorID, 
	                    ISNULL(C.BoxColorID2 ,'00000000-0000-0000-0000-000000000000') AS BoxColorID2, 
	                    ISNULL(C.BoxColorID3 ,'00000000-0000-0000-0000-000000000000') AS BoxColorID3, 
	                    ISNULL(C.BoxColorID4,'00000000-0000-0000-0000-000000000000') AS BoxColorID4, 
                        ISNULL(C.BoxColorID5,'00000000-0000-0000-0000-000000000000') AS BoxColorID5, 
	                    ISNULL(C.BoxColorID6,'00000000-0000-0000-0000-000000000000') AS BoxColorID6,
                        ISNULL(C.DoorTypeID  ,'00000000-0000-0000-0000-000000000000') AS DoorTypeID, 
	                    ISNULL(C.DoorTypeID2 ,'00000000-0000-0000-0000-000000000000') AS DoorTypeID2, 
	                    ISNULL(C.DoorTypeID3 ,'00000000-0000-0000-0000-000000000000') AS DoorTypeID3, 
	                    ISNULL(C.DoorTypeID4,'00000000-0000-0000-0000-000000000000') AS DoorTypeID4, 
                        ISNULL(C.DoorTypeID5,'00000000-0000-0000-0000-000000000000') AS DoorTypeID5, 
	                    ISNULL(C.DoorTypeID6,'00000000-0000-0000-0000-000000000000') AS DoorTypeID6,
				        ISNULL(C.DoorTypeID7  ,'00000000-0000-0000-0000-000000000000') AS DoorTypeID7, 
	                    ISNULL(C.DoorTypeID8 ,'00000000-0000-0000-0000-000000000000') AS DoorTypeID8, 
	                    ISNULL(C.DoorTypeID9 ,'00000000-0000-0000-0000-000000000000') AS DoorTypeID9, 
	                    ISNULL(C.DoorTypeID10,'00000000-0000-0000-0000-000000000000') AS DoorTypeID10, 
                        ISNULL(C.DoorTypeID11,'00000000-0000-0000-0000-000000000000') AS DoorTypeID11, 
	                    ISNULL(C.DoorTypeID12,'00000000-0000-0000-0000-000000000000') AS DoorTypeID12,
						ISNULL(C.Sides1,'00000000-0000-0000-0000-000000000000') AS SidesID1,
						ISNULL(C.Sides2,'00000000-0000-0000-0000-000000000000') AS SidesID2,
						ISNULL(C.Sides3,'00000000-0000-0000-0000-000000000000') AS SidesID3,
						ISNULL(C.Sides4,'00000000-0000-0000-0000-000000000000') AS SidesID4,
						ISNULL(C.Sides5,'00000000-0000-0000-0000-000000000000') AS SidesID5,
						ISNULL(C.Sides6,'00000000-0000-0000-0000-000000000000') AS SidesID6,
				        C.Model1,C.Model2,C.Model3,C.Model4,C.Model5,C.Model6
                        From AGREEMENT  A
                        INNER Join TRANSH T ON T.ID = A.transhID 
                        Left Join [dbo].[CCT_ORDERS_CLOSET]  C on C.transhID  = t.ID " &
                        "where T.ID = " & toSQLValueS(cboTRANSH.EditValue.ToString)
                Case 2  'ΠΟΡΤΑ
                    sSQL = "Select A.ID as AgreementID,
                        ISNULL(D.PartOfVat, 0) As DPartOfVat,
				        ISNULL(D.Measurement, 0) as DMeasurement,
				        ISNULL(D.remove, 0) as DRemove,
				        ISNULL(D.ExtraTransp, 0) as DTransp,
                        ISNULL(D.DoorTypeID  ,'00000000-0000-0000-0000-000000000000') AS DoorTypeID, 
	                    ISNULL(D.DoorTypeID2 ,'00000000-0000-0000-0000-000000000000') AS DoorTypeID2, 
	                    ISNULL(D.DoorTypeID3 ,'00000000-0000-0000-0000-000000000000') AS DoorTypeID3, 
	                    ISNULL(D.DoorTypeID4,'00000000-0000-0000-0000-000000000000') AS DoorTypeID4, 
                        ISNULL(D.DoorTypeID5,'00000000-0000-0000-0000-000000000000') AS DoorTypeID5, 
	                    ISNULL(D.DoorTypeID6,'00000000-0000-0000-0000-000000000000') AS DoorTypeID6,
						D.doorType1,D.doorType2,D.doorType3,D.doorType4,D.doorType5,D.doorType6,
						D.kasa1,D.kasa2,D.kasa3,D.kasa4,D.kasa5,D.kasa6
                        From AGREEMENT  A
                        INNER Join TRANSH T ON T.ID = A.transhID 
                        Left Join [dbo].[CCT_ORDERS_DOOR]   D on D.transhID  = t.ID " &
                        "where T.ID = " & toSQLValueS(cboTRANSH.EditValue.ToString)
                Case 3  'ΕΙΔ. ΚΑΤΑΣΚΕΥΗ
                    sSQL = "Select A.ID as AgreementID,
                        ISNULL(SC.PartOfVat, 0) As scPartOfVat,
				        ISNULL(SC.Measurement, 0) as SCMeasurement,
				        ISNULL(SC.Remove, 0) as SCRemove,
				        ISNULL(SC.ExtraTransp, 0) as SCTransp,
                        ISNULL(SC.DoorTypeID1 ,'00000000-0000-0000-0000-000000000000') AS DoorTypeID1, 
	                    ISNULL(SC.DoorTypeID2 ,'00000000-0000-0000-0000-000000000000') AS DoorTypeID2, 
	                    ISNULL(SC.DoorTypeID3 ,'00000000-0000-0000-0000-000000000000') AS DoorTypeID3,
	                    ISNULL(SC.DoorTypeID4,'00000000-0000-0000-0000-000000000000') AS  DoorTypeID4,
                        ISNULL(SC.constrTypeID1 ,'00000000-0000-0000-0000-000000000000') AS constrTypeID1, 
	                    ISNULL(SC.constrTypeID2 ,'00000000-0000-0000-0000-000000000000') AS constrTypeID2, 
	                    ISNULL(SC.constrTypeID3 ,'00000000-0000-0000-0000-000000000000') AS constrTypeID3,
	                    ISNULL(SC.constrTypeID4,'00000000-0000-0000-0000-000000000000') AS  constrTypeID4,
                        SC.modelFinalPrice1,SC.modelFinalPrice2,SC.modelFinalPrice3,SC.modelFinalPrice4
                        From AGREEMENT  A
                        INNER Join TRANSH T ON T.ID = A.transhID 
                        Left Join [dbo].[CCT_ORDERS_SPECIAL_CONSTR]   SC on SC.transhID  = t.ID  " &
                        "where T.ID = " & toSQLValueS(cboTRANSH.EditValue.ToString)
                Case 4  ' ΓΕΝΙΚΑ ΣΤΟΙΧΕΙΑ - ΚΟΥΖΙΝΑ
                    sSQL = "Select A.ID as AgreementID,
                        ISNULL(K.PartOfVat, 0) As KPartOfVat,
				        ISNULL(K.Measurement, 0) as KMeasurement,
				        ISNULL(K.remove, 0) as KRemove,
				        ISNULL(K.ExtraTransp , 0) as KTransp
                        From AGREEMENT  A
                        INNER Join TRANSH T ON T.ID = A.transhID 
                        Left Join [dbo].[CCT_ORDERS_KITCHEN] K on K.transhID  = t.ID  " &
                        "where T.ID = " & toSQLValueS(cboTRANSH.EditValue.ToString)
                Case 5  ' ΓΕΝΙΚΑ ΣΤΟΙΧΕΙΑ - ΝΤΟΥΛΑΠΑ
                    sSQL = "Select A.ID as AgreementID,
                        ISNULL(C.PartOfVat, 0) As CPartOfVat,
				        ISNULL(C.Measurement, 0) as CMeasurement,
				        ISNULL(C.remove, 0) as CRemove,
				        ISNULL(C.ExtraTransp, 0) as CTransp
                        From AGREEMENT  A
                        INNER Join TRANSH T ON T.ID = A.transhID 
                        Left Join [dbo].[CCT_ORDERS_CLOSET]  C on C.transhID  = t.ID " &
                        "where T.ID = " & toSQLValueS(cboTRANSH.EditValue.ToString)
                Case 6  ' ΓΕΝΙΚΑ ΣΤΟΙΧΕΙΑ - ΠΟΡΤΑ
                    sSQL = "Select A.ID as AgreementID,
                        ISNULL(D.PartOfVat, 0) As DPartOfVat,
				        ISNULL(D.Measurement, 0) as DMeasurement,
				        ISNULL(D.remove, 0) as DRemove,
				        ISNULL(D.ExtraTransp, 0) as DTransp
                        From AGREEMENT  A
                        INNER Join TRANSH T ON T.ID = A.transhID 
                        Left Join [dbo].[CCT_ORDERS_DOOR]   D on D.transhID  = t.ID " &
                        "where T.ID = " & toSQLValueS(cboTRANSH.EditValue.ToString)

                Case 7  ' ΓΕΝΙΚΑ ΣΤΟΙΧΕΙΑ - ΕΙΔ. ΚΑΤΑΣΚΕΥΗ
                    sSQL = "Select A.ID as AgreementID,
                        ISNULL(SC.PartOfVat, 0) As scPartOfVat,
				        ISNULL(SC.Measurement, 0) as SCMeasurement,
				        ISNULL(SC.Remove, 0) as SCRemove,
				        ISNULL(SC.ExtraTransp, 0) as SCTransp
                        From AGREEMENT  A
                        INNER Join TRANSH T ON T.ID = A.transhID 
                        Left Join [dbo].[CCT_ORDERS_SPECIAL_CONSTR]   SC on SC.transhID  = t.ID  " &
                        "where T.ID = " & toSQLValueS(cboTRANSH.EditValue.ToString)


            End Select

            Dim cmd As SqlCommand
            Dim sdr As SqlDataReader
            cmd = New SqlCommand(sSQL, CNDB)
            sdr = cmd.ExecuteReader()
            If (sdr.Read() = True) Then


                Select Case WhichOrder
                    Case 0  'ΚΟΥΖΙΝΑ

                        '********************************* Κ Ο Υ Ζ Ι Ν Α**************************************
                        'Β Α Σ Ε Ω Σ
                        CostPrices.VDoorType1 = sdr.GetGuid(sdr.GetOrdinal("VDoorTypeID")) : cboVDoorType1.EditValue = CostPrices.VDoorType1
                        CostPrices.VDoorType2 = sdr.GetGuid(sdr.GetOrdinal("VDoorTypeID2")) : cboVDoorType2.EditValue = CostPrices.VDoorType2

                        'Κ Ρ Ε Μ Α Σ Τ Α
                        CostPrices.KDoorType1 = sdr.GetGuid(sdr.GetOrdinal("KDoorTypeID")) : cboKDoorType1.EditValue = CostPrices.KDoorType1
                        CostPrices.KDoorType2 = sdr.GetGuid(sdr.GetOrdinal("KDoorTypeID2")) : cboKDoorType2.EditValue = CostPrices.KDoorType2

                        'Υ Ψ Η Λ Α
                        CostPrices.YDoorType1 = sdr.GetGuid(sdr.GetOrdinal("YDoorTypeID")) : cboYDoorType1.EditValue = CostPrices.YDoorType1
                        CostPrices.YDoorType2 = sdr.GetGuid(sdr.GetOrdinal("YDoorTypeID2")) : cboYDoorType2.EditValue = CostPrices.YDoorType2

                        '********************************* Ε Π Ε Ν Δ Υ Σ Ε Ι Σ - Ρ Α Φ Ι Ε Ρ Ε Σ**************************************
                        'Β Α Σ Ε Ω Σ
                        CostPrices.VependisisDoorTypeID = sdr.GetGuid(sdr.GetOrdinal("VependisisDoorTypeID")) : cboVependisisDoorType.EditValue = CostPrices.VependisisDoorTypeID
                        CostPrices.NependisisDoorTypeID = sdr.GetGuid(sdr.GetOrdinal("NependisisDoorTypeID")) : cboNependisisDoorType.EditValue = CostPrices.NependisisDoorTypeID
                        CostPrices.VRafieraDoorTypeID = sdr.GetGuid(sdr.GetOrdinal("VRafieraDoorTypeID")) : cboVRafieraDoorType.EditValue = CostPrices.VRafieraDoorTypeID

                        'Κ Ρ Ε Μ Α Σ Τ Α
                        CostPrices.KependisisDoorTypeID = sdr.GetGuid(sdr.GetOrdinal("KependisisDoorTypeID")) : cboKependisisDoorType.EditValue = CostPrices.KependisisDoorTypeID
                        CostPrices.SependisisDoorTypeID = sdr.GetGuid(sdr.GetOrdinal("SndEpendisisDoorTypeID")) : cboSndEpendisisDoorType.EditValue = CostPrices.SependisisDoorTypeID
                        CostPrices.KRafieraDoorTypeID = sdr.GetGuid(sdr.GetOrdinal("KRafieraDoorTypeID")) : cboKRafieraDoorType.EditValue = CostPrices.KRafieraDoorTypeID

                        'Υ Ψ Η Λ Α
                        CostPrices.YependisisDoorTypeID = sdr.GetGuid(sdr.GetOrdinal("PependisisDoorTypeID")) : cboPependisisDoorType.EditValue = CostPrices.YependisisDoorTypeID
                        CostPrices.YRafieraDoorTypeID = sdr.GetGuid(sdr.GetOrdinal("YRafieraDoorTypeID")) : cboYRafieraDoorType.EditValue = CostPrices.YRafieraDoorTypeID

                        '********************************* Π Α Γ Κ Ο Ι**************************************
                        CostPrices.BenchID = sdr.GetGuid(sdr.GetOrdinal("BenchID")) : cboBenchType.EditValue = CostPrices.BenchID
                        CostPrices.BenchID2 = sdr.GetGuid(sdr.GetOrdinal("BenchID2")) : cboBenchType2.EditValue = CostPrices.BenchID2
                        CostPrices.BackID = sdr.GetGuid(sdr.GetOrdinal("BackID")) : cboBack.EditValue = CostPrices.BackID


                    Case 1  'ΝΤΟΥΛΑΠΑ
                        '********************************* Ν Τ Ο Υ Λ Α Π Ε Σ**************************************
                        CostPrices.Model1 = sdr.GetString(sdr.GetOrdinal("Model1")) : cboClosetType1.Text = CostPrices.Model1
                        CostPrices.Model2 = sdr.GetString(sdr.GetOrdinal("Model2")) : cboClosetType2.Text = CostPrices.Model2
                        CostPrices.Model3 = sdr.GetString(sdr.GetOrdinal("Model3")) : cboClosetType3.Text = CostPrices.Model3
                        CostPrices.Model4 = sdr.GetString(sdr.GetOrdinal("Model4")) : cboClosetType4.Text = CostPrices.Model4
                        CostPrices.Model5 = sdr.GetString(sdr.GetOrdinal("Model5")) : cboClosetType5.Text = CostPrices.Model5
                        CostPrices.Model6 = sdr.GetString(sdr.GetOrdinal("Model6")) : cboClosetType6.Text = CostPrices.Model6

                        CostPrices.BoxColorID = sdr.GetGuid(sdr.GetOrdinal("BoxColorID")) : cboBOXColors.EditValue = CostPrices.BoxColorID
                        CostPrices.BoxColorID2 = sdr.GetGuid(sdr.GetOrdinal("BoxColorID2")) : cboBOXColors2.EditValue = CostPrices.BoxColorID2
                        CostPrices.BoxColorID3 = sdr.GetGuid(sdr.GetOrdinal("BoxColorID3")) : cboBOXColors3.EditValue = CostPrices.BoxColorID3
                        CostPrices.BoxColorID4 = sdr.GetGuid(sdr.GetOrdinal("BoxColorID4")) : cboBOXColors4.EditValue = CostPrices.BoxColorID4
                        CostPrices.BoxColorID5 = sdr.GetGuid(sdr.GetOrdinal("BoxColorID5")) : cboBOXColors5.EditValue = CostPrices.BoxColorID5
                        CostPrices.BoxColorID6 = sdr.GetGuid(sdr.GetOrdinal("BoxColorID6")) : cboBOXColors6.EditValue = CostPrices.BoxColorID6

                        LoadDoorType(cboBOXColors, cboDoorType, cboClosetType1) : LoadDoorType(cboBOXColors, cboDoorType7, cboClosetType1)
                        LoadDoorType(cboBOXColors2, cboDoorType2, cboClosetType2) : LoadDoorType(cboBOXColors2, cboDoorType8, cboClosetType2)
                        LoadDoorType(cboBOXColors3, cboDoorType3, cboClosetType3) : LoadDoorType(cboBOXColors3, cboDoorType9, cboClosetType3)
                        LoadDoorType(cboBOXColors4, cboDoorType4, cboClosetType4) : LoadDoorType(cboBOXColors4, cboDoorType10, cboClosetType4)
                        LoadDoorType(cboBOXColors5, cboDoorType5, cboClosetType5) : LoadDoorType(cboBOXColors5, cboDoorType11, cboClosetType5)
                        LoadDoorType(cboBOXColors6, cboDoorType6, cboClosetType6) : LoadDoorType(cboBOXColors6, cboDoorType12, cboClosetType6)

                        CostPrices.DoorTypeID = sdr.GetGuid(sdr.GetOrdinal("DoorTypeID")) : cboDoorType.EditValue = CostPrices.DoorTypeID
                        CostPrices.DoorTypeID2 = sdr.GetGuid(sdr.GetOrdinal("DoorTypeID2")) : cboDoorType2.EditValue = CostPrices.DoorTypeID2
                        CostPrices.DoorTypeID3 = sdr.GetGuid(sdr.GetOrdinal("DoorTypeID3")) : cboDoorType3.EditValue = CostPrices.DoorTypeID3
                        CostPrices.DoorTypeID4 = sdr.GetGuid(sdr.GetOrdinal("DoorTypeID4")) : cboDoorType4.EditValue = CostPrices.DoorTypeID4
                        CostPrices.DoorTypeID5 = sdr.GetGuid(sdr.GetOrdinal("DoorTypeID5")) : cboDoorType5.EditValue = CostPrices.DoorTypeID5
                        CostPrices.DoorTypeID6 = sdr.GetGuid(sdr.GetOrdinal("DoorTypeID6")) : cboDoorType6.EditValue = CostPrices.DoorTypeID6
                        CostPrices.DoorTypeID7 = sdr.GetGuid(sdr.GetOrdinal("DoorTypeID7")) : cboDoorType7.EditValue = CostPrices.DoorTypeID7
                        CostPrices.DoorTypeID8 = sdr.GetGuid(sdr.GetOrdinal("DoorTypeID8")) : cboDoorType8.EditValue = CostPrices.DoorTypeID8
                        CostPrices.DoorTypeID9 = sdr.GetGuid(sdr.GetOrdinal("DoorTypeID9")) : cboDoorType9.EditValue = CostPrices.DoorTypeID9
                        CostPrices.DoorTypeID10 = sdr.GetGuid(sdr.GetOrdinal("DoorTypeID10")) : cboDoorType10.EditValue = CostPrices.DoorTypeID10
                        CostPrices.DoorTypeID11 = sdr.GetGuid(sdr.GetOrdinal("DoorTypeID11")) : cboDoorType11.EditValue = CostPrices.DoorTypeID11
                        CostPrices.DoorTypeID12 = sdr.GetGuid(sdr.GetOrdinal("DoorTypeID12")) : cboDoorType12.EditValue = CostPrices.DoorTypeID12

                        CostPrices.SidesID1 = sdr.GetGuid(sdr.GetOrdinal("SidesID1")) : cboSides1.EditValue = CostPrices.SidesID1
                        CostPrices.SidesID2 = sdr.GetGuid(sdr.GetOrdinal("SidesID2")) : cboSides2.EditValue = CostPrices.SidesID2
                        CostPrices.SidesID3 = sdr.GetGuid(sdr.GetOrdinal("SidesID3")) : cboSides3.EditValue = CostPrices.SidesID3
                        CostPrices.SidesID4 = sdr.GetGuid(sdr.GetOrdinal("SidesID4")) : cboSides4.EditValue = CostPrices.SidesID4
                        CostPrices.SidesID5 = sdr.GetGuid(sdr.GetOrdinal("SidesID5")) : cboSides5.EditValue = CostPrices.SidesID5
                        CostPrices.SidesID6 = sdr.GetGuid(sdr.GetOrdinal("SidesID6")) : cboSides6.EditValue = CostPrices.SidesID6



                    Case 2  'ΠΟΡΤΑ

                        CostPrices.DoorType1 = sdr.GetString(sdr.GetOrdinal("DoorType1")) : cboType1.Text = CostPrices.DoorType1
                        CostPrices.DoorType2 = sdr.GetString(sdr.GetOrdinal("DoorType2")) : cboType2.Text = CostPrices.DoorType2
                        CostPrices.DoorType3 = sdr.GetString(sdr.GetOrdinal("DoorType3")) : cboType3.Text = CostPrices.DoorType3
                        CostPrices.DoorType4 = sdr.GetString(sdr.GetOrdinal("DoorType4")) : cboType4.Text = CostPrices.DoorType4
                        CostPrices.DoorType5 = sdr.GetString(sdr.GetOrdinal("DoorType5")) : cboType5.Text = CostPrices.DoorType5
                        CostPrices.DoorType6 = sdr.GetString(sdr.GetOrdinal("DoorType6")) : cboType6.Text = CostPrices.DoorType6

                        CostPrices.Kasa1 = sdr.GetInt32(sdr.GetOrdinal("Kasa1")) : cboKasa1.Text = CostPrices.Kasa1
                        CostPrices.Kasa2 = sdr.GetInt32(sdr.GetOrdinal("Kasa2")) : cboKasa2.Text = CostPrices.Kasa2
                        CostPrices.Kasa3 = sdr.GetInt32(sdr.GetOrdinal("Kasa3")) : cboKasa3.Text = CostPrices.Kasa3
                        CostPrices.Kasa4 = sdr.GetInt32(sdr.GetOrdinal("Kasa4")) : cboKasa4.Text = CostPrices.Kasa4
                        CostPrices.Kasa5 = sdr.GetInt32(sdr.GetOrdinal("Kasa5")) : cboKasa5.Text = CostPrices.Kasa5
                        CostPrices.Kasa6 = sdr.GetInt32(sdr.GetOrdinal("Kasa6")) : cboKasa6.Text = CostPrices.Kasa6

                        LoadDoorTypeDoor(cboType1, cboKasa1, cboDDoorType1)
                        LoadDoorTypeDoor(cboType2, cboKasa2, cboDDoorType2)
                        LoadDoorTypeDoor(cboType3, cboKasa3, cboDDoorType3)
                        LoadDoorTypeDoor(cboType4, cboKasa4, cboDDoorType4)
                        LoadDoorTypeDoor(cboType5, cboKasa5, cboDDoorType5)
                        LoadDoorTypeDoor(cboType6, cboKasa6, cboDDoorType6)


                        CostPrices.DDoorTypeID1 = sdr.GetGuid(sdr.GetOrdinal("DoorTypeID")) : cboDDoorType1.EditValue = CostPrices.DDoorTypeID1
                        CostPrices.DDoorTypeID2 = sdr.GetGuid(sdr.GetOrdinal("DoorTypeID2")) : cboDDoorType2.EditValue = CostPrices.DDoorTypeID2
                        CostPrices.DDoorTypeID3 = sdr.GetGuid(sdr.GetOrdinal("DoorTypeID3")) : cboDDoorType3.EditValue = CostPrices.DDoorTypeID3
                        CostPrices.DDoorTypeID4 = sdr.GetGuid(sdr.GetOrdinal("DoorTypeID4")) : cboDDoorType4.EditValue = CostPrices.DDoorTypeID4
                        CostPrices.DDoorTypeID5 = sdr.GetGuid(sdr.GetOrdinal("DoorTypeID5")) : cboDDoorType5.EditValue = CostPrices.DDoorTypeID5
                        CostPrices.DDoorTypeID6 = sdr.GetGuid(sdr.GetOrdinal("DoorTypeID6")) : cboDDoorType6.EditValue = CostPrices.DDoorTypeID6
                    Case 3  'ΕΙΔ. ΚΑΤΑΣΚΕΥΗ
                        CostPrices.SCDoorTypeID1 = sdr.GetGuid(sdr.GetOrdinal("DoorTypeID1")) : cboSCDoorType1.EditValue = CostPrices.SCDoorTypeID1
                        CostPrices.SCDoorTypeID2 = sdr.GetGuid(sdr.GetOrdinal("DoorTypeID2")) : cboSCDoorType2.EditValue = CostPrices.SCDoorTypeID2
                        CostPrices.SCDoorTypeID3 = sdr.GetGuid(sdr.GetOrdinal("DoorTypeID3")) : cboSCDoorType3.EditValue = CostPrices.SCDoorTypeID3
                        CostPrices.SCDoorTypeID4 = sdr.GetGuid(sdr.GetOrdinal("DoorTypeID4")) : cboSCDoorType4.EditValue = CostPrices.SCDoorTypeID4

                        CostPrices.ScpecialConstr1 = sdr.GetGuid(sdr.GetOrdinal("constrTypeID1")) : cboScpecialConstr1.EditValue = CostPrices.ScpecialConstr1
                        CostPrices.ScpecialConstr2 = sdr.GetGuid(sdr.GetOrdinal("constrTypeID2")) : cboScpecialConstr2.EditValue = CostPrices.ScpecialConstr2
                        CostPrices.ScpecialConstr3 = sdr.GetGuid(sdr.GetOrdinal("constrTypeID3")) : cboScpecialConstr3.EditValue = CostPrices.ScpecialConstr3
                        CostPrices.ScpecialConstr4 = sdr.GetGuid(sdr.GetOrdinal("constrTypeID4")) : cboScpecialConstr4.EditValue = CostPrices.ScpecialConstr4

                        CostPrices.SCDoorFinalPrice1 = sdr.GetDecimal(sdr.GetOrdinal("modelFinalPrice1")) : txtSCPrice1.EditValue = CostPrices.SCDoorFinalPrice1
                        CostPrices.SCDoorFinalPrice2 = sdr.GetDecimal(sdr.GetOrdinal("modelFinalPrice2")) : txtSCPrice2.EditValue = CostPrices.SCDoorFinalPrice2
                        CostPrices.SCDoorFinalPrice3 = sdr.GetDecimal(sdr.GetOrdinal("modelFinalPrice3")) : txtSCPrice3.EditValue = CostPrices.SCDoorFinalPrice3
                        CostPrices.SCDoorFinalPrice4 = sdr.GetDecimal(sdr.GetOrdinal("modelFinalPrice4")) : txtSCPrice4.EditValue = CostPrices.SCDoorFinalPrice4
                        CostPrices.SCTotal = CostPrices.SCDoorFinalPrice1 + CostPrices.SCDoorFinalPrice2 + CostPrices.SCDoorFinalPrice3 + CostPrices.SCDoorFinalPrice4
                        txtSCTotal.EditValue = CostPrices.SCTotal
                        CostPrices.GenTot = CostPrices.VTotal + CostPrices.KTotal + CostPrices.YTotal + CostPrices.VEpendisisTotal + CostPrices.KEpendisisTotal + CostPrices.YEpendisisTotal + CostPrices.BenchBackTotal + CostPrices.TotKEquipment +
                                               CostPrices.CErmariaTotal + CostPrices.TotCEquipment + CostPrices.DTotal + CostPrices.SCTotal + CostPrices.KStandarTotal + CostPrices.CStandarTotal + CostPrices.DStandarTotal + CostPrices.SCStandarTotal

                        txtGenTot.EditValue = CostPrices.GenTot

                    Case 4  'ΓΕΝΙΚΑ ΣΤΟΙΧΕΙΑ - ΚΟΥΖΙΝΑ 
                        ' ΜΕΤΑΦΟΡΑ
                        CostPrices.KTransp = sdr.GetDecimal(sdr.GetOrdinal("KTransp")) : txtKtransport.EditValue = CostPrices.KTransp
                        ' ΣΥΜΦΩΝΗΘΕΝ ΦΠΑ
                        CostPrices.KPartofVat = sdr.GetDecimal(sdr.GetOrdinal("KPartOfVat")) : txtKPartOfVat.EditValue = CostPrices.KPartofVat
                        ' ΕΠΙΜΕΤΡΗΣΗ
                        CostPrices.KMeasurement = sdr.GetDecimal(sdr.GetOrdinal("KMeasurement")) : txtKmeasurement.EditValue = CostPrices.KMeasurement
                        ' ΑΠΟΞΥΛΩΣΗ
                        CostPrices.KRemove = sdr.GetDecimal(sdr.GetOrdinal("KRemove")) : txtKRemove.EditValue = CostPrices.KRemove
                        ' ΣΥΝΟΛΟ ΓΕΝΙΚΩΝ ΣΤΟΙΧΕΙΩΝ
                        CostPrices.KStandarTotal = CostPrices.KTransp + CostPrices.KPartofVat + CostPrices.KMeasurement + CostPrices.KRemove
                        txtKTotalStandar.EditValue = CostPrices.KStandarTotal
                        CostPrices.GenTot = CostPrices.VTotal + CostPrices.KTotal + CostPrices.YTotal + CostPrices.VEpendisisTotal + CostPrices.KEpendisisTotal + CostPrices.YEpendisisTotal + CostPrices.BenchBackTotal + CostPrices.TotKEquipment +
                                               CostPrices.CErmariaTotal + CostPrices.TotCEquipment + CostPrices.DTotal + CostPrices.SCTotal + CostPrices.KStandarTotal + CostPrices.CStandarTotal + CostPrices.DStandarTotal + CostPrices.SCStandarTotal

                        txtGenTot.EditValue = CostPrices.GenTot
                    Case 5 'ΓΕΝΙΚΑ ΣΤΟΙΧΕΙΑ - ΝΤΟΥΛΑΠΑ
                        ' ΜΕΤΑΦΟΡΑ
                        CostPrices.CTransp = sdr.GetDecimal(sdr.GetOrdinal("CTransp")) : txtCtransport.EditValue = CostPrices.CTransp
                        ' ΣΥΜΦΩΝΗΘΕΝ ΦΠΑ
                        CostPrices.CPartofVat = sdr.GetDecimal(sdr.GetOrdinal("CPartOfVat")) : txtCPartOfVat.EditValue = CostPrices.CPartofVat
                        ' ΕΠΙΜΕΤΡΗΣΗ
                        CostPrices.CMeasurement = sdr.GetDecimal(sdr.GetOrdinal("CMeasurement")) : txtCmeasurement.EditValue = CostPrices.CMeasurement
                        ' ΑΠΟΞΥΛΩΣΗ
                        CostPrices.CRemove = sdr.GetDecimal(sdr.GetOrdinal("CRemove")) : txtCRemove.EditValue = CostPrices.CRemove
                        ' ΣΥΝΟΛΟ ΓΕΝΙΚΩΝ ΣΤΟΙΧΕΙΩΝ
                        CostPrices.CStandarTotal = CostPrices.CTransp + CostPrices.CPartofVat + CostPrices.CMeasurement + CostPrices.CRemove
                        txtCTotalStandar.EditValue = CostPrices.CStandarTotal
                        CostPrices.GenTot = CostPrices.VTotal + CostPrices.KTotal + CostPrices.YTotal + CostPrices.VEpendisisTotal + CostPrices.KEpendisisTotal + CostPrices.YEpendisisTotal + CostPrices.BenchBackTotal + CostPrices.TotKEquipment +
                                               CostPrices.CErmariaTotal + CostPrices.TotCEquipment + CostPrices.DTotal + CostPrices.SCTotal + CostPrices.KStandarTotal + CostPrices.CStandarTotal + CostPrices.DStandarTotal + CostPrices.SCStandarTotal

                        txtGenTot.EditValue = CostPrices.GenTot
                    Case 6 'ΓΕΝΙΚΑ ΣΤΟΙΧΕΙΑ - ΠΟΡΤΑ
                        ' ΜΕΤΑΦΟΡΑ
                        CostPrices.DTransp = sdr.GetDecimal(sdr.GetOrdinal("DTransp")) : txtDtransport.EditValue = CostPrices.DTransp
                        ' ΣΥΜΦΩΝΗΘΕΝ ΦΠΑ
                        CostPrices.DPartofVat = sdr.GetDecimal(sdr.GetOrdinal("DPartOfVat")) : txtDPartOfVat.EditValue = CostPrices.DPartofVat
                        ' ΕΠΙΜΕΤΡΗΣΗ
                        CostPrices.DMeasurement = sdr.GetDecimal(sdr.GetOrdinal("DMeasurement")) : txtDmeasurement.EditValue = CostPrices.DMeasurement
                        ' ΑΠΟΞΥΛΩΣΗ
                        CostPrices.DRemove = sdr.GetDecimal(sdr.GetOrdinal("DRemove")) : txtDRemove.EditValue = CostPrices.DRemove
                        ' ΣΥΝΟΛΟ ΓΕΝΙΚΩΝ ΣΤΟΙΧΕΙΩΝ
                        CostPrices.DStandarTotal = CostPrices.DTransp + CostPrices.DPartofVat + CostPrices.DMeasurement + CostPrices.DRemove
                        txtDTotal.EditValue = CostPrices.DStandarTotal
                        CostPrices.GenTot = CostPrices.VTotal + CostPrices.KTotal + CostPrices.YTotal + CostPrices.VEpendisisTotal + CostPrices.KEpendisisTotal + CostPrices.YEpendisisTotal + CostPrices.BenchBackTotal + CostPrices.TotKEquipment +
                                               CostPrices.CErmariaTotal + CostPrices.TotCEquipment + CostPrices.DTotal + CostPrices.SCTotal + CostPrices.KStandarTotal + CostPrices.CStandarTotal + CostPrices.DStandarTotal + CostPrices.SCStandarTotal

                    Case 7 'ΓΕΝΙΚΑ ΣΤΟΙΧΕΙΑ - ΕΙΔ. ΚΑΤΑΣΚΕΥΗ
                        ' ΜΕΤΑΦΟΡΑ
                        CostPrices.SCTransp = sdr.GetDecimal(sdr.GetOrdinal("SCTransp")) : txtSCtransport.EditValue = CostPrices.SCTransp
                        ' ΣΥΜΦΩΝΗΘΕΝ ΦΠΑ
                        CostPrices.SCPartofVat = sdr.GetDecimal(sdr.GetOrdinal("SCPartofVat")) : txtSCPartOfVat.EditValue = CostPrices.SCPartofVat
                        ' ΕΠΙΜΕΤΡΗΣΗ
                        CostPrices.SCMeasurement = sdr.GetDecimal(sdr.GetOrdinal("SCMeasurement")) : txtSCmeasurement.EditValue = CostPrices.SCMeasurement
                        ' ΑΠΟΞΥΛΩΣΗ
                        CostPrices.SCRemove = sdr.GetDecimal(sdr.GetOrdinal("SCRemove")) : txtSCRemove.EditValue = CostPrices.SCRemove
                        ' ΣΥΝΟΛΟ ΓΕΝΙΚΩΝ ΣΤΟΙΧΕΙΩΝ
                        CostPrices.SCStandarTotal = CostPrices.SCTransp + CostPrices.SCPartofVat + CostPrices.SCMeasurement + CostPrices.SCRemove
                        txtDTotal.EditValue = CostPrices.SCStandarTotal
                        CostPrices.GenTot = CostPrices.VTotal + CostPrices.KTotal + CostPrices.YTotal + CostPrices.VEpendisisTotal + CostPrices.KEpendisisTotal + CostPrices.YEpendisisTotal + CostPrices.BenchBackTotal + CostPrices.TotKEquipment +
                                             CostPrices.CErmariaTotal + CostPrices.TotCEquipment + CostPrices.DTotal + CostPrices.SCTotal + CostPrices.KStandarTotal + CostPrices.CStandarTotal + CostPrices.DStandarTotal + CostPrices.SCStandarTotal

                End Select


            End If
            sdr.Close()

        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), "Dreamy Kitchen CRM", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub LoadDoorType(ByVal lkupEditColor As LookUpEdit, ByVal lkupEditDoorType As LookUpEdit, Optional ByVal cboClosetTypes As ComboBoxEdit = Nothing)
        '      If Me.IsActive = False Then Exit Sub
        If lkupEditColor.EditValue = Nothing Then Exit Sub
        Dim sSQL = New System.Text.StringBuilder
        sSQL.AppendLine("Select id,name,price from vw_DOOR_TYPE where  doorCatID = 'CF691845-D6CC-4181-9760-6D15934C40B4' and doorColorID = " & toSQLValueS(lkupEditColor.EditValue.ToString))
        If cboClosetTypes IsNot Nothing Then sSQL.AppendLine(" and closetType = " & cboClosetTypes.SelectedIndex)
        FillCbo.DOOR_TYPE(lkupEditDoorType, sSQL)
    End Sub
    Private Sub LoadDoorTypeDoor(ByVal cboEdit As ComboBoxEdit, ByVal cboKasa As ComboBoxEdit, ByVal lkupEditDoorType As LookUpEdit)
        'If Me.IsActive = False Then Exit Sub
        If cboEdit.SelectedIndex = -1 Or cboKasa.EditValue = -1 Then Exit Sub
        Dim sSQL = New System.Text.StringBuilder
        sSQL.AppendLine("Select id,name,price from vw_DOOR_TYPE where doorCatID='E6733593-7DA0-4180-8951-B09315E1F13D' and doorType = " & cboEdit.SelectedIndex & " and kasa = " & cboKasa.SelectedIndex)
        FillCbo.DOOR_TYPE(lkupEditDoorType, sSQL)
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
        CostPrices.Vtrm1 = Vtrm1.EditValue
        CostPrices.VFinalPrice1 = CostPrices.Vtrm1 * CostPrices.VDoorPrice1
        txtvPrice1.EditValue = CostPrices.VFinalPrice1
    End Sub

    Private Sub Vtrm2_EditValueChanged(sender As Object, e As EventArgs) Handles Vtrm2.EditValueChanged
        CostPrices.Vtrm2 = Vtrm2.EditValue
        CostPrices.VFinalPrice2 = CostPrices.Vtrm2 * CostPrices.VDoorPrice2
        txtvPrice2.EditValue = CostPrices.VFinalPrice2
    End Sub

    Private Sub txtvPrice1_EditValueChanged(sender As Object, e As EventArgs) Handles txtvPrice1.EditValueChanged
        CostPrices.VTotal = CostPrices.VFinalPrice1 + CostPrices.VFinalPrice2
        txtErmTotal.EditValue = CostPrices.VTotal + CostPrices.KTotal + CostPrices.YTotal
    End Sub

    Private Sub txtvPrice2_EditValueChanged(sender As Object, e As EventArgs) Handles txtvPrice2.EditValueChanged
        CostPrices.VTotal = CostPrices.VFinalPrice1 + CostPrices.VFinalPrice2
        txtErmTotal.EditValue = CostPrices.VTotal + CostPrices.KTotal + CostPrices.YTotal
    End Sub
    Private Sub txtKPrice1_EditValueChanged(sender As Object, e As EventArgs) Handles txtKPrice1.EditValueChanged
        CostPrices.KTotal = CostPrices.KFinalPrice1 + CostPrices.KFinalPrice2
        txtErmTotal.EditValue = CostPrices.VTotal + CostPrices.KTotal + CostPrices.YTotal
    End Sub

    Private Sub txtKPrice2_EditValueChanged(sender As Object, e As EventArgs) Handles txtKPrice2.EditValueChanged
        CostPrices.KTotal = CostPrices.KFinalPrice1 + CostPrices.KFinalPrice2
        txtErmTotal.EditValue = CostPrices.VTotal + CostPrices.KTotal + CostPrices.YTotal
    End Sub

    Private Sub txtYDoorPrice1_EditValueChanged(sender As Object, e As EventArgs) Handles txtYDoorPrice1.EditValueChanged
        CostPrices.YTotal = CostPrices.YFinalPrice1 + CostPrices.YFinalPrice2
        txtErmTotal.EditValue = CostPrices.VTotal + CostPrices.KTotal + CostPrices.YTotal
    End Sub

    Private Sub txtYDoorPrice2_EditValueChanged(sender As Object, e As EventArgs) Handles txtYDoorPrice2.EditValueChanged
        CostPrices.YTotal = CostPrices.YFinalPrice1 + CostPrices.YFinalPrice2
        txtErmTotal.EditValue = CostPrices.VTotal + CostPrices.KTotal + CostPrices.YTotal
    End Sub

    Private Sub txtErmTotal_EditValueChanged(sender As Object, e As EventArgs) Handles txtErmTotal.EditValueChanged
        CostPrices.GenTot = CostPrices.VTotal + CostPrices.KTotal + CostPrices.YTotal + CostPrices.VEpendisisTotal + CostPrices.KEpendisisTotal + CostPrices.YEpendisisTotal + CostPrices.BenchBackTotal + CostPrices.TotKEquipment +
                            CostPrices.CErmariaTotal + CostPrices.TotCEquipment + CostPrices.DTotal + CostPrices.KStandarTotal + CostPrices.CStandarTotal + CostPrices.DStandarTotal + CostPrices.SCStandarTotal

        txtGenTot.EditValue = CostPrices.GenTot
    End Sub
    Private Sub Ktrm1_EditValueChanged(sender As Object, e As EventArgs) Handles Ktrm1.EditValueChanged
        CostPrices.Ktrm1 = Ktrm1.EditValue
        CostPrices.KFinalPrice1 = CostPrices.Ktrm1 * CostPrices.KDoorPrice1
        txtKPrice1.EditValue = CostPrices.KFinalPrice1
    End Sub
    Private Sub Ktrm2_EditValueChanged(sender As Object, e As EventArgs) Handles Ktrm2.EditValueChanged
        CostPrices.Ktrm2 = Ktrm2.EditValue
        CostPrices.KFinalPrice2 = CostPrices.Ktrm2 * CostPrices.KDoorPrice2
        txtKPrice2.EditValue = CostPrices.KFinalPrice2
    End Sub

    Private Sub Ytrm1_EditValueChanged(sender As Object, e As EventArgs) Handles Ytrm1.EditValueChanged
        CostPrices.Ytrm1 = Ytrm1.EditValue
        CostPrices.YFinalPrice1 = CostPrices.Ytrm1 * CostPrices.YDoorPrice1
        txtYPrice1.EditValue = CostPrices.YFinalPrice1
    End Sub

    Private Sub Ytrm2_EditValueChanged(sender As Object, e As EventArgs) Handles Ytrm2.EditValueChanged
        CostPrices.Ytrm2 = Ytrm2.EditValue
        CostPrices.YFinalPrice2 = CostPrices.Ytrm2 * CostPrices.YDoorPrice2
        txtYPrice2.EditValue = CostPrices.YFinalPrice2
    End Sub

    Private Sub txtYPrice1_EditValueChanged(sender As Object, e As EventArgs) Handles txtYPrice1.EditValueChanged
        CostPrices.YTotal = CostPrices.YFinalPrice1 + CostPrices.YFinalPrice2
        txtErmTotal.EditValue = CostPrices.VTotal + CostPrices.KTotal + CostPrices.YTotal

    End Sub

    Private Sub txtYPrice2_EditValueChanged(sender As Object, e As EventArgs) Handles txtYPrice2.EditValueChanged
        CostPrices.YTotal = CostPrices.YFinalPrice1 + CostPrices.YFinalPrice2
        txtErmTotal.EditValue = CostPrices.VTotal + CostPrices.KTotal + CostPrices.YTotal
    End Sub


    Private Sub VEpendTrm_EditValueChanged(sender As Object, e As EventArgs) Handles VEpendTrm.EditValueChanged
        CostPrices.VEpendTrm = VEpendTrm.EditValue
        CostPrices.VependisisFinalPrice = CostPrices.VEpendTrm * CostPrices.VependisisPrice
        txtVEpendPrice.EditValue = CostPrices.VependisisFinalPrice
    End Sub

    Private Sub NEpendTrm_EditValueChanged(sender As Object, e As EventArgs) Handles NEpendTrm.EditValueChanged
        CostPrices.NEpendTrm = NEpendTrm.EditValue
        CostPrices.NependisisFinalPrice = CostPrices.NEpendTrm * CostPrices.NependisisPrice
        txtNEpendPrice.EditValue = CostPrices.NependisisFinalPrice
    End Sub
    Private Sub VRafTem_EditValueChanged(sender As Object, e As EventArgs) Handles VRafTem.EditValueChanged
        CostPrices.VRafTem = VRafTem.EditValue
        CostPrices.VRafieraFinalPrice = CostPrices.VRafTem * CostPrices.VRafieraPrice
        txtVTotRafPrice.EditValue = CostPrices.VRafieraFinalPrice
    End Sub

    Private Sub KEpendTrm_EditValueChanged(sender As Object, e As EventArgs) Handles KEpendTrm.EditValueChanged
        CostPrices.KEpendTrm = KEpendTrm.EditValue
        CostPrices.KependisisFinalPrice = CostPrices.KEpendTrm * CostPrices.KependisisPrice
        txtKEpendPrice.EditValue = CostPrices.KependisisFinalPrice
    End Sub

    Private Sub SEpendTrm_EditValueChanged(sender As Object, e As EventArgs) Handles SEpendTrm.EditValueChanged
        CostPrices.SEpendTrm = SEpendTrm.EditValue
        CostPrices.SependisisFinalPrice = CostPrices.SEpendTrm * CostPrices.SependisisPrice
        txtSEpendPrice.EditValue = CostPrices.SependisisFinalPrice
    End Sub

    Private Sub KRafTem_EditValueChanged(sender As Object, e As EventArgs) Handles KRafTem.EditValueChanged
        CostPrices.KRafTem = KRafTem.EditValue
        CostPrices.KRafieraFinalPrice = CostPrices.KRafTem * CostPrices.KRafieraPrice
        txtKTotRafPrice.EditValue = CostPrices.KRafieraFinalPrice
    End Sub

    Private Sub YEpendTrm_EditValueChanged(sender As Object, e As EventArgs) Handles YEpendTrm.EditValueChanged
        CostPrices.YEpendTrm = YEpendTrm.EditValue
        CostPrices.YependisisFinalPrice = CostPrices.YEpendTrm * CostPrices.YependisisPrice
        txtYEpendPrice.EditValue = CostPrices.YependisisFinalPrice
    End Sub

    Private Sub YRafTem_EditValueChanged(sender As Object, e As EventArgs) Handles YRafTem.EditValueChanged
        CostPrices.YRafTem = YRafTem.EditValue
        CostPrices.YRafieraFinalPrice = CostPrices.YRafTem * CostPrices.YRafieraPrice
        txtYTotRafPrice.EditValue = CostPrices.YRafieraFinalPrice
    End Sub

    Private Sub txtVEpendPrice_EditValueChanged(sender As Object, e As EventArgs) Handles txtVEpendPrice.EditValueChanged
        CostPrices.VEpendisisTotal = CostPrices.VependisisFinalPrice + CostPrices.NependisisFinalPrice + CostPrices.VRafieraFinalPrice
        txtEpendTotal.EditValue = CostPrices.VEpendisisTotal + CostPrices.KEpendisisTotal + CostPrices.YEpendisisTotal
    End Sub

    Private Sub txtNEpendPrice_EditValueChanged(sender As Object, e As EventArgs) Handles txtNEpendPrice.EditValueChanged
        CostPrices.VEpendisisTotal = CostPrices.VependisisFinalPrice + CostPrices.NependisisFinalPrice + CostPrices.VRafieraFinalPrice
        txtEpendTotal.EditValue = CostPrices.VEpendisisTotal + CostPrices.KEpendisisTotal + CostPrices.YEpendisisTotal
    End Sub

    Private Sub txtVTotRafPrice_EditValueChanged(sender As Object, e As EventArgs) Handles txtVTotRafPrice.EditValueChanged
        CostPrices.VEpendisisTotal = CostPrices.VependisisFinalPrice + CostPrices.NependisisFinalPrice + CostPrices.VRafieraFinalPrice
        txtEpendTotal.EditValue = CostPrices.VEpendisisTotal + CostPrices.KEpendisisTotal + CostPrices.YEpendisisTotal
    End Sub

    Private Sub txtKEpendPrice_EditValueChanged(sender As Object, e As EventArgs) Handles txtKEpendPrice.EditValueChanged
        CostPrices.KEpendisisTotal = CostPrices.KependisisFinalPrice + CostPrices.SependisisFinalPrice + CostPrices.KRafieraFinalPrice
        txtEpendTotal.EditValue = CostPrices.VEpendisisTotal + CostPrices.KEpendisisTotal + CostPrices.YEpendisisTotal
    End Sub

    Private Sub txtSEpendPrice_EditValueChanged(sender As Object, e As EventArgs) Handles txtSEpendPrice.EditValueChanged
        CostPrices.KEpendisisTotal = CostPrices.KependisisFinalPrice + CostPrices.SependisisFinalPrice + CostPrices.KRafieraFinalPrice
        txtEpendTotal.EditValue = CostPrices.VEpendisisTotal + CostPrices.KEpendisisTotal + CostPrices.YEpendisisTotal
    End Sub

    Private Sub txtKTotRafPrice_EditValueChanged(sender As Object, e As EventArgs) Handles txtKTotRafPrice.EditValueChanged
        CostPrices.KEpendisisTotal = CostPrices.KependisisFinalPrice + CostPrices.SependisisFinalPrice + CostPrices.KRafieraFinalPrice
        txtEpendTotal.EditValue = CostPrices.VEpendisisTotal + CostPrices.KEpendisisTotal + CostPrices.YEpendisisTotal
    End Sub

    Private Sub txtYEpendPrice_EditValueChanged(sender As Object, e As EventArgs) Handles txtYEpendPrice.EditValueChanged
        CostPrices.YEpendisisTotal = CostPrices.YependisisFinalPrice + CostPrices.YRafieraFinalPrice
        txtEpendTotal.EditValue = CostPrices.VEpendisisTotal + CostPrices.KEpendisisTotal + CostPrices.YEpendisisTotal

    End Sub

    Private Sub txtYTotRafPrice_EditValueChanged(sender As Object, e As EventArgs) Handles txtYTotRafPrice.EditValueChanged
        CostPrices.YEpendisisTotal = CostPrices.YependisisFinalPrice + CostPrices.YRafieraFinalPrice
        txtEpendTotal.EditValue = CostPrices.VEpendisisTotal + CostPrices.KEpendisisTotal + CostPrices.YEpendisisTotal
    End Sub

    Private Sub txtEpendTotal_EditValueChanged(sender As Object, e As EventArgs) Handles txtEpendTotal.EditValueChanged
        CostPrices.GenTot = CostPrices.VTotal + CostPrices.KTotal + CostPrices.YTotal + CostPrices.VEpendisisTotal + CostPrices.KEpendisisTotal + CostPrices.YEpendisisTotal + CostPrices.BenchBackTotal + CostPrices.TotKEquipment +
                            CostPrices.CErmariaTotal + CostPrices.TotCEquipment + CostPrices.DTotal + CostPrices.SCTotal + CostPrices.KStandarTotal + CostPrices.CStandarTotal + CostPrices.DStandarTotal + CostPrices.SCStandarTotal

        txtGenTot.EditValue = CostPrices.GenTot
    End Sub

    Private Sub BenchTem1_EditValueChanged(sender As Object, e As EventArgs) Handles BenchTem1.EditValueChanged
        CostPrices.BenchTem1 = BenchTem1.EditValue
        CostPrices.BenchFinalPrice1 = CostPrices.BenchTem1 * CostPrices.BenchPrice1
        txtBenchPrice1.EditValue = CostPrices.BenchFinalPrice1
    End Sub

    Private Sub BenchTem2_EditValueChanged(sender As Object, e As EventArgs) Handles BenchTem2.EditValueChanged
        CostPrices.BenchTem2 = BenchTem2.EditValue
        CostPrices.BenchFinalPrice2 = CostPrices.BenchTem2 * CostPrices.BenchPrice2
        txtBenchPrice2.EditValue = CostPrices.BenchFinalPrice2
    End Sub

    Private Sub txtBenchTotal_EditValueChanged(sender As Object, e As EventArgs) Handles txtBenchTotal.EditValueChanged
        CostPrices.GenTot = CostPrices.VTotal + CostPrices.KTotal + CostPrices.YTotal + CostPrices.VEpendisisTotal + CostPrices.KEpendisisTotal + CostPrices.YEpendisisTotal + CostPrices.BenchBackTotal + CostPrices.TotKEquipment +
                            CostPrices.CErmariaTotal + CostPrices.TotCEquipment + CostPrices.DTotal + CostPrices.SCTotal + CostPrices.KStandarTotal + CostPrices.CStandarTotal + CostPrices.SCStandarTotal

        txtGenTot.EditValue = CostPrices.GenTot
    End Sub

    Private Sub txtBenchPrice1_EditValueChanged(sender As Object, e As EventArgs) Handles txtBenchPrice1.EditValueChanged
        CostPrices.BenchBackTotal = CostPrices.BenchFinalPrice1 + CostPrices.BenchFinalPrice2
        txtBenchTotal.EditValue = CostPrices.BenchBackTotal
    End Sub

    Private Sub txtBenchPrice2_EditValueChanged(sender As Object, e As EventArgs) Handles txtBenchPrice2.EditValueChanged
        CostPrices.BenchBackTotal = CostPrices.BenchFinalPrice1 + CostPrices.BenchFinalPrice2
        txtBenchTotal.EditValue = CostPrices.BenchBackTotal

    End Sub

    Private Sub BackTem_EditValueChanged(sender As Object, e As EventArgs) Handles BackTem.EditValueChanged
        CostPrices.BackTem = BackTem.EditValue
        CostPrices.BackFinalPrice = CostPrices.BackTem * CostPrices.BackPrice
        txtBackPrice.EditValue = CostPrices.BackFinalPrice
    End Sub

    Private Sub txtBackPrice_EditValueChanged(sender As Object, e As EventArgs) Handles txtBackPrice.EditValueChanged
        CostPrices.BenchBackTotal = CostPrices.BenchFinalPrice1 + CostPrices.BenchFinalPrice2 + CostPrices.BackFinalPrice
        txtBenchTotal.EditValue = CostPrices.BenchBackTotal
    End Sub

    Private Sub GridView2_PopupMenuShowing(sender As Object, e As PopupMenuShowingEventArgs) Handles GridView2.PopupMenuShowing
        If e.MenuType = GridMenuType.Column Then LoadForms.PopupMenuShow(e, GridView2, "CCT_ORDERS_KITCHEN_EQUIPMENT_COST_def.xml", "vw_CCT_ORDERS_KITCHEN_EQUIPMENT")
    End Sub

    Private Sub GridView2_CustomDrawFooterCell(sender As Object, e As FooterCellCustomDrawEventArgs) Handles GridView2.CustomDrawFooterCell
        CostPrices.TotKEquipment = GridView2.Columns("Total").SummaryItem.SummaryValue
        txtGenTot.EditValue = CostPrices.GenTot + CostPrices.TotKEquipment
    End Sub


    Private Sub Ctm1_EditValueChanged(sender As Object, e As EventArgs) Handles Ctm1.EditValueChanged
        CostPrices.CTm1 = Ctm1.EditValue
        CostPrices.ModelFinalPrice1 = CostPrices.CTm1 * CostPrices.ModelPrice1
        txtCPrice1.EditValue = CostPrices.ModelFinalPrice1
    End Sub
    Private Sub Ctm2_EditValueChanged(sender As Object, e As EventArgs) Handles Ctm2.EditValueChanged
        CostPrices.CTm2 = Ctm2.EditValue
        CostPrices.ModelFinalPrice2 = CostPrices.CTm2 * CostPrices.ModelPrice2
        txtCPrice2.EditValue = CostPrices.ModelFinalPrice2
    End Sub

    Private Sub Ctm3_EditValueChanged(sender As Object, e As EventArgs) Handles Ctm3.EditValueChanged
        CostPrices.CTm3 = Ctm3.EditValue
        CostPrices.ModelFinalPrice3 = CostPrices.CTm3 * CostPrices.ModelPrice3
        txtCPrice3.EditValue = CostPrices.ModelFinalPrice3
    End Sub

    Private Sub Ctm4_EditValueChanged(sender As Object, e As EventArgs) Handles Ctm4.EditValueChanged
        CostPrices.CTm4 = Ctm4.EditValue
        CostPrices.ModelFinalPrice4 = CostPrices.CTm4 * CostPrices.ModelPrice4
        txtCPrice4.EditValue = CostPrices.ModelFinalPrice4
    End Sub

    Private Sub Ctm5_EditValueChanged(sender As Object, e As EventArgs) Handles Ctm5.EditValueChanged
        CostPrices.CTm5 = Ctm5.EditValue
        CostPrices.ModelFinalPrice5 = CostPrices.CTm5 * CostPrices.ModelPrice5
        txtCPrice5.EditValue = CostPrices.ModelFinalPrice5
    End Sub

    Private Sub Ctm6_EditValueChanged(sender As Object, e As EventArgs) Handles Ctm6.EditValueChanged
        CostPrices.CTm6 = Ctm6.EditValue
        CostPrices.ModelFinalPrice6 = CostPrices.CTm6 * CostPrices.ModelPrice6
        txtCPrice6.EditValue = CostPrices.ModelFinalPrice6
    End Sub

    Private Sub Ctm7_EditValueChanged(sender As Object, e As EventArgs) Handles Ctm7.EditValueChanged
        CostPrices.CTm7 = Ctm7.EditValue
        CostPrices.ModelFinalPrice7 = CostPrices.CTm7 * CostPrices.ModelPrice7
        txtCPrice7.EditValue = CostPrices.ModelFinalPrice7
    End Sub

    Private Sub Ctm8_EditValueChanged(sender As Object, e As EventArgs) Handles Ctm8.EditValueChanged
        CostPrices.CTm8 = Ctm8.EditValue
        CostPrices.ModelFinalPrice8 = CostPrices.CTm8 * CostPrices.ModelPrice8
        txtCPrice8.EditValue = CostPrices.ModelFinalPrice8
    End Sub

    Private Sub Ctm9_EditValueChanged(sender As Object, e As EventArgs) Handles Ctm9.EditValueChanged
        CostPrices.CTm9 = Ctm9.EditValue
        CostPrices.ModelFinalPrice9 = CostPrices.CTm9 * CostPrices.ModelPrice9
        txtCPrice9.EditValue = CostPrices.ModelFinalPrice9
    End Sub

    Private Sub Ctm10_EditValueChanged(sender As Object, e As EventArgs) Handles Ctm10.EditValueChanged
        CostPrices.CTm10 = Ctm10.EditValue
        CostPrices.ModelFinalPrice10 = CostPrices.CTm10 * CostPrices.ModelPrice10
        txtCPrice10.EditValue = CostPrices.ModelFinalPrice10
    End Sub

    Private Sub Ctm11_EditValueChanged(sender As Object, e As EventArgs) Handles Ctm11.EditValueChanged
        CostPrices.CTm11 = Ctm11.EditValue
        CostPrices.ModelFinalPrice11 = CostPrices.CTm11 * CostPrices.ModelPrice11
        txtCPrice11.EditValue = CostPrices.ModelFinalPrice11
    End Sub

    Private Sub Ctm12_EditValueChanged(sender As Object, e As EventArgs) Handles Ctm12.EditValueChanged
        CostPrices.CTm12 = Ctm12.EditValue
        CostPrices.ModelFinalPrice12 = CostPrices.CTm12 * CostPrices.ModelPrice12
        txtCPrice12.EditValue = CostPrices.ModelFinalPrice12
    End Sub

    Private Sub CTem1_EditValueChanged(sender As Object, e As EventArgs) Handles CTem1.EditValueChanged
        CostPrices.PTem1 = CTem1.EditValue
        CostPrices.PlainaFinalPrice1 = CostPrices.PTem1 * CostPrices.PlainaPrice1
        txtPPrice1.EditValue = CostPrices.PlainaFinalPrice1
    End Sub

    Private Sub CTem2_EditValueChanged(sender As Object, e As EventArgs) Handles CTem2.EditValueChanged
        CostPrices.PTem2 = CTem2.EditValue
        CostPrices.PlainaFinalPrice2 = CostPrices.PTem2 * CostPrices.PlainaPrice2
        txtPPrice2.EditValue = CostPrices.PlainaFinalPrice2
    End Sub

    Private Sub CTem3_EditValueChanged(sender As Object, e As EventArgs) Handles CTem3.EditValueChanged
        CostPrices.PTem3 = CTem3.EditValue
        CostPrices.PlainaFinalPrice3 = CostPrices.PTem3 * CostPrices.PlainaPrice3
        txtPPrice3.EditValue = CostPrices.PlainaFinalPrice3
    End Sub

    Private Sub CTem4_EditValueChanged(sender As Object, e As EventArgs) Handles CTem4.EditValueChanged
        CostPrices.PTem4 = CTem4.EditValue
        CostPrices.PlainaFinalPrice4 = CostPrices.PTem4 * CostPrices.PlainaPrice4
        txtPPrice4.EditValue = CostPrices.PlainaFinalPrice4
    End Sub

    Private Sub CTem5_EditValueChanged(sender As Object, e As EventArgs) Handles CTem5.EditValueChanged
        CostPrices.PTem5 = CTem5.EditValue
        CostPrices.PlainaFinalPrice5 = CostPrices.PTem5 * CostPrices.PlainaPrice5
        txtPPrice5.EditValue = CostPrices.PlainaFinalPrice5
    End Sub

    Private Sub CTem6_EditValueChanged(sender As Object, e As EventArgs) Handles CTem6.EditValueChanged
        CostPrices.PTem6 = CTem6.EditValue
        CostPrices.PlainaFinalPrice6 = CostPrices.PTem6 * CostPrices.PlainaPrice6
        txtPPrice6.EditValue = CostPrices.PlainaFinalPrice6
    End Sub

    Private Sub txtCPrice1_EditValueChanged(sender As Object, e As EventArgs) Handles txtCPrice1.EditValueChanged
        CostPrices.CErmariaTotal = CostPrices.ModelFinalPrice1 + CostPrices.ModelFinalPrice2 + CostPrices.ModelFinalPrice3 + CostPrices.ModelFinalPrice4 + CostPrices.ModelFinalPrice5 + CostPrices.ModelFinalPrice6 +
                            CostPrices.ModelFinalPrice7 + CostPrices.ModelFinalPrice8 + +CostPrices.ModelFinalPrice9 + CostPrices.ModelFinalPrice10 + CostPrices.ModelFinalPrice11 + CostPrices.ModelFinalPrice12 +
                            CostPrices.PlainaFinalPrice1 + CostPrices.PlainaFinalPrice2 + CostPrices.PlainaFinalPrice3 + CostPrices.PlainaFinalPrice4 + CostPrices.PlainaFinalPrice5 + CostPrices.PlainaFinalPrice6
        txtCErmTotal.EditValue = CostPrices.CErmariaTotal
    End Sub

    Private Sub txtCPrice2_EditValueChanged(sender As Object, e As EventArgs) Handles txtCPrice2.EditValueChanged
        CostPrices.CErmariaTotal = CostPrices.ModelFinalPrice1 + CostPrices.ModelFinalPrice2 + CostPrices.ModelFinalPrice3 + CostPrices.ModelFinalPrice4 + CostPrices.ModelFinalPrice5 + CostPrices.ModelFinalPrice6 +
                            CostPrices.ModelFinalPrice7 + CostPrices.ModelFinalPrice8 + +CostPrices.ModelFinalPrice9 + CostPrices.ModelFinalPrice10 + CostPrices.ModelFinalPrice11 + CostPrices.ModelFinalPrice12 +
                            CostPrices.PlainaFinalPrice1 + CostPrices.PlainaFinalPrice2 + CostPrices.PlainaFinalPrice3 + CostPrices.PlainaFinalPrice4 + CostPrices.PlainaFinalPrice5 + CostPrices.PlainaFinalPrice6
        txtCErmTotal.EditValue = CostPrices.CErmariaTotal
    End Sub

    Private Sub txtPPrice1_EditValueChanged(sender As Object, e As EventArgs) Handles txtPPrice1.EditValueChanged
        CostPrices.CErmariaTotal = CostPrices.ModelFinalPrice1 + CostPrices.ModelFinalPrice2 + CostPrices.ModelFinalPrice3 + CostPrices.ModelFinalPrice4 + CostPrices.ModelFinalPrice5 + CostPrices.ModelFinalPrice6 +
                            CostPrices.ModelFinalPrice7 + CostPrices.ModelFinalPrice8 + +CostPrices.ModelFinalPrice9 + CostPrices.ModelFinalPrice10 + CostPrices.ModelFinalPrice11 + CostPrices.ModelFinalPrice12 +
                            CostPrices.PlainaFinalPrice1 + CostPrices.PlainaFinalPrice2 + CostPrices.PlainaFinalPrice3 + CostPrices.PlainaFinalPrice4 + CostPrices.PlainaFinalPrice5 + CostPrices.PlainaFinalPrice6
        txtCErmTotal.EditValue = CostPrices.CErmariaTotal
    End Sub

    Private Sub txtCPrice3_EditValueChanged(sender As Object, e As EventArgs) Handles txtCPrice3.EditValueChanged
        CostPrices.CErmariaTotal = CostPrices.ModelFinalPrice1 + CostPrices.ModelFinalPrice2 + CostPrices.ModelFinalPrice3 + CostPrices.ModelFinalPrice4 + CostPrices.ModelFinalPrice5 + CostPrices.ModelFinalPrice6 +
                            CostPrices.ModelFinalPrice7 + CostPrices.ModelFinalPrice8 + +CostPrices.ModelFinalPrice9 + CostPrices.ModelFinalPrice10 + CostPrices.ModelFinalPrice11 + CostPrices.ModelFinalPrice12 +
                            CostPrices.PlainaFinalPrice1 + CostPrices.PlainaFinalPrice2 + CostPrices.PlainaFinalPrice3 + CostPrices.PlainaFinalPrice4 + CostPrices.PlainaFinalPrice5 + CostPrices.PlainaFinalPrice6
        txtCErmTotal.EditValue = CostPrices.CErmariaTotal
    End Sub

    Private Sub txtCPrice4_EditValueChanged(sender As Object, e As EventArgs) Handles txtCPrice4.EditValueChanged
        CostPrices.CErmariaTotal = CostPrices.ModelFinalPrice1 + CostPrices.ModelFinalPrice2 + CostPrices.ModelFinalPrice3 + CostPrices.ModelFinalPrice4 + CostPrices.ModelFinalPrice5 + CostPrices.ModelFinalPrice6 +
                            CostPrices.ModelFinalPrice7 + CostPrices.ModelFinalPrice8 + +CostPrices.ModelFinalPrice9 + CostPrices.ModelFinalPrice10 + CostPrices.ModelFinalPrice11 + CostPrices.ModelFinalPrice12 +
                            CostPrices.PlainaFinalPrice1 + CostPrices.PlainaFinalPrice2 + CostPrices.PlainaFinalPrice3 + CostPrices.PlainaFinalPrice4 + CostPrices.PlainaFinalPrice5 + CostPrices.PlainaFinalPrice6
        txtCErmTotal.EditValue = CostPrices.CErmariaTotal
    End Sub

    Private Sub txtPPrice2_EditValueChanged(sender As Object, e As EventArgs) Handles txtPPrice2.EditValueChanged
        CostPrices.CErmariaTotal = CostPrices.ModelFinalPrice1 + CostPrices.ModelFinalPrice2 + CostPrices.ModelFinalPrice3 + CostPrices.ModelFinalPrice4 + CostPrices.ModelFinalPrice5 + CostPrices.ModelFinalPrice6 +
                            CostPrices.ModelFinalPrice7 + CostPrices.ModelFinalPrice8 + +CostPrices.ModelFinalPrice9 + CostPrices.ModelFinalPrice10 + CostPrices.ModelFinalPrice11 + CostPrices.ModelFinalPrice12 +
                            CostPrices.PlainaFinalPrice1 + CostPrices.PlainaFinalPrice2 + CostPrices.PlainaFinalPrice3 + CostPrices.PlainaFinalPrice4 + CostPrices.PlainaFinalPrice5 + CostPrices.PlainaFinalPrice6
        txtCErmTotal.EditValue = CostPrices.CErmariaTotal
    End Sub

    Private Sub txtCPrice5_EditValueChanged(sender As Object, e As EventArgs) Handles txtCPrice5.EditValueChanged
        CostPrices.CErmariaTotal = CostPrices.ModelFinalPrice1 + CostPrices.ModelFinalPrice2 + CostPrices.ModelFinalPrice3 + CostPrices.ModelFinalPrice4 + CostPrices.ModelFinalPrice5 + CostPrices.ModelFinalPrice6 +
                            CostPrices.ModelFinalPrice7 + CostPrices.ModelFinalPrice8 + +CostPrices.ModelFinalPrice9 + CostPrices.ModelFinalPrice10 + CostPrices.ModelFinalPrice11 + CostPrices.ModelFinalPrice12 +
                            CostPrices.PlainaFinalPrice1 + CostPrices.PlainaFinalPrice2 + CostPrices.PlainaFinalPrice3 + CostPrices.PlainaFinalPrice4 + CostPrices.PlainaFinalPrice5 + CostPrices.PlainaFinalPrice6
        txtCErmTotal.EditValue = CostPrices.CErmariaTotal
    End Sub

    Private Sub txtCPrice6_EditValueChanged(sender As Object, e As EventArgs) Handles txtCPrice6.EditValueChanged
        CostPrices.CErmariaTotal = CostPrices.ModelFinalPrice1 + CostPrices.ModelFinalPrice2 + CostPrices.ModelFinalPrice3 + CostPrices.ModelFinalPrice4 + CostPrices.ModelFinalPrice5 + CostPrices.ModelFinalPrice6 +
                            CostPrices.ModelFinalPrice7 + CostPrices.ModelFinalPrice8 + +CostPrices.ModelFinalPrice9 + CostPrices.ModelFinalPrice10 + CostPrices.ModelFinalPrice11 + CostPrices.ModelFinalPrice12 +
                            CostPrices.PlainaFinalPrice1 + CostPrices.PlainaFinalPrice2 + CostPrices.PlainaFinalPrice3 + CostPrices.PlainaFinalPrice4 + CostPrices.PlainaFinalPrice5 + CostPrices.PlainaFinalPrice6
        txtCErmTotal.EditValue = CostPrices.CErmariaTotal
    End Sub

    Private Sub txtPPrice3_EditValueChanged(sender As Object, e As EventArgs) Handles txtPPrice3.EditValueChanged
        CostPrices.CErmariaTotal = CostPrices.ModelFinalPrice1 + CostPrices.ModelFinalPrice2 + CostPrices.ModelFinalPrice3 + CostPrices.ModelFinalPrice4 + CostPrices.ModelFinalPrice5 + CostPrices.ModelFinalPrice6 +
                            CostPrices.ModelFinalPrice7 + CostPrices.ModelFinalPrice8 + +CostPrices.ModelFinalPrice9 + CostPrices.ModelFinalPrice10 + CostPrices.ModelFinalPrice11 + CostPrices.ModelFinalPrice12 +
                            CostPrices.PlainaFinalPrice1 + CostPrices.PlainaFinalPrice2 + CostPrices.PlainaFinalPrice3 + CostPrices.PlainaFinalPrice4 + CostPrices.PlainaFinalPrice5 + CostPrices.PlainaFinalPrice6
        txtCErmTotal.EditValue = CostPrices.CErmariaTotal
    End Sub

    Private Sub txtCPrice7_EditValueChanged(sender As Object, e As EventArgs) Handles txtCPrice7.EditValueChanged
        CostPrices.CErmariaTotal = CostPrices.ModelFinalPrice1 + CostPrices.ModelFinalPrice2 + CostPrices.ModelFinalPrice3 + CostPrices.ModelFinalPrice4 + CostPrices.ModelFinalPrice5 + CostPrices.ModelFinalPrice6 +
                            CostPrices.ModelFinalPrice7 + CostPrices.ModelFinalPrice8 + +CostPrices.ModelFinalPrice9 + CostPrices.ModelFinalPrice10 + CostPrices.ModelFinalPrice11 + CostPrices.ModelFinalPrice12 +
                            CostPrices.PlainaFinalPrice1 + CostPrices.PlainaFinalPrice2 + CostPrices.PlainaFinalPrice3 + CostPrices.PlainaFinalPrice4 + CostPrices.PlainaFinalPrice5 + CostPrices.PlainaFinalPrice6
        txtCErmTotal.EditValue = CostPrices.CErmariaTotal
    End Sub

    Private Sub txtCPrice8_EditValueChanged(sender As Object, e As EventArgs) Handles txtCPrice8.EditValueChanged
        CostPrices.CErmariaTotal = CostPrices.ModelFinalPrice1 + CostPrices.ModelFinalPrice2 + CostPrices.ModelFinalPrice3 + CostPrices.ModelFinalPrice4 + CostPrices.ModelFinalPrice5 + CostPrices.ModelFinalPrice6 +
                            CostPrices.ModelFinalPrice7 + CostPrices.ModelFinalPrice8 + +CostPrices.ModelFinalPrice9 + CostPrices.ModelFinalPrice10 + CostPrices.ModelFinalPrice11 + CostPrices.ModelFinalPrice12 +
                            CostPrices.PlainaFinalPrice1 + CostPrices.PlainaFinalPrice2 + CostPrices.PlainaFinalPrice3 + CostPrices.PlainaFinalPrice4 + CostPrices.PlainaFinalPrice5 + CostPrices.PlainaFinalPrice6
        txtCErmTotal.EditValue = CostPrices.CErmariaTotal
    End Sub

    Private Sub txtPPrice4_EditValueChanged(sender As Object, e As EventArgs) Handles txtPPrice4.EditValueChanged
        CostPrices.CErmariaTotal = CostPrices.ModelFinalPrice1 + CostPrices.ModelFinalPrice2 + CostPrices.ModelFinalPrice3 + CostPrices.ModelFinalPrice4 + CostPrices.ModelFinalPrice5 + CostPrices.ModelFinalPrice6 +
                            CostPrices.ModelFinalPrice7 + CostPrices.ModelFinalPrice8 + +CostPrices.ModelFinalPrice9 + CostPrices.ModelFinalPrice10 + CostPrices.ModelFinalPrice11 + CostPrices.ModelFinalPrice12 +
                            CostPrices.PlainaFinalPrice1 + CostPrices.PlainaFinalPrice2 + CostPrices.PlainaFinalPrice3 + CostPrices.PlainaFinalPrice4 + CostPrices.PlainaFinalPrice5 + CostPrices.PlainaFinalPrice6
        txtCErmTotal.EditValue = CostPrices.CErmariaTotal
    End Sub

    Private Sub txtCPrice9_EditValueChanged(sender As Object, e As EventArgs) Handles txtCPrice9.EditValueChanged
        CostPrices.CErmariaTotal = CostPrices.ModelFinalPrice1 + CostPrices.ModelFinalPrice2 + CostPrices.ModelFinalPrice3 + CostPrices.ModelFinalPrice4 + CostPrices.ModelFinalPrice5 + CostPrices.ModelFinalPrice6 +
                            CostPrices.ModelFinalPrice7 + CostPrices.ModelFinalPrice8 + +CostPrices.ModelFinalPrice9 + CostPrices.ModelFinalPrice10 + CostPrices.ModelFinalPrice11 + CostPrices.ModelFinalPrice12 +
                            CostPrices.PlainaFinalPrice1 + CostPrices.PlainaFinalPrice2 + CostPrices.PlainaFinalPrice3 + CostPrices.PlainaFinalPrice4 + CostPrices.PlainaFinalPrice5 + CostPrices.PlainaFinalPrice6
        txtCErmTotal.EditValue = CostPrices.CErmariaTotal
    End Sub

    Private Sub txtCPrice10_EditValueChanged(sender As Object, e As EventArgs) Handles txtCPrice10.EditValueChanged
        CostPrices.CErmariaTotal = CostPrices.ModelFinalPrice1 + CostPrices.ModelFinalPrice2 + CostPrices.ModelFinalPrice3 + CostPrices.ModelFinalPrice4 + CostPrices.ModelFinalPrice5 + CostPrices.ModelFinalPrice6 +
                            CostPrices.ModelFinalPrice7 + CostPrices.ModelFinalPrice8 + +CostPrices.ModelFinalPrice9 + CostPrices.ModelFinalPrice10 + CostPrices.ModelFinalPrice11 + CostPrices.ModelFinalPrice12 +
                            CostPrices.PlainaFinalPrice1 + CostPrices.PlainaFinalPrice2 + CostPrices.PlainaFinalPrice3 + CostPrices.PlainaFinalPrice4 + CostPrices.PlainaFinalPrice5 + CostPrices.PlainaFinalPrice6
        txtCErmTotal.EditValue = CostPrices.CErmariaTotal
    End Sub

    Private Sub txtPPrice5_EditValueChanged(sender As Object, e As EventArgs) Handles txtPPrice5.EditValueChanged
        CostPrices.CErmariaTotal = CostPrices.ModelFinalPrice1 + CostPrices.ModelFinalPrice2 + CostPrices.ModelFinalPrice3 + CostPrices.ModelFinalPrice4 + CostPrices.ModelFinalPrice5 + CostPrices.ModelFinalPrice6 +
                            CostPrices.ModelFinalPrice7 + CostPrices.ModelFinalPrice8 + +CostPrices.ModelFinalPrice9 + CostPrices.ModelFinalPrice10 + CostPrices.ModelFinalPrice11 + CostPrices.ModelFinalPrice12 +
                            CostPrices.PlainaFinalPrice1 + CostPrices.PlainaFinalPrice2 + CostPrices.PlainaFinalPrice3 + CostPrices.PlainaFinalPrice4 + CostPrices.PlainaFinalPrice5 + CostPrices.PlainaFinalPrice6
        txtCErmTotal.EditValue = CostPrices.CErmariaTotal
    End Sub

    Private Sub txtCPrice11_EditValueChanged(sender As Object, e As EventArgs) Handles txtCPrice11.EditValueChanged
        CostPrices.CErmariaTotal = CostPrices.ModelFinalPrice1 + CostPrices.ModelFinalPrice2 + CostPrices.ModelFinalPrice3 + CostPrices.ModelFinalPrice4 + CostPrices.ModelFinalPrice5 + CostPrices.ModelFinalPrice6 +
                            CostPrices.ModelFinalPrice7 + CostPrices.ModelFinalPrice8 + +CostPrices.ModelFinalPrice9 + CostPrices.ModelFinalPrice10 + CostPrices.ModelFinalPrice11 + CostPrices.ModelFinalPrice12 +
                            CostPrices.PlainaFinalPrice1 + CostPrices.PlainaFinalPrice2 + CostPrices.PlainaFinalPrice3 + CostPrices.PlainaFinalPrice4 + CostPrices.PlainaFinalPrice5 + CostPrices.PlainaFinalPrice6
        txtCErmTotal.EditValue = CostPrices.CErmariaTotal
    End Sub

    Private Sub txtCPrice12_EditValueChanged(sender As Object, e As EventArgs) Handles txtCPrice12.EditValueChanged
        CostPrices.CErmariaTotal = CostPrices.ModelFinalPrice1 + CostPrices.ModelFinalPrice2 + CostPrices.ModelFinalPrice3 + CostPrices.ModelFinalPrice4 + CostPrices.ModelFinalPrice5 + CostPrices.ModelFinalPrice6 +
                            CostPrices.ModelFinalPrice7 + CostPrices.ModelFinalPrice8 + +CostPrices.ModelFinalPrice9 + CostPrices.ModelFinalPrice10 + CostPrices.ModelFinalPrice11 + CostPrices.ModelFinalPrice12 +
                            CostPrices.PlainaFinalPrice1 + CostPrices.PlainaFinalPrice2 + CostPrices.PlainaFinalPrice3 + CostPrices.PlainaFinalPrice4 + CostPrices.PlainaFinalPrice5 + CostPrices.PlainaFinalPrice6
        txtCErmTotal.EditValue = CostPrices.CErmariaTotal
    End Sub

    Private Sub txtPPrice6_EditValueChanged(sender As Object, e As EventArgs) Handles txtPPrice6.EditValueChanged
        CostPrices.CErmariaTotal = CostPrices.ModelFinalPrice1 + CostPrices.ModelFinalPrice2 + CostPrices.ModelFinalPrice3 + CostPrices.ModelFinalPrice4 + CostPrices.ModelFinalPrice5 + CostPrices.ModelFinalPrice6 +
                            CostPrices.ModelFinalPrice7 + CostPrices.ModelFinalPrice8 + +CostPrices.ModelFinalPrice9 + CostPrices.ModelFinalPrice10 + CostPrices.ModelFinalPrice11 + CostPrices.ModelFinalPrice12 +
                            CostPrices.PlainaFinalPrice1 + CostPrices.PlainaFinalPrice2 + CostPrices.PlainaFinalPrice3 + CostPrices.PlainaFinalPrice4 + CostPrices.PlainaFinalPrice5 + CostPrices.PlainaFinalPrice6
        txtCErmTotal.EditValue = CostPrices.CErmariaTotal
    End Sub

    Private Sub txtCErmTotal_EditValueChanged(sender As Object, e As EventArgs) Handles txtCErmTotal.EditValueChanged
        CostPrices.GenTot = CostPrices.VTotal + CostPrices.KTotal + CostPrices.YTotal + CostPrices.VEpendisisTotal + CostPrices.KEpendisisTotal + CostPrices.YEpendisisTotal + CostPrices.BenchBackTotal + CostPrices.TotKEquipment +
                            CostPrices.CErmariaTotal + CostPrices.TotCEquipment + CostPrices.DTotal + CostPrices.SCTotal + CostPrices.KStandarTotal + CostPrices.CStandarTotal + CostPrices.DStandarTotal + CostPrices.SCStandarTotal
        txtGenTot.EditValue = CostPrices.GenTot
    End Sub

    Private Sub TCMech_ElementClick(sender As Object, e As NavElementEventArgs) Handles TCMech.ElementClick
        Maintab.SelectedTabPage = XtraTabPage6
        XtraTabPage6.Visible = True

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
    End Sub

    Private Sub GridView1_CustomDrawFooterCell(sender As Object, e As FooterCellCustomDrawEventArgs) Handles GridView1.CustomDrawFooterCell
        CostPrices.TotCEquipment = GridView1.Columns("Total").SummaryItem.SummaryValue
        txtGenTot.EditValue = CostPrices.GenTot + CostPrices.TotCEquipment
    End Sub

    Private Sub GridView1_PopupMenuShowing(sender As Object, e As PopupMenuShowingEventArgs) Handles GridView1.PopupMenuShowing
        If e.MenuType = GridMenuType.Column Then LoadForms.PopupMenuShow(e, GridView1, "CCT_ORDERS_CLOSET_EQUIPMENT_COST_def.xml", "vw_CCT_ORDERS_CLOSET_EQUIPMENT")
    End Sub

    Private Sub DTem1_EditValueChanged(sender As Object, e As EventArgs) Handles DTem1.EditValueChanged
        CostPrices.DTem1 = DTem1.EditValue
        CostPrices.DDoorFinalPrice1 = CostPrices.DTem1 * CostPrices.DDoorPrice1
        txtDPrice1.EditValue = CostPrices.DDoorFinalPrice1

    End Sub

    Private Sub DTem2_EditValueChanged(sender As Object, e As EventArgs) Handles DTem2.EditValueChanged
        CostPrices.DTem2 = DTem2.EditValue
        CostPrices.DDoorFinalPrice2 = CostPrices.DTem2 * CostPrices.DDoorPrice2
        txtDPrice2.EditValue = CostPrices.DDoorFinalPrice2
    End Sub

    Private Sub DTem3_EditValueChanged(sender As Object, e As EventArgs) Handles DTem3.EditValueChanged
        CostPrices.DTem3 = DTem3.EditValue
        CostPrices.DDoorFinalPrice3 = CostPrices.DTem3 * CostPrices.DDoorPrice3
        txtDPrice3.EditValue = CostPrices.DDoorFinalPrice3
    End Sub

    Private Sub DTem4_EditValueChanged(sender As Object, e As EventArgs) Handles DTem4.EditValueChanged
        CostPrices.DTem4 = DTem4.EditValue
        CostPrices.DDoorFinalPrice4 = CostPrices.DTem4 * CostPrices.DDoorPrice4
        txtDPrice4.EditValue = CostPrices.DDoorFinalPrice4
    End Sub

    Private Sub DTem5_EditValueChanged(sender As Object, e As EventArgs) Handles DTem5.EditValueChanged
        CostPrices.DTem5 = DTem5.EditValue
        CostPrices.DDoorFinalPrice5 = CostPrices.DTem5 * CostPrices.DDoorPrice5
        txtDPrice5.EditValue = CostPrices.DDoorFinalPrice5
    End Sub

    Private Sub DTem6_EditValueChanged(sender As Object, e As EventArgs) Handles DTem6.EditValueChanged
        CostPrices.DTem6 = DTem6.EditValue
        CostPrices.DDoorFinalPrice6 = CostPrices.DTem6 * CostPrices.DDoorPrice6
        txtDPrice6.EditValue = CostPrices.DDoorFinalPrice6
    End Sub

    Private Sub txtDPrice1_EditValueChanged(sender As Object, e As EventArgs) Handles txtDPrice1.EditValueChanged
        CostPrices.DTotal = CostPrices.DDoorFinalPrice1 + CostPrices.DDoorFinalPrice2 + CostPrices.DDoorFinalPrice3 + CostPrices.DDoorFinalPrice4 + CostPrices.DDoorFinalPrice5 + CostPrices.DDoorFinalPrice6 + CostPrices.DStandarTotal +
            CostPrices.DDesign
        txtDTotal.EditValue = CostPrices.DTotal
    End Sub

    Private Sub txtDPrice2_EditValueChanged(sender As Object, e As EventArgs) Handles txtDPrice2.EditValueChanged
        CostPrices.DTotal = CostPrices.DDoorFinalPrice1 + CostPrices.DDoorFinalPrice2 + CostPrices.DDoorFinalPrice3 + CostPrices.DDoorFinalPrice4 + CostPrices.DDoorFinalPrice5 + CostPrices.DDoorFinalPrice6 + CostPrices.DStandarTotal +
            CostPrices.DDesign
        txtDTotal.EditValue = CostPrices.DTotal
    End Sub

    Private Sub txtDPrice3_EditValueChanged(sender As Object, e As EventArgs) Handles txtDPrice3.EditValueChanged
        CostPrices.DTotal = CostPrices.DDoorFinalPrice1 + CostPrices.DDoorFinalPrice2 + CostPrices.DDoorFinalPrice3 + CostPrices.DDoorFinalPrice4 + CostPrices.DDoorFinalPrice5 + CostPrices.DDoorFinalPrice6 + CostPrices.DStandarTotal +
            CostPrices.DDesign
        txtDTotal.EditValue = CostPrices.DTotal
    End Sub

    Private Sub txtDPrice4_EditValueChanged(sender As Object, e As EventArgs) Handles txtDPrice4.EditValueChanged
        CostPrices.DTotal = CostPrices.DDoorFinalPrice1 + CostPrices.DDoorFinalPrice2 + CostPrices.DDoorFinalPrice3 + CostPrices.DDoorFinalPrice4 + CostPrices.DDoorFinalPrice5 + CostPrices.DDoorFinalPrice6 + CostPrices.DStandarTotal +
            CostPrices.DDesign
        txtDTotal.EditValue = CostPrices.DTotal
    End Sub

    Private Sub txtDPrice5_EditValueChanged(sender As Object, e As EventArgs) Handles txtDPrice5.EditValueChanged
        CostPrices.DTotal = CostPrices.DDoorFinalPrice1 + CostPrices.DDoorFinalPrice2 + CostPrices.DDoorFinalPrice3 + CostPrices.DDoorFinalPrice4 + CostPrices.DDoorFinalPrice5 + CostPrices.DDoorFinalPrice6 + CostPrices.DStandarTotal +
            CostPrices.DDesign
        txtDTotal.EditValue = CostPrices.DTotal
    End Sub

    Private Sub txtDPrice6_EditValueChanged(sender As Object, e As EventArgs) Handles txtDPrice6.EditValueChanged
        CostPrices.DTotal = CostPrices.DDoorFinalPrice1 + CostPrices.DDoorFinalPrice2 + CostPrices.DDoorFinalPrice3 + CostPrices.DDoorFinalPrice4 + CostPrices.DDoorFinalPrice5 + CostPrices.DDoorFinalPrice6 + CostPrices.DStandarTotal +
            CostPrices.DDesign
        txtDTotal.EditValue = CostPrices.DTotal
    End Sub

    Private Sub txtDTotal_EditValueChanged(sender As Object, e As EventArgs) Handles txtDTotal.EditValueChanged
        CostPrices.GenTot = CostPrices.VTotal + CostPrices.KTotal + CostPrices.YTotal + CostPrices.VEpendisisTotal + CostPrices.KEpendisisTotal + CostPrices.YEpendisisTotal + CostPrices.BenchBackTotal + CostPrices.TotKEquipment +
                            CostPrices.CErmariaTotal + CostPrices.TotCEquipment + CostPrices.DTotal + CostPrices.SCTotal + CostPrices.KStandarTotal + CostPrices.CStandarTotal + CostPrices.DStandarTotal + CostPrices.SCStandarTotal

        txtGenTot.EditValue = CostPrices.GenTot
    End Sub
    Private Sub txtDDesigner_EditValueChanged(sender As Object, e As EventArgs) Handles txtDDesigner.EditValueChanged
        CostPrices.DDesign = txtDDesigner.EditValue
        CostPrices.DTotal = CostPrices.DDoorFinalPrice1 + CostPrices.DDoorFinalPrice2 + CostPrices.DDoorFinalPrice3 + CostPrices.DDoorFinalPrice4 + CostPrices.DDoorFinalPrice5 + CostPrices.DDoorFinalPrice6 + CostPrices.DStandarTotal +
                            CostPrices.DDesign
        txtDTotal.EditValue = CostPrices.DTotal
    End Sub

    Private Sub txtSCDesigner_EditValueChanged(sender As Object, e As EventArgs) Handles txtSCDesigner.EditValueChanged
        CostPrices.SCDesign = txtSCDesigner.EditValue
        CostPrices.DTotal = CostPrices.SCDoorFinalPrice1 + CostPrices.SCDoorFinalPrice2 + CostPrices.SCDoorFinalPrice3 + CostPrices.SCDoorFinalPrice4 + CostPrices.SCStandarTotal + CostPrices.SCDesign
        txtSCTotal.EditValue = CostPrices.SCTotal
    End Sub

End Class