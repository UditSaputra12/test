Public Class frm_menu

    Private Sub CetakLaporanToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CetakLaporanToolStripMenuItem.Click
        Form1.Show()
    End Sub

    Private Sub FileToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FileToolStripMenuItem.Click

    End Sub

    Private Sub LemburToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LemburToolStripMenuItem.Click
        frm_Lembur.Show()
    End Sub

    Private Sub JabatanToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles JabatanToolStripMenuItem.Click
        frm_jabatan.Show()
    End Sub

    Private Sub GajiToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GajiToolStripMenuItem.Click
        frm_gaji.Show()
    End Sub

    Private Sub CetakJabatanToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CetakJabatanToolStripMenuItem.Click
        frm_cetak_jabatan.Show()
    End Sub

    Private Sub RekapGajiToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RekapGajiToolStripMenuItem.Click
        frm_rekap_gaji.Show()
    End Sub

    Private Sub AbsenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AbsenToolStripMenuItem.Click
        frm_absensi.Show()
    End Sub

    Private Sub KeluarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KeluarToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub frm_menu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class