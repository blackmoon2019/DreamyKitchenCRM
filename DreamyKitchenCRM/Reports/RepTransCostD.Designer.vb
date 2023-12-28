<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class RepTransCostD
    Inherits DevExpress.XtraReports.UI.XtraReport

    'XtraReport overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim CustomStringConnectionParameters1 As DevExpress.DataAccess.ConnectionParameters.CustomStringConnectionParameters = New DevExpress.DataAccess.ConnectionParameters.CustomStringConnectionParameters()
        Dim CustomSqlQuery1 As DevExpress.DataAccess.Sql.CustomSqlQuery = New DevExpress.DataAccess.Sql.CustomSqlQuery()
        Dim QueryParameter1 As DevExpress.DataAccess.Sql.QueryParameter = New DevExpress.DataAccess.Sql.QueryParameter()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RepTransCostD))
        Dim DynamicListLookUpSettings1 As DevExpress.XtraReports.Parameters.DynamicListLookUpSettings = New DevExpress.XtraReports.Parameters.DynamicListLookUpSettings()
        Me.SqlDataSource1 = New DevExpress.DataAccess.Sql.SqlDataSource(Me.components)
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.XrPictureBox1 = New DevExpress.XtraReports.UI.XRPictureBox()
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
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
        Me.XrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrTable4 = New DevExpress.XtraReports.UI.XRTable()
        Me.XrTableRow22 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell106 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell107 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell108 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell116 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell109 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableRow23 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell111 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell112 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell113 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell117 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell114 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.CalculatedField1 = New DevExpress.XtraReports.UI.CalculatedField()
        Me.TransCostID = New DevExpress.XtraReports.Parameters.Parameter()
        CType(Me.XrTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrTable4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'SqlDataSource1
        '
        Me.SqlDataSource1.ConnectionName = "Connection"
        Me.SqlDataSource1.ConnectionOptions.CommandTimeout = 15
        Me.SqlDataSource1.ConnectionOptions.DbCommandTimeout = 15
        CustomStringConnectionParameters1.ConnectionString = "XpoProvider=MSSqlServer;Password=Dr3@mySA;Persist Security Info=True;User ID=sa;I" &
    "nitial Catalog=DreamyKitchen;Data Source=10.10.5.7,1433;MultipleActiveResultSets" &
    "=True"
        Me.SqlDataSource1.ConnectionParameters = CustomStringConnectionParameters1
        Me.SqlDataSource1.Name = "SqlDataSource1"
        CustomSqlQuery1.Name = "VW_REPTRANSCOSTD"
        QueryParameter1.Name = "TransCostID"
        QueryParameter1.Type = GetType(DevExpress.DataAccess.Expression)
        QueryParameter1.Value = New DevExpress.DataAccess.Expression("?TransCostID", GetType(System.Guid))
        CustomSqlQuery1.Parameters.AddRange(New DevExpress.DataAccess.Sql.QueryParameter() {QueryParameter1})
        CustomSqlQuery1.Sql = "select ""VW_REPTRANSCOSTD"".*" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "  from ""dbo"".""VW_REPTRANSCOSTD"" ""VW_REPTRANSCOSTD""" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) &
    " where (""VW_REPTRANSCOSTD"".""ID"" = @TransCostID)"
        Me.SqlDataSource1.Queries.AddRange(New DevExpress.DataAccess.Sql.SqlQuery() {CustomSqlQuery1})
        Me.SqlDataSource1.ResultSchemaSerializable = resources.GetString("SqlDataSource1.ResultSchemaSerializable")
        '
        'Detail
        '
        Me.Detail.HeightF = 0!
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detail.PageBreak = DevExpress.XtraReports.UI.PageBreak.AfterBand
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
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
        Me.BottomMargin.HeightF = 0!
        Me.BottomMargin.Name = "BottomMargin"
        Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'ReportHeader
        '
        Me.ReportHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrPanel1, Me.XrLabel25, Me.XrTable1, Me.XrLabel1, Me.XrTable4})
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
        Me.XrLabel26.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[SalerName]")})
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
        Me.XrLabel20.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[createdOn]")})
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
        Me.XrTableCell3.Text = "ΤΕΜ"
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
        Me.XrTableCell51.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[DVALUELISTITEM1]")})
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
        Me.XrTableCell37.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[DT1Νame]")})
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
        Me.XrTableCell6.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[DDoorPrice1]")})
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
        Me.XrTableCell8.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[DTem1]")})
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
        Me.XrTableCell8.TextFormatString = "{0}"
        Me.XrTableCell8.Weight = 1.0468409166370298R
        '
        'XrTableCell9
        '
        Me.XrTableCell9.BackColor = System.Drawing.Color.Transparent
        Me.XrTableCell9.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[DPrice1]")})
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
        Me.XrTableCell52.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[DVALUELISTITEM2]")})
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
        Me.XrTableCell38.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[DT2Name]")})
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
        Me.XrTableCell11.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[DDoorPrice2]")})
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
        Me.XrTableCell13.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[DTem2]")})
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
        Me.XrTableCell13.TextFormatString = "{0}"
        Me.XrTableCell13.Weight = 1.0468409166370298R
        '
        'XrTableCell14
        '
        Me.XrTableCell14.BackColor = System.Drawing.Color.Transparent
        Me.XrTableCell14.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[DPrice2]")})
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
        Me.XrTableCell53.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[DVALUELISTITEM3]")})
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
        Me.XrTableCell39.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[DT3Νame]")})
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
        Me.XrTableCell16.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[DDoorPrice3]")})
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
        Me.XrTableCell18.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[DTem3]")})
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
        Me.XrTableCell18.TextFormatString = "{0}"
        Me.XrTableCell18.Weight = 1.0468409166370298R
        '
        'XrTableCell19
        '
        Me.XrTableCell19.BackColor = System.Drawing.Color.Transparent
        Me.XrTableCell19.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[DPrice3]")})
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
        Me.XrTableCell54.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[DVALUELISTITEM4]")})
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
        Me.XrTableCell40.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[DT4Name]")})
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
        Me.XrTableCell21.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[DDoorPrice4]")})
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
        Me.XrTableCell23.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[DTem4]")})
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
        Me.XrTableCell23.TextFormatString = "{0}"
        Me.XrTableCell23.Weight = 1.0468409166370298R
        '
        'XrTableCell24
        '
        Me.XrTableCell24.BackColor = System.Drawing.Color.Transparent
        Me.XrTableCell24.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[DPrice4]")})
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
        Me.XrTableCell55.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[DVALUELISTITEM5]")})
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
        Me.XrTableCell41.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[DT5Νame]")})
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
        Me.XrTableCell26.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[DDoorPrice5]")})
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
        Me.XrTableCell28.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[DTem5]")})
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
        Me.XrTableCell28.TextFormatString = "{0}"
        Me.XrTableCell28.Weight = 1.0468409166370298R
        '
        'XrTableCell29
        '
        Me.XrTableCell29.BackColor = System.Drawing.Color.Transparent
        Me.XrTableCell29.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[DPrice5]")})
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
        Me.XrTableCell56.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[DVALUELISTITEM6]")})
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
        Me.XrTableCell42.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[DT6Name]")})
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
        Me.XrTableCell31.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[DDoorPrice6]")})
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
        Me.XrTableCell33.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[DTem6]")})
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
        Me.XrTableCell33.TextFormatString = "{0}"
        Me.XrTableCell33.Weight = 1.0468409166370298R
        '
        'XrTableCell34
        '
        Me.XrTableCell34.BackColor = System.Drawing.Color.Transparent
        Me.XrTableCell34.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[DPrice6]")})
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
        Me.XrTableCell119.Text = "ΣΥΝΟΛΟ ΕΡΓΟΥ ΠΟΡΤΩΝ"
        Me.XrTableCell119.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrTableCell119.Weight = 5.8558789433012981R
        '
        'XrTableCell120
        '
        Me.XrTableCell120.BackColor = System.Drawing.Color.Transparent
        Me.XrTableCell120.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[TotD]")})
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
        Me.XrTable4.LocationFloat = New DevExpress.Utils.PointFloat(0!, 118.6726!)
        Me.XrTable4.Name = "XrTable4"
        Me.XrTable4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96.0!)
        Me.XrTable4.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow22, Me.XrTableRow23})
        Me.XrTable4.SizeF = New System.Drawing.SizeF(625.0004!, 50.0!)
        Me.XrTable4.StylePriority.UseBorderColor = False
        Me.XrTable4.StylePriority.UseBorders = False
        '
        'XrTableRow22
        '
        Me.XrTableRow22.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell106, Me.XrTableCell107, Me.XrTableCell108, Me.XrTableCell116, Me.XrTableCell109})
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
        Me.XrTableCell107.Weight = 1.5209372595390369R
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
        Me.XrTableCell108.Weight = 1.5465837043605144R
        '
        'XrTableCell116
        '
        Me.XrTableCell116.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.XrTableCell116.Font = New DevExpress.Drawing.DXFont("Zona Pro Regular", 10.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrTableCell116.ForeColor = System.Drawing.Color.Gray
        Me.XrTableCell116.Multiline = True
        Me.XrTableCell116.Name = "XrTableCell116"
        Me.XrTableCell116.StylePriority.UseBackColor = False
        Me.XrTableCell116.StylePriority.UseFont = False
        Me.XrTableCell116.StylePriority.UseForeColor = False
        Me.XrTableCell116.StylePriority.UseTextAlignment = False
        Me.XrTableCell116.Text = "ΣΧΕΔΙΟ"
        Me.XrTableCell116.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrTableCell116.Weight = 1.6639966434512481R
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
        'XrTableRow23
        '
        Me.XrTableRow23.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell111, Me.XrTableCell112, Me.XrTableCell113, Me.XrTableCell117, Me.XrTableCell114})
        Me.XrTableRow23.Name = "XrTableRow23"
        Me.XrTableRow23.Weight = 1.0R
        '
        'XrTableCell111
        '
        Me.XrTableCell111.BackColor = System.Drawing.Color.Transparent
        Me.XrTableCell111.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Dtransport]")})
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
        Me.XrTableCell112.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Dmeasurement]")})
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
        Me.XrTableCell112.Weight = 1.5209372595390369R
        '
        'XrTableCell113
        '
        Me.XrTableCell113.BackColor = System.Drawing.Color.Transparent
        Me.XrTableCell113.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Dremove]")})
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
        Me.XrTableCell113.Weight = 1.5465837043605144R
        '
        'XrTableCell117
        '
        Me.XrTableCell117.BackColor = System.Drawing.Color.Transparent
        Me.XrTableCell117.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[DDesignCharge]")})
        Me.XrTableCell117.Font = New DevExpress.Drawing.DXFont("Zona Pro Regular", 10.0!)
        Me.XrTableCell117.ForeColor = System.Drawing.Color.Gray
        Me.XrTableCell117.Multiline = True
        Me.XrTableCell117.Name = "XrTableCell117"
        Me.XrTableCell117.StylePriority.UseBackColor = False
        Me.XrTableCell117.StylePriority.UseFont = False
        Me.XrTableCell117.StylePriority.UseForeColor = False
        Me.XrTableCell117.StylePriority.UseTextAlignment = False
        Me.XrTableCell117.Text = "XrTableCell117"
        Me.XrTableCell117.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrTableCell117.Weight = 1.6639966434512481R
        '
        'XrTableCell114
        '
        Me.XrTableCell114.BackColor = System.Drawing.Color.Transparent
        Me.XrTableCell114.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[DVatPrice]")})
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
        'CalculatedField1
        '
        Me.CalculatedField1.DataMember = "vw_CCT_OFFERS_DOOR"
        Me.CalculatedField1.Name = "CalculatedField1"
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
        'RepTransCostD
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin, Me.ReportHeader})
        Me.CalculatedFields.AddRange(New DevExpress.XtraReports.UI.CalculatedField() {Me.CalculatedField1})
        Me.ComponentStorage.AddRange(New System.ComponentModel.IComponent() {Me.SqlDataSource1})
        Me.DataMember = "VW_REPTRANSCOSTD"
        Me.DataSource = Me.SqlDataSource1
        Me.Margins = New DevExpress.Drawing.DXMargins(100, 100, 51, 0)
        Me.PageHeight = 1169
        Me.PageWidth = 827
        Me.PaperKind = DevExpress.Drawing.Printing.DXPaperKind.A4
        Me.Parameters.AddRange(New DevExpress.XtraReports.Parameters.Parameter() {Me.TransCostID})
        Me.ScriptLanguage = DevExpress.XtraReports.ScriptLanguage.VisualBasic
        Me.Version = "21.2"
        CType(Me.XrTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrTable4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub

    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents TransCostID As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents SqlDataSource1 As DevExpress.DataAccess.Sql.SqlDataSource
    Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents XrPictureBox1 As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
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
    Friend WithEvents XrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrTable4 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow22 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell106 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell107 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell108 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell109 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableRow23 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell111 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell112 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell113 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell114 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents CalculatedField1 As DevExpress.XtraReports.UI.CalculatedField
    Friend WithEvents XrTableCell116 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell117 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableRow24 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell119 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell120 As DevExpress.XtraReports.UI.XRTableCell
End Class
