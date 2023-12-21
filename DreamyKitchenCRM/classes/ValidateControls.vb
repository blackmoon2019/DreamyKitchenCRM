Imports DevExpress.XtraEditors
Imports DevExpress.XtraLayout

Public Class ValidateControls
    Public SChanged As Boolean
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
    Public Function ValiDationRules(ByVal FrmName As String, ByVal frm As Form) As Boolean
        Select Case FrmName
            Case "frmCUSOfferOrderKitchen"
                Dim f As frmCUSOfferOrderKitchen = frm
                ' 1st Rule
                If f.cboCompany.EditValue IsNot Nothing And f.cboCompProject.EditValue = Nothing Then
                    XtraMessageBox.Show("Δεν έχετε συμπληρώσει έργο εταιρίας", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return False
                End If
                If (f.txtCUSOfferOrderFilename.EditValue IsNot Nothing And (f.cboSup.EditValue = Nothing Or f.txtbenchSalesPrice.EditValue = 0)) Then
                    XtraMessageBox.Show("Έχετε επισυνάψει έντυπο προσφορας πάγκου και δεν έχετε επιλέξει προμηθευτή ή Τιμή.Λ", ProgProps.ProgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return False
                End If
                Return True
        End Select
    End Function
End Class
