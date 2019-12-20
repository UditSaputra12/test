Public Class frm_gaji

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub frm_gaji_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Call get_idjabatan()
        konek()
        da = New Odbc.OdbcDataAdapter("select * FROM  t_gaji", conn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "t_gaji")
        DataGridView1.DataSource = (ds.Tables("t_gaji"))
        Call auto_slip()
    End Sub
    Sub auto_slip()
        Dim no_slip As String = "TR" + Format(Now, "yyMMdd-hhmmss")
        txtnoslip.Text = no_slip
    End Sub
    Private Sub cmbidjabatan_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbidjabatan.SelectedIndexChanged
        konek()
        cdm = New Odbc.OdbcCommand("SELECT nama_jabatan,gaji_pokok FROM t_jabatan WHERE id_jabatan = '" & cmbidjabatan.Text & "'", conn)

        rd = cdm.ExecuteReader
        rd.Read()

        If rd.HasRows Then
            TxtNamaJabatan.Text = rd(0).ToString
            Txtgajipokok.Text = rd(1).ToString
        End If
        conn.Close()


    End Sub

    Private Sub btn_simpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_simpan.Click
        konek()
        strcon = "INSERT INTO t_gaji " _
        + "VALUES (''," _
        + "'" & Txtidgaji.Text & "'," _
        + "'" & txtnoslip.Text & "')" _
        + "'" & TxtNik.Text & "')" _
        + "'" & dtptanggalgaji.Text & "')" _
        + "'" & cmbidjabatan.Text & "')" _
        + "'" & TxtNamaJabatan.Text & "')" _
        + "'" & Txtgajipokok.Text & "')" _
        + "'" & TxtTunjangan.Text & "')" _
        + "'" & Txtuanglembur.Text & "')" _
        + "'" & Txtpotbpjskes.Text & "')" _
        + "'" & Txtpotbpjsket.Text & "')" _
        + "'" & Txtpotlain2.Text & "')" _
        + "'" & TxtNoRekening.Text & "')" _
        + "'" & TxtNamaBank.Text & "')" _
        + "'" & TxtTotalGaji.Text & "')"


        ' MsgBox(strcon)
        Dim cmd As New Odbc.OdbcCommand
        cmd.Connection = conn
        cmd.CommandText = strcon
        cmd.ExecuteNonQuery()
        conn.Close()
        ' MsgBox("Date Berhasil Disimpan", MsgBoxStyle.Information)
        Dim pesan As Integer
        pesan = MsgBox("Data Berhasil Disimpan, " + "Apakah Anda Akan mencetak Transaksi..?? " + txtnoslip.Text, vbExclamation + vbYes, "Cetak Transaksi")
        If pesan = vbNo Then
            Exit Sub
        Else
            'call cetak_slipGaji()
        End If
    End Sub

    Private Sub btn_perbaiki_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_perbaiki.Click
        Call konek()
        strcon = "UPDATE t_gaji SET " _
        + "id_gaji= '" & Txtidgaji.Text & "'," _
        + "no_slip= '" & txtnoslip.Text & "'," _
        + "nik= '" & TxtNik.Text & "'," _
        + "tgl_gaji= '" & dtptanggalgaji.Text & "'," _
        + "id_jabatan= '" & cmbidjabatan.Text & "'," _
        + "nama_jabatan'" & TxtNamaJabatan.Text & "'," _
        + "gaji_pokok= '" & Txtgajipokok.Text & "'," _
        + "tunjangan= '" & TxtTunjangan.Text & "'," _
        + "uang_lembur= '" & Txtuanglembur.Text & "'," _
        + "pot_npjs_kes= '" & Txtpotbpjskes.Text & "'," _
        + "pot_bpjs_ket= '" & Txtpotbpjsket.Text & "'," _
        + "pot_lain2= '" & Txtpotlain2.Text & "'," _
        + "no_rekening= '" & TxtNoRekening.Text & "'," _
        + "nama_bank= '" & TxtNamaBank.Text & "'," _
        + "'total_gaji= " & TxtTotalGaji.Text & "'" _
        + " WHERE id_gaji = '" & Txtidgaji.Text & "'"
        Dim cdm As New Odbc.OdbcCommand
        cdm.Connection = conn
        cdm.CommandText = strcon
        cdm.ExecuteNonQuery()
        conn.Close()
        MsgBox("Data Berhasil Diupdate", vbInformation)
        'Call tampil_data()
    End Sub
    Private Sub set_editgaji(ByVal x As Integer)
        Try
            Txtidgaji.Text = DataGridView1.Rows(x).Cells(0).Value
            txtnoslip.Text = DataGridView1.Rows(x).Cells(1).Value
            TxtNik.Text = DataGridView1.Rows(x).Cells(2).Value
            dtptanggalgaji.Text = DataGridView1.Rows(x).Cells(3).Value
            cmbidjabatan.Text = DataGridView1.Rows(x).Cells(4).Value
            TxtNamaJabatan.Text = DataGridView1.Rows(x).Cells(5).Value
            Txtgajipokok.Text = DataGridView1.Rows(x).Cells(6).Value
            TxtTunjangan.Text = DataGridView1.Rows(x).Cells(7).Value
            Txtuanglembur.Text = DataGridView1.Rows(x).Cells(8).Value
            Txtpotbpjskes.Text = DataGridView1.Rows(x).Cells(9).Value
            Txtpotbpjsket.Text = DataGridView1.Rows(x).Cells(10).Value
            Txtpotbpjsket.Text = DataGridView1.Rows(x).Cells(11).Value
            Txtpotlain2.Text = DataGridView1.Rows(x).Cells(12).Value
            TxtNoRekening.Text = DataGridView1.Rows(x).Cells(13).Value
            TxtNamaBank.Text = DataGridView1.Rows(x).Cells(14).Value
            TxtTotalGaji.Text = DataGridView1.Rows(x).Cells(15).Value
        Catch ex As Exception
        End Try
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        set_editgaji(e.RowIndex)
    End Sub
    Public Sub hitung_gaji()
        Dim jum_gaji As Integer
        Dim jum_potongan As Integer

        jum_gaji = Val(Txtgajipokok.Text) + Val(TxtTunjangan.Text) + Val(Txtuanglembur.Text)
        jum_potongan = Val(Txtpotbpjskes.Text) + Val(Txtpotbpjsket.Text) + Val(Txtpotlain2.Text)
        TxtTotalGaji.Text = jum_gaji - jum_potongan
    End Sub

    Private Sub Txtgajipokok_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Txtgajipokok.TextChanged
        hitung_gaji()

    End Sub

    Private Sub TxtTunjangan_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtTunjangan.TextChanged
        hitung_gaji()

    End Sub

    Private Sub Txtuanglembur_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Txtuanglembur.TextChanged
        hitung_gaji()

    End Sub

    Private Sub Txtpotbpjskes_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Txtpotbpjskes.TextChanged
        hitung_gaji()

    End Sub

    Private Sub Txtpotbpjsket_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Txtpotbpjsket.TextChanged
        hitung_gaji()

    End Sub

    Private Sub Txtpotlain2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Txtpotlain2.TextChanged
        hitung_gaji()

    End Sub

    Private Sub txtnoslip_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtnoslip.TextChanged

    End Sub

    Private Sub Txtidgaji_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Txtidgaji.TextChanged

    End Sub
End Class