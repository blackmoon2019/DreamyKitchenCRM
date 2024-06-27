Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip

Public Class frmInstallationsCost
    Private InstallationsCost As New InstallationsCost
    Private LoadForms As New FormLoader
    Private ManageCbo As New CombosManager
    Private sID As String
    Private sInstID As String
    Private sTRANSH_ID As String
    Private bKitchen As Boolean
    Private bCloset As Boolean
    Private bDoors As Boolean
    Private bSC As Boolean
    Public Mode As Byte
    Private Ctrl As DevExpress.XtraGrid.Views.Grid.GridView
    Private Frm As DevExpress.XtraEditors.XtraForm
    Public WriteOnly Property ID As String
        Set(value As String)
            sID = value
        End Set
    End Property
    Public WriteOnly Property InstID As String
        Set(value As String)
            sInstID = value
        End Set
    End Property
    Public WriteOnly Property TRANSH_ID As String
        Set(value As String)
            sTRANSH_ID = value
        End Set
    End Property
    Public WriteOnly Property Kitchen As Boolean
        Set(value As Boolean)
            bKitchen = value
        End Set
    End Property
    Public WriteOnly Property Closet As Boolean
        Set(value As Boolean)
            bCloset = value
        End Set
    End Property
    Public WriteOnly Property Doors As Boolean
        Set(value As Boolean)
            bDoors = value
        End Set
    End Property
    Public WriteOnly Property SC As Boolean
        Set(value As Boolean)
            bSC = value
        End Set
    End Property

    Private Sub frmInstallationsCost_Load(sender As Object, e As EventArgs) Handles Me.Load
        InstallationsCost.Initialize(Me, sID, sInstID, Mode, bKitchen, bCloset, bDoors, bSC)
        InstallationsCost.LoadForm()
        Me.CenterToScreen()
    End Sub

    Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click
        InstallationsCost.SaveRecord(sID)
    End Sub

    Private Sub cmdExit_Click(sender As Object, e As EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub
End Class