<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmImageSlider
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.mySlider = New DevExpress.XtraEditors.Controls.ImageSlider()
        Me.cmdExit = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.mySlider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'mySlider
        '
        Me.mySlider.Dock = System.Windows.Forms.DockStyle.Fill
        Me.mySlider.Location = New System.Drawing.Point(0, 0)
        Me.mySlider.Name = "mySlider"
        Me.mySlider.Size = New System.Drawing.Size(1896, 1393)
        Me.mySlider.TabIndex = 20
        Me.mySlider.Text = "ImageSlider1"
        '
        'cmdExit
        '
        Me.cmdExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdExit.ImageOptions.Image = Global.DreamyKitchenCRM.My.Resources.Resources.icons8_exit_24
        Me.cmdExit.Location = New System.Drawing.Point(1699, 1342)
        Me.cmdExit.Margin = New System.Windows.Forms.Padding(5)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(179, 39)
        Me.cmdExit.TabIndex = 19
        Me.cmdExit.Text = "Έξοδος"
        '
        'frmImageSlider
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 23.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1896, 1393)
        Me.Controls.Add(Me.mySlider)
        Me.Controls.Add(Me.cmdExit)
        Me.IconOptions.Image = Global.DreamyKitchenCRM.My.Resources.Resources.favicon
        Me.Name = "frmImageSlider"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ΚΥΛΙΣΗ ΕΙΚΟΝΩΝ"
        CType(Me.mySlider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents mySlider As DevExpress.XtraEditors.Controls.ImageSlider
    Friend WithEvents cmdExit As DevExpress.XtraEditors.SimpleButton
End Class
