<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.OlusturBtn = New System.Windows.Forms.Button()
        Me.KaydetBtn = New System.Windows.Forms.Button()
        Me.YazdirBtn = New System.Windows.Forms.Button()
        Me.OkuBtn = New System.Windows.Forms.Button()
        Me.BuyuklukNUD = New System.Windows.Forms.NumericUpDown()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.VersiyonNUD = New System.Windows.Forms.NumericUpDown()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SeviyeCBox = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ByteRBtn = New System.Windows.Forms.RadioButton()
        Me.MetinRBtn = New System.Windows.Forms.RadioButton()
        Me.SayiRBtn = New System.Windows.Forms.RadioButton()
        Me.VeriTBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.QRPBox = New System.Windows.Forms.PictureBox()
        Me.QRKodSaveFD = New System.Windows.Forms.SaveFileDialog()
        Me.QRKodOpenFD = New System.Windows.Forms.OpenFileDialog()
        Me.QRKodPrintD = New System.Windows.Forms.PrintDialog()
        Me.QRKodPDoc = New System.Drawing.Printing.PrintDocument()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.BuyuklukNUD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VersiyonNUD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QRPBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer1.IsSplitterFixed = True
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.OlusturBtn)
        Me.SplitContainer1.Panel1.Controls.Add(Me.KaydetBtn)
        Me.SplitContainer1.Panel1.Controls.Add(Me.YazdirBtn)
        Me.SplitContainer1.Panel1.Controls.Add(Me.OkuBtn)
        Me.SplitContainer1.Panel1.Controls.Add(Me.BuyuklukNUD)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label4)
        Me.SplitContainer1.Panel1.Controls.Add(Me.VersiyonNUD)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label3)
        Me.SplitContainer1.Panel1.Controls.Add(Me.SeviyeCBox)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ByteRBtn)
        Me.SplitContainer1.Panel1.Controls.Add(Me.MetinRBtn)
        Me.SplitContainer1.Panel1.Controls.Add(Me.SayiRBtn)
        Me.SplitContainer1.Panel1.Controls.Add(Me.VeriTBox)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.AutoScroll = True
        Me.SplitContainer1.Panel2.Controls.Add(Me.QRPBox)
        Me.SplitContainer1.Size = New System.Drawing.Size(800, 467)
        Me.SplitContainer1.SplitterDistance = 300
        Me.SplitContainer1.TabIndex = 0
        '
        'OlusturBtn
        '
        Me.OlusturBtn.Image = CType(resources.GetObject("OlusturBtn.Image"), System.Drawing.Image)
        Me.OlusturBtn.Location = New System.Drawing.Point(12, 394)
        Me.OlusturBtn.Name = "OlusturBtn"
        Me.OlusturBtn.Size = New System.Drawing.Size(69, 70)
        Me.OlusturBtn.TabIndex = 1
        Me.OlusturBtn.Text = "Oluştur"
        Me.OlusturBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.OlusturBtn.UseVisualStyleBackColor = True
        '
        'KaydetBtn
        '
        Me.KaydetBtn.Image = CType(resources.GetObject("KaydetBtn.Image"), System.Drawing.Image)
        Me.KaydetBtn.Location = New System.Drawing.Point(81, 394)
        Me.KaydetBtn.Name = "KaydetBtn"
        Me.KaydetBtn.Size = New System.Drawing.Size(69, 70)
        Me.KaydetBtn.TabIndex = 2
        Me.KaydetBtn.Text = "Kaydet"
        Me.KaydetBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.KaydetBtn.UseVisualStyleBackColor = True
        '
        'YazdirBtn
        '
        Me.YazdirBtn.Image = CType(resources.GetObject("YazdirBtn.Image"), System.Drawing.Image)
        Me.YazdirBtn.Location = New System.Drawing.Point(150, 394)
        Me.YazdirBtn.Name = "YazdirBtn"
        Me.YazdirBtn.Size = New System.Drawing.Size(69, 70)
        Me.YazdirBtn.TabIndex = 3
        Me.YazdirBtn.Text = "Yazdır"
        Me.YazdirBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.YazdirBtn.UseVisualStyleBackColor = True
        '
        'OkuBtn
        '
        Me.OkuBtn.Image = CType(resources.GetObject("OkuBtn.Image"), System.Drawing.Image)
        Me.OkuBtn.Location = New System.Drawing.Point(219, 394)
        Me.OkuBtn.Name = "OkuBtn"
        Me.OkuBtn.Size = New System.Drawing.Size(69, 70)
        Me.OkuBtn.TabIndex = 4
        Me.OkuBtn.Text = "Oku"
        Me.OkuBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.OkuBtn.UseVisualStyleBackColor = True
        '
        'BuyuklukNUD
        '
        Me.BuyuklukNUD.Location = New System.Drawing.Point(150, 362)
        Me.BuyuklukNUD.Maximum = New Decimal(New Integer() {40, 0, 0, 0})
        Me.BuyuklukNUD.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.BuyuklukNUD.Name = "BuyuklukNUD"
        Me.BuyuklukNUD.Size = New System.Drawing.Size(53, 23)
        Me.BuyuklukNUD.TabIndex = 10
        Me.BuyuklukNUD.Value = New Decimal(New Integer() {4, 0, 0, 0})
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 364)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 15)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Büyüklük:"
        '
        'VersiyonNUD
        '
        Me.VersiyonNUD.Location = New System.Drawing.Point(150, 332)
        Me.VersiyonNUD.Maximum = New Decimal(New Integer() {40, 0, 0, 0})
        Me.VersiyonNUD.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.VersiyonNUD.Name = "VersiyonNUD"
        Me.VersiyonNUD.Size = New System.Drawing.Size(53, 23)
        Me.VersiyonNUD.TabIndex = 8
        Me.VersiyonNUD.Value = New Decimal(New Integer() {7, 0, 0, 0})
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 334)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 15)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Versiyon:"
        '
        'SeviyeCBox
        '
        Me.SeviyeCBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.SeviyeCBox.FormattingEnabled = True
        Me.SeviyeCBox.Items.AddRange(New Object() {"Düşük (L)", "Orta (M)", "Kaliteli (Q)", "Yüksek (H)"})
        Me.SeviyeCBox.Location = New System.Drawing.Point(150, 303)
        Me.SeviyeCBox.Name = "SeviyeCBox"
        Me.SeviyeCBox.Size = New System.Drawing.Size(98, 23)
        Me.SeviyeCBox.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 306)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(132, 15)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Hata Düzeltme Seviyesi:"
        '
        'ByteRBtn
        '
        Me.ByteRBtn.AutoSize = True
        Me.ByteRBtn.Location = New System.Drawing.Point(236, 269)
        Me.ByteRBtn.Name = "ByteRBtn"
        Me.ByteRBtn.Size = New System.Drawing.Size(48, 19)
        Me.ByteRBtn.TabIndex = 4
        Me.ByteRBtn.Text = "Byte"
        Me.ByteRBtn.UseVisualStyleBackColor = True
        '
        'MetinRBtn
        '
        Me.MetinRBtn.AutoSize = True
        Me.MetinRBtn.Checked = True
        Me.MetinRBtn.Location = New System.Drawing.Point(119, 269)
        Me.MetinRBtn.Name = "MetinRBtn"
        Me.MetinRBtn.Size = New System.Drawing.Size(56, 19)
        Me.MetinRBtn.TabIndex = 3
        Me.MetinRBtn.TabStop = True
        Me.MetinRBtn.Text = "Metin"
        Me.MetinRBtn.UseVisualStyleBackColor = True
        '
        'SayiRBtn
        '
        Me.SayiRBtn.AutoSize = True
        Me.SayiRBtn.Location = New System.Drawing.Point(12, 269)
        Me.SayiRBtn.Name = "SayiRBtn"
        Me.SayiRBtn.Size = New System.Drawing.Size(46, 19)
        Me.SayiRBtn.TabIndex = 2
        Me.SayiRBtn.Text = "Sayı"
        Me.SayiRBtn.UseVisualStyleBackColor = True
        '
        'VeriTBox
        '
        Me.VeriTBox.Location = New System.Drawing.Point(12, 26)
        Me.VeriTBox.Multiline = True
        Me.VeriTBox.Name = "VeriTBox"
        Me.VeriTBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.VeriTBox.Size = New System.Drawing.Size(272, 236)
        Me.VeriTBox.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Veri:"
        '
        'QRPBox
        '
        Me.QRPBox.BackColor = System.Drawing.Color.White
        Me.QRPBox.Location = New System.Drawing.Point(0, 0)
        Me.QRPBox.Name = "QRPBox"
        Me.QRPBox.Size = New System.Drawing.Size(208, 203)
        Me.QRPBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.QRPBox.TabIndex = 0
        Me.QRPBox.TabStop = False
        '
        'QRKodOpenFD
        '
        Me.QRKodOpenFD.FileName = "OpenFileDialog1"
        '
        'QRKodPrintD
        '
        Me.QRKodPrintD.UseEXDialog = True
        '
        'QRKodPDoc
        '
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 467)
        Me.Controls.Add(Me.SplitContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.Text = "QR Kod Programı"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.BuyuklukNUD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VersiyonNUD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QRPBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents BuyuklukNUD As NumericUpDown
    Friend WithEvents Label4 As Label
    Friend WithEvents VersiyonNUD As NumericUpDown
    Friend WithEvents Label3 As Label
    Friend WithEvents SeviyeCBox As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents ByteRBtn As RadioButton
    Friend WithEvents MetinRBtn As RadioButton
    Friend WithEvents SayiRBtn As RadioButton
    Friend WithEvents VeriTBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents QRPBox As PictureBox
    Friend WithEvents OlusturBtn As Button
    Friend WithEvents KaydetBtn As Button
    Friend WithEvents YazdirBtn As Button
    Friend WithEvents OkuBtn As Button
    Friend WithEvents QRKodSaveFD As SaveFileDialog
    Friend WithEvents QRKodOpenFD As OpenFileDialog
    Friend WithEvents QRKodPrintD As PrintDialog
    Friend WithEvents QRKodPDoc As Printing.PrintDocument
End Class
