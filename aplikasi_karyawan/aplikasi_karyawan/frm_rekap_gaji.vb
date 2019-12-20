Imports CrystalDecisions.CrystalReports.Engine
Public Class frm_rekap_gaji


    Private Sub Btncetak_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btncetak.Click
        Dim Report_detail As New ReportDocument
        Report_detail.load("..\..\cr_rekap_gaji.rpt")

        Report_detail.SetParameterValue("dari", dtp_dari.Text)
        Report_detail.SetParameterValue("sampai", dtp_sampai.Text)

        frm_cetak_rekapgaji.CrystalReportViewer1.ReportSource = Report_detail
        frm_cetak_rekapgaji.CrystalReportViewer1.Refresh()
        frm_cetak_rekapgaji.Show()
    End Sub

    Private Sub DateTimePicker1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtp_dari.ValueChanged

    End Sub
End Class