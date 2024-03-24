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

                    If OrderExistInTransH("CCT_ORDERS_KITCHEN") = True Then Return False
                    If isOrder = True Then If AgreementExist() = True Then Return False




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
                    If OrderExistInTransH("CCT_ORDERS_DOOR") = True Then Return False
                    If isOrder = True Then If AgreementExist() = True Then Return False



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
                    If f.chkGenOffer.CheckState = CheckState.Checked And f.cboCompany.EditValue Is Nothing Then
                        XtraMessageBox.Show("Έχετε επιλέξει Γενική Προσφορά εταιρίας χωρίς να επιλέξετε εταιρία", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Return False
                    End If
                    If f.cboCompany.EditValue IsNot Nothing And f.cboCompProject.EditValue = Nothing Then
                        XtraMessageBox.Show("Δεν έχετε συμπληρώσει έργο εταιρίας", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Return False
                    End If
                    If OrderExistInTransH("CCT_ORDERS_CLOSET") = True Then Return False
                    If isOrder = True Then If AgreementExist() = True Then Return False



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
                    If OrderExistInTransH("CCT_ORDERS_SPECIAL_CONSTR") = True Then Return False
                    If isOrder = True Then If AgreementExist() = True Then Return False



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
    Private Function AgreementExist() As Boolean
        Dim sSQL As String
        Dim Cmd As SqlCommand
        Dim ExistAgreement As Integer
        Dim sdr As SqlDataReader
        Try
            sSQL = "SELECT count(ID) as ExistAgreement FROM [AGREEMENT] WHERE transhID = " & toSQLValueS(sID)
            Cmd = New SqlCommand(sSQL, CNDB)
            sdr = Cmd.ExecuteReader()
            If (sdr.Read() = True) Then
                If sdr.IsDBNull(sdr.GetOrdinal("ExistAgreement")) = False Then ExistAgreement = sdr.GetInt32(sdr.GetOrdinal("ExistAgreement")) Else ExistAgreement = 0
                If ExistAgreement = 1 Then
                    XtraMessageBox.Show("Δεν μπορείτε να αλλάξετε την παραγγελία όταν έχει δημιουργηθεί συμφωνητικό. ", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
                    sdr.Close()
                    Return True
                End If
            End If
            Return False
        Catch ex As Exception
            sdr.Close()
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return True
        End Try
    End Function
    Private Function OrderExistInTransH(ByVal sTable As String) As Boolean
        Dim sSQL As String
        Dim Cmd As SqlCommand
        Dim ExistOrder As Integer
        Dim sdr As SqlDataReader
        Try
            sSQL = "SELECT count(ID) as ExistOrder FROM " & sTable & " WHERE isOrder = 1 and transhID = " & toSQLValueS(sID)
            Cmd = New SqlCommand(sSQL, CNDB)
            sdr = Cmd.ExecuteReader()
            If (sdr.Read() = True) Then
                If sdr.IsDBNull(sdr.GetOrdinal("ExistOrder")) = False Then ExistOrder = sdr.GetInt32(sdr.GetOrdinal("ExistOrder")) Else ExistOrder = 0
                If ExistOrder > 1 Then
                    XtraMessageBox.Show("Δεν μπορείτε να δημιουργήσετε παραπάνω από μια παραγγελίες στο ίδιο έργο. ", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
                    sdr.Close()
                    Return True
                End If
            End If
            Return False
        Catch ex As Exception
            sdr.Close()
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return True
        End Try
    End Function
    Public Sub AddControlsForCheckIfSomethingChanged(ByVal control As DevExpress.XtraLayout.LayoutControl, Optional ByVal IgnoreVisibility As Boolean = False)
        Dim TagValue As String()
        Dim IsFirstField As Boolean = True
        For Each item As DevExpress.XtraLayout.BaseLayoutItem In control.Items
            If TypeOf item Is DevExpress.XtraLayout.LayoutControlItem Then
                Dim LItem As DevExpress.XtraLayout.LayoutControlItem = CType(item, DevExpress.XtraLayout.LayoutControlItem)
                If LItem.ControlName <> Nothing Then
                    'Γίνεται διαχείριση όταν υπάρχει RadioGroup με optionButtons
                    If TypeOf LItem.Control Is DevExpress.XtraEditors.RadioGroup Then
                        Dim RDG As DevExpress.XtraEditors.RadioGroup
                        RDG = LItem.Control
                    End If
                    ' Εαν δεν έχω ορίσει tag στο Control δεν θα συμπεριληφθεί στο INSERT-UPDATE
                    If LItem.Control.Tag <> "" Then
                        'Βάζω τις τιμές του TAG σε array
                        TagValue = LItem.Control.Tag.ToString.Split(",")
                        'Ψάχνω αν το πεδίο έχει δικάιωμα καταχώρησης
                        Dim value As String = Array.Find(TagValue, Function(x) (x.StartsWith("1")))
                        ' Εαν δεν είναι visible το Control δεν θα συμπεριληφθεί στο INSERT-UPDATE
                        If IgnoreVisibility = True Then
                            If LItem.Control.Visible = False Then GoTo NextItem
                        End If

                        ' Εαν δεν είναι visible το Control δεν θα συμπεριληφθεί στο INSERT-UPDATE
                        'If LItem.Control.Visible = True Then
                        ' Παίρνω τον τύπο του Control ώστε να δώ με ποιον τρόπ θα πάρω το value.
                        ' Αλλιώς το παίρνουμε όταν είναι text και αλλιώς όταν είναι LookupEdit
                        Dim Ctrl As Control = LItem.Control
                        If TypeOf Ctrl Is DevExpress.XtraEditors.LookUpEdit Then
                            Dim cbo As DevExpress.XtraEditors.LookUpEdit
                            cbo = Ctrl
                            AddHandler CType(cbo, DevExpress.XtraEditors.LookUpEdit).EditValueChanged, AddressOf SomethingChanged
                        ElseIf TypeOf Ctrl Is DevExpress.XtraEditors.DateEdit Then
                            Dim dt As DevExpress.XtraEditors.DateEdit
                            dt = Ctrl
                            AddHandler CType(dt, DevExpress.XtraEditors.DateEdit).EditValueChanged, AddressOf SomethingChanged
                        ElseIf TypeOf Ctrl Is DevExpress.XtraEditors.SpinEdit Then
                            Dim spn As DevExpress.XtraEditors.SpinEdit
                            spn = Ctrl
                            AddHandler CType(spn, DevExpress.XtraEditors.SpinEdit).EditValueChanged, AddressOf SomethingChanged
                        ElseIf TypeOf Ctrl Is DevExpress.XtraEditors.MemoEdit Then
                            Dim txt As DevExpress.XtraEditors.MemoEdit
                            txt = Ctrl
                            AddHandler CType(txt, DevExpress.XtraEditors.MemoEdit).EditValueChanged, AddressOf SomethingChanged
                        ElseIf TypeOf Ctrl Is DevExpress.XtraEditors.TextEdit Then
                            Dim txt As DevExpress.XtraEditors.TextEdit
                            txt = Ctrl
                            AddHandler CType(txt, DevExpress.XtraEditors.TextEdit).EditValueChanged, AddressOf SomethingChanged
                            '*******DevExpress.XtraEditors.ButtonEdit******
                        ElseIf TypeOf Ctrl Is DevExpress.XtraEditors.ButtonEdit Then
                            Dim txt As DevExpress.XtraEditors.ButtonEdit
                            txt = Ctrl
                            AddHandler CType(txt, DevExpress.XtraEditors.ButtonEdit).EditValueChanged, AddressOf SomethingChanged
                        ElseIf TypeOf Ctrl Is DevExpress.XtraEditors.CheckEdit Then
                            Dim chk As DevExpress.XtraEditors.CheckEdit
                            chk = Ctrl
                            AddHandler CType(chk, DevExpress.XtraEditors.CheckEdit).EditValueChanged, AddressOf SomethingChanged
                        End If
                        IsFirstField = False
NextItem:
                    End If
                End If
            End If
        Next
    End Sub
    Public Sub RemoveControlsForCheckIfSomethingChanged(ByVal control As DevExpress.XtraLayout.LayoutControl, Optional ByVal IgnoreVisibility As Boolean = False)
        Dim TagValue As String()
        Dim IsFirstField As Boolean = True
        For Each item As DevExpress.XtraLayout.BaseLayoutItem In control.Items
            If TypeOf item Is DevExpress.XtraLayout.LayoutControlItem Then
                Dim LItem As DevExpress.XtraLayout.LayoutControlItem = CType(item, DevExpress.XtraLayout.LayoutControlItem)
                If LItem.ControlName <> Nothing Then
                    'Γίνεται διαχείριση όταν υπάρχει RadioGroup με optionButtons
                    If TypeOf LItem.Control Is DevExpress.XtraEditors.RadioGroup Then
                        Dim RDG As DevExpress.XtraEditors.RadioGroup
                        RDG = LItem.Control
                    End If
                    ' Εαν δεν έχω ορίσει tag στο Control δεν θα συμπεριληφθεί στο INSERT-UPDATE
                    If LItem.Control.Tag <> "" Then
                        'Βάζω τις τιμές του TAG σε array
                        TagValue = LItem.Control.Tag.ToString.Split(",")
                        'Ψάχνω αν το πεδίο έχει δικάιωμα καταχώρησης
                        Dim value As String = Array.Find(TagValue, Function(x) (x.StartsWith("1")))
                        ' Εαν δεν είναι visible το Control δεν θα συμπεριληφθεί στο INSERT-UPDATE
                        If IgnoreVisibility = True Then
                            If LItem.Control.Visible = False Then GoTo NextItem
                        End If

                        ' Εαν δεν είναι visible το Control δεν θα συμπεριληφθεί στο INSERT-UPDATE
                        'If LItem.Control.Visible = True Then
                        ' Παίρνω τον τύπο του Control ώστε να δώ με ποιον τρόπ θα πάρω το value.
                        ' Αλλιώς το παίρνουμε όταν είναι text και αλλιώς όταν είναι LookupEdit
                        Dim Ctrl As Control = LItem.Control
                        If TypeOf Ctrl Is DevExpress.XtraEditors.LookUpEdit Then
                            Dim cbo As DevExpress.XtraEditors.LookUpEdit
                            cbo = Ctrl
                            AddHandler CType(cbo, DevExpress.XtraEditors.LookUpEdit).EditValueChanged, AddressOf SomethingChanged
                        ElseIf TypeOf Ctrl Is DevExpress.XtraEditors.DateEdit Then
                            Dim dt As DevExpress.XtraEditors.DateEdit
                            dt = Ctrl
                            RemoveHandler CType(dt, DevExpress.XtraEditors.DateEdit).EditValueChanged, AddressOf SomethingChanged
                        ElseIf TypeOf Ctrl Is DevExpress.XtraEditors.SpinEdit Then
                            Dim spn As DevExpress.XtraEditors.SpinEdit
                            spn = Ctrl
                            RemoveHandler CType(spn, DevExpress.XtraEditors.SpinEdit).EditValueChanged, AddressOf SomethingChanged
                        ElseIf TypeOf Ctrl Is DevExpress.XtraEditors.MemoEdit Then
                            Dim txt As DevExpress.XtraEditors.MemoEdit
                            txt = Ctrl
                            RemoveHandler CType(txt, DevExpress.XtraEditors.MemoEdit).EditValueChanged, AddressOf SomethingChanged
                        ElseIf TypeOf Ctrl Is DevExpress.XtraEditors.TextEdit Then
                            Dim txt As DevExpress.XtraEditors.TextEdit
                            txt = Ctrl
                            RemoveHandler CType(txt, DevExpress.XtraEditors.TextEdit).EditValueChanged, AddressOf SomethingChanged
                            '*******DevExpress.XtraEditors.ButtonEdit******
                        ElseIf TypeOf Ctrl Is DevExpress.XtraEditors.ButtonEdit Then
                            Dim txt As DevExpress.XtraEditors.ButtonEdit
                            txt = Ctrl
                            RemoveHandler CType(txt, DevExpress.XtraEditors.ButtonEdit).EditValueChanged, AddressOf SomethingChanged
                        ElseIf TypeOf Ctrl Is DevExpress.XtraEditors.CheckEdit Then
                            Dim chk As DevExpress.XtraEditors.CheckEdit
                            chk = Ctrl
                            RemoveHandler CType(chk, DevExpress.XtraEditors.CheckEdit).EditValueChanged, AddressOf SomethingChanged
                        ElseIf TypeOf Ctrl Is DevExpress.XtraEditors.CheckedListBoxControl Then
                            Dim chk As DevExpress.XtraEditors.CheckedListBoxControl
                            chk = Ctrl
                            RemoveHandler CType(chk, DevExpress.XtraEditors.CheckedListBoxControl).SelectedIndexChanged, AddressOf SomethingChanged
                        End If
                        IsFirstField = False
NextItem:
                    End If
                End If
            End If
        Next
    End Sub
    Private Sub SomethingChanged(sender As Object, e As EventArgs)
        SChanged = True
    End Sub
End Class
