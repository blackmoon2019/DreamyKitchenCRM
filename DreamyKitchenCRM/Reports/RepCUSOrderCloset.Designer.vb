<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class RepCUSOrderCloset
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RepCUSOrderCloset))
        Dim CustomSqlQuery2 As DevExpress.DataAccess.Sql.CustomSqlQuery = New DevExpress.DataAccess.Sql.CustomSqlQuery()
        Dim QueryParameter2 As DevExpress.DataAccess.Sql.QueryParameter = New DevExpress.DataAccess.Sql.QueryParameter()
        Dim CustomSqlQuery3 As DevExpress.DataAccess.Sql.CustomSqlQuery = New DevExpress.DataAccess.Sql.CustomSqlQuery()
        Dim QueryParameter3 As DevExpress.DataAccess.Sql.QueryParameter = New DevExpress.DataAccess.Sql.QueryParameter()
        Dim MasterDetailInfo1 As DevExpress.DataAccess.Sql.MasterDetailInfo = New DevExpress.DataAccess.Sql.MasterDetailInfo()
        Dim RelationColumnInfo1 As DevExpress.DataAccess.Sql.RelationColumnInfo = New DevExpress.DataAccess.Sql.RelationColumnInfo()
        Dim MasterDetailInfo2 As DevExpress.DataAccess.Sql.MasterDetailInfo = New DevExpress.DataAccess.Sql.MasterDetailInfo()
        Dim RelationColumnInfo2 As DevExpress.DataAccess.Sql.RelationColumnInfo = New DevExpress.DataAccess.Sql.RelationColumnInfo()
        Dim DynamicListLookUpSettings1 As DevExpress.XtraReports.Parameters.DynamicListLookUpSettings = New DevExpress.XtraReports.Parameters.DynamicListLookUpSettings()
        Me.SqlDataSource1 = New DevExpress.DataAccess.Sql.SqlDataSource(Me.components)
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.XrPictureBox1 = New DevExpress.XtraReports.UI.XRPictureBox()
        Me.XrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
        Me.OfferID = New DevExpress.XtraReports.Parameters.Parameter()
        Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand()
        Me.XrLabel30 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrPanel3 = New DevExpress.XtraReports.UI.XRPanel()
        Me.XrLabel63 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel11 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel10 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel4 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel41 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel45 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel40 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel44 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel39 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel47 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel42 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel43 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel3 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrCheckBox2 = New DevExpress.XtraReports.UI.XRCheckBox()
        Me.XrLabel91 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel25 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel28 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel8 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel9 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrPanel1 = New DevExpress.XtraReports.UI.XRPanel()
        Me.XrLabel38 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel81 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel34 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel35 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel17 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel22 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel21 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel20 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel19 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel18 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel12 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel13 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel14 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel15 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel16 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel23 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrPanel2 = New DevExpress.XtraReports.UI.XRPanel()
        Me.XrLabel6 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel24 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel26 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel27 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel29 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel46 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel48 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel49 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel50 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel51 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel52 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel53 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel54 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrCheckBox1 = New DevExpress.XtraReports.UI.XRCheckBox()
        Me.XrLabel55 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel56 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel57 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel58 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel59 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrPanel4 = New DevExpress.XtraReports.UI.XRPanel()
        Me.XrLabel60 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel61 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel62 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel64 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel65 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel66 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel67 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel68 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel69 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel70 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel71 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel72 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel73 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrCheckBox3 = New DevExpress.XtraReports.UI.XRCheckBox()
        Me.XrLabel74 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel75 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel76 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel77 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel78 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrPanel5 = New DevExpress.XtraReports.UI.XRPanel()
        Me.XrLabel5 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel7 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel31 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel32 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel33 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel36 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel37 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel79 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel80 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel82 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel83 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel84 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel85 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrCheckBox4 = New DevExpress.XtraReports.UI.XRCheckBox()
        Me.XrLabel86 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel87 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel88 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel89 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel90 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrPanel6 = New DevExpress.XtraReports.UI.XRPanel()
        Me.XrLabel92 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel93 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel94 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel95 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel96 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel97 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel98 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel99 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel100 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel101 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel102 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel103 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel104 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrCheckBox5 = New DevExpress.XtraReports.UI.XRCheckBox()
        Me.XrLabel105 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel106 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel107 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel108 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel109 = New DevExpress.XtraReports.UI.XRLabel()
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
        CustomSqlQuery1.MetaSerializable = "<Meta X=""20"" Y=""20"" Width=""174"" Height=""1052"" />"
        CustomSqlQuery1.Name = "vw_CCT_ORDERS_CLOSET"
        QueryParameter1.Name = "OfferID"
        QueryParameter1.Type = GetType(DevExpress.DataAccess.Expression)
        QueryParameter1.Value = New DevExpress.DataAccess.Expression("?OfferID", GetType(System.Guid))
        CustomSqlQuery1.Parameters.AddRange(New DevExpress.DataAccess.Sql.QueryParameter() {QueryParameter1})
        CustomSqlQuery1.Sql = resources.GetString("CustomSqlQuery1.Sql")
        CustomSqlQuery2.MetaSerializable = "<Meta X=""214"" Y=""20"" Width=""252"" Height=""92"" />"
        CustomSqlQuery2.Name = "vw_CCT_ORDERS_CLOSET_EQUIPMENT"
        QueryParameter2.Name = "OfferID"
        QueryParameter2.Type = GetType(DevExpress.DataAccess.Expression)
        QueryParameter2.Value = New DevExpress.DataAccess.Expression("?OfferID", GetType(System.Guid))
        CustomSqlQuery2.Parameters.AddRange(New DevExpress.DataAccess.Sql.QueryParameter() {QueryParameter2})
        CustomSqlQuery2.Sql = resources.GetString("CustomSqlQuery2.Sql")
        CustomSqlQuery3.MetaSerializable = "<Meta X=""486"" Y=""20"" Width=""297"" Height=""112"" />"
        CustomSqlQuery3.Name = "vw_CCT_ORDERS_CLOSET_EQUIPMENT_EXTRA"
        QueryParameter3.Name = "OfferID"
        QueryParameter3.Type = GetType(DevExpress.DataAccess.Expression)
        QueryParameter3.Value = New DevExpress.DataAccess.Expression("?OfferID", GetType(System.Guid))
        CustomSqlQuery3.Parameters.AddRange(New DevExpress.DataAccess.Sql.QueryParameter() {QueryParameter3})
        CustomSqlQuery3.Sql = resources.GetString("CustomSqlQuery3.Sql")
        Me.SqlDataSource1.Queries.AddRange(New DevExpress.DataAccess.Sql.SqlQuery() {CustomSqlQuery1, CustomSqlQuery2, CustomSqlQuery3})
        MasterDetailInfo1.DetailQueryName = "vw_CCT_ORDERS_CLOSET"
        RelationColumnInfo1.NestedKeyColumn = "ID"
        RelationColumnInfo1.ParentKeyColumn = "cctOrdersCLOSETID"
        MasterDetailInfo1.KeyColumns.Add(RelationColumnInfo1)
        MasterDetailInfo1.MasterQueryName = "vw_CCT_ORDERS_CLOSET_EQUIPMENT"
        MasterDetailInfo2.DetailQueryName = "vw_CCT_ORDERS_CLOSET"
        RelationColumnInfo2.NestedKeyColumn = "ID"
        RelationColumnInfo2.ParentKeyColumn = "cctOrdersCLOSETID"
        MasterDetailInfo2.KeyColumns.Add(RelationColumnInfo2)
        MasterDetailInfo2.MasterQueryName = "vw_CCT_ORDERS_CLOSET_EQUIPMENT_EXTRA"
        Me.SqlDataSource1.Relations.AddRange(New DevExpress.DataAccess.Sql.MasterDetailInfo() {MasterDetailInfo1, MasterDetailInfo2})
        Me.SqlDataSource1.ResultSchemaSerializable = resources.GetString("SqlDataSource1.ResultSchemaSerializable")
        '
        'TopMargin
        '
        Me.TopMargin.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrPictureBox1, Me.XrLabel1})
        Me.TopMargin.Dpi = 254.0!
        Me.TopMargin.HeightF = 251.0!
        Me.TopMargin.Name = "TopMargin"
        '
        'XrPictureBox1
        '
        Me.XrPictureBox1.Dpi = 254.0!
        Me.XrPictureBox1.ImageSource = New DevExpress.XtraPrinting.Drawing.ImageSource("img", resources.GetString("XrPictureBox1.ImageSource"))
        Me.XrPictureBox1.LocationFloat = New DevExpress.Utils.PointFloat(0!, 39.03812!)
        Me.XrPictureBox1.Name = "XrPictureBox1"
        Me.XrPictureBox1.SizeF = New System.Drawing.SizeF(700.6712!, 187.0219!)
        '
        'XrLabel1
        '
        Me.XrLabel1.Dpi = 254.0!
        Me.XrLabel1.Font = New System.Drawing.Font("Zona Pro Regular", 10.0!)
        Me.XrLabel1.ForeColor = System.Drawing.Color.Gray
        Me.XrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(832.7375!, 51.73812!)
        Me.XrLabel1.Multiline = True
        Me.XrLabel1.Name = "XrLabel1"
        Me.XrLabel1.SizeF = New System.Drawing.SizeF(759.8425!, 174.3219!)
        Me.XrLabel1.StylePriority.UseFont = False
        Me.XrLabel1.StylePriority.UseForeColor = False
        Me.XrLabel1.StylePriority.UseTextAlignment = False
        Me.XrLabel1.Text = " Δημιουργούμε το χώρο των ονείρων σας." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "'Επιπλα Κουζίνας, Ντουλάπες Υπνοδωματίων," &
    " " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " Πόρτες,  Έπιπλα Μπάνιου"
        Me.XrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'BottomMargin
        '
        Me.BottomMargin.Dpi = 254.0!
        Me.BottomMargin.HeightF = 55.0!
        Me.BottomMargin.Name = "BottomMargin"
        '
        'Detail
        '
        Me.Detail.Dpi = 254.0!
        Me.Detail.HeightF = 0!
        Me.Detail.HierarchyPrintOptions.Indent = 50.8!
        Me.Detail.Name = "Detail"
        '
        'OfferID
        '
        Me.OfferID.Description = "OfferID"
        Me.OfferID.Name = "OfferID"
        Me.OfferID.Type = GetType(System.Guid)
        Me.OfferID.ValueInfo = "e4273d18-61e5-440a-b309-f7eeaea25b57"
        DynamicListLookUpSettings1.DataMember = "vw_CCT_ORDERS_CLOSET"
        DynamicListLookUpSettings1.DataSource = Me.SqlDataSource1
        DynamicListLookUpSettings1.DisplayMember = "ID"
        DynamicListLookUpSettings1.FilterString = Nothing
        DynamicListLookUpSettings1.SortMember = Nothing
        DynamicListLookUpSettings1.ValueMember = "ID"
        Me.OfferID.ValueSourceSettings = DynamicListLookUpSettings1
        Me.OfferID.Visible = False
        '
        'PageHeader
        '
        Me.PageHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrPanel6, Me.XrPanel5, Me.XrPanel4, Me.XrPanel2, Me.XrLabel30, Me.XrPanel3, Me.XrPanel1, Me.XrLabel2})
        Me.PageHeader.Dpi = 254.0!
        Me.PageHeader.HeightF = 2661.101!
        Me.PageHeader.Name = "PageHeader"
        '
        'XrLabel30
        '
        Me.XrLabel30.BackColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.XrLabel30.BorderColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(113, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.XrLabel30.Dpi = 254.0!
        Me.XrLabel30.Font = New System.Drawing.Font("Zona Pro", 10.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel30.ForeColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(113, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.XrLabel30.LocationFloat = New DevExpress.Utils.PointFloat(0!, 423.9333!)
        Me.XrLabel30.Name = "XrLabel30"
        Me.XrLabel30.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254.0!)
        Me.XrLabel30.SizeF = New System.Drawing.SizeF(1587.5!, 80.31473!)
        Me.XrLabel30.StylePriority.UseBackColor = False
        Me.XrLabel30.StylePriority.UseBorderColor = False
        Me.XrLabel30.StylePriority.UseFont = False
        Me.XrLabel30.StylePriority.UseForeColor = False
        Me.XrLabel30.StylePriority.UsePadding = False
        Me.XrLabel30.StylePriority.UseTextAlignment = False
        Me.XrLabel30.Text = "Μοντέλα Ντουλαπών"
        Me.XrLabel30.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrPanel3
        '
        Me.XrPanel3.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrPanel3.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel63, Me.XrLabel11, Me.XrLabel10, Me.XrLabel4, Me.XrLabel41, Me.XrLabel45, Me.XrLabel40, Me.XrLabel44, Me.XrLabel39, Me.XrLabel47, Me.XrLabel42, Me.XrLabel43, Me.XrLabel3, Me.XrCheckBox2, Me.XrLabel91, Me.XrLabel25, Me.XrLabel28, Me.XrLabel8, Me.XrLabel9})
        Me.XrPanel3.Dpi = 254.0!
        Me.XrPanel3.LocationFloat = New DevExpress.Utils.PointFloat(8.020736!, 511.8682!)
        Me.XrPanel3.Name = "XrPanel3"
        Me.XrPanel3.SizeF = New System.Drawing.SizeF(1579.48!, 420.9468!)
        Me.XrPanel3.StylePriority.UseBorders = False
        '
        'XrLabel63
        '
        Me.XrLabel63.BorderColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(113, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.XrLabel63.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrLabel63.Dpi = 254.0!
        Me.XrLabel63.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[BOXName]")})
        Me.XrLabel63.Font = New System.Drawing.Font("Zona Pro Regular", 8.0!)
        Me.XrLabel63.ForeColor = System.Drawing.Color.Gray
        Me.XrLabel63.LocationFloat = New DevExpress.Utils.PointFloat(966.4923!, 256.54!)
        Me.XrLabel63.Multiline = True
        Me.XrLabel63.Name = "XrLabel63"
        Me.XrLabel63.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel63.SizeF = New System.Drawing.SizeF(570.1476!, 58.57541!)
        Me.XrLabel63.StylePriority.UseBorderColor = False
        Me.XrLabel63.StylePriority.UseBorders = False
        Me.XrLabel63.StylePriority.UseFont = False
        Me.XrLabel63.StylePriority.UseForeColor = False
        Me.XrLabel63.StylePriority.UsePadding = False
        Me.XrLabel63.StylePriority.UseTextAlignment = False
        Me.XrLabel63.Text = "XrTableCell2"
        Me.XrLabel63.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel11
        '
        Me.XrLabel11.BorderColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(113, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.XrLabel11.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrLabel11.Dpi = 254.0!
        Me.XrLabel11.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[BOXName]")})
        Me.XrLabel11.Font = New System.Drawing.Font("Zona Pro Regular", 8.0!)
        Me.XrLabel11.ForeColor = System.Drawing.Color.Gray
        Me.XrLabel11.LocationFloat = New DevExpress.Utils.PointFloat(396.3449!, 340.36!)
        Me.XrLabel11.Multiline = True
        Me.XrLabel11.Name = "XrLabel11"
        Me.XrLabel11.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel11.SizeF = New System.Drawing.SizeF(1162.815!, 58.57544!)
        Me.XrLabel11.StylePriority.UseBorderColor = False
        Me.XrLabel11.StylePriority.UseBorders = False
        Me.XrLabel11.StylePriority.UseFont = False
        Me.XrLabel11.StylePriority.UseForeColor = False
        Me.XrLabel11.StylePriority.UsePadding = False
        Me.XrLabel11.StylePriority.UseTextAlignment = False
        Me.XrLabel11.Text = "XrTableCell2"
        Me.XrLabel11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel10
        '
        Me.XrLabel10.BorderColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(113, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.XrLabel10.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrLabel10.Dpi = 254.0!
        Me.XrLabel10.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[BOXName]")})
        Me.XrLabel10.Font = New System.Drawing.Font("Zona Pro Regular", 8.0!)
        Me.XrLabel10.ForeColor = System.Drawing.Color.Gray
        Me.XrLabel10.LocationFloat = New DevExpress.Utils.PointFloat(396.3449!, 256.54!)
        Me.XrLabel10.Multiline = True
        Me.XrLabel10.Name = "XrLabel10"
        Me.XrLabel10.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel10.SizeF = New System.Drawing.SizeF(570.1474!, 58.57541!)
        Me.XrLabel10.StylePriority.UseBorderColor = False
        Me.XrLabel10.StylePriority.UseBorders = False
        Me.XrLabel10.StylePriority.UseFont = False
        Me.XrLabel10.StylePriority.UseForeColor = False
        Me.XrLabel10.StylePriority.UsePadding = False
        Me.XrLabel10.StylePriority.UseTextAlignment = False
        Me.XrLabel10.Text = "XrTableCell2"
        Me.XrLabel10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel4
        '
        Me.XrLabel4.BackColor = System.Drawing.Color.Empty
        Me.XrLabel4.BorderColor = System.Drawing.Color.Empty
        Me.XrLabel4.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel4.Dpi = 254.0!
        Me.XrLabel4.Font = New System.Drawing.Font("Zona Pro", 9.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel4.ForeColor = System.Drawing.Color.Gray
        Me.XrLabel4.LocationFloat = New DevExpress.Utils.PointFloat(4.6736!, 340.36!)
        Me.XrLabel4.Multiline = True
        Me.XrLabel4.Name = "XrLabel4"
        Me.XrLabel4.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel4.SizeF = New System.Drawing.SizeF(391.6657!, 58.57544!)
        Me.XrLabel4.StylePriority.UseBackColor = False
        Me.XrLabel4.StylePriority.UseBorderColor = False
        Me.XrLabel4.StylePriority.UseBorders = False
        Me.XrLabel4.StylePriority.UseFont = False
        Me.XrLabel4.StylePriority.UseForeColor = False
        Me.XrLabel4.StylePriority.UsePadding = False
        Me.XrLabel4.StylePriority.UseTextAlignment = False
        Me.XrLabel4.Text = "Κωδικός επενδύσεων:"
        Me.XrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel41
        '
        Me.XrLabel41.BackColor = System.Drawing.Color.Empty
        Me.XrLabel41.BorderColor = System.Drawing.Color.Empty
        Me.XrLabel41.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel41.Dpi = 254.0!
        Me.XrLabel41.Font = New System.Drawing.Font("Zona Pro", 9.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel41.ForeColor = System.Drawing.Color.Gray
        Me.XrLabel41.LocationFloat = New DevExpress.Utils.PointFloat(4.6736!, 256.54!)
        Me.XrLabel41.Multiline = True
        Me.XrLabel41.Name = "XrLabel41"
        Me.XrLabel41.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel41.SizeF = New System.Drawing.SizeF(391.6657!, 58.57541!)
        Me.XrLabel41.StylePriority.UseBackColor = False
        Me.XrLabel41.StylePriority.UseBorderColor = False
        Me.XrLabel41.StylePriority.UseBorders = False
        Me.XrLabel41.StylePriority.UseFont = False
        Me.XrLabel41.StylePriority.UseForeColor = False
        Me.XrLabel41.StylePriority.UsePadding = False
        Me.XrLabel41.StylePriority.UseTextAlignment = False
        Me.XrLabel41.Text = "Κωδικός  Πόρτας:"
        Me.XrLabel41.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel45
        '
        Me.XrLabel45.BorderColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(113, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.XrLabel45.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrLabel45.Dpi = 254.0!
        Me.XrLabel45.Font = New System.Drawing.Font("Zona Pro Regular", 8.0!)
        Me.XrLabel45.ForeColor = System.Drawing.Color.Gray
        Me.XrLabel45.LocationFloat = New DevExpress.Utils.PointFloat(1098.917!, 172.7199!)
        Me.XrLabel45.Multiline = True
        Me.XrLabel45.Name = "XrLabel45"
        Me.XrLabel45.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel45.SizeF = New System.Drawing.SizeF(460.2432!, 58.57538!)
        Me.XrLabel45.StylePriority.UseBorderColor = False
        Me.XrLabel45.StylePriority.UseBorders = False
        Me.XrLabel45.StylePriority.UseFont = False
        Me.XrLabel45.StylePriority.UseForeColor = False
        Me.XrLabel45.StylePriority.UsePadding = False
        Me.XrLabel45.StylePriority.UseTextAlignment = False
        Me.XrLabel45.Text = "XrTableCell15"
        Me.XrLabel45.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel40
        '
        Me.XrLabel40.BackColor = System.Drawing.Color.Empty
        Me.XrLabel40.BorderColor = System.Drawing.Color.Empty
        Me.XrLabel40.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel40.Dpi = 254.0!
        Me.XrLabel40.Font = New System.Drawing.Font("Zona Pro Regular", 9.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel40.ForeColor = System.Drawing.Color.Gray
        Me.XrLabel40.LocationFloat = New DevExpress.Utils.PointFloat(810.116!, 172.7199!)
        Me.XrLabel40.Multiline = True
        Me.XrLabel40.Name = "XrLabel40"
        Me.XrLabel40.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel40.SizeF = New System.Drawing.SizeF(288.8008!, 58.57544!)
        Me.XrLabel40.StylePriority.UseBackColor = False
        Me.XrLabel40.StylePriority.UseBorderColor = False
        Me.XrLabel40.StylePriority.UseBorders = False
        Me.XrLabel40.StylePriority.UseFont = False
        Me.XrLabel40.StylePriority.UseForeColor = False
        Me.XrLabel40.StylePriority.UsePadding = False
        Me.XrLabel40.StylePriority.UseTextAlignment = False
        Me.XrLabel40.Text = "Κωδικός Ραφιών:"
        Me.XrLabel40.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel44
        '
        Me.XrLabel44.BorderColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(113, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.XrLabel44.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrLabel44.Dpi = 254.0!
        Me.XrLabel44.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[BOXName]")})
        Me.XrLabel44.Font = New System.Drawing.Font("Zona Pro Regular", 8.0!)
        Me.XrLabel44.ForeColor = System.Drawing.Color.Gray
        Me.XrLabel44.LocationFloat = New DevExpress.Utils.PointFloat(396.3449!, 172.7199!)
        Me.XrLabel44.Multiline = True
        Me.XrLabel44.Name = "XrLabel44"
        Me.XrLabel44.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel44.SizeF = New System.Drawing.SizeF(413.7711!, 58.57542!)
        Me.XrLabel44.StylePriority.UseBorderColor = False
        Me.XrLabel44.StylePriority.UseBorders = False
        Me.XrLabel44.StylePriority.UseFont = False
        Me.XrLabel44.StylePriority.UseForeColor = False
        Me.XrLabel44.StylePriority.UsePadding = False
        Me.XrLabel44.StylePriority.UseTextAlignment = False
        Me.XrLabel44.Text = "XrTableCell2"
        Me.XrLabel44.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel39
        '
        Me.XrLabel39.BackColor = System.Drawing.Color.Empty
        Me.XrLabel39.BorderColor = System.Drawing.Color.Empty
        Me.XrLabel39.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel39.Dpi = 254.0!
        Me.XrLabel39.Font = New System.Drawing.Font("Zona Pro", 9.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel39.ForeColor = System.Drawing.Color.Gray
        Me.XrLabel39.LocationFloat = New DevExpress.Utils.PointFloat(4.6736!, 172.72!)
        Me.XrLabel39.Multiline = True
        Me.XrLabel39.Name = "XrLabel39"
        Me.XrLabel39.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel39.SizeF = New System.Drawing.SizeF(391.6657!, 58.57541!)
        Me.XrLabel39.StylePriority.UseBackColor = False
        Me.XrLabel39.StylePriority.UseBorderColor = False
        Me.XrLabel39.StylePriority.UseBorders = False
        Me.XrLabel39.StylePriority.UseFont = False
        Me.XrLabel39.StylePriority.UseForeColor = False
        Me.XrLabel39.StylePriority.UsePadding = False
        Me.XrLabel39.StylePriority.UseTextAlignment = False
        Me.XrLabel39.Text = "Κωδικός Κουτιών:"
        Me.XrLabel39.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel47
        '
        Me.XrLabel47.BorderColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(113, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.XrLabel47.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrLabel47.Dpi = 254.0!
        Me.XrLabel47.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Dimension1]")})
        Me.XrLabel47.Font = New System.Drawing.Font("Zona Pro", 9.0!)
        Me.XrLabel47.ForeColor = System.Drawing.Color.Gray
        Me.XrLabel47.LocationFloat = New DevExpress.Utils.PointFloat(1252.949!, 5.079962!)
        Me.XrLabel47.Multiline = True
        Me.XrLabel47.Name = "XrLabel47"
        Me.XrLabel47.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel47.SizeF = New System.Drawing.SizeF(306.2107!, 58.57545!)
        Me.XrLabel47.StylePriority.UseBorderColor = False
        Me.XrLabel47.StylePriority.UseBorders = False
        Me.XrLabel47.StylePriority.UseFont = False
        Me.XrLabel47.StylePriority.UseForeColor = False
        Me.XrLabel47.StylePriority.UsePadding = False
        Me.XrLabel47.StylePriority.UseTextAlignment = False
        Me.XrLabel47.Text = "XrTableCell22"
        Me.XrLabel47.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrLabel47.TextFormatString = "{0:C}"
        '
        'XrLabel42
        '
        Me.XrLabel42.BackColor = System.Drawing.Color.Empty
        Me.XrLabel42.BorderColor = System.Drawing.Color.Empty
        Me.XrLabel42.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel42.Dpi = 254.0!
        Me.XrLabel42.Font = New System.Drawing.Font("Zona Pro Regular", 9.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel42.ForeColor = System.Drawing.Color.Gray
        Me.XrLabel42.LocationFloat = New DevExpress.Utils.PointFloat(926.4183!, 5.08!)
        Me.XrLabel42.Multiline = True
        Me.XrLabel42.Name = "XrLabel42"
        Me.XrLabel42.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel42.SizeF = New System.Drawing.SizeF(326.5312!, 58.57545!)
        Me.XrLabel42.StylePriority.UseBackColor = False
        Me.XrLabel42.StylePriority.UseBorderColor = False
        Me.XrLabel42.StylePriority.UseBorders = False
        Me.XrLabel42.StylePriority.UseFont = False
        Me.XrLabel42.StylePriority.UseForeColor = False
        Me.XrLabel42.StylePriority.UsePadding = False
        Me.XrLabel42.StylePriority.UseTextAlignment = False
        Me.XrLabel42.Text = "Διαστάσεις"
        Me.XrLabel42.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel43
        '
        Me.XrLabel43.BorderColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(113, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.XrLabel43.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrLabel43.Dpi = 254.0!
        Me.XrLabel43.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Model1]")})
        Me.XrLabel43.Font = New System.Drawing.Font("Zona Pro", 9.0!)
        Me.XrLabel43.ForeColor = System.Drawing.Color.Gray
        Me.XrLabel43.LocationFloat = New DevExpress.Utils.PointFloat(396.3449!, 5.080079!)
        Me.XrLabel43.Multiline = True
        Me.XrLabel43.Name = "XrLabel43"
        Me.XrLabel43.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel43.SizeF = New System.Drawing.SizeF(530.0734!, 58.57542!)
        Me.XrLabel43.StylePriority.UseBorderColor = False
        Me.XrLabel43.StylePriority.UseBorders = False
        Me.XrLabel43.StylePriority.UseFont = False
        Me.XrLabel43.StylePriority.UseForeColor = False
        Me.XrLabel43.StylePriority.UsePadding = False
        Me.XrLabel43.StylePriority.UseTextAlignment = False
        Me.XrLabel43.Text = "XrTableCell20"
        Me.XrLabel43.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel3
        '
        Me.XrLabel3.BackColor = System.Drawing.Color.Empty
        Me.XrLabel3.BorderColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(113, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.XrLabel3.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel3.Dpi = 254.0!
        Me.XrLabel3.Font = New System.Drawing.Font("Zona Pro", 9.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel3.ForeColor = System.Drawing.Color.Gray
        Me.XrLabel3.LocationFloat = New DevExpress.Utils.PointFloat(4.679394!, 5.080079!)
        Me.XrLabel3.Multiline = True
        Me.XrLabel3.Name = "XrLabel3"
        Me.XrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel3.SizeF = New System.Drawing.SizeF(391.6599!, 58.41995!)
        Me.XrLabel3.StylePriority.UseBackColor = False
        Me.XrLabel3.StylePriority.UseBorderColor = False
        Me.XrLabel3.StylePriority.UseBorders = False
        Me.XrLabel3.StylePriority.UseFont = False
        Me.XrLabel3.StylePriority.UseForeColor = False
        Me.XrLabel3.StylePriority.UsePadding = False
        Me.XrLabel3.StylePriority.UseTextAlignment = False
        Me.XrLabel3.Text = "Τύπος:"
        Me.XrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrCheckBox2
        '
        Me.XrCheckBox2.BorderColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(113, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.XrCheckBox2.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrCheckBox2.Dpi = 254.0!
        Me.XrCheckBox2.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "CheckBoxState", "[HoodAlignment]")})
        Me.XrCheckBox2.LocationFloat = New DevExpress.Utils.PointFloat(1509.107!, 80.31259!)
        Me.XrCheckBox2.Name = "XrCheckBox2"
        Me.XrCheckBox2.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrCheckBox2.SizeF = New System.Drawing.SizeF(50.05249!, 58.41969!)
        Me.XrCheckBox2.StylePriority.UseBorderColor = False
        Me.XrCheckBox2.StylePriority.UseBorders = False
        '
        'XrLabel91
        '
        Me.XrLabel91.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel91.CanShrink = True
        Me.XrLabel91.Dpi = 254.0!
        Me.XrLabel91.Font = New System.Drawing.Font("Zona Pro", 9.0!)
        Me.XrLabel91.ForeColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(113, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.XrLabel91.LocationFloat = New DevExpress.Utils.PointFloat(1046.472!, 88.89995!)
        Me.XrLabel91.Name = "XrLabel91"
        Me.XrLabel91.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel91.SizeF = New System.Drawing.SizeF(457.5557!, 52.37231!)
        Me.XrLabel91.StylePriority.UseBorders = False
        Me.XrLabel91.StylePriority.UseFont = False
        Me.XrLabel91.StylePriority.UseForeColor = False
        Me.XrLabel91.StylePriority.UsePadding = False
        Me.XrLabel91.StylePriority.UseTextAlignment = False
        Me.XrLabel91.Text = "Χωνευτό προφίλ για Led :"
        Me.XrLabel91.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel25
        '
        Me.XrLabel25.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel25.CanShrink = True
        Me.XrLabel25.Dpi = 254.0!
        Me.XrLabel25.Font = New System.Drawing.Font("Zona Pro", 9.0!)
        Me.XrLabel25.ForeColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(113, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.XrLabel25.LocationFloat = New DevExpress.Utils.PointFloat(582.9641!, 88.9!)
        Me.XrLabel25.Name = "XrLabel25"
        Me.XrLabel25.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel25.SizeF = New System.Drawing.SizeF(282.1962!, 58.42001!)
        Me.XrLabel25.StylePriority.UseBorders = False
        Me.XrLabel25.StylePriority.UseFont = False
        Me.XrLabel25.StylePriority.UseForeColor = False
        Me.XrLabel25.StylePriority.UsePadding = False
        Me.XrLabel25.StylePriority.UseTextAlignment = False
        Me.XrLabel25.Text = "Πάχος Πλάτης:"
        Me.XrLabel25.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel28
        '
        Me.XrLabel28.BorderColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(113, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.XrLabel28.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrLabel28.Dpi = 254.0!
        Me.XrLabel28.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[vw_CCT_ORDERS_CLOSET].[boxThikness]")})
        Me.XrLabel28.Font = New System.Drawing.Font("Zona Pro", 9.0!)
        Me.XrLabel28.ForeColor = System.Drawing.Color.Gray
        Me.XrLabel28.LocationFloat = New DevExpress.Utils.PointFloat(865.1606!, 88.89995!)
        Me.XrLabel28.Multiline = True
        Me.XrLabel28.Name = "XrLabel28"
        Me.XrLabel28.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel28.SizeF = New System.Drawing.SizeF(158.3397!, 58.42015!)
        Me.XrLabel28.StylePriority.UseBorderColor = False
        Me.XrLabel28.StylePriority.UseBorders = False
        Me.XrLabel28.StylePriority.UseFont = False
        Me.XrLabel28.StylePriority.UseForeColor = False
        Me.XrLabel28.StylePriority.UseTextAlignment = False
        Me.XrLabel28.Text = "XrLabel55"
        Me.XrLabel28.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel8
        '
        Me.XrLabel8.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel8.CanShrink = True
        Me.XrLabel8.Dpi = 254.0!
        Me.XrLabel8.Font = New System.Drawing.Font("Zona Pro", 9.0!)
        Me.XrLabel8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(113, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.XrLabel8.LocationFloat = New DevExpress.Utils.PointFloat(4.679379!, 88.89995!)
        Me.XrLabel8.Name = "XrLabel8"
        Me.XrLabel8.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel8.SizeF = New System.Drawing.SizeF(391.6599!, 58.41992!)
        Me.XrLabel8.StylePriority.UseBorders = False
        Me.XrLabel8.StylePriority.UseFont = False
        Me.XrLabel8.StylePriority.UseForeColor = False
        Me.XrLabel8.StylePriority.UsePadding = False
        Me.XrLabel8.StylePriority.UseTextAlignment = False
        Me.XrLabel8.Text = "Πάχος Κασώματος:"
        Me.XrLabel8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel9
        '
        Me.XrLabel9.BorderColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(113, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.XrLabel9.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrLabel9.Dpi = 254.0!
        Me.XrLabel9.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[vw_CCT_ORDERS_CLOSET].[boxThikness]")})
        Me.XrLabel9.Font = New System.Drawing.Font("Zona Pro", 9.0!)
        Me.XrLabel9.ForeColor = System.Drawing.Color.Gray
        Me.XrLabel9.LocationFloat = New DevExpress.Utils.PointFloat(396.3441!, 88.89995!)
        Me.XrLabel9.Multiline = True
        Me.XrLabel9.Name = "XrLabel9"
        Me.XrLabel9.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel9.SizeF = New System.Drawing.SizeF(165.449!, 58.42015!)
        Me.XrLabel9.StylePriority.UseBorderColor = False
        Me.XrLabel9.StylePriority.UseBorders = False
        Me.XrLabel9.StylePriority.UseFont = False
        Me.XrLabel9.StylePriority.UseForeColor = False
        Me.XrLabel9.StylePriority.UseTextAlignment = False
        Me.XrLabel9.Text = "XrLabel55"
        Me.XrLabel9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrPanel1
        '
        Me.XrPanel1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel38, Me.XrLabel81, Me.XrLabel34, Me.XrLabel35, Me.XrLabel17, Me.XrLabel22, Me.XrLabel21, Me.XrLabel20, Me.XrLabel19, Me.XrLabel18, Me.XrLabel12, Me.XrLabel13, Me.XrLabel14, Me.XrLabel15, Me.XrLabel16, Me.XrLabel23})
        Me.XrPanel1.Dpi = 254.0!
        Me.XrPanel1.LocationFloat = New DevExpress.Utils.PointFloat(0.0004613968!, 93.83906!)
        Me.XrPanel1.Name = "XrPanel1"
        Me.XrPanel1.SizeF = New System.Drawing.SizeF(1587.5!, 319.9343!)
        '
        'XrLabel38
        '
        Me.XrLabel38.CanShrink = True
        Me.XrLabel38.Dpi = 254.0!
        Me.XrLabel38.Font = New System.Drawing.Font("Zona Pro", 10.0!)
        Me.XrLabel38.ForeColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(113, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.XrLabel38.LocationFloat = New DevExpress.Utils.PointFloat(896.4894!, 261.5143!)
        Me.XrLabel38.Name = "XrLabel38"
        Me.XrLabel38.SizeF = New System.Drawing.SizeF(309.3007!, 50.80005!)
        Me.XrLabel38.StylePriority.UseFont = False
        Me.XrLabel38.StylePriority.UseForeColor = False
        Me.XrLabel38.Text = "Αρ. Παραγγελίας:"
        '
        'XrLabel81
        '
        Me.XrLabel81.BorderColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(113, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.XrLabel81.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrLabel81.Dpi = 254.0!
        Me.XrLabel81.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[code]")})
        Me.XrLabel81.Font = New System.Drawing.Font("Zona Pro Regular", 9.0!)
        Me.XrLabel81.ForeColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(113, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.XrLabel81.LocationFloat = New DevExpress.Utils.PointFloat(1233.227!, 261.5143!)
        Me.XrLabel81.Multiline = True
        Me.XrLabel81.Name = "XrLabel81"
        Me.XrLabel81.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel81.SizeF = New System.Drawing.SizeF(339.0326!, 53.23438!)
        Me.XrLabel81.StylePriority.UseBorderColor = False
        Me.XrLabel81.StylePriority.UseBorders = False
        Me.XrLabel81.StylePriority.UseFont = False
        Me.XrLabel81.StylePriority.UseForeColor = False
        Me.XrLabel81.StylePriority.UseTextAlignment = False
        Me.XrLabel81.Text = "XrLabel23"
        Me.XrLabel81.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrLabel34
        '
        Me.XrLabel34.CanShrink = True
        Me.XrLabel34.Dpi = 254.0!
        Me.XrLabel34.Font = New System.Drawing.Font("Zona Pro", 10.0!)
        Me.XrLabel34.ForeColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(113, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.XrLabel34.LocationFloat = New DevExpress.Utils.PointFloat(5.079241!, 261.5143!)
        Me.XrLabel34.Name = "XrLabel34"
        Me.XrLabel34.SizeF = New System.Drawing.SizeF(187.5125!, 50.80002!)
        Me.XrLabel34.StylePriority.UseFont = False
        Me.XrLabel34.StylePriority.UseForeColor = False
        Me.XrLabel34.Text = "Πωλητής:"
        '
        'XrLabel35
        '
        Me.XrLabel35.BorderColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(113, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.XrLabel35.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrLabel35.Dpi = 254.0!
        Me.XrLabel35.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[EmpName]")})
        Me.XrLabel35.Font = New System.Drawing.Font("Zona Pro Regular", 9.857143!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel35.ForeColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(113, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.XrLabel35.LocationFloat = New DevExpress.Utils.PointFloat(192.5917!, 261.5143!)
        Me.XrLabel35.Multiline = True
        Me.XrLabel35.Name = "XrLabel35"
        Me.XrLabel35.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel35.SizeF = New System.Drawing.SizeF(690.7505!, 50.80005!)
        Me.XrLabel35.StylePriority.UseBorderColor = False
        Me.XrLabel35.StylePriority.UseBorders = False
        Me.XrLabel35.StylePriority.UseFont = False
        Me.XrLabel35.StylePriority.UseForeColor = False
        Me.XrLabel35.Text = "XrLabel26"
        '
        'XrLabel17
        '
        Me.XrLabel17.CanShrink = True
        Me.XrLabel17.Dpi = 254.0!
        Me.XrLabel17.Font = New System.Drawing.Font("Zona Pro", 10.0!)
        Me.XrLabel17.ForeColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(113, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.XrLabel17.LocationFloat = New DevExpress.Utils.PointFloat(0!, 180.34!)
        Me.XrLabel17.Name = "XrLabel17"
        Me.XrLabel17.SizeF = New System.Drawing.SizeF(404.3647!, 50.8!)
        Me.XrLabel17.StylePriority.UseFont = False
        Me.XrLabel17.StylePriority.UseForeColor = False
        Me.XrLabel17.Text = "Ημ/νία Παραγγελίας:"
        '
        'XrLabel22
        '
        Me.XrLabel22.BorderColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(113, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.XrLabel22.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrLabel22.Dpi = 254.0!
        Me.XrLabel22.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[AREAS_Name]")})
        Me.XrLabel22.Font = New System.Drawing.Font("Zona Pro Regular", 9.0!)
        Me.XrLabel22.ForeColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(113, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.XrLabel22.LocationFloat = New DevExpress.Utils.PointFloat(1031.521!, 109.22!)
        Me.XrLabel22.Multiline = True
        Me.XrLabel22.Name = "XrLabel22"
        Me.XrLabel22.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel22.SizeF = New System.Drawing.SizeF(540.7388!, 58.42!)
        Me.XrLabel22.StylePriority.UseBorderColor = False
        Me.XrLabel22.StylePriority.UseBorders = False
        Me.XrLabel22.StylePriority.UseFont = False
        Me.XrLabel22.StylePriority.UseForeColor = False
        Me.XrLabel22.Text = "XrLabel22"
        '
        'XrLabel21
        '
        Me.XrLabel21.BorderColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(113, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.XrLabel21.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrLabel21.Dpi = 254.0!
        Me.XrLabel21.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[phn]")})
        Me.XrLabel21.Font = New System.Drawing.Font("Zona Pro Regular", 9.0!)
        Me.XrLabel21.ForeColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(113, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.XrLabel21.LocationFloat = New DevExpress.Utils.PointFloat(1031.521!, 33.01998!)
        Me.XrLabel21.Multiline = True
        Me.XrLabel21.Name = "XrLabel21"
        Me.XrLabel21.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel21.SizeF = New System.Drawing.SizeF(540.7388!, 58.41997!)
        Me.XrLabel21.StylePriority.UseBorderColor = False
        Me.XrLabel21.StylePriority.UseBorders = False
        Me.XrLabel21.StylePriority.UseFont = False
        Me.XrLabel21.StylePriority.UseForeColor = False
        Me.XrLabel21.Text = "XrLabel21"
        '
        'XrLabel20
        '
        Me.XrLabel20.BorderColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(113, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.XrLabel20.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrLabel20.Dpi = 254.0!
        Me.XrLabel20.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[dtOffer]")})
        Me.XrLabel20.Font = New System.Drawing.Font("Zona Pro Regular", 10.0!)
        Me.XrLabel20.ForeColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(113, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.XrLabel20.LocationFloat = New DevExpress.Utils.PointFloat(404.3644!, 180.3399!)
        Me.XrLabel20.Multiline = True
        Me.XrLabel20.Name = "XrLabel20"
        Me.XrLabel20.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel20.SizeF = New System.Drawing.SizeF(296.3062!, 50.8!)
        Me.XrLabel20.StylePriority.UseBorderColor = False
        Me.XrLabel20.StylePriority.UseBorders = False
        Me.XrLabel20.StylePriority.UseFont = False
        Me.XrLabel20.StylePriority.UseForeColor = False
        Me.XrLabel20.Text = "XrLabel20"
        Me.XrLabel20.TextFormatString = "{0:d}"
        '
        'XrLabel19
        '
        Me.XrLabel19.BorderColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(113, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.XrLabel19.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrLabel19.Dpi = 254.0!
        Me.XrLabel19.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[FullAddress]")})
        Me.XrLabel19.Font = New System.Drawing.Font("Zona Pro Regular", 9.0!)
        Me.XrLabel19.ForeColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.XrLabel19.LocationFloat = New DevExpress.Utils.PointFloat(190.0517!, 109.2199!)
        Me.XrLabel19.Multiline = True
        Me.XrLabel19.Name = "XrLabel19"
        Me.XrLabel19.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel19.SizeF = New System.Drawing.SizeF(693.2905!, 58.42003!)
        Me.XrLabel19.StylePriority.UseBorderColor = False
        Me.XrLabel19.StylePriority.UseBorders = False
        Me.XrLabel19.StylePriority.UseFont = False
        Me.XrLabel19.StylePriority.UseForeColor = False
        Me.XrLabel19.StylePriority.UseTextAlignment = False
        Me.XrLabel19.Text = "XrLabel19"
        Me.XrLabel19.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLabel18
        '
        Me.XrLabel18.BorderColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(113, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.XrLabel18.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrLabel18.Dpi = 254.0!
        Me.XrLabel18.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[CctName]")})
        Me.XrLabel18.Font = New System.Drawing.Font("Zona Pro Regular", 9.0!)
        Me.XrLabel18.ForeColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(113, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.XrLabel18.LocationFloat = New DevExpress.Utils.PointFloat(192.5917!, 33.02002!)
        Me.XrLabel18.Multiline = True
        Me.XrLabel18.Name = "XrLabel18"
        Me.XrLabel18.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel18.SizeF = New System.Drawing.SizeF(690.7505!, 58.41999!)
        Me.XrLabel18.StylePriority.UseBorderColor = False
        Me.XrLabel18.StylePriority.UseBorders = False
        Me.XrLabel18.StylePriority.UseFont = False
        Me.XrLabel18.StylePriority.UseForeColor = False
        Me.XrLabel18.Text = "XrLabel18"
        '
        'XrLabel12
        '
        Me.XrLabel12.CanShrink = True
        Me.XrLabel12.Dpi = 254.0!
        Me.XrLabel12.Font = New System.Drawing.Font("Zona Pro", 10.0!)
        Me.XrLabel12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(113, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.XrLabel12.LocationFloat = New DevExpress.Utils.PointFloat(896.4894!, 33.02!)
        Me.XrLabel12.Name = "XrLabel12"
        Me.XrLabel12.SizeF = New System.Drawing.SizeF(135.0311!, 50.8!)
        Me.XrLabel12.StylePriority.UseFont = False
        Me.XrLabel12.StylePriority.UseForeColor = False
        Me.XrLabel12.Text = "Τηλ.:"
        '
        'XrLabel13
        '
        Me.XrLabel13.CanShrink = True
        Me.XrLabel13.Dpi = 254.0!
        Me.XrLabel13.Font = New System.Drawing.Font("Zona Pro", 10.0!)
        Me.XrLabel13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(113, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.XrLabel13.LocationFloat = New DevExpress.Utils.PointFloat(896.4894!, 116.84!)
        Me.XrLabel13.Name = "XrLabel13"
        Me.XrLabel13.SizeF = New System.Drawing.SizeF(135.0311!, 50.79997!)
        Me.XrLabel13.StylePriority.UseFont = False
        Me.XrLabel13.StylePriority.UseForeColor = False
        Me.XrLabel13.Text = "Πόλη:"
        '
        'XrLabel14
        '
        Me.XrLabel14.CanShrink = True
        Me.XrLabel14.Dpi = 254.0!
        Me.XrLabel14.Font = New System.Drawing.Font("Zona Pro", 10.0!)
        Me.XrLabel14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(113, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.XrLabel14.LocationFloat = New DevExpress.Utils.PointFloat(896.4894!, 180.34!)
        Me.XrLabel14.Name = "XrLabel14"
        Me.XrLabel14.SizeF = New System.Drawing.SizeF(381.0936!, 50.8!)
        Me.XrLabel14.StylePriority.UseFont = False
        Me.XrLabel14.StylePriority.UseForeColor = False
        Me.XrLabel14.Text = "Ημέρες Παράδοσης: "
        '
        'XrLabel15
        '
        Me.XrLabel15.CanShrink = True
        Me.XrLabel15.Dpi = 254.0!
        Me.XrLabel15.Font = New System.Drawing.Font("Zona Pro", 10.0!)
        Me.XrLabel15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(113, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.XrLabel15.LocationFloat = New DevExpress.Utils.PointFloat(0!, 33.02008!)
        Me.XrLabel15.Name = "XrLabel15"
        Me.XrLabel15.SizeF = New System.Drawing.SizeF(190.0522!, 50.8!)
        Me.XrLabel15.StylePriority.UseFont = False
        Me.XrLabel15.StylePriority.UseForeColor = False
        Me.XrLabel15.Text = "Πελάτης:"
        '
        'XrLabel16
        '
        Me.XrLabel16.CanShrink = True
        Me.XrLabel16.Dpi = 254.0!
        Me.XrLabel16.Font = New System.Drawing.Font("Zona Pro", 10.0!)
        Me.XrLabel16.ForeColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(113, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.XrLabel16.LocationFloat = New DevExpress.Utils.PointFloat(0!, 116.8401!)
        Me.XrLabel16.Name = "XrLabel16"
        Me.XrLabel16.SizeF = New System.Drawing.SizeF(139.7814!, 50.8!)
        Me.XrLabel16.StylePriority.UseFont = False
        Me.XrLabel16.StylePriority.UseForeColor = False
        Me.XrLabel16.Text = "Διευθ.:"
        '
        'XrLabel23
        '
        Me.XrLabel23.BorderColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(113, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.XrLabel23.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrLabel23.Dpi = 254.0!
        Me.XrLabel23.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[daysofdeliver]")})
        Me.XrLabel23.Font = New System.Drawing.Font("Zona Pro Regular", 10.0!)
        Me.XrLabel23.ForeColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(113, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.XrLabel23.LocationFloat = New DevExpress.Utils.PointFloat(1277.583!, 180.3399!)
        Me.XrLabel23.Multiline = True
        Me.XrLabel23.Name = "XrLabel23"
        Me.XrLabel23.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel23.SizeF = New System.Drawing.SizeF(294.6763!, 53.23431!)
        Me.XrLabel23.StylePriority.UseBorderColor = False
        Me.XrLabel23.StylePriority.UseBorders = False
        Me.XrLabel23.StylePriority.UseFont = False
        Me.XrLabel23.StylePriority.UseForeColor = False
        Me.XrLabel23.StylePriority.UseTextAlignment = False
        Me.XrLabel23.Text = "XrLabel23"
        Me.XrLabel23.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrLabel2
        '
        Me.XrLabel2.Dpi = 254.0!
        Me.XrLabel2.Font = New System.Drawing.Font("Zona Pro", 14.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(113, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.XrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(0.0001845587!, 0!)
        Me.XrLabel2.Name = "XrLabel2"
        Me.XrLabel2.SizeF = New System.Drawing.SizeF(1587.5!, 80.32481!)
        Me.XrLabel2.StylePriority.UseFont = False
        Me.XrLabel2.StylePriority.UseForeColor = False
        Me.XrLabel2.StylePriority.UseTextAlignment = False
        Me.XrLabel2.Text = "Δελτίο παραγγελίας Ντουλάπας"
        Me.XrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrPanel2
        '
        Me.XrPanel2.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrPanel2.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel6, Me.XrLabel24, Me.XrLabel26, Me.XrLabel27, Me.XrLabel29, Me.XrLabel46, Me.XrLabel48, Me.XrLabel49, Me.XrLabel50, Me.XrLabel51, Me.XrLabel52, Me.XrLabel53, Me.XrLabel54, Me.XrCheckBox1, Me.XrLabel55, Me.XrLabel56, Me.XrLabel57, Me.XrLabel58, Me.XrLabel59})
        Me.XrPanel2.Dpi = 254.0!
        Me.XrPanel2.LocationFloat = New DevExpress.Utils.PointFloat(8.020736!, 937.895!)
        Me.XrPanel2.Name = "XrPanel2"
        Me.XrPanel2.SizeF = New System.Drawing.SizeF(1579.48!, 420.9469!)
        Me.XrPanel2.StylePriority.UseBorders = False
        '
        'XrLabel6
        '
        Me.XrLabel6.BorderColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(113, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.XrLabel6.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrLabel6.Dpi = 254.0!
        Me.XrLabel6.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[BOXName]")})
        Me.XrLabel6.Font = New System.Drawing.Font("Zona Pro Regular", 8.0!)
        Me.XrLabel6.ForeColor = System.Drawing.Color.Gray
        Me.XrLabel6.LocationFloat = New DevExpress.Utils.PointFloat(966.4923!, 256.54!)
        Me.XrLabel6.Multiline = True
        Me.XrLabel6.Name = "XrLabel6"
        Me.XrLabel6.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel6.SizeF = New System.Drawing.SizeF(570.1476!, 58.57541!)
        Me.XrLabel6.StylePriority.UseBorderColor = False
        Me.XrLabel6.StylePriority.UseBorders = False
        Me.XrLabel6.StylePriority.UseFont = False
        Me.XrLabel6.StylePriority.UseForeColor = False
        Me.XrLabel6.StylePriority.UsePadding = False
        Me.XrLabel6.StylePriority.UseTextAlignment = False
        Me.XrLabel6.Text = "XrTableCell2"
        Me.XrLabel6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel24
        '
        Me.XrLabel24.BorderColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(113, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.XrLabel24.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrLabel24.Dpi = 254.0!
        Me.XrLabel24.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[BOXName]")})
        Me.XrLabel24.Font = New System.Drawing.Font("Zona Pro Regular", 8.0!)
        Me.XrLabel24.ForeColor = System.Drawing.Color.Gray
        Me.XrLabel24.LocationFloat = New DevExpress.Utils.PointFloat(396.3449!, 340.36!)
        Me.XrLabel24.Multiline = True
        Me.XrLabel24.Name = "XrLabel24"
        Me.XrLabel24.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel24.SizeF = New System.Drawing.SizeF(1162.815!, 58.57544!)
        Me.XrLabel24.StylePriority.UseBorderColor = False
        Me.XrLabel24.StylePriority.UseBorders = False
        Me.XrLabel24.StylePriority.UseFont = False
        Me.XrLabel24.StylePriority.UseForeColor = False
        Me.XrLabel24.StylePriority.UsePadding = False
        Me.XrLabel24.StylePriority.UseTextAlignment = False
        Me.XrLabel24.Text = "XrTableCell2"
        Me.XrLabel24.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel26
        '
        Me.XrLabel26.BorderColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(113, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.XrLabel26.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrLabel26.Dpi = 254.0!
        Me.XrLabel26.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[BOXName]")})
        Me.XrLabel26.Font = New System.Drawing.Font("Zona Pro Regular", 8.0!)
        Me.XrLabel26.ForeColor = System.Drawing.Color.Gray
        Me.XrLabel26.LocationFloat = New DevExpress.Utils.PointFloat(396.3449!, 256.54!)
        Me.XrLabel26.Multiline = True
        Me.XrLabel26.Name = "XrLabel26"
        Me.XrLabel26.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel26.SizeF = New System.Drawing.SizeF(570.1474!, 58.57541!)
        Me.XrLabel26.StylePriority.UseBorderColor = False
        Me.XrLabel26.StylePriority.UseBorders = False
        Me.XrLabel26.StylePriority.UseFont = False
        Me.XrLabel26.StylePriority.UseForeColor = False
        Me.XrLabel26.StylePriority.UsePadding = False
        Me.XrLabel26.StylePriority.UseTextAlignment = False
        Me.XrLabel26.Text = "XrTableCell2"
        Me.XrLabel26.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel27
        '
        Me.XrLabel27.BackColor = System.Drawing.Color.Empty
        Me.XrLabel27.BorderColor = System.Drawing.Color.Empty
        Me.XrLabel27.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel27.Dpi = 254.0!
        Me.XrLabel27.Font = New System.Drawing.Font("Zona Pro", 9.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel27.ForeColor = System.Drawing.Color.Gray
        Me.XrLabel27.LocationFloat = New DevExpress.Utils.PointFloat(4.6736!, 340.36!)
        Me.XrLabel27.Multiline = True
        Me.XrLabel27.Name = "XrLabel27"
        Me.XrLabel27.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel27.SizeF = New System.Drawing.SizeF(391.6657!, 58.57544!)
        Me.XrLabel27.StylePriority.UseBackColor = False
        Me.XrLabel27.StylePriority.UseBorderColor = False
        Me.XrLabel27.StylePriority.UseBorders = False
        Me.XrLabel27.StylePriority.UseFont = False
        Me.XrLabel27.StylePriority.UseForeColor = False
        Me.XrLabel27.StylePriority.UsePadding = False
        Me.XrLabel27.StylePriority.UseTextAlignment = False
        Me.XrLabel27.Text = "Κωδικός επενδύσεων:"
        Me.XrLabel27.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel29
        '
        Me.XrLabel29.BackColor = System.Drawing.Color.Empty
        Me.XrLabel29.BorderColor = System.Drawing.Color.Empty
        Me.XrLabel29.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel29.Dpi = 254.0!
        Me.XrLabel29.Font = New System.Drawing.Font("Zona Pro", 9.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel29.ForeColor = System.Drawing.Color.Gray
        Me.XrLabel29.LocationFloat = New DevExpress.Utils.PointFloat(4.6736!, 256.54!)
        Me.XrLabel29.Multiline = True
        Me.XrLabel29.Name = "XrLabel29"
        Me.XrLabel29.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel29.SizeF = New System.Drawing.SizeF(391.6657!, 58.57541!)
        Me.XrLabel29.StylePriority.UseBackColor = False
        Me.XrLabel29.StylePriority.UseBorderColor = False
        Me.XrLabel29.StylePriority.UseBorders = False
        Me.XrLabel29.StylePriority.UseFont = False
        Me.XrLabel29.StylePriority.UseForeColor = False
        Me.XrLabel29.StylePriority.UsePadding = False
        Me.XrLabel29.StylePriority.UseTextAlignment = False
        Me.XrLabel29.Text = "Κωδικός  Πόρτας:"
        Me.XrLabel29.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel46
        '
        Me.XrLabel46.BorderColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(113, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.XrLabel46.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrLabel46.Dpi = 254.0!
        Me.XrLabel46.Font = New System.Drawing.Font("Zona Pro Regular", 8.0!)
        Me.XrLabel46.ForeColor = System.Drawing.Color.Gray
        Me.XrLabel46.LocationFloat = New DevExpress.Utils.PointFloat(1098.917!, 172.7199!)
        Me.XrLabel46.Multiline = True
        Me.XrLabel46.Name = "XrLabel46"
        Me.XrLabel46.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel46.SizeF = New System.Drawing.SizeF(460.2432!, 58.57538!)
        Me.XrLabel46.StylePriority.UseBorderColor = False
        Me.XrLabel46.StylePriority.UseBorders = False
        Me.XrLabel46.StylePriority.UseFont = False
        Me.XrLabel46.StylePriority.UseForeColor = False
        Me.XrLabel46.StylePriority.UsePadding = False
        Me.XrLabel46.StylePriority.UseTextAlignment = False
        Me.XrLabel46.Text = "XrTableCell15"
        Me.XrLabel46.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel48
        '
        Me.XrLabel48.BackColor = System.Drawing.Color.Empty
        Me.XrLabel48.BorderColor = System.Drawing.Color.Empty
        Me.XrLabel48.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel48.Dpi = 254.0!
        Me.XrLabel48.Font = New System.Drawing.Font("Zona Pro Regular", 9.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel48.ForeColor = System.Drawing.Color.Gray
        Me.XrLabel48.LocationFloat = New DevExpress.Utils.PointFloat(810.116!, 172.7199!)
        Me.XrLabel48.Multiline = True
        Me.XrLabel48.Name = "XrLabel48"
        Me.XrLabel48.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel48.SizeF = New System.Drawing.SizeF(288.8008!, 58.57544!)
        Me.XrLabel48.StylePriority.UseBackColor = False
        Me.XrLabel48.StylePriority.UseBorderColor = False
        Me.XrLabel48.StylePriority.UseBorders = False
        Me.XrLabel48.StylePriority.UseFont = False
        Me.XrLabel48.StylePriority.UseForeColor = False
        Me.XrLabel48.StylePriority.UsePadding = False
        Me.XrLabel48.StylePriority.UseTextAlignment = False
        Me.XrLabel48.Text = "Κωδικός Ραφιών:"
        Me.XrLabel48.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel49
        '
        Me.XrLabel49.BorderColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(113, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.XrLabel49.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrLabel49.Dpi = 254.0!
        Me.XrLabel49.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[BOXName]")})
        Me.XrLabel49.Font = New System.Drawing.Font("Zona Pro Regular", 8.0!)
        Me.XrLabel49.ForeColor = System.Drawing.Color.Gray
        Me.XrLabel49.LocationFloat = New DevExpress.Utils.PointFloat(396.3449!, 172.7199!)
        Me.XrLabel49.Multiline = True
        Me.XrLabel49.Name = "XrLabel49"
        Me.XrLabel49.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel49.SizeF = New System.Drawing.SizeF(413.7711!, 58.57542!)
        Me.XrLabel49.StylePriority.UseBorderColor = False
        Me.XrLabel49.StylePriority.UseBorders = False
        Me.XrLabel49.StylePriority.UseFont = False
        Me.XrLabel49.StylePriority.UseForeColor = False
        Me.XrLabel49.StylePriority.UsePadding = False
        Me.XrLabel49.StylePriority.UseTextAlignment = False
        Me.XrLabel49.Text = "XrTableCell2"
        Me.XrLabel49.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel50
        '
        Me.XrLabel50.BackColor = System.Drawing.Color.Empty
        Me.XrLabel50.BorderColor = System.Drawing.Color.Empty
        Me.XrLabel50.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel50.Dpi = 254.0!
        Me.XrLabel50.Font = New System.Drawing.Font("Zona Pro", 9.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel50.ForeColor = System.Drawing.Color.Gray
        Me.XrLabel50.LocationFloat = New DevExpress.Utils.PointFloat(4.6736!, 172.72!)
        Me.XrLabel50.Multiline = True
        Me.XrLabel50.Name = "XrLabel50"
        Me.XrLabel50.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel50.SizeF = New System.Drawing.SizeF(391.6657!, 58.57541!)
        Me.XrLabel50.StylePriority.UseBackColor = False
        Me.XrLabel50.StylePriority.UseBorderColor = False
        Me.XrLabel50.StylePriority.UseBorders = False
        Me.XrLabel50.StylePriority.UseFont = False
        Me.XrLabel50.StylePriority.UseForeColor = False
        Me.XrLabel50.StylePriority.UsePadding = False
        Me.XrLabel50.StylePriority.UseTextAlignment = False
        Me.XrLabel50.Text = "Κωδικός Κουτιών:"
        Me.XrLabel50.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel51
        '
        Me.XrLabel51.BorderColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(113, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.XrLabel51.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrLabel51.Dpi = 254.0!
        Me.XrLabel51.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Dimension1]")})
        Me.XrLabel51.Font = New System.Drawing.Font("Zona Pro", 9.0!)
        Me.XrLabel51.ForeColor = System.Drawing.Color.Gray
        Me.XrLabel51.LocationFloat = New DevExpress.Utils.PointFloat(1252.949!, 5.079962!)
        Me.XrLabel51.Multiline = True
        Me.XrLabel51.Name = "XrLabel51"
        Me.XrLabel51.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel51.SizeF = New System.Drawing.SizeF(306.2107!, 58.57545!)
        Me.XrLabel51.StylePriority.UseBorderColor = False
        Me.XrLabel51.StylePriority.UseBorders = False
        Me.XrLabel51.StylePriority.UseFont = False
        Me.XrLabel51.StylePriority.UseForeColor = False
        Me.XrLabel51.StylePriority.UsePadding = False
        Me.XrLabel51.StylePriority.UseTextAlignment = False
        Me.XrLabel51.Text = "XrTableCell22"
        Me.XrLabel51.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrLabel51.TextFormatString = "{0:C}"
        '
        'XrLabel52
        '
        Me.XrLabel52.BackColor = System.Drawing.Color.Empty
        Me.XrLabel52.BorderColor = System.Drawing.Color.Empty
        Me.XrLabel52.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel52.Dpi = 254.0!
        Me.XrLabel52.Font = New System.Drawing.Font("Zona Pro Regular", 9.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel52.ForeColor = System.Drawing.Color.Gray
        Me.XrLabel52.LocationFloat = New DevExpress.Utils.PointFloat(926.4183!, 5.08!)
        Me.XrLabel52.Multiline = True
        Me.XrLabel52.Name = "XrLabel52"
        Me.XrLabel52.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel52.SizeF = New System.Drawing.SizeF(326.5312!, 58.57545!)
        Me.XrLabel52.StylePriority.UseBackColor = False
        Me.XrLabel52.StylePriority.UseBorderColor = False
        Me.XrLabel52.StylePriority.UseBorders = False
        Me.XrLabel52.StylePriority.UseFont = False
        Me.XrLabel52.StylePriority.UseForeColor = False
        Me.XrLabel52.StylePriority.UsePadding = False
        Me.XrLabel52.StylePriority.UseTextAlignment = False
        Me.XrLabel52.Text = "Διαστάσεις"
        Me.XrLabel52.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel53
        '
        Me.XrLabel53.BorderColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(113, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.XrLabel53.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrLabel53.Dpi = 254.0!
        Me.XrLabel53.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Model1]")})
        Me.XrLabel53.Font = New System.Drawing.Font("Zona Pro", 9.0!)
        Me.XrLabel53.ForeColor = System.Drawing.Color.Gray
        Me.XrLabel53.LocationFloat = New DevExpress.Utils.PointFloat(396.3449!, 5.080079!)
        Me.XrLabel53.Multiline = True
        Me.XrLabel53.Name = "XrLabel53"
        Me.XrLabel53.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel53.SizeF = New System.Drawing.SizeF(530.0734!, 58.57542!)
        Me.XrLabel53.StylePriority.UseBorderColor = False
        Me.XrLabel53.StylePriority.UseBorders = False
        Me.XrLabel53.StylePriority.UseFont = False
        Me.XrLabel53.StylePriority.UseForeColor = False
        Me.XrLabel53.StylePriority.UsePadding = False
        Me.XrLabel53.StylePriority.UseTextAlignment = False
        Me.XrLabel53.Text = "XrTableCell20"
        Me.XrLabel53.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel54
        '
        Me.XrLabel54.BackColor = System.Drawing.Color.Empty
        Me.XrLabel54.BorderColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(113, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.XrLabel54.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel54.Dpi = 254.0!
        Me.XrLabel54.Font = New System.Drawing.Font("Zona Pro", 9.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel54.ForeColor = System.Drawing.Color.Gray
        Me.XrLabel54.LocationFloat = New DevExpress.Utils.PointFloat(4.679394!, 5.080079!)
        Me.XrLabel54.Multiline = True
        Me.XrLabel54.Name = "XrLabel54"
        Me.XrLabel54.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel54.SizeF = New System.Drawing.SizeF(391.6599!, 58.41995!)
        Me.XrLabel54.StylePriority.UseBackColor = False
        Me.XrLabel54.StylePriority.UseBorderColor = False
        Me.XrLabel54.StylePriority.UseBorders = False
        Me.XrLabel54.StylePriority.UseFont = False
        Me.XrLabel54.StylePriority.UseForeColor = False
        Me.XrLabel54.StylePriority.UsePadding = False
        Me.XrLabel54.StylePriority.UseTextAlignment = False
        Me.XrLabel54.Text = "Τύπος:"
        Me.XrLabel54.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrCheckBox1
        '
        Me.XrCheckBox1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(113, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.XrCheckBox1.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrCheckBox1.Dpi = 254.0!
        Me.XrCheckBox1.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "CheckBoxState", "[HoodAlignment]")})
        Me.XrCheckBox1.LocationFloat = New DevExpress.Utils.PointFloat(1509.107!, 80.31259!)
        Me.XrCheckBox1.Name = "XrCheckBox1"
        Me.XrCheckBox1.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrCheckBox1.SizeF = New System.Drawing.SizeF(50.05249!, 58.41969!)
        Me.XrCheckBox1.StylePriority.UseBorderColor = False
        Me.XrCheckBox1.StylePriority.UseBorders = False
        '
        'XrLabel55
        '
        Me.XrLabel55.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel55.CanShrink = True
        Me.XrLabel55.Dpi = 254.0!
        Me.XrLabel55.Font = New System.Drawing.Font("Zona Pro", 9.0!)
        Me.XrLabel55.ForeColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(113, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.XrLabel55.LocationFloat = New DevExpress.Utils.PointFloat(1046.472!, 88.89995!)
        Me.XrLabel55.Name = "XrLabel55"
        Me.XrLabel55.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel55.SizeF = New System.Drawing.SizeF(457.5557!, 52.37231!)
        Me.XrLabel55.StylePriority.UseBorders = False
        Me.XrLabel55.StylePriority.UseFont = False
        Me.XrLabel55.StylePriority.UseForeColor = False
        Me.XrLabel55.StylePriority.UsePadding = False
        Me.XrLabel55.StylePriority.UseTextAlignment = False
        Me.XrLabel55.Text = "Χωνευτό προφίλ για Led :"
        Me.XrLabel55.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel56
        '
        Me.XrLabel56.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel56.CanShrink = True
        Me.XrLabel56.Dpi = 254.0!
        Me.XrLabel56.Font = New System.Drawing.Font("Zona Pro", 9.0!)
        Me.XrLabel56.ForeColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(113, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.XrLabel56.LocationFloat = New DevExpress.Utils.PointFloat(582.9641!, 88.9!)
        Me.XrLabel56.Name = "XrLabel56"
        Me.XrLabel56.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel56.SizeF = New System.Drawing.SizeF(282.1962!, 58.42001!)
        Me.XrLabel56.StylePriority.UseBorders = False
        Me.XrLabel56.StylePriority.UseFont = False
        Me.XrLabel56.StylePriority.UseForeColor = False
        Me.XrLabel56.StylePriority.UsePadding = False
        Me.XrLabel56.StylePriority.UseTextAlignment = False
        Me.XrLabel56.Text = "Πάχος Πλάτης:"
        Me.XrLabel56.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel57
        '
        Me.XrLabel57.BorderColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(113, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.XrLabel57.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrLabel57.Dpi = 254.0!
        Me.XrLabel57.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[vw_CCT_ORDERS_CLOSET].[boxThikness]")})
        Me.XrLabel57.Font = New System.Drawing.Font("Zona Pro", 9.0!)
        Me.XrLabel57.ForeColor = System.Drawing.Color.Gray
        Me.XrLabel57.LocationFloat = New DevExpress.Utils.PointFloat(865.1606!, 88.89995!)
        Me.XrLabel57.Multiline = True
        Me.XrLabel57.Name = "XrLabel57"
        Me.XrLabel57.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel57.SizeF = New System.Drawing.SizeF(158.3397!, 58.42015!)
        Me.XrLabel57.StylePriority.UseBorderColor = False
        Me.XrLabel57.StylePriority.UseBorders = False
        Me.XrLabel57.StylePriority.UseFont = False
        Me.XrLabel57.StylePriority.UseForeColor = False
        Me.XrLabel57.StylePriority.UseTextAlignment = False
        Me.XrLabel57.Text = "XrLabel55"
        Me.XrLabel57.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel58
        '
        Me.XrLabel58.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel58.CanShrink = True
        Me.XrLabel58.Dpi = 254.0!
        Me.XrLabel58.Font = New System.Drawing.Font("Zona Pro", 9.0!)
        Me.XrLabel58.ForeColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(113, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.XrLabel58.LocationFloat = New DevExpress.Utils.PointFloat(4.679379!, 88.89995!)
        Me.XrLabel58.Name = "XrLabel58"
        Me.XrLabel58.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel58.SizeF = New System.Drawing.SizeF(391.6599!, 58.41992!)
        Me.XrLabel58.StylePriority.UseBorders = False
        Me.XrLabel58.StylePriority.UseFont = False
        Me.XrLabel58.StylePriority.UseForeColor = False
        Me.XrLabel58.StylePriority.UsePadding = False
        Me.XrLabel58.StylePriority.UseTextAlignment = False
        Me.XrLabel58.Text = "Πάχος Κασώματος:"
        Me.XrLabel58.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel59
        '
        Me.XrLabel59.BorderColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(113, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.XrLabel59.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrLabel59.Dpi = 254.0!
        Me.XrLabel59.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[vw_CCT_ORDERS_CLOSET].[boxThikness]")})
        Me.XrLabel59.Font = New System.Drawing.Font("Zona Pro", 9.0!)
        Me.XrLabel59.ForeColor = System.Drawing.Color.Gray
        Me.XrLabel59.LocationFloat = New DevExpress.Utils.PointFloat(396.3441!, 88.89995!)
        Me.XrLabel59.Multiline = True
        Me.XrLabel59.Name = "XrLabel59"
        Me.XrLabel59.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel59.SizeF = New System.Drawing.SizeF(165.449!, 58.42015!)
        Me.XrLabel59.StylePriority.UseBorderColor = False
        Me.XrLabel59.StylePriority.UseBorders = False
        Me.XrLabel59.StylePriority.UseFont = False
        Me.XrLabel59.StylePriority.UseForeColor = False
        Me.XrLabel59.StylePriority.UseTextAlignment = False
        Me.XrLabel59.Text = "XrLabel55"
        Me.XrLabel59.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrPanel4
        '
        Me.XrPanel4.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrPanel4.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel60, Me.XrLabel61, Me.XrLabel62, Me.XrLabel64, Me.XrLabel65, Me.XrLabel66, Me.XrLabel67, Me.XrLabel68, Me.XrLabel69, Me.XrLabel70, Me.XrLabel71, Me.XrLabel72, Me.XrLabel73, Me.XrCheckBox3, Me.XrLabel74, Me.XrLabel75, Me.XrLabel76, Me.XrLabel77, Me.XrLabel78})
        Me.XrPanel4.Dpi = 254.0!
        Me.XrPanel4.LocationFloat = New DevExpress.Utils.PointFloat(8.020736!, 1363.922!)
        Me.XrPanel4.Name = "XrPanel4"
        Me.XrPanel4.SizeF = New System.Drawing.SizeF(1579.48!, 420.9469!)
        Me.XrPanel4.StylePriority.UseBorders = False
        '
        'XrLabel60
        '
        Me.XrLabel60.BorderColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(113, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.XrLabel60.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrLabel60.Dpi = 254.0!
        Me.XrLabel60.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[BOXName]")})
        Me.XrLabel60.Font = New System.Drawing.Font("Zona Pro Regular", 8.0!)
        Me.XrLabel60.ForeColor = System.Drawing.Color.Gray
        Me.XrLabel60.LocationFloat = New DevExpress.Utils.PointFloat(966.4923!, 256.54!)
        Me.XrLabel60.Multiline = True
        Me.XrLabel60.Name = "XrLabel60"
        Me.XrLabel60.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel60.SizeF = New System.Drawing.SizeF(570.1476!, 58.57541!)
        Me.XrLabel60.StylePriority.UseBorderColor = False
        Me.XrLabel60.StylePriority.UseBorders = False
        Me.XrLabel60.StylePriority.UseFont = False
        Me.XrLabel60.StylePriority.UseForeColor = False
        Me.XrLabel60.StylePriority.UsePadding = False
        Me.XrLabel60.StylePriority.UseTextAlignment = False
        Me.XrLabel60.Text = "XrTableCell2"
        Me.XrLabel60.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel61
        '
        Me.XrLabel61.BorderColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(113, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.XrLabel61.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrLabel61.Dpi = 254.0!
        Me.XrLabel61.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[BOXName]")})
        Me.XrLabel61.Font = New System.Drawing.Font("Zona Pro Regular", 8.0!)
        Me.XrLabel61.ForeColor = System.Drawing.Color.Gray
        Me.XrLabel61.LocationFloat = New DevExpress.Utils.PointFloat(396.3449!, 340.36!)
        Me.XrLabel61.Multiline = True
        Me.XrLabel61.Name = "XrLabel61"
        Me.XrLabel61.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel61.SizeF = New System.Drawing.SizeF(1162.815!, 58.57544!)
        Me.XrLabel61.StylePriority.UseBorderColor = False
        Me.XrLabel61.StylePriority.UseBorders = False
        Me.XrLabel61.StylePriority.UseFont = False
        Me.XrLabel61.StylePriority.UseForeColor = False
        Me.XrLabel61.StylePriority.UsePadding = False
        Me.XrLabel61.StylePriority.UseTextAlignment = False
        Me.XrLabel61.Text = "XrTableCell2"
        Me.XrLabel61.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel62
        '
        Me.XrLabel62.BorderColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(113, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.XrLabel62.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrLabel62.Dpi = 254.0!
        Me.XrLabel62.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[BOXName]")})
        Me.XrLabel62.Font = New System.Drawing.Font("Zona Pro Regular", 8.0!)
        Me.XrLabel62.ForeColor = System.Drawing.Color.Gray
        Me.XrLabel62.LocationFloat = New DevExpress.Utils.PointFloat(396.3449!, 256.54!)
        Me.XrLabel62.Multiline = True
        Me.XrLabel62.Name = "XrLabel62"
        Me.XrLabel62.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel62.SizeF = New System.Drawing.SizeF(570.1474!, 58.57541!)
        Me.XrLabel62.StylePriority.UseBorderColor = False
        Me.XrLabel62.StylePriority.UseBorders = False
        Me.XrLabel62.StylePriority.UseFont = False
        Me.XrLabel62.StylePriority.UseForeColor = False
        Me.XrLabel62.StylePriority.UsePadding = False
        Me.XrLabel62.StylePriority.UseTextAlignment = False
        Me.XrLabel62.Text = "XrTableCell2"
        Me.XrLabel62.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel64
        '
        Me.XrLabel64.BackColor = System.Drawing.Color.Empty
        Me.XrLabel64.BorderColor = System.Drawing.Color.Empty
        Me.XrLabel64.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel64.Dpi = 254.0!
        Me.XrLabel64.Font = New System.Drawing.Font("Zona Pro", 9.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel64.ForeColor = System.Drawing.Color.Gray
        Me.XrLabel64.LocationFloat = New DevExpress.Utils.PointFloat(4.6736!, 340.36!)
        Me.XrLabel64.Multiline = True
        Me.XrLabel64.Name = "XrLabel64"
        Me.XrLabel64.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel64.SizeF = New System.Drawing.SizeF(391.6657!, 58.57544!)
        Me.XrLabel64.StylePriority.UseBackColor = False
        Me.XrLabel64.StylePriority.UseBorderColor = False
        Me.XrLabel64.StylePriority.UseBorders = False
        Me.XrLabel64.StylePriority.UseFont = False
        Me.XrLabel64.StylePriority.UseForeColor = False
        Me.XrLabel64.StylePriority.UsePadding = False
        Me.XrLabel64.StylePriority.UseTextAlignment = False
        Me.XrLabel64.Text = "Κωδικός επενδύσεων:"
        Me.XrLabel64.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel65
        '
        Me.XrLabel65.BackColor = System.Drawing.Color.Empty
        Me.XrLabel65.BorderColor = System.Drawing.Color.Empty
        Me.XrLabel65.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel65.Dpi = 254.0!
        Me.XrLabel65.Font = New System.Drawing.Font("Zona Pro", 9.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel65.ForeColor = System.Drawing.Color.Gray
        Me.XrLabel65.LocationFloat = New DevExpress.Utils.PointFloat(4.6736!, 256.54!)
        Me.XrLabel65.Multiline = True
        Me.XrLabel65.Name = "XrLabel65"
        Me.XrLabel65.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel65.SizeF = New System.Drawing.SizeF(391.6657!, 58.57541!)
        Me.XrLabel65.StylePriority.UseBackColor = False
        Me.XrLabel65.StylePriority.UseBorderColor = False
        Me.XrLabel65.StylePriority.UseBorders = False
        Me.XrLabel65.StylePriority.UseFont = False
        Me.XrLabel65.StylePriority.UseForeColor = False
        Me.XrLabel65.StylePriority.UsePadding = False
        Me.XrLabel65.StylePriority.UseTextAlignment = False
        Me.XrLabel65.Text = "Κωδικός  Πόρτας:"
        Me.XrLabel65.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel66
        '
        Me.XrLabel66.BorderColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(113, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.XrLabel66.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrLabel66.Dpi = 254.0!
        Me.XrLabel66.Font = New System.Drawing.Font("Zona Pro Regular", 8.0!)
        Me.XrLabel66.ForeColor = System.Drawing.Color.Gray
        Me.XrLabel66.LocationFloat = New DevExpress.Utils.PointFloat(1098.917!, 172.7199!)
        Me.XrLabel66.Multiline = True
        Me.XrLabel66.Name = "XrLabel66"
        Me.XrLabel66.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel66.SizeF = New System.Drawing.SizeF(460.2432!, 58.57538!)
        Me.XrLabel66.StylePriority.UseBorderColor = False
        Me.XrLabel66.StylePriority.UseBorders = False
        Me.XrLabel66.StylePriority.UseFont = False
        Me.XrLabel66.StylePriority.UseForeColor = False
        Me.XrLabel66.StylePriority.UsePadding = False
        Me.XrLabel66.StylePriority.UseTextAlignment = False
        Me.XrLabel66.Text = "XrTableCell15"
        Me.XrLabel66.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel67
        '
        Me.XrLabel67.BackColor = System.Drawing.Color.Empty
        Me.XrLabel67.BorderColor = System.Drawing.Color.Empty
        Me.XrLabel67.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel67.Dpi = 254.0!
        Me.XrLabel67.Font = New System.Drawing.Font("Zona Pro Regular", 9.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel67.ForeColor = System.Drawing.Color.Gray
        Me.XrLabel67.LocationFloat = New DevExpress.Utils.PointFloat(810.116!, 172.7199!)
        Me.XrLabel67.Multiline = True
        Me.XrLabel67.Name = "XrLabel67"
        Me.XrLabel67.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel67.SizeF = New System.Drawing.SizeF(288.8008!, 58.57544!)
        Me.XrLabel67.StylePriority.UseBackColor = False
        Me.XrLabel67.StylePriority.UseBorderColor = False
        Me.XrLabel67.StylePriority.UseBorders = False
        Me.XrLabel67.StylePriority.UseFont = False
        Me.XrLabel67.StylePriority.UseForeColor = False
        Me.XrLabel67.StylePriority.UsePadding = False
        Me.XrLabel67.StylePriority.UseTextAlignment = False
        Me.XrLabel67.Text = "Κωδικός Ραφιών:"
        Me.XrLabel67.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel68
        '
        Me.XrLabel68.BorderColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(113, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.XrLabel68.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrLabel68.Dpi = 254.0!
        Me.XrLabel68.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[BOXName]")})
        Me.XrLabel68.Font = New System.Drawing.Font("Zona Pro Regular", 8.0!)
        Me.XrLabel68.ForeColor = System.Drawing.Color.Gray
        Me.XrLabel68.LocationFloat = New DevExpress.Utils.PointFloat(396.3449!, 172.7199!)
        Me.XrLabel68.Multiline = True
        Me.XrLabel68.Name = "XrLabel68"
        Me.XrLabel68.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel68.SizeF = New System.Drawing.SizeF(413.7711!, 58.57542!)
        Me.XrLabel68.StylePriority.UseBorderColor = False
        Me.XrLabel68.StylePriority.UseBorders = False
        Me.XrLabel68.StylePriority.UseFont = False
        Me.XrLabel68.StylePriority.UseForeColor = False
        Me.XrLabel68.StylePriority.UsePadding = False
        Me.XrLabel68.StylePriority.UseTextAlignment = False
        Me.XrLabel68.Text = "XrTableCell2"
        Me.XrLabel68.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel69
        '
        Me.XrLabel69.BackColor = System.Drawing.Color.Empty
        Me.XrLabel69.BorderColor = System.Drawing.Color.Empty
        Me.XrLabel69.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel69.Dpi = 254.0!
        Me.XrLabel69.Font = New System.Drawing.Font("Zona Pro", 9.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel69.ForeColor = System.Drawing.Color.Gray
        Me.XrLabel69.LocationFloat = New DevExpress.Utils.PointFloat(4.6736!, 172.72!)
        Me.XrLabel69.Multiline = True
        Me.XrLabel69.Name = "XrLabel69"
        Me.XrLabel69.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel69.SizeF = New System.Drawing.SizeF(391.6657!, 58.57541!)
        Me.XrLabel69.StylePriority.UseBackColor = False
        Me.XrLabel69.StylePriority.UseBorderColor = False
        Me.XrLabel69.StylePriority.UseBorders = False
        Me.XrLabel69.StylePriority.UseFont = False
        Me.XrLabel69.StylePriority.UseForeColor = False
        Me.XrLabel69.StylePriority.UsePadding = False
        Me.XrLabel69.StylePriority.UseTextAlignment = False
        Me.XrLabel69.Text = "Κωδικός Κουτιών:"
        Me.XrLabel69.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel70
        '
        Me.XrLabel70.BorderColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(113, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.XrLabel70.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrLabel70.Dpi = 254.0!
        Me.XrLabel70.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Dimension1]")})
        Me.XrLabel70.Font = New System.Drawing.Font("Zona Pro", 9.0!)
        Me.XrLabel70.ForeColor = System.Drawing.Color.Gray
        Me.XrLabel70.LocationFloat = New DevExpress.Utils.PointFloat(1252.949!, 5.079962!)
        Me.XrLabel70.Multiline = True
        Me.XrLabel70.Name = "XrLabel70"
        Me.XrLabel70.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel70.SizeF = New System.Drawing.SizeF(306.2107!, 58.57545!)
        Me.XrLabel70.StylePriority.UseBorderColor = False
        Me.XrLabel70.StylePriority.UseBorders = False
        Me.XrLabel70.StylePriority.UseFont = False
        Me.XrLabel70.StylePriority.UseForeColor = False
        Me.XrLabel70.StylePriority.UsePadding = False
        Me.XrLabel70.StylePriority.UseTextAlignment = False
        Me.XrLabel70.Text = "XrTableCell22"
        Me.XrLabel70.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrLabel70.TextFormatString = "{0:C}"
        '
        'XrLabel71
        '
        Me.XrLabel71.BackColor = System.Drawing.Color.Empty
        Me.XrLabel71.BorderColor = System.Drawing.Color.Empty
        Me.XrLabel71.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel71.Dpi = 254.0!
        Me.XrLabel71.Font = New System.Drawing.Font("Zona Pro Regular", 9.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel71.ForeColor = System.Drawing.Color.Gray
        Me.XrLabel71.LocationFloat = New DevExpress.Utils.PointFloat(926.4183!, 5.08!)
        Me.XrLabel71.Multiline = True
        Me.XrLabel71.Name = "XrLabel71"
        Me.XrLabel71.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel71.SizeF = New System.Drawing.SizeF(326.5312!, 58.57545!)
        Me.XrLabel71.StylePriority.UseBackColor = False
        Me.XrLabel71.StylePriority.UseBorderColor = False
        Me.XrLabel71.StylePriority.UseBorders = False
        Me.XrLabel71.StylePriority.UseFont = False
        Me.XrLabel71.StylePriority.UseForeColor = False
        Me.XrLabel71.StylePriority.UsePadding = False
        Me.XrLabel71.StylePriority.UseTextAlignment = False
        Me.XrLabel71.Text = "Διαστάσεις"
        Me.XrLabel71.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel72
        '
        Me.XrLabel72.BorderColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(113, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.XrLabel72.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrLabel72.Dpi = 254.0!
        Me.XrLabel72.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Model1]")})
        Me.XrLabel72.Font = New System.Drawing.Font("Zona Pro", 9.0!)
        Me.XrLabel72.ForeColor = System.Drawing.Color.Gray
        Me.XrLabel72.LocationFloat = New DevExpress.Utils.PointFloat(396.3449!, 5.080079!)
        Me.XrLabel72.Multiline = True
        Me.XrLabel72.Name = "XrLabel72"
        Me.XrLabel72.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel72.SizeF = New System.Drawing.SizeF(530.0734!, 58.57542!)
        Me.XrLabel72.StylePriority.UseBorderColor = False
        Me.XrLabel72.StylePriority.UseBorders = False
        Me.XrLabel72.StylePriority.UseFont = False
        Me.XrLabel72.StylePriority.UseForeColor = False
        Me.XrLabel72.StylePriority.UsePadding = False
        Me.XrLabel72.StylePriority.UseTextAlignment = False
        Me.XrLabel72.Text = "XrTableCell20"
        Me.XrLabel72.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel73
        '
        Me.XrLabel73.BackColor = System.Drawing.Color.Empty
        Me.XrLabel73.BorderColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(113, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.XrLabel73.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel73.Dpi = 254.0!
        Me.XrLabel73.Font = New System.Drawing.Font("Zona Pro", 9.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel73.ForeColor = System.Drawing.Color.Gray
        Me.XrLabel73.LocationFloat = New DevExpress.Utils.PointFloat(4.679394!, 5.080079!)
        Me.XrLabel73.Multiline = True
        Me.XrLabel73.Name = "XrLabel73"
        Me.XrLabel73.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel73.SizeF = New System.Drawing.SizeF(391.6599!, 58.41995!)
        Me.XrLabel73.StylePriority.UseBackColor = False
        Me.XrLabel73.StylePriority.UseBorderColor = False
        Me.XrLabel73.StylePriority.UseBorders = False
        Me.XrLabel73.StylePriority.UseFont = False
        Me.XrLabel73.StylePriority.UseForeColor = False
        Me.XrLabel73.StylePriority.UsePadding = False
        Me.XrLabel73.StylePriority.UseTextAlignment = False
        Me.XrLabel73.Text = "Τύπος:"
        Me.XrLabel73.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrCheckBox3
        '
        Me.XrCheckBox3.BorderColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(113, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.XrCheckBox3.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrCheckBox3.Dpi = 254.0!
        Me.XrCheckBox3.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "CheckBoxState", "[HoodAlignment]")})
        Me.XrCheckBox3.LocationFloat = New DevExpress.Utils.PointFloat(1509.107!, 80.31259!)
        Me.XrCheckBox3.Name = "XrCheckBox3"
        Me.XrCheckBox3.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrCheckBox3.SizeF = New System.Drawing.SizeF(50.05249!, 58.41969!)
        Me.XrCheckBox3.StylePriority.UseBorderColor = False
        Me.XrCheckBox3.StylePriority.UseBorders = False
        '
        'XrLabel74
        '
        Me.XrLabel74.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel74.CanShrink = True
        Me.XrLabel74.Dpi = 254.0!
        Me.XrLabel74.Font = New System.Drawing.Font("Zona Pro", 9.0!)
        Me.XrLabel74.ForeColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(113, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.XrLabel74.LocationFloat = New DevExpress.Utils.PointFloat(1046.472!, 88.89995!)
        Me.XrLabel74.Name = "XrLabel74"
        Me.XrLabel74.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel74.SizeF = New System.Drawing.SizeF(457.5557!, 52.37231!)
        Me.XrLabel74.StylePriority.UseBorders = False
        Me.XrLabel74.StylePriority.UseFont = False
        Me.XrLabel74.StylePriority.UseForeColor = False
        Me.XrLabel74.StylePriority.UsePadding = False
        Me.XrLabel74.StylePriority.UseTextAlignment = False
        Me.XrLabel74.Text = "Χωνευτό προφίλ για Led :"
        Me.XrLabel74.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel75
        '
        Me.XrLabel75.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel75.CanShrink = True
        Me.XrLabel75.Dpi = 254.0!
        Me.XrLabel75.Font = New System.Drawing.Font("Zona Pro", 9.0!)
        Me.XrLabel75.ForeColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(113, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.XrLabel75.LocationFloat = New DevExpress.Utils.PointFloat(582.9641!, 88.9!)
        Me.XrLabel75.Name = "XrLabel75"
        Me.XrLabel75.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel75.SizeF = New System.Drawing.SizeF(282.1962!, 58.42001!)
        Me.XrLabel75.StylePriority.UseBorders = False
        Me.XrLabel75.StylePriority.UseFont = False
        Me.XrLabel75.StylePriority.UseForeColor = False
        Me.XrLabel75.StylePriority.UsePadding = False
        Me.XrLabel75.StylePriority.UseTextAlignment = False
        Me.XrLabel75.Text = "Πάχος Πλάτης:"
        Me.XrLabel75.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel76
        '
        Me.XrLabel76.BorderColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(113, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.XrLabel76.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrLabel76.Dpi = 254.0!
        Me.XrLabel76.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[vw_CCT_ORDERS_CLOSET].[boxThikness]")})
        Me.XrLabel76.Font = New System.Drawing.Font("Zona Pro", 9.0!)
        Me.XrLabel76.ForeColor = System.Drawing.Color.Gray
        Me.XrLabel76.LocationFloat = New DevExpress.Utils.PointFloat(865.1606!, 88.89995!)
        Me.XrLabel76.Multiline = True
        Me.XrLabel76.Name = "XrLabel76"
        Me.XrLabel76.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel76.SizeF = New System.Drawing.SizeF(158.3397!, 58.42015!)
        Me.XrLabel76.StylePriority.UseBorderColor = False
        Me.XrLabel76.StylePriority.UseBorders = False
        Me.XrLabel76.StylePriority.UseFont = False
        Me.XrLabel76.StylePriority.UseForeColor = False
        Me.XrLabel76.StylePriority.UseTextAlignment = False
        Me.XrLabel76.Text = "XrLabel55"
        Me.XrLabel76.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel77
        '
        Me.XrLabel77.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel77.CanShrink = True
        Me.XrLabel77.Dpi = 254.0!
        Me.XrLabel77.Font = New System.Drawing.Font("Zona Pro", 9.0!)
        Me.XrLabel77.ForeColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(113, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.XrLabel77.LocationFloat = New DevExpress.Utils.PointFloat(4.679379!, 88.89995!)
        Me.XrLabel77.Name = "XrLabel77"
        Me.XrLabel77.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel77.SizeF = New System.Drawing.SizeF(391.6599!, 58.41992!)
        Me.XrLabel77.StylePriority.UseBorders = False
        Me.XrLabel77.StylePriority.UseFont = False
        Me.XrLabel77.StylePriority.UseForeColor = False
        Me.XrLabel77.StylePriority.UsePadding = False
        Me.XrLabel77.StylePriority.UseTextAlignment = False
        Me.XrLabel77.Text = "Πάχος Κασώματος:"
        Me.XrLabel77.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel78
        '
        Me.XrLabel78.BorderColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(113, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.XrLabel78.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrLabel78.Dpi = 254.0!
        Me.XrLabel78.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[vw_CCT_ORDERS_CLOSET].[boxThikness]")})
        Me.XrLabel78.Font = New System.Drawing.Font("Zona Pro", 9.0!)
        Me.XrLabel78.ForeColor = System.Drawing.Color.Gray
        Me.XrLabel78.LocationFloat = New DevExpress.Utils.PointFloat(396.3441!, 88.89995!)
        Me.XrLabel78.Multiline = True
        Me.XrLabel78.Name = "XrLabel78"
        Me.XrLabel78.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel78.SizeF = New System.Drawing.SizeF(165.449!, 58.42015!)
        Me.XrLabel78.StylePriority.UseBorderColor = False
        Me.XrLabel78.StylePriority.UseBorders = False
        Me.XrLabel78.StylePriority.UseFont = False
        Me.XrLabel78.StylePriority.UseForeColor = False
        Me.XrLabel78.StylePriority.UseTextAlignment = False
        Me.XrLabel78.Text = "XrLabel55"
        Me.XrLabel78.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrPanel5
        '
        Me.XrPanel5.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrPanel5.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel5, Me.XrLabel7, Me.XrLabel31, Me.XrLabel32, Me.XrLabel33, Me.XrLabel36, Me.XrLabel37, Me.XrLabel79, Me.XrLabel80, Me.XrLabel82, Me.XrLabel83, Me.XrLabel84, Me.XrLabel85, Me.XrCheckBox4, Me.XrLabel86, Me.XrLabel87, Me.XrLabel88, Me.XrLabel89, Me.XrLabel90})
        Me.XrPanel5.Dpi = 254.0!
        Me.XrPanel5.LocationFloat = New DevExpress.Utils.PointFloat(8.020736!, 1787.869!)
        Me.XrPanel5.Name = "XrPanel5"
        Me.XrPanel5.SizeF = New System.Drawing.SizeF(1579.48!, 420.9469!)
        Me.XrPanel5.StylePriority.UseBorders = False
        '
        'XrLabel5
        '
        Me.XrLabel5.BorderColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(113, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.XrLabel5.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrLabel5.Dpi = 254.0!
        Me.XrLabel5.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[BOXName]")})
        Me.XrLabel5.Font = New System.Drawing.Font("Zona Pro Regular", 8.0!)
        Me.XrLabel5.ForeColor = System.Drawing.Color.Gray
        Me.XrLabel5.LocationFloat = New DevExpress.Utils.PointFloat(966.4923!, 256.54!)
        Me.XrLabel5.Multiline = True
        Me.XrLabel5.Name = "XrLabel5"
        Me.XrLabel5.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel5.SizeF = New System.Drawing.SizeF(570.1476!, 58.57541!)
        Me.XrLabel5.StylePriority.UseBorderColor = False
        Me.XrLabel5.StylePriority.UseBorders = False
        Me.XrLabel5.StylePriority.UseFont = False
        Me.XrLabel5.StylePriority.UseForeColor = False
        Me.XrLabel5.StylePriority.UsePadding = False
        Me.XrLabel5.StylePriority.UseTextAlignment = False
        Me.XrLabel5.Text = "XrTableCell2"
        Me.XrLabel5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel7
        '
        Me.XrLabel7.BorderColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(113, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.XrLabel7.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrLabel7.Dpi = 254.0!
        Me.XrLabel7.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[BOXName]")})
        Me.XrLabel7.Font = New System.Drawing.Font("Zona Pro Regular", 8.0!)
        Me.XrLabel7.ForeColor = System.Drawing.Color.Gray
        Me.XrLabel7.LocationFloat = New DevExpress.Utils.PointFloat(396.3449!, 340.36!)
        Me.XrLabel7.Multiline = True
        Me.XrLabel7.Name = "XrLabel7"
        Me.XrLabel7.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel7.SizeF = New System.Drawing.SizeF(1162.815!, 58.57544!)
        Me.XrLabel7.StylePriority.UseBorderColor = False
        Me.XrLabel7.StylePriority.UseBorders = False
        Me.XrLabel7.StylePriority.UseFont = False
        Me.XrLabel7.StylePriority.UseForeColor = False
        Me.XrLabel7.StylePriority.UsePadding = False
        Me.XrLabel7.StylePriority.UseTextAlignment = False
        Me.XrLabel7.Text = "XrTableCell2"
        Me.XrLabel7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel31
        '
        Me.XrLabel31.BorderColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(113, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.XrLabel31.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrLabel31.Dpi = 254.0!
        Me.XrLabel31.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[BOXName]")})
        Me.XrLabel31.Font = New System.Drawing.Font("Zona Pro Regular", 8.0!)
        Me.XrLabel31.ForeColor = System.Drawing.Color.Gray
        Me.XrLabel31.LocationFloat = New DevExpress.Utils.PointFloat(396.3449!, 256.54!)
        Me.XrLabel31.Multiline = True
        Me.XrLabel31.Name = "XrLabel31"
        Me.XrLabel31.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel31.SizeF = New System.Drawing.SizeF(570.1474!, 58.57541!)
        Me.XrLabel31.StylePriority.UseBorderColor = False
        Me.XrLabel31.StylePriority.UseBorders = False
        Me.XrLabel31.StylePriority.UseFont = False
        Me.XrLabel31.StylePriority.UseForeColor = False
        Me.XrLabel31.StylePriority.UsePadding = False
        Me.XrLabel31.StylePriority.UseTextAlignment = False
        Me.XrLabel31.Text = "XrTableCell2"
        Me.XrLabel31.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel32
        '
        Me.XrLabel32.BackColor = System.Drawing.Color.Empty
        Me.XrLabel32.BorderColor = System.Drawing.Color.Empty
        Me.XrLabel32.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel32.Dpi = 254.0!
        Me.XrLabel32.Font = New System.Drawing.Font("Zona Pro", 9.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel32.ForeColor = System.Drawing.Color.Gray
        Me.XrLabel32.LocationFloat = New DevExpress.Utils.PointFloat(4.6736!, 340.36!)
        Me.XrLabel32.Multiline = True
        Me.XrLabel32.Name = "XrLabel32"
        Me.XrLabel32.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel32.SizeF = New System.Drawing.SizeF(391.6657!, 58.57544!)
        Me.XrLabel32.StylePriority.UseBackColor = False
        Me.XrLabel32.StylePriority.UseBorderColor = False
        Me.XrLabel32.StylePriority.UseBorders = False
        Me.XrLabel32.StylePriority.UseFont = False
        Me.XrLabel32.StylePriority.UseForeColor = False
        Me.XrLabel32.StylePriority.UsePadding = False
        Me.XrLabel32.StylePriority.UseTextAlignment = False
        Me.XrLabel32.Text = "Κωδικός επενδύσεων:"
        Me.XrLabel32.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel33
        '
        Me.XrLabel33.BackColor = System.Drawing.Color.Empty
        Me.XrLabel33.BorderColor = System.Drawing.Color.Empty
        Me.XrLabel33.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel33.Dpi = 254.0!
        Me.XrLabel33.Font = New System.Drawing.Font("Zona Pro", 9.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel33.ForeColor = System.Drawing.Color.Gray
        Me.XrLabel33.LocationFloat = New DevExpress.Utils.PointFloat(4.6736!, 256.54!)
        Me.XrLabel33.Multiline = True
        Me.XrLabel33.Name = "XrLabel33"
        Me.XrLabel33.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel33.SizeF = New System.Drawing.SizeF(391.6657!, 58.57541!)
        Me.XrLabel33.StylePriority.UseBackColor = False
        Me.XrLabel33.StylePriority.UseBorderColor = False
        Me.XrLabel33.StylePriority.UseBorders = False
        Me.XrLabel33.StylePriority.UseFont = False
        Me.XrLabel33.StylePriority.UseForeColor = False
        Me.XrLabel33.StylePriority.UsePadding = False
        Me.XrLabel33.StylePriority.UseTextAlignment = False
        Me.XrLabel33.Text = "Κωδικός  Πόρτας:"
        Me.XrLabel33.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel36
        '
        Me.XrLabel36.BorderColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(113, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.XrLabel36.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrLabel36.Dpi = 254.0!
        Me.XrLabel36.Font = New System.Drawing.Font("Zona Pro Regular", 8.0!)
        Me.XrLabel36.ForeColor = System.Drawing.Color.Gray
        Me.XrLabel36.LocationFloat = New DevExpress.Utils.PointFloat(1098.917!, 172.7199!)
        Me.XrLabel36.Multiline = True
        Me.XrLabel36.Name = "XrLabel36"
        Me.XrLabel36.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel36.SizeF = New System.Drawing.SizeF(460.2432!, 58.57538!)
        Me.XrLabel36.StylePriority.UseBorderColor = False
        Me.XrLabel36.StylePriority.UseBorders = False
        Me.XrLabel36.StylePriority.UseFont = False
        Me.XrLabel36.StylePriority.UseForeColor = False
        Me.XrLabel36.StylePriority.UsePadding = False
        Me.XrLabel36.StylePriority.UseTextAlignment = False
        Me.XrLabel36.Text = "XrTableCell15"
        Me.XrLabel36.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel37
        '
        Me.XrLabel37.BackColor = System.Drawing.Color.Empty
        Me.XrLabel37.BorderColor = System.Drawing.Color.Empty
        Me.XrLabel37.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel37.Dpi = 254.0!
        Me.XrLabel37.Font = New System.Drawing.Font("Zona Pro Regular", 9.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel37.ForeColor = System.Drawing.Color.Gray
        Me.XrLabel37.LocationFloat = New DevExpress.Utils.PointFloat(810.116!, 172.7199!)
        Me.XrLabel37.Multiline = True
        Me.XrLabel37.Name = "XrLabel37"
        Me.XrLabel37.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel37.SizeF = New System.Drawing.SizeF(288.8008!, 58.57544!)
        Me.XrLabel37.StylePriority.UseBackColor = False
        Me.XrLabel37.StylePriority.UseBorderColor = False
        Me.XrLabel37.StylePriority.UseBorders = False
        Me.XrLabel37.StylePriority.UseFont = False
        Me.XrLabel37.StylePriority.UseForeColor = False
        Me.XrLabel37.StylePriority.UsePadding = False
        Me.XrLabel37.StylePriority.UseTextAlignment = False
        Me.XrLabel37.Text = "Κωδικός Ραφιών:"
        Me.XrLabel37.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel79
        '
        Me.XrLabel79.BorderColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(113, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.XrLabel79.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrLabel79.Dpi = 254.0!
        Me.XrLabel79.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[BOXName]")})
        Me.XrLabel79.Font = New System.Drawing.Font("Zona Pro Regular", 8.0!)
        Me.XrLabel79.ForeColor = System.Drawing.Color.Gray
        Me.XrLabel79.LocationFloat = New DevExpress.Utils.PointFloat(396.3449!, 172.7199!)
        Me.XrLabel79.Multiline = True
        Me.XrLabel79.Name = "XrLabel79"
        Me.XrLabel79.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel79.SizeF = New System.Drawing.SizeF(413.7711!, 58.57542!)
        Me.XrLabel79.StylePriority.UseBorderColor = False
        Me.XrLabel79.StylePriority.UseBorders = False
        Me.XrLabel79.StylePriority.UseFont = False
        Me.XrLabel79.StylePriority.UseForeColor = False
        Me.XrLabel79.StylePriority.UsePadding = False
        Me.XrLabel79.StylePriority.UseTextAlignment = False
        Me.XrLabel79.Text = "XrTableCell2"
        Me.XrLabel79.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel80
        '
        Me.XrLabel80.BackColor = System.Drawing.Color.Empty
        Me.XrLabel80.BorderColor = System.Drawing.Color.Empty
        Me.XrLabel80.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel80.Dpi = 254.0!
        Me.XrLabel80.Font = New System.Drawing.Font("Zona Pro", 9.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel80.ForeColor = System.Drawing.Color.Gray
        Me.XrLabel80.LocationFloat = New DevExpress.Utils.PointFloat(4.6736!, 172.72!)
        Me.XrLabel80.Multiline = True
        Me.XrLabel80.Name = "XrLabel80"
        Me.XrLabel80.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel80.SizeF = New System.Drawing.SizeF(391.6657!, 58.57541!)
        Me.XrLabel80.StylePriority.UseBackColor = False
        Me.XrLabel80.StylePriority.UseBorderColor = False
        Me.XrLabel80.StylePriority.UseBorders = False
        Me.XrLabel80.StylePriority.UseFont = False
        Me.XrLabel80.StylePriority.UseForeColor = False
        Me.XrLabel80.StylePriority.UsePadding = False
        Me.XrLabel80.StylePriority.UseTextAlignment = False
        Me.XrLabel80.Text = "Κωδικός Κουτιών:"
        Me.XrLabel80.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel82
        '
        Me.XrLabel82.BorderColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(113, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.XrLabel82.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrLabel82.Dpi = 254.0!
        Me.XrLabel82.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Dimension1]")})
        Me.XrLabel82.Font = New System.Drawing.Font("Zona Pro", 9.0!)
        Me.XrLabel82.ForeColor = System.Drawing.Color.Gray
        Me.XrLabel82.LocationFloat = New DevExpress.Utils.PointFloat(1252.949!, 5.079962!)
        Me.XrLabel82.Multiline = True
        Me.XrLabel82.Name = "XrLabel82"
        Me.XrLabel82.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel82.SizeF = New System.Drawing.SizeF(306.2107!, 58.57545!)
        Me.XrLabel82.StylePriority.UseBorderColor = False
        Me.XrLabel82.StylePriority.UseBorders = False
        Me.XrLabel82.StylePriority.UseFont = False
        Me.XrLabel82.StylePriority.UseForeColor = False
        Me.XrLabel82.StylePriority.UsePadding = False
        Me.XrLabel82.StylePriority.UseTextAlignment = False
        Me.XrLabel82.Text = "XrTableCell22"
        Me.XrLabel82.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrLabel82.TextFormatString = "{0:C}"
        '
        'XrLabel83
        '
        Me.XrLabel83.BackColor = System.Drawing.Color.Empty
        Me.XrLabel83.BorderColor = System.Drawing.Color.Empty
        Me.XrLabel83.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel83.Dpi = 254.0!
        Me.XrLabel83.Font = New System.Drawing.Font("Zona Pro Regular", 9.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel83.ForeColor = System.Drawing.Color.Gray
        Me.XrLabel83.LocationFloat = New DevExpress.Utils.PointFloat(926.4183!, 5.08!)
        Me.XrLabel83.Multiline = True
        Me.XrLabel83.Name = "XrLabel83"
        Me.XrLabel83.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel83.SizeF = New System.Drawing.SizeF(326.5312!, 58.57545!)
        Me.XrLabel83.StylePriority.UseBackColor = False
        Me.XrLabel83.StylePriority.UseBorderColor = False
        Me.XrLabel83.StylePriority.UseBorders = False
        Me.XrLabel83.StylePriority.UseFont = False
        Me.XrLabel83.StylePriority.UseForeColor = False
        Me.XrLabel83.StylePriority.UsePadding = False
        Me.XrLabel83.StylePriority.UseTextAlignment = False
        Me.XrLabel83.Text = "Διαστάσεις"
        Me.XrLabel83.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel84
        '
        Me.XrLabel84.BorderColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(113, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.XrLabel84.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrLabel84.Dpi = 254.0!
        Me.XrLabel84.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Model1]")})
        Me.XrLabel84.Font = New System.Drawing.Font("Zona Pro", 9.0!)
        Me.XrLabel84.ForeColor = System.Drawing.Color.Gray
        Me.XrLabel84.LocationFloat = New DevExpress.Utils.PointFloat(396.3449!, 5.080079!)
        Me.XrLabel84.Multiline = True
        Me.XrLabel84.Name = "XrLabel84"
        Me.XrLabel84.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel84.SizeF = New System.Drawing.SizeF(530.0734!, 58.57542!)
        Me.XrLabel84.StylePriority.UseBorderColor = False
        Me.XrLabel84.StylePriority.UseBorders = False
        Me.XrLabel84.StylePriority.UseFont = False
        Me.XrLabel84.StylePriority.UseForeColor = False
        Me.XrLabel84.StylePriority.UsePadding = False
        Me.XrLabel84.StylePriority.UseTextAlignment = False
        Me.XrLabel84.Text = "XrTableCell20"
        Me.XrLabel84.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel85
        '
        Me.XrLabel85.BackColor = System.Drawing.Color.Empty
        Me.XrLabel85.BorderColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(113, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.XrLabel85.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel85.Dpi = 254.0!
        Me.XrLabel85.Font = New System.Drawing.Font("Zona Pro", 9.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel85.ForeColor = System.Drawing.Color.Gray
        Me.XrLabel85.LocationFloat = New DevExpress.Utils.PointFloat(4.679394!, 5.080079!)
        Me.XrLabel85.Multiline = True
        Me.XrLabel85.Name = "XrLabel85"
        Me.XrLabel85.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel85.SizeF = New System.Drawing.SizeF(391.6599!, 58.41995!)
        Me.XrLabel85.StylePriority.UseBackColor = False
        Me.XrLabel85.StylePriority.UseBorderColor = False
        Me.XrLabel85.StylePriority.UseBorders = False
        Me.XrLabel85.StylePriority.UseFont = False
        Me.XrLabel85.StylePriority.UseForeColor = False
        Me.XrLabel85.StylePriority.UsePadding = False
        Me.XrLabel85.StylePriority.UseTextAlignment = False
        Me.XrLabel85.Text = "Τύπος:"
        Me.XrLabel85.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrCheckBox4
        '
        Me.XrCheckBox4.BorderColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(113, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.XrCheckBox4.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrCheckBox4.Dpi = 254.0!
        Me.XrCheckBox4.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "CheckBoxState", "[HoodAlignment]")})
        Me.XrCheckBox4.LocationFloat = New DevExpress.Utils.PointFloat(1509.107!, 80.31259!)
        Me.XrCheckBox4.Name = "XrCheckBox4"
        Me.XrCheckBox4.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrCheckBox4.SizeF = New System.Drawing.SizeF(50.05249!, 58.41969!)
        Me.XrCheckBox4.StylePriority.UseBorderColor = False
        Me.XrCheckBox4.StylePriority.UseBorders = False
        '
        'XrLabel86
        '
        Me.XrLabel86.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel86.CanShrink = True
        Me.XrLabel86.Dpi = 254.0!
        Me.XrLabel86.Font = New System.Drawing.Font("Zona Pro", 9.0!)
        Me.XrLabel86.ForeColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(113, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.XrLabel86.LocationFloat = New DevExpress.Utils.PointFloat(1046.472!, 88.89995!)
        Me.XrLabel86.Name = "XrLabel86"
        Me.XrLabel86.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel86.SizeF = New System.Drawing.SizeF(457.5557!, 52.37231!)
        Me.XrLabel86.StylePriority.UseBorders = False
        Me.XrLabel86.StylePriority.UseFont = False
        Me.XrLabel86.StylePriority.UseForeColor = False
        Me.XrLabel86.StylePriority.UsePadding = False
        Me.XrLabel86.StylePriority.UseTextAlignment = False
        Me.XrLabel86.Text = "Χωνευτό προφίλ για Led :"
        Me.XrLabel86.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel87
        '
        Me.XrLabel87.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel87.CanShrink = True
        Me.XrLabel87.Dpi = 254.0!
        Me.XrLabel87.Font = New System.Drawing.Font("Zona Pro", 9.0!)
        Me.XrLabel87.ForeColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(113, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.XrLabel87.LocationFloat = New DevExpress.Utils.PointFloat(582.9641!, 88.9!)
        Me.XrLabel87.Name = "XrLabel87"
        Me.XrLabel87.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel87.SizeF = New System.Drawing.SizeF(282.1962!, 58.42001!)
        Me.XrLabel87.StylePriority.UseBorders = False
        Me.XrLabel87.StylePriority.UseFont = False
        Me.XrLabel87.StylePriority.UseForeColor = False
        Me.XrLabel87.StylePriority.UsePadding = False
        Me.XrLabel87.StylePriority.UseTextAlignment = False
        Me.XrLabel87.Text = "Πάχος Πλάτης:"
        Me.XrLabel87.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel88
        '
        Me.XrLabel88.BorderColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(113, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.XrLabel88.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrLabel88.Dpi = 254.0!
        Me.XrLabel88.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[vw_CCT_ORDERS_CLOSET].[boxThikness]")})
        Me.XrLabel88.Font = New System.Drawing.Font("Zona Pro", 9.0!)
        Me.XrLabel88.ForeColor = System.Drawing.Color.Gray
        Me.XrLabel88.LocationFloat = New DevExpress.Utils.PointFloat(865.1606!, 88.89995!)
        Me.XrLabel88.Multiline = True
        Me.XrLabel88.Name = "XrLabel88"
        Me.XrLabel88.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel88.SizeF = New System.Drawing.SizeF(158.3397!, 58.42015!)
        Me.XrLabel88.StylePriority.UseBorderColor = False
        Me.XrLabel88.StylePriority.UseBorders = False
        Me.XrLabel88.StylePriority.UseFont = False
        Me.XrLabel88.StylePriority.UseForeColor = False
        Me.XrLabel88.StylePriority.UseTextAlignment = False
        Me.XrLabel88.Text = "XrLabel55"
        Me.XrLabel88.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel89
        '
        Me.XrLabel89.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel89.CanShrink = True
        Me.XrLabel89.Dpi = 254.0!
        Me.XrLabel89.Font = New System.Drawing.Font("Zona Pro", 9.0!)
        Me.XrLabel89.ForeColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(113, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.XrLabel89.LocationFloat = New DevExpress.Utils.PointFloat(4.679379!, 88.89995!)
        Me.XrLabel89.Name = "XrLabel89"
        Me.XrLabel89.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel89.SizeF = New System.Drawing.SizeF(391.6599!, 58.41992!)
        Me.XrLabel89.StylePriority.UseBorders = False
        Me.XrLabel89.StylePriority.UseFont = False
        Me.XrLabel89.StylePriority.UseForeColor = False
        Me.XrLabel89.StylePriority.UsePadding = False
        Me.XrLabel89.StylePriority.UseTextAlignment = False
        Me.XrLabel89.Text = "Πάχος Κασώματος:"
        Me.XrLabel89.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel90
        '
        Me.XrLabel90.BorderColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(113, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.XrLabel90.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrLabel90.Dpi = 254.0!
        Me.XrLabel90.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[vw_CCT_ORDERS_CLOSET].[boxThikness]")})
        Me.XrLabel90.Font = New System.Drawing.Font("Zona Pro", 9.0!)
        Me.XrLabel90.ForeColor = System.Drawing.Color.Gray
        Me.XrLabel90.LocationFloat = New DevExpress.Utils.PointFloat(396.3441!, 88.89995!)
        Me.XrLabel90.Multiline = True
        Me.XrLabel90.Name = "XrLabel90"
        Me.XrLabel90.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel90.SizeF = New System.Drawing.SizeF(165.449!, 58.42015!)
        Me.XrLabel90.StylePriority.UseBorderColor = False
        Me.XrLabel90.StylePriority.UseBorders = False
        Me.XrLabel90.StylePriority.UseFont = False
        Me.XrLabel90.StylePriority.UseForeColor = False
        Me.XrLabel90.StylePriority.UseTextAlignment = False
        Me.XrLabel90.Text = "XrLabel55"
        Me.XrLabel90.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrPanel6
        '
        Me.XrPanel6.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrPanel6.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel92, Me.XrLabel93, Me.XrLabel94, Me.XrLabel95, Me.XrLabel96, Me.XrLabel97, Me.XrLabel98, Me.XrLabel99, Me.XrLabel100, Me.XrLabel101, Me.XrLabel102, Me.XrLabel103, Me.XrLabel104, Me.XrCheckBox5, Me.XrLabel105, Me.XrLabel106, Me.XrLabel107, Me.XrLabel108, Me.XrLabel109})
        Me.XrPanel6.Dpi = 254.0!
        Me.XrPanel6.LocationFloat = New DevExpress.Utils.PointFloat(8.020736!, 2212.816!)
        Me.XrPanel6.Name = "XrPanel6"
        Me.XrPanel6.SizeF = New System.Drawing.SizeF(1579.48!, 420.9469!)
        Me.XrPanel6.StylePriority.UseBorders = False
        '
        'XrLabel92
        '
        Me.XrLabel92.BorderColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(113, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.XrLabel92.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrLabel92.Dpi = 254.0!
        Me.XrLabel92.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[BOXName]")})
        Me.XrLabel92.Font = New System.Drawing.Font("Zona Pro Regular", 8.0!)
        Me.XrLabel92.ForeColor = System.Drawing.Color.Gray
        Me.XrLabel92.LocationFloat = New DevExpress.Utils.PointFloat(966.4923!, 256.54!)
        Me.XrLabel92.Multiline = True
        Me.XrLabel92.Name = "XrLabel92"
        Me.XrLabel92.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel92.SizeF = New System.Drawing.SizeF(570.1476!, 58.57541!)
        Me.XrLabel92.StylePriority.UseBorderColor = False
        Me.XrLabel92.StylePriority.UseBorders = False
        Me.XrLabel92.StylePriority.UseFont = False
        Me.XrLabel92.StylePriority.UseForeColor = False
        Me.XrLabel92.StylePriority.UsePadding = False
        Me.XrLabel92.StylePriority.UseTextAlignment = False
        Me.XrLabel92.Text = "XrTableCell2"
        Me.XrLabel92.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel93
        '
        Me.XrLabel93.BorderColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(113, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.XrLabel93.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrLabel93.Dpi = 254.0!
        Me.XrLabel93.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[BOXName]")})
        Me.XrLabel93.Font = New System.Drawing.Font("Zona Pro Regular", 8.0!)
        Me.XrLabel93.ForeColor = System.Drawing.Color.Gray
        Me.XrLabel93.LocationFloat = New DevExpress.Utils.PointFloat(396.3449!, 340.36!)
        Me.XrLabel93.Multiline = True
        Me.XrLabel93.Name = "XrLabel93"
        Me.XrLabel93.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel93.SizeF = New System.Drawing.SizeF(1162.815!, 58.57544!)
        Me.XrLabel93.StylePriority.UseBorderColor = False
        Me.XrLabel93.StylePriority.UseBorders = False
        Me.XrLabel93.StylePriority.UseFont = False
        Me.XrLabel93.StylePriority.UseForeColor = False
        Me.XrLabel93.StylePriority.UsePadding = False
        Me.XrLabel93.StylePriority.UseTextAlignment = False
        Me.XrLabel93.Text = "XrTableCell2"
        Me.XrLabel93.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel94
        '
        Me.XrLabel94.BorderColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(113, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.XrLabel94.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrLabel94.Dpi = 254.0!
        Me.XrLabel94.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[BOXName]")})
        Me.XrLabel94.Font = New System.Drawing.Font("Zona Pro Regular", 8.0!)
        Me.XrLabel94.ForeColor = System.Drawing.Color.Gray
        Me.XrLabel94.LocationFloat = New DevExpress.Utils.PointFloat(396.3449!, 256.54!)
        Me.XrLabel94.Multiline = True
        Me.XrLabel94.Name = "XrLabel94"
        Me.XrLabel94.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel94.SizeF = New System.Drawing.SizeF(570.1474!, 58.57541!)
        Me.XrLabel94.StylePriority.UseBorderColor = False
        Me.XrLabel94.StylePriority.UseBorders = False
        Me.XrLabel94.StylePriority.UseFont = False
        Me.XrLabel94.StylePriority.UseForeColor = False
        Me.XrLabel94.StylePriority.UsePadding = False
        Me.XrLabel94.StylePriority.UseTextAlignment = False
        Me.XrLabel94.Text = "XrTableCell2"
        Me.XrLabel94.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel95
        '
        Me.XrLabel95.BackColor = System.Drawing.Color.Empty
        Me.XrLabel95.BorderColor = System.Drawing.Color.Empty
        Me.XrLabel95.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel95.Dpi = 254.0!
        Me.XrLabel95.Font = New System.Drawing.Font("Zona Pro", 9.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel95.ForeColor = System.Drawing.Color.Gray
        Me.XrLabel95.LocationFloat = New DevExpress.Utils.PointFloat(4.6736!, 340.36!)
        Me.XrLabel95.Multiline = True
        Me.XrLabel95.Name = "XrLabel95"
        Me.XrLabel95.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel95.SizeF = New System.Drawing.SizeF(391.6657!, 58.57544!)
        Me.XrLabel95.StylePriority.UseBackColor = False
        Me.XrLabel95.StylePriority.UseBorderColor = False
        Me.XrLabel95.StylePriority.UseBorders = False
        Me.XrLabel95.StylePriority.UseFont = False
        Me.XrLabel95.StylePriority.UseForeColor = False
        Me.XrLabel95.StylePriority.UsePadding = False
        Me.XrLabel95.StylePriority.UseTextAlignment = False
        Me.XrLabel95.Text = "Κωδικός επενδύσεων:"
        Me.XrLabel95.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel96
        '
        Me.XrLabel96.BackColor = System.Drawing.Color.Empty
        Me.XrLabel96.BorderColor = System.Drawing.Color.Empty
        Me.XrLabel96.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel96.Dpi = 254.0!
        Me.XrLabel96.Font = New System.Drawing.Font("Zona Pro", 9.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel96.ForeColor = System.Drawing.Color.Gray
        Me.XrLabel96.LocationFloat = New DevExpress.Utils.PointFloat(4.6736!, 256.54!)
        Me.XrLabel96.Multiline = True
        Me.XrLabel96.Name = "XrLabel96"
        Me.XrLabel96.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel96.SizeF = New System.Drawing.SizeF(391.6657!, 58.57541!)
        Me.XrLabel96.StylePriority.UseBackColor = False
        Me.XrLabel96.StylePriority.UseBorderColor = False
        Me.XrLabel96.StylePriority.UseBorders = False
        Me.XrLabel96.StylePriority.UseFont = False
        Me.XrLabel96.StylePriority.UseForeColor = False
        Me.XrLabel96.StylePriority.UsePadding = False
        Me.XrLabel96.StylePriority.UseTextAlignment = False
        Me.XrLabel96.Text = "Κωδικός  Πόρτας:"
        Me.XrLabel96.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel97
        '
        Me.XrLabel97.BorderColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(113, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.XrLabel97.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrLabel97.Dpi = 254.0!
        Me.XrLabel97.Font = New System.Drawing.Font("Zona Pro Regular", 8.0!)
        Me.XrLabel97.ForeColor = System.Drawing.Color.Gray
        Me.XrLabel97.LocationFloat = New DevExpress.Utils.PointFloat(1098.917!, 172.7199!)
        Me.XrLabel97.Multiline = True
        Me.XrLabel97.Name = "XrLabel97"
        Me.XrLabel97.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel97.SizeF = New System.Drawing.SizeF(460.2432!, 58.57538!)
        Me.XrLabel97.StylePriority.UseBorderColor = False
        Me.XrLabel97.StylePriority.UseBorders = False
        Me.XrLabel97.StylePriority.UseFont = False
        Me.XrLabel97.StylePriority.UseForeColor = False
        Me.XrLabel97.StylePriority.UsePadding = False
        Me.XrLabel97.StylePriority.UseTextAlignment = False
        Me.XrLabel97.Text = "XrTableCell15"
        Me.XrLabel97.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel98
        '
        Me.XrLabel98.BackColor = System.Drawing.Color.Empty
        Me.XrLabel98.BorderColor = System.Drawing.Color.Empty
        Me.XrLabel98.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel98.Dpi = 254.0!
        Me.XrLabel98.Font = New System.Drawing.Font("Zona Pro Regular", 9.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel98.ForeColor = System.Drawing.Color.Gray
        Me.XrLabel98.LocationFloat = New DevExpress.Utils.PointFloat(810.116!, 172.7199!)
        Me.XrLabel98.Multiline = True
        Me.XrLabel98.Name = "XrLabel98"
        Me.XrLabel98.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel98.SizeF = New System.Drawing.SizeF(288.8008!, 58.57544!)
        Me.XrLabel98.StylePriority.UseBackColor = False
        Me.XrLabel98.StylePriority.UseBorderColor = False
        Me.XrLabel98.StylePriority.UseBorders = False
        Me.XrLabel98.StylePriority.UseFont = False
        Me.XrLabel98.StylePriority.UseForeColor = False
        Me.XrLabel98.StylePriority.UsePadding = False
        Me.XrLabel98.StylePriority.UseTextAlignment = False
        Me.XrLabel98.Text = "Κωδικός Ραφιών:"
        Me.XrLabel98.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel99
        '
        Me.XrLabel99.BorderColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(113, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.XrLabel99.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrLabel99.Dpi = 254.0!
        Me.XrLabel99.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[BOXName]")})
        Me.XrLabel99.Font = New System.Drawing.Font("Zona Pro Regular", 8.0!)
        Me.XrLabel99.ForeColor = System.Drawing.Color.Gray
        Me.XrLabel99.LocationFloat = New DevExpress.Utils.PointFloat(396.3449!, 172.7199!)
        Me.XrLabel99.Multiline = True
        Me.XrLabel99.Name = "XrLabel99"
        Me.XrLabel99.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel99.SizeF = New System.Drawing.SizeF(413.7711!, 58.57542!)
        Me.XrLabel99.StylePriority.UseBorderColor = False
        Me.XrLabel99.StylePriority.UseBorders = False
        Me.XrLabel99.StylePriority.UseFont = False
        Me.XrLabel99.StylePriority.UseForeColor = False
        Me.XrLabel99.StylePriority.UsePadding = False
        Me.XrLabel99.StylePriority.UseTextAlignment = False
        Me.XrLabel99.Text = "XrTableCell2"
        Me.XrLabel99.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel100
        '
        Me.XrLabel100.BackColor = System.Drawing.Color.Empty
        Me.XrLabel100.BorderColor = System.Drawing.Color.Empty
        Me.XrLabel100.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel100.Dpi = 254.0!
        Me.XrLabel100.Font = New System.Drawing.Font("Zona Pro", 9.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel100.ForeColor = System.Drawing.Color.Gray
        Me.XrLabel100.LocationFloat = New DevExpress.Utils.PointFloat(4.6736!, 172.72!)
        Me.XrLabel100.Multiline = True
        Me.XrLabel100.Name = "XrLabel100"
        Me.XrLabel100.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel100.SizeF = New System.Drawing.SizeF(391.6657!, 58.57541!)
        Me.XrLabel100.StylePriority.UseBackColor = False
        Me.XrLabel100.StylePriority.UseBorderColor = False
        Me.XrLabel100.StylePriority.UseBorders = False
        Me.XrLabel100.StylePriority.UseFont = False
        Me.XrLabel100.StylePriority.UseForeColor = False
        Me.XrLabel100.StylePriority.UsePadding = False
        Me.XrLabel100.StylePriority.UseTextAlignment = False
        Me.XrLabel100.Text = "Κωδικός Κουτιών:"
        Me.XrLabel100.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel101
        '
        Me.XrLabel101.BorderColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(113, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.XrLabel101.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrLabel101.Dpi = 254.0!
        Me.XrLabel101.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Dimension1]")})
        Me.XrLabel101.Font = New System.Drawing.Font("Zona Pro", 9.0!)
        Me.XrLabel101.ForeColor = System.Drawing.Color.Gray
        Me.XrLabel101.LocationFloat = New DevExpress.Utils.PointFloat(1252.949!, 5.079962!)
        Me.XrLabel101.Multiline = True
        Me.XrLabel101.Name = "XrLabel101"
        Me.XrLabel101.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel101.SizeF = New System.Drawing.SizeF(306.2107!, 58.57545!)
        Me.XrLabel101.StylePriority.UseBorderColor = False
        Me.XrLabel101.StylePriority.UseBorders = False
        Me.XrLabel101.StylePriority.UseFont = False
        Me.XrLabel101.StylePriority.UseForeColor = False
        Me.XrLabel101.StylePriority.UsePadding = False
        Me.XrLabel101.StylePriority.UseTextAlignment = False
        Me.XrLabel101.Text = "XrTableCell22"
        Me.XrLabel101.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrLabel101.TextFormatString = "{0:C}"
        '
        'XrLabel102
        '
        Me.XrLabel102.BackColor = System.Drawing.Color.Empty
        Me.XrLabel102.BorderColor = System.Drawing.Color.Empty
        Me.XrLabel102.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel102.Dpi = 254.0!
        Me.XrLabel102.Font = New System.Drawing.Font("Zona Pro Regular", 9.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel102.ForeColor = System.Drawing.Color.Gray
        Me.XrLabel102.LocationFloat = New DevExpress.Utils.PointFloat(926.4183!, 5.08!)
        Me.XrLabel102.Multiline = True
        Me.XrLabel102.Name = "XrLabel102"
        Me.XrLabel102.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel102.SizeF = New System.Drawing.SizeF(326.5312!, 58.57545!)
        Me.XrLabel102.StylePriority.UseBackColor = False
        Me.XrLabel102.StylePriority.UseBorderColor = False
        Me.XrLabel102.StylePriority.UseBorders = False
        Me.XrLabel102.StylePriority.UseFont = False
        Me.XrLabel102.StylePriority.UseForeColor = False
        Me.XrLabel102.StylePriority.UsePadding = False
        Me.XrLabel102.StylePriority.UseTextAlignment = False
        Me.XrLabel102.Text = "Διαστάσεις"
        Me.XrLabel102.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel103
        '
        Me.XrLabel103.BorderColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(113, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.XrLabel103.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrLabel103.Dpi = 254.0!
        Me.XrLabel103.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Model1]")})
        Me.XrLabel103.Font = New System.Drawing.Font("Zona Pro", 9.0!)
        Me.XrLabel103.ForeColor = System.Drawing.Color.Gray
        Me.XrLabel103.LocationFloat = New DevExpress.Utils.PointFloat(396.3449!, 5.080079!)
        Me.XrLabel103.Multiline = True
        Me.XrLabel103.Name = "XrLabel103"
        Me.XrLabel103.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel103.SizeF = New System.Drawing.SizeF(530.0734!, 58.57542!)
        Me.XrLabel103.StylePriority.UseBorderColor = False
        Me.XrLabel103.StylePriority.UseBorders = False
        Me.XrLabel103.StylePriority.UseFont = False
        Me.XrLabel103.StylePriority.UseForeColor = False
        Me.XrLabel103.StylePriority.UsePadding = False
        Me.XrLabel103.StylePriority.UseTextAlignment = False
        Me.XrLabel103.Text = "XrTableCell20"
        Me.XrLabel103.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel104
        '
        Me.XrLabel104.BackColor = System.Drawing.Color.Empty
        Me.XrLabel104.BorderColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(113, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.XrLabel104.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel104.Dpi = 254.0!
        Me.XrLabel104.Font = New System.Drawing.Font("Zona Pro", 9.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel104.ForeColor = System.Drawing.Color.Gray
        Me.XrLabel104.LocationFloat = New DevExpress.Utils.PointFloat(4.679394!, 5.080079!)
        Me.XrLabel104.Multiline = True
        Me.XrLabel104.Name = "XrLabel104"
        Me.XrLabel104.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel104.SizeF = New System.Drawing.SizeF(391.6599!, 58.41995!)
        Me.XrLabel104.StylePriority.UseBackColor = False
        Me.XrLabel104.StylePriority.UseBorderColor = False
        Me.XrLabel104.StylePriority.UseBorders = False
        Me.XrLabel104.StylePriority.UseFont = False
        Me.XrLabel104.StylePriority.UseForeColor = False
        Me.XrLabel104.StylePriority.UsePadding = False
        Me.XrLabel104.StylePriority.UseTextAlignment = False
        Me.XrLabel104.Text = "Τύπος:"
        Me.XrLabel104.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrCheckBox5
        '
        Me.XrCheckBox5.BorderColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(113, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.XrCheckBox5.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrCheckBox5.Dpi = 254.0!
        Me.XrCheckBox5.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "CheckBoxState", "[HoodAlignment]")})
        Me.XrCheckBox5.LocationFloat = New DevExpress.Utils.PointFloat(1509.107!, 80.31259!)
        Me.XrCheckBox5.Name = "XrCheckBox5"
        Me.XrCheckBox5.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrCheckBox5.SizeF = New System.Drawing.SizeF(50.05249!, 58.41969!)
        Me.XrCheckBox5.StylePriority.UseBorderColor = False
        Me.XrCheckBox5.StylePriority.UseBorders = False
        '
        'XrLabel105
        '
        Me.XrLabel105.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel105.CanShrink = True
        Me.XrLabel105.Dpi = 254.0!
        Me.XrLabel105.Font = New System.Drawing.Font("Zona Pro", 9.0!)
        Me.XrLabel105.ForeColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(113, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.XrLabel105.LocationFloat = New DevExpress.Utils.PointFloat(1046.472!, 88.89995!)
        Me.XrLabel105.Name = "XrLabel105"
        Me.XrLabel105.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel105.SizeF = New System.Drawing.SizeF(457.5557!, 52.37231!)
        Me.XrLabel105.StylePriority.UseBorders = False
        Me.XrLabel105.StylePriority.UseFont = False
        Me.XrLabel105.StylePriority.UseForeColor = False
        Me.XrLabel105.StylePriority.UsePadding = False
        Me.XrLabel105.StylePriority.UseTextAlignment = False
        Me.XrLabel105.Text = "Χωνευτό προφίλ για Led :"
        Me.XrLabel105.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel106
        '
        Me.XrLabel106.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel106.CanShrink = True
        Me.XrLabel106.Dpi = 254.0!
        Me.XrLabel106.Font = New System.Drawing.Font("Zona Pro", 9.0!)
        Me.XrLabel106.ForeColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(113, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.XrLabel106.LocationFloat = New DevExpress.Utils.PointFloat(582.9641!, 88.9!)
        Me.XrLabel106.Name = "XrLabel106"
        Me.XrLabel106.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel106.SizeF = New System.Drawing.SizeF(282.1962!, 58.42001!)
        Me.XrLabel106.StylePriority.UseBorders = False
        Me.XrLabel106.StylePriority.UseFont = False
        Me.XrLabel106.StylePriority.UseForeColor = False
        Me.XrLabel106.StylePriority.UsePadding = False
        Me.XrLabel106.StylePriority.UseTextAlignment = False
        Me.XrLabel106.Text = "Πάχος Πλάτης:"
        Me.XrLabel106.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel107
        '
        Me.XrLabel107.BorderColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(113, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.XrLabel107.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrLabel107.Dpi = 254.0!
        Me.XrLabel107.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[vw_CCT_ORDERS_CLOSET].[boxThikness]")})
        Me.XrLabel107.Font = New System.Drawing.Font("Zona Pro", 9.0!)
        Me.XrLabel107.ForeColor = System.Drawing.Color.Gray
        Me.XrLabel107.LocationFloat = New DevExpress.Utils.PointFloat(865.1606!, 88.89995!)
        Me.XrLabel107.Multiline = True
        Me.XrLabel107.Name = "XrLabel107"
        Me.XrLabel107.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel107.SizeF = New System.Drawing.SizeF(158.3397!, 58.42015!)
        Me.XrLabel107.StylePriority.UseBorderColor = False
        Me.XrLabel107.StylePriority.UseBorders = False
        Me.XrLabel107.StylePriority.UseFont = False
        Me.XrLabel107.StylePriority.UseForeColor = False
        Me.XrLabel107.StylePriority.UseTextAlignment = False
        Me.XrLabel107.Text = "XrLabel55"
        Me.XrLabel107.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel108
        '
        Me.XrLabel108.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel108.CanShrink = True
        Me.XrLabel108.Dpi = 254.0!
        Me.XrLabel108.Font = New System.Drawing.Font("Zona Pro", 9.0!)
        Me.XrLabel108.ForeColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(113, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.XrLabel108.LocationFloat = New DevExpress.Utils.PointFloat(4.679379!, 88.89995!)
        Me.XrLabel108.Name = "XrLabel108"
        Me.XrLabel108.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel108.SizeF = New System.Drawing.SizeF(391.6599!, 58.41992!)
        Me.XrLabel108.StylePriority.UseBorders = False
        Me.XrLabel108.StylePriority.UseFont = False
        Me.XrLabel108.StylePriority.UseForeColor = False
        Me.XrLabel108.StylePriority.UsePadding = False
        Me.XrLabel108.StylePriority.UseTextAlignment = False
        Me.XrLabel108.Text = "Πάχος Κασώματος:"
        Me.XrLabel108.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel109
        '
        Me.XrLabel109.BorderColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(113, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.XrLabel109.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrLabel109.Dpi = 254.0!
        Me.XrLabel109.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[vw_CCT_ORDERS_CLOSET].[boxThikness]")})
        Me.XrLabel109.Font = New System.Drawing.Font("Zona Pro", 9.0!)
        Me.XrLabel109.ForeColor = System.Drawing.Color.Gray
        Me.XrLabel109.LocationFloat = New DevExpress.Utils.PointFloat(396.3441!, 88.89995!)
        Me.XrLabel109.Multiline = True
        Me.XrLabel109.Name = "XrLabel109"
        Me.XrLabel109.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel109.SizeF = New System.Drawing.SizeF(165.449!, 58.42015!)
        Me.XrLabel109.StylePriority.UseBorderColor = False
        Me.XrLabel109.StylePriority.UseBorders = False
        Me.XrLabel109.StylePriority.UseFont = False
        Me.XrLabel109.StylePriority.UseForeColor = False
        Me.XrLabel109.StylePriority.UseTextAlignment = False
        Me.XrLabel109.Text = "XrLabel55"
        Me.XrLabel109.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'RepCUSOrderCloset
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.TopMargin, Me.BottomMargin, Me.Detail, Me.PageHeader})
        Me.ComponentStorage.AddRange(New System.ComponentModel.IComponent() {Me.SqlDataSource1})
        Me.DataMember = "vw_CCT_ORDERS_CLOSET"
        Me.DataSource = Me.SqlDataSource1
        Me.Dpi = 254.0!
        Me.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.Margins = New System.Drawing.Printing.Margins(254, 254, 251, 55)
        Me.PageHeight = 2970
        Me.PageWidth = 2100
        Me.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.Parameters.AddRange(New DevExpress.XtraReports.Parameters.Parameter() {Me.OfferID})
        Me.ReportUnit = DevExpress.XtraReports.UI.ReportUnit.TenthsOfAMillimeter
        Me.ScriptLanguage = DevExpress.XtraReports.ScriptLanguage.VisualBasic
        Me.SnapGridSize = 25.0!
        Me.Version = "21.2"
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub

    Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents SqlDataSource1 As DevExpress.DataAccess.Sql.SqlDataSource
    Friend WithEvents OfferID As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents XrPictureBox1 As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents XrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents PageHeader As DevExpress.XtraReports.UI.PageHeaderBand
    Friend WithEvents XrPanel1 As DevExpress.XtraReports.UI.XRPanel
    Friend WithEvents XrLabel34 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel35 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel17 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel22 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel21 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel20 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel19 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel18 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel12 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel13 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel14 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel15 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel16 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel23 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrPanel3 As DevExpress.XtraReports.UI.XRPanel
    Friend WithEvents XrLabel25 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel28 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel8 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel9 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel30 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel38 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel81 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel91 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrCheckBox2 As DevExpress.XtraReports.UI.XRCheckBox
    Friend WithEvents XrLabel3 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel39 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel40 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel41 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel42 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel43 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel44 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel45 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel47 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel10 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel63 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel11 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel4 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrPanel4 As DevExpress.XtraReports.UI.XRPanel
    Friend WithEvents XrLabel60 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel61 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel62 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel64 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel65 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel66 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel67 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel68 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel69 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel70 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel71 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel72 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel73 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrCheckBox3 As DevExpress.XtraReports.UI.XRCheckBox
    Friend WithEvents XrLabel74 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel75 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel76 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel77 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel78 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrPanel2 As DevExpress.XtraReports.UI.XRPanel
    Friend WithEvents XrLabel6 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel24 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel26 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel27 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel29 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel46 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel48 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel49 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel50 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel51 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel52 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel53 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel54 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrCheckBox1 As DevExpress.XtraReports.UI.XRCheckBox
    Friend WithEvents XrLabel55 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel56 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel57 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel58 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel59 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrPanel6 As DevExpress.XtraReports.UI.XRPanel
    Friend WithEvents XrLabel92 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel93 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel94 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel95 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel96 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel97 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel98 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel99 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel100 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel101 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel102 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel103 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel104 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrCheckBox5 As DevExpress.XtraReports.UI.XRCheckBox
    Friend WithEvents XrLabel105 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel106 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel107 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel108 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel109 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrPanel5 As DevExpress.XtraReports.UI.XRPanel
    Friend WithEvents XrLabel5 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel7 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel31 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel32 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel33 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel36 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel37 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel79 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel80 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel82 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel83 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel84 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel85 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrCheckBox4 As DevExpress.XtraReports.UI.XRCheckBox
    Friend WithEvents XrLabel86 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel87 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel88 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel89 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel90 As DevExpress.XtraReports.UI.XRLabel
End Class
