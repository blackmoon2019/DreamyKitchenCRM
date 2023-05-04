<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class RepCUSOrderCloset2ndPage
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
        Dim CustomSqlQuery2 As DevExpress.DataAccess.Sql.CustomSqlQuery = New DevExpress.DataAccess.Sql.CustomSqlQuery()
        Dim QueryParameter2 As DevExpress.DataAccess.Sql.QueryParameter = New DevExpress.DataAccess.Sql.QueryParameter()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RepCUSOrderCloset2ndPage))
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
        Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand()
        Me.XrLabel39 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel40 = New DevExpress.XtraReports.UI.XRLabel()
        Me.OfferID = New DevExpress.XtraReports.Parameters.Parameter()
        Me.ReportFooter = New DevExpress.XtraReports.UI.ReportFooterBand()
        Me.XrLabel43 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel42 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel11 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel12 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel7 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel8 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel9 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel10 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel4 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel70 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel72 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLine1 = New DevExpress.XtraReports.UI.XRLine()
        Me.XrLine2 = New DevExpress.XtraReports.UI.XRLine()
        Me.XrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel41 = New DevExpress.XtraReports.UI.XRLabel()
        Me.DetailReport = New DevExpress.XtraReports.UI.DetailReportBand()
        Me.Detail1 = New DevExpress.XtraReports.UI.DetailBand()
        Me.XrLabel37 = New DevExpress.XtraReports.UI.XRLabel()
        Me.GroupHeader1 = New DevExpress.XtraReports.UI.GroupHeaderBand()
        Me.XrLabel36 = New DevExpress.XtraReports.UI.XRLabel()
        Me.DetailReport1 = New DevExpress.XtraReports.UI.DetailReportBand()
        Me.Detail2 = New DevExpress.XtraReports.UI.DetailBand()
        Me.XrLabel32 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel33 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel3 = New DevExpress.XtraReports.UI.XRLabel()
        Me.GroupHeader2 = New DevExpress.XtraReports.UI.GroupHeaderBand()
        Me.XrLabel31 = New DevExpress.XtraReports.UI.XRLabel()
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
        CustomSqlQuery1.MetaSerializable = "<Meta X=""20"" Y=""20"" Width=""174"" Height=""1692"" />"
        CustomSqlQuery1.Name = "vw_CCT_ORDERS_CLOSET"
        QueryParameter1.Name = "OfferID"
        QueryParameter1.Type = GetType(DevExpress.DataAccess.Expression)
        QueryParameter1.Value = New DevExpress.DataAccess.Expression("?OfferID", GetType(System.Guid))
        CustomSqlQuery1.Parameters.AddRange(New DevExpress.DataAccess.Sql.QueryParameter() {QueryParameter1})
        CustomSqlQuery1.Sql = "select ""vw_CCT_ORDERS_CLOSET"".*" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "  from ""dbo"".""vw_CCT_ORDERS_CLOSET""" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "       ""vw_" &
    "CCT_ORDERS_CLOSET""" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " where (""vw_CCT_ORDERS_CLOSET"".""ID"" = @OfferID)"
        CustomSqlQuery2.MetaSerializable = "<Meta X=""214"" Y=""20"" Width=""252"" Height=""112"" />"
        CustomSqlQuery2.Name = "vw_CCT_ORDERS_CLOSET_EQUIPMENT"
        QueryParameter2.Name = "OfferID"
        QueryParameter2.Type = GetType(DevExpress.DataAccess.Expression)
        QueryParameter2.Value = New DevExpress.DataAccess.Expression("?OfferID", GetType(System.Guid))
        CustomSqlQuery2.Parameters.AddRange(New DevExpress.DataAccess.Sql.QueryParameter() {QueryParameter2})
        CustomSqlQuery2.Sql = resources.GetString("CustomSqlQuery2.Sql")
        CustomSqlQuery3.MetaSerializable = "<Meta X=""486"" Y=""20"" Width=""297"" Height=""132"" />"
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
        Me.TopMargin.Name = "TopMargin"
        '
        'XrPictureBox1
        '
        Me.XrPictureBox1.ImageSource = New DevExpress.XtraPrinting.Drawing.ImageSource("img", resources.GetString("XrPictureBox1.ImageSource"))
        Me.XrPictureBox1.LocationFloat = New DevExpress.Utils.PointFloat(0!, 15.36935!)
        Me.XrPictureBox1.Name = "XrPictureBox1"
        Me.XrPictureBox1.SizeF = New System.Drawing.SizeF(275.8548!, 62.60684!)
        '
        'XrLabel1
        '
        Me.XrLabel1.Font = New System.Drawing.Font("Zona Pro Regular", 10.0!)
        Me.XrLabel1.ForeColor = System.Drawing.Color.Gray
        Me.XrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(327.8494!, 20.36934!)
        Me.XrLabel1.Name = "XrLabel1"
        Me.XrLabel1.SizeF = New System.Drawing.SizeF(299.1506!, 52.19016!)
        Me.XrLabel1.StylePriority.UseFont = False
        Me.XrLabel1.StylePriority.UseForeColor = False
        Me.XrLabel1.Text = "Δημιουργούμε το χώρο των ονείρων σας.                                            " &
    "                           'Επιπλα Κουζίνας, Ντουλάπες Υπνοδωματίων, Πόρτες."
        '
        'BottomMargin
        '
        Me.BottomMargin.HeightF = 167.0271!
        Me.BottomMargin.Name = "BottomMargin"
        '
        'Detail
        '
        Me.Detail.HeightF = 0!
        Me.Detail.Name = "Detail"
        '
        'PageHeader
        '
        Me.PageHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel39, Me.XrLabel40})
        Me.PageHeader.HeightF = 102.9762!
        Me.PageHeader.Name = "PageHeader"
        '
        'XrLabel39
        '
        Me.XrLabel39.Font = New System.Drawing.Font("Zona Pro Regular", 10.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel39.ForeColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.XrLabel39.LocationFloat = New DevExpress.Utils.PointFloat(1.000032!, 0!)
        Me.XrLabel39.Name = "XrLabel39"
        Me.XrLabel39.SizeF = New System.Drawing.SizeF(625.0!, 25.0!)
        Me.XrLabel39.StylePriority.UseFont = False
        Me.XrLabel39.StylePriority.UseForeColor = False
        Me.XrLabel39.StylePriority.UseTextAlignment = False
        Me.XrLabel39.Text = "Παρατηρήσεις"
        Me.XrLabel39.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel40
        '
        Me.XrLabel40.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[notes]")})
        Me.XrLabel40.Font = New System.Drawing.Font("Zona Pro Regular", 9.0!)
        Me.XrLabel40.ForeColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.XrLabel40.LocationFloat = New DevExpress.Utils.PointFloat(0!, 25.0!)
        Me.XrLabel40.Multiline = True
        Me.XrLabel40.Name = "XrLabel40"
        Me.XrLabel40.SizeF = New System.Drawing.SizeF(625.0001!, 70.24402!)
        Me.XrLabel40.StylePriority.UseFont = False
        Me.XrLabel40.StylePriority.UseForeColor = False
        Me.XrLabel40.StylePriority.UseTextAlignment = False
        Me.XrLabel40.Text = resources.GetString("XrLabel40.Text")
        Me.XrLabel40.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'OfferID
        '
        Me.OfferID.Description = "OfferID"
        Me.OfferID.Name = "OfferID"
        Me.OfferID.Type = GetType(System.Guid)
        Me.OfferID.ValueInfo = "597c9975-b2b5-412a-bb7d-3e3ee6c758cf"
        DynamicListLookUpSettings1.DataMember = "vw_CCT_ORDERS_CLOSET"
        DynamicListLookUpSettings1.DataSource = Me.SqlDataSource1
        DynamicListLookUpSettings1.DisplayMember = "ID"
        DynamicListLookUpSettings1.FilterString = Nothing
        DynamicListLookUpSettings1.SortMember = Nothing
        DynamicListLookUpSettings1.ValueMember = "ID"
        Me.OfferID.ValueSourceSettings = DynamicListLookUpSettings1
        Me.OfferID.Visible = False
        '
        'ReportFooter
        '
        Me.ReportFooter.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel43, Me.XrLabel42, Me.XrLabel11, Me.XrLabel12, Me.XrLabel7, Me.XrLabel8, Me.XrLabel9, Me.XrLabel10, Me.XrLabel4, Me.XrLabel70, Me.XrLabel72, Me.XrLine1, Me.XrLine2, Me.XrLabel2, Me.XrLabel41})
        Me.ReportFooter.HeightF = 445.8333!
        Me.ReportFooter.Name = "ReportFooter"
        '
        'XrLabel43
        '
        Me.XrLabel43.Font = New System.Drawing.Font("Zona Pro Regular", 10.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel43.ForeColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.XrLabel43.LocationFloat = New DevExpress.Utils.PointFloat(31.87503!, 213.4226!)
        Me.XrLabel43.Name = "XrLabel43"
        Me.XrLabel43.SizeF = New System.Drawing.SizeF(503.0553!, 32.7083!)
        Me.XrLabel43.StylePriority.UseFont = False
        Me.XrLabel43.StylePriority.UseForeColor = False
        Me.XrLabel43.StylePriority.UseTextAlignment = False
        Me.XrLabel43.Text = "Εξόφληση: Με την παράδοση των εμπορευμάτων στο χώρο σας και πριν την έναρξη της τ" &
    "οποθέτησης"
        Me.XrLabel43.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel42
        '
        Me.XrLabel42.Font = New System.Drawing.Font("Zona Pro Regular", 10.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel42.ForeColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.XrLabel42.LocationFloat = New DevExpress.Utils.PointFloat(31.87503!, 191.4583!)
        Me.XrLabel42.Name = "XrLabel42"
        Me.XrLabel42.SizeF = New System.Drawing.SizeF(480.3571!, 16.96426!)
        Me.XrLabel42.StylePriority.UseFont = False
        Me.XrLabel42.StylePriority.UseForeColor = False
        Me.XrLabel42.StylePriority.UseTextAlignment = False
        Me.XrLabel42.Text = "Προκαταβολή: Με την υπογραφή του ιδιωτικού συμφωνητικού 50%"
        Me.XrLabel42.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel11
        '
        Me.XrLabel11.Font = New System.Drawing.Font("Zona Pro Regular", 10.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.XrLabel11.LocationFloat = New DevExpress.Utils.PointFloat(4.0!, 102.9643!)
        Me.XrLabel11.Name = "XrLabel11"
        Me.XrLabel11.SizeF = New System.Drawing.SizeF(261.3095!, 16.96428!)
        Me.XrLabel11.StylePriority.UseFont = False
        Me.XrLabel11.StylePriority.UseForeColor = False
        Me.XrLabel11.StylePriority.UseTextAlignment = False
        Me.XrLabel11.Text = "Γενικό Σύνολο:"
        Me.XrLabel11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel12
        '
        Me.XrLabel12.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[GENTOT]")})
        Me.XrLabel12.Font = New System.Drawing.Font("Zona Pro Regular", 9.75!, System.Drawing.FontStyle.Bold)
        Me.XrLabel12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.XrLabel12.LocationFloat = New DevExpress.Utils.PointFloat(265.3095!, 102.9643!)
        Me.XrLabel12.Multiline = True
        Me.XrLabel12.Name = "XrLabel12"
        Me.XrLabel12.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel12.SizeF = New System.Drawing.SizeF(139.881!, 16.96429!)
        Me.XrLabel12.StylePriority.UseFont = False
        Me.XrLabel12.StylePriority.UseForeColor = False
        Me.XrLabel12.StylePriority.UseTextAlignment = False
        Me.XrLabel12.Text = "XrLabel5"
        Me.XrLabel12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        Me.XrLabel12.TextFormatString = "{0:C2}"
        '
        'XrLabel7
        '
        Me.XrLabel7.Font = New System.Drawing.Font("Zona Pro Regular", 10.0!)
        Me.XrLabel7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.XrLabel7.LocationFloat = New DevExpress.Utils.PointFloat(4.0!, 40.07144!)
        Me.XrLabel7.Name = "XrLabel7"
        Me.XrLabel7.SizeF = New System.Drawing.SizeF(261.3095!, 16.96428!)
        Me.XrLabel7.StylePriority.UseFont = False
        Me.XrLabel7.StylePriority.UseForeColor = False
        Me.XrLabel7.StylePriority.UseTextAlignment = False
        Me.XrLabel7.Text = "Έξτρα Μεταφορά:"
        Me.XrLabel7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel8
        '
        Me.XrLabel8.Font = New System.Drawing.Font("Zona Pro Regular", 10.0!)
        Me.XrLabel8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.XrLabel8.LocationFloat = New DevExpress.Utils.PointFloat(4.0!, 61.03574!)
        Me.XrLabel8.Name = "XrLabel8"
        Me.XrLabel8.SizeF = New System.Drawing.SizeF(261.3095!, 16.96428!)
        Me.XrLabel8.StylePriority.UseFont = False
        Me.XrLabel8.StylePriority.UseForeColor = False
        Me.XrLabel8.StylePriority.UseTextAlignment = False
        Me.XrLabel8.Text = "Έξτρα Τοποθέτηση:"
        Me.XrLabel8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel9
        '
        Me.XrLabel9.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[ExtraTransp]")})
        Me.XrLabel9.Font = New System.Drawing.Font("Zona Pro Regular", 9.75!)
        Me.XrLabel9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.XrLabel9.LocationFloat = New DevExpress.Utils.PointFloat(265.3095!, 40.07144!)
        Me.XrLabel9.Multiline = True
        Me.XrLabel9.Name = "XrLabel9"
        Me.XrLabel9.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel9.SizeF = New System.Drawing.SizeF(139.881!, 16.96429!)
        Me.XrLabel9.StylePriority.UseFont = False
        Me.XrLabel9.StylePriority.UseForeColor = False
        Me.XrLabel9.StylePriority.UseTextAlignment = False
        Me.XrLabel9.Text = "XrLabel5"
        Me.XrLabel9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        Me.XrLabel9.TextFormatString = "{0:C2}"
        '
        'XrLabel10
        '
        Me.XrLabel10.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[ExtraInst]")})
        Me.XrLabel10.Font = New System.Drawing.Font("Zona Pro Regular", 9.75!)
        Me.XrLabel10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.XrLabel10.LocationFloat = New DevExpress.Utils.PointFloat(265.3095!, 61.03573!)
        Me.XrLabel10.Multiline = True
        Me.XrLabel10.Name = "XrLabel10"
        Me.XrLabel10.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel10.SizeF = New System.Drawing.SizeF(139.881!, 16.96429!)
        Me.XrLabel10.StylePriority.UseFont = False
        Me.XrLabel10.StylePriority.UseForeColor = False
        Me.XrLabel10.StylePriority.UseTextAlignment = False
        Me.XrLabel10.Text = "XrLabel5"
        Me.XrLabel10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        Me.XrLabel10.TextFormatString = "{0:C2}"
        '
        'XrLabel4
        '
        Me.XrLabel4.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "iif([visibleVat]=True,[TotalClosetPice],[TotalClosetVat])" & Global.Microsoft.VisualBasic.ChrW(10))})
        Me.XrLabel4.Font = New System.Drawing.Font("Zona Pro Regular", 9.75!)
        Me.XrLabel4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.XrLabel4.LocationFloat = New DevExpress.Utils.PointFloat(265.3095!, 82.00002!)
        Me.XrLabel4.Multiline = True
        Me.XrLabel4.Name = "XrLabel4"
        Me.XrLabel4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel4.SizeF = New System.Drawing.SizeF(139.881!, 16.96428!)
        Me.XrLabel4.StylePriority.UseFont = False
        Me.XrLabel4.StylePriority.UseForeColor = False
        Me.XrLabel4.StylePriority.UseTextAlignment = False
        Me.XrLabel4.Text = "XrLabel4"
        Me.XrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        Me.XrLabel4.TextFormatString = "{0:C2}"
        '
        'XrLabel70
        '
        Me.XrLabel70.CanShrink = True
        Me.XrLabel70.Font = New System.Drawing.Font("Zona Pro", 9.0!)
        Me.XrLabel70.ForeColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(113, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.XrLabel70.LocationFloat = New DevExpress.Utils.PointFloat(51.52257!, 298.6428!)
        Me.XrLabel70.Name = "XrLabel70"
        Me.XrLabel70.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel70.SizeF = New System.Drawing.SizeF(198.5954!, 22.99994!)
        Me.XrLabel70.StylePriority.UseFont = False
        Me.XrLabel70.StylePriority.UseForeColor = False
        Me.XrLabel70.StylePriority.UsePadding = False
        Me.XrLabel70.StylePriority.UseTextAlignment = False
        Me.XrLabel70.Text = "Για την Εταιρία"
        Me.XrLabel70.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel72
        '
        Me.XrLabel72.CanShrink = True
        Me.XrLabel72.Font = New System.Drawing.Font("Zona Pro", 9.0!)
        Me.XrLabel72.ForeColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(113, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.XrLabel72.LocationFloat = New DevExpress.Utils.PointFloat(364.6833!, 298.6428!)
        Me.XrLabel72.Name = "XrLabel72"
        Me.XrLabel72.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel72.SizeF = New System.Drawing.SizeF(198.5954!, 22.99994!)
        Me.XrLabel72.StylePriority.UseFont = False
        Me.XrLabel72.StylePriority.UseForeColor = False
        Me.XrLabel72.StylePriority.UsePadding = False
        Me.XrLabel72.StylePriority.UseTextAlignment = False
        Me.XrLabel72.Text = "Ο Πελάτης"
        Me.XrLabel72.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLine1
        '
        Me.XrLine1.LocationFloat = New DevExpress.Utils.PointFloat(50.11786!, 355.6428!)
        Me.XrLine1.Name = "XrLine1"
        Me.XrLine1.SizeF = New System.Drawing.SizeF(200.0!, 23.0!)
        '
        'XrLine2
        '
        Me.XrLine2.LocationFloat = New DevExpress.Utils.PointFloat(364.6833!, 355.6428!)
        Me.XrLine2.Name = "XrLine2"
        Me.XrLine2.SizeF = New System.Drawing.SizeF(200.0!, 23.0!)
        '
        'XrLabel2
        '
        Me.XrLabel2.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "iif([visibleVat]=True,'Συνολική αξία ντουλαπών με Φ.Π.Α','Συνολική αξία ντουλαπών" &
                    " προ Φ.Π.Α')" & Global.Microsoft.VisualBasic.ChrW(10))})
        Me.XrLabel2.Font = New System.Drawing.Font("Zona Pro Regular", 10.0!)
        Me.XrLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.XrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(3.999983!, 82.00002!)
        Me.XrLabel2.Name = "XrLabel2"
        Me.XrLabel2.SizeF = New System.Drawing.SizeF(261.3095!, 16.96428!)
        Me.XrLabel2.StylePriority.UseFont = False
        Me.XrLabel2.StylePriority.UseForeColor = False
        Me.XrLabel2.StylePriority.UseTextAlignment = False
        Me.XrLabel2.Text = "Συνολική αξία ερμαρίων προ ΦΠΑ :"
        Me.XrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel41
        '
        Me.XrLabel41.Font = New System.Drawing.Font("Zona Pro Regular", 10.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel41.ForeColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.XrLabel41.LocationFloat = New DevExpress.Utils.PointFloat(0!, 164.9286!)
        Me.XrLabel41.Name = "XrLabel41"
        Me.XrLabel41.SizeF = New System.Drawing.SizeF(627.0!, 18.07143!)
        Me.XrLabel41.StylePriority.UseFont = False
        Me.XrLabel41.StylePriority.UseForeColor = False
        Me.XrLabel41.StylePriority.UseTextAlignment = False
        Me.XrLabel41.Text = "Τρόπος πληρωμής"
        Me.XrLabel41.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'DetailReport
        '
        Me.DetailReport.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail1, Me.GroupHeader1, Me.DetailReport1})
        Me.DetailReport.DataMember = "vw_CCT_ORDERS_CLOSET_EQUIPMENT"
        Me.DetailReport.DataSource = Me.SqlDataSource1
        Me.DetailReport.Level = 0
        Me.DetailReport.Name = "DetailReport"
        '
        'Detail1
        '
        Me.Detail1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel37})
        Me.Detail1.HeightF = 13.00001!
        Me.Detail1.MultiColumn.ColumnCount = 3
        Me.Detail1.MultiColumn.ColumnSpacing = 5.0!
        Me.Detail1.MultiColumn.Layout = DevExpress.XtraPrinting.ColumnLayout.AcrossThenDown
        Me.Detail1.MultiColumn.Mode = DevExpress.XtraReports.UI.MultiColumnMode.UseColumnCount
        Me.Detail1.Name = "Detail1"
        '
        'XrLabel37
        '
        Me.XrLabel37.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[EquipmentName]")})
        Me.XrLabel37.Font = New System.Drawing.Font("Zona Pro", 9.0!)
        Me.XrLabel37.ForeColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(113, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.XrLabel37.LocationFloat = New DevExpress.Utils.PointFloat(3.999983!, 0!)
        Me.XrLabel37.Multiline = True
        Me.XrLabel37.Name = "XrLabel37"
        Me.XrLabel37.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel37.SizeF = New System.Drawing.SizeF(207.0!, 13.00001!)
        Me.XrLabel37.StylePriority.UseFont = False
        Me.XrLabel37.StylePriority.UseForeColor = False
        Me.XrLabel37.Text = "XrLabel10"
        Me.XrLabel37.TextFormatString = "* {0}"
        '
        'GroupHeader1
        '
        Me.GroupHeader1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel36})
        Me.GroupHeader1.HeightF = 21.42857!
        Me.GroupHeader1.Name = "GroupHeader1"
        '
        'XrLabel36
        '
        Me.XrLabel36.BackColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.XrLabel36.Font = New System.Drawing.Font("Zona Pro", 10.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel36.ForeColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(113, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.XrLabel36.LocationFloat = New DevExpress.Utils.PointFloat(2.000064!, 0!)
        Me.XrLabel36.Name = "XrLabel36"
        Me.XrLabel36.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.XrLabel36.SizeF = New System.Drawing.SizeF(624.9999!, 20.83333!)
        Me.XrLabel36.StylePriority.UseBackColor = False
        Me.XrLabel36.StylePriority.UseFont = False
        Me.XrLabel36.StylePriority.UseForeColor = False
        Me.XrLabel36.StylePriority.UsePadding = False
        Me.XrLabel36.StylePriority.UseTextAlignment = False
        Me.XrLabel36.Text = "Στάνταρ εξοπλισμός που περιλαμβάνεται"
        Me.XrLabel36.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'DetailReport1
        '
        Me.DetailReport1.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail2, Me.GroupHeader2})
        Me.DetailReport1.DataMember = "vw_CCT_ORDERS_CLOSET_EQUIPMENT_EXTRA"
        Me.DetailReport1.DataSource = Me.SqlDataSource1
        Me.DetailReport1.Level = 0
        Me.DetailReport1.Name = "DetailReport1"
        '
        'Detail2
        '
        Me.Detail2.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel32, Me.XrLabel33, Me.XrLabel3})
        Me.Detail2.HeightF = 15.57141!
        Me.Detail2.MultiColumn.ColumnCount = 3
        Me.Detail2.MultiColumn.Layout = DevExpress.XtraPrinting.ColumnLayout.AcrossThenDown
        Me.Detail2.MultiColumn.Mode = DevExpress.XtraReports.UI.MultiColumnMode.UseColumnCount
        Me.Detail2.Name = "Detail2"
        '
        'XrLabel32
        '
        Me.XrLabel32.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[EquipmentName]")})
        Me.XrLabel32.Font = New System.Drawing.Font("Zona Pro", 9.0!)
        Me.XrLabel32.ForeColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(113, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.XrLabel32.LocationFloat = New DevExpress.Utils.PointFloat(5.000014!, 0!)
        Me.XrLabel32.Multiline = True
        Me.XrLabel32.Name = "XrLabel32"
        Me.XrLabel32.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel32.SizeF = New System.Drawing.SizeF(206.0!, 15.2619!)
        Me.XrLabel32.StylePriority.UseFont = False
        Me.XrLabel32.StylePriority.UseForeColor = False
        Me.XrLabel32.Text = "XrLabel10"
        Me.XrLabel32.TextFormatString = "* {0}"
        '
        'XrLabel33
        '
        Me.XrLabel33.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[price]")})
        Me.XrLabel33.Font = New System.Drawing.Font("Zona Pro", 9.0!)
        Me.XrLabel33.ForeColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(113, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.XrLabel33.LocationFloat = New DevExpress.Utils.PointFloat(214.0!, 0!)
        Me.XrLabel33.Multiline = True
        Me.XrLabel33.Name = "XrLabel33"
        Me.XrLabel33.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel33.SizeF = New System.Drawing.SizeF(75.9048!, 15.2619!)
        Me.XrLabel33.StylePriority.UseFont = False
        Me.XrLabel33.StylePriority.UseForeColor = False
        Me.XrLabel33.Text = "XrLabel10"
        Me.XrLabel33.TextFormatString = "{0:C}"
        '
        'XrLabel3
        '
        Me.XrLabel3.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[qty]")})
        Me.XrLabel3.Font = New System.Drawing.Font("Zona Pro", 9.0!)
        Me.XrLabel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(113, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.XrLabel3.LocationFloat = New DevExpress.Utils.PointFloat(295.9048!, 0!)
        Me.XrLabel3.Multiline = True
        Me.XrLabel3.Name = "XrLabel3"
        Me.XrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel3.SizeF = New System.Drawing.SizeF(57.8681!, 15.2619!)
        Me.XrLabel3.StylePriority.UseFont = False
        Me.XrLabel3.StylePriority.UseForeColor = False
        Me.XrLabel3.Text = "XrLabel7"
        Me.XrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'GroupHeader2
        '
        Me.GroupHeader2.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel31})
        Me.GroupHeader2.HeightF = 22.61905!
        Me.GroupHeader2.Name = "GroupHeader2"
        '
        'XrLabel31
        '
        Me.XrLabel31.BackColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.XrLabel31.Font = New System.Drawing.Font("Zona Pro", 10.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel31.ForeColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(113, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.XrLabel31.LocationFloat = New DevExpress.Utils.PointFloat(2.000064!, 0.3937008!)
        Me.XrLabel31.Name = "XrLabel31"
        Me.XrLabel31.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.XrLabel31.SizeF = New System.Drawing.SizeF(625.0!, 20.83333!)
        Me.XrLabel31.StylePriority.UseBackColor = False
        Me.XrLabel31.StylePriority.UseFont = False
        Me.XrLabel31.StylePriority.UseForeColor = False
        Me.XrLabel31.StylePriority.UsePadding = False
        Me.XrLabel31.StylePriority.UseTextAlignment = False
        Me.XrLabel31.Text = "Extra εξοπλισμός που περιλαμβάνεται"
        Me.XrLabel31.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'RepCUSOrderCloset2ndPage
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.TopMargin, Me.BottomMargin, Me.Detail, Me.PageHeader, Me.ReportFooter, Me.DetailReport})
        Me.ComponentStorage.AddRange(New System.ComponentModel.IComponent() {Me.SqlDataSource1})
        Me.DataMember = "vw_CCT_ORDERS_CLOSET"
        Me.DataSource = Me.SqlDataSource1
        Me.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.Margins = New System.Drawing.Printing.Margins(100, 100, 100, 167)
        Me.PageHeight = 1169
        Me.PageWidth = 827
        Me.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.Parameters.AddRange(New DevExpress.XtraReports.Parameters.Parameter() {Me.OfferID})
        Me.ScriptLanguage = DevExpress.XtraReports.ScriptLanguage.VisualBasic
        Me.Version = "21.2"
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub

    Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents XrPictureBox1 As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents XrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents PageHeader As DevExpress.XtraReports.UI.PageHeaderBand
    Friend WithEvents SqlDataSource1 As DevExpress.DataAccess.Sql.SqlDataSource
    Friend WithEvents OfferID As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents XrLabel39 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel40 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents ReportFooter As DevExpress.XtraReports.UI.ReportFooterBand
    Friend WithEvents XrLabel4 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel70 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel72 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLine1 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLine2 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLabel2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel41 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel7 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel8 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel9 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel10 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel11 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel12 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel43 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel42 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents DetailReport As DevExpress.XtraReports.UI.DetailReportBand
    Friend WithEvents Detail1 As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents GroupHeader1 As DevExpress.XtraReports.UI.GroupHeaderBand
    Friend WithEvents XrLabel36 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel37 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents DetailReport1 As DevExpress.XtraReports.UI.DetailReportBand
    Friend WithEvents Detail2 As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents GroupHeader2 As DevExpress.XtraReports.UI.GroupHeaderBand
    Friend WithEvents XrLabel31 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel32 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel33 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel3 As DevExpress.XtraReports.UI.XRLabel
End Class
