﻿Imports DevExpress.XtraEditors
Imports DevExpress.XtraLayout

Public Class ValidateControls
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
                                    XtraMessageBox.Show("Υπάρχουν υποχρεωτικά πεδία που δεν έχετε συμπληρώσει.", "Dreamy Kitchen CRM", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                    Return False
                                End If
                            End If
                        End If
                        If LItem.Control.Text = "" Then
                            XtraMessageBox.Show("Υπάρχουν υποχρεωτικά πεδία που δεν έχετε συμπληρώσει.", "Dreamy Kitchen CRM", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            Return False
                        End If
                    End If
                End If
            End If
        Next
        Return True
    End Function
End Class
