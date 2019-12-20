Imports System.Data.Odbc
Public Class frm_absensi

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        lbl_tgl_sekarang.Text = Format(Now, "yyyy-MM-dd")
        Lbl_jam_sekarang.Text = Format(Now, "HH:mm:ss")

    End Sub


    Private Sub lbl_nik_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbl_nik.Click
       
    End Sub

    Private Sub txtnik_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtnik.KeyPress
        Dim jam_masuk, jam_kerja As DateTime
        Dim jam_pulang As String
        Dim a1, a2 As String
        Dim tgl As DateTime

        If (e.KeyChar = Chr(13)) Then
            konek()
            strcon = "select * from t_karyawan where nik='" & txtnik.Text & "'"
            cdm = New OdbcCommand(strcon, conn)
            rd = cdm.ExecuteReader

            If rd.HasRows Then
                lbl_nik.Text = rd.Item("nik")
                PictureBox1.ImageLocation = rd.Item("lokasi_gambar")
                PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage

                '=========================code simpan================='
                jam_masuk = Format(Now, "HH:mm:ss")
                jam_kerja = "07:00:00"

                a1 = Format(Now, "HH:mm:ss")
                a2 = "07:00:00"

                jam_pulang = Format(Now, "HH:mm:ss")
                tgl = Format(Now, "yyyy-MM-dd")

                Dim selisih As TimeSpan = New TimeSpan
                selisih = jam_masuk - jam_kerja
                lbl_info.Text = selisih.ToString

                strcon = "Insert into t_absensi (id_absensi ,nik,jam_masuk,jam_kerja,tgl_kerja,jam_pulang,telat_masuk)values(?,?,?,?,?,?,?)"
                Dim mycomm As OdbcCommand = New OdbcCommand(strcon, conn)
                With mycomm.Parameters
                    .Add("?", OdbcType.VarChar, 20).Value = Microsoft.VisualBasic.Left(txtnik.Text, 3) & Format(Now, "yyMMdd-HHmmss")
                    .Add("?", OdbcType.VarChar, 20).Value = txtnik.Text.Trim
                    .Add("?", OdbcType.VarChar, 15).Value = a1
                    .Add("?", OdbcType.VarChar, 15).Value = a2
                    .Add("?", OdbcType.Date).Value = tgl
                    .Add("?", OdbcType.VarChar, 15).Value = jam_pulang
                    .Add("?", OdbcType.VarChar, 10).Value = selisih.ToString
                End With

                mycomm.ExecuteNonQuery()
                mycomm = Nothing
                MsgBox("Menyimpan", MsgBoxStyle.MsgBoxSetForeground, "Save")
                '========================End Kode Simpan===================
            Else
                txtnik.Clear()
                PictureBox1.Hide()
            End If
            PictureBox1.Visible = True

        End If

    End Sub

    Private Sub frm_absensi_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub lbl_info_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbl_info.Click

    End Sub

    Private Sub lbl_tgl_sekarang_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbl_tgl_sekarang.Click

    End Sub

    Private Sub txtnik_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtnik.TextChanged

    End Sub
End Class