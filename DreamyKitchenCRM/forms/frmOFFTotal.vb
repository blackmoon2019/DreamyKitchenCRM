Imports System.Data.SqlClient
Imports DevExpress.Utils
Imports DevExpress.Utils.Menu
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Menu
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid

Public Class frmOFFTotal
    Private sID As String
    Private Ctrl As DevExpress.XtraGrid.Views.Grid.GridView
    Private Frm As DevExpress.XtraEditors.XtraForm
    Public Mode As Byte
    Private Log As New Transactions
    Private LoadForms As New FormLoader
    Private Cls As New ClearControls

    Friend Class MenuColumnInfo
        Public Sub New(ByVal column As GridColumn)
            Me.Column = column
        End Sub
        Public Column As GridColumn
    End Class
    Public WriteOnly Property ID As String
        Set(value As String)
            sID = value
        End Set
    End Property
    Public WriteOnly Property Scroller As DevExpress.XtraGrid.Views.Grid.GridView
        Set(value As DevExpress.XtraGrid.Views.Grid.GridView)
            Ctrl = value
        End Set
    End Property
    Public WriteOnly Property FormScroller As DevExpress.XtraEditors.XtraForm
        Set(value As DevExpress.XtraEditors.XtraForm)
            Frm = value
        End Set
    End Property
    Private Sub cmdExit_Click(sender As Object, e As EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub

    Private Sub frmOFFTotal_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        If Me.WindowState = FormWindowState.Maximized Then frmMain.XtraTabbedMdiManager1.Dock(Me, frmMain.XtraTabbedMdiManager1)
    End Sub

    Private Sub frmOFFTotal_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim sSQL As String
        Try
            sSQL = "INSERT INTO OFF_TOTAL (offID,subOffID, DoorTypeID, price, NewPrice,createdBy ,createdOn)
                    SELECT offID,subOffID,DoorTypeID,SUM(ISNULL(OfferPrice, 0)),SUM(ISNULL(OfferPrice, 0)) ," & toSQLValueS(UserProps.ID.ToString) & " ,getdate()
            FROM    dbo.vw_OFFERS S
                    WHERE offID = " & toSQLValueS(sID) & " and  NOT EXISTS (SELECT T.offid FROM   OFF_TOTAL  T WHERE  T.offid= " & toSQLValueS(sID) & " and t.DoorTypeID=s.DoorTypeID )
            GROUP BY DoorTypeName, offID, DoorTypeID, subOffID, SubOFFName                 "

            Using oCmd As New SqlCommand(sSQL, CNDB)
                oCmd.ExecuteNonQuery()
            End Using

        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), "Dreamy Kitchen CRM", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        sSQL = "Select CAST(dbo.[OFF].code AS nvarchar(10)) + ' - ' + CAST(S.code AS nvarchar(10)) AS SubOFFName, d.name,O.* 
               from OFF_TOTAL O 
               INNER  JOIN DOOR_TYPE D ON O.DoorTypeID = D.ID 
               INNER  JOIN OFF_SUBOFF S ON O.subOffID= S.ID 
               INNER  JOIN [OFF]  ON O.OffID= [OFF].ID 
               where O.offid =  " & toSQLValueS(sID)
        LoadForms.LoadDataToGrid(grdOffTotal, GridView3, sSQL)
        If My.Computer.FileSystem.FileExists(Application.StartupPath & "\DSGNS\DEF\OFFTOTAL.xml") Then GridView3.RestoreLayoutFromXml(Application.StartupPath & "\DSGNS\DEF\OFFTOTAL.xml", OptionsLayoutBase.FullLayout)
        GridView3.Columns("SubOFFName").OptionsColumn.ReadOnly = True
        GridView3.Columns("SubOFFName").OptionsColumn.AllowEdit = False
        GridView3.Columns("NewPrice").OptionsColumn.ReadOnly = False
        GridView3.Columns("NewPrice").OptionsColumn.AllowEdit = True
        GridView3.Columns("Price").OptionsColumn.AllowEdit = False
        GridView3.Columns("name").OptionsColumn.AllowEdit = False
        GridView3.OptionsBehavior.Editable = True
    End Sub


    'Αποθήκευση όψης Προσφορών
    Private Sub OnSaveViewOff(ByVal sender As System.Object, ByVal e As EventArgs)
        Dim item As DXMenuItem = TryCast(sender, DXMenuItem)
        GridView3.SaveLayoutToXml(Application.StartupPath & "\DSGNS\DEF\OFFTOTAL.xml", OptionsLayoutBase.FullLayout)
        XtraMessageBox.Show("Η όψη αποθηκεύτηκε με επιτυχία", "Dreamy Kitchen CRM", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
    'Μετονομασία Στήλης Master
    Private Sub OnEditValueChangedOff(ByVal sender As System.Object, ByVal e As EventArgs)
        Dim item As New DXEditMenuItem()
        item = sender
        If item.Tag Is Nothing Then Exit Sub
        GridView3.Columns(item.Tag).Caption = item.EditValue
        'MessageBox.Show(item.EditValue.ToString())
    End Sub
    'Αλλαγή Χρώματος Στήλης Master
    Private Sub OnColumnsColorChangedOff(ByVal sender As System.Object, ByVal e As EventArgs)
        Dim item As DXEditMenuItem = TryCast(sender, DXEditMenuItem)
        item = sender
        If item.Tag Is Nothing Then Exit Sub
        GridView3.Columns(item.Tag).AppearanceCell.BackColor = item.EditValue
    End Sub
    Private Function CreateCheckItem(ByVal caption As String, ByVal column As GridColumn, ByVal image As Image) As DXMenuCheckItem
        Dim item As New DXMenuCheckItem(caption, (Not column.OptionsColumn.AllowMove), image, New EventHandler(AddressOf OnCanMoveItemClick))
        item.Tag = New MenuColumnInfo(column)
        Return item
    End Function
    'Αλλαγή Χρώματος Στήλης Master
    Private Sub OnColumnsColorChanged(ByVal sender As System.Object, ByVal e As EventArgs)
        Dim item As DXEditMenuItem = TryCast(sender, DXEditMenuItem)
        item = sender
        If item.Tag Is Nothing Then Exit Sub
        GridView3.Columns(item.Tag).AppearanceCell.BackColor = item.EditValue
    End Sub
    'Κλείδωμα Στήλης Master
    Private Sub OnCanMoveItemClick(ByVal sender As Object, ByVal e As EventArgs)
        Dim item As DXMenuCheckItem = TryCast(sender, DXMenuCheckItem)
        Dim info As MenuColumnInfo = TryCast(item.Tag, MenuColumnInfo)
        If info Is Nothing Then
            Return
        End If
        info.Column.OptionsColumn.AllowMove = Not item.Checked
    End Sub


    Private Sub GridView3_PopupMenuShowing(sender As Object, e As PopupMenuShowingEventArgs) Handles GridView3.PopupMenuShowing
        If e.MenuType = GridMenuType.Column Then
            Dim menu As DevExpress.XtraGrid.Menu.GridViewColumnMenu = TryCast(e.Menu, GridViewColumnMenu)
            Dim item As New DXEditMenuItem()
            Dim itemColor As New DXEditMenuItem()

            'menu.Items.Clear()
            If menu.Column IsNot Nothing Then
                'Για να προσθέσουμε menu item στο Default menu πρέπει πρώτα να προσθέσουμε ένα Repository Item 
                'Υπάρχουν πολλών ειδών Repositorys
                '1st Custom Menu Item
                Dim popRenameColumn As New RepositoryItemTextEdit
                popRenameColumn.Name = "RenameColumn"
                menu.Items.Add(New DXEditMenuItem("Μετονομασία Στήλης", popRenameColumn, AddressOf OnEditValueChangedOff, Nothing, Nothing, 100, 0))
                item = menu.Items.Item("Μετονομασία Στήλης")
                item.EditValue = menu.Column.GetTextCaption
                item.Tag = menu.Column.AbsoluteIndex

                '2nd Custom Menu Item
                menu.Items.Add(CreateCheckItem("Κλείδωμα Στήλης", menu.Column, Nothing))

                '3rd Custom Menu Item
                Dim popColorsColumn As New RepositoryItemColorEdit
                popColorsColumn.Name = "ColorsColumn"
                menu.Items.Add(New DXEditMenuItem("Χρώμα Στήλης", popColorsColumn, AddressOf OnColumnsColorChangedOff, Nothing, Nothing, 100, 0))
                itemColor = menu.Items.Item("Χρώμα Στήλης")
                itemColor.EditValue = menu.Column.AppearanceCell.BackColor
                itemColor.Tag = menu.Column.AbsoluteIndex

                '4nd Custom Menu Item
                menu.Items.Add(New DXMenuItem("Αποθήκευση όψης", AddressOf OnSaveViewOff, Nothing, Nothing, Nothing, Nothing))

            End If
        End If
    End Sub

    Private Sub GridView3_RowUpdated(sender As Object, e As RowObjectEventArgs) Handles GridView3.RowUpdated
        Try
            Dim sSQL As String
            sSQL = "UPDATE [OFF_TOTAL] SET NewPrice = " & toSQLValueS(GridView3.GetRowCellValue(GridView3.FocusedRowHandle, "NewPrice"), True) & " WHERE ID = " & toSQLValueS(GridView3.GetRowCellValue(GridView3.FocusedRowHandle, "ID").ToString)
            Using oCmd As New SqlCommand(sSQL, CNDB)
                oCmd.ExecuteNonQuery()
            End Using

        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), "Dreamy Kitchen CRM", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class