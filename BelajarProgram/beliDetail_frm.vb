Public Class beliDetail_frm
    Private Sub beliDetail_frm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet1.msbrg' table. You can move, or remove it, as needed.
        Me.MsbrgTableAdapter.Fill(Me.DataSet1.msbrg)
        'TODO: This line of code loads data into the 'DataSet1.tbJenis' table. You can move, or remove it, as needed.
        Me.TbJenisTableAdapter.Fill(Me.DataSet1.tbJenis)
        isiDetail()
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        If Not ComboBox2.SelectedValue = Nothing Then
            isiDetail()
        End If
    End Sub

    Sub isiDetail()
        sqLstr = "select * from view_barang where id=" & ComboBox2.SelectedValue
        tabel = proses.executequery(sqLstr)
        With tabel
            If .Rows.Count > 0 Then
                lblSatuan.Text = .Rows(0).Item("satuan").ToString
                lblJenis.Text = .Rows(0).Item("Jenis barang").ToString
                lblHrg.Text = .Rows(0).Item("harga").ToString
            End If
        End With
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Val(TextBox1.Text) > 0 Then
            With Beli_frm
                Dim baris As Integer = .DataGridView1.Rows.Count
                .DataGridView1.Rows.Add()
                .DataGridView1.Rows(baris).Cells("idbrg").Value = ComboBox2.SelectedValue
                .DataGridView1.Rows(baris).Cells("namabrg").Value = ComboBox2.Text
                .DataGridView1.Rows(baris).Cells("jenis").Value = lblJenis.Text
                .DataGridView1.Rows(baris).Cells("satuan").Value = lblSatuan.Text
                .DataGridView1.Rows(baris).Cells("harga").Value = lblHrg.Text
                .DataGridView1.Rows(baris).Cells("qty").Value = TextBox1.Text
                .DataGridView1.Rows(baris).Cells("notes").Value = TextBox2.Text
                .Enabled = True
            End With
            Me.Close()
        Else
            MsgBox("qty masih kosong")
        End If

    End Sub
End Class