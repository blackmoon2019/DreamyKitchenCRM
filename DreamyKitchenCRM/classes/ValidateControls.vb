Imports System.Data.SqlClient
Imports DevExpress.XtraEditors
Imports DevExpress.XtraLayout

Public Class ValidateControls
    Public SChanged As Boolean
    Private sID As String
    Private scompTrashID As String
    Private sTrashID As String
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
    Public WriteOnly Property TrashID As String
        Set(value As String)
            sTrashID = value
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
    Public Function ValiDationRules(ByVal FrmName As String, ByVal frm As Form, Optional ByVal ExtraChecks As Boolean = False,
                                    Optional ByVal isOrder As Boolean = False, Optional ByVal sFields As Dictionary(Of String, String) = Nothing) As Boolean
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
                    ' Έλεγχος ώστε το Συμφωνηθέν ΦΠΑ να μην ξεπερνάει ποτέ το Κανονικό ΦΠΑ
                    If isOrder = True Then
                        Dim NormalVat As Double = (DbnullToZero(f.txtTotalErmariaVat) * 1.24) - DbnullToZero(f.txtTotalErmariaVat)
                        Dim PartOfVatVat As Double = DbnullToZero(f.txtPartofVat)
                        If PartOfVatVat > NormalVat Then
                            XtraMessageBox.Show("Λανθασμένη καταχώριση ποσού ΦΠΑ", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
                            Return False
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
                    If OrderExistInTransH("CCT_ORDERS_DOOR") = True Then Return False
                    If isOrder = True Then If AgreementExist() = True Then Return False
                    ' Έλεγχος ώστε το Συμφωνηθέν ΦΠΑ να μην ξεπερνάει ποτέ το Κανονικό ΦΠΑ
                    If isOrder = True Then
                        Dim NormalVat As Double = (DbnullToZero(f.txtTotalDoorsVat) * 1.24) - DbnullToZero(f.txtTotalDoorsVat)
                        Dim PartOfVatVat As Double = DbnullToZero(f.txtPartofVat)
                        If PartOfVatVat > NormalVat Then
                            XtraMessageBox.Show("Δεν μπορεί το συμφωνηθέν ΦΠΑ να είναι μεγαλύτερο από το κανονικό", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
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
                    ' Έλεγχος ώστε το Συμφωνηθέν ΦΠΑ να μην ξεπερνάει ποτέ το Κανονικό ΦΠΑ
                    If isOrder = True Then
                        Dim NormalVat As Double = (DbnullToZero(f.txtTotalClosetVat) * 1.24) - DbnullToZero(f.txtTotalClosetVat)
                        Dim PartOfVatVat As Double = DbnullToZero(f.txtPartofVat)
                        If PartOfVatVat > NormalVat Then
                            XtraMessageBox.Show("Δεν μπορεί το συμφωνηθέν ΦΠΑ να είναι μεγαλύτερο από το κανονικό", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
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
                    If OrderExistInTransH("CCT_ORDERS_SPECIAL_CONSTR") = True Then Return False
                    If isOrder = True Then If AgreementExist() = True Then Return False
                    ' Έλεγχος ώστε το Συμφωνηθέν ΦΠΑ να μην ξεπερνάει ποτέ το Κανονικό ΦΠΑ
                    If isOrder = True Then
                        Dim NormalVat As Double = (DbnullToZero(f.txtTotalSpecialVat) * 1.24) - DbnullToZero(f.txtTotalSpecialVat)
                        Dim PartOfVatVat As Double = DbnullToZero(f.txtPartofVat)
                        If PartOfVatVat > NormalVat Then
                            XtraMessageBox.Show("Δεν μπορεί το συμφωνηθέν ΦΠΑ να είναι μεγαλύτερο από το κανονικό", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
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
                Case "frmInstallations"
                    Dim f As frmInstallations = frm
                    Dim sSQL As String
                    Dim Cmd As SqlCommand
                    Dim sdr As SqlDataReader



                    '----------------------------------------------------------------------------------------------------
                    If f.Mode = FormMode.NewRecord Then
                        Dim CountInst As Integer
                        sSQL = "SELECT count(ID) as CountInst FROM [INST] WHERE transhID = " & toSQLValueS(sTrashID)
                        Cmd = New SqlCommand(sSQL, CNDB)
                        sdr = Cmd.ExecuteReader()
                        If (sdr.Read() = True) Then
                            If sdr.IsDBNull(sdr.GetOrdinal("CountInst")) = False Then CountInst = sdr.GetInt32(sdr.GetOrdinal("CountInst")) Else CountInst = 0
                            If CountInst = 1 Then
                                XtraMessageBox.Show("Υπάρχει ήδη πρόγραμμα τοποθέτησης στο έργο. ", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
                                Return False
                            End If
                        End If
                    End If
                    '----------------------------------------------------------------------------------------------------

                    Dim Hours As Long
                    If f.TabPane2.SelectedPageIndex = "0" Then
                        If f.txtTmKIN.Text = "00:00" Or f.txtTmKOUT.Text = "00:00" Then XtraMessageBox.Show("Η ώρα δεν μπορεί να είναι 00:00", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error) : Return False
                        f.txtTmKIN.EditValue = f.txtTmKIN.Text : f.txtTmKOUT.EditValue = f.txtTmKOUT.Text
                        Hours = DateDiff(DateInterval.Hour, f.txtTmKIN.EditValue, f.txtTmKOUT.EditValue)
                        If Hours < 0 Then XtraMessageBox.Show("Η ώρα ΑΠΟ δεν μπορεί να είναι μικρότερη από την ΕΩΣ", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error) : Return False
                        Dim date1 As Date = Date.Parse(f.dtDeliverDateKF.EditValue.ToString)
                        Dim date2 As Date = Date.Parse(f.dtDeliverDateKT.EditValue.ToString)
                        Dim Days As Int16 = DateDiff(DateInterval.Day, date1, date2)
                        If DateDiff(DateInterval.Day, date1, date2) < 0 Then XtraMessageBox.Show("Δεν μπορεί η ""ΑΠΟ"" ημερομηνία να είναι μεγαλύτερη από την ""ΕΩΣ""", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error) : Return False
                    End If
                    If f.TabPane2.SelectedPageIndex = "1" Then
                        If f.txtTmCIN.Text = "00:00" Or f.txtTmCOUT.Text = "00:00" Then XtraMessageBox.Show("Η ώρα δεν μπορεί να είναι 00:00", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error) : Return False
                        f.txtTmCIN.EditValue = f.txtTmCIN.Text : f.txtTmCOUT.EditValue = f.txtTmCOUT.Text
                        Hours = DateDiff(DateInterval.Hour, f.txtTmCIN.EditValue, f.txtTmCOUT.EditValue)
                        If Hours < 0 Then XtraMessageBox.Show("Η ώρα ΑΠΟ δεν μπορεί να είναι μικρότερη από την ΕΩΣ", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error) : Return False

                        Dim date1 As Date = Date.Parse(f.dtDeliverDateCF.EditValue.ToString)
                        Dim date2 As Date = Date.Parse(f.dtDeliverDateCT.EditValue.ToString)
                        Dim Days As Int16 = DateDiff(DateInterval.Day, date1, date2)
                        If DateDiff(DateInterval.Day, date1, date2) < 0 Then XtraMessageBox.Show("Δεν μπορεί η ""ΑΠΟ"" ημερομηνία να είναι μεγαλύτερη από την ""ΕΩΣ""", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error) : Return False
                    End If
                    If f.TabPane2.SelectedPageIndex = "2" Then
                        If f.txtTmDIN.Text = "00:00" Or f.txtTmDOUT.Text = "00:00" Then XtraMessageBox.Show("Η ώρα δεν μπορεί να είναι 00:00", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error) : Return False
                        f.txtTmDIN.EditValue = f.txtTmDIN.Text : f.txtTmDOUT.EditValue = f.txtTmDOUT.Text
                        Hours = DateDiff(DateInterval.Hour, f.txtTmDIN.EditValue, f.txtTmDOUT.EditValue)
                        If Hours < 0 Then XtraMessageBox.Show("Η ώρα ΑΠΟ δεν μπορεί να είναι μικρότερη από την ΕΩΣ", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error) : Return False

                        Dim date1 As Date = Date.Parse(f.dtDeliverDateDF.EditValue.ToString)
                        Dim date2 As Date = Date.Parse(f.dtDeliverDateDT.EditValue.ToString)
                        Dim Days As Int16 = DateDiff(DateInterval.Day, date1, date2)
                        If DateDiff(DateInterval.Day, date1, date2) < 0 Then XtraMessageBox.Show("Δεν μπορεί η ""ΑΠΟ"" ημερομηνία να είναι μεγαλύτερη από την ""ΕΩΣ""", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error) : Return False
                    End If
                    If f.TabPane2.SelectedPageIndex = "3" Then
                        If f.txtTmSCIN.Text = "00:00" Or f.txtTmSCOUT.Text = "00:00" Then XtraMessageBox.Show("Η ώρα δεν μπορεί να είναι 00:00", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error) : Return False
                        f.txtTmSCIN.EditValue = f.txtTmSCIN.Text : f.txtTmSCOUT.EditValue = f.txtTmSCOUT.Text
                        Hours = DateDiff(DateInterval.Hour, f.txtTmSCIN.EditValue, f.txtTmSCOUT.EditValue)
                        If Hours < 0 Then XtraMessageBox.Show("Η ώρα ΑΠΟ δεν μπορεί να είναι μικρότερη από την ΕΩΣ", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error) : Return False

                        Dim date1 As Date = Date.Parse(f.dtDeliverDateSCF.EditValue.ToString)
                        Dim date2 As Date = Date.Parse(f.dtDeliverDateSCT.EditValue.ToString)
                        Dim Days As Int16 = DateDiff(DateInterval.Day, date1, date2)
                        If DateDiff(DateInterval.Day, date1, date2) < 0 Then XtraMessageBox.Show("Δεν μπορεί η ""ΑΠΟ"" ημερομηνία να είναι μεγαλύτερη από την ""ΕΩΣ""", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error) : Return False
                    End If
                    '----------------------------------------------------------------------------------------------------
                    Dim sFilename As String = ""
                    If f.chkCompleted.Checked = True Then
                        sSQL = "SELECT fInstName  FROM INST WHERE transhID= " & toSQLValueS(sTrashID)
                        Cmd = New SqlCommand(sSQL.ToString, CNDB)
                        sdr = Cmd.ExecuteReader()
                        If (sdr.Read() = True) Then
                            If sdr.IsDBNull(sdr.GetOrdinal("fInstName")) = False Then sFilename = sdr.GetString(sdr.GetOrdinal("fInstName"))
                            If sFilename = "" Then
                                XtraMessageBox.Show("Δεν μπορείτε να ολοκληρώσετε την Τοποθέτηση χωρίς να επισυνάψετε έντυπο", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
                                sdr.Close()
                                Return False
                            Else
                                sdr.Close()
                            End If
                        Else
                            XtraMessageBox.Show("Δεν μπορείτε να ολοκληρώσετε την Τοποθέτηση χωρίς να επισυνάψετε έντυπο", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
                            Return False
                        End If
                    End If
                    '------------------------------------------------------------------------------------------------------
                    Dim ExistCost As Integer
                    'ΚΟΥΖΙΝΑ
                    If f.cboExtPartnerKitchen.EditValue IsNot Nothing Then
                        If sFields.Count > 0 Then
                            If sFields("ExtPartnerKitchenID") <> f.cboExtPartnerKitchen.EditValue.ToString Then
                                sSQL = "SELECT count(ID) as ExistCost FROM INST_COST WHERE  kitchen = 1 and Paid = 1 and instID = " & toSQLValueS(sFields("ID"))
                                Cmd = New SqlCommand(sSQL, CNDB) : sdr = Cmd.ExecuteReader()
                                If (sdr.Read() = True) Then
                                    If sdr.IsDBNull(sdr.GetOrdinal("ExistCost")) = False Then ExistCost = sdr.GetInt32(sdr.GetOrdinal("ExistCost")) Else ExistCost = 0
                                    If ExistCost = 1 Then
                                        XtraMessageBox.Show("Δεν μπορεί να γίνει αλλαγή Τοποθέτη για την κουζίνα όταν υπάρχει εξοφλημένη συναλλαγή", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
                                        sdr.Close()
                                        Return False
                                    End If
                                End If
                            End If
                        End If
                    End If
                    'ΝΤΟΥΛΑΠΑ
                    If f.cboExtPartnerCloset.EditValue IsNot Nothing Then
                        If sFields.Count > 0 Then
                            If sFields("ExtPartnerClosetID") <> toSQLValueS(f.cboExtPartnerCloset.EditValue.ToString) Then
                                sSQL = "SELECT count(ID) as ExistCost FROM INST_COST WHERE  closet = 1 and Paid = 1 and instID = " & toSQLValueS(sFields("ID"))
                                Cmd = New SqlCommand(sSQL, CNDB) : sdr = Cmd.ExecuteReader()
                                If (sdr.Read() = True) Then
                                    If sdr.IsDBNull(sdr.GetOrdinal("ExistCost")) = False Then ExistCost = sdr.GetInt32(sdr.GetOrdinal("ExistCost")) Else ExistCost = 0
                                    If ExistCost = 1 Then
                                        XtraMessageBox.Show("Δεν μπορεί να γίνει αλλαγή Τοποθέτη για τις ντουλάπες όταν υπάρχει εξοφλημένη συναλλαγή", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
                                        sdr.Close()
                                        Return False
                                    End If
                                End If
                            End If
                        End If
                    End If
                    'ΠΟΡΤΑ
                    If f.cboExtPartnerDoors.EditValue IsNot Nothing Then
                        If sFields.Count > 0 Then
                            If sFields("ExtPartnerDoorsID") <> toSQLValueS(f.cboExtPartnerDoors.EditValue.ToString) Then
                                sSQL = "SELECT count(ID) as ExistCost FROM INST_COST WHERE  doors = 1 and Paid = 1 and instID = " & toSQLValueS(sFields("ID"))
                                Cmd = New SqlCommand(sSQL, CNDB) : sdr = Cmd.ExecuteReader()
                                If (sdr.Read() = True) Then
                                    If sdr.IsDBNull(sdr.GetOrdinal("ExistCost")) = False Then ExistCost = sdr.GetInt32(sdr.GetOrdinal("ExistCost")) Else ExistCost = 0
                                    If ExistCost = 1 Then
                                        XtraMessageBox.Show("Δεν μπορεί να γίνει αλλαγή Τοποθέτη για τις πόρτες όταν υπάρχει εξοφλημένη συναλλαγή", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
                                        sdr.Close()
                                        Return False
                                    End If
                                End If
                            End If
                        End If
                    End If
                    'ΕΙΔΙΚΗ ΚΑΤΑΣΚΕΥΗ
                    If f.cboExtPartnerSC.EditValue IsNot Nothing Then
                        If sFields.Count > 0 Then
                            If sFields("ExtPartnerSCID") <> toSQLValueS(f.cboExtPartnerSC.EditValue.ToString) Then
                                sSQL = "SELECT count(ID) as ExistCost FROM INST_COST WHERE  doors = 1 and Paid = 1 and instID = " & toSQLValueS(sFields("ID"))
                                Cmd = New SqlCommand(sSQL, CNDB) : sdr = Cmd.ExecuteReader()
                                If (sdr.Read() = True) Then
                                    If sdr.IsDBNull(sdr.GetOrdinal("ExistCost")) = False Then ExistCost = sdr.GetInt32(sdr.GetOrdinal("ExistCost")) Else ExistCost = 0
                                    If ExistCost = 1 Then
                                        XtraMessageBox.Show("Δεν μπορεί να γίνει αλλαγή Τοποθέτη για τις Ειδ. Κατασκευές όταν υπάρχει εξοφλημένη συναλλαγή", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
                                        sdr.Close()
                                        Return False
                                    End If
                                End If
                            End If
                        End If
                    End If

                Case "frmProjectJobs"
                    Dim f As frmProjectJobs = frm
                    If ExtraChecks = False Then
                        f.GridControl1.ForceInitialize()
                        If f.ComeFrom = 0 Then
                            If f.dtVisitDate.EditValue IsNot Nothing Then
                                If f.txtTmIN.Text = "00:00" Or f.txtTmOUT.Text = "00:00" Then XtraMessageBox.Show("Η ώρα δεν μπορεί να είναι 00:00", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error) : Return False
                                f.txtTmIN.EditValue = f.txtTmIN.Text : f.txtTmOUT.EditValue = f.txtTmOUT.Text
                                Dim Hours As Long = DateDiff(DateInterval.Hour, f.txtTmIN.EditValue, f.txtTmOUT.EditValue)
                                If Hours < 0 Then XtraMessageBox.Show("Η ώρα ΑΠΟ δεν μπορεί να είναι μικρότερη από την ΕΩΣ", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error) : Return False
                            End If

                            If f.dtVisitDate.EditValue IsNot Nothing And f.chkSER.CheckedItemsCount = 0 Then
                                XtraMessageBox.Show("Έχετε επιλέξει ημερομηνία επίσκεψης χωρίς να επιλέξετε συνεργείο. Δεν μπορεί να αποθηκευθεί η εγγραφή.", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
                                Return False
                            End If

                            If f.chkCompleted.CheckState = CheckState.Checked And f.dtVisitDate.EditValue = Nothing Then
                                XtraMessageBox.Show("Δεν μπορείτε να ολοκληρώσετε την εργασία χωρίς ημερομηνία επίσκεψης. Δεν μπορεί να αποθηκευθεί η εγγραφή.", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
                                Return False
                            End If

                            If CheckIfProjectJobsDAreCompleted() And f.txtfProjectNameComplete.EditValue = Nothing Then
                                XtraMessageBox.Show("Δεν έχετε ολοκληρώσει όλες τις εργασίες ή δεν έχετε επισυνάψει το έντυπο ολοκλήρωσης. Δεν μπορεί να αποθηκευθεί η εγγραφή.", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
                                Return False
                            End If
                        End If
                        'isOrder = sComeFrom
                        If f.ComeFrom = 1 And f.cboSUP.EditValue = Nothing Then
                            XtraMessageBox.Show("Δεν έχετε επιλέξει Προμηθευτή.", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
                            Return False
                        End If
                        Return True
                    Else
                        If f.Mode = FormMode.NewRecord Then
                            XtraMessageBox.Show("Δεν έχετε αποθηκέυση την εργασία. Παρακαλώ κάντε κλίκ στο  ""Αποθήκευση"".", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
                            Return False
                        End If
                        If CheckIfProjectJobsDAreCompleted() Then
                            XtraMessageBox.Show("Όλες οι εργασίες είναι ολοκληρωμένες. Δεν μπορεί να αποθηκευθεί η εγγραφή.", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
                            Return False
                        End If
                        If f.cboSUP.EditValue = Nothing Then
                            XtraMessageBox.Show("Δεν έχετε επιλέξει Προμηθευτή.", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
                            Return False
                        End If
                    End If
            End Select
            Return True
        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try

    End Function
    Private Function CheckIfProjectJobsDAreCompleted() As Boolean
        Dim Cmd As SqlCommand, sdr As SqlDataReader
        Dim sSQL As String
        sSQL = "SELECT id as CountJobD  FROM PROJECT_JOBS_D WHERE completed = 0 and projectJobID= " & toSQLValueS(sID)
        Cmd = New SqlCommand(sSQL.ToString, CNDB)
        sdr = Cmd.ExecuteReader()
        Dim CountJobD As String
        If (sdr.Read() = True) Then
            If sdr.IsDBNull(sdr.GetOrdinal("CountJobD")) = False Then CountJobD = sdr.GetGuid(sdr.GetOrdinal("CountJobD")).ToString Else CountJobD = ""
            sdr.Close()
            If CountJobD <> "" Then Return False Else Return True
        Else
            sdr.Close()
            Return True
        End If
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
                If LItem.ControlName isnot Nothing Then
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
                If LItem.ControlName isnot Nothing Then
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
