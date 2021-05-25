Imports System.Data.SqlClient
Imports DevExpress.XtraEditors

Public Class frmCloneOffer
    Private sID As String
    Private sOfferCode As Integer
    Private DBQ As New DBQueries
    Private SubOffCode As Integer
    Private sOffers As New List(Of String)
    Private Frm As DevExpress.XtraEditors.XtraForm
    Public WriteOnly Property ID As String
        Set(value As String)
            sID = value
        End Set
    End Property
    Public WriteOnly Property OfferCode As Integer
        Set(value As Integer)
            sOfferCode = value
        End Set
    End Property
    Public ReadOnly Property GetSubOffers() As List(Of String)
        Get
            Return sOffers
        End Get
    End Property
    Public WriteOnly Property SetSubOffers() As List(Of String)
        Set(value As List(Of String))
            sOffers = value
        End Set
    End Property
    Public WriteOnly Property FormScroller As DevExpress.XtraEditors.XtraForm
        Set(value As DevExpress.XtraEditors.XtraForm)
            Frm = value
        End Set
    End Property

    Private Sub frmCloneOffer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DreamyKitchenDataSet.vw_DOOR_TYPE1' table. You can move, or remove it, as needed.
        txtCode.EditValue = sOfferCode
        'TODO: This line of code loads data into the 'DreamyKitchenDataSet.vw_DOOR_TYPE' table. You can move, or remove it, as needed.
        Me.Vw_DOOR_TYPETableAdapter.Fill(Me.DreamyKitchenDataSet.vw_DOOR_TYPE)
        Me.Vw_OFF_SUBOFFTableAdapter.Fill(Me.DreamyKitchenDataSet.vw_OFF_SUBOFF, System.Guid.Parse(sID))

    End Sub

    Private Sub cboSubOffName_EditValueChanged(sender As Object, e As EventArgs) Handles cboSubOffName.EditValueChanged
        Me.Vw_OFFER_DOORTYPES.Fill(Me.DreamyKitchenDataSet.vw_OFFER_DOORTYPES, System.Guid.Parse(sID), System.Guid.Parse(cboSubOffName.EditValue.ToString))
    End Sub

    Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click
        Dim sSQL As String, SubOffID As String
        Dim sCurrentDoor As String
        Dim sSelectedDoor As String
        Try

            If XtraMessageBox.Show("Θέλετε να δημιουργήσω προσφορά για τα επιλεγμένα πορτάκια?", "Dreamy Kitchen CRM", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                If SubOffCode = 0 Then
                    ' Καταχώρηση υποπροσφοράς
                    SubOffID = System.Guid.NewGuid.ToString
                    SubOffCode = DBQ.GetNextCODE("OFF_SUBOFF", "where offid= " & toSQLValueS(sID))
                    sSQL = "INSERT INTO OFF_SUBOFF (ID,offID, code,createdBy ,createdOn) SELECT " & toSQLValueS(SubOffID) & "," & toSQLValueS(sID) & "," & toSQLValueS(SubOffCode.ToString, True) & "," & toSQLValueS(UserProps.ID.ToString) & ",GETDATE()"
                    Using oCmd As New SqlCommand(sSQL, CNDB)
                        oCmd.ExecuteNonQuery()
                    End Using
                    If sOffers Is Nothing Then sOffers = New List(Of String)
                    sOffers.Add(SubOffID)
                End If
                For i As Integer = 0 To GridView1.DataRowCount - 1
                    sCurrentDoor = GridView1.GetRowCellValue(i, "DoorTypeID").ToString
                    sSelectedDoor = GridView1.GetRowCellValue(i, "DoorTypeID2").ToString

                    Using oCmd As New SqlCommand("CloneOffers", CNDB)
                        oCmd.CommandType = CommandType.StoredProcedure
                        oCmd.Parameters.AddWithValue("@OffID", sID)
                        oCmd.Parameters.AddWithValue("@DoorTypeID", sSelectedDoor)
                        oCmd.Parameters.AddWithValue("@BasedOnDoorTypeID", sCurrentDoor)
                        oCmd.Parameters.AddWithValue("@CurrsubOFFID", cboSubOffName.EditValue)
                        oCmd.Parameters.AddWithValue("@NewsubOFFID ", SubOffID)
                        oCmd.Parameters.AddWithValue("@modifiedBy", UserProps.ID.ToString)
                        oCmd.ExecuteNonQuery()
                    End Using
                Next
                SubOffCode = 0


            End If
        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), "Dreamy Kitchen CRM", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cmdExit_Click(sender As Object, e As EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub

    Private Sub FillByToolStripButton_Click(sender As Object, e As EventArgs)
        Try
            Me.Vw_DOOR_TYPETableAdapter.FillBy(Me.DreamyKitchenDataSet.vw_DOOR_TYPE)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub
End Class