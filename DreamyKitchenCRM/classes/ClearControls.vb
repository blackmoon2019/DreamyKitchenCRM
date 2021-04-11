Imports DevExpress.XtraLayout
Imports DevExpress.XtraEditors

Public Class ClearControls
    Public Sub ClearCtrls(ByVal control As DevExpress.XtraLayout.LayoutControl)
        For Each item As BaseLayoutItem In control.Items
            If TypeOf item Is LayoutControlItem Then
                Dim LItem As LayoutControlItem = CType(item, LayoutControlItem)
                If LItem.ControlName <> Nothing Then
                    If LItem.Control.Tag <> "" Then
                        If LItem.Control.Visible = True Then
                            Dim Ctrl As Control = LItem.Control
                            If TypeOf Ctrl Is DevExpress.XtraEditors.LookUpEdit Then
                                Dim cbo As DevExpress.XtraEditors.LookUpEdit
                                cbo = Ctrl
                                cbo.EditValue = Nothing : cbo.Text = "" : cbo.EditValue = ""
                            ElseIf TypeOf Ctrl Is DevExpress.XtraEditors.ColorPickEdit Then
                                Dim cpk As DevExpress.XtraEditors.ColorPickEdit
                                cpk = Ctrl
                                cpk.EditValue = Nothing : cpk.Text = "" : cpk.EditValue = ""
                            ElseIf TypeOf Ctrl Is DevExpress.XtraEditors.DateEdit Then
                                Dim dt As DevExpress.XtraEditors.DateEdit
                                dt = Ctrl
                                dt.Text = "" : dt.EditValue = ""
                            ElseIf TypeOf Ctrl Is DevExpress.XtraEditors.TextEdit Then
                                Dim txt As DevExpress.XtraEditors.TextEdit
                                txt = Ctrl
                                If txt.Properties.Mask.EditMask = "c" & ProgProps.Decimals Or txt.Properties.Mask.MaskType = Mask.MaskType.Numeric Or txt.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric Then
                                    txt.EditValue = "0"
                                Else
                                    txt.Text = ""
                                End If
                            ElseIf TypeOf Ctrl Is DevExpress.XtraEditors.CheckedListBoxControl Then
                                Dim chklst As DevExpress.XtraEditors.CheckedListBoxControl
                                chklst = Ctrl
                                chklst.UnCheckAll()
                            ElseIf TypeOf Ctrl Is DevExpress.XtraEditors.CheckEdit Then
                                Dim chk As DevExpress.XtraEditors.CheckEdit
                                chk = Ctrl
                                chk.Checked = False
                            ElseIf TypeOf Ctrl Is DevExpress.XtraEditors.PictureEdit Then
                                Dim pic As DevExpress.XtraEditors.PictureEdit
                                pic = Ctrl
                                pic.EditValue = ""
                            End If
                        End If
                    End If
                End If
            End If
        Next
    End Sub
    Public Sub ClearCtrlsGRP(ByVal GRP As DevExpress.XtraLayout.LayoutControlGroup)
        Try
            For Each item As BaseLayoutItem In GRP.Items
                If TypeOf item Is LayoutControlItem Then
                    Dim LItem As LayoutControlItem = CType(item, LayoutControlItem)
                    If LItem.ControlName <> Nothing Then
                        If LItem.Control.Tag <> "" Then
                            If LItem.Control.Visible = True Then
                                Dim Ctrl As Control = LItem.Control
                                If TypeOf Ctrl Is DevExpress.XtraEditors.LookUpEdit Then
                                    Dim cbo As DevExpress.XtraEditors.LookUpEdit
                                    cbo = Ctrl
                                    cbo.EditValue = Nothing : cbo.Text = "" : cbo.EditValue = ""
                                ElseIf TypeOf Ctrl Is DevExpress.XtraEditors.ColorPickEdit Then
                                    Dim cpk As DevExpress.XtraEditors.ColorPickEdit
                                    cpk = Ctrl
                                    cpk.EditValue = Nothing : cpk.Text = "" : cpk.EditValue = ""
                                ElseIf TypeOf Ctrl Is DevExpress.XtraEditors.DateEdit Then
                                    Dim dt As DevExpress.XtraEditors.DateEdit
                                    dt = Ctrl
                                    dt.Text = "" : dt.EditValue = ""
                                ElseIf TypeOf Ctrl Is DevExpress.XtraEditors.TextEdit Then
                                    Dim txt As DevExpress.XtraEditors.TextEdit
                                    txt = Ctrl
                                    If txt.Properties.Mask.EditMask = "c" & ProgProps.Decimals Or txt.Properties.Mask.MaskType = Mask.MaskType.Numeric Or txt.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric Then
                                        txt.EditValue = "0"
                                    Else
                                        txt.Text = ""
                                    End If
                                ElseIf TypeOf Ctrl Is DevExpress.XtraEditors.CheckedListBoxControl Then
                                    Dim chklst As DevExpress.XtraEditors.CheckedListBoxControl
                                    chklst = Ctrl
                                    chklst.UnCheckAll()
                                ElseIf TypeOf Ctrl Is DevExpress.XtraEditors.CheckEdit Then
                                    Dim chk As DevExpress.XtraEditors.CheckEdit
                                    chk = Ctrl
                                    chk.Checked = False
                                ElseIf TypeOf Ctrl Is DevExpress.XtraEditors.PictureEdit Then
                                    Dim pic As DevExpress.XtraEditors.PictureEdit
                                    pic = Ctrl
                                    pic.EditValue = ""
                                End If
                            End If
                        End If
                    End If
                End If
            Next
        Catch ex As Exception
            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message), "Dreamy Kitchen CRM", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
