Partial Public Class frmUpdate
    Inherits DevExpress.XtraEditors.XtraForm

    ''' <summary>
    ''' Required designer variable.
    ''' </summary>
    Private components As System.ComponentModel.IContainer = Nothing

    ''' <summary>
    ''' Clean up any resources being used.
    ''' </summary>
    ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso (components IsNot Nothing) Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

#Region "Windows Form Designer generated code"

    ''' <summary>
    ''' Required method for Designer support - do not modify
    ''' the contents of this method with the code editor.
    ''' </summary>
    Private Sub InitializeComponent()
        Me.lblFileCounter = New DevExpress.XtraEditors.LabelControl()
        Me.peImage = New DevExpress.XtraEditors.PictureEdit()
        Me.lblTotal = New DevExpress.XtraEditors.LabelControl()
        Me.cmdExit = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdUpdate = New DevExpress.XtraEditors.SimpleButton()
        Me.ProgressBarControl2 = New DevExpress.XtraEditors.ProgressBarControl()
        Me.ProgressBarControl1 = New DevExpress.XtraEditors.ProgressBarControl()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        CType(Me.peImage.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProgressBarControl2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProgressBarControl1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblFileCounter
        '
        Me.lblFileCounter.Location = New System.Drawing.Point(14, 261)
        Me.lblFileCounter.Margin = New System.Windows.Forms.Padding(2)
        Me.lblFileCounter.Name = "lblFileCounter"
        Me.lblFileCounter.Size = New System.Drawing.Size(0, 13)
        Me.lblFileCounter.TabIndex = 23
        '
        'peImage
        '
        Me.peImage.Cursor = System.Windows.Forms.Cursors.Default
        Me.peImage.Dock = System.Windows.Forms.DockStyle.Top
        Me.peImage.EditValue = Global.DreamyKitchenUpdater.My.Resources.Resources.logo
        Me.peImage.Location = New System.Drawing.Point(0, 0)
        Me.peImage.Name = "peImage"
        Me.peImage.Properties.AllowFocused = False
        Me.peImage.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.peImage.Properties.Appearance.Options.UseBackColor = True
        Me.peImage.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.peImage.Properties.ShowMenu = False
        Me.peImage.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch
        Me.peImage.Properties.SvgImageColorizationMode = DevExpress.Utils.SvgImageColorizationMode.None
        Me.peImage.Size = New System.Drawing.Size(632, 265)
        Me.peImage.TabIndex = 22
        '
        'lblTotal
        '
        Me.lblTotal.Location = New System.Drawing.Point(14, 314)
        Me.lblTotal.Margin = New System.Windows.Forms.Padding(2)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(0, 13)
        Me.lblTotal.TabIndex = 21
        '
        'cmdExit
        '
        Me.cmdExit.Location = New System.Drawing.Point(470, 365)
        Me.cmdExit.Margin = New System.Windows.Forms.Padding(2)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(75, 24)
        Me.cmdExit.TabIndex = 20
        Me.cmdExit.Text = "Έξοδος"
        '
        'cmdUpdate
        '
        Me.cmdUpdate.Location = New System.Drawing.Point(551, 365)
        Me.cmdUpdate.Margin = New System.Windows.Forms.Padding(2)
        Me.cmdUpdate.Name = "cmdUpdate"
        Me.cmdUpdate.Size = New System.Drawing.Size(75, 24)
        Me.cmdUpdate.TabIndex = 19
        Me.cmdUpdate.Text = "Ενημέρωση"
        '
        'ProgressBarControl2
        '
        Me.ProgressBarControl2.Location = New System.Drawing.Point(8, 332)
        Me.ProgressBarControl2.Margin = New System.Windows.Forms.Padding(2)
        Me.ProgressBarControl2.Name = "ProgressBarControl2"
        Me.ProgressBarControl2.Properties.ShowTitle = True
        Me.ProgressBarControl2.Size = New System.Drawing.Size(620, 19)
        Me.ProgressBarControl2.TabIndex = 18
        '
        'ProgressBarControl1
        '
        Me.ProgressBarControl1.Location = New System.Drawing.Point(8, 285)
        Me.ProgressBarControl1.Margin = New System.Windows.Forms.Padding(2)
        Me.ProgressBarControl1.Name = "ProgressBarControl1"
        Me.ProgressBarControl1.Properties.ShowTitle = True
        Me.ProgressBarControl1.Size = New System.Drawing.Size(620, 19)
        Me.ProgressBarControl1.TabIndex = 17
        '
        'frmUpdate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(632, 392)
        Me.Controls.Add(Me.lblFileCounter)
        Me.Controls.Add(Me.peImage)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.cmdExit)
        Me.Controls.Add(Me.cmdUpdate)
        Me.Controls.Add(Me.ProgressBarControl2)
        Me.Controls.Add(Me.ProgressBarControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmUpdate"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Αναβάθμιση"
        CType(Me.peImage.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProgressBarControl2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProgressBarControl1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblFileCounter As DevExpress.XtraEditors.LabelControl
    Private WithEvents peImage As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents lblTotal As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmdExit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdUpdate As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ProgressBarControl2 As DevExpress.XtraEditors.ProgressBarControl
    Friend WithEvents ProgressBarControl1 As DevExpress.XtraEditors.ProgressBarControl
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker

#End Region

End Class
