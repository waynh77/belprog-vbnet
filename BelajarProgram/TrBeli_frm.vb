Public Class TrBeli_frm
    Private Sub TrBeli_frm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        isiGridHead()
        DataGridView1.Columns("idtrans").Visible = False
        DataGridView1.Columns("id supplier").Visible = False
        DataGridView1.Columns("id user").Visible = False
        DataGridView1.CurrentCell = DataGridView1.Rows(0).Cells(1)
        isiDetail()
    End Sub

    Sub isiGridHead()
        sqLstr = "select top(100) * from view_headbeli order by [tanggal beli] desc"
        tabel = proses.executequery(sqLstr)
        DataGridView1.DataSource = tabel
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
    End Sub

    Private Sub ViewBeliDetailBindingSource_CurrentChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        With Beli_frm
            .MdiParent = Main_frm
            .Show()
            .Top = 0
            .Left = 0
            Me.Enabled = False
            .lblid.Text = "Tambah"
            .lbltgl.Text = Format(Now, "dd MMM yyyy")
        End With
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub DataGridView1_Click(sender As Object, e As EventArgs) Handles DataGridView1.Click
        isiDetail()
    End Sub

    Sub isiDetail()
        Dim idtr As Integer = DataGridView1.Item("idtrans", DataGridView1.CurrentRow.Index).Value
        sqLstr = "select * from view_belidetail where idtrans=" & idtr
        tabel = proses.executequery(sqLstr)
        DataGridView2.DataSource = tabel
    End Sub
End Class