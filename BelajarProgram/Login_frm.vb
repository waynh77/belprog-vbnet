Public Class Login_frm
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If TextBox1.Text = "" Or TextBox2.Text = "" Then
                MsgBox("Input Kosong", MsgBoxStyle.Critical, "Cek Input")
            Else
            sqLstr = "select * from msuser where username=" & Aphostrophe(TextBox1.Text) &
                " and pass=" & Aphostrophe(TextBox2.Text)
            tabel = proses.executequery(sqLstr)
            If tabel.Rows.Count > 0 Then
                'MsgBox("Berhasil Login")
                namaUser = TextBox1.Text
                idUser = tabel.Rows(0).Item(0).ToString
                Main_frm.ToolStripStatusLabel1.Text = namaUser
                Main_frm.Show()
                Me.Hide()
            Else
                MsgBox("Gagal Login")
                End If
            End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub

    Private Sub Login_frm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Login_frm_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        TextBox1.Text = "admin"
        TextBox2.Text = "123"
    End Sub
End Class
