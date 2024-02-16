<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class RepCompOffer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RepCompOffer))
        Dim CustomSqlQuery1 As DevExpress.DataAccess.Sql.CustomSqlQuery = New DevExpress.DataAccess.Sql.CustomSqlQuery()
        Dim QueryParameter1 As DevExpress.DataAccess.Sql.QueryParameter = New DevExpress.DataAccess.Sql.QueryParameter()
        Dim CustomSqlQuery2 As DevExpress.DataAccess.Sql.CustomSqlQuery = New DevExpress.DataAccess.Sql.CustomSqlQuery()
        Dim QueryParameter2 As DevExpress.DataAccess.Sql.QueryParameter = New DevExpress.DataAccess.Sql.QueryParameter()
        Dim MasterDetailInfo1 As DevExpress.DataAccess.Sql.MasterDetailInfo = New DevExpress.DataAccess.Sql.MasterDetailInfo()
        Dim RelationColumnInfo1 As DevExpress.DataAccess.Sql.RelationColumnInfo = New DevExpress.DataAccess.Sql.RelationColumnInfo()
        Dim MasterDetailInfo2 As DevExpress.DataAccess.Sql.MasterDetailInfo = New DevExpress.DataAccess.Sql.MasterDetailInfo()
        Dim RelationColumnInfo2 As DevExpress.DataAccess.Sql.RelationColumnInfo = New DevExpress.DataAccess.Sql.RelationColumnInfo()
        Dim DynamicListLookUpSettings1 As DevExpress.XtraReports.Parameters.DynamicListLookUpSettings = New DevExpress.XtraReports.Parameters.DynamicListLookUpSettings()
        Dim XrSummary1 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand()
        Me.XrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrPictureBox1 = New DevExpress.XtraReports.UI.XRPictureBox()
        Me.XrPanel1 = New DevExpress.XtraReports.UI.XRPanel()
        Me.XrLabel43 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel54 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel17 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel20 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel19 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel18 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel15 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel16 = New DevExpress.XtraReports.UI.XRLabel()
        Me.SqlDataSource1 = New DevExpress.DataAccess.Sql.SqlDataSource(Me.components)
        Me.ID = New DevExpress.XtraReports.Parameters.Parameter()
        Me.XrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrTable7 = New DevExpress.XtraReports.UI.XRTable()
        Me.XrTableRow24 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell45 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell46 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.GroupHeader1 = New DevExpress.XtraReports.UI.GroupHeaderBand()
        Me.XrTable5 = New DevExpress.XtraReports.UI.XRTable()
        Me.XrTableRow5 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell43 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell44 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.GroupFooter1 = New DevExpress.XtraReports.UI.GroupFooterBand()
        Me.XrTable1 = New DevExpress.XtraReports.UI.XRTable()
        Me.XrTableRow1 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell1 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell2 = New DevExpress.XtraReports.UI.XRTableCell()
        CType(Me.XrTable7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrTable5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrTable7})
        Me.Detail.HeightF = 22.0!
        Me.Detail.MultiColumn.ColumnCount = 3
        Me.Detail.MultiColumn.ColumnSpacing = 2.0!
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'TopMargin
        '
        Me.TopMargin.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel1, Me.XrPictureBox1})
        Me.TopMargin.HeightF = 94.0!
        Me.TopMargin.Name = "TopMargin"
        Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'BottomMargin
        '
        Me.BottomMargin.HeightF = 51.0!
        Me.BottomMargin.Name = "BottomMargin"
        Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'PageHeader
        '
        Me.PageHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel2, Me.XrPanel1})
        Me.PageHeader.HeightF = 208.1448!
        Me.PageHeader.Name = "PageHeader"
        '
        'XrLabel1
        '
        Me.XrLabel1.Font = New DevExpress.Drawing.DXFont("Zona Pro Regular", 10.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrLabel1.ForeColor = System.Drawing.Color.Gray
        Me.XrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(288.9284!, 15.36934!)
        Me.XrLabel1.Multiline = True
        Me.XrLabel1.Name = "XrLabel1"
        Me.XrLabel1.SizeF = New System.Drawing.SizeF(436.0719!, 56.05922!)
        Me.XrLabel1.StylePriority.UseFont = False
        Me.XrLabel1.StylePriority.UseForeColor = False
        Me.XrLabel1.StylePriority.UseTextAlignment = False
        Me.XrLabel1.Text = "Διεύθυνση: 25ης Μaρτίου, 5 Ταύρος, Τηλ: 210 3410770" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Web: www.dreamykitchen.gr," &
    " e-mail: info@dreamykitchen.gr"
        Me.XrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrPictureBox1
        '
        Me.XrPictureBox1.ImageSource = New DevExpress.XtraPrinting.Drawing.ImageSource("img", resources.GetString("XrPictureBox1.ImageSource"))
        Me.XrPictureBox1.LocationFloat = New DevExpress.Utils.PointFloat(0!, 15.36934!)
        Me.XrPictureBox1.Name = "XrPictureBox1"
        Me.XrPictureBox1.SizeF = New System.Drawing.SizeF(275.8548!, 56.05922!)
        '
        'XrPanel1
        '
        Me.XrPanel1.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrPanel1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel43, Me.XrLabel54, Me.XrLabel17, Me.XrLabel20, Me.XrLabel19, Me.XrLabel18, Me.XrLabel15, Me.XrLabel16})
        Me.XrPanel1.LocationFloat = New DevExpress.Utils.PointFloat(0.0001907349!, 56.9722!)
        Me.XrPanel1.Name = "XrPanel1"
        Me.XrPanel1.SizeF = New System.Drawing.SizeF(724.9998!, 137.1726!)
        Me.XrPanel1.StylePriority.UseBorders = False
        '
        'XrLabel43
        '
        Me.XrLabel43.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel43.CanShrink = True
        Me.XrLabel43.Font = New DevExpress.Drawing.DXFont("Zona Pro", 10.0!)
        Me.XrLabel43.ForeColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(113, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.XrLabel43.LocationFloat = New DevExpress.Utils.PointFloat(4.999701!, 102.9584!)
        Me.XrLabel43.Name = "XrLabel43"
        Me.XrLabel43.SizeF = New System.Drawing.SizeF(73.8238!, 20.00001!)
        Me.XrLabel43.StylePriority.UseBorders = False
        Me.XrLabel43.StylePriority.UseFont = False
        Me.XrLabel43.StylePriority.UseForeColor = False
        Me.XrLabel43.Text = "Πωλητής:"
        '
        'XrLabel54
        '
        Me.XrLabel54.BorderColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(113, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.XrLabel54.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrLabel54.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[vw_TRANSH].[SalerName]")})
        Me.XrLabel54.Font = New DevExpress.Drawing.DXFont("Zona Pro Regular", 9.0!)
        Me.XrLabel54.ForeColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(113, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.XrLabel54.LocationFloat = New DevExpress.Utils.PointFloat(187.3236!, 102.9584!)
        Me.XrLabel54.Multiline = True
        Me.XrLabel54.Name = "XrLabel54"
        Me.XrLabel54.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel54.SizeF = New System.Drawing.SizeF(514.5!, 20.00002!)
        Me.XrLabel54.StylePriority.UseBorderColor = False
        Me.XrLabel54.StylePriority.UseBorders = False
        Me.XrLabel54.StylePriority.UseFont = False
        Me.XrLabel54.StylePriority.UseForeColor = False
        Me.XrLabel54.Text = "XrLabel26"
        '
        'XrLabel17
        '
        Me.XrLabel17.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel17.CanShrink = True
        Me.XrLabel17.Font = New DevExpress.Drawing.DXFont("Zona Pro", 10.0!)
        Me.XrLabel17.ForeColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(113, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.XrLabel17.LocationFloat = New DevExpress.Utils.PointFloat(3.0!, 71.0!)
        Me.XrLabel17.Name = "XrLabel17"
        Me.XrLabel17.SizeF = New System.Drawing.SizeF(159.1987!, 20.0!)
        Me.XrLabel17.StylePriority.UseBorders = False
        Me.XrLabel17.StylePriority.UseFont = False
        Me.XrLabel17.StylePriority.UseForeColor = False
        Me.XrLabel17.Text = "Ημ/νία Προσφοράς:"
        '
        'XrLabel20
        '
        Me.XrLabel20.BorderColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(113, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.XrLabel20.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrLabel20.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "Now()")})
        Me.XrLabel20.Font = New DevExpress.Drawing.DXFont("Zona Pro Regular", 9.0!)
        Me.XrLabel20.ForeColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(113, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.XrLabel20.LocationFloat = New DevExpress.Utils.PointFloat(187.3235!, 70.99997!)
        Me.XrLabel20.Multiline = True
        Me.XrLabel20.Name = "XrLabel20"
        Me.XrLabel20.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel20.SizeF = New System.Drawing.SizeF(514.5001!, 20.0!)
        Me.XrLabel20.StylePriority.UseBorderColor = False
        Me.XrLabel20.StylePriority.UseBorders = False
        Me.XrLabel20.StylePriority.UseFont = False
        Me.XrLabel20.StylePriority.UseForeColor = False
        Me.XrLabel20.Text = "XrLabel20"
        '
        'XrLabel19
        '
        Me.XrLabel19.BorderColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(113, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.XrLabel19.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrLabel19.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[vw_TRANSH].[description]")})
        Me.XrLabel19.Font = New DevExpress.Drawing.DXFont("Zona Pro Regular", 9.0!)
        Me.XrLabel19.ForeColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.XrLabel19.LocationFloat = New DevExpress.Utils.PointFloat(187.3236!, 43.00003!)
        Me.XrLabel19.Multiline = True
        Me.XrLabel19.Name = "XrLabel19"
        Me.XrLabel19.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel19.SizeF = New System.Drawing.SizeF(514.5!, 23.00002!)
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
        Me.XrLabel18.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[vw_TRANSH].[Fullname]")})
        Me.XrLabel18.Font = New DevExpress.Drawing.DXFont("Zona Pro Regular", 9.0!)
        Me.XrLabel18.ForeColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(113, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.XrLabel18.LocationFloat = New DevExpress.Utils.PointFloat(187.3235!, 13.00001!)
        Me.XrLabel18.Multiline = True
        Me.XrLabel18.Name = "XrLabel18"
        Me.XrLabel18.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel18.SizeF = New System.Drawing.SizeF(514.5001!, 23.0!)
        Me.XrLabel18.StylePriority.UseBorderColor = False
        Me.XrLabel18.StylePriority.UseBorders = False
        Me.XrLabel18.StylePriority.UseFont = False
        Me.XrLabel18.StylePriority.UseForeColor = False
        Me.XrLabel18.Text = "XrLabel18"
        '
        'XrLabel15
        '
        Me.XrLabel15.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel15.CanShrink = True
        Me.XrLabel15.Font = New DevExpress.Drawing.DXFont("Zona Pro", 10.0!)
        Me.XrLabel15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(113, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.XrLabel15.LocationFloat = New DevExpress.Utils.PointFloat(3.000009!, 13.00004!)
        Me.XrLabel15.Name = "XrLabel15"
        Me.XrLabel15.SizeF = New System.Drawing.SizeF(128.824!, 20.0!)
        Me.XrLabel15.StylePriority.UseBorders = False
        Me.XrLabel15.StylePriority.UseFont = False
        Me.XrLabel15.StylePriority.UseForeColor = False
        Me.XrLabel15.Text = "Πελάτης / Εταιρία:"
        '
        'XrLabel16
        '
        Me.XrLabel16.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel16.CanShrink = True
        Me.XrLabel16.Font = New DevExpress.Drawing.DXFont("Zona Pro", 10.0!)
        Me.XrLabel16.ForeColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(113, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.XrLabel16.LocationFloat = New DevExpress.Utils.PointFloat(3.000009!, 46.00007!)
        Me.XrLabel16.Name = "XrLabel16"
        Me.XrLabel16.SizeF = New System.Drawing.SizeF(175.8652!, 19.99999!)
        Me.XrLabel16.StylePriority.UseBorders = False
        Me.XrLabel16.StylePriority.UseFont = False
        Me.XrLabel16.StylePriority.UseForeColor = False
        Me.XrLabel16.Text = "Έργο πελάτη / Εταιρείας:"
        '
        'SqlDataSource1
        '
        Me.SqlDataSource1.ConnectionName = "DreamyKitchenCRM.My.MySettings.DreamyKitchenConnectionStringRemotely"
        Me.SqlDataSource1.Name = "SqlDataSource1"
        CustomSqlQuery1.Name = "vw_TRANSH"
        QueryParameter1.Name = "ID"
        QueryParameter1.Type = GetType(DevExpress.DataAccess.Expression)
        QueryParameter1.Value = New DevExpress.DataAccess.Expression("?ID", GetType(System.Guid))
        CustomSqlQuery1.Parameters.AddRange(New DevExpress.DataAccess.Sql.QueryParameter() {QueryParameter1})
        CustomSqlQuery1.Sql = "select ""vw_TRANSH"".""SalerName""," & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "       ""vw_TRANSH"".""description""," & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "       ""vw_TR" &
    "ANSH"".""Fullname""" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "  from ""dbo"".""vw_TRANSH"" ""vw_TRANSH""" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "where ID=@ID"
        CustomSqlQuery2.Name = "CCT_Comp_Projects"
        QueryParameter2.Name = "ID"
        QueryParameter2.Type = GetType(DevExpress.DataAccess.Expression)
        QueryParameter2.Value = New DevExpress.DataAccess.Expression("?ID", GetType(System.Guid))
        CustomSqlQuery2.Parameters.AddRange(New DevExpress.DataAccess.Sql.QueryParameter() {QueryParameter2})
        CustomSqlQuery2.Sql = "select HC.Fullname,D.amt  " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "from TRANSH H" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "inner join TRANSD D on D.transhID = H." &
    "ID " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "inner join vw_TRANSH HC on HC.compTrashID  = H.ID and HC.cusID = D.cusID " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) &
    "where H.ID = @ID"
        Me.SqlDataSource1.Queries.AddRange(New DevExpress.DataAccess.Sql.SqlQuery() {CustomSqlQuery1, CustomSqlQuery2})
        MasterDetailInfo1.DetailQueryName = "vw_CCT_ORDERS_KITCHEN"
        RelationColumnInfo1.NestedKeyColumn = "ID"
        RelationColumnInfo1.ParentKeyColumn = "cctOrdersKitchenID"
        MasterDetailInfo1.KeyColumns.Add(RelationColumnInfo1)
        MasterDetailInfo1.MasterQueryName = "vw_CCT_ORDERS_KITCHEN_EQUIPMENT"
        MasterDetailInfo2.DetailQueryName = "vw_CCT_ORDERS_KITCHEN"
        RelationColumnInfo2.NestedKeyColumn = "ID"
        RelationColumnInfo2.ParentKeyColumn = "cctOrdersKitchenID"
        MasterDetailInfo2.KeyColumns.Add(RelationColumnInfo2)
        MasterDetailInfo2.MasterQueryName = "vw_CCT_ORDERS_KITCHEN_EQUIPMENT_EXTRA"
        Me.SqlDataSource1.Relations.AddRange(New DevExpress.DataAccess.Sql.MasterDetailInfo() {MasterDetailInfo1, MasterDetailInfo2})
        Me.SqlDataSource1.ResultSchemaSerializable = resources.GetString("SqlDataSource1.ResultSchemaSerializable")
        '
        'ID
        '
        Me.ID.Description = "ID"
        Me.ID.Name = "ID"
        Me.ID.Type = GetType(System.Guid)
        Me.ID.ValueInfo = "2f96a393-7a86-40d6-9601-854f87d2bae2"
        DynamicListLookUpSettings1.DataMember = "CCT_Comp_Projects"
        DynamicListLookUpSettings1.DataSource = Me.SqlDataSource1
        DynamicListLookUpSettings1.DisplayMember = "ID"
        DynamicListLookUpSettings1.ValueMember = "ID"
        Me.ID.ValueSourceSettings = DynamicListLookUpSettings1
        Me.ID.Visible = False
        '
        'XrLabel2
        '
        Me.XrLabel2.BackColor = System.Drawing.Color.White
        Me.XrLabel2.Font = New DevExpress.Drawing.DXFont("Zona Pro", 20.0!, CType((DevExpress.Drawing.DXFontStyle.Bold Or DevExpress.Drawing.DXFontStyle.Underline), DevExpress.Drawing.DXFontStyle))
        Me.XrLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(113, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.XrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(0!, 0!)
        Me.XrLabel2.Name = "XrLabel2"
        Me.XrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.XrLabel2.SizeF = New System.Drawing.SizeF(724.9999!, 35.5555!)
        Me.XrLabel2.StylePriority.UseBackColor = False
        Me.XrLabel2.StylePriority.UseFont = False
        Me.XrLabel2.StylePriority.UseForeColor = False
        Me.XrLabel2.StylePriority.UsePadding = False
        Me.XrLabel2.StylePriority.UseTextAlignment = False
        Me.XrLabel2.Text = "Συγκεντρωτική Προσφορά"
        Me.XrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrTable7
        '
        Me.XrTable7.BorderColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(113, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.XrTable7.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTable7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(113, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.XrTable7.LocationFloat = New DevExpress.Utils.PointFloat(1.000032!, 0!)
        Me.XrTable7.Name = "XrTable7"
        Me.XrTable7.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96.0!)
        Me.XrTable7.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow24})
        Me.XrTable7.SizeF = New System.Drawing.SizeF(723.9997!, 22.0!)
        Me.XrTable7.StylePriority.UseBorderColor = False
        Me.XrTable7.StylePriority.UseBorders = False
        Me.XrTable7.StylePriority.UseForeColor = False
        '
        'XrTableRow24
        '
        Me.XrTableRow24.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell45, Me.XrTableCell46})
        Me.XrTableRow24.Name = "XrTableRow24"
        Me.XrTableRow24.Weight = 1.1922581760180335R
        '
        'XrTableCell45
        '
        Me.XrTableCell45.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[CCT_Comp_Projects].[Fullname]")})
        Me.XrTableCell45.Font = New DevExpress.Drawing.DXFont("Zona Pro", 9.0!)
        Me.XrTableCell45.ForeColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(113, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.XrTableCell45.Multiline = True
        Me.XrTableCell45.Name = "XrTableCell45"
        Me.XrTableCell45.StylePriority.UseFont = False
        Me.XrTableCell45.StylePriority.UseForeColor = False
        Me.XrTableCell45.StylePriority.UseTextAlignment = False
        Me.XrTableCell45.Text = "XrTableCell1"
        Me.XrTableCell45.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrTableCell45.Weight = 1.195671880594277R
        '
        'XrTableCell46
        '
        Me.XrTableCell46.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[CCT_Comp_Projects].[amt]")})
        Me.XrTableCell46.Font = New DevExpress.Drawing.DXFont("Zona Pro", 9.0!)
        Me.XrTableCell46.ForeColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(113, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.XrTableCell46.Multiline = True
        Me.XrTableCell46.Name = "XrTableCell46"
        Me.XrTableCell46.StylePriority.UseFont = False
        Me.XrTableCell46.StylePriority.UseForeColor = False
        Me.XrTableCell46.StylePriority.UseTextAlignment = False
        Me.XrTableCell46.Text = "XrTableCell2"
        Me.XrTableCell46.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrTableCell46.TextFormatString = "{0:C}"
        Me.XrTableCell46.Weight = 0.804328119405723R
        '
        'GroupHeader1
        '
        Me.GroupHeader1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrTable5})
        Me.GroupHeader1.HeightF = 22.0!
        Me.GroupHeader1.Name = "GroupHeader1"
        '
        'XrTable5
        '
        Me.XrTable5.BorderColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(113, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.XrTable5.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTable5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(113, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.XrTable5.LocationFloat = New DevExpress.Utils.PointFloat(1.000032!, 0!)
        Me.XrTable5.Name = "XrTable5"
        Me.XrTable5.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96.0!)
        Me.XrTable5.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow5})
        Me.XrTable5.SizeF = New System.Drawing.SizeF(723.9997!, 22.0!)
        Me.XrTable5.StylePriority.UseBorderColor = False
        Me.XrTable5.StylePriority.UseBorders = False
        Me.XrTable5.StylePriority.UseForeColor = False
        '
        'XrTableRow5
        '
        Me.XrTableRow5.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell43, Me.XrTableCell44})
        Me.XrTableRow5.Name = "XrTableRow5"
        Me.XrTableRow5.Weight = 1.1922581760180337R
        '
        'XrTableCell43
        '
        Me.XrTableCell43.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.XrTableCell43.Font = New DevExpress.Drawing.DXFont("Zona Pro Regular", 11.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrTableCell43.ForeColor = System.Drawing.Color.Gray
        Me.XrTableCell43.Multiline = True
        Me.XrTableCell43.Name = "XrTableCell43"
        Me.XrTableCell43.StylePriority.UseBackColor = False
        Me.XrTableCell43.StylePriority.UseFont = False
        Me.XrTableCell43.StylePriority.UseForeColor = False
        Me.XrTableCell43.StylePriority.UseTextAlignment = False
        Me.XrTableCell43.Text = "Πελάτης"
        Me.XrTableCell43.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrTableCell43.Weight = 1.195671880594277R
        '
        'XrTableCell44
        '
        Me.XrTableCell44.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.XrTableCell44.Font = New DevExpress.Drawing.DXFont("Zona Pro Regular", 11.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrTableCell44.ForeColor = System.Drawing.Color.Gray
        Me.XrTableCell44.Multiline = True
        Me.XrTableCell44.Name = "XrTableCell44"
        Me.XrTableCell44.StylePriority.UseBackColor = False
        Me.XrTableCell44.StylePriority.UseFont = False
        Me.XrTableCell44.StylePriority.UseForeColor = False
        Me.XrTableCell44.StylePriority.UseTextAlignment = False
        Me.XrTableCell44.Text = "Συνολικό Κόστος"
        Me.XrTableCell44.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrTableCell44.Weight = 0.804328119405723R
        '
        'GroupFooter1
        '
        Me.GroupFooter1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrTable1})
        Me.GroupFooter1.Name = "GroupFooter1"
        '
        'XrTable1
        '
        Me.XrTable1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(113, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.XrTable1.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTable1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(113, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.XrTable1.LocationFloat = New DevExpress.Utils.PointFloat(1.000032!, 0!)
        Me.XrTable1.Name = "XrTable1"
        Me.XrTable1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96.0!)
        Me.XrTable1.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow1})
        Me.XrTable1.SizeF = New System.Drawing.SizeF(723.9997!, 22.0!)
        Me.XrTable1.StylePriority.UseBorderColor = False
        Me.XrTable1.StylePriority.UseBorders = False
        Me.XrTable1.StylePriority.UseForeColor = False
        '
        'XrTableRow1
        '
        Me.XrTableRow1.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell1, Me.XrTableCell2})
        Me.XrTableRow1.Name = "XrTableRow1"
        Me.XrTableRow1.Weight = 1.1922581760180337R
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
        Me.XrTableCell1.Text = "Συνολικό Κόστος"
        Me.XrTableCell1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrTableCell1.Weight = 1.195671880594277R
        '
        'XrTableCell2
        '
        Me.XrTableCell2.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.XrTableCell2.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "sumSum([amt])")})
        Me.XrTableCell2.Font = New DevExpress.Drawing.DXFont("Zona Pro Regular", 10.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrTableCell2.ForeColor = System.Drawing.Color.Gray
        Me.XrTableCell2.Multiline = True
        Me.XrTableCell2.Name = "XrTableCell2"
        Me.XrTableCell2.StylePriority.UseBackColor = False
        Me.XrTableCell2.StylePriority.UseFont = False
        Me.XrTableCell2.StylePriority.UseForeColor = False
        Me.XrTableCell2.StylePriority.UseTextAlignment = False
        XrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.XrTableCell2.Summary = XrSummary1
        Me.XrTableCell2.Text = "Συνολικό Κόστος"
        Me.XrTableCell2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrTableCell2.TextFormatString = "{0:C}"
        Me.XrTableCell2.Weight = 0.804328119405723R
        '
        'RepCompOffer
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin, Me.PageHeader, Me.GroupHeader1, Me.GroupFooter1})
        Me.ComponentStorage.AddRange(New System.ComponentModel.IComponent() {Me.SqlDataSource1})
        Me.DataMember = "CCT_Comp_Projects"
        Me.DataSource = Me.SqlDataSource1
        Me.Font = New DevExpress.Drawing.DXFont("Times New Roman", 9.0!)
        Me.Margins = New DevExpress.Drawing.DXMargins(51.0!, 51.0!, 94.0!, 51.0!)
        Me.PageHeight = 1169
        Me.PageWidth = 827
        Me.PaperKind = DevExpress.Drawing.Printing.DXPaperKind.A4
        Me.ParameterPanelLayoutItems.AddRange(New DevExpress.XtraReports.Parameters.ParameterPanelLayoutItem() {New DevExpress.XtraReports.Parameters.ParameterLayoutItem(Me.ID, DevExpress.XtraReports.Parameters.Orientation.Horizontal)})
        Me.Parameters.AddRange(New DevExpress.XtraReports.Parameters.Parameter() {Me.ID})
        Me.ScriptLanguage = DevExpress.XtraReports.ScriptLanguage.VisualBasic
        Me.Version = "23.1"
        CType(Me.XrTable7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrTable5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub

    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents XrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrPictureBox1 As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents PageHeader As DevExpress.XtraReports.UI.PageHeaderBand
    Friend WithEvents XrPanel1 As DevExpress.XtraReports.UI.XRPanel
    Friend WithEvents XrLabel43 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel54 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel17 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel20 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel19 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel18 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel15 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel16 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents SqlDataSource1 As DevExpress.DataAccess.Sql.SqlDataSource
    Friend WithEvents ID As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents XrLabel2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrTable7 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow24 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell45 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell46 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents GroupHeader1 As DevExpress.XtraReports.UI.GroupHeaderBand
    Friend WithEvents XrTable5 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow5 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell43 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell44 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents GroupFooter1 As DevExpress.XtraReports.UI.GroupFooterBand
    Friend WithEvents XrTable1 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow1 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell1 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell2 As DevExpress.XtraReports.UI.XRTableCell
End Class
