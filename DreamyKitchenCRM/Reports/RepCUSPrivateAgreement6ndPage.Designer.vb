<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class RepCUSPrivateAgreement6ndPage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RepCUSPrivateAgreement6ndPage))
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.XrRichText1 = New DevExpress.XtraReports.UI.XRRichText()
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
        Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand()
        Me.XrRichText2 = New DevExpress.XtraReports.UI.XRRichText()
        Me.PageFooter = New DevExpress.XtraReports.UI.PageFooterBand()
        CType(Me.XrRichText1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrRichText2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'TopMargin
        '
        Me.TopMargin.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrRichText1})
        Me.TopMargin.HeightF = 152.6667!
        Me.TopMargin.Name = "TopMargin"
        '
        'XrRichText1
        '
        Me.XrRichText1.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrRichText1.LocationFloat = New DevExpress.Utils.PointFloat(157.9524!, 21.11905!)
        Me.XrRichText1.Name = "XrRichText1"
        Me.XrRichText1.SerializableRtfString = resources.GetString("XrRichText1.SerializableRtfString")
        Me.XrRichText1.SizeF = New System.Drawing.SizeF(310.7142!, 100.0!)
        Me.XrRichText1.StylePriority.UseBorders = False
        '
        'BottomMargin
        '
        Me.BottomMargin.Name = "BottomMargin"
        '
        'Detail
        '
        Me.Detail.HeightF = 0.1671201!
        Me.Detail.Name = "Detail"
        '
        'PageHeader
        '
        Me.PageHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrRichText2})
        Me.PageHeader.HeightF = 790.8184!
        Me.PageHeader.Name = "PageHeader"
        '
        'XrRichText2
        '
        Me.XrRichText2.Font = New DevExpress.Drawing.DXFont("Arial", 9.75!)
        Me.XrRichText2.LocationFloat = New DevExpress.Utils.PointFloat(2.380965!, 0!)
        Me.XrRichText2.Name = "XrRichText2"
        Me.XrRichText2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrRichText2.SerializableRtfString = resources.GetString("XrRichText2.SerializableRtfString")
        Me.XrRichText2.SizeF = New System.Drawing.SizeF(657.6191!, 790.8184!)
        Me.XrRichText2.StylePriority.UseFont = False
        '
        'PageFooter
        '
        Me.PageFooter.HeightF = 0!
        Me.PageFooter.Name = "PageFooter"
        '
        'RepCUSPrivateAgreement6ndPage
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.TopMargin, Me.BottomMargin, Me.Detail, Me.PageHeader, Me.PageFooter})
        Me.Font = New DevExpress.Drawing.DXFont("Zona Pro Light", 9.75!)
        Me.Margins = New DevExpress.Drawing.DXMargins(83.0!, 84.0!, 152.6667!, 100.0!)
        Me.PageHeight = 1169
        Me.PageWidth = 827
        Me.PaperKind = DevExpress.Drawing.Printing.DXPaperKind.A4
        Me.ScriptLanguage = DevExpress.XtraReports.ScriptLanguage.VisualBasic
        Me.SnapGridSize = 9.84252!
        Me.Version = "23.2"
        CType(Me.XrRichText1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrRichText2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub

    Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents XrRichText1 As DevExpress.XtraReports.UI.XRRichText
    Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents PageHeader As DevExpress.XtraReports.UI.PageHeaderBand
    Friend WithEvents XrRichText2 As DevExpress.XtraReports.UI.XRRichText
    Friend WithEvents PageFooter As DevExpress.XtraReports.UI.PageFooterBand
End Class
