<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_gaji
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.txtnoslip = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.cmbidjabatan = New System.Windows.Forms.ComboBox
        Me.TxtNik = New System.Windows.Forms.TextBox
        Me.TxtNamaJabatan = New System.Windows.Forms.TextBox
        Me.Txtgajipokok = New System.Windows.Forms.TextBox
        Me.TxtTunjangan = New System.Windows.Forms.TextBox
        Me.Txtuanglembur = New System.Windows.Forms.TextBox
        Me.Txtpotbpjsket = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.Txtpotbpjskes = New System.Windows.Forms.TextBox
        Me.Txtpotlain2 = New System.Windows.Forms.TextBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.TxtNoRekening = New System.Windows.Forms.TextBox
        Me.TxtNamaRekening = New System.Windows.Forms.TextBox
        Me.TxtNamaBank = New System.Windows.Forms.TextBox
        Me.TxtTotalGaji = New System.Windows.Forms.TextBox
        Me.btn_keluar = New System.Windows.Forms.Button
        Me.btn_perbaiki = New System.Windows.Forms.Button
        Me.btn_hapus = New System.Windows.Forms.Button
        Me.btn_simpan = New System.Windows.Forms.Button
        Me.Txtidgaji = New System.Windows.Forms.TextBox
        Me.dtptanggalgaji = New System.Windows.Forms.DateTimePicker
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(28, 455)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(829, 120)
        Me.DataGridView1.TabIndex = 18
        '
        'txtnoslip
        '
        Me.txtnoslip.Location = New System.Drawing.Point(189, 47)
        Me.txtnoslip.Name = "txtnoslip"
        Me.txtnoslip.Size = New System.Drawing.Size(155, 20)
        Me.txtnoslip.TabIndex = 14
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(25, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 16)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "No slip"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(25, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 16)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "ID Gaji"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(25, 80)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 16)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Nik"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(25, 132)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(0, 16)
        Me.Label4.TabIndex = 20
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(25, 141)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(83, 16)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "ID Jabatan"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(25, 109)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(63, 16)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "Tgl Gaji"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(25, 178)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(113, 16)
        Me.Label7.TabIndex = 23
        Me.Label7.Text = "Nama Jabatan "
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(31, 178)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(0, 16)
        Me.Label8.TabIndex = 24
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(25, 380)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(92, 16)
        Me.Label9.TabIndex = 25
        Me.Label9.Text = "Pot Bpjs Ket"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(25, 305)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(100, 16)
        Me.Label10.TabIndex = 26
        Me.Label10.Text = "Uang Lembur"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(25, 259)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(81, 16)
        Me.Label11.TabIndex = 27
        Me.Label11.Text = "Tunjangan"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(25, 214)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(84, 16)
        Me.Label12.TabIndex = 28
        Me.Label12.Text = "Gaji Pokok"
        '
        'cmbidjabatan
        '
        Me.cmbidjabatan.FormattingEnabled = True
        Me.cmbidjabatan.Location = New System.Drawing.Point(189, 141)
        Me.cmbidjabatan.Name = "cmbidjabatan"
        Me.cmbidjabatan.Size = New System.Drawing.Size(171, 21)
        Me.cmbidjabatan.TabIndex = 29
        '
        'TxtNik
        '
        Me.TxtNik.Location = New System.Drawing.Point(189, 80)
        Me.TxtNik.Name = "TxtNik"
        Me.TxtNik.Size = New System.Drawing.Size(155, 20)
        Me.TxtNik.TabIndex = 30
        '
        'TxtNamaJabatan
        '
        Me.TxtNamaJabatan.Location = New System.Drawing.Point(189, 178)
        Me.TxtNamaJabatan.Name = "TxtNamaJabatan"
        Me.TxtNamaJabatan.Size = New System.Drawing.Size(155, 20)
        Me.TxtNamaJabatan.TabIndex = 32
        '
        'Txtgajipokok
        '
        Me.Txtgajipokok.Location = New System.Drawing.Point(189, 213)
        Me.Txtgajipokok.Name = "Txtgajipokok"
        Me.Txtgajipokok.Size = New System.Drawing.Size(155, 20)
        Me.Txtgajipokok.TabIndex = 33
        '
        'TxtTunjangan
        '
        Me.TxtTunjangan.Location = New System.Drawing.Point(189, 255)
        Me.TxtTunjangan.Name = "TxtTunjangan"
        Me.TxtTunjangan.Size = New System.Drawing.Size(155, 20)
        Me.TxtTunjangan.TabIndex = 34
        '
        'Txtuanglembur
        '
        Me.Txtuanglembur.Location = New System.Drawing.Point(189, 304)
        Me.Txtuanglembur.Name = "Txtuanglembur"
        Me.Txtuanglembur.Size = New System.Drawing.Size(155, 20)
        Me.Txtuanglembur.TabIndex = 35
        '
        'Txtpotbpjsket
        '
        Me.Txtpotbpjsket.Location = New System.Drawing.Point(189, 380)
        Me.Txtpotbpjsket.Name = "Txtpotbpjsket"
        Me.Txtpotbpjsket.Size = New System.Drawing.Size(155, 20)
        Me.Txtpotbpjsket.TabIndex = 36
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(29, 342)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(96, 16)
        Me.Label13.TabIndex = 37
        Me.Label13.Text = "Pot Bpjs Kes"
        '
        'Txtpotbpjskes
        '
        Me.Txtpotbpjskes.Location = New System.Drawing.Point(189, 342)
        Me.Txtpotbpjskes.Name = "Txtpotbpjskes"
        Me.Txtpotbpjskes.Size = New System.Drawing.Size(155, 20)
        Me.Txtpotbpjskes.TabIndex = 38
        '
        'Txtpotlain2
        '
        Me.Txtpotlain2.Location = New System.Drawing.Point(600, 19)
        Me.Txtpotlain2.Name = "Txtpotlain2"
        Me.Txtpotlain2.Size = New System.Drawing.Size(155, 20)
        Me.Txtpotlain2.TabIndex = 39
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(407, 19)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(94, 16)
        Me.Label14.TabIndex = 40
        Me.Label14.Text = "Pot Lain-lain"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(407, 51)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(98, 16)
        Me.Label15.TabIndex = 41
        Me.Label15.Text = "No Rekening"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(407, 96)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(119, 16)
        Me.Label16.TabIndex = 42
        Me.Label16.Text = "Nama Rekening"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(407, 146)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(88, 16)
        Me.Label17.TabIndex = 43
        Me.Label17.Text = "Nama Bank"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(407, 182)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(76, 16)
        Me.Label18.TabIndex = 44
        Me.Label18.Text = "Total Gaji"
        '
        'TxtNoRekening
        '
        Me.TxtNoRekening.Location = New System.Drawing.Point(600, 51)
        Me.TxtNoRekening.Name = "TxtNoRekening"
        Me.TxtNoRekening.Size = New System.Drawing.Size(155, 20)
        Me.TxtNoRekening.TabIndex = 45
        '
        'TxtNamaRekening
        '
        Me.TxtNamaRekening.Location = New System.Drawing.Point(600, 92)
        Me.TxtNamaRekening.Name = "TxtNamaRekening"
        Me.TxtNamaRekening.Size = New System.Drawing.Size(155, 20)
        Me.TxtNamaRekening.TabIndex = 46
        '
        'TxtNamaBank
        '
        Me.TxtNamaBank.Location = New System.Drawing.Point(600, 141)
        Me.TxtNamaBank.Name = "TxtNamaBank"
        Me.TxtNamaBank.Size = New System.Drawing.Size(155, 20)
        Me.TxtNamaBank.TabIndex = 47
        '
        'TxtTotalGaji
        '
        Me.TxtTotalGaji.Location = New System.Drawing.Point(600, 182)
        Me.TxtTotalGaji.Name = "TxtTotalGaji"
        Me.TxtTotalGaji.Size = New System.Drawing.Size(155, 20)
        Me.TxtTotalGaji.TabIndex = 48
        '
        'btn_keluar
        '
        Me.btn_keluar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_keluar.Location = New System.Drawing.Point(570, 316)
        Me.btn_keluar.Name = "btn_keluar"
        Me.btn_keluar.Size = New System.Drawing.Size(113, 46)
        Me.btn_keluar.TabIndex = 53
        Me.btn_keluar.Text = "Keluar"
        Me.btn_keluar.UseVisualStyleBackColor = True
        '
        'btn_perbaiki
        '
        Me.btn_perbaiki.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_perbaiki.Location = New System.Drawing.Point(570, 242)
        Me.btn_perbaiki.Name = "btn_perbaiki"
        Me.btn_perbaiki.Size = New System.Drawing.Size(113, 46)
        Me.btn_perbaiki.TabIndex = 52
        Me.btn_perbaiki.Text = "Perbaiki"
        Me.btn_perbaiki.UseVisualStyleBackColor = True
        '
        'btn_hapus
        '
        Me.btn_hapus.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_hapus.Location = New System.Drawing.Point(410, 316)
        Me.btn_hapus.Name = "btn_hapus"
        Me.btn_hapus.Size = New System.Drawing.Size(113, 46)
        Me.btn_hapus.TabIndex = 51
        Me.btn_hapus.Text = "Hapus"
        Me.btn_hapus.UseVisualStyleBackColor = True
        '
        'btn_simpan
        '
        Me.btn_simpan.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_simpan.Location = New System.Drawing.Point(410, 242)
        Me.btn_simpan.Name = "btn_simpan"
        Me.btn_simpan.Size = New System.Drawing.Size(113, 46)
        Me.btn_simpan.TabIndex = 50
        Me.btn_simpan.Text = "Simpan"
        Me.btn_simpan.UseVisualStyleBackColor = True
        '
        'Txtidgaji
        '
        Me.Txtidgaji.Location = New System.Drawing.Point(189, 11)
        Me.Txtidgaji.Name = "Txtidgaji"
        Me.Txtidgaji.Size = New System.Drawing.Size(155, 20)
        Me.Txtidgaji.TabIndex = 54
        '
        'dtptanggalgaji
        '
        Me.dtptanggalgaji.Location = New System.Drawing.Point(189, 115)
        Me.dtptanggalgaji.Name = "dtptanggalgaji"
        Me.dtptanggalgaji.Size = New System.Drawing.Size(167, 20)
        Me.dtptanggalgaji.TabIndex = 55
        '
        'frm_gaji
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(946, 661)
        Me.Controls.Add(Me.dtptanggalgaji)
        Me.Controls.Add(Me.Txtidgaji)
        Me.Controls.Add(Me.btn_keluar)
        Me.Controls.Add(Me.btn_perbaiki)
        Me.Controls.Add(Me.btn_hapus)
        Me.Controls.Add(Me.btn_simpan)
        Me.Controls.Add(Me.TxtTotalGaji)
        Me.Controls.Add(Me.TxtNamaBank)
        Me.Controls.Add(Me.TxtNamaRekening)
        Me.Controls.Add(Me.TxtNoRekening)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Txtpotlain2)
        Me.Controls.Add(Me.Txtpotbpjskes)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Txtpotbpjsket)
        Me.Controls.Add(Me.Txtuanglembur)
        Me.Controls.Add(Me.TxtTunjangan)
        Me.Controls.Add(Me.Txtgajipokok)
        Me.Controls.Add(Me.TxtNamaJabatan)
        Me.Controls.Add(Me.TxtNik)
        Me.Controls.Add(Me.cmbidjabatan)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.txtnoslip)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frm_gaji"
        Me.Text = "frm_gaji"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents txtnoslip As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents cmbidjabatan As System.Windows.Forms.ComboBox
    Friend WithEvents TxtNik As System.Windows.Forms.TextBox
    Friend WithEvents TxtNamaJabatan As System.Windows.Forms.TextBox
    Friend WithEvents Txtgajipokok As System.Windows.Forms.TextBox
    Friend WithEvents TxtTunjangan As System.Windows.Forms.TextBox
    Friend WithEvents Txtuanglembur As System.Windows.Forms.TextBox
    Friend WithEvents Txtpotbpjsket As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Txtpotbpjskes As System.Windows.Forms.TextBox
    Friend WithEvents Txtpotlain2 As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents TxtNoRekening As System.Windows.Forms.TextBox
    Friend WithEvents TxtNamaRekening As System.Windows.Forms.TextBox
    Friend WithEvents TxtNamaBank As System.Windows.Forms.TextBox
    Friend WithEvents TxtTotalGaji As System.Windows.Forms.TextBox
    Friend WithEvents btn_keluar As System.Windows.Forms.Button
    Friend WithEvents btn_perbaiki As System.Windows.Forms.Button
    Friend WithEvents btn_hapus As System.Windows.Forms.Button
    Friend WithEvents btn_simpan As System.Windows.Forms.Button
    Friend WithEvents Txtidgaji As System.Windows.Forms.TextBox
    Friend WithEvents dtptanggalgaji As System.Windows.Forms.DateTimePicker
End Class
