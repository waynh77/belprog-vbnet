Public Class Beli_frm
    Private Sub Beli_frm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet1.msSpl' table. You can move, or remove it, as needed.
        Me.MsSplTableAdapter.Fill(Me.DataSet1.msSpl)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
        TrBeli_frm.Enabled = True
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Enabled = False
        With beliDetail_frm
            .MdiParent = Main_frm
            .Show()
            .StartPosition = FormStartPosition.CenterScreen
        End With
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If DataGridView1.Rows.Count > 0 Then
            If lblid.Text = "Tambah" Then
                'save header
                sqLstr = "Insert into trbelihead([Tgl],[idSpl],[idUser],[Notes])values(" &
                    Aphostrophe(lbltgl.Text) & "," &
                    ComboBox1.SelectedValue & "," &
                    idUser & "," &
                    Aphostrophe(TextBox1.Text) & ")"
                proses.executenonquery(sqLstr)
                'save detail
                sqLstr = "select top(10)idtrans from trbelihead order by idtrans desc"
                tabel = proses.executequery(sqLstr)
                Dim idTrans As Integer = tabel.Rows(0).Item(0).ToString

                With DataGridView1
                    For i = 0 To .Rows.Count - 1
                        sqLstr = "insert into trbelidetail([idTrans]
      ,[idBrg]
      ,[Qty]
      ,[Harga]
      ,[Notes])values(" &
      idTrans & "," &
      .Rows(i).Cells("idbrg").Value & "," &
      .Rows(i).Cells("qty").Value & "," &
      .Rows(i).Cells("harga").Value & "," &
      Aphostrophe(.Rows(i).Cells("notes").Value) & ")"
                        proses.executenonquery(sqLstr)
                    Next
                    MsgBox("Berhasil tambah data")
                End With
                Me.Close()
                TrBeli_frm.Enabled = True
                TrBeli_frm.DataGridView1.Refresh()
            Else 'update

            End If
        Else
            MsgBox("Belum ada detail")
        End If
    End Sub
End Class