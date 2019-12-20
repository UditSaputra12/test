<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class tambah_karyawan
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
        Me.txtnik = New System.Windows.Forms.TextBox
        Me.txtnama = New System.Windows.Forms.TextBox
        Me.txttempatlahir = New System.Windows.Forms.TextBox
        Me.cmbstatus = New System.Windows.Forms.ComboBox
        Me.cmbkewarganegaraan = New System.Windows.Forms.ComboBox
        Me.cmbagama = New System.Windows.Forms.ComboBox
        Me.txtnohp = New System.Windows.Forms.TextBox
        Me.dtplahir = New System.Windows.Forms.DateTimePicker
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.txtemail = New System.Windows.Forms.TextBox
        Me.txtalamat = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.Cmbpendidikanterakhir = New System.Windows.Forms.ComboBox
        Me.txtperguruantinggi = New System.Windows.Forms.TextBox
        Me.txtjabatan = New System.Windows.Forms.TextBox
        Me.dtptanggalmasuk = New System.Windows.Forms.DateTimePicker
        Me.txtbagian = New System.Windows.Forms.TextBox
        Me.txtgaji = New System.Windows.Forms.TextBox
        Me.cmbstatuskaryawan = New System.Windows.Forms.ComboBox
        Me.cmbstatuskerja = New System.Windows.Forms.ComboBox
        Me.Btnsimpan = New System.Windows.Forms.Button
        Me.PctGbr = New System.Windows.Forms.PictureBox
        Me.lblpath = New System.Windows.Forms.Label
        Me.btnpilih = New System.Windows.Forms.Button
        Me.txtNamaGbr = New System.Windows.Forms.TextBox
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        CType(Me.PctGbr, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtnik
        '
        Me.txtnik.Location = New System.Drawing.Point(138, 27)
        Me.txtnik.Name = "txtnik"
        Me.txtnik.Size = New System.Drawing.Size(81, 20)
        Me.txtnik.TabIndex = 0
        '
        'txtnama
        '
        Me.txtnama.Location = New System.Drawing.Point(138, 63)
        Me.txtnama.Name = "txtnama"
        Me.txtnama.Size = New System.Drawing.Size(81, 20)
        Me.txtnama.TabIndex = 1
        '
        'txttempatlahir
        '
        Me.txttempatlahir.Location = New System.Drawing.Point(138, 106)
        Me.txttempatlahir.Name = "txttempatlahir"
        Me.txttempatlahir.Size = New System.Drawing.Size(81, 20)
        Me.txttempatlahir.TabIndex = 2
        '
        'cmbstatus
        '
        Me.cmbstatus.FormattingEnabled = True
        Me.cmbstatus.Items.AddRange(New Object() {"sudah menikah", "menikah"})
        Me.cmbstatus.Location = New System.Drawing.Point(138, 215)
        Me.cmbstatus.Name = "cmbstatus"
        Me.cmbstatus.Size = New System.Drawing.Size(135, 21)
        Me.cmbstatus.TabIndex = 3
        '
        'cmbkewarganegaraan
        '
        Me.cmbkewarganegaraan.FormattingEnabled = True
        Me.cmbkewarganegaraan.Items.AddRange(New Object() {"WNI", "WNA"})
        Me.cmbkewarganegaraan.Location = New System.Drawing.Point(155, 242)
        Me.cmbkewarganegaraan.Name = "cmbkewarganegaraan"
        Me.cmbkewarganegaraan.Size = New System.Drawing.Size(135, 21)
        Me.cmbkewarganegaraan.TabIndex = 4
        '
        'cmbagama
        '
        Me.cmbagama.FormattingEnabled = True
        Me.cmbagama.Items.AddRange(New Object() {"Islam", "kristen", "Hindu", "budha", "kong hu cu"})
        Me.cmbagama.Location = New System.Drawing.Point(139, 188)
        Me.cmbagama.Name = "cmbagama"
        Me.cmbagama.Size = New System.Drawing.Size(115, 21)
        Me.cmbagama.TabIndex = 5
        '
        'txtnohp
        '
        Me.txtnohp.Location = New System.Drawing.Point(139, 279)
        Me.txtnohp.Name = "txtnohp"
        Me.txtnohp.Size = New System.Drawing.Size(116, 20)
        Me.txtnohp.TabIndex = 6
        '
        'dtplahir
        '
        Me.dtplahir.CustomFormat = "yyyy-MM-dd"
        Me.dtplahir.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtplahir.Location = New System.Drawing.Point(138, 145)
        Me.dtplahir.Name = "dtplahir"
        Me.dtplahir.Size = New System.Drawing.Size(230, 20)
        Me.dtplahir.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(38, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(26, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Nik"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(38, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Nama"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(38, 113)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Tempat Lahir"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(38, 152)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Tgl lahir"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(38, 196)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Agama"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(38, 223)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(43, 13)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Status"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(38, 250)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(109, 13)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Kewarganegaraan"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(38, 286)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(44, 13)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "No HP"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(40, 323)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(37, 13)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Email"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(40, 363)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(45, 13)
        Me.Label10.TabIndex = 17
        Me.Label10.Text = "Alamat"
        '
        'txtemail
        '
        Me.txtemail.Location = New System.Drawing.Point(138, 323)
        Me.txtemail.Name = "txtemail"
        Me.txtemail.Size = New System.Drawing.Size(116, 20)
        Me.txtemail.TabIndex = 18
        '
        'txtalamat
        '
        Me.txtalamat.Location = New System.Drawing.Point(138, 363)
        Me.txtalamat.Name = "txtalamat"
        Me.txtalamat.Size = New System.Drawing.Size(116, 20)
        Me.txtalamat.TabIndex = 19
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(475, 34)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(121, 13)
        Me.Label11.TabIndex = 20
        Me.Label11.Text = "Pendidikan Terakhir"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(475, 70)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(104, 13)
        Me.Label12.TabIndex = 21
        Me.Label12.Text = "Perguruan Tinggi"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(475, 113)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(49, 13)
        Me.Label13.TabIndex = 22
        Me.Label13.Text = "jabatan"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(475, 163)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(66, 13)
        Me.Label14.TabIndex = 23
        Me.Label14.Text = "Tgl Masuk"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(475, 215)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(46, 13)
        Me.Label15.TabIndex = 24
        Me.Label15.Text = "Bagian"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(475, 268)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(29, 13)
        Me.Label16.TabIndex = 25
        Me.Label16.Text = "Gaji"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(475, 312)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(102, 13)
        Me.Label17.TabIndex = 26
        Me.Label17.Text = "Status Karyawan"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(475, 355)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(76, 13)
        Me.Label18.TabIndex = 27
        Me.Label18.Text = "Status Kerja"
        '
        'Cmbpendidikanterakhir
        '
        Me.Cmbpendidikanterakhir.FormattingEnabled = True
        Me.Cmbpendidikanterakhir.Items.AddRange(New Object() {"SD", "SMP", "SMA", "D1", "D2", "D3", "S1", "S2", "S3"})
        Me.Cmbpendidikanterakhir.Location = New System.Drawing.Point(632, 34)
        Me.Cmbpendidikanterakhir.Name = "Cmbpendidikanterakhir"
        Me.Cmbpendidikanterakhir.Size = New System.Drawing.Size(135, 21)
        Me.Cmbpendidikanterakhir.TabIndex = 28
        '
        'txtperguruantinggi
        '
        Me.txtperguruantinggi.Location = New System.Drawing.Point(632, 70)
        Me.txtperguruantinggi.Name = "txtperguruantinggi"
        Me.txtperguruantinggi.Size = New System.Drawing.Size(116, 20)
        Me.txtperguruantinggi.TabIndex = 29
        '
        'txtjabatan
        '
        Me.txtjabatan.Location = New System.Drawing.Point(632, 110)
        Me.txtjabatan.Name = "txtjabatan"
        Me.txtjabatan.Size = New System.Drawing.Size(116, 20)
        Me.txtjabatan.TabIndex = 30
        '
        'dtptanggalmasuk
        '
        Me.dtptanggalmasuk.CustomFormat = "yyyy-MM-dd"
        Me.dtptanggalmasuk.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtptanggalmasuk.Location = New System.Drawing.Point(632, 163)
        Me.dtptanggalmasuk.Name = "dtptanggalmasuk"
        Me.dtptanggalmasuk.Size = New System.Drawing.Size(217, 20)
        Me.dtptanggalmasuk.TabIndex = 31
        '
        'txtbagian
        '
        Me.txtbagian.Location = New System.Drawing.Point(632, 220)
        Me.txtbagian.Name = "txtbagian"
        Me.txtbagian.Size = New System.Drawing.Size(116, 20)
        Me.txtbagian.TabIndex = 32
        '
        'txtgaji
        '
        Me.txtgaji.Location = New System.Drawing.Point(632, 279)
        Me.txtgaji.Name = "txtgaji"
        Me.txtgaji.Size = New System.Drawing.Size(116, 20)
        Me.txtgaji.TabIndex = 33
        '
        'cmbstatuskaryawan
        '
        Me.cmbstatuskaryawan.FormattingEnabled = True
        Me.cmbstatuskaryawan.Items.AddRange(New Object() {"Tetap", "Tidak Tetap"})
        Me.cmbstatuskaryawan.Location = New System.Drawing.Point(632, 315)
        Me.cmbstatuskaryawan.Name = "cmbstatuskaryawan"
        Me.cmbstatuskaryawan.Size = New System.Drawing.Size(135, 21)
        Me.cmbstatuskaryawan.TabIndex = 34
        '
        'cmbstatuskerja
        '
        Me.cmbstatuskerja.FormattingEnabled = True
        Me.cmbstatuskerja.Items.AddRange(New Object() {"Aktif", "Tidak Aktif"})
        Me.cmbstatuskerja.Location = New System.Drawing.Point(632, 355)
        Me.cmbstatuskerja.Name = "cmbstatuskerja"
        Me.cmbstatuskerja.Size = New System.Drawing.Size(135, 21)
        Me.cmbstatuskerja.TabIndex = 35
        '
        'Btnsimpan
        '
        Me.Btnsimpan.Location = New System.Drawing.Point(558, 401)
        Me.Btnsimpan.Name = "Btnsimpan"
        Me.Btnsimpan.Size = New System.Drawing.Size(219, 31)
        Me.Btnsimpan.TabIndex = 36
        Me.Btnsimpan.Text = "SIMPAN"
        Me.Btnsimpan.UseVisualStyleBackColor = True
        '
        'PctGbr
        '
        Me.PctGbr.Location = New System.Drawing.Point(138, 431)
        Me.PctGbr.Name = "PctGbr"
        Me.PctGbr.Size = New System.Drawing.Size(100, 50)
        Me.PctGbr.TabIndex = 37
        Me.PctGbr.TabStop = False
        '
        'lblpath
        '
        Me.lblpath.AutoSize = True
        Me.lblpath.Location = New System.Drawing.Point(136, 517)
        Me.lblpath.Name = "lblpath"
        Me.lblpath.Size = New System.Drawing.Size(52, 13)
        Me.lblpath.TabIndex = 38
        Me.lblpath.Text = "Label19"
        '
        'btnpilih
        '
        Me.btnpilih.Location = New System.Drawing.Point(138, 550)
        Me.btnpilih.Name = "btnpilih"
        Me.btnpilih.Size = New System.Drawing.Size(77, 35)
        Me.btnpilih.TabIndex = 39
        Me.btnpilih.Text = "pilih"
        Me.btnpilih.UseVisualStyleBackColor = True
        '
        'txtNamaGbr
        '
        Me.txtNamaGbr.Location = New System.Drawing.Point(139, 617)
        Me.txtNamaGbr.Name = "txtNamaGbr"
        Me.txtNamaGbr.Size = New System.Drawing.Size(56, 20)
        Me.txtNamaGbr.TabIndex = 40
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'tambah_karyawan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(923, 711)
        Me.Controls.Add(Me.txtNamaGbr)
        Me.Controls.Add(Me.btnpilih)
        Me.Controls.Add(Me.lblpath)
        Me.Controls.Add(Me.PctGbr)
        Me.Controls.Add(Me.Btnsimpan)
        Me.Controls.Add(Me.cmbstatuskerja)
        Me.Controls.Add(Me.cmbstatuskaryawan)
        Me.Controls.Add(Me.txtgaji)
        Me.Controls.Add(Me.txtbagian)
        Me.Controls.Add(Me.dtptanggalmasuk)
        Me.Controls.Add(Me.txtjabatan)
        Me.Controls.Add(Me.txtperguruantinggi)
        Me.Controls.Add(Me.Cmbpendidikanterakhir)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtalamat)
        Me.Controls.Add(Me.txtemail)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dtplahir)
        Me.Controls.Add(Me.txtnohp)
        Me.Controls.Add(Me.cmbagama)
        Me.Controls.Add(Me.cmbkewarganegaraan)
        Me.Controls.Add(Me.cmbstatus)
        Me.Controls.Add(Me.txttempatlahir)
        Me.Controls.Add(Me.txtnama)
        Me.Controls.Add(Me.txtnik)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.SystemColors.InfoText
        Me.Name = "tambah_karyawan"
        Me.Text = "tambah_karyawan"
        CType(Me.PctGbr, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtnik As System.Windows.Forms.TextBox
    Friend WithEvents txtnama As System.Windows.Forms.TextBox
    Friend WithEvents txttempatlahir As System.Windows.Forms.TextBox
    Friend WithEvents cmbstatus As System.Windows.Forms.ComboBox
    Friend WithEvents cmbkewarganegaraan As System.Windows.Forms.ComboBox
    Friend WithEvents cmbagama As System.Windows.Forms.ComboBox
    Friend WithEvents txtnohp As System.Windows.Forms.TextBox
    Friend WithEvents dtplahir As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtemail As System.Windows.Forms.TextBox
    Friend WithEvents txtalamat As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Cmbpendidikanterakhir As System.Windows.Forms.ComboBox
    Friend WithEvents txtperguruantinggi As System.Windows.Forms.TextBox
    Friend WithEvents txtjabatan As System.Windows.Forms.TextBox
    Friend WithEvents dtptanggalmasuk As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtbagian As System.Windows.Forms.TextBox
    Friend WithEvents txtgaji As System.Windows.Forms.TextBox
    Friend WithEvents cmbstatuskaryawan As System.Windows.Forms.ComboBox
    Friend WithEvents cmbstatuskerja As System.Windows.Forms.ComboBox
    Friend WithEvents Btnsimpan As System.Windows.Forms.Button
    Friend WithEvents PctGbr As System.Windows.Forms.PictureBox
    Friend WithEvents lblpath As System.Windows.Forms.Label
    Friend WithEvents btnpilih As System.Windows.Forms.Button
    Friend WithEvents txtNamaGbr As System.Windows.Forms.TextBox
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
End Class
