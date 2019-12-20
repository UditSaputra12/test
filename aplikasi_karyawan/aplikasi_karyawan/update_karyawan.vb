Public Class update_karyawan
    Private Sub Btnupdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnupdate.Click
        strcon = "UPDATE t_karyawan SET " _
        + "nama = '" & txtnama.Text & "'," _
        + "tempat_lahir = '" & txttempatlahir.Text & "'," _
        + "tgl_lahir = '" & dtplahir.Text & "'," _
        + "agama = '" & cmbagama.Text & "'," _
        + "status = '" & cmbstatus.Text & "'," _
        + "kewarganegaraan = '" & cmbkewarganegaraan.Text & "'," _
        + "no_hp = '" & txtnohp.Text & "'," _
        + "email = '" & txtemail.Text & "'," _
        + "alamat = '" & txtalamat.Text & "'," _
        + "pendidikan_terakhir= '" & Cmbpendidikanterakhir.Text & "'," _
        + "pt_terakhir = '" & txtperguruantinggi.Text & "'," _
        + "jabatan = '" & txtjabatan.Text & "'," _
        + "tgl_masuk = '" & dtptanggalmasuk.Text & "'," _
        + "bagian = '" & txtbagian.Text & "'," _
        + "gaji = '" & txtgaji.Text & "'," _
        + "status_karyawan = '" & cmbstatuskaryawan.Text & "'," _
        + "status_kerja = '" & cmbstatuskerja.Text & "'" _
        + " WHERE nik = '" & txtnik.Text & "'"
        Dim cmd As New Odbc.OdbcCommand
        cmd.Connection = conn
        cmd.CommandText = strcon
        cmd.ExecuteNonQuery()
        conn.Close()
        MsgBox("Data Berhasil Diupdate", vbInformation)
        Call tampil_data()
        Form1.DataGridView1.Refresh()

        strcon = "UPDATE t_karyawan SET "
        Dim odm As New Odbc.OdbcCommand
        cdm.Connection = conn
        cdm.CommandText = strcon
        cdm.ExecuteNonQuery()
        conn.Close()
        MsgBox("Data Berhasil DiUpdate", vbInformation)
    End Sub

    Private Sub update_karyawan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call edit_karyawan()
        Call tampil_data()
    End Sub

    Sub tampil_data()
        txtNik.Enabled = False
        konek()
        cdm = New Odbc.OdbcCommand("SELECT * FROM t_karyawan WHERE nik ='" & txtnik.Text & "'", conn)
        rd = cdm.ExecuteReader
        If rd.Read Then
            txtNama.Text = rd(1).ToString
            txttempatlahir.Text = rd(2).ToString
            dtplahir.Text = rd(3).ToString
            cmbAgama.Text = rd(4).ToString
            cmbStatus.Text = rd(5).ToString
            cmbkewarganegaraan.Text = rd(6).ToString
            txtNoHp.Text = rd(7).ToString
            txtEmail.Text = rd(8).ToString
            txtAlamat.Text = rd(9).ToString
            Cmbpendidikanterakhir.Text = rd(10).ToString
            txtperguruantinggi.Text = rd(11).ToString
            txtJabatan.Text = rd(12).ToString
            dtptanggalmasuk.Text = rd(13).ToString
            txtBagian.Text = rd(14).ToString
            txtGaji.Text = rd(15).ToString
            cmbstatuskaryawan.Text = rd(16).ToString
            CmbStatusKerja.Text = rd(17).ToString
        Else
            Exit Sub
            MsgBox("Tidak ditemukan")
        End If
        'conn.Close()

    End Sub

    Sub edit_karyawan()
        txtnik.Enabled = False
        konek()
        cdm = New Odbc.OdbcCommand("SELECT * FROM t_karyawan WHERE nik ='" & txtnik.Text & "'", conn)
        rd = cdm.ExecuteReader
        If rd.Read Then
            txtnama.Text = rd(1).ToString
            txttempatlahir.Text = rd(2).ToString
            dtplahir.Text = rd(3).ToString
            cmbagama.Text = rd(4).ToString
            cmbstatus.Text = rd(5).ToString
            cmbkewarganegaraan.Text = rd(6).ToString
            txtnohp.Text = rd(7).ToString
            txtemail.Text = rd(8).ToString
            txtalamat.Text = rd(9).ToString
            Cmbpendidikanterakhir.Text = rd(10).ToString
            txtperguruantinggi.Text = rd(11).ToString
            txtjabatan.Text = rd(12).ToString
            dtptanggalmasuk.Text = rd(13).ToString
            txtbagian.Text = rd(14).ToString
            txtgaji.Text = rd(15).ToString
            cmbstatuskaryawan.Text = rd(16).ToString
            cmbstatuskerja.Text = rd(17).ToString
        Else
            Exit Sub
            MsgBox("Tidak ditemukan")
        End If
        conn.Close()

    End Sub

End Class