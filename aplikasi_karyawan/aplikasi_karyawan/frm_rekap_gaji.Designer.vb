<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_rekap_gaji
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
        Me.dtp_dari = New System.Windows.Forms.DateTimePicker
        Me.dari = New System.Windows.Forms.Label
        Me.dtp_sampai = New System.Windows.Forms.DateTimePicker
        Me.sampai = New System.Windows.Forms.Label
        Me.Btncetak = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'dtp_dari
        '
        Me.dtp_dari.CustomFormat = "yyyy-MM-dd"
        Me.dtp_dari.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_dari.Location = New System.Drawing.Point(58, 57)
        Me.dtp_dari.Name = "dtp_dari"
        Me.dtp_dari.Size = New System.Drawing.Size(147, 20)
        Me.dtp_dari.TabIndex = 0
        '
        'dari
        '
        Me.dari.AutoSize = True
        Me.dari.Location = New System.Drawing.Point(55, 31)
        Me.dari.Name = "dari"
        Me.dari.Size = New System.Drawing.Size(26, 13)
        Me.dari.TabIndex = 1
        Me.dari.Text = "Dari"
        '
        'dtp_sampai
        '
        Me.dtp_sampai.CustomFormat = "yyyy-MM-dd"
        Me.dtp_sampai.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_sampai.Location = New System.Drawing.Point(58, 128)
        Me.dtp_sampai.Name = "dtp_sampai"
        Me.dtp_sampai.Size = New System.Drawing.Size(147, 20)
        Me.dtp_sampai.TabIndex = 2
        '
        'sampai
        '
        Me.sampai.AutoSize = True
        Me.sampai.Location = New System.Drawing.Point(55, 98)
        Me.sampai.Name = "sampai"
        Me.sampai.Size = New System.Drawing.Size(42, 13)
        Me.sampai.TabIndex = 3
        Me.sampai.Text = "Sampai"
        '
        'Btncetak
        '
        Me.Btncetak.Location = New System.Drawing.Point(157, 182)
        Me.Btncetak.Name = "Btncetak"
        Me.Btncetak.Size = New System.Drawing.Size(107, 36)
        Me.Btncetak.TabIndex = 4
        Me.Btncetak.Text = "Cetak"
        Me.Btncetak.UseVisualStyleBackColor = True
        '
        'frm_rekap_gaji
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(313, 278)
        Me.Controls.Add(Me.Btncetak)
        Me.Controls.Add(Me.sampai)
        Me.Controls.Add(Me.dtp_sampai)
        Me.Controls.Add(Me.dari)
        Me.Controls.Add(Me.dtp_dari)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frm_rekap_gaji"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "cetak Rekap Gaji"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dtp_dari As System.Windows.Forms.DateTimePicker
    Friend WithEvents dari As System.Windows.Forms.Label
    Friend WithEvents dtp_sampai As System.Windows.Forms.DateTimePicker
    Friend WithEvents sampai As System.Windows.Forms.Label
    Friend WithEvents Btncetak As System.Windows.Forms.Button
End Class
