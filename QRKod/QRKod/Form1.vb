Imports System.Drawing.Printing
Imports System.IO
Imports Qr.Net.Imaging
Imports ThoughtWorks.QRCode.Codec
Imports ThoughtWorks.QRCode.Codec.Data
Public Class Form1
    Private Sub OlusturBtn_Click(sender As Object, e As EventArgs) Handles OlusturBtn.Click
        QRPBox.Image = Nothing
        If String.IsNullOrWhiteSpace(VeriTBox.Text.Trim) Then
            MessageBox.Show("Veri girişi yapılmamış.", "Hata")
            Exit Sub
        End If
        'QR Kod Veri Türü
        Dim QRKodOlusturucu As New QRCodeEncoder
        If MetinRBtn.Checked Then
            QRKodOlusturucu.QRCodeEncodeMode = QRCodeEncoder.ENCODE_MODE.ALPHA_NUMERIC
        ElseIf SayiRBtn.Checked Then
            QRKodOlusturucu.QRCodeEncodeMode = QRCodeEncoder.ENCODE_MODE.NUMERIC
        Else
            QRKodOlusturucu.QRCodeEncodeMode = QRCodeEncoder.ENCODE_MODE.BYTE
        End If
        'Hata düzeltme seviyesi
        Select Case SeviyeCBox.SelectedIndex
            Case 0
                QRKodOlusturucu.QRCodeErrorCorrect = QRCodeEncoder.ERROR_CORRECTION.L
            Case 1
                QRKodOlusturucu.QRCodeErrorCorrect = QRCodeEncoder.ERROR_CORRECTION.M
            Case 2
                QRKodOlusturucu.QRCodeErrorCorrect = QRCodeEncoder.ERROR_CORRECTION.Q
            Case Else
                QRKodOlusturucu.QRCodeErrorCorrect = QRCodeEncoder.ERROR_CORRECTION.H
        End Select
        'Versiyon bilgisi
        Try
            QRKodOlusturucu.QRCodeVersion = VersiyonNUD.Value
        Catch ex As Exception
            MessageBox.Show("Versiyon değeri hatalı. Yeni bir versiyon seçiniz.", "Hata")
        End Try
        'Büyüklük seviyesi
        Try
            QRKodOlusturucu.QRCodeScale = BuyuklukNUD.Value
        Catch ex As Exception
            MessageBox.Show("Büyüklük değeri hatalı. Yeni bir büyüklük seçiniz.", "Hata")
        End Try
        'QR Kod oluştur
        Dim Veri As String = BuyukHarfeCevir(VeriTBox.Text)
        VeriTBox.Text = Veri
        Try
            Dim OlusanVeri = QRKodOlusturucu.Encode(Veri, System.Text.Encoding.UTF8)
            Dim QRResim As New QrImage
            Dim Resim As Image = QRResim.CreateImage(OlusanVeri)
            QRPBox.Image = Resim
        Catch ex As Exception
            MessageBox.Show("QR Kod oluşturulurken hata oluştu.", "Hata")
        End Try
    End Sub
    Private Function BuyukHarfeCevir(Metin As String) As String
        Dim Sonuc As String = Nothing
        Sonuc = UCase(Metin)
        Dim TR As String = "ÖÇŞİĞÜ"
        Dim EN As String = "OCSIGU"
        For i = 0 To TR.Count - 1
            Sonuc = Sonuc.Replace(TR(i), EN(i))
        Next
        Return Sonuc
    End Function
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SeviyeCBox.SelectedIndex = 1
        VersiyonNUD.Value = 7
        BuyuklukNUD.Value = 4
    End Sub

    Private Sub KaydetBtn_Click(sender As Object, e As EventArgs) Handles KaydetBtn.Click
        If Not IsNothing(QRPBox.Image) Then
            QRKodSaveFD.Filter = "Jpeg Resmi|*.jpg|PNG Resmi|*.png"
            QRKodSaveFD.FilterIndex = 1
            QRKodSaveFD.FileName = Nothing
            QRKodSaveFD.Title = "QR Kod Kaydet"
            If QRKodSaveFD.ShowDialog = DialogResult.OK Then
                Dim QRFS As FileStream = CType(QRKodSaveFD.OpenFile, FileStream)
                Select Case QRKodSaveFD.FilterIndex
                    Case 1
                        QRPBox.Image.Save(QRFS, Imaging.ImageFormat.Jpeg)
                    Case Else
                        QRPBox.Image.Save(QRFS, Imaging.ImageFormat.Png)
                End Select
                QRFS.Flush()
                QRFS.Close()
            End If
        End If
    End Sub

    Private Sub YazdirBtn_Click(sender As Object, e As EventArgs) Handles YazdirBtn.Click
        If Not IsNothing(QRPBox.Image) Then
            QRKodPrintD.Document = QRKodPDoc
            If QRKodPrintD.ShowDialog = DialogResult.OK Then
                QRKodPDoc.Print()
            End If
        End If
    End Sub

    Private Sub QRKodPDoc_PrintPage(sender As Object, e As PrintPageEventArgs) Handles QRKodPDoc.PrintPage
        e.Graphics.DrawImage(QRPBox.Image, New Point(0, 0))
    End Sub

    Private Sub OkuBtn_Click(sender As Object, e As EventArgs) Handles OkuBtn.Click
        QRPBox.Image = Nothing
        QRKodOpenFD.Filter = "Jpeg Resmi|*.jpg;*.jpeg|Png Resmi|*.png|Gif Resmi|*.gif|Bitmap Resmi|*.bmp"
        QRKodOpenFD.FilterIndex = 1
        QRKodOpenFD.RestoreDirectory = True
        QRKodOpenFD.FileName = Nothing
        If QRKodOpenFD.ShowDialog = DialogResult.OK Then
            Dim Resim As New Bitmap(QRKodOpenFD.FileName)
            QRPBox.Image = Resim
            Try
                Dim QROkuyucu As New QRCodeDecoder
                Dim Okunan As String = QROkuyucu.decode(New QRCodeBitmapImage(Resim))
                VeriTBox.Text = Okunan
            Catch ex As Exception
                MessageBox.Show("QR Kod okunurken hata oluştu.", "Hata")
            End Try
        End If
    End Sub
End Class
