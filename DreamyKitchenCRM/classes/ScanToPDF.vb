Imports System.Drawing.Imaging
Imports System.IO
Imports DevExpress.XtraEditors
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports WIA
Public Class ScanToPDF
    Public Function Scan(ByRef sFilename As String, ByVal BNDSource As BindingSource, ByVal sPages As Integer) As Boolean
        Dim CD As New WIA.CommonDialog
        Dim oPDF As New Document(PageSize.A4, 10.0F, 10.0F, 10.0F, 10.0F)
        Try
            Dim i As Integer
            For i = 1 To sPages
                'Dim F As WIA.ImageFile = CD.ShowAcquireImage(WIA.WiaDeviceType.ScannerDeviceType)
                'Dim Scanner As WIA.Device

                'Scanner = CD.ShowSelectDevice(WIA.WiaDeviceType.ScannerDeviceType, False, False)
                Dim imagefile As ImageFile = CD.ShowAcquireImage(DeviceType:=WiaDeviceType.ScannerDeviceType, Intent:=WiaImageIntent.ColorIntent, Bias:=WiaImageBias.MinimizeSize,
                                                    FormatID:=WIA.FormatID.wiaFormatJPEG, AlwaysSelectDevice:=False, UseCommonUI:=True, CancelError:=False)
                Dim sPath As String = ProgProps.ServerPath & "tmpscan" & i & ".jpg"
                If (imagefile IsNot Nothing) Then
                    Dim v As Vector = imagefile.FileData
                    Dim bytes As Byte() = v.BinaryData()
                    Using ms = New System.IO.MemoryStream(bytes)
                        Using bitmap = New Bitmap(ms)
                            Dim codecinfo As ImageCodecInfo = ImageCodecInfo.GetImageDecoders.First(Function(name) name.FormatID = ImageFormat.Jpeg.Guid)
                            Dim encoder As Encoder = Encoder.Quality
                            Dim ep As EncoderParameters = New EncoderParameters(1)
                            Dim qualityParameter As EncoderParameter = New EncoderParameter(encoder, 75L)
                            ep.Param(0) = qualityParameter
                            bitmap.Save(sPath, codecinfo, ep)
                            ms.Dispose()
                            ms.Close()
                        End Using
                    End Using
                End If
            Next i
            ' Dim result = XtraInputBox.Show("Πληκτρολογήστε το όνομα του αρχείου", "Όνομα Αρχείου", "Έγγραφο")
            Dim args As New XtraInputBoxArgs()
            ' Specify settings.
            args.Caption = "Πληκτρολογήστε το όνομα του αρχείου"
            args.Prompt = "Όνομα Αρχείου"
            args.DefaultButtonIndex = 0
            ' Initialize a new DateEdit instance.
            Dim editor As New DevExpress.XtraEditors.LookUpEdit()
            ' Specify settings.
            editor.Properties.DataSource = BNDSource
            editor.Properties.DisplayMember = "name"
            editor.Properties.ValueMember = "name"
            editor.Properties.NullValuePrompt = ""
            editor.Properties.NullText = ""

            ' Assign the editor to the input box settings.
            args.Editor = editor
            ' Specify the editor's default value.
            Dim result = XtraInputBox.Show(args)

            If result = "" Then
                CD = Nothing
                oPDF = Nothing
                Return False
            End If
            'Dim oPDF As New Document()

            Dim pdfFILE As String = ProgProps.ServerPath & result & ".pdf"
            sFilename = ProgProps.ServerPath & result & ".pdf"
            Dim oPDfWriter As PdfWriter = PdfWriter.GetInstance(oPDF, New FileStream(pdfFILE, FileMode.Create))

            oPDF.Open()
            For i = 1 To sPages
                Dim myImage As Image = Image.GetInstance(ProgProps.ServerPath & "tmpscan" & i & ".jpg")
                myImage.ScaleToFit(PageSize.A4)
                myImage.Alignment = Element.ALIGN_CENTER
                oPDF.Add(myImage)
                myImage = Nothing
            Next i
            oPDF.Close()
            oPDF = Nothing
            Return True
        Catch ex As Exception

            Dim trace = New Diagnostics.StackTrace(ex, True)
            Dim line As String = Right(trace.ToString, 5)

            XtraMessageBox.Show(String.Format("Error: {0}", ex.Message & " Error in- Line number: " & line), Company, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        Finally
            CD = Nothing
            oPDF = Nothing
        End Try
    End Function

End Class
