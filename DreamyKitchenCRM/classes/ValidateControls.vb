Imports System.Data.SqlClient
Imports DevExpress.XtraEditors
Imports DevExpress.XtraLayout

Public Class ValidateControls
    Public SChanged As Boolean
    Private sID As String
    Private scompTrashID As String
    Public WriteOnly Property ID As String
        Set(value As String)
            sID = value
        End Set
    End Property
    Public WriteOnly Property compTrashID As String
        Set(value As String)
            scompTrashID = value
        End Set
    End Property

    Public Function ValidateForm(ByVal control As DevExpress.XtraLayout.LayoutControl) As Boolean
        For Each item As BaseLayoutItem In control.Items
            If TypeOf item Is LayoutControlItem Then
                Dim LItem As LayoutControlItem = CType(item, LayoutControlItem)
                If LItem.Tag = "1" Then
                    If LItem.Control.Visible = True Then
                        Dim Ctrl As Control = LItem.Control
                        If TypeOf Ctrl Is DevExpress.XtraEditors.TextEdit Then
                            Dim txt As DevExpress.XtraEditors.TextEdit
                            txt = Ctrl
                            If txt.Properties.Mask.EditMask = "c" & ProgProps.Decimals Or txt.Properties.Mask.MaskType = Mask.MaskType.Numeric Or txt.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric Then
                                If LItem.Control.Text.Replace(" €", "") = "0,00" Or LItem.Control.Text.Replace(" €", "") = "0" Or LItem.Control.Text.Replace(" €", "") = "0,000" Then
                                    XtraMessageBox.Show("Υπάρχουν υποχρεωτικά πεδία που δεν έχετε συμπληρώσει.", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
                                    Return False
                                End If
                            End If
                        End If
                        If LItem.Control.Text = "" Then
                            XtraMessageBox.Show("Υπάρχουν υποχρεωτικά πεδία που δεν έχετε συμπληρώσει.", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
                            Return False
                        End If

                        If TypeOf Ctrl Is DevExpress.XtraEditors.CheckedListBoxControl Then
                            Dim chklst As DevExpress.XtraEditors.CheckedListBoxControl
                            chklst = Ctrl
                            If chklst.CheckedItems.Count = 0 Then
                                XtraMessageBox.Show("Υπάρχουν υποχρεωτικά πεδία που δεν έχετε συμπληρώσει.", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
                                Return False
                            End If
                        End If

                    End If
                End If
            End If
        Next
        Return True
    End Function
    Public Function ValidateFormGRP(ByVal GRP As DevExpress.XtraLayout.LayoutControlGroup) As Boolean
        For Each item As BaseLayoutItem In GRP.Items
            If TypeOf item Is LayoutControlItem Then
                Dim LItem As LayoutControlItem = CType(item, LayoutControlItem)
                If LItem.Tag = "1" Then
                    If LItem.Control.Visible = True Then
                        Dim Ctrl As Control = LItem.Control
                        If TypeOf Ctrl Is DevExpress.XtraEditors.TextEdit Then
                            Dim txt As DevExpress.XtraEditors.TextEdit
                            txt = Ctrl
                            If txt.Properties.Mask.EditMask = "c" & ProgProps.Decimals Or txt.Properties.Mask.MaskType = Mask.MaskType.Numeric Or txt.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric Then
                                If LItem.Control.Text.Replace(" €", "") = "0,00" Or LItem.Control.Text.Replace(" €", "") = "0" Or LItem.Control.Text.Replace(" €", "") = "0,000" Then
                                    XtraMessageBox.Show("Υπάρχουν υποχρεωτικά πεδία που δεν έχετε συμπληρώσει.", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
                                    Return False
                                End If
                            End If
                        End If
                        If LItem.Control.Text = "" Then
                            XtraMessageBox.Show("Υπάρχουν υποχρεωτικά πεδία που δεν έχετε συμπληρώσει.", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
                            Return False
                        End If
                    End If
                End If
            End If
        Next
        Return True
    End Function
    Public Function ValiDationRules(ByVal FrmName As String, ByVal frm As Form, Optional ByVal ExtraChecks As Boolean = False, Optional ByVal isOrder As Boolean = False) As Boolean
        Try

            Select Case FrmName
                Case "frmCUSOfferOrderKitchen"
                    Dim f As frmCUSOfferOrderKitchen = frm
                    ' 1st Rule
                    If f.chkGenOffer.CheckState = CheckState.Checked And f.cboCompany.EditValue Is Nothing Then
                        XtraMessageBox.Show("Έχετε επιλέξει Γενική Προσφορά εταιρίας χωρίς να επιλέξετε εταιρία", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Return False
                    End If
                    If f.cboCompany.EditValue IsNot Nothing And f.cboCompProject.EditValue = Nothing Then
                        XtraMessageBox.Show("Δεν έχετε συμπληρώσει έργο εταιρίας", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Return False
                    End If
                    If (f.txtCUSOfferOrderFilename.EditValue IsNot Nothing And (f.cboSup.EditValue = Nothing Or f.txtbenchSalesPrice.EditValue = 0)) Then
                        XtraMessageBox.Show("Έχετε επισυνάψει έντυπο προσφορας πάγκου και δεν έχετε επιλέξει προμηθευτή ή Τιμή.Λ", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Return False
                    End If
                    If isOrder = False And f.chkModel1.CheckState = CheckState.Unchecked And f.chkModel2.CheckState = CheckState.Unchecked And f.chkModel3.CheckState = CheckState.Unchecked And
                       f.chkModel4.CheckState = CheckState.Unchecked Then
                        XtraMessageBox.Show("Δεν έχετε επιλέξει με ποιο μοντέλο θα προχωρήσετε", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Return False
                    End If
                    Dim FinalPrice As Double
                    Dim TotAmt As Double = GetAmt(f.txtTotAmt)
                    If isOrder = False Then
                        If f.chkModel1.CheckState = CheckState.Checked Then FinalPrice = GetAmt(f.txtFinalPrice1)
                        If f.chkModel2.CheckState = CheckState.Checked Then FinalPrice = GetAmt(f.txtFinalPrice2)
                        If f.chkModel3.CheckState = CheckState.Checked Then FinalPrice = GetAmt(f.txtFinalPrice3)
                        If f.chkModel4.CheckState = CheckState.Checked Then FinalPrice = GetAmt(f.txtFinalPrice4)
                    Else
                        FinalPrice = GetAmt(f.txtTotalErmariaVat)
                    End If
                    If FinalPrice <> TotAmt Then
                        XtraMessageBox.Show("Το ποσό πώλησης έργου είναι διαφορετικό από το σύνολο της " & IIf(isOrder=False," προσφοράς"," παραγγελίας"), ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Return False
                    End If
                    If isOrder = True Then
                        Dim sSQL As String
                        Dim Cmd As SqlCommand
                        Dim ExistAgreement As Integer
                        sSQL = "SELECT count(ID) as ExistAgreement FROM [AGREEMENT] WHERE transhID = " & toSQLValueS(sID)
                        Cmd = New SqlCommand(sSQL, CNDB)
                        Dim sdr As SqlDataReader = Cmd.ExecuteReader()
                        If (sdr.Read() = True) Then
                            If sdr.IsDBNull(sdr.GetOrdinal("ExistAgreement")) = False Then ExistAgreement = sdr.GetInt32(sdr.GetOrdinal("ExistAgreement")) Else ExistAgreement = 0
                            If ExistAgreement = 1 Then
                                XtraMessageBox.Show("Δεν μπορείτε να αλλάξετε την παραγγελία όταν έχει δημιουργηθεί συμφωνητικό. ", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
                                Return False
                            End If
                        End If
                    End If


                    If ExtraChecks = True Then
                        Dim sSQL As String
                        Dim Cmd As SqlCommand
                        Dim CountClosed As Integer


                        ' Αν αφορά εταιρία η εγγραφή κλεισίματος ελέγχεται αν υπάρχει πάνω στην εταιρία
                        If f.chkGenOffer.CheckState = CheckState.Checked Then
                            sSQL = "SELECT count(ID) as CountClosed FROM [TRANSD] WHERE isCredit = 1 and PayTypeID = '90A295A1-D2A0-40B7-B260-A532B2C322AC' and transhID = " & toSQLValueS(scompTrashID)
                        Else
                            sSQL = "SELECT count(ID) as CountClosed FROM [TRANSD] WHERE isCredit = 1 and PayTypeID = '90A295A1-D2A0-40B7-B260-A532B2C322AC' and transhID = " & toSQLValueS(sID)
                        End If

                        Cmd = New SqlCommand(sSQL, CNDB)
                        Dim sdr As SqlDataReader = Cmd.ExecuteReader()
                        If (sdr.Read() = True) Then
                            If sdr.IsDBNull(sdr.GetOrdinal("CountClosed")) = False Then CountClosed = sdr.GetInt32(sdr.GetOrdinal("CountClosed")) Else CountClosed = 0
                            If CountClosed = 0 Then
                                XtraMessageBox.Show("Δεν μπορείτε να μετατρέψετε την προσφορά σε παραγγελία χωρίς εγγραφή Κλεισίματος. ", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
                                Return False
                            End If
                        End If
                    End If
                    Return True
                Case "frmCUSOfferOrderDoors"
                    Dim f As frmCUSOfferOrderDoors = frm
                    ' 1st Rule
                    If f.cboCompany.EditValue IsNot Nothing And f.cboCompProject.EditValue = Nothing Then
                        XtraMessageBox.Show("Δεν έχετε συμπληρώσει έργο εταιρίας", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Return False
                    End If
                    If f.cboCompany.EditValue IsNot Nothing And f.cboCUS.EditValue IsNot Nothing Then
                        If f.cboCUS.EditValue.ToString.ToUpper = f.cboCompany.EditValue.ToString.ToUpper Then
                            XtraMessageBox.Show("Παραγγελίες γίνονται μόνο σε πελάτες", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
                            Return False
                        End If
                    End If


                    If ExtraChecks = True Then
                        Dim sSQL As String
                        Dim Cmd As SqlCommand
                        Dim CountClosed As Integer


                        ' Αν αφορά εταιρία η εγγραφή κλεισίματος ελέγχεται αν υπάρχει πάνω στην εταιρία
                        If f.cboCompany.EditValue IsNot Nothing Then
                            sSQL = "SELECT count(ID) as CountClosed FROM [TRANSD] WHERE isCredit = 1 and PayTypeID = '90A295A1-D2A0-40B7-B260-A532B2C322AC' and transhID = " & toSQLValueS(scompTrashID)
                        Else
                            sSQL = "SELECT count(ID) as CountClosed FROM [TRANSD] WHERE isCredit = 1 and PayTypeID = '90A295A1-D2A0-40B7-B260-A532B2C322AC' and transhID = " & toSQLValueS(sID)
                        End If

                        Cmd = New SqlCommand(sSQL, CNDB)
                        Dim sdr As SqlDataReader = Cmd.ExecuteReader()
                        If (sdr.Read() = True) Then
                            If sdr.IsDBNull(sdr.GetOrdinal("CountClosed")) = False Then CountClosed = sdr.GetInt32(sdr.GetOrdinal("CountClosed")) Else CountClosed = 0
                            If CountClosed = 0 Then
                                XtraMessageBox.Show("Δεν μπορείτε να μετατρέψετε την προσφορά σε παραγγελία χωρίς εγγραφή Κλεισίματος. ", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
                                Return False
                            End If
                        End If
                    End If
                    Return True
                Case "frmCUSOfferOrderCloset"
                    Dim f As frmCUSOfferOrderCloset = frm
                    ' 1st Rule
                    If f.cboCompany.EditValue IsNot Nothing And f.cboCompProject.EditValue = Nothing Then
                        XtraMessageBox.Show("Δεν έχετε συμπληρώσει έργο εταιρίας", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Return False
                    End If
                    If f.cboCompany.EditValue IsNot Nothing And f.cboCUS.EditValue IsNot Nothing Then
                        If f.cboCUS.EditValue.ToString.ToUpper = f.cboCompany.EditValue.ToString.ToUpper Then
                            XtraMessageBox.Show("Παραγγελίες γίνονται μόνο σε πελάτες", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
                            Return False
                        End If
                    End If


                    If ExtraChecks = True Then
                        Dim sSQL As String
                        Dim Cmd As SqlCommand
                        Dim CountClosed As Integer


                        ' Αν αφορά εταιρία η εγγραφή κλεισίματος ελέγχεται αν υπάρχει πάνω στην εταιρία
                        If f.cboCompany.EditValue IsNot Nothing Then
                            sSQL = "SELECT count(ID) as CountClosed FROM [TRANSD] WHERE isCredit = 1 and PayTypeID = '90A295A1-D2A0-40B7-B260-A532B2C322AC' and transhID = " & toSQLValueS(scompTrashID)
                        Else
                            sSQL = "SELECT count(ID) as CountClosed FROM [TRANSD] WHERE isCredit = 1 and PayTypeID = '90A295A1-D2A0-40B7-B260-A532B2C322AC' and transhID = " & toSQLValueS(sID)
                        End If

                        Cmd = New SqlCommand(sSQL, CNDB)
                        Dim sdr As SqlDataReader = Cmd.ExecuteReader()
                        If (sdr.Read() = True) Then
                            If sdr.IsDBNull(sdr.GetOrdinal("CountClosed")) = False Then CountClosed = sdr.GetInt32(sdr.GetOrdinal("CountClosed")) Else CountClosed = 0
                            If CountClosed = 0 Then
                                XtraMessageBox.Show("Δεν μπορείτε να μετατρέψετε την προσφορά σε παραγγελία χωρίς εγγραφή Κλεισίματος. ", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
                                Return False
                            End If
                        End If
                    End If
                    Return True
                Case "frmCUSOfferOrderSpecialConstr"
                    Dim f As frmCUSOfferOrderSpecialConstr = frm
                    ' 1st Rule
                    If f.cboCompany.EditValue IsNot Nothing And f.cboCompProject.EditValue = Nothing Then
                        XtraMessageBox.Show("Δεν έχετε συμπληρώσει έργο εταιρίας", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Return False
                    End If
                    If f.cboCompany.EditValue IsNot Nothing And f.cboCUS.EditValue IsNot Nothing Then
                        If f.cboCUS.EditValue.ToString.ToUpper = f.cboCompany.EditValue.ToString.ToUpper Then
                            XtraMessageBox.Show("Παραγγελίες γίνονται μόνο σε πελάτες", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
                            Return False
                        End If
                    End If


                    If ExtraChecks = True Then
                        Dim sSQL As String
                        Dim Cmd As SqlCommand
                        Dim CountClosed As Integer


                        ' Αν αφορά εταιρία η εγγραφή κλεισίματος ελέγχεται αν υπάρχει πάνω στην εταιρία
                        If f.cboCompany.EditValue IsNot Nothing Then
                            sSQL = "SELECT count(ID) as CountClosed FROM [TRANSD] WHERE isCredit = 1 and PayTypeID = '90A295A1-D2A0-40B7-B260-A532B2C322AC' and transhID = " & toSQLValueS(scompTrashID)
                        Else
                            sSQL = "SELECT count(ID) as CountClosed FROM [TRANSD] WHERE isCredit = 1 and PayTypeID = '90A295A1-D2A0-40B7-B260-A532B2C322AC' and transhID = " & toSQLValueS(sID)
                        End If

                        Cmd = New SqlCommand(sSQL, CNDB)
                        Dim sdr As SqlDataReader = Cmd.ExecuteReader()
                        If (sdr.Read() = True) Then
                            If sdr.IsDBNull(sdr.GetOrdinal("CountClosed")) = False Then CountClosed = sdr.GetInt32(sdr.GetOrdinal("CountClosed")) Else CountClosed = 0
                            If CountClosed = 0 Then
                                XtraMessageBox.Show("Δεν μπορείτε να μετατρέψετε την προσφορά σε παραγγελία χωρίς εγγραφή Κλεισίματος. ", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
                                Return False
                            End If
                        End If
                    End If
                    Return True

            End Select
        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try


    End Function
End Class
