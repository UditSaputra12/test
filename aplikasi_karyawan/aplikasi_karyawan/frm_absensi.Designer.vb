<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_absensi
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
        Me.components = New System.ComponentModel.Container
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.lbl_tgl_sekarang = New System.Windows.Forms.Label
        Me.Lbl_jam_sekarang = New System.Windows.Forms.Label
        Me.lbl_nik = New System.Windows.Forms.Label
        Me.lbl_info = New System.Windows.Forms.Label
        Me.txtnik = New System.Windows.Forms.TextBox
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(161, 169)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'lbl_tgl_sekarang
        '
        Me.lbl_tgl_sekarang.AutoSize = True
        Me.lbl_tgl_sekarang.Location = New System.Drawing.Point(215, 27)
        Me.lbl_tgl_sekarang.Name = "lbl_tgl_sekarang"
        Me.lbl_tgl_sekarang.Size = New System.Drawing.Size(39, 13)
        Me.lbl_tgl_sekarang.TabIndex = 1
        Me.lbl_tgl_sekarang.Text = "Label1"
        '
        'Lbl_jam_sekarang
        '
        Me.Lbl_jam_sekarang.AutoSize = True
        Me.Lbl_jam_sekarang.Location = New System.Drawing.Point(215, 73)
        Me.Lbl_jam_sekarang.Name = "Lbl_jam_sekarang"
        Me.Lbl_jam_sekarang.Size = New System.Drawing.Size(39, 13)
        Me.Lbl_jam_sekarang.TabIndex = 2
        Me.Lbl_jam_sekarang.Text = "Label2"
        '
        'lbl_nik
        '
        Me.lbl_nik.AutoSize = True
        Me.lbl_nik.Location = New System.Drawing.Point(215, 118)
        Me.lbl_nik.Name = "lbl_nik"
        Me.lbl_nik.Size = New System.Drawing.Size(39, 13)
        Me.lbl_nik.TabIndex = 3
        Me.lbl_nik.Text = "Label3"
        '
        'lbl_info
        '
        Me.lbl_info.AutoSize = True
        Me.lbl_info.Location = New System.Drawing.Point(215, 154)
        Me.lbl_info.Name = "lbl_info"
        Me.lbl_info.Size = New System.Drawing.Size(39, 13)
        Me.lbl_info.TabIndex = 4
        Me.lbl_info.Text = "Label4"
        '
        'txtnik
        '
        Me.txtnik.Location = New System.Drawing.Point(21, 202)
        Me.txtnik.Name = "txtnik"
        Me.txtnik.Size = New System.Drawing.Size(161, 20)
        Me.txtnik.TabIndex = 5
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'frm_absensi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(655, 449)
        Me.Controls.Add(Me.txtnik)
        Me.Controls.Add(Me.lbl_info)
        Me.Controls.Add(Me.lbl_nik)
        Me.Controls.Add(Me.Lbl_jam_sekarang)
        Me.Controls.Add(Me.lbl_tgl_sekarang)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "frm_absensi"
        Me.Text = "absensi"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lbl_tgl_sekarang As System.Windows.Forms.Label
    Friend WithEvents Lbl_jam_sekarang As System.Windows.Forms.Label
    Friend WithEvents lbl_nik As System.Windows.Forms.Label
    Friend WithEvents lbl_info As System.Windows.Forms.Label
    Friend WithEvents txtnik As System.Windows.Forms.TextBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
End Class
