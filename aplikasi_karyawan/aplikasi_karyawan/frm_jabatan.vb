Public Class frm_jabatan

    Private Sub frm_jabatan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        konek()
        da = New Odbc.OdbcDataAdapter("select * FROM  t_jabatan", conn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "t_jabatan")
        DataGridView1.DataSource = (ds.Tables("t_jabatan"))
    End Sub

    Private Sub btn_simpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_simpan.Click
        konek()
        strcon = "INSERT INTO t_jabatan " _
        + "VALUES (''," _
        + "'" & txt_nama_jabatan.Text & "'," _
        + "'" & txt_gaji_pokok.Text & "')"

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
        strcon = "UPDATE t_jabatan SET " _
   + "nama_jabatan = '" & txt_nama_jabatan.Text & "'," _
   + "gaji_pokok = '" & txt_gaji_pokok.Text & "'" _
   + " WHERE id_jabatan = '" & txt_id.Text & "'"
        Dim cdm As New Odbc.OdbcCommand
        cdm.Connection = conn
        cdm.CommandText = strcon
        cdm.ExecuteNonQuery()
        conn.Close()
        MsgBox("Data Berhasil Diupdate", vbInformation)
        'Call tampil_data()
        
    End Sub

    Private Sub set_editjabatan(ByVal x As Integer)
        Try
            txt_id.Text = DataGridView1.Rows(x).Cells(0).Value
            txt_nama_jabatan.Text = DataGridView1.Rows(x).Cells(1).Value
            txt_gaji_pokok.Text = DataGridView1.Rows(x).Cells(2).Value
        Catch ex As Exception
        End Try
    End Sub

    Private Sub DataGridView1_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        set_editjabatan(e.RowIndex)
    End Sub



    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub btn_keluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_keluar.Click

    End Sub
End Class