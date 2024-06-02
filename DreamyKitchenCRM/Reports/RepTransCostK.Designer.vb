<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Public Class RepTransCostK
    Inherits DevExpress.XtraReports.UI.XtraReport

    'XtraReport overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Designer
    'It can be modified using the Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim CustomStringConnectionParameters1 As DevExpress.DataAccess.ConnectionParameters.CustomStringConnectionParameters = New DevExpress.DataAccess.ConnectionParameters.CustomStringConnectionParameters()
        Dim CustomSqlQuery1 As DevExpress.DataAccess.Sql.CustomSqlQuery = New DevExpress.DataAccess.Sql.CustomSqlQuery()
        Dim QueryParameter1 As DevExpress.DataAccess.Sql.QueryParameter = New DevExpress.DataAccess.Sql.QueryParameter()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RepTransCostK))
        Dim DynamicListLookUpSettings1 As DevExpress.XtraReports.Parameters.DynamicListLookUpSettings = New DevExpress.XtraReports.Parameters.DynamicListLookUpSettings()
        Me.SqlDataSource1 = New DevExpress.DataAccess.Sql.SqlDataSource(Me.components)
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
        Me.XrSubreport1 = New DevExpress.XtraReports.UI.XRSubreport()
        Me.TransCostID = New DevExpress.XtraReports.Parameters.Parameter()
        Me.SubBand2 = New DevExpress.XtraReports.UI.SubBand()
        Me.XrSubreport2 = New DevExpress.XtraReports.UI.XRSubreport()
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.XrPictureBox1 = New DevExpress.XtraReports.UI.XRPictureBox()
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.CalculatedField1 = New DevExpress.XtraReports.UI.CalculatedField()
        Me.ReportHeader = New DevExpress.XtraReports.UI.ReportHeaderBand()
        Me.XrPanel1 = New DevExpress.XtraReports.UI.XRPanel()
        Me.XrLabel4 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel6 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel27 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel26 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel17 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel20 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel18 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel15 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel25 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrTable1 = New DevExpress.XtraReports.UI.XRTable()
        Me.XrTableRow1 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell50 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell36 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell1 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell3 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell4 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableRow2 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell51 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell37 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell6 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell8 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell9 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableRow3 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell52 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell38 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell11 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell13 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell14 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableRow4 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell53 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell39 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell16 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell18 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell19 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableRow5 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell54 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell40 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell21 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell23 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell24 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableRow6 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell55 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell41 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell26 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell28 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell29 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableRow7 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell56 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell42 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell31 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell33 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell34 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableRow24 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell119 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell120 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTable2 = New DevExpress.XtraReports.UI.XRTable()
        Me.XrTableRow8 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell2 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell5 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell7 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell10 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell12 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableRow9 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell15 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell17 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell20 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell22 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell25 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableRow10 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell27 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell30 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell32 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell35 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell43 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableRow11 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell44 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell45 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell46 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell47 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell48 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableRow12 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell49 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell57 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell58 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell59 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell60 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableRow13 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell61 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell62 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell63 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell64 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell65 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableRow14 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell66 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell67 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell68 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell69 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell70 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableRow15 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell71 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell72 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell73 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell74 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell75 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableRow16 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell76 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell77 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell78 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell79 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell80 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableRow17 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell81 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell82 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell83 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell84 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell85 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableRow25 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell121 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell122 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel3 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrTable3 = New DevExpress.XtraReports.UI.XRTable()
        Me.XrTableRow18 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell86 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell87 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell88 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell89 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell90 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableRow19 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell91 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell92 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell93 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell94 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell95 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableRow20 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell96 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell97 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell98 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell99 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell100 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableRow21 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell101 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell102 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell103 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell104 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell105 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableRow26 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell123 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell124 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrTable4 = New DevExpress.XtraReports.UI.XRTable()
        Me.XrTableRow22 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell106 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell107 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell108 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell109 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell110 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableRow23 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell111 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell112 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell113 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell114 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell115 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTable7 = New DevExpress.XtraReports.UI.XRTable()
        Me.XrTableRow28 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell118 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell125 = New DevExpress.XtraReports.UI.XRTableCell()
        CType(Me.XrTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrTable2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrTable3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrTable4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrTable7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'SqlDataSource1
        '
        Me.SqlDataSource1.ConnectionName = "DreamyKitchenCRM.My.MySettings.DreamyKitchenConnectionStringRemotely"
        Me.SqlDataSource1.ConnectionOptions.CommandTimeout = 15
        Me.SqlDataSource1.ConnectionOptions.DbCommandTimeout = 15
        CustomStringConnectionParameters1.ConnectionString = "XpoProvider=MSSqlServer;Password=Dr3@mySA;Persist Security Info=True;User ID=sa;I" &
    "nitial Catalog=DreamyKitchen;Data Source=10.10.5.7,1433;MultipleActiveResultSets" &
    "=True"
        Me.SqlDataSource1.ConnectionParameters = CustomStringConnectionParameters1
        Me.SqlDataSource1.Name = "SqlDataSource1"
        CustomSqlQuery1.Name = "VW_REPTRANSCOSTK"
        QueryParameter1.Name = "TransCostID"
        QueryParameter1.Type = GetType(DevExpress.DataAccess.Expression)
        QueryParameter1.Value = New DevExpress.DataAccess.Expression("?TransCostID", GetType(System.Guid))
        CustomSqlQuery1.Parameters.AddRange(New DevExpress.DataAccess.Sql.QueryParameter() {QueryParameter1})
        CustomSqlQuery1.Sql = "select ""VW_REPTRANSCOSTK"".*" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "  from ""dbo"".""VW_REPTRANSCOSTK"" ""VW_REPTRANSCOSTK""" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) &
    " where (""VW_REPTRANSCOSTK"".""ID"" = @TransCostID)"
        Me.SqlDataSource1.Queries.AddRange(New DevExpress.DataAccess.Sql.SqlQuery() {CustomSqlQuery1})
        Me.SqlDataSource1.ResultSchemaSerializable = resources.GetString("SqlDataSource1.ResultSchemaSerializable")
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrSubreport1})
        Me.Detail.HeightF = 23.0!
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detail.PageBreak = DevExpress.XtraReports.UI.PageBreak.AfterBand
        Me.Detail.SubBands.AddRange(New DevExpress.XtraReports.UI.SubBand() {Me.SubBand2})
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrSubreport1
        '
        Me.XrSubreport1.LocationFloat = New DevExpress.Utils.PointFloat(0!, 0!)
        Me.XrSubreport1.Name = "XrSubreport1"
        Me.XrSubreport1.ParameterBindings.Add(New DevExpress.XtraReports.UI.ParameterBinding("TransCostID", Me.TransCostID))
        Me.XrSubreport1.ReportSource = New DreamyKitchenCRM.RepTransCostEQK()
        Me.XrSubreport1.SizeF = New System.Drawing.SizeF(625.0!, 23.0!)
        '
        'TransCostID
        '
        Me.TransCostID.Description = "TransCostID"
        Me.TransCostID.Name = "TransCostID"
        Me.TransCostID.Type = GetType(System.Guid)
        Me.TransCostID.ValueInfo = "83f1949f-1238-4c59-84b6-513800805651"
        DynamicListLookUpSettings1.DataMember = "VW_REPTRANSCOSTK"
        DynamicListLookUpSettings1.DataSource = Me.SqlDataSource1
        DynamicListLookUpSettings1.DisplayMember = "ID"
        DynamicListLookUpSettings1.ValueMember = "ID"
        Me.TransCostID.ValueSourceSettings = DynamicListLookUpSettings1
        Me.TransCostID.Visible = False
        '
        'SubBand2
        '
        Me.SubBand2.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrSubreport2})
        Me.SubBand2.HeightF = 23.0!
        Me.SubBand2.Name = "SubBand2"
        '
        'XrSubreport2
        '
        Me.XrSubreport2.LocationFloat = New DevExpress.Utils.PointFloat(0.0005086263!, 0!)
        Me.XrSubreport2.Name = "XrSubreport2"
        Me.XrSubreport2.ParameterBindings.Add(New DevExpress.XtraReports.UI.ParameterBinding("TransCostID", Me.TransCostID))
        Me.XrSubreport2.ReportSource = New DreamyKitchenCRM.Rep_TransCostDE()
        Me.XrSubreport2.SizeF = New System.Drawing.SizeF(625.0!, 23.0!)
        '
        'TopMargin
        '
        Me.TopMargin.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrPictureBox1})
        Me.TopMargin.HeightF = 51.0!
        Me.TopMargin.Name = "TopMargin"
        Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrPictureBox1
        '
        Me.XrPictureBox1.ImageSource = New DevExpress.XtraPrinting.Drawing.ImageSource("img", resources.GetString("XrPictureBox1.ImageSource"))
        Me.XrPictureBox1.LocationFloat = New DevExpress.Utils.PointFloat(0!, 9.999992!)
        Me.XrPictureBox1.Name = "XrPictureBox1"
        Me.XrPictureBox1.SizeF = New System.Drawing.SizeF(159.2699!, 34.0354!)
        Me.XrPictureBox1.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage
        '
        'BottomMargin
        '
        Me.BottomMargin.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrTable7})
        Me.BottomMargin.HeightF = 46.0!
        Me.BottomMargin.Name = "BottomMargin"
        Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'CalculatedField1
        '
        Me.CalculatedField1.DataMember = "vw_CCT_OFFERS_DOOR"
        Me.CalculatedField1.Name = "CalculatedField1"
        '
        'ReportHeader
        '
        Me.ReportHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrPanel1, Me.XrLabel25, Me.XrTable1, Me.XrTable2, Me.XrLabel2, Me.XrLabel3, Me.XrTable3, Me.XrLabel1, Me.XrTable4})
        Me.ReportHeader.HeightF = 831.1724!
        Me.ReportHeader.Name = "ReportHeader"
        '
        'XrPanel1
        '
        Me.XrPanel1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel4, Me.XrLabel6, Me.XrLabel27, Me.XrLabel26, Me.XrLabel17, Me.XrLabel20, Me.XrLabel18, Me.XrLabel15})
        Me.XrPanel1.LocationFloat = New DevExpress.Utils.PointFloat(0.0001816523!, 0!)
        Me.XrPanel1.Name = "XrPanel1"
        Me.XrPanel1.SizeF = New System.Drawing.SizeF(624.9998!, 97.83936!)
        '
        'XrLabel4
        '
        Me.XrLabel4.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel4.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[cmt]")})
        Me.XrLabel4.Font = New DevExpress.Drawing.DXFont("Zona Pro Regular", 10.0!)
        Me.XrLabel4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.XrLabel4.LocationFloat = New DevExpress.Utils.PointFloat(376.8547!, 20.61906!)
        Me.XrLabel4.Multiline = True
        Me.XrLabel4.Name = "XrLabel4"
        Me.XrLabel4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel4.SizeF = New System.Drawing.SizeF(246.1451!, 67.38099!)
        Me.XrLabel4.StylePriority.UseBorders = False
        Me.XrLabel4.StylePriority.UseFont = False
        Me.XrLabel4.StylePriority.UseForeColor = False
        Me.XrLabel4.Text = "XrLabel4"
        '
        'XrLabel6
        '
        Me.XrLabel6.Font = New DevExpress.Drawing.DXFont("Zona Pro Regular", 10.0!)
        Me.XrLabel6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.XrLabel6.LocationFloat = New DevExpress.Utils.PointFloat(470.4521!, 0!)
        Me.XrLabel6.Multiline = True
        Me.XrLabel6.Name = "XrLabel6"
        Me.XrLabel6.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel6.SizeF = New System.Drawing.SizeF(90.70468!, 20.61902!)
        Me.XrLabel6.StylePriority.UseFont = False
        Me.XrLabel6.StylePriority.UseForeColor = False
        Me.XrLabel6.Text = "Σημείωσεις"
        '
        'XrLabel27
        '
        Me.XrLabel27.CanShrink = True
        Me.XrLabel27.Font = New DevExpress.Drawing.DXFont("Zona Pro", 10.0!)
        Me.XrLabel27.ForeColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(113, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.XrLabel27.LocationFloat = New DevExpress.Utils.PointFloat(1.999701!, 68.0!)
        Me.XrLabel27.Name = "XrLabel27"
        Me.XrLabel27.SizeF = New System.Drawing.SizeF(73.8238!, 20.00001!)
        Me.XrLabel27.StylePriority.UseFont = False
        Me.XrLabel27.StylePriority.UseForeColor = False
        Me.XrLabel27.Text = "Πωλητής:"
        '
        'XrLabel26
        '
        Me.XrLabel26.BorderColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(113, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.XrLabel26.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrLabel26.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[VW_REPTRANSCOSTK].[SalerName]")})
        Me.XrLabel26.Font = New DevExpress.Drawing.DXFont("Zona Pro Regular", 9.857143!, DevExpress.Drawing.DXFontStyle.Regular, DevExpress.Drawing.DXGraphicsUnit.Point, New DevExpress.Drawing.DXFontAdditionalProperty() {New DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", CType(0, Byte))})
        Me.XrLabel26.ForeColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(113, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.XrLabel26.LocationFloat = New DevExpress.Utils.PointFloat(76.82349!, 68.00003!)
        Me.XrLabel26.Multiline = True
        Me.XrLabel26.Name = "XrLabel26"
        Me.XrLabel26.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel26.SizeF = New System.Drawing.SizeF(295.2001!, 20.00002!)
        Me.XrLabel26.StylePriority.UseBorderColor = False
        Me.XrLabel26.StylePriority.UseBorders = False
        Me.XrLabel26.StylePriority.UseFont = False
        Me.XrLabel26.StylePriority.UseForeColor = False
        Me.XrLabel26.Text = "XrLabel26"
        '
        'XrLabel17
        '
        Me.XrLabel17.CanShrink = True
        Me.XrLabel17.Font = New DevExpress.Drawing.DXFont("Zona Pro", 10.0!)
        Me.XrLabel17.ForeColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(113, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.XrLabel17.LocationFloat = New DevExpress.Utils.PointFloat(0!, 36.00001!)
        Me.XrLabel17.Name = "XrLabel17"
        Me.XrLabel17.SizeF = New System.Drawing.SizeF(73.8238!, 20.0!)
        Me.XrLabel17.StylePriority.UseFont = False
        Me.XrLabel17.StylePriority.UseForeColor = False
        Me.XrLabel17.Text = "Ημερ/νία:"
        '
        'XrLabel20
        '
        Me.XrLabel20.BorderColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(113, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.XrLabel20.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrLabel20.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[VW_REPTRANSCOSTK].[createdOn]")})
        Me.XrLabel20.Font = New DevExpress.Drawing.DXFont("Zona Pro Regular", 10.0!)
        Me.XrLabel20.ForeColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(113, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.XrLabel20.LocationFloat = New DevExpress.Utils.PointFloat(76.82349!, 35.99999!)
        Me.XrLabel20.Multiline = True
        Me.XrLabel20.Name = "XrLabel20"
        Me.XrLabel20.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel20.SizeF = New System.Drawing.SizeF(295.2001!, 20.00001!)
        Me.XrLabel20.StylePriority.UseBorderColor = False
        Me.XrLabel20.StylePriority.UseBorders = False
        Me.XrLabel20.StylePriority.UseFont = False
        Me.XrLabel20.StylePriority.UseForeColor = False
        Me.XrLabel20.Text = "XrLabel20"
        Me.XrLabel20.TextFormatString = "{0:d}"
        '
        'XrLabel18
        '
        Me.XrLabel18.BorderColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(113, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.XrLabel18.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrLabel18.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Fullname]")})
        Me.XrLabel18.Font = New DevExpress.Drawing.DXFont("Zona Pro Regular", 9.0!)
        Me.XrLabel18.ForeColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(113, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.XrLabel18.LocationFloat = New DevExpress.Utils.PointFloat(76.82349!, 4.999996!)
        Me.XrLabel18.Multiline = True
        Me.XrLabel18.Name = "XrLabel18"
        Me.XrLabel18.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel18.SizeF = New System.Drawing.SizeF(295.2001!, 23.0!)
        Me.XrLabel18.StylePriority.UseBorderColor = False
        Me.XrLabel18.StylePriority.UseBorders = False
        Me.XrLabel18.StylePriority.UseFont = False
        Me.XrLabel18.StylePriority.UseForeColor = False
        Me.XrLabel18.Text = "XrLabel18"
        '
        'XrLabel15
        '
        Me.XrLabel15.CanShrink = True
        Me.XrLabel15.Font = New DevExpress.Drawing.DXFont("Zona Pro", 10.0!)
        Me.XrLabel15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(113, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.XrLabel15.LocationFloat = New DevExpress.Utils.PointFloat(0!, 5.000031!)
        Me.XrLabel15.Name = "XrLabel15"
        Me.XrLabel15.SizeF = New System.Drawing.SizeF(73.8238!, 20.0!)
        Me.XrLabel15.StylePriority.UseFont = False
        Me.XrLabel15.StylePriority.UseForeColor = False
        Me.XrLabel15.Text = "Πελάτης:"
        '
        'XrLabel25
        '
        Me.XrLabel25.BackColor = System.Drawing.Color.White
        Me.XrLabel25.Font = New DevExpress.Drawing.DXFont("Zona Pro", 12.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrLabel25.ForeColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(113, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.XrLabel25.LocationFloat = New DevExpress.Utils.PointFloat(1.999878!, 168.6726!)
        Me.XrLabel25.Name = "XrLabel25"
        Me.XrLabel25.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.XrLabel25.SizeF = New System.Drawing.SizeF(625.0001!, 20.83333!)
        Me.XrLabel25.StylePriority.UseBackColor = False
        Me.XrLabel25.StylePriority.UseFont = False
        Me.XrLabel25.StylePriority.UseForeColor = False
        Me.XrLabel25.StylePriority.UsePadding = False
        Me.XrLabel25.StylePriority.UseTextAlignment = False
        Me.XrLabel25.Text = "ΕΡΜΑΡΙΑ"
        Me.XrLabel25.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrTable1
        '
        Me.XrTable1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(113, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.XrTable1.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTable1.LocationFloat = New DevExpress.Utils.PointFloat(0!, 189.5059!)
        Me.XrTable1.Name = "XrTable1"
        Me.XrTable1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96.0!)
        Me.XrTable1.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow1, Me.XrTableRow2, Me.XrTableRow3, Me.XrTableRow4, Me.XrTableRow5, Me.XrTableRow6, Me.XrTableRow7, Me.XrTableRow24})
        Me.XrTable1.SizeF = New System.Drawing.SizeF(625.0003!, 200.0!)
        Me.XrTable1.StylePriority.UseBorderColor = False
        Me.XrTable1.StylePriority.UseBorders = False
        '
        'XrTableRow1
        '
        Me.XrTableRow1.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell50, Me.XrTableCell36, Me.XrTableCell1, Me.XrTableCell3, Me.XrTableCell4})
        Me.XrTableRow1.Name = "XrTableRow1"
        Me.XrTableRow1.Weight = 1.0R
        '
        'XrTableCell50
        '
        Me.XrTableCell50.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.XrTableCell50.Font = New DevExpress.Drawing.DXFont("Zona Pro Regular", 10.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrTableCell50.ForeColor = System.Drawing.Color.Gray
        Me.XrTableCell50.Multiline = True
        Me.XrTableCell50.Name = "XrTableCell50"
        Me.XrTableCell50.StylePriority.UseBackColor = False
        Me.XrTableCell50.StylePriority.UseFont = False
        Me.XrTableCell50.StylePriority.UseForeColor = False
        Me.XrTableCell50.StylePriority.UseTextAlignment = False
        Me.XrTableCell50.Text = "ΠΕΡΙΓΡΑΦΗ"
        Me.XrTableCell50.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrTableCell50.Weight = 1.35560659942077R
        '
        'XrTableCell36
        '
        Me.XrTableCell36.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.XrTableCell36.Font = New DevExpress.Drawing.DXFont("Zona Pro Regular", 10.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrTableCell36.ForeColor = System.Drawing.Color.Gray
        Me.XrTableCell36.Multiline = True
        Me.XrTableCell36.Name = "XrTableCell36"
        Me.XrTableCell36.StylePriority.UseBackColor = False
        Me.XrTableCell36.StylePriority.UseFont = False
        Me.XrTableCell36.StylePriority.UseForeColor = False
        Me.XrTableCell36.StylePriority.UseTextAlignment = False
        Me.XrTableCell36.Text = "ΥΛΙΚΟ"
        Me.XrTableCell36.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrTableCell36.Weight = 2.3624746271932575R
        '
        'XrTableCell1
        '
        Me.XrTableCell1.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.XrTableCell1.Font = New DevExpress.Drawing.DXFont("Zona Pro Regular", 10.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrTableCell1.ForeColor = System.Drawing.Color.Gray
        Me.XrTableCell1.Multiline = True
        Me.XrTableCell1.Name = "XrTableCell1"
        Me.XrTableCell1.StylePriority.UseBackColor = False
        Me.XrTableCell1.StylePriority.UseFont = False
        Me.XrTableCell1.StylePriority.UseForeColor = False
        Me.XrTableCell1.StylePriority.UseTextAlignment = False
        Me.XrTableCell1.Text = "ΤΙΜΗ ΥΛΙΚΟΥ"
        Me.XrTableCell1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrTableCell1.Weight = 1.0909568000502403R
        '
        'XrTableCell3
        '
        Me.XrTableCell3.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.XrTableCell3.Font = New DevExpress.Drawing.DXFont("Zona Pro Regular", 10.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrTableCell3.ForeColor = System.Drawing.Color.Gray
        Me.XrTableCell3.Multiline = True
        Me.XrTableCell3.Name = "XrTableCell3"
        Me.XrTableCell3.StylePriority.UseBackColor = False
        Me.XrTableCell3.StylePriority.UseFont = False
        Me.XrTableCell3.StylePriority.UseForeColor = False
        Me.XrTableCell3.StylePriority.UseTextAlignment = False
        Me.XrTableCell3.Text = "ΤΕΜ/ΤΡ.Μ."
        Me.XrTableCell3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrTableCell3.Weight = 1.0468409166370298R
        '
        'XrTableCell4
        '
        Me.XrTableCell4.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.XrTableCell4.Font = New DevExpress.Drawing.DXFont("Zona Pro Regular", 10.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrTableCell4.ForeColor = System.Drawing.Color.Gray
        Me.XrTableCell4.Multiline = True
        Me.XrTableCell4.Name = "XrTableCell4"
        Me.XrTableCell4.StylePriority.UseBackColor = False
        Me.XrTableCell4.StylePriority.UseFont = False
        Me.XrTableCell4.StylePriority.UseForeColor = False
        Me.XrTableCell4.StylePriority.UseTextAlignment = False
        Me.XrTableCell4.Text = "ΤΕΛΙΚΗ ΤΙΜΗ"
        Me.XrTableCell4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrTableCell4.Weight = 1.361594181021454R
        '
        'XrTableRow2
        '
        Me.XrTableRow2.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell51, Me.XrTableCell37, Me.XrTableCell6, Me.XrTableCell8, Me.XrTableCell9})
        Me.XrTableRow2.Name = "XrTableRow2"
        Me.XrTableRow2.Weight = 1.0R
        '
        'XrTableCell51
        '
        Me.XrTableCell51.BackColor = System.Drawing.Color.Transparent
        Me.XrTableCell51.Font = New DevExpress.Drawing.DXFont("Zona Pro Regular", 10.0!)
        Me.XrTableCell51.ForeColor = System.Drawing.Color.Gray
        Me.XrTableCell51.Multiline = True
        Me.XrTableCell51.Name = "XrTableCell51"
        Me.XrTableCell51.StylePriority.UseBackColor = False
        Me.XrTableCell51.StylePriority.UseFont = False
        Me.XrTableCell51.StylePriority.UseForeColor = False
        Me.XrTableCell51.StylePriority.UseTextAlignment = False
        Me.XrTableCell51.Text = "ΒΑΣΕΩΣ"
        Me.XrTableCell51.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrTableCell51.Weight = 1.35560659942077R
        '
        'XrTableCell37
        '
        Me.XrTableCell37.BackColor = System.Drawing.Color.Transparent
        Me.XrTableCell37.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[VDTName]")})
        Me.XrTableCell37.Font = New DevExpress.Drawing.DXFont("Zona Pro Regular", 10.0!)
        Me.XrTableCell37.ForeColor = System.Drawing.Color.Gray
        Me.XrTableCell37.Multiline = True
        Me.XrTableCell37.Name = "XrTableCell37"
        Me.XrTableCell37.StylePriority.UseBackColor = False
        Me.XrTableCell37.StylePriority.UseFont = False
        Me.XrTableCell37.StylePriority.UseForeColor = False
        Me.XrTableCell37.StylePriority.UseTextAlignment = False
        Me.XrTableCell37.Text = "XrTableCell37"
        Me.XrTableCell37.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrTableCell37.Weight = 2.3624746271932575R
        '
        'XrTableCell6
        '
        Me.XrTableCell6.BackColor = System.Drawing.Color.Transparent
        Me.XrTableCell6.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[VDoorPrice1]")})
        Me.XrTableCell6.Font = New DevExpress.Drawing.DXFont("Zona Pro Regular", 10.0!)
        Me.XrTableCell6.ForeColor = System.Drawing.Color.Gray
        Me.XrTableCell6.Multiline = True
        Me.XrTableCell6.Name = "XrTableCell6"
        Me.XrTableCell6.StylePriority.UseBackColor = False
        Me.XrTableCell6.StylePriority.UseFont = False
        Me.XrTableCell6.StylePriority.UseForeColor = False
        Me.XrTableCell6.StylePriority.UseTextAlignment = False
        Me.XrTableCell6.Text = "XrTableCell6"
        Me.XrTableCell6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrTableCell6.TextFormatString = "{0:C}"
        Me.XrTableCell6.Weight = 1.0909568000502403R
        '
        'XrTableCell8
        '
        Me.XrTableCell8.BackColor = System.Drawing.Color.Transparent
        Me.XrTableCell8.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Vtrm1]")})
        Me.XrTableCell8.Font = New DevExpress.Drawing.DXFont("Zona Pro Regular", 10.0!)
        Me.XrTableCell8.ForeColor = System.Drawing.Color.Gray
        Me.XrTableCell8.Multiline = True
        Me.XrTableCell8.Name = "XrTableCell8"
        Me.XrTableCell8.StylePriority.UseBackColor = False
        Me.XrTableCell8.StylePriority.UseFont = False
        Me.XrTableCell8.StylePriority.UseForeColor = False
        Me.XrTableCell8.StylePriority.UseTextAlignment = False
        Me.XrTableCell8.Text = "XrTableCell8"
        Me.XrTableCell8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrTableCell8.TextFormatString = "{0}cm"
        Me.XrTableCell8.Weight = 1.0468409166370298R
        '
        'XrTableCell9
        '
        Me.XrTableCell9.BackColor = System.Drawing.Color.Transparent
        Me.XrTableCell9.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[vPrice1]")})
        Me.XrTableCell9.Font = New DevExpress.Drawing.DXFont("Zona Pro Regular", 10.0!)
        Me.XrTableCell9.ForeColor = System.Drawing.Color.Gray
        Me.XrTableCell9.Multiline = True
        Me.XrTableCell9.Name = "XrTableCell9"
        Me.XrTableCell9.StylePriority.UseBackColor = False
        Me.XrTableCell9.StylePriority.UseFont = False
        Me.XrTableCell9.StylePriority.UseForeColor = False
        Me.XrTableCell9.StylePriority.UseTextAlignment = False
        Me.XrTableCell9.Text = "XrTableCell9"
        Me.XrTableCell9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrTableCell9.TextFormatString = "{0:C}"
        Me.XrTableCell9.Weight = 1.361594181021454R
        '
        'XrTableRow3
        '
        Me.XrTableRow3.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell52, Me.XrTableCell38, Me.XrTableCell11, Me.XrTableCell13, Me.XrTableCell14})
        Me.XrTableRow3.Name = "XrTableRow3"
        Me.XrTableRow3.Weight = 1.0R
        '
        'XrTableCell52
        '
        Me.XrTableCell52.BackColor = System.Drawing.Color.Transparent
        Me.XrTableCell52.Font = New DevExpress.Drawing.DXFont("Zona Pro Regular", 10.0!)
        Me.XrTableCell52.ForeColor = System.Drawing.Color.Gray
        Me.XrTableCell52.Multiline = True
        Me.XrTableCell52.Name = "XrTableCell52"
        Me.XrTableCell52.StylePriority.UseBackColor = False
        Me.XrTableCell52.StylePriority.UseFont = False
        Me.XrTableCell52.StylePriority.UseForeColor = False
        Me.XrTableCell52.StylePriority.UseTextAlignment = False
        Me.XrTableCell52.Text = "ΒΑΣΕΩΣ"
        Me.XrTableCell52.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrTableCell52.Weight = 1.35560659942077R
        '
        'XrTableCell38
        '
        Me.XrTableCell38.BackColor = System.Drawing.Color.Transparent
        Me.XrTableCell38.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[VDT2Name]")})
        Me.XrTableCell38.Font = New DevExpress.Drawing.DXFont("Zona Pro Regular", 10.0!)
        Me.XrTableCell38.ForeColor = System.Drawing.Color.Gray
        Me.XrTableCell38.Multiline = True
        Me.XrTableCell38.Name = "XrTableCell38"
        Me.XrTableCell38.StylePriority.UseBackColor = False
        Me.XrTableCell38.StylePriority.UseFont = False
        Me.XrTableCell38.StylePriority.UseForeColor = False
        Me.XrTableCell38.StylePriority.UseTextAlignment = False
        Me.XrTableCell38.Text = "XrTableCell38"
        Me.XrTableCell38.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrTableCell38.Weight = 2.3624746271932575R
        '
        'XrTableCell11
        '
        Me.XrTableCell11.BackColor = System.Drawing.Color.Transparent
        Me.XrTableCell11.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[VDoorPrice2]")})
        Me.XrTableCell11.Font = New DevExpress.Drawing.DXFont("Zona Pro Regular", 10.0!)
        Me.XrTableCell11.ForeColor = System.Drawing.Color.Gray
        Me.XrTableCell11.Multiline = True
        Me.XrTableCell11.Name = "XrTableCell11"
        Me.XrTableCell11.StylePriority.UseBackColor = False
        Me.XrTableCell11.StylePriority.UseFont = False
        Me.XrTableCell11.StylePriority.UseForeColor = False
        Me.XrTableCell11.StylePriority.UseTextAlignment = False
        Me.XrTableCell11.Text = "XrTableCell11"
        Me.XrTableCell11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrTableCell11.TextFormatString = "{0:C}"
        Me.XrTableCell11.Weight = 1.0909568000502403R
        '
        'XrTableCell13
        '
        Me.XrTableCell13.BackColor = System.Drawing.Color.Transparent
        Me.XrTableCell13.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Vtrm2]")})
        Me.XrTableCell13.Font = New DevExpress.Drawing.DXFont("Zona Pro Regular", 10.0!)
        Me.XrTableCell13.ForeColor = System.Drawing.Color.Gray
        Me.XrTableCell13.Multiline = True
        Me.XrTableCell13.Name = "XrTableCell13"
        Me.XrTableCell13.StylePriority.UseBackColor = False
        Me.XrTableCell13.StylePriority.UseFont = False
        Me.XrTableCell13.StylePriority.UseForeColor = False
        Me.XrTableCell13.StylePriority.UseTextAlignment = False
        Me.XrTableCell13.Text = "XrTableCell13"
        Me.XrTableCell13.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrTableCell13.TextFormatString = "{0}cm"
        Me.XrTableCell13.Weight = 1.0468409166370298R
        '
        'XrTableCell14
        '
        Me.XrTableCell14.BackColor = System.Drawing.Color.Transparent
        Me.XrTableCell14.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[VPrice2]")})
        Me.XrTableCell14.Font = New DevExpress.Drawing.DXFont("Zona Pro Regular", 10.0!)
        Me.XrTableCell14.ForeColor = System.Drawing.Color.Gray
        Me.XrTableCell14.Multiline = True
        Me.XrTableCell14.Name = "XrTableCell14"
        Me.XrTableCell14.StylePriority.UseBackColor = False
        Me.XrTableCell14.StylePriority.UseFont = False
        Me.XrTableCell14.StylePriority.UseForeColor = False
        Me.XrTableCell14.StylePriority.UseTextAlignment = False
        Me.XrTableCell14.Text = "XrTableCell14"
        Me.XrTableCell14.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrTableCell14.TextFormatString = "{0:C}"
        Me.XrTableCell14.Weight = 1.361594181021454R
        '
        'XrTableRow4
        '
        Me.XrTableRow4.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell53, Me.XrTableCell39, Me.XrTableCell16, Me.XrTableCell18, Me.XrTableCell19})
        Me.XrTableRow4.Name = "XrTableRow4"
        Me.XrTableRow4.Weight = 1.0R
        '
        'XrTableCell53
        '
        Me.XrTableCell53.BackColor = System.Drawing.Color.Transparent
        Me.XrTableCell53.Font = New DevExpress.Drawing.DXFont("Zona Pro Regular", 10.0!)
        Me.XrTableCell53.ForeColor = System.Drawing.Color.Gray
        Me.XrTableCell53.Multiline = True
        Me.XrTableCell53.Name = "XrTableCell53"
        Me.XrTableCell53.StylePriority.UseBackColor = False
        Me.XrTableCell53.StylePriority.UseFont = False
        Me.XrTableCell53.StylePriority.UseForeColor = False
        Me.XrTableCell53.StylePriority.UseTextAlignment = False
        Me.XrTableCell53.Text = "ΚΡΕΜΑΣΤΑ"
        Me.XrTableCell53.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrTableCell53.Weight = 1.35560659942077R
        '
        'XrTableCell39
        '
        Me.XrTableCell39.BackColor = System.Drawing.Color.Transparent
        Me.XrTableCell39.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[KDTName]")})
        Me.XrTableCell39.Font = New DevExpress.Drawing.DXFont("Zona Pro Regular", 10.0!)
        Me.XrTableCell39.ForeColor = System.Drawing.Color.Gray
        Me.XrTableCell39.Multiline = True
        Me.XrTableCell39.Name = "XrTableCell39"
        Me.XrTableCell39.StylePriority.UseBackColor = False
        Me.XrTableCell39.StylePriority.UseFont = False
        Me.XrTableCell39.StylePriority.UseForeColor = False
        Me.XrTableCell39.StylePriority.UseTextAlignment = False
        Me.XrTableCell39.Text = "XrTableCell39"
        Me.XrTableCell39.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrTableCell39.Weight = 2.3624746271932575R
        '
        'XrTableCell16
        '
        Me.XrTableCell16.BackColor = System.Drawing.Color.Transparent
        Me.XrTableCell16.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[KDoorPrice1]")})
        Me.XrTableCell16.Font = New DevExpress.Drawing.DXFont("Zona Pro Regular", 10.0!)
        Me.XrTableCell16.ForeColor = System.Drawing.Color.Gray
        Me.XrTableCell16.Multiline = True
        Me.XrTableCell16.Name = "XrTableCell16"
        Me.XrTableCell16.StylePriority.UseBackColor = False
        Me.XrTableCell16.StylePriority.UseFont = False
        Me.XrTableCell16.StylePriority.UseForeColor = False
        Me.XrTableCell16.StylePriority.UseTextAlignment = False
        Me.XrTableCell16.Text = "XrTableCell16"
        Me.XrTableCell16.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrTableCell16.TextFormatString = "{0:C}"
        Me.XrTableCell16.Weight = 1.0909568000502403R
        '
        'XrTableCell18
        '
        Me.XrTableCell18.BackColor = System.Drawing.Color.Transparent
        Me.XrTableCell18.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Ktrm1]")})
        Me.XrTableCell18.Font = New DevExpress.Drawing.DXFont("Zona Pro Regular", 10.0!)
        Me.XrTableCell18.ForeColor = System.Drawing.Color.Gray
        Me.XrTableCell18.Multiline = True
        Me.XrTableCell18.Name = "XrTableCell18"
        Me.XrTableCell18.StylePriority.UseBackColor = False
        Me.XrTableCell18.StylePriority.UseFont = False
        Me.XrTableCell18.StylePriority.UseForeColor = False
        Me.XrTableCell18.StylePriority.UseTextAlignment = False
        Me.XrTableCell18.Text = "XrTableCell18"
        Me.XrTableCell18.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrTableCell18.TextFormatString = "{0}cm"
        Me.XrTableCell18.Weight = 1.0468409166370298R
        '
        'XrTableCell19
        '
        Me.XrTableCell19.BackColor = System.Drawing.Color.Transparent
        Me.XrTableCell19.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[KPrice1]")})
        Me.XrTableCell19.Font = New DevExpress.Drawing.DXFont("Zona Pro Regular", 10.0!)
        Me.XrTableCell19.ForeColor = System.Drawing.Color.Gray
        Me.XrTableCell19.Multiline = True
        Me.XrTableCell19.Name = "XrTableCell19"
        Me.XrTableCell19.StylePriority.UseBackColor = False
        Me.XrTableCell19.StylePriority.UseFont = False
        Me.XrTableCell19.StylePriority.UseForeColor = False
        Me.XrTableCell19.StylePriority.UseTextAlignment = False
        Me.XrTableCell19.Text = "XrTableCell19"
        Me.XrTableCell19.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrTableCell19.TextFormatString = "{0:C}"
        Me.XrTableCell19.Weight = 1.361594181021454R
        '
        'XrTableRow5
        '
        Me.XrTableRow5.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell54, Me.XrTableCell40, Me.XrTableCell21, Me.XrTableCell23, Me.XrTableCell24})
        Me.XrTableRow5.Name = "XrTableRow5"
        Me.XrTableRow5.Weight = 1.0R
        '
        'XrTableCell54
        '
        Me.XrTableCell54.BackColor = System.Drawing.Color.Transparent
        Me.XrTableCell54.Font = New DevExpress.Drawing.DXFont("Zona Pro Regular", 10.0!)
        Me.XrTableCell54.ForeColor = System.Drawing.Color.Gray
        Me.XrTableCell54.Multiline = True
        Me.XrTableCell54.Name = "XrTableCell54"
        Me.XrTableCell54.StylePriority.UseBackColor = False
        Me.XrTableCell54.StylePriority.UseFont = False
        Me.XrTableCell54.StylePriority.UseForeColor = False
        Me.XrTableCell54.StylePriority.UseTextAlignment = False
        Me.XrTableCell54.Text = "ΚΡΕΜΑΣΤΑ"
        Me.XrTableCell54.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrTableCell54.Weight = 1.35560659942077R
        '
        'XrTableCell40
        '
        Me.XrTableCell40.BackColor = System.Drawing.Color.Transparent
        Me.XrTableCell40.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[KDT2Name]")})
        Me.XrTableCell40.Font = New DevExpress.Drawing.DXFont("Zona Pro Regular", 10.0!)
        Me.XrTableCell40.ForeColor = System.Drawing.Color.Gray
        Me.XrTableCell40.Multiline = True
        Me.XrTableCell40.Name = "XrTableCell40"
        Me.XrTableCell40.StylePriority.UseBackColor = False
        Me.XrTableCell40.StylePriority.UseFont = False
        Me.XrTableCell40.StylePriority.UseForeColor = False
        Me.XrTableCell40.StylePriority.UseTextAlignment = False
        Me.XrTableCell40.Text = "XrTableCell40"
        Me.XrTableCell40.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrTableCell40.Weight = 2.3624746271932575R
        '
        'XrTableCell21
        '
        Me.XrTableCell21.BackColor = System.Drawing.Color.Transparent
        Me.XrTableCell21.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[KDoorPrice2]")})
        Me.XrTableCell21.Font = New DevExpress.Drawing.DXFont("Zona Pro Regular", 10.0!)
        Me.XrTableCell21.ForeColor = System.Drawing.Color.Gray
        Me.XrTableCell21.Multiline = True
        Me.XrTableCell21.Name = "XrTableCell21"
        Me.XrTableCell21.StylePriority.UseBackColor = False
        Me.XrTableCell21.StylePriority.UseFont = False
        Me.XrTableCell21.StylePriority.UseForeColor = False
        Me.XrTableCell21.StylePriority.UseTextAlignment = False
        Me.XrTableCell21.Text = "XrTableCell21"
        Me.XrTableCell21.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrTableCell21.TextFormatString = "{0:C}"
        Me.XrTableCell21.Weight = 1.0909568000502403R
        '
        'XrTableCell23
        '
        Me.XrTableCell23.BackColor = System.Drawing.Color.Transparent
        Me.XrTableCell23.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Ktrm2]")})
        Me.XrTableCell23.Font = New DevExpress.Drawing.DXFont("Zona Pro Regular", 10.0!)
        Me.XrTableCell23.ForeColor = System.Drawing.Color.Gray
        Me.XrTableCell23.Multiline = True
        Me.XrTableCell23.Name = "XrTableCell23"
        Me.XrTableCell23.StylePriority.UseBackColor = False
        Me.XrTableCell23.StylePriority.UseFont = False
        Me.XrTableCell23.StylePriority.UseForeColor = False
        Me.XrTableCell23.StylePriority.UseTextAlignment = False
        Me.XrTableCell23.Text = "XrTableCell23"
        Me.XrTableCell23.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrTableCell23.TextFormatString = "{0}cm"
        Me.XrTableCell23.Weight = 1.0468409166370298R
        '
        'XrTableCell24
        '
        Me.XrTableCell24.BackColor = System.Drawing.Color.Transparent
        Me.XrTableCell24.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[KPrice2]")})
        Me.XrTableCell24.Font = New DevExpress.Drawing.DXFont("Zona Pro Regular", 10.0!)
        Me.XrTableCell24.ForeColor = System.Drawing.Color.Gray
        Me.XrTableCell24.Multiline = True
        Me.XrTableCell24.Name = "XrTableCell24"
        Me.XrTableCell24.StylePriority.UseBackColor = False
        Me.XrTableCell24.StylePriority.UseFont = False
        Me.XrTableCell24.StylePriority.UseForeColor = False
        Me.XrTableCell24.StylePriority.UseTextAlignment = False
        Me.XrTableCell24.Text = "XrTableCell24"
        Me.XrTableCell24.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrTableCell24.TextFormatString = "{0:C}"
        Me.XrTableCell24.Weight = 1.361594181021454R
        '
        'XrTableRow6
        '
        Me.XrTableRow6.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell55, Me.XrTableCell41, Me.XrTableCell26, Me.XrTableCell28, Me.XrTableCell29})
        Me.XrTableRow6.Name = "XrTableRow6"
        Me.XrTableRow6.Weight = 1.0R
        '
        'XrTableCell55
        '
        Me.XrTableCell55.BackColor = System.Drawing.Color.Transparent
        Me.XrTableCell55.Font = New DevExpress.Drawing.DXFont("Zona Pro Regular", 10.0!)
        Me.XrTableCell55.ForeColor = System.Drawing.Color.Gray
        Me.XrTableCell55.Multiline = True
        Me.XrTableCell55.Name = "XrTableCell55"
        Me.XrTableCell55.StylePriority.UseBackColor = False
        Me.XrTableCell55.StylePriority.UseFont = False
        Me.XrTableCell55.StylePriority.UseForeColor = False
        Me.XrTableCell55.StylePriority.UseTextAlignment = False
        Me.XrTableCell55.Text = "ΥΨΗΛΑ"
        Me.XrTableCell55.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrTableCell55.Weight = 1.35560659942077R
        '
        'XrTableCell41
        '
        Me.XrTableCell41.BackColor = System.Drawing.Color.Transparent
        Me.XrTableCell41.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[YDTName]")})
        Me.XrTableCell41.Font = New DevExpress.Drawing.DXFont("Zona Pro Regular", 10.0!)
        Me.XrTableCell41.ForeColor = System.Drawing.Color.Gray
        Me.XrTableCell41.Multiline = True
        Me.XrTableCell41.Name = "XrTableCell41"
        Me.XrTableCell41.StylePriority.UseBackColor = False
        Me.XrTableCell41.StylePriority.UseFont = False
        Me.XrTableCell41.StylePriority.UseForeColor = False
        Me.XrTableCell41.StylePriority.UseTextAlignment = False
        Me.XrTableCell41.Text = "XrTableCell41"
        Me.XrTableCell41.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrTableCell41.Weight = 2.3624746271932575R
        '
        'XrTableCell26
        '
        Me.XrTableCell26.BackColor = System.Drawing.Color.Transparent
        Me.XrTableCell26.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[YDoorPrice1]")})
        Me.XrTableCell26.Font = New DevExpress.Drawing.DXFont("Zona Pro Regular", 10.0!)
        Me.XrTableCell26.ForeColor = System.Drawing.Color.Gray
        Me.XrTableCell26.Multiline = True
        Me.XrTableCell26.Name = "XrTableCell26"
        Me.XrTableCell26.StylePriority.UseBackColor = False
        Me.XrTableCell26.StylePriority.UseFont = False
        Me.XrTableCell26.StylePriority.UseForeColor = False
        Me.XrTableCell26.StylePriority.UseTextAlignment = False
        Me.XrTableCell26.Text = "XrTableCell26"
        Me.XrTableCell26.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrTableCell26.TextFormatString = "{0:C}"
        Me.XrTableCell26.Weight = 1.0909568000502403R
        '
        'XrTableCell28
        '
        Me.XrTableCell28.BackColor = System.Drawing.Color.Transparent
        Me.XrTableCell28.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Ytrm1]")})
        Me.XrTableCell28.Font = New DevExpress.Drawing.DXFont("Zona Pro Regular", 10.0!)
        Me.XrTableCell28.ForeColor = System.Drawing.Color.Gray
        Me.XrTableCell28.Multiline = True
        Me.XrTableCell28.Name = "XrTableCell28"
        Me.XrTableCell28.StylePriority.UseBackColor = False
        Me.XrTableCell28.StylePriority.UseFont = False
        Me.XrTableCell28.StylePriority.UseForeColor = False
        Me.XrTableCell28.StylePriority.UseTextAlignment = False
        Me.XrTableCell28.Text = "XrTableCell28"
        Me.XrTableCell28.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrTableCell28.TextFormatString = "{0}cm"
        Me.XrTableCell28.Weight = 1.0468409166370298R
        '
        'XrTableCell29
        '
        Me.XrTableCell29.BackColor = System.Drawing.Color.Transparent
        Me.XrTableCell29.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[YPrice1]")})
        Me.XrTableCell29.Font = New DevExpress.Drawing.DXFont("Zona Pro Regular", 10.0!)
        Me.XrTableCell29.ForeColor = System.Drawing.Color.Gray
        Me.XrTableCell29.Multiline = True
        Me.XrTableCell29.Name = "XrTableCell29"
        Me.XrTableCell29.StylePriority.UseBackColor = False
        Me.XrTableCell29.StylePriority.UseFont = False
        Me.XrTableCell29.StylePriority.UseForeColor = False
        Me.XrTableCell29.StylePriority.UseTextAlignment = False
        Me.XrTableCell29.Text = "XrTableCell29"
        Me.XrTableCell29.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrTableCell29.TextFormatString = "{0:C}"
        Me.XrTableCell29.Weight = 1.361594181021454R
        '
        'XrTableRow7
        '
        Me.XrTableRow7.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell56, Me.XrTableCell42, Me.XrTableCell31, Me.XrTableCell33, Me.XrTableCell34})
        Me.XrTableRow7.Name = "XrTableRow7"
        Me.XrTableRow7.Weight = 1.0R
        '
        'XrTableCell56
        '
        Me.XrTableCell56.BackColor = System.Drawing.Color.Transparent
        Me.XrTableCell56.Font = New DevExpress.Drawing.DXFont("Zona Pro Regular", 10.0!)
        Me.XrTableCell56.ForeColor = System.Drawing.Color.Gray
        Me.XrTableCell56.Multiline = True
        Me.XrTableCell56.Name = "XrTableCell56"
        Me.XrTableCell56.StylePriority.UseBackColor = False
        Me.XrTableCell56.StylePriority.UseFont = False
        Me.XrTableCell56.StylePriority.UseForeColor = False
        Me.XrTableCell56.StylePriority.UseTextAlignment = False
        Me.XrTableCell56.Text = "ΥΨΗΛΑ"
        Me.XrTableCell56.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrTableCell56.Weight = 1.35560659942077R
        '
        'XrTableCell42
        '
        Me.XrTableCell42.BackColor = System.Drawing.Color.Transparent
        Me.XrTableCell42.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[YDT2Name]")})
        Me.XrTableCell42.Font = New DevExpress.Drawing.DXFont("Zona Pro Regular", 10.0!)
        Me.XrTableCell42.ForeColor = System.Drawing.Color.Gray
        Me.XrTableCell42.Multiline = True
        Me.XrTableCell42.Name = "XrTableCell42"
        Me.XrTableCell42.StylePriority.UseBackColor = False
        Me.XrTableCell42.StylePriority.UseFont = False
        Me.XrTableCell42.StylePriority.UseForeColor = False
        Me.XrTableCell42.StylePriority.UseTextAlignment = False
        Me.XrTableCell42.Text = "XrTableCell42"
        Me.XrTableCell42.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrTableCell42.Weight = 2.3624746271932575R
        '
        'XrTableCell31
        '
        Me.XrTableCell31.BackColor = System.Drawing.Color.Transparent
        Me.XrTableCell31.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[YDoorPrice2]")})
        Me.XrTableCell31.Font = New DevExpress.Drawing.DXFont("Zona Pro Regular", 10.0!)
        Me.XrTableCell31.ForeColor = System.Drawing.Color.Gray
        Me.XrTableCell31.Multiline = True
        Me.XrTableCell31.Name = "XrTableCell31"
        Me.XrTableCell31.StylePriority.UseBackColor = False
        Me.XrTableCell31.StylePriority.UseFont = False
        Me.XrTableCell31.StylePriority.UseForeColor = False
        Me.XrTableCell31.StylePriority.UseTextAlignment = False
        Me.XrTableCell31.Text = "XrTableCell31"
        Me.XrTableCell31.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrTableCell31.TextFormatString = "{0:C}"
        Me.XrTableCell31.Weight = 1.0909568000502403R
        '
        'XrTableCell33
        '
        Me.XrTableCell33.BackColor = System.Drawing.Color.Transparent
        Me.XrTableCell33.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Ytrm2]")})
        Me.XrTableCell33.Font = New DevExpress.Drawing.DXFont("Zona Pro Regular", 10.0!)
        Me.XrTableCell33.ForeColor = System.Drawing.Color.Gray
        Me.XrTableCell33.Multiline = True
        Me.XrTableCell33.Name = "XrTableCell33"
        Me.XrTableCell33.StylePriority.UseBackColor = False
        Me.XrTableCell33.StylePriority.UseFont = False
        Me.XrTableCell33.StylePriority.UseForeColor = False
        Me.XrTableCell33.StylePriority.UseTextAlignment = False
        Me.XrTableCell33.Text = "XrTableCell33"
        Me.XrTableCell33.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrTableCell33.TextFormatString = "{0}cm"
        Me.XrTableCell33.Weight = 1.0468409166370298R
        '
        'XrTableCell34
        '
        Me.XrTableCell34.BackColor = System.Drawing.Color.Transparent
        Me.XrTableCell34.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[YPrice2]")})
        Me.XrTableCell34.Font = New DevExpress.Drawing.DXFont("Zona Pro Regular", 10.0!)
        Me.XrTableCell34.ForeColor = System.Drawing.Color.Gray
        Me.XrTableCell34.Multiline = True
        Me.XrTableCell34.Name = "XrTableCell34"
        Me.XrTableCell34.StylePriority.UseBackColor = False
        Me.XrTableCell34.StylePriority.UseFont = False
        Me.XrTableCell34.StylePriority.UseForeColor = False
        Me.XrTableCell34.StylePriority.UseTextAlignment = False
        Me.XrTableCell34.Text = "XrTableCell34"
        Me.XrTableCell34.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrTableCell34.TextFormatString = "{0:C}"
        Me.XrTableCell34.Weight = 1.361594181021454R
        '
        'XrTableRow24
        '
        Me.XrTableRow24.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell119, Me.XrTableCell120})
        Me.XrTableRow24.Name = "XrTableRow24"
        Me.XrTableRow24.Weight = 1.0R
        '
        'XrTableCell119
        '
        Me.XrTableCell119.BackColor = System.Drawing.Color.Transparent
        Me.XrTableCell119.Font = New DevExpress.Drawing.DXFont("Zona Pro Regular", 10.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrTableCell119.ForeColor = System.Drawing.Color.Gray
        Me.XrTableCell119.Multiline = True
        Me.XrTableCell119.Name = "XrTableCell119"
        Me.XrTableCell119.StylePriority.UseBackColor = False
        Me.XrTableCell119.StylePriority.UseFont = False
        Me.XrTableCell119.StylePriority.UseForeColor = False
        Me.XrTableCell119.StylePriority.UseTextAlignment = False
        Me.XrTableCell119.Text = "ΣΥΝΟΛΟ"
        Me.XrTableCell119.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrTableCell119.Weight = 5.8558789433012981R
        '
        'XrTableCell120
        '
        Me.XrTableCell120.BackColor = System.Drawing.Color.Transparent
        Me.XrTableCell120.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[TotKErm]")})
        Me.XrTableCell120.Font = New DevExpress.Drawing.DXFont("Zona Pro Regular", 10.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrTableCell120.ForeColor = System.Drawing.Color.Gray
        Me.XrTableCell120.Multiline = True
        Me.XrTableCell120.Name = "XrTableCell120"
        Me.XrTableCell120.StylePriority.UseBackColor = False
        Me.XrTableCell120.StylePriority.UseFont = False
        Me.XrTableCell120.StylePriority.UseForeColor = False
        Me.XrTableCell120.StylePriority.UseTextAlignment = False
        Me.XrTableCell120.Text = "XrTableCell120"
        Me.XrTableCell120.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrTableCell120.TextFormatString = "{0:C}"
        Me.XrTableCell120.Weight = 1.361594181021454R
        '
        'XrTable2
        '
        Me.XrTable2.BorderColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(113, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.XrTable2.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTable2.LocationFloat = New DevExpress.Utils.PointFloat(0!, 410.3392!)
        Me.XrTable2.Name = "XrTable2"
        Me.XrTable2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96.0!)
        Me.XrTable2.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow8, Me.XrTableRow9, Me.XrTableRow10, Me.XrTableRow11, Me.XrTableRow12, Me.XrTableRow13, Me.XrTableRow14, Me.XrTableRow15, Me.XrTableRow16, Me.XrTableRow17, Me.XrTableRow25})
        Me.XrTable2.SizeF = New System.Drawing.SizeF(625.0003!, 275.0!)
        Me.XrTable2.StylePriority.UseBorderColor = False
        Me.XrTable2.StylePriority.UseBorders = False
        '
        'XrTableRow8
        '
        Me.XrTableRow8.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell2, Me.XrTableCell5, Me.XrTableCell7, Me.XrTableCell10, Me.XrTableCell12})
        Me.XrTableRow8.Name = "XrTableRow8"
        Me.XrTableRow8.Weight = 1.0R
        '
        'XrTableCell2
        '
        Me.XrTableCell2.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.XrTableCell2.Font = New DevExpress.Drawing.DXFont("Zona Pro Regular", 10.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrTableCell2.ForeColor = System.Drawing.Color.Gray
        Me.XrTableCell2.Multiline = True
        Me.XrTableCell2.Name = "XrTableCell2"
        Me.XrTableCell2.StylePriority.UseBackColor = False
        Me.XrTableCell2.StylePriority.UseFont = False
        Me.XrTableCell2.StylePriority.UseForeColor = False
        Me.XrTableCell2.StylePriority.UseTextAlignment = False
        Me.XrTableCell2.Text = "ΠΕΡΙΓΡΑΦΗ"
        Me.XrTableCell2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrTableCell2.Weight = 1.35560659942077R
        '
        'XrTableCell5
        '
        Me.XrTableCell5.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.XrTableCell5.Font = New DevExpress.Drawing.DXFont("Zona Pro Regular", 10.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrTableCell5.ForeColor = System.Drawing.Color.Gray
        Me.XrTableCell5.Multiline = True
        Me.XrTableCell5.Name = "XrTableCell5"
        Me.XrTableCell5.StylePriority.UseBackColor = False
        Me.XrTableCell5.StylePriority.UseFont = False
        Me.XrTableCell5.StylePriority.UseForeColor = False
        Me.XrTableCell5.StylePriority.UseTextAlignment = False
        Me.XrTableCell5.Text = "ΥΛΙΚΟ"
        Me.XrTableCell5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrTableCell5.Weight = 2.3624746271932575R
        '
        'XrTableCell7
        '
        Me.XrTableCell7.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.XrTableCell7.Font = New DevExpress.Drawing.DXFont("Zona Pro Regular", 10.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrTableCell7.ForeColor = System.Drawing.Color.Gray
        Me.XrTableCell7.Multiline = True
        Me.XrTableCell7.Name = "XrTableCell7"
        Me.XrTableCell7.StylePriority.UseBackColor = False
        Me.XrTableCell7.StylePriority.UseFont = False
        Me.XrTableCell7.StylePriority.UseForeColor = False
        Me.XrTableCell7.StylePriority.UseTextAlignment = False
        Me.XrTableCell7.Text = "ΤΙΜΗ ΥΛΙΚΟΥ"
        Me.XrTableCell7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrTableCell7.Weight = 1.0909568000502403R
        '
        'XrTableCell10
        '
        Me.XrTableCell10.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.XrTableCell10.Font = New DevExpress.Drawing.DXFont("Zona Pro Regular", 10.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrTableCell10.ForeColor = System.Drawing.Color.Gray
        Me.XrTableCell10.Multiline = True
        Me.XrTableCell10.Name = "XrTableCell10"
        Me.XrTableCell10.StylePriority.UseBackColor = False
        Me.XrTableCell10.StylePriority.UseFont = False
        Me.XrTableCell10.StylePriority.UseForeColor = False
        Me.XrTableCell10.StylePriority.UseTextAlignment = False
        Me.XrTableCell10.Text = "ΤΕΜ/ΤΡ.Μ."
        Me.XrTableCell10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrTableCell10.Weight = 1.0499509447912281R
        '
        'XrTableCell12
        '
        Me.XrTableCell12.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.XrTableCell12.Font = New DevExpress.Drawing.DXFont("Zona Pro Regular", 10.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrTableCell12.ForeColor = System.Drawing.Color.Gray
        Me.XrTableCell12.Multiline = True
        Me.XrTableCell12.Name = "XrTableCell12"
        Me.XrTableCell12.StylePriority.UseBackColor = False
        Me.XrTableCell12.StylePriority.UseFont = False
        Me.XrTableCell12.StylePriority.UseForeColor = False
        Me.XrTableCell12.StylePriority.UseTextAlignment = False
        Me.XrTableCell12.Text = "ΤΕΛΙΚΗ ΤΙΜΗ"
        Me.XrTableCell12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrTableCell12.Weight = 1.3799265220250976R
        '
        'XrTableRow9
        '
        Me.XrTableRow9.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell15, Me.XrTableCell17, Me.XrTableCell20, Me.XrTableCell22, Me.XrTableCell25})
        Me.XrTableRow9.Name = "XrTableRow9"
        Me.XrTableRow9.Weight = 1.0R
        '
        'XrTableCell15
        '
        Me.XrTableCell15.BackColor = System.Drawing.Color.Transparent
        Me.XrTableCell15.Font = New DevExpress.Drawing.DXFont("Zona Pro Regular", 10.0!)
        Me.XrTableCell15.ForeColor = System.Drawing.Color.Gray
        Me.XrTableCell15.Multiline = True
        Me.XrTableCell15.Name = "XrTableCell15"
        Me.XrTableCell15.StylePriority.UseBackColor = False
        Me.XrTableCell15.StylePriority.UseFont = False
        Me.XrTableCell15.StylePriority.UseForeColor = False
        Me.XrTableCell15.StylePriority.UseTextAlignment = False
        Me.XrTableCell15.Text = "ΒΑΣΕΩΣ"
        Me.XrTableCell15.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrTableCell15.Weight = 1.35560659942077R
        '
        'XrTableCell17
        '
        Me.XrTableCell17.BackColor = System.Drawing.Color.Transparent
        Me.XrTableCell17.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[VEPName]")})
        Me.XrTableCell17.Font = New DevExpress.Drawing.DXFont("Zona Pro Regular", 10.0!)
        Me.XrTableCell17.ForeColor = System.Drawing.Color.Gray
        Me.XrTableCell17.Multiline = True
        Me.XrTableCell17.Name = "XrTableCell17"
        Me.XrTableCell17.StylePriority.UseBackColor = False
        Me.XrTableCell17.StylePriority.UseFont = False
        Me.XrTableCell17.StylePriority.UseForeColor = False
        Me.XrTableCell17.StylePriority.UseTextAlignment = False
        Me.XrTableCell17.Text = "XrTableCell37"
        Me.XrTableCell17.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrTableCell17.Weight = 2.3624746271932575R
        '
        'XrTableCell20
        '
        Me.XrTableCell20.BackColor = System.Drawing.Color.Transparent
        Me.XrTableCell20.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[VEpendDoorPrice]")})
        Me.XrTableCell20.Font = New DevExpress.Drawing.DXFont("Zona Pro Regular", 10.0!)
        Me.XrTableCell20.ForeColor = System.Drawing.Color.Gray
        Me.XrTableCell20.Multiline = True
        Me.XrTableCell20.Name = "XrTableCell20"
        Me.XrTableCell20.StylePriority.UseBackColor = False
        Me.XrTableCell20.StylePriority.UseFont = False
        Me.XrTableCell20.StylePriority.UseForeColor = False
        Me.XrTableCell20.StylePriority.UseTextAlignment = False
        Me.XrTableCell20.Text = "XrTableCell6"
        Me.XrTableCell20.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrTableCell20.TextFormatString = "{0:C}"
        Me.XrTableCell20.Weight = 1.0909568000502403R
        '
        'XrTableCell22
        '
        Me.XrTableCell22.BackColor = System.Drawing.Color.Transparent
        Me.XrTableCell22.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[VEpendTrm]")})
        Me.XrTableCell22.Font = New DevExpress.Drawing.DXFont("Zona Pro Regular", 10.0!)
        Me.XrTableCell22.ForeColor = System.Drawing.Color.Gray
        Me.XrTableCell22.Multiline = True
        Me.XrTableCell22.Name = "XrTableCell22"
        Me.XrTableCell22.StylePriority.UseBackColor = False
        Me.XrTableCell22.StylePriority.UseFont = False
        Me.XrTableCell22.StylePriority.UseForeColor = False
        Me.XrTableCell22.StylePriority.UseTextAlignment = False
        Me.XrTableCell22.Text = "XrTableCell8"
        Me.XrTableCell22.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrTableCell22.TextFormatString = "{0}cm"
        Me.XrTableCell22.Weight = 1.0499509447912281R
        '
        'XrTableCell25
        '
        Me.XrTableCell25.BackColor = System.Drawing.Color.Transparent
        Me.XrTableCell25.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[VEpendPrice]")})
        Me.XrTableCell25.Font = New DevExpress.Drawing.DXFont("Zona Pro Regular", 10.0!)
        Me.XrTableCell25.ForeColor = System.Drawing.Color.Gray
        Me.XrTableCell25.Multiline = True
        Me.XrTableCell25.Name = "XrTableCell25"
        Me.XrTableCell25.StylePriority.UseBackColor = False
        Me.XrTableCell25.StylePriority.UseFont = False
        Me.XrTableCell25.StylePriority.UseForeColor = False
        Me.XrTableCell25.StylePriority.UseTextAlignment = False
        Me.XrTableCell25.Text = "XrTableCell9"
        Me.XrTableCell25.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrTableCell25.TextFormatString = "{0:C}"
        Me.XrTableCell25.Weight = 1.3799265220250976R
        '
        'XrTableRow10
        '
        Me.XrTableRow10.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell27, Me.XrTableCell30, Me.XrTableCell32, Me.XrTableCell35, Me.XrTableCell43})
        Me.XrTableRow10.Name = "XrTableRow10"
        Me.XrTableRow10.Weight = 1.0R
        '
        'XrTableCell27
        '
        Me.XrTableCell27.BackColor = System.Drawing.Color.Transparent
        Me.XrTableCell27.Font = New DevExpress.Drawing.DXFont("Zona Pro Regular", 10.0!)
        Me.XrTableCell27.ForeColor = System.Drawing.Color.Gray
        Me.XrTableCell27.Multiline = True
        Me.XrTableCell27.Name = "XrTableCell27"
        Me.XrTableCell27.StylePriority.UseBackColor = False
        Me.XrTableCell27.StylePriority.UseFont = False
        Me.XrTableCell27.StylePriority.UseForeColor = False
        Me.XrTableCell27.StylePriority.UseTextAlignment = False
        Me.XrTableCell27.Text = "ΝΗΣΙΔΑΣ"
        Me.XrTableCell27.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrTableCell27.Weight = 1.35560659942077R
        '
        'XrTableCell30
        '
        Me.XrTableCell30.BackColor = System.Drawing.Color.Transparent
        Me.XrTableCell30.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[NEPName]")})
        Me.XrTableCell30.Font = New DevExpress.Drawing.DXFont("Zona Pro Regular", 10.0!)
        Me.XrTableCell30.ForeColor = System.Drawing.Color.Gray
        Me.XrTableCell30.Multiline = True
        Me.XrTableCell30.Name = "XrTableCell30"
        Me.XrTableCell30.StylePriority.UseBackColor = False
        Me.XrTableCell30.StylePriority.UseFont = False
        Me.XrTableCell30.StylePriority.UseForeColor = False
        Me.XrTableCell30.StylePriority.UseTextAlignment = False
        Me.XrTableCell30.Text = "XrTableCell38"
        Me.XrTableCell30.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrTableCell30.Weight = 2.3624746271932575R
        '
        'XrTableCell32
        '
        Me.XrTableCell32.BackColor = System.Drawing.Color.Transparent
        Me.XrTableCell32.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[NEpendDoorPrice]")})
        Me.XrTableCell32.Font = New DevExpress.Drawing.DXFont("Zona Pro Regular", 10.0!)
        Me.XrTableCell32.ForeColor = System.Drawing.Color.Gray
        Me.XrTableCell32.Multiline = True
        Me.XrTableCell32.Name = "XrTableCell32"
        Me.XrTableCell32.StylePriority.UseBackColor = False
        Me.XrTableCell32.StylePriority.UseFont = False
        Me.XrTableCell32.StylePriority.UseForeColor = False
        Me.XrTableCell32.StylePriority.UseTextAlignment = False
        Me.XrTableCell32.Text = "XrTableCell11"
        Me.XrTableCell32.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrTableCell32.TextFormatString = "{0:C}"
        Me.XrTableCell32.Weight = 1.0909568000502403R
        '
        'XrTableCell35
        '
        Me.XrTableCell35.BackColor = System.Drawing.Color.Transparent
        Me.XrTableCell35.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[NEpendTrm]")})
        Me.XrTableCell35.Font = New DevExpress.Drawing.DXFont("Zona Pro Regular", 10.0!)
        Me.XrTableCell35.ForeColor = System.Drawing.Color.Gray
        Me.XrTableCell35.Multiline = True
        Me.XrTableCell35.Name = "XrTableCell35"
        Me.XrTableCell35.StylePriority.UseBackColor = False
        Me.XrTableCell35.StylePriority.UseFont = False
        Me.XrTableCell35.StylePriority.UseForeColor = False
        Me.XrTableCell35.StylePriority.UseTextAlignment = False
        Me.XrTableCell35.Text = "XrTableCell13"
        Me.XrTableCell35.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrTableCell35.TextFormatString = "{0}cm"
        Me.XrTableCell35.Weight = 1.0499509447912281R
        '
        'XrTableCell43
        '
        Me.XrTableCell43.BackColor = System.Drawing.Color.Transparent
        Me.XrTableCell43.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[NEpendPrice]")})
        Me.XrTableCell43.Font = New DevExpress.Drawing.DXFont("Zona Pro Regular", 10.0!)
        Me.XrTableCell43.ForeColor = System.Drawing.Color.Gray
        Me.XrTableCell43.Multiline = True
        Me.XrTableCell43.Name = "XrTableCell43"
        Me.XrTableCell43.StylePriority.UseBackColor = False
        Me.XrTableCell43.StylePriority.UseFont = False
        Me.XrTableCell43.StylePriority.UseForeColor = False
        Me.XrTableCell43.StylePriority.UseTextAlignment = False
        Me.XrTableCell43.Text = "XrTableCell14"
        Me.XrTableCell43.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrTableCell43.TextFormatString = "{0:C}"
        Me.XrTableCell43.Weight = 1.3799265220250976R
        '
        'XrTableRow11
        '
        Me.XrTableRow11.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell44, Me.XrTableCell45, Me.XrTableCell46, Me.XrTableCell47, Me.XrTableCell48})
        Me.XrTableRow11.Name = "XrTableRow11"
        Me.XrTableRow11.Weight = 1.0R
        '
        'XrTableCell44
        '
        Me.XrTableCell44.BackColor = System.Drawing.Color.Transparent
        Me.XrTableCell44.Font = New DevExpress.Drawing.DXFont("Zona Pro Regular", 10.0!)
        Me.XrTableCell44.ForeColor = System.Drawing.Color.Gray
        Me.XrTableCell44.Multiline = True
        Me.XrTableCell44.Name = "XrTableCell44"
        Me.XrTableCell44.StylePriority.UseBackColor = False
        Me.XrTableCell44.StylePriority.UseFont = False
        Me.XrTableCell44.StylePriority.UseForeColor = False
        Me.XrTableCell44.StylePriority.UseTextAlignment = False
        Me.XrTableCell44.Text = "ΡΑΦΙΕΡΑ"
        Me.XrTableCell44.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrTableCell44.Weight = 1.35560659942077R
        '
        'XrTableCell45
        '
        Me.XrTableCell45.BackColor = System.Drawing.Color.Transparent
        Me.XrTableCell45.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[VRAFName]")})
        Me.XrTableCell45.Font = New DevExpress.Drawing.DXFont("Zona Pro Regular", 10.0!)
        Me.XrTableCell45.ForeColor = System.Drawing.Color.Gray
        Me.XrTableCell45.Multiline = True
        Me.XrTableCell45.Name = "XrTableCell45"
        Me.XrTableCell45.StylePriority.UseBackColor = False
        Me.XrTableCell45.StylePriority.UseFont = False
        Me.XrTableCell45.StylePriority.UseForeColor = False
        Me.XrTableCell45.StylePriority.UseTextAlignment = False
        Me.XrTableCell45.Text = "XrTableCell39"
        Me.XrTableCell45.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrTableCell45.Weight = 2.3624746271932575R
        '
        'XrTableCell46
        '
        Me.XrTableCell46.BackColor = System.Drawing.Color.Transparent
        Me.XrTableCell46.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[VRafPrice]")})
        Me.XrTableCell46.Font = New DevExpress.Drawing.DXFont("Zona Pro Regular", 10.0!)
        Me.XrTableCell46.ForeColor = System.Drawing.Color.Gray
        Me.XrTableCell46.Multiline = True
        Me.XrTableCell46.Name = "XrTableCell46"
        Me.XrTableCell46.StylePriority.UseBackColor = False
        Me.XrTableCell46.StylePriority.UseFont = False
        Me.XrTableCell46.StylePriority.UseForeColor = False
        Me.XrTableCell46.StylePriority.UseTextAlignment = False
        Me.XrTableCell46.Text = "XrTableCell16"
        Me.XrTableCell46.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrTableCell46.TextFormatString = "{0:C}"
        Me.XrTableCell46.Weight = 1.0909568000502403R
        '
        'XrTableCell47
        '
        Me.XrTableCell47.BackColor = System.Drawing.Color.Transparent
        Me.XrTableCell47.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[VRafTem]")})
        Me.XrTableCell47.Font = New DevExpress.Drawing.DXFont("Zona Pro Regular", 10.0!)
        Me.XrTableCell47.ForeColor = System.Drawing.Color.Gray
        Me.XrTableCell47.Multiline = True
        Me.XrTableCell47.Name = "XrTableCell47"
        Me.XrTableCell47.StylePriority.UseBackColor = False
        Me.XrTableCell47.StylePriority.UseFont = False
        Me.XrTableCell47.StylePriority.UseForeColor = False
        Me.XrTableCell47.StylePriority.UseTextAlignment = False
        Me.XrTableCell47.Text = "XrTableCell18"
        Me.XrTableCell47.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrTableCell47.TextFormatString = "{0}"
        Me.XrTableCell47.Weight = 1.0499509447912281R
        '
        'XrTableCell48
        '
        Me.XrTableCell48.BackColor = System.Drawing.Color.Transparent
        Me.XrTableCell48.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[VTotRafPrice]")})
        Me.XrTableCell48.Font = New DevExpress.Drawing.DXFont("Zona Pro Regular", 10.0!)
        Me.XrTableCell48.ForeColor = System.Drawing.Color.Gray
        Me.XrTableCell48.Multiline = True
        Me.XrTableCell48.Name = "XrTableCell48"
        Me.XrTableCell48.StylePriority.UseBackColor = False
        Me.XrTableCell48.StylePriority.UseFont = False
        Me.XrTableCell48.StylePriority.UseForeColor = False
        Me.XrTableCell48.StylePriority.UseTextAlignment = False
        Me.XrTableCell48.Text = "XrTableCell19"
        Me.XrTableCell48.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrTableCell48.TextFormatString = "{0:C}"
        Me.XrTableCell48.Weight = 1.3799265220250976R
        '
        'XrTableRow12
        '
        Me.XrTableRow12.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell49, Me.XrTableCell57, Me.XrTableCell58, Me.XrTableCell59, Me.XrTableCell60})
        Me.XrTableRow12.Name = "XrTableRow12"
        Me.XrTableRow12.Weight = 1.0R
        '
        'XrTableCell49
        '
        Me.XrTableCell49.BackColor = System.Drawing.Color.Transparent
        Me.XrTableCell49.Font = New DevExpress.Drawing.DXFont("Zona Pro Regular", 10.0!)
        Me.XrTableCell49.ForeColor = System.Drawing.Color.Gray
        Me.XrTableCell49.Multiline = True
        Me.XrTableCell49.Name = "XrTableCell49"
        Me.XrTableCell49.StylePriority.UseBackColor = False
        Me.XrTableCell49.StylePriority.UseFont = False
        Me.XrTableCell49.StylePriority.UseForeColor = False
        Me.XrTableCell49.StylePriority.UseTextAlignment = False
        Me.XrTableCell49.Text = "ΚΡΕΜΑΣΤΩΝ"
        Me.XrTableCell49.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrTableCell49.Weight = 1.35560659942077R
        '
        'XrTableCell57
        '
        Me.XrTableCell57.BackColor = System.Drawing.Color.Transparent
        Me.XrTableCell57.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[KEPName]")})
        Me.XrTableCell57.Font = New DevExpress.Drawing.DXFont("Zona Pro Regular", 10.0!)
        Me.XrTableCell57.ForeColor = System.Drawing.Color.Gray
        Me.XrTableCell57.Multiline = True
        Me.XrTableCell57.Name = "XrTableCell57"
        Me.XrTableCell57.StylePriority.UseBackColor = False
        Me.XrTableCell57.StylePriority.UseFont = False
        Me.XrTableCell57.StylePriority.UseForeColor = False
        Me.XrTableCell57.StylePriority.UseTextAlignment = False
        Me.XrTableCell57.Text = "XrTableCell40"
        Me.XrTableCell57.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrTableCell57.Weight = 2.3624746271932575R
        '
        'XrTableCell58
        '
        Me.XrTableCell58.BackColor = System.Drawing.Color.Transparent
        Me.XrTableCell58.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[KEpendDoorPrice]")})
        Me.XrTableCell58.Font = New DevExpress.Drawing.DXFont("Zona Pro Regular", 10.0!)
        Me.XrTableCell58.ForeColor = System.Drawing.Color.Gray
        Me.XrTableCell58.Multiline = True
        Me.XrTableCell58.Name = "XrTableCell58"
        Me.XrTableCell58.StylePriority.UseBackColor = False
        Me.XrTableCell58.StylePriority.UseFont = False
        Me.XrTableCell58.StylePriority.UseForeColor = False
        Me.XrTableCell58.StylePriority.UseTextAlignment = False
        Me.XrTableCell58.Text = "XrTableCell21"
        Me.XrTableCell58.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrTableCell58.TextFormatString = "{0:C}"
        Me.XrTableCell58.Weight = 1.0909568000502403R
        '
        'XrTableCell59
        '
        Me.XrTableCell59.BackColor = System.Drawing.Color.Transparent
        Me.XrTableCell59.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[KEpendTrm]")})
        Me.XrTableCell59.Font = New DevExpress.Drawing.DXFont("Zona Pro Regular", 10.0!)
        Me.XrTableCell59.ForeColor = System.Drawing.Color.Gray
        Me.XrTableCell59.Multiline = True
        Me.XrTableCell59.Name = "XrTableCell59"
        Me.XrTableCell59.StylePriority.UseBackColor = False
        Me.XrTableCell59.StylePriority.UseFont = False
        Me.XrTableCell59.StylePriority.UseForeColor = False
        Me.XrTableCell59.StylePriority.UseTextAlignment = False
        Me.XrTableCell59.Text = "XrTableCell23"
        Me.XrTableCell59.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrTableCell59.TextFormatString = "{0}cm"
        Me.XrTableCell59.Weight = 1.0499509447912281R
        '
        'XrTableCell60
        '
        Me.XrTableCell60.BackColor = System.Drawing.Color.Transparent
        Me.XrTableCell60.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[KEpendPrice]")})
        Me.XrTableCell60.Font = New DevExpress.Drawing.DXFont("Zona Pro Regular", 10.0!)
        Me.XrTableCell60.ForeColor = System.Drawing.Color.Gray
        Me.XrTableCell60.Multiline = True
        Me.XrTableCell60.Name = "XrTableCell60"
        Me.XrTableCell60.StylePriority.UseBackColor = False
        Me.XrTableCell60.StylePriority.UseFont = False
        Me.XrTableCell60.StylePriority.UseForeColor = False
        Me.XrTableCell60.StylePriority.UseTextAlignment = False
        Me.XrTableCell60.Text = "XrTableCell24"
        Me.XrTableCell60.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrTableCell60.TextFormatString = "{0:C}"
        Me.XrTableCell60.Weight = 1.3799265220250976R
        '
        'XrTableRow13
        '
        Me.XrTableRow13.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell61, Me.XrTableCell62, Me.XrTableCell63, Me.XrTableCell64, Me.XrTableCell65})
        Me.XrTableRow13.Name = "XrTableRow13"
        Me.XrTableRow13.Weight = 1.0R
        '
        'XrTableCell61
        '
        Me.XrTableCell61.BackColor = System.Drawing.Color.Transparent
        Me.XrTableCell61.Font = New DevExpress.Drawing.DXFont("Zona Pro Regular", 10.0!)
        Me.XrTableCell61.ForeColor = System.Drawing.Color.Gray
        Me.XrTableCell61.Multiline = True
        Me.XrTableCell61.Name = "XrTableCell61"
        Me.XrTableCell61.StylePriority.UseBackColor = False
        Me.XrTableCell61.StylePriority.UseFont = False
        Me.XrTableCell61.StylePriority.UseForeColor = False
        Me.XrTableCell61.StylePriority.UseTextAlignment = False
        Me.XrTableCell61.Text = "2Η ΣΕΙΡΑΣ"
        Me.XrTableCell61.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrTableCell61.Weight = 1.35560659942077R
        '
        'XrTableCell62
        '
        Me.XrTableCell62.BackColor = System.Drawing.Color.Transparent
        Me.XrTableCell62.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[SNDName]")})
        Me.XrTableCell62.Font = New DevExpress.Drawing.DXFont("Zona Pro Regular", 10.0!)
        Me.XrTableCell62.ForeColor = System.Drawing.Color.Gray
        Me.XrTableCell62.Multiline = True
        Me.XrTableCell62.Name = "XrTableCell62"
        Me.XrTableCell62.StylePriority.UseBackColor = False
        Me.XrTableCell62.StylePriority.UseFont = False
        Me.XrTableCell62.StylePriority.UseForeColor = False
        Me.XrTableCell62.StylePriority.UseTextAlignment = False
        Me.XrTableCell62.Text = "XrTableCell41"
        Me.XrTableCell62.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrTableCell62.Weight = 2.3624746271932575R
        '
        'XrTableCell63
        '
        Me.XrTableCell63.BackColor = System.Drawing.Color.Transparent
        Me.XrTableCell63.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[SEpendDoorPrice]")})
        Me.XrTableCell63.Font = New DevExpress.Drawing.DXFont("Zona Pro Regular", 10.0!)
        Me.XrTableCell63.ForeColor = System.Drawing.Color.Gray
        Me.XrTableCell63.Multiline = True
        Me.XrTableCell63.Name = "XrTableCell63"
        Me.XrTableCell63.StylePriority.UseBackColor = False
        Me.XrTableCell63.StylePriority.UseFont = False
        Me.XrTableCell63.StylePriority.UseForeColor = False
        Me.XrTableCell63.StylePriority.UseTextAlignment = False
        Me.XrTableCell63.Text = "XrTableCell26"
        Me.XrTableCell63.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrTableCell63.TextFormatString = "{0:C}"
        Me.XrTableCell63.Weight = 1.0909568000502403R
        '
        'XrTableCell64
        '
        Me.XrTableCell64.BackColor = System.Drawing.Color.Transparent
        Me.XrTableCell64.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[SEpendTrm]")})
        Me.XrTableCell64.Font = New DevExpress.Drawing.DXFont("Zona Pro Regular", 10.0!)
        Me.XrTableCell64.ForeColor = System.Drawing.Color.Gray
        Me.XrTableCell64.Multiline = True
        Me.XrTableCell64.Name = "XrTableCell64"
        Me.XrTableCell64.StylePriority.UseBackColor = False
        Me.XrTableCell64.StylePriority.UseFont = False
        Me.XrTableCell64.StylePriority.UseForeColor = False
        Me.XrTableCell64.StylePriority.UseTextAlignment = False
        Me.XrTableCell64.Text = "XrTableCell28"
        Me.XrTableCell64.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrTableCell64.TextFormatString = "{0}cm"
        Me.XrTableCell64.Weight = 1.0499509447912281R
        '
        'XrTableCell65
        '
        Me.XrTableCell65.BackColor = System.Drawing.Color.Transparent
        Me.XrTableCell65.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[SEpendPrice]")})
        Me.XrTableCell65.Font = New DevExpress.Drawing.DXFont("Zona Pro Regular", 10.0!)
        Me.XrTableCell65.ForeColor = System.Drawing.Color.Gray
        Me.XrTableCell65.Multiline = True
        Me.XrTableCell65.Name = "XrTableCell65"
        Me.XrTableCell65.StylePriority.UseBackColor = False
        Me.XrTableCell65.StylePriority.UseFont = False
        Me.XrTableCell65.StylePriority.UseForeColor = False
        Me.XrTableCell65.StylePriority.UseTextAlignment = False
        Me.XrTableCell65.Text = "XrTableCell29"
        Me.XrTableCell65.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrTableCell65.TextFormatString = "{0:C}"
        Me.XrTableCell65.Weight = 1.3799265220250976R
        '
        'XrTableRow14
        '
        Me.XrTableRow14.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell66, Me.XrTableCell67, Me.XrTableCell68, Me.XrTableCell69, Me.XrTableCell70})
        Me.XrTableRow14.Name = "XrTableRow14"
        Me.XrTableRow14.Weight = 1.0R
        '
        'XrTableCell66
        '
        Me.XrTableCell66.BackColor = System.Drawing.Color.Transparent
        Me.XrTableCell66.Font = New DevExpress.Drawing.DXFont("Zona Pro Regular", 10.0!)
        Me.XrTableCell66.ForeColor = System.Drawing.Color.Gray
        Me.XrTableCell66.Multiline = True
        Me.XrTableCell66.Name = "XrTableCell66"
        Me.XrTableCell66.StylePriority.UseBackColor = False
        Me.XrTableCell66.StylePriority.UseFont = False
        Me.XrTableCell66.StylePriority.UseForeColor = False
        Me.XrTableCell66.StylePriority.UseTextAlignment = False
        Me.XrTableCell66.Text = "ΡΑΦΙΕΡΑ"
        Me.XrTableCell66.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrTableCell66.Weight = 1.35560659942077R
        '
        'XrTableCell67
        '
        Me.XrTableCell67.BackColor = System.Drawing.Color.Transparent
        Me.XrTableCell67.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[KRAFName]")})
        Me.XrTableCell67.Font = New DevExpress.Drawing.DXFont("Zona Pro Regular", 10.0!)
        Me.XrTableCell67.ForeColor = System.Drawing.Color.Gray
        Me.XrTableCell67.Multiline = True
        Me.XrTableCell67.Name = "XrTableCell67"
        Me.XrTableCell67.StylePriority.UseBackColor = False
        Me.XrTableCell67.StylePriority.UseFont = False
        Me.XrTableCell67.StylePriority.UseForeColor = False
        Me.XrTableCell67.StylePriority.UseTextAlignment = False
        Me.XrTableCell67.Text = "XrTableCell42"
        Me.XrTableCell67.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrTableCell67.Weight = 2.3624746271932575R
        '
        'XrTableCell68
        '
        Me.XrTableCell68.BackColor = System.Drawing.Color.Transparent
        Me.XrTableCell68.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[KRafPrice]")})
        Me.XrTableCell68.Font = New DevExpress.Drawing.DXFont("Zona Pro Regular", 10.0!)
        Me.XrTableCell68.ForeColor = System.Drawing.Color.Gray
        Me.XrTableCell68.Multiline = True
        Me.XrTableCell68.Name = "XrTableCell68"
        Me.XrTableCell68.StylePriority.UseBackColor = False
        Me.XrTableCell68.StylePriority.UseFont = False
        Me.XrTableCell68.StylePriority.UseForeColor = False
        Me.XrTableCell68.StylePriority.UseTextAlignment = False
        Me.XrTableCell68.Text = "XrTableCell31"
        Me.XrTableCell68.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrTableCell68.TextFormatString = "{0:C}"
        Me.XrTableCell68.Weight = 1.0909568000502403R
        '
        'XrTableCell69
        '
        Me.XrTableCell69.BackColor = System.Drawing.Color.Transparent
        Me.XrTableCell69.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[KRafTem]")})
        Me.XrTableCell69.Font = New DevExpress.Drawing.DXFont("Zona Pro Regular", 10.0!)
        Me.XrTableCell69.ForeColor = System.Drawing.Color.Gray
        Me.XrTableCell69.Multiline = True
        Me.XrTableCell69.Name = "XrTableCell69"
        Me.XrTableCell69.StylePriority.UseBackColor = False
        Me.XrTableCell69.StylePriority.UseFont = False
        Me.XrTableCell69.StylePriority.UseForeColor = False
        Me.XrTableCell69.StylePriority.UseTextAlignment = False
        Me.XrTableCell69.Text = "XrTableCell33"
        Me.XrTableCell69.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrTableCell69.TextFormatString = "{0}"
        Me.XrTableCell69.Weight = 1.0499509447912281R
        '
        'XrTableCell70
        '
        Me.XrTableCell70.BackColor = System.Drawing.Color.Transparent
        Me.XrTableCell70.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[KTotRafPrice]")})
        Me.XrTableCell70.Font = New DevExpress.Drawing.DXFont("Zona Pro Regular", 10.0!)
        Me.XrTableCell70.ForeColor = System.Drawing.Color.Gray
        Me.XrTableCell70.Multiline = True
        Me.XrTableCell70.Name = "XrTableCell70"
        Me.XrTableCell70.StylePriority.UseBackColor = False
        Me.XrTableCell70.StylePriority.UseFont = False
        Me.XrTableCell70.StylePriority.UseForeColor = False
        Me.XrTableCell70.StylePriority.UseTextAlignment = False
        Me.XrTableCell70.Text = "XrTableCell34"
        Me.XrTableCell70.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrTableCell70.TextFormatString = "{0:C}"
        Me.XrTableCell70.Weight = 1.3799265220250976R
        '
        'XrTableRow15
        '
        Me.XrTableRow15.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell71, Me.XrTableCell72, Me.XrTableCell73, Me.XrTableCell74, Me.XrTableCell75})
        Me.XrTableRow15.Name = "XrTableRow15"
        Me.XrTableRow15.Weight = 1.0R
        '
        'XrTableCell71
        '
        Me.XrTableCell71.BackColor = System.Drawing.Color.Transparent
        Me.XrTableCell71.Font = New DevExpress.Drawing.DXFont("Zona Pro Regular", 10.0!)
        Me.XrTableCell71.ForeColor = System.Drawing.Color.Gray
        Me.XrTableCell71.Multiline = True
        Me.XrTableCell71.Name = "XrTableCell71"
        Me.XrTableCell71.StylePriority.UseBackColor = False
        Me.XrTableCell71.StylePriority.UseFont = False
        Me.XrTableCell71.StylePriority.UseForeColor = False
        Me.XrTableCell71.StylePriority.UseTextAlignment = False
        Me.XrTableCell71.Text = "ΡΑΦΙΑ ΤΟΙΧΟΥ"
        Me.XrTableCell71.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrTableCell71.Weight = 1.35560659942077R
        '
        'XrTableCell72
        '
        Me.XrTableCell72.BackColor = System.Drawing.Color.Transparent
        Me.XrTableCell72.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[KWALName]")})
        Me.XrTableCell72.Font = New DevExpress.Drawing.DXFont("Zona Pro Regular", 10.0!)
        Me.XrTableCell72.ForeColor = System.Drawing.Color.Gray
        Me.XrTableCell72.Multiline = True
        Me.XrTableCell72.Name = "XrTableCell72"
        Me.XrTableCell72.StylePriority.UseBackColor = False
        Me.XrTableCell72.StylePriority.UseFont = False
        Me.XrTableCell72.StylePriority.UseForeColor = False
        Me.XrTableCell72.StylePriority.UseTextAlignment = False
        Me.XrTableCell72.Text = "XrTableCell72"
        Me.XrTableCell72.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrTableCell72.Weight = 2.3624746271932575R
        '
        'XrTableCell73
        '
        Me.XrTableCell73.BackColor = System.Drawing.Color.Transparent
        Me.XrTableCell73.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[WRafPrice]")})
        Me.XrTableCell73.Font = New DevExpress.Drawing.DXFont("Zona Pro Regular", 10.0!)
        Me.XrTableCell73.ForeColor = System.Drawing.Color.Gray
        Me.XrTableCell73.Multiline = True
        Me.XrTableCell73.Name = "XrTableCell73"
        Me.XrTableCell73.StylePriority.UseBackColor = False
        Me.XrTableCell73.StylePriority.UseFont = False
        Me.XrTableCell73.StylePriority.UseForeColor = False
        Me.XrTableCell73.StylePriority.UseTextAlignment = False
        Me.XrTableCell73.Text = "XrTableCell73"
        Me.XrTableCell73.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrTableCell73.TextFormatString = "{0:C}"
        Me.XrTableCell73.Weight = 1.0909568000502403R
        '
        'XrTableCell74
        '
        Me.XrTableCell74.BackColor = System.Drawing.Color.Transparent
        Me.XrTableCell74.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[WRafTem]")})
        Me.XrTableCell74.Font = New DevExpress.Drawing.DXFont("Zona Pro Regular", 10.0!)
        Me.XrTableCell74.ForeColor = System.Drawing.Color.Gray
        Me.XrTableCell74.Multiline = True
        Me.XrTableCell74.Name = "XrTableCell74"
        Me.XrTableCell74.StylePriority.UseBackColor = False
        Me.XrTableCell74.StylePriority.UseFont = False
        Me.XrTableCell74.StylePriority.UseForeColor = False
        Me.XrTableCell74.StylePriority.UseTextAlignment = False
        Me.XrTableCell74.Text = "XrTableCell74"
        Me.XrTableCell74.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrTableCell74.TextFormatString = "{0}"
        Me.XrTableCell74.Weight = 1.0499509447912281R
        '
        'XrTableCell75
        '
        Me.XrTableCell75.BackColor = System.Drawing.Color.Transparent
        Me.XrTableCell75.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[WTotRafPrice]")})
        Me.XrTableCell75.Font = New DevExpress.Drawing.DXFont("Zona Pro Regular", 10.0!)
        Me.XrTableCell75.ForeColor = System.Drawing.Color.Gray
        Me.XrTableCell75.Multiline = True
        Me.XrTableCell75.Name = "XrTableCell75"
        Me.XrTableCell75.StylePriority.UseBackColor = False
        Me.XrTableCell75.StylePriority.UseFont = False
        Me.XrTableCell75.StylePriority.UseForeColor = False
        Me.XrTableCell75.StylePriority.UseTextAlignment = False
        Me.XrTableCell75.Text = "XrTableCell75"
        Me.XrTableCell75.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrTableCell75.TextFormatString = "{0:C}"
        Me.XrTableCell75.Weight = 1.3799265220250976R
        '
        'XrTableRow16
        '
        Me.XrTableRow16.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell76, Me.XrTableCell77, Me.XrTableCell78, Me.XrTableCell79, Me.XrTableCell80})
        Me.XrTableRow16.Name = "XrTableRow16"
        Me.XrTableRow16.Weight = 1.0R
        '
        'XrTableCell76
        '
        Me.XrTableCell76.BackColor = System.Drawing.Color.Transparent
        Me.XrTableCell76.Font = New DevExpress.Drawing.DXFont("Zona Pro Regular", 10.0!)
        Me.XrTableCell76.ForeColor = System.Drawing.Color.Gray
        Me.XrTableCell76.Multiline = True
        Me.XrTableCell76.Name = "XrTableCell76"
        Me.XrTableCell76.StylePriority.UseBackColor = False
        Me.XrTableCell76.StylePriority.UseFont = False
        Me.XrTableCell76.StylePriority.UseForeColor = False
        Me.XrTableCell76.StylePriority.UseTextAlignment = False
        Me.XrTableCell76.Text = "ΠΛΑΪΝΑ ΥΨΗΛΑ"
        Me.XrTableCell76.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrTableCell76.Weight = 1.35560659942077R
        '
        'XrTableCell77
        '
        Me.XrTableCell77.BackColor = System.Drawing.Color.Transparent
        Me.XrTableCell77.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[PDEPName]")})
        Me.XrTableCell77.Font = New DevExpress.Drawing.DXFont("Zona Pro Regular", 10.0!)
        Me.XrTableCell77.ForeColor = System.Drawing.Color.Gray
        Me.XrTableCell77.Multiline = True
        Me.XrTableCell77.Name = "XrTableCell77"
        Me.XrTableCell77.StylePriority.UseBackColor = False
        Me.XrTableCell77.StylePriority.UseFont = False
        Me.XrTableCell77.StylePriority.UseForeColor = False
        Me.XrTableCell77.StylePriority.UseTextAlignment = False
        Me.XrTableCell77.Text = "XrTableCell77"
        Me.XrTableCell77.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrTableCell77.Weight = 2.3624746271932575R
        '
        'XrTableCell78
        '
        Me.XrTableCell78.BackColor = System.Drawing.Color.Transparent
        Me.XrTableCell78.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[YEpendDoorPrice]")})
        Me.XrTableCell78.Font = New DevExpress.Drawing.DXFont("Zona Pro Regular", 10.0!)
        Me.XrTableCell78.ForeColor = System.Drawing.Color.Gray
        Me.XrTableCell78.Multiline = True
        Me.XrTableCell78.Name = "XrTableCell78"
        Me.XrTableCell78.StylePriority.UseBackColor = False
        Me.XrTableCell78.StylePriority.UseFont = False
        Me.XrTableCell78.StylePriority.UseForeColor = False
        Me.XrTableCell78.StylePriority.UseTextAlignment = False
        Me.XrTableCell78.Text = "XrTableCell78"
        Me.XrTableCell78.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrTableCell78.TextFormatString = "{0:C}"
        Me.XrTableCell78.Weight = 1.0941979627911933R
        '
        'XrTableCell79
        '
        Me.XrTableCell79.BackColor = System.Drawing.Color.Transparent
        Me.XrTableCell79.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[YEpendTrm]")})
        Me.XrTableCell79.Font = New DevExpress.Drawing.DXFont("Zona Pro Regular", 10.0!)
        Me.XrTableCell79.ForeColor = System.Drawing.Color.Gray
        Me.XrTableCell79.Multiline = True
        Me.XrTableCell79.Name = "XrTableCell79"
        Me.XrTableCell79.StylePriority.UseBackColor = False
        Me.XrTableCell79.StylePriority.UseFont = False
        Me.XrTableCell79.StylePriority.UseForeColor = False
        Me.XrTableCell79.StylePriority.UseTextAlignment = False
        Me.XrTableCell79.Text = "XrTableCell79"
        Me.XrTableCell79.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrTableCell79.Weight = 1.0499509447912281R
        '
        'XrTableCell80
        '
        Me.XrTableCell80.BackColor = System.Drawing.Color.Transparent
        Me.XrTableCell80.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[YEpendPrice]")})
        Me.XrTableCell80.Font = New DevExpress.Drawing.DXFont("Zona Pro Regular", 10.0!)
        Me.XrTableCell80.ForeColor = System.Drawing.Color.Gray
        Me.XrTableCell80.Multiline = True
        Me.XrTableCell80.Name = "XrTableCell80"
        Me.XrTableCell80.StylePriority.UseBackColor = False
        Me.XrTableCell80.StylePriority.UseFont = False
        Me.XrTableCell80.StylePriority.UseForeColor = False
        Me.XrTableCell80.StylePriority.UseTextAlignment = False
        Me.XrTableCell80.Text = "XrTableCell80"
        Me.XrTableCell80.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrTableCell80.TextFormatString = "{0:C}"
        Me.XrTableCell80.Weight = 1.3766853592841446R
        '
        'XrTableRow17
        '
        Me.XrTableRow17.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell81, Me.XrTableCell82, Me.XrTableCell83, Me.XrTableCell84, Me.XrTableCell85})
        Me.XrTableRow17.Name = "XrTableRow17"
        Me.XrTableRow17.Weight = 1.0R
        '
        'XrTableCell81
        '
        Me.XrTableCell81.BackColor = System.Drawing.Color.Transparent
        Me.XrTableCell81.Font = New DevExpress.Drawing.DXFont("Zona Pro Regular", 10.0!)
        Me.XrTableCell81.ForeColor = System.Drawing.Color.Gray
        Me.XrTableCell81.Multiline = True
        Me.XrTableCell81.Name = "XrTableCell81"
        Me.XrTableCell81.StylePriority.UseBackColor = False
        Me.XrTableCell81.StylePriority.UseFont = False
        Me.XrTableCell81.StylePriority.UseForeColor = False
        Me.XrTableCell81.StylePriority.UseTextAlignment = False
        Me.XrTableCell81.Text = "ΡΑΦΙΕΡΑ"
        Me.XrTableCell81.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrTableCell81.Weight = 1.35560659942077R
        '
        'XrTableCell82
        '
        Me.XrTableCell82.BackColor = System.Drawing.Color.Transparent
        Me.XrTableCell82.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[YRAFName]")})
        Me.XrTableCell82.Font = New DevExpress.Drawing.DXFont("Zona Pro Regular", 10.0!)
        Me.XrTableCell82.ForeColor = System.Drawing.Color.Gray
        Me.XrTableCell82.Multiline = True
        Me.XrTableCell82.Name = "XrTableCell82"
        Me.XrTableCell82.StylePriority.UseBackColor = False
        Me.XrTableCell82.StylePriority.UseFont = False
        Me.XrTableCell82.StylePriority.UseForeColor = False
        Me.XrTableCell82.StylePriority.UseTextAlignment = False
        Me.XrTableCell82.Text = "XrTableCell82"
        Me.XrTableCell82.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrTableCell82.Weight = 2.3514614663661071R
        '
        'XrTableCell83
        '
        Me.XrTableCell83.BackColor = System.Drawing.Color.Transparent
        Me.XrTableCell83.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[YRafPrice]")})
        Me.XrTableCell83.Font = New DevExpress.Drawing.DXFont("Zona Pro Regular", 10.0!)
        Me.XrTableCell83.ForeColor = System.Drawing.Color.Gray
        Me.XrTableCell83.Multiline = True
        Me.XrTableCell83.Name = "XrTableCell83"
        Me.XrTableCell83.StylePriority.UseBackColor = False
        Me.XrTableCell83.StylePriority.UseFont = False
        Me.XrTableCell83.StylePriority.UseForeColor = False
        Me.XrTableCell83.StylePriority.UseTextAlignment = False
        Me.XrTableCell83.Text = "XrTableCell83"
        Me.XrTableCell83.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrTableCell83.TextFormatString = "{0:C}"
        Me.XrTableCell83.Weight = 1.0909568000502403R
        '
        'XrTableCell84
        '
        Me.XrTableCell84.BackColor = System.Drawing.Color.Transparent
        Me.XrTableCell84.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[YRafTem]")})
        Me.XrTableCell84.Font = New DevExpress.Drawing.DXFont("Zona Pro Regular", 10.0!)
        Me.XrTableCell84.ForeColor = System.Drawing.Color.Gray
        Me.XrTableCell84.Multiline = True
        Me.XrTableCell84.Name = "XrTableCell84"
        Me.XrTableCell84.StylePriority.UseBackColor = False
        Me.XrTableCell84.StylePriority.UseFont = False
        Me.XrTableCell84.StylePriority.UseForeColor = False
        Me.XrTableCell84.StylePriority.UseTextAlignment = False
        Me.XrTableCell84.Text = "XrTableCell84"
        Me.XrTableCell84.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrTableCell84.TextFormatString = "{0}"
        Me.XrTableCell84.Weight = 1.0468409166370298R
        '
        'XrTableCell85
        '
        Me.XrTableCell85.BackColor = System.Drawing.Color.Transparent
        Me.XrTableCell85.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[YTotRafPrice]")})
        Me.XrTableCell85.Font = New DevExpress.Drawing.DXFont("Zona Pro Regular", 10.0!)
        Me.XrTableCell85.ForeColor = System.Drawing.Color.Gray
        Me.XrTableCell85.Multiline = True
        Me.XrTableCell85.Name = "XrTableCell85"
        Me.XrTableCell85.StylePriority.UseBackColor = False
        Me.XrTableCell85.StylePriority.UseFont = False
        Me.XrTableCell85.StylePriority.UseForeColor = False
        Me.XrTableCell85.StylePriority.UseTextAlignment = False
        Me.XrTableCell85.Text = "XrTableCell85"
        Me.XrTableCell85.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrTableCell85.TextFormatString = "{0:C}"
        Me.XrTableCell85.Weight = 1.3726073418486045R
        '
        'XrTableRow25
        '
        Me.XrTableRow25.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell121, Me.XrTableCell122})
        Me.XrTableRow25.Name = "XrTableRow25"
        Me.XrTableRow25.Weight = 1.0R
        '
        'XrTableCell121
        '
        Me.XrTableCell121.BackColor = System.Drawing.Color.Transparent
        Me.XrTableCell121.Font = New DevExpress.Drawing.DXFont("Zona Pro Regular", 10.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrTableCell121.ForeColor = System.Drawing.Color.Gray
        Me.XrTableCell121.Multiline = True
        Me.XrTableCell121.Name = "XrTableCell121"
        Me.XrTableCell121.StylePriority.UseBackColor = False
        Me.XrTableCell121.StylePriority.UseFont = False
        Me.XrTableCell121.StylePriority.UseForeColor = False
        Me.XrTableCell121.StylePriority.UseTextAlignment = False
        Me.XrTableCell121.Text = "ΣΥΝΟΛΟ"
        Me.XrTableCell121.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrTableCell121.Weight = 5.8448657824741472R
        '
        'XrTableCell122
        '
        Me.XrTableCell122.BackColor = System.Drawing.Color.Transparent
        Me.XrTableCell122.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[TotKEpendRaf]")})
        Me.XrTableCell122.Font = New DevExpress.Drawing.DXFont("Zona Pro Regular", 10.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrTableCell122.ForeColor = System.Drawing.Color.Gray
        Me.XrTableCell122.Multiline = True
        Me.XrTableCell122.Name = "XrTableCell122"
        Me.XrTableCell122.StylePriority.UseBackColor = False
        Me.XrTableCell122.StylePriority.UseFont = False
        Me.XrTableCell122.StylePriority.UseForeColor = False
        Me.XrTableCell122.StylePriority.UseTextAlignment = False
        Me.XrTableCell122.Text = "XrTableCell122"
        Me.XrTableCell122.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrTableCell122.TextFormatString = "{0:C}"
        Me.XrTableCell122.Weight = 1.3726073418486045R
        '
        'XrLabel2
        '
        Me.XrLabel2.BackColor = System.Drawing.Color.White
        Me.XrLabel2.Font = New DevExpress.Drawing.DXFont("Zona Pro", 12.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(113, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.XrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(1.999878!, 389.5059!)
        Me.XrLabel2.Name = "XrLabel2"
        Me.XrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.XrLabel2.SizeF = New System.Drawing.SizeF(625.0001!, 20.83333!)
        Me.XrLabel2.StylePriority.UseBackColor = False
        Me.XrLabel2.StylePriority.UseFont = False
        Me.XrLabel2.StylePriority.UseForeColor = False
        Me.XrLabel2.StylePriority.UsePadding = False
        Me.XrLabel2.StylePriority.UseTextAlignment = False
        Me.XrLabel2.Text = "ΠΛΑΪΝΑ-ΕΠΕΝΔΥΣΕΙΣ"
        Me.XrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel3
        '
        Me.XrLabel3.BackColor = System.Drawing.Color.White
        Me.XrLabel3.Font = New DevExpress.Drawing.DXFont("Zona Pro", 12.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrLabel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(113, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.XrLabel3.LocationFloat = New DevExpress.Utils.PointFloat(1.999878!, 685.3392!)
        Me.XrLabel3.Name = "XrLabel3"
        Me.XrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.XrLabel3.SizeF = New System.Drawing.SizeF(625.0001!, 20.83333!)
        Me.XrLabel3.StylePriority.UseBackColor = False
        Me.XrLabel3.StylePriority.UseFont = False
        Me.XrLabel3.StylePriority.UseForeColor = False
        Me.XrLabel3.StylePriority.UsePadding = False
        Me.XrLabel3.StylePriority.UseTextAlignment = False
        Me.XrLabel3.Text = "ΠΑΓΚΟΙ-ΠΛΑΤΕΣ"
        Me.XrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrTable3
        '
        Me.XrTable3.BorderColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(113, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.XrTable3.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTable3.LocationFloat = New DevExpress.Utils.PointFloat(0.000181675!, 706.1724!)
        Me.XrTable3.Name = "XrTable3"
        Me.XrTable3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96.0!)
        Me.XrTable3.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow18, Me.XrTableRow19, Me.XrTableRow20, Me.XrTableRow21, Me.XrTableRow26})
        Me.XrTable3.SizeF = New System.Drawing.SizeF(625.0003!, 125.0!)
        Me.XrTable3.StylePriority.UseBorderColor = False
        Me.XrTable3.StylePriority.UseBorders = False
        '
        'XrTableRow18
        '
        Me.XrTableRow18.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell86, Me.XrTableCell87, Me.XrTableCell88, Me.XrTableCell89, Me.XrTableCell90})
        Me.XrTableRow18.Name = "XrTableRow18"
        Me.XrTableRow18.Weight = 1.0R
        '
        'XrTableCell86
        '
        Me.XrTableCell86.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.XrTableCell86.Font = New DevExpress.Drawing.DXFont("Zona Pro Regular", 10.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrTableCell86.ForeColor = System.Drawing.Color.Gray
        Me.XrTableCell86.Multiline = True
        Me.XrTableCell86.Name = "XrTableCell86"
        Me.XrTableCell86.StylePriority.UseBackColor = False
        Me.XrTableCell86.StylePriority.UseFont = False
        Me.XrTableCell86.StylePriority.UseForeColor = False
        Me.XrTableCell86.StylePriority.UseTextAlignment = False
        Me.XrTableCell86.Text = "ΠΕΡΙΓΡΑΦΗ"
        Me.XrTableCell86.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrTableCell86.Weight = 1.1998139875904392R
        '
        'XrTableCell87
        '
        Me.XrTableCell87.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.XrTableCell87.Font = New DevExpress.Drawing.DXFont("Zona Pro Regular", 10.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrTableCell87.ForeColor = System.Drawing.Color.Gray
        Me.XrTableCell87.Multiline = True
        Me.XrTableCell87.Name = "XrTableCell87"
        Me.XrTableCell87.StylePriority.UseBackColor = False
        Me.XrTableCell87.StylePriority.UseFont = False
        Me.XrTableCell87.StylePriority.UseForeColor = False
        Me.XrTableCell87.StylePriority.UseTextAlignment = False
        Me.XrTableCell87.Text = "ΥΛΙΚΟ"
        Me.XrTableCell87.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrTableCell87.Weight = 2.1342503659669942R
        '
        'XrTableCell88
        '
        Me.XrTableCell88.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.XrTableCell88.Font = New DevExpress.Drawing.DXFont("Zona Pro Regular", 10.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrTableCell88.ForeColor = System.Drawing.Color.Gray
        Me.XrTableCell88.Multiline = True
        Me.XrTableCell88.Name = "XrTableCell88"
        Me.XrTableCell88.StylePriority.UseBackColor = False
        Me.XrTableCell88.StylePriority.UseFont = False
        Me.XrTableCell88.StylePriority.UseForeColor = False
        Me.XrTableCell88.StylePriority.UseTextAlignment = False
        Me.XrTableCell88.Text = "ΤΙΜΗ ΥΛΙΚΟΥ"
        Me.XrTableCell88.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrTableCell88.Weight = 0.9760257872718886R
        '
        'XrTableCell89
        '
        Me.XrTableCell89.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.XrTableCell89.Font = New DevExpress.Drawing.DXFont("Zona Pro Regular", 10.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrTableCell89.ForeColor = System.Drawing.Color.Gray
        Me.XrTableCell89.Multiline = True
        Me.XrTableCell89.Name = "XrTableCell89"
        Me.XrTableCell89.StylePriority.UseBackColor = False
        Me.XrTableCell89.StylePriority.UseFont = False
        Me.XrTableCell89.StylePriority.UseForeColor = False
        Me.XrTableCell89.StylePriority.UseTextAlignment = False
        Me.XrTableCell89.Text = "ΤΕΜ/ΤΡ.Μ."
        Me.XrTableCell89.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrTableCell89.Weight = 0.93822613851573722R
        '
        'XrTableCell90
        '
        Me.XrTableCell90.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.XrTableCell90.Font = New DevExpress.Drawing.DXFont("Zona Pro Regular", 10.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrTableCell90.ForeColor = System.Drawing.Color.Gray
        Me.XrTableCell90.Multiline = True
        Me.XrTableCell90.Name = "XrTableCell90"
        Me.XrTableCell90.StylePriority.UseBackColor = False
        Me.XrTableCell90.StylePriority.UseFont = False
        Me.XrTableCell90.StylePriority.UseForeColor = False
        Me.XrTableCell90.StylePriority.UseTextAlignment = False
        Me.XrTableCell90.Text = "ΤΕΛΙΚΗ ΤΙΜΗ"
        Me.XrTableCell90.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrTableCell90.Weight = 1.2203090688250462R
        '
        'XrTableRow19
        '
        Me.XrTableRow19.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell91, Me.XrTableCell92, Me.XrTableCell93, Me.XrTableCell94, Me.XrTableCell95})
        Me.XrTableRow19.Name = "XrTableRow19"
        Me.XrTableRow19.Weight = 1.0R
        '
        'XrTableCell91
        '
        Me.XrTableCell91.BackColor = System.Drawing.Color.Transparent
        Me.XrTableCell91.Font = New DevExpress.Drawing.DXFont("Zona Pro Regular", 10.0!)
        Me.XrTableCell91.ForeColor = System.Drawing.Color.Gray
        Me.XrTableCell91.Multiline = True
        Me.XrTableCell91.Name = "XrTableCell91"
        Me.XrTableCell91.StylePriority.UseBackColor = False
        Me.XrTableCell91.StylePriority.UseFont = False
        Me.XrTableCell91.StylePriority.UseForeColor = False
        Me.XrTableCell91.StylePriority.UseTextAlignment = False
        Me.XrTableCell91.Text = "ΠΑΓΚΟΙ"
        Me.XrTableCell91.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrTableCell91.Weight = 1.3325141327514347R
        '
        'XrTableCell92
        '
        Me.XrTableCell92.BackColor = System.Drawing.Color.Transparent
        Me.XrTableCell92.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[BenchName1]")})
        Me.XrTableCell92.Font = New DevExpress.Drawing.DXFont("Zona Pro Regular", 10.0!)
        Me.XrTableCell92.ForeColor = System.Drawing.Color.Gray
        Me.XrTableCell92.Multiline = True
        Me.XrTableCell92.Name = "XrTableCell92"
        Me.XrTableCell92.StylePriority.UseBackColor = False
        Me.XrTableCell92.StylePriority.UseFont = False
        Me.XrTableCell92.StylePriority.UseForeColor = False
        Me.XrTableCell92.StylePriority.UseTextAlignment = False
        Me.XrTableCell92.Text = "XrTableCell37"
        Me.XrTableCell92.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrTableCell92.Weight = 2.3702995904568218R
        '
        'XrTableCell93
        '
        Me.XrTableCell93.BackColor = System.Drawing.Color.Transparent
        Me.XrTableCell93.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[BenchDoorPrice1]")})
        Me.XrTableCell93.Font = New DevExpress.Drawing.DXFont("Zona Pro Regular", 10.0!)
        Me.XrTableCell93.ForeColor = System.Drawing.Color.Gray
        Me.XrTableCell93.Multiline = True
        Me.XrTableCell93.Name = "XrTableCell93"
        Me.XrTableCell93.StylePriority.UseBackColor = False
        Me.XrTableCell93.StylePriority.UseFont = False
        Me.XrTableCell93.StylePriority.UseForeColor = False
        Me.XrTableCell93.StylePriority.UseTextAlignment = False
        Me.XrTableCell93.Text = "XrTableCell6"
        Me.XrTableCell93.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrTableCell93.TextFormatString = "{0:C}"
        Me.XrTableCell93.Weight = 1.0839746961997945R
        '
        'XrTableCell94
        '
        Me.XrTableCell94.BackColor = System.Drawing.Color.Transparent
        Me.XrTableCell94.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[BenchTem1]")})
        Me.XrTableCell94.Font = New DevExpress.Drawing.DXFont("Zona Pro Regular", 10.0!)
        Me.XrTableCell94.ForeColor = System.Drawing.Color.Gray
        Me.XrTableCell94.Multiline = True
        Me.XrTableCell94.Name = "XrTableCell94"
        Me.XrTableCell94.StylePriority.UseBackColor = False
        Me.XrTableCell94.StylePriority.UseFont = False
        Me.XrTableCell94.StylePriority.UseForeColor = False
        Me.XrTableCell94.StylePriority.UseTextAlignment = False
        Me.XrTableCell94.Text = "XrTableCell8"
        Me.XrTableCell94.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrTableCell94.TextFormatString = "{0}"
        Me.XrTableCell94.Weight = 1.0407575134332627R
        '
        'XrTableCell95
        '
        Me.XrTableCell95.BackColor = System.Drawing.Color.Transparent
        Me.XrTableCell95.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[BenchPrice1]")})
        Me.XrTableCell95.Font = New DevExpress.Drawing.DXFont("Zona Pro Regular", 10.0!)
        Me.XrTableCell95.ForeColor = System.Drawing.Color.Gray
        Me.XrTableCell95.Multiline = True
        Me.XrTableCell95.Name = "XrTableCell95"
        Me.XrTableCell95.StylePriority.UseBackColor = False
        Me.XrTableCell95.StylePriority.UseFont = False
        Me.XrTableCell95.StylePriority.UseForeColor = False
        Me.XrTableCell95.StylePriority.UseTextAlignment = False
        Me.XrTableCell95.Text = "XrTableCell9"
        Me.XrTableCell95.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrTableCell95.TextFormatString = "{0:C}"
        Me.XrTableCell95.Weight = 1.3479849284031831R
        '
        'XrTableRow20
        '
        Me.XrTableRow20.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell96, Me.XrTableCell97, Me.XrTableCell98, Me.XrTableCell99, Me.XrTableCell100})
        Me.XrTableRow20.Name = "XrTableRow20"
        Me.XrTableRow20.Weight = 1.0R
        '
        'XrTableCell96
        '
        Me.XrTableCell96.BackColor = System.Drawing.Color.Transparent
        Me.XrTableCell96.Font = New DevExpress.Drawing.DXFont("Zona Pro Regular", 10.0!)
        Me.XrTableCell96.ForeColor = System.Drawing.Color.Gray
        Me.XrTableCell96.Multiline = True
        Me.XrTableCell96.Name = "XrTableCell96"
        Me.XrTableCell96.StylePriority.UseBackColor = False
        Me.XrTableCell96.StylePriority.UseFont = False
        Me.XrTableCell96.StylePriority.UseForeColor = False
        Me.XrTableCell96.StylePriority.UseTextAlignment = False
        Me.XrTableCell96.Text = "ΤΡΑΠΕΖΙΑ"
        Me.XrTableCell96.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrTableCell96.Weight = 1.3325141327514347R
        '
        'XrTableCell97
        '
        Me.XrTableCell97.BackColor = System.Drawing.Color.Transparent
        Me.XrTableCell97.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[BenchName2]")})
        Me.XrTableCell97.Font = New DevExpress.Drawing.DXFont("Zona Pro Regular", 10.0!)
        Me.XrTableCell97.ForeColor = System.Drawing.Color.Gray
        Me.XrTableCell97.Multiline = True
        Me.XrTableCell97.Name = "XrTableCell97"
        Me.XrTableCell97.StylePriority.UseBackColor = False
        Me.XrTableCell97.StylePriority.UseFont = False
        Me.XrTableCell97.StylePriority.UseForeColor = False
        Me.XrTableCell97.StylePriority.UseTextAlignment = False
        Me.XrTableCell97.Text = "XrTableCell38"
        Me.XrTableCell97.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrTableCell97.Weight = 2.3779344849110617R
        '
        'XrTableCell98
        '
        Me.XrTableCell98.BackColor = System.Drawing.Color.Transparent
        Me.XrTableCell98.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[BenchDoorPrice2]")})
        Me.XrTableCell98.Font = New DevExpress.Drawing.DXFont("Zona Pro Regular", 10.0!)
        Me.XrTableCell98.ForeColor = System.Drawing.Color.Gray
        Me.XrTableCell98.Multiline = True
        Me.XrTableCell98.Name = "XrTableCell98"
        Me.XrTableCell98.StylePriority.UseBackColor = False
        Me.XrTableCell98.StylePriority.UseFont = False
        Me.XrTableCell98.StylePriority.UseForeColor = False
        Me.XrTableCell98.StylePriority.UseTextAlignment = False
        Me.XrTableCell98.Text = "XrTableCell11"
        Me.XrTableCell98.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrTableCell98.TextFormatString = "{0:C}"
        Me.XrTableCell98.Weight = 1.0874663151488642R
        '
        'XrTableCell99
        '
        Me.XrTableCell99.BackColor = System.Drawing.Color.Transparent
        Me.XrTableCell99.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[BenchTem2]")})
        Me.XrTableCell99.Font = New DevExpress.Drawing.DXFont("Zona Pro Regular", 10.0!)
        Me.XrTableCell99.ForeColor = System.Drawing.Color.Gray
        Me.XrTableCell99.Multiline = True
        Me.XrTableCell99.Name = "XrTableCell99"
        Me.XrTableCell99.StylePriority.UseBackColor = False
        Me.XrTableCell99.StylePriority.UseFont = False
        Me.XrTableCell99.StylePriority.UseForeColor = False
        Me.XrTableCell99.StylePriority.UseTextAlignment = False
        Me.XrTableCell99.Text = "XrTableCell13"
        Me.XrTableCell99.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrTableCell99.TextFormatString = "{0}"
        Me.XrTableCell99.Weight = 1.0434915616698974R
        '
        'XrTableCell100
        '
        Me.XrTableCell100.BackColor = System.Drawing.Color.Transparent
        Me.XrTableCell100.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[BenchPrice2]")})
        Me.XrTableCell100.Font = New DevExpress.Drawing.DXFont("Zona Pro Regular", 10.0!)
        Me.XrTableCell100.ForeColor = System.Drawing.Color.Gray
        Me.XrTableCell100.Multiline = True
        Me.XrTableCell100.Name = "XrTableCell100"
        Me.XrTableCell100.StylePriority.UseBackColor = False
        Me.XrTableCell100.StylePriority.UseFont = False
        Me.XrTableCell100.StylePriority.UseForeColor = False
        Me.XrTableCell100.StylePriority.UseTextAlignment = False
        Me.XrTableCell100.Text = "XrTableCell14"
        Me.XrTableCell100.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrTableCell100.TextFormatString = "{0:C}"
        Me.XrTableCell100.Weight = 1.352974251276035R
        '
        'XrTableRow21
        '
        Me.XrTableRow21.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell101, Me.XrTableCell102, Me.XrTableCell103, Me.XrTableCell104, Me.XrTableCell105})
        Me.XrTableRow21.Name = "XrTableRow21"
        Me.XrTableRow21.Weight = 1.0R
        '
        'XrTableCell101
        '
        Me.XrTableCell101.BackColor = System.Drawing.Color.Transparent
        Me.XrTableCell101.Font = New DevExpress.Drawing.DXFont("Zona Pro Regular", 10.0!)
        Me.XrTableCell101.ForeColor = System.Drawing.Color.Gray
        Me.XrTableCell101.Multiline = True
        Me.XrTableCell101.Name = "XrTableCell101"
        Me.XrTableCell101.StylePriority.UseBackColor = False
        Me.XrTableCell101.StylePriority.UseFont = False
        Me.XrTableCell101.StylePriority.UseForeColor = False
        Me.XrTableCell101.StylePriority.UseTextAlignment = False
        Me.XrTableCell101.Text = "ΠΛΑΤΕΣ"
        Me.XrTableCell101.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrTableCell101.Weight = 1.3325141327514347R
        '
        'XrTableCell102
        '
        Me.XrTableCell102.BackColor = System.Drawing.Color.Transparent
        Me.XrTableCell102.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[BackName]")})
        Me.XrTableCell102.Font = New DevExpress.Drawing.DXFont("Zona Pro Regular", 10.0!)
        Me.XrTableCell102.ForeColor = System.Drawing.Color.Gray
        Me.XrTableCell102.Multiline = True
        Me.XrTableCell102.Name = "XrTableCell102"
        Me.XrTableCell102.StylePriority.UseBackColor = False
        Me.XrTableCell102.StylePriority.UseFont = False
        Me.XrTableCell102.StylePriority.UseForeColor = False
        Me.XrTableCell102.StylePriority.UseTextAlignment = False
        Me.XrTableCell102.Text = "XrTableCell39"
        Me.XrTableCell102.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrTableCell102.Weight = 2.3855670938625928R
        '
        'XrTableCell103
        '
        Me.XrTableCell103.BackColor = System.Drawing.Color.Transparent
        Me.XrTableCell103.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[BackDoorPrice]")})
        Me.XrTableCell103.Font = New DevExpress.Drawing.DXFont("Zona Pro Regular", 10.0!)
        Me.XrTableCell103.ForeColor = System.Drawing.Color.Gray
        Me.XrTableCell103.Multiline = True
        Me.XrTableCell103.Name = "XrTableCell103"
        Me.XrTableCell103.StylePriority.UseBackColor = False
        Me.XrTableCell103.StylePriority.UseFont = False
        Me.XrTableCell103.StylePriority.UseForeColor = False
        Me.XrTableCell103.StylePriority.UseTextAlignment = False
        Me.XrTableCell103.Text = "XrTableCell16"
        Me.XrTableCell103.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrTableCell103.TextFormatString = "{0:C}"
        Me.XrTableCell103.Weight = 1.0909568000502403R
        '
        'XrTableCell104
        '
        Me.XrTableCell104.BackColor = System.Drawing.Color.Transparent
        Me.XrTableCell104.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[BackTem]")})
        Me.XrTableCell104.Font = New DevExpress.Drawing.DXFont("Zona Pro Regular", 10.0!)
        Me.XrTableCell104.ForeColor = System.Drawing.Color.Gray
        Me.XrTableCell104.Multiline = True
        Me.XrTableCell104.Name = "XrTableCell104"
        Me.XrTableCell104.StylePriority.UseBackColor = False
        Me.XrTableCell104.StylePriority.UseFont = False
        Me.XrTableCell104.StylePriority.UseForeColor = False
        Me.XrTableCell104.StylePriority.UseTextAlignment = False
        Me.XrTableCell104.Text = "XrTableCell18"
        Me.XrTableCell104.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrTableCell104.TextFormatString = "{0}"
        Me.XrTableCell104.Weight = 1.0468409166370298R
        '
        'XrTableCell105
        '
        Me.XrTableCell105.BackColor = System.Drawing.Color.Transparent
        Me.XrTableCell105.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[BackPrice]")})
        Me.XrTableCell105.Font = New DevExpress.Drawing.DXFont("Zona Pro Regular", 10.0!)
        Me.XrTableCell105.ForeColor = System.Drawing.Color.Gray
        Me.XrTableCell105.Multiline = True
        Me.XrTableCell105.Name = "XrTableCell105"
        Me.XrTableCell105.StylePriority.UseBackColor = False
        Me.XrTableCell105.StylePriority.UseFont = False
        Me.XrTableCell105.StylePriority.UseForeColor = False
        Me.XrTableCell105.StylePriority.UseTextAlignment = False
        Me.XrTableCell105.Text = "XrTableCell19"
        Me.XrTableCell105.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrTableCell105.TextFormatString = "{0:C}"
        Me.XrTableCell105.Weight = 1.361594181021454R
        '
        'XrTableRow26
        '
        Me.XrTableRow26.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell123, Me.XrTableCell124})
        Me.XrTableRow26.Name = "XrTableRow26"
        Me.XrTableRow26.Weight = 1.0R
        '
        'XrTableCell123
        '
        Me.XrTableCell123.BackColor = System.Drawing.Color.Transparent
        Me.XrTableCell123.Font = New DevExpress.Drawing.DXFont("Zona Pro Regular", 10.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrTableCell123.ForeColor = System.Drawing.Color.Gray
        Me.XrTableCell123.Multiline = True
        Me.XrTableCell123.Name = "XrTableCell123"
        Me.XrTableCell123.StylePriority.UseBackColor = False
        Me.XrTableCell123.StylePriority.UseFont = False
        Me.XrTableCell123.StylePriority.UseForeColor = False
        Me.XrTableCell123.StylePriority.UseTextAlignment = False
        Me.XrTableCell123.Text = "ΣΥΝΟΛΟ"
        Me.XrTableCell123.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrTableCell123.Weight = 5.8558789433012981R
        '
        'XrTableCell124
        '
        Me.XrTableCell124.BackColor = System.Drawing.Color.Transparent
        Me.XrTableCell124.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[TotBackBench]")})
        Me.XrTableCell124.Font = New DevExpress.Drawing.DXFont("Zona Pro Regular", 10.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrTableCell124.ForeColor = System.Drawing.Color.Gray
        Me.XrTableCell124.Multiline = True
        Me.XrTableCell124.Name = "XrTableCell124"
        Me.XrTableCell124.StylePriority.UseBackColor = False
        Me.XrTableCell124.StylePriority.UseFont = False
        Me.XrTableCell124.StylePriority.UseForeColor = False
        Me.XrTableCell124.StylePriority.UseTextAlignment = False
        Me.XrTableCell124.Text = "XrTableCell124"
        Me.XrTableCell124.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrTableCell124.TextFormatString = "{0:C}"
        Me.XrTableCell124.Weight = 1.361594181021454R
        '
        'XrLabel1
        '
        Me.XrLabel1.BackColor = System.Drawing.Color.White
        Me.XrLabel1.Font = New DevExpress.Drawing.DXFont("Zona Pro", 12.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(113, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.XrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(1.999878!, 97.83936!)
        Me.XrLabel1.Name = "XrLabel1"
        Me.XrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.XrLabel1.SizeF = New System.Drawing.SizeF(625.0001!, 20.83333!)
        Me.XrLabel1.StylePriority.UseBackColor = False
        Me.XrLabel1.StylePriority.UseFont = False
        Me.XrLabel1.StylePriority.UseForeColor = False
        Me.XrLabel1.StylePriority.UsePadding = False
        Me.XrLabel1.StylePriority.UseTextAlignment = False
        Me.XrLabel1.Text = "ΓΕΝΙΚΑ ΣΤΟΙΧΕΙΑ"
        Me.XrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrTable4
        '
        Me.XrTable4.BorderColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(113, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.XrTable4.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTable4.LocationFloat = New DevExpress.Utils.PointFloat(1.999701!, 118.6726!)
        Me.XrTable4.Name = "XrTable4"
        Me.XrTable4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96.0!)
        Me.XrTable4.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow22, Me.XrTableRow23})
        Me.XrTable4.SizeF = New System.Drawing.SizeF(625.0003!, 50.0!)
        Me.XrTable4.StylePriority.UseBorderColor = False
        Me.XrTable4.StylePriority.UseBorders = False
        '
        'XrTableRow22
        '
        Me.XrTableRow22.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell106, Me.XrTableCell107, Me.XrTableCell108, Me.XrTableCell109, Me.XrTableCell110})
        Me.XrTableRow22.Name = "XrTableRow22"
        Me.XrTableRow22.Weight = 1.0R
        '
        'XrTableCell106
        '
        Me.XrTableCell106.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.XrTableCell106.Font = New DevExpress.Drawing.DXFont("Zona Pro Regular", 10.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrTableCell106.ForeColor = System.Drawing.Color.Gray
        Me.XrTableCell106.Multiline = True
        Me.XrTableCell106.Name = "XrTableCell106"
        Me.XrTableCell106.StylePriority.UseBackColor = False
        Me.XrTableCell106.StylePriority.UseFont = False
        Me.XrTableCell106.StylePriority.UseForeColor = False
        Me.XrTableCell106.StylePriority.UseTextAlignment = False
        Me.XrTableCell106.Text = "ΜΕΤΑΦΟΡΑ"
        Me.XrTableCell106.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrTableCell106.Weight = 1.4371878159559566R
        '
        'XrTableCell107
        '
        Me.XrTableCell107.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.XrTableCell107.Font = New DevExpress.Drawing.DXFont("Zona Pro Regular", 10.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrTableCell107.ForeColor = System.Drawing.Color.Gray
        Me.XrTableCell107.Multiline = True
        Me.XrTableCell107.Name = "XrTableCell107"
        Me.XrTableCell107.StylePriority.UseBackColor = False
        Me.XrTableCell107.StylePriority.UseFont = False
        Me.XrTableCell107.StylePriority.UseForeColor = False
        Me.XrTableCell107.StylePriority.UseTextAlignment = False
        Me.XrTableCell107.Text = "ΕΠΙΜΕΤΡΗΣΗ"
        Me.XrTableCell107.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrTableCell107.Weight = 1.2429530016493193R
        '
        'XrTableCell108
        '
        Me.XrTableCell108.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.XrTableCell108.Font = New DevExpress.Drawing.DXFont("Zona Pro Regular", 10.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrTableCell108.ForeColor = System.Drawing.Color.Gray
        Me.XrTableCell108.Multiline = True
        Me.XrTableCell108.Name = "XrTableCell108"
        Me.XrTableCell108.StylePriority.UseBackColor = False
        Me.XrTableCell108.StylePriority.UseFont = False
        Me.XrTableCell108.StylePriority.UseForeColor = False
        Me.XrTableCell108.StylePriority.UseTextAlignment = False
        Me.XrTableCell108.Text = "ΑΠΟΞΥΛΩΣΗ"
        Me.XrTableCell108.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrTableCell108.Weight = 1.3797920569623507R
        '
        'XrTableCell109
        '
        Me.XrTableCell109.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.XrTableCell109.Font = New DevExpress.Drawing.DXFont("Zona Pro Regular", 10.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrTableCell109.ForeColor = System.Drawing.Color.Gray
        Me.XrTableCell109.Multiline = True
        Me.XrTableCell109.Name = "XrTableCell109"
        Me.XrTableCell109.StylePriority.UseBackColor = False
        Me.XrTableCell109.StylePriority.UseFont = False
        Me.XrTableCell109.StylePriority.UseForeColor = False
        Me.XrTableCell109.StylePriority.UseTextAlignment = False
        Me.XrTableCell109.Text = "ΣΥΜΦΩΝΗΘΕΝ ΦΠΑ"
        Me.XrTableCell109.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrTableCell109.Weight = 2.1087725487391293R
        '
        'XrTableCell110
        '
        Me.XrTableCell110.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.XrTableCell110.Font = New DevExpress.Drawing.DXFont("Zona Pro Regular", 10.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrTableCell110.ForeColor = System.Drawing.Color.Gray
        Me.XrTableCell110.Multiline = True
        Me.XrTableCell110.Name = "XrTableCell110"
        Me.XrTableCell110.StylePriority.UseBackColor = False
        Me.XrTableCell110.StylePriority.UseFont = False
        Me.XrTableCell110.StylePriority.UseForeColor = False
        Me.XrTableCell110.StylePriority.UseTextAlignment = False
        Me.XrTableCell110.Text = "ΣΥΝΟΛΟ"
        Me.XrTableCell110.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrTableCell110.Weight = 1.4831195887282125R
        '
        'XrTableRow23
        '
        Me.XrTableRow23.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell111, Me.XrTableCell112, Me.XrTableCell113, Me.XrTableCell114, Me.XrTableCell115})
        Me.XrTableRow23.Name = "XrTableRow23"
        Me.XrTableRow23.Weight = 1.0R
        '
        'XrTableCell111
        '
        Me.XrTableCell111.BackColor = System.Drawing.Color.Transparent
        Me.XrTableCell111.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Ktransport]")})
        Me.XrTableCell111.Font = New DevExpress.Drawing.DXFont("Zona Pro Regular", 10.0!)
        Me.XrTableCell111.ForeColor = System.Drawing.Color.Gray
        Me.XrTableCell111.Multiline = True
        Me.XrTableCell111.Name = "XrTableCell111"
        Me.XrTableCell111.StylePriority.UseBackColor = False
        Me.XrTableCell111.StylePriority.UseFont = False
        Me.XrTableCell111.StylePriority.UseForeColor = False
        Me.XrTableCell111.StylePriority.UseTextAlignment = False
        Me.XrTableCell111.Text = "ΠΑΓΚΟΙ"
        Me.XrTableCell111.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrTableCell111.TextFormatString = "{0:C}"
        Me.XrTableCell111.Weight = 1.4371878159559566R
        '
        'XrTableCell112
        '
        Me.XrTableCell112.BackColor = System.Drawing.Color.Transparent
        Me.XrTableCell112.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Kmeasurement]")})
        Me.XrTableCell112.Font = New DevExpress.Drawing.DXFont("Zona Pro Regular", 10.0!)
        Me.XrTableCell112.ForeColor = System.Drawing.Color.Gray
        Me.XrTableCell112.Multiline = True
        Me.XrTableCell112.Name = "XrTableCell112"
        Me.XrTableCell112.StylePriority.UseBackColor = False
        Me.XrTableCell112.StylePriority.UseFont = False
        Me.XrTableCell112.StylePriority.UseForeColor = False
        Me.XrTableCell112.StylePriority.UseTextAlignment = False
        Me.XrTableCell112.Text = "XrTableCell37"
        Me.XrTableCell112.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrTableCell112.TextFormatString = "{0:C}"
        Me.XrTableCell112.Weight = 1.2429530016493193R
        '
        'XrTableCell113
        '
        Me.XrTableCell113.BackColor = System.Drawing.Color.Transparent
        Me.XrTableCell113.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Kremove]")})
        Me.XrTableCell113.Font = New DevExpress.Drawing.DXFont("Zona Pro Regular", 10.0!)
        Me.XrTableCell113.ForeColor = System.Drawing.Color.Gray
        Me.XrTableCell113.Multiline = True
        Me.XrTableCell113.Name = "XrTableCell113"
        Me.XrTableCell113.StylePriority.UseBackColor = False
        Me.XrTableCell113.StylePriority.UseFont = False
        Me.XrTableCell113.StylePriority.UseForeColor = False
        Me.XrTableCell113.StylePriority.UseTextAlignment = False
        Me.XrTableCell113.Text = "XrTableCell6"
        Me.XrTableCell113.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrTableCell113.TextFormatString = "{0:C}"
        Me.XrTableCell113.Weight = 1.3797920569623507R
        '
        'XrTableCell114
        '
        Me.XrTableCell114.BackColor = System.Drawing.Color.Transparent
        Me.XrTableCell114.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[KVatPrice]")})
        Me.XrTableCell114.Font = New DevExpress.Drawing.DXFont("Zona Pro Regular", 10.0!)
        Me.XrTableCell114.ForeColor = System.Drawing.Color.Gray
        Me.XrTableCell114.Multiline = True
        Me.XrTableCell114.Name = "XrTableCell114"
        Me.XrTableCell114.StylePriority.UseBackColor = False
        Me.XrTableCell114.StylePriority.UseFont = False
        Me.XrTableCell114.StylePriority.UseForeColor = False
        Me.XrTableCell114.StylePriority.UseTextAlignment = False
        Me.XrTableCell114.Text = "XrTableCell8"
        Me.XrTableCell114.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrTableCell114.TextFormatString = "{0:C}"
        Me.XrTableCell114.Weight = 2.1087725487391293R
        '
        'XrTableCell115
        '
        Me.XrTableCell115.BackColor = System.Drawing.Color.Transparent
        Me.XrTableCell115.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[TotK]")})
        Me.XrTableCell115.Font = New DevExpress.Drawing.DXFont("Zona Pro Regular", 10.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrTableCell115.ForeColor = System.Drawing.Color.Gray
        Me.XrTableCell115.Multiline = True
        Me.XrTableCell115.Name = "XrTableCell115"
        Me.XrTableCell115.StylePriority.UseBackColor = False
        Me.XrTableCell115.StylePriority.UseFont = False
        Me.XrTableCell115.StylePriority.UseForeColor = False
        Me.XrTableCell115.StylePriority.UseTextAlignment = False
        Me.XrTableCell115.Text = "XrTableCell115"
        Me.XrTableCell115.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrTableCell115.TextFormatString = "{0:C}"
        Me.XrTableCell115.Weight = 1.4831195887282125R
        '
        'XrTable7
        '
        Me.XrTable7.BorderColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(113, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.XrTable7.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTable7.LocationFloat = New DevExpress.Utils.PointFloat(0.000181675!, 0!)
        Me.XrTable7.Name = "XrTable7"
        Me.XrTable7.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96.0!)
        Me.XrTable7.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow28})
        Me.XrTable7.SizeF = New System.Drawing.SizeF(625.0003!, 25.0!)
        Me.XrTable7.StylePriority.UseBorderColor = False
        Me.XrTable7.StylePriority.UseBorders = False
        '
        'XrTableRow28
        '
        Me.XrTableRow28.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell118, Me.XrTableCell125})
        Me.XrTableRow28.Name = "XrTableRow28"
        Me.XrTableRow28.Weight = 1.0R
        '
        'XrTableCell118
        '
        Me.XrTableCell118.BackColor = System.Drawing.Color.Transparent
        Me.XrTableCell118.Font = New DevExpress.Drawing.DXFont("Zona Pro Regular", 10.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrTableCell118.ForeColor = System.Drawing.Color.Gray
        Me.XrTableCell118.Multiline = True
        Me.XrTableCell118.Name = "XrTableCell118"
        Me.XrTableCell118.StylePriority.UseBackColor = False
        Me.XrTableCell118.StylePriority.UseFont = False
        Me.XrTableCell118.StylePriority.UseForeColor = False
        Me.XrTableCell118.StylePriority.UseTextAlignment = False
        Me.XrTableCell118.Text = "ΣΥΝΟΛΟ ΕΡΓΟΥ ΚΟΥΖΙΝΑΣ"
        Me.XrTableCell118.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrTableCell118.Weight = 5.8558789433012981R
        '
        'XrTableCell125
        '
        Me.XrTableCell125.BackColor = System.Drawing.Color.Transparent
        Me.XrTableCell125.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[TotBackBench] + [TotEDM] + [TotEQM] + [TotK] + [TotKEpendRaf] + [TotKErm]")})
        Me.XrTableCell125.Font = New DevExpress.Drawing.DXFont("Zona Pro Regular", 10.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrTableCell125.ForeColor = System.Drawing.Color.Gray
        Me.XrTableCell125.Multiline = True
        Me.XrTableCell125.Name = "XrTableCell125"
        Me.XrTableCell125.StylePriority.UseBackColor = False
        Me.XrTableCell125.StylePriority.UseFont = False
        Me.XrTableCell125.StylePriority.UseForeColor = False
        Me.XrTableCell125.StylePriority.UseTextAlignment = False
        Me.XrTableCell125.Text = "XrTableCell124"
        Me.XrTableCell125.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrTableCell125.TextFormatString = "{0:C}"
        Me.XrTableCell125.Weight = 1.361594181021454R
        '
        'RepTransCostK
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin, Me.ReportHeader})
        Me.CalculatedFields.AddRange(New DevExpress.XtraReports.UI.CalculatedField() {Me.CalculatedField1})
        Me.ComponentStorage.AddRange(New System.ComponentModel.IComponent() {Me.SqlDataSource1})
        Me.DataMember = "VW_REPTRANSCOSTK"
        Me.DataSource = Me.SqlDataSource1
        Me.Margins = New DevExpress.Drawing.DXMargins(100, 100, 51, 46)
        Me.PageHeight = 1169
        Me.PageWidth = 827
        Me.PaperKind = DevExpress.Drawing.Printing.DXPaperKind.A4
        Me.Parameters.AddRange(New DevExpress.XtraReports.Parameters.Parameter() {Me.TransCostID})
        Me.ScriptLanguage = DevExpress.XtraReports.ScriptLanguage.VisualBasic
        Me.Version = "21.2"
        CType(Me.XrTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrTable2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrTable3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrTable4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrTable7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub

    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents XrPictureBox1 As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents SqlDataSource1 As DevExpress.DataAccess.Sql.SqlDataSource
    Friend WithEvents CalculatedField1 As DevExpress.XtraReports.UI.CalculatedField
    Friend WithEvents TransCostID As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents XrSubreport1 As DevExpress.XtraReports.UI.XRSubreport
    Friend WithEvents ReportHeader As DevExpress.XtraReports.UI.ReportHeaderBand
    Friend WithEvents XrPanel1 As DevExpress.XtraReports.UI.XRPanel
    Friend WithEvents XrLabel4 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel6 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel27 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel26 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel17 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel20 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel18 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel15 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel25 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrTable1 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow1 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell50 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell36 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell1 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell3 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell4 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableRow2 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell51 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell37 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell6 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell8 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell9 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableRow3 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell52 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell38 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell11 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell13 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell14 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableRow4 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell53 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell39 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell16 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell18 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell19 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableRow5 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell54 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell40 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell21 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell23 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell24 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableRow6 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell55 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell41 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell26 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell28 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell29 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableRow7 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell56 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell42 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell31 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell33 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell34 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableRow24 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell119 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell120 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTable2 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow8 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell2 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell5 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell7 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell10 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell12 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableRow9 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell15 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell17 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell20 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell22 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell25 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableRow10 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell27 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell30 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell32 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell35 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell43 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableRow11 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell44 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell45 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell46 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell47 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell48 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableRow12 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell49 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell57 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell58 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell59 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell60 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableRow13 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell61 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell62 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell63 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell64 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell65 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableRow14 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell66 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell67 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell68 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell69 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell70 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableRow15 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell71 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell72 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell73 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell74 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell75 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableRow16 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell76 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell77 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell78 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell79 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell80 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableRow17 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell81 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell82 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell83 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell84 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell85 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableRow25 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell121 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell122 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrLabel2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel3 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrTable3 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow18 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell86 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell87 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell88 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell89 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell90 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableRow19 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell91 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell92 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell93 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell94 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell95 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableRow20 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell96 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell97 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell98 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell99 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell100 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableRow21 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell101 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell102 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell103 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell104 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell105 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableRow26 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell123 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell124 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrTable4 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow22 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell106 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell107 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell108 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell109 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell110 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableRow23 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell111 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell112 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell113 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell114 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell115 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents SubBand2 As DevExpress.XtraReports.UI.SubBand
    Friend WithEvents XrSubreport2 As DevExpress.XtraReports.UI.XRSubreport
    Friend WithEvents XrTable7 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow28 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell118 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell125 As DevExpress.XtraReports.UI.XRTableCell
End Class
