<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_jabatan
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.txt_nama_jabatan = New System.Windows.Forms.TextBox
        Me.btn_simpan = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.txt_gaji_pokok = New System.Windows.Forms.TextBox
        Me.btn_hapus = New System.Windows.Forms.Button
        Me.btn_perbaiki = New System.Windows.Forms.Button
        Me.btn_keluar = New System.Windows.Forms.Button
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.txt_id = New System.Windows.Forms.TextBox
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(80, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(109, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nama Jabatan"
        '
        'txt_nama_jabatan
        '
        Me.txt_nama_jabatan.Location = New System.Drawing.Point(241, 58)
        Me.txt_nama_jabatan.Name = "txt_nama_jabatan"
        Me.txt_nama_jabatan.Size = New System.Drawing.Size(155, 20)
        Me.txt_nama_jabatan.TabIndex = 1
        '
        'btn_simpan
        '
        Me.btn_simpan.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_simpan.Location = New System.Drawing.Point(83, 164)
        Me.btn_simpan.Name = "btn_simpan"
        Me.btn_simpan.Size = New System.Drawing.Size(113, 46)
        Me.btn_simpan.TabIndex = 2
        Me.btn_simpan.Text = "Simpan"
        Me.btn_simpan.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(80, 98)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Gaji Pokok"
        '
        'txt_gaji_pokok
        '
        Me.txt_gaji_pokok.Location = New System.Drawing.Point(241, 98)
        Me.txt_gaji_pokok.Name = "txt_gaji_pokok"
        Me.txt_gaji_pokok.Size = New System.Drawing.Size(155, 20)
        Me.txt_gaji_pokok.TabIndex = 4
        '
        'btn_hapus
        '
        Me.btn_hapus.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_hapus.Location = New System.Drawing.Point(241, 164)
        Me.btn_hapus.Name = "btn_hapus"
        Me.btn_hapus.Size = New System.Drawing.Size(113, 46)
        Me.btn_hapus.TabIndex = 5
        Me.btn_hapus.Text = "Hapus"
        Me.btn_hapus.UseVisualStyleBackColor = True
        '
        'btn_perbaiki
        '
        Me.btn_perbaiki.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_perbaiki.Location = New System.Drawing.Point(401, 164)
        Me.btn_perbaiki.Name = "btn_perbaiki"
        Me.btn_perbaiki.Size = New System.Drawing.Size(113, 46)
        Me.btn_perbaiki.TabIndex = 6
        Me.btn_perbaiki.Text = "Perbaiki"
        Me.btn_perbaiki.UseVisualStyleBackColor = True
        '
        'btn_keluar
        '
        Me.btn_keluar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_keluar.Location = New System.Drawing.Point(561, 164)
        Me.btn_keluar.Name = "btn_keluar"
        Me.btn_keluar.Size = New System.Drawing.Size(113, 46)
        Me.btn_keluar.TabIndex = 7
        Me.btn_keluar.Text = "Keluar"
        Me.btn_keluar.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(74, 253)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(829, 181)
        Me.DataGridView1.TabIndex = 8
        '
        'txt_id
        '
        Me.txt_id.Location = New System.Drawing.Point(241, 22)
        Me.txt_id.Name = "txt_id"
        Me.txt_id.Size = New System.Drawing.Size(91, 20)
        Me.txt_id.TabIndex = 9
        Me.txt_id.Visible = False
        '
        'frm_jabatan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(931, 449)
        Me.Controls.Add(Me.txt_id)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btn_keluar)
        Me.Controls.Add(Me.btn_perbaiki)
        Me.Controls.Add(Me.btn_hapus)
        Me.Controls.Add(Me.txt_gaji_pokok)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btn_simpan)
        Me.Controls.Add(Me.txt_nama_jabatan)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frm_jabatan"
        Me.Text = "Data Jabatan"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_nama_jabatan As System.Windows.Forms.TextBox
    Friend WithEvents btn_simpan As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_gaji_pokok As System.Windows.Forms.TextBox
    Friend WithEvents btn_hapus As System.Windows.Forms.Button
    Friend WithEvents btn_perbaiki As System.Windows.Forms.Button
    Friend WithEvents btn_keluar As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents txt_id As System.Windows.Forms.TextBox
End Class
