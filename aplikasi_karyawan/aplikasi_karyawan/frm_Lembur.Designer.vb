<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Lembur
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Lembur))
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.btn_keluar = New System.Windows.Forms.Button
        Me.btn_perbaiki = New System.Windows.Forms.Button
        Me.btn_hapus = New System.Windows.Forms.Button
        Me.btn_simpan = New System.Windows.Forms.Button
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.TxtNik = New System.Windows.Forms.TextBox
        Me.TxtNamaKaryawan = New System.Windows.Forms.TextBox
        Me.TxtJumjamLembur = New System.Windows.Forms.TextBox
        Me.TxtUangLembur = New System.Windows.Forms.TextBox
        Me.TxtTotalUangLembur = New System.Windows.Forms.TextBox
        Me.Cmbidjabatan = New System.Windows.Forms.ComboBox
        Me.dtplembur = New System.Windows.Forms.DateTimePicker
        Me.Label1 = New System.Windows.Forms.Label
        Me.TxtIdLembur = New System.Windows.Forms.TextBox
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(82, 84)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "NIK"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(82, 110)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(137, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Nama Karyawan"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(82, 148)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(98, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "ID Jabatan"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(360, 52)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(144, 20)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Tanggal Lemburr"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(361, 84)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(145, 20)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Jum Jam Lembur"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(361, 110)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(117, 20)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Uang Lembur"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(360, 148)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(162, 20)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Total Uang Lembur"
        '
        'btn_keluar
        '
        Me.btn_keluar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_keluar.Image = CType(resources.GetObject("btn_keluar.Image"), System.Drawing.Image)
        Me.btn_keluar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_keluar.Location = New System.Drawing.Point(245, 302)
        Me.btn_keluar.Name = "btn_keluar"
        Me.btn_keluar.Size = New System.Drawing.Size(113, 46)
        Me.btn_keluar.TabIndex = 57
        Me.btn_keluar.Text = "Keluar"
        Me.btn_keluar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_keluar.UseVisualStyleBackColor = True
        '
        'btn_perbaiki
        '
        Me.btn_perbaiki.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_perbaiki.Image = CType(resources.GetObject("btn_perbaiki.Image"), System.Drawing.Image)
        Me.btn_perbaiki.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_perbaiki.Location = New System.Drawing.Point(245, 228)
        Me.btn_perbaiki.Name = "btn_perbaiki"
        Me.btn_perbaiki.Size = New System.Drawing.Size(113, 46)
        Me.btn_perbaiki.TabIndex = 56
        Me.btn_perbaiki.Text = "Perbaiki"
        Me.btn_perbaiki.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_perbaiki.UseVisualStyleBackColor = True
        '
        'btn_hapus
        '
        Me.btn_hapus.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_hapus.Image = CType(resources.GetObject("btn_hapus.Image"), System.Drawing.Image)
        Me.btn_hapus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_hapus.Location = New System.Drawing.Point(85, 302)
        Me.btn_hapus.Name = "btn_hapus"
        Me.btn_hapus.Size = New System.Drawing.Size(113, 46)
        Me.btn_hapus.TabIndex = 55
        Me.btn_hapus.Text = "Hapus"
        Me.btn_hapus.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_hapus.UseVisualStyleBackColor = True
        '
        'btn_simpan
        '
        Me.btn_simpan.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_simpan.Image = CType(resources.GetObject("btn_simpan.Image"), System.Drawing.Image)
        Me.btn_simpan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_simpan.Location = New System.Drawing.Point(85, 228)
        Me.btn_simpan.Name = "btn_simpan"
        Me.btn_simpan.Size = New System.Drawing.Size(113, 46)
        Me.btn_simpan.TabIndex = 54
        Me.btn_simpan.Text = "Simpan"
        Me.btn_simpan.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_simpan.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(40, 397)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(697, 120)
        Me.DataGridView1.TabIndex = 58
        '
        'TxtNik
        '
        Me.TxtNik.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNik.Location = New System.Drawing.Point(225, 81)
        Me.TxtNik.Name = "TxtNik"
        Me.TxtNik.Size = New System.Drawing.Size(85, 21)
        Me.TxtNik.TabIndex = 59
        '
        'TxtNamaKaryawan
        '
        Me.TxtNamaKaryawan.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNamaKaryawan.Location = New System.Drawing.Point(225, 110)
        Me.TxtNamaKaryawan.Name = "TxtNamaKaryawan"
        Me.TxtNamaKaryawan.Size = New System.Drawing.Size(85, 21)
        Me.TxtNamaKaryawan.TabIndex = 60
        '
        'TxtJumjamLembur
        '
        Me.TxtJumjamLembur.Location = New System.Drawing.Point(539, 81)
        Me.TxtJumjamLembur.Name = "TxtJumjamLembur"
        Me.TxtJumjamLembur.Size = New System.Drawing.Size(85, 20)
        Me.TxtJumjamLembur.TabIndex = 63
        '
        'TxtUangLembur
        '
        Me.TxtUangLembur.Location = New System.Drawing.Point(539, 110)
        Me.TxtUangLembur.Name = "TxtUangLembur"
        Me.TxtUangLembur.Size = New System.Drawing.Size(85, 20)
        Me.TxtUangLembur.TabIndex = 64
        '
        'TxtTotalUangLembur
        '
        Me.TxtTotalUangLembur.Location = New System.Drawing.Point(539, 148)
        Me.TxtTotalUangLembur.Name = "TxtTotalUangLembur"
        Me.TxtTotalUangLembur.Size = New System.Drawing.Size(85, 20)
        Me.TxtTotalUangLembur.TabIndex = 65
        '
        'Cmbidjabatan
        '
        Me.Cmbidjabatan.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmbidjabatan.FormattingEnabled = True
        Me.Cmbidjabatan.Location = New System.Drawing.Point(225, 145)
        Me.Cmbidjabatan.Name = "Cmbidjabatan"
        Me.Cmbidjabatan.Size = New System.Drawing.Size(91, 23)
        Me.Cmbidjabatan.TabIndex = 67
        '
        'dtplembur
        '
        Me.dtplembur.Location = New System.Drawing.Point(539, 49)
        Me.dtplembur.Name = "dtplembur"
        Me.dtplembur.Size = New System.Drawing.Size(109, 20)
        Me.dtplembur.TabIndex = 68
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(82, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ID Lembur"
        '
        'TxtIdLembur
        '
        Me.TxtIdLembur.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtIdLembur.Location = New System.Drawing.Point(225, 46)
        Me.TxtIdLembur.Name = "TxtIdLembur"
        Me.TxtIdLembur.Size = New System.Drawing.Size(85, 21)
        Me.TxtIdLembur.TabIndex = 66
        '
        'frm_Lembur
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Maroon
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(945, 575)
        Me.Controls.Add(Me.dtplembur)
        Me.Controls.Add(Me.Cmbidjabatan)
        Me.Controls.Add(Me.TxtIdLembur)
        Me.Controls.Add(Me.TxtTotalUangLembur)
        Me.Controls.Add(Me.TxtUangLembur)
        Me.Controls.Add(Me.TxtJumjamLembur)
        Me.Controls.Add(Me.TxtNamaKaryawan)
        Me.Controls.Add(Me.TxtNik)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btn_keluar)
        Me.Controls.Add(Me.btn_perbaiki)
        Me.Controls.Add(Me.btn_hapus)
        Me.Controls.Add(Me.btn_simpan)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frm_Lembur"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btn_keluar As System.Windows.Forms.Button
    Friend WithEvents btn_perbaiki As System.Windows.Forms.Button
    Friend WithEvents btn_hapus As System.Windows.Forms.Button
    Friend WithEvents btn_simpan As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents TxtNik As System.Windows.Forms.TextBox
    Friend WithEvents TxtNamaKaryawan As System.Windows.Forms.TextBox
    Friend WithEvents TxtJumjamLembur As System.Windows.Forms.TextBox
    Friend WithEvents TxtUangLembur As System.Windows.Forms.TextBox
    Friend WithEvents TxtTotalUangLembur As System.Windows.Forms.TextBox
    Friend WithEvents Cmbidjabatan As System.Windows.Forms.ComboBox
    Friend WithEvents dtplembur As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtIdLembur As System.Windows.Forms.TextBox
End Class
