<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class RepOfferMech
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
        Dim CustomSqlQuery1 As DevExpress.DataAccess.Sql.CustomSqlQuery = New DevExpress.DataAccess.Sql.CustomSqlQuery()
        Dim QueryParameter1 As DevExpress.DataAccess.Sql.QueryParameter = New DevExpress.DataAccess.Sql.QueryParameter()
        Dim DynamicListLookUpSettings1 As DevExpress.XtraReports.Parameters.DynamicListLookUpSettings = New DevExpress.XtraReports.Parameters.DynamicListLookUpSettings()
        Me.SqlDataSource1 = New DevExpress.DataAccess.Sql.SqlDataSource(Me.components)
        Me.Vw_NOTESTableAdapter = New DreamyKitchenCRM.DreamyKitchenDataSetTableAdapters.vw_NOTESTableAdapter()
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
        Me.XrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.offerID = New DevExpress.XtraReports.Parameters.Parameter()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'SqlDataSource1
        '
        Me.SqlDataSource1.ConnectionName = "DreamyKitchenCRM.My.MySettings.DreamyKitchenConnectionStringRemotely"
        Me.SqlDataSource1.Name = "SqlDataSource1"
        CustomSqlQuery1.Name = "vw_OFFER_MECH"
        QueryParameter1.Name = "OfferID"
        QueryParameter1.Type = GetType(DevExpress.DataAccess.Expression)
        QueryParameter1.Value = New DevExpress.DataAccess.Expression("?offerID", GetType(System.Guid))
        CustomSqlQuery1.Parameters.Add(QueryParameter1)
        CustomSqlQuery1.Sql = "select distinct  ""vw_OFFER_MECH"".""name""" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "  from ""dbo"".""vw_OFFER_MECH"" ""vw_OFFER_M" &
    "ECH""" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " where (""vw_OFFER_MECH"".""offID"" = @OfferID)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "and ""vw_OFFER_MECH"".""qty"">0"
        Me.SqlDataSource1.Queries.AddRange(New DevExpress.DataAccess.Sql.SqlQuery() {CustomSqlQuery1})
        Me.SqlDataSource1.ResultSchemaSerializable = "PERhdGFTZXQgTmFtZT0iU3FsRGF0YVNvdXJjZTEiPjxWaWV3IE5hbWU9InZ3X09GRkVSX01FQ0giPjxGa" &
    "WVsZCBOYW1lPSJuYW1lIiBUeXBlPSJTdHJpbmciIC8+PC9WaWV3PjwvRGF0YVNldD4="
        '
        'Vw_NOTESTableAdapter
        '
        Me.Vw_NOTESTableAdapter.ClearBeforeFill = True
        '
        'TopMargin
        '
        Me.TopMargin.HeightF = 0!
        Me.TopMargin.Name = "TopMargin"
        '
        'BottomMargin
        '
        Me.BottomMargin.HeightF = 0!
        Me.BottomMargin.Name = "BottomMargin"
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel2, Me.XrLabel1})
        Me.Detail.HeightF = 16.04166!
        Me.Detail.Name = "Detail"
        '
        'XrLabel2
        '
        Me.XrLabel2.ForeColor = System.Drawing.Color.Gray
        Me.XrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(0!, 0!)
        Me.XrLabel2.Multiline = True
        Me.XrLabel2.Name = "XrLabel2"
        Me.XrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel2.SizeF = New System.Drawing.SizeF(14.58333!, 16.04166!)
        Me.XrLabel2.StylePriority.UseForeColor = False
        Me.XrLabel2.Text = "*"
        '
        'XrLabel1
        '
        Me.XrLabel1.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[name]")})
        Me.XrLabel1.Font = New DevExpress.Drawing.DXFont("Zona Pro Regular", 9.0!)
        Me.XrLabel1.ForeColor = System.Drawing.Color.Gray
        Me.XrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(14.58333!, 0!)
        Me.XrLabel1.Multiline = True
        Me.XrLabel1.Name = "XrLabel1"
        Me.XrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel1.SizeF = New System.Drawing.SizeF(279.125!, 16.04166!)
        Me.XrLabel1.StylePriority.UseFont = False
        Me.XrLabel1.StylePriority.UseForeColor = False
        Me.XrLabel1.Text = "XrLabel1"
        '
        'offerID
        '
        Me.offerID.Description = "offerID"
        Me.offerID.Name = "offerID"
        Me.offerID.Type = GetType(System.Guid)
        Me.offerID.ValueInfo = "00000000-0000-0000-0000-000000000000"
        DynamicListLookUpSettings1.DataMember = "vw_OFFER_MECH"
        DynamicListLookUpSettings1.DataSource = Me.SqlDataSource1
        DynamicListLookUpSettings1.DisplayMember = Nothing
        DynamicListLookUpSettings1.FilterString = "[offerID] = [offerID]"
        DynamicListLookUpSettings1.SortMember = Nothing
        DynamicListLookUpSettings1.ValueMember = "offerID"
        Me.offerID.ValueSourceSettings = DynamicListLookUpSettings1
        '
        'RepOfferMech
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.TopMargin, Me.BottomMargin, Me.Detail})
        Me.ComponentStorage.AddRange(New System.ComponentModel.IComponent() {Me.SqlDataSource1})
        Me.DataMember = "vw_OFFER_MECH"
        Me.DataSource = Me.SqlDataSource1
        Me.Font = New DevExpress.Drawing.DXFont("Zona Pro Regular", 8.999999!, DevExpress.Drawing.DXFontStyle.Regular, DevExpress.Drawing.DXGraphicsUnit.Point, New DevExpress.Drawing.DXFontAdditionalProperty() {New DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", CType(161, Byte))})
        Me.Margins = New DevExpress.Drawing.DXMargins(100, 448, 0, 0)
        Me.Parameters.AddRange(New DevExpress.XtraReports.Parameters.Parameter() {Me.offerID})
        Me.Version = "20.2"
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents Vw_NOTESTableAdapter As DreamyKitchenDataSetTableAdapters.vw_NOTESTableAdapter
    Friend WithEvents SqlDataSource1 As DevExpress.DataAccess.Sql.SqlDataSource
    Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents XrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents offerID As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents XrLabel2 As DevExpress.XtraReports.UI.XRLabel
End Class
