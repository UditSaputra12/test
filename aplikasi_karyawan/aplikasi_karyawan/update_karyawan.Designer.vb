<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class update_karyawan
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
        Me.Btnupdate = New System.Windows.Forms.Button
        Me.cmbstatuskerja = New System.Windows.Forms.ComboBox
        Me.cmbstatuskaryawan = New System.Windows.Forms.ComboBox
        Me.txtgaji = New System.Windows.Forms.TextBox
        Me.txtbagian = New System.Windows.Forms.TextBox
        Me.dtptanggalmasuk = New System.Windows.Forms.DateTimePicker
        Me.txtjabatan = New System.Windows.Forms.TextBox
        Me.txtperguruantinggi = New System.Windows.Forms.TextBox
        Me.Cmbpendidikanterakhir = New System.Windows.Forms.ComboBox
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.txtalamat = New System.Windows.Forms.TextBox
        Me.txtemail = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.dtplahir = New System.Windows.Forms.DateTimePicker
        Me.txtnohp = New System.Windows.Forms.TextBox
        Me.cmbagama = New System.Windows.Forms.ComboBox
        Me.cmbkewarganegaraan = New System.Windows.Forms.ComboBox
        Me.cmbstatus = New System.Windows.Forms.ComboBox
        Me.txttempatlahir = New System.Windows.Forms.TextBox
        Me.txtnama = New System.Windows.Forms.TextBox
        Me.txtnik = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'Btnupdate
        '
        Me.Btnupdate.Location = New System.Drawing.Point(617, 465)
        Me.Btnupdate.Name = "Btnupdate"
        Me.Btnupdate.Size = New System.Drawing.Size(219, 31)
        Me.Btnupdate.TabIndex = 73
        Me.Btnupdate.Text = "UPDATE"
        Me.Btnupdate.UseVisualStyleBackColor = True
        '
        'cmbstatuskerja
        '
        Me.cmbstatuskerja.FormattingEnabled = True
        Me.cmbstatuskerja.Items.AddRange(New Object() {"Aktif", "Tidak Aktif"})
        Me.cmbstatuskerja.Location = New System.Drawing.Point(691, 419)
        Me.cmbstatuskerja.Name = "cmbstatuskerja"
        Me.cmbstatuskerja.Size = New System.Drawing.Size(135, 21)
        Me.cmbstatuskerja.TabIndex = 72
        '
        'cmbstatuskaryawan
        '
        Me.cmbstatuskaryawan.FormattingEnabled = True
        Me.cmbstatuskaryawan.Items.AddRange(New Object() {"Tetap", "Tidak Tetap"})
        Me.cmbstatuskaryawan.Location = New System.Drawing.Point(691, 379)
        Me.cmbstatuskaryawan.Name = "cmbstatuskaryawan"
        Me.cmbstatuskaryawan.Size = New System.Drawing.Size(135, 21)
        Me.cmbstatuskaryawan.TabIndex = 71
        '
        'txtgaji
        '
        Me.txtgaji.Location = New System.Drawing.Point(691, 343)
        Me.txtgaji.Name = "txtgaji"
        Me.txtgaji.Size = New System.Drawing.Size(116, 20)
        Me.txtgaji.TabIndex = 70
        '
        'txtbagian
        '
        Me.txtbagian.Location = New System.Drawing.Point(691, 284)
        Me.txtbagian.Name = "txtbagian"
        Me.txtbagian.Size = New System.Drawing.Size(116, 20)
        Me.txtbagian.TabIndex = 69
        '
        'dtptanggalmasuk
        '
        Me.dtptanggalmasuk.CustomFormat = "yyyy-MM-dd"
        Me.dtptanggalmasuk.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtptanggalmasuk.Location = New System.Drawing.Point(691, 227)
        Me.dtptanggalmasuk.Name = "dtptanggalmasuk"
        Me.dtptanggalmasuk.Size = New System.Drawing.Size(217, 20)
        Me.dtptanggalmasuk.TabIndex = 68
        '
        'txtjabatan
        '
        Me.txtjabatan.Location = New System.Drawing.Point(691, 174)
        Me.txtjabatan.Name = "txtjabatan"
        Me.txtjabatan.Size = New System.Drawing.Size(116, 20)
        Me.txtjabatan.TabIndex = 67
        '
        'txtperguruantinggi
        '
        Me.txtperguruantinggi.Location = New System.Drawing.Point(691, 134)
        Me.txtperguruantinggi.Name = "txtperguruantinggi"
        Me.txtperguruantinggi.Size = New System.Drawing.Size(116, 20)
        Me.txtperguruantinggi.TabIndex = 66
        '
        'Cmbpendidikanterakhir
        '
        Me.Cmbpendidikanterakhir.FormattingEnabled = True
        Me.Cmbpendidikanterakhir.Items.AddRange(New Object() {"SD", "SMP", "SMA", "D1", "D2", "D3", "S1", "S2", "S3"})
        Me.Cmbpendidikanterakhir.Location = New System.Drawing.Point(691, 98)
        Me.Cmbpendidikanterakhir.Name = "Cmbpendidikanterakhir"
        Me.Cmbpendidikanterakhir.Size = New System.Drawing.Size(135, 21)
        Me.Cmbpendidikanterakhir.TabIndex = 65
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(534, 419)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(64, 13)
        Me.Label18.TabIndex = 64
        Me.Label18.Text = "Status Kerja"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(534, 376)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(87, 13)
        Me.Label17.TabIndex = 63
        Me.Label17.Text = "Status Karyawan"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(534, 332)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(25, 13)
        Me.Label16.TabIndex = 62
        Me.Label16.Text = "Gaji"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(534, 279)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(40, 13)
        Me.Label15.TabIndex = 61
        Me.Label15.Text = "Bagian"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(534, 227)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(57, 13)
        Me.Label14.TabIndex = 60
        Me.Label14.Text = "Tgl Masuk"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(534, 177)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(42, 13)
        Me.Label13.TabIndex = 59
        Me.Label13.Text = "jabatan"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(534, 134)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(88, 13)
        Me.Label12.TabIndex = 58
        Me.Label12.Text = "Perguruan Tinggi"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(534, 98)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(102, 13)
        Me.Label11.TabIndex = 57
        Me.Label11.Text = "Pendidikan Terakhir"
        '
        'txtalamat
        '
        Me.txtalamat.Location = New System.Drawing.Point(197, 427)
        Me.txtalamat.Name = "txtalamat"
        Me.txtalamat.Size = New System.Drawing.Size(116, 20)
        Me.txtalamat.TabIndex = 56
        '
        'txtemail
        '
        Me.txtemail.Location = New System.Drawing.Point(197, 387)
        Me.txtemail.Name = "txtemail"
        Me.txtemail.Size = New System.Drawing.Size(116, 20)
        Me.txtemail.TabIndex = 55
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(99, 427)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(39, 13)
        Me.Label10.TabIndex = 54
        Me.Label10.Text = "Alamat"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(99, 387)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(32, 13)
        Me.Label9.TabIndex = 53
        Me.Label9.Text = "Email"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(97, 350)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(39, 13)
        Me.Label8.TabIndex = 52
        Me.Label8.Text = "No HP"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(97, 314)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(94, 13)
        Me.Label7.TabIndex = 51
        Me.Label7.Text = "Kewarganegaraan"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(97, 287)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(37, 13)
        Me.Label6.TabIndex = 50
        Me.Label6.Text = "Status"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(97, 260)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 13)
        Me.Label5.TabIndex = 49
        Me.Label5.Text = "Agama"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(97, 216)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 13)
        Me.Label4.TabIndex = 48
        Me.Label4.Text = "Tgl lahir"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(97, 177)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 13)
        Me.Label3.TabIndex = 47
        Me.Label3.Text = "Tempat Lahir"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(97, 134)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 46
        Me.Label2.Text = "Nama"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(97, 94)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(23, 13)
        Me.Label1.TabIndex = 45
        Me.Label1.Text = "Nik"
        '
        'dtplahir
        '
        Me.dtplahir.CustomFormat = "yyyy-MM-dd"
        Me.dtplahir.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtplahir.Location = New System.Drawing.Point(197, 209)
        Me.dtplahir.Name = "dtplahir"
        Me.dtplahir.Size = New System.Drawing.Size(230, 20)
        Me.dtplahir.TabIndex = 44
        '
        'txtnohp
        '
        Me.txtnohp.Location = New System.Drawing.Point(198, 343)
        Me.txtnohp.Name = "txtnohp"
        Me.txtnohp.Size = New System.Drawing.Size(116, 20)
        Me.txtnohp.TabIndex = 43
        '
        'cmbagama
        '
        Me.cmbagama.FormattingEnabled = True
        Me.cmbagama.Items.AddRange(New Object() {"Islam", "kristen", "Hindu", "budha", "kong hu cu"})
        Me.cmbagama.Location = New System.Drawing.Point(198, 252)
        Me.cmbagama.Name = "cmbagama"
        Me.cmbagama.Size = New System.Drawing.Size(115, 21)
        Me.cmbagama.TabIndex = 42
        '
        'cmbkewarganegaraan
        '
        Me.cmbkewarganegaraan.FormattingEnabled = True
        Me.cmbkewarganegaraan.Items.AddRange(New Object() {"WNI", "WNA"})
        Me.cmbkewarganegaraan.Location = New System.Drawing.Point(214, 306)
        Me.cmbkewarganegaraan.Name = "cmbkewarganegaraan"
        Me.cmbkewarganegaraan.Size = New System.Drawing.Size(135, 21)
        Me.cmbkewarganegaraan.TabIndex = 41
        '
        'cmbstatus
        '
        Me.cmbstatus.FormattingEnabled = True
        Me.cmbstatus.Items.AddRange(New Object() {"sudah menikah", "menikah"})
        Me.cmbstatus.Location = New System.Drawing.Point(197, 279)
        Me.cmbstatus.Name = "cmbstatus"
        Me.cmbstatus.Size = New System.Drawing.Size(135, 21)
        Me.cmbstatus.TabIndex = 40
        '
        'txttempatlahir
        '
        Me.txttempatlahir.Location = New System.Drawing.Point(197, 170)
        Me.txttempatlahir.Name = "txttempatlahir"
        Me.txttempatlahir.Size = New System.Drawing.Size(81, 20)
        Me.txttempatlahir.TabIndex = 39
        '
        'txtnama
        '
        Me.txtnama.Location = New System.Drawing.Point(197, 127)
        Me.txtnama.Name = "txtnama"
        Me.txtnama.Size = New System.Drawing.Size(81, 20)
        Me.txtnama.TabIndex = 38
        '
        'txtnik
        '
        Me.txtnik.Location = New System.Drawing.Point(197, 91)
        Me.txtnik.Name = "txtnik"
        Me.txtnik.Size = New System.Drawing.Size(81, 20)
        Me.txtnik.TabIndex = 37
        '
        'update_karyawan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1004, 586)
        Me.Controls.Add(Me.Btnupdate)
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
        Me.Name = "update_karyawan"
        Me.Text = "update_karyawan"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Btnupdate As System.Windows.Forms.Button
    Friend WithEvents cmbstatuskerja As System.Windows.Forms.ComboBox
    Friend WithEvents cmbstatuskaryawan As System.Windows.Forms.ComboBox
    Friend WithEvents txtgaji As System.Windows.Forms.TextBox
    Friend WithEvents txtbagian As System.Windows.Forms.TextBox
    Friend WithEvents dtptanggalmasuk As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtjabatan As System.Windows.Forms.TextBox
    Friend WithEvents txtperguruantinggi As System.Windows.Forms.TextBox
    Friend WithEvents Cmbpendidikanterakhir As System.Windows.Forms.ComboBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtalamat As System.Windows.Forms.TextBox
    Friend WithEvents txtemail As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtplahir As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtnohp As System.Windows.Forms.TextBox
    Friend WithEvents cmbagama As System.Windows.Forms.ComboBox
    Friend WithEvents cmbkewarganegaraan As System.Windows.Forms.ComboBox
    Friend WithEvents cmbstatus As System.Windows.Forms.ComboBox
    Friend WithEvents txttempatlahir As System.Windows.Forms.TextBox
    Friend WithEvents txtnama As System.Windows.Forms.TextBox
    Friend WithEvents txtnik As System.Windows.Forms.TextBox
End Class
