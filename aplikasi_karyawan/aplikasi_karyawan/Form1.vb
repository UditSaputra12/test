Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.ContextMenuStrip = ContextMenuStrip1
        konek()
        da = New Odbc.OdbcDataAdapter("select * FROM  t_karyawan", conn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "t_karyawan")
        DataGridView1.DataSource = (ds.Tables("t_karyawan"))
    End Sub
    Private Sub set_editkaryawan(ByVal x As Integer)
        Try
            update_karyawan.txtnik.Text = DataGridView1.Rows(x).Cells(0).Value
        Catch ex As Exception
        End Try
    End Sub


    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        
    End Sub

    Private Sub DataGridView1_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        set_editkaryawan(e.RowIndex)
        update_karyawan.Show()
    End Sub
End Class
