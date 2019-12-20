Public Class frm_Lembur

    Private Sub btn_simpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_simpan.Click
        konek()
        strcon = "INSERT INTO t_lembur " _
        + "VALUES (''," _
        + "'" & TxtIdLembur.Text & "'," _
        + "'" & TxtNik.Text & "')" _
        + "'" & TxtNamaKaryawan.Text & "'," _
        + "'" & Cmbidjabatan.Text & "'," _
        + "'" & dtplembur.Text & "'," _
        + "'" & TxtJumjamLembur.Text & "'," _
        + "'" & TxtUangLembur.Text & "'," _
        + "'" & TxtTotalUangLembur.Text & "'"


        ' MsgBox(strcon)
        Dim cmd As New Odbc.OdbcCommand
        cmd.Connection = conn
        cmd.CommandText = strcon
        cmd.ExecuteNonQuery()
        conn.Close()
        MsgBox("Date Berhasil Disimpan", MsgBoxStyle.Information)

    End Sub

    Private Sub btn_perbaiki_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_perbaiki.Click
        Call konek()
        strcon = "UPDATE t_lembur SET " _
   + "nik = '" & TxtNik.Text & "'," _
   + "nama_karyawan = '" & TxtNamaKaryawan.Text & "'," _
   + "id_jabatan = '" & Cmbidjabatan.Text & "'," _
    + "tgl_lembur = '" & dtplembur.Text & "'," _
    + "jum_jam_lembur = '" & TxtJumjamLembur.Text & "'," _
    + "uang_lembur = '" & TxtUangLembur.Text & "'," _
    + "total_uang_lembur = '" & TxtUangLembur.Text & "'," _
   + " WHERE id_lembur= '" & TxtIdLembur.Text & "'"
        Dim cmd As New Odbc.OdbcCommand
        cmd.Connection = conn
        cmd.CommandText = strcon
        cmd.ExecuteNonQuery()
        conn.Close()
        MsgBox("Data Berhasil Diupdate", vbInformation)
        'Call tampil_data()
    End Sub

    Private Sub btn_hapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_hapus.Click

    End Sub

    Private Sub frm_Lembur_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        konek()
        da = New Odbc.OdbcDataAdapter("select * FROM  t_lembur", conn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "t_lembur")
        DataGridView1.DataSource = (ds.Tables("t_lembur"))
    End Sub
    Private Sub set_editjabatan(ByVal x As Integer)
        Try
            TxtIdLembur.Text = DataGridView1.Rows(x).Cells(0).Value
            TxtNik.Text = DataGridView1.Rows(x).Cells(1).Value
            Cmbidjabatan.Text = DataGridView1.Rows(x).Cells(2).Value
            dtplembur.Text = DataGridView1.Rows(x).Cells(3).Value
            TxtJumjamLembur.Text = DataGridView1.Rows(x).Cells(4).Value
            TxtUangLembur.Text = DataGridView1.Rows(x).Cells(5).Value
            TxtTotalUangLembur.Text = DataGridView1.Rows(x).Cells(6).Value
            TxtUangLembur.Text = DataGridView1.Rows(x).Cells(7).Value
        Catch ex As Exception
        End Try
    End Sub

    Private Sub TxtIdLembur_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtIdLembur.TextChanged

    End Sub

    Private Sub TxtNik_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtNik.KeyPress
        If (e.KeyChar = Chr(13)) Then
            konek()
            cdm = New Odbc.OdbcCommand("SELECT * FROM t_karyawan WHERE nik ='" & "'", conn)
            rd = cdm.ExecuteReader
            If rd.Read Then
                TxtNamaKaryawan.Text = rd(1).ToString
                Cmbidjabatan.Text = rd(12).ToString
            Else
                'Exit Sub
                MsgBox("Tidak ditemukan")
                TxtNik.Focus()
                TxtNik.Clear()
            End If
            'txtNamaKaryawan.focus()
        End If
    End Sub

    Private Sub TxtNik_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtNik.TextChanged


    End Sub

    Private Sub TxtUangLembur_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtUangLembur.TextChanged
        TxtTotalUangLembur.Text = Val(TxtJumjamLembur.Text) * Val(TxtTotalUangLembur.Text)
    End Sub

    Private Sub TxtJumjamLembur_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtJumjamLembur.TextChanged
        TxtTotalUangLembur.Text = Val(TxtJumjamLembur.Text) * Val(TxtTotalUangLembur.Text)
    End Sub
End Class